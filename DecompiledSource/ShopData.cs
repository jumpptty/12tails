using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000FDE RID: 4062
[Serializable]
public class ShopData : MonoBehaviour
{
	// Token: 0x06005D00 RID: 23808 RVA: 0x00C22AEC File Offset: 0x00C20CEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShopData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005D01 RID: 23809 RVA: 0x00C22AFC File Offset: 0x00C20CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getOwl1List(int nRank)
	{
		if (143343 - 390137 != -246793)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_7E2:
			if (nRank == 100)
			{
				if (88196 - 449026 == -360829)
				{
					continue;
				}
				if (Game.server >= 3)
				{
					goto IL_89B;
				}
				if (256978 - 314674 != -57696)
				{
					continue;
				}
			}
			string[] array = new string[]
			{
				"f_hlb1",
				"f_hlb2",
				"f_hlb3",
				"t_all66",
				"t_all67",
				"p_sdm1",
				"p_sdv1",
				"f_rss1",
				"f_rsk1",
				"f_rfl4",
				"f_rfl3",
				"f_rfl2",
				"f_rfl1",
				"f_box1",
				"f_key5",
				"f_key4",
				"f_key3",
				"f_key2",
				"f_key1",
				"b_all50",
				"b_all51",
				"b_all40",
				"b_all41",
				"b_all30",
				"b_all31",
				"b_all20",
				"b_all21",
				"b_all10",
				"o_all1",
				"o_all2",
				"c_wlf65",
				"a_wlf65",
				"c_bsn65",
				"a_bsn65",
				"c_pnd65",
				"a_pnd65",
				"c_whl65",
				"a_whl65",
				"c_cat65",
				"a_cat65",
				"c_chm65",
				"a_chm65",
				"c_rab65",
				"a_rab65",
				"c_mol65",
				"a_mol65",
				"c_mnk65",
				"a_mnk65",
				"c_pgn65",
				"a_pgn65",
				"c_shp65",
				"a_shp65",
				"c_bat65",
				"a_bat65",
				"c_wlf45",
				"a_wlf45",
				"c_bsn45",
				"a_bsn45",
				"c_pnd45",
				"a_pnd45",
				"c_whl45",
				"a_whl45",
				"c_cat45",
				"a_cat45",
				"c_chm45",
				"a_chm45",
				"c_rab45",
				"a_rab45",
				"c_mol45",
				"a_mol45",
				"c_mnk45",
				"a_mnk45",
				"c_pgn45",
				"a_pgn45",
				"c_shp45",
				"a_shp45",
				"c_bat45",
				"a_bat45",
				"c_wlf25",
				"a_wlf25",
				"c_bsn25",
				"a_bsn25",
				"c_pnd25",
				"a_pnd25",
				"c_whl25",
				"a_whl25",
				"c_cat25",
				"a_cat25",
				"c_chm25",
				"a_chm25",
				"c_rab25",
				"a_rab25",
				"c_mol25",
				"a_mol25",
				"c_mnk25",
				"a_mnk25",
				"c_pgn25",
				"a_pgn25",
				"c_shp25",
				"a_shp25",
				"c_bat25",
				"a_bat25",
				"a_wlf5",
				"c_wlf5",
				"a_bsn5",
				"c_bsn5",
				"a_pnd5",
				"c_pnd5",
				"a_whl5",
				"c_whl5",
				"a_cat5",
				"c_cat5",
				"a_chm5",
				"c_chm5",
				"a_rab5",
				"c_rab5",
				"a_mol5",
				"c_mol5",
				"a_mnk5",
				"c_mnk5",
				"a_pgn5",
				"c_pgn5",
				"a_shp5",
				"c_shp5",
				"a_bat5",
				"c_bat5",
				"c_all23",
				"c_all24",
				"c_all18",
				"c_all19",
				"c_all11",
				"c_all12",
				"t_all8",
				"t_pnd5",
				"t_cat5",
				"t_fem2",
				"t_all2",
				"t_all1"
			};
			if (66661 - 407526 == -340865)
			{
				array2 = new UnityScript.Lang.Array();
				if (74884 - 48369 != 26516)
				{
					int i = 0;
					if (14992 - 15072 == -80)
					{
						string[] array3 = array;
						if (123954 - 142946 != -18991)
						{
							int length = array3.Length;
							if (128548 - 125012 != 3537)
							{
								while (i < length)
								{
									if (PlayerPrefs.GetInt("usableItem", 1) != 0)
									{
										if (126740 - 336533 != -209793)
										{
											goto IL_7E2;
										}
										string a = array3[i].Trim().Substring(0, 1);
										if (114106 - 137381 != -23274)
										{
											if (a == "w")
											{
												if (81163 - 496509 != -415345)
												{
													goto IL_210;
												}
												goto IL_7E2;
											}
											else if (a == "a")
											{
												if (229175 - 346931 != -117755)
												{
													goto IL_210;
												}
												goto IL_7E2;
											}
											else if (a == "c")
											{
												if (87835 - 18959 != 68876)
												{
													goto IL_7E2;
												}
												goto IL_D7;
											}
											else if (a == "b")
											{
												if (293880 - 112420 != 181460)
												{
													goto IL_7E2;
												}
												goto IL_804;
											}
											else if (a == "t")
											{
												if (20298 - 493692 != -473394)
												{
													goto IL_7E2;
												}
												goto IL_833;
											}
											else if (Mathf.Abs(ItemData.getLv(array3[i])) <= nRank + 10)
											{
												if (49881 - 247153 == -197271)
												{
													goto IL_7E2;
												}
												array2.Add(array3[i]);
												if (276460 - 168258 == 108203)
												{
													goto IL_7E2;
												}
											}
											IL_130:
											goto IL_23F;
											IL_833:
											if (CharacterData.current.canEquip(array3[i]))
											{
												if (179186 - 61294 == 117893)
												{
													goto IL_7E2;
												}
												if (Mathf.Abs(ItemData.getLv(array3[i])) <= nRank + 10)
												{
													if (7808 - 375188 != -367380)
													{
														goto IL_7E2;
													}
													array2.Add(array3[i]);
													if (119699 - 105509 != 14190)
													{
														goto IL_7E2;
													}
												}
											}
											goto IL_130;
											IL_804:
											goto IL_833;
											IL_D7:
											goto IL_804;
											IL_210:
											goto IL_D7;
										}
										goto IL_7E2;
									}
									else
									{
										array2.Add(array3[i]);
										if (298616 - 212250 != 86366)
										{
											goto IL_7E2;
										}
									}
									IL_23F:
									i++;
									if (49808 - 212232 == -162423)
									{
										goto IL_7E2;
									}
								}
								if (78746 - 261628 != -182881)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return array2.ToBuiltin(typeof(string));
		IL_89B:
		string[] array4 = new string[631];
		array4[0] = "c_all55";
		array4[1] = "t_all55";
		array4[2] = "t_all56";
		array4[3] = "t_all57";
		array4[4] = "t_all58";
		array4[5] = "t_all59";
		array4[6] = "p_lck1";
		array4[7] = "p_lpd1";
		array4[8] = "f_rss1";
		array4[9] = "f_rsk1";
		array4[10] = "f_rfl5";
		array4[11] = "f_rfl4";
		array4[12] = "f_rfl3";
		array4[13] = "f_rfl2";
		array4[14] = "f_rfl1";
		array4[15] = "f_box1";
		array4[16] = "f_key5";
		array4[17] = "f_key4";
		array4[18] = "f_key3";
		array4[19] = "f_key2";
		array4[20] = "f_key1";
		array4[21] = "f_gld1";
		array4[22] = "f_gld2";
		array4[23] = "f_gld3";
		array4[24] = "f_gld4";
		array4[25] = "f_gld5";
		array4[26] = "f_jil1";
		array4[27] = "f_jil2";
		array4[28] = "f_jil3";
		array4[29] = "f_jil4";
		array4[30] = "f_jil5";
		array4[31] = "f_exp1";
		array4[32] = "f_exp2";
		array4[33] = "f_exp3";
		array4[34] = "f_exp4";
		array4[35] = "f_exp5";
		array4[36] = "f_arp1";
		array4[37] = "f_arp2";
		array4[38] = "f_arp3";
		array4[39] = "f_arp4";
		array4[40] = "f_arp5";
		array4[41] = "f_qhp1";
		array4[42] = "f_qmp1";
		array4[43] = "f_qsp1";
		array4[44] = "f_qmp2";
		array4[45] = "f_nyb1";
		array4[46] = "a_all15";
		array4[47] = "c_all15";
		array4[48] = "t_mal15";
		array4[49] = "t_fem15";
		array4[50] = "p_sss1";
		array4[51] = "f_ori1";
		array4[52] = "f_ppl1";
		array4[53] = "p_all23";
		array4[54] = "p_all24";
		array4[55] = "f_lkp1";
		array4[56] = "f_skl2";
		array4[57] = "f_vlb1";
		array4[58] = "f_vlb2";
		array4[59] = "f_wdv1";
		array4[60] = "f_smb1";
		array4[61] = "f_wtb1";
		array4[62] = "t_all66";
		array4[63] = "t_all67";
		array4[64] = "p_sdm1";
		array4[65] = "p_sdv1";
		array4[66] = "p_skm1";
		array4[67] = "p_skz1";
		array4[68] = "d_cak5";
		array4[69] = "d_cak6";
		array4[70] = "f_bdb1";
		array4[71] = "d_cak7";
		array4[72] = "f_ibk1";
		array4[73] = "f_ibk2";
		array4[74] = "f_hlb1";
		array4[75] = "f_hlb2";
		array4[76] = "f_hlb3";
		array4[77] = "f_ktg1";
		array4[78] = "f_ktg2";
		array4[79] = "f_ktg3";
		array4[80] = "f_ktg4";
		array4[81] = "f_ktg5";
		array4[82] = "f_skl1";
		array4[83] = "b_all1";
		array4[84] = "b_all10";
		array4[85] = "b_all20";
		array4[86] = "b_all21";
		array4[87] = "b_all30";
		array4[88] = "b_all31";
		array4[89] = "b_all40";
		array4[90] = "b_all41";
		array4[91] = "b_all45";
		array4[92] = "b_all50";
		array4[93] = "b_all51";
		array4[94] = "b_all66";
		array4[95] = "o_all1";
		array4[96] = "o_all2";
		array4[97] = "o_all3";
		array4[98] = "o_all4";
		array4[99] = "o_all5";
		array4[100] = "o_all6";
		array4[101] = "o_all7";
		array4[102] = "o_all9";
		array4[103] = "o_bug1";
		array4[104] = "o_bug2";
		array4[105] = "o_dun1";
		array4[106] = "o_dun2";
		array4[107] = "o_dun3";
		array4[108] = "o_mol1";
		array4[109] = "o_mol2";
		array4[110] = "o_mol3";
		array4[111] = "w_wlf5";
		array4[112] = "c_wlf5";
		array4[113] = "a_wlf5";
		array4[114] = "w_bsn5";
		array4[115] = "c_bsn5";
		array4[116] = "a_bsn5";
		array4[117] = "w_pnd5";
		array4[118] = "c_pnd5";
		array4[119] = "a_pnd5";
		array4[120] = "w_whl5";
		array4[121] = "c_whl5";
		array4[122] = "a_whl5";
		array4[123] = "w_cat5";
		array4[124] = "c_cat5";
		array4[125] = "a_cat5";
		array4[126] = "t_cat5";
		array4[127] = "w_chm5";
		array4[128] = "c_chm5";
		array4[129] = "a_chm5";
		array4[130] = "w_rab5";
		array4[131] = "c_rab5";
		array4[132] = "a_rab5";
		array4[133] = "w_mol5";
		array4[134] = "c_mol5";
		array4[135] = "a_mol5";
		array4[136] = "w_mnk5";
		array4[137] = "c_mnk5";
		array4[138] = "a_mnk5";
		array4[139] = "w_pgn5";
		array4[140] = "c_pgn5";
		array4[141] = "a_pgn5";
		array4[142] = "w_shp5";
		array4[143] = "c_shp5";
		array4[144] = "a_shp5";
		array4[145] = "w_bat5";
		array4[146] = "c_bat5";
		array4[147] = "a_bat5";
		array4[148] = "a_wlf15";
		array4[149] = "c_wlf15";
		array4[150] = "a_bsn15";
		array4[151] = "c_bsn15";
		array4[152] = "a_pnd15";
		array4[153] = "c_pnd15";
		array4[154] = "a_whl15";
		array4[155] = "c_whl15";
		array4[156] = "a_cat15";
		array4[157] = "c_cat15";
		array4[158] = "a_chm15";
		array4[159] = "c_chm15";
		array4[160] = "a_rab15";
		array4[161] = "c_rab15";
		array4[162] = "a_mol15";
		array4[163] = "c_mol15";
		array4[164] = "a_mnk15";
		array4[165] = "c_mnk15";
		array4[166] = "a_pgn15";
		array4[167] = "c_pgn15";
		array4[168] = "a_shp15";
		array4[169] = "c_shp15";
		array4[170] = "a_bat15";
		array4[171] = "c_bat15";
		array4[172] = "c_wlf19";
		array4[173] = "c_bsn19";
		array4[174] = "c_pnd19";
		array4[175] = "c_whl19";
		array4[176] = "c_cat19";
		array4[177] = "c_chm19";
		array4[178] = "c_rab19";
		array4[179] = "c_mol19";
		array4[180] = "c_mnk19";
		array4[181] = "c_pgn19";
		array4[182] = "c_shp19";
		array4[183] = "c_bat19";
		array4[184] = "w_wlf25";
		array4[185] = "c_wlf25";
		array4[186] = "a_wlf25";
		array4[187] = "w_bsn25";
		array4[188] = "c_bsn25";
		array4[189] = "a_bsn25";
		array4[190] = "w_pnd25";
		array4[191] = "c_pnd25";
		array4[192] = "a_pnd25";
		array4[193] = "w_whl25";
		array4[194] = "c_whl25";
		array4[195] = "a_whl25";
		array4[196] = "w_cat25";
		array4[197] = "c_cat25";
		array4[198] = "a_cat25";
		array4[199] = "w_chm25";
		array4[200] = "c_chm25";
		array4[201] = "a_chm25";
		array4[202] = "w_rab25";
		array4[203] = "c_rab25";
		array4[204] = "a_rab25";
		array4[205] = "w_mol25";
		array4[206] = "c_mol25";
		array4[207] = "a_mol25";
		array4[208] = "w_mnk25";
		array4[209] = "c_mnk25";
		array4[210] = "a_mnk25";
		array4[211] = "w_pgn25";
		array4[212] = "c_pgn25";
		array4[213] = "a_pgn25";
		array4[214] = "w_shp25";
		array4[215] = "c_shp25";
		array4[216] = "a_shp25";
		array4[217] = "w_bat25";
		array4[218] = "c_bat25";
		array4[219] = "a_bat25";
		array4[220] = "w_wlf35";
		array4[221] = "c_wlf35";
		array4[222] = "a_wlf35";
		array4[223] = "w_bsn35";
		array4[224] = "c_bsn35";
		array4[225] = "a_bsn35";
		array4[226] = "w_pnd35";
		array4[227] = "c_pnd35";
		array4[228] = "a_pnd35";
		array4[229] = "w_whl35";
		array4[230] = "c_whl35";
		array4[231] = "a_whl35";
		array4[232] = "w_cat35";
		array4[233] = "c_cat35";
		array4[234] = "a_cat35";
		array4[235] = "w_chm35";
		array4[236] = "c_chm35";
		array4[237] = "a_chm35";
		array4[238] = "w_rab35";
		array4[239] = "c_rab35";
		array4[240] = "a_rab35";
		array4[241] = "w_mol35";
		array4[242] = "c_mol35";
		array4[243] = "a_mol35";
		array4[244] = "w_mnk35";
		array4[245] = "c_mnk35";
		array4[246] = "a_mnk35";
		array4[247] = "w_pgn35";
		array4[248] = "c_pgn35";
		array4[249] = "a_pgn35";
		array4[250] = "w_shp35";
		array4[251] = "c_shp35";
		array4[252] = "a_shp35";
		array4[253] = "w_bat35";
		array4[254] = "c_bat35";
		array4[255] = "a_bat35";
		array4[256] = "w_wlf45";
		array4[257] = "c_wlf45";
		array4[258] = "a_wlf45";
		array4[259] = "w_bsn45";
		array4[260] = "c_bsn45";
		array4[261] = "a_bsn45";
		array4[262] = "w_pnd45";
		array4[263] = "c_pnd45";
		array4[264] = "a_pnd45";
		array4[265] = "t_pnd45";
		array4[266] = "w_whl45";
		array4[267] = "c_whl45";
		array4[268] = "a_whl45";
		array4[269] = "w_cat45";
		array4[270] = "c_cat45";
		array4[271] = "a_cat45";
		array4[272] = "w_chm45";
		array4[273] = "c_chm45";
		array4[274] = "a_chm45";
		array4[275] = "w_rab45";
		array4[276] = "c_rab45";
		array4[277] = "a_rab45";
		array4[278] = "w_mol45";
		array4[279] = "c_mol45";
		array4[280] = "a_mol45";
		array4[281] = "w_mnk45";
		array4[282] = "c_mnk45";
		array4[283] = "a_mnk45";
		array4[284] = "t_mnk45";
		array4[285] = "w_pgn45";
		array4[286] = "c_pgn45";
		array4[287] = "a_pgn45";
		array4[288] = "w_shp45";
		array4[289] = "c_shp45";
		array4[290] = "a_shp45";
		array4[291] = "w_bat45";
		array4[292] = "c_bat45";
		array4[293] = "a_bat45";
		array4[294] = "w_wlf65";
		array4[295] = "c_wlf65";
		array4[296] = "a_wlf65";
		array4[297] = "w_bsn65";
		array4[298] = "c_bsn65";
		array4[299] = "a_bsn65";
		array4[300] = "w_pnd65";
		array4[301] = "c_pnd65";
		array4[302] = "a_pnd65";
		array4[303] = "w_whl65";
		array4[304] = "c_whl65";
		array4[305] = "a_whl65";
		array4[306] = "w_cat65";
		array4[307] = "c_cat65";
		array4[308] = "a_cat65";
		array4[309] = "w_chm65";
		array4[310] = "c_chm65";
		array4[311] = "a_chm65";
		array4[312] = "w_rab65";
		array4[313] = "c_rab65";
		array4[314] = "a_rab65";
		array4[315] = "w_mol65";
		array4[316] = "c_mol65";
		array4[317] = "a_mol65";
		array4[318] = "w_mnk65";
		array4[319] = "c_mnk65";
		array4[320] = "a_mnk65";
		array4[321] = "w_pgn65";
		array4[322] = "c_pgn65";
		array4[323] = "a_pgn65";
		array4[324] = "w_shp65";
		array4[325] = "c_shp65";
		array4[326] = "a_shp65";
		array4[327] = "w_bat65";
		array4[328] = "c_bat65";
		array4[329] = "a_bat65";
		array4[330] = "c_all1";
		array4[331] = "c_all3";
		array4[332] = "c_all7";
		array4[333] = "c_all8";
		array4[334] = "c_all9";
		array4[335] = "c_all10";
		array4[336] = "c_all11";
		array4[337] = "c_all12";
		array4[338] = "c_all16";
		array4[339] = "c_all26";
		array4[340] = "c_all18";
		array4[341] = "c_all19";
		array4[342] = "c_all21";
		array4[343] = "c_all22";
		array4[344] = "c_all23";
		array4[345] = "c_all24";
		array4[346] = "c_all25";
		array4[347] = "c_all27";
		array4[348] = "c_all28";
		array4[349] = "c_all29";
		array4[350] = "c_all37";
		array4[351] = "c_all38";
		array4[352] = "c_all39";
		array4[353] = "c_all46";
		array4[354] = "c_all56";
		array4[355] = "c_all66";
		array4[356] = "c_mal37";
		array4[357] = "c_fem11";
		array4[358] = "c_fem37";
		array4[359] = "t_all1";
		array4[360] = "t_all2";
		array4[361] = "t_all3";
		array4[362] = "t_all4";
		array4[363] = "t_all6";
		array4[364] = "t_all7";
		array4[365] = "t_all8";
		array4[366] = "t_all9";
		array4[367] = "t_all10";
		array4[368] = "t_all11";
		array4[369] = "t_all12";
		array4[370] = "t_all13";
		array4[371] = "t_all14";
		array4[372] = "t_all15";
		array4[373] = "t_all16";
		array4[374] = "t_all17";
		array4[375] = "t_all18";
		array4[376] = "t_all19";
		array4[377] = "t_all20";
		array4[378] = "t_all21";
		array4[379] = "t_all22";
		array4[380] = "t_all23";
		array4[381] = "t_all24";
		array4[382] = "t_all25";
		array4[383] = "t_all26";
		array4[384] = "t_all27";
		array4[385] = "t_all28";
		array4[386] = "t_all29";
		array4[387] = "t_all30";
		array4[388] = "t_all31";
		array4[389] = "t_all32";
		array4[390] = "t_all33";
		array4[391] = "t_all34";
		array4[392] = "t_all35";
		array4[393] = "t_all36";
		array4[394] = "t_all37";
		array4[395] = "t_all38";
		array4[396] = "t_all39";
		array4[397] = "t_all41";
		array4[398] = "t_all42";
		array4[399] = "t_all43";
		array4[400] = "t_all44";
		array4[401] = "t_all46";
		array4[402] = "t_all51";
		array4[403] = "t_all52";
		array4[404] = "t_all66";
		array4[405] = "t_all67";
		array4[406] = "t_all68";
		array4[407] = "t_all69";
		array4[408] = "t_all71";
		array4[409] = "t_all72";
		array4[410] = "t_all73";
		array4[411] = "t_all74";
		array4[412] = "t_all80";
		array4[413] = "t_all81";
		array4[414] = "t_all82";
		array4[415] = "t_all83";
		array4[416] = "t_all84";
		array4[417] = "t_all85";
		array4[418] = "t_all86";
		array4[419] = "t_all87";
		array4[420] = "t_all88";
		array4[421] = "t_all89";
		array4[422] = "t_all90";
		array4[423] = "t_all91";
		array4[424] = "t_all92";
		array4[425] = "t_all93";
		array4[426] = "t_all94";
		array4[427] = "t_all95";
		array4[428] = "t_all96";
		array4[429] = "t_fem1";
		array4[430] = "t_fem2";
		array4[431] = "t_mal11";
		array4[432] = "t_fem11";
		array4[433] = "t_mal14";
		array4[434] = "t_fem14";
		array4[435] = "t_mal37";
		array4[436] = "t_fem37";
		array4[437] = "t_mal46";
		array4[438] = "t_fem46";
		array4[439] = "t_mal56";
		array4[440] = "t_fem56";
		array4[441] = "t_mal66";
		array4[442] = "t_fem66";
		array4[443] = "t_pnd5";
		array4[444] = "t_pnd26";
		array4[445] = "t_pnd27";
		array4[446] = "t_cat5";
		array4[447] = "t_wlf60";
		array4[448] = "t_bsn60";
		array4[449] = "t_pnd60";
		array4[450] = "t_whl60";
		array4[451] = "t_cat60";
		array4[452] = "t_chm60";
		array4[453] = "t_rab60";
		array4[454] = "t_mol60";
		array4[455] = "t_mnk60";
		array4[456] = "t_pgn60";
		array4[457] = "t_shp60";
		array4[458] = "t_bat60";
		array4[459] = "t_wlf62";
		array4[460] = "t_bsn62";
		array4[461] = "t_pnd62";
		array4[462] = "t_whl62";
		array4[463] = "t_cat62";
		array4[464] = "t_chm62";
		array4[465] = "t_rab62";
		array4[466] = "t_mol62";
		array4[467] = "t_mnk62";
		array4[468] = "t_pgn62";
		array4[469] = "t_shp62";
		array4[470] = "t_bat62";
		array4[471] = "p_all1";
		array4[472] = "p_all2";
		array4[473] = "p_all3";
		array4[474] = "p_all4";
		array4[475] = "p_all11";
		array4[476] = "p_all12";
		array4[477] = "p_all21";
		array4[478] = "p_all22";
		array4[479] = "p_all23";
		array4[480] = "p_all24";
		array4[481] = "p_lcr1";
		array4[482] = "p_lcp1";
		array4[483] = "p_lmp1";
		array4[484] = "p_lpp1";
		array4[485] = "p_lct1";
		array4[486] = "p_lcc1";
		array4[487] = "p_lpk1";
		array4[488] = "p_lml1";
		array4[489] = "p_lbd1";
		array4[490] = "p_lcs1";
		array4[491] = "p_lms1";
		array4[492] = "p_lps1";
		array4[493] = "p_ldc1";
		array4[494] = "p_ldm1";
		array4[495] = "p_ldp1";
		array4[496] = "p_ldt1";
		array4[497] = "p_ldn1";
		array4[498] = "p_ldk1";
		array4[499] = "p_lmc1";
		array4[500] = "p_lmn1";
		array4[501] = "p_lmo1";
		array4[502] = "p_srp1";
		array4[503] = "p_sbb1";
		array4[504] = "p_sim1";
		array4[505] = "p_sdm1";
		array4[506] = "p_skr1";
		array4[507] = "p_skg1";
		array4[508] = "p_sky1";
		array4[509] = "p_skb1";
		array4[510] = "p_skk1";
		array4[511] = "p_sam1";
		array4[512] = "p_sfb1";
		array4[513] = "p_sob1";
		array4[514] = "p_sgb1";
		array4[515] = "p_slb1";
		array4[516] = "p_stb1";
		array4[517] = "p_spb1";
		array4[518] = "p_swb1";
		array4[519] = "p_ssq1";
		array4[520] = "p_snb1";
		array4[521] = "p_sab1";
		array4[522] = "p_spg1";
		array4[523] = "p_spf1";
		array4[524] = "p_msb1";
		array4[525] = "p_mcb1";
		array4[526] = "p_mab1";
		array4[527] = "p_mrb1";
		array4[528] = "p_mmb1";
		array4[529] = "p_mgb1";
		array4[530] = "p_mnb1";
		array4[531] = "n_veg1";
		array4[532] = "n_veg2";
		array4[533] = "n_veg3";
		array4[534] = "n_veg4";
		array4[535] = "n_veg5";
		array4[536] = "n_veg6";
		array4[537] = "n_veg7";
		array4[538] = "n_veg8";
		array4[539] = "n_npc1";
		array4[540] = "n_npc2";
		array4[541] = "n_npc3";
		array4[542] = "n_npc4";
		array4[543] = "n_npc7";
		array4[544] = "n_npc8";
		array4[545] = "n_npc9";
		array4[546] = "n_npc10";
		array4[547] = "n_npc11";
		array4[548] = "n_npc12";
		array4[549] = "n_npc13";
		array4[550] = "n_npc14";
		array4[551] = "n_npc15";
		array4[552] = "n_npc16";
		array4[553] = "n_npc17";
		array4[554] = "n_npc18";
		array4[555] = "n_npc19";
		array4[556] = "n_npc20";
		array4[557] = "n_npc21";
		array4[558] = "n_npc22";
		array4[559] = "n_npc23";
		array4[560] = "n_npc24";
		array4[561] = "n_npc25";
		array4[562] = "n_npc26";
		array4[563] = "n_npc27";
		array4[564] = "n_npc28";
		array4[565] = "n_npc29";
		array4[566] = "n_npc30";
		array4[567] = "n_npc31";
		array4[568] = "n_npc32";
		array4[569] = "n_npc33";
		array4[570] = "n_npc34";
		array4[571] = "n_npc35";
		array4[572] = "n_npc36";
		array4[573] = "n_npc37";
		array4[574] = "k_mdl1";
		array4[575] = "k_mdl2";
		array4[576] = "k_mdl3";
		array4[577] = "k_bdg1";
		array4[578] = "k_bdg2";
		array4[579] = "k_bdg3";
		array4[580] = "k_bdg4";
		array4[581] = "k_bdg5";
		array4[582] = "k_bdg6";
		array4[583] = "k_bdg7";
		array4[584] = "k_bdg8";
		array4[585] = "k_bdg9";
		array4[586] = "k_bdg10";
		array4[587] = "k_bdg11";
		array4[588] = "k_dtk1";
		array4[589] = "k_dtk2";
		array4[590] = "k_dtk3";
		array4[591] = "k_dtk4";
		array4[592] = "k_dtk5";
		array4[593] = "k_gdp1";
		array4[594] = "k_tlm1";
		array4[595] = "k_stm1";
		array4[596] = "k_trp1";
		array4[597] = "k_trp2";
		array4[598] = "k_trp3";
		array4[599] = "k_trp4";
		array4[600] = "k_trp5";
		array4[601] = "k_trp6";
		array4[602] = "k_trp7";
		array4[603] = "k_trp8";
		array4[604] = "k_bvt1";
		array4[605] = "k_bvt2";
		array4[606] = "k_bvt3";
		array4[607] = "k_bvt4";
		array4[608] = "k_bvt5";
		array4[609] = "k_bvt6";
		array4[610] = "k_bvt7";
		array4[611] = "k_bvt8";
		array4[612] = "k_let1";
		array4[613] = "k_let2";
		array4[614] = "k_let3";
		array4[615] = "k_lbx1";
		array4[616] = "k_crd1";
		array4[617] = "k_crd2";
		array4[618] = "k_bok1";
		array4[619] = "k_tol1";
		array4[620] = "k_tol2";
		array4[621] = "k_cwn1";
		array4[622] = "k_cwn2";
		array4[623] = "k_cwn3";
		array4[624] = "k_cwn4";
		array4[625] = "k_wep1";
		array4[626] = "k_wep2";
		array4[627] = "k_wep3";
		array4[628] = "k_shd1";
		array4[629] = "k_shd2";
		System.Array result = array4;
		array4[630] = "k_shd3";
		return result;
	}

	// Token: 0x06005D02 RID: 23810 RVA: 0x00C24FD0 File Offset: 0x00C231D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getOwl2List(int nRank)
	{
		if (20773 - 553889 != -533116)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_3D5:
			if (nRank == 100)
			{
				if (139174 - 394490 == -255315)
				{
					continue;
				}
				if (Game.server >= 3)
				{
					goto IL_46E;
				}
				if (289113 - 359983 != -70870)
				{
					continue;
				}
			}
			string[] array = new string[]
			{
				"k_dun1",
				"k_dun2",
				"k_dun3",
				"k_dun6",
				"f_exl1",
				"f_exl2",
				"f_exl3",
				"f_qhp1",
				"f_qmp1",
				"f_qsp1",
				"f_ton1",
				"f_ton2",
				"f_ton3",
				"f_hpp1",
				"f_hpp2",
				"f_hpp3",
				"f_hpp4",
				"f_hpp5",
				"f_mpp1",
				"f_mpp2",
				"f_mpp3",
				"f_mpp4",
				"f_mpp5",
				"f_spp1",
				"f_spp2",
				"f_spp3",
				"f_spp4",
				"f_spp5",
				"m_flt1",
				"m_kbt1",
				"m_spo5",
				"m_srd1",
				"m_atk1",
				"m_def1",
				"m_agi1",
				"m_vit1",
				"m_mag1",
				"m_cha1",
				"m_tal1",
				"m_lck1",
				"m_srd2",
				"m_atk2",
				"m_def2",
				"m_agi2",
				"m_vit2",
				"m_mag2",
				"m_cha2",
				"m_tal2",
				"m_lck2",
				"m_srd3",
				"m_atk3",
				"m_def3",
				"m_agi3",
				"m_vit3",
				"m_mag3",
				"m_cha3",
				"m_tal3",
				"m_lck3",
				"m_rnw1",
				"m_rnw2",
				"m_rnw3",
				"m_rsl1",
				"m_rsl2",
				"m_rsl3",
				"m_rpc1",
				"m_rpc2",
				"m_rpc3",
				"m_asl1",
				"m_asl2",
				"m_asl3"
			};
			if (188003 - 589215 == -401212)
			{
				array2 = new UnityScript.Lang.Array();
				if (48465 - 582400 == -533935)
				{
					int i = 0;
					if (278538 - 74793 != 203746)
					{
						string[] array3 = array;
						if (185934 - 29363 != 156572)
						{
							int length = array3.Length;
							if (43659 - 548995 != -505335)
							{
								while (i < length)
								{
									if (PlayerPrefs.GetInt("usableItem", 1) != 0)
									{
										if (241971 - 539574 != -297603)
										{
											goto IL_3D5;
										}
										if (Mathf.Abs(ItemData.getLv(array3[i])) <= nRank + 10)
										{
											if (101277 - 160041 != -58764)
											{
												goto IL_3D5;
											}
											array2.Add(array3[i]);
											if (294131 - 484690 == -190558)
											{
												goto IL_3D5;
											}
										}
									}
									else
									{
										array2.Add(array3[i]);
										if (171640 - 357192 != -185552)
										{
											goto IL_3D5;
										}
									}
									i++;
									if (275337 - 455492 == -180154)
									{
										goto IL_3D5;
									}
								}
								if (96966 - 64670 != 32297)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return array2.ToBuiltin(typeof(string));
		IL_46E:
		string[] array4 = new string[407];
		array4[0] = "k_dun1";
		array4[1] = "k_dun2";
		array4[2] = "k_dun3";
		array4[3] = "k_dun6";
		array4[4] = "k_dun7";
		array4[5] = "k_dun8";
		array4[6] = "k_dun9";
		array4[7] = "k_dun10";
		array4[8] = "f_exl1";
		array4[9] = "f_exl2";
		array4[10] = "f_exl3";
		array4[11] = "f_qhp1";
		array4[12] = "f_qmp1";
		array4[13] = "f_qsp1";
		array4[14] = "f_hpp1";
		array4[15] = "f_hpp2";
		array4[16] = "f_hpp3";
		array4[17] = "f_hpp4";
		array4[18] = "f_hpp5";
		array4[19] = "f_mpp1";
		array4[20] = "f_mpp2";
		array4[21] = "f_mpp3";
		array4[22] = "f_mpp4";
		array4[23] = "f_mpp5";
		array4[24] = "f_spp1";
		array4[25] = "f_spp2";
		array4[26] = "f_spp3";
		array4[27] = "f_spp4";
		array4[28] = "f_spp5";
		array4[29] = "f_ton1";
		array4[30] = "f_ton2";
		array4[31] = "f_ton3";
		array4[32] = "f_dem1";
		array4[33] = "f_dem2";
		array4[34] = "f_dem3";
		array4[35] = "m_flt1";
		array4[36] = "m_kbt1";
		array4[37] = "m_spo5";
		array4[38] = "f_hpb1";
		array4[39] = "f_hpb2";
		array4[40] = "f_hpb3";
		array4[41] = "f_mpb1";
		array4[42] = "f_mpb2";
		array4[43] = "f_mpb3";
		array4[44] = "f_spb1";
		array4[45] = "f_spb2";
		array4[46] = "f_spb3";
		array4[47] = "f_slb1";
		array4[48] = "f_slb2";
		array4[49] = "f_slb3";
		array4[50] = "f_kob1";
		array4[51] = "f_htb1";
		array4[52] = "f_rmb1";
		array4[53] = "f_stb1";
		array4[54] = "f_ahb1";
		array4[55] = "f_amb1";
		array4[56] = "f_asb1";
		array4[57] = "f_akb1";
		array4[58] = "f_fwk1";
		array4[59] = "f_fwk2";
		array4[60] = "f_fwk3";
		array4[61] = "f_fwk4";
		array4[62] = "f_fwk5";
		array4[63] = "f_fwk6";
		array4[64] = "f_fwk7";
		array4[65] = "f_bmb1";
		array4[66] = "f_bmb2";
		array4[67] = "f_bmb3";
		array4[68] = "f_bmb4";
		array4[69] = "f_bmb5";
		array4[70] = "f_bmb6";
		array4[71] = "f_cam1";
		array4[72] = "f_cam2";
		array4[73] = "f_cam3";
		array4[74] = "f_cam4";
		array4[75] = "m_srd1";
		array4[76] = "m_atk1";
		array4[77] = "m_def1";
		array4[78] = "m_agi1";
		array4[79] = "m_vit1";
		array4[80] = "m_mag1";
		array4[81] = "m_cha1";
		array4[82] = "m_tal1";
		array4[83] = "m_lck1";
		array4[84] = "m_srd2";
		array4[85] = "m_atk2";
		array4[86] = "m_def2";
		array4[87] = "m_agi2";
		array4[88] = "m_vit2";
		array4[89] = "m_mag2";
		array4[90] = "m_cha2";
		array4[91] = "m_tal2";
		array4[92] = "m_lck2";
		array4[93] = "m_srd3";
		array4[94] = "m_atk3";
		array4[95] = "m_def3";
		array4[96] = "m_agi3";
		array4[97] = "m_vit3";
		array4[98] = "m_mag3";
		array4[99] = "m_cha3";
		array4[100] = "m_tal3";
		array4[101] = "m_lck3";
		array4[102] = "m_rnw1";
		array4[103] = "m_rnw2";
		array4[104] = "m_rnw3";
		array4[105] = "m_rsl1";
		array4[106] = "m_rsl2";
		array4[107] = "m_rsl3";
		array4[108] = "m_asl1";
		array4[109] = "m_asl2";
		array4[110] = "m_asl3";
		array4[111] = "m_rpc1";
		array4[112] = "m_rpc2";
		array4[113] = "m_rpc3";
		array4[114] = "m_jnk1";
		array4[115] = "m_jnk2";
		array4[116] = "m_jnk3";
		array4[117] = "m_jnk4";
		array4[118] = "m_jnk5";
		array4[119] = "m_wod1";
		array4[120] = "m_wod2";
		array4[121] = "m_wod3";
		array4[122] = "m_wod4";
		array4[123] = "m_peb1";
		array4[124] = "m_peb2";
		array4[125] = "m_peb3";
		array4[126] = "m_rck1";
		array4[127] = "m_rck2";
		array4[128] = "m_rck3";
		array4[129] = "m_rck4";
		array4[130] = "m_stn1";
		array4[131] = "m_stn2";
		array4[132] = "m_stn3";
		array4[133] = "m_stn4";
		array4[134] = "m_stn5";
		array4[135] = "m_zin1";
		array4[136] = "m_zin2";
		array4[137] = "m_zin3";
		array4[138] = "m_cop1";
		array4[139] = "m_cop2";
		array4[140] = "m_cop3";
		array4[141] = "m_irn1";
		array4[142] = "m_irn2";
		array4[143] = "m_irn3";
		array4[144] = "m_sil1";
		array4[145] = "m_sil2";
		array4[146] = "m_sil3";
		array4[147] = "m_gld1";
		array4[148] = "m_gld2";
		array4[149] = "m_gld3";
		array4[150] = "m_spo1";
		array4[151] = "m_spo2";
		array4[152] = "m_spo3";
		array4[153] = "m_spo4";
		array4[154] = "m_spo5";
		array4[155] = "m_crs1";
		array4[156] = "m_crs2";
		array4[157] = "m_crs3";
		array4[158] = "m_crs4";
		array4[159] = "m_crs5";
		array4[160] = "m_crs6";
		array4[161] = "m_pin1";
		array4[162] = "m_pin2";
		array4[163] = "m_pin3";
		array4[164] = "m_pap1";
		array4[165] = "m_pap2";
		array4[166] = "m_pap3";
		array4[167] = "m_fab1";
		array4[168] = "m_fab2";
		array4[169] = "m_fab3";
		array4[170] = "m_fab4";
		array4[171] = "m_fab5";
		array4[172] = "m_fab6";
		array4[173] = "m_fab7";
		array4[174] = "m_fab8";
		array4[175] = "m_fab9";
		array4[176] = "m_fab10";
		array4[177] = "m_fab11";
		array4[178] = "m_fab12";
		array4[179] = "m_fab13";
		array4[180] = "m_fab14";
		array4[181] = "m_fab15";
		array4[182] = "m_lth1";
		array4[183] = "m_lth2";
		array4[184] = "m_lth3";
		array4[185] = "m_bro1";
		array4[186] = "m_bro2";
		array4[187] = "m_bro3";
		array4[188] = "m_bro4";
		array4[189] = "m_bro5";
		array4[190] = "m_bro6";
		array4[191] = "m_bro7";
		array4[192] = "m_bro8";
		array4[193] = "m_bro9";
		array4[194] = "m_orb1";
		array4[195] = "m_orb2";
		array4[196] = "m_orb3";
		array4[197] = "m_orb4";
		array4[198] = "m_orb5";
		array4[199] = "m_orb6";
		array4[200] = "m_orb7";
		array4[201] = "m_orb8";
		array4[202] = "m_orb9";
		array4[203] = "m_orb10";
		array4[204] = "m_wat1";
		array4[205] = "m_wat2";
		array4[206] = "m_wat3";
		array4[207] = "m_wat4";
		array4[208] = "m_ice1";
		array4[209] = "m_ice2";
		array4[210] = "m_ice3";
		array4[211] = "m_ice4";
		array4[212] = "m_spm1";
		array4[213] = "m_spm2";
		array4[214] = "m_spm3";
		array4[215] = "m_spm4";
		array4[216] = "m_spm5";
		array4[217] = "m_spm6";
		array4[218] = "m_spm7";
		array4[219] = "m_bug1";
		array4[220] = "m_bug2";
		array4[221] = "m_bug3";
		array4[222] = "m_bug4";
		array4[223] = "m_bug5";
		array4[224] = "m_bug6";
		array4[225] = "m_bug7";
		array4[226] = "m_bug8";
		array4[227] = "m_bug9";
		array4[228] = "m_bug10";
		array4[229] = "m_bug11";
		array4[230] = "m_bug12";
		array4[231] = "m_bug13";
		array4[232] = "m_bug14";
		array4[233] = "m_bug15";
		array4[234] = "m_bug16";
		array4[235] = "m_bug17";
		array4[236] = "m_bug18";
		array4[237] = "m_bug19";
		array4[238] = "m_bug20";
		array4[239] = "m_bug21";
		array4[240] = "m_bug22";
		array4[241] = "m_bug23";
		array4[242] = "m_bug24";
		array4[243] = "m_bug25";
		array4[244] = "m_bug26";
		array4[245] = "m_bug27";
		array4[246] = "m_bug28";
		array4[247] = "m_bug29";
		array4[248] = "m_bug30";
		array4[249] = "m_bug31";
		array4[250] = "m_bug32";
		array4[251] = "m_bug33";
		array4[252] = "m_bug34";
		array4[253] = "m_bug35";
		array4[254] = "m_bug36";
		array4[255] = "m_bug37";
		array4[256] = "m_bug38";
		array4[257] = "m_bug39";
		array4[258] = "m_bug40";
		array4[259] = "m_bug41";
		array4[260] = "m_bug42";
		array4[261] = "m_bug43";
		array4[262] = "m_bug44";
		array4[263] = "m_bug45";
		array4[264] = "m_bug46";
		array4[265] = "m_bug47";
		array4[266] = "m_bug48";
		array4[267] = "m_bug49";
		array4[268] = "m_bug50";
		array4[269] = "m_bug51";
		array4[270] = "m_bug52";
		array4[271] = "m_bug53";
		array4[272] = "m_bug54";
		array4[273] = "m_bug55";
		array4[274] = "m_bug56";
		array4[275] = "m_bug57";
		array4[276] = "m_bug58";
		array4[277] = "m_bug59";
		array4[278] = "m_bug60";
		array4[279] = "m_bug61";
		array4[280] = "m_bug62";
		array4[281] = "m_bug63";
		array4[282] = "m_bug64";
		array4[283] = "m_bug65";
		array4[284] = "m_bug66";
		array4[285] = "m_bug67";
		array4[286] = "m_bug68";
		array4[287] = "m_bug69";
		array4[288] = "m_bug70";
		array4[289] = "m_bug71";
		array4[290] = "m_bug72";
		array4[291] = "m_bug73";
		array4[292] = "m_bug74";
		array4[293] = "m_mcn1";
		array4[294] = "m_mcn2";
		array4[295] = "m_mcn3";
		array4[296] = "m_mcn4";
		array4[297] = "m_mcn5";
		array4[298] = "m_mcn6";
		array4[299] = "m_mcn7";
		array4[300] = "m_mcn8";
		array4[301] = "m_mcn9";
		array4[302] = "m_mcn10";
		array4[303] = "m_mcn11";
		array4[304] = "m_mcn12";
		array4[305] = "m_mcn13";
		array4[306] = "m_shl1";
		array4[307] = "m_shl2";
		array4[308] = "m_shl3";
		array4[309] = "m_shl4";
		array4[310] = "m_flw1";
		array4[311] = "m_flw2";
		array4[312] = "m_flw3";
		array4[313] = "m_flw4";
		array4[314] = "m_flw5";
		array4[315] = "m_flw6";
		array4[316] = "m_flw7";
		array4[317] = "m_flw8";
		array4[318] = "m_cor1";
		array4[319] = "m_cor2";
		array4[320] = "m_cor3";
		array4[321] = "m_gas1";
		array4[322] = "m_gas2";
		array4[323] = "m_gas3";
		array4[324] = "m_gas4";
		array4[325] = "m_prl1";
		array4[326] = "m_prl2";
		array4[327] = "m_prl3";
		array4[328] = "m_gle1";
		array4[329] = "m_gle2";
		array4[330] = "m_gle3";
		array4[331] = "m_gle4";
		array4[332] = "m_pwd1";
		array4[333] = "m_pwd2";
		array4[334] = "m_pwd3";
		array4[335] = "m_pwd4";
		array4[336] = "m_bon1";
		array4[337] = "m_bon2";
		array4[338] = "m_bon3";
		array4[339] = "m_bon4";
		array4[340] = "m_bon5";
		array4[341] = "m_flt1";
		array4[342] = "m_kbt1";
		array4[343] = "m_swp1";
		array4[344] = "m_swp2";
		array4[345] = "m_swp3";
		array4[346] = "m_swp4";
		array4[347] = "m_swp5";
		array4[348] = "m_swp6";
		array4[349] = "m_swp7";
		array4[350] = "m_swp8";
		array4[351] = "m_swp9";
		array4[352] = "m_swp10";
		array4[353] = "m_swp11";
		array4[354] = "m_swp12";
		array4[355] = "m_wmt1";
		array4[356] = "m_wmt2";
		array4[357] = "m_wmt3";
		array4[358] = "m_wmt4";
		array4[359] = "m_wmt5";
		array4[360] = "m_wmt6";
		array4[361] = "m_wmt7";
		array4[362] = "m_wmt8";
		array4[363] = "m_wmt9";
		array4[364] = "m_wmt10";
		array4[365] = "m_wmt11";
		array4[366] = "m_wmt12";
		array4[367] = "m_wmt13";
		array4[368] = "m_wmt14";
		array4[369] = "m_wmt15";
		array4[370] = "m_wmt16";
		array4[371] = "m_wmt17";
		array4[372] = "m_wmt18";
		array4[373] = "m_amt1";
		array4[374] = "m_amt2";
		array4[375] = "m_amt3";
		array4[376] = "m_amt4";
		array4[377] = "m_amt5";
		array4[378] = "m_amt6";
		array4[379] = "m_amt7";
		array4[380] = "m_amt8";
		array4[381] = "m_amt9";
		array4[382] = "m_amt10";
		array4[383] = "m_amt11";
		array4[384] = "m_amt12";
		array4[385] = "m_amt13";
		array4[386] = "m_amt14";
		array4[387] = "m_amt15";
		array4[388] = "m_amt16";
		array4[389] = "m_amt17";
		array4[390] = "m_amt18";
		array4[391] = "m_amt19";
		array4[392] = "m_amt20";
		array4[393] = "m_eqp1";
		array4[394] = "m_eqp2";
		array4[395] = "m_eqp3";
		array4[396] = "m_eqp4";
		array4[397] = "m_eqp5";
		array4[398] = "m_eqp6";
		array4[399] = "m_eqp7";
		array4[400] = "m_eqp8";
		array4[401] = "m_eqp9";
		array4[402] = "m_asd1";
		array4[403] = "m_asd2";
		array4[404] = "m_asd3";
		array4[405] = "m_asd4";
		System.Array result = array4;
		array4[406] = "m_asd5";
		return result;
	}

	// Token: 0x06005D03 RID: 23811 RVA: 0x00C265F8 File Offset: 0x00C247F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getMouseList(int nRank)
	{
		if (25328 - 558800 != -533472)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_652:
			if (nRank == 100)
			{
				if (81617 - 432430 != -350813)
				{
					continue;
				}
				if (Game.server >= 3)
				{
					goto IL_700;
				}
				if (214841 - 521952 == -307110)
				{
					continue;
				}
			}
			string[] array = new string[]
			{
				"w_wlf40",
				"w_bsn40",
				"w_pnd40",
				"w_whl40",
				"w_cat40",
				"w_chm40",
				"w_rab40",
				"w_mol40",
				"w_mnk40",
				"w_pgn40",
				"w_shp40",
				"w_bat40",
				"w_wlf31",
				"w_wlf32",
				"w_bsn31",
				"w_bsn32",
				"w_pnd31",
				"w_pnd32",
				"w_whl31",
				"w_whl32",
				"w_cat31",
				"w_cat32",
				"w_chm31",
				"w_chm32",
				"w_rab31",
				"w_rab32",
				"w_mol31",
				"w_mol32",
				"w_mnk31",
				"w_mnk32",
				"w_pgn31",
				"w_pgn32",
				"w_shp31",
				"w_shp32",
				"w_bat31",
				"w_bat32",
				"w_wlf21",
				"w_wlf22",
				"w_bsn21",
				"w_bsn22",
				"w_pnd21",
				"w_pnd22",
				"w_whl21",
				"w_whl22",
				"w_cat21",
				"w_cat22",
				"w_chm21",
				"w_chm22",
				"w_rab21",
				"w_rab22",
				"w_mol21",
				"w_mol22",
				"w_mnk21",
				"w_mnk22",
				"w_pgn21",
				"w_pgn22",
				"w_shp21",
				"w_shp22",
				"w_bat21",
				"w_bat22",
				"w_wlf10",
				"w_bsn10",
				"w_pnd10",
				"w_whl10",
				"w_cat10",
				"w_chm10",
				"w_rab10",
				"w_mol10",
				"w_mnk10",
				"w_pgn10",
				"w_shp10",
				"w_bat10",
				"w_wlf2",
				"w_bsn2",
				"w_pnd2",
				"w_whl2",
				"w_cat2",
				"w_chm2",
				"w_rab2",
				"w_mol2",
				"w_mnk2",
				"w_pgn2",
				"w_shp2",
				"w_bat2",
				"w_wlf1",
				"w_bsn1",
				"w_pnd1",
				"w_whl1",
				"w_cat1",
				"w_chm1",
				"w_rab1",
				"w_mol1",
				"w_mnk1",
				"w_pgn1",
				"w_shp1",
				"w_bat1"
			};
			if (173918 - 312208 != -138289)
			{
				array2 = new UnityScript.Lang.Array();
				if (284865 - 112225 == 172640)
				{
					int i = 0;
					if (139338 - 94909 != 44430)
					{
						string[] array3 = array;
						if (205284 - 560580 != -355295)
						{
							int length = array3.Length;
							if (235088 - 33343 != 201746)
							{
								while (i < length)
								{
									if (PlayerPrefs.GetInt("usableItem", 1) != 0)
									{
										if (115146 - 273348 != -158202)
										{
											goto IL_652;
										}
										string a = array3[i].Trim().Substring(0, 1);
										if (272972 - 361390 != -88418)
										{
											goto IL_652;
										}
										if (a == "w")
										{
											if (217907 - 111660 != 106247)
											{
												goto IL_652;
											}
											goto IL_501;
										}
										else if (a == "a")
										{
											if (183984 - 414123 != -230138)
											{
												goto IL_501;
											}
											goto IL_652;
										}
										else if (a == "c")
										{
											if (197597 - 123887 != 73710)
											{
												goto IL_652;
											}
											goto IL_553;
										}
										else if (a == "b")
										{
											if (209327 - 573634 != -364306)
											{
												goto IL_3ED;
											}
											goto IL_652;
										}
										else if (a == "t")
										{
											if (188772 - 38419 != 150354)
											{
												goto IL_4D3;
											}
											goto IL_652;
										}
										else if (Mathf.Abs(ItemData.getLv(array3[i])) <= nRank + 10)
										{
											if (192850 - 417486 == -224635)
											{
												goto IL_652;
											}
											array2.Add(array3[i]);
											if (69999 - 56807 == 13193)
											{
												goto IL_652;
											}
										}
										IL_628:
										goto IL_3CD;
										IL_4D3:
										if (CharacterData.current.canEquip(array3[i]))
										{
											if (229211 - 496785 != -267574)
											{
												goto IL_652;
											}
											if (Mathf.Abs(ItemData.getLv(array3[i])) <= nRank + 10)
											{
												if (75633 - 157397 != -81764)
												{
													goto IL_652;
												}
												array2.Add(array3[i]);
												if (67994 - 97716 == -29721)
												{
													goto IL_652;
												}
											}
										}
										goto IL_628;
										IL_3ED:
										goto IL_4D3;
										IL_553:
										goto IL_3ED;
										IL_501:
										goto IL_553;
									}
									else
									{
										array2.Add(array3[i]);
										if (94620 - 430568 != -335948)
										{
											goto IL_652;
										}
									}
									IL_3CD:
									i++;
									if (177176 - 127448 == 49729)
									{
										goto IL_652;
									}
								}
								if (119612 - 274187 != -154574)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return array2.ToBuiltin(typeof(string));
		IL_700:
		string[] array4 = new string[557];
		array4[0] = "w_wlf1";
		array4[1] = "w_wlf2";
		array4[2] = "w_wlf3";
		array4[3] = "w_wlf5";
		array4[4] = "w_wlf10";
		array4[5] = "w_wlf11";
		array4[6] = "w_wlf12";
		array4[7] = "w_wlf14";
		array4[8] = "w_wlf15";
		array4[9] = "w_wlf19";
		array4[10] = "w_wlf21";
		array4[11] = "w_wlf22";
		array4[12] = "w_wlf23";
		array4[13] = "w_wlf24";
		array4[14] = "w_wlf25";
		array4[15] = "w_wlf31";
		array4[16] = "w_wlf32";
		array4[17] = "w_wlf33";
		array4[18] = "w_wlf34";
		array4[19] = "w_wlf35";
		array4[20] = "w_wlf36";
		array4[21] = "w_wlf39";
		array4[22] = "w_wlf40";
		array4[23] = "w_wlf41";
		array4[24] = "w_wlf42";
		array4[25] = "w_wlf43";
		array4[26] = "w_wlf44";
		array4[27] = "w_wlf45";
		array4[28] = "w_wlf46";
		array4[29] = "w_wlf47";
		array4[30] = "w_wlf48";
		array4[31] = "w_wlf49";
		array4[32] = "w_wlf50";
		array4[33] = "w_wlf51";
		array4[34] = "w_wlf52";
		array4[35] = "w_wlf56";
		array4[36] = "w_wlf58";
		array4[37] = "w_wlf59";
		array4[38] = "w_wlf60";
		array4[39] = "w_wlf61";
		array4[40] = "w_wlf62";
		array4[41] = "w_wlf65";
		array4[42] = "w_wlf66";
		array4[43] = "w_wlf69";
		array4[44] = "w_bsn1";
		array4[45] = "w_bsn2";
		array4[46] = "w_bsn3";
		array4[47] = "w_bsn5";
		array4[48] = "w_bsn10";
		array4[49] = "w_bsn11";
		array4[50] = "w_bsn12";
		array4[51] = "w_bsn14";
		array4[52] = "w_bsn15";
		array4[53] = "w_bsn19";
		array4[54] = "w_bsn21";
		array4[55] = "w_bsn22";
		array4[56] = "w_bsn23";
		array4[57] = "w_bsn24";
		array4[58] = "w_bsn25";
		array4[59] = "w_bsn31";
		array4[60] = "w_bsn32";
		array4[61] = "w_bsn33";
		array4[62] = "w_bsn34";
		array4[63] = "w_bsn35";
		array4[64] = "w_bsn36";
		array4[65] = "w_bsn39";
		array4[66] = "w_bsn40";
		array4[67] = "w_bsn41";
		array4[68] = "w_bsn42";
		array4[69] = "w_bsn43";
		array4[70] = "w_bsn44";
		array4[71] = "w_bsn45";
		array4[72] = "w_bsn46";
		array4[73] = "w_bsn47";
		array4[74] = "w_bsn48";
		array4[75] = "w_bsn49";
		array4[76] = "w_bsn50";
		array4[77] = "w_bsn51";
		array4[78] = "w_bsn52";
		array4[79] = "w_bsn56";
		array4[80] = "w_bsn58";
		array4[81] = "w_bsn59";
		array4[82] = "w_bsn60";
		array4[83] = "w_bsn61";
		array4[84] = "w_bsn62";
		array4[85] = "w_bsn65";
		array4[86] = "w_bsn66";
		array4[87] = "w_bsn69";
		array4[88] = "w_pnd1";
		array4[89] = "w_pnd2";
		array4[90] = "w_pnd3";
		array4[91] = "w_pnd5";
		array4[92] = "w_pnd10";
		array4[93] = "w_pnd11";
		array4[94] = "w_pnd12";
		array4[95] = "w_pnd14";
		array4[96] = "w_pnd15";
		array4[97] = "w_pnd19";
		array4[98] = "w_pnd21";
		array4[99] = "w_pnd22";
		array4[100] = "w_pnd23";
		array4[101] = "w_pnd24";
		array4[102] = "w_pnd25";
		array4[103] = "w_pnd31";
		array4[104] = "w_pnd32";
		array4[105] = "w_pnd33";
		array4[106] = "w_pnd34";
		array4[107] = "w_pnd35";
		array4[108] = "w_pnd36";
		array4[109] = "w_pnd39";
		array4[110] = "w_pnd40";
		array4[111] = "w_pnd41";
		array4[112] = "w_pnd42";
		array4[113] = "w_pnd43";
		array4[114] = "w_pnd44";
		array4[115] = "w_pnd45";
		array4[116] = "w_pnd46";
		array4[117] = "w_pnd47";
		array4[118] = "w_pnd48";
		array4[119] = "w_pnd49";
		array4[120] = "w_pnd50";
		array4[121] = "w_pnd51";
		array4[122] = "w_pnd52";
		array4[123] = "w_pnd56";
		array4[124] = "w_pnd58";
		array4[125] = "w_pnd59";
		array4[126] = "w_pnd60";
		array4[127] = "w_pnd61";
		array4[128] = "w_pnd62";
		array4[129] = "w_pnd65";
		array4[130] = "w_pnd66";
		array4[131] = "w_pnd69";
		array4[132] = "w_whl1";
		array4[133] = "w_whl2";
		array4[134] = "w_whl3";
		array4[135] = "w_whl5";
		array4[136] = "w_whl10";
		array4[137] = "w_whl11";
		array4[138] = "w_whl12";
		array4[139] = "w_whl14";
		array4[140] = "w_whl15";
		array4[141] = "w_whl19";
		array4[142] = "w_whl21";
		array4[143] = "w_whl22";
		array4[144] = "w_whl23";
		array4[145] = "w_whl24";
		array4[146] = "w_whl25";
		array4[147] = "w_whl31";
		array4[148] = "w_whl32";
		array4[149] = "w_whl33";
		array4[150] = "w_whl34";
		array4[151] = "w_whl35";
		array4[152] = "w_whl36";
		array4[153] = "w_whl39";
		array4[154] = "w_whl40";
		array4[155] = "w_whl41";
		array4[156] = "w_whl42";
		array4[157] = "w_whl43";
		array4[158] = "w_whl44";
		array4[159] = "w_whl45";
		array4[160] = "w_whl46";
		array4[161] = "w_whl47";
		array4[162] = "w_whl48";
		array4[163] = "w_whl49";
		array4[164] = "w_whl50";
		array4[165] = "w_whl51";
		array4[166] = "w_whl52";
		array4[167] = "w_whl56";
		array4[168] = "w_whl58";
		array4[169] = "w_whl59";
		array4[170] = "w_whl60";
		array4[171] = "w_whl61";
		array4[172] = "w_whl62";
		array4[173] = "w_whl65";
		array4[174] = "w_whl66";
		array4[175] = "w_whl69";
		array4[176] = "w_cat1";
		array4[177] = "w_cat2";
		array4[178] = "w_cat3";
		array4[179] = "w_cat5";
		array4[180] = "w_cat10";
		array4[181] = "w_cat11";
		array4[182] = "w_cat12";
		array4[183] = "w_cat14";
		array4[184] = "w_cat15";
		array4[185] = "w_cat19";
		array4[186] = "w_cat21";
		array4[187] = "w_cat22";
		array4[188] = "w_cat23";
		array4[189] = "w_cat24";
		array4[190] = "w_cat25";
		array4[191] = "w_cat31";
		array4[192] = "w_cat32";
		array4[193] = "w_cat33";
		array4[194] = "w_cat34";
		array4[195] = "w_cat35";
		array4[196] = "w_cat36";
		array4[197] = "w_cat39";
		array4[198] = "w_cat40";
		array4[199] = "w_cat41";
		array4[200] = "w_cat42";
		array4[201] = "w_cat43";
		array4[202] = "w_cat44";
		array4[203] = "w_cat45";
		array4[204] = "w_cat46";
		array4[205] = "w_cat47";
		array4[206] = "w_cat48";
		array4[207] = "w_cat49";
		array4[208] = "w_cat50";
		array4[209] = "w_cat51";
		array4[210] = "w_cat52";
		array4[211] = "w_cat56";
		array4[212] = "w_cat58";
		array4[213] = "w_cat59";
		array4[214] = "w_cat60";
		array4[215] = "w_cat61";
		array4[216] = "w_cat62";
		array4[217] = "w_cat65";
		array4[218] = "w_cat66";
		array4[219] = "w_cat69";
		array4[220] = "w_chm1";
		array4[221] = "w_chm2";
		array4[222] = "w_chm3";
		array4[223] = "w_chm5";
		array4[224] = "w_chm10";
		array4[225] = "w_chm11";
		array4[226] = "w_chm12";
		array4[227] = "w_chm14";
		array4[228] = "w_chm15";
		array4[229] = "w_chm19";
		array4[230] = "w_chm21";
		array4[231] = "w_chm22";
		array4[232] = "w_chm23";
		array4[233] = "w_chm24";
		array4[234] = "w_chm25";
		array4[235] = "w_chm31";
		array4[236] = "w_chm32";
		array4[237] = "w_chm33";
		array4[238] = "w_chm34";
		array4[239] = "w_chm35";
		array4[240] = "w_chm36";
		array4[241] = "w_chm39";
		array4[242] = "w_chm40";
		array4[243] = "w_chm41";
		array4[244] = "w_chm42";
		array4[245] = "w_chm43";
		array4[246] = "w_chm44";
		array4[247] = "w_chm45";
		array4[248] = "w_chm46";
		array4[249] = "w_chm47";
		array4[250] = "w_chm48";
		array4[251] = "w_chm49";
		array4[252] = "w_chm50";
		array4[253] = "w_chm51";
		array4[254] = "w_chm52";
		array4[255] = "w_chm56";
		array4[256] = "w_chm58";
		array4[257] = "w_chm59";
		array4[258] = "w_chm60";
		array4[259] = "w_chm61";
		array4[260] = "w_chm62";
		array4[261] = "w_chm65";
		array4[262] = "w_chm66";
		array4[263] = "w_chm69";
		array4[264] = "w_rab1";
		array4[265] = "w_rab2";
		array4[266] = "w_rab3";
		array4[267] = "w_rab5";
		array4[268] = "w_rab10";
		array4[269] = "w_rab11";
		array4[270] = "w_rab12";
		array4[271] = "w_rab14";
		array4[272] = "w_rab15";
		array4[273] = "w_rab19";
		array4[274] = "w_rab21";
		array4[275] = "w_rab22";
		array4[276] = "w_rab23";
		array4[277] = "w_rab24";
		array4[278] = "w_rab25";
		array4[279] = "w_rab31";
		array4[280] = "w_rab32";
		array4[281] = "w_rab33";
		array4[282] = "w_rab34";
		array4[283] = "w_rab35";
		array4[284] = "w_rab36";
		array4[285] = "w_rab39";
		array4[286] = "w_rab40";
		array4[287] = "w_rab41";
		array4[288] = "w_rab42";
		array4[289] = "w_rab43";
		array4[290] = "w_rab44";
		array4[291] = "w_rab45";
		array4[292] = "w_rab46";
		array4[293] = "w_rab47";
		array4[294] = "w_rab48";
		array4[295] = "w_rab49";
		array4[296] = "w_rab50";
		array4[297] = "w_rab51";
		array4[298] = "w_rab52";
		array4[299] = "w_rab56";
		array4[300] = "w_rab58";
		array4[301] = "w_rab59";
		array4[302] = "w_rab60";
		array4[303] = "w_rab61";
		array4[304] = "w_rab62";
		array4[305] = "w_rab65";
		array4[306] = "w_rab66";
		array4[307] = "w_rab69";
		array4[308] = "w_mol1";
		array4[309] = "w_mol2";
		array4[310] = "w_mol3";
		array4[311] = "w_mol5";
		array4[312] = "w_mol10";
		array4[313] = "w_mol11";
		array4[314] = "w_mol12";
		array4[315] = "w_mol14";
		array4[316] = "w_mol15";
		array4[317] = "w_mol19";
		array4[318] = "w_mol21";
		array4[319] = "w_mol22";
		array4[320] = "w_mol23";
		array4[321] = "w_mol24";
		array4[322] = "w_mol25";
		array4[323] = "w_mol31";
		array4[324] = "w_mol32";
		array4[325] = "w_mol33";
		array4[326] = "w_mol34";
		array4[327] = "w_mol35";
		array4[328] = "w_mol36";
		array4[329] = "w_mol39";
		array4[330] = "w_mol40";
		array4[331] = "w_mol41";
		array4[332] = "w_mol42";
		array4[333] = "w_mol43";
		array4[334] = "w_mol44";
		array4[335] = "w_mol45";
		array4[336] = "w_mol46";
		array4[337] = "w_mol47";
		array4[338] = "w_mol48";
		array4[339] = "w_mol49";
		array4[340] = "w_mol50";
		array4[341] = "w_mol51";
		array4[342] = "w_mol52";
		array4[343] = "w_mol56";
		array4[344] = "w_mol58";
		array4[345] = "w_mol59";
		array4[346] = "w_mol60";
		array4[347] = "w_mol61";
		array4[348] = "w_mol62";
		array4[349] = "w_mol65";
		array4[350] = "w_mol66";
		array4[351] = "w_mol69";
		array4[352] = "w_mnk1";
		array4[353] = "w_mnk2";
		array4[354] = "w_mnk3";
		array4[355] = "w_mnk5";
		array4[356] = "w_mnk10";
		array4[357] = "w_mnk11";
		array4[358] = "w_mnk12";
		array4[359] = "w_mnk14";
		array4[360] = "w_mnk15";
		array4[361] = "w_mnk19";
		array4[362] = "w_mnk21";
		array4[363] = "w_mnk22";
		array4[364] = "w_mnk23";
		array4[365] = "w_mnk24";
		array4[366] = "w_mnk25";
		array4[367] = "w_mnk31";
		array4[368] = "w_mnk32";
		array4[369] = "w_mnk33";
		array4[370] = "w_mnk34";
		array4[371] = "w_mnk35";
		array4[372] = "w_mnk36";
		array4[373] = "w_mnk39";
		array4[374] = "w_mnk40";
		array4[375] = "w_mnk41";
		array4[376] = "w_mnk42";
		array4[377] = "w_mnk43";
		array4[378] = "w_mnk44";
		array4[379] = "w_mnk45";
		array4[380] = "w_mnk46";
		array4[381] = "w_mnk47";
		array4[382] = "w_mnk48";
		array4[383] = "w_mnk49";
		array4[384] = "w_mnk50";
		array4[385] = "w_mnk51";
		array4[386] = "w_mnk52";
		array4[387] = "w_mnk56";
		array4[388] = "w_mnk58";
		array4[389] = "w_mnk59";
		array4[390] = "w_mnk60";
		array4[391] = "w_mnk61";
		array4[392] = "w_mnk62";
		array4[393] = "w_mnk65";
		array4[394] = "w_mnk66";
		array4[395] = "w_mnk69";
		array4[396] = "w_pgn1";
		array4[397] = "w_pgn2";
		array4[398] = "w_pgn3";
		array4[399] = "w_pgn5";
		array4[400] = "w_pgn10";
		array4[401] = "w_pgn11";
		array4[402] = "w_pgn12";
		array4[403] = "w_pgn14";
		array4[404] = "w_pgn15";
		array4[405] = "w_pgn19";
		array4[406] = "w_pgn21";
		array4[407] = "w_pgn22";
		array4[408] = "w_pgn23";
		array4[409] = "w_pgn24";
		array4[410] = "w_pgn25";
		array4[411] = "w_pgn31";
		array4[412] = "w_pgn32";
		array4[413] = "w_pgn33";
		array4[414] = "w_pgn34";
		array4[415] = "w_pgn35";
		array4[416] = "w_pgn36";
		array4[417] = "w_pgn39";
		array4[418] = "w_pgn40";
		array4[419] = "w_pgn41";
		array4[420] = "w_pgn42";
		array4[421] = "w_pgn43";
		array4[422] = "w_pgn44";
		array4[423] = "w_pgn45";
		array4[424] = "w_pgn46";
		array4[425] = "w_pgn47";
		array4[426] = "w_pgn48";
		array4[427] = "w_pgn49";
		array4[428] = "w_pgn50";
		array4[429] = "w_pgn51";
		array4[430] = "w_pgn52";
		array4[431] = "w_pgn56";
		array4[432] = "w_pgn58";
		array4[433] = "w_pgn59";
		array4[434] = "w_pgn60";
		array4[435] = "w_pgn61";
		array4[436] = "w_pgn62";
		array4[437] = "w_pgn65";
		array4[438] = "w_pgn66";
		array4[439] = "w_pgn69";
		array4[440] = "w_shp1";
		array4[441] = "w_shp2";
		array4[442] = "w_shp3";
		array4[443] = "w_shp5";
		array4[444] = "w_shp10";
		array4[445] = "w_shp11";
		array4[446] = "w_shp12";
		array4[447] = "w_shp14";
		array4[448] = "w_shp15";
		array4[449] = "w_shp19";
		array4[450] = "w_shp21";
		array4[451] = "w_shp22";
		array4[452] = "w_shp23";
		array4[453] = "w_shp24";
		array4[454] = "w_shp25";
		array4[455] = "w_shp31";
		array4[456] = "w_shp32";
		array4[457] = "w_shp33";
		array4[458] = "w_shp34";
		array4[459] = "w_shp35";
		array4[460] = "w_shp36";
		array4[461] = "w_shp39";
		array4[462] = "w_shp40";
		array4[463] = "w_shp41";
		array4[464] = "w_shp42";
		array4[465] = "w_shp43";
		array4[466] = "w_shp44";
		array4[467] = "w_shp45";
		array4[468] = "w_shp46";
		array4[469] = "w_shp47";
		array4[470] = "w_shp48";
		array4[471] = "w_shp49";
		array4[472] = "w_shp50";
		array4[473] = "w_shp51";
		array4[474] = "w_shp52";
		array4[475] = "w_shp56";
		array4[476] = "w_shp58";
		array4[477] = "w_shp59";
		array4[478] = "w_shp60";
		array4[479] = "w_shp61";
		array4[480] = "w_shp62";
		array4[481] = "w_shp65";
		array4[482] = "w_shp66";
		array4[483] = "w_shp69";
		array4[484] = "w_bat1";
		array4[485] = "w_bat2";
		array4[486] = "w_bat3";
		array4[487] = "w_bat5";
		array4[488] = "w_bat10";
		array4[489] = "w_bat11";
		array4[490] = "w_bat12";
		array4[491] = "w_bat14";
		array4[492] = "w_bat15";
		array4[493] = "w_bat19";
		array4[494] = "w_bat21";
		array4[495] = "w_bat22";
		array4[496] = "w_bat23";
		array4[497] = "w_bat24";
		array4[498] = "w_bat25";
		array4[499] = "w_bat31";
		array4[500] = "w_bat32";
		array4[501] = "w_bat33";
		array4[502] = "w_bat34";
		array4[503] = "w_bat35";
		array4[504] = "w_bat36";
		array4[505] = "w_bat39";
		array4[506] = "w_bat40";
		array4[507] = "w_bat41";
		array4[508] = "w_bat42";
		array4[509] = "w_bat43";
		array4[510] = "w_bat44";
		array4[511] = "w_bat45";
		array4[512] = "w_bat46";
		array4[513] = "w_bat47";
		array4[514] = "w_bat48";
		array4[515] = "w_bat49";
		array4[516] = "w_bat50";
		array4[517] = "w_bat51";
		array4[518] = "w_bat52";
		array4[519] = "w_bat56";
		array4[520] = "w_bat58";
		array4[521] = "w_bat59";
		array4[522] = "w_bat60";
		array4[523] = "w_bat61";
		array4[524] = "w_bat62";
		array4[525] = "w_bat65";
		array4[526] = "w_bat66";
		array4[527] = "w_bat69";
		array4[528] = "w_wlf79";
		array4[529] = "w_bsn79";
		array4[530] = "w_pnd79";
		array4[531] = "w_whl79";
		array4[532] = "w_cat79";
		array4[533] = "w_chm79";
		array4[534] = "w_mol79";
		array4[535] = "w_rab79";
		array4[536] = "w_mnk79";
		array4[537] = "w_pgn79";
		array4[538] = "w_shp79";
		array4[539] = "w_bat79";
		array4[540] = "w_wlf81";
		array4[541] = "w_bsn81";
		array4[542] = "w_bsn82";
		array4[543] = "w_bsn83";
		array4[544] = "w_cat81";
		array4[545] = "w_chm81";
		array4[546] = "w_chm82";
		array4[547] = "w_mol81";
		array4[548] = "w_pgn81";
		array4[549] = "w_shp81";
		array4[550] = "w_shp82";
		array4[551] = "w_shp83";
		array4[552] = "w_shp84";
		array4[553] = "w_bat81";
		array4[554] = "w_bat82";
		array4[555] = "w_bat83";
		System.Array result = array4;
		array4[556] = "w_bat84";
		return result;
	}

	// Token: 0x06005D04 RID: 23812 RVA: 0x00C285B8 File Offset: 0x00C267B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getWarthogList(int nRank)
	{
		if (196053 - 577249 != -381195)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_4B1:
			if (nRank == 100)
			{
				if (12801 - 485099 != -472298)
				{
					continue;
				}
				if (Game.server >= 3)
				{
					goto IL_5E4;
				}
				if (108990 - 117442 == -8451)
				{
					continue;
				}
			}
			string[] array = new string[]
			{
				"c_wlf40",
				"a_wlf40",
				"c_wlf31",
				"a_wlf31",
				"c_wlf32",
				"a_wlf32",
				"c_wlf21",
				"a_wlf21",
				"c_wlf22",
				"a_wlf22",
				"c_wlf10",
				"a_wlf10",
				"c_bsn40",
				"a_bsn40",
				"c_bsn31",
				"a_bsn31",
				"c_bsn32",
				"a_bsn32",
				"c_bsn21",
				"a_bsn21",
				"c_bsn22",
				"a_bsn22",
				"a_bsn10",
				"c_pnd40",
				"a_pnd40",
				"c_pnd31",
				"a_pnd31",
				"c_pnd32",
				"a_pnd32",
				"c_pnd21",
				"a_pnd21",
				"c_pnd22",
				"a_pnd22",
				"a_pnd10",
				"c_whl40",
				"a_whl40",
				"c_whl31",
				"a_whl31",
				"c_whl32",
				"a_whl32",
				"c_whl21",
				"a_whl21",
				"c_whl22",
				"a_whl22",
				"a_whl10",
				"c_chm40",
				"a_chm40",
				"c_chm31",
				"a_chm31",
				"c_chm32",
				"a_chm32",
				"c_chm21",
				"a_chm21",
				"c_chm22",
				"a_chm22",
				"c_chm10",
				"a_chm10",
				"c_mol40",
				"a_mol40",
				"c_mol31",
				"a_mol31",
				"c_mol32",
				"a_mol32",
				"c_mol21",
				"a_mol21",
				"c_mol22",
				"a_mol22",
				"c_mol10",
				"a_mol10",
				"a_all1"
			};
			if (134664 - 89823 != 44842)
			{
				array2 = new UnityScript.Lang.Array();
				if (288991 - 473975 == -184984)
				{
					int i = 0;
					if (272385 - 465347 != -192961)
					{
						string[] array3 = array;
						if (253580 - 176207 == 77373)
						{
							int length = array3.Length;
							if (185368 - 217843 == -32475)
							{
								while (i < length)
								{
									if (PlayerPrefs.GetInt("usableItem", 1) != 0)
									{
										if (291901 - 49072 == 242830)
										{
											goto IL_4B1;
										}
										string a = array3[i].Trim().Substring(0, 1);
										if (158186 - 469144 != -310958)
										{
											goto IL_4B1;
										}
										if (a == "w")
										{
											if (26052 - 269425 != -243372)
											{
												goto IL_4D3;
											}
											goto IL_4B1;
										}
										else if (a == "a")
										{
											if (268265 - 101162 != 167103)
											{
												goto IL_4B1;
											}
											goto IL_4D3;
										}
										else if (a == "c")
										{
											if (197996 - 41494 != 156502)
											{
												goto IL_4B1;
											}
											goto IL_482;
										}
										else if (a == "b")
										{
											if (276418 - 551723 != -275304)
											{
												goto IL_57B;
											}
											goto IL_4B1;
										}
										else if (a == "t")
										{
											if (220238 - 195286 != 24953)
											{
												goto IL_F5;
											}
											goto IL_4B1;
										}
										else
										{
											array2.Add(array3[i]);
											if (50820 - 344941 == -294120)
											{
												goto IL_4B1;
											}
										}
										IL_CB:
										goto IL_462;
										IL_F5:
										if (CharacterData.current.canEquip(array3[i]))
										{
											if (281344 - 128624 != 152720)
											{
												goto IL_4B1;
											}
											if (Mathf.Abs(ItemData.getLv(array3[i])) <= nRank + 10)
											{
												if (259235 - 320103 != -60868)
												{
													goto IL_4B1;
												}
												array2.Add(array3[i]);
												if (46233 - 178845 != -132612)
												{
													goto IL_4B1;
												}
											}
										}
										goto IL_CB;
										IL_57B:
										goto IL_F5;
										IL_482:
										goto IL_57B;
										IL_4D3:
										goto IL_482;
									}
									else
									{
										array2.Add(array3[i]);
										if (96979 - 321884 != -224905)
										{
											goto IL_4B1;
										}
									}
									IL_462:
									i++;
									if (136241 - 104666 == 31576)
									{
										goto IL_4B1;
									}
								}
								if (173027 - 572397 != -399369)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return array2.ToBuiltin(typeof(string));
		IL_5E4:
		string[] array4 = new string[272];
		array4[0] = "c_wlf10";
		array4[1] = "a_wlf10";
		array4[2] = "c_wlf11";
		array4[3] = "a_wlf11";
		array4[4] = "c_wlf12";
		array4[5] = "a_wlf12";
		array4[6] = "c_wlf21";
		array4[7] = "a_wlf21";
		array4[8] = "c_wlf22";
		array4[9] = "a_wlf22";
		array4[10] = "c_wlf23";
		array4[11] = "a_wlf23";
		array4[12] = "c_wlf24";
		array4[13] = "a_wlf24";
		array4[14] = "c_wlf31";
		array4[15] = "a_wlf31";
		array4[16] = "c_wlf32";
		array4[17] = "a_wlf32";
		array4[18] = "c_wlf33";
		array4[19] = "a_wlf33";
		array4[20] = "c_wlf34";
		array4[21] = "a_wlf34";
		array4[22] = "c_wlf36";
		array4[23] = "c_wlf40";
		array4[24] = "a_wlf40";
		array4[25] = "c_wlf41";
		array4[26] = "a_wlf41";
		array4[27] = "c_wlf42";
		array4[28] = "a_wlf42";
		array4[29] = "c_wlf47";
		array4[30] = "a_wlf47";
		array4[31] = "c_wlf48";
		array4[32] = "a_wlf48";
		array4[33] = "c_wlf50";
		array4[34] = "a_wlf50";
		array4[35] = "c_wlf51";
		array4[36] = "a_wlf51";
		array4[37] = "c_wlf52";
		array4[38] = "a_wlf52";
		array4[39] = "c_wlf60";
		array4[40] = "a_wlf60";
		array4[41] = "c_wlf61";
		array4[42] = "a_wlf61";
		array4[43] = "c_wlf62";
		array4[44] = "a_wlf62";
		array4[45] = "a_bsn10";
		array4[46] = "a_bsn11";
		array4[47] = "c_bsn12";
		array4[48] = "a_bsn12";
		array4[49] = "c_bsn21";
		array4[50] = "a_bsn21";
		array4[51] = "c_bsn22";
		array4[52] = "a_bsn22";
		array4[53] = "c_bsn23";
		array4[54] = "a_bsn23";
		array4[55] = "c_bsn24";
		array4[56] = "a_bsn24";
		array4[57] = "c_bsn25";
		array4[58] = "a_bsn25";
		array4[59] = "c_bsn31";
		array4[60] = "a_bsn31";
		array4[61] = "c_bsn32";
		array4[62] = "a_bsn32";
		array4[63] = "c_bsn33";
		array4[64] = "a_bsn33";
		array4[65] = "c_bsn34";
		array4[66] = "a_bsn34";
		array4[67] = "c_bsn36";
		array4[68] = "a_bsn36";
		array4[69] = "c_bsn40";
		array4[70] = "a_bsn40";
		array4[71] = "c_bsn41";
		array4[72] = "a_bsn41";
		array4[73] = "c_bsn42";
		array4[74] = "a_bsn42";
		array4[75] = "c_bsn47";
		array4[76] = "a_bsn47";
		array4[77] = "c_bsn48";
		array4[78] = "a_bsn48";
		array4[79] = "c_bsn50";
		array4[80] = "a_bsn50";
		array4[81] = "c_bsn51";
		array4[82] = "a_bsn51";
		array4[83] = "c_bsn52";
		array4[84] = "a_bsn52";
		array4[85] = "c_bsn60";
		array4[86] = "a_bsn60";
		array4[87] = "c_bsn61";
		array4[88] = "a_bsn61";
		array4[89] = "c_bsn62";
		array4[90] = "a_bsn62";
		array4[91] = "c_pnd10";
		array4[92] = "a_pnd10";
		array4[93] = "c_pnd11";
		array4[94] = "a_pnd11";
		array4[95] = "c_pnd12";
		array4[96] = "a_pnd12";
		array4[97] = "c_pnd21";
		array4[98] = "a_pnd21";
		array4[99] = "c_pnd22";
		array4[100] = "a_pnd22";
		array4[101] = "c_pnd23";
		array4[102] = "a_pnd23";
		array4[103] = "c_pnd24";
		array4[104] = "a_pnd24";
		array4[105] = "c_pnd31";
		array4[106] = "a_pnd31";
		array4[107] = "c_pnd32";
		array4[108] = "a_pnd32";
		array4[109] = "c_pnd33";
		array4[110] = "a_pnd33";
		array4[111] = "c_pnd34";
		array4[112] = "a_pnd34";
		array4[113] = "c_pnd36";
		array4[114] = "c_pnd40";
		array4[115] = "a_pnd40";
		array4[116] = "c_pnd41";
		array4[117] = "a_pnd41";
		array4[118] = "c_pnd42";
		array4[119] = "a_pnd42";
		array4[120] = "c_pnd47";
		array4[121] = "a_pnd47";
		array4[122] = "c_pnd48";
		array4[123] = "a_pnd48";
		array4[124] = "c_pnd50";
		array4[125] = "a_pnd50";
		array4[126] = "c_pnd51";
		array4[127] = "a_pnd51";
		array4[128] = "c_pnd52";
		array4[129] = "a_pnd52";
		array4[130] = "c_pnd60";
		array4[131] = "a_pnd60";
		array4[132] = "c_pnd61";
		array4[133] = "a_pnd61";
		array4[134] = "c_pnd62";
		array4[135] = "a_pnd62";
		array4[136] = "c_whl10";
		array4[137] = "a_whl10";
		array4[138] = "c_whl11";
		array4[139] = "a_whl11";
		array4[140] = "c_whl12";
		array4[141] = "a_whl12";
		array4[142] = "c_whl21";
		array4[143] = "a_whl21";
		array4[144] = "c_whl22";
		array4[145] = "a_whl22";
		array4[146] = "c_whl23";
		array4[147] = "a_whl23";
		array4[148] = "c_whl24";
		array4[149] = "a_whl24";
		array4[150] = "c_whl31";
		array4[151] = "a_whl31";
		array4[152] = "c_whl32";
		array4[153] = "a_whl32";
		array4[154] = "c_whl33";
		array4[155] = "a_whl33";
		array4[156] = "c_whl34";
		array4[157] = "a_whl34";
		array4[158] = "c_whl36";
		array4[159] = "c_whl40";
		array4[160] = "a_whl40";
		array4[161] = "c_whl41";
		array4[162] = "a_whl41";
		array4[163] = "c_whl42";
		array4[164] = "a_whl42";
		array4[165] = "c_whl47";
		array4[166] = "a_whl47";
		array4[167] = "c_whl48";
		array4[168] = "a_whl48";
		array4[169] = "c_whl50";
		array4[170] = "a_whl50";
		array4[171] = "c_whl51";
		array4[172] = "a_whl51";
		array4[173] = "c_whl52";
		array4[174] = "a_whl52";
		array4[175] = "c_whl60";
		array4[176] = "a_whl60";
		array4[177] = "c_whl61";
		array4[178] = "a_whl61";
		array4[179] = "c_whl62";
		array4[180] = "a_whl62";
		array4[181] = "c_chm10";
		array4[182] = "a_chm10";
		array4[183] = "c_chm11";
		array4[184] = "a_chm11";
		array4[185] = "c_chm12";
		array4[186] = "a_chm12";
		array4[187] = "c_chm21";
		array4[188] = "a_chm21";
		array4[189] = "c_chm22";
		array4[190] = "a_chm22";
		array4[191] = "c_chm23";
		array4[192] = "a_chm23";
		array4[193] = "c_chm24";
		array4[194] = "a_chm24";
		array4[195] = "c_chm31";
		array4[196] = "a_chm31";
		array4[197] = "c_chm32";
		array4[198] = "a_chm32";
		array4[199] = "c_chm33";
		array4[200] = "a_chm33";
		array4[201] = "c_chm34";
		array4[202] = "a_chm34";
		array4[203] = "c_chm36";
		array4[204] = "c_chm40";
		array4[205] = "a_chm40";
		array4[206] = "c_chm41";
		array4[207] = "a_chm41";
		array4[208] = "c_chm42";
		array4[209] = "a_chm42";
		array4[210] = "c_chm47";
		array4[211] = "a_chm47";
		array4[212] = "c_chm48";
		array4[213] = "a_chm48";
		array4[214] = "c_chm50";
		array4[215] = "a_chm50";
		array4[216] = "c_chm51";
		array4[217] = "a_chm51";
		array4[218] = "c_chm52";
		array4[219] = "a_chm52";
		array4[220] = "c_chm60";
		array4[221] = "a_chm60";
		array4[222] = "c_chm61";
		array4[223] = "a_chm61";
		array4[224] = "c_chm62";
		array4[225] = "a_chm62";
		array4[226] = "c_mol10";
		array4[227] = "a_mol10";
		array4[228] = "c_mol11";
		array4[229] = "a_mol11";
		array4[230] = "c_mol12";
		array4[231] = "a_mol12";
		array4[232] = "c_mol21";
		array4[233] = "a_mol21";
		array4[234] = "c_mol22";
		array4[235] = "a_mol22";
		array4[236] = "c_mol23";
		array4[237] = "a_mol23";
		array4[238] = "c_mol24";
		array4[239] = "a_mol24";
		array4[240] = "c_mol31";
		array4[241] = "a_mol31";
		array4[242] = "c_mol32";
		array4[243] = "a_mol32";
		array4[244] = "c_mol33";
		array4[245] = "a_mol33";
		array4[246] = "c_mol34";
		array4[247] = "a_mol34";
		array4[248] = "c_mol36";
		array4[249] = "c_mol40";
		array4[250] = "a_mol40";
		array4[251] = "c_mol41";
		array4[252] = "a_mol41";
		array4[253] = "c_mol42";
		array4[254] = "a_mol42";
		array4[255] = "c_mol47";
		array4[256] = "a_mol47";
		array4[257] = "c_mol48";
		array4[258] = "a_mol48";
		array4[259] = "c_mol50";
		array4[260] = "a_mol50";
		array4[261] = "c_mol51";
		array4[262] = "a_mol51";
		array4[263] = "c_mol52";
		array4[264] = "a_mol52";
		array4[265] = "c_mol60";
		array4[266] = "a_mol60";
		array4[267] = "c_mol61";
		array4[268] = "a_mol61";
		array4[269] = "c_mol62";
		array4[270] = "a_mol62";
		System.Array result = array4;
		array4[271] = "a_all1";
		return result;
	}

	// Token: 0x06005D05 RID: 23813 RVA: 0x00C29700 File Offset: 0x00C27900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getAlpacaList(int nRank)
	{
		if (137268 - 564950 != -427681)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_98:
			if (nRank == 100)
			{
				if (178633 - 586523 == -407889)
				{
					continue;
				}
				if (Game.server >= 3)
				{
					goto IL_5BE;
				}
				if (32666 - 586420 == -553753)
				{
					continue;
				}
			}
			string[] array = new string[]
			{
				"c_cat40",
				"a_cat40",
				"c_cat31",
				"a_cat31",
				"c_cat32",
				"a_cat32",
				"c_cat21",
				"a_cat21",
				"c_cat22",
				"a_cat22",
				"c_cat10",
				"a_cat10",
				"c_rab40",
				"a_rab40",
				"c_rab31",
				"a_rab31",
				"c_rab32",
				"a_rab32",
				"c_rab21",
				"a_rab21",
				"c_rab22",
				"a_rab22",
				"c_rab10",
				"a_rab10",
				"c_mnk40",
				"a_mnk40",
				"c_mnk31",
				"a_mnk31",
				"c_mnk32",
				"a_mnk32",
				"c_mnk21",
				"a_mnk21",
				"c_mnk22",
				"a_mnk22",
				"c_mnk10",
				"a_mnk10",
				"c_pgn40",
				"a_pgn40",
				"c_pgn31",
				"a_pgn31",
				"c_pgn32",
				"a_pgn32",
				"c_pgn21",
				"a_pgn21",
				"c_pgn22",
				"a_pgn22",
				"c_pgn10",
				"a_pgn10",
				"c_shp40",
				"a_shp40",
				"c_shp31",
				"a_shp31",
				"c_shp32",
				"a_shp32",
				"c_shp21",
				"a_shp21",
				"c_shp22",
				"a_shp22",
				"a_shp10",
				"c_bat40",
				"a_bat40",
				"c_bat31",
				"a_bat31",
				"c_bat32",
				"a_bat32",
				"c_bat21",
				"a_bat21",
				"c_bat22",
				"a_bat22",
				"a_bat10",
				"a_all1"
			};
			if (55838 - 126156 != -70317)
			{
				array2 = new UnityScript.Lang.Array();
				if (116866 - 294270 != -177403)
				{
					int i = 0;
					if (50907 - 315904 == -264997)
					{
						string[] array3 = array;
						if (73400 - 343902 == -270502)
						{
							int length = array3.Length;
							if (211905 - 374633 != -162727)
							{
								while (i < length)
								{
									if (PlayerPrefs.GetInt("usableItem", 1) != 0)
									{
										if (87870 - 235936 != -148066)
										{
											goto IL_98;
										}
										string a = array3[i].Trim().Substring(0, 1);
										if (119283 - 571461 != -452177)
										{
											if (a == "w")
											{
												if (31128 - 113944 != -82816)
												{
													goto IL_98;
												}
												goto IL_45C;
											}
											else if (a == "a")
											{
												if (235263 - 193503 != 41761)
												{
													goto IL_45C;
												}
												goto IL_98;
											}
											else if (a == "c")
											{
												if (9112 - 523469 != -514357)
												{
													goto IL_98;
												}
												goto IL_51D;
											}
											else if (a == "t")
											{
												if (73712 - 30900 != 42812)
												{
													goto IL_98;
												}
												goto IL_57B;
											}
											else
											{
												array2.Add(array3[i]);
												if (219144 - 147051 != 72093)
												{
													goto IL_98;
												}
											}
											IL_44:
											goto IL_48B;
											IL_57B:
											if (CharacterData.current.canEquip(array3[i]))
											{
												if (273076 - 528914 == -255837)
												{
													goto IL_98;
												}
												if (Mathf.Abs(ItemData.getLv(array3[i])) <= nRank + 10)
												{
													if (157259 - 212955 != -55696)
													{
														goto IL_98;
													}
													array2.Add(array3[i]);
													if (69982 - 119792 != -49810)
													{
														goto IL_98;
													}
												}
											}
											goto IL_44;
											IL_51D:
											goto IL_57B;
											IL_45C:
											goto IL_51D;
										}
										goto IL_98;
									}
									else
									{
										array2.Add(array3[i]);
										if (185878 - 80170 != 105708)
										{
											goto IL_98;
										}
									}
									IL_48B:
									i++;
									if (54690 - 221990 != -167300)
									{
										goto IL_98;
									}
								}
								if (196467 - 493452 == -296985)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return array2.ToBuiltin(typeof(string));
		IL_5BE:
		string[] array4 = new string[276];
		array4[0] = "c_cat10";
		array4[1] = "a_cat10";
		array4[2] = "c_cat11";
		array4[3] = "a_cat11";
		array4[4] = "c_cat12";
		array4[5] = "a_cat12";
		array4[6] = "c_cat21";
		array4[7] = "a_cat21";
		array4[8] = "c_cat22";
		array4[9] = "a_cat22";
		array4[10] = "c_cat23";
		array4[11] = "a_cat23";
		array4[12] = "c_cat24";
		array4[13] = "a_cat24";
		array4[14] = "c_cat31";
		array4[15] = "a_cat31";
		array4[16] = "c_cat32";
		array4[17] = "a_cat32";
		array4[18] = "c_cat33";
		array4[19] = "a_cat33";
		array4[20] = "c_cat34";
		array4[21] = "a_cat34";
		array4[22] = "c_cat36";
		array4[23] = "c_cat40";
		array4[24] = "a_cat40";
		array4[25] = "c_cat41";
		array4[26] = "a_cat41";
		array4[27] = "c_cat42";
		array4[28] = "a_cat42";
		array4[29] = "c_cat47";
		array4[30] = "a_cat47";
		array4[31] = "c_cat48";
		array4[32] = "a_cat48";
		array4[33] = "c_cat50";
		array4[34] = "a_cat50";
		array4[35] = "c_cat51";
		array4[36] = "a_cat51";
		array4[37] = "c_cat52";
		array4[38] = "a_cat52";
		array4[39] = "c_cat60";
		array4[40] = "a_cat60";
		array4[41] = "c_cat61";
		array4[42] = "a_cat61";
		array4[43] = "c_cat62";
		array4[44] = "a_cat62";
		array4[45] = "c_rab10";
		array4[46] = "a_rab10";
		array4[47] = "c_rab11";
		array4[48] = "a_rab11";
		array4[49] = "c_rab12";
		array4[50] = "a_rab12";
		array4[51] = "c_rab21";
		array4[52] = "a_rab21";
		array4[53] = "c_rab22";
		array4[54] = "a_rab22";
		array4[55] = "c_rab23";
		array4[56] = "a_rab23";
		array4[57] = "c_rab24";
		array4[58] = "a_rab24";
		array4[59] = "c_rab31";
		array4[60] = "a_rab31";
		array4[61] = "c_rab32";
		array4[62] = "a_rab32";
		array4[63] = "c_rab33";
		array4[64] = "a_rab33";
		array4[65] = "c_rab34";
		array4[66] = "a_rab34";
		array4[67] = "c_rab36";
		array4[68] = "c_rab40";
		array4[69] = "a_rab40";
		array4[70] = "c_rab41";
		array4[71] = "a_rab41";
		array4[72] = "c_rab42";
		array4[73] = "a_rab42";
		array4[74] = "c_rab47";
		array4[75] = "a_rab47";
		array4[76] = "c_rab48";
		array4[77] = "a_rab48";
		array4[78] = "c_rab50";
		array4[79] = "a_rab50";
		array4[80] = "c_rab51";
		array4[81] = "a_rab51";
		array4[82] = "c_rab52";
		array4[83] = "a_rab52";
		array4[84] = "c_rab50";
		array4[85] = "a_rab50";
		array4[86] = "c_rab51";
		array4[87] = "a_rab51";
		array4[88] = "c_rab52";
		array4[89] = "a_rab52";
		array4[90] = "c_rab60";
		array4[91] = "a_rab60";
		array4[92] = "c_rab61";
		array4[93] = "a_rab61";
		array4[94] = "c_rab62";
		array4[95] = "a_rab62";
		array4[96] = "c_mnk10";
		array4[97] = "a_mnk10";
		array4[98] = "c_mnk11";
		array4[99] = "a_mnk11";
		array4[100] = "c_mnk12";
		array4[101] = "a_mnk12";
		array4[102] = "c_mnk21";
		array4[103] = "a_mnk21";
		array4[104] = "c_mnk22";
		array4[105] = "a_mnk22";
		array4[106] = "c_mnk23";
		array4[107] = "a_mnk23";
		array4[108] = "c_mnk24";
		array4[109] = "a_mnk24";
		array4[110] = "c_mnk31";
		array4[111] = "a_mnk31";
		array4[112] = "c_mnk32";
		array4[113] = "a_mnk32";
		array4[114] = "c_mnk33";
		array4[115] = "a_mnk33";
		array4[116] = "c_mnk34";
		array4[117] = "a_mnk34";
		array4[118] = "c_mnk36";
		array4[119] = "c_mnk40";
		array4[120] = "a_mnk40";
		array4[121] = "c_mnk41";
		array4[122] = "a_mnk41";
		array4[123] = "c_mnk42";
		array4[124] = "a_mnk42";
		array4[125] = "c_mnk47";
		array4[126] = "a_mnk47";
		array4[127] = "c_mnk48";
		array4[128] = "a_mnk48";
		array4[129] = "c_mnk50";
		array4[130] = "a_mnk50";
		array4[131] = "c_mnk51";
		array4[132] = "a_mnk51";
		array4[133] = "c_mnk52";
		array4[134] = "a_mnk52";
		array4[135] = "c_mnk60";
		array4[136] = "a_mnk60";
		array4[137] = "c_mnk61";
		array4[138] = "a_mnk61";
		array4[139] = "c_mnk62";
		array4[140] = "a_mnk62";
		array4[141] = "c_pgn10";
		array4[142] = "a_pgn10";
		array4[143] = "c_pgn11";
		array4[144] = "a_pgn11";
		array4[145] = "c_pgn12";
		array4[146] = "a_pgn12";
		array4[147] = "c_pgn21";
		array4[148] = "a_pgn21";
		array4[149] = "c_pgn22";
		array4[150] = "a_pgn22";
		array4[151] = "c_pgn23";
		array4[152] = "a_pgn23";
		array4[153] = "c_pgn24";
		array4[154] = "a_pgn24";
		array4[155] = "c_pgn31";
		array4[156] = "a_pgn31";
		array4[157] = "c_pgn32";
		array4[158] = "a_pgn32";
		array4[159] = "c_pgn33";
		array4[160] = "a_pgn33";
		array4[161] = "c_pgn34";
		array4[162] = "a_pgn34";
		array4[163] = "c_pgn36";
		array4[164] = "c_pgn40";
		array4[165] = "a_pgn40";
		array4[166] = "c_pgn41";
		array4[167] = "a_pgn41";
		array4[168] = "c_pgn42";
		array4[169] = "a_pgn42";
		array4[170] = "c_pgn47";
		array4[171] = "a_pgn47";
		array4[172] = "c_pgn48";
		array4[173] = "a_pgn48";
		array4[174] = "c_pgn50";
		array4[175] = "a_pgn50";
		array4[176] = "c_pgn51";
		array4[177] = "a_pgn51";
		array4[178] = "c_pgn52";
		array4[179] = "a_pgn52";
		array4[180] = "c_pgn60";
		array4[181] = "a_pgn60";
		array4[182] = "c_pgn61";
		array4[183] = "a_pgn61";
		array4[184] = "c_pgn62";
		array4[185] = "a_pgn62";
		array4[186] = "c_shp10";
		array4[187] = "a_shp10";
		array4[188] = "c_shp11";
		array4[189] = "a_shp11";
		array4[190] = "c_shp12";
		array4[191] = "a_shp12";
		array4[192] = "c_shp21";
		array4[193] = "a_shp21";
		array4[194] = "c_shp22";
		array4[195] = "a_shp22";
		array4[196] = "c_shp23";
		array4[197] = "a_shp23";
		array4[198] = "c_shp24";
		array4[199] = "a_shp24";
		array4[200] = "c_shp31";
		array4[201] = "a_shp31";
		array4[202] = "c_shp32";
		array4[203] = "a_shp32";
		array4[204] = "c_shp33";
		array4[205] = "a_shp33";
		array4[206] = "c_shp34";
		array4[207] = "a_shp34";
		array4[208] = "c_shp36";
		array4[209] = "c_shp40";
		array4[210] = "a_shp40";
		array4[211] = "c_shp41";
		array4[212] = "a_shp41";
		array4[213] = "c_shp42";
		array4[214] = "a_shp42";
		array4[215] = "c_shp47";
		array4[216] = "a_shp47";
		array4[217] = "c_shp48";
		array4[218] = "a_shp48";
		array4[219] = "c_shp50";
		array4[220] = "a_shp50";
		array4[221] = "c_shp51";
		array4[222] = "a_shp51";
		array4[223] = "c_shp52";
		array4[224] = "a_shp52";
		array4[225] = "c_shp60";
		array4[226] = "a_shp60";
		array4[227] = "c_shp61";
		array4[228] = "a_shp61";
		array4[229] = "c_shp62";
		array4[230] = "a_shp62";
		array4[231] = "c_bat10";
		array4[232] = "a_bat10";
		array4[233] = "c_bat11";
		array4[234] = "a_bat11";
		array4[235] = "c_bat12";
		array4[236] = "a_bat12";
		array4[237] = "c_bat21";
		array4[238] = "a_bat21";
		array4[239] = "c_bat22";
		array4[240] = "a_bat22";
		array4[241] = "c_bat23";
		array4[242] = "a_bat23";
		array4[243] = "c_bat24";
		array4[244] = "a_bat24";
		array4[245] = "c_bat31";
		array4[246] = "a_bat31";
		array4[247] = "c_bat32";
		array4[248] = "a_bat32";
		array4[249] = "c_bat33";
		array4[250] = "a_bat33";
		array4[251] = "c_bat34";
		array4[252] = "a_bat34";
		array4[253] = "c_bat36";
		array4[254] = "c_bat40";
		array4[255] = "a_bat40";
		array4[256] = "c_bat41";
		array4[257] = "a_bat41";
		array4[258] = "c_bat42";
		array4[259] = "a_bat42";
		array4[260] = "c_bat47";
		array4[261] = "a_bat47";
		array4[262] = "c_bat48";
		array4[263] = "a_bat48";
		array4[264] = "c_bat50";
		array4[265] = "a_bat50";
		array4[266] = "c_bat51";
		array4[267] = "a_bat51";
		array4[268] = "c_bat52";
		array4[269] = "a_bat52";
		array4[270] = "c_bat60";
		array4[271] = "a_bat60";
		array4[272] = "c_bat61";
		array4[273] = "a_bat61";
		array4[274] = "c_bat62";
		System.Array result = array4;
		array4[275] = "a_bat62";
		return result;
	}

	// Token: 0x06005D06 RID: 23814 RVA: 0x00C2A854 File Offset: 0x00C28A54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getKoalaList(int nRank)
	{
		if (256177 - 6271 != 249907)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_3E:
			if (nRank == 100)
			{
				if (154643 - 333575 != -178932)
				{
					continue;
				}
				if (Game.server >= 3)
				{
					goto IL_2F2;
				}
				if (138432 - 166449 != -28017)
				{
					continue;
				}
			}
			string[] array = new string[]
			{
				"d_brd1",
				"d_brd2",
				"d_bun1",
				"d_bun2",
				"d_bun3",
				"d_drk1",
				"d_drk2",
				"d_drk3",
				"d_drk4",
				"d_drk5",
				"d_drk6",
				"d_drk7",
				"d_drk8",
				"d_drk9",
				"d_ric1",
				"d_ric5",
				"d_snw1",
				"d_nod1",
				"d_nod5",
				"d_dst1",
				"d_dst2",
				"d_dst3",
				"d_dst4",
				"d_dst5",
				"d_dst6",
				"d_flr1",
				"d_mlk1",
				"d_sld1",
				"d_chs1",
				"d_cnd1",
				"d_spc1",
				"d_spc2",
				"d_spc3",
				"d_spc4",
				"d_src1",
				"d_src2",
				"d_src3"
			};
			if (265949 - 370134 != -104184)
			{
				array2 = new UnityScript.Lang.Array();
				if (13914 - 236253 == -222339)
				{
					int i = 0;
					if (200711 - 218951 == -18240)
					{
						string[] array3 = array;
						if (219929 - 77631 != 142299)
						{
							int length = array3.Length;
							if (2206 - 508638 != -506431)
							{
								while (i < length)
								{
									if (Mathf.Abs(ItemData.getLv(array3[i])) <= nRank + 10)
									{
										if (110083 - 179514 == -69430)
										{
											goto IL_3E;
										}
										array2.Add(array3[i]);
										if (166406 - 192219 != -25813)
										{
											goto IL_3E;
										}
									}
									i++;
									if (212371 - 138657 != 73714)
									{
										goto IL_3E;
									}
								}
								if (142855 - 17905 != 124951)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return array2.ToBuiltin(typeof(string));
		IL_2F2:
		string[] array4 = new string[157];
		array4[0] = "d_sop7";
		array4[1] = "d_sop8";
		array4[2] = "d_sop9";
		array4[3] = "d_grb1";
		array4[4] = "d_brd1";
		array4[5] = "d_brd2";
		array4[6] = "d_bun1";
		array4[7] = "d_bun2";
		array4[8] = "d_bun3";
		array4[9] = "d_cak1";
		array4[10] = "d_cak2";
		array4[11] = "d_cak3";
		array4[12] = "d_cak4";
		array4[13] = "d_cak5";
		array4[14] = "d_cak6";
		array4[15] = "d_drk1";
		array4[16] = "d_drk2";
		array4[17] = "d_drk3";
		array4[18] = "d_drk4";
		array4[19] = "d_drk5";
		array4[20] = "d_drk6";
		array4[21] = "d_drk7";
		array4[22] = "d_drk8";
		array4[23] = "d_drk9";
		array4[24] = "d_drk10";
		array4[25] = "d_drk11";
		array4[26] = "d_ric1";
		array4[27] = "d_ric2";
		array4[28] = "d_ric3";
		array4[29] = "d_ric4";
		array4[30] = "d_ric5";
		array4[31] = "d_ric6";
		array4[32] = "d_ric7";
		array4[33] = "d_ric8";
		array4[34] = "d_ric9";
		array4[35] = "d_ric10";
		array4[36] = "d_nod1";
		array4[37] = "d_nod2";
		array4[38] = "d_nod3";
		array4[39] = "d_nod4";
		array4[40] = "d_nod5";
		array4[41] = "d_nod6";
		array4[42] = "d_nod7";
		array4[43] = "d_nod8";
		array4[44] = "d_dst1";
		array4[45] = "d_dst2";
		array4[46] = "d_dst3";
		array4[47] = "d_dst4";
		array4[48] = "d_dst5";
		array4[49] = "d_dst6";
		array4[50] = "d_dst7";
		array4[51] = "d_dst8";
		array4[52] = "d_egg1";
		array4[53] = "d_egg2";
		array4[54] = "d_egg3";
		array4[55] = "d_egg4";
		array4[56] = "d_hrb1";
		array4[57] = "d_hrb2";
		array4[58] = "d_ice1";
		array4[59] = "d_flr1";
		array4[60] = "d_frt1";
		array4[61] = "d_frt2";
		array4[62] = "d_frt3";
		array4[63] = "d_frt4";
		array4[64] = "d_frt5";
		array4[65] = "d_frt6";
		array4[66] = "d_jar1";
		array4[67] = "d_jar2";
		array4[68] = "d_jar3";
		array4[69] = "d_met1";
		array4[70] = "d_met2";
		array4[71] = "d_met3";
		array4[72] = "d_met4";
		array4[73] = "d_met5";
		array4[74] = "d_met6";
		array4[75] = "d_met7";
		array4[76] = "d_met8";
		array4[77] = "d_met9";
		array4[78] = "d_met10";
		array4[79] = "d_met11";
		array4[80] = "d_met12";
		array4[81] = "d_met13";
		array4[82] = "d_mlk1";
		array4[83] = "d_tea1";
		array4[84] = "d_tea2";
		array4[85] = "d_tea3";
		array4[86] = "d_tea4";
		array4[87] = "d_tea5";
		array4[88] = "d_tea6";
		array4[89] = "d_tea7";
		array4[90] = "d_tea8";
		array4[91] = "d_nut1";
		array4[92] = "d_nut2";
		array4[93] = "d_oil1";
		array4[94] = "d_oil2";
		array4[95] = "d_oil3";
		array4[96] = "d_sld1";
		array4[97] = "d_sld2";
		array4[98] = "d_sld3";
		array4[99] = "d_sld4";
		array4[100] = "d_sld5";
		array4[101] = "d_snw1";
		array4[102] = "d_snw2";
		array4[103] = "d_snw3";
		array4[104] = "d_snw4";
		array4[105] = "d_snw5";
		array4[106] = "d_snw6";
		array4[107] = "d_sop1";
		array4[108] = "d_sop2";
		array4[109] = "d_sop3";
		array4[110] = "d_sop4";
		array4[111] = "d_sop5";
		array4[112] = "d_sop6";
		array4[113] = "d_sop7";
		array4[114] = "d_sop8";
		array4[115] = "d_sop9";
		array4[116] = "d_veg1";
		array4[117] = "d_veg2";
		array4[118] = "d_veg3";
		array4[119] = "d_veg4";
		array4[120] = "d_veg5";
		array4[121] = "d_veg6";
		array4[122] = "d_veg7";
		array4[123] = "d_veg8";
		array4[124] = "d_veg9";
		array4[125] = "d_veg10";
		array4[126] = "d_veg11";
		array4[127] = "d_veg12";
		array4[128] = "d_veg13";
		array4[129] = "d_veg14";
		array4[130] = "d_veg15";
		array4[131] = "d_veg16";
		array4[132] = "d_veg17";
		array4[133] = "d_veg18";
		array4[134] = "d_veg19";
		array4[135] = "d_snk1";
		array4[136] = "d_snk2";
		array4[137] = "d_chs1";
		array4[138] = "d_cnd1";
		array4[139] = "d_cnd2";
		array4[140] = "d_cnd3";
		array4[141] = "d_cnd4";
		array4[142] = "d_cnd5";
		array4[143] = "d_cnd6";
		array4[144] = "d_swd1";
		array4[145] = "d_swd2";
		array4[146] = "d_swd3";
		array4[147] = "d_spc1";
		array4[148] = "d_spc2";
		array4[149] = "d_spc3";
		array4[150] = "d_spc4";
		array4[151] = "d_spg1";
		array4[152] = "d_spg2";
		array4[153] = "d_spg3";
		array4[154] = "d_src1";
		array4[155] = "d_src2";
		System.Array result = array4;
		array4[156] = "d_src3";
		return result;
	}

	// Token: 0x06005D07 RID: 23815 RVA: 0x00C2B148 File Offset: 0x00C29348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getRaccoonList(int nRank)
	{
		if (11153 - 430965 != -419812)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_182:
			if (nRank == 100)
			{
				if (148535 - 198193 == -49657)
				{
					continue;
				}
				if (Game.server >= 3)
				{
					goto IL_1B9;
				}
				if (36222 - 227629 != -191407)
				{
					continue;
				}
			}
			string[] array = new string[]
			{
				"g_dec1",
				"g_dec2"
			};
			if (221687 - 537634 == -315947)
			{
				array2 = new UnityScript.Lang.Array();
				if (242220 - 39019 != 203202)
				{
					int i = 0;
					if (174134 - 496887 == -322753)
					{
						string[] array3 = array;
						if (100041 - 4332 == 95709)
						{
							int length = array3.Length;
							if (30257 - 448279 == -418022)
							{
								while (i < length)
								{
									if (ItemData.getLv(array3[i]) <= GuildData.Rank)
									{
										if (1990 - 352436 == -350445)
										{
											goto IL_182;
										}
										array2.Add(array3[i]);
										if (271254 - 265991 == 5264)
										{
											goto IL_182;
										}
									}
									i++;
									if (74794 - 67589 == 7206)
									{
										goto IL_182;
									}
								}
								if (92092 - 544783 == -452691)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return array2.ToBuiltin(typeof(string));
		IL_1B9:
		string[] array4 = new string[2];
		array4[0] = "g_dec1";
		System.Array result = array4;
		array4[1] = "g_dec2";
		return result;
	}

	// Token: 0x06005D08 RID: 23816 RVA: 0x00C2B33C File Offset: 0x00C2953C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getReindeerList(int nRank)
	{
		if (138884 - 22904 != 115980)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_576:
			if (nRank == 100)
			{
				if (181262 - 567156 != -385894)
				{
					continue;
				}
				if (Game.server >= 3)
				{
					goto IL_D5B;
				}
				if (231326 - 124731 != 106595)
				{
					continue;
				}
			}
			string[] array = new string[]
			{
				"r_rnw1",
				"r_rnw2",
				"r_rnw3",
				"r_rsl1",
				"r_rsl2",
				"r_rsl3",
				"r_asl1",
				"r_asl2",
				"r_asl3",
				"r_rpc1",
				"r_rpc2",
				"r_rpc3",
				"r_srd1",
				"r_atk1",
				"r_def1",
				"r_agi1",
				"r_vit1",
				"r_mag1",
				"r_cha1",
				"r_tal1",
				"r_lck1",
				"r_srd2",
				"r_atk2",
				"r_def2",
				"r_agi2",
				"r_vit2",
				"r_mag2",
				"r_cha2",
				"r_tal2",
				"r_lck2",
				"r_srd3",
				"r_atk3",
				"r_def3",
				"r_agi3",
				"r_vit3",
				"r_mag3",
				"r_cha3",
				"r_tal3",
				"r_lck3",
				"r_wlf9",
				"r_bsn9",
				"r_pnd9",
				"r_whl9",
				"r_cat9",
				"r_chm9",
				"r_rab9",
				"r_mol9",
				"r_mnk9",
				"r_pgn9",
				"r_shp9",
				"r_bat9",
				"r_wlf8",
				"r_bsn8",
				"r_pnd8",
				"r_whl8",
				"r_cat8",
				"r_chm8",
				"r_rab8",
				"r_mol8",
				"r_mnk8",
				"r_pgn8",
				"r_shp8",
				"r_bat8",
				"r_wlf6",
				"r_bsn6",
				"r_pnd6",
				"r_whl6",
				"r_cat6",
				"r_chm6",
				"r_rab6",
				"r_mol6",
				"r_mnk6",
				"r_pgn6",
				"r_shp6",
				"r_bat6",
				"r_wlf5",
				"r_bsn5",
				"r_pnd5",
				"r_whl5",
				"r_cat5",
				"r_chm5",
				"r_rab5",
				"r_mol5",
				"r_mnk5",
				"r_pgn5",
				"r_shp5",
				"r_bat5",
				"r_wlf4",
				"r_bsn4",
				"r_pnd4",
				"r_whl4",
				"r_cat4",
				"r_chm4",
				"r_rab4",
				"r_mol4",
				"r_mnk4",
				"r_pgn4",
				"r_shp4",
				"r_bat4",
				"r_wlf3",
				"r_bsn3",
				"r_pnd3",
				"r_whl3",
				"r_cat3",
				"r_chm3",
				"r_rab3",
				"r_mol3",
				"r_mnk3",
				"r_pgn3",
				"r_shp3",
				"r_bat3",
				"r_wlf2",
				"r_bsn2",
				"r_pnd2",
				"r_whl2",
				"r_cat2",
				"r_chm2",
				"r_rab2",
				"r_mol2",
				"r_mnk2",
				"r_pgn2",
				"r_shp2",
				"r_bat2",
				"r_wlf1",
				"r_bsn1",
				"r_pnd1",
				"r_whl1",
				"r_cat1",
				"r_chm1",
				"r_rab1",
				"r_mol1",
				"r_mnk1",
				"r_pgn1",
				"r_shp1",
				"r_bat1"
			};
			if (186534 - 252936 != -66401)
			{
				array2 = new UnityScript.Lang.Array();
				if (167040 - 284702 == -117662)
				{
					int i = 0;
					if (183988 - 165062 != 18927)
					{
						string[] array3 = array;
						if (127714 - 578204 == -450490)
						{
							int length = array3.Length;
							if (297674 - 178852 == 118822)
							{
								while (i < length)
								{
									if (Mathf.Abs(ItemData.getLv(array3[i])) <= nRank + 10)
									{
										if (71668 - 516317 == -444648)
										{
											goto IL_576;
										}
										if (PlayerPrefs.GetInt("usableItem", 1) != 0)
										{
											if (17396 - 270182 != -252786)
											{
												goto IL_576;
											}
											string a = array3[i].Trim().Substring(0, 5);
											if (238965 - 15494 != 223471)
											{
												goto IL_576;
											}
											if (a == "r_wlf")
											{
												if (278471 - 264095 == 14377)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Wolf")
												{
													if (153205 - 241307 != -88102)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (88717 - 100442 == -11724)
													{
														goto IL_576;
													}
												}
											}
											else if (a == "r_bsn")
											{
												if (65052 - 510814 != -445762)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Bison")
												{
													if (112306 - 297341 == -185034)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (210103 - 151405 == 58699)
													{
														goto IL_576;
													}
												}
											}
											else if (a == "r_pnd")
											{
												if (296468 - 741 != 295727)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Panda")
												{
													if (282206 - 559059 != -276853)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (210895 - 461668 == -250772)
													{
														goto IL_576;
													}
												}
											}
											else if (a == "r_whl")
											{
												if (66765 - 142373 == -75607)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Whale")
												{
													if (89704 - 442581 == -352876)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (106838 - 281188 == -174349)
													{
														goto IL_576;
													}
												}
											}
											else if (a == "r_cat")
											{
												if (102966 - 201241 == -98274)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Cat")
												{
													if (28075 - 402912 != -374837)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (258055 - 232130 == 25926)
													{
														goto IL_576;
													}
												}
											}
											else if (a == "r_chm")
											{
												if (97173 - 96726 != 447)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Chameleon")
												{
													if (4860 - 20561 == -15700)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (187849 - 327721 == -139871)
													{
														goto IL_576;
													}
												}
											}
											else if (a == "r_rab")
											{
												if (92128 - 332159 != -240031)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Rabbit")
												{
													if (107555 - 587997 != -480442)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (86247 - 103309 != -17062)
													{
														goto IL_576;
													}
												}
											}
											else if (a == "r_mol")
											{
												if (208101 - 146420 != 61681)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Mole")
												{
													if (211084 - 389686 != -178602)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (76780 - 573486 == -496705)
													{
														goto IL_576;
													}
												}
											}
											else if (a == "r_mnk")
											{
												if (292106 - 373399 == -81292)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Monkey")
												{
													if (248254 - 127381 == 120874)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (80509 - 205085 == -124575)
													{
														goto IL_576;
													}
												}
											}
											else if (a == "r_shp")
											{
												if (63653 - 544966 != -481313)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Sheep")
												{
													if (32686 - 389097 != -356411)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (137563 - 182195 == -44631)
													{
														goto IL_576;
													}
												}
											}
											else if (a == "r_pgn")
											{
												if (96591 - 147881 != -51290)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Penguin")
												{
													if (71577 - 27924 != 43653)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (208216 - 109616 != 98600)
													{
														goto IL_576;
													}
												}
											}
											else if (a == "r_bat")
											{
												if (190466 - 281253 == -90786)
												{
													goto IL_576;
												}
												if (CharacterData.current.Type == "Bat")
												{
													if (27095 - 572745 == -545649)
													{
														goto IL_576;
													}
													array2.Add(array3[i]);
													if (125193 - 311017 != -185824)
													{
														goto IL_576;
													}
												}
											}
											else
											{
												array2.Add(array3[i]);
												if (35823 - 494936 != -459113)
												{
													goto IL_576;
												}
											}
										}
										else
										{
											array2.Add(array3[i]);
											if (211030 - 88886 != 122144)
											{
												goto IL_576;
											}
										}
									}
									i++;
									if (186860 - 319669 != -132809)
									{
										goto IL_576;
									}
								}
								if (212583 - 324662 == -112079)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return array2.ToBuiltin(typeof(string));
		IL_D5B:
		string[] array4 = new string[148];
		array4[0] = "r_rnw1";
		array4[1] = "r_rsl1";
		array4[2] = "r_asl1";
		array4[3] = "r_rpc1";
		array4[4] = "r_rnw2";
		array4[5] = "r_rsl2";
		array4[6] = "r_asl2";
		array4[7] = "r_rpc2";
		array4[8] = "r_rnw3";
		array4[9] = "r_rsl3";
		array4[10] = "r_asl3";
		array4[11] = "r_rpc3";
		array4[12] = "r_srd1";
		array4[13] = "r_atk1";
		array4[14] = "r_def1";
		array4[15] = "r_agi1";
		array4[16] = "r_vit1";
		array4[17] = "r_mag1";
		array4[18] = "r_cha1";
		array4[19] = "r_tal1";
		array4[20] = "r_lck1";
		array4[21] = "r_srd1";
		array4[22] = "r_atk2";
		array4[23] = "r_def2";
		array4[24] = "r_agi2";
		array4[25] = "r_vit2";
		array4[26] = "r_mag2";
		array4[27] = "r_cha2";
		array4[28] = "r_tal2";
		array4[29] = "r_lck2";
		array4[30] = "r_srd3";
		array4[31] = "r_atk3";
		array4[32] = "r_def3";
		array4[33] = "r_agi3";
		array4[34] = "r_vit3";
		array4[35] = "r_mag3";
		array4[36] = "r_cha3";
		array4[37] = "r_tal3";
		array4[38] = "r_lck3";
		array4[39] = "r_wlf1";
		array4[40] = "r_bsn1";
		array4[41] = "r_pnd1";
		array4[42] = "r_whl1";
		array4[43] = "r_cat1";
		array4[44] = "r_chm1";
		array4[45] = "r_rab1";
		array4[46] = "r_mol1";
		array4[47] = "r_mnk1";
		array4[48] = "r_pgn1";
		array4[49] = "r_shp1";
		array4[50] = "r_bat1";
		array4[51] = "r_wlf2";
		array4[52] = "r_bsn2";
		array4[53] = "r_pnd2";
		array4[54] = "r_whl2";
		array4[55] = "r_cat2";
		array4[56] = "r_chm2";
		array4[57] = "r_rab2";
		array4[58] = "r_mol2";
		array4[59] = "r_mnk2";
		array4[60] = "r_pgn2";
		array4[61] = "r_shp2";
		array4[62] = "r_bat2";
		array4[63] = "r_wlf3";
		array4[64] = "r_bsn3";
		array4[65] = "r_pnd3";
		array4[66] = "r_whl3";
		array4[67] = "r_cat3";
		array4[68] = "r_chm3";
		array4[69] = "r_rab3";
		array4[70] = "r_mol3";
		array4[71] = "r_mnk3";
		array4[72] = "r_pgn3";
		array4[73] = "r_shp3";
		array4[74] = "r_bat3";
		array4[75] = "r_wlf4";
		array4[76] = "r_bsn4";
		array4[77] = "r_pnd4";
		array4[78] = "r_whl4";
		array4[79] = "r_cat4";
		array4[80] = "r_chm4";
		array4[81] = "r_rab4";
		array4[82] = "r_mol4";
		array4[83] = "r_mnk4";
		array4[84] = "r_pgn4";
		array4[85] = "r_shp4";
		array4[86] = "r_bat4";
		array4[87] = "r_wlf5";
		array4[88] = "r_bsn5";
		array4[89] = "r_pnd5";
		array4[90] = "r_whl5";
		array4[91] = "r_cat5";
		array4[92] = "r_chm5";
		array4[93] = "r_rab5";
		array4[94] = "r_mol5";
		array4[95] = "r_mnk5";
		array4[96] = "r_pgn5";
		array4[97] = "r_shp5";
		array4[98] = "r_bat5";
		array4[99] = "r_wlf6";
		array4[100] = "r_bsn6";
		array4[101] = "r_pnd6";
		array4[102] = "r_whl6";
		array4[103] = "r_cat6";
		array4[104] = "r_chm6";
		array4[105] = "r_rab6";
		array4[106] = "r_mol6";
		array4[107] = "r_mnk6";
		array4[108] = "r_pgn6";
		array4[109] = "r_shp6";
		array4[110] = "r_bat6";
		array4[111] = "r_wlf7";
		array4[112] = "r_bsn7";
		array4[113] = "r_pnd7";
		array4[114] = "r_whl7";
		array4[115] = "r_cat7";
		array4[116] = "r_chm7";
		array4[117] = "r_rab7";
		array4[118] = "r_mol7";
		array4[119] = "r_mnk7";
		array4[120] = "r_pgn7";
		array4[121] = "r_shp7";
		array4[122] = "r_bat7";
		array4[123] = "r_wlf8";
		array4[124] = "r_bsn8";
		array4[125] = "r_pnd8";
		array4[126] = "r_whl8";
		array4[127] = "r_cat8";
		array4[128] = "r_chm8";
		array4[129] = "r_rab8";
		array4[130] = "r_mol8";
		array4[131] = "r_mnk8";
		array4[132] = "r_pgn8";
		array4[133] = "r_shp8";
		array4[134] = "r_bat8";
		array4[135] = "r_wlf9";
		array4[136] = "r_bsn9";
		array4[137] = "r_pnd9";
		array4[138] = "r_whl9";
		array4[139] = "r_cat9";
		array4[140] = "r_chm9";
		array4[141] = "r_rab9";
		array4[142] = "r_mol9";
		array4[143] = "r_mnk9";
		array4[144] = "r_pgn9";
		array4[145] = "r_shp9";
		array4[146] = "r_bat9";
		System.Array result = array4;
		array4[147] = "r_all1";
		return result;
	}

	// Token: 0x06005D09 RID: 23817 RVA: 0x00C2C62C File Offset: 0x00C2A82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getCatFishList(int nRank)
	{
		if (100598 - 486144 != -385545)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_18E:
			if (nRank == 100)
			{
				if (229886 - 109678 != 120208)
				{
					continue;
				}
				if (Game.server >= 3)
				{
					goto IL_1C5;
				}
				if (33961 - 308732 != -274771)
				{
					continue;
				}
			}
			string[] array = new string[]
			{
				"k_gld1",
				"k_gld2",
				"k_gld3"
			};
			if (117739 - 410668 == -292929)
			{
				array2 = new UnityScript.Lang.Array();
				if (247232 - 268813 == -21581)
				{
					int i = 0;
					if (4439 - 54877 != -50437)
					{
						string[] array3 = array;
						if (108008 - 39141 == 68867)
						{
							int length = array3.Length;
							if (257114 - 491057 != -233942)
							{
								while (i < length)
								{
									if (Mathf.Abs(ItemData.getLv(array3[i])) <= nRank + 10)
									{
										if (205381 - 170537 == 34845)
										{
											goto IL_18E;
										}
										array2.Add(array3[i]);
										if (86065 - 575167 != -489102)
										{
											goto IL_18E;
										}
									}
									i++;
									if (67977 - 584811 != -516834)
									{
										goto IL_18E;
									}
								}
								if (228200 - 580907 != -352706)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return array2.ToBuiltin(typeof(string));
		IL_1C5:
		string[] array4 = new string[3];
		array4[0] = "k_gld1";
		array4[1] = "k_gld2";
		System.Array result = array4;
		array4[2] = "k_gld3";
		return result;
	}

	// Token: 0x06005D0A RID: 23818 RVA: 0x00C2C834 File Offset: 0x00C2AA34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getPantherList(int nRank)
	{
		if (73966 - 449247 != -375280)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_5BA:
			if (nRank == 100)
			{
				if (7238 - 471805 == -464566)
				{
					continue;
				}
				if (Game.server >= 3)
				{
					goto IL_5F1;
				}
				if (233455 - 401962 == -168506)
				{
					continue;
				}
			}
			string[] array = new string[]
			{
				"w_wlf58",
				"w_bsn58",
				"w_pnd58",
				"w_whl58",
				"w_cat58",
				"w_chm58",
				"w_rab58",
				"w_mol58",
				"w_mnk58",
				"w_pgn58",
				"w_shp58",
				"w_bat58",
				"a_all58",
				"c_all58",
				"w_wlf43",
				"w_wlf44",
				"w_bsn43",
				"w_bsn44",
				"w_pnd43",
				"w_pnd44",
				"w_whl43",
				"w_whl44",
				"w_cat43",
				"w_cat44",
				"w_chm43",
				"w_chm44",
				"w_rab43",
				"w_rab44",
				"w_mol43",
				"w_mol44",
				"w_mnk43",
				"w_mnk44",
				"w_pgn43",
				"w_pgn44",
				"w_shp43",
				"w_shp44",
				"w_bat43",
				"w_bat44",
				"c_all43",
				"a_all43",
				"c_all44",
				"a_all44",
				"t_all61",
				"t_all62",
				"t_all63",
				"f_rpb1",
				"f_rpb2",
				"f_rpb3",
				"f_rfc1",
				"f_rfc2",
				"f_rsc1",
				"f_rsc2",
				"f_rsc3",
				"f_rsc4",
				"f_rsc5",
				"f_lbs4",
				"f_lbs3",
				"f_lbs2",
				"f_lbs1",
				"f_mbs4",
				"f_mbs3",
				"f_mbs2",
				"f_mbs1",
				"f_sbs4",
				"f_sbs3",
				"f_sbs2",
				"f_sbs1",
				"f_ebs2",
				"f_ebs1",
				"f_wfg1",
				"f_wfg2",
				"f_wfg3",
				"f_wfg4",
				"m_asd5",
				"m_asd1",
				"m_asd2",
				"m_spm1"
			};
			if (184493 - 531220 != -346726)
			{
				array2 = new UnityScript.Lang.Array();
				if (177515 - 267432 != -89916)
				{
					int i = 0;
					if (296025 - 442964 == -146939)
					{
						string[] array3 = array;
						if (185030 - 442320 != -257289)
						{
							int length = array3.Length;
							if (178997 - 90233 == 88764)
							{
								while (i < length)
								{
									if (PlayerPrefs.GetInt("usableItem", 1) != 0)
									{
										if (293818 - 354311 == -60492)
										{
											goto IL_5BA;
										}
										string a = array3[i].Trim().Substring(0, 1);
										if (159497 - 449477 != -289979)
										{
											if (a == "w")
											{
												if (207881 - 556558 != -348676)
												{
													goto IL_C6;
												}
												goto IL_5BA;
											}
											else if (a == "a")
											{
												if (273397 - 286616 != -13218)
												{
													goto IL_C6;
												}
												goto IL_5BA;
											}
											else if (a == "c")
											{
												if (107396 - 505633 != -398236)
												{
													goto IL_4E4;
												}
												goto IL_5BA;
											}
											else if (a == "t")
											{
												if (221600 - 486021 != -264421)
												{
													goto IL_5BA;
												}
												goto IL_4E;
											}
											else if (Mathf.Abs(ItemData.getLv(array3[i])) <= nRank)
											{
												if (20696 - 549842 == -529145)
												{
													goto IL_5BA;
												}
												array2.Add(array3[i]);
												if (23523 - 181429 != -157906)
												{
													goto IL_5BA;
												}
											}
											IL_544:
											goto IL_7C;
											IL_4E:
											if (CharacterData.current.canEquip(array3[i]))
											{
												if (205183 - 509994 != -304811)
												{
													goto IL_5BA;
												}
												array2.Add(array3[i]);
												if (10539 - 74523 != -63984)
												{
													goto IL_5BA;
												}
											}
											goto IL_544;
											IL_4E4:
											goto IL_4E;
											IL_C6:
											goto IL_4E4;
										}
										goto IL_5BA;
									}
									else
									{
										array2.Add(array3[i]);
										if (208349 - 120841 == 87509)
										{
											goto IL_5BA;
										}
									}
									IL_7C:
									i++;
									if (85918 - 404773 == -318854)
									{
										goto IL_5BA;
									}
								}
								if (113941 - 379671 == -265730)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return array2.ToBuiltin(typeof(string));
		IL_5F1:
		string[] array4 = new string[78];
		array4[0] = "w_wlf58";
		array4[1] = "w_bsn58";
		array4[2] = "w_pnd58";
		array4[3] = "w_whl58";
		array4[4] = "w_cat58";
		array4[5] = "w_chm58";
		array4[6] = "w_rab58";
		array4[7] = "w_mol58";
		array4[8] = "w_mnk58";
		array4[9] = "w_pgn58";
		array4[10] = "w_shp58";
		array4[11] = "w_bat58";
		array4[12] = "a_all58";
		array4[13] = "c_all58";
		array4[14] = "w_wlf43";
		array4[15] = "w_wlf44";
		array4[16] = "w_bsn43";
		array4[17] = "w_bsn44";
		array4[18] = "w_pnd43";
		array4[19] = "w_pnd44";
		array4[20] = "w_whl43";
		array4[21] = "w_whl44";
		array4[22] = "w_cat43";
		array4[23] = "w_cat44";
		array4[24] = "w_chm43";
		array4[25] = "w_chm44";
		array4[26] = "w_rab43";
		array4[27] = "w_rab44";
		array4[28] = "w_mol43";
		array4[29] = "w_mol44";
		array4[30] = "w_mnk43";
		array4[31] = "w_mnk44";
		array4[32] = "w_pgn43";
		array4[33] = "w_pgn44";
		array4[34] = "w_shp43";
		array4[35] = "w_shp44";
		array4[36] = "w_bat43";
		array4[37] = "w_bat44";
		array4[38] = "c_all43";
		array4[39] = "a_all43";
		array4[40] = "c_all44";
		array4[41] = "a_all44";
		array4[42] = "t_all61";
		array4[43] = "t_all62";
		array4[44] = "t_all63";
		array4[45] = "f_rpb1";
		array4[46] = "f_rpb2";
		array4[47] = "f_rpb3";
		array4[48] = "f_rfc1";
		array4[49] = "f_rfc2";
		array4[50] = "f_rfc3";
		array4[51] = "f_rsc1";
		array4[52] = "f_rsc2";
		array4[53] = "f_rsc3";
		array4[54] = "f_rsc4";
		array4[55] = "f_rsc5";
		array4[56] = "f_lbs4";
		array4[57] = "f_lbs3";
		array4[58] = "f_lbs2";
		array4[59] = "f_lbs1";
		array4[60] = "f_mbs4";
		array4[61] = "f_mbs3";
		array4[62] = "f_mbs2";
		array4[63] = "f_mbs1";
		array4[64] = "f_sbs4";
		array4[65] = "f_sbs3";
		array4[66] = "f_sbs2";
		array4[67] = "f_sbs1";
		array4[68] = "f_ebs2";
		array4[69] = "f_ebs1";
		array4[70] = "f_wfg1";
		array4[71] = "f_wfg2";
		array4[72] = "f_wfg3";
		array4[73] = "f_wfg4";
		array4[74] = "m_asd1";
		array4[75] = "m_asd2";
		array4[76] = "m_asd5";
		System.Array result = array4;
		array4[77] = "m_spm1";
		return result;
	}

	// Token: 0x06005D0B RID: 23819 RVA: 0x00C2D104 File Offset: 0x00C2B304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getVersion()
	{
		return 555;
	}

	// Token: 0x06005D0C RID: 23820 RVA: 0x00C2D10C File Offset: 0x00C2B30C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005D0D RID: 23821 RVA: 0x00C2D110 File Offset: 0x00C2B310
	internal static bool nLZq9ipc5aJKp9kJv1W8()
	{
		return true;
	}

	// Token: 0x06005D0E RID: 23822 RVA: 0x00C2D114 File Offset: 0x00C2B314
	internal static bool hZHO4dpcpMXCbAV5cpPA()
	{
		return false;
	}
}
