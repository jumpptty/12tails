using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000FBA RID: 4026
[Serializable]
public class CharacterDataClass
{
	// Token: 0x06005BA9 RID: 23465 RVA: 0x00B31580 File Offset: 0x00B2F780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterDataClass()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005BAA RID: 23466 RVA: 0x00B31590 File Offset: 0x00B2F790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nSlot)
	{
		if (220492 - 409350 != -188858)
		{
		}
		for (;;)
		{
			this.slot = nSlot;
			if (87451 - 481393 != -393941)
			{
				this.CID = -1;
				if (26262 - 219827 != -193564)
				{
					this.Name = "none";
					if (3701 - 219292 == -215591)
					{
						this.Type = "none";
						if (29884 - 221120 != -191235)
						{
							this.Skin = 0;
							if (244799 - 478013 == -233214)
							{
								this.Guild = "none";
								if (132976 - 318929 != -185952)
								{
									this.Race = eRace.NPC;
									if (159229 - 148937 == 10292)
									{
										this.lv = 1;
										if (138690 - 564508 != -425817)
										{
											this.exp = 0;
											if (141588 - 463647 == -322059)
											{
												this.nexp = 12;
												if (64080 - 519352 == -455272)
												{
													this.stat = "0%0%0%0%0%0%0%0";
													if (241209 - 336669 == -95460)
													{
														this.bStat = "0%0%0%0%0%0%0%0";
														if (72815 - 214714 == -141899)
														{
															this.bonus = "0%0%0%0%0%0%0%0";
															if (122024 - 159269 == -37245)
															{
																this.weight = (float)100;
																if (239228 - 377996 == -138768)
																{
																	this.runspeed = (float)4;
																	if (183844 - 268565 != -84720)
																	{
																		this.equipment = new InventoryClass[6];
																		if (51298 - 437413 == -386115)
																		{
																			this.inventory = new InventoryClass[30];
																			if (210105 - 401483 != -191377)
																			{
																				this.skill = new int[80];
																				if (63683 - 504855 != -441171)
																				{
																					this.cooldown = new UnityScript.Lang.Array();
																					if (68491 - 417216 != -348724)
																					{
																						this.command = new int[30];
																						if (36271 - 423197 != -386925)
																						{
																							this.timeOut = (float)0;
																							if (80963 - 468347 != -387383)
																							{
																								this.resetEquipment();
																								if (53605 - 523636 == -470031)
																								{
																									this.resetInventory();
																									if (19949 - 484841 == -464892)
																									{
																										this.resetSkill();
																										if (111404 - 299288 != -187883)
																										{
																											this.resetCommand();
																											if (57019 - 548746 != -491726)
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
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BAB RID: 23467 RVA: 0x00B31938 File Offset: 0x00B2FB38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void resetInventory()
	{
		if (184217 - 351942 != -167725)
		{
		}
		for (;;)
		{
			IL_1A:
			int i = 0;
			if (222567 - 427799 == -205232)
			{
				while (i < 30)
				{
					this.inventory[i] = new InventoryClass();
					if (21948 - 476507 == -454558)
					{
						goto IL_1A;
					}
					i++;
					if (199815 - 259286 == -59470)
					{
						goto IL_1A;
					}
				}
				if (188803 - 56511 == 132292)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005BAC RID: 23468 RVA: 0x00B319F8 File Offset: 0x00B2FBF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void resetEquipment()
	{
		if (266882 - 172751 != 94132)
		{
		}
		for (;;)
		{
			IL_59:
			int i = 0;
			if (207326 - 435595 != -228268)
			{
				while (i < 6)
				{
					this.equipment[i] = new InventoryClass();
					if (120006 - 336965 == -216958)
					{
						goto IL_59;
					}
					i++;
					if (262219 - 314999 != -52780)
					{
						goto IL_59;
					}
				}
				if (185576 - 197767 != -12190)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005BAD RID: 23469 RVA: 0x00B31AB8 File Offset: 0x00B2FCB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void resetSkill()
	{
		if (185993 - 366321 != -180328)
		{
		}
		for (;;)
		{
			IL_5A:
			int i = 0;
			if (152836 - 398963 != -246126)
			{
				while (i < 80)
				{
					this.skill[i] = 0;
					if (217691 - 241502 == -23810)
					{
						goto IL_5A;
					}
					i++;
					if (251414 - 275232 == -23817)
					{
						goto IL_5A;
					}
				}
				if (269234 - 228746 != 40489)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005BAE RID: 23470 RVA: 0x00B31B74 File Offset: 0x00B2FD74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void resetCommand()
	{
		if (44689 - 128647 != -83958)
		{
		}
		for (;;)
		{
			IL_5A:
			int i = 0;
			if (149382 - 181435 == -32053)
			{
				while (i < 30)
				{
					this.command[i] = 0;
					if (264684 - 204099 == 60586)
					{
						goto IL_5A;
					}
					i++;
					if (185596 - 353953 == -168356)
					{
						goto IL_5A;
					}
				}
				if (293223 - 237671 != 55553)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005BAF RID: 23471 RVA: 0x00B31C30 File Offset: 0x00B2FE30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateData()
	{
		if (46368 - 190689 != -144321)
		{
		}
		IL_E9B:
		while (!(this.Type == string.Empty))
		{
			if (211204 - 57470 != 153735)
			{
				if (this.Type == "none")
				{
					if (282083 - 356181 == -74098)
					{
						break;
					}
				}
				else
				{
					int[] statList = this.getStatList();
					if (183022 - 516526 == -333504)
					{
						int[] bstatList = this.getBStatList();
						if (286380 - 17638 == 268742)
						{
							int[] bonusList = this.getBonusList();
							if (216488 - 174322 == 42166)
							{
								int[] typeLevelStat = CharacterData.getTypeLevelStat(this.Type, this.lv);
								if (275942 - 427469 != -151526)
								{
									int num = 0;
									if (119219 - 177201 == -57982)
									{
										if (this.hasSkill(141))
										{
											if (173098 - 95837 != 77261)
											{
												continue;
											}
											num += 2;
											if (41287 - 72032 != -30745)
											{
												continue;
											}
										}
										if (this.hasSkill(142))
										{
											if (34065 - 536042 == -501976)
											{
												continue;
											}
											num += 2;
											if (46807 - 430642 == -383834)
											{
												continue;
											}
										}
										if (this.hasSkill(143))
										{
											if (247720 - 295100 != -47380)
											{
												continue;
											}
											num += 2;
											if (55398 - 539807 == -484408)
											{
												continue;
											}
										}
										if (this.hasSkill(144))
										{
											if (122781 - 281101 != -158320)
											{
												continue;
											}
											num += 2;
											if (129740 - 128738 == 1003)
											{
												continue;
											}
										}
										if (this.hasSkill(441))
										{
											if (89851 - 339360 == -249508)
											{
												continue;
											}
											num += 10;
											if (298673 - 487886 != -189213)
											{
												continue;
											}
										}
										int i = 0;
										if (296540 - 569052 != -272511)
										{
											while (i < 8)
											{
												statList[i] = Mathf.FloorToInt((float)(bstatList[i] + bonusList[i] + typeLevelStat[i] + num));
												if (129018 - 569129 == -440110)
												{
													goto IL_E9B;
												}
												i++;
												if (124231 - 450239 == -326007)
												{
													goto IL_E9B;
												}
											}
											if (269965 - 360428 == -90463)
											{
												int j = 0;
												if (14952 - 69159 == -54207)
												{
													while (j < 6)
													{
														if (this.equipment[j].name != "none")
														{
															if (158241 - 374912 != -216671)
															{
																goto IL_E9B;
															}
															ItemClass itemData = ItemData.getItemData(this.equipment[j].name);
															if (179257 - 218877 != -39620)
															{
																goto IL_E9B;
															}
															i = 0;
															if (117856 - 166217 == -48360)
															{
																goto IL_E9B;
															}
															while (i < 8)
															{
																statList[i] += itemData.att[i] + this.equipment[j].att[i];
																if (243905 - 85905 == 158001)
																{
																	goto IL_E9B;
																}
																i++;
																if (66973 - 539662 == -472688)
																{
																	goto IL_E9B;
																}
															}
															if (243029 - 457904 != -214875)
															{
																goto IL_E9B;
															}
														}
														j++;
														if (201500 - 263600 == -62099)
														{
															goto IL_E9B;
														}
													}
													if (97464 - 249641 != -152176)
													{
														if (this.Type == "Wolf")
														{
															if (91318 - 159713 != -68395)
															{
																continue;
															}
															int num2 = 0;
															if (47167 - 8384 == 38784)
															{
																continue;
															}
															if (this.hasSkill(234))
															{
																if (35593 - 469808 == -434214)
																{
																	continue;
																}
																num2 = 4;
																if (156201 - 225790 == -69588)
																{
																	continue;
																}
															}
															else if (this.hasSkill(233))
															{
																if (98904 - 309636 == -210731)
																{
																	continue;
																}
																num2 = 3;
																if (152529 - 582180 == -429650)
																{
																	continue;
																}
															}
															else if (this.hasSkill(232))
															{
																if (89270 - 324855 != -235585)
																{
																	continue;
																}
																num2 = 2;
																if (106032 - 291148 == -185115)
																{
																	continue;
																}
															}
															else if (this.hasSkill(231))
															{
																if (263075 - 233002 == 30074)
																{
																	continue;
																}
																num2 = 1;
																if (173307 - 372682 != -199375)
																{
																	continue;
																}
															}
															if (num2 > 0)
															{
																if (295835 - 271272 != 24563)
																{
																	continue;
																}
																if (this.equipment[0].name != "none")
																{
																	if (73047 - 193150 != -120103)
																	{
																		continue;
																	}
																	ItemClass itemData2 = ItemData.getItemData(this.equipment[0].name);
																	if (214281 - 79694 != 134587)
																	{
																		continue;
																	}
																	i = 0;
																	if (130662 - 31483 == 99180)
																	{
																		continue;
																	}
																	while (i < 8)
																	{
																		statList[i] += Mathf.FloorToInt(0.1f * (float)num2 * (float)(itemData2.att[i] + this.equipment[0].att[i]));
																		if (285346 - 233252 == 52095)
																		{
																			goto IL_E9B;
																		}
																		i++;
																		if (163724 - 333466 == -169741)
																		{
																			goto IL_E9B;
																		}
																	}
																	if (32332 - 82158 != -49826)
																	{
																		continue;
																	}
																}
															}
															int num3 = 0;
															if (251678 - 274774 != -23096)
															{
																continue;
															}
															if (this.hasSkill(244))
															{
																if (165763 - 162953 == 2811)
																{
																	continue;
																}
																num3 = 4;
																if (296029 - 557758 != -261729)
																{
																	continue;
																}
															}
															else if (this.hasSkill(243))
															{
																if (6477 - 69553 != -63076)
																{
																	continue;
																}
																num3 = 3;
																if (126407 - 203688 == -77280)
																{
																	continue;
																}
															}
															else if (this.hasSkill(242))
															{
																if (95962 - 475492 == -379529)
																{
																	continue;
																}
																num3 = 2;
																if (238708 - 300792 != -62084)
																{
																	continue;
																}
															}
															else if (this.hasSkill(241))
															{
																if (206012 - 564934 == -358921)
																{
																	continue;
																}
																num3 = 1;
																if (161277 - 166581 != -5304)
																{
																	continue;
																}
															}
															if (num3 > 0)
															{
																if (296563 - 320442 != -23879)
																{
																	continue;
																}
																if (this.equipment[1].name != "none")
																{
																	if (28148 - 260748 == -232599)
																	{
																		continue;
																	}
																	ItemClass itemData3 = ItemData.getItemData(this.equipment[1].name);
																	if (87471 - 288499 == -201027)
																	{
																		continue;
																	}
																	i = 0;
																	if (73475 - 204620 == -131144)
																	{
																		continue;
																	}
																	while (i < 8)
																	{
																		statList[i] += Mathf.FloorToInt(0.1f * (float)num3 * (float)(itemData3.att[i] + this.equipment[1].att[i]));
																		if (117950 - 456711 != -338761)
																		{
																			goto IL_E9B;
																		}
																		i++;
																		if (208262 - 526865 != -318603)
																		{
																			goto IL_E9B;
																		}
																	}
																	if (191600 - 411063 != -219463)
																	{
																		continue;
																	}
																}
															}
														}
														this.hp = Mathf.Clamp(10 * statList[3], 1, 9999);
														if (114324 - 144339 != -30014)
														{
															this.mp = Mathf.Clamp(3 * statList[4], 1, 9999);
															if (171211 - 317926 == -146715)
															{
																this.sp = Mathf.FloorToInt((float)(statList[6] / 5)) + 10;
																if (7963 - 208125 != -200161)
																{
																	this.ko = Mathf.FloorToInt((float)(statList[2] / 3)) + 10;
																	if (187335 - 459626 == -272291)
																	{
																		this.nexp = CharacterData.getNextExp(this.lv);
																		if (238295 - 425847 == -187552)
																		{
																			this.weight = (float)(CharacterData.getTypeWeight(this.Type) + this.getInventoryWeight());
																			if (177869 - 373421 == -195552)
																			{
																				if (this.Type == "Whale")
																				{
																					if (168177 - 209366 != -41189)
																					{
																						continue;
																					}
																					if (this.hasSkill(131))
																					{
																						if (202882 - 138584 == 64299)
																						{
																							continue;
																						}
																						this.hp += 150;
																						if (187175 - 116179 != 70996)
																						{
																							continue;
																						}
																						statList[3] = statList[3] + 15;
																						if (73399 - 245124 == -171724)
																						{
																							continue;
																						}
																						this.weight += (float)2;
																						if (160088 - 387539 != -227451)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(132))
																					{
																						if (271702 - 415192 == -143489)
																						{
																							continue;
																						}
																						this.hp += 150;
																						if (183197 - 401566 != -218369)
																						{
																							continue;
																						}
																						statList[3] = statList[3] + 15;
																						if (12863 - 128381 == -115517)
																						{
																							continue;
																						}
																						this.weight += (float)2;
																						if (297970 - 84882 == 213089)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(133))
																					{
																						if (138863 - 403682 == -264818)
																						{
																							continue;
																						}
																						this.hp += 150;
																						if (233501 - 171189 == 62313)
																						{
																							continue;
																						}
																						statList[3] = statList[3] + 15;
																						if (11045 - 468261 == -457215)
																						{
																							continue;
																						}
																						this.weight += (float)2;
																						if (267078 - 306670 != -39592)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(134))
																					{
																						if (183133 - 143808 == 39326)
																						{
																							continue;
																						}
																						this.hp += 150;
																						if (299446 - 192419 == 107028)
																						{
																							continue;
																						}
																						statList[3] = statList[3] + 15;
																						if (251670 - 42043 != 209627)
																						{
																							continue;
																						}
																						this.weight += (float)2;
																						if (230847 - 8843 != 222004)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(431))
																					{
																						if (229172 - 556725 != -327553)
																						{
																							continue;
																						}
																						this.hp += 400;
																						if (236011 - 265193 != -29182)
																						{
																							continue;
																						}
																						statList[3] = statList[3] + 40;
																						if (193867 - 164645 != 29222)
																						{
																							continue;
																						}
																						this.weight += (float)10;
																						if (236696 - 47164 == 189533)
																						{
																							continue;
																						}
																					}
																				}
																				if (this.Type == "Cat")
																				{
																					if (259561 - 481582 != -222021)
																					{
																						continue;
																					}
																					if (this.hasSkill(131))
																					{
																						if (295966 - 489636 == -193669)
																						{
																							continue;
																						}
																						statList[2] = statList[2] + 5;
																						if (136466 - 598575 != -462109)
																						{
																							continue;
																						}
																						this.weight -= (float)3;
																						if (284544 - 65190 == 219355)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(132))
																					{
																						if (139553 - 586120 != -446567)
																						{
																							continue;
																						}
																						statList[2] = statList[2] + 5;
																						if (272509 - 113712 == 158798)
																						{
																							continue;
																						}
																						this.weight -= (float)3;
																						if (199001 - 48493 == 150509)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(133))
																					{
																						if (268062 - 486389 == -218326)
																						{
																							continue;
																						}
																						statList[2] = statList[2] + 5;
																						if (89100 - 191557 == -102456)
																						{
																							continue;
																						}
																						this.weight -= (float)3;
																						if (123410 - 240912 != -117502)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(134))
																					{
																						if (40786 - 113891 != -73105)
																						{
																							continue;
																						}
																						statList[2] = statList[2] + 5;
																						if (125461 - 93130 == 32332)
																						{
																							continue;
																						}
																						this.weight -= (float)3;
																						if (113035 - 265526 != -152491)
																						{
																							continue;
																						}
																					}
																				}
																				if (this.Type == "Penguin")
																				{
																					if (169928 - 209799 != -39871)
																					{
																						continue;
																					}
																					if (this.hasSkill(121))
																					{
																						if (49102 - 417317 == -368214)
																						{
																							continue;
																						}
																						statList[4] = statList[4] + 10;
																						if (282120 - 555796 != -273676)
																						{
																							continue;
																						}
																						this.mp += 30;
																						if (248673 - 500129 == -251455)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(122))
																					{
																						if (45816 - 261325 == -215508)
																						{
																							continue;
																						}
																						statList[4] = statList[4] + 10;
																						if (225658 - 82063 != 143595)
																						{
																							continue;
																						}
																						this.mp += 30;
																						if (245821 - 255512 != -9691)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(123))
																					{
																						if (135131 - 318246 == -183114)
																						{
																							continue;
																						}
																						statList[4] = statList[4] + 10;
																						if (264690 - 556570 != -291880)
																						{
																							continue;
																						}
																						this.mp += 30;
																						if (73390 - 105260 == -31869)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(124))
																					{
																						if (62933 - 20703 == 42231)
																						{
																							continue;
																						}
																						statList[4] = statList[4] + 10;
																						if (142368 - 496271 == -353902)
																						{
																							continue;
																						}
																						this.mp += 30;
																						if (22801 - 329598 == -306796)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(261))
																					{
																						if (150251 - 138915 != 11336)
																						{
																							continue;
																						}
																						statList[6] = statList[6] + 10;
																						if (148138 - 173401 != -25263)
																						{
																							continue;
																						}
																						this.sp += 2;
																						if (214124 - 306757 == -92632)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(262))
																					{
																						if (124195 - 74597 == 49599)
																						{
																							continue;
																						}
																						statList[6] = statList[6] + 10;
																						if (235431 - 278805 != -43374)
																						{
																							continue;
																						}
																						this.sp += 2;
																						if (68663 - 463889 != -395226)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(263))
																					{
																						if (210595 - 129029 == 81567)
																						{
																							continue;
																						}
																						statList[6] = statList[6] + 10;
																						if (9627 - 45030 != -35403)
																						{
																							continue;
																						}
																						this.sp += 2;
																						if (57449 - 304477 == -247027)
																						{
																							continue;
																						}
																					}
																					if (this.hasSkill(264))
																					{
																						if (295408 - 533879 == -238470)
																						{
																							continue;
																						}
																						statList[6] = statList[6] + 10;
																						if (79997 - 73507 == 6491)
																						{
																							continue;
																						}
																						this.sp += 2;
																						if (107936 - 10508 != 97428)
																						{
																							continue;
																						}
																					}
																				}
																				this.runspeed = 0.01f * ((float)(400 + 2 * statList[2]) - (float)4 * Mathf.Max(this.weight + (float)this.getReducedWeight(), (float)0));
																				if (53065 - 395652 == -342587)
																				{
																					this.setStatString(statList);
																					if (6072 - 248075 != -242002)
																					{
																						return;
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
	}

	// Token: 0x06005BB0 RID: 23472 RVA: 0x00B330D4 File Offset: 0x00B312D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void updateDelta()
	{
		if (164192 - 347325 != -183133)
		{
		}
		while (!(this.Type == string.Empty))
		{
			if (173679 - 591332 != -417652)
			{
				if (this.Type == "none")
				{
					if (255148 - 549466 == -294318)
					{
						break;
					}
				}
				else
				{
					int[] statList = this.getStatList();
					if (65441 - 148237 != -82795)
					{
						this.hp = Mathf.Clamp(10 * statList[3], 1, 9999);
						if (221675 - 125970 != 95706)
						{
							this.mp = Mathf.Clamp(3 * statList[4], 1, 9999);
							if (227635 - 120894 == 106741)
							{
								this.sp = Mathf.FloorToInt((float)(statList[6] / 5)) + 10;
								if (102220 - 245784 == -143564)
								{
									this.ko = Mathf.FloorToInt((float)(statList[2] / 3)) + 10;
									if (268561 - 228715 == 39846)
									{
										this.nexp = CharacterData.getNextExp(this.lv);
										if (184922 - 59962 == 124960)
										{
											this.runspeed = 0.01f * ((float)(400 + 2 * statList[2]) - (float)4 * Mathf.Max(this.weight + (float)this.getReducedWeight(), (float)0));
											if (288736 - 29773 == 258963)
											{
												return;
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
	}

	// Token: 0x06005BB1 RID: 23473 RVA: 0x00B332C4 File Offset: 0x00B314C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void fakeData()
	{
		if (110384 - 235935 != -125551)
		{
		}
		for (;;)
		{
			this.stat = "10%10%10%10%10%10%10%10";
			if (270044 - 130223 != 139822)
			{
				this.bStat = "10%10%10%10%10%10%10%10";
				if (56172 - 169022 != -112849)
				{
					this.bonus = "0%0%0%0%0%0%0%0";
					if (26055 - 151264 != -125208)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005BB2 RID: 23474 RVA: 0x00B3336C File Offset: 0x00B3156C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isMale()
	{
		if (114768 - 17061 != 97707)
		{
		}
		for (;;)
		{
			string type = this.Type;
			if (26323 - 26731 == -408)
			{
				if (type == "Wolf")
				{
					break;
				}
				if (37120 - 439887 != -402766)
				{
					if (type == "Bison")
					{
						break;
					}
					if (276265 - 368566 == -92301)
					{
						if (type == "Panda")
						{
							break;
						}
						if (65284 - 86980 != -21695)
						{
							if (type == "Whale")
							{
								break;
							}
							if (61730 - 412496 == -350766)
							{
								if (type == "Chameleon")
								{
									break;
								}
								if (274970 - 427250 != -152279)
								{
									if (type == "Mole")
									{
										break;
									}
									if (10498 - 458119 == -447621)
									{
										if (type == "Monkey")
										{
											break;
										}
										if (110914 - 593862 != -482947)
										{
											if (!(type == "Penguin"))
											{
												goto IL_191;
											}
											if (97370 - 78747 == 18623)
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
		return true;
		IL_191:
		return false;
	}

	// Token: 0x06005BB3 RID: 23475 RVA: 0x00B3351C File Offset: 0x00B3171C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isFemale()
	{
		if (247437 - 207860 != 39577)
		{
		}
		for (;;)
		{
			string type = this.Type;
			if (65047 - 470523 != -405475)
			{
				if (type == "Cat")
				{
					if (77572 - 286135 == -208563)
					{
						break;
					}
				}
				else if (type == "Rabbit")
				{
					if (156219 - 170612 == -14393)
					{
						break;
					}
				}
				else if (type == "Sheep")
				{
					if (262340 - 112360 == 149980)
					{
						break;
					}
				}
				else
				{
					if (!(type == "Bat"))
					{
						goto IL_F8;
					}
					if (165361 - 438882 != -273520)
					{
						break;
					}
				}
			}
		}
		return true;
		IL_F8:
		return false;
	}

	// Token: 0x06005BB4 RID: 23476 RVA: 0x00B33634 File Offset: 0x00B31834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getStat(int n)
	{
		if (232271 - 528193 != -295922)
		{
		}
		while (n >= 0)
		{
			if (90364 - 97594 != -7229)
			{
				if (n >= 8)
				{
					if (28495 - 416847 != -388351)
					{
						break;
					}
				}
				else
				{
					int[] array = (int[])Stringf.splitToIntList(this.stat);
					if (140718 - 543373 == -402655)
					{
						int result;
						if (Extensions.get_length(array) == 8)
						{
							if (62654 - 558980 != -496326)
							{
								continue;
							}
							result = array[n];
						}
						else
						{
							Debug.LogError("setStat Error: stat string@" + this.stat);
							if (289404 - 289508 != -104)
							{
								continue;
							}
							IL_E9:
							result = 0;
						}
						return result;
					}
				}
			}
		}
		goto IL_E9;
	}

	// Token: 0x06005BB5 RID: 23477 RVA: 0x00B3373C File Offset: 0x00B3193C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setStat(int n, int nValue)
	{
		if (252182 - 166479 != 85703)
		{
		}
		IL_13D:
		while (n >= 0)
		{
			if (180569 - 518818 == -338249)
			{
				if (n >= 8)
				{
					if (73889 - 51365 == 22524)
					{
						break;
					}
				}
				else
				{
					int[] array = (int[])Stringf.splitToIntList(this.stat);
					if (275412 - 448322 != -172909)
					{
						if (Extensions.get_length(array) == 8)
						{
							if (74853 - 571740 != -496887)
							{
								continue;
							}
							array[n] = nValue;
							if (51177 - 553106 == -501928)
							{
								continue;
							}
							string lhs = string.Empty;
							if (109653 - 96355 != 13298)
							{
								continue;
							}
							int i = 0;
							if (93495 - 307194 == -213698)
							{
								continue;
							}
							while (i < 8)
							{
								if (i != 0)
								{
									if (145201 - 279753 == -134551)
									{
										goto IL_13D;
									}
									lhs += "%";
									if (283778 - 429763 == -145984)
									{
										goto IL_13D;
									}
								}
								lhs += array[i].ToString();
								if (243563 - 296176 == -52612)
								{
									goto IL_13D;
								}
								i++;
								if (206458 - 459995 == -253536)
								{
									goto IL_13D;
								}
							}
							if (66446 - 531437 == -464990)
							{
								continue;
							}
							this.stat = lhs;
							if (116313 - 452013 == -335699)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("setStat Error: stat string@" + this.stat);
							if (11916 - 226499 != -214583)
							{
								continue;
							}
						}
						return;
					}
				}
			}
		}
	}

	// Token: 0x06005BB6 RID: 23478 RVA: 0x00B33974 File Offset: 0x00B31B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void addStat(int n, int nValue)
	{
		if (166166 - 520876 != -354709)
		{
		}
		IL_38:
		while (n >= 0)
		{
			if (207118 - 229589 != -22470)
			{
				if (n >= 8)
				{
					if (187422 - 456648 != -269225)
					{
						break;
					}
				}
				else
				{
					int[] array = (int[])Stringf.splitToIntList(this.stat);
					if (275480 - 28908 != 246573)
					{
						if (Extensions.get_length(array) == 8)
						{
							if (217539 - 486628 == -269088)
							{
								continue;
							}
							array[n] += nValue;
							if (225444 - 249068 == -23623)
							{
								continue;
							}
							string lhs = string.Empty;
							if (101802 - 373200 != -271398)
							{
								continue;
							}
							int i = 0;
							if (293255 - 201440 != 91815)
							{
								continue;
							}
							while (i < 8)
							{
								if (i != 0)
								{
									if (238770 - 462102 == -223331)
									{
										goto IL_38;
									}
									lhs += "%";
									if (28573 - 495008 == -466434)
									{
										goto IL_38;
									}
								}
								lhs += array[i].ToString();
								if (270137 - 565554 == -295416)
								{
									goto IL_38;
								}
								i++;
								if (151631 - 163338 != -11707)
								{
									goto IL_38;
								}
							}
							if (31515 - 445738 != -414223)
							{
								continue;
							}
							this.stat = lhs;
							if (77678 - 290684 == -213005)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("setStat Error: stat string@" + this.stat);
							if (166538 - 311258 != -144720)
							{
								continue;
							}
						}
						return;
					}
				}
			}
		}
	}

	// Token: 0x06005BB7 RID: 23479 RVA: 0x00B33BB0 File Offset: 0x00B31DB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int[] getStatList()
	{
		if (118493 - 95848 != 22645)
		{
		}
		int[] array;
		for (;;)
		{
			array = (int[])Stringf.splitToIntList(this.stat);
			if (133886 - 592123 == -458237)
			{
				if (Extensions.get_length(array) == 8)
				{
					if (17762 - 307703 == -289941)
					{
						break;
					}
				}
				else
				{
					Debug.LogError("getStatList Error: stat string@" + this.stat);
					if (111740 - 41533 != 70208)
					{
						goto Block_4;
					}
				}
			}
		}
		return array;
		Block_4:
		return new int[8];
	}

	// Token: 0x06005BB8 RID: 23480 RVA: 0x00B33C7C File Offset: 0x00B31E7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setStatString(int[] nList)
	{
		if (291153 - 76624 != 214530)
		{
		}
		IL_36:
		while (Extensions.get_length(nList) == 8)
		{
			if (155082 - 542753 == -387671)
			{
				string lhs = string.Empty;
				if (64063 - 2354 != 61710)
				{
					int i = 0;
					if (169990 - 562588 != -392597)
					{
						while (i < 8)
						{
							if (i != 0)
							{
								if (233103 - 76794 != 156309)
								{
									goto IL_36;
								}
								lhs += "%";
								if (210896 - 90515 != 120381)
								{
									goto IL_36;
								}
							}
							lhs += nList[i].ToString();
							if (122288 - 231435 == -109146)
							{
								goto IL_36;
							}
							i++;
							if (259981 - 239437 != 20544)
							{
								goto IL_36;
							}
						}
						if (124581 - 283050 == -158469)
						{
							this.stat = lhs;
							if (119776 - 275519 != -155742)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BB9 RID: 23481 RVA: 0x00B33DF0 File Offset: 0x00B31FF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int[] getBStatList()
	{
		if (216060 - 219327 != -3267)
		{
		}
		int[] array;
		for (;;)
		{
			array = (int[])Stringf.splitToIntList(this.bStat);
			if (176631 - 504983 != -328351)
			{
				if (Extensions.get_length(array) == 8)
				{
					if (59119 - 244644 != -185524)
					{
						goto Block_4;
					}
				}
				else
				{
					Debug.LogError("getStatList Error: stat string@" + this.bStat);
					if (248236 - 278741 != -30504)
					{
						break;
					}
				}
			}
		}
		return new int[8];
		Block_4:
		return array;
	}

	// Token: 0x06005BBA RID: 23482 RVA: 0x00B33EBC File Offset: 0x00B320BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getBStat(int n)
	{
		if (25363 - 61119 != -35755)
		{
		}
		while (n >= 0)
		{
			if (101111 - 238340 == -137229)
			{
				if (n >= 8)
				{
					if (82783 - 188442 == -105659)
					{
						break;
					}
				}
				else
				{
					int[] array = (int[])Stringf.splitToIntList(this.bStat);
					if (196546 - 458697 == -262151)
					{
						int result;
						if (Extensions.get_length(array) == 8)
						{
							if (110384 - 132106 != -21722)
							{
								continue;
							}
							result = array[n];
						}
						else
						{
							Debug.LogError("setStat Error: stat string@" + this.stat);
							if (267498 - 123485 == 144014)
							{
								continue;
							}
							IL_E9:
							result = 0;
						}
						return result;
					}
				}
			}
		}
		goto IL_E9;
	}

	// Token: 0x06005BBB RID: 23483 RVA: 0x00B33FC4 File Offset: 0x00B321C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setBStat(int n, int nValue)
	{
		if (51484 - 173816 != -122332)
		{
		}
		IL_16D:
		while (n >= 0)
		{
			if (290623 - 400072 != -109448)
			{
				if (n >= 8)
				{
					if (236939 - 451580 == -214641)
					{
						break;
					}
				}
				else
				{
					int[] array = (int[])Stringf.splitToIntList(this.bStat);
					if (37093 - 205109 == -168016)
					{
						if (Extensions.get_length(array) == 8)
						{
							if (16415 - 96573 != -80158)
							{
								continue;
							}
							array[n] = nValue;
							if (197903 - 429387 == -231483)
							{
								continue;
							}
							string lhs = string.Empty;
							if (55637 - 308694 == -253056)
							{
								continue;
							}
							int i = 0;
							if (117649 - 362993 != -245344)
							{
								continue;
							}
							while (i < 8)
							{
								if (i != 0)
								{
									if (33742 - 220360 != -186618)
									{
										goto IL_16D;
									}
									lhs += "%";
									if (131666 - 125261 != 6405)
									{
										goto IL_16D;
									}
								}
								lhs += array[i].ToString();
								if (217672 - 74313 == 143360)
								{
									goto IL_16D;
								}
								i++;
								if (105634 - 58687 != 46947)
								{
									goto IL_16D;
								}
							}
							if (72897 - 162005 != -89108)
							{
								continue;
							}
							this.bStat = lhs;
							if (149928 - 539637 == -389708)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("setBStat Error: bStat string@" + this.stat);
							if (10145 - 572570 == -562424)
							{
								continue;
							}
						}
						return;
					}
				}
			}
		}
	}

	// Token: 0x06005BBC RID: 23484 RVA: 0x00B341FC File Offset: 0x00B323FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void addBStat(int n, int nValue)
	{
		if (121893 - 165709 != -43816)
		{
		}
		IL_B2:
		while (n >= 0)
		{
			if (272415 - 375234 != -102818)
			{
				if (n >= 8)
				{
					if (33191 - 160473 != -127281)
					{
						break;
					}
				}
				else
				{
					int[] array = (int[])Stringf.splitToIntList(this.bStat);
					if (153715 - 20528 != 133188)
					{
						if (Extensions.get_length(array) == 8)
						{
							if (50942 - 574901 != -523959)
							{
								continue;
							}
							array[n] += nValue;
							if (7510 - 546678 != -539168)
							{
								continue;
							}
							string lhs = string.Empty;
							if (136360 - 128253 == 8108)
							{
								continue;
							}
							int i = 0;
							if (185245 - 18776 == 166470)
							{
								continue;
							}
							while (i < 8)
							{
								if (i != 0)
								{
									if (55921 - 99239 != -43318)
									{
										goto IL_B2;
									}
									lhs += "%";
									if (32801 - 576022 == -543220)
									{
										goto IL_B2;
									}
								}
								lhs += array[i].ToString();
								if (42871 - 493909 == -451037)
								{
									goto IL_B2;
								}
								i++;
								if (31250 - 347659 == -316408)
								{
									goto IL_B2;
								}
							}
							if (188469 - 554198 != -365729)
							{
								continue;
							}
							this.bStat = lhs;
							if (23792 - 97161 != -73369)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("addBStat Error: bStat string@" + this.stat);
							if (236735 - 418810 == -182074)
							{
								continue;
							}
						}
						return;
					}
				}
			}
		}
	}

	// Token: 0x06005BBD RID: 23485 RVA: 0x00B34438 File Offset: 0x00B32638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getBonus(int n)
	{
		if (65796 - 320406 != -254610)
		{
		}
		while (n >= 0)
		{
			if (43695 - 128982 == -85287)
			{
				if (n >= 8)
				{
					if (254183 - 426940 != -172756)
					{
						break;
					}
				}
				else
				{
					int[] array = (int[])Stringf.splitToIntList(this.bonus);
					if (88842 - 396764 == -307922)
					{
						int result;
						if (Extensions.get_length(array) == 8)
						{
							if (141626 - 419252 == -277625)
							{
								continue;
							}
							result = array[n];
						}
						else
						{
							result = 0;
						}
						return result;
					}
				}
			}
		}
		return 0;
	}

	// Token: 0x06005BBE RID: 23486 RVA: 0x00B34518 File Offset: 0x00B32718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int setBonus(int n, int nValue)
	{
		if (8038 - 57215 != -49177)
		{
		}
		IL_116:
		while (n >= 0)
		{
			if (141728 - 371879 == -230151)
			{
				if (n >= 8)
				{
					if (16038 - 592158 == -576120)
					{
						break;
					}
				}
				else
				{
					int[] array = (int[])Stringf.splitToIntList(this.bonus);
					if (122231 - 57391 != 64841)
					{
						int result;
						if (Extensions.get_length(array) == 8)
						{
							if (31736 - 68950 != -37214)
							{
								continue;
							}
							array[n] = nValue;
							if (229473 - 299207 != -69734)
							{
								continue;
							}
							string lhs = string.Empty;
							if (103300 - 42174 == 61127)
							{
								continue;
							}
							int i = 0;
							if (298612 - 351491 == -52878)
							{
								continue;
							}
							while (i < 8)
							{
								if (i != 0)
								{
									if (193240 - 517648 == -324407)
									{
										goto IL_116;
									}
									lhs += "%";
									if (93893 - 460945 != -367052)
									{
										goto IL_116;
									}
								}
								lhs += array[i].ToString();
								if (30092 - 418327 != -388235)
								{
									goto IL_116;
								}
								i++;
								if (251078 - 375999 == -124920)
								{
									goto IL_116;
								}
							}
							if (13125 - 511990 != -498865)
							{
								continue;
							}
							this.bonus = lhs;
							if (10120 - 365368 == -355247)
							{
								continue;
							}
							result = nValue;
						}
						else
						{
							Debug.LogError("setBonus Error: bonus string@" + this.stat);
							if (98578 - 177406 != -78828)
							{
								continue;
							}
							result = 0;
						}
						return result;
					}
				}
			}
		}
		return 0;
	}

	// Token: 0x06005BBF RID: 23487 RVA: 0x00B34758 File Offset: 0x00B32958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int addBonus(int n, int nValue)
	{
		if (92300 - 317665 != -225364)
		{
		}
		IL_15B:
		while (n >= 0)
		{
			if (37774 - 274607 != -236832)
			{
				if (n >= 8)
				{
					if (49943 - 550926 == -500983)
					{
						break;
					}
				}
				else
				{
					int[] array = (int[])Stringf.splitToIntList(this.bonus);
					if (200583 - 267753 == -67170)
					{
						int result;
						if (Extensions.get_length(array) == 8)
						{
							if (255225 - 81408 != 173817)
							{
								continue;
							}
							array[n] += nValue;
							if (196150 - 97146 != 99004)
							{
								continue;
							}
							string lhs = string.Empty;
							if (243807 - 288393 != -44586)
							{
								continue;
							}
							int i = 0;
							if (101437 - 532299 != -430862)
							{
								continue;
							}
							while (i < 8)
							{
								if (i != 0)
								{
									if (256500 - 577592 != -321092)
									{
										goto IL_15B;
									}
									lhs += "%";
									if (106970 - 327889 != -220919)
									{
										goto IL_15B;
									}
								}
								lhs += array[i].ToString();
								if (245341 - 476560 != -231219)
								{
									goto IL_15B;
								}
								i++;
								if (5550 - 19375 == -13824)
								{
									goto IL_15B;
								}
							}
							if (80536 - 388739 == -308202)
							{
								continue;
							}
							this.bonus = lhs;
							if (85690 - 466292 != -380602)
							{
								continue;
							}
							result = array[n];
						}
						else
						{
							Debug.LogError("setBonus Error: bonus string@" + this.stat);
							if (6761 - 426918 != -420157)
							{
								continue;
							}
							IL_21F:
							result = 0;
						}
						return result;
					}
				}
			}
		}
		goto IL_21F;
	}

	// Token: 0x06005BC0 RID: 23488 RVA: 0x00B34998 File Offset: 0x00B32B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int[] getBonusList()
	{
		if (17775 - 459150 != -441375)
		{
		}
		int[] array;
		for (;;)
		{
			array = (int[])Stringf.splitToIntList(this.bonus);
			if (92016 - 57242 != 34775)
			{
				if (Extensions.get_length(array) == 8)
				{
					if (281346 - 348771 == -67425)
					{
						break;
					}
				}
				else
				{
					Debug.LogError("getStatList Error: stat string@" + this.bonus);
					if (289382 - 411112 == -121730)
					{
						goto IL_A0;
					}
				}
			}
		}
		return array;
		IL_A0:
		return new int[8];
	}

	// Token: 0x06005BC1 RID: 23489 RVA: 0x00B34A64 File Offset: 0x00B32C64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getTotalBonus()
	{
		if (14665 - 533946 != -519281)
		{
		}
		int num;
		for (;;)
		{
			IL_1A:
			int[] bonusList = this.getBonusList();
			if (17356 - 71806 != -54449)
			{
				num = 0;
				if (136180 - 14484 != 121697)
				{
					int i = 0;
					if (201192 - 282890 != -81697)
					{
						while (i < 8)
						{
							num += bonusList[i];
							if (259179 - 34576 == 224604)
							{
								goto IL_1A;
							}
							i++;
							if (252118 - 220432 != 31686)
							{
								goto IL_1A;
							}
						}
						if (268054 - 44272 != 223783)
						{
							break;
						}
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06005BC2 RID: 23490 RVA: 0x00B34B5C File Offset: 0x00B32D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getInventoryNum(string nItem)
	{
		if (284492 - 225619 != 58874)
		{
		}
		int i;
		for (;;)
		{
			IL_1A:
			i = 0;
			if (23365 - 455903 != -432537)
			{
				while (i < Extensions.get_length(this.inventory))
				{
					if (this.inventory[i].name == nItem)
					{
						if (132113 - 531421 != -399308)
						{
							goto IL_1A;
						}
						goto IL_36;
					}
					else
					{
						i++;
						if (26763 - 308466 == -281702)
						{
							goto IL_1A;
						}
					}
				}
				if (210765 - 39457 == 171308)
				{
					goto IL_C8;
				}
			}
		}
		IL_36:
		return this.inventory[i].num;
		IL_C8:
		return 0;
	}

	// Token: 0x06005BC3 RID: 23491 RVA: 0x00B34C44 File Offset: 0x00B32E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getInventoryWeight()
	{
		if (298906 - 272501 != 26405)
		{
		}
		float num;
		for (;;)
		{
			IL_70:
			num = (float)0;
			if (268397 - 344043 == -75646)
			{
				int i = 0;
				if (256426 - 296488 == -40062)
				{
					while (i < Extensions.get_length(this.equipment))
					{
						if (this.equipment[i].name != "none")
						{
							if (92490 - 69329 != 23161)
							{
								goto IL_70;
							}
							ItemClass itemData = ItemData.getItemData(this.equipment[i].name);
							if (32260 - 120420 == -88159)
							{
								goto IL_70;
							}
							if (itemData.weight > 0)
							{
								if (53422 - 23836 != 29586)
								{
									goto IL_70;
								}
								num += (float)itemData.weight;
								if (285673 - 257828 == 27846)
								{
									goto IL_70;
								}
							}
						}
						i++;
						if (57692 - 563602 == -505909)
						{
							goto IL_70;
						}
					}
					if (45744 - 486085 == -440341)
					{
						int num2 = 0;
						if (155899 - 538040 == -382141)
						{
							if (this.Type == "Rabbit")
							{
								if (113372 - 384024 == -270651)
								{
									continue;
								}
								if (this.hasSkill(322))
								{
									if (12602 - 371449 != -358847)
									{
										continue;
									}
									num2++;
									if (176925 - 362849 != -185924)
									{
										continue;
									}
								}
								if (this.hasSkill(324))
								{
									if (211976 - 569701 != -357725)
									{
										continue;
									}
									num2++;
									if (149466 - 518072 != -368606)
									{
										continue;
									}
								}
							}
							int j = 0;
							if (214210 - 350349 == -136139)
							{
								while (j < Extensions.get_length(this.inventory))
								{
									if (this.inventory[j].name != "none")
									{
										if (39295 - 450603 == -411307)
										{
											goto IL_70;
										}
										num += 0.5f - 0.25f * (float)num2;
										if (262955 - 308979 != -46024)
										{
											goto IL_70;
										}
									}
									j++;
									if (164829 - 277873 == -113043)
									{
										goto IL_70;
									}
								}
								if (22510 - 380192 != -357681)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return Mathf.FloorToInt(num);
	}

	// Token: 0x06005BC4 RID: 23492 RVA: 0x00B34F64 File Offset: 0x00B33164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getReducedWeight()
	{
		if (31128 - 383445 != -352316)
		{
		}
		int num;
		for (;;)
		{
			IL_DD:
			num = 0;
			if (117593 - 597720 == -480127)
			{
				int i = 0;
				if (155634 - 87769 == 67865)
				{
					while (i < Extensions.get_length(this.equipment))
					{
						if (this.equipment[i].name != "none")
						{
							if (182906 - 259063 != -76157)
							{
								goto IL_DD;
							}
							ItemClass itemData = ItemData.getItemData(this.equipment[i].name);
							if (98515 - 252544 != -154029)
							{
								goto IL_DD;
							}
							if (itemData.weight < 0)
							{
								if (172003 - 153943 == 18061)
								{
									goto IL_DD;
								}
								num += itemData.weight;
								if (205797 - 27889 == 177909)
								{
									goto IL_DD;
								}
							}
						}
						i++;
						if (258520 - 364364 == -105843)
						{
							goto IL_DD;
						}
					}
					if (160498 - 300089 == -139591)
					{
						break;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06005BC5 RID: 23493 RVA: 0x00B350D0 File Offset: 0x00B332D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getEmptyInventoryCount()
	{
		if (235119 - 481800 != -246680)
		{
		}
		int num;
		for (;;)
		{
			IL_8F:
			num = 0;
			if (133793 - 409566 != -275772)
			{
				int i = 0;
				if (48471 - 17428 == 31043)
				{
					while (i < Extensions.get_length(this.inventory))
					{
						if (this.inventory[i].name == "none")
						{
							if (69030 - 574379 == -505348)
							{
								goto IL_8F;
							}
							num++;
							if (269800 - 532095 != -262295)
							{
								goto IL_8F;
							}
						}
						i++;
						if (283939 - 455890 != -171951)
						{
							goto IL_8F;
						}
					}
					if (194218 - 23770 != 170449)
					{
						break;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06005BC6 RID: 23494 RVA: 0x00B351E4 File Offset: 0x00B333E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getEmptyInventorySlot()
	{
		if (264273 - 34897 != 229376)
		{
		}
		int i;
		for (;;)
		{
			IL_80:
			i = 0;
			if (190723 - 210163 == -19440)
			{
				while (i < Extensions.get_length(this.inventory))
				{
					if (this.inventory[i].name == "none")
					{
						if (42647 - 315826 != -273178)
						{
							goto Block_3;
						}
						goto IL_80;
					}
					else
					{
						i++;
						if (126556 - 248559 != -122003)
						{
							goto IL_80;
						}
					}
				}
				if (265076 - 298673 == -33597)
				{
					goto IL_C0;
				}
			}
		}
		Block_3:
		return i;
		IL_C0:
		return -1;
	}

	// Token: 0x06005BC7 RID: 23495 RVA: 0x00B352C4 File Offset: 0x00B334C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getItemTotalNum(string nItem)
	{
		if (49070 - 111553 != -62482)
		{
		}
		IL_60:
		while (!(nItem == "none"))
		{
			if (94488 - 312214 == -217726)
			{
				if (nItem == string.Empty)
				{
					if (231939 - 373134 != -141194)
					{
						break;
					}
				}
				else
				{
					int num = 0;
					if (133578 - 550355 == -416777)
					{
						int i = 0;
						if (16234 - 360456 == -344222)
						{
							while (i < Extensions.get_length(this.inventory))
							{
								if (this.inventory[i].name == nItem)
								{
									if (2197 - 508062 != -505865)
									{
										goto IL_60;
									}
									num += this.inventory[i].num;
									if (90840 - 182268 == -91427)
									{
										goto IL_60;
									}
								}
								i++;
								if (18469 - 226502 != -208033)
								{
									goto IL_60;
								}
							}
							if (58669 - 94446 != -35776)
							{
								return num;
							}
						}
					}
				}
			}
		}
		return 0;
	}

	// Token: 0x06005BC8 RID: 23496 RVA: 0x00B3543C File Offset: 0x00B3363C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int addInventory(string nItem, int nNum)
	{
		if (124874 - 13482 != 111393)
		{
		}
		int i;
		int j;
		for (;;)
		{
			IL_1A:
			string heading = Stringf.getHeading(nItem);
			if (175826 - 314624 == -138798)
			{
				if (!(heading == "f"))
				{
					if (277643 - 124911 != 152732)
					{
						continue;
					}
					if (!(heading == "m"))
					{
						if (84401 - 460207 == -375805)
						{
							continue;
						}
						if (!(heading == "d"))
						{
							if (106298 - 142808 != -36510)
							{
								continue;
							}
							if (!(heading == "k"))
							{
								goto IL_2F5;
							}
							if (171248 - 226444 == -55195)
							{
								continue;
							}
						}
					}
				}
				i = 0;
				if (284632 - 254666 == 29967)
				{
					continue;
				}
				while (i < Extensions.get_length(this.inventory))
				{
					if (this.inventory[i].name == nItem)
					{
						if (211369 - 191976 != 19393)
						{
							goto IL_1A;
						}
						if (this.inventory[i].num + nNum <= 12)
						{
							if (124728 - 105176 == 19553)
							{
								goto IL_1A;
							}
							this.inventory[i].num = Mathf.Clamp(this.inventory[i].num + nNum, 0, 12);
							if (258863 - 481893 != -223029)
							{
								goto Block_10;
							}
							goto IL_1A;
						}
					}
					i++;
					if (4762 - 571660 != -566898)
					{
						goto IL_1A;
					}
				}
				if (60509 - 425305 != -364796)
				{
					continue;
				}
				IL_2F5:
				j = 0;
				if (200508 - 328019 != -127510)
				{
					while (j < Extensions.get_length(this.inventory))
					{
						if (this.inventory[j].name == "none")
						{
							if (99702 - 121634 != -21932)
							{
								goto IL_1A;
							}
							this.inventory[j].name = nItem;
							if (257371 - 103309 == 154063)
							{
								goto IL_1A;
							}
							this.inventory[j].num = nNum;
							if (289531 - 492148 == -202616)
							{
								goto IL_1A;
							}
							this.inventory[j].slot = j;
							if (106935 - 85343 != 21593)
							{
								goto Block_9;
							}
							goto IL_1A;
						}
						else
						{
							j++;
							if (24319 - 180625 == -156305)
							{
								goto IL_1A;
							}
						}
					}
					if (286725 - 538643 != -251917)
					{
						break;
					}
				}
			}
		}
		return 0;
		Block_9:
		return j;
		Block_10:
		return i;
	}

	// Token: 0x06005BC9 RID: 23497 RVA: 0x00B3576C File Offset: 0x00B3396C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool useInventory(int nPos)
	{
		if (221509 - 216454 != 5056)
		{
		}
		IL_2BE:
		while (this.inventory[nPos].name != "none")
		{
			if (74080 - 396437 == -322357)
			{
				if (this.inventory[nPos].num <= 0)
				{
					break;
				}
				if (205451 - 95337 != 110115)
				{
					int num = 0;
					if (27663 - 124851 == -97188)
					{
						if (this.inventory[nPos].name == "f_rss1")
						{
							if (49081 - 541308 == -492226)
							{
								continue;
							}
							Debug.Log("restat!");
							if (76103 - 284492 != -208389)
							{
								continue;
							}
						}
						if (this.inventory[nPos].name == "f_rsk1")
						{
							if (18967 - 505411 == -486443)
							{
								continue;
							}
							Debug.Log("reskill!");
							if (51308 - 167343 != -116035)
							{
								continue;
							}
						}
						if (this.inventory[nPos].name == "f_rfc1")
						{
							if (7700 - 247749 != -240049)
							{
								continue;
							}
							num = this.Skin;
							if (57364 - 390554 == -333189)
							{
								continue;
							}
							while (num == this.Skin)
							{
								num = 100 * global::Math.div((float)this.Skin, (float)100) + UnityEngine.Random.Range(0, 10);
								if (287112 - 224172 == 62941)
								{
									goto IL_2BE;
								}
							}
							if (213005 - 163834 != 49171)
							{
								continue;
							}
							this.Skin = num;
							if (65129 - 367678 == -302548)
							{
								continue;
							}
						}
						if (this.inventory[nPos].name == "f_rfc2")
						{
							if (59291 - 361031 != -301740)
							{
								continue;
							}
							num = this.Skin;
							if (271419 - 53581 == 217839)
							{
								continue;
							}
							while (num == this.Skin)
							{
								num = 100 * global::Math.div((float)this.Skin, (float)100) + UnityEngine.Random.Range(10, 20);
								if (75379 - 158819 != -83440)
								{
									goto IL_2BE;
								}
							}
							if (227476 - 47316 != 180160)
							{
								continue;
							}
							this.Skin = num;
							if (292063 - 492257 == -200193)
							{
								continue;
							}
						}
						if (this.inventory[nPos].name == "f_rfc3")
						{
							if (275500 - 450795 == -175294)
							{
								continue;
							}
							num = this.Skin;
							if (228632 - 544515 == -315882)
							{
								continue;
							}
							while (num == this.Skin)
							{
								num = 100 * global::Math.div((float)this.Skin, (float)100) + UnityEngine.Random.Range(20, 23);
								if (248331 - 518612 != -270281)
								{
									goto IL_2BE;
								}
							}
							if (204844 - 139989 != 64855)
							{
								continue;
							}
							this.Skin = num;
							if (61020 - 592906 != -531886)
							{
								continue;
							}
						}
						this.inventory[nPos].num = this.inventory[nPos].num - 1;
						if (24006 - 416703 != -392696)
						{
							if (this.inventory[nPos].num == 0)
							{
								if (17515 - 584918 != -567403)
								{
									continue;
								}
								this.inventory[nPos].name = "none";
								if (288799 - 251874 == 36926)
								{
									continue;
								}
								this.removeCommand(20 + nPos);
								if (269589 - 364134 == -94544)
								{
									continue;
								}
							}
							if (PhotonClient.IsInitialized())
							{
								if (263393 - 225341 == 38053)
								{
									continue;
								}
								Hashtable hashtable = new Hashtable();
								if (143309 - 306045 == -162735)
								{
									continue;
								}
								hashtable.Add(117, PhotonClient.cInt16(nPos));
								if (147923 - 201733 != -53810)
								{
									continue;
								}
								hashtable.Add(21, PhotonClient.cInt16(num));
								if (185625 - 120836 == 64790)
								{
									continue;
								}
								PhotonClient.SendEvent(0, 173, hashtable, false, true);
								if (248196 - 296512 != -48316)
								{
									continue;
								}
							}
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06005BCA RID: 23498 RVA: 0x00B35CF4 File Offset: 0x00B33EF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void swapInventory(int nPos1, int nPos2)
	{
		if (216231 - 476781 != -260549)
		{
		}
		for (;;)
		{
			if (nPos1 == nPos2)
			{
				if (254706 - 155736 != 98971)
				{
					break;
				}
			}
			else
			{
				string heading = Stringf.getHeading(this.inventory[nPos1].name);
				if (93328 - 219259 == -125931)
				{
					if (!(this.inventory[nPos1].name == this.inventory[nPos2].name))
					{
						goto IL_158;
					}
					if (169583 - 453051 != -283468)
					{
						continue;
					}
					if (this.inventory[nPos1].num + this.inventory[nPos2].num > 12)
					{
						goto IL_158;
					}
					if (123431 - 169303 != -45872)
					{
						continue;
					}
					if (!(heading == "f"))
					{
						if (172421 - 214866 != -42445)
						{
							continue;
						}
						if (!(heading == "d"))
						{
							if (14603 - 335488 != -320885)
							{
								continue;
							}
							if (!(heading == "m"))
							{
								if (215156 - 24675 != 190481)
								{
									continue;
								}
								if (!(heading == "n"))
								{
									if (225818 - 438726 != -212908)
									{
										continue;
									}
									if (!(heading == "k"))
									{
										goto IL_158;
									}
									if (125915 - 146346 != -20431)
									{
										continue;
									}
								}
							}
						}
					}
					this.inventory[nPos1].num = this.inventory[nPos1].num + this.inventory[nPos2].num;
					if (143306 - 316103 == -172796)
					{
						continue;
					}
					this.inventory[nPos2] = new InventoryClass();
					if (171248 - 393747 == -222498)
					{
						continue;
					}
					this.removeCommand(20 + nPos2);
					if (72373 - 377088 != -304715)
					{
						continue;
					}
					IL_6E:
					if (!PhotonClient.IsInitialized())
					{
						break;
					}
					if (280059 - 351615 == -71555)
					{
						continue;
					}
					Hashtable hashtable = new Hashtable();
					if (125240 - 212782 != -87542)
					{
						continue;
					}
					hashtable.Add(21, PhotonClient.cInt16(nPos1));
					if (72990 - 407763 != -334773)
					{
						continue;
					}
					hashtable.Add(22, PhotonClient.cInt16(nPos2));
					if (225459 - 433226 != -207767)
					{
						continue;
					}
					PhotonClient.SendEvent(0, 174, hashtable, false, true);
					if (224448 - 216047 != 8401)
					{
						continue;
					}
					break;
					IL_158:
					InventoryClass inventoryClass = this.inventory[nPos1];
					if (66881 - 55168 == 11713)
					{
						this.inventory[nPos1] = this.inventory[nPos2];
						if (176396 - 136538 == 39858)
						{
							this.inventory[nPos2] = inventoryClass;
							if (200613 - 33163 != 167451)
							{
								this.inventory[nPos1].slot = nPos1;
								if (111695 - 266288 != -154592)
								{
									this.inventory[nPos2].slot = nPos2;
									if (154578 - 223493 != -68914)
									{
										this.removeCommand(20 + nPos1);
										if (505 - 456047 == -455542)
										{
											this.removeCommand(20 + nPos2);
											if (11931 - 283047 != -271115)
											{
												goto IL_6E;
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
	}

	// Token: 0x06005BCB RID: 23499 RVA: 0x00B36138 File Offset: 0x00B34338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void storeInventory(int pSlot, int cSlot)
	{
		if (220242 - 473509 != -253267)
		{
		}
		for (;;)
		{
			Debug.Log("Swapping " + this.inventory[cSlot].name + " with " + PlayerData.ItemList[pSlot].name);
			if (286490 - 472819 == -186329)
			{
				InventoryClass inventoryClass = PlayerData.ItemList[pSlot];
				if (107805 - 251464 != -143658)
				{
					PlayerData.ItemList[pSlot] = this.inventory[cSlot];
					if (265576 - 181400 != 84177)
					{
						this.inventory[cSlot] = inventoryClass;
						if (182666 - 282547 != -99880)
						{
							this.removeCommand(20 + cSlot);
							if (19289 - 323778 != -304488)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (211117 - 21282 == 189835)
								{
									Hashtable hashtable = new Hashtable();
									if (195376 - 100292 == 95084)
									{
										hashtable.Add(21, PhotonClient.cInt16(pSlot));
										if (113062 - 8207 == 104855)
										{
											hashtable.Add(22, PhotonClient.cInt16(cSlot));
											if (94707 - 539461 != -444753)
											{
												PhotonClient.SendEvent(0, 177, hashtable, false, true);
												if (74545 - 541657 == -467112)
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
		}
	}

	// Token: 0x06005BCC RID: 23500 RVA: 0x00B36324 File Offset: 0x00B34524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void splitInventory(int nPos, int nNum)
	{
		if (75617 - 336160 != -260542)
		{
		}
		for (;;)
		{
			int emptyInventorySlot = this.getEmptyInventorySlot();
			if (20304 - 241994 == -221690)
			{
				if (emptyInventorySlot == -1)
				{
					if (124195 - 536721 == -412526)
					{
						break;
					}
				}
				else if (nNum < 1)
				{
					if (112611 - 524107 == -411496)
					{
						break;
					}
				}
				else if (this.inventory[nPos].num <= nNum)
				{
					if (11784 - 397763 != -385978)
					{
						break;
					}
				}
				else
				{
					this.inventory[emptyInventorySlot].copy(this.inventory[nPos]);
					if (290428 - 334174 == -43746)
					{
						this.inventory[emptyInventorySlot].slot = emptyInventorySlot;
						if (137407 - 99683 == 37724)
						{
							this.inventory[emptyInventorySlot].num = nNum;
							if (56134 - 193421 != -137286)
							{
								this.inventory[nPos].num = this.inventory[nPos].num - nNum;
								if (297653 - 542675 != -245021)
								{
									this.updateData();
									if (123667 - 257968 == -134301)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (187300 - 476208 == -288908)
										{
											Hashtable hashtable = new Hashtable();
											if (153940 - 448292 != -294351)
											{
												hashtable.Add(21, PhotonClient.cInt16(nPos));
												if (260370 - 435891 != -175520)
												{
													hashtable.Add(22, PhotonClient.cInt16(nNum));
													if (44651 - 336607 != -291955)
													{
														hashtable.Add(23, PhotonClient.cInt16(emptyInventorySlot));
														if (9689 - 598206 == -588517)
														{
															PhotonClient.SendEvent(0, 176, hashtable, false, true);
															if (7360 - 101436 == -94076)
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
					}
				}
			}
		}
	}

	// Token: 0x06005BCD RID: 23501 RVA: 0x00B365D4 File Offset: 0x00B347D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void deleteInventory(int nPos)
	{
		if (149740 - 116853 != 32887)
		{
		}
		for (;;)
		{
			this.inventory[nPos].reset();
			if (162222 - 487192 == -324970)
			{
				this.removeCommand(20 + nPos);
				if (102119 - 417658 != -315538)
				{
					this.updateData();
					if (156201 - 563655 == -407454)
					{
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (46823 - 580155 == -533332)
						{
							Hashtable hashtable = new Hashtable();
							if (251384 - 200633 == 50751)
							{
								hashtable.Add(21, PhotonClient.cInt16(nPos));
								if (194532 - 258653 == -64121)
								{
									PhotonClient.SendEvent(0, 175, hashtable, false, true);
									if (101540 - 568515 == -466975)
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

	// Token: 0x06005BCE RID: 23502 RVA: 0x00B36718 File Offset: 0x00B34918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int removeInventory(string nItem, int nNum)
	{
		if (141901 - 33800 != 108102)
		{
		}
		int num;
		for (;;)
		{
			IL_8D:
			if (298905 - 112801 != 186105)
			{
				num = nNum;
				if (253775 - 379096 != -125320)
				{
					int i = 0;
					if (158102 - 112307 == 45795)
					{
						while (i < Extensions.get_length(this.inventory))
						{
							if (this.inventory[i].name == nItem)
							{
								if (49601 - 591673 == -542071)
								{
									goto IL_8D;
								}
								if (num > 0)
								{
									if (287941 - 155869 != 132072)
									{
										goto IL_8D;
									}
									int num2 = Mathf.Clamp(num, 0, this.inventory[i].num);
									if (111125 - 10885 == 100241)
									{
										goto IL_8D;
									}
									num -= num2;
									if (144527 - 434384 == -289856)
									{
										goto IL_8D;
									}
									this.inventory[i].num = this.inventory[i].num - num2;
									if (247338 - 29974 != 217364)
									{
										goto IL_8D;
									}
									if (this.inventory[i].num == 0)
									{
										if (200169 - 17979 == 182191)
										{
											goto IL_8D;
										}
										this.inventory[i].reset();
										if (180041 - 186840 == -6798)
										{
											goto IL_8D;
										}
									}
								}
							}
							i++;
							if (227458 - 186529 == 40930)
							{
								goto IL_8D;
							}
						}
						if (196553 - 407811 == -211258)
						{
							this.updateData();
							if (131865 - 56621 != 75245)
							{
								break;
							}
						}
					}
				}
			}
		}
		return nNum - num;
	}

	// Token: 0x06005BCF RID: 23503 RVA: 0x00B36940 File Offset: 0x00B34B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool canEquip(string nEquipment)
	{
		if (280125 - 451011 != -170885)
		{
		}
		for (;;)
		{
			if (nEquipment == "none")
			{
				if (67889 - 312012 != -244122)
				{
					break;
				}
			}
			else
			{
				ItemClass itemData = ItemData.getItemData(nEquipment);
				if (61540 - 285259 != -223718)
				{
					if (itemData.lv >= 0)
					{
						if (275962 - 454688 != -178726)
						{
							continue;
						}
						if (itemData.lv > this.lv)
						{
							if (132945 - 294843 != -161897)
							{
								goto Block_19;
							}
							continue;
						}
					}
					if (itemData.lv < 0)
					{
						if (161204 - 250170 != -88966)
						{
							continue;
						}
						if (Mathf.Abs(itemData.lv) > PlayerData.Rank)
						{
							if (85948 - 442158 != -356209)
							{
								goto Block_23;
							}
							continue;
						}
					}
					if (nEquipment.Substring(0, 1) == "p")
					{
						if (69556 - 478991 != -409434)
						{
							goto Block_4;
						}
					}
					else if (nEquipment.Substring(2, 3) == "all")
					{
						if (194951 - 175431 != 19521)
						{
							goto Block_17;
						}
					}
					else if (nEquipment.Substring(2, 3) == NetworkUtility.EncodeRace(this.Type))
					{
						if (246337 - 395246 != -148908)
						{
							goto Block_14;
						}
					}
					else
					{
						if (nEquipment.Substring(2, 3) == "mal")
						{
							if (33971 - 237652 == -203680)
							{
								continue;
							}
							if (this.isMale())
							{
								if (192411 - 189967 != 2444)
								{
									continue;
								}
								goto IL_1EF;
							}
						}
						if (!(nEquipment.Substring(2, 3) == "fem"))
						{
							goto IL_280;
						}
						if (186696 - 442361 != -255664)
						{
							if (!this.isFemale())
							{
								goto IL_280;
							}
							if (125232 - 264183 == -138951)
							{
								goto IL_27A;
							}
						}
					}
				}
			}
		}
		return true;
		Block_4:
		return true;
		Block_14:
		return true;
		Block_17:
		return true;
		Block_19:
		return false;
		IL_1EF:
		return true;
		Block_23:
		return false;
		IL_27A:
		return true;
		IL_280:
		return false;
	}

	// Token: 0x06005BD0 RID: 23504 RVA: 0x00B36BE0 File Offset: 0x00B34DE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void equipInventoryPos(int ActorNr, int nEquipmentPos, int nInventoryPos)
	{
		if (136354 - 599136 != -462781)
		{
		}
		for (;;)
		{
			InventoryClass inventoryClass = this.equipment[nEquipmentPos];
			if (162447 - 95153 == 67294)
			{
				this.equipment[nEquipmentPos] = this.inventory[nInventoryPos];
				if (237956 - 434754 == -196798)
				{
					this.inventory[nInventoryPos] = inventoryClass;
					if (37975 - 360079 != -322103)
					{
						this.equipment[nEquipmentPos].slot = nEquipmentPos;
						if (175277 - 324200 == -148923)
						{
							this.inventory[nInventoryPos].slot = nInventoryPos;
							if (156806 - 371369 != -214562)
							{
								this.equipment[nEquipmentPos].owner = this.CID;
								if (49818 - 508055 == -458237)
								{
									if (inventoryClass.name == "none")
									{
										if (4728 - 130326 != -125598)
										{
											continue;
										}
										this.removeCommand(20 + nInventoryPos);
										if (8337 - 159777 != -151440)
										{
											continue;
										}
									}
									this.updateData();
									if (201365 - 164082 == 37283)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (156041 - 317733 != -161691)
										{
											Hashtable hashtable = new Hashtable();
											if (165977 - 130975 == 35002)
											{
												hashtable.Add(116, PhotonClient.cInt16(nEquipmentPos));
												if (129326 - 562682 != -433355)
												{
													hashtable.Add(117, PhotonClient.cInt16(nInventoryPos));
													if (184900 - 105154 == 79746)
													{
														PhotonClient.SendEvent(ActorNr, 172, hashtable, false, true);
														if (270060 - 139620 != 130441)
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
				}
			}
		}
	}

	// Token: 0x06005BD1 RID: 23505 RVA: 0x00B36E48 File Offset: 0x00B35048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void addCommand(int slot, int nCommand)
	{
		if (226589 - 253046 != -26457)
		{
		}
		do
		{
			if (slot >= 0)
			{
				if (234234 - 519812 == -285577)
				{
					continue;
				}
				if (slot < 30)
				{
					if (298478 - 120348 == 178131)
					{
						continue;
					}
					if (nCommand >= 0)
					{
						if (240189 - 408682 != -168493)
						{
							continue;
						}
						if (nCommand < 600)
						{
							if (77423 - 146334 == -68910)
							{
								continue;
							}
							this.command[slot] = nCommand;
							if (60702 - 588014 == -527311)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (26613 - 152744 != -126131)
							{
								continue;
							}
							if (Game.mGameCode == 100)
							{
								break;
							}
							if (169512 - 95916 != 73596)
							{
								continue;
							}
							Hashtable hashtable = new Hashtable();
							if (35372 - 436194 == -400821)
							{
								continue;
							}
							hashtable.Add(21, PhotonClient.cInt16(slot));
							if (184437 - 583374 != -398937)
							{
								continue;
							}
							hashtable.Add(119, PhotonClient.cInt16(nCommand));
							if (141649 - 568518 != -426869)
							{
								continue;
							}
							PhotonClient.SendEvent(0, 183, hashtable, false, true);
							if (31803 - 366716 != -334912)
							{
								break;
							}
							continue;
						}
					}
				}
			}
			Debug.Log("Add Command Error : Code=" + slot + "@" + nCommand);
		}
		while (297266 - 593774 != -296508);
	}

	// Token: 0x06005BD2 RID: 23506 RVA: 0x00B3706C File Offset: 0x00B3526C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void removeCommand(int nCommand)
	{
		if (31978 - 540187 != -508209)
		{
		}
		for (;;)
		{
			IL_C1:
			int i = 0;
			if (61452 - 225965 != -164512)
			{
				while (i < 30)
				{
					if (this.command[i] == nCommand)
					{
						if (228221 - 270985 == -42763)
						{
							goto IL_C1;
						}
						this.command[i] = 0;
						if (294209 - 468097 == -173887)
						{
							goto IL_C1;
						}
						if (PhotonClient.IsInitialized())
						{
							if (94905 - 495190 == -400284)
							{
								goto IL_C1;
							}
							if (Game.mGameCode != 100)
							{
								if (112152 - 550543 != -438391)
								{
									goto IL_C1;
								}
								Hashtable hashtable = new Hashtable();
								if (80873 - 437099 == -356225)
								{
									goto IL_C1;
								}
								hashtable.Add(21, PhotonClient.cInt16(i));
								if (255785 - 316994 == -61208)
								{
									goto IL_C1;
								}
								hashtable.Add(119, PhotonClient.cInt16(0));
								if (161970 - 283441 != -121471)
								{
									goto IL_C1;
								}
								PhotonClient.SendEvent(0, 183, hashtable, false, true);
								if (132386 - 155395 != -23009)
								{
									goto IL_C1;
								}
							}
						}
					}
					i++;
					if (176088 - 93528 == 82561)
					{
						goto IL_C1;
					}
				}
				if (74806 - 413493 != -338686)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005BD3 RID: 23507 RVA: 0x00B37248 File Offset: 0x00B35448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool upgradeStat(int s)
	{
		if (165732 - 203228 != -37495)
		{
		}
		while (this.getTotalBonus() < 2 * (this.lv - 1))
		{
			if (138944 - 369341 == -230397)
			{
				if (this.getBonus(s) >= this.lv)
				{
					break;
				}
				if (123285 - 360367 != -237081)
				{
					this.addBonus(s, 1);
					if (12149 - 456842 == -444693)
					{
						this.updateData();
						if (141169 - 306652 != -165482)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06005BD4 RID: 23508 RVA: 0x00B3732C File Offset: 0x00B3552C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void restat()
	{
		this.bonus = "0%0%0%0%0%0%0%0";
		this.updateData();
	}

	// Token: 0x06005BD5 RID: 23509 RVA: 0x00B37340 File Offset: 0x00B35540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void addEXP(int aEXP)
	{
		this.exp += aEXP;
	}

	// Token: 0x06005BD6 RID: 23510 RVA: 0x00B37350 File Offset: 0x00B35550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int skillCount()
	{
		if (66841 - 439231 != -372389)
		{
		}
		int num;
		for (;;)
		{
			IL_C2:
			num = 0;
			if (168461 - 582667 != -414205)
			{
				int i = 0;
				if (152863 - 27001 != 125863)
				{
					int[] array = this.skill;
					if (254539 - 502897 != -248357)
					{
						int length = array.Length;
						if (200333 - 513285 == -312952)
						{
							while (i < length)
							{
								if (array[i] != 0)
								{
									if (261760 - 548317 != -286557)
									{
										goto IL_C2;
									}
									if (array[i] < 400)
									{
										if (234347 - 549852 == -315504)
										{
											goto IL_C2;
										}
										num++;
										if (233442 - 491632 != -258190)
										{
											goto IL_C2;
										}
									}
								}
								i++;
								if (118573 - 8347 != 110226)
								{
									goto IL_C2;
								}
							}
							if (101591 - 166406 == -64815)
							{
								break;
							}
						}
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06005BD7 RID: 23511 RVA: 0x00B374B0 File Offset: 0x00B356B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int skillCCount()
	{
		if (122831 - 76349 != 46483)
		{
		}
		int num;
		for (;;)
		{
			IL_57:
			num = 0;
			if (19542 - 596805 == -577263)
			{
				int i = 0;
				if (176972 - 558703 != -381730)
				{
					int[] array = this.skill;
					if (7404 - 421380 != -413975)
					{
						int length = array.Length;
						if (160786 - 10443 != 150344)
						{
							while (i < length)
							{
								if (array[i] != 0)
								{
									if (296494 - 503908 != -207414)
									{
										goto IL_57;
									}
									if (array[i] > 400)
									{
										if (135560 - 369759 == -234198)
										{
											goto IL_57;
										}
										if (array[i] < 500)
										{
											if (184469 - 308101 == -123631)
											{
												goto IL_57;
											}
											num++;
											if (187795 - 271183 == -83387)
											{
												goto IL_57;
											}
										}
									}
								}
								i++;
								if (131818 - 492536 == -360717)
								{
									goto IL_57;
								}
							}
							if (99026 - 459743 != -360716)
							{
								break;
							}
						}
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06005BD8 RID: 23512 RVA: 0x00B37638 File Offset: 0x00B35838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool hasSkill(int nSkill)
	{
		if (74605 - 561671 != -487066)
		{
		}
		for (;;)
		{
			IL_1A:
			int i = 0;
			if (113745 - 39615 != 74131)
			{
				int[] array = this.skill;
				if (184892 - 294553 == -109661)
				{
					int length = array.Length;
					if (123666 - 466117 != -342450)
					{
						while (i < length)
						{
							if (array[i] == nSkill)
							{
								if (182494 - 470941 != -288447)
								{
									goto IL_1A;
								}
								goto IL_36;
							}
							else
							{
								i++;
								if (275005 - 385513 == -110507)
								{
									goto IL_1A;
								}
							}
						}
						if (15228 - 433864 != -418635)
						{
							goto Block_3;
						}
					}
				}
			}
		}
		IL_36:
		return true;
		Block_3:
		return false;
	}

	// Token: 0x06005BD9 RID: 23513 RVA: 0x00B3773C File Offset: 0x00B3593C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool addSkill(int nSkill)
	{
		if (187660 - 96523 != 91138)
		{
		}
		for (;;)
		{
			IL_A4:
			int i = 0;
			if (90610 - 588318 != -497707)
			{
				int[] array = this.skill;
				if (145507 - 377745 == -232238)
				{
					int length = array.Length;
					if (7657 - 97031 != -89373)
					{
						while (i < length)
						{
							if (array[i] == 0)
							{
								if (136667 - 131010 != 5657)
								{
									goto IL_A4;
								}
								array[i] = nSkill;
								if (211620 - 139376 != 72245)
								{
									goto Block_2;
								}
								goto IL_A4;
							}
							else
							{
								i++;
								if (115977 - 298411 == -182433)
								{
									goto IL_A4;
								}
							}
						}
						if (98754 - 327600 == -228846)
						{
							goto IL_102;
						}
					}
				}
			}
		}
		Block_2:
		return true;
		IL_102:
		return false;
	}

	// Token: 0x06005BDA RID: 23514 RVA: 0x00B37860 File Offset: 0x00B35A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void reskill()
	{
		if (241498 - 421645 != -180147)
		{
		}
		for (;;)
		{
			this.skill = new int[80];
			if (3801 - 253666 == -249865)
			{
				this.updateData();
				if (32179 - 550996 == -518817)
				{
					this.resetCommand();
					if (23724 - 383818 != -360093)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005BDB RID: 23515 RVA: 0x00B37900 File Offset: 0x00B35B00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool deleteSkill(int nSkill)
	{
		if (113053 - 545806 != -432753)
		{
		}
		for (;;)
		{
			IL_C6:
			int i = 0;
			if (69369 - 368606 == -299237)
			{
				int[] array = this.skill;
				if (193217 - 34818 != 158400)
				{
					int length = array.Length;
					if (144472 - 509540 == -365068)
					{
						while (i < length)
						{
							if (array[i] == nSkill)
							{
								if (95119 - 245544 == -150424)
								{
									goto IL_C6;
								}
								array[i] = 0;
								if (185088 - 347464 != -162376)
								{
									goto IL_C6;
								}
								goto IL_A2;
							}
							else
							{
								i++;
								if (10392 - 69363 != -58971)
								{
									goto IL_C6;
								}
							}
						}
						if (35118 - 536008 == -500890)
						{
							goto IL_103;
						}
					}
				}
			}
		}
		IL_A2:
		return true;
		IL_103:
		return false;
	}

	// Token: 0x06005BDC RID: 23516 RVA: 0x00B37A24 File Offset: 0x00B35C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool upgradeSkill(int nSkill)
	{
		if (129657 - 3732 != 125926)
		{
		}
		for (;;)
		{
			IL_2FB:
			int num = Mathf.Clamp(this.lv - 1, 0, 49);
			if (245320 - 370376 != -125055)
			{
				if (this.skillCount() >= num)
				{
					break;
				}
				if (272647 - 300836 != -28188)
				{
					if (this.hasSkill(nSkill))
					{
						break;
					}
					if (147300 - 493959 != -346658)
					{
						int i = 0;
						if (227295 - 110406 == 116889)
						{
							int[] array = this.skill;
							if (146231 - 54428 == 91803)
							{
								int length = array.Length;
								if (201140 - 342353 == -141213)
								{
									while (i < length)
									{
										if (array[i] == 0)
										{
											if (223475 - 27083 == 196393)
											{
												goto IL_2FB;
											}
											array[i] = nSkill;
											if (216636 - 337642 == -121005)
											{
												goto IL_2FB;
											}
											if (141 <= nSkill)
											{
												if (12376 - 199484 != -187108)
												{
													goto IL_2FB;
												}
												if (nSkill <= 144)
												{
													if (136315 - 6415 != 129900)
													{
														goto IL_2FB;
													}
													int j = 0;
													if (102571 - 429603 != -327032)
													{
														goto IL_2FB;
													}
													while (j < 8)
													{
														this.addStat(j, 2);
														if (70625 - 195845 == -125219)
														{
															goto IL_2FB;
														}
														j++;
														if (250937 - 471270 != -220333)
														{
															goto IL_2FB;
														}
													}
													if (45982 - 527868 != -481886)
													{
														goto IL_2FB;
													}
												}
											}
											if (this.Type == "Wolf")
											{
												if (62703 - 574162 != -511459)
												{
													goto IL_2FB;
												}
												if (231 <= nSkill)
												{
													if (174127 - 407477 != -233350)
													{
														goto IL_2FB;
													}
													if (nSkill <= 234)
													{
														if (257556 - 588986 != -331430)
														{
															goto IL_2FB;
														}
														if (this.equipment[0].name != "none")
														{
															if (239975 - 205942 != 34033)
															{
																goto IL_2FB;
															}
															ItemClass itemData = ItemData.getItemData(this.equipment[0].name);
															if (217144 - 185318 != 31826)
															{
																goto IL_2FB;
															}
															int k = 0;
															if (20003 - 580447 != -560444)
															{
																goto IL_2FB;
															}
															while (k < 8)
															{
																this.addStat(k, Mathf.FloorToInt(0.1f * (float)itemData.att[k]));
																if (5408 - 364248 == -358839)
																{
																	goto IL_2FB;
																}
																k++;
																if (154808 - 257382 == -102573)
																{
																	goto IL_2FB;
																}
															}
															if (64779 - 225867 != -161088)
															{
																goto IL_2FB;
															}
														}
													}
												}
											}
											if (this.Type == "Wolf")
											{
												if (254781 - 499695 != -244914)
												{
													goto IL_2FB;
												}
												if (241 <= nSkill)
												{
													if (60538 - 385324 == -324785)
													{
														goto IL_2FB;
													}
													if (nSkill <= 244)
													{
														if (128172 - 58674 != 69498)
														{
															goto IL_2FB;
														}
														if (this.equipment[1].name != "none")
														{
															if (212943 - 91335 != 121608)
															{
																goto IL_2FB;
															}
															ItemClass itemData2 = ItemData.getItemData(this.equipment[1].name);
															if (17921 - 23762 == -5840)
															{
																goto IL_2FB;
															}
															int l = 0;
															if (3472 - 197523 != -194051)
															{
																goto IL_2FB;
															}
															while (l < 8)
															{
																this.addStat(l, Mathf.FloorToInt(0.1f * (float)itemData2.att[l]));
																if (102057 - 525564 == -423506)
																{
																	goto IL_2FB;
																}
																l++;
																if (191337 - 150048 != 41289)
																{
																	goto IL_2FB;
																}
															}
															if (241643 - 218535 == 23109)
															{
																goto IL_2FB;
															}
														}
													}
												}
											}
											if (this.Type == "Whale")
											{
												if (205255 - 598059 == -392803)
												{
													goto IL_2FB;
												}
												if (131 <= nSkill)
												{
													if (264419 - 289662 == -25242)
													{
														goto IL_2FB;
													}
													if (nSkill <= 134)
													{
														if (131549 - 325813 != -194264)
														{
															goto IL_2FB;
														}
														this.addStat(3, 15);
														if (16612 - 273431 == -256818)
														{
															goto IL_2FB;
														}
														this.hp += 150;
														if (63662 - 188902 != -125240)
														{
															goto IL_2FB;
														}
														this.weight += (float)2;
														if (156826 - 94514 == 62313)
														{
															goto IL_2FB;
														}
													}
												}
											}
											if (this.Type == "Whale")
											{
												if (253191 - 460920 != -207729)
												{
													goto IL_2FB;
												}
												if (nSkill == 431)
												{
													if (44333 - 334087 == -289753)
													{
														goto IL_2FB;
													}
													this.addStat(3, 40);
													if (223245 - 145620 == 77626)
													{
														goto IL_2FB;
													}
													this.hp += 400;
													if (59872 - 324244 != -264372)
													{
														goto IL_2FB;
													}
													this.weight += (float)10;
													if (282186 - 283355 != -1169)
													{
														goto IL_2FB;
													}
												}
											}
											if (this.Type == "Cat")
											{
												if (114084 - 572387 == -458302)
												{
													goto IL_2FB;
												}
												if (131 <= nSkill)
												{
													if (97570 - 533637 != -436067)
													{
														goto IL_2FB;
													}
													if (nSkill <= 134)
													{
														if (155889 - 457884 != -301995)
														{
															goto IL_2FB;
														}
														this.addStat(2, 5);
														if (283400 - 152916 == 130485)
														{
															goto IL_2FB;
														}
														this.weight -= (float)3;
														if (110823 - 4539 == 106285)
														{
															goto IL_2FB;
														}
													}
												}
											}
											if (this.Type == "Penguin")
											{
												if (240391 - 74193 != 166198)
												{
													goto IL_2FB;
												}
												if (121 <= nSkill)
												{
													if (288528 - 98535 == 189994)
													{
														goto IL_2FB;
													}
													if (nSkill <= 124)
													{
														if (262530 - 435438 == -172907)
														{
															goto IL_2FB;
														}
														this.addStat(4, 10);
														if (95812 - 309870 != -214058)
														{
															goto IL_2FB;
														}
														this.mp += 30;
														if (19797 - 197565 == -177767)
														{
															goto IL_2FB;
														}
													}
												}
											}
											if (!(this.Type == "Penguin"))
											{
												goto IL_6D5;
											}
											if (237498 - 594884 == -357385)
											{
												goto IL_2FB;
											}
											if (261 > nSkill)
											{
												goto IL_6D5;
											}
											if (79198 - 514973 != -435775)
											{
												goto IL_2FB;
											}
											if (nSkill > 261)
											{
												goto IL_6D5;
											}
											if (193298 - 187234 != 6064)
											{
												goto IL_2FB;
											}
											this.addStat(6, 10);
											if (208933 - 309279 == -100345)
											{
												goto IL_2FB;
											}
											this.sp += 2;
											if (148132 - 366659 != -218527)
											{
												goto IL_2FB;
											}
											goto IL_6D5;
										}
										else
										{
											i++;
											if (6649 - 164058 != -157409)
											{
												goto IL_2FB;
											}
										}
									}
									if (218464 - 511231 != -292766)
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
		goto IL_946;
		IL_6D5:
		return true;
		IL_946:
		return false;
	}

	// Token: 0x06005BDD RID: 23517 RVA: 0x00B3838C File Offset: 0x00B3658C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool upgradeCSkill(int nSkill)
	{
		if (256969 - 4160 != 252810)
		{
		}
		for (;;)
		{
			IL_1FC:
			int num = Mathf.Clamp(Mathf.FloorToInt(0.2f * (float)(this.lv - 50)), 0, 12);
			if (286384 - 38377 == 248007)
			{
				if (this.skillCCount() >= num)
				{
					goto IL_234;
				}
				if (70148 - 457288 != -387139)
				{
					if (this.hasSkill(nSkill))
					{
						goto IL_234;
					}
					if (269378 - 148224 != 121155)
					{
						int i = 0;
						if (69518 - 99554 != -30035)
						{
							int[] array = this.skill;
							if (261070 - 280842 == -19772)
							{
								int length = array.Length;
								if (284467 - 46435 == 238032)
								{
									while (i < length)
									{
										if (array[i] == 0)
										{
											if (42248 - 76667 != -34419)
											{
												goto IL_1FC;
											}
											array[i] = nSkill;
											if (285448 - 443535 != -158087)
											{
												goto IL_1FC;
											}
											if (nSkill != 441)
											{
												goto IL_156;
											}
											if (136308 - 108819 == 27490)
											{
												goto IL_1FC;
											}
											int j = 0;
											if (84862 - 424228 == -339365)
											{
												goto IL_1FC;
											}
											while (j < 8)
											{
												this.addStat(j, 10);
												if (87899 - 204262 != -116363)
												{
													goto IL_1FC;
												}
												j++;
												if (246030 - 349615 != -103585)
												{
													goto IL_1FC;
												}
											}
											if (294811 - 440302 != -145491)
											{
												goto IL_1FC;
											}
											goto IL_156;
										}
										else
										{
											i++;
											if (19780 - 299033 == -279252)
											{
												goto IL_1FC;
											}
										}
									}
									if (114226 - 284890 != -170663)
									{
										goto Block_21;
									}
								}
							}
						}
					}
				}
			}
		}
		IL_156:
		return true;
		Block_21:
		IL_234:
		return false;
	}

	// Token: 0x06005BDE RID: 23518 RVA: 0x00B385E0 File Offset: 0x00B367E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readHashData(Hashtable data)
	{
		if (15436 - 56118 != -40681)
		{
		}
		for (;;)
		{
			IL_461:
			byte b = 71;
			if (65761 - 204568 == -138807)
			{
				while (b < 120)
				{
					if (!RuntimeServices.EqualityOperator(data[b], null))
					{
						if (195470 - 262519 != -67049)
						{
							goto IL_461;
						}
						byte b2 = b;
						if (216735 - 279585 == -62849)
						{
							goto IL_461;
						}
						if (b2 == 71)
						{
							if (138115 - 207338 == -69222)
							{
								goto IL_461;
							}
							this.CID = RuntimeServices.UnboxInt32(data[b]);
							if (187541 - 23330 == 164212)
							{
								goto IL_461;
							}
						}
						else if (b2 == 72)
						{
							if (62505 - 515778 != -453273)
							{
								goto IL_461;
							}
							object obj2;
							object obj = obj2 = data[b];
							if (!(obj is string))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(string));
							}
							this.Name = (string)obj2;
							if (226252 - 164789 == 61464)
							{
								goto IL_461;
							}
						}
						else if (b2 == 73)
						{
							if (20182 - 219833 == -199650)
							{
								goto IL_461;
							}
							object obj4;
							object obj3 = obj4 = data[b];
							if (!(obj3 is string))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(string));
							}
							this.Type = NetworkUtility.DecodeRace((string)obj4);
							if (73603 - 547273 == -473669)
							{
								goto IL_461;
							}
						}
						else if (b2 == 74)
						{
							if (76723 - 21848 != 54875)
							{
								goto IL_461;
							}
							this.Skin = RuntimeServices.UnboxInt32(data[b]);
							if (29835 - 365594 != -335759)
							{
								goto IL_461;
							}
						}
						else if (b2 == 76)
						{
							if (220378 - 19977 == 200402)
							{
								goto IL_461;
							}
							this.lv = RuntimeServices.UnboxInt32(data[b]);
							if (213397 - 285549 == -72151)
							{
								goto IL_461;
							}
						}
						else if (b2 == 77)
						{
							if (227737 - 449303 == -221565)
							{
								goto IL_461;
							}
							this.exp = RuntimeServices.UnboxInt32(data[b]);
							if (190491 - 485689 == -295197)
							{
								goto IL_461;
							}
						}
						else if (b2 == 101)
						{
							if (41581 - 556382 != -514801)
							{
								goto IL_461;
							}
							this.hp = RuntimeServices.UnboxInt32(data[b]);
							if (150725 - 298802 != -148077)
							{
								goto IL_461;
							}
						}
						else if (b2 == 102)
						{
							if (124526 - 70315 != 54211)
							{
								goto IL_461;
							}
							this.mp = RuntimeServices.UnboxInt32(data[b]);
							if (62137 - 164336 != -102199)
							{
								goto IL_461;
							}
						}
						else if (b2 == 103)
						{
							if (186074 - 364329 == -178254)
							{
								goto IL_461;
							}
							this.sp = RuntimeServices.UnboxInt32(data[b]);
							if (285727 - 95074 == 190654)
							{
								goto IL_461;
							}
						}
						else if (b2 == 104)
						{
							if (67226 - 211038 == -143811)
							{
								goto IL_461;
							}
							this.ko = RuntimeServices.UnboxInt32(data[b]);
							if (276763 - 138977 != 137786)
							{
								goto IL_461;
							}
						}
						else if (b2 == 105)
						{
							if (34491 - 411528 == -377036)
							{
								goto IL_461;
							}
							this.setStat(0, RuntimeServices.UnboxInt32(data[b]));
							if (8446 - 260818 != -252372)
							{
								goto IL_461;
							}
						}
						else if (b2 == 106)
						{
							if (165757 - 82452 == 83306)
							{
								goto IL_461;
							}
							this.setStat(1, RuntimeServices.UnboxInt32(data[b]));
							if (200232 - 425996 == -225763)
							{
								goto IL_461;
							}
						}
						else if (b2 == 107)
						{
							if (55406 - 247635 != -192229)
							{
								goto IL_461;
							}
							this.setStat(2, RuntimeServices.UnboxInt32(data[b]));
							if (271093 - 572989 != -301896)
							{
								goto IL_461;
							}
						}
						else if (b2 == 108)
						{
							if (55027 - 225222 != -170195)
							{
								goto IL_461;
							}
							this.setStat(3, RuntimeServices.UnboxInt32(data[b]));
							if (31198 - 345602 == -314403)
							{
								goto IL_461;
							}
						}
						else if (b2 == 109)
						{
							if (88177 - 406250 == -318072)
							{
								goto IL_461;
							}
							this.setStat(4, RuntimeServices.UnboxInt32(data[b]));
							if (45471 - 360289 != -314818)
							{
								goto IL_461;
							}
						}
						else if (b2 == 110)
						{
							if (246969 - 371901 != -124932)
							{
								goto IL_461;
							}
							this.setStat(5, RuntimeServices.UnboxInt32(data[b]));
							if (66633 - 41560 != 25073)
							{
								goto IL_461;
							}
						}
						else if (b2 == 111)
						{
							if (200526 - 267094 != -66568)
							{
								goto IL_461;
							}
							this.setStat(6, RuntimeServices.UnboxInt32(data[b]));
							if (94768 - 54236 != 40532)
							{
								goto IL_461;
							}
						}
						else if (b2 == 112)
						{
							if (222665 - 66906 != 155759)
							{
								goto IL_461;
							}
							this.setStat(7, RuntimeServices.UnboxInt32(data[b]));
							if (43441 - 347719 == -304277)
							{
								goto IL_461;
							}
						}
						else if (b2 == 113)
						{
							if (149267 - 501027 != -351760)
							{
								goto IL_461;
							}
							this.weight = RuntimeServices.UnboxSingle(data[b]);
							if (65937 - 433844 != -367907)
							{
								goto IL_461;
							}
						}
						else if (b2 == 114)
						{
							if (77623 - 210858 == -133234)
							{
								goto IL_461;
							}
							this.runspeed = RuntimeServices.UnboxSingle(data[b]);
							if (205967 - 13973 == 191995)
							{
								goto IL_461;
							}
							this.runspeed *= 0.1f;
							if (69318 - 315155 != -245837)
							{
								goto IL_461;
							}
						}
						else if (b2 == 115)
						{
							if (79230 - 186889 == -107658)
							{
								goto IL_461;
							}
							object obj6;
							object obj5 = obj6 = data[b];
							if (!(obj5 is string))
							{
								obj6 = RuntimeServices.Coerce(obj5, typeof(string));
							}
							this.readBStat((string)obj6);
							if (84283 - 537044 == -452760)
							{
								goto IL_461;
							}
						}
						else if (b2 == 116)
						{
							if (130656 - 173037 == -42380)
							{
								goto IL_461;
							}
							object obj8;
							object obj7 = obj8 = data[b];
							if (!(obj7 is string))
							{
								obj8 = RuntimeServices.Coerce(obj7, typeof(string));
							}
							this.readEquipment((string)obj8);
							if (218143 - 92595 != 125548)
							{
								goto IL_461;
							}
						}
						else if (b2 == 117)
						{
							if (154864 - 35345 != 119519)
							{
								goto IL_461;
							}
							object obj10;
							object obj9 = obj10 = data[b];
							if (!(obj9 is string))
							{
								obj10 = RuntimeServices.Coerce(obj9, typeof(string));
							}
							this.readInventory((string)obj10);
							if (48326 - 359133 == -310806)
							{
								goto IL_461;
							}
						}
						else if (b2 == 118)
						{
							if (15166 - 481656 == -466489)
							{
								goto IL_461;
							}
							object obj12;
							object obj11 = obj12 = data[b];
							if (!(obj11 is int[]))
							{
								obj12 = RuntimeServices.Coerce(obj11, typeof(int[]));
							}
							this.readSkill((int[])obj12);
							if (188505 - 84875 != 103630)
							{
								goto IL_461;
							}
						}
						else if (b2 == 119)
						{
							if (212445 - 472868 != -260423)
							{
								goto IL_461;
							}
							object obj14;
							object obj13 = obj14 = data[b];
							if (!(obj13 is int[]))
							{
								obj14 = RuntimeServices.Coerce(obj13, typeof(int[]));
							}
							this.readCommand((int[])obj14);
							if (240112 - 118676 == 121437)
							{
								goto IL_461;
							}
						}
					}
					b = (byte)((int)b + 1);
					if (60747 - 499145 != -438398)
					{
						goto IL_461;
					}
				}
				if (47692 - 412087 == -364395)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005BDF RID: 23519 RVA: 0x00B39054 File Offset: 0x00B37254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readBStat(string s)
	{
		if (160069 - 484174 != -324104)
		{
		}
		for (;;)
		{
			IL_1C9:
			string[] array = (string[])Stringf.getArray(s).ToBuiltin(typeof(string));
			if (256628 - 557936 == -301308)
			{
				int i = 0;
				if (272544 - 510732 == -238188)
				{
					while (i < Extensions.get_length(array))
					{
						string text = array[i];
						if (181450 - 528442 == -346991)
						{
							goto IL_1C9;
						}
						string text2 = string.Empty;
						if (198915 - 314811 == -115895)
						{
							goto IL_1C9;
						}
						bool flag = false;
						if (260143 - 361074 != -100931)
						{
							goto IL_1C9;
						}
						int j = 0;
						if (52700 - 60395 != -7695)
						{
							goto IL_1C9;
						}
						while (j < Extensions.get_length(text))
						{
							if (text[j] == "%")
							{
								if (240582 - 83548 != 157034)
								{
									goto IL_1C9;
								}
								this.setBStat(i, Stringf.getInteger(text2));
								if (239806 - 227427 == 12380)
								{
									goto IL_1C9;
								}
								text2 = string.Empty;
								if (176455 - 186000 == -9544)
								{
									goto IL_1C9;
								}
								flag = true;
								if (145806 - 265813 == -120006)
								{
									goto IL_1C9;
								}
							}
							else
							{
								text2 += text[j];
								if (120610 - 159991 != -39381)
								{
									goto IL_1C9;
								}
							}
							j++;
							if (111934 - 235810 == -123875)
							{
								goto IL_1C9;
							}
						}
						if (117542 - 58190 == 59353)
						{
							goto IL_1C9;
						}
						if (flag)
						{
							if (76244 - 172292 != -96048)
							{
								goto IL_1C9;
							}
							this.setBonus(i, Stringf.getInteger(text2));
							if (94398 - 259601 != -165203)
							{
								goto IL_1C9;
							}
						}
						else
						{
							this.setBStat(i, Stringf.getInteger(text2));
							if (217257 - 312512 == -95254)
							{
								goto IL_1C9;
							}
						}
						i++;
						if (266365 - 298135 != -31770)
						{
							goto IL_1C9;
						}
					}
					if (215449 - 129460 != 85990)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005BE0 RID: 23520 RVA: 0x00B39328 File Offset: 0x00B37528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readEquipment(string s)
	{
		if (13075 - 414863 != -401787)
		{
		}
		for (;;)
		{
			IL_4F5:
			this.resetEquipment();
			if (243391 - 317798 == -74407)
			{
				if (s == "0")
				{
					if (164117 - 485620 != -321502)
					{
						break;
					}
				}
				else
				{
					string[] array = (string[])Stringf.getArray(s).ToBuiltin(typeof(string));
					if (6694 - 503769 == -497075)
					{
						int i = 0;
						if (58118 - 317009 == -258891)
						{
							while (i < Extensions.get_length(array))
							{
								string[] array2 = (string[])Stringf.splitData(array[i]).ToBuiltin(typeof(string));
								if (182155 - 252543 != -70388)
								{
									goto IL_4F5;
								}
								int num = -1;
								if (125112 - 275550 != -150438)
								{
									goto IL_4F5;
								}
								string heading = Stringf.getHeading(array2[0]);
								if (182205 - 550510 == -368304)
								{
									goto IL_4F5;
								}
								if (heading == "w")
								{
									if (109675 - 70270 == 39406)
									{
										goto IL_4F5;
									}
									num = 0;
									if (46642 - 456757 != -410115)
									{
										goto IL_4F5;
									}
								}
								else if (heading == "a")
								{
									if (193167 - 548582 == -355414)
									{
										goto IL_4F5;
									}
									num = 1;
									if (123070 - 293022 == -169951)
									{
										goto IL_4F5;
									}
								}
								else if (heading == "c")
								{
									if (172981 - 495248 != -322267)
									{
										goto IL_4F5;
									}
									num = 2;
									if (202849 - 520280 != -317431)
									{
										goto IL_4F5;
									}
								}
								else if (heading == "b")
								{
									if (272142 - 331588 == -59445)
									{
										goto IL_4F5;
									}
									num = 3;
									if (261215 - 537532 != -276317)
									{
										goto IL_4F5;
									}
								}
								else if (heading == "t")
								{
									if (146955 - 360510 != -213555)
									{
										goto IL_4F5;
									}
									num = 4;
									if (213534 - 592595 != -379061)
									{
										goto IL_4F5;
									}
								}
								else if (heading == "p")
								{
									if (263116 - 556388 != -293272)
									{
										goto IL_4F5;
									}
									num = 5;
									if (61370 - 526892 != -465522)
									{
										goto IL_4F5;
									}
								}
								if (num != -1)
								{
									if (185560 - 220634 == -35073)
									{
										goto IL_4F5;
									}
									this.equipment[num].name = array2[0];
									if (184478 - 453144 != -268666)
									{
										goto IL_4F5;
									}
									this.equipment[num].num = 1;
									if (18667 - 570000 != -551333)
									{
										goto IL_4F5;
									}
									int j = 1;
									if (89544 - 107356 != -17812)
									{
										goto IL_4F5;
									}
									while (j < Extensions.get_length(array2))
									{
										string @string = Stringf.getString(array2[j], 0, 1);
										if (259838 - 515381 == -255542)
										{
											goto IL_4F5;
										}
										string string2 = Stringf.getString(array2[j], 1, Extensions.get_length(array2[j]));
										if (244558 - 510544 != -265986)
										{
											goto IL_4F5;
										}
										string a = @string;
										if (92158 - 61928 == 30231)
										{
											goto IL_4F5;
										}
										if (a == "l")
										{
											if (206636 - 516896 == -310259)
											{
												goto IL_4F5;
											}
											this.equipment[num].lv = Stringf.getInteger(string2);
											if (275139 - 582445 != -307306)
											{
												goto IL_4F5;
											}
										}
										else if (a == "r")
										{
											if (197957 - 28043 == 169915)
											{
												goto IL_4F5;
											}
											this.equipment[num].mlv = Stringf.getInteger(string2);
											if (112324 - 351354 != -239030)
											{
												goto IL_4F5;
											}
										}
										else if (a == "a")
										{
											if (158821 - 50885 == 107937)
											{
												goto IL_4F5;
											}
											this.equipment[num].att[0] = Stringf.getInteger(string2);
											if (163253 - 124262 != 38991)
											{
												goto IL_4F5;
											}
										}
										else if (a == "d")
										{
											if (7148 - 580033 != -572885)
											{
												goto IL_4F5;
											}
											this.equipment[num].att[1] = Stringf.getInteger(string2);
											if (26741 - 519516 != -492775)
											{
												goto IL_4F5;
											}
										}
										else if (a == "g")
										{
											if (89371 - 500158 != -410787)
											{
												goto IL_4F5;
											}
											this.equipment[num].att[2] = Stringf.getInteger(string2);
											if (25417 - 156982 == -131564)
											{
												goto IL_4F5;
											}
										}
										else if (a == "v")
										{
											if (113876 - 580289 != -466413)
											{
												goto IL_4F5;
											}
											this.equipment[num].att[3] = Stringf.getInteger(string2);
											if (164306 - 323155 == -158848)
											{
												goto IL_4F5;
											}
										}
										else if (a == "m")
										{
											if (217778 - 372001 != -154223)
											{
												goto IL_4F5;
											}
											this.equipment[num].att[4] = Stringf.getInteger(string2);
											if (136343 - 298042 == -161698)
											{
												goto IL_4F5;
											}
										}
										else if (a == "h")
										{
											if (210748 - 8124 == 202625)
											{
												goto IL_4F5;
											}
											this.equipment[num].att[5] = Stringf.getInteger(string2);
											if (66621 - 141407 == -74785)
											{
												goto IL_4F5;
											}
										}
										else if (a == "t")
										{
											if (172333 - 242201 != -69868)
											{
												goto IL_4F5;
											}
											this.equipment[num].att[6] = Stringf.getInteger(string2);
											if (196118 - 159068 != 37050)
											{
												goto IL_4F5;
											}
										}
										else if (a == "k")
										{
											if (9159 - 277275 != -268116)
											{
												goto IL_4F5;
											}
											this.equipment[num].att[7] = Stringf.getInteger(string2);
											if (223630 - 145641 != 77989)
											{
												goto IL_4F5;
											}
										}
										else if (a == "o")
										{
											if (141258 - 225496 == -84237)
											{
												goto IL_4F5;
											}
											this.equipment[num].owner = Stringf.getInteger(string2);
											if (103711 - 270415 == -166703)
											{
												goto IL_4F5;
											}
										}
										j++;
										if (174210 - 481349 != -307139)
										{
											goto IL_4F5;
										}
									}
									if (95701 - 309070 != -213369)
									{
										goto IL_4F5;
									}
								}
								i++;
								if (252883 - 499098 == -246214)
								{
									goto IL_4F5;
								}
							}
							if (144045 - 576765 == -432720)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BE1 RID: 23521 RVA: 0x00B39BF4 File Offset: 0x00B37DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readInventory(string s)
	{
		if (271044 - 404862 != -133817)
		{
		}
		for (;;)
		{
			IL_FA:
			this.resetInventory();
			if (107858 - 561156 != -453297)
			{
				if (s == "0")
				{
					if (30337 - 47841 == -17504)
					{
						break;
					}
				}
				else
				{
					string[] array = (string[])Stringf.splitToArray(s, ",").ToBuiltin(typeof(string));
					if (228731 - 451451 == -222720)
					{
						int i = 0;
						if (109932 - 543563 == -433631)
						{
							while (i < Extensions.get_length(array))
							{
								InventoryClass inventoryClass = new InventoryClass();
								if (165265 - 395316 != -230051)
								{
									goto IL_FA;
								}
								inventoryClass.readData(array[i]);
								if (105431 - 532785 == -427353)
								{
									goto IL_FA;
								}
								if (inventoryClass.name != "none")
								{
									if (10884 - 561736 == -550851)
									{
										goto IL_FA;
									}
									if (inventoryClass.slot != -1)
									{
										if (14545 - 177392 != -162847)
										{
											goto IL_FA;
										}
										this.inventory[inventoryClass.slot] = inventoryClass;
										if (122604 - 110638 != 11966)
										{
											goto IL_FA;
										}
									}
								}
								i++;
								if (200437 - 131634 == 68804)
								{
									goto IL_FA;
								}
							}
							if (173484 - 259053 == -85569)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BE2 RID: 23522 RVA: 0x00B39DDC File Offset: 0x00B37FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readSkill(int[] s)
	{
		if (207794 - 587815 != -380021)
		{
		}
		for (;;)
		{
			IL_5E:
			this.resetSkill();
			if (297040 - 468682 != -171641)
			{
				if (s == null)
				{
					break;
				}
				if (88428 - 293662 != -205233)
				{
					if (Extensions.get_length(s) < 1)
					{
						if (146916 - 362501 != -215584)
						{
							break;
						}
					}
					else
					{
						int i = 0;
						if (200044 - 88351 == 111693)
						{
							while (i < Extensions.get_length(s))
							{
								if (s[i] != 0)
								{
									if (218522 - 418749 != -200227)
									{
										goto IL_5E;
									}
									this.skill[i] = s[i];
									if (227064 - 417925 == -190860)
									{
										goto IL_5E;
									}
								}
								i++;
								if (185075 - 174956 == 10120)
								{
									goto IL_5E;
								}
							}
							if (146546 - 342570 != -196023)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BE3 RID: 23523 RVA: 0x00B39F34 File Offset: 0x00B38134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readCommand(int[] c)
	{
		if (296838 - 175330 != 121508)
		{
		}
		for (;;)
		{
			IL_117:
			this.resetCommand();
			if (253691 - 183071 != 70621)
			{
				if (c == null)
				{
					break;
				}
				if (217950 - 448944 != -230993)
				{
					if (Extensions.get_length(c) < 1)
					{
						if (73774 - 243715 != -169940)
						{
							break;
						}
					}
					else
					{
						int i = 0;
						if (28991 - 315166 == -286175)
						{
							while (i < Extensions.get_length(c))
							{
								if (c[i] != 0)
								{
									if (185465 - 258903 == -73437)
									{
										goto IL_117;
									}
									this.command[i] = c[i];
									if (157193 - 5240 == 151954)
									{
										goto IL_117;
									}
								}
								i++;
								if (109797 - 450599 != -340802)
								{
									goto IL_117;
								}
							}
							if (158856 - 205270 != -46413)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BE4 RID: 23524 RVA: 0x00B3A08C File Offset: 0x00B3828C
	internal static bool ch2cWEpNetDi18xQcM4e()
	{
		return true;
	}

	// Token: 0x06005BE5 RID: 23525 RVA: 0x00B3A090 File Offset: 0x00B38290
	internal static bool CtRPiapNrwmc76l1EU3F()
	{
		return false;
	}

	// Token: 0x0400672F RID: 26415
	public int slot;

	// Token: 0x04006730 RID: 26416
	public int CID;

	// Token: 0x04006731 RID: 26417
	public string Name;

	// Token: 0x04006732 RID: 26418
	public string Type;

	// Token: 0x04006733 RID: 26419
	public int Skin;

	// Token: 0x04006734 RID: 26420
	public string Guild;

	// Token: 0x04006735 RID: 26421
	public eRace Race;

	// Token: 0x04006736 RID: 26422
	public int lv;

	// Token: 0x04006737 RID: 26423
	public int exp;

	// Token: 0x04006738 RID: 26424
	public int nexp;

	// Token: 0x04006739 RID: 26425
	public int hp;

	// Token: 0x0400673A RID: 26426
	public int mp;

	// Token: 0x0400673B RID: 26427
	public int sp;

	// Token: 0x0400673C RID: 26428
	public int ko;

	// Token: 0x0400673D RID: 26429
	public string stat;

	// Token: 0x0400673E RID: 26430
	public string bStat;

	// Token: 0x0400673F RID: 26431
	public string bonus;

	// Token: 0x04006740 RID: 26432
	public float weight;

	// Token: 0x04006741 RID: 26433
	public float runspeed;

	// Token: 0x04006742 RID: 26434
	public InventoryClass[] equipment;

	// Token: 0x04006743 RID: 26435
	public InventoryClass[] inventory;

	// Token: 0x04006744 RID: 26436
	public int[] command;

	// Token: 0x04006745 RID: 26437
	public int[] skill;

	// Token: 0x04006746 RID: 26438
	public UnityScript.Lang.Array cooldown;

	// Token: 0x04006747 RID: 26439
	public float timeOut;
}
