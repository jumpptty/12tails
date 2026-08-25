using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020009B6 RID: 2486
[Serializable]
public class WhaleSkill : MonoBehaviour
{
	// Token: 0x0600365F RID: 13919 RVA: 0x0070ED4C File Offset: 0x0070CF4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WhaleSkill()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003660 RID: 13920 RVA: 0x0070ED5C File Offset: 0x0070CF5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSkill(string skillname)
	{
		if (28507 - 123336 != -94828)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (163177 - 34977 == 128200)
			{
				if (115901 - 65830 == 50071)
				{
					if (skillname == "whl_nAttack1")
					{
						if (177282 - 455158 == -277875)
						{
							continue;
						}
						skillClass.setReq(1, 0);
						if (293153 - 194958 == 98196)
						{
							continue;
						}
					}
					else if (skillname == "whl_nAttack2")
					{
						if (18755 - 397734 == -378978)
						{
							continue;
						}
					}
					else
					{
						if (skillname == "whl_cAttack1")
						{
							if (150258 - 216039 != -65781)
							{
								continue;
							}
							skillClass.setReq(4, 1);
							if (277961 - 409070 != -131109)
							{
								continue;
							}
						}
						else if (skillname == "whl_cAttack2")
						{
							if (18272 - 261445 != -243173)
							{
								continue;
							}
						}
						else if (skillname == "whl_cAttack3")
						{
							if (226884 - 93330 != 133554)
							{
								continue;
							}
							goto IL_230F;
						}
						else if (skillname == "whl_shieldBash1")
						{
							if (1130 - 568971 != -567841)
							{
								continue;
							}
							skillClass.setReq(22, 4);
							if (98283 - 538650 == -440366)
							{
								continue;
							}
							skillClass.mode = eSkillMode.passive;
							if (46384 - 315805 != -269420)
							{
								break;
							}
							continue;
						}
						else
						{
							if (skillname == "whl_culinaryTongue1")
							{
								if (86977 - 476241 != -389264)
								{
									continue;
								}
								skillClass.setReq(6, 2);
								if (49842 - 383533 != -333691)
								{
									continue;
								}
							}
							else if (skillname == "whl_culinaryTongue2")
							{
								if (55067 - 167126 != -112059)
								{
									continue;
								}
							}
							else
							{
								if (skillname == "whl_superSize1")
								{
									if (166994 - 46081 == 120914)
									{
										continue;
									}
									skillClass.setReq(8, 4);
									if (144836 - 578997 != -434160)
									{
										goto IL_1388;
									}
									continue;
								}
								else if (skillname == "whl_superSize2")
								{
									if (153559 - 132695 != 20864)
									{
										continue;
									}
									goto IL_1388;
								}
								else if (skillname == "whl_superSize3")
								{
									if (276748 - 99670 != 177078)
									{
										continue;
									}
								}
								else if (skillname == "whl_superSize4")
								{
									if (237982 - 554564 != -316582)
									{
										continue;
									}
									goto IL_32D5;
								}
								else
								{
									if (skillname == "whl_statPlus1")
									{
										if (76691 - 268606 != -191915)
										{
											continue;
										}
										skillClass.setReq(10, 4);
										if (236418 - 5855 != 230563)
										{
											continue;
										}
										goto IL_3511;
									}
									else if (skillname == "whl_statPlus2")
									{
										if (103670 - 230339 != -126669)
										{
											continue;
										}
										goto IL_3511;
									}
									else if (skillname == "whl_statPlus3")
									{
										if (103082 - 313695 == -210612)
										{
											continue;
										}
									}
									else if (skillname == "whl_statPlus4")
									{
										if (35991 - 539464 != -503472)
										{
											goto IL_2089;
										}
										continue;
									}
									else
									{
										if (skillname == "whl_sweep1")
										{
											if (263566 - 13600 != 249966)
											{
												continue;
											}
											skillClass.setReq(3, 0);
											if (112531 - 469392 != -356861)
											{
												continue;
											}
											skillClass.setSP(12);
											if (241193 - 363050 != -121857)
											{
												continue;
											}
										}
										else if (skillname == "whl_sweep2")
										{
											if (27043 - 204654 == -177610)
											{
												continue;
											}
										}
										else
										{
											if (skillname == "whl_javelin1")
											{
												if (17515 - 414215 == -396699)
												{
													continue;
												}
												skillClass.setReq(15, 2);
												if (172225 - 31497 == 140729)
												{
													continue;
												}
												skillClass.setSP(-8);
												if (127006 - 163434 == -36427)
												{
													continue;
												}
											}
											else if (skillname == "whl_javelin2")
											{
												if (287492 - 342034 != -54542)
												{
													continue;
												}
											}
											else
											{
												if (skillname == "whl_honor1")
												{
													if (164357 - 51302 != 113055)
													{
														continue;
													}
													skillClass.setReq(5, 1);
													if (43535 - 399675 == -356139)
													{
														continue;
													}
													skillClass.setMP(10);
													if (480 - 51848 != -51368)
													{
														continue;
													}
													goto IL_5BF;
												}
												else if (skillname == "whl_honor2")
												{
													if (146630 - 140196 != 6434)
													{
														continue;
													}
													goto IL_5BF;
												}
												else if (skillname == "whl_honor3")
												{
													if (7728 - 228439 == -220710)
													{
														continue;
													}
												}
												else if (skillname == "whl_honor4")
												{
													if (155621 - 85976 != 69645)
													{
														continue;
													}
													goto IL_17DE;
												}
												else
												{
													if (skillname == "whl_shieldRush1")
													{
														if (93443 - 420286 != -326843)
														{
															continue;
														}
														skillClass.setReq(7, 2);
														if (182462 - 119742 != 62720)
														{
															continue;
														}
														skillClass.setSP(15);
														if (230118 - 459986 == -229867)
														{
															continue;
														}
													}
													else if (skillname == "whl_shieldRush2")
													{
														if (170685 - 386611 == -215925)
														{
															continue;
														}
													}
													else
													{
														if (skillname == "whl_flyingShield1")
														{
															if (53016 - 320984 == -267967)
															{
																continue;
															}
															skillClass.setReq(19, 6);
															if (89220 - 331009 != -241789)
															{
																continue;
															}
															skillClass.setSP(16);
															if (204721 - 578886 != -374165)
															{
																continue;
															}
														}
														else if (skillname == "whl_flyingShield2")
														{
															if (138608 - 172700 != -34092)
															{
																continue;
															}
														}
														else
														{
															if (skillname == "whl_swallow1")
															{
																if (266733 - 264157 == 2577)
																{
																	continue;
																}
																skillClass.setReq(9, 3);
																if (247047 - 498299 == -251251)
																{
																	continue;
																}
																skillClass.setSP(-10);
																if (197319 - 584785 == -387465)
																{
																	continue;
																}
															}
															else if (skillname == "whl_swallow2")
															{
																if (167155 - 108139 != 59016)
																{
																	continue;
																}
															}
															else if (skillname == "whl_gobbleUp1")
															{
																if (82841 - 324640 == -241798)
																{
																	continue;
																}
																skillClass.setReq(21, 7);
																if (271390 - 97363 == 174028)
																{
																	continue;
																}
																skillClass.setSP(-5);
																if (286153 - 380320 != -94167)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.instant;
																if (179161 - 51718 != 127443)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.all;
																if (58435 - 440409 != -381974)
																{
																	continue;
																}
																skillClass.cType = "gobbleUp";
																if (133511 - 407601 != -274089)
																{
																	break;
																}
																continue;
															}
															else
															{
																if (skillname == "whl_peninsulaImpale1")
																{
																	if (217608 - 433160 == -215551)
																	{
																		continue;
																	}
																	skillClass.setReq(16, 4);
																	if (8693 - 126388 == -117694)
																	{
																		continue;
																	}
																	skillClass.setSP(-18);
																	if (226680 - 373021 == -146340)
																	{
																		continue;
																	}
																}
																else if (skillname == "whl_peninsulaImpale2")
																{
																	if (144344 - 456981 != -312637)
																	{
																		continue;
																	}
																}
																else
																{
																	if (skillname == "whl_peninsulaRound1")
																	{
																		if (133404 - 544151 != -410747)
																		{
																			continue;
																		}
																		skillClass.setReq(24, 12);
																		if (1396 - 460232 != -458836)
																		{
																			continue;
																		}
																		skillClass.setMPSP(10, -21);
																		if (207658 - 132561 == 75098)
																		{
																			continue;
																		}
																	}
																	else if (skillname == "whl_peninsulaRound2")
																	{
																		if (138679 - 212238 == -73558)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (skillname == "whl_wallPuncture1")
																		{
																			if (72248 - 25964 == 46285)
																			{
																				continue;
																			}
																			skillClass.setReq(20, 12);
																			if (35318 - 49891 != -14572)
																			{
																				goto IL_1AF4;
																			}
																			continue;
																		}
																		else if (skillname == "whl_wallPuncture2")
																		{
																			if (25921 - 46689 != -20768)
																			{
																				continue;
																			}
																			goto IL_1AF4;
																		}
																		else if (skillname == "whl_wallPuncture3")
																		{
																			if (111085 - 473371 != -362286)
																			{
																				continue;
																			}
																			goto IL_1BA0;
																		}
																		else if (skillname == "whl_wallPuncture4")
																		{
																			if (146549 - 528275 == -381725)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (skillname == "whl_autoShield1")
																			{
																				if (235718 - 491205 == -255486)
																				{
																					continue;
																				}
																				skillClass.setReq(24, 15);
																				if (144944 - 360699 != -215755)
																				{
																					continue;
																				}
																				goto IL_1685;
																			}
																			else if (skillname == "whl_autoShield2")
																			{
																				if (80463 - 158542 != -78079)
																				{
																					continue;
																				}
																				goto IL_1685;
																			}
																			else if (skillname == "whl_autoShield3")
																			{
																				if (274921 - 124004 == 150918)
																				{
																					continue;
																				}
																			}
																			else if (skillname == "whl_lastHope1")
																			{
																				if (208207 - 79248 == 128960)
																				{
																					continue;
																				}
																				skillClass.setReq(33, 24);
																				if (134800 - 374020 == -239219)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.passive;
																				if (270872 - 398168 != -127295)
																				{
																					break;
																				}
																				continue;
																			}
																			else
																			{
																				if (skillname == "whl_12thKingdomKnight1")
																				{
																					if (195289 - 240142 != -44853)
																					{
																						continue;
																					}
																					skillClass.setReq(35, 23);
																					if (218593 - 115289 != 103304)
																					{
																						continue;
																					}
																					skillClass.setSP(-45);
																					if (285196 - 31096 != 254100)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "whl_12thKingdomKnight2")
																				{
																					if (17798 - 32520 != -14722)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "whl_knightOfTheDeep1")
																				{
																					if (38613 - 559876 != -521263)
																					{
																						continue;
																					}
																					skillClass.setReq(45, 27);
																					if (273080 - 195588 == 77493)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.passive;
																					if (218632 - 245847 != -27215)
																					{
																						continue;
																					}
																					break;
																				}
																				else
																				{
																					if (skillname == "whl_bubbleShield1")
																					{
																						if (24587 - 92035 != -67448)
																						{
																							continue;
																						}
																						skillClass.setReq(3, 0);
																						if (49386 - 541158 == -491771)
																						{
																							continue;
																						}
																						skillClass.setMP(6);
																						if (24194 - 61878 != -37684)
																						{
																							continue;
																						}
																						goto IL_16CB;
																					}
																					else if (skillname == "whl_bubbleShield2")
																					{
																						if (183177 - 381370 != -198193)
																						{
																							continue;
																						}
																						goto IL_16CB;
																					}
																					else if (skillname == "whl_bubbleShield3")
																					{
																						if (200929 - 435482 != -234553)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "whl_bubbleShield4")
																					{
																						if (180021 - 493791 != -313770)
																						{
																							continue;
																						}
																						goto IL_1126;
																					}
																					else
																					{
																						if (skillname == "whl_heavyWeight1")
																						{
																							if (181686 - 478330 == -296643)
																							{
																								continue;
																							}
																							skillClass.setReq(5, 1);
																							if (64623 - 530675 == -466051)
																							{
																								continue;
																							}
																							skillClass.setMP(10);
																							if (9033 - 59082 != -50049)
																							{
																								continue;
																							}
																						}
																						else if (skillname == "whl_heavyWeight2")
																						{
																							if (88760 - 539823 != -451063)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							if (skillname == "whl_overPresence1")
																							{
																								if (214722 - 458262 == -243539)
																								{
																									continue;
																								}
																								skillClass.setReq(17, 5);
																								if (64434 - 202053 == -137618)
																								{
																									continue;
																								}
																							}
																							else if (skillname == "whl_overPresence2")
																							{
																								if (234348 - 108679 != 125669)
																								{
																									continue;
																								}
																							}
																							else
																							{
																								if (skillname == "whl_hydroBlast1")
																								{
																									if (253771 - 66716 == 187056)
																									{
																										continue;
																									}
																									skillClass.setReq(7, 2);
																									if (191162 - 46773 == 144390)
																									{
																										continue;
																									}
																									skillClass.setMP(8);
																									if (170651 - 117812 != 52839)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "whl_hydroBlast2")
																								{
																									if (164118 - 542241 != -378123)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "whl_hydroBlast3")
																								{
																									if (7532 - 470095 != -462563)
																									{
																										continue;
																									}
																									goto IL_2D9C;
																								}
																								else if (skillname == "whl_hydroBlast4")
																								{
																									if (57470 - 562753 != -505283)
																									{
																										continue;
																									}
																									goto IL_131C;
																								}
																								else
																								{
																									if (skillname == "whl_rejuvenate1")
																									{
																										if (262203 - 218424 == 43780)
																										{
																											continue;
																										}
																										skillClass.setReq(9, 3);
																										if (47182 - 37488 == 9695)
																										{
																											continue;
																										}
																										skillClass.setMP(10);
																										if (190040 - 345065 != -155025)
																										{
																											continue;
																										}
																									}
																									else if (skillname == "whl_rejuvenate2")
																									{
																										if (140767 - 328515 == -187747)
																										{
																											continue;
																										}
																									}
																									else if (skillname == "whl_rejuvenate3")
																									{
																										if (80829 - 15901 != 64928)
																										{
																											continue;
																										}
																										goto IL_D54;
																									}
																									else if (skillname == "whl_rejuvenate4")
																									{
																										if (127169 - 542904 != -415734)
																										{
																											goto IL_2E55;
																										}
																										continue;
																									}
																									else
																									{
																										if (skillname == "whl_whaleWave1")
																										{
																											if (91859 - 384922 != -293063)
																											{
																												continue;
																											}
																											skillClass.setReq(16, 4);
																											if (902 - 207899 == -206996)
																											{
																												continue;
																											}
																											skillClass.setSP(-12);
																											if (139874 - 220836 == -80961)
																											{
																												continue;
																											}
																										}
																										else if (skillname == "whl_whaleWave2")
																										{
																											if (107272 - 478937 != -371665)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											if (skillname == "whl_malStorm1")
																											{
																												if (120997 - 138909 == -17911)
																												{
																													continue;
																												}
																												skillClass.setReq(24, 12);
																												if (73155 - 211000 == -137844)
																												{
																													continue;
																												}
																												skillClass.setMPSP(16, -20);
																												if (197916 - 599065 == -401148)
																												{
																													continue;
																												}
																											}
																											else if (skillname == "whl_malStorm2")
																											{
																												if (181002 - 97273 != 83729)
																												{
																													continue;
																												}
																											}
																											else
																											{
																												if (skillname == "whl_hardenSkin1")
																												{
																													if (48991 - 36070 != 12921)
																													{
																														continue;
																													}
																													skillClass.setReq(20, 12);
																													if (67860 - 230915 == -163054)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "whl_hardenSkin2")
																												{
																													if (33096 - 241176 == -208079)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "whl_hardenSkin3")
																												{
																													if (253474 - 86716 != 166759)
																													{
																														goto IL_25F1;
																													}
																													continue;
																												}
																												else if (skillname == "whl_hardenSkin4")
																												{
																													if (37793 - 317671 != -279878)
																													{
																														continue;
																													}
																													goto IL_27D5;
																												}
																												else if (skillname == "whl_callToArm1")
																												{
																													if (103197 - 86143 != 17054)
																													{
																														continue;
																													}
																													skillClass.setReq(24, 15);
																													if (156252 - 376458 != -220206)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.instant;
																													if (68272 - 40496 != 27776)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.ally;
																													if (32580 - 120603 == -88022)
																													{
																														continue;
																													}
																													skillClass.cType = "callToArm";
																													if (123251 - 63942 != 59310)
																													{
																														break;
																													}
																													continue;
																												}
																												else
																												{
																													if (skillname == "whl_salvation1")
																													{
																														if (84253 - 176504 != -92251)
																														{
																															continue;
																														}
																														skillClass.setReq(27, 18);
																														if (35682 - 267466 == -231783)
																														{
																															continue;
																														}
																														skillClass.setMP(24);
																														if (257040 - 219714 == 37327)
																														{
																															continue;
																														}
																													}
																													else if (skillname == "whl_salvation2")
																													{
																														if (135227 - 43240 != 91987)
																														{
																															continue;
																														}
																													}
																													else
																													{
																														if (skillname == "whl_megalodon1")
																														{
																															if (106287 - 26192 != 80095)
																															{
																																continue;
																															}
																															skillClass.setReq(35, 25);
																															if (97973 - 374554 != -276581)
																															{
																																continue;
																															}
																															skillClass.setMPSP(45, -20);
																															if (92953 - 471467 != -378514)
																															{
																																continue;
																															}
																														}
																														else if (skillname == "whl_megalodon2")
																														{
																															if (21651 - 481058 == -459406)
																															{
																																continue;
																															}
																														}
																														else if (skillname == "whl_reducedCast1")
																														{
																															if (59526 - 314603 == -255076)
																															{
																																continue;
																															}
																															skillClass.setReq(45, 29);
																															if (40248 - 183577 == -143328)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (96249 - 420084 != -323834)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "whl_entendedWave5")
																														{
																															if (130949 - 120236 == 10714)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (106346 - 468170 == -361823)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (44292 - 301435 != -257143)
																															{
																																continue;
																															}
																															skillClass.rSkill = 102;
																															if (67743 - 155057 != -87313)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "whl_shieldReflect5")
																														{
																															if (113076 - 106549 == 6528)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (184685 - 43551 == 141135)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (56363 - 234460 != -178097)
																															{
																																continue;
																															}
																															skillClass.rSkill = 114;
																															if (282457 - 16828 != 265629)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_gourmetHeart5")
																														{
																															if (250744 - 59889 == 190856)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (124173 - 9158 == 115016)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (103569 - 300199 == -196629)
																															{
																																continue;
																															}
																															skillClass.rSkill = 122;
																															if (213325 - 543096 != -329771)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_megaSize5")
																														{
																															if (121705 - 368792 != -247087)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (126876 - 516843 != -389967)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (47124 - 229073 != -181949)
																															{
																																continue;
																															}
																															skillClass.rSkill = 134;
																															if (185948 - 8718 != 177230)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_superStatPlus5")
																														{
																															if (12279 - 591095 != -578816)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (231707 - 69754 == 161954)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (295404 - 563208 == -267803)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.self;
																															if (184384 - 451388 != -267004)
																															{
																																continue;
																															}
																															skillClass.rSkill = 144;
																															if (178753 - 433375 != -254621)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "whl_tideCutter5")
																														{
																															if (28945 - 474135 != -445190)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (186328 - 66053 == 120276)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (67687 - 393030 != -325343)
																															{
																																continue;
																															}
																															skillClass.rSkill = 204;
																															if (144294 - 204781 != -60487)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_honorStand5")
																														{
																															if (125985 - 69337 == 56649)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (283110 - 326614 != -43504)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (7352 - 161780 == -154427)
																															{
																																continue;
																															}
																															skillClass.rSkill = 214;
																															if (94432 - 243476 != -149043)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "whl_honorStand5")
																														{
																															if (85077 - 415237 == -330159)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (132798 - 571026 != -438228)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (142121 - 356655 == -214533)
																															{
																																continue;
																															}
																															skillClass.rSkill = 214;
																															if (9658 - 166483 != -156824)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "whl_homingShield5")
																														{
																															if (48030 - 486162 != -438132)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (268158 - 98273 != 169885)
																															{
																																continue;
																															}
																															skillClass.setSP(-24);
																															if (90292 - 23033 != 67259)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.target;
																															if (13604 - 81112 == -67507)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (149664 - 400389 != -250725)
																															{
																																continue;
																															}
																															skillClass.cType = "flyingShield";
																															if (168886 - 208337 == -39450)
																															{
																																continue;
																															}
																															skillClass.rSkill = 224;
																															if (162482 - 573140 != -410657)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "whl_wonderBelly5")
																														{
																															if (69865 - 315008 != -245143)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (273864 - 76333 == 197532)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (118016 - 59642 != 58374)
																															{
																																continue;
																															}
																															skillClass.rSkill = 233;
																															if (88860 - 314486 != -225626)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_peninsulaAsunder5")
																														{
																															if (256386 - 33765 == 222622)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (217327 - 89830 != 127497)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (114042 - 164916 == -50873)
																															{
																																continue;
																															}
																															skillClass.rSkill = 244;
																															if (33879 - 574603 != -540724)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_bubbleBurst5")
																														{
																															if (8161 - 193239 == -185077)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (285615 - 157145 != 128470)
																															{
																																continue;
																															}
																															skillClass.setMPSP(10, -10);
																															if (268198 - 513056 != -244858)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.instant;
																															if (216790 - 436445 != -219655)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.ally;
																															if (129372 - 82748 == 46625)
																															{
																																continue;
																															}
																															skillClass.cType = "bubbleBurst";
																															if (188795 - 525523 == -336727)
																															{
																																continue;
																															}
																															skillClass.rSkill = 304;
																															if (116174 - 63371 != 52803)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_overWeight5")
																														{
																															if (241031 - 436810 == -195778)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (282675 - 182139 != 100536)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (16577 - 163176 == -146598)
																															{
																																continue;
																															}
																															skillClass.rSkill = 314;
																															if (253729 - 587367 != -333638)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_spiralBlast5")
																														{
																															if (117905 - 367117 == -249211)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (257985 - 220854 != 37131)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (257667 - 94292 != 163375)
																															{
																																continue;
																															}
																															skillClass.rSkill = 324;
																															if (115883 - 437339 != -321456)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_revitalize5")
																														{
																															if (4941 - 297157 == -292215)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (118683 - 520247 == -401563)
																															{
																																continue;
																															}
																															skillClass.setMP(60);
																															if (38141 - 268898 != -230757)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.instant;
																															if (42802 - 238512 == -195709)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.ally;
																															if (104371 - 182931 != -78560)
																															{
																																continue;
																															}
																															skillClass.cType = "revitalize";
																															if (121869 - 446902 == -325032)
																															{
																																continue;
																															}
																															skillClass.rSkill = 334;
																															if (128842 - 596002 != -467160)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_divingPress5")
																														{
																															if (145556 - 300569 == -155012)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (11128 - 520374 == -509245)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (64933 - 467807 != -402874)
																															{
																																continue;
																															}
																															skillClass.rSkill = 344;
																															if (56792 - 154059 != -97266)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "whl_revisedSkill5")
																														{
																															if (116288 - 542570 == -426281)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (153931 - 142179 == 11753)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (40579 - 280847 != -240267)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "whl_revisedMagic5")
																														{
																															if (112941 - 166788 == -53846)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (166982 - 555180 != -388198)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (222407 - 515723 != -293316)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_revisedArt5")
																														{
																															if (269060 - 53270 == 215791)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (123620 - 162516 != -38896)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (221012 - 144779 != 76233)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "whl_bowlingWhale5")
																														{
																															if (66985 - 154761 != -87776)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (251384 - 388322 == -136937)
																															{
																																continue;
																															}
																															skillClass.setMPSP(45, -45);
																															if (157283 - 180674 != -23391)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.instant;
																															if (207612 - 335428 != -127816)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (136082 - 318944 == -182861)
																															{
																																continue;
																															}
																															skillClass.cType = "bowlingWhale";
																															if (11685 - 300966 != -289281)
																															{
																																continue;
																															}
																															skillClass.rSkill = 251351;
																															if (11084 - 467244 != -456160)
																															{
																																continue;
																															}
																															break;
																														}
																														else
																														{
																															if (!(skillname == "whl_grandTide5"))
																															{
																																break;
																															}
																															if (218986 - 57986 == 161001)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (96636 - 64709 == 31928)
																															{
																																continue;
																															}
																															skillClass.setMPSP(30, 60);
																															if (118960 - 308214 != -189254)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.instant;
																															if (178751 - 539363 == -360611)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (59293 - 554856 == -495562)
																															{
																																continue;
																															}
																															skillClass.cType = "grandTide";
																															if (11233 - 592294 == -581060)
																															{
																																continue;
																															}
																															skillClass.rSkill = 434;
																															if (26894 - 408591 != -381697)
																															{
																																continue;
																															}
																															break;
																														}
																														skillClass.setReq(40, 27);
																														if (262403 - 8711 == 253693)
																														{
																															continue;
																														}
																														skillClass.setMPSP(65, -30);
																														if (35363 - 355467 != -320104)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.target;
																														if (75699 - 123453 == -47753)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.enemy;
																														if (199577 - 105791 != 93786)
																														{
																															continue;
																														}
																														skillClass.cType = "megalodon";
																														if (190003 - 289356 != -99352)
																														{
																															break;
																														}
																														continue;
																													}
																													skillClass.setReq(30, 21);
																													if (17846 - 212425 != -194579)
																													{
																														continue;
																													}
																													skillClass.setMP(32);
																													if (176142 - 182302 != -6160)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.instant;
																													if (143778 - 364643 == -220864)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.ally;
																													if (157080 - 289618 != -132538)
																													{
																														continue;
																													}
																													skillClass.cType = "salvation";
																													if (205956 - 293455 != -87498)
																													{
																														break;
																													}
																													continue;
																												}
																												skillClass.setReq(24, 15);
																												if (257688 - 129461 == 128228)
																												{
																													continue;
																												}
																												IL_25F1:
																												skillClass.setReq(28, 18);
																												if (222816 - 12377 != 210439)
																												{
																													continue;
																												}
																												IL_27D5:
																												skillClass.setReq(32, 21);
																												if (240413 - 554411 != -313998)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (199927 - 222356 != -22428)
																												{
																													break;
																												}
																												continue;
																											}
																											skillClass.setReq(28, 16);
																											if (122018 - 203264 == -81245)
																											{
																												continue;
																											}
																											skillClass.setMPSP(24, -20);
																											if (55116 - 441429 == -386312)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.instant;
																											if (215014 - 512523 == -297508)
																											{
																												continue;
																											}
																											skillClass.target = eSkillTarget.enemy;
																											if (288723 - 349487 != -60764)
																											{
																												continue;
																											}
																											skillClass.cType = "malStorm";
																											if (24638 - 541294 != -516655)
																											{
																												break;
																											}
																											continue;
																										}
																										skillClass.setReq(20, 8);
																										if (81426 - 187801 == -106374)
																										{
																											continue;
																										}
																										skillClass.setSP(-15);
																										if (230170 - 224004 == 6167)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.instant;
																										if (130996 - 528153 == -397156)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.enemy;
																										if (32336 - 114468 == -82131)
																										{
																											continue;
																										}
																										skillClass.cType = "whaleWave";
																										if (34607 - 465758 != -431150)
																										{
																											break;
																										}
																										continue;
																									}
																									skillClass.setReq(15, 5);
																									if (270799 - 240927 != 29872)
																									{
																										continue;
																									}
																									skillClass.setMP(14);
																									if (243684 - 302218 != -58534)
																									{
																										continue;
																									}
																									IL_D54:
																									skillClass.setReq(18, 7);
																									if (212421 - 139162 == 73260)
																									{
																										continue;
																									}
																									skillClass.setMP(18);
																									if (202756 - 133495 == 69262)
																									{
																										continue;
																									}
																									IL_2E55:
																									skillClass.setReq(27, 9);
																									if (253934 - 338143 == -84208)
																									{
																										continue;
																									}
																									skillClass.setMP(22);
																									if (115164 - 140979 == -25814)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.target;
																									if (250515 - 318140 != -67625)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.ally;
																									if (191387 - 206651 != -15264)
																									{
																										continue;
																									}
																									skillClass.cType = "rejuvenate";
																									if (232935 - 556375 != -323439)
																									{
																										break;
																									}
																									continue;
																								}
																								skillClass.setReq(13, 4);
																								if (190696 - 184119 != 6577)
																								{
																									continue;
																								}
																								skillClass.setMP(12);
																								if (214668 - 459556 != -244887)
																								{
																									goto IL_2D9C;
																								}
																								continue;
																								IL_131C:
																								skillClass.setReq(25, 8);
																								if (167942 - 552357 == -384414)
																								{
																									continue;
																								}
																								skillClass.setMP(20);
																								if (167069 - 293190 != -126121)
																								{
																									continue;
																								}
																								skillClass.mode = eSkillMode.target;
																								if (98467 - 219377 != -120910)
																								{
																									continue;
																								}
																								skillClass.target = eSkillTarget.enemy;
																								if (170031 - 565940 != -395909)
																								{
																									continue;
																								}
																								skillClass.cType = "hydroBlast";
																								if (49608 - 288981 != -239372)
																								{
																									break;
																								}
																								continue;
																								IL_2D9C:
																								skillClass.setReq(19, 6);
																								if (23453 - 285305 != -261852)
																								{
																									continue;
																								}
																								skillClass.setMP(16);
																								if (124463 - 229917 != -105453)
																								{
																									goto IL_131C;
																								}
																								continue;
																							}
																							skillClass.setReq(23, 7);
																							if (68205 - 106404 != -38199)
																							{
																								continue;
																							}
																							skillClass.mode = eSkillMode.passive;
																							if (284357 - 204215 != 80142)
																							{
																								continue;
																							}
																							break;
																						}
																						skillClass.setReq(11, 3);
																						if (164394 - 130922 == 33473)
																						{
																							continue;
																						}
																						skillClass.setMP(14);
																						if (101504 - 359594 == -258089)
																						{
																							continue;
																						}
																						skillClass.mode = eSkillMode.target;
																						if (277730 - 177279 == 100452)
																						{
																							continue;
																						}
																						skillClass.target = eSkillTarget.all;
																						if (112307 - 176060 != -63753)
																						{
																							continue;
																						}
																						skillClass.cType = "heavyWeight";
																						if (123210 - 357171 != -233960)
																						{
																							break;
																						}
																						continue;
																					}
																					IL_CBC:
																					skillClass.setReq(15, 2);
																					if (239805 - 476475 == -236669)
																					{
																						continue;
																					}
																					skillClass.setMP(14);
																					if (197005 - 273644 == -76638)
																					{
																						continue;
																					}
																					IL_1126:
																					skillClass.setReq(21, 3);
																					if (245210 - 436464 != -191254)
																					{
																						continue;
																					}
																					skillClass.setMP(18);
																					if (101673 - 262802 == -161128)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.target;
																					if (28050 - 202824 == -174773)
																					{
																						continue;
																					}
																					skillClass.target = eSkillTarget.ally;
																					if (171625 - 582049 == -410423)
																					{
																						continue;
																					}
																					skillClass.cType = "bubbleShield";
																					if (77210 - 264209 != -186999)
																					{
																						continue;
																					}
																					break;
																					IL_16CB:
																					skillClass.setReq(9, 1);
																					if (208911 - 194155 != 14756)
																					{
																						continue;
																					}
																					skillClass.setMP(10);
																					if (168107 - 53821 != 114287)
																					{
																						goto IL_CBC;
																					}
																					continue;
																				}
																				skillClass.setReq(40, 25);
																				if (21085 - 374412 == -353326)
																				{
																					continue;
																				}
																				skillClass.setSP(-65);
																				if (95768 - 421030 != -325262)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.instant;
																				if (167818 - 52359 != 115459)
																				{
																					continue;
																				}
																				skillClass.target = eSkillTarget.ally;
																				if (94714 - 288381 != -193667)
																				{
																					continue;
																				}
																				skillClass.cType = "12thKingdomKnight";
																				if (92945 - 326220 != -233275)
																				{
																					continue;
																				}
																				break;
																			}
																			IL_C48:
																			skillClass.setReq(30, 21);
																			if (219637 - 365696 != -146059)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.passive;
																			if (32306 - 459075 != -426769)
																			{
																				continue;
																			}
																			break;
																			IL_1685:
																			skillClass.setReq(27, 18);
																			if (138377 - 296361 != -157984)
																			{
																				continue;
																			}
																			goto IL_C48;
																		}
																		IL_17BA:
																		skillClass.setReq(32, 21);
																		if (116208 - 256373 == -140164)
																		{
																			continue;
																		}
																		skillClass.mode = eSkillMode.passive;
																		if (59204 - 1842 != 57362)
																		{
																			continue;
																		}
																		break;
																		IL_1BA0:
																		skillClass.setReq(28, 18);
																		if (89182 - 177758 != -88576)
																		{
																			continue;
																		}
																		goto IL_17BA;
																		IL_1AF4:
																		skillClass.setReq(24, 15);
																		if (30696 - 584419 != -553722)
																		{
																			goto IL_1BA0;
																		}
																		continue;
																	}
																	skillClass.setReq(28, 16);
																	if (15386 - 479544 == -464157)
																	{
																		continue;
																	}
																	skillClass.setMPSP(15, -30);
																	if (81271 - 153475 != -72204)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.instant;
																	if (193237 - 112343 == 80895)
																	{
																		continue;
																	}
																	skillClass.target = eSkillTarget.enemy;
																	if (197380 - 92655 != 104725)
																	{
																		continue;
																	}
																	skillClass.cType = "peninsulaRound";
																	if (232316 - 65976 != 166341)
																	{
																		break;
																	}
																	continue;
																}
																skillClass.setReq(20, 8);
																if (231326 - 511602 == -280275)
																{
																	continue;
																}
																skillClass.setSP(-24);
																if (94527 - 437448 != -342921)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.instant;
																if (133824 - 255234 == -121409)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.enemy;
																if (94189 - 415948 != -321759)
																{
																	continue;
																}
																skillClass.cType = "peninsulaImpale";
																if (175349 - 461713 != -286364)
																{
																	continue;
																}
																break;
															}
															skillClass.setReq(15, 5);
															if (245570 - 151450 != 94120)
															{
																continue;
															}
															skillClass.setSP(-15);
															if (86069 - 576595 == -490525)
															{
																continue;
															}
															skillClass.mode = eSkillMode.target;
															if (118926 - 445285 == -326358)
															{
																continue;
															}
															skillClass.target = eSkillTarget.all;
															if (69784 - 302056 == -232271)
															{
																continue;
															}
															skillClass.cType = "swallow";
															if (154729 - 511839 != -357110)
															{
																continue;
															}
															break;
														}
														skillClass.setReq(25, 8);
														if (258748 - 353407 == -94658)
														{
															continue;
														}
														skillClass.setSP(20);
														if (199496 - 46922 != 152574)
														{
															continue;
														}
														skillClass.mode = eSkillMode.instant;
														if (171886 - 516036 != -344150)
														{
															continue;
														}
														skillClass.target = eSkillTarget.enemy;
														if (159490 - 269107 != -109617)
														{
															continue;
														}
														skillClass.cType = "flyingShield";
														if (171534 - 492462 != -320928)
														{
															continue;
														}
														break;
													}
													skillClass.setReq(13, 4);
													if (291787 - 224939 == 66849)
													{
														continue;
													}
													skillClass.setSP(18);
													if (187544 - 426881 == -239336)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (221755 - 187795 == 33961)
													{
														continue;
													}
													skillClass.target = eSkillTarget.enemy;
													if (165572 - 547511 != -381939)
													{
														continue;
													}
													skillClass.cType = "shieldRush";
													if (290525 - 122818 != 167707)
													{
														continue;
													}
													break;
												}
												IL_D1:
												skillClass.setReq(17, 5);
												if (255379 - 67778 == 187602)
												{
													continue;
												}
												skillClass.setMP(14);
												if (114367 - 513923 != -399556)
												{
													continue;
												}
												goto IL_17DE;
												IL_5BF:
												skillClass.setReq(11, 3);
												if (291061 - 286534 != 4527)
												{
													continue;
												}
												skillClass.setMP(12);
												if (75607 - 158556 != -82949)
												{
													continue;
												}
												goto IL_D1;
												IL_17DE:
												skillClass.setReq(23, 7);
												if (271476 - 140803 != 130673)
												{
													continue;
												}
												skillClass.setMP(16);
												if (8951 - 392056 == -383104)
												{
													continue;
												}
												skillClass.mode = eSkillMode.instant;
												if (208372 - 404080 == -195707)
												{
													continue;
												}
												skillClass.target = eSkillTarget.ally;
												if (180890 - 203708 == -22817)
												{
													continue;
												}
												skillClass.cType = "honor";
												if (261934 - 386633 != -124699)
												{
													continue;
												}
												break;
											}
											skillClass.setReq(21, 3);
											if (14233 - 237843 == -223609)
											{
												continue;
											}
											skillClass.setSP(-12);
											if (291392 - 524896 != -233504)
											{
												continue;
											}
											skillClass.mode = eSkillMode.instant;
											if (98142 - 351726 == -253583)
											{
												continue;
											}
											skillClass.target = eSkillTarget.enemy;
											if (83383 - 562116 != -478733)
											{
												continue;
											}
											skillClass.cType = "javelin";
											if (173884 - 548355 != -374471)
											{
												continue;
											}
											break;
										}
										skillClass.setReq(9, 1);
										if (113984 - 545369 != -431385)
										{
											continue;
										}
										skillClass.setSP(16);
										if (253584 - 363741 == -110156)
										{
											continue;
										}
										skillClass.mode = eSkillMode.instant;
										if (178423 - 233884 != -55461)
										{
											continue;
										}
										skillClass.target = eSkillTarget.enemy;
										if (131384 - 527017 == -395632)
										{
											continue;
										}
										skillClass.cType = "sweep";
										if (181368 - 841 != 180527)
										{
											continue;
										}
										break;
									}
									IL_BAF:
									skillClass.setReq(30, 8);
									if (276720 - 28473 != 248248)
									{
										goto IL_2089;
									}
									continue;
									IL_3511:
									skillClass.setReq(20, 6);
									if (164702 - 254550 != -89848)
									{
										continue;
									}
									goto IL_BAF;
									IL_2089:
									skillClass.setReq(40, 10);
									if (188267 - 32486 != 155781)
									{
										continue;
									}
									skillClass.mode = eSkillMode.passive;
									if (134733 - 559506 != -424773)
									{
										continue;
									}
									skillClass.target = eSkillTarget.self;
									if (148623 - 462087 != -313463)
									{
										break;
									}
									continue;
								}
								IL_464:
								skillClass.setReq(24, 8);
								if (125728 - 456003 != -330275)
								{
									continue;
								}
								goto IL_32D5;
								IL_1388:
								skillClass.setReq(16, 6);
								if (204552 - 228199 != -23647)
								{
									continue;
								}
								goto IL_464;
								IL_32D5:
								skillClass.setReq(32, 10);
								if (30032 - 180591 == -150558)
								{
									continue;
								}
								skillClass.mode = eSkillMode.passive;
								if (158892 - 358675 != -199782)
								{
									break;
								}
								continue;
							}
							skillClass.setReq(12, 4);
							if (271397 - 87185 != 184212)
							{
								continue;
							}
							skillClass.mode = eSkillMode.passive;
							if (240573 - 353846 != -113272)
							{
								break;
							}
							continue;
						}
						skillClass.setReq(10, 2);
						if (23723 - 393313 != -369590)
						{
							continue;
						}
						IL_230F:
						skillClass.setReq(16, 3);
						if (219961 - 390336 == -170374)
						{
							continue;
						}
						skillClass.mode = eSkillMode.passive;
						if (85946 - 247752 != -161805)
						{
							break;
						}
						continue;
					}
					skillClass.setReq(2, 1);
					if (14199 - 51009 == -36810)
					{
						skillClass.mode = eSkillMode.passive;
						if (130033 - 344562 != -214528)
						{
							break;
						}
					}
				}
			}
		}
		return skillClass;
	}

	// Token: 0x06003661 RID: 13921 RVA: 0x0071239C File Offset: 0x0071059C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillTree(int commandNum)
	{
		if (281069 - 27186 != 253883)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (135410 - 210423 != -75012)
			{
				if (275650 - 598385 == -322735)
				{
					if (commandNum == 101)
					{
						if (51038 - 14652 == 36386)
						{
							result = "whl_nAttack1";
							if (104019 - 74185 == 29834)
							{
								break;
							}
						}
					}
					else if (commandNum == 102)
					{
						if (172844 - 487699 != -314854)
						{
							result = "whl_nAttack2";
							if (24494 - 275457 == -250963)
							{
								break;
							}
						}
					}
					else if (commandNum == 111)
					{
						if (128652 - 185146 != -56493)
						{
							result = "whl_cAttack1";
							if (132317 - 206306 != -73988)
							{
								break;
							}
						}
					}
					else if (commandNum == 112)
					{
						if (294375 - 455504 == -161129)
						{
							result = "whl_cAttack2";
							if (249267 - 427300 == -178033)
							{
								break;
							}
						}
					}
					else if (commandNum == 113)
					{
						if (149851 - 3005 == 146846)
						{
							result = "whl_cAttack3";
							if (195096 - 85070 != 110027)
							{
								break;
							}
						}
					}
					else if (commandNum == 114)
					{
						if (67385 - 162295 != -94909)
						{
							result = "whl_shieldBash1";
							if (117522 - 207091 != -89568)
							{
								break;
							}
						}
					}
					else if (commandNum == 121)
					{
						if (285979 - 510379 == -224400)
						{
							result = "whl_culinaryTongue1";
							if (177894 - 100816 != 77079)
							{
								break;
							}
						}
					}
					else if (commandNum == 122)
					{
						if (171366 - 244669 == -73303)
						{
							result = "whl_culinaryTongue2";
							if (14095 - 156799 != -142703)
							{
								break;
							}
						}
					}
					else if (commandNum == 131)
					{
						if (49427 - 70963 != -21535)
						{
							result = "whl_superSize1";
							if (9071 - 151629 != -142557)
							{
								break;
							}
						}
					}
					else if (commandNum == 132)
					{
						if (148789 - 348408 != -199618)
						{
							result = "whl_superSize2";
							if (279584 - 106937 != 172648)
							{
								break;
							}
						}
					}
					else if (commandNum == 133)
					{
						if (275963 - 387394 == -111431)
						{
							result = "whl_superSize3";
							if (35188 - 67730 == -32542)
							{
								break;
							}
						}
					}
					else if (commandNum == 134)
					{
						if (272561 - 485539 == -212978)
						{
							result = "whl_superSize4";
							if (106805 - 65777 == 41028)
							{
								break;
							}
						}
					}
					else if (commandNum == 141)
					{
						if (120850 - 66126 == 54724)
						{
							result = "whl_statPlus1";
							if (276624 - 322246 == -45622)
							{
								break;
							}
						}
					}
					else if (commandNum == 142)
					{
						if (5521 - 309726 != -304204)
						{
							result = "whl_statPlus2";
							if (117588 - 487521 == -369933)
							{
								break;
							}
						}
					}
					else if (commandNum == 143)
					{
						if (27295 - 484169 != -456873)
						{
							result = "whl_statPlus3";
							if (186127 - 522741 != -336613)
							{
								break;
							}
						}
					}
					else if (commandNum == 144)
					{
						if (6260 - 137370 == -131110)
						{
							result = "whl_statPlus4";
							if (211761 - 29761 == 182000)
							{
								break;
							}
						}
					}
					else if (commandNum == 201)
					{
						if (205 - 98941 == -98736)
						{
							result = "whl_sweep1";
							if (150367 - 543283 == -392916)
							{
								break;
							}
						}
					}
					else if (commandNum == 202)
					{
						if (260872 - 516889 != -256016)
						{
							result = "whl_sweep2";
							if (289803 - 477374 != -187570)
							{
								break;
							}
						}
					}
					else if (commandNum == 203)
					{
						if (126276 - 584989 != -458712)
						{
							result = "whl_javelin1";
							if (153200 - 531814 != -378613)
							{
								break;
							}
						}
					}
					else if (commandNum == 204)
					{
						if (194676 - 594031 == -399355)
						{
							result = "whl_javelin2";
							if (180893 - 452914 != -272020)
							{
								break;
							}
						}
					}
					else if (commandNum == 211)
					{
						if (38303 - 217901 == -179598)
						{
							result = "whl_honor1";
							if (64085 - 257398 != -193312)
							{
								break;
							}
						}
					}
					else if (commandNum == 212)
					{
						if (7185 - 184037 == -176852)
						{
							result = "whl_honor2";
							if (258245 - 500358 == -242113)
							{
								break;
							}
						}
					}
					else if (commandNum == 213)
					{
						if (2625 - 101808 == -99183)
						{
							result = "whl_honor3";
							if (51127 - 459171 != -408043)
							{
								break;
							}
						}
					}
					else if (commandNum == 214)
					{
						if (146524 - 221804 != -75279)
						{
							result = "whl_honor4";
							if (81275 - 296502 == -215227)
							{
								break;
							}
						}
					}
					else if (commandNum == 221)
					{
						if (143374 - 545572 != -402197)
						{
							result = "whl_shieldRush1";
							if (142752 - 468192 == -325440)
							{
								break;
							}
						}
					}
					else if (commandNum == 222)
					{
						if (259740 - 83001 != 176740)
						{
							result = "whl_shieldRush2";
							if (278831 - 63213 == 215618)
							{
								break;
							}
						}
					}
					else if (commandNum == 223)
					{
						if (18618 - 373900 != -355281)
						{
							result = "whl_flyingShield1";
							if (278415 - 587865 != -309449)
							{
								break;
							}
						}
					}
					else if (commandNum == 224)
					{
						if (215385 - 591264 != -375878)
						{
							result = "whl_flyingShield2";
							if (100477 - 448444 == -347967)
							{
								break;
							}
						}
					}
					else if (commandNum == 231)
					{
						if (89696 - 575551 != -485854)
						{
							result = "whl_swallow1";
							if (184557 - 311362 == -126805)
							{
								break;
							}
						}
					}
					else if (commandNum == 232)
					{
						if (130709 - 58127 == 72582)
						{
							result = "whl_swallow2";
							if (267278 - 463955 != -196676)
							{
								break;
							}
						}
					}
					else if (commandNum == 233)
					{
						if (68381 - 151568 == -83187)
						{
							result = "whl_gobbleUp1";
							if (112078 - 423392 != -311313)
							{
								break;
							}
						}
					}
					else if (commandNum == 241)
					{
						if (781 - 151201 == -150420)
						{
							result = "whl_peninsulaImpale1";
							if (240598 - 357574 == -116976)
							{
								break;
							}
						}
					}
					else if (commandNum == 242)
					{
						if (183101 - 101371 == 81730)
						{
							result = "whl_peninsulaImpale2";
							if (239721 - 395416 != -155694)
							{
								break;
							}
						}
					}
					else if (commandNum == 243)
					{
						if (29761 - 401690 == -371929)
						{
							result = "whl_peninsulaRound1";
							if (116534 - 202058 == -85524)
							{
								break;
							}
						}
					}
					else if (commandNum == 244)
					{
						if (298744 - 51886 == 246858)
						{
							result = "whl_peninsulaRound2";
							if (226281 - 196575 == 29706)
							{
								break;
							}
						}
					}
					else if (commandNum == 251)
					{
						if (199529 - 401646 != -202116)
						{
							result = "whl_wallPuncture1";
							if (191359 - 52199 != 139161)
							{
								break;
							}
						}
					}
					else if (commandNum == 252)
					{
						if (278768 - 52130 != 226639)
						{
							result = "whl_wallPuncture2";
							if (269004 - 14586 != 254419)
							{
								break;
							}
						}
					}
					else if (commandNum == 253)
					{
						if (273901 - 251777 == 22124)
						{
							result = "whl_wallPuncture3";
							if (174485 - 395238 == -220753)
							{
								break;
							}
						}
					}
					else if (commandNum == 254)
					{
						if (116657 - 524439 == -407782)
						{
							result = "whl_wallPuncture4";
							if (32151 - 57414 != -25262)
							{
								break;
							}
						}
					}
					else if (commandNum == 261)
					{
						if (294010 - 367350 == -73340)
						{
							result = "whl_autoShield1";
							if (252740 - 116404 != 136337)
							{
								break;
							}
						}
					}
					else if (commandNum == 262)
					{
						if (29597 - 340192 != -310594)
						{
							result = "whl_autoShield2";
							if (165019 - 359453 == -194434)
							{
								break;
							}
						}
					}
					else if (commandNum == 263)
					{
						if (178472 - 367069 != -188596)
						{
							result = "whl_autoShield3";
							if (282021 - 129740 == 152281)
							{
								break;
							}
						}
					}
					else if (commandNum == 264)
					{
						if (281458 - 156631 != 124828)
						{
							result = "whl_lastHope1";
							if (169815 - 29032 == 140783)
							{
								break;
							}
						}
					}
					else if (commandNum == 271)
					{
						if (134214 - 389376 == -255162)
						{
							result = "whl_12thKingdomKnight1";
							if (10546 - 164957 == -154411)
							{
								break;
							}
						}
					}
					else if (commandNum == 272)
					{
						if (171693 - 237918 == -66225)
						{
							result = "whl_12thKingdomKnight2";
							if (188993 - 99204 != 89790)
							{
								break;
							}
						}
					}
					else if (commandNum == 273)
					{
						if (195809 - 129186 != 66624)
						{
							result = "whl_knightOfTheDeep1";
							if (141056 - 239667 == -98611)
							{
								break;
							}
						}
					}
					else if (commandNum == 301)
					{
						if (40453 - 397262 == -356809)
						{
							result = "whl_bubbleShield1";
							if (195827 - 404061 == -208234)
							{
								break;
							}
						}
					}
					else if (commandNum == 302)
					{
						if (299690 - 300249 == -559)
						{
							result = "whl_bubbleShield2";
							if (76634 - 218246 != -141611)
							{
								break;
							}
						}
					}
					else if (commandNum == 303)
					{
						if (131315 - 59021 != 72295)
						{
							result = "whl_bubbleShield3";
							if (6614 - 17556 == -10942)
							{
								break;
							}
						}
					}
					else if (commandNum == 304)
					{
						if (25225 - 131651 != -106425)
						{
							result = "whl_bubbleShield4";
							if (40303 - 6089 == 34214)
							{
								break;
							}
						}
					}
					else if (commandNum == 311)
					{
						if (116672 - 232262 != -115589)
						{
							result = "whl_heavyWeight1";
							if (2958 - 66648 == -63690)
							{
								break;
							}
						}
					}
					else if (commandNum == 312)
					{
						if (57769 - 4228 == 53541)
						{
							result = "whl_heavyWeight2";
							if (287705 - 363309 != -75603)
							{
								break;
							}
						}
					}
					else if (commandNum == 313)
					{
						if (100185 - 418090 == -317905)
						{
							result = "whl_overPresence1";
							if (77647 - 585824 != -508176)
							{
								break;
							}
						}
					}
					else if (commandNum == 314)
					{
						if (240662 - 369678 != -129015)
						{
							result = "whl_overPresence2";
							if (298363 - 506981 == -208618)
							{
								break;
							}
						}
					}
					else if (commandNum == 321)
					{
						if (219154 - 352680 == -133526)
						{
							result = "whl_hydroBlast1";
							if (42013 - 303337 != -261323)
							{
								break;
							}
						}
					}
					else if (commandNum == 322)
					{
						if (88542 - 391779 == -303237)
						{
							result = "whl_hydroBlast2";
							if (29204 - 78578 != -49373)
							{
								break;
							}
						}
					}
					else if (commandNum == 323)
					{
						if (70765 - 286155 == -215390)
						{
							result = "whl_hydroBlast3";
							if (135982 - 221959 != -85976)
							{
								break;
							}
						}
					}
					else if (commandNum == 324)
					{
						if (10504 - 119173 == -108669)
						{
							result = "whl_hydroBlast4";
							if (33622 - 376176 == -342554)
							{
								break;
							}
						}
					}
					else if (commandNum == 331)
					{
						if (2406 - 359867 != -357460)
						{
							result = "whl_rejuvenate1";
							if (119382 - 23067 != 96316)
							{
								break;
							}
						}
					}
					else if (commandNum == 332)
					{
						if (200790 - 119781 == 81009)
						{
							result = "whl_rejuvenate2";
							if (271368 - 580150 == -308782)
							{
								break;
							}
						}
					}
					else if (commandNum == 333)
					{
						if (135101 - 72887 != 62215)
						{
							result = "whl_rejuvenate3";
							if (169608 - 398066 == -228458)
							{
								break;
							}
						}
					}
					else if (commandNum == 334)
					{
						if (38721 - 255413 != -216691)
						{
							result = "whl_rejuvenate4";
							if (158059 - 570686 != -412626)
							{
								break;
							}
						}
					}
					else if (commandNum == 341)
					{
						if (190923 - 77774 != 113150)
						{
							result = "whl_whaleWave1";
							if (233489 - 139710 != 93780)
							{
								break;
							}
						}
					}
					else if (commandNum == 342)
					{
						if (85919 - 287018 != -201098)
						{
							result = "whl_whaleWave2";
							if (220526 - 299761 == -79235)
							{
								break;
							}
						}
					}
					else if (commandNum == 343)
					{
						if (196101 - 261181 == -65080)
						{
							result = "whl_malStorm1";
							if (242805 - 522847 != -280041)
							{
								break;
							}
						}
					}
					else if (commandNum == 344)
					{
						if (276702 - 410301 == -133599)
						{
							result = "whl_malStorm2";
							if (201820 - 425372 == -223552)
							{
								break;
							}
						}
					}
					else if (commandNum == 351)
					{
						if (152953 - 554350 != -401396)
						{
							result = "whl_hardenSkin1";
							if (128603 - 463278 == -334675)
							{
								break;
							}
						}
					}
					else if (commandNum == 352)
					{
						if (34496 - 372480 != -337983)
						{
							result = "whl_hardenSkin2";
							if (201197 - 469750 != -268552)
							{
								break;
							}
						}
					}
					else if (commandNum == 353)
					{
						if (49127 - 907 != 48221)
						{
							result = "whl_hardenSkin3";
							if (178725 - 489852 == -311127)
							{
								break;
							}
						}
					}
					else if (commandNum == 354)
					{
						if (152342 - 2754 == 149588)
						{
							result = "whl_hardenSkin4";
							if (191992 - 523820 == -331828)
							{
								break;
							}
						}
					}
					else if (commandNum == 361)
					{
						if (3294 - 24532 == -21238)
						{
							result = "whl_callToArm1";
							if (146167 - 7888 != 138280)
							{
								break;
							}
						}
					}
					else if (commandNum == 362)
					{
						if (71597 - 347655 == -276058)
						{
							result = "whl_salvation1";
							if (228049 - 132117 != 95933)
							{
								break;
							}
						}
					}
					else if (commandNum == 363)
					{
						if (240693 - 519784 != -279090)
						{
							result = "whl_salvation2";
							if (165063 - 230571 != -65507)
							{
								break;
							}
						}
					}
					else if (commandNum == 371)
					{
						if (199280 - 566369 == -367089)
						{
							result = "whl_megalodon1";
							if (112473 - 359263 == -246790)
							{
								break;
							}
						}
					}
					else if (commandNum == 372)
					{
						if (61424 - 439597 != -378172)
						{
							result = "whl_megalodon2";
							if (247973 - 422011 != -174037)
							{
								break;
							}
						}
					}
					else if (commandNum == 373)
					{
						if (75565 - 167190 != -91624)
						{
							result = "whl_reducedCast1";
							if (232452 - 213527 == 18925)
							{
								break;
							}
						}
					}
					else if (commandNum == 401)
					{
						if (187251 - 432444 == -245193)
						{
							result = "whl_entendedWave5";
							if (60185 - 532405 != -472219)
							{
								break;
							}
						}
					}
					else if (commandNum == 411)
					{
						if (281168 - 3731 != 277438)
						{
							result = "whl_shieldReflect5";
							if (214536 - 99091 == 115445)
							{
								break;
							}
						}
					}
					else if (commandNum == 421)
					{
						if (285126 - 497572 == -212446)
						{
							result = "whl_gourmetHeart5";
							if (240931 - 170655 == 70276)
							{
								break;
							}
						}
					}
					else if (commandNum == 431)
					{
						if (299175 - 567347 == -268172)
						{
							result = "whl_megaSize5";
							if (153190 - 84369 != 68822)
							{
								break;
							}
						}
					}
					else if (commandNum == 441)
					{
						if (21230 - 205154 != -183923)
						{
							result = "whl_superStatPlus5";
							if (61284 - 471385 == -410101)
							{
								break;
							}
						}
					}
					else if (commandNum == 402)
					{
						if (158147 - 558223 == -400076)
						{
							result = "whl_tideCutter5";
							if (142686 - 225897 == -83211)
							{
								break;
							}
						}
					}
					else if (commandNum == 412)
					{
						if (157248 - 557407 == -400159)
						{
							result = "whl_honorStand5";
							if (120500 - 365112 == -244612)
							{
								break;
							}
						}
					}
					else if (commandNum == 422)
					{
						if (57197 - 475341 == -418144)
						{
							result = "whl_homingShield5";
							if (244356 - 352043 != -107686)
							{
								break;
							}
						}
					}
					else if (commandNum == 432)
					{
						if (696 - 576327 != -575630)
						{
							result = "whl_wonderBelly5";
							if (42875 - 537701 == -494826)
							{
								break;
							}
						}
					}
					else if (commandNum == 442)
					{
						if (48656 - 446314 != -397657)
						{
							result = "whl_peninsulaAsunder5";
							if (184952 - 371478 != -186525)
							{
								break;
							}
						}
					}
					else if (commandNum == 403)
					{
						if (230677 - 459439 != -228761)
						{
							result = "whl_bubbleBurst5";
							if (32056 - 66495 == -34439)
							{
								break;
							}
						}
					}
					else if (commandNum == 413)
					{
						if (187853 - 254003 == -66150)
						{
							result = "whl_overWeight5";
							if (137808 - 441833 == -304025)
							{
								break;
							}
						}
					}
					else if (commandNum == 423)
					{
						if (198152 - 56623 == 141529)
						{
							result = "whl_spiralBlast5";
							if (63970 - 89654 == -25684)
							{
								break;
							}
						}
					}
					else if (commandNum == 433)
					{
						if (292655 - 287625 != 5031)
						{
							result = "whl_revitalize5";
							if (69449 - 73901 != -4451)
							{
								break;
							}
						}
					}
					else if (commandNum == 443)
					{
						if (101564 - 278597 == -177033)
						{
							result = "whl_divingPress5";
							if (17820 - 3965 != 13856)
							{
								break;
							}
						}
					}
					else if (commandNum == 404)
					{
						if (151995 - 89160 == 62835)
						{
							result = "whl_revisedSkill5";
							if (59698 - 106162 == -46464)
							{
								break;
							}
						}
					}
					else if (commandNum == 414)
					{
						if (267897 - 217027 != 50871)
						{
							result = "whl_revisedMagic5";
							if (182376 - 392691 != -210314)
							{
								break;
							}
						}
					}
					else if (commandNum == 424)
					{
						if (120841 - 581432 != -460590)
						{
							result = "whl_revisedArt5";
							if (150010 - 50525 != 99486)
							{
								break;
							}
						}
					}
					else if (commandNum == 434)
					{
						if (283446 - 228768 != 54679)
						{
							result = "whl_bowlingWhale5";
							if (287289 - 588159 != -300869)
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
						if (4816 - 475299 != -470482)
						{
							result = "whl_grandTide5";
							if (57146 - 501487 == -444341)
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

	// Token: 0x06003662 RID: 13922 RVA: 0x00713FBC File Offset: 0x007121BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003663 RID: 13923 RVA: 0x00713FC0 File Offset: 0x007121C0
	internal static bool sxwMBY5lXg9TTSIjmksp()
	{
		return true;
	}

	// Token: 0x06003664 RID: 13924 RVA: 0x00713FC4 File Offset: 0x007121C4
	internal static bool mrwCBk5lQPuiv8cPnARZ()
	{
		return false;
	}
}
