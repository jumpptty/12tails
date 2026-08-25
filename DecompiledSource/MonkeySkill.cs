using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000767 RID: 1895
[Serializable]
public class MonkeySkill : MonoBehaviour
{
	// Token: 0x06002A1B RID: 10779 RVA: 0x0051A344 File Offset: 0x00518544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MonkeySkill()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002A1C RID: 10780 RVA: 0x0051A354 File Offset: 0x00518554
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSkill(string skillname)
	{
		if (272679 - 405719 != -133040)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (172470 - 10275 != 162196 && 91398 - 435891 != -344492)
			{
				if (skillname == "mnk_nAttack1")
				{
					if (59591 - 332404 == -272813)
					{
						skillClass.setReq(1, 0);
						if (269790 - 63064 == 206726)
						{
							skillClass.mode = eSkillMode.passive;
							if (94261 - 270001 != -175739)
							{
								break;
							}
						}
					}
				}
				else
				{
					if (skillname == "mnk_damageCast1")
					{
						if (131017 - 154120 == -23102)
						{
							continue;
						}
						skillClass.setReq(2, 1);
						if (10101 - 28683 != -18582)
						{
							continue;
						}
					}
					else if (skillname == "mnk_damageCast2")
					{
						if (80290 - 435885 == -355594)
						{
							continue;
						}
					}
					else
					{
						if (skillname == "mnk_cAttack1")
						{
							if (186811 - 339876 != -153065)
							{
								continue;
							}
							skillClass.setReq(4, 1);
							if (211902 - 242507 == -30604)
							{
								continue;
							}
						}
						else if (skillname == "mnk_cAttack2")
						{
							if (198635 - 324455 != -125820)
							{
								continue;
							}
						}
						else if (skillname == "mnk_cAttack3")
						{
							if (143267 - 117198 != 26070)
							{
								goto IL_2F90;
							}
							continue;
						}
						else if (skillname == "mnk_cAttack4")
						{
							if (154415 - 533986 != -379570)
							{
								goto IL_1974;
							}
							continue;
						}
						else if (skillname == "mnk_summonAttack")
						{
							if (214010 - 468667 != -254657)
							{
								continue;
							}
							skillClass.setReq(6, 2);
							if (179780 - 498941 == -319160)
							{
								continue;
							}
							skillClass.setSP(-1);
							if (135399 - 391353 != -255954)
							{
								continue;
							}
							skillClass.mode = eSkillMode.target;
							if (189671 - 317365 == -127693)
							{
								continue;
							}
							skillClass.target = eSkillTarget.enemy;
							if (249488 - 392634 != -143146)
							{
								continue;
							}
							skillClass.cType = "summonAttack";
							if (217677 - 154222 != 63456)
							{
								break;
							}
							continue;
						}
						else if (skillname == "mnk_summonDefense")
						{
							if (55126 - 350754 != -295628)
							{
								continue;
							}
							skillClass.setReq(12, 4);
							if (249416 - 412464 != -163048)
							{
								continue;
							}
							skillClass.setSP(-1);
							if (60213 - 170551 == -110337)
							{
								continue;
							}
							skillClass.mode = eSkillMode.instant;
							if (108454 - 226932 == -118477)
							{
								continue;
							}
							skillClass.target = eSkillTarget.self;
							if (128397 - 194642 == -66244)
							{
								continue;
							}
							skillClass.cType = "summonDefense";
							if (8044 - 557109 != -549065)
							{
								continue;
							}
							break;
						}
						else if (skillname == "mnk_unsummon")
						{
							if (88417 - 391880 != -303463)
							{
								continue;
							}
							skillClass.setReq(18, 6);
							if (77645 - 337590 != -259945)
							{
								continue;
							}
							skillClass.setSP(-10);
							if (221190 - 565200 != -344010)
							{
								continue;
							}
							skillClass.mode = eSkillMode.instant;
							if (112265 - 68401 == 43865)
							{
								continue;
							}
							skillClass.target = eSkillTarget.self;
							if (125539 - 194007 != -68468)
							{
								continue;
							}
							skillClass.cType = "unsummon";
							if (31971 - 275637 != -243665)
							{
								break;
							}
							continue;
						}
						else if (skillname == "mnk_summonRelease")
						{
							if (163185 - 494898 == -331712)
							{
								continue;
							}
							skillClass.setReq(24, 8);
							if (121552 - 559207 == -437654)
							{
								continue;
							}
							skillClass.setSP(-30);
							if (60040 - 358964 == -298923)
							{
								continue;
							}
							skillClass.mode = eSkillMode.instant;
							if (102477 - 311387 != -208910)
							{
								continue;
							}
							skillClass.target = eSkillTarget.self;
							if (35402 - 517240 == -481837)
							{
								continue;
							}
							skillClass.cType = "summonRelease";
							if (222602 - 30335 != 192267)
							{
								continue;
							}
							break;
						}
						else
						{
							if (skillname == "mnk_instantCast1")
							{
								if (284357 - 560012 == -275654)
								{
									continue;
								}
								skillClass.setReq(32, 6);
								if (122117 - 407095 == -284977)
								{
									continue;
								}
								skillClass.setMPSP(25, -15);
								if (281934 - 147016 != 134918)
								{
									continue;
								}
							}
							else if (skillname == "mnk_instantCast2")
							{
								if (106197 - 14163 == 92035)
								{
									continue;
								}
							}
							else
							{
								if (skillname == "mnk_statPlus1")
								{
									if (69250 - 265083 == -195832)
									{
										continue;
									}
									skillClass.setReq(10, 4);
									if (237187 - 112558 != 124630)
									{
										goto IL_2EB1;
									}
									continue;
								}
								else if (skillname == "mnk_statPlus2")
								{
									if (83170 - 445363 != -362193)
									{
										continue;
									}
									goto IL_2EB1;
								}
								else if (skillname == "mnk_statPlus3")
								{
									if (53213 - 197940 != -144726)
									{
										goto IL_28F0;
									}
									continue;
								}
								else if (skillname == "mnk_statPlus4")
								{
									if (158955 - 588250 == -429294)
									{
										continue;
									}
								}
								else
								{
									if (skillname == "mnk_fireBall1")
									{
										if (149956 - 268644 != -118688)
										{
											continue;
										}
										skillClass.setReq(3, 0);
										if (49247 - 528991 != -479744)
										{
											continue;
										}
										skillClass.setMP(9);
										if (141012 - 227267 != -86254)
										{
											goto IL_35A1;
										}
										continue;
									}
									else if (skillname == "mnk_fireBall2")
									{
										if (186732 - 158773 != 27960)
										{
											goto IL_35A1;
										}
										continue;
									}
									else if (skillname == "mnk_fireBall3")
									{
										if (195936 - 201618 != -5682)
										{
											continue;
										}
									}
									else if (skillname == "mnk_fireBall4")
									{
										if (246978 - 24552 != 222427)
										{
											goto IL_2273;
										}
										continue;
									}
									else
									{
										if (skillname == "mnk_phoenix1")
										{
											if (57451 - 481622 == -424170)
											{
												continue;
											}
											skillClass.setReq(5, 1);
											if (263542 - 530502 == -266959)
											{
												continue;
											}
											skillClass.setMP(25);
											if (140008 - 322922 != -182914)
											{
												continue;
											}
											goto IL_159B;
										}
										else if (skillname == "mnk_phoenix2")
										{
											if (141559 - 459510 != -317951)
											{
												continue;
											}
											goto IL_159B;
										}
										else if (skillname == "mnk_phoenix3")
										{
											if (176894 - 135854 != 41040)
											{
												continue;
											}
											goto IL_2D9C;
										}
										else if (skillname == "mnk_phoenix4")
										{
											if (47693 - 451735 != -404042)
											{
												continue;
											}
										}
										else
										{
											if (skillname == "mnk_rapidFire1")
											{
												if (157813 - 147696 == 10118)
												{
													continue;
												}
												skillClass.setReq(7, 2);
												if (75747 - 342000 == -266252)
												{
													continue;
												}
											}
											else if (skillname == "mnk_rapidFire2")
											{
												if (52681 - 275971 != -223290)
												{
													continue;
												}
											}
											else if (skillname == "mnk_rapidFire3")
											{
												if (116253 - 299370 != -183116)
												{
													goto IL_3223;
												}
												continue;
											}
											else if (skillname == "mnk_skyCrimson1")
											{
												if (251522 - 156242 != 95280)
												{
													continue;
												}
												skillClass.setReq(31, 8);
												if (275547 - 106144 == 169404)
												{
													continue;
												}
												skillClass.setSP(-36);
												if (116040 - 364993 == -248952)
												{
													continue;
												}
												skillClass.mode = eSkillMode.instant;
												if (204922 - 540057 != -335135)
												{
													continue;
												}
												skillClass.target = eSkillTarget.enemy;
												if (175374 - 497049 != -321675)
												{
													continue;
												}
												skillClass.cType = "skyCrimson";
												if (78887 - 559248 != -480360)
												{
													break;
												}
												continue;
											}
											else
											{
												if (skillname == "mnk_intenseFire1")
												{
													if (263376 - 102425 != 160951)
													{
														continue;
													}
													skillClass.setReq(9, 3);
													if (66982 - 88532 == -21549)
													{
														continue;
													}
												}
												else if (skillname == "mnk_intenseFire2")
												{
													if (67072 - 160933 != -93861)
													{
														continue;
													}
												}
												else if (skillname == "mnk_intenseFire3")
												{
													if (232673 - 197331 != 35343)
													{
														goto IL_133C;
													}
													continue;
												}
												else if (skillname == "mnk_blazingArrow1")
												{
													if (17912 - 411440 != -393528)
													{
														continue;
													}
													skillClass.setReq(33, 9);
													if (281181 - 389803 != -108622)
													{
														continue;
													}
													skillClass.setMPSP(24, -48);
													if (242499 - 390409 == -147909)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (109383 - 534404 != -425021)
													{
														continue;
													}
													skillClass.target = eSkillTarget.enemy;
													if (52698 - 472671 != -419973)
													{
														continue;
													}
													skillClass.cType = "blazingArrow";
													if (195877 - 175531 != 20347)
													{
														break;
													}
													continue;
												}
												else
												{
													if (skillname == "mnk_flashFire1")
													{
														if (222385 - 101887 != 120498)
														{
															continue;
														}
														skillClass.setReq(12, 4);
														if (48959 - 419469 == -370509)
														{
															continue;
														}
														skillClass.setMPSP(24, -12);
														if (165590 - 373240 != -207649)
														{
															goto IL_88F;
														}
														continue;
													}
													else if (skillname == "mnk_flashFire2")
													{
														if (186452 - 291303 != -104851)
														{
															continue;
														}
														goto IL_88F;
													}
													else if (skillname == "mnk_flashFire3")
													{
														if (30002 - 94480 == -64477)
														{
															continue;
														}
													}
													else if (skillname == "mnk_flashFire4")
													{
														if (292720 - 432446 != -139725)
														{
															goto IL_2DE2;
														}
														continue;
													}
													else
													{
														if (skillname == "mnk_ja1")
														{
															if (115844 - 84114 != 31730)
															{
																continue;
															}
															skillClass.setReq(17, 6);
															if (115347 - 500437 != -385090)
															{
																continue;
															}
															skillClass.setMP(15);
															if (4032 - 40015 != -35983)
															{
																continue;
															}
															goto IL_2764;
														}
														else if (skillname == "mnk_ja2")
														{
															if (297502 - 285505 != 11997)
															{
																continue;
															}
															goto IL_2764;
														}
														else if (skillname == "mnk_ja3")
														{
															if (54514 - 73656 == -19141)
															{
																continue;
															}
														}
														else if (skillname == "mnk_ja4")
														{
															if (285654 - 9510 != 276144)
															{
																continue;
															}
															goto IL_2EF6;
														}
														else
														{
															if (skillname == "mnk_fireRune1")
															{
																if (116817 - 467661 == -350843)
																{
																	continue;
																}
																skillClass.setReq(22, 12);
																if (50037 - 115623 != -65585)
																{
																	goto IL_3695;
																}
																continue;
															}
															else if (skillname == "mnk_fireRune2")
															{
																if (58522 - 329579 != -271057)
																{
																	continue;
																}
																goto IL_3695;
															}
															else if (skillname == "mnk_fireRune3")
															{
																if (176096 - 122253 != 53843)
																{
																	continue;
																}
															}
															else if (skillname == "mnk_runicFlame1")
															{
																if (274902 - 277856 != -2954)
																{
																	continue;
																}
																skillClass.setReq(40, 24);
																if (209779 - 571502 == -361722)
																{
																	continue;
																}
																skillClass.setMP(30);
																if (180439 - 119819 != 60620)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.instant;
																if (28714 - 181382 == -152667)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.self;
																if (115777 - 295199 != -179422)
																{
																	continue;
																}
																skillClass.cType = "runicFlame";
																if (197347 - 350197 != -152849)
																{
																	break;
																}
																continue;
															}
															else
															{
																if (skillname == "mnk_worldIgnition1")
																{
																	if (126479 - 583889 == -457409)
																	{
																		continue;
																	}
																	skillClass.setReq(35, 23);
																	if (280371 - 550492 == -270120)
																	{
																		continue;
																	}
																	skillClass.setMPSP(40, -30);
																	if (95434 - 449338 == -353903)
																	{
																		continue;
																	}
																}
																else if (skillname == "mnk_worldIgnition2")
																{
																	if (219907 - 349698 == -129790)
																	{
																		continue;
																	}
																}
																else
																{
																	if (skillname == "mnk_groundLock1")
																	{
																		if (65086 - 366557 != -301471)
																		{
																			continue;
																		}
																		skillClass.setReq(3, 0);
																		if (163871 - 561040 == -397168)
																		{
																			continue;
																		}
																		skillClass.setMP(8);
																		if (160603 - 415386 != -254782)
																		{
																			goto IL_120F;
																		}
																		continue;
																	}
																	else if (skillname == "mnk_groundLock2")
																	{
																		if (127301 - 318224 != -190922)
																		{
																			goto IL_120F;
																		}
																		continue;
																	}
																	else if (skillname == "mnk_groundLock3")
																	{
																		if (18842 - 348272 != -329430)
																		{
																			continue;
																		}
																		goto IL_3469;
																	}
																	else if (skillname == "mnk_groundLock4")
																	{
																		if (268882 - 550486 != -281604)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (skillname == "mnk_gadina1")
																		{
																			if (74387 - 288337 != -213950)
																			{
																				continue;
																			}
																			skillClass.setReq(5, 1);
																			if (101424 - 439426 == -338001)
																			{
																				continue;
																			}
																			skillClass.setMP(25);
																			if (93985 - 234937 != -140952)
																			{
																				continue;
																			}
																			goto IL_2190;
																		}
																		else if (skillname == "mnk_gadina2")
																		{
																			if (24461 - 522357 != -497895)
																			{
																				goto IL_2190;
																			}
																			continue;
																		}
																		else if (skillname == "mnk_gadina3")
																		{
																			if (186063 - 347264 != -161201)
																			{
																				continue;
																			}
																		}
																		else if (skillname == "mnk_gadina4")
																		{
																			if (243739 - 593390 != -349651)
																			{
																				continue;
																			}
																			goto IL_2250;
																		}
																		else
																		{
																			if (skillname == "mnk_titanSword1")
																			{
																				if (53594 - 153918 == -100323)
																				{
																					continue;
																				}
																				skillClass.setReq(7, 2);
																				if (207338 - 155058 == 52281)
																				{
																					continue;
																				}
																			}
																			else if (skillname == "mnk_titanSword2")
																			{
																				if (281660 - 108224 == 173437)
																				{
																					continue;
																				}
																			}
																			else if (skillname == "mnk_titanSword3")
																			{
																				if (248546 - 255880 != -7334)
																				{
																					continue;
																				}
																				goto IL_926;
																			}
																			else if (skillname == "mnk_planetBreaker1")
																			{
																				if (139193 - 471763 != -332570)
																				{
																					continue;
																				}
																				skillClass.setReq(31, 8);
																				if (263502 - 407584 == -144081)
																				{
																					continue;
																				}
																				skillClass.setSP(-35);
																				if (18502 - 131308 == -112805)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.instant;
																				if (77212 - 2547 != 74665)
																				{
																					continue;
																				}
																				skillClass.target = eSkillTarget.enemy;
																				if (231322 - 373214 == -141891)
																				{
																					continue;
																				}
																				skillClass.cType = "planetBreaker";
																				if (125258 - 315409 != -190150)
																				{
																					break;
																				}
																				continue;
																			}
																			else
																			{
																				if (skillname == "mnk_aegisOfEarth1")
																				{
																					if (175782 - 536818 != -361036)
																					{
																						continue;
																					}
																					skillClass.setReq(9, 3);
																					if (263048 - 273544 != -10496)
																					{
																						continue;
																					}
																					goto IL_29EE;
																				}
																				else if (skillname == "mnk_aegisOfEarth2")
																				{
																					if (41249 - 292151 != -250902)
																					{
																						continue;
																					}
																					goto IL_29EE;
																				}
																				else if (skillname == "mnk_aegisOfEarth3")
																				{
																					if (137148 - 300080 == -162931)
																					{
																						continue;
																					}
																				}
																				else if (skillname == "mnk_titanicEarthPulse1")
																				{
																					if (3067 - 209585 == -206517)
																					{
																						continue;
																					}
																					skillClass.setReq(33, 9);
																					if (77583 - 417155 == -339571)
																					{
																						continue;
																					}
																					skillClass.setMPSP(40, -60);
																					if (246909 - 118659 != 128250)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.instant;
																					if (228665 - 300548 == -71882)
																					{
																						continue;
																					}
																					skillClass.target = eSkillTarget.enemy;
																					if (47281 - 554929 != -507648)
																					{
																						continue;
																					}
																					skillClass.cType = "titanicEarthPulse";
																					if (13197 - 536940 != -523743)
																					{
																						continue;
																					}
																					break;
																				}
																				else
																				{
																					if (skillname == "mnk_stoneHammer1")
																					{
																						if (83458 - 201137 == -117678)
																						{
																							continue;
																						}
																						skillClass.setReq(12, 4);
																						if (99391 - 411839 == -312447)
																						{
																							continue;
																						}
																						skillClass.setMP(12);
																						if (155682 - 195565 == -39882)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "mnk_stoneHammer2")
																					{
																						if (114563 - 109197 == 5367)
																						{
																							continue;
																						}
																					}
																					else if (skillname == "mnk_stoneHammer3")
																					{
																						if (7222 - 510629 != -503407)
																						{
																							continue;
																						}
																						goto IL_21E2;
																					}
																					else if (skillname == "mnk_stoneHammer4")
																					{
																						if (32937 - 494950 != -462012)
																						{
																							goto IL_2F6C;
																						}
																						continue;
																					}
																					else
																					{
																						if (skillname == "mnk_buitenHouHou1")
																						{
																							if (229848 - 130220 == 99629)
																							{
																								continue;
																							}
																							skillClass.setReq(17, 6);
																							if (237197 - 53723 != 183474)
																							{
																								continue;
																							}
																							skillClass.setMP(24);
																							if (253915 - 202978 == 50938)
																							{
																								continue;
																							}
																						}
																						else if (skillname == "mnk_buitenHouHou2")
																						{
																							if (231295 - 284948 == -53652)
																							{
																								continue;
																							}
																						}
																						else if (skillname == "mnk_buitenHouHou3")
																						{
																							if (113951 - 525474 != -411523)
																							{
																								continue;
																							}
																							goto IL_2BA7;
																						}
																						else if (skillname == "mnk_buitenHouHou4")
																						{
																							if (98166 - 548 != 97618)
																							{
																								continue;
																							}
																							goto IL_16AF;
																						}
																						else
																						{
																							if (skillname == "mnk_earthRune1")
																							{
																								if (141272 - 303183 != -161911)
																								{
																									continue;
																								}
																								skillClass.setReq(22, 12);
																								if (53720 - 146528 != -92807)
																								{
																									goto IL_348C;
																								}
																								continue;
																							}
																							else if (skillname == "mnk_earthRune2")
																							{
																								if (56318 - 375729 != -319410)
																								{
																									goto IL_348C;
																								}
																								continue;
																							}
																							else if (skillname == "mnk_earthRune3")
																							{
																								if (67678 - 569798 == -502119)
																								{
																									continue;
																								}
																							}
																							else if (skillname == "mnk_runicSand1")
																							{
																								if (196806 - 572448 != -375642)
																								{
																									continue;
																								}
																								skillClass.setReq(40, 24);
																								if (22597 - 141246 == -118648)
																								{
																									continue;
																								}
																								skillClass.setMP(30);
																								if (93281 - 59992 == 33290)
																								{
																									continue;
																								}
																								skillClass.mode = eSkillMode.instant;
																								if (12977 - 323216 == -310238)
																								{
																									continue;
																								}
																								skillClass.target = eSkillTarget.self;
																								if (133779 - 526940 == -393160)
																								{
																									continue;
																								}
																								skillClass.cType = "runicSand";
																								if (146163 - 178874 != -32710)
																								{
																									break;
																								}
																								continue;
																							}
																							else
																							{
																								if (skillname == "mnk_lavu1")
																								{
																									if (34487 - 411176 == -376688)
																									{
																										continue;
																									}
																									skillClass.setReq(35, 23);
																									if (135871 - 204 == 135668)
																									{
																										continue;
																									}
																									skillClass.setMPSP(100, -75);
																									if (14576 - 569718 != -555142)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "mnk_lavu2")
																								{
																									if (258831 - 195319 == 63513)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "mnk_mikeBlink5")
																								{
																									if (46177 - 215692 != -169515)
																									{
																										continue;
																									}
																									skillClass.setReq(55, 0);
																									if (286002 - 559867 != -273865)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (49849 - 409341 != -359492)
																									{
																										continue;
																									}
																									skillClass.rSkill = 103;
																									if (280026 - 326908 != -46881)
																									{
																										break;
																									}
																									continue;
																								}
																								else if (skillname == "mnk_mikeCircle5")
																								{
																									if (141049 - 116193 == 24857)
																									{
																										continue;
																									}
																									skillClass.setReq(60, 1);
																									if (183353 - 7296 == 176058)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (41349 - 33655 != 7694)
																									{
																										continue;
																									}
																									skillClass.rSkill = 114;
																									if (215169 - 495928 != -280759)
																									{
																										continue;
																									}
																									break;
																								}
																								else if (skillname == "mnk_summonSoul5")
																								{
																									if (47080 - 287260 == -240179)
																									{
																										continue;
																									}
																									skillClass.setReq(70, 3);
																									if (94228 - 71703 == 22526)
																									{
																										continue;
																									}
																									skillClass.setMPSP(10, -30);
																									if (7975 - 45515 != -37540)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.target;
																									if (77417 - 122834 != -45417)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.ally;
																									if (216677 - 287421 == -70743)
																									{
																										continue;
																									}
																									skillClass.cType = "summonSoul";
																									if (203353 - 140612 == 62742)
																									{
																										continue;
																									}
																									skillClass.rSkill = 124;
																									if (249009 - 155409 != 93601)
																									{
																										break;
																									}
																									continue;
																								}
																								else if (skillname == "mnk_autoInstant5")
																								{
																									if (88505 - 281556 != -193051)
																									{
																										continue;
																									}
																									skillClass.setReq(75, 4);
																									if (187378 - 543459 == -356080)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (169317 - 84614 != 84703)
																									{
																										continue;
																									}
																									skillClass.rSkill = 132;
																									if (116343 - 45684 != 70659)
																									{
																										continue;
																									}
																									break;
																								}
																								else if (skillname == "mnk_superStatPlus5")
																								{
																									if (96185 - 30513 != 65672)
																									{
																										continue;
																									}
																									skillClass.setReq(85, 6);
																									if (187653 - 196632 != -8979)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (252016 - 287790 == -35773)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.self;
																									if (85310 - 565229 == -479918)
																									{
																										continue;
																									}
																									skillClass.rSkill = 144;
																									if (173388 - 434226 != -260838)
																									{
																										continue;
																									}
																									break;
																								}
																								else if (skillname == "mnk_fireKeep5")
																								{
																									if (17231 - 129689 == -112457)
																									{
																										continue;
																									}
																									skillClass.setReq(55, 0);
																									if (52474 - 300632 != -248158)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (2001 - 52664 == -50662)
																									{
																										continue;
																									}
																									skillClass.rSkill = 204;
																									if (74948 - 350927 != -275979)
																									{
																										continue;
																									}
																									break;
																								}
																								else if (skillname == "mnk_instantBlaze5")
																								{
																									if (176575 - 35752 == 140824)
																									{
																										continue;
																									}
																									skillClass.setReq(60, 1);
																									if (39294 - 511586 == -472291)
																									{
																										continue;
																									}
																									skillClass.setMPSP(12, -12);
																									if (102510 - 170078 != -67568)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.instant;
																									if (11379 - 344121 != -332742)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.self;
																									if (246341 - 274085 == -27743)
																									{
																										continue;
																									}
																									skillClass.cType = "instantBlaze";
																									if (207416 - 493136 == -285719)
																									{
																										continue;
																									}
																									skillClass.rSkill = 214;
																									if (243875 - 355626 != -111750)
																									{
																										break;
																									}
																									continue;
																								}
																								else if (skillname == "mnk_fireSoul5")
																								{
																									if (92432 - 160158 == -67725)
																									{
																										continue;
																									}
																									skillClass.setReq(70, 3);
																									if (122311 - 91598 == 30714)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (10108 - 364415 != -354307)
																									{
																										continue;
																									}
																									skillClass.rSkill = 224;
																									if (121622 - 256220 != -134597)
																									{
																										break;
																									}
																									continue;
																								}
																								else if (skillname == "mnk_fireAvatar5")
																								{
																									if (293960 - 513646 == -219685)
																									{
																										continue;
																									}
																									skillClass.setReq(75, 4);
																									if (47598 - 53164 == -5565)
																									{
																										continue;
																									}
																									skillClass.setMPSP(140, -60);
																									if (162631 - 181567 != -18936)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.instant;
																									if (245397 - 227920 == 17478)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.self;
																									if (292174 - 51895 != 240279)
																									{
																										continue;
																									}
																									skillClass.cType = "fireAvatar";
																									if (57235 - 213978 != -156743)
																									{
																										continue;
																									}
																									skillClass.rSkill = 234;
																									if (210562 - 132536 != 78027)
																									{
																										break;
																									}
																									continue;
																								}
																								else if (skillname == "mnk_blazingFire5")
																								{
																									if (155094 - 168436 == -13341)
																									{
																										continue;
																									}
																									skillClass.setReq(85, 6);
																									if (228479 - 304434 == -75954)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (140955 - 289477 == -148521)
																									{
																										continue;
																									}
																									skillClass.rSkill = 244;
																									if (206921 - 327012 != -120091)
																									{
																										continue;
																									}
																									break;
																								}
																								else if (skillname == "mnk_secondStone5")
																								{
																									if (145913 - 210586 != -64673)
																									{
																										continue;
																									}
																									skillClass.setReq(55, 0);
																									if (40041 - 164749 != -124708)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (115823 - 56518 != 59305)
																									{
																										continue;
																									}
																									skillClass.rSkill = 304;
																									if (263848 - 121127 != 142722)
																									{
																										break;
																									}
																									continue;
																								}
																								else if (skillname == "mnk_earthGuard5")
																								{
																									if (62748 - 525902 != -463154)
																									{
																										continue;
																									}
																									skillClass.setReq(60, 1);
																									if (299244 - 354198 != -54954)
																									{
																										continue;
																									}
																									skillClass.setMPSP(15, -15);
																									if (206634 - 359895 == -153260)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.instant;
																									if (250629 - 459849 != -209220)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.self;
																									if (175713 - 428455 == -252741)
																									{
																										continue;
																									}
																									skillClass.cType = "earthGuard";
																									if (106956 - 166318 != -59362)
																									{
																										continue;
																									}
																									skillClass.rSkill = 314;
																									if (260909 - 381344 != -120435)
																									{
																										continue;
																									}
																									break;
																								}
																								else if (skillname == "mnk_earthSoul5")
																								{
																									if (129657 - 351110 == -221452)
																									{
																										continue;
																									}
																									skillClass.setReq(70, 3);
																									if (170761 - 524698 != -353937)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (78914 - 244571 == -165656)
																									{
																										continue;
																									}
																									skillClass.rSkill = 324;
																									if (70021 - 453676 != -383654)
																									{
																										break;
																									}
																									continue;
																								}
																								else if (skillname == "mnk_earthForm5")
																								{
																									if (206954 - 321496 == -114541)
																									{
																										continue;
																									}
																									skillClass.setReq(75, 4);
																									if (161266 - 577688 != -416422)
																									{
																										continue;
																									}
																									skillClass.setMPSP(100, -75);
																									if (188734 - 454493 == -265758)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.instant;
																									if (150601 - 186078 != -35477)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.self;
																									if (61318 - 412412 != -351094)
																									{
																										continue;
																									}
																									skillClass.cType = "earthForm";
																									if (225496 - 254177 != -28681)
																									{
																										continue;
																									}
																									skillClass.rSkill = 334;
																									if (167489 - 105157 != 62333)
																									{
																										break;
																									}
																									continue;
																								}
																								else if (skillname == "mnk_stoneSentinel5")
																								{
																									if (223398 - 199739 != 23659)
																									{
																										continue;
																									}
																									skillClass.setReq(85, 6);
																									if (232300 - 245615 != -13315)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (181812 - 320742 != -138930)
																									{
																										continue;
																									}
																									skillClass.rSkill = 344;
																									if (176488 - 75214 != 101274)
																									{
																										continue;
																									}
																									break;
																								}
																								else if (skillname == "mnk_revisedSkill5")
																								{
																									if (4552 - 167409 == -162856)
																									{
																										continue;
																									}
																									skillClass.setReq(55, 0);
																									if (179571 - 321223 != -141652)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (67996 - 292543 != -224547)
																									{
																										continue;
																									}
																									break;
																								}
																								else if (skillname == "mnk_revisedMagic5")
																								{
																									if (80772 - 185044 != -104272)
																									{
																										continue;
																									}
																									skillClass.setReq(60, 1);
																									if (248744 - 578569 != -329825)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (111044 - 346403 != -235358)
																									{
																										break;
																									}
																									continue;
																								}
																								else if (skillname == "mnk_revisedArt5")
																								{
																									if (105815 - 48911 != 56904)
																									{
																										continue;
																									}
																									skillClass.setReq(70, 3);
																									if (119435 - 225904 != -106469)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.passive;
																									if (279173 - 492230 != -213057)
																									{
																										continue;
																									}
																									break;
																								}
																								else if (skillname == "mnk_volcanicEruption5")
																								{
																									if (7644 - 138992 != -131348)
																									{
																										continue;
																									}
																									skillClass.setReq(75, 4);
																									if (265190 - 498920 != -233730)
																									{
																										continue;
																									}
																									skillClass.setMPSP(150, -50);
																									if (20923 - 404521 != -383598)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.target;
																									if (229929 - 8065 != 221864)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.enemy;
																									if (219138 - 510132 == -290993)
																									{
																										continue;
																									}
																									skillClass.cType = "volcanicEruption";
																									if (147011 - 137673 == 9339)
																									{
																										continue;
																									}
																									skillClass.rSkill = 261361;
																									if (22039 - 580727 != -558688)
																									{
																										continue;
																									}
																									break;
																								}
																								else
																								{
																									if (!(skillname == "mnk_summonGaos5"))
																									{
																										break;
																									}
																									if (188794 - 464093 == -275298)
																									{
																										continue;
																									}
																									skillClass.setReq(85, 6);
																									if (279471 - 359977 == -80505)
																									{
																										continue;
																									}
																									skillClass.setMPSP(300, -50);
																									if (204007 - 363525 == -159517)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.instant;
																									if (150466 - 372857 != -222391)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.self;
																									if (175338 - 87547 != 87791)
																									{
																										continue;
																									}
																									skillClass.cType = "summonGaos";
																									if (25382 - 286736 == -261353)
																									{
																										continue;
																									}
																									skillClass.rSkill = 434;
																									if (1622 - 194136 != -192514)
																									{
																										continue;
																									}
																									break;
																								}
																								skillClass.setReq(40, 25);
																								if (184157 - 422379 == -238221)
																								{
																									continue;
																								}
																								skillClass.setMPSP(150, -75);
																								if (270060 - 201483 == 68578)
																								{
																									continue;
																								}
																								skillClass.mode = eSkillMode.instant;
																								if (233245 - 441690 == -208444)
																								{
																									continue;
																								}
																								skillClass.target = eSkillTarget.self;
																								if (161717 - 11729 == 149989)
																								{
																									continue;
																								}
																								skillClass.cType = "lavu";
																								if (178400 - 556374 != -377973)
																								{
																									break;
																								}
																								continue;
																							}
																							IL_2FF8:
																							skillClass.setReq(34, 20);
																							if (14966 - 113099 == -98132)
																							{
																								continue;
																							}
																							skillClass.mode = eSkillMode.passive;
																							if (239300 - 549699 != -310398)
																							{
																								break;
																							}
																							continue;
																							IL_348C:
																							skillClass.setReq(28, 16);
																							if (207784 - 583920 != -376136)
																							{
																								continue;
																							}
																							goto IL_2FF8;
																						}
																						skillClass.setReq(24, 10);
																						if (189968 - 373869 != -183901)
																						{
																							continue;
																						}
																						skillClass.setMP(38);
																						if (110723 - 92612 == 18112)
																						{
																							continue;
																						}
																						IL_2BA7:
																						skillClass.setReq(31, 14);
																						if (106577 - 493170 != -386593)
																						{
																							continue;
																						}
																						skillClass.setMP(52);
																						if (176773 - 224618 != -47845)
																						{
																							continue;
																						}
																						IL_16AF:
																						skillClass.setReq(38, 18);
																						if (228252 - 430058 != -201806)
																						{
																							continue;
																						}
																						skillClass.setMP(66);
																						if (221808 - 175190 == 46619)
																						{
																							continue;
																						}
																						skillClass.mode = eSkillMode.instant;
																						if (288611 - 294821 == -6209)
																						{
																							continue;
																						}
																						skillClass.target = eSkillTarget.self;
																						if (280903 - 209502 != 71401)
																						{
																							continue;
																						}
																						skillClass.cType = "buiten";
																						if (193558 - 551760 != -358201)
																						{
																							break;
																						}
																						continue;
																					}
																					skillClass.setReq(20, 8);
																					if (237262 - 447051 != -209789)
																					{
																						continue;
																					}
																					skillClass.setMP(20);
																					if (296797 - 301515 == -4717)
																					{
																						continue;
																					}
																					IL_21E2:
																					skillClass.setReq(28, 12);
																					if (276467 - 379915 == -103447)
																					{
																						continue;
																					}
																					skillClass.setMP(28);
																					if (229694 - 277008 != -47314)
																					{
																						continue;
																					}
																					IL_2F6C:
																					skillClass.setReq(36, 16);
																					if (2827 - 459626 == -456798)
																					{
																						continue;
																					}
																					skillClass.setMP(36);
																					if (104745 - 53193 == 51553)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.target;
																					if (54157 - 240503 == -186345)
																					{
																						continue;
																					}
																					skillClass.target = eSkillTarget.enemy;
																					if (173339 - 27667 != 145672)
																					{
																						continue;
																					}
																					skillClass.cType = "stoneHammer";
																					if (208193 - 279714 != -71521)
																					{
																						continue;
																					}
																					break;
																				}
																				IL_1FA8:
																				skillClass.setReq(25, 7);
																				if (2838 - 121417 == -118578)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.passive;
																				if (125565 - 18854 != 106711)
																				{
																					continue;
																				}
																				break;
																				IL_29EE:
																				skillClass.setReq(17, 5);
																				if (210099 - 20978 != 189121)
																				{
																					continue;
																				}
																				goto IL_1FA8;
																			}
																			skillClass.setReq(15, 4);
																			if (247033 - 556952 == -309918)
																			{
																				continue;
																			}
																			IL_926:
																			skillClass.setReq(23, 6);
																			if (20669 - 281279 != -260610)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.passive;
																			if (173608 - 373291 != -199682)
																			{
																				break;
																			}
																			continue;
																		}
																		IL_1D26:
																		skillClass.setReq(21, 5);
																		if (131602 - 522338 != -390736)
																		{
																			continue;
																		}
																		skillClass.setMP(65);
																		if (229385 - 499321 != -269935)
																		{
																			goto IL_2250;
																		}
																		continue;
																		IL_2190:
																		skillClass.setReq(13, 3);
																		if (244751 - 134469 == 110283)
																		{
																			continue;
																		}
																		skillClass.setMP(45);
																		if (35461 - 63305 != -27843)
																		{
																			goto IL_1D26;
																		}
																		continue;
																		IL_2250:
																		skillClass.setReq(29, 7);
																		if (31649 - 133823 == -102173)
																		{
																			continue;
																		}
																		skillClass.setMP(85);
																		if (211565 - 375501 != -163936)
																		{
																			continue;
																		}
																		skillClass.mode = eSkillMode.instant;
																		if (181982 - 242634 == -60651)
																		{
																			continue;
																		}
																		skillClass.target = eSkillTarget.self;
																		if (256877 - 50928 == 205950)
																		{
																			continue;
																		}
																		skillClass.cType = "gadina";
																		if (190255 - 536975 != -346719)
																		{
																			break;
																		}
																		continue;
																	}
																	IL_18E4:
																	skillClass.setReq(27, 3);
																	if (219769 - 481604 != -261835)
																	{
																		continue;
																	}
																	skillClass.setMP(20);
																	if (271610 - 54755 != 216855)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.target;
																	if (10465 - 524506 == -514040)
																	{
																		continue;
																	}
																	skillClass.target = eSkillTarget.enemy;
																	if (168522 - 573908 == -405385)
																	{
																		continue;
																	}
																	skillClass.cType = "groundLock";
																	if (12642 - 580653 != -568010)
																	{
																		break;
																	}
																	continue;
																	IL_120F:
																	skillClass.setReq(11, 1);
																	if (266333 - 310780 != -44447)
																	{
																		continue;
																	}
																	skillClass.setMP(12);
																	if (118342 - 399029 == -280686)
																	{
																		continue;
																	}
																	IL_3469:
																	skillClass.setReq(19, 2);
																	if (238988 - 290096 == -51107)
																	{
																		continue;
																	}
																	skillClass.setMP(16);
																	if (126473 - 520577 != -394103)
																	{
																		goto IL_18E4;
																	}
																	continue;
																}
																skillClass.setReq(40, 25);
																if (232192 - 168000 != 64192)
																{
																	continue;
																}
																skillClass.setMPSP(60, -35);
																if (248455 - 24052 == 224404)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.target;
																if (107814 - 352632 == -244817)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.enemy;
																if (194427 - 588835 != -394408)
																{
																	continue;
																}
																skillClass.cType = "worldIgnition";
																if (32767 - 576702 != -543935)
																{
																	continue;
																}
																break;
															}
															IL_1836:
															skillClass.setReq(34, 20);
															if (109001 - 555184 == -446182)
															{
																continue;
															}
															skillClass.mode = eSkillMode.passive;
															if (140466 - 126884 != 13582)
															{
																continue;
															}
															break;
															IL_3695:
															skillClass.setReq(28, 16);
															if (106490 - 544486 != -437995)
															{
																goto IL_1836;
															}
															continue;
														}
														IL_6E:
														skillClass.setReq(31, 14);
														if (202610 - 386899 == -184288)
														{
															continue;
														}
														skillClass.setMP(45);
														if (15671 - 319303 != -303632)
														{
															continue;
														}
														goto IL_2EF6;
														IL_2764:
														skillClass.setReq(24, 10);
														if (160170 - 314310 != -154140)
														{
															continue;
														}
														skillClass.setMP(30);
														if (150394 - 239439 != -89044)
														{
															goto IL_6E;
														}
														continue;
														IL_2EF6:
														skillClass.setReq(38, 18);
														if (99962 - 429280 == -329317)
														{
															continue;
														}
														skillClass.setMP(60);
														if (230051 - 584337 != -354286)
														{
															continue;
														}
														skillClass.mode = eSkillMode.instant;
														if (84343 - 595356 == -511012)
														{
															continue;
														}
														skillClass.target = eSkillTarget.self;
														if (269944 - 247834 != 22110)
														{
															continue;
														}
														skillClass.cType = "ja";
														if (292436 - 485160 != -192724)
														{
															continue;
														}
														break;
													}
													IL_607:
													skillClass.setReq(28, 12);
													if (212307 - 293937 == -81629)
													{
														continue;
													}
													skillClass.setMPSP(40, -20);
													if (266695 - 34691 != 232005)
													{
														goto IL_2DE2;
													}
													continue;
													IL_88F:
													skillClass.setReq(20, 8);
													if (28602 - 221611 == -193008)
													{
														continue;
													}
													skillClass.setMPSP(32, -16);
													if (60060 - 244738 != -184677)
													{
														goto IL_607;
													}
													continue;
													IL_2DE2:
													skillClass.setReq(36, 16);
													if (32796 - 406665 != -373869)
													{
														continue;
													}
													skillClass.setMPSP(48, -24);
													if (293347 - 11792 == 281556)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (70087 - 197019 != -126932)
													{
														continue;
													}
													skillClass.target = eSkillTarget.enemy;
													if (26117 - 212473 == -186355)
													{
														continue;
													}
													skillClass.cType = "flashFire";
													if (237676 - 341605 != -103928)
													{
														break;
													}
													continue;
												}
												skillClass.setReq(17, 5);
												if (219163 - 230058 == -10894)
												{
													continue;
												}
												IL_133C:
												skillClass.setReq(25, 7);
												if (255261 - 292787 == -37525)
												{
													continue;
												}
												skillClass.mode = eSkillMode.passive;
												if (207577 - 594879 != -387302)
												{
													continue;
												}
												break;
											}
											skillClass.setReq(15, 4);
											if (75931 - 472909 != -396978)
											{
												continue;
											}
											IL_3223:
											skillClass.setReq(23, 6);
											if (196561 - 211485 != -14924)
											{
												continue;
											}
											skillClass.mode = eSkillMode.passive;
											if (122312 - 46709 != 75603)
											{
												continue;
											}
											break;
										}
										IL_12F8:
										skillClass.setReq(29, 7);
										if (166547 - 114711 != 51836)
										{
											continue;
										}
										skillClass.setMP(70);
										if (139743 - 33225 == 106519)
										{
											continue;
										}
										skillClass.mode = eSkillMode.instant;
										if (163800 - 17365 != 146435)
										{
											continue;
										}
										skillClass.target = eSkillTarget.self;
										if (97214 - 553589 == -456374)
										{
											continue;
										}
										skillClass.cType = "phoenix";
										if (201721 - 206589 != -4868)
										{
											continue;
										}
										break;
										IL_159B:
										skillClass.setReq(13, 3);
										if (164124 - 350605 == -186480)
										{
											continue;
										}
										skillClass.setMP(40);
										if (17230 - 558968 == -541737)
										{
											continue;
										}
										IL_2D9C:
										skillClass.setReq(21, 5);
										if (126526 - 238897 == -112370)
										{
											continue;
										}
										skillClass.setMP(55);
										if (84759 - 530485 != -445726)
										{
											continue;
										}
										goto IL_12F8;
									}
									IL_18C1:
									skillClass.setReq(19, 2);
									if (234939 - 576691 != -341752)
									{
										continue;
									}
									skillClass.setMP(19);
									if (228238 - 488723 != -260485)
									{
										continue;
									}
									goto IL_2273;
									IL_35A1:
									skillClass.setReq(11, 1);
									if (28832 - 161463 != -132631)
									{
										continue;
									}
									skillClass.setMP(14);
									if (137331 - 434238 != -296907)
									{
										continue;
									}
									goto IL_18C1;
									IL_2273:
									skillClass.setReq(27, 3);
									if (211596 - 255351 != -43755)
									{
										continue;
									}
									skillClass.setMP(24);
									if (4245 - 127575 != -123330)
									{
										continue;
									}
									skillClass.mode = eSkillMode.instant;
									if (65450 - 486896 != -421446)
									{
										continue;
									}
									skillClass.target = eSkillTarget.enemy;
									if (73622 - 467077 != -393455)
									{
										continue;
									}
									skillClass.cType = "fireBall";
									if (37483 - 434807 != -397324)
									{
										continue;
									}
									break;
								}
								IL_A65:
								skillClass.setReq(40, 10);
								if (192236 - 3504 == 188733)
								{
									continue;
								}
								skillClass.mode = eSkillMode.passive;
								if (266233 - 42229 == 224005)
								{
									continue;
								}
								skillClass.target = eSkillTarget.self;
								if (58043 - 411668 != -353625)
								{
									continue;
								}
								break;
								IL_28F0:
								skillClass.setReq(30, 8);
								if (244727 - 433663 != -188936)
								{
									continue;
								}
								goto IL_A65;
								IL_2EB1:
								skillClass.setReq(20, 6);
								if (57024 - 416700 != -359676)
								{
									continue;
								}
								goto IL_28F0;
							}
							skillClass.setReq(40, 10);
							if (57450 - 344047 != -286597)
							{
								continue;
							}
							skillClass.setMPSP(40, -20);
							if (18186 - 35055 != -16869)
							{
								continue;
							}
							skillClass.mode = eSkillMode.instant;
							if (144256 - 195146 != -50890)
							{
								continue;
							}
							skillClass.target = eSkillTarget.self;
							if (288693 - 159452 != 129241)
							{
								continue;
							}
							skillClass.cType = "instantCast";
							if (127610 - 175289 != -47678)
							{
								break;
							}
							continue;
						}
						skillClass.setReq(10, 2);
						if (133479 - 519381 != -385901)
						{
							goto IL_2F90;
						}
						continue;
						IL_1974:
						skillClass.setReq(22, 4);
						if (156399 - 82325 == 74075)
						{
							continue;
						}
						skillClass.mode = eSkillMode.passive;
						if (48894 - 5724 == 43171)
						{
							continue;
						}
						skillClass.target = eSkillTarget.enemy;
						if (159933 - 245020 == -85086)
						{
							continue;
						}
						skillClass.cType = "cAttack";
						if (218231 - 531500 != -313269)
						{
							continue;
						}
						break;
						IL_2F90:
						skillClass.setReq(16, 3);
						if (18374 - 298995 != -280620)
						{
							goto IL_1974;
						}
						continue;
					}
					skillClass.setReq(3, 2);
					if (139728 - 103843 != 35886)
					{
						skillClass.mode = eSkillMode.passive;
						if (88955 - 520052 != -431096)
						{
							break;
						}
					}
				}
			}
		}
		return skillClass;
	}

	// Token: 0x06002A1D RID: 10781 RVA: 0x0051DB98 File Offset: 0x0051BD98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillTree(int commandNum)
	{
		if (265472 - 323817 != -58345)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (183482 - 125732 != 57751)
			{
				if (67337 - 127496 == -60159)
				{
					if (commandNum == 101)
					{
						if (265764 - 251345 != 14420)
						{
							result = "mnk_nAttack1";
							if (125763 - 450299 != -324535)
							{
								break;
							}
						}
					}
					else if (commandNum == 102)
					{
						if (276433 - 25967 != 250467)
						{
							result = "mnk_damageCast1";
							if (291622 - 31970 == 259652)
							{
								break;
							}
						}
					}
					else if (commandNum == 103)
					{
						if (177104 - 377542 == -200438)
						{
							result = "mnk_damageCast2";
							if (74138 - 377876 == -303738)
							{
								break;
							}
						}
					}
					else if (commandNum == 111)
					{
						if (182042 - 435471 == -253429)
						{
							result = "mnk_cAttack1";
							if (228648 - 543127 == -314479)
							{
								break;
							}
						}
					}
					else if (commandNum == 112)
					{
						if (82899 - 256546 != -173646)
						{
							result = "mnk_cAttack2";
							if (279303 - 162966 != 116338)
							{
								break;
							}
						}
					}
					else if (commandNum == 113)
					{
						if (286655 - 403207 == -116552)
						{
							result = "mnk_cAttack3";
							if (224091 - 404518 == -180427)
							{
								break;
							}
						}
					}
					else if (commandNum == 114)
					{
						if (15240 - 284851 != -269610)
						{
							result = "mnk_cAttack4";
							if (210409 - 422569 != -212159)
							{
								break;
							}
						}
					}
					else if (commandNum == 121)
					{
						if (121022 - 415866 == -294844)
						{
							result = "mnk_summonAttack";
							if (46605 - 256570 != -209964)
							{
								break;
							}
						}
					}
					else if (commandNum == 122)
					{
						if (213083 - 438814 == -225731)
						{
							result = "mnk_summonDefense";
							if (142218 - 252317 != -110098)
							{
								break;
							}
						}
					}
					else if (commandNum == 123)
					{
						if (37019 - 316854 != -279834)
						{
							result = "mnk_unsummon";
							if (832 - 389594 == -388762)
							{
								break;
							}
						}
					}
					else if (commandNum == 124)
					{
						if (104539 - 578116 == -473577)
						{
							result = "mnk_summonRelease";
							if (261011 - 111142 == 149869)
							{
								break;
							}
						}
					}
					else if (commandNum == 131)
					{
						if (240900 - 468594 == -227694)
						{
							result = "mnk_instantCast1";
							if (98066 - 42560 == 55506)
							{
								break;
							}
						}
					}
					else if (commandNum == 132)
					{
						if (151259 - 387096 == -235837)
						{
							result = "mnk_instantCast2";
							if (78704 - 211902 == -133198)
							{
								break;
							}
						}
					}
					else if (commandNum == 141)
					{
						if (214861 - 446090 == -231229)
						{
							result = "mnk_statPlus1";
							if (53166 - 195037 == -141871)
							{
								break;
							}
						}
					}
					else if (commandNum == 142)
					{
						if (282316 - 108075 != 174242)
						{
							result = "mnk_statPlus2";
							if (237703 - 293429 == -55726)
							{
								break;
							}
						}
					}
					else if (commandNum == 143)
					{
						if (32094 - 247702 == -215608)
						{
							result = "mnk_statPlus3";
							if (63960 - 126007 == -62047)
							{
								break;
							}
						}
					}
					else if (commandNum == 144)
					{
						if (132901 - 534977 != -402075)
						{
							result = "mnk_statPlus4";
							if (243722 - 582305 == -338583)
							{
								break;
							}
						}
					}
					else if (commandNum == 201)
					{
						if (204650 - 415058 != -210407)
						{
							result = "mnk_fireBall1";
							if (103709 - 532911 == -429202)
							{
								break;
							}
						}
					}
					else if (commandNum == 202)
					{
						if (288509 - 193082 == 95427)
						{
							result = "mnk_fireBall2";
							if (271004 - 370765 == -99761)
							{
								break;
							}
						}
					}
					else if (commandNum == 203)
					{
						if (229828 - 103569 == 126259)
						{
							result = "mnk_fireBall3";
							if (226386 - 570465 != -344078)
							{
								break;
							}
						}
					}
					else if (commandNum == 204)
					{
						if (114164 - 502173 != -388008)
						{
							result = "mnk_fireBall4";
							if (46583 - 64825 != -18241)
							{
								break;
							}
						}
					}
					else if (commandNum == 211)
					{
						if (297074 - 506989 == -209915)
						{
							result = "mnk_phoenix1";
							if (237352 - 113516 == 123836)
							{
								break;
							}
						}
					}
					else if (commandNum == 212)
					{
						if (180388 - 18194 != 162195)
						{
							result = "mnk_phoenix2";
							if (273426 - 7080 != 266347)
							{
								break;
							}
						}
					}
					else if (commandNum == 213)
					{
						if (224612 - 451967 != -227354)
						{
							result = "mnk_phoenix3";
							if (110723 - 436227 == -325504)
							{
								break;
							}
						}
					}
					else if (commandNum == 214)
					{
						if (262622 - 225104 == 37518)
						{
							result = "mnk_phoenix4";
							if (244748 - 540466 != -295717)
							{
								break;
							}
						}
					}
					else if (commandNum == 221)
					{
						if (264673 - 526703 == -262030)
						{
							result = "mnk_rapidFire1";
							if (67437 - 32489 == 34948)
							{
								break;
							}
						}
					}
					else if (commandNum == 222)
					{
						if (279803 - 429157 != -149353)
						{
							result = "mnk_rapidFire2";
							if (154298 - 181662 != -27363)
							{
								break;
							}
						}
					}
					else if (commandNum == 223)
					{
						if (110348 - 309391 != -199042)
						{
							result = "mnk_rapidFire3";
							if (243971 - 523289 == -279318)
							{
								break;
							}
						}
					}
					else if (commandNum == 224)
					{
						if (104555 - 26054 != 78502)
						{
							result = "mnk_skyCrimson1";
							if (133670 - 558057 == -424387)
							{
								break;
							}
						}
					}
					else if (commandNum == 231)
					{
						if (145179 - 331568 != -186388)
						{
							result = "mnk_intenseFire1";
							if (278500 - 302201 == -23701)
							{
								break;
							}
						}
					}
					else if (commandNum == 232)
					{
						if (104477 - 336078 == -231601)
						{
							result = "mnk_intenseFire2";
							if (298180 - 368905 == -70725)
							{
								break;
							}
						}
					}
					else if (commandNum == 233)
					{
						if (217972 - 488311 != -270338)
						{
							result = "mnk_intenseFire3";
							if (166312 - 113151 != 53162)
							{
								break;
							}
						}
					}
					else if (commandNum == 234)
					{
						if (15274 - 519537 != -504262)
						{
							result = "mnk_blazingArrow1";
							if (125860 - 83913 == 41947)
							{
								break;
							}
						}
					}
					else if (commandNum == 241)
					{
						if (94472 - 33585 == 60887)
						{
							result = "mnk_flashFire1";
							if (213736 - 20725 != 193012)
							{
								break;
							}
						}
					}
					else if (commandNum == 242)
					{
						if (44441 - 320712 == -276271)
						{
							result = "mnk_flashFire2";
							if (174484 - 493764 != -319279)
							{
								break;
							}
						}
					}
					else if (commandNum == 243)
					{
						if (124515 - 510969 == -386454)
						{
							result = "mnk_flashFire3";
							if (218962 - 502244 != -283281)
							{
								break;
							}
						}
					}
					else if (commandNum == 244)
					{
						if (137955 - 15137 != 122819)
						{
							result = "mnk_flashFire4";
							if (110239 - 555738 == -445499)
							{
								break;
							}
						}
					}
					else if (commandNum == 251)
					{
						if (268938 - 102163 != 166776)
						{
							result = "mnk_ja1";
							if (56736 - 76902 != -20165)
							{
								break;
							}
						}
					}
					else if (commandNum == 252)
					{
						if (211457 - 500857 == -289400)
						{
							result = "mnk_ja2";
							if (33861 - 82639 == -48778)
							{
								break;
							}
						}
					}
					else if (commandNum == 253)
					{
						if (136740 - 154420 != -17679)
						{
							result = "mnk_ja3";
							if (190567 - 404761 != -214193)
							{
								break;
							}
						}
					}
					else if (commandNum == 254)
					{
						if (134410 - 79588 == 54822)
						{
							result = "mnk_ja4";
							if (234382 - 97989 != 136394)
							{
								break;
							}
						}
					}
					else if (commandNum == 261)
					{
						if (238513 - 34778 == 203735)
						{
							result = "mnk_fireRune1";
							if (106393 - 489258 != -382864)
							{
								break;
							}
						}
					}
					else if (commandNum == 262)
					{
						if (271341 - 553549 != -282207)
						{
							result = "mnk_fireRune2";
							if (135859 - 487300 != -351440)
							{
								break;
							}
						}
					}
					else if (commandNum == 263)
					{
						if (83500 - 158151 != -74650)
						{
							result = "mnk_fireRune3";
							if (60848 - 270032 == -209184)
							{
								break;
							}
						}
					}
					else if (commandNum == 264)
					{
						if (250120 - 306668 == -56548)
						{
							result = "mnk_runicFlame1";
							if (226018 - 246307 != -20288)
							{
								break;
							}
						}
					}
					else if (commandNum == 271)
					{
						if (280711 - 511540 != -230828)
						{
							result = "mnk_worldIgnition1";
							if (271274 - 213097 != 58178)
							{
								break;
							}
						}
					}
					else if (commandNum == 272)
					{
						if (211785 - 422572 == -210787)
						{
							result = "mnk_worldIgnition2";
							if (124201 - 52831 == 71370)
							{
								break;
							}
						}
					}
					else if (commandNum == 301)
					{
						if (244314 - 207759 == 36555)
						{
							result = "mnk_groundLock1";
							if (12088 - 1704 != 10385)
							{
								break;
							}
						}
					}
					else if (commandNum == 302)
					{
						if (217332 - 129123 != 88210)
						{
							result = "mnk_groundLock2";
							if (112852 - 298349 == -185497)
							{
								break;
							}
						}
					}
					else if (commandNum == 303)
					{
						if (168529 - 315700 == -147171)
						{
							result = "mnk_groundLock3";
							if (158877 - 278357 == -119480)
							{
								break;
							}
						}
					}
					else if (commandNum == 304)
					{
						if (184118 - 301110 != -116991)
						{
							result = "mnk_groundLock4";
							if (52383 - 215072 == -162689)
							{
								break;
							}
						}
					}
					else if (commandNum == 311)
					{
						if (4909 - 414330 != -409420)
						{
							result = "mnk_gadina1";
							if (101031 - 503532 == -402501)
							{
								break;
							}
						}
					}
					else if (commandNum == 312)
					{
						if (120782 - 311783 != -191000)
						{
							result = "mnk_gadina2";
							if (274717 - 16235 == 258482)
							{
								break;
							}
						}
					}
					else if (commandNum == 313)
					{
						if (292704 - 273954 == 18750)
						{
							result = "mnk_gadina3";
							if (282460 - 135988 != 146473)
							{
								break;
							}
						}
					}
					else if (commandNum == 314)
					{
						if (215623 - 7132 != 208492)
						{
							result = "mnk_gadina4";
							if (243451 - 310774 != -67322)
							{
								break;
							}
						}
					}
					else if (commandNum == 321)
					{
						if (71677 - 16570 == 55107)
						{
							result = "mnk_titanSword1";
							if (230589 - 402135 != -171545)
							{
								break;
							}
						}
					}
					else if (commandNum == 322)
					{
						if (116734 - 301108 != -184373)
						{
							result = "mnk_titanSword2";
							if (43369 - 375938 == -332569)
							{
								break;
							}
						}
					}
					else if (commandNum == 323)
					{
						if (6823 - 115126 == -108303)
						{
							result = "mnk_titanSword3";
							if (199818 - 137791 == 62027)
							{
								break;
							}
						}
					}
					else if (commandNum == 324)
					{
						if (65329 - 324036 == -258707)
						{
							result = "mnk_planetBreaker1";
							if (10368 - 463250 == -452882)
							{
								break;
							}
						}
					}
					else if (commandNum == 331)
					{
						if (199423 - 235732 != -36308)
						{
							result = "mnk_aegisOfEarth1";
							if (270234 - 100900 == 169334)
							{
								break;
							}
						}
					}
					else if (commandNum == 332)
					{
						if (156110 - 411116 == -255006)
						{
							result = "mnk_aegisOfEarth2";
							if (168153 - 443711 == -275558)
							{
								break;
							}
						}
					}
					else if (commandNum == 333)
					{
						if (79001 - 82904 != -3902)
						{
							result = "mnk_aegisOfEarth3";
							if (255207 - 476243 != -221035)
							{
								break;
							}
						}
					}
					else if (commandNum == 334)
					{
						if (31551 - 572176 != -540624)
						{
							result = "mnk_titanicEarthPulse1";
							if (46821 - 209410 == -162589)
							{
								break;
							}
						}
					}
					else if (commandNum == 341)
					{
						if (15710 - 323234 == -307524)
						{
							result = "mnk_stoneHammer1";
							if (139504 - 161726 != -22221)
							{
								break;
							}
						}
					}
					else if (commandNum == 342)
					{
						if (86522 - 236556 == -150034)
						{
							result = "mnk_stoneHammer2";
							if (132989 - 339501 != -206511)
							{
								break;
							}
						}
					}
					else if (commandNum == 343)
					{
						if (3096 - 406808 == -403712)
						{
							result = "mnk_stoneHammer3";
							if (275215 - 475726 == -200511)
							{
								break;
							}
						}
					}
					else if (commandNum == 344)
					{
						if (216 - 90149 == -89933)
						{
							result = "mnk_stoneHammer4";
							if (118758 - 74405 != 44354)
							{
								break;
							}
						}
					}
					else if (commandNum == 351)
					{
						if (292045 - 90400 == 201645)
						{
							result = "mnk_buitenHouHou1";
							if (267638 - 411169 == -143531)
							{
								break;
							}
						}
					}
					else if (commandNum == 352)
					{
						if (187266 - 248148 != -60881)
						{
							result = "mnk_buitenHouHou2";
							if (33321 - 552563 == -519242)
							{
								break;
							}
						}
					}
					else if (commandNum == 353)
					{
						if (36431 - 282110 == -245679)
						{
							result = "mnk_buitenHouHou3";
							if (126594 - 468245 == -341651)
							{
								break;
							}
						}
					}
					else if (commandNum == 354)
					{
						if (66235 - 233655 != -167419)
						{
							result = "mnk_buitenHouHou4";
							if (158308 - 348636 == -190328)
							{
								break;
							}
						}
					}
					else if (commandNum == 361)
					{
						if (223693 - 333874 != -110180)
						{
							result = "mnk_earthRune1";
							if (283127 - 216117 != 67011)
							{
								break;
							}
						}
					}
					else if (commandNum == 362)
					{
						if (252865 - 580267 != -327401)
						{
							result = "mnk_earthRune2";
							if (227699 - 109223 != 118477)
							{
								break;
							}
						}
					}
					else if (commandNum == 363)
					{
						if (187255 - 116133 != 71123)
						{
							result = "mnk_earthRune3";
							if (189998 - 247249 == -57251)
							{
								break;
							}
						}
					}
					else if (commandNum == 364)
					{
						if (227521 - 259306 != -31784)
						{
							result = "mnk_runicSand1";
							if (193297 - 196668 == -3371)
							{
								break;
							}
						}
					}
					else if (commandNum == 371)
					{
						if (83354 - 277849 != -194494)
						{
							result = "mnk_lavu1";
							if (159697 - 464565 != -304867)
							{
								break;
							}
						}
					}
					else if (commandNum == 372)
					{
						if (103624 - 534048 == -430424)
						{
							result = "mnk_lavu2";
							if (287697 - 463158 == -175461)
							{
								break;
							}
						}
					}
					else if (commandNum == 401)
					{
						if (212988 - 161882 == 51106)
						{
							result = "mnk_mikeBlink5";
							if (183993 - 96492 != 87502)
							{
								break;
							}
						}
					}
					else if (commandNum == 411)
					{
						if (4177 - 334469 == -330292)
						{
							result = "mnk_mikeCircle5";
							if (273427 - 258618 == 14809)
							{
								break;
							}
						}
					}
					else if (commandNum == 421)
					{
						if (224203 - 483799 != -259595)
						{
							result = "mnk_summonSoul5";
							if (250777 - 537853 != -287075)
							{
								break;
							}
						}
					}
					else if (commandNum == 431)
					{
						if (286056 - 513104 != -227047)
						{
							result = "mnk_autoInstant5";
							if (20386 - 122971 == -102585)
							{
								break;
							}
						}
					}
					else if (commandNum == 441)
					{
						if (208014 - 329041 == -121027)
						{
							result = "mnk_superStatPlus5";
							if (12614 - 413517 != -400902)
							{
								break;
							}
						}
					}
					else if (commandNum == 402)
					{
						if (83530 - 187623 != -104092)
						{
							result = "mnk_fireKeep5";
							if (86998 - 113604 == -26606)
							{
								break;
							}
						}
					}
					else if (commandNum == 412)
					{
						if (136000 - 504940 != -368939)
						{
							result = "mnk_instantBlaze5";
							if (71699 - 92600 != -20900)
							{
								break;
							}
						}
					}
					else if (commandNum == 422)
					{
						if (168778 - 500827 != -332048)
						{
							result = "mnk_fireSoul5";
							if (35709 - 442943 == -407234)
							{
								break;
							}
						}
					}
					else if (commandNum == 432)
					{
						if (269588 - 146623 != 122966)
						{
							result = "mnk_fireAvatar5";
							if (71199 - 446342 != -375142)
							{
								break;
							}
						}
					}
					else if (commandNum == 442)
					{
						if (207448 - 305128 == -97680)
						{
							result = "mnk_blazingFire5";
							if (205929 - 115096 == 90833)
							{
								break;
							}
						}
					}
					else if (commandNum == 403)
					{
						if (196549 - 468252 != -271702)
						{
							result = "mnk_secondStone5";
							if (249405 - 423840 != -174434)
							{
								break;
							}
						}
					}
					else if (commandNum == 413)
					{
						if (92452 - 17001 != 75452)
						{
							result = "mnk_earthGuard5";
							if (98899 - 149566 != -50666)
							{
								break;
							}
						}
					}
					else if (commandNum == 423)
					{
						if (55148 - 218847 != -163698)
						{
							result = "mnk_earthSoul5";
							if (37966 - 275825 == -237859)
							{
								break;
							}
						}
					}
					else if (commandNum == 433)
					{
						if (230815 - 474244 != -243428)
						{
							result = "mnk_earthForm5";
							if (101548 - 79336 == 22212)
							{
								break;
							}
						}
					}
					else if (commandNum == 443)
					{
						if (84309 - 106937 != -22627)
						{
							result = "mnk_stoneSentinel5";
							if (67446 - 568011 == -500565)
							{
								break;
							}
						}
					}
					else if (commandNum == 404)
					{
						if (23750 - 157752 == -134002)
						{
							result = "mnk_revisedSkill5";
							if (76073 - 280383 != -204309)
							{
								break;
							}
						}
					}
					else if (commandNum == 414)
					{
						if (252350 - 461672 != -209321)
						{
							result = "mnk_revisedMagic5";
							if (217273 - 510635 == -293362)
							{
								break;
							}
						}
					}
					else if (commandNum == 424)
					{
						if (146323 - 312176 == -165853)
						{
							result = "mnk_revisedArt5";
							if (48112 - 418787 == -370675)
							{
								break;
							}
						}
					}
					else if (commandNum == 434)
					{
						if (292993 - 383545 == -90552)
						{
							result = "mnk_volcanicEruption5";
							if (75517 - 353210 != -277692)
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
						if (131978 - 435368 != -303389)
						{
							result = "mnk_summonGaos5";
							if (162551 - 6280 == 156271)
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

	// Token: 0x06002A1E RID: 10782 RVA: 0x0051F7F8 File Offset: 0x0051D9F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002A1F RID: 10783 RVA: 0x0051F7FC File Offset: 0x0051D9FC
	internal static bool jETLDVzcj8ehZ0YffxR()
	{
		return true;
	}

	// Token: 0x06002A20 RID: 10784 RVA: 0x0051F800 File Offset: 0x0051DA00
	internal static bool y8W4bxzUrn81VEux2nK()
	{
		return false;
	}
}
