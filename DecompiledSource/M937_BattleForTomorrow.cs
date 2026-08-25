using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001BAE RID: 7086
[Serializable]
public class M937_BattleForTomorrow : MonoBehaviour
{
	// Token: 0x0600A573 RID: 42355 RVA: 0x012A7750 File Offset: 0x012A5950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M937_BattleForTomorrow()
	{
		if (854 - 537904 != -537050)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (148695 - 397779 != -249083)
			{
				base..ctor();
				if (288385 - 340666 != -52280)
				{
					this.Lc4n60mkJOK = "blank";
					if (33690 - 220329 == -186639)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A574 RID: 42356 RVA: 0x012A77EC File Offset: 0x012A59EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (96446 - 431571 != -335125)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (189509 - 363060 != -173550)
			{
				Game.mGameType = 4;
				if (162078 - 370225 != -208146)
				{
					if (Chat.Initialized)
					{
						if (142720 - 316577 != -173856)
						{
							Chat.ChatDisplay.Clear();
							if (112251 - 245740 == -133489)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (261746 - 487254 != -225507)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A575 RID: 42357 RVA: 0x012A78D0 File Offset: 0x012A5AD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (22780 - 169280 != -146499)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (40548 - 422975 != -382426)
				{
					if (Game.mNextGameCode != 937)
					{
						break;
					}
					if (264952 - 33032 != 231921)
					{
						Game.nextGame();
						if (179476 - 461671 != -282194)
						{
							Game.mGameCode = 937;
							if (292553 - 212547 != 80007)
							{
								Game.mGameType = 5;
								if (190957 - 262794 != -71836)
								{
									Game.mGameTime = Time.time;
									if (121428 - 222813 != -101384)
									{
										Game.mGameScore = 0;
										if (298696 - 254389 != 44308)
										{
											Game.mGameMana = 0;
											if (178098 - 262870 == -84772)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (46171 - 225735 != -179563)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (57745 - 85562 != -27816)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (243560 - 474335 == -230775)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (118951 - 72744 == 46207)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (101424 - 134434 == -33010)
																{
																	this.xiTn6SrlwjK = PhotonClient.Connection;
																	if (230844 - 579120 != -348275)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (143209 - 210658 != -67448)
																		{
																			this.InitGame();
																			if (285869 - 106090 != 179780)
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
				if (60275 - 172531 != -112255)
				{
					Game.mGameType = 99;
					if (12863 - 156040 != -143176)
					{
						this.StartCoroutine_Auto(this.StoryEvent());
						if (2981 - 509669 == -506688)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A576 RID: 42358 RVA: 0x012A7BC4 File Offset: 0x012A5DC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (30813 - 200858 != -170044)
		{
		}
		for (;;)
		{
			GUI.depth = 3;
			if (195221 - 540699 == -345478)
			{
				GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
				if (286756 - 534598 != -247841)
				{
					float num = (float)(1024 * Screen.width / Screen.height);
					if (99801 - 135707 == -35906)
					{
						float num2 = (float)Screen.height / 1024f;
						if (115654 - 281646 != -165991)
						{
							string lc4n60mkJOK = this.Lc4n60mkJOK;
							if (24841 - 595546 != -570704)
							{
								if (lc4n60mkJOK == "EndImage1")
								{
									if (60881 - 420809 == -359928)
									{
										if (!this.EndImage1)
										{
											break;
										}
										if (57177 - 370480 == -313303)
										{
											GUI.DrawTexture(new Rect((float)0, (float)0, num, (float)1024), this.EndBlack);
											if (283795 - 355983 != -72187)
											{
												float num3 = (float)this.EndImage1.width * (1024f / (float)this.EndImage1.height);
												if (242060 - 216792 == 25268)
												{
													GUI.DrawTexture(new Rect(0.5f * (num - num3), (float)0, num3, (float)1024), this.EndImage1);
													if (192319 - 70118 == 122201)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (lc4n60mkJOK == "EndImage2")
								{
									if (209575 - 566928 == -357353)
									{
										if (!this.EndImage2)
										{
											break;
										}
										if (113954 - 243368 == -129414)
										{
											GUI.DrawTexture(new Rect((float)0, (float)0, num, (float)1024), this.EndBlack);
											if (234454 - 162892 == 71562)
											{
												float num4 = (float)this.EndImage2.width * (1024f / (float)this.EndImage2.height);
												if (108838 - 74361 == 34477)
												{
													GUI.DrawTexture(new Rect(0.5f * (num - num4), (float)0, num4, (float)1024), this.EndImage2);
													if (82681 - 62189 != 20493)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (lc4n60mkJOK == "EndImage3")
								{
									if (54685 - 58343 == -3658)
									{
										if (!this.EndImage3)
										{
											break;
										}
										if (85145 - 130095 != -44949)
										{
											GUI.DrawTexture(new Rect((float)0, (float)0, num, (float)1024), this.EndBlack);
											if (137650 - 299510 != -161859)
											{
												float num5 = (float)this.EndImage3.width * (1024f / (float)this.EndImage3.height);
												if (173970 - 196828 != -22857)
												{
													GUI.DrawTexture(new Rect(0.5f * (num - num5), (float)0, num5, (float)1024), this.EndImage3);
													if (13792 - 142044 != -128251)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (lc4n60mkJOK == "EndImage4")
								{
									if (50841 - 20351 == 30490)
									{
										if (!this.EndImage4)
										{
											break;
										}
										if (218848 - 306997 == -88149)
										{
											GUI.DrawTexture(new Rect((float)0, (float)0, num, (float)1024), this.EndBlack);
											if (50632 - 338703 == -288071)
											{
												float num6 = (float)this.EndImage4.width * (1024f / (float)this.EndImage4.height);
												if (165029 - 4118 == 160911)
												{
													GUI.DrawTexture(new Rect(0.5f * (num - num6), (float)0, num6, (float)1024), this.EndImage4);
													if (25413 - 1839 == 23574)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (lc4n60mkJOK == "EndImage5")
								{
									if (228020 - 401212 != -173191)
									{
										if (!this.EndImage5)
										{
											break;
										}
										if (67487 - 237863 == -170376)
										{
											GUI.DrawTexture(new Rect((float)0, (float)0, num, (float)1024), this.EndWhite);
											if (192350 - 99679 == 92671)
											{
												float num7 = (float)this.EndImage5.width * (1024f / (float)this.EndImage5.height);
												if (223670 - 14509 == 209161)
												{
													GUI.DrawTexture(new Rect(0.5f * (num - num7), (float)0, num7, (float)1024), this.EndImage5);
													if (260201 - 332271 != -72069)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (lc4n60mkJOK == "EndWhite")
								{
									if (194498 - 126131 != 68368)
									{
										GUI.DrawTexture(new Rect((float)0, (float)0, num, (float)1024), this.EndWhite);
										if (124700 - 19272 == 105428)
										{
											break;
										}
									}
								}
								else if (lc4n60mkJOK == "EndBlack")
								{
									if (33528 - 145712 == -112184)
									{
										GUI.DrawTexture(new Rect((float)0, (float)0, num, (float)1024), this.EndBlack);
										if (79543 - 445205 == -365662)
										{
											break;
										}
									}
								}
								else
								{
									if (!(lc4n60mkJOK == "EndCredit"))
									{
										break;
									}
									if (172802 - 498818 == -326016)
									{
										float num8 = Time.time - this.nRQn68fsRHA;
										if (94766 - 248341 == -153575)
										{
											int num9 = 15;
											if (71669 - 366881 != -295211)
											{
												GUI.DrawTexture(new Rect((float)0, (float)0, num, (float)1024), this.EndWhite);
												if (168754 - 544028 != -375273)
												{
													if (this.EndCredit1)
													{
														if (84259 - 524661 == -440401)
														{
															continue;
														}
														if (num8 >= (float)(0 * num9))
														{
															if (270772 - 349529 != -78757)
															{
																continue;
															}
															if (num8 <= (float)(2 * num9))
															{
																if (282688 - 259489 != 23199)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect(0.5f * num - (float)512, Mathf.Lerp((float)1024, (float)-1024, num8 / (float)(2 * num9)), (float)1024, (float)1024), this.EndCredit1);
																if (18479 - 108341 != -89862)
																{
																	continue;
																}
															}
														}
													}
													if (this.EndCredit2)
													{
														if (86880 - 233048 != -146168)
														{
															continue;
														}
														if (num8 >= (float)(1 * num9))
														{
															if (40795 - 269201 != -228406)
															{
																continue;
															}
															if (num8 <= (float)(3 * num9))
															{
																if (123051 - 122581 == 471)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect(0.5f * num - (float)512, Mathf.Lerp((float)1024, (float)-1024, (num8 - (float)num9) / (float)(2 * num9)), (float)1024, (float)1024), this.EndCredit2);
																if (274876 - 325669 != -50793)
																{
																	continue;
																}
															}
														}
													}
													if (this.EndCredit3)
													{
														if (21055 - 314660 != -293605)
														{
															continue;
														}
														if (num8 >= (float)(2 * num9))
														{
															if (77820 - 558869 != -481049)
															{
																continue;
															}
															if (num8 <= (float)(4 * num9))
															{
																if (96850 - 190001 == -93150)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect(0.5f * num - (float)512, Mathf.Lerp((float)1024, (float)-1024, (num8 - (float)(2 * num9)) / (float)(2 * num9)), (float)1024, (float)1024), this.EndCredit3);
																if (142820 - 78 == 142743)
																{
																	continue;
																}
															}
														}
													}
													if (this.EndCredit4)
													{
														if (97280 - 506146 != -408866)
														{
															continue;
														}
														if (num8 >= (float)(3 * num9))
														{
															if (240386 - 313774 != -73388)
															{
																continue;
															}
															if (num8 <= (float)(5 * num9))
															{
																if (291922 - 146766 != 145156)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect(0.5f * num - (float)512, Mathf.Lerp((float)1024, (float)-1024, (num8 - (float)(3 * num9)) / (float)(2 * num9)), (float)1024, (float)1024), this.EndCredit4);
																if (147632 - 220423 != -72791)
																{
																	continue;
																}
															}
														}
													}
													if (this.EndCredit5)
													{
														if (271141 - 178618 != 92523)
														{
															continue;
														}
														if (num8 >= (float)(4 * num9))
														{
															if (39510 - 137519 == -98008)
															{
																continue;
															}
															if (num8 <= (float)(6 * num9))
															{
																if (173537 - 32822 != 140715)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect(0.5f * num - (float)512, Mathf.Lerp((float)1024, (float)-1024, (num8 - (float)(4 * num9)) / (float)(2 * num9)), (float)1024, (float)1024), this.EndCredit5);
																if (129012 - 197294 == -68281)
																{
																	continue;
																}
															}
														}
													}
													if (this.EndCredit6)
													{
														if (251863 - 1604 == 250260)
														{
															continue;
														}
														if (num8 >= (float)(5 * num9))
														{
															if (47223 - 369233 == -322009)
															{
																continue;
															}
															if (num8 <= (float)(7 * num9))
															{
																if (190963 - 549519 != -358556)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect(0.5f * num - (float)512, Mathf.Lerp((float)1024, (float)-1024, (num8 - (float)(5 * num9)) / (float)(2 * num9)), (float)1024, (float)1024), this.EndCredit6);
																if (86805 - 181923 == -95117)
																{
																	continue;
																}
															}
														}
													}
													if (this.EndCredit7)
													{
														if (277274 - 146038 == 131237)
														{
															continue;
														}
														if (num8 >= (float)(6 * num9))
														{
															if (86348 - 285370 != -199022)
															{
																continue;
															}
															if (num8 <= (float)(8 * num9))
															{
																if (65882 - 20148 == 45735)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect(0.5f * num - (float)512, Mathf.Lerp((float)1024, (float)-1024, (num8 - (float)(6 * num9)) / (float)(2 * num9)), (float)1024, (float)1024), this.EndCredit7);
																if (103766 - 379428 == -275661)
																{
																	continue;
																}
															}
														}
													}
													if (this.EndCredit8)
													{
														if (86597 - 264777 == -178179)
														{
															continue;
														}
														if (num8 >= (float)(7 * num9))
														{
															if (33581 - 284568 != -250987)
															{
																continue;
															}
															if (num8 <= (float)(9 * num9))
															{
																if (88026 - 52609 != 35417)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect(0.5f * num - (float)512, Mathf.Lerp((float)1024, (float)-1024, (num8 - (float)(7 * num9)) / (float)(2 * num9)), (float)1024, (float)1024), this.EndCredit8);
																if (260471 - 283396 == -22924)
																{
																	continue;
																}
															}
														}
													}
													if (this.EndCredit9)
													{
														if (167316 - 280747 != -113431)
														{
															continue;
														}
														if (num8 >= (float)(8 * num9))
														{
															if (182113 - 83377 == 98737)
															{
																continue;
															}
															if (num8 <= (float)(10 * num9))
															{
																if (262867 - 155315 == 107553)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect(0.5f * num - (float)512, Mathf.Lerp((float)1024, (float)0, (num8 - (float)(8 * num9)) / (float)num9), (float)1024, (float)1024), this.EndCredit9);
																if (210150 - 488713 != -278563)
																{
																	continue;
																}
															}
														}
													}
													if (Game.mGameState != eGameState.AllHold)
													{
														break;
													}
													if (133657 - 225100 == -91443)
													{
														if (!Input.GetKeyDown(KeyCode.Escape))
														{
															break;
														}
														if (36527 - 8636 == 27891)
														{
															Game.sendMissionEvent(9371, 0);
															if (137015 - 115102 != 21914)
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

	// Token: 0x0600A577 RID: 42359 RVA: 0x012A8B7C File Offset: 0x012A6D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (68864 - 455205 != -386340)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (159126 - 380642 == -221516)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (43007 - 557357 == -514350)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (197910 - 48817 != 149094)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (23246 - 397949 == -374703)
						{
							int num4 = num;
							if (156357 - 84932 != 71426)
							{
								if (num4 == 9371)
								{
									if (237212 - 98076 == 139136)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (136901 - 528137 == -391236)
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

	// Token: 0x0600A578 RID: 42360 RVA: 0x012A8CE8 File Offset: 0x012A6EE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StoryEvent()
	{
		return new M937_BattleForTomorrow.$StoryEvent$44100(this).GetEnumerator();
	}

	// Token: 0x0600A579 RID: 42361 RVA: 0x012A8CF8 File Offset: 0x012A6EF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void getDress(GameObject nModel, string nType)
	{
		if (38414 - 354617 != -316203)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(1);
			if (58784 - 103524 == -44740)
			{
				CharacterDataClass cdat2 = CharacterData.getCDat(2);
				if (81512 - 133523 == -52011)
				{
					CharacterDataClass cdat3 = CharacterData.getCDat(3);
					if (35509 - 110834 != -75324)
					{
						if (cdat != null)
						{
							if (227179 - 429800 != -202621)
							{
								continue;
							}
							if (cdat2 != null)
							{
								if (25071 - 122338 != -97267)
								{
									continue;
								}
								if (cdat3 == null)
								{
									if (51784 - 73219 != -21435)
									{
										continue;
									}
								}
								else if (cdat.Type == nType)
								{
									if (291804 - 384381 != -92577)
									{
										continue;
									}
									nModel.SendMessage("EquipCDat", 1);
									if (30501 - 559564 != -529063)
									{
										continue;
									}
									break;
								}
								else if (cdat2.Type == nType)
								{
									if (89891 - 259874 == -169982)
									{
										continue;
									}
									nModel.SendMessage("EquipCDat", 2);
									if (79705 - 375373 != -295667)
									{
										break;
									}
									continue;
								}
								else if (cdat3.Type == nType)
								{
									if (248858 - 337378 != -88520)
									{
										continue;
									}
									nModel.SendMessage("EquipCDat", 3);
									if (68040 - 114512 != -46471)
									{
										break;
									}
									continue;
								}
								else
								{
									nModel.SendMessage("EquipAll");
									if (114593 - 85863 != 28731)
									{
										break;
									}
									continue;
								}
							}
						}
						Debug.LogError("CharacterData Error");
						if (167845 - 91799 == 76046)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A57A RID: 42362 RVA: 0x012A8F5C File Offset: 0x012A715C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hideModel(GameObject nModel, bool nHide)
	{
		if (162965 - 60361 != 102604)
		{
		}
		IL_AD:
		while (nModel)
		{
			if (217790 - 414890 != -197099)
			{
				Component[] componentsInChildren = nModel.GetComponentsInChildren(typeof(Renderer));
				if (200237 - 512206 == -311969)
				{
					int i = 0;
					if (30424 - 164943 != -134518)
					{
						Component[] array = componentsInChildren;
						if (77927 - 543874 == -465947)
						{
							int length = array.Length;
							if (14879 - 420526 == -405647)
							{
								while (i < length)
								{
									((Renderer)array[i]).enabled = !nHide;
									if (196107 - 147479 == 48629)
									{
										goto IL_AD;
									}
									i++;
									if (104839 - 146889 != -42050)
									{
										goto IL_AD;
									}
								}
								if (78907 - 409024 != -330116)
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

	// Token: 0x0600A57B RID: 42363 RVA: 0x012A90B0 File Offset: 0x012A72B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnPlayCut3()
	{
		return new M937_BattleForTomorrow.$OnPlayCut3$44124(this).GetEnumerator();
	}

	// Token: 0x0600A57C RID: 42364 RVA: 0x012A90C0 File Offset: 0x012A72C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnPlayCut4()
	{
		return new M937_BattleForTomorrow.$OnPlayCut4$44127(this).GetEnumerator();
	}

	// Token: 0x0600A57D RID: 42365 RVA: 0x012A90D0 File Offset: 0x012A72D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnPlayCut5()
	{
		return new M937_BattleForTomorrow.$OnPlayCut5$44130(this).GetEnumerator();
	}

	// Token: 0x0600A57E RID: 42366 RVA: 0x012A90E0 File Offset: 0x012A72E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnPlayCut6()
	{
		return new M937_BattleForTomorrow.$OnPlayCut6$44133(this).GetEnumerator();
	}

	// Token: 0x0600A57F RID: 42367 RVA: 0x012A90F0 File Offset: 0x012A72F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnPlayCut7()
	{
		return new M937_BattleForTomorrow.$OnPlayCut7$44136(this).GetEnumerator();
	}

	// Token: 0x0600A580 RID: 42368 RVA: 0x012A9100 File Offset: 0x012A7300
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPlayCut8()
	{
		if (this.penguin_hit)
		{
			UnityEngine.Object.Instantiate(this.penguin_hit, Vector3.zero, Quaternion.identity);
		}
	}

	// Token: 0x0600A581 RID: 42369 RVA: 0x012A9128 File Offset: 0x012A7328
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnPlayCut9()
	{
		return new M937_BattleForTomorrow.$OnPlayCut9$44140(this).GetEnumerator();
	}

	// Token: 0x0600A582 RID: 42370 RVA: 0x012A9138 File Offset: 0x012A7338
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnPlayCut10()
	{
		return new M937_BattleForTomorrow.$OnPlayCut10$44143(this).GetEnumerator();
	}

	// Token: 0x0600A583 RID: 42371 RVA: 0x012A9148 File Offset: 0x012A7348
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnPlayCut12()
	{
		return new M937_BattleForTomorrow.$OnPlayCut12$44146(this).GetEnumerator();
	}

	// Token: 0x0600A584 RID: 42372 RVA: 0x012A9158 File Offset: 0x012A7358
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnPlayCut13()
	{
		return new M937_BattleForTomorrow.$OnPlayCut13$44149(this).GetEnumerator();
	}

	// Token: 0x0600A585 RID: 42373 RVA: 0x012A9168 File Offset: 0x012A7368
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPlayCut14()
	{
		if (263658 - 391022 != -127363)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("DarkFalcon");
			if (27415 - 71696 == -44281)
			{
				if (!gameObject)
				{
					break;
				}
				if (160556 - 433307 != -272750)
				{
					if (!this.gun_broken)
					{
						break;
					}
					if (277866 - 273378 != 4489)
					{
						Transform transform = global::Math.findChildObject(gameObject.transform, "DarkFalcon_gun_tri_(1)");
						if (190108 - 394633 == -204525)
						{
							if (transform)
							{
								if (167715 - 532342 == -364627)
								{
									GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(this.gun_broken, Vector3.zero, Quaternion.identity);
									if (14763 - 269422 != -254658)
									{
										if (gameObject2)
										{
											if (7124 - 457158 != -450034)
											{
												continue;
											}
											gameObject2.name = "DarkFalcon_gun_tri_(1)";
											if (275065 - 187069 == 87997)
											{
												continue;
											}
											gameObject2.transform.parent = transform.parent;
											if (4075 - 109023 != -104948)
											{
												continue;
											}
											gameObject2.transform.position = transform.position;
											if (4857 - 504447 != -499590)
											{
												continue;
											}
											gameObject2.transform.rotation = transform.rotation;
											if (45095 - 28006 != 17089)
											{
												continue;
											}
										}
										UnityEngine.Object.Destroy(transform.gameObject);
										if (109990 - 375217 != -265226)
										{
											break;
										}
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find oGun transform");
								if (189648 - 82113 != 107536)
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

	// Token: 0x0600A586 RID: 42374 RVA: 0x012A93B4 File Offset: 0x012A75B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (132673 - 573396 != -440722)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (109073 - 349061 != -239987)
			{
				Time.timeScale = 1f;
				if (268498 - 82051 != 186448)
				{
					Hashtable customOpParameters = new Hashtable();
					if (138391 - 225476 == -87085)
					{
						this.xiTn6SrlwjK.OpCustom(52, customOpParameters, true);
						if (141700 - 485412 != -343711)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (180361 - 430188 != -249826)
							{
								this.audio.volume = (float)1;
								if (18701 - 493024 == -474323)
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

	// Token: 0x0600A587 RID: 42375 RVA: 0x012A94D0 File Offset: 0x012A76D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (36168 - 460298 != -424129)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (104514 - 408205 == -303691)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (17418 - 98609 != -81190)
				{
					Game.mGameState = eGameState.Setup;
					if (274573 - 30296 == 244277)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A588 RID: 42376 RVA: 0x012A9574 File Offset: 0x012A7774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		int num = RuntimeServices.UnboxInt32(data[43]);
		Game.setGameState(eGameState.Ready);
	}

	// Token: 0x0600A589 RID: 42377 RVA: 0x012A959C File Offset: 0x012A779C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (75587 - 279766 != -204179)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (247073 - 346736 != -99662)
			{
				Game.mGameState = eGameState.Ready;
				if (66029 - 214176 != -148146)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (42090 - 510588 != -468497)
					{
						GameObject gameObject = GameObject.Find("StartPoint1");
						if (227731 - 429979 == -202248)
						{
							if (!gameObject)
							{
								break;
							}
							if (174481 - 567267 == -392786)
							{
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (163912 - 146383 == 17529)
								{
									if (spawnPos != Vector3.zero)
									{
										if (97376 - 82196 == 15180)
										{
											this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
											if (113796 - 570553 == -456757)
											{
												break;
											}
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
										if (89701 - 574541 != -484839)
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

	// Token: 0x0600A58A RID: 42378 RVA: 0x012A975C File Offset: 0x012A795C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (216718 - 261905 != -45186)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (236229 - 18408 != 217822)
			{
				Game.mGameState = eGameState.Start;
				if (171147 - 569151 == -398004)
				{
					Game.mGameTime = Time.time;
					if (223625 - 264416 != -40790)
					{
						this.StartCoroutine_Auto(this.StoryEvent());
						if (247222 - 566811 != -319588)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A58B RID: 42379 RVA: 0x012A9824 File Offset: 0x012A7A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A58C RID: 42380 RVA: 0x012A9828 File Offset: 0x012A7A28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (47321 - 481698 != -434376)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (200499 - 320001 != -119501)
			{
				hashtable.Add(71, CID);
				if (237685 - 524177 != -286491)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (13857 - 208368 != -194510)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (155105 - 49988 == 105117)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (277561 - 412942 != -135380)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (213717 - 325899 != -112181)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (218869 - 577878 == -359009)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (158412 - 65452 != 92961)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (172807 - 290271 == -117464)
											{
												this.xiTn6SrlwjK.OpCustom(61, hashtable, true);
												if (260209 - 596500 != -336290)
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

	// Token: 0x0600A58D RID: 42381 RVA: 0x012A9AB4 File Offset: 0x012A7CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (216448 - 9881 != 206568)
		{
		}
		for (;;)
		{
			GameObject exists = Game.createPlayer(data);
			if (192498 - 308728 == -116230)
			{
				if (!exists)
				{
					break;
				}
				if (196298 - 67970 != 128329)
				{
					this.StartGame();
					if (71798 - 326413 != -254614)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A58E RID: 42382 RVA: 0x012A9B54 File Offset: 0x012A7D54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (283606 - 248200 != 35407)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (78886 - 386812 == -307926)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (283572 - 138818 == 144754)
				{
					gameGui.ResetTeamBar();
					if (66438 - 43122 == 23316)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A58F RID: 42383 RVA: 0x012A9C00 File Offset: 0x012A7E00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (253571 - 217664 != 35908)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (167822 - 216370 != -48547)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (167927 - 400981 == -233054)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (159088 - 250507 != -91418)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A590 RID: 42384 RVA: 0x012A9CC4 File Offset: 0x012A7EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A591 RID: 42385 RVA: 0x012A9CF0 File Offset: 0x012A7EF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (261026 - 149192 != 111835)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (116910 - 180681 == -63771)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (202666 - 492260 != -289593)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (194970 - 309242 != -114271)
					{
						Hashtable hashtable = new Hashtable();
						if (182303 - 141287 != 41017)
						{
							hashtable.Add(43, PlayerData.UID);
							if (228677 - 523782 != -295104)
							{
								hashtable.Add(71, nCID);
								if (232372 - 71878 == 160494)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (263996 - 267293 != -3296)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (216599 - 258640 != -42040)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (42418 - 136664 != -94245)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (154532 - 122907 == 31625)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (15221 - 297936 != -282714)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (27442 - 568843 == -541401)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (27136 - 206020 != -178883)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (109965 - 24843 != 85123)
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

	// Token: 0x0600A592 RID: 42386 RVA: 0x012AA010 File Offset: 0x012A8210
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M937_BattleForTomorrow.$onChangePlayer$44153(data, this).GetEnumerator();
	}

	// Token: 0x0600A593 RID: 42387 RVA: 0x012AA020 File Offset: 0x012A8220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameComplete(Hashtable data)
	{
		if (4930 - 267805 != -262874)
		{
		}
		for (;;)
		{
			Debug.Log("On Event Complete:" + data[31]);
			if (191414 - 37440 == 153974)
			{
				if (Game.mGameState > eGameState.AllHold)
				{
					if (3322 - 58512 != -55189)
					{
						break;
					}
				}
				else
				{
					Game.mGameState = eGameState.Complete;
					if (71438 - 340120 == -268682)
					{
						this.SendMessage("fadeOut");
						if (208440 - 80538 != 127903)
						{
							this.StartCoroutine_Auto(this.ReturnToTown());
							if (221144 - 581976 != -360831)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A594 RID: 42388 RVA: 0x012AA124 File Offset: 0x012A8324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M937_BattleForTomorrow.$ReturnToTown$44160(this).GetEnumerator();
	}

	// Token: 0x0600A595 RID: 42389 RVA: 0x012AA134 File Offset: 0x012A8334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M937_BattleForTomorrow.$ReturnToGuild$44165(this).GetEnumerator();
	}

	// Token: 0x0600A596 RID: 42390 RVA: 0x012AA144 File Offset: 0x012A8344
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M937_BattleForTomorrow.$ReturnToCamp$44169(this).GetEnumerator();
	}

	// Token: 0x0600A597 RID: 42391 RVA: 0x012AA154 File Offset: 0x012A8354
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (205695 - 221951 != -16256)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (227842 - 214657 != 13186)
			{
				Hashtable hashtable = new Hashtable();
				if (271867 - 158906 == 112961)
				{
					hashtable.Add(43, PlayerData.UID);
					if (240743 - 506304 == -265561)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (255589 - 261101 == -5512)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A598 RID: 42392 RVA: 0x012AA22C File Offset: 0x012A842C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A599 RID: 42393 RVA: 0x012AA240 File Offset: 0x012A8440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (243054 - 282025 != -38971)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (115045 - 553725 != -438679)
			{
				Hashtable hashtable = new Hashtable();
				if (130107 - 255981 != -125873)
				{
					if (Game.mNextGameCode == 30)
					{
						if (296980 - 375847 != -78867)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (33933 - 304908 == -270974)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (63181 - 333040 != -269859)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (126430 - 34040 != 92390)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (232660 - 422841 == -190180)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (88125 - 464175 != -376050)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (217731 - 244911 == -27179)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (267860 - 141309 != 126551)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (148877 - 31820 != 117057)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (108597 - 274891 == -166293)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (180315 - 357404 != -177089)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (155974 - 560475 != -404501)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (26635 - 212089 != -185454)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (106234 - 359715 != -253481)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (23213 - 269623 == -246409)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (147434 - 53483 == 93952)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (217638 - 435036 == -217397)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (269605 - 527889 == -258283)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (123125 - 32853 != 90272)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (282789 - 42186 == 240604)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (164208 - 597231 == -433022)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (218751 - 128940 == 89812)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (90747 - 409448 == -318700)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (176681 - 213977 != -37296)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (208778 - 3122 == 205657)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (227214 - 113352 == 113863)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (156784 - 207084 != -50300)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (78443 - 352618 != -274175)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (168986 - 195545 != -26558)
					{
						this.xiTn6SrlwjK.OpCustom(42, hashtable, true);
						if (266783 - 559207 != -292423)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A59A RID: 42394 RVA: 0x012AA7F4 File Offset: 0x012A89F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A59B RID: 42395 RVA: 0x012AA804 File Offset: 0x012A8A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A59C RID: 42396 RVA: 0x012AA808 File Offset: 0x012A8A08
	internal static bool aMGIc0VvnSGat1S3n1wS()
	{
		return true;
	}

	// Token: 0x0600A59D RID: 42397 RVA: 0x012AA80C File Offset: 0x012A8A0C
	internal static bool ovcNIyVv6SiPZb82m5FM()
	{
		return false;
	}

	// Token: 0x0400942E RID: 37934
	private LitePeer xiTn6SrlwjK;

	// Token: 0x0400942F RID: 37935
	private float AyFn6BrEp3b;

	// Token: 0x04009430 RID: 37936
	private string Lc4n60mkJOK;

	// Token: 0x04009431 RID: 37937
	private float nRQn68fsRHA;

	// Token: 0x04009432 RID: 37938
	public Texture EndWhite;

	// Token: 0x04009433 RID: 37939
	public Texture EndBlack;

	// Token: 0x04009434 RID: 37940
	public Texture EndImage1;

	// Token: 0x04009435 RID: 37941
	public Texture EndImage2;

	// Token: 0x04009436 RID: 37942
	public Texture EndImage3;

	// Token: 0x04009437 RID: 37943
	public Texture EndImage4;

	// Token: 0x04009438 RID: 37944
	public Texture EndImage5;

	// Token: 0x04009439 RID: 37945
	public Texture EndCredit1;

	// Token: 0x0400943A RID: 37946
	public Texture EndCredit2;

	// Token: 0x0400943B RID: 37947
	public Texture EndCredit3;

	// Token: 0x0400943C RID: 37948
	public Texture EndCredit4;

	// Token: 0x0400943D RID: 37949
	public Texture EndCredit5;

	// Token: 0x0400943E RID: 37950
	public Texture EndCredit6;

	// Token: 0x0400943F RID: 37951
	public Texture EndCredit7;

	// Token: 0x04009440 RID: 37952
	public Texture EndCredit8;

	// Token: 0x04009441 RID: 37953
	public Texture EndCredit9;

	// Token: 0x04009442 RID: 37954
	private float sSjn6iwy3AT;

	// Token: 0x04009443 RID: 37955
	private int Kqcn6DpwM3K;

	// Token: 0x04009444 RID: 37956
	private float Sign6mAAYkt;

	// Token: 0x04009445 RID: 37957
	public AudioClip music_mission;

	// Token: 0x04009446 RID: 37958
	public AudioClip music_credit;

	// Token: 0x04009447 RID: 37959
	public GameObject braveSpirit;

	// Token: 0x04009448 RID: 37960
	public AudioClip braveSpirit_vc;

	// Token: 0x04009449 RID: 37961
	public GameObject instantRush;

	// Token: 0x0400944A RID: 37962
	public GameObject earthSmasher_ring;

	// Token: 0x0400944B RID: 37963
	public GameObject earthSmasher_hit;

	// Token: 0x0400944C RID: 37964
	public AudioClip earthSmasher_vc;

	// Token: 0x0400944D RID: 37965
	public GameObject rushingFalcon_ring;

	// Token: 0x0400944E RID: 37966
	public GameObject rushingFalcon_hit;

	// Token: 0x0400944F RID: 37967
	public AudioClip rushingFalcon_vc;

	// Token: 0x04009450 RID: 37968
	public GameObject moonBlade;

	// Token: 0x04009451 RID: 37969
	public AudioClip moonBlade_vc;

	// Token: 0x04009452 RID: 37970
	public AudioClip nAttack2_vc;

	// Token: 0x04009453 RID: 37971
	public GameObject thousandShot_ring;

	// Token: 0x04009454 RID: 37972
	public GameObject thousandShot_fire;

	// Token: 0x04009455 RID: 37973
	public AudioClip thousandShot_vc;

	// Token: 0x04009456 RID: 37974
	public GameObject thousandShot_hit;

	// Token: 0x04009457 RID: 37975
	public GameObject whale_ring;

	// Token: 0x04009458 RID: 37976
	public AudioClip whale_vc;

	// Token: 0x04009459 RID: 37977
	public GameObject penguin_ring;

	// Token: 0x0400945A RID: 37978
	public GameObject penguin_cast;

	// Token: 0x0400945B RID: 37979
	public AudioClip penguin_vc;

	// Token: 0x0400945C RID: 37980
	public GameObject monkey_ring;

	// Token: 0x0400945D RID: 37981
	public GameObject monkey_fire;

	// Token: 0x0400945E RID: 37982
	public AudioClip monkey_vc;

	// Token: 0x0400945F RID: 37983
	public GameObject phoenix_fire;

	// Token: 0x04009460 RID: 37984
	public AudioClip phoenix_vc;

	// Token: 0x04009461 RID: 37985
	public GameObject chameleon_ring;

	// Token: 0x04009462 RID: 37986
	public GameObject chameleon_fire;

	// Token: 0x04009463 RID: 37987
	public AudioClip chameleon_vc;

	// Token: 0x04009464 RID: 37988
	public GameObject bat_fire;

	// Token: 0x04009465 RID: 37989
	public AudioClip bat1_vc;

	// Token: 0x04009466 RID: 37990
	public AudioClip bat2_vc;

	// Token: 0x04009467 RID: 37991
	public AudioClip bat3_vc;

	// Token: 0x04009468 RID: 37992
	public GameObject rabbit_ring;

	// Token: 0x04009469 RID: 37993
	public GameObject rabbit_fire;

	// Token: 0x0400946A RID: 37994
	public AudioClip rabbit_vc;

	// Token: 0x0400946B RID: 37995
	public GameObject monkey_hit;

	// Token: 0x0400946C RID: 37996
	public GameObject bat_hit;

	// Token: 0x0400946D RID: 37997
	public GameObject mole_ring;

	// Token: 0x0400946E RID: 37998
	public GameObject mole_fire;

	// Token: 0x0400946F RID: 37999
	public AudioClip mole_vc;

	// Token: 0x04009470 RID: 38000
	public GameObject penguin_fire;

	// Token: 0x04009471 RID: 38001
	public GameObject penguin_hit;

	// Token: 0x04009472 RID: 38002
	public GameObject cAttack_ring;

	// Token: 0x04009473 RID: 38003
	public AudioClip cAttack_vc;

	// Token: 0x04009474 RID: 38004
	public GameObject sheep_ring;

	// Token: 0x04009475 RID: 38005
	public GameObject sheep_fire;

	// Token: 0x04009476 RID: 38006
	public AudioClip sheep_vc;

	// Token: 0x04009477 RID: 38007
	public AudioClip wolf_nAttack1_vc;

	// Token: 0x04009478 RID: 38008
	public GameObject wolf_ring;

	// Token: 0x04009479 RID: 38009
	public AudioClip wolf_nAttack3_vc;

	// Token: 0x0400947A RID: 38010
	public GameObject wolf_hit;

	// Token: 0x0400947B RID: 38011
	public GameObject gun_broken;

	// Token: 0x0400947C RID: 38012
	private int Y03n6jKFcHt;

	// Token: 0x02001BAF RID: 7087
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StoryEvent$44100 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A59E RID: 42398 RVA: 0x012AA810 File Offset: 0x012A8A10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StoryEvent$44100(M937_BattleForTomorrow self_)
		{
			if (23837 - 476116 != -452279)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65308 - 356890 == -291582)
				{
					base..ctor();
					if (191120 - 157079 != 34042)
					{
						this.$self_$44123 = self_;
						if (123372 - 292836 == -169464)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A59F RID: 42399 RVA: 0x012AA8A8 File Offset: 0x012A8AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$StoryEvent$44100.$(this.$self_$44123);
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x012AA8B8 File Offset: 0x012A8AB8
		internal static bool GtUTjKVvin8Ikmq4RUiA()
		{
			return true;
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x012AA8BC File Offset: 0x012A8ABC
		internal static bool k96BMxVvKMu5cNiRDe97()
		{
			return false;
		}

		// Token: 0x0400947D RID: 38013
		internal M937_BattleForTomorrow $self_$44123;

		// Token: 0x02001BB0 RID: 7088
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5A2 RID: 42402 RVA: 0x012AA8C0 File Offset: 0x012A8AC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (204213 - 304646 != -100433)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (72530 - 324353 == -251823)
					{
						base..ctor();
						if (75718 - 207902 == -132184)
						{
							this.$self_$44122 = self_;
							if (76386 - 543605 == -467219)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A5A3 RID: 42403 RVA: 0x012AA958 File Offset: 0x012A8B58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (1135 - 149656 != -148521)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_4B75;
					case 1:
						goto IL_7DF6;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (202727 - 259549 != -56822)
							{
								continue;
							}
							goto IL_6D6B;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (84566 - 46040 != 38527)
							{
								goto Block_593;
							}
							continue;
						}
						else
						{
							this.$mStoryCamera$44101.animation.Play("c2");
							if (136662 - 267490 != -130828)
							{
								continue;
							}
							if (this.$mWolf$44103)
							{
								if (85815 - 486734 == -400918)
								{
									continue;
								}
								this.$mWolf$44103.animation.Play("c2");
								if (50242 - 428541 != -378299)
								{
									continue;
								}
							}
							if (this.$mBison$44104)
							{
								if (62563 - 531879 == -469315)
								{
									continue;
								}
								this.$mBison$44104.animation.Play("c2");
								if (4188 - 110449 != -106261)
								{
									continue;
								}
							}
							if (this.$mPanda$44105)
							{
								if (246878 - 167174 != 79704)
								{
									continue;
								}
								this.$mPanda$44105.animation.Play("c2");
								if (241836 - 165626 == 76211)
								{
									continue;
								}
							}
							if (this.$mWhale$44106)
							{
								if (242244 - 559310 != -317066)
								{
									continue;
								}
								this.$mWhale$44106.animation.Play("c2");
								if (183934 - 552316 != -368382)
								{
									continue;
								}
							}
							if (this.$mPenguin$44112)
							{
								if (49724 - 70854 == -21129)
								{
									continue;
								}
								this.$mPenguin$44112.animation.Play("c2");
								if (188011 - 584477 != -396466)
								{
									continue;
								}
							}
							if (!this.$mSheep$44113)
							{
								goto IL_B9E;
							}
							if (110656 - 307019 == -196362)
							{
								continue;
							}
							this.$mSheep$44113.animation.Play("c2");
							if (184700 - 401333 != -216632)
							{
								goto Block_139;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (273857 - 352059 != -78202)
							{
								continue;
							}
							goto IL_4D0B;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (57857 - 192003 != -134146)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c3");
								if (82674 - 328693 == -246018)
								{
									continue;
								}
							}
							if (this.$mWolf$44103)
							{
								if (30456 - 141993 != -111537)
								{
									continue;
								}
								this.$mWolf$44103.animation.Play("c3");
								if (182843 - 258397 == -75553)
								{
									continue;
								}
							}
							if (this.$mBison$44104)
							{
								if (92992 - 538151 != -445159)
								{
									continue;
								}
								this.$mBison$44104.animation.Play("c3");
								if (90080 - 502297 == -412216)
								{
									continue;
								}
							}
							if (this.$mPanda$44105)
							{
								if (238491 - 272518 != -34027)
								{
									continue;
								}
								this.$mPanda$44105.animation.Play("c3");
								if (257502 - 27976 == 229527)
								{
									continue;
								}
							}
							if (this.$mSheep$44113)
							{
								if (17491 - 126299 == -108807)
								{
									continue;
								}
								this.$mSheep$44113.animation.Play("c3");
								if (177087 - 564070 == -386982)
								{
									continue;
								}
							}
							this.$self_$44122.StartCoroutine_Auto(this.$self_$44122.OnPlayCut3());
							if (105311 - 88643 != 16668)
							{
								continue;
							}
							goto IL_5ECC;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (205346 - 65072 != 140274)
							{
								continue;
							}
							goto IL_1BA3;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (200583 - 489466 != -288883)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c4");
								if (262064 - 88943 != 173121)
								{
									continue;
								}
							}
							if (this.$mBison$44104)
							{
								if (87694 - 344322 == -256627)
								{
									continue;
								}
								this.$mBison$44104.animation.Play("c4");
								if (18373 - 555548 == -537174)
								{
									continue;
								}
							}
							if (this.$mPanda$44105)
							{
								if (292348 - 361404 == -69055)
								{
									continue;
								}
								this.$mPanda$44105.animation.Play("c4");
								if (6942 - 131350 == -124407)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (166832 - 560575 == -393742)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mDarkFalcon$44102, true);
								if (288537 - 338413 != -49876)
								{
									continue;
								}
							}
							this.$self_$44122.StartCoroutine_Auto(this.$self_$44122.OnPlayCut4());
							if (277124 - 388492 != -111367)
							{
								goto Block_671;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (254836 - 531707 != -276870)
							{
								goto Block_860;
							}
							continue;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (46776 - 187591 == -140814)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c5");
								if (28026 - 237458 == -209431)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (233700 - 308710 == -75009)
								{
									continue;
								}
								this.$mDarkFalcon$44102.animation.Play("c5");
								if (73415 - 366819 == -293403)
								{
									continue;
								}
							}
							if (this.$mBison$44104)
							{
								if (218314 - 400192 != -181878)
								{
									continue;
								}
								this.$mBison$44104.animation.Play("c5");
								if (269331 - 7774 == 261558)
								{
									continue;
								}
							}
							if (this.$mPanda$44105)
							{
								if (95509 - 54608 == 40902)
								{
									continue;
								}
								this.$mPanda$44105.animation.Play("c5");
								if (265205 - 413449 != -148244)
								{
									continue;
								}
							}
							if (this.$mCat$44107)
							{
								if (224352 - 87478 != 136874)
								{
									continue;
								}
								this.$mCat$44107.animation.Play("c5");
								if (260416 - 573516 != -313100)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (216941 - 377207 == -160265)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mDarkFalcon$44102, false);
								if (115149 - 92230 != 22919)
								{
									continue;
								}
							}
							this.$self_$44122.StartCoroutine_Auto(this.$self_$44122.OnPlayCut5());
							if (224089 - 474013 != -249923)
							{
								goto Block_329;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (15427 - 285965 != -270537)
							{
								goto Block_599;
							}
							continue;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (98823 - 21395 == 77429)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c6");
								if (151772 - 278685 == -126912)
								{
									continue;
								}
							}
							if (this.$mWhale$44106)
							{
								if (166388 - 48885 == 117504)
								{
									continue;
								}
								this.$mWhale$44106.animation.Play("c6");
								if (230270 - 395172 == -164901)
								{
									continue;
								}
							}
							if (this.$mChameleon$44108)
							{
								if (250362 - 551324 == -300961)
								{
									continue;
								}
								this.$mChameleon$44108.animation.Play("c6");
								if (96122 - 384681 != -288559)
								{
									continue;
								}
							}
							if (this.$mRabbit$44109)
							{
								if (163832 - 546434 != -382602)
								{
									continue;
								}
								this.$mRabbit$44109.animation.Play("c6");
								if (25422 - 567450 == -542027)
								{
									continue;
								}
							}
							if (this.$mMole$44110)
							{
								if (25288 - 330644 == -305355)
								{
									continue;
								}
								this.$mMole$44110.animation.Play("c6");
								if (204230 - 59619 != 144611)
								{
									continue;
								}
							}
							if (this.$mMonkey$44111)
							{
								if (114678 - 582942 == -468263)
								{
									continue;
								}
								this.$mMonkey$44111.animation.Play("c6");
								if (131917 - 487013 == -355095)
								{
									continue;
								}
							}
							if (this.$mPenguin$44112)
							{
								if (72695 - 456349 != -383654)
								{
									continue;
								}
								this.$mPenguin$44112.animation.Play("c6");
								if (46579 - 216844 == -170264)
								{
									continue;
								}
							}
							if (this.$mBat$44114)
							{
								if (234722 - 48576 == 186147)
								{
									continue;
								}
								this.$mBat$44114.animation.Play("c6");
								if (161889 - 66863 == 95027)
								{
									continue;
								}
							}
							if (this.$mIllusion1$44116)
							{
								if (106329 - 589404 != -483075)
								{
									continue;
								}
								this.$mIllusion1$44116.animation.Play("c6");
								if (153572 - 132101 != 21471)
								{
									continue;
								}
							}
							if (this.$mIllusion2$44117)
							{
								if (188765 - 150915 == 37851)
								{
									continue;
								}
								this.$mIllusion2$44117.animation.Play("c6");
								if (80077 - 165499 != -85422)
								{
									continue;
								}
							}
							if (this.$mWolf$44103)
							{
								if (112515 - 336904 == -224388)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mWolf$44103, true);
								if (180350 - 530641 == -350290)
								{
									continue;
								}
							}
							if (this.$mSheep$44113)
							{
								if (262435 - 280770 != -18335)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mSheep$44113, true);
								if (81843 - 51113 != 30730)
								{
									continue;
								}
							}
							if (this.$mPhoenix$44115)
							{
								if (13836 - 578543 == -564706)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mPhoenix$44115, false);
								if (296856 - 306704 != -9848)
								{
									continue;
								}
							}
							if (this.$mIllusion1$44116)
							{
								if (274271 - 368855 != -94584)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mIllusion1$44116, false);
								if (105572 - 549391 != -443819)
								{
									continue;
								}
							}
							if (this.$mIllusion2$44117)
							{
								if (208220 - 220830 == -12609)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mIllusion2$44117, false);
								if (41457 - 541993 != -500536)
								{
									continue;
								}
							}
							this.$self_$44122.StartCoroutine_Auto(this.$self_$44122.OnPlayCut6());
							if (10206 - 94899 != -84692)
							{
								goto Block_653;
							}
							continue;
						}
						break;
					case 8:
						if (!this.$mPhoenix$44115)
						{
							goto IL_1099;
						}
						if (98968 - 566492 != -467524)
						{
							continue;
						}
						this.$mPhoenix$44115.animation.Play("nAttack");
						if (83115 - 420064 != -336948)
						{
							goto Block_317;
						}
						continue;
					case 9:
						if (!this.$mPhoenix$44115)
						{
							goto IL_1505;
						}
						if (12383 - 102215 != -89832)
						{
							continue;
						}
						this.$mPhoenix$44115.animation.Play("root");
						if (251442 - 197401 != 54042)
						{
							goto Block_830;
						}
						continue;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (236879 - 373741 != -136862)
							{
								continue;
							}
							goto IL_3CCB;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (39018 - 571621 == -532602)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c7");
								if (71776 - 150649 != -78873)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (163026 - 169089 != -6063)
								{
									continue;
								}
								this.$mDarkFalcon$44102.animation.Play("c7");
								if (247321 - 427620 == -180298)
								{
									continue;
								}
							}
							if (this.$mMole$44110)
							{
								if (206559 - 2027 != 204532)
								{
									continue;
								}
								this.$mMole$44110.animation.Play("c7");
								if (230619 - 244372 == -13752)
								{
									continue;
								}
							}
							if (this.$mMonkey$44111)
							{
								if (167454 - 55211 != 112243)
								{
									continue;
								}
								this.$mMonkey$44111.animation.Play("battle");
								if (42610 - 332800 == -290189)
								{
									continue;
								}
							}
							if (this.$mPenguin$44112)
							{
								if (196208 - 228916 != -32708)
								{
									continue;
								}
								this.$mPenguin$44112.animation.Play("battle");
								if (87534 - 374451 == -286916)
								{
									continue;
								}
							}
							if (this.$mBison$44104)
							{
								if (150139 - 212437 != -62298)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mBison$44104, true);
								if (243668 - 440257 != -196589)
								{
									continue;
								}
							}
							if (this.$mPanda$44105)
							{
								if (193583 - 65088 != 128495)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mPanda$44105, true);
								if (247247 - 565924 == -318676)
								{
									continue;
								}
							}
							if (this.$mCat$44107)
							{
								if (240897 - 597029 != -356132)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mCat$44107, true);
								if (87333 - 21 != 87312)
								{
									continue;
								}
							}
							if (this.$mMole$44110)
							{
								if (208578 - 472520 == -263941)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mMole$44110, false);
								if (242817 - 363670 != -120853)
								{
									continue;
								}
							}
							if (this.$mPhoenix$44115)
							{
								if (247221 - 447848 != -200627)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mPhoenix$44115, true);
								if (265039 - 306828 == -41788)
								{
									continue;
								}
							}
							if (this.$mIllusion1$44116)
							{
								if (183423 - 99696 != 83727)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mIllusion1$44116, true);
								if (145482 - 478474 != -332992)
								{
									continue;
								}
							}
							if (this.$mIllusion2$44117)
							{
								if (278938 - 436415 != -157477)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mIllusion2$44117, true);
								if (171420 - 163865 == 7556)
								{
									continue;
								}
							}
							this.$self_$44122.StartCoroutine_Auto(this.$self_$44122.OnPlayCut7());
							if (233909 - 262286 != -28376)
							{
								goto Block_708;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (35461 - 27795 != 7667)
							{
								goto Block_433;
							}
							continue;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (218362 - 413359 == -194996)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c8");
								if (34461 - 53296 == -18834)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (189328 - 596817 == -407488)
								{
									continue;
								}
								this.$mDarkFalcon$44102.animation.Play("c8");
								if (11838 - 492006 == -480167)
								{
									continue;
								}
							}
							if (this.$mMole$44110)
							{
								if (179010 - 157389 == 21622)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mMole$44110, true);
								if (209469 - 92984 != 116485)
								{
									continue;
								}
							}
							this.$self_$44122.OnPlayCut8();
							if (15246 - 163383 != -148136)
							{
								goto Block_182;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (136398 - 255620 != -119221)
							{
								goto Block_787;
							}
							continue;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (50795 - 287941 != -237146)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c9");
								if (177950 - 297267 != -119317)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (53272 - 272450 != -219178)
								{
									continue;
								}
								this.$mDarkFalcon$44102.animation.Play("c9");
								if (209148 - 118940 != 90208)
								{
									continue;
								}
							}
							if (this.$mChameleon$44108)
							{
								if (222123 - 467245 != -245122)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mChameleon$44108, true);
								if (183113 - 291516 == -108402)
								{
									continue;
								}
							}
							if (this.$mBat$44114)
							{
								if (22076 - 308275 == -286198)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mBat$44114, true);
								if (36900 - 434300 != -397400)
								{
									continue;
								}
							}
							this.$self_$44122.StartCoroutine_Auto(this.$self_$44122.OnPlayCut9());
							if (151866 - 277435 != -125568)
							{
								goto Block_381;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (203349 - 343443 != -140094)
							{
								continue;
							}
							goto IL_77EC;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (197705 - 126810 == 70896)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c10");
								if (272684 - 553615 != -280931)
								{
									continue;
								}
							}
							if (this.$mWolf$44103)
							{
								if (104090 - 129894 == -25803)
								{
									continue;
								}
								this.$mWolf$44103.animation.Play("c10");
								if (1068 - 485165 == -484096)
								{
									continue;
								}
							}
							if (this.$mSheep$44113)
							{
								if (150028 - 474229 != -324201)
								{
									continue;
								}
								this.$mSheep$44113.animation.Play("c10");
								if (107457 - 545175 == -437717)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (288961 - 135290 != 153671)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mDarkFalcon$44102, true);
								if (238226 - 359462 == -121235)
								{
									continue;
								}
							}
							if (this.$mWolf$44103)
							{
								if (164457 - 31119 == 133339)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mWolf$44103, false);
								if (182215 - 384578 == -202362)
								{
									continue;
								}
							}
							if (this.$mSheep$44113)
							{
								if (41273 - 197804 != -156531)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mSheep$44113, false);
								if (66425 - 506487 == -440061)
								{
									continue;
								}
							}
							this.$self_$44122.StartCoroutine_Auto(this.$self_$44122.OnPlayCut10());
							if (172783 - 520263 != -347480)
							{
								continue;
							}
							goto IL_2D3F;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (39288 - 140152 != -100864)
							{
								continue;
							}
							goto IL_369D;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (52977 - 139655 == -86677)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c11");
								if (145987 - 583645 == -437657)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (187746 - 168366 == 19381)
								{
									continue;
								}
								this.$mDarkFalcon$44102.animation.Play("c11");
								if (226671 - 482882 != -256211)
								{
									continue;
								}
							}
							if (this.$mWhale$44106)
							{
								if (79575 - 552930 == -473354)
								{
									continue;
								}
								this.$mWhale$44106.animation.Play("battle");
								if (29055 - 239864 == -210808)
								{
									continue;
								}
							}
							if (this.$mRabbit$44109)
							{
								if (158937 - 464817 != -305880)
								{
									continue;
								}
								this.$mRabbit$44109.animation.Play("battle");
								if (155481 - 4423 == 151059)
								{
									continue;
								}
							}
							if (this.$mPenguin$44112)
							{
								if (12487 - 536947 == -524459)
								{
									continue;
								}
								this.$mPenguin$44112.animation.Play("battle");
								if (240109 - 581586 != -341477)
								{
									continue;
								}
							}
							if (this.$mBat$44114)
							{
								if (5155 - 558207 != -553052)
								{
									continue;
								}
								this.$mBat$44114.animation.Play("battle");
								if (124070 - 215962 == -91891)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (235091 - 219537 != 15554)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mDarkFalcon$44102, false);
								if (172757 - 446284 == -273526)
								{
									continue;
								}
							}
							if (this.$mWolf$44103)
							{
								if (137421 - 441167 != -303746)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mWolf$44103, true);
								if (124929 - 148352 == -23422)
								{
									continue;
								}
							}
							if (this.$mChameleon$44108)
							{
								if (107086 - 545028 == -437941)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mChameleon$44108, true);
								if (196572 - 566019 != -369447)
								{
									continue;
								}
							}
							if (!this.$mBat$44114)
							{
								goto IL_2EC8;
							}
							if (192025 - 552199 == -360173)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mBat$44114, false);
							if (114565 - 89612 != 24954)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (3225 - 289773 != -286547)
							{
								goto Block_349;
							}
							continue;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (14059 - 28603 != -14544)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c12");
								if (172000 - 231833 == -59832)
								{
									continue;
								}
							}
							if (this.$mWolf$44103)
							{
								if (107630 - 585885 != -478255)
								{
									continue;
								}
								this.$mWolf$44103.animation.Play("c12");
								if (183250 - 9840 != 173410)
								{
									continue;
								}
							}
							if (this.$mChameleon$44108)
							{
								if (62324 - 196925 == -134600)
								{
									continue;
								}
								this.$mChameleon$44108.animation.Play("battle");
								if (100344 - 58323 != 42021)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (163605 - 513994 == -350388)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mDarkFalcon$44102, true);
								if (223915 - 497154 != -273239)
								{
									continue;
								}
							}
							if (this.$mWolf$44103)
							{
								if (225882 - 541152 == -315269)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mWolf$44103, false);
								if (2124 - 466081 != -463957)
								{
									continue;
								}
							}
							if (this.$mChameleon$44108)
							{
								if (90997 - 482705 == -391707)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mChameleon$44108, false);
								if (137052 - 30690 != 106362)
								{
									continue;
								}
							}
							if (this.$mBat$44114)
							{
								if (89785 - 386471 == -296685)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mBat$44114, true);
								if (1636 - 380342 == -378705)
								{
									continue;
								}
							}
							this.$self_$44122.StartCoroutine_Auto(this.$self_$44122.OnPlayCut12());
							if (19473 - 136694 != -117220)
							{
								goto Block_167;
							}
							continue;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (140107 - 354392 != -214285)
							{
								continue;
							}
							goto IL_9DA;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (118066 - 237929 == -119862)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c13");
								if (2622 - 357679 == -355056)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (55309 - 463779 != -408470)
								{
									continue;
								}
								this.$mDarkFalcon$44102.animation.Play("c13");
								if (261163 - 236190 != 24973)
								{
									continue;
								}
							}
							if (this.$mWolf$44103)
							{
								if (194318 - 363080 != -168762)
								{
									continue;
								}
								this.$mWolf$44103.animation.Play("c13");
								if (184583 - 419433 != -234850)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (213995 - 142606 == 71390)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mDarkFalcon$44102, false);
								if (386 - 247951 == -247564)
								{
									continue;
								}
							}
							if (this.$mWolf$44103)
							{
								if (179006 - 136439 != 42567)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mWolf$44103, false);
								if (123631 - 571449 == -447817)
								{
									continue;
								}
							}
							if (this.$mChameleon$44108)
							{
								if (247066 - 167569 == 79498)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mChameleon$44108, true);
								if (15663 - 293277 == -277613)
								{
									continue;
								}
							}
							if (this.$mBat$44114)
							{
								if (250743 - 128510 != 122233)
								{
									continue;
								}
								this.$self_$44122.hideModel(this.$mBat$44114, true);
								if (17177 - 236617 == -219439)
								{
									continue;
								}
							}
							this.$self_$44122.StartCoroutine_Auto(this.$self_$44122.OnPlayCut13());
							if (168730 - 458065 != -289335)
							{
								continue;
							}
							goto IL_67FE;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (7359 - 200026 != -192666)
							{
								goto Block_763;
							}
							continue;
						}
						else
						{
							if (this.$mStoryCamera$44101)
							{
								if (227296 - 582465 == -355168)
								{
									continue;
								}
								this.$mStoryCamera$44101.animation.Play("c14");
								if (1180 - 259805 == -258624)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$44102)
							{
								if (15074 - 6536 != 8538)
								{
									continue;
								}
								this.$mDarkFalcon$44102.animation.Play("c14");
								if (69531 - 520567 != -451036)
								{
									continue;
								}
							}
							if (this.$mWolf$44103)
							{
								if (172695 - 4951 != 167744)
								{
									continue;
								}
								this.$mWolf$44103.animation.Play("c14");
								if (250050 - 396845 == -146794)
								{
									continue;
								}
							}
							this.$self_$44122.OnPlayCut14();
							if (299192 - 95381 != 203812)
							{
								goto Block_535;
							}
							continue;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (31796 - 360723 != -328926)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							if (this.$mDarkFalcon$44102)
							{
								if (26785 - 67688 == -40902)
								{
									continue;
								}
								this.$mDarkFalcon$44102.animation.CrossFade("c15");
								if (237328 - 15630 != 221698)
								{
									continue;
								}
							}
							if (this.$mWolf$44103)
							{
								if (133281 - 343254 == -209972)
								{
									continue;
								}
								this.$mWolf$44103.animation.Play("c15");
								if (176522 - 134264 != 42258)
								{
									continue;
								}
							}
							if (this.$mBison$44104)
							{
								if (201030 - 118841 == 82190)
								{
									continue;
								}
								this.$mBison$44104.animation.Play("c15");
								if (37838 - 505637 == -467798)
								{
									continue;
								}
							}
							if (this.$mPanda$44105)
							{
								if (276865 - 306041 == -29175)
								{
									continue;
								}
								this.$mPanda$44105.animation.Play("c15");
								if (150941 - 293331 != -142390)
								{
									continue;
								}
							}
							if (this.$mWhale$44106)
							{
								if (25649 - 583071 == -557421)
								{
									continue;
								}
								this.$mWhale$44106.animation.Play("c15");
								if (144452 - 277300 != -132848)
								{
									continue;
								}
							}
							if (this.$mCat$44107)
							{
								if (86138 - 46371 != 39767)
								{
									continue;
								}
								this.$mCat$44107.animation.Play("c15");
								if (232047 - 314185 != -82138)
								{
									continue;
								}
							}
							if (this.$mChameleon$44108)
							{
								if (213082 - 260068 != -46986)
								{
									continue;
								}
								this.$mChameleon$44108.animation.Play("c15");
								if (277845 - 591919 != -314074)
								{
									continue;
								}
							}
							if (this.$mRabbit$44109)
							{
								if (37513 - 32391 == 5123)
								{
									continue;
								}
								this.$mRabbit$44109.animation.Play("c15");
								if (136763 - 179307 != -42544)
								{
									continue;
								}
							}
							if (this.$mMole$44110)
							{
								if (217674 - 248430 != -30756)
								{
									continue;
								}
								this.$mMole$44110.animation.Play("c15");
								if (204559 - 544175 == -339615)
								{
									continue;
								}
							}
							if (this.$mMonkey$44111)
							{
								if (34473 - 464800 == -430326)
								{
									continue;
								}
								this.$mMonkey$44111.animation.Play("c15");
								if (31468 - 189911 == -158442)
								{
									continue;
								}
							}
							if (this.$mPenguin$44112)
							{
								if (116082 - 402623 == -286540)
								{
									continue;
								}
								this.$mChameleon$44108.animation.Play("c15");
								if (122306 - 299878 != -177572)
								{
									continue;
								}
							}
							if (this.$mSheep$44113)
							{
								if (83275 - 524373 != -441098)
								{
									continue;
								}
								this.$mSheep$44113.animation.Play("c15");
								if (248565 - 555956 == -307390)
								{
									continue;
								}
							}
							if (this.$mBat$44114)
							{
								if (73591 - 27814 != 45777)
								{
									continue;
								}
								this.$mBat$44114.animation.Play("c15");
								if (243249 - 342040 == -98790)
								{
									continue;
								}
							}
							this.$mStoryGui$44119 = (StoryGui)this.$self_$44122.GetComponent(typeof(StoryGui));
							if (246583 - 322336 == -75752)
							{
								continue;
							}
							this.$mStoryTimer$44120 = 0f;
							if (157709 - 31420 == 126290)
							{
								continue;
							}
							this.$mStoryGui$44119.startStoryMessage("DarkFalcon", "Shadow Italus", eTalkType.enemy);
							if (103062 - 264734 != -161672)
							{
								continue;
							}
							goto IL_49CF;
						}
						break;
					case 19:
						this.$mStoryGui$44119.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 101), eTalkType.enemy);
						if (297495 - 136161 == 161335)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (228072 - 508831 != -280759)
						{
							continue;
						}
						goto IL_A93;
					case 20:
						goto IL_ABC;
					case 21:
						goto IL_ABC;
					case 22:
						goto IL_6E84;
					case 23:
						goto IL_6E84;
					case 24:
						goto IL_27CC;
					case 25:
						goto IL_27CC;
					case 26:
						goto IL_566E;
					case 27:
						goto IL_566E;
					case 28:
						goto IL_6932;
					case 29:
						goto IL_6932;
					case 30:
						goto IL_334D;
					case 31:
						goto IL_334D;
					case 32:
						goto IL_4AF5;
					case 33:
						goto IL_4AF5;
					case 34:
						goto IL_6A40;
					case 35:
						goto IL_6A40;
					case 36:
						goto IL_2DA4;
					case 37:
						goto IL_2DA4;
					case 38:
						goto IL_294E;
					case 39:
						goto IL_294E;
					case 40:
						goto IL_1F14;
					case 41:
						goto IL_1F14;
					case 42:
						goto IL_413C;
					case 43:
						goto IL_413C;
					case 44:
						goto IL_3803;
					case 45:
						goto IL_3803;
					case 46:
						goto IL_6F00;
					case 47:
						goto IL_6F00;
					case 48:
						this.$self_$44122.SendMessage("blackInTimer", 1f);
						if (175578 - 299160 == -123581)
						{
							continue;
						}
						this.$self_$44122.Lc4n60mkJOK = "EndImage1";
						if (136329 - 293842 == -157512)
						{
							continue;
						}
						this.$self_$44122.nRQn68fsRHA = Time.time;
						if (131893 - 396965 != -265071)
						{
							goto Block_784;
						}
						continue;
					case 49:
						this.$mStoryGui$44119.startStoryMessage("none", "Shadow Italus", eTalkType.enemy);
						if (299326 - 553787 != -254460)
						{
							goto Block_427;
						}
						continue;
					case 50:
						this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 205), eTalkType.enemy);
						if (154740 - 68760 != 85980)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (93622 - 356244 != -262622)
						{
							continue;
						}
						goto IL_AE6;
					case 51:
						goto IL_B0F;
					case 52:
						goto IL_B0F;
					case 53:
						goto IL_2064;
					case 54:
						goto IL_2064;
					case 55:
						this.$self_$44122.SendMessage("blackInTimer", 0.5f);
						if (221249 - 62001 != 159248)
						{
							continue;
						}
						this.$self_$44122.Lc4n60mkJOK = "EndImage2";
						if (97343 - 325225 == -227881)
						{
							continue;
						}
						this.$self_$44122.nRQn68fsRHA = Time.time;
						if (245561 - 27616 == 217946)
						{
							continue;
						}
						this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 207), eTalkType.enemy);
						if (165725 - 5191 != 160534)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (71480 - 548886 != -477405)
						{
							goto Block_736;
						}
						continue;
					case 56:
						goto IL_2D15;
					case 57:
						goto IL_2D15;
					case 58:
						goto IL_3E72;
					case 59:
						goto IL_3E72;
					case 60:
						goto IL_5956;
					case 61:
						goto IL_5956;
					case 62:
						this.$self_$44122.SendMessage("blackInTimer", 0.5f);
						if (102857 - 112892 != -10035)
						{
							continue;
						}
						this.$self_$44122.Lc4n60mkJOK = "EndImage3";
						if (174937 - 558735 == -383797)
						{
							continue;
						}
						this.$self_$44122.nRQn68fsRHA = Time.time;
						if (270666 - 184670 != 85996)
						{
							continue;
						}
						this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 210), eTalkType.enemy);
						if (106909 - 9213 != 97696)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (137119 - 588756 != -451636)
						{
							goto Block_612;
						}
						continue;
					case 63:
						goto IL_374B;
					case 64:
						goto IL_374B;
					case 65:
						goto IL_16A2;
					case 66:
						goto IL_16A2;
					case 67:
						goto IL_4F1A;
					case 68:
						goto IL_4F1A;
					case 69:
						this.$self_$44122.SendMessage("blackInTimer", 0.5f);
						if (205255 - 478607 != -273352)
						{
							continue;
						}
						this.$self_$44122.Lc4n60mkJOK = "EndImage4";
						if (284510 - 244335 == 40176)
						{
							continue;
						}
						this.$self_$44122.nRQn68fsRHA = Time.time;
						if (248871 - 242466 == 6406)
						{
							continue;
						}
						this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 213), eTalkType.enemy);
						if (97739 - 265518 != -167779)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 1.5f;
						if (211729 - 516421 != -304692)
						{
							continue;
						}
						goto IL_2726;
					case 70:
						goto IL_274F;
					case 71:
						goto IL_274F;
					case 72:
						goto IL_260E;
					case 73:
						goto IL_260E;
					case 74:
						goto IL_CAC;
					case 75:
						goto IL_CAC;
					case 76:
						goto IL_7D42;
					case 77:
						goto IL_7D42;
					case 78:
						goto IL_2B0F;
					case 79:
						goto IL_4C8A;
					case 80:
						this.$mStoryGui$44119.newStoryMessage("Liger", "Boldas", Language.getMessage("M937_BattleForTomorrow", 301), eTalkType.friend);
						if (34538 - 86307 != -51769)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (258111 - 14573 != 243538)
						{
							continue;
						}
						goto IL_3920;
					case 81:
						goto IL_3949;
					case 82:
						goto IL_3949;
					case 83:
						goto IL_5DD9;
					case 84:
						goto IL_5DD9;
					case 85:
						goto IL_17BF;
					case 86:
						goto IL_17BF;
					case 87:
						goto IL_3000;
					case 88:
						goto IL_3000;
					case 89:
						goto IL_7934;
					case 90:
						goto IL_7934;
					case 91:
						goto IL_716F;
					case 92:
						goto IL_716F;
					case 93:
						goto IL_4F0;
					case 94:
						goto IL_4F0;
					case 95:
						goto IL_6256;
					case 96:
						goto IL_6256;
					case 97:
						goto IL_2217;
					case 98:
						goto IL_2217;
					case 99:
						goto IL_14DB;
					case 100:
						goto IL_14DB;
					case 101:
						goto IL_688C;
					case 102:
						goto IL_688C;
					case 103:
						goto IL_52E3;
					case 104:
						goto IL_52E3;
					case 105:
						goto IL_5571;
					case 106:
						goto IL_5571;
					case 107:
						goto IL_64E8;
					case 108:
						this.$self_$44122.SendMessage("fadeInTimer", 1f);
						if (178614 - 559406 != -380792)
						{
							continue;
						}
						this.$self_$44122.Lc4n60mkJOK = "EndBlack";
						if (3399 - 457102 == -453702)
						{
							continue;
						}
						this.$self_$44122.nRQn68fsRHA = Time.time;
						if (86530 - 297337 == -210806)
						{
							continue;
						}
						this.$mStoryGui$44119.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
						if (188982 - 224799 != -35817)
						{
							continue;
						}
						goto IL_739A;
					case 109:
						this.$mStoryGui$44119.newStoryMessage("Walrus", "Reggu", Language.getMessage("M937_BattleForTomorrow", 401), eTalkType.friend);
						if (213277 - 27301 != 185976)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (51677 - 234140 != -182462)
						{
							goto Block_631;
						}
						continue;
					case 110:
						goto IL_C59;
					case 111:
						goto IL_C59;
					case 112:
						goto IL_3229;
					case 113:
						goto IL_3229;
					case 114:
						goto IL_72BC;
					case 115:
						goto IL_72BC;
					case 116:
						goto IL_4BC8;
					case 117:
						goto IL_4BC8;
					case 118:
						goto IL_29FF;
					case 119:
						goto IL_29FF;
					case 120:
						goto IL_688;
					case 121:
						goto IL_688;
					case 122:
						goto IL_409;
					case 123:
						goto IL_409;
					case 124:
						goto IL_6047;
					case 125:
						goto IL_6047;
					case 126:
						goto IL_359F;
					case 127:
						goto IL_359F;
					case 128:
						this.$self_$44122.SendMessage("fadeInTimer", 2f);
						if (5274 - 9108 != -3834)
						{
							continue;
						}
						this.$self_$44122.Lc4n60mkJOK = "EndCredit";
						if (166547 - 328107 != -161560)
						{
							continue;
						}
						this.$self_$44122.nRQn68fsRHA = Time.time;
						if (140260 - 33254 != 107006)
						{
							continue;
						}
						if (this.$self_$44122.music_credit)
						{
							if (98424 - 389477 == -291052)
							{
								continue;
							}
							this.$self_$44122.audio.clip = this.$self_$44122.music_credit;
							if (253174 - 231474 == 21701)
							{
								continue;
							}
							this.$self_$44122.audio.loop = false;
							if (20763 - 374801 != -354038)
							{
								continue;
							}
							this.$self_$44122.audio.Play();
							if (6162 - 402561 != -396399)
							{
								continue;
							}
						}
						this.$self_$44122.audio.volume = (float)1;
						if (227644 - 500509 != -272864)
						{
							goto Block_164;
						}
						continue;
					case 129:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (134344 - 440654 != -306309)
							{
								goto Block_281;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9371, 0);
							if (70684 - 259281 == -188596)
							{
								continue;
							}
							this.YieldDefault(1);
							if (35745 - 399641 != -363896)
							{
								continue;
							}
							goto IL_7DF6;
						}
						break;
					default:
						if (78477 - 308704 != -230226)
						{
							goto IL_4B75;
						}
						continue;
					}
					IL_6D70:
					if (Time.time >= this.$mZoomTimer$44118 + 3f)
					{
						if (131029 - 129813 != 1216)
						{
							continue;
						}
						if (this.$mStoryCamera$44101)
						{
							if (28189 - 19348 != 8841)
							{
								continue;
							}
							this.$mStoryCamera$44101.animation.Play("c1");
							if (93538 - 89099 == 4440)
							{
								continue;
							}
						}
						this.$self_$44122.camera.fieldOfView = (float)36;
						if (240906 - 32473 != 208434)
						{
							goto Block_47;
						}
						continue;
					}
					else
					{
						this.$self_$44122.camera.fieldOfView = Mathf.SmoothStep((float)30, (float)72, 0.33f * (Time.time - this.$mZoomTimer$44118));
						if (268088 - 268356 != -267)
						{
							goto Block_790;
						}
						continue;
					}
					IL_6A40:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (20586 - 279145 == -258558)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6A33;
						}
						if (40897 - 432928 == -392030)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (16346 - 72618 != -56271)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$44119.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M937_BattleForTomorrow", 109), eTalkType.friend);
						if (80743 - 522919 == -442175)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (299592 - 335464 != -35871)
						{
							goto Block_225;
						}
						continue;
					}
					IL_CAC:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (184544 - 209517 == -24972)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C9F;
						}
						if (195208 - 545006 == -349797)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 216), eTalkType.enemy);
					if (63802 - 113967 != -50165)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (200173 - 44424 != 155749)
					{
						continue;
					}
					goto IL_7D19;
					IL_260E:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (261069 - 37061 != 224008)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2601;
						}
						if (89153 - 408840 != -319687)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 215), eTalkType.enemy);
					if (225015 - 46470 == 178546)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (27367 - 479287 != -451919)
					{
						goto Block_222;
					}
					continue;
					IL_409:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (2551 - 591838 != -589287)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3FC;
						}
						if (119415 - 29006 != 90409)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M937_BattleForTomorrow", 408), eTalkType.friend);
					if (172488 - 455892 != -283404)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (294491 - 554303 != -259812)
					{
						continue;
					}
					goto IL_601E;
					IL_6047:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (80069 - 512628 == -432558)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_603A;
						}
						if (297823 - 76412 == 221412)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M937_BattleForTomorrow", 409), eTalkType.friend);
					if (133061 - 402503 == -269441)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (176800 - 439931 != -263130)
					{
						goto Block_226;
					}
					continue;
					IL_4F0:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (26283 - 541413 != -515130)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4E3;
						}
						if (182875 - 535169 != -352294)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("none", "Crowd", Language.getMessage("M937_BattleForTomorrow", 307), eTalkType.friend);
					if (285681 - 6356 == 279326)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (210761 - 3074 != 207688)
					{
						goto Block_263;
					}
					continue;
					IL_3949:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (186792 - 172451 != 14341)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_393C;
						}
						if (21249 - 376662 != -355413)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M937_BattleForTomorrow", 302), eTalkType.friend);
					if (28198 - 12950 == 15249)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (65526 - 190278 != -124751)
					{
						goto Block_279;
					}
					continue;
					IL_2DA4:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (8839 - 451832 != -442993)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2D97;
						}
						if (273105 - 429222 == -156116)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (184355 - 45240 != 139116)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.$mStoryCamera$44101)
						{
							if (13123 - 74354 != -61231)
							{
								continue;
							}
							this.$mStoryCamera$44101.animation.Play("c18");
							if (175855 - 23782 == 152074)
							{
								continue;
							}
						}
						if (this.$mDarkFalcon$44102)
						{
							if (82867 - 190515 != -107648)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mDarkFalcon$44102, false);
							if (176785 - 243029 == -66243)
							{
								continue;
							}
						}
						this.$mStoryGui$44119.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 200), eTalkType.enemy);
						if (292938 - 424560 == -131621)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 1.5f;
						if (210160 - 303481 != -93320)
						{
							goto Block_181;
						}
						continue;
					}
					IL_52E3:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (14209 - 125617 != -111408)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_52D6;
						}
						if (101951 - 215572 != -113621)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("Liger", "Boldas", Language.getMessage("M937_BattleForTomorrow", 312), eTalkType.friend);
					if (108400 - 578833 != -470433)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (23012 - 176887 != -153874)
					{
						goto Block_202;
					}
					continue;
					IL_688:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (21784 - 484675 == -462890)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_67B;
						}
						if (244276 - 273159 == -28882)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M937_BattleForTomorrow", 407), eTalkType.friend);
					if (71624 - 276538 != -204914)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (190922 - 251663 != -60740)
					{
						goto Block_633;
					}
					continue;
					IL_4BC8:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (253421 - 6335 != 247086)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4BBB;
						}
						if (182510 - 160330 == 22181)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M937_BattleForTomorrow", 405), eTalkType.friend);
					if (127096 - 17306 != 109790)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (142379 - 413554 != -271174)
					{
						goto Block_203;
					}
					continue;
					IL_27CC:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (59143 - 479744 != -420601)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_27BF;
						}
						if (145544 - 334735 == -189190)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (246510 - 137866 != 108644)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.$mStoryCamera$44101)
						{
							if (273859 - 533684 == -259824)
							{
								continue;
							}
							this.$mStoryCamera$44101.animation.Play("c16");
							if (18939 - 274212 == -255272)
							{
								continue;
							}
						}
						if (this.$mBison$44104)
						{
							if (193007 - 595738 == -402730)
							{
								continue;
							}
							this.$mBison$44104.animation.Play("battle");
							if (29669 - 85963 == -56293)
							{
								continue;
							}
						}
						if (this.$mPanda$44105)
						{
							if (51966 - 446347 != -394381)
							{
								continue;
							}
							this.$mPanda$44105.animation.Play("battle");
							if (88694 - 387003 != -298309)
							{
								continue;
							}
						}
						if (this.$mWhale$44106)
						{
							if (155603 - 419221 != -263618)
							{
								continue;
							}
							this.$mWhale$44106.animation.Play("battle");
							if (78775 - 315487 != -236712)
							{
								continue;
							}
						}
						if (this.$mCat$44107)
						{
							if (121687 - 534117 != -412430)
							{
								continue;
							}
							this.$mCat$44107.animation.Play("battle");
							if (44097 - 571918 != -527821)
							{
								continue;
							}
						}
						if (this.$mChameleon$44108)
						{
							if (2501 - 110543 == -108041)
							{
								continue;
							}
							this.$mChameleon$44108.animation.Play("battle");
							if (129880 - 299882 != -170002)
							{
								continue;
							}
						}
						if (this.$mRabbit$44109)
						{
							if (117518 - 405878 == -288359)
							{
								continue;
							}
							this.$mRabbit$44109.animation.Play("battle");
							if (299496 - 508376 == -208879)
							{
								continue;
							}
						}
						if (this.$mMole$44110)
						{
							if (69727 - 177181 == -107453)
							{
								continue;
							}
							this.$mMole$44110.animation.Play("battle");
							if (267968 - 524518 != -256550)
							{
								continue;
							}
						}
						if (this.$mMonkey$44111)
						{
							if (194222 - 47092 == 147131)
							{
								continue;
							}
							this.$mMonkey$44111.animation.Play("battle");
							if (258634 - 363061 != -104427)
							{
								continue;
							}
						}
						if (this.$mPenguin$44112)
						{
							if (222732 - 597180 == -374447)
							{
								continue;
							}
							this.$mChameleon$44108.animation.Play("battle");
							if (225086 - 589583 == -364496)
							{
								continue;
							}
						}
						if (this.$mSheep$44113)
						{
							if (61808 - 230006 == -168197)
							{
								continue;
							}
							this.$mSheep$44113.animation.Play("battle");
							if (100050 - 342446 != -242396)
							{
								continue;
							}
						}
						if (this.$mBat$44114)
						{
							if (184264 - 474595 != -290331)
							{
								continue;
							}
							this.$mBat$44114.animation.Play("battle");
							if (183891 - 545901 != -362010)
							{
								continue;
							}
						}
						if (this.$mWolf$44103)
						{
							if (58298 - 569101 != -510803)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mWolf$44103, false);
							if (199849 - 228565 == -28715)
							{
								continue;
							}
						}
						if (this.$mBison$44104)
						{
							if (217856 - 219432 == -1575)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mBison$44104, false);
							if (61499 - 416190 == -354690)
							{
								continue;
							}
						}
						if (this.$mPanda$44105)
						{
							if (51674 - 478503 == -426828)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mPanda$44105, false);
							if (167654 - 226555 != -58901)
							{
								continue;
							}
						}
						if (this.$mWhale$44106)
						{
							if (256 - 18957 != -18701)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mWhale$44106, false);
							if (161634 - 172038 == -10403)
							{
								continue;
							}
						}
						if (this.$mCat$44107)
						{
							if (138544 - 343721 != -205177)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mCat$44107, false);
							if (211024 - 34519 != 176505)
							{
								continue;
							}
						}
						if (this.$mChameleon$44108)
						{
							if (29648 - 138959 != -109311)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mChameleon$44108, false);
							if (35848 - 229631 != -193783)
							{
								continue;
							}
						}
						if (this.$mRabbit$44109)
						{
							if (124901 - 486428 == -361526)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mRabbit$44109, false);
							if (90803 - 334309 == -243505)
							{
								continue;
							}
						}
						if (this.$mMole$44110)
						{
							if (164508 - 83559 == 80950)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mMole$44110, false);
							if (165961 - 25024 != 140937)
							{
								continue;
							}
						}
						if (this.$mMonkey$44111)
						{
							if (277404 - 354860 == -77455)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mMonkey$44111, false);
							if (15696 - 76774 != -61078)
							{
								continue;
							}
						}
						if (this.$mPenguin$44112)
						{
							if (11098 - 106555 != -95457)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mPenguin$44112, false);
							if (275488 - 76925 == 198564)
							{
								continue;
							}
						}
						if (this.$mSheep$44113)
						{
							if (292132 - 433183 != -141051)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mSheep$44113, false);
							if (65923 - 324882 == -258958)
							{
								continue;
							}
						}
						if (this.$mBat$44114)
						{
							if (284619 - 457977 != -173358)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mBat$44114, false);
							if (101604 - 386498 != -284894)
							{
								continue;
							}
						}
						this.$mStoryGui$44119.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 104), eTalkType.enemy);
						if (192890 - 254324 == -61433)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (235017 - 375321 != -140304)
						{
							continue;
						}
						goto IL_5645;
					}
					IL_ABC:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (292183 - 454240 == -162056)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_AAF;
						}
						if (293268 - 375849 != -82581)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (149076 - 333943 != -184866)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$44119.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 102), eTalkType.enemy);
						if (230057 - 21068 != 208989)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (229818 - 317873 != -88054)
						{
							goto Block_597;
						}
						continue;
					}
					IL_B0F:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (155708 - 551030 == -395321)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B02;
						}
						if (262717 - 370021 != -107304)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 206), eTalkType.enemy);
					if (232693 - 217486 != 15207)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (223092 - 591751 != -368659)
					{
						continue;
					}
					goto IL_203B;
					IL_C59:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (156378 - 226200 == -69821)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C4C;
						}
						if (273751 - 541557 == -267805)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("Walrus", "Reggu", Language.getMessage("M937_BattleForTomorrow", 402), eTalkType.friend);
					if (95595 - 278359 != -182764)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (264768 - 96685 != 168084)
					{
						goto Block_729;
					}
					continue;
					IL_566E:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (289387 - 217622 != 71765)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5661;
						}
						if (176774 - 554564 != -377790)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (211720 - 537527 != -325806)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$44119.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 105), eTalkType.enemy);
						if (57443 - 519680 != -462237)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (217859 - 406541 != -188682)
						{
							continue;
						}
						goto IL_6909;
					}
					IL_6E84:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (39570 - 3321 == 36250)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6E77;
						}
						if (240854 - 480266 != -239412)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (40283 - 501550 != -461267)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$44119.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 103), eTalkType.enemy);
						if (148097 - 216762 == -68664)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (135725 - 36030 != 99696)
						{
							goto Block_11;
						}
						continue;
					}
					IL_14DB:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (103041 - 317129 == -214087)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_14CE;
						}
						if (245655 - 550219 != -304564)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M937_BattleForTomorrow", 310), eTalkType.friend);
					if (258753 - 33757 == 224997)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (227658 - 270474 != -42816)
					{
						continue;
					}
					goto IL_6863;
					IL_334D:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (219142 - 295412 == -76269)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3340;
						}
						if (162782 - 120253 == 42530)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (36564 - 502896 != -466331)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.$mStoryCamera$44101)
						{
							if (111190 - 516348 != -405158)
							{
								continue;
							}
							if (!RuntimeServices.EqualityOperator(CharacterData.current, null))
							{
								if (256602 - 326842 != -70240)
								{
									continue;
								}
								this.$$switch$8113$44121 = CharacterData.current.Type;
								if (84836 - 110327 == -25490)
								{
									continue;
								}
								if (this.$$switch$8113$44121 == "Wolf")
								{
									if (83739 - 96298 == -12558)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cWolf");
									if (45616 - 471499 != -425883)
									{
										continue;
									}
								}
								else if (this.$$switch$8113$44121 == "Bison")
								{
									if (21413 - 219954 == -198540)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cBison");
									if (97684 - 259635 != -161951)
									{
										continue;
									}
								}
								else if (this.$$switch$8113$44121 == "Panda")
								{
									if (73145 - 413045 != -339900)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cPanda");
									if (237690 - 382809 != -145119)
									{
										continue;
									}
								}
								else if (this.$$switch$8113$44121 == "Whale")
								{
									if (263746 - 321352 != -57606)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cWhale");
									if (70195 - 207089 != -136894)
									{
										continue;
									}
								}
								else if (this.$$switch$8113$44121 == "Cat")
								{
									if (8043 - 18937 == -10893)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cCat");
									if (72756 - 490117 != -417361)
									{
										continue;
									}
								}
								else if (this.$$switch$8113$44121 == "Chameleon")
								{
									if (207879 - 75113 == 132767)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cChameleon");
									if (64052 - 389108 == -325055)
									{
										continue;
									}
								}
								else if (this.$$switch$8113$44121 == "Rabbit")
								{
									if (62454 - 153077 != -90623)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cRabbit");
									if (136435 - 62149 != 74286)
									{
										continue;
									}
								}
								else if (this.$$switch$8113$44121 == "Mole")
								{
									if (177310 - 312295 != -134985)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cMole");
									if (207972 - 204273 != 3699)
									{
										continue;
									}
								}
								else if (this.$$switch$8113$44121 == "Monkey")
								{
									if (283468 - 306091 == -22622)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cMonkey");
									if (68439 - 558126 != -489687)
									{
										continue;
									}
								}
								else if (this.$$switch$8113$44121 == "Sheep")
								{
									if (2605 - 32895 != -30290)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cSheep");
									if (264492 - 102907 != 161585)
									{
										continue;
									}
								}
								else if (this.$$switch$8113$44121 == "Penguin")
								{
									if (152514 - 589833 == -437318)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cPenguin");
									if (6718 - 412465 != -405747)
									{
										continue;
									}
								}
								else if (this.$$switch$8113$44121 == "Bat")
								{
									if (160240 - 191729 == -31488)
									{
										continue;
									}
									this.$mStoryCamera$44101.animation.Play("cBat");
									if (113623 - 1145 == 112479)
									{
										continue;
									}
								}
							}
						}
						if (this.$mDarkFalcon$44102)
						{
							if (44105 - 559308 == -515202)
							{
								continue;
							}
							this.$self_$44122.hideModel(this.$mDarkFalcon$44102, true);
							if (70765 - 34529 == 36237)
							{
								continue;
							}
						}
						this.$mStoryGui$44119.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M937_BattleForTomorrow", 107), eTalkType.friend);
						if (63778 - 66110 != -2332)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (103935 - 25864 != 78071)
						{
							continue;
						}
						goto IL_4ACC;
					}
					IL_359F:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (83277 - 90574 != -7297)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3592;
						}
						if (44510 - 531888 == -487377)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.close();
					if (205890 - 188136 != 17754)
					{
						continue;
					}
					this.$self_$44122.SendMessage("fadeOutTimer", 3f);
					if (296481 - 506657 != -210175)
					{
						goto Block_385;
					}
					continue;
					IL_688C:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (192022 - 165603 == 26420)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_687F;
						}
						if (101507 - 102219 == -711)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("Liger", "Boldas", Language.getMessage("M937_BattleForTomorrow", 311), eTalkType.friend);
					if (194403 - 15562 == 178842)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (1204 - 313230 != -312026)
					{
						continue;
					}
					goto IL_52BA;
					IL_16A2:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (276513 - 90243 == 186271)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1695;
						}
						if (49267 - 244769 == -195501)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 212), eTalkType.enemy);
					if (20619 - 259812 == -239192)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (135038 - 378720 != -243681)
					{
						goto Block_927;
					}
					continue;
					IL_716F:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (156094 - 534454 != -378360)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7162;
						}
						if (111275 - 150949 == -39673)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("Liger", "Boldas", Language.getMessage("M937_BattleForTomorrow", 306), eTalkType.friend);
					if (78644 - 446491 != -367847)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 2f;
					if (273354 - 176436 != 96918)
					{
						continue;
					}
					goto IL_4C7;
					IL_17BF:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (222319 - 462475 == -240155)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_17B2;
						}
						if (50965 - 87842 == -36876)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M937_BattleForTomorrow", 303), eTalkType.friend);
					if (100115 - 346006 == -245890)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (173832 - 422050 != -248217)
					{
						goto Block_108;
					}
					continue;
					IL_2D15:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (200090 - 260554 == -60463)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2D08;
						}
						if (118522 - 142212 == -23689)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 208), eTalkType.enemy);
					if (165690 - 574430 == -408739)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (78640 - 496226 != -417586)
					{
						continue;
					}
					goto IL_3E49;
					IL_2064:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (119690 - 82964 != 36726)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2057;
						}
						if (209649 - 455395 == -245745)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.blank();
					if (72893 - 435264 != -362371)
					{
						continue;
					}
					this.$self_$44122.SendMessage("blackOutTimer", 0.5f);
					if (38016 - 302276 != -264259)
					{
						goto Block_393;
					}
					continue;
					IL_2217:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (177154 - 64027 != 113127)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_220A;
						}
						if (173565 - 233171 != -59606)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("none", "Crowd", Language.getMessage("M937_BattleForTomorrow", 309), eTalkType.friend);
					if (175673 - 524185 != -348512)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (109065 - 327984 != -218918)
					{
						goto Block_442;
					}
					continue;
					IL_6932:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (145673 - 311504 != -165831)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6925;
						}
						if (193546 - 410784 != -217238)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (108490 - 448244 != -339753)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$44119.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 106), eTalkType.enemy);
						if (202172 - 189910 == 12263)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (217601 - 148594 != 69007)
						{
							continue;
						}
						goto IL_3324;
					}
					IL_1F14:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (121217 - 306725 == -185507)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1F07;
						}
						if (139773 - 346699 == -206925)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 202), eTalkType.enemy);
					if (288923 - 409433 != -120510)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (32582 - 333013 != -300430)
					{
						goto Block_710;
					}
					continue;
					IL_4AF5:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (106340 - 323822 != -217482)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4AE8;
						}
						if (167233 - 89955 != 77278)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (258970 - 576799 != -317829)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$44119.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M937_BattleForTomorrow", 108), eTalkType.friend);
						if (231181 - 596263 != -365082)
						{
							continue;
						}
						this.$mStoryTimer$44120 = Time.time + 3f;
						if (118507 - 344992 != -226485)
						{
							continue;
						}
						goto IL_6A17;
					}
					IL_4C8A:
					if (Time.time >= this.$mStoryTimer$44120 + (float)1)
					{
						if (64739 - 327292 == -262552)
						{
							continue;
						}
						this.$mStoryGui$44119.startStoryMessage("Liger", "Boldas", eTalkType.friend);
						if (278588 - 109133 != 169455)
						{
							continue;
						}
						goto IL_3DF2;
					}
					else
					{
						this.$self_$44122.audio.volume = Mathf.Lerp((float)0, (float)1, Time.time - this.$mStoryTimer$44120);
						if (81440 - 280127 != -198687)
						{
							continue;
						}
						goto IL_4C7D;
					}
					IL_7D42:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (3844 - 104268 == -100423)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7D35;
						}
						if (177371 - 401284 != -223913)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.close();
					if (61446 - 283486 == -222039)
					{
						continue;
					}
					this.$self_$44122.SendMessage("fadeOutTimer", 1f);
					if (239039 - 315841 == -76801)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time;
					if (181152 - 314980 != -133827)
					{
						goto IL_2B0F;
					}
					continue;
					IL_274F:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (100340 - 321129 != -220789)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2742;
						}
						if (151099 - 96409 != 54690)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 214), eTalkType.enemy);
					if (30904 - 65291 != -34387)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (225302 - 82230 != 143073)
					{
						goto Block_740;
					}
					continue;
					IL_3000:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (19783 - 130615 == -110831)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2FF3;
						}
						if (82587 - 208014 == -125426)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("Liger", "Boldas", Language.getMessage("M937_BattleForTomorrow", 304), eTalkType.friend);
					if (53376 - 389628 != -336252)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (129264 - 80398 != 48866)
					{
						continue;
					}
					goto IL_790B;
					IL_294E:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (187575 - 381162 == -193586)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2941;
						}
						if (105443 - 294117 != -188674)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 201), eTalkType.enemy);
					if (11897 - 314227 != -302330)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (12441 - 131803 != -119361)
					{
						goto Block_793;
					}
					continue;
					IL_29FF:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (106813 - 514831 != -408018)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_29F2;
						}
						if (276353 - 372447 != -96094)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M937_BattleForTomorrow", 406), eTalkType.friend);
					if (225656 - 435339 == -209682)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (260157 - 239008 != 21150)
					{
						goto Block_713;
					}
					continue;
					IL_2B0F:
					if (Time.time >= this.$mStoryTimer$44120 + (float)1)
					{
						if (239091 - 204035 == 35057)
						{
							continue;
						}
						this.$self_$44122.SendMessage("fadeInTimer", 1f);
						if (285263 - 29594 != 255669)
						{
							continue;
						}
						this.$self_$44122.Lc4n60mkJOK = "EndImage5";
						if (166317 - 63069 == 103249)
						{
							continue;
						}
						this.$self_$44122.nRQn68fsRHA = Time.time;
						if (185554 - 280055 == -94500)
						{
							continue;
						}
						if (this.$self_$44122.music_mission)
						{
							if (66224 - 38168 == 28057)
							{
								continue;
							}
							this.$self_$44122.audio.clip = this.$self_$44122.music_mission;
							if (217631 - 355974 != -138343)
							{
								continue;
							}
							this.$self_$44122.audio.Play();
							if (207819 - 436072 != -228253)
							{
								continue;
							}
						}
						this.$mStoryTimer$44120 = Time.time;
						if (96589 - 200102 != -103512)
						{
							goto IL_4C8A;
						}
						continue;
					}
					else
					{
						this.$self_$44122.audio.volume = Mathf.Lerp((float)1, (float)0, Time.time - this.$mStoryTimer$44120);
						if (176667 - 391179 != -214511)
						{
							goto Block_639;
						}
						continue;
					}
					IL_3803:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (42696 - 431477 == -388780)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_37F6;
						}
						if (261831 - 306194 == -44362)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 204), eTalkType.enemy);
					if (256872 - 248579 != 8293)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (149910 - 113427 != 36483)
					{
						continue;
					}
					goto IL_6ED7;
					IL_6F00:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (247967 - 487346 == -239378)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6EF3;
						}
						if (2180 - 59622 != -57442)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.close();
					if (41055 - 451529 != -410474)
					{
						continue;
					}
					this.$self_$44122.SendMessage("blackOutTimer", 1f);
					if (286980 - 339114 != -52133)
					{
						goto Block_366;
					}
					continue;
					IL_3229:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (257507 - 167680 == 89828)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_321C;
						}
						if (286960 - 462125 == -175164)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M937_BattleForTomorrow", 403), eTalkType.friend);
					if (258720 - 493467 != -234747)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (248660 - 136867 != 111794)
					{
						goto Block_731;
					}
					continue;
					IL_3E72:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (157458 - 65729 != 91729)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3E65;
						}
						if (69353 - 203478 == -134124)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 209), eTalkType.enemy);
					if (284341 - 440484 == -156142)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (100903 - 449686 != -348782)
					{
						goto Block_323;
					}
					continue;
					IL_413C:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (224398 - 476866 != -252468)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_412F;
						}
						if (190398 - 585895 != -395497)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 203), eTalkType.enemy);
					if (40620 - 175126 != -134506)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (273406 - 311233 != -37826)
					{
						goto Block_849;
					}
					continue;
					IL_374B:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (122715 - 29260 != 93455)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_373E;
						}
						if (290486 - 83802 == 206685)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("none", "Shadow Italus", Language.getMessage("M937_BattleForTomorrow", 211), eTalkType.enemy);
					if (242994 - 130840 != 112154)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (204402 - 428873 != -224470)
					{
						goto Block_799;
					}
					continue;
					IL_7934:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (120424 - 281485 == -161060)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7927;
						}
						if (17308 - 265089 == -247780)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("Liger", "Boldas", Language.getMessage("M937_BattleForTomorrow", 305), eTalkType.friend);
					if (265850 - 459814 != -193964)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (60252 - 35914 != 24339)
					{
						goto Block_651;
					}
					continue;
					IL_6256:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (37546 - 220836 != -183290)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6249;
						}
						if (230896 - 423452 == -192555)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("none", "Crowd", Language.getMessage("M937_BattleForTomorrow", 308), eTalkType.friend);
					if (80593 - 450418 == -369824)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (113221 - 25696 != 87526)
					{
						goto Block_388;
					}
					continue;
					IL_4F1A:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (245541 - 299298 == -53756)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4F0D;
						}
						if (206992 - 211792 == -4799)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.close();
					if (122677 - 472024 != -349347)
					{
						continue;
					}
					this.$self_$44122.SendMessage("blackOutTimer", 0.5f);
					if (51164 - 131793 != -80628)
					{
						goto Block_504;
					}
					continue;
					IL_4B75:
					this.$mStoryCamera$44101 = GameObject.Find("StoryCamera");
					if (206875 - 186323 == 20553)
					{
						continue;
					}
					this.$mDarkFalcon$44102 = GameObject.Find("DarkFalcon");
					if (77894 - 429214 == -351319)
					{
						continue;
					}
					this.$mWolf$44103 = GameObject.Find("Wolf");
					if (237207 - 174388 == 62820)
					{
						continue;
					}
					this.$mBison$44104 = GameObject.Find("Bison");
					if (241653 - 195154 != 46499)
					{
						continue;
					}
					this.$mPanda$44105 = GameObject.Find("Panda");
					if (208582 - 490437 == -281854)
					{
						continue;
					}
					this.$mWhale$44106 = GameObject.Find("Whale");
					if (182015 - 467971 != -285956)
					{
						continue;
					}
					this.$mCat$44107 = GameObject.Find("Cat");
					if (84537 - 217351 == -132813)
					{
						continue;
					}
					this.$mChameleon$44108 = GameObject.Find("Chameleon");
					if (12336 - 210385 != -198049)
					{
						continue;
					}
					this.$mRabbit$44109 = GameObject.Find("Rabbit");
					if (120941 - 214734 != -93793)
					{
						continue;
					}
					this.$mMole$44110 = GameObject.Find("Mole");
					if (55334 - 548376 == -493041)
					{
						continue;
					}
					this.$mMonkey$44111 = GameObject.Find("Monkey");
					if (142101 - 351825 == -209723)
					{
						continue;
					}
					this.$mPenguin$44112 = GameObject.Find("Penguin");
					if (106191 - 130864 != -24673)
					{
						continue;
					}
					this.$mSheep$44113 = GameObject.Find("Sheep");
					if (206985 - 12537 == 194449)
					{
						continue;
					}
					this.$mBat$44114 = GameObject.Find("Bat");
					if (251303 - 233865 != 17438)
					{
						continue;
					}
					this.$mPhoenix$44115 = GameObject.Find("Phoenix");
					if (221914 - 586189 != -364275)
					{
						continue;
					}
					this.$mIllusion1$44116 = GameObject.Find("Illusion1");
					if (252923 - 314058 != -61135)
					{
						continue;
					}
					this.$mIllusion2$44117 = GameObject.Find("Illusion2");
					if (121608 - 108741 != 12867)
					{
						continue;
					}
					if (this.$mWolf$44103)
					{
						if (179832 - 490756 == -310923)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mWolf$44103, "Wolf");
						if (129456 - 188699 != -59243)
						{
							continue;
						}
					}
					if (this.$mBison$44104)
					{
						if (136056 - 513846 != -377790)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mBison$44104, "Bison");
						if (144046 - 450437 != -306391)
						{
							continue;
						}
					}
					if (this.$mPanda$44105)
					{
						if (234023 - 539431 != -305408)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mPanda$44105, "Panda");
						if (144128 - 91620 == 52509)
						{
							continue;
						}
					}
					if (this.$mWhale$44106)
					{
						if (150778 - 38678 != 112100)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mWhale$44106, "Whale");
						if (265613 - 120933 != 144680)
						{
							continue;
						}
					}
					if (this.$mCat$44107)
					{
						if (256639 - 282413 == -25773)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mCat$44107, "Cat");
						if (128794 - 171091 != -42297)
						{
							continue;
						}
					}
					if (this.$mChameleon$44108)
					{
						if (234722 - 359030 != -124308)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mChameleon$44108, "Chameleon");
						if (230943 - 192284 == 38660)
						{
							continue;
						}
					}
					if (this.$mRabbit$44109)
					{
						if (103445 - 35939 != 67506)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mRabbit$44109, "Rabbit");
						if (32296 - 267830 == -235533)
						{
							continue;
						}
					}
					if (this.$mMole$44110)
					{
						if (149376 - 74573 != 74803)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mMole$44110, "Mole");
						if (149320 - 445825 == -296504)
						{
							continue;
						}
					}
					if (this.$mMonkey$44111)
					{
						if (18098 - 105897 == -87798)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mMonkey$44111, "Monkey");
						if (201452 - 97547 == 103906)
						{
							continue;
						}
					}
					if (this.$mPenguin$44112)
					{
						if (287163 - 70551 == 216613)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mPenguin$44112, "Penguin");
						if (13219 - 377214 != -363995)
						{
							continue;
						}
					}
					if (this.$mSheep$44113)
					{
						if (176426 - 377466 == -201039)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mSheep$44113, "Sheep");
						if (237611 - 138753 != 98858)
						{
							continue;
						}
					}
					if (this.$mBat$44114)
					{
						if (251501 - 10617 != 240884)
						{
							continue;
						}
						this.$self_$44122.getDress(this.$mBat$44114, "Bat");
						if (117053 - 223377 != -106324)
						{
							continue;
						}
					}
					if (this.$mPhoenix$44115)
					{
						if (108141 - 100592 == 7550)
						{
							continue;
						}
						this.$self_$44122.hideModel(this.$mPhoenix$44115, true);
						if (127030 - 35582 == 91449)
						{
							continue;
						}
					}
					if (this.$mIllusion1$44116)
					{
						if (179312 - 460495 == -281182)
						{
							continue;
						}
						this.$self_$44122.hideModel(this.$mIllusion1$44116, true);
						if (206926 - 119917 != 87009)
						{
							continue;
						}
					}
					if (this.$mIllusion2$44117)
					{
						if (35873 - 112833 == -76959)
						{
							continue;
						}
						this.$self_$44122.hideModel(this.$mIllusion2$44117, true);
						if (101778 - 412379 == -310600)
						{
							continue;
						}
					}
					Game.mGameState = eGameState.AllHold;
					if (19310 - 320730 != -301420)
					{
						continue;
					}
					if (Game.mGameType != 99)
					{
						if (6190 - 465442 != -459252)
						{
							continue;
						}
						this.$self_$44122.SendMessage("fadeIn");
						if (157789 - 452197 != -294408)
						{
							continue;
						}
					}
					if (this.$mStoryCamera$44101)
					{
						if (60638 - 360669 != -300031)
						{
							continue;
						}
						this.$mStoryCamera$44101.animation.Play("c0");
						if (138492 - 416507 != -278015)
						{
							continue;
						}
					}
					this.$self_$44122.camera.fieldOfView = (float)30;
					if (205494 - 396129 == -190634)
					{
						continue;
					}
					this.$self_$44122.audio.Play();
					if (219938 - 455485 != -235547)
					{
						continue;
					}
					this.$mZoomTimer$44118 = Time.time;
					if (226367 - 19298 != 207070)
					{
						goto IL_6D70;
					}
					continue;
					IL_5571:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (217062 - 420663 == -203600)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5564;
						}
						if (217369 - 490278 == -272908)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.close();
					if (266070 - 419288 != -153218)
					{
						continue;
					}
					this.$self_$44122.SendMessage("fadeOutTimer", 1f);
					if (11415 - 325706 == -314290)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time;
					if (65914 - 522665 != -456750)
					{
						goto IL_64E8;
					}
					continue;
					IL_5956:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (265201 - 227556 != 37645)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5949;
						}
						if (150798 - 42798 == 108001)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.blank();
					if (127086 - 359626 != -232540)
					{
						continue;
					}
					this.$self_$44122.SendMessage("blackOutTimer", 0.5f);
					if (30686 - 532581 != -501895)
					{
						continue;
					}
					goto IL_1BD2;
					IL_72BC:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (227542 - 338000 != -110458)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_72AF;
						}
						if (136406 - 557513 != -421107)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M937_BattleForTomorrow", 404), eTalkType.friend);
					if (39386 - 229343 != -189957)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 3f;
					if (152541 - 158872 != -6330)
					{
						goto Block_730;
					}
					continue;
					IL_5DD9:
					if (this.$mStoryTimer$44120 > Time.time)
					{
						if (121857 - 11727 == 110131)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5DCC;
						}
						if (217822 - 148314 == 69509)
						{
							continue;
						}
					}
					this.$mStoryGui$44119.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, "!!?", eTalkType.friend);
					if (260427 - 359503 == -99075)
					{
						continue;
					}
					this.$mStoryTimer$44120 = Time.time + 1.5f;
					if (254535 - 523617 != -269082)
					{
						continue;
					}
					goto IL_1796;
					IL_64E8:
					if (Time.time >= this.$mStoryTimer$44120 + (float)1)
					{
						if (100361 - 570419 == -470058)
						{
							goto IL_22D0;
						}
					}
					else
					{
						this.$self_$44122.audio.volume = Mathf.Lerp((float)1, (float)0, Time.time - this.$mStoryTimer$44120);
						if (165991 - 178507 == -12516)
						{
							goto IL_64DB;
						}
					}
				}
				Block_3:
				goto IL_7DF6;
				Block_11:
				return this.Yield(24, new WaitForSeconds(0.5f));
				goto IL_7DF6;
				Block_30:
				goto IL_2EC8;
				IL_3FC:
				return this.YieldDefault(123);
				IL_4C7:
				return this.Yield(93, new WaitForSeconds(0.5f));
				IL_4E3:
				return this.YieldDefault(94);
				Block_47:
				return this.Yield(3, new WaitForSeconds(3.3f));
				IL_67B:
				return this.YieldDefault(121);
				IL_9DA:
				goto IL_7DF6;
				IL_A93:
				return this.Yield(20, new WaitForSeconds(0.5f));
				IL_AAF:
				return this.YieldDefault(21);
				IL_AE6:
				return this.Yield(51, new WaitForSeconds(0.5f));
				IL_B02:
				return this.YieldDefault(52);
				IL_B9E:
				return this.Yield(4, new WaitForSeconds(2.3f));
				IL_C4C:
				return this.YieldDefault(111);
				IL_C9F:
				return this.YieldDefault(75);
				Block_108:
				return this.Yield(87, new WaitForSeconds(0.5f));
				IL_1099:
				return this.Yield(9, new WaitForSeconds(1.5f));
				Block_139:
				goto IL_B9E;
				IL_14CE:
				return this.YieldDefault(100);
				IL_1505:
				return this.Yield(10, new WaitForSeconds(9f));
				Block_164:
				return this.Yield(129, new WaitForSeconds((float)150));
				Block_167:
				return this.Yield(16, new WaitForSeconds(1.9f));
				IL_1695:
				return this.YieldDefault(66);
				IL_1796:
				return this.Yield(85, new WaitForSeconds(0.5f));
				IL_17B2:
				return this.YieldDefault(86);
				Block_181:
				return this.Yield(38, new WaitForSeconds(0.5f));
				Block_182:
				return this.Yield(12, new WaitForSeconds(3.3f));
				Block_202:
				return this.Yield(105, new WaitForSeconds(0.5f));
				Block_203:
				return this.Yield(118, new WaitForSeconds(0.5f));
				IL_1BA3:
				goto IL_7DF6;
				IL_1BD2:
				return this.Yield(62, new WaitForSeconds(0.5f));
				Block_222:
				return this.Yield(74, new WaitForSeconds(0.5f));
				Block_225:
				return this.Yield(36, new WaitForSeconds(0.5f));
				Block_226:
				return this.Yield(126, new WaitForSeconds(0.5f));
				IL_1F07:
				return this.YieldDefault(41);
				goto IL_7DF6;
				IL_203B:
				return this.Yield(53, new WaitForSeconds(0.5f));
				IL_2057:
				return this.YieldDefault(54);
				IL_220A:
				return this.YieldDefault(98);
				goto IL_7DF6;
				IL_22D0:
				return this.Yield(108, new WaitForSeconds(1f));
				Block_263:
				return this.Yield(95, new WaitForSeconds(0.5f));
				goto IL_7DF6;
				Block_279:
				return this.Yield(83, new WaitForSeconds(0.5f));
				Block_281:
				goto IL_7DF6;
				IL_2601:
				return this.YieldDefault(73);
				IL_2726:
				return this.Yield(70, new WaitForSeconds(0.5f));
				IL_2742:
				return this.YieldDefault(71);
				IL_27BF:
				return this.YieldDefault(25);
				IL_2941:
				return this.YieldDefault(39);
				IL_29F2:
				return this.YieldDefault(119);
				Block_317:
				goto IL_1099;
				Block_323:
				return this.Yield(60, new WaitForSeconds(0.5f));
				Block_329:
				return this.Yield(7, new WaitForSeconds(7f));
				goto IL_7DF6;
				IL_2D08:
				return this.YieldDefault(57);
				IL_2D3F:
				return this.Yield(14, new WaitForSeconds(2.5f));
				IL_2D97:
				return this.YieldDefault(37);
				IL_2EC8:
				return this.Yield(15, new WaitForSeconds(1.9f));
				Block_349:
				goto IL_7DF6;
				IL_2FF3:
				return this.YieldDefault(88);
				Block_366:
				return this.Yield(48, new WaitForSeconds(1f));
				IL_321C:
				return this.YieldDefault(113);
				Block_381:
				return this.Yield(13, new WaitForSeconds(4.8f));
				IL_3324:
				return this.Yield(30, new WaitForSeconds(0.5f));
				IL_3340:
				return this.YieldDefault(31);
				Block_385:
				return this.Yield(128, new WaitForSeconds(5f));
				Block_388:
				return this.Yield(97, new WaitForSeconds(0.5f));
				Block_393:
				return this.Yield(55, new WaitForSeconds(0.5f));
				IL_3592:
				return this.YieldDefault(127);
				IL_369D:
				goto IL_7DF6;
				IL_373E:
				return this.YieldDefault(64);
				IL_37F6:
				return this.YieldDefault(45);
				Block_427:
				return this.Yield(50, new WaitForSeconds(0.5f));
				IL_3920:
				return this.Yield(81, new WaitForSeconds(0.5f));
				IL_393C:
				return this.YieldDefault(82);
				Block_433:
				goto IL_7DF6;
				Block_442:
				return this.Yield(99, new WaitForSeconds(0.5f));
				IL_3CCB:
				goto IL_7DF6;
				IL_3DF2:
				return this.Yield(80, new WaitForSeconds(0.5f));
				IL_3E49:
				return this.Yield(58, new WaitForSeconds(0.5f));
				IL_3E65:
				return this.YieldDefault(59);
				IL_412F:
				return this.YieldDefault(43);
				Block_504:
				return this.Yield(69, new WaitForSeconds(0.5f));
				Block_535:
				return this.Yield(18, new WaitForSeconds(9f));
				IL_49CF:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_4ACC:
				return this.Yield(32, new WaitForSeconds(0.5f));
				IL_4AE8:
				return this.YieldDefault(33);
				IL_4BBB:
				return this.YieldDefault(117);
				IL_4C7D:
				return this.YieldDefault(79);
				IL_4D0B:
				goto IL_7DF6;
				IL_4F0D:
				return this.YieldDefault(68);
				Block_593:
				goto IL_7DF6;
				Block_597:
				return this.Yield(22, new WaitForSeconds(0.5f));
				Block_599:
				goto IL_7DF6;
				IL_52BA:
				return this.Yield(103, new WaitForSeconds(0.5f));
				IL_52D6:
				return this.YieldDefault(104);
				Block_612:
				return this.Yield(63, new WaitForSeconds(0.5f));
				IL_5564:
				return this.YieldDefault(106);
				Block_631:
				return this.Yield(110, new WaitForSeconds(0.5f));
				Block_633:
				return this.Yield(122, new WaitForSeconds(0.5f));
				IL_5645:
				return this.Yield(26, new WaitForSeconds(0.5f));
				IL_5661:
				return this.YieldDefault(27);
				Block_639:
				return this.YieldDefault(78);
				Block_651:
				return this.Yield(91, new WaitForSeconds(0.5f));
				Block_653:
				return this.Yield(8, new WaitForSeconds(7.5f));
				IL_5949:
				return this.YieldDefault(61);
				Block_671:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_5DCC:
				return this.YieldDefault(84);
				IL_5ECC:
				return this.Yield(5, new WaitForSeconds(2.7f));
				IL_601E:
				return this.Yield(124, new WaitForSeconds(0.5f));
				IL_603A:
				return this.YieldDefault(125);
				goto IL_7DF6;
				Block_708:
				return this.Yield(11, new WaitForSeconds(3.3f));
				Block_710:
				return this.Yield(42, new WaitForSeconds(0.5f));
				Block_713:
				return this.Yield(120, new WaitForSeconds(0.5f));
				IL_6249:
				return this.YieldDefault(96);
				Block_729:
				return this.Yield(112, new WaitForSeconds(0.5f));
				Block_730:
				return this.Yield(116, new WaitForSeconds(0.5f));
				Block_731:
				return this.Yield(114, new WaitForSeconds(0.5f));
				Block_736:
				return this.Yield(56, new WaitForSeconds(0.5f));
				IL_64DB:
				return this.YieldDefault(107);
				Block_740:
				return this.Yield(72, new WaitForSeconds(0.5f));
				goto IL_7DF6;
				IL_67FE:
				return this.Yield(17, new WaitForSeconds(2.5f));
				Block_763:
				goto IL_7DF6;
				IL_6863:
				return this.Yield(101, new WaitForSeconds(0.5f));
				IL_687F:
				return this.YieldDefault(102);
				IL_6909:
				return this.Yield(28, new WaitForSeconds(0.5f));
				IL_6925:
				return this.YieldDefault(29);
				IL_6A17:
				return this.Yield(34, new WaitForSeconds(0.5f));
				IL_6A33:
				return this.YieldDefault(35);
				Block_784:
				return this.Yield(49, new WaitForSeconds(1f));
				Block_787:
				goto IL_7DF6;
				Block_790:
				return this.YieldDefault(2);
				Block_793:
				return this.Yield(40, new WaitForSeconds(0.5f));
				goto IL_7DF6;
				Block_799:
				return this.Yield(65, new WaitForSeconds(0.5f));
				IL_6D6B:
				goto IL_7DF6;
				IL_6E77:
				return this.YieldDefault(23);
				IL_6ED7:
				return this.Yield(46, new WaitForSeconds(0.5f));
				IL_6EF3:
				return this.YieldDefault(47);
				Block_830:
				goto IL_1505;
				IL_7162:
				return this.YieldDefault(92);
				IL_72AF:
				return this.YieldDefault(115);
				Block_849:
				return this.Yield(44, new WaitForSeconds(0.5f));
				IL_739A:
				return this.Yield(109, new WaitForSeconds(0.5f));
				Block_860:
				IL_77EC:
				goto IL_7DF6;
				IL_790B:
				return this.Yield(89, new WaitForSeconds(0.5f));
				IL_7927:
				return this.YieldDefault(90);
				IL_7D19:
				return this.Yield(76, new WaitForSeconds(0.5f));
				IL_7D35:
				return this.YieldDefault(77);
				Block_927:
				return this.Yield(67, new WaitForSeconds(0.5f));
				IL_7DF6:
				return false;
			}

			// Token: 0x0600A5A4 RID: 42404 RVA: 0x012B2770 File Offset: 0x012B0970
			internal static bool ceT4OOVvd7fmF0AuWiMP()
			{
				return true;
			}

			// Token: 0x0600A5A5 RID: 42405 RVA: 0x012B2774 File Offset: 0x012B0974
			internal static bool OB5Kn8VvJP1rE0gnwynP()
			{
				return false;
			}

			// Token: 0x0400947E RID: 38014
			internal GameObject $mStoryCamera$44101;

			// Token: 0x0400947F RID: 38015
			internal GameObject $mDarkFalcon$44102;

			// Token: 0x04009480 RID: 38016
			internal GameObject $mWolf$44103;

			// Token: 0x04009481 RID: 38017
			internal GameObject $mBison$44104;

			// Token: 0x04009482 RID: 38018
			internal GameObject $mPanda$44105;

			// Token: 0x04009483 RID: 38019
			internal GameObject $mWhale$44106;

			// Token: 0x04009484 RID: 38020
			internal GameObject $mCat$44107;

			// Token: 0x04009485 RID: 38021
			internal GameObject $mChameleon$44108;

			// Token: 0x04009486 RID: 38022
			internal GameObject $mRabbit$44109;

			// Token: 0x04009487 RID: 38023
			internal GameObject $mMole$44110;

			// Token: 0x04009488 RID: 38024
			internal GameObject $mMonkey$44111;

			// Token: 0x04009489 RID: 38025
			internal GameObject $mPenguin$44112;

			// Token: 0x0400948A RID: 38026
			internal GameObject $mSheep$44113;

			// Token: 0x0400948B RID: 38027
			internal GameObject $mBat$44114;

			// Token: 0x0400948C RID: 38028
			internal GameObject $mPhoenix$44115;

			// Token: 0x0400948D RID: 38029
			internal GameObject $mIllusion1$44116;

			// Token: 0x0400948E RID: 38030
			internal GameObject $mIllusion2$44117;

			// Token: 0x0400948F RID: 38031
			internal float $mZoomTimer$44118;

			// Token: 0x04009490 RID: 38032
			internal StoryGui $mStoryGui$44119;

			// Token: 0x04009491 RID: 38033
			internal float $mStoryTimer$44120;

			// Token: 0x04009492 RID: 38034
			internal string $$switch$8113$44121;

			// Token: 0x04009493 RID: 38035
			internal M937_BattleForTomorrow $self_$44122;
		}
	}

	// Token: 0x02001BB1 RID: 7089
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnPlayCut3$44124 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5A6 RID: 42406 RVA: 0x012B2778 File Offset: 0x012B0978
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnPlayCut3$44124(M937_BattleForTomorrow self_)
		{
			if (278704 - 281939 != -3235)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (97461 - 74104 == 23357)
				{
					base..ctor();
					if (30440 - 69244 != -38803)
					{
						this.$self_$44126 = self_;
						if (249354 - 7552 == 241802)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x012B2810 File Offset: 0x012B0A10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$OnPlayCut3$44124.$(this.$self_$44126);
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x012B2820 File Offset: 0x012B0A20
		internal static bool UWnD40VvDZCIso5ESAE4()
		{
			return true;
		}

		// Token: 0x0600A5A9 RID: 42409 RVA: 0x012B2824 File Offset: 0x012B0A24
		internal static bool BLEwQJVvvcTx6fu5GdnD()
		{
			return false;
		}

		// Token: 0x04009494 RID: 38036
		internal M937_BattleForTomorrow $self_$44126;

		// Token: 0x02001BB2 RID: 7090
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5AA RID: 42410 RVA: 0x012B2828 File Offset: 0x012B0A28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (274091 - 104202 != 169890)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229057 - 27389 == 201668)
					{
						base..ctor();
						if (87698 - 139958 == -52260)
						{
							this.$self_$44125 = self_;
							if (234699 - 118644 != 116056)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A5AB RID: 42411 RVA: 0x012B28C0 File Offset: 0x012B0AC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (82571 - 234573 != -152002)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_131;
					case 1:
						goto IL_1D5;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (266891 - 592758 == -325867)
							{
								goto IL_1A1;
							}
						}
						else
						{
							if (this.$self_$44125.braveSpirit)
							{
								if (22883 - 24560 == -1676)
								{
									break;
								}
								UnityEngine.Object.Instantiate(this.$self_$44125.braveSpirit, new Vector3(-0.3f, (float)50, 8.5f), Quaternion.identity);
								if (64571 - 44982 != 19589)
								{
									break;
								}
							}
							else
							{
								Debug.LogError("Missing braveSpirit GameObject");
								if (7551 - 597358 != -589807)
								{
									break;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (60717 - 434702 == -373984)
								{
									break;
								}
								if (this.$self_$44125.braveSpirit_vc)
								{
									if (247846 - 370693 != -122847)
									{
										break;
									}
									this.$self_$44125.audio.PlayOneShot(this.$self_$44125.braveSpirit_vc);
									if (163353 - 408474 != -245121)
									{
										break;
									}
								}
							}
							this.YieldDefault(1);
							if (221059 - 73348 != 147712)
							{
								goto Block_4;
							}
						}
						break;
					default:
						if (259682 - 126443 != 133240)
						{
							goto Block_7;
						}
						break;
					}
				}
				Block_4:
				goto IL_1D5;
				Block_7:
				IL_131:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1A1:
				IL_1D5:
				return false;
			}

			// Token: 0x0600A5AC RID: 42412 RVA: 0x012B2AB4 File Offset: 0x012B0CB4
			internal static bool XDnIHgVvRtHHkQQ4uAJr()
			{
				return true;
			}

			// Token: 0x0600A5AD RID: 42413 RVA: 0x012B2AB8 File Offset: 0x012B0CB8
			internal static bool imc73QVvw3ySBLpLWyha()
			{
				return false;
			}

			// Token: 0x04009495 RID: 38037
			internal M937_BattleForTomorrow $self_$44125;
		}
	}

	// Token: 0x02001BB3 RID: 7091
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnPlayCut4$44127 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5AE RID: 42414 RVA: 0x012B2ABC File Offset: 0x012B0CBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnPlayCut4$44127(M937_BattleForTomorrow self_)
		{
			if (42569 - 316654 != -274084)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (32305 - 385868 != -353562)
				{
					base..ctor();
					if (108640 - 479070 == -370430)
					{
						this.$self_$44129 = self_;
						if (1956 - 587953 != -585996)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A5AF RID: 42415 RVA: 0x012B2B54 File Offset: 0x012B0D54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$OnPlayCut4$44127.$(this.$self_$44129);
		}

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x012B2B64 File Offset: 0x012B0D64
		internal static bool oR89ImVvqUrGTwZZu0Oc()
		{
			return true;
		}

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x012B2B68 File Offset: 0x012B0D68
		internal static bool EyHxGbVv7RtZ2YNkFfBN()
		{
			return false;
		}

		// Token: 0x04009496 RID: 38038
		internal M937_BattleForTomorrow $self_$44129;

		// Token: 0x02001BB4 RID: 7092
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5B2 RID: 42418 RVA: 0x012B2B6C File Offset: 0x012B0D6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (163419 - 545211 != -381792)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (273479 - 595974 != -322494)
					{
						base..ctor();
						if (18209 - 51516 == -33307)
						{
							this.$self_$44128 = self_;
							if (176042 - 502352 == -326310)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A5B3 RID: 42419 RVA: 0x012B2C04 File Offset: 0x012B0E04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (260363 - 569153 != -308789)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1A;
					case 1:
						goto IL_E7;
					case 2:
						if (this.$self_$44128.instantRush)
						{
							if (95604 - 268479 != -172875)
							{
								break;
							}
							UnityEngine.Object.Instantiate(this.$self_$44128.instantRush, Vector3.zero, Quaternion.identity);
							if (187237 - 242647 != -55410)
							{
								break;
							}
						}
						this.YieldDefault(1);
						if (261124 - 273310 != -12185)
						{
							goto Block_4;
						}
						break;
					default:
						if (20244 - 385286 != -365041)
						{
							goto Block_6;
						}
						break;
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_4:
				goto IL_E7;
				Block_6:
				goto IL_1A;
				IL_E7:
				return false;
			}

			// Token: 0x0600A5B4 RID: 42420 RVA: 0x012B2D0C File Offset: 0x012B0F0C
			internal static bool gnfG4RVvPG18jw4ornx3()
			{
				return true;
			}

			// Token: 0x0600A5B5 RID: 42421 RVA: 0x012B2D10 File Offset: 0x012B0F10
			internal static bool Ox22ILVv0uhN0jQFNmn2()
			{
				return false;
			}

			// Token: 0x04009497 RID: 38039
			internal M937_BattleForTomorrow $self_$44128;
		}
	}

	// Token: 0x02001BB5 RID: 7093
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnPlayCut5$44130 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5B6 RID: 42422 RVA: 0x012B2D14 File Offset: 0x012B0F14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnPlayCut5$44130(M937_BattleForTomorrow self_)
		{
			if (188651 - 107368 != 81283)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (69844 - 167419 == -97575)
				{
					base..ctor();
					if (255594 - 106906 != 148689)
					{
						this.$self_$44132 = self_;
						if (171846 - 346787 != -174940)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x012B2DAC File Offset: 0x012B0FAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$OnPlayCut5$44130.$(this.$self_$44132);
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x012B2DBC File Offset: 0x012B0FBC
		internal static bool AQBQ9CVvbCKcrBGr6SVH()
		{
			return true;
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x012B2DC0 File Offset: 0x012B0FC0
		internal static bool ccOl9sVvuDJ16djnTamT()
		{
			return false;
		}

		// Token: 0x04009498 RID: 38040
		internal M937_BattleForTomorrow $self_$44132;

		// Token: 0x02001BB6 RID: 7094
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5BA RID: 42426 RVA: 0x012B2DC4 File Offset: 0x012B0FC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (107394 - 565255 != -457860)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211985 - 477187 != -265201)
					{
						base..ctor();
						if (282466 - 254061 != 28406)
						{
							this.$self_$44131 = self_;
							if (23188 - 403904 != -380715)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A5BB RID: 42427 RVA: 0x012B2E5C File Offset: 0x012B105C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216226 - 33774 != 182452)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7DB;
					case 2:
						if (this.$self_$44131.earthSmasher_ring)
						{
							if (77947 - 328067 == -250119)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44131.earthSmasher_ring, Vector3.zero, Quaternion.identity);
							if (258446 - 304244 != -45797)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing earthSmasher_ring GameObject");
							if (158019 - 37108 != 120911)
							{
								continue;
							}
							goto IL_461;
						}
						break;
					case 3:
						if (this.$self_$44131.earthSmasher_hit)
						{
							if (266617 - 514044 != -247427)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44131.earthSmasher_hit, Vector3.zero, Quaternion.identity);
							if (152314 - 284223 != -131908)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing earthSmasher_hit GameObject");
							if (28098 - 214321 != -186222)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$44131.rushingFalcon_ring)
						{
							if (131085 - 396591 == -265505)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44131.rushingFalcon_ring, Vector3.zero, Quaternion.identity);
							if (201935 - 66886 == 135050)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing rushingFalcon_ring GameObject");
							if (195032 - 303868 == -108835)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_2F1;
						}
						if (147447 - 427236 != -279789)
						{
							continue;
						}
						if (!this.$self_$44131.rushingFalcon_vc)
						{
							goto IL_2F1;
						}
						if (30221 - 580810 == -550588)
						{
							continue;
						}
						this.$self_$44131.audio.PlayOneShot(this.$self_$44131.rushingFalcon_vc);
						if (257739 - 342886 != -85146)
						{
							goto Block_40;
						}
						continue;
					case 5:
						if (this.$self_$44131.rushingFalcon_hit)
						{
							if (191775 - 17517 != 174258)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44131.rushingFalcon_hit, Vector3.zero, Quaternion.identity);
							if (162330 - 56658 != 105672)
							{
								continue;
							}
							goto IL_738;
						}
						else
						{
							Debug.LogError("Missing rushingFalcon_hit GameObject");
							if (275839 - 180797 != 95042)
							{
								continue;
							}
							goto IL_5C7;
						}
						break;
					case 6:
						if (this.$self_$44131.moonBlade)
						{
							if (211679 - 191127 == 20553)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44131.moonBlade, Vector3.zero, Quaternion.identity);
							if (185787 - 137167 == 48621)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing moonBlade GameObject");
							if (250653 - 11235 == 239419)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_1EF;
						}
						if (248432 - 93626 == 154807)
						{
							continue;
						}
						if (!this.$self_$44131.moonBlade_vc)
						{
							goto IL_1EF;
						}
						if (169025 - 423420 == -254394)
						{
							continue;
						}
						this.$self_$44131.audio.PlayOneShot(this.$self_$44131.moonBlade_vc);
						if (96299 - 83142 != 13158)
						{
							goto Block_4;
						}
						continue;
					case 7:
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_15D;
						}
						if (216353 - 306601 != -90248)
						{
							continue;
						}
						if (!this.$self_$44131.nAttack2_vc)
						{
							goto IL_15D;
						}
						if (156775 - 461251 == -304475)
						{
							continue;
						}
						this.$self_$44131.audio.PlayOneShot(this.$self_$44131.nAttack2_vc);
						if (127094 - 397205 != -270111)
						{
							continue;
						}
						goto IL_15D;
					case 8:
						if (this.$self_$44131.thousandShot_ring)
						{
							if (216481 - 274855 == -58373)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44131.thousandShot_ring, Vector3.zero, Quaternion.identity);
							if (147352 - 65981 == 81372)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing thousandShot_ring GameObject");
							if (186008 - 35648 == 150361)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_693;
						}
						if (204671 - 529299 == -324627)
						{
							continue;
						}
						if (!this.$self_$44131.thousandShot_vc)
						{
							goto IL_693;
						}
						if (289023 - 228292 == 60732)
						{
							continue;
						}
						this.$self_$44131.audio.PlayOneShot(this.$self_$44131.thousandShot_vc);
						if (3777 - 538602 != -534824)
						{
							goto Block_19;
						}
						continue;
					case 9:
						if (this.$self_$44131.thousandShot_fire)
						{
							if (264395 - 99660 != 164735)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44131.thousandShot_fire, Vector3.zero, Quaternion.identity);
							if (153993 - 343852 != -189859)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing thousandShot_fire GameObject");
							if (83267 - 316509 != -233242)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (98635 - 229927 != -131292)
						{
							continue;
						}
						goto IL_7DB;
					default:
						if (154197 - 78833 == 75365)
						{
							continue;
						}
						break;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						goto IL_41C;
					}
					if (54641 - 12332 != 42310)
					{
						if (!this.$self_$44131.earthSmasher_vc)
						{
							goto IL_41C;
						}
						if (175460 - 449881 != -274420)
						{
							this.$self_$44131.audio.PlayOneShot(this.$self_$44131.earthSmasher_vc);
							if (146441 - 131461 == 14980)
							{
								goto IL_41C;
							}
						}
					}
				}
				Block_4:
				goto IL_1EF;
				Block_5:
				goto IL_796;
				IL_15D:
				return this.Yield(8, new WaitForSeconds(0.8f));
				IL_1EF:
				return this.Yield(7, new WaitForSeconds(0.7f));
				Block_19:
				goto IL_693;
				IL_2F1:
				return this.Yield(5, new WaitForSeconds(0.3f));
				Block_29:
				goto IL_461;
				IL_41C:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_461:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_40:
				goto IL_2F1;
				IL_5C7:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_48:
				goto IL_796;
				IL_693:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_738:
				goto IL_5C7;
				IL_796:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_7DB:
				return false;
			}

			// Token: 0x0600A5BC RID: 42428 RVA: 0x012B3658 File Offset: 0x012B1858
			internal static bool MLuvhcVvIBGTc2UYK8nZ()
			{
				return true;
			}

			// Token: 0x0600A5BD RID: 42429 RVA: 0x012B365C File Offset: 0x012B185C
			internal static bool J3FP5qVvBAEexHlejeYD()
			{
				return false;
			}

			// Token: 0x04009499 RID: 38041
			internal M937_BattleForTomorrow $self_$44131;
		}
	}

	// Token: 0x02001BB7 RID: 7095
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnPlayCut6$44133 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5BE RID: 42430 RVA: 0x012B3660 File Offset: 0x012B1860
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnPlayCut6$44133(M937_BattleForTomorrow self_)
		{
			if (228175 - 42080 != 186096)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (53636 - 150125 != -96488)
				{
					base..ctor();
					if (265540 - 540101 == -274561)
					{
						this.$self_$44135 = self_;
						if (73091 - 74386 == -1295)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A5BF RID: 42431 RVA: 0x012B36F8 File Offset: 0x012B18F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$OnPlayCut6$44133.$(this.$self_$44135);
		}

		// Token: 0x0600A5C0 RID: 42432 RVA: 0x012B3708 File Offset: 0x012B1908
		internal static bool Vv067BVveyJRSvcLYlEK()
		{
			return true;
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x012B370C File Offset: 0x012B190C
		internal static bool RfcnRjVvrW0Homj1TuGB()
		{
			return false;
		}

		// Token: 0x0400949A RID: 38042
		internal M937_BattleForTomorrow $self_$44135;

		// Token: 0x02001BB8 RID: 7096
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5C2 RID: 42434 RVA: 0x012B3710 File Offset: 0x012B1910
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (288353 - 433386 != -145033)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242473 - 167736 != 74738)
					{
						base..ctor();
						if (176257 - 37519 == 138738)
						{
							this.$self_$44134 = self_;
							if (231138 - 42581 == 188557)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A5C3 RID: 42435 RVA: 0x012B37A8 File Offset: 0x012B19A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (282816 - 55587 != 227229)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_CD9;
					case 2:
						if (this.$self_$44134.whale_ring)
						{
							if (266618 - 100766 == 165853)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44134.whale_ring, Vector3.zero, Quaternion.identity);
							if (31095 - 537706 == -506610)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_6F5;
						}
						if (36521 - 157686 == -121164)
						{
							continue;
						}
						if (!this.$self_$44134.whale_vc)
						{
							goto IL_6F5;
						}
						if (20645 - 219450 != -198805)
						{
							continue;
						}
						this.$self_$44134.audio.PlayOneShot(this.$self_$44134.whale_vc);
						if (235932 - 130670 != 105263)
						{
							goto Block_83;
						}
						continue;
					case 3:
						if (!this.$self_$44134.penguin_ring)
						{
							goto IL_48D;
						}
						if (30057 - 271234 == -241176)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44134.penguin_ring, Vector3.zero, Quaternion.identity);
						if (18410 - 92326 != -73915)
						{
							goto Block_26;
						}
						continue;
					case 4:
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_A4B;
						}
						if (228837 - 232230 != -3393)
						{
							continue;
						}
						if (!this.$self_$44134.penguin_vc)
						{
							goto IL_A4B;
						}
						if (296585 - 29481 == 267105)
						{
							continue;
						}
						this.$self_$44134.audio.PlayOneShot(this.$self_$44134.penguin_vc);
						if (271540 - 403003 != -131463)
						{
							continue;
						}
						goto IL_A4B;
					case 5:
						if (!this.$self_$44134.penguin_cast)
						{
							goto IL_502;
						}
						if (211541 - 538709 == -327167)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44134.penguin_cast, Vector3.zero, Quaternion.identity);
						if (279530 - 162738 != 116792)
						{
							continue;
						}
						goto IL_502;
					case 6:
						if (!this.$self_$44134.monkey_ring)
						{
							goto IL_8E8;
						}
						if (45222 - 324400 == -279177)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44134.monkey_ring, Vector3.zero, Quaternion.identity);
						if (152958 - 69720 != 83238)
						{
							continue;
						}
						goto IL_8E8;
					case 7:
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_928;
						}
						if (122650 - 511527 != -388877)
						{
							continue;
						}
						if (!this.$self_$44134.monkey_vc)
						{
							goto IL_928;
						}
						if (222261 - 370391 == -148129)
						{
							continue;
						}
						this.$self_$44134.audio.PlayOneShot(this.$self_$44134.monkey_vc);
						if (61907 - 459668 != -397760)
						{
							goto Block_80;
						}
						continue;
					case 8:
						if (!this.$self_$44134.monkey_fire)
						{
							goto IL_176;
						}
						if (207675 - 65106 == 142570)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44134.monkey_fire, Vector3.zero, Quaternion.identity);
						if (25048 - 72858 != -47810)
						{
							continue;
						}
						goto IL_176;
					case 9:
						if (this.$self_$44134.phoenix_fire)
						{
							if (213342 - 217370 == -4027)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44134.phoenix_fire, Vector3.zero, Quaternion.identity);
							if (209038 - 260555 != -51517)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_B3B;
						}
						if (177661 - 107271 != 70390)
						{
							continue;
						}
						if (!this.$self_$44134.phoenix_vc)
						{
							goto IL_B3B;
						}
						if (3928 - 156939 == -153010)
						{
							continue;
						}
						this.$self_$44134.audio.PlayOneShot(this.$self_$44134.phoenix_vc);
						if (101280 - 318381 != -217100)
						{
							goto Block_61;
						}
						continue;
					case 10:
						if (this.$self_$44134.chameleon_ring)
						{
							if (199826 - 360967 == -161140)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44134.chameleon_ring, Vector3.zero, Quaternion.identity);
							if (6321 - 320961 != -314640)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_1F1;
						}
						if (210283 - 373292 == -163008)
						{
							continue;
						}
						if (!this.$self_$44134.chameleon_vc)
						{
							goto IL_1F1;
						}
						if (264614 - 513908 != -249294)
						{
							continue;
						}
						this.$self_$44134.audio.PlayOneShot(this.$self_$44134.chameleon_vc);
						if (145938 - 567365 != -421426)
						{
							goto Block_84;
						}
						continue;
					case 11:
						if (!this.$self_$44134.chameleon_fire)
						{
							goto IL_98F;
						}
						if (295412 - 461930 == -166517)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44134.chameleon_fire, Vector3.zero, Quaternion.identity);
						if (241865 - 365789 != -123924)
						{
							continue;
						}
						goto IL_98F;
					case 12:
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_60F;
						}
						if (274289 - 17970 != 256319)
						{
							continue;
						}
						if (!this.$self_$44134.bat1_vc)
						{
							goto IL_60F;
						}
						if (59480 - 383596 == -324115)
						{
							continue;
						}
						this.$self_$44134.audio.PlayOneShot(this.$self_$44134.bat1_vc);
						if (164827 - 419109 != -254282)
						{
							continue;
						}
						goto IL_60F;
					case 13:
						if (!this.$self_$44134.bat_fire)
						{
							goto IL_A90;
						}
						if (179089 - 105042 == 74048)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44134.bat_fire, Vector3.zero, Quaternion.identity);
						if (281733 - 595309 != -313575)
						{
							goto Block_79;
						}
						continue;
					case 14:
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_C1A;
						}
						if (124121 - 500283 == -376161)
						{
							continue;
						}
						if (!this.$self_$44134.bat2_vc)
						{
							goto IL_C1A;
						}
						if (104158 - 241464 != -137306)
						{
							continue;
						}
						this.$self_$44134.audio.PlayOneShot(this.$self_$44134.bat2_vc);
						if (277935 - 434256 != -156320)
						{
							goto Block_24;
						}
						continue;
					case 15:
						if (!this.$self_$44134.bat_fire)
						{
							goto IL_813;
						}
						if (287551 - 165784 != 121767)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44134.bat_fire, Vector3.zero, Quaternion.identity);
						if (125011 - 364204 != -239193)
						{
							continue;
						}
						goto IL_813;
					case 16:
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_447;
						}
						if (187754 - 382175 == -194420)
						{
							continue;
						}
						if (!this.$self_$44134.bat3_vc)
						{
							goto IL_447;
						}
						if (44649 - 139809 == -95159)
						{
							continue;
						}
						this.$self_$44134.audio.PlayOneShot(this.$self_$44134.bat3_vc);
						if (100232 - 443537 != -343305)
						{
							continue;
						}
						goto IL_447;
					case 17:
						if (!this.$self_$44134.bat_fire)
						{
							goto IL_6B4;
						}
						if (58576 - 87094 != -28518)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44134.bat_fire, Vector3.zero, Quaternion.identity);
						if (145698 - 412009 != -266310)
						{
							goto Block_9;
						}
						continue;
					case 18:
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_76F;
						}
						if (58234 - 561316 != -503082)
						{
							continue;
						}
						if (!this.$self_$44134.rabbit_vc)
						{
							goto IL_76F;
						}
						if (240324 - 263744 == -23419)
						{
							continue;
						}
						this.$self_$44134.audio.PlayOneShot(this.$self_$44134.rabbit_vc);
						if (50713 - 289758 != -239044)
						{
							goto IL_76F;
						}
						continue;
					case 19:
						if (!this.$self_$44134.rabbit_ring)
						{
							goto IL_9D0;
						}
						if (55058 - 115018 == -59959)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44134.rabbit_ring, Vector3.zero, Quaternion.identity);
						if (269030 - 55456 != 213575)
						{
							goto Block_27;
						}
						continue;
					case 20:
						if (this.$self_$44134.rabbit_fire)
						{
							if (153204 - 567641 != -414437)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44134.rabbit_fire, Vector3.zero, Quaternion.identity);
							if (70279 - 210186 != -139907)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (115564 - 370150 != -254585)
						{
							goto Block_69;
						}
						continue;
					default:
						if (165953 - 485270 == -319316)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$44134.thousandShot_hit)
					{
						goto IL_29B;
					}
					if (230114 - 378741 != -148626)
					{
						UnityEngine.Object.Instantiate(this.$self_$44134.thousandShot_hit, Vector3.zero, Quaternion.identity);
						if (126216 - 162397 != -36180)
						{
							goto Block_17;
						}
					}
				}
				Block_9:
				goto IL_6B4;
				IL_176:
				return this.Yield(9, new WaitForSeconds(0.1f));
				IL_1F1:
				return this.Yield(11, new WaitForSeconds(1f));
				Block_17:
				IL_29B:
				return this.Yield(2, new WaitForSeconds(1.5f));
				Block_24:
				goto IL_C1A;
				Block_26:
				goto IL_48D;
				Block_27:
				goto IL_9D0;
				IL_447:
				return this.Yield(17, new WaitForSeconds(0.4f));
				IL_48D:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_502:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_60F:
				return this.Yield(13, new WaitForSeconds(0.3f));
				IL_6B4:
				return this.Yield(18, new WaitForSeconds(2.1f));
				IL_6F5:
				return this.Yield(3, new WaitForSeconds(1.5f));
				IL_76F:
				return this.Yield(19, new WaitForSeconds(0.9f));
				IL_813:
				return this.Yield(16, new WaitForSeconds(0.5f));
				Block_61:
				goto IL_B3B;
				IL_8E8:
				return this.Yield(7, new WaitForSeconds(1.2f));
				IL_928:
				return this.Yield(8, new WaitForSeconds(0.8f));
				Block_69:
				goto IL_CD9;
				IL_98F:
				return this.Yield(12, new WaitForSeconds(1.3f));
				IL_9D0:
				return this.Yield(20, new WaitForSeconds(0.3f));
				IL_A4B:
				return this.Yield(5, new WaitForSeconds(1.5f));
				IL_A90:
				return this.Yield(14, new WaitForSeconds(0.6f));
				Block_79:
				goto IL_A90;
				Block_80:
				goto IL_928;
				IL_B3B:
				return this.Yield(10, new WaitForSeconds(1.4f));
				Block_83:
				goto IL_6F5;
				Block_84:
				goto IL_1F1;
				IL_C1A:
				return this.Yield(15, new WaitForSeconds(0.3f));
				IL_CD9:
				return false;
			}

			// Token: 0x0600A5C4 RID: 42436 RVA: 0x012B44A0 File Offset: 0x012B26A0
			internal static bool DNySJYVvjXMatdLDfvlC()
			{
				return true;
			}

			// Token: 0x0600A5C5 RID: 42437 RVA: 0x012B44A4 File Offset: 0x012B26A4
			internal static bool wZ1pZZVvhsBU4TiaFswH()
			{
				return false;
			}

			// Token: 0x0400949B RID: 38043
			internal M937_BattleForTomorrow $self_$44134;
		}
	}

	// Token: 0x02001BB9 RID: 7097
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnPlayCut7$44136 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5C6 RID: 42438 RVA: 0x012B44A8 File Offset: 0x012B26A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnPlayCut7$44136(M937_BattleForTomorrow self_)
		{
			if (222849 - 339285 != -116436)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82576 - 398984 == -316408)
				{
					base..ctor();
					if (6764 - 589055 != -582290)
					{
						this.$self_$44139 = self_;
						if (57397 - 63712 == -6315)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x012B4540 File Offset: 0x012B2740
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$OnPlayCut7$44136.$(this.$self_$44139);
		}

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x012B4550 File Offset: 0x012B2750
		internal static bool L8WVdDVvsmHkJJ6MUJDm()
		{
			return true;
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x012B4554 File Offset: 0x012B2754
		internal static bool VoFZ2EVv957xw33gXdYp()
		{
			return false;
		}

		// Token: 0x0400949C RID: 38044
		internal M937_BattleForTomorrow $self_$44139;

		// Token: 0x02001BBA RID: 7098
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5CA RID: 42442 RVA: 0x012B4558 File Offset: 0x012B2758
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (45765 - 596043 != -550277)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (22318 - 210178 != -187859)
					{
						base..ctor();
						if (298129 - 415721 == -117592)
						{
							this.$self_$44138 = self_;
							if (131552 - 423362 == -291810)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A5CB RID: 42443 RVA: 0x012B45F0 File Offset: 0x012B27F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (257408 - 132979 != 124430)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_40D;
					case 2:
						if (!this.$self_$44138.monkey_hit)
						{
							goto IL_383;
						}
						if (172410 - 59499 != 112911)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44138.monkey_hit, Vector3.zero, Quaternion.identity);
						if (267103 - 331485 != -64381)
						{
							goto Block_10;
						}
						continue;
					case 3:
						if (!this.$self_$44138.mole_ring)
						{
							goto IL_5F;
						}
						if (111798 - 488547 != -376749)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44138.mole_ring, Vector3.zero, Quaternion.identity);
						if (199124 - 455712 != -256587)
						{
							goto Block_16;
						}
						continue;
					case 4:
						if (!this.$self_$44138.bat_hit)
						{
							goto IL_1A;
						}
						if (231904 - 127261 != 104643)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44138.bat_hit, Vector3.zero, Quaternion.identity);
						if (254760 - 142280 != 112481)
						{
							goto Block_18;
						}
						continue;
					case 5:
						if (!this.$self_$44138.mole_fire)
						{
							goto IL_1E4;
						}
						if (296925 - 33741 == 263185)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44138.mole_fire, Vector3.zero, Quaternion.identity);
						if (136178 - 327553 != -191375)
						{
							continue;
						}
						goto IL_1E4;
					case 6:
						if (!this.$self_$44138.penguin_fire)
						{
							goto IL_2EA;
						}
						if (255095 - 19879 != 235216)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44138.penguin_fire, Vector3.zero, Quaternion.identity);
						if (223856 - 43548 != 180308)
						{
							continue;
						}
						goto IL_2EA;
					case 7:
						this.$mCameraEffect$44137 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
						if (37378 - 339483 != -302105)
						{
							continue;
						}
						this.$mCameraEffect$44137.AddColorRamp("whiteRamp", "none", (float)10, new Vector4((float)0, 0.5f, 0.5f, 0.8f));
						if (289039 - 459084 == -170044)
						{
							continue;
						}
						this.YieldDefault(1);
						if (94738 - 325844 != -231106)
						{
							continue;
						}
						goto IL_40D;
					default:
						if (228035 - 87240 == 140796)
						{
							continue;
						}
						break;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						goto IL_33E;
					}
					if (277899 - 355515 == -77616)
					{
						if (!this.$self_$44138.mole_vc)
						{
							goto IL_33E;
						}
						if (7348 - 473897 != -466548)
						{
							this.$self_$44138.audio.PlayOneShot(this.$self_$44138.mole_vc);
							if (239688 - 526635 != -286946)
							{
								goto Block_13;
							}
						}
					}
				}
				IL_1A:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_5F:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_10:
				goto IL_383;
				Block_13:
				goto IL_33E;
				IL_1E4:
				return this.Yield(6, new WaitForSeconds(0.4f));
				Block_16:
				goto IL_5F;
				Block_18:
				goto IL_1A;
				IL_2EA:
				return this.Yield(7, new WaitForSeconds(1.5f));
				IL_33E:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_383:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_40D:
				return false;
			}

			// Token: 0x0600A5CC RID: 42444 RVA: 0x012B4A1C File Offset: 0x012B2C1C
			internal static bool TpHNWDVv1HKA0DhF9dD9()
			{
				return true;
			}

			// Token: 0x0600A5CD RID: 42445 RVA: 0x012B4A20 File Offset: 0x012B2C20
			internal static bool o0ZVWxVv4kt1akeLVem2()
			{
				return false;
			}

			// Token: 0x0400949D RID: 38045
			internal CameraEffect $mCameraEffect$44137;

			// Token: 0x0400949E RID: 38046
			internal M937_BattleForTomorrow $self_$44138;
		}
	}

	// Token: 0x02001BBB RID: 7099
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnPlayCut9$44140 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5CE RID: 42446 RVA: 0x012B4A24 File Offset: 0x012B2C24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnPlayCut9$44140(M937_BattleForTomorrow self_)
		{
			if (50174 - 587456 != -537282)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235952 - 234979 != 974)
				{
					base..ctor();
					if (207711 - 443124 == -235413)
					{
						this.$self_$44142 = self_;
						if (268346 - 407959 == -139613)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A5CF RID: 42447 RVA: 0x012B4ABC File Offset: 0x012B2CBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$OnPlayCut9$44140.$(this.$self_$44142);
		}

		// Token: 0x0600A5D0 RID: 42448 RVA: 0x012B4ACC File Offset: 0x012B2CCC
		internal static bool fOR0beVvzVkfM9u0YMbU()
		{
			return true;
		}

		// Token: 0x0600A5D1 RID: 42449 RVA: 0x012B4AD0 File Offset: 0x012B2CD0
		internal static bool uneLmQVRaWYS6pbEONhe()
		{
			return false;
		}

		// Token: 0x0400949F RID: 38047
		internal M937_BattleForTomorrow $self_$44142;

		// Token: 0x02001BBC RID: 7100
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5D2 RID: 42450 RVA: 0x012B4AD4 File Offset: 0x012B2CD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (50463 - 52640 != -2177)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (115104 - 128017 == -12913)
					{
						base..ctor();
						if (176172 - 120333 == 55839)
						{
							this.$self_$44141 = self_;
							if (266357 - 522258 == -255901)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A5D3 RID: 42451 RVA: 0x012B4B6C File Offset: 0x012B2D6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (257807 - 47940 != 209868)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_6B;
					case 1:
						goto IL_175;
					case 2:
						if (this.$self_$44141.cAttack_ring)
						{
							if (266283 - 453197 != -186914)
							{
								break;
							}
							UnityEngine.Object.Instantiate(this.$self_$44141.cAttack_ring, Vector3.zero, Quaternion.identity);
							if (264057 - 492113 != -228056)
							{
								break;
							}
						}
						if (PlayerPrefs.GetInt("pvoice", 1) != 0)
						{
							if (134573 - 114022 != 20551)
							{
								break;
							}
							if (this.$self_$44141.cAttack_vc)
							{
								if (234318 - 12858 == 221461)
								{
									break;
								}
								this.$self_$44141.audio.PlayOneShot(this.$self_$44141.cAttack_vc);
								if (31989 - 151722 == -119732)
								{
									break;
								}
							}
						}
						this.YieldDefault(1);
						if (239715 - 423423 == -183708)
						{
							goto IL_175;
						}
						break;
					default:
						if (118106 - 170234 != -52127)
						{
							goto Block_12;
						}
						break;
					}
				}
				IL_6B:
				return this.Yield(2, new WaitForSeconds(3.3f));
				Block_12:
				goto IL_6B;
				IL_175:
				return false;
			}

			// Token: 0x0600A5D4 RID: 42452 RVA: 0x012B4D00 File Offset: 0x012B2F00
			internal static bool v5Q9SqVR5d332dYBmHY2()
			{
				return true;
			}

			// Token: 0x0600A5D5 RID: 42453 RVA: 0x012B4D04 File Offset: 0x012B2F04
			internal static bool LC8mdhVRp5FWBwhuy7bi()
			{
				return false;
			}

			// Token: 0x040094A0 RID: 38048
			internal M937_BattleForTomorrow $self_$44141;
		}
	}

	// Token: 0x02001BBD RID: 7101
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnPlayCut10$44143 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5D6 RID: 42454 RVA: 0x012B4D08 File Offset: 0x012B2F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnPlayCut10$44143(M937_BattleForTomorrow self_)
		{
			if (99000 - 592699 != -493698)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270767 - 251885 != 18883)
				{
					base..ctor();
					if (265549 - 275449 == -9900)
					{
						this.$self_$44145 = self_;
						if (275162 - 509773 == -234611)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x012B4DA0 File Offset: 0x012B2FA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$OnPlayCut10$44143.$(this.$self_$44145);
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x012B4DB0 File Offset: 0x012B2FB0
		internal static bool IUKIyPVRV7OUJOY9AKKk()
		{
			return true;
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x012B4DB4 File Offset: 0x012B2FB4
		internal static bool pAIJ4CVRtF1lXXwNIhda()
		{
			return false;
		}

		// Token: 0x040094A1 RID: 38049
		internal M937_BattleForTomorrow $self_$44145;

		// Token: 0x02001BBE RID: 7102
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5DA RID: 42458 RVA: 0x012B4DB8 File Offset: 0x012B2FB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (11076 - 421643 != -410567)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292756 - 258364 == 34392)
					{
						base..ctor();
						if (90163 - 134180 == -44017)
						{
							this.$self_$44144 = self_;
							if (31612 - 494312 == -462700)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A5DB RID: 42459 RVA: 0x012B4E50 File Offset: 0x012B3050
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237566 - 297915 != -60348)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_281;
					case 2:
						if (!this.$self_$44144.sheep_fire)
						{
							goto IL_18C;
						}
						if (259312 - 429852 != -170540)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44144.sheep_fire, Vector3.zero, Quaternion.identity);
						if (21573 - 568038 != -546465)
						{
							continue;
						}
						goto IL_18C;
					case 3:
						if (PlayerPrefs.GetInt("pvoice", 1) != 0)
						{
							if (237721 - 367994 == -130272)
							{
								continue;
							}
							if (this.$self_$44144.wolf_nAttack1_vc)
							{
								if (229069 - 489182 != -260113)
								{
									continue;
								}
								this.$self_$44144.audio.PlayOneShot(this.$self_$44144.wolf_nAttack1_vc);
								if (252370 - 516988 == -264617)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (259703 - 493166 != -233463)
						{
							continue;
						}
						goto IL_281;
					default:
						if (25832 - 49874 != -24042)
						{
							continue;
						}
						break;
					}
					if (this.$self_$44144.sheep_ring)
					{
						if (157718 - 469484 != -311766)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44144.sheep_ring, Vector3.zero, Quaternion.identity);
						if (176021 - 375651 != -199630)
						{
							continue;
						}
					}
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						break;
					}
					if (96142 - 225591 == -129449)
					{
						if (!this.$self_$44144.sheep_vc)
						{
							break;
						}
						if (72649 - 139749 == -67100)
						{
							this.$self_$44144.audio.PlayOneShot(this.$self_$44144.sheep_vc);
							if (44868 - 543966 != -499097)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_18C:
				return this.Yield(3, new WaitForSeconds(0.8f));
				IL_281:
				return false;
			}

			// Token: 0x0600A5DC RID: 42460 RVA: 0x012B50F0 File Offset: 0x012B32F0
			internal static bool pVUBQNVRN4m4v3dXpj5n()
			{
				return true;
			}

			// Token: 0x0600A5DD RID: 42461 RVA: 0x012B50F4 File Offset: 0x012B32F4
			internal static bool CIUgAkVRY72rE89grkVs()
			{
				return false;
			}

			// Token: 0x040094A2 RID: 38050
			internal M937_BattleForTomorrow $self_$44144;
		}
	}

	// Token: 0x02001BBF RID: 7103
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnPlayCut12$44146 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5DE RID: 42462 RVA: 0x012B50F8 File Offset: 0x012B32F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnPlayCut12$44146(M937_BattleForTomorrow self_)
		{
			if (221554 - 537647 != -316093)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199844 - 261718 == -61874)
				{
					base..ctor();
					if (216877 - 203611 == 13266)
					{
						this.$self_$44148 = self_;
						if (28278 - 105879 != -77600)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x012B5190 File Offset: 0x012B3390
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$OnPlayCut12$44146.$(this.$self_$44148);
		}

		// Token: 0x0600A5E0 RID: 42464 RVA: 0x012B51A0 File Offset: 0x012B33A0
		internal static bool T0VKTNVRcYfbSACVXjR5()
		{
			return true;
		}

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x012B51A4 File Offset: 0x012B33A4
		internal static bool j8vDrdVRU2E433F4ZvIb()
		{
			return false;
		}

		// Token: 0x040094A3 RID: 38051
		internal M937_BattleForTomorrow $self_$44148;

		// Token: 0x02001BC0 RID: 7104
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5E2 RID: 42466 RVA: 0x012B51A8 File Offset: 0x012B33A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (283612 - 266320 != 17293)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (130013 - 442151 != -312137)
					{
						base..ctor();
						if (149229 - 370882 == -221653)
						{
							this.$self_$44147 = self_;
							if (133571 - 421863 != -288291)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A5E3 RID: 42467 RVA: 0x012B5240 File Offset: 0x012B3440
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284889 - 432821 != -147931)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_3C;
					case 1:
						goto IL_18F;
					case 2:
						if (PlayerPrefs.GetInt("pvoice", 1) == 0)
						{
							goto IL_14A;
						}
						if (115518 - 597287 == -481769)
						{
							if (!this.$self_$44147.wolf_nAttack3_vc)
							{
								goto IL_14A;
							}
							if (76904 - 434721 != -357816)
							{
								this.$self_$44147.audio.PlayOneShot(this.$self_$44147.wolf_nAttack3_vc);
								if (194512 - 537891 == -343379)
								{
									goto IL_14A;
								}
							}
						}
						break;
					case 3:
						if (this.$self_$44147.wolf_ring)
						{
							if (182708 - 526129 != -343421)
							{
								break;
							}
							UnityEngine.Object.Instantiate(this.$self_$44147.wolf_ring, Vector3.zero, Quaternion.identity);
							if (231908 - 51021 == 180888)
							{
								break;
							}
						}
						this.YieldDefault(1);
						if (17629 - 533758 != -516128)
						{
							goto Block_2;
						}
						break;
					default:
						if (111879 - 273519 != -161639)
						{
							goto Block_5;
						}
						break;
					}
				}
				Block_2:
				goto IL_18F;
				IL_3C:
				return this.Yield(2, new WaitForSeconds(1.2f));
				Block_5:
				goto IL_3C;
				IL_14A:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_18F:
				return false;
			}

			// Token: 0x0600A5E4 RID: 42468 RVA: 0x012B53F0 File Offset: 0x012B35F0
			internal static bool A9V5nFVRTQbQHMUZv84X()
			{
				return true;
			}

			// Token: 0x0600A5E5 RID: 42469 RVA: 0x012B53F4 File Offset: 0x012B35F4
			internal static bool Fof6APVR3A4kCrJl3CUu()
			{
				return false;
			}

			// Token: 0x040094A4 RID: 38052
			internal M937_BattleForTomorrow $self_$44147;
		}
	}

	// Token: 0x02001BC1 RID: 7105
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnPlayCut13$44149 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5E6 RID: 42470 RVA: 0x012B53F8 File Offset: 0x012B35F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnPlayCut13$44149(M937_BattleForTomorrow self_)
		{
			if (23358 - 589698 != -566340)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (107209 - 142541 == -35332)
				{
					base..ctor();
					if (127462 - 502519 != -375056)
					{
						this.$self_$44152 = self_;
						if (17724 - 167912 != -150187)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A5E7 RID: 42471 RVA: 0x012B5490 File Offset: 0x012B3690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$OnPlayCut13$44149.$(this.$self_$44152);
		}

		// Token: 0x0600A5E8 RID: 42472 RVA: 0x012B54A0 File Offset: 0x012B36A0
		internal static bool cWmJdhVRXvIprgl8deuZ()
		{
			return true;
		}

		// Token: 0x0600A5E9 RID: 42473 RVA: 0x012B54A4 File Offset: 0x012B36A4
		internal static bool nvmylvVRQ9tuDtRu4Reg()
		{
			return false;
		}

		// Token: 0x040094A5 RID: 38053
		internal M937_BattleForTomorrow $self_$44152;

		// Token: 0x02001BC2 RID: 7106
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5EA RID: 42474 RVA: 0x012B54A8 File Offset: 0x012B36A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (201865 - 296125 != -94259)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (58784 - 333977 == -275193)
					{
						base..ctor();
						if (139324 - 23199 != 116126)
						{
							this.$self_$44151 = self_;
							if (202672 - 459640 != -256967)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A5EB RID: 42475 RVA: 0x012B5540 File Offset: 0x012B3740
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (1612 - 3217 != -1605)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_B6;
					case 1:
						goto IL_1C5;
					case 2:
						this.$mCameraEffect$44150 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
						if (141591 - 436850 == -295259)
						{
							this.$mCameraEffect$44150.AddColorRamp("sepiaRamp", "sepiaMask", (float)1, new Vector4((float)0, (float)0, 0.5f, (float)0));
							if (267594 - 10237 != 257358)
							{
								goto Block_9;
							}
						}
						break;
					case 3:
						if (this.$self_$44151.wolf_hit)
						{
							if (174805 - 427457 != -252652)
							{
								break;
							}
							UnityEngine.Object.Instantiate(this.$self_$44151.wolf_hit, Vector3.zero, Quaternion.identity);
							if (166664 - 181677 == -15012)
							{
								break;
							}
						}
						this.$mCameraEffect$44150.AddColorRamp("whiteRamp", "none", (float)10, new Vector4((float)0, (float)0, 0.7f, 0.5f));
						if (113976 - 103737 == 10239)
						{
							this.YieldDefault(1);
							if (285573 - 315538 != -29964)
							{
								goto Block_3;
							}
						}
						break;
					default:
						if (61224 - 123536 == -62312)
						{
							goto IL_B6;
						}
						break;
					}
				}
				Block_3:
				goto IL_1C5;
				IL_B6:
				return this.Yield(2, new WaitForSeconds(1.5f));
				Block_9:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_1C5:
				return false;
			}

			// Token: 0x0600A5EC RID: 42476 RVA: 0x012B5724 File Offset: 0x012B3924
			internal static bool UERdENVRkb9CTineMQn6()
			{
				return true;
			}

			// Token: 0x0600A5ED RID: 42477 RVA: 0x012B5728 File Offset: 0x012B3928
			internal static bool E4OST0VRG2XPVAGldMht()
			{
				return false;
			}

			// Token: 0x040094A6 RID: 38054
			internal CameraEffect $mCameraEffect$44150;

			// Token: 0x040094A7 RID: 38055
			internal M937_BattleForTomorrow $self_$44151;
		}
	}

	// Token: 0x02001BC3 RID: 7107
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$44153 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5EE RID: 42478 RVA: 0x012B572C File Offset: 0x012B392C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$44153(Hashtable data, M937_BattleForTomorrow self_)
		{
			if (161605 - 579996 != -418390)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (218198 - 21044 == 197154)
				{
					base..ctor();
					if (87171 - 226306 != -139134)
					{
						this.$data$44158 = data;
						if (22327 - 185376 == -163049)
						{
							this.$self_$44159 = self_;
							if (230713 - 442963 != -212249)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A5EF RID: 42479 RVA: 0x012B57E8 File Offset: 0x012B39E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$onChangePlayer$44153.$(this.$data$44158, this.$self_$44159);
		}

		// Token: 0x0600A5F0 RID: 42480 RVA: 0x012B57FC File Offset: 0x012B39FC
		internal static bool MLLR9EVRHmwWtcldqrUS()
		{
			return true;
		}

		// Token: 0x0600A5F1 RID: 42481 RVA: 0x012B5800 File Offset: 0x012B3A00
		internal static bool Pkg4eGVRW1Y9q0VIYuHM()
		{
			return false;
		}

		// Token: 0x040094A8 RID: 38056
		internal Hashtable $data$44158;

		// Token: 0x040094A9 RID: 38057
		internal M937_BattleForTomorrow $self_$44159;

		// Token: 0x02001BC4 RID: 7108
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5F2 RID: 42482 RVA: 0x012B5804 File Offset: 0x012B3A04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M937_BattleForTomorrow self_)
			{
				if (134552 - 553450 != -418898)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (251822 - 109196 != 142627)
					{
						base..ctor();
						if (86987 - 315305 == -228318)
						{
							this.$data$44156 = data;
							if (280714 - 266884 != 13831)
							{
								this.$self_$44157 = self_;
								if (107154 - 553713 == -446559)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A5F3 RID: 42483 RVA: 0x012B58C0 File Offset: 0x012B3AC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (16449 - 44351 != -27902)
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
							if (183264 - 51473 == 131792)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (183582 - 49250 == 134333)
							{
								continue;
							}
							this.$mGameGui$44155 = (GameGui)this.$self_$44157.GetComponent(typeof(GameGui));
							if (18051 - 494705 != -476654)
							{
								continue;
							}
							this.$mGameGui$44155.enabled = true;
							if (254656 - 554775 != -300119)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (288367 - 213678 != 74689)
						{
							continue;
						}
						goto IL_205;
					default:
						if (245488 - 342738 != -97250)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (191858 - 407293 == -215435)
					{
						this.$self_$44157.SendMessage("onCreatePlayer", this.$data$44156);
						if (215309 - 497266 == -281957)
						{
							this.$mChangeGui$44154 = (ChangeGui)this.$self_$44157.GetComponent(typeof(ChangeGui));
							if (36483 - 265414 != -228930)
							{
								if (!this.$mChangeGui$44154.enabled)
								{
									break;
								}
								if (69805 - 101660 == -31855)
								{
									this.$mChangeGui$44154.close();
									if (247463 - 227146 == 20317)
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

			// Token: 0x0600A5F4 RID: 42484 RVA: 0x012B5AE4 File Offset: 0x012B3CE4
			internal static bool AFWnIHVRAVwptGfsaEi0()
			{
				return true;
			}

			// Token: 0x0600A5F5 RID: 42485 RVA: 0x012B5AE8 File Offset: 0x012B3CE8
			internal static bool eurm8NVRloD3McgxtRJL()
			{
				return false;
			}

			// Token: 0x040094AA RID: 38058
			internal ChangeGui $mChangeGui$44154;

			// Token: 0x040094AB RID: 38059
			internal GameGui $mGameGui$44155;

			// Token: 0x040094AC RID: 38060
			internal Hashtable $data$44156;

			// Token: 0x040094AD RID: 38061
			internal M937_BattleForTomorrow $self_$44157;
		}
	}

	// Token: 0x02001BC5 RID: 7109
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44160 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5F6 RID: 42486 RVA: 0x012B5AEC File Offset: 0x012B3CEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44160(M937_BattleForTomorrow self_)
		{
			if (148719 - 310013 != -161294)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (49547 - 52550 == -3003)
				{
					base..ctor();
					if (191648 - 430157 == -238509)
					{
						this.$self_$44164 = self_;
						if (141255 - 322423 == -181168)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A5F7 RID: 42487 RVA: 0x012B5B84 File Offset: 0x012B3D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$ReturnToTown$44160.$(this.$self_$44164);
		}

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x012B5B94 File Offset: 0x012B3D94
		internal static bool KOZfR3VRyoH9OlIV2XTP()
		{
			return true;
		}

		// Token: 0x0600A5F9 RID: 42489 RVA: 0x012B5B98 File Offset: 0x012B3D98
		internal static bool cpUYsXVRSmlmId8J3jDq()
		{
			return false;
		}

		// Token: 0x040094AE RID: 38062
		internal M937_BattleForTomorrow $self_$44164;

		// Token: 0x02001BC6 RID: 7110
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A5FA RID: 42490 RVA: 0x012B5B9C File Offset: 0x012B3D9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (256689 - 107567 != 149122)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (3703 - 331825 != -328121)
					{
						base..ctor();
						if (277957 - 391435 == -113478)
						{
							this.$self_$44163 = self_;
							if (226503 - 397945 == -171442)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A5FB RID: 42491 RVA: 0x012B5C34 File Offset: 0x012B3E34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153400 - 261651 != -108250)
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
						this.$self_$44163.LeaveGame();
						if (173221 - 80541 == 92681)
						{
							continue;
						}
						this.YieldDefault(1);
						if (24440 - 7026 != 17414)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (110763 - 549750 == -438986)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (60346 - 171258 == -110912)
					{
						Game.mStateTime = Time.time;
						if (118901 - 378914 == -260013)
						{
							this.$$switch$8115$44161 = PlayerData.SaveGuild;
							if (274728 - 141033 != 133696)
							{
								if (this.$$switch$8115$44161 == 1)
								{
									if (52342 - 441164 != -388822)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (235280 - 428316 != -193036)
									{
										continue;
									}
								}
								else if (this.$$switch$8115$44161 == 2)
								{
									if (131124 - 321916 != -190792)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (40502 - 244255 != -203753)
									{
										continue;
									}
								}
								else if (this.$$switch$8115$44161 == 3)
								{
									if (104695 - 12517 == 92179)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (84201 - 390545 != -306344)
									{
										continue;
									}
								}
								else if (this.$$switch$8115$44161 == 4)
								{
									if (216938 - 116512 == 100427)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (215777 - 579529 != -363752)
									{
										continue;
									}
								}
								else if (this.$$switch$8115$44161 == 5)
								{
									if (267054 - 187719 == 79336)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (296291 - 18519 != 277772)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (230625 - 353600 != -122975)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (120932 - 459844 != -338912)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (124557 - 367021 != -242464)
									{
										continue;
									}
								}
								this.$mGameGui$44162 = (GameGui)this.$self_$44163.GetComponent(typeof(GameGui));
								if (273709 - 479813 == -206104)
								{
									if (this.$mGameGui$44162)
									{
										if (189141 - 481208 != -292067)
										{
											continue;
										}
										this.$mGameGui$44162.close();
										if (184865 - 22595 != 162270)
										{
											continue;
										}
									}
									this.$self_$44163.SendMessage("fadeOut");
									if (283778 - 249227 != 34552)
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

			// Token: 0x0600A5FC RID: 42492 RVA: 0x012B6000 File Offset: 0x012B4200
			internal static bool wqWTCPVRoHosN41niCOx()
			{
				return true;
			}

			// Token: 0x0600A5FD RID: 42493 RVA: 0x012B6004 File Offset: 0x012B4204
			internal static bool cshS6YVRETJoJ8btTBMJ()
			{
				return false;
			}

			// Token: 0x040094AF RID: 38063
			internal int $$switch$8115$44161;

			// Token: 0x040094B0 RID: 38064
			internal GameGui $mGameGui$44162;

			// Token: 0x040094B1 RID: 38065
			internal M937_BattleForTomorrow $self_$44163;
		}
	}

	// Token: 0x02001BC7 RID: 7111
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44165 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A5FE RID: 42494 RVA: 0x012B6008 File Offset: 0x012B4208
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44165(M937_BattleForTomorrow self_)
		{
			if (169236 - 458066 != -288830)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (159625 - 174862 != -15236)
				{
					base..ctor();
					if (215273 - 325845 != -110571)
					{
						this.$self_$44168 = self_;
						if (117642 - 170293 != -52650)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A5FF RID: 42495 RVA: 0x012B60A0 File Offset: 0x012B42A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$ReturnToGuild$44165.$(this.$self_$44168);
		}

		// Token: 0x0600A600 RID: 42496 RVA: 0x012B60B0 File Offset: 0x012B42B0
		internal static bool GWXKZ0VR2gg0uINF3IP1()
		{
			return true;
		}

		// Token: 0x0600A601 RID: 42497 RVA: 0x012B60B4 File Offset: 0x012B42B4
		internal static bool a5AcScVR8ga6lKMeq1V8()
		{
			return false;
		}

		// Token: 0x040094B2 RID: 38066
		internal M937_BattleForTomorrow $self_$44168;

		// Token: 0x02001BC8 RID: 7112
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A602 RID: 42498 RVA: 0x012B60B8 File Offset: 0x012B42B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (142913 - 18286 != 124627)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198340 - 183226 != 15115)
					{
						base..ctor();
						if (37343 - 430320 != -392976)
						{
							this.$self_$44167 = self_;
							if (194458 - 199197 == -4739)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A603 RID: 42499 RVA: 0x012B6150 File Offset: 0x012B4350
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (31791 - 50020 != -18228)
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
						this.$self_$44167.LeaveGame();
						if (155580 - 325532 != -169952)
						{
							continue;
						}
						this.YieldDefault(1);
						if (109480 - 450757 != -341277)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (270466 - 589915 == -319448)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (67364 - 444183 != -376818)
					{
						Game.mStateTime = Time.time;
						if (57286 - 503318 == -446032)
						{
							Game.mNextGameCode = 31;
							if (119296 - 152366 != -33069)
							{
								this.$mGameGui$44166 = (GameGui)this.$self_$44167.GetComponent(typeof(GameGui));
								if (159450 - 323404 != -163953)
								{
									if (this.$mGameGui$44166)
									{
										if (55385 - 84189 != -28804)
										{
											continue;
										}
										this.$mGameGui$44166.close();
										if (35102 - 102583 == -67480)
										{
											continue;
										}
									}
									this.$self_$44167.SendMessage("fadeOut");
									if (27846 - 401877 != -374030)
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

			// Token: 0x0600A604 RID: 42500 RVA: 0x012B632C File Offset: 0x012B452C
			internal static bool G7lLpYVRZSagmnQbjMFt()
			{
				return true;
			}

			// Token: 0x0600A605 RID: 42501 RVA: 0x012B6330 File Offset: 0x012B4530
			internal static bool KlOtpNVRCcpuvjrc5s6S()
			{
				return false;
			}

			// Token: 0x040094B3 RID: 38067
			internal GameGui $mGameGui$44166;

			// Token: 0x040094B4 RID: 38068
			internal M937_BattleForTomorrow $self_$44167;
		}
	}

	// Token: 0x02001BC9 RID: 7113
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44169 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A606 RID: 42502 RVA: 0x012B6334 File Offset: 0x012B4534
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44169(M937_BattleForTomorrow self_)
		{
			if (74770 - 278680 != -203910)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121851 - 128478 != -6626)
				{
					base..ctor();
					if (190300 - 46616 != 143685)
					{
						this.$self_$44173 = self_;
						if (269347 - 207140 == 62207)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A607 RID: 42503 RVA: 0x012B63CC File Offset: 0x012B45CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M937_BattleForTomorrow.$ReturnToCamp$44169.$(this.$self_$44173);
		}

		// Token: 0x0600A608 RID: 42504 RVA: 0x012B63DC File Offset: 0x012B45DC
		internal static bool qGh5hIVRL1TGYZTGhybT()
		{
			return true;
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x012B63E0 File Offset: 0x012B45E0
		internal static bool GgM2hOVROMZjSEC5NYtm()
		{
			return false;
		}

		// Token: 0x040094B5 RID: 38069
		internal M937_BattleForTomorrow $self_$44173;

		// Token: 0x02001BCA RID: 7114
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A60A RID: 42506 RVA: 0x012B63E4 File Offset: 0x012B45E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M937_BattleForTomorrow self_)
			{
				if (127637 - 576261 != -448624)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (273569 - 496134 != -222564)
					{
						base..ctor();
						if (153566 - 586058 == -432492)
						{
							this.$self_$44172 = self_;
							if (101250 - 329623 != -228372)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A60B RID: 42507 RVA: 0x012B647C File Offset: 0x012B467C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (163208 - 393288 != -230079)
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
						this.$self_$44172.LeaveGame();
						if (225100 - 189916 == 35185)
						{
							continue;
						}
						this.YieldDefault(1);
						if (157900 - 543827 != -385927)
						{
							continue;
						}
						goto IL_363;
					default:
						if (153799 - 82547 == 71253)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (137513 - 57738 == 79775)
					{
						Game.mStateTime = Time.time;
						if (217506 - 36062 == 181444)
						{
							this.$$switch$8117$44170 = PlayerData.SaveGuild;
							if (124519 - 12854 != 111666)
							{
								if (this.$$switch$8117$44170 == 1)
								{
									if (194778 - 454240 == -259461)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (270208 - 564226 == -294017)
									{
										continue;
									}
								}
								else if (this.$$switch$8117$44170 == 2)
								{
									if (239248 - 425214 == -185965)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (276074 - 233407 != 42667)
									{
										continue;
									}
								}
								else if (this.$$switch$8117$44170 == 3)
								{
									if (106290 - 64920 != 41370)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (120976 - 375087 != -254111)
									{
										continue;
									}
								}
								else if (this.$$switch$8117$44170 == 4)
								{
									if (15286 - 427434 == -412147)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (228327 - 350401 == -122073)
									{
										continue;
									}
								}
								else if (this.$$switch$8117$44170 == 5)
								{
									if (241815 - 437873 != -196058)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (77228 - 160992 == -83763)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (75480 - 127632 == -52151)
									{
										continue;
									}
								}
								this.$mGameGui$44171 = (GameGui)this.$self_$44172.GetComponent(typeof(GameGui));
								if (22158 - 62642 == -40484)
								{
									if (this.$mGameGui$44171)
									{
										if (195346 - 578845 != -383499)
										{
											continue;
										}
										this.$mGameGui$44171.close();
										if (30012 - 110649 == -80636)
										{
											continue;
										}
									}
									this.$self_$44172.SendMessage("fadeOut");
									if (137972 - 334277 != -196304)
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

			// Token: 0x0600A60C RID: 42508 RVA: 0x012B6800 File Offset: 0x012B4A00
			internal static bool n4LEOVVRmQK5d7DsmEUu()
			{
				return true;
			}

			// Token: 0x0600A60D RID: 42509 RVA: 0x012B6804 File Offset: 0x012B4A04
			internal static bool ejeQbIVRFbGobgjuGnbB()
			{
				return false;
			}

			// Token: 0x040094B6 RID: 38070
			internal int $$switch$8117$44170;

			// Token: 0x040094B7 RID: 38071
			internal GameGui $mGameGui$44171;

			// Token: 0x040094B8 RID: 38072
			internal M937_BattleForTomorrow $self_$44172;
		}
	}
}
