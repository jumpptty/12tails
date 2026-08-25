using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000FBF RID: 4031
[Serializable]
public class CompoundData : MonoBehaviour
{
	// Token: 0x06005C10 RID: 23568 RVA: 0x00B43E8C File Offset: 0x00B4208C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompoundData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005C11 RID: 23569 RVA: 0x00B43E9C File Offset: 0x00B4209C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getWeaponRecipe()
	{
		if (170814 - 430494 != -259680)
		{
		}
		UnityScript.Lang.Array array;
		string[] result;
		for (;;)
		{
			IL_709:
			if (GuildData.Rank != 100)
			{
				if (8139 - 300944 == -292805)
				{
					array = new UnityScript.Lang.Array();
					if (233184 - 189311 != 43874)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.RecipeList);
						if (285598 - 551292 == -265694)
						{
							while (enumerator.MoveNext())
							{
								object value = enumerator.Current;
								int num = RuntimeServices.UnboxInt32(value);
								if (2707 - 224160 != -221453)
								{
									goto IL_709;
								}
								string text = null;
								if (140596 - 35512 == 105085)
								{
									goto IL_709;
								}
								int num2 = global::Math.div((float)num, (float)100);
								if (49074 - 344475 == -295400)
								{
									goto IL_709;
								}
								UnityRuntimeServices.Update(enumerator, num);
								if (167858 - 388375 != -220517)
								{
									goto IL_709;
								}
								if (num2 == 1)
								{
									if (221793 - 508789 != -286996)
									{
										goto IL_709;
									}
									text = "w_wlf" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (269688 - 168020 != 101668)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (44284 - 489986 == -445701)
									{
										goto IL_709;
									}
								}
								else if (num2 == 2)
								{
									if (132779 - 9752 == 123028)
									{
										goto IL_709;
									}
									text = "w_bsn" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (167436 - 334726 != -167290)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (118602 - 533216 != -414614)
									{
										goto IL_709;
									}
								}
								else if (num2 == 3)
								{
									if (217717 - 273925 != -56208)
									{
										goto IL_709;
									}
									text = "w_pnd" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (185617 - 257850 != -72233)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (126817 - 505036 == -378218)
									{
										goto IL_709;
									}
								}
								else if (num2 == 4)
								{
									if (219519 - 251345 != -31826)
									{
										goto IL_709;
									}
									text = "w_whl" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (250881 - 586033 == -335151)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (59156 - 177130 == -117973)
									{
										goto IL_709;
									}
								}
								else if (num2 == 5)
								{
									if (69604 - 520558 != -450954)
									{
										goto IL_709;
									}
									text = "w_cat" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (101475 - 165676 == -64200)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (142343 - 344840 == -202496)
									{
										goto IL_709;
									}
								}
								else if (num2 == 6)
								{
									if (150268 - 155181 == -4912)
									{
										goto IL_709;
									}
									text = "w_chm" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (266247 - 430306 != -164059)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (239167 - 436233 == -197065)
									{
										goto IL_709;
									}
								}
								else if (num2 == 7)
								{
									if (9148 - 293057 != -283909)
									{
										goto IL_709;
									}
									text = "w_rab" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (83396 - 118217 != -34821)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (260031 - 470758 == -210726)
									{
										goto IL_709;
									}
								}
								else if (num2 == 8)
								{
									if (88941 - 417655 == -328713)
									{
										goto IL_709;
									}
									text = "w_mol" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (218239 - 515758 != -297519)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (162847 - 545805 != -382958)
									{
										goto IL_709;
									}
								}
								else if (num2 == 9)
								{
									if (21501 - 107192 == -85690)
									{
										goto IL_709;
									}
									text = "w_mnk" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (23554 - 483901 != -460347)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (106512 - 306476 == -199963)
									{
										goto IL_709;
									}
								}
								else if (num2 == 10)
								{
									if (271059 - 381707 != -110648)
									{
										goto IL_709;
									}
									text = "w_pgn" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (34453 - 352311 == -317857)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (205646 - 302872 != -97226)
									{
										goto IL_709;
									}
								}
								else if (num2 == 11)
								{
									if (45465 - 245197 != -199732)
									{
										goto IL_709;
									}
									text = "w_shp" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (134809 - 123849 == 10961)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (62109 - 26593 != 35516)
									{
										goto IL_709;
									}
								}
								else if (num2 == 12)
								{
									if (56477 - 590450 != -533973)
									{
										goto IL_709;
									}
									text = "w_bat" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (103110 - 551507 == -448396)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (238602 - 289980 == -51377)
									{
										goto IL_709;
									}
								}
								else if (num2 == 15)
								{
									if (233031 - 489786 != -256755)
									{
										goto IL_709;
									}
									int num3 = num % 100;
									if (46021 - 123188 == -77166)
									{
										goto IL_709;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (17429 - 7847 == 9583)
									{
										goto IL_709;
									}
									if (num3 == 1)
									{
										if (124203 - 365176 == -240972)
										{
											goto IL_709;
										}
										array.Add("w_wlf69");
										if (222685 - 118750 == 103936)
										{
											goto IL_709;
										}
										array.Add("w_bsn69");
										if (34857 - 341478 != -306621)
										{
											goto IL_709;
										}
										array.Add("w_pnd69");
										if (23639 - 590658 != -567019)
										{
											goto IL_709;
										}
										array.Add("w_whl69");
										if (271299 - 344759 != -73460)
										{
											goto IL_709;
										}
										array.Add("w_cat69");
										if (29279 - 558953 == -529673)
										{
											goto IL_709;
										}
										array.Add("w_chm69");
										if (219588 - 156880 != 62708)
										{
											goto IL_709;
										}
										array.Add("w_rab69");
										if (67071 - 330723 == -263651)
										{
											goto IL_709;
										}
										array.Add("w_mol69");
										if (207406 - 244667 != -37261)
										{
											goto IL_709;
										}
										array.Add("w_mnk69");
										if (15759 - 207132 == -191372)
										{
											goto IL_709;
										}
										array.Add("w_pgn69");
										if (114322 - 583670 == -469347)
										{
											goto IL_709;
										}
										array.Add("w_shp69");
										if (32194 - 26434 != 5760)
										{
											goto IL_709;
										}
										array.Add("w_bat69");
										if (299450 - 80726 != 218724)
										{
											goto IL_709;
										}
									}
								}
								if (CompoundData.getMaterial(text) != "none")
								{
									if (295460 - 141844 == 153617)
									{
										goto IL_709;
									}
									array.Add(text);
									if (29162 - 540239 != -511077)
									{
										goto IL_709;
									}
								}
							}
							if (99040 - 208457 == -109417)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				result = new string[]
				{
					"w_wlf11",
					"w_wlf23",
					"w_wlf24",
					"w_wlf33",
					"w_wlf34",
					"w_wlf41",
					"w_wlf47",
					"w_wlf51",
					"w_wlf61",
					"w_wlf69",
					"w_bsn11",
					"w_bsn23",
					"w_bsn24",
					"w_bsn33",
					"w_bsn34",
					"w_bsn41",
					"w_bsn47",
					"w_bsn51",
					"w_bsn61",
					"w_bsn69",
					"w_pnd11",
					"w_pnd23",
					"w_pnd24",
					"w_pnd33",
					"w_pnd34",
					"w_pnd41",
					"w_pnd47",
					"w_pnd51",
					"w_pnd61",
					"w_pnd69",
					"w_whl11",
					"w_whl23",
					"w_whl24",
					"w_whl33",
					"w_whl34",
					"w_whl41",
					"w_whl47",
					"w_whl51",
					"w_whl61",
					"w_whl69",
					"w_cat11",
					"w_cat23",
					"w_cat24",
					"w_cat33",
					"w_cat34",
					"w_cat41",
					"w_cat47",
					"w_cat51",
					"w_cat61",
					"w_cat69",
					"w_chm11",
					"w_chm23",
					"w_chm24",
					"w_chm33",
					"w_chm34",
					"w_chm41",
					"w_chm47",
					"w_chm51",
					"w_chm61",
					"w_chm69",
					"w_rab11",
					"w_rab23",
					"w_rab24",
					"w_rab33",
					"w_rab34",
					"w_rab41",
					"w_rab47",
					"w_rab51",
					"w_rab61",
					"w_rab69",
					"w_mol11",
					"w_mol23",
					"w_mol24",
					"w_mol33",
					"w_mol34",
					"w_mol41",
					"w_mol47",
					"w_mol51",
					"w_mol61",
					"w_mol69",
					"w_mnk11",
					"w_mnk23",
					"w_mnk24",
					"w_mnk33",
					"w_mnk34",
					"w_mnk41",
					"w_mnk47",
					"w_mnk51",
					"w_mnk61",
					"w_mnk69",
					"w_pgn11",
					"w_pgn23",
					"w_pgn24",
					"w_pgn33",
					"w_pgn34",
					"w_pgn41",
					"w_pgn47",
					"w_pgn51",
					"w_pgn61",
					"w_pgn69",
					"w_shp11",
					"w_shp23",
					"w_shp24",
					"w_shp33",
					"w_shp34",
					"w_shp41",
					"w_shp47",
					"w_shp51",
					"w_shp61",
					"w_shp69",
					"w_bat11",
					"w_bat23",
					"w_bat24",
					"w_bat33",
					"w_bat34",
					"w_bat41",
					"w_bat47",
					"w_bat51",
					"w_bat61",
					"w_bat69"
				};
				if (256912 - 344074 == -87162)
				{
					goto IL_E51;
				}
			}
		}
		return array.Sort().ToBuiltin(typeof(string));
		IL_E51:
		return result;
	}

	// Token: 0x06005C12 RID: 23570 RVA: 0x00B44D14 File Offset: 0x00B42F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getArmorRecipe()
	{
		if (297457 - 291088 != 6370)
		{
		}
		UnityScript.Lang.Array array;
		string[] result;
		for (;;)
		{
			IL_9A0:
			if (GuildData.Rank != 100)
			{
				if (200241 - 573163 != -372921)
				{
					array = new UnityScript.Lang.Array();
					if (257668 - 327568 != -69899)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.RecipeList);
						if (281551 - 108918 != 172634)
						{
							while (enumerator.MoveNext())
							{
								object value = enumerator.Current;
								int num = RuntimeServices.UnboxInt32(value);
								if (247811 - 104269 != 143542)
								{
									goto IL_9A0;
								}
								string text = null;
								if (77951 - 102395 != -24444)
								{
									goto IL_9A0;
								}
								int num2 = global::Math.div((float)num, (float)100);
								if (205243 - 471969 != -266726)
								{
									goto IL_9A0;
								}
								UnityRuntimeServices.Update(enumerator, num);
								if (238074 - 162048 == 76027)
								{
									goto IL_9A0;
								}
								if (num2 == 1)
								{
									if (225677 - 176751 == 48927)
									{
										goto IL_9A0;
									}
									text = "a_wlf" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (152721 - 530094 == -377372)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (209083 - 381102 != -172019)
									{
										goto IL_9A0;
									}
								}
								else if (num2 == 2)
								{
									if (155522 - 258279 == -102756)
									{
										goto IL_9A0;
									}
									text = "a_bsn" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (253359 - 547678 == -294318)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (227240 - 303286 == -76045)
									{
										goto IL_9A0;
									}
								}
								else if (num2 == 3)
								{
									if (128263 - 543296 == -415032)
									{
										goto IL_9A0;
									}
									text = "a_pnd" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (90133 - 442722 == -352588)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (81074 - 165155 == -84080)
									{
										goto IL_9A0;
									}
								}
								else if (num2 == 4)
								{
									if (20047 - 104083 != -84036)
									{
										goto IL_9A0;
									}
									text = "a_whl" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (209662 - 281995 != -72333)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (189182 - 224774 == -35591)
									{
										goto IL_9A0;
									}
								}
								else if (num2 == 5)
								{
									if (96952 - 320306 != -223354)
									{
										goto IL_9A0;
									}
									text = "a_cat" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (262756 - 261090 != 1666)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (100994 - 278414 != -177420)
									{
										goto IL_9A0;
									}
								}
								else if (num2 == 6)
								{
									if (16744 - 100125 == -83380)
									{
										goto IL_9A0;
									}
									text = "a_chm" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (138648 - 131067 == 7582)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (259758 - 96340 != 163418)
									{
										goto IL_9A0;
									}
								}
								else if (num2 == 7)
								{
									if (102353 - 458146 == -355792)
									{
										goto IL_9A0;
									}
									text = "a_rab" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (225015 - 106859 == 118157)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (244599 - 27181 == 217419)
									{
										goto IL_9A0;
									}
								}
								else if (num2 == 8)
								{
									if (132012 - 254527 != -122515)
									{
										goto IL_9A0;
									}
									text = "a_mol" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (95599 - 47296 != 48303)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (4950 - 475459 != -470509)
									{
										goto IL_9A0;
									}
								}
								else if (num2 == 9)
								{
									if (229659 - 31293 != 198366)
									{
										goto IL_9A0;
									}
									text = "a_mnk" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (238608 - 468473 == -229864)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (232407 - 549738 == -317330)
									{
										goto IL_9A0;
									}
								}
								else if (num2 == 10)
								{
									if (254859 - 337314 == -82454)
									{
										goto IL_9A0;
									}
									text = "a_pgn" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (121507 - 245289 == -123781)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (185125 - 311872 != -126747)
									{
										goto IL_9A0;
									}
								}
								else if (num2 == 11)
								{
									if (229821 - 342774 != -112953)
									{
										goto IL_9A0;
									}
									text = "a_shp" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (258548 - 562648 != -304100)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (294791 - 80350 == 214442)
									{
										goto IL_9A0;
									}
								}
								else if (num2 == 12)
								{
									if (30382 - 346672 == -316289)
									{
										goto IL_9A0;
									}
									text = "a_bat" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (220711 - 480041 != -259330)
									{
										goto IL_9A0;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (25198 - 39220 == -14021)
									{
										goto IL_9A0;
									}
								}
								if (CompoundData.getMaterial(text) != "none")
								{
									if (279447 - 595586 == -316138)
									{
										goto IL_9A0;
									}
									array.Add(text);
									if (247765 - 330749 == -82983)
									{
										goto IL_9A0;
									}
								}
							}
							if (82196 - 592923 == -510727)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				result = new string[]
				{
					"a_wlf11",
					"a_wlf23",
					"a_wlf24",
					"a_wlf33",
					"a_wlf34",
					"a_wlf41",
					"a_wlf47",
					"a_wlf51",
					"a_wlf61",
					"a_bsn11",
					"a_bsn23",
					"a_bsn24",
					"a_bsn33",
					"a_bsn34",
					"a_bsn41",
					"a_bsn47",
					"a_bsn51",
					"a_bsn61",
					"a_pnd11",
					"a_pnd23",
					"a_pnd24",
					"a_pnd33",
					"a_pnd34",
					"a_pnd41",
					"a_pnd47",
					"a_pnd51",
					"a_pnd61",
					"a_whl11",
					"a_whl23",
					"a_whl24",
					"a_whl33",
					"a_whl34",
					"a_whl41",
					"a_whl47",
					"a_whl51",
					"a_whl61",
					"a_cat11",
					"a_cat23",
					"a_cat24",
					"a_cat33",
					"a_cat34",
					"a_cat41",
					"a_cat47",
					"a_cat51",
					"a_cat61",
					"a_chm11",
					"a_chm23",
					"a_chm24",
					"a_chm33",
					"a_chm34",
					"a_chm41",
					"a_chm47",
					"a_chm51",
					"a_chm61",
					"a_rab11",
					"a_rab23",
					"a_rab24",
					"a_rab33",
					"a_rab34",
					"a_rab41",
					"a_rab47",
					"a_rab51",
					"a_rab61",
					"a_mol11",
					"a_mol23",
					"a_mol24",
					"a_mol33",
					"a_mol34",
					"a_mol41",
					"a_mol47",
					"a_mol51",
					"a_mol61",
					"a_mnk11",
					"a_mnk23",
					"a_mnk24",
					"a_mnk33",
					"a_mnk34",
					"a_mnk41",
					"a_mnk47",
					"a_mnk51",
					"a_mnk61",
					"a_pgn11",
					"a_pgn23",
					"a_pgn24",
					"a_pgn33",
					"a_pgn34",
					"a_pgn41",
					"a_pgn47",
					"a_pgn51",
					"a_pgn61",
					"a_shp11",
					"a_shp23",
					"a_shp24",
					"a_shp33",
					"a_shp34",
					"a_shp41",
					"a_shp47",
					"a_shp51",
					"a_shp61",
					"a_bat11",
					"a_bat23",
					"a_bat24",
					"a_bat33",
					"a_bat34",
					"a_bat41",
					"a_bat47",
					"a_bat51",
					"a_bat61"
				};
				if (36799 - 283921 == -247122)
				{
					goto IL_B94;
				}
			}
		}
		return array.Sort().ToBuiltin(typeof(string));
		IL_B94:
		return result;
	}

	// Token: 0x06005C13 RID: 23571 RVA: 0x00B458D0 File Offset: 0x00B43AD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getAccessoryRecipe()
	{
		if (247917 - 148479 != 99438)
		{
		}
		UnityScript.Lang.Array array;
		string[] result;
		for (;;)
		{
			IL_6D2:
			if (GuildData.Rank != 100)
			{
				if (10947 - 398036 != -387088)
				{
					array = new UnityScript.Lang.Array();
					if (215744 - 23993 != 191752)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.RecipeList);
						if (38441 - 173005 != -134563)
						{
							while (enumerator.MoveNext())
							{
								object value = enumerator.Current;
								int num = RuntimeServices.UnboxInt32(value);
								if (9741 - 159419 != -149678)
								{
									goto IL_6D2;
								}
								string text = null;
								if (176424 - 526091 != -349667)
								{
									goto IL_6D2;
								}
								int num2 = global::Math.div((float)num, (float)100);
								if (215171 - 155714 != 59457)
								{
									goto IL_6D2;
								}
								UnityRuntimeServices.Update(enumerator, num);
								if (259048 - 330253 == -71204)
								{
									goto IL_6D2;
								}
								if (num2 == 1)
								{
									if (177607 - 87984 == 89624)
									{
										goto IL_6D2;
									}
									text = "c_wlf" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (103611 - 435309 != -331698)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (146553 - 277859 != -131306)
									{
										goto IL_6D2;
									}
								}
								else if (num2 == 2)
								{
									if (299432 - 588888 == -289455)
									{
										goto IL_6D2;
									}
									text = "c_bsn" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (66348 - 509514 != -443166)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (248777 - 66152 == 182626)
									{
										goto IL_6D2;
									}
								}
								else if (num2 == 3)
								{
									if (246596 - 200740 != 45856)
									{
										goto IL_6D2;
									}
									text = "c_pnd" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (268590 - 207018 != 61572)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (187768 - 491969 == -304200)
									{
										goto IL_6D2;
									}
								}
								else if (num2 == 4)
								{
									if (267972 - 346739 == -78766)
									{
										goto IL_6D2;
									}
									text = "c_whl" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (207773 - 35594 == 172180)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (214849 - 227144 == -12294)
									{
										goto IL_6D2;
									}
								}
								else if (num2 == 5)
								{
									if (27857 - 48161 == -20303)
									{
										goto IL_6D2;
									}
									text = "c_cat" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (204264 - 348064 == -143799)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (280039 - 116824 != 163215)
									{
										goto IL_6D2;
									}
								}
								else if (num2 == 6)
								{
									if (263064 - 421430 != -158366)
									{
										goto IL_6D2;
									}
									text = "c_chm" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (207598 - 327615 == -120016)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (50076 - 408211 == -358134)
									{
										goto IL_6D2;
									}
								}
								else if (num2 == 7)
								{
									if (107437 - 402098 == -294660)
									{
										goto IL_6D2;
									}
									text = "c_rab" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (18328 - 85936 == -67607)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (207111 - 378516 != -171405)
									{
										goto IL_6D2;
									}
								}
								else if (num2 == 8)
								{
									if (656 - 189176 != -188520)
									{
										goto IL_6D2;
									}
									text = "c_mol" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (4950 - 297669 != -292719)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (150990 - 185429 != -34439)
									{
										goto IL_6D2;
									}
								}
								else if (num2 == 9)
								{
									if (255575 - 356703 == -101127)
									{
										goto IL_6D2;
									}
									text = "c_mnk" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (10970 - 247022 == -236051)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (285276 - 73723 == 211554)
									{
										goto IL_6D2;
									}
								}
								else if (num2 == 10)
								{
									if (77407 - 479701 == -402293)
									{
										goto IL_6D2;
									}
									text = "c_pgn" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (285063 - 521878 == -236814)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (122798 - 342754 == -219955)
									{
										goto IL_6D2;
									}
								}
								else if (num2 == 11)
								{
									if (158362 - 382525 == -224162)
									{
										goto IL_6D2;
									}
									text = "c_shp" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (90521 - 517397 != -426876)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (253373 - 229113 != 24260)
									{
										goto IL_6D2;
									}
								}
								else if (num2 == 12)
								{
									if (187852 - 470162 != -282310)
									{
										goto IL_6D2;
									}
									text = "c_bat" + CompoundData.getRecipeEquipmentLv(num % 100);
									if (235805 - 85 != 235720)
									{
										goto IL_6D2;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (298067 - 570176 == -272108)
									{
										goto IL_6D2;
									}
								}
								if (CompoundData.getMaterial(text) != "none")
								{
									if (224523 - 334769 != -110246)
									{
										goto IL_6D2;
									}
									array.Add(text);
									if (45098 - 89893 == -44794)
									{
										goto IL_6D2;
									}
								}
							}
							if (153013 - 287144 != -134130)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				result = new string[]
				{
					"c_wlf11",
					"c_wlf23",
					"c_wlf24",
					"c_wlf33",
					"c_wlf34",
					"c_wlf41",
					"c_wlf47",
					"c_wlf51",
					"c_wlf61",
					"c_bsn23",
					"c_bsn24",
					"c_bsn33",
					"c_bsn34",
					"c_bsn41",
					"c_bsn47",
					"c_bsn51",
					"c_bsn61",
					"c_pnd23",
					"c_pnd24",
					"c_pnd33",
					"c_pnd34",
					"c_pnd41",
					"c_pnd47",
					"c_pnd51",
					"c_pnd61",
					"c_whl23",
					"c_whl24",
					"c_whl33",
					"c_whl34",
					"c_whl41",
					"c_whl47",
					"c_whl51",
					"c_whl61",
					"c_cat11",
					"c_cat23",
					"c_cat24",
					"c_cat33",
					"c_cat34",
					"c_cat41",
					"c_cat47",
					"c_cat51",
					"c_cat61",
					"c_chm11",
					"c_chm23",
					"c_chm24",
					"c_chm33",
					"c_chm34",
					"c_chm41",
					"c_chm47",
					"c_chm51",
					"c_chm61",
					"c_rab11",
					"c_rab23",
					"c_rab24",
					"c_rab33",
					"c_rab34",
					"c_rab41",
					"c_rab47",
					"c_rab51",
					"c_rab61",
					"c_mol11",
					"c_mol23",
					"c_mol24",
					"c_mol33",
					"c_mol34",
					"c_mol41",
					"c_mol47",
					"c_mol51",
					"c_mol61",
					"c_mnk11",
					"c_mnk23",
					"c_mnk24",
					"c_mnk33",
					"c_mnk34",
					"c_mnk41",
					"c_mnk47",
					"c_mnk51",
					"c_mnk61",
					"c_pgn11",
					"c_pgn23",
					"c_pgn24",
					"c_pgn33",
					"c_pgn34",
					"c_pgn41",
					"c_pgn47",
					"c_pgn51",
					"c_pgn61",
					"c_shp23",
					"c_shp24",
					"c_shp33",
					"c_shp34",
					"c_shp41",
					"c_shp41",
					"c_shp47",
					"c_shp51",
					"c_shp61",
					"c_bat23",
					"c_bat24",
					"c_bat33",
					"c_bat34",
					"c_bat41",
					"c_bat41",
					"c_bat47",
					"c_bat51",
					"c_bat61"
				};
				if (58548 - 76699 == -18151)
				{
					goto IL_B79;
				}
			}
		}
		return array.Sort().ToBuiltin(typeof(string));
		IL_B79:
		return result;
	}

	// Token: 0x06005C14 RID: 23572 RVA: 0x00B46470 File Offset: 0x00B44670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] getMaterialRecipe()
	{
		return new string[]
		{
			"m_zin2",
			"m_zin3",
			"m_cop2",
			"m_cop3",
			"m_irn2",
			"m_irn3",
			"m_sil2",
			"m_sil3",
			"m_gld2",
			"m_gld3",
			"m_spo1",
			"m_spo5",
			"m_pin1",
			"m_pin2",
			"m_pin3",
			"m_gle2",
			"m_gle3",
			"m_gle4",
			"m_pap1",
			"m_pap2",
			"m_pap3",
			"m_fab3",
			"m_fab4",
			"m_fab5",
			"m_fab6",
			"m_fab7",
			"m_fab8",
			"m_lth4",
			"m_orb2",
			"m_orb3",
			"m_orb4",
			"m_orb5",
			"m_orb7",
			"m_orb8",
			"m_flw7",
			"m_wmt1",
			"m_wmt2",
			"m_wmt3",
			"m_wmt4",
			"m_wmt5",
			"m_wmt6",
			"m_wmt9",
			"m_wmt10",
			"m_wmt11",
			"m_wmt12",
			"m_wmt13",
			"m_wmt14",
			"m_wmt15",
			"m_wmt16",
			"m_wmt17",
			"m_wmt18",
			"m_amt4",
			"m_amt5",
			"m_amt9",
			"m_amt10",
			"m_amt11",
			"m_amt12",
			"m_amt14",
			"m_amt15",
			"m_amt16",
			"m_amt17",
			"m_amt18",
			"m_amt19",
			"m_amt20",
			"m_flt1",
			"m_kbt1",
			"m_spm2"
		};
	}

	// Token: 0x06005C15 RID: 23573 RVA: 0x00B466D8 File Offset: 0x00B448D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Array getSpecialRecipe()
	{
		if (251036 - 188862 != 62174)
		{
		}
		UnityScript.Lang.Array array;
		string[] result;
		for (;;)
		{
			IL_126:
			if (GuildData.Rank != 100)
			{
				if (273904 - 301646 == -27742)
				{
					array = new UnityScript.Lang.Array();
					if (209776 - 302541 != -92764)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.RecipeList);
						if (239298 - 256998 == -17700)
						{
							while (enumerator.MoveNext())
							{
								object value = enumerator.Current;
								int num = RuntimeServices.UnboxInt32(value);
								if (42067 - 268384 == -226316)
								{
									goto IL_126;
								}
								string text = null;
								if (70439 - 117015 == -46575)
								{
									goto IL_126;
								}
								int num2 = global::Math.div((float)num, (float)10);
								if (48149 - 470710 == -422560)
								{
									goto IL_126;
								}
								UnityRuntimeServices.Update(enumerator, num);
								if (184283 - 18137 != 166146)
								{
									goto IL_126;
								}
								if (num2 == 131)
								{
									if (193786 - 117284 == 76503)
									{
										goto IL_126;
									}
									text = "s_rnw" + num % 10;
									if (135473 - 144229 != -8756)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (203876 - 23651 == 180226)
									{
										goto IL_126;
									}
								}
								else if (num2 == 132)
								{
									if (51673 - 175233 == -123559)
									{
										goto IL_126;
									}
									text = "s_rsl" + num % 10;
									if (274537 - 11982 != 262555)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (149743 - 432394 == -282650)
									{
										goto IL_126;
									}
								}
								else if (num2 == 133)
								{
									if (26251 - 205643 == -179391)
									{
										goto IL_126;
									}
									text = "s_asl" + num % 10;
									if (101970 - 279988 == -178017)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (298081 - 426761 != -128680)
									{
										goto IL_126;
									}
								}
								else if (num2 == 134)
								{
									if (11216 - 38154 == -26937)
									{
										goto IL_126;
									}
									text = "s_rpc" + num % 10;
									if (6114 - 369726 == -363611)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (231566 - 298206 != -66640)
									{
										goto IL_126;
									}
								}
								else if (num2 == 140)
								{
									if (60608 - 84965 != -24357)
									{
										goto IL_126;
									}
									text = "s_srd" + num % 10;
									if (52811 - 523502 != -470691)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (248712 - 299481 != -50769)
									{
										goto IL_126;
									}
								}
								else if (num2 == 141)
								{
									if (236599 - 457585 == -220985)
									{
										goto IL_126;
									}
									text = "s_atk" + num % 10;
									if (22235 - 552960 != -530725)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (228294 - 62748 != 165546)
									{
										goto IL_126;
									}
								}
								else if (num2 == 142)
								{
									if (267405 - 211431 != 55974)
									{
										goto IL_126;
									}
									text = "s_def" + num % 10;
									if (85683 - 491329 == -405645)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (186466 - 133399 == 53068)
									{
										goto IL_126;
									}
								}
								else if (num2 == 143)
								{
									if (168321 - 526444 != -358123)
									{
										goto IL_126;
									}
									text = "s_agi" + num % 10;
									if (298363 - 229762 != 68601)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (135301 - 223333 == -88031)
									{
										goto IL_126;
									}
								}
								else if (num2 == 144)
								{
									if (258108 - 21707 == 236402)
									{
										goto IL_126;
									}
									text = "s_vit" + num % 10;
									if (52775 - 572586 == -519810)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (298304 - 364421 != -66117)
									{
										goto IL_126;
									}
								}
								else if (num2 == 145)
								{
									if (252250 - 161399 == 90852)
									{
										goto IL_126;
									}
									text = "s_mag" + num % 10;
									if (103439 - 319293 == -215853)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (240801 - 414883 == -174081)
									{
										goto IL_126;
									}
								}
								else if (num2 == 146)
								{
									if (220540 - 407971 != -187431)
									{
										goto IL_126;
									}
									text = "s_cha" + num % 10;
									if (265495 - 492778 == -227282)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (89577 - 516716 != -427139)
									{
										goto IL_126;
									}
								}
								else if (num2 == 147)
								{
									if (67461 - 579735 == -512273)
									{
										goto IL_126;
									}
									text = "s_tal" + num % 10;
									if (295272 - 173629 != 121643)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (10230 - 177413 == -167182)
									{
										goto IL_126;
									}
								}
								else if (num2 == 148)
								{
									if (282111 - 112331 != 169780)
									{
										goto IL_126;
									}
									text = "s_lck" + num % 10;
									if (225744 - 489721 != -263977)
									{
										goto IL_126;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (272615 - 141819 != 130796)
									{
										goto IL_126;
									}
								}
								if (CompoundData.getMaterial(text) != "none")
								{
									if (92168 - 395637 == -303468)
									{
										goto IL_126;
									}
									array.Add(text);
									if (87454 - 116282 != -28828)
									{
										goto IL_126;
									}
								}
							}
							if (138639 - 140103 == -1464)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				result = new string[]
				{
					"s_rnw1",
					"s_rnw2",
					"s_rnw3",
					"s_rsl1",
					"s_rsl2",
					"s_rsl3",
					"s_asl1",
					"s_asl2",
					"s_rpc1",
					"s_rpc2",
					"s_atk1",
					"s_atk2",
					"s_atk3",
					"s_def1",
					"s_def2",
					"s_def3",
					"s_agi1",
					"s_agi2",
					"s_agi3",
					"s_vit1",
					"s_vit2",
					"s_vit3",
					"s_mag1",
					"s_mag2",
					"s_mag3",
					"s_cha1",
					"s_cha2",
					"s_cha3",
					"s_tal1",
					"s_tal2",
					"s_tal3",
					"s_lck1",
					"s_lck2",
					"s_lck2"
				};
				if (245456 - 505471 == -260015)
				{
					goto IL_969;
				}
			}
		}
		return array.Sort().ToBuiltin(typeof(string));
		IL_969:
		return result;
	}

	// Token: 0x06005C16 RID: 23574 RVA: 0x00B47068 File Offset: 0x00B45268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getRecipeEquipmentLv(int nCode)
	{
		if (239482 - 273668 != -34186)
		{
		}
		int result;
		for (;;)
		{
			result = 0;
			if (153447 - 338001 != -184553)
			{
				if (267989 - 560074 == -292085)
				{
					if (nCode == 1)
					{
						if (46261 - 439850 == -393589)
						{
							result = 11;
							if (43662 - 481411 == -437749)
							{
								break;
							}
						}
					}
					else if (nCode == 2)
					{
						if (141910 - 179056 != -37145)
						{
							result = 23;
							if (186945 - 79054 == 107891)
							{
								break;
							}
						}
					}
					else if (nCode == 3)
					{
						if (274530 - 158914 != 115617)
						{
							result = 24;
							if (10668 - 456411 == -445743)
							{
								break;
							}
						}
					}
					else if (nCode == 4)
					{
						if (191532 - 297628 == -106096)
						{
							result = 33;
							if (11146 - 107238 != -96091)
							{
								break;
							}
						}
					}
					else if (nCode == 5)
					{
						if (168764 - 300002 == -131238)
						{
							result = 34;
							if (180599 - 44876 == 135723)
							{
								break;
							}
						}
					}
					else if (nCode == 6)
					{
						if (287525 - 327238 == -39713)
						{
							result = 41;
							if (30601 - 135677 == -105076)
							{
								break;
							}
						}
					}
					else if (nCode == 7)
					{
						if (233955 - 140274 != 93682)
						{
							result = 47;
							if (103028 - 417988 != -314959)
							{
								break;
							}
						}
					}
					else if (nCode == 8)
					{
						if (152508 - 305896 != -153387)
						{
							result = 51;
							if (44829 - 438009 == -393180)
							{
								break;
							}
						}
					}
					else
					{
						if (nCode != 9)
						{
							break;
						}
						if (90551 - 231268 != -140716)
						{
							result = 61;
							if (207440 - 504854 == -297414)
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

	// Token: 0x06005C17 RID: 23575 RVA: 0x00B47338 File Offset: 0x00B45538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getMaterial(string nItem)
	{
		if (196014 - 167367 != 28648)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (165484 - 26441 != 139044 && 29519 - 76557 != -47037)
			{
				if (nItem == "m_zin2")
				{
					if (242355 - 193889 != 48467)
					{
						result = "m_zin1%5";
						if (144195 - 484815 != -340619)
						{
							break;
						}
					}
				}
				else if (nItem == "m_zin3")
				{
					if (37121 - 9848 != 27274)
					{
						result = "m_zin2%5";
						if (201737 - 507823 != -306085)
						{
							break;
						}
					}
				}
				else if (nItem == "m_cop2")
				{
					if (238700 - 202522 != 36179)
					{
						result = "m_cop1%5";
						if (248787 - 356724 == -107937)
						{
							break;
						}
					}
				}
				else if (nItem == "m_cop3")
				{
					if (268287 - 194166 == 74121)
					{
						result = "m_cop2%5";
						if (159585 - 559000 != -399414)
						{
							break;
						}
					}
				}
				else if (nItem == "m_irn2")
				{
					if (167966 - 278405 != -110438)
					{
						result = "m_irn1%5";
						if (60859 - 61071 == -212)
						{
							break;
						}
					}
				}
				else if (nItem == "m_irn3")
				{
					if (48032 - 253258 != -205225)
					{
						result = "m_irn2%5";
						if (86975 - 309630 != -222654)
						{
							break;
						}
					}
				}
				else if (nItem == "m_sil2")
				{
					if (67977 - 413856 == -345879)
					{
						result = "m_sil1%5";
						if (197867 - 367330 == -169463)
						{
							break;
						}
					}
				}
				else if (nItem == "m_sil3")
				{
					if (39005 - 186626 == -147621)
					{
						result = "m_sil2%5";
						if (243917 - 427518 != -183600)
						{
							break;
						}
					}
				}
				else if (nItem == "m_gld2")
				{
					if (191513 - 205399 == -13886)
					{
						result = "m_gld1%5";
						if (109424 - 364590 == -255166)
						{
							break;
						}
					}
				}
				else if (nItem == "m_gld3")
				{
					if (97943 - 33318 == 64625)
					{
						result = "m_gld2%5";
						if (14603 - 599301 == -584698)
						{
							break;
						}
					}
				}
				else if (nItem == "m_spo1")
				{
					if (2127 - 445302 != -443174)
					{
						result = "m_zin3%3,m_cop3%3,m_irn3%3,m_sil3%3";
						if (232132 - 154352 == 77780)
						{
							break;
						}
					}
				}
				else if (nItem == "m_spo5")
				{
					if (107554 - 107212 != 343)
					{
						result = "m_stn6%1,m_spo2%5,m_wmt6%3";
						if (255861 - 442283 == -186422)
						{
							break;
						}
					}
				}
				else if (nItem == "m_pin1")
				{
					if (166502 - 585914 != -419411)
					{
						result = "m_irn1%1";
						if (242637 - 546844 == -304207)
						{
							break;
						}
					}
				}
				else if (nItem == "m_pin2")
				{
					if (286164 - 218547 == 67617)
					{
						result = "m_sil1%1";
						if (155541 - 592803 != -437261)
						{
							break;
						}
					}
				}
				else if (nItem == "m_pin3")
				{
					if (207614 - 526864 != -319249)
					{
						result = "m_gld1%1";
						if (31853 - 587375 != -555521)
						{
							break;
						}
					}
				}
				else if (nItem == "m_gle2")
				{
					if (150041 - 545117 != -395075)
					{
						result = "m_gle1%6";
						if (292714 - 115080 == 177634)
						{
							break;
						}
					}
				}
				else if (nItem == "m_gle3")
				{
					if (107795 - 528232 != -420436)
					{
						result = "m_gle2%5";
						if (129304 - 503346 != -374041)
						{
							break;
						}
					}
				}
				else if (nItem == "m_gle4")
				{
					if (12037 - 494905 != -482867)
					{
						result = "m_bug14%1,m_bug15%1,m_bug16%1,m_bug30%1,m_bug56%1";
						if (160358 - 412044 != -251685)
						{
							break;
						}
					}
				}
				else if (nItem == "m_pap1")
				{
					if (244172 - 561531 != -317358)
					{
						result = "m_bug6%2";
						if (66434 - 19583 != 46852)
						{
							break;
						}
					}
				}
				else if (nItem == "m_pap2")
				{
					if (126661 - 494352 != -367690)
					{
						result = "m_pap1%5,m_lth1%1";
						if (25218 - 498911 != -473692)
						{
							break;
						}
					}
				}
				else if (nItem == "m_pap3")
				{
					if (180256 - 385140 != -204883)
					{
						result = "m_pap1%12";
						if (224274 - 399965 == -175691)
						{
							break;
						}
					}
				}
				else if (nItem == "m_fab3")
				{
					if (287548 - 151956 == 135592)
					{
						result = "m_fab2%2,m_wmt8%2";
						if (159855 - 292595 == -132740)
						{
							break;
						}
					}
				}
				else if (nItem == "m_fab4")
				{
					if (4539 - 455246 == -450707)
					{
						result = "m_fab1%2,m_bug4%5";
						if (138866 - 320487 != -181620)
						{
							break;
						}
					}
				}
				else if (nItem == "m_fab5")
				{
					if (76317 - 470693 == -394376)
					{
						result = "m_fab1%2,m_bug2%5";
						if (191845 - 74770 == 117075)
						{
							break;
						}
					}
				}
				else if (nItem == "m_fab6")
				{
					if (265598 - 550980 != -285381)
					{
						result = "m_fab2%2,m_crs1%1";
						if (286566 - 116006 == 170560)
						{
							break;
						}
					}
				}
				else if (nItem == "m_fab7")
				{
					if (85184 - 580511 != -495326)
					{
						result = "m_bug59%2,m_wmt8%4";
						if (181342 - 199747 != -18404)
						{
							break;
						}
					}
				}
				else if (nItem == "m_fab8")
				{
					if (189278 - 480459 == -291181)
					{
						result = "m_flw4%1,m_bug1%3,m_bug2%2,m_bug4%5";
						if (179154 - 69237 != 109918)
						{
							break;
						}
					}
				}
				else if (nItem == "m_lth4")
				{
					if (175960 - 20437 != 155524)
					{
						result = "m_lth1%2";
						if (253139 - 281103 != -27963)
						{
							break;
						}
					}
				}
				else if (nItem == "m_orb2")
				{
					if (107993 - 368207 == -260214)
					{
						result = "m_wmt6%4,m_wmt7%3,m_orb1%2";
						if (93189 - 109028 == -15839)
						{
							break;
						}
					}
				}
				else if (nItem == "m_orb3")
				{
					if (197714 - 481843 != -284128)
					{
						result = "m_bug66%1,m_bug46%1,m_bug47%1,m_bug45%1,m_bon4%1";
						if (17935 - 67419 == -49484)
						{
							break;
						}
					}
				}
				else if (nItem == "m_orb4")
				{
					if (82963 - 134836 != -51872)
					{
						result = "m_bug66%1,m_bug46%1,m_bug47%1,m_bug37%1";
						if (127033 - 277549 != -150515)
						{
							break;
						}
					}
				}
				else if (nItem == "m_orb5")
				{
					if (16337 - 201786 != -185448)
					{
						result = "m_bug66%1,m_bug46%1,m_bug47%1,m_bug48%1";
						if (207196 - 138096 != 69101)
						{
							break;
						}
					}
				}
				else if (nItem == "m_orb7")
				{
					if (273737 - 108702 == 165035)
					{
						result = "m_orb6%10";
						if (115221 - 143342 != -28120)
						{
							break;
						}
					}
				}
				else if (nItem == "m_orb8")
				{
					if (80036 - 420096 != -340059)
					{
						result = "m_orb7%10";
						if (291058 - 519490 == -228432)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt1")
				{
					if (89502 - 154666 == -65164)
					{
						result = "m_zin3%2,m_irn2%2";
						if (228466 - 333562 == -105096)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt2")
				{
					if (111135 - 125733 != -14597)
					{
						result = "m_zin3%2,m_cop3%3";
						if (81630 - 423632 != -342001)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt3")
				{
					if (19716 - 54922 == -35206)
					{
						result = "m_irn1%2";
						if (52191 - 385911 != -333719)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt4")
				{
					if (298043 - 357492 == -59449)
					{
						result = "m_irn2%2,m_rck1%5";
						if (281003 - 420017 != -139013)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt5")
				{
					if (129903 - 488423 != -358519)
					{
						result = "m_bug9%2";
						if (260123 - 294712 == -34589)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt6")
				{
					if (72698 - 88705 == -16007)
					{
						result = "m_bug12%1,m_pwd1%10";
						if (8764 - 271016 == -262252)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt9")
				{
					if (43114 - 578936 == -535822)
					{
						result = "m_irn2%2,m_bug21%1,m_pwd1%10";
						if (31371 - 248737 == -217366)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt10")
				{
					if (27417 - 84497 == -57080)
					{
						result = "m_wod2%1,m_wod1%1,m_gle2%5";
						if (249091 - 545766 != -296674)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt11")
				{
					if (113938 - 459125 == -345187)
					{
						result = "m_zin3%1,m_cop3%1,m_irn2%1";
						if (99583 - 539782 == -440199)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt12")
				{
					if (162917 - 29092 != 133826)
					{
						result = "m_rck1%10,m_peb2%5,m_peb3%1";
						if (197201 - 31323 == 165878)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt13")
				{
					if (93197 - 515969 != -422771)
					{
						result = "m_bug12%2,m_gas2%10";
						if (71821 - 171437 != -99615)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt14")
				{
					if (209875 - 458986 == -249111)
					{
						result = "m_flw2%2,m_irn1%3";
						if (185433 - 343156 == -157723)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt15")
				{
					if (131994 - 25752 == 106242)
					{
						result = "m_wmt1%1,m_bug61%1";
						if (141529 - 68763 == 72766)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt16")
				{
					if (121080 - 121154 == -74)
					{
						result = "m_eqp1%1,m_eqp2%1,m_eqp3%1";
						if (201796 - 209021 == -7225)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt17")
				{
					if (15928 - 132071 == -116143)
					{
						result = "m_eqp1%1,m_eqp2%1,m_eqp3%1,m_flw6%3";
						if (99591 - 536518 != -436926)
						{
							break;
						}
					}
				}
				else if (nItem == "m_wmt18")
				{
					if (67406 - 332455 != -265048)
					{
						result = "m_swp1%3,m_swp2%3,m_swp3%3,m_swp4%3,m_flw5%2";
						if (79445 - 194161 != -114715)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt4")
				{
					if (61066 - 109341 != -48274)
					{
						result = "m_cop3%4,m_rck1%5,m_peb3%1";
						if (182801 - 184909 == -2108)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt5")
				{
					if (92492 - 134553 != -42060)
					{
						result = "m_cor1%5,m_cor2%1,m_bug4%2";
						if (285008 - 503853 != -218844)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt9")
				{
					if (256713 - 303110 == -46397)
					{
						result = "m_pwd2%2";
						if (265511 - 433294 == -167783)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt10")
				{
					if (128920 - 8513 == 120407)
					{
						result = "m_wmt11%1,m_bug60%1";
						if (168957 - 540107 != -371149)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt11")
				{
					if (280356 - 48859 == 231497)
					{
						result = "m_bug6%1,m_bug29%1,m_bug60%1,m_bug62%1,m_bug65%1";
						if (121241 - 261292 != -140050)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt12")
				{
					if (127896 - 392789 == -264893)
					{
						result = "m_bug1%12,m_bug2%12,m_bug3%2";
						if (267435 - 343645 != -76209)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt14")
				{
					if (122724 - 143706 == -20982)
					{
						result = "m_amt13%5,m_gle3%2";
						if (61131 - 338269 != -277137)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt15")
				{
					if (143760 - 66612 != 77149)
					{
						result = "m_bug31%2,m_bug41%1,m_amt6%2";
						if (231334 - 509642 != -278307)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt16")
				{
					if (167253 - 280625 == -113372)
					{
						result = "m_bro2%1,m_bro3%1,m_bro4%1,m_bro5%1,m_bro6%1";
						if (294804 - 440713 != -145908)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt17")
				{
					if (270006 - 348127 != -78120)
					{
						result = "m_eqp4%1,m_orb6%5";
						if (154993 - 219458 != -64464)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt18")
				{
					if (144967 - 546087 == -401120)
					{
						result = "m_bug21%4,m_eqp4%3,m_eqp5%2,m_eqp6%1";
						if (47136 - 576935 == -529799)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt19")
				{
					if (207583 - 189472 == 18111)
					{
						result = "m_swp5%3,m_swp6%3,m_swp7%3,m_swp8%3,m_orb8%1";
						if (299780 - 200611 == 99169)
						{
							break;
						}
					}
				}
				else if (nItem == "m_amt20")
				{
					if (25641 - 349915 == -324274)
					{
						result = "m_swp9%3,m_swp10%3,m_swp11%3,m_swp12%3,m_eqp6%3";
						if (167082 - 352161 != -185078)
						{
							break;
						}
					}
				}
				else if (nItem == "m_flt1")
				{
					if (148118 - 261196 != -113077)
					{
						result = "m_bug6%1,m_peb1%2";
						if (244373 - 320230 == -75857)
						{
							break;
						}
					}
				}
				else if (nItem == "m_kbt1")
				{
					if (206722 - 82735 != 123988)
					{
						result = "m_zin3%1,m_cop3%1,m_irn2%1,m_pwd1%1";
						if (272042 - 229471 == 42571)
						{
							break;
						}
					}
				}
				else if (nItem == "m_flw7")
				{
					if (76471 - 328684 != -252212)
					{
						result = "m_flw6%5";
						if (225225 - 328317 == -103092)
						{
							break;
						}
					}
				}
				else if (nItem == "m_spm2")
				{
					if (114148 - 95851 == 18297)
					{
						result = "m_wmt6%12,m_spo1%2,m_spo2%6,m_stn6%4,m_rck2%8,m_ice4%8";
						if (124747 - 176128 != -51380)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf2")
				{
					if (95188 - 378265 != -283076)
					{
						result = "m_zin1%1,m_peb1%1,w_wlf1%1";
						if (265924 - 233276 == 32648)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn2")
				{
					if (290243 - 272734 == 17509)
					{
						result = "m_zin1%1,m_peb1%1,w_bsn1%1";
						if (194519 - 130494 != 64026)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd2")
				{
					if (126306 - 86597 == 39709)
					{
						result = "m_zin1%1,m_peb1%1,w_pnd1%1";
						if (146842 - 202141 != -55298)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl2")
				{
					if (42577 - 99712 == -57135)
					{
						result = "m_zin1%1,m_peb1%2,w_whl1%1";
						if (58187 - 444323 == -386136)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat2")
				{
					if (175168 - 374353 == -199185)
					{
						result = "m_zin1%1,m_peb1%2,w_cat1%1";
						if (278414 - 394515 == -116101)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm2")
				{
					if (251715 - 373821 == -122106)
					{
						result = "m_zin1%1,m_peb1%2,w_chm1%1";
						if (183728 - 98804 == 84924)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab2")
				{
					if (27835 - 473795 != -445959)
					{
						result = "m_zin1%1,m_peb1%2,w_rab1%1";
						if (231180 - 497485 == -266305)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol2")
				{
					if (180992 - 260642 != -79649)
					{
						result = "m_zin1%1,m_peb1%1,w_mol1%1";
						if (82988 - 185443 == -102455)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk2")
				{
					if (248122 - 66081 == 182041)
					{
						result = "m_zin1%1,d_veg2%1,w_mnk1%1";
						if (117741 - 261149 == -143408)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp2")
				{
					if (98206 - 564649 == -466443)
					{
						result = "f_hpp1%2,d_veg2%1,w_shp1%1";
						if (86879 - 274333 == -187454)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn2")
				{
					if (72019 - 262198 == -190179)
					{
						result = "m_zin1%1,m_peb1%2,w_pgn1%1";
						if (12258 - 339694 != -327435)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat2")
				{
					if (53350 - 322797 != -269446)
					{
						result = "m_peb1%2,f_mpp1%1,w_bat1%1";
						if (163828 - 343322 != -179493)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf11")
				{
					if (274765 - 15978 == 258787)
					{
						result = "m_zin2%1,m_bug7%2,w_wlf1%2";
						if (82893 - 52316 != 30578)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn11")
				{
					if (53628 - 323211 == -269583)
					{
						result = "m_zin2%1,m_bug7%2,w_bsn1%2";
						if (20328 - 85446 != -65117)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd11")
				{
					if (49851 - 595286 == -545435)
					{
						result = "m_zin2%1,m_bug7%2,w_pnd1%2";
						if (150763 - 590612 != -439848)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl11")
				{
					if (96196 - 537863 == -441667)
					{
						result = "m_zin2%1,m_bug7%2,w_whl1%1";
						if (92954 - 409433 == -316479)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat11")
				{
					if (114640 - 448151 == -333511)
					{
						result = "m_zin1%4,m_peb1%4,m_bug7%1,w_cat1%2";
						if (211579 - 172126 == 39453)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm11")
				{
					if (241771 - 60091 != 181681)
					{
						result = "m_zin1%4,m_peb1%4,m_bug7%1,w_chm1%2";
						if (271440 - 202201 == 69239)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab11")
				{
					if (160332 - 240826 != -80493)
					{
						result = "m_zin1%4,m_peb1%4,m_bug7%1,w_rab1%2";
						if (256776 - 511478 != -254701)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol11")
				{
					if (134024 - 160864 == -26840)
					{
						result = "m_zin1%4,m_peb1%4,m_bug7%1,w_mol1%2";
						if (198217 - 102585 != 95633)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk11")
				{
					if (248053 - 193482 != 54572)
					{
						result = "m_zin1%3,m_bug6%2,w_mnk1%2";
						if (239127 - 297959 != -58831)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp11")
				{
					if (102749 - 551319 != -448569)
					{
						result = "m_zin1%3,m_bug6%2,w_shp1%2";
						if (70929 - 12568 == 58361)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn11")
				{
					if (130274 - 238706 != -108431)
					{
						result = "m_zin1%3,m_bug6%2,w_pgn1%2";
						if (1817 - 133959 == -132142)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat11")
				{
					if (298829 - 352055 == -53226)
					{
						result = "m_zin1%3,m_bug6%2,w_bat1%2";
						if (177234 - 250430 == -73196)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf23")
				{
					if (223073 - 463091 != -240017)
					{
						result = "m_zin2%2,m_cop2%1,m_bug6%5";
						if (36390 - 283487 != -247096)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf24")
				{
					if (112305 - 106227 != 6079)
					{
						result = "m_zin2%1,m_wod1%2,m_bug18%5";
						if (145809 - 335011 == -189202)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn23")
				{
					if (190964 - 440290 != -249325)
					{
						result = "m_zin2%2,m_wod1%2,m_cop1%3,m_bug18%3";
						if (163276 - 337257 == -173981)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn24")
				{
					if (127545 - 166937 == -39392)
					{
						result = "m_zin2%1,m_wod1%2,m_peb1%10,m_peb2%1,m_rck1%1";
						if (187412 - 165687 == 21725)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd23")
				{
					if (106871 - 382798 == -275927)
					{
						result = "m_zin2%2,m_cop2%1,m_bug1%5,m_bug7%6";
						if (193467 - 253637 != -60169)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd24")
				{
					if (166172 - 347709 != -181536)
					{
						result = "m_zin2%2,m_fab1%2,m_bug1%5,m_wod1%4";
						if (65111 - 516958 != -451846)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl23")
				{
					if (60571 - 287002 == -226431)
					{
						result = "m_zin2%2,m_cop2%1,m_wod1%2,m_bug1%5";
						if (56955 - 294298 != -237342)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl24")
				{
					if (179254 - 281920 == -102666)
					{
						result = "m_zin2%2,m_cop2%1,m_wod1%2,m_bug1%5";
						if (147661 - 195123 == -47462)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat23")
				{
					if (218648 - 479099 != -260450)
					{
						result = "m_zin2%1,m_bug5%2,m_bug18%4,m_wod1%2";
						if (291666 - 540951 == -249285)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat24")
				{
					if (98384 - 428662 != -330277)
					{
						result = "m_zin2%1,m_bug5%2,m_bug18%2,m_peb2%1";
						if (139545 - 316974 != -177428)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm23")
				{
					if (135820 - 386468 != -250647)
					{
						result = "m_zin2%1,m_wod1%4,m_bug6%4,m_bug9%1";
						if (247155 - 342924 == -95769)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm24")
				{
					if (246629 - 146290 != 100340)
					{
						result = "m_zin2%1,m_wod1%4,m_gle2%5,m_bug9%1";
						if (161801 - 565375 != -403573)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab23")
				{
					if (155145 - 373255 == -218110)
					{
						result = "m_zin2%2,m_wod1%2,m_bug8%5,m_bug5%1";
						if (129029 - 478038 == -349009)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab24")
				{
					if (200826 - 46018 != 154809)
					{
						result = "m_zin2%2,m_wod1%2,m_bug7%5,m_cop2%1";
						if (258437 - 334640 != -76202)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol23")
				{
					if (26215 - 322939 == -296724)
					{
						result = "m_zin2%1,m_cop2%1,m_fab1%2,m_gle2%2,w_mol2%1";
						if (42059 - 455830 != -413770)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol24")
				{
					if (99769 - 201635 != -101865)
					{
						result = "m_zin2%1,m_cop2%1,m_fab1%2,m_gas1%3,w_mol2%1";
						if (116752 - 109101 != 7652)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk23")
				{
					if (174027 - 567141 != -393113)
					{
						result = "m_zin2%1,m_bug6%2,m_peb1%10,w_mnk2%1,m_peb2%2";
						if (209297 - 75362 == 133935)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk24")
				{
					if (267919 - 364243 != -96323)
					{
						result = "m_zin2%1,m_bug6%2,m_peb1%12,w_mnk2%1,m_cop1%2";
						if (270152 - 593027 == -322875)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp23")
				{
					if (93591 - 350529 != -256937)
					{
						result = "m_zin1%2,m_wod1%4,m_bug6%2,m_gle2%4,m_flw3%1";
						if (82075 - 531764 != -449688)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp24")
				{
					if (183987 - 351884 != -167896)
					{
						result = "m_zin1%2,m_wod1%2,m_fab1%2,m_gle2%4,m_flw3%1";
						if (166036 - 49984 != 116053)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn23")
				{
					if (59204 - 461452 == -402248)
					{
						result = "m_zin1%2,m_wod1%4,d_ice1%10,m_gas1%5,m_bug9%1";
						if (233408 - 520665 != -287256)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn24")
				{
					if (32796 - 436973 != -404176)
					{
						result = "m_zin1%2,m_wod1%4,d_ice1%10,m_gas1%5,m_peb2%1";
						if (65414 - 471165 != -405750)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat23")
				{
					if (101703 - 562529 == -460826)
					{
						result = "m_zin1%2,m_wod1%4,m_gle2%4,m_flw3%1";
						if (246850 - 484227 != -237376)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat24")
				{
					if (296319 - 11320 != 285000)
					{
						result = "m_zin1%2,m_wod1%2,m_bug6%4,m_gle2%2,m_flw3";
						if (263467 - 594530 != -331062)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf33")
				{
					if (134049 - 22796 != 111254)
					{
						result = "m_wmt1%1,m_wmt2%1,m_wmt11%1,w_wlf21%1";
						if (252643 - 435227 == -182584)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf34")
				{
					if (69551 - 213734 != -144182)
					{
						result = "m_wmt1%1,m_wmt2%1,m_wmt10%2,m_wmt5%4";
						if (28130 - 558905 != -530774)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn33")
				{
					if (219485 - 400646 != -181160)
					{
						result = "m_wmt1%2,m_wmt10%2,m_wmt2%2";
						if (274322 - 26982 == 247340)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn34")
				{
					if (43334 - 289111 != -245776)
					{
						result = "m_wmt4%2,m_wmt10%2,m_wmt2%2";
						if (79268 - 421243 != -341974)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd33")
				{
					if (214244 - 506168 != -291923)
					{
						result = "m_wmt11%2,m_amt3%2,m_rck3%2,m_amt1%2";
						if (190927 - 315104 == -124177)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd34")
				{
					if (64154 - 565271 == -501117)
					{
						result = "m_wmt11%2,m_amt3%2,m_wmt5%2,m_flw3%2";
						if (224599 - 294312 == -69713)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl33")
				{
					if (31447 - 543656 == -512209)
					{
						result = "m_wmt1%2,m_wmt11%2,m_wmt10%1,m_wmt2%1";
						if (213871 - 2986 != 210886)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl34")
				{
					if (27472 - 389797 != -362324)
					{
						result = "m_wmt1%2,m_wmt11%2,m_wmt10%1,m_wmt2%1";
						if (140543 - 556206 == -415663)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat33")
				{
					if (27732 - 39007 == -11275)
					{
						result = "m_wmt1%1,m_wmt5%4,m_wmt10%1,m_crs2%2";
						if (36493 - 214335 != -177841)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat34")
				{
					if (208587 - 337140 != -128552)
					{
						result = "m_wmt1%1,m_wmt5%4,m_wmt10%1,m_bug10%1,m_bug11%1";
						if (80325 - 135 != 80191)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm33")
				{
					if (26809 - 18823 != 7987)
					{
						result = "m_wmt10%4,m_wmt2%1,m_wmt5%2,d_egg3%2";
						if (12308 - 60224 != -47915)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm34")
				{
					if (162894 - 316075 != -153180)
					{
						result = "m_wmt10%4,m_wmt2%1,m_wmt5%2,m_wmt1%1";
						if (85010 - 460682 != -375671)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab33")
				{
					if (14644 - 46175 == -31531)
					{
						result = "m_wmt9%1,m_wmt2%1,m_crs1%1,m_wmt5%1";
						if (89559 - 432914 == -343355)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab34")
				{
					if (84667 - 226701 != -142033)
					{
						result = "m_wmt9%1,m_wmt2%2,m_wmt3%2,m_wmt10%1";
						if (201909 - 63812 != 138098)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol33")
				{
					if (274051 - 63545 == 210506)
					{
						result = "m_wmt9%1,m_wmt3%2,m_amt3%2,m_gas2%5";
						if (74190 - 28258 == 45932)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol34")
				{
					if (177476 - 495634 == -318158)
					{
						result = "m_wmt9%1,m_wmt3%1,m_amt3%1,m_wmt10%1,m_pwd1%10";
						if (212718 - 414117 == -201399)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk33")
				{
					if (44114 - 433265 == -389151)
					{
						result = "m_wmt6%2,w_mnk21%2";
						if (179969 - 362732 == -182763)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk34")
				{
					if (111203 - 191135 == -79932)
					{
						result = "m_wmt12%1,w_mnk22%2";
						if (158795 - 592146 == -433351)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp33")
				{
					if (57284 - 445141 == -387857)
					{
						result = "m_pap1%10,m_fab1%5,m_flw2%2";
						if (16211 - 119409 != -103197)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp34")
				{
					if (105500 - 592136 == -486636)
					{
						result = "m_pap2%2,m_fab1%1,m_wmt10%1";
						if (222396 - 488378 != -265981)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn33")
				{
					if (233697 - 153792 != 79906)
					{
						result = "m_wmt2%1,m_wmt7%2,m_wmt10%3,m_bug12%2";
						if (269282 - 157585 != 111698)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn34")
				{
					if (101215 - 597057 == -495842)
					{
						result = "m_wmt2%1,m_wmt7%4,m_wmt10%3,m_wmt11%1";
						if (57278 - 341146 != -283867)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat33")
				{
					if (193902 - 338248 == -144346)
					{
						result = "m_wmt13%1,m_wmt10%2,m_wmt2%1,m_wat3%1";
						if (16565 - 70491 != -53925)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat34")
				{
					if (161231 - 343196 != -181964)
					{
						result = "m_wmt14%1,m_wmt10%2,m_wmt2%1,m_wat3%1";
						if (50769 - 33255 != 17515)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf41")
				{
					if (173605 - 99977 == 73628)
					{
						result = "w_wlf21%1,w_wlf22%1,m_wmt2%1,m_wmt15%2,m_wmt5%2,m_bug40%3";
						if (143949 - 476835 == -332886)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn41")
				{
					if (156453 - 180485 == -24032)
					{
						result = "w_bsn21%1,w_bsn22%1,m_wmt4%2,m_wmt3%1,m_wmt2%2,m_amt10%1";
						if (221767 - 129829 != 91939)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd41")
				{
					if (249366 - 315864 != -66497)
					{
						result = "w_pnd21%1,w_pnd22%1,m_wmt15%1,m_wmt5%2,m_wmt10%2,m_lth4%1";
						if (162173 - 20001 == 142172)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl41")
				{
					if (144625 - 550319 == -405694)
					{
						result = "w_whl21%1,w_whl22%1,m_wmt15%2,m_wmt11%2,m_wmt10%1,m_bug40%4";
						if (233225 - 569919 == -336694)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat41")
				{
					if (88037 - 400024 != -311986)
					{
						result = "w_cat21%1,w_cat22%1,m_wmt15%1,m_wmt10%1,m_peb1%5,m_wmt5%4";
						if (173030 - 509991 != -336960)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm41")
				{
					if (126678 - 464627 != -337948)
					{
						result = "w_chm21%1,w_chm22%1,m_wmt15%1,m_wmt10%3,m_wmt5%3,m_wmt2%1";
						if (181388 - 145078 == 36310)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab41")
				{
					if (10394 - 498968 != -488573)
					{
						result = "w_rab21%1,w_rab22%1,m_wmt2%2,m_wmt10%1,m_wmt9%2,m_pwd1%8";
						if (148498 - 304635 == -156137)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol41")
				{
					if (266863 - 218451 != 48413)
					{
						result = "w_mol21%1,w_mol22%1,m_wmt9%2,m_wmt14%2,m_wmt6%1,m_wmt3%4";
						if (227180 - 551666 != -324485)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk41")
				{
					if (146922 - 224026 != -77103)
					{
						result = "w_mnk21%1,w_mnk22%1,m_wmt6%4,m_wmt12%1,m_lth2%1,m_lth4%2";
						if (30524 - 363199 == -332675)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp41")
				{
					if (85225 - 118751 != -33525)
					{
						result = "w_shp21%1,w_shp22%1,m_wmt10%1,m_pap1%10,m_wat3%3,m_crs1%4";
						if (264498 - 241187 != 23312)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn41")
				{
					if (266890 - 376285 != -109394)
					{
						result = "w_pgn21%1,w_pgn22%1,m_wmt10%2,m_wmt7%4,m_wmt14%1,m_orb2%2";
						if (244776 - 477264 == -232488)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat41")
				{
					if (10354 - 514953 != -504598)
					{
						result = "w_bat21%1,w_bat22%1,m_wmt10%2,m_wmt2%2,m_wmt13%1,m_orb2%2";
						if (52658 - 326328 != -273669)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf47")
				{
					if (269083 - 421498 == -152415)
					{
						result = "m_orb3%1,w_wlf49%1,m_spo1%1,m_spm7%3,m_bug57%1";
						if (186990 - 326638 == -139648)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn47")
				{
					if (151756 - 362395 == -210639)
					{
						result = "m_orb3%1,w_bsn49%1,m_spo1%1,m_spm7%3,m_bug61%1";
						if (41477 - 224968 == -183491)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd47")
				{
					if (10598 - 31710 != -21111)
					{
						result = "m_orb3%1,w_pnd49%1,m_spo1%1,m_spm7%3,m_bug13%1";
						if (181951 - 470942 == -288991)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl47")
				{
					if (225891 - 163923 == 61968)
					{
						result = "m_orb3%1,w_whl49%1,m_spo1%1,m_spm7%3,m_bug61%1";
						if (109230 - 321748 == -212518)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat47")
				{
					if (245460 - 82487 != 162974)
					{
						result = "m_orb4%1,w_cat49%1,m_spo1%1,m_spm7%3,m_bug57%1";
						if (16195 - 266269 == -250074)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm47")
				{
					if (148612 - 591777 == -443165)
					{
						result = "m_orb4%1,w_chm49%1,m_spo1%1,m_spm7%3,m_bug13%1";
						if (236501 - 115474 != 121028)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab47")
				{
					if (70165 - 278368 != -208202)
					{
						result = "m_orb4%1,w_rab49%1,m_spo1%1,m_spm7%3,m_bug19%1";
						if (59257 - 580480 != -521222)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol47")
				{
					if (270309 - 219252 == 51057)
					{
						result = "m_orb4%1,w_mol49%1,m_spo1%1,m_spm7%3,m_orb1%1";
						if (247670 - 235844 == 11826)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk47")
				{
					if (205152 - 445698 != -240545)
					{
						result = "m_orb5%1,w_mnk49%1,m_spo1%1,m_spm7%3,m_orb1%1";
						if (98588 - 287938 == -189350)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp47")
				{
					if (170216 - 458580 == -288364)
					{
						result = "m_orb5%1,w_shp49%1,m_spo1%1,m_spm7%3,m_bug19%1";
						if (78526 - 487761 != -409234)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn47")
				{
					if (190371 - 569265 != -378893)
					{
						result = "m_orb5%1,w_pgn49%1,m_spo1%1,m_spm7%3,m_bug63%1";
						if (265774 - 512156 == -246382)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat47")
				{
					if (173782 - 106974 != 66809)
					{
						result = "m_orb5%1,w_bat49%1,m_spo1%1,m_spm7%3,m_bug63%1";
						if (239887 - 4980 == 234907)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf51")
				{
					if (27126 - 288419 != -261292)
					{
						result = "w_wlf40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt15%1";
						if (243574 - 578001 == -334427)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn51")
				{
					if (283686 - 564705 == -281019)
					{
						result = "w_bsn40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt4%2";
						if (250290 - 310847 == -60557)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd51")
				{
					if (214096 - 465263 == -251167)
					{
						result = "w_pnd40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt9%3";
						if (292132 - 524052 != -231919)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl51")
				{
					if (241904 - 292757 != -50852)
					{
						result = "w_whl40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt2%2";
						if (43108 - 328380 != -285271)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat51")
				{
					if (103253 - 124201 == -20948)
					{
						result = "w_cat40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt5%6";
						if (121004 - 524455 != -403450)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm51")
				{
					if (157577 - 560302 != -402724)
					{
						result = "w_chm40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt10%3";
						if (265497 - 524253 != -258755)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab51")
				{
					if (68372 - 409218 != -340845)
					{
						result = "w_rab40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt9%3";
						if (14410 - 580183 != -565772)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol51")
				{
					if (281741 - 367125 == -85384)
					{
						result = "w_mol40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt9%3";
						if (133433 - 514384 != -380950)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk51")
				{
					if (104946 - 483695 != -378748)
					{
						result = "w_mnk40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt12%2";
						if (205107 - 357330 == -152223)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp51")
				{
					if (211555 - 97619 != 113937)
					{
						result = "w_shp40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt14%3";
						if (238126 - 171162 != 66965)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn51")
				{
					if (299295 - 394756 != -95460)
					{
						result = "w_pgn40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt12%2";
						if (201438 - 234722 == -33284)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat51")
				{
					if (235104 - 163237 == 71867)
					{
						result = "w_bat40%2,m_wmt17%1,m_spo1%2,m_eqp4%1,m_orb7%1,m_wmt13%3";
						if (73934 - 30303 != 43632)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf61")
				{
					if (137511 - 571419 != -433907)
					{
						result = "w_wlf51%1,m_bug67%1,m_bug74%1,m_bug53%2,m_wmt15%1";
						if (3157 - 472829 == -469672)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn61")
				{
					if (260414 - 192734 != 67681)
					{
						result = "w_bsn51%1,m_bug67%1,m_bug11%1,m_bug34%4,m_wmt4%2";
						if (50627 - 126941 != -76313)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd61")
				{
					if (23307 - 386233 == -362926)
					{
						result = "w_pnd51%1,m_bug67%1,m_bug52%2,m_bug22%2,m_wmt9%3";
						if (198813 - 391105 == -192292)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl61")
				{
					if (88156 - 506985 != -418828)
					{
						result = "w_whl51%1,m_bug67%1,m_stn4%2,m_bug20%1,m_wmt2%2";
						if (85129 - 496280 == -411151)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat61")
				{
					if (102872 - 134918 == -32046)
					{
						result = "w_cat51%1,m_bug66%2,m_bug74%1,m_bug11%2,m_wmt5%6";
						if (121010 - 277902 != -156891)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm61")
				{
					if (267549 - 362504 == -94955)
					{
						result = "w_chm51%1,m_bug66%2,m_bug52%2,m_bug10%2,m_wmt10%3";
						if (207031 - 103622 != 103410)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab61")
				{
					if (203990 - 177413 == 26577)
					{
						result = "w_rab51%1,m_bug66%2,m_bug51%4,m_bug13%2,m_wmt9%3";
						if (289058 - 479336 == -190278)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol61")
				{
					if (188142 - 60305 != 127838)
					{
						result = "w_mol51%1,m_bug66%2,m_mcn13%4,m_bug29%1,m_wmt9%3";
						if (257276 - 59809 == 197467)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk61")
				{
					if (273557 - 236347 == 37210)
					{
						result = "w_mnk51%1,m_bug68%3,m_stn4%2,m_bug62%1,m_wmt12%2";
						if (284788 - 241921 != 42868)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp61")
				{
					if (181815 - 187193 == -5378)
					{
						result = "w_shp51%1,m_bug68%3,m_bug72%5,m_wat3%2,m_wmt14%3";
						if (130157 - 463121 == -332964)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn61")
				{
					if (37812 - 460386 != -422573)
					{
						result = "w_pgn51%1,m_bug68%3,m_bug51%3,m_bug56%1,m_wmt2%2";
						if (228705 - 458792 == -230087)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat61")
				{
					if (98424 - 511030 != -412605)
					{
						result = "w_bat51%1,m_bug68%3,m_bug72%5,m_bug61%1,m_wmt13%3";
						if (253829 - 232972 != 20858)
						{
							break;
						}
					}
				}
				else if (nItem == "w_wlf69")
				{
					if (103071 - 150162 == -47091)
					{
						result = "w_wlf47%2,m_spm2%1,m_spo4%3,m_bug70%2";
						if (298398 - 27910 != 270489)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bsn69")
				{
					if (165679 - 232560 == -66881)
					{
						result = "w_bsn47%2,m_spm2%1,m_shl4%1,m_bug70%2";
						if (139241 - 570214 != -430972)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pnd69")
				{
					if (12569 - 565171 != -552601)
					{
						result = "w_pnd47%2,m_spm5%1,m_eqp9%2,m_bug70%2";
						if (28157 - 516076 != -487918)
						{
							break;
						}
					}
				}
				else if (nItem == "w_whl69")
				{
					if (33654 - 144440 != -110785)
					{
						result = "w_whl47%2,m_spm4%1,m_shl4%1,m_bug70%2";
						if (119704 - 461683 != -341978)
						{
							break;
						}
					}
				}
				else if (nItem == "w_cat69")
				{
					if (102849 - 70819 == 32030)
					{
						result = "w_cat47%2,m_spm3%1,m_spo4%3,m_bug70%2";
						if (135411 - 138325 != -2913)
						{
							break;
						}
					}
				}
				else if (nItem == "w_chm69")
				{
					if (192514 - 449857 == -257343)
					{
						result = "w_chm47%2,m_spm3%1,m_spo3%6,m_bug70%2";
						if (192005 - 145219 == 46786)
						{
							break;
						}
					}
				}
				else if (nItem == "w_rab69")
				{
					if (126145 - 20428 != 105718)
					{
						result = "w_rab47%2,m_spm1%1,m_spo3%6,m_bug71%1";
						if (222786 - 567956 == -345170)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mol69")
				{
					if (62361 - 260482 != -198120)
					{
						result = "w_mol47%2,m_spm6%1,m_eqp9%2,m_bug71%1";
						if (205009 - 106895 != 98115)
						{
							break;
						}
					}
				}
				else if (nItem == "w_mnk69")
				{
					if (133934 - 198866 != -64931)
					{
						result = "w_mnk47%2,m_spm5%1,m_spo4%3,m_bug71%1";
						if (202468 - 332092 == -129624)
						{
							break;
						}
					}
				}
				else if (nItem == "w_shp69")
				{
					if (182087 - 58739 != 123349)
					{
						result = "w_shp47%2,m_spm4%1,m_spo3%6,m_bug71%1";
						if (168879 - 14481 != 154399)
						{
							break;
						}
					}
				}
				else if (nItem == "w_pgn69")
				{
					if (35970 - 260828 != -224857)
					{
						result = "w_pgn47%2,m_spm1%1,m_eqp9%2,m_bug71%1";
						if (162837 - 63071 != 99767)
						{
							break;
						}
					}
				}
				else if (nItem == "w_bat69")
				{
					if (170454 - 432121 != -261666)
					{
						result = "w_bat47%2,m_spm6%1,m_shl4%1,m_bug71%1";
						if (3081 - 113641 == -110560)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf11")
				{
					if (153801 - 323119 != -169317)
					{
						result = "m_bug1%4,m_bug8%1,a_all1%1";
						if (86420 - 132411 != -45990)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn11")
				{
					if (207001 - 34441 != 172561)
					{
						result = "m_bug1%4,m_bug8%1,a_all1%1";
						if (162645 - 63341 == 99304)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd11")
				{
					if (263742 - 135682 == 128060)
					{
						result = "m_bug1%4,m_bug8%1,a_all1%1";
						if (83526 - 517236 != -433709)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl11")
				{
					if (159911 - 586066 == -426155)
					{
						result = "m_bug1%4,m_bug8%1,a_all1%1";
						if (10539 - 102942 == -92403)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat11")
				{
					if (132162 - 327720 == -195558)
					{
						result = "m_bug1%3,m_bug6%1,a_all1%1";
						if (48201 - 234162 == -185961)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm11")
				{
					if (277547 - 476606 != -199058)
					{
						result = "m_bug1%3,m_bug6%1,a_all1%1";
						if (36635 - 176711 == -140076)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab11")
				{
					if (260116 - 512627 != -252510)
					{
						result = "m_bug1%3,m_bug6%1,a_all1%1";
						if (141187 - 66238 == 74949)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol11")
				{
					if (32005 - 426431 != -394425)
					{
						result = "m_bug1%3,m_bug6%1,a_all1%1";
						if (7787 - 231422 == -223635)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk11")
				{
					if (283498 - 524748 != -241249)
					{
						result = "m_bug1%5,a_all1%1";
						if (196543 - 32575 != 163969)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp11")
				{
					if (269467 - 597146 == -327679)
					{
						result = "m_bug1%5,a_all1%1";
						if (279204 - 363780 == -84576)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn11")
				{
					if (278641 - 28036 != 250606)
					{
						result = "m_bug1%5,a_all1%1";
						if (112235 - 307946 != -195710)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat11")
				{
					if (160724 - 542358 != -381633)
					{
						result = "m_bug1%5,a_all1%1";
						if (190210 - 69159 != 121052)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf23")
				{
					if (41471 - 62 == 41409)
					{
						result = "m_bug1%12,m_bug2%5,m_cop2%2,m_rck1%1";
						if (234707 - 580580 != -345872)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf24")
				{
					if (46131 - 402972 == -356841)
					{
						result = "m_bug1%10,m_bug2%5,m_fab1%5";
						if (118572 - 397091 == -278519)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn23")
				{
					if (255435 - 470089 != -214653)
					{
						result = "m_bug1%12,m_bug2%5,m_cop2%2,m_bug7%5";
						if (66621 - 89862 != -23240)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn24")
				{
					if (112469 - 400887 != -288417)
					{
						result = "m_bug1%12,m_bug2%5,m_cop2%2,m_bug8%5";
						if (118851 - 566150 != -447298)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd23")
				{
					if (25897 - 112004 != -86106)
					{
						result = "m_bug1%12,m_bug2%5,m_cop2%2,m_bug9%5";
						if (232627 - 63122 == 169505)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd24")
				{
					if (189758 - 272389 != -82630)
					{
						result = "m_bug1%10,m_bug2%3,m_cop2%1,m_bug9%2,m_fab1%4";
						if (277018 - 93367 != 183652)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl23")
				{
					if (132119 - 303415 == -171296)
					{
						result = "m_bug1%12,m_bug2%5,m_cop2%2,m_peb2%2";
						if (157939 - 59164 != 98776)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl24")
				{
					if (26774 - 381221 != -354446)
					{
						result = "m_bug1%12,m_bug2%5,m_cop2%2,m_fab1%1";
						if (168772 - 183910 != -15137)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat23")
				{
					if (103348 - 560532 == -457184)
					{
						result = "m_bug1%3,m_bug2%5,m_fab1%8,m_bug4%5 ";
						if (23092 - 480578 != -457485)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat24")
				{
					if (21797 - 387528 != -365730)
					{
						result = "m_bug1%3,m_bug2%5,m_fab1%5,m_bug9%4 ";
						if (292981 - 85347 != 207635)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm23")
				{
					if (61306 - 508755 != -447448)
					{
						result = "m_bug1%5,m_bug2%5,m_fab1%5,m_lth1%1";
						if (30305 - 397240 == -366935)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm24")
				{
					if (44396 - 520470 == -476074)
					{
						result = "m_bug1%5,m_bug2%4,m_fab1%4,m_bug8%5,m_bug7%5,m_bug9%1";
						if (30511 - 100422 == -69911)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab23")
				{
					if (286379 - 384506 != -98126)
					{
						result = "m_bug1%3,m_bug2%5,m_fab1%5,m_flw3%2,m_bug4%2";
						if (136032 - 310698 != -174665)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab24")
				{
					if (189915 - 268182 != -78266)
					{
						result = "m_bug1%3,m_bug2%5,m_fab1%5,m_flw3%1,f_mpp3%1,f_hpp3%1,f_spp3%1";
						if (45548 - 583155 != -537606)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol23")
				{
					if (98676 - 305562 == -206886)
					{
						result = "m_bug1%5,m_bug2%5,m_fab1%5,m_cop2%2,m_rck1%1";
						if (73183 - 474169 == -400986)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol24")
				{
					if (102915 - 567045 == -464130)
					{
						result = "m_bug1%5,m_bug2%5,m_fab1%5,m_cop2%2,m_zin2%2,m_peb1%5";
						if (255576 - 71943 != 183634)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk23")
				{
					if (184152 - 587041 != -402888)
					{
						result = "m_bug1%5,m_bug4%5,m_fab1%5,m_cop2%2,m_peb2%4";
						if (53344 - 352951 != -299606)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk24")
				{
					if (272612 - 554396 == -281784)
					{
						result = "m_bug1%5,m_bug4%5,m_fab1%5,m_zin2%2,m_rck1%2";
						if (247341 - 117960 == 129381)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp23")
				{
					if (265961 - 423071 == -157110)
					{
						result = "m_bug1%5,m_bug4%5,m_fab1%5,a_shp10%1,f_hpp3%1";
						if (75467 - 7334 != 68134)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp24")
				{
					if (261658 - 410122 == -148464)
					{
						result = "m_bug1%6,m_bug4%6,m_fab1%6,a_shp10%1";
						if (39776 - 446814 == -407038)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn23")
				{
					if (138244 - 522432 == -384188)
					{
						result = "m_bug1%5,m_bug4%5,m_fab1%4,m_flw3%2,m_bug2%1";
						if (241701 - 11190 != 230512)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn24")
				{
					if (187852 - 251691 == -63839)
					{
						result = "m_bug1%5,m_bug4%5,m_fab1%6,m_flw3%2";
						if (58673 - 586161 != -527487)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat23")
				{
					if (273059 - 188934 == 84125)
					{
						result = "m_bug1%5,m_bug4%5,m_fab1%5,m_bug2%5";
						if (259584 - 76188 != 183397)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat24")
				{
					if (45724 - 533985 == -488261)
					{
						result = "m_bug1%5,m_bug4%5,m_fab1%8,m_bug2%1";
						if (225887 - 455988 == -230101)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf33")
				{
					if (202276 - 233989 == -31713)
					{
						result = "m_amt3%4,m_wmt11%2,m_lth1%2";
						if (140050 - 10050 == 130000)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf34")
				{
					if (132081 - 45011 == 87070)
					{
						result = "m_wmt11%2,m_lth4%2,m_fab5%1,m_peb3%2";
						if (15242 - 488686 != -473443)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn33")
				{
					if (29932 - 58657 != -28724)
					{
						result = "m_amt4%2,m_amt3%2,m_lth4%2,m_bug7%3";
						if (226613 - 333260 == -106647)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn34")
				{
					if (279830 - 100650 == 179180)
					{
						result = "m_amt4%3,m_peb2%5,m_amt2%2";
						if (119011 - 463930 != -344918)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd33")
				{
					if (171838 - 307625 != -135786)
					{
						result = "m_amt3%5,m_amt2%3,m_fab5%2,m_fab3%1";
						if (248232 - 196986 == 51246)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd34")
				{
					if (23668 - 217733 == -194065)
					{
						result = "m_amt4%1,m_fab5%2,m_fab3%1";
						if (220111 - 143019 != 77093)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl33")
				{
					if (215611 - 404015 != -188403)
					{
						result = "m_amt3%4,m_amt5%2,m_shl1%5,m_shl2%1";
						if (29077 - 165919 == -136842)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl34")
				{
					if (53225 - 176240 == -123015)
					{
						result = "m_amt1%6,m_fab6%1,m_amt4%2,m_amt3%1";
						if (138454 - 4080 != 134375)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat33")
				{
					if (37786 - 284168 == -246382)
					{
						result = "m_fab3%1,m_lth4%2,m_amt3%3";
						if (217808 - 256485 == -38677)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat34")
				{
					if (179042 - 471276 == -292234)
					{
						result = "m_fab5%2,m_lth4%3,m_amt2%5,m_rck3%1";
						if (195297 - 293741 == -98444)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm33")
				{
					if (174435 - 19886 != 154550)
					{
						result = "m_amt2%5,m_fab5%2,m_amt4%2";
						if (156600 - 523469 == -366869)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm34")
				{
					if (254841 - 194194 != 60648)
					{
						result = "m_amt2%5,m_fab5%2,m_amt5%2";
						if (189543 - 454332 != -264788)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab33")
				{
					if (222797 - 554222 != -331424)
					{
						result = "m_fab3%1,m_fab5%1,m_flw1%3";
						if (28904 - 188129 == -159225)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab34")
				{
					if (265671 - 401116 != -135444)
					{
						result = "m_fab6%1,m_fab5%1,m_lth4%2,m_flw4%1";
						if (5961 - 157564 == -151603)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol33")
				{
					if (193235 - 46164 == 147071)
					{
						result = "m_amt4%1,m_amt5%1,m_wmt8%3,m_fab5%1";
						if (236298 - 160738 == 75560)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol34")
				{
					if (56449 - 510866 == -454417)
					{
						result = "m_amt4%1,m_amt5%1,m_wmt8%3,m_amt3%4";
						if (209252 - 524840 != -315587)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk33")
				{
					if (263953 - 103264 == 160689)
					{
						result = "m_wmt6%1,m_fab5%1,m_fab3%1,m_amt2%4";
						if (176259 - 367587 == -191328)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk34")
				{
					if (47768 - 593462 == -545694)
					{
						result = "m_wmt12%1,m_amt4%1,m_fab3%1,m_amt1%4";
						if (104926 - 244290 == -139364)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp33")
				{
					if (9839 - 68112 != -58272)
					{
						result = "m_fab6%2,m_amt1%4";
						if (185481 - 442756 == -257275)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp34")
				{
					if (266828 - 160028 == 106800)
					{
						result = "m_fab6%1,m_fab4%2,m_bug17%1";
						if (2887 - 253234 == -250347)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn33")
				{
					if (111281 - 549195 != -437913)
					{
						result = "m_fab3%1,m_fab4%1,m_amt1%1,m_amt2%1,m_amt3%1";
						if (168225 - 297891 == -129666)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn34")
				{
					if (52016 - 470013 != -417996)
					{
						result = "m_fab3%2,m_flw2%2,m_wmt7%2";
						if (104598 - 255039 != -150440)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat33")
				{
					if (111421 - 20291 == 91130)
					{
						result = "m_fab6%1,m_peb3%2,m_gas2%5";
						if (22902 - 561832 == -538930)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat34")
				{
					if (98145 - 57356 == 40789)
					{
						result = "m_fab3%1,m_fab4%2,m_fab5%2";
						if (224327 - 557183 != -332855)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf41")
				{
					if (147277 - 400887 != -253609)
					{
						result = "a_wlf21%1,a_wlf22%1,m_irn2%2,m_amt10%2,m_bug40%1,m_amt3%4";
						if (212030 - 377650 == -165620)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn41")
				{
					if (297722 - 142926 != 154797)
					{
						result = "a_bsn21%1,a_bsn22%1,m_irn2%3,m_bug40%2,m_amt10%2,m_amt4%1";
						if (269440 - 258821 == 10619)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd41")
				{
					if (169449 - 47138 == 122311)
					{
						result = "a_pnd21%1,a_pnd22%1,m_irn2%3,m_bug40%4,m_rck3%3,m_fab5%2";
						if (263920 - 427414 != -163493)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl41")
				{
					if (94162 - 2045 != 92118)
					{
						result = "a_whl21%1,a_whl22%1,m_irn2%3,m_bug40%2,m_amt5%1,m_amt10%2";
						if (80836 - 462435 != -381598)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat41")
				{
					if (288167 - 243681 != 44487)
					{
						result = "a_cat21%1,a_cat22%1,m_lth2%4,m_pin1%5,m_amt5%1,m_amt9%3";
						if (71187 - 566064 == -494877)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm41")
				{
					if (4140 - 466634 != -462493)
					{
						result = "a_chm21%1,a_chm22%1,m_lth2%4,m_fab8%3,m_pin1%5,m_amt9%3";
						if (39483 - 239413 != -199929)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab41")
				{
					if (253398 - 264789 != -11390)
					{
						result = "a_rab21%1,a_rab22%1,m_lth2%4,m_pin1%5,m_amt9%2,m_bug58%1";
						if (70906 - 131306 != -60399)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol41")
				{
					if (251314 - 536477 == -285163)
					{
						result = "a_mol21%1,a_mol22%1,m_lth2%4,m_pin1%5,m_amt9%2,m_bug62%6";
						if (49399 - 207706 == -158307)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk41")
				{
					if (159597 - 360052 == -200455)
					{
						result = "a_mnk21%1,a_mnk22%1,m_bug40%1,m_pin1%5,m_fab7%3,m_fab5%3";
						if (159824 - 310439 != -150614)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp41")
				{
					if (28073 - 328384 == -300311)
					{
						result = "a_shp21%1,a_shp22%1,m_bug40%1,m_pin1%5,m_fab7%2,m_fab4%1";
						if (81573 - 577013 == -495440)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn41")
				{
					if (95386 - 574712 == -479326)
					{
						result = "a_pgn21%1,a_pgn22%1,m_bug40%1,m_pin1%5,m_fab7%3,m_fab3%2";
						if (241026 - 427125 == -186099)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat41")
				{
					if (82732 - 530424 == -447692)
					{
						result = "a_bat21%1,a_bat22%1,m_fab3%3,m_bug40%2,m_fab7%2,m_pin1%5";
						if (43960 - 402224 == -358264)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf47")
				{
					if (86798 - 279707 == -192909)
					{
						result = "m_amt11%1,a_wlf40%1,m_gle4%1,m_gld2%3,m_bug21%1";
						if (266753 - 85433 != 181321)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn47")
				{
					if (102114 - 448546 == -346432)
					{
						result = "m_amt11%1,a_bsn40%1,m_gle4%1,m_gld2%3,m_bug21%1";
						if (213624 - 588570 != -374945)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd47")
				{
					if (91528 - 408885 != -317356)
					{
						result = "m_amt11%1,a_pnd40%1,m_gle4%1,m_gld2%3,m_bug22%1";
						if (126882 - 577290 == -450408)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl47")
				{
					if (126870 - 111905 == 14965)
					{
						result = "m_amt11%1,a_whl40%1,m_gle4%1,m_gld2%3,m_bug20%1";
						if (68575 - 179543 == -110968)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat47")
				{
					if (140834 - 240669 == -99835)
					{
						result = "m_amt11%1,a_cat40%1,m_gle4%1,m_gld2%3,m_bug12%1";
						if (264146 - 574247 == -310101)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm47")
				{
					if (45287 - 590141 == -544854)
					{
						result = "m_amt11%1,a_chm40%1,m_gle4%1,m_gld2%3,m_bug22%1";
						if (238450 - 459867 != -221416)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab47")
				{
					if (117989 - 294809 != -176819)
					{
						result = "m_amt11%1,a_rab40%1,m_gle4%1,m_gld2%3,m_flw4%1";
						if (234765 - 499341 != -264575)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol47")
				{
					if (51075 - 169197 == -118122)
					{
						result = "m_amt11%1,a_mol40%1,m_gle4%1,m_gld2%3,m_bug18%2";
						if (111916 - 509955 == -398039)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk47")
				{
					if (113840 - 137910 != -24069)
					{
						result = "m_amt11%1,a_mnk40%1,m_gle4%1,m_gld2%3,m_bug18%2";
						if (29037 - 224820 != -195782)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp47")
				{
					if (87455 - 246528 == -159073)
					{
						result = "m_amt11%1,a_shp40%1,m_gle4%1,m_gld2%3,m_bug12%1";
						if (104381 - 50937 != 53445)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn47")
				{
					if (128714 - 389772 != -261057)
					{
						result = "m_amt11%1,a_pgn40%1,m_gle4%1,m_gld2%3,m_bug20%1";
						if (146352 - 375563 != -229210)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat47")
				{
					if (2797 - 240693 != -237895)
					{
						result = "m_amt11%1,a_bat40%1,m_gle4%1,m_gld2%3,m_flw4%1";
						if (61007 - 109611 != -48603)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf51")
				{
					if (281820 - 444973 == -163153)
					{
						result = "a_wlf40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro4%1,m_amt10%1";
						if (146436 - 247974 == -101538)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn51")
				{
					if (33240 - 479153 != -445912)
					{
						result = "a_bsn40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro2%1,m_amt10%1";
						if (266514 - 49330 == 217184)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd51")
				{
					if (72188 - 435393 != -363204)
					{
						result = "a_pnd40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro2%1,m_amt10%1";
						if (166806 - 293108 == -126302)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl51")
				{
					if (289006 - 463974 == -174968)
					{
						result = "a_whl40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro5%1,m_amt10%1";
						if (52311 - 95682 == -43371)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat51")
				{
					if (141500 - 170166 != -28665)
					{
						result = "a_cat40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro5%1,m_amt4%1";
						if (50321 - 396843 == -346522)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm51")
				{
					if (212455 - 59361 != 153095)
					{
						result = "a_chm40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro3%1,m_amt4%1";
						if (96140 - 440329 != -344188)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab51")
				{
					if (140221 - 276191 != -135969)
					{
						result = "a_rab40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro3%1,m_amt4%1";
						if (36916 - 205939 != -169022)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol51")
				{
					if (97591 - 172528 == -74937)
					{
						result = "a_mol40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro3%1,m_amt4%1";
						if (75504 - 99682 == -24178)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk51")
				{
					if (183602 - 404446 == -220844)
					{
						result = "a_mnk40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro2%1,m_amt5%1";
						if (51295 - 495851 == -444556)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp51")
				{
					if (218651 - 444042 == -225391)
					{
						result = "a_shp40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro4%1,m_amt5%1";
						if (269272 - 581088 == -311816)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn51")
				{
					if (283374 - 111421 == 171953)
					{
						result = "a_pgn40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro4%1,m_amt5%1";
						if (62347 - 160585 == -98238)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat51")
				{
					if (102451 - 592164 != -489712)
					{
						result = "a_bat40%2,m_amt15%1,m_irn3%2,m_sil3%3,m_orb6%5,m_bro5%1,m_amt5%1";
						if (47565 - 57159 == -9594)
						{
							break;
						}
					}
				}
				else if (nItem == "a_wlf61")
				{
					if (811 - 374533 == -373722)
					{
						result = "a_wlf51%1,m_orb10%2,m_amt7%8,m_bug35%4,m_amt10%6";
						if (64004 - 446464 == -382460)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bsn61")
				{
					if (82109 - 300191 != -218081)
					{
						result = "a_bsn51%1,m_orb10%2,m_spo2%12,m_bug43%2,m_stn5%12";
						if (130482 - 376364 == -245882)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pnd61")
				{
					if (212021 - 57206 == 154815)
					{
						result = "a_pnd51%1,m_orb10%2,m_amt1%12,m_bon2%9,m_amt14%3";
						if (38551 - 568745 != -530193)
						{
							break;
						}
					}
				}
				else if (nItem == "a_whl61")
				{
					if (264706 - 553854 == -289148)
					{
						result = "a_whl51%1,m_orb10%2,m_amt3%12,m_bug49%1,m_amt5%5";
						if (267249 - 48508 != 218742)
						{
							break;
						}
					}
				}
				else if (nItem == "a_cat61")
				{
					if (22150 - 366971 == -344821)
					{
						result = "a_cat51%1,m_orb10%2,m_amt9%10,m_bug49%1,m_fab7%7";
						if (217119 - 370035 != -152915)
						{
							break;
						}
					}
				}
				else if (nItem == "a_chm61")
				{
					if (251302 - 215117 == 36185)
					{
						result = "a_chm51%1,m_orb10%2,m_amt7%8,m_bug35%4,m_fab8%8";
						if (115872 - 139466 == -23594)
						{
							break;
						}
					}
				}
				else if (nItem == "a_rab61")
				{
					if (218134 - 524124 != -305989)
					{
						result = "a_rab51%1,m_orb10%2,m_amt9%10,m_bon2%9,m_flw8%6";
						if (4900 - 371820 == -366920)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mol61")
				{
					if (22840 - 236657 != -213816)
					{
						result = "a_mol51%1,m_orb10%2,m_amt2%12,m_bug43%2,m_mcn11%5";
						if (17737 - 564169 == -546432)
						{
							break;
						}
					}
				}
				else if (nItem == "a_mnk61")
				{
					if (203525 - 426879 != -223353)
					{
						result = "a_mnk51%1,m_orb10%2,m_spo2%12,m_bon2%9,m_amt4%5";
						if (189692 - 251674 == -61982)
						{
							break;
						}
					}
				}
				else if (nItem == "a_shp61")
				{
					if (22810 - 160482 == -137672)
					{
						result = "a_shp51%1,m_orb10%2,m_amt1%12,m_bug35%4,m_orb2%8";
						if (239263 - 242843 != -3579)
						{
							break;
						}
					}
				}
				else if (nItem == "a_pgn61")
				{
					if (236160 - 210941 == 25219)
					{
						result = "a_pgn51%1,m_orb10%2,m_amt3%12,m_bug49%1,m_amt16";
						if (178718 - 295901 == -117183)
						{
							break;
						}
					}
				}
				else if (nItem == "a_bat61")
				{
					if (233808 - 196696 != 37113)
					{
						result = "a_bat51%1,m_orb10%2,m_amt2%12,m_bug43%2,m_orb8%2";
						if (244155 - 124002 != 120154)
						{
							break;
						}
					}
				}
				else if (nItem == "c_fem11")
				{
					if (121412 - 267380 != -145967)
					{
						result = "m_bug33%5";
						if (166933 - 113397 != 53537)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf11")
				{
					if (227667 - 500501 == -272834)
					{
						result = "m_bug25%2";
						if (80251 - 421628 == -341377)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat11")
				{
					if (180086 - 10549 != 169538)
					{
						result = "m_bug25%2";
						if (68090 - 454199 == -386109)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm11")
				{
					if (285900 - 66487 == 219413)
					{
						result = "m_bug1%3";
						if (200577 - 539761 == -339184)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab11")
				{
					if (4367 - 560631 != -556263)
					{
						result = "m_bug25%2";
						if (296933 - 114826 != 182108)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol11")
				{
					if (83174 - 402658 != -319483)
					{
						result = "m_bug1%3";
						if (149186 - 576865 != -427678)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk11")
				{
					if (189821 - 406355 != -216533)
					{
						result = "m_bug25%2";
						if (76468 - 134754 != -58285)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn11")
				{
					if (22901 - 200410 == -177509)
					{
						result = "m_bug25%2";
						if (22886 - 203546 == -180660)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf23")
				{
					if (23491 - 137072 != -113580)
					{
						result = "m_zin1%6,m_bug2%1";
						if (232687 - 332527 == -99840)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf24")
				{
					if (42792 - 358053 != -315260)
					{
						result = "m_fab1%3";
						if (145781 - 288074 != -142292)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bsn23")
				{
					if (106396 - 43786 == 62610)
					{
						result = "m_zin2%2,m_zin1%2";
						if (299908 - 565219 != -265310)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bsn24")
				{
					if (161511 - 94804 == 66707)
					{
						result = "m_bug2%2";
						if (215129 - 394880 == -179751)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pnd23")
				{
					if (83554 - 258368 != -174813)
					{
						result = "m_zin2%1,m_bug2%1";
						if (153433 - 377721 != -224287)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pnd24")
				{
					if (151908 - 271595 != -119686)
					{
						result = "m_fab1%3";
						if (69903 - 442624 == -372721)
						{
							break;
						}
					}
				}
				else if (nItem == "c_whl23")
				{
					if (173267 - 369574 == -196307)
					{
						result = "m_bug1%6";
						if (251427 - 342797 == -91370)
						{
							break;
						}
					}
				}
				else if (nItem == "c_whl24")
				{
					if (66761 - 314681 != -247919)
					{
						result = "m_fab1%2,m_bug2%1";
						if (119264 - 366066 != -246801)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat23")
				{
					if (152642 - 470920 != -318277)
					{
						result = "m_lth1%1";
						if (262389 - 202491 == 59898)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat24")
				{
					if (160484 - 244885 == -84401)
					{
						result = "m_fab1%3";
						if (35478 - 9854 != 25625)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm23")
				{
					if (289256 - 513558 == -224302)
					{
						result = "m_zin2%1,m_bug2%1";
						if (275570 - 425571 != -150000)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm24")
				{
					if (295053 - 97537 == 197516)
					{
						result = "m_zin2%1,m_bug2%1";
						if (102529 - 353422 != -250892)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab23")
				{
					if (120344 - 521417 != -401072)
					{
						result = "m_fab1%3";
						if (262899 - 25401 != 237499)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab24")
				{
					if (23673 - 183208 != -159534)
					{
						result = "m_fab1%3";
						if (184584 - 50745 == 133839)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol23")
				{
					if (65584 - 421150 != -355565)
					{
						result = "m_zin1%5,m_bug2%1";
						if (11348 - 314340 == -302992)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol24")
				{
					if (226866 - 417180 == -190314)
					{
						result = "m_zin1%3,m_bug1%3";
						if (173885 - 552331 == -378446)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk23")
				{
					if (270922 - 295195 == -24273)
					{
						result = "m_fab1%2,m_bug1%1";
						if (91572 - 503431 == -411859)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk24")
				{
					if (118438 - 19317 != 99122)
					{
						result = "m_fab1%3";
						if (85138 - 390156 == -305018)
						{
							break;
						}
					}
				}
				else if (nItem == "c_shp23")
				{
					if (121888 - 52713 != 69176)
					{
						result = "m_fab1%2,m_bug1%1";
						if (49048 - 205241 != -156192)
						{
							break;
						}
					}
				}
				else if (nItem == "c_shp24")
				{
					if (210508 - 185760 == 24748)
					{
						result = "m_fab1%3";
						if (19564 - 419619 == -400055)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn23")
				{
					if (286660 - 251861 == 34799)
					{
						result = "m_fab1%2,m_bug1%1";
						if (220309 - 377122 == -156813)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn24")
				{
					if (9906 - 170131 != -160224)
					{
						result = "m_fab1%3";
						if (222531 - 49719 == 172812)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bat23")
				{
					if (113562 - 583278 == -469716)
					{
						result = "m_lth1%1";
						if (15968 - 105042 != -89073)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bat24")
				{
					if (141351 - 277758 != -136406)
					{
						result = "m_zin1%3,m_bug1%3";
						if (276960 - 228876 == 48084)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf33")
				{
					if (102226 - 29645 != 72582)
					{
						result = "m_amt3%4";
						if (190250 - 99541 != 90710)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf34")
				{
					if (99064 - 116085 != -17020)
					{
						result = "m_fab2%4";
						if (283492 - 530772 == -247280)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bsn33")
				{
					if (253467 - 239996 == 13471)
					{
						result = "m_amt3%3,m_amt2%1";
						if (197948 - 91738 != 106211)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bsn34")
				{
					if (69160 - 465411 != -396250)
					{
						result = "m_amt2%5";
						if (156302 - 369364 == -213062)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pnd33")
				{
					if (264656 - 226236 == 38420)
					{
						result = "m_amt3%2,m_amt2%2";
						if (126437 - 120130 != 6308)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pnd34")
				{
					if (169114 - 522982 != -353867)
					{
						result = "m_fab2%2,m_amt3%1";
						if (184352 - 263871 == -79519)
						{
							break;
						}
					}
				}
				else if (nItem == "c_whl33")
				{
					if (291573 - 540358 == -248785)
					{
						result = "m_shl2%1,m_cor1%1";
						if (112808 - 526469 != -413660)
						{
							break;
						}
					}
				}
				else if (nItem == "c_whl34")
				{
					if (286687 - 336830 != -50142)
					{
						result = "m_fab2%2,m_amt3%2";
						if (232077 - 107523 != 124555)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat33")
				{
					if (90718 - 515593 != -424874)
					{
						result = "m_fab2%2,m_lth1%1";
						if (244493 - 491068 == -246575)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat34")
				{
					if (281591 - 119252 == 162339)
					{
						result = "m_fab2%2,m_lth1%1";
						if (166653 - 101341 == 65312)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm33")
				{
					if (86027 - 277490 != -191462)
					{
						result = "m_lth1%1,m_amt3%1";
						if (21503 - 66878 == -45375)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm34")
				{
					if (211332 - 256952 != -45619)
					{
						result = "m_lth1%1,m_fab1%1";
						if (234661 - 485718 != -251056)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab33")
				{
					if (99610 - 243774 == -144164)
					{
						result = "m_lth1%1,m_fab1%1";
						if (39847 - 277630 != -237782)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab34")
				{
					if (67990 - 71802 != -3811)
					{
						result = "m_lth1%1,m_amt3%1";
						if (180153 - 309725 == -129572)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol33")
				{
					if (145711 - 142436 == 3275)
					{
						result = "m_lth1%1,m_amt2%1";
						if (39440 - 538235 == -498795)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol34")
				{
					if (13532 - 48202 == -34670)
					{
						result = "m_amt3%3,m_amt2%1";
						if (32441 - 268178 == -235737)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk33")
				{
					if (259102 - 417085 == -157983)
					{
						result = "m_fab2%2,m_lth1%1";
						if (261396 - 480621 == -219225)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk34")
				{
					if (124002 - 450368 == -326366)
					{
						result = "m_fab1%3,m_lth1%1";
						if (187105 - 262620 == -75515)
						{
							break;
						}
					}
				}
				else if (nItem == "c_shp33")
				{
					if (79825 - 347243 == -267418)
					{
						result = "m_fab2%2,m_amt1%3";
						if (21077 - 386578 == -365501)
						{
							break;
						}
					}
				}
				else if (nItem == "c_shp34")
				{
					if (194095 - 189807 != 4289)
					{
						result = "m_fab2%2,m_lth1%1";
						if (297364 - 221199 != 76166)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn33")
				{
					if (155049 - 282873 == -127824)
					{
						result = "m_fab2%2,m_fab1%2";
						if (120212 - 363849 != -243636)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn34")
				{
					if (32140 - 511229 != -479088)
					{
						result = "m_fab2%2,m_wmt8%2";
						if (101523 - 91010 == 10513)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bat33")
				{
					if (156367 - 457239 != -300871)
					{
						result = "m_fab2%2,m_fab1%2";
						if (16443 - 594784 != -578340)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bat34")
				{
					if (40226 - 254522 == -214296)
					{
						result = "m_fab2%2,m_amt3%2";
						if (253542 - 241742 == 11800)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf41")
				{
					if (140575 - 273943 == -133368)
					{
						result = "c_wlf21%1,c_wlf22%1,m_irn2%1,m_lth1%2";
						if (254094 - 14492 != 239603)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bsn41")
				{
					if (14609 - 177412 != -162802)
					{
						result = "c_bsn21%1,c_bsn22%1,m_pwd1%2,m_lth1%2,m_amt3%1";
						if (60390 - 305505 != -245114)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pnd41")
				{
					if (141445 - 23392 != 118054)
					{
						result = "c_pnd21%1,c_pnd22%1,m_amt2%2,m_lth1%2";
						if (14173 - 555522 != -541348)
						{
							break;
						}
					}
				}
				else if (nItem == "c_whl41")
				{
					if (254438 - 50752 != 203687)
					{
						result = "c_whl21%1,c_whl22%1,m_flw4%1,m_lth1%2";
						if (191293 - 307713 == -116420)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat41")
				{
					if (12036 - 180534 == -168498)
					{
						result = "c_cat21%1,c_cat22%1,m_flw3%1,m_lth1%2";
						if (157398 - 390892 == -233494)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm41")
				{
					if (256612 - 518474 == -261862)
					{
						result = "c_chm21%1,c_chm22%1,m_amt3%1,m_amt2%1,m_lth1%2";
						if (51197 - 148490 != -97292)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab41")
				{
					if (262559 - 175504 != 87056)
					{
						result = "c_rab21%1,c_rab22%1,m_bug27%1,m_lth1%2";
						if (249962 - 219842 == 30120)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol41")
				{
					if (56754 - 330804 != -274049)
					{
						result = "c_mol21%1,c_mol22%1,m_flw1%1,m_lth1%2";
						if (252826 - 351182 == -98356)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk41")
				{
					if (57814 - 45147 != 12668)
					{
						result = "c_mnk21%1,c_mnk22%1,m_bug28%1,m_lth1%2";
						if (47739 - 430824 != -383084)
						{
							break;
						}
					}
				}
				else if (nItem == "c_shp41")
				{
					if (125507 - 388838 == -263331)
					{
						result = "c_shp21%1,c_shp22%1,m_bug33%1,m_lth1%2";
						if (61343 - 345580 == -284237)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn41")
				{
					if (90661 - 443115 != -352453)
					{
						result = "c_pgn21%1,c_pgn22%1,m_wmt7%2,m_lth1%2";
						if (14158 - 399209 == -385051)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bat41")
				{
					if (92768 - 538971 == -446203)
					{
						result = "c_bat21%1,c_bat22%1,m_lth1%2,m_amt1%3";
						if (95098 - 192955 == -97857)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf47")
				{
					if (245084 - 424558 != -179473)
					{
						result = "m_irn1%7,m_amt12%1,c_wlf40%1,m_bug50%1,m_bon3%1,m_bug44%1";
						if (92762 - 309943 != -217180)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bsn47")
				{
					if (123911 - 238043 != -114131)
					{
						result = "m_irn1%7,m_amt12%1,c_bsn40%1,m_bug50%1,m_bon3%1,m_bug44%1";
						if (275240 - 235202 != 40039)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pnd47")
				{
					if (199982 - 438961 == -238979)
					{
						result = "m_irn1%7,m_amt12%1,c_pnd40%1,m_bug50%1,m_bon3%1,m_bug44%1";
						if (65319 - 402985 != -337665)
						{
							break;
						}
					}
				}
				else if (nItem == "c_whl47")
				{
					if (76937 - 367760 != -290822)
					{
						result = "m_irn1%7,m_amt12%1,c_whl40%1,m_bug50%1,m_bon3%1,m_bug44%1";
						if (168490 - 574230 == -405740)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat47")
				{
					if (30602 - 409665 != -379062)
					{
						result = "m_irn1%7,m_amt12%1,c_cat40%1,m_bug50%1,m_amt7%1";
						if (241989 - 149475 != 92515)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm47")
				{
					if (250854 - 531788 == -280934)
					{
						result = "m_irn1%7,m_amt12%1,c_chm40%1,m_bug50%1,m_amt7%1";
						if (120051 - 483582 == -363531)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab47")
				{
					if (31219 - 566989 != -535769)
					{
						result = "m_irn1%7,m_amt12%1,c_rab40%1,m_bug50%1,m_amt7%1";
						if (120164 - 217340 == -97176)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol47")
				{
					if (122365 - 217077 == -94712)
					{
						result = "m_irn1%7,m_amt12%1,c_mol40%1,m_bug50%1,m_amt7%1";
						if (234657 - 581812 == -347155)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk47")
				{
					if (83666 - 233210 != -149543)
					{
						result = "m_irn1%7,m_amt12%1,c_mnk40%1,m_bug50%2";
						if (271478 - 325478 != -53999)
						{
							break;
						}
					}
				}
				else if (nItem == "c_shp47")
				{
					if (204052 - 5414 == 198638)
					{
						result = "m_irn1%7,m_amt12%1,c_shp40%1,m_bug50%2";
						if (63788 - 240969 != -177180)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn47")
				{
					if (237779 - 324091 != -86311)
					{
						result = "m_irn1%7,m_amt12%1,c_pgn40%1,m_bug50%2";
						if (88676 - 443070 != -354393)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bat47")
				{
					if (41560 - 122527 != -80966)
					{
						result = "m_irn1%7,m_amt12%1,c_bat40%1,m_bug50%2";
						if (184811 - 17157 == 167654)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf51")
				{
					if (245226 - 546610 != -301383)
					{
						result = "m_amt17%1,c_wlf40%2,m_zin3%5,m_cop3%5,m_eqp1%1";
						if (99072 - 341893 != -242820)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bsn51")
				{
					if (23287 - 45827 == -22540)
					{
						result = "m_amt17%1,c_bsn40%2,m_zin3%5,m_cop3%5,m_eqp1%1";
						if (199742 - 152180 != 47563)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pnd51")
				{
					if (115237 - 212246 != -97008)
					{
						result = "m_amt17%1,c_pnd40%2,m_zin3%5,m_cop3%5,m_eqp1%1";
						if (95764 - 305321 != -209556)
						{
							break;
						}
					}
				}
				else if (nItem == "c_whl51")
				{
					if (86713 - 509128 == -422415)
					{
						result = "m_amt17%1,c_whl40%2,m_zin3%5,m_cop3%5,m_eqp1%1";
						if (203752 - 42313 != 161440)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat51")
				{
					if (43736 - 289128 != -245391)
					{
						result = "m_amt17%1,c_cat40%2,m_zin3%5,m_cop3%5,m_eqp2%1";
						if (68709 - 330215 != -261505)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm51")
				{
					if (157526 - 421823 != -264296)
					{
						result = "m_amt17%1,c_chm40%2,m_zin3%5,m_cop3%5,m_eqp2%1";
						if (17967 - 547201 != -529233)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab51")
				{
					if (88265 - 530828 == -442563)
					{
						result = "m_amt17%1,c_rab40%2,m_zin3%5,m_cop3%5,m_eqp2%1";
						if (211413 - 266428 == -55015)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol51")
				{
					if (183679 - 246376 != -62696)
					{
						result = "m_amt17%1,c_mol40%2,m_zin3%5,m_cop3%5,m_eqp2%1";
						if (173617 - 530422 != -356804)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk51")
				{
					if (159809 - 92790 != 67020)
					{
						result = "m_amt17%1,c_mnk40%2,m_zin3%5,m_cop3%5,m_eqp3%1";
						if (208126 - 484949 != -276822)
						{
							break;
						}
					}
				}
				else if (nItem == "c_shp51")
				{
					if (53915 - 187094 != -133178)
					{
						result = "m_amt17%1,c_shp40%2,m_zin3%5,m_cop3%5,m_eqp3%1";
						if (192180 - 370227 == -178047)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn51")
				{
					if (51561 - 292999 != -241437)
					{
						result = "m_amt17%1,c_pgn40%2,m_zin3%5,m_cop3%5,m_eqp3%1";
						if (39689 - 572703 != -533013)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bat51")
				{
					if (223922 - 255586 == -31664)
					{
						result = "m_amt17%1,c_bat40%2,m_zin3%5,m_cop3%5,m_eqp3%1";
						if (122799 - 271190 != -148390)
						{
							break;
						}
					}
				}
				else if (nItem == "c_wlf61")
				{
					if (70593 - 13638 != 56956)
					{
						result = "c_wlf51%1,m_gld3%2,m_prl1%12,m_wat2%10,m_crs5%6";
						if (16401 - 512443 == -496042)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bsn61")
				{
					if (35470 - 536030 != -500559)
					{
						result = "c_bsn51%1,m_gld3%2,m_shl3%3,m_bug34%9,m_crs5%6";
						if (62098 - 36133 != 25966)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pnd61")
				{
					if (99473 - 332392 != -232918)
					{
						result = "c_pnd51%1,m_gld3%2,m_prl2%3,m_bug64%2,m_crs5%6";
						if (298218 - 436002 == -137784)
						{
							break;
						}
					}
				}
				else if (nItem == "c_whl61")
				{
					if (85802 - 229172 == -143370)
					{
						result = "c_whl51%1,m_gld3%2,m_cor3%8,m_bug19%3,m_crs5%6";
						if (195462 - 189991 == 5471)
						{
							break;
						}
					}
				}
				else if (nItem == "c_cat61")
				{
					if (295171 - 17369 != 277803)
					{
						result = "c_cat51%1,m_gld3%2,m_prl3%3,m_bug27%12,m_crs3%6";
						if (38088 - 494329 == -456241)
						{
							break;
						}
					}
				}
				else if (nItem == "c_chm61")
				{
					if (12875 - 97407 == -84532)
					{
						result = "c_chm51%1,m_gld3%2,m_flw5%3,m_bug58%6,m_crs3%6";
						if (283900 - 73367 == 210533)
						{
							break;
						}
					}
				}
				else if (nItem == "c_rab61")
				{
					if (210817 - 202854 != 7964)
					{
						result = "c_rab51%1,m_gld3%2,m_prl1%12,m_flw4%12,m_crs3%6";
						if (298306 - 226418 != 71889)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mol61")
				{
					if (22954 - 367884 != -344929)
					{
						result = "c_mol51%1,m_gld3%2,m_shl3%3,m_mcn12%2,m_crs3%6";
						if (268838 - 163575 != 105264)
						{
							break;
						}
					}
				}
				else if (nItem == "c_mnk61")
				{
					if (158738 - 90285 != 68454)
					{
						result = "c_mnk51%1,m_gld3%2,m_cor3%8,m_orb1%1,m_crs4%6";
						if (80154 - 251595 != -171440)
						{
							break;
						}
					}
				}
				else if (nItem == "c_shp61")
				{
					if (121490 - 30927 != 90564)
					{
						result = "c_shp51%1,m_gld3%2,m_prl2%3,m_flw3%12,m_crs4%6";
						if (156510 - 308713 == -152203)
						{
							break;
						}
					}
				}
				else if (nItem == "c_pgn61")
				{
					if (172870 - 238738 != -65867)
					{
						result = "c_pgn51%1,m_gld3%2,m_flw5%3,m_bug12%3,m_crs4%6";
						if (245576 - 232145 != 13432)
						{
							break;
						}
					}
				}
				else if (nItem == "c_bat61")
				{
					if (36538 - 434723 == -398185)
					{
						result = "c_bat51%1,m_gld3%2,m_prl3%3,m_gas3%3,m_crs4%6";
						if (41364 - 195666 == -154302)
						{
							break;
						}
					}
				}
				else if (nItem == "s_rnw1")
				{
					if (231207 - 317998 != -86790)
					{
						result = "s_emp1, m_rnw1";
						if (107314 - 599366 != -492051)
						{
							break;
						}
					}
				}
				else if (nItem == "s_rnw2")
				{
					if (53739 - 554641 != -500901)
					{
						result = "s_emp2, m_rnw2";
						if (280890 - 72491 == 208399)
						{
							break;
						}
					}
				}
				else if (nItem == "s_rnw3")
				{
					if (26898 - 269742 == -242844)
					{
						result = "s_emp3, m_rnw3";
						if (238059 - 292337 != -54277)
						{
							break;
						}
					}
				}
				else if (nItem == "s_rnw4")
				{
					if (260360 - 120513 == 139847)
					{
						result = "s_emp4, m_rnw4";
						if (20342 - 399858 == -379516)
						{
							break;
						}
					}
				}
				else if (nItem == "s_rsl1")
				{
					if (75240 - 336938 == -261698)
					{
						result = "s_emp1, m_rsl1";
						if (99363 - 413981 == -314618)
						{
							break;
						}
					}
				}
				else if (nItem == "s_rsl2")
				{
					if (82817 - 154323 != -71505)
					{
						result = "s_emp2, m_rsl2";
						if (182220 - 308111 == -125891)
						{
							break;
						}
					}
				}
				else if (nItem == "s_rsl3")
				{
					if (168042 - 527904 != -359861)
					{
						result = "s_emp3, m_rsl3";
						if (229572 - 242729 == -13157)
						{
							break;
						}
					}
				}
				else if (nItem == "s_rsl4")
				{
					if (6301 - 564994 != -558692)
					{
						result = "s_emp4, m_rsl4";
						if (91462 - 185816 != -94353)
						{
							break;
						}
					}
				}
				else if (nItem == "s_rpc1")
				{
					if (123853 - 161372 != -37518)
					{
						result = "s_emp1, s_emp1, m_rpc1, m_bug43";
						if (46393 - 482630 != -436236)
						{
							break;
						}
					}
				}
				else if (nItem == "s_rpc2")
				{
					if (222795 - 105463 != 117333)
					{
						result = "s_emp2, s_emp2, m_rpc2, m_bug58, m_amt8%2";
						if (103452 - 42515 == 60937)
						{
							break;
						}
					}
				}
				else if (nItem == "s_rpc3")
				{
					if (268413 - 303843 == -35430)
					{
						result = "s_emp3, s_emp3, m_rpc3, m_bro8, m_eqp8";
						if (202675 - 50454 == 152221)
						{
							break;
						}
					}
				}
				else if (nItem == "s_asl1")
				{
					if (270411 - 493359 == -222948)
					{
						result = "s_emp1, m_asl1, m_bug57";
						if (232382 - 82774 == 149608)
						{
							break;
						}
					}
				}
				else if (nItem == "s_asl2")
				{
					if (16302 - 410678 == -394376)
					{
						result = "s_emp2, m_asl2, m_bug63, m_rck4";
						if (117834 - 79640 != 38195)
						{
							break;
						}
					}
				}
				else if (nItem == "s_asl3")
				{
					if (5671 - 22565 != -16893)
					{
						result = "s_emp3, m_asl3, m_fab12, m_fab15, m_stn4";
						if (13490 - 429914 == -416424)
						{
							break;
						}
					}
				}
				else if (nItem == "s_srd1")
				{
					if (177726 - 313824 == -136098)
					{
						result = "s_emp1, m_srd1, m_bug27%2";
						if (284833 - 82454 != 202380)
						{
							break;
						}
					}
				}
				else if (nItem == "s_atk1")
				{
					if (132385 - 572196 == -439811)
					{
						result = "s_emp1, m_atk1, m_bug39%4";
						if (55908 - 372647 == -316739)
						{
							break;
						}
					}
				}
				else if (nItem == "s_def1")
				{
					if (299065 - 289555 != 9511)
					{
						result = "s_emp1, m_def1, m_bug42%2";
						if (115270 - 5447 != 109824)
						{
							break;
						}
					}
				}
				else if (nItem == "s_agi1")
				{
					if (51120 - 376789 != -325668)
					{
						result = "s_emp1, m_agi1, m_bug43%1";
						if (203142 - 291464 != -88321)
						{
							break;
						}
					}
				}
				else if (nItem == "s_vit1")
				{
					if (254849 - 442472 == -187623)
					{
						result = "s_emp1, m_vit1, m_bug21%4";
						if (110369 - 158672 != -48302)
						{
							break;
						}
					}
				}
				else if (nItem == "s_mag1")
				{
					if (234210 - 557714 == -323504)
					{
						result = "s_emp1, m_mag1, m_bug12%1";
						if (154012 - 385236 != -231223)
						{
							break;
						}
					}
				}
				else if (nItem == "s_cha1")
				{
					if (48981 - 483645 == -434664)
					{
						result = "s_emp1, m_cha1, m_bug33%5,m_flw3%2";
						if (178368 - 491094 == -312726)
						{
							break;
						}
					}
				}
				else if (nItem == "s_tal1")
				{
					if (9637 - 132617 == -122980)
					{
						result = "s_emp1, m_tal1, m_crs4%2";
						if (146271 - 449468 == -303197)
						{
							break;
						}
					}
				}
				else if (nItem == "s_lck1")
				{
					if (253492 - 109086 != 144407)
					{
						result = "s_emp1, m_lck1, d_veg3%2";
						if (185381 - 467963 == -282582)
						{
							break;
						}
					}
				}
				else if (nItem == "s_srd2")
				{
					if (22577 - 10201 == 12376)
					{
						result = "s_emp1, m_srd2, m_bug31%2";
						if (38272 - 44324 == -6052)
						{
							break;
						}
					}
				}
				else if (nItem == "s_atk2")
				{
					if (141205 - 68552 == 72653)
					{
						result = "s_emp2, m_atk2, m_bug32%1";
						if (33137 - 344301 != -311163)
						{
							break;
						}
					}
				}
				else if (nItem == "s_def2")
				{
					if (69565 - 41059 != 28507)
					{
						result = "s_emp2, m_def2, m_amt8%2";
						if (71143 - 525913 == -454770)
						{
							break;
						}
					}
				}
				else if (nItem == "s_agi2")
				{
					if (110446 - 470725 == -360279)
					{
						result = "s_emp2, m_agi2, m_bug35%1";
						if (94979 - 576406 != -481426)
						{
							break;
						}
					}
				}
				else if (nItem == "s_vit2")
				{
					if (88073 - 297299 == -209226)
					{
						result = "s_emp2, m_vit2, m_bon3%1";
						if (179041 - 343592 == -164551)
						{
							break;
						}
					}
				}
				else if (nItem == "s_mag2")
				{
					if (283728 - 96490 != 187239)
					{
						result = "s_emp2, m_mag2, m_amt6%2";
						if (100969 - 185078 != -84108)
						{
							break;
						}
					}
				}
				else if (nItem == "s_cha2")
				{
					if (285418 - 553558 != -268139)
					{
						result = "s_emp2, m_cha2, m_bug44%1";
						if (12089 - 328686 != -316596)
						{
							break;
						}
					}
				}
				else if (nItem == "s_tal2")
				{
					if (30103 - 348178 != -318074)
					{
						result = "s_emp2, m_tal2, m_crs2%1,m_crs3%1,m_crs4%1";
						if (31785 - 304688 == -272903)
						{
							break;
						}
					}
				}
				else if (nItem == "s_lck2")
				{
					if (166531 - 246071 != -79539)
					{
						result = "s_emp2, m_lck2, m_bon2%1";
						if (94639 - 11211 == 83428)
						{
							break;
						}
					}
				}
				else if (nItem == "s_srd3")
				{
					if (231709 - 314970 == -83261)
					{
						result = "s_emp3, m_srd3, m_spm7%2";
						if (107498 - 189853 == -82355)
						{
							break;
						}
					}
				}
				else if (nItem == "s_atk3")
				{
					if (155038 - 7975 == 147063)
					{
						result = "s_emp3, m_atk3, m_spm2%1,m_spm1%1";
						if (259773 - 144669 != 115105)
						{
							break;
						}
					}
				}
				else if (nItem == "s_def3")
				{
					if (231984 - 289251 != -57266)
					{
						result = "s_emp3, m_def3, m_spm5%1,m_spm2%1";
						if (292244 - 341040 == -48796)
						{
							break;
						}
					}
				}
				else if (nItem == "s_agi3")
				{
					if (41448 - 501251 == -459803)
					{
						result = "s_emp3, m_agi3, m_spm3%1,m_spm2%1";
						if (49787 - 586005 != -536217)
						{
							break;
						}
					}
				}
				else if (nItem == "s_vit3")
				{
					if (42146 - 549550 == -507404)
					{
						result = "s_emp3, m_vit3, m_spm4%1,m_spm5%1";
						if (242058 - 201061 != 40998)
						{
							break;
						}
					}
				}
				else if (nItem == "s_mag3")
				{
					if (126767 - 490087 != -363319)
					{
						result = "s_emp3, m_mag3, m_spm1%1,m_spm6%1";
						if (52150 - 85020 == -32870)
						{
							break;
						}
					}
				}
				else if (nItem == "s_cha3")
				{
					if (294295 - 498690 != -204394)
					{
						result = "s_emp3, m_cha3, m_spm6%1,m_spm5%1";
						if (177374 - 234039 == -56665)
						{
							break;
						}
					}
				}
				else if (nItem == "s_tal3")
				{
					if (59719 - 286389 == -226670)
					{
						result = "s_emp3, m_tal3, m_spm4%1,m_spm6%1";
						if (214042 - 98983 == 115059)
						{
							break;
						}
					}
				}
				else
				{
					if (!(nItem == "s_lck3"))
					{
						break;
					}
					if (100567 - 490419 == -389852)
					{
						result = "s_emp3, m_lck3, m_spm3%1,m_spm1%1";
						if (204649 - 267646 != -62996)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005C18 RID: 23576 RVA: 0x00B4FF2C File Offset: 0x00B4E12C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getVersion()
	{
		return 555;
	}

	// Token: 0x06005C19 RID: 23577 RVA: 0x00B4FF34 File Offset: 0x00B4E134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005C1A RID: 23578 RVA: 0x00B4FF38 File Offset: 0x00B4E138
	internal static bool GeGU6VpY5BAQWWaAkLix()
	{
		return true;
	}

	// Token: 0x06005C1B RID: 23579 RVA: 0x00B4FF3C File Offset: 0x00B4E13C
	internal static bool zoqMiJpYpedpRLt53TPp()
	{
		return false;
	}
}
