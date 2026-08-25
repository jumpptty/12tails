using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000643 RID: 1603
[Serializable]
public class ChameleonSkill : MonoBehaviour
{
	// Token: 0x06002415 RID: 9237 RVA: 0x0043EC24 File Offset: 0x0043CE24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChameleonSkill()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002416 RID: 9238 RVA: 0x0043EC34 File Offset: 0x0043CE34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSkill(string skillname)
	{
		if (25232 - 294199 != -268967)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (47671 - 293187 != -245515 && 246688 - 326096 != -79407)
			{
				if (skillname == "chm_nAttack1")
				{
					if (116812 - 448844 == -332031)
					{
						continue;
					}
					skillClass.setReq(1, 0);
					if (33995 - 38095 != -4099)
					{
						goto IL_1FBC;
					}
					continue;
				}
				else if (skillname == "chm_nAttack2")
				{
					if (61636 - 139412 != -77776)
					{
						continue;
					}
					goto IL_1FBC;
				}
				else if (skillname == "chm_nAttack3")
				{
					if (183950 - 385566 != -201616)
					{
						continue;
					}
					goto IL_2D6D;
				}
				else if (skillname == "chm_nAttack4")
				{
					if (148397 - 304650 == -156252)
					{
						continue;
					}
				}
				else
				{
					if (skillname == "chm_cAttack1")
					{
						if (176393 - 536313 == -359919)
						{
							continue;
						}
						skillClass.setReq(4, 1);
						if (163407 - 117592 != 45815)
						{
							continue;
						}
					}
					else if (skillname == "chm_cAttack2")
					{
						if (158658 - 323764 == -165105)
						{
							continue;
						}
					}
					else if (skillname == "chm_cAttack3")
					{
						if (125032 - 450356 != -325324)
						{
							continue;
						}
						goto IL_3220;
					}
					else
					{
						if (skillname == "chm_immunity1")
						{
							if (45292 - 507814 == -462521)
							{
								continue;
							}
							skillClass.setReq(6, 2);
							if (63070 - 81929 != -18859)
							{
								continue;
							}
							skillClass.setMP(3);
							if (106802 - 595332 != -488530)
							{
								continue;
							}
						}
						else if (skillname == "chm_immunity2")
						{
							if (551 - 150191 == -149639)
							{
								continue;
							}
						}
						else
						{
							if (skillname == "chm_farReach1")
							{
								if (146640 - 324107 != -177467)
								{
									continue;
								}
								skillClass.setReq(8, 4);
								if (235008 - 385193 != -150185)
								{
									continue;
								}
								goto IL_2731;
							}
							else if (skillname == "chm_farReach2")
							{
								if (265255 - 281560 != -16304)
								{
									goto IL_2731;
								}
								continue;
							}
							else if (skillname == "chm_farReach3")
							{
								if (285415 - 143449 == 141967)
								{
									continue;
								}
							}
							else if (skillname == "chm_farReach4")
							{
								if (261376 - 45763 != 215613)
								{
									continue;
								}
								goto IL_2A40;
							}
							else
							{
								if (skillname == "chm_statPlus1")
								{
									if (219647 - 270848 == -51200)
									{
										continue;
									}
									skillClass.setReq(10, 4);
									if (242827 - 4541 != 238286)
									{
										continue;
									}
									goto IL_2EBE;
								}
								else if (skillname == "chm_statPlus2")
								{
									if (219066 - 468416 != -249349)
									{
										goto IL_2EBE;
									}
									continue;
								}
								else if (skillname == "chm_statPlus3")
								{
									if (184988 - 579425 != -394436)
									{
										goto IL_60D;
									}
									continue;
								}
								else if (skillname == "chm_statPlus4")
								{
									if (175078 - 505895 == -330816)
									{
										continue;
									}
								}
								else
								{
									if (skillname == "chm_quickFire1")
									{
										if (271468 - 562991 == -291522)
										{
											continue;
										}
										skillClass.setReq(3, 0);
										if (12242 - 497662 == -485419)
										{
											continue;
										}
										skillClass.setSP(12);
										if (67392 - 377550 != -310158)
										{
											continue;
										}
										goto IL_1393;
									}
									else if (skillname == "chm_quickFire2")
									{
										if (118504 - 179940 != -61436)
										{
											continue;
										}
										goto IL_1393;
									}
									else if (skillname == "chm_quickFire3")
									{
										if (224672 - 391808 != -167136)
										{
											continue;
										}
									}
									else if (skillname == "chm_quickFire4")
									{
										if (29284 - 169432 != -140147)
										{
											goto IL_3073;
										}
										continue;
									}
									else
									{
										if (skillname == "chm_perfectBlend1")
										{
											if (243014 - 253137 != -10123)
											{
												continue;
											}
											skillClass.setReq(5, 1);
											if (141836 - 178281 == -36444)
											{
												continue;
											}
											skillClass.setSP(-8);
											if (73733 - 6526 == 67208)
											{
												continue;
											}
										}
										else if (skillname == "chm_perfectBlend2")
										{
											if (68838 - 224543 != -155705)
											{
												continue;
											}
										}
										else
										{
											if (skillname == "chm_trueInvisibility1")
											{
												if (139977 - 275958 != -135981)
												{
													continue;
												}
												skillClass.setReq(17, 5);
												if (154272 - 240416 != -86144)
												{
													continue;
												}
												skillClass.setMP(12);
												if (23631 - 440691 != -417060)
												{
													continue;
												}
											}
											else if (skillname == "chm_trueInvisibility2")
											{
												if (256121 - 369510 == -113388)
												{
													continue;
												}
											}
											else
											{
												if (skillname == "chm_needlePrison1")
												{
													if (26519 - 251972 == -225452)
													{
														continue;
													}
													skillClass.setReq(7, 2);
													if (76698 - 218847 == -142148)
													{
														continue;
													}
													skillClass.setSP(-14);
													if (247457 - 27125 == 220333)
													{
														continue;
													}
												}
												else if (skillname == "chm_needlePrison2")
												{
													if (278438 - 264218 != 14220)
													{
														continue;
													}
												}
												else
												{
													if (skillname == "chm_massShot1")
													{
														if (179865 - 135190 != 44675)
														{
															continue;
														}
														skillClass.setReq(13, 4);
														if (5136 - 294457 == -289320)
														{
															continue;
														}
														skillClass.setSP(-10);
														if (218587 - 412445 == -193857)
														{
															continue;
														}
													}
													else if (skillname == "chm_massShot2")
													{
														if (140021 - 574185 != -434164)
														{
															continue;
														}
													}
													else
													{
														if (skillname == "chm_poisonArrow1")
														{
															if (36563 - 150243 == -113679)
															{
																continue;
															}
															skillClass.setReq(9, 3);
															if (35504 - 363664 != -328159)
															{
																goto IL_27BC;
															}
															continue;
														}
														else if (skillname == "chm_poisonArrow2")
														{
															if (190390 - 518061 != -327670)
															{
																goto IL_27BC;
															}
															continue;
														}
														else if (skillname == "chm_poisonArrow3")
														{
															if (36576 - 173029 != -136453)
															{
																continue;
															}
														}
														else if (skillname == "chm_poisonArrow4")
														{
															if (294851 - 382545 != -87693)
															{
																goto IL_7F0;
															}
															continue;
														}
														else
														{
															if (skillname == "chm_increasedPoison1")
															{
																if (245575 - 114686 != 130889)
																{
																	continue;
																}
																skillClass.setReq(16, 4);
																if (26478 - 412958 != -386480)
																{
																	continue;
																}
																goto IL_28BB;
															}
															else if (skillname == "chm_increasedPoison2")
															{
																if (281506 - 85574 != 195932)
																{
																	continue;
																}
																goto IL_28BB;
															}
															else if (skillname == "chm_increasedPoison3")
															{
																if (19769 - 432756 != -412987)
																{
																	continue;
																}
																goto IL_2FC5;
															}
															else if (skillname == "chm_piercingVenom1")
															{
																if (72207 - 524761 != -452554)
																{
																	continue;
																}
															}
															else
															{
																if (skillname == "chm_poisonVolley1")
																{
																	if (8661 - 272521 == -263859)
																	{
																		continue;
																	}
																	skillClass.setReq(20, 12);
																	if (153670 - 384935 != -231265)
																	{
																		continue;
																	}
																	skillClass.setMPSP(6, -12);
																	if (155848 - 20679 != 135169)
																	{
																		continue;
																	}
																}
																else if (skillname == "chm_poisonVolley2")
																{
																	if (34826 - 273277 == -238450)
																	{
																		continue;
																	}
																}
																else
																{
																	if (skillname == "chm_venomShock1")
																	{
																		if (210998 - 479270 != -268272)
																		{
																			continue;
																		}
																		skillClass.setReq(28, 18);
																		if (77903 - 368741 != -290838)
																		{
																			continue;
																		}
																		skillClass.setMPSP(12, -24);
																		if (55463 - 449756 != -394293)
																		{
																			continue;
																		}
																	}
																	else if (skillname == "chm_venomShock2")
																	{
																		if (15386 - 305006 != -289620)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (skillname == "chm_massInvisibility1")
																		{
																			if (226034 - 128141 != 97893)
																			{
																				continue;
																			}
																			skillClass.setReq(24, 15);
																			if (237176 - 12639 != 224537)
																			{
																				continue;
																			}
																			skillClass.setMP(28);
																			if (36330 - 574224 == -537893)
																			{
																				continue;
																			}
																		}
																		else if (skillname == "chm_massInvisibility2")
																		{
																			if (41019 - 135777 != -94758)
																			{
																				continue;
																			}
																		}
																		else if (skillname == "chm_clearArrow1")
																		{
																			if (246508 - 307832 == -61323)
																			{
																				continue;
																			}
																			skillClass.setReq(30, 21);
																			if (143422 - 294060 != -150638)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.passive;
																			if (84792 - 100934 != -16141)
																			{
																				break;
																			}
																			continue;
																		}
																		else
																		{
																			if (skillname == "chm_finalEntrapment1")
																			{
																				if (149724 - 553144 != -403420)
																				{
																					continue;
																				}
																				skillClass.setReq(35, 23);
																				if (220877 - 518968 == -298090)
																				{
																					continue;
																				}
																				skillClass.setMPSP(20, -35);
																				if (271853 - 300329 == -28475)
																				{
																					continue;
																				}
																			}
																			else if (skillname == "chm_finalEntrapment2")
																			{
																				if (131971 - 182632 == -50660)
																				{
																					continue;
																				}
																			}
																			else if (skillname == "chm_tormentRain1")
																			{
																				if (139566 - 221381 != -81815)
																				{
																					continue;
																				}
																				skillClass.setReq(45, 27);
																				if (110738 - 558100 != -447362)
																				{
																					continue;
																				}
																				skillClass.setMPSP(15, -15);
																				if (95956 - 578143 == -482186)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.instant;
																				if (15187 - 196242 != -181055)
																				{
																					continue;
																				}
																				skillClass.target = eSkillTarget.enemy;
																				if (127458 - 479243 != -351785)
																				{
																					continue;
																				}
																				skillClass.cType = "tormentRain";
																				if (205790 - 523413 != -317622)
																				{
																					break;
																				}
																				continue;
																			}
																			else
																			{
																				if (skillname == "chm_fatalStrike1")
																				{
																					if (132446 - 6026 != 126420)
																					{
																						continue;
																					}
																					skillClass.setReq(3, 0);
																					if (258237 - 315057 == -56819)
																					{
																						continue;
																					}
																					skillClass.setMPSP(6, 6);
																					if (146380 - 168304 != -21923)
																					{
																						goto IL_35DE;
																					}
																					continue;
																				}
																				else if (skillname == "chm_fatalStrike2")
																				{
																					if (216053 - 331109 != -115056)
																					{
																						continue;
																					}
																					goto IL_35DE;
																				}
																				else if (skillname == "chm_fatalStrike3")
																				{
																					if (16749 - 30591 != -13842)
																					{
																						continue;
																					}
																					goto IL_134F;
																				}
																				else if (skillname == "chm_fatalStrike4")
																				{
																					if (279870 - 333613 != -53743)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					if (skillname == "chm_criticalPlus1")
																					{
																						if (243876 - 412758 != -168882)
																						{
																							continue;
																						}
																						skillClass.setReq(5, 1);
																						if (15152 - 1500 != 13652)
																						{
																							continue;
																						}
																						goto IL_1280;
																					}
																					else if (skillname == "chm_criticalPlus2")
																					{
																						if (263587 - 369113 != -105525)
																						{
																							goto IL_1280;
																						}
																						continue;
																					}
																					else if (skillname == "chm_criticalPlus3")
																					{
																						if (218019 - 345573 != -127554)
																						{
																							continue;
																						}
																						goto IL_A12;
																					}
																					else if (skillname == "chm_criticalPlus4")
																					{
																						if (16871 - 461915 == -445043)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						if (skillname == "chm_leftStride1")
																						{
																							if (50536 - 303824 == -253287)
																							{
																								continue;
																							}
																							skillClass.setReq(7, 2);
																							if (295529 - 97134 != 198395)
																							{
																								continue;
																							}
																							skillClass.setSP(-12);
																							if (277766 - 250857 != 26909)
																							{
																								continue;
																							}
																						}
																						else if (skillname == "chm_leftStride2")
																						{
																							if (295894 - 92001 != 203893)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							if (skillname == "chm_rightStride1")
																							{
																								if (14636 - 293024 == -278387)
																								{
																									continue;
																								}
																								skillClass.setReq(13, 4);
																								if (71789 - 512321 == -440531)
																								{
																									continue;
																								}
																								skillClass.setMPSP(4, -12);
																								if (129562 - 167275 != -37713)
																								{
																									continue;
																								}
																							}
																							else if (skillname == "chm_rightStride2")
																							{
																								if (262410 - 474886 == -212475)
																								{
																									continue;
																								}
																							}
																							else
																							{
																								if (skillname == "chm_campFire1")
																								{
																									if (265364 - 570088 != -304724)
																									{
																										continue;
																									}
																									skillClass.setReq(9, 3);
																									if (118243 - 27347 == 90897)
																									{
																										continue;
																									}
																									skillClass.setMP(10);
																									if (271713 - 424853 == -153139)
																									{
																										continue;
																									}
																								}
																								else if (skillname == "chm_campFire2")
																								{
																									if (126939 - 259727 != -132788)
																									{
																										continue;
																									}
																								}
																								else
																								{
																									if (skillname == "chm_bloodBurn1")
																									{
																										if (20638 - 588825 == -568186)
																										{
																											continue;
																										}
																										skillClass.setReq(15, 5);
																										if (170252 - 235062 != -64810)
																										{
																											continue;
																										}
																									}
																									else if (skillname == "chm_bloodBurn2")
																									{
																										if (267013 - 112676 == 154338)
																										{
																											continue;
																										}
																									}
																									else if (skillname == "chm_bugSlayer1")
																									{
																										if (210972 - 334339 == -123366)
																										{
																											continue;
																										}
																										skillClass.setReq(16, 4);
																										if (41794 - 400642 == -358847)
																										{
																											continue;
																										}
																										skillClass.setMPSP(12, -24);
																										if (231924 - 427775 == -195850)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.target;
																										if (207760 - 119997 != 87763)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.enemy;
																										if (52832 - 492382 != -439550)
																										{
																											continue;
																										}
																										skillClass.cType = "slayer1";
																										if (128575 - 549880 != -421304)
																										{
																											break;
																										}
																										continue;
																									}
																									else if (skillname == "chm_tailSlayer2")
																									{
																										if (146333 - 410651 != -264318)
																										{
																											continue;
																										}
																										skillClass.setReq(20, 8);
																										if (30520 - 374251 != -343731)
																										{
																											continue;
																										}
																										skillClass.setMPSP(12, -24);
																										if (219342 - 588870 != -369528)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.target;
																										if (100301 - 336414 == -236112)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.enemy;
																										if (54122 - 459106 == -404983)
																										{
																											continue;
																										}
																										skillClass.cType = "slayer2";
																										if (82541 - 38636 != 43906)
																										{
																											break;
																										}
																										continue;
																									}
																									else if (skillname == "chm_elementalSlayer3")
																									{
																										if (150690 - 439662 != -288972)
																										{
																											continue;
																										}
																										skillClass.setReq(24, 12);
																										if (74785 - 19236 == 55550)
																										{
																											continue;
																										}
																										skillClass.setMPSP(12, -24);
																										if (125953 - 516176 == -390222)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.target;
																										if (12616 - 427327 == -414710)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.enemy;
																										if (176648 - 445064 != -268416)
																										{
																											continue;
																										}
																										skillClass.cType = "slayer3";
																										if (101511 - 102524 != -1013)
																										{
																											continue;
																										}
																										break;
																									}
																									else if (skillname == "chm_machineSlayer4")
																									{
																										if (86749 - 540849 != -454100)
																										{
																											continue;
																										}
																										skillClass.setReq(28, 16);
																										if (142772 - 14697 == 128076)
																										{
																											continue;
																										}
																										skillClass.setMPSP(12, -24);
																										if (285754 - 83087 != 202667)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.target;
																										if (188416 - 344420 == -156003)
																										{
																											continue;
																										}
																										skillClass.target = eSkillTarget.enemy;
																										if (277720 - 35025 == 242696)
																										{
																											continue;
																										}
																										skillClass.cType = "slayer4";
																										if (4529 - 20665 != -16135)
																										{
																											break;
																										}
																										continue;
																									}
																									else
																									{
																										if (skillname == "chm_improvedSlayer1")
																										{
																											if (119833 - 334056 != -214223)
																											{
																												continue;
																											}
																											skillClass.setReq(20, 12);
																											if (292858 - 333002 != -40143)
																											{
																												goto IL_2853;
																											}
																											continue;
																										}
																										else if (skillname == "chm_improvedSlayer2")
																										{
																											if (30182 - 520968 != -490785)
																											{
																												goto IL_2853;
																											}
																											continue;
																										}
																										else if (skillname == "chm_improvedSlayer3")
																										{
																											if (102102 - 231148 != -129046)
																											{
																												continue;
																											}
																											goto IL_13B6;
																										}
																										else if (skillname == "chm_improvedSlayer4")
																										{
																											if (170937 - 495961 == -325023)
																											{
																												continue;
																											}
																										}
																										else if (skillname == "chm_allBugSlayer1")
																										{
																											if (293682 - 526578 != -232896)
																											{
																												continue;
																											}
																											skillClass.setReq(24, 15);
																											if (241041 - 548298 == -307256)
																											{
																												continue;
																											}
																											skillClass.setMPSP(24, -36);
																											if (72518 - 268189 == -195670)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.instant;
																											if (178380 - 399317 == -220936)
																											{
																												continue;
																											}
																											skillClass.target = eSkillTarget.enemy;
																											if (6564 - 80651 != -74087)
																											{
																												continue;
																											}
																											skillClass.cType = "allSlayer1";
																											if (31526 - 486081 != -454555)
																											{
																												continue;
																											}
																											break;
																										}
																										else if (skillname == "chm_allTailSlayer2")
																										{
																											if (267769 - 468040 != -200271)
																											{
																												continue;
																											}
																											skillClass.setReq(27, 18);
																											if (169714 - 330661 == -160946)
																											{
																												continue;
																											}
																											skillClass.setMPSP(24, -36);
																											if (107879 - 206377 != -98498)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.instant;
																											if (262001 - 578079 == -316077)
																											{
																												continue;
																											}
																											skillClass.target = eSkillTarget.enemy;
																											if (239364 - 327170 != -87806)
																											{
																												continue;
																											}
																											skillClass.cType = "allSlayer2";
																											if (63652 - 576459 != -512806)
																											{
																												break;
																											}
																											continue;
																										}
																										else if (skillname == "chm_allElementalSlayer3")
																										{
																											if (109602 - 531739 != -422137)
																											{
																												continue;
																											}
																											skillClass.setReq(30, 21);
																											if (197096 - 480518 != -283422)
																											{
																												continue;
																											}
																											skillClass.setMPSP(24, -36);
																											if (229742 - 559079 == -329336)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.instant;
																											if (57102 - 347035 == -289932)
																											{
																												continue;
																											}
																											skillClass.target = eSkillTarget.enemy;
																											if (116364 - 302579 == -186214)
																											{
																												continue;
																											}
																											skillClass.cType = "allSlayer3";
																											if (127053 - 257015 != -129962)
																											{
																												continue;
																											}
																											break;
																										}
																										else if (skillname == "chm_allMachineSlayer4")
																										{
																											if (58572 - 15332 == 43241)
																											{
																												continue;
																											}
																											skillClass.setReq(33, 24);
																											if (63980 - 516013 == -452032)
																											{
																												continue;
																											}
																											skillClass.setMPSP(24, -36);
																											if (13268 - 582831 != -569563)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.instant;
																											if (141663 - 540775 == -399111)
																											{
																												continue;
																											}
																											skillClass.target = eSkillTarget.enemy;
																											if (119636 - 20124 == 99513)
																											{
																												continue;
																											}
																											skillClass.cType = "allSlayer4";
																											if (10208 - 508878 != -498669)
																											{
																												break;
																											}
																											continue;
																										}
																										else
																										{
																											if (skillname == "chm_allSlain1")
																											{
																												if (80121 - 591583 == -511461)
																												{
																													continue;
																												}
																												skillClass.setReq(35, 23);
																												if (170383 - 80389 != 89994)
																												{
																													continue;
																												}
																												skillClass.setMPSP(32, -45);
																												if (31856 - 407010 != -375154)
																												{
																													continue;
																												}
																											}
																											else if (skillname == "chm_allSlain2")
																											{
																												if (188284 - 455124 != -266840)
																												{
																													continue;
																												}
																											}
																											else if (skillname == "chm_bowMastery5")
																											{
																												if (81650 - 430298 != -348648)
																												{
																													continue;
																												}
																												skillClass.setReq(55, 0);
																												if (176924 - 423026 == -246101)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (220428 - 541604 != -321176)
																												{
																													continue;
																												}
																												skillClass.rSkill = 104;
																												if (150002 - 579492 != -429490)
																												{
																													continue;
																												}
																												break;
																											}
																											else if (skillname == "chm_silentWalk5")
																											{
																												if (224476 - 137922 != 86554)
																												{
																													continue;
																												}
																												skillClass.setReq(60, 1);
																												if (163967 - 210300 != -46333)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (16371 - 524024 != -507653)
																												{
																													continue;
																												}
																												skillClass.rSkill = 113;
																												if (127098 - 380013 != -252914)
																												{
																													break;
																												}
																												continue;
																											}
																											else if (skillname == "chm_skinShift5")
																											{
																												if (253219 - 67680 != 185539)
																												{
																													continue;
																												}
																												skillClass.setReq(70, 3);
																												if (87251 - 130532 != -43281)
																												{
																													continue;
																												}
																												skillClass.setMPSP(10, -10);
																												if (52706 - 463108 == -410401)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.instant;
																												if (244605 - 107129 == 137477)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.self;
																												if (47567 - 108680 == -61112)
																												{
																													continue;
																												}
																												skillClass.cType = "immunity";
																												if (228202 - 190384 != 37818)
																												{
																													continue;
																												}
																												skillClass.rSkill = 122;
																												if (293648 - 536186 != -242538)
																												{
																													continue;
																												}
																												break;
																											}
																											else if (skillname == "chm_doubleEffect5")
																											{
																												if (103166 - 15454 == 87713)
																												{
																													continue;
																												}
																												skillClass.setReq(75, 4);
																												if (51609 - 143919 != -92310)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (267160 - 368399 != -101239)
																												{
																													continue;
																												}
																												skillClass.rSkill = 134;
																												if (272745 - 515213 != -242468)
																												{
																													continue;
																												}
																												break;
																											}
																											else if (skillname == "chm_superStatPlus5")
																											{
																												if (91657 - 205557 == -113899)
																												{
																													continue;
																												}
																												skillClass.setReq(85, 6);
																												if (66710 - 451998 == -385287)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (172584 - 457075 == -284490)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.self;
																												if (114672 - 518512 != -403840)
																												{
																													continue;
																												}
																												skillClass.rSkill = 144;
																												if (162552 - 145641 != 16912)
																												{
																													break;
																												}
																												continue;
																											}
																											else if (skillname == "chm_addedFire5")
																											{
																												if (52518 - 54652 == -2133)
																												{
																													continue;
																												}
																												skillClass.setReq(55, 0);
																												if (241881 - 236956 == 4926)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (151353 - 263997 != -112644)
																												{
																													continue;
																												}
																												skillClass.rSkill = 204;
																												if (53842 - 342164 != -288322)
																												{
																													continue;
																												}
																												break;
																											}
																											else if (skillname == "chm_eraseSenses5")
																											{
																												if (94074 - 556264 != -462190)
																												{
																													continue;
																												}
																												skillClass.setReq(60, 1);
																												if (246100 - 422734 != -176634)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (61634 - 556425 != -494791)
																												{
																													continue;
																												}
																												skillClass.rSkill = 214;
																												if (128145 - 361248 != -233103)
																												{
																													continue;
																												}
																												break;
																											}
																											else if (skillname == "chm_massHouseLock5")
																											{
																												if (40164 - 301211 == -261046)
																												{
																													continue;
																												}
																												skillClass.setReq(70, 3);
																												if (34861 - 32868 == 1994)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (180422 - 284302 != -103880)
																												{
																													continue;
																												}
																												skillClass.rSkill = 224;
																												if (27929 - 78967 != -51037)
																												{
																													break;
																												}
																												continue;
																											}
																											else if (skillname == "chm_rustyDecay5")
																											{
																												if (194201 - 59484 == 134718)
																												{
																													continue;
																												}
																												skillClass.setReq(75, 4);
																												if (80394 - 75832 != 4562)
																												{
																													continue;
																												}
																												skillClass.setMPSP(24, -30);
																												if (154884 - 44457 == 110428)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.instant;
																												if (248060 - 34243 != 213817)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.enemy;
																												if (180973 - 86303 != 94670)
																												{
																													continue;
																												}
																												skillClass.cType = "rustyDecay";
																												if (121027 - 335005 != -213978)
																												{
																													continue;
																												}
																												skillClass.rSkill = 234;
																												if (135011 - 82510 != 52502)
																												{
																													break;
																												}
																												continue;
																											}
																											else if (skillname == "chm_deadlyVenom5")
																											{
																												if (206133 - 265648 != -59515)
																												{
																													continue;
																												}
																												skillClass.setReq(85, 6);
																												if (254953 - 157022 != 97931)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (295001 - 206649 != 88352)
																												{
																													continue;
																												}
																												skillClass.rSkill = 244;
																												if (101717 - 268906 != -167189)
																												{
																													continue;
																												}
																												break;
																											}
																											else if (skillname == "chm_extraArrows5")
																											{
																												if (78288 - 264844 == -186555)
																												{
																													continue;
																												}
																												skillClass.setReq(55, 0);
																												if (270693 - 503938 != -233245)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (149038 - 279558 != -130520)
																												{
																													continue;
																												}
																												skillClass.rSkill = 304;
																												if (59845 - 81829 != -21984)
																												{
																													continue;
																												}
																												break;
																											}
																											else if (skillname == "chm_bullsEye5")
																											{
																												if (164377 - 125334 == 39044)
																												{
																													continue;
																												}
																												skillClass.setReq(60, 1);
																												if (292340 - 187824 == 104517)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (32326 - 197204 != -164878)
																												{
																													continue;
																												}
																												skillClass.rSkill = 314;
																												if (228901 - 279070 != -50168)
																												{
																													break;
																												}
																												continue;
																											}
																											else if (skillname == "chm_doubleStrider5")
																											{
																												if (27831 - 272030 == -244198)
																												{
																													continue;
																												}
																												skillClass.setReq(70, 3);
																												if (168277 - 240878 != -72601)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (53188 - 236976 != -183788)
																												{
																													continue;
																												}
																												skillClass.rSkill = 324;
																												if (234321 - 566053 != -331731)
																												{
																													break;
																												}
																												continue;
																											}
																											else if (skillname == "chm_tent5")
																											{
																												if (284786 - 355774 == -70987)
																												{
																													continue;
																												}
																												skillClass.setReq(75, 4);
																												if (142975 - 407342 == -264366)
																												{
																													continue;
																												}
																												skillClass.setMPSP(40, -30);
																												if (228360 - 425431 == -197070)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.instant;
																												if (149841 - 181894 == -32052)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.self;
																												if (39404 - 422816 != -383412)
																												{
																													continue;
																												}
																												skillClass.cType = "tent";
																												if (151899 - 377366 == -225466)
																												{
																													continue;
																												}
																												skillClass.rSkill = 334;
																												if (250981 - 377154 != -126172)
																												{
																													break;
																												}
																												continue;
																											}
																											else if (skillname == "chm_markOfSlayer5")
																											{
																												if (65898 - 415094 == -349195)
																												{
																													continue;
																												}
																												skillClass.setReq(85, 6);
																												if (122672 - 328714 == -206041)
																												{
																													continue;
																												}
																												skillClass.setMPSP(45, -45);
																												if (186672 - 314492 != -127820)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.target;
																												if (45019 - 531613 == -486593)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.enemy;
																												if (186829 - 553414 == -366584)
																												{
																													continue;
																												}
																												skillClass.cType = "markOfSlayer";
																												if (3946 - 567001 != -563055)
																												{
																													continue;
																												}
																												skillClass.rSkill = 344;
																												if (38504 - 496403 != -457899)
																												{
																													continue;
																												}
																												break;
																											}
																											else if (skillname == "chm_revisedSkill5")
																											{
																												if (8979 - 591577 == -582597)
																												{
																													continue;
																												}
																												skillClass.setReq(55, 0);
																												if (77007 - 25268 == 51740)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (224958 - 180942 != 44016)
																												{
																													continue;
																												}
																												break;
																											}
																											else if (skillname == "chm_revisedMagic5")
																											{
																												if (96930 - 200263 == -103332)
																												{
																													continue;
																												}
																												skillClass.setReq(60, 1);
																												if (160345 - 257112 != -96767)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (96446 - 164010 != -67564)
																												{
																													continue;
																												}
																												break;
																											}
																											else if (skillname == "chm_revisedArt5")
																											{
																												if (99923 - 226243 != -126320)
																												{
																													continue;
																												}
																												skillClass.setReq(70, 3);
																												if (213860 - 466462 != -252602)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.passive;
																												if (202914 - 561133 != -358219)
																												{
																													continue;
																												}
																												break;
																											}
																											else if (skillname == "chm_zeroShot5")
																											{
																												if (242996 - 209979 == 33018)
																												{
																													continue;
																												}
																												skillClass.setReq(75, 4);
																												if (97029 - 167461 != -70432)
																												{
																													continue;
																												}
																												skillClass.setMPSP(30, -30);
																												if (154780 - 423479 != -268699)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.instant;
																												if (70202 - 72735 == -2532)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.enemy;
																												if (149580 - 290119 != -140539)
																												{
																													continue;
																												}
																												skillClass.cType = "zeroShot";
																												if (273129 - 422267 == -149137)
																												{
																													continue;
																												}
																												skillClass.rSkill = 251351;
																												if (157073 - 597442 != -440369)
																												{
																													continue;
																												}
																												break;
																											}
																											else
																											{
																												if (!(skillname == "chm_thunderDragon5"))
																												{
																													break;
																												}
																												if (252507 - 58506 == 194002)
																												{
																													continue;
																												}
																												skillClass.setReq(85, 6);
																												if (235209 - 503364 != -268155)
																												{
																													continue;
																												}
																												skillClass.setMPSP(50, -50);
																												if (262424 - 386140 == -123715)
																												{
																													continue;
																												}
																												skillClass.mode = eSkillMode.instant;
																												if (215898 - 67779 == 148120)
																												{
																													continue;
																												}
																												skillClass.target = eSkillTarget.self;
																												if (234442 - 408232 != -173790)
																												{
																													continue;
																												}
																												skillClass.cType = "thunderDragon";
																												if (98941 - 544617 != -445676)
																												{
																													continue;
																												}
																												skillClass.rSkill = 434;
																												if (31854 - 145749 != -113894)
																												{
																													break;
																												}
																												continue;
																											}
																											skillClass.setReq(40, 25);
																											if (128259 - 355096 == -226836)
																											{
																												continue;
																											}
																											skillClass.setMPSP(40, -50);
																											if (112627 - 360323 == -247695)
																											{
																												continue;
																											}
																											skillClass.mode = eSkillMode.instant;
																											if (63862 - 322266 == -258403)
																											{
																												continue;
																											}
																											skillClass.target = eSkillTarget.self;
																											if (251185 - 58587 != 192598)
																											{
																												continue;
																											}
																											skillClass.cType = "allSlain";
																											if (30163 - 30461 != -298)
																											{
																												continue;
																											}
																											break;
																										}
																										IL_132B:
																										skillClass.setReq(32, 21);
																										if (228580 - 441727 != -213147)
																										{
																											continue;
																										}
																										skillClass.mode = eSkillMode.passive;
																										if (53936 - 366017 != -312081)
																										{
																											continue;
																										}
																										break;
																										IL_13B6:
																										skillClass.setReq(28, 18);
																										if (202138 - 596976 != -394837)
																										{
																											goto IL_132B;
																										}
																										continue;
																										IL_2853:
																										skillClass.setReq(24, 15);
																										if (47770 - 136338 != -88568)
																										{
																											continue;
																										}
																										goto IL_13B6;
																									}
																									skillClass.setReq(27, 9);
																									if (119280 - 171687 == -52406)
																									{
																										continue;
																									}
																									skillClass.mode = eSkillMode.instant;
																									if (57849 - 72601 != -14752)
																									{
																										continue;
																									}
																									skillClass.target = eSkillTarget.self;
																									if (115372 - 434825 == -319452)
																									{
																										continue;
																									}
																									skillClass.cType = "bloodBurn";
																									if (29463 - 539791 != -510327)
																									{
																										break;
																									}
																									continue;
																								}
																								skillClass.setReq(21, 7);
																								if (179107 - 243303 != -64196)
																								{
																									continue;
																								}
																								skillClass.setMP(15);
																								if (107945 - 265914 != -157969)
																								{
																									continue;
																								}
																								skillClass.mode = eSkillMode.instant;
																								if (140589 - 455876 == -315286)
																								{
																									continue;
																								}
																								skillClass.target = eSkillTarget.self;
																								if (138050 - 451793 == -313742)
																								{
																									continue;
																								}
																								skillClass.cType = "campFire";
																								if (248766 - 482087 != -233320)
																								{
																									break;
																								}
																								continue;
																							}
																							skillClass.setReq(25, 8);
																							if (270488 - 214098 == 56391)
																							{
																								continue;
																							}
																							skillClass.setMPSP(6, -18);
																							if (43707 - 175321 == -131613)
																							{
																								continue;
																							}
																							skillClass.mode = eSkillMode.instant;
																							if (197254 - 557536 != -360282)
																							{
																								continue;
																							}
																							skillClass.target = eSkillTarget.enemy;
																							if (122429 - 205527 != -83098)
																							{
																								continue;
																							}
																							skillClass.cType = "rightStride";
																							if (208246 - 40589 != 167657)
																							{
																								continue;
																							}
																							break;
																						}
																						skillClass.setReq(19, 6);
																						if (237881 - 485780 == -247898)
																						{
																							continue;
																						}
																						skillClass.setSP(-18);
																						if (190009 - 315700 != -125691)
																						{
																							continue;
																						}
																						skillClass.mode = eSkillMode.instant;
																						if (16077 - 335651 == -319573)
																						{
																							continue;
																						}
																						skillClass.target = eSkillTarget.enemy;
																						if (103141 - 348783 != -245642)
																						{
																							continue;
																						}
																						skillClass.cType = "leftStride";
																						if (125845 - 110458 != 15387)
																						{
																							continue;
																						}
																						break;
																					}
																					IL_868:
																					skillClass.setReq(23, 7);
																					if (107024 - 281660 != -174636)
																					{
																						continue;
																					}
																					skillClass.mode = eSkillMode.passive;
																					if (175524 - 191088 != -15563)
																					{
																						break;
																					}
																					continue;
																					IL_A12:
																					skillClass.setReq(17, 5);
																					if (222577 - 220921 != 1657)
																					{
																						goto IL_868;
																					}
																					continue;
																					IL_1280:
																					skillClass.setReq(11, 3);
																					if (82534 - 474083 != -391549)
																					{
																						continue;
																					}
																					goto IL_A12;
																				}
																				IL_33E1:
																				skillClass.setReq(21, 3);
																				if (289847 - 328919 != -39072)
																				{
																					continue;
																				}
																				skillClass.setMPSP(12, 12);
																				if (149456 - 133800 != 15656)
																				{
																					continue;
																				}
																				skillClass.mode = eSkillMode.instant;
																				if (74845 - 22680 == 52166)
																				{
																					continue;
																				}
																				skillClass.target = eSkillTarget.self;
																				if (144804 - 430360 != -285556)
																				{
																					continue;
																				}
																				skillClass.cType = "fatalStrike";
																				if (19839 - 533458 != -513619)
																				{
																					continue;
																				}
																				break;
																				IL_134F:
																				skillClass.setReq(15, 2);
																				if (162359 - 515872 != -353513)
																				{
																					continue;
																				}
																				skillClass.setMPSP(10, 10);
																				if (19400 - 463395 != -443995)
																				{
																					continue;
																				}
																				goto IL_33E1;
																				IL_35DE:
																				skillClass.setReq(9, 1);
																				if (88426 - 74495 != 13931)
																				{
																					continue;
																				}
																				skillClass.setMPSP(8, 8);
																				if (117685 - 315295 != -197610)
																				{
																					continue;
																				}
																				goto IL_134F;
																			}
																			skillClass.setReq(40, 25);
																			if (203470 - 113439 != 90031)
																			{
																				continue;
																			}
																			skillClass.setMPSP(30, -45);
																			if (29356 - 414089 == -384732)
																			{
																				continue;
																			}
																			skillClass.mode = eSkillMode.target;
																			if (198673 - 510494 != -311821)
																			{
																				continue;
																			}
																			skillClass.target = eSkillTarget.enemy;
																			if (84021 - 395945 == -311923)
																			{
																				continue;
																			}
																			skillClass.cType = "finalEntrapment";
																			if (156397 - 205857 != -49459)
																			{
																				break;
																			}
																			continue;
																		}
																		skillClass.setReq(27, 18);
																		if (223175 - 363184 != -140009)
																		{
																			continue;
																		}
																		skillClass.setMP(36);
																		if (136232 - 150341 != -14109)
																		{
																			continue;
																		}
																		skillClass.mode = eSkillMode.instant;
																		if (239925 - 438849 == -198923)
																		{
																			continue;
																		}
																		skillClass.target = eSkillTarget.ally;
																		if (58594 - 68022 != -9428)
																		{
																			continue;
																		}
																		skillClass.cType = "massInvisibility";
																		if (21424 - 77691 != -56266)
																		{
																			break;
																		}
																		continue;
																	}
																	skillClass.setReq(32, 21);
																	if (288521 - 569424 == -280902)
																	{
																		continue;
																	}
																	skillClass.setMPSP(24, -30);
																	if (258055 - 323283 == -65227)
																	{
																		continue;
																	}
																	skillClass.mode = eSkillMode.instant;
																	if (69258 - 182947 != -113689)
																	{
																		continue;
																	}
																	skillClass.target = eSkillTarget.enemy;
																	if (85530 - 441809 != -356279)
																	{
																		continue;
																	}
																	skillClass.cType = "venomShock";
																	if (243918 - 288431 != -44513)
																	{
																		continue;
																	}
																	break;
																}
																skillClass.setReq(24, 15);
																if (292681 - 213093 != 79588)
																{
																	continue;
																}
																skillClass.setMPSP(9, -18);
																if (285617 - 6407 != 279210)
																{
																	continue;
																}
																skillClass.mode = eSkillMode.instant;
																if (223320 - 369940 == -146619)
																{
																	continue;
																}
																skillClass.target = eSkillTarget.enemy;
																if (77588 - 272199 == -194610)
																{
																	continue;
																}
																skillClass.cType = "poisonVolley";
																if (60248 - 511140 != -450891)
																{
																	break;
																}
																continue;
															}
															IL_70C:
															skillClass.setReq(28, 16);
															if (66862 - 575321 == -508458)
															{
																continue;
															}
															skillClass.mode = eSkillMode.passive;
															if (117346 - 108845 != 8502)
															{
																break;
															}
															continue;
															IL_28BB:
															skillClass.setReq(20, 8);
															if (250706 - 535088 == -284381)
															{
																continue;
															}
															IL_2FC5:
															skillClass.setReq(24, 12);
															if (242750 - 98909 != 143842)
															{
																goto IL_70C;
															}
															continue;
														}
														IL_7A3:
														skillClass.setReq(21, 7);
														if (70370 - 340031 == -269660)
														{
															continue;
														}
														IL_7F0:
														skillClass.setReq(27, 9);
														if (247175 - 570423 != -323248)
														{
															continue;
														}
														skillClass.mode = eSkillMode.passive;
														if (263379 - 195335 != 68044)
														{
															continue;
														}
														break;
														IL_27BC:
														skillClass.setReq(15, 5);
														if (44157 - 140477 != -96319)
														{
															goto IL_7A3;
														}
														continue;
													}
													skillClass.setReq(25, 8);
													if (171357 - 11964 != 159393)
													{
														continue;
													}
													skillClass.setSP(-12);
													if (201460 - 572245 == -370784)
													{
														continue;
													}
													skillClass.mode = eSkillMode.instant;
													if (211445 - 196683 == 14763)
													{
														continue;
													}
													skillClass.target = eSkillTarget.enemy;
													if (31763 - 510719 != -478956)
													{
														continue;
													}
													skillClass.cType = "massShot";
													if (59974 - 599641 != -539667)
													{
														continue;
													}
													break;
												}
												skillClass.setReq(19, 6);
												if (6425 - 93726 != -87301)
												{
													continue;
												}
												skillClass.setSP(-16);
												if (283522 - 95779 != 187743)
												{
													continue;
												}
												skillClass.mode = eSkillMode.target;
												if (286140 - 316001 != -29861)
												{
													continue;
												}
												skillClass.target = eSkillTarget.enemy;
												if (39704 - 429726 == -390021)
												{
													continue;
												}
												skillClass.cType = "needlePrison";
												if (262683 - 480144 != -217461)
												{
													continue;
												}
												break;
											}
											skillClass.setReq(23, 7);
											if (223003 - 39056 == 183948)
											{
												continue;
											}
											skillClass.setMP(20);
											if (80995 - 388746 != -307751)
											{
												continue;
											}
											skillClass.mode = eSkillMode.target;
											if (142527 - 490429 != -347902)
											{
												continue;
											}
											skillClass.target = eSkillTarget.ally;
											if (175528 - 38642 != 136886)
											{
												continue;
											}
											skillClass.cType = "trueInvisibility";
											if (128917 - 445258 != -316340)
											{
												break;
											}
											continue;
										}
										skillClass.setReq(11, 3);
										if (211500 - 226346 == -14845)
										{
											continue;
										}
										skillClass.setSP(-12);
										if (16580 - 229739 == -213158)
										{
											continue;
										}
										skillClass.mode = eSkillMode.instant;
										if (164446 - 417532 != -253086)
										{
											continue;
										}
										skillClass.target = eSkillTarget.self;
										if (100868 - 160386 != -59518)
										{
											continue;
										}
										skillClass.cType = "perfectBlend";
										if (10699 - 469770 != -459071)
										{
											continue;
										}
										break;
									}
									IL_B1E:
									skillClass.setReq(15, 2);
									if (250737 - 396268 == -145530)
									{
										continue;
									}
									skillClass.setSP(20);
									if (40934 - 163418 != -122483)
									{
										goto IL_3073;
									}
									continue;
									IL_1393:
									skillClass.setReq(9, 1);
									if (101443 - 487167 == -385723)
									{
										continue;
									}
									skillClass.setSP(16);
									if (79886 - 347469 != -267583)
									{
										continue;
									}
									goto IL_B1E;
									IL_3073:
									skillClass.setReq(21, 3);
									if (159462 - 288623 != -129161)
									{
										continue;
									}
									skillClass.setSP(24);
									if (120788 - 276625 == -155836)
									{
										continue;
									}
									skillClass.mode = eSkillMode.target;
									if (110530 - 405556 == -295025)
									{
										continue;
									}
									skillClass.target = eSkillTarget.enemy;
									if (17407 - 520715 != -503308)
									{
										continue;
									}
									skillClass.cType = "quickFire";
									if (288329 - 103196 != 185134)
									{
										break;
									}
									continue;
								}
								IL_3D:
								skillClass.setReq(40, 10);
								if (15412 - 404771 != -389359)
								{
									continue;
								}
								skillClass.mode = eSkillMode.passive;
								if (290223 - 480763 != -190540)
								{
									continue;
								}
								skillClass.target = eSkillTarget.self;
								if (65204 - 308933 != -243729)
								{
									continue;
								}
								break;
								IL_60D:
								skillClass.setReq(30, 8);
								if (25245 - 195156 != -169911)
								{
									continue;
								}
								goto IL_3D;
								IL_2EBE:
								skillClass.setReq(20, 6);
								if (286761 - 114576 != 172186)
								{
									goto IL_60D;
								}
								continue;
							}
							IL_2656:
							skillClass.setReq(24, 8);
							if (205427 - 103185 != 102242)
							{
								continue;
							}
							goto IL_2A40;
							IL_2731:
							skillClass.setReq(16, 6);
							if (92358 - 232871 != -140512)
							{
								goto IL_2656;
							}
							continue;
							IL_2A40:
							skillClass.setReq(32, 10);
							if (109971 - 488989 == -379017)
							{
								continue;
							}
							skillClass.mode = eSkillMode.passive;
							if (101311 - 429028 != -327717)
							{
								continue;
							}
							break;
						}
						skillClass.setReq(12, 4);
						if (184273 - 208084 != -23811)
						{
							continue;
						}
						skillClass.setMP(5);
						if (293513 - 373024 != -79511)
						{
							continue;
						}
						skillClass.mode = eSkillMode.instant;
						if (181462 - 505047 != -323585)
						{
							continue;
						}
						skillClass.target = eSkillTarget.self;
						if (21654 - 153177 == -131522)
						{
							continue;
						}
						skillClass.cType = "immunity";
						if (169688 - 188800 != -19111)
						{
							break;
						}
						continue;
					}
					skillClass.setReq(10, 3);
					if (268404 - 298910 != -30506)
					{
						continue;
					}
					IL_3220:
					skillClass.setReq(16, 5);
					if (298074 - 61294 != 236780)
					{
						continue;
					}
					skillClass.mode = eSkillMode.passive;
					if (115051 - 166960 != -51909)
					{
						continue;
					}
					skillClass.target = eSkillTarget.enemy;
					if (234046 - 485652 == -251605)
					{
						continue;
					}
					skillClass.cType = "cAttack";
					if (72913 - 140153 != -67239)
					{
						break;
					}
					continue;
				}
				IL_162D:
				skillClass.setReq(4, 3);
				if (97642 - 80603 == 17040)
				{
					continue;
				}
				skillClass.mode = eSkillMode.passive;
				if (115546 - 382075 == -266528)
				{
					continue;
				}
				skillClass.target = eSkillTarget.enemy;
				if (60540 - 369449 != -308909)
				{
					continue;
				}
				skillClass.cType = "nAttack";
				if (291730 - 306300 != -14569)
				{
					break;
				}
				continue;
				IL_2D6D:
				skillClass.setReq(3, 2);
				if (246998 - 324453 != -77455)
				{
					continue;
				}
				goto IL_162D;
				IL_1FBC:
				skillClass.setReq(2, 1);
				if (282976 - 610 != 282367)
				{
					goto IL_2D6D;
				}
			}
		}
		return skillClass;
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x00442528 File Offset: 0x00440728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillTree(int commandNum)
	{
		if (203569 - 95748 != 107821)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (235074 - 505574 == -270500)
			{
				if (155358 - 320071 != -164712)
				{
					if (commandNum == 101)
					{
						if (43716 - 122432 == -78716)
						{
							result = "chm_nAttack1";
							if (66434 - 255627 != -189192)
							{
								break;
							}
						}
					}
					else if (commandNum == 102)
					{
						if (102431 - 546313 == -443882)
						{
							result = "chm_nAttack2";
							if (179134 - 332785 != -153650)
							{
								break;
							}
						}
					}
					else if (commandNum == 103)
					{
						if (109251 - 76149 == 33102)
						{
							result = "chm_nAttack3";
							if (217168 - 128303 != 88866)
							{
								break;
							}
						}
					}
					else if (commandNum == 104)
					{
						if (264009 - 489471 == -225462)
						{
							result = "chm_nAttack4";
							if (120114 - 478011 != -357896)
							{
								break;
							}
						}
					}
					else if (commandNum == 111)
					{
						if (68702 - 378232 == -309530)
						{
							result = "chm_cAttack1";
							if (90984 - 275805 == -184821)
							{
								break;
							}
						}
					}
					else if (commandNum == 112)
					{
						if (94086 - 6664 == 87422)
						{
							result = "chm_cAttack2";
							if (117843 - 282904 != -165060)
							{
								break;
							}
						}
					}
					else if (commandNum == 113)
					{
						if (287559 - 543854 == -256295)
						{
							result = "chm_cAttack3";
							if (279852 - 20056 != 259797)
							{
								break;
							}
						}
					}
					else if (commandNum == 121)
					{
						if (298503 - 235225 == 63278)
						{
							result = "chm_immunity1";
							if (112246 - 243131 != -130884)
							{
								break;
							}
						}
					}
					else if (commandNum == 122)
					{
						if (215326 - 407389 == -192063)
						{
							result = "chm_immunity2";
							if (258928 - 366516 != -107587)
							{
								break;
							}
						}
					}
					else if (commandNum == 131)
					{
						if (11530 - 173367 == -161837)
						{
							result = "chm_farReach1";
							if (249819 - 250047 == -228)
							{
								break;
							}
						}
					}
					else if (commandNum == 132)
					{
						if (262774 - 212221 == 50553)
						{
							result = "chm_farReach2";
							if (77677 - 154931 != -77253)
							{
								break;
							}
						}
					}
					else if (commandNum == 133)
					{
						if (15583 - 20316 != -4732)
						{
							result = "chm_farReach3";
							if (82323 - 96502 == -14179)
							{
								break;
							}
						}
					}
					else if (commandNum == 134)
					{
						if (113701 - 510585 != -396883)
						{
							result = "chm_farReach4";
							if (84185 - 47908 == 36277)
							{
								break;
							}
						}
					}
					else if (commandNum == 141)
					{
						if (40902 - 487763 != -446860)
						{
							result = "chm_statPlus1";
							if (27527 - 28915 != -1387)
							{
								break;
							}
						}
					}
					else if (commandNum == 142)
					{
						if (281699 - 30916 != 250784)
						{
							result = "chm_statPlus2";
							if (4778 - 534574 == -529796)
							{
								break;
							}
						}
					}
					else if (commandNum == 143)
					{
						if (154362 - 59529 != 94834)
						{
							result = "chm_statPlus3";
							if (272963 - 382293 != -109329)
							{
								break;
							}
						}
					}
					else if (commandNum == 144)
					{
						if (111051 - 514158 == -403107)
						{
							result = "chm_statPlus4";
							if (48463 - 250095 == -201632)
							{
								break;
							}
						}
					}
					else if (commandNum == 201)
					{
						if (191957 - 218724 != -26766)
						{
							result = "chm_quickFire1";
							if (258147 - 39420 == 218727)
							{
								break;
							}
						}
					}
					else if (commandNum == 202)
					{
						if (177705 - 8255 == 169450)
						{
							result = "chm_quickFire2";
							if (102017 - 532698 == -430681)
							{
								break;
							}
						}
					}
					else if (commandNum == 203)
					{
						if (190924 - 361980 == -171056)
						{
							result = "chm_quickFire3";
							if (90116 - 333655 != -243538)
							{
								break;
							}
						}
					}
					else if (commandNum == 204)
					{
						if (118565 - 65228 == 53337)
						{
							result = "chm_quickFire4";
							if (150021 - 305406 != -155384)
							{
								break;
							}
						}
					}
					else if (commandNum == 211)
					{
						if (218540 - 71832 != 146709)
						{
							result = "chm_perfectBlend1";
							if (79720 - 58264 == 21456)
							{
								break;
							}
						}
					}
					else if (commandNum == 212)
					{
						if (254300 - 388669 != -134368)
						{
							result = "chm_perfectBlend2";
							if (278191 - 115411 != 162781)
							{
								break;
							}
						}
					}
					else if (commandNum == 213)
					{
						if (227960 - 113915 != 114046)
						{
							result = "chm_trueInvisibility1";
							if (105568 - 404514 == -298946)
							{
								break;
							}
						}
					}
					else if (commandNum == 214)
					{
						if (250108 - 82589 != 167520)
						{
							result = "chm_trueInvisibility2";
							if (127335 - 487825 != -360489)
							{
								break;
							}
						}
					}
					else if (commandNum == 221)
					{
						if (148257 - 198464 != -50206)
						{
							result = "chm_needlePrison1";
							if (41131 - 166060 == -124929)
							{
								break;
							}
						}
					}
					else if (commandNum == 222)
					{
						if (218307 - 194548 != 23760)
						{
							result = "chm_massShot1";
							if (85126 - 444116 == -358990)
							{
								break;
							}
						}
					}
					else if (commandNum == 223)
					{
						if (88840 - 81944 == 6896)
						{
							result = "chm_needlePrison2";
							if (233393 - 576740 != -343346)
							{
								break;
							}
						}
					}
					else if (commandNum == 224)
					{
						if (50920 - 375337 != -324416)
						{
							result = "chm_massShot2";
							if (161797 - 141040 == 20757)
							{
								break;
							}
						}
					}
					else if (commandNum == 231)
					{
						if (202104 - 411812 == -209708)
						{
							result = "chm_poisonArrow1";
							if (44658 - 135455 == -90797)
							{
								break;
							}
						}
					}
					else if (commandNum == 232)
					{
						if (25720 - 562423 != -536702)
						{
							result = "chm_poisonArrow2";
							if (148518 - 596349 == -447831)
							{
								break;
							}
						}
					}
					else if (commandNum == 233)
					{
						if (154996 - 60358 == 94638)
						{
							result = "chm_poisonArrow3";
							if (199011 - 129973 != 69039)
							{
								break;
							}
						}
					}
					else if (commandNum == 234)
					{
						if (47747 - 50727 != -2979)
						{
							result = "chm_poisonArrow4";
							if (298461 - 82907 == 215554)
							{
								break;
							}
						}
					}
					else if (commandNum == 241)
					{
						if (292547 - 317395 != -24847)
						{
							result = "chm_increasedPoison1";
							if (19288 - 581111 != -561822)
							{
								break;
							}
						}
					}
					else if (commandNum == 242)
					{
						if (23275 - 411214 != -387938)
						{
							result = "chm_increasedPoison2";
							if (159167 - 266841 == -107674)
							{
								break;
							}
						}
					}
					else if (commandNum == 243)
					{
						if (133610 - 225075 != -91464)
						{
							result = "chm_increasedPoison3";
							if (120224 - 25667 == 94557)
							{
								break;
							}
						}
					}
					else if (commandNum == 244)
					{
						if (255278 - 6106 != 249173)
						{
							result = "chm_piercingVenom1";
							if (154204 - 545056 == -390852)
							{
								break;
							}
						}
					}
					else if (commandNum == 251)
					{
						if (68910 - 30484 != 38427)
						{
							result = "chm_poisonVolley1";
							if (241810 - 364693 == -122883)
							{
								break;
							}
						}
					}
					else if (commandNum == 252)
					{
						if (104826 - 197175 == -92349)
						{
							result = "chm_poisonVolley2";
							if (247549 - 55320 != 192230)
							{
								break;
							}
						}
					}
					else if (commandNum == 253)
					{
						if (292993 - 465071 != -172077)
						{
							result = "chm_venomShock1";
							if (208930 - 230611 != -21680)
							{
								break;
							}
						}
					}
					else if (commandNum == 254)
					{
						if (279073 - 39845 == 239228)
						{
							result = "chm_venomShock2";
							if (263916 - 103350 != 160567)
							{
								break;
							}
						}
					}
					else if (commandNum == 261)
					{
						if (233530 - 332752 != -99221)
						{
							result = "chm_massInvisibility1";
							if (141591 - 306142 != -164550)
							{
								break;
							}
						}
					}
					else if (commandNum == 262)
					{
						if (232324 - 89310 == 143014)
						{
							result = "chm_massInvisibility2";
							if (54292 - 545091 != -490798)
							{
								break;
							}
						}
					}
					else if (commandNum == 263)
					{
						if (111352 - 493396 != -382043)
						{
							result = "chm_clearArrow1";
							if (186345 - 552267 == -365922)
							{
								break;
							}
						}
					}
					else if (commandNum == 271)
					{
						if (113117 - 528591 != -415473)
						{
							result = "chm_finalEntrapment1";
							if (76130 - 55559 != 20572)
							{
								break;
							}
						}
					}
					else if (commandNum == 272)
					{
						if (59441 - 477326 == -417885)
						{
							result = "chm_finalEntrapment2";
							if (13091 - 570672 != -557580)
							{
								break;
							}
						}
					}
					else if (commandNum == 273)
					{
						if (67511 - 255150 != -187638)
						{
							result = "chm_tormentRain1";
							if (87780 - 345525 != -257744)
							{
								break;
							}
						}
					}
					else if (commandNum == 301)
					{
						if (68904 - 114929 != -46024)
						{
							result = "chm_fatalStrike1";
							if (90742 - 46413 == 44329)
							{
								break;
							}
						}
					}
					else if (commandNum == 302)
					{
						if (119737 - 215936 != -96198)
						{
							result = "chm_fatalStrike2";
							if (20389 - 38897 != -18507)
							{
								break;
							}
						}
					}
					else if (commandNum == 303)
					{
						if (188018 - 304451 != -116432)
						{
							result = "chm_fatalStrike3";
							if (292633 - 489011 != -196377)
							{
								break;
							}
						}
					}
					else if (commandNum == 304)
					{
						if (44035 - 251819 != -207783)
						{
							result = "chm_fatalStrike4";
							if (25015 - 407251 == -382236)
							{
								break;
							}
						}
					}
					else if (commandNum == 311)
					{
						if (91748 - 374821 != -283072)
						{
							result = "chm_criticalPlus1";
							if (251646 - 486370 != -234723)
							{
								break;
							}
						}
					}
					else if (commandNum == 312)
					{
						if (134208 - 178467 != -44258)
						{
							result = "chm_criticalPlus2";
							if (246556 - 343161 == -96605)
							{
								break;
							}
						}
					}
					else if (commandNum == 313)
					{
						if (165193 - 277606 == -112413)
						{
							result = "chm_criticalPlus3";
							if (209171 - 321758 == -112587)
							{
								break;
							}
						}
					}
					else if (commandNum == 314)
					{
						if (254670 - 356316 != -101645)
						{
							result = "chm_criticalPlus4";
							if (107585 - 34531 != 73055)
							{
								break;
							}
						}
					}
					else if (commandNum == 321)
					{
						if (176400 - 448947 == -272547)
						{
							result = "chm_leftStride1";
							if (161828 - 89315 != 72514)
							{
								break;
							}
						}
					}
					else if (commandNum == 322)
					{
						if (296504 - 471647 == -175143)
						{
							result = "chm_rightStride1";
							if (223431 - 228084 != -4652)
							{
								break;
							}
						}
					}
					else if (commandNum == 323)
					{
						if (26780 - 533722 != -506941)
						{
							result = "chm_leftStride2";
							if (19979 - 504927 != -484947)
							{
								break;
							}
						}
					}
					else if (commandNum == 324)
					{
						if (142893 - 31211 == 111682)
						{
							result = "chm_rightStride2";
							if (193985 - 375512 == -181527)
							{
								break;
							}
						}
					}
					else if (commandNum == 331)
					{
						if (86185 - 394921 != -308735)
						{
							result = "chm_campFire1";
							if (17142 - 65003 == -47861)
							{
								break;
							}
						}
					}
					else if (commandNum == 332)
					{
						if (174455 - 369755 != -195299)
						{
							result = "chm_bloodBurn1";
							if (53463 - 174808 != -121344)
							{
								break;
							}
						}
					}
					else if (commandNum == 333)
					{
						if (56755 - 539518 == -482763)
						{
							result = "chm_campFire2";
							if (184110 - 524826 != -340715)
							{
								break;
							}
						}
					}
					else if (commandNum == 334)
					{
						if (162470 - 478158 == -315688)
						{
							result = "chm_bloodBurn2";
							if (163661 - 76670 != 86992)
							{
								break;
							}
						}
					}
					else if (commandNum == 341)
					{
						if (181257 - 194459 == -13202)
						{
							result = "chm_bugSlayer1";
							if (90017 - 424764 == -334747)
							{
								break;
							}
						}
					}
					else if (commandNum == 342)
					{
						if (32788 - 496244 != -463455)
						{
							result = "chm_tailSlayer2";
							if (200273 - 237395 == -37122)
							{
								break;
							}
						}
					}
					else if (commandNum == 343)
					{
						if (15679 - 347940 != -332260)
						{
							result = "chm_elementalSlayer3";
							if (184562 - 360733 == -176171)
							{
								break;
							}
						}
					}
					else if (commandNum == 344)
					{
						if (463 - 254502 == -254039)
						{
							result = "chm_machineSlayer4";
							if (244639 - 589821 == -345182)
							{
								break;
							}
						}
					}
					else if (commandNum == 351)
					{
						if (145963 - 449900 != -303936)
						{
							result = "chm_improvedSlayer1";
							if (269977 - 548988 != -279010)
							{
								break;
							}
						}
					}
					else if (commandNum == 352)
					{
						if (206724 - 212401 == -5677)
						{
							result = "chm_improvedSlayer2";
							if (297318 - 266305 != 31014)
							{
								break;
							}
						}
					}
					else if (commandNum == 353)
					{
						if (197052 - 536263 == -339211)
						{
							result = "chm_improvedSlayer3";
							if (14101 - 342286 != -328184)
							{
								break;
							}
						}
					}
					else if (commandNum == 354)
					{
						if (197539 - 527469 != -329929)
						{
							result = "chm_improvedSlayer4";
							if (210802 - 346849 != -136046)
							{
								break;
							}
						}
					}
					else if (commandNum == 361)
					{
						if (92811 - 545833 != -453021)
						{
							result = "chm_allBugSlayer1";
							if (189964 - 289004 == -99040)
							{
								break;
							}
						}
					}
					else if (commandNum == 362)
					{
						if (185202 - 559265 == -374063)
						{
							result = "chm_allTailSlayer2";
							if (7211 - 472898 == -465687)
							{
								break;
							}
						}
					}
					else if (commandNum == 363)
					{
						if (227340 - 594333 == -366993)
						{
							result = "chm_allElementalSlayer3";
							if (272591 - 493511 != -220919)
							{
								break;
							}
						}
					}
					else if (commandNum == 364)
					{
						if (230487 - 484040 == -253553)
						{
							result = "chm_allMachineSlayer4";
							if (256548 - 244906 == 11642)
							{
								break;
							}
						}
					}
					else if (commandNum == 371)
					{
						if (14727 - 321021 == -306294)
						{
							result = "chm_allSlain1";
							if (247145 - 200067 != 47079)
							{
								break;
							}
						}
					}
					else if (commandNum == 372)
					{
						if (204490 - 189426 != 15065)
						{
							result = "chm_allSlain2";
							if (174256 - 468736 == -294480)
							{
								break;
							}
						}
					}
					else if (commandNum == 401)
					{
						if (151709 - 308034 != -156324)
						{
							result = "chm_bowMastery5";
							if (190305 - 319092 == -128787)
							{
								break;
							}
						}
					}
					else if (commandNum == 411)
					{
						if (193096 - 75906 != 117191)
						{
							result = "chm_silentWalk5";
							if (250175 - 159831 == 90344)
							{
								break;
							}
						}
					}
					else if (commandNum == 421)
					{
						if (268549 - 557568 != -289018)
						{
							result = "chm_skinShift5";
							if (158806 - 95580 != 63227)
							{
								break;
							}
						}
					}
					else if (commandNum == 431)
					{
						if (39030 - 440356 == -401326)
						{
							result = "chm_doubleEffect5";
							if (248530 - 314530 == -66000)
							{
								break;
							}
						}
					}
					else if (commandNum == 441)
					{
						if (60280 - 160211 != -99930)
						{
							result = "chm_superStatPlus5";
							if (83532 - 566228 != -482695)
							{
								break;
							}
						}
					}
					else if (commandNum == 402)
					{
						if (219825 - 444266 != -224440)
						{
							result = "chm_addedFire5";
							if (149783 - 245238 == -95455)
							{
								break;
							}
						}
					}
					else if (commandNum == 412)
					{
						if (153274 - 283421 == -130147)
						{
							result = "chm_eraseSenses5";
							if (129542 - 425217 != -295674)
							{
								break;
							}
						}
					}
					else if (commandNum == 422)
					{
						if (132230 - 171700 == -39470)
						{
							result = "chm_massHouseLock5";
							if (76849 - 302794 == -225945)
							{
								break;
							}
						}
					}
					else if (commandNum == 432)
					{
						if (28679 - 584940 == -556261)
						{
							result = "chm_rustyDecay5";
							if (56885 - 525084 == -468199)
							{
								break;
							}
						}
					}
					else if (commandNum == 442)
					{
						if (31181 - 291320 == -260139)
						{
							result = "chm_deadlyVenom5";
							if (43589 - 533020 == -489431)
							{
								break;
							}
						}
					}
					else if (commandNum == 403)
					{
						if (260543 - 246765 == 13778)
						{
							result = "chm_extraArrows5";
							if (185151 - 527794 == -342643)
							{
								break;
							}
						}
					}
					else if (commandNum == 413)
					{
						if (187117 - 575177 == -388060)
						{
							result = "chm_bullsEye5";
							if (49057 - 500378 == -451321)
							{
								break;
							}
						}
					}
					else if (commandNum == 423)
					{
						if (221475 - 271767 != -50291)
						{
							result = "chm_doubleStrider5";
							if (149766 - 117761 != 32006)
							{
								break;
							}
						}
					}
					else if (commandNum == 433)
					{
						if (147294 - 236816 == -89522)
						{
							result = "chm_tent5";
							if (249911 - 112177 == 137734)
							{
								break;
							}
						}
					}
					else if (commandNum == 443)
					{
						if (21965 - 472213 != -450247)
						{
							result = "chm_markOfSlayer5";
							if (218398 - 214851 != 3548)
							{
								break;
							}
						}
					}
					else if (commandNum == 404)
					{
						if (15155 - 208914 != -193758)
						{
							result = "chm_revisedSkill5";
							if (275212 - 344033 != -68820)
							{
								break;
							}
						}
					}
					else if (commandNum == 414)
					{
						if (185176 - 419537 == -234361)
						{
							result = "chm_revisedMagic5";
							if (174869 - 94022 != 80848)
							{
								break;
							}
						}
					}
					else if (commandNum == 424)
					{
						if (194048 - 579186 == -385138)
						{
							result = "chm_revisedArt5";
							if (20541 - 4533 != 16009)
							{
								break;
							}
						}
					}
					else if (commandNum == 434)
					{
						if (124458 - 152639 != -28180)
						{
							result = "chm_zeroShot5";
							if (31811 - 493640 != -461828)
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
						if (117735 - 199666 == -81931)
						{
							result = "chm_thunderDragon5";
							if (129903 - 426803 != -296899)
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

	// Token: 0x06002418 RID: 9240 RVA: 0x0044418C File Offset: 0x0044238C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x00444190 File Offset: 0x00442390
	internal static bool aihu7UIRR5xC9h3mqVI()
	{
		return true;
	}

	// Token: 0x0600241A RID: 9242 RVA: 0x00444194 File Offset: 0x00442394
	internal static bool v4sxxmIwZRup6Ga5Q4Z()
	{
		return false;
	}
}
