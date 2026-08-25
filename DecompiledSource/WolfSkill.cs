using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A1D RID: 2589
[Serializable]
public class WolfSkill : MonoBehaviour
{
	// Token: 0x0600387C RID: 14460 RVA: 0x0076D334 File Offset: 0x0076B534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WolfSkill()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600387D RID: 14461 RVA: 0x0076D344 File Offset: 0x0076B544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSkill(string skillname)
	{
		if (205604 - 556947 != -351343)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (82959 - 299674 != -216714)
			{
				if (42121 - 115926 == -73805)
				{
					if (skillname == "wlf_nAttack1")
					{
						if (150168 - 109616 != 40552)
						{
							continue;
						}
						skillClass.setReq(1, 0);
						if (43116 - 307462 != -264346)
						{
							continue;
						}
						goto IL_25A8;
					}
					else if (skillname == "wlf_nAttack2")
					{
						if (199138 - 512489 != -313351)
						{
							continue;
						}
						goto IL_25A8;
					}
					else if (skillname == "wlf_nAttack3")
					{
						if (38397 - 225984 != -187587)
						{
							continue;
						}
					}
					else
					{
						if (skillname == "wlf_cAttack1")
						{
							if (14935 - 371605 != -356670)
							{
								continue;
							}
							skillClass.setReq(4, 1);
							if (122532 - 346421 != -223888)
							{
								goto IL_2797;
							}
							continue;
						}
						else if (skillname == "wlf_cAttack2")
						{
							if (86932 - 222168 != -135235)
							{
								goto IL_2797;
							}
							continue;
						}
						else if (skillname == "wlf_cAttack3")
						{
							if (167083 - 240877 == -73793)
							{
								continue;
							}
						}
						else
						{
							if (skillname == "wlf_perseverance1")
							{
								if (28399 - 154034 != -125635)
								{
									continue;
								}
								skillClass.setReq(6, 2);
								if (82097 - 300003 == -217905)
								{
									continue;
								}
							}
							else if (skillname == "wlf_perseverance2")
							{
								if (67402 - 28363 == 39040)
								{
									continue;
								}
							}
							else
							{
								if (skillname == "wlf_doubleArt1")
								{
									if (57281 - 71624 != -14343)
									{
										continue;
									}
									skillClass.setReq(8, 4);
									if (19432 - 99893 != -80460)
									{
										goto IL_2C46;
									}
									continue;
								}
								else if (skillname == "wlf_doubleArt2")
								{
									if (62326 - 332259 != -269932)
									{
										goto IL_2C46;
									}
									continue;
								}
								else if (skillname == "wlf_doubleArt3")
								{
									if (242135 - 522927 != -280792)
									{
										continue;
									}
								}
								else if (skillname == "wlf_doubleArt4")
								{
									if (114424 - 304375 != -189951)
									{
										continue;
									}
									goto IL_2D01;
								}
								else
								{
									if (skillname == "wlf_statPlus1")
									{
										if (197123 - 545547 != -348424)
										{
											continue;
										}
										skillClass.setReq(10, 4);
										if (81448 - 222211 != -140762)
										{
											goto IL_FFA;
										}
										continue;
									}
									else if (skillname == "wlf_statPlus2")
									{
										if (154271 - 455306 != -301035)
										{
											continue;
										}
										goto IL_FFA;
									}
									else if (skillname == "wlf_statPlus3")
									{
										if (15130 - 491555 != -476425)
										{
											continue;
										}
										goto IL_E12;
									}
									else if (skillname == "wlf_statPlus4")
									{
										if (258428 - 141159 == 117270)
										{
											continue;
										}
									}
									else
									{
										if (skillname == "wlf_braveSpirit1")
										{
											if (1411 - 225912 != -224501)
											{
												continue;
											}
											skillClass.setReq(3, 0);
											if (297665 - 223605 == 74061)
											{
												continue;
											}
											skillClass.setMP(4);
											if (47074 - 507308 == -460233)
											{
												continue;
											}
										}
										else if (skillname == "wlf_braveSpirit2")
										{
											if (210505 - 468068 != -257563)
											{
												continue;
											}
										}
										else if (skillname == "wlf_braveSpirit3")
										{
											if (42465 - 81553 != -39088)
											{
												continue;
											}
											goto IL_2A4;
										}
										else if (skillname == "wlf_braveSpirit4")
										{
											if (122349 - 303744 != -181395)
											{
												continue;
											}
											goto IL_DEF;
										}
										else
										{
											if (skillname == "wlf_crusader1")
											{
												if (238362 - 75958 == 162405)
												{
													continue;
												}
												skillClass.setReq(5, 1);
												if (296375 - 34802 != 261573)
												{
													continue;
												}
												skillClass.setMPSP(6, 10);
												if (289308 - 170153 == 119156)
												{
													continue;
												}
											}
											else if (skillname == "wlf_crusader2")
											{
												if (208396 - 160286 != 48110)
												{
													continue;
												}
											}
											else if (skillname == "wlf_crusader3")
											{
												if (109944 - 415011 != -305066)
												{
													goto IL_179A;
												}
												continue;
											}
											else if (skillname == "wlf_crusader4")
											{
												if (184758 - 387378 != -202620)
												{
													continue;
												}
												goto IL_232A;
											}
											else
											{
												if (skillname == "wlf_powerBreak1")
												{
													if (235204 - 152368 != 82836)
													{
														continue;
													}
													skillClass.setReq(7, 2);
													if (52033 - 182570 == -130536)
													{
														continue;
													}
													skillClass.setSP(-10);
													if (43745 - 146142 == -102396)
													{
														continue;
													}
												}
												else if (skillname == "wlf_powerBreak2")
												{
													if (169558 - 50653 == 118906)
													{
														continue;
													}
												}
												else
												{
													if (skillname == "wlf_armorBreak1")
													{
														if (93828 - 484170 == -390341)
														{
															continue;
														}
														skillClass.setReq(13, 4);
														if (59401 - 551430 != -492029)
														{
															continue;
														}
														skillClass.setSP(-10);
														if (267683 - 200478 != 67205)
														{
															continue;
														}
													}
													else if (skillname == "wlf_armorBreak2")
													{
														if (288948 - 263985 != 24963)
														{
															continue;
														}
													}
													else
													{
														if (skillname == "wlf_weaponPlus1")
														{
															if (242507 - 477110 == -234602)
															{
																continue;
															}
															skillClass.setReq(9, 3);
															if (165958 - 465098 != -299140)
															{
																continue;
															}
															goto IL_3126;
														}
														else if (skillname == "wlf_weaponPlus2")
														{
															if (145308 - 16299 != 129009)
															{
																continue;
															}
															goto IL_3126;
														}
														else if (skillname == "wlf_weaponPlus3")
														{
															if (194603 - 110322 != 84282)
															{
																goto IL_2EEF;
															}
															continue;
														}
														else if (skillname == "wlf_weaponPlus4")
														{
															if (47160 - 535224 == -488063)
															{
																continue;
															}
														}
														else
														{
															if (skillname == "wlf_armorPlus1")
															{
																if (229708 - 399395 == -169686)
																{
																	continue;
																}
																skillClass.setReq(16, 4);
																if (107658 - 436539 != -328881)
																{
																	continue;
																}
																goto IL_2B6B;
															}
															else if (skillname == "wlf_armorPlus2")
															{
																if (121796 - 483912 != -362115)
																{
																	goto IL_2B6B;
																}
																continue;
															}
															else if (skillname == "wlf_armorPlus3")
															{
																if (106159 - 268252 != -162093)
																{
																	continue;
																}
															}
															else if (skillname == "wlf_armorPlus4")
															{
																if (122227 - 298302 != -176074)
																{
																	goto IL_33B0;
																}
																continue;
															}
															else
															{
																if (skillname == "wlf_noKo1")
																{
																	if (197722 - 559324 == -361601)
																	{
																		continue;
																	}
																	skillClass.setReq(20, 12);
																	if (49452 - 176434 != -126982)
																	{
																		continue;
																	}
																}
																else if (skillname == "wlf_noKo2")
																{
																	if (294034 - 170995 != 123039)
																	{
																		continue;
																	}
																}
																else if (skillname == "wlf_noKo3")
																{
																	if (293240 - 505376 != -212135)
																	{
																		goto IL_3425;
																	}
																	continue;
																}
																else if (skillname == "wlf_secondWind1")
																{
																	if (155339 - 583157 != -427818)
																	{
																		continue;
																	}
																	skillClass.setReq(32, 21);
																	if (30713 - 555475 == -524761)
																	{
																		continue;
																	}
																	skillClass.setMPSP(30, 20);
																	if (92124 - 599638 != -507514)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.instant;
																	if (71723 - 350836 == -279112)
																	{
																		continue;
																	}
																	skillClass.target = eSkillTarget.self;
																	if (2393 - 372636 != -370243)
																	{
																		continue;
																	}
																	skillClass.cType = "secondWind";
																	if (43867 - 265035 != -221168)
																	{
																		continue;
																	}
																	break;
																}
																else
																{
																	if (skillname == "wlf_crossBreak1")
																	{
																		if (244607 - 328462 == -83854)
																		{
																			continue;
																		}
																		skillClass.setReq(24, 15);
																		if (155456 - 332377 == -176920)
																		{
																			continue;
																		}
																		skillClass.setMPSP(25, -30);
																		if (178708 - 84207 == 94502)
																		{
																			continue;
																		}
																	}
																	else if (skillname == "wlf_crossBreak2")
																	{
																		if (218100 - 510758 == -292657)
																		{
																			continue;
																		}
																	}
																	else if (skillname == "wlf_crossBreak3")
																	{
																		if (151097 - 455167 != -304070)
																		{
																			continue;
																		}
																		goto IL_C26;
																	}
																	else if (skillname == "wlf_grandCross1")
																	{
																		if (189572 - 319568 != -129996)
																		{
																			continue;
																		}
																		skillClass.setReq(33, 24);
																		if (106211 - 523036 == -416824)
																		{
																			continue;
																		}
																		skillClass.setMPSP(45, -30);
																		if (103828 - 44534 != 59294)
																		{
																			continue;
																		}
																		skillClass.mode = eSkillMode.instant;
																		if (271403 - 267250 != 4153)
																		{
																			continue;
																		}
																		skillClass.target = eSkillTarget.enemy;
																		if (257392 - 575838 == -318445)
																		{
																			continue;
																		}
																		skillClass.cType = "grandCross";
																		if (69499 - 455742 != -386243)
																		{
																			continue;
																		}
																		break;
																	}
																	else
																	{
																		if (skillname == "wlf_massResurrection1")
																		{
																			if (181245 - 498424 != -317179)
																			{
																				continue;
																			}
																			skillClass.setReq(35, 25);
																			if (176719 - 159087 != 17632)
																			{
																				continue;
																			}
																			skillClass.setMPSP(45, -35);
																			if (181782 - 250418 != -68636)
																			{
																				continue;
																			}
																		}
																		else if (skillname == "wlf_massResurrection2")
																		{
																			if (274547 - 316624 == -42076)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (skillname == "wlf_bladeFang1")
																			{
																				if (280568 - 43111 == 237458)
																				{
																					continue;
																				}
																				skillClass.setReq(3, 0);
																				if (92540 - 584795 == -492254)
																				{
																					continue;
																				}
																				skillClass.setSP(-6);
																				if (58294 - 452873 != -394579)
																				{
																					continue;
																				}
																				goto IL_2585;
																			}
																			else if (skillname == "wlf_bladeFang2")
																			{
																				if (169388 - 200834 != -31445)
																				{
																					goto IL_2585;
																				}
																				continue;
																			}
																			else if (skillname == "wlf_bladeFang3")
																			{
																				if (226418 - 282623 == -56204)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				if (skillname == "wlf_feralInstinct1")
																				{
																					if (175173 - 399300 == -224126)
																					{
																						continue;
																					}
																					skillClass.setReq(5, 1);
																					if (13364 - 167061 == -153696)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "wlf_feralInstinct2")
																				{
																					if (181715 - 404542 == -222826)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "wlf_feralInstinct3")
																				{
																					if (221023 - 436193 != -215169)
																					{
																						goto IL_3021;
																					}
																					continue;
																				}
																				else if (skillname == "wlf_feralInstinct4")
																				{
																					if (190682 - 448061 != -257379)
																					{
																						continue;
																					}
																					goto IL_2510;
																				}
																				else
																				{
																					if (skillname == "wlf_provoke1")
																					{
																						if (155245 - 527653 != -372408)
																						{
																							continue;
																						}
																						skillClass.setReq(7, 2);
																						if (165870 - 465109 == -299238)
																						{
																							continue;
																						}
																						skillClass.setMPSP(4, -4);
																						if (201668 - 277813 == -76144)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "wlf_provoke2")
																					{
																						if (163555 - 370635 == -207079)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						if (skillname == "wlf_artCancel1")
																						{
																							if (189032 - 350939 != -161907)
																							{
																								continue;
																							}
																							skillClass.setReq(19, 6);
																							if (12662 - 521735 == -509072)
																							{
																								continue;
																							}
																							skillClass.setSP(-10);
																							if (146635 - 17390 != 129245)
																							{
																								continue;
																							}
																						}
																						else if (skillname == "wlf_artCancel2")
																						{
																							if (55488 - 215421 == -159932)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							if (skillname == "wlf_counter1")
																							{
																								if (21047 - 412203 != -391156)
																								{
																									continue;
																								}
																								skillClass.setReq(9, 3);
																								if (3003 - 443223 == -440219)
																								{
																									continue;
																								}
																								skillClass.setSP(-2);
																								if (254086 - 211802 != 42284)
																								{
																									continue;
																								}
																							}
																							else if (skillname == "wlf_counter2")
																							{
																								if (264451 - 398205 == -133753)
																								{
																									continue;
																								}
																							}
																							else
																							{
																								if (skillname == "wlf_impulse1")
																								{
																									if (171650 - 589770 != -418120)
																									{
																										continue;
																									}
																									skillClass.setReq(21, 7);
																									if (288774 - 394685 != -105911)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "wlf_impulse2")
																								{
																									if (43132 - 333191 == -290058)
																									{
																										continue;
																									}
																								}
																								else
																								{
																									if (skillname == "wlf_feralStrike1")
																									{
																										if (295454 - 260340 == 35115)
																										{
																											continue;
																										}
																										skillClass.setReq(16, 4);
																										if (31551 - 38756 != -7205)
																										{
																											continue;
																										}
																										skillClass.setSP(15);
																										if (101659 - 96329 != 5330)
																										{
																											continue;
																										}
																										goto IL_17BD;
																									}
																									else if (skillname == "wlf_feralStrike2")
																									{
																										if (4015 - 400634 != -396618)
																										{
																											goto IL_17BD;
																										}
																										continue;
																									}
																									else if (skillname == "wlf_feralStrike3")
																									{
																										if (241223 - 532664 == -291440)
																										{
																											continue;
																										}
																									}
																									else if (skillname == "wlf_feralStrike4")
																									{
																										if (209429 - 378096 != -168666)
																										{
																											goto IL_1C8F;
																										}
																										continue;
																									}
																									else
																									{
																										if (skillname == "wlf_bladeSong1")
																										{
																											if (184111 - 397925 != -213814)
																											{
																												continue;
																											}
																											skillClass.setReq(20, 12);
																											if (208037 - 564088 != -356051)
																											{
																												continue;
																											}
																											skillClass.setSP(-32);
																											if (290144 - 275512 != 14633)
																											{
																												goto IL_1BCB;
																											}
																											continue;
																										}
																										else if (skillname == "wlf_bladeSong2")
																										{
																											if (139432 - 131742 != 7690)
																											{
																												continue;
																											}
																											goto IL_1BCB;
																										}
																										else if (skillname == "wlf_bladeSong3")
																										{
																											if (32500 - 255354 != -222854)
																											{
																												continue;
																											}
																										}
																										else if (skillname == "wlf_lastBlade1")
																										{
																											if (28961 - 85506 == -56544)
																											{
																												continue;
																											}
																											skillClass.setReq(32, 21);
																											if (78164 - 554828 != -476664)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.passive;
																											if (202565 - 275687 != -73121)
																											{
																												break;
																											}
																											continue;
																										}
																										else
																										{
																											if (skillname == "wlf_darkEdge1")
																											{
																												if (149983 - 26496 == 123488)
																												{
																													continue;
																												}
																												skillClass.setReq(24, 15);
																												if (263557 - 295296 == -31738)
																												{
																													continue;
																												}
																												skillClass.setMP(12);
																												if (92440 - 360095 == -267654)
																												{
																													continue;
																												}
																											}
																											else if (skillname == "wlf_darkEdge2")
																											{
																												if (142133 - 135925 == 6209)
																												{
																													continue;
																												}
																											}
																											else if (skillname == "wlf_darkEdge3")
																											{
																												if (146959 - 410471 != -263511)
																												{
																													goto IL_2A2B;
																												}
																												continue;
																											}
																											else if (skillname == "wlf_darkEdge4")
																											{
																												if (14560 - 134430 != -119869)
																												{
																													goto IL_32EC;
																												}
																												continue;
																											}
																											else
																											{
																												if (skillname == "wlf_lunarEclipse1")
																												{
																													if (22885 - 598638 != -575753)
																													{
																														continue;
																													}
																													skillClass.setReq(35, 23);
																													if (60612 - 62755 != -2143)
																													{
																														continue;
																													}
																													skillClass.setMPSP(20, -45);
																													if (250239 - 111476 != 138763)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "wlf_lunarEclipse2")
																												{
																													if (220642 - 88204 == 132439)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "wlf_finalEclipse1")
																												{
																													if (58216 - 32464 != 25752)
																													{
																														continue;
																													}
																													skillClass.setReq(45, 27);
																													if (202233 - 580224 == -377990)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (198058 - 339370 != -141311)
																													{
																														break;
																													}
																													continue;
																												}
																												else if (skillname == "wlf_continuousBlade5")
																												{
																													if (130729 - 500596 == -369866)
																													{
																														continue;
																													}
																													skillClass.setReq(55, 0);
																													if (213029 - 403028 == -189998)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (140612 - 311922 != -171310)
																													{
																														continue;
																													}
																													skillClass.rSkill = 103;
																													if (242103 - 190694 != 51409)
																													{
																														continue;
																													}
																													break;
																												}
																												else if (skillname == "wlf_skySlasher5")
																												{
																													if (105670 - 201819 == -96148)
																													{
																														continue;
																													}
																													skillClass.setReq(60, 1);
																													if (72642 - 17016 != 55626)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (58568 - 550623 != -492055)
																													{
																														continue;
																													}
																													skillClass.rSkill = 113;
																													if (217113 - 220079 != -2966)
																													{
																														continue;
																													}
																													break;
																												}
																												else if (skillname == "wlf_fortitude5")
																												{
																													if (227183 - 189809 != 37374)
																													{
																														continue;
																													}
																													skillClass.setReq(70, 3);
																													if (9044 - 112108 == -103063)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (11330 - 416308 != -404978)
																													{
																														continue;
																													}
																													skillClass.rSkill = 122;
																													if (101242 - 15745 != 85498)
																													{
																														break;
																													}
																													continue;
																												}
																												else if (skillname == "wlf_sublimeArt5")
																												{
																													if (100776 - 86730 != 14046)
																													{
																														continue;
																													}
																													skillClass.setReq(75, 4);
																													if (177154 - 122084 != 55070)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (210101 - 286639 == -76537)
																													{
																														continue;
																													}
																													skillClass.rSkill = 134;
																													if (25789 - 558825 != -533036)
																													{
																														continue;
																													}
																													break;
																												}
																												else if (skillname == "wlf_superStatPlus5")
																												{
																													if (191693 - 440167 != -248474)
																													{
																														continue;
																													}
																													skillClass.setReq(85, 6);
																													if (50484 - 96892 == -46407)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (284003 - 286762 != -2759)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.self;
																													if (195588 - 358853 != -163265)
																													{
																														continue;
																													}
																													skillClass.rSkill = 144;
																													if (64050 - 392904 != -328853)
																													{
																														break;
																													}
																													continue;
																												}
																												else if (skillname == "wlf_gloriousSpirit5")
																												{
																													if (226419 - 430676 != -204257)
																													{
																														continue;
																													}
																													skillClass.setReq(55, 0);
																													if (260932 - 410448 == -149515)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (91836 - 516333 == -424496)
																													{
																														continue;
																													}
																													skillClass.rSkill = 204;
																													if (148580 - 450361 != -301781)
																													{
																														continue;
																													}
																													break;
																												}
																												else if (skillname == "wlf_lawBringer5")
																												{
																													if (69014 - 25448 == 43567)
																													{
																														continue;
																													}
																													skillClass.setReq(60, 1);
																													if (30389 - 1406 != 28983)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (169227 - 593134 != -423907)
																													{
																														continue;
																													}
																													skillClass.rSkill = 214;
																													if (523 - 493426 != -492902)
																													{
																														break;
																													}
																													continue;
																												}
																												else if (skillname == "wlf_thirdRend5")
																												{
																													if (143568 - 547889 != -404321)
																													{
																														continue;
																													}
																													skillClass.setReq(70, 3);
																													if (245380 - 443476 == -198095)
																													{
																														continue;
																													}
																													skillClass.setMPSP(10, -20);
																													if (269064 - 48210 == 220855)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.instant;
																													if (209919 - 316785 == -106865)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.enemy;
																													if (289 - 449439 == -449149)
																													{
																														continue;
																													}
																													skillClass.cType = "thirdRend";
																													if (94965 - 398250 == -303284)
																													{
																														continue;
																													}
																													skillClass.rSkill = 224;
																													if (150118 - 367036 != -216917)
																													{
																														break;
																													}
																													continue;
																												}
																												else if (skillname == "wlf_holySword5")
																												{
																													if (211802 - 588386 == -376583)
																													{
																														continue;
																													}
																													skillClass.setReq(75, 4);
																													if (40830 - 263679 != -222849)
																													{
																														continue;
																													}
																													skillClass.setMPSP(40, -40);
																													if (198086 - 116346 != 81740)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.instant;
																													if (282310 - 66675 == 215636)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.self;
																													if (70826 - 562910 == -492083)
																													{
																														continue;
																													}
																													skillClass.cType = "holySword";
																													if (297734 - 152090 == 145645)
																													{
																														continue;
																													}
																													skillClass.rSkill = 234;
																													if (281442 - 314590 != -33148)
																													{
																														continue;
																													}
																													break;
																												}
																												else if (skillname == "wlf_holyArmor5")
																												{
																													if (8659 - 434375 != -425716)
																													{
																														continue;
																													}
																													skillClass.setReq(85, 6);
																													if (209338 - 400566 != -191228)
																													{
																														continue;
																													}
																													skillClass.setMPSP(40, -40);
																													if (160769 - 112144 != 48625)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.instant;
																													if (289116 - 589858 != -300742)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.self;
																													if (163614 - 486687 == -323072)
																													{
																														continue;
																													}
																													skillClass.cType = "holyArmor";
																													if (149077 - 13388 == 135690)
																													{
																														continue;
																													}
																													skillClass.rSkill = 244;
																													if (127261 - 389245 != -261984)
																													{
																														continue;
																													}
																													break;
																												}
																												else if (skillname == "wlf_bloodFang5")
																												{
																													if (274919 - 151196 == 123724)
																													{
																														continue;
																													}
																													skillClass.setReq(55, 0);
																													if (44708 - 11676 == 33033)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (246236 - 453353 == -207116)
																													{
																														continue;
																													}
																													skillClass.rSkill = 303;
																													if (93457 - 241173 != -147715)
																													{
																														break;
																													}
																													continue;
																												}
																												else if (skillname == "wlf_wildHeart5")
																												{
																													if (64603 - 284156 != -219553)
																													{
																														continue;
																													}
																													skillClass.setReq(60, 1);
																													if (166035 - 441252 == -275216)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (159122 - 290827 == -131704)
																													{
																														continue;
																													}
																													skillClass.rSkill = 314;
																													if (247858 - 46208 != 201650)
																													{
																														continue;
																													}
																													break;
																												}
																												else if (skillname == "wlf_artBreaker5")
																												{
																													if (118123 - 438318 != -320195)
																													{
																														continue;
																													}
																													skillClass.setReq(70, 3);
																													if (1063 - 16883 == -15819)
																													{
																														continue;
																													}
																													skillClass.setSP(-30);
																													if (76682 - 8354 != 68328)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.target;
																													if (169087 - 405934 != -236847)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.enemy;
																													if (114499 - 445382 == -330882)
																													{
																														continue;
																													}
																													skillClass.cType = "artCancel";
																													if (92016 - 324116 != -232100)
																													{
																														continue;
																													}
																													skillClass.rSkill = 324;
																													if (227453 - 393728 != -166274)
																													{
																														break;
																													}
																													continue;
																												}
																												else if (skillname == "wlf_mirrorBlade5")
																												{
																													if (154586 - 599321 == -444734)
																													{
																														continue;
																													}
																													skillClass.setReq(75, 4);
																													if (196884 - 238656 != -41772)
																													{
																														continue;
																													}
																													skillClass.setSP(-30);
																													if (247295 - 249461 == -2165)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.target;
																													if (95160 - 426868 != -331708)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.enemy;
																													if (18587 - 598470 != -579883)
																													{
																														continue;
																													}
																													skillClass.cType = "mirrorBlade";
																													if (290191 - 66461 == 223731)
																													{
																														continue;
																													}
																													skillClass.rSkill = 334;
																													if (232542 - 133274 != 99269)
																													{
																														break;
																													}
																													continue;
																												}
																												else if (skillname == "wlf_feralAssault5")
																												{
																													if (111741 - 534605 != -422864)
																													{
																														continue;
																													}
																													skillClass.setReq(85, 6);
																													if (40202 - 403439 == -363236)
																													{
																														continue;
																													}
																													skillClass.setSP(-45);
																													if (229790 - 347400 != -117610)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.instant;
																													if (195559 - 490873 == -295313)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.enemy;
																													if (114495 - 457115 != -342620)
																													{
																														continue;
																													}
																													skillClass.cType = "feralAssault";
																													if (30573 - 538690 != -508117)
																													{
																														continue;
																													}
																													skillClass.rSkill = 344;
																													if (22208 - 445750 != -423541)
																													{
																														break;
																													}
																													continue;
																												}
																												else if (skillname == "wlf_revisedSkill5")
																												{
																													if (206911 - 149090 != 57821)
																													{
																														continue;
																													}
																													skillClass.setReq(55, 0);
																													if (90302 - 285054 != -194752)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (263719 - 515537 != -251818)
																													{
																														continue;
																													}
																													break;
																												}
																												else if (skillname == "wlf_revisedMagic5")
																												{
																													if (69475 - 321656 == -252180)
																													{
																														continue;
																													}
																													skillClass.setReq(60, 1);
																													if (50195 - 206771 != -156576)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (105484 - 513865 != -408380)
																													{
																														break;
																													}
																													continue;
																												}
																												else if (skillname == "wlf_revisedArt5")
																												{
																													if (273407 - 395381 == -121973)
																													{
																														continue;
																													}
																													skillClass.setReq(70, 3);
																													if (123848 - 578013 != -454165)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (55254 - 146634 != -91380)
																													{
																														continue;
																													}
																													break;
																												}
																												else if (skillname == "wlf_dualBrand5")
																												{
																													if (298970 - 534301 == -235330)
																													{
																														continue;
																													}
																													skillClass.setReq(75, 4);
																													if (152327 - 318177 == -165849)
																													{
																														continue;
																													}
																													skillClass.setMPSP(24, -36);
																													if (99444 - 127919 != -28475)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.instant;
																													if (134793 - 467053 != -332260)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.enemy;
																													if (148625 - 142991 == 5635)
																													{
																														continue;
																													}
																													skillClass.cType = "dualBrand";
																													if (114180 - 308340 != -194160)
																													{
																														continue;
																													}
																													skillClass.rSkill = 251351;
																													if (211396 - 404406 != -193010)
																													{
																														continue;
																													}
																													break;
																												}
																												else
																												{
																													if (!(skillname == "wlf_twinResonance5"))
																													{
																														break;
																													}
																													if (264256 - 273008 == -8751)
																													{
																														continue;
																													}
																													skillClass.setReq(85, 6);
																													if (190452 - 445382 != -254930)
																													{
																														continue;
																													}
																													skillClass.setMPSP(60, -60);
																													if (156316 - 3069 == 153248)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.instant;
																													if (286356 - 259420 != 26936)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.enemy;
																													if (87530 - 230626 == -143095)
																													{
																														continue;
																													}
																													skillClass.cType = "twinResonance";
																													if (251506 - 55692 == 195815)
																													{
																														continue;
																													}
																													skillClass.rSkill = 434;
																													if (252094 - 568259 != -316164)
																													{
																														break;
																													}
																													continue;
																												}
																												skillClass.setReq(40, 25);
																												if (62370 - 472143 != -409773)
																												{
																													continue;
																												}
																												skillClass.setMPSP(20, -60);
																												if (197118 - 198752 != -1634)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.instant;
																												if (155999 - 311951 == -155951)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.self;
																												if (256489 - 400198 != -143709)
																												{
																													continue;
																												}
																												skillClass.cType = "lunarEclipse";
																												if (125293 - 165064 != -39771)
																												{
																													continue;
																												}
																												break;
																											}
																											skillClass.setReq(27, 18);
																											if (111794 - 252717 != -140923)
																											{
																												continue;
																											}
																											skillClass.setMP(19);
																											if (237904 - 437268 != -199364)
																											{
																												continue;
																											}
																											IL_2A2B:
																											skillClass.setReq(30, 21);
																											if (27488 - 201487 != -173999)
																											{
																												continue;
																											}
																											skillClass.setMP(26);
																											if (2667 - 420642 != -417975)
																											{
																												continue;
																											}
																											IL_32EC:
																											skillClass.setReq(33, 24);
																											if (105204 - 119431 == -14226)
																											{
																												continue;
																											}
																											skillClass.setMP(33);
																											if (52687 - 166506 != -113819)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.instant;
																											if (116594 - 527857 != -411263)
																											{
																												continue;
																											}
																											skillClass.target = eSkillTarget.self;
																											if (212548 - 86197 != 126351)
																											{
																												continue;
																											}
																											skillClass.cType = "darkEdge";
																											if (221091 - 577976 != -356884)
																											{
																												break;
																											}
																											continue;
																										}
																										IL_87:
																										skillClass.setReq(28, 18);
																										if (217843 - 293334 != -75491)
																										{
																											continue;
																										}
																										skillClass.setSP(-40);
																										if (44070 - 433587 != -389517)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.instant;
																										if (274760 - 47107 != 227653)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.enemy;
																										if (53429 - 275594 == -222164)
																										{
																											continue;
																										}
																										skillClass.cType = "bladeSong";
																										if (136418 - 539478 != -403060)
																										{
																											continue;
																										}
																										break;
																										IL_1BCB:
																										skillClass.setReq(24, 15);
																										if (59217 - 372013 == -312795)
																										{
																											continue;
																										}
																										skillClass.setSP(-36);
																										if (261863 - 408105 != -146241)
																										{
																											goto IL_87;
																										}
																										continue;
																									}
																									IL_11AB:
																									skillClass.setReq(24, 12);
																									if (208164 - 440765 != -232601)
																									{
																										continue;
																									}
																									skillClass.setSP(21);
																									if (48227 - 320145 == -271917)
																									{
																										continue;
																									}
																									IL_1C8F:
																									skillClass.setReq(28, 16);
																									if (289924 - 562501 != -272577)
																									{
																										continue;
																									}
																									skillClass.setSP(24);
																									if (231302 - 26434 != 204868)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.instant;
																									if (100059 - 354587 != -254528)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.enemy;
																									if (229435 - 313720 != -84285)
																									{
																										continue;
																									}
																									skillClass.cType = "feralStrike";
																									if (23456 - 342111 != -318654)
																									{
																										break;
																									}
																									continue;
																									IL_17BD:
																									skillClass.setReq(20, 8);
																									if (58612 - 206325 == -147712)
																									{
																										continue;
																									}
																									skillClass.setSP(18);
																									if (58025 - 83567 != -25541)
																									{
																										goto IL_11AB;
																									}
																									continue;
																								}
																								skillClass.setReq(27, 9);
																								if (5652 - 197988 == -192335)
																								{
																									continue;
																								}
																								skillClass.mode = eSkillMode.passive;
																								if (98844 - 464726 != -365882)
																								{
																									continue;
																								}
																								break;
																							}
																							skillClass.setReq(15, 5);
																							if (257501 - 247674 == 9828)
																							{
																								continue;
																							}
																							skillClass.setSP(-3);
																							if (112604 - 211668 != -99064)
																							{
																								continue;
																							}
																							skillClass.mode = eSkillMode.instant;
																							if (255650 - 30085 == 225566)
																							{
																								continue;
																							}
																							skillClass.target = eSkillTarget.enemy;
																							if (193072 - 153218 == 39855)
																							{
																								continue;
																							}
																							skillClass.cType = "counter";
																							if (244002 - 295317 != -51315)
																							{
																								continue;
																							}
																							break;
																						}
																						skillClass.setReq(25, 8);
																						if (10953 - 549118 == -538164)
																						{
																							continue;
																						}
																						skillClass.setSP(-14);
																						if (40574 - 556101 != -515527)
																						{
																							continue;
																						}
																						skillClass.mode = eSkillMode.instant;
																						if (129447 - 416954 == -287506)
																						{
																							continue;
																						}
																						skillClass.target = eSkillTarget.enemy;
																						if (263694 - 147741 == 115954)
																						{
																							continue;
																						}
																						skillClass.cType = "artCancel";
																						if (54867 - 546100 != -491233)
																						{
																							continue;
																						}
																						break;
																					}
																					skillClass.setReq(13, 4);
																					if (64461 - 130949 != -66488)
																					{
																						continue;
																					}
																					skillClass.setMPSP(6, -6);
																					if (66630 - 4580 != 62050)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.target;
																					if (220030 - 224924 != -4894)
																					{
																						continue;
																					}
																					skillClass.target = eSkillTarget.enemy;
																					if (200224 - 6838 != 193386)
																					{
																						continue;
																					}
																					skillClass.cType = "provoke";
																					if (228950 - 428125 != -199175)
																					{
																						continue;
																					}
																					break;
																				}
																				skillClass.setReq(11, 3);
																				if (29021 - 3909 != 25112)
																				{
																					continue;
																				}
																				goto IL_3021;
																				IL_2510:
																				skillClass.setReq(23, 7);
																				if (263082 - 585803 != -322721)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.passive;
																				if (255430 - 450650 != -195219)
																				{
																					break;
																				}
																				continue;
																				IL_3021:
																				skillClass.setReq(17, 5);
																				if (158584 - 529897 != -371313)
																				{
																					continue;
																				}
																				goto IL_2510;
																			}
																			IL_4A7:
																			skillClass.setReq(15, 2);
																			if (160014 - 542304 != -382290)
																			{
																				continue;
																			}
																			skillClass.setSP(-12);
																			if (19654 - 461058 == -441403)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.instant;
																			if (251967 - 552878 == -300910)
																			{
																				continue;
																			}
																			skillClass.target = eSkillTarget.enemy;
																			if (227865 - 30995 != 196870)
																			{
																				continue;
																			}
																			skillClass.cType = "bladeFang";
																			if (293813 - 427817 != -134004)
																			{
																				continue;
																			}
																			break;
																			IL_2585:
																			skillClass.setReq(9, 1);
																			if (112433 - 344574 == -232140)
																			{
																				continue;
																			}
																			skillClass.setSP(-9);
																			if (115555 - 416380 != -300824)
																			{
																				goto IL_4A7;
																			}
																			continue;
																		}
																		skillClass.setReq(40, 27);
																		if (66963 - 557664 == -490700)
																		{
																			continue;
																		}
																		skillClass.setMPSP(60, -35);
																		if (72585 - 89476 != -16891)
																		{
																			continue;
																		}
																		skillClass.mode = eSkillMode.instant;
																		if (276699 - 197298 != 79401)
																		{
																			continue;
																		}
																		skillClass.target = eSkillTarget.ally;
																		if (175758 - 351829 == -176070)
																		{
																			continue;
																		}
																		skillClass.cType = "massResurrection";
																		if (58124 - 269269 != -211145)
																		{
																			continue;
																		}
																		break;
																	}
																	skillClass.setReq(27, 18);
																	if (272833 - 423370 != -150537)
																	{
																		continue;
																	}
																	skillClass.setMPSP(30, -35);
																	if (85992 - 101687 == -15694)
																	{
																		continue;
																	}
																	IL_C26:
																	skillClass.setReq(30, 21);
																	if (251074 - 97893 != 153181)
																	{
																		continue;
																	}
																	skillClass.setMPSP(35, -40);
																	if (253137 - 36201 == 216937)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.instant;
																	if (206117 - 231818 == -25700)
																	{
																		continue;
																	}
																	skillClass.target = eSkillTarget.enemy;
																	if (217730 - 35315 != 182415)
																	{
																		continue;
																	}
																	skillClass.cType = "crossBreak";
																	if (202078 - 174864 != 27215)
																	{
																		break;
																	}
																	continue;
																}
																skillClass.setReq(24, 15);
																if (18330 - 415379 == -397048)
																{
																	continue;
																}
																IL_3425:
																skillClass.setReq(28, 18);
																if (39174 - 3194 != 35980)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.passive;
																if (75180 - 35638 != 39542)
																{
																	continue;
																}
																break;
															}
															IL_13D1:
															skillClass.setReq(24, 12);
															if (93508 - 383000 != -289492)
															{
																continue;
															}
															IL_33B0:
															skillClass.setReq(28, 16);
															if (177636 - 356354 != -178718)
															{
																continue;
															}
															skillClass.mode = eSkillMode.passive;
															if (217968 - 312243 != -94275)
															{
																continue;
															}
															break;
															IL_2B6B:
															skillClass.setReq(20, 8);
															if (191387 - 418721 != -227333)
															{
																goto IL_13D1;
															}
															continue;
														}
														IL_2981:
														skillClass.setReq(27, 9);
														if (126646 - 430237 == -303590)
														{
															continue;
														}
														skillClass.mode = eSkillMode.passive;
														if (223947 - 152082 != 71865)
														{
															continue;
														}
														break;
														IL_2EEF:
														skillClass.setReq(21, 7);
														if (137068 - 403460 != -266392)
														{
															continue;
														}
														goto IL_2981;
														IL_3126:
														skillClass.setReq(15, 5);
														if (64122 - 425449 != -361326)
														{
															goto IL_2EEF;
														}
														continue;
													}
													skillClass.setReq(25, 8);
													if (257625 - 377145 == -119519)
													{
														continue;
													}
													skillClass.setSP(-14);
													if (254706 - 437210 != -182504)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (88031 - 222925 == -134893)
													{
														continue;
													}
													skillClass.target = eSkillTarget.enemy;
													if (213703 - 24958 != 188745)
													{
														continue;
													}
													skillClass.cType = "armorBreak";
													if (54956 - 287781 != -232825)
													{
														continue;
													}
													break;
												}
												skillClass.setReq(19, 6);
												if (208364 - 386931 != -178567)
												{
													continue;
												}
												skillClass.setSP(-14);
												if (213895 - 248146 == -34250)
												{
													continue;
												}
												skillClass.mode = eSkillMode.instant;
												if (78362 - 463520 == -385157)
												{
													continue;
												}
												skillClass.target = eSkillTarget.enemy;
												if (261039 - 244049 != 16990)
												{
													continue;
												}
												skillClass.cType = "powerBreak";
												if (202471 - 274581 != -72110)
												{
													continue;
												}
												break;
											}
											skillClass.setReq(11, 3);
											if (119906 - 265342 != -145436)
											{
												continue;
											}
											skillClass.setMPSP(8, 12);
											if (9362 - 564883 == -555520)
											{
												continue;
											}
											IL_179A:
											skillClass.setReq(17, 5);
											if (215921 - 251599 == -35677)
											{
												continue;
											}
											skillClass.setMPSP(10, 14);
											if (168708 - 115565 == 53144)
											{
												continue;
											}
											IL_232A:
											skillClass.setReq(23, 7);
											if (141956 - 407589 != -265633)
											{
												continue;
											}
											skillClass.setMPSP(12, 16);
											if (21904 - 291101 == -269196)
											{
												continue;
											}
											skillClass.mode = eSkillMode.instant;
											if (257798 - 151873 != 105925)
											{
												continue;
											}
											skillClass.target = eSkillTarget.enemy;
											if (57228 - 32532 != 24696)
											{
												continue;
											}
											skillClass.cType = "crusader";
											if (38621 - 444920 != -406298)
											{
												break;
											}
											continue;
										}
										skillClass.setReq(9, 1);
										if (8315 - 435316 != -427001)
										{
											continue;
										}
										skillClass.setMP(6);
										if (148458 - 438094 != -289636)
										{
											continue;
										}
										IL_2A4:
										skillClass.setReq(15, 2);
										if (273663 - 98499 != 175164)
										{
											continue;
										}
										skillClass.setMP(8);
										if (120638 - 436855 == -316216)
										{
											continue;
										}
										IL_DEF:
										skillClass.setReq(21, 3);
										if (3839 - 203958 == -200118)
										{
											continue;
										}
										skillClass.setMP(10);
										if (48204 - 73545 == -25340)
										{
											continue;
										}
										skillClass.mode = eSkillMode.instant;
										if (231579 - 596147 == -364567)
										{
											continue;
										}
										skillClass.target = eSkillTarget.self;
										if (223330 - 338022 != -114692)
										{
											continue;
										}
										skillClass.cType = "braveSpirit";
										if (108503 - 282579 != -174076)
										{
											continue;
										}
										break;
									}
									IL_F84:
									skillClass.setReq(40, 10);
									if (119738 - 333023 != -213285)
									{
										continue;
									}
									skillClass.mode = eSkillMode.passive;
									if (83609 - 177044 == -93434)
									{
										continue;
									}
									skillClass.target = eSkillTarget.self;
									if (88208 - 475437 != -387228)
									{
										break;
									}
									continue;
									IL_E12:
									skillClass.setReq(30, 8);
									if (44644 - 225792 != -181148)
									{
										continue;
									}
									goto IL_F84;
									IL_FFA:
									skillClass.setReq(20, 6);
									if (224470 - 49947 != 174523)
									{
										continue;
									}
									goto IL_E12;
								}
								IL_1EAA:
								skillClass.setReq(24, 8);
								if (206443 - 309756 != -103312)
								{
									goto IL_2D01;
								}
								continue;
								IL_2C46:
								skillClass.setReq(16, 6);
								if (64182 - 282643 != -218460)
								{
									goto IL_1EAA;
								}
								continue;
								IL_2D01:
								skillClass.setReq(32, 10);
								if (186132 - 517616 == -331483)
								{
									continue;
								}
								skillClass.mode = eSkillMode.passive;
								if (200671 - 374441 != -173770)
								{
									continue;
								}
								break;
							}
							skillClass.setReq(12, 4);
							if (230890 - 516507 != -285617)
							{
								continue;
							}
							skillClass.mode = eSkillMode.passive;
							if (290602 - 13504 != 277099)
							{
								break;
							}
							continue;
						}
						IL_D34:
						skillClass.setReq(16, 3);
						if (263131 - 564960 == -301828)
						{
							continue;
						}
						skillClass.mode = eSkillMode.passive;
						if (217849 - 22850 != 194999)
						{
							continue;
						}
						skillClass.target = eSkillTarget.enemy;
						if (282066 - 240063 != 42003)
						{
							continue;
						}
						skillClass.cType = "cAttack";
						if (255249 - 436734 != -181485)
						{
							continue;
						}
						break;
						IL_2797:
						skillClass.setReq(10, 2);
						if (113018 - 222691 != -109673)
						{
							continue;
						}
						goto IL_D34;
					}
					IL_1E88:
					skillClass.setReq(3, 2);
					if (197681 - 395179 == -197497)
					{
						continue;
					}
					skillClass.mode = eSkillMode.passive;
					if (273529 - 452667 != -179138)
					{
						continue;
					}
					skillClass.target = eSkillTarget.enemy;
					if (17609 - 406882 != -389273)
					{
						continue;
					}
					skillClass.cType = "nAttack";
					if (250821 - 558833 != -308011)
					{
						break;
					}
					continue;
					IL_25A8:
					skillClass.setReq(2, 1);
					if (193197 - 285762 != -92564)
					{
						goto IL_1E88;
					}
				}
			}
		}
		return skillClass;
	}

	// Token: 0x0600387E RID: 14462 RVA: 0x00770928 File Offset: 0x0076EB28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillTree(object commandNum)
	{
		if (45746 - 307076 != -261329)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (211825 - 508459 == -296634)
			{
				if (185451 - 137459 != 47993)
				{
					if (RuntimeServices.EqualityOperator(commandNum, 101))
					{
						if (285759 - 259243 != 26517)
						{
							result = "wlf_nAttack1";
							if (284516 - 468765 != -184248)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 102))
					{
						if (31136 - 386287 != -355150)
						{
							result = "wlf_nAttack2";
							if (152215 - 48013 != 104203)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 103))
					{
						if (70837 - 366122 != -295284)
						{
							result = "wlf_nAttack3";
							if (112362 - 580747 != -468384)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 111))
					{
						if (267316 - 401323 == -134007)
						{
							result = "wlf_cAttack1";
							if (115468 - 237999 != -122530)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 112))
					{
						if (195256 - 303304 != -108047)
						{
							result = "wlf_cAttack2";
							if (15519 - 206684 == -191165)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 113))
					{
						if (190949 - 218721 == -27772)
						{
							result = "wlf_cAttack3";
							if (249981 - 590378 != -340396)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 121))
					{
						if (88724 - 53954 != 34771)
						{
							result = "wlf_perseverance1";
							if (78849 - 432370 == -353521)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 122))
					{
						if (136034 - 298714 == -162680)
						{
							result = "wlf_perseverance2";
							if (70573 - 529221 != -458647)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 131))
					{
						if (265503 - 59091 != 206413)
						{
							result = "wlf_doubleArt1";
							if (118632 - 17297 == 101335)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 132))
					{
						if (207420 - 20704 == 186716)
						{
							result = "wlf_doubleArt2";
							if (133261 - 140735 != -7473)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 133))
					{
						if (91454 - 305657 == -214203)
						{
							result = "wlf_doubleArt3";
							if (164828 - 352417 == -187589)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 134))
					{
						if (258636 - 251997 != 6640)
						{
							result = "wlf_doubleArt4";
							if (258504 - 377174 != -118669)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 141))
					{
						if (260391 - 438659 == -178268)
						{
							result = "wlf_statPlus1";
							if (19789 - 198430 != -178640)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 142))
					{
						if (16571 - 15532 == 1039)
						{
							result = "wlf_statPlus2";
							if (210164 - 368899 != -158734)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 143))
					{
						if (290146 - 592055 == -301909)
						{
							result = "wlf_statPlus3";
							if (122121 - 85635 != 36487)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 144))
					{
						if (214555 - 264479 != -49923)
						{
							result = "wlf_statPlus4";
							if (5906 - 1724 != 4183)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 201))
					{
						if (250235 - 302394 == -52159)
						{
							result = "wlf_braveSpirit1";
							if (109956 - 483240 != -373283)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 202))
					{
						if (291216 - 16443 != 274774)
						{
							result = "wlf_braveSpirit2";
							if (209928 - 152962 == 56966)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 203))
					{
						if (202387 - 8412 != 193976)
						{
							result = "wlf_braveSpirit3";
							if (250118 - 508439 != -258320)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 204))
					{
						if (206019 - 8020 != 198000)
						{
							result = "wlf_braveSpirit4";
							if (43983 - 542935 == -498952)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 211))
					{
						if (53074 - 174902 == -121828)
						{
							result = "wlf_crusader1";
							if (103351 - 91866 == 11485)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 212))
					{
						if (105306 - 325826 != -220519)
						{
							result = "wlf_crusader2";
							if (29681 - 385091 != -355409)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 213))
					{
						if (251798 - 257939 != -6140)
						{
							result = "wlf_crusader3";
							if (179659 - 447062 == -267403)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 214))
					{
						if (224646 - 218058 == 6588)
						{
							result = "wlf_crusader4";
							if (179003 - 416151 != -237147)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 221))
					{
						if (278690 - 326659 == -47969)
						{
							result = "wlf_powerBreak1";
							if (79675 - 94044 != -14368)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 222))
					{
						if (157166 - 111216 != 45951)
						{
							result = "wlf_armorBreak1";
							if (251542 - 445055 != -193512)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 223))
					{
						if (181222 - 298874 != -117651)
						{
							result = "wlf_powerBreak2";
							if (84686 - 572653 == -487967)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 224))
					{
						if (241828 - 390769 == -148941)
						{
							result = "wlf_armorBreak2";
							if (203271 - 306293 == -103022)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 231))
					{
						if (194227 - 381159 == -186932)
						{
							result = "wlf_weaponPlus1";
							if (135015 - 136083 != -1067)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 232))
					{
						if (103455 - 372654 == -269199)
						{
							result = "wlf_weaponPlus2";
							if (290469 - 560757 == -270288)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 233))
					{
						if (61500 - 118131 == -56631)
						{
							result = "wlf_weaponPlus3";
							if (75521 - 382263 == -306742)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 234))
					{
						if (149997 - 411291 == -261294)
						{
							result = "wlf_weaponPlus4";
							if (125304 - 559620 == -434316)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 241))
					{
						if (194760 - 388884 == -194124)
						{
							result = "wlf_armorPlus1";
							if (260763 - 579548 != -318784)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 242))
					{
						if (95579 - 400003 != -304423)
						{
							result = "wlf_armorPlus2";
							if (258097 - 562833 != -304735)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 243))
					{
						if (25171 - 136049 != -110877)
						{
							result = "wlf_armorPlus3";
							if (78227 - 309072 == -230845)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 244))
					{
						if (135171 - 132581 == 2590)
						{
							result = "wlf_armorPlus4";
							if (105774 - 561636 != -455861)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 251))
					{
						if (56133 - 227967 != -171833)
						{
							result = "wlf_noKo1";
							if (216368 - 382987 == -166619)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 252))
					{
						if (30758 - 414273 == -383515)
						{
							result = "wlf_noKo2";
							if (60529 - 494206 != -433676)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 253))
					{
						if (231447 - 454091 != -222643)
						{
							result = "wlf_noKo3";
							if (211842 - 274317 == -62475)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 254))
					{
						if (290200 - 254598 != 35603)
						{
							result = "wlf_secondWind1";
							if (58422 - 521450 != -463027)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 261))
					{
						if (9387 - 556766 == -547379)
						{
							result = "wlf_crossBreak1";
							if (168365 - 344876 == -176511)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 262))
					{
						if (259951 - 32325 != 227627)
						{
							result = "wlf_crossBreak2";
							if (74225 - 286493 == -212268)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 263))
					{
						if (4570 - 327246 != -322675)
						{
							result = "wlf_crossBreak3";
							if (10326 - 132813 != -122486)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 264))
					{
						if (298101 - 322384 == -24283)
						{
							result = "wlf_grandCross1";
							if (297996 - 19884 == 278112)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 271))
					{
						if (41249 - 336706 == -295457)
						{
							result = "wlf_massResurrection1";
							if (154538 - 135580 != 18959)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 272))
					{
						if (65141 - 168900 == -103759)
						{
							result = "wlf_massResurrection2";
							if (209981 - 130754 == 79227)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 301))
					{
						if (176168 - 218081 == -41913)
						{
							result = "wlf_bladeFang1";
							if (24571 - 90321 != -65749)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 302))
					{
						if (275794 - 151235 != 124560)
						{
							result = "wlf_bladeFang2";
							if (189061 - 327762 != -138700)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 303))
					{
						if (159116 - 336292 == -177176)
						{
							result = "wlf_bladeFang3";
							if (263435 - 218565 == 44870)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 311))
					{
						if (189629 - 80271 != 109359)
						{
							result = "wlf_feralInstinct1";
							if (255378 - 563292 != -307913)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 312))
					{
						if (263755 - 213874 != 49882)
						{
							result = "wlf_feralInstinct2";
							if (195605 - 503937 != -308331)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 313))
					{
						if (112689 - 343289 == -230600)
						{
							result = "wlf_feralInstinct3";
							if (106641 - 262786 != -156144)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 314))
					{
						if (219041 - 533944 != -314902)
						{
							result = "wlf_feralInstinct4";
							if (285729 - 62429 != 223301)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 321))
					{
						if (27606 - 264884 != -237277)
						{
							result = "wlf_provoke1";
							if (21756 - 270310 != -248553)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 322))
					{
						if (226668 - 197471 != 29198)
						{
							result = "wlf_provoke2";
							if (281421 - 194533 == 86888)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 323))
					{
						if (116393 - 431842 != -315448)
						{
							result = "wlf_artCancel1";
							if (118614 - 342912 == -224298)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 324))
					{
						if (21668 - 473366 != -451697)
						{
							result = "wlf_artCancel2";
							if (136841 - 324390 != -187548)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 331))
					{
						if (33041 - 157144 == -124103)
						{
							result = "wlf_counter1";
							if (251514 - 162574 == 88940)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 332))
					{
						if (216369 - 258515 != -42145)
						{
							result = "wlf_counter2";
							if (222117 - 37789 == 184328)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 333))
					{
						if (45541 - 469935 != -424393)
						{
							result = "wlf_impulse1";
							if (46417 - 538133 != -491715)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 334))
					{
						if (20104 - 504706 != -484601)
						{
							result = "wlf_impulse2";
							if (204103 - 302250 == -98147)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 341))
					{
						if (30714 - 556546 == -525832)
						{
							result = "wlf_feralStrike1";
							if (288000 - 150800 == 137200)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 342))
					{
						if (178984 - 283954 != -104969)
						{
							result = "wlf_feralStrike2";
							if (224457 - 587778 == -363321)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 343))
					{
						if (267461 - 42074 == 225387)
						{
							result = "wlf_feralStrike3";
							if (250475 - 559141 == -308666)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 344))
					{
						if (132819 - 179753 != -46933)
						{
							result = "wlf_feralStrike4";
							if (231201 - 4769 != 226433)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 351))
					{
						if (278218 - 299525 == -21307)
						{
							result = "wlf_bladeSong1";
							if (285220 - 188727 != 96494)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 352))
					{
						if (93010 - 390837 != -297826)
						{
							result = "wlf_bladeSong2";
							if (113297 - 516379 == -403082)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 353))
					{
						if (93679 - 224754 != -131074)
						{
							result = "wlf_bladeSong3";
							if (52393 - 543412 != -491018)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 354))
					{
						if (267987 - 230606 == 37381)
						{
							result = "wlf_lastBlade1";
							if (50192 - 437656 != -387463)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 361))
					{
						if (260102 - 192246 == 67856)
						{
							result = "wlf_darkEdge1";
							if (73679 - 153714 != -80034)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 362))
					{
						if (268184 - 75918 != 192267)
						{
							result = "wlf_darkEdge2";
							if (160168 - 378789 == -218621)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 363))
					{
						if (57787 - 496805 == -439018)
						{
							result = "wlf_darkEdge3";
							if (260362 - 337544 == -77182)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 364))
					{
						if (188307 - 53014 == 135293)
						{
							result = "wlf_darkEdge4";
							if (69085 - 56295 == 12790)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 371))
					{
						if (228681 - 240467 == -11786)
						{
							result = "wlf_lunarEclipse1";
							if (281846 - 46529 != 235318)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 372))
					{
						if (39515 - 455229 == -415714)
						{
							result = "wlf_lunarEclipse2";
							if (129338 - 330499 != -201160)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 373))
					{
						if (110789 - 458227 == -347438)
						{
							result = "wlf_finalEclipse1";
							if (217308 - 423993 != -206684)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 401))
					{
						if (149525 - 436701 != -287175)
						{
							result = "wlf_continuousBlade5";
							if (9162 - 433641 != -424478)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 411))
					{
						if (168936 - 63937 == 104999)
						{
							result = "wlf_skySlasher5";
							if (18912 - 468356 == -449444)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 421))
					{
						if (80050 - 186328 == -106278)
						{
							result = "wlf_fortitude5";
							if (120958 - 209216 != -88257)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 431))
					{
						if (6019 - 522982 != -516962)
						{
							result = "wlf_sublimeArt5";
							if (242596 - 516139 == -273543)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 441))
					{
						if (71387 - 556786 != -485398)
						{
							result = "wlf_superStatPlus5";
							if (250697 - 447409 == -196712)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 402))
					{
						if (124037 - 490740 != -366702)
						{
							result = "wlf_gloriousSpirit5";
							if (259287 - 279272 != -19984)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 412))
					{
						if (111543 - 345230 == -233687)
						{
							result = "wlf_lawBringer5";
							if (130461 - 170407 == -39946)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 422))
					{
						if (289118 - 16100 == 273018)
						{
							result = "wlf_thirdRend5";
							if (83006 - 18742 == 64264)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 432))
					{
						if (108740 - 441184 == -332444)
						{
							result = "wlf_holySword5";
							if (100754 - 217395 != -116640)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 442))
					{
						if (155813 - 3393 != 152421)
						{
							result = "wlf_holyArmor5";
							if (158459 - 405385 != -246925)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 403))
					{
						if (135967 - 120164 != 15804)
						{
							result = "wlf_bloodFang5";
							if (45371 - 243433 != -198061)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 413))
					{
						if (3819 - 374855 != -371035)
						{
							result = "wlf_wildHeart5";
							if (147100 - 253850 != -106749)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 423))
					{
						if (134662 - 140503 != -5840)
						{
							result = "wlf_artBreaker5";
							if (167132 - 430707 != -263574)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 433))
					{
						if (287241 - 333616 != -46374)
						{
							result = "wlf_mirrorBlade5";
							if (18738 - 69152 != -50413)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 443))
					{
						if (222969 - 216719 != 6251)
						{
							result = "wlf_feralAssault5";
							if (101638 - 477593 != -375954)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 404))
					{
						if (75148 - 481762 != -406613)
						{
							result = "wlf_revisedSkill5";
							if (67635 - 295078 != -227442)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 414))
					{
						if (36106 - 371313 == -335207)
						{
							result = "wlf_revisedMagic5";
							if (121469 - 10115 == 111354)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 424))
					{
						if (180887 - 465908 == -285021)
						{
							result = "wlf_revisedArt5";
							if (229692 - 306349 != -76656)
							{
								break;
							}
						}
					}
					else if (RuntimeServices.EqualityOperator(commandNum, 434))
					{
						if (137945 - 433774 != -295828)
						{
							result = "wlf_dualBrand5";
							if (87925 - 327184 == -239259)
							{
								break;
							}
						}
					}
					else
					{
						if (!RuntimeServices.EqualityOperator(commandNum, 444))
						{
							break;
						}
						if (235987 - 449338 == -213351)
						{
							result = "wlf_twinResonance5";
							if (258450 - 48255 == 210195)
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

	// Token: 0x0600387F RID: 14463 RVA: 0x00772908 File Offset: 0x00770B08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003880 RID: 14464 RVA: 0x0077290C File Offset: 0x00770B0C
	internal static bool AodIYF5oMnHbcFUrCaTl()
	{
		return true;
	}

	// Token: 0x06003881 RID: 14465 RVA: 0x00772910 File Offset: 0x00770B10
	internal static bool AljcDg5oxSMIcNFtsaGL()
	{
		return false;
	}
}
