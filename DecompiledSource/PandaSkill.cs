using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020007D4 RID: 2004
[Serializable]
public class PandaSkill : MonoBehaviour
{
	// Token: 0x06002C64 RID: 11364 RVA: 0x005814E8 File Offset: 0x0057F6E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PandaSkill()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002C65 RID: 11365 RVA: 0x005814F8 File Offset: 0x0057F6F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSkill(string skillname)
	{
		if (9678 - 295683 != -286005)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (20646 - 22148 == -1502)
			{
				if (239638 - 105317 != 134322)
				{
					if (skillname == "pnd_nAttack1")
					{
						if (81597 - 241357 != -159760)
						{
							continue;
						}
						skillClass.setReq(1, 0);
						if (164799 - 451621 != -286821)
						{
							goto IL_940;
						}
						continue;
					}
					else if (skillname == "pnd_nAttack2")
					{
						if (228221 - 166540 != 61682)
						{
							goto IL_940;
						}
						continue;
					}
					else if (skillname == "pnd_nAttack3")
					{
						if (197172 - 483441 == -286268)
						{
							continue;
						}
					}
					else if (skillname == "pnd_nAttack4")
					{
						if (91984 - 477 != 91508)
						{
							goto IL_8AC;
						}
						continue;
					}
					else
					{
						if (skillname == "pnd_cAttack1")
						{
							if (6607 - 85205 == -78597)
							{
								continue;
							}
							skillClass.setReq(4, 1);
							if (150600 - 371656 != -221056)
							{
								continue;
							}
							goto IL_D9B;
						}
						else if (skillname == "pnd_cAttack2")
						{
							if (80991 - 520193 != -439201)
							{
								goto IL_D9B;
							}
							continue;
						}
						else if (skillname == "pnd_cAttack3")
						{
							if (179330 - 365740 == -186409)
							{
								continue;
							}
						}
						else
						{
							if (skillname == "pnd_roll1")
							{
								if (65913 - 59212 == 6702)
								{
									continue;
								}
								skillClass.setReq(6, 2);
								if (219229 - 289201 != -69972)
								{
									continue;
								}
								skillClass.setSP(-5);
								if (82149 - 240179 == -158029)
								{
									continue;
								}
							}
							else if (skillname == "pnd_roll2")
							{
								if (88397 - 458141 == -369743)
								{
									continue;
								}
							}
							else
							{
								if (skillname == "pnd_resistance1")
								{
									if (186568 - 465584 == -279015)
									{
										continue;
									}
									skillClass.setReq(8, 4);
									if (25438 - 111157 != -85719)
									{
										continue;
									}
									goto IL_21A4;
								}
								else if (skillname == "pnd_resistance2")
								{
									if (232613 - 286479 != -53866)
									{
										continue;
									}
									goto IL_21A4;
								}
								else if (skillname == "pnd_resistance3")
								{
									if (296694 - 553926 != -257232)
									{
										continue;
									}
								}
								else if (skillname == "pnd_resistance4")
								{
									if (37982 - 541451 != -503469)
									{
										continue;
									}
									goto IL_133B;
								}
								else
								{
									if (skillname == "pnd_statPlus1")
									{
										if (103133 - 147372 == -44238)
										{
											continue;
										}
										skillClass.setReq(10, 4);
										if (267162 - 425022 != -157860)
										{
											continue;
										}
										goto IL_1897;
									}
									else if (skillname == "pnd_statPlus2")
									{
										if (251702 - 526624 != -274922)
										{
											continue;
										}
										goto IL_1897;
									}
									else if (skillname == "pnd_statPlus3")
									{
										if (262666 - 329890 != -67224)
										{
											continue;
										}
										goto IL_2040;
									}
									else if (skillname == "pnd_statPlus4")
									{
										if (37939 - 493249 != -455310)
										{
											continue;
										}
									}
									else
									{
										if (skillname == "pnd_threeSteps1")
										{
											if (294423 - 562605 != -268182)
											{
												continue;
											}
											skillClass.setReq(3, 0);
											if (229804 - 489910 == -260105)
											{
												continue;
											}
											skillClass.setSP(12);
											if (107088 - 200717 == -93628)
											{
												continue;
											}
										}
										else if (skillname == "pnd_threeSteps2")
										{
											if (213393 - 531605 != -318212)
											{
												continue;
											}
										}
										else
										{
											if (skillname == "pnd_rushingFalcon1")
											{
												if (167520 - 203834 != -36314)
												{
													continue;
												}
												skillClass.setReq(15, 2);
												if (256471 - 483299 == -226827)
												{
													continue;
												}
												skillClass.setSP(18);
												if (202259 - 410736 == -208476)
												{
													continue;
												}
											}
											else if (skillname == "pnd_rushingFalcon2")
											{
												if (273287 - 311062 != -37775)
												{
													continue;
												}
											}
											else
											{
												if (skillname == "pnd_qiStrike1")
												{
													if (114100 - 453151 != -339051)
													{
														continue;
													}
													skillClass.setReq(5, 1);
													if (240867 - 152638 == 88230)
													{
														continue;
													}
													skillClass.setSP(-15);
													if (263681 - 298456 != -34774)
													{
														goto IL_C80;
													}
													continue;
												}
												else if (skillname == "pnd_qiStrike2")
												{
													if (55409 - 522428 != -467018)
													{
														goto IL_C80;
													}
													continue;
												}
												else if (skillname == "pnd_qiStrike3")
												{
													if (228932 - 44849 == 184084)
													{
														continue;
													}
												}
												else if (skillname == "pnd_delayQi1")
												{
													if (10192 - 304709 == -294516)
													{
														continue;
													}
													skillClass.setReq(23, 7);
													if (12773 - 352573 != -339800)
													{
														continue;
													}
													skillClass.setSP(-24);
													if (124551 - 195002 == -70450)
													{
														continue;
													}
													skillClass.mode = eSkillMode.passive;
													if (168372 - 377422 != -209050)
													{
														continue;
													}
													break;
												}
												else
												{
													if (skillname == "pnd_pummel1")
													{
														if (105008 - 436520 == -331511)
														{
															continue;
														}
														skillClass.setReq(7, 2);
														if (39741 - 380486 == -340744)
														{
															continue;
														}
														skillClass.setSP(-12);
														if (288640 - 365072 != -76432)
														{
															continue;
														}
													}
													else if (skillname == "pnd_pummel2")
													{
														if (98909 - 490376 != -391467)
														{
															continue;
														}
													}
													else
													{
														if (skillname == "pnd_towerRush1")
														{
															if (78454 - 266118 == -187663)
															{
																continue;
															}
															skillClass.setReq(13, 4);
															if (45872 - 565718 != -519846)
															{
																continue;
															}
															skillClass.setSP(-15);
															if (254985 - 506997 != -252012)
															{
																continue;
															}
														}
														else if (skillname == "pnd_towerRush2")
														{
															if (221960 - 503018 != -281058)
															{
																continue;
															}
														}
														else if (skillname == "pnd_tigerToss1")
														{
															if (248758 - 527029 == -278270)
															{
																continue;
															}
															skillClass.setReq(9, 3);
															if (261386 - 137426 != 123960)
															{
																continue;
															}
															skillClass.setSP(12);
															if (120359 - 523263 == -402903)
															{
																continue;
															}
															skillClass.mode = eSkillMode.target;
															if (111074 - 373026 != -261952)
															{
																continue;
															}
															skillClass.target = eSkillTarget.enemy;
															if (185330 - 313706 == -128375)
															{
																continue;
															}
															skillClass.cType = "tigerToss";
															if (77240 - 561299 != -484058)
															{
																break;
															}
															continue;
														}
														else
														{
															if (skillname == "pnd_tigerPounce1")
															{
																if (251620 - 519370 != -267750)
																{
																	continue;
																}
																skillClass.setReq(15, 5);
																if (146797 - 43175 != 103622)
																{
																	continue;
																}
																goto IL_2AC2;
															}
															else if (skillname == "pnd_climbingCliff1")
															{
																if (258430 - 309018 != -50587)
																{
																	goto IL_2AC2;
																}
																continue;
															}
															else if (skillname == "pnd_crumblingMountain1")
															{
																if (85303 - 67577 == 17727)
																{
																	continue;
																}
															}
															else
															{
																if (skillname == "pnd_comboPlus1")
																{
																	if (62998 - 91144 != -28146)
																	{
																		continue;
																	}
																	skillClass.setReq(16, 4);
																	if (195685 - 305879 != -110194)
																	{
																		continue;
																	}
																	goto IL_3461;
																}
																else if (skillname == "pnd_comboPlus2")
																{
																	if (291212 - 448867 != -157655)
																	{
																		continue;
																	}
																	goto IL_3461;
																}
																else if (skillname == "pnd_comboPlus3")
																{
																	if (38228 - 9501 == 28728)
																	{
																		continue;
																	}
																}
																else if (skillname == "pnd_comboPlus4")
																{
																	if (189215 - 103428 != 85788)
																	{
																		goto IL_2E65;
																	}
																	continue;
																}
																else
																{
																	if (skillname == "pnd_risingVortex1")
																	{
																		if (282236 - 241862 != 40374)
																		{
																			continue;
																		}
																		skillClass.setReq(20, 12);
																		if (207640 - 594285 != -386645)
																		{
																			continue;
																		}
																		skillClass.setMPSP(5, 16);
																		if (137234 - 435001 == -297766)
																		{
																			continue;
																		}
																	}
																	else if (skillname == "pnd_risingVortex2")
																	{
																		if (110855 - 569405 == -458549)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (skillname == "pnd_risingDragons1")
																		{
																			if (13907 - 521434 != -507527)
																			{
																				continue;
																			}
																			skillClass.setReq(28, 18);
																			if (185341 - 235565 != -50224)
																			{
																				continue;
																			}
																			skillClass.setMPSP(10, -45);
																			if (8124 - 511666 == -503541)
																			{
																				continue;
																			}
																		}
																		else if (skillname == "pnd_risingDragons2")
																		{
																			if (66216 - 177684 != -111468)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (skillname == "pnd_focusedSpirit1")
																			{
																				if (115611 - 578714 != -463103)
																				{
																					continue;
																				}
																				skillClass.setReq(24, 15);
																				if (282374 - 410010 != -127635)
																				{
																					goto IL_16AB;
																				}
																				continue;
																			}
																			else if (skillname == "pnd_focusedSpirit2")
																			{
																				if (61523 - 244256 != -182732)
																				{
																					goto IL_16AB;
																				}
																				continue;
																			}
																			else if (skillname == "pnd_focusedArt1")
																			{
																				if (172410 - 568741 == -396330)
																				{
																					continue;
																				}
																			}
																			else if (skillname == "pnd_focusedArt2")
																			{
																				if (218632 - 522434 != -303801)
																				{
																					goto IL_2F85;
																				}
																				continue;
																			}
																			else
																			{
																				if (skillname == "pnd_ashura1")
																				{
																					if (116250 - 208777 != -92527)
																					{
																						continue;
																					}
																					skillClass.setReq(35, 23);
																					if (10422 - 565609 != -555187)
																					{
																						continue;
																					}
																					skillClass.setMPSP(25, -90);
																					if (45182 - 21585 == 23598)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "pnd_ashura2")
																				{
																					if (6572 - 192097 == -185524)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					if (skillname == "pnd_drunkenFist1")
																					{
																						if (257613 - 327358 != -69745)
																						{
																							continue;
																						}
																						skillClass.setReq(3, 0);
																						if (168118 - 563822 != -395704)
																						{
																							continue;
																						}
																						skillClass.setMPSP(4, 10);
																						if (18938 - 108791 == -89852)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "pnd_drunkenFist2")
																					{
																						if (1724 - 208303 == -206578)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						if (skillname == "pnd_drunkenPlus1")
																						{
																							if (259590 - 362651 != -103061)
																							{
																								continue;
																							}
																							skillClass.setReq(15, 2);
																							if (99866 - 401021 != -301155)
																							{
																								continue;
																							}
																						}
																						else if (skillname == "pnd_drunkenPlus2")
																						{
																							if (217202 - 103340 != 113862)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							if (skillname == "pnd_waterMonkey1")
																							{
																								if (192023 - 557998 != -365975)
																								{
																									continue;
																								}
																								skillClass.setReq(5, 1);
																								if (176593 - 500723 == -324129)
																								{
																									continue;
																								}
																								skillClass.setSP(12);
																								if (282473 - 556672 != -274199)
																								{
																									continue;
																								}
																							}
																							else if (skillname == "pnd_waterMonkey2")
																							{
																								if (46459 - 334961 == -288501)
																								{
																									continue;
																								}
																							}
																							else
																							{
																								if (skillname == "pnd_waterCrane1")
																								{
																									if (185827 - 578192 != -392365)
																									{
																										continue;
																									}
																									skillClass.setReq(17, 5);
																									if (83698 - 181713 != -98015)
																									{
																										continue;
																									}
																									skillClass.setSP(14);
																									if (159267 - 381447 == -222179)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "pnd_waterCrane2")
																								{
																									if (294793 - 135769 != 159024)
																									{
																										continue;
																									}
																								}
																								else
																								{
																									if (skillname == "pnd_stasisBlow1")
																									{
																										if (115358 - 551861 != -436503)
																										{
																											continue;
																										}
																										skillClass.setReq(7, 2);
																										if (206691 - 190314 != 16377)
																										{
																											continue;
																										}
																										skillClass.setMPSP(10, 10);
																										if (250123 - 227155 == 22969)
																										{
																											continue;
																										}
																									}
																									else if (skillname == "pnd_stasisBlow2")
																									{
																										if (268265 - 413493 != -145228)
																										{
																											continue;
																										}
																									}
																									else
																									{
																										if (skillname == "pnd_deathBlow1")
																										{
																											if (139950 - 531144 == -391193)
																											{
																												continue;
																											}
																											skillClass.setReq(19, 6);
																											if (201197 - 431454 == -230256)
																											{
																												continue;
																											}
																											skillClass.setMPSP(15, 18);
																											if (31440 - 115275 != -83835)
																											{
																												continue;
																											}
																										}
																										else if (skillname == "pnd_deathBlow2")
																										{
																											if (184967 - 88173 == 96795)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											if (skillname == "pnd_shadowFist1")
																											{
																												if (64220 - 430035 == -365814)
																												{
																													continue;
																												}
																												skillClass.setReq(9, 3);
																												if (56988 - 260224 != -203235)
																												{
																													goto IL_BD1;
																												}
																												continue;
																											}
																											else if (skillname == "pnd_shadowFist2")
																											{
																												if (136123 - 184421 != -48297)
																												{
																													goto IL_BD1;
																												}
																												continue;
																											}
																											else if (skillname == "pnd_shadowFist3")
																											{
																												if (11839 - 586946 != -575106)
																												{
																													goto IL_259D;
																												}
																												continue;
																											}
																											else if (skillname == "pnd_shadowFist4")
																											{
																												if (123465 - 399093 != -275628)
																												{
																													continue;
																												}
																											}
																											else
																											{
																												if (skillname == "pnd_spTransfer1")
																												{
																													if (286699 - 227847 == 58853)
																													{
																														continue;
																													}
																													skillClass.setReq(16, 4);
																													if (257540 - 63046 != 194494)
																													{
																														continue;
																													}
																													skillClass.setSP(-15);
																													if (269021 - 68785 != 200236)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "pnd_spTransfer2")
																												{
																													if (105754 - 136878 == -31123)
																													{
																														continue;
																													}
																												}
																												else
																												{
																													if (skillname == "pnd_sacredSageTechnique1")
																													{
																														if (33709 - 261756 == -228046)
																														{
																															continue;
																														}
																														skillClass.setReq(24, 12);
																														if (262465 - 520032 == -257566)
																														{
																															continue;
																														}
																													}
																													else if (skillname == "pnd_sacredSageTechnique2")
																													{
																														if (151071 - 365884 != -214813)
																														{
																															continue;
																														}
																													}
																													else
																													{
																														if (skillname == "pnd_wind&cloud1")
																														{
																															if (220832 - 503682 == -282849)
																															{
																																continue;
																															}
																															skillClass.setReq(20, 12);
																															if (41290 - 44773 == -3482)
																															{
																																continue;
																															}
																															skillClass.setMPSP(10, -20);
																															if (59225 - 565524 != -506299)
																															{
																																continue;
																															}
																														}
																														else if (skillname == "pnd_wind&cloud2")
																														{
																															if (251854 - 424241 == -172386)
																															{
																																continue;
																															}
																														}
																														else
																														{
																															if (skillname == "pnd_rain&storm1")
																															{
																																if (157086 - 579181 != -422095)
																																{
																																	continue;
																																}
																																skillClass.setReq(28, 18);
																																if (293750 - 70073 != 223677)
																																{
																																	continue;
																																}
																																skillClass.setMPSP(15, -32);
																																if (214698 - 60291 == 154408)
																																{
																																	continue;
																																}
																															}
																															else if (skillname == "pnd_rain&storm2")
																															{
																																if (55099 - 122595 == -67495)
																																{
																																	continue;
																																}
																															}
																															else
																															{
																																if (skillname == "pnd_lotusPalm1")
																																{
																																	if (204820 - 28543 != 176277)
																																	{
																																		continue;
																																	}
																																	skillClass.setReq(24, 15);
																																	if (62684 - 393132 != -330448)
																																	{
																																		continue;
																																	}
																																	skillClass.setMPSP(7, -30);
																																	if (210284 - 250011 != -39727)
																																	{
																																		continue;
																																	}
																																}
																																else if (skillname == "pnd_lotusPalm2")
																																{
																																	if (158997 - 445455 == -286457)
																																	{
																																		continue;
																																	}
																																}
																																else
																																{
																																	if (skillname == "pnd_heavenPalm1")
																																	{
																																		if (201200 - 50669 == 150532)
																																		{
																																			continue;
																																		}
																																		skillClass.setReq(30, 21);
																																		if (23568 - 133767 != -110199)
																																		{
																																			continue;
																																		}
																																		skillClass.setMPSP(23, -60);
																																		if (110211 - 411279 != -301068)
																																		{
																																			continue;
																																		}
																																	}
																																	else if (skillname == "pnd_heavenPalm2")
																																	{
																																		if (213198 - 327483 == -114284)
																																		{
																																			continue;
																																		}
																																	}
																																	else
																																	{
																																		if (skillname == "pnd_mysticSage1")
																																		{
																																			if (49374 - 406271 != -356897)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(35, 23);
																																			if (29637 - 144792 != -115155)
																																			{
																																				continue;
																																			}
																																		}
																																		else if (skillname == "pnd_mysticSage2")
																																		{
																																			if (762 - 173501 == -172738)
																																			{
																																				continue;
																																			}
																																		}
																																		else if (skillname == "pnd_auraBlast5")
																																		{
																																			if (68759 - 267108 == -198348)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(55, 0);
																																			if (256136 - 314320 != -58184)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (180482 - 485606 == -305123)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 104;
																																			if (41122 - 377691 != -336569)
																																			{
																																				continue;
																																			}
																																			break;
																																		}
																																		else if (skillname == "pnd_auraField5")
																																		{
																																			if (258143 - 162509 != 95634)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(60, 1);
																																			if (261279 - 153099 != 108180)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (185484 - 552274 != -366790)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 113;
																																			if (103158 - 582845 != -479686)
																																			{
																																				break;
																																			}
																																			continue;
																																		}
																																		else if (skillname == "pnd_rollAround5")
																																		{
																																			if (68233 - 206716 == -138482)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(70, 3);
																																			if (169912 - 235570 != -65658)
																																			{
																																				continue;
																																			}
																																			skillClass.setMPSP(6, -24);
																																			if (89213 - 117964 != -28751)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.instant;
																																			if (146479 - 129065 == 17415)
																																			{
																																				continue;
																																			}
																																			skillClass.target = eSkillTarget.self;
																																			if (167145 - 10115 != 157030)
																																			{
																																				continue;
																																			}
																																			skillClass.cType = "roll";
																																			if (187601 - 80366 != 107235)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 122;
																																			if (34798 - 31522 != 3276)
																																			{
																																				continue;
																																			}
																																			break;
																																		}
																																		else if (skillname == "pnd_safeGuard5")
																																		{
																																			if (60460 - 376817 == -316356)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(75, 4);
																																			if (140152 - 584095 == -443942)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (231179 - 278988 == -47808)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 134;
																																			if (73916 - 475630 != -401713)
																																			{
																																				break;
																																			}
																																			continue;
																																		}
																																		else if (skillname == "pnd_superStatPlus5")
																																		{
																																			if (145696 - 508186 != -362490)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(85, 6);
																																			if (109082 - 449001 == -339918)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (157703 - 264782 != -107079)
																																			{
																																				continue;
																																			}
																																			skillClass.target = eSkillTarget.self;
																																			if (139095 - 241658 == -102562)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 144;
																																			if (206516 - 170912 != 35604)
																																			{
																																				continue;
																																			}
																																			break;
																																		}
																																		else if (skillname == "pnd_nineSteps5")
																																		{
																																			if (181819 - 584506 != -402687)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(55, 0);
																																			if (214362 - 47597 != 166765)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (27054 - 454515 != -427461)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 204;
																																			if (214734 - 37987 != 176747)
																																			{
																																				continue;
																																			}
																																			break;
																																		}
																																		else if (skillname == "pnd_qiBurst5")
																																		{
																																			if (276723 - 429237 != -152514)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(60, 1);
																																			if (91533 - 436422 == -344888)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (179857 - 26755 == 153103)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 214;
																																			if (215939 - 574221 != -358281)
																																			{
																																				break;
																																			}
																																			continue;
																																		}
																																		else if (skillname == "pnd_ogreImpact5")
																																		{
																																			if (136910 - 548834 != -411924)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(70, 3);
																																			if (113642 - 415184 == -301541)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (274747 - 166659 == 108089)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 224;
																																			if (4731 - 275175 != -270444)
																																			{
																																				continue;
																																			}
																																			break;
																																		}
																																		else if (skillname == "pnd_crushingMonolith5")
																																		{
																																			if (9140 - 184611 != -175471)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(75, 4);
																																			if (140034 - 50026 == 90009)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (186664 - 72122 == 114543)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 234;
																																			if (113966 - 418770 != -304804)
																																			{
																																				continue;
																																			}
																																			break;
																																		}
																																		else if (skillname == "pnd_comboLink5")
																																		{
																																			if (88843 - 94035 != -5192)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(85, 6);
																																			if (141744 - 420349 != -278605)
																																			{
																																				continue;
																																			}
																																			skillClass.setSP(-50);
																																			if (173365 - 171382 == 1984)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.instant;
																																			if (93424 - 218029 == -124604)
																																			{
																																				continue;
																																			}
																																			skillClass.target = eSkillTarget.self;
																																			if (163863 - 8524 != 155339)
																																			{
																																				continue;
																																			}
																																			skillClass.cType = "comboLink";
																																			if (215390 - 359842 == -144451)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 244;
																																			if (30233 - 470458 != -440225)
																																			{
																																				continue;
																																			}
																																			break;
																																		}
																																		else if (skillname == "pnd_drunkenSpin5")
																																		{
																																			if (20332 - 254210 == -233877)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(55, 0);
																																			if (237231 - 55547 == 181685)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (221532 - 22687 != 198845)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 304;
																																			if (240885 - 84810 != 156075)
																																			{
																																				continue;
																																			}
																																			break;
																																		}
																																		else if (skillname == "pnd_timeAndTide5")
																																		{
																																			if (32785 - 390026 == -357240)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(60, 1);
																																			if (9554 - 457997 != -448443)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (115020 - 193154 == -78133)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 314;
																																			if (126124 - 141187 != -15063)
																																			{
																																				continue;
																																			}
																																			break;
																																		}
																																		else if (skillname == "pnd_windWalker5")
																																		{
																																			if (221470 - 503518 == -282047)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(70, 3);
																																			if (111887 - 24220 == 87668)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (78529 - 486749 == -408219)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 324;
																																			if (218757 - 528296 != -309538)
																																			{
																																				break;
																																			}
																																			continue;
																																		}
																																		else if (skillname == "pnd_spiritFist5")
																																		{
																																			if (50107 - 571169 == -521061)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(75, 4);
																																			if (264846 - 510608 == -245761)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (247020 - 122877 != 124143)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 334;
																																			if (192923 - 88711 != 104213)
																																			{
																																				break;
																																			}
																																			continue;
																																		}
																																		else if (skillname == "pnd_heavenBreath5")
																																		{
																																			if (250776 - 280772 == -29995)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(85, 6);
																																			if (204788 - 330721 != -125933)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (239582 - 243728 != -4146)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 334;
																																			if (179838 - 510357 != -330518)
																																			{
																																				break;
																																			}
																																			continue;
																																		}
																																		else if (skillname == "pnd_revisedSkill5")
																																		{
																																			if (256334 - 566738 == -310403)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(55, 0);
																																			if (112758 - 195685 == -82926)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (52935 - 321477 != -268542)
																																			{
																																				continue;
																																			}
																																			break;
																																		}
																																		else if (skillname == "pnd_revisedMagic5")
																																		{
																																			if (155882 - 469082 == -313199)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(60, 1);
																																			if (144495 - 505505 == -361009)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (172196 - 308890 != -136693)
																																			{
																																				break;
																																			}
																																			continue;
																																		}
																																		else if (skillname == "pnd_revisedArt5")
																																		{
																																			if (126483 - 296664 == -170180)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(70, 3);
																																			if (192986 - 438878 != -245892)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.passive;
																																			if (133812 - 380518 != -246705)
																																			{
																																				break;
																																			}
																																			continue;
																																		}
																																		else if (skillname == "pnd_fuujinKen5")
																																		{
																																			if (287598 - 581674 == -294075)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(75, 4);
																																			if (12134 - 397425 != -385291)
																																			{
																																				continue;
																																			}
																																			skillClass.setMPSP(50, -70);
																																			if (56325 - 553813 == -497487)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.instant;
																																			if (293070 - 172051 != 121019)
																																			{
																																				continue;
																																			}
																																			skillClass.target = eSkillTarget.enemy;
																																			if (122485 - 76376 != 46109)
																																			{
																																				continue;
																																			}
																																			skillClass.cType = "fuujinKen";
																																			if (18926 - 196442 == -177515)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 251351;
																																			if (118340 - 152942 != -34602)
																																			{
																																				continue;
																																			}
																																			break;
																																		}
																																		else
																																		{
																																			if (!(skillname == "pnd_raijinKen5"))
																																			{
																																				break;
																																			}
																																			if (163581 - 114550 != 49031)
																																			{
																																				continue;
																																			}
																																			skillClass.setReq(85, 6);
																																			if (73548 - 8417 == 65132)
																																			{
																																				continue;
																																			}
																																			skillClass.setMPSP(70, -90);
																																			if (236377 - 558527 == -322149)
																																			{
																																				continue;
																																			}
																																			skillClass.mode = eSkillMode.target;
																																			if (6059 - 240056 == -233996)
																																			{
																																				continue;
																																			}
																																			skillClass.target = eSkillTarget.enemy;
																																			if (111129 - 11064 != 100065)
																																			{
																																				continue;
																																			}
																																			skillClass.cType = "raijinKen";
																																			if (89553 - 429541 == -339987)
																																			{
																																				continue;
																																			}
																																			skillClass.rSkill = 434;
																																			if (250479 - 450017 != -199537)
																																			{
																																				break;
																																			}
																																			continue;
																																		}
																																		skillClass.setReq(40, 25);
																																		if (154010 - 428390 == -274379)
																																		{
																																			continue;
																																		}
																																		skillClass.mode = eSkillMode.passive;
																																		if (29783 - 588417 != -558634)
																																		{
																																			continue;
																																		}
																																		break;
																																	}
																																	skillClass.setReq(33, 24);
																																	if (214382 - 256483 != -42101)
																																	{
																																		continue;
																																	}
																																	skillClass.setMPSP(23, -75);
																																	if (242908 - 594648 == -351739)
																																	{
																																		continue;
																																	}
																																	skillClass.mode = eSkillMode.target;
																																	if (106943 - 497969 != -391026)
																																	{
																																		continue;
																																	}
																																	skillClass.target = eSkillTarget.enemy;
																																	if (74684 - 276145 != -201461)
																																	{
																																		continue;
																																	}
																																	skillClass.cType = "heavenPalm";
																																	if (183999 - 289213 != -105213)
																																	{
																																		break;
																																	}
																																	continue;
																																}
																																skillClass.setReq(27, 18);
																																if (130399 - 311933 != -181534)
																																{
																																	continue;
																																}
																																skillClass.setMPSP(7, -35);
																																if (183007 - 456538 == -273530)
																																{
																																	continue;
																																}
																																skillClass.mode = eSkillMode.target;
																																if (110543 - 354029 != -243486)
																																{
																																	continue;
																																}
																																skillClass.target = eSkillTarget.enemy;
																																if (104497 - 384099 == -279601)
																																{
																																	continue;
																																}
																																skillClass.cType = "lotusPalm";
																																if (150182 - 315892 != -165709)
																																{
																																	break;
																																}
																																continue;
																															}
																															skillClass.setReq(30, 21);
																															if (138446 - 292401 != -153955)
																															{
																																continue;
																															}
																															skillClass.setMPSP(15, -40);
																															if (246520 - 311713 == -65192)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.instant;
																															if (221201 - 318337 != -97136)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (258355 - 267519 != -9164)
																															{
																																continue;
																															}
																															skillClass.cType = "rain&storm";
																															if (153680 - 551677 != -397996)
																															{
																																break;
																															}
																															continue;
																														}
																														skillClass.setReq(24, 15);
																														if (271211 - 237206 == 34006)
																														{
																															continue;
																														}
																														skillClass.setMPSP(10, -24);
																														if (136930 - 550592 != -413662)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.instant;
																														if (256666 - 247236 == 9431)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.enemy;
																														if (266918 - 50482 != 216436)
																														{
																															continue;
																														}
																														skillClass.cType = "wind&cloud";
																														if (109596 - 351838 != -242242)
																														{
																															continue;
																														}
																														break;
																													}
																													skillClass.setReq(28, 16);
																													if (31336 - 474211 == -442874)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (167709 - 285638 != -117929)
																													{
																														continue;
																													}
																													break;
																												}
																												skillClass.setReq(20, 8);
																												if (156267 - 105274 != 50993)
																												{
																													continue;
																												}
																												skillClass.setSP(-30);
																												if (74629 - 271336 == -196706)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.target;
																												if (210849 - 574972 == -364122)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.ally;
																												if (76869 - 351975 != -275106)
																												{
																													continue;
																												}
																												skillClass.cType = "spTransfer";
																												if (16185 - 335674 != -319489)
																												{
																													continue;
																												}
																												break;
																											}
																											IL_4B0:
																											skillClass.setReq(27, 9);
																											if (197011 - 65547 != 131464)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.passive;
																											if (295812 - 437825 != -142013)
																											{
																												continue;
																											}
																											break;
																											IL_BD1:
																											skillClass.setReq(15, 5);
																											if (83015 - 279932 == -196916)
																											{
																												continue;
																											}
																											IL_259D:
																											skillClass.setReq(21, 7);
																											if (208220 - 244761 != -36540)
																											{
																												goto IL_4B0;
																											}
																											continue;
																										}
																										skillClass.setReq(25, 8);
																										if (43862 - 36977 == 6886)
																										{
																											continue;
																										}
																										skillClass.setMPSP(20, 24);
																										if (276630 - 392114 != -115484)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.target;
																										if (99349 - 484831 != -385482)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.enemy;
																										if (187495 - 570005 == -382509)
																										{
																											continue;
																										}
																										skillClass.cType = "deathBlow";
																										if (117024 - 9852 != 107172)
																										{
																											continue;
																										}
																										break;
																									}
																									skillClass.setReq(13, 4);
																									if (157522 - 134536 != 22986)
																									{
																										continue;
																									}
																									skillClass.setMPSP(15, 15);
																									if (182674 - 160652 != 22022)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.target;
																									if (129478 - 589095 == -459616)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.enemy;
																									if (43290 - 407158 != -363868)
																									{
																										continue;
																									}
																									skillClass.cType = "stasisBlow";
																									if (295959 - 224986 != 70973)
																									{
																										continue;
																									}
																									break;
																								}
																								skillClass.setReq(23, 7);
																								if (22685 - 368111 != -345426)
																								{
																									continue;
																								}
																								skillClass.setSP(18);
																								if (72577 - 571656 != -499079)
																								{
																									continue;
																								}
																								skillClass.mode = eSkillMode.instant;
																								if (139087 - 143359 == -4271)
																								{
																									continue;
																								}
																								skillClass.target = eSkillTarget.enemy;
																								if (299834 - 22974 != 276860)
																								{
																									continue;
																								}
																								skillClass.cType = "waterCrane";
																								if (271930 - 472447 != -200516)
																								{
																									break;
																								}
																								continue;
																							}
																							skillClass.setReq(11, 3);
																							if (283713 - 595106 == -311392)
																							{
																								continue;
																							}
																							skillClass.setSP(16);
																							if (22746 - 116494 == -93747)
																							{
																								continue;
																							}
																							skillClass.mode = eSkillMode.instant;
																							if (42652 - 296134 != -253482)
																							{
																								continue;
																							}
																							skillClass.target = eSkillTarget.enemy;
																							if (42253 - 99923 != -57670)
																							{
																								continue;
																							}
																							skillClass.cType = "waterMonkey";
																							if (275905 - 445277 != -169372)
																							{
																								continue;
																							}
																							break;
																						}
																						skillClass.setReq(21, 3);
																						if (99739 - 93833 == 5907)
																						{
																							continue;
																						}
																						skillClass.mode = eSkillMode.passive;
																						if (22759 - 386480 != -363721)
																						{
																							continue;
																						}
																						break;
																					}
																					skillClass.setReq(9, 1);
																					if (6423 - 450915 == -444491)
																					{
																						continue;
																					}
																					skillClass.setMPSP(6, 12);
																					if (245628 - 34276 != 211352)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.instant;
																					if (272946 - 550539 != -277593)
																					{
																						continue;
																					}
																					skillClass.target = eSkillTarget.enemy;
																					if (233148 - 298205 == -65056)
																					{
																						continue;
																					}
																					skillClass.cType = "drunkenFist";
																					if (107535 - 140921 != -33386)
																					{
																						continue;
																					}
																					break;
																				}
																				skillClass.setReq(40, 25);
																				if (115781 - 432726 != -316945)
																				{
																					continue;
																				}
																				skillClass.setMPSP(35, -90);
																				if (156896 - 304347 == -147450)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.instant;
																				if (102612 - 450850 == -348237)
																				{
																					continue;
																				}
																				skillClass.target = eSkillTarget.self;
																				if (186809 - 170049 != 16760)
																				{
																					continue;
																				}
																				skillClass.cType = "ashura";
																				if (68176 - 554285 != -486108)
																				{
																					break;
																				}
																				continue;
																			}
																			IL_BAD:
																			skillClass.setReq(30, 21);
																			if (288951 - 357939 != -68988)
																			{
																				continue;
																			}
																			goto IL_2F85;
																			IL_16AB:
																			skillClass.setReq(27, 18);
																			if (96123 - 360841 != -264717)
																			{
																				goto IL_BAD;
																			}
																			continue;
																			IL_2F85:
																			skillClass.setReq(33, 24);
																			if (268010 - 510218 != -242208)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.passive;
																			if (197691 - 493491 != -295799)
																			{
																				break;
																			}
																			continue;
																		}
																		skillClass.setReq(32, 21);
																		if (188896 - 346311 != -157415)
																		{
																			continue;
																		}
																		skillClass.setMPSP(10, -60);
																		if (128263 - 159405 != -31142)
																		{
																			continue;
																		}
																		skillClass.mode = eSkillMode.instant;
																		if (178082 - 242552 != -64470)
																		{
																			continue;
																		}
																		skillClass.target = eSkillTarget.enemy;
																		if (260713 - 594815 == -334101)
																		{
																			continue;
																		}
																		skillClass.cType = "risingDragons";
																		if (76586 - 194100 != -117513)
																		{
																			break;
																		}
																		continue;
																	}
																	skillClass.setReq(24, 15);
																	if (120544 - 599669 != -479125)
																	{
																		continue;
																	}
																	skillClass.setMPSP(5, 18);
																	if (32868 - 339711 != -306843)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.instant;
																	if (249498 - 402041 != -152543)
																	{
																		continue;
																	}
																	skillClass.target = eSkillTarget.enemy;
																	if (222386 - 203099 != 19287)
																	{
																		continue;
																	}
																	skillClass.cType = "risingVortex";
																	if (41743 - 428217 != -386474)
																	{
																		continue;
																	}
																	break;
																}
																IL_66D:
																skillClass.setReq(24, 12);
																if (282786 - 96059 == 186728)
																{
																	continue;
																}
																IL_2E65:
																skillClass.setReq(28, 16);
																if (238854 - 522900 != -284046)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.passive;
																if (162907 - 500422 != -337515)
																{
																	continue;
																}
																break;
																IL_3461:
																skillClass.setReq(20, 8);
																if (99088 - 411888 != -312799)
																{
																	goto IL_66D;
																}
																continue;
															}
															IL_1B9F:
															skillClass.setReq(27, 9);
															if (152495 - 365778 == -213282)
															{
																continue;
															}
															skillClass.mode = eSkillMode.passive;
															if (101407 - 520640 != -419232)
															{
																break;
															}
															continue;
															IL_2AC2:
															skillClass.setReq(21, 7);
															if (181612 - 264359 != -82747)
															{
																continue;
															}
															goto IL_1B9F;
														}
														skillClass.setReq(25, 8);
														if (200156 - 204208 != -4052)
														{
															continue;
														}
														skillClass.setSP(-20);
														if (120179 - 399646 == -279466)
														{
															continue;
														}
														skillClass.mode = eSkillMode.instant;
														if (34833 - 55563 != -20730)
														{
															continue;
														}
														skillClass.target = eSkillTarget.enemy;
														if (106315 - 324667 != -218352)
														{
															continue;
														}
														skillClass.cType = "towerRush";
														if (15559 - 340961 != -325401)
														{
															break;
														}
														continue;
													}
													skillClass.setReq(19, 6);
													if (284379 - 370888 == -86508)
													{
														continue;
													}
													skillClass.setSP(-16);
													if (69255 - 346925 != -277670)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (175954 - 234980 != -59026)
													{
														continue;
													}
													skillClass.target = eSkillTarget.enemy;
													if (133177 - 471089 != -337912)
													{
														continue;
													}
													skillClass.cType = "pummel";
													if (52019 - 276243 != -224224)
													{
														continue;
													}
													break;
												}
												IL_6DA:
												skillClass.setReq(17, 5);
												if (216997 - 381530 == -164532)
												{
													continue;
												}
												skillClass.setSP(-21);
												if (42807 - 451752 != -408945)
												{
													continue;
												}
												skillClass.mode = eSkillMode.instant;
												if (286609 - 555660 == -269050)
												{
													continue;
												}
												skillClass.target = eSkillTarget.enemy;
												if (39671 - 156099 != -116428)
												{
													continue;
												}
												skillClass.cType = "qiStrike";
												if (10621 - 587558 != -576936)
												{
													break;
												}
												continue;
												IL_C80:
												skillClass.setReq(11, 3);
												if (288565 - 364864 == -76298)
												{
													continue;
												}
												skillClass.setSP(-18);
												if (233216 - 450229 != -217012)
												{
													goto IL_6DA;
												}
												continue;
											}
											skillClass.setReq(21, 3);
											if (277846 - 390398 != -112552)
											{
												continue;
											}
											skillClass.setSP(22);
											if (161769 - 383560 != -221791)
											{
												continue;
											}
											skillClass.mode = eSkillMode.instant;
											if (106712 - 323217 != -216505)
											{
												continue;
											}
											skillClass.target = eSkillTarget.enemy;
											if (215147 - 338334 == -123186)
											{
												continue;
											}
											skillClass.cType = "rushingFalcon";
											if (233993 - 480283 != -246289)
											{
												break;
											}
											continue;
										}
										skillClass.setReq(9, 1);
										if (182539 - 559593 != -377054)
										{
											continue;
										}
										skillClass.setSP(15);
										if (310 - 435127 != -434817)
										{
											continue;
										}
										skillClass.mode = eSkillMode.instant;
										if (64370 - 99040 == -34669)
										{
											continue;
										}
										skillClass.target = eSkillTarget.enemy;
										if (215543 - 561817 != -346274)
										{
											continue;
										}
										skillClass.cType = "threeSteps";
										if (131932 - 427651 != -295719)
										{
											continue;
										}
										break;
									}
									IL_BF:
									skillClass.setReq(40, 10);
									if (35995 - 451951 != -415956)
									{
										continue;
									}
									skillClass.mode = eSkillMode.passive;
									if (163405 - 108789 != 54616)
									{
										continue;
									}
									skillClass.target = eSkillTarget.self;
									if (204147 - 391521 != -187373)
									{
										break;
									}
									continue;
									IL_2040:
									skillClass.setReq(30, 8);
									if (177157 - 200828 != -23671)
									{
										continue;
									}
									goto IL_BF;
									IL_1897:
									skillClass.setReq(20, 6);
									if (35368 - 301965 != -266597)
									{
										continue;
									}
									goto IL_2040;
								}
								IL_7F4:
								skillClass.setReq(24, 8);
								if (89728 - 524523 == -434794)
								{
									continue;
								}
								IL_133B:
								skillClass.setReq(32, 10);
								if (243822 - 440851 == -197028)
								{
									continue;
								}
								skillClass.mode = eSkillMode.passive;
								if (263309 - 186910 != 76400)
								{
									break;
								}
								continue;
								IL_21A4:
								skillClass.setReq(16, 6);
								if (111959 - 225196 != -113236)
								{
									goto IL_7F4;
								}
								continue;
							}
							skillClass.setReq(12, 4);
							if (165249 - 418215 == -252965)
							{
								continue;
							}
							skillClass.setSP(-8);
							if (4668 - 348595 != -343927)
							{
								continue;
							}
							skillClass.mode = eSkillMode.instant;
							if (207692 - 255786 != -48094)
							{
								continue;
							}
							skillClass.target = eSkillTarget.self;
							if (261647 - 427973 == -166325)
							{
								continue;
							}
							skillClass.cType = "roll";
							if (231534 - 126310 != 105224)
							{
								continue;
							}
							break;
						}
						IL_2EFC:
						skillClass.setReq(16, 3);
						if (85142 - 548363 != -463221)
						{
							continue;
						}
						skillClass.mode = eSkillMode.passive;
						if (112829 - 49505 != 63325)
						{
							break;
						}
						continue;
						IL_D9B:
						skillClass.setReq(10, 2);
						if (248703 - 280190 != -31487)
						{
							continue;
						}
						goto IL_2EFC;
					}
					IL_292:
					skillClass.setReq(3, 0);
					if (36667 - 447672 == -411004)
					{
						continue;
					}
					IL_8AC:
					skillClass.setReq(4, 0);
					if (128426 - 491102 != -362676)
					{
						continue;
					}
					skillClass.mode = eSkillMode.passive;
					if (289471 - 83875 == 205597)
					{
						continue;
					}
					skillClass.target = eSkillTarget.enemy;
					if (172465 - 163169 != 9296)
					{
						continue;
					}
					skillClass.cType = "nAttack";
					if (6905 - 475583 != -468677)
					{
						break;
					}
					continue;
					IL_940:
					skillClass.setReq(2, 0);
					if (49409 - 50314 != -904)
					{
						goto IL_292;
					}
				}
			}
		}
		return skillClass;
	}

	// Token: 0x06002C66 RID: 11366 RVA: 0x00584AE8 File Offset: 0x00582CE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillTree(int commandNum)
	{
		if (169692 - 9870 != 159822)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (270029 - 60213 != 209817)
			{
				if (291731 - 283629 == 8102)
				{
					if (commandNum == 101)
					{
						if (222120 - 469995 == -247875)
						{
							result = "pnd_nAttack1";
							if (20730 - 576268 == -555538)
							{
								break;
							}
						}
					}
					else if (commandNum == 102)
					{
						if (147252 - 546529 != -399276)
						{
							result = "pnd_nAttack2";
							if (46962 - 253038 == -206076)
							{
								break;
							}
						}
					}
					else if (commandNum == 103)
					{
						if (171789 - 83400 == 88389)
						{
							result = "pnd_nAttack3";
							if (294130 - 396208 == -102078)
							{
								break;
							}
						}
					}
					else if (commandNum == 104)
					{
						if (167154 - 362739 != -195584)
						{
							result = "pnd_nAttack4";
							if (284193 - 225511 != 58683)
							{
								break;
							}
						}
					}
					else if (commandNum == 111)
					{
						if (51520 - 486086 == -434566)
						{
							result = "pnd_cAttack1";
							if (93911 - 481650 != -387738)
							{
								break;
							}
						}
					}
					else if (commandNum == 112)
					{
						if (152352 - 473188 != -320835)
						{
							result = "pnd_cAttack2";
							if (51360 - 393079 != -341718)
							{
								break;
							}
						}
					}
					else if (commandNum == 113)
					{
						if (61891 - 303983 != -242091)
						{
							result = "pnd_cAttack3";
							if (272528 - 223703 == 48825)
							{
								break;
							}
						}
					}
					else if (commandNum == 121)
					{
						if (59515 - 406040 != -346524)
						{
							result = "pnd_roll1";
							if (94438 - 97726 != -3287)
							{
								break;
							}
						}
					}
					else if (commandNum == 122)
					{
						if (77350 - 379625 != -302274)
						{
							result = "pnd_roll2";
							if (198171 - 540941 != -342769)
							{
								break;
							}
						}
					}
					else if (commandNum == 131)
					{
						if (1805 - 262638 == -260833)
						{
							result = "pnd_resistance1";
							if (227722 - 340907 == -113185)
							{
								break;
							}
						}
					}
					else if (commandNum == 132)
					{
						if (255684 - 335428 == -79744)
						{
							result = "pnd_resistance2";
							if (21441 - 416328 == -394887)
							{
								break;
							}
						}
					}
					else if (commandNum == 133)
					{
						if (243010 - 305716 == -62706)
						{
							result = "pnd_resistance3";
							if (289260 - 474909 != -185648)
							{
								break;
							}
						}
					}
					else if (commandNum == 134)
					{
						if (46311 - 299652 == -253341)
						{
							result = "pnd_resistance4";
							if (204958 - 408103 == -203145)
							{
								break;
							}
						}
					}
					else if (commandNum == 141)
					{
						if (231036 - 159960 != 71077)
						{
							result = "pnd_statPlus1";
							if (188327 - 193080 != -4752)
							{
								break;
							}
						}
					}
					else if (commandNum == 142)
					{
						if (274977 - 557569 == -282592)
						{
							result = "pnd_statPlus2";
							if (244132 - 54573 == 189559)
							{
								break;
							}
						}
					}
					else if (commandNum == 143)
					{
						if (216837 - 571178 == -354341)
						{
							result = "pnd_statPlus3";
							if (164596 - 268158 == -103562)
							{
								break;
							}
						}
					}
					else if (commandNum == 144)
					{
						if (200764 - 307332 != -106567)
						{
							result = "pnd_statPlus4";
							if (208645 - 352323 == -143678)
							{
								break;
							}
						}
					}
					else if (commandNum == 201)
					{
						if (276177 - 5632 != 270546)
						{
							result = "pnd_threeSteps1";
							if (273044 - 219368 != 53677)
							{
								break;
							}
						}
					}
					else if (commandNum == 202)
					{
						if (144369 - 259926 != -115556)
						{
							result = "pnd_threeSteps2";
							if (49365 - 521824 == -472459)
							{
								break;
							}
						}
					}
					else if (commandNum == 203)
					{
						if (171143 - 167319 == 3824)
						{
							result = "pnd_rushingFalcon1";
							if (261420 - 62779 == 198641)
							{
								break;
							}
						}
					}
					else if (commandNum == 204)
					{
						if (130768 - 41710 != 89059)
						{
							result = "pnd_rushingFalcon2";
							if (201537 - 269483 != -67945)
							{
								break;
							}
						}
					}
					else if (commandNum == 211)
					{
						if (123910 - 52186 != 71725)
						{
							result = "pnd_qiStrike1";
							if (18210 - 307591 == -289381)
							{
								break;
							}
						}
					}
					else if (commandNum == 212)
					{
						if (138819 - 95622 == 43197)
						{
							result = "pnd_qiStrike2";
							if (252193 - 24153 != 228041)
							{
								break;
							}
						}
					}
					else if (commandNum == 213)
					{
						if (62180 - 154000 != -91819)
						{
							result = "pnd_qiStrike3";
							if (229791 - 330974 != -101182)
							{
								break;
							}
						}
					}
					else if (commandNum == 214)
					{
						if (110622 - 106067 != 4556)
						{
							result = "pnd_delayQi1";
							if (298021 - 333737 != -35715)
							{
								break;
							}
						}
					}
					else if (commandNum == 221)
					{
						if (174444 - 47004 == 127440)
						{
							result = "pnd_pummel1";
							if (212045 - 599712 == -387667)
							{
								break;
							}
						}
					}
					else if (commandNum == 222)
					{
						if (57602 - 47389 == 10213)
						{
							result = "pnd_towerRush1";
							if (112946 - 249790 == -136844)
							{
								break;
							}
						}
					}
					else if (commandNum == 223)
					{
						if (227570 - 395367 == -167797)
						{
							result = "pnd_pummel2";
							if (287464 - 442773 != -155308)
							{
								break;
							}
						}
					}
					else if (commandNum == 224)
					{
						if (159868 - 41557 == 118311)
						{
							result = "pnd_towerRush2";
							if (264666 - 123294 == 141372)
							{
								break;
							}
						}
					}
					else if (commandNum == 231)
					{
						if (7824 - 103993 == -96169)
						{
							result = "pnd_tigerToss1";
							if (154200 - 562007 == -407807)
							{
								break;
							}
						}
					}
					else if (commandNum == 232)
					{
						if (197595 - 316568 != -118972)
						{
							result = "pnd_tigerPounce1";
							if (264207 - 382046 != -117838)
							{
								break;
							}
						}
					}
					else if (commandNum == 233)
					{
						if (17258 - 169553 == -152295)
						{
							result = "pnd_climbingCliff1";
							if (202368 - 263829 == -61461)
							{
								break;
							}
						}
					}
					else if (commandNum == 234)
					{
						if (178912 - 426507 == -247595)
						{
							result = "pnd_crumblingMountain1";
							if (69669 - 456848 != -387178)
							{
								break;
							}
						}
					}
					else if (commandNum == 241)
					{
						if (36343 - 431695 == -395352)
						{
							result = "pnd_comboPlus1";
							if (123460 - 256675 != -133214)
							{
								break;
							}
						}
					}
					else if (commandNum == 242)
					{
						if (286239 - 184454 != 101786)
						{
							result = "pnd_comboPlus2";
							if (59782 - 469089 != -409306)
							{
								break;
							}
						}
					}
					else if (commandNum == 243)
					{
						if (12264 - 87168 != -74903)
						{
							result = "pnd_comboPlus3";
							if (128793 - 516668 == -387875)
							{
								break;
							}
						}
					}
					else if (commandNum == 244)
					{
						if (114804 - 128750 != -13945)
						{
							result = "pnd_comboPlus4";
							if (277650 - 116691 != 160960)
							{
								break;
							}
						}
					}
					else if (commandNum == 251)
					{
						if (128828 - 559088 != -430259)
						{
							result = "pnd_risingVortex1";
							if (114106 - 272826 == -158720)
							{
								break;
							}
						}
					}
					else if (commandNum == 252)
					{
						if (164334 - 63366 == 100968)
						{
							result = "pnd_risingVortex2";
							if (254692 - 334295 != -79602)
							{
								break;
							}
						}
					}
					else if (commandNum == 253)
					{
						if (130102 - 13828 == 116274)
						{
							result = "pnd_risingDragons1";
							if (161055 - 480732 == -319677)
							{
								break;
							}
						}
					}
					else if (commandNum == 254)
					{
						if (290404 - 14618 == 275786)
						{
							result = "pnd_risingDragons2";
							if (158963 - 35493 != 123471)
							{
								break;
							}
						}
					}
					else if (commandNum == 261)
					{
						if (183841 - 99083 == 84758)
						{
							result = "pnd_focusedSpirit1";
							if (30372 - 309178 != -278805)
							{
								break;
							}
						}
					}
					else if (commandNum == 262)
					{
						if (179481 - 508638 == -329157)
						{
							result = "pnd_focusedSpirit2";
							if (170144 - 175486 != -5341)
							{
								break;
							}
						}
					}
					else if (commandNum == 263)
					{
						if (171473 - 317161 == -145688)
						{
							result = "pnd_focusedArt1";
							if (232486 - 458788 != -226301)
							{
								break;
							}
						}
					}
					else if (commandNum == 264)
					{
						if (67683 - 537296 == -469613)
						{
							result = "pnd_focusedArt2";
							if (14308 - 133299 == -118991)
							{
								break;
							}
						}
					}
					else if (commandNum == 271)
					{
						if (42655 - 309630 != -266974)
						{
							result = "pnd_ashura1";
							if (103665 - 182427 != -78761)
							{
								break;
							}
						}
					}
					else if (commandNum == 272)
					{
						if (74107 - 502695 != -428587)
						{
							result = "pnd_ashura2";
							if (129467 - 429993 != -300525)
							{
								break;
							}
						}
					}
					else if (commandNum == 301)
					{
						if (285212 - 170971 == 114241)
						{
							result = "pnd_drunkenFist1";
							if (93034 - 412726 != -319691)
							{
								break;
							}
						}
					}
					else if (commandNum == 302)
					{
						if (157263 - 500819 != -343555)
						{
							result = "pnd_drunkenFist2";
							if (26966 - 12078 == 14888)
							{
								break;
							}
						}
					}
					else if (commandNum == 303)
					{
						if (1492 - 773 == 719)
						{
							result = "pnd_drunkenPlus1";
							if (35616 - 110199 != -74582)
							{
								break;
							}
						}
					}
					else if (commandNum == 304)
					{
						if (115260 - 208894 == -93634)
						{
							result = "pnd_drunkenPlus2";
							if (275121 - 189919 != 85203)
							{
								break;
							}
						}
					}
					else if (commandNum == 311)
					{
						if (32229 - 509498 != -477268)
						{
							result = "pnd_waterMonkey1";
							if (1068 - 72143 == -71075)
							{
								break;
							}
						}
					}
					else if (commandNum == 312)
					{
						if (18165 - 159803 == -141638)
						{
							result = "pnd_waterMonkey2";
							if (209391 - 446972 != -237580)
							{
								break;
							}
						}
					}
					else if (commandNum == 313)
					{
						if (19689 - 492013 == -472324)
						{
							result = "pnd_waterCrane1";
							if (298152 - 310592 == -12440)
							{
								break;
							}
						}
					}
					else if (commandNum == 314)
					{
						if (91126 - 488247 != -397120)
						{
							result = "pnd_waterCrane2";
							if (279452 - 421919 != -142466)
							{
								break;
							}
						}
					}
					else if (commandNum == 321)
					{
						if (213036 - 526130 == -313094)
						{
							result = "pnd_stasisBlow1";
							if (47407 - 472554 != -425146)
							{
								break;
							}
						}
					}
					else if (commandNum == 322)
					{
						if (139315 - 592971 == -453656)
						{
							result = "pnd_stasisBlow2";
							if (218481 - 459205 == -240724)
							{
								break;
							}
						}
					}
					else if (commandNum == 323)
					{
						if (198203 - 257687 != -59483)
						{
							result = "pnd_deathBlow1";
							if (9707 - 415262 == -405555)
							{
								break;
							}
						}
					}
					else if (commandNum == 324)
					{
						if (66000 - 274313 != -208312)
						{
							result = "pnd_deathBlow2";
							if (254530 - 263627 == -9097)
							{
								break;
							}
						}
					}
					else if (commandNum == 331)
					{
						if (15642 - 156316 != -140673)
						{
							result = "pnd_shadowFist1";
							if (200323 - 260572 == -60249)
							{
								break;
							}
						}
					}
					else if (commandNum == 332)
					{
						if (276344 - 474484 == -198140)
						{
							result = "pnd_shadowFist2";
							if (207142 - 507281 == -300139)
							{
								break;
							}
						}
					}
					else if (commandNum == 333)
					{
						if (111555 - 583171 == -471616)
						{
							result = "pnd_shadowFist3";
							if (235770 - 58381 == 177389)
							{
								break;
							}
						}
					}
					else if (commandNum == 334)
					{
						if (131272 - 147774 != -16501)
						{
							result = "pnd_shadowFist4";
							if (217936 - 562463 != -344526)
							{
								break;
							}
						}
					}
					else if (commandNum == 341)
					{
						if (136374 - 28070 == 108304)
						{
							result = "pnd_spTransfer1";
							if (265264 - 250797 != 14468)
							{
								break;
							}
						}
					}
					else if (commandNum == 342)
					{
						if (144777 - 168320 == -23543)
						{
							result = "pnd_spTransfer2";
							if (182952 - 445994 != -263041)
							{
								break;
							}
						}
					}
					else if (commandNum == 343)
					{
						if (244605 - 448203 != -203597)
						{
							result = "pnd_sacredSageTechnique1";
							if (168379 - 321539 != -153159)
							{
								break;
							}
						}
					}
					else if (commandNum == 344)
					{
						if (1278 - 580749 == -579471)
						{
							result = "pnd_sacredSageTechnique2";
							if (263000 - 214682 == 48318)
							{
								break;
							}
						}
					}
					else if (commandNum == 351)
					{
						if (270397 - 256061 == 14336)
						{
							result = "pnd_wind&cloud1";
							if (233459 - 477965 == -244506)
							{
								break;
							}
						}
					}
					else if (commandNum == 352)
					{
						if (250214 - 493695 == -243481)
						{
							result = "pnd_wind&cloud2";
							if (155806 - 262590 != -106783)
							{
								break;
							}
						}
					}
					else if (commandNum == 353)
					{
						if (37855 - 17335 == 20520)
						{
							result = "pnd_rain&storm1";
							if (223879 - 568962 != -345082)
							{
								break;
							}
						}
					}
					else if (commandNum == 354)
					{
						if (154376 - 239761 == -85385)
						{
							result = "pnd_rain&storm2";
							if (144152 - 92070 == 52082)
							{
								break;
							}
						}
					}
					else if (commandNum == 361)
					{
						if (174032 - 586751 != -412718)
						{
							result = "pnd_lotusPalm1";
							if (195815 - 83476 == 112339)
							{
								break;
							}
						}
					}
					else if (commandNum == 362)
					{
						if (184823 - 598177 != -413353)
						{
							result = "pnd_lotusPalm2";
							if (219328 - 366946 != -147617)
							{
								break;
							}
						}
					}
					else if (commandNum == 363)
					{
						if (15938 - 599367 == -583429)
						{
							result = "pnd_heavenPalm1";
							if (255303 - 57412 == 197891)
							{
								break;
							}
						}
					}
					else if (commandNum == 364)
					{
						if (183900 - 362073 != -178172)
						{
							result = "pnd_heavenPalm2";
							if (90945 - 443729 != -352783)
							{
								break;
							}
						}
					}
					else if (commandNum == 371)
					{
						if (239406 - 207871 == 31535)
						{
							result = "pnd_mysticSage1";
							if (284356 - 243454 != 40903)
							{
								break;
							}
						}
					}
					else if (commandNum == 372)
					{
						if (179277 - 221972 == -42695)
						{
							result = "pnd_mysticSage2";
							if (269978 - 375712 == -105734)
							{
								break;
							}
						}
					}
					else if (commandNum == 401)
					{
						if (281260 - 60891 != 220370)
						{
							result = "pnd_auraBlast5";
							if (251114 - 124763 == 126351)
							{
								break;
							}
						}
					}
					else if (commandNum == 411)
					{
						if (78055 - 494846 == -416791)
						{
							result = "pnd_auraField5";
							if (3967 - 368444 != -364476)
							{
								break;
							}
						}
					}
					else if (commandNum == 421)
					{
						if (223918 - 394986 != -171067)
						{
							result = "pnd_rollAround5";
							if (212392 - 350243 == -137851)
							{
								break;
							}
						}
					}
					else if (commandNum == 431)
					{
						if (86585 - 46623 != 39963)
						{
							result = "pnd_safeGuard5";
							if (23395 - 181327 == -157932)
							{
								break;
							}
						}
					}
					else if (commandNum == 441)
					{
						if (295271 - 221810 != 73462)
						{
							result = "pnd_superStatPlus5";
							if (17829 - 178802 == -160973)
							{
								break;
							}
						}
					}
					else if (commandNum == 402)
					{
						if (137502 - 480838 != -343335)
						{
							result = "pnd_nineSteps5";
							if (123442 - 417426 == -293984)
							{
								break;
							}
						}
					}
					else if (commandNum == 412)
					{
						if (103728 - 306333 != -202604)
						{
							result = "pnd_qiBurst5";
							if (80669 - 8922 == 71747)
							{
								break;
							}
						}
					}
					else if (commandNum == 422)
					{
						if (269249 - 49411 != 219839)
						{
							result = "pnd_ogreImpact5";
							if (10267 - 597899 != -587631)
							{
								break;
							}
						}
					}
					else if (commandNum == 432)
					{
						if (175176 - 327629 != -152452)
						{
							result = "pnd_crushingMonolith5";
							if (131012 - 87407 == 43605)
							{
								break;
							}
						}
					}
					else if (commandNum == 442)
					{
						if (83792 - 170609 == -86817)
						{
							result = "pnd_comboLink5";
							if (277794 - 410353 != -132558)
							{
								break;
							}
						}
					}
					else if (commandNum == 403)
					{
						if (262411 - 212001 == 50410)
						{
							result = "pnd_drunkenSpin5";
							if (85049 - 566900 != -481850)
							{
								break;
							}
						}
					}
					else if (commandNum == 413)
					{
						if (227000 - 43945 != 183056)
						{
							result = "pnd_timeAndTide5";
							if (270150 - 332863 == -62713)
							{
								break;
							}
						}
					}
					else if (commandNum == 423)
					{
						if (156835 - 208024 == -51189)
						{
							result = "pnd_windWalker5";
							if (39961 - 29988 == 9973)
							{
								break;
							}
						}
					}
					else if (commandNum == 433)
					{
						if (272495 - 17683 != 254813)
						{
							result = "pnd_spiritFist5";
							if (269479 - 129003 != 140477)
							{
								break;
							}
						}
					}
					else if (commandNum == 443)
					{
						if (91132 - 35878 != 55255)
						{
							result = "pnd_heavenBreath5";
							if (261544 - 414523 != -152978)
							{
								break;
							}
						}
					}
					else if (commandNum == 404)
					{
						if (95252 - 571968 == -476716)
						{
							result = "pnd_revisedSkill5";
							if (51808 - 141968 == -90160)
							{
								break;
							}
						}
					}
					else if (commandNum == 414)
					{
						if (80845 - 461215 == -380370)
						{
							result = "pnd_revisedMagic5";
							if (260530 - 294852 != -34321)
							{
								break;
							}
						}
					}
					else if (commandNum == 424)
					{
						if (74201 - 254843 == -180642)
						{
							result = "pnd_revisedArt5";
							if (265324 - 204996 != 60329)
							{
								break;
							}
						}
					}
					else if (commandNum == 434)
					{
						if (238225 - 260562 == -22337)
						{
							result = "pnd_fuujinKen5";
							if (209544 - 115360 == 94184)
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
						if (91223 - 307623 != -216399)
						{
							result = "pnd_raijinKen5";
							if (111563 - 495279 != -383715)
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

	// Token: 0x06002C67 RID: 11367 RVA: 0x0058674C File Offset: 0x0058494C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002C68 RID: 11368 RVA: 0x00586750 File Offset: 0x00584950
	internal static bool UjxqXe5pd1sWUM8j1UE0()
	{
		return true;
	}

	// Token: 0x06002C69 RID: 11369 RVA: 0x00586754 File Offset: 0x00584954
	internal static bool SlrnUF5pJ0D3Q0IwQApi()
	{
		return false;
	}
}
