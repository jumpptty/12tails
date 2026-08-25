using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020010A9 RID: 4265
[Serializable]
public class Language : MonoBehaviour
{
	// Token: 0x06006349 RID: 25417 RVA: 0x00DC7FB8 File Offset: 0x00DC61B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Language()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600634A RID: 25418 RVA: 0x00DC7FC8 File Offset: 0x00DC61C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getMessage(string nScriptName, int nCode)
	{
		if (299747 - 356143 != -56396)
		{
		}
		string result;
		for (;;)
		{
			result = string.Empty;
			if (207408 - 20260 == 187148)
			{
				int @int = PlayerPrefs.GetInt("language", 0);
				if (73097 - 242806 != -169708)
				{
					if (@int == 0)
					{
						if (297418 - 451855 != -154436)
						{
							result = Language.getThaiMessage(nScriptName, nCode);
							if (257752 - 165436 != 92317)
							{
								break;
							}
						}
					}
					else
					{
						if (@int != 1)
						{
							break;
						}
						if (191354 - 558804 == -367450)
						{
							result = Language.getEnglishMessage(nScriptName, nCode);
							if (207774 - 158567 != 49208)
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

	// Token: 0x0600634B RID: 25419 RVA: 0x00DC80D8 File Offset: 0x00DC62D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getDes(string nScriptName, string nString)
	{
		if (114720 - 378733 != -264013)
		{
		}
		string result;
		for (;;)
		{
			result = string.Empty;
			if (175672 - 515905 != -340232)
			{
				int @int = PlayerPrefs.GetInt("language", 0);
				if (136539 - 376074 == -239535)
				{
					if (@int == 0)
					{
						if (239368 - 384960 == -145592)
						{
							result = Language.getThaiDes(nScriptName, nString);
							if (259898 - 15918 == 243980)
							{
								break;
							}
						}
					}
					else
					{
						if (@int != 1)
						{
							break;
						}
						if (15587 - 557330 != -541742)
						{
							result = Language.getEnglishDes(nScriptName, nString);
							if (197671 - 480885 == -283214)
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

	// Token: 0x0600634C RID: 25420 RVA: 0x00DC81E8 File Offset: 0x00DC63E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getThaiDes(string nScriptName, string nString)
	{
		if (258604 - 198300 != 60305)
		{
		}
		string result;
		for (;;)
		{
			result = string.Empty;
			if (111773 - 534916 == -423143)
			{
				if (173234 - 466918 != -293683)
				{
					if (nScriptName == "WolfSkill")
					{
						if (5874 - 26746 == -20872)
						{
							result = WolfSkill_thai.getDes(nString);
							if (139975 - 252367 != -112391)
							{
								break;
							}
						}
					}
					else if (nScriptName == "BisonSkill")
					{
						if (213665 - 189726 != 23940)
						{
							result = BisonSkill_thai.getDes(nString);
							if (233130 - 560958 != -327827)
							{
								break;
							}
						}
					}
					else if (nScriptName == "PandaSkill")
					{
						if (133190 - 130601 != 2590)
						{
							result = PandaSkill_thai.getDes(nString);
							if (134072 - 142231 != -8158)
							{
								break;
							}
						}
					}
					else if (nScriptName == "WhaleSkill")
					{
						if (100047 - 230909 == -130862)
						{
							result = WhaleSkill_thai.getDes(nString);
							if (142310 - 491013 != -348702)
							{
								break;
							}
						}
					}
					else if (nScriptName == "CatSkill")
					{
						if (82081 - 448555 == -366474)
						{
							result = CatSkill_thai.getDes(nString);
							if (177528 - 318710 == -141182)
							{
								break;
							}
						}
					}
					else if (nScriptName == "ChameleonSkill")
					{
						if (214758 - 480069 != -265310)
						{
							result = ChameleonSkill_thai.getDes(nString);
							if (162626 - 101663 == 60963)
							{
								break;
							}
						}
					}
					else if (nScriptName == "MoleSkill")
					{
						if (75606 - 588601 != -512994)
						{
							result = MoleSkill_thai.getDes(nString);
							if (81619 - 90142 == -8523)
							{
								break;
							}
						}
					}
					else if (nScriptName == "RabbitSkill")
					{
						if (69347 - 184600 == -115253)
						{
							result = RabbitSkill_thai.getDes(nString);
							if (235698 - 361993 == -126295)
							{
								break;
							}
						}
					}
					else if (nScriptName == "MonkeySkill")
					{
						if (154108 - 156715 == -2607)
						{
							result = MonkeySkill_thai.getDes(nString);
							if (76324 - 470224 != -393899)
							{
								break;
							}
						}
					}
					else if (nScriptName == "PenguinSkill")
					{
						if (154767 - 483425 != -328657)
						{
							result = PenguinSkill_thai.getDes(nString);
							if (99160 - 217113 != -117952)
							{
								break;
							}
						}
					}
					else if (nScriptName == "SheepSkill")
					{
						if (9706 - 403618 == -393912)
						{
							result = SheepSkill_thai.getDes(nString);
							if (134045 - 135255 == -1210)
							{
								break;
							}
						}
					}
					else if (nScriptName == "BatSkill")
					{
						if (219100 - 522407 != -303306)
						{
							result = BatSkill_thai.getDes(nString);
							if (271818 - 542317 != -270498)
							{
								break;
							}
						}
					}
					else if (nScriptName == "SupplementSkill")
					{
						if (244512 - 399529 != -155016)
						{
							result = SupplementSkill_thai.getDes(nString);
							if (7860 - 535065 != -527204)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nScriptName == "EmotionSkill"))
						{
							break;
						}
						if (72545 - 343538 == -270993)
						{
							result = EmotionSkill_thai.getDes(nString);
							if (231581 - 467112 != -235530)
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

	// Token: 0x0600634D RID: 25421 RVA: 0x00DC86C0 File Offset: 0x00DC68C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getThaiMessage(string nScriptName, int nCode)
	{
		if (250333 - 428942 != -178609)
		{
		}
		string result;
		for (;;)
		{
			result = string.Empty;
			if (244261 - 573235 != -328973 && 215395 - 57386 != 158010)
			{
				if (nScriptName == "AuctionGui")
				{
					if (109921 - 313919 != -203997)
					{
						result = AuctionGui_thai.getMessage(nCode);
						if (28699 - 79494 != -50794)
						{
							break;
						}
					}
				}
				else if (nScriptName == "BankGui")
				{
					if (132243 - 310109 != -177865)
					{
						result = BankGui_thai.getMessage(nCode);
						if (164921 - 123579 == 41342)
						{
							break;
						}
					}
				}
				else if (nScriptName == "CollectorGui")
				{
					if (157498 - 502086 != -344587)
					{
						result = CollectorGui_thai.getMessage(nCode);
						if (205594 - 59110 != 146485)
						{
							break;
						}
					}
				}
				else if (nScriptName == "CompoundGui")
				{
					if (157581 - 407950 != -250368)
					{
						result = CompoundGui_thai.getMessage(nCode);
						if (110523 - 58587 != 51937)
						{
							break;
						}
					}
				}
				else if (nScriptName == "GameGui")
				{
					if (157909 - 209827 == -51918)
					{
						result = GameGui_thai.getMessage(nCode);
						if (98028 - 102389 == -4361)
						{
							break;
						}
					}
				}
				else if (nScriptName == "GuildGui")
				{
					if (226898 - 392790 != -165891)
					{
						result = GuildGui_thai.getMessage(nCode);
						if (233515 - 564721 == -331206)
						{
							break;
						}
					}
				}
				else if (nScriptName == "IceMixerGui")
				{
					if (186684 - 287961 == -101277)
					{
						result = IceMixerGui_thai.getMessage(nCode);
						if (138033 - 311597 != -173563)
						{
							break;
						}
					}
				}
				else if (nScriptName == "LobbyGui")
				{
					if (89457 - 278711 != -189253)
					{
						result = LobbyGuI_thai.getMessage(nCode);
						if (209919 - 185218 != 24702)
						{
							break;
						}
					}
				}
				else if (nScriptName == "MailBoxGui")
				{
					if (82723 - 584998 != -502274)
					{
						result = MailBoxGui_thai.getMessage(nCode);
						if (117366 - 360491 == -243125)
						{
							break;
						}
					}
				}
				else if (nScriptName == "MallGui")
				{
					if (234256 - 364320 == -130064)
					{
						result = MallGui_thai.getMessage(nCode);
						if (141686 - 336764 != -195077)
						{
							break;
						}
					}
				}
				else if (nScriptName == "MissionGui")
				{
					if (88357 - 29600 == 58757)
					{
						result = MissionGui_thai.getMessage(nCode);
						if (112964 - 12167 == 100797)
						{
							break;
						}
					}
				}
				else if (nScriptName == "PetShopGui")
				{
					if (240264 - 315412 != -75147)
					{
						result = PetShopGui_thai.getMessage(nCode);
						if (276677 - 42312 != 234366)
						{
							break;
						}
					}
				}
				else if (nScriptName == "QuestGui")
				{
					if (27918 - 119897 != -91978)
					{
						result = QuestGui_thai.getMessage(nCode);
						if (68323 - 439817 != -371493)
						{
							break;
						}
					}
				}
				else if (nScriptName == "ShopGui")
				{
					if (156910 - 500320 == -343410)
					{
						result = ShopGui_thai.getMessage(nCode);
						if (242591 - 242315 != 277)
						{
							break;
						}
					}
				}
				else if (nScriptName == "StorageGui")
				{
					if (35445 - 465279 != -429833)
					{
						result = StorageGui_thai.getMessage(nCode);
						if (268537 - 1917 == 266620)
						{
							break;
						}
					}
				}
				else if (nScriptName == "TransportGui")
				{
					if (165367 - 189797 == -24430)
					{
						result = TransportGui_thai.getMessage(nCode);
						if (294069 - 374342 == -80273)
						{
							break;
						}
					}
				}
				else if (nScriptName == "TutorialGui")
				{
					if (296951 - 310696 != -13744)
					{
						result = TutorialGui_thai.getMessage(nCode);
						if (109905 - 337472 == -227567)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G30_NoGuild")
				{
					if (5505 - 45333 == -39828)
					{
						result = G30_NoGuild_thai.getMessage(nCode);
						if (224387 - 109824 != 114564)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G31_GuildPlain")
				{
					if (23387 - 291490 == -268103)
					{
						result = G31_GuildPlain_thai.getMessage(nCode);
						if (84193 - 594017 == -509824)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G32_SnowCamp")
				{
					if (146861 - 583827 != -436965)
					{
						result = G32_SnowCamp_thai.getMessage(nCode);
						if (184896 - 270137 == -85241)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G33_CrystalBeach")
				{
					if (20541 - 427593 != -407051)
					{
						result = G33_CrystalBeach_thai.getMessage(nCode);
						if (296130 - 502666 == -206536)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G34_ExcavationCamp")
				{
					if (280798 - 311819 == -31021)
					{
						result = G34_ExcavationCamp_thai.getMessage(nCode);
						if (153779 - 315727 == -161948)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G35_UndergroundCamp")
				{
					if (93002 - 2036 != 90967)
					{
						result = G35_UndergroundCamp_thai.getMessage(nCode);
						if (270375 - 179653 != 90723)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G36_ForestCamp")
				{
					if (196084 - 307826 == -111742)
					{
						result = G36_ForestCamp_thai.getMessage(nCode);
						if (235984 - 574657 == -338673)
						{
							break;
						}
					}
				}
				else if (nScriptName == "T51_MainStreet")
				{
					if (173814 - 378843 == -205029)
					{
						result = T51_MainStreet_thai.getMessage(nCode);
						if (191818 - 387830 != -196011)
						{
							break;
						}
					}
				}
				else if (nScriptName == "T52_CentralSquare")
				{
					if (44688 - 597117 != -552428)
					{
						result = T52_CentralSquare_thai.getMessage(nCode);
						if (181327 - 408355 == -227028)
						{
							break;
						}
					}
				}
				else if (nScriptName == "T53_CityLibrary")
				{
					if (166165 - 476950 != -310784)
					{
						result = T53_CityLibrary_thai.getMessage(nCode);
						if (18938 - 466130 == -447192)
						{
							break;
						}
					}
				}
				else if (nScriptName == "T54_LightPark")
				{
					if (216448 - 526423 == -309975)
					{
						result = T54_LightPark_thai.getMessage(nCode);
						if (172304 - 422237 != -249932)
						{
							break;
						}
					}
				}
				else if (nScriptName == "T55_LightPalace")
				{
					if (50293 - 585954 == -535661)
					{
						result = T55_LightPalace_thai.getMessage(nCode);
						if (124165 - 48090 != 76076)
						{
							break;
						}
					}
				}
				else if (nScriptName == "T56_PlainColosseum")
				{
					if (5987 - 484343 == -478356)
					{
						result = T56_PlainColosseum_thai.getMessage(nCode);
						if (189952 - 283042 == -93090)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M100_GameTutorial")
				{
					if (214590 - 395866 == -181276)
					{
						result = M100_GameTutorial_thai.getMessage(nCode);
						if (201567 - 551376 == -349809)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M101_CarronHunt")
				{
					if (13592 - 411853 != -398260)
					{
						result = M101_CarronHunt_thai.getMessage(nCode);
						if (233459 - 16577 != 216883)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M102_MupoRoundUp")
				{
					if (210819 - 423787 != -212967)
					{
						result = M102_MupoRoundUp_thai.getMessage(nCode);
						if (288033 - 278343 != 9691)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M105_NeedleCave")
				{
					if (171634 - 96925 != 74710)
					{
						result = M105_NeedleCave_thai.getMessage(nCode);
						if (252396 - 575875 != -323478)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M106_BoldasRecruitment")
				{
					if (242926 - 71944 != 170983)
					{
						result = M106_BoldasRecruitment_thai.getMessage(nCode);
						if (57276 - 370704 != -313427)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M107_RequestFromAlcacia")
				{
					if (230939 - 577797 != -346857)
					{
						result = M107_RequestFromAlcacia_thai.getMessage(nCode);
						if (97053 - 67643 != 29411)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M201_MupoFarmWatch")
				{
					if (22570 - 479278 == -456708)
					{
						result = M201_MupoFarmWatch_thai.getMessage(nCode);
						if (281130 - 547907 != -266776)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M202_RunMupoRun")
				{
					if (112704 - 379519 == -266815)
					{
						result = M202_RunMupoRun_thai.getMessage(nCode);
						if (145773 - 282054 != -136280)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M203_StartofALongJourney")
				{
					if (15180 - 198991 == -183811)
					{
						result = M203_StartofALongJourney_thai.getMessage(nCode);
						if (123128 - 460013 == -336885)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M206_GrandTheftMupo")
				{
					if (107163 - 441967 == -334804)
					{
						result = M206_GrandTheftMupo_thai.getMessage(nCode);
						if (115212 - 397785 != -282572)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M207_TroublingGiant")
				{
					if (250864 - 114591 == 136273)
					{
						result = M207_TroublingGiant_thai.getMessage(nCode);
						if (238565 - 329005 != -90439)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M301_FrozenPeppon")
				{
					if (102061 - 17530 == 84531)
					{
						result = M301_FrozenPeppon_thai.getMessage(nCode);
						if (63925 - 520283 == -456358)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M303_SnowPass")
				{
					if (111265 - 32892 != 78374)
					{
						result = M303_SnowPass_thai.getMessage(nCode);
						if (59934 - 596332 != -536397)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M305_ItalusAcceptance")
				{
					if (210645 - 391867 == -181222)
					{
						result = M305_ItalusAcceptance_thai.getMessage(nCode);
						if (13017 - 433365 != -420347)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M306_FireCaveEntrance")
				{
					if (163503 - 217354 == -53851)
					{
						result = M306_FireCaveEntrance_thai.getMessage(nCode);
						if (85058 - 554411 == -469353)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M307_FireThrone")
				{
					if (116261 - 303355 != -187093)
					{
						result = M307_FireThrone_thai.getMessage(nCode);
						if (155730 - 169807 != -14076)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M402_DesertPath")
				{
					if (20191 - 327719 == -307528)
					{
						result = M402_DesertPath_thai.getMessage(nCode);
						if (269370 - 84172 != 185199)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M403_CactonGarden")
				{
					if (112737 - 230744 != -118006)
					{
						result = M403_CactonGarden_thai.getMessage(nCode);
						if (248081 - 104693 != 143389)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M404_SandOasis")
				{
					if (86479 - 25926 == 60553)
					{
						result = M404_SandOasis_thai.getMessage(nCode);
						if (80418 - 188049 != -107630)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M405_WindValleyEntrance")
				{
					if (290246 - 185946 != 104301)
					{
						result = M405_WindValleyEntrance_thai.getMessage(nCode);
						if (103314 - 462730 == -359416)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M407_CatchTheWind")
				{
					if (284903 - 526728 != -241824)
					{
						result = M407_CatchTheWind_thai.getMessage(nCode);
						if (58315 - 120464 != -62148)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M502_ToTheBeach")
				{
					if (92449 - 239897 != -147447)
					{
						result = M502_ToTheBeach_thai.getMessage(nCode);
						if (44988 - 277012 != -232023)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M503_TwoTurtleSages")
				{
					if (145107 - 156359 == -11252)
					{
						result = M503_TwoTurtleSages_thai.getMessage(nCode);
						if (40880 - 452502 == -411622)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M504_WaterTemple")
				{
					if (145993 - 181207 != -35213)
					{
						result = M504_WaterTemple_thai.getMessage(nCode);
						if (222773 - 234471 != -11697)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M505_SunkenCity")
				{
					if (631 - 270599 == -269968)
					{
						result = M505_SunkenCity_thai.getMessage(nCode);
						if (201012 - 536169 != -335156)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M506_PearlPalace")
				{
					if (245764 - 160590 != 85175)
					{
						result = M506_PearlPalace_thai.getMessage(nCode);
						if (277905 - 593478 == -315573)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M507_AnemoneDecision")
				{
					if (1257 - 465689 == -464432)
					{
						result = M507_AnemoneDecision_thai.getMessage(nCode);
						if (189669 - 126015 == 63654)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M601_FlightBackToTheCity")
				{
					if (153760 - 555904 != -402143)
					{
						result = M601_FlightBackToTheCity_thai.getMessage(nCode);
						if (213229 - 367955 == -154726)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M602_HighWayBlockade")
				{
					if (271250 - 573187 != -301936)
					{
						result = M602_HighWayBlockade_thai.getMessage(nCode);
						if (144362 - 79201 == 65161)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M603_ShadeInTheCity")
				{
					if (158807 - 284245 == -125438)
					{
						result = M603_ShadeInTheCity_thai.getMessage(nCode);
						if (80418 - 518071 != -437652)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M606_WalrusGoneMad")
				{
					if (10010 - 421206 == -411196)
					{
						result = M606_WalrusGoneMad_thai.getMessage(nCode);
						if (40047 - 292678 != -252630)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M607_MessageFromShadow")
				{
					if (43218 - 232577 != -189358)
					{
						result = M607_MessageFromShadow_thai.getMessage(nCode);
						if (36702 - 114057 != -77354)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M701_StrangeNewFoe")
				{
					if (58428 - 383249 == -324821)
					{
						result = M701_StrangeNewFoe_thai.getMessage(nCode);
						if (54476 - 451329 == -396853)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M702_EasternWorldDivide")
				{
					if (31168 - 505804 != -474635)
					{
						result = M702_EasternWorldDivide_thai.getMessage(nCode);
						if (163856 - 203941 == -40085)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M703_SandDuneTerror")
				{
					if (235021 - 511959 == -276938)
					{
						result = M703_SandDuneTerror_thai.getMessage(nCode);
						if (195253 - 15258 == 179995)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M704_ZappaBaseEntrance")
				{
					if (237398 - 304616 == -67218)
					{
						result = M704_ZappaBaseEntrance_thai.getMessage(nCode);
						if (290808 - 341562 == -50754)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M705_InsideZappaBase")
				{
					if (255065 - 226086 == 28979)
					{
						result = M705_InsideZappaBase_thai.getMessage(nCode);
						if (234381 - 111780 != 122602)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M706_MeetDrZappa")
				{
					if (293660 - 134766 == 158894)
					{
						result = M706_MeetDrZappa_thai.getMessage(nCode);
						if (217923 - 588835 == -370912)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M707_MachineFromThePast")
				{
					if (14733 - 13085 == 1648)
					{
						result = M707_MachineFromThePast_thai.getMessage(nCode);
						if (3122 - 365315 != -362192)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M801_LifeAsAGallonBot")
				{
					if (49357 - 283168 != -233810)
					{
						result = M801_LifeAsAGallonBot_thai.getMessage(nCode);
						if (276251 - 120041 != 156211)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M802_BoldasFinalTest")
				{
					if (170836 - 363094 == -192258)
					{
						result = M802_BoldasFinalTest_thai.getMessage(nCode);
						if (250996 - 283109 != -32112)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M803_SteelInvader")
				{
					if (130163 - 483980 == -353817)
					{
						result = M803_SteelInvader_thai.getMessage(nCode);
						if (166200 - 280587 == -114387)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M804_LibraryElevator")
				{
					if (112729 - 288781 != -176051)
					{
						result = M804_LibraryElevator_thai.getMessage(nCode);
						if (20115 - 525929 == -505814)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M806_EnlagearsFlagment")
				{
					if (19271 - 191966 != -172694)
					{
						result = M806_EnlagearsFlagment_thai.getMessage(nCode);
						if (290932 - 242486 == 48446)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M807_RemnantOfTime")
				{
					if (41783 - 455981 != -414197)
					{
						result = M807_RemnantOfTime_thai.getMessage(nCode);
						if (289434 - 550477 != -261042)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M901_BurningSnowForest")
				{
					if (181847 - 417256 != -235408)
					{
						result = M901_BurningSnowForest_thai.getMessage(nCode);
						if (79258 - 417796 == -338538)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M902_MadVegetables")
				{
					if (58353 - 228139 != -169785)
					{
						result = M902_MadVegetables_thai.getMessage(nCode);
						if (274884 - 316173 == -41289)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M903_ShadowPalace")
				{
					if (296445 - 367099 != -70653)
					{
						result = M903_ShadowPalace_thai.getMessage(nCode);
						if (29066 - 220656 != -191589)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M904_BattleWithZerbiras")
				{
					if (34326 - 247782 == -213456)
					{
						result = M904_BattleWithZerbiras_thai.getMessage(nCode);
						if (255332 - 344106 != -88773)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M905_DarknessWithin")
				{
					if (262569 - 97788 != 164782)
					{
						result = M905_DarknessWithin_thai.getMessage(nCode);
						if (285061 - 251089 != 33973)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M906_ShadowGodZera")
				{
					if (157816 - 264952 == -107136)
					{
						result = M906_ShadowGodZera_thai.getMessage(nCode);
						if (186137 - 163344 != 22794)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M907_ZerasHiddenPlan")
				{
					if (290422 - 512019 != -221596)
					{
						result = M907_ZerasHiddenPlan_thai.getMessage(nCode);
						if (118111 - 29730 != 88382)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M911_LavuAttack")
				{
					if (268990 - 485169 != -216178)
					{
						result = M911_LavuAttack_thai.getMessage(nCode);
						if (281399 - 213790 == 67609)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M912_ArmyTraining")
				{
					if (182108 - 260491 == -78383)
					{
						result = M912_ArmyTraining_thai.getMessage(nCode);
						if (251784 - 295418 == -43634)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M913_CarrierSite")
				{
					if (268812 - 552889 != -284076)
					{
						result = M913_CarrierSite_thai.getMessage(nCode);
						if (183840 - 259982 == -76142)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M914_GuildUnderAttack")
				{
					if (208133 - 95019 == 113114)
					{
						result = M914_GuildUnderAttack_thai.getMessage(nCode);
						if (163838 - 527104 != -363265)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M915_BattleAtGreatPlain")
				{
					if (42290 - 504987 == -462697)
					{
						result = M915_BattleAtGreatPlain_thai.getMessage(nCode);
						if (103065 - 467475 != -364409)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M916_CityUnderSiege")
				{
					if (35399 - 524313 == -488914)
					{
						result = M916_CityUnderSiege_thai.getMessage(nCode);
						if (144397 - 482669 == -338272)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M917_WarRepose")
				{
					if (192565 - 72109 == 120456)
					{
						result = M917_WarRepose_thai.getMessage(nCode);
						if (96110 - 231011 != -134900)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M918_Decathon")
				{
					if (69187 - 273869 != -204681)
					{
						result = M918_Decathon_thai.getMessage(nCode);
						if (283122 - 361728 == -78606)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M921_AncientForest")
				{
					if (240884 - 572052 != -331167)
					{
						result = M921_AncientForest_thai.getMessage(nCode);
						if (33422 - 375949 == -342527)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M922_DancingHippos")
				{
					if (32289 - 106915 == -74626)
					{
						result = M922_DancingHippos_thai.getMessage(nCode);
						if (176153 - 530243 == -354090)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M924_LostWoods")
				{
					if (54604 - 121654 != -67049)
					{
						result = M924_LostWoods_thai.getMessage(nCode);
						if (290561 - 67707 != 222855)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M925_WrathOfTitan")
				{
					if (145694 - 64941 != 80754)
					{
						result = M925_WrathOfTitan_thai.getMessage(nCode);
						if (143148 - 367308 != -224159)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M926_WhenWindStops")
				{
					if (130031 - 110980 != 19052)
					{
						result = M926_WhenWindStops_thai.getMessage(nCode);
						if (150560 - 152829 != -2268)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M927_SilentEarth")
				{
					if (158424 - 499854 == -341430)
					{
						result = M927_SilentEarth_thai.getMessage(nCode);
						if (55834 - 102800 != -46965)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M931_IAmNoKnight")
				{
					if (280016 - 546962 == -266946)
					{
						result = M931_IAmNoKnight_thai.getMessage(nCode);
						if (288591 - 328257 != -39665)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M932_WindHollow")
				{
					if (161429 - 233952 == -72523)
					{
						result = M932_WindHollow_thai.getMessage(nCode);
						if (270703 - 247517 == 23186)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M934_LadyNoirDarkRitual")
				{
					if (222911 - 389433 == -166522)
					{
						result = M934_LadyNoirDarkRitual_thai.getMessage(nCode);
						if (243135 - 479639 != -236503)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M935_TormentWoods")
				{
					if (85800 - 175618 != -89817)
					{
						result = M935_TormentWoods_thai.getMessage(nCode);
						if (6567 - 576939 == -570372)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M936_CrossingDestiny")
				{
					if (277702 - 142222 == 135480)
					{
						result = M936_CrossingDestiny_thai.getMessage(nCode);
						if (190347 - 322957 == -132610)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M937_BattleForTomorrow")
				{
					if (164822 - 220703 == -55881)
					{
						result = M937_BattleForTomorrow_thai.getMessage(nCode);
						if (189590 - 7886 == 181704)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M938_TimesMemories")
				{
					if (176822 - 267166 != -90343)
					{
						result = M938_TimesMemories_thai.getMessage(nCode);
						if (102004 - 516014 == -414010)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M941_SkyBug")
				{
					if (38968 - 111870 != -72901)
					{
						result = M941_SkyBug_thai.getMessage(nCode);
						if (210315 - 349441 == -139126)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M946_GoldenKingBug")
				{
					if (229511 - 416666 != -187154)
					{
						result = M946_GoldenKingBug_thai.getMessage(nCode);
						if (199635 - 382875 == -183240)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M947_NemesisBug")
				{
					if (9123 - 273790 != -264666)
					{
						result = M947_NemesisBug_thai.getMessage(nCode);
						if (164618 - 456274 != -291655)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M948_HellRisers")
				{
					if (262000 - 360129 != -98128)
					{
						result = M948_HellRisers_thai.getMessage(nCode);
						if (219570 - 571633 != -352062)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M949_PurgatoryPlain")
				{
					if (58727 - 281530 != -222802)
					{
						result = M949_PurgatoryPlain_thai.getMessage(nCode);
						if (271195 - 145674 == 125521)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M965_UltimateQuiz")
				{
					if (150362 - 138813 == 11549)
					{
						result = M965_UltimateQuiz_thai.getMessage(nCode);
						if (120636 - 374160 != -253523)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M971_MaohsTomb")
				{
					if (225195 - 101572 != 123624)
					{
						result = M971_MaohsTomb_thai.getMessage(nCode);
						if (237464 - 222412 == 15052)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M972_IceTower")
				{
					if (126593 - 413604 == -287011)
					{
						result = M972_IceTower_thai.getMessage(nCode);
						if (61162 - 253415 == -192253)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M973_PirateCave")
				{
					if (176258 - 100969 != 75290)
					{
						result = M973_PirateCave_thai.getMessage(nCode);
						if (57622 - 536044 == -478422)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M974_DemonicTown")
				{
					if (93818 - 147871 != -54052)
					{
						result = M974_DemonicTown_thai.getMessage(nCode);
						if (110273 - 285573 != -175299)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M974_DemonicGate")
				{
					if (63143 - 392876 == -329733)
					{
						result = M974_DemonicGate_thai.getMessage(nCode);
						if (120600 - 219818 != -99217)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M974_DeliverancePass")
				{
					if (170400 - 437165 == -266765)
					{
						result = M974_DeliverancePass_thai.getMessage(nCode);
						if (262419 - 32166 == 230253)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M974_HellCarousel")
				{
					if (167160 - 80572 == 86588)
					{
						result = M974_HellCarousel_thai.getMessage(nCode);
						if (115687 - 472132 == -356445)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M992_FireLordsOrdeal")
				{
					if (59027 - 341438 == -282411)
					{
						result = M992_FireLordsOrdeal_thai.getMessage(nCode);
						if (189514 - 243258 == -53744)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M993_WindsAmusement")
				{
					if (84073 - 93358 == -9285)
					{
						result = M993_WindsAmusement_thai.getMessage(nCode);
						if (261443 - 247767 != 13677)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q1_LetterToBoldas")
				{
					if (28673 - 34427 == -5754)
					{
						result = Q1_LetterToBoldas_thai.getMessage(nCode);
						if (88343 - 558591 == -470248)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q2_HungryXinfu")
				{
					if (236803 - 354352 != -117548)
					{
						result = Q2_HungryXinfu_thai.getMessage(nCode);
						if (21691 - 179314 == -157623)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q4_DontSkipYourBreakfast")
				{
					if (185694 - 359349 != -173654)
					{
						result = Q4_DontSkipYourBreakfast_thai.getMessage(nCode);
						if (230535 - 579684 == -349149)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q5_FahTradingCard")
				{
					if (20314 - 66674 == -46360)
					{
						result = Q5_FahTradingCard_thai.getMessage(nCode);
						if (21958 - 405136 != -383177)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q6_DaringChallenge")
				{
					if (282317 - 9796 != 272522)
					{
						result = Q6_DaringChallenge_thai.getMessage(nCode);
						if (215296 - 32053 != 183244)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q9_LookingForMaterial")
				{
					if (157597 - 564385 != -406787)
					{
						result = Q9_LookingForMaterial_thai.getMessage(nCode);
						if (2097 - 211298 == -209201)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q13_PantherParty")
				{
					if (254690 - 320315 == -65625)
					{
						result = Q13_PantherParty_thai.getMessage(nCode);
						if (56561 - 164490 == -107929)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q15_FakeBug")
				{
					if (267834 - 473885 == -206051)
					{
						result = Q15_FakeBug_thai.getMessage(nCode);
						if (241228 - 158577 == 82651)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q20_SurveyingSnowPath")
				{
					if (71275 - 133665 != -62389)
					{
						result = Q20_SurveyingSnowPath_thai.getMessage(nCode);
						if (41741 - 329604 != -287862)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q22_DesignerDisfavour")
				{
					if (257932 - 27225 == 230707)
					{
						result = Q22_DesignerDisfavour_thai.getMessage(nCode);
						if (279111 - 531493 == -252382)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q27_HarderStronger")
				{
					if (144005 - 571113 != -427107)
					{
						result = Q27_HarderStronger_thai.getMessage(nCode);
						if (170491 - 598932 != -428440)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q28_DesertPatrol")
				{
					if (170380 - 533833 != -363452)
					{
						result = Q28_DesertPatrol_thai.getMessage(nCode);
						if (86409 - 585121 != -498711)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q52_IBeliveMoleCanFly")
				{
					if (128810 - 464351 != -335540)
					{
						result = Q52_IBeliveMoleCanFly_thai.getMessage(nCode);
						if (15284 - 135005 != -119720)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q53_RegguAlchemy")
				{
					if (105478 - 2129 != 103350)
					{
						result = Q53_RegguAlchemy_thai.getMessage(nCode);
						if (189380 - 551393 == -362013)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q54_LizaResearch")
				{
					if (82158 - 115390 == -33232)
					{
						result = Q54_LizaResearch_thai.getMessage(nCode);
						if (262043 - 164666 == 97377)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q57_NewTasteSalad")
				{
					if (91845 - 271200 == -179355)
					{
						result = Q57_NewTasteSalad_thai.getMessage(nCode);
						if (86318 - 581810 != -495491)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q61_NicoNeedHelp")
				{
					if (230599 - 469390 != -238790)
					{
						result = Q61_NicoNeedHelp_thai.getMessage(nCode);
						if (76761 - 444922 == -368161)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q65_JamonsFire")
				{
					if (89290 - 23697 != 65594)
					{
						result = Q65_JamonsFire_thai.getMessage(nCode);
						if (16812 - 482645 != -465832)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q66_LittleBigVeggie")
				{
					if (277172 - 85904 != 191269)
					{
						result = Q66_LittleBigVeggie_thai.getMessage(nCode);
						if (246971 - 50590 == 196381)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q73_GeologyStudy")
				{
					if (235382 - 537537 != -302154)
					{
						result = Q73_GeologyStudy_thai.getMessage(nCode);
						if (65665 - 40023 != 25643)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q75_FlyMoleToTheMoon")
				{
					if (165493 - 571277 != -405783)
					{
						result = Q75_FlyMoleToTheMoon_thai.getMessage(nCode);
						if (171711 - 512215 != -340503)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q79_MakeItStronger")
				{
					if (77373 - 543666 == -466293)
					{
						result = Q79_MakeItStronger_thai.getMessage(nCode);
						if (24759 - 230543 != -205783)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q82_GiftFromTheEarth")
				{
					if (48048 - 137071 != -89022)
					{
						result = Q82_GiftFromTheEarth_thai.getMessage(nCode);
						if (212000 - 371856 == -159856)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q87_EasyCookingInTheForest")
				{
					if (244612 - 85580 != 159033)
					{
						result = Q87_EasyCookingInTheForest_thai.getMessage(nCode);
						if (104068 - 251514 == -147446)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing Language Script: " + nScriptName + "_thai");
					if (70315 - 48934 != 21382)
					{
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600634E RID: 25422 RVA: 0x00DCB3D0 File Offset: 0x00DC95D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getEnglishDes(string nScriptName, string nString)
	{
		if (30406 - 543328 != -512922)
		{
		}
		string result;
		for (;;)
		{
			result = string.Empty;
			if (109439 - 503758 != -394318)
			{
				if (125772 - 105909 == 19863)
				{
					if (nScriptName == "BatSkill")
					{
						if (4740 - 574844 == -570104)
						{
							result = BatSkill_eng.getDes(nString);
							if (283337 - 398321 != -114983)
							{
								break;
							}
						}
					}
					else if (nScriptName == "BisonSkill")
					{
						if (209567 - 294493 != -84925)
						{
							result = BisonSkill_eng.getDes(nString);
							if (248985 - 457732 != -208746)
							{
								break;
							}
						}
					}
					else if (nScriptName == "CatSkill")
					{
						if (277558 - 313961 == -36403)
						{
							result = CatSkill_eng.getDes(nString);
							if (29732 - 134076 != -104343)
							{
								break;
							}
						}
					}
					else if (nScriptName == "ChameleonSkill")
					{
						if (64770 - 502830 != -438059)
						{
							result = ChameleonSkill_eng.getDes(nString);
							if (46690 - 137312 != -90621)
							{
								break;
							}
						}
					}
					else if (nScriptName == "MoleSkill")
					{
						if (231526 - 221665 == 9861)
						{
							result = MoleSkill_eng.getDes(nString);
							if (177786 - 518671 == -340885)
							{
								break;
							}
						}
					}
					else if (nScriptName == "MonkeySkill")
					{
						if (15078 - 100891 != -85812)
						{
							result = MonkeySkill_eng.getDes(nString);
							if (13204 - 547338 == -534134)
							{
								break;
							}
						}
					}
					else if (nScriptName == "PandaSkill")
					{
						if (17748 - 93496 == -75748)
						{
							result = PandaSkill_eng.getDes(nString);
							if (22669 - 126903 == -104234)
							{
								break;
							}
						}
					}
					else if (nScriptName == "PenguinSkill")
					{
						if (248100 - 5738 != 242363)
						{
							result = PenguinSkill_eng.getDes(nString);
							if (155928 - 535544 != -379615)
							{
								break;
							}
						}
					}
					else if (nScriptName == "RabbitSkill")
					{
						if (66979 - 461844 != -394864)
						{
							result = RabbitSkill_eng.getDes(nString);
							if (242253 - 470011 == -227758)
							{
								break;
							}
						}
					}
					else if (nScriptName == "SheepSkill")
					{
						if (28705 - 74136 != -45430)
						{
							result = SheepSkill_eng.getDes(nString);
							if (281536 - 67997 == 213539)
							{
								break;
							}
						}
					}
					else if (nScriptName == "WhaleSkill")
					{
						if (191189 - 392752 != -201562)
						{
							result = WhaleSkill_eng.getDes(nString);
							if (268627 - 247377 == 21250)
							{
								break;
							}
						}
					}
					else if (nScriptName == "WolfSkill")
					{
						if (247901 - 537270 != -289368)
						{
							result = WolfSkill_eng.getDes(nString);
							if (195407 - 82301 == 113106)
							{
								break;
							}
						}
					}
					else if (nScriptName == "SupplementSkill")
					{
						if (184759 - 451808 != -267048)
						{
							result = SupplementSkill_eng.getDes(nString);
							if (72059 - 546076 != -474016)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nScriptName == "EmotionSkill"))
						{
							break;
						}
						if (114146 - 413552 != -299405)
						{
							result = EmotionSkill_eng.getDes(nString);
							if (30502 - 168587 == -138085)
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

	// Token: 0x0600634F RID: 25423 RVA: 0x00DCB8A8 File Offset: 0x00DC9AA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getEnglishMessage(string nScriptName, int nCode)
	{
		if (1329 - 177719 != -176390)
		{
		}
		string result;
		for (;;)
		{
			result = string.Empty;
			if (161139 - 363219 != -202079 && 212590 - 115148 != 97443)
			{
				if (nScriptName == "AuctionGui")
				{
					if (284590 - 33410 != 251181)
					{
						result = AuctionGui_eng.getMessage(nCode);
						if (259631 - 525415 != -265783)
						{
							break;
						}
					}
				}
				else if (nScriptName == "BankGui")
				{
					if (238913 - 291408 == -52495)
					{
						result = BankGui_eng.getMessage(nCode);
						if (214250 - 300958 == -86708)
						{
							break;
						}
					}
				}
				else if (nScriptName == "CollectorGui")
				{
					if (104166 - 265191 != -161024)
					{
						result = CollectorGui_eng.getMessage(nCode);
						if (229062 - 303801 == -74739)
						{
							break;
						}
					}
				}
				else if (nScriptName == "CompoundGui")
				{
					if (228115 - 437291 == -209176)
					{
						result = CompoundGui_eng.getMessage(nCode);
						if (244040 - 202683 == 41357)
						{
							break;
						}
					}
				}
				else if (nScriptName == "GameGui")
				{
					if (30587 - 129278 != -98690)
					{
						result = GameGui_eng.getMessage(nCode);
						if (167288 - 214428 == -47140)
						{
							break;
						}
					}
				}
				else if (nScriptName == "GuildGui")
				{
					if (41159 - 398682 != -357522)
					{
						result = GuildGui_eng.getMessage(nCode);
						if (27504 - 485283 != -457778)
						{
							break;
						}
					}
				}
				else if (nScriptName == "IceMixerGui")
				{
					if (218934 - 261766 == -42832)
					{
						result = IceMixerGui_eng.getMessage(nCode);
						if (157744 - 400231 == -242487)
						{
							break;
						}
					}
				}
				else if (nScriptName == "LobbyGui")
				{
					if (241555 - 353124 == -111569)
					{
						result = LobbyGuI_eng.getMessage(nCode);
						if (59372 - 582661 != -523288)
						{
							break;
						}
					}
				}
				else if (nScriptName == "MailBoxGui")
				{
					if (270005 - 311459 != -41453)
					{
						result = MailBoxGui_eng.getMessage(nCode);
						if (28339 - 460314 == -431975)
						{
							break;
						}
					}
				}
				else if (nScriptName == "MallGui")
				{
					if (275054 - 310008 != -34953)
					{
						result = MallGui_eng.getMessage(nCode);
						if (151972 - 522443 != -370470)
						{
							break;
						}
					}
				}
				else if (nScriptName == "MissionGui")
				{
					if (40502 - 497366 != -456863)
					{
						result = MissionGui_eng.getMessage(nCode);
						if (150296 - 519411 != -369114)
						{
							break;
						}
					}
				}
				else if (nScriptName == "QuestGui")
				{
					if (195003 - 81549 == 113454)
					{
						result = QuestGui_eng.getMessage(nCode);
						if (14567 - 344391 != -329823)
						{
							break;
						}
					}
				}
				else if (nScriptName == "ShopGui")
				{
					if (246974 - 404791 == -157817)
					{
						result = ShopGui_eng.getMessage(nCode);
						if (99179 - 314024 == -214845)
						{
							break;
						}
					}
				}
				else if (nScriptName == "StorageGui")
				{
					if (211531 - 565057 == -353526)
					{
						result = StorageGui_eng.getMessage(nCode);
						if (11425 - 416507 == -405082)
						{
							break;
						}
					}
				}
				else if (nScriptName == "TransportGui")
				{
					if (183272 - 350751 == -167479)
					{
						result = TransportGui_eng.getMessage(nCode);
						if (286945 - 174564 == 112381)
						{
							break;
						}
					}
				}
				else if (nScriptName == "TutorialGui")
				{
					if (135037 - 241105 == -106068)
					{
						result = TutorialGui_eng.getMessage(nCode);
						if (118076 - 478548 == -360472)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G30_NoGuild")
				{
					if (62873 - 153487 != -90613)
					{
						result = G30_NoGuild_eng.getMessage(nCode);
						if (207495 - 420845 == -213350)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G31_GuildPlain")
				{
					if (70385 - 30752 != 39634)
					{
						result = G31_GuildPlain_eng.getMessage(nCode);
						if (154557 - 453312 == -298755)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G32_SnowCamp")
				{
					if (181153 - 12405 != 168749)
					{
						result = G32_SnowCamp_eng.getMessage(nCode);
						if (155579 - 423521 == -267942)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G33_CrystalBeach")
				{
					if (32375 - 322144 == -289769)
					{
						result = G33_CrystalBeach_eng.getMessage(nCode);
						if (77459 - 219679 == -142220)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G34_ExcavationCamp")
				{
					if (62507 - 441170 != -378662)
					{
						result = G34_ExcavationCamp_eng.getMessage(nCode);
						if (272965 - 250911 != 22055)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G35_UndergroundCamp")
				{
					if (145106 - 531077 != -385970)
					{
						result = G35_UndergroundCamp_eng.getMessage(nCode);
						if (261039 - 141104 == 119935)
						{
							break;
						}
					}
				}
				else if (nScriptName == "G36_ForestCamp")
				{
					if (126043 - 444965 != -318921)
					{
						result = G36_ForestCamp_eng.getMessage(nCode);
						if (184671 - 305470 != -120798)
						{
							break;
						}
					}
				}
				else if (nScriptName == "T51_MainStreet")
				{
					if (31250 - 127198 == -95948)
					{
						result = T51_MainStreet_eng.getMessage(nCode);
						if (215571 - 586164 != -370592)
						{
							break;
						}
					}
				}
				else if (nScriptName == "T52_CentralSquare")
				{
					if (227391 - 502650 == -275259)
					{
						result = T52_CentralSquare_eng.getMessage(nCode);
						if (294289 - 253083 == 41206)
						{
							break;
						}
					}
				}
				else if (nScriptName == "T53_CityLibrary")
				{
					if (147444 - 308850 != -161405)
					{
						result = T53_CityLibrary_eng.getMessage(nCode);
						if (247094 - 79487 != 167608)
						{
							break;
						}
					}
				}
				else if (nScriptName == "T55_LightPalace")
				{
					if (291875 - 598746 == -306871)
					{
						result = T55_LightPalace_eng.getMessage(nCode);
						if (243918 - 380391 == -136473)
						{
							break;
						}
					}
				}
				else if (nScriptName == "T56_PlainColosseum")
				{
					if (10388 - 599316 == -588928)
					{
						result = T56_PlainColosseum_eng.getMessage(nCode);
						if (135754 - 337547 != -201792)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M100_GameTutorial")
				{
					if (249741 - 241511 == 8230)
					{
						result = M100_GameTutorial_eng.getMessage(nCode);
						if (31674 - 94634 == -62960)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M101_CarronHunt")
				{
					if (247044 - 568791 != -321746)
					{
						result = M101_CarronHunt_eng.getMessage(nCode);
						if (145217 - 503550 == -358333)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M102_MupoRoundUp")
				{
					if (27106 - 127299 != -100192)
					{
						result = M102_MupoRoundUp_eng.getMessage(nCode);
						if (183355 - 302718 != -119362)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M105_NeedleCave")
				{
					if (177788 - 445835 != -268046)
					{
						result = M105_NeedleCave_eng.getMessage(nCode);
						if (92892 - 252517 != -159624)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M106_BoldasRecruitment")
				{
					if (50516 - 153845 != -103328)
					{
						result = M106_BoldasRecruitment_eng.getMessage(nCode);
						if (171989 - 234482 == -62493)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M107_RequestFromAlcacia")
				{
					if (265724 - 256631 != 9094)
					{
						result = M107_RequestFromAlcacia_eng.getMessage(nCode);
						if (167227 - 261468 != -94240)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M201_MupoFarmWatch")
				{
					if (51147 - 131410 == -80263)
					{
						result = M201_MupoFarmWatch_eng.getMessage(nCode);
						if (233399 - 468523 != -235123)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M202_RunMupoRun")
				{
					if (133567 - 527823 != -394255)
					{
						result = M202_RunMupoRun_eng.getMessage(nCode);
						if (111314 - 598001 != -486686)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M203_StartofALongJourney")
				{
					if (37263 - 395020 == -357757)
					{
						result = M203_StartofALongJourney_eng.getMessage(nCode);
						if (203752 - 490648 != -286895)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M206_GrandTheftMupo")
				{
					if (2720 - 219107 != -216386)
					{
						result = M206_GrandTheftMupo_eng.getMessage(nCode);
						if (84754 - 508470 != -423715)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M207_TroublingGiant")
				{
					if (291275 - 90415 != 200861)
					{
						result = M207_TroublingGiant_eng.getMessage(nCode);
						if (278643 - 236327 != 42317)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M301_FrozenPeppon")
				{
					if (34433 - 459843 == -425410)
					{
						result = M301_FrozenPeppon_eng.getMessage(nCode);
						if (2359 - 36368 != -34008)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M303_SnowPass")
				{
					if (58583 - 96910 != -38326)
					{
						result = M303_SnowPass_eng.getMessage(nCode);
						if (299426 - 79565 != 219862)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M305_ItalusAcceptance")
				{
					if (77030 - 401300 == -324270)
					{
						result = M305_ItalusAcceptance_eng.getMessage(nCode);
						if (67707 - 386595 != -318887)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M306_FireCaveEntrance")
				{
					if (282483 - 598834 == -316351)
					{
						result = M306_FireCaveEntrance_eng.getMessage(nCode);
						if (295821 - 241948 == 53873)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M307_FireThrone")
				{
					if (14287 - 321497 == -307210)
					{
						result = M307_FireThrone_eng.getMessage(nCode);
						if (227473 - 166155 != 61319)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M402_DesertPath")
				{
					if (39421 - 3288 == 36133)
					{
						result = M402_DesertPath_eng.getMessage(nCode);
						if (34309 - 75530 != -41220)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M403_CactonGarden")
				{
					if (199583 - 304085 != -104501)
					{
						result = M403_CactonGarden_eng.getMessage(nCode);
						if (176639 - 153265 != 23375)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M404_SandOasis")
				{
					if (232208 - 331287 != -99078)
					{
						result = M404_SandOasis_eng.getMessage(nCode);
						if (255152 - 101405 == 153747)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M405_WindValleyEntrance")
				{
					if (215675 - 431152 != -215476)
					{
						result = M405_WindValleyEntrance_eng.getMessage(nCode);
						if (124473 - 312615 == -188142)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M407_CatchTheWind")
				{
					if (76493 - 354752 == -278259)
					{
						result = M407_CatchTheWind_eng.getMessage(nCode);
						if (186644 - 559945 != -373300)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M502_ToTheBeach")
				{
					if (107003 - 557335 == -450332)
					{
						result = M502_ToTheBeach_eng.getMessage(nCode);
						if (215466 - 348821 != -133354)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M503_TwoTurtleSages")
				{
					if (263797 - 440936 != -177138)
					{
						result = M503_TwoTurtleSages_eng.getMessage(nCode);
						if (141677 - 158144 == -16467)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M504_WaterTemple")
				{
					if (282506 - 392343 == -109837)
					{
						result = M504_WaterTemple_eng.getMessage(nCode);
						if (26245 - 270243 != -243997)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M505_SunkenCity")
				{
					if (277058 - 501939 == -224881)
					{
						result = M505_SunkenCity_eng.getMessage(nCode);
						if (49292 - 388708 == -339416)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M506_PearlPalace")
				{
					if (276768 - 168168 != 108601)
					{
						result = M506_PearlPalace_eng.getMessage(nCode);
						if (81673 - 485897 != -404223)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M507_AnemoneDecision")
				{
					if (115077 - 395161 == -280084)
					{
						result = M507_AnemoneDecision_eng.getMessage(nCode);
						if (170753 - 252809 == -82056)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M601_FlightBackToTheCity")
				{
					if (293111 - 463387 != -170275)
					{
						result = M601_FlightBackToTheCity_eng.getMessage(nCode);
						if (220946 - 445790 != -224843)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M602_HighWayBlockade")
				{
					if (234483 - 90806 == 143677)
					{
						result = M602_HighWayBlockade_eng.getMessage(nCode);
						if (73283 - 177000 != -103716)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M603_ShadeInTheCity")
				{
					if (192675 - 495756 == -303081)
					{
						result = M603_ShadeInTheCity_eng.getMessage(nCode);
						if (201982 - 216849 == -14867)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M606_WalrusGoneMad")
				{
					if (95250 - 77737 == 17513)
					{
						result = M606_WalrusGoneMad_eng.getMessage(nCode);
						if (192331 - 471781 != -279449)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M607_MessageFromShadow")
				{
					if (189811 - 595895 == -406084)
					{
						result = M607_MessageFromShadow_eng.getMessage(nCode);
						if (62787 - 218598 != -155810)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M701_StrangeNewFoe")
				{
					if (268350 - 267124 != 1227)
					{
						result = M701_StrangeNewFoe_eng.getMessage(nCode);
						if (263681 - 574251 != -310569)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M702_EasternWorldDivide")
				{
					if (224329 - 185990 != 38340)
					{
						result = M702_EasternWorldDivide_eng.getMessage(nCode);
						if (106714 - 336250 == -229536)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M703_SandDuneTerror")
				{
					if (45071 - 594643 != -549571)
					{
						result = M703_SandDuneTerror_eng.getMessage(nCode);
						if (242951 - 167232 == 75719)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M704_ZappaBaseEntrance")
				{
					if (299755 - 443769 != -144013)
					{
						result = M704_ZappaBaseEntrance_eng.getMessage(nCode);
						if (171642 - 135410 != 36233)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M705_InsideZappaBase")
				{
					if (287748 - 508627 != -220878)
					{
						result = M705_InsideZappaBase_eng.getMessage(nCode);
						if (257629 - 267924 == -10295)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M706_MeetDrZappa")
				{
					if (66924 - 84172 == -17248)
					{
						result = M706_MeetDrZappa_eng.getMessage(nCode);
						if (255165 - 147166 == 107999)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M707_MachineFromThePast")
				{
					if (252779 - 531361 != -278581)
					{
						result = M707_MachineFromThePast_eng.getMessage(nCode);
						if (237912 - 432888 == -194976)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M801_LifeAsAGallonBot")
				{
					if (56772 - 521249 == -464477)
					{
						result = M801_LifeAsAGallonBot_eng.getMessage(nCode);
						if (116329 - 458963 == -342634)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M802_BoldasFinalTest")
				{
					if (83521 - 3945 != 79577)
					{
						result = M802_BoldasFinalTest_eng.getMessage(nCode);
						if (83127 - 103529 != -20401)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M803_SteelInvader")
				{
					if (192933 - 373621 != -180687)
					{
						result = M803_SteelInvader_eng.getMessage(nCode);
						if (419 - 420738 == -420319)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M804_LibraryElevator")
				{
					if (107055 - 317169 != -210113)
					{
						result = M804_LibraryElevator_eng.getMessage(nCode);
						if (131434 - 597886 != -466451)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M806_EnlagearsFlagment")
				{
					if (251923 - 535433 == -283510)
					{
						result = M806_EnlagearsFlagment_eng.getMessage(nCode);
						if (80495 - 207477 == -126982)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M807_RemnantOfTime")
				{
					if (164382 - 175743 != -11360)
					{
						result = M807_RemnantOfTime_eng.getMessage(nCode);
						if (259670 - 297544 != -37873)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M901_BurningSnowForest")
				{
					if (86075 - 138441 == -52366)
					{
						result = M901_BurningSnowForest_eng.getMessage(nCode);
						if (197149 - 289714 == -92565)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M902_MadVegetables")
				{
					if (224770 - 470372 == -245602)
					{
						result = M902_MadVegetables_eng.getMessage(nCode);
						if (43803 - 572191 != -528387)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M903_ShadowPalace")
				{
					if (235032 - 537642 == -302610)
					{
						result = M903_ShadowPalace_eng.getMessage(nCode);
						if (108584 - 544326 != -435741)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M904_BattleWithZerbiras")
				{
					if (147044 - 239053 != -92008)
					{
						result = M904_BattleWithZerbiras_eng.getMessage(nCode);
						if (54411 - 302297 != -247885)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M905_DarknessWithin")
				{
					if (42036 - 299517 != -257480)
					{
						result = M905_DarknessWithin_eng.getMessage(nCode);
						if (156852 - 187704 != -30851)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M906_ShadowGodZera")
				{
					if (235731 - 311250 != -75518)
					{
						result = M906_ShadowGodZera_eng.getMessage(nCode);
						if (270687 - 261867 != 8821)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M907_ZerasHiddenPlan")
				{
					if (148530 - 293157 == -144627)
					{
						result = M907_ZerasHiddenPlan_eng.getMessage(nCode);
						if (79291 - 475699 == -396408)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M911_LavuAttack")
				{
					if (120634 - 244473 != -123838)
					{
						result = M911_LavuAttack_eng.getMessage(nCode);
						if (211309 - 198661 != 12649)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M912_ArmyTraining")
				{
					if (91770 - 262970 != -171199)
					{
						result = M912_ArmyTraining_eng.getMessage(nCode);
						if (114060 - 192567 != -78506)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M913_CarrierSite")
				{
					if (162271 - 179427 == -17156)
					{
						result = M913_CarrierSite_eng.getMessage(nCode);
						if (38329 - 259956 != -221626)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M914_GuildUnderAttack")
				{
					if (119825 - 553295 != -433469)
					{
						result = M914_GuildUnderAttack_eng.getMessage(nCode);
						if (97293 - 128363 == -31070)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M915_BattleAtGreatPlain")
				{
					if (179572 - 585952 != -406379)
					{
						result = M915_BattleAtGreatPlain_eng.getMessage(nCode);
						if (215535 - 486545 == -271010)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M916_CityUnderSiege")
				{
					if (161943 - 224992 != -63048)
					{
						result = M916_CityUnderSiege_eng.getMessage(nCode);
						if (101991 - 197671 != -95679)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M917_WarRepose")
				{
					if (18223 - 64152 == -45929)
					{
						result = M917_WarRepose_eng.getMessage(nCode);
						if (148536 - 59922 == 88614)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M918_Decathon")
				{
					if (166708 - 571724 == -405016)
					{
						result = M918_Decathon_eng.getMessage(nCode);
						if (175453 - 26088 != 149366)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M921_AncientForest")
				{
					if (203634 - 589861 == -386227)
					{
						result = M921_AncientForest_eng.getMessage(nCode);
						if (281476 - 282767 == -1291)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M922_DancingHippos")
				{
					if (3831 - 285040 == -281209)
					{
						result = M922_DancingHippos_eng.getMessage(nCode);
						if (53557 - 17814 != 35744)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M924_LostWoods")
				{
					if (50312 - 360762 == -310450)
					{
						result = M924_LostWoods_eng.getMessage(nCode);
						if (68242 - 247896 != -179653)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M925_WrathOfTitan")
				{
					if (69193 - 518917 == -449724)
					{
						result = M925_WrathOfTitan_eng.getMessage(nCode);
						if (291916 - 360699 == -68783)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M926_WhenWindStops")
				{
					if (215680 - 338332 != -122651)
					{
						result = M926_WhenWindStops_eng.getMessage(nCode);
						if (142551 - 379162 != -236610)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M927_SilentEarth")
				{
					if (8773 - 208222 == -199449)
					{
						result = M927_SilentEarth_eng.getMessage(nCode);
						if (82121 - 385241 == -303120)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M931_IAmNoKnight")
				{
					if (189130 - 282618 != -93487)
					{
						result = M931_IAmNoKnight_eng.getMessage(nCode);
						if (106626 - 513239 != -406612)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M932_WindHollow")
				{
					if (69531 - 318631 != -249099)
					{
						result = M932_WindHollow_eng.getMessage(nCode);
						if (287276 - 237215 == 50061)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M934_LadyNoirDarkRitual")
				{
					if (166733 - 221725 != -54991)
					{
						result = M934_LadyNoirDarkRitual_eng.getMessage(nCode);
						if (263600 - 195395 == 68205)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M935_TormentWoods")
				{
					if (2412 - 227636 == -225224)
					{
						result = M935_TormentWoods_eng.getMessage(nCode);
						if (161966 - 567009 == -405043)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M936_CrossingDestiny")
				{
					if (122250 - 195868 != -73617)
					{
						result = M936_CrossingDestiny_eng.getMessage(nCode);
						if (109021 - 385271 == -276250)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M937_BattleForTomorrow")
				{
					if (213803 - 401442 != -187638)
					{
						result = M937_BattleForTomorrow_eng.getMessage(nCode);
						if (38554 - 16091 != 22464)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M938_TimesMemories")
				{
					if (42539 - 129374 == -86835)
					{
						result = M938_TimesMemories_eng.getMessage(nCode);
						if (296087 - 445848 == -149761)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M941_SkyBug")
				{
					if (219792 - 29456 != 190337)
					{
						result = M941_SkyBug_eng.getMessage(nCode);
						if (223751 - 280739 != -56987)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M946_GoldenKingBug")
				{
					if (250986 - 41184 == 209802)
					{
						result = M946_GoldenKingBug_eng.getMessage(nCode);
						if (180212 - 100159 != 80054)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M947_NemesisBug")
				{
					if (34324 - 461194 == -426870)
					{
						result = M947_NemesisBug_eng.getMessage(nCode);
						if (291121 - 428310 != -137188)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M971_MaohsTomb")
				{
					if (76269 - 513289 != -437019)
					{
						result = M971_MaohsTomb_eng.getMessage(nCode);
						if (91975 - 388583 == -296608)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M972_IceTower")
				{
					if (69905 - 353343 != -283437)
					{
						result = M972_IceTower_eng.getMessage(nCode);
						if (69738 - 133877 != -64138)
						{
							break;
						}
					}
				}
				else if (nScriptName == "M973_PirateCave")
				{
					if (273642 - 467419 == -193777)
					{
						result = M973_PirateCave_eng.getMessage(nCode);
						if (272158 - 37962 != 234197)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q1_LetterToBoldas")
				{
					if (206388 - 427776 == -221388)
					{
						result = Q1_LetterToBoldas_eng.getMessage(nCode);
						if (179216 - 507523 != -328306)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q2_HungryXinfu")
				{
					if (203535 - 151458 != 52078)
					{
						result = Q2_HungryXinfu_eng.getMessage(nCode);
						if (135718 - 394630 == -258912)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q4_DontSkipYourBreakfast")
				{
					if (249218 - 93620 != 155599)
					{
						result = Q4_DontSkipYourBreakfast_eng.getMessage(nCode);
						if (65710 - 435131 == -369421)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q5_FahTradingCard")
				{
					if (220529 - 41613 != 178917)
					{
						result = Q5_FahTradingCard_eng.getMessage(nCode);
						if (174922 - 195424 == -20502)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q6_DaringChallenge")
				{
					if (57865 - 315338 != -257472)
					{
						result = Q6_DaringChallenge_eng.getMessage(nCode);
						if (176087 - 376918 == -200831)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q9_LookingForMaterial")
				{
					if (160889 - 22704 != 138186)
					{
						result = Q9_LookingForMaterial_eng.getMessage(nCode);
						if (138177 - 401226 != -263048)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q13_PantherParty")
				{
					if (223305 - 302469 == -79164)
					{
						result = Q13_PantherParty_eng.getMessage(nCode);
						if (72339 - 553126 == -480787)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q15_FakeBug")
				{
					if (287999 - 73873 != 214127)
					{
						result = Q15_FakeBug_eng.getMessage(nCode);
						if (58021 - 504083 == -446062)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q20_SurveyingSnowPath")
				{
					if (169193 - 428757 == -259564)
					{
						result = Q20_SurveyingSnowPath_eng.getMessage(nCode);
						if (246080 - 168305 == 77775)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q22_DesignerDisfavour")
				{
					if (137727 - 182654 == -44927)
					{
						result = Q22_DesignerDisfavour_eng.getMessage(nCode);
						if (45253 - 249372 != -204118)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q27_HarderStronger")
				{
					if (57451 - 590096 != -532644)
					{
						result = Q27_HarderStronger_eng.getMessage(nCode);
						if (80871 - 166439 == -85568)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q28_DesertPatrol")
				{
					if (149726 - 111635 == 38091)
					{
						result = Q28_DesertPatrol_eng.getMessage(nCode);
						if (83700 - 64026 != 19675)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q52_IBeliveMoleCanFly")
				{
					if (289669 - 500430 != -210760)
					{
						result = Q52_IBeliveMoleCanFly_eng.getMessage(nCode);
						if (290211 - 286215 != 3997)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q53_RegguAlchemy")
				{
					if (285486 - 94705 == 190781)
					{
						result = Q53_RegguAlchemy_eng.getMessage(nCode);
						if (131399 - 246318 == -114919)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q54_LizaResearch")
				{
					if (235438 - 444467 != -209028)
					{
						result = Q54_LizaResearch_eng.getMessage(nCode);
						if (119478 - 560733 != -441254)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q57_NewTasteSalad")
				{
					if (149347 - 432831 != -283483)
					{
						result = Q57_NewTasteSalad_eng.getMessage(nCode);
						if (76746 - 422356 == -345610)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q61_NicoNeedHelp")
				{
					if (214518 - 66007 != 148512)
					{
						result = Q61_NicoNeedHelp_eng.getMessage(nCode);
						if (99432 - 346111 != -246678)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q65_JamonsFire")
				{
					if (100838 - 472865 == -372027)
					{
						result = Q65_JamonsFire_eng.getMessage(nCode);
						if (231366 - 564972 != -333605)
						{
							break;
						}
					}
				}
				else if (nScriptName == "Q66_LittleBigVeggie")
				{
					if (36698 - 404861 != -368162)
					{
						result = Q66_LittleBigVeggie_eng.getMessage(nCode);
						if (242168 - 203198 != 38971)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing Language Script: " + nScriptName + "_eng");
					if (195837 - 216616 != -20778)
					{
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06006350 RID: 25424 RVA: 0x00DCE0B8 File Offset: 0x00DCC2B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006351 RID: 25425 RVA: 0x00DCE0BC File Offset: 0x00DCC2BC
	internal static bool RQTrakpknIHyVejZbcf4()
	{
		return true;
	}

	// Token: 0x06006352 RID: 25426 RVA: 0x00DCE0C0 File Offset: 0x00DCC2C0
	internal static bool pSq7Hopk6cSeBl0kVknQ()
	{
		return false;
	}
}
