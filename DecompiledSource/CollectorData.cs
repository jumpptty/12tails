using System;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000FBE RID: 4030
[Serializable]
public class CollectorData : MonoBehaviour
{
	// Token: 0x06005C07 RID: 23559 RVA: 0x00B3E9A0 File Offset: 0x00B3CBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CollectorData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005C08 RID: 23560 RVA: 0x00B3E9B0 File Offset: 0x00B3CBB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] getItemList(bool usable)
	{
		return new string[]
		{
			"f_hlb1",
			"f_hlb3",
			"d_cnd6",
			"m_asd4",
			"k_dun1",
			"k_dun2",
			"k_trp1",
			"k_trp2",
			"k_trp3",
			"k_trp4",
			"k_trp5",
			"k_trp6",
			"k_dtk2",
			"k_dtk3",
			"k_dtk4",
			"k_dtk5",
			"o_all3",
			"o_all4",
			"o_all5",
			"o_all6",
			"o_all7",
			"o_all9",
			"t_all46",
			"t_all7",
			"t_all3",
			"t_all4",
			"b_all45"
		};
	}

	// Token: 0x06005C09 RID: 23561 RVA: 0x00B3EAB0 File Offset: 0x00B3CCB0
	[DuckTyped]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object getEquipmentList(bool usable)
	{
		if (202547 - 181811 != 20736)
		{
		}
		string[] array;
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_1A:
			array = new string[]
			{
				"w_wlf59",
				"w_bsn59",
				"w_pnd59",
				"w_whl59",
				"w_cat59",
				"w_chm59",
				"w_rab59",
				"w_mol59",
				"w_mnk59",
				"w_pgn59",
				"w_shp59",
				"w_bat59",
				"w_wlf52",
				"w_bsn52",
				"w_pnd52",
				"w_whl52",
				"w_cat52",
				"w_chm52",
				"w_rab52",
				"w_mol52",
				"w_mnk52",
				"w_pgn52",
				"w_shp52",
				"w_bat52",
				"a_wlf52",
				"a_bsn52",
				"a_pnd52",
				"a_whl52",
				"a_cat52",
				"a_chm52",
				"a_rab52",
				"a_mol52",
				"a_mnk52",
				"a_pgn52",
				"a_shp52",
				"a_bat52",
				"c_wlf52",
				"c_bsn52",
				"c_pnd52",
				"c_whl52",
				"c_cat52",
				"c_chm52",
				"c_rab52",
				"c_mol52",
				"c_mnk52",
				"c_pgn52",
				"c_shp52",
				"c_bat52",
				"w_wlf42",
				"w_bsn42",
				"w_pnd42",
				"w_whl42",
				"w_cat42",
				"w_chm42",
				"w_rab42",
				"w_mol42",
				"w_mnk42",
				"w_pgn42",
				"w_shp42",
				"w_bat42",
				"a_wlf42",
				"a_bsn42",
				"a_pnd42",
				"a_whl42",
				"a_cat42",
				"a_chm42",
				"a_rab42",
				"a_mol42",
				"a_mnk42",
				"a_pgn42",
				"a_shp42",
				"a_bat42",
				"c_wlf42",
				"c_bsn42",
				"c_pnd42",
				"c_whl42",
				"c_cat42",
				"c_chm42",
				"c_rab42",
				"c_mol42",
				"c_mnk42",
				"c_pgn42",
				"c_shp42",
				"c_bat42",
				"w_wlf12",
				"w_bsn12",
				"w_pnd12",
				"w_whl12",
				"w_cat12",
				"w_chm12",
				"w_rab12",
				"w_mol12",
				"w_mnk12",
				"w_pgn12",
				"w_shp12",
				"w_bat12",
				"a_wlf12",
				"a_bsn12",
				"a_pnd12",
				"a_whl12",
				"a_cat12",
				"a_chm12",
				"a_rab12",
				"a_mol12",
				"a_mnk12",
				"a_pgn12",
				"a_shp12",
				"a_bat12",
				"c_cat12",
				"c_chm12",
				"c_rab12",
				"c_mol12",
				"c_mnk12",
				"c_pgn12",
				"c_all37",
				"c_all29",
				"c_all7",
				"c_all8"
			};
			if (138167 - 229510 != -91342)
			{
				if (!usable)
				{
					if (3520 - 186968 == -183448)
					{
						break;
					}
				}
				else
				{
					array2 = new UnityScript.Lang.Array();
					if (171029 - 365532 != -194502)
					{
						int i = 0;
						if (200925 - 423376 == -222451)
						{
							string[] array3 = array;
							if (221481 - 416621 == -195140)
							{
								int length = array3.Length;
								if (70494 - 286568 != -216073)
								{
									while (i < length)
									{
										if (CharacterData.current.canEquip(array3[i]))
										{
											if (103780 - 213453 != -109673)
											{
												goto IL_1A;
											}
											array2.Add(array3[i]);
											if (266804 - 456849 == -190044)
											{
												goto IL_1A;
											}
										}
										i++;
										if (262620 - 225938 == 36683)
										{
											goto IL_1A;
										}
									}
									if (281676 - 455741 == -174065)
									{
										goto IL_591;
									}
								}
							}
						}
					}
				}
			}
		}
		return array;
		IL_591:
		return array2;
	}

	// Token: 0x06005C0A RID: 23562 RVA: 0x00B3F068 File Offset: 0x00B3D268
	[DuckTyped]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object getCoinList(bool usable)
	{
		if (64100 - 95530 != -31430)
		{
		}
		string[] array;
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_73:
			array = new string[]
			{
				"n_veg1",
				"n_veg2",
				"n_veg3",
				"n_veg4",
				"n_veg5",
				"n_veg6",
				"n_npc1",
				"n_npc2",
				"n_npc3",
				"n_npc4",
				"n_npc7",
				"n_npc8",
				"n_npc9",
				"n_npc10",
				"n_npc11",
				"n_npc12",
				"n_npc13",
				"n_npc14",
				"n_npc15",
				"n_npc16",
				"n_npc17",
				"n_npc18",
				"n_npc19",
				"n_npc20",
				"n_npc21",
				"n_npc22",
				"n_npc23",
				"n_npc24",
				"n_npc25",
				"n_npc26",
				"n_npc27",
				"n_npc28",
				"n_npc29",
				"n_npc30",
				"n_npc31",
				"n_npc32",
				"n_npc33",
				"n_npc34"
			};
			if (188643 - 36779 != 151865)
			{
				if (!usable)
				{
					if (2180 - 259579 != -257398)
					{
						break;
					}
				}
				else
				{
					array2 = new UnityScript.Lang.Array();
					if (116408 - 304502 == -188094)
					{
						int i = 0;
						if (242703 - 5578 == 237125)
						{
							string[] array3 = array;
							if (231351 - 488319 == -256968)
							{
								int length = array3.Length;
								if (296250 - 231633 == 64617)
								{
									while (i < length)
									{
										if (Mathf.Abs(ItemData.getLv(array3[i])) <= PlayerData.Rank)
										{
											if (82210 - 520260 == -438049)
											{
												goto IL_73;
											}
											array2.Add(array3[i]);
											if (212269 - 477934 == -265664)
											{
												goto IL_73;
											}
										}
										i++;
										if (282228 - 193732 != 88496)
										{
											goto IL_73;
										}
									}
									if (255914 - 316660 == -60746)
									{
										goto IL_2C6;
									}
								}
							}
						}
					}
				}
			}
		}
		return array;
		IL_2C6:
		return array2;
	}

	// Token: 0x06005C0B RID: 23563 RVA: 0x00B3F354 File Offset: 0x00B3D554
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getMaterial(string nItem)
	{
		if (190494 - 404838 != -214344)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (192014 - 266589 != -74574 && 159210 - 579136 != -419925)
			{
				if (nItem == "f_nyb1")
				{
					if (132398 - 51643 != 80756)
					{
						result = "d_cnd2%12, d_cnd3%12, d_cnd4%12";
						if (68420 - 366804 != -298383)
						{
							break;
						}
					}
				}
				else if (nItem == "f_fwk5")
				{
					if (222634 - 344912 == -122278)
					{
						result = "f_fwk1%4,f_fwk2%4,f_fwk3%4,f_fwk4%4";
						if (30726 - 296194 != -265467)
						{
							break;
						}
					}
				}
				else if (nItem == "p_all21")
				{
					if (272051 - 117137 == 154914)
					{
						result = "f_ppl1%30,m_fab14%3,m_pin2%3,d_dst8%12";
						if (121132 - 440710 != -319577)
						{
							break;
						}
					}
				}
				else if (nItem == "p_all22")
				{
					if (50622 - 378054 != -327431)
					{
						result = "f_ppl1%30,m_fab14%3,m_pin2%3,d_dst7%12";
						if (47049 - 353922 != -306872)
						{
							break;
						}
					}
				}
				else if (nItem == "f_vlb1")
				{
					if (140172 - 261180 != -121007)
					{
						result = "d_cak4%12,m_bug30%6,m_bug53%2";
						if (170903 - 36180 == 134723)
						{
							break;
						}
					}
				}
				else if (nItem == "f_vlb2")
				{
					if (148011 - 218030 != -70018)
					{
						result = "d_cak4%12,m_bug30%6,m_bug54%2";
						if (146385 - 258564 != -112178)
						{
							break;
						}
					}
				}
				else if (nItem == "f_ktg1")
				{
					if (189183 - 320488 != -131304)
					{
						result = "d_brd1%3,m_bug33%3,f_fwk1%3";
						if (287783 - 100307 != 187477)
						{
							break;
						}
					}
				}
				else if (nItem == "f_ktg2")
				{
					if (121741 - 22691 != 99051)
					{
						result = "m_bug62%1,d_veg1%12,d_veg6%1,f_fwk3%6";
						if (283595 - 309012 != -25416)
						{
							break;
						}
					}
				}
				else if (nItem == "f_ktg3")
				{
					if (172095 - 231503 == -59408)
					{
						result = "m_bug29%1,m_bug28%3,m_bug56%3,f_fwk2%9";
						if (218589 - 596055 != -377465)
						{
							break;
						}
					}
				}
				else if (nItem == "f_ktg5")
				{
					if (294039 - 292923 == 1116)
					{
						result = "m_wod1%1,m_bug33%1,m_flw3%1";
						if (72373 - 323222 != -250848)
						{
							break;
						}
					}
				}
				else if (nItem == "f_skl1")
				{
					if (11059 - 84787 != -73727)
					{
						result = "m_wod1%1,m_bug6%2,m_gle1%1,m_peb1%1";
						if (254871 - 187894 == 66977)
						{
							break;
						}
					}
				}
				else if (nItem == "f_smb1")
				{
					if (299452 - 477515 != -178062)
					{
						result = "f_wtb1%60,k_bdg5%20,d_veg15%10";
						if (136088 - 473178 == -337090)
						{
							break;
						}
					}
				}
				else if (nItem == "p_sfb1")
				{
					if (101679 - 85862 == 15817)
					{
						result = "m_bug33%30,m_bug56%20,m_pin2%20,f_rsc5%1";
						if (85915 - 146907 == -60992)
						{
							break;
						}
					}
				}
				else if (nItem == "f_hlb1")
				{
					if (52503 - 525119 != -472615)
					{
						result = "d_cnd6%13";
						if (103807 - 56756 == 47051)
						{
							break;
						}
					}
				}
				else if (nItem == "f_hlb3")
				{
					if (246685 - 82407 == 164278)
					{
						result = "d_cnd6%99";
						if (26337 - 482522 == -456185)
						{
							break;
						}
					}
				}
				else if (nItem == "d_cnd6")
				{
					if (215485 - 248458 == -32973)
					{
						result = "d_cnd2%6,d_cnd3%6,d_cnd4%6, d_cnd5%6";
						if (275074 - 204192 == 70882)
						{
							break;
						}
					}
				}
				else if (nItem == "m_asd4")
				{
					if (271742 - 515505 != -243762)
					{
						result = "f_rsc4%1,m_bon2%1,m_wmt13%6,m_crs6%66";
						if (215593 - 164909 != 50685)
						{
							break;
						}
					}
				}
				else if (nItem == "f_dem1")
				{
					if (68475 - 161002 != -92526)
					{
						result = "k_dun6%1,k_dun7%1";
						if (161021 - 466946 == -305925)
						{
							break;
						}
					}
				}
				else if (nItem == "f_dem2")
				{
					if (38318 - 348066 != -309747)
					{
						result = "k_dun6%1,k_dun8%1";
						if (12459 - 448740 == -436281)
						{
							break;
						}
					}
				}
				else if (nItem == "f_dem3")
				{
					if (245658 - 498304 != -252645)
					{
						result = "k_dun6%1,k_dun9%1";
						if (208010 - 243689 == -35679)
						{
							break;
						}
					}
				}
				else if (nItem == "t_all68")
				{
					if (19021 - 384387 != -365365)
					{
						result = "k_dun7%1,k_dun8%1,k_dun10%1";
						if (250593 - 73675 != 176919)
						{
							break;
						}
					}
				}
				else if (nItem == "t_all69")
				{
					if (84776 - 86314 == -1538)
					{
						result = "k_dun8%1,k_dun9%1,k_dun10%1";
						if (199479 - 221591 != -22111)
						{
							break;
						}
					}
				}
				else if (nItem == "b_all66")
				{
					if (291716 - 363851 == -72135)
					{
						result = "k_dun7%1,k_dun9%1,k_dun10%1";
						if (62022 - 435562 == -373540)
						{
							break;
						}
					}
				}
				else if (nItem == "k_dun1")
				{
					if (162739 - 501654 == -338915)
					{
						result = "k_trp1%3, k_trp2%3, k_trp3%3";
						if (225904 - 420271 == -194367)
						{
							break;
						}
					}
				}
				else if (nItem == "k_dun2")
				{
					if (264108 - 24841 != 239268)
					{
						result = "m_fab13%1,m_gas4%1,m_bro7%1,m_orb9%1";
						if (59273 - 95330 != -36056)
						{
							break;
						}
					}
				}
				else if (nItem == "k_trp1")
				{
					if (120502 - 567137 == -446635)
					{
						result = "k_bvt1%12";
						if (32548 - 517125 == -484577)
						{
							break;
						}
					}
				}
				else if (nItem == "k_trp2")
				{
					if (15901 - 88887 == -72986)
					{
						result = "k_bvt2%12";
						if (29131 - 363093 == -333962)
						{
							break;
						}
					}
				}
				else if (nItem == "k_trp3")
				{
					if (48573 - 560773 == -512200)
					{
						result = "k_bvt3%12";
						if (44105 - 347629 != -303523)
						{
							break;
						}
					}
				}
				else if (nItem == "k_trp4")
				{
					if (132868 - 179246 != -46377)
					{
						result = "k_bvt4%12";
						if (99657 - 97808 != 1850)
						{
							break;
						}
					}
				}
				else if (nItem == "k_trp5")
				{
					if (93893 - 202486 == -108593)
					{
						result = "k_bvt5%12";
						if (180226 - 120607 == 59619)
						{
							break;
						}
					}
				}
				else if (nItem == "k_trp6")
				{
					if (229136 - 5518 != 223619)
					{
						result = "k_bvt6%12";
						if (226176 - 149664 == 76512)
						{
							break;
						}
					}
				}
				else if (nItem == "k_dtk2")
				{
					if (209568 - 289119 == -79551)
					{
						result = "k_dtk1%6";
						if (148379 - 251038 == -102659)
						{
							break;
						}
					}
				}
				else if (nItem == "k_dtk3")
				{
					if (85649 - 467547 == -381898)
					{
						result = "k_dtk2%6";
						if (222592 - 165464 != 57129)
						{
							break;
						}
					}
				}
				else if (nItem == "k_dtk4")
				{
					if (205206 - 308132 != -102925)
					{
						result = "k_dtk3%6";
						if (290406 - 433071 != -142664)
						{
							break;
						}
					}
				}
				else if (nItem == "k_dtk5")
				{
					if (270264 - 344270 == -74006)
					{
						result = "k_dtk4%6";
						if (245717 - 129762 != 115956)
						{
							break;
						}
					}
				}
				else if (nItem == "o_all3")
				{
					if (38613 - 374155 == -335542)
					{
						result = "o_all1%1,m_asd1%1";
						if (117195 - 524853 != -407657)
						{
							break;
						}
					}
				}
				else if (nItem == "o_all4")
				{
					if (227253 - 393753 != -166499)
					{
						result = "o_all1%1,m_asd2%1";
						if (143487 - 506778 == -363291)
						{
							break;
						}
					}
				}
				else if (nItem == "o_all5")
				{
					if (225727 - 116258 != 109470)
					{
						result = "o_all2%1,m_asd5%1";
						if (219822 - 330092 != -110269)
						{
							break;
						}
					}
				}
				else if (nItem == "o_all6")
				{
					if (298769 - 530890 != -232120)
					{
						result = "o_all1%1,m_asd3%1";
						if (202999 - 473852 == -270853)
						{
							break;
						}
					}
				}
				else if (nItem == "o_all7")
				{
					if (160282 - 550508 != -390225)
					{
						result = "o_all2%1,m_asd4%1";
						if (220184 - 3872 != 216313)
						{
							break;
						}
					}
				}
				else if (nItem == "o_all9")
				{
					if (198514 - 118808 == 79706)
					{
						result = "m_eqp9%5";
						if (160619 - 37535 != 123085)
						{
							break;
						}
					}
				}
				else if (nItem == "c_all7")
				{
					if (229842 - 117678 == 112164)
					{
						result = "k_dtk1%6,k_dtk2%6";
						if (95233 - 363462 != -268228)
						{
							break;
						}
					}
				}
				else if (nItem == "c_all8")
				{
					if (124637 - 63257 != 61381)
					{
						result = "k_dtk1%6,k_dtk2%6";
						if (184177 - 102080 != 82098)
						{
							break;
						}
					}
				}
				else if (nItem == "c_all29")
				{
					if (64053 - 587569 == -523516)
					{
						result = "m_ice1%8,m_ice2%6,k_tol2%6,k_dtk3%6";
						if (68476 - 177115 == -108639)
						{
							break;
						}
					}
				}
				else if (nItem == "c_all37")
				{
					if (116923 - 107828 != 9096)
					{
						result = "k_gdp1%60,k_dtk5%12";
						if (123922 - 133977 == -10055)
						{
							break;
						}
					}
				}
				else if (nItem == "t_all46")
				{
					if (147928 - 559444 != -411515)
					{
						result = "k_trp8%12,k_dtk5%12,k_tlm1%12";
						if (57515 - 349188 == -291673)
						{
							break;
						}
					}
				}
				else if (nItem == "t_all4")
				{
					if (195747 - 125049 == 70698)
					{
						result = "k_gdp1%12,k_dtk1%12";
						if (15262 - 543131 != -527868)
						{
							break;
						}
					}
				}
				else if (nItem == "t_all7")
				{
					if (14029 - 129973 != -115943)
					{
						result = "k_dtk2%6,k_dtk3%6";
						if (54269 - 532928 != -478658)
						{
							break;
						}
					}
				}
				else if (nItem == "t_all3")
				{
					if (70074 - 262103 != -192028)
					{
						result = "k_dtk3%6,k_dtk4%6";
						if (175602 - 567089 == -391487)
						{
							break;
						}
					}
				}
				else if (nItem == "b_all45")
				{
					if (59635 - 229620 != -169984)
					{
						result = "b_all41%1, k_dtk5%12";
						if (134241 - 218203 != -83961)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf12")
				{
					if (60154 - 102045 == -41891)
					{
						result = "w_wlf11%1,n_npc7%3,k_cwn1%6,m_asl1%1";
						if (272502 - 290627 == -18125)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn12")
				{
					if (139690 - 501944 != -362253)
					{
						result = "w_bsn11%1,n_npc7%3,m_bug22%4,m_asl1%1";
						if (130113 - 315395 == -185282)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd12")
				{
					if (230519 - 351732 != -121212)
					{
						result = "w_pnd11%1,n_npc7%3,m_bug9%10,m_asl1%1";
						if (119398 - 30081 == 89317)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl12")
				{
					if (154112 - 595588 != -441475)
					{
						result = "w_whl11%1,n_npc7%3,m_bug17%10,m_asl1%1";
						if (262606 - 263284 != -677)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat12")
				{
					if (280034 - 423136 != -143101)
					{
						result = "w_cat11%1,n_npc7%3,k_crd1%15,m_asl1%1";
						if (251449 - 328083 != -76633)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm12")
				{
					if (168099 - 505535 != -337435)
					{
						result = "w_chm11%1,n_npc7%3,m_bug7%5,m_asl1%1";
						if (63731 - 128173 == -64442)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab12")
				{
					if (45984 - 8700 != 37285)
					{
						result = "w_rab11%1,n_npc7%3,m_bug27%7,m_asl1%1";
						if (192129 - 244673 != -52543)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol12")
				{
					if (140634 - 153954 == -13320)
					{
						result = "w_mol11%1,n_npc7%3,d_egg3%5,m_asl1%1";
						if (81441 - 119354 != -37912)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk12")
				{
					if (50668 - 354989 != -304320)
					{
						result = "w_mnk11%1,n_npc7%3,m_flw1%4,m_asl1%1";
						if (75111 - 329769 == -254658)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp12")
				{
					if (97795 - 491795 == -394000)
					{
						result = "w_shp11%1,n_npc7%3,m_flw4%6,m_asl1%1";
						if (144758 - 422709 == -277951)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn12")
				{
					if (51217 - 240065 == -188848)
					{
						result = "w_pgn11%1,n_npc7%3,m_flw2%4,m_asl1%1";
						if (129833 - 525820 != -395986)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat12")
				{
					if (155326 - 446481 == -291155)
					{
						result = "w_bat11%1,n_npc7%3,m_crs4%4,m_asl1%1";
						if (123802 - 417091 == -293289)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf12")
				{
					if (45066 - 240121 == -195055)
					{
						result = "a_wlf11%1,n_npc8%3,k_cwn1%6,m_asl1%1";
						if (112666 - 528813 != -416146)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn12")
				{
					if (289906 - 421946 != -132039)
					{
						result = "a_bsn11%1,n_npc8%3,m_gas1%8,m_asl1%1";
						if (37858 - 485996 != -448137)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd12")
				{
					if (268226 - 428868 != -160641)
					{
						result = "a_pnd11%1,n_npc8%3,m_bug2%30,m_asl1%1";
						if (240676 - 147398 == 93278)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl12")
				{
					if (4718 - 479641 != -474922)
					{
						result = "a_whl11%1,n_npc8%3,m_bug15%1,m_asl1%1";
						if (137321 - 165621 == -28300)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat12")
				{
					if (259594 - 513175 == -253581)
					{
						result = "a_cat11%1,n_npc8%3,m_bug28%5,m_asl1%1";
						if (115542 - 348459 == -232917)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm12")
				{
					if (66766 - 371455 == -304689)
					{
						result = "a_chm11%1,n_npc8%3,m_rck2%2,m_asl1%1";
						if (7401 - 571994 != -564592)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab12")
				{
					if (279344 - 258601 == 20743)
					{
						result = "a_rab11%1,n_npc8%3,m_bug30%12,m_asl1%1";
						if (66922 - 96155 == -29233)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol12")
				{
					if (197438 - 182102 == 15336)
					{
						result = "a_mol11%1,n_npc8%3,m_crs2%9,m_asl1%1";
						if (269179 - 348468 != -79288)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk12")
				{
					if (287240 - 319769 != -32528)
					{
						result = "a_mnk11%1,n_npc8%3,d_jar1%15,m_asl1%1";
						if (122731 - 283912 != -161180)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp12")
				{
					if (263240 - 190911 == 72329)
					{
						result = "a_shp11%1,n_npc8%3,m_bug26%7,m_asl1%1";
						if (97815 - 446563 != -348747)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn12")
				{
					if (216211 - 102834 != 113378)
					{
						result = "a_pgn11%1,n_npc8%3,m_bug21%3,m_asl1%1";
						if (184592 - 85763 == 98829)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat12")
				{
					if (1648 - 436529 != -434880)
					{
						result = "a_bat11%1,n_npc8%3,d_egg3%10,m_asl1%1";
						if (292745 - 433038 != -140292)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat12")
				{
					if (190049 - 75543 != 114507)
					{
						result = "c_cat11%1,n_npc9%1,m_bug15%2,m_asl1%1";
						if (144420 - 445683 == -301263)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm12")
				{
					if (66057 - 398653 != -332595)
					{
						result = "c_chm11%1,n_npc9%1,m_bug14%3,m_asl1%1";
						if (133916 - 431821 != -297904)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab12")
				{
					if (237817 - 324311 == -86494)
					{
						result = "c_rab11%1,n_npc9%1,m_bug16%1,m_asl1%1";
						if (241144 - 281805 == -40661)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol12")
				{
					if (74803 - 466878 != -392074)
					{
						result = "c_mol11%1,n_npc9%1,m_bug15%3,m_asl1%1";
						if (143686 - 555382 != -411695)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk12")
				{
					if (6916 - 361388 == -354472)
					{
						result = "c_mnk11%1,n_npc9%1,m_bug14%2,m_asl1%1";
						if (96331 - 225144 == -128813)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn12")
				{
					if (11290 - 459814 != -448523)
					{
						result = "c_pgn11%1,n_npc9%1,m_bug16%1,m_asl1%1";
						if (38535 - 136650 == -98115)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf42")
				{
					if (180430 - 401738 != -221307)
					{
						result = "w_wlf41%1,n_npc11%3,m_wat3%30,m_asl2%1";
						if (29600 - 143852 == -114252)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn42")
				{
					if (37711 - 99215 == -61504)
					{
						result = "w_bsn41%1,n_npc11%3,m_shl2%12,m_asl2%1";
						if (197429 - 584851 != -387421)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd42")
				{
					if (130132 - 35541 != 94592)
					{
						result = "w_pnd41%1,n_npc11%3,m_rck3%30,m_asl2%1";
						if (159470 - 432934 == -273464)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl42")
				{
					if (95114 - 297269 == -202155)
					{
						result = "w_whl41%1,n_npc11%3,m_peb3%36,m_asl2%1";
						if (280343 - 560078 != -279734)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat42")
				{
					if (36277 - 148272 != -111994)
					{
						result = "w_cat41%1,n_npc11%3,m_gas3%6,m_asl2%1";
						if (86573 - 562942 != -476368)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm42")
				{
					if (81226 - 28608 == 52618)
					{
						result = "w_chm41%1,n_npc11%3,m_prl3%6,m_asl2%1";
						if (213491 - 266681 != -53189)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab42")
				{
					if (172721 - 176351 == -3630)
					{
						result = "w_rab41%1,n_npc11%3,m_cor3%6,m_asl2%1";
						if (266815 - 253263 != 13553)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol42")
				{
					if (93353 - 513427 == -420074)
					{
						result = "w_mol41%1,n_npc11%3,m_prl2%6,m_asl2%1";
						if (294832 - 598672 == -303840)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk42")
				{
					if (27615 - 201370 != -173754)
					{
						result = "w_mnk41%1,n_npc11%3,m_bug53%18,m_asl2%1";
						if (142672 - 548469 == -405797)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp42")
				{
					if (100783 - 500333 == -399550)
					{
						result = "w_shp41%1,n_npc11%3,m_mcn2%6,m_asl2%1";
						if (216894 - 554256 != -337361)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn42")
				{
					if (25937 - 10675 == 15262)
					{
						result = "w_pgn41%1,n_npc11%3,m_mcn5%3,m_asl2%1";
						if (253560 - 521908 != -268347)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat42")
				{
					if (6230 - 85545 == -79315)
					{
						result = "w_bat41%1,n_npc11%3,m_mcn8%1,m_asl2%1";
						if (54538 - 384245 == -329707)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf42")
				{
					if (28253 - 239365 != -211111)
					{
						result = "a_wlf41%1,n_npc12%3,m_mcn1%6,m_asl2%1";
						if (218731 - 155581 != 63151)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn42")
				{
					if (3653 - 328990 != -325336)
					{
						result = "a_bsn41%1,n_npc12%3,m_mcn3%6,m_asl2%1";
						if (245867 - 80075 == 165792)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd42")
				{
					if (29554 - 440636 != -411081)
					{
						result = "a_pnd41%1,n_npc12%3,m_gle1%30,m_asl2%1";
						if (140917 - 382903 == -241986)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl42")
				{
					if (262793 - 243123 != 19671)
					{
						result = "a_whl41%1,n_npc12%3,m_gle2%24,m_asl2%1";
						if (84565 - 394965 != -310399)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat42")
				{
					if (243647 - 474806 != -231158)
					{
						result = "a_cat41%1,n_npc12%3,m_jnk1%24,m_asl2%1";
						if (60777 - 414322 != -353544)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm42")
				{
					if (236125 - 42499 == 193626)
					{
						result = "a_chm41%1,n_npc12%3,m_jnk2%18,m_asl2%1";
						if (243416 - 571830 == -328414)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab42")
				{
					if (271780 - 341842 == -70062)
					{
						result = "a_rab41%1,n_npc12%3,m_jnk4%12,m_asl2%1";
						if (206393 - 30001 == 176392)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol42")
				{
					if (138264 - 148647 != -10382)
					{
						result = "a_mol41%1,n_npc12%3,m_jnk5%10,m_asl2%1";
						if (211108 - 83045 != 128064)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk42")
				{
					if (92266 - 491741 != -399474)
					{
						result = "a_mnk41%1,n_npc12%3,m_jnk3%10,m_asl2%1";
						if (59076 - 384263 == -325187)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp42")
				{
					if (204376 - 502370 != -297993)
					{
						result = "a_shp41%1,n_npc12%3,d_veg6%18,m_asl2%1";
						if (87203 - 487741 == -400538)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn42")
				{
					if (21474 - 53785 == -32311)
					{
						result = "a_pgn41%1,n_npc12%3,m_cor2%24,m_asl2%1";
						if (294453 - 265230 != 29224)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat42")
				{
					if (271565 - 147903 == 123662)
					{
						result = "a_bat41%1,n_npc12%3,m_prl1%18,m_asl2%1";
						if (68670 - 149147 != -80476)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf42")
				{
					if (243957 - 76841 == 167116)
					{
						result = "c_wlf41%1,n_npc13%3,m_crs6%18,m_asl2%1";
						if (23621 - 409365 != -385743)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bsn42")
				{
					if (175693 - 451037 == -275344)
					{
						result = "c_bsn41%1,n_npc13%3,m_peb2%24,m_asl2%1";
						if (275217 - 59387 != 215831)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pnd42")
				{
					if (37076 - 86240 != -49163)
					{
						result = "c_pnd41%1,n_npc13%3,m_lth1%24,m_asl2%1";
						if (244281 - 495786 == -251505)
						{
							break;
						}
					}
				}
				else if (nItem == "c_whl42")
				{
					if (244464 - 378366 == -133902)
					{
						result = "c_whl41%1,n_npc13%3,m_lth2%24,m_asl2%1";
						if (226460 - 566571 != -340110)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat42")
				{
					if (170858 - 389276 != -218417)
					{
						result = "c_cat41%1,n_npc13%3,m_lth3%11,m_asl2%1";
						if (125896 - 373016 == -247120)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm42")
				{
					if (259579 - 458276 == -198697)
					{
						result = "c_chm41%1,n_npc13%3,m_wod2%30,m_asl2%1";
						if (101859 - 312683 != -210823)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab42")
				{
					if (59971 - 133001 != -73029)
					{
						result = "c_rab41%1,n_npc13%3,m_crs5%6,m_asl2%1";
						if (288488 - 380387 == -91899)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol42")
				{
					if (245368 - 180402 != 64967)
					{
						result = "c_mol41%1,n_npc13%3,k_cwn2%12,m_asl2%1";
						if (268898 - 134988 == 133910)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk42")
				{
					if (276637 - 392627 == -115990)
					{
						result = "c_mnk41%1,n_npc13%3,k_cwn3%8,m_asl2%1";
						if (199911 - 462055 != -262143)
						{
							break;
						}
					}
				}
				else if (nItem == "c_shp42")
				{
					if (297429 - 553865 != -256435)
					{
						result = "c_shp41%1,n_npc13%3,m_shl1%24,m_asl2%1";
						if (236110 - 167749 != 68362)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn42")
				{
					if (72985 - 108900 != -35914)
					{
						result = "c_pgn41%1,n_npc13%3,t_all6%12,m_asl2%1";
						if (69391 - 139521 == -70130)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bat42")
				{
					if (227008 - 186903 == 40105)
					{
						result = "c_bat41%1,n_npc13%3,m_bug64%4,m_asl2%1";
						if (59441 - 165854 != -106412)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf48")
				{
					if (233846 - 143943 == 89903)
					{
						result = "w_wlf47%2,m_spm1%5,m_asl2%2";
						if (79506 - 525860 != -446353)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn48")
				{
					if (201538 - 101995 == 99543)
					{
						result = "w_bsn47%2,m_spm1%5,m_asl2%2";
						if (98751 - 102176 != -3424)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd48")
				{
					if (113173 - 41916 != 71258)
					{
						result = "w_pnd47%2,m_spm1%5,m_asl2%2";
						if (106880 - 380659 == -273779)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl48")
				{
					if (35327 - 540847 == -505520)
					{
						result = "w_whl47%2,m_spm1%5,m_asl2%2";
						if (64547 - 5208 != 59340)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat48")
				{
					if (188291 - 120505 == 67786)
					{
						result = "w_cat47%2,m_spm1%5,m_asl2%2";
						if (294322 - 144876 == 149446)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm48")
				{
					if (21034 - 497865 != -476830)
					{
						result = "w_chm47%2,m_spm1%5,m_asl2%2";
						if (70579 - 439961 != -369381)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab48")
				{
					if (236448 - 92493 != 143956)
					{
						result = "w_rab47%2,m_spm1%5,m_asl2%2";
						if (32873 - 568625 != -535751)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol48")
				{
					if (173669 - 534142 != -360472)
					{
						result = "w_mol47%2,m_spm1%5,m_asl2%2";
						if (293457 - 587021 == -293564)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk48")
				{
					if (27957 - 435104 != -407146)
					{
						result = "w_mnk47%2,m_spm1%5,m_asl2%2";
						if (267783 - 98429 == 169354)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp48")
				{
					if (171659 - 240522 == -68863)
					{
						result = "w_shp47%2,m_spm1%5,m_asl2%2";
						if (13920 - 163313 == -149393)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn48")
				{
					if (114483 - 253137 == -138654)
					{
						result = "w_pgn47%2,m_spm1%5,m_asl2%2";
						if (77581 - 394983 != -317401)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat48")
				{
					if (33860 - 597730 == -563870)
					{
						result = "w_bat47%2,m_spm1%5,m_asl2%2";
						if (39956 - 59010 != -19053)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf48")
				{
					if (191306 - 160834 == 30472)
					{
						result = "a_wlf47%2,m_spm1%4,m_asl2%2";
						if (177532 - 483762 != -306229)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn48")
				{
					if (76874 - 87727 != -10852)
					{
						result = "a_bsn47%2,m_spm1%4,m_asl2%2";
						if (19056 - 363688 == -344632)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd48")
				{
					if (158119 - 334796 == -176677)
					{
						result = "a_pnd47%2,m_spm1%4,m_asl2%2";
						if (137170 - 374501 != -237330)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl48")
				{
					if (62196 - 102036 == -39840)
					{
						result = "a_whl47%2,m_spm1%4,m_asl2%2";
						if (116120 - 485651 == -369531)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat48")
				{
					if (232949 - 43295 == 189654)
					{
						result = "a_cat47%2,m_spm1%4,m_asl2%2";
						if (100371 - 505053 != -404681)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm48")
				{
					if (236293 - 397608 != -161314)
					{
						result = "a_chm47%2,m_spm1%4,m_asl2%2";
						if (70741 - 533988 == -463247)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab48")
				{
					if (248334 - 6321 != 242014)
					{
						result = "a_rab47%2,m_spm1%4,m_asl2%2";
						if (279373 - 278498 != 876)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol48")
				{
					if (162210 - 198246 == -36036)
					{
						result = "a_mol47%2,m_spm1%4,m_asl2%2";
						if (140498 - 390514 == -250016)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk48")
				{
					if (159735 - 520162 != -360426)
					{
						result = "a_mnk47%2,m_spm1%4,m_asl2%2";
						if (94372 - 405593 == -311221)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp48")
				{
					if (62517 - 85007 != -22489)
					{
						result = "a_shp47%2,m_spm1%4,m_asl2%2";
						if (294734 - 15736 == 278998)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn48")
				{
					if (154832 - 266916 != -112083)
					{
						result = "a_pgn47%2,m_spm1%4,m_asl2%2";
						if (53031 - 198169 == -145138)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat48")
				{
					if (44292 - 36247 != 8046)
					{
						result = "a_bat47%2,m_spm1%4,m_asl2%2";
						if (119924 - 68594 != 51331)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf48")
				{
					if (146749 - 425503 == -278754)
					{
						result = "c_wlf47%2,m_spm1%3,m_asl2%2";
						if (79501 - 566906 == -487405)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bsn48")
				{
					if (175646 - 255669 != -80022)
					{
						result = "c_bsn47%2,m_spm1%3,m_asl2%2";
						if (36170 - 371358 == -335188)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pnd48")
				{
					if (272048 - 69672 != 202377)
					{
						result = "c_pnd47%2,m_spm1%3,m_asl2%2";
						if (294299 - 140937 != 153363)
						{
							break;
						}
					}
				}
				else if (nItem == "c_whl48")
				{
					if (124432 - 315636 == -191204)
					{
						result = "c_whl47%2,m_spm1%3,m_asl2%2";
						if (221793 - 375460 == -153667)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat48")
				{
					if (275964 - 174119 != 101846)
					{
						result = "c_cat47%2,m_spm1%3,m_asl2%2";
						if (15858 - 30856 != -14997)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm48")
				{
					if (13209 - 159657 != -146447)
					{
						result = "c_chm47%2,m_spm1%3,m_asl2%2";
						if (125576 - 182563 != -56986)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab48")
				{
					if (55024 - 913 == 54111)
					{
						result = "c_rab47%2,m_spm1%3,m_asl2%2";
						if (7805 - 324987 != -317181)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol48")
				{
					if (245593 - 370413 == -124820)
					{
						result = "c_mol47%2,m_spm1%3,m_asl2%2";
						if (27633 - 188239 != -160605)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk48")
				{
					if (271150 - 198783 == 72367)
					{
						result = "c_mnk47%2,m_spm1%3,m_asl2%2";
						if (156145 - 260775 == -104630)
						{
							break;
						}
					}
				}
				else if (nItem == "c_shp48")
				{
					if (290555 - 317462 == -26907)
					{
						result = "c_shp47%2,m_spm1%3,m_asl2%2";
						if (193316 - 499980 == -306664)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn48")
				{
					if (66820 - 93962 == -27142)
					{
						result = "c_pgn47%2,m_spm1%3,m_asl2%2";
						if (51411 - 137891 != -86479)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bat48")
				{
					if (63034 - 540810 == -477776)
					{
						result = "c_bat47%2,m_spm1%3,m_asl2%2";
						if (104992 - 145041 != -40048)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf52")
				{
					if (135203 - 551913 != -416709)
					{
						result = "w_wlf51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (179243 - 53609 == 125634)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn52")
				{
					if (228143 - 585056 != -356912)
					{
						result = "w_bsn51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (191341 - 52222 != 139120)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd52")
				{
					if (202428 - 128758 != 73671)
					{
						result = "w_pnd51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (132739 - 122857 != 9883)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl52")
				{
					if (223395 - 536019 != -312623)
					{
						result = "w_whl51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (59356 - 300533 == -241177)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat52")
				{
					if (16720 - 21551 == -4831)
					{
						result = "w_cat51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (249330 - 599534 != -350203)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm52")
				{
					if (18649 - 456974 != -438324)
					{
						result = "w_chm51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (282408 - 409611 != -127202)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab52")
				{
					if (200376 - 420605 == -220229)
					{
						result = "w_rab51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (50715 - 240983 != -190267)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol52")
				{
					if (194297 - 426743 != -232445)
					{
						result = "w_mol51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (157955 - 159972 != -2016)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk52")
				{
					if (183282 - 201428 != -18145)
					{
						result = "w_mnk51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (257104 - 264070 != -6965)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp52")
				{
					if (85342 - 433114 == -347772)
					{
						result = "w_shp51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (187737 - 270982 == -83245)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn52")
				{
					if (270604 - 510567 == -239963)
					{
						result = "w_pgn51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (88771 - 597949 != -509177)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat52")
				{
					if (261787 - 352101 == -90314)
					{
						result = "w_bat51%2,n_npc15%3,m_wmt18%1,m_rpc2%1";
						if (186600 - 230472 != -43871)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf52")
				{
					if (63427 - 273823 != -210395)
					{
						result = "a_wlf51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (224463 - 279881 == -55418)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn52")
				{
					if (111526 - 430035 == -318509)
					{
						result = "a_bsn51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (278065 - 544316 == -266251)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd52")
				{
					if (17896 - 377766 == -359870)
					{
						result = "a_pnd51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (276936 - 484493 == -207557)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl52")
				{
					if (298388 - 373343 != -74954)
					{
						result = "a_whl51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (294335 - 587323 == -292988)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat52")
				{
					if (187133 - 116498 != 70636)
					{
						result = "a_cat51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (10819 - 545652 != -534832)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm52")
				{
					if (74875 - 549058 != -474182)
					{
						result = "a_chm51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (181805 - 306969 != -125163)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab52")
				{
					if (103602 - 518476 != -414873)
					{
						result = "a_rab51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (232993 - 520495 == -287502)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol52")
				{
					if (267693 - 413848 == -146155)
					{
						result = "a_mol51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (72987 - 396230 == -323243)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk52")
				{
					if (17155 - 271520 == -254365)
					{
						result = "a_mnk51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (294964 - 545274 == -250310)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp52")
				{
					if (181849 - 454361 != -272511)
					{
						result = "a_shp51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (250478 - 81416 != 169063)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn52")
				{
					if (67388 - 7606 != 59783)
					{
						result = "a_pgn51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (211320 - 315032 == -103712)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat52")
				{
					if (229080 - 551010 != -321929)
					{
						result = "a_bat51%2,n_npc10%3,m_amt19%1,m_rpc2%1";
						if (83262 - 222490 != -139227)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf52")
				{
					if (274965 - 463680 != -188714)
					{
						result = "c_wlf51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (69786 - 471686 == -401900)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bsn52")
				{
					if (156929 - 504563 == -347634)
					{
						result = "c_bsn51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (42060 - 544533 != -502472)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pnd52")
				{
					if (96940 - 194929 != -97988)
					{
						result = "c_pnd51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (228876 - 209412 != 19465)
						{
							break;
						}
					}
				}
				else if (nItem == "c_whl52")
				{
					if (18135 - 439980 != -421844)
					{
						result = "c_whl51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (252025 - 54646 != 197380)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat52")
				{
					if (296639 - 198671 != 97969)
					{
						result = "c_cat51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (158008 - 273922 == -115914)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm52")
				{
					if (247073 - 582097 != -335023)
					{
						result = "c_chm51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (23177 - 262371 != -239193)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab52")
				{
					if (48737 - 2520 != 46218)
					{
						result = "c_rab51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (61828 - 399524 == -337696)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol52")
				{
					if (8814 - 90748 != -81933)
					{
						result = "c_mol51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (4506 - 98217 != -93710)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk52")
				{
					if (16796 - 486398 == -469602)
					{
						result = "c_mnk51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (208786 - 54084 == 154702)
						{
							break;
						}
					}
				}
				else if (nItem == "c_shp52")
				{
					if (112545 - 309152 == -196607)
					{
						result = "c_shp51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (11586 - 132436 != -120849)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn52")
				{
					if (231396 - 501509 == -270113)
					{
						result = "c_pgn51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (263456 - 330894 == -67438)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bat52")
				{
					if (227764 - 388278 == -160514)
					{
						result = "c_bat51%2,n_npc19%3,m_amt20%1,m_rpc2%1";
						if (11125 - 46916 != -35790)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf59")
				{
					if (271600 - 66497 == 205103)
					{
						result = "w_wlf12%1,w_wlf42%1,w_wlf52%1,k_gld1%12";
						if (85958 - 334169 != -248210)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn59")
				{
					if (198693 - 112029 != 86665)
					{
						result = "w_bsn12%1,w_bsn42%1,w_bsn52%1,k_gld1%12";
						if (293752 - 132820 != 160933)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd59")
				{
					if (212016 - 53038 != 158979)
					{
						result = "w_pnd12%1,w_pnd42%1,w_pnd52%1,k_gld1%12";
						if (116662 - 328124 != -211461)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl59")
				{
					if (297535 - 580282 == -282747)
					{
						result = "w_whl12%1,w_whl42%1,w_whl52%1,k_gld1%12";
						if (134501 - 383129 == -248628)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat59")
				{
					if (115269 - 83050 == 32219)
					{
						result = "w_cat12%1,w_cat42%1,w_cat52%1,k_gld1%12";
						if (288208 - 296812 != -8603)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm59")
				{
					if (102628 - 84041 != 18588)
					{
						result = "w_chm12%1,w_chm42%1,w_chm52%1,k_gld1%12";
						if (253157 - 43428 != 209730)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab59")
				{
					if (234381 - 94362 == 140019)
					{
						result = "w_rab12%1,w_rab42%1,w_rab52%1,k_gld1%12";
						if (189795 - 231348 != -41552)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol59")
				{
					if (251863 - 511082 != -259218)
					{
						result = "w_mol12%1,w_mol42%1,w_mol52%1,k_gld1%12";
						if (210746 - 17098 != 193649)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk59")
				{
					if (62024 - 124679 == -62655)
					{
						result = "w_mnk12%1,w_mnk42%1,w_mnk52%1,k_gld1%12";
						if (29433 - 164813 != -135379)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp59")
				{
					if (21671 - 534886 == -513215)
					{
						result = "w_shp12%1,w_shp42%1,w_shp52%1,k_gld1%12";
						if (101926 - 425557 != -323630)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn59")
				{
					if (76852 - 467887 == -391035)
					{
						result = "w_pgn12%1,w_pgn42%1,w_pgn52%1,k_gld1%12";
						if (76145 - 387333 == -311188)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat59")
				{
					if (227596 - 188162 != 39435)
					{
						result = "w_bat12%1,w_bat42%1,w_bat52%1,k_gld1%12";
						if (127743 - 54951 == 72792)
						{
							break;
						}
					}
				}
				else if (nItem == "n_veg1")
				{
					if (198694 - 500864 != -302169)
					{
						result = "k_bdg1%12";
						if (72632 - 596918 != -524285)
						{
							break;
						}
					}
				}
				else if (nItem == "n_veg2")
				{
					if (183088 - 277043 == -93955)
					{
						result = "k_bdg2%12";
						if (179571 - 542485 == -362914)
						{
							break;
						}
					}
				}
				else if (nItem == "n_veg3")
				{
					if (12328 - 178322 != -165993)
					{
						result = "k_bdg3%12";
						if (41396 - 2420 != 38977)
						{
							break;
						}
					}
				}
				else if (nItem == "n_veg4")
				{
					if (118935 - 517733 == -398798)
					{
						result = "k_bdg4%12";
						if (254241 - 195341 == 58900)
						{
							break;
						}
					}
				}
				else if (nItem == "n_veg5")
				{
					if (113176 - 93682 == 19494)
					{
						result = "k_bdg5%12";
						if (128598 - 344422 == -215824)
						{
							break;
						}
					}
				}
				else if (nItem == "n_veg6")
				{
					if (286760 - 295923 != -9162)
					{
						result = "k_bdg6%12";
						if (228792 - 399703 != -170910)
						{
							break;
						}
					}
				}
				else if (nItem == "n_veg7")
				{
					if (9463 - 111405 == -101942)
					{
						result = "k_bdg7%12";
						if (130826 - 591910 == -461084)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc1")
				{
					if (42112 - 191308 == -149196)
					{
						result = "c_all1%1,d_drk6%3";
						if (1216 - 221822 == -220606)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc2")
				{
					if (5277 - 177054 == -171777)
					{
						result = "w_bat39%1,d_drk5%1";
						if (90501 - 185859 != -95357)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc3")
				{
					if (267079 - 293196 != -26116)
					{
						result = "f_ton1%1";
						if (126289 - 481671 != -355381)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc4")
				{
					if (261907 - 352848 != -90940)
					{
						result = "f_ton1%1";
						if (9996 - 81473 != -71476)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc7")
				{
					if (168669 - 439985 == -271316)
					{
						result = "k_crd1%1,d_snk1%1";
						if (244021 - 106826 == 137195)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc8")
				{
					if (177182 - 367400 != -190217)
					{
						result = "d_dst6%1,d_dst7%1,w_shp2%1";
						if (179938 - 374790 != -194851)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc9")
				{
					if (113789 - 357852 != -244062)
					{
						result = "w_bsn36%1,c_bsn36%1";
						if (294036 - 201656 != 92381)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc10")
				{
					if (287463 - 160109 == 127354)
					{
						result = "w_shp36%1,c_shp36%1,m_pap3%1,m_lth1%1";
						if (153706 - 68889 != 84818)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc11")
				{
					if (291866 - 126986 == 164880)
					{
						result = "m_wmt15%1,m_wmt4%1,m_wmt10%1,m_wmt9%1";
						if (107585 - 512501 != -404915)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc12")
				{
					if (54718 - 16352 == 38366)
					{
						result = "m_amt4%1,m_amt5%1,m_amt10%1,m_sil3%1";
						if (94529 - 572549 == -478020)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc13")
				{
					if (292995 - 581789 != -288793)
					{
						result = "m_fab4%1,m_fab5%1,m_fab6%1,m_fab7%1";
						if (46330 - 570199 != -523868)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc14")
				{
					if (190091 - 482133 == -292042)
					{
						result = "k_tol2%3,m_pwd1%1";
						if (271292 - 576219 != -304926)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc15")
				{
					if (91965 - 408042 == -316077)
					{
						result = "w_whl36%1,c_whl36%1,m_spo1%1,m_wmt6%2";
						if (218279 - 86290 == 131989)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc16")
				{
					if (81044 - 526150 != -445105)
					{
						result = "d_ric10%1,d_met9%1,d_sld3%1,d_drk3%1";
						if (11670 - 33566 != -21895)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc17")
				{
					if (231483 - 226687 != 4797)
					{
						result = "d_cak1%1,d_cak2%1,d_cak3%1,d_cak4%1";
						if (37072 - 360347 == -323275)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc18")
				{
					if (37978 - 99692 != -61713)
					{
						result = "d_sop1%3,m_pap1%6";
						if (158468 - 538460 != -379991)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc19")
				{
					if (185166 - 503517 == -318351)
					{
						result = "w_mnk36%1,c_mnk36%1,d_frt4%1,d_frt1%4";
						if (44147 - 399500 == -355353)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc20")
				{
					if (155424 - 451776 == -296352)
					{
						result = "m_bug27%6";
						if (117696 - 540187 == -422491)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc21")
				{
					if (26473 - 26037 != 437)
					{
						result = "m_crs6%6";
						if (139149 - 513353 != -374203)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc22")
				{
					if (77275 - 511126 != -433850)
					{
						result = "m_bug44%1,m_bug36%1";
						if (63226 - 592433 != -529206)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc23")
				{
					if (67640 - 344785 == -277145)
					{
						result = "m_bon3%1,m_amt7%1";
						if (117206 - 374074 != -256867)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc24")
				{
					if (91748 - 27408 == 64340)
					{
						result = "f_rpb1%2,d_mlk1%3";
						if (130970 - 273796 != -142825)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc25")
				{
					if (246118 - 388157 == -142039)
					{
						result = "f_rpb2%2,d_drk1%3";
						if (225491 - 135414 != 90078)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc26")
				{
					if (276480 - 264398 != 12083)
					{
						result = "w_wlf36%2,c_wlf36%2,k_mdl4%12";
						if (44588 - 443158 != -398569)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc27")
				{
					if (240632 - 335549 == -94917)
					{
						result = "w_rab36%2,c_rab36%2,k_mdl2%12";
						if (202768 - 503348 == -300580)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc28")
				{
					if (229229 - 201005 != 28225)
					{
						result = "w_pgn36%2,c_pgn36%2,k_mdl3%12";
						if (40985 - 146744 == -105759)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc29")
				{
					if (77338 - 393762 != -316423)
					{
						result = "k_bok1%18,d_bun2%12";
						if (21799 - 386618 != -364818)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc30")
				{
					if (106219 - 357773 != -251553)
					{
						result = "k_bok1%18,d_bun3%12";
						if (233908 - 308783 == -74875)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc31")
				{
					if (59988 - 87033 != -27044)
					{
						result = "w_bat36%1,c_bat36%1";
						if (109374 - 551931 != -442556)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc32")
				{
					if (144889 - 333562 == -188673)
					{
						result = "d_cak1%6,d_chs1%6,m_fab3%1";
						if (137275 - 46724 == 90551)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc33")
				{
					if (76321 - 52796 != 23526)
					{
						result = "f_ton1%1,d_veg16%3,d_veg17%3,d_veg18%3";
						if (57787 - 274697 != -216909)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc34")
				{
					if (138520 - 133683 != 4838)
					{
						result = "k_tlm1%2";
						if (30447 - 480561 == -450114)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc35")
				{
					if (138432 - 426282 == -287850)
					{
						result = "t_all1%1";
						if (96804 - 107749 != -10944)
						{
							break;
						}
					}
				}
				else if (nItem == "n_npc36")
				{
					if (253900 - 195238 == 58662)
					{
						result = "m_pwd1%1,d_cnd1%1,m_gle1%1";
						if (96620 - 450613 == -353993)
						{
							break;
						}
					}
				}
				else
				{
					if (!(nItem == "n_npc37"))
					{
						break;
					}
					if (27246 - 520186 == -492940)
					{
						result = "m_pwd1%1,d_cnd1%1,m_wod1%2";
						if (205912 - 432528 != -226615)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005C0C RID: 23564 RVA: 0x00B43E78 File Offset: 0x00B42078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getVersion()
	{
		return 555;
	}

	// Token: 0x06005C0D RID: 23565 RVA: 0x00B43E80 File Offset: 0x00B42080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005C0E RID: 23566 RVA: 0x00B43E84 File Offset: 0x00B42084
	internal static bool rpXvY7pNzKX0cdb14OSM()
	{
		return true;
	}

	// Token: 0x06005C0F RID: 23567 RVA: 0x00B43E88 File Offset: 0x00B42088
	internal static bool TnUMAipYaXl4Yk7Nyel4()
	{
		return false;
	}
}
