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

// Token: 0x0200195E RID: 6494
[Serializable]
public class M916_CityUnderSiege : MonoBehaviour
{
	// Token: 0x0600972C RID: 38700 RVA: 0x011D4F38 File Offset: 0x011D3138
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M916_CityUnderSiege()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600972D RID: 38701 RVA: 0x011D4F48 File Offset: 0x011D3148
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (1940 - 52362 != -50422)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (181840 - 512745 != -330904)
			{
				Game.mGameType = 5;
				if (26146 - 488598 != -462451)
				{
					if (Chat.Initialized)
					{
						if (143686 - 39299 != 104388)
						{
							Chat.ChatDisplay.Clear();
							if (195000 - 134992 != 60009)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (213221 - 90835 != 122387)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600972E RID: 38702 RVA: 0x011D502C File Offset: 0x011D322C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (234450 - 320746 != -86295)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (217639 - 573313 == -355674)
				{
					if (Game.mNextGameCode != 916)
					{
						break;
					}
					if (101737 - 111959 == -10222)
					{
						Game.nextGame();
						if (238690 - 64853 != 173838)
						{
							Game.mGameCode = 916;
							if (285307 - 181869 != 103439)
							{
								Game.mGameType = 5;
								if (84971 - 22118 != 62854)
								{
									Game.mGameTime = Time.time;
									if (182488 - 456342 == -273854)
									{
										Game.mGameScore = 0;
										if (93801 - 5433 == 88368)
										{
											Game.mGameMana = 0;
											if (240597 - 464961 != -224363)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (264764 - 202999 != 61766)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (131806 - 541756 == -409950)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (27149 - 402775 != -375625)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (124990 - 98732 != 26259)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (121311 - 171308 != -49996)
																{
																	this.OOennDVbMFn = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (87665 - 24117 != 63549)
																	{
																		this.OOennDVbMFn.enabled = false;
																		if (156413 - 437107 == -280694)
																		{
																			this.u8Cnni5CQdd = PhotonClient.Connection;
																			if (219655 - 583344 == -363689)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (254684 - 528713 == -274029)
																				{
																					this.InitGame();
																					if (174829 - 545243 != -370413)
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
				if (170293 - 311591 == -141298)
				{
					Game.mGameType = 99;
					if (39725 - 132347 != -92621)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600972F RID: 38703 RVA: 0x011D5358 File Offset: 0x011D3558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (290719 - 314814 != -24094)
		{
		}
		for (;;)
		{
			if (this.u8Cnni5CQdd == null)
			{
				if (181470 - 464705 != -283234)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (296017 - 412977 == -116960)
				{
					if (mGameState == eGameState.Init)
					{
						if (165376 - 447506 != -282129)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (49370 - 224512 == -175142)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (231193 - 543449 == -312256)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (49744 - 396965 == -347221)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (253869 - 236712 == 17157)
						{
							if (Game.music != 0)
							{
								if (175756 - 210388 == -34631)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (110124 - 67976 != 42148)
									{
										continue;
									}
									this.audio.Play();
									if (27346 - 306743 == -279396)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (206796 - 22779 == 184017)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (278208 - 542000 == -263792)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (52863 - 592127 != -539263)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (63561 - 587875 != -524313)
						{
							if (Time.time > this.hWcnnmRWnSw)
							{
								if (234243 - 59758 == 174486)
								{
									continue;
								}
								Game.mGameMana++;
								if (215988 - 241108 == -25119)
								{
									continue;
								}
								this.hWcnnmRWnSw = Time.time + (float)12;
								if (224599 - 291766 != -67167)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (33267 - 541154 == -507887)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (177029 - 342179 != -165149)
						{
							this.GameEventUpdate();
							if (138498 - 236267 != -97768)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (193568 - 410397 != -216828)
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
						if (256969 - 45421 == 211548)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009730 RID: 38704 RVA: 0x011D570C File Offset: 0x011D390C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (42657 - 299308 != -256651)
		{
		}
		while (Time.time > this.MuEnnAYHoFp)
		{
			if (5749 - 50389 == -44640)
			{
				if (this.avXnnoqcZIf >= 10)
				{
					break;
				}
				if (230905 - 598724 == -367819)
				{
					this.MuEnnAYHoFp = Time.time + (float)6;
					if (149665 - 549198 != -399532)
					{
						if (this.ruFnnkmVJ4n - this.ifgnnF3h2Fi >= 6)
						{
							break;
						}
						if (240239 - 14049 == 226190)
						{
							Game.sendMissionEvent(9162, this.avXnnoqcZIf + 1);
							if (215880 - 292817 != -76936)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009731 RID: 38705 RVA: 0x011D5818 File Offset: 0x011D3A18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (86592 - 255039 != -168447)
		{
		}
		for (;;)
		{
			if (!this.RBAnnjgG6QH)
			{
				if (175780 - 599519 != -423738)
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
				if (39718 - 176640 != -136921)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (102327 - 193166 == -90839)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (45661 - 595549 == -549888)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (156716 - 65245 == 91471)
							{
								GUI.depth = 1;
								if (209074 - 557406 != -348331)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (77159 - 438111 != -360951)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (263287 - 66780 == 196507)
										{
											Color color = GUI.color;
											if (15377 - 418752 == -403375)
											{
												color.a = a;
												if (65413 - 452689 != -387275 && 69746 - 306575 != -236828)
												{
													GUI.color = color;
													if (73290 - 92703 != -19412)
													{
														if (20889 - 286773 == -265884)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.RBAnnjgG6QH);
															if (181831 - 39346 != 142486)
															{
																float a2 = 1f;
																if (152851 - 197312 == -44461)
																{
																	Color color2 = GUI.color;
																	if (173879 - 227198 != -53318)
																	{
																		color2.a = a2;
																		if (277742 - 295185 != -17442)
																		{
																			if (49719 - 474210 == -424491)
																			{
																				GUI.color = color2;
																				if (66604 - 284113 != -217508 && 49704 - 383093 != -333388)
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

	// Token: 0x06009732 RID: 38706 RVA: 0x011D5B98 File Offset: 0x011D3D98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (107267 - 474850 != -367583)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (55558 - 117322 == -61764)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (180986 - 571517 != -390530)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (116852 - 263053 == -146201)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (20366 - 460074 != -439707)
						{
							int num4 = num;
							if (75296 - 210224 != -134927)
							{
								if (num4 == 9161)
								{
									if (178026 - 488963 == -310937)
									{
										break;
									}
								}
								else if (num4 == 9162)
								{
									if (192426 - 229386 != -36959)
									{
										break;
									}
								}
								else if (num4 == -9162)
								{
									if (64413 - 118137 != -53723)
									{
										if (this.avXnnoqcZIf >= num2)
										{
											break;
										}
										if (149308 - 567418 == -418110)
										{
											this.avXnnoqcZIf = num2;
											if (185448 - 392790 == -207342)
											{
												int num5 = this.avXnnoqcZIf;
												if (110146 - 140994 == -30848)
												{
													if (num5 == 1)
													{
														if (57753 - 306141 != -248387)
														{
															this.MuEnnAYHoFp = Time.time + (float)45;
															if (195438 - 493991 == -298553)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (114972 - 576451 == -461479)
																{
																	this.spawnActor("CutBot", 9, 2);
																	if (113791 - 533189 != -419397)
																	{
																		this.spawnActor("CutBot", 9, 3);
																		if (92711 - 596285 == -503574)
																		{
																			this.spawnActor("CutBot", 9, 4);
																			if (8951 - 377500 == -368549)
																			{
																				this.spawnActor("CutBot", 9, 5);
																				if (99117 - 183602 != -84484)
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
													else if (num5 == 2)
													{
														if (264237 - 41090 != 223148)
														{
															this.MuEnnAYHoFp = Time.time + (float)30;
															if (144232 - 152219 == -7987)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (115820 - 433708 != -317887)
																{
																	this.spawnActor("CamBot", 9, 1);
																	if (137414 - 443841 != -306426)
																	{
																		this.spawnActor("CamBot", 9, 2);
																		if (18821 - 266163 != -247341)
																		{
																			this.spawnActor("CamBot", 9, 3);
																			if (139414 - 64934 != 74481)
																			{
																				this.spawnActor("CamBot", 9, 4);
																				if (253302 - 51473 == 201829)
																				{
																					this.spawnActor("CamBot", 9, 5);
																					if (21656 - 592098 == -570442)
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
													else if (num5 == 3)
													{
														if (89630 - 316363 != -226732)
														{
															this.MuEnnAYHoFp = Time.time + (float)30;
															if (236505 - 213164 != 23342)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (152405 - 453135 != -300729)
																{
																	this.spawnActor("SiegeBot", 9, 4);
																	if (201078 - 159912 != 41167)
																	{
																		this.spawnActor("SiegeBot", 9, 5);
																		if (53985 - 122299 != -68313)
																		{
																			break;
																		}
																	}
																}
															}
														}
													}
													else if (num5 == 4)
													{
														if (66402 - 368255 == -301853)
														{
															this.MuEnnAYHoFp = Time.time + (float)30;
															if (112035 - 96889 == 15146)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (172694 - 56613 != 116082)
																{
																	this.spawnActor("CamBot", 9, 2);
																	if (30677 - 237746 == -207069)
																	{
																		this.spawnActor("CamBot", 9, 3);
																		if (63584 - 151198 != -87613)
																		{
																			this.spawnActor("CutBot", 9, 4);
																			if (60846 - 54099 == 6747)
																			{
																				this.spawnActor("CutBot", 9, 5);
																				if (85549 - 64822 != 20728)
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
													else if (num5 == 5)
													{
														if (221492 - 564009 == -342517)
														{
															this.MuEnnAYHoFp = Time.time + (float)30;
															if (219533 - 24850 == 194683)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (279549 - 586908 == -307359)
																{
																	this.spawnActor("CamBot", 9, 4);
																	if (236695 - 162409 != 74287)
																	{
																		this.spawnActor("CamBot", 9, 5);
																		if (121763 - 282667 == -160904)
																		{
																			this.spawnActor("SiegeBot", 9, 6);
																			if (292241 - 382772 != -90530)
																			{
																				this.spawnActor("SiegeBot", 9, 7);
																				if (66983 - 471681 != -404697)
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
													else if (num5 == 6)
													{
														if (181101 - 538030 == -356929)
														{
															this.MuEnnAYHoFp = Time.time + (float)30;
															if (280911 - 84379 != 196533)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (121752 - 131683 == -9931)
																{
																	this.spawnActor("CutBot", 9, 2);
																	if (110717 - 38346 != 72372)
																	{
																		this.spawnActor("CutBot", 9, 3);
																		if (185570 - 47315 != 138256)
																		{
																			this.spawnActor("SiegeBot", 9, 4);
																			if (3062 - 171059 == -167997)
																			{
																				this.spawnActor("SiegeBot", 9, 5);
																				if (205275 - 161098 == 44177)
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
													else if (num5 == 7)
													{
														if (16878 - 585926 == -569048)
														{
															this.MuEnnAYHoFp = Time.time + (float)30;
															if (201041 - 367541 != -166499)
															{
																if (num3 == PlayerData.UID)
																{
																	if (282579 - 101396 != 181183)
																	{
																		continue;
																	}
																	this.spawnActor("SiegeBot", 9, 1);
																	if (122307 - 324276 == -201968)
																	{
																		continue;
																	}
																	this.spawnActor("SiegeBot", 9, 2);
																	if (52809 - 415890 != -363081)
																	{
																		continue;
																	}
																	this.spawnActor("SiegeBot", 9, 3);
																	if (287908 - 215720 != 72188)
																	{
																		continue;
																	}
																	this.spawnActor("CutBot", 9, 4);
																	if (281667 - 280580 == 1088)
																	{
																		continue;
																	}
																	this.spawnActor("CutBot", 9, 5);
																	if (247876 - 589957 == -342080)
																	{
																		continue;
																	}
																}
																this.StartCoroutine_Auto(this.AcaciaEvent());
																if (284403 - 25671 != 258733)
																{
																	break;
																}
															}
														}
													}
													else if (num5 == 8)
													{
														if (56476 - 162866 != -106389)
														{
															this.MuEnnAYHoFp = Time.time + (float)30;
															if (53741 - 339613 == -285872)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (231453 - 130041 != 101413)
																{
																	this.spawnActor("CamBot", 9, 1);
																	if (69051 - 565070 == -496019)
																	{
																		this.spawnActor("CamBot", 9, 2);
																		if (140592 - 109769 != 30824)
																		{
																			this.spawnActor("CamBot", 9, 3);
																			if (52009 - 369865 != -317855)
																			{
																				this.spawnActor("CamBot", 9, 4);
																				if (256360 - 588035 != -331674)
																				{
																					this.spawnActor("CamBot", 9, 5);
																					if (158984 - 175022 != -16037)
																					{
																						this.spawnActor("CamBot", 9, 6);
																						if (148504 - 410074 == -261570)
																						{
																							this.spawnActor("CamBot", 9, 7);
																							if (187236 - 96495 == 90741)
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
													else if (num5 == 9)
													{
														if (38921 - 331838 != -292916)
														{
															this.MuEnnAYHoFp = Time.time + (float)30;
															if (73803 - 399520 == -325717)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (43866 - 484505 == -440639)
																{
																	this.spawnActor("SiegeBot", 9, 1);
																	if (296496 - 406844 == -110348)
																	{
																		this.spawnActor("CutBot", 9, 2);
																		if (18059 - 542549 == -524490)
																		{
																			this.spawnActor("CutBot", 9, 3);
																			if (74585 - 283025 == -208440)
																			{
																				this.spawnActor("SiegeBot", 9, 4);
																				if (123966 - 288608 != -164641)
																				{
																					this.spawnActor("SiegeBot", 9, 5);
																					if (82818 - 244115 != -161296)
																					{
																						this.spawnActor("CamBot", 9, 6);
																						if (135529 - 251481 != -115951)
																						{
																							this.spawnActor("CamBot", 9, 7);
																							if (293783 - 447924 != -154140)
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
														if (num5 != 10)
														{
															break;
														}
														if (119435 - 33549 == 85886)
														{
															if (num3 == PlayerData.UID)
															{
																if (226639 - 570543 == -343903)
																{
																	continue;
																}
																this.spawnActor("CarrierBot", 9, 2);
																if (281035 - 74446 == 206590)
																{
																	continue;
																}
																this.spawnActor("CarrierBot", 9, 3);
																if (259633 - 435987 != -176354)
																{
																	continue;
																}
															}
															GameObject gameObject = GameObject.Find("FakeRobots");
															if (138047 - 465984 == -327937)
															{
																if (!gameObject)
																{
																	break;
																}
																if (297903 - 553792 != -255888)
																{
																	UnityEngine.Object.Destroy(gameObject);
																	if (91437 - 74552 == 16885)
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
								else if (num4 == 9163)
								{
									if (246958 - 394165 == -147207)
									{
										this.ifgnnF3h2Fi++;
										if (6013 - 114998 == -108985)
										{
											this.SendMessage("newGameMessage", "Mission Objective: Robot destroyed:" + this.ifgnnF3h2Fi + "/44");
											if (126334 - 233421 == -107087)
											{
												Chat.SubmitChat("none", "Robot destroyed:" + this.ifgnnF3h2Fi + "/44", eChatType.system, eChatMode.system);
												if (137185 - 258114 == -120929)
												{
													if (this.ifgnnF3h2Fi < 44)
													{
														break;
													}
													if (245366 - 79407 == 165959)
													{
														Game.sendMissionEvent(9161, 1);
														if (72006 - 536595 != -464588)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else if (num4 == 9164)
								{
									if (244645 - 293443 == -48798)
									{
										int num6 = num2;
										if (7473 - 475543 != -468069)
										{
											if (num6 == 1)
											{
												if (164437 - 336284 != -171846)
												{
													this.SendMessage("newGameMessage", "Warning: Abete is dead!");
													if (96767 - 190259 != -93491)
													{
														Chat.SubmitChat("none", "Warning: Abete is dead!", eChatType.system, eChatMode.system);
														if (233880 - 28179 != 205702)
														{
															break;
														}
													}
												}
											}
											else if (num6 == 2)
											{
												if (85668 - 42045 != 43624)
												{
													this.SendMessage("newGameMessage", "Warning: Jamon is dead!");
													if (118953 - 597052 != -478098)
													{
														Chat.SubmitChat("none", "Warning: Jamon is dead!", eChatType.system, eChatMode.system);
														if (214674 - 520562 != -305887)
														{
															break;
														}
													}
												}
											}
											else if (num6 == 3)
											{
												if (78535 - 278212 == -199677)
												{
													this.SendMessage("newGameMessage", "Warning: Xin Fu is dead!");
													if (131419 - 40244 != 91176)
													{
														Chat.SubmitChat("none", "Warning: Xin Fu is dead!", eChatType.system, eChatMode.system);
														if (73701 - 243800 == -170099)
														{
															break;
														}
													}
												}
											}
											else
											{
												if (num6 != 4)
												{
													break;
												}
												if (136543 - 248414 != -111870)
												{
													this.SendMessage("newGameMessage", "Warning: Panther is dead!");
													if (244652 - 317369 != -72716)
													{
														Chat.SubmitChat("none", "Warning: Panther is dead!", eChatType.system, eChatMode.system);
														if (61111 - 482642 != -421530)
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
									Debug.LogError("Warning unknown returnCode:" + num);
									if (281277 - 552872 != -271594)
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

	// Token: 0x06009733 RID: 38707 RVA: 0x011D6CFC File Offset: 0x011D4EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M916_CityUnderSiege.$StartEvent$42250(this).GetEnumerator();
	}

	// Token: 0x06009734 RID: 38708 RVA: 0x011D6D0C File Offset: 0x011D4F0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AcaciaEvent()
	{
		return new M916_CityUnderSiege.$AcaciaEvent$42256(this).GetEnumerator();
	}

	// Token: 0x06009735 RID: 38709 RVA: 0x011D6D1C File Offset: 0x011D4F1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (92333 - 547358 != -455024)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (280815 - 572333 == -291518)
			{
				CharacterControl characterControl = null;
				if (276076 - 32737 != 243340)
				{
					if (mPlayer)
					{
						if (223605 - 589043 == -365437)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (12077 - 483361 == -471283)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (38301 - 209690 == -171389)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (162762 - 492513 != -329750)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (143808 - 559259 != -415450)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (99751 - 349834 == -250082)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (37456 - 442703 != -405247)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (269084 - 172073 == 97012)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (33907 - 24909 != 8998)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (193566 - 453330 != -259763)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (45718 - 551927 == -506209)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (105938 - 241327 != -135388)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (107897 - 118384 != -10486)
								{
									if (!changeGui)
									{
										break;
									}
									if (242082 - 15142 == 226940)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (284615 - 375446 == -90830)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (186384 - 350095 == -163710)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (272194 - 54067 == 218127)
										{
											gameGui.close();
											if (90261 - 326916 != -236654)
											{
												changeGui.enabled = true;
												if (172196 - 566125 != -393928)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (44281 - 113820 == -69539)
													{
														if (!gameObject)
														{
															break;
														}
														if (104608 - 127117 == -22509)
														{
															if (!mPlayer)
															{
																break;
															}
															if (101434 - 111522 == -10088)
															{
																Debug.Log("UseLifeAltar");
																if (190605 - 305266 == -114661)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (236978 - 215039 != 21940)
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

	// Token: 0x06009736 RID: 38710 RVA: 0x011D717C File Offset: 0x011D537C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (143991 - 351598 != -207606)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (104740 - 510356 == -405616)
			{
				Time.timeScale = 1f;
				if (40812 - 291659 != -250846)
				{
					this.RBAnnjgG6QH = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (274671 - 197191 == 77480)
					{
						Hashtable customOpParameters = new Hashtable();
						if (278853 - 41990 == 236863)
						{
							this.u8Cnni5CQdd.OpCustom(52, customOpParameters, true);
							if (89147 - 5564 != 83584)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009737 RID: 38711 RVA: 0x011D7280 File Offset: 0x011D5480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (144231 - 148396 != -4164)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (139077 - 342322 == -203245)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (248975 - 478590 != -229614)
				{
					Game.mGameState = eGameState.Setup;
					if (62386 - 181450 != -119063)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009738 RID: 38712 RVA: 0x011D7324 File Offset: 0x011D5524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (107984 - 277102 != -169118)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (159473 - 583197 != -423723)
			{
				if (num == PlayerData.UID)
				{
					if (77328 - 234865 != -157536)
					{
						this.SetupActors();
						if (49248 - 333673 != -284424)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (248466 - 474016 != -225549)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009739 RID: 38713 RVA: 0x011D73F4 File Offset: 0x011D55F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (238423 - 48952 != 189472)
		{
		}
		for (;;)
		{
			IL_107:
			Debug.Log("Creating Actors");
			if (125786 - 10066 != 115721)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (133735 - 401969 != -268233)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (124208 - 556832 == -432624)
						{
							int i = 0;
							if (114295 - 535811 != -421515)
							{
								CharacterControl[] array2 = array;
								if (70151 - 63602 == 6549)
								{
									int length = array2.Length;
									if (145894 - 380915 != -235020)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (176509 - 42597 != 133912)
												{
													goto IL_107;
												}
												string type = array2[i].Type;
												if (132671 - 40357 != 92314)
												{
													goto IL_107;
												}
												if (type == "LightGate")
												{
													goto IL_2D1;
												}
												if (180116 - 216072 == -35955)
												{
													goto IL_107;
												}
												if (type == "Humpback")
												{
													goto IL_2D1;
												}
												if (109761 - 215776 != -106015)
												{
													goto IL_107;
												}
												if (type == "Mouse")
												{
													goto IL_2D1;
												}
												if (214991 - 389829 != -174838)
												{
													goto IL_107;
												}
												if (type == "Owl1")
												{
													goto IL_2D1;
												}
												if (177433 - 331173 == -153739)
												{
													goto IL_107;
												}
												if (type == "Panther")
												{
													if (146190 - 405192 != -259002)
													{
														goto IL_107;
													}
													goto IL_2D1;
												}
												IL_23D:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (14960 - 190960 == -175999)
												{
													goto IL_107;
												}
												this.h2vnnWyx3kk++;
												if (190197 - 335548 != -145350)
												{
													goto IL_1EB;
												}
												goto IL_107;
												IL_2D1:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (76041 - 453380 != -377338)
												{
													goto IL_23D;
												}
												goto IL_107;
											}
											IL_1EB:
											i++;
											if (169695 - 208495 == -38799)
											{
												goto IL_107;
											}
										}
										if (210883 - 205971 == 4912)
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
						if (63118 - 89533 == -26415)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600973A RID: 38714 RVA: 0x011D7738 File Offset: 0x011D5938
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (173844 - 442624 != -268780)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (49687 - 281725 == -232038)
			{
				int i = 0;
				if (249383 - 478386 != -229002)
				{
					CharacterControl[] array2 = array;
					if (14365 - 404651 != -390285)
					{
						int length = array2.Length;
						if (156329 - 359556 == -203227)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (145423 - 478138 == -332714)
								{
									goto IL_1A;
								}
								i++;
								if (40966 - 374777 == -333810)
								{
									goto IL_1A;
								}
							}
							if (290353 - 291047 != -693)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600973B RID: 38715 RVA: 0x011D7868 File Offset: 0x011D5A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (193093 - 596869 != -403776)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (13530 - 300212 != -286681)
			{
				Game.mGameState = eGameState.Ready;
				if (91805 - 62235 != 29571)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (159167 - 263163 != -103995 && 127807 - 296598 != -168790)
					{
						GameObject gameObject = null;
						if (184960 - 334921 != -149960)
						{
							if (playerSlot < 1)
							{
								goto IL_1D5;
							}
							if (289984 - 457473 != -167489)
							{
								continue;
							}
							if (playerSlot > 12)
							{
								goto IL_1D5;
							}
							if (29184 - 262742 == -233557)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (230700 - 525848 == -295147)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (85053 - 241626 == -156572)
							{
								continue;
							}
							IL_1A:
							if (gameObject2)
							{
								if (13244 - 391321 != -378077)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (239682 - 406048 == -166365)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (289900 - 4362 != 285538)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (177678 - 253680 == -76001)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (189515 - 459669 != -270154)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (124811 - 21237 == 103575)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (119805 - 1739 != 118066)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (133884 - 474529 != -340644)
							{
								break;
							}
							continue;
							IL_1D5:
							gameObject2 = GameObject.Find("StartPoint1");
							if (218860 - 196535 != 22326)
							{
								goto IL_1A;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600973C RID: 38716 RVA: 0x011D7B8C File Offset: 0x011D5D8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x0600973D RID: 38717 RVA: 0x011D7BA8 File Offset: 0x011D5DA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600973E RID: 38718 RVA: 0x011D7BAC File Offset: 0x011D5DAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (150693 - 517962 != -367269)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (131795 - 174157 != -42361)
			{
				if (gameObject)
				{
					if (98110 - 365090 != -266979)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (249328 - 159574 == 89754)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (120973 - 390346 == -269373)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600973F RID: 38719 RVA: 0x011D7CA8 File Offset: 0x011D5EA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (100466 - 83171 != 17296)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (99154 - 506455 != -407300)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (157277 - 128571 != 28707)
				{
					hashtable.Add(43, PlayerData.UID);
					if (297975 - 498824 != -200848)
					{
						hashtable.Add(73, nType);
						if (218739 - 249693 != -30953)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (156948 - 293319 != -136370)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (219754 - 190303 != 29452)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (265868 - 246403 != 19466)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (267398 - 584130 == -316732)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (196168 - 121165 == 75003)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (1543 - 325059 != -323515)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (238293 - 151201 != 87093)
													{
														this.u8Cnni5CQdd.OpCustom(63, hashtable, true);
														if (283273 - 589345 != -306071)
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

	// Token: 0x06009740 RID: 38720 RVA: 0x011D7F8C File Offset: 0x011D618C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (240548 - 467698 != -227150)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (50997 - 455933 == -404936)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (7261 - 20709 != -13447)
				{
					object lhs = data[73];
					if (3383 - 350915 == -347532)
					{
						if (RuntimeServices.EqualityOperator(lhs, "CamBot"))
						{
							goto IL_245;
						}
						if (132034 - 251101 == -119066)
						{
							continue;
						}
						if (RuntimeServices.EqualityOperator(lhs, "CutBot"))
						{
							goto IL_245;
						}
						if (280245 - 461656 == -181410)
						{
							continue;
						}
						if (RuntimeServices.EqualityOperator(lhs, "SiegeBot"))
						{
							goto IL_245;
						}
						if (206050 - 234546 != -28496)
						{
							continue;
						}
						if (RuntimeServices.EqualityOperator(lhs, "CarrierBot"))
						{
							if (157119 - 332650 != -175530)
							{
								goto IL_245;
							}
							continue;
						}
						else if (RuntimeServices.EqualityOperator(lhs, "LightGate"))
						{
							if (224002 - 62119 != 161883)
							{
								continue;
							}
							this.DtWnn9VKw72 = gameObject;
							if (282861 - 298496 != -15635)
							{
								continue;
							}
						}
						IL_1A8:
						if (Game.mGameState == eGameState.Setup)
						{
							if (106882 - 401327 == -294444)
							{
								continue;
							}
							if (this.h2vnnWyx3kk <= 0)
							{
								break;
							}
							if (28535 - 538925 == -510389)
							{
								continue;
							}
							this.h2vnnWyx3kk--;
							if (46974 - 590640 != -543666)
							{
								continue;
							}
							if (this.h2vnnWyx3kk != 0)
							{
								break;
							}
							if (127061 - 551995 != -424934)
							{
								continue;
							}
							Game.setGameState(eGameState.Ready);
							if (23313 - 53064 != -29750)
							{
								break;
							}
							continue;
						}
						else
						{
							if (Game.mGameState < eGameState.Normal)
							{
								break;
							}
							if (30195 - 104601 != -74406)
							{
								continue;
							}
							gameObject.SendMessage("createSpecialEffect", 1);
							if (221235 - 315184 != -93948)
							{
								break;
							}
							continue;
						}
						IL_245:
						this.ruFnnkmVJ4n++;
						if (123163 - 272383 != -149219)
						{
							goto IL_1A8;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009741 RID: 38721 RVA: 0x011D826C File Offset: 0x011D646C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009742 RID: 38722 RVA: 0x011D8280 File Offset: 0x011D6480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (236023 - 232779 != 3244)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (16764 - 316820 == -300056)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (237975 - 423449 != -185473)
				{
					if (!characterControl)
					{
						break;
					}
					if (104940 - 16495 != 88446)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (29180 - 87245 == -58065)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (17834 - 84163 != -66328)
							{
								string type = characterControl.Type;
								if (69197 - 324169 == -254972)
								{
									if (type == "CamBot")
									{
										if (16564 - 201966 == -185402)
										{
											Game.sendMissionEvent(9163, 1);
											if (27421 - 29339 == -1918)
											{
												break;
											}
										}
									}
									else if (type == "CutBot")
									{
										if (255703 - 598025 != -342321)
										{
											Game.sendMissionEvent(9163, 2);
											if (256916 - 361636 == -104720)
											{
												break;
											}
										}
									}
									else if (type == "SiegeBot")
									{
										if (135889 - 173897 != -38007)
										{
											Game.sendMissionEvent(9163, 3);
											if (175703 - 176512 == -809)
											{
												break;
											}
										}
									}
									else if (type == "CarrierBot")
									{
										if (232689 - 85069 == 147620)
										{
											Game.sendMissionEvent(9163, 4);
											if (287038 - 183345 != 103694)
											{
												break;
											}
										}
									}
									else if (type == "Mouse")
									{
										if (158147 - 576779 != -418631)
										{
											Game.sendMissionEvent(9164, 1);
											if (32553 - 6795 != 25759)
											{
												break;
											}
										}
									}
									else if (type == "Humpback")
									{
										if (216017 - 357449 != -141431)
										{
											Game.sendMissionEvent(9164, 2);
											if (87114 - 224969 == -137855)
											{
												break;
											}
										}
									}
									else if (type == "Owl1")
									{
										if (170621 - 244287 == -73666)
										{
											Game.sendMissionEvent(9164, 3);
											if (133144 - 92594 == 40550)
											{
												break;
											}
										}
									}
									else if (type == "Panther")
									{
										if (37211 - 304588 == -267377)
										{
											Game.sendMissionEvent(9164, 4);
											if (222187 - 384630 == -162443)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "LightGate"))
										{
											break;
										}
										if (220116 - 474495 == -254379)
										{
											Game.sendMissionEvent(9161, 2);
											if (17452 - 67416 == -49964)
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

	// Token: 0x06009743 RID: 38723 RVA: 0x011D8698 File Offset: 0x011D6898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (159574 - 456998 != -297424)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (176965 - 162278 == 14687)
			{
				hashtable.Add(71, CID);
				if (56365 - 420836 != -364470)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (152607 - 286527 != -133919)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (131465 - 145891 == -14426)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (41545 - 99792 != -58246)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (125554 - 505587 == -380033)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (289463 - 306599 != -17135)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (294454 - 74383 == 220071)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (124655 - 423463 != -298807)
											{
												this.u8Cnni5CQdd.OpCustom(61, hashtable, true);
												if (210657 - 83019 != 127639)
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

	// Token: 0x06009744 RID: 38724 RVA: 0x011D8924 File Offset: 0x011D6B24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (171996 - 18479 != 153517)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (25684 - 407519 != -381834)
			{
				if (!gameObject)
				{
					break;
				}
				if (26282 - 200717 == -174435)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (293910 - 300702 != -6791)
					{
						playerCameraControl.target = gameObject;
						if (11530 - 374247 == -362717)
						{
							this.StartGame();
							if (244110 - 259341 != -15230)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009745 RID: 38725 RVA: 0x011D8A14 File Offset: 0x011D6C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (50397 - 398326 != -347929)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (195347 - 314503 == -119156)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (187368 - 399387 == -212019)
				{
					gameGui.ResetTeamBar();
					if (15988 - 326524 == -310536)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009746 RID: 38726 RVA: 0x011D8AC0 File Offset: 0x011D6CC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M916_CityUnderSiege.$onDeadPlayer$42261(this).GetEnumerator();
	}

	// Token: 0x06009747 RID: 38727 RVA: 0x011D8AD0 File Offset: 0x011D6CD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (62551 - 367128 != -304577)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (217455 - 321444 != -103988)
			{
				this.OOennDVbMFn.target = Game.mPlayer;
				if (218748 - 293470 != -74721)
				{
					this.OOennDVbMFn.enabled = true;
					if (296411 - 47824 == 248587)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (264141 - 365629 != -101488)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (248991 - 1597 != 247394)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (208714 - 408522 == -199808)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (4165 - 230145 == -225980)
							{
								if (!gameGui)
								{
									break;
								}
								if (64556 - 213734 == -149178)
								{
									gameGui.enabled = true;
									if (38712 - 382291 == -343579)
									{
										gameGui.closeDeadMenu();
										if (185039 - 589654 != -404614)
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

	// Token: 0x06009748 RID: 38728 RVA: 0x011D8C7C File Offset: 0x011D6E7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (93281 - 292056 != -198774)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (274797 - 245856 == 28941)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (180083 - 302820 == -122737)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (95145 - 352597 == -257452)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009749 RID: 38729 RVA: 0x011D8D40 File Offset: 0x011D6F40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600974A RID: 38730 RVA: 0x011D8D6C File Offset: 0x011D6F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (25011 - 286501 != -261490)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (9330 - 406316 == -396986)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (277884 - 207578 != 70307)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (267445 - 37337 != 230109)
					{
						Hashtable hashtable = new Hashtable();
						if (231612 - 534202 == -302590)
						{
							hashtable.Add(43, PlayerData.UID);
							if (32225 - 586148 == -553923)
							{
								hashtable.Add(71, nCID);
								if (124763 - 328233 != -203469)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (133345 - 384001 == -250656)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (174446 - 398212 != -223765)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (163899 - 589111 == -425212)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (215558 - 521476 != -305917)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (183925 - 377233 == -193308)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (137134 - 266332 == -129198)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (60102 - 257176 != -197073)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (2655 - 290793 != -288137)
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

	// Token: 0x0600974B RID: 38731 RVA: 0x011D908C File Offset: 0x011D728C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M916_CityUnderSiege.$onChangePlayer$42267(data, this).GetEnumerator();
	}

	// Token: 0x0600974C RID: 38732 RVA: 0x011D909C File Offset: 0x011D729C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M916_CityUnderSiege.$onGameComplete$42274(data, this).GetEnumerator();
	}

	// Token: 0x0600974D RID: 38733 RVA: 0x011D90AC File Offset: 0x011D72AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M916_CityUnderSiege.$ReturnToTown$42284(this).GetEnumerator();
	}

	// Token: 0x0600974E RID: 38734 RVA: 0x011D90BC File Offset: 0x011D72BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M916_CityUnderSiege.$ReturnToGuild$42289(this).GetEnumerator();
	}

	// Token: 0x0600974F RID: 38735 RVA: 0x011D90CC File Offset: 0x011D72CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M916_CityUnderSiege.$ReturnToCamp$42293(this).GetEnumerator();
	}

	// Token: 0x06009750 RID: 38736 RVA: 0x011D90DC File Offset: 0x011D72DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (120738 - 277205 != -156467)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (11082 - 193301 != -182218)
			{
				Hashtable hashtable = new Hashtable();
				if (254695 - 285830 != -31134)
				{
					hashtable.Add(43, PlayerData.UID);
					if (23873 - 275203 == -251330)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (28803 - 574955 == -546152)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009751 RID: 38737 RVA: 0x011D91B4 File Offset: 0x011D73B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009752 RID: 38738 RVA: 0x011D91C8 File Offset: 0x011D73C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (58684 - 343691 != -285007)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (4154 - 409712 == -405558)
			{
				Hashtable hashtable = new Hashtable();
				if (63497 - 246007 != -182509)
				{
					if (Game.mNextGameCode == 30)
					{
						if (186318 - 493542 != -307224)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (133758 - 7919 == 125840)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (189439 - 480012 == -290572)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (24262 - 319069 != -294807)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (222443 - 22132 == 200312)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (102376 - 242163 != -139787)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (47473 - 369625 != -322152)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (113920 - 220332 == -106411)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (119271 - 429187 == -309915)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (201739 - 570045 != -368306)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (270638 - 298458 != -27820)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (179528 - 562876 == -383347)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (138254 - 298125 == -159870)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (48660 - 329764 != -281104)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (38832 - 132676 == -93843)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (281923 - 472781 == -190857)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (280175 - 315552 == -35376)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (51291 - 261300 != -210009)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (17094 - 8724 != 8370)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (166923 - 119451 != 47472)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (76979 - 167455 != -90476)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (200222 - 259090 != -58868)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (57416 - 152193 != -94777)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (40352 - 537530 == -497177)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (263681 - 436294 != -172613)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (146791 - 330945 != -184154)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (257012 - 445828 == -188815)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (55679 - 299831 != -244152)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (240870 - 584423 != -343552)
					{
						this.u8Cnni5CQdd.OpCustom(42, hashtable, true);
						if (64400 - 407030 == -342630)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009753 RID: 38739 RVA: 0x011D977C File Offset: 0x011D797C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009754 RID: 38740 RVA: 0x011D978C File Offset: 0x011D798C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009755 RID: 38741 RVA: 0x011D9790 File Offset: 0x011D7990
	internal static bool AFAyLcV2muQwnTbChhaX()
	{
		return true;
	}

	// Token: 0x06009756 RID: 38742 RVA: 0x011D9794 File Offset: 0x011D7994
	internal static bool GrbJVQV2F6scQFQVqUGK()
	{
		return false;
	}

	// Token: 0x04008C88 RID: 35976
	private LitePeer u8Cnni5CQdd;

	// Token: 0x04008C89 RID: 35977
	private PlayerCameraControl OOennDVbMFn;

	// Token: 0x04008C8A RID: 35978
	private float hWcnnmRWnSw;

	// Token: 0x04008C8B RID: 35979
	private Texture RBAnnjgG6QH;

	// Token: 0x04008C8C RID: 35980
	private int avXnnoqcZIf;

	// Token: 0x04008C8D RID: 35981
	private int ruFnnkmVJ4n;

	// Token: 0x04008C8E RID: 35982
	private int ifgnnF3h2Fi;

	// Token: 0x04008C8F RID: 35983
	private float MuEnnAYHoFp;

	// Token: 0x04008C90 RID: 35984
	private GameObject DtWnn9VKw72;

	// Token: 0x04008C91 RID: 35985
	private int h2vnnWyx3kk;

	// Token: 0x0200195F RID: 6495
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$42250 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009757 RID: 38743 RVA: 0x011D9798 File Offset: 0x011D7998
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$42250(M916_CityUnderSiege self_)
		{
			if (184852 - 203875 != -19023)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186051 - 558122 != -372070)
				{
					base..ctor();
					if (54879 - 404867 != -349987)
					{
						this.$self_$42255 = self_;
						if (286230 - 296427 != -10196)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009758 RID: 38744 RVA: 0x011D9830 File Offset: 0x011D7A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M916_CityUnderSiege.$StartEvent$42250.$(this.$self_$42255);
		}

		// Token: 0x06009759 RID: 38745 RVA: 0x011D9840 File Offset: 0x011D7A40
		internal static bool AM7oeyV2MQh6nUyrWFII()
		{
			return true;
		}

		// Token: 0x0600975A RID: 38746 RVA: 0x011D9844 File Offset: 0x011D7A44
		internal static bool xleDrVV2xxShPOXlVaap()
		{
			return false;
		}

		// Token: 0x04008C92 RID: 35986
		internal M916_CityUnderSiege $self_$42255;

		// Token: 0x02001960 RID: 6496
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600975B RID: 38747 RVA: 0x011D9848 File Offset: 0x011D7A48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M916_CityUnderSiege self_)
			{
				if (13087 - 525028 != -511941)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (210861 - 529135 == -318274)
					{
						base..ctor();
						if (195119 - 259655 != -64535)
						{
							this.$self_$42254 = self_;
							if (56697 - 346891 == -290194)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600975C RID: 38748 RVA: 0x011D98E0 File Offset: 0x011D7AE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (69815 - 331240 != -261425)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_758;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (40586 - 193397 != -152811)
							{
								continue;
							}
							goto IL_168;
						}
						else
						{
							this.$self_$42254.OOennDVbMFn.StartCoroutine_Auto(this.$self_$42254.OOennDVbMFn.slerpToObject("EventCamera2", (float)4));
							if (227752 - 565001 != -337248)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (38613 - 94871 != -56258)
							{
								continue;
							}
							goto IL_63B;
						}
						else
						{
							this.$mStoryGui$42251 = (StoryGui)this.$self_$42254.GetComponent(typeof(StoryGui));
							if (211604 - 28833 == 182772)
							{
								continue;
							}
							if (!this.$mStoryGui$42251)
							{
								goto IL_CE;
							}
							if (269165 - 518829 != -249664)
							{
								continue;
							}
							this.$mStoryGui$42251.startStoryMessage("Mouse", "Abette", eTalkType.friend);
							if (52098 - 171967 != -119869)
							{
								continue;
							}
							goto IL_53B;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (69688 - 446334 != -376645)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42251.newStoryMessage("Mouse", "Abette", Language.getMessage("M916_CityUnderSiege", 101), eTalkType.friend);
							if (21759 - 354889 != -333129)
							{
								goto Block_45;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (99750 - 482356 != -382605)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42251.newStoryMessage("Mouse", "Abette", Language.getMessage("M916_CityUnderSiege", UnityEngine.Random.Range(201, 206)), eTalkType.friend);
							if (166558 - 110879 == 55680)
							{
								continue;
							}
							this.$self_$42254.OOennDVbMFn.alignToObject("EventCamera3");
							if (25832 - 337889 != -312057)
							{
								continue;
							}
							goto IL_47C;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (115639 - 106595 != 9044)
							{
								continue;
							}
							goto IL_576;
						}
						else
						{
							this.$mStoryGui$42251.newStoryMessage("Humpback", "Jamon", Language.getMessage("M916_CityUnderSiege", UnityEngine.Random.Range(301, 306)), eTalkType.friend);
							if (235692 - 462738 != -227046)
							{
								continue;
							}
							goto IL_277;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (275727 - 520274 != -244546)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42251.newStoryMessage("Owl1", "Xin Fu", Language.getMessage("M916_CityUnderSiege", UnityEngine.Random.Range(401, 406)), eTalkType.friend);
							if (16883 - 394959 != -378075)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (208916 - 594541 != -385625)
							{
								continue;
							}
							goto IL_37B;
						}
						else
						{
							this.$mStoryGui$42251.close();
							if (260009 - 211157 == 48853)
							{
								continue;
							}
							this.$self_$42254.SendMessage("fadeOut");
							if (95069 - 328871 != -233802)
							{
								continue;
							}
							goto IL_6B6;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (257516 - 324719 != -67202)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							this.$slot$42252 = Game.getPlayerSlot(PlayerData.UID);
							if (255809 - 586785 != -330976)
							{
								continue;
							}
							this.$self_$42254.OOennDVbMFn.alignToObject("StartCamera" + this.$slot$42252);
							if (157055 - 35664 != 121392)
							{
								goto IL_CE;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (194280 - 110963 != 83317)
							{
								continue;
							}
							goto IL_8F;
						}
						else
						{
							this.$mGameGui$42253 = (GameGui)this.$self_$42254.GetComponent(typeof(GameGui));
							if (277066 - 4255 != 272811)
							{
								continue;
							}
							this.$mGameGui$42253.enabled = true;
							if (240763 - 190027 != 50736)
							{
								continue;
							}
							goto IL_3A5;
						}
						break;
					case 11:
						Game.mGameState = eGameState.Normal;
						if (282060 - 375149 != -93089)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (52356 - 200445 == -148088)
						{
							continue;
						}
						this.YieldDefault(1);
						if (235247 - 334279 != -99031)
						{
							goto Block_7;
						}
						continue;
					default:
						if (192600 - 12813 != 179787)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (111144 - 99248 == 11897)
					{
						continue;
					}
					Game.mGameTime = Time.time;
					if (77868 - 381390 != -303522)
					{
						continue;
					}
					this.$self_$42254.OOennDVbMFn.alignToObject("EventCamera1");
					if (293753 - 104249 == 189505)
					{
						continue;
					}
					this.$self_$42254.SendMessage("fadeIn");
					if (253074 - 278032 != -24957)
					{
						goto Block_8;
					}
					continue;
					IL_CE:
					this.$self_$42254.SendMessage("fadeIn");
					if (180542 - 129233 != 51310)
					{
						this.$self_$42254.OOennDVbMFn.enabled = true;
						if (256686 - 454520 == -197834)
						{
							goto IL_67A;
						}
					}
				}
				IL_8F:
				Block_7:
				goto IL_758;
				Block_8:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_168:
				goto IL_758;
				Block_10:
				return this.Yield(3, new WaitForSeconds(4f));
				Block_11:
				return this.Yield(8, new WaitForSeconds(3.5f));
				IL_277:
				return this.Yield(7, new WaitForSeconds(3.5f));
				Block_16:
				IL_37B:
				goto IL_758;
				IL_3A5:
				return this.Yield(11, new WaitForSeconds(0.5f));
				Block_24:
				goto IL_758;
				IL_47C:
				return this.Yield(6, new WaitForSeconds(3.5f));
				IL_53B:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_33:
				IL_576:
				IL_63B:
				goto IL_758;
				IL_67A:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_6B6:
				return this.Yield(9, new WaitForSeconds(0.6f));
				Block_43:
				goto IL_758;
				Block_45:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_758:
				return false;
			}

			// Token: 0x0600975D RID: 38749 RVA: 0x011DA058 File Offset: 0x011D8258
			internal static bool a5jBPqV2geSZeQyXCfFh()
			{
				return true;
			}

			// Token: 0x0600975E RID: 38750 RVA: 0x011DA05C File Offset: 0x011D825C
			internal static bool f8MvLuV2fUuBEIkikDNx()
			{
				return false;
			}

			// Token: 0x04008C93 RID: 35987
			internal StoryGui $mStoryGui$42251;

			// Token: 0x04008C94 RID: 35988
			internal int $slot$42252;

			// Token: 0x04008C95 RID: 35989
			internal GameGui $mGameGui$42253;

			// Token: 0x04008C96 RID: 35990
			internal M916_CityUnderSiege $self_$42254;
		}
	}

	// Token: 0x02001961 RID: 6497
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AcaciaEvent$42256 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600975F RID: 38751 RVA: 0x011DA060 File Offset: 0x011D8260
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AcaciaEvent$42256(M916_CityUnderSiege self_)
		{
			if (47645 - 212251 != -164605)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145775 - 50064 != 95712)
				{
					base..ctor();
					if (62240 - 229498 != -167257)
					{
						this.$self_$42260 = self_;
						if (80252 - 347054 == -266802)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009760 RID: 38752 RVA: 0x011DA0F8 File Offset: 0x011D82F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M916_CityUnderSiege.$AcaciaEvent$42256.$(this.$self_$42260);
		}

		// Token: 0x06009761 RID: 38753 RVA: 0x011DA108 File Offset: 0x011D8308
		internal static bool amhPd3V2nQXO0bD2hs1W()
		{
			return true;
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x011DA10C File Offset: 0x011D830C
		internal static bool cXAvhVV26GXKUQDmV5UG()
		{
			return false;
		}

		// Token: 0x04008C97 RID: 35991
		internal M916_CityUnderSiege $self_$42260;

		// Token: 0x02001962 RID: 6498
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009763 RID: 38755 RVA: 0x011DA110 File Offset: 0x011D8310
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M916_CityUnderSiege self_)
			{
				if (193413 - 397564 != -204150)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (166260 - 279244 == -112984)
					{
						base..ctor();
						if (51087 - 392203 == -341116)
						{
							this.$self_$42259 = self_;
							if (102416 - 442292 == -339876)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009764 RID: 38756 RVA: 0x011DA1A8 File Offset: 0x011D83A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (14045 - 466424 != -452379)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8C9;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (34047 - 415508 != -381460)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							this.$self_$42259.camera.SendMessage("alignToObject", "EventCamera4");
							if (57487 - 157813 == -100325)
							{
								continue;
							}
							this.$self_$42259.SendMessage("fadeIn");
							if (71871 - 296377 != -224506)
							{
								continue;
							}
							goto IL_5C7;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (49058 - 414975 != -365917)
							{
								continue;
							}
							goto IL_126;
						}
						else
						{
							this.$mGameGui$42257.close();
							if (57874 - 565610 == -507735)
							{
								continue;
							}
							this.$mStoryGui$42258.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
							if (288225 - 492573 != -204347)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (128075 - 18579 != 109496)
							{
								continue;
							}
							goto IL_46E;
						}
						else
						{
							this.$mStoryGui$42258.newStoryMessage("Walrus", "Reggu", Language.getMessage("M916_CityUnderSiege", 1001), eTalkType.friend);
							if (223932 - 301301 != -77369)
							{
								continue;
							}
							goto IL_6C2;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (143253 - 266204 != -122951)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mStoryGui$42258.newStoryMessage("Walrus", "Reggu", Language.getMessage("M916_CityUnderSiege", 1002), eTalkType.friend);
							if (260289 - 199360 != 60929)
							{
								continue;
							}
							goto IL_433;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (290032 - 450111 != -160079)
							{
								continue;
							}
							goto IL_59D;
						}
						else
						{
							this.$mStoryGui$42258.close();
							if (84869 - 174071 != -89202)
							{
								continue;
							}
							goto IL_852;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (33974 - 24036 != 9938)
							{
								continue;
							}
							goto IL_3FE;
						}
						else
						{
							this.$mStoryGui$42258.startStoryMessage("LightGod", "Alcacia", eTalkType.friend);
							if (21154 - 529241 != -508086)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (22868 - 249307 != -226439)
							{
								continue;
							}
							goto IL_2AA;
						}
						else
						{
							this.$mStoryGui$42258.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M916_CityUnderSiege", 1003), eTalkType.friend);
							if (38626 - 112164 != -73538)
							{
								continue;
							}
							goto IL_232;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (193521 - 124448 != 69073)
							{
								continue;
							}
							goto IL_32A;
						}
						else
						{
							this.$mStoryGui$42258.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M916_CityUnderSiege", 1004), eTalkType.friend);
							if (19895 - 408913 != -389018)
							{
								continue;
							}
							goto IL_26E;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (32516 - 508142 != -475625)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42258.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M916_CityUnderSiege", 1005), eTalkType.friend);
							if (165334 - 253283 != -87949)
							{
								continue;
							}
							goto IL_602;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (181415 - 433896 != -252481)
							{
								continue;
							}
							goto IL_7E3;
						}
						else
						{
							this.$mStoryGui$42258.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M916_CityUnderSiege", 1006), eTalkType.friend);
							if (173916 - 281439 != -107522)
							{
								goto Block_53;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (1812 - 491288 != -489476)
							{
								continue;
							}
							goto IL_698;
						}
						else
						{
							this.$mStoryGui$42258.close();
							if (93529 - 110859 == -17329)
							{
								continue;
							}
							this.$self_$42259.camera.SendMessage("resetPlayerCamera");
							if (243636 - 592423 == -348786)
							{
								continue;
							}
							this.$self_$42259.SendMessage("fadeOut");
							if (205725 - 209633 != -3908)
							{
								continue;
							}
							goto IL_76C;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (126617 - 394595 != -267978)
							{
								continue;
							}
							goto IL_36F;
						}
						else
						{
							this.$self_$42259.SendMessage("fadeIn");
							if (20766 - 66827 != -46060)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (168113 - 217823 != -49709)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							if (this.$self_$42259.DtWnn9VKw72)
							{
								if (278196 - 474361 == -196164)
								{
									continue;
								}
								this.$self_$42259.DtWnn9VKw72.SendMessage("startAIAttack");
								if (15298 - 473089 == -457790)
								{
									continue;
								}
							}
							this.$mGameGui$42257.enabled = true;
							if (62170 - 205962 == -143791)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (27142 - 171504 != -144361)
							{
								goto IL_4E2;
							}
							continue;
						}
						break;
					default:
						if (94074 - 440507 == -346432)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$42257 = (GameGui)this.$self_$42259.GetComponent(typeof(GameGui));
					if (267314 - 304884 == -37569)
					{
						continue;
					}
					this.$mStoryGui$42258 = (StoryGui)this.$self_$42259.GetComponent(typeof(StoryGui));
					if (177445 - 404159 != -226714)
					{
						continue;
					}
					if (this.$mGameGui$42257)
					{
						if (12995 - 452112 != -439117)
						{
							continue;
						}
						if (this.$mStoryGui$42258)
						{
							if (293643 - 167218 != 126425)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (16645 - 258303 != -241658)
							{
								continue;
							}
							this.$self_$42259.SendMessage("fadeOut");
							if (85238 - 537110 != -451872)
							{
								continue;
							}
							goto IL_538;
						}
					}
					IL_4E2:
					this.YieldDefault(1);
				}
				while (49895 - 278432 == -228536);
				IL_1A:
				Block_4:
				IL_126:
				goto IL_8C9;
				IL_232:
				return this.Yield(9, new WaitForSeconds(4f));
				IL_26E:
				return this.Yield(10, new WaitForSeconds(4f));
				Block_17:
				IL_2AA:
				IL_32A:
				IL_36F:
				goto IL_8C9;
				Block_22:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_3FE:
				goto IL_8C9;
				Block_25:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_433:
				return this.Yield(6, new WaitForSeconds(3.5f));
				IL_46E:
				goto IL_8C9;
				IL_538:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_34:
				IL_59D:
				goto IL_8C9;
				IL_5C7:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_602:
				return this.Yield(11, new WaitForSeconds(4f));
				Block_41:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_698:
				goto IL_8C9;
				IL_6C2:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_76C:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_7E3:
				goto IL_8C9;
				Block_53:
				return this.Yield(12, new WaitForSeconds(3f));
				IL_852:
				return this.Yield(7, new WaitForSeconds(0.65f));
				IL_8C9:
				return false;
			}

			// Token: 0x06009765 RID: 38757 RVA: 0x011DAA90 File Offset: 0x011D8C90
			internal static bool cKsVD7V2iseEHoOWoJR5()
			{
				return true;
			}

			// Token: 0x06009766 RID: 38758 RVA: 0x011DAA94 File Offset: 0x011D8C94
			internal static bool TcRFbYV2Kd6k7lwKLHlf()
			{
				return false;
			}

			// Token: 0x04008C98 RID: 35992
			internal GameGui $mGameGui$42257;

			// Token: 0x04008C99 RID: 35993
			internal StoryGui $mStoryGui$42258;

			// Token: 0x04008C9A RID: 35994
			internal M916_CityUnderSiege $self_$42259;
		}
	}

	// Token: 0x02001963 RID: 6499
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42261 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009767 RID: 38759 RVA: 0x011DAA98 File Offset: 0x011D8C98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42261(M916_CityUnderSiege self_)
		{
			if (275547 - 284808 != -9260)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (213839 - 187100 == 26739)
				{
					base..ctor();
					if (169271 - 577043 != -407771)
					{
						this.$self_$42266 = self_;
						if (273176 - 578095 != -304918)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009768 RID: 38760 RVA: 0x011DAB30 File Offset: 0x011D8D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M916_CityUnderSiege.$onDeadPlayer$42261.$(this.$self_$42266);
		}

		// Token: 0x06009769 RID: 38761 RVA: 0x011DAB40 File Offset: 0x011D8D40
		internal static bool ayyQUaV2dH66SNu4Sms3()
		{
			return true;
		}

		// Token: 0x0600976A RID: 38762 RVA: 0x011DAB44 File Offset: 0x011D8D44
		internal static bool yVeWUrV2J4QhamggqlDj()
		{
			return false;
		}

		// Token: 0x04008C9B RID: 35995
		internal M916_CityUnderSiege $self_$42266;

		// Token: 0x02001964 RID: 6500
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600976B RID: 38763 RVA: 0x011DAB48 File Offset: 0x011D8D48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M916_CityUnderSiege self_)
			{
				if (70065 - 3150 != 66916)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (187387 - 576244 != -388856)
					{
						base..ctor();
						if (141245 - 518060 != -376814)
						{
							this.$self_$42265 = self_;
							if (151361 - 463442 == -312081)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600976C RID: 38764 RVA: 0x011DABE0 File Offset: 0x011D8DE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66207 - 274165 != -207958)
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
							goto IL_2D9;
						}
						if (65658 - 290041 == -224382)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (47541 - 99693 != -52151)
							{
								goto IL_2D9;
							}
							continue;
						}
						IL_18F:
						this.YieldDefault(1);
						if (77376 - 374832 != -297456)
						{
							continue;
						}
						goto IL_2F9;
						IL_2D9:
						Game.mGameState = eGameState.Hold;
						if (47269 - 331799 == -284529)
						{
							continue;
						}
						this.$mStoryGui$42262 = (StoryGui)this.$self_$42265.GetComponent(typeof(StoryGui));
						if (156699 - 73336 != 83363)
						{
							continue;
						}
						if (this.$mStoryGui$42262)
						{
							if (211920 - 325753 == -113832)
							{
								continue;
							}
							this.$mStoryGui$42262.close();
							if (224166 - 442431 != -218265)
							{
								continue;
							}
						}
						this.$mChangeGui$42263 = (ChangeGui)this.$self_$42265.GetComponent(typeof(ChangeGui));
						if (204410 - 222867 != -18457)
						{
							continue;
						}
						if (this.$mChangeGui$42263)
						{
							if (227634 - 67751 != 159883)
							{
								continue;
							}
							this.$mChangeGui$42263.close();
							if (198354 - 340968 != -142614)
							{
								continue;
							}
						}
						this.$mGameGui$42264 = (GameGui)this.$self_$42265.GetComponent(typeof(GameGui));
						if (254074 - 248218 != 5856)
						{
							continue;
						}
						if (!this.$mGameGui$42264)
						{
							goto IL_18F;
						}
						if (95471 - 567541 == -472069)
						{
							continue;
						}
						if (!this.$mGameGui$42264.enabled)
						{
							if (144764 - 552388 != -407624)
							{
								continue;
							}
							this.$mGameGui$42264.enabled = true;
							if (234311 - 598354 == -364042)
							{
								continue;
							}
						}
						this.$mGameGui$42264.openDeadMenu();
						if (17844 - 210787 != -192942)
						{
							goto IL_18F;
						}
						continue;
					default:
						if (219491 - 283941 != -64450)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (184991 - 158590 != 26401);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600976D RID: 38765 RVA: 0x011DAEF8 File Offset: 0x011D90F8
			internal static bool ettxubV2DYtHA5JNGhOZ()
			{
				return true;
			}

			// Token: 0x0600976E RID: 38766 RVA: 0x011DAEFC File Offset: 0x011D90FC
			internal static bool Rx48jdV2vvqrIlGedTmJ()
			{
				return false;
			}

			// Token: 0x04008C9C RID: 35996
			internal StoryGui $mStoryGui$42262;

			// Token: 0x04008C9D RID: 35997
			internal ChangeGui $mChangeGui$42263;

			// Token: 0x04008C9E RID: 35998
			internal GameGui $mGameGui$42264;

			// Token: 0x04008C9F RID: 35999
			internal M916_CityUnderSiege $self_$42265;
		}
	}

	// Token: 0x02001965 RID: 6501
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$42267 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600976F RID: 38767 RVA: 0x011DAF00 File Offset: 0x011D9100
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$42267(Hashtable data, M916_CityUnderSiege self_)
		{
			if (277589 - 460007 != -182417)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (79751 - 398848 == -319097)
				{
					base..ctor();
					if (80892 - 265929 != -185036)
					{
						this.$data$42272 = data;
						if (138859 - 25759 == 113100)
						{
							this.$self_$42273 = self_;
							if (261067 - 215383 == 45684)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009770 RID: 38768 RVA: 0x011DAFBC File Offset: 0x011D91BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M916_CityUnderSiege.$onChangePlayer$42267.$(this.$data$42272, this.$self_$42273);
		}

		// Token: 0x06009771 RID: 38769 RVA: 0x011DAFD0 File Offset: 0x011D91D0
		internal static bool KnmKywV2Rexw6rKdSc7O()
		{
			return true;
		}

		// Token: 0x06009772 RID: 38770 RVA: 0x011DAFD4 File Offset: 0x011D91D4
		internal static bool dEN7N7V2wwQOZVgxwOy8()
		{
			return false;
		}

		// Token: 0x04008CA0 RID: 36000
		internal Hashtable $data$42272;

		// Token: 0x04008CA1 RID: 36001
		internal M916_CityUnderSiege $self_$42273;

		// Token: 0x02001966 RID: 6502
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009773 RID: 38771 RVA: 0x011DAFD8 File Offset: 0x011D91D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M916_CityUnderSiege self_)
			{
				if (78518 - 111909 != -33391)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (135909 - 122263 != 13647)
					{
						base..ctor();
						if (50175 - 352928 == -302753)
						{
							this.$data$42270 = data;
							if (98445 - 576673 == -478228)
							{
								this.$self_$42271 = self_;
								if (231516 - 367686 == -136170)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009774 RID: 38772 RVA: 0x011DB094 File Offset: 0x011D9294
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (139437 - 477510 != -338072)
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
							if (252783 - 446217 == -193433)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (108963 - 78076 != 30887)
							{
								continue;
							}
							this.$mGameGui$42269 = (GameGui)this.$self_$42271.GetComponent(typeof(GameGui));
							if (121797 - 543298 != -421501)
							{
								continue;
							}
							this.$mGameGui$42269.enabled = true;
							if (25546 - 27776 == -2229)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (176839 - 543746 != -366907)
						{
							continue;
						}
						goto IL_205;
					default:
						if (173085 - 16483 == 156603)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (67194 - 117192 != -49997)
					{
						this.$self_$42271.SendMessage("onCreatePlayer", this.$data$42270);
						if (277587 - 231262 != 46326)
						{
							this.$mChangeGui$42268 = (ChangeGui)this.$self_$42271.GetComponent(typeof(ChangeGui));
							if (188331 - 418542 != -230210)
							{
								if (!this.$mChangeGui$42268.enabled)
								{
									break;
								}
								if (177278 - 361113 == -183835)
								{
									this.$mChangeGui$42268.close();
									if (206960 - 41441 == 165519)
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

			// Token: 0x06009775 RID: 38773 RVA: 0x011DB2B8 File Offset: 0x011D94B8
			internal static bool CO5FVUV2qUJRwh3rGbIQ()
			{
				return true;
			}

			// Token: 0x06009776 RID: 38774 RVA: 0x011DB2BC File Offset: 0x011D94BC
			internal static bool o71OyoV27Ee8rvltyDL3()
			{
				return false;
			}

			// Token: 0x04008CA2 RID: 36002
			internal ChangeGui $mChangeGui$42268;

			// Token: 0x04008CA3 RID: 36003
			internal GameGui $mGameGui$42269;

			// Token: 0x04008CA4 RID: 36004
			internal Hashtable $data$42270;

			// Token: 0x04008CA5 RID: 36005
			internal M916_CityUnderSiege $self_$42271;
		}
	}

	// Token: 0x02001967 RID: 6503
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42274 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009777 RID: 38775 RVA: 0x011DB2C0 File Offset: 0x011D94C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42274(Hashtable data, M916_CityUnderSiege self_)
		{
			if (105720 - 59020 != 46701)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (248433 - 114075 != 134359)
				{
					base..ctor();
					if (45409 - 28702 != 16708)
					{
						this.$data$42282 = data;
						if (7380 - 524416 != -517035)
						{
							this.$self_$42283 = self_;
							if (2838 - 239083 != -236244)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009778 RID: 38776 RVA: 0x011DB37C File Offset: 0x011D957C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M916_CityUnderSiege.$onGameComplete$42274.$(this.$data$42282, this.$self_$42283);
		}

		// Token: 0x06009779 RID: 38777 RVA: 0x011DB390 File Offset: 0x011D9590
		internal static bool tg9oPUV2PmXtvQHiENHr()
		{
			return true;
		}

		// Token: 0x0600977A RID: 38778 RVA: 0x011DB394 File Offset: 0x011D9594
		internal static bool JG90HdV20cLknabxjqYs()
		{
			return false;
		}

		// Token: 0x04008CA6 RID: 36006
		internal Hashtable $data$42282;

		// Token: 0x04008CA7 RID: 36007
		internal M916_CityUnderSiege $self_$42283;

		// Token: 0x02001968 RID: 6504
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600977B RID: 38779 RVA: 0x011DB398 File Offset: 0x011D9598
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M916_CityUnderSiege self_)
			{
				if (91084 - 1897 != 89188)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221535 - 146142 != 75394)
					{
						base..ctor();
						if (267198 - 6451 != 260748)
						{
							this.$data$42280 = data;
							if (31032 - 553864 == -522832)
							{
								this.$self_$42281 = self_;
								if (238901 - 22292 == 216609)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600977C RID: 38780 RVA: 0x011DB454 File Offset: 0x011D9654
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227825 - 283566 != -55741)
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
						this.$mCompleteGui$42276 = (CompleteGui)this.$self_$42281.GetComponent(typeof(CompleteGui));
						if (226619 - 57113 != 169506)
						{
							continue;
						}
						this.$mCompleteGui$42276.Init();
						if (80695 - 324804 != -244109)
						{
							continue;
						}
						this.$mCompleteGui$42276.readData(this.$data$42280);
						if (174846 - 117786 == 57061)
						{
							continue;
						}
						if (this.$result$42275 == 1)
						{
							if (59488 - 133100 == -73611)
							{
								continue;
							}
							this.$mCompleteGui$42276.displayResult(eCompleteType.Success);
							if (76068 - 245352 == -169283)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42276.displayResult(eCompleteType.Failed);
							if (267891 - 558606 == -290714)
							{
								continue;
							}
						}
						this.$mGameGui$42277 = (GameGui)this.$self_$42281.GetComponent(typeof(GameGui));
						if (61210 - 72198 != -10988)
						{
							continue;
						}
						this.$mStoryGui$42278 = (StoryGui)this.$self_$42281.GetComponent(typeof(StoryGui));
						if (69186 - 493278 == -424091)
						{
							continue;
						}
						this.$mChangeGui$42279 = (ChangeGui)this.$self_$42281.GetComponent(typeof(ChangeGui));
						if (214442 - 519234 != -304792)
						{
							continue;
						}
						if (this.$mGameGui$42277)
						{
							if (153959 - 509147 != -355188)
							{
								continue;
							}
							this.$mGameGui$42277.close();
							if (40197 - 390053 == -349855)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42278)
						{
							if (267493 - 404634 != -137141)
							{
								continue;
							}
							this.$mStoryGui$42278.close();
							if (263484 - 45131 == 218354)
							{
								continue;
							}
						}
						if (this.$mChangeGui$42279)
						{
							if (261483 - 317463 != -55980)
							{
								continue;
							}
							this.$mChangeGui$42279.disable();
							if (260256 - 41248 != 219008)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (88062 - 85103 != 2960)
						{
							goto Block_2;
						}
						continue;
					default:
						if (30731 - 344363 == -313631)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42280[31]);
					if (1349 - 490974 != -489624)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (283669 - 465602 != -181932)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (110620 - 94292 == 16328)
							{
								this.$result$42275 = RuntimeServices.UnboxInt32(this.$data$42280[31]);
								if (76552 - 123861 == -47309)
								{
									goto IL_150;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_3DB;
				IL_150:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600977D RID: 38781 RVA: 0x011DB850 File Offset: 0x011D9A50
			internal static bool FsttHxV2blTvPbmZj9gx()
			{
				return true;
			}

			// Token: 0x0600977E RID: 38782 RVA: 0x011DB854 File Offset: 0x011D9A54
			internal static bool hRAhpAV2uyc1fY14FJmu()
			{
				return false;
			}

			// Token: 0x04008CA8 RID: 36008
			internal int $result$42275;

			// Token: 0x04008CA9 RID: 36009
			internal CompleteGui $mCompleteGui$42276;

			// Token: 0x04008CAA RID: 36010
			internal GameGui $mGameGui$42277;

			// Token: 0x04008CAB RID: 36011
			internal StoryGui $mStoryGui$42278;

			// Token: 0x04008CAC RID: 36012
			internal ChangeGui $mChangeGui$42279;

			// Token: 0x04008CAD RID: 36013
			internal Hashtable $data$42280;

			// Token: 0x04008CAE RID: 36014
			internal M916_CityUnderSiege $self_$42281;
		}
	}

	// Token: 0x02001969 RID: 6505
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42284 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600977F RID: 38783 RVA: 0x011DB858 File Offset: 0x011D9A58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42284(M916_CityUnderSiege self_)
		{
			if (116262 - 380283 != -264020)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (249476 - 17079 == 232397)
				{
					base..ctor();
					if (179964 - 213512 == -33548)
					{
						this.$self_$42288 = self_;
						if (181081 - 328612 != -147530)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009780 RID: 38784 RVA: 0x011DB8F0 File Offset: 0x011D9AF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M916_CityUnderSiege.$ReturnToTown$42284.$(this.$self_$42288);
		}

		// Token: 0x06009781 RID: 38785 RVA: 0x011DB900 File Offset: 0x011D9B00
		internal static bool swFdPnV2IoxCK1Obtwk6()
		{
			return true;
		}

		// Token: 0x06009782 RID: 38786 RVA: 0x011DB904 File Offset: 0x011D9B04
		internal static bool DwdXa4V2BBoui7qV06WX()
		{
			return false;
		}

		// Token: 0x04008CAF RID: 36015
		internal M916_CityUnderSiege $self_$42288;

		// Token: 0x0200196A RID: 6506
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009783 RID: 38787 RVA: 0x011DB908 File Offset: 0x011D9B08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M916_CityUnderSiege self_)
			{
				if (253196 - 490021 != -236824)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289565 - 196037 != 93529)
					{
						base..ctor();
						if (95797 - 231515 != -135717)
						{
							this.$self_$42287 = self_;
							if (12707 - 379890 != -367182)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009784 RID: 38788 RVA: 0x011DB9A0 File Offset: 0x011D9BA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230891 - 289682 != -58790)
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
						this.$self_$42287.LeaveGame();
						if (243020 - 558618 != -315598)
						{
							continue;
						}
						this.YieldDefault(1);
						if (289280 - 145160 != 144120)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (110895 - 407777 == -296881)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (250689 - 304679 != -53989)
					{
						Game.mStateTime = Time.time;
						if (147469 - 578567 == -431098)
						{
							this.$$switch$7666$42285 = PlayerData.SaveGuild;
							if (142687 - 442270 == -299583)
							{
								if (this.$$switch$7666$42285 == 1)
								{
									if (98435 - 134914 != -36479)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (150582 - 110341 == 40242)
									{
										continue;
									}
								}
								else if (this.$$switch$7666$42285 == 2)
								{
									if (45214 - 221336 != -176122)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (217444 - 129907 != 87537)
									{
										continue;
									}
								}
								else if (this.$$switch$7666$42285 == 3)
								{
									if (114040 - 422395 == -308354)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (72541 - 523182 != -450641)
									{
										continue;
									}
								}
								else if (this.$$switch$7666$42285 == 4)
								{
									if (131853 - 290611 != -158758)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (291868 - 355552 == -63683)
									{
										continue;
									}
								}
								else if (this.$$switch$7666$42285 == 5)
								{
									if (165035 - 20487 == 144549)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (85741 - 228764 == -143022)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (6932 - 71570 != -64638)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (22716 - 160500 != -137784)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (118042 - 234646 == -116603)
									{
										continue;
									}
								}
								this.$mGameGui$42286 = (GameGui)this.$self_$42287.GetComponent(typeof(GameGui));
								if (28107 - 390167 == -362060)
								{
									if (this.$mGameGui$42286)
									{
										if (35138 - 551003 == -515864)
										{
											continue;
										}
										this.$mGameGui$42286.close();
										if (97169 - 411536 != -314367)
										{
											continue;
										}
									}
									this.$self_$42287.SendMessage("fadeOut");
									if (240369 - 469031 == -228662)
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

			// Token: 0x06009785 RID: 38789 RVA: 0x011DBD6C File Offset: 0x011D9F6C
			internal static bool Wu6fCWV2eJLjsvpEGIue()
			{
				return true;
			}

			// Token: 0x06009786 RID: 38790 RVA: 0x011DBD70 File Offset: 0x011D9F70
			internal static bool g7ccZhV2rub6Xq5PmgqN()
			{
				return false;
			}

			// Token: 0x04008CB0 RID: 36016
			internal int $$switch$7666$42285;

			// Token: 0x04008CB1 RID: 36017
			internal GameGui $mGameGui$42286;

			// Token: 0x04008CB2 RID: 36018
			internal M916_CityUnderSiege $self_$42287;
		}
	}

	// Token: 0x0200196B RID: 6507
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42289 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009787 RID: 38791 RVA: 0x011DBD74 File Offset: 0x011D9F74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42289(M916_CityUnderSiege self_)
		{
			if (67571 - 199070 != -131499)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131112 - 73020 != 58093)
				{
					base..ctor();
					if (16864 - 266120 != -249255)
					{
						this.$self_$42292 = self_;
						if (221686 - 342787 != -121100)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009788 RID: 38792 RVA: 0x011DBE0C File Offset: 0x011DA00C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M916_CityUnderSiege.$ReturnToGuild$42289.$(this.$self_$42292);
		}

		// Token: 0x06009789 RID: 38793 RVA: 0x011DBE1C File Offset: 0x011DA01C
		internal static bool Ynp801V2jMhpZvHwDLVj()
		{
			return true;
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x011DBE20 File Offset: 0x011DA020
		internal static bool n23sm7V2h4urs4rJd8VF()
		{
			return false;
		}

		// Token: 0x04008CB3 RID: 36019
		internal M916_CityUnderSiege $self_$42292;

		// Token: 0x0200196C RID: 6508
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600978B RID: 38795 RVA: 0x011DBE24 File Offset: 0x011DA024
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M916_CityUnderSiege self_)
			{
				if (267087 - 576683 != -309596)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (48976 - 363122 != -314145)
					{
						base..ctor();
						if (72367 - 182066 != -109698)
						{
							this.$self_$42291 = self_;
							if (235269 - 593176 == -357907)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600978C RID: 38796 RVA: 0x011DBEBC File Offset: 0x011DA0BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (234697 - 465522 != -230825)
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
						this.$self_$42291.LeaveGame();
						if (105163 - 356175 != -251012)
						{
							continue;
						}
						this.YieldDefault(1);
						if (255470 - 246589 != 8882)
						{
							goto Block_8;
						}
						continue;
					default:
						if (173197 - 261139 == -87941)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (168932 - 210760 != -41827)
					{
						Game.mStateTime = Time.time;
						if (244878 - 297369 != -52490)
						{
							Game.mNextGameCode = 31;
							if (196807 - 459264 != -262456)
							{
								this.$mGameGui$42290 = (GameGui)this.$self_$42291.GetComponent(typeof(GameGui));
								if (186348 - 416113 == -229765)
								{
									if (this.$mGameGui$42290)
									{
										if (160505 - 123278 != 37227)
										{
											continue;
										}
										this.$mGameGui$42290.close();
										if (153789 - 443789 != -290000)
										{
											continue;
										}
									}
									this.$self_$42291.SendMessage("fadeOut");
									if (283336 - 406484 != -123147)
									{
										goto Block_10;
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_1BD;
				Block_10:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600978D RID: 38797 RVA: 0x011DC098 File Offset: 0x011DA298
			internal static bool qfrXZnV2spAoyO0FIQ09()
			{
				return true;
			}

			// Token: 0x0600978E RID: 38798 RVA: 0x011DC09C File Offset: 0x011DA29C
			internal static bool wMmsQcV29qfqwvdwHxYf()
			{
				return false;
			}

			// Token: 0x04008CB4 RID: 36020
			internal GameGui $mGameGui$42290;

			// Token: 0x04008CB5 RID: 36021
			internal M916_CityUnderSiege $self_$42291;
		}
	}

	// Token: 0x0200196D RID: 6509
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42293 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600978F RID: 38799 RVA: 0x011DC0A0 File Offset: 0x011DA2A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42293(M916_CityUnderSiege self_)
		{
			if (134549 - 407726 != -273176)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172853 - 242800 != -69946)
				{
					base..ctor();
					if (204091 - 149638 != 54454)
					{
						this.$self_$42297 = self_;
						if (171101 - 298012 == -126911)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009790 RID: 38800 RVA: 0x011DC138 File Offset: 0x011DA338
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M916_CityUnderSiege.$ReturnToCamp$42293.$(this.$self_$42297);
		}

		// Token: 0x06009791 RID: 38801 RVA: 0x011DC148 File Offset: 0x011DA348
		internal static bool fGpH9YV21TyCmuqamhXF()
		{
			return true;
		}

		// Token: 0x06009792 RID: 38802 RVA: 0x011DC14C File Offset: 0x011DA34C
		internal static bool SySsQmV24OehLPhu4Hr9()
		{
			return false;
		}

		// Token: 0x04008CB6 RID: 36022
		internal M916_CityUnderSiege $self_$42297;

		// Token: 0x0200196E RID: 6510
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009793 RID: 38803 RVA: 0x011DC150 File Offset: 0x011DA350
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M916_CityUnderSiege self_)
			{
				if (235061 - 403017 != -167956)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110629 - 90346 != 20284)
					{
						base..ctor();
						if (1651 - 238237 != -236585)
						{
							this.$self_$42296 = self_;
							if (292560 - 449540 != -156979)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009794 RID: 38804 RVA: 0x011DC1E8 File Offset: 0x011DA3E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249980 - 116032 != 133949)
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
						this.$self_$42296.LeaveGame();
						if (226407 - 469976 != -243569)
						{
							continue;
						}
						this.YieldDefault(1);
						if (29118 - 163179 != -134060)
						{
							goto Block_21;
						}
						continue;
					default:
						if (219595 - 539488 != -319893)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (472 - 376767 == -376295)
					{
						Game.mStateTime = Time.time;
						if (293978 - 454254 != -160275)
						{
							this.$$switch$7668$42294 = PlayerData.SaveGuild;
							if (57175 - 110458 != -53282)
							{
								if (this.$$switch$7668$42294 == 1)
								{
									if (293419 - 365183 == -71763)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (280746 - 17979 != 262767)
									{
										continue;
									}
								}
								else if (this.$$switch$7668$42294 == 2)
								{
									if (174996 - 553027 != -378031)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (61024 - 12231 != 48793)
									{
										continue;
									}
								}
								else if (this.$$switch$7668$42294 == 3)
								{
									if (85768 - 550236 == -464467)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (64141 - 592752 == -528610)
									{
										continue;
									}
								}
								else if (this.$$switch$7668$42294 == 4)
								{
									if (174687 - 155858 == 18830)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (50026 - 130334 != -80308)
									{
										continue;
									}
								}
								else if (this.$$switch$7668$42294 == 5)
								{
									if (122814 - 450256 != -327442)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (240456 - 478813 == -238356)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (72448 - 275444 != -202996)
									{
										continue;
									}
								}
								this.$mGameGui$42295 = (GameGui)this.$self_$42296.GetComponent(typeof(GameGui));
								if (33793 - 422191 == -388398)
								{
									if (this.$mGameGui$42295)
									{
										if (228751 - 261827 != -33076)
										{
											continue;
										}
										this.$mGameGui$42295.close();
										if (213706 - 547051 != -333345)
										{
											continue;
										}
									}
									this.$self_$42296.SendMessage("fadeOut");
									if (10107 - 210222 != -200114)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_21:
				IL_363:
				return false;
			}

			// Token: 0x06009795 RID: 38805 RVA: 0x011DC56C File Offset: 0x011DA76C
			internal static bool a3gmXIV2zD6y3lUGCjZ7()
			{
				return true;
			}

			// Token: 0x06009796 RID: 38806 RVA: 0x011DC570 File Offset: 0x011DA770
			internal static bool R06mcmV8aEvg5SJ8EqKR()
			{
				return false;
			}

			// Token: 0x04008CB7 RID: 36023
			internal int $$switch$7668$42294;

			// Token: 0x04008CB8 RID: 36024
			internal GameGui $mGameGui$42295;

			// Token: 0x04008CB9 RID: 36025
			internal M916_CityUnderSiege $self_$42296;
		}
	}
}
