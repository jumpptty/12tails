using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200056F RID: 1391
[Serializable]
public class BisonSkill : MonoBehaviour
{
	// Token: 0x06001FB1 RID: 8113 RVA: 0x0037AF70 File Offset: 0x00379170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BisonSkill()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x0037AF80 File Offset: 0x00379180
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSkill(string skillname)
	{
		if (272936 - 355946 != -83009)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (157694 - 190458 == -32764)
			{
				if (248561 - 498785 != -250223)
				{
					if (skillname == "bsn_nAttack1")
					{
						if (92966 - 154892 != -61926)
						{
							continue;
						}
						skillClass.setReq(1, 0);
						if (251109 - 146196 != 104914)
						{
							goto IL_A88;
						}
						continue;
					}
					else if (skillname == "bsn_nAttack2")
					{
						if (114242 - 325865 != -211623)
						{
							continue;
						}
						goto IL_A88;
					}
					else if (skillname == "bsn_nAttack3")
					{
						if (240976 - 251575 != -10599)
						{
							continue;
						}
					}
					else if (skillname == "bsn_nAttack4")
					{
						if (123450 - 274261 != -150811)
						{
							continue;
						}
						goto IL_2FA3;
					}
					else
					{
						if (skillname == "bsn_cAttack1")
						{
							if (23170 - 195589 != -172419)
							{
								continue;
							}
							skillClass.setReq(4, 1);
							if (230691 - 587569 != -356878)
							{
								continue;
							}
						}
						else if (skillname == "bsn_cAttack2")
						{
							if (116738 - 293220 == -176481)
							{
								continue;
							}
						}
						else if (skillname == "bsn_holdCharge1")
						{
							if (61946 - 103567 != -41621)
							{
								continue;
							}
							skillClass.setReq(16, 5);
							if (48118 - 599497 == -551378)
							{
								continue;
							}
							skillClass.mode = eSkillMode.passive;
							if (166513 - 514250 != -347736)
							{
								break;
							}
							continue;
						}
						else
						{
							if (skillname == "bsn_bloodRage1")
							{
								if (73027 - 28732 == 44296)
								{
									continue;
								}
								skillClass.setReq(6, 2);
								if (123523 - 521806 != -398283)
								{
									continue;
								}
							}
							else if (skillname == "bsn_bloodRage2")
							{
								if (255372 - 562767 != -307395)
								{
									continue;
								}
							}
							else
							{
								if (skillname == "bsn_bruteStrength1")
								{
									if (225554 - 324155 == -98600)
									{
										continue;
									}
									skillClass.setReq(8, 4);
									if (92261 - 165079 != -72817)
									{
										goto IL_17AA;
									}
									continue;
								}
								else if (skillname == "bsn_bruteStrength2")
								{
									if (292789 - 228661 != 64128)
									{
										continue;
									}
									goto IL_17AA;
								}
								else if (skillname == "bsn_bruteStrength3")
								{
									if (85327 - 267736 == -182408)
									{
										continue;
									}
								}
								else if (skillname == "bsn_bruteStrength4")
								{
									if (3623 - 49945 != -46321)
									{
										goto IL_1CCD;
									}
									continue;
								}
								else
								{
									if (skillname == "bsn_statPlus1")
									{
										if (221534 - 285509 == -63974)
										{
											continue;
										}
										skillClass.setReq(10, 4);
										if (220879 - 208417 != 12462)
										{
											continue;
										}
										goto IL_2D9C;
									}
									else if (skillname == "bsn_statPlus2")
									{
										if (174647 - 579135 != -404488)
										{
											continue;
										}
										goto IL_2D9C;
									}
									else if (skillname == "bsn_statPlus3")
									{
										if (182579 - 527187 != -344608)
										{
											continue;
										}
										goto IL_26FF;
									}
									else if (skillname == "bsn_statPlus4")
									{
										if (128559 - 272643 != -144084)
										{
											continue;
										}
									}
									else
									{
										if (skillname == "bsn_enrage1")
										{
											if (133810 - 244241 == -110430)
											{
												continue;
											}
											skillClass.setReq(3, 0);
											if (186057 - 354292 != -168235)
											{
												continue;
											}
											skillClass.setMP(4);
											if (93613 - 577116 == -483502)
											{
												continue;
											}
										}
										else if (skillname == "bsn_enrage2")
										{
											if (105120 - 11986 == 93135)
											{
												continue;
											}
										}
										else if (skillname == "bsn_enrage3")
										{
											if (213639 - 283116 != -69476)
											{
												goto IL_253B;
											}
											continue;
										}
										else if (skillname == "bsn_enrage4")
										{
											if (292721 - 77489 != 215232)
											{
												continue;
											}
											goto IL_306A;
										}
										else
										{
											if (skillname == "bsn_slam1")
											{
												if (222040 - 326581 == -104540)
												{
													continue;
												}
												skillClass.setReq(5, 1);
												if (52399 - 217225 != -164826)
												{
													continue;
												}
												skillClass.setSP(10);
												if (287009 - 260897 == 26113)
												{
													continue;
												}
											}
											else if (skillname == "bsn_slam2")
											{
												if (117614 - 451151 == -333536)
												{
													continue;
												}
											}
											else
											{
												if (skillname == "bsn_trample1")
												{
													if (243791 - 488004 == -244212)
													{
														continue;
													}
													skillClass.setReq(17, 5);
													if (38684 - 432944 != -394260)
													{
														continue;
													}
													skillClass.setSP(-30);
													if (271406 - 494638 != -223232)
													{
														continue;
													}
												}
												else if (skillname == "bsn_trample2")
												{
													if (53618 - 15293 != 38325)
													{
														continue;
													}
												}
												else
												{
													if (skillname == "bsn_knockDown1")
													{
														if (279379 - 60593 == 218787)
														{
															continue;
														}
														skillClass.setReq(7, 2);
														if (135590 - 393518 != -257928)
														{
															continue;
														}
														skillClass.setSP(-5);
														if (79769 - 355478 == -275708)
														{
															continue;
														}
													}
													else if (skillname == "bsn_knockDown2")
													{
														if (293575 - 113617 == 179959)
														{
															continue;
														}
													}
													else if (skillname == "bsn_knockDown3")
													{
														if (212327 - 532637 != -320309)
														{
															goto IL_CBE;
														}
														continue;
													}
													else if (skillname == "bsn_knockDown4")
													{
														if (96598 - 111029 != -14430)
														{
															goto IL_29CC;
														}
														continue;
													}
													else
													{
														if (skillname == "bsn_controlledSwing1")
														{
															if (144616 - 185682 == -41065)
															{
																continue;
															}
															skillClass.setReq(9, 3);
															if (134335 - 129034 != 5301)
															{
																continue;
															}
															goto IL_20D5;
														}
														else if (skillname == "bsn_improvedSwing1")
														{
															if (105918 - 92566 != 13352)
															{
																continue;
															}
															goto IL_20D5;
														}
														else if (skillname == "bsn_improvedSwing2")
														{
															if (290317 - 550953 != -260635)
															{
																goto IL_1B59;
															}
															continue;
														}
														else if (skillname == "bsn_improvedSwing3")
														{
															if (44563 - 370129 == -325565)
															{
																continue;
															}
														}
														else
														{
															if (skillname == "bsn_farStun1")
															{
																if (23117 - 332281 == -309163)
																{
																	continue;
																}
																skillClass.setReq(16, 4);
																if (47223 - 573797 != -526574)
																{
																	continue;
																}
																skillClass.setSP(-14);
																if (211154 - 592672 == -381517)
																{
																	continue;
																}
															}
															else if (skillname == "bsn_farStun2")
															{
																if (127134 - 382237 != -255103)
																{
																	continue;
																}
															}
															else if (skillname == "bsn_instantRush1")
															{
																if (273840 - 434014 == -160173)
																{
																	continue;
																}
																skillClass.setReq(24, 12);
																if (135189 - 563648 == -428458)
																{
																	continue;
																}
																skillClass.setSP(12);
																if (75122 - 504033 == -428910)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.target;
																if (211982 - 80956 != 131026)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.enemy;
																if (253116 - 154475 != 98641)
																{
																	continue;
																}
																skillClass.cType = "instantRush";
																if (164692 - 402679 != -237986)
																{
																	break;
																}
																continue;
															}
															else
															{
																if (skillname == "bsn_berserkerRush1")
																{
																	if (201818 - 253440 != -51622)
																	{
																		continue;
																	}
																	skillClass.setReq(20, 12);
																	if (125216 - 281769 != -156553)
																	{
																		continue;
																	}
																}
																else if (skillname == "bsn_berserkerRush2")
																{
																	if (79189 - 583568 == -504378)
																	{
																		continue;
																	}
																}
																else if (skillname == "bsn_berserkerRush3")
																{
																	if (233256 - 118429 != 114828)
																	{
																		goto IL_26DB;
																	}
																	continue;
																}
																else if (skillname == "bsn_berserkerRush4")
																{
																	if (102394 - 341436 != -239041)
																	{
																		goto IL_1CF1;
																	}
																	continue;
																}
																else
																{
																	if (skillname == "bsn_restingGlory1")
																	{
																		if (282966 - 324832 != -41866)
																		{
																			continue;
																		}
																		skillClass.setReq(24, 15);
																		if (139003 - 113467 == 25537)
																		{
																			continue;
																		}
																	}
																	else if (skillname == "bsn_furyTrance1")
																	{
																		if (48436 - 413460 == -365023)
																		{
																			continue;
																		}
																	}
																	else if (skillname == "bsn_furyTrance2")
																	{
																		if (5025 - 471564 != -466539)
																		{
																			continue;
																		}
																		goto IL_181D;
																	}
																	else if (skillname == "bsn_furyTrance3")
																	{
																		if (67085 - 386109 != -319023)
																		{
																			goto IL_287D;
																		}
																		continue;
																	}
																	else
																	{
																		if (skillname == "bsn_overPower1")
																		{
																			if (295923 - 76644 != 219279)
																			{
																				continue;
																			}
																			skillClass.setReq(35, 23);
																			if (23044 - 462529 != -439485)
																			{
																				continue;
																			}
																			skillClass.setMPSP(20, -60);
																			if (192200 - 538774 == -346573)
																			{
																				continue;
																			}
																		}
																		else if (skillname == "bsn_overPower2")
																		{
																			if (15200 - 447305 != -432105)
																			{
																				continue;
																			}
																		}
																		else if (skillname == "bsn_overSwing1")
																		{
																			if (62054 - 208828 != -146774)
																			{
																				continue;
																			}
																			skillClass.setReq(45, 27);
																			if (279188 - 160830 == 118359)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.passive;
																			if (149857 - 293435 != -143578)
																			{
																				continue;
																			}
																			break;
																		}
																		else
																		{
																			if (skillname == "bsn_powerCleave1")
																			{
																				if (283356 - 319916 != -36560)
																				{
																					continue;
																				}
																				skillClass.setReq(3, 0);
																				if (162915 - 57291 == 105625)
																				{
																					continue;
																				}
																				skillClass.setSP(-10);
																				if (225453 - 227712 == -2258)
																				{
																					continue;
																				}
																			}
																			else if (skillname == "bsn_powerCleave2")
																			{
																				if (1558 - 501755 != -500197)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				if (skillname == "bsn_powerHammer1")
																				{
																					if (147314 - 67312 != 80002)
																					{
																						continue;
																					}
																					skillClass.setReq(9, 1);
																					if (204749 - 283028 == -78278)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "bsn_powerHammer2")
																				{
																					if (113134 - 35090 != 78044)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					if (skillname == "bsn_warcry1")
																					{
																						if (24451 - 63260 != -38809)
																						{
																							continue;
																						}
																						skillClass.setReq(5, 1);
																						if (21023 - 559173 != -538150)
																						{
																							continue;
																						}
																						skillClass.setMP(5);
																						if (15983 - 358990 == -343006)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "bsn_warcry2")
																					{
																						if (158927 - 349558 != -190631)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						if (skillname == "bsn_overlord1")
																						{
																							if (17193 - 599523 != -582330)
																							{
																								continue;
																							}
																							skillClass.setReq(17, 5);
																							if (60902 - 233542 == -172639)
																							{
																								continue;
																							}
																						}
																						else if (skillname == "bsn_overlord2")
																						{
																							if (239105 - 143990 != 95115)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							if (skillname == "bsn_overPride1")
																							{
																								if (275997 - 514487 != -238490)
																								{
																									continue;
																								}
																								skillClass.setReq(7, 2);
																								if (177288 - 206254 != -28965)
																								{
																									goto IL_1E96;
																								}
																								continue;
																							}
																							else if (skillname == "bsn_overPride2")
																							{
																								if (155624 - 210180 != -54556)
																								{
																									continue;
																								}
																								goto IL_1E96;
																							}
																							else if (skillname == "bsn_overPride3")
																							{
																								if (106367 - 18456 == 87912)
																								{
																									continue;
																								}
																							}
																							else if (skillname == "bsn_overPride4")
																							{
																								if (179869 - 251249 != -71380)
																								{
																									continue;
																								}
																								goto IL_2767;
																							}
																							else
																							{
																								if (skillname == "bsn_ironSkin1")
																								{
																									if (84893 - 16145 == 68749)
																									{
																										continue;
																									}
																									skillClass.setReq(16, 4);
																									if (188429 - 234133 != -45704)
																									{
																										continue;
																									}
																									goto IL_2EA4;
																								}
																								else if (skillname == "bsn_ironSkin2")
																								{
																									if (90239 - 423391 != -333151)
																									{
																										goto IL_2EA4;
																									}
																									continue;
																								}
																								else if (skillname == "bsn_ironSkin3")
																								{
																									if (49564 - 404309 != -354745)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "bsn_ironShield1")
																								{
																									if (69370 - 319933 != -250563)
																									{
																										continue;
																									}
																									skillClass.setReq(28, 18);
																									if (81777 - 558399 != -476622)
																									{
																										continue;
																									}
																									skillClass.setMPSP(10, -10);
																									if (290425 - 577239 == -286813)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.instant;
																									if (175992 - 463474 == -287481)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.self;
																									if (291732 - 71582 == 220151)
																									{
																										continue;
																									}
																									skillClass.cType = "ironShield";
																									if (208957 - 512131 != -303173)
																									{
																										break;
																									}
																									continue;
																								}
																								else
																								{
																									if (skillname == "bsn_diamondSkin1")
																									{
																										if (243726 - 15596 != 228130)
																										{
																											continue;
																										}
																										skillClass.setReq(16, 4);
																										if (72276 - 87240 != -14964)
																										{
																											continue;
																										}
																										goto IL_2A34;
																									}
																									else if (skillname == "bsn_diamondSkin2")
																									{
																										if (50320 - 297872 != -247551)
																										{
																											goto IL_2A34;
																										}
																										continue;
																									}
																									else if (skillname == "bsn_diamondSkin3")
																									{
																										if (271388 - 269258 != 2130)
																										{
																											continue;
																										}
																									}
																									else if (skillname == "bsn_diamondShield1")
																									{
																										if (291437 - 374435 != -82998)
																										{
																											continue;
																										}
																										skillClass.setReq(28, 18);
																										if (234827 - 444701 != -209874)
																										{
																											continue;
																										}
																										skillClass.setMPSP(10, -10);
																										if (131002 - 414089 == -283086)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.instant;
																										if (169009 - 409605 != -240596)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.self;
																										if (53254 - 283266 == -230011)
																										{
																											continue;
																										}
																										skillClass.cType = "diamondShield";
																										if (221175 - 69755 != 151420)
																										{
																											continue;
																										}
																										break;
																									}
																									else
																									{
																										if (skillname == "bsn_earthRupture1")
																										{
																											if (271253 - 445633 != -174380)
																											{
																												continue;
																											}
																											skillClass.setReq(20, 12);
																											if (3762 - 86537 != -82775)
																											{
																												continue;
																											}
																											skillClass.setSP(-15);
																											if (269770 - 177717 != 92053)
																											{
																												continue;
																											}
																										}
																										else if (skillname == "bsn_earthRupture2")
																										{
																											if (285800 - 422813 == -137012)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											if (skillname == "bsn_earthSmasher1")
																											{
																												if (8351 - 172853 == -164501)
																												{
																													continue;
																												}
																												skillClass.setReq(28, 18);
																												if (17333 - 23901 == -6567)
																												{
																													continue;
																												}
																												skillClass.setSP(-45);
																												if (78680 - 59041 == 19640)
																												{
																													continue;
																												}
																											}
																											else if (skillname == "bsn_earthSmasher2")
																											{
																												if (62382 - 202187 != -139805)
																												{
																													continue;
																												}
																											}
																											else
																											{
																												if (skillname == "bsn_colossalWeapon1")
																												{
																													if (233078 - 134801 == 98278)
																													{
																														continue;
																													}
																													skillClass.setReq(24, 15);
																													if (223488 - 220536 == 2953)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "bsn_colossalWeapon2")
																												{
																													if (214427 - 391514 == -177086)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "bsn_colossalArmor1")
																												{
																													if (13207 - 405998 != -392790)
																													{
																														goto IL_2C8D;
																													}
																													continue;
																												}
																												else if (skillname == "bsn_colossalArmor2")
																												{
																													if (2329 - 545831 != -543502)
																													{
																														continue;
																													}
																													goto IL_308D;
																												}
																												else
																												{
																													if (skillname == "bsn_titanForm1")
																													{
																														if (248984 - 538080 != -289096)
																														{
																															continue;
																														}
																														skillClass.setReq(35, 23);
																														if (144055 - 43526 == 100530)
																														{
																															continue;
																														}
																														skillClass.setMPSP(30, -55);
																														if (27191 - 18263 == 8929)
																														{
																															continue;
																														}
																													}
																													else if (skillname == "bsn_titanForm2")
																													{
																														if (179077 - 108876 != 70201)
																														{
																															continue;
																														}
																													}
																													else if (skillname == "bsn_addedSwing5")
																													{
																														if (120941 - 204014 == -83072)
																														{
																															continue;
																														}
																														skillClass.setReq(55, 0);
																														if (295097 - 144676 == 150422)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (247607 - 379665 == -132057)
																														{
																															continue;
																														}
																														skillClass.rSkill = 104;
																														if (53320 - 399958 != -346637)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "bsn_solidHold5")
																													{
																														if (129438 - 157252 != -27814)
																														{
																															continue;
																														}
																														skillClass.setReq(60, 1);
																														if (245692 - 69713 != 175979)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (57449 - 382444 != -324995)
																														{
																															continue;
																														}
																														skillClass.rSkill = 113;
																														if (224109 - 445361 != -221251)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "bsn_bloodBath5")
																													{
																														if (27908 - 164052 == -136143)
																														{
																															continue;
																														}
																														skillClass.setReq(70, 3);
																														if (112784 - 569028 != -456244)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (175928 - 18540 == 157389)
																														{
																															continue;
																														}
																														skillClass.rSkill = 122;
																														if (162830 - 66945 != 95885)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "bsn_rawStrength5")
																													{
																														if (287757 - 548046 == -260288)
																														{
																															continue;
																														}
																														skillClass.setReq(75, 4);
																														if (276968 - 275299 == 1670)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (158168 - 408485 == -250316)
																														{
																															continue;
																														}
																														skillClass.rSkill = 134;
																														if (220848 - 582312 != -361463)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "bsn_superStatPlus5")
																													{
																														if (172863 - 321155 == -148291)
																														{
																															continue;
																														}
																														skillClass.setReq(85, 6);
																														if (286104 - 268187 != 17917)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (140425 - 390373 != -249948)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.self;
																														if (156445 - 188488 != -32043)
																														{
																															continue;
																														}
																														skillClass.rSkill = 144;
																														if (173995 - 40323 != 133672)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "bsn_rageControl5")
																													{
																														if (52833 - 280682 == -227848)
																														{
																															continue;
																														}
																														skillClass.setReq(55, 0);
																														if (186041 - 73739 != 112302)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (225196 - 197722 == 27475)
																														{
																															continue;
																														}
																														skillClass.rSkill = 204;
																														if (239352 - 212597 != 26755)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "bsn_aspectOfTheHorde5")
																													{
																														if (23424 - 87934 != -64510)
																														{
																															continue;
																														}
																														skillClass.setReq(60, 1);
																														if (220342 - 165568 != 54774)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (153162 - 23688 == 129475)
																														{
																															continue;
																														}
																														skillClass.rSkill = 214;
																														if (197757 - 442823 != -245065)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "bsn_aftershock5")
																													{
																														if (9909 - 389750 == -379840)
																														{
																															continue;
																														}
																														skillClass.setReq(70, 3);
																														if (245969 - 295701 != -49732)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (113162 - 352933 != -239771)
																														{
																															continue;
																														}
																														skillClass.rSkill = 224;
																														if (299237 - 62222 != 237015)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "bsn_spinHack5")
																													{
																														if (192050 - 354066 == -162015)
																														{
																															continue;
																														}
																														skillClass.setReq(75, 4);
																														if (252856 - 237522 != 15334)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (209189 - 178990 == 30200)
																														{
																															continue;
																														}
																														skillClass.rSkill = 234;
																														if (38019 - 307323 != -269304)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "bsn_massStun5")
																													{
																														if (245345 - 291244 == -45898)
																														{
																															continue;
																														}
																														skillClass.setReq(85, 6);
																														if (152181 - 425744 == -273562)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (248615 - 417031 != -168416)
																														{
																															continue;
																														}
																														skillClass.rSkill = 243;
																														if (38781 - 455606 != -416824)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "bsn_powerReel5")
																													{
																														if (298785 - 228772 == 70014)
																														{
																															continue;
																														}
																														skillClass.setReq(55, 0);
																														if (28148 - 195422 != -167274)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (59035 - 7929 != 51106)
																														{
																															continue;
																														}
																														skillClass.rSkill = 304;
																														if (102110 - 228268 != -126157)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "bsn_onslaught5")
																													{
																														if (169673 - 500922 == -331248)
																														{
																															continue;
																														}
																														skillClass.setReq(60, 1);
																														if (15428 - 496733 != -481305)
																														{
																															continue;
																														}
																														skillClass.setMPSP(50, -50);
																														if (49168 - 279570 != -230402)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.instant;
																														if (59234 - 444491 == -385256)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.enemy;
																														if (197018 - 461688 != -264670)
																														{
																															continue;
																														}
																														skillClass.cType = "onslaught";
																														if (137782 - 89907 == 47876)
																														{
																															continue;
																														}
																														skillClass.rSkill = 314;
																														if (47174 - 461953 != -414778)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "bsn_prideCrusher5")
																													{
																														if (269290 - 467330 == -198039)
																														{
																															continue;
																														}
																														skillClass.setReq(70, 3);
																														if (63131 - 325543 != -262412)
																														{
																															continue;
																														}
																														skillClass.setMPSP(5, -25);
																														if (2289 - 485761 == -483471)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.instant;
																														if (63097 - 350699 == -287601)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.enemy;
																														if (244494 - 211049 == 33446)
																														{
																															continue;
																														}
																														skillClass.cType = "prideCrusher";
																														if (31233 - 523892 != -492659)
																														{
																															continue;
																														}
																														skillClass.rSkill = 324;
																														if (9082 - 102068 != -92986)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "bsn_steelSkin5")
																													{
																														if (277283 - 47238 != 230045)
																														{
																															continue;
																														}
																														skillClass.setReq(75, 4);
																														if (252200 - 503697 == -251496)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (5315 - 294665 != -289350)
																														{
																															continue;
																														}
																														skillClass.rSkill = 334;
																														if (57453 - 293529 != -236076)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "bsn_mythrilSkin5")
																													{
																														if (15030 - 27381 != -12351)
																														{
																															continue;
																														}
																														skillClass.setReq(85, 6);
																														if (281637 - 243130 != 38507)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (236347 - 370267 == -133919)
																														{
																															continue;
																														}
																														skillClass.rSkill = 344;
																														if (113498 - 523099 != -409600)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "bsn_revisedSkill5")
																													{
																														if (65911 - 319587 != -253676)
																														{
																															continue;
																														}
																														skillClass.setReq(55, 0);
																														if (68352 - 578291 != -509939)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (114697 - 460447 != -345750)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (skillname == "bsn_revisedMagic5")
																													{
																														if (151149 - 529046 != -377897)
																														{
																															continue;
																														}
																														skillClass.setReq(60, 1);
																														if (56561 - 245352 != -188791)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (160981 - 393228 != -232246)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "bsn_revisedArt5")
																													{
																														if (206132 - 491152 != -285020)
																														{
																															continue;
																														}
																														skillClass.setReq(70, 3);
																														if (133628 - 557922 == -424293)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.passive;
																														if (151047 - 485150 != -334102)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (skillname == "bsn_magmaClutter5")
																													{
																														if (65252 - 339270 == -274017)
																														{
																															continue;
																														}
																														skillClass.setReq(75, 4);
																														if (88406 - 19061 != 69345)
																														{
																															continue;
																														}
																														skillClass.setMPSP(20, -20);
																														if (192046 - 258579 != -66533)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.instant;
																														if (82939 - 556223 == -473283)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.enemy;
																														if (235975 - 443214 == -207238)
																														{
																															continue;
																														}
																														skillClass.cType = "magmaClutter";
																														if (48814 - 30548 != 18266)
																														{
																															continue;
																														}
																														skillClass.rSkill = 251351;
																														if (288942 - 531846 != -242903)
																														{
																															break;
																														}
																														continue;
																													}
																													else
																													{
																														if (!(skillname == "bsn_calamityHammer5"))
																														{
																															break;
																														}
																														if (150760 - 571993 != -421233)
																														{
																															continue;
																														}
																														skillClass.setReq(85, 6);
																														if (276146 - 212440 == 63707)
																														{
																															continue;
																														}
																														skillClass.setMPSP(50, -50);
																														if (53139 - 559098 != -505959)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.target;
																														if (154411 - 249915 != -95504)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.enemy;
																														if (212934 - 102939 != 109995)
																														{
																															continue;
																														}
																														skillClass.cType = "calamityHammer";
																														if (141078 - 253758 == -112679)
																														{
																															continue;
																														}
																														skillClass.rSkill = 434;
																														if (87042 - 99370 != -12327)
																														{
																															break;
																														}
																														continue;
																													}
																													skillClass.setReq(40, 25);
																													if (61490 - 104717 == -43226)
																													{
																														continue;
																													}
																													skillClass.setMPSP(40, -70);
																													if (286235 - 15709 != 270526)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.instant;
																													if (227444 - 148495 == 78950)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.self;
																													if (284660 - 372898 != -88238)
																													{
																														continue;
																													}
																													skillClass.cType = "titanForm";
																													if (179686 - 82941 != 96746)
																													{
																														break;
																													}
																													continue;
																												}
																												skillClass.setReq(27, 18);
																												if (211973 - 491235 == -279261)
																												{
																													continue;
																												}
																												IL_2C8D:
																												skillClass.setReq(30, 21);
																												if (174241 - 427051 != -252810)
																												{
																													continue;
																												}
																												IL_308D:
																												skillClass.setReq(33, 24);
																												if (205011 - 169710 != 35301)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (243602 - 549146 != -305544)
																												{
																													continue;
																												}
																												break;
																											}
																											skillClass.setReq(32, 21);
																											if (42276 - 482056 != -439780)
																											{
																												continue;
																											}
																											skillClass.setSP(-55);
																											if (143256 - 459540 != -316284)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.instant;
																											if (16101 - 301585 == -285483)
																											{
																												continue;
																											}
																											skillClass.target = eSkillTarget.enemy;
																											if (205662 - 172639 != 33023)
																											{
																												continue;
																											}
																											skillClass.cType = "earthSmasher";
																											if (63981 - 235059 != -171078)
																											{
																												continue;
																											}
																											break;
																										}
																										skillClass.setReq(24, 15);
																										if (195659 - 160574 == 35086)
																										{
																											continue;
																										}
																										skillClass.setSP(-20);
																										if (73711 - 100897 != -27186)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.instant;
																										if (231074 - 487371 == -256296)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.enemy;
																										if (15538 - 415685 != -400147)
																										{
																											continue;
																										}
																										skillClass.cType = "earthRupture";
																										if (68475 - 87636 != -19161)
																										{
																											continue;
																										}
																										break;
																									}
																									IL_2BF8:
																									skillClass.setReq(24, 12);
																									if (38412 - 246568 != -208156)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (59082 - 97613 != -38530)
																									{
																										break;
																									}
																									continue;
																									IL_2A34:
																									skillClass.setReq(20, 8);
																									if (166127 - 81391 != 84736)
																									{
																										continue;
																									}
																									goto IL_2BF8;
																								}
																								IL_BB1:
																								skillClass.setReq(24, 12);
																								if (252098 - 389707 != -137609)
																								{
																									continue;
																								}
																								skillClass.mode = eSkillMode.passive;
																								if (12410 - 81230 != -68819)
																								{
																									break;
																								}
																								continue;
																								IL_2EA4:
																								skillClass.setReq(20, 8);
																								if (56793 - 274061 != -217268)
																								{
																									continue;
																								}
																								goto IL_BB1;
																							}
																							IL_6B:
																							skillClass.setReq(19, 7);
																							if (3653 - 289708 != -286055)
																							{
																								continue;
																							}
																							IL_2767:
																							skillClass.setReq(25, 9);
																							if (293345 - 325057 != -31712)
																							{
																								continue;
																							}
																							skillClass.mode = eSkillMode.passive;
																							if (28614 - 266792 != -238177)
																							{
																								break;
																							}
																							continue;
																							IL_1E96:
																							skillClass.setReq(13, 5);
																							if (173845 - 273037 != -99191)
																							{
																								goto IL_6B;
																							}
																							continue;
																						}
																						skillClass.setReq(23, 7);
																						if (105783 - 516237 == -410453)
																						{
																							continue;
																						}
																						skillClass.mode = eSkillMode.passive;
																						if (38095 - 216110 != -178015)
																						{
																							continue;
																						}
																						break;
																					}
																					skillClass.setReq(11, 3);
																					if (36871 - 249785 == -212913)
																					{
																						continue;
																					}
																					skillClass.setMP(10);
																					if (243975 - 283089 != -39114)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.instant;
																					if (55538 - 275929 != -220391)
																					{
																						continue;
																					}
																					skillClass.target = eSkillTarget.self;
																					if (42519 - 108793 == -66273)
																					{
																						continue;
																					}
																					skillClass.cType = "warcry";
																					if (153728 - 532339 != -378611)
																					{
																						continue;
																					}
																					break;
																				}
																				skillClass.setReq(21, 3);
																				if (31392 - 110565 == -79172)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.passive;
																				if (187746 - 574907 != -387161)
																				{
																					continue;
																				}
																				break;
																			}
																			skillClass.setReq(15, 2);
																			if (260399 - 287212 != -26813)
																			{
																				continue;
																			}
																			skillClass.setSP(-15);
																			if (80772 - 120684 == -39911)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.instant;
																			if (84868 - 251659 == -166790)
																			{
																				continue;
																			}
																			skillClass.target = eSkillTarget.enemy;
																			if (248302 - 464088 != -215786)
																			{
																				continue;
																			}
																			skillClass.cType = "powerCleave";
																			if (233152 - 17721 != 215432)
																			{
																				break;
																			}
																			continue;
																		}
																		skillClass.setReq(40, 25);
																		if (250700 - 67687 == 183014)
																		{
																			continue;
																		}
																		skillClass.setMPSP(20, -80);
																		if (273272 - 187091 == 86182)
																		{
																			continue;
																		}
																		skillClass.mode = eSkillMode.instant;
																		if (182873 - 598728 == -415854)
																		{
																			continue;
																		}
																		skillClass.target = eSkillTarget.self;
																		if (275309 - 66074 == 209236)
																		{
																			continue;
																		}
																		skillClass.cType = "overPower";
																		if (200650 - 117576 != 83075)
																		{
																			break;
																		}
																		continue;
																	}
																	skillClass.setReq(27, 18);
																	if (207493 - 113619 != 93874)
																	{
																		continue;
																	}
																	IL_181D:
																	skillClass.setReq(30, 21);
																	if (20295 - 211229 == -190933)
																	{
																		continue;
																	}
																	IL_287D:
																	skillClass.setReq(33, 24);
																	if (281559 - 114995 == 166565)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.passive;
																	if (234972 - 88921 != 146052)
																	{
																		break;
																	}
																	continue;
																}
																skillClass.setReq(24, 15);
																if (231913 - 69674 != 162240)
																{
																	goto IL_26DB;
																}
																continue;
																IL_1CF1:
																skillClass.setReq(32, 21);
																if (80794 - 38292 == 42503)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.passive;
																if (218372 - 264186 != -45814)
																{
																	continue;
																}
																break;
																IL_26DB:
																skillClass.setReq(28, 18);
																if (223164 - 84582 != 138582)
																{
																	continue;
																}
																goto IL_1CF1;
															}
															skillClass.setReq(20, 8);
															if (230721 - 182836 != 47885)
															{
																continue;
															}
															skillClass.setSP(-18);
															if (297002 - 130245 == 166758)
															{
																continue;
															}
															skillClass.mode = eSkillMode.target;
															if (242513 - 439802 == -197288)
															{
																continue;
															}
															skillClass.target = eSkillTarget.enemy;
															if (275709 - 402223 == -126513)
															{
																continue;
															}
															skillClass.cType = "farStun";
															if (177653 - 190929 != -13275)
															{
																break;
															}
															continue;
														}
														IL_1033:
														skillClass.setReq(27, 9);
														if (29146 - 18416 != 10730)
														{
															continue;
														}
														skillClass.mode = eSkillMode.passive;
														if (126263 - 327523 != -201260)
														{
															continue;
														}
														break;
														IL_1B59:
														skillClass.setReq(21, 7);
														if (106329 - 175229 != -68899)
														{
															goto IL_1033;
														}
														continue;
														IL_20D5:
														skillClass.setReq(15, 5);
														if (168541 - 463318 != -294776)
														{
															goto IL_1B59;
														}
														continue;
													}
													skillClass.setReq(13, 4);
													if (293696 - 86569 != 207127)
													{
														continue;
													}
													skillClass.setSP(-8);
													if (89810 - 151039 != -61229)
													{
														continue;
													}
													IL_CBE:
													skillClass.setReq(19, 6);
													if (148415 - 428345 == -279929)
													{
														continue;
													}
													skillClass.setSP(-12);
													if (283235 - 376304 == -93068)
													{
														continue;
													}
													IL_29CC:
													skillClass.setReq(25, 8);
													if (184741 - 443423 != -258682)
													{
														continue;
													}
													skillClass.setSP(-15);
													if (96719 - 535533 == -438813)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (181340 - 333908 != -152568)
													{
														continue;
													}
													skillClass.target = eSkillTarget.self;
													if (222230 - 499127 != -276897)
													{
														continue;
													}
													skillClass.cType = "knockDown";
													if (277419 - 170754 != 106665)
													{
														continue;
													}
													break;
												}
												skillClass.setReq(23, 7);
												if (275888 - 484220 != -208332)
												{
													continue;
												}
												skillClass.setSP(-40);
												if (136382 - 582192 != -445810)
												{
													continue;
												}
												skillClass.mode = eSkillMode.instant;
												if (109601 - 78261 != 31340)
												{
													continue;
												}
												skillClass.target = eSkillTarget.enemy;
												if (138286 - 66053 != 72233)
												{
													continue;
												}
												skillClass.cType = "trample";
												if (127822 - 43593 != 84230)
												{
													break;
												}
												continue;
											}
											skillClass.setReq(11, 3);
											if (228438 - 185759 == 42680)
											{
												continue;
											}
											skillClass.setSP(14);
											if (140530 - 481501 == -340970)
											{
												continue;
											}
											skillClass.mode = eSkillMode.instant;
											if (162516 - 390470 != -227954)
											{
												continue;
											}
											skillClass.target = eSkillTarget.enemy;
											if (158321 - 296699 != -138378)
											{
												continue;
											}
											skillClass.cType = "slam";
											if (229213 - 327432 != -98218)
											{
												break;
											}
											continue;
										}
										skillClass.setReq(9, 1);
										if (162846 - 178805 == -15958)
										{
											continue;
										}
										skillClass.setMP(6);
										if (47300 - 42149 != 5151)
										{
											continue;
										}
										IL_253B:
										skillClass.setReq(15, 2);
										if (78390 - 312198 != -233808)
										{
											continue;
										}
										skillClass.setMP(8);
										if (208947 - 497381 != -288434)
										{
											continue;
										}
										IL_306A:
										skillClass.setReq(21, 3);
										if (142219 - 492183 == -349963)
										{
											continue;
										}
										skillClass.setMP(10);
										if (195263 - 149195 != 46068)
										{
											continue;
										}
										skillClass.mode = eSkillMode.instant;
										if (250816 - 336457 == -85640)
										{
											continue;
										}
										skillClass.target = eSkillTarget.self;
										if (227513 - 99997 != 127516)
										{
											continue;
										}
										skillClass.cType = "enrage";
										if (277713 - 15595 != 262118)
										{
											continue;
										}
										break;
									}
									IL_10D9:
									skillClass.setReq(40, 10);
									if (82999 - 321509 == -238509)
									{
										continue;
									}
									skillClass.mode = eSkillMode.passive;
									if (23592 - 485538 != -461945)
									{
										break;
									}
									continue;
									IL_26FF:
									skillClass.setReq(30, 8);
									if (188924 - 195465 != -6541)
									{
										continue;
									}
									goto IL_10D9;
									IL_2D9C:
									skillClass.setReq(20, 6);
									if (19397 - 466981 != -447584)
									{
										continue;
									}
									goto IL_26FF;
								}
								IL_1F4:
								skillClass.setReq(24, 8);
								if (148888 - 428313 != -279424)
								{
									goto IL_1CCD;
								}
								continue;
								IL_17AA:
								skillClass.setReq(16, 6);
								if (132171 - 184405 != -52233)
								{
									goto IL_1F4;
								}
								continue;
								IL_1CCD:
								skillClass.setReq(32, 10);
								if (179504 - 75410 == 104095)
								{
									continue;
								}
								skillClass.mode = eSkillMode.passive;
								if (234230 - 123289 != 110942)
								{
									break;
								}
								continue;
							}
							skillClass.setReq(12, 4);
							if (132396 - 566174 == -433777)
							{
								continue;
							}
							skillClass.mode = eSkillMode.passive;
							if (183374 - 149637 != 33737)
							{
								continue;
							}
							break;
						}
						skillClass.setReq(10, 3);
						if (288191 - 283283 == 4909)
						{
							continue;
						}
						skillClass.mode = eSkillMode.passive;
						if (211915 - 80948 != 130967)
						{
							continue;
						}
						break;
					}
					IL_8E:
					skillClass.setReq(3, 2);
					if (187754 - 293159 != -105405)
					{
						continue;
					}
					goto IL_2FA3;
					IL_A88:
					skillClass.setReq(2, 1);
					if (292583 - 294372 != -1789)
					{
						continue;
					}
					goto IL_8E;
					IL_2FA3:
					skillClass.setReq(4, 3);
					if (108812 - 573729 == -464917)
					{
						skillClass.mode = eSkillMode.passive;
						if (281203 - 243126 == 38077)
						{
							break;
						}
					}
				}
			}
		}
		return skillClass;
	}

	// Token: 0x06001FB3 RID: 8115 RVA: 0x0037E174 File Offset: 0x0037C374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillTree(int commandNum)
	{
		if (279740 - 243028 != 36712)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (236924 - 351355 == -114431)
			{
				if (50606 - 317751 != -267144)
				{
					if (commandNum == 101)
					{
						if (177273 - 460593 != -283319)
						{
							result = "bsn_nAttack1";
							if (289588 - 187112 == 102476)
							{
								break;
							}
						}
					}
					else if (commandNum == 102)
					{
						if (45735 - 141455 == -95720)
						{
							result = "bsn_nAttack2";
							if (207993 - 377047 == -169054)
							{
								break;
							}
						}
					}
					else if (commandNum == 103)
					{
						if (47048 - 297782 != -250733)
						{
							result = "bsn_nAttack3";
							if (150287 - 315630 != -165342)
							{
								break;
							}
						}
					}
					else if (commandNum == 104)
					{
						if (6912 - 269518 == -262606)
						{
							result = "bsn_nAttack4";
							if (298691 - 501555 == -202864)
							{
								break;
							}
						}
					}
					else if (commandNum == 111)
					{
						if (24909 - 587390 != -562480)
						{
							result = "bsn_cAttack1";
							if (261352 - 465444 == -204092)
							{
								break;
							}
						}
					}
					else if (commandNum == 112)
					{
						if (77266 - 423967 == -346701)
						{
							result = "bsn_cAttack2";
							if (100014 - 257069 == -157055)
							{
								break;
							}
						}
					}
					else if (commandNum == 113)
					{
						if (245510 - 153469 == 92041)
						{
							result = "bsn_holdCharge1";
							if (62651 - 541081 != -478429)
							{
								break;
							}
						}
					}
					else if (commandNum == 121)
					{
						if (227836 - 163837 != 64000)
						{
							result = "bsn_bloodRage1";
							if (175555 - 24177 != 151379)
							{
								break;
							}
						}
					}
					else if (commandNum == 122)
					{
						if (102967 - 424024 != -321056)
						{
							result = "bsn_bloodRage2";
							if (32179 - 377343 != -345163)
							{
								break;
							}
						}
					}
					else if (commandNum == 131)
					{
						if (193351 - 43559 != 149793)
						{
							result = "bsn_bruteStrength1";
							if (180820 - 483430 != -302609)
							{
								break;
							}
						}
					}
					else if (commandNum == 132)
					{
						if (67785 - 459726 != -391940)
						{
							result = "bsn_bruteStrength2";
							if (73329 - 435560 != -362230)
							{
								break;
							}
						}
					}
					else if (commandNum == 133)
					{
						if (174912 - 119415 != 55498)
						{
							result = "bsn_bruteStrength3";
							if (83004 - 458478 != -375473)
							{
								break;
							}
						}
					}
					else if (commandNum == 134)
					{
						if (215648 - 213402 != 2247)
						{
							result = "bsn_bruteStrength4";
							if (19913 - 300629 != -280715)
							{
								break;
							}
						}
					}
					else if (commandNum == 141)
					{
						if (263202 - 1857 == 261345)
						{
							result = "bsn_statPlus1";
							if (67170 - 42290 == 24880)
							{
								break;
							}
						}
					}
					else if (commandNum == 142)
					{
						if (226743 - 272152 != -45408)
						{
							result = "bsn_statPlus2";
							if (120090 - 152196 != -32105)
							{
								break;
							}
						}
					}
					else if (commandNum == 143)
					{
						if (237077 - 294043 == -56966)
						{
							result = "bsn_statPlus3";
							if (276681 - 199820 != 76862)
							{
								break;
							}
						}
					}
					else if (commandNum == 144)
					{
						if (150802 - 445053 == -294251)
						{
							result = "bsn_statPlus4";
							if (183921 - 240681 == -56760)
							{
								break;
							}
						}
					}
					else if (commandNum == 201)
					{
						if (67431 - 127131 == -59700)
						{
							result = "bsn_enrage1";
							if (91690 - 83419 == 8271)
							{
								break;
							}
						}
					}
					else if (commandNum == 202)
					{
						if (102026 - 546369 == -444343)
						{
							result = "bsn_enrage2";
							if (182486 - 178476 != 4011)
							{
								break;
							}
						}
					}
					else if (commandNum == 203)
					{
						if (298390 - 381426 != -83035)
						{
							result = "bsn_enrage3";
							if (202896 - 188986 == 13910)
							{
								break;
							}
						}
					}
					else if (commandNum == 204)
					{
						if (93589 - 584628 != -491038)
						{
							result = "bsn_enrage4";
							if (247812 - 289874 == -42062)
							{
								break;
							}
						}
					}
					else if (commandNum == 211)
					{
						if (39132 - 171897 != -132764)
						{
							result = "bsn_slam1";
							if (27350 - 42841 != -15490)
							{
								break;
							}
						}
					}
					else if (commandNum == 212)
					{
						if (273632 - 170063 == 103569)
						{
							result = "bsn_slam2";
							if (176887 - 302460 != -125572)
							{
								break;
							}
						}
					}
					else if (commandNum == 213)
					{
						if (213643 - 407432 == -193789)
						{
							result = "bsn_trample1";
							if (187221 - 187926 != -704)
							{
								break;
							}
						}
					}
					else if (commandNum == 214)
					{
						if (237554 - 180453 != 57102)
						{
							result = "bsn_trample2";
							if (193992 - 514190 != -320197)
							{
								break;
							}
						}
					}
					else if (commandNum == 221)
					{
						if (221054 - 175580 != 45475)
						{
							result = "bsn_knockDown1";
							if (85822 - 538927 == -453105)
							{
								break;
							}
						}
					}
					else if (commandNum == 222)
					{
						if (111141 - 577888 == -466747)
						{
							result = "bsn_knockDown2";
							if (176698 - 270554 == -93856)
							{
								break;
							}
						}
					}
					else if (commandNum == 223)
					{
						if (126603 - 435148 != -308544)
						{
							result = "bsn_knockDown3";
							if (251132 - 594830 == -343698)
							{
								break;
							}
						}
					}
					else if (commandNum == 224)
					{
						if (270665 - 202857 != 67809)
						{
							result = "bsn_knockDown4";
							if (205545 - 580026 == -374481)
							{
								break;
							}
						}
					}
					else if (commandNum == 231)
					{
						if (180892 - 9404 == 171488)
						{
							result = "bsn_controlledSwing1";
							if (211731 - 475281 != -263549)
							{
								break;
							}
						}
					}
					else if (commandNum == 232)
					{
						if (235071 - 53638 == 181433)
						{
							result = "bsn_improvedSwing1";
							if (142694 - 267014 == -124320)
							{
								break;
							}
						}
					}
					else if (commandNum == 233)
					{
						if (268048 - 443118 != -175069)
						{
							result = "bsn_improvedSwing2";
							if (66920 - 142530 == -75610)
							{
								break;
							}
						}
					}
					else if (commandNum == 234)
					{
						if (77692 - 404121 != -326428)
						{
							result = "bsn_improvedSwing3";
							if (207063 - 345618 != -138554)
							{
								break;
							}
						}
					}
					else if (commandNum == 241)
					{
						if (134080 - 187467 != -53386)
						{
							result = "bsn_farStun1";
							if (234186 - 541164 != -306977)
							{
								break;
							}
						}
					}
					else if (commandNum == 242)
					{
						if (49124 - 213176 != -164051)
						{
							result = "bsn_farStun2";
							if (28175 - 248653 == -220478)
							{
								break;
							}
						}
					}
					else if (commandNum == 243)
					{
						if (57402 - 299419 == -242017)
						{
							result = "bsn_instantRush1";
							if (787 - 557528 == -556741)
							{
								break;
							}
						}
					}
					else if (commandNum == 251)
					{
						if (198853 - 581077 == -382224)
						{
							result = "bsn_berserkerRush1";
							if (247386 - 586681 != -339294)
							{
								break;
							}
						}
					}
					else if (commandNum == 252)
					{
						if (91508 - 186123 != -94614)
						{
							result = "bsn_berserkerRush2";
							if (109624 - 375353 != -265728)
							{
								break;
							}
						}
					}
					else if (commandNum == 253)
					{
						if (114521 - 232214 == -117693)
						{
							result = "bsn_berserkerRush3";
							if (220659 - 38830 == 181829)
							{
								break;
							}
						}
					}
					else if (commandNum == 254)
					{
						if (280014 - 29955 == 250059)
						{
							result = "bsn_berserkerRush4";
							if (197281 - 471640 == -274359)
							{
								break;
							}
						}
					}
					else if (commandNum == 261)
					{
						if (179244 - 580541 == -401297)
						{
							result = "bsn_restingGlory1";
							if (87467 - 277395 == -189928)
							{
								break;
							}
						}
					}
					else if (commandNum == 262)
					{
						if (244570 - 318414 != -73843)
						{
							result = "bsn_furyTrance1";
							if (199255 - 533143 != -333887)
							{
								break;
							}
						}
					}
					else if (commandNum == 263)
					{
						if (161909 - 72826 == 89083)
						{
							result = "bsn_furyTrance2";
							if (193711 - 233294 != -39582)
							{
								break;
							}
						}
					}
					else if (commandNum == 264)
					{
						if (19534 - 515683 == -496149)
						{
							result = "bsn_furyTrance3";
							if (124405 - 78032 == 46373)
							{
								break;
							}
						}
					}
					else if (commandNum == 271)
					{
						if (260163 - 570084 == -309921)
						{
							result = "bsn_overPower1";
							if (216130 - 252619 == -36489)
							{
								break;
							}
						}
					}
					else if (commandNum == 272)
					{
						if (136193 - 448773 != -312579)
						{
							result = "bsn_overPower2";
							if (54097 - 536840 == -482743)
							{
								break;
							}
						}
					}
					else if (commandNum == 273)
					{
						if (289545 - 352487 == -62942)
						{
							result = "bsn_overSwing1";
							if (275404 - 442209 != -166804)
							{
								break;
							}
						}
					}
					else if (commandNum == 301)
					{
						if (225931 - 144716 != 81216)
						{
							result = "bsn_powerCleave1";
							if (4174 - 372108 == -367934)
							{
								break;
							}
						}
					}
					else if (commandNum == 302)
					{
						if (276505 - 248111 != 28395)
						{
							result = "bsn_powerHammer1";
							if (56437 - 151071 == -94634)
							{
								break;
							}
						}
					}
					else if (commandNum == 303)
					{
						if (281433 - 317758 == -36325)
						{
							result = "bsn_powerCleave2";
							if (257642 - 248873 != 8770)
							{
								break;
							}
						}
					}
					else if (commandNum == 304)
					{
						if (78956 - 183533 != -104576)
						{
							result = "bsn_powerHammer2";
							if (158090 - 467742 != -309651)
							{
								break;
							}
						}
					}
					else if (commandNum == 311)
					{
						if (41945 - 372762 == -330817)
						{
							result = "bsn_warcry1";
							if (185589 - 537168 == -351579)
							{
								break;
							}
						}
					}
					else if (commandNum == 312)
					{
						if (252507 - 442861 != -190353)
						{
							result = "bsn_warcry2";
							if (135973 - 252994 == -117021)
							{
								break;
							}
						}
					}
					else if (commandNum == 313)
					{
						if (4778 - 185947 != -181168)
						{
							result = "bsn_overlord1";
							if (105159 - 456740 == -351581)
							{
								break;
							}
						}
					}
					else if (commandNum == 314)
					{
						if (179795 - 79869 != 99927)
						{
							result = "bsn_overlord2";
							if (274679 - 48221 == 226458)
							{
								break;
							}
						}
					}
					else if (commandNum == 321)
					{
						if (227676 - 28764 == 198912)
						{
							result = "bsn_overPride1";
							if (175373 - 40389 == 134984)
							{
								break;
							}
						}
					}
					else if (commandNum == 322)
					{
						if (88801 - 545589 != -456787)
						{
							result = "bsn_overPride2";
							if (196341 - 515530 != -319188)
							{
								break;
							}
						}
					}
					else if (commandNum == 323)
					{
						if (163820 - 277041 != -113220)
						{
							result = "bsn_overPride3";
							if (267015 - 115967 != 151049)
							{
								break;
							}
						}
					}
					else if (commandNum == 324)
					{
						if (216510 - 320685 == -104175)
						{
							result = "bsn_overPride4";
							if (109529 - 560721 != -451191)
							{
								break;
							}
						}
					}
					else if (commandNum == 331)
					{
						if (1650 - 538619 == -536969)
						{
							result = "bsn_ironSkin1";
							if (295232 - 448950 == -153718)
							{
								break;
							}
						}
					}
					else if (commandNum == 332)
					{
						if (183700 - 44946 != 138755)
						{
							result = "bsn_ironSkin2";
							if (57513 - 381776 == -324263)
							{
								break;
							}
						}
					}
					else if (commandNum == 333)
					{
						if (230065 - 197611 == 32454)
						{
							result = "bsn_ironSkin3";
							if (270791 - 429808 == -159017)
							{
								break;
							}
						}
					}
					else if (commandNum == 334)
					{
						if (132776 - 36381 != 96396)
						{
							result = "bsn_ironShield1";
							if (207258 - 398805 == -191547)
							{
								break;
							}
						}
					}
					else if (commandNum == 341)
					{
						if (194362 - 578327 == -383965)
						{
							result = "bsn_diamondSkin1";
							if (238350 - 431160 != -192809)
							{
								break;
							}
						}
					}
					else if (commandNum == 342)
					{
						if (254823 - 131018 != 123806)
						{
							result = "bsn_diamondSkin2";
							if (2438 - 158869 != -156430)
							{
								break;
							}
						}
					}
					else if (commandNum == 343)
					{
						if (98709 - 571744 != -473034)
						{
							result = "bsn_diamondSkin3";
							if (37799 - 410537 == -372738)
							{
								break;
							}
						}
					}
					else if (commandNum == 344)
					{
						if (21257 - 135338 == -114081)
						{
							result = "bsn_diamondShield1";
							if (254382 - 502276 == -247894)
							{
								break;
							}
						}
					}
					else if (commandNum == 351)
					{
						if (215988 - 574065 != -358076)
						{
							result = "bsn_earthRupture1";
							if (275899 - 97277 != 178623)
							{
								break;
							}
						}
					}
					else if (commandNum == 352)
					{
						if (150636 - 43729 == 106907)
						{
							result = "bsn_earthRupture2";
							if (229806 - 46647 != 183160)
							{
								break;
							}
						}
					}
					else if (commandNum == 353)
					{
						if (241905 - 512857 != -270951)
						{
							result = "bsn_earthSmasher1";
							if (209077 - 48111 == 160966)
							{
								break;
							}
						}
					}
					else if (commandNum == 354)
					{
						if (118268 - 363440 != -245171)
						{
							result = "bsn_earthSmasher2";
							if (61460 - 113638 == -52178)
							{
								break;
							}
						}
					}
					else if (commandNum == 361)
					{
						if (260175 - 288755 != -28579)
						{
							result = "bsn_colossalWeapon1";
							if (223322 - 157355 == 65967)
							{
								break;
							}
						}
					}
					else if (commandNum == 362)
					{
						if (267413 - 503921 == -236508)
						{
							result = "bsn_colossalWeapon2";
							if (200223 - 459718 == -259495)
							{
								break;
							}
						}
					}
					else if (commandNum == 363)
					{
						if (258475 - 405515 != -147039)
						{
							result = "bsn_colossalArmor1";
							if (190532 - 581416 != -390883)
							{
								break;
							}
						}
					}
					else if (commandNum == 364)
					{
						if (159792 - 372231 != -212438)
						{
							result = "bsn_colossalArmor2";
							if (136580 - 86908 == 49672)
							{
								break;
							}
						}
					}
					else if (commandNum == 371)
					{
						if (135725 - 231701 != -95975)
						{
							result = "bsn_titanForm1";
							if (270388 - 60500 == 209888)
							{
								break;
							}
						}
					}
					else if (commandNum == 372)
					{
						if (243452 - 570018 == -326566)
						{
							result = "bsn_titanForm2";
							if (273772 - 488562 != -214789)
							{
								break;
							}
						}
					}
					else if (commandNum == 401)
					{
						if (11763 - 54272 == -42509)
						{
							result = "bsn_addedSwing5";
							if (176974 - 492057 != -315082)
							{
								break;
							}
						}
					}
					else if (commandNum == 411)
					{
						if (52229 - 371686 == -319457)
						{
							result = "bsn_solidHold5";
							if (150392 - 76045 == 74347)
							{
								break;
							}
						}
					}
					else if (commandNum == 421)
					{
						if (108853 - 266764 != -157910)
						{
							result = "bsn_bloodBath5";
							if (237412 - 331240 == -93828)
							{
								break;
							}
						}
					}
					else if (commandNum == 431)
					{
						if (92992 - 147702 != -54709)
						{
							result = "bsn_rawStrength5";
							if (262092 - 160865 != 101228)
							{
								break;
							}
						}
					}
					else if (commandNum == 441)
					{
						if (62945 - 493193 != -430247)
						{
							result = "bsn_superStatPlus5";
							if (122562 - 547952 == -425390)
							{
								break;
							}
						}
					}
					else if (commandNum == 402)
					{
						if (194154 - 290697 != -96542)
						{
							result = "bsn_rageControl5";
							if (136399 - 442461 == -306062)
							{
								break;
							}
						}
					}
					else if (commandNum == 412)
					{
						if (185688 - 480888 == -295200)
						{
							result = "bsn_aspectOfTheHorde5";
							if (119585 - 213100 != -93514)
							{
								break;
							}
						}
					}
					else if (commandNum == 422)
					{
						if (296086 - 463742 == -167656)
						{
							result = "bsn_aftershock5";
							if (76427 - 572835 == -496408)
							{
								break;
							}
						}
					}
					else if (commandNum == 432)
					{
						if (235661 - 131029 == 104632)
						{
							result = "bsn_spinHack5";
							if (15404 - 28964 == -13560)
							{
								break;
							}
						}
					}
					else if (commandNum == 442)
					{
						if (72148 - 60707 != 11442)
						{
							result = "bsn_massStun5";
							if (256415 - 261548 == -5133)
							{
								break;
							}
						}
					}
					else if (commandNum == 403)
					{
						if (298038 - 195789 != 102250)
						{
							result = "bsn_powerReel5";
							if (106013 - 146521 == -40508)
							{
								break;
							}
						}
					}
					else if (commandNum == 413)
					{
						if (42442 - 466585 != -424142)
						{
							result = "bsn_onslaught5";
							if (260012 - 161886 == 98126)
							{
								break;
							}
						}
					}
					else if (commandNum == 423)
					{
						if (112085 - 317468 != -205382)
						{
							result = "bsn_prideCrusher5";
							if (127121 - 58701 != 68421)
							{
								break;
							}
						}
					}
					else if (commandNum == 433)
					{
						if (141373 - 460793 != -319419)
						{
							result = "bsn_steelSkin5";
							if (269187 - 300043 == -30856)
							{
								break;
							}
						}
					}
					else if (commandNum == 443)
					{
						if (80217 - 17409 == 62808)
						{
							result = "bsn_mythrilSkin5";
							if (195615 - 299905 == -104290)
							{
								break;
							}
						}
					}
					else if (commandNum == 404)
					{
						if (37817 - 529173 != -491355)
						{
							result = "bsn_revisedSkill5";
							if (96716 - 208539 != -111822)
							{
								break;
							}
						}
					}
					else if (commandNum == 414)
					{
						if (84338 - 200279 == -115941)
						{
							result = "bsn_revisedMagic5";
							if (112625 - 539972 == -427347)
							{
								break;
							}
						}
					}
					else if (commandNum == 424)
					{
						if (31694 - 375575 != -343880)
						{
							result = "bsn_revisedArt5";
							if (67347 - 290652 != -223304)
							{
								break;
							}
						}
					}
					else if (commandNum == 434)
					{
						if (20703 - 552152 != -531448)
						{
							result = "bsn_magmaClutter5";
							if (231303 - 303287 == -71984)
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
						if (234744 - 24273 == 210471)
						{
							result = "bsn_calamityHammer5";
							if (236580 - 311765 == -75185)
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

	// Token: 0x06001FB4 RID: 8116 RVA: 0x0037FDD8 File Offset: 0x0037DFD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x0037FDDC File Offset: 0x0037DFDC
	internal static bool Ks36bdwe0YS5tvWoumC()
	{
		return true;
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x0037FDE0 File Offset: 0x0037DFE0
	internal static bool A33ApdwrOyNPu6j8hKY()
	{
		return false;
	}
}
