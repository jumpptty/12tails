using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200085C RID: 2140
[Serializable]
public class PenguinSkill : MonoBehaviour
{
	// Token: 0x06002F33 RID: 12083 RVA: 0x005E6900 File Offset: 0x005E4B00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PenguinSkill()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002F34 RID: 12084 RVA: 0x005E6910 File Offset: 0x005E4B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSkill(string skillname)
	{
		if (291865 - 557993 != -266127)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (199389 - 84771 == 114618)
			{
				if (4506 - 305322 != -300815)
				{
					if (231383 - 9817 == 221566)
					{
						if (skillname == "pgn_nAttack1")
						{
							if (25090 - 158275 != -133185)
							{
								continue;
							}
							skillClass.setReq(1, 0);
							if (239650 - 338835 != -99185)
							{
								continue;
							}
						}
						else if (skillname == "pgn_nAttack2")
						{
							if (197833 - 241443 != -43610)
							{
								continue;
							}
						}
						else
						{
							if (skillname == "pgn_cAttack1")
							{
								if (5887 - 587850 == -581962)
								{
									continue;
								}
								skillClass.setReq(4, 1);
								if (2720 - 129016 != -126295)
								{
									goto IL_280E;
								}
								continue;
							}
							else if (skillname == "pgn_cAttack2")
							{
								if (224795 - 108546 != 116250)
								{
									goto IL_280E;
								}
								continue;
							}
							else if (skillname == "pgn_cAttack3")
							{
								if (91187 - 432811 != -341624)
								{
									continue;
								}
							}
							else if (skillname == "pgn_cAttack4")
							{
								if (82623 - 253987 != -171364)
								{
									continue;
								}
								goto IL_34BA;
							}
							else
							{
								if (skillname == "pgn_Intellect1")
								{
									if (231631 - 113903 != 117728)
									{
										continue;
									}
									skillClass.setReq(8, 2);
									if (118422 - 535013 != -416590)
									{
										goto IL_3711;
									}
									continue;
								}
								else if (skillname == "pgn_Intellect2")
								{
									if (290820 - 564605 != -273784)
									{
										goto IL_3711;
									}
									continue;
								}
								else if (skillname == "pgn_Intellect3")
								{
									if (248114 - 113431 != 134683)
									{
										continue;
									}
									goto IL_9E0;
								}
								else if (skillname == "pgn_Intellect4")
								{
									if (263104 - 195324 != 67780)
									{
										continue;
									}
								}
								else if (skillname == "pgn_doubleCast1")
								{
									if (15897 - 424403 != -408506)
									{
										continue;
									}
									skillClass.setReq(32, 6);
									if (95965 - 514487 == -418521)
									{
										continue;
									}
									skillClass.setMPSP(20, -20);
									if (171382 - 519757 != -348375)
									{
										continue;
									}
									skillClass.mode = eSkillMode.instant;
									if (287327 - 374765 == -87437)
									{
										continue;
									}
									skillClass.target = eSkillTarget.self;
									if (14158 - 311035 == -296876)
									{
										continue;
									}
									skillClass.cType = "doubleCast";
									if (47830 - 328870 != -281039)
									{
										break;
									}
									continue;
								}
								else if (skillname == "pgn_tripleCast2")
								{
									if (252351 - 284068 != -31717)
									{
										continue;
									}
									skillClass.setReq(40, 10);
									if (85515 - 93187 == -7671)
									{
										continue;
									}
									skillClass.setMPSP(40, -30);
									if (268746 - 237786 != 30960)
									{
										continue;
									}
									skillClass.mode = eSkillMode.instant;
									if (257652 - 365817 == -108164)
									{
										continue;
									}
									skillClass.target = eSkillTarget.self;
									if (227552 - 563566 == -336013)
									{
										continue;
									}
									skillClass.cType = "tripleCast";
									if (223374 - 41019 != 182355)
									{
										continue;
									}
									break;
								}
								else
								{
									if (skillname == "pgn_statPlus1")
									{
										if (67070 - 227908 == -160837)
										{
											continue;
										}
										skillClass.setReq(10, 4);
										if (296459 - 65348 != 231112)
										{
											goto IL_115F;
										}
										continue;
									}
									else if (skillname == "pgn_statPlus2")
									{
										if (18270 - 90259 != -71989)
										{
											continue;
										}
										goto IL_115F;
									}
									else if (skillname == "pgn_statPlus3")
									{
										if (226757 - 517027 != -290270)
										{
											continue;
										}
										goto IL_181E;
									}
									else if (skillname == "pgn_statPlus4")
									{
										if (123064 - 270502 != -147438)
										{
											continue;
										}
									}
									else
									{
										if (skillname == "pgn_manaMissile1")
										{
											if (207598 - 374129 == -166530)
											{
												continue;
											}
											skillClass.setReq(3, 0);
											if (150235 - 10133 != 140102)
											{
												continue;
											}
											skillClass.setMP(9);
											if (175803 - 329443 != -153640)
											{
												continue;
											}
										}
										else if (skillname == "pgn_manaMissile2")
										{
											if (228447 - 270586 == -42138)
											{
												continue;
											}
										}
										else if (skillname == "pgn_manaMissile3")
										{
											if (255183 - 563718 != -308535)
											{
												continue;
											}
											goto IL_D05;
										}
										else if (skillname == "pgn_manaMissile4")
										{
											if (285129 - 505152 != -220023)
											{
												continue;
											}
											goto IL_30D;
										}
										else
										{
											if (skillname == "pgn_manaArc1")
											{
												if (289739 - 442895 != -153156)
												{
													continue;
												}
												skillClass.setReq(5, 1);
												if (126264 - 244161 == -117896)
												{
													continue;
												}
												skillClass.setMPSP(6, -4);
												if (178030 - 25705 != 152326)
												{
													goto IL_8BA;
												}
												continue;
											}
											else if (skillname == "pgn_manaArc2")
											{
												if (45645 - 551538 != -505892)
												{
													goto IL_8BA;
												}
												continue;
											}
											else if (skillname == "pgn_manaArc3")
											{
												if (41642 - 509701 != -468059)
												{
													continue;
												}
												goto IL_1935;
											}
											else if (skillname == "pgn_manaArc4")
											{
												if (208974 - 440541 == -231566)
												{
													continue;
												}
											}
											else
											{
												if (skillname == "pgn_dispell1")
												{
													if (73863 - 74587 != -724)
													{
														continue;
													}
													skillClass.setReq(7, 2);
													if (6234 - 14959 != -8725)
													{
														continue;
													}
													skillClass.setMP(14);
													if (88451 - 454443 != -365992)
													{
														continue;
													}
												}
												else if (skillname == "pgn_dispell2")
												{
													if (117128 - 586644 != -469516)
													{
														continue;
													}
												}
												else
												{
													if (skillname == "pgn_blink1")
													{
														if (287327 - 565517 == -278189)
														{
															continue;
														}
														skillClass.setReq(15, 4);
														if (99255 - 516593 == -417337)
														{
															continue;
														}
														skillClass.setMPSP(5, -10);
														if (19682 - 489716 == -470033)
														{
															continue;
														}
													}
													else if (skillname == "pgn_blink2")
													{
														if (81493 - 21883 == 59611)
														{
															continue;
														}
													}
													else
													{
														if (skillname == "pgn_mpTransfer1")
														{
															if (72007 - 244111 != -172104)
															{
																continue;
															}
															skillClass.setReq(9, 3);
															if (52371 - 304199 != -251828)
															{
																continue;
															}
															skillClass.setMP(30);
															if (112609 - 472110 != -359501)
															{
																continue;
															}
														}
														else if (skillname == "pgn_mpTransfer2")
														{
															if (32040 - 460613 == -428572)
															{
																continue;
															}
														}
														else
														{
															if (skillname == "pgn_manaBurn1")
															{
																if (94571 - 548143 == -453571)
																{
																	continue;
																}
																skillClass.setReq(17, 5);
																if (30484 - 490622 != -460138)
																{
																	continue;
																}
																skillClass.setMP(15);
																if (179517 - 359868 != -180351)
																{
																	continue;
																}
															}
															else if (skillname == "pgn_manaBurn2")
															{
																if (226995 - 512723 != -285728)
																{
																	continue;
																}
															}
															else
															{
																if (skillname == "pgn_fallingStars1")
																{
																	if (196511 - 176234 == 20278)
																	{
																		continue;
																	}
																	skillClass.setReq(12, 4);
																	if (67150 - 62565 == 4586)
																	{
																		continue;
																	}
																	skillClass.setMPSP(20, -10);
																	if (241175 - 373487 != -132312)
																	{
																		continue;
																	}
																}
																else if (skillname == "pgn_fallingStars2")
																{
																	if (297030 - 216099 == 80932)
																	{
																		continue;
																	}
																}
																else
																{
																	if (skillname == "pgn_fallingComets1")
																	{
																		if (5377 - 574093 != -568716)
																		{
																			continue;
																		}
																		skillClass.setReq(28, 12);
																		if (124888 - 509815 == -384926)
																		{
																			continue;
																		}
																		skillClass.setMP(35);
																		if (129070 - 351408 != -222338)
																		{
																			continue;
																		}
																	}
																	else if (skillname == "pgn_fallingComets2")
																	{
																		if (132352 - 436 == 131917)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (skillname == "pgn_manaVortex1")
																		{
																			if (66883 - 512190 != -445307)
																			{
																				continue;
																			}
																			skillClass.setReq(17, 6);
																			if (286176 - 213447 != 72729)
																			{
																				continue;
																			}
																			skillClass.setMP(40);
																			if (104178 - 31246 != 72932)
																			{
																				continue;
																			}
																		}
																		else if (skillname == "pgn_manaVortex2")
																		{
																			if (83097 - 111699 != -28602)
																			{
																				continue;
																			}
																		}
																		else if (skillname == "pgn_manaVortex3")
																		{
																			if (294892 - 499884 != -204991)
																			{
																				goto IL_1C68;
																			}
																			continue;
																		}
																		else if (skillname == "pgn_novaFlare1")
																		{
																			if (143664 - 322854 != -179190)
																			{
																				continue;
																			}
																			skillClass.setReq(38, 18);
																			if (55741 - 550376 != -494635)
																			{
																				continue;
																			}
																			skillClass.setSP(-30);
																			if (86476 - 559914 == -473437)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.instant;
																			if (233302 - 501706 != -268404)
																			{
																				continue;
																			}
																			skillClass.target = eSkillTarget.enemy;
																			if (133667 - 59773 == 73895)
																			{
																				continue;
																			}
																			skillClass.cType = "novaFlare";
																			if (51140 - 510676 != -459536)
																			{
																				continue;
																			}
																			break;
																		}
																		else
																		{
																			if (skillname == "pgn_astralTalent1")
																			{
																				if (246924 - 535641 != -288717)
																				{
																					continue;
																				}
																				skillClass.setReq(22, 12);
																				if (57612 - 183703 != -126090)
																				{
																					goto IL_3150;
																				}
																				continue;
																			}
																			else if (skillname == "pgn_astralTalent2")
																			{
																				if (78266 - 148454 != -70188)
																				{
																					continue;
																				}
																				goto IL_3150;
																			}
																			else if (skillname == "pgn_astralTalent3")
																			{
																				if (262448 - 11588 != 250861)
																				{
																					goto IL_2F1D;
																				}
																				continue;
																			}
																			else if (skillname == "pgn_astralTalent4")
																			{
																				if (174624 - 546201 == -371576)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				if (skillname == "pgn_meteora1")
																				{
																					if (91988 - 296494 == -204505)
																					{
																						continue;
																					}
																					skillClass.setReq(35, 23);
																					if (244857 - 240912 != 3945)
																					{
																						continue;
																					}
																					skillClass.setMPSP(120, -35);
																					if (275691 - 424304 == -148612)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "pgn_meteora2")
																				{
																					if (23844 - 566271 != -542427)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					if (skillname == "pgn_frozenBlast1")
																					{
																						if (157853 - 500089 != -342236)
																						{
																							continue;
																						}
																						skillClass.setReq(3, 0);
																						if (168796 - 324393 != -155597)
																						{
																							continue;
																						}
																						skillClass.setMP(12);
																						if (263409 - 79022 != 184387)
																						{
																							continue;
																						}
																						goto IL_2577;
																					}
																					else if (skillname == "pgn_frozenBlast2")
																					{
																						if (108456 - 320210 != -211754)
																						{
																							continue;
																						}
																						goto IL_2577;
																					}
																					else if (skillname == "pgn_frozenBlast3")
																					{
																						if (219519 - 354574 != -135055)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "pgn_frozenBlast4")
																					{
																						if (208487 - 205141 != 3347)
																						{
																							goto IL_1E84;
																						}
																						continue;
																					}
																					else
																					{
																						if (skillname == "pgn_arcticWind1")
																						{
																							if (288011 - 102608 == 185404)
																							{
																								continue;
																							}
																							skillClass.setReq(5, 1);
																							if (153491 - 224959 == -71467)
																							{
																								continue;
																							}
																							skillClass.setMP(20);
																							if (206338 - 536800 != -330461)
																							{
																								goto IL_B61;
																							}
																							continue;
																						}
																						else if (skillname == "pgn_arcticWind2")
																						{
																							if (164832 - 390552 != -225719)
																							{
																								goto IL_B61;
																							}
																							continue;
																						}
																						else if (skillname == "pgn_arcticWind3")
																						{
																							if (185895 - 356419 == -170523)
																							{
																								continue;
																							}
																						}
																						else if (skillname == "pgn_arcticFrost1")
																						{
																							if (211827 - 426446 != -214619)
																							{
																								continue;
																							}
																							skillClass.setReq(29, 7);
																							if (28122 - 415977 == -387854)
																							{
																								continue;
																							}
																							skillClass.mode = eSkillMode.passive;
																							if (155530 - 259443 != -103913)
																							{
																								continue;
																							}
																							break;
																						}
																						else
																						{
																							if (skillname == "pgn_iceShield1")
																							{
																								if (113717 - 88099 == 25619)
																								{
																									continue;
																								}
																								skillClass.setReq(7, 2);
																								if (135327 - 220304 != -84977)
																								{
																									continue;
																								}
																								skillClass.setMP(15);
																								if (132529 - 500977 != -368448)
																								{
																									continue;
																								}
																								goto IL_173D;
																							}
																							else if (skillname == "pgn_iceShield2")
																							{
																								if (260256 - 49324 != 210933)
																								{
																									goto IL_173D;
																								}
																								continue;
																							}
																							else if (skillname == "pgn_iceShield3")
																							{
																								if (127379 - 198052 != -70673)
																								{
																									continue;
																								}
																							}
																							else if (skillname == "pgn_iceShield4")
																							{
																								if (116210 - 107143 != 9067)
																								{
																									continue;
																								}
																								goto IL_120C;
																							}
																							else
																							{
																								if (skillname == "pgn_iceBlock1")
																								{
																									if (32635 - 411974 != -379339)
																									{
																										continue;
																									}
																									skillClass.setReq(9, 3);
																									if (184777 - 181901 == 2877)
																									{
																										continue;
																									}
																									skillClass.setMP(10);
																									if (80400 - 413929 != -333529)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "pgn_iceBlock2")
																								{
																									if (219491 - 76173 == 143319)
																									{
																										continue;
																									}
																								}
																								else
																								{
																									if (skillname == "pgn_snowMan1")
																									{
																										if (173651 - 480099 == -306447)
																										{
																											continue;
																										}
																										skillClass.setReq(17, 5);
																										if (237205 - 100833 == 136373)
																										{
																											continue;
																										}
																										skillClass.setMP(20);
																										if (13732 - 343333 == -329600)
																										{
																											continue;
																										}
																									}
																									else if (skillname == "pgn_snowMan2")
																									{
																										if (208072 - 9450 != 198622)
																										{
																											continue;
																										}
																									}
																									else
																									{
																										if (skillname == "pgn_tornado1")
																										{
																											if (192264 - 573785 == -381520)
																											{
																												continue;
																											}
																											skillClass.setReq(12, 4);
																											if (62740 - 56111 != 6629)
																											{
																												continue;
																											}
																											skillClass.setMP(36);
																											if (106888 - 78906 != 27983)
																											{
																												goto IL_2786;
																											}
																											continue;
																										}
																										else if (skillname == "pgn_tornado2")
																										{
																											if (209037 - 209079 != -42)
																											{
																												continue;
																											}
																											goto IL_2786;
																										}
																										else if (skillname == "pgn_tornado3")
																										{
																											if (43577 - 263661 == -220083)
																											{
																												continue;
																											}
																										}
																										else if (skillname == "pgn_typhoon1")
																										{
																											if (89588 - 573780 == -484191)
																											{
																												continue;
																											}
																											skillClass.setReq(36, 16);
																											if (111517 - 309644 != -198127)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.passive;
																											if (611 - 50959 != -50348)
																											{
																												continue;
																											}
																											break;
																										}
																										else
																										{
																											if (skillname == "pgn_frostBite1")
																											{
																												if (100540 - 281564 == -181023)
																												{
																													continue;
																												}
																												skillClass.setReq(17, 6);
																												if (106457 - 200671 != -94214)
																												{
																													continue;
																												}
																												goto IL_1ADF;
																											}
																											else if (skillname == "pgn_frostBite2")
																											{
																												if (220881 - 206780 != 14102)
																												{
																													goto IL_1ADF;
																												}
																												continue;
																											}
																											else if (skillname == "pgn_frostBite3")
																											{
																												if (79926 - 208601 == -128674)
																												{
																													continue;
																												}
																											}
																											else if (skillname == "pgn_frostBite4")
																											{
																												if (140080 - 109047 != 31034)
																												{
																													goto IL_FC4;
																												}
																												continue;
																											}
																											else
																											{
																												if (skillname == "pgn_absoluteZero1")
																												{
																													if (2764 - 516020 == -513255)
																													{
																														continue;
																													}
																													skillClass.setReq(22, 12);
																													if (222135 - 229523 != -7388)
																													{
																														continue;
																													}
																													skillClass.setMPSP(35, 30);
																													if (167027 - 151349 != 15678)
																													{
																														continue;
																													}
																												}
																												else if (skillname == "pgn_absoluteZero2")
																												{
																													if (266557 - 187562 == 78996)
																													{
																														continue;
																													}
																												}
																												else
																												{
																													if (skillname == "pgn_blizzard1")
																													{
																														if (40263 - 343223 == -302959)
																														{
																															continue;
																														}
																														skillClass.setReq(34, 20);
																														if (95019 - 408055 != -313036)
																														{
																															continue;
																														}
																														skillClass.setMP(65);
																														if (17539 - 578794 != -561255)
																														{
																															continue;
																														}
																													}
																													else if (skillname == "pgn_blizzard2")
																													{
																														if (198585 - 67472 != 131113)
																														{
																															continue;
																														}
																													}
																													else
																													{
																														if (skillname == "pgn_arcticEmperor1")
																														{
																															if (248788 - 498542 == -249753)
																															{
																																continue;
																															}
																															skillClass.setReq(35, 23);
																															if (84922 - 585318 == -500395)
																															{
																																continue;
																															}
																															skillClass.setMPSP(60, -25);
																															if (23194 - 541452 != -518258)
																															{
																																continue;
																															}
																														}
																														else if (skillname == "pgn_arcticEmperor2")
																														{
																															if (165115 - 470973 != -305858)
																															{
																																continue;
																															}
																														}
																														else if (skillname == "pgn_spreadShot5")
																														{
																															if (198142 - 136006 != 62136)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (36380 - 41941 != -5561)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (59156 - 263590 == -204433)
																															{
																																continue;
																															}
																															skillClass.rSkill = 102;
																															if (104092 - 443932 != -339839)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "pgn_manaField5")
																														{
																															if (5540 - 466585 == -461044)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (227486 - 51028 == 176459)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (268707 - 521775 == -253067)
																															{
																																continue;
																															}
																															skillClass.rSkill = 114;
																															if (144470 - 596890 != -452420)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "pgn_focusIntellect5")
																														{
																															if (21036 - 197395 != -176359)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (8052 - 325266 != -317214)
																															{
																																continue;
																															}
																															skillClass.setMPSP(30, -75);
																															if (191436 - 216652 == -25215)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.instant;
																															if (169746 - 496626 != -326880)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.self;
																															if (239477 - 344180 == -104702)
																															{
																																continue;
																															}
																															skillClass.cType = "focusIntellect";
																															if (293065 - 531714 == -238648)
																															{
																																continue;
																															}
																															skillClass.rSkill = 124;
																															if (206845 - 531219 != -324374)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "pgn_doubleSpell5")
																														{
																															if (272914 - 169296 != 103618)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (24369 - 537496 != -513127)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (92540 - 16393 == 76148)
																															{
																																continue;
																															}
																															skillClass.rSkill = 132;
																															if (40476 - 488275 != -447798)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "pgn_superStatPlus5")
																														{
																															if (142466 - 25972 == 116495)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (149584 - 353055 == -203470)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (208397 - 541374 == -332976)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.self;
																															if (30605 - 8821 == 21785)
																															{
																																continue;
																															}
																															skillClass.rSkill = 144;
																															if (180991 - 259043 != -78051)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "pgn_moreMissile5")
																														{
																															if (189770 - 395756 == -205985)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (111366 - 303606 != -192240)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (14980 - 38193 != -23213)
																															{
																																continue;
																															}
																															skillClass.rSkill = 204;
																															if (293680 - 419163 != -125483)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "pgn_penguinOfArc5")
																														{
																															if (143256 - 218185 != -74929)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (69859 - 426578 == -356718)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (128803 - 449377 == -320573)
																															{
																																continue;
																															}
																															skillClass.rSkill = 214;
																															if (74534 - 70971 != 3564)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "pgn_parallelShift5")
																														{
																															if (32985 - 565864 == -532878)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (36658 - 111542 != -74884)
																															{
																																continue;
																															}
																															skillClass.setMPSP(10, -20);
																															if (187099 - 451053 != -263954)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.instant;
																															if (193244 - 299099 == -105854)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.self;
																															if (182139 - 19215 == 162925)
																															{
																																continue;
																															}
																															skillClass.cType = "blink";
																															if (169914 - 231875 != -61961)
																															{
																																continue;
																															}
																															skillClass.rSkill = 224;
																															if (168064 - 553347 != -385283)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "pgn_manaSurge5")
																														{
																															if (273334 - 129763 != 143571)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (193321 - 438756 == -245434)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (240718 - 500283 == -259564)
																															{
																																continue;
																															}
																															skillClass.rSkill = 234;
																															if (172032 - 40702 != 131330)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "pgn_giantStar5")
																														{
																															if (294252 - 34745 == 259508)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (114330 - 210905 != -96575)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (264043 - 599648 != -335605)
																															{
																																continue;
																															}
																															skillClass.rSkill = 244;
																															if (6941 - 254674 != -247732)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "pgn_frozenBreak5")
																														{
																															if (91381 - 98841 == -7459)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (276572 - 274912 == 1661)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (79558 - 449957 == -370398)
																															{
																																continue;
																															}
																															skillClass.rSkill = 304;
																															if (31598 - 167681 != -136083)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "pgn_deadlyFrost5")
																														{
																															if (114997 - 481941 == -366943)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (62373 - 212489 != -150116)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (232630 - 149954 != 82676)
																															{
																																continue;
																															}
																															skillClass.rSkill = 314;
																															if (33203 - 480404 != -447200)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "pgn_frostSpike5")
																														{
																															if (14479 - 438745 == -424265)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (205364 - 287601 != -82237)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (186116 - 460691 == -274574)
																															{
																																continue;
																															}
																															skillClass.rSkill = 324;
																															if (238705 - 510481 != -271775)
																															{
																																break;
																															}
																															continue;
																														}
																														else if (skillname == "pgn_snowBall5")
																														{
																															if (78046 - 18380 == 59667)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (158006 - 22175 != 135831)
																															{
																																continue;
																															}
																															skillClass.setMP(30);
																															if (248992 - 589842 != -340850)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.target;
																															if (226920 - 520426 == -293505)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.enemy;
																															if (158503 - 219145 == -60641)
																															{
																																continue;
																															}
																															skillClass.cType = "snowBall";
																															if (147906 - 576410 != -428504)
																															{
																																continue;
																															}
																															skillClass.rSkill = 334;
																															if (49616 - 525030 != -475414)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "pgn_iceTwister5")
																														{
																															if (257839 - 151366 == 106474)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (5199 - 577702 != -572503)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (168657 - 575285 == -406627)
																															{
																																continue;
																															}
																															skillClass.rSkill = 344;
																															if (182531 - 169324 != 13207)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "pgn_revisedSkill5")
																														{
																															if (27132 - 358462 == -331329)
																															{
																																continue;
																															}
																															skillClass.setReq(55, 0);
																															if (256610 - 572780 == -316169)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (287354 - 538836 != -251482)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "pgn_revisedMagic5")
																														{
																															if (22037 - 175164 == -153126)
																															{
																																continue;
																															}
																															skillClass.setReq(60, 1);
																															if (143712 - 60225 != 83487)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (93631 - 90428 != 3203)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "pgn_revisedArt5")
																														{
																															if (142104 - 15097 != 127007)
																															{
																																continue;
																															}
																															skillClass.setReq(70, 3);
																															if (55828 - 185736 != -129908)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.passive;
																															if (134565 - 158653 != -24088)
																															{
																																continue;
																															}
																															break;
																														}
																														else if (skillname == "pgn_cosmicRift5")
																														{
																															if (11688 - 508603 != -496915)
																															{
																																continue;
																															}
																															skillClass.setReq(75, 4);
																															if (102967 - 350122 == -247154)
																															{
																																continue;
																															}
																															skillClass.setMPSP(50, -50);
																															if (12130 - 414895 == -402764)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.instant;
																															if (144256 - 447644 == -303387)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.self;
																															if (142630 - 475549 == -332918)
																															{
																																continue;
																															}
																															skillClass.cType = "cosmicRift";
																															if (48923 - 527680 != -478757)
																															{
																																continue;
																															}
																															skillClass.rSkill = 261361;
																															if (146821 - 409172 != -262350)
																															{
																																break;
																															}
																															continue;
																														}
																														else
																														{
																															if (!(skillname == "pgn_cosmicFriday5"))
																															{
																																break;
																															}
																															if (73748 - 35496 == 38253)
																															{
																																continue;
																															}
																															skillClass.setReq(85, 6);
																															if (157129 - 480837 == -323707)
																															{
																																continue;
																															}
																															skillClass.setMPSP(100, -50);
																															if (14517 - 79397 != -64880)
																															{
																																continue;
																															}
																															skillClass.mode = eSkillMode.instant;
																															if (126245 - 291151 != -164906)
																															{
																																continue;
																															}
																															skillClass.target = eSkillTarget.self;
																															if (136286 - 471392 == -335105)
																															{
																																continue;
																															}
																															skillClass.cType = "cosmicFriday";
																															if (96858 - 160910 == -64051)
																															{
																																continue;
																															}
																															skillClass.rSkill = 434;
																															if (135156 - 58393 != 76763)
																															{
																																continue;
																															}
																															break;
																														}
																														skillClass.setReq(40, 25);
																														if (247849 - 258189 == -10339)
																														{
																															continue;
																														}
																														skillClass.setMPSP(80, -35);
																														if (118475 - 175648 == -57172)
																														{
																															continue;
																														}
																														skillClass.mode = eSkillMode.instant;
																														if (153657 - 107700 == 45958)
																														{
																															continue;
																														}
																														skillClass.target = eSkillTarget.enemy;
																														if (260929 - 386696 != -125767)
																														{
																															continue;
																														}
																														skillClass.cType = "arcticEmperor";
																														if (47567 - 415463 != -367895)
																														{
																															break;
																														}
																														continue;
																													}
																													skillClass.setReq(40, 24);
																													if (278852 - 544197 == -265344)
																													{
																														continue;
																													}
																													skillClass.setMP(90);
																													if (167026 - 453886 != -286860)
																													{
																														continue;
																													}
																													skillClass.mode = eSkillMode.target;
																													if (6586 - 427769 != -421183)
																													{
																														continue;
																													}
																													skillClass.target = eSkillTarget.all;
																													if (98463 - 391211 == -292747)
																													{
																														continue;
																													}
																													skillClass.cType = "blizzard";
																													if (237713 - 414094 != -176380)
																													{
																														break;
																													}
																													continue;
																												}
																												skillClass.setReq(28, 16);
																												if (215773 - 547942 != -332169)
																												{
																													continue;
																												}
																												skillClass.setMPSP(50, 40);
																												if (91212 - 577276 != -486064)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.target;
																												if (11232 - 543783 == -532550)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.enemy;
																												if (250849 - 263391 == -12541)
																												{
																													continue;
																												}
																												skillClass.cType = "absoluteZero";
																												if (283044 - 187536 != 95508)
																												{
																													continue;
																												}
																												break;
																											}
																											IL_4F5:
																											skillClass.setReq(31, 14);
																											if (184096 - 281263 != -97166)
																											{
																												goto IL_FC4;
																											}
																											continue;
																											IL_1ADF:
																											skillClass.setReq(24, 10);
																											if (226884 - 366715 != -139831)
																											{
																												continue;
																											}
																											goto IL_4F5;
																											IL_FC4:
																											skillClass.setReq(38, 18);
																											if (86727 - 273698 == -186970)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.passive;
																											if (89585 - 22067 != 67519)
																											{
																												break;
																											}
																											continue;
																										}
																										IL_23B3:
																										skillClass.setReq(28, 12);
																										if (178153 - 453306 != -275153)
																										{
																											continue;
																										}
																										skillClass.setMP(60);
																										if (228088 - 250106 == -22017)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.instant;
																										if (60586 - 537251 != -476665)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.enemy;
																										if (145876 - 497774 == -351897)
																										{
																											continue;
																										}
																										skillClass.cType = "tornado";
																										if (17536 - 398950 != -381414)
																										{
																											continue;
																										}
																										break;
																										IL_2786:
																										skillClass.setReq(20, 8);
																										if (245418 - 235285 == 10134)
																										{
																											continue;
																										}
																										skillClass.setMP(48);
																										if (244558 - 234295 != 10263)
																										{
																											continue;
																										}
																										goto IL_23B3;
																									}
																									skillClass.setReq(33, 9);
																									if (19532 - 487774 == -468241)
																									{
																										continue;
																									}
																									skillClass.setMP(27);
																									if (166672 - 466098 != -299426)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.target;
																									if (10199 - 198903 != -188704)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.enemy;
																									if (267742 - 178510 == 89233)
																									{
																										continue;
																									}
																									skillClass.cType = "snowMan";
																									if (65685 - 47472 != 18213)
																									{
																										continue;
																									}
																									break;
																								}
																								skillClass.setReq(25, 7);
																								if (277582 - 121494 == 156089)
																								{
																									continue;
																								}
																								skillClass.setMP(15);
																								if (143445 - 228331 == -84885)
																								{
																									continue;
																								}
																								skillClass.mode = eSkillMode.instant;
																								if (183209 - 392421 != -209212)
																								{
																									continue;
																								}
																								skillClass.target = eSkillTarget.self;
																								if (232452 - 555503 != -323051)
																								{
																									continue;
																								}
																								skillClass.cType = "iceBlock";
																								if (218245 - 379991 != -161745)
																								{
																									break;
																								}
																								continue;
																							}
																							IL_1EE:
																							skillClass.setReq(23, 6);
																							if (43845 - 511170 != -467325)
																							{
																								continue;
																							}
																							skillClass.setMP(31);
																							if (269482 - 344417 != -74935)
																							{
																								continue;
																							}
																							goto IL_120C;
																							IL_173D:
																							skillClass.setReq(15, 4);
																							if (138317 - 16847 != 121470)
																							{
																								continue;
																							}
																							skillClass.setMP(23);
																							if (43668 - 255365 != -211696)
																							{
																								goto IL_1EE;
																							}
																							continue;
																							IL_120C:
																							skillClass.setReq(31, 8);
																							if (110990 - 245097 == -134106)
																							{
																								continue;
																							}
																							skillClass.setMP(39);
																							if (48327 - 464066 != -415739)
																							{
																								continue;
																							}
																							skillClass.mode = eSkillMode.target;
																							if (143596 - 440082 == -296485)
																							{
																								continue;
																							}
																							skillClass.target = eSkillTarget.ally;
																							if (168278 - 445026 == -276747)
																							{
																								continue;
																							}
																							skillClass.cType = "iceShield";
																							if (37451 - 203478 != -166026)
																							{
																								break;
																							}
																							continue;
																						}
																						IL_7A1:
																						skillClass.setReq(21, 5);
																						if (223423 - 101976 != 121447)
																						{
																							continue;
																						}
																						skillClass.setMP(32);
																						if (244566 - 194519 == 50048)
																						{
																							continue;
																						}
																						skillClass.mode = eSkillMode.instant;
																						if (205844 - 555912 == -350067)
																						{
																							continue;
																						}
																						skillClass.target = eSkillTarget.enemy;
																						if (44065 - 412874 == -368808)
																						{
																							continue;
																						}
																						skillClass.cType = "arcticWind";
																						if (268489 - 45020 != 223469)
																						{
																							continue;
																						}
																						break;
																						IL_B61:
																						skillClass.setReq(13, 3);
																						if (209352 - 297993 == -88640)
																						{
																							continue;
																						}
																						skillClass.setMP(26);
																						if (227456 - 221255 != 6201)
																						{
																							continue;
																						}
																						goto IL_7A1;
																					}
																					IL_1655:
																					skillClass.setReq(19, 2);
																					if (146188 - 195667 != -49479)
																					{
																						continue;
																					}
																					skillClass.setMP(20);
																					if (78463 - 460470 != -382007)
																					{
																						continue;
																					}
																					IL_1E84:
																					skillClass.setReq(27, 3);
																					if (71638 - 471789 == -400150)
																					{
																						continue;
																					}
																					skillClass.setMP(24);
																					if (272632 - 506942 != -234310)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.target;
																					if (123116 - 400388 == -277271)
																					{
																						continue;
																					}
																					skillClass.target = eSkillTarget.enemy;
																					if (242517 - 520133 == -277615)
																					{
																						continue;
																					}
																					skillClass.cType = "frozenBlast";
																					if (293136 - 379378 != -86242)
																					{
																						continue;
																					}
																					break;
																					IL_2577:
																					skillClass.setReq(11, 1);
																					if (10078 - 112843 == -102764)
																					{
																						continue;
																					}
																					skillClass.setMP(16);
																					if (86484 - 328954 != -242469)
																					{
																						goto IL_1655;
																					}
																					continue;
																				}
																				skillClass.setReq(40, 25);
																				if (24403 - 464799 == -440395)
																				{
																					continue;
																				}
																				skillClass.setMPSP(160, -45);
																				if (72466 - 415222 != -342756)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.target;
																				if (121905 - 528476 != -406571)
																				{
																					continue;
																				}
																				skillClass.target = eSkillTarget.enemy;
																				if (270748 - 439559 == -168810)
																				{
																					continue;
																				}
																				skillClass.cType = "meteora";
																				if (239153 - 235632 != 3521)
																				{
																					continue;
																				}
																				break;
																			}
																			IL_EA3:
																			skillClass.setReq(40, 24);
																			if (98936 - 515249 != -416313)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.passive;
																			if (143450 - 165448 != -21997)
																			{
																				break;
																			}
																			continue;
																			IL_2F1D:
																			skillClass.setReq(34, 20);
																			if (194949 - 521190 != -326241)
																			{
																				continue;
																			}
																			goto IL_EA3;
																			IL_3150:
																			skillClass.setReq(28, 16);
																			if (227505 - 479396 != -251890)
																			{
																				goto IL_2F1D;
																			}
																			continue;
																		}
																		skillClass.setReq(24, 10);
																		if (194421 - 385880 != -191459)
																		{
																			continue;
																		}
																		skillClass.setMP(55);
																		if (96165 - 427648 != -331483)
																		{
																			continue;
																		}
																		IL_1C68:
																		skillClass.setReq(31, 14);
																		if (192642 - 298524 != -105882)
																		{
																			continue;
																		}
																		skillClass.setMP(70);
																		if (190329 - 66540 != 123789)
																		{
																			continue;
																		}
																		skillClass.mode = eSkillMode.instant;
																		if (139822 - 312914 != -173092)
																		{
																			continue;
																		}
																		skillClass.target = eSkillTarget.enemy;
																		if (284189 - 3599 != 280590)
																		{
																			continue;
																		}
																		skillClass.cType = "manaVortex";
																		if (148176 - 368130 != -219954)
																		{
																			continue;
																		}
																		break;
																	}
																	skillClass.setReq(36, 16);
																	if (245131 - 90194 != 154937)
																	{
																		continue;
																	}
																	skillClass.setMP(50);
																	if (20443 - 408310 == -387866)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.target;
																	if (256426 - 162277 == 94150)
																	{
																		continue;
																	}
																	skillClass.target = eSkillTarget.enemy;
																	if (128017 - 147192 == -19174)
																	{
																		continue;
																	}
																	skillClass.cType = "fallingComets";
																	if (108214 - 524932 != -416718)
																	{
																		continue;
																	}
																	break;
																}
																skillClass.setReq(20, 8);
																if (163168 - 481242 == -318073)
																{
																	continue;
																}
																skillClass.setMPSP(30, -15);
																if (95046 - 145779 == -50732)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.instant;
																if (16811 - 317088 == -300276)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.self;
																if (167384 - 159181 == 8204)
																{
																	continue;
																}
																skillClass.cType = "fallingStars";
																if (168090 - 405532 != -237442)
																{
																	continue;
																}
																break;
															}
															skillClass.setReq(33, 9);
															if (255193 - 316389 == -61195)
															{
																continue;
															}
															skillClass.setMP(30);
															if (144962 - 441145 == -296182)
															{
																continue;
															}
															skillClass.mode = eSkillMode.target;
															if (238984 - 104791 != 134193)
															{
																continue;
															}
															skillClass.target = eSkillTarget.enemy;
															if (164412 - 114270 == 50143)
															{
																continue;
															}
															skillClass.cType = "manaBurn";
															if (166462 - 226597 != -60135)
															{
																continue;
															}
															break;
														}
														skillClass.setReq(25, 7);
														if (22998 - 420097 == -397098)
														{
															continue;
														}
														skillClass.setMP(60);
														if (136637 - 240818 == -104180)
														{
															continue;
														}
														skillClass.mode = eSkillMode.target;
														if (251364 - 235833 == 15532)
														{
															continue;
														}
														skillClass.target = eSkillTarget.ally;
														if (53489 - 497 != 52992)
														{
															continue;
														}
														skillClass.cType = "mpTransfer";
														if (283783 - 584458 != -300675)
														{
															continue;
														}
														break;
													}
													skillClass.setReq(31, 8);
													if (252409 - 451470 == -199060)
													{
														continue;
													}
													skillClass.setMPSP(5, -15);
													if (13893 - 451803 == -437909)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (138920 - 386508 == -247587)
													{
														continue;
													}
													skillClass.target = eSkillTarget.self;
													if (239835 - 543014 == -303178)
													{
														continue;
													}
													skillClass.cType = "blink";
													if (267727 - 259235 != 8493)
													{
														break;
													}
													continue;
												}
												skillClass.setReq(23, 6);
												if (179468 - 229699 == -50230)
												{
													continue;
												}
												skillClass.setMP(22);
												if (52476 - 356884 != -304408)
												{
													continue;
												}
												skillClass.mode = eSkillMode.instant;
												if (277631 - 594865 != -317234)
												{
													continue;
												}
												skillClass.target = eSkillTarget.self;
												if (45800 - 315614 == -269813)
												{
													continue;
												}
												skillClass.cType = "dispell";
												if (11727 - 313503 != -301775)
												{
													break;
												}
												continue;
											}
											IL_284:
											skillClass.setReq(29, 7);
											if (287299 - 524400 == -237100)
											{
												continue;
											}
											skillClass.setMPSP(24, -10);
											if (2580 - 436039 != -433459)
											{
												continue;
											}
											skillClass.mode = eSkillMode.instant;
											if (102864 - 470640 != -367776)
											{
												continue;
											}
											skillClass.target = eSkillTarget.enemy;
											if (216983 - 504111 == -287127)
											{
												continue;
											}
											skillClass.cType = "manaArc";
											if (83555 - 437753 != -354197)
											{
												break;
											}
											continue;
											IL_8BA:
											skillClass.setReq(13, 3);
											if (93234 - 568958 == -475723)
											{
												continue;
											}
											skillClass.setMPSP(12, -6);
											if (38065 - 50039 != -11974)
											{
												continue;
											}
											IL_1935:
											skillClass.setReq(21, 5);
											if (201436 - 486811 == -285374)
											{
												continue;
											}
											skillClass.setMPSP(18, -8);
											if (201508 - 81031 != 120477)
											{
												continue;
											}
											goto IL_284;
										}
										skillClass.setReq(11, 1);
										if (12561 - 150246 == -137684)
										{
											continue;
										}
										skillClass.setMP(15);
										if (253849 - 43711 != 210138)
										{
											continue;
										}
										goto IL_D05;
										IL_30D:
										skillClass.setReq(27, 3);
										if (246015 - 206278 != 39737)
										{
											continue;
										}
										skillClass.setMP(27);
										if (279239 - 172096 != 107143)
										{
											continue;
										}
										skillClass.mode = eSkillMode.target;
										if (178149 - 117498 == 60652)
										{
											continue;
										}
										skillClass.target = eSkillTarget.enemy;
										if (209048 - 2920 == 206129)
										{
											continue;
										}
										skillClass.cType = "manaMissile";
										if (272993 - 152199 != 120795)
										{
											break;
										}
										continue;
										IL_D05:
										skillClass.setReq(19, 2);
										if (150813 - 197800 != -46987)
										{
											continue;
										}
										skillClass.setMP(21);
										if (272724 - 538766 != -266042)
										{
											continue;
										}
										goto IL_30D;
									}
									IL_263D:
									skillClass.setReq(40, 10);
									if (131899 - 17648 != 114251)
									{
										continue;
									}
									skillClass.mode = eSkillMode.passive;
									if (38169 - 148595 == -110425)
									{
										continue;
									}
									skillClass.target = eSkillTarget.self;
									if (180572 - 94473 != 86100)
									{
										break;
									}
									continue;
									IL_115F:
									skillClass.setReq(20, 6);
									if (12025 - 446280 == -434254)
									{
										continue;
									}
									IL_181E:
									skillClass.setReq(30, 8);
									if (19488 - 489048 != -469559)
									{
										goto IL_263D;
									}
									continue;
								}
								IL_49:
								skillClass.setReq(32, 8);
								if (30668 - 511458 != -480790)
								{
									continue;
								}
								skillClass.mode = eSkillMode.passive;
								if (265188 - 385949 != -120760)
								{
									break;
								}
								continue;
								IL_9E0:
								skillClass.setReq(24, 6);
								if (282606 - 547317 != -264711)
								{
									continue;
								}
								goto IL_49;
								IL_3711:
								skillClass.setReq(16, 4);
								if (151521 - 103987 != 47535)
								{
									goto IL_9E0;
								}
								continue;
							}
							IL_15A5:
							skillClass.setReq(16, 3);
							if (181302 - 202180 != -20878)
							{
								continue;
							}
							goto IL_34BA;
							IL_280E:
							skillClass.setReq(10, 2);
							if (25617 - 121368 != -95750)
							{
								goto IL_15A5;
							}
							continue;
							IL_34BA:
							skillClass.setReq(22, 4);
							if (153232 - 487071 == -333838)
							{
								continue;
							}
							skillClass.mode = eSkillMode.passive;
							if (112585 - 570266 != -457680)
							{
								break;
							}
							continue;
						}
						skillClass.setReq(2, 1);
						if (13437 - 96512 != -83074)
						{
							skillClass.mode = eSkillMode.passive;
							if (195899 - 55263 != 140637)
							{
								break;
							}
						}
					}
				}
			}
		}
		return skillClass;
	}

	// Token: 0x06002F35 RID: 12085 RVA: 0x005EA0B0 File Offset: 0x005E82B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillTree(int commandNum)
	{
		if (281095 - 357210 != -76114)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (35763 - 1310 != 34454)
			{
				if (246377 - 547809 == -301432)
				{
					if (commandNum == 101)
					{
						if (280274 - 481614 == -201340)
						{
							result = "pgn_nAttack1";
							if (36732 - 389316 == -352584)
							{
								break;
							}
						}
					}
					else if (commandNum == 102)
					{
						if (149388 - 384104 == -234716)
						{
							result = "pgn_nAttack2";
							if (160079 - 87373 == 72706)
							{
								break;
							}
						}
					}
					else if (commandNum == 111)
					{
						if (12003 - 181698 == -169695)
						{
							result = "pgn_cAttack1";
							if (128054 - 354530 != -226475)
							{
								break;
							}
						}
					}
					else if (commandNum == 112)
					{
						if (235813 - 327209 == -91396)
						{
							result = "pgn_cAttack2";
							if (180424 - 303474 != -123049)
							{
								break;
							}
						}
					}
					else if (commandNum == 113)
					{
						if (128924 - 163056 == -34132)
						{
							result = "pgn_cAttack3";
							if (174395 - 512366 != -337970)
							{
								break;
							}
						}
					}
					else if (commandNum == 114)
					{
						if (16954 - 41588 != -24633)
						{
							result = "pgn_cAttack4";
							if (235334 - 287078 != -51743)
							{
								break;
							}
						}
					}
					else if (commandNum == 121)
					{
						if (9528 - 182398 == -172870)
						{
							result = "pgn_Intellect1";
							if (240494 - 471612 == -231118)
							{
								break;
							}
						}
					}
					else if (commandNum == 122)
					{
						if (285875 - 581464 != -295588)
						{
							result = "pgn_Intellect2";
							if (228298 - 381237 == -152939)
							{
								break;
							}
						}
					}
					else if (commandNum == 123)
					{
						if (278376 - 399163 == -120787)
						{
							result = "pgn_Intellect3";
							if (152798 - 36346 != 116453)
							{
								break;
							}
						}
					}
					else if (commandNum == 124)
					{
						if (67690 - 378262 == -310572)
						{
							result = "pgn_Intellect4";
							if (49483 - 24393 == 25090)
							{
								break;
							}
						}
					}
					else if (commandNum == 131)
					{
						if (104050 - 441175 == -337125)
						{
							result = "pgn_doubleCast1";
							if (128617 - 236743 == -108126)
							{
								break;
							}
						}
					}
					else if (commandNum == 132)
					{
						if (225721 - 399869 != -174147)
						{
							result = "pgn_tripleCast2";
							if (268518 - 470248 == -201730)
							{
								break;
							}
						}
					}
					else if (commandNum == 141)
					{
						if (281906 - 1913 == 279993)
						{
							result = "pgn_statPlus1";
							if (249942 - 209575 == 40367)
							{
								break;
							}
						}
					}
					else if (commandNum == 142)
					{
						if (170971 - 1650 == 169321)
						{
							result = "pgn_statPlus2";
							if (56223 - 351756 != -295532)
							{
								break;
							}
						}
					}
					else if (commandNum == 143)
					{
						if (275944 - 48776 != 227169)
						{
							result = "pgn_statPlus3";
							if (70863 - 41986 != 28878)
							{
								break;
							}
						}
					}
					else if (commandNum == 144)
					{
						if (257335 - 84710 != 172626)
						{
							result = "pgn_statPlus4";
							if (242827 - 401138 != -158310)
							{
								break;
							}
						}
					}
					else if (commandNum == 201)
					{
						if (135241 - 34657 == 100584)
						{
							result = "pgn_manaMissile1";
							if (9725 - 161191 == -151466)
							{
								break;
							}
						}
					}
					else if (commandNum == 202)
					{
						if (59131 - 223120 != -163988)
						{
							result = "pgn_manaMissile2";
							if (102143 - 483532 != -381388)
							{
								break;
							}
						}
					}
					else if (commandNum == 203)
					{
						if (225472 - 511020 != -285547)
						{
							result = "pgn_manaMissile3";
							if (251515 - 108688 != 142828)
							{
								break;
							}
						}
					}
					else if (commandNum == 204)
					{
						if (158933 - 196853 == -37920)
						{
							result = "pgn_manaMissile4";
							if (276315 - 337515 == -61200)
							{
								break;
							}
						}
					}
					else if (commandNum == 211)
					{
						if (177626 - 118378 != 59249)
						{
							result = "pgn_manaArc1";
							if (175897 - 359051 == -183154)
							{
								break;
							}
						}
					}
					else if (commandNum == 212)
					{
						if (243655 - 345173 == -101518)
						{
							result = "pgn_manaArc2";
							if (40200 - 430534 == -390334)
							{
								break;
							}
						}
					}
					else if (commandNum == 213)
					{
						if (46462 - 273371 != -226908)
						{
							result = "pgn_manaArc3";
							if (268656 - 553890 != -285233)
							{
								break;
							}
						}
					}
					else if (commandNum == 214)
					{
						if (298664 - 66213 == 232451)
						{
							result = "pgn_manaArc4";
							if (59723 - 112408 != -52684)
							{
								break;
							}
						}
					}
					else if (commandNum == 221)
					{
						if (294947 - 299873 != -4925)
						{
							result = "pgn_dispell1";
							if (36827 - 241551 == -204724)
							{
								break;
							}
						}
					}
					else if (commandNum == 222)
					{
						if (157646 - 563448 == -405802)
						{
							result = "pgn_blink1";
							if (94368 - 537015 == -442647)
							{
								break;
							}
						}
					}
					else if (commandNum == 223)
					{
						if (232708 - 408340 != -175631)
						{
							result = "pgn_dispell2";
							if (279341 - 427334 != -147992)
							{
								break;
							}
						}
					}
					else if (commandNum == 224)
					{
						if (289379 - 561292 == -271913)
						{
							result = "pgn_blink2";
							if (272357 - 226071 == 46286)
							{
								break;
							}
						}
					}
					else if (commandNum == 231)
					{
						if (110661 - 593468 != -482806)
						{
							result = "pgn_mpTransfer1";
							if (62499 - 56508 != 5992)
							{
								break;
							}
						}
					}
					else if (commandNum == 232)
					{
						if (81238 - 510483 != -429244)
						{
							result = "pgn_manaBurn1";
							if (255031 - 24007 != 231025)
							{
								break;
							}
						}
					}
					else if (commandNum == 233)
					{
						if (177782 - 177620 == 162)
						{
							result = "pgn_mpTransfer2";
							if (172696 - 406246 == -233550)
							{
								break;
							}
						}
					}
					else if (commandNum == 234)
					{
						if (60798 - 190843 == -130045)
						{
							result = "pgn_manaBurn2";
							if (253050 - 545260 != -292209)
							{
								break;
							}
						}
					}
					else if (commandNum == 241)
					{
						if (69191 - 345322 == -276131)
						{
							result = "pgn_fallingStars1";
							if (117856 - 15112 != 102745)
							{
								break;
							}
						}
					}
					else if (commandNum == 242)
					{
						if (87591 - 445404 != -357812)
						{
							result = "pgn_fallingStars2";
							if (81270 - 588892 != -507621)
							{
								break;
							}
						}
					}
					else if (commandNum == 243)
					{
						if (104372 - 496416 != -392043)
						{
							result = "pgn_fallingComets1";
							if (64200 - 551186 != -486985)
							{
								break;
							}
						}
					}
					else if (commandNum == 244)
					{
						if (262252 - 412202 != -149949)
						{
							result = "pgn_fallingComets2";
							if (272589 - 283633 != -11043)
							{
								break;
							}
						}
					}
					else if (commandNum == 251)
					{
						if (68921 - 120273 != -51351)
						{
							result = "pgn_manaVortex1";
							if (9271 - 442658 != -433386)
							{
								break;
							}
						}
					}
					else if (commandNum == 252)
					{
						if (194182 - 545185 != -351002)
						{
							result = "pgn_manaVortex2";
							if (211135 - 335948 == -124813)
							{
								break;
							}
						}
					}
					else if (commandNum == 253)
					{
						if (191082 - 186714 == 4368)
						{
							result = "pgn_manaVortex3";
							if (184911 - 178084 != 6828)
							{
								break;
							}
						}
					}
					else if (commandNum == 254)
					{
						if (224106 - 280260 != -56153)
						{
							result = "pgn_novaFlare1";
							if (281859 - 395594 == -113735)
							{
								break;
							}
						}
					}
					else if (commandNum == 261)
					{
						if (45685 - 596479 != -550793)
						{
							result = "pgn_astralTalent1";
							if (154107 - 163111 != -9003)
							{
								break;
							}
						}
					}
					else if (commandNum == 262)
					{
						if (244575 - 211387 != 33189)
						{
							result = "pgn_astralTalent2";
							if (252657 - 387785 == -135128)
							{
								break;
							}
						}
					}
					else if (commandNum == 263)
					{
						if (13556 - 43140 != -29583)
						{
							result = "pgn_astralTalent3";
							if (188529 - 90343 != 98187)
							{
								break;
							}
						}
					}
					else if (commandNum == 264)
					{
						if (19742 - 429175 != -409432)
						{
							result = "pgn_astralTalent4";
							if (27872 - 454514 == -426642)
							{
								break;
							}
						}
					}
					else if (commandNum == 271)
					{
						if (277865 - 443547 == -165682)
						{
							result = "pgn_meteora1";
							if (255481 - 496008 != -240526)
							{
								break;
							}
						}
					}
					else if (commandNum == 272)
					{
						if (202404 - 228062 == -25658)
						{
							result = "pgn_meteora2";
							if (82040 - 199429 == -117389)
							{
								break;
							}
						}
					}
					else if (commandNum == 301)
					{
						if (26508 - 223037 != -196528)
						{
							result = "pgn_frozenBlast1";
							if (151282 - 229028 == -77746)
							{
								break;
							}
						}
					}
					else if (commandNum == 302)
					{
						if (144249 - 137422 != 6828)
						{
							result = "pgn_frozenBlast2";
							if (178662 - 218678 == -40016)
							{
								break;
							}
						}
					}
					else if (commandNum == 303)
					{
						if (152581 - 414523 != -261941)
						{
							result = "pgn_frozenBlast3";
							if (133558 - 257242 == -123684)
							{
								break;
							}
						}
					}
					else if (commandNum == 304)
					{
						if (43611 - 351604 != -307992)
						{
							result = "pgn_frozenBlast4";
							if (89706 - 524489 == -434783)
							{
								break;
							}
						}
					}
					else if (commandNum == 311)
					{
						if (136527 - 216619 != -80091)
						{
							result = "pgn_arcticWind1";
							if (230429 - 428524 == -198095)
							{
								break;
							}
						}
					}
					else if (commandNum == 312)
					{
						if (49452 - 596863 == -547411)
						{
							result = "pgn_arcticWind2";
							if (260401 - 254600 == 5801)
							{
								break;
							}
						}
					}
					else if (commandNum == 313)
					{
						if (24825 - 226927 == -202102)
						{
							result = "pgn_arcticWind3";
							if (49507 - 159395 != -109887)
							{
								break;
							}
						}
					}
					else if (commandNum == 314)
					{
						if (43858 - 582075 == -538217)
						{
							result = "pgn_arcticFrost1";
							if (161618 - 474307 == -312689)
							{
								break;
							}
						}
					}
					else if (commandNum == 321)
					{
						if (249651 - 30857 == 218794)
						{
							result = "pgn_iceShield1";
							if (53272 - 415414 != -362141)
							{
								break;
							}
						}
					}
					else if (commandNum == 322)
					{
						if (14059 - 323995 == -309936)
						{
							result = "pgn_iceShield2";
							if (91191 - 441909 == -350718)
							{
								break;
							}
						}
					}
					else if (commandNum == 323)
					{
						if (281409 - 123740 == 157669)
						{
							result = "pgn_iceShield3";
							if (109137 - 440603 == -331466)
							{
								break;
							}
						}
					}
					else if (commandNum == 324)
					{
						if (174855 - 457859 == -283004)
						{
							result = "pgn_iceShield4";
							if (17444 - 124237 == -106793)
							{
								break;
							}
						}
					}
					else if (commandNum == 331)
					{
						if (118408 - 294207 != -175798)
						{
							result = "pgn_iceBlock1";
							if (92374 - 294197 != -201822)
							{
								break;
							}
						}
					}
					else if (commandNum == 332)
					{
						if (22057 - 467852 != -445794)
						{
							result = "pgn_snowMan1";
							if (59025 - 422115 == -363090)
							{
								break;
							}
						}
					}
					else if (commandNum == 333)
					{
						if (120382 - 392315 == -271933)
						{
							result = "pgn_iceBlock2";
							if (260692 - 278455 == -17763)
							{
								break;
							}
						}
					}
					else if (commandNum == 334)
					{
						if (137531 - 5505 == 132026)
						{
							result = "pgn_snowMan2";
							if (267337 - 262861 != 4477)
							{
								break;
							}
						}
					}
					else if (commandNum == 341)
					{
						if (38006 - 453263 == -415257)
						{
							result = "pgn_tornado1";
							if (273684 - 445233 == -171549)
							{
								break;
							}
						}
					}
					else if (commandNum == 342)
					{
						if (92354 - 597700 != -505345)
						{
							result = "pgn_tornado2";
							if (155019 - 419006 == -263987)
							{
								break;
							}
						}
					}
					else if (commandNum == 343)
					{
						if (184520 - 216956 != -32435)
						{
							result = "pgn_tornado3";
							if (238951 - 597043 == -358092)
							{
								break;
							}
						}
					}
					else if (commandNum == 344)
					{
						if (191739 - 201346 != -9606)
						{
							result = "pgn_typhoon1";
							if (283851 - 378409 != -94557)
							{
								break;
							}
						}
					}
					else if (commandNum == 351)
					{
						if (196505 - 355521 == -159016)
						{
							result = "pgn_frostBite1";
							if (116957 - 447487 == -330530)
							{
								break;
							}
						}
					}
					else if (commandNum == 352)
					{
						if (269644 - 545403 == -275759)
						{
							result = "pgn_frostBite2";
							if (89788 - 261728 != -171939)
							{
								break;
							}
						}
					}
					else if (commandNum == 353)
					{
						if (227606 - 286103 != -58496)
						{
							result = "pgn_frostBite3";
							if (127336 - 237718 != -110381)
							{
								break;
							}
						}
					}
					else if (commandNum == 354)
					{
						if (126170 - 183068 == -56898)
						{
							result = "pgn_frostBite4";
							if (91651 - 277479 != -185827)
							{
								break;
							}
						}
					}
					else if (commandNum == 361)
					{
						if (37661 - 456483 == -418822)
						{
							result = "pgn_absoluteZero1";
							if (193528 - 374761 == -181233)
							{
								break;
							}
						}
					}
					else if (commandNum == 362)
					{
						if (235500 - 160395 != 75106)
						{
							result = "pgn_absoluteZero2";
							if (250385 - 419411 == -169026)
							{
								break;
							}
						}
					}
					else if (commandNum == 363)
					{
						if (82829 - 508843 == -426014)
						{
							result = "pgn_blizzard1";
							if (24045 - 78433 == -54388)
							{
								break;
							}
						}
					}
					else if (commandNum == 364)
					{
						if (119464 - 200434 != -80969)
						{
							result = "pgn_blizzard2";
							if (67550 - 502275 == -434725)
							{
								break;
							}
						}
					}
					else if (commandNum == 371)
					{
						if (90400 - 188026 == -97626)
						{
							result = "pgn_arcticEmperor1";
							if (56786 - 222916 == -166130)
							{
								break;
							}
						}
					}
					else if (commandNum == 372)
					{
						if (152091 - 58831 == 93260)
						{
							result = "pgn_arcticEmperor2";
							if (225146 - 15018 == 210128)
							{
								break;
							}
						}
					}
					else if (commandNum == 401)
					{
						if (8848 - 133294 == -124446)
						{
							result = "pgn_spreadShot5";
							if (216260 - 510027 != -293766)
							{
								break;
							}
						}
					}
					else if (commandNum == 411)
					{
						if (190889 - 180708 != 10182)
						{
							result = "pgn_manaField5";
							if (52790 - 407096 != -354305)
							{
								break;
							}
						}
					}
					else if (commandNum == 421)
					{
						if (257281 - 347205 != -89923)
						{
							result = "pgn_focusIntellect5";
							if (38599 - 385405 == -346806)
							{
								break;
							}
						}
					}
					else if (commandNum == 431)
					{
						if (218951 - 57585 != 161367)
						{
							result = "pgn_doubleSpell5";
							if (273877 - 542268 != -268390)
							{
								break;
							}
						}
					}
					else if (commandNum == 441)
					{
						if (198854 - 551968 != -353113)
						{
							result = "pgn_superStatPlus5";
							if (228841 - 545150 == -316309)
							{
								break;
							}
						}
					}
					else if (commandNum == 402)
					{
						if (138421 - 336697 != -198275)
						{
							result = "pgn_moreMissile5";
							if (272414 - 248517 == 23897)
							{
								break;
							}
						}
					}
					else if (commandNum == 412)
					{
						if (253599 - 374157 == -120558)
						{
							result = "pgn_penguinOfArc5";
							if (117838 - 300973 == -183135)
							{
								break;
							}
						}
					}
					else if (commandNum == 422)
					{
						if (158210 - 338696 != -180485)
						{
							result = "pgn_parallelShift5";
							if (291956 - 268544 != 23413)
							{
								break;
							}
						}
					}
					else if (commandNum == 432)
					{
						if (202698 - 154865 == 47833)
						{
							result = "pgn_manaSurge5";
							if (170854 - 596119 == -425265)
							{
								break;
							}
						}
					}
					else if (commandNum == 442)
					{
						if (139503 - 435180 != -295676)
						{
							result = "pgn_giantStar5";
							if (15865 - 82949 == -67084)
							{
								break;
							}
						}
					}
					else if (commandNum == 403)
					{
						if (256574 - 360113 == -103539)
						{
							result = "pgn_frozenBreak5";
							if (37142 - 184468 == -147326)
							{
								break;
							}
						}
					}
					else if (commandNum == 413)
					{
						if (55397 - 449093 == -393696)
						{
							result = "pgn_deadlyFrost5";
							if (66531 - 135776 != -69244)
							{
								break;
							}
						}
					}
					else if (commandNum == 423)
					{
						if (66412 - 111453 != -45040)
						{
							result = "pgn_frostSpike5";
							if (152246 - 543380 != -391133)
							{
								break;
							}
						}
					}
					else if (commandNum == 433)
					{
						if (71209 - 548958 == -477749)
						{
							result = "pgn_snowBall5";
							if (118079 - 167426 == -49347)
							{
								break;
							}
						}
					}
					else if (commandNum == 443)
					{
						if (90270 - 147929 != -57658)
						{
							result = "pgn_iceTwister5";
							if (12328 - 281704 != -269375)
							{
								break;
							}
						}
					}
					else if (commandNum == 404)
					{
						if (89063 - 255415 == -166352)
						{
							result = "pgn_revisedSkill5";
							if (298336 - 421049 == -122713)
							{
								break;
							}
						}
					}
					else if (commandNum == 414)
					{
						if (91779 - 51380 != 40400)
						{
							result = "pgn_revisedMagic5";
							if (108744 - 373450 == -264706)
							{
								break;
							}
						}
					}
					else if (commandNum == 424)
					{
						if (86204 - 172776 == -86572)
						{
							result = "pgn_revisedArt5";
							if (220181 - 333115 != -112933)
							{
								break;
							}
						}
					}
					else if (commandNum == 434)
					{
						if (176858 - 127847 != 49012)
						{
							result = "pgn_cosmicRift5";
							if (242030 - 3241 == 238789)
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
						if (130993 - 531651 != -400657)
						{
							result = "pgn_cosmicFriday5";
							if (132955 - 76013 == 56942)
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

	// Token: 0x06002F36 RID: 12086 RVA: 0x005EBCC8 File Offset: 0x005E9EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002F37 RID: 12087 RVA: 0x005EBCCC File Offset: 0x005E9ECC
	internal static bool uN2XsW5c5pij65BA0ZFi()
	{
		return true;
	}

	// Token: 0x06002F38 RID: 12088 RVA: 0x005EBCD0 File Offset: 0x005E9ED0
	internal static bool Bb4Qs55cpjr3lsSk0COF()
	{
		return false;
	}
}
