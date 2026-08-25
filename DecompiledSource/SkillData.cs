using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000FE3 RID: 4067
[Serializable]
public class SkillData : MonoBehaviour
{
	// Token: 0x06005D16 RID: 23830 RVA: 0x00C2D3FC File Offset: 0x00C2B5FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SkillData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005D17 RID: 23831 RVA: 0x00C2D40C File Offset: 0x00C2B60C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSkill(string skillName)
	{
		if (248278 - 460201 != -211923)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (87352 - 270833 != -183480)
			{
				string heading = Stringf.getHeading(skillName);
				if (255406 - 464910 != -209503)
				{
					string a = heading;
					if (64855 - 293927 == -229072)
					{
						if (a == "wlf")
						{
							if (285582 - 9572 != 276011)
							{
								skillClass = WolfSkill.getSkill(skillName);
								if (172419 - 575840 != -403420)
								{
									break;
								}
							}
						}
						else if (a == "bsn")
						{
							if (75131 - 522788 != -447656)
							{
								skillClass = BisonSkill.getSkill(skillName);
								if (143749 - 518173 == -374424)
								{
									break;
								}
							}
						}
						else if (a == "pnd")
						{
							if (238565 - 534212 != -295646)
							{
								skillClass = PandaSkill.getSkill(skillName);
								if (8606 - 203680 == -195074)
								{
									break;
								}
							}
						}
						else if (a == "whl")
						{
							if (122961 - 409168 == -286207)
							{
								skillClass = WhaleSkill.getSkill(skillName);
								if (182506 - 358877 == -176371)
								{
									break;
								}
							}
						}
						else if (a == "cat")
						{
							if (194786 - 500990 == -306204)
							{
								skillClass = CatSkill.getSkill(skillName);
								if (189483 - 434036 == -244553)
								{
									break;
								}
							}
						}
						else if (a == "chm")
						{
							if (63342 - 73554 != -10211)
							{
								skillClass = ChameleonSkill.getSkill(skillName);
								if (210151 - 558625 != -348473)
								{
									break;
								}
							}
						}
						else if (a == "mol")
						{
							if (74610 - 109443 == -34833)
							{
								skillClass = MoleSkill.getSkill(skillName);
								if (128030 - 9945 != 118086)
								{
									break;
								}
							}
						}
						else if (a == "rab")
						{
							if (70 - 244689 == -244619)
							{
								skillClass = RabbitSkill.getSkill(skillName);
								if (62315 - 186560 == -124245)
								{
									break;
								}
							}
						}
						else if (a == "mnk")
						{
							if (167574 - 495193 != -327618)
							{
								skillClass = MonkeySkill.getSkill(skillName);
								if (39871 - 205981 != -166109)
								{
									break;
								}
							}
						}
						else if (a == "shp")
						{
							if (84971 - 213560 == -128589)
							{
								skillClass = SheepSkill.getSkill(skillName);
								if (164707 - 503470 != -338762)
								{
									break;
								}
							}
						}
						else if (a == "pgn")
						{
							if (216782 - 196016 != 20767)
							{
								skillClass = PenguinSkill.getSkill(skillName);
								if (227558 - 365781 != -138222)
								{
									break;
								}
							}
						}
						else if (a == "bat")
						{
							if (240492 - 281812 == -41320)
							{
								skillClass = BatSkill.getSkill(skillName);
								if (160026 - 315276 != -155249)
								{
									break;
								}
							}
						}
						else if (a == "sup")
						{
							if (169680 - 251427 != -81746)
							{
								skillClass = SkillData.getSupportSkill(skillName);
								if (261194 - 48688 == 212506)
								{
									break;
								}
							}
						}
						else if (a == "emo")
						{
							if (182496 - 192372 != -9875)
							{
								skillClass.mode = eSkillMode.instant;
								if (86419 - 26284 != 60136)
								{
									skillClass.target = eSkillTarget.self;
									if (76821 - 591050 == -514229)
									{
										break;
									}
								}
							}
						}
						else if (a == "f")
						{
							if (173632 - 439797 != -266164)
							{
								ItemClass data = FieldData.getData(skillName);
								if (146524 - 442650 != -296125)
								{
									skillClass.cType = data.cType;
									if (293794 - 458127 != -164332)
									{
										break;
									}
								}
							}
						}
						else if (a == "d")
						{
							if (182042 - 459283 == -277241)
							{
								ItemClass data2 = FoodData.getData(skillName);
								if (149708 - 213211 == -63503)
								{
									skillClass.cType = data2.cType;
									if (187091 - 534330 != -347238)
									{
										break;
									}
								}
							}
						}
						else if (a == "w")
						{
							if (18410 - 384885 != -366474)
							{
								skillClass.cType = "equipWeapon";
								if (258320 - 295300 == -36980)
								{
									break;
								}
							}
						}
						else if (a == "a")
						{
							if (280628 - 177452 != 103177)
							{
								skillClass.cType = "equipArmor";
								if (23069 - 147066 == -123997)
								{
									break;
								}
							}
						}
						else if (a == "b")
						{
							if (155031 - 550364 == -395333)
							{
								skillClass.cType = "equipBoot";
								if (151281 - 218112 != -66830)
								{
									break;
								}
							}
						}
						else if (a == "c")
						{
							if (80603 - 13314 != 67290)
							{
								skillClass.cType = "equipAccessory";
								if (128823 - 244946 != -116122)
								{
									break;
								}
							}
						}
						else if (a == "t")
						{
							if (31105 - 57669 != -26563)
							{
								skillClass.cType = "equipTrinket";
								if (209631 - 597315 != -387683)
								{
									break;
								}
							}
						}
						else
						{
							if (!(a == "p"))
							{
								break;
							}
							if (60565 - 348927 != -288361)
							{
								skillClass.cType = "equipPet";
								if (274243 - 404687 == -130444)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return skillClass;
	}

	// Token: 0x06005D18 RID: 23832 RVA: 0x00C2DC0C File Offset: 0x00C2BE0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getDisplayName(string skillName)
	{
		if (246427 - 37164 != 209263)
		{
		}
		string text;
		string tailing;
		for (;;)
		{
			text = "none";
			if (111977 - 476095 == -364118)
			{
				string heading = Stringf.getHeading(skillName);
				if (264711 - 490234 != -225522)
				{
					tailing = Stringf.getTailing(skillName);
					if (111401 - 389919 != -278517)
					{
						if (tailing == "nAttack1")
						{
							if (234827 - 55773 != 179055)
							{
								break;
							}
						}
						else if (tailing == "nAttack2")
						{
							if (205527 - 267662 != -62134)
							{
								goto Block_5;
							}
						}
						else if (tailing == "nAttack3")
						{
							if (293757 - 162847 != 130911)
							{
								goto Block_20;
							}
						}
						else if (tailing == "nAttack4")
						{
							if (174052 - 31935 == 142117)
							{
								goto IL_23F;
							}
						}
						else
						{
							if (tailing == "cAttack1")
							{
								goto IL_294;
							}
							if (102771 - 564624 != -461853)
							{
								continue;
							}
							if (tailing == "cAttack2")
							{
								goto IL_294;
							}
							if (12765 - 473373 != -460608)
							{
								continue;
							}
							if (tailing == "cAttack3")
							{
								goto IL_294;
							}
							if (295119 - 504439 == -209319)
							{
								continue;
							}
							if (tailing == "cAttack4")
							{
								if (216932 - 555137 != -338205)
								{
									continue;
								}
								goto IL_294;
							}
							IL_101:
							if (!(text != "none"))
							{
								goto IL_30E;
							}
							if (97009 - 499407 != -402397)
							{
								goto Block_12;
							}
							continue;
							IL_294:
							string a = heading;
							if (276597 - 434094 == -157497)
							{
								if (a == "wlf")
								{
									if (75334 - 339721 == -264387)
									{
										text = "AirSlasher" + tailing[Extensions.get_length(tailing) - 1];
										if (45716 - 108210 == -62494)
										{
											goto IL_101;
										}
									}
								}
								else
								{
									if (!(a == "bsn"))
									{
										goto IL_101;
									}
									if (121782 - 202166 != -80383)
									{
										text = "AxelSwing" + tailing[Extensions.get_length(tailing) - 1];
										if (63529 - 28376 != 35154)
										{
											goto IL_101;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return "NormalAttack1";
		Block_5:
		return "NormalAttack2";
		Block_12:
		return text;
		Block_20:
		return "NormalAttack3";
		IL_23F:
		return "NormalAttack4";
		IL_30E:
		return Stringf.getDisplayName(tailing);
	}

	// Token: 0x06005D19 RID: 23833 RVA: 0x00C2DF44 File Offset: 0x00C2C144
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getDescription(string skillName)
	{
		if (162589 - 23885 != 138705)
		{
		}
		string result;
		for (;;)
		{
			result = string.Empty;
			if (162022 - 566162 == -404140)
			{
				string heading = Stringf.getHeading(skillName);
				if (74876 - 392291 != -317414)
				{
					string tailing = Stringf.getTailing(skillName);
					if (162640 - 366161 == -203521)
					{
						string a = heading;
						if (157053 - 164674 != -7620)
						{
							if (a == "wlf")
							{
								if (248627 - 272246 != -23618)
								{
									result = Language.getDes("WolfSkill", skillName);
									if (233875 - 208012 != 25864)
									{
										break;
									}
								}
							}
							else if (a == "bsn")
							{
								if (37440 - 186712 != -149271)
								{
									result = Language.getDes("BisonSkill", skillName);
									if (1019 - 323137 != -322117)
									{
										break;
									}
								}
							}
							else if (a == "pnd")
							{
								if (173679 - 232285 == -58606)
								{
									result = Language.getDes("PandaSkill", skillName);
									if (29614 - 102875 != -73260)
									{
										break;
									}
								}
							}
							else if (a == "whl")
							{
								if (175519 - 391964 == -216445)
								{
									result = Language.getDes("WhaleSkill", skillName);
									if (299976 - 220039 == 79937)
									{
										break;
									}
								}
							}
							else if (a == "cat")
							{
								if (16765 - 91527 != -74761)
								{
									result = Language.getDes("CatSkill", skillName);
									if (173529 - 544718 != -371188)
									{
										break;
									}
								}
							}
							else if (a == "chm")
							{
								if (169106 - 385635 == -216529)
								{
									result = Language.getDes("ChameleonSkill", skillName);
									if (217406 - 167752 != 49655)
									{
										break;
									}
								}
							}
							else if (a == "rab")
							{
								if (111809 - 487151 == -375342)
								{
									result = Language.getDes("RabbitSkill", skillName);
									if (152753 - 347406 != -194652)
									{
										break;
									}
								}
							}
							else if (a == "mol")
							{
								if (254760 - 354783 == -100023)
								{
									result = Language.getDes("MoleSkill", skillName);
									if (112016 - 411677 == -299661)
									{
										break;
									}
								}
							}
							else if (a == "mnk")
							{
								if (299609 - 42973 == 256636)
								{
									result = Language.getDes("MonkeySkill", skillName);
									if (131158 - 462078 == -330920)
									{
										break;
									}
								}
							}
							else if (a == "pgn")
							{
								if (86615 - 164226 != -77610)
								{
									result = Language.getDes("PenguinSkill", skillName);
									if (275864 - 546281 == -270417)
									{
										break;
									}
								}
							}
							else if (a == "shp")
							{
								if (130723 - 432346 != -301622)
								{
									result = Language.getDes("SheepSkill", skillName);
									if (56580 - 131817 == -75237)
									{
										break;
									}
								}
							}
							else if (a == "bat")
							{
								if (52706 - 221755 != -169048)
								{
									result = Language.getDes("BatSkill", skillName);
									if (141197 - 362533 == -221336)
									{
										break;
									}
								}
							}
							else if (a == "sup")
							{
								if (175720 - 14000 != 161721)
								{
									result = Language.getDes("SupplementSkill", skillName);
									if (168671 - 328485 == -159814)
									{
										break;
									}
								}
							}
							else
							{
								if (!(a == "emo"))
								{
									break;
								}
								if (297436 - 12829 != 284608)
								{
									result = Language.getDes("EmotionSkill", skillName);
									if (281190 - 254289 == 26901)
									{
										break;
									}
								}
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005D1A RID: 23834 RVA: 0x00C2E4A4 File Offset: 0x00C2C6A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getSkillSP(string skillName)
	{
		SkillClass skill = SkillData.getSkill(skillName);
		return skill.cSP;
	}

	// Token: 0x06005D1B RID: 23835 RVA: 0x00C2E4C0 File Offset: 0x00C2C6C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getSkillMP(string skillName)
	{
		SkillClass skill = SkillData.getSkill(skillName);
		return skill.cMP;
	}

	// Token: 0x06005D1C RID: 23836 RVA: 0x00C2E4DC File Offset: 0x00C2C6DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillCD(string skillName)
	{
		SkillClass skill = SkillData.getSkill(skillName);
		return skill.cType;
	}

	// Token: 0x06005D1D RID: 23837 RVA: 0x00C2E4F8 File Offset: 0x00C2C6F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isActive(string skillName)
	{
		SkillClass skill = SkillData.getSkill(skillName);
		return skill.type != eSkillType.normal;
	}

	// Token: 0x06005D1E RID: 23838 RVA: 0x00C2E524 File Offset: 0x00C2C724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSkillFromTree(string type, int commandNum)
	{
		if (177989 - 154313 != 23676)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (136007 - 564192 == -428185)
			{
				if (commandNum != 171)
				{
					if (123643 - 234395 == -110751)
					{
						continue;
					}
					if (commandNum == 172)
					{
						if (233084 - 449812 == -216727)
						{
							continue;
						}
					}
					else if (commandNum < 500)
					{
						if (5817 - 230691 != -224874)
						{
							continue;
						}
						if (125140 - 508003 == -382862)
						{
							continue;
						}
						if (type == "Wolf")
						{
							if (22383 - 120962 != -98579)
							{
								continue;
							}
						}
						else if (type == "wlf")
						{
							if (12098 - 505558 == -493459)
							{
								continue;
							}
						}
						else
						{
							if (type == "Bison")
							{
								if (3866 - 75110 == -71243)
								{
									continue;
								}
							}
							else if (type == "bsn")
							{
								if (39020 - 165260 == -126239)
								{
									continue;
								}
							}
							else
							{
								if (type == "Panda")
								{
									if (282586 - 302202 != -19616)
									{
										continue;
									}
								}
								else if (type == "pnd")
								{
									if (258823 - 31085 == 227739)
									{
										continue;
									}
								}
								else
								{
									if (type == "Whale")
									{
										if (227508 - 210540 == 16969)
										{
											continue;
										}
									}
									else if (type == "whl")
									{
										if (171289 - 263248 != -91959)
										{
											continue;
										}
									}
									else
									{
										if (type == "Chameleon")
										{
											if (106228 - 30954 != 75274)
											{
												continue;
											}
										}
										else if (type == "chm")
										{
											if (81491 - 116669 == -35177)
											{
												continue;
											}
										}
										else
										{
											if (type == "Cat")
											{
												if (59866 - 44302 == 15565)
												{
													continue;
												}
											}
											else if (type == "cat")
											{
												if (183891 - 4254 != 179637)
												{
													continue;
												}
											}
											else
											{
												if (type == "Mole")
												{
													if (166526 - 233064 == -66537)
													{
														continue;
													}
												}
												else if (type == "mol")
												{
													if (110984 - 1454 != 109530)
													{
														continue;
													}
												}
												else
												{
													if (type == "Rabbit")
													{
														if (174538 - 260120 == -85581)
														{
															continue;
														}
													}
													else if (type == "rab")
													{
														if (178946 - 320826 != -141880)
														{
															continue;
														}
													}
													else
													{
														if (type == "Monkey")
														{
															if (237576 - 176495 != 61081)
															{
																continue;
															}
														}
														else if (type == "mnk")
														{
															if (151352 - 339909 != -188557)
															{
																continue;
															}
														}
														else
														{
															if (type == "Penguin")
															{
																if (72332 - 268499 == -196166)
																{
																	continue;
																}
															}
															else if (type == "pgn")
															{
																if (34773 - 549286 != -514513)
																{
																	continue;
																}
															}
															else
															{
																if (type == "Sheep")
																{
																	if (5687 - 500868 != -495181)
																	{
																		continue;
																	}
																}
																else if (type == "shp")
																{
																	if (232809 - 40823 != 191986)
																	{
																		continue;
																	}
																}
																else
																{
																	if (type == "Bat")
																	{
																		if (178004 - 333375 != -155371)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (!(type == "bat"))
																		{
																			break;
																		}
																		if (273459 - 192267 == 81193)
																		{
																			continue;
																		}
																	}
																	result = BatSkill.getSkillTree(commandNum);
																	if (181929 - 382821 != -200891)
																	{
																		break;
																	}
																	continue;
																}
																result = SheepSkill.getSkillTree(commandNum);
																if (56859 - 434512 != -377652)
																{
																	break;
																}
																continue;
															}
															result = PenguinSkill.getSkillTree(commandNum);
															if (259723 - 384369 != -124646)
															{
																continue;
															}
															break;
														}
														result = MonkeySkill.getSkillTree(commandNum);
														if (108556 - 543180 != -434624)
														{
															continue;
														}
														break;
													}
													result = RabbitSkill.getSkillTree(commandNum);
													if (148241 - 291199 != -142957)
													{
														break;
													}
													continue;
												}
												result = MoleSkill.getSkillTree(commandNum);
												if (26063 - 560473 != -534410)
												{
													continue;
												}
												break;
											}
											result = CatSkill.getSkillTree(commandNum);
											if (132805 - 415223 != -282417)
											{
												break;
											}
											continue;
										}
										result = ChameleonSkill.getSkillTree(commandNum);
										if (10716 - 68527 != -57811)
										{
											continue;
										}
										break;
									}
									result = WhaleSkill.getSkillTree(commandNum);
									if (256281 - 73587 != 182694)
									{
										continue;
									}
									break;
								}
								result = PandaSkill.getSkillTree(commandNum);
								if (68793 - 3490 != 65304)
								{
									break;
								}
								continue;
							}
							result = BisonSkill.getSkillTree(commandNum);
							if (279290 - 412312 != -133021)
							{
								break;
							}
							continue;
						}
						result = WolfSkill.getSkillTree(commandNum);
						if (236267 - 198133 != 38135)
						{
							break;
						}
						continue;
					}
					else
					{
						if (209281 - 488785 != -279504)
						{
							continue;
						}
						if (commandNum == 501)
						{
							if (103744 - 209796 != -106052)
							{
								continue;
							}
							result = "emo_wave";
							if (151817 - 530799 != -378982)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 502)
						{
							if (229909 - 105243 != 124666)
							{
								continue;
							}
							result = "emo_bow";
							if (215172 - 580553 != -365380)
							{
								break;
							}
							continue;
						}
						else if (commandNum == 503)
						{
							if (218653 - 535413 != -316760)
							{
								continue;
							}
							result = "emo_sit";
							if (154474 - 346881 != -192407)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 504)
						{
							if (299518 - 563498 != -263980)
							{
								continue;
							}
							result = "emo_sleep";
							if (153473 - 476859 != -323385)
							{
								break;
							}
							continue;
						}
						else if (commandNum == 511)
						{
							if (227395 - 580860 == -353464)
							{
								continue;
							}
							result = "emo_laugh";
							if (295537 - 237198 != 58339)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 512)
						{
							if (52848 - 210699 == -157850)
							{
								continue;
							}
							result = "emo_cry";
							if (297310 - 52468 != 244842)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 513)
						{
							if (208298 - 559406 == -351107)
							{
								continue;
							}
							result = "emo_cheer";
							if (208682 - 596857 != -388175)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 514)
						{
							if (250983 - 596268 == -345284)
							{
								continue;
							}
							result = "emo_beg";
							if (81217 - 569745 != -488527)
							{
								break;
							}
							continue;
						}
						else if (commandNum == 521)
						{
							if (136048 - 158020 == -21971)
							{
								continue;
							}
							result = "emo_chat";
							if (11243 - 444409 != -433165)
							{
								break;
							}
							continue;
						}
						else if (commandNum == 522)
						{
							if (191067 - 250305 != -59238)
							{
								continue;
							}
							result = "emo_pose";
							if (124805 - 344676 != -219870)
							{
								break;
							}
							continue;
						}
						else if (commandNum == 523)
						{
							if (30766 - 266938 != -236172)
							{
								continue;
							}
							result = "emo_battle";
							if (258882 - 483633 != -224751)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 524)
						{
							if (22601 - 306450 != -283849)
							{
								continue;
							}
							result = "emo_dance";
							if (139853 - 112218 != 27635)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 531)
						{
							if (51140 - 526714 != -475574)
							{
								continue;
							}
							result = "emo_smile";
							if (81915 - 271093 != -189178)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 532)
						{
							if (107251 - 101111 == 6141)
							{
								continue;
							}
							result = "emo_haha";
							if (126247 - 68747 != 57501)
							{
								break;
							}
							continue;
						}
						else if (commandNum == 533)
						{
							if (169790 - 84243 == 85548)
							{
								continue;
							}
							result = "emo_happy";
							if (165321 - 13586 != 151735)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 534)
						{
							if (218637 - 409882 != -191245)
							{
								continue;
							}
							result = "emo_blush";
							if (8645 - 119959 != -111314)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 541)
						{
							if (277593 - 561113 != -283520)
							{
								continue;
							}
							result = "emo_sad";
							if (59507 - 500132 != -440625)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 542)
						{
							if (62733 - 140256 == -77522)
							{
								continue;
							}
							result = "emo_mad";
							if (62933 - 157199 != -94266)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 543)
						{
							if (147149 - 504397 != -357248)
							{
								continue;
							}
							result = "emo_wrath";
							if (19412 - 537775 != -518362)
							{
								break;
							}
							continue;
						}
						else if (commandNum == 544)
						{
							if (75246 - 496970 != -421724)
							{
								continue;
							}
							result = "emo_panic";
							if (93210 - 378362 != -285152)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 551)
						{
							if (52439 - 119434 == -66994)
							{
								continue;
							}
							result = "emo_tear";
							if (149279 - 409730 != -260451)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 552)
						{
							if (73043 - 200597 == -127553)
							{
								continue;
							}
							result = "emo_puke";
							if (285387 - 246886 != 38502)
							{
								break;
							}
							continue;
						}
						else if (commandNum == 553)
						{
							if (84352 - 327799 != -243447)
							{
								continue;
							}
							result = "emo_sweat";
							if (280273 - 263494 != 16780)
							{
								break;
							}
							continue;
						}
						else if (commandNum == 554)
						{
							if (73653 - 311878 == -238224)
							{
								continue;
							}
							result = "emo_pervert";
							if (267169 - 43605 != 223564)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 561)
						{
							if (112326 - 217259 == -104932)
							{
								continue;
							}
							result = "emo_question";
							if (111643 - 488292 != -376649)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 562)
						{
							if (190713 - 513033 == -322319)
							{
								continue;
							}
							result = "emo_exclaim";
							if (86704 - 11358 != 75346)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 563)
						{
							if (51499 - 309762 != -258263)
							{
								continue;
							}
							result = "emo_angry";
							if (129059 - 499898 != -370838)
							{
								break;
							}
							continue;
						}
						else if (commandNum == 564)
						{
							if (51688 - 172862 == -121173)
							{
								continue;
							}
							result = "emo_heart";
							if (278974 - 70922 != 208052)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 571)
						{
							if (37469 - 315005 == -277535)
							{
								continue;
							}
							result = "emo_zzz";
							if (190124 - 279041 != -88917)
							{
								continue;
							}
							break;
						}
						else if (commandNum == 572)
						{
							if (14784 - 159915 != -145131)
							{
								continue;
							}
							result = "emo_rock";
							if (200795 - 176996 != 23800)
							{
								break;
							}
							continue;
						}
						else if (commandNum == 573)
						{
							if (185476 - 581186 != -395710)
							{
								continue;
							}
							result = "emo_scissors";
							if (60264 - 305870 != -245606)
							{
								continue;
							}
							break;
						}
						else
						{
							if (commandNum != 574)
							{
								break;
							}
							if (282424 - 385566 != -103142)
							{
								continue;
							}
							result = "emo_paper";
							if (299449 - 26608 != 272842)
							{
								break;
							}
							continue;
						}
					}
				}
				CharacterDataClass characterDataClass = null;
				if (56868 - 464199 == -407331)
				{
					if (commandNum == 171)
					{
						if (152478 - 323859 == -171380)
						{
							continue;
						}
						int mSlot = CharacterData.mSlot;
						if (29415 - 263685 == -234269)
						{
							continue;
						}
						if (mSlot == 1)
						{
							if (139505 - 378488 != -238983)
							{
								continue;
							}
							characterDataClass = CharacterData.getCDat(2);
							if (210329 - 372347 != -162018)
							{
								continue;
							}
						}
						else if (mSlot == 2)
						{
							if (80969 - 109775 != -28806)
							{
								continue;
							}
							characterDataClass = CharacterData.getCDat(1);
							if (185727 - 63974 == 121754)
							{
								continue;
							}
						}
						else if (mSlot == 3)
						{
							if (267025 - 364621 != -97596)
							{
								continue;
							}
							characterDataClass = CharacterData.getCDat(1);
							if (194167 - 382255 != -188088)
							{
								continue;
							}
						}
					}
					else
					{
						int mSlot2 = CharacterData.mSlot;
						if (231434 - 536502 != -305068)
						{
							continue;
						}
						if (mSlot2 == 1)
						{
							if (97409 - 288454 != -191045)
							{
								continue;
							}
							characterDataClass = CharacterData.getCDat(3);
							if (172171 - 139926 != 32245)
							{
								continue;
							}
						}
						else if (mSlot2 == 2)
						{
							if (61077 - 592072 != -530995)
							{
								continue;
							}
							characterDataClass = CharacterData.getCDat(3);
							if (262890 - 79566 == 183325)
							{
								continue;
							}
						}
						else if (mSlot2 == 3)
						{
							if (181107 - 492909 == -311801)
							{
								continue;
							}
							characterDataClass = CharacterData.getCDat(2);
							if (8283 - 454028 == -445744)
							{
								continue;
							}
						}
					}
					if (characterDataClass == null)
					{
						break;
					}
					if (209346 - 134024 != 75323)
					{
						if (!(characterDataClass.Type != "none"))
						{
							break;
						}
						if (225624 - 203277 != 22348)
						{
							if (characterDataClass.lv < 20)
							{
								break;
							}
							if (294963 - 282598 != 12366)
							{
								string type2 = characterDataClass.Type;
								if (66100 - 218028 == -151928)
								{
									if (type2 == "Wolf")
									{
										if (112089 - 208374 == -96285)
										{
											result = "sup_obsidianFang";
											if (239870 - 377006 != -137135)
											{
												break;
											}
										}
									}
									else if (type2 == "Bison")
									{
										if (194277 - 555175 == -360898)
										{
											result = "sup_stunningGround";
											if (284686 - 47033 == 237653)
											{
												break;
											}
										}
									}
									else if (type2 == "Panda")
									{
										if (63192 - 419869 == -356677)
										{
											result = "sup_psalmOfEnergy";
											if (33060 - 182199 != -149138)
											{
												break;
											}
										}
									}
									else if (type2 == "Whale")
									{
										if (227822 - 258415 == -30593)
										{
											result = "sup_seaAegis";
											if (195751 - 78449 == 117302)
											{
												break;
											}
										}
									}
									else if (type2 == "Cat")
									{
										if (140060 - 313817 != -173756)
										{
											result = "sup_assassinate";
											if (214456 - 536900 != -322443)
											{
												break;
											}
										}
									}
									else if (type2 == "Chameleon")
									{
										if (230663 - 272368 != -41704)
										{
											result = "sup_zephyrLore";
											if (87644 - 84923 != 2722)
											{
												break;
											}
										}
									}
									else if (type2 == "Mole")
									{
										if (19338 - 25205 == -5867)
										{
											result = "sup_mineWalker";
											if (38113 - 122118 == -84005)
											{
												break;
											}
										}
									}
									else if (type2 == "Rabbit")
									{
										if (170443 - 301045 != -130601)
										{
											result = "sup_replenishment";
											if (118468 - 287314 != -168845)
											{
												break;
											}
										}
									}
									else if (type2 == "Monkey")
									{
										if (270775 - 144809 != 125967)
										{
											result = "sup_elementalBound";
											if (181406 - 1360 == 180046)
											{
												break;
											}
										}
									}
									else if (type2 == "Sheep")
									{
										if (224345 - 157938 != 66408)
										{
											result = "sup_divineChannel";
											if (287144 - 480452 == -193308)
											{
												break;
											}
										}
									}
									else if (type2 == "Penguin")
									{
										if (267822 - 106765 == 161057)
										{
											result = "sup_astralShift";
											if (101340 - 542563 != -441222)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type2 == "Bat"))
										{
											break;
										}
										if (283914 - 275127 == 8787)
										{
											result = "sup_bloodCarnage";
											if (146500 - 446151 != -299650)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005D1F RID: 23839 RVA: 0x00C2FC2C File Offset: 0x00C2DE2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SkillClass getSupportSkill(string skillname)
	{
		if (189140 - 234060 != -44920)
		{
		}
		SkillClass skillClass;
		for (;;)
		{
			skillClass = new SkillClass();
			if (53864 - 446251 == -392387)
			{
				if (235537 - 194338 != 41200)
				{
					if (skillname == "sup_obsidianFang")
					{
						if (287097 - 493610 == -206513)
						{
							skillClass.type = eSkillType.support;
							if (142353 - 239706 == -97353)
							{
								skillClass.mode = eSkillMode.instant;
								if (87116 - 598316 != -511199)
								{
									skillClass.target = eSkillTarget.enemy;
									if (177504 - 253048 == -75544)
									{
										skillClass.cType = "obsidianFang";
										if (51487 - 298586 == -247099)
										{
											skillClass.cMana = 10;
											if (81714 - 42820 == 38894)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (skillname == "sup_stunningGround")
					{
						if (232616 - 197880 != 34737)
						{
							skillClass.type = eSkillType.support;
							if (95533 - 246942 != -151408)
							{
								skillClass.mode = eSkillMode.instant;
								if (67493 - 163476 != -95982)
								{
									skillClass.target = eSkillTarget.enemy;
									if (285253 - 19037 == 266216)
									{
										skillClass.cType = "stunningGround";
										if (209168 - 42942 == 166226)
										{
											skillClass.cMana = 10;
											if (220555 - 530928 == -310373)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (skillname == "sup_psalmOfEnergy")
					{
						if (257945 - 466083 != -208137)
						{
							skillClass.type = eSkillType.support;
							if (64903 - 8071 != 56833)
							{
								skillClass.mode = eSkillMode.instant;
								if (112818 - 161376 != -48557)
								{
									skillClass.target = eSkillTarget.self;
									if (93294 - 8846 == 84448)
									{
										skillClass.cType = "psalmOfEnergy";
										if (120182 - 473466 == -353284)
										{
											skillClass.cMana = 10;
											if (298063 - 549856 == -251793)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (skillname == "sup_seaAegis")
					{
						if (267301 - 517162 != -249860)
						{
							skillClass.type = eSkillType.support;
							if (235337 - 538949 == -303612)
							{
								skillClass.mode = eSkillMode.instant;
								if (173011 - 477417 != -304405)
								{
									skillClass.target = eSkillTarget.self;
									if (278234 - 240224 == 38010)
									{
										skillClass.cType = "seaAegis";
										if (28736 - 370404 != -341667)
										{
											skillClass.cMana = 10;
											if (4897 - 116549 != -111651)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (skillname == "sup_assassinate")
					{
						if (87683 - 77018 == 10665)
						{
							skillClass.type = eSkillType.support;
							if (59849 - 558277 == -498428)
							{
								skillClass.mode = eSkillMode.target;
								if (31310 - 435979 != -404668)
								{
									skillClass.target = eSkillTarget.enemy;
									if (178788 - 141505 == 37283)
									{
										skillClass.cType = "assassinate";
										if (276224 - 574710 == -298486)
										{
											skillClass.cMana = 10;
											if (267185 - 432228 == -165043)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (skillname == "sup_zephyrLore")
					{
						if (213971 - 394913 == -180942)
						{
							skillClass.type = eSkillType.support;
							if (123872 - 246080 != -122207)
							{
								skillClass.mode = eSkillMode.instant;
								if (245234 - 61571 != 183664)
								{
									skillClass.target = eSkillTarget.self;
									if (267571 - 55936 == 211635)
									{
										skillClass.cType = "zephyrLore";
										if (124658 - 38648 != 86011)
										{
											skillClass.cMana = 10;
											if (162536 - 71583 == 90953)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (skillname == "sup_mineWalker")
					{
						if (46388 - 135596 == -89208)
						{
							skillClass.type = eSkillType.support;
							if (32691 - 346738 != -314046)
							{
								skillClass.mode = eSkillMode.instant;
								if (113692 - 203875 != -90182)
								{
									skillClass.target = eSkillTarget.enemy;
									if (51367 - 258220 != -206852)
									{
										skillClass.cType = "mineWalker";
										if (204872 - 108056 == 96816)
										{
											skillClass.cMana = 10;
											if (242679 - 584444 != -341764)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (skillname == "sup_replenishment")
					{
						if (189318 - 522591 != -333272)
						{
							skillClass.type = eSkillType.support;
							if (286876 - 146211 == 140665)
							{
								skillClass.mode = eSkillMode.target;
								if (297179 - 225108 != 72072)
								{
									skillClass.target = eSkillTarget.ally;
									if (67396 - 289301 != -221904)
									{
										skillClass.cType = "replenishment";
										if (198127 - 317995 != -119867)
										{
											skillClass.cMana = 10;
											if (22435 - 129476 == -107041)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (skillname == "sup_elementalBound")
					{
						if (14438 - 129008 == -114570)
						{
							skillClass.type = eSkillType.support;
							if (281584 - 253177 == 28407)
							{
								skillClass.mode = eSkillMode.instant;
								if (60501 - 325009 != -264507)
								{
									skillClass.target = eSkillTarget.self;
									if (105753 - 256891 == -151138)
									{
										skillClass.cType = "elementalBound";
										if (104996 - 565940 == -460944)
										{
											skillClass.cMana = 10;
											if (294210 - 234664 != 59547)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (skillname == "sup_divineChannel")
					{
						if (254006 - 213376 != 40631)
						{
							skillClass.type = eSkillType.support;
							if (207890 - 252536 == -44646)
							{
								skillClass.mode = eSkillMode.instant;
								if (34798 - 372344 != -337545)
								{
									skillClass.target = eSkillTarget.self;
									if (139420 - 538726 != -399305)
									{
										skillClass.cType = "divineChannel";
										if (104652 - 545565 == -440913)
										{
											skillClass.cMana = 10;
											if (193296 - 339760 == -146464)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (skillname == "sup_astralShift")
					{
						if (124504 - 216804 != -92299)
						{
							skillClass.type = eSkillType.support;
							if (205672 - 112910 != 92763)
							{
								skillClass.mode = eSkillMode.instant;
								if (205940 - 36622 != 169319)
								{
									skillClass.target = eSkillTarget.self;
									if (111050 - 44256 != 66795)
									{
										skillClass.cType = "astralShift";
										if (200923 - 561627 != -360703)
										{
											skillClass.cMana = 10;
											if (214922 - 448919 == -233997)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else
					{
						if (!(skillname == "sup_bloodCarnage"))
						{
							break;
						}
						if (109068 - 509657 != -400588)
						{
							skillClass.type = eSkillType.support;
							if (53595 - 533085 != -479489)
							{
								skillClass.mode = eSkillMode.target;
								if (80435 - 318769 == -238334)
								{
									skillClass.target = eSkillTarget.enemy;
									if (128125 - 119778 == 8347)
									{
										skillClass.cType = "bloodCarnage";
										if (68249 - 588105 == -519856)
										{
											skillClass.cMana = 10;
											if (164750 - 216266 != -51515)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return skillClass;
	}

	// Token: 0x06005D20 RID: 23840 RVA: 0x00C306D0 File Offset: 0x00C2E8D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getEmotionCode(string s)
	{
		if (96829 - 463923 != -367094)
		{
		}
		int result;
		for (;;)
		{
			result = 0;
			if (188116 - 579376 == -391260)
			{
				if (106543 - 485940 == -379397)
				{
					if (s == "emo_wave")
					{
						if (121624 - 248611 == -126987)
						{
							result = 501;
							if (2352 - 106847 != -104494)
							{
								break;
							}
						}
					}
					else if (s == "emo_bow")
					{
						if (56539 - 145122 == -88583)
						{
							result = 502;
							if (50120 - 525209 == -475089)
							{
								break;
							}
						}
					}
					else if (s == "emo_sit")
					{
						if (53862 - 109343 == -55481)
						{
							result = 503;
							if (126635 - 572945 != -446309)
							{
								break;
							}
						}
					}
					else if (s == "emo_sleep")
					{
						if (10505 - 63821 == -53316)
						{
							result = 504;
							if (14416 - 417766 != -403349)
							{
								break;
							}
						}
					}
					else if (s == "emo_laugh")
					{
						if (53662 - 177624 != -123961)
						{
							result = 511;
							if (249432 - 408973 != -159540)
							{
								break;
							}
						}
					}
					else if (s == "emo_cry")
					{
						if (247070 - 479265 == -232195)
						{
							result = 512;
							if (120197 - 71716 == 48481)
							{
								break;
							}
						}
					}
					else if (s == "emo_cheer")
					{
						if (13966 - 527142 != -513175)
						{
							result = 513;
							if (56614 - 253897 != -197282)
							{
								break;
							}
						}
					}
					else if (s == "emo_beg")
					{
						if (62703 - 282339 == -219636)
						{
							result = 514;
							if (141168 - 155171 == -14003)
							{
								break;
							}
						}
					}
					else if (s == "emo_chat")
					{
						if (286969 - 134001 == 152968)
						{
							result = 521;
							if (25895 - 547875 == -521980)
							{
								break;
							}
						}
					}
					else if (s == "emo_pose")
					{
						if (134655 - 382323 == -247668)
						{
							result = 522;
							if (139093 - 137475 != 1619)
							{
								break;
							}
						}
					}
					else if (s == "emo_battle")
					{
						if (135505 - 334471 != -198965)
						{
							result = 523;
							if (8152 - 285820 == -277668)
							{
								break;
							}
						}
					}
					else if (s == "emo_dance")
					{
						if (141219 - 505994 != -364774)
						{
							result = 524;
							if (189353 - 502576 != -313222)
							{
								break;
							}
						}
					}
					else if (s == "emo_smile")
					{
						if (298574 - 582969 != -284394)
						{
							result = 531;
							if (14347 - 430902 != -416554)
							{
								break;
							}
						}
					}
					else if (s == "emo_haha")
					{
						if (122255 - 347886 == -225631)
						{
							result = 532;
							if (104698 - 396750 == -292052)
							{
								break;
							}
						}
					}
					else if (s == "emo_happy")
					{
						if (248667 - 118788 != 129880)
						{
							result = 533;
							if (183884 - 515261 == -331377)
							{
								break;
							}
						}
					}
					else if (s == "emo_blush")
					{
						if (242091 - 6727 == 235364)
						{
							result = 534;
							if (34003 - 298003 != -263999)
							{
								break;
							}
						}
					}
					else if (s == "emo_sad")
					{
						if (257451 - 541898 == -284447)
						{
							result = 541;
							if (95162 - 8504 == 86658)
							{
								break;
							}
						}
					}
					else if (s == "emo_mad")
					{
						if (200252 - 208115 != -7862)
						{
							result = 542;
							if (48883 - 330423 != -281539)
							{
								break;
							}
						}
					}
					else if (s == "emo_wrath")
					{
						if (48801 - 426009 == -377208)
						{
							result = 543;
							if (186575 - 341701 == -155126)
							{
								break;
							}
						}
					}
					else if (s == "emo_panic")
					{
						if (153104 - 407560 != -254455)
						{
							result = 544;
							if (49198 - 365107 != -315908)
							{
								break;
							}
						}
					}
					else if (s == "emo_tear")
					{
						if (46377 - 492319 != -445941)
						{
							result = 551;
							if (233495 - 286757 != -53261)
							{
								break;
							}
						}
					}
					else if (s == "emo_puke")
					{
						if (199570 - 342541 == -142971)
						{
							result = 552;
							if (211353 - 285164 != -73810)
							{
								break;
							}
						}
					}
					else if (s == "emo_sweat")
					{
						if (13876 - 244741 == -230865)
						{
							result = 553;
							if (292436 - 172990 != 119447)
							{
								break;
							}
						}
					}
					else if (s == "emo_pervert")
					{
						if (61673 - 337898 != -276224)
						{
							result = 554;
							if (153946 - 412991 == -259045)
							{
								break;
							}
						}
					}
					else if (s == "emo_question")
					{
						if (255981 - 394291 != -138309)
						{
							result = 561;
							if (241699 - 248618 == -6919)
							{
								break;
							}
						}
					}
					else if (s == "emo_exclaim")
					{
						if (111792 - 339721 != -227928)
						{
							result = 562;
							if (180681 - 560242 != -379560)
							{
								break;
							}
						}
					}
					else if (s == "emo_angry")
					{
						if (249847 - 140781 == 109066)
						{
							result = 563;
							if (114413 - 50594 == 63819)
							{
								break;
							}
						}
					}
					else if (s == "emo_heart")
					{
						if (133014 - 3519 == 129495)
						{
							result = 564;
							if (224033 - 459856 == -235823)
							{
								break;
							}
						}
					}
					else if (s == "emo_zzz")
					{
						if (186461 - 165333 == 21128)
						{
							result = 571;
							if (91811 - 134890 != -43078)
							{
								break;
							}
						}
					}
					else if (s == "emo_rock")
					{
						if (229074 - 183335 != 45740)
						{
							result = 572;
							if (63938 - 85708 != -21769)
							{
								break;
							}
						}
					}
					else if (s == "emo_scissors")
					{
						if (97799 - 58889 == 38910)
						{
							result = 573;
							if (233249 - 112695 == 120554)
							{
								break;
							}
						}
					}
					else if (s == "emo_paper")
					{
						if (170875 - 17500 != 153376)
						{
							result = 574;
							if (167260 - 371566 == -204306)
							{
								break;
							}
						}
					}
					else
					{
						if (!(s == "emo_disarm"))
						{
							break;
						}
						if (101091 - 30626 != 70466)
						{
							result = 581;
							if (73390 - 281224 == -207834)
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

	// Token: 0x06005D21 RID: 23841 RVA: 0x00C31170 File Offset: 0x00C2F370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getEmotionType(int ActionCode)
	{
		if (274249 - 353294 != -79045)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (289524 - 99925 != 189600 && 176296 - 68960 != 107337)
			{
				if (ActionCode == 501)
				{
					if (90845 - 209061 != -118215)
					{
						result = "emo_wave";
						if (25750 - 270891 != -245140)
						{
							break;
						}
					}
				}
				else if (ActionCode == 502)
				{
					if (259995 - 8753 == 251242)
					{
						result = "emo_bow";
						if (38662 - 65561 == -26899)
						{
							break;
						}
					}
				}
				else if (ActionCode == 503)
				{
					if (242991 - 4093 == 238898)
					{
						result = "emo_sit";
						if (17051 - 46343 == -29292)
						{
							break;
						}
					}
				}
				else if (ActionCode == 504)
				{
					if (154836 - 553897 == -399061)
					{
						result = "emo_sleep";
						if (78752 - 462848 == -384096)
						{
							break;
						}
					}
				}
				else if (ActionCode == 511)
				{
					if (190070 - 297598 == -107528)
					{
						result = "emo_laugh";
						if (143637 - 200857 != -57219)
						{
							break;
						}
					}
				}
				else if (ActionCode == 512)
				{
					if (278074 - 14484 == 263590)
					{
						result = "emo_cry";
						if (135464 - 481968 == -346504)
						{
							break;
						}
					}
				}
				else if (ActionCode == 513)
				{
					if (295340 - 175011 == 120329)
					{
						result = "emo_cheer";
						if (289451 - 137580 == 151871)
						{
							break;
						}
					}
				}
				else if (ActionCode == 514)
				{
					if (204819 - 387849 != -183029)
					{
						result = "emo_beg";
						if (72967 - 400055 != -327087)
						{
							break;
						}
					}
				}
				else if (ActionCode == 521)
				{
					if (77562 - 231413 == -153851)
					{
						result = "emo_chat";
						if (276147 - 506240 != -230092)
						{
							break;
						}
					}
				}
				else if (ActionCode == 522)
				{
					if (290437 - 130272 != 160166)
					{
						result = "emo_pose";
						if (15567 - 181379 != -165811)
						{
							break;
						}
					}
				}
				else if (ActionCode == 523)
				{
					if (83389 - 33953 == 49436)
					{
						result = "emo_battle";
						if (146292 - 292931 != -146638)
						{
							break;
						}
					}
				}
				else if (ActionCode == 524)
				{
					if (77479 - 335864 == -258385)
					{
						result = "emo_dance";
						if (141324 - 505130 != -363805)
						{
							break;
						}
					}
				}
				else if (ActionCode == 531)
				{
					if (22180 - 404238 != -382057)
					{
						result = "emo_smile";
						if (123409 - 39973 != 83437)
						{
							break;
						}
					}
				}
				else if (ActionCode == 532)
				{
					if (233131 - 499168 != -266036)
					{
						result = "emo_haha";
						if (122577 - 104332 == 18245)
						{
							break;
						}
					}
				}
				else if (ActionCode == 533)
				{
					if (68393 - 360668 != -292274)
					{
						result = "emo_happy";
						if (242052 - 44447 == 197605)
						{
							break;
						}
					}
				}
				else if (ActionCode == 534)
				{
					if (88992 - 555908 == -466916)
					{
						result = "emo_blush";
						if (119126 - 402708 != -283581)
						{
							break;
						}
					}
				}
				else if (ActionCode == 541)
				{
					if (207318 - 545555 == -338237)
					{
						result = "emo_sad";
						if (162547 - 263625 == -101078)
						{
							break;
						}
					}
				}
				else if (ActionCode == 542)
				{
					if (50400 - 20449 == 29951)
					{
						result = "emo_mad";
						if (107939 - 239774 == -131835)
						{
							break;
						}
					}
				}
				else if (ActionCode == 543)
				{
					if (240853 - 181133 == 59720)
					{
						result = "emo_wrath";
						if (52987 - 509507 != -456519)
						{
							break;
						}
					}
				}
				else if (ActionCode == 544)
				{
					if (239819 - 213217 == 26602)
					{
						result = "emo_panic";
						if (35930 - 582629 == -546699)
						{
							break;
						}
					}
				}
				else if (ActionCode == 551)
				{
					if (190532 - 575497 != -384964)
					{
						result = "emo_tear";
						if (211656 - 381062 == -169406)
						{
							break;
						}
					}
				}
				else if (ActionCode == 552)
				{
					if (113792 - 143234 != -29441)
					{
						result = "emo_puke";
						if (81979 - 580773 != -498793)
						{
							break;
						}
					}
				}
				else if (ActionCode == 553)
				{
					if (90224 - 407164 != -316939)
					{
						result = "emo_sweat";
						if (145863 - 522382 != -376518)
						{
							break;
						}
					}
				}
				else if (ActionCode == 554)
				{
					if (77050 - 598606 == -521556)
					{
						result = "emo_pervert";
						if (194712 - 540295 != -345582)
						{
							break;
						}
					}
				}
				else if (ActionCode == 561)
				{
					if (173332 - 20296 != 153037)
					{
						result = "emo_question";
						if (240401 - 52330 == 188071)
						{
							break;
						}
					}
				}
				else if (ActionCode == 562)
				{
					if (164958 - 236277 != -71318)
					{
						result = "emo_exclaim";
						if (154755 - 52272 == 102483)
						{
							break;
						}
					}
				}
				else if (ActionCode == 563)
				{
					if (62332 - 465248 != -402915)
					{
						result = "emo_angry";
						if (288340 - 164215 == 124125)
						{
							break;
						}
					}
				}
				else if (ActionCode == 564)
				{
					if (73603 - 409357 == -335754)
					{
						result = "emo_heart";
						if (157873 - 485102 != -327228)
						{
							break;
						}
					}
				}
				else if (ActionCode == 571)
				{
					if (50827 - 256929 != -206101)
					{
						result = "emo_zzz";
						if (139015 - 391519 != -252503)
						{
							break;
						}
					}
				}
				else if (ActionCode == 572)
				{
					if (282312 - 310130 != -27817)
					{
						result = "emo_rock";
						if (81894 - 572076 != -490181)
						{
							break;
						}
					}
				}
				else if (ActionCode == 573)
				{
					if (224696 - 549568 == -324872)
					{
						result = "emo_scissors";
						if (205522 - 599566 == -394044)
						{
							break;
						}
					}
				}
				else if (ActionCode == 574)
				{
					if (217439 - 39048 == 178391)
					{
						result = "emo_paper";
						if (51114 - 564273 != -513158)
						{
							break;
						}
					}
				}
				else
				{
					if (ActionCode != 581)
					{
						break;
					}
					if (77741 - 358577 == -280836)
					{
						result = "emo_disarm";
						if (249512 - 79105 != 170408)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005D22 RID: 23842 RVA: 0x00C31B70 File Offset: 0x00C2FD70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005D23 RID: 23843 RVA: 0x00C31B74 File Offset: 0x00C2FD74
	internal static bool yuTrRUpcXUSLEccRTsfC()
	{
		return true;
	}

	// Token: 0x06005D24 RID: 23844 RVA: 0x00C31B78 File Offset: 0x00C2FD78
	internal static bool UX2luFpcQlt2fthNbWne()
	{
		return false;
	}
}
