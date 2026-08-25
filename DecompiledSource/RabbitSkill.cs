using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020008CE RID: 2254
[Serializable]
public class RabbitSkill : MonoBehaviour
{
	// Token: 0x06003196 RID: 12694 RVA: 0x0064B88C File Offset: 0x00649A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RabbitSkill()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003197 RID: 12695 RVA: 0x0064B89C File Offset: 0x00649A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSkill(string skillname)
	{
		if (208495 - 118246 != 90250)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (233110 - 84003 != 149108)
			{
				if (169109 - 19318 == 149791)
				{
					if (skillname == "rab_nAttack1")
					{
						if (170616 - 274636 != -104020)
						{
							continue;
						}
						skillClass.setReq(1, 0);
						if (136162 - 207205 != -71043)
						{
							continue;
						}
						goto IL_358B;
					}
					else if (skillname == "rab_nAttack2")
					{
						if (187377 - 230382 != -43004)
						{
							goto IL_358B;
						}
						continue;
					}
					else if (skillname == "rab_nAttack3")
					{
						if (231625 - 166161 != 65464)
						{
							continue;
						}
					}
					else if (skillname == "rab_nAttack4")
					{
						if (161165 - 418038 != -256873)
						{
							continue;
						}
						goto IL_2D19;
					}
					else
					{
						if (skillname == "rab_cAttack1")
						{
							if (33926 - 119598 == -85671)
							{
								continue;
							}
							skillClass.setReq(4, 1);
							if (289673 - 263511 != 26163)
							{
								goto IL_2BBE;
							}
							continue;
						}
						else if (skillname == "rab_cAttack2")
						{
							if (14983 - 286174 != -271190)
							{
								goto IL_2BBE;
							}
							continue;
						}
						else if (skillname == "rab_cAttack3")
						{
							if (58945 - 206829 != -147884)
							{
								continue;
							}
						}
						else if (skillname == "rab_statScan1")
						{
							if (21671 - 394498 != -372827)
							{
								continue;
							}
							skillClass.setReq(22, 4);
							if (106568 - 436591 != -330023)
							{
								continue;
							}
							skillClass.setSP(-6);
							if (133959 - 401098 != -267139)
							{
								continue;
							}
							skillClass.mode = eSkillMode.target;
							if (127118 - 228054 == -100935)
							{
								continue;
							}
							skillClass.target = eSkillTarget.all;
							if (222851 - 58154 != 164697)
							{
								continue;
							}
							skillClass.cType = "statScan";
							if (57867 - 514098 != -456230)
							{
								break;
							}
							continue;
						}
						else
						{
							if (skillname == "rab_bounce1")
							{
								if (97763 - 247443 == -149679)
								{
									continue;
								}
								skillClass.setReq(6, 2);
								if (250042 - 528529 == -278486)
								{
									continue;
								}
								skillClass.setSP(-5);
								if (48891 - 19240 == 29652)
								{
									continue;
								}
							}
							else if (skillname == "rab_bounce2")
							{
								if (124023 - 308803 != -184780)
								{
									continue;
								}
							}
							else
							{
								if (skillname == "rab_hyperShot1")
								{
									if (197689 - 250276 != -52587)
									{
										continue;
									}
									skillClass.setReq(8, 4);
									if (157131 - 378375 != -221243)
									{
										goto IL_2107;
									}
									continue;
								}
								else if (skillname == "rab_hyperShot2")
								{
									if (56816 - 58640 != -1824)
									{
										continue;
									}
									goto IL_2107;
								}
								else if (skillname == "rab_hyperShot3")
								{
									if (199855 - 138487 != 61369)
									{
										goto IL_290C;
									}
									continue;
								}
								else if (skillname == "rab_hyperShot4")
								{
									if (83596 - 172921 == -89324)
									{
										continue;
									}
								}
								else
								{
									if (skillname == "rab_statPlus1")
									{
										if (72476 - 577607 != -505131)
										{
											continue;
										}
										skillClass.setReq(10, 4);
										if (143506 - 300835 != -157329)
										{
											continue;
										}
									}
									else if (skillname == "rab_statPlus2")
									{
										if (287019 - 87053 != 199966)
										{
											continue;
										}
									}
									else if (skillname == "rab_statPlus3")
									{
										if (285264 - 101485 != 183780)
										{
											goto IL_277A;
										}
										continue;
									}
									else if (skillname == "rab_statPlus4")
									{
										if (238304 - 156308 != 81997)
										{
											goto IL_2C47;
										}
										continue;
									}
									else
									{
										if (skillname == "rab_maimShot1")
										{
											if (110068 - 428314 == -318245)
											{
												continue;
											}
											skillClass.setReq(3, 0);
											if (115793 - 209323 != -93530)
											{
												continue;
											}
											skillClass.setSP(12);
											if (229690 - 511580 != -281889)
											{
												goto IL_1C5A;
											}
											continue;
										}
										else if (skillname == "rab_maimShot2")
										{
											if (296 - 450387 != -450091)
											{
												continue;
											}
											goto IL_1C5A;
										}
										else if (skillname == "rab_maimShot3")
										{
											if (238047 - 270813 != -32766)
											{
												continue;
											}
											goto IL_101D;
										}
										else if (skillname == "rab_maimShot4")
										{
											if (7700 - 283729 != -276029)
											{
												continue;
											}
										}
										else
										{
											if (skillname == "rab_mix1")
											{
												if (5863 - 309989 != -304126)
												{
													continue;
												}
												skillClass.setReq(5, 1);
												if (48809 - 101390 != -52581)
												{
													continue;
												}
												skillClass.setMP(6);
												if (205370 - 420645 != -215275)
												{
													continue;
												}
											}
											else if (skillname == "rab_mix2")
											{
												if (34550 - 182061 != -147511)
												{
													continue;
												}
											}
											else if (skillname == "rab_mix3")
											{
												if (261892 - 440907 != -179015)
												{
													continue;
												}
												goto IL_AA4;
											}
											else if (skillname == "rab_mix4")
											{
												if (194245 - 56079 != 138166)
												{
													continue;
												}
												goto IL_3239;
											}
											else
											{
												if (skillname == "rab_shake1")
												{
													if (67937 - 569598 == -501660)
													{
														continue;
													}
													skillClass.setReq(7, 2);
													if (59468 - 454931 == -395462)
													{
														continue;
													}
													skillClass.setMP(6);
													if (78970 - 321558 == -242587)
													{
														continue;
													}
												}
												else if (skillname == "rab_shake2")
												{
													if (25474 - 179090 != -153616)
													{
														continue;
													}
												}
												else if (skillname == "rab_shake3")
												{
													if (151960 - 467017 != -315056)
													{
														goto IL_339F;
													}
													continue;
												}
												else if (skillname == "rab_miracleBlend1")
												{
													if (169488 - 193279 == -23790)
													{
														continue;
													}
													skillClass.setReq(25, 8);
													if (230844 - 223612 != 7232)
													{
														continue;
													}
													skillClass.setMP(18);
													if (271343 - 461690 != -190347)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (152451 - 137559 != 14892)
													{
														continue;
													}
													skillClass.target = eSkillTarget.self;
													if (69116 - 11435 == 57682)
													{
														continue;
													}
													skillClass.cType = "miracleBlend";
													if (97518 - 444197 != -346679)
													{
														continue;
													}
													break;
												}
												else
												{
													if (skillname == "rab_alchemistLab1")
													{
														if (180675 - 263454 != -82779)
														{
															continue;
														}
														skillClass.setReq(9, 3);
														if (25589 - 542975 != -517386)
														{
															continue;
														}
														goto IL_2159;
													}
													else if (skillname == "rab_alchemistLab2")
													{
														if (260304 - 288063 != -27759)
														{
															continue;
														}
														goto IL_2159;
													}
													else if (skillname == "rab_alchemistLab3")
													{
														if (39696 - 55910 != -16214)
														{
															continue;
														}
														goto IL_166F;
													}
													else if (skillname == "rab_alchemistLab4")
													{
														if (72492 - 308501 == -236008)
														{
															continue;
														}
													}
													else
													{
														if (skillname == "rab_stickyGum1")
														{
															if (196069 - 479896 == -283826)
															{
																continue;
															}
															skillClass.setReq(16, 4);
															if (73532 - 59579 != 13953)
															{
																continue;
															}
															skillClass.setMPSP(6, -10);
															if (28629 - 513410 != -484781)
															{
																continue;
															}
														}
														else if (skillname == "rab_stickyGum2")
														{
															if (74785 - 201394 != -126609)
															{
																continue;
															}
														}
														else
														{
															if (skillname == "rab_acidicField1")
															{
																if (264674 - 221761 != 42913)
																{
																	continue;
																}
																skillClass.setReq(24, 12);
																if (206260 - 319174 == -112913)
																{
																	continue;
																}
																skillClass.setMPSP(8, -15);
																if (237170 - 246960 == -9789)
																{
																	continue;
																}
															}
															else if (skillname == "rab_acidicField2")
															{
																if (136172 - 399269 != -263097)
																{
																	continue;
																}
															}
															else if (skillname == "rab_immuneShot1")
															{
																if (250309 - 202268 != 48041)
																{
																	continue;
																}
																skillClass.setReq(20, 12);
																if (53249 - 114832 != -61583)
																{
																	continue;
																}
																skillClass.setMPSP(10, 10);
																if (147189 - 500747 == -353557)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.target;
																if (223394 - 44658 == 178737)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.ally;
																if (294230 - 185526 != 108704)
																{
																	continue;
																}
																skillClass.cType = "immuneShot";
																if (231379 - 381525 != -150145)
																{
																	break;
																}
																continue;
															}
															else if (skillname == "rab_boostShot2")
															{
																if (128239 - 88833 != 39406)
																{
																	continue;
																}
																skillClass.setReq(24, 15);
																if (28776 - 17351 != 11425)
																{
																	continue;
																}
																skillClass.setMPSP(10, 10);
																if (193577 - 485999 == -292421)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.target;
																if (18532 - 505737 != -487205)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.ally;
																if (74522 - 420586 != -346064)
																{
																	continue;
																}
																skillClass.cType = "boostShot";
																if (155305 - 17836 != 137470)
																{
																	break;
																}
																continue;
															}
															else if (skillname == "rab_heatShot3")
															{
																if (238310 - 279035 == -40724)
																{
																	continue;
																}
																skillClass.setReq(28, 18);
																if (280307 - 585155 != -304848)
																{
																	continue;
																}
																skillClass.setMPSP(10, 10);
																if (156379 - 589378 != -432999)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.target;
																if (115123 - 251988 == -136864)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.ally;
																if (287375 - 297816 == -10440)
																{
																	continue;
																}
																skillClass.cType = "heatShot";
																if (205227 - 325634 != -120406)
																{
																	break;
																}
																continue;
															}
															else if (skillname == "rab_lifeShot4")
															{
																if (112161 - 573979 == -461817)
																{
																	continue;
																}
																skillClass.setReq(32, 21);
																if (170334 - 295514 == -125179)
																{
																	continue;
																}
																skillClass.setMPSP(10, 10);
																if (163044 - 476482 != -313438)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.target;
																if (58040 - 428155 == -370114)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.ally;
																if (225615 - 469981 == -244365)
																{
																	continue;
																}
																skillClass.cType = "lifeShot";
																if (222080 - 184106 != 37975)
																{
																	break;
																}
																continue;
															}
															else
															{
																if (skillname == "rab_medicalEnhancement1")
																{
																	if (290197 - 212495 != 77702)
																	{
																		continue;
																	}
																	skillClass.setReq(24, 15);
																	if (202759 - 186889 == 15871)
																	{
																		continue;
																	}
																}
																else if (skillname == "rab_medicalEnhancement2")
																{
																	if (6787 - 308103 == -301315)
																	{
																		continue;
																	}
																}
																else if (skillname == "rab_medicalEnhancement3")
																{
																	if (130679 - 560752 != -430073)
																	{
																		continue;
																	}
																	goto IL_2873;
																}
																else if (skillname == "rab_rapidTrance1")
																{
																	if (102794 - 160253 != -57459)
																	{
																		continue;
																	}
																	skillClass.setReq(33, 24);
																	if (132057 - 360261 == -228203)
																	{
																		continue;
																	}
																	skillClass.setMPSP(20, -30);
																	if (235289 - 136262 == 99028)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.instant;
																	if (71167 - 477954 == -406786)
																	{
																		continue;
																	}
																	skillClass.target = eSkillTarget.self;
																	if (164842 - 235469 != -70627)
																	{
																		continue;
																	}
																	skillClass.cType = "rapidTrance";
																	if (211152 - 250251 != -39099)
																	{
																		continue;
																	}
																	break;
																}
																else
																{
																	if (skillname == "rab_gorgonShot1")
																	{
																		if (104037 - 361551 != -257514)
																		{
																			continue;
																		}
																		skillClass.setReq(35, 23);
																		if (284315 - 341354 != -57039)
																		{
																			continue;
																		}
																		skillClass.setMPSP(20, -35);
																		if (259756 - 459270 == -199513)
																		{
																			continue;
																		}
																	}
																	else if (skillname == "rab_gorgonShot2")
																	{
																		if (279719 - 278406 == 1314)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (skillname == "rab_gilShot1")
																		{
																			if (114326 - 254431 == -140104)
																			{
																				continue;
																			}
																			skillClass.setReq(3, 0);
																			if (20229 - 16994 == 3236)
																			{
																				continue;
																			}
																			skillClass.setSP(10);
																			if (133962 - 286376 != -152413)
																			{
																				goto IL_1A85;
																			}
																			continue;
																		}
																		else if (skillname == "rab_gilShot2")
																		{
																			if (206753 - 168251 != 38503)
																			{
																				goto IL_1A85;
																			}
																			continue;
																		}
																		else if (skillname == "rab_gilShot3")
																		{
																			if (229390 - 257253 != -27863)
																			{
																				continue;
																			}
																			goto IL_2EF6;
																		}
																		else if (skillname == "rab_gilShot4")
																		{
																			if (62659 - 278025 != -215366)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (skillname == "rab_bunnyBargain1")
																			{
																				if (262571 - 49227 == 213345)
																				{
																					continue;
																				}
																				skillClass.setReq(5, 1);
																				if (236137 - 199466 != 36671)
																				{
																					continue;
																				}
																				goto IL_A1A;
																			}
																			else if (skillname == "rab_bunnyBargain2")
																			{
																				if (263308 - 108029 != 155280)
																				{
																					goto IL_A1A;
																				}
																				continue;
																			}
																			else if (skillname == "rab_bunnyBargain3")
																			{
																				if (103658 - 77398 == 26261)
																				{
																					continue;
																				}
																			}
																			else if (skillname == "rab_bunnyBargain4")
																			{
																				if (125779 - 160147 != -34367)
																				{
																					goto IL_140A;
																				}
																				continue;
																			}
																			else
																			{
																				if (skillname == "rab_herbFinder1")
																				{
																					if (224070 - 85209 == 138862)
																					{
																						continue;
																					}
																					skillClass.setReq(7, 2);
																					if (58883 - 100458 != -41575)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "rab_herbFinder2")
																				{
																					if (202726 - 237831 != -35105)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					if (skillname == "rab_backpack1")
																					{
																						if (207793 - 44832 == 162962)
																						{
																							continue;
																						}
																						skillClass.setReq(13, 4);
																						if (260359 - 539460 != -279101)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "rab_backpack2")
																					{
																						if (85415 - 572443 != -487028)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						if (skillname == "rab_fourShot1")
																						{
																							if (118156 - 389659 != -271503)
																							{
																								continue;
																							}
																							skillClass.setReq(9, 3);
																							if (57193 - 475540 == -418346)
																							{
																								continue;
																							}
																							skillClass.setSP(-12);
																							if (61953 - 274381 == -212427)
																							{
																								continue;
																							}
																						}
																						else if (skillname == "rab_fourShot2")
																						{
																							if (267636 - 75653 != 191983)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							if (skillname == "rab_circleShot1")
																							{
																								if (140482 - 153989 == -13506)
																								{
																									continue;
																								}
																								skillClass.setReq(21, 7);
																								if (162308 - 590320 != -428012)
																								{
																									continue;
																								}
																								skillClass.setSP(-24);
																								if (60250 - 448523 == -388272)
																								{
																									continue;
																								}
																							}
																							else if (skillname == "rab_circleShot2")
																							{
																								if (277640 - 337636 != -59996)
																								{
																									continue;
																								}
																							}
																							else
																							{
																								if (skillname == "rab_mall1")
																								{
																									if (237529 - 374436 == -136906)
																									{
																										continue;
																									}
																									skillClass.setReq(16, 4);
																									if (79311 - 3254 == 76058)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "rab_mall2")
																								{
																									if (119529 - 171851 != -52322)
																									{
																										continue;
																									}
																								}
																								else
																								{
																									if (skillname == "rab_truceTrading&Co1")
																									{
																										if (11543 - 540825 != -529282)
																										{
																											continue;
																										}
																										skillClass.setReq(24, 12);
																										if (269286 - 78104 == 191183)
																										{
																											continue;
																										}
																										skillClass.setMP(20);
																										if (132788 - 450235 != -317447)
																										{
																											continue;
																										}
																									}
																									else if (skillname == "rab_truceTrading&Co2")
																									{
																										if (168649 - 299166 == -130516)
																										{
																											continue;
																										}
																									}
																									else
																									{
																										if (skillname == "rab_shootingArray1")
																										{
																											if (11712 - 596161 != -584449)
																											{
																												continue;
																											}
																											skillClass.setReq(20, 12);
																											if (89217 - 416511 != -327294)
																											{
																												continue;
																											}
																											skillClass.setSP(-24);
																											if (123482 - 102181 != 21301)
																											{
																												continue;
																											}
																										}
																										else if (skillname == "rab_shootingArray2")
																										{
																											if (183000 - 29747 == 153254)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											if (skillname == "rab_customizedShotgun1")
																											{
																												if (65258 - 190349 == -125090)
																												{
																													continue;
																												}
																												skillClass.setReq(28, 18);
																												if (275750 - 379982 == -104231)
																												{
																													continue;
																												}
																											}
																											else if (skillname == "rab_customizedShotgun2")
																											{
																												if (286150 - 252322 == 33829)
																												{
																													continue;
																												}
																											}
																											else
																											{
																												if (skillname == "rab_specialDeal1")
																												{
																													if (106542 - 391678 == -285135)
																													{
																														continue;
																													}
																													skillClass.setReq(24, 15);
																													if (157838 - 322248 == -164409)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "rab_specialDeal2")
																												{
																													if (65787 - 144636 != -78849)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "rab_specialDeal3")
																												{
																													if (100767 - 408814 != -308047)
																													{
																														continue;
																													}
																													goto IL_33C2;
																												}
																												else if (skillname == "rab_specialDeal4")
																												{
																													if (185249 - 366804 != -181554)
																													{
																														goto IL_3021;
																													}
																													continue;
																												}
																												else
																												{
																													if (skillname == "rab_millionaire1")
																													{
																														if (221796 - 114124 == 107673)
																														{
																															continue;
																														}
																														skillClass.setReq(35, 23);
																														if (127425 - 565202 == -437776)
																														{
																															continue;
																														}
																														skillClass.setSP(-50);
																														if (232443 - 171187 == 61257)
																														{
																															continue;
																														}
																													}
																													else if (skillname == "rab_millionaire2")
																													{
																														if (86821 - 216916 != -130095)
																														{
																															continue;
																														}
																													}
																													else if (skillname == "rab_bouncingBullet5")
																													{
																														if (24038 - 550582 != -526544)
																														{
																															continue;
																														}
																														skillClass.setReq(55, 0);
																														if (1219 - 33156 == -31936)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (285326 - 379174 != -93848)
																														{
																															continue;
																														}
																														skillClass.rSkill = 104;
																														if (235432 - 560599 != -325167)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "rab_deadShot5")
																													{
																														if (211115 - 160365 == 50751)
																														{
																															continue;
																														}
																														skillClass.setReq(60, 1);
																														if (37140 - 370283 == -333142)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (233699 - 198028 != 35671)
																														{
																															continue;
																														}
																														skillClass.rSkill = 114;
																														if (195884 - 10972 != 184913)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "rab_fromTheAbove5")
																													{
																														if (186739 - 13541 != 173198)
																														{
																															continue;
																														}
																														skillClass.setReq(70, 3);
																														if (209317 - 531092 == -321774)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (296537 - 448309 != -151772)
																														{
																															continue;
																														}
																														skillClass.rSkill = 122;
																														if (291823 - 209004 != 82819)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "rab_snipeMastery5")
																													{
																														if (95507 - 310162 != -214655)
																														{
																															continue;
																														}
																														skillClass.setReq(75, 4);
																														if (175661 - 140208 != 35453)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (189285 - 62404 == 126882)
																														{
																															continue;
																														}
																														skillClass.rSkill = 134;
																														if (36401 - 338708 != -302307)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "rab_superStatPlus5")
																													{
																														if (192437 - 139326 != 53111)
																														{
																															continue;
																														}
																														skillClass.setReq(85, 6);
																														if (133044 - 228937 != -95893)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (178042 - 510625 != -332583)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.self;
																														if (124936 - 332377 != -207441)
																														{
																															continue;
																														}
																														skillClass.rSkill = 144;
																														if (147848 - 571676 != -423828)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "rab_kneeShot5")
																													{
																														if (213327 - 314447 != -101120)
																														{
																															continue;
																														}
																														skillClass.setReq(55, 0);
																														if (95829 - 427565 == -331735)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (33462 - 292556 == -259093)
																														{
																															continue;
																														}
																														skillClass.rSkill = 204;
																														if (86103 - 138015 != -51912)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "rab_extraPotion5")
																													{
																														if (105031 - 518362 != -413331)
																														{
																															continue;
																														}
																														skillClass.setReq(60, 1);
																														if (61666 - 259010 != -197344)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (236532 - 17333 != 219199)
																														{
																															continue;
																														}
																														skillClass.rSkill = 214;
																														if (42720 - 200217 != -157496)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "rab_miracleDrop5")
																													{
																														if (161323 - 34946 == 126378)
																														{
																															continue;
																														}
																														skillClass.setReq(70, 3);
																														if (234579 - 29722 == 204858)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (223979 - 42935 == 181045)
																														{
																															continue;
																														}
																														skillClass.rSkill = 224;
																														if (24028 - 407499 != -383470)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "rab_medResearch5")
																													{
																														if (14770 - 41489 == -26718)
																														{
																															continue;
																														}
																														skillClass.setReq(75, 4);
																														if (236971 - 44090 == 192882)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (156587 - 580616 != -424029)
																														{
																															continue;
																														}
																														skillClass.rSkill = 234;
																														if (260630 - 381310 != -120680)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "rab_healingField5")
																													{
																														if (42672 - 465619 != -422947)
																														{
																															continue;
																														}
																														skillClass.setReq(85, 6);
																														if (27818 - 232026 != -204208)
																														{
																															continue;
																														}
																														skillClass.setMPSP(30, -30);
																														if (54269 - 489908 != -435639)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.instant;
																														if (231440 - 340935 == -109494)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.self;
																														if (188770 - 366439 == -177668)
																														{
																															continue;
																														}
																														skillClass.cType = "healingField";
																														if (5872 - 36484 != -30612)
																														{
																															continue;
																														}
																														skillClass.rSkill = 244;
																														if (85244 - 214693 != -129448)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "rab_diamondShot5")
																													{
																														if (63370 - 342156 != -278786)
																														{
																															continue;
																														}
																														skillClass.setReq(55, 0);
																														if (8848 - 404293 == -395444)
																														{
																															continue;
																														}
																														skillClass.setSP(-20);
																														if (150260 - 527705 != -377445)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.instant;
																														if (166837 - 471505 != -304668)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.enemy;
																														if (95176 - 109292 == -14115)
																														{
																															continue;
																														}
																														skillClass.cType = "diamondShot";
																														if (31819 - 577654 != -545835)
																														{
																															continue;
																														}
																														skillClass.rSkill = 304;
																														if (176953 - 425089 != -248136)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "rab_skillBargain5")
																													{
																														if (185234 - 21585 != 163649)
																														{
																															continue;
																														}
																														skillClass.setReq(60, 1);
																														if (216878 - 410538 == -193659)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (259647 - 552796 == -293148)
																														{
																															continue;
																														}
																														skillClass.rSkill = 314;
																														if (182681 - 450101 != -267419)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "rab_bigBag5")
																													{
																														if (235258 - 171454 != 63804)
																														{
																															continue;
																														}
																														skillClass.setReq(70, 3);
																														if (210219 - 292482 != -82263)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (116951 - 470213 == -353261)
																														{
																															continue;
																														}
																														skillClass.rSkill = 324;
																														if (283995 - 571211 != -287216)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "rab_tenShot5")
																													{
																														if (12792 - 163258 != -150466)
																														{
																															continue;
																														}
																														skillClass.setReq(75, 4);
																														if (156980 - 511286 == -354305)
																														{
																															continue;
																														}
																														skillClass.setSP(-20);
																														if (83979 - 235943 != -151964)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.instant;
																														if (259561 - 506191 != -246630)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.enemy;
																														if (297514 - 491186 != -193672)
																														{
																															continue;
																														}
																														skillClass.cType = "tenShot";
																														if (237424 - 145815 != 91609)
																														{
																															continue;
																														}
																														skillClass.rSkill = 334;
																														if (293303 - 528332 != -235028)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "rab_extravagance5")
																													{
																														if (239517 - 299886 == -60368)
																														{
																															continue;
																														}
																														skillClass.setReq(85, 6);
																														if (275886 - 145026 != 130860)
																														{
																															continue;
																														}
																														skillClass.setMPSP(20, -40);
																														if (168167 - 13229 != 154938)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.instant;
																														if (50379 - 375571 == -325191)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.self;
																														if (52272 - 551258 != -498986)
																														{
																															continue;
																														}
																														skillClass.cType = "extravagance";
																														if (113836 - 348416 != -234580)
																														{
																															continue;
																														}
																														skillClass.rSkill = 344;
																														if (143429 - 12889 != 130540)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "rab_revisedSkill5")
																													{
																														if (8855 - 206623 != -197768)
																														{
																															continue;
																														}
																														skillClass.setReq(55, 0);
																														if (177797 - 536979 != -359182)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (133486 - 82285 != 51201)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "rab_revisedMagic5")
																													{
																														if (223992 - 324374 == -100381)
																														{
																															continue;
																														}
																														skillClass.setReq(60, 1);
																														if (45023 - 317960 == -272936)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (290401 - 328416 != -38014)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "rab_revisedArt5")
																													{
																														if (229385 - 178719 == 50667)
																														{
																															continue;
																														}
																														skillClass.setReq(70, 3);
																														if (69916 - 22472 == 47445)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (227133 - 426661 != -199527)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "rab_contract5")
																													{
																														if (289007 - 391212 == -102204)
																														{
																															continue;
																														}
																														skillClass.setReq(75, 4);
																														if (58743 - 115901 == -57157)
																														{
																															continue;
																														}
																														skillClass.setMPSP(50, -30);
																														if (252364 - 528821 != -276457)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.instant;
																														if (272457 - 563289 == -290831)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.self;
																														if (38280 - 120319 == -82038)
																														{
																															continue;
																														}
																														skillClass.cType = "contract";
																														if (170884 - 531913 == -361028)
																														{
																															continue;
																														}
																														skillClass.rSkill = 243343;
																														if (168279 - 334578 != -166298)
																														{
																															break;
																														}
																														continue;
																													}
																													else
																													{
																														if (!(skillname == "rab_newOrder5"))
																														{
																															break;
																														}
																														if (77243 - 18640 != 58603)
																														{
																															continue;
																														}
																														skillClass.setReq(85, 6);
																														if (211340 - 385526 != -174186)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (50323 - 222362 == -172038)
																														{
																															continue;
																														}
																														skillClass.rSkill = 434;
																														if (155520 - 86298 != 69223)
																														{
																															break;
																														}
																														continue;
																													}
																													skillClass.setReq(40, 25);
																													if (100928 - 408851 == -307922)
																													{
																														continue;
																													}
																													skillClass.setSP(-75);
																													if (86584 - 73335 != 13249)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.instant;
																													if (161480 - 501554 == -340073)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.enemy;
																													if (245787 - 16974 != 228813)
																													{
																														continue;
																													}
																													skillClass.cType = "millionaire";
																													if (111126 - 239340 != -128213)
																													{
																														break;
																													}
																													continue;
																												}
																												skillClass.setReq(27, 18);
																												if (132354 - 195678 != -63323)
																												{
																													goto IL_33C2;
																												}
																												continue;
																												IL_3021:
																												skillClass.setReq(33, 24);
																												if (269619 - 512370 == -242750)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (32606 - 237384 != -204777)
																												{
																													break;
																												}
																												continue;
																												IL_33C2:
																												skillClass.setReq(30, 21);
																												if (128823 - 487623 != -358799)
																												{
																													goto IL_3021;
																												}
																												continue;
																											}
																											skillClass.setReq(28, 22);
																											if (53287 - 404395 != -351108)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.passive;
																											if (29135 - 569889 != -540754)
																											{
																												continue;
																											}
																											break;
																										}
																										skillClass.setReq(24, 15);
																										if (292567 - 107302 != 185265)
																										{
																											continue;
																										}
																										skillClass.setSP(-30);
																										if (204775 - 54600 != 150175)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.target;
																										if (150452 - 450554 == -300101)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.enemy;
																										if (214583 - 78511 != 136072)
																										{
																											continue;
																										}
																										skillClass.cType = "shootingArray";
																										if (221169 - 559176 != -338006)
																										{
																											break;
																										}
																										continue;
																									}
																									skillClass.setReq(28, 16);
																									if (148214 - 376997 == -228782)
																									{
																										continue;
																									}
																									skillClass.setMP(30);
																									if (138078 - 460468 != -322390)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.target;
																									if (30116 - 569424 != -539308)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.enemy;
																									if (261196 - 188095 != 73101)
																									{
																										continue;
																									}
																									skillClass.cType = "truceTrading";
																									if (66475 - 592608 != -526132)
																									{
																										break;
																									}
																									continue;
																								}
																								skillClass.setReq(20, 8);
																								if (8719 - 371850 == -363130)
																								{
																									continue;
																								}
																								skillClass.mode = eSkillMode.instant;
																								if (170899 - 39492 == 131408)
																								{
																									continue;
																								}
																								skillClass.target = eSkillTarget.self;
																								if (40931 - 70879 != -29948)
																								{
																									continue;
																								}
																								skillClass.cType = "mall";
																								if (135880 - 141777 != -5897)
																								{
																									continue;
																								}
																								break;
																							}
																							skillClass.setReq(27, 9);
																							if (58594 - 309015 != -250421)
																							{
																								continue;
																							}
																							skillClass.setSP(-27);
																							if (26793 - 87639 == -60845)
																							{
																								continue;
																							}
																							skillClass.mode = eSkillMode.instant;
																							if (16201 - 570200 == -553998)
																							{
																								continue;
																							}
																							skillClass.target = eSkillTarget.enemy;
																							if (201002 - 146915 != 54087)
																							{
																								continue;
																							}
																							skillClass.cType = "circleShot";
																							if (294386 - 290880 != 3506)
																							{
																								continue;
																							}
																							break;
																						}
																						skillClass.setReq(15, 5);
																						if (22186 - 540192 != -518006)
																						{
																							continue;
																						}
																						skillClass.setSP(-15);
																						if (151842 - 539195 != -387353)
																						{
																							continue;
																						}
																						skillClass.mode = eSkillMode.instant;
																						if (206798 - 382741 != -175943)
																						{
																							continue;
																						}
																						skillClass.target = eSkillTarget.enemy;
																						if (272729 - 543430 == -270700)
																						{
																							continue;
																						}
																						skillClass.cType = "fourShot";
																						if (54946 - 46210 != 8737)
																						{
																							break;
																						}
																						continue;
																					}
																					skillClass.setReq(25, 8);
																					if (69540 - 247590 == -178049)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.instant;
																					if (85757 - 470526 == -384768)
																					{
																						continue;
																					}
																					skillClass.target = eSkillTarget.enemy;
																					if (35976 - 133624 != -97648)
																					{
																						continue;
																					}
																					skillClass.cType = "backpack";
																					if (26928 - 338487 != -311559)
																					{
																						continue;
																					}
																					break;
																				}
																				skillClass.setReq(19, 6);
																				if (260019 - 307380 != -47361)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.passive;
																				if (142947 - 422775 != -279827)
																				{
																					break;
																				}
																				continue;
																			}
																			IL_435:
																			skillClass.setReq(17, 5);
																			if (264376 - 67814 != 196562)
																			{
																				continue;
																			}
																			goto IL_140A;
																			IL_A1A:
																			skillClass.setReq(11, 3);
																			if (285137 - 353101 != -67964)
																			{
																				continue;
																			}
																			goto IL_435;
																			IL_140A:
																			skillClass.setReq(23, 7);
																			if (273960 - 85669 == 188292)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.passive;
																			if (241455 - 61968 != 179487)
																			{
																				continue;
																			}
																			break;
																		}
																		IL_709:
																		skillClass.setReq(21, 3);
																		if (120615 - 343082 != -222467)
																		{
																			continue;
																		}
																		skillClass.setSP(16);
																		if (107074 - 214066 == -106991)
																		{
																			continue;
																		}
																		skillClass.mode = eSkillMode.target;
																		if (72774 - 344336 != -271562)
																		{
																			continue;
																		}
																		skillClass.target = eSkillTarget.enemy;
																		if (206459 - 154119 == 52341)
																		{
																			continue;
																		}
																		skillClass.cType = "gilShot";
																		if (171885 - 178391 != -6506)
																		{
																			continue;
																		}
																		break;
																		IL_1A85:
																		skillClass.setReq(9, 1);
																		if (226575 - 4171 == 222405)
																		{
																			continue;
																		}
																		skillClass.setSP(12);
																		if (193951 - 384754 == -190802)
																		{
																			continue;
																		}
																		IL_2EF6:
																		skillClass.setReq(15, 2);
																		if (147400 - 166505 != -19105)
																		{
																			continue;
																		}
																		skillClass.setSP(14);
																		if (230496 - 582829 != -352332)
																		{
																			goto IL_709;
																		}
																		continue;
																	}
																	skillClass.setReq(40, 25);
																	if (24157 - 280944 == -256786)
																	{
																		continue;
																	}
																	skillClass.setMPSP(30, -50);
																	if (85403 - 428090 == -342686)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.target;
																	if (176911 - 514472 == -337560)
																	{
																		continue;
																	}
																	skillClass.target = eSkillTarget.enemy;
																	if (161122 - 394647 == -233524)
																	{
																		continue;
																	}
																	skillClass.cType = "gorgonShot";
																	if (161208 - 560154 != -398945)
																	{
																		break;
																	}
																	continue;
																}
																skillClass.setReq(27, 18);
																if (232364 - 354090 == -121725)
																{
																	continue;
																}
																IL_2873:
																skillClass.setReq(30, 21);
																if (194460 - 489738 != -295278)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.passive;
																if (183626 - 443162 != -259535)
																{
																	break;
																}
																continue;
															}
															skillClass.setReq(28, 16);
															if (197220 - 164294 == 32927)
															{
																continue;
															}
															skillClass.setMPSP(12, -15);
															if (134238 - 301537 == -167298)
															{
																continue;
															}
															skillClass.mode = eSkillMode.instant;
															if (131677 - 237791 == -106113)
															{
																continue;
															}
															skillClass.target = eSkillTarget.self;
															if (154755 - 71972 != 82783)
															{
																continue;
															}
															skillClass.cType = "acidicField";
															if (260795 - 105644 != 155151)
															{
																continue;
															}
															break;
														}
														skillClass.setReq(20, 8);
														if (181050 - 105994 != 75056)
														{
															continue;
														}
														skillClass.setMPSP(10, -10);
														if (283879 - 340086 == -56206)
														{
															continue;
														}
														skillClass.mode = eSkillMode.instant;
														if (159492 - 318833 == -159340)
														{
															continue;
														}
														skillClass.target = eSkillTarget.self;
														if (205746 - 548404 != -342658)
														{
															continue;
														}
														skillClass.cType = "stickyGum";
														if (176098 - 427134 != -251035)
														{
															break;
														}
														continue;
													}
													IL_8FE:
													skillClass.setReq(27, 9);
													if (102459 - 321968 == -219508)
													{
														continue;
													}
													skillClass.mode = eSkillMode.passive;
													if (52774 - 37041 != 15734)
													{
														break;
													}
													continue;
													IL_166F:
													skillClass.setReq(21, 7);
													if (88324 - 352878 != -264554)
													{
														continue;
													}
													goto IL_8FE;
													IL_2159:
													skillClass.setReq(15, 5);
													if (122955 - 425135 != -302180)
													{
														continue;
													}
													goto IL_166F;
												}
												skillClass.setReq(13, 4);
												if (256949 - 94733 == 162217)
												{
													continue;
												}
												skillClass.setMP(10);
												if (245447 - 40590 == 204858)
												{
													continue;
												}
												IL_339F:
												skillClass.setReq(19, 6);
												if (52320 - 479790 == -427469)
												{
													continue;
												}
												skillClass.setMP(14);
												if (166755 - 335199 == -168443)
												{
													continue;
												}
												skillClass.mode = eSkillMode.instant;
												if (200402 - 166368 != 34034)
												{
													continue;
												}
												skillClass.target = eSkillTarget.self;
												if (109394 - 529882 != -420488)
												{
													continue;
												}
												skillClass.cType = "shake";
												if (237309 - 212058 != 25252)
												{
													break;
												}
												continue;
											}
											skillClass.setReq(11, 3);
											if (293714 - 139628 == 154087)
											{
												continue;
											}
											skillClass.setMP(9);
											if (264039 - 32783 == 231257)
											{
												continue;
											}
											IL_AA4:
											skillClass.setReq(17, 5);
											if (91488 - 176903 == -85414)
											{
												continue;
											}
											skillClass.setMP(12);
											if (161020 - 171791 == -10770)
											{
												continue;
											}
											IL_3239:
											skillClass.setReq(23, 7);
											if (47621 - 316637 == -269015)
											{
												continue;
											}
											skillClass.setMP(15);
											if (134195 - 157037 != -22842)
											{
												continue;
											}
											skillClass.mode = eSkillMode.instant;
											if (98453 - 144110 == -45656)
											{
												continue;
											}
											skillClass.target = eSkillTarget.self;
											if (200757 - 532986 == -332228)
											{
												continue;
											}
											skillClass.cType = "mix";
											if (289927 - 515928 != -226000)
											{
												break;
											}
											continue;
										}
										IL_7AC:
										skillClass.setReq(21, 3);
										if (130432 - 582493 == -452060)
										{
											continue;
										}
										skillClass.setSP(15);
										if (209076 - 429520 != -220444)
										{
											continue;
										}
										skillClass.mode = eSkillMode.target;
										if (132193 - 332969 == -200775)
										{
											continue;
										}
										skillClass.target = eSkillTarget.enemy;
										if (120780 - 240505 == -119724)
										{
											continue;
										}
										skillClass.cType = "maimShot";
										if (232218 - 90822 != 141397)
										{
											break;
										}
										continue;
										IL_101D:
										skillClass.setReq(15, 2);
										if (275116 - 113165 == 161952)
										{
											continue;
										}
										skillClass.setSP(14);
										if (128038 - 389541 != -261502)
										{
											goto IL_7AC;
										}
										continue;
										IL_1C5A:
										skillClass.setReq(9, 1);
										if (4813 - 7048 == -2234)
										{
											continue;
										}
										skillClass.setSP(13);
										if (132244 - 395201 != -262957)
										{
											continue;
										}
										goto IL_101D;
									}
									skillClass.setReq(20, 6);
									if (186808 - 21937 == 164872)
									{
										continue;
									}
									IL_277A:
									skillClass.setReq(30, 8);
									if (233687 - 217794 != 15893)
									{
										continue;
									}
									IL_2C47:
									skillClass.setReq(40, 10);
									if (240534 - 499899 == -259364)
									{
										continue;
									}
									skillClass.mode = eSkillMode.passive;
									if (49499 - 550327 == -500827)
									{
										continue;
									}
									skillClass.target = eSkillTarget.self;
									if (58572 - 565869 != -507296)
									{
										break;
									}
									continue;
								}
								IL_5EC:
								skillClass.setReq(32, 10);
								if (280605 - 16543 != 264062)
								{
									continue;
								}
								skillClass.mode = eSkillMode.passive;
								if (141954 - 33278 == 108677)
								{
									continue;
								}
								skillClass.target = eSkillTarget.all;
								if (23857 - 299125 != -275267)
								{
									break;
								}
								continue;
								IL_2107:
								skillClass.setReq(16, 6);
								if (297132 - 41612 == 255521)
								{
									continue;
								}
								IL_290C:
								skillClass.setReq(24, 8);
								if (27553 - 536505 != -508951)
								{
									goto IL_5EC;
								}
								continue;
							}
							skillClass.setReq(12, 4);
							if (216391 - 289700 == -73308)
							{
								continue;
							}
							skillClass.setSP(-8);
							if (189908 - 79328 != 110580)
							{
								continue;
							}
							skillClass.mode = eSkillMode.instant;
							if (135496 - 376333 != -240837)
							{
								continue;
							}
							skillClass.target = eSkillTarget.self;
							if (129746 - 525363 == -395616)
							{
								continue;
							}
							skillClass.cType = "bounce";
							if (225441 - 43793 != 181648)
							{
								continue;
							}
							break;
						}
						IL_1DC1:
						skillClass.setReq(16, 3);
						if (178327 - 478285 == -299957)
						{
							continue;
						}
						skillClass.mode = eSkillMode.passive;
						if (124475 - 343803 == -219327)
						{
							continue;
						}
						skillClass.target = eSkillTarget.enemy;
						if (239430 - 243220 != -3790)
						{
							continue;
						}
						skillClass.cType = "cAttack";
						if (169068 - 522922 != -353853)
						{
							break;
						}
						continue;
						IL_2BBE:
						skillClass.setReq(10, 2);
						if (117928 - 79164 != 38765)
						{
							goto IL_1DC1;
						}
						continue;
					}
					IL_2C02:
					skillClass.setReq(3, 0);
					if (10429 - 578376 == -567946)
					{
						continue;
					}
					IL_2D19:
					skillClass.setReq(4, 0);
					if (249209 - 237210 == 12000)
					{
						continue;
					}
					skillClass.mode = eSkillMode.passive;
					if (216186 - 94153 == 122034)
					{
						continue;
					}
					skillClass.target = eSkillTarget.enemy;
					if (27809 - 285991 != -258182)
					{
						continue;
					}
					skillClass.cType = "nAttack";
					if (256487 - 51337 != 205151)
					{
						break;
					}
					continue;
					IL_358B:
					skillClass.setReq(2, 0);
					if (23963 - 381972 != -358008)
					{
						goto IL_2C02;
					}
				}
			}
		}
		return skillClass;
	}

	// Token: 0x06003198 RID: 12696 RVA: 0x0064F008 File Offset: 0x0064D208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillTree(int commandNum)
	{
		if (162125 - 284498 != -122372)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (127591 - 76835 != 50757 && 280382 - 310094 != -29711)
			{
				if (commandNum == 101)
				{
					if (9330 - 587823 == -578493)
					{
						result = "rab_nAttack1";
						if (17695 - 438811 != -421115)
						{
							break;
						}
					}
				}
				else if (commandNum == 102)
				{
					if (138318 - 423126 != -284807)
					{
						result = "rab_nAttack2";
						if (56647 - 14269 == 42378)
						{
							break;
						}
					}
				}
				else if (commandNum == 103)
				{
					if (250461 - 194184 == 56277)
					{
						result = "rab_nAttack3";
						if (84810 - 178229 == -93419)
						{
							break;
						}
					}
				}
				else if (commandNum == 104)
				{
					if (197864 - 59565 == 138299)
					{
						result = "rab_nAttack4";
						if (179163 - 563169 != -384005)
						{
							break;
						}
					}
				}
				else if (commandNum == 111)
				{
					if (295228 - 273695 == 21533)
					{
						result = "rab_cAttack1";
						if (257893 - 176399 == 81494)
						{
							break;
						}
					}
				}
				else if (commandNum == 112)
				{
					if (253978 - 320241 != -66262)
					{
						result = "rab_cAttack2";
						if (141434 - 270372 == -128938)
						{
							break;
						}
					}
				}
				else if (commandNum == 113)
				{
					if (260954 - 78313 == 182641)
					{
						result = "rab_cAttack3";
						if (291508 - 201418 == 90090)
						{
							break;
						}
					}
				}
				else if (commandNum == 114)
				{
					if (39741 - 488688 != -448946)
					{
						result = "rab_statScan1";
						if (153289 - 560179 != -406889)
						{
							break;
						}
					}
				}
				else if (commandNum == 121)
				{
					if (187513 - 203327 != -15813)
					{
						result = "rab_bounce1";
						if (233613 - 297384 == -63771)
						{
							break;
						}
					}
				}
				else if (commandNum == 122)
				{
					if (271797 - 557378 != -285580)
					{
						result = "rab_bounce2";
						if (170993 - 34060 == 136933)
						{
							break;
						}
					}
				}
				else if (commandNum == 131)
				{
					if (223704 - 295405 != -71700)
					{
						result = "rab_hyperShot1";
						if (72213 - 388223 != -316009)
						{
							break;
						}
					}
				}
				else if (commandNum == 132)
				{
					if (177201 - 193420 == -16219)
					{
						result = "rab_hyperShot2";
						if (76550 - 242964 == -166414)
						{
							break;
						}
					}
				}
				else if (commandNum == 133)
				{
					if (229559 - 47548 != 182012)
					{
						result = "rab_hyperShot3";
						if (274901 - 22534 != 252368)
						{
							break;
						}
					}
				}
				else if (commandNum == 134)
				{
					if (108475 - 70668 != 37808)
					{
						result = "rab_hyperShot4";
						if (98018 - 318934 == -220916)
						{
							break;
						}
					}
				}
				else if (commandNum == 141)
				{
					if (32876 - 257266 == -224390)
					{
						result = "rab_statPlus1";
						if (72807 - 178951 != -106143)
						{
							break;
						}
					}
				}
				else if (commandNum == 142)
				{
					if (192670 - 345677 != -153006)
					{
						result = "rab_statPlus2";
						if (273108 - 16212 != 256897)
						{
							break;
						}
					}
				}
				else if (commandNum == 143)
				{
					if (118157 - 541416 != -423258)
					{
						result = "rab_statPlus3";
						if (93377 - 425058 == -331681)
						{
							break;
						}
					}
				}
				else if (commandNum == 144)
				{
					if (219527 - 300160 != -80632)
					{
						result = "rab_statPlus4";
						if (22679 - 27977 == -5298)
						{
							break;
						}
					}
				}
				else if (commandNum == 201)
				{
					if (42694 - 537655 != -494960)
					{
						result = "rab_maimShot1";
						if (64024 - 237585 == -173561)
						{
							break;
						}
					}
				}
				else if (commandNum == 202)
				{
					if (93688 - 252919 == -159231)
					{
						result = "rab_maimShot2";
						if (176155 - 174743 == 1412)
						{
							break;
						}
					}
				}
				else if (commandNum == 203)
				{
					if (120978 - 291434 != -170455)
					{
						result = "rab_maimShot3";
						if (154430 - 12176 != 142255)
						{
							break;
						}
					}
				}
				else if (commandNum == 204)
				{
					if (69376 - 317552 == -248176)
					{
						result = "rab_maimShot4";
						if (289273 - 202122 != 87152)
						{
							break;
						}
					}
				}
				else if (commandNum == 211)
				{
					if (246253 - 530479 != -284225)
					{
						result = "rab_mix1";
						if (137150 - 416558 != -279407)
						{
							break;
						}
					}
				}
				else if (commandNum == 212)
				{
					if (172980 - 409722 == -236742)
					{
						result = "rab_mix2";
						if (41625 - 189336 == -147711)
						{
							break;
						}
					}
				}
				else if (commandNum == 213)
				{
					if (291807 - 570708 != -278900)
					{
						result = "rab_mix3";
						if (67218 - 493658 == -426440)
						{
							break;
						}
					}
				}
				else if (commandNum == 214)
				{
					if (263940 - 135054 != 128887)
					{
						result = "rab_mix4";
						if (130048 - 208526 == -78478)
						{
							break;
						}
					}
				}
				else if (commandNum == 221)
				{
					if (213688 - 47066 == 166622)
					{
						result = "rab_shake1";
						if (121269 - 53127 == 68142)
						{
							break;
						}
					}
				}
				else if (commandNum == 222)
				{
					if (156638 - 147217 == 9421)
					{
						result = "rab_shake2";
						if (227687 - 54028 != 173660)
						{
							break;
						}
					}
				}
				else if (commandNum == 223)
				{
					if (22949 - 323012 == -300063)
					{
						result = "rab_shake3";
						if (89545 - 572416 == -482871)
						{
							break;
						}
					}
				}
				else if (commandNum == 224)
				{
					if (234744 - 472825 == -238081)
					{
						result = "rab_miracleBlend1";
						if (129143 - 78867 == 50276)
						{
							break;
						}
					}
				}
				else if (commandNum == 231)
				{
					if (260388 - 111915 != 148474)
					{
						result = "rab_alchemistLab1";
						if (169152 - 511632 != -342479)
						{
							break;
						}
					}
				}
				else if (commandNum == 232)
				{
					if (24418 - 163933 == -139515)
					{
						result = "rab_alchemistLab2";
						if (171793 - 126940 == 44853)
						{
							break;
						}
					}
				}
				else if (commandNum == 233)
				{
					if (87366 - 73137 == 14229)
					{
						result = "rab_alchemistLab3";
						if (38260 - 1189 != 37072)
						{
							break;
						}
					}
				}
				else if (commandNum == 234)
				{
					if (255869 - 478012 == -222143)
					{
						result = "rab_alchemistLab4";
						if (204602 - 469102 == -264500)
						{
							break;
						}
					}
				}
				else if (commandNum == 241)
				{
					if (235056 - 389422 == -154366)
					{
						result = "rab_stickyGum1";
						if (163081 - 534447 != -371365)
						{
							break;
						}
					}
				}
				else if (commandNum == 242)
				{
					if (295143 - 143028 != 152116)
					{
						result = "rab_stickyGum2";
						if (269096 - 469988 == -200892)
						{
							break;
						}
					}
				}
				else if (commandNum == 243)
				{
					if (245390 - 143503 == 101887)
					{
						result = "rab_acidicField1";
						if (30756 - 584206 == -553450)
						{
							break;
						}
					}
				}
				else if (commandNum == 244)
				{
					if (34492 - 566090 != -531597)
					{
						result = "rab_acidicField2";
						if (19022 - 289450 != -270427)
						{
							break;
						}
					}
				}
				else if (commandNum == 251)
				{
					if (198333 - 232586 == -34253)
					{
						result = "rab_immuneShot1";
						if (277513 - 413173 == -135660)
						{
							break;
						}
					}
				}
				else if (commandNum == 252)
				{
					if (95972 - 454288 != -358315)
					{
						result = "rab_boostShot2";
						if (33301 - 228058 != -194756)
						{
							break;
						}
					}
				}
				else if (commandNum == 253)
				{
					if (285525 - 433139 != -147613)
					{
						result = "rab_heatShot3";
						if (112984 - 445147 == -332163)
						{
							break;
						}
					}
				}
				else if (commandNum == 254)
				{
					if (126058 - 160986 != -34927)
					{
						result = "rab_lifeShot4";
						if (263176 - 11962 == 251214)
						{
							break;
						}
					}
				}
				else if (commandNum == 261)
				{
					if (280814 - 341976 == -61162)
					{
						result = "rab_medicalEnhancement1";
						if (156412 - 257768 != -101355)
						{
							break;
						}
					}
				}
				else if (commandNum == 262)
				{
					if (52725 - 261240 == -208515)
					{
						result = "rab_medicalEnhancement2";
						if (241132 - 42007 == 199125)
						{
							break;
						}
					}
				}
				else if (commandNum == 263)
				{
					if (173287 - 296763 == -123476)
					{
						result = "rab_medicalEnhancement3";
						if (206387 - 510204 != -303816)
						{
							break;
						}
					}
				}
				else if (commandNum == 264)
				{
					if (75780 - 70986 != 4795)
					{
						result = "rab_rapidTrance1";
						if (183867 - 333846 == -149979)
						{
							break;
						}
					}
				}
				else if (commandNum == 271)
				{
					if (61467 - 362070 == -300603)
					{
						result = "rab_gorgonShot1";
						if (131431 - 511536 == -380105)
						{
							break;
						}
					}
				}
				else if (commandNum == 272)
				{
					if (236600 - 313518 == -76918)
					{
						result = "rab_gorgonShot2";
						if (159780 - 266887 != -107106)
						{
							break;
						}
					}
				}
				else if (commandNum == 301)
				{
					if (35243 - 195529 == -160286)
					{
						result = "rab_gilShot1";
						if (266384 - 248813 == 17571)
						{
							break;
						}
					}
				}
				else if (commandNum == 302)
				{
					if (70199 - 218466 != -148266)
					{
						result = "rab_gilShot2";
						if (178615 - 364168 != -185552)
						{
							break;
						}
					}
				}
				else if (commandNum == 303)
				{
					if (236169 - 18843 != 217327)
					{
						result = "rab_gilShot3";
						if (5689 - 569877 == -564188)
						{
							break;
						}
					}
				}
				else if (commandNum == 304)
				{
					if (146696 - 408675 == -261979)
					{
						result = "rab_gilShot4";
						if (76660 - 186094 != -109433)
						{
							break;
						}
					}
				}
				else if (commandNum == 311)
				{
					if (166431 - 363924 != -197492)
					{
						result = "rab_bunnyBargain1";
						if (69965 - 372602 == -302637)
						{
							break;
						}
					}
				}
				else if (commandNum == 312)
				{
					if (87175 - 489065 != -401889)
					{
						result = "rab_bunnyBargain2";
						if (64045 - 227667 == -163622)
						{
							break;
						}
					}
				}
				else if (commandNum == 313)
				{
					if (274753 - 551117 == -276364)
					{
						result = "rab_bunnyBargain3";
						if (45900 - 249889 == -203989)
						{
							break;
						}
					}
				}
				else if (commandNum == 314)
				{
					if (241444 - 415562 == -174118)
					{
						result = "rab_bunnyBargain4";
						if (206143 - 81560 != 124584)
						{
							break;
						}
					}
				}
				else if (commandNum == 321)
				{
					if (37578 - 472795 == -435217)
					{
						result = "rab_herbFinder1";
						if (166400 - 87203 == 79197)
						{
							break;
						}
					}
				}
				else if (commandNum == 322)
				{
					if (59766 - 168965 != -109198)
					{
						result = "rab_backpack1";
						if (16635 - 144552 == -127917)
						{
							break;
						}
					}
				}
				else if (commandNum == 323)
				{
					if (285074 - 267712 == 17362)
					{
						result = "rab_herbFinder2";
						if (245570 - 132847 != 112724)
						{
							break;
						}
					}
				}
				else if (commandNum == 324)
				{
					if (56092 - 344439 == -288347)
					{
						result = "rab_backpack2";
						if (99838 - 353141 == -253303)
						{
							break;
						}
					}
				}
				else if (commandNum == 331)
				{
					if (68887 - 598879 == -529992)
					{
						result = "rab_fourShot1";
						if (4158 - 291768 != -287609)
						{
							break;
						}
					}
				}
				else if (commandNum == 332)
				{
					if (63314 - 205230 == -141916)
					{
						result = "rab_fourShot2";
						if (40946 - 105592 == -64646)
						{
							break;
						}
					}
				}
				else if (commandNum == 333)
				{
					if (220249 - 71096 == 149153)
					{
						result = "rab_circleShot1";
						if (230239 - 560868 != -330628)
						{
							break;
						}
					}
				}
				else if (commandNum == 334)
				{
					if (92479 - 172019 != -79539)
					{
						result = "rab_circleShot2";
						if (92305 - 194336 == -102031)
						{
							break;
						}
					}
				}
				else if (commandNum == 341)
				{
					if (181520 - 562900 != -381379)
					{
						result = "rab_mall1";
						if (211606 - 5484 == 206122)
						{
							break;
						}
					}
				}
				else if (commandNum == 342)
				{
					if (25147 - 116600 == -91453)
					{
						result = "rab_mall2";
						if (276443 - 201133 == 75310)
						{
							break;
						}
					}
				}
				else if (commandNum == 343)
				{
					if (269988 - 84080 == 185908)
					{
						result = "rab_truceTrading&Co1";
						if (78293 - 436962 == -358669)
						{
							break;
						}
					}
				}
				else if (commandNum == 344)
				{
					if (246646 - 557182 != -310535)
					{
						result = "rab_truceTrading&Co2";
						if (67626 - 110941 != -43314)
						{
							break;
						}
					}
				}
				else if (commandNum == 351)
				{
					if (203285 - 140846 != 62440)
					{
						result = "rab_shootingArray1";
						if (96884 - 139990 == -43106)
						{
							break;
						}
					}
				}
				else if (commandNum == 352)
				{
					if (76493 - 280526 == -204033)
					{
						result = "rab_shootingArray2";
						if (230841 - 428512 == -197671)
						{
							break;
						}
					}
				}
				else if (commandNum == 353)
				{
					if (266526 - 468573 != -202046)
					{
						result = "rab_customizedShotgun1";
						if (277050 - 268809 == 8241)
						{
							break;
						}
					}
				}
				else if (commandNum == 354)
				{
					if (212890 - 32717 == 180173)
					{
						result = "rab_customizedShotgun2";
						if (281218 - 33546 == 247672)
						{
							break;
						}
					}
				}
				else if (commandNum == 361)
				{
					if (226990 - 542720 == -315730)
					{
						result = "rab_specialDeal1";
						if (232545 - 338650 != -106104)
						{
							break;
						}
					}
				}
				else if (commandNum == 362)
				{
					if (164870 - 472304 != -307433)
					{
						result = "rab_specialDeal2";
						if (56576 - 135300 == -78724)
						{
							break;
						}
					}
				}
				else if (commandNum == 363)
				{
					if (185045 - 347948 == -162903)
					{
						result = "rab_specialDeal3";
						if (112601 - 455825 != -343223)
						{
							break;
						}
					}
				}
				else if (commandNum == 364)
				{
					if (167028 - 221687 == -54659)
					{
						result = "rab_specialDeal4";
						if (158001 - 127340 != 30662)
						{
							break;
						}
					}
				}
				else if (commandNum == 371)
				{
					if (106585 - 159252 == -52667)
					{
						result = "rab_millionaire1";
						if (117959 - 376479 == -258520)
						{
							break;
						}
					}
				}
				else if (commandNum == 372)
				{
					if (132157 - 190305 != -58147)
					{
						result = "rab_millionaire2";
						if (162129 - 474160 == -312031)
						{
							break;
						}
					}
				}
				else if (commandNum == 401)
				{
					if (1600 - 164399 != -162798)
					{
						result = "rab_bouncingBullet5";
						if (238809 - 92931 == 145878)
						{
							break;
						}
					}
				}
				else if (commandNum == 411)
				{
					if (123351 - 542232 != -418880)
					{
						result = "rab_deadShot5";
						if (286355 - 318930 == -32575)
						{
							break;
						}
					}
				}
				else if (commandNum == 421)
				{
					if (155603 - 402702 == -247099)
					{
						result = "rab_fromTheAbove5";
						if (149666 - 436633 == -286967)
						{
							break;
						}
					}
				}
				else if (commandNum == 431)
				{
					if (186756 - 210151 == -23395)
					{
						result = "rab_snipeMastery5";
						if (280547 - 368669 == -88122)
						{
							break;
						}
					}
				}
				else if (commandNum == 441)
				{
					if (134703 - 396729 == -262026)
					{
						result = "rab_superStatPlus5";
						if (70561 - 518513 != -447951)
						{
							break;
						}
					}
				}
				else if (commandNum == 402)
				{
					if (179981 - 53268 != 126714)
					{
						result = "rab_kneeShot5";
						if (225238 - 575174 != -349935)
						{
							break;
						}
					}
				}
				else if (commandNum == 412)
				{
					if (153456 - 533304 != -379847)
					{
						result = "rab_extraPotion5";
						if (31508 - 37355 != -5846)
						{
							break;
						}
					}
				}
				else if (commandNum == 422)
				{
					if (166732 - 330684 == -163952)
					{
						result = "rab_miracleDrop5";
						if (95852 - 542415 != -446562)
						{
							break;
						}
					}
				}
				else if (commandNum == 432)
				{
					if (267658 - 558905 == -291247)
					{
						result = "rab_medResearch5";
						if (83850 - 349318 != -265467)
						{
							break;
						}
					}
				}
				else if (commandNum == 442)
				{
					if (293846 - 502227 == -208381)
					{
						result = "rab_healingField5";
						if (17587 - 19590 != -2002)
						{
							break;
						}
					}
				}
				else if (commandNum == 403)
				{
					if (188172 - 446890 == -258718)
					{
						result = "rab_diamondShot5";
						if (118907 - 217587 != -98679)
						{
							break;
						}
					}
				}
				else if (commandNum == 413)
				{
					if (40454 - 581770 == -541316)
					{
						result = "rab_skillBargain5";
						if (215793 - 415377 != -199583)
						{
							break;
						}
					}
				}
				else if (commandNum == 423)
				{
					if (53206 - 415724 == -362518)
					{
						result = "rab_bigBag5";
						if (6519 - 38054 == -31535)
						{
							break;
						}
					}
				}
				else if (commandNum == 433)
				{
					if (263281 - 236019 == 27262)
					{
						result = "rab_tenShot5";
						if (184304 - 100366 == 83938)
						{
							break;
						}
					}
				}
				else if (commandNum == 443)
				{
					if (130289 - 515783 == -385494)
					{
						result = "rab_extravagance5";
						if (72968 - 77260 != -4291)
						{
							break;
						}
					}
				}
				else if (commandNum == 404)
				{
					if (93768 - 184937 != -91168)
					{
						result = "rab_revisedSkill5";
						if (146402 - 28166 == 118236)
						{
							break;
						}
					}
				}
				else if (commandNum == 414)
				{
					if (255475 - 505181 != -249705)
					{
						result = "rab_revisedMagic5";
						if (257950 - 28943 == 229007)
						{
							break;
						}
					}
				}
				else if (commandNum == 424)
				{
					if (182174 - 430312 == -248138)
					{
						result = "rab_revisedArt5";
						if (242539 - 566125 != -323585)
						{
							break;
						}
					}
				}
				else if (commandNum == 434)
				{
					if (244740 - 383945 == -139205)
					{
						result = "rab_contract5";
						if (97131 - 150944 != -53812)
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
					if (251103 - 346746 != -95642)
					{
						result = "rab_newOrder5";
						if (74107 - 512729 == -438622)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06003199 RID: 12697 RVA: 0x00650CB4 File Offset: 0x0064EEB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600319A RID: 12698 RVA: 0x00650CB8 File Offset: 0x0064EEB8
	internal static bool rxqV4F53RADR1ppjA4Zr()
	{
		return true;
	}

	// Token: 0x0600319B RID: 12699 RVA: 0x00650CBC File Offset: 0x0064EEBC
	internal static bool hrGFUl53wF1UL3lLvJJV()
	{
		return false;
	}
}
