using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020004EE RID: 1262
[Serializable]
public class BatSkill : MonoBehaviour
{
	// Token: 0x06001CF8 RID: 7416 RVA: 0x0031175C File Offset: 0x0030F95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BatSkill()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001CF9 RID: 7417 RVA: 0x0031176C File Offset: 0x0030F96C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSkill(string skillname)
	{
		if (260694 - 78518 != 182176)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (93486 - 141274 != -47787 && 268854 - 359866 != -91011)
			{
				if (skillname == "bat_nAttack1")
				{
					if (16020 - 319582 != -303562)
					{
						continue;
					}
					skillClass.setReq(1, 0);
					if (173855 - 460512 != -286656)
					{
						goto IL_192E;
					}
					continue;
				}
				else if (skillname == "bat_nAttack2")
				{
					if (212626 - 590539 != -377913)
					{
						continue;
					}
					goto IL_192E;
				}
				else if (skillname == "bat_nAttack3")
				{
					if (87245 - 246982 != -159737)
					{
						continue;
					}
				}
				else
				{
					if (skillname == "bat_cAttack1")
					{
						if (131369 - 431996 != -300627)
						{
							continue;
						}
						skillClass.setReq(4, 1);
						if (186620 - 148015 != 38605)
						{
							continue;
						}
					}
					else if (skillname == "bat_cAttack2")
					{
						if (195341 - 465991 == -270649)
						{
							continue;
						}
					}
					else if (skillname == "bat_cAttack3")
					{
						if (27088 - 513224 != -486135)
						{
							goto IL_37C2;
						}
						continue;
					}
					else
					{
						if (skillname == "bat_drainMana1")
						{
							if (238610 - 185516 == 53095)
							{
								continue;
							}
							skillClass.setReq(8, 2);
							if (125117 - 172312 == -47194)
							{
								continue;
							}
						}
						else if (skillname == "bat_drainMana2")
						{
							if (39709 - 244918 == -205208)
							{
								continue;
							}
						}
						else if (skillname == "bat_drainMana3")
						{
							if (175744 - 258610 != -82866)
							{
								continue;
							}
							goto IL_1693;
						}
						else
						{
							if (skillname == "bat_massCast1")
							{
								if (78125 - 272055 == -193929)
								{
									continue;
								}
								skillClass.setReq(32, 6);
								if (71542 - 94239 == -22696)
								{
									continue;
								}
								skillClass.setMPSP(30, -15);
								if (151246 - 509295 != -358049)
								{
									continue;
								}
							}
							else if (skillname == "bat_massCast2")
							{
								if (77613 - 150102 == -72488)
								{
									continue;
								}
							}
							else
							{
								if (skillname == "bat_statPlus1")
								{
									if (165229 - 208876 != -43647)
									{
										continue;
									}
									skillClass.setReq(10, 4);
									if (288364 - 328704 == -40339)
									{
										continue;
									}
								}
								else if (skillname == "bat_statPlus2")
								{
									if (136407 - 43003 == 93405)
									{
										continue;
									}
								}
								else if (skillname == "bat_statPlus3")
								{
									if (73953 - 597635 != -523682)
									{
										continue;
									}
									goto IL_342B;
								}
								else if (skillname == "bat_statPlus4")
								{
									if (50891 - 506513 != -455622)
									{
										continue;
									}
									goto IL_2A6C;
								}
								else
								{
									if (skillname == "bat_phantomBane1")
									{
										if (11892 - 63502 == -51609)
										{
											continue;
										}
										skillClass.setReq(3, 0);
										if (164887 - 398259 == -233371)
										{
											continue;
										}
										skillClass.setMP(10);
										if (203141 - 304423 == -101281)
										{
											continue;
										}
									}
									else if (skillname == "bat_phantomBane2")
									{
										if (168167 - 534512 == -366344)
										{
											continue;
										}
									}
									else if (skillname == "bat_phantomBane3")
									{
										if (234310 - 273200 != -38889)
										{
											goto IL_A4B;
										}
										continue;
									}
									else if (skillname == "bat_phantomBane4")
									{
										if (239044 - 186446 != 52598)
										{
											continue;
										}
										goto IL_2EBA;
									}
									else
									{
										if (skillname == "bat_shadowGaze1")
										{
											if (221047 - 503821 != -282774)
											{
												continue;
											}
											skillClass.setReq(5, 1);
											if (69162 - 305297 != -236135)
											{
												continue;
											}
											skillClass.setMP(11);
											if (126435 - 276586 != -150151)
											{
												continue;
											}
										}
										else if (skillname == "bat_shadowGaze2")
										{
											if (107139 - 44898 != 62241)
											{
												continue;
											}
										}
										else if (skillname == "bat_shadowGaze3")
										{
											if (134928 - 437518 != -302590)
											{
												continue;
											}
											goto IL_3470;
										}
										else if (skillname == "bat_shadowGaze4")
										{
											if (292442 - 353335 != -60892)
											{
												goto IL_1FB9;
											}
											continue;
										}
										else
										{
											if (skillname == "bat_dissolute1")
											{
												if (213219 - 548857 != -335638)
												{
													continue;
												}
												skillClass.setReq(7, 2);
												if (221467 - 365616 == -144148)
												{
													continue;
												}
												skillClass.setMP(13);
												if (172705 - 483810 == -311104)
												{
													continue;
												}
											}
											else if (skillname == "bat_dissolute2")
											{
												if (234313 - 199393 != 34920)
												{
													continue;
												}
											}
											else
											{
												if (skillname == "bat_corruption1")
												{
													if (132169 - 428827 != -296658)
													{
														continue;
													}
													skillClass.setReq(15, 4);
													if (23122 - 85336 == -62213)
													{
														continue;
													}
													skillClass.setMP(15);
													if (201247 - 228137 == -26889)
													{
														continue;
													}
												}
												else if (skillname == "bat_corruption2")
												{
													if (26292 - 234524 == -208231)
													{
														continue;
													}
												}
												else
												{
													if (skillname == "bat_curse1")
													{
														if (194329 - 298075 != -103746)
														{
															continue;
														}
														skillClass.setReq(9, 3);
														if (161729 - 414098 != -252369)
														{
															continue;
														}
														skillClass.setMP(7);
														if (128898 - 572258 != -443360)
														{
															continue;
														}
													}
													else if (skillname == "bat_curse2")
													{
														if (1448 - 370602 == -369153)
														{
															continue;
														}
													}
													else if (skillname == "bat_curse3")
													{
														if (257218 - 451165 != -193947)
														{
															continue;
														}
														goto IL_10BD;
													}
													else if (skillname == "bat_curse4")
													{
														if (129980 - 140206 != -10226)
														{
															continue;
														}
														goto IL_1341;
													}
													else
													{
														if (skillname == "bat_echoes1")
														{
															if (73384 - 49113 != 24271)
															{
																continue;
															}
															skillClass.setReq(12, 4);
															if (180888 - 216147 != -35259)
															{
																continue;
															}
															skillClass.setMPSP(17, -13);
															if (268598 - 381038 != -112440)
															{
																continue;
															}
														}
														else if (skillname == "bat_echoes2")
														{
															if (45714 - 225624 == -179909)
															{
																continue;
															}
														}
														else
														{
															if (skillname == "bat_nightmare1")
															{
																if (250156 - 170364 == 79793)
																{
																	continue;
																}
																skillClass.setReq(28, 12);
																if (144491 - 50897 != 93594)
																{
																	continue;
																}
																skillClass.setMPSP(35, -30);
																if (204018 - 414749 != -210731)
																{
																	continue;
																}
															}
															else if (skillname == "bat_nightmare2")
															{
																if (216825 - 498099 == -281273)
																{
																	continue;
																}
															}
															else
															{
																if (skillname == "bat_amplifyDamage1")
																{
																	if (283508 - 257950 == 25559)
																	{
																		continue;
																	}
																	skillClass.setReq(17, 6);
																	if (193724 - 147951 != 45774)
																	{
																		goto IL_1BA0;
																	}
																	continue;
																}
																else if (skillname == "bat_amplifyDamage2")
																{
																	if (235634 - 42458 != 193177)
																	{
																		goto IL_1BA0;
																	}
																	continue;
																}
																else if (skillname == "bat_amplifyDamage3")
																{
																	if (190418 - 141513 != 48905)
																	{
																		continue;
																	}
																	goto IL_1285;
																}
																else if (skillname == "bat_amplifyDamage4")
																{
																	if (151683 - 248329 == -96645)
																	{
																		continue;
																	}
																}
																else
																{
																	if (skillname == "bat_doom1")
																	{
																		if (45627 - 224356 != -178729)
																		{
																			continue;
																		}
																		skillClass.setReq(22, 12);
																		if (81256 - 59717 != 21539)
																		{
																			continue;
																		}
																		skillClass.setMP(35);
																		if (111245 - 405352 != -294107)
																		{
																			continue;
																		}
																	}
																	else if (skillname == "bat_doom2")
																	{
																		if (124067 - 210794 == -86726)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (skillname == "bat_shadowMastery1")
																		{
																			if (117912 - 411408 != -293496)
																			{
																				continue;
																			}
																			skillClass.setReq(34, 20);
																			if (158076 - 42005 == 116072)
																			{
																				continue;
																			}
																		}
																		else if (skillname == "bat_shadowMastery2")
																		{
																			if (186022 - 137362 != 48660)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (skillname == "bat_guardianOfTheNight1")
																			{
																				if (40536 - 578803 != -538267)
																				{
																					continue;
																				}
																				skillClass.setReq(35, 23);
																				if (217218 - 76102 == 141117)
																				{
																					continue;
																				}
																				skillClass.setMPSP(70, -35);
																				if (36032 - 164681 == -128648)
																				{
																					continue;
																				}
																			}
																			else if (skillname == "bat_guardianOfTheNight2")
																			{
																				if (264917 - 15176 != 249741)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				if (skillname == "bat_mirageOrb1")
																				{
																					if (170243 - 72107 == 98137)
																					{
																						continue;
																					}
																					skillClass.setReq(3, 0);
																					if (135711 - 488304 != -352593)
																					{
																						continue;
																					}
																					skillClass.setMP(11);
																					if (146781 - 288452 != -141671)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "bat_mirageOrb2")
																				{
																					if (90755 - 132006 == -41250)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "bat_mirageOrb3")
																				{
																					if (76520 - 575094 != -498574)
																					{
																						continue;
																					}
																					goto IL_12A9;
																				}
																				else if (skillname == "bat_mirageOrb4")
																				{
																					if (144332 - 161679 != -17347)
																					{
																						continue;
																					}
																					goto IL_1531;
																				}
																				else
																				{
																					if (skillname == "bat_shadowIllusion1")
																					{
																						if (77224 - 379785 == -302560)
																						{
																							continue;
																						}
																						skillClass.setReq(5, 1);
																						if (280032 - 304395 != -24363)
																						{
																							continue;
																						}
																						skillClass.setMP(21);
																						if (45933 - 243714 == -197780)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "bat_shadowIllusion2")
																					{
																						if (206582 - 11565 != 195017)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "bat_shadowIllusion3")
																					{
																						if (187701 - 79888 != 107814)
																						{
																							goto IL_1076;
																						}
																						continue;
																					}
																					else if (skillname == "bat_shadowIllusion4")
																					{
																						if (57235 - 244675 != -187439)
																						{
																							goto IL_2A28;
																						}
																						continue;
																					}
																					else
																					{
																						if (skillname == "bat_blind1")
																						{
																							if (27255 - 334571 == -307315)
																							{
																								continue;
																							}
																							skillClass.setReq(7, 2);
																							if (184929 - 361302 != -176373)
																							{
																								continue;
																							}
																							skillClass.setMP(7);
																							if (260857 - 115778 == 145080)
																							{
																								continue;
																							}
																						}
																						else if (skillname == "bat_blind2")
																						{
																							if (224717 - 399550 != -174833)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							if (skillname == "bat_confusion1")
																							{
																								if (172715 - 312428 == -139712)
																								{
																									continue;
																								}
																								skillClass.setReq(23, 6);
																								if (14911 - 331395 != -316484)
																								{
																									continue;
																								}
																								skillClass.setMP(7);
																								if (187454 - 224739 == -37284)
																								{
																									continue;
																								}
																							}
																							else if (skillname == "bat_confusion2")
																							{
																								if (6353 - 100893 != -94540)
																								{
																									continue;
																								}
																							}
																							else
																							{
																								if (skillname == "bat_hateTransfer1")
																								{
																									if (183942 - 197630 != -13688)
																									{
																										continue;
																									}
																									skillClass.setReq(9, 3);
																									if (265475 - 469197 != -203722)
																									{
																										continue;
																									}
																									skillClass.setMP(13);
																									if (150008 - 106226 == 43783)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "bat_hateTransfer2")
																								{
																									if (94667 - 521587 == -426919)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "bat_switch1")
																								{
																									if (186786 - 200758 == -13971)
																									{
																										continue;
																									}
																									skillClass.setReq(25, 7);
																									if (195168 - 59041 == 136128)
																									{
																										continue;
																									}
																									skillClass.setSP(-10);
																									if (215646 - 165241 == 50406)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.instant;
																									if (241515 - 193365 != 48150)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.ally;
																									if (69759 - 174280 == -104520)
																									{
																										continue;
																									}
																									skillClass.cType = "switch";
																									if (222125 - 447135 != -225009)
																									{
																										break;
																									}
																									continue;
																								}
																								else if (skillname == "bat_swap1")
																								{
																									if (44172 - 467327 == -423154)
																									{
																										continue;
																									}
																									skillClass.setReq(33, 9);
																									if (86504 - 525309 == -438804)
																									{
																										continue;
																									}
																									skillClass.setMPSP(15, -15);
																									if (239736 - 28840 == 210897)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.target;
																									if (179126 - 483530 != -304404)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.all;
																									if (95590 - 72826 != 22764)
																									{
																										continue;
																									}
																									skillClass.cType = "swap";
																									if (119502 - 385890 != -266388)
																									{
																										continue;
																									}
																									break;
																								}
																								else
																								{
																									if (skillname == "bat_dreamDazzle1")
																									{
																										if (297785 - 204678 == 93108)
																										{
																											continue;
																										}
																										skillClass.setReq(12, 4);
																										if (183684 - 302177 != -118493)
																										{
																											continue;
																										}
																										skillClass.setMPSP(23, -10);
																										if (175022 - 586387 == -411364)
																										{
																											continue;
																										}
																									}
																									else if (skillname == "bat_dreamDazzle2")
																									{
																										if (183155 - 508975 == -325819)
																										{
																											continue;
																										}
																									}
																									else
																									{
																										if (skillname == "bat_phantasmBlast1")
																										{
																											if (215996 - 24308 == 191689)
																											{
																												continue;
																											}
																											skillClass.setReq(28, 12);
																											if (159348 - 429296 != -269948)
																											{
																												continue;
																											}
																											skillClass.setMPSP(23, -10);
																											if (239454 - 359757 == -120302)
																											{
																												continue;
																											}
																										}
																										else if (skillname == "bat_phantasmBlast2")
																										{
																											if (84447 - 96781 == -12333)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											if (skillname == "bat_charm1")
																											{
																												if (250045 - 389463 != -139418)
																												{
																													continue;
																												}
																												skillClass.setReq(17, 6);
																												if (12410 - 90081 != -77671)
																												{
																													continue;
																												}
																												skillClass.setMP(21);
																												if (268250 - 202847 != 65403)
																												{
																													continue;
																												}
																											}
																											else if (skillname == "bat_charm2")
																											{
																												if (94629 - 580464 == -485834)
																												{
																													continue;
																												}
																											}
																											else
																											{
																												if (skillname == "bat_mindControl1")
																												{
																													if (89413 - 509270 != -419857)
																													{
																														continue;
																													}
																													skillClass.setReq(31, 14);
																													if (164623 - 385980 != -221357)
																													{
																														continue;
																													}
																													skillClass.setMP(35);
																													if (174391 - 478449 == -304057)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "bat_mindControl2")
																												{
																													if (234902 - 521156 == -286253)
																													{
																														continue;
																													}
																												}
																												else
																												{
																													if (skillname == "bat_dreamBurst1")
																													{
																														if (68767 - 187478 == -118710)
																														{
																															continue;
																														}
																														skillClass.setReq(22, 15);
																														if (112095 - 52826 == 59270)
																														{
																															continue;
																														}
																													}
																													else if (skillname == "bat_dreamBurst2")
																													{
																														if (99801 - 126710 != -26909)
																														{
																															continue;
																														}
																													}
																													else if (skillname == "bat_dreamBurst3")
																													{
																														if (162448 - 121332 != 41117)
																														{
																															goto IL_2FE7;
																														}
																														continue;
																													}
																													else
																													{
																														if (skillname == "bat_mimic1")
																														{
																															if (194318 - 599055 != -404737)
																															{
																																continue;
																															}
																															skillClass.setReq(35, 23);
																															if (296645 - 495382 != -198737)
																															{
																																continue;
																															}
																															skillClass.setMPSP(50, -25);
																															if (185116 - 285134 != -100018)
																															{
																																continue;
																															}
																														}
																														else if (skillname == "bat_mimic2")
																														{
																															if (277329 - 474704 == -197374)
																															{
																																continue;
																															}
																														}
																														else if (skillname == "bat_allMimic1")
																														{
																															if (65264 - 427357 == -362092)
																															{
																																continue;
																															}
																															skillClass.setReq(45, 27);
																															if (161526 - 131198 != 30328)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (284266 - 497069 != -212802)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "bat_illusionEffect5")
																														{
																															if (199163 - 481725 == -282561)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (138290 - 299808 != -161518)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (136829 - 45384 != 91445)
																															{
																																continue;
																															}
																															skillClass.rSkill = 103;
																															if (83247 - 88858 != -5610)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "bat_darkIntention5")
																														{
																															if (186522 - 355069 != -168547)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (121078 - 399385 != -278307)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (196107 - 186229 != 9878)
																															{
																																continue;
																															}
																															skillClass.rSkill = 113;
																															if (141621 - 68231 != 73390)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "bat_mercilessDrain5")
																														{
																															if (222330 - 18771 != 203559)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (75430 - 136011 != -60581)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (134614 - 454689 == -320074)
																															{
																																continue;
																															}
																															skillClass.rSkill = 123;
																															if (87213 - 451051 != -363838)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "bat_autoMass5")
																														{
																															if (14502 - 92571 == -78068)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (122024 - 237055 == -115030)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (227070 - 404069 != -176999)
																															{
																																continue;
																															}
																															skillClass.rSkill = 132;
																															if (259655 - 149933 != 109722)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "bat_superStatPlus5")
																														{
																															if (129971 - 92501 != 37470)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (182837 - 428418 != -245581)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (257060 - 255215 == 1846)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.self;
																															if (36869 - 59891 != -23022)
																															{
																																continue;
																															}
																															skillClass.rSkill = 144;
																															if (99252 - 588697 != -489444)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "bat_demonBane5")
																														{
																															if (104458 - 306936 != -202478)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (163638 - 473026 == -309387)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (133557 - 527395 != -393838)
																															{
																																continue;
																															}
																															skillClass.rSkill = 204;
																															if (231162 - 275108 != -43946)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "bat_demonGaze5")
																														{
																															if (5086 - 495992 != -490906)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (240885 - 267160 != -26275)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (156657 - 140296 == 16362)
																															{
																																continue;
																															}
																															skillClass.rSkill = 214;
																															if (147976 - 319222 != -171246)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "bat_shame5")
																														{
																															if (130340 - 77371 == 52970)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (294148 - 223148 == 71001)
																															{
																																continue;
																															}
																															skillClass.setMPSP(10, -35);
																															if (220917 - 173808 == 47110)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.target;
																															if (6148 - 356328 != -350180)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (132414 - 335543 != -203129)
																															{
																																continue;
																															}
																															skillClass.cType = "shame";
																															if (79028 - 452010 == -372981)
																															{
																																continue;
																															}
																															skillClass.rSkill = 224;
																															if (247537 - 561844 != -314306)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "bat_darkStalker5")
																														{
																															if (51238 - 84120 != -32882)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (14892 - 560243 == -545350)
																															{
																																continue;
																															}
																															skillClass.setMPSP(45, -20);
																															if (280016 - 173257 != 106759)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.target;
																															if (62592 - 169505 != -106913)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (130713 - 56145 == 74569)
																															{
																																continue;
																															}
																															skillClass.cType = "darkStalker";
																															if (259036 - 542542 != -283506)
																															{
																																continue;
																															}
																															skillClass.rSkill = 234;
																															if (187906 - 90690 != 97217)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "bat_soulEater5")
																														{
																															if (101655 - 114932 == -13276)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (111769 - 565887 != -454118)
																															{
																																continue;
																															}
																															skillClass.setMPSP(40, -40);
																															if (130916 - 121009 != 9907)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.target;
																															if (30755 - 478316 == -447560)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (221920 - 194737 != 27183)
																															{
																																continue;
																															}
																															skillClass.cType = "soulEater";
																															if (109831 - 60576 == 49256)
																															{
																																continue;
																															}
																															skillClass.rSkill = 244;
																															if (280405 - 275395 != 5010)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "bat_distantOrb5")
																														{
																															if (127976 - 448443 != -320467)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (93266 - 311707 != -218441)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (228282 - 148884 != 79398)
																															{
																																continue;
																															}
																															skillClass.rSkill = 304;
																															if (229321 - 247415 != -18093)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "bat_shadowSacrifice5")
																														{
																															if (64862 - 324811 == -259948)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (291251 - 7051 == 284201)
																															{
																																continue;
																															}
																															skillClass.setMPSP(30, -30);
																															if (82335 - 581953 == -499617)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.instant;
																															if (76806 - 49158 != 27648)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.self;
																															if (195194 - 418228 != -223034)
																															{
																																continue;
																															}
																															skillClass.cType = "shadowSacrifice";
																															if (127585 - 179017 == -51431)
																															{
																																continue;
																															}
																															skillClass.rSkill = 314;
																															if (242405 - 222759 != 19647)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "bat_chiroptophobia5")
																														{
																															if (225342 - 518037 == -292694)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (173125 - 12656 != 160469)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (290068 - 436994 != -146926)
																															{
																																continue;
																															}
																															skillClass.rSkill = 324;
																															if (135089 - 431192 != -296103)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "bat_paranoia5")
																														{
																															if (67456 - 297246 != -229790)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (280223 - 202179 == 78045)
																															{
																																continue;
																															}
																															skillClass.setMPSP(40, -25);
																															if (230965 - 497854 != -266889)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.target;
																															if (195455 - 515424 != -319969)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (294820 - 42545 == 252276)
																															{
																																continue;
																															}
																															skillClass.cType = "paranoia";
																															if (15275 - 194870 != -179595)
																															{
																																continue;
																															}
																															skillClass.rSkill = 334;
																															if (246734 - 357040 != -110305)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "bat_shatteringDream5")
																														{
																															if (19284 - 367982 != -348698)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (19807 - 392504 != -372697)
																															{
																																continue;
																															}
																															skillClass.setMPSP(50, -30);
																															if (97753 - 272989 == -175235)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.target;
																															if (239539 - 477952 == -238412)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (270301 - 248599 == 21703)
																															{
																																continue;
																															}
																															skillClass.cType = "shatteringDream";
																															if (170426 - 128474 != 41952)
																															{
																																continue;
																															}
																															skillClass.rSkill = 344;
																															if (160318 - 248146 != -87828)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "bat_revisedSkill5")
																														{
																															if (78490 - 438027 != -359537)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (139290 - 541586 != -402296)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (131891 - 537019 != -405127)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "bat_revisedMagic5")
																														{
																															if (95979 - 153770 != -57791)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (122142 - 3791 != 118351)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (42054 - 357687 != -315633)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "bat_revisedArt5")
																														{
																															if (171669 - 395501 == -223831)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (200092 - 501335 != -301243)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (162111 - 502703 != -340592)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "bat_nefariousWhip5")
																														{
																															if (67980 - 70728 == -2747)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (243161 - 526040 == -282878)
																															{
																																continue;
																															}
																															skillClass.setMPSP(70, -35);
																															if (107264 - 258924 != -151660)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.target;
																															if (30012 - 8274 == 21739)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (16334 - 578848 != -562514)
																															{
																																continue;
																															}
																															skillClass.cType = "nefariousWhip";
																															if (169551 - 73794 != 95757)
																															{
																																continue;
																															}
																															skillClass.rSkill = 243343;
																															if (125973 - 307005 != -181031)
																															{
																																break;
																															}
																															continue;
																														}
																														else
																														{
																															if (!(skillname == "bat_blackServant5"))
																															{
																																break;
																															}
																															if (25523 - 310619 == -285095)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (219247 - 344644 != -125397)
																															{
																																continue;
																															}
																															skillClass.setMPSP(66, -66);
																															if (233974 - 462462 == -228487)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.target;
																															if (159520 - 31643 == 127878)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (171998 - 536670 == -364671)
																															{
																																continue;
																															}
																															skillClass.cType = "blackServant";
																															if (123357 - 505182 != -381825)
																															{
																																continue;
																															}
																															skillClass.rSkill = 434;
																															if (52842 - 214148 != -161306)
																															{
																																continue;
																															}
																															break;
																														}
																														skillClass.setReq(40, 25);
																														if (298882 - 97419 != 201463)
																														{
																															continue;
																														}
																														skillClass.setMPSP(70, -35);
																														if (188866 - 2458 != 186408)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.target;
																														if (97128 - 392076 != -294948)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.all;
																														if (45296 - 237093 != -191797)
																														{
																															continue;
																														}
																														skillClass.cType = "mimic";
																														if (39350 - 147483 != -108133)
																														{
																															continue;
																														}
																														break;
																													}
																													skillClass.setReq(28, 18);
																													if (232543 - 457225 == -224681)
																													{
																														continue;
																													}
																													IL_2FE7:
																													skillClass.setReq(34, 21);
																													if (30096 - 244362 == -214265)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.passive;
																													if (276813 - 300751 != -23937)
																													{
																														break;
																													}
																													continue;
																												}
																												skillClass.setReq(38, 18);
																												if (269248 - 424236 == -154987)
																												{
																													continue;
																												}
																												skillClass.setMP(40);
																												if (89956 - 436730 != -346774)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.target;
																												if (178422 - 484541 == -306118)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.enemy;
																												if (15636 - 345336 != -329700)
																												{
																													continue;
																												}
																												skillClass.cType = "mindControl";
																												if (258641 - 259601 != -960)
																												{
																													continue;
																												}
																												break;
																											}
																											skillClass.setReq(24, 10);
																											if (30993 - 176478 != -145485)
																											{
																												continue;
																											}
																											skillClass.setMP(27);
																											if (92682 - 451578 != -358896)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.target;
																											if (275959 - 40109 != 235850)
																											{
																												continue;
																											}
																											skillClass.target = eSkillTarget.enemy;
																											if (129228 - 241829 != -112601)
																											{
																												continue;
																											}
																											skillClass.cType = "charm";
																											if (273704 - 423046 != -149342)
																											{
																												continue;
																											}
																											break;
																										}
																										skillClass.setReq(36, 16);
																										if (34467 - 98678 == -64210)
																										{
																											continue;
																										}
																										skillClass.setMPSP(30, -10);
																										if (168464 - 508858 == -340393)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.target;
																										if (250183 - 201594 == 48590)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.enemy;
																										if (75604 - 296094 == -220489)
																										{
																											continue;
																										}
																										skillClass.cType = "phantasmBlast";
																										if (37987 - 154243 != -116255)
																										{
																											break;
																										}
																										continue;
																									}
																									skillClass.setReq(20, 8);
																									if (139747 - 441118 != -301371)
																									{
																										continue;
																									}
																									skillClass.setMPSP(30, -10);
																									if (78837 - 127374 == -48536)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.target;
																									if (69635 - 174052 == -104416)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.enemy;
																									if (189655 - 586382 != -396727)
																									{
																										continue;
																									}
																									skillClass.cType = "dreamDazzle";
																									if (143229 - 255391 != -112162)
																									{
																										continue;
																									}
																									break;
																								}
																								skillClass.setReq(17, 5);
																								if (12804 - 70597 == -57792)
																								{
																									continue;
																								}
																								skillClass.setMP(17);
																								if (163877 - 547315 != -383438)
																								{
																									continue;
																								}
																								skillClass.mode = eSkillMode.target;
																								if (228715 - 575649 == -346933)
																								{
																									continue;
																								}
																								skillClass.target = eSkillTarget.all;
																								if (188513 - 149948 == 38566)
																								{
																									continue;
																								}
																								skillClass.cType = "hateTransfer";
																								if (290800 - 418305 != -127504)
																								{
																									break;
																								}
																								continue;
																							}
																							skillClass.setReq(31, 8);
																							if (18240 - 200276 == -182035)
																							{
																								continue;
																							}
																							skillClass.setMP(13);
																							if (51742 - 393339 == -341596)
																							{
																								continue;
																							}
																							skillClass.mode = eSkillMode.target;
																							if (212545 - 380549 == -168003)
																							{
																								continue;
																							}
																							skillClass.target = eSkillTarget.enemy;
																							if (17295 - 152511 != -135216)
																							{
																								continue;
																							}
																							skillClass.cType = "confusion";
																							if (88552 - 200253 != -111700)
																							{
																								break;
																							}
																							continue;
																						}
																						skillClass.setReq(15, 4);
																						if (287431 - 206251 != 81180)
																						{
																							continue;
																						}
																						skillClass.setMP(13);
																						if (240007 - 26716 == 213292)
																						{
																							continue;
																						}
																						skillClass.mode = eSkillMode.target;
																						if (81406 - 586166 == -504759)
																						{
																							continue;
																						}
																						skillClass.target = eSkillTarget.enemy;
																						if (114102 - 360784 != -246682)
																						{
																							continue;
																						}
																						skillClass.cType = "blind";
																						if (20658 - 301039 != -280381)
																						{
																							continue;
																						}
																						break;
																					}
																					skillClass.setReq(13, 3);
																					if (71932 - 471524 != -399592)
																					{
																						continue;
																					}
																					skillClass.setMP(29);
																					if (157473 - 422978 != -265505)
																					{
																						continue;
																					}
																					goto IL_1076;
																					IL_2A28:
																					skillClass.setReq(29, 7);
																					if (267126 - 244440 != 22686)
																					{
																						continue;
																					}
																					skillClass.setMP(45);
																					if (239956 - 439811 == -199854)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.instant;
																					if (152545 - 201114 != -48569)
																					{
																						continue;
																					}
																					skillClass.target = eSkillTarget.self;
																					if (129106 - 328415 != -199309)
																					{
																						continue;
																					}
																					skillClass.cType = "shadowIllusion";
																					if (53277 - 66640 != -13363)
																					{
																						continue;
																					}
																					break;
																					IL_1076:
																					skillClass.setReq(21, 5);
																					if (183421 - 232492 == -49070)
																					{
																						continue;
																					}
																					skillClass.setMP(37);
																					if (19231 - 385053 != -365822)
																					{
																						continue;
																					}
																					goto IL_2A28;
																				}
																				skillClass.setReq(11, 1);
																				if (194581 - 237209 != -42628)
																				{
																					continue;
																				}
																				skillClass.setMP(15);
																				if (244832 - 77525 != 167307)
																				{
																					continue;
																				}
																				IL_12A9:
																				skillClass.setReq(19, 2);
																				if (239086 - 554482 == -315395)
																				{
																					continue;
																				}
																				skillClass.setMP(19);
																				if (99084 - 419151 != -320067)
																				{
																					continue;
																				}
																				IL_1531:
																				skillClass.setReq(27, 3);
																				if (213464 - 305933 == -92468)
																				{
																					continue;
																				}
																				skillClass.setMP(23);
																				if (59979 - 460100 == -400120)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.instant;
																				if (36893 - 208736 == -171842)
																				{
																					continue;
																				}
																				skillClass.target = eSkillTarget.enemy;
																				if (84810 - 327475 != -242665)
																				{
																					continue;
																				}
																				skillClass.cType = "mirageOrb";
																				if (278622 - 218657 != 59965)
																				{
																					continue;
																				}
																				break;
																			}
																			skillClass.setReq(40, 25);
																			if (25606 - 277486 == -251879)
																			{
																				continue;
																			}
																			skillClass.setMPSP(90, -45);
																			if (26319 - 479008 != -452689)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.instant;
																			if (120391 - 515795 != -395404)
																			{
																				continue;
																			}
																			skillClass.target = eSkillTarget.self;
																			if (215263 - 33464 == 181800)
																			{
																				continue;
																			}
																			skillClass.cType = "guardianOfTheNight";
																			if (90492 - 269789 != -179296)
																			{
																				break;
																			}
																			continue;
																		}
																		skillClass.setReq(40, 24);
																		if (128108 - 60684 == 67425)
																		{
																			continue;
																		}
																		skillClass.mode = eSkillMode.passive;
																		if (136762 - 355485 != -218723)
																		{
																			continue;
																		}
																		break;
																	}
																	skillClass.setReq(28, 16);
																	if (129798 - 563911 == -434112)
																	{
																		continue;
																	}
																	skillClass.setMP(40);
																	if (8321 - 297875 == -289553)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.target;
																	if (18527 - 468370 == -449842)
																	{
																		continue;
																	}
																	skillClass.target = eSkillTarget.enemy;
																	if (187782 - 499977 == -312194)
																	{
																		continue;
																	}
																	skillClass.cType = "doom";
																	if (265453 - 409041 != -143588)
																	{
																		continue;
																	}
																	break;
																}
																IL_1F3:
																skillClass.setReq(38, 18);
																if (289443 - 22227 == 267217)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.passive;
																if (58342 - 96856 != -38514)
																{
																	continue;
																}
																break;
																IL_1285:
																skillClass.setReq(31, 14);
																if (2477 - 176990 != -174513)
																{
																	continue;
																}
																goto IL_1F3;
																IL_1BA0:
																skillClass.setReq(24, 10);
																if (79812 - 49759 != 30054)
																{
																	goto IL_1285;
																}
																continue;
															}
															skillClass.setReq(36, 16);
															if (245483 - 208781 != 36702)
															{
																continue;
															}
															skillClass.setMPSP(45, -40);
															if (290464 - 567941 != -277477)
															{
																continue;
															}
															skillClass.mode = eSkillMode.target;
															if (9786 - 59330 == -49543)
															{
																continue;
															}
															skillClass.target = eSkillTarget.enemy;
															if (35597 - 509294 == -473696)
															{
																continue;
															}
															skillClass.cType = "nightmare";
															if (294784 - 543047 != -248262)
															{
																break;
															}
															continue;
														}
														skillClass.setReq(20, 8);
														if (89060 - 285090 == -196029)
														{
															continue;
														}
														skillClass.setMPSP(21, -13);
														if (133754 - 459757 == -326002)
														{
															continue;
														}
														skillClass.mode = eSkillMode.instant;
														if (58730 - 207629 != -148899)
														{
															continue;
														}
														skillClass.target = eSkillTarget.enemy;
														if (289900 - 101891 != 188009)
														{
															continue;
														}
														skillClass.cType = "echoes";
														if (139880 - 328441 != -188561)
														{
															continue;
														}
														break;
													}
													skillClass.setReq(17, 5);
													if (150479 - 233431 == -82951)
													{
														continue;
													}
													skillClass.setMP(11);
													if (195078 - 225290 == -30211)
													{
														continue;
													}
													IL_10BD:
													skillClass.setReq(25, 7);
													if (78663 - 252789 == -174125)
													{
														continue;
													}
													skillClass.setMP(15);
													if (42108 - 233642 == -191533)
													{
														continue;
													}
													IL_1341:
													skillClass.setReq(33, 9);
													if (36782 - 92619 == -55836)
													{
														continue;
													}
													skillClass.setMP(19);
													if (272390 - 554865 != -282475)
													{
														continue;
													}
													skillClass.mode = eSkillMode.target;
													if (48657 - 160795 != -112138)
													{
														continue;
													}
													skillClass.target = eSkillTarget.enemy;
													if (197370 - 400191 == -202820)
													{
														continue;
													}
													skillClass.cType = "curse";
													if (122645 - 376771 != -254125)
													{
														break;
													}
													continue;
												}
												skillClass.setReq(31, 8);
												if (91988 - 87759 != 4229)
												{
													continue;
												}
												skillClass.setMP(23);
												if (443 - 428519 != -428076)
												{
													continue;
												}
												skillClass.mode = eSkillMode.target;
												if (168560 - 319641 == -151080)
												{
													continue;
												}
												skillClass.target = eSkillTarget.enemy;
												if (110009 - 242027 != -132018)
												{
													continue;
												}
												skillClass.cType = "corruption";
												if (296799 - 379134 != -82335)
												{
													continue;
												}
												break;
											}
											skillClass.setReq(23, 6);
											if (195384 - 573714 != -378330)
											{
												continue;
											}
											skillClass.setMP(19);
											if (147958 - 25294 == 122665)
											{
												continue;
											}
											skillClass.mode = eSkillMode.target;
											if (283888 - 366704 != -82816)
											{
												continue;
											}
											skillClass.target = eSkillTarget.enemy;
											if (17178 - 597085 != -579907)
											{
												continue;
											}
											skillClass.cType = "dissolute";
											if (103655 - 41846 != 61809)
											{
												continue;
											}
											break;
										}
										skillClass.setReq(13, 3);
										if (24194 - 95480 == -71285)
										{
											continue;
										}
										skillClass.setMP(15);
										if (123871 - 203307 != -79435)
										{
											goto IL_3470;
										}
										continue;
										IL_1FB9:
										skillClass.setReq(29, 7);
										if (247734 - 180406 != 67328)
										{
											continue;
										}
										skillClass.setMP(23);
										if (195836 - 164436 != 31400)
										{
											continue;
										}
										skillClass.mode = eSkillMode.target;
										if (214988 - 585540 != -370552)
										{
											continue;
										}
										skillClass.target = eSkillTarget.enemy;
										if (203061 - 440965 != -237904)
										{
											continue;
										}
										skillClass.cType = "shadowGaze";
										if (239001 - 211975 != 27026)
										{
											continue;
										}
										break;
										IL_3470:
										skillClass.setReq(21, 5);
										if (266883 - 331740 == -64856)
										{
											continue;
										}
										skillClass.setMP(19);
										if (290126 - 584359 != -294232)
										{
											goto IL_1FB9;
										}
										continue;
									}
									skillClass.setReq(11, 1);
									if (271347 - 256515 == 14833)
									{
										continue;
									}
									skillClass.setMP(13);
									if (41245 - 376029 != -334784)
									{
										continue;
									}
									IL_A4B:
									skillClass.setReq(19, 2);
									if (63568 - 296131 == -232562)
									{
										continue;
									}
									skillClass.setMP(16);
									if (184877 - 218022 != -33145)
									{
										continue;
									}
									IL_2EBA:
									skillClass.setReq(27, 3);
									if (218145 - 339831 == -121685)
									{
										continue;
									}
									skillClass.setMP(19);
									if (139053 - 585410 != -446357)
									{
										continue;
									}
									skillClass.mode = eSkillMode.target;
									if (47004 - 57768 != -10764)
									{
										continue;
									}
									skillClass.target = eSkillTarget.enemy;
									if (150658 - 175879 != -25221)
									{
										continue;
									}
									skillClass.cType = "phantomBane";
									if (134780 - 329182 != -194401)
									{
										break;
									}
									continue;
								}
								skillClass.setReq(20, 6);
								if (115082 - 75036 != 40047)
								{
									goto IL_342B;
								}
								continue;
								IL_2A6C:
								skillClass.setReq(40, 10);
								if (120559 - 91843 == 28717)
								{
									continue;
								}
								skillClass.mode = eSkillMode.passive;
								if (17206 - 257062 == -239855)
								{
									continue;
								}
								skillClass.target = eSkillTarget.self;
								if (21535 - 251197 != -229661)
								{
									break;
								}
								continue;
								IL_342B:
								skillClass.setReq(30, 8);
								if (146859 - 357273 != -210414)
								{
									continue;
								}
								goto IL_2A6C;
							}
							skillClass.setReq(40, 9);
							if (178693 - 30720 != 147973)
							{
								continue;
							}
							skillClass.setMPSP(40, -20);
							if (98951 - 107363 == -8411)
							{
								continue;
							}
							skillClass.mode = eSkillMode.instant;
							if (31641 - 483019 != -451378)
							{
								continue;
							}
							skillClass.target = eSkillTarget.self;
							if (157141 - 366027 != -208886)
							{
								continue;
							}
							skillClass.cType = "massCast";
							if (560 - 132729 != -132169)
							{
								continue;
							}
							break;
						}
						skillClass.setReq(16, 4);
						if (5566 - 113942 == -108375)
						{
							continue;
						}
						IL_1693:
						skillClass.setReq(24, 6);
						if (219366 - 559230 != -339864)
						{
							continue;
						}
						skillClass.mode = eSkillMode.passive;
						if (139490 - 164457 != -24966)
						{
							break;
						}
						continue;
					}
					skillClass.setReq(10, 3);
					if (44665 - 23071 != 21594)
					{
						continue;
					}
					IL_37C2:
					skillClass.setReq(16, 5);
					if (103398 - 384312 == -280913)
					{
						continue;
					}
					skillClass.mode = eSkillMode.passive;
					if (63596 - 417436 != -353840)
					{
						continue;
					}
					skillClass.target = eSkillTarget.enemy;
					if (269386 - 572121 != -302735)
					{
						continue;
					}
					skillClass.cType = "cAttack";
					if (158204 - 226593 != -68389)
					{
						continue;
					}
					break;
				}
				IL_21AD:
				skillClass.setReq(3, 2);
				if (118762 - 427427 != -308665)
				{
					continue;
				}
				skillClass.mode = eSkillMode.passive;
				if (243166 - 251875 != -8709)
				{
					continue;
				}
				skillClass.target = eSkillTarget.enemy;
				if (17770 - 458258 == -440487)
				{
					continue;
				}
				skillClass.cType = "nAttack";
				if (62839 - 275762 != -212922)
				{
					break;
				}
				continue;
				IL_192E:
				skillClass.setReq(2, 1);
				if (161230 - 438909 == -277679)
				{
					goto IL_21AD;
				}
			}
		}
		return skillClass;
	}

	// Token: 0x06001CFA RID: 7418 RVA: 0x00315064 File Offset: 0x00313264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillTree(int commandNum)
	{
		if (34489 - 414919 != -380429)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (143464 - 47111 == 96353)
			{
				if (232723 - 524621 == -291898)
				{
					if (commandNum == 101)
					{
						if (191951 - 517353 != -325401)
						{
							result = "bat_nAttack1";
							if (127922 - 404522 == -276600)
							{
								break;
							}
						}
					}
					else if (commandNum == 102)
					{
						if (83518 - 233196 == -149678)
						{
							result = "bat_nAttack2";
							if (220480 - 518666 != -298185)
							{
								break;
							}
						}
					}
					else if (commandNum == 103)
					{
						if (131805 - 546605 != -414799)
						{
							result = "bat_nAttack3";
							if (885 - 436091 != -435205)
							{
								break;
							}
						}
					}
					else if (commandNum == 111)
					{
						if (207810 - 438909 == -231099)
						{
							result = "bat_cAttack1";
							if (222035 - 402985 == -180950)
							{
								break;
							}
						}
					}
					else if (commandNum == 112)
					{
						if (92284 - 113318 != -21033)
						{
							result = "bat_cAttack2";
							if (189605 - 39777 != 149829)
							{
								break;
							}
						}
					}
					else if (commandNum == 113)
					{
						if (281055 - 37802 == 243253)
						{
							result = "bat_cAttack3";
							if (122680 - 102846 == 19834)
							{
								break;
							}
						}
					}
					else if (commandNum == 121)
					{
						if (228082 - 100268 != 127815)
						{
							result = "bat_drainMana1";
							if (24650 - 520177 != -495526)
							{
								break;
							}
						}
					}
					else if (commandNum == 122)
					{
						if (275982 - 433762 == -157780)
						{
							result = "bat_drainMana2";
							if (252114 - 123424 == 128690)
							{
								break;
							}
						}
					}
					else if (commandNum == 123)
					{
						if (30309 - 497548 != -467238)
						{
							result = "bat_drainMana3";
							if (11411 - 583115 == -571704)
							{
								break;
							}
						}
					}
					else if (commandNum == 131)
					{
						if (11439 - 539176 != -527736)
						{
							result = "bat_massCast1";
							if (88465 - 213697 != -125231)
							{
								break;
							}
						}
					}
					else if (commandNum == 132)
					{
						if (6098 - 383857 == -377759)
						{
							result = "bat_massCast2";
							if (242857 - 249944 == -7087)
							{
								break;
							}
						}
					}
					else if (commandNum == 141)
					{
						if (245698 - 577094 == -331396)
						{
							result = "bat_statPlus1";
							if (288671 - 249979 == 38692)
							{
								break;
							}
						}
					}
					else if (commandNum == 142)
					{
						if (126595 - 112978 != 13618)
						{
							result = "bat_statPlus2";
							if (132205 - 90286 != 41920)
							{
								break;
							}
						}
					}
					else if (commandNum == 143)
					{
						if (68924 - 480174 == -411250)
						{
							result = "bat_statPlus3";
							if (43782 - 363010 == -319228)
							{
								break;
							}
						}
					}
					else if (commandNum == 144)
					{
						if (251887 - 41788 == 210099)
						{
							result = "bat_statPlus4";
							if (69792 - 232599 == -162807)
							{
								break;
							}
						}
					}
					else if (commandNum == 201)
					{
						if (192188 - 553691 == -361503)
						{
							result = "bat_phantomBane1";
							if (56335 - 349364 != -293028)
							{
								break;
							}
						}
					}
					else if (commandNum == 202)
					{
						if (162037 - 110754 == 51283)
						{
							result = "bat_phantomBane2";
							if (233147 - 225385 == 7762)
							{
								break;
							}
						}
					}
					else if (commandNum == 203)
					{
						if (92989 - 52522 != 40468)
						{
							result = "bat_phantomBane3";
							if (31526 - 362489 != -330962)
							{
								break;
							}
						}
					}
					else if (commandNum == 204)
					{
						if (192907 - 320195 == -127288)
						{
							result = "bat_phantomBane4";
							if (110030 - 44547 != 65484)
							{
								break;
							}
						}
					}
					else if (commandNum == 211)
					{
						if (195214 - 507586 != -312371)
						{
							result = "bat_shadowGaze1";
							if (234000 - 473708 == -239708)
							{
								break;
							}
						}
					}
					else if (commandNum == 212)
					{
						if (99817 - 533314 == -433497)
						{
							result = "bat_shadowGaze2";
							if (205581 - 341899 == -136318)
							{
								break;
							}
						}
					}
					else if (commandNum == 213)
					{
						if (12500 - 473849 != -461348)
						{
							result = "bat_shadowGaze3";
							if (67564 - 235730 != -168165)
							{
								break;
							}
						}
					}
					else if (commandNum == 214)
					{
						if (149496 - 289519 == -140023)
						{
							result = "bat_shadowGaze4";
							if (123476 - 360280 == -236804)
							{
								break;
							}
						}
					}
					else if (commandNum == 221)
					{
						if (113022 - 542393 == -429371)
						{
							result = "bat_dissolute1";
							if (6326 - 572863 == -566537)
							{
								break;
							}
						}
					}
					else if (commandNum == 222)
					{
						if (196238 - 342573 != -146334)
						{
							result = "bat_corruption1";
							if (85516 - 172458 != -86941)
							{
								break;
							}
						}
					}
					else if (commandNum == 223)
					{
						if (176028 - 49930 == 126098)
						{
							result = "bat_dissolute2";
							if (262765 - 507215 == -244450)
							{
								break;
							}
						}
					}
					else if (commandNum == 224)
					{
						if (439 - 111354 == -110915)
						{
							result = "bat_corruption2";
							if (97618 - 194051 == -96433)
							{
								break;
							}
						}
					}
					else if (commandNum == 231)
					{
						if (41232 - 60264 != -19031)
						{
							result = "bat_curse1";
							if (49960 - 271357 != -221396)
							{
								break;
							}
						}
					}
					else if (commandNum == 232)
					{
						if (16284 - 95869 == -79585)
						{
							result = "bat_curse2";
							if (45634 - 1834 != 43801)
							{
								break;
							}
						}
					}
					else if (commandNum == 233)
					{
						if (145783 - 493870 != -348086)
						{
							result = "bat_curse3";
							if (52683 - 242315 == -189632)
							{
								break;
							}
						}
					}
					else if (commandNum == 234)
					{
						if (74899 - 421891 != -346991)
						{
							result = "bat_curse4";
							if (185986 - 563114 == -377128)
							{
								break;
							}
						}
					}
					else if (commandNum == 241)
					{
						if (140609 - 159039 != -18429)
						{
							result = "bat_echoes1";
							if (157599 - 49645 == 107954)
							{
								break;
							}
						}
					}
					else if (commandNum == 242)
					{
						if (168062 - 548418 == -380356)
						{
							result = "bat_echoes2";
							if (215616 - 281097 == -65481)
							{
								break;
							}
						}
					}
					else if (commandNum == 243)
					{
						if (169500 - 504736 != -335235)
						{
							result = "bat_nightmare1";
							if (59651 - 305894 == -246243)
							{
								break;
							}
						}
					}
					else if (commandNum == 244)
					{
						if (286899 - 595514 == -308615)
						{
							result = "bat_nightmare2";
							if (8639 - 229968 != -221328)
							{
								break;
							}
						}
					}
					else if (commandNum == 251)
					{
						if (104321 - 387727 != -283405)
						{
							result = "bat_amplifyDamage1";
							if (168658 - 591068 != -422409)
							{
								break;
							}
						}
					}
					else if (commandNum == 252)
					{
						if (169001 - 298385 != -129383)
						{
							result = "bat_amplifyDamage2";
							if (22850 - 123568 != -100717)
							{
								break;
							}
						}
					}
					else if (commandNum == 253)
					{
						if (56883 - 523680 != -466796)
						{
							result = "bat_amplifyDamage3";
							if (273065 - 325138 != -52072)
							{
								break;
							}
						}
					}
					else if (commandNum == 254)
					{
						if (150911 - 280782 != -129870)
						{
							result = "bat_amplifyDamage4";
							if (293727 - 157822 != 135906)
							{
								break;
							}
						}
					}
					else if (commandNum == 261)
					{
						if (282117 - 89907 != 192211)
						{
							result = "bat_doom1";
							if (6830 - 57916 == -51086)
							{
								break;
							}
						}
					}
					else if (commandNum == 262)
					{
						if (106937 - 596316 == -489379)
						{
							result = "bat_doom2";
							if (83257 - 64928 != 18330)
							{
								break;
							}
						}
					}
					else if (commandNum == 263)
					{
						if (15509 - 48695 == -33186)
						{
							result = "bat_shadowMastery1";
							if (93919 - 441637 == -347718)
							{
								break;
							}
						}
					}
					else if (commandNum == 264)
					{
						if (189155 - 508158 == -319003)
						{
							result = "bat_shadowMastery2";
							if (272746 - 12582 != 260165)
							{
								break;
							}
						}
					}
					else if (commandNum == 271)
					{
						if (8420 - 69776 != -61355)
						{
							result = "bat_guardianOfTheNight1";
							if (96441 - 97713 == -1272)
							{
								break;
							}
						}
					}
					else if (commandNum == 272)
					{
						if (227692 - 487389 != -259696)
						{
							result = "bat_guardianOfTheNight2";
							if (27755 - 425074 != -397318)
							{
								break;
							}
						}
					}
					else if (commandNum == 301)
					{
						if (265811 - 333346 == -67535)
						{
							result = "bat_mirageOrb1";
							if (55071 - 205426 == -150355)
							{
								break;
							}
						}
					}
					else if (commandNum == 302)
					{
						if (78807 - 371588 != -292780)
						{
							result = "bat_mirageOrb2";
							if (10559 - 425057 == -414498)
							{
								break;
							}
						}
					}
					else if (commandNum == 303)
					{
						if (169764 - 330366 != -160601)
						{
							result = "bat_mirageOrb3";
							if (61422 - 169783 == -108361)
							{
								break;
							}
						}
					}
					else if (commandNum == 304)
					{
						if (197363 - 492548 != -295184)
						{
							result = "bat_mirageOrb4";
							if (200136 - 202329 != -2192)
							{
								break;
							}
						}
					}
					else if (commandNum == 311)
					{
						if (191625 - 180248 == 11377)
						{
							result = "bat_shadowIllusion1";
							if (209587 - 133873 == 75714)
							{
								break;
							}
						}
					}
					else if (commandNum == 312)
					{
						if (221325 - 466940 != -245614)
						{
							result = "bat_shadowIllusion2";
							if (132410 - 90073 != 42338)
							{
								break;
							}
						}
					}
					else if (commandNum == 313)
					{
						if (288709 - 251525 != 37185)
						{
							result = "bat_shadowIllusion3";
							if (46205 - 145117 != -98911)
							{
								break;
							}
						}
					}
					else if (commandNum == 314)
					{
						if (182542 - 489197 == -306655)
						{
							result = "bat_shadowIllusion4";
							if (142805 - 463515 == -320710)
							{
								break;
							}
						}
					}
					else if (commandNum == 321)
					{
						if (57692 - 399118 == -341426)
						{
							result = "bat_blind1";
							if (77262 - 396457 != -319194)
							{
								break;
							}
						}
					}
					else if (commandNum == 322)
					{
						if (12852 - 138426 != -125573)
						{
							result = "bat_blind2";
							if (97433 - 538222 == -440789)
							{
								break;
							}
						}
					}
					else if (commandNum == 323)
					{
						if (38208 - 204756 == -166548)
						{
							result = "bat_confusion1";
							if (3639 - 575175 == -571536)
							{
								break;
							}
						}
					}
					else if (commandNum == 324)
					{
						if (204762 - 272966 != -68203)
						{
							result = "bat_confusion2";
							if (255304 - 407920 == -152616)
							{
								break;
							}
						}
					}
					else if (commandNum == 331)
					{
						if (21247 - 98499 != -77251)
						{
							result = "bat_hateTransfer1";
							if (141998 - 239348 == -97350)
							{
								break;
							}
						}
					}
					else if (commandNum == 332)
					{
						if (102824 - 184739 != -81914)
						{
							result = "bat_hateTransfer2";
							if (222451 - 60864 == 161587)
							{
								break;
							}
						}
					}
					else if (commandNum == 333)
					{
						if (203141 - 322199 == -119058)
						{
							result = "bat_switch1";
							if (298115 - 364138 != -66022)
							{
								break;
							}
						}
					}
					else if (commandNum == 334)
					{
						if (17079 - 492094 == -475015)
						{
							result = "bat_swap1";
							if (192699 - 118204 == 74495)
							{
								break;
							}
						}
					}
					else if (commandNum == 341)
					{
						if (23281 - 469836 != -446554)
						{
							result = "bat_dreamDazzle1";
							if (14406 - 561268 == -546862)
							{
								break;
							}
						}
					}
					else if (commandNum == 342)
					{
						if (298872 - 399372 == -100500)
						{
							result = "bat_dreamDazzle2";
							if (65114 - 313828 == -248714)
							{
								break;
							}
						}
					}
					else if (commandNum == 343)
					{
						if (220994 - 19155 != 201840)
						{
							result = "bat_phantasmBlast1";
							if (236247 - 494477 == -258230)
							{
								break;
							}
						}
					}
					else if (commandNum == 344)
					{
						if (269096 - 534612 == -265516)
						{
							result = "bat_phantasmBlast2";
							if (285017 - 41618 == 243399)
							{
								break;
							}
						}
					}
					else if (commandNum == 351)
					{
						if (273993 - 405735 != -131741)
						{
							result = "bat_charm1";
							if (218318 - 84511 == 133807)
							{
								break;
							}
						}
					}
					else if (commandNum == 352)
					{
						if (214576 - 259075 != -44498)
						{
							result = "bat_charm2";
							if (280807 - 335804 != -54996)
							{
								break;
							}
						}
					}
					else if (commandNum == 353)
					{
						if (35439 - 23903 == 11536)
						{
							result = "bat_mindControl1";
							if (128002 - 369093 == -241091)
							{
								break;
							}
						}
					}
					else if (commandNum == 354)
					{
						if (259540 - 236666 != 22875)
						{
							result = "bat_mindControl2";
							if (297940 - 560165 != -262224)
							{
								break;
							}
						}
					}
					else if (commandNum == 361)
					{
						if (23743 - 61337 != -37593)
						{
							result = "bat_dreamBurst1";
							if (120171 - 235191 == -115020)
							{
								break;
							}
						}
					}
					else if (commandNum == 362)
					{
						if (208574 - 320815 != -112240)
						{
							result = "bat_dreamBurst2";
							if (172925 - 592264 != -419338)
							{
								break;
							}
						}
					}
					else if (commandNum == 363)
					{
						if (35796 - 29658 != 6139)
						{
							result = "bat_dreamBurst3";
							if (90326 - 31802 != 58525)
							{
								break;
							}
						}
					}
					else if (commandNum == 371)
					{
						if (175234 - 282721 != -107486)
						{
							result = "bat_mimic1";
							if (261396 - 36740 == 224656)
							{
								break;
							}
						}
					}
					else if (commandNum == 372)
					{
						if (162607 - 82361 != 80247)
						{
							result = "bat_mimic2";
							if (134179 - 544896 != -410716)
							{
								break;
							}
						}
					}
					else if (commandNum == 373)
					{
						if (94560 - 518785 == -424225)
						{
							result = "bat_allMimic1";
							if (294208 - 81891 == 212317)
							{
								break;
							}
						}
					}
					else if (commandNum == 401)
					{
						if (1012 - 336549 != -335536)
						{
							result = "bat_illusionEffect5";
							if (92296 - 389114 != -296817)
							{
								break;
							}
						}
					}
					else if (commandNum == 411)
					{
						if (133305 - 99386 == 33919)
						{
							result = "bat_darkIntention5";
							if (179511 - 558710 == -379199)
							{
								break;
							}
						}
					}
					else if (commandNum == 421)
					{
						if (167097 - 228772 == -61675)
						{
							result = "bat_mercilessDrain5";
							if (61678 - 29644 == 32034)
							{
								break;
							}
						}
					}
					else if (commandNum == 431)
					{
						if (265237 - 507287 == -242050)
						{
							result = "bat_autoMass5";
							if (160467 - 512564 == -352097)
							{
								break;
							}
						}
					}
					else if (commandNum == 441)
					{
						if (186724 - 234196 == -47472)
						{
							result = "bat_superStatPlus5";
							if (100597 - 296711 != -196113)
							{
								break;
							}
						}
					}
					else if (commandNum == 402)
					{
						if (155216 - 257938 != -102721)
						{
							result = "bat_demonBane5";
							if (161854 - 344735 == -182881)
							{
								break;
							}
						}
					}
					else if (commandNum == 412)
					{
						if (18899 - 281102 == -262203)
						{
							result = "bat_demonGaze5";
							if (106592 - 185675 != -79082)
							{
								break;
							}
						}
					}
					else if (commandNum == 422)
					{
						if (245305 - 90043 != 155263)
						{
							result = "bat_shame5";
							if (237360 - 312671 == -75311)
							{
								break;
							}
						}
					}
					else if (commandNum == 432)
					{
						if (129644 - 463559 == -333915)
						{
							result = "bat_darkStalker5";
							if (8055 - 229925 != -221869)
							{
								break;
							}
						}
					}
					else if (commandNum == 442)
					{
						if (225730 - 135357 == 90373)
						{
							result = "bat_soulEater5";
							if (120707 - 218672 == -97965)
							{
								break;
							}
						}
					}
					else if (commandNum == 403)
					{
						if (103141 - 134177 != -31035)
						{
							result = "bat_distantOrb5";
							if (214192 - 569779 != -355586)
							{
								break;
							}
						}
					}
					else if (commandNum == 413)
					{
						if (64686 - 433329 != -368642)
						{
							result = "bat_shadowSacrifice5";
							if (82126 - 540548 == -458422)
							{
								break;
							}
						}
					}
					else if (commandNum == 423)
					{
						if (151606 - 227853 != -76246)
						{
							result = "bat_chiroptophobia5";
							if (121581 - 74985 == 46596)
							{
								break;
							}
						}
					}
					else if (commandNum == 433)
					{
						if (13032 - 346244 == -333212)
						{
							result = "bat_paranoia5";
							if (233165 - 138989 != 94177)
							{
								break;
							}
						}
					}
					else if (commandNum == 443)
					{
						if (133909 - 24884 != 109026)
						{
							result = "bat_shatteringDream5";
							if (58328 - 249571 != -191242)
							{
								break;
							}
						}
					}
					else if (commandNum == 404)
					{
						if (60593 - 119647 == -59054)
						{
							result = "bat_revisedSkill5";
							if (49426 - 448615 == -399189)
							{
								break;
							}
						}
					}
					else if (commandNum == 414)
					{
						if (249045 - 349732 == -100687)
						{
							result = "bat_revisedMagic5";
							if (53010 - 523024 != -470013)
							{
								break;
							}
						}
					}
					else if (commandNum == 424)
					{
						if (83931 - 322238 == -238307)
						{
							result = "bat_revisedArt5";
							if (163157 - 123035 != 40123)
							{
								break;
							}
						}
					}
					else if (commandNum == 434)
					{
						if (13685 - 192232 != -178546)
						{
							result = "bat_nefariousWhip5";
							if (89376 - 101490 == -12114)
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
						if (224327 - 502510 != -278182)
						{
							result = "bat_blackServant5";
							if (25637 - 458521 == -432884)
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

	// Token: 0x06001CFB RID: 7419 RVA: 0x00316C34 File Offset: 0x00314E34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001CFC RID: 7420 RVA: 0x00316C38 File Offset: 0x00314E38
	internal static bool C9fonUJRNv2XlZuNfPJ()
	{
		return true;
	}

	// Token: 0x06001CFD RID: 7421 RVA: 0x00316C3C File Offset: 0x00314E3C
	internal static bool eUGsefJwHxHDDHmAOZZ()
	{
		return false;
	}
}
