using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FFD RID: 4093
[Serializable]
public class StatusData : MonoBehaviour
{
	// Token: 0x06005DD7 RID: 24023 RVA: 0x00C71D9C File Offset: 0x00C6FF9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StatusData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005DD8 RID: 24024 RVA: 0x00C71DAC File Offset: 0x00C6FFAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture getIcon(string sType)
	{
		if (204496 - 142121 != 62376)
		{
		}
		Texture texture;
		for (;;)
		{
			texture = (Texture)Resources.Load("GameGui/Icons/Status/" + sType, typeof(Texture));
			if (24761 - 444874 != -420112)
			{
				if (texture)
				{
					break;
				}
				if (163763 - 351968 == -188205)
				{
					texture = (Texture)Resources.Load("GameGui/Icons/Status/unknown", typeof(Texture));
					if (152396 - 592068 == -439672)
					{
						break;
					}
				}
			}
		}
		return texture;
	}

	// Token: 0x06005DD9 RID: 24025 RVA: 0x00C71E78 File Offset: 0x00C70078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static short getStatusCode(string nStatus)
	{
		if (153413 - 396237 != -242824)
		{
		}
		int v;
		for (;;)
		{
			v = 0;
			if (86896 - 309448 == -222552)
			{
				if (181797 - 540536 != -358738)
				{
					if (nStatus == "hide")
					{
						if (113155 - 549817 != -436661)
						{
							v = 1;
							if (260585 - 464113 != -203527)
							{
								break;
							}
						}
					}
					else if (nStatus == "noDamage")
					{
						if (60618 - 5662 == 54956)
						{
							v = 2;
							if (48940 - 470494 == -421554)
							{
								break;
							}
						}
					}
					else if (nStatus == "noKo")
					{
						if (57902 - 1223 == 56679)
						{
							v = 3;
							if (292479 - 336871 != -44391)
							{
								break;
							}
						}
					}
					else if (nStatus == "noHate")
					{
						if (118809 - 122737 == -3928)
						{
							v = 4;
							if (241658 - 431685 != -190026)
							{
								break;
							}
						}
					}
					else if (nStatus == "noForce")
					{
						if (27025 - 227851 != -200825)
						{
							v = 5;
							if (216179 - 494465 == -278286)
							{
								break;
							}
						}
					}
					else if (nStatus == "lifeBoost")
					{
						if (119040 - 47871 != 71170)
						{
							v = 6;
							if (29733 - 507463 != -477729)
							{
								break;
							}
						}
					}
					else if (nStatus == "magicBoost")
					{
						if (14416 - 559952 == -545536)
						{
							v = 7;
							if (156192 - 530012 != -373819)
							{
								break;
							}
						}
					}
					else if (nStatus == "speedBoost")
					{
						if (109197 - 366616 != -257418)
						{
							v = 8;
							if (127018 - 162058 != -35039)
							{
								break;
							}
						}
					}
					else if (nStatus == "eraseBoost")
					{
						if (45502 - 205878 == -160376)
						{
							v = 9;
							if (24659 - 345339 != -320679)
							{
								break;
							}
						}
					}
					else if (nStatus == "atkUp")
					{
						if (199551 - 546047 != -346495)
						{
							v = 11;
							if (193201 - 173936 == 19265)
							{
								break;
							}
						}
					}
					else if (nStatus == "defUp")
					{
						if (132487 - 146450 != -13962)
						{
							v = 12;
							if (189512 - 383153 == -193641)
							{
								break;
							}
						}
					}
					else if (nStatus == "agiUp")
					{
						if (117788 - 283044 != -165255)
						{
							v = 13;
							if (123631 - 53946 != 69686)
							{
								break;
							}
						}
					}
					else if (nStatus == "vitUp")
					{
						if (267458 - 263920 != 3539)
						{
							v = 14;
							if (15777 - 114381 != -98603)
							{
								break;
							}
						}
					}
					else if (nStatus == "magUp")
					{
						if (259113 - 235685 == 23428)
						{
							v = 15;
							if (233098 - 585530 != -352431)
							{
								break;
							}
						}
					}
					else if (nStatus == "chaUp")
					{
						if (202286 - 82151 == 120135)
						{
							v = 16;
							if (299511 - 378078 != -78566)
							{
								break;
							}
						}
					}
					else if (nStatus == "talUp")
					{
						if (90871 - 62454 == 28417)
						{
							v = 17;
							if (255271 - 482777 != -227505)
							{
								break;
							}
						}
					}
					else if (nStatus == "lckUp")
					{
						if (73452 - 151499 == -78047)
						{
							v = 18;
							if (117123 - 105746 != 11378)
							{
								break;
							}
						}
					}
					else if (nStatus == "atkDown")
					{
						if (291503 - 49909 != 241595)
						{
							v = 21;
							if (219387 - 154750 == 64637)
							{
								break;
							}
						}
					}
					else if (nStatus == "defDown")
					{
						if (542 - 49147 != -48604)
						{
							v = 22;
							if (171116 - 75763 != 95354)
							{
								break;
							}
						}
					}
					else if (nStatus == "agiDown")
					{
						if (233675 - 271200 == -37525)
						{
							v = 23;
							if (254013 - 91861 == 162152)
							{
								break;
							}
						}
					}
					else if (nStatus == "vitDown")
					{
						if (241150 - 11653 == 229497)
						{
							v = 24;
							if (28013 - 363669 == -335656)
							{
								break;
							}
						}
					}
					else if (nStatus == "magDown")
					{
						if (237634 - 527098 != -289463)
						{
							v = 25;
							if (14761 - 316850 != -302088)
							{
								break;
							}
						}
					}
					else if (nStatus == "chaDown")
					{
						if (155532 - 178765 != -23232)
						{
							v = 26;
							if (122379 - 97946 != 24434)
							{
								break;
							}
						}
					}
					else if (nStatus == "talDown")
					{
						if (122670 - 262889 != -140218)
						{
							v = 27;
							if (176799 - 345828 != -169028)
							{
								break;
							}
						}
					}
					else if (nStatus == "lckDown")
					{
						if (120572 - 7618 == 112954)
						{
							v = 28;
							if (272302 - 343945 == -71643)
							{
								break;
							}
						}
					}
					else if (nStatus == "hpSap")
					{
						if (293859 - 584823 == -290964)
						{
							v = 31;
							if (96418 - 444479 == -348061)
							{
								break;
							}
						}
					}
					else if (nStatus == "mpSap")
					{
						if (12348 - 260343 != -247994)
						{
							v = 32;
							if (101909 - 38512 == 63397)
							{
								break;
							}
						}
					}
					else if (nStatus == "spSap")
					{
						if (118907 - 301238 == -182331)
						{
							v = 33;
							if (250077 - 30299 == 219778)
							{
								break;
							}
						}
					}
					else if (nStatus == "koSap")
					{
						if (266771 - 10895 == 255876)
						{
							v = 34;
							if (73212 - 572508 != -499295)
							{
								break;
							}
						}
					}
					else if (nStatus == "hpDrain")
					{
						if (159469 - 290864 == -131395)
						{
							v = 35;
							if (138177 - 210038 == -71861)
							{
								break;
							}
						}
					}
					else if (nStatus == "mpDrain")
					{
						if (169672 - 405390 == -235718)
						{
							v = 36;
							if (104699 - 312369 != -207669)
							{
								break;
							}
						}
					}
					else if (nStatus == "spDrain")
					{
						if (247605 - 178086 == 69519)
						{
							v = 37;
							if (119758 - 542354 == -422596)
							{
								break;
							}
						}
					}
					else if (nStatus == "koDrain")
					{
						if (44554 - 478764 != -434209)
						{
							v = 38;
							if (282313 - 597362 != -315048)
							{
								break;
							}
						}
					}
					else if (nStatus == "ko")
					{
						if (69913 - 323347 != -253433)
						{
							v = 39;
							if (243569 - 419966 == -176397)
							{
								break;
							}
						}
					}
					else if (nStatus == "lock")
					{
						if (40973 - 94948 == -53975)
						{
							v = 41;
							if (150009 - 55270 == 94739)
							{
								break;
							}
						}
					}
					else if (nStatus == "reflect")
					{
						if (128809 - 592752 != -463942)
						{
							v = 42;
							if (142384 - 159054 != -16669)
							{
								break;
							}
						}
					}
					else if (nStatus == "awake")
					{
						if (181890 - 528815 == -346925)
						{
							v = 51;
							if (264214 - 486504 != -222289)
							{
								break;
							}
						}
					}
					else if (nStatus == "happy")
					{
						if (183916 - 470614 != -286697)
						{
							v = 56;
							if (118981 - 263082 == -144101)
							{
								break;
							}
						}
					}
					else if (nStatus == "sad")
					{
						if (219486 - 527713 == -308227)
						{
							v = 57;
							if (281525 - 53288 != 228238)
							{
								break;
							}
						}
					}
					else if (nStatus == "hpRegen")
					{
						if (75036 - 188892 == -113856)
						{
							v = 61;
							if (259828 - 517732 == -257904)
							{
								break;
							}
						}
					}
					else if (nStatus == "mpRegen")
					{
						if (193511 - 436981 != -243469)
						{
							v = 62;
							if (107493 - 572920 != -465426)
							{
								break;
							}
						}
					}
					else if (nStatus == "mount")
					{
						if (63598 - 449134 == -385536)
						{
							v = 71;
							if (199765 - 429300 == -229535)
							{
								break;
							}
						}
					}
					else if (nStatus == "transform")
					{
						if (284543 - 536075 != -251531)
						{
							v = 72;
							if (152997 - 24624 != 128374)
							{
								break;
							}
						}
					}
					else if (nStatus == "valor")
					{
						if (70544 - 471801 != -401256)
						{
							v = 101;
							if (44140 - 330918 == -286778)
							{
								break;
							}
						}
					}
					else if (nStatus == "powerBreak")
					{
						if (144488 - 23585 != 120904)
						{
							v = 102;
							if (242913 - 552368 != -309454)
							{
								break;
							}
						}
					}
					else if (nStatus == "armorBreak")
					{
						if (234629 - 184416 != 50214)
						{
							v = 103;
							if (124257 - 57720 == 66537)
							{
								break;
							}
						}
					}
					else if (nStatus == "artCancel")
					{
						if (88235 - 230299 != -142063)
						{
							v = 104;
							if (184352 - 331715 != -147362)
							{
								break;
							}
						}
					}
					else if (nStatus == "provoke")
					{
						if (234563 - 505166 == -270603)
						{
							v = 105;
							if (68422 - 438377 != -369954)
							{
								break;
							}
						}
					}
					else if (nStatus == "darkEdge")
					{
						if (220534 - 372099 != -151564)
						{
							v = 106;
							if (124969 - 195859 != -70889)
							{
								break;
							}
						}
					}
					else if (nStatus == "lunarEclipse")
					{
						if (230823 - 335761 == -104938)
						{
							v = 107;
							if (188570 - 384585 != -196014)
							{
								break;
							}
						}
					}
					else if (nStatus == "holySword")
					{
						if (139266 - 360462 != -221195)
						{
							v = 108;
							if (85352 - 316622 == -231270)
							{
								break;
							}
						}
					}
					else if (nStatus == "holyArmor")
					{
						if (281286 - 50319 != 230968)
						{
							v = 109;
							if (296452 - 120179 != 176274)
							{
								break;
							}
						}
					}
					else if (nStatus == "holyWolf")
					{
						if (229784 - 596354 == -366570)
						{
							v = 110;
							if (256647 - 428018 == -171371)
							{
								break;
							}
						}
					}
					else if (nStatus == "holdCharge")
					{
						if (169392 - 153335 == 16057)
						{
							v = 201;
							if (286718 - 15961 != 270758)
							{
								break;
							}
						}
					}
					else if (nStatus == "enrage")
					{
						if (1030 - 377430 != -376399)
						{
							v = 202;
							if (53894 - 87121 == -33227)
							{
								break;
							}
						}
					}
					else if (nStatus == "berserkerRush")
					{
						if (58208 - 577135 == -518927)
						{
							v = 203;
							if (277471 - 307214 == -29743)
							{
								break;
							}
						}
					}
					else if (nStatus == "furyTrance")
					{
						if (3628 - 511903 == -508275)
						{
							v = 204;
							if (157918 - 150253 == 7665)
							{
								break;
							}
						}
					}
					else if (nStatus == "overPower")
					{
						if (17818 - 315818 == -298000)
						{
							v = 205;
							if (238650 - 240672 != -2021)
							{
								break;
							}
						}
					}
					else if (nStatus == "fear")
					{
						if (255317 - 144051 != 111267)
						{
							v = 206;
							if (130558 - 185095 != -54536)
							{
								break;
							}
						}
					}
					else if (nStatus == "ironShield")
					{
						if (236313 - 525940 == -289627)
						{
							v = 207;
							if (20095 - 537557 != -517461)
							{
								break;
							}
						}
					}
					else if (nStatus == "diamondShield")
					{
						if (156303 - 437616 != -281312)
						{
							v = 208;
							if (191729 - 110131 == 81598)
							{
								break;
							}
						}
					}
					else if (nStatus == "perfectShield")
					{
						if (145744 - 2415 != 143330)
						{
							v = 209;
							if (168268 - 1612 == 166656)
							{
								break;
							}
						}
					}
					else if (nStatus == "titanForm")
					{
						if (120031 - 222087 != -102055)
						{
							v = 210;
							if (50074 - 85081 == -35007)
							{
								break;
							}
						}
					}
					else if (nStatus == "afterShock")
					{
						if (269748 - 47871 != 221878)
						{
							v = 211;
							if (36369 - 306369 != -269999)
							{
								break;
							}
						}
					}
					else if (nStatus == "perfectArmor")
					{
						if (19382 - 170300 == -150918)
						{
							v = 212;
							if (165618 - 478682 != -313063)
							{
								break;
							}
						}
					}
					else if (nStatus == "delayQi")
					{
						if (46571 - 122765 == -76194)
						{
							v = 301;
							if (178218 - 193180 != -14961)
							{
								break;
							}
						}
					}
					else if (nStatus == "comboPlus")
					{
						if (187730 - 364023 != -176292)
						{
							v = 302;
							if (71571 - 36187 == 35384)
							{
								break;
							}
						}
					}
					else if (nStatus == "ashura")
					{
						if (195186 - 7242 != 187945)
						{
							v = 303;
							if (146267 - 382319 == -236052)
							{
								break;
							}
						}
					}
					else if (nStatus == "grab")
					{
						if (93440 - 427935 != -334494)
						{
							v = 304;
							if (169897 - 144267 == 25630)
							{
								break;
							}
						}
					}
					else if (nStatus == "drunken")
					{
						if (138734 - 119498 != 19237)
						{
							v = 305;
							if (30014 - 276926 != -246911)
							{
								break;
							}
						}
					}
					else if (nStatus == "paralysis")
					{
						if (155275 - 288854 == -133579)
						{
							v = 306;
							if (124507 - 548606 != -424098)
							{
								break;
							}
						}
					}
					else if (nStatus == "death")
					{
						if (66857 - 399854 != -332996)
						{
							v = 307;
							if (112139 - 31370 == 80769)
							{
								break;
							}
						}
					}
					else if (nStatus == "drunk")
					{
						if (208111 - 242015 != -33903)
						{
							v = 308;
							if (58814 - 130715 != -71900)
							{
								break;
							}
						}
					}
					else if (nStatus == "shield")
					{
						if (297693 - 184510 != 113184)
						{
							v = 401;
							if (31531 - 386618 != -355086)
							{
								break;
							}
						}
					}
					else if (nStatus == "honor")
					{
						if (51736 - 278928 != -227191)
						{
							v = 402;
							if (115650 - 298889 != -183238)
							{
								break;
							}
						}
					}
					else if (nStatus == "swallow")
					{
						if (40301 - 456303 != -416001)
						{
							v = 403;
							if (193279 - 358257 == -164978)
							{
								break;
							}
						}
					}
					else if (nStatus == "gobble")
					{
						if (115182 - 417699 == -302517)
						{
							v = 404;
							if (233297 - 574607 == -341310)
							{
								break;
							}
						}
					}
					else if (nStatus == "puncture")
					{
						if (56063 - 178485 == -122422)
						{
							v = 405;
							if (214516 - 80636 == 133880)
							{
								break;
							}
						}
					}
					else if (nStatus == "lastHope")
					{
						if (264506 - 132987 != 131520)
						{
							v = 406;
							if (122520 - 136544 != -14023)
							{
								break;
							}
						}
					}
					else if (nStatus == "kingdomKnight")
					{
						if (5161 - 13659 == -8498)
						{
							v = 407;
							if (214912 - 335017 != -120104)
							{
								break;
							}
						}
					}
					else if (nStatus == "bubbleShield")
					{
						if (110109 - 472722 != -362612)
						{
							v = 408;
							if (178403 - 250999 == -72596)
							{
								break;
							}
						}
					}
					else if (nStatus == "heavy")
					{
						if (266513 - 369788 != -103274)
						{
							v = 409;
							if (72270 - 439764 != -367493)
							{
								break;
							}
						}
					}
					else if (nStatus == "overPresence")
					{
						if (205700 - 479949 != -274248)
						{
							v = 410;
							if (128788 - 306066 != -177277)
							{
								break;
							}
						}
					}
					else if (nStatus == "rejuvenate")
					{
						if (137860 - 101508 != 36353)
						{
							v = 411;
							if (211221 - 528863 != -317641)
							{
								break;
							}
						}
					}
					else if (nStatus == "hardenSkin")
					{
						if (76344 - 12886 == 63458)
						{
							v = 412;
							if (270492 - 319027 == -48535)
							{
								break;
							}
						}
					}
					else if (nStatus == "salvation")
					{
						if (139089 - 71671 != 67419)
						{
							v = 413;
							if (119154 - 338232 != -219077)
							{
								break;
							}
						}
					}
					else if (nStatus == "noShield")
					{
						if (73258 - 124604 != -51345)
						{
							v = 414;
							if (16709 - 104915 != -88205)
							{
								break;
							}
						}
					}
					else if (nStatus == "wash")
					{
						if (170675 - 328564 != -157888)
						{
							v = 415;
							if (184661 - 94352 == 90309)
							{
								break;
							}
						}
					}
					else if (nStatus == "awareness")
					{
						if (68039 - 132654 != -64614)
						{
							v = 501;
							if (33852 - 216774 != -182921)
							{
								break;
							}
						}
					}
					else if (nStatus == "damagePlus")
					{
						if (106868 - 217851 == -110983)
						{
							v = 502;
							if (210535 - 243040 == -32505)
							{
								break;
							}
						}
					}
					else if (nStatus == "fortune")
					{
						if (123710 - 361835 == -238125)
						{
							v = 503;
							if (286365 - 61896 != 224470)
							{
								break;
							}
						}
					}
					else if (nStatus == "damageRoulette")
					{
						if (22708 - 23639 == -931)
						{
							v = 504;
							if (200064 - 449417 != -249352)
							{
								break;
							}
						}
					}
					else if (nStatus == "disarm")
					{
						if (243471 - 376235 != -132763)
						{
							v = 505;
							if (206818 - 240345 != -33526)
							{
								break;
							}
						}
					}
					else if (nStatus == "bleed")
					{
						if (283049 - 383646 == -100597)
						{
							v = 506;
							if (227832 - 287392 == -59560)
							{
								break;
							}
						}
					}
					else if (nStatus == "cut")
					{
						if (203970 - 132650 != 71321)
						{
							v = 507;
							if (77732 - 368517 == -290785)
							{
								break;
							}
						}
					}
					else if (nStatus == "insight")
					{
						if (193894 - 184828 != 9067)
						{
							v = 508;
							if (40607 - 76360 != -35752)
							{
								break;
							}
						}
					}
					else if (nStatus == "pillage")
					{
						if (280032 - 589068 == -309036)
						{
							v = 509;
							if (251769 - 322143 != -70373)
							{
								break;
							}
						}
					}
					else if (nStatus == "immunity")
					{
						if (60617 - 214562 == -153945)
						{
							v = 601;
							if (94978 - 418551 != -323572)
							{
								break;
							}
						}
					}
					else if (nStatus == "blend")
					{
						if (259982 - 559916 == -299934)
						{
							v = 602;
							if (21083 - 69436 == -48353)
							{
								break;
							}
						}
					}
					else if (nStatus == "invisible")
					{
						if (147589 - 307545 == -159956)
						{
							v = 603;
							if (195439 - 187883 == 7556)
							{
								break;
							}
						}
					}
					else if (nStatus == "needlePrison")
					{
						if (8736 - 346358 != -337621)
						{
							v = 604;
							if (128595 - 486286 == -357691)
							{
								break;
							}
						}
					}
					else if (nStatus == "poison")
					{
						if (66484 - 422754 != -356269)
						{
							v = 605;
							if (42873 - 454744 == -411871)
							{
								break;
							}
						}
					}
					else if (nStatus == "venomShock")
					{
						if (27446 - 368405 != -340958)
						{
							v = 606;
							if (228147 - 325850 != -97702)
							{
								break;
							}
						}
					}
					else if (nStatus == "fatalStrike")
					{
						if (59770 - 328171 != -268400)
						{
							v = 607;
							if (242744 - 571967 != -329222)
							{
								break;
							}
						}
					}
					else if (nStatus == "rust")
					{
						if (98703 - 432758 != -334054)
						{
							v = 608;
							if (48571 - 404736 != -356164)
							{
								break;
							}
						}
					}
					else if (nStatus == "rustyDecay")
					{
						if (80451 - 584972 != -504520)
						{
							v = 609;
							if (273530 - 362561 == -89031)
							{
								break;
							}
						}
					}
					else if (nStatus == "tent")
					{
						if (219274 - 73655 == 145619)
						{
							v = 610;
							if (86180 - 59483 != 26698)
							{
								break;
							}
						}
					}
					else if (nStatus == "slayerMark")
					{
						if (30192 - 12837 != 17356)
						{
							v = 611;
							if (242835 - 473524 != -230688)
							{
								break;
							}
						}
					}
					else if (nStatus == "maim")
					{
						if (260662 - 492141 != -231478)
						{
							v = 701;
							if (137009 - 523358 != -386348)
							{
								break;
							}
						}
					}
					else if (nStatus == "enlarge")
					{
						if (247379 - 579635 == -332256)
						{
							v = 702;
							if (111160 - 174852 != -63691)
							{
								break;
							}
						}
					}
					else if (nStatus == "reduce")
					{
						if (33916 - 357165 == -323249)
						{
							v = 703;
							if (234024 - 195538 != 38487)
							{
								break;
							}
						}
					}
					else if (nStatus == "sticky")
					{
						if (13586 - 201722 == -188136)
						{
							v = 704;
							if (55549 - 535535 != -479985)
							{
								break;
							}
						}
					}
					else if (nStatus == "acid")
					{
						if (64601 - 111648 != -47046)
						{
							v = 705;
							if (236985 - 598869 != -361883)
							{
								break;
							}
						}
					}
					else if (nStatus == "remedy")
					{
						if (206578 - 400963 == -194385)
						{
							v = 706;
							if (161199 - 14527 != 146673)
							{
								break;
							}
						}
					}
					else if (nStatus == "boost")
					{
						if (80271 - 432355 != -352083)
						{
							v = 707;
							if (265203 - 215120 != 50084)
							{
								break;
							}
						}
					}
					else if (nStatus == "heat")
					{
						if (14969 - 363974 != -349004)
						{
							v = 708;
							if (290657 - 460851 == -170194)
							{
								break;
							}
						}
					}
					else if (nStatus == "autoLife")
					{
						if (27613 - 506054 != -478440)
						{
							v = 709;
							if (283966 - 243613 != 40354)
							{
								break;
							}
						}
					}
					else if (nStatus == "rapidTrance")
					{
						if (205014 - 505027 == -300013)
						{
							v = 710;
							if (293478 - 511545 != -218066)
							{
								break;
							}
						}
					}
					else if (nStatus == "petrify")
					{
						if (64583 - 430542 == -365959)
						{
							v = 711;
							if (108043 - 320493 != -212449)
							{
								break;
							}
						}
					}
					else if (nStatus == "miracleDrop")
					{
						if (45139 - 561017 == -515878)
						{
							v = 712;
							if (56210 - 110643 == -54433)
							{
								break;
							}
						}
					}
					else if (nStatus == "synchroMole")
					{
						if (171947 - 14150 != 157798)
						{
							v = 801;
							if (188108 - 541017 == -352909)
							{
								break;
							}
						}
					}
					else if (nStatus == "instantCast")
					{
						if (179681 - 72491 == 107190)
						{
							v = 901;
							if (282815 - 581066 != -298250)
							{
								break;
							}
						}
					}
					else if (nStatus == "burn")
					{
						if (540 - 150610 == -150070)
						{
							v = 902;
							if (265046 - 194060 == 70986)
							{
								break;
							}
						}
					}
					else if (nStatus == "ja")
					{
						if (274399 - 250090 != 24310)
						{
							v = 903;
							if (249676 - 6355 != 243322)
							{
								break;
							}
						}
					}
					else if (nStatus == "runicFlame")
					{
						if (21848 - 419829 == -397981)
						{
							v = 904;
							if (165686 - 432166 != -266479)
							{
								break;
							}
						}
					}
					else if (nStatus == "ignite")
					{
						if (46854 - 445004 != -398149)
						{
							v = 905;
							if (245484 - 100451 != 145034)
							{
								break;
							}
						}
					}
					else if (nStatus == "groundLock")
					{
						if (178422 - 374005 != -195582)
						{
							v = 906;
							if (42851 - 426051 != -383199)
							{
								break;
							}
						}
					}
					else if (nStatus == "buiten")
					{
						if (118197 - 469849 == -351652)
						{
							v = 907;
							if (274173 - 246316 != 27858)
							{
								break;
							}
						}
					}
					else if (nStatus == "runicSand")
					{
						if (201258 - 568833 != -367574)
						{
							v = 908;
							if (49677 - 253142 != -203464)
							{
								break;
							}
						}
					}
					else if (nStatus == "lavu")
					{
						if (92833 - 163665 != -70831)
						{
							v = 909;
							if (282910 - 7946 != 274965)
							{
								break;
							}
						}
					}
					else if (nStatus == "fireKeep")
					{
						if (6736 - 380743 == -374007)
						{
							v = 910;
							if (200544 - 194957 == 5587)
							{
								break;
							}
						}
					}
					else if (nStatus == "phoenixSoul")
					{
						if (198099 - 35032 != 163068)
						{
							v = 911;
							if (274916 - 73327 != 201590)
							{
								break;
							}
						}
					}
					else if (nStatus == "jaSoul")
					{
						if (53686 - 12619 == 41067)
						{
							v = 912;
							if (154559 - 111820 != 42740)
							{
								break;
							}
						}
					}
					else if (nStatus == "gadinaSoul")
					{
						if (187875 - 7027 != 180849)
						{
							v = 913;
							if (95579 - 297764 == -202185)
							{
								break;
							}
						}
					}
					else if (nStatus == "buitenSoul")
					{
						if (118601 - 169595 == -50994)
						{
							v = 914;
							if (137298 - 427746 != -290447)
							{
								break;
							}
						}
					}
					else if (nStatus == "gaosSoul")
					{
						if (57765 - 33919 != 23847)
						{
							v = 915;
							if (276302 - 307355 == -31053)
							{
								break;
							}
						}
					}
					else if (nStatus == "fireAvatar")
					{
						if (132194 - 380841 != -248646)
						{
							v = 916;
							if (13826 - 19073 != -5246)
							{
								break;
							}
						}
					}
					else if (nStatus == "earthForm")
					{
						if (119386 - 30451 != 88936)
						{
							v = 917;
							if (30943 - 292639 != -261695)
							{
								break;
							}
						}
					}
					else if (nStatus == "multiCast")
					{
						if (78374 - 238667 == -160293)
						{
							v = 1001;
							if (24883 - 220418 == -195535)
							{
								break;
							}
						}
					}
					else if (nStatus == "dispell")
					{
						if (1545 - 476341 == -474796)
						{
							v = 1002;
							if (130870 - 531275 == -400405)
							{
								break;
							}
						}
					}
					else if (nStatus == "manaBurn")
					{
						if (291184 - 597832 == -306648)
						{
							v = 1003;
							if (276999 - 462477 != -185477)
							{
								break;
							}
						}
					}
					else if (nStatus == "ice")
					{
						if (180214 - 333607 == -153393)
						{
							v = 1004;
							if (294970 - 75652 == 219318)
							{
								break;
							}
						}
					}
					else if (nStatus == "frost")
					{
						if (144189 - 97550 != 46640)
						{
							v = 1005;
							if (105089 - 281206 != -176116)
							{
								break;
							}
						}
					}
					else if (nStatus == "iceShield")
					{
						if (249347 - 535113 == -285766)
						{
							v = 1006;
							if (82320 - 386081 != -303760)
							{
								break;
							}
						}
					}
					else if (nStatus == "snowMan")
					{
						if (215377 - 19972 == 195405)
						{
							v = 1007;
							if (190400 - 215352 != -24951)
							{
								break;
							}
						}
					}
					else if (nStatus == "focusIntellect")
					{
						if (250106 - 436796 != -186689)
						{
							v = 1008;
							if (218728 - 27521 == 191207)
							{
								break;
							}
						}
					}
					else if (nStatus == "snowBall")
					{
						if (167763 - 63936 != 103828)
						{
							v = 1009;
							if (53560 - 529438 == -475878)
							{
								break;
							}
						}
					}
					else if (nStatus == "cosmicRift")
					{
						if (223379 - 115457 == 107922)
						{
							v = 1010;
							if (220143 - 573164 == -353021)
							{
								break;
							}
						}
					}
					else if (nStatus == "cosmicFriday")
					{
						if (260044 - 447690 == -187646)
						{
							v = 1011;
							if (190418 - 160796 != 29623)
							{
								break;
							}
						}
					}
					else if (nStatus == "bless")
					{
						if (110420 - 41258 == 69162)
						{
							v = 1101;
							if (101127 - 463649 == -362522)
							{
								break;
							}
						}
					}
					else if (nStatus == "sleep")
					{
						if (273261 - 532515 != -259253)
						{
							v = 1102;
							if (88801 - 500096 == -411295)
							{
								break;
							}
						}
					}
					else if (nStatus == "clear")
					{
						if (269505 - 360395 == -90890)
						{
							v = 1103;
							if (227937 - 571938 == -344001)
							{
								break;
							}
						}
					}
					else if (nStatus == "cleanse")
					{
						if (156520 - 172922 != -16401)
						{
							v = 1104;
							if (227407 - 460079 == -232672)
							{
								break;
							}
						}
					}
					else if (nStatus == "revive")
					{
						if (182935 - 116931 == 66004)
						{
							v = 1105;
							if (87624 - 2834 == 84790)
							{
								break;
							}
						}
					}
					else if (nStatus == "lightBind")
					{
						if (94724 - 124357 != -29632)
						{
							v = 1106;
							if (137585 - 306397 == -168812)
							{
								break;
							}
						}
					}
					else if (nStatus == "feather")
					{
						if (251167 - 365828 == -114661)
						{
							v = 1107;
							if (290018 - 308491 == -18473)
							{
								break;
							}
						}
					}
					else if (nStatus == "illuminate")
					{
						if (80990 - 244786 == -163796)
						{
							v = 1108;
							if (124901 - 477466 != -352564)
							{
								break;
							}
						}
					}
					else if (nStatus == "sealOfAttack")
					{
						if (263907 - 83637 != 180271)
						{
							v = 1109;
							if (88611 - 112842 != -24230)
							{
								break;
							}
						}
					}
					else if (nStatus == "sealOfDefense")
					{
						if (82479 - 540301 != -457821)
						{
							v = 1110;
							if (85366 - 1450 == 83916)
							{
								break;
							}
						}
					}
					else if (nStatus == "sealOfEarth")
					{
						if (94372 - 511264 == -416892)
						{
							v = 1111;
							if (292706 - 352922 != -60215)
							{
								break;
							}
						}
					}
					else if (nStatus == "sealOfHeaven")
					{
						if (90566 - 300520 != -209953)
						{
							v = 1112;
							if (99254 - 213558 == -114304)
							{
								break;
							}
						}
					}
					else if (nStatus == "repel")
					{
						if (262029 - 70982 != 191048)
						{
							v = 1113;
							if (86859 - 221986 == -135127)
							{
								break;
							}
						}
					}
					else if (nStatus == "reverse")
					{
						if (57421 - 331569 != -274147)
						{
							v = 1114;
							if (289853 - 132866 != 156988)
							{
								break;
							}
						}
					}
					else if (nStatus == "float")
					{
						if (32555 - 201715 != -169159)
						{
							v = 1115;
							if (99807 - 264047 == -164240)
							{
								break;
							}
						}
					}
					else if (nStatus == "wing")
					{
						if (217584 - 421922 == -204338)
						{
							v = 1116;
							if (73807 - 509417 == -435610)
							{
								break;
							}
						}
					}
					else if (nStatus == "sanctuary")
					{
						if (125982 - 333006 != -207023)
						{
							v = 1117;
							if (214610 - 496943 == -282333)
							{
								break;
							}
						}
					}
					else if (nStatus == "worldEncarta")
					{
						if (109443 - 584698 == -475255)
						{
							v = 1118;
							if (38107 - 218988 != -180880)
							{
								break;
							}
						}
					}
					else if (nStatus == "massCast")
					{
						if (142308 - 292747 != -150438)
						{
							v = 1201;
							if (158951 - 301595 != -142643)
							{
								break;
							}
						}
					}
					else if (nStatus == "phantomBane")
					{
						if (276566 - 266219 == 10347)
						{
							v = 1202;
							if (259429 - 129228 == 130201)
							{
								break;
							}
						}
					}
					else if (nStatus == "dissolute")
					{
						if (287003 - 78008 == 208995)
						{
							v = 1203;
							if (161670 - 136532 != 25139)
							{
								break;
							}
						}
					}
					else if (nStatus == "corruption")
					{
						if (30139 - 140037 != -109897)
						{
							v = 1204;
							if (84825 - 562003 != -477177)
							{
								break;
							}
						}
					}
					else if (nStatus == "curse")
					{
						if (21519 - 169122 != -147602)
						{
							v = 1205;
							if (139239 - 305252 == -166013)
							{
								break;
							}
						}
					}
					else if (nStatus == "nightmare")
					{
						if (284386 - 33724 == 250662)
						{
							v = 1206;
							if (51745 - 429738 != -377992)
							{
								break;
							}
						}
					}
					else if (nStatus == "amplifyDamage")
					{
						if (213379 - 384626 == -171247)
						{
							v = 1207;
							if (81273 - 207127 == -125854)
							{
								break;
							}
						}
					}
					else if (nStatus == "doom")
					{
						if (222222 - 103042 != 119181)
						{
							v = 1208;
							if (71847 - 326143 == -254296)
							{
								break;
							}
						}
					}
					else if (nStatus == "guardianOfTheNight")
					{
						if (100092 - 42832 != 57261)
						{
							v = 1209;
							if (82450 - 207060 == -124610)
							{
								break;
							}
						}
					}
					else if (nStatus == "blind")
					{
						if (155663 - 73420 != 82244)
						{
							v = 1210;
							if (128052 - 154355 == -26303)
							{
								break;
							}
						}
					}
					else if (nStatus == "confuse")
					{
						if (23418 - 199945 == -176527)
						{
							v = 1211;
							if (23409 - 522284 == -498875)
							{
								break;
							}
						}
					}
					else if (nStatus == "charm")
					{
						if (78198 - 372204 == -294006)
						{
							v = 1212;
							if (233943 - 190967 == 42976)
							{
								break;
							}
						}
					}
					else if (nStatus == "mindControl")
					{
						if (201114 - 234312 == -33198)
						{
							v = 1213;
							if (277410 - 427381 == -149971)
							{
								break;
							}
						}
					}
					else if (nStatus == "mimic")
					{
						if (66177 - 74145 != -7967)
						{
							v = 1214;
							if (158467 - 287577 != -129109)
							{
								break;
							}
						}
					}
					else if (nStatus == "allMimic")
					{
						if (272578 - 380196 != -107617)
						{
							v = 1215;
							if (86986 - 261128 != -174141)
							{
								break;
							}
						}
					}
					else if (nStatus == "shame")
					{
						if (103003 - 485551 != -382547)
						{
							v = 1216;
							if (119534 - 70015 == 49519)
							{
								break;
							}
						}
					}
					else if (nStatus == "chiroptophobia")
					{
						if (173488 - 575088 == -401600)
						{
							v = 1217;
							if (195556 - 252537 != -56980)
							{
								break;
							}
						}
					}
					else if (nStatus == "darkStalker")
					{
						if (253836 - 304480 != -50643)
						{
							v = 1218;
							if (55421 - 106464 != -51042)
							{
								break;
							}
						}
					}
					else if (nStatus == "blackServant")
					{
						if (121269 - 71578 == 49691)
						{
							v = 1219;
							if (172959 - 101745 != 71215)
							{
								break;
							}
						}
					}
					else if (nStatus == "yellowFlag")
					{
						if (243597 - 525042 != -281444)
						{
							v = 1401;
							if (33115 - 87900 == -54785)
							{
								break;
							}
						}
					}
					else if (nStatus == "blueFlag")
					{
						if (155273 - 319832 == -164559)
						{
							v = 1402;
							if (44530 - 378995 == -334465)
							{
								break;
							}
						}
					}
					else if (nStatus == "redFlag")
					{
						if (102919 - 332963 == -230044)
						{
							v = 1403;
							if (269571 - 97772 == 171799)
							{
								break;
							}
						}
					}
					else if (nStatus == "whiteFlag")
					{
						if (48754 - 322028 != -273273)
						{
							v = 1404;
							if (67603 - 463611 != -396007)
							{
								break;
							}
						}
					}
					else if (nStatus == "seaAegis")
					{
						if (168647 - 128790 != 39858)
						{
							v = 1501;
							if (112586 - 382237 == -269651)
							{
								break;
							}
						}
					}
					else if (nStatus == "zephyrLore")
					{
						if (291730 - 37181 != 254550)
						{
							v = 1502;
							if (102409 - 85444 != 16966)
							{
								break;
							}
						}
					}
					else if (nStatus == "elementalBound")
					{
						if (262893 - 394197 == -131304)
						{
							v = 1503;
							if (19885 - 224666 != -204780)
							{
								break;
							}
						}
					}
					else if (nStatus == "bloodCarnage")
					{
						if (34651 - 482696 != -448044)
						{
							v = 1504;
							if (193263 - 122690 != 70574)
							{
								break;
							}
						}
					}
					else if (nStatus == "flameOfReggu")
					{
						if (104099 - 384808 != -280708)
						{
							v = 2001;
							if (119330 - 362099 != -242768)
							{
								break;
							}
						}
					}
					else if (nStatus == "plague")
					{
						if (20393 - 500839 != -480445)
						{
							v = 2002;
							if (234304 - 559352 == -325048)
							{
								break;
							}
						}
					}
					else if (nStatus == "livingDead")
					{
						if (128235 - 108682 == 19553)
						{
							v = 2003;
							if (253211 - 524031 == -270820)
							{
								break;
							}
						}
					}
					else if (nStatus == "darkRitual")
					{
						if (299900 - 415571 != -115670)
						{
							v = 2004;
							if (134753 - 516410 == -381657)
							{
								break;
							}
						}
					}
					else if (nStatus == "nemesisLarva")
					{
						if (174024 - 31181 != 142844)
						{
							v = 3001;
							if (23480 - 301310 != -277829)
							{
								break;
							}
						}
					}
					else if (nStatus == "netherBane")
					{
						if (259887 - 306772 == -46885)
						{
							v = 4001;
							if (160236 - 295319 != -135082)
							{
								break;
							}
						}
					}
					else if (nStatus == "loveBind")
					{
						if (94695 - 136777 == -42082)
						{
							v = 4002;
							if (149705 - 217227 != -67521)
							{
								break;
							}
						}
					}
					else if (nStatus == "coma")
					{
						if (65428 - 424748 == -359320)
						{
							v = 5501;
							if (18298 - 337640 == -319342)
							{
								break;
							}
						}
					}
					else if (nStatus == "inferno")
					{
						if (181873 - 299827 == -117954)
						{
							v = 5502;
							if (84501 - 160551 == -76050)
							{
								break;
							}
						}
					}
					else if (nStatus == "spiritOfWind")
					{
						if (88664 - 520975 != -432310)
						{
							v = 5503;
							if (129879 - 255999 == -126120)
							{
								break;
							}
						}
					}
					else if (nStatus == "wet")
					{
						if (261782 - 49300 == 212482)
						{
							v = 9001;
							if (141529 - 441820 == -300291)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("unknown status name : " + nStatus);
						if (154958 - 504965 == -350007)
						{
							break;
						}
					}
				}
			}
		}
		return PhotonClient.cInt16(v);
	}

	// Token: 0x06005DDA RID: 24026 RVA: 0x00C75DB4 File Offset: 0x00C73FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getStatusName(int nCode)
	{
		if (80710 - 178830 != -98119)
		{
		}
		string result;
		for (;;)
		{
			result = "none";
			if (155719 - 145217 != 10503 && 89395 - 457612 != -368216)
			{
				if (nCode == 1)
				{
					if (143476 - 263789 != -120312)
					{
						result = "hide";
						if (200669 - 391996 != -191326)
						{
							break;
						}
					}
				}
				else if (nCode == 2)
				{
					if (29838 - 197776 == -167938)
					{
						result = "noDamage";
						if (164029 - 76329 == 87700)
						{
							break;
						}
					}
				}
				else if (nCode == 3)
				{
					if (109735 - 41722 != 68014)
					{
						result = "noKo";
						if (44591 - 211732 == -167141)
						{
							break;
						}
					}
				}
				else if (nCode == 4)
				{
					if (195834 - 546552 != -350717)
					{
						result = "noHate";
						if (44416 - 240210 != -195793)
						{
							break;
						}
					}
				}
				else if (nCode == 5)
				{
					if (192347 - 433556 != -241208)
					{
						result = "noForce";
						if (175113 - 91930 != 83184)
						{
							break;
						}
					}
				}
				else if (nCode == 6)
				{
					if (107900 - 435370 != -327469)
					{
						result = "lifeBoost";
						if (3086 - 466629 != -463542)
						{
							break;
						}
					}
				}
				else if (nCode == 7)
				{
					if (267688 - 572005 != -304316)
					{
						result = "magicBoost";
						if (99911 - 511678 == -411767)
						{
							break;
						}
					}
				}
				else if (nCode == 8)
				{
					if (28264 - 218954 != -190689)
					{
						result = "speedBoost";
						if (127222 - 304409 != -177186)
						{
							break;
						}
					}
				}
				else if (nCode == 9)
				{
					if (99052 - 431338 == -332286)
					{
						result = "eraseBoost";
						if (190879 - 461569 != -270689)
						{
							break;
						}
					}
				}
				else if (nCode == 11)
				{
					if (165667 - 142214 != 23454)
					{
						result = "atkUp";
						if (186081 - 540348 == -354267)
						{
							break;
						}
					}
				}
				else if (nCode == 12)
				{
					if (147735 - 413010 == -265275)
					{
						result = "defUp";
						if (209708 - 163196 != 46513)
						{
							break;
						}
					}
				}
				else if (nCode == 13)
				{
					if (297309 - 494726 != -197416)
					{
						result = "agiUp";
						if (99717 - 19446 == 80271)
						{
							break;
						}
					}
				}
				else if (nCode == 14)
				{
					if (207172 - 208685 != -1512)
					{
						result = "vitUp";
						if (49043 - 494719 != -445675)
						{
							break;
						}
					}
				}
				else if (nCode == 15)
				{
					if (197758 - 182069 == 15689)
					{
						result = "magUp";
						if (37198 - 414839 != -377640)
						{
							break;
						}
					}
				}
				else if (nCode == 16)
				{
					if (142523 - 353433 == -210910)
					{
						result = "chaUp";
						if (2378 - 334763 == -332385)
						{
							break;
						}
					}
				}
				else if (nCode == 17)
				{
					if (95916 - 259597 != -163680)
					{
						result = "talUp";
						if (168902 - 23995 != 144908)
						{
							break;
						}
					}
				}
				else if (nCode == 18)
				{
					if (843 - 363761 != -362917)
					{
						result = "lckUp";
						if (67723 - 589646 != -521922)
						{
							break;
						}
					}
				}
				else if (nCode == 21)
				{
					if (249449 - 448239 == -198790)
					{
						result = "atkDown";
						if (285590 - 483050 == -197460)
						{
							break;
						}
					}
				}
				else if (nCode == 22)
				{
					if (51741 - 298487 == -246746)
					{
						result = "defDown";
						if (287 - 48435 != -48147)
						{
							break;
						}
					}
				}
				else if (nCode == 23)
				{
					if (192481 - 195146 == -2665)
					{
						result = "agiDown";
						if (26680 - 419174 != -392493)
						{
							break;
						}
					}
				}
				else if (nCode == 24)
				{
					if (286661 - 452005 == -165344)
					{
						result = "vitDown";
						if (4073 - 16967 == -12894)
						{
							break;
						}
					}
				}
				else if (nCode == 25)
				{
					if (226713 - 30402 != 196312)
					{
						result = "magDown";
						if (268812 - 352239 == -83427)
						{
							break;
						}
					}
				}
				else if (nCode == 26)
				{
					if (295401 - 36574 != 258828)
					{
						result = "chaDown";
						if (739 - 239097 == -238358)
						{
							break;
						}
					}
				}
				else if (nCode == 27)
				{
					if (215678 - 422948 == -207270)
					{
						result = "talDown";
						if (27845 - 568927 == -541082)
						{
							break;
						}
					}
				}
				else if (nCode == 28)
				{
					if (22613 - 43474 == -20861)
					{
						result = "lckDown";
						if (71956 - 187060 != -115103)
						{
							break;
						}
					}
				}
				else if (nCode == 31)
				{
					if (227852 - 468720 != -240867)
					{
						result = "hpSap";
						if (212765 - 36511 != 176255)
						{
							break;
						}
					}
				}
				else if (nCode == 32)
				{
					if (43941 - 551607 != -507665)
					{
						result = "mpSap";
						if (97525 - 329478 != -231952)
						{
							break;
						}
					}
				}
				else if (nCode == 33)
				{
					if (138381 - 532254 == -393873)
					{
						result = "spSap";
						if (120723 - 446689 == -325966)
						{
							break;
						}
					}
				}
				else if (nCode == 34)
				{
					if (135301 - 129532 == 5769)
					{
						result = "koSap";
						if (170949 - 175660 != -4710)
						{
							break;
						}
					}
				}
				else if (nCode == 35)
				{
					if (14918 - 357946 != -343027)
					{
						result = "hpDrain";
						if (209839 - 247309 != -37469)
						{
							break;
						}
					}
				}
				else if (nCode == 36)
				{
					if (148891 - 181847 != -32955)
					{
						result = "mpDrain";
						if (208389 - 376811 != -168421)
						{
							break;
						}
					}
				}
				else if (nCode == 37)
				{
					if (190964 - 322035 != -131070)
					{
						result = "spDrain";
						if (33496 - 64618 != -31121)
						{
							break;
						}
					}
				}
				else if (nCode == 38)
				{
					if (265647 - 197497 == 68150)
					{
						result = "koDrain";
						if (289746 - 246510 == 43236)
						{
							break;
						}
					}
				}
				else if (nCode == 39)
				{
					if (73478 - 469183 != -395704)
					{
						result = "ko";
						if (283743 - 190819 == 92924)
						{
							break;
						}
					}
				}
				else if (nCode == 41)
				{
					if (228110 - 124989 == 103121)
					{
						result = "lock";
						if (288570 - 36417 != 252154)
						{
							break;
						}
					}
				}
				else if (nCode == 42)
				{
					if (43941 - 98477 == -54536)
					{
						result = "reflect";
						if (245474 - 31623 != 213852)
						{
							break;
						}
					}
				}
				else if (nCode == 51)
				{
					if (82986 - 192832 != -109845)
					{
						result = "awake";
						if (123669 - 401675 == -278006)
						{
							break;
						}
					}
				}
				else if (nCode == 56)
				{
					if (203472 - 311936 == -108464)
					{
						result = "happy";
						if (133537 - 504909 != -371371)
						{
							break;
						}
					}
				}
				else if (nCode == 57)
				{
					if (225277 - 110728 == 114549)
					{
						result = "sad";
						if (191862 - 317134 == -125272)
						{
							break;
						}
					}
				}
				else if (nCode == 61)
				{
					if (119929 - 31064 != 88866)
					{
						result = "hpRegen";
						if (10099 - 505159 == -495060)
						{
							break;
						}
					}
				}
				else if (nCode == 62)
				{
					if (109644 - 393501 == -283857)
					{
						result = "mpRegen";
						if (70157 - 539036 != -468878)
						{
							break;
						}
					}
				}
				else if (nCode == 71)
				{
					if (169740 - 212142 != -42401)
					{
						result = "mount";
						if (134227 - 78463 != 55765)
						{
							break;
						}
					}
				}
				else if (nCode == 72)
				{
					if (112178 - 299139 != -186960)
					{
						result = "transform";
						if (123911 - 588700 == -464789)
						{
							break;
						}
					}
				}
				else if (nCode == 101)
				{
					if (115093 - 555136 == -440043)
					{
						result = "valor";
						if (272438 - 131990 != 140449)
						{
							break;
						}
					}
				}
				else if (nCode == 102)
				{
					if (239338 - 593685 != -354346)
					{
						result = "powerBreak";
						if (293133 - 497385 != -204251)
						{
							break;
						}
					}
				}
				else if (nCode == 103)
				{
					if (136980 - 408529 != -271548)
					{
						result = "armorBreak";
						if (103332 - 120853 == -17521)
						{
							break;
						}
					}
				}
				else if (nCode == 104)
				{
					if (157446 - 424415 == -266969)
					{
						result = "artCancel";
						if (186393 - 482241 != -295847)
						{
							break;
						}
					}
				}
				else if (nCode == 105)
				{
					if (112963 - 329924 == -216961)
					{
						result = "provoke";
						if (55003 - 238501 != -183497)
						{
							break;
						}
					}
				}
				else if (nCode == 106)
				{
					if (119582 - 121961 == -2379)
					{
						result = "darkEdge";
						if (254795 - 539509 != -284713)
						{
							break;
						}
					}
				}
				else if (nCode == 107)
				{
					if (86540 - 579207 == -492667)
					{
						result = "lunarEclipse";
						if (292632 - 282282 == 10350)
						{
							break;
						}
					}
				}
				else if (nCode == 108)
				{
					if (172494 - 521346 == -348852)
					{
						result = "holySword";
						if (191215 - 375570 != -184354)
						{
							break;
						}
					}
				}
				else if (nCode == 109)
				{
					if (26812 - 548942 == -522130)
					{
						result = "holyArmor";
						if (147872 - 230809 == -82937)
						{
							break;
						}
					}
				}
				else if (nCode == 110)
				{
					if (238765 - 480626 != -241860)
					{
						result = "holyWolf";
						if (176218 - 387326 != -211107)
						{
							break;
						}
					}
				}
				else if (nCode == 201)
				{
					if (162631 - 529448 == -366817)
					{
						result = "holdCharge";
						if (152234 - 130331 != 21904)
						{
							break;
						}
					}
				}
				else if (nCode == 202)
				{
					if (36938 - 520315 == -483377)
					{
						result = "enrage";
						if (219900 - 333468 != -113567)
						{
							break;
						}
					}
				}
				else if (nCode == 203)
				{
					if (234191 - 180354 != 53838)
					{
						result = "berserkerRush";
						if (138422 - 34698 == 103724)
						{
							break;
						}
					}
				}
				else if (nCode == 204)
				{
					if (20353 - 338177 == -317824)
					{
						result = "furyTrance";
						if (64680 - 497643 == -432963)
						{
							break;
						}
					}
				}
				else if (nCode == 205)
				{
					if (127768 - 504703 != -376934)
					{
						result = "overPower";
						if (93411 - 57289 == 36122)
						{
							break;
						}
					}
				}
				else if (nCode == 206)
				{
					if (146698 - 308300 != -161601)
					{
						result = "fear";
						if (234640 - 454780 != -220139)
						{
							break;
						}
					}
				}
				else if (nCode == 207)
				{
					if (186746 - 357051 != -170304)
					{
						result = "ironShield";
						if (97433 - 53777 != 43657)
						{
							break;
						}
					}
				}
				else if (nCode == 208)
				{
					if (33959 - 250682 != -216722)
					{
						result = "diamondShield";
						if (27640 - 522530 == -494890)
						{
							break;
						}
					}
				}
				else if (nCode == 209)
				{
					if (25362 - 420570 != -395207)
					{
						result = "perfectShield";
						if (17885 - 131278 == -113393)
						{
							break;
						}
					}
				}
				else if (nCode == 210)
				{
					if (174293 - 308345 != -134051)
					{
						result = "titanForm";
						if (67073 - 273591 == -206518)
						{
							break;
						}
					}
				}
				else if (nCode == 211)
				{
					if (71183 - 543382 == -472199)
					{
						result = "afterShock";
						if (95882 - 367507 != -271624)
						{
							break;
						}
					}
				}
				else if (nCode == 212)
				{
					if (99501 - 324277 == -224776)
					{
						result = "perfectArmor";
						if (183791 - 328026 != -144234)
						{
							break;
						}
					}
				}
				else if (nCode == 301)
				{
					if (266828 - 491921 == -225093)
					{
						result = "delayQi";
						if (138345 - 57909 == 80436)
						{
							break;
						}
					}
				}
				else if (nCode == 302)
				{
					if (240827 - 476602 == -235775)
					{
						result = "comboPlus";
						if (294222 - 138424 != 155799)
						{
							break;
						}
					}
				}
				else if (nCode == 303)
				{
					if (161606 - 593356 != -431749)
					{
						result = "ashura";
						if (194525 - 52033 == 142492)
						{
							break;
						}
					}
				}
				else if (nCode == 304)
				{
					if (247260 - 307965 == -60705)
					{
						result = "grab";
						if (264996 - 468368 != -203371)
						{
							break;
						}
					}
				}
				else if (nCode == 305)
				{
					if (18202 - 541713 != -523510)
					{
						result = "drunken";
						if (217508 - 575963 == -358455)
						{
							break;
						}
					}
				}
				else if (nCode == 306)
				{
					if (97413 - 113076 != -15662)
					{
						result = "paralysis";
						if (183649 - 485696 != -302046)
						{
							break;
						}
					}
				}
				else if (nCode == 307)
				{
					if (266301 - 472941 != -206639)
					{
						result = "death";
						if (283616 - 531404 == -247788)
						{
							break;
						}
					}
				}
				else if (nCode == 308)
				{
					if (31705 - 485552 != -453846)
					{
						result = "drunk";
						if (277425 - 311134 == -33709)
						{
							break;
						}
					}
				}
				else if (nCode == 401)
				{
					if (252844 - 522803 != -269958)
					{
						result = "shield";
						if (48670 - 546318 != -497647)
						{
							break;
						}
					}
				}
				else if (nCode == 402)
				{
					if (202354 - 460273 == -257919)
					{
						result = "honor";
						if (147530 - 431933 == -284403)
						{
							break;
						}
					}
				}
				else if (nCode == 403)
				{
					if (277714 - 424044 != -146329)
					{
						result = "swallow";
						if (31192 - 98785 != -67592)
						{
							break;
						}
					}
				}
				else if (nCode == 404)
				{
					if (276788 - 14271 == 262517)
					{
						result = "gobble";
						if (1508 - 240328 != -238819)
						{
							break;
						}
					}
				}
				else if (nCode == 405)
				{
					if (115395 - 110863 == 4532)
					{
						result = "puncture";
						if (265133 - 162484 != 102650)
						{
							break;
						}
					}
				}
				else if (nCode == 406)
				{
					if (214246 - 408408 != -194161)
					{
						result = "lastHope";
						if (167569 - 408226 != -240656)
						{
							break;
						}
					}
				}
				else if (nCode == 407)
				{
					if (165374 - 571813 != -406438)
					{
						result = "kingdomKnight";
						if (204675 - 502977 != -298301)
						{
							break;
						}
					}
				}
				else if (nCode == 408)
				{
					if (221460 - 104153 == 117307)
					{
						result = "bubbleShield";
						if (164132 - 540541 != -376408)
						{
							break;
						}
					}
				}
				else if (nCode == 409)
				{
					if (46310 - 488743 != -442432)
					{
						result = "heavy";
						if (177986 - 349393 != -171406)
						{
							break;
						}
					}
				}
				else if (nCode == 410)
				{
					if (127978 - 572384 != -444405)
					{
						result = "overPresence";
						if (142186 - 448405 == -306219)
						{
							break;
						}
					}
				}
				else if (nCode == 411)
				{
					if (167977 - 220575 == -52598)
					{
						result = "rejuvenate";
						if (64291 - 8519 != 55773)
						{
							break;
						}
					}
				}
				else if (nCode == 412)
				{
					if (284346 - 75491 == 208855)
					{
						result = "hardenSkin";
						if (260649 - 35737 != 224913)
						{
							break;
						}
					}
				}
				else if (nCode == 413)
				{
					if (225601 - 151471 == 74130)
					{
						result = "salvation";
						if (241925 - 50464 == 191461)
						{
							break;
						}
					}
				}
				else if (nCode == 414)
				{
					if (78440 - 1978 != 76463)
					{
						result = "noShield";
						if (284003 - 481291 != -197287)
						{
							break;
						}
					}
				}
				else if (nCode == 415)
				{
					if (232006 - 590137 != -358130)
					{
						result = "wash";
						if (74257 - 109347 == -35090)
						{
							break;
						}
					}
				}
				else if (nCode == 501)
				{
					if (227465 - 45740 == 181725)
					{
						result = "awareness";
						if (10040 - 74614 != -64573)
						{
							break;
						}
					}
				}
				else if (nCode == 502)
				{
					if (278259 - 258902 != 19358)
					{
						result = "damagePlus";
						if (173980 - 556995 == -383015)
						{
							break;
						}
					}
				}
				else if (nCode == 503)
				{
					if (145405 - 215873 != -70467)
					{
						result = "fortune";
						if (10192 - 505997 == -495805)
						{
							break;
						}
					}
				}
				else if (nCode == 504)
				{
					if (119961 - 590103 != -470141)
					{
						result = "damageRoulette";
						if (248639 - 219063 != 29577)
						{
							break;
						}
					}
				}
				else if (nCode == 505)
				{
					if (63047 - 303481 == -240434)
					{
						result = "disarm";
						if (65606 - 249492 != -183885)
						{
							break;
						}
					}
				}
				else if (nCode == 506)
				{
					if (58050 - 506309 != -448258)
					{
						result = "bleed";
						if (60988 - 184722 != -123733)
						{
							break;
						}
					}
				}
				else if (nCode == 507)
				{
					if (113056 - 29425 == 83631)
					{
						result = "cut";
						if (132009 - 516158 == -384149)
						{
							break;
						}
					}
				}
				else if (nCode == 508)
				{
					if (220557 - 531736 == -311179)
					{
						result = "insight";
						if (677 - 53649 == -52972)
						{
							break;
						}
					}
				}
				else if (nCode == 509)
				{
					if (82373 - 542170 != -459796)
					{
						result = "pillage";
						if (123610 - 288249 == -164639)
						{
							break;
						}
					}
				}
				else if (nCode == 601)
				{
					if (237528 - 287166 != -49637)
					{
						result = "immunity";
						if (167339 - 456225 == -288886)
						{
							break;
						}
					}
				}
				else if (nCode == 602)
				{
					if (25673 - 463746 == -438073)
					{
						result = "blend";
						if (294 - 205925 != -205630)
						{
							break;
						}
					}
				}
				else if (nCode == 603)
				{
					if (283993 - 562773 != -278779)
					{
						result = "invisible";
						if (216622 - 567618 != -350995)
						{
							break;
						}
					}
				}
				else if (nCode == 604)
				{
					if (270259 - 339716 == -69457)
					{
						result = "needlePrison";
						if (145784 - 255684 != -109899)
						{
							break;
						}
					}
				}
				else if (nCode == 605)
				{
					if (26344 - 195075 != -168730)
					{
						result = "poison";
						if (271484 - 92705 == 178779)
						{
							break;
						}
					}
				}
				else if (nCode == 606)
				{
					if (222377 - 33271 == 189106)
					{
						result = "venomShock";
						if (137021 - 489775 != -352753)
						{
							break;
						}
					}
				}
				else if (nCode == 607)
				{
					if (154387 - 340474 != -186086)
					{
						result = "fatalStrike";
						if (232412 - 427362 == -194950)
						{
							break;
						}
					}
				}
				else if (nCode == 608)
				{
					if (265544 - 449587 != -184042)
					{
						result = "rust";
						if (202822 - 321915 == -119093)
						{
							break;
						}
					}
				}
				else if (nCode == 609)
				{
					if (6250 - 119915 == -113665)
					{
						result = "rustyDecay";
						if (227578 - 253541 != -25962)
						{
							break;
						}
					}
				}
				else if (nCode == 610)
				{
					if (71940 - 234383 != -162442)
					{
						result = "tent";
						if (152519 - 380217 != -227697)
						{
							break;
						}
					}
				}
				else if (nCode == 611)
				{
					if (190196 - 45993 == 144203)
					{
						result = "slayerMark";
						if (207587 - 273043 != -65455)
						{
							break;
						}
					}
				}
				else if (nCode == 701)
				{
					if (232261 - 204511 == 27750)
					{
						result = "maim";
						if (37229 - 171428 == -134199)
						{
							break;
						}
					}
				}
				else if (nCode == 702)
				{
					if (237038 - 570358 != -333319)
					{
						result = "enlarge";
						if (175059 - 263867 == -88808)
						{
							break;
						}
					}
				}
				else if (nCode == 703)
				{
					if (113878 - 542047 != -428168)
					{
						result = "reduce";
						if (15149 - 10161 != 4989)
						{
							break;
						}
					}
				}
				else if (nCode == 704)
				{
					if (80830 - 81495 == -665)
					{
						result = "sticky";
						if (252234 - 223011 == 29223)
						{
							break;
						}
					}
				}
				else if (nCode == 705)
				{
					if (63940 - 31656 != 32285)
					{
						result = "acid";
						if (88980 - 6104 != 82877)
						{
							break;
						}
					}
				}
				else if (nCode == 706)
				{
					if (10532 - 117207 != -106674)
					{
						result = "remedy";
						if (3063 - 553892 == -550829)
						{
							break;
						}
					}
				}
				else if (nCode == 707)
				{
					if (197309 - 150871 == 46438)
					{
						result = "boost";
						if (180077 - 468379 != -288301)
						{
							break;
						}
					}
				}
				else if (nCode == 708)
				{
					if (233584 - 29517 != 204068)
					{
						result = "heat";
						if (240587 - 345733 != -105145)
						{
							break;
						}
					}
				}
				else if (nCode == 709)
				{
					if (4366 - 389508 != -385141)
					{
						result = "autoLife";
						if (292213 - 124272 != 167942)
						{
							break;
						}
					}
				}
				else if (nCode == 710)
				{
					if (205004 - 303193 != -98188)
					{
						result = "rapidTrance";
						if (50800 - 587988 == -537188)
						{
							break;
						}
					}
				}
				else if (nCode == 711)
				{
					if (29932 - 597605 == -567673)
					{
						result = "petrify";
						if (187975 - 561819 == -373844)
						{
							break;
						}
					}
				}
				else if (nCode == 712)
				{
					if (95791 - 487349 == -391558)
					{
						result = "miracleDrop";
						if (181749 - 88967 == 92782)
						{
							break;
						}
					}
				}
				else if (nCode == 801)
				{
					if (11247 - 108856 == -97609)
					{
						result = "synchroMole";
						if (238055 - 26426 == 211629)
						{
							break;
						}
					}
				}
				else if (nCode == 901)
				{
					if (133981 - 356398 == -222417)
					{
						result = "instantCast";
						if (138402 - 379124 == -240722)
						{
							break;
						}
					}
				}
				else if (nCode == 902)
				{
					if (91247 - 544957 == -453710)
					{
						result = "burn";
						if (116573 - 463628 != -347054)
						{
							break;
						}
					}
				}
				else if (nCode == 903)
				{
					if (101167 - 589902 != -488734)
					{
						result = "ja";
						if (163229 - 296517 == -133288)
						{
							break;
						}
					}
				}
				else if (nCode == 904)
				{
					if (48780 - 567703 != -518922)
					{
						result = "runicFlame";
						if (193255 - 330811 == -137556)
						{
							break;
						}
					}
				}
				else if (nCode == 905)
				{
					if (254613 - 129811 == 124802)
					{
						result = "ignite";
						if (267555 - 55768 == 211787)
						{
							break;
						}
					}
				}
				else if (nCode == 906)
				{
					if (187402 - 583469 != -396066)
					{
						result = "groundLock";
						if (143576 - 421137 == -277561)
						{
							break;
						}
					}
				}
				else if (nCode == 907)
				{
					if (274191 - 423446 == -149255)
					{
						result = "buiten";
						if (55326 - 55453 != -126)
						{
							break;
						}
					}
				}
				else if (nCode == 908)
				{
					if (193897 - 138648 == 55249)
					{
						result = "runicSand";
						if (91237 - 161534 != -70296)
						{
							break;
						}
					}
				}
				else if (nCode == 909)
				{
					if (63301 - 380071 != -316769)
					{
						result = "lavu";
						if (136030 - 227078 == -91048)
						{
							break;
						}
					}
				}
				else if (nCode == 910)
				{
					if (246039 - 15783 == 230256)
					{
						result = "fireKeep";
						if (21811 - 231299 != -209487)
						{
							break;
						}
					}
				}
				else if (nCode == 911)
				{
					if (249714 - 78932 == 170782)
					{
						result = "phoenixSoul";
						if (24304 - 276809 == -252505)
						{
							break;
						}
					}
				}
				else if (nCode == 912)
				{
					if (129031 - 341683 != -212651)
					{
						result = "jaSoul";
						if (220876 - 19687 != 201190)
						{
							break;
						}
					}
				}
				else if (nCode == 913)
				{
					if (185043 - 590261 == -405218)
					{
						result = "gadinaSoul";
						if (168961 - 130400 == 38561)
						{
							break;
						}
					}
				}
				else if (nCode == 914)
				{
					if (281150 - 34966 != 246185)
					{
						result = "buitenSoul";
						if (293900 - 168203 != 125698)
						{
							break;
						}
					}
				}
				else if (nCode == 915)
				{
					if (95649 - 577880 != -482230)
					{
						result = "gaosSoul";
						if (191047 - 11162 == 179885)
						{
							break;
						}
					}
				}
				else if (nCode == 916)
				{
					if (13885 - 374351 == -360466)
					{
						result = "fireAvatar";
						if (86707 - 322322 == -235615)
						{
							break;
						}
					}
				}
				else if (nCode == 917)
				{
					if (200595 - 36808 == 163787)
					{
						result = "earthForm";
						if (175417 - 214610 == -39193)
						{
							break;
						}
					}
				}
				else if (nCode == 1001)
				{
					if (228922 - 499751 == -270829)
					{
						result = "multiCast";
						if (159625 - 332741 != -173115)
						{
							break;
						}
					}
				}
				else if (nCode == 1002)
				{
					if (57636 - 28853 == 28783)
					{
						result = "dispell";
						if (148080 - 132497 != 15584)
						{
							break;
						}
					}
				}
				else if (nCode == 1003)
				{
					if (158349 - 66794 != 91556)
					{
						result = "manaBurn";
						if (197532 - 488932 != -291399)
						{
							break;
						}
					}
				}
				else if (nCode == 1004)
				{
					if (159810 - 218340 != -58529)
					{
						result = "ice";
						if (7659 - 276959 != -269299)
						{
							break;
						}
					}
				}
				else if (nCode == 1005)
				{
					if (105245 - 54370 != 50876)
					{
						result = "frost";
						if (86282 - 245871 != -159588)
						{
							break;
						}
					}
				}
				else if (nCode == 1006)
				{
					if (106876 - 48078 == 58798)
					{
						result = "iceShield";
						if (234153 - 1882 != 232272)
						{
							break;
						}
					}
				}
				else if (nCode == 1007)
				{
					if (295412 - 166860 != 128553)
					{
						result = "snowMan";
						if (132176 - 82019 != 50158)
						{
							break;
						}
					}
				}
				else if (nCode == 1008)
				{
					if (65135 - 49463 == 15672)
					{
						result = "focusIntellect";
						if (75387 - 524214 == -448827)
						{
							break;
						}
					}
				}
				else if (nCode == 1009)
				{
					if (156996 - 232637 != -75640)
					{
						result = "snowBall";
						if (103127 - 73730 == 29397)
						{
							break;
						}
					}
				}
				else if (nCode == 1010)
				{
					if (61290 - 247492 != -186201)
					{
						result = "cosmicRift";
						if (201336 - 580654 == -379318)
						{
							break;
						}
					}
				}
				else if (nCode == 1011)
				{
					if (116016 - 442004 != -325987)
					{
						result = "cosmicFriday";
						if (26389 - 280949 == -254560)
						{
							break;
						}
					}
				}
				else if (nCode == 1101)
				{
					if (210192 - 305101 != -94908)
					{
						result = "bless";
						if (280688 - 423853 != -143164)
						{
							break;
						}
					}
				}
				else if (nCode == 1102)
				{
					if (88418 - 336248 != -247829)
					{
						result = "sleep";
						if (43572 - 579397 == -535825)
						{
							break;
						}
					}
				}
				else if (nCode == 1103)
				{
					if (216515 - 547223 == -330708)
					{
						result = "clear";
						if (86502 - 535611 == -449109)
						{
							break;
						}
					}
				}
				else if (nCode == 1104)
				{
					if (145968 - 420424 == -274456)
					{
						result = "cleanse";
						if (291706 - 596272 != -304565)
						{
							break;
						}
					}
				}
				else if (nCode == 1105)
				{
					if (74117 - 384699 != -310581)
					{
						result = "revive";
						if (170226 - 205412 != -35185)
						{
							break;
						}
					}
				}
				else if (nCode == 1106)
				{
					if (27696 - 345778 == -318082)
					{
						result = "lightBind";
						if (41028 - 93430 == -52402)
						{
							break;
						}
					}
				}
				else if (nCode == 1107)
				{
					if (289993 - 457623 == -167630)
					{
						result = "feather";
						if (38054 - 282562 != -244507)
						{
							break;
						}
					}
				}
				else if (nCode == 1108)
				{
					if (114146 - 320456 == -206310)
					{
						result = "illuminate";
						if (26026 - 176763 == -150737)
						{
							break;
						}
					}
				}
				else if (nCode == 1109)
				{
					if (41543 - 357751 != -316207)
					{
						result = "sealOfAttack";
						if (288916 - 185377 == 103539)
						{
							break;
						}
					}
				}
				else if (nCode == 1110)
				{
					if (116481 - 458999 == -342518)
					{
						result = "sealOfDefense";
						if (232006 - 322499 != -90492)
						{
							break;
						}
					}
				}
				else if (nCode == 1111)
				{
					if (289092 - 542236 == -253144)
					{
						result = "sealOfEarth";
						if (240652 - 414985 == -174333)
						{
							break;
						}
					}
				}
				else if (nCode == 1112)
				{
					if (265887 - 573458 == -307571)
					{
						result = "sealOfHeaven";
						if (139237 - 324676 != -185438)
						{
							break;
						}
					}
				}
				else if (nCode == 1113)
				{
					if (262098 - 108981 != 153118)
					{
						result = "repel";
						if (25520 - 321188 == -295668)
						{
							break;
						}
					}
				}
				else if (nCode == 1114)
				{
					if (85117 - 250359 != -165241)
					{
						result = "reverse";
						if (280351 - 428692 == -148341)
						{
							break;
						}
					}
				}
				else if (nCode == 1115)
				{
					if (83016 - 278122 != -195105)
					{
						result = "float";
						if (268804 - 59434 == 209370)
						{
							break;
						}
					}
				}
				else if (nCode == 1116)
				{
					if (16210 - 532526 != -516315)
					{
						result = "wing";
						if (190623 - 14946 != 175678)
						{
							break;
						}
					}
				}
				else if (nCode == 1117)
				{
					if (141096 - 319306 != -178209)
					{
						result = "sanctuary";
						if (43440 - 251957 == -208517)
						{
							break;
						}
					}
				}
				else if (nCode == 1118)
				{
					if (26917 - 446625 != -419707)
					{
						result = "worldEncarta";
						if (263294 - 127583 == 135711)
						{
							break;
						}
					}
				}
				else if (nCode == 1201)
				{
					if (7691 - 328774 == -321083)
					{
						result = "massCast";
						if (103491 - 518400 == -414909)
						{
							break;
						}
					}
				}
				else if (nCode == 1202)
				{
					if (117921 - 444860 != -326938)
					{
						result = "phantomBane";
						if (135391 - 48096 != 87296)
						{
							break;
						}
					}
				}
				else if (nCode == 1203)
				{
					if (222888 - 322425 == -99537)
					{
						result = "dissolute";
						if (200990 - 301921 == -100931)
						{
							break;
						}
					}
				}
				else if (nCode == 1204)
				{
					if (194102 - 53038 == 141064)
					{
						result = "corruption";
						if (175957 - 77459 != 98499)
						{
							break;
						}
					}
				}
				else if (nCode == 1205)
				{
					if (45380 - 312799 != -267418)
					{
						result = "curse";
						if (22917 - 585094 == -562177)
						{
							break;
						}
					}
				}
				else if (nCode == 1206)
				{
					if (239133 - 406335 == -167202)
					{
						result = "nightmare";
						if (124775 - 512216 != -387440)
						{
							break;
						}
					}
				}
				else if (nCode == 1207)
				{
					if (106283 - 593894 == -487611)
					{
						result = "amplifyDamage";
						if (44709 - 556490 != -511780)
						{
							break;
						}
					}
				}
				else if (nCode == 1208)
				{
					if (266169 - 569785 != -303615)
					{
						result = "doom";
						if (205369 - 154272 != 51098)
						{
							break;
						}
					}
				}
				else if (nCode == 1209)
				{
					if (16118 - 220990 != -204871)
					{
						result = "guardianOfTheNight";
						if (141783 - 292275 == -150492)
						{
							break;
						}
					}
				}
				else if (nCode == 1210)
				{
					if (17065 - 372037 != -354971)
					{
						result = "blind";
						if (222055 - 118676 != 103380)
						{
							break;
						}
					}
				}
				else if (nCode == 1211)
				{
					if (104875 - 9324 != 95552)
					{
						result = "confuse";
						if (59305 - 358282 != -298976)
						{
							break;
						}
					}
				}
				else if (nCode == 1212)
				{
					if (131019 - 304669 != -173649)
					{
						result = "charm";
						if (197618 - 400065 == -202447)
						{
							break;
						}
					}
				}
				else if (nCode == 1213)
				{
					if (242178 - 274635 == -32457)
					{
						result = "mindControl";
						if (152288 - 24550 != 127739)
						{
							break;
						}
					}
				}
				else if (nCode == 1214)
				{
					if (270849 - 584156 != -313306)
					{
						result = "mimic";
						if (104691 - 150000 != -45308)
						{
							break;
						}
					}
				}
				else if (nCode == 1215)
				{
					if (35380 - 577707 != -542326)
					{
						result = "allMimic";
						if (72261 - 399280 == -327019)
						{
							break;
						}
					}
				}
				else if (nCode == 1216)
				{
					if (195335 - 506146 == -310811)
					{
						result = "shame";
						if (12691 - 487582 == -474891)
						{
							break;
						}
					}
				}
				else if (nCode == 1217)
				{
					if (209576 - 61743 == 147833)
					{
						result = "chiroptophobia";
						if (283488 - 574441 == -290953)
						{
							break;
						}
					}
				}
				else if (nCode == 1218)
				{
					if (292622 - 152246 != 140377)
					{
						result = "darkStalker";
						if (117811 - 146606 != -28794)
						{
							break;
						}
					}
				}
				else if (nCode == 1219)
				{
					if (13398 - 104208 == -90810)
					{
						result = "blackServant";
						if (26284 - 237775 != -211490)
						{
							break;
						}
					}
				}
				else if (nCode == 1401)
				{
					if (200922 - 495837 == -294915)
					{
						result = "yellowFlag";
						if (56144 - 87984 != -31839)
						{
							break;
						}
					}
				}
				else if (nCode == 1402)
				{
					if (25015 - 290765 == -265750)
					{
						result = "blueFlag";
						if (250281 - 11614 != 238668)
						{
							break;
						}
					}
				}
				else if (nCode == 1403)
				{
					if (150877 - 455160 != -304282)
					{
						result = "redFlag";
						if (111985 - 80825 != 31161)
						{
							break;
						}
					}
				}
				else if (nCode == 1404)
				{
					if (196612 - 313291 != -116678)
					{
						result = "whiteFlag";
						if (40152 - 413311 != -373158)
						{
							break;
						}
					}
				}
				else if (nCode == 1501)
				{
					if (133159 - 168864 != -35704)
					{
						result = "seaAegis";
						if (244088 - 397691 != -153602)
						{
							break;
						}
					}
				}
				else if (nCode == 1502)
				{
					if (67489 - 390427 == -322938)
					{
						result = "zephyrLore";
						if (9747 - 327202 != -317454)
						{
							break;
						}
					}
				}
				else if (nCode == 1503)
				{
					if (268342 - 239182 == 29160)
					{
						result = "elementalBound";
						if (103584 - 222294 != -118709)
						{
							break;
						}
					}
				}
				else if (nCode == 1504)
				{
					if (191785 - 509457 != -317671)
					{
						result = "bloodCarnage";
						if (90198 - 411331 != -321132)
						{
							break;
						}
					}
				}
				else if (nCode == 2001)
				{
					if (90722 - 451607 == -360885)
					{
						result = "flameOfReggu";
						if (208597 - 400570 != -191972)
						{
							break;
						}
					}
				}
				else if (nCode == 2002)
				{
					if (201276 - 73086 != 128191)
					{
						result = "plague";
						if (23785 - 418824 == -395039)
						{
							break;
						}
					}
				}
				else if (nCode == 2003)
				{
					if (254485 - 342936 == -88451)
					{
						result = "livingDead";
						if (136563 - 535193 == -398630)
						{
							break;
						}
					}
				}
				else if (nCode == 2004)
				{
					if (135762 - 156291 == -20529)
					{
						result = "darkRitual";
						if (158786 - 138025 != 20762)
						{
							break;
						}
					}
				}
				else if (nCode == 3001)
				{
					if (104331 - 88995 != 15337)
					{
						result = "nemesisLarva";
						if (89299 - 94898 != -5598)
						{
							break;
						}
					}
				}
				else if (nCode == 4001)
				{
					if (148159 - 406344 == -258185)
					{
						result = "netherBane";
						if (49282 - 87424 != -38141)
						{
							break;
						}
					}
				}
				else if (nCode == 4002)
				{
					if (72077 - 282147 != -210069)
					{
						result = "loveBind";
						if (288989 - 466502 != -177512)
						{
							break;
						}
					}
				}
				else if (nCode == 5501)
				{
					if (52524 - 31523 == 21001)
					{
						result = "coma";
						if (17091 - 421029 == -403938)
						{
							break;
						}
					}
				}
				else if (nCode == 5502)
				{
					if (288568 - 199692 != 88877)
					{
						result = "inferno";
						if (273430 - 549679 == -276249)
						{
							break;
						}
					}
				}
				else if (nCode == 5503)
				{
					if (205688 - 511843 != -306154)
					{
						result = "spiritOfWind";
						if (93145 - 473558 != -380412)
						{
							break;
						}
					}
				}
				else if (nCode == 9001)
				{
					if (125308 - 462001 != -336692)
					{
						result = "wet";
						if (89234 - 204695 != -115460)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("unknown status code : " + nCode);
					if (28141 - 284428 != -256286)
					{
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005DDB RID: 24027 RVA: 0x00C798F4 File Offset: 0x00C77AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isSystemStatus(string nStatus)
	{
		if (272728 - 333567 != -60839)
		{
		}
		for (;;)
		{
			if (82531 - 295238 != -212706)
			{
				if (nStatus == "hide")
				{
					break;
				}
				if (256682 - 578264 != -321581)
				{
					if (nStatus == "noDamage")
					{
						break;
					}
					if (234347 - 200436 != 33912)
					{
						if (nStatus == "noKo")
						{
							break;
						}
						if (32312 - 43877 != -11564)
						{
							if (nStatus == "noHate")
							{
								break;
							}
							if (102649 - 514966 != -412316)
							{
								if (nStatus == "noForce")
								{
									break;
								}
								if (70035 - 404742 != -334706)
								{
									if (nStatus == "hpSap")
									{
										break;
									}
									if (113525 - 164237 == -50712)
									{
										if (nStatus == "mpSap")
										{
											break;
										}
										if (153936 - 532749 != -378812)
										{
											if (nStatus == "spSap")
											{
												break;
											}
											if (282970 - 344968 != -61997)
											{
												if (nStatus == "koSap")
												{
													break;
												}
												if (58760 - 294620 != -235859)
												{
													if (nStatus == "hpDrain")
													{
														break;
													}
													if (45013 - 127435 == -82422)
													{
														if (nStatus == "mpDrain")
														{
															break;
														}
														if (292944 - 349183 == -56239)
														{
															if (nStatus == "spDrain")
															{
																break;
															}
															if (39296 - 29348 != 9949)
															{
																if (nStatus == "koDrain")
																{
																	break;
																}
																if (193530 - 464614 != -271083)
																{
																	if (nStatus == "hpRegen")
																	{
																		break;
																	}
																	if (83060 - 470965 == -387905)
																	{
																		if (nStatus == "mpRegen")
																		{
																			break;
																		}
																		if (215904 - 583135 == -367231)
																		{
																			if (nStatus == "ko")
																			{
																				break;
																			}
																			if (206954 - 528489 == -321535)
																			{
																				if (nStatus == "lock")
																				{
																					break;
																				}
																				if (228167 - 443465 != -215297)
																				{
																					if (nStatus == "reflect")
																					{
																						break;
																					}
																					if (264439 - 444846 == -180407)
																					{
																						if (nStatus == "awake")
																						{
																							break;
																						}
																						if (259339 - 4288 == 255051)
																						{
																							if (nStatus == "happy")
																							{
																								break;
																							}
																							if (56508 - 301359 == -244851)
																							{
																								if (nStatus == "sad")
																								{
																									break;
																								}
																								if (86076 - 436688 != -350611)
																								{
																									if (nStatus == "mount")
																									{
																										break;
																									}
																									if (288950 - 77413 == 211537)
																									{
																										if (nStatus == "transform")
																										{
																											break;
																										}
																										if (274451 - 329771 != -55319)
																										{
																											if (nStatus == "death")
																											{
																												break;
																											}
																											if (143656 - 17659 == 125997)
																											{
																												if (!(nStatus == "nemesisLarva"))
																												{
																													goto IL_456;
																												}
																												if (263591 - 98200 != 165392)
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
		return true;
		IL_456:
		return false;
	}

	// Token: 0x06005DDC RID: 24028 RVA: 0x00C79D6C File Offset: 0x00C77F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isStateStatus(string nStatus)
	{
		if (86297 - 269632 != -183334)
		{
		}
		for (;;)
		{
			if (134998 - 88793 != 46206)
			{
				if (nStatus == "artCancel")
				{
					break;
				}
				if (142905 - 367389 != -224483)
				{
					if (nStatus == "lunarEclipse")
					{
						break;
					}
					if (278549 - 17706 == 260843)
					{
						if (nStatus == "holyWolf")
						{
							break;
						}
						if (166386 - 566167 == -399781)
						{
							if (nStatus == "holdCharge")
							{
								break;
							}
							if (190431 - 565298 == -374867)
							{
								if (nStatus == "overPower")
								{
									break;
								}
								if (261846 - 295637 == -33791)
								{
									if (nStatus == "titanForm")
									{
										break;
									}
									if (67264 - 256335 != -189070)
									{
										if (nStatus == "puncture")
										{
											break;
										}
										if (209707 - 436380 != -226672)
										{
											if (nStatus == "lastHope")
											{
												break;
											}
											if (182739 - 420225 != -237485)
											{
												if (nStatus == "kingdomKnight")
												{
													break;
												}
												if (50901 - 486686 == -435785)
												{
													if (nStatus == "overPresence")
													{
														break;
													}
													if (92495 - 57105 != 35391)
													{
														if (nStatus == "noShield")
														{
															break;
														}
														if (256879 - 587663 == -330784)
														{
															if (nStatus == "comboPlus")
															{
																break;
															}
															if (187733 - 506651 != -318917)
															{
																if (nStatus == "delayQi")
																{
																	break;
																}
																if (185830 - 390903 == -205073)
																{
																	if (nStatus == "grab")
																	{
																		break;
																	}
																	if (193183 - 384114 != -190930)
																	{
																		if (nStatus == "ashura")
																		{
																			break;
																		}
																		if (11533 - 225509 != -213975)
																		{
																			if (nStatus == "insight")
																			{
																				break;
																			}
																			if (54093 - 361965 == -307872)
																			{
																				if (nStatus == "cut")
																				{
																					break;
																				}
																				if (94381 - 134378 != -39996)
																				{
																					if (nStatus == "tent")
																					{
																						break;
																					}
																					if (234451 - 505007 != -270555)
																					{
																						if (nStatus == "rapidTrance")
																						{
																							break;
																						}
																						if (186240 - 496607 != -310366)
																						{
																							if (nStatus == "petrify")
																							{
																								break;
																							}
																							if (206077 - 203213 == 2864)
																							{
																								if (nStatus == "synchroMole")
																								{
																									break;
																								}
																								if (267967 - 356327 == -88360)
																								{
																									if (nStatus == "instantCast")
																									{
																										break;
																									}
																									if (694 - 429777 != -429082)
																									{
																										if (nStatus == "ja")
																										{
																											break;
																										}
																										if (42561 - 362026 != -319464)
																										{
																											if (nStatus == "buiten")
																											{
																												break;
																											}
																											if (154210 - 94366 == 59844)
																											{
																												if (nStatus == "fireKeep")
																												{
																													break;
																												}
																												if (247779 - 554253 != -306473)
																												{
																													if (nStatus == "lavu")
																													{
																														break;
																													}
																													if (94665 - 4820 == 89845)
																													{
																														if (nStatus == "phoenixSoul")
																														{
																															break;
																														}
																														if (121529 - 278979 != -157449)
																														{
																															if (nStatus == "jaSoul")
																															{
																																break;
																															}
																															if (261097 - 64091 != 197007)
																															{
																																if (nStatus == "gadinaSoul")
																																{
																																	break;
																																}
																																if (98651 - 542212 != -443560)
																																{
																																	if (nStatus == "buitenSoul")
																																	{
																																		break;
																																	}
																																	if (102549 - 276666 != -174116)
																																	{
																																		if (nStatus == "gaosSoul")
																																		{
																																			break;
																																		}
																																		if (98379 - 52890 != 45490)
																																		{
																																			if (nStatus == "fireAvatar")
																																			{
																																				break;
																																			}
																																			if (87337 - 308560 != -221222)
																																			{
																																				if (nStatus == "earthForm")
																																				{
																																					break;
																																				}
																																				if (33834 - 262054 != -228219)
																																				{
																																					if (nStatus == "multiCast")
																																					{
																																						break;
																																					}
																																					if (61724 - 490307 == -428583)
																																					{
																																						if (nStatus == "focusIntellect")
																																						{
																																							break;
																																						}
																																						if (30048 - 268488 == -238440)
																																						{
																																							if (nStatus == "cosmicRift")
																																							{
																																								break;
																																							}
																																							if (263345 - 510738 != -247392)
																																							{
																																								if (nStatus == "cosmicFriday")
																																								{
																																									break;
																																								}
																																								if (225632 - 535487 == -309855)
																																								{
																																									if (nStatus == "revive")
																																									{
																																										break;
																																									}
																																									if (66495 - 395889 != -329393)
																																									{
																																										if (nStatus == "massCast")
																																										{
																																											break;
																																										}
																																										if (233466 - 29084 == 204382)
																																										{
																																											if (nStatus == "guardianOfTheNight")
																																											{
																																												break;
																																											}
																																											if (48011 - 84940 == -36929)
																																											{
																																												if (nStatus == "mimic")
																																												{
																																													break;
																																												}
																																												if (193306 - 184754 != 8553)
																																												{
																																													if (nStatus == "allMimic")
																																													{
																																														break;
																																													}
																																													if (81196 - 161010 == -79814)
																																													{
																																														if (nStatus == "chiroptophobia")
																																														{
																																															break;
																																														}
																																														if (72151 - 122156 == -50005)
																																														{
																																															if (nStatus == "darkStalker")
																																															{
																																																break;
																																															}
																																															if (102480 - 537232 == -434752)
																																															{
																																																if (nStatus == "blackServant")
																																																{
																																																	break;
																																																}
																																																if (290259 - 133477 != 156783)
																																																{
																																																	if (nStatus == "yellowFlag")
																																																	{
																																																		break;
																																																	}
																																																	if (124919 - 67724 != 57196)
																																																	{
																																																		if (nStatus == "blueFlag")
																																																		{
																																																			break;
																																																		}
																																																		if (269867 - 159402 == 110465)
																																																		{
																																																			if (nStatus == "redFlag")
																																																			{
																																																				break;
																																																			}
																																																			if (162857 - 93117 != 69741)
																																																			{
																																																				if (nStatus == "whiteFlag")
																																																				{
																																																					break;
																																																				}
																																																				if (106270 - 51034 != 55237)
																																																				{
																																																					if (nStatus == "seaAegis")
																																																					{
																																																						break;
																																																					}
																																																					if (110727 - 293352 == -182625)
																																																					{
																																																						if (nStatus == "zephyrLore")
																																																						{
																																																							break;
																																																						}
																																																						if (198662 - 39893 != 158770)
																																																						{
																																																							if (nStatus == "elementalBound")
																																																							{
																																																								break;
																																																							}
																																																							if (92592 - 496099 != -403506)
																																																							{
																																																								if (nStatus == "bloodCarnage")
																																																								{
																																																									break;
																																																								}
																																																								if (189845 - 573004 == -383159)
																																																								{
																																																									if (nStatus == "flameOfReggu")
																																																									{
																																																										break;
																																																									}
																																																									if (38055 - 301088 != -263032)
																																																									{
																																																										if (nStatus == "wet")
																																																										{
																																																											break;
																																																										}
																																																										if (262386 - 122848 == 139538)
																																																										{
																																																											if (!(nStatus == "spiritOfWind"))
																																																											{
																																																												goto IL_96C;
																																																											}
																																																											if (265911 - 12396 != 253516)
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
					}
				}
			}
		}
		return true;
		IL_96C:
		return false;
	}

	// Token: 0x06005DDD RID: 24029 RVA: 0x00C7A6F8 File Offset: 0x00C788F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isPhysicalStatus(string nStatus)
	{
		if (137354 - 439097 != -301742)
		{
		}
		for (;;)
		{
			if (84643 - 341352 != -256708)
			{
				if (nStatus == "atkUp")
				{
					break;
				}
				if (216526 - 87478 == 129048)
				{
					if (nStatus == "defUp")
					{
						break;
					}
					if (288324 - 247087 == 41237)
					{
						if (nStatus == "agiUp")
						{
							break;
						}
						if (260528 - 238549 == 21979)
						{
							if (nStatus == "vitUp")
							{
								break;
							}
							if (205552 - 582618 != -377065)
							{
								if (nStatus == "magUp")
								{
									break;
								}
								if (111270 - 481273 == -370003)
								{
									if (nStatus == "chaUp")
									{
										break;
									}
									if (80608 - 303306 == -222698)
									{
										if (nStatus == "talUp")
										{
											break;
										}
										if (268454 - 547236 == -278782)
										{
											if (nStatus == "lckUp")
											{
												break;
											}
											if (171355 - 490950 != -319594)
											{
												if (nStatus == "atkDown")
												{
													break;
												}
												if (208270 - 551137 == -342867)
												{
													if (nStatus == "defDown")
													{
														break;
													}
													if (250153 - 410243 == -160090)
													{
														if (nStatus == "agiDown")
														{
															break;
														}
														if (287284 - 352565 != -65280)
														{
															if (nStatus == "vitDown")
															{
																break;
															}
															if (86755 - 332808 != -246052)
															{
																if (nStatus == "magDown")
																{
																	break;
																}
																if (249007 - 376695 != -127687)
																{
																	if (nStatus == "chaDown")
																	{
																		break;
																	}
																	if (10590 - 133180 == -122590)
																	{
																		if (nStatus == "talDown")
																		{
																			break;
																		}
																		if (230891 - 304545 != -73653)
																		{
																			if (nStatus == "lckDown")
																			{
																				break;
																			}
																			if (243453 - 118761 != 124693)
																			{
																				if (nStatus == "lifeBoost")
																				{
																					break;
																				}
																				if (215078 - 308340 != -93261)
																				{
																					if (nStatus == "magicBoost")
																					{
																						break;
																					}
																					if (44983 - 500242 == -455259)
																					{
																						if (nStatus == "speedBoost")
																						{
																							break;
																						}
																						if (218743 - 319323 != -100579)
																						{
																							if (nStatus == "powerBreak")
																							{
																								break;
																							}
																							if (36600 - 556015 != -519414)
																							{
																								if (nStatus == "armorBreak")
																								{
																									break;
																								}
																								if (135956 - 413625 == -277669)
																								{
																									if (nStatus == "provoke")
																									{
																										break;
																									}
																									if (280371 - 435951 == -155580)
																									{
																										if (nStatus == "berserkerRush")
																										{
																											break;
																										}
																										if (63904 - 508996 == -445092)
																										{
																											if (nStatus == "furyTrance")
																											{
																												break;
																											}
																											if (268154 - 343192 != -75037)
																											{
																												if (nStatus == "afterShock")
																												{
																													break;
																												}
																												if (28392 - 243725 != -215332)
																												{
																													if (nStatus == "drunken")
																													{
																														break;
																													}
																													if (79153 - 320209 == -241056)
																													{
																														if (nStatus == "paralysis")
																														{
																															break;
																														}
																														if (258342 - 463454 != -205111)
																														{
																															if (nStatus == "drunk")
																															{
																																break;
																															}
																															if (35309 - 222632 == -187323)
																															{
																																if (nStatus == "shield")
																																{
																																	break;
																																}
																																if (123924 - 291655 != -167730)
																																{
																																	if (nStatus == "swallow")
																																	{
																																		break;
																																	}
																																	if (64272 - 376287 == -312015)
																																	{
																																		if (nStatus == "gobble")
																																		{
																																			break;
																																		}
																																		if (120907 - 350846 != -229938)
																																		{
																																			if (nStatus == "hardenSkin")
																																			{
																																				break;
																																			}
																																			if (297838 - 595032 != -297193)
																																			{
																																				if (nStatus == "damagePlus")
																																				{
																																					break;
																																				}
																																				if (121121 - 392807 == -271686)
																																				{
																																					if (nStatus == "disarm")
																																					{
																																						break;
																																					}
																																					if (266086 - 223547 != 42540)
																																					{
																																						if (nStatus == "bleed")
																																						{
																																							break;
																																						}
																																						if (245586 - 171211 != 74376)
																																						{
																																							if (nStatus == "pillage")
																																							{
																																								break;
																																							}
																																							if (111551 - 16202 != 95350)
																																							{
																																								if (nStatus == "blend")
																																								{
																																									break;
																																								}
																																								if (496 - 511828 != -511331)
																																								{
																																									if (nStatus == "needlePrison")
																																									{
																																										break;
																																									}
																																									if (227440 - 376791 == -149351)
																																									{
																																										if (nStatus == "poison")
																																										{
																																											break;
																																										}
																																										if (244005 - 436556 != -192550)
																																										{
																																											if (nStatus == "venomShock")
																																											{
																																												break;
																																											}
																																											if (275411 - 313126 != -37714)
																																											{
																																												if (nStatus == "rust")
																																												{
																																													break;
																																												}
																																												if (1226 - 471227 != -470000)
																																												{
																																													if (nStatus == "rustyDecay")
																																													{
																																														break;
																																													}
																																													if (123621 - 129075 == -5454)
																																													{
																																														if (nStatus == "maim")
																																														{
																																															break;
																																														}
																																														if (11269 - 329262 == -317993)
																																														{
																																															if (nStatus == "enlarge")
																																															{
																																																break;
																																															}
																																															if (101539 - 416540 != -315000)
																																															{
																																																if (nStatus == "reduce")
																																																{
																																																	break;
																																																}
																																																if (156139 - 597950 == -441811)
																																																{
																																																	if (nStatus == "acid")
																																																	{
																																																		break;
																																																	}
																																																	if (234967 - 385141 == -150174)
																																																	{
																																																		if (nStatus == "sticky")
																																																		{
																																																			break;
																																																		}
																																																		if (251722 - 50178 != 201545)
																																																		{
																																																			if (nStatus == "amplifyDamage")
																																																			{
																																																				break;
																																																			}
																																																			if (279629 - 199547 != 80083)
																																																			{
																																																				if (!(nStatus == "plague"))
																																																				{
																																																					goto IL_846;
																																																				}
																																																				if (226361 - 520464 != -294102)
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
		return true;
		IL_846:
		return false;
	}

	// Token: 0x06005DDE RID: 24030 RVA: 0x00C7AF60 File Offset: 0x00C79160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isMagicalStatus(string nStatus)
	{
		if (244933 - 194246 != 50687)
		{
		}
		for (;;)
		{
			if (167598 - 180920 != -13321)
			{
				if (nStatus == "valor")
				{
					break;
				}
				if (155197 - 98097 != 57101)
				{
					if (nStatus == "darkEdge")
					{
						break;
					}
					if (276970 - 43869 == 233101)
					{
						if (nStatus == "holySword")
						{
							break;
						}
						if (194025 - 303302 == -109277)
						{
							if (nStatus == "holyArmor")
							{
								break;
							}
							if (6280 - 104850 != -98569)
							{
								if (nStatus == "enrage")
								{
									break;
								}
								if (183342 - 167017 == 16325)
								{
									if (nStatus == "ironShield")
									{
										break;
									}
									if (124501 - 243904 == -119403)
									{
										if (nStatus == "diamondShield")
										{
											break;
										}
										if (284263 - 273553 != 10711)
										{
											if (nStatus == "perfectShield")
											{
												break;
											}
											if (236823 - 402773 == -165950)
											{
												if (nStatus == "perfectArmor")
												{
													break;
												}
												if (50149 - 204750 != -154600)
												{
													if (nStatus == "fear")
													{
														break;
													}
													if (132084 - 2587 != 129498)
													{
														if (nStatus == "honor")
														{
															break;
														}
														if (57628 - 567761 == -510133)
														{
															if (nStatus == "bubbleShield")
															{
																break;
															}
															if (293939 - 380928 != -86988)
															{
																if (nStatus == "heavy")
																{
																	break;
																}
																if (12660 - 188406 == -175746)
																{
																	if (nStatus == "rejuvenate")
																	{
																		break;
																	}
																	if (78828 - 90400 == -11572)
																	{
																		if (nStatus == "salvation")
																		{
																			break;
																		}
																		if (131492 - 39095 != 92398)
																		{
																			if (nStatus == "wash")
																			{
																				break;
																			}
																			if (277550 - 124647 == 152903)
																			{
																				if (nStatus == "awareness")
																				{
																					break;
																				}
																				if (667 - 194233 != -193565)
																				{
																					if (nStatus == "fortune")
																					{
																						break;
																					}
																					if (52516 - 384234 != -331717)
																					{
																						if (nStatus == "damageRoulette")
																						{
																							break;
																						}
																						if (107300 - 573090 != -465789)
																						{
																							if (nStatus == "immunity")
																							{
																								break;
																							}
																							if (118588 - 447327 == -328739)
																							{
																								if (nStatus == "invisible")
																								{
																									break;
																								}
																								if (67283 - 479766 != -412482)
																								{
																									if (nStatus == "fatalStrike")
																									{
																										break;
																									}
																									if (253264 - 420379 == -167115)
																									{
																										if (nStatus == "slayerMark")
																										{
																											break;
																										}
																										if (91099 - 239646 == -148547)
																										{
																											if (nStatus == "boost")
																											{
																												break;
																											}
																											if (56298 - 362635 != -306336)
																											{
																												if (nStatus == "heat")
																												{
																													break;
																												}
																												if (225231 - 386820 != -161588)
																												{
																													if (nStatus == "autoLife")
																													{
																														break;
																													}
																													if (256541 - 336635 == -80094)
																													{
																														if (nStatus == "remedy")
																														{
																															break;
																														}
																														if (291249 - 266496 != 24754)
																														{
																															if (nStatus == "miracleDrop")
																															{
																																break;
																															}
																															if (173875 - 110229 == 63646)
																															{
																																if (nStatus == "burn")
																																{
																																	break;
																																}
																																if (78254 - 101503 == -23249)
																																{
																																	if (nStatus == "groundLock")
																																	{
																																		break;
																																	}
																																	if (220290 - 453485 != -233194)
																																	{
																																		if (nStatus == "runicFlame")
																																		{
																																			break;
																																		}
																																		if (285528 - 344724 == -59196)
																																		{
																																			if (nStatus == "ignite")
																																			{
																																				break;
																																			}
																																			if (50350 - 557585 == -507235)
																																			{
																																				if (nStatus == "runicSand")
																																				{
																																					break;
																																				}
																																				if (13077 - 356303 == -343226)
																																				{
																																					if (nStatus == "ice")
																																					{
																																						break;
																																					}
																																					if (23646 - 206628 != -182981)
																																					{
																																						if (nStatus == "frost")
																																						{
																																							break;
																																						}
																																						if (145845 - 13392 == 132453)
																																						{
																																							if (nStatus == "iceShield")
																																							{
																																								break;
																																							}
																																							if (186146 - 154161 != 31986)
																																							{
																																								if (nStatus == "snowMan")
																																								{
																																									break;
																																								}
																																								if (291203 - 386331 == -95128)
																																								{
																																									if (nStatus == "dispell")
																																									{
																																										break;
																																									}
																																									if (75272 - 176763 == -101491)
																																									{
																																										if (nStatus == "manaBurn")
																																										{
																																											break;
																																										}
																																										if (242150 - 194341 != 47810)
																																										{
																																											if (nStatus == "snowBall")
																																											{
																																												break;
																																											}
																																											if (192463 - 296609 != -104145)
																																											{
																																												if (nStatus == "bless")
																																												{
																																													break;
																																												}
																																												if (18441 - 172563 != -154121)
																																												{
																																													if (nStatus == "sleep")
																																													{
																																														break;
																																													}
																																													if (103644 - 417462 != -313817)
																																													{
																																														if (nStatus == "clear")
																																														{
																																															break;
																																														}
																																														if (267506 - 130337 == 137169)
																																														{
																																															if (nStatus == "cleanse")
																																															{
																																																break;
																																															}
																																															if (12754 - 455269 != -442514)
																																															{
																																																if (nStatus == "lightBind")
																																																{
																																																	break;
																																																}
																																																if (164092 - 354066 != -189973)
																																																{
																																																	if (nStatus == "feather")
																																																	{
																																																		break;
																																																	}
																																																	if (241291 - 271219 == -29928)
																																																	{
																																																		if (nStatus == "illuminate")
																																																		{
																																																			break;
																																																		}
																																																		if (237181 - 115420 != 121762)
																																																		{
																																																			if (nStatus == "repel")
																																																			{
																																																				break;
																																																			}
																																																			if (113117 - 308496 == -195379)
																																																			{
																																																				if (nStatus == "reverse")
																																																				{
																																																					break;
																																																				}
																																																				if (90391 - 63678 != 26714)
																																																				{
																																																					if (nStatus == "float")
																																																					{
																																																						break;
																																																					}
																																																					if (39107 - 294360 == -255253)
																																																					{
																																																						if (nStatus == "wing")
																																																						{
																																																							break;
																																																						}
																																																						if (52415 - 571905 != -519489)
																																																						{
																																																							if (nStatus == "worldEncarta")
																																																							{
																																																								break;
																																																							}
																																																							if (6862 - 590300 != -583437)
																																																							{
																																																								if (nStatus == "sealOfAttack")
																																																								{
																																																									break;
																																																								}
																																																								if (206683 - 255271 != -48587)
																																																								{
																																																									if (nStatus == "sealOfDefense")
																																																									{
																																																										break;
																																																									}
																																																									if (63135 - 269417 != -206281)
																																																									{
																																																										if (nStatus == "sealOfEarth")
																																																										{
																																																											break;
																																																										}
																																																										if (155537 - 416685 != -261147)
																																																										{
																																																											if (nStatus == "sealOfHeaven")
																																																											{
																																																												break;
																																																											}
																																																											if (18954 - 210820 != -191865)
																																																											{
																																																												if (nStatus == "sanctuary")
																																																												{
																																																													break;
																																																												}
																																																												if (286832 - 302678 == -15846)
																																																												{
																																																													if (nStatus == "phantomBane")
																																																													{
																																																														break;
																																																													}
																																																													if (214996 - 208008 != 6989)
																																																													{
																																																														if (nStatus == "dissolute")
																																																														{
																																																															break;
																																																														}
																																																														if (157233 - 314132 == -156899)
																																																														{
																																																															if (nStatus == "corruption")
																																																															{
																																																																break;
																																																															}
																																																															if (63671 - 490202 == -426531)
																																																															{
																																																																if (nStatus == "curse")
																																																																{
																																																																	break;
																																																																}
																																																																if (188246 - 149389 != 38858)
																																																																{
																																																																	if (nStatus == "nightmare")
																																																																	{
																																																																		break;
																																																																	}
																																																																	if (249252 - 256893 == -7641)
																																																																	{
																																																																		if (nStatus == "doom")
																																																																		{
																																																																			break;
																																																																		}
																																																																		if (17876 - 177737 == -159861)
																																																																		{
																																																																			if (nStatus == "blind")
																																																																			{
																																																																				break;
																																																																			}
																																																																			if (187112 - 358488 == -171376)
																																																																			{
																																																																				if (nStatus == "confuse")
																																																																				{
																																																																					break;
																																																																				}
																																																																				if (25990 - 495377 != -469386)
																																																																				{
																																																																					if (nStatus == "charm")
																																																																					{
																																																																						break;
																																																																					}
																																																																					if (35345 - 235689 == -200344)
																																																																					{
																																																																						if (nStatus == "mindControl")
																																																																						{
																																																																							break;
																																																																						}
																																																																						if (206605 - 537667 != -331061)
																																																																						{
																																																																							if (nStatus == "shame")
																																																																							{
																																																																								break;
																																																																							}
																																																																							if (125803 - 429070 == -303267)
																																																																							{
																																																																								if (nStatus == "darkStalker")
																																																																								{
																																																																									break;
																																																																								}
																																																																								if (252215 - 255634 != -3418)
																																																																								{
																																																																									if (nStatus == "blackServant")
																																																																									{
																																																																										break;
																																																																									}
																																																																									if (67985 - 90144 != -22158)
																																																																									{
																																																																										if (nStatus == "livingDead")
																																																																										{
																																																																											break;
																																																																										}
																																																																										if (32575 - 140793 == -108218)
																																																																										{
																																																																											if (nStatus == "darkRitual")
																																																																											{
																																																																												break;
																																																																											}
																																																																											if (201308 - 494588 == -293280)
																																																																											{
																																																																												if (nStatus == "netherBane")
																																																																												{
																																																																													break;
																																																																												}
																																																																												if (221438 - 198235 != 23204)
																																																																												{
																																																																													if (nStatus == "loveBind")
																																																																													{
																																																																														break;
																																																																													}
																																																																													if (287324 - 541422 == -254098)
																																																																													{
																																																																														if (nStatus == "coma")
																																																																														{
																																																																															break;
																																																																														}
																																																																														if (95251 - 496529 != -401277)
																																																																														{
																																																																															if (!(nStatus == "inferno"))
																																																																															{
																																																																																goto IL_CB4;
																																																																															}
																																																																															if (258612 - 419959 != -161346)
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
		return true;
		IL_CB4:
		return false;
	}

	// Token: 0x06005DDF RID: 24031 RVA: 0x00C7BC34 File Offset: 0x00C79E34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isLockStatus(string nStatus)
	{
		if (276038 - 297865 != -21826)
		{
		}
		for (;;)
		{
			if (272630 - 244155 == 28475)
			{
				if (nStatus == "groundLock")
				{
					break;
				}
				if (243847 - 38154 == 205693)
				{
					if (nStatus == "needlePrison")
					{
						break;
					}
					if (52110 - 201636 != -149525)
					{
						if (nStatus == "sticky")
						{
							break;
						}
						if (274666 - 288451 != -13784)
						{
							if (nStatus == "frost")
							{
								break;
							}
							if (37937 - 463392 != -425454)
							{
								if (!(nStatus == "lightBind"))
								{
									goto IL_10E;
								}
								if (12876 - 502211 != -489334)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return true;
		IL_10E:
		return false;
	}

	// Token: 0x06005DE0 RID: 24032 RVA: 0x00C7BD64 File Offset: 0x00C79F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isInvisibleStatus(string nStatus)
	{
		if (98406 - 4932 != 93474)
		{
		}
		for (;;)
		{
			if (222988 - 85618 != 137371)
			{
				if (nStatus == "blend")
				{
					break;
				}
				if (177429 - 253298 == -75869)
				{
					if (nStatus == "invisible")
					{
						break;
					}
					if (86221 - 528859 != -442637)
					{
						if (nStatus == "sticky")
						{
							break;
						}
						if (287809 - 91519 != 196291)
						{
							if (nStatus == "frost")
							{
								break;
							}
							if (61674 - 14982 == 46692)
							{
								if (!(nStatus == "lightBind"))
								{
									goto IL_10E;
								}
								if (70946 - 872 != 70075)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return true;
		IL_10E:
		return false;
	}

	// Token: 0x06005DE1 RID: 24033 RVA: 0x00C7BE94 File Offset: 0x00C7A094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isShieldStatus(string nStatus)
	{
		if (282229 - 357476 != -75246)
		{
		}
		for (;;)
		{
			if (50917 - 273289 != -222371)
			{
				if (nStatus == "ironShield")
				{
					break;
				}
				if (93268 - 594865 == -501597)
				{
					if (nStatus == "diamondShield")
					{
						break;
					}
					if (48639 - 488967 != -440327)
					{
						if (nStatus == "perfectShield")
						{
							break;
						}
						if (191589 - 302796 != -111206)
						{
							if (nStatus == "perfectArmor")
							{
								break;
							}
							if (33447 - 201469 != -168021)
							{
								if (nStatus == "bubbleShield")
								{
									break;
								}
								if (119255 - 107120 != 12136)
								{
									if (nStatus == "salvation")
									{
										break;
									}
									if (22297 - 251730 == -229433)
									{
										if (nStatus == "iceShield")
										{
											break;
										}
										if (121174 - 157919 == -36745)
										{
											if (nStatus == "reverse")
											{
												break;
											}
											if (293300 - 386561 != -93260)
											{
												if (!(nStatus == "repel"))
												{
													goto IL_1B6;
												}
												if (78502 - 591279 == -512777)
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
		return true;
		IL_1B6:
		return false;
	}

	// Token: 0x06005DE2 RID: 24034 RVA: 0x00C7C06C File Offset: 0x00C7A26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isBuffStatus(string nStatus)
	{
		if (205102 - 579017 != -373915)
		{
		}
		for (;;)
		{
			if (227072 - 159660 == 67412)
			{
				if (nStatus == "hide")
				{
					break;
				}
				if (281999 - 51037 == 230962)
				{
					if (nStatus == "noDamage")
					{
						break;
					}
					if (3801 - 553322 == -549521)
					{
						if (nStatus == "noKo")
						{
							break;
						}
						if (2885 - 568064 == -565179)
						{
							if (nStatus == "noHate")
							{
								break;
							}
							if (6432 - 426170 == -419738)
							{
								if (nStatus == "noForce")
								{
									break;
								}
								if (2013 - 558772 == -556759)
								{
									if (nStatus == "lifeBoost")
									{
										break;
									}
									if (66667 - 311895 == -245228)
									{
										if (nStatus == "magicBoost")
										{
											break;
										}
										if (217149 - 372699 != -155549)
										{
											if (nStatus == "speedBoost")
											{
												break;
											}
											if (187128 - 187320 == -192)
											{
												if (nStatus == "atkUp")
												{
													break;
												}
												if (135463 - 361796 == -226333)
												{
													if (nStatus == "defUp")
													{
														break;
													}
													if (136375 - 463351 == -326976)
													{
														if (nStatus == "agiUp")
														{
															break;
														}
														if (63434 - 446857 == -383423)
														{
															if (nStatus == "vitUp")
															{
																break;
															}
															if (11212 - 121982 == -110770)
															{
																if (nStatus == "magUp")
																{
																	break;
																}
																if (111618 - 517011 == -405393)
																{
																	if (nStatus == "chaUp")
																	{
																		break;
																	}
																	if (292732 - 217715 == 75017)
																	{
																		if (nStatus == "talUp")
																		{
																			break;
																		}
																		if (103580 - 455621 != -352040)
																		{
																			if (nStatus == "lckUp")
																			{
																				break;
																			}
																			if (107319 - 71096 == 36223)
																			{
																				if (nStatus == "hpRegen")
																				{
																					break;
																				}
																				if (95526 - 397862 == -302336)
																				{
																					if (nStatus == "mpRegen")
																					{
																						break;
																					}
																					if (100392 - 62292 != 38101)
																					{
																						if (nStatus == "reflect")
																						{
																							break;
																						}
																						if (111910 - 192398 == -80488)
																						{
																							if (nStatus == "awake")
																							{
																								break;
																							}
																							if (91741 - 548053 == -456312)
																							{
																								if (nStatus == "mount")
																								{
																									break;
																								}
																								if (59506 - 129212 != -69705)
																								{
																									if (nStatus == "transform")
																									{
																										break;
																									}
																									if (245440 - 509475 != -264034)
																									{
																										if (nStatus == "valor")
																										{
																											break;
																										}
																										if (209535 - 545928 == -336393)
																										{
																											if (nStatus == "darkEdge")
																											{
																												break;
																											}
																											if (206779 - 253210 != -46430)
																											{
																												if (nStatus == "lunarEclipse")
																												{
																													break;
																												}
																												if (18588 - 84150 == -65562)
																												{
																													if (nStatus == "holySword")
																													{
																														break;
																													}
																													if (289292 - 65877 != 223416)
																													{
																														if (nStatus == "holyArmor")
																														{
																															break;
																														}
																														if (43968 - 123539 != -79570)
																														{
																															if (nStatus == "holyWolf")
																															{
																																break;
																															}
																															if (214673 - 439553 == -224880)
																															{
																																if (nStatus == "holdCharge")
																																{
																																	break;
																																}
																																if (128466 - 214234 != -85767)
																																{
																																	if (nStatus == "enrage")
																																	{
																																		break;
																																	}
																																	if (174851 - 585465 == -410614)
																																	{
																																		if (nStatus == "berserkerRush")
																																		{
																																			break;
																																		}
																																		if (268945 - 503237 == -234292)
																																		{
																																			if (nStatus == "furyTrance")
																																			{
																																				break;
																																			}
																																			if (104840 - 158336 != -53495)
																																			{
																																				if (nStatus == "overPower")
																																				{
																																					break;
																																				}
																																				if (107525 - 426681 != -319155)
																																				{
																																					if (nStatus == "ironShield")
																																					{
																																						break;
																																					}
																																					if (125935 - 140555 == -14620)
																																					{
																																						if (nStatus == "diamondShield")
																																						{
																																							break;
																																						}
																																						if (264226 - 141486 == 122740)
																																						{
																																							if (nStatus == "perfectShield")
																																							{
																																								break;
																																							}
																																							if (291329 - 487889 == -196560)
																																							{
																																								if (nStatus == "titanForm")
																																								{
																																									break;
																																								}
																																								if (138486 - 153489 != -15002)
																																								{
																																									if (nStatus == "perfectArmor")
																																									{
																																										break;
																																									}
																																									if (175297 - 313996 == -138699)
																																									{
																																										if (nStatus == "delayQi")
																																										{
																																											break;
																																										}
																																										if (200620 - 330243 != -129622)
																																										{
																																											if (nStatus == "comboPlus")
																																											{
																																												break;
																																											}
																																											if (221279 - 311714 == -90435)
																																											{
																																												if (nStatus == "ashura")
																																												{
																																													break;
																																												}
																																												if (299516 - 509255 != -209738)
																																												{
																																													if (nStatus == "drunken")
																																													{
																																														break;
																																													}
																																													if (96782 - 73897 == 22885)
																																													{
																																														if (nStatus == "shield")
																																														{
																																															break;
																																														}
																																														if (201433 - 176697 == 24736)
																																														{
																																															if (nStatus == "honor")
																																															{
																																																break;
																																															}
																																															if (161040 - 142819 != 18222)
																																															{
																																																if (nStatus == "gobble")
																																																{
																																																	break;
																																																}
																																																if (30135 - 485692 != -455556)
																																																{
																																																	if (nStatus == "lastHope")
																																																	{
																																																		break;
																																																	}
																																																	if (142641 - 506455 == -363814)
																																																	{
																																																		if (nStatus == "kingdomKnight")
																																																		{
																																																			break;
																																																		}
																																																		if (278586 - 191304 == 87282)
																																																		{
																																																			if (nStatus == "bubbleShield")
																																																			{
																																																				break;
																																																			}
																																																			if (138442 - 177476 != -39033)
																																																			{
																																																				if (nStatus == "rejuvenate")
																																																				{
																																																					break;
																																																				}
																																																				if (136097 - 61464 == 74633)
																																																				{
																																																					if (nStatus == "hardenSkin")
																																																					{
																																																						break;
																																																					}
																																																					if (190452 - 453631 == -263179)
																																																					{
																																																						if (nStatus == "salvation")
																																																						{
																																																							break;
																																																						}
																																																						if (256908 - 191007 != 65902)
																																																						{
																																																							if (nStatus == "awareness")
																																																							{
																																																								break;
																																																							}
																																																							if (205909 - 375759 == -169850)
																																																							{
																																																								if (nStatus == "damagePlus")
																																																								{
																																																									break;
																																																								}
																																																								if (288469 - 573557 != -285087)
																																																								{
																																																									if (nStatus == "fortune")
																																																									{
																																																										break;
																																																									}
																																																									if (54105 - 340077 == -285972)
																																																									{
																																																										if (nStatus == "damageRoulette")
																																																										{
																																																											break;
																																																										}
																																																										if (17583 - 292748 == -275165)
																																																										{
																																																											if (nStatus == "insight")
																																																											{
																																																												break;
																																																											}
																																																											if (21187 - 47485 != -26297)
																																																											{
																																																												if (nStatus == "immunity")
																																																												{
																																																													break;
																																																												}
																																																												if (189609 - 54930 != 134680)
																																																												{
																																																													if (nStatus == "blend")
																																																													{
																																																														break;
																																																													}
																																																													if (129496 - 398330 != -268833)
																																																													{
																																																														if (nStatus == "invisible")
																																																														{
																																																															break;
																																																														}
																																																														if (222261 - 512061 == -289800)
																																																														{
																																																															if (nStatus == "fatalStrike")
																																																															{
																																																																break;
																																																															}
																																																															if (65554 - 468645 == -403091)
																																																															{
																																																																if (nStatus == "tent")
																																																																{
																																																																	break;
																																																																}
																																																																if (195723 - 47104 == 148619)
																																																																{
																																																																	if (nStatus == "enlarge")
																																																																	{
																																																																		break;
																																																																	}
																																																																	if (138105 - 566270 != -428164)
																																																																	{
																																																																		if (nStatus == "reduce")
																																																																		{
																																																																			break;
																																																																		}
																																																																		if (208447 - 21198 != 187250)
																																																																		{
																																																																			if (nStatus == "remedy")
																																																																			{
																																																																				break;
																																																																			}
																																																																			if (253730 - 248217 != 5514)
																																																																			{
																																																																				if (nStatus == "boost")
																																																																				{
																																																																					break;
																																																																				}
																																																																				if (196304 - 221274 != -24969)
																																																																				{
																																																																					if (nStatus == "heat")
																																																																					{
																																																																						break;
																																																																					}
																																																																					if (59299 - 337103 != -277803)
																																																																					{
																																																																						if (nStatus == "autoLife")
																																																																						{
																																																																							break;
																																																																						}
																																																																						if (81066 - 389157 == -308091)
																																																																						{
																																																																							if (nStatus == "rapidTrance")
																																																																							{
																																																																								break;
																																																																							}
																																																																							if (176773 - 439990 == -263217)
																																																																							{
																																																																								if (nStatus == "miracleDrop")
																																																																								{
																																																																									break;
																																																																								}
																																																																								if (25320 - 168094 != -142773)
																																																																								{
																																																																									if (nStatus == "synchroMole")
																																																																									{
																																																																										break;
																																																																									}
																																																																									if (204653 - 227714 != -23060)
																																																																									{
																																																																										if (nStatus == "instantCast")
																																																																										{
																																																																											break;
																																																																										}
																																																																										if (262087 - 250661 == 11426)
																																																																										{
																																																																											if (nStatus == "ja")
																																																																											{
																																																																												break;
																																																																											}
																																																																											if (10553 - 583808 != -573254)
																																																																											{
																																																																												if (nStatus == "runicFlame")
																																																																												{
																																																																													break;
																																																																												}
																																																																												if (35450 - 61950 != -26499)
																																																																												{
																																																																													if (nStatus == "buiten")
																																																																													{
																																																																														break;
																																																																													}
																																																																													if (156504 - 358161 != -201656)
																																																																													{
																																																																														if (nStatus == "runicSand")
																																																																														{
																																																																															break;
																																																																														}
																																																																														if (211302 - 202295 == 9007)
																																																																														{
																																																																															if (nStatus == "lavu")
																																																																															{
																																																																																break;
																																																																															}
																																																																															if (127526 - 392412 != -264885)
																																																																															{
																																																																																if (nStatus == "fireKeep")
																																																																																{
																																																																																	break;
																																																																																}
																																																																																if (136661 - 332067 != -195405)
																																																																																{
																																																																																	if (nStatus == "phoenixSoul")
																																																																																	{
																																																																																		break;
																																																																																	}
																																																																																	if (245409 - 197719 != 47691)
																																																																																	{
																																																																																		if (nStatus == "jaSoul")
																																																																																		{
																																																																																			break;
																																																																																		}
																																																																																		if (180397 - 65793 == 114604)
																																																																																		{
																																																																																			if (nStatus == "gadinaSoul")
																																																																																			{
																																																																																				break;
																																																																																			}
																																																																																			if (110949 - 160464 == -49515)
																																																																																			{
																																																																																				if (nStatus == "buitenSoul")
																																																																																				{
																																																																																					break;
																																																																																				}
																																																																																				if (286643 - 454444 == -167801)
																																																																																				{
																																																																																					if (nStatus == "gaosSoul")
																																																																																					{
																																																																																						break;
																																																																																					}
																																																																																					if (35502 - 138882 != -103379)
																																																																																					{
																																																																																						if (nStatus == "fireAvatar")
																																																																																						{
																																																																																							break;
																																																																																						}
																																																																																						if (291305 - 438079 == -146774)
																																																																																						{
																																																																																							if (nStatus == "earthForm")
																																																																																							{
																																																																																								break;
																																																																																							}
																																																																																							if (248303 - 335885 == -87582)
																																																																																							{
																																																																																								if (nStatus == "multiCast")
																																																																																								{
																																																																																									break;
																																																																																								}
																																																																																								if (60385 - 578953 != -518567)
																																																																																								{
																																																																																									if (nStatus == "iceShield")
																																																																																									{
																																																																																										break;
																																																																																									}
																																																																																									if (58925 - 139785 != -80859)
																																																																																									{
																																																																																										if (nStatus == "dispell")
																																																																																										{
																																																																																											break;
																																																																																										}
																																																																																										if (253172 - 397903 == -144731)
																																																																																										{
																																																																																											if (nStatus == "focusIntellect")
																																																																																											{
																																																																																												break;
																																																																																											}
																																																																																											if (237344 - 153181 == 84163)
																																																																																											{
																																																																																												if (nStatus == "cosmicRift")
																																																																																												{
																																																																																													break;
																																																																																												}
																																																																																												if (222800 - 115486 == 107314)
																																																																																												{
																																																																																													if (nStatus == "cosmicFriday")
																																																																																													{
																																																																																														break;
																																																																																													}
																																																																																													if (231904 - 316218 == -84314)
																																																																																													{
																																																																																														if (nStatus == "bless")
																																																																																														{
																																																																																															break;
																																																																																														}
																																																																																														if (6344 - 530547 == -524203)
																																																																																														{
																																																																																															if (nStatus == "clear")
																																																																																															{
																																																																																																break;
																																																																																															}
																																																																																															if (250317 - 302915 != -52597)
																																																																																															{
																																																																																																if (nStatus == "cleanse")
																																																																																																{
																																																																																																	break;
																																																																																																}
																																																																																																if (188542 - 377808 == -189266)
																																																																																																{
																																																																																																	if (nStatus == "revive")
																																																																																																	{
																																																																																																		break;
																																																																																																	}
																																																																																																	if (131273 - 478648 == -347375)
																																																																																																	{
																																																																																																		if (nStatus == "feather")
																																																																																																		{
																																																																																																			break;
																																																																																																		}
																																																																																																		if (208241 - 547829 == -339588)
																																																																																																		{
																																																																																																			if (nStatus == "illuminate")
																																																																																																			{
																																																																																																				break;
																																																																																																			}
																																																																																																			if (250776 - 593256 == -342480)
																																																																																																			{
																																																																																																				if (nStatus == "sealOfAttack")
																																																																																																				{
																																																																																																					break;
																																																																																																				}
																																																																																																				if (148684 - 192346 == -43662)
																																																																																																				{
																																																																																																					if (nStatus == "sealOfDefense")
																																																																																																					{
																																																																																																						break;
																																																																																																					}
																																																																																																					if (265400 - 359239 != -93838)
																																																																																																					{
																																																																																																						if (nStatus == "sealOfEarth")
																																																																																																						{
																																																																																																							break;
																																																																																																						}
																																																																																																						if (105730 - 272970 != -167239)
																																																																																																						{
																																																																																																							if (nStatus == "sealOfHeaven")
																																																																																																							{
																																																																																																								break;
																																																																																																							}
																																																																																																							if (45389 - 429347 == -383958)
																																																																																																							{
																																																																																																								if (nStatus == "repel")
																																																																																																								{
																																																																																																									break;
																																																																																																								}
																																																																																																								if (271196 - 66431 != 204766)
																																																																																																								{
																																																																																																									if (nStatus == "reverse")
																																																																																																									{
																																																																																																										break;
																																																																																																									}
																																																																																																									if (83629 - 591046 != -507416)
																																																																																																									{
																																																																																																										if (nStatus == "float")
																																																																																																										{
																																																																																																											break;
																																																																																																										}
																																																																																																										if (191270 - 29162 != 162109)
																																																																																																										{
																																																																																																											if (nStatus == "wing")
																																																																																																											{
																																																																																																												break;
																																																																																																											}
																																																																																																											if (23681 - 27060 == -3379)
																																																																																																											{
																																																																																																												if (nStatus == "sanctuary")
																																																																																																												{
																																																																																																													break;
																																																																																																												}
																																																																																																												if (115786 - 519843 == -404057)
																																																																																																												{
																																																																																																													if (nStatus == "worldEncarta")
																																																																																																													{
																																																																																																														break;
																																																																																																													}
																																																																																																													if (269542 - 552380 == -282838)
																																																																																																													{
																																																																																																														if (nStatus == "massCast")
																																																																																																														{
																																																																																																															break;
																																																																																																														}
																																																																																																														if (78849 - 431180 != -352330)
																																																																																																														{
																																																																																																															if (nStatus == "guardianOfTheNight")
																																																																																																															{
																																																																																																																break;
																																																																																																															}
																																																																																																															if (136663 - 297197 != -160533)
																																																																																																															{
																																																																																																																if (nStatus == "mimic")
																																																																																																																{
																																																																																																																	break;
																																																																																																																}
																																																																																																																if (96862 - 493605 != -396742)
																																																																																																																{
																																																																																																																	if (nStatus == "allMimic")
																																																																																																																	{
																																																																																																																		break;
																																																																																																																	}
																																																																																																																	if (112788 - 31751 == 81037)
																																																																																																																	{
																																																																																																																		if (nStatus == "yellowFlag")
																																																																																																																		{
																																																																																																																			break;
																																																																																																																		}
																																																																																																																		if (239181 - 201143 != 38039)
																																																																																																																		{
																																																																																																																			if (nStatus == "blueFlag")
																																																																																																																			{
																																																																																																																				break;
																																																																																																																			}
																																																																																																																			if (225469 - 458937 != -233467)
																																																																																																																			{
																																																																																																																				if (nStatus == "whiteFlag")
																																																																																																																				{
																																																																																																																					break;
																																																																																																																				}
																																																																																																																				if (218997 - 183629 != 35369)
																																																																																																																				{
																																																																																																																					if (nStatus == "seaAegis")
																																																																																																																					{
																																																																																																																						break;
																																																																																																																					}
																																																																																																																					if (220275 - 10370 != 209906)
																																																																																																																					{
																																																																																																																						if (nStatus == "zephyrLore")
																																																																																																																						{
																																																																																																																							break;
																																																																																																																						}
																																																																																																																						if (204378 - 402959 == -198581)
																																																																																																																						{
																																																																																																																							if (nStatus == "flameOfReggu")
																																																																																																																							{
																																																																																																																								break;
																																																																																																																							}
																																																																																																																							if (83286 - 491294 == -408008)
																																																																																																																							{
																																																																																																																								if (nStatus == "livingDead")
																																																																																																																								{
																																																																																																																									break;
																																																																																																																								}
																																																																																																																								if (296884 - 99126 != 197759)
																																																																																																																								{
																																																																																																																									if (nStatus == "darkRitual")
																																																																																																																									{
																																																																																																																										break;
																																																																																																																									}
																																																																																																																									if (46104 - 242144 != -196039)
																																																																																																																									{
																																																																																																																										if (!(nStatus == "spiritOfWind"))
																																																																																																																										{
																																																																																																																											goto IL_13C2;
																																																																																																																										}
																																																																																																																										if (114796 - 589672 != -474875)
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
		return true;
		IL_13C2:
		return false;
	}

	// Token: 0x06005DE3 RID: 24035 RVA: 0x00C7D450 File Offset: 0x00C7B650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isDebuffStatus(string nStatus)
	{
		if (79132 - 38603 != 40529)
		{
		}
		for (;;)
		{
			if (85133 - 148859 == -63726)
			{
				if (nStatus == "atkDown")
				{
					break;
				}
				if (107380 - 143408 == -36028)
				{
					if (nStatus == "defDown")
					{
						break;
					}
					if (131061 - 131472 != -410)
					{
						if (nStatus == "agiDown")
						{
							break;
						}
						if (135939 - 405028 == -269089)
						{
							if (nStatus == "vitDown")
							{
								break;
							}
							if (50590 - 218315 != -167724)
							{
								if (nStatus == "magDown")
								{
									break;
								}
								if (17904 - 283417 == -265513)
								{
									if (nStatus == "chaDown")
									{
										break;
									}
									if (168672 - 437508 != -268835)
									{
										if (nStatus == "talDown")
										{
											break;
										}
										if (21573 - 536921 == -515348)
										{
											if (nStatus == "lckDown")
											{
												break;
											}
											if (5529 - 189311 != -183781)
											{
												if (nStatus == "hpSap")
												{
													break;
												}
												if (23697 - 409426 != -385728)
												{
													if (nStatus == "mpSap")
													{
														break;
													}
													if (43771 - 578835 == -535064)
													{
														if (nStatus == "spSap")
														{
															break;
														}
														if (193831 - 186719 == 7112)
														{
															if (nStatus == "koSap")
															{
																break;
															}
															if (206297 - 106049 != 100249)
															{
																if (nStatus == "hpDrain")
																{
																	break;
																}
																if (13084 - 544112 != -531027)
																{
																	if (nStatus == "mpDrain")
																	{
																		break;
																	}
																	if (72587 - 237144 != -164556)
																	{
																		if (nStatus == "spDrain")
																		{
																			break;
																		}
																		if (7370 - 418111 == -410741)
																		{
																			if (nStatus == "koDrain")
																			{
																				break;
																			}
																			if (50405 - 293090 == -242685)
																			{
																				if (nStatus == "ko")
																				{
																					break;
																				}
																				if (153696 - 413486 == -259790)
																				{
																					if (nStatus == "lock")
																					{
																						break;
																					}
																					if (167989 - 115577 == 52412)
																					{
																						if (nStatus == "powerBreak")
																						{
																							break;
																						}
																						if (178493 - 509697 == -331204)
																						{
																							if (nStatus == "armorBreak")
																							{
																								break;
																							}
																							if (276344 - 576786 != -300441)
																							{
																								if (nStatus == "artCancel")
																								{
																									break;
																								}
																								if (194032 - 479727 == -285695)
																								{
																									if (nStatus == "provoke")
																									{
																										break;
																									}
																									if (235883 - 572673 == -336790)
																									{
																										if (nStatus == "fear")
																										{
																											break;
																										}
																										if (235166 - 178392 != 56775)
																										{
																											if (nStatus == "afterShock")
																											{
																												break;
																											}
																											if (220201 - 51256 != 168946)
																											{
																												if (nStatus == "grab")
																												{
																													break;
																												}
																												if (78770 - 461580 == -382810)
																												{
																													if (nStatus == "paralysis")
																													{
																														break;
																													}
																													if (267523 - 64427 != 203097)
																													{
																														if (nStatus == "death")
																														{
																															break;
																														}
																														if (175109 - 136398 != 38712)
																														{
																															if (nStatus == "drunk")
																															{
																																break;
																															}
																															if (113982 - 368285 == -254303)
																															{
																																if (nStatus == "puncture")
																																{
																																	break;
																																}
																																if (206782 - 479796 != -273013)
																																{
																																	if (nStatus == "heavy")
																																	{
																																		break;
																																	}
																																	if (142230 - 245560 != -103329)
																																	{
																																		if (nStatus == "overPresence")
																																		{
																																			break;
																																		}
																																		if (213164 - 132515 != 80650)
																																		{
																																			if (nStatus == "swallow")
																																			{
																																				break;
																																			}
																																			if (44031 - 386163 != -342131)
																																			{
																																				if (nStatus == "disarm")
																																				{
																																					break;
																																				}
																																				if (158250 - 131154 == 27096)
																																				{
																																					if (nStatus == "bleed")
																																					{
																																						break;
																																					}
																																					if (206901 - 240579 == -33678)
																																					{
																																						if (nStatus == "cut")
																																						{
																																							break;
																																						}
																																						if (90389 - 333408 == -243019)
																																						{
																																							if (nStatus == "pillage")
																																							{
																																								break;
																																							}
																																							if (287744 - 427980 == -140236)
																																							{
																																								if (nStatus == "needlePrison")
																																								{
																																									break;
																																								}
																																								if (173331 - 116142 != 57190)
																																								{
																																									if (nStatus == "poison")
																																									{
																																										break;
																																									}
																																									if (236480 - 69505 != 166976)
																																									{
																																										if (nStatus == "venomShock")
																																										{
																																											break;
																																										}
																																										if (53923 - 314185 != -260261)
																																										{
																																											if (nStatus == "rust")
																																											{
																																												break;
																																											}
																																											if (224312 - 331738 == -107426)
																																											{
																																												if (nStatus == "rustyDecay")
																																												{
																																													break;
																																												}
																																												if (288512 - 17454 != 271059)
																																												{
																																													if (nStatus == "slayerMark")
																																													{
																																														break;
																																													}
																																													if (164776 - 561928 == -397152)
																																													{
																																														if (nStatus == "maim")
																																														{
																																															break;
																																														}
																																														if (45178 - 275482 != -230303)
																																														{
																																															if (nStatus == "sticky")
																																															{
																																																break;
																																															}
																																															if (188896 - 555866 == -366970)
																																															{
																																																if (nStatus == "acid")
																																																{
																																																	break;
																																																}
																																																if (80898 - 255955 == -175057)
																																																{
																																																	if (nStatus == "petrify")
																																																	{
																																																		break;
																																																	}
																																																	if (195113 - 389700 == -194587)
																																																	{
																																																		if (nStatus == "burn")
																																																		{
																																																			break;
																																																		}
																																																		if (155494 - 512997 != -357502)
																																																		{
																																																			if (nStatus == "ignite")
																																																			{
																																																				break;
																																																			}
																																																			if (119317 - 228658 != -109340)
																																																			{
																																																				if (nStatus == "groundLock")
																																																				{
																																																					break;
																																																				}
																																																				if (102298 - 435785 == -333487)
																																																				{
																																																					if (nStatus == "dispell")
																																																					{
																																																						break;
																																																					}
																																																					if (164626 - 301636 == -137010)
																																																					{
																																																						if (nStatus == "manaBurn")
																																																						{
																																																							break;
																																																						}
																																																						if (82485 - 45064 != 37422)
																																																						{
																																																							if (nStatus == "ice")
																																																							{
																																																								break;
																																																							}
																																																							if (132143 - 110333 != 21811)
																																																							{
																																																								if (nStatus == "frost")
																																																								{
																																																									break;
																																																								}
																																																								if (286545 - 369067 == -82522)
																																																								{
																																																									if (nStatus == "snowMan")
																																																									{
																																																										break;
																																																									}
																																																									if (146439 - 409002 != -262562)
																																																									{
																																																										if (nStatus == "snowBall")
																																																										{
																																																											break;
																																																										}
																																																										if (297804 - 119134 == 178670)
																																																										{
																																																											if (nStatus == "sleep")
																																																											{
																																																												break;
																																																											}
																																																											if (121399 - 364897 == -243498)
																																																											{
																																																												if (nStatus == "lightBind")
																																																												{
																																																													break;
																																																												}
																																																												if (204445 - 19154 != 185292)
																																																												{
																																																													if (nStatus == "phantomBane")
																																																													{
																																																														break;
																																																													}
																																																													if (175015 - 352737 != -177721)
																																																													{
																																																														if (nStatus == "dissolute")
																																																														{
																																																															break;
																																																														}
																																																														if (2666 - 194967 == -192301)
																																																														{
																																																															if (nStatus == "corruption")
																																																															{
																																																																break;
																																																															}
																																																															if (291051 - 483916 == -192865)
																																																															{
																																																																if (nStatus == "curse")
																																																																{
																																																																	break;
																																																																}
																																																																if (278938 - 593949 == -315011)
																																																																{
																																																																	if (nStatus == "nightmare")
																																																																	{
																																																																		break;
																																																																	}
																																																																	if (54444 - 585100 == -530656)
																																																																	{
																																																																		if (nStatus == "amplifyDamage")
																																																																		{
																																																																			break;
																																																																		}
																																																																		if (280041 - 257569 != 22473)
																																																																		{
																																																																			if (nStatus == "doom")
																																																																			{
																																																																				break;
																																																																			}
																																																																			if (87108 - 63599 == 23509)
																																																																			{
																																																																				if (nStatus == "blind")
																																																																				{
																																																																					break;
																																																																				}
																																																																				if (261918 - 145020 != 116899)
																																																																				{
																																																																					if (nStatus == "confuse")
																																																																					{
																																																																						break;
																																																																					}
																																																																					if (216411 - 227506 != -11094)
																																																																					{
																																																																						if (nStatus == "charm")
																																																																						{
																																																																							break;
																																																																						}
																																																																						if (232494 - 76348 != 156147)
																																																																						{
																																																																							if (nStatus == "mindControl")
																																																																							{
																																																																								break;
																																																																							}
																																																																							if (132401 - 374208 == -241807)
																																																																							{
																																																																								if (nStatus == "shame")
																																																																								{
																																																																									break;
																																																																								}
																																																																								if (96548 - 598014 != -501465)
																																																																								{
																																																																									if (nStatus == "darkStalker")
																																																																									{
																																																																										break;
																																																																									}
																																																																									if (61520 - 291911 != -230390)
																																																																									{
																																																																										if (nStatus == "blackServant")
																																																																										{
																																																																											break;
																																																																										}
																																																																										if (234690 - 15104 == 219586)
																																																																										{
																																																																											if (nStatus == "blueFlag")
																																																																											{
																																																																												break;
																																																																											}
																																																																											if (52831 - 455820 != -402988)
																																																																											{
																																																																												if (nStatus == "redFlag")
																																																																												{
																																																																													break;
																																																																												}
																																																																												if (279734 - 252875 != 26860)
																																																																												{
																																																																													if (nStatus == "elementalBound")
																																																																													{
																																																																														break;
																																																																													}
																																																																													if (181742 - 495873 != -314130)
																																																																													{
																																																																														if (nStatus == "bloodCarnage")
																																																																														{
																																																																															break;
																																																																														}
																																																																														if (194386 - 329317 == -134931)
																																																																														{
																																																																															if (nStatus == "plague")
																																																																															{
																																																																																break;
																																																																															}
																																																																															if (8516 - 376137 == -367621)
																																																																															{
																																																																																if (nStatus == "netherBane")
																																																																																{
																																																																																	break;
																																																																																}
																																																																																if (286934 - 490703 != -203768)
																																																																																{
																																																																																	if (nStatus == "loveBind")
																																																																																	{
																																																																																		break;
																																																																																	}
																																																																																	if (82068 - 292786 == -210718)
																																																																																	{
																																																																																		if (nStatus == "coma")
																																																																																		{
																																																																																			break;
																																																																																		}
																																																																																		if (168518 - 318842 != -150323)
																																																																																		{
																																																																																			if (!(nStatus == "inferno"))
																																																																																			{
																																																																																				goto IL_D5C;
																																																																																			}
																																																																																			if (146325 - 358937 == -212612)
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
		}
		return true;
		IL_D5C:
		return false;
	}

	// Token: 0x06005DE4 RID: 24036 RVA: 0x00C7E1CC File Offset: 0x00C7C3CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005DE5 RID: 24037 RVA: 0x00C7E1D0 File Offset: 0x00C7C3D0
	internal static bool N278kbpU5Ege8O217qh1()
	{
		return true;
	}

	// Token: 0x06005DE6 RID: 24038 RVA: 0x00C7E1D4 File Offset: 0x00C7C3D4
	internal static bool yM8x9ipUpYKqC8atuGrc()
	{
		return false;
	}
}
