using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FD8 RID: 4056
[Serializable]
public class MissionData : MonoBehaviour
{
	// Token: 0x06005CBB RID: 23739 RVA: 0x00C00F4C File Offset: 0x00BFF14C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MissionData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005CBC RID: 23740 RVA: 0x00C00F5C File Offset: 0x00BFF15C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getMissionNumber(int c)
	{
		if (155826 - 240866 != -85040)
		{
		}
		int num;
		int digit;
		int digit2;
		for (;;)
		{
			num = global::Math.getDigit(c, 2) - 1;
			if (206127 - 555388 == -349261)
			{
				digit = global::Math.getDigit(c, 1);
				if (240736 - 169007 == 71729)
				{
					digit2 = global::Math.getDigit(c, 0);
					if (213591 - 54625 != 158967)
					{
						break;
					}
				}
			}
		}
		return num * 8 + digit * 10 + digit2;
	}

	// Token: 0x06005CBD RID: 23741 RVA: 0x00C01008 File Offset: 0x00BFF208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MissionClass getData(int c)
	{
		if (220001 - 280050 != -60049)
		{
		}
		MissionClass missionClass;
		for (;;)
		{
			missionClass = new MissionClass();
			if (289055 - 407521 != -118465)
			{
				missionClass.code = c;
				if (32115 - 387062 != -354946 && 87233 - 253904 != -166670)
				{
					if (c == 30)
					{
						if (83709 - 335996 != -252287)
						{
							continue;
						}
						missionClass.name = "Novice Ground";
						if (80680 - 280007 == -199326)
						{
							continue;
						}
						missionClass.mapName = "Novice Ground";
						if (287150 - 276912 == 10239)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)430, (float)686);
						if (262512 - 217937 != 44575)
						{
							continue;
						}
						missionClass.des = " ยินดีต้อนรับสู่แคมป์ผู้กล้าฝึกหัด";
						if (45535 - 492887 == -447351)
						{
							continue;
						}
						missionClass.obj = "   คุยกับแพนด้าแดงเพื่อรับงาน";
						if (271979 - 48089 == 223891)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (16892 - 196463 != -179571)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (17025 - 195960 == -178934)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (112832 - 204802 != -91970)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (292079 - 517161 != -225082)
						{
							continue;
						}
					}
					else if (c == 31)
					{
						if (30435 - 36588 != -6153)
						{
							continue;
						}
						missionClass.name = "Guild";
						if (132863 - 406162 != -273299)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (231994 - 427897 == -195902)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (293291 - 300265 == -6973)
						{
							continue;
						}
						missionClass.des = "   นั่งล้อมกองไฟสบายๆ ";
						if (63254 - 594724 != -531470)
						{
							continue;
						}
						missionClass.obj = "   คุยกับแพนด้าแดงเพื่อรับงาน";
						if (221983 - 209612 != 12371)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (291432 - 106715 == 184718)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (230213 - 448127 == -217913)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (102440 - 24084 != 78356)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (208689 - 427559 == -218869)
						{
							continue;
						}
					}
					else if (c == 32)
					{
						if (252468 - 457907 != -205439)
						{
							continue;
						}
						missionClass.name = "Snow Camp";
						if (4498 - 188083 == -183584)
						{
							continue;
						}
						missionClass.mapName = "Snow Camp";
						if (48158 - 370300 == -322141)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)357, (float)375);
						if (222681 - 197292 == 25390)
						{
							continue;
						}
						missionClass.des = "   แคมป์ผู้กล้ากลางแดนหิมะ";
						if (210345 - 77784 == 132562)
						{
							continue;
						}
						missionClass.obj = "   คุยกับแพนด้าแดงเพื่อรับงาน";
						if (195547 - 527833 == -332285)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (118929 - 117849 == 1081)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (226883 - 153399 == 73485)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (163045 - 339491 == -176445)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (276366 - 262351 == 14016)
						{
							continue;
						}
					}
					else if (c == 33)
					{
						if (232418 - 313560 == -81141)
						{
							continue;
						}
						missionClass.name = "Crystal Beach";
						if (66336 - 212573 != -146237)
						{
							continue;
						}
						missionClass.mapName = "Crystal Beach";
						if (181450 - 282354 != -100904)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)663, (float)612);
						if (246742 - 586883 != -340141)
						{
							continue;
						}
						missionClass.des = "   แคมป์ผู้กล้าบนชายหาด";
						if (295096 - 160702 == 134395)
						{
							continue;
						}
						missionClass.obj = "   คุยกับแพนด้าแดงเพื่อรับงาน";
						if (68505 - 161925 != -93420)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (262145 - 183073 != 79072)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (248807 - 373799 != -124992)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (231059 - 348926 == -117866)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (7262 - 365729 != -358467)
						{
							continue;
						}
					}
					else if (c == 34)
					{
						if (95722 - 455592 == -359869)
						{
							continue;
						}
						missionClass.name = "Excavation Camp";
						if (102829 - 264946 == -162116)
						{
							continue;
						}
						missionClass.mapName = "Excavation Camp";
						if (108365 - 567043 != -458678)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)639, (float)412);
						if (17298 - 350427 != -333129)
						{
							continue;
						}
						missionClass.des = "   แคมป์คณะนักสำรวจของ ดร.ลิซ่า";
						if (176643 - 334899 != -158256)
						{
							continue;
						}
						missionClass.obj = "   คุยกับแพนด้าแดงเพื่อรับงาน";
						if (251980 - 382803 == -130822)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (264188 - 17653 == 246536)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (220033 - 519259 == -299225)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (81846 - 539981 != -458135)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (40447 - 512047 == -471599)
						{
							continue;
						}
					}
					else if (c == 35)
					{
						if (49530 - 53132 == -3601)
						{
							continue;
						}
						missionClass.name = "Underground Camp";
						if (284406 - 585649 == -301242)
						{
							continue;
						}
						missionClass.mapName = "Underground Camp";
						if (70367 - 159975 != -89608)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)77, (float)569);
						if (298791 - 384214 != -85423)
						{
							continue;
						}
						missionClass.des = "   แคมป์ผู้กล้าใจกลางถ้ำใต้ดินของตุ่นและค้างคาว";
						if (102108 - 247935 != -145827)
						{
							continue;
						}
						missionClass.obj = "   คุยกับแพนด้าแดงเพื่อรับงาน";
						if (214376 - 561026 != -346650)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (292787 - 123744 != 169043)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (104799 - 232660 == -127860)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (106717 - 255034 == -148316)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (283409 - 106829 == 176581)
						{
							continue;
						}
					}
					else if (c == 36)
					{
						if (195167 - 552424 != -357257)
						{
							continue;
						}
						missionClass.name = "Forest Camp";
						if (106706 - 386926 == -280219)
						{
							continue;
						}
						missionClass.mapName = "Forest Camp";
						if (157237 - 411152 != -253915)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)77, (float)569);
						if (155005 - 250639 != -95634)
						{
							continue;
						}
						missionClass.des = "   แคมป์ชั่วคราวของกองทัพแสง กลางป่าทางเหนือ";
						if (86478 - 542576 != -456098)
						{
							continue;
						}
						missionClass.obj = "   คุยกับแพนด้าแดงเพื่อรับงาน";
						if (171924 - 318502 == -146577)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (30738 - 87048 != -56310)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (25275 - 504872 != -479597)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (33796 - 308126 != -274330)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (208782 - 56293 == 152490)
						{
							continue;
						}
					}
					else if (c == 51)
					{
						if (143016 - 300976 == -157959)
						{
							continue;
						}
						missionClass.name = "LightCity (Main Street)";
						if (62065 - 64718 != -2653)
						{
							continue;
						}
						missionClass.mapName = "LightCity Main St.";
						if (274179 - 260953 != 13226)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)304, (float)624);
						if (181120 - 469809 != -288689)
						{
							continue;
						}
						missionClass.des = "    ส่วนแรกถัดจากประตูทางเข้าของเมืองแสง เป็นย่านร้านค้าที่คึกคักอยู่ตลอดเวลา สามารถ หาซื้อไอเท็มเกือบทุกชนิดได้ในบริเวณนี้ และยัง มีโรงประมูลที่เต็มไปด้วยสินค้าหายากจากเหล่า นักผจญภัยหมุนเวียนกันมาตลอดอีกด้วย";
						if (106185 - 418217 == -312031)
						{
							continue;
						}
						missionClass.obj = "    ไม่มีธุระอะไรเป็นพิเศษ";
						if (287493 - 177898 != 109595)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (211566 - 521677 == -310110)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (196430 - 209219 != -12789)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (6388 - 198119 == -191730)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (103081 - 486957 == -383875)
						{
							continue;
						}
					}
					else if (c == 52)
					{
						if (266065 - 15527 != 250538)
						{
							continue;
						}
						missionClass.name = "LightCity (Central Square)";
						if (4919 - 414461 != -409542)
						{
							continue;
						}
						missionClass.mapName = "LightCity Central Sqr.";
						if (87618 - 511565 != -423947)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)304, (float)614);
						if (76036 - 111016 != -34980)
						{
							continue;
						}
						missionClass.des = "    ถนนใจกลางเมืองแสง เป็นที่ตั้งของหอสมุด ศูนย์บัญชาการทหารของโบลดาส  รวมถึงกรม พัฒนาและส่งเสริมกิลด์  คุณสามารถเข้าสมัคร แข่งพีวีพี จัดการเกี่ยวกับกิลด์ หรือลงชื่อเข้าร่วม กิลด์บอส ได้ในบริเวณ";
						if (2162 - 193616 != -191454)
						{
							continue;
						}
						missionClass.obj = "    ไม่มีธุระอะไรเป็นพิเศษ";
						if (253159 - 62326 != 190833)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (54046 - 473837 != -419791)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (125656 - 416577 == -290920)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (47285 - 345925 == -298639)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (85815 - 405818 != -320003)
						{
							continue;
						}
					}
					else if (c == 53)
					{
						if (157459 - 62192 != 95267)
						{
							continue;
						}
						missionClass.name = "LightCity (City Library)";
						if (280323 - 309918 != -29595)
						{
							continue;
						}
						missionClass.mapName = "LightCity Library";
						if (77809 - 4383 != 73426)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)304, (float)614);
						if (244638 - 442056 == -197417)
						{
							continue;
						}
						missionClass.des = "     หอสมุดกลางของเมืองแสง เป็นที่เก็บรวบ รวมหนังสือชั้นยอดมากมาย  รวมไปถึงบันทึก โบราณของเผ่าไร้หางซึ่งหลงเหลืออยู่เพียงจำ- นวนหนึ่งเท่านั้น สามารถคุยกับบรรณารักษ์ได้ ถ้าต้องการซื้อหนังสือ (สูตรทำของต่างๆ)";
						if (143352 - 439205 == -295852)
						{
							continue;
						}
						missionClass.obj = "      ไม่มีธุระอะไรเป็นพิเศษ";
						if (288560 - 46381 != 242179)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (109063 - 182451 != -73388)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (183753 - 172364 == 11390)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (119038 - 347324 != -228286)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (109468 - 361612 != -252144)
						{
							continue;
						}
					}
					else if (c == 54)
					{
						if (270900 - 572642 != -301742)
						{
							continue;
						}
						missionClass.name = "LightCity (LightPark)";
						if (217518 - 18491 == 199028)
						{
							continue;
						}
						missionClass.mapName = "LightPark";
						if (264241 - 423457 == -159215)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)309, (float)602);
						if (154873 - 300687 != -145814)
						{
							continue;
						}
						missionClass.des = "    สวนสาธารณะใจกลางเมืองแสง นอกจาก จะเป็นที่พักผ่อนหย่อนใจ  และจัดงานเทศกาล แล้ว  เสามานาที่อยู่ในบริเวณนี้  ยังเป็นแหล่ง พลังงานที่สำคัญของเมืองอีกด้วย ส่วนที่ศาลา กลางน้ำก็มีเครื่องเทเลพอร์ต  ที่เชื่อมต่อกับวัง ของเทพแสงโดยตรง";
						if (147425 - 444237 == -296811)
						{
							continue;
						}
						missionClass.obj = "    ไม่มีธุระอะไรเป็นพิเศษ";
						if (217035 - 397600 == -180564)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (254411 - 451456 == -197044)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (115967 - 271804 == -155836)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (17521 - 466523 == -449001)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (177162 - 10599 == 166564)
						{
							continue;
						}
					}
					else if (c == 55)
					{
						if (173685 - 254772 != -81087)
						{
							continue;
						}
						missionClass.name = "Alcacia Palace";
						if (28948 - 142820 == -113871)
						{
							continue;
						}
						missionClass.mapName = "Alcacia Palace";
						if (178474 - 72538 != 105936)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)313, (float)594);
						if (176230 - 257765 == -81534)
						{
							continue;
						}
						missionClass.des = "    พระราชวังลอยฟ้าของเทพแสงอัลคาเซีย ผู้ เป็นเทพสูงสุดที่ปกครองเหล่าสัตว์อย่างสันติมา ตลอดระยะเวลาหลายร้อยปี อัลคาเซียเป็นเทพ ที่ฉลาด ใจดี รักความยุติธรรมจึงเป็นที่รักและ เคารพของเหล่าสัตว์เสมอมา";
						if (298358 - 284176 != 14182)
						{
							continue;
						}
						missionClass.obj = "    ไม่มีธุระอะไรเป็นพิเศษ";
						if (275525 - 520547 != -245022)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (95230 - 202205 == -106974)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (249059 - 372702 == -123642)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (65412 - 519285 != -453873)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (10453 - 420769 == -410315)
						{
							continue;
						}
					}
					else if (c == 56)
					{
						if (214337 - 533232 == -318894)
						{
							continue;
						}
						missionClass.name = "Plain Colosseum";
						if (80454 - 468336 == -387881)
						{
							continue;
						}
						missionClass.mapName = "Plain Colosseum";
						if (104851 - 89761 == 15091)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)371, (float)742);
						if (170938 - 4019 == 166920)
						{
							continue;
						}
						missionClass.des = "     โคลอสเซียม สนามประลองเก่าแก่ที่ตั้งอยู่ ในอาณาเขตที่ราบแห่งแสง ถูกคงสภาพเดิมไว้ เพื่อรักษาอารยธรรมของเหล่าสัตว์โบราณใน ยุคบุกเบิก ปัจจุบันใช้เป็นที่จัดการแข่งขันต่อสู้ และกีฬาต่างๆ";
						if (29608 - 283096 == -253487)
						{
							continue;
						}
						missionClass.obj = "     ไม่มีธุระอะไรเป็นพิเศษ";
						if (102706 - 258513 != -155807)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (163243 - 598335 == -435091)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (241718 - 106413 != 135305)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (296519 - 44558 != 251961)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (232690 - 18609 == 214082)
						{
							continue;
						}
					}
					else if (c == 57)
					{
						if (257400 - 368211 == -110810)
						{
							continue;
						}
						missionClass.name = "LightTheater";
						if (195390 - 194987 == 404)
						{
							continue;
						}
						missionClass.mapName = "LightTheater";
						if (88837 - 115440 == -26602)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)304, (float)614);
						if (239357 - 566190 != -326833)
						{
							continue;
						}
						missionClass.des = "    ???";
						if (110123 - 344033 != -233910)
						{
							continue;
						}
						missionClass.obj = "    ไม่มีธุระอะไรเป็นพิเศษ";
						if (91699 - 497048 != -405349)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (36155 - 412214 == -376058)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (93167 - 302380 != -209213)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (1331 - 173564 == -172232)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (185321 - 320156 != -134835)
						{
							continue;
						}
					}
					else if (c == 100)
					{
						if (23613 - 402743 != -379130)
						{
							continue;
						}
						missionClass.name = "Tutorial";
						if (287662 - 493399 != -205737)
						{
							continue;
						}
						missionClass.mapName = "Plain Colosseum";
						if (100905 - 236647 != -135742)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)371, (float)742);
						if (232837 - 169918 != 62919)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (236798 - 331041 != -94243)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (261005 - 372727 == -111721)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (41389 - 117064 != -75675)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (222193 - 40868 != 181325)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (270493 - 329453 != -58960)
						{
							continue;
						}
						missionClass.des = string.Empty;
						if (220156 - 479129 != -258973)
						{
							continue;
						}
						missionClass.obj = string.Empty;
						if (168159 - 513981 != -345822)
						{
							continue;
						}
					}
					else if (c == 101)
					{
						if (142608 - 35215 == 107394)
						{
							continue;
						}
						missionClass.name = "Carron farm's harvest";
						if (158952 - 273643 != -114691)
						{
							continue;
						}
						missionClass.des = "    ถึงฤดูเก็บเกี่ยวแล้ว คุณแพะต้องการคนมาช่วย เก็บเกี่ยวแครอน ก่อนที่มันจะวิ่งหนีไปหมด";
						if (214770 - 104399 == 110372)
						{
							continue;
						}
						missionClass.obj = "    จัดการแครอน 12 ตัว แล้วคุยกับคุณแพะโกทัน";
						if (235102 - 200573 == 34530)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (78014 - 294874 == -216859)
						{
							continue;
						}
						missionClass.lv = 1;
						if (107401 - 330808 != -223407)
						{
							continue;
						}
						missionClass.slv = 1;
						if (106772 - 118390 == -11617)
						{
							continue;
						}
						missionClass.player = 3;
						if (275069 - 204469 != 70600)
						{
							continue;
						}
						missionClass.team = 1;
						if (261934 - 587088 == -325153)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (121729 - 366824 == -245094)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (30022 - 291440 != -261418)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (59789 - 508970 != -449181)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (177466 - 333687 == -156220)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (296454 - 545074 == -248619)
						{
							continue;
						}
						missionClass.mapName = "Carron Farm";
						if (256900 - 553089 != -296189)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)198, (float)652);
						if (10389 - 49343 != -38954)
						{
							continue;
						}
					}
					else if (c == 102)
					{
						if (115572 - 317900 == -202327)
						{
							continue;
						}
						missionClass.name = "Mupo Round Up";
						if (50527 - 413967 != -363440)
						{
							continue;
						}
						missionClass.des = "   ฟาร์มของคุณนกฮูกกำลังต้องการคนช่วยต้อนมูโป้ แต่เบาๆมือกันหน่อย ระวังอย่าให้มูโป้เจ็บตัวล่ะ";
						if (255941 - 70741 == 185201)
						{
							continue;
						}
						missionClass.obj = "   ต้อนมูโป้หกตัวเข้าคอกโดยอย่าให้มูโป้ตาย";
						if (280434 - 36920 != 243514)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (250701 - 200633 == 50069)
						{
							continue;
						}
						missionClass.lv = 2;
						if (86713 - 547433 == -460719)
						{
							continue;
						}
						missionClass.slv = 2;
						if (105252 - 542981 == -437728)
						{
							continue;
						}
						missionClass.player = 3;
						if (220681 - 230759 != -10078)
						{
							continue;
						}
						missionClass.team = 1;
						if (281659 - 469784 != -188125)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (202173 - 356114 == -153940)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (157159 - 187 != 156972)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (206183 - 579243 == -373059)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (267920 - 464537 == -196616)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (64817 - 493817 == -428999)
						{
							continue;
						}
						missionClass.mapName = "Mupo Farm";
						if (94757 - 64660 != 30097)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)431, (float)628);
						if (269234 - 201401 == 67834)
						{
							continue;
						}
					}
					else if (c == 103)
					{
						if (282817 - 556730 != -273913)
						{
							continue;
						}
						missionClass.name = "Bugs trouble";
						if (285051 - 414018 != -128967)
						{
							continue;
						}
						missionClass.des = "   พวกแมลงมาป่วนกันจนเต็มแครอนฟาร์มไปหมด ใครก็ได้ไปช่วยพวกแครอนหน่อย";
						if (175272 - 346643 == -171370)
						{
							continue;
						}
						missionClass.obj = "    จัดการสติงบั๊ก 13 ตัวก่อนที่แครอนทั้งหมดหรือคุณแพะโกทันจะตาย";
						if (205404 - 445101 == -239696)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (86340 - 516382 == -430041)
						{
							continue;
						}
						missionClass.lv = 3;
						if (158478 - 387071 == -228592)
						{
							continue;
						}
						missionClass.slv = 3;
						if (214756 - 490810 != -276054)
						{
							continue;
						}
						missionClass.player = 3;
						if (44902 - 304247 == -259344)
						{
							continue;
						}
						missionClass.team = 1;
						if (175421 - 138419 == 37003)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (260814 - 450616 != -189802)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (118084 - 463560 != -345476)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (3036 - 281302 == -278265)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (66614 - 301645 != -235031)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (193221 - 215761 != -22540)
						{
							continue;
						}
						missionClass.mapName = "Carron Farm";
						if (204759 - 11108 == 193652)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)198, (float)652);
						if (46463 - 214286 == -167822)
						{
							continue;
						}
					}
					else if (c == 104)
					{
						if (273336 - 597326 != -323990)
						{
							continue;
						}
						missionClass.name = "StingBug Nest";
						if (187209 - 331852 != -144643)
						{
							continue;
						}
						missionClass.des = "  ในที่สุดก็พบรังของพวกสติงบั๊กแล้ว แต่ใครล่ะจะเข้า ไปจัดการ";
						if (25400 - 333731 != -308331)
						{
							continue;
						}
						missionClass.obj = "    ทำลายรังของสติงบั๊กให้หมด";
						if (255152 - 401298 != -146146)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (2964 - 29709 == -26744)
						{
							continue;
						}
						missionClass.lv = 4;
						if (229716 - 589093 == -359376)
						{
							continue;
						}
						missionClass.slv = 4;
						if (259168 - 98669 != 160499)
						{
							continue;
						}
						missionClass.player = 4;
						if (294617 - 240149 == 54469)
						{
							continue;
						}
						missionClass.team = 1;
						if (96043 - 551105 != -455062)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (184374 - 250564 == -66189)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (221380 - 326212 != -104832)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (225471 - 128586 != 96885)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (291770 - 4040 != 287730)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (187191 - 424182 != -236991)
						{
							continue;
						}
						missionClass.mapName = "Sting Wood";
						if (197833 - 494568 == -296734)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)194, (float)573);
						if (231254 - 542049 != -310795)
						{
							continue;
						}
					}
					else if (c == 105)
					{
						if (187847 - 502447 == -314599)
						{
							continue;
						}
						missionClass.name = "Needle Cave";
						if (198778 - 246366 == -47587)
						{
							continue;
						}
						missionClass.des = "    เจ้าแมวน้อยแอบไปเล่นซ่อนหา แล้วหายไปในถ้ำ ของนีดเดิ้ลบั๊ก จนป่านนี้ยังไม่กลับมาเลย ใครช่วยไป ตามหาที";
						if (215895 - 561384 != -345489)
						{
							continue;
						}
						missionClass.obj = "   ตามหาแมวน้อยในถ้ำให้เจอ";
						if (14770 - 256029 == -241258)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (72590 - 534611 != -462021)
						{
							continue;
						}
						missionClass.lv = 5;
						if (233832 - 279655 == -45822)
						{
							continue;
						}
						missionClass.slv = 5;
						if (71128 - 412809 == -341680)
						{
							continue;
						}
						missionClass.player = 2;
						if (119657 - 474786 == -355128)
						{
							continue;
						}
						missionClass.team = 1;
						if (90460 - 577994 == -487533)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (189863 - 238455 != -48592)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (218970 - 136660 == 82311)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (185867 - 570336 != -384469)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (184648 - 510934 != -326286)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (11344 - 66549 != -55205)
						{
							continue;
						}
						missionClass.mapName = "Needle Cave";
						if (46923 - 196479 == -149555)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)113, (float)581);
						if (111419 - 82512 == 28908)
						{
							continue;
						}
					}
					else if (c == 106)
					{
						if (110311 - 379443 != -269132)
						{
							continue;
						}
						missionClass.name = "Boldas' Recruitment";
						if (150284 - 490377 == -340092)
						{
							continue;
						}
						missionClass.des = "   แม่ทัพโบลดาสกำลังทำการคัดเลือกเหล่าผู้กล้าอยู่ พวกเธอกล้าพอมั้ยล่ะ!";
						if (150095 - 564420 == -414324)
						{
							continue;
						}
						missionClass.obj = "    ทำให้โบลดาสล้มให้ได้สามครั้ง";
						if (227619 - 534748 != -307129)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (257778 - 583562 != -325784)
						{
							continue;
						}
						missionClass.lv = 6;
						if (210054 - 405932 == -195877)
						{
							continue;
						}
						missionClass.slv = 6;
						if (32743 - 191854 != -159111)
						{
							continue;
						}
						missionClass.player = 3;
						if (244820 - 182125 == 62696)
						{
							continue;
						}
						missionClass.team = 1;
						if (219232 - 87803 != 131429)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (211563 - 337624 != -126061)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (118119 - 351942 == -233822)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (2910 - 138423 == -135512)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (234304 - 59791 != 174513)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (157031 - 466059 == -309027)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (18704 - 275836 != -257132)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (107858 - 594360 == -486501)
						{
							continue;
						}
					}
					else if (c == 107)
					{
						if (222102 - 416049 == -193946)
						{
							continue;
						}
						missionClass.name = "Request from Alcacia";
						if (258755 - 209120 != 49635)
						{
							continue;
						}
						missionClass.des = "   เทพแสงอัลคาเซีย เรียกตัวเหล่าผู้กล้าที่ได้รับการ คัดเลือกจากโบลดาสไปพบบนวังแห่งแสง เพื่อมอบ ภารกิจที่จะเปลี่ยนชะตาของโลกให้... \n   เหล่าผู้กล้าจะทำสำเร็จมั้ยนะ?";
						if (9361 - 425833 != -416472)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (87407 - 386320 == -298912)
						{
							continue;
						}
						missionClass.lv = 0;
						if (247778 - 102313 != 145465)
						{
							continue;
						}
						missionClass.slv = 7;
						if (204521 - 593319 == -388797)
						{
							continue;
						}
						missionClass.player = 1;
						if (22711 - 337371 != -314660)
						{
							continue;
						}
						missionClass.team = 1;
						if (296702 - 537952 == -241249)
						{
							continue;
						}
						missionClass.mapName = "Alcacia Palace";
						if (187879 - 76104 != 111775)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)317, (float)588);
						if (231952 - 569242 != -337290)
						{
							continue;
						}
					}
					else if (c == 108)
					{
						if (285769 - 154642 == 131128)
						{
							continue;
						}
						missionClass.name = "One on One Bout";
						if (240079 - 537361 != -297282)
						{
							continue;
						}
						missionClass.des = "   สนามประลอง 1ต่อ1 สำหรับเหล่าผู้กล้าฝึกหัด";
						if (120029 - 211868 == -91838)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (6676 - 10286 != -3610)
						{
							continue;
						}
						missionClass.lv = 0;
						if (80709 - 500226 == -419516)
						{
							continue;
						}
						missionClass.slv = 8;
						if (204127 - 41651 != 162476)
						{
							continue;
						}
						missionClass.player = 2;
						if (296710 - 494476 != -197766)
						{
							continue;
						}
						missionClass.team = 2;
						if (48248 - 222571 != -174323)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (45369 - 260656 == -215286)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (42775 - 436358 != -393583)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (147583 - 211639 == -64055)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (261428 - 82081 != 179347)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (28866 - 244840 == -215973)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)240, (float)698);
						if (250061 - 455353 == -205291)
						{
							continue;
						}
					}
					else if (c == 201)
					{
						if (67808 - 590079 == -522270)
						{
							continue;
						}
						missionClass.name = "Mupo Farm Watch";
						if (60894 - 557139 == -496244)
						{
							continue;
						}
						missionClass.des = "    คืนก่อนที่เหล่าผู้กล้าจะออกเดินทาง ฟาร์มมูโป้ก็ เจอปัญหาเข้าอีกแล้ว  มีจดหมายขู่ลึกลับส่งมาถึงเจ้า ของฟาร์มว่าจะมีการปล้นครั้งใหญ่เกิดขึ้นในคืนนี้";
						if (226348 - 164749 == 61600)
						{
							continue;
						}
						missionClass.obj = "    จัดการปราบพวกหัวขโมยมูโป้ให้หมด โดยระวัง อย่าให้มูโป้บาดเจ็บ";
						if (216948 - 182217 == 34732)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (196574 - 51693 == 144882)
						{
							continue;
						}
						missionClass.lv = 7;
						if (286489 - 376777 != -90288)
						{
							continue;
						}
						missionClass.slv = 8;
						if (65945 - 19459 != 46486)
						{
							continue;
						}
						missionClass.player = 3;
						if (165549 - 310567 != -145018)
						{
							continue;
						}
						missionClass.team = 1;
						if (9678 - 381849 != -372171)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (286789 - 554280 == -267490)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (131154 - 176031 == -44876)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (75049 - 278865 == -203815)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (42930 - 118839 != -75909)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (282247 - 467242 != -184995)
						{
							continue;
						}
						missionClass.mapName = "Mupo Farm";
						if (64777 - 20941 == 43837)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)431, (float)628);
						if (148921 - 296044 == -147122)
						{
							continue;
						}
					}
					else if (c == 202)
					{
						if (28655 - 459506 == -430850)
						{
							continue;
						}
						missionClass.name = "Run Mupo Run";
						if (294793 - 293625 != 1168)
						{
							continue;
						}
						missionClass.des = "    พ่อค้า Xinfu ให้เหล่าผู้กล้ายืมมูโป้ เพื่อขี่ไปถึงชายอานาเขตของอาณาจักรเมืองแสง แต่ระวังอย่าให้มูโป้บาดเจ็บล่ะ";
						if (2650 - 332443 != -329793)
						{
							continue;
						}
						missionClass.obj = "    ขี่มูโป้ไปให้ถึงปลายทาง และอย่าให้มูโป้บาดเจ็บหรือล้มระหว่างทาง";
						if (137771 - 225562 != -87791)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (19857 - 527386 == -507528)
						{
							continue;
						}
						missionClass.lv = 8;
						if (31274 - 310073 == -278798)
						{
							continue;
						}
						missionClass.slv = 9;
						if (134538 - 547728 == -413189)
						{
							continue;
						}
						missionClass.player = 3;
						if (162390 - 325556 == -163165)
						{
							continue;
						}
						missionClass.team = 1;
						if (6390 - 64623 != -58233)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (114587 - 587123 != -472536)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (73174 - 228205 == -155030)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (174913 - 82398 != 92515)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (165809 - 24343 != 141466)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (172402 - 569212 == -396809)
						{
							continue;
						}
						missionClass.mapName = "Light Plain";
						if (223750 - 454914 != -231164)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)395, (float)581);
						if (9229 - 452992 != -443763)
						{
							continue;
						}
					}
					else if (c == 203)
					{
						if (145332 - 285772 != -140440)
						{
							continue;
						}
						missionClass.name = "Start of a Long Journey";
						if (148883 - 77968 != 70915)
						{
							continue;
						}
						missionClass.des = "    ทุกการผจญภัยเริ่มจากก้าวๆแรก การเดินทางของ เหล่าผู้กล้าเริ่มต้นขึ้นแล้ว";
						if (87642 - 250976 == -163333)
						{
							continue;
						}
						missionClass.obj = "    ไปให้ถึงจุดหมายปลายทาง";
						if (169237 - 354630 == -185392)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (129380 - 402365 == -272984)
						{
							continue;
						}
						missionClass.lv = 9;
						if (144887 - 95741 == 49147)
						{
							continue;
						}
						missionClass.slv = 10;
						if (169696 - 565098 != -395402)
						{
							continue;
						}
						missionClass.player = 3;
						if (238504 - 111283 == 127222)
						{
							continue;
						}
						missionClass.team = 1;
						if (14408 - 578617 == -564208)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (242205 - 370966 == -128760)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (105436 - 530271 == -424834)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (244244 - 153334 == 90911)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (244198 - 223298 == 20901)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (111149 - 370453 == -259303)
						{
							continue;
						}
						missionClass.mapName = "Light Plain";
						if (218226 - 105820 != 112406)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)395, (float)581);
						if (240295 - 422762 != -182467)
						{
							continue;
						}
					}
					else if (c == 204)
					{
						if (93646 - 547637 != -453991)
						{
							continue;
						}
						missionClass.name = "Highway Robbery";
						if (37862 - 85150 == -47287)
						{
							continue;
						}
						missionClass.des = "    แถบชายป่าเต็มไปด้วยฝูงนินจาบั๊กที่ชอบแอบดัก ปล้นตามทาง ระวังอย่าเดินทางคนเดียว";
						if (145056 - 82919 != 62137)
						{
							continue;
						}
						missionClass.obj = "    จัดการกับนินจาบั๊กทั้งหมด";
						if (217429 - 592706 != -375277)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (6570 - 553602 != -547032)
						{
							continue;
						}
						missionClass.lv = 10;
						if (33914 - 455060 == -421145)
						{
							continue;
						}
						missionClass.slv = 11;
						if (187605 - 135929 != 51676)
						{
							continue;
						}
						missionClass.player = 4;
						if (249473 - 480061 != -230588)
						{
							continue;
						}
						missionClass.team = 1;
						if (218422 - 291131 == -72708)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (267205 - 166891 == 100315)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (264413 - 63947 != 200466)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (15298 - 594994 != -579696)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (255520 - 433434 != -177914)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (222888 - 148638 != 74250)
						{
							continue;
						}
						missionClass.mapName = "Light Plain";
						if (66452 - 45460 != 20992)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)397, (float)542);
						if (2170 - 366803 == -364632)
						{
							continue;
						}
					}
					else if (c == 205)
					{
						if (280428 - 145704 != 134724)
						{
							continue;
						}
						missionClass.name = "Crossing Plain Lagoon";
						if (133795 - 582049 != -448254)
						{
							continue;
						}
						missionClass.des = "     พวกสัตว์มาหยุดพักกันที่หนองน้ำกลางป่าที่สงบ และร่มรื่น แต่ไม่ทันไรก็มีเจ้าพวกตัวอันตรายเข้ามา ก่อกวน";
						if (155426 - 393974 != -238548)
						{
							continue;
						}
						missionClass.obj = "    ไปให้ถึงจุดหมายปลายทาง";
						if (189913 - 107579 != 82334)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (189298 - 283501 == -94202)
						{
							continue;
						}
						missionClass.lv = 11;
						if (83345 - 379172 == -295826)
						{
							continue;
						}
						missionClass.slv = 12;
						if (182318 - 86452 == 95867)
						{
							continue;
						}
						missionClass.player = 3;
						if (112543 - 214462 != -101919)
						{
							continue;
						}
						missionClass.team = 1;
						if (157754 - 402955 == -245200)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (12664 - 293556 != -280892)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (286483 - 323967 != -37484)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (97360 - 65925 != 31435)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (8274 - 565137 == -556862)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (84578 - 118698 != -34120)
						{
							continue;
						}
						missionClass.mapName = "Plain Lagoon";
						if (264414 - 473800 != -209386)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)400, (float)560);
						if (100465 - 387242 != -286777)
						{
							continue;
						}
					}
					else if (c == 206)
					{
						if (96710 - 521080 == -424369)
						{
							continue;
						}
						missionClass.name = "Grand Theft Mupo";
						if (209665 - 504079 != -294414)
						{
							continue;
						}
						missionClass.des = "    ระหว่างเดินป่า อยู่ๆก็พบมูโป้ที่กำลังถูกเจ้าหนอน ยักษ์เล่นงาน รีบเข้าไปช่วยเร็ว! (แต่ทว่านั่นใครติดมา ด้วยเนี่ย?)";
						if (213365 - 200248 != 13117)
						{
							continue;
						}
						missionClass.obj = "     จัดการกับหนอนยักษ์และช่วยมูโป้ให้ได้ก่อนที่มันจะหนีไป";
						if (243681 - 549403 == -305721)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (59961 - 288511 == -228549)
						{
							continue;
						}
						missionClass.lv = 12;
						if (43002 - 157178 != -114176)
						{
							continue;
						}
						missionClass.slv = 13;
						if (221704 - 21275 != 200429)
						{
							continue;
						}
						missionClass.player = 3;
						if (197284 - 347498 != -150214)
						{
							continue;
						}
						missionClass.team = 1;
						if (162020 - 557980 == -395959)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (226363 - 215593 == 10771)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (191538 - 107070 == 84469)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (128913 - 215803 != -86890)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (164348 - 562087 == -397738)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (190364 - 517464 == -327099)
						{
							continue;
						}
						missionClass.mapName = "Forked Wood";
						if (34612 - 116913 != -82301)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)524);
						if (76974 - 52025 != 24949)
						{
							continue;
						}
					}
					else if (c == 207)
					{
						if (226279 - 588859 == -362579)
						{
							continue;
						}
						missionClass.name = "Troubling Giant";
						if (82944 - 138416 == -55471)
						{
							continue;
						}
						missionClass.des = "      แปลกจริง.... ทำไมอยู่ๆเทพดินถึงได้เดินร่อนเร่เข้า มาในอาณาเขตของเทพไฟ? จะมีเรื่องอะไรร้ายแรงเกิด ขึ้นหลังจากนี้รึเปล่านะ?";
						if (84767 - 119182 == -34414)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (228287 - 88354 == 139934)
						{
							continue;
						}
						missionClass.lv = 0;
						if (279950 - 216762 != 63188)
						{
							continue;
						}
						missionClass.slv = 14;
						if (168082 - 154216 != 13866)
						{
							continue;
						}
						missionClass.player = 1;
						if (46466 - 513851 != -467385)
						{
							continue;
						}
						missionClass.team = 1;
						if (298746 - 559805 != -261059)
						{
							continue;
						}
						missionClass.mapName = "Forked Wood";
						if (156901 - 27898 != 129003)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)524);
						if (158768 - 72329 == 86440)
						{
							continue;
						}
					}
					else if (c == 208)
					{
						if (186994 - 461641 == -274646)
						{
							continue;
						}
						missionClass.name = "Double Duel";
						if (145451 - 261885 == -116433)
						{
							continue;
						}
						missionClass.des = "  มิชชั่นพิเศษ สู้แบบทีม 2ต่อ2";
						if (162619 - 11391 == 151229)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (159990 - 90093 != 69897)
						{
							continue;
						}
						missionClass.lv = 0;
						if (189909 - 58390 != 131519)
						{
							continue;
						}
						missionClass.slv = 15;
						if (75758 - 339531 != -263773)
						{
							continue;
						}
						missionClass.player = 4;
						if (216959 - 500040 != -283081)
						{
							continue;
						}
						missionClass.team = 2;
						if (211614 - 41989 != 169625)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (196423 - 329041 == -132617)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (214350 - 588786 != -374436)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (221236 - 168529 == 52708)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (80408 - 429245 == -348836)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (284481 - 218250 != 66231)
						{
							continue;
						}
						missionClass.mapName = "Forked Wood";
						if (283651 - 33917 != 249734)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)524);
						if (252515 - 153024 != 99491)
						{
							continue;
						}
					}
					else if (c == 301)
					{
						if (264973 - 531639 != -266666)
						{
							continue;
						}
						missionClass.name = "Frozen Peppon";
						if (104539 - 210130 != -105591)
						{
							continue;
						}
						missionClass.des = "  ก่อนจะไปให้ถึงถ้ำของเทพไฟ ก็ต้องผ่านดินแดนหิมะ ที่หนาวเหน็บซะก่อน อ้าว? นั่นตัวอะไรโดนแช่แข็งอยู่ บนทะเลสาบล่ะเนี่ย?";
						if (138387 - 315792 == -177404)
						{
							continue;
						}
						missionClass.obj = "   ช่วยเจ้าพริกหยวกเป็บปอน  โดยทำลายตุ๊กตาหิมะ ทั้งหมด 14 ตัว แล้วคุยกับคุณจิงโจ้ อย่าเผลอทำร้ายเจ้าเป็ปปอนล่ะ";
						if (265976 - 104367 != 161609)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (29385 - 153239 == -123853)
						{
							continue;
						}
						missionClass.lv = 13;
						if (277725 - 261639 == 16087)
						{
							continue;
						}
						missionClass.slv = 15;
						if (200317 - 427416 == -227098)
						{
							continue;
						}
						missionClass.player = 2;
						if (116801 - 427517 != -310716)
						{
							continue;
						}
						missionClass.team = 1;
						if (99026 - 244620 != -145594)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (263478 - 413013 != -149535)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (182345 - 497196 == -314850)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (199563 - 595714 != -396151)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (57140 - 451011 == -393870)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (234777 - 548535 == -313757)
						{
							continue;
						}
						missionClass.mapName = "Frozen Lake";
						if (222571 - 477985 == -255413)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)334, (float)374);
						if (101276 - 315968 == -214691)
						{
							continue;
						}
					}
					else if (c == 302)
					{
						if (106556 - 262451 != -155895)
						{
							continue;
						}
						missionClass.name = "Snow Pine Forest";
						if (81886 - 269241 == -187354)
						{
							continue;
						}
						missionClass.des = "  ป่าสนหิมะแถบนี้กำลังย่ำแย่ เพราะพวกแมลงต้นสน ที่ชอบกัดกินต้นไม้เกิดเพิ่มจำนวนขึ้นมากเกินไป";
						if (81902 - 8862 != 73040)
						{
							continue;
						}
						missionClass.obj = "   กำจัดแมลงต้นสนให้ได้ทั้งหมด 7 ตัว";
						if (7169 - 216935 == -209765)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (161590 - 295646 == -134055)
						{
							continue;
						}
						missionClass.lv = 14;
						if (139303 - 526238 == -386934)
						{
							continue;
						}
						missionClass.slv = 16;
						if (114063 - 556191 != -442128)
						{
							continue;
						}
						missionClass.player = 4;
						if (16823 - 456577 == -439753)
						{
							continue;
						}
						missionClass.team = 1;
						if (262437 - 18821 == 243617)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (265269 - 409810 != -144541)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (62192 - 145413 != -83221)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (257899 - 284374 == -26474)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (68946 - 263550 == -194603)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (280298 - 283382 != -3084)
						{
							continue;
						}
						missionClass.mapName = "Snow Pine Forest";
						if (253517 - 426866 != -173349)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)363, (float)340);
						if (53340 - 208184 != -154844)
						{
							continue;
						}
					}
					else if (c == 303)
					{
						if (158139 - 336223 != -178084)
						{
							continue;
						}
						missionClass.name = "Snow Pass";
						if (91932 - 207568 == -115635)
						{
							continue;
						}
						missionClass.des = "   โบลดาสกำลังต้องการคนช่วยไปเปิดเสามานา บนภูเขาหิมะที่ดับไปเพราะพวกแมลง";
						if (42613 - 568317 == -525703)
						{
							continue;
						}
						missionClass.obj = "   เปิดเสามานา 4 เสาแล้วคุยกับโบลดาส";
						if (212174 - 277031 == -64856)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (167681 - 175847 == -8165)
						{
							continue;
						}
						missionClass.lv = 15;
						if (163205 - 414639 != -251434)
						{
							continue;
						}
						missionClass.slv = 17;
						if (114758 - 487151 != -372393)
						{
							continue;
						}
						missionClass.player = 4;
						if (266570 - 546368 == -279797)
						{
							continue;
						}
						missionClass.team = 1;
						if (288672 - 517905 != -229233)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (119886 - 139920 != -20034)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (202415 - 393546 == -191130)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (255517 - 388755 == -133237)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (37900 - 405123 == -367222)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (74736 - 388127 != -313391)
						{
							continue;
						}
						missionClass.mapName = "Snow Mountain";
						if (66674 - 123813 != -57139)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)305, (float)305);
						if (281080 - 596152 == -315071)
						{
							continue;
						}
					}
					else if (c == 304)
					{
						if (168958 - 396268 == -227309)
						{
							continue;
						}
						missionClass.name = "Samurai Fort";
						if (207963 - 179500 != 28463)
						{
							continue;
						}
						missionClass.des = "   ทางไปภูเขาเทพไฟโดนพวกแมลงทำเป็นป้อมปรา- การไปซะนี่ แล้วพวกผู้กล้าจะผ่านไปยังไงดีล่ะ";
						if (196845 - 388821 == -191975)
						{
							continue;
						}
						missionClass.obj = "   ฝ่าด่านเหล่าซามูไรบั๊กไปให้ถึงปลายทาง";
						if (232271 - 406721 == -174449)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (19110 - 271234 == -252123)
						{
							continue;
						}
						missionClass.lv = 16;
						if (110984 - 139838 != -28854)
						{
							continue;
						}
						missionClass.slv = 18;
						if (56316 - 469617 != -413301)
						{
							continue;
						}
						missionClass.player = 3;
						if (25505 - 204520 != -179015)
						{
							continue;
						}
						missionClass.team = 1;
						if (120671 - 261531 == -140859)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (36824 - 449690 == -412865)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (196924 - 497728 == -300803)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (188699 - 218552 != -29853)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (246421 - 216525 == 29897)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (177608 - 285036 != -107428)
						{
							continue;
						}
						missionClass.mapName = "Snow Pine Forest";
						if (247141 - 144669 == 102473)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)363, (float)340);
						if (285175 - 18411 != 266764)
						{
							continue;
						}
					}
					else if (c == 305)
					{
						if (90604 - 271142 != -180538)
						{
							continue;
						}
						missionClass.name = "Italus' Acceptance";
						if (257902 - 55200 != 202702)
						{
							continue;
						}
						missionClass.des = "   อิทารุสดักรอเหล่าผู้กล้าอยู่บนเส้นทางสู่ถ้ำเทพไฟ ผู้กล้าจะผ่านการทดสอบนี้ได้มั้ยนะ";
						if (245913 - 339044 == -93130)
						{
							continue;
						}
						missionClass.obj = "   เอาตัวรอดจากการทดสอบของอิทารุสให้ได้ภายในระยะเวลา 3 นาที";
						if (63808 - 81283 != -17475)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (126954 - 455716 != -328762)
						{
							continue;
						}
						missionClass.lv = 17;
						if (194900 - 240701 != -45801)
						{
							continue;
						}
						missionClass.slv = 19;
						if (99455 - 277106 == -177650)
						{
							continue;
						}
						missionClass.player = 3;
						if (136706 - 495773 != -359067)
						{
							continue;
						}
						missionClass.team = 1;
						if (178951 - 494279 == -315327)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (193800 - 373304 == -179503)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (76628 - 543168 == -466539)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (20156 - 183036 == -162879)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (223179 - 122108 != 101071)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (76799 - 261103 != -184304)
						{
							continue;
						}
						missionClass.mapName = "Snow Mountain";
						if (290194 - 597704 != -307510)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)305, (float)305);
						if (277959 - 50472 != 227487)
						{
							continue;
						}
					}
					else if (c == 306)
					{
						if (2590 - 243310 != -240720)
						{
							continue;
						}
						missionClass.name = "Fire Cave Entrance";
						if (193891 - 19930 == 173962)
						{
							continue;
						}
						missionClass.des = "     พวกผู้กล้าเดินทางมาจนถึงทางเข้าถ้ำเทพไฟแล้ว แต่ภายในกลับเจอแมลงร๊อคบั๊กที่ดุร้าย เข้าขวางทาง";
						if (212103 - 421577 == -209473)
						{
							continue;
						}
						missionClass.obj = "   ฝ่าเข้าไปพบเทพไฟ โดยปราบร๊อคบั๊ก 3 ตัวที่ขวางทางอยู่ให้ได้";
						if (218970 - 589548 != -370578)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (123958 - 12406 != 111552)
						{
							continue;
						}
						missionClass.lv = 18;
						if (1379 - 190813 != -189434)
						{
							continue;
						}
						missionClass.slv = 20;
						if (206989 - 511189 == -304199)
						{
							continue;
						}
						missionClass.player = 4;
						if (12230 - 413808 != -401578)
						{
							continue;
						}
						missionClass.team = 1;
						if (8549 - 267002 != -258453)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (122979 - 120413 != 2566)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (136117 - 352272 == -216154)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (161642 - 464571 != -302929)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (77051 - 420728 == -343676)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (4511 - 154900 != -150389)
						{
							continue;
						}
						missionClass.mapName = "Fire Cave";
						if (285667 - 140750 != 144917)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)258, (float)333);
						if (135343 - 390866 != -255523)
						{
							continue;
						}
					}
					else if (c == 307)
					{
						if (39483 - 381294 != -341811)
						{
							continue;
						}
						missionClass.name = "Fire Throne";
						if (208049 - 65427 == 142623)
						{
							continue;
						}
						missionClass.des = "     หลังจากเดินทางฝ่าพายุหิมะ ผ่านความร้อนระอุ ของถ้ำลาวา ในที่สุดพวกผู้กล้าก็เข้ามาถึงบัลลังก์ของ เทพไฟ  ซึ่งเป็นเทพที่ขึ้นชื่อเรื่องความเก่งกาจในการ สู้รบ แต่ใจร้อนและแข็งกร้าว... \n     เทพไฟจะมีคำตอบอย่างไรกันนะ?";
						if (243154 - 128133 != 115021)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (191402 - 307372 == -115969)
						{
							continue;
						}
						missionClass.lv = 0;
						if (164331 - 330614 != -166283)
						{
							continue;
						}
						missionClass.slv = 21;
						if (101328 - 30585 == 70744)
						{
							continue;
						}
						missionClass.player = 1;
						if (264183 - 28847 != 235336)
						{
							continue;
						}
						missionClass.team = 1;
						if (266452 - 291107 == -24654)
						{
							continue;
						}
						missionClass.mapName = "Fire Cave";
						if (283532 - 544522 == -260989)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)258, (float)333);
						if (9071 - 231778 == -222706)
						{
							continue;
						}
					}
					else if (c == 308)
					{
						if (36258 - 581181 == -544922)
						{
							continue;
						}
						missionClass.name = "Triple Trouble";
						if (52829 - 425956 != -373127)
						{
							continue;
						}
						missionClass.des = "  มิชชั่นพิเศษ สู้แบบทีม 3ต่อ3";
						if (105630 - 490543 != -384913)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (230980 - 313957 != -82977)
						{
							continue;
						}
						missionClass.lv = 0;
						if (75898 - 203963 == -128064)
						{
							continue;
						}
						missionClass.slv = 22;
						if (33218 - 290901 == -257682)
						{
							continue;
						}
						missionClass.player = 6;
						if (33454 - 462080 == -428625)
						{
							continue;
						}
						missionClass.team = 2;
						if (223201 - 450727 == -227525)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (174017 - 346272 == -172254)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (249236 - 421952 == -172715)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (14120 - 402615 != -388495)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (103501 - 113867 == -10365)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (227594 - 24544 != 203050)
						{
							continue;
						}
						missionClass.mapName = "Frozen Lake";
						if (26698 - 233247 != -206549)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)334, (float)374);
						if (14984 - 210877 != -195893)
						{
							continue;
						}
					}
					else if (c == 401)
					{
						if (28749 - 221140 == -192390)
						{
							continue;
						}
						missionClass.name = "Down from the Volcano";
						if (177725 - 482231 != -304506)
						{
							continue;
						}
						missionClass.des = "    พวกสัตว์ใช้ทางลัดหลังบัลลังก์ของเทพไฟ ผ่านถ้ำ ลาวาส่วนสุดท้าย เพื่อทะลุไปยังเขตทะเลทราย";
						if (282377 - 75162 == 207216)
						{
							continue;
						}
						missionClass.obj = "    ไปให้ถึงทางออกของถ้ำภูเขาไฟ";
						if (168672 - 479505 != -310833)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (93442 - 433995 == -340552)
						{
							continue;
						}
						missionClass.lv = 19;
						if (111450 - 574111 != -462661)
						{
							continue;
						}
						missionClass.slv = 22;
						if (141281 - 569806 == -428524)
						{
							continue;
						}
						missionClass.player = 4;
						if (210340 - 414000 != -203660)
						{
							continue;
						}
						missionClass.team = 1;
						if (271379 - 435540 != -164161)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (244211 - 398668 == -154456)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (54479 - 508447 != -453968)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (58565 - 574574 != -516009)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (169906 - 259864 == -89957)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (285656 - 318035 != -32379)
						{
							continue;
						}
						missionClass.mapName = "Fire Cave Secret  Path";
						if (230739 - 82035 != 148704)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)359, (float)400);
						if (119051 - 335988 == -216936)
						{
							continue;
						}
					}
					else if (c == 402)
					{
						if (259616 - 6248 != 253368)
						{
							continue;
						}
						missionClass.name = "Desert Path";
						if (295491 - 262883 == 32609)
						{
							continue;
						}
						missionClass.des = "   ดินแดนทะเลทรายเวิ้งว้าง กำลังรอคอยที่จะฝังร่าง นักเดินทางและพ่อค้าที่ไม่ระวังตัวอยู่";
						if (192410 - 229275 == -36864)
						{
							continue;
						}
						missionClass.obj = "   ผ่านไปให้ถึงอีกฝั่งของทะเลทราย ถ้าเจอใครกำลังประสบภัย อย่าลืมช่วยล่ะ";
						if (279510 - 486305 == -206794)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (141574 - 321986 == -180411)
						{
							continue;
						}
						missionClass.lv = 20;
						if (262265 - 513407 != -251142)
						{
							continue;
						}
						missionClass.slv = 23;
						if (83658 - 597835 == -514176)
						{
							continue;
						}
						missionClass.player = 3;
						if (296178 - 375880 == -79701)
						{
							continue;
						}
						missionClass.team = 1;
						if (42939 - 116444 != -73505)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (255497 - 516661 != -261164)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (293168 - 43497 != 249671)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (128636 - 476088 == -347451)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (247776 - 354780 != -107004)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (37839 - 337044 == -299204)
						{
							continue;
						}
						missionClass.mapName = "Gao Desert Edge";
						if (116330 - 38279 != 78051)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)513, (float)419);
						if (213147 - 568488 != -355341)
						{
							continue;
						}
					}
					else if (c == 403)
					{
						if (66958 - 362291 == -295332)
						{
							continue;
						}
						missionClass.name = "Cacton Garden";
						if (175192 - 429593 == -254400)
						{
							continue;
						}
						missionClass.des = "    เหล่าผู้กล้าเดินทางมาส่งอัลปาก้าจนถึง ฟาร์มกระบองเพชร แต่ดูเหมือนที่นั่นก็กำลัง ต้องการความช่วยเหลือ";
						if (213629 - 506397 != -292768)
						{
							continue;
						}
						missionClass.obj = "   ปราบแซนด์บั๊ก 30 ตัว โดยพยายามไม่ให้ Cacton ตาย";
						if (113775 - 429057 == -315281)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (227322 - 49372 != 177950)
						{
							continue;
						}
						missionClass.lv = 21;
						if (289971 - 555750 == -265778)
						{
							continue;
						}
						missionClass.slv = 24;
						if (105473 - 89141 == 16333)
						{
							continue;
						}
						missionClass.player = 4;
						if (148152 - 104048 == 44105)
						{
							continue;
						}
						missionClass.team = 1;
						if (236839 - 505253 == -268413)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (299573 - 542059 != -242486)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (228147 - 100890 != 127257)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (28734 - 390376 != -361642)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (82032 - 279560 != -197528)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (2089 - 166959 != -164870)
						{
							continue;
						}
						missionClass.mapName = "Gao Desert";
						if (282634 - 419176 == -136541)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)607, (float)422);
						if (105169 - 510953 == -405783)
						{
							continue;
						}
					}
					else if (c == 404)
					{
						if (43542 - 322261 != -278719)
						{
							continue;
						}
						missionClass.name = "Sand Oasis";
						if (116195 - 18313 == 97883)
						{
							continue;
						}
						missionClass.des = "   คุณอัลปาก้าวานผู้กล้าอีกเรื่องนึง เธอต้องการกระบองเพชรสีม่วงที่ขึ้นที่โอเอสิสสำหรับทำสีย้อมผ้า";
						if (94316 - 20832 == 73485)
						{
							continue;
						}
						missionClass.obj = "   ฝ่าเหล่าแมลงที่ดุร้ายเข้าไปเก็บกระบองเพชรสีม่วง 6 ต้นแล้วคุยกับอัลปาก้า";
						if (125619 - 540720 != -415101)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (169079 - 276271 != -107192)
						{
							continue;
						}
						missionClass.lv = 22;
						if (161101 - 91397 == 69705)
						{
							continue;
						}
						missionClass.slv = 25;
						if (174331 - 498836 == -324504)
						{
							continue;
						}
						missionClass.player = 3;
						if (154900 - 25124 == 129777)
						{
							continue;
						}
						missionClass.team = 1;
						if (234834 - 145925 == 88910)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (177790 - 291727 != -113937)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (71160 - 69994 == 1167)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (156057 - 267933 != -111876)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (206593 - 259822 != -53229)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (91156 - 386706 != -295550)
						{
							continue;
						}
						missionClass.mapName = "Desert Oasis";
						if (173672 - 346745 == -173072)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)662, (float)437);
						if (177070 - 359164 != -182094)
						{
							continue;
						}
					}
					else if (c == 405)
					{
						if (255305 - 305127 != -49822)
						{
							continue;
						}
						missionClass.name = "Wind Valley 1";
						if (297949 - 463080 != -165131)
						{
							continue;
						}
						missionClass.des = "   ด้วยความขอบคุณ หรือเพราะหมดธุระแล้ว? คุณอัลปาก้าจึงพาเหล่าผู้กล้ามาถึงทางเข้าของ หุบเขาสายลม เทพลมคงกำลังอยู่ที่ไหนซักแห่งในหุบเขาที่ซับซ้อนแห่งนี้";
						if (113628 - 225115 != -111487)
						{
							continue;
						}
						missionClass.obj = "   วิ่งฝ่าสายลมเข้าไปให้ถึงหุบเขาสายลม ระวังแมลงดุร้ายที่เฝ้าทางเข้าด้วย";
						if (255969 - 35061 == 220909)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (7046 - 427177 == -420130)
						{
							continue;
						}
						missionClass.lv = 23;
						if (281736 - 556379 == -274642)
						{
							continue;
						}
						missionClass.slv = 26;
						if (58282 - 339907 == -281624)
						{
							continue;
						}
						missionClass.player = 3;
						if (26744 - 584660 == -557915)
						{
							continue;
						}
						missionClass.team = 1;
						if (72290 - 449744 == -377453)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (222863 - 8273 != 214590)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (12486 - 523413 != -510927)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (251727 - 528523 != -276796)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (87513 - 551480 != -463967)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (198832 - 332928 == -134095)
						{
							continue;
						}
						missionClass.mapName = "Wind Valley";
						if (72443 - 471775 == -399331)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)612, (float)462);
						if (81763 - 569157 == -487393)
						{
							continue;
						}
					}
					else if (c == 406)
					{
						if (89986 - 81565 == 8422)
						{
							continue;
						}
						missionClass.name = "Wind Valley 2";
						if (230443 - 465864 == -235420)
						{
							continue;
						}
						missionClass.des = "    หุบเขาที่ลึกลับซับซ้อน ซ้ำยังเต็มไปด้วยเหล่าแมลง สุดโหด ทำให้การตามหาเทพลมไม่ใช่เรื่องง่ายเลย";
						if (199118 - 165610 != 33508)
						{
							continue;
						}
						missionClass.obj = "   ผ่านไปให้ถึงสวนของเทพลมให้ได้";
						if (262486 - 93140 != 169346)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (116286 - 213849 == -97562)
						{
							continue;
						}
						missionClass.lv = 24;
						if (174906 - 109578 != 65328)
						{
							continue;
						}
						missionClass.slv = 27;
						if (78240 - 522926 != -444686)
						{
							continue;
						}
						missionClass.player = 4;
						if (161528 - 501012 != -339484)
						{
							continue;
						}
						missionClass.team = 1;
						if (294221 - 451524 != -157303)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (26904 - 228657 == -201752)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (110592 - 531659 != -421067)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (17240 - 402145 != -384905)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (90328 - 562643 != -472315)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (272159 - 1294 != 270865)
						{
							continue;
						}
						missionClass.mapName = "Wind Valley";
						if (141760 - 229556 != -87796)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)616, (float)479);
						if (162977 - 179375 == -16397)
						{
							continue;
						}
					}
					else if (c == 407)
					{
						if (280346 - 593497 != -313151)
						{
							continue;
						}
						missionClass.name = "Catch the wind if you can";
						if (213750 - 330320 != -116570)
						{
							continue;
						}
						missionClass.des = "     เหล่าผู้กล้าเดินทางมาถึงที่อยู่ของเทพลมแล้ว แต่ เอ๊ะ!? เทพลมหายไปไหนแล้ว?";
						if (193789 - 90126 != 103663)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (146898 - 130305 != 16593)
						{
							continue;
						}
						missionClass.lv = 0;
						if (80001 - 549801 != -469800)
						{
							continue;
						}
						missionClass.slv = 28;
						if (241330 - 403499 == -162168)
						{
							continue;
						}
						missionClass.player = 1;
						if (57203 - 317993 != -260790)
						{
							continue;
						}
						missionClass.team = 1;
						if (176927 - 87976 == 88952)
						{
							continue;
						}
						missionClass.mapName = "Wind Valley";
						if (86712 - 30894 != 55818)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)566, (float)436);
						if (59536 - 334501 == -274964)
						{
							continue;
						}
					}
					else if (c == 408)
					{
						if (275719 - 429331 != -153612)
						{
							continue;
						}
						missionClass.name = "Desert Survival";
						if (171660 - 168564 != 3096)
						{
							continue;
						}
						missionClass.des = "  มิชชั่นพิเศษ สู้แบบเจอกันหมด 5 คน ใครจะเป็นผู้อยู่รอดคนสุดท้ายนะ ?";
						if (108035 - 38418 != 69617)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (125600 - 416818 == -291217)
						{
							continue;
						}
						missionClass.lv = 0;
						if (292954 - 591481 != -298527)
						{
							continue;
						}
						missionClass.slv = 29;
						if (53434 - 119255 != -65821)
						{
							continue;
						}
						missionClass.player = 5;
						if (120336 - 331847 == -211510)
						{
							continue;
						}
						missionClass.team = 5;
						if (257794 - 459340 != -201546)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (130007 - 197722 != -67715)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (45999 - 480671 == -434671)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (130876 - 180893 == -50016)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (140897 - 230945 == -90047)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (82310 - 534229 == -451918)
						{
							continue;
						}
						missionClass.mapName = "Gao Desert";
						if (180235 - 134948 != 45287)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)665, (float)422);
						if (40095 - 496408 == -456312)
						{
							continue;
						}
					}
					else if (c == 501)
					{
						if (222797 - 99015 == 123783)
						{
							continue;
						}
						missionClass.name = "Through the Swamp";
						if (14401 - 161178 != -146777)
						{
							continue;
						}
						missionClass.des = "  เพื่อที่จะลัดทางผ่านดินแดนทะเลทรายไปยังชายฝั่ง เหล่าผู้กล้าจำเป็นต้องเดินทางผ่านบึงพิษ ที่เต็มไปด้วยพวกทากซะก่อน";
						if (241390 - 332855 != -91465)
						{
							continue;
						}
						missionClass.obj = "  ผ่านไปให้ถึงชายหาด";
						if (30359 - 128005 != -97646)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (68190 - 230077 != -161887)
						{
							continue;
						}
						missionClass.lv = 25;
						if (204208 - 54244 != 149964)
						{
							continue;
						}
						missionClass.slv = 29;
						if (188124 - 71829 == 116296)
						{
							continue;
						}
						missionClass.player = 3;
						if (173648 - 280812 == -107163)
						{
							continue;
						}
						missionClass.team = 1;
						if (204973 - 173725 == 31249)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (67197 - 524173 != -456976)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (211006 - 113338 == 97669)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (28216 - 500955 != -472739)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (163177 - 117644 == 45534)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (295145 - 312950 == -17804)
						{
							continue;
						}
						missionClass.mapName = "Poison Swamp";
						if (114597 - 167153 == -52555)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)622, (float)531);
						if (232086 - 579505 != -347419)
						{
							continue;
						}
					}
					else if (c == 502)
					{
						if (62739 - 344412 == -281672)
						{
							continue;
						}
						missionClass.name = "To The Beach!";
						if (15857 - 275474 == -259616)
						{
							continue;
						}
						missionClass.des = "    เร็กกุมารอช่วยผู้กล้าให้สามารถลงใต้ทะเลอยู่ที่ชายหาดแล้ว  โดยจะต้องหาเปลือกหอยพิเศษ มาทำเครื่องรางสำหรับหายใจใต้น้ำ";
						if (50664 - 242554 == -191889)
						{
							continue;
						}
						missionClass.obj = "   เก็บเปลือกหอยมาให้ได้ 10 อัน แล้วนำมาให้เร็กกุที่ จุดเริ่มต้น";
						if (33193 - 551625 == -518431)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (250579 - 192187 == 58393)
						{
							continue;
						}
						missionClass.lv = 26;
						if (286578 - 449482 == -162903)
						{
							continue;
						}
						missionClass.slv = 30;
						if (96238 - 584999 == -488760)
						{
							continue;
						}
						missionClass.player = 3;
						if (124419 - 459759 == -335339)
						{
							continue;
						}
						missionClass.team = 1;
						if (226213 - 575305 != -349092)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (247294 - 211135 == 36160)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (51667 - 482806 == -431138)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (29087 - 306153 == -277065)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (156798 - 36608 != 120190)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (295700 - 41348 != 254352)
						{
							continue;
						}
						missionClass.mapName = "Eastern Coast";
						if (160667 - 488968 != -328301)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)740, (float)598);
						if (206212 - 574555 != -368343)
						{
							continue;
						}
					}
					else if (c == 503)
					{
						if (171456 - 308689 == -137232)
						{
							continue;
						}
						missionClass.name = "The Two Turtle Sages";
						if (94322 - 434541 == -340218)
						{
							continue;
						}
						missionClass.des = "    จู่ๆ สองเต่าปรมาจารย์ในตำนานก็ปรากฏตัว ขึ้นมาขวางทางเพื่อมาช่วยฝึกการ ต่อสู้ให้แก่เหล่าผู้กล้า ตามคำขอของโบลดาส";
						if (285676 - 161115 != 124561)
						{
							continue;
						}
						missionClass.obj = "    ไม่มีการออมมือจากสองเต่าเฒ่า สู้ให้เต็มที่มิเช่นนั้นการเดินทางอาจ จะต้องจบลงตรงนี้";
						if (279950 - 101104 != 178846)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (198237 - 242484 != -44247)
						{
							continue;
						}
						missionClass.lv = 27;
						if (123373 - 331813 == -208439)
						{
							continue;
						}
						missionClass.slv = 31;
						if (27381 - 161783 == -134401)
						{
							continue;
						}
						missionClass.player = 3;
						if (205327 - 198655 == 6673)
						{
							continue;
						}
						missionClass.team = 1;
						if (183755 - 303155 == -119399)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (34443 - 562095 != -527652)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (35351 - 75628 != -40277)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (199651 - 525009 == -325357)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (210317 - 556592 != -346275)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (98366 - 82285 == 16082)
						{
							continue;
						}
						missionClass.mapName = "Beach Area";
						if (28355 - 472270 == -443914)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)699, (float)562);
						if (20645 - 364979 == -344333)
						{
							continue;
						}
					}
					else if (c == 504)
					{
						if (160096 - 243938 == -83841)
						{
							continue;
						}
						missionClass.name = "Water Temple";
						if (240119 - 395735 == -155615)
						{
							continue;
						}
						missionClass.des = "    เหล่าผู้กล้าเดินทางไปยังใต้บาดาลเพื่อพบเทพน้ำ โดยผ่านวิหารโบราณที่กลายเป็นที่ อยู่ของพวกวิซซี่ไปซะแล้ว";
						if (82857 - 443329 == -360471)
						{
							continue;
						}
						missionClass.obj = "   ผ่านวิหารโบราณเพื่อลงไปยังดินแดนใต้บาดาล";
						if (118932 - 303096 != -184164)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (280399 - 233382 == 47018)
						{
							continue;
						}
						missionClass.lv = 28;
						if (9994 - 497328 == -487333)
						{
							continue;
						}
						missionClass.slv = 32;
						if (174630 - 389842 == -215211)
						{
							continue;
						}
						missionClass.player = 4;
						if (113554 - 488129 != -374575)
						{
							continue;
						}
						missionClass.team = 1;
						if (54599 - 294297 != -239698)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (124117 - 589541 != -465424)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (104885 - 298370 == -193484)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (29298 - 160909 != -131611)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (255341 - 456962 == -201620)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (251906 - 109618 != 142288)
						{
							continue;
						}
						missionClass.mapName = "Mari-Tumu Temple";
						if (16261 - 275763 == -259501)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)779, (float)555);
						if (216760 - 427017 == -210256)
						{
							continue;
						}
					}
					else if (c == 505)
					{
						if (107491 - 219331 != -111840)
						{
							continue;
						}
						missionClass.name = "Sunken City";
						if (171151 - 18462 == 152690)
						{
							continue;
						}
						missionClass.des = "   ที่นี่คือ....ซากเมืองโบราณจากอารยธรรมที่สูญหาย งั้นเหรอ? อย่ามัวแต่เดินชมอยู่ล่ะ";
						if (128673 - 362200 != -233527)
						{
							continue;
						}
						missionClass.obj = "   ไปให้ถึงจุดหมายปลายทาง";
						if (200162 - 411698 != -211536)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (162038 - 187636 == -25597)
						{
							continue;
						}
						missionClass.lv = 29;
						if (100225 - 563000 != -462775)
						{
							continue;
						}
						missionClass.slv = 33;
						if (55262 - 183856 != -128594)
						{
							continue;
						}
						missionClass.player = 3;
						if (42413 - 177066 == -134652)
						{
							continue;
						}
						missionClass.team = 1;
						if (37319 - 413605 != -376286)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (157871 - 216659 != -58788)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (201008 - 337696 == -136687)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (53465 - 413866 == -360400)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (227544 - 40458 != 187086)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (143819 - 540662 == -396842)
						{
							continue;
						}
						missionClass.mapName = "Sunken City Ruins";
						if (238926 - 299301 != -60375)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)782, (float)703);
						if (239429 - 56187 != 183242)
						{
							continue;
						}
					}
					else if (c == 506)
					{
						if (271518 - 400932 != -129414)
						{
							continue;
						}
						missionClass.name = "Anemone's Palace";
						if (199383 - 516668 == -317284)
						{
							continue;
						}
						missionClass.des = "  เจ้าหอยแอมโมไนท์ยักษ์ดูท่าจะไม่อยากต้อนรับเหล่า ผู้กล้า ที่ล้ำเข้ามาในเขตปราสาทของเทพน้ำซักเท่าไหร่";
						if (288696 - 292865 != -4169)
						{
							continue;
						}
						missionClass.obj = "  ปราบหอยแอมโมไนท์แล้วผ่านไปให้ถึงปราสาท";
						if (133581 - 193047 == -59465)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (61886 - 412166 != -350280)
						{
							continue;
						}
						missionClass.lv = 30;
						if (112698 - 112300 == 399)
						{
							continue;
						}
						missionClass.slv = 34;
						if (231984 - 599475 == -367490)
						{
							continue;
						}
						missionClass.player = 3;
						if (126781 - 12395 != 114386)
						{
							continue;
						}
						missionClass.team = 1;
						if (68743 - 97931 != -29188)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (41448 - 188040 == -146591)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (246138 - 5098 == 241041)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (132167 - 554848 != -422681)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (253441 - 549138 != -295697)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (133175 - 304159 != -170984)
						{
							continue;
						}
						missionClass.mapName = "Anemone Palace";
						if (74287 - 249956 == -175668)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)732, (float)730);
						if (219280 - 389191 != -169911)
						{
							continue;
						}
					}
					else if (c == 507)
					{
						if (249854 - 365051 != -115197)
						{
							continue;
						}
						missionClass.name = "Anemone's decision";
						if (190343 - 516873 == -326529)
						{
							continue;
						}
						missionClass.des = "     เทพน้ำเป็นเทพที่ได้ชื่อว่าใจดี รักสงบ เกลียดการ สู้รบ และสงครามมาก \n     ...แล้วเทพน้ำจะตัดสินใจอย่างไรกันนะ?";
						if (35927 - 498765 == -462837)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (254689 - 310807 == -56117)
						{
							continue;
						}
						missionClass.lv = 0;
						if (60573 - 161634 == -101060)
						{
							continue;
						}
						missionClass.slv = 35;
						if (261355 - 259602 == 1754)
						{
							continue;
						}
						missionClass.player = 1;
						if (248597 - 138086 != 110511)
						{
							continue;
						}
						missionClass.team = 1;
						if (28566 - 511516 == -482949)
						{
							continue;
						}
						missionClass.mapName = "Anemone Palace";
						if (167365 - 348781 != -181416)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)732, (float)730);
						if (93885 - 194202 != -100317)
						{
							continue;
						}
					}
					else if (c == 508)
					{
						if (77830 - 597394 == -519563)
						{
							continue;
						}
						missionClass.name = "SmashBall";
						if (106456 - 178032 == -71575)
						{
							continue;
						}
						missionClass.des = "     กีฬายอดฮิตของชาวหาง ทำทุกวิถีทางให้บอล ลอยเข้าประตูของอีกฝั่ง";
						if (17885 - 547835 != -529950)
						{
							continue;
						}
						missionClass.obj = "     ทำประตูให้ได้ 6 ประตู";
						if (266880 - 572222 == -305341)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (68630 - 148259 != -79629)
						{
							continue;
						}
						missionClass.lv = 0;
						if (272205 - 201878 != 70327)
						{
							continue;
						}
						missionClass.slv = 36;
						if (204367 - 16864 == 187504)
						{
							continue;
						}
						missionClass.player = 6;
						if (115609 - 550264 == -434654)
						{
							continue;
						}
						missionClass.team = 2;
						if (39619 - 285127 == -245507)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (202463 - 572945 != -370482)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (113057 - 552507 != -439450)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (34306 - 415777 != -381471)
						{
							continue;
						}
						missionClass.allowRespawn = true;
						if (199090 - 316837 != -117747)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (60779 - 436503 == -375723)
						{
							continue;
						}
						missionClass.mapName = "Seaside Ring";
						if (51378 - 575044 == -523665)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)625, (float)613);
						if (225871 - 197110 != 28761)
						{
							continue;
						}
					}
					else if (c == 601)
					{
						if (157561 - 424977 == -267415)
						{
							continue;
						}
						missionClass.name = "Flight Back to The City";
						if (239633 - 499828 == -260194)
						{
							continue;
						}
						missionClass.des = "    กาซ่ากำลังซิ่งนรกเพื่อพาพวกผู้กล้า กลับไปช่วยเมืองแสงที่ถูกพวกเงา โจมตี";
						if (208878 - 357001 != -148123)
						{
							continue;
						}
						missionClass.obj = "   บินซิ่งกลับไปให้ถึงจุดหมาย ภายใน 3 นาที";
						if (85275 - 26549 == 58727)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (104919 - 123794 == -18874)
						{
							continue;
						}
						missionClass.lv = 31;
						if (118697 - 5720 != 112977)
						{
							continue;
						}
						missionClass.slv = 36;
						if (54740 - 12703 != 42037)
						{
							continue;
						}
						missionClass.player = 1;
						if (257768 - 164229 != 93539)
						{
							continue;
						}
						missionClass.team = 1;
						if (204817 - 467887 == -263069)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (58324 - 393021 == -334696)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (71211 - 86989 == -15777)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (167960 - 337986 == -170025)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (142408 - 252636 == -110227)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (121929 - 143907 == -21977)
						{
							continue;
						}
						missionClass.mapName = "Sky";
						if (224992 - 323118 == -98125)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)699, (float)562);
						if (94765 - 67695 != 27070)
						{
							continue;
						}
					}
					else if (c == 602)
					{
						if (43682 - 363060 == -319377)
						{
							continue;
						}
						missionClass.name = "Highway Blockade";
						if (117928 - 275534 != -157606)
						{
							continue;
						}
						missionClass.des = "  อยู่ๆพวกทหารเสือดำก็มาตั้งด่านปิดทางไปเมืองแสง นี่มันเรื่องอะไรกัน? รู้สึกว่าท่าทางของพวกนั้นดูแปลก ไปทุกคนเลย";
						if (21816 - 285871 != -264055)
						{
							continue;
						}
						missionClass.obj = "   จัดการกับพวกเสือดำเพื่อฝ่าด่านไปให้ได้";
						if (262840 - 70305 == 192536)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (114603 - 493233 != -378630)
						{
							continue;
						}
						missionClass.lv = 32;
						if (261830 - 537529 == -275698)
						{
							continue;
						}
						missionClass.slv = 37;
						if (65385 - 316596 != -251211)
						{
							continue;
						}
						missionClass.player = 4;
						if (223376 - 499083 != -275707)
						{
							continue;
						}
						missionClass.team = 1;
						if (50568 - 299942 != -249374)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (218800 - 392704 == -173903)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (45017 - 112547 == -67529)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (172020 - 538141 != -366121)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (294034 - 142758 != 151276)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (275694 - 202682 == 73013)
						{
							continue;
						}
						missionClass.mapName = "Light Plain";
						if (130856 - 354798 == -223941)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)397, (float)542);
						if (19909 - 109370 == -89460)
						{
							continue;
						}
					}
					else if (c == 603)
					{
						if (243047 - 126185 != 116862)
						{
							continue;
						}
						missionClass.name = "Shade in the City";
						if (72056 - 450480 == -378423)
						{
							continue;
						}
						missionClass.des = "    ดูเหมือนเงามืดกำลังเข้าปกคลุมเมืองแสง แล้วพวก ชาวเมืองจะปลอดภัยดีรึเปล่านะ?";
						if (64263 - 554290 == -490026)
						{
							continue;
						}
						missionClass.obj = "   ช่วยชาวเมืองให้ครบ 10 คน";
						if (48562 - 398780 != -350218)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (136392 - 509209 != -372817)
						{
							continue;
						}
						missionClass.lv = 33;
						if (199367 - 459638 == -260270)
						{
							continue;
						}
						missionClass.slv = 38;
						if (79022 - 549380 == -470357)
						{
							continue;
						}
						missionClass.player = 3;
						if (168132 - 432408 != -264276)
						{
							continue;
						}
						missionClass.team = 1;
						if (75696 - 16223 == 59474)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (169177 - 39468 == 129710)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (135687 - 22467 == 113221)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (61343 - 31344 != 29999)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (27275 - 536678 != -509403)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (247476 - 579057 == -331580)
						{
							continue;
						}
						missionClass.mapName = "LightCity";
						if (82819 - 538920 != -456101)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)390, (float)400);
						if (235781 - 562315 != -326534)
						{
							continue;
						}
					}
					else if (c == 604)
					{
						if (256090 - 324237 != -68147)
						{
							continue;
						}
						missionClass.name = "Smashing Pumpkon";
						if (170837 - 275231 == -104393)
						{
							continue;
						}
						missionClass.des = "    ขณะที่พวกเงาเข้าโจมตีเมืองแสง เจ้าฟักทองก็โผล่ มาเต็มแครอนฟาร์มไปหมด ใครช่วยสละเวลาไปกำจัด พวกมันที";
						if (170543 - 148843 == 21701)
						{
							continue;
						}
						missionClass.obj = "    จัดการกับพัมกอน 55 ตัวภายในเวลา 10 นาที";
						if (52314 - 304741 == -252426)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (19727 - 70413 != -50686)
						{
							continue;
						}
						missionClass.lv = 34;
						if (58120 - 324678 != -266558)
						{
							continue;
						}
						missionClass.slv = 39;
						if (86672 - 445189 != -358517)
						{
							continue;
						}
						missionClass.player = 3;
						if (22567 - 572274 == -549706)
						{
							continue;
						}
						missionClass.team = 1;
						if (219289 - 431653 != -212364)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (54357 - 339481 == -285123)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (164122 - 429696 == -265573)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (214672 - 193100 != 21572)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (123131 - 378304 == -255172)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (120425 - 364129 != -243704)
						{
							continue;
						}
						missionClass.mapName = "Carron Farm";
						if (289320 - 326913 == -37592)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)198, (float)652);
						if (231129 - 88701 != 142428)
						{
							continue;
						}
					}
					else if (c == 605)
					{
						if (121253 - 276148 == -154894)
						{
							continue;
						}
						missionClass.name = "LightGarden Defense";
						if (197149 - 32681 != 164468)
						{
							continue;
						}
						missionClass.des = "    เสามานาที่ช่วยค้ำจุนเมืองกำลังถูกโจมตี ทุกคน! รีบไปช่วยพวกทหารเร็วเข้า...! ปกป้องเมืองแสงเอาไว้ ให้ได้!";
						if (232408 - 414567 != -182159)
						{
							continue;
						}
						missionClass.obj = "    เปิดเสามานาทั้งหมดและจัดการกับเชดี้ 4 ตัว";
						if (85693 - 68753 == 16941)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (253815 - 341914 != -88099)
						{
							continue;
						}
						missionClass.lv = 35;
						if (172752 - 598713 == -425960)
						{
							continue;
						}
						missionClass.slv = 40;
						if (67020 - 581343 == -514322)
						{
							continue;
						}
						missionClass.player = 5;
						if (148348 - 451696 != -303348)
						{
							continue;
						}
						missionClass.team = 1;
						if (7718 - 452491 == -444772)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (291893 - 183719 != 108174)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (278679 - 442121 == -163441)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (26353 - 319091 != -292738)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (61873 - 463384 == -401510)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (126157 - 140632 == -14474)
						{
							continue;
						}
						missionClass.mapName = "LightCity";
						if (55022 - 285782 == -230759)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)390, (float)400);
						if (15485 - 444363 == -428877)
						{
							continue;
						}
					}
					else if (c == 606)
					{
						if (200633 - 41788 != 158845)
						{
							continue;
						}
						missionClass.name = "Walrus Gone Mad";
						if (288920 - 588688 == -299767)
						{
							continue;
						}
						missionClass.des = "     พวกฮีโร่ฝ่าขึ้นไปบนวังแสงได้แล้ว...\nแต่เอ๊ะ! เกิดอะไรขึ้นกับจอมเวทเร็กกุ!?";
						if (146335 - 504876 == -358540)
						{
							continue;
						}
						missionClass.obj = "   ล้มเร็กกุให้ได้";
						if (41972 - 384067 == -342094)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (223687 - 48290 == 175398)
						{
							continue;
						}
						missionClass.lv = 36;
						if (164746 - 133503 == 31244)
						{
							continue;
						}
						missionClass.slv = 41;
						if (143843 - 217615 != -73772)
						{
							continue;
						}
						missionClass.player = 3;
						if (15799 - 335276 != -319477)
						{
							continue;
						}
						missionClass.team = 1;
						if (129978 - 434954 == -304975)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (141793 - 167794 == -26000)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (138952 - 579071 == -440118)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (267368 - 17656 == 249713)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (208290 - 247782 == -39491)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (147171 - 77972 == 69200)
						{
							continue;
						}
						missionClass.mapName = "Alcacia Palace";
						if (43051 - 546041 != -502990)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)317, (float)588);
						if (109636 - 371541 != -261905)
						{
							continue;
						}
					}
					else if (c == 607)
					{
						if (164691 - 380842 != -216151)
						{
							continue;
						}
						missionClass.name = "Message from the Shadow";
						if (125141 - 399693 == -274551)
						{
							continue;
						}
						missionClass.des = "   พวกเชดนำสาส์นลึกลับจากเทพเงามาให้กับเทพแสง จุดประสงค์ที่แท้จริงของเทพเงา ...คืออะไรกันแน่?";
						if (15038 - 105127 != -90089)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (253224 - 294293 != -41069)
						{
							continue;
						}
						missionClass.lv = 0;
						if (248647 - 382209 != -133562)
						{
							continue;
						}
						missionClass.slv = 42;
						if (35713 - 384910 == -349196)
						{
							continue;
						}
						missionClass.player = 1;
						if (155033 - 205486 != -50453)
						{
							continue;
						}
						missionClass.team = 1;
						if (279945 - 127291 == 152655)
						{
							continue;
						}
						missionClass.mapName = "Alcacia Palace";
						if (101504 - 410939 == -309434)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)317, (float)588);
						if (252926 - 262054 != -9128)
						{
							continue;
						}
					}
					else if (c == 608)
					{
						if (104847 - 99196 == 5652)
						{
							continue;
						}
						missionClass.name = "Five on Five";
						if (23985 - 336944 == -312958)
						{
							continue;
						}
						missionClass.des = "  มิชชั่นพิเศษ สู้แบบทีม 5ต่อ5";
						if (297142 - 204340 == 92803)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (299517 - 295343 != 4174)
						{
							continue;
						}
						missionClass.lv = 0;
						if (87011 - 3579 == 83433)
						{
							continue;
						}
						missionClass.slv = 43;
						if (104520 - 554081 == -449560)
						{
							continue;
						}
						missionClass.player = 10;
						if (232925 - 58562 != 174363)
						{
							continue;
						}
						missionClass.team = 2;
						if (212850 - 246060 != -33210)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (138054 - 482958 != -344904)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (187497 - 356893 == -169395)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (229300 - 392137 == -162836)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (203710 - 120444 == 83267)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (186692 - 357818 != -171126)
						{
							continue;
						}
					}
					else if (c == 701)
					{
						if (61036 - 503202 != -442166)
						{
							continue;
						}
						missionClass.name = "A Strange New Foe";
						if (55939 - 427800 == -371860)
						{
							continue;
						}
						missionClass.des = "   มีรายงานว่าพบเครื่องจักรกลประหลาดตามที่ต่างๆ อิทาลุสจึงอยากให้พวกผู้กล้าไปตรวจสอบ";
						if (269455 - 101103 != 168352)
						{
							continue;
						}
						missionClass.obj = "   ดักจับเครื่องจักรประหลาดให้ได้อย่างน้อย 3 ตัว ระวังสติงบั๊กทะเลทรายที่ดุร้ายด้วย";
						if (223058 - 75957 != 147101)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (141493 - 281999 == -140505)
						{
							continue;
						}
						missionClass.lv = 37;
						if (289776 - 230307 == 59470)
						{
							continue;
						}
						missionClass.slv = 43;
						if (90188 - 333656 != -243468)
						{
							continue;
						}
						missionClass.player = 3;
						if (97657 - 408575 != -310918)
						{
							continue;
						}
						missionClass.team = 1;
						if (206725 - 184620 != 22105)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (256991 - 201553 == 55439)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (116347 - 517739 == -401391)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (261190 - 582908 == -321717)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (604 - 487657 == -487052)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (114643 - 151573 != -36930)
						{
							continue;
						}
						missionClass.mapName = "Northern Gao Desert";
						if (254650 - 64453 == 190198)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)524, (float)472);
						if (266161 - 192399 == 73763)
						{
							continue;
						}
					}
					else if (c == 702)
					{
						if (36162 - 7159 == 29004)
						{
							continue;
						}
						missionClass.name = "Eastern World Divide";
						if (286548 - 123479 != 163069)
						{
							continue;
						}
						missionClass.des = "  จากร่องรอยที่ได้ บ่งบอกว่าเครื่องจักรประหลาด มาจากทางเหนือ พวกผู้กล้าจึงเดินทางไปพิสูจน์";
						if (42642 - 586916 == -544273)
						{
							continue;
						}
						missionClass.obj = "   ไปให้ถึงรอยแผลของโลกเพื่อตรวจสอบ";
						if (198379 - 353720 != -155341)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (177343 - 286409 == -109065)
						{
							continue;
						}
						missionClass.lv = 38;
						if (70477 - 1067 != 69410)
						{
							continue;
						}
						missionClass.slv = 44;
						if (7287 - 65254 != -57967)
						{
							continue;
						}
						missionClass.player = 3;
						if (280469 - 96577 != 183892)
						{
							continue;
						}
						missionClass.team = 1;
						if (280065 - 401272 != -121207)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (49558 - 111584 == -62025)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (295843 - 309591 == -13747)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (227576 - 375242 == -147665)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (235537 - 367014 != -131477)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (97168 - 272556 != -175388)
						{
							continue;
						}
						missionClass.mapName = "Eastern World Divide";
						if (6820 - 6989 == -168)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)585, (float)299);
						if (213955 - 144852 == 69104)
						{
							continue;
						}
					}
					else if (c == 703)
					{
						if (248715 - 584242 != -335527)
						{
							continue;
						}
						missionClass.name = "Sand Dune Terror";
						if (130435 - 218306 != -87871)
						{
							continue;
						}
						missionClass.des = "  ช่วงนี้ฝูงผึ้งทะเลทรายที่ดุร้าย ออกมาทำร้ายเหล่าผู้ช่วย ของ ดร.ลิซ่าอยู่บ่อยๆ ใครก็ได้ช่วยไปจัดการพวกมันที";
						if (96168 - 182098 != -85930)
						{
							continue;
						}
						missionClass.obj = " ทลายรังของพวกผึ้งทะเลทรายให้หมด";
						if (296874 - 104988 == 191887)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (89589 - 63828 != 25761)
						{
							continue;
						}
						missionClass.lv = 39;
						if (71235 - 548126 == -476890)
						{
							continue;
						}
						missionClass.slv = 45;
						if (270154 - 352875 == -82720)
						{
							continue;
						}
						missionClass.player = 4;
						if (265332 - 160832 != 104500)
						{
							continue;
						}
						missionClass.team = 1;
						if (45234 - 339362 != -294128)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (206751 - 212021 == -5269)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (211016 - 245150 != -34134)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (272847 - 497092 != -224245)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (163826 - 451635 == -287808)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (188111 - 172863 != 15248)
						{
							continue;
						}
						missionClass.mapName = "Western Gao Desert";
						if (115167 - 559256 == -444088)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)529, (float)470);
						if (274558 - 444875 != -170317)
						{
							continue;
						}
					}
					else if (c == 704)
					{
						if (114714 - 515280 != -400566)
						{
							continue;
						}
						missionClass.name = "Zappa Base Entrance";
						if (42642 - 214148 != -171506)
						{
							continue;
						}
						missionClass.des = "     เพื่อที่จะรู้เรื่องเกี่ยวกับพวกเครื่องจักรประหลาด พวกผู้กล้าได้นำชิ้นส่วนของพวกมันเดินทางไปหาตุ่น นักวิทยาศาสตร์สติเฟื่อง ที่แยกตัวออกไป...";
						if (59418 - 32003 == 27416)
						{
							continue;
						}
						missionClass.obj = "     ฝ่าไปให้ถึงฐานของ ดร. แซปป้า และจัดการกับ แกลลอนบ็อทรักษาความปลอดภัย 15 ตัว";
						if (97708 - 451469 != -353761)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (32840 - 172183 != -139343)
						{
							continue;
						}
						missionClass.lv = 40;
						if (140141 - 211879 != -71738)
						{
							continue;
						}
						missionClass.slv = 46;
						if (222846 - 290252 != -67406)
						{
							continue;
						}
						missionClass.player = 4;
						if (200322 - 210353 == -10030)
						{
							continue;
						}
						missionClass.team = 1;
						if (135026 - 190495 != -55469)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (27844 - 403999 == -376154)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (201610 - 409734 != -208124)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (190981 - 217642 != -26661)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (125605 - 26423 == 99183)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (231741 - 505702 != -273961)
						{
							continue;
						}
						missionClass.mapName = "Northern Pine Forest";
						if (179752 - 210694 != -30942)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)422, (float)256);
						if (177142 - 42615 != 134527)
						{
							continue;
						}
					}
					else if (c == 705)
					{
						if (93182 - 342919 == -249736)
						{
							continue;
						}
						missionClass.name = "Inside Zappa Base";
						if (12494 - 212893 != -200399)
						{
							continue;
						}
						missionClass.des = "   นอกจากหุ่นยนต์แล้ว ฐานทัพใต้ดินของ ดร.แซปป้า ไม่ต้อนรับใครทั้งนั้น!";
						if (180277 - 523426 != -343149)
						{
							continue;
						}
						missionClass.obj = "  ฝ่าระบบรักษาความปลอดภัยไปให้ถึงตัว ดร. แซปป้า";
						if (277922 - 462416 == -184493)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (122424 - 479351 != -356927)
						{
							continue;
						}
						missionClass.lv = 41;
						if (206125 - 18610 == 187516)
						{
							continue;
						}
						missionClass.slv = 47;
						if (150976 - 23401 != 127575)
						{
							continue;
						}
						missionClass.player = 5;
						if (22152 - 131320 != -109168)
						{
							continue;
						}
						missionClass.team = 1;
						if (123553 - 157124 != -33571)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (278919 - 568779 == -289859)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (25500 - 556867 != -531367)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (52673 - 110373 == -57699)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (14918 - 428742 == -413823)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (123071 - 418666 == -295594)
						{
							continue;
						}
						missionClass.mapName = "Dr. Zappa's Base";
						if (7715 - 162417 == -154701)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)392, (float)262);
						if (263250 - 179785 != 83465)
						{
							continue;
						}
					}
					else if (c == 706)
					{
						if (138455 - 320504 == -182048)
						{
							continue;
						}
						missionClass.name = "Meet Dr. Zappa!";
						if (187533 - 541745 == -354211)
						{
							continue;
						}
						missionClass.des = "   ดร.แซปป้าชอบผู้บุกรุกเป็นที่สุด เพราะจะได้ทดสอบ สิ่งประดิษฐ์ใหม่ๆ!";
						if (8385 - 370399 != -362014)
						{
							continue;
						}
						missionClass.obj = "  สู้และเอาชนะ ดร.แซปป้า ให้ได้";
						if (159958 - 420981 == -261022)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (268793 - 339944 == -71150)
						{
							continue;
						}
						missionClass.lv = 42;
						if (41740 - 114342 != -72602)
						{
							continue;
						}
						missionClass.slv = 48;
						if (22617 - 456636 != -434019)
						{
							continue;
						}
						missionClass.player = 5;
						if (116194 - 53044 != 63150)
						{
							continue;
						}
						missionClass.team = 1;
						if (258269 - 323413 == -65143)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (273707 - 101491 != 172216)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (231029 - 410716 == -179686)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (236116 - 85466 != 150650)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (63460 - 67580 == -4119)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (134763 - 293706 != -158943)
						{
							continue;
						}
						missionClass.mapName = "Dr. Zappa's Base";
						if (130465 - 525123 != -394658)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)392, (float)262);
						if (156618 - 186439 == -29820)
						{
							continue;
						}
					}
					else if (c == 707)
					{
						if (134718 - 508222 != -373504)
						{
							continue;
						}
						missionClass.name = "Machine from the past";
						if (55621 - 564310 != -508689)
						{
							continue;
						}
						missionClass.des = "    ดร.แซบป้า ตรวจดูชิ้นส่วนของพวกหุ่นยนต์ แล้วจึงได้พบกับความจริงที่น่าตกใจ";
						if (210227 - 94991 != 115236)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (166087 - 58977 != 107110)
						{
							continue;
						}
						missionClass.lv = 0;
						if (252766 - 323346 == -70579)
						{
							continue;
						}
						missionClass.slv = 49;
						if (217694 - 534137 != -316443)
						{
							continue;
						}
						missionClass.player = 1;
						if (163423 - 42407 != 121016)
						{
							continue;
						}
						missionClass.team = 1;
						if (177252 - 447789 != -270537)
						{
							continue;
						}
						missionClass.mapName = "Dr. Zappa's Base";
						if (258258 - 152168 == 106091)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)392, (float)262);
						if (200807 - 290654 != -89847)
						{
							continue;
						}
					}
					else if (c == 708)
					{
						if (260265 - 405226 == -144960)
						{
							continue;
						}
						missionClass.name = "SmackRun";
						if (203635 - 482431 != -278796)
						{
							continue;
						}
						missionClass.des = "    สุดยอดกีฬาดุเดือดของพวกทหาร ผลัดกันวิ่งฝ่าไป ให้ถึงเส้นชัย ในเวลาที่กำหนด  ในขณะที่มีอีกทีมคอย ขัดขวาง";
						if (155083 - 33080 == 122004)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (254360 - 560688 == -306327)
						{
							continue;
						}
						missionClass.lv = 0;
						if (2469 - 422908 == -420438)
						{
							continue;
						}
						missionClass.slv = 50;
						if (98005 - 325892 != -227887)
						{
							continue;
						}
						missionClass.player = 10;
						if (100712 - 26472 != 74240)
						{
							continue;
						}
						missionClass.team = 2;
						if (253315 - 25854 != 227461)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (51996 - 432653 == -380656)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (243026 - 47595 != 195431)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (278714 - 120644 == 158071)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (105919 - 18259 == 87661)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (41869 - 252684 != -210815)
						{
							continue;
						}
						missionClass.mapName = "Western Gao Desert";
						if (140370 - 302076 == -161705)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)524, (float)472);
						if (47332 - 68332 != -21000)
						{
							continue;
						}
					}
					else if (c == 801)
					{
						if (37209 - 53203 != -15994)
						{
							continue;
						}
						missionClass.name = "Life as a GallonBot";
						if (15784 - 53640 == -37855)
						{
							continue;
						}
						missionClass.des = "  พวกฮีโร่กลับไปจากแล้ว แต่ใครล่ะจะช่วย ด.ร.แซปป้าซ่อมแซมฐาน?";
						if (221885 - 262967 != -41082)
						{
							continue;
						}
						missionClass.obj = "  เล่นเป็นแกลลอนบ๊อท วิ่งไปอุดท่อที่รั่วทั้งหมดก่อนที่ฐานจะระเบิด";
						if (277091 - 554101 == -277009)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (85615 - 147556 == -61940)
						{
							continue;
						}
						missionClass.lv = 43;
						if (32729 - 98649 != -65920)
						{
							continue;
						}
						missionClass.slv = 50;
						if (258459 - 394556 != -136097)
						{
							continue;
						}
						missionClass.player = 4;
						if (255129 - 258097 == -2967)
						{
							continue;
						}
						missionClass.team = 1;
						if (154369 - 576411 == -422041)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (53404 - 288116 == -234711)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (129184 - 488989 != -359805)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (234341 - 180086 != 54255)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (242274 - 483598 != -241324)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (96777 - 267639 == -170861)
						{
							continue;
						}
						missionClass.mapName = "Dr. Zappa's Base";
						if (296323 - 11636 == 284688)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)392, (float)262);
						if (163874 - 341698 != -177824)
						{
							continue;
						}
					}
					else if (c == 802)
					{
						if (113923 - 215894 == -101970)
						{
							continue;
						}
						missionClass.name = "Boldas's Final Test";
						if (136392 - 407127 != -270735)
						{
							continue;
						}
						missionClass.des = "    เวลาแห่งสงครามได้เข้ามาใกล้แล้ว แม่ทัพโบลดาสจึงอยากจะทดสอบพวกผู้กล้าอีกครั้ง";
						if (8832 - 245412 == -236579)
						{
							continue;
						}
						missionClass.obj = "   สู้และเอาชนะแม่ทัพโบลดาสให้ได้";
						if (183071 - 488173 == -305101)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (119777 - 146452 == -26674)
						{
							continue;
						}
						missionClass.lv = 44;
						if (153772 - 174111 != -20339)
						{
							continue;
						}
						missionClass.slv = 51;
						if (65455 - 274600 != -209145)
						{
							continue;
						}
						missionClass.player = 3;
						if (248209 - 119002 == 129208)
						{
							continue;
						}
						missionClass.team = 1;
						if (70676 - 368098 == -297421)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (136304 - 123872 != 12432)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (78545 - 423484 != -344939)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (270648 - 342107 == -71458)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (256889 - 369418 == -112528)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (92538 - 92633 != -95)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (174828 - 228086 == -53257)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (3597 - 544504 == -540906)
						{
							continue;
						}
					}
					else if (c == 803)
					{
						if (153568 - 34876 == 118693)
						{
							continue;
						}
						missionClass.name = "Steel Invaders";
						if (225706 - 71401 == 154306)
						{
							continue;
						}
						missionClass.des = "  กลุ่มเครื่องจักรประหลาดได้บุกเข้า มาในฟาร์มเครอนของคุณแพะแล้ว ใครช่วยจัดการพวกมันที";
						if (217914 - 399344 == -181429)
						{
							continue;
						}
						missionClass.obj = "  จัดการกับพวกเครื่องจักรประหลาดในฟาร์มทั้งหมด";
						if (14289 - 47338 == -33048)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (179458 - 56438 != 123020)
						{
							continue;
						}
						missionClass.lv = 45;
						if (79624 - 452486 != -372862)
						{
							continue;
						}
						missionClass.slv = 52;
						if (56405 - 528662 == -472256)
						{
							continue;
						}
						missionClass.player = 3;
						if (181818 - 388630 == -206811)
						{
							continue;
						}
						missionClass.team = 1;
						if (87694 - 541050 != -453356)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (144597 - 360926 != -216329)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (284556 - 354371 != -69815)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (111397 - 147504 != -36107)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (297635 - 513459 == -215823)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (70979 - 68435 != 2544)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (100396 - 535322 == -434925)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (248349 - 509878 == -261528)
						{
							continue;
						}
					}
					else if (c == 804)
					{
						if (120055 - 495728 == -375672)
						{
							continue;
						}
						missionClass.name = "Library's Elevator";
						if (140617 - 305876 == -165258)
						{
							continue;
						}
						missionClass.des = "   เร็กกุเปิดลิฟท์ห้องสมุดเพื่อให้ผู้กล้าผ่านใป วิหารลับใต้วังแสง แต่ผู้กล้ากลับเจอสิ่ง ไม่คาดคิดระหว่างทาง!";
						if (188086 - 85370 == 102717)
						{
							continue;
						}
						missionClass.obj = "  จัดการเหล่าแมลงกระดาษที่บุกเข้ามาบนลิฟท์ทั้งหมด";
						if (26660 - 430107 != -403447)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (36659 - 21617 != 15042)
						{
							continue;
						}
						missionClass.lv = 46;
						if (215553 - 552805 != -337252)
						{
							continue;
						}
						missionClass.slv = 53;
						if (90971 - 283691 == -192719)
						{
							continue;
						}
						missionClass.player = 3;
						if (208430 - 590589 == -382158)
						{
							continue;
						}
						missionClass.team = 1;
						if (81765 - 54990 != 26775)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (294591 - 340986 == -46394)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (2645 - 552138 == -549492)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (243546 - 455007 != -211461)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (138934 - 86895 != 52039)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (274897 - 546632 != -271735)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (250690 - 373833 == -123142)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (164679 - 132924 != 31755)
						{
							continue;
						}
					}
					else if (c == 805)
					{
						if (195568 - 67905 != 127663)
						{
							continue;
						}
						missionClass.name = "LightVault Cleaning";
						if (230969 - 266584 != -35615)
						{
							continue;
						}
						missionClass.des = "   วิหารลับใต้วังแสงกลายเป็นรังแมลง กระดาษไปซะแล้ว ได้เวลาทำความ สะอาดครั้งใหญ่แล้ว";
						if (1076 - 13766 != -12690)
						{
							continue;
						}
						missionClass.obj = "  ทำความสะอาดวิหารลับใต้วังแสง ด้วยการกำจัดเหล่าแมลงกระดาษทั้งหมด";
						if (86071 - 40453 != 45618)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (86119 - 349893 != -263774)
						{
							continue;
						}
						missionClass.lv = 47;
						if (46587 - 316599 != -270012)
						{
							continue;
						}
						missionClass.slv = 54;
						if (45615 - 23366 == 22250)
						{
							continue;
						}
						missionClass.player = 4;
						if (179811 - 506720 == -326908)
						{
							continue;
						}
						missionClass.team = 1;
						if (176736 - 328520 == -151783)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (269288 - 578294 != -309006)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (236818 - 283601 == -46782)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (247213 - 429935 == -182721)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (146232 - 27706 != 118526)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (298386 - 474481 == -176094)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (47657 - 105374 == -57716)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (18326 - 265056 == -246729)
						{
							continue;
						}
					}
					else if (c == 806)
					{
						if (100306 - 168011 != -67705)
						{
							continue;
						}
						missionClass.name = "Enlagea's Fragment";
						if (151333 - 55423 != 95910)
						{
							continue;
						}
						missionClass.des = "   ที่ใจกลางของวิหารลับใต้วังแสง เหล่าผู้กล้าพบปิศาจเงาที่บุกเข้ามาขโมย อะไรสักอย่าง";
						if (215248 - 104554 == 110695)
						{
							continue;
						}
						missionClass.obj = "  จัดการกับปิศาจเงาและลูกน้องทั้งหมด";
						if (108175 - 309471 == -201295)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (73040 - 56335 == 16706)
						{
							continue;
						}
						missionClass.lv = 48;
						if (214975 - 51770 != 163205)
						{
							continue;
						}
						missionClass.slv = 55;
						if (287128 - 494535 == -207406)
						{
							continue;
						}
						missionClass.player = 5;
						if (209219 - 237428 == -28208)
						{
							continue;
						}
						missionClass.team = 1;
						if (208699 - 165070 != 43629)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (78588 - 172149 == -93560)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (290854 - 462978 == -172123)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (273725 - 302107 == -28381)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (282782 - 432348 == -149565)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (66435 - 445680 == -379244)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (94329 - 561580 != -467251)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (35074 - 434962 == -399887)
						{
							continue;
						}
					}
					else if (c == 807)
					{
						if (36531 - 267417 != -230886)
						{
							continue;
						}
						missionClass.name = "Remnant Of Time";
						if (83355 - 140554 == -57198)
						{
							continue;
						}
						missionClass.des = "   วิหารลับใต้วังแสงมีแต่ของแปลกๆ จากอดีตเต็มไปหมด ลองไปสำรวจกันดีกว่า ว่าเกิดอะไรขึ้นในอดีต 5000 ปีก่อนกันแน่";
						if (189900 - 553320 != -363420)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (86044 - 321050 == -235005)
						{
							continue;
						}
						missionClass.lv = 0;
						if (229254 - 557481 != -328227)
						{
							continue;
						}
						missionClass.slv = 56;
						if (174021 - 216308 != -42287)
						{
							continue;
						}
						missionClass.player = 1;
						if (275152 - 308939 == -33786)
						{
							continue;
						}
						missionClass.team = 1;
						if (208305 - 11997 != 196308)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (80971 - 591506 == -510534)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (211181 - 124206 == 86976)
						{
							continue;
						}
					}
					else if (c == 808)
					{
						if (167186 - 338929 != -171743)
						{
							continue;
						}
						missionClass.name = "Monster Arena";
						if (44823 - 587475 == -542651)
						{
							continue;
						}
						missionClass.des = "  เมืองแสงจัดงานประลองกับพวก มอนสเตอร์ทั้งหลายแบบแพ้ คัดออก ทีมไหนล่ะจะสามารถสู้จนชนะ ทัวร์นาเม้น์นี้ได้";
						if (214169 - 261110 != -46941)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (232045 - 229246 != 2799)
						{
							continue;
						}
						missionClass.lv = 48;
						if (238108 - 50245 == 187864)
						{
							continue;
						}
						missionClass.slv = 57;
						if (9455 - 445999 == -436543)
						{
							continue;
						}
						missionClass.player = 3;
						if (267696 - 228474 == 39223)
						{
							continue;
						}
						missionClass.team = 1;
						if (160066 - 48601 != 111465)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (184149 - 403405 != -219256)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (155394 - 135602 == 19793)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (91170 - 62699 == 28472)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (34789 - 122227 != -87438)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (237885 - 396179 == -158293)
						{
							continue;
						}
						missionClass.mapName = "Colosseum";
						if (170759 - 406551 != -235792)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)371, (float)742);
						if (281809 - 505992 == -224182)
						{
							continue;
						}
					}
					else if (c == 901)
					{
						if (208415 - 337824 != -129409)
						{
							continue;
						}
						missionClass.name = "Burning Snow Forest";
						if (84933 - 114686 == -29752)
						{
							continue;
						}
						missionClass.des = "  พวกหุ่นยนต์ส่งหุ่นยนต์ไฟมาบุกป่าสนหิมะแล้ว ใครไปช่วยดับไฟที";
						if (213695 - 110449 != 103246)
						{
							continue;
						}
						missionClass.obj = "  จัดการกับหุ่นยนต์ไฟทั้งหมด 5 ตัว";
						if (56063 - 176935 == -120871)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (169372 - 16875 != 152497)
						{
							continue;
						}
						missionClass.lv = 49;
						if (238334 - 62291 != 176043)
						{
							continue;
						}
						missionClass.slv = 57;
						if (194776 - 249070 != -54294)
						{
							continue;
						}
						missionClass.player = 4;
						if (254322 - 493752 != -239430)
						{
							continue;
						}
						missionClass.team = 1;
						if (227334 - 122793 != 104541)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (26261 - 92950 != -66689)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (218694 - 538187 == -319492)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (232997 - 320681 != -87684)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (39891 - 294035 == -254143)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (186234 - 545755 == -359520)
						{
							continue;
						}
						missionClass.mapName = "Snow Pine Forest";
						if (105535 - 371651 == -266115)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)363, (float)340);
						if (241724 - 529479 != -287755)
						{
							continue;
						}
					}
					else if (c == 902)
					{
						if (2545 - 539276 != -536731)
						{
							continue;
						}
						missionClass.name = "Mad Vegetables";
						if (97859 - 114044 == -16184)
						{
							continue;
						}
						missionClass.des = "  ลุงแพะขอให้ท่านเร็กกุทำให้พวกผักแข็งแรงขึ้น เพื่อรับมือกับเหตุการณ์ข้างหน้า แต่ดูเหมือนท่านเร็กกุจะทำดีไปหน่อย";
						if (263065 - 440694 == -177628)
						{
							continue;
						}
						missionClass.obj = "  จับผักที่หนีไป 12 ตัวกลับมาให้ลุงแพะ";
						if (264596 - 516894 != -252298)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (130886 - 451500 == -320613)
						{
							continue;
						}
						missionClass.lv = 50;
						if (21660 - 582619 == -560958)
						{
							continue;
						}
						missionClass.slv = 58;
						if (38808 - 557761 == -518952)
						{
							continue;
						}
						missionClass.player = 3;
						if (247115 - 68454 != 178661)
						{
							continue;
						}
						missionClass.team = 1;
						if (202641 - 316798 == -114156)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (143255 - 327922 == -184666)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (156966 - 24692 == 132275)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (11297 - 4867 != 6430)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (235932 - 528596 == -292663)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (57509 - 206507 == -148997)
						{
							continue;
						}
						missionClass.mapName = "Sting Wood";
						if (14159 - 388694 != -374535)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)194, (float)573);
						if (125091 - 478552 == -353460)
						{
							continue;
						}
					}
					else if (c == 903)
					{
						if (106478 - 463997 != -357519)
						{
							continue;
						}
						missionClass.name = "Shadow Palace 1";
						if (292639 - 167860 == 124780)
						{
							continue;
						}
						missionClass.des = "  พวกผู้กล้าตามปิศาจเงาไปถึงวังเทพเซร่า แต่ดูเหมือนพวกลัทธิเงาจะไม่ให้ผ่าน ไปง่ายๆ ซะแล้ว";
						if (188352 - 360005 == -171652)
						{
							continue;
						}
						missionClass.obj = "  ฝ่าพวกลัทธิเงาไปจนถึงจุดหมายปลายทาง";
						if (130302 - 69357 == 60946)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (116727 - 325431 == -208703)
						{
							continue;
						}
						missionClass.lv = 51;
						if (140180 - 471865 == -331684)
						{
							continue;
						}
						missionClass.slv = 59;
						if (117535 - 537114 != -419579)
						{
							continue;
						}
						missionClass.player = 4;
						if (75709 - 163504 != -87795)
						{
							continue;
						}
						missionClass.team = 1;
						if (193551 - 119756 != 73795)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (266684 - 54528 == 212157)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (204897 - 516662 != -311765)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (220090 - 487829 != -267739)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (182800 - 214020 != -31220)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (10862 - 282611 != -271749)
						{
							continue;
						}
						missionClass.mapName = "Shadow Palace";
						if (96569 - 294849 != -198280)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)77, (float)569);
						if (182895 - 333581 != -150686)
						{
							continue;
						}
					}
					else if (c == 904)
					{
						if (293360 - 578137 != -284777)
						{
							continue;
						}
						missionClass.name = "Shadow Palace 2";
						if (165662 - 514871 != -349209)
						{
							continue;
						}
						missionClass.des = "   ปิศาจเงารู้ถึงการมาของพวกผู้กล้า ที่ตามมาถึงข้างในวังเทพเงาเซร่า จึงได้เตรียมแผนรับมือสุดโหดไว้";
						if (74406 - 224632 == -150225)
						{
							continue;
						}
						missionClass.obj = "  รอดจากกับดักของปิศาจเงาให้ได้";
						if (82526 - 325066 != -242540)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (20461 - 129502 == -109040)
						{
							continue;
						}
						missionClass.lv = 52;
						if (102056 - 547393 == -445336)
						{
							continue;
						}
						missionClass.slv = 60;
						if (229250 - 76852 != 152398)
						{
							continue;
						}
						missionClass.player = 5;
						if (275469 - 102342 != 173127)
						{
							continue;
						}
						missionClass.team = 1;
						if (117443 - 17036 == 100408)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (274463 - 114138 == 160326)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (182087 - 515362 == -333274)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (277258 - 290229 == -12970)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (295866 - 490833 != -194967)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (67932 - 28518 == 39415)
						{
							continue;
						}
						missionClass.mapName = "Shadow Palace";
						if (278033 - 50141 != 227892)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)77, (float)569);
						if (35203 - 582017 == -546813)
						{
							continue;
						}
					}
					else if (c == 905)
					{
						if (215393 - 588493 != -373100)
						{
							continue;
						}
						missionClass.name = "Darkness Within";
						if (254969 - 10890 != 244079)
						{
							continue;
						}
						missionClass.des = "  เหล่าผู้กล้าต้องพบกับบททดสอบที่แสนท้าทาย จากเทพเงาเซร่า ศึกครั้งนี้เหล่าผู้กล้าจะผ่านไปได้มั้ยนะ";
						if (200664 - 538295 == -337630)
						{
							continue;
						}
						missionClass.obj = "  จัดการกับร่างเงาของตัวเองทั้งหมด";
						if (258612 - 397941 != -139329)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (204431 - 10131 == 194301)
						{
							continue;
						}
						missionClass.lv = 53;
						if (240140 - 578497 != -338357)
						{
							continue;
						}
						missionClass.slv = 61;
						if (116763 - 572567 == -455803)
						{
							continue;
						}
						missionClass.player = 1;
						if (4560 - 287645 != -283085)
						{
							continue;
						}
						missionClass.team = 1;
						if (117764 - 163188 != -45424)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (155105 - 40336 != 114769)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (81150 - 62375 == 18776)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (97415 - 549642 != -452227)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (203715 - 581361 == -377645)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (98947 - 177363 == -78415)
						{
							continue;
						}
						missionClass.mapName = "Shadow Dimention";
						if (12210 - 88723 != -76513)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)77, (float)569);
						if (201962 - 592837 == -390874)
						{
							continue;
						}
					}
					else if (c == 906)
					{
						if (206926 - 391720 == -184793)
						{
							continue;
						}
						missionClass.name = "Shadow God Zera";
						if (201663 - 302791 != -101128)
						{
							continue;
						}
						missionClass.des = "  หลังจากบททดสอบอันยากลำบาก ก็ถึงเวลาตัดสินชะตากับเทพเงาเซร่า ในมิติแห่งเงาแล้ว";
						if (72559 - 78526 == -5966)
						{
							continue;
						}
						missionClass.obj = "  เอาชนะเทพเงาและนำชิ้นส่วนของเทพโบราณกลับมาให้ได้";
						if (65681 - 193644 == -127962)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (208276 - 550406 == -342129)
						{
							continue;
						}
						missionClass.lv = 54;
						if (31948 - 296860 == -264911)
						{
							continue;
						}
						missionClass.slv = 62;
						if (247283 - 496867 == -249583)
						{
							continue;
						}
						missionClass.player = 5;
						if (224730 - 269377 != -44647)
						{
							continue;
						}
						missionClass.team = 1;
						if (164806 - 65167 == 99640)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (181721 - 12919 == 168803)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (197068 - 448785 == -251716)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (193444 - 218359 != -24915)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (227888 - 569306 == -341417)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (7542 - 294632 != -287090)
						{
							continue;
						}
						missionClass.mapName = "Shadow Dimention";
						if (296703 - 316933 != -20230)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)77, (float)569);
						if (149893 - 591310 == -441416)
						{
							continue;
						}
					}
					else if (c == 907)
					{
						if (215011 - 331711 != -116700)
						{
							continue;
						}
						missionClass.name = "Zera's Hidden Plan";
						if (177098 - 563762 == -386663)
						{
							continue;
						}
						missionClass.des = "   ด้วยพลังจากชิ้นส่วนของเทพโบราณ พวกผู้กล้าก็สามารถพิชิตเทพเงาและ นำชิ้นส่วนกลับคืนมาได้ แต่จุดประสงค์ที่แท้จริงของเทพเงา คืออะไรกันแน่นะ?";
						if (218074 - 487693 == -269618)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (173429 - 338656 == -165226)
						{
							continue;
						}
						missionClass.lv = 0;
						if (203730 - 480719 != -276989)
						{
							continue;
						}
						missionClass.slv = 63;
						if (14458 - 256060 != -241602)
						{
							continue;
						}
						missionClass.player = 1;
						if (173304 - 102420 == 70885)
						{
							continue;
						}
						missionClass.team = 1;
						if (149371 - 590109 == -440737)
						{
							continue;
						}
						missionClass.mapName = "Shadow Dimention";
						if (192643 - 258588 == -65944)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)77, (float)569);
						if (90258 - 572576 != -482318)
						{
							continue;
						}
					}
					else if (c == 908)
					{
						if (121685 - 3486 == 118200)
						{
							continue;
						}
						missionClass.name = "Surprised Assault";
						if (202277 - 298944 != -96667)
						{
							continue;
						}
						missionClass.des = "    มิชชั่นพิเศษ สุ้เป็นทีม 4 ต่อ 4 ในทางวงกตปราสาทเงา";
						if (285678 - 443534 != -157856)
						{
							continue;
						}
						missionClass.obj = "  ล้มคู่ต่อสู้อีกทีมให้ได้แปดครั้ง";
						if (68569 - 571492 != -502923)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (101034 - 276854 != -175820)
						{
							continue;
						}
						missionClass.lv = 0;
						if (97012 - 448238 == -351225)
						{
							continue;
						}
						missionClass.slv = 64;
						if (148883 - 244970 == -96086)
						{
							continue;
						}
						missionClass.player = 8;
						if (284682 - 556562 == -271879)
						{
							continue;
						}
						missionClass.team = 2;
						if (228781 - 224017 != 4764)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (171018 - 309363 == -138344)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (216068 - 200514 == 15555)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (99955 - 552237 == -452281)
						{
							continue;
						}
						missionClass.allowRespawn = true;
						if (44647 - 110958 != -66311)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (91991 - 384332 == -292340)
						{
							continue;
						}
						missionClass.mapName = "Shadow Palace";
						if (215417 - 15267 == 200151)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)77, (float)569);
						if (231350 - 541885 == -310534)
						{
							continue;
						}
					}
					else if (c == 911)
					{
						if (281860 - 255159 != 26701)
						{
							continue;
						}
						missionClass.name = "Lavu Attack";
						if (297555 - 91391 == 206165)
						{
							continue;
						}
						missionClass.des = "  พวกผู้กล้าและแพนด้าแดงขนชิ้นส่วนของเทพโบราณ กลับเมืองแสงแต่ก็ต้องพบกับผู้เข้า ขัดขวางที่ไม่คาดฝัน";
						if (177590 - 139927 != 37663)
						{
							continue;
						}
						missionClass.obj = "  ปกป้องชิ้นส่วนของเทพโบราณกลับเมืองแสงอย่างปลอดภัย";
						if (264991 - 107760 != 157231)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (75134 - 381156 != -306022)
						{
							continue;
						}
						missionClass.lv = 55;
						if (108478 - 577540 == -469061)
						{
							continue;
						}
						missionClass.slv = 64;
						if (44295 - 573108 == -528812)
						{
							continue;
						}
						missionClass.player = 4;
						if (108805 - 67086 == 41720)
						{
							continue;
						}
						missionClass.team = 1;
						if (57454 - 399901 != -342447)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (247323 - 515552 == -268228)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (74772 - 320680 != -245908)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (210619 - 597202 != -386583)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (255335 - 445582 != -190247)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (68915 - 573172 == -504256)
						{
							continue;
						}
						missionClass.mapName = "Forked Wood";
						if (49327 - 239865 != -190538)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)524);
						if (245588 - 159898 != 85690)
						{
							continue;
						}
					}
					else if (c == 912)
					{
						if (284883 - 409081 != -124198)
						{
							continue;
						}
						missionClass.name = "Army Training";
						if (35482 - 83657 == -48174)
						{
							continue;
						}
						missionClass.des = "  เวลาของมหาสงครามใกล้เข้ามาแล้ว โบลดาสจึงให้พวกผู้กล้าช่วยฝึกทหาร ในการสู้รบจริง";
						if (13228 - 106876 != -93648)
						{
							continue;
						}
						missionClass.obj = "  สู้กับพวกทหารเสือโดยไม่ใช้สกิล และระวังไม่ให้ชาวบ้านที่มาฝึกบาดเจ็บ";
						if (86043 - 30735 != 55308)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (118328 - 185189 != -66861)
						{
							continue;
						}
						missionClass.lv = 56;
						if (216254 - 47508 != 168746)
						{
							continue;
						}
						missionClass.slv = 65;
						if (118040 - 342094 == -224053)
						{
							continue;
						}
						missionClass.player = 3;
						if (109503 - 545158 != -435655)
						{
							continue;
						}
						missionClass.team = 1;
						if (298403 - 94391 != 204012)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (20102 - 572871 == -552768)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (181549 - 416802 != -235253)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (8959 - 592495 == -583535)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (26955 - 134436 != -107481)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (18 - 45845 != -45827)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (260781 - 595487 != -334706)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (140116 - 556149 != -416033)
						{
							continue;
						}
					}
					else if (c == 913)
					{
						if (221209 - 180871 != 40338)
						{
							continue;
						}
						missionClass.name = "Carrier Site";
						if (2809 - 371042 != -368233)
						{
							continue;
						}
						missionClass.des = "  อิทารุสพบจุดจอดยานขนส่งของ พวกหุ่นยนต์หลายจุดใกล้เมืองแสง ใครบุกไปจัดการที";
						if (16661 - 83162 != -66501)
						{
							continue;
						}
						missionClass.obj = "  จัดการกับหนึ่งในยานขนส่ง เพื่อตัดกำลังรบของพวกหุ่่นยนต์";
						if (141950 - 470226 != -328276)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (98218 - 76005 == 22214)
						{
							continue;
						}
						missionClass.lv = 57;
						if (170069 - 156051 != 14018)
						{
							continue;
						}
						missionClass.slv = 66;
						if (32228 - 318940 == -286711)
						{
							continue;
						}
						missionClass.player = 3;
						if (78874 - 215618 == -136743)
						{
							continue;
						}
						missionClass.team = 1;
						if (242825 - 598261 == -355435)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (79671 - 141248 == -61576)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (15595 - 398798 != -383203)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (174203 - 560890 != -386687)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (273437 - 166980 == 106458)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (33982 - 223470 == -189487)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (28398 - 583948 != -555550)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (209558 - 278905 == -69346)
						{
							continue;
						}
					}
					else if (c == 914)
					{
						if (218673 - 366937 != -148264)
						{
							continue;
						}
						missionClass.name = "Guild Under Attack";
						if (146075 - 19915 == 126161)
						{
							continue;
						}
						missionClass.des = "  กิลด์กำลังโดนพวกหุ่นเข้าบุกยึดแล้ว รีบไปช่วยพวกชาวกิลด์เถอะ";
						if (9159 - 184239 != -175080)
						{
							continue;
						}
						missionClass.obj = "  ช่วยพวกชาวกิลด์และจัดการกับหุ่นทั้งหมด";
						if (279123 - 259056 != 20067)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (154852 - 38956 != 115896)
						{
							continue;
						}
						missionClass.lv = 58;
						if (164520 - 94132 == 70389)
						{
							continue;
						}
						missionClass.slv = 67;
						if (111548 - 568472 != -456924)
						{
							continue;
						}
						missionClass.player = 4;
						if (121265 - 431525 != -310260)
						{
							continue;
						}
						missionClass.team = 1;
						if (83107 - 573816 == -490708)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (173291 - 328555 != -155264)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (52158 - 446857 != -394699)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (257613 - 543099 == -285485)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (62064 - 174536 == -112471)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (111911 - 512156 == -400244)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (124174 - 476132 == -351957)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (24786 - 483231 == -458444)
						{
							continue;
						}
					}
					else if (c == 915)
					{
						if (206248 - 335380 == -129131)
						{
							continue;
						}
						missionClass.name = "Battle At the Great Plain";
						if (93401 - 66274 == 27128)
						{
							continue;
						}
						missionClass.des = "  กองทัพของพวกหุ่นกำลังจะปะทะกับกองทัพของโบลดาส ที่ทุ่งกว้าง สงครามแห่งประวัติศาสตร์กำลังจะเริ่มขึ้นแล้ว";
						if (48023 - 581610 == -533586)
						{
							continue;
						}
						missionClass.obj = "  ปกป้องพวกทหารและจัดการกับพวกหุ่นให้ได้มากที่สุด";
						if (115172 - 365746 != -250574)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (143470 - 88428 == 55043)
						{
							continue;
						}
						missionClass.lv = 59;
						if (44641 - 112844 != -68203)
						{
							continue;
						}
						missionClass.slv = 68;
						if (106219 - 441633 != -335414)
						{
							continue;
						}
						missionClass.player = 5;
						if (195673 - 534009 != -338336)
						{
							continue;
						}
						missionClass.team = 1;
						if (92761 - 81585 == 11177)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (74588 - 116010 == -41421)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (102667 - 206286 == -103618)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (31912 - 344305 != -312393)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (245587 - 37682 != 207905)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (249315 - 334722 != -85407)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (42650 - 30984 == 11667)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (296907 - 566040 == -269132)
						{
							continue;
						}
					}
					else if (c == 916)
					{
						if (223298 - 376201 == -152902)
						{
							continue;
						}
						missionClass.name = "City Under Siege";
						if (28347 - 459924 == -431576)
						{
							continue;
						}
						missionClass.des = "กองทัพหุ่นยนต์อีกกลุ่มหนึ่งได้เข้าโจมตีเมืองแสงอย่างเฉียบพลัน เหล่าชาวเมืองต่างออกมาต่อสู้ปกป้องประตูเมืองอย่างสุดชีวิต";
						if (265594 - 299095 == -33500)
						{
							continue;
						}
						missionClass.obj = "  ป้องกันประตูเมืองไว้ให้ได้";
						if (63346 - 477435 == -414088)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (152148 - 467920 == -315771)
						{
							continue;
						}
						missionClass.lv = 60;
						if (139760 - 220967 != -81207)
						{
							continue;
						}
						missionClass.slv = 69;
						if (77650 - 104445 != -26795)
						{
							continue;
						}
						missionClass.player = 4;
						if (95564 - 27523 == 68042)
						{
							continue;
						}
						missionClass.team = 1;
						if (276299 - 510223 != -233924)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (10263 - 504843 == -494579)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (166181 - 349551 != -183370)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (33458 - 543621 == -510162)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (295473 - 322592 == -27118)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (176213 - 270475 != -94262)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (50234 - 184808 != -134574)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (188865 - 236434 == -47568)
						{
							continue;
						}
					}
					else if (c == 917)
					{
						if (253814 - 95784 != 158030)
						{
							continue;
						}
						missionClass.name = "War Repose";
						if (9866 - 238028 == -228161)
						{
							continue;
						}
						missionClass.des = "      ศึกที่ทุ่งแห่งแสงได้สร้างความสูญเสียให้กับชาวเมือง แสงเป็นอย่างมาก เหล่าเทพได้ผนึกกำลังกับเหล่า สัตว์หางเพื่อดำเนินแผนการทำสงครามกับพวกหุ่นยนต์ ก่อนที่ทุกอย่างจะสายเกินแก้";
						if (277576 - 449316 != -171740)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (288592 - 579761 != -291169)
						{
							continue;
						}
						missionClass.lv = 0;
						if (135370 - 384962 != -249592)
						{
							continue;
						}
						missionClass.slv = 70;
						if (241017 - 372451 != -131434)
						{
							continue;
						}
						missionClass.player = 1;
						if (295860 - 248186 == 47675)
						{
							continue;
						}
						missionClass.team = 1;
						if (267284 - 387994 != -120710)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (40536 - 256738 != -216202)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (39437 - 434952 != -395515)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (92037 - 204011 != -111974)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (250778 - 498060 == -247281)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (79783 - 248955 != -169172)
						{
							continue;
						}
						missionClass.mapName = "Alcacia Palace";
						if (292660 - 49773 != 242887)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)317, (float)588);
						if (101577 - 176882 != -75305)
						{
							continue;
						}
					}
					else if (c == 918)
					{
						if (287857 - 495045 != -207188)
						{
							continue;
						}
						missionClass.name = "Decathlon";
						if (269307 - 25935 == 243373)
						{
							continue;
						}
						missionClass.des = "  งานแข่งกีฬาสีฮาเฮ ประกอบ ด้วยเกมหลากหลายประเภทที่ต้อง พึ่งพาทักษะของสัตว์หางทุกตัว";
						if (135855 - 559517 == -423661)
						{
							continue;
						}
						missionClass.obj = "  ชนะฝ่ายตรงข้ามให้ได้ 3 เกม";
						if (149547 - 292305 == -142757)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (262682 - 278748 == -16065)
						{
							continue;
						}
						missionClass.lv = 0;
						if (242386 - 39073 != 203313)
						{
							continue;
						}
						missionClass.slv = 71;
						if (251852 - 396425 == -144572)
						{
							continue;
						}
						missionClass.player = 6;
						if (142102 - 596262 != -454160)
						{
							continue;
						}
						missionClass.team = 2;
						if (38196 - 186770 == -148573)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (1358 - 525052 != -523694)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (110957 - 60911 == 50047)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (149151 - 210210 != -61059)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (207130 - 587620 != -380490)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (229763 - 281116 == -51352)
						{
							continue;
						}
						missionClass.mapName = "Guild";
						if (51343 - 252015 == -200671)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)248, (float)690);
						if (97149 - 582653 != -485504)
						{
							continue;
						}
					}
					else if (c == 921)
					{
						if (83658 - 78209 != 5449)
						{
							continue;
						}
						missionClass.name = "Ancient Forest";
						if (112265 - 11163 == 101103)
						{
							continue;
						}
						missionClass.des = "  โบลดาสต้องการให้พวกฮีโร่ ออกไปสำรวจป่าโบราณของเทพดิน เพื่อเปิดเสามานารอบๆ แคมป์";
						if (144056 - 151106 != -7050)
						{
							continue;
						}
						missionClass.obj = "  สำรวจป่าของเทพดินให้ทั่ว และเปิดเสามานาให้มากที่สุด";
						if (60390 - 84931 == -24540)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (196004 - 501565 != -305561)
						{
							continue;
						}
						missionClass.lv = 61;
						if (270591 - 186681 == 83911)
						{
							continue;
						}
						missionClass.slv = 71;
						if (169767 - 174921 != -5154)
						{
							continue;
						}
						missionClass.player = 4;
						if (276913 - 334814 == -57900)
						{
							continue;
						}
						missionClass.team = 1;
						if (111831 - 505060 != -393229)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (52150 - 69015 != -16865)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (282570 - 521948 == -239377)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (252455 - 87342 == 165114)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (17095 - 427361 == -410265)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (245634 - 256515 != -10881)
						{
							continue;
						}
						missionClass.mapName = "Ancient Forest";
						if (44682 - 99588 == -54905)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)524);
						if (47610 - 21499 != 26111)
						{
							continue;
						}
					}
					else if (c == 922)
					{
						if (145376 - 192105 != -46729)
						{
							continue;
						}
						missionClass.name = "Dancing of the Hippos";
						if (2045 - 42966 == -40920)
						{
							continue;
						}
						missionClass.des = "  เพื่อช่วยกองทัพของเทพแสงจัดการกับพวกหุ่น พวกฮิปโปจึงพิธีอัญเชิญเทพดินมาที่แคมป์";
						if (168695 - 284951 != -116256)
						{
							continue;
						}
						missionClass.obj = "  ช่วยพวกฮิปโปกดปุ่มเต้นตามลำดับให้ถูกต้อง";
						if (108661 - 271263 != -162602)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (102864 - 450116 != -347252)
						{
							continue;
						}
						missionClass.lv = 62;
						if (102174 - 135132 == -32957)
						{
							continue;
						}
						missionClass.slv = 72;
						if (143579 - 408763 != -265184)
						{
							continue;
						}
						missionClass.player = 4;
						if (128288 - 141442 != -13154)
						{
							continue;
						}
						missionClass.team = 1;
						if (127240 - 473412 != -346172)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (89857 - 304100 == -214242)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (50526 - 27375 != 23151)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (114053 - 389395 == -275341)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (285235 - 20149 != 265086)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (181384 - 218272 != -36888)
						{
							continue;
						}
						missionClass.mapName = "Ancient Forest";
						if (127902 - 430914 != -303012)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)524);
						if (281697 - 437437 != -155740)
						{
							continue;
						}
					}
					else if (c == 923)
					{
						if (132526 - 333641 != -201115)
						{
							continue;
						}
						missionClass.name = "War in the Forest";
						if (101735 - 337736 == -236000)
						{
							continue;
						}
						missionClass.des = "  พวกหุ่นแบบใหม่เข้าโจมตีแคมป์ของกองทัพแสง ใครช่วยไปจัดการมันก่อนจะมาถึงแคมป์ที";
						if (32915 - 470823 != -437908)
						{
							continue;
						}
						missionClass.obj = "  จัดการกับมิซไซล์บอทให้มากที่สุด";
						if (292357 - 201612 != 90745)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (48810 - 5372 != 43438)
						{
							continue;
						}
						missionClass.lv = 63;
						if (90351 - 196308 == -105956)
						{
							continue;
						}
						missionClass.slv = 73;
						if (233883 - 167157 == 66727)
						{
							continue;
						}
						missionClass.player = 5;
						if (273556 - 327500 == -53943)
						{
							continue;
						}
						missionClass.team = 1;
						if (105081 - 475223 == -370141)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (103880 - 212682 != -108802)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (576 - 263730 != -263154)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (57483 - 520568 != -463085)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (299601 - 384501 != -84900)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (28472 - 376196 != -347724)
						{
							continue;
						}
						missionClass.mapName = "Ancient Forest";
						if (36549 - 207538 == -170988)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)524);
						if (287629 - 247446 != 40183)
						{
							continue;
						}
					}
					else if (c == 924)
					{
						if (205548 - 502413 == -296864)
						{
							continue;
						}
						missionClass.name = "Lost Woods";
						if (275172 - 268494 == 6679)
						{
							continue;
						}
						missionClass.des = "  อยู่ๆ นิโค่ก็หายไปจากแคมป์ในป่า ทุกคนช่วยกันตามหาที";
						if (47993 - 152751 == -104757)
						{
							continue;
						}
						missionClass.obj = "  ตามหานิโค่ในป่าลึกให้เจอ";
						if (126604 - 541242 == -414637)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (74434 - 64309 != 10125)
						{
							continue;
						}
						missionClass.lv = 64;
						if (202223 - 415696 != -213473)
						{
							continue;
						}
						missionClass.slv = 74;
						if (178239 - 427101 == -248861)
						{
							continue;
						}
						missionClass.player = 3;
						if (154910 - 514980 != -360070)
						{
							continue;
						}
						missionClass.team = 1;
						if (268445 - 536716 != -268271)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (76295 - 120453 != -44158)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (104356 - 484982 == -380625)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (214989 - 318924 != -103935)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (239123 - 494369 == -255245)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (225287 - 241949 != -16662)
						{
							continue;
						}
						missionClass.mapName = "Lost Woods";
						if (47454 - 70643 != -23189)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)504);
						if (190006 - 298710 != -108704)
						{
							continue;
						}
					}
					else if (c == 925)
					{
						if (252223 - 246936 == 5288)
						{
							continue;
						}
						missionClass.name = "Wrath of Titan";
						if (297640 - 569472 != -271832)
						{
							continue;
						}
						missionClass.des = "  พวกทหารพบเทพดินที่ป่าทางเหนือแล้ว แต่ดูเหมือนท่านบาเบร๊อค จะโกรธพวกหุ่นมากจนไม่ฟังอะไรเลย";
						if (273430 - 577498 == -304067)
						{
							continue;
						}
						missionClass.obj = "  ติดตามเฝ้าเทพดินบาเบร๊อคไปให้สุดทาง";
						if (76766 - 124228 != -47462)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (34565 - 192409 != -157844)
						{
							continue;
						}
						missionClass.lv = 65;
						if (224961 - 200705 == 24257)
						{
							continue;
						}
						missionClass.slv = 75;
						if (291335 - 589698 != -298363)
						{
							continue;
						}
						missionClass.player = 3;
						if (198447 - 327873 != -129426)
						{
							continue;
						}
						missionClass.team = 1;
						if (127182 - 283017 != -155835)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (135048 - 88714 != 46334)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (150874 - 65842 == 85033)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (228476 - 436230 != -207754)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (105122 - 79330 == 25793)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (251827 - 106353 != 145474)
						{
							continue;
						}
						missionClass.mapName = "North Woods";
						if (71720 - 487121 != -415401)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)484);
						if (62619 - 350444 != -287825)
						{
							continue;
						}
					}
					else if (c == 926)
					{
						if (101851 - 58258 != 43593)
						{
							continue;
						}
						missionClass.name = "When the Wind Stops";
						if (141551 - 228061 != -86510)
						{
							continue;
						}
						missionClass.des = "  พวกฮีโร่ตามเทพดินที่บุกไปถล่มพวก หุ่นยนต์ที่ป่าทางเหนือ และได้พบ กับอะไรที่ไม่คาดคิด";
						if (55113 - 12549 != 42564)
						{
							continue;
						}
						missionClass.obj = "  ป้องกันเทพลมให้ได้สิบนาที";
						if (212092 - 386580 == -174487)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (282619 - 389768 == -107148)
						{
							continue;
						}
						missionClass.lv = 66;
						if (267431 - 180736 != 86695)
						{
							continue;
						}
						missionClass.slv = 76;
						if (165603 - 451877 != -286274)
						{
							continue;
						}
						missionClass.player = 5;
						if (205327 - 391975 == -186647)
						{
							continue;
						}
						missionClass.team = 1;
						if (298654 - 531542 == -232887)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (207871 - 370811 != -162940)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (286950 - 200975 == 85976)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (17399 - 40787 == -23387)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (271101 - 78424 != 192677)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (298883 - 412257 == -113373)
						{
							continue;
						}
						missionClass.mapName = "North Woods";
						if (222558 - 84303 == 138256)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)484);
						if (211721 - 218148 != -6427)
						{
							continue;
						}
					}
					else if (c == 927)
					{
						if (56001 - 452134 != -396133)
						{
							continue;
						}
						missionClass.name = "Silence Earth";
						if (234797 - 398803 == -164005)
						{
							continue;
						}
						missionClass.des = "   เทพลม เทพดินและพวกฮีโร่ ตกอยู่ในวงล้อมของกองทัพหุ่นยนต์ ที่หนุนเนื่องเข้ามาอย่างไม่มีที่สิ้นสุด หรือว่านี้คือจุดสิ้นสุดของการเดินทาง!?";
						if (151124 - 398534 == -247409)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (19362 - 144152 == -124789)
						{
							continue;
						}
						missionClass.lv = 0;
						if (274009 - 502524 != -228515)
						{
							continue;
						}
						missionClass.slv = 77;
						if (95106 - 100007 != -4901)
						{
							continue;
						}
						missionClass.player = 1;
						if (194244 - 429751 != -235507)
						{
							continue;
						}
						missionClass.team = 1;
						if (217886 - 56187 != 161699)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (43148 - 557299 == -514150)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (154260 - 94312 == 59949)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (43206 - 420447 != -377241)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (208123 - 225132 == -17008)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (113213 - 62080 != 51133)
						{
							continue;
						}
						missionClass.mapName = "North Woods";
						if (165091 - 117884 == 47208)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)484);
						if (134494 - 586657 != -452163)
						{
							continue;
						}
					}
					else if (c == 928)
					{
						if (88949 - 72538 != 16411)
						{
							continue;
						}
						missionClass.name = "Jungle Hunt";
						if (125817 - 62772 != 63045)
						{
							continue;
						}
						missionClass.des = "  มาปลุกสัญชาติญาณดิบแห่งพงไพร เพื่อฝึกไล่ล่าในป่าใหญ่กันดีกว่า";
						if (265899 - 233451 != 32448)
						{
							continue;
						}
						missionClass.obj = "  แข่งกันล้มคู่ต่อสู้ให้ครบ 12 ครั้ง";
						if (42547 - 570108 == -527560)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (112325 - 34617 == 77709)
						{
							continue;
						}
						missionClass.lv = 0;
						if (217948 - 97840 == 120109)
						{
							continue;
						}
						missionClass.slv = 78;
						if (138080 - 42154 == 95927)
						{
							continue;
						}
						missionClass.player = 8;
						if (229903 - 38122 != 191781)
						{
							continue;
						}
						missionClass.team = 4;
						if (215726 - 10404 != 205322)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (168188 - 313294 == -145105)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (117110 - 467758 == -350647)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (240055 - 501689 == -261633)
						{
							continue;
						}
						missionClass.allowRespawn = true;
						if (173770 - 370771 != -197001)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (113842 - 419139 == -305296)
						{
							continue;
						}
						missionClass.mapName = "Lost Woods";
						if (148893 - 123511 != 25382)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)504);
						if (6759 - 21397 == -14637)
						{
							continue;
						}
					}
					else if (c == 931)
					{
						if (64001 - 52830 != 11171)
						{
							continue;
						}
						missionClass.name = "I am no knight";
						if (221756 - 227502 == -5745)
						{
							continue;
						}
						missionClass.des = "  พวกแมลงบุกเข้ามาทำรังในวังไข่มุก ขณะที่เทพน้ำไม่อยู่กันใหญ่แล้ว ใครช่วยปกป้องวังของเทพน้ำที";
						if (298981 - 356846 == -57864)
						{
							continue;
						}
						missionClass.obj = "  ช่วยลูกๆ แอมโมไนท์ กำจัดแมลงที่บุกเข้ามาให้หมด";
						if (104314 - 404068 == -299753)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (140867 - 149067 == -8199)
						{
							continue;
						}
						missionClass.lv = 67;
						if (45114 - 580281 != -535167)
						{
							continue;
						}
						missionClass.slv = 78;
						if (282903 - 103197 == 179707)
						{
							continue;
						}
						missionClass.player = 4;
						if (202278 - 48657 == 153622)
						{
							continue;
						}
						missionClass.team = 1;
						if (214197 - 582631 == -368433)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (11250 - 598152 != -586902)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (33430 - 510363 != -476933)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (61911 - 38385 != 23526)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (208576 - 81424 != 127152)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (100132 - 14672 == 85461)
						{
							continue;
						}
						missionClass.mapName = "Anemone Palace";
						if (202948 - 246902 != -43954)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)732, (float)730);
						if (220931 - 235613 == -14681)
						{
							continue;
						}
					}
					else if (c == 932)
					{
						if (104546 - 524379 != -419833)
						{
							continue;
						}
						missionClass.name = "Wind's Hollow";
						if (199602 - 150069 != 49533)
						{
							continue;
						}
						missionClass.des = " เพื่อรักษาซันซัน เหล่าผู้กล้าได้เดินทางมาค้นหา ผลึกมานาแห่งลม ตามคำแนะนำของเรกกุ";
						if (276191 - 524086 == -247894)
						{
							continue;
						}
						missionClass.obj = "  ฝ่าฝูงแมลงเพื่อเข้าไปเอาผลึกมานาแห่งลม";
						if (73302 - 380391 != -307089)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (14636 - 213106 != -198470)
						{
							continue;
						}
						missionClass.lv = 68;
						if (280244 - 21003 != 259241)
						{
							continue;
						}
						missionClass.slv = 79;
						if (254024 - 49433 == 204592)
						{
							continue;
						}
						missionClass.player = 2;
						if (79233 - 448208 != -368975)
						{
							continue;
						}
						missionClass.team = 1;
						if (232112 - 232746 == -633)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (41101 - 248924 == -207822)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (275981 - 222029 == 53953)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (179354 - 289299 != -109945)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (275520 - 52811 != 222709)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (41422 - 98579 == -57156)
						{
							continue;
						}
						missionClass.mapName = "Gao Desert";
						if (276429 - 35477 == 240953)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)607, (float)422);
						if (150208 - 270318 == -120109)
						{
							continue;
						}
					}
					else if (c == 933)
					{
						if (165655 - 239707 == -74051)
						{
							continue;
						}
						missionClass.name = "Magma Pit";
						if (52334 - 295526 != -243192)
						{
							continue;
						}
						missionClass.des = "  เพื่อเตรียมตัวกับศึกหนักข้างหน้า เทพไฟ จึงเปิดให้เหล่าฮีโร่ลงไปใน ส่วนลึกของภูเขาไฟ";
						if (222951 - 504893 == -281941)
						{
							continue;
						}
						missionClass.obj = "  ปราบกาออสและสะสมแร่สำหรับทำ อาวุธให้ได้มากที่สุด";
						if (154660 - 132447 == 22214)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (202636 - 597473 != -394837)
						{
							continue;
						}
						missionClass.lv = 69;
						if (103649 - 375115 != -271466)
						{
							continue;
						}
						missionClass.slv = 80;
						if (20528 - 515735 == -495206)
						{
							continue;
						}
						missionClass.player = 4;
						if (186570 - 399167 == -212596)
						{
							continue;
						}
						missionClass.team = 1;
						if (178379 - 408119 == -229739)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (228373 - 542860 == -314486)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (11558 - 481613 == -470054)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (68152 - 500822 != -432670)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (57381 - 176850 != -119469)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (77287 - 468999 != -391712)
						{
							continue;
						}
						missionClass.mapName = "Fire Cave";
						if (255006 - 10633 == 244374)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)258, (float)333);
						if (259415 - 518691 == -259275)
						{
							continue;
						}
					}
					else if (c == 934)
					{
						if (293277 - 506051 != -212774)
						{
							continue;
						}
						missionClass.name = "Lady Noir's Dark Ritual";
						if (144702 - 369232 == -224529)
						{
							continue;
						}
						missionClass.des = "  กลุ่มลัทธิเงาที่เชื่อว่าเซร่ายังไม่ตาย ได้รวมตัวกัน ทำพิธีอะไรบางอย่าอยู่ ใครช่วยไปตรวจดูที";
						if (10272 - 389961 == -379688)
						{
							continue;
						}
						missionClass.obj = "  หยุดพิธีกรรมของเลดี้นัวร์หัวหน้ากลุ่มลัทธิเงาให้ได้";
						if (201257 - 305486 == -104228)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (57518 - 263439 == -205920)
						{
							continue;
						}
						missionClass.lv = 70;
						if (152014 - 59589 == 92426)
						{
							continue;
						}
						missionClass.slv = 81;
						if (223923 - 599107 == -375183)
						{
							continue;
						}
						missionClass.player = 3;
						if (68872 - 81384 != -12512)
						{
							continue;
						}
						missionClass.team = 1;
						if (296262 - 557112 == -260849)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (6948 - 310110 == -303161)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (194285 - 486599 != -292314)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (153099 - 277337 != -124238)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (184567 - 130052 == 54516)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (28717 - 297690 != -268973)
						{
							continue;
						}
						missionClass.mapName = "Shadow Palace";
						if (291161 - 555173 != -264012)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)77, (float)569);
						if (12513 - 208273 != -195760)
						{
							continue;
						}
					}
					else if (c == 935)
					{
						if (201157 - 481017 == -279859)
						{
							continue;
						}
						missionClass.name = "Tormented Woods";
						if (211126 - 88324 == 122803)
						{
							continue;
						}
						missionClass.des = "  เมื่อเทพดินไม่อยู่ เขตป่าทางเหนือกำลังถูกทำลาย โดยพวกธาตุเน่าเสียที่แพร่กระจายไปทั่ว";
						if (14318 - 570352 == -556033)
						{
							continue;
						}
						missionClass.obj = "  จัดการกับพวก FoulElement และหยุดยั้ง EarthAvatar ให้ได้";
						if (105280 - 349303 != -244023)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (93899 - 449032 != -355133)
						{
							continue;
						}
						missionClass.lv = 71;
						if (290239 - 381950 == -91710)
						{
							continue;
						}
						missionClass.slv = 82;
						if (231719 - 253206 != -21487)
						{
							continue;
						}
						missionClass.player = 5;
						if (124611 - 262667 == -138055)
						{
							continue;
						}
						missionClass.team = 1;
						if (5656 - 458738 == -453081)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (263788 - 285288 == -21499)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (155241 - 396493 == -241251)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (247777 - 339519 == -91741)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (125121 - 467984 == -342862)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (24847 - 201382 != -176535)
						{
							continue;
						}
						missionClass.mapName = "Lost Woods";
						if (231827 - 184618 != 47209)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)436, (float)504);
						if (85079 - 39105 == 45975)
						{
							continue;
						}
					}
					else if (c == 936)
					{
						if (61207 - 419817 == -358609)
						{
							continue;
						}
						missionClass.name = "Crossing Destiny";
						if (136450 - 358710 != -222260)
						{
							continue;
						}
						missionClass.des = "  กองทัพเมืองแสงตามเทพดินที่ถูกจับไป จนถึงรอย แตกของโลก พวกฮีโร่เดินทางมาถึงจุดตัดสินชะตา ครั้งสำคัญแล้ว";
						if (105821 - 411055 != -305234)
						{
							continue;
						}
						missionClass.obj = "  ข้ามรอยแตกของโลกไปให้ได้";
						if (150204 - 444158 == -293953)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (119263 - 301244 == -181980)
						{
							continue;
						}
						missionClass.lv = 72;
						if (72256 - 275954 == -203697)
						{
							continue;
						}
						missionClass.slv = 83;
						if (247477 - 401079 != -153602)
						{
							continue;
						}
						missionClass.player = 5;
						if (256842 - 287009 == -30166)
						{
							continue;
						}
						missionClass.team = 1;
						if (194 - 436234 != -436040)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (20508 - 161008 == -140499)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (28033 - 15940 != 12093)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (203795 - 512241 != -308446)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (242598 - 216171 != 26427)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (155110 - 245881 != -90771)
						{
							continue;
						}
						missionClass.mapName = "Great Divide";
						if (291156 - 372504 != -81348)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)585, (float)299);
						if (23666 - 180536 != -156870)
						{
							continue;
						}
					}
					else if (c == 937)
					{
						if (202182 - 127360 != 74822)
						{
							continue;
						}
						missionClass.name = "Battle for Tomorrow";
						if (287548 - 230163 == 57386)
						{
							continue;
						}
						missionClass.des = "   พวกฮีโร่ต้องสู้กับอิทาลุสที่เข้ามาขัดขวางบนสะพาน สายลมที่เชื่อมต่อไปยังอีกฝั่งของโลก การต่อสู้เพื่อ วันพรุ่งนี้ ได้มาถึงตอนจบแล้ว";
						if (242816 - 463739 != -220923)
						{
							continue;
						}
						missionClass.type = eMissionType.@event;
						if (32306 - 176102 == -143795)
						{
							continue;
						}
						missionClass.lv = 0;
						if (188946 - 117004 == 71943)
						{
							continue;
						}
						missionClass.slv = 84;
						if (209735 - 480079 == -270343)
						{
							continue;
						}
						missionClass.player = 1;
						if (94750 - 96013 != -1263)
						{
							continue;
						}
						missionClass.team = 1;
						if (238295 - 184676 == 53620)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (186986 - 354179 != -167193)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (150214 - 225641 != -75427)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (124266 - 367264 == -242997)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (290105 - 472824 != -182719)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (2789 - 315933 != -313144)
						{
							continue;
						}
						missionClass.mapName = "Great Divide";
						if (196971 - 378175 != -181204)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)585, (float)299);
						if (155185 - 311910 == -156724)
						{
							continue;
						}
					}
					else if (c == 938)
					{
						if (132832 - 340486 != -207654)
						{
							continue;
						}
						missionClass.name = "Time's Memories";
						if (144892 - 465392 != -320500)
						{
							continue;
						}
						missionClass.des = "   เพื่อเตรียมพร้อมสำหรับอนาคต เทพแสงจึงให้ เร็กกุเปิดประตูแสง พาผู้กล้าไปพบกับปริศนาแห่ง ห้วงกาลเวลา";
						if (151763 - 511370 == -359606)
						{
							continue;
						}
						missionClass.obj = "  พิสูจน์ความสามารถที่แท้จริง ด้วยการ เอาชนะบอสทั้งหมดให้ได้";
						if (92791 - 462462 != -369671)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (168033 - 422269 == -254235)
						{
							continue;
						}
						missionClass.lv = 72;
						if (146795 - 560211 != -413416)
						{
							continue;
						}
						missionClass.slv = 84;
						if (119069 - 132825 == -13755)
						{
							continue;
						}
						missionClass.player = 5;
						if (107299 - 541005 != -433706)
						{
							continue;
						}
						missionClass.team = 1;
						if (165894 - 396064 != -230170)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (142899 - 275436 != -132537)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (45411 - 506874 == -461462)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (71744 - 63602 != 8142)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (138359 - 331671 != -193312)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (159442 - 280808 != -121366)
						{
							continue;
						}
						missionClass.mapName = "Alcacia Palace";
						if (234956 - 127029 != 107927)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)317, (float)588);
						if (79669 - 271597 == -191927)
						{
							continue;
						}
					}
					else if (c == 941)
					{
						if (99359 - 578000 != -478641)
						{
							continue;
						}
						missionClass.name = "Lightning in the Sky";
						if (42389 - 139374 != -96985)
						{
							continue;
						}
						missionClass.des = "     แมลงสกายบั๊กที่ชอบมาพร้อมกับสายฟ้า ย้ายมา อยู่ใกล้ๆ เมืองแสง ทำให้มีชาวบ้านโดนฟ้าผ่าเป็นสิบๆ รายแล้ว ใครก็ได้ไปช่วยไล่มันที";
						if (684 - 162262 == -161577)
						{
							continue;
						}
						missionClass.obj = "     ปราบแมลงสกายบั๊ก เพื่อทำให้ท้องฟ้าสงบ";
						if (136426 - 524955 != -388529)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (258732 - 595867 == -337134)
						{
							continue;
						}
						missionClass.lv = 24;
						if (219329 - 110991 != 108338)
						{
							continue;
						}
						missionClass.slv = 24;
						if (90127 - 441924 == -351796)
						{
							continue;
						}
						missionClass.player = 12;
						if (64788 - 148110 == -83321)
						{
							continue;
						}
						missionClass.team = 1;
						if (87750 - 128962 != -41212)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (120328 - 92827 != 27501)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (4702 - 46841 == -42138)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (231953 - 512007 != -280054)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (296565 - 150141 == 146425)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (239275 - 444676 == -205400)
						{
							continue;
						}
						missionClass.mapName = "Flower Field";
						if (193234 - 65859 != 127375)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)378, (float)631);
						if (136470 - 580210 == -443739)
						{
							continue;
						}
					}
					else if (c == 942)
					{
						if (193249 - 268564 == -75314)
						{
							continue;
						}
						missionClass.name = "Crystal Gorge";
						if (57395 - 401731 != -344336)
						{
							continue;
						}
						missionClass.des = "     โบลดาสต้องการกิลด์ไปช่วยปราบแมลงคริสตัล ตัวการที่ทำให้เกิดภูเขาถล่มบ่อยๆในช่วงนี้  ว่ากันว่า พวกมันหลบอยู่ใต้เหวน้ำแข็ง";
						if (215302 - 201334 == 13969)
						{
							continue;
						}
						missionClass.obj = "     ปราบแมลงคริสตัลทั้งสี่ตัวให้ได้";
						if (26746 - 250398 != -223652)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (142747 - 584523 == -441775)
						{
							continue;
						}
						missionClass.lv = 30;
						if (140651 - 299475 == -158823)
						{
							continue;
						}
						missionClass.slv = 30;
						if (177191 - 454287 != -277096)
						{
							continue;
						}
						missionClass.player = 12;
						if (107090 - 254163 != -147073)
						{
							continue;
						}
						missionClass.team = 1;
						if (123791 - 77102 == 46690)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (279231 - 343305 != -64074)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (286015 - 81582 != 204433)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (257042 - 397289 == -140246)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (54798 - 177864 != -123066)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (197829 - 339132 != -141303)
						{
							continue;
						}
						missionClass.mapName = "Snow Mount Gorge";
						if (177674 - 436749 != -259075)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)249, (float)375);
						if (37578 - 211853 != -174275)
						{
							continue;
						}
					}
					else if (c == 943)
					{
						if (135930 - 515099 == -379168)
						{
							continue;
						}
						missionClass.name = "Ancient Bug";
						if (13147 - 328600 != -315453)
						{
							continue;
						}
						missionClass.des = "    แมลงโบราณจอมทำลายล้าง ที่ถูกสะกดให้หลับอยู่ ข้างใต้หุบเขาสายลมได้ตื่นขึ้นมาแล้ว";
						if (22085 - 507074 == -484988)
						{
							continue;
						}
						missionClass.obj = "    ปราบแมลงโบราณให้ได้ก่อนที่มันจะฟื้นตัวเต็มที่";
						if (100666 - 309203 != -208537)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (232754 - 388413 != -155659)
						{
							continue;
						}
						missionClass.lv = 36;
						if (69884 - 44220 == 25665)
						{
							continue;
						}
						missionClass.slv = 36;
						if (80110 - 250680 == -170569)
						{
							continue;
						}
						missionClass.player = 12;
						if (62947 - 345029 != -282082)
						{
							continue;
						}
						missionClass.team = 1;
						if (108504 - 521120 == -412615)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (239253 - 95600 != 143653)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (281992 - 268589 == 13404)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (213320 - 202797 == 10524)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (46869 - 501539 != -454670)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (144583 - 394990 != -250407)
						{
							continue;
						}
						missionClass.mapName = "Wind Valley - Outer -";
						if (46115 - 214086 != -167971)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)672, (float)447);
						if (178645 - 261851 != -83206)
						{
							continue;
						}
					}
					else if (c == 944)
					{
						if (70886 - 97871 != -26985)
						{
							continue;
						}
						missionClass.name = "Withering Coral Reef";
						if (266454 - 121754 != 144700)
						{
							continue;
						}
						missionClass.des = "     สารแปลกปลอมที่ตกค้างในทะเลทำให้เกิดแมลง จ้าวปะการังยักษ์ขึ้นมา ถ้าปล่อยไว้ปะการังโดยรอบ จะโดนแย่งอาหารไปจนหมด";
						if (214254 - 400785 == -186530)
						{
							continue;
						}
						missionClass.obj = "     จัดการกับจ้าวปะการังให้ได้";
						if (224077 - 403487 == -179409)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (83610 - 177085 == -93474)
						{
							continue;
						}
						missionClass.lv = 42;
						if (107111 - 500378 != -393267)
						{
							continue;
						}
						missionClass.slv = 42;
						if (45225 - 175928 != -130703)
						{
							continue;
						}
						missionClass.player = 12;
						if (5320 - 374986 == -369665)
						{
							continue;
						}
						missionClass.team = 1;
						if (143891 - 106085 == 37807)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (143683 - 181127 == -37443)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (102284 - 478874 == -376589)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (27996 - 5561 != 22435)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (174911 - 367655 == -192743)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (157147 - 6151 == 150997)
						{
							continue;
						}
						missionClass.mapName = "Southern Coral Reef";
						if (171169 - 523038 == -351868)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)191, (float)837);
						if (16281 - 61299 == -45017)
						{
							continue;
						}
					}
					else if (c == 945)
					{
						if (90280 - 240104 != -149824)
						{
							continue;
						}
						missionClass.name = "Trampling MokBug";
						if (203074 - 413430 == -210355)
						{
							continue;
						}
						missionClass.des = "   แมลงม๊อกบั๊กยักษ์ตื่นหนีมาจากเขต ป่าโบราณของเทพดินจากทางเหนือ ใครไปช่วยหยุดพวกมันก่อนเมืองแสงจะโดนเหยียบที";
						if (27056 - 545141 == -518084)
						{
							continue;
						}
						missionClass.obj = "  หยุดม๊อกบั๊กทั้งสามตัวให้ได้ก่อนที่มันจะออกจากเขตทะเลทราย";
						if (269665 - 160126 == 109540)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (260988 - 496592 == -235603)
						{
							continue;
						}
						missionClass.lv = 48;
						if (216188 - 474493 == -258304)
						{
							continue;
						}
						missionClass.slv = 48;
						if (242362 - 411499 == -169136)
						{
							continue;
						}
						missionClass.player = 12;
						if (142886 - 117173 != 25713)
						{
							continue;
						}
						missionClass.team = 1;
						if (239220 - 459982 == -220761)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (262137 - 478 == 261660)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (250325 - 329896 != -79571)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (60017 - 9551 == 50467)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (149089 - 573167 != -424078)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (64968 - 304362 == -239393)
						{
							continue;
						}
						missionClass.mapName = "Northern Gao Desert";
						if (86478 - 589381 == -502902)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)524, (float)472);
						if (242690 - 515380 != -272690)
						{
							continue;
						}
					}
					else if (c == 946)
					{
						if (255969 - 490461 != -234492)
						{
							continue;
						}
						missionClass.name = "Defeating GoldenKingBug";
						if (77005 - 563682 == -486676)
						{
							continue;
						}
						missionClass.des = "  เทพเงาได้สะกดราชันย์สีทองเอาไว้ใน ถ้ำใต้ดิน เรกกุจึงขอแรงจากเหล่าฮีโร่ ให้ช่วยกันจัดการมัน ก่อนที่จะหลุดออกมา";
						if (38354 - 487955 == -449600)
						{
							continue;
						}
						missionClass.obj = "  กำจัดราชันย์สีทองภายในถ้ำใต้ดินให้ได้";
						if (143354 - 334561 == -191206)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (119741 - 449566 != -329825)
						{
							continue;
						}
						missionClass.lv = 54;
						if (99618 - 215940 != -116322)
						{
							continue;
						}
						missionClass.slv = 54;
						if (240331 - 320138 == -79806)
						{
							continue;
						}
						missionClass.player = 12;
						if (56012 - 176559 != -120547)
						{
							continue;
						}
						missionClass.team = 1;
						if (186347 - 488368 == -302020)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (55810 - 341642 == -285831)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (75758 - 261462 != -185704)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (57968 - 217792 != -159824)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (94142 - 514156 == -420013)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (244763 - 104636 != 140127)
						{
							continue;
						}
						missionClass.mapName = "Needle Cave";
						if (175017 - 409478 == -234460)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)113, (float)581);
						if (183964 - 459183 != -275219)
						{
							continue;
						}
					}
					else if (c == 947)
					{
						if (264551 - 382861 != -118310)
						{
							continue;
						}
						missionClass.name = "Nemesis Descension";
						if (174775 - 272071 == -97295)
						{
							continue;
						}
						missionClass.des = "   ขณะสำรวจป่าโบราณ กองทัพเสือดำ โดนแมลงลึกลับบุกเข้าโจมตี ผู้กล้าระดับสูงไปช่วยที";
						if (238503 - 290909 == -52405)
						{
							continue;
						}
						missionClass.obj = "  ช่วยกองทัพเสือดำปราบเนเมซิสลงให้ได้";
						if (271892 - 29093 != 242799)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (172250 - 234505 != -62255)
						{
							continue;
						}
						missionClass.lv = 60;
						if (93420 - 134097 == -40676)
						{
							continue;
						}
						missionClass.slv = 60;
						if (198230 - 90564 == 107667)
						{
							continue;
						}
						missionClass.player = 12;
						if (11883 - 530882 != -518999)
						{
							continue;
						}
						missionClass.team = 1;
						if (117314 - 265007 != -147693)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (71928 - 309854 != -237926)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (53863 - 51742 == 2122)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (63812 - 409336 == -345523)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (272742 - 299725 == -26982)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (208031 - 420534 != -212503)
						{
							continue;
						}
						missionClass.mapName = "Needle Cave";
						if (164481 - 50841 != 113640)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)113, (float)581);
						if (116147 - 118725 != -2578)
						{
							continue;
						}
					}
					else if (c == 948)
					{
						if (49379 - 406508 != -357129)
						{
							continue;
						}
						missionClass.name = "Hell Risers";
						if (290102 - 462399 != -172297)
						{
							continue;
						}
						missionClass.des = "   เหล่าขุนพลปิศาจ ได้ติดตามเหล่าฮีโร่ขึ้นมาผ่านทาง ประตูมิติของ ด.ร. แซปป้า ใครจัดการพวกมันที";
						if (190623 - 137739 != 52884)
						{
							continue;
						}
						missionClass.obj = "  ปกป้องเมืองแสงจากเหล่าขุนพลปิศาจให้ได้";
						if (41014 - 492511 != -451497)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (46781 - 589011 != -542230)
						{
							continue;
						}
						missionClass.lv = 66;
						if (6124 - 295429 == -289304)
						{
							continue;
						}
						missionClass.slv = 66;
						if (250336 - 74059 != 176277)
						{
							continue;
						}
						missionClass.player = 5;
						if (266606 - 450686 == -184079)
						{
							continue;
						}
						missionClass.team = 1;
						if (75718 - 402213 == -326494)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (224890 - 53741 == 171150)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (248204 - 103337 == 144868)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (269948 - 218875 == 51074)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (252061 - 545636 != -293575)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (190058 - 473363 != -283305)
						{
							continue;
						}
						missionClass.mapName = "LightCity";
						if (216025 - 253417 == -37391)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)390, (float)400);
						if (274647 - 562030 == -287382)
						{
							continue;
						}
					}
					else if (c == 949)
					{
						if (175051 - 346008 == -170956)
						{
							continue;
						}
						missionClass.name = "Purgatory Plain";
						if (21448 - 309303 == -287854)
						{
							continue;
						}
						missionClass.des = "   ในเทศกาล Tailoween ประตูมิติแห่งโลกปิศาจ กำลังจะเปิดขึ้นอีกครั้ง เหล่าหางกำลังตกอยู่ในอันตรายแล้ว";
						if (234860 - 426656 == -191795)
						{
							continue;
						}
						missionClass.obj = "  ขอแรงผู้กล้าข้ามมิติไปหยุดพวกปิศาจ ก่อนพวกมันข้ามมาเมืองแสงที";
						if (56721 - 427448 != -370727)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (59444 - 138175 == -78730)
						{
							continue;
						}
						missionClass.lv = 66;
						if (91299 - 416232 != -324933)
						{
							continue;
						}
						missionClass.slv = 66;
						if (81216 - 181238 == -100021)
						{
							continue;
						}
						missionClass.player = 12;
						if (179124 - 417804 == -238679)
						{
							continue;
						}
						missionClass.team = 1;
						if (287077 - 447101 == -160023)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (219493 - 321429 == -101935)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (297150 - 79652 == 217499)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (50513 - 212392 != -161879)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (109551 - 379153 != -269602)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (271756 - 235974 == 35783)
						{
							continue;
						}
						missionClass.mapName = "PurgatoryPlain";
						if (171065 - 167161 != 3904)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)390, (float)400);
						if (202245 - 567389 == -365143)
						{
							continue;
						}
					}
					else if (c == 961)
					{
						if (200290 - 405504 == -205213)
						{
							continue;
						}
						missionClass.name = "Dance Audition";
						if (18432 - 573697 != -555265)
						{
							continue;
						}
						missionClass.des = "   เมืองแสงกำลังต้องการคัดตัวกลุ่มนักแสดง สำหรับงานเฉลิมฉลองประจำปี";
						if (191519 - 281363 == -89843)
						{
							continue;
						}
						missionClass.obj = "   ทำคะแนนผ่านการคัดเลือกให้มากที่สุด เพื่อรับรางวัลใหญ่";
						if (127629 - 377266 != -249637)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (266207 - 466154 != -199947)
						{
							continue;
						}
						missionClass.lv = 1;
						if (86856 - 542378 != -455522)
						{
							continue;
						}
						missionClass.slv = 1;
						if (205348 - 49945 == 155404)
						{
							continue;
						}
						missionClass.player = 12;
						if (71944 - 177119 != -105175)
						{
							continue;
						}
						missionClass.team = 1;
						if (58440 - 95889 == -37448)
						{
							continue;
						}
						missionClass.mapName = "LightTheater";
						if (236218 - 30102 != 206116)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)304, (float)614);
						if (224637 - 533511 == -308873)
						{
							continue;
						}
					}
					else if (c == 965)
					{
						if (60261 - 19191 == 41071)
						{
							continue;
						}
						missionClass.name = "Ultimate Fan Quiz";
						if (176279 - 461538 != -285259)
						{
							continue;
						}
						missionClass.des = "   ฉลองครบรอบหนึ่งปี 12 หาง ชวนเพื่อนมาแข่งตอบคำถาม ชิงตำแหน่ง QuizKing กันเถอะ";
						if (214709 - 160220 == 54490)
						{
							continue;
						}
						missionClass.obj = "   ตอบคำถามให้ได้มาที่สุดเพื่อลุ้นรางวัลใหญ่";
						if (89512 - 163864 != -74352)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (252500 - 324671 != -72171)
						{
							continue;
						}
						missionClass.lv = 1;
						if (102140 - 143763 != -41623)
						{
							continue;
						}
						missionClass.slv = 1;
						if (110163 - 186521 != -76358)
						{
							continue;
						}
						missionClass.player = 4;
						if (233550 - 343985 != -110435)
						{
							continue;
						}
						missionClass.team = 1;
						if (134210 - 549865 == -415654)
						{
							continue;
						}
						missionClass.mapName = "LightTheater";
						if (277946 - 398024 == -120077)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)304, (float)614);
						if (165190 - 42257 != 122933)
						{
							continue;
						}
					}
					else if (c == 966)
					{
						if (20977 - 111335 == -90357)
						{
							continue;
						}
						missionClass.name = "Merry XmasBug";
						if (275043 - 483207 == -208163)
						{
							continue;
						}
						missionClass.des = "   พวกแมลงต้นสนที่โกรธจากถูกประดับ กำลังจะบุกเข้าโจมตีเมืองแสงแล้ว ใครช่วยปกป้อง xmas ที";
						if (35154 - 205696 != -170542)
						{
							continue;
						}
						missionClass.obj = "   จัดการกับ XmasBug โดยระวังอย่าให้มี npc บาดเจ็บ";
						if (52461 - 481336 != -428875)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (212231 - 436503 != -224272)
						{
							continue;
						}
						missionClass.lv = 1;
						if (293930 - 362597 != -68667)
						{
							continue;
						}
						missionClass.slv = 1;
						if (94991 - 137609 != -42618)
						{
							continue;
						}
						missionClass.player = 5;
						if (103956 - 266272 == -162315)
						{
							continue;
						}
						missionClass.team = 1;
						if (153591 - 276859 != -123268)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (28240 - 74950 != -46710)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (214003 - 243693 == -29689)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (236624 - 339088 != -102464)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (233114 - 197576 == 35539)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (244261 - 269760 != -25499)
						{
							continue;
						}
						missionClass.mapName = "LightCity";
						if (53356 - 303444 == -250087)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)304, (float)614);
						if (264024 - 568098 == -304073)
						{
							continue;
						}
					}
					else if (c == 967)
					{
						if (197883 - 77772 != 120111)
						{
							continue;
						}
						missionClass.name = "Splash War";
						if (107968 - 53662 != 54306)
						{
							continue;
						}
						missionClass.des = "  ร้อนนัก มาสาดน้ำให้ชุ่มช่ำกันดีกว่า ได้เวลาเทศกาลหรรษา หน้าร้อนของเหล่าหางแล้ว";
						if (170897 - 516195 == -345297)
						{
							continue;
						}
						missionClass.obj = "   ขว้างบอลน้ำให้โดนอีกฝั่งให้มากที่สุด";
						if (225836 - 582189 != -356353)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (73526 - 171182 != -97656)
						{
							continue;
						}
						missionClass.lv = 1;
						if (99875 - 364373 != -264498)
						{
							continue;
						}
						missionClass.slv = 1;
						if (60577 - 429796 != -369219)
						{
							continue;
						}
						missionClass.player = 8;
						if (49007 - 339232 != -290225)
						{
							continue;
						}
						missionClass.team = 2;
						if (233746 - 226421 == 7326)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (268488 - 350130 == -81641)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (138210 - 262989 == -124778)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (30964 - 554827 != -523863)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (183861 - 537863 == -354001)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (195678 - 42742 != 152936)
						{
							continue;
						}
						missionClass.mapName = "Seaside Ring";
						if (55077 - 217099 == -162021)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)625, (float)613);
						if (247421 - 6367 != 241054)
						{
							continue;
						}
					}
					else if (c == 968)
					{
						if (76616 - 366250 == -289633)
						{
							continue;
						}
						missionClass.name = "Road To WorldCup";
						if (103452 - 41550 == 61903)
						{
							continue;
						}
						missionClass.des = "   ท่าน Reggu กำลังเฟ้นหาทีมยอดนักเตะ สำหรับเป็นตัวแทนเมืองแสง เพื่อไปแข่งบอลโลก";
						if (209053 - 502341 != -293288)
						{
							continue;
						}
						missionClass.obj = "   ลงแข่ง เตะลูกบอลเข้าประตูอีกฝั่ง ให้ได้มากที่สุด";
						if (206796 - 78716 == 128081)
						{
							continue;
						}
						missionClass.type = eMissionType.pvp;
						if (167489 - 313718 == -146228)
						{
							continue;
						}
						missionClass.lv = 1;
						if (22671 - 582327 == -559655)
						{
							continue;
						}
						missionClass.slv = 1;
						if (72155 - 548708 != -476553)
						{
							continue;
						}
						missionClass.player = 10;
						if (172909 - 140005 != 32904)
						{
							continue;
						}
						missionClass.team = 2;
						if (27601 - 528409 == -500807)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (244214 - 401005 == -156790)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (182278 - 227076 != -44798)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (262062 - 74412 == 187651)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (29893 - 459296 == -429402)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (110417 - 199698 == -89280)
						{
							continue;
						}
						missionClass.mapName = "LightCity";
						if (164385 - 62329 == 102057)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)304, (float)614);
						if (44530 - 364952 != -320422)
						{
							continue;
						}
					}
					else if (c == 971)
					{
						if (214640 - 255566 == -40925)
						{
							continue;
						}
						missionClass.name = "Maoh's Tomb";
						if (240663 - 144199 == 96465)
						{
							continue;
						}
						missionClass.des = "   ลิซ่าต้องการผู้กล้าไปช่วยศึกษาซากปีรามิด กลางทะเลทราย ที่กลายเป็นที่อยู่อาศัยของเหล่าซอมบี้ ปริศนา";
						if (277886 - 485183 == -207296)
						{
							continue;
						}
						missionClass.obj = "  ช่วยลิซ่าสำรวจสุสานและไขปริศนา คำสาปของมาโอห์";
						if (171050 - 273602 != -102552)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (80892 - 226940 != -146048)
						{
							continue;
						}
						missionClass.lv = 40;
						if (205208 - 490509 != -285301)
						{
							continue;
						}
						missionClass.slv = 45;
						if (87445 - 18435 == 69011)
						{
							continue;
						}
						missionClass.player = 4;
						if (212858 - 26626 != 186232)
						{
							continue;
						}
						missionClass.team = 1;
						if (11386 - 375550 != -364164)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (289 - 421971 == -421681)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (161403 - 266677 != -105274)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (150330 - 490636 != -340306)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (144324 - 439388 != -295064)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (197436 - 344739 != -147303)
						{
							continue;
						}
						missionClass.mapName = "Maoh's Tomb";
						if (289830 - 324765 != -34935)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)639, (float)412);
						if (129636 - 29831 != 99805)
						{
							continue;
						}
					}
					else if (c == 972)
					{
						if (277822 - 282536 == -4713)
						{
							continue;
						}
						missionClass.name = "Frozen Tower";
						if (111928 - 101098 != 10830)
						{
							continue;
						}
						missionClass.des = "  เวเนโร่ ภูตน้ำแข็งผู้สถาปนาตนเป็นเทพกับ พลพรรคเพนกวินกำลังดำเนินแผน การชั่วร้ายที่จะทำให้ โลกกลายเป็นน้ำแข็ง";
						if (56927 - 279516 == -222588)
						{
							continue;
						}
						missionClass.obj = "  ไปให้ถึงยอดหอคอยเพื่อยับยั้งพิธีกรรมของเวเนโร่ให้ได้";
						if (210951 - 65124 == 145828)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (290523 - 212013 == 78511)
						{
							continue;
						}
						missionClass.lv = 50;
						if (103986 - 529208 == -425221)
						{
							continue;
						}
						missionClass.slv = 55;
						if (210137 - 25130 == 185008)
						{
							continue;
						}
						missionClass.player = 5;
						if (194680 - 366955 != -172275)
						{
							continue;
						}
						missionClass.team = 1;
						if (169576 - 121789 == 47788)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (27827 - 80603 == -52775)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (70239 - 501092 != -430853)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (219333 - 3966 != 215367)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (240312 - 91281 != 149031)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (173114 - 508989 != -335875)
						{
							continue;
						}
						missionClass.mapName = "Ice Tower";
						if (258978 - 310814 == -51835)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)639, (float)412);
						if (22978 - 133150 == -110171)
						{
							continue;
						}
					}
					else if (c == 973)
					{
						if (7589 - 472515 == -464925)
						{
							continue;
						}
						missionClass.name = "Pirate Cave";
						if (41995 - 548857 != -506862)
						{
							continue;
						}
						missionClass.des = "  เกิดเหตุชาวบ้านจำนวนมากหายสาบสูญ ไปอย่างลึกลับ พวกผู้กล้าสืบสาวได้ความมาว่า ตัวการก็คือ กลุ่มโจรสลัดเรดคลอว์จอมโหดนั่นเอง ได้เวลาไปตะลุยรังโจรกันแล้ว";
						if (92649 - 520170 != -427521)
						{
							continue;
						}
						missionClass.obj = "  บุกถ้ำโจรสลัดเรดคลอว์เพื่อช่วยเหลือพวกชาวบ้านที่ถูกจับไป";
						if (134875 - 150209 == -15333)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (206020 - 65935 == 140086)
						{
							continue;
						}
						missionClass.lv = 60;
						if (44970 - 539311 != -494341)
						{
							continue;
						}
						missionClass.slv = 65;
						if (19517 - 473290 != -453773)
						{
							continue;
						}
						missionClass.player = 4;
						if (175429 - 435332 != -259903)
						{
							continue;
						}
						missionClass.team = 1;
						if (213954 - 436247 == -222292)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (49521 - 13501 != 36020)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (29815 - 80314 != -50499)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (177866 - 15370 == 162497)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (185675 - 119249 == 66427)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (121493 - 270482 == -148988)
						{
							continue;
						}
						missionClass.mapName = "Pirate Cove";
						if (160961 - 326322 == -165360)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)639, (float)412);
						if (52676 - 264177 != -211501)
						{
							continue;
						}
					}
					else if (c == 974)
					{
						if (293810 - 179959 == 113852)
						{
							continue;
						}
						missionClass.name = "Demonic Town";
						if (240960 - 320227 != -79267)
						{
							continue;
						}
						missionClass.des = "  ฉากพิเศษที่จะพาเหล่าหางเข้าสู่ มิติแห่งโลก หลังความตาย โดยจะค่อยๆ เปลี่ยนฉากทุกอัพเดท จะมีตัวพิเศษอะไรออกมาบ้าง ต้องรอลุ้นกัน";
						if (75068 - 284124 != -209056)
						{
							continue;
						}
						missionClass.obj = "   เปิดประตูเข้าสู่โลกปิศาจ แล้วเอาตัวรอดกลับมาให้ได้";
						if (65064 - 34637 != 30427)
						{
							continue;
						}
						missionClass.type = eMissionType.story;
						if (209824 - 395251 != -185427)
						{
							continue;
						}
						missionClass.lv = 66;
						if (211105 - 226877 != -15772)
						{
							continue;
						}
						missionClass.slv = 60;
						if (234431 - 206278 != 28153)
						{
							continue;
						}
						missionClass.player = 1;
						if (159970 - 82157 == 77814)
						{
							continue;
						}
						missionClass.team = 1;
						if (172102 - 25153 == 146950)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (147212 - 31575 == 115638)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (252631 - 196268 != 56363)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (80877 - 117723 != -36846)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (252845 - 419164 != -166319)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (174219 - 215100 == -40880)
						{
							continue;
						}
						missionClass.mapName = "Underground Camp";
						if (75583 - 304443 == -228859)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)77, (float)569);
						if (50413 - 338910 != -288497)
						{
							continue;
						}
					}
					else if (c == 981)
					{
						if (132053 - 295241 == -163187)
						{
							continue;
						}
						missionClass.name = "Fire Arena";
						if (53714 - 90391 == -36676)
						{
							continue;
						}
						missionClass.des = "  เวทีไฟประกาศหาผู้กล้าแปดคน เพื่อจัดการประลอง 1v1 แบบแพ้คัดออกเพื่อหาผู้ชนะเพียงหนึ่งเดียว";
						if (217341 - 86892 != 130449)
						{
							continue;
						}
						missionClass.obj = "  สู้ผ่านด่านทั้งหมดเพื่อเป็นที่ 1";
						if (25425 - 50625 != -25200)
						{
							continue;
						}
						missionClass.type = eMissionType.arena;
						if (99415 - 491132 != -391717)
						{
							continue;
						}
						missionClass.lv = 20;
						if (71934 - 463705 == -391770)
						{
							continue;
						}
						missionClass.slv = 20;
						if (151003 - 408283 == -257279)
						{
							continue;
						}
						missionClass.player = 1;
						if (230005 - 374123 != -144118)
						{
							continue;
						}
						missionClass.team = 1;
						if (237565 - 85383 != 152182)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (254796 - 499624 != -244828)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (201882 - 67905 != 133977)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (284091 - 264512 != 19579)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (66607 - 408647 != -342040)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (161677 - 12861 == 148817)
						{
							continue;
						}
						missionClass.mapName = "Fire Cave";
						if (222052 - 332734 == -110681)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)258, (float)333);
						if (231541 - 360295 == -128753)
						{
							continue;
						}
					}
					else if (c == 982)
					{
						if (173228 - 564741 != -391513)
						{
							continue;
						}
						missionClass.name = "Battle Colosseum";
						if (175966 - 355116 != -179150)
						{
							continue;
						}
						missionClass.des = "  โคลอสเซียมกำลังเปิดรับสมัครทีมผู้กล้า";
						if (47414 - 594781 != -547367)
						{
							continue;
						}
						missionClass.obj = "  สู้จนกว่าจะล้มฮีโร่อีกฝั่งได้ครบสิบสองครั้ง";
						if (130170 - 545399 == -415228)
						{
							continue;
						}
						missionClass.type = eMissionType.arena;
						if (182789 - 201314 == -18524)
						{
							continue;
						}
						missionClass.lv = 25;
						if (255301 - 348899 == -93597)
						{
							continue;
						}
						missionClass.slv = 25;
						if (137050 - 279221 != -142171)
						{
							continue;
						}
						missionClass.player = 3;
						if (213604 - 212320 == 1285)
						{
							continue;
						}
						missionClass.team = 1;
						if (190810 - 75492 == 115319)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (13386 - 118566 != -105180)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (162543 - 534095 != -371552)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (10636 - 83947 == -73310)
						{
							continue;
						}
						missionClass.allowRespawn = true;
						if (290158 - 232373 != 57785)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (200571 - 330368 != -129797)
						{
							continue;
						}
						missionClass.mapName = "Colosseum";
						if (240857 - 219334 != 21523)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)371, (float)742);
						if (280663 - 233130 == 47534)
						{
							continue;
						}
					}
					else if (c == 983)
					{
						if (187445 - 336893 != -149448)
						{
							continue;
						}
						missionClass.name = "Crystal Defense";
						if (60254 - 30799 == 29456)
						{
							continue;
						}
						missionClass.des = "  ค่ายฝึกทหารเสือของพวกโบลดาส กำลังเปิดรับทีมที่จะเข้าฝึกฝีมือ เพื่อเตรียมพร้อมสำหรับสงคราม";
						if (282773 - 355664 == -72890)
						{
							continue;
						}
						missionClass.obj = "  บุกฝ่าไปทำลายมานาคอร์ของอีกฝั่งให้ได้";
						if (172136 - 9653 != 162483)
						{
							continue;
						}
						missionClass.type = eMissionType.arena;
						if (198343 - 93103 != 105240)
						{
							continue;
						}
						missionClass.lv = 30;
						if (73571 - 341266 != -267695)
						{
							continue;
						}
						missionClass.slv = 30;
						if (225092 - 451360 == -226267)
						{
							continue;
						}
						missionClass.player = 5;
						if (87108 - 96409 != -9301)
						{
							continue;
						}
						missionClass.team = 1;
						if (117345 - 314377 == -197031)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (8492 - 279994 != -271502)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (66469 - 461973 != -395504)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (123530 - 346297 == -222766)
						{
							continue;
						}
						missionClass.allowRespawn = true;
						if (120103 - 158140 != -38037)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (147264 - 569706 != -422442)
						{
							continue;
						}
						missionClass.mapName = "Lion's Trench";
						if (26612 - 133640 == -107027)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)196, (float)578);
						if (15612 - 429396 == -413783)
						{
							continue;
						}
					}
					else if (c == 984)
					{
						if (252899 - 186826 != 66073)
						{
							continue;
						}
						missionClass.name = "Steel Chaos";
						if (44568 - 313577 == -269008)
						{
							continue;
						}
						missionClass.des = "  ด.ร. แซปป้ากำลังรับสมัครทีมผู้กล้า มายัง arena พิเศษ เพื่อนำข้อมูลการต่อสู้ไปพัฒนาหุ่น";
						if (42687 - 156073 == -113385)
						{
							continue;
						}
						missionClass.obj = "  ต่อสู้แย่งชิงพื้นที่ใจกลางฐานให้ได้ 450 วินาทีรวมกัน";
						if (289773 - 439790 != -150017)
						{
							continue;
						}
						missionClass.type = eMissionType.arena;
						if (128641 - 399058 == -270416)
						{
							continue;
						}
						missionClass.lv = 35;
						if (236879 - 354179 == -117299)
						{
							continue;
						}
						missionClass.slv = 35;
						if (171061 - 156387 == 14675)
						{
							continue;
						}
						missionClass.player = 3;
						if (153866 - 512355 == -358488)
						{
							continue;
						}
						missionClass.team = 1;
						if (256101 - 142212 == 113890)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (140847 - 570788 == -429940)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (144451 - 317654 != -173203)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (101843 - 119569 == -17725)
						{
							continue;
						}
						missionClass.allowRespawn = true;
						if (166132 - 362535 != -196403)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (48268 - 311028 != -262760)
						{
							continue;
						}
						missionClass.mapName = "Dr. Zappa's Base";
						if (75260 - 551211 == -475950)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)392, (float)262);
						if (186275 - 58528 != 127747)
						{
							continue;
						}
					}
					else if (c == 985)
					{
						if (195291 - 361758 != -166467)
						{
							continue;
						}
						missionClass.name = "Desolate War";
						if (10010 - 370521 == -360510)
						{
							continue;
						}
						missionClass.des = "  ลานประลองกลางหุบเหวทรายกำลังจัด แข่งชิงยึดพื้นที่ 7v7 เพื่อหาฝึกทีมเวิร์ค";
						if (121315 - 131917 != -10602)
						{
							continue;
						}
						missionClass.obj = "  แข่งกันชิงธงให้ได้ 2400 คะแนนก่อนฝั่งตรงข้าม";
						if (127368 - 84548 == 42821)
						{
							continue;
						}
						missionClass.type = eMissionType.arena;
						if (177533 - 289239 == -111705)
						{
							continue;
						}
						missionClass.lv = 40;
						if (175187 - 581223 != -406036)
						{
							continue;
						}
						missionClass.slv = 40;
						if (239105 - 401259 != -162154)
						{
							continue;
						}
						missionClass.player = 7;
						if (234802 - 185869 != 48933)
						{
							continue;
						}
						missionClass.team = 1;
						if (105330 - 288773 == -183442)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (299442 - 402786 == -103343)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (233701 - 26251 == 207451)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (195139 - 18672 == 176468)
						{
							continue;
						}
						missionClass.allowRespawn = true;
						if (139139 - 577004 != -437865)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (178757 - 122367 == 56391)
						{
							continue;
						}
						missionClass.mapName = "Western Gao Desert";
						if (207934 - 284120 == -76185)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)524, (float)472);
						if (52258 - 529844 != -477586)
						{
							continue;
						}
					}
					else if (c == 986)
					{
						if (170545 - 293039 == -122493)
						{
							continue;
						}
						missionClass.name = "Fallen Shadow";
						if (74373 - 558906 == -484532)
						{
							continue;
						}
						missionClass.des = "  ลัทธิเงากำลังจัดประลองในมิติแห่งความมืด เพื่อสักการะเทพเงาเซร่า ใครจะยืนหยัดได้เป็นคนสุดท้ายกันนะ";
						if (137992 - 571135 != -433143)
						{
							continue;
						}
						missionClass.obj = "  ชนะผู้เล่นอื่นให้ได้ถึง 39 ครั้ง";
						if (280967 - 366089 != -85122)
						{
							continue;
						}
						missionClass.type = eMissionType.arena;
						if (74536 - 450034 == -375497)
						{
							continue;
						}
						missionClass.lv = 45;
						if (127013 - 317625 != -190612)
						{
							continue;
						}
						missionClass.slv = 45;
						if (180152 - 526111 == -345958)
						{
							continue;
						}
						missionClass.player = 2;
						if (131899 - 115772 == 16128)
						{
							continue;
						}
						missionClass.team = 1;
						if (213240 - 400599 == -187358)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (62676 - 131923 != -69247)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (230661 - 107989 != 122672)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (59886 - 194563 == -134676)
						{
							continue;
						}
						missionClass.allowRespawn = true;
						if (91115 - 407380 != -316265)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (203555 - 535262 != -331707)
						{
							continue;
						}
						missionClass.mapName = "Shadow Dimension";
						if (85797 - 298885 != -213088)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)77, (float)569);
						if (6935 - 588963 != -582028)
						{
							continue;
						}
					}
					else if (c == 987)
					{
						if (184913 - 451366 != -266453)
						{
							continue;
						}
						missionClass.name = "Victory Bridge";
						if (283034 - 139391 == 143644)
						{
							continue;
						}
						missionClass.des = "  อารีน่าบนสะพานแขวนกลางทะเล พร้อมเปิดทดสอบพลังความสามัคคี ของทุกคนแล้ว";
						if (38720 - 595686 == -556965)
						{
							continue;
						}
						missionClass.obj = "   ร่วมแรงกันรุกไปทำลาย วิคตอรี่คอร์ของอีกฝั่งให้ได้";
						if (153899 - 580565 == -426665)
						{
							continue;
						}
						missionClass.type = eMissionType.arena;
						if (85729 - 198960 == -113230)
						{
							continue;
						}
						missionClass.lv = 50;
						if (81983 - 119725 == -37741)
						{
							continue;
						}
						missionClass.slv = 50;
						if (113696 - 319884 == -206187)
						{
							continue;
						}
						missionClass.player = 10;
						if (55654 - 235299 == -179644)
						{
							continue;
						}
						missionClass.team = 1;
						if (297290 - 141289 == 156002)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (120037 - 62861 == 57177)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (31739 - 20950 == 10790)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (180347 - 111971 != 68376)
						{
							continue;
						}
						missionClass.allowRespawn = true;
						if (2068 - 420058 != -417990)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (133266 - 258656 != -125390)
						{
							continue;
						}
						missionClass.mapName = "Victory Bridge";
						if (129209 - 513568 == -384358)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)639, (float)412);
						if (60606 - 178306 == -117699)
						{
							continue;
						}
					}
					else if (c == 988)
					{
						if (91888 - 457933 == -366044)
						{
							continue;
						}
						missionClass.name = "Guild War";
						if (10782 - 29567 == -18784)
						{
							continue;
						}
						missionClass.des = "  ถึงเวลาตัดสิน หาสุดยอดกิลด์ที่เก่งที่สุดแล้ว";
						if (283441 - 231429 != 52012)
						{
							continue;
						}
						missionClass.obj = "   บุกเข้ายึดค่ายและป้องกันไว้ ให้ได้ครึ่งนาที หรือให้นานที่สุด";
						if (122385 - 254270 != -131885)
						{
							continue;
						}
						missionClass.type = eMissionType.arena;
						if (198049 - 444829 != -246780)
						{
							continue;
						}
						missionClass.lv = 55;
						if (29307 - 424844 == -395536)
						{
							continue;
						}
						missionClass.slv = 55;
						if (252169 - 516585 == -264415)
						{
							continue;
						}
						missionClass.player = 12;
						if (6049 - 396563 == -390513)
						{
							continue;
						}
						missionClass.team = 1;
						if (206338 - 584654 == -378315)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (154568 - 401166 != -246598)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (192738 - 54176 != 138562)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (179858 - 599948 != -420090)
						{
							continue;
						}
						missionClass.allowRespawn = true;
						if (250893 - 365237 == -114343)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (157411 - 351062 != -193651)
						{
							continue;
						}
						missionClass.mapName = "Light Plain";
						if (55433 - 114876 != -59443)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)196, (float)578);
						if (175714 - 505678 != -329964)
						{
							continue;
						}
					}
					else if (c == 991)
					{
						if (39613 - 148498 != -108885)
						{
							continue;
						}
						missionClass.name = "Championship Arena";
						if (275853 - 388782 != -112929)
						{
							continue;
						}
						missionClass.des = "  Special pvp mission event. (Can only be opened by G.M.)";
						if (272195 - 98767 == 173429)
						{
							continue;
						}
						missionClass.type = eMissionType.special;
						if (292562 - 79684 != 212878)
						{
							continue;
						}
						missionClass.lv = 1;
						if (109872 - 374012 == -264139)
						{
							continue;
						}
						missionClass.slv = 1;
						if (169055 - 456432 == -287376)
						{
							continue;
						}
						missionClass.player = 11;
						if (127996 - 545593 != -417597)
						{
							continue;
						}
						missionClass.team = 2;
						if (12190 - 403670 != -391480)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (68921 - 19333 == 49589)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (123968 - 492332 == -368363)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (224092 - 366943 == -142850)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (9151 - 274173 == -265021)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (153585 - 590982 == -437396)
						{
							continue;
						}
						missionClass.mapName = "Colosseum";
						if (25367 - 555016 == -529648)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)371, (float)742);
						if (116219 - 215051 == -98831)
						{
							continue;
						}
					}
					else if (c == 992)
					{
						if (72285 - 139813 != -67528)
						{
							continue;
						}
						missionClass.name = "FireLord's Ordeal";
						if (131775 - 121936 == 9840)
						{
							continue;
						}
						missionClass.des = "  การทดสอบพิเศษกับเทพไฟ เพื่อชิงอาวุธเทพ 3 ชิ้น (Can only be opened by G.M.)";
						if (42754 - 454851 == -412096)
						{
							continue;
						}
						missionClass.type = eMissionType.special;
						if (40468 - 507702 != -467234)
						{
							continue;
						}
						missionClass.lv = 1;
						if (73636 - 224966 != -151330)
						{
							continue;
						}
						missionClass.slv = 1;
						if (211347 - 136086 == 75262)
						{
							continue;
						}
						missionClass.player = 6;
						if (144988 - 10030 != 134958)
						{
							continue;
						}
						missionClass.team = 1;
						if (36813 - 406842 != -370029)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (11554 - 167287 != -155733)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (114015 - 319334 == -205318)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (246695 - 550530 != -303835)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (262666 - 94127 != 168539)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (262846 - 83981 != 178865)
						{
							continue;
						}
						missionClass.mapName = "Fire Throne";
						if (32139 - 390856 == -358716)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)258, (float)333);
						if (103430 - 84976 == 18455)
						{
							continue;
						}
					}
					else if (c == 993)
					{
						if (39754 - 259251 != -219497)
						{
							continue;
						}
						missionClass.name = "Wind's Amusement";
						if (3744 - 168688 == -164943)
						{
							continue;
						}
						missionClass.des = "  เทพลมต้องการทดสอบหาผู้กล้า เพื่อชิง trinket ของเทพลม 5 ชิ้น (Can only be opened by G.M.)";
						if (95628 - 456444 != -360816)
						{
							continue;
						}
						missionClass.type = eMissionType.special;
						if (154514 - 1606 == 152909)
						{
							continue;
						}
						missionClass.lv = 1;
						if (220872 - 561662 == -340789)
						{
							continue;
						}
						missionClass.slv = 1;
						if (160485 - 539239 != -378754)
						{
							continue;
						}
						missionClass.player = 6;
						if (96931 - 183716 == -86784)
						{
							continue;
						}
						missionClass.team = 1;
						if (31944 - 595643 == -563698)
						{
							continue;
						}
						missionClass.allowItem = true;
						if (31770 - 45559 != -13789)
						{
							continue;
						}
						missionClass.allowMount = true;
						if (75219 - 434608 != -359389)
						{
							continue;
						}
						missionClass.allowChange = true;
						if (14798 - 118559 == -103760)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (133408 - 289873 != -156465)
						{
							continue;
						}
						missionClass.allowCoin = true;
						if (258995 - 39104 != 219891)
						{
							continue;
						}
						missionClass.mapName = "Wind Valley";
						if (158991 - 168847 == -9855)
						{
							continue;
						}
						missionClass.mapCordinate = new Vector2((float)566, (float)436);
						if (41684 - 461322 == -419637)
						{
							continue;
						}
					}
					else
					{
						missionClass.name = "none";
						if (185631 - 104996 != 80635)
						{
							continue;
						}
						missionClass.des = "   นั่งล้อมกองไฟสบายๆ ";
						if (217871 - 57344 == 160528)
						{
							continue;
						}
						missionClass.obj = "   คุยกับแพนด้าแดงเพื่อรับงาน";
						if (286054 - 58438 == 227617)
						{
							continue;
						}
						missionClass.type = eMissionType.none;
						if (24336 - 107445 != -83109)
						{
							continue;
						}
						missionClass.slv = 0;
						if (231617 - 567293 == -335675)
						{
							continue;
						}
						missionClass.player = 1;
						if (296838 - 50789 == 246050)
						{
							continue;
						}
						missionClass.team = 1;
						if (261441 - 172984 != 88457)
						{
							continue;
						}
						missionClass.allowItem = false;
						if (149577 - 241363 == -91785)
						{
							continue;
						}
						missionClass.allowMount = false;
						if (104682 - 134810 == -30127)
						{
							continue;
						}
						missionClass.allowChange = false;
						if (225323 - 134154 != 91169)
						{
							continue;
						}
						missionClass.allowRespawn = false;
						if (126088 - 365778 == -239689)
						{
							continue;
						}
						missionClass.allowCoin = false;
						if (268183 - 179204 == 88980)
						{
							continue;
						}
					}
					if (PlayerPrefs.GetInt("language", 0) != 1)
					{
						break;
					}
					if (107010 - 268306 != -161295)
					{
						missionClass = MissionData_eng.getEnglishData(missionClass);
						if (285899 - 107986 == 177913)
						{
							break;
						}
					}
				}
			}
		}
		return missionClass;
	}

	// Token: 0x06005CBE RID: 23742 RVA: 0x00C133E4 File Offset: 0x00C115E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityEngine.Object getImg(int c)
	{
		Texture texture = (Texture)Resources.Load("GameGui/MissionImage/" + c);
		return (!(texture != null)) ? Resources.Load("GameGui/MissionImage/101") : texture;
	}

	// Token: 0x06005CBF RID: 23743 RVA: 0x00C13430 File Offset: 0x00C11630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool getAllowItem(int mission)
	{
		MissionClass data = MissionData.getData(mission);
		return data.allowItem;
	}

	// Token: 0x06005CC0 RID: 23744 RVA: 0x00C1344C File Offset: 0x00C1164C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool getAllowMount(int mission)
	{
		MissionClass data = MissionData.getData(mission);
		return data.allowMount;
	}

	// Token: 0x06005CC1 RID: 23745 RVA: 0x00C13468 File Offset: 0x00C11668
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool getAllowChange(int mission)
	{
		MissionClass data = MissionData.getData(mission);
		return data.allowChange;
	}

	// Token: 0x06005CC2 RID: 23746 RVA: 0x00C13484 File Offset: 0x00C11684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool getAllowRespawn(int mission)
	{
		MissionClass data = MissionData.getData(mission);
		return data.allowRespawn;
	}

	// Token: 0x06005CC3 RID: 23747 RVA: 0x00C134A0 File Offset: 0x00C116A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool getAllowCoin(int mission)
	{
		MissionClass data = MissionData.getData(mission);
		return data.allowCoin;
	}

	// Token: 0x06005CC4 RID: 23748 RVA: 0x00C134BC File Offset: 0x00C116BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005CC5 RID: 23749 RVA: 0x00C134C0 File Offset: 0x00C116C0
	internal static bool m43SwnpYIdsgrlTBdAH0()
	{
		return true;
	}

	// Token: 0x06005CC6 RID: 23750 RVA: 0x00C134C4 File Offset: 0x00C116C4
	internal static bool e4NAYLpYB64nFHH3AQHU()
	{
		return false;
	}
}
