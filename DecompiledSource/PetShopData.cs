using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FC2 RID: 4034
[Serializable]
public class PetShopData : MonoBehaviour
{
	// Token: 0x06005C2B RID: 23595 RVA: 0x00B524C4 File Offset: 0x00B506C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PetShopData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005C2C RID: 23596 RVA: 0x00B524D4 File Offset: 0x00B506D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] getTradeList()
	{
		return new string[]
		{
			"p_lcr1",
			"p_lmp1",
			"p_lpp1",
			"p_lct1",
			"p_lcc1",
			"p_lpk1"
		};
	}

	// Token: 0x06005C2D RID: 23597 RVA: 0x00B5251C File Offset: 0x00B5071C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getTradeItem(string nPet)
	{
		if (211974 - 439789 != -227814)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (84043 - 540882 != -456838 && 273366 - 42475 != 230892)
			{
				if (nPet == "p_lcr1")
				{
					if (168381 - 172307 == -3926)
					{
						result = "d_veg3%99,n_veg1%9";
						if (111130 - 406970 == -295840)
						{
							break;
						}
					}
				}
				else if (nPet == "p_lmp1")
				{
					if (77618 - 437280 == -359662)
					{
						result = "d_nut2%99,n_veg2%9";
						if (293921 - 207830 != 86092)
						{
							break;
						}
					}
				}
				else if (nPet == "p_lpp1")
				{
					if (243587 - 425363 != -181775)
					{
						result = "d_veg5%30,n_veg3%9";
						if (245871 - 593899 == -348028)
						{
							break;
						}
					}
				}
				else if (nPet == "p_lct1")
				{
					if (76848 - 549129 == -472281)
					{
						result = "d_veg7%50,n_veg4%9";
						if (267351 - 133203 != 134149)
						{
							break;
						}
					}
				}
				else if (nPet == "p_lcc1")
				{
					if (125814 - 337996 == -212182)
					{
						result = "d_frt3%30,n_veg5%9";
						if (139398 - 583828 != -444429)
						{
							break;
						}
					}
				}
				else
				{
					if (!(nPet == "p_lpk1"))
					{
						break;
					}
					if (160856 - 222021 == -61165)
					{
						result = "d_veg19%20,n_veg6%9";
						if (290605 - 232175 != 58431)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005C2E RID: 23598 RVA: 0x00B5276C File Offset: 0x00B5096C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getUpgradeItem(string nPet)
	{
		if (288604 - 100331 != 188274)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (90907 - 334366 == -243459)
			{
				if (90102 - 358887 == -268785)
				{
					if (nPet == "p_lcr")
					{
						if (151182 - 500952 != -349769)
						{
							result = "d_veg2%12,d_sld1%12,m_flw6%1,n_veg1%1";
							if (268457 - 273034 != -4576)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lcp")
					{
						if (198362 - 540544 != -342181)
						{
							result = "d_veg3%9,d_sop1%12,m_flw6%1.5,n_veg1%2";
							if (274294 - 234427 != 39868)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lmp")
					{
						if (226271 - 394949 == -168678)
						{
							result = "d_nut2%12,m_wmt8%6,m_flw6%1,n_veg2%1";
							if (265477 - 330525 == -65048)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lpp")
					{
						if (187975 - 54381 != 133595)
						{
							result = "d_veg5%12,d_veg10%12,m_flw6%1,n_veg3%1";
							if (60615 - 406514 == -345899)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lct")
					{
						if (297683 - 5498 != 292186)
						{
							result = "d_veg7%6,d_veg6%3,m_flw6%1,n_veg4%1";
							if (66237 - 547807 != -481569)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lcc")
					{
						if (17212 - 59941 != -42728)
						{
							result = "d_frt3%6,d_nut1%12,m_flw6%1,n_veg5%1";
							if (148940 - 564867 != -415926)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lpk")
					{
						if (17730 - 423225 != -405494)
						{
							result = "d_veg19%12,d_oil1%12,m_flw6%1,n_veg6%1";
							if (70247 - 145519 != -75271)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lml")
					{
						if (250835 - 229839 != 20997)
						{
							result = "d_veg15%12,d_drk10%6,m_flw6%1,n_veg7%1";
							if (87274 - 455218 == -367944)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lbd")
					{
						if (72754 - 445887 != -373132)
						{
							result = "k_gld3%3";
							if (4486 - 339541 == -335055)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lcs")
					{
						if (298487 - 218703 == 79784)
						{
							result = "d_sld1%12,d_cak2%6,m_bug53%1,n_veg1%1.5";
							if (27226 - 162383 != -135156)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lms")
					{
						if (36850 - 497532 == -460682)
						{
							result = "m_wmt8%6,d_cak3%6,m_bug53%1,n_veg2%1.5";
							if (110991 - 490656 == -379665)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lps")
					{
						if (198360 - 155351 != 43010)
						{
							result = "d_veg10%9,d_cak4%6,m_bug53%1,n_veg3%1.5";
							if (89692 - 453408 != -363715)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lmc")
					{
						if (81247 - 161905 == -80658)
						{
							result = "d_veg13%1,m_eqp1%1,m_flw7%0.5,k_bdg9%6";
							if (263882 - 2257 != 261626)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lmn")
					{
						if (148067 - 563075 == -415008)
						{
							result = "d_veg14%1,m_eqp2%1,m_flw7%0.5,k_bdg10%6";
							if (206946 - 2274 != 204673)
							{
								break;
							}
						}
					}
					else if (nPet == "p_lmo")
					{
						if (54861 - 224373 != -169511)
						{
							result = "d_veg15%1,m_eqp3%1,m_flw7%0.5,k_bdg11%6";
							if (143223 - 491293 == -348070)
							{
								break;
							}
						}
					}
					else if (nPet == "p_ldc")
					{
						if (71658 - 586187 != -514528)
						{
							result = "d_grb1%12,d_veg18%6,m_crs1%12,k_gld1%0.5";
							if (165737 - 302992 == -137255)
							{
								break;
							}
						}
					}
					else if (nPet == "p_ldm")
					{
						if (257501 - 134021 == 123480)
						{
							result = "d_grb1%12,d_veg16%6,m_crs5%6,k_gld1%0.5";
							if (192996 - 372310 == -179314)
							{
								break;
							}
						}
					}
					else if (nPet == "p_ldp")
					{
						if (199907 - 327186 == -127279)
						{
							result = "d_grb1%12,d_veg17%6,m_crs2%12,k_gld1%0.5";
							if (222421 - 384947 == -162526)
							{
								break;
							}
						}
					}
					else if (nPet == "p_ldt")
					{
						if (158894 - 219837 == -60943)
						{
							result = "d_grb1%12,d_veg16%6,m_crs3%6,k_gld1%0.5";
							if (27472 - 96956 != -69483)
							{
								break;
							}
						}
					}
					else if (nPet == "p_ldn")
					{
						if (165832 - 52315 != 113518)
						{
							result = "d_grb1%12,d_veg17%6,m_crs4%6,k_gld1%0.5";
							if (281100 - 276254 == 4846)
							{
								break;
							}
						}
					}
					else if (nPet == "p_ldk")
					{
						if (276930 - 584363 == -307433)
						{
							result = "d_grb1%12,d_veg18%6,m_crs6%12,k_gld1%0.5";
							if (91177 - 81046 != 10132)
							{
								break;
							}
						}
					}
					else if (nPet == "p_skr")
					{
						if (2396 - 149506 != -147109)
						{
							result = "d_ric2%12,d_veg9%9,m_bug9%4,m_pap3%1";
							if (130023 - 113026 == 16997)
							{
								break;
							}
						}
					}
					else if (nPet == "p_skg")
					{
						if (184715 - 196237 != -11521)
						{
							result = "d_ric3%6,d_veg8%9,m_bug9%4,m_pap3%1";
							if (91663 - 110517 == -18854)
							{
								break;
							}
						}
					}
					else if (nPet == "p_sky")
					{
						if (135564 - 591362 == -455798)
						{
							result = "d_ric4%6,d_snk1%12,m_bug9%4,m_pap3%1";
							if (60058 - 124788 == -64730)
							{
								break;
							}
						}
					}
					else if (nPet == "p_skb")
					{
						if (78814 - 265773 != -186958)
						{
							result = "d_ric5%12,d_veg12%3,m_bug9%4,m_pap3%1";
							if (148543 - 122232 == 26311)
							{
								break;
							}
						}
					}
					else if (nPet == "p_skk")
					{
						if (267530 - 348645 != -81114)
						{
							result = "d_ric6%6,d_veg11%3,m_bug9%4,m_pap3%1";
							if (50960 - 356978 == -306018)
							{
								break;
							}
						}
					}
					else if (nPet == "p_sfb")
					{
						if (173559 - 210967 != -37407)
						{
							result = "d_jar1%12,d_dst7%6,m_bug33%6,m_bug56%6";
							if (3109 - 156664 == -153555)
							{
								break;
							}
						}
					}
					else if (nPet == "p_sim")
					{
						if (152209 - 435264 != -283054)
						{
							result = "d_dst8%1,d_ice1%12,m_stn1%9,m_wmt10%2";
							if (241949 - 208604 != 33346)
							{
								break;
							}
						}
					}
					else if (nPet == "p_sam")
					{
						if (167028 - 580621 != -413592)
						{
							result = "d_swd1%6,d_swd2%9,d_swd3%12,m_prl2%4";
							if (112521 - 489540 == -377019)
							{
								break;
							}
						}
					}
					else if (nPet == "p_sob")
					{
						if (294333 - 449285 == -154952)
						{
							result = "m_atk1%1,f_slb1%1,f_slb2%1,f_slb3%1";
							if (184798 - 130322 == 54476)
							{
								break;
							}
						}
					}
					else if (nPet == "p_sgb")
					{
						if (267505 - 579786 != -312280)
						{
							result = "m_def1%1,f_slb1%1,f_slb2%1,f_slb3%1";
							if (32689 - 494498 != -461808)
							{
								break;
							}
						}
					}
					else if (nPet == "p_slb")
					{
						if (84988 - 288682 != -203693)
						{
							result = "m_agi1%1,f_slb1%1,f_slb2%1,f_slb3%1";
							if (113861 - 17511 != 96351)
							{
								break;
							}
						}
					}
					else if (nPet == "p_stb")
					{
						if (158147 - 403488 != -245340)
						{
							result = "m_vit1%1,f_slb1%1,f_slb2%1,f_slb3%1";
							if (154834 - 366097 != -211262)
							{
								break;
							}
						}
					}
					else if (nPet == "p_spb")
					{
						if (33899 - 359533 != -325633)
						{
							result = "m_mag1%1,f_slb1%1,f_slb2%1,f_slb3%1";
							if (22076 - 238918 == -216842)
							{
								break;
							}
						}
					}
					else if (nPet == "p_swb")
					{
						if (163324 - 106270 == 57054)
						{
							result = "m_cha1%1,f_slb1%1,f_slb2%1,f_slb3%1";
							if (35420 - 229974 == -194554)
							{
								break;
							}
						}
					}
					else if (nPet == "p_ssq")
					{
						if (278315 - 142954 == 135361)
						{
							result = "m_tal1%1,f_slb1%1,f_slb2%1,f_slb3%1";
							if (173769 - 336996 == -163227)
							{
								break;
							}
						}
					}
					else if (nPet == "p_snb")
					{
						if (1332 - 490751 != -489418)
						{
							result = "m_lck1%1,f_slb1%1,f_slb2%1,f_slb3%1";
							if (192677 - 443001 != -250323)
							{
								break;
							}
						}
					}
					else if (nPet == "p_sab")
					{
						if (163891 - 278421 != -114529)
						{
							result = "d_snw5%3,d_snw6%3,d_sop5%1,m_bro1%3";
							if (175004 - 475800 == -300796)
							{
								break;
							}
						}
					}
					else if (nPet == "p_spg")
					{
						if (240221 - 544207 == -303986)
						{
							result = "d_nod7%3,d_nod8%3,d_sop6%6,m_fab12%1";
							if (104625 - 295179 != -190553)
							{
								break;
							}
						}
					}
					else if (nPet == "p_spf")
					{
						if (135679 - 51071 != 84609)
						{
							result = "d_met12%3,d_met13%3,d_dst6%1.5,m_fab15%2";
							if (50670 - 236328 == -185658)
							{
								break;
							}
						}
					}
					else if (nPet == "p_msb")
					{
						if (214743 - 272652 != -57908)
						{
							result = "p_mrb1%0.7,d_snw4%3,t_all31%1,k_gld1%1";
							if (79463 - 33762 == 45701)
							{
								break;
							}
						}
					}
					else if (nPet == "p_mcb")
					{
						if (107478 - 227602 == -120124)
						{
							result = "p_msb1%0.7,d_nod6%5,t_all32%1,k_gld1%1";
							if (18005 - 531815 != -513809)
							{
								break;
							}
						}
					}
					else if (nPet == "p_mab")
					{
						if (32170 - 597607 != -565436)
						{
							result = "p_mgb1%0.5,d_ric9%3,t_all33%1,k_gld1%1";
							if (249625 - 191337 != 58289)
							{
								break;
							}
						}
					}
					else if (nPet == "p_mrb")
					{
						if (121574 - 410099 != -288524)
						{
							result = "p_mmb1%1.2,d_spg3%4,t_all34%1,k_gld1%1";
							if (194004 - 116058 == 77946)
							{
								break;
							}
						}
					}
					else if (nPet == "p_mmb")
					{
						if (57173 - 567762 != -510588)
						{
							result = "p_mab1%1,d_sop4%6,t_all35%1,k_gld1%1";
							if (178073 - 552159 == -374086)
							{
								break;
							}
						}
					}
					else if (nPet == "p_mgb")
					{
						if (286259 - 463046 == -176787)
						{
							result = "p_mcb1%1.2,d_met8%5,t_all36%1,k_gld1%1";
							if (207306 - 277054 == -69748)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nPet == "p_mnb"))
						{
							break;
						}
						if (37622 - 392561 != -354938)
						{
							result = "p_mnb1%0.5,d_sld5%1,t_all37%1,k_gld1%1";
							if (4616 - 573747 != -569130)
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

	// Token: 0x06005C2F RID: 23599 RVA: 0x00B53664 File Offset: 0x00B51864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005C30 RID: 23600 RVA: 0x00B53668 File Offset: 0x00B51868
	internal static bool XWdwbZpYceSHrBbepWTS()
	{
		return true;
	}

	// Token: 0x06005C31 RID: 23601 RVA: 0x00B5366C File Offset: 0x00B5186C
	internal static bool mIqoFYpYUkg5SBuBouHc()
	{
		return false;
	}
}
