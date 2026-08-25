using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020005D8 RID: 1496
[Serializable]
public class CatSkill : MonoBehaviour
{
	// Token: 0x060021E3 RID: 8675 RVA: 0x003DFA18 File Offset: 0x003DDC18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CatSkill()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x003DFA28 File Offset: 0x003DDC28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSkill(string skillname)
	{
		if (115454 - 582787 != -467332)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (73489 - 265706 == -192217)
			{
				if (58758 - 440899 == -382141)
				{
					if (skillname == "cat_nAttack1")
					{
						if (45636 - 26558 == 19079)
						{
							continue;
						}
						skillClass.setReq(1, 0);
						if (33014 - 413482 == -380467)
						{
							continue;
						}
					}
					else if (skillname == "cat_nAttack2")
					{
						if (29438 - 237204 == -207765)
						{
							continue;
						}
					}
					else if (skillname == "cat_nAttack3")
					{
						if (298770 - 383388 != -84618)
						{
							continue;
						}
						goto IL_26E1;
					}
					else if (skillname == "cat_nAttack4")
					{
						if (218933 - 251937 != -33003)
						{
							goto IL_146C;
						}
						continue;
					}
					else
					{
						if (skillname == "cat_cAttack1")
						{
							if (73194 - 510876 != -437682)
							{
								continue;
							}
							skillClass.setReq(4, 1);
							if (46911 - 443174 != -396263)
							{
								continue;
							}
							goto IL_1EC7;
						}
						else if (skillname == "cat_cAttack2")
						{
							if (91683 - 91669 != 14)
							{
								continue;
							}
							goto IL_1EC7;
						}
						else if (skillname == "cat_cAttack3")
						{
							if (239835 - 96774 != 143061)
							{
								continue;
							}
						}
						else
						{
							if (skillname == "cat_awareness1")
							{
								if (150280 - 505073 == -354792)
								{
									continue;
								}
								skillClass.setReq(6, 2);
								if (232052 - 409552 == -177499)
								{
									continue;
								}
								skillClass.setSP(-3);
								if (112472 - 440735 != -328263)
								{
									continue;
								}
							}
							else if (skillname == "cat_awareness2")
							{
								if (116634 - 557263 != -440629)
								{
									continue;
								}
							}
							else if (skillname == "cat_treasureHunt1")
							{
								if (17070 - 66391 == -49320)
								{
									continue;
								}
								skillClass.setReq(18, 6);
								if (81694 - 457240 != -375546)
								{
									continue;
								}
								skillClass.mode = eSkillMode.passive;
								if (10969 - 599993 != -589023)
								{
									break;
								}
								continue;
							}
							else
							{
								if (skillname == "cat_felineAgility1")
								{
									if (129948 - 309603 != -179655)
									{
										continue;
									}
									skillClass.setReq(8, 4);
									if (238906 - 432364 != -193458)
									{
										continue;
									}
									goto IL_21FC;
								}
								else if (skillname == "cat_felineAgility2")
								{
									if (16030 - 98122 != -82092)
									{
										continue;
									}
									goto IL_21FC;
								}
								else if (skillname == "cat_felineAgility3")
								{
									if (135664 - 77816 != 57848)
									{
										continue;
									}
									goto IL_2AE4;
								}
								else if (skillname == "cat_felineAgility4")
								{
									if (233625 - 553548 == -319922)
									{
										continue;
									}
								}
								else
								{
									if (skillname == "cat_statPlus1")
									{
										if (179233 - 56255 == 122979)
										{
											continue;
										}
										skillClass.setReq(10, 4);
										if (157785 - 337214 != -179428)
										{
											goto IL_2D97;
										}
										continue;
									}
									else if (skillname == "cat_statPlus2")
									{
										if (247814 - 266287 != -18473)
										{
											continue;
										}
										goto IL_2D97;
									}
									else if (skillname == "cat_statPlus3")
									{
										if (105486 - 322513 != -217027)
										{
											continue;
										}
										goto IL_33C8;
									}
									else if (skillname == "cat_statPlus4")
									{
										if (139405 - 420527 == -281121)
										{
											continue;
										}
									}
									else
									{
										if (skillname == "cat_luckyCard1")
										{
											if (16769 - 289269 != -272500)
											{
												continue;
											}
											skillClass.setReq(3, 0);
											if (148882 - 24908 == 123975)
											{
												continue;
											}
											skillClass.setMPSP(2, 5);
											if (5597 - 84789 == -79191)
											{
												continue;
											}
										}
										else if (skillname == "cat_luckyCard2")
										{
											if (253637 - 549642 == -296004)
											{
												continue;
											}
										}
										else if (skillname == "cat_luckyCard3")
										{
											if (95050 - 33609 != 61441)
											{
												continue;
											}
											goto IL_2240;
										}
										else if (skillname == "cat_luckyCard4")
										{
											if (194724 - 133004 != 61721)
											{
												goto IL_2703;
											}
											continue;
										}
										else
										{
											if (skillname == "cat_fateDraw1")
											{
												if (164986 - 55973 != 109013)
												{
													continue;
												}
												skillClass.setReq(5, 1);
												if (56969 - 568075 == -511105)
												{
													continue;
												}
												skillClass.setMP(4);
												if (3164 - 511034 != -507870)
												{
													continue;
												}
												goto IL_2922;
											}
											else if (skillname == "cat_fateDraw2")
											{
												if (5676 - 367512 != -361835)
												{
													goto IL_2922;
												}
												continue;
											}
											else if (skillname == "cat_fateDraw3")
											{
												if (124999 - 358315 != -233316)
												{
													continue;
												}
											}
											else if (skillname == "cat_fateDraw4")
											{
												if (26904 - 312644 != -285740)
												{
													continue;
												}
												goto IL_16C7;
											}
											else
											{
												if (skillname == "cat_powerShuffle1")
												{
													if (104348 - 192767 == -88418)
													{
														continue;
													}
													skillClass.setReq(7, 2);
													if (297676 - 596885 != -299209)
													{
														continue;
													}
													skillClass.setSP(-5);
													if (205484 - 270361 == -64876)
													{
														continue;
													}
												}
												else if (skillname == "cat_powerShuffle2")
												{
													if (167423 - 534902 != -367479)
													{
														continue;
													}
												}
												else if (skillname == "cat_lifeGamble1")
												{
													if (64812 - 157226 == -92413)
													{
														continue;
													}
													skillClass.setReq(19, 6);
													if (86461 - 25795 != 60666)
													{
														continue;
													}
													skillClass.setMP(5);
													if (85333 - 147585 != -62252)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (93938 - 344689 == -250750)
													{
														continue;
													}
													skillClass.target = eSkillTarget.self;
													if (8306 - 72586 == -64279)
													{
														continue;
													}
													skillClass.cType = "lifeGamble";
													if (158743 - 122824 != 35920)
													{
														break;
													}
													continue;
												}
												else if (skillname == "cat_skillGamble2")
												{
													if (191759 - 323551 != -131792)
													{
														continue;
													}
													skillClass.setReq(25, 8);
													if (235697 - 282622 != -46925)
													{
														continue;
													}
													skillClass.setSP(5);
													if (121534 - 397139 != -275605)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (139806 - 443736 == -303929)
													{
														continue;
													}
													skillClass.target = eSkillTarget.self;
													if (18534 - 42181 != -23647)
													{
														continue;
													}
													skillClass.cType = "skillGamble";
													if (116528 - 550331 != -433802)
													{
														break;
													}
													continue;
												}
												else
												{
													if (skillname == "cat_luckyDice1")
													{
														if (107305 - 433608 == -326302)
														{
															continue;
														}
														skillClass.setReq(9, 3);
														if (74130 - 558978 == -484847)
														{
															continue;
														}
														skillClass.setMPSP(8, -12);
														if (40311 - 31102 == 9210)
														{
															continue;
														}
													}
													else if (skillname == "cat_luckyDice2")
													{
														if (261357 - 478602 == -217244)
														{
															continue;
														}
													}
													else
													{
														if (skillname == "cat_doubleDown1")
														{
															if (109086 - 421960 == -312873)
															{
																continue;
															}
															skillClass.setReq(21, 7);
															if (79587 - 409850 != -330263)
															{
																continue;
															}
															skillClass.setMPSP(16, -20);
															if (26438 - 17296 == 9143)
															{
																continue;
															}
														}
														else if (skillname == "cat_doubleDown2")
														{
															if (131481 - 64818 == 66664)
															{
																continue;
															}
														}
														else
														{
															if (skillname == "cat_powerOne1")
															{
																if (32416 - 25420 == 6997)
																{
																	continue;
																}
																skillClass.setReq(16, 4);
																if (101057 - 14710 != 86348)
																{
																	goto IL_16A4;
																}
																continue;
															}
															else if (skillname == "cat_powerTwo2")
															{
																if (63140 - 304664 != -241524)
																{
																	continue;
																}
																goto IL_16A4;
															}
															else if (skillname == "cat_powerThree3")
															{
																if (254342 - 586440 != -332098)
																{
																	continue;
																}
																goto IL_ACA;
															}
															else if (skillname == "cat_powerSeven4")
															{
																if (55300 - 460641 != -405341)
																{
																	continue;
																}
															}
															else
															{
																if (skillname == "cat_twoPair1")
																{
																	if (5314 - 179887 == -174572)
																	{
																		continue;
																	}
																	skillClass.setReq(20, 12);
																	if (109667 - 74207 == 35461)
																	{
																		continue;
																	}
																	skillClass.setSP(12);
																	if (144844 - 332946 == -188101)
																	{
																		continue;
																	}
																}
																else if (skillname == "cat_twoPair2")
																{
																	if (72841 - 322243 != -249402)
																	{
																		continue;
																	}
																}
																else
																{
																	if (skillname == "cat_copycat1")
																	{
																		if (249223 - 154423 != 94800)
																		{
																			continue;
																		}
																		skillClass.setReq(28, 18);
																		if (171970 - 64265 == 107706)
																		{
																			continue;
																		}
																		skillClass.setMP(18);
																		if (157349 - 545455 == -388105)
																		{
																			continue;
																		}
																	}
																	else if (skillname == "cat_copycat2")
																	{
																		if (169343 - 136592 != 32751)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (skillname == "cat_damageRoulette1")
																		{
																			if (17899 - 279998 == -262098)
																			{
																				continue;
																			}
																			skillClass.setReq(24, 15);
																			if (14790 - 114680 != -99890)
																			{
																				continue;
																			}
																			skillClass.setMPSP(12, -12);
																			if (90949 - 426775 != -335826)
																			{
																				continue;
																			}
																		}
																		else if (skillname == "cat_damageRoulette2")
																		{
																			if (154960 - 98779 != 56181)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (skillname == "cat_nineLives1")
																			{
																				if (164245 - 36308 == 127938)
																				{
																					continue;
																				}
																				skillClass.setReq(30, 21);
																				if (75449 - 330794 == -255344)
																				{
																					continue;
																				}
																			}
																			else if (skillname == "cat_nineLives2")
																			{
																				if (188994 - 563090 == -374095)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				if (skillname == "cat_grandCasinoArcade1")
																				{
																					if (21900 - 424879 == -402978)
																					{
																						continue;
																					}
																					skillClass.setReq(35, 23);
																					if (133015 - 528785 != -395770)
																					{
																						continue;
																					}
																					skillClass.setMPSP(30, -55);
																					if (292683 - 313520 == -20836)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "cat_grandCasinoArcade2")
																				{
																					if (249973 - 82581 != 167392)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					if (skillname == "cat_flyingDagger1")
																					{
																						if (230701 - 132418 != 98283)
																						{
																							continue;
																						}
																						skillClass.setReq(3, 0);
																						if (219409 - 348559 == -129149)
																						{
																							continue;
																						}
																						skillClass.setSP(10);
																						if (14852 - 226437 == -211584)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "cat_flyingDagger2")
																					{
																						if (76605 - 95934 == -19328)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "cat_flyingDagger3")
																					{
																						if (282098 - 485779 != -203680)
																						{
																							goto IL_24FB;
																						}
																						continue;
																					}
																					else if (skillname == "cat_flyingDagger4")
																					{
																						if (272773 - 523485 != -250712)
																						{
																							continue;
																						}
																						goto IL_3765;
																					}
																					else
																					{
																						if (skillname == "cat_forwardLunge1")
																						{
																							if (56173 - 218216 != -162043)
																							{
																								continue;
																							}
																							skillClass.setReq(5, 1);
																							if (62466 - 229217 != -166751)
																							{
																								continue;
																							}
																							skillClass.setSP(-15);
																							if (189831 - 536345 != -346514)
																							{
																								continue;
																							}
																						}
																						else if (skillname == "cat_forwardLunge2")
																						{
																							if (150608 - 476333 != -325725)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							if (skillname == "cat_reverseThrust1")
																							{
																								if (211617 - 46428 != 165189)
																								{
																									continue;
																								}
																								skillClass.setReq(11, 3);
																								if (198563 - 435501 == -236937)
																								{
																									continue;
																								}
																								skillClass.setSP(-16);
																								if (123107 - 165187 != -42080)
																								{
																									continue;
																								}
																							}
																							else if (skillname == "cat_reverseThrust2")
																							{
																								if (423 - 7351 == -6927)
																								{
																									continue;
																								}
																							}
																							else
																							{
																								if (skillname == "cat_backflip1")
																								{
																									if (96031 - 538301 == -442269)
																									{
																										continue;
																									}
																									skillClass.setReq(7, 2);
																									if (202925 - 261518 == -58592)
																									{
																										continue;
																									}
																									skillClass.setSP(-3);
																									if (9410 - 546180 != -536770)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "cat_backflip2")
																								{
																									if (218985 - 332094 == -113108)
																									{
																										continue;
																									}
																								}
																								else
																								{
																									if (skillname == "cat_heartRipper1")
																									{
																										if (187258 - 271939 == -84680)
																										{
																											continue;
																										}
																										skillClass.setReq(19, 6);
																										if (261983 - 65173 != 196810)
																										{
																											continue;
																										}
																										skillClass.setSP(-3);
																										if (144586 - 518879 == -374292)
																										{
																											continue;
																										}
																									}
																									else if (skillname == "cat_heartRipper2")
																									{
																										if (121432 - 55370 != 66062)
																										{
																											continue;
																										}
																									}
																									else
																									{
																										if (skillname == "cat_hiddenBlade1")
																										{
																											if (215400 - 582066 == -366665)
																											{
																												continue;
																											}
																											skillClass.setReq(9, 3);
																											if (58350 - 565650 != -507299)
																											{
																												goto IL_1CDE;
																											}
																											continue;
																										}
																										else if (skillname == "cat_hiddenBlade2")
																										{
																											if (90940 - 99615 != -8675)
																											{
																												continue;
																											}
																											goto IL_1CDE;
																										}
																										else if (skillname == "cat_hiddenBlade3")
																										{
																											if (140814 - 413456 != -272641)
																											{
																												goto IL_22DC;
																											}
																											continue;
																										}
																										else if (skillname == "cat_hiddenBlade4")
																										{
																											if (163818 - 68835 == 94984)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											if (skillname == "cat_disarm1")
																											{
																												if (237203 - 313779 == -76575)
																												{
																													continue;
																												}
																												skillClass.setReq(16, 4);
																												if (54122 - 401514 == -347391)
																												{
																													continue;
																												}
																												skillClass.setSP(18);
																												if (250452 - 305174 == -54721)
																												{
																													continue;
																												}
																											}
																											else if (skillname == "cat_disarm2")
																											{
																												if (193453 - 412717 != -219264)
																												{
																													continue;
																												}
																											}
																											else
																											{
																												if (skillname == "cat_bleed1")
																												{
																													if (26398 - 41015 == -14616)
																													{
																														continue;
																													}
																													skillClass.setReq(24, 12);
																													if (192468 - 309461 == -116992)
																													{
																														continue;
																													}
																													skillClass.setMPSP(14, 18);
																													if (54823 - 227093 == -172269)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "cat_bleed2")
																												{
																													if (146963 - 38209 != 108754)
																													{
																														continue;
																													}
																												}
																												else
																												{
																													if (skillname == "cat_moonBlade1")
																													{
																														if (135279 - 325710 == -190430)
																														{
																															continue;
																														}
																														skillClass.setReq(20, 12);
																														if (182602 - 252946 == -70343)
																														{
																															continue;
																														}
																														skillClass.setMPSP(10, -20);
																														if (163451 - 301388 == -137936)
																														{
																															continue;
																														}
																													}
																													else if (skillname == "cat_moonBlade2")
																													{
																														if (99334 - 24974 != 74360)
																														{
																															continue;
																														}
																													}
																													else
																													{
																														if (skillname == "cat_moonStorm1")
																														{
																															if (117539 - 431555 != -314016)
																															{
																																continue;
																															}
																															skillClass.setReq(28, 18);
																															if (246436 - 491586 != -245150)
																															{
																																continue;
																															}
																															skillClass.setMPSP(20, -30);
																															if (101177 - 492849 == -391671)
																															{
																																continue;
																															}
																														}
																														else if (skillname == "cat_moonStorm2")
																														{
																															if (137843 - 355119 != -217276)
																															{
																																continue;
																															}
																														}
																														else
																														{
																															if (skillname == "cat_evasion1")
																															{
																																if (149092 - 88215 == 60878)
																																{
																																	continue;
																																}
																																skillClass.setReq(24, 15);
																																if (20831 - 380244 != -359412)
																																{
																																	goto IL_15B3;
																																}
																																continue;
																															}
																															else if (skillname == "cat_evasion2")
																															{
																																if (158471 - 380145 != -221674)
																																{
																																	continue;
																																}
																																goto IL_15B3;
																															}
																															else if (skillname == "cat_evasion3")
																															{
																																if (26580 - 265693 != -239113)
																																{
																																	continue;
																																}
																																goto IL_E21;
																															}
																															else if (skillname == "cat_vendetta1")
																															{
																																if (144619 - 430533 != -285914)
																																{
																																	continue;
																																}
																															}
																															else
																															{
																																if (skillname == "cat_deltaStrike1")
																																{
																																	if (107722 - 74450 == 33273)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(35, 23);
																																	if (191043 - 365215 != -174172)
																																	{
																																		continue;
																																	}
																																	skillClass.setMPSP(30, -45);
																																	if (178096 - 13004 != 165092)
																																	{
																																		continue;
																																	}
																																}
																																else if (skillname == "cat_deltaStrike2")
																																{
																																	if (71291 - 235476 == -164184)
																																	{
																																		continue;
																																	}
																																}
																																else if (skillname == "cat_noChance5")
																																{
																																	if (64969 - 82291 != -17322)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(55, 0);
																																	if (51586 - 367693 == -316106)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (26503 - 41330 == -14826)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 103;
																																	if (197615 - 191651 != 5964)
																																	{
																																		continue;
																																	}
																																	break;
																																}
																																else if (skillname == "cat_doubleFocus5")
																																{
																																	if (225801 - 239296 == -13494)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(60, 1);
																																	if (104230 - 528170 == -423939)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (273822 - 138501 == 135322)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 113;
																																	if (79939 - 525241 != -445301)
																																	{
																																		break;
																																	}
																																	continue;
																																}
																																else if (skillname == "cat_insight5")
																																{
																																	if (274670 - 54999 == 219672)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(70, 3);
																																	if (170900 - 261684 == -90783)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (283872 - 478931 != -195059)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 123;
																																	if (39418 - 123785 != -84367)
																																	{
																																		continue;
																																	}
																																	break;
																																}
																																else if (skillname == "cat_swiftPace5")
																																{
																																	if (57998 - 21464 == 36535)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(75, 4);
																																	if (139606 - 430186 != -290580)
																																	{
																																		continue;
																																	}
																																	skillClass.setSP(-10);
																																	if (427 - 294822 != -294395)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.target;
																																	if (194227 - 186831 != 7396)
																																	{
																																		continue;
																																	}
																																	skillClass.target = eSkillTarget.enemy;
																																	if (8274 - 186513 == -178238)
																																	{
																																		continue;
																																	}
																																	skillClass.cType = "swiftPace";
																																	if (6882 - 297879 != -290997)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 134;
																																	if (46467 - 507352 != -460885)
																																	{
																																		continue;
																																	}
																																	break;
																																}
																																else if (skillname == "cat_superStatPlus5")
																																{
																																	if (202007 - 445215 == -243207)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(85, 6);
																																	if (88886 - 559874 != -470988)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (28057 - 341926 != -313869)
																																	{
																																		continue;
																																	}
																																	skillClass.target = eSkillTarget.self;
																																	if (69438 - 385778 == -316339)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 144;
																																	if (196664 - 347902 != -151237)
																																	{
																																		break;
																																	}
																																	continue;
																																}
																																else if (skillname == "cat_joker5")
																																{
																																	if (82506 - 265960 != -183454)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(55, 0);
																																	if (226184 - 431801 == -205616)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (161805 - 221499 == -59693)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 204;
																																	if (136767 - 243755 != -106987)
																																	{
																																		break;
																																	}
																																	continue;
																																}
																																else if (skillname == "cat_ladyLuck5")
																																{
																																	if (238121 - 55566 == 182556)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(60, 1);
																																	if (224719 - 540143 == -315423)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (196907 - 7211 == 189697)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 214;
																																	if (212292 - 84946 != 127347)
																																	{
																																		break;
																																	}
																																	continue;
																																}
																																else if (skillname == "cat_evenOdds5")
																																{
																																	if (158786 - 270971 != -112185)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(70, 3);
																																	if (203736 - 490584 != -286848)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (269682 - 365980 == -96297)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 224;
																																	if (123203 - 319700 != -196497)
																																	{
																																		continue;
																																	}
																																	break;
																																}
																																else if (skillname == "cat_rollTheDice5")
																																{
																																	if (75722 - 133031 == -57308)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(75, 4);
																																	if (234636 - 241280 != -6644)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (717 - 4399 == -3681)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 234;
																																	if (123228 - 335102 != -211874)
																																	{
																																		continue;
																																	}
																																	break;
																																}
																																else if (skillname == "cat_superSeven5")
																																{
																																	if (196514 - 568470 != -371956)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(85, 6);
																																	if (150918 - 405815 != -254897)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (63065 - 563009 == -499943)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 244;
																																	if (24634 - 390493 != -365858)
																																	{
																																		break;
																																	}
																																	continue;
																																}
																																else if (skillname == "cat_threeKnives5")
																																{
																																	if (281071 - 489835 != -208764)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(55, 0);
																																	if (216831 - 372160 != -155329)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (4249 - 314584 != -310335)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 304;
																																	if (1275 - 8025 != -6749)
																																	{
																																		break;
																																	}
																																	continue;
																																}
																																else if (skillname == "cat_backstab5")
																																{
																																	if (276721 - 206880 == 69842)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(60, 1);
																																	if (268429 - 65979 == 202451)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (261527 - 150001 == 111527)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 314;
																																	if (178335 - 62575 != 115761)
																																	{
																																		break;
																																	}
																																	continue;
																																}
																																else if (skillname == "cat_finishingBlow5")
																																{
																																	if (43378 - 492609 == -449230)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(70, 3);
																																	if (17226 - 23778 == -6551)
																																	{
																																		continue;
																																	}
																																	skillClass.setMPSP(20, -45);
																																	if (231649 - 191761 != 39888)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.target;
																																	if (299861 - 221283 == 78579)
																																	{
																																		continue;
																																	}
																																	skillClass.target = eSkillTarget.enemy;
																																	if (191603 - 193701 != -2098)
																																	{
																																		continue;
																																	}
																																	skillClass.cType = "heartRipper";
																																	if (104292 - 582216 == -477923)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 324;
																																	if (89824 - 533148 != -443324)
																																	{
																																		continue;
																																	}
																																	break;
																																}
																																else if (skillname == "cat_jaggedKnife5")
																																{
																																	if (91289 - 122533 == -31243)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(75, 4);
																																	if (275306 - 342426 == -67119)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (266961 - 238639 != 28322)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 334;
																																	if (214280 - 77143 != 137138)
																																	{
																																		break;
																																	}
																																	continue;
																																}
																																else if (skillname == "cat_openWound5")
																																{
																																	if (174610 - 569645 != -395035)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(85, 6);
																																	if (17170 - 365562 != -348392)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (190925 - 361800 == -170874)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 344;
																																	if (95275 - 338228 != -242953)
																																	{
																																		continue;
																																	}
																																	break;
																																}
																																else if (skillname == "cat_revisedSkill5")
																																{
																																	if (30740 - 79384 != -48644)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(55, 0);
																																	if (23205 - 492679 != -469474)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (233471 - 446392 != -212920)
																																	{
																																		break;
																																	}
																																	continue;
																																}
																																else if (skillname == "cat_revisedMagic5")
																																{
																																	if (276274 - 584821 != -308547)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(60, 1);
																																	if (282356 - 44131 != 238225)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (49004 - 196899 != -147895)
																																	{
																																		continue;
																																	}
																																	break;
																																}
																																else if (skillname == "cat_revisedArt5")
																																{
																																	if (192035 - 1678 != 190357)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(70, 3);
																																	if (94600 - 12989 == 81612)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.passive;
																																	if (189845 - 149792 != 40053)
																																	{
																																		continue;
																																	}
																																	break;
																																}
																																else if (skillname == "cat_pillagePlunge5")
																																{
																																	if (141247 - 510003 == -368755)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(75, 4);
																																	if (263926 - 510721 != -246795)
																																	{
																																		continue;
																																	}
																																	skillClass.setMPSP(15, -30);
																																	if (211475 - 544075 != -332600)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.instant;
																																	if (294931 - 531667 == -236735)
																																	{
																																		continue;
																																	}
																																	skillClass.target = eSkillTarget.enemy;
																																	if (224461 - 82475 == 141987)
																																	{
																																		continue;
																																	}
																																	skillClass.cType = "pillagePlunge";
																																	if (47275 - 463594 == -416318)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 251351;
																																	if (28932 - 326348 != -297415)
																																	{
																																		break;
																																	}
																																	continue;
																																}
																																else
																																{
																																	if (!(skillname == "cat_supportFire5"))
																																	{
																																		break;
																																	}
																																	if (52506 - 427014 == -374507)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(85, 6);
																																	if (59622 - 260672 != -201050)
																																	{
																																		continue;
																																	}
																																	skillClass.setMPSP(60, 60);
																																	if (81542 - 269539 == -187996)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.instant;
																																	if (282690 - 66719 != 215971)
																																	{
																																		continue;
																																	}
																																	skillClass.target = eSkillTarget.enemy;
																																	if (182063 - 449255 == -267191)
																																	{
																																		continue;
																																	}
																																	skillClass.cType = "supportFire";
																																	if (112588 - 58934 == 53655)
																																	{
																																		continue;
																																	}
																																	skillClass.rSkill = 434;
																																	if (46782 - 518749 != -471967)
																																	{
																																		continue;
																																	}
																																	break;
																																}
																																skillClass.setReq(40, 25);
																																if (240972 - 223302 == 17671)
																																{
																																	continue;
																																}
																																skillClass.setMPSP(30, -60);
																																if (40547 - 541810 != -501263)
																																{
																																	continue;
																																}
																																skillClass.mode = eSkillMode.instant;
																																if (116294 - 329096 != -212802)
																																{
																																	continue;
																																}
																																skillClass.target = eSkillTarget.enemy;
																																if (112032 - 515167 == -403134)
																																{
																																	continue;
																																}
																																skillClass.cType = "deltaStrike";
																																if (268204 - 274560 != -6355)
																																{
																																	break;
																																}
																																continue;
																															}
																															IL_D64:
																															skillClass.setReq(33, 24);
																															if (257889 - 534252 == -276362)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (106219 - 3380 != 102839)
																															{
																																continue;
																															}
																															break;
																															IL_E21:
																															skillClass.setReq(30, 21);
																															if (45983 - 162510 != -116526)
																															{
																																goto IL_D64;
																															}
																															continue;
																															IL_15B3:
																															skillClass.setReq(27, 18);
																															if (170502 - 456034 != -285532)
																															{
																																continue;
																															}
																															goto IL_E21;
																														}
																														skillClass.setReq(32, 21);
																														if (15755 - 290541 == -274785)
																														{
																															continue;
																														}
																														skillClass.setMPSP(20, -40);
																														if (75184 - 457684 != -382500)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.instant;
																														if (267337 - 538303 == -270965)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.enemy;
																														if (231962 - 89348 == 142615)
																														{
																															continue;
																														}
																														skillClass.cType = "moonStorm";
																														if (238999 - 317239 != -78240)
																														{
																															continue;
																														}
																														break;
																													}
																													skillClass.setReq(24, 15);
																													if (84628 - 5688 == 78941)
																													{
																														continue;
																													}
																													skillClass.setMPSP(10, -25);
																													if (47605 - 512563 == -464957)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.instant;
																													if (163151 - 220936 != -57785)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.enemy;
																													if (174845 - 507831 == -332985)
																													{
																														continue;
																													}
																													skillClass.cType = "moonBlade";
																													if (46871 - 111749 != -64878)
																													{
																														continue;
																													}
																													break;
																												}
																												skillClass.setReq(28, 16);
																												if (281076 - 501875 == -220798)
																												{
																													continue;
																												}
																												skillClass.setMPSP(20, 24);
																												if (218534 - 311469 != -92935)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.target;
																												if (231596 - 381235 == -149638)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.enemy;
																												if (181290 - 206972 == -25681)
																												{
																													continue;
																												}
																												skillClass.cType = "bleed";
																												if (30598 - 62845 != -32247)
																												{
																													continue;
																												}
																												break;
																											}
																											skillClass.setReq(20, 8);
																											if (223951 - 449370 != -225419)
																											{
																												continue;
																											}
																											skillClass.setSP(24);
																											if (189133 - 467056 != -277923)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.target;
																											if (122598 - 560497 != -437899)
																											{
																												continue;
																											}
																											skillClass.target = eSkillTarget.enemy;
																											if (196190 - 146045 == 50146)
																											{
																												continue;
																											}
																											skillClass.cType = "disarm";
																											if (26377 - 534879 != -508502)
																											{
																												continue;
																											}
																											break;
																										}
																										IL_106F:
																										skillClass.setReq(27, 9);
																										if (49872 - 573743 != -523871)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.passive;
																										if (294976 - 392626 != -97649)
																										{
																											break;
																										}
																										continue;
																										IL_1CDE:
																										skillClass.setReq(15, 5);
																										if (274971 - 279714 == -4742)
																										{
																											continue;
																										}
																										IL_22DC:
																										skillClass.setReq(21, 7);
																										if (171536 - 377431 != -205894)
																										{
																											goto IL_106F;
																										}
																										continue;
																									}
																									skillClass.setReq(25, 8);
																									if (196262 - 139320 != 56942)
																									{
																										continue;
																									}
																									skillClass.setSP(-5);
																									if (297315 - 326408 != -29093)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.target;
																									if (24205 - 159542 == -135336)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.enemy;
																									if (186696 - 425659 != -238963)
																									{
																										continue;
																									}
																									skillClass.cType = "heartRipper";
																									if (121751 - 290267 != -168515)
																									{
																										break;
																									}
																									continue;
																								}
																								skillClass.setReq(13, 4);
																								if (100800 - 67996 == 32805)
																								{
																									continue;
																								}
																								skillClass.setSP(-5);
																								if (284841 - 312047 == -27205)
																								{
																									continue;
																								}
																								skillClass.mode = eSkillMode.instant;
																								if (225009 - 416876 != -191867)
																								{
																									continue;
																								}
																								skillClass.target = eSkillTarget.self;
																								if (220371 - 257150 == -36778)
																								{
																									continue;
																								}
																								skillClass.cType = "backflip";
																								if (118880 - 445408 != -326527)
																								{
																									break;
																								}
																								continue;
																							}
																							skillClass.setReq(23, 7);
																							if (79020 - 393151 != -314131)
																							{
																								continue;
																							}
																							skillClass.setSP(-20);
																							if (177264 - 386374 != -209110)
																							{
																								continue;
																							}
																							skillClass.mode = eSkillMode.instant;
																							if (152894 - 24261 != 128633)
																							{
																								continue;
																							}
																							skillClass.target = eSkillTarget.enemy;
																							if (115836 - 75555 == 40282)
																							{
																								continue;
																							}
																							skillClass.cType = "reverseThrust";
																							if (63062 - 337859 != -274797)
																							{
																								continue;
																							}
																							break;
																						}
																						skillClass.setReq(17, 5);
																						if (59427 - 349972 != -290545)
																						{
																							continue;
																						}
																						skillClass.setSP(-18);
																						if (45885 - 385848 != -339963)
																						{
																							continue;
																						}
																						skillClass.mode = eSkillMode.instant;
																						if (210091 - 400848 != -190757)
																						{
																							continue;
																						}
																						skillClass.target = eSkillTarget.enemy;
																						if (218298 - 114758 == 103541)
																						{
																							continue;
																						}
																						skillClass.cType = "forwardLunge";
																						if (183871 - 242994 != -59123)
																						{
																							continue;
																						}
																						break;
																					}
																					skillClass.setReq(9, 1);
																					if (95954 - 536616 != -440662)
																					{
																						continue;
																					}
																					skillClass.setSP(14);
																					if (2378 - 224566 != -222188)
																					{
																						continue;
																					}
																					IL_24FB:
																					skillClass.setReq(15, 2);
																					if (124213 - 193421 == -69207)
																					{
																						continue;
																					}
																					skillClass.setSP(18);
																					if (110509 - 453906 != -343397)
																					{
																						continue;
																					}
																					IL_3765:
																					skillClass.setReq(21, 3);
																					if (178387 - 188993 == -10605)
																					{
																						continue;
																					}
																					skillClass.setSP(22);
																					if (193310 - 580655 == -387344)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.target;
																					if (269439 - 550363 != -280924)
																					{
																						continue;
																					}
																					skillClass.target = eSkillTarget.enemy;
																					if (82378 - 457338 != -374960)
																					{
																						continue;
																					}
																					skillClass.cType = "flyingDagger";
																					if (22906 - 27504 != -4598)
																					{
																						continue;
																					}
																					break;
																				}
																				skillClass.setReq(40, 25);
																				if (41561 - 330902 != -289341)
																				{
																					continue;
																				}
																				skillClass.setMPSP(50, -75);
																				if (53719 - 424945 == -371225)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.instant;
																				if (295237 - 258452 == 36786)
																				{
																					continue;
																				}
																				skillClass.target = eSkillTarget.enemy;
																				if (153429 - 12126 != 141303)
																				{
																					continue;
																				}
																				skillClass.cType = "grandCasinoArcade";
																				if (10540 - 533392 != -522851)
																				{
																					break;
																				}
																				continue;
																			}
																			skillClass.setReq(33, 24);
																			if (294950 - 261025 == 33926)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.passive;
																			if (200397 - 503297 != -302900)
																			{
																				continue;
																			}
																			break;
																		}
																		skillClass.setReq(27, 18);
																		if (73205 - 243000 == -169794)
																		{
																			continue;
																		}
																		skillClass.setMPSP(15, -15);
																		if (252496 - 202218 == 50279)
																		{
																			continue;
																		}
																		skillClass.mode = eSkillMode.instant;
																		if (213926 - 500181 == -286254)
																		{
																			continue;
																		}
																		skillClass.target = eSkillTarget.self;
																		if (16599 - 524488 != -507889)
																		{
																			continue;
																		}
																		skillClass.cType = "damageRoulette";
																		if (281901 - 407811 != -125909)
																		{
																			break;
																		}
																		continue;
																	}
																	skillClass.setReq(32, 21);
																	if (21983 - 333833 == -311849)
																	{
																		continue;
																	}
																	skillClass.setMP(24);
																	if (279762 - 558713 != -278951)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.target;
																	if (208770 - 310654 == -101883)
																	{
																		continue;
																	}
																	skillClass.target = eSkillTarget.enemy;
																	if (54019 - 397687 == -343667)
																	{
																		continue;
																	}
																	skillClass.cType = "copycat";
																	if (115005 - 322701 != -207695)
																	{
																		break;
																	}
																	continue;
																}
																skillClass.setReq(24, 15);
																if (104287 - 83875 == 20413)
																{
																	continue;
																}
																skillClass.setSP(18);
																if (29978 - 416191 == -386212)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.target;
																if (271157 - 210719 != 60438)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.all;
																if (36119 - 526258 == -490138)
																{
																	continue;
																}
																skillClass.cType = "twoPair";
																if (153529 - 33745 != 119784)
																{
																	continue;
																}
																break;
															}
															IL_69A:
															skillClass.setReq(28, 16);
															if (246642 - 295691 == -49048)
															{
																continue;
															}
															skillClass.mode = eSkillMode.passive;
															if (69205 - 203449 != -134244)
															{
																continue;
															}
															break;
															IL_ACA:
															skillClass.setReq(24, 12);
															if (57840 - 392699 != -334858)
															{
																goto IL_69A;
															}
															continue;
															IL_16A4:
															skillClass.setReq(20, 8);
															if (227180 - 598368 != -371188)
															{
																continue;
															}
															goto IL_ACA;
														}
														skillClass.setReq(27, 9);
														if (197091 - 182402 == 14690)
														{
															continue;
														}
														skillClass.setMPSP(20, -24);
														if (141648 - 400198 == -258549)
														{
															continue;
														}
														skillClass.mode = eSkillMode.instant;
														if (43421 - 378031 == -334609)
														{
															continue;
														}
														skillClass.target = eSkillTarget.enemy;
														if (103181 - 39720 == 63462)
														{
															continue;
														}
														skillClass.cType = "doubleDown";
														if (168548 - 423494 != -254946)
														{
															continue;
														}
														break;
													}
													skillClass.setReq(15, 5);
													if (239513 - 75703 != 163810)
													{
														continue;
													}
													skillClass.setMPSP(12, -16);
													if (110597 - 314678 == -204080)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (185432 - 458264 != -272832)
													{
														continue;
													}
													skillClass.target = eSkillTarget.enemy;
													if (286498 - 319269 == -32770)
													{
														continue;
													}
													skillClass.cType = "luckyDice";
													if (26219 - 129289 != -103069)
													{
														break;
													}
													continue;
												}
												skillClass.setReq(13, 4);
												if (253593 - 391819 == -138225)
												{
													continue;
												}
												skillClass.setSP(-10);
												if (28870 - 569135 != -540265)
												{
													continue;
												}
												skillClass.mode = eSkillMode.instant;
												if (177602 - 360859 == -183256)
												{
													continue;
												}
												skillClass.target = eSkillTarget.self;
												if (25010 - 554591 != -529581)
												{
													continue;
												}
												skillClass.cType = "powerShuffle";
												if (60685 - 363905 != -303220)
												{
													continue;
												}
												break;
											}
											IL_D88:
											skillClass.setReq(17, 5);
											if (48764 - 38892 != 9872)
											{
												continue;
											}
											skillClass.setMP(8);
											if (180473 - 201962 != -21489)
											{
												continue;
											}
											IL_16C7:
											skillClass.setReq(23, 7);
											if (95705 - 557780 != -462075)
											{
												continue;
											}
											skillClass.setMP(10);
											if (116657 - 249900 == -133242)
											{
												continue;
											}
											skillClass.mode = eSkillMode.instant;
											if (86086 - 177087 == -91000)
											{
												continue;
											}
											skillClass.target = eSkillTarget.ally;
											if (165048 - 250518 != -85470)
											{
												continue;
											}
											skillClass.cType = "fateDraw";
											if (129549 - 208829 != -79279)
											{
												break;
											}
											continue;
											IL_2922:
											skillClass.setReq(11, 3);
											if (269356 - 223543 == 45814)
											{
												continue;
											}
											skillClass.setMP(6);
											if (287113 - 521105 != -233992)
											{
												continue;
											}
											goto IL_D88;
										}
										skillClass.setReq(9, 1);
										if (6997 - 380908 != -373911)
										{
											continue;
										}
										skillClass.setMPSP(3, 8);
										if (231094 - 10551 != 220544)
										{
											goto IL_2240;
										}
										continue;
										IL_2703:
										skillClass.setReq(21, 3);
										if (294549 - 34562 != 259987)
										{
											continue;
										}
										skillClass.setMPSP(5, 14);
										if (257691 - 549805 != -292114)
										{
											continue;
										}
										skillClass.mode = eSkillMode.target;
										if (180519 - 253483 == -72963)
										{
											continue;
										}
										skillClass.target = eSkillTarget.enemy;
										if (180236 - 211369 == -31132)
										{
											continue;
										}
										skillClass.cType = "luckyCard";
										if (66011 - 471371 != -405359)
										{
											break;
										}
										continue;
										IL_2240:
										skillClass.setReq(15, 2);
										if (222162 - 32100 == 190063)
										{
											continue;
										}
										skillClass.setMPSP(4, 11);
										if (199834 - 429495 != -229661)
										{
											continue;
										}
										goto IL_2703;
									}
									IL_1093:
									skillClass.setReq(40, 10);
									if (179902 - 159040 != 20862)
									{
										continue;
									}
									skillClass.mode = eSkillMode.passive;
									if (24238 - 411211 != -386973)
									{
										continue;
									}
									skillClass.target = eSkillTarget.self;
									if (257765 - 434699 != -176933)
									{
										break;
									}
									continue;
									IL_2D97:
									skillClass.setReq(20, 6);
									if (101883 - 136751 != -34868)
									{
										continue;
									}
									IL_33C8:
									skillClass.setReq(30, 8);
									if (66648 - 293570 != -226921)
									{
										goto IL_1093;
									}
									continue;
								}
								IL_CF6:
								skillClass.setReq(32, 10);
								if (191101 - 313143 == -122041)
								{
									continue;
								}
								skillClass.mode = eSkillMode.passive;
								if (78773 - 278121 != -199347)
								{
									break;
								}
								continue;
								IL_2AE4:
								skillClass.setReq(24, 8);
								if (209120 - 530368 != -321248)
								{
									continue;
								}
								goto IL_CF6;
								IL_21FC:
								skillClass.setReq(19, 6);
								if (100053 - 128255 != -28201)
								{
									goto IL_2AE4;
								}
								continue;
							}
							skillClass.setReq(12, 4);
							if (191849 - 584587 == -392737)
							{
								continue;
							}
							skillClass.setSP(-5);
							if (46795 - 123614 == -76818)
							{
								continue;
							}
							skillClass.mode = eSkillMode.instant;
							if (33320 - 186205 != -152885)
							{
								continue;
							}
							skillClass.target = eSkillTarget.self;
							if (228235 - 390708 != -162473)
							{
								continue;
							}
							skillClass.cType = "awareness";
							if (232738 - 43610 != 189129)
							{
								break;
							}
							continue;
						}
						IL_14BD:
						skillClass.setReq(16, 3);
						if (208625 - 132726 == 75900)
						{
							continue;
						}
						skillClass.mode = eSkillMode.passive;
						if (99668 - 490563 == -390894)
						{
							continue;
						}
						skillClass.target = eSkillTarget.enemy;
						if (294651 - 470144 != -175493)
						{
							continue;
						}
						skillClass.cType = "cAttack";
						if (211507 - 119736 != 91772)
						{
							break;
						}
						continue;
						IL_1EC7:
						skillClass.setReq(10, 2);
						if (276860 - 166254 != 110607)
						{
							goto IL_14BD;
						}
						continue;
					}
					skillClass.setReq(2, 1);
					if (217660 - 205477 != 12183)
					{
						continue;
					}
					goto IL_26E1;
					IL_146C:
					skillClass.setReq(4, 3);
					if (261582 - 571643 == -310060)
					{
						continue;
					}
					skillClass.mode = eSkillMode.passive;
					if (11802 - 245356 == -233553)
					{
						continue;
					}
					skillClass.target = eSkillTarget.enemy;
					if (13955 - 339218 != -325263)
					{
						continue;
					}
					skillClass.cType = "nAttack";
					if (274226 - 386279 != -112053)
					{
						continue;
					}
					break;
					IL_26E1:
					skillClass.setReq(3, 2);
					if (48189 - 180503 == -132314)
					{
						goto IL_146C;
					}
				}
			}
		}
		return skillClass;
	}

	// Token: 0x060021E5 RID: 8677 RVA: 0x003E3204 File Offset: 0x003E1404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillTree(int commandNum)
	{
		if (25658 - 438080 != -412421)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (244650 - 557280 == -312630)
			{
				if (37646 - 504589 != -466942)
				{
					if (commandNum == 101)
					{
						if (249741 - 575914 != -326172)
						{
							result = "cat_nAttack1";
							if (164288 - 446207 != -281918)
							{
								break;
							}
						}
					}
					else if (commandNum == 102)
					{
						if (176129 - 340050 == -163921)
						{
							result = "cat_nAttack2";
							if (202651 - 211523 != -8871)
							{
								break;
							}
						}
					}
					else if (commandNum == 103)
					{
						if (117535 - 390135 != -272599)
						{
							result = "cat_nAttack3";
							if (283113 - 575320 != -292206)
							{
								break;
							}
						}
					}
					else if (commandNum == 111)
					{
						if (112274 - 60726 == 51548)
						{
							result = "cat_cAttack1";
							if (261967 - 578937 != -316969)
							{
								break;
							}
						}
					}
					else if (commandNum == 112)
					{
						if (39690 - 382904 == -343214)
						{
							result = "cat_cAttack2";
							if (116841 - 430610 != -313768)
							{
								break;
							}
						}
					}
					else if (commandNum == 113)
					{
						if (216192 - 285581 == -69389)
						{
							result = "cat_cAttack3";
							if (165226 - 548987 != -383760)
							{
								break;
							}
						}
					}
					else if (commandNum == 121)
					{
						if (10274 - 277631 != -267356)
						{
							result = "cat_awareness1";
							if (196643 - 332079 != -135435)
							{
								break;
							}
						}
					}
					else if (commandNum == 122)
					{
						if (98686 - 356410 != -257723)
						{
							result = "cat_awareness2";
							if (95398 - 429118 != -333719)
							{
								break;
							}
						}
					}
					else if (commandNum == 123)
					{
						if (216461 - 394664 == -178203)
						{
							result = "cat_treasureHunt1";
							if (216066 - 430228 == -214162)
							{
								break;
							}
						}
					}
					else if (commandNum == 131)
					{
						if (163910 - 117104 != 46807)
						{
							result = "cat_felineAgility1";
							if (299539 - 304919 != -5379)
							{
								break;
							}
						}
					}
					else if (commandNum == 132)
					{
						if (56976 - 48751 != 8226)
						{
							result = "cat_felineAgility2";
							if (69765 - 591379 != -521613)
							{
								break;
							}
						}
					}
					else if (commandNum == 133)
					{
						if (24725 - 250245 == -225520)
						{
							result = "cat_felineAgility3";
							if (240715 - 45804 != 194912)
							{
								break;
							}
						}
					}
					else if (commandNum == 134)
					{
						if (74169 - 436562 != -362392)
						{
							result = "cat_felineAgility4";
							if (267304 - 334841 == -67537)
							{
								break;
							}
						}
					}
					else if (commandNum == 141)
					{
						if (260972 - 578289 != -317316)
						{
							result = "cat_statPlus1";
							if (168948 - 518917 == -349969)
							{
								break;
							}
						}
					}
					else if (commandNum == 142)
					{
						if (107601 - 340871 == -233270)
						{
							result = "cat_statPlus2";
							if (247338 - 18053 != 229286)
							{
								break;
							}
						}
					}
					else if (commandNum == 143)
					{
						if (286272 - 207249 != 79024)
						{
							result = "cat_statPlus3";
							if (283738 - 182675 == 101063)
							{
								break;
							}
						}
					}
					else if (commandNum == 144)
					{
						if (218975 - 424097 != -205121)
						{
							result = "cat_statPlus4";
							if (91246 - 95421 != -4174)
							{
								break;
							}
						}
					}
					else if (commandNum == 201)
					{
						if (272896 - 181884 != 91013)
						{
							result = "cat_luckyCard1";
							if (249996 - 461435 == -211439)
							{
								break;
							}
						}
					}
					else if (commandNum == 202)
					{
						if (243716 - 431829 != -188112)
						{
							result = "cat_luckyCard2";
							if (102145 - 219982 != -117836)
							{
								break;
							}
						}
					}
					else if (commandNum == 203)
					{
						if (248307 - 473757 != -225449)
						{
							result = "cat_luckyCard3";
							if (126935 - 379966 != -253030)
							{
								break;
							}
						}
					}
					else if (commandNum == 204)
					{
						if (274342 - 25861 != 248482)
						{
							result = "cat_luckyCard4";
							if (91869 - 271019 != -179149)
							{
								break;
							}
						}
					}
					else if (commandNum == 211)
					{
						if (120733 - 2198 != 118536)
						{
							result = "cat_fateDraw1";
							if (179749 - 475035 != -295285)
							{
								break;
							}
						}
					}
					else if (commandNum == 212)
					{
						if (236374 - 166575 != 69800)
						{
							result = "cat_fateDraw2";
							if (105061 - 127439 == -22378)
							{
								break;
							}
						}
					}
					else if (commandNum == 213)
					{
						if (266323 - 306597 == -40274)
						{
							result = "cat_fateDraw3";
							if (78313 - 432556 != -354242)
							{
								break;
							}
						}
					}
					else if (commandNum == 214)
					{
						if (41701 - 597422 == -555721)
						{
							result = "cat_fateDraw4";
							if (84610 - 462349 != -377738)
							{
								break;
							}
						}
					}
					else if (commandNum == 221)
					{
						if (73658 - 553866 != -480207)
						{
							result = "cat_powerShuffle1";
							if (58715 - 511188 != -452472)
							{
								break;
							}
						}
					}
					else if (commandNum == 222)
					{
						if (214015 - 191623 == 22392)
						{
							result = "cat_powerShuffle2";
							if (159480 - 142806 != 16675)
							{
								break;
							}
						}
					}
					else if (commandNum == 223)
					{
						if (35369 - 76398 != -41028)
						{
							result = "cat_lifeGamble1";
							if (53903 - 166071 != -112167)
							{
								break;
							}
						}
					}
					else if (commandNum == 224)
					{
						if (266488 - 126509 == 139979)
						{
							result = "cat_skillGamble2";
							if (111402 - 314417 == -203015)
							{
								break;
							}
						}
					}
					else if (commandNum == 231)
					{
						if (144887 - 387115 != -242227)
						{
							result = "cat_luckyDice1";
							if (168699 - 553788 != -385088)
							{
								break;
							}
						}
					}
					else if (commandNum == 232)
					{
						if (187887 - 321205 != -133317)
						{
							result = "cat_luckyDice2";
							if (110970 - 211386 != -100415)
							{
								break;
							}
						}
					}
					else if (commandNum == 233)
					{
						if (280145 - 149204 == 130941)
						{
							result = "cat_doubleDown1";
							if (115106 - 587389 == -472283)
							{
								break;
							}
						}
					}
					else if (commandNum == 234)
					{
						if (40429 - 326148 == -285719)
						{
							result = "cat_doubleDown2";
							if (123408 - 421977 == -298569)
							{
								break;
							}
						}
					}
					else if (commandNum == 241)
					{
						if (40909 - 120924 != -80014)
						{
							result = "cat_powerOne1";
							if (68993 - 224695 == -155702)
							{
								break;
							}
						}
					}
					else if (commandNum == 242)
					{
						if (266646 - 91045 == 175601)
						{
							result = "cat_powerTwo2";
							if (273098 - 162195 == 110903)
							{
								break;
							}
						}
					}
					else if (commandNum == 243)
					{
						if (280213 - 216866 == 63347)
						{
							result = "cat_powerThree3";
							if (161744 - 321146 == -159402)
							{
								break;
							}
						}
					}
					else if (commandNum == 244)
					{
						if (184305 - 137802 == 46503)
						{
							result = "cat_powerSeven4";
							if (218298 - 55284 == 163014)
							{
								break;
							}
						}
					}
					else if (commandNum == 251)
					{
						if (268434 - 74386 != 194049)
						{
							result = "cat_twoPair1";
							if (226012 - 391562 == -165550)
							{
								break;
							}
						}
					}
					else if (commandNum == 252)
					{
						if (175800 - 449030 != -273229)
						{
							result = "cat_twoPair2";
							if (246454 - 235506 == 10948)
							{
								break;
							}
						}
					}
					else if (commandNum == 253)
					{
						if (292599 - 216543 != 76057)
						{
							result = "cat_copycat1";
							if (229611 - 150844 == 78767)
							{
								break;
							}
						}
					}
					else if (commandNum == 254)
					{
						if (292066 - 164996 != 127071)
						{
							result = "cat_copycat2";
							if (91651 - 226214 == -134563)
							{
								break;
							}
						}
					}
					else if (commandNum == 261)
					{
						if (154775 - 242716 != -87940)
						{
							result = "cat_damageRoulette1";
							if (251045 - 469484 != -218438)
							{
								break;
							}
						}
					}
					else if (commandNum == 262)
					{
						if (53400 - 126117 == -72717)
						{
							result = "cat_damageRoulette2";
							if (63277 - 349711 != -286433)
							{
								break;
							}
						}
					}
					else if (commandNum == 263)
					{
						if (172381 - 223971 == -51590)
						{
							result = "cat_nineLives1";
							if (295470 - 388016 != -92545)
							{
								break;
							}
						}
					}
					else if (commandNum == 264)
					{
						if (99309 - 442165 == -342856)
						{
							result = "cat_nineLives2";
							if (172356 - 120079 != 52278)
							{
								break;
							}
						}
					}
					else if (commandNum == 271)
					{
						if (26702 - 62814 == -36112)
						{
							result = "cat_grandCasinoArcade1";
							if (46443 - 283315 == -236872)
							{
								break;
							}
						}
					}
					else if (commandNum == 272)
					{
						if (293186 - 490036 != -196849)
						{
							result = "cat_grandCasinoArcade2";
							if (159624 - 19554 == 140070)
							{
								break;
							}
						}
					}
					else if (commandNum == 301)
					{
						if (37230 - 88456 != -51225)
						{
							result = "cat_flyingDagger1";
							if (7527 - 113269 == -105742)
							{
								break;
							}
						}
					}
					else if (commandNum == 302)
					{
						if (11850 - 258000 == -246150)
						{
							result = "cat_flyingDagger2";
							if (293856 - 52621 == 241235)
							{
								break;
							}
						}
					}
					else if (commandNum == 303)
					{
						if (25535 - 525625 == -500090)
						{
							result = "cat_flyingDagger3";
							if (256141 - 368527 != -112385)
							{
								break;
							}
						}
					}
					else if (commandNum == 304)
					{
						if (76719 - 29343 != 47377)
						{
							result = "cat_flyingDagger4";
							if (86483 - 423527 != -337043)
							{
								break;
							}
						}
					}
					else if (commandNum == 311)
					{
						if (53504 - 3241 == 50263)
						{
							result = "cat_forwardLunge1";
							if (36859 - 269103 != -232243)
							{
								break;
							}
						}
					}
					else if (commandNum == 312)
					{
						if (203181 - 45457 != 157725)
						{
							result = "cat_reverseThrust1";
							if (97820 - 571566 == -473746)
							{
								break;
							}
						}
					}
					else if (commandNum == 313)
					{
						if (204806 - 129178 == 75628)
						{
							result = "cat_forwardLunge2";
							if (20335 - 362676 != -342340)
							{
								break;
							}
						}
					}
					else if (commandNum == 314)
					{
						if (238910 - 22523 != 216388)
						{
							result = "cat_reverseThrust2";
							if (2706 - 147031 != -144324)
							{
								break;
							}
						}
					}
					else if (commandNum == 321)
					{
						if (42361 - 218041 == -175680)
						{
							result = "cat_backflip1";
							if (145775 - 246166 == -100391)
							{
								break;
							}
						}
					}
					else if (commandNum == 322)
					{
						if (20388 - 161049 != -140660)
						{
							result = "cat_backflip2";
							if (139807 - 204759 != -64951)
							{
								break;
							}
						}
					}
					else if (commandNum == 323)
					{
						if (79310 - 221263 == -141953)
						{
							result = "cat_heartRipper1";
							if (195824 - 321581 == -125757)
							{
								break;
							}
						}
					}
					else if (commandNum == 324)
					{
						if (198347 - 517353 == -319006)
						{
							result = "cat_heartRipper2";
							if (241235 - 248195 == -6960)
							{
								break;
							}
						}
					}
					else if (commandNum == 331)
					{
						if (141304 - 229353 != -88048)
						{
							result = "cat_hiddenBlade1";
							if (26199 - 475876 != -449676)
							{
								break;
							}
						}
					}
					else if (commandNum == 332)
					{
						if (216975 - 273747 != -56771)
						{
							result = "cat_hiddenBlade2";
							if (82837 - 467550 == -384713)
							{
								break;
							}
						}
					}
					else if (commandNum == 333)
					{
						if (56560 - 578314 == -521754)
						{
							result = "cat_hiddenBlade3";
							if (176603 - 432482 == -255879)
							{
								break;
							}
						}
					}
					else if (commandNum == 334)
					{
						if (40380 - 95090 == -54710)
						{
							result = "cat_hiddenBlade4";
							if (18719 - 314024 == -295305)
							{
								break;
							}
						}
					}
					else if (commandNum == 341)
					{
						if (106912 - 373367 != -266454)
						{
							result = "cat_disarm1";
							if (6486 - 312535 == -306049)
							{
								break;
							}
						}
					}
					else if (commandNum == 342)
					{
						if (95385 - 45619 != 49767)
						{
							result = "cat_disarm2";
							if (25411 - 253165 != -227753)
							{
								break;
							}
						}
					}
					else if (commandNum == 343)
					{
						if (105071 - 122878 == -17807)
						{
							result = "cat_bleed1";
							if (172676 - 303562 != -130885)
							{
								break;
							}
						}
					}
					else if (commandNum == 344)
					{
						if (98183 - 28317 == 69866)
						{
							result = "cat_bleed2";
							if (44794 - 117184 == -72390)
							{
								break;
							}
						}
					}
					else if (commandNum == 351)
					{
						if (97493 - 447058 == -349565)
						{
							result = "cat_moonBlade1";
							if (251046 - 22608 != 228439)
							{
								break;
							}
						}
					}
					else if (commandNum == 352)
					{
						if (61526 - 121107 != -59580)
						{
							result = "cat_moonBlade2";
							if (166122 - 444180 != -278057)
							{
								break;
							}
						}
					}
					else if (commandNum == 353)
					{
						if (111924 - 516170 == -404246)
						{
							result = "cat_moonStorm1";
							if (109270 - 39746 != 69525)
							{
								break;
							}
						}
					}
					else if (commandNum == 354)
					{
						if (134566 - 513217 != -378650)
						{
							result = "cat_moonStorm2";
							if (298042 - 112275 != 185768)
							{
								break;
							}
						}
					}
					else if (commandNum == 361)
					{
						if (52829 - 263564 != -210734)
						{
							result = "cat_evasion1";
							if (289122 - 295056 != -5933)
							{
								break;
							}
						}
					}
					else if (commandNum == 362)
					{
						if (120487 - 107945 == 12542)
						{
							result = "cat_evasion2";
							if (269582 - 17951 != 251632)
							{
								break;
							}
						}
					}
					else if (commandNum == 363)
					{
						if (83859 - 586892 != -503032)
						{
							result = "cat_evasion3";
							if (20157 - 105122 == -84965)
							{
								break;
							}
						}
					}
					else if (commandNum == 364)
					{
						if (217995 - 116900 == 101095)
						{
							result = "cat_vendetta1";
							if (220767 - 95271 == 125496)
							{
								break;
							}
						}
					}
					else if (commandNum == 371)
					{
						if (141958 - 522496 != -380537)
						{
							result = "cat_deltaStrike1";
							if (28192 - 289374 == -261182)
							{
								break;
							}
						}
					}
					else if (commandNum == 372)
					{
						if (259278 - 418791 == -159513)
						{
							result = "cat_deltaStrike2";
							if (246591 - 36112 != 210480)
							{
								break;
							}
						}
					}
					else if (commandNum == 401)
					{
						if (188294 - 51730 == 136564)
						{
							result = "cat_noChance5";
							if (229017 - 35980 != 193038)
							{
								break;
							}
						}
					}
					else if (commandNum == 411)
					{
						if (19629 - 449424 == -429795)
						{
							result = "cat_doubleFocus5";
							if (44506 - 124806 != -80299)
							{
								break;
							}
						}
					}
					else if (commandNum == 421)
					{
						if (200803 - 211236 == -10433)
						{
							result = "cat_insight5";
							if (138136 - 34437 != 103700)
							{
								break;
							}
						}
					}
					else if (commandNum == 431)
					{
						if (266062 - 351561 != -85498)
						{
							result = "cat_swiftPace5";
							if (192384 - 48112 != 144273)
							{
								break;
							}
						}
					}
					else if (commandNum == 441)
					{
						if (235601 - 125600 != 110002)
						{
							result = "cat_superStatPlus5";
							if (160740 - 71662 != 89079)
							{
								break;
							}
						}
					}
					else if (commandNum == 402)
					{
						if (280409 - 125738 == 154671)
						{
							result = "cat_joker5";
							if (149698 - 494190 == -344492)
							{
								break;
							}
						}
					}
					else if (commandNum == 412)
					{
						if (216006 - 128432 == 87574)
						{
							result = "cat_ladyLuck5";
							if (216318 - 361731 != -145412)
							{
								break;
							}
						}
					}
					else if (commandNum == 422)
					{
						if (279623 - 551088 == -271465)
						{
							result = "cat_evenOdds5";
							if (2111 - 26235 == -24124)
							{
								break;
							}
						}
					}
					else if (commandNum == 432)
					{
						if (43281 - 181753 == -138472)
						{
							result = "cat_rollTheDice5";
							if (205797 - 592792 == -386995)
							{
								break;
							}
						}
					}
					else if (commandNum == 442)
					{
						if (141998 - 145938 == -3940)
						{
							result = "cat_superSeven5";
							if (244681 - 473130 == -228449)
							{
								break;
							}
						}
					}
					else if (commandNum == 403)
					{
						if (248840 - 206560 == 42280)
						{
							result = "cat_threeKnives5";
							if (325 - 49830 != -49504)
							{
								break;
							}
						}
					}
					else if (commandNum == 413)
					{
						if (11825 - 119170 != -107344)
						{
							result = "cat_backstab5";
							if (153319 - 113695 != 39625)
							{
								break;
							}
						}
					}
					else if (commandNum == 423)
					{
						if (161055 - 383872 == -222817)
						{
							result = "cat_finishingBlow5";
							if (295975 - 28696 == 267279)
							{
								break;
							}
						}
					}
					else if (commandNum == 433)
					{
						if (91644 - 122068 == -30424)
						{
							result = "cat_jaggedKnife5";
							if (205128 - 296209 == -91081)
							{
								break;
							}
						}
					}
					else if (commandNum == 443)
					{
						if (71617 - 462875 == -391258)
						{
							result = "cat_openWound5";
							if (123628 - 444710 == -321082)
							{
								break;
							}
						}
					}
					else if (commandNum == 404)
					{
						if (107919 - 478927 == -371008)
						{
							result = "cat_revisedSkill5";
							if (130288 - 322182 == -191894)
							{
								break;
							}
						}
					}
					else if (commandNum == 414)
					{
						if (117163 - 233046 == -115883)
						{
							result = "cat_revisedMagic5";
							if (197117 - 74581 != 122537)
							{
								break;
							}
						}
					}
					else if (commandNum == 424)
					{
						if (265084 - 554422 != -289337)
						{
							result = "cat_revisedArt5";
							if (182653 - 519443 != -336789)
							{
								break;
							}
						}
					}
					else if (commandNum == 434)
					{
						if (169263 - 527922 != -358658)
						{
							result = "cat_pillagePlunge5";
							if (262380 - 485233 != -222852)
							{
								break;
							}
						}
					}
					else
					{
						if (commandNum != 444)
						{
							break;
						}
						if (170949 - 229074 == -58125)
						{
							result = "cat_supportFire5";
							if (70941 - 410824 == -339883)
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

	// Token: 0x060021E6 RID: 8678 RVA: 0x003E4E68 File Offset: 0x003E3068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x003E4E6C File Offset: 0x003E306C
	internal static bool eBFarC0H3pCUORDL0sS()
	{
		return true;
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x003E4E70 File Offset: 0x003E3070
	internal static bool s5hvK20WIcBJ7NA9cXS()
	{
		return false;
	}
}
