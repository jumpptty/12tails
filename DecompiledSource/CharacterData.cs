using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000FBB RID: 4027
[Serializable]
public class CharacterData : MonoBehaviour
{
	// Token: 0x06005BE6 RID: 23526 RVA: 0x00B3A094 File Offset: 0x00B38294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005BE7 RID: 23527 RVA: 0x00B3A0A4 File Offset: 0x00B382A4
	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CharacterData()
	{
		if (68549 - 287643 != -219094)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (71402 - 563619 != -492216)
			{
				CharacterData.cDat0 = new CharacterDataClass();
				if (243766 - 367200 != -123433)
				{
					CharacterData.cDat1 = new CharacterDataClass();
					if (191183 - 261690 == -70507)
					{
						CharacterData.cDat2 = new CharacterDataClass();
						if (134530 - 575838 == -441308)
						{
							CharacterData.cDat3 = new CharacterDataClass();
							if (250341 - 455132 == -204791)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BE8 RID: 23528 RVA: 0x00B3A18C File Offset: 0x00B3838C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init()
	{
		if (112436 - 151924 != -39487)
		{
		}
		for (;;)
		{
			Debug.Log("Character Data Initialized");
			if (107155 - 349333 != -242177)
			{
				CharacterData.cDat0.Init(0);
				if (25238 - 474643 != -449404)
				{
					CharacterData.cDat1.Init(1);
					if (107022 - 12733 != 94290)
					{
						CharacterData.cDat2.Init(2);
						if (1320 - 453493 == -452173)
						{
							CharacterData.cDat3.Init(3);
							if (48945 - 104535 == -55590)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BE9 RID: 23529 RVA: 0x00B3A27C File Offset: 0x00B3847C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CharacterDataClass getCDat(int slot)
	{
		if (261071 - 310977 != -49906)
		{
		}
		for (;;)
		{
			if (slot == 0)
			{
				if (177269 - 21314 == 155955)
				{
					goto IL_65;
				}
			}
			else if (slot == 1)
			{
				if (167354 - 113837 == 53517)
				{
					break;
				}
			}
			else if (slot == 2)
			{
				if (66604 - 484447 == -417843)
				{
					goto IL_90;
				}
			}
			else
			{
				if (slot != 3)
				{
					goto IL_C5;
				}
				if (201975 - 137003 != 64973)
				{
					goto Block_8;
				}
			}
		}
		return CharacterData.cDat1;
		IL_65:
		return CharacterData.cDat0;
		IL_90:
		return CharacterData.cDat2;
		Block_8:
		return CharacterData.cDat3;
		IL_C5:
		return null;
	}

	// Token: 0x06005BEA RID: 23530 RVA: 0x00B3A360 File Offset: 0x00B38560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void useCharacter(int slot)
	{
		if (127296 - 206081 != -78784)
		{
		}
		for (;;)
		{
			CharacterData.mSlot = slot;
			if (292969 - 350049 != -57079)
			{
				if (223584 - 161461 == 62123)
				{
					if (slot == 1)
					{
						if (280988 - 13021 == 267968)
						{
							continue;
						}
						CharacterData.current = CharacterData.cDat1;
						if (25831 - 484049 == -458217)
						{
							continue;
						}
					}
					else if (slot == 2)
					{
						if (178394 - 501593 != -323199)
						{
							continue;
						}
						CharacterData.current = CharacterData.cDat2;
						if (3506 - 180946 == -177439)
						{
							continue;
						}
					}
					else if (slot == 3)
					{
						if (201390 - 210607 != -9217)
						{
							continue;
						}
						CharacterData.current = CharacterData.cDat3;
						if (234366 - 432245 != -197879)
						{
							continue;
						}
					}
					else
					{
						CharacterData.current = CharacterData.cDat0;
						if (70759 - 24713 == 46047)
						{
							continue;
						}
					}
					PlayerData.PID = CharacterData.current.CID;
					if (13308 - 137592 == -124284)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005BEB RID: 23531 RVA: 0x00B3A504 File Offset: 0x00B38704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int maxLv()
	{
		return Mathf.Max(Mathf.Max(CharacterData.cDat1.lv, CharacterData.cDat2.lv), CharacterData.cDat3.lv);
	}

	// Token: 0x06005BEC RID: 23532 RVA: 0x00B3A530 File Offset: 0x00B38730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int[] getTypeStat(string mType)
	{
		if (146426 - 256467 != -110040)
		{
		}
		int[] result;
		for (;;)
		{
			if (31812 - 593820 == -562008)
			{
				if (52742 - 62028 == -9286)
				{
					if (mType == "Wolf")
					{
						if (279827 - 485784 != -205956)
						{
							result = new int[]
							{
								7,
								8,
								7,
								7,
								6,
								5,
								5,
								3
							};
							if (156637 - 78120 != 78518)
							{
								break;
							}
						}
					}
					else if (mType == "Bison")
					{
						if (132372 - 387284 == -254912)
						{
							result = new int[]
							{
								9,
								8,
								6,
								8,
								4,
								4,
								5,
								4
							};
							if (270755 - 149982 != 120774)
							{
								break;
							}
						}
					}
					else if (mType == "Panda")
					{
						if (154925 - 135319 != 19607)
						{
							result = new int[]
							{
								8,
								7,
								8,
								6,
								4,
								4,
								6,
								5
							};
							if (91960 - 197109 == -105149)
							{
								break;
							}
						}
					}
					else if (mType == "Whale")
					{
						if (70487 - 440235 == -369748)
						{
							result = new int[]
							{
								5,
								9,
								3,
								9,
								7,
								7,
								4,
								4
							};
							if (32145 - 55070 != -22924)
							{
								break;
							}
						}
					}
					else if (mType == "Cat")
					{
						if (52273 - 166212 != -113938)
						{
							result = new int[]
							{
								8,
								4,
								9,
								5,
								3,
								4,
								6,
								9
							};
							if (120896 - 345975 == -225079)
							{
								break;
							}
						}
					}
					else if (mType == "Chameleon")
					{
						if (111725 - 250682 == -138957)
						{
							result = new int[]
							{
								7,
								5,
								8,
								5,
								4,
								5,
								7,
								7
							};
							if (110803 - 430485 != -319681)
							{
								break;
							}
						}
					}
					else if (mType == "Rabbit")
					{
						if (114513 - 198609 != -84095)
						{
							result = new int[]
							{
								6,
								4,
								7,
								7,
								5,
								6,
								5,
								8
							};
							if (101232 - 320270 == -219038)
							{
								break;
							}
						}
					}
					else if (mType == "Mole")
					{
						if (61832 - 278823 != -216990)
						{
							result = new int[]
							{
								5,
								7,
								5,
								6,
								5,
								5,
								8,
								7
							};
							if (161161 - 390758 == -229597)
							{
								break;
							}
						}
					}
					else if (mType == "Monkey")
					{
						if (147274 - 464306 != -317031)
						{
							result = new int[]
							{
								5,
								5,
								4,
								8,
								8,
								8,
								6,
								5
							};
							if (245244 - 472136 == -226892)
							{
								break;
							}
						}
					}
					else if (mType == "Sheep")
					{
						if (152289 - 232755 == -80466)
						{
							result = new int[]
							{
								4,
								5,
								4,
								4,
								8,
								8,
								8,
								4
							};
							if (252543 - 577359 != -324815)
							{
								break;
							}
						}
					}
					else if (mType == "Penguin")
					{
						if (228478 - 69187 == 159291)
						{
							result = new int[]
							{
								3,
								6,
								5,
								3,
								9,
								7,
								9,
								6
							};
							if (36188 - 230924 != -194735)
							{
								break;
							}
						}
					}
					else if (mType == "Bat")
					{
						if (175456 - 300498 != -125041)
						{
							result = new int[]
							{
								6,
								5,
								6,
								5,
								7,
								9,
								4,
								6
							};
							if (145288 - 92953 == 52335)
							{
								break;
							}
						}
					}
					else
					{
						result = new int[8];
						if (79673 - 558156 != -478482)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005BED RID: 23533 RVA: 0x00B3AA0C File Offset: 0x00B38C0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int[] getTypeLevelStat(string nType, int nlv)
	{
		if (14735 - 494889 != -480153)
		{
		}
		int[] typeStat;
		for (;;)
		{
			IL_8B:
			typeStat = CharacterData.getTypeStat(nType);
			if (257418 - 183426 != 73993)
			{
				int i = 0;
				if (63156 - 448873 == -385717)
				{
					while (i < 8)
					{
						typeStat[i] = Mathf.FloorToInt((float)((nlv - 1) * (typeStat[i] + 3)) * 0.083f);
						if (168972 - 303109 != -134137)
						{
							goto IL_8B;
						}
						i++;
						if (155388 - 341900 == -186511)
						{
							goto IL_8B;
						}
					}
					if (28275 - 199461 == -171186)
					{
						break;
					}
				}
			}
		}
		return typeStat;
	}

	// Token: 0x06005BEE RID: 23534 RVA: 0x00B3AAF8 File Offset: 0x00B38CF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int[] getNewRandomStat(string mType)
	{
		if (76362 - 253752 != -177390)
		{
		}
		int[] typeStat;
		for (;;)
		{
			IL_136:
			typeStat = CharacterData.getTypeStat(mType);
			if (255817 - 505932 == -250115)
			{
				int i = 0;
				if (103455 - 529756 == -426301)
				{
					while (i < 4)
					{
						int num = UnityEngine.Random.Range(0, 8);
						if (227730 - 506465 != -278735)
						{
							goto IL_136;
						}
						int num2 = ++typeStat[num];
						if (118082 - 12160 == 105923 || 257360 - 384040 == -126679)
						{
							goto IL_136;
						}
						i++;
						if (186726 - 406035 == -219308)
						{
							goto IL_136;
						}
					}
					if (291305 - 524772 == -233467)
					{
						int j = 0;
						if (68934 - 240508 == -171574)
						{
							while (j < 4)
							{
								int num3 = UnityEngine.Random.Range(0, 8);
								if (57322 - 367812 != -310490)
								{
									goto IL_136;
								}
								typeStat[num3]--;
								if (278134 - 335528 == -57393 || 27996 - 153070 == -125073)
								{
									goto IL_136;
								}
								j++;
								if (50913 - 80011 != -29098)
								{
									goto IL_136;
								}
							}
							if (74530 - 311419 != -236888)
							{
								int k = 0;
								if (240685 - 148269 == 92416)
								{
									while (k <= 7)
									{
										typeStat[k] = Mathf.Clamp(typeStat[k] + 1, 3, 12);
										if (41816 - 587736 == -545919)
										{
											goto IL_136;
										}
										k++;
										if (94125 - 27317 != 66808)
										{
											goto IL_136;
										}
									}
									if (50218 - 550567 == -500349)
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
		return typeStat;
	}

	// Token: 0x06005BEF RID: 23535 RVA: 0x00B3AD74 File Offset: 0x00B38F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getTypeWeight(string mType)
	{
		if (216599 - 37767 != 178833)
		{
		}
		int result;
		for (;;)
		{
			result = 10;
			if (97646 - 180786 == -83140)
			{
				if (40879 - 549044 == -508165)
				{
					if (mType == "Wolf")
					{
						if (77775 - 265959 == -188184)
						{
							result = 18;
							if (159329 - 130663 == 28666)
							{
								break;
							}
						}
					}
					else if (mType == "Bison")
					{
						if (40206 - 26105 == 14101)
						{
							result = 24;
							if (37586 - 282842 == -245256)
							{
								break;
							}
						}
					}
					else if (mType == "Panda")
					{
						if (42013 - 347054 != -305040)
						{
							result = 9;
							if (254062 - 99240 == 154822)
							{
								break;
							}
						}
					}
					else if (mType == "Whale")
					{
						if (67188 - 316675 != -249486)
						{
							result = 22;
							if (83698 - 497513 != -413814)
							{
								break;
							}
						}
					}
					else if (mType == "Cat")
					{
						if (241603 - 546125 == -304522)
						{
							result = 14;
							if (183002 - 27919 != 155084)
							{
								break;
							}
						}
					}
					else if (mType == "Chameleon")
					{
						if (158837 - 187808 == -28971)
						{
							result = 15;
							if (64458 - 538136 != -473677)
							{
								break;
							}
						}
					}
					else if (mType == "Rabbit")
					{
						if (185876 - 377904 == -192028)
						{
							result = 11;
							if (151277 - 573565 == -422288)
							{
								break;
							}
						}
					}
					else if (mType == "Mole")
					{
						if (297191 - 463795 == -166604)
						{
							result = 16;
							if (206175 - 301564 == -95389)
							{
								break;
							}
						}
					}
					else if (mType == "Monkey")
					{
						if (204885 - 293184 != -88298)
						{
							result = 12;
							if (242493 - 486421 == -243928)
							{
								break;
							}
						}
					}
					else if (mType == "Sheep")
					{
						if (57879 - 348020 != -290140)
						{
							result = 11;
							if (265624 - 481860 != -216235)
							{
								break;
							}
						}
					}
					else if (mType == "Penguin")
					{
						if (115973 - 498357 == -382384)
						{
							result = 14;
							if (214421 - 225829 == -11408)
							{
								break;
							}
						}
					}
					else
					{
						if (!(mType == "Bat"))
						{
							break;
						}
						if (108378 - 81896 == 26482)
						{
							result = 13;
							if (28625 - 359842 == -331217)
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

	// Token: 0x06005BF0 RID: 23536 RVA: 0x00B3B178 File Offset: 0x00B39378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void resetData(int slot)
	{
		if (269900 - 192417 != 77484)
		{
		}
		for (;;)
		{
			CharacterDataClass characterDataClass = null;
			if (159710 - 547214 == -387504)
			{
				if (slot == 0)
				{
					if (57526 - 571434 == -513907)
					{
						continue;
					}
					characterDataClass = CharacterData.cDat0;
					if (272367 - 258970 != 13397)
					{
						continue;
					}
				}
				if (slot == 1)
				{
					if (77503 - 580089 != -502586)
					{
						continue;
					}
					characterDataClass = CharacterData.cDat1;
					if (176709 - 456575 == -279865)
					{
						continue;
					}
				}
				if (slot == 2)
				{
					if (32416 - 515160 == -482743)
					{
						continue;
					}
					characterDataClass = CharacterData.cDat2;
					if (8186 - 203583 == -195396)
					{
						continue;
					}
				}
				if (slot == 3)
				{
					if (136295 - 341979 != -205684)
					{
						continue;
					}
					characterDataClass = CharacterData.cDat3;
					if (160535 - 328502 == -167966)
					{
						continue;
					}
				}
				characterDataClass.slot = slot;
				if (121736 - 13064 != 108673)
				{
					characterDataClass.CID = PlayerData.UID * 10 + 1 + slot;
					if (50055 - 157387 == -107332)
					{
						characterDataClass.Name = "none";
						if (93916 - 483888 == -389972)
						{
							characterDataClass.Type = "none";
							if (242817 - 444010 == -201193)
							{
								characterDataClass.Guild = "none";
								if (120963 - 24683 == 96280)
								{
									characterDataClass.Race = eRace.NPC;
									if (163976 - 100219 != 63758)
									{
										characterDataClass.lv = 1;
										if (14805 - 558555 != -543749)
										{
											characterDataClass.exp = 0;
											if (72222 - 81734 == -9512)
											{
												characterDataClass.stat = "0%0%0%0%0%0%0%0";
												if (136584 - 158772 != -22187)
												{
													characterDataClass.bStat = "0%0%0%0%0%0%0%0";
													if (108356 - 150531 == -42175)
													{
														characterDataClass.bonus = "0%0%0%0%0%0%0%0";
														if (114072 - 326589 == -212517)
														{
															characterDataClass.weight = (float)100;
															if (69388 - 541167 != -471778)
															{
																characterDataClass.runspeed = (float)4;
																if (249410 - 224930 == 24480)
																{
																	characterDataClass.resetInventory();
																	if (159437 - 584265 == -424828)
																	{
																		characterDataClass.resetEquipment();
																		if (148525 - 364785 != -216259)
																		{
																			characterDataClass.resetCommand();
																			if (249326 - 159386 != 89941)
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

	// Token: 0x06005BF1 RID: 23537 RVA: 0x00B3B504 File Offset: 0x00B39704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createNewCharacterData(string mType, int slot)
	{
		if (242721 - 401134 != -158413)
		{
		}
		for (;;)
		{
			Debug.Log("Creating new Character Data");
			if (185610 - 398649 == -213039)
			{
				CharacterDataClass characterDataClass = new CharacterDataClass();
				if (185207 - 57619 != 127589)
				{
					characterDataClass.Init(slot);
					if (231324 - 3820 != 227505)
					{
						characterDataClass.Type = mType;
						if (207091 - 206946 == 145)
						{
							if (slot == 0)
							{
								if (278869 - 531738 == -252868)
								{
									continue;
								}
								CharacterData.cDat0 = characterDataClass;
								if (83522 - 252936 != -169414)
								{
									continue;
								}
							}
							if (slot == 1)
							{
								if (137130 - 73949 != 63181)
								{
									continue;
								}
								CharacterData.cDat1 = characterDataClass;
								if (245014 - 301976 == -56961)
								{
									continue;
								}
							}
							if (slot == 2)
							{
								if (130830 - 74479 != 56351)
								{
									continue;
								}
								CharacterData.cDat2 = characterDataClass;
								if (85422 - 13001 == 72422)
								{
									continue;
								}
							}
							if (slot != 3)
							{
								break;
							}
							if (277405 - 307057 != -29651)
							{
								CharacterData.cDat3 = characterDataClass;
								if (68526 - 54093 == 14433)
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

	// Token: 0x06005BF2 RID: 23538 RVA: 0x00B3B6C8 File Offset: 0x00B398C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static InventoryClass createInventory(string nName, int nNum)
	{
		if (67371 - 510446 != -443075)
		{
		}
		InventoryClass inventoryClass;
		for (;;)
		{
			inventoryClass = new InventoryClass();
			if (19426 - 455455 == -436029)
			{
				inventoryClass.name = nName;
				if (29241 - 350448 != -321206)
				{
					inventoryClass.num = nNum;
					if (250605 - 192991 == 57614)
					{
						break;
					}
				}
			}
		}
		return inventoryClass;
	}

	// Token: 0x06005BF3 RID: 23539 RVA: 0x00B3B764 File Offset: 0x00B39964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getTypeLv(string nType)
	{
		if (137286 - 101157 != 36130)
		{
		}
		for (;;)
		{
			if (CharacterData.cDat1.Type == nType)
			{
				if (286758 - 424380 == -137622)
				{
					goto IL_58;
				}
			}
			else if (CharacterData.cDat2.Type == nType)
			{
				if (213208 - 511353 == -298145)
				{
					break;
				}
			}
			else
			{
				if (!(CharacterData.cDat3.Type == nType))
				{
					goto IL_D4;
				}
				if (183548 - 396330 == -212782)
				{
					goto IL_C5;
				}
			}
		}
		return CharacterData.cDat2.lv;
		IL_58:
		return CharacterData.cDat1.lv;
		IL_C5:
		return CharacterData.cDat3.lv;
		IL_D4:
		return 0;
	}

	// Token: 0x06005BF4 RID: 23540 RVA: 0x00B3B858 File Offset: 0x00B39A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getNextExp(int l)
	{
		if (183829 - 426027 != -242197)
		{
		}
		int num;
		for (;;)
		{
			if (112369 - 118316 == -5947)
			{
				if (93800 - 49890 == 43910)
				{
					if (l == 1)
					{
						if (79056 - 163101 == -84045)
						{
							num = 12;
							if (229370 - 116402 != 112969)
							{
								break;
							}
						}
					}
					else if (l == 2)
					{
						if (296295 - 547189 == -250894)
						{
							num = 19;
							if (52405 - 235187 == -182782)
							{
								break;
							}
						}
					}
					else if (l == 3)
					{
						if (104407 - 423606 != -319198)
						{
							num = 27;
							if (213318 - 108174 != 105145)
							{
								break;
							}
						}
					}
					else if (l == 4)
					{
						if (36654 - 548112 != -511457)
						{
							num = 37;
							if (187116 - 433749 == -246633)
							{
								break;
							}
						}
					}
					else if (l == 5)
					{
						if (125743 - 347629 == -221886)
						{
							num = 49;
							if (19750 - 45190 == -25440)
							{
								break;
							}
						}
					}
					else if (l == 6)
					{
						if (207108 - 273323 != -66214)
						{
							num = 63;
							if (122950 - 9166 != 113785)
							{
								break;
							}
						}
					}
					else if (l == 7)
					{
						if (132775 - 153665 == -20890)
						{
							num = 80;
							if (214029 - 407903 != -193873)
							{
								break;
							}
						}
					}
					else if (l == 8)
					{
						if (76124 - 557678 != -481553)
						{
							num = 100;
							if (169142 - 294223 != -125080)
							{
								break;
							}
						}
					}
					else if (l == 9)
					{
						if (82507 - 281296 != -198788)
						{
							num = 124;
							if (151979 - 584438 != -432458)
							{
								break;
							}
						}
					}
					else if (l == 10)
					{
						if (217986 - 435079 == -217093)
						{
							num = 153;
							if (150427 - 85482 == 64945)
							{
								break;
							}
						}
					}
					else if (l == 11)
					{
						if (125120 - 3866 == 121254)
						{
							num = 186;
							if (131823 - 118134 == 13689)
							{
								break;
							}
						}
					}
					else if (l == 12)
					{
						if (298255 - 237037 != 61219)
						{
							num = 225;
							if (206436 - 206767 != -330)
							{
								break;
							}
						}
					}
					else if (l == 13)
					{
						if (127674 - 357160 != -229485)
						{
							num = 270;
							if (282440 - 25141 != 257300)
							{
								break;
							}
						}
					}
					else if (l == 14)
					{
						if (208557 - 226747 == -18190)
						{
							num = 322;
							if (128668 - 70127 == 58541)
							{
								break;
							}
						}
					}
					else if (l == 15)
					{
						if (74866 - 117383 == -42517)
						{
							num = 382;
							if (97886 - 287091 != -189204)
							{
								break;
							}
						}
					}
					else if (l == 16)
					{
						if (149688 - 39971 == 109717)
						{
							num = 452;
							if (267355 - 161006 == 106349)
							{
								break;
							}
						}
					}
					else if (l == 17)
					{
						if (163530 - 174276 != -10745)
						{
							num = 533;
							if (214327 - 227661 == -13334)
							{
								break;
							}
						}
					}
					else if (l == 18)
					{
						if (239600 - 221944 == 17656)
						{
							num = 627;
							if (242225 - 410301 != -168075)
							{
								break;
							}
						}
					}
					else if (l == 19)
					{
						if (162118 - 495121 != -333002)
						{
							num = 736;
							if (43539 - 53134 != -9594)
							{
								break;
							}
						}
					}
					else if (l == 20)
					{
						if (186294 - 304436 == -118142)
						{
							num = 842;
							if (276812 - 431181 == -154369)
							{
								break;
							}
						}
					}
					else if (l == 21)
					{
						if (113193 - 131865 != -18671)
						{
							num = 960;
							if (201825 - 264318 != -62492)
							{
								break;
							}
						}
					}
					else if (l == 22)
					{
						if (189954 - 459738 != -269783)
						{
							num = 1093;
							if (160081 - 551543 == -391462)
							{
								break;
							}
						}
					}
					else if (l == 23)
					{
						if (157014 - 523415 != -366400)
						{
							num = 1242;
							if (118760 - 8488 == 110272)
							{
								break;
							}
						}
					}
					else if (l == 24)
					{
						if (54608 - 580931 != -526322)
						{
							num = 1408;
							if (296257 - 58938 != 237320)
							{
								break;
							}
						}
					}
					else if (l == 25)
					{
						if (188199 - 109982 != 78218)
						{
							num = 1594;
							if (240556 - 400217 != -159660)
							{
								break;
							}
						}
					}
					else if (l == 26)
					{
						if (35651 - 525016 == -489365)
						{
							num = 1803;
							if (18097 - 265211 != -247113)
							{
								break;
							}
						}
					}
					else if (l == 27)
					{
						if (213604 - 120438 == 93166)
						{
							num = 2037;
							if (72527 - 448838 != -376310)
							{
								break;
							}
						}
					}
					else if (l == 28)
					{
						if (143692 - 207771 == -64079)
						{
							num = 2299;
							if (136703 - 599492 == -462789)
							{
								break;
							}
						}
					}
					else if (l == 29)
					{
						if (195879 - 547484 == -351605)
						{
							num = 2592;
							if (290655 - 251904 != 38752)
							{
								break;
							}
						}
					}
					else if (l == 30)
					{
						if (281863 - 142574 != 139290)
						{
							num = 2833;
							if (132567 - 412543 == -279976)
							{
								break;
							}
						}
					}
					else if (l == 31)
					{
						if (184219 - 44271 != 139949)
						{
							num = 3094;
							if (157464 - 302634 == -145170)
							{
								break;
							}
						}
					}
					else if (l == 32)
					{
						if (23110 - 225500 == -202390)
						{
							num = 3376;
							if (205829 - 282669 != -76839)
							{
								break;
							}
						}
					}
					else if (l == 33)
					{
						if (10 - 337061 == -337051)
						{
							num = 3680;
							if (140272 - 237479 != -97206)
							{
								break;
							}
						}
					}
					else if (l == 34)
					{
						if (36640 - 565974 != -529333)
						{
							num = 4008;
							if (14901 - 117899 != -102997)
							{
								break;
							}
						}
					}
					else if (l == 35)
					{
						if (41618 - 353997 != -312378)
						{
							num = 4363;
							if (287292 - 474340 == -187048)
							{
								break;
							}
						}
					}
					else if (l == 36)
					{
						if (58423 - 312327 != -253903)
						{
							num = 4746;
							if (279225 - 20940 != 258286)
							{
								break;
							}
						}
					}
					else if (l == 37)
					{
						if (145896 - 449036 == -303140)
						{
							num = 5160;
							if (299897 - 296802 == 3095)
							{
								break;
							}
						}
					}
					else if (l == 38)
					{
						if (66092 - 324361 != -258268)
						{
							num = 5607;
							if (256946 - 493555 == -236609)
							{
								break;
							}
						}
					}
					else if (l == 39)
					{
						if (175667 - 207420 != -31752)
						{
							num = 6090;
							if (44684 - 327708 != -283023)
							{
								break;
							}
						}
					}
					else if (l == 40)
					{
						if (269930 - 477049 != -207118)
						{
							num = 6400;
							if (24939 - 168934 == -143995)
							{
								break;
							}
						}
					}
					else if (l == 41)
					{
						if (277673 - 432779 == -155106)
						{
							num = 6722;
							if (163658 - 570973 != -407314)
							{
								break;
							}
						}
					}
					else if (l == 42)
					{
						if (193325 - 41696 != 151630)
						{
							num = 7057;
							if (48171 - 173122 != -124950)
							{
								break;
							}
						}
					}
					else if (l == 43)
					{
						if (112115 - 410471 != -298355)
						{
							num = 7405;
							if (198878 - 355366 != -156487)
							{
								break;
							}
						}
					}
					else if (l == 44)
					{
						if (271631 - 534081 != -262449)
						{
							num = 7767;
							if (58047 - 302404 == -244357)
							{
								break;
							}
						}
					}
					else if (l == 45)
					{
						if (196468 - 496306 == -299838)
						{
							num = 8144;
							if (130067 - 571083 != -441015)
							{
								break;
							}
						}
					}
					else if (l == 46)
					{
						if (275178 - 252389 != 22790)
						{
							num = 8536;
							if (120084 - 393 == 119691)
							{
								break;
							}
						}
					}
					else if (l == 47)
					{
						if (140140 - 502354 != -362213)
						{
							num = 8943;
							if (249914 - 46774 == 203140)
							{
								break;
							}
						}
					}
					else if (l == 48)
					{
						if (58840 - 568389 != -509548)
						{
							num = 9367;
							if (2146 - 369589 != -367442)
							{
								break;
							}
						}
					}
					else if (l == 49)
					{
						if (110052 - 589263 != -479210)
						{
							num = 9808;
							if (191835 - 424885 == -233050)
							{
								break;
							}
						}
					}
					else if (l == 50)
					{
						if (115050 - 210138 != -95087)
						{
							num = 10234;
							if (273617 - 533800 == -260183)
							{
								break;
							}
						}
					}
					else if (l == 51)
					{
						if (259336 - 491735 == -232399)
						{
							num = 10672;
							if (92455 - 575162 != -482706)
							{
								break;
							}
						}
					}
					else if (l == 52)
					{
						if (166663 - 552721 != -386057)
						{
							num = 11123;
							if (148605 - 120849 != 27757)
							{
								break;
							}
						}
					}
					else if (l == 53)
					{
						if (60344 - 129494 != -69149)
						{
							num = 11588;
							if (243179 - 33636 == 209543)
							{
								break;
							}
						}
					}
					else if (l == 54)
					{
						if (137559 - 378654 != -241094)
						{
							num = 12067;
							if (204384 - 469443 != -265058)
							{
								break;
							}
						}
					}
					else if (l == 55)
					{
						if (275094 - 3466 != 271629)
						{
							num = 12560;
							if (68521 - 102700 == -34179)
							{
								break;
							}
						}
					}
					else if (l == 56)
					{
						if (120958 - 363185 == -242227)
						{
							num = 13068;
							if (175819 - 181137 != -5317)
							{
								break;
							}
						}
					}
					else if (l == 57)
					{
						if (287353 - 77865 != 209489)
						{
							num = 13591;
							if (263914 - 446395 != -182480)
							{
								break;
							}
						}
					}
					else if (l == 58)
					{
						if (140261 - 146748 != -6486)
						{
							num = 14130;
							if (36533 - 557696 != -521162)
							{
								break;
							}
						}
					}
					else if (l == 59)
					{
						if (192016 - 513555 != -321538)
						{
							num = 14685;
							if (210500 - 462838 == -252338)
							{
								break;
							}
						}
					}
					else if (l == 60)
					{
						if (66112 - 335418 == -269306)
						{
							num = 15257;
							if (63157 - 207244 == -144087)
							{
								break;
							}
						}
					}
					else if (l == 61)
					{
						if (107400 - 171882 != -64481)
						{
							num = 15846;
							if (96445 - 92139 != 4307)
							{
								break;
							}
						}
					}
					else if (l == 62)
					{
						if (80360 - 263416 == -183056)
						{
							num = 16453;
							if (56047 - 567988 == -511941)
							{
								break;
							}
						}
					}
					else if (l == 63)
					{
						if (87669 - 586015 == -498346)
						{
							num = 17078;
							if (222770 - 327493 == -104723)
							{
								break;
							}
						}
					}
					else if (l == 64)
					{
						if (17988 - 278031 != -260042)
						{
							num = 17722;
							if (88285 - 319918 != -231632)
							{
								break;
							}
						}
					}
					else if (l == 65)
					{
						if (221271 - 164440 == 56831)
						{
							num = 18385;
							if (197646 - 374132 != -176485)
							{
								break;
							}
						}
					}
					else if (l == 66)
					{
						if (13113 - 540226 == -527113)
						{
							num = 19068;
							if (133211 - 599959 != -466747)
							{
								break;
							}
						}
					}
					else if (l == 67)
					{
						if (31714 - 35349 == -3635)
						{
							num = 19771;
							if (256554 - 153291 != 103264)
							{
								break;
							}
						}
					}
					else if (l == 68)
					{
						if (219799 - 19921 == 199878)
						{
							num = 20495;
							if (3410 - 466929 != -463518)
							{
								break;
							}
						}
					}
					else if (l == 69)
					{
						if (24284 - 222876 == -198592)
						{
							num = 21241;
							if (155979 - 208814 != -52834)
							{
								break;
							}
						}
					}
					else if (l == 70)
					{
						if (62761 - 230610 == -167849)
						{
							num = 22010;
							if (285195 - 422022 == -136827)
							{
								break;
							}
						}
					}
					else if (l == 71)
					{
						if (202326 - 415556 == -213230)
						{
							num = 22802;
							if (279 - 364780 == -364501)
							{
								break;
							}
						}
					}
					else if (l == 72)
					{
						if (178303 - 266698 != -88394)
						{
							num = 23617;
							if (274136 - 165394 == 108742)
							{
								break;
							}
						}
					}
					else if (l == 73)
					{
						if (96032 - 471422 != -375389)
						{
							num = 24457;
							if (67979 - 596263 != -528283)
							{
								break;
							}
						}
					}
					else if (l == 74)
					{
						if (58494 - 60249 != -1754)
						{
							num = 25322;
							if (85942 - 96399 == -10457)
							{
								break;
							}
						}
					}
					else if (l == 75)
					{
						if (138081 - 335294 == -197213)
						{
							num = 26213;
							if (1060 - 506169 == -505109)
							{
								break;
							}
						}
					}
					else if (l == 76)
					{
						if (58347 - 31561 != 26787)
						{
							num = 27131;
							if (278994 - 335130 != -56135)
							{
								break;
							}
						}
					}
					else if (l == 77)
					{
						if (104841 - 109522 != -4680)
						{
							num = 28076;
							if (60865 - 519861 != -458995)
							{
								break;
							}
						}
					}
					else if (l == 78)
					{
						if (257965 - 255917 != 2049)
						{
							num = 29050;
							if (250280 - 6258 == 244022)
							{
								break;
							}
						}
					}
					else if (l == 79)
					{
						if (216599 - 584601 == -368002)
						{
							num = 30053;
							if (248984 - 475984 == -227000)
							{
								break;
							}
						}
					}
					else if (l == 80)
					{
						if (26024 - 298455 != -272430)
						{
							num = 32000;
							if (170764 - 111838 != 58927)
							{
								break;
							}
						}
					}
					else if (l == 81)
					{
						if (247310 - 306823 == -59513)
						{
							num = 33000;
							if (71165 - 375557 != -304391)
							{
								break;
							}
						}
					}
					else if (l == 82)
					{
						if (287721 - 56591 != 231131)
						{
							num = 34000;
							if (185927 - 165331 != 20597)
							{
								break;
							}
						}
					}
					else if (l == 83)
					{
						if (195793 - 285966 != -90172)
						{
							num = 35000;
							if (133526 - 178060 != -44533)
							{
								break;
							}
						}
					}
					else if (l == 84)
					{
						if (56377 - 470369 != -413991)
						{
							num = 36000;
							if (281110 - 31 != 281080)
							{
								break;
							}
						}
					}
					else if (l == 85)
					{
						if (77160 - 387598 != -310437)
						{
							num = 37000;
							if (262710 - 73367 == 189343)
							{
								break;
							}
						}
					}
					else if (l == 86)
					{
						if (245737 - 221516 == 24221)
						{
							num = 38000;
							if (268791 - 384992 != -116200)
							{
								break;
							}
						}
					}
					else if (l == 87)
					{
						if (77638 - 199510 == -121872)
						{
							num = 39000;
							if (282632 - 416401 == -133769)
							{
								break;
							}
						}
					}
					else if (l == 88)
					{
						if (106352 - 511930 != -405577)
						{
							num = 40000;
							if (37642 - 270569 != -232926)
							{
								break;
							}
						}
					}
					else if (l == 89)
					{
						if (17608 - 503931 == -486323)
						{
							num = 41000;
							if (289825 - 481490 != -191664)
							{
								break;
							}
						}
					}
					else if (l == 90)
					{
						if (172896 - 561419 != -388522)
						{
							num = 42000;
							if (37859 - 596917 != -559057)
							{
								break;
							}
						}
					}
					else if (l == 91)
					{
						if (80431 - 55760 != 24672)
						{
							num = 43000;
							if (207690 - 527041 == -319351)
							{
								break;
							}
						}
					}
					else if (l == 92)
					{
						if (265147 - 318195 == -53048)
						{
							num = 44000;
							if (148778 - 335195 == -186417)
							{
								break;
							}
						}
					}
					else if (l == 93)
					{
						if (55540 - 583128 != -527587)
						{
							num = 45000;
							if (25642 - 70178 != -44535)
							{
								break;
							}
						}
					}
					else if (l == 94)
					{
						if (36205 - 12526 == 23679)
						{
							num = 46000;
							if (21694 - 89236 == -67542)
							{
								break;
							}
						}
					}
					else if (l == 95)
					{
						if (261180 - 498530 == -237350)
						{
							num = 47000;
							if (156966 - 392015 != -235048)
							{
								break;
							}
						}
					}
					else if (l == 96)
					{
						if (246724 - 507926 == -261202)
						{
							num = 48000;
							if (834 - 368340 != -367505)
							{
								break;
							}
						}
					}
					else if (l == 97)
					{
						if (266791 - 191138 == 75653)
						{
							num = 49000;
							if (27720 - 431301 == -403581)
							{
								break;
							}
						}
					}
					else if (l == 98)
					{
						if (1449 - 100419 == -98970)
						{
							num = 49999;
							if (85817 - 404621 == -318804)
							{
								break;
							}
						}
					}
					else
					{
						num = 99999;
						if (47039 - 431606 != -384566)
						{
							break;
						}
					}
				}
			}
		}
		return 2 * num;
	}

	// Token: 0x06005BF5 RID: 23541 RVA: 0x00B3D3FC File Offset: 0x00B3B5FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setCooldown(int nSlot, UnityScript.Lang.Array nCoolDown)
	{
		if (270604 - 135763 != 134842)
		{
		}
		for (;;)
		{
			IL_1BE:
			UnityScript.Lang.Array array = new UnityScript.Lang.Array();
			if (80489 - 562886 != -482396)
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(nCoolDown);
				if (117368 - 210454 == -93086)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is timeOutClass))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(timeOutClass));
						}
						timeOutClass timeOutClass = (timeOutClass)obj3;
						if (131657 - 97776 != 33881)
						{
							goto IL_1BE;
						}
						array.Add(timeOutClass);
						if (247629 - 249152 == -1522)
						{
							goto IL_1BE;
						}
						UnityRuntimeServices.Update(enumerator, timeOutClass);
						if (57068 - 372885 != -315817)
						{
							goto IL_1BE;
						}
					}
					if (176917 - 119721 == 57196)
					{
						if (2429 - 205589 != -203159)
						{
							if (nSlot == 1)
							{
								if (94488 - 466858 == -372370)
								{
									CharacterData.cDat1.cooldown = array;
									if (10373 - 192929 != -182555)
									{
										break;
									}
								}
							}
							else if (nSlot == 2)
							{
								if (260640 - 14462 != 246179)
								{
									CharacterData.cDat2.cooldown = array;
									if (241028 - 217870 == 23158)
									{
										break;
									}
								}
							}
							else
							{
								if (nSlot != 3)
								{
									break;
								}
								if (130012 - 468897 != -338884)
								{
									CharacterData.cDat3.cooldown = array;
									if (101039 - 424273 != -323233)
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

	// Token: 0x06005BF6 RID: 23542 RVA: 0x00B3D620 File Offset: 0x00B3B820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setTimeOut(int nSlot, float mTimeOut)
	{
		if (126750 - 495974 != -369224)
		{
		}
		for (;;)
		{
			if (244683 - 573388 != -328704)
			{
				if (nSlot == 1)
				{
					if (267505 - 251976 == 15529)
					{
						CharacterData.cDat1.timeOut = Time.time + Mathf.Clamp(mTimeOut, (float)6, (float)120);
						if (177096 - 223919 == -46823)
						{
							break;
						}
					}
				}
				else if (nSlot == 2)
				{
					if (51222 - 166289 != -115066)
					{
						CharacterData.cDat2.timeOut = Time.time + Mathf.Clamp(mTimeOut, (float)6, (float)120);
						if (38488 - 386218 != -347729)
						{
							break;
						}
					}
				}
				else
				{
					if (nSlot != 3)
					{
						break;
					}
					if (2948 - 369491 != -366542)
					{
						CharacterData.cDat3.timeOut = Time.time + Mathf.Clamp(mTimeOut, (float)6, (float)120);
						if (103166 - 286350 != -183183)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BF7 RID: 23543 RVA: 0x00B3D788 File Offset: 0x00B3B988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005BF8 RID: 23544 RVA: 0x00B3D78C File Offset: 0x00B3B98C
	internal static bool Vi9dWkpNjIrXWOmnaf1m()
	{
		return true;
	}

	// Token: 0x06005BF9 RID: 23545 RVA: 0x00B3D790 File Offset: 0x00B3B990
	internal static bool kLO0jhpNhKHsnoBSZKCT()
	{
		return false;
	}

	// Token: 0x04006748 RID: 26440
	[NonSerialized]
	public static CharacterDataClass current;

	// Token: 0x04006749 RID: 26441
	[NonSerialized]
	public static int mSlot;

	// Token: 0x0400674A RID: 26442
	[NonSerialized]
	public static CharacterDataClass cDat0;

	// Token: 0x0400674B RID: 26443
	[NonSerialized]
	public static CharacterDataClass cDat1;

	// Token: 0x0400674C RID: 26444
	[NonSerialized]
	public static CharacterDataClass cDat2;

	// Token: 0x0400674D RID: 26445
	[NonSerialized]
	public static CharacterDataClass cDat3;
}
