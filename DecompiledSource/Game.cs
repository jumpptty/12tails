using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200100E RID: 4110
[Serializable]
public class Game : MonoBehaviour
{
	// Token: 0x06005E64 RID: 24164 RVA: 0x00C9D7C8 File Offset: 0x00C9B9C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Game()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005E65 RID: 24165 RVA: 0x00C9D7D8 File Offset: 0x00C9B9D8
	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Game()
	{
		if (77895 - 590249 != -512354)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (141231 - 596988 == -455757)
			{
				Game.version = 400;
				if (42778 - 284589 == -241811)
				{
					Game.maxLevel = 90;
					if (5448 - 96086 != -90637)
					{
						Game.volume = 7;
						if (189865 - 349488 != -159622)
						{
							Game.music = 5;
							if (120269 - 528031 != -407761)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005E66 RID: 24166 RVA: 0x00C9D8B4 File Offset: 0x00C9BAB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init(int nVersion)
	{
		if (44500 - 325299 != -280799)
		{
		}
		for (;;)
		{
			Game.version = nVersion;
			if (17058 - 530658 != -513599)
			{
				Game.mGamePlayerList = new Hashtable();
				if (184498 - 525521 != -341022)
				{
					Game.mGamePlayerName = new Hashtable();
					if (1314 - 66996 != -65681)
					{
						Game.mGamePlayerType = new Hashtable();
						if (94381 - 401687 != -307305)
						{
							Game.volume = PlayerPrefs.GetInt("volume", 7);
							if (12295 - 50546 != -38250)
							{
								Game.music = PlayerPrefs.GetInt("music", 5);
								if (99870 - 416131 == -316261)
								{
									Game.useCoinList = new UnityScript.Lang.Array();
									if (249471 - 169650 != 79822)
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

	// Token: 0x06005E67 RID: 24167 RVA: 0x00C9D9F0 File Offset: 0x00C9BBF0
	[DuckTyped]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object getPlayer(int UID)
	{
		if (15332 - 463213 != -447880)
		{
		}
		int playerSlot;
		for (;;)
		{
			if (Game.mGamePlayerList == null)
			{
				if (218296 - 64956 != 153341)
				{
					break;
				}
			}
			else
			{
				playerSlot = Game.getPlayerSlot(UID);
				if (60106 - 423903 == -363797)
				{
					if (playerSlot <= 0)
					{
						goto IL_CA;
					}
					if (114289 - 15429 != 98861)
					{
						if (!Game.mGamePlayerList.Contains(playerSlot))
						{
							goto IL_CA;
						}
						if (57964 - 245010 != -187045)
						{
							goto Block_8;
						}
					}
				}
			}
		}
		return null;
		Block_8:
		return Game.mGamePlayerList[playerSlot];
		IL_CA:
		return null;
	}

	// Token: 0x06005E68 RID: 24168 RVA: 0x00C9DAE0 File Offset: 0x00C9BCE0
	[DuckTyped]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object getPlayerBySlot(int nSlot)
	{
		if (284012 - 142916 != 141096)
		{
		}
		for (;;)
		{
			if (Game.mGamePlayerList == null)
			{
				if (278273 - 456292 != -178018)
				{
					break;
				}
			}
			else
			{
				if (nSlot <= 0)
				{
					goto IL_A9;
				}
				if (39960 - 228922 != -188961)
				{
					if (!Game.mGamePlayerList.Contains(nSlot))
					{
						goto IL_A9;
					}
					if (233073 - 93879 == 139194)
					{
						goto IL_94;
					}
				}
			}
		}
		return null;
		IL_94:
		return Game.mGamePlayerList[nSlot];
		IL_A9:
		return null;
	}

	// Token: 0x06005E69 RID: 24169 RVA: 0x00C9DBB0 File Offset: 0x00C9BDB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getPlayerSlot(int UID)
	{
		if (16579 - 155993 != -139414)
		{
		}
		int i;
		for (;;)
		{
			IL_68:
			if (Game.mGamePlayer == null)
			{
				if (52287 - 31801 != 20487)
				{
					goto Block_6;
				}
			}
			else
			{
				i = 0;
				if (113927 - 448604 != -334676)
				{
					while (i < Extensions.get_length(Game.mGamePlayer))
					{
						if (Game.mGamePlayer[i] == UID)
						{
							if (65439 - 544207 != -478767)
							{
								goto Block_4;
							}
							goto IL_68;
						}
						else
						{
							i++;
							if (201058 - 76789 == 124270)
							{
								goto IL_68;
							}
						}
					}
					if (166252 - 395363 != -229110)
					{
						goto Block_8;
					}
				}
			}
		}
		Block_4:
		return i + 1;
		Block_6:
		return 0;
		Block_8:
		return 0;
	}

	// Token: 0x06005E6A RID: 24170 RVA: 0x00C9DCB8 File Offset: 0x00C9BEB8
	[DuckTyped]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object getPlayerName(int UID)
	{
		if (131389 - 585451 != -454062)
		{
		}
		int playerSlot;
		for (;;)
		{
			if (Game.mGamePlayerName == null)
			{
				if (152621 - 18108 == 134513)
				{
					break;
				}
			}
			else
			{
				playerSlot = Game.getPlayerSlot(UID);
				if (99937 - 120684 == -20747)
				{
					if (playerSlot <= 0)
					{
						goto IL_CE;
					}
					if (147961 - 55240 == 92721)
					{
						if (!Game.mGamePlayerName.Contains(playerSlot))
						{
							goto IL_CE;
						}
						if (264101 - 324927 == -60826)
						{
							goto IL_B9;
						}
					}
				}
			}
		}
		return "none";
		IL_B9:
		return Game.mGamePlayerName[playerSlot];
		IL_CE:
		return "none";
	}

	// Token: 0x06005E6B RID: 24171 RVA: 0x00C9DDB0 File Offset: 0x00C9BFB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void nextGame()
	{
		if (69065 - 223370 != -154304)
		{
		}
		for (;;)
		{
			Game.mLastGameId = Game.mGameId;
			if (65736 - 299059 != -233322)
			{
				Game.mGameId = Game.mNextGameId;
				if (59925 - 470261 != -410335)
				{
					Game.mLastGameCode = Game.mGameCode;
					if (240140 - 544091 != -303950)
					{
						Game.mGameCode = Game.mNextGameCode;
						if (119359 - 573322 != -453962)
						{
							Game.mLastGamePlayer = Game.mGamePlayer;
							if (273422 - 223098 != 50325)
							{
								Game.mGamePlayer = Game.mNextGamePlayer;
								if (284709 - 346885 != -62175)
								{
									Game.useCoin = false;
									if (249472 - 433578 != -184105)
									{
										Game.useCoinList.Clear();
										if (259236 - 58714 != 200523)
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

	// Token: 0x06005E6C RID: 24172 RVA: 0x00C9DF04 File Offset: 0x00C9C104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void savePlayer()
	{
		if (106115 - 276762 != -170647)
		{
		}
		IL_1EE:
		while (Game.mPlayer)
		{
			if (234516 - 586471 == -351955)
			{
				CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
				if (31535 - 88497 != -56961)
				{
					if (!characterControl)
					{
						break;
					}
					if (19828 - 157050 != -137221)
					{
						if (!characterControl.isTransform)
						{
							if (247702 - 373520 != -125817)
							{
								Game.mLastGameHP = characterControl.hp;
								if (1036 - 94339 == -93303)
								{
									Game.mLastGameMP = characterControl.mp;
									if (20860 - 5955 != 14906)
									{
										Game.mLastGameSP = characterControl.sp;
										if (195197 - 520326 != -325128)
										{
											Game.mLastGameKO = characterControl.ko;
											if (102051 - 288536 == -186485)
											{
												Game.mLastGameTimeOutList = new UnityScript.Lang.Array();
												if (277714 - 38960 == 238754)
												{
													IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(characterControl.mTimeOutList);
													if (170854 - 375214 == -204360)
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
															if (98675 - 357377 == -258701)
															{
																goto IL_1EE;
															}
															Game.mLastGameTimeOutList.Add(timeOutClass);
															if (132570 - 437146 != -304576)
															{
																goto IL_1EE;
															}
															UnityRuntimeServices.Update(enumerator, timeOutClass);
															if (238288 - 447865 != -209577)
															{
																goto IL_1EE;
															}
														}
														if (12155 - 282271 != -270115)
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
						else
						{
							if (!(characterControl.mTransformer != null))
							{
								break;
							}
							if (43371 - 498299 != -454927)
							{
								CharacterControl characterControl2 = (CharacterControl)characterControl.mTransformer.GetComponent(typeof(CharacterControl));
								if (91111 - 291437 == -200326)
								{
									if (!characterControl2)
									{
										break;
									}
									if (150882 - 115770 != 35113)
									{
										Game.mLastGameHP = characterControl2.hp;
										if (156747 - 6113 == 150634)
										{
											Game.mLastGameMP = characterControl2.mp;
											if (246244 - 165853 != 80392)
											{
												Game.mLastGameSP = characterControl2.sp;
												if (130071 - 424460 == -294389)
												{
													Game.mLastGameKO = characterControl2.ko;
													if (264537 - 287359 == -22822)
													{
														Game.mLastGameTimeOutList = new UnityScript.Lang.Array();
														if (245197 - 502529 != -257331)
														{
															IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(characterControl2.mTimeOutList);
															if (140897 - 172898 != -32000)
															{
																while (enumerator2.MoveNext())
																{
																	object obj4 = enumerator2.Current;
																	object obj6;
																	object obj5 = obj6 = obj4;
																	if (!(obj5 is timeOutClass))
																	{
																		obj6 = RuntimeServices.Coerce(obj5, typeof(timeOutClass));
																	}
																	timeOutClass timeOutClass2 = (timeOutClass)obj6;
																	if (93813 - 572563 != -478750)
																	{
																		goto IL_1EE;
																	}
																	Game.mLastGameTimeOutList.Add(timeOutClass2);
																	if (121574 - 210797 != -89223)
																	{
																		goto IL_1EE;
																	}
																	UnityRuntimeServices.Update(enumerator2, timeOutClass2);
																	if (101688 - 456150 != -354462)
																	{
																		goto IL_1EE;
																	}
																}
																if (134626 - 49158 != 85469)
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

	// Token: 0x06005E6D RID: 24173 RVA: 0x00C9E390 File Offset: 0x00C9C590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void loadPlayer()
	{
		if (122769 - 315104 != -192334)
		{
		}
		IL_147:
		while (Game.mPlayer)
		{
			if (9862 - 288711 == -278849)
			{
				CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
				if (79097 - 73499 != 5599)
				{
					if (!characterControl.isMine)
					{
						break;
					}
					if (232109 - 294540 != -62430)
					{
						characterControl.hp = Game.mLastGameHP;
						if (206255 - 596315 == -390060)
						{
							characterControl.mp = Game.mLastGameMP;
							if (156083 - 142609 == 13474)
							{
								characterControl.sp = Game.mLastGameSP;
								if (59805 - 114197 == -54392)
								{
									characterControl.ko = Game.mLastGameKO;
									if (56238 - 208322 == -152084)
									{
										IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(Game.mLastGameTimeOutList);
										if (106359 - 360794 == -254435)
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
												if (54272 - 228422 != -174150)
												{
													goto IL_147;
												}
												characterControl.mTimeOutList.Add(timeOutClass);
												if (35585 - 186737 == -151151)
												{
													goto IL_147;
												}
												UnityRuntimeServices.Update(enumerator, timeOutClass);
												if (91883 - 447086 != -355203)
												{
													goto IL_147;
												}
											}
											if (12320 - 13379 == -1059)
											{
												characterControl.HPMPSPKOEvent();
												if (165771 - 368423 == -202652)
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

	// Token: 0x06005E6E RID: 24174 RVA: 0x00C9E5D4 File Offset: 0x00C9C7D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void loadNextLevel()
	{
		if (49299 - 271995 != -222696)
		{
		}
		for (;;)
		{
			bool flag = true;
			if (270223 - 153924 == 116299)
			{
				DateTime now = DateTime.Now;
				if (105851 - 9609 != 96243)
				{
					if (now.Hour % 6 < 3)
					{
						if (229945 - 8292 == 221654)
						{
							continue;
						}
						flag = false;
						if (125396 - 254773 != -129377)
						{
							continue;
						}
					}
					int num = Game.mNextGameCode;
					if (158077 - 537846 != -379768)
					{
						if (num == 10)
						{
							if (38606 - 304953 != -266346)
							{
								Application.LoadLevel("L10_LobbyNoGuild");
								if (242201 - 230039 == 12162)
								{
									break;
								}
							}
						}
						else if (num == 11)
						{
							if (221745 - 74485 != 147261)
							{
								Application.LoadLevel("L11_LobbyPlain");
								if (186811 - 535918 != -349106)
								{
									break;
								}
							}
						}
						else if (num == 30)
						{
							if (298387 - 102697 == 195690)
							{
								if (flag)
								{
									if (26352 - 48270 == -21918)
									{
										Application.LoadLevel("G30_NoGuild");
										if (110281 - 410778 == -300497)
										{
											break;
										}
									}
								}
								else
								{
									Application.LoadLevel("G30_NoGuild_n");
									if (209803 - 130121 != 79683)
									{
										break;
									}
								}
							}
						}
						else if (num == 31)
						{
							if (181692 - 244369 == -62677)
							{
								if (flag)
								{
									if (168400 - 183738 != -15337)
									{
										Application.LoadLevel("G31_GuildPlain");
										if (94369 - 156637 != -62267)
										{
											break;
										}
									}
								}
								else
								{
									Application.LoadLevel("G31_GuildPlain_n");
									if (223231 - 497836 != -274604)
									{
										break;
									}
								}
							}
						}
						else if (num == 32)
						{
							if (85505 - 58152 != 27354)
							{
								Application.LoadLevel("G32_SnowCamp");
								if (260869 - 109253 == 151616)
								{
									break;
								}
							}
						}
						else if (num == 33)
						{
							if (52804 - 106585 != -53780)
							{
								Application.LoadLevel("G33_CrystalBeach");
								if (231045 - 343020 == -111975)
								{
									break;
								}
							}
						}
						else if (num == 34)
						{
							if (165540 - 29773 != 135768)
							{
								Application.LoadLevel("G34_ExcavationCamp");
								if (236374 - 194381 != 41994)
								{
									break;
								}
							}
						}
						else if (num == 35)
						{
							if (73345 - 190573 == -117228)
							{
								Application.LoadLevel("G35_UndergroundCamp");
								if (34913 - 352867 != -317953)
								{
									break;
								}
							}
						}
						else if (num == 36)
						{
							if (254009 - 368620 == -114611)
							{
								Application.LoadLevel("G36_ForestCamp");
								if (122456 - 432329 != -309872)
								{
									break;
								}
							}
						}
						else if (num == 51)
						{
							if (232575 - 202073 != 30503)
							{
								Application.LoadLevel("T51_MainStreet");
								if (83116 - 130220 != -47103)
								{
									break;
								}
							}
						}
						else if (num == 52)
						{
							if (20025 - 149818 == -129793)
							{
								Application.LoadLevel("T52_CentralSquare");
								if (72844 - 364099 != -291254)
								{
									break;
								}
							}
						}
						else if (num == 53)
						{
							if (161354 - 599592 == -438238)
							{
								Application.LoadLevel("T53_CityLibrary");
								if (65406 - 144638 == -79232)
								{
									break;
								}
							}
						}
						else if (num == 54)
						{
							if (7747 - 418493 != -410745)
							{
								Application.LoadLevel("T54_LightPark");
								if (130061 - 330221 != -200159)
								{
									break;
								}
							}
						}
						else if (num == 55)
						{
							if (72195 - 415764 != -343568)
							{
								Application.LoadLevel("T55_LightPalace");
								if (113505 - 314783 != -201277)
								{
									break;
								}
							}
						}
						else if (num == 56)
						{
							if (285076 - 184489 != 100588)
							{
								if (flag)
								{
									if (131217 - 307995 == -176778)
									{
										Application.LoadLevel("T56_PlainColosseum");
										if (244823 - 284660 != -39836)
										{
											break;
										}
									}
								}
								else
								{
									Application.LoadLevel("T56_PlainColosseum_n");
									if (109556 - 510869 == -401313)
									{
										break;
									}
								}
							}
						}
						else if (num == 57)
						{
							if (184139 - 98434 != 85706)
							{
								Application.LoadLevel("T57_LightTheater");
								if (170538 - 9167 != 161372)
								{
									break;
								}
							}
						}
						else if (num == 100)
						{
							if (99424 - 564295 == -464871)
							{
								Application.LoadLevel("M100_GameTutorial1");
								if (724 - 543800 == -543076)
								{
									break;
								}
							}
						}
						else if (num == 101)
						{
							if (1004 - 564543 != -563538)
							{
								Application.LoadLevel("M101_CarronHarvest");
								if (91350 - 352281 != -260930)
								{
									break;
								}
							}
						}
						else if (num == 102)
						{
							if (171204 - 151027 == 20177)
							{
								Application.LoadLevel("M102_MupoRoundUp");
								if (45066 - 276304 == -231238)
								{
									break;
								}
							}
						}
						else if (num == 103)
						{
							if (215037 - 128622 == 86415)
							{
								Application.LoadLevel("M103_BugTrouble");
								if (267669 - 408181 != -140511)
								{
									break;
								}
							}
						}
						else if (num == 104)
						{
							if (132014 - 522058 == -390044)
							{
								Application.LoadLevel("M104_StingbugNest");
								if (209790 - 574553 != -364762)
								{
									break;
								}
							}
						}
						else if (num == 105)
						{
							if (228180 - 216746 == 11434)
							{
								Application.LoadLevel("M105_NeedleCave");
								if (30959 - 259695 == -228736)
								{
									break;
								}
							}
						}
						else if (num == 106)
						{
							if (199481 - 546147 == -346666)
							{
								Application.LoadLevel("M106_BoldasRecruitment");
								if (220811 - 518176 == -297365)
								{
									break;
								}
							}
						}
						else if (num == 107)
						{
							if (113302 - 425900 != -312597)
							{
								Application.LoadLevel("M107_RequestFromAlcacia");
								if (139295 - 256215 == -116920)
								{
									break;
								}
							}
						}
						else if (num == 108)
						{
							if (200613 - 130693 != 69921)
							{
								Application.LoadLevel("M108_OneOnOneBout");
								if (13296 - 88019 == -74723)
								{
									break;
								}
							}
						}
						else if (num == 201)
						{
							if (57867 - 598831 != -540963)
							{
								Application.LoadLevel("M201_MupoFarmWatch");
								if (157661 - 444873 == -287212)
								{
									break;
								}
							}
						}
						else if (num == 202)
						{
							if (235032 - 7213 != 227820)
							{
								Application.LoadLevel("M202_RunMupoRun");
								if (281597 - 161886 != 119712)
								{
									break;
								}
							}
						}
						else if (num == 203)
						{
							if (67588 - 353962 == -286374)
							{
								Application.LoadLevel("M203_StartofALongJourney");
								if (97497 - 30639 != 66859)
								{
									break;
								}
							}
						}
						else if (num == 204)
						{
							if (3143 - 463397 == -460254)
							{
								Application.LoadLevel("M204_HighWayRobbery");
								if (70352 - 170398 != -100045)
								{
									break;
								}
							}
						}
						else if (num == 205)
						{
							if (62852 - 180193 != -117340)
							{
								Application.LoadLevel("M205_CrossingPlainLagoon1");
								if (271166 - 450180 == -179014)
								{
									break;
								}
							}
						}
						else if (num == 206)
						{
							if (171895 - 215989 == -44094)
							{
								Application.LoadLevel("M206_GrandTheftMupo1");
								if (7734 - 557341 != -549606)
								{
									break;
								}
							}
						}
						else if (num == 207)
						{
							if (5778 - 483310 == -477532)
							{
								Application.LoadLevel("M207_TroublingGiant");
								if (42079 - 197162 != -155082)
								{
									break;
								}
							}
						}
						else if (num == 208)
						{
							if (207209 - 489428 != -282218)
							{
								Application.LoadLevel("M208_DoubleDuel");
								if (71885 - 4300 != 67586)
								{
									break;
								}
							}
						}
						else if (num == 301)
						{
							if (66071 - 431901 != -365829)
							{
								Application.LoadLevel("M301_FrozenPeppon");
								if (149068 - 174405 != -25336)
								{
									break;
								}
							}
						}
						else if (num == 302)
						{
							if (173310 - 172430 == 880)
							{
								Application.LoadLevel("M302_SnowPineForest");
								if (68657 - 327479 != -258821)
								{
									break;
								}
							}
						}
						else if (num == 303)
						{
							if (255649 - 194094 != 61556)
							{
								Application.LoadLevel("M303_SnowPass");
								if (38699 - 454074 != -415374)
								{
									break;
								}
							}
						}
						else if (num == 304)
						{
							if (201949 - 381846 != -179896)
							{
								Application.LoadLevel("M304_SamuraiFort");
								if (238459 - 456656 == -218197)
								{
									break;
								}
							}
						}
						else if (num == 305)
						{
							if (144147 - 189106 != -44958)
							{
								Application.LoadLevel("M305_ItalusAcceptance1");
								if (29186 - 260432 != -231245)
								{
									break;
								}
							}
						}
						else if (num == 306)
						{
							if (220651 - 361301 != -140649)
							{
								Application.LoadLevel("M306_FireCaveEntrance1");
								if (275991 - 57541 != 218451)
								{
									break;
								}
							}
						}
						else if (num == 307)
						{
							if (260735 - 110469 == 150266)
							{
								Application.LoadLevel("M307_FireThrone");
								if (291375 - 494818 != -203442)
								{
									break;
								}
							}
						}
						else if (num == 308)
						{
							if (201239 - 179229 == 22010)
							{
								Application.LoadLevel("M308_TripleTrouble");
								if (24604 - 270683 != -246078)
								{
									break;
								}
							}
						}
						else if (num == 401)
						{
							if (226621 - 83959 == 142662)
							{
								Application.LoadLevel("M401_DownFromVolcano1");
								if (59900 - 526616 == -466716)
								{
									break;
								}
							}
						}
						else if (num == 402)
						{
							if (116670 - 438719 != -322048)
							{
								Application.LoadLevel("M402_DesertPath1");
								if (3099 - 55799 == -52700)
								{
									break;
								}
							}
						}
						else if (num == 403)
						{
							if (47927 - 8417 == 39510)
							{
								Application.LoadLevel("M403_CactonGarden");
								if (146548 - 285991 != -139442)
								{
									break;
								}
							}
						}
						else if (num == 404)
						{
							if (294452 - 577308 == -282856)
							{
								Application.LoadLevel("M404_SandOasis");
								if (272441 - 117602 == 154839)
								{
									break;
								}
							}
						}
						else if (num == 405)
						{
							if (238442 - 597101 != -358658)
							{
								Application.LoadLevel("M405_WindValleyEntrance1");
								if (252304 - 523932 == -271628)
								{
									break;
								}
							}
						}
						else if (num == 406)
						{
							if (260856 - 261516 != -659)
							{
								Application.LoadLevel("M406_WindValley");
								if (108583 - 160290 == -51707)
								{
									break;
								}
							}
						}
						else if (num == 407)
						{
							if (280287 - 578234 == -297947)
							{
								Application.LoadLevel("M407_CatchTheWind");
								if (169034 - 39465 == 129569)
								{
									break;
								}
							}
						}
						else if (num == 408)
						{
							if (239777 - 403772 != -163994)
							{
								Application.LoadLevel("M408_DesertSurvival");
								if (216142 - 347272 != -131129)
								{
									break;
								}
							}
						}
						else if (num == 501)
						{
							if (104273 - 241928 != -137654)
							{
								Application.LoadLevel("M501_ThroughTheSwamp1");
								if (259159 - 193931 == 65228)
								{
									break;
								}
							}
						}
						else if (num == 502)
						{
							if (292427 - 53775 == 238652)
							{
								Application.LoadLevel("M502_ToTheBeach");
								if (231302 - 263024 == -31722)
								{
									break;
								}
							}
						}
						else if (num == 503)
						{
							if (198162 - 252243 == -54081)
							{
								Application.LoadLevel("M503_TwoTurtleSages");
								if (54807 - 185924 == -131117)
								{
									break;
								}
							}
						}
						else if (num == 504)
						{
							if (177920 - 373754 == -195834)
							{
								Application.LoadLevel("M504_WaterTemple");
								if (53417 - 78962 != -25544)
								{
									break;
								}
							}
						}
						else if (num == 505)
						{
							if (99582 - 496355 != -396772)
							{
								Application.LoadLevel("M505_SunkenCity1");
								if (47559 - 404622 != -357062)
								{
									break;
								}
							}
						}
						else if (num == 506)
						{
							if (101923 - 495591 != -393667)
							{
								Application.LoadLevel("M506_PearlPalace");
								if (118694 - 596855 != -478160)
								{
									break;
								}
							}
						}
						else if (num == 507)
						{
							if (197293 - 310823 == -113530)
							{
								Application.LoadLevel("M507_AnemoneDecision");
								if (248404 - 378506 != -130101)
								{
									break;
								}
							}
						}
						else if (num == 508)
						{
							if (83236 - 187569 == -104333)
							{
								Application.LoadLevel("M508_SmashBall");
								if (40519 - 224470 != -183950)
								{
									break;
								}
							}
						}
						else if (num == 601)
						{
							if (285784 - 178748 != 107037)
							{
								Application.LoadLevel("M601_FlightBackToTheCity");
								if (299385 - 581702 != -282316)
								{
									break;
								}
							}
						}
						else if (num == 602)
						{
							if (52510 - 67300 == -14790)
							{
								Application.LoadLevel("M602_HighWayBlockade");
								if (212030 - 559268 != -347237)
								{
									break;
								}
							}
						}
						else if (num == 603)
						{
							if (157831 - 160295 != -2463)
							{
								Application.LoadLevel("M603_ShadeInTheCity1");
								if (175660 - 237951 != -62290)
								{
									break;
								}
							}
						}
						else if (num == 604)
						{
							if (59288 - 323884 != -264595)
							{
								Application.LoadLevel("M604_SmashingPumpkon");
								if (58236 - 444370 == -386134)
								{
									break;
								}
							}
						}
						else if (num == 605)
						{
							if (116690 - 458769 == -342079)
							{
								Application.LoadLevel("M605_LightGardenDefense");
								if (118166 - 366453 == -248287)
								{
									break;
								}
							}
						}
						else if (num == 606)
						{
							if (154267 - 171095 == -16828)
							{
								Application.LoadLevel("M606_WalrusGoneMad");
								if (289214 - 204830 != 84385)
								{
									break;
								}
							}
						}
						else if (num == 607)
						{
							if (254535 - 266012 != -11476)
							{
								Application.LoadLevel("M607_MessageFromShadow");
								if (44451 - 217610 != -173158)
								{
									break;
								}
							}
						}
						else if (num == 608)
						{
							if (191271 - 568795 == -377524)
							{
								Application.LoadLevel("M608_FiveOnFiveChallenge");
								if (37989 - 144846 != -106856)
								{
									break;
								}
							}
						}
						else if (num == 701)
						{
							if (210030 - 476345 == -266315)
							{
								Application.LoadLevel("M701_StrangeNewFoe");
								if (118785 - 59954 == 58831)
								{
									break;
								}
							}
						}
						else if (num == 702)
						{
							if (212377 - 133941 != 78437)
							{
								Application.LoadLevel("M702_EasternWorldDivide1");
								if (163113 - 554628 == -391515)
								{
									break;
								}
							}
						}
						else if (num == 703)
						{
							if (70223 - 122012 == -51789)
							{
								Application.LoadLevel("M703_SandDuneTerror");
								if (211581 - 550719 == -339138)
								{
									break;
								}
							}
						}
						else if (num == 704)
						{
							if (2351 - 492972 == -490621)
							{
								Application.LoadLevel("M704_ZappaBaseEntrance");
								if (253509 - 499874 == -246365)
								{
									break;
								}
							}
						}
						else if (num == 705)
						{
							if (106548 - 65741 == 40807)
							{
								Application.LoadLevel("M705_InsideZappaBase");
								if (247209 - 504775 == -257566)
								{
									break;
								}
							}
						}
						else if (num == 706)
						{
							if (235881 - 316108 == -80227)
							{
								Application.LoadLevel("M706_MeetDrZappa");
								if (70655 - 442013 == -371358)
								{
									break;
								}
							}
						}
						else if (num == 707)
						{
							if (241160 - 389535 == -148375)
							{
								Application.LoadLevel("M707_MachineFromThePast");
								if (21709 - 332669 == -310960)
								{
									break;
								}
							}
						}
						else if (num == 708)
						{
							if (285700 - 494107 == -208407)
							{
								Application.LoadLevel("M708_SmackRun");
								if (225841 - 194051 == 31790)
								{
									break;
								}
							}
						}
						else if (num == 801)
						{
							if (227417 - 442176 != -214758)
							{
								Application.LoadLevel("M801_LifeAsAGallonBot");
								if (271053 - 386815 == -115762)
								{
									break;
								}
							}
						}
						else if (num == 802)
						{
							if (220350 - 147865 != 72486)
							{
								Application.LoadLevel("M802_BoldasFinalTest");
								if (191176 - 219794 == -28618)
								{
									break;
								}
							}
						}
						else if (num == 803)
						{
							if (56246 - 348404 == -292158)
							{
								Application.LoadLevel("M803_SteelInvader");
								if (109780 - 327589 == -217809)
								{
									break;
								}
							}
						}
						else if (num == 804)
						{
							if (293725 - 470499 != -176773)
							{
								Application.LoadLevel("M804_LibraryElevator");
								if (210307 - 231641 != -21333)
								{
									break;
								}
							}
						}
						else if (num == 805)
						{
							if (194936 - 392462 != -197525)
							{
								Application.LoadLevel("M805_LightVaultCleaning");
								if (216419 - 513319 != -296899)
								{
									break;
								}
							}
						}
						else if (num == 806)
						{
							if (265103 - 116267 == 148836)
							{
								Application.LoadLevel("M806_EnlagearsFlagment");
								if (150428 - 385055 == -234627)
								{
									break;
								}
							}
						}
						else if (num == 807)
						{
							if (289651 - 361820 != -72168)
							{
								Application.LoadLevel("M807_RemnantOfTime");
								if (113742 - 482766 != -369023)
								{
									break;
								}
							}
						}
						else if (num == 808)
						{
							if (205784 - 424917 != -219132)
							{
								Application.LoadLevel("M808_MonsterArena");
								if (177144 - 549650 == -372506)
								{
									break;
								}
							}
						}
						else if (num == 901)
						{
							if (89527 - 349289 != -259761)
							{
								Application.LoadLevel("M901_BurningSnowForest");
								if (252087 - 429036 != -176948)
								{
									break;
								}
							}
						}
						else if (num == 902)
						{
							if (148632 - 155709 != -7076)
							{
								Application.LoadLevel("M902_MadVegetables");
								if (74535 - 549537 == -475002)
								{
									break;
								}
							}
						}
						else if (num == 903)
						{
							if (138298 - 367892 == -229594)
							{
								Application.LoadLevel("M903_ShadowPalace1");
								if (151209 - 550527 == -399318)
								{
									break;
								}
							}
						}
						else if (num == 904)
						{
							if (71304 - 598023 == -526719)
							{
								Application.LoadLevel("M904_BattleWithZerbiras");
								if (20189 - 544311 != -524121)
								{
									break;
								}
							}
						}
						else if (num == 905)
						{
							if (102996 - 348416 != -245419)
							{
								Application.LoadLevel("M905_DarknessWithIn");
								if (145411 - 25100 == 120311)
								{
									break;
								}
							}
						}
						else if (num == 906)
						{
							if (110791 - 335674 == -224883)
							{
								Application.LoadLevel("M906_ShadowGodZera1");
								if (181818 - 339889 != -158070)
								{
									break;
								}
							}
						}
						else if (num == 907)
						{
							if (171125 - 145782 == 25343)
							{
								Application.LoadLevel("M907_ZerasHiddenPlan");
								if (54817 - 310438 == -255621)
								{
									break;
								}
							}
						}
						else if (num == 908)
						{
							if (250221 - 455223 != -205001)
							{
								Application.LoadLevel("M908_SurprisedAssault");
								if (65253 - 485717 == -420464)
								{
									break;
								}
							}
						}
						else if (num == 911)
						{
							if (250948 - 355051 == -104103)
							{
								Application.LoadLevel("M911_LavuAttack1");
								if (43031 - 505094 == -462063)
								{
									break;
								}
							}
						}
						else if (num == 912)
						{
							if (284794 - 48682 == 236112)
							{
								Application.LoadLevel("M912_ArmyTraining");
								if (41688 - 532588 == -490900)
								{
									break;
								}
							}
						}
						else if (num == 913)
						{
							if (186787 - 99779 == 87008)
							{
								Application.LoadLevel("M913_CarrierSite1");
								if (214816 - 25967 != 188850)
								{
									break;
								}
							}
						}
						else if (num == 914)
						{
							if (238100 - 17307 == 220793)
							{
								Application.LoadLevel("M914_GuildUnderAttack");
								if (34044 - 432705 == -398661)
								{
									break;
								}
							}
						}
						else if (num == 915)
						{
							if (240540 - 432931 == -192391)
							{
								Application.LoadLevel("M915_BattleAtGreatPlain");
								if (67725 - 534202 == -466477)
								{
									break;
								}
							}
						}
						else if (num == 916)
						{
							if (234611 - 393185 == -158574)
							{
								Application.LoadLevel("M916_CityUnderSiege");
								if (283857 - 390991 != -107133)
								{
									break;
								}
							}
						}
						else if (num == 917)
						{
							if (163250 - 424721 != -261470)
							{
								Application.LoadLevel("M917_WarRepose1");
								if (202122 - 193099 == 9023)
								{
									break;
								}
							}
						}
						else if (num == 918)
						{
							if (240932 - 421046 != -180113)
							{
								Application.LoadLevel("M918_Decathlon");
								if (72454 - 122087 == -49633)
								{
									break;
								}
							}
						}
						else if (num == 921)
						{
							if (138508 - 497682 == -359174)
							{
								Application.LoadLevel("M921_AncientForest1");
								if (17824 - 573224 != -555399)
								{
									break;
								}
							}
						}
						else if (num == 922)
						{
							if (128600 - 487371 == -358771)
							{
								Application.LoadLevel("M922_DancingHippos");
								if (149953 - 588340 == -438387)
								{
									break;
								}
							}
						}
						else if (num == 923)
						{
							if (260322 - 32650 == 227672)
							{
								Application.LoadLevel("M923_WarInTheForest");
								if (195592 - 214575 == -18983)
								{
									break;
								}
							}
						}
						else if (num == 924)
						{
							if (243475 - 205565 != 37911)
							{
								Application.LoadLevel("M924_LostWoods1");
								if (205649 - 151333 != 54317)
								{
									break;
								}
							}
						}
						else if (num == 925)
						{
							if (227115 - 319669 == -92554)
							{
								Application.LoadLevel("M925_WrathOfTitan1");
								if (54490 - 370708 != -316217)
								{
									break;
								}
							}
						}
						else if (num == 926)
						{
							if (170876 - 157071 != 13806)
							{
								Application.LoadLevel("M926_WhenWindStops");
								if (255648 - 469851 == -214203)
								{
									break;
								}
							}
						}
						else if (num == 927)
						{
							if (173085 - 271182 == -98097)
							{
								Application.LoadLevel("M927_SilentEarth");
								if (96655 - 208404 != -111748)
								{
									break;
								}
							}
						}
						else if (num == 928)
						{
							if (196532 - 79062 == 117470)
							{
								Application.LoadLevel("M928_JungleHunt");
								if (276403 - 539842 != -263438)
								{
									break;
								}
							}
						}
						else if (num == 931)
						{
							if (63331 - 130283 != -66951)
							{
								Application.LoadLevel("M931_IAmNoKnight");
								if (236384 - 390969 != -154584)
								{
									break;
								}
							}
						}
						else if (num == 932)
						{
							if (170253 - 527573 != -357319)
							{
								Application.LoadLevel("M932_WindHollow1");
								if (126020 - 446376 == -320356)
								{
									break;
								}
							}
						}
						else if (num == 933)
						{
							if (164536 - 399099 == -234563)
							{
								Application.LoadLevel("M933_MagmaPit1");
								if (31225 - 401612 == -370387)
								{
									break;
								}
							}
						}
						else if (num == 934)
						{
							if (183969 - 404161 != -220191)
							{
								Application.LoadLevel("M934_LadyNoirDarkRitual1");
								if (19717 - 251522 == -231805)
								{
									break;
								}
							}
						}
						else if (num == 935)
						{
							if (157977 - 31992 != 125986)
							{
								Application.LoadLevel("M935_TormentWoods1");
								if (247927 - 84296 == 163631)
								{
									break;
								}
							}
						}
						else if (num == 936)
						{
							if (111666 - 19955 != 91712)
							{
								Application.LoadLevel("M936_CrossingDestiny1");
								if (109504 - 194847 == -85343)
								{
									break;
								}
							}
						}
						else if (num == 937)
						{
							if (85104 - 360708 != -275603)
							{
								Application.LoadLevel("M937_BattleForTomorrow");
								if (153656 - 113925 == 39731)
								{
									break;
								}
							}
						}
						else if (num == 938)
						{
							if (246269 - 387018 == -140749)
							{
								Application.LoadLevel("M938_TimesMemories");
								if (164679 - 255878 != -91198)
								{
									break;
								}
							}
						}
						else if (num == 941)
						{
							if (254283 - 226616 == 27667)
							{
								Application.LoadLevel("M941_SkyBug");
								if (131224 - 224033 != -92808)
								{
									break;
								}
							}
						}
						else if (num == 942)
						{
							if (65045 - 324183 == -259138)
							{
								Application.LoadLevel("M942_CrystalBug");
								if (154220 - 449058 != -294837)
								{
									break;
								}
							}
						}
						else if (num == 943)
						{
							if (104156 - 27202 == 76954)
							{
								Application.LoadLevel("M943_AncientBug");
								if (40412 - 269682 != -229269)
								{
									break;
								}
							}
						}
						else if (num == 944)
						{
							if (236389 - 20171 == 216218)
							{
								Application.LoadLevel("M944_CoralBug");
								if (123513 - 228727 == -105214)
								{
									break;
								}
							}
						}
						else if (num == 945)
						{
							if (255697 - 366195 == -110498)
							{
								Application.LoadLevel("M945_MokBug");
								if (83576 - 30848 != 52729)
								{
									break;
								}
							}
						}
						else if (num == 946)
						{
							if (76654 - 327699 != -251044)
							{
								Application.LoadLevel("M946_GoldenKingBug");
								if (78600 - 168923 == -90323)
								{
									break;
								}
							}
						}
						else if (num == 947)
						{
							if (280679 - 145853 != 134827)
							{
								Application.LoadLevel("M947_NemesisBug");
								if (39957 - 502603 == -462646)
								{
									break;
								}
							}
						}
						else if (num == 961)
						{
							if (28863 - 593661 != -564797)
							{
								Application.LoadLevel("M961_DanceAudition");
								if (193439 - 430399 == -236960)
								{
									break;
								}
							}
						}
						else if (num == 965)
						{
							if (253654 - 578734 != -325079)
							{
								Application.LoadLevel("M965_UltimateQuiz");
								if (161855 - 484288 != -322432)
								{
									break;
								}
							}
						}
						else if (num == 966)
						{
							if (31061 - 299634 != -268572)
							{
								Application.LoadLevel("M966_XmasSpecial");
								if (277162 - 589985 == -312823)
								{
									break;
								}
							}
						}
						else if (num == 967)
						{
							if (5687 - 566200 != -560512)
							{
								Application.LoadLevel("M967_SplashWar");
								if (291575 - 107962 == 183613)
								{
									break;
								}
							}
						}
						else if (num == 968)
						{
							if (171752 - 52854 != 118899)
							{
								Application.LoadLevel("M968_RoadToWorldCup");
								if (205912 - 158244 == 47668)
								{
									break;
								}
							}
						}
						else if (num == 971)
						{
							if (54967 - 114119 != -59151)
							{
								Application.LoadLevel("M971_MaohsTomb1");
								if (99095 - 165455 != -66359)
								{
									break;
								}
							}
						}
						else if (num == 972)
						{
							if (274435 - 458970 == -184535)
							{
								Application.LoadLevel("M972_IceTower1");
								if (184694 - 30503 != 154192)
								{
									break;
								}
							}
						}
						else if (num == 973)
						{
							if (70783 - 282118 != -211334)
							{
								Application.LoadLevel("M973_PirateCave1");
								if (212013 - 446269 != -234255)
								{
									break;
								}
							}
						}
						else if (num == 981)
						{
							if (281907 - 69756 != 212152)
							{
								Application.LoadLevel("M981_FireArena");
								if (262897 - 255303 == 7594)
								{
									break;
								}
							}
						}
						else if (num == 982)
						{
							if (158540 - 487681 != -329140)
							{
								Application.LoadLevel("M982_BattleColosseum");
								if (209190 - 285437 == -76247)
								{
									break;
								}
							}
						}
						else if (num == 983)
						{
							if (170428 - 115115 != 55314)
							{
								Application.LoadLevel("M983_CrystalDefense");
								if (128915 - 323489 != -194573)
								{
									break;
								}
							}
						}
						else if (num == 984)
						{
							if (22759 - 270863 != -248103)
							{
								Application.LoadLevel("M984_SteelChaos");
								if (114117 - 105345 == 8772)
								{
									break;
								}
							}
						}
						else if (num == 985)
						{
							if (123338 - 4932 == 118406)
							{
								Application.LoadLevel("M985_DesolateWar");
								if (182637 - 36533 == 146104)
								{
									break;
								}
							}
						}
						else if (num == 986)
						{
							if (299000 - 400329 == -101329)
							{
								Application.LoadLevel("M986_FallenShadow");
								if (181606 - 175846 != 5761)
								{
									break;
								}
							}
						}
						else if (num == 987)
						{
							if (216632 - 526177 == -309545)
							{
								Application.LoadLevel("M987_VictoryBridge");
								if (170480 - 470413 == -299933)
								{
									break;
								}
							}
						}
						else if (num == 988)
						{
							if (280437 - 413673 != -133235)
							{
								Application.LoadLevel("M988_GuildWar");
								if (137585 - 546305 == -408720)
								{
									break;
								}
							}
						}
						else if (num == 991)
						{
							if (224097 - 323865 != -99767)
							{
								Application.LoadLevel("M991_ChampionshipArena");
								if (261102 - 429526 == -168424)
								{
									break;
								}
							}
						}
						else if (num == 992)
						{
							if (199067 - 4213 != 194855)
							{
								Application.LoadLevel("M992_FireLordsOrdeal");
								if (122120 - 129530 == -7410)
								{
									break;
								}
							}
						}
						else if (num == 993)
						{
							if (100557 - 337529 != -236971)
							{
								Application.LoadLevel("M993_WindsAmusement");
								if (116571 - 184463 == -67892)
								{
									break;
								}
							}
						}
						else
						{
							Application.LoadLevel("M101_CarronHarvest");
							if (15014 - 379811 == -364797)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005E6F RID: 24175 RVA: 0x00CA11BC File Offset: 0x00C9F3BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject createPlayer(Hashtable data)
	{
		if (185202 - 20933 != 164270)
		{
		}
		GameObject gameObject;
		for (;;)
		{
			string text;
			Vector3 vector;
			CharacterControl characterControl;
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (39706 - 558371 == -518664)
				{
					continue;
				}
				int num = RuntimeServices.UnboxInt32(data[71]);
				if (59477 - 4845 != 54632)
				{
					continue;
				}
				int uid = PlayerData.UID;
				if (141750 - 182759 == -41008)
				{
					continue;
				}
				CharacterData.useCharacter(num - 10 * uid);
				if (19868 - 465739 != -445871)
				{
					continue;
				}
				object obj2;
				object obj = obj2 = data[73];
				if (!(obj is string))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(string));
				}
				text = NetworkUtility.DecodeRace((string)obj2);
				if (229933 - 277848 == -47914 || 136907 - 74801 == 62107)
				{
					continue;
				}
				string a = text;
				if (56063 - 461572 == -405508)
				{
					continue;
				}
				GameObject original;
				if (a == "Wolf")
				{
					if (36670 - 323534 != -286864)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Wolf", typeof(GameObject));
					if (122824 - 77662 != 45162)
					{
						continue;
					}
				}
				else if (a == "Bison")
				{
					if (134162 - 227619 != -93457)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Bison", typeof(GameObject));
					if (265167 - 267025 == -1857)
					{
						continue;
					}
				}
				else if (a == "Panda")
				{
					if (45776 - 571180 != -525404)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Panda", typeof(GameObject));
					if (95323 - 578585 != -483262)
					{
						continue;
					}
				}
				else if (a == "Whale")
				{
					if (276387 - 16479 != 259908)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Whale", typeof(GameObject));
					if (30836 - 149845 == -119008)
					{
						continue;
					}
				}
				else if (a == "Cat")
				{
					if (28387 - 302059 == -273671)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Cat", typeof(GameObject));
					if (202290 - 295315 != -93025)
					{
						continue;
					}
				}
				else if (a == "Chameleon")
				{
					if (158029 - 493456 != -335427)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Chameleon", typeof(GameObject));
					if (206457 - 583675 != -377218)
					{
						continue;
					}
				}
				else if (a == "Mole")
				{
					if (123919 - 417959 == -294039)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Mole", typeof(GameObject));
					if (245614 - 181757 == 63858)
					{
						continue;
					}
				}
				else if (a == "Rabbit")
				{
					if (214205 - 516737 == -302531)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Rabbit", typeof(GameObject));
					if (223118 - 167237 != 55881)
					{
						continue;
					}
				}
				else if (a == "Monkey")
				{
					if (211918 - 104679 == 107240)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Monkey", typeof(GameObject));
					if (131344 - 272862 != -141518)
					{
						continue;
					}
				}
				else if (a == "Sheep")
				{
					if (248545 - 2942 == 245604)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Sheep", typeof(GameObject));
					if (114303 - 22121 == 92183)
					{
						continue;
					}
				}
				else if (a == "Penguin")
				{
					if (290979 - 505361 == -214381)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Penguin", typeof(GameObject));
					if (70341 - 410600 == -340258)
					{
						continue;
					}
				}
				else if (a == "Bat")
				{
					if (44298 - 100132 != -55834)
					{
						continue;
					}
					original = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Bat", typeof(GameObject));
					if (150631 - 482915 == -332283)
					{
						continue;
					}
				}
				else
				{
					Debug.Log("OnCreateChar Error:" + data[73]);
					if (39005 - 559837 != -520831)
					{
						break;
					}
					continue;
				}
				vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(data[122]), RuntimeServices.UnboxSingle(data[123]), RuntimeServices.UnboxSingle(data[124]));
				if (248107 - 424500 == -176392)
				{
					continue;
				}
				Vector3 forward = 0.005f * new Vector3(RuntimeServices.UnboxSingle(data[126]), RuntimeServices.UnboxSingle(data[127]), RuntimeServices.UnboxSingle(data[128]));
				if (23852 - 283707 != -259855)
				{
					continue;
				}
				gameObject = (GameObject)UnityEngine.Object.Instantiate(original, vector, Quaternion.LookRotation(forward));
				if (266447 - 80963 == 185485)
				{
					continue;
				}
				gameObject.layer = RuntimeServices.UnboxInt32(data[75]);
				if (284715 - 533316 == -248600)
				{
					continue;
				}
				gameObject.layer += 7;
				if (86077 - 46491 != 39586)
				{
					continue;
				}
				gameObject.tag = "Player";
				if (50390 - 594800 != -544410)
				{
					continue;
				}
				characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
				if (124599 - 448895 == -324295)
				{
					continue;
				}
				if (characterControl == null)
				{
					if (223495 - 180729 != 42767)
					{
						break;
					}
					continue;
				}
				else
				{
					characterControl.ActorNr = RuntimeServices.UnboxInt32(data[9]);
					if (117217 - 226116 != -108899)
					{
						continue;
					}
					CharacterControl characterControl2 = characterControl;
					object obj4;
					object obj3 = obj4 = data[72];
					if (!(obj3 is string))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(string));
					}
					characterControl2.Name = (string)obj4;
					if (32334 - 179083 != -146749)
					{
						continue;
					}
					characterControl.Lv = RuntimeServices.UnboxInt32(data[76]);
					if (197885 - 33256 != 164629)
					{
						continue;
					}
					characterControl.Skin = RuntimeServices.UnboxInt32(data[74]);
					if (261896 - 342745 == -80848)
					{
						continue;
					}
					characterControl.ownerID = RuntimeServices.UnboxInt32(data[81]);
					if (283691 - 482396 == -198704)
					{
						continue;
					}
					CharacterControl characterControl3 = characterControl;
					object obj6;
					object obj5 = obj6 = data[82];
					if (!(obj5 is string))
					{
						obj6 = RuntimeServices.Coerce(obj5, typeof(string));
					}
					characterControl3.ownerName = (string)obj6;
					if (119671 - 148686 != -29015)
					{
						continue;
					}
					CharacterControl characterControl4 = characterControl;
					object obj8;
					object obj7 = obj8 = data[83];
					if (!(obj7 is string))
					{
						obj8 = RuntimeServices.Coerce(obj7, typeof(string));
					}
					characterControl4.readGuildData((string)obj8);
					if (51781 - 446076 == -394294)
					{
						continue;
					}
					characterControl.isPlayer = true;
					if (102487 - 13734 == 88754)
					{
						continue;
					}
					characterControl.isControlled = true;
					if (155626 - 276879 == -121252)
					{
						continue;
					}
					characterControl.isMine = true;
					if (146320 - 340316 != -193996)
					{
						continue;
					}
					characterControl.mOriginalLayer = gameObject.layer;
					if (145011 - 539124 != -394113)
					{
						continue;
					}
					characterControl.vDirection = gameObject.transform.forward;
					if (289026 - 291673 != -2647)
					{
						continue;
					}
					characterControl.hp = RuntimeServices.UnboxInt32(data[101]);
					if (70632 - 518740 != -448108)
					{
						continue;
					}
					characterControl.mp = RuntimeServices.UnboxInt32(data[102]);
					if (222273 - 408087 == -185813)
					{
						continue;
					}
					characterControl.sp = RuntimeServices.UnboxInt32(data[103]);
					if (32762 - 459725 != -426963)
					{
						continue;
					}
					characterControl.ko = RuntimeServices.UnboxInt32(data[104]);
					if (283182 - 158847 != 124335)
					{
						continue;
					}
					characterControl.mhp = characterControl.hp;
					if (220393 - 292929 != -72536)
					{
						continue;
					}
					characterControl.mmp = characterControl.mp;
					if (283815 - 455812 == -171996)
					{
						continue;
					}
					characterControl.msp = characterControl.sp;
					if (68872 - 176235 == -107362)
					{
						continue;
					}
					characterControl.mko = characterControl.ko;
					if (42918 - 123229 == -80310)
					{
						continue;
					}
					characterControl.atk = RuntimeServices.UnboxInt32(data[105]);
					if (236746 - 42762 != 193984)
					{
						continue;
					}
					characterControl.def = RuntimeServices.UnboxInt32(data[106]);
					if (225018 - 140597 != 84421)
					{
						continue;
					}
					characterControl.agi = RuntimeServices.UnboxInt32(data[107]);
					if (35318 - 596410 != -561092)
					{
						continue;
					}
					characterControl.vit = RuntimeServices.UnboxInt32(data[108]);
					if (1566 - 12945 == -11378)
					{
						continue;
					}
					characterControl.mag = RuntimeServices.UnboxInt32(data[109]);
					if (165697 - 143868 == 21830)
					{
						continue;
					}
					characterControl.cha = RuntimeServices.UnboxInt32(data[110]);
					if (7733 - 380453 == -372719)
					{
						continue;
					}
					characterControl.tal = RuntimeServices.UnboxInt32(data[111]);
					if (238792 - 18648 != 220144)
					{
						continue;
					}
					characterControl.lck = RuntimeServices.UnboxInt32(data[112]);
					if (238264 - 97940 == 140325)
					{
						continue;
					}
					characterControl.weight = RuntimeServices.UnboxInt32(data[113]);
					if (172149 - 500483 != -328334)
					{
						continue;
					}
					int num2 = RuntimeServices.UnboxInt32(data[114]);
					if (112347 - 582807 != -470460)
					{
						continue;
					}
					characterControl.runSpeed = 0.01f * (float)num2;
					if (100284 - 597689 == -497404)
					{
						continue;
					}
					characterControl.nPosition = vector;
					if (75972 - 337088 == -261115)
					{
						continue;
					}
					characterControl.nSpeed = (float)0;
					if (255207 - 136653 == 118555)
					{
						continue;
					}
					characterControl.resetEquipment();
					if (134031 - 369627 == -235595)
					{
						continue;
					}
					CharacterControl characterControl5 = characterControl;
					object obj10;
					object obj9 = obj10 = data[116];
					if (!(obj9 is string))
					{
						obj10 = RuntimeServices.Coerce(obj9, typeof(string));
					}
					characterControl5.setEquipment((string)obj10);
					if (270563 - 246291 != 24272)
					{
						continue;
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[characterControl.ActorNr], null))
					{
						if (150137 - 252188 == -102050)
						{
							continue;
						}
						Debug.Log("ActorNr: " + characterControl.ActorNr + " already existed");
						if (251815 - 391723 != -139908)
						{
							continue;
						}
						object obj12;
						object obj11 = obj12 = PhotonClient.ActorNrList[characterControl.ActorNr];
						if (!(obj11 is GameObject))
						{
							obj12 = RuntimeServices.Coerce(obj11, typeof(GameObject));
						}
						GameObject obj13 = (GameObject)obj12;
						if (86645 - 337671 == -251025)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj13);
						if (216919 - 266376 == -49456)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(characterControl.ActorNr, gameObject);
					if (219159 - 501224 == -282064)
					{
						continue;
					}
					Game.mPlayer = gameObject;
					if (62159 - 409404 != -347245)
					{
						continue;
					}
					Game.mPlayerID = characterControl.ActorNr;
					if (11770 - 248207 != -236437)
					{
						continue;
					}
					Game.mTeam = RuntimeServices.UnboxInt32(data[75]);
					if (206800 - 526224 != -319424)
					{
						continue;
					}
					characterControl.loadCharacterData();
					if (7919 - 272700 != -264781)
					{
						continue;
					}
				}
			}
			else
			{
				Debug.Log("Create Player Error : Wrong ID ->" + data[81]);
				if (124385 - 292802 != -168417)
				{
					continue;
				}
			}
			if (text == "Whale")
			{
				if (164610 - 460633 != -296023)
				{
					continue;
				}
				int num3 = 0;
				if (121909 - 211957 != -90048)
				{
					continue;
				}
				if (characterControl.hasSkill(131))
				{
					if (7421 - 193455 != -186034)
					{
						continue;
					}
					num3++;
					if (215173 - 60390 == 154784)
					{
						continue;
					}
				}
				if (characterControl.hasSkill(132))
				{
					if (197398 - 573158 == -375759)
					{
						continue;
					}
					num3++;
					if (31153 - 76509 != -45356)
					{
						continue;
					}
				}
				if (characterControl.hasSkill(133))
				{
					if (1510 - 413838 != -412328)
					{
						continue;
					}
					num3++;
					if (129591 - 145350 != -15759)
					{
						continue;
					}
				}
				if (characterControl.hasSkill(134))
				{
					if (71649 - 593525 == -521875)
					{
						continue;
					}
					num3++;
					if (194080 - 317441 != -123361)
					{
						continue;
					}
				}
				if (characterControl.hasSkill(431))
				{
					if (72004 - 274040 != -202036)
					{
						continue;
					}
					num3++;
					if (137171 - 464011 == -326839)
					{
						continue;
					}
				}
				CharacterController characterController = (CharacterController)gameObject.GetComponent(typeof(CharacterController));
				if (189270 - 435578 != -246308)
				{
					continue;
				}
				if (characterController)
				{
					if (112837 - 504338 != -391501)
					{
						continue;
					}
					Transform transform = gameObject.transform.Find("Whale_tri");
					if (125236 - 163130 != -37894)
					{
						continue;
					}
					transform.transform.localScale = Vector3.one * (0.8f + 0.05f * (float)num3);
					if (144065 - 533703 != -389638)
					{
						continue;
					}
					characterController.height = (float)2 + 0.1f * (float)num3;
					if (150828 - 317315 == -166486)
					{
						continue;
					}
					characterController.radius = 0.6f + 0.05f * (float)num3;
					if (103889 - 263736 != -159847)
					{
						continue;
					}
					float y = 1.1f + 0.05f * (float)num3;
					if (167637 - 558566 != -390929)
					{
						continue;
					}
					Vector3 center = characterController.center;
					if (218185 - 216862 != 1323)
					{
						continue;
					}
					center.y = y;
					if (153145 - 157603 == -4457 || 62504 - 486872 == -424367)
					{
						continue;
					}
					characterController.center = center;
					if (75423 - 468257 == -392833)
					{
						continue;
					}
					if (130353 - 473948 != -343595)
					{
						continue;
					}
				}
			}
			if (Game.mGameType <= 3)
			{
				goto IL_17DA;
			}
			if (145223 - 573822 != -428598)
			{
				int playerSlot = Game.getPlayerSlot(characterControl.ownerID);
				if (18017 - 38817 == -20800)
				{
					gameObject.name = "Player" + playerSlot;
					if (33305 - 42746 != -9440)
					{
						if (Game.mGamePlayerList.Contains(playerSlot))
						{
							if (189793 - 528864 == -339070)
							{
								continue;
							}
							Game.mGamePlayerList[playerSlot] = gameObject;
							if (169660 - 356725 == -187064)
							{
								continue;
							}
						}
						else
						{
							Game.mGamePlayerList.Add(playerSlot, gameObject);
							if (233492 - 228966 == 4527)
							{
								continue;
							}
						}
						if (Game.mGamePlayerName.Contains(playerSlot))
						{
							if (1214 - 147238 == -146023)
							{
								continue;
							}
							Game.mGamePlayerName[playerSlot] = characterControl.Name;
							if (24299 - 222441 != -198142)
							{
								continue;
							}
						}
						else
						{
							Game.mGamePlayerName.Add(playerSlot, characterControl.Name);
							if (264439 - 54243 != 210196)
							{
								continue;
							}
						}
						if (Game.mGamePlayerType.Contains(gameObject.name))
						{
							if (24941 - 470430 == -445488)
							{
								continue;
							}
							Game.mGamePlayerType[gameObject.name] = text;
							if (200531 - 594317 != -393786)
							{
								continue;
							}
						}
						else
						{
							Game.mGamePlayerType.Add(gameObject.name, text);
							if (75526 - 73366 != 2160)
							{
								continue;
							}
						}
						string name = "Team" + (gameObject.layer - 7);
						if (174771 - 158917 != 15855)
						{
							GameObject gameObject2 = GameObject.Find(name);
							if (146475 - 571439 != -424963)
							{
								if (!gameObject2)
								{
									if (165557 - 795 != 164762)
									{
										continue;
									}
									gameObject2 = new GameObject(name);
									if (209700 - 25332 == 184369)
									{
										continue;
									}
								}
								gameObject.transform.parent = gameObject2.transform;
								if (274352 - 501977 == -227625)
								{
									Debug.Log(gameObject.name + " created : ID=" + characterControl.ActorNr + "@" + vector + " Team : " + gameObject.layer);
									if (49534 - 102552 == -53018)
									{
										goto IL_17DA;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_17E1;
		IL_17DA:
		return gameObject;
		IL_17E1:
		return null;
	}

	// Token: 0x06005E70 RID: 24176 RVA: 0x00CA29BC File Offset: 0x00CA0BBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject createPeer(Hashtable data)
	{
		if (94230 - 497551 != -403321)
		{
		}
		GameObject gameObject2;
		for (;;)
		{
			object obj2;
			object obj = obj2 = data[73];
			if (!(obj is string))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(string));
			}
			string text = NetworkUtility.DecodeRace((string)obj2);
			if (75612 - 205672 == -130060)
			{
				if (249159 - 438448 == -189289)
				{
					bool flag = false;
					if (247668 - 549856 == -302188)
					{
						string a = text;
						if (107682 - 127500 == -19818)
						{
							GameObject gameObject;
							if (a == "Wolf")
							{
								if (87048 - 30436 == 56613)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Wolf", typeof(GameObject));
								if (31901 - 38251 == -6349)
								{
									continue;
								}
							}
							else if (a == "Bison")
							{
								if (267876 - 129749 != 138127)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Bison", typeof(GameObject));
								if (60687 - 235723 != -175036)
								{
									continue;
								}
							}
							else if (a == "Panda")
							{
								if (213798 - 483313 != -269515)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Panda", typeof(GameObject));
								if (265122 - 493160 == -228037)
								{
									continue;
								}
							}
							else if (a == "Whale")
							{
								if (285672 - 580506 != -294834)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Whale", typeof(GameObject));
								if (234476 - 24122 == 210355)
								{
									continue;
								}
							}
							else if (a == "Cat")
							{
								if (15622 - 276493 != -260871)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Cat", typeof(GameObject));
								if (64259 - 366017 == -301757)
								{
									continue;
								}
							}
							else if (a == "Chameleon")
							{
								if (68499 - 377770 == -309270)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Chameleon", typeof(GameObject));
								if (2322 - 388257 == -385934)
								{
									continue;
								}
							}
							else if (a == "Mole")
							{
								if (6992 - 522646 == -515653)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Mole", typeof(GameObject));
								if (30872 - 383668 == -352795)
								{
									continue;
								}
							}
							else if (a == "Rabbit")
							{
								if (277650 - 130181 != 147469)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Rabbit", typeof(GameObject));
								if (16520 - 334841 == -318320)
								{
									continue;
								}
							}
							else if (a == "Monkey")
							{
								if (210289 - 289281 != -78992)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Monkey", typeof(GameObject));
								if (137724 - 200915 == -63190)
								{
									continue;
								}
							}
							else if (a == "Sheep")
							{
								if (154757 - 455612 == -300854)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Sheep", typeof(GameObject));
								if (3862 - 597085 == -593222)
								{
									continue;
								}
							}
							else if (a == "Penguin")
							{
								if (3828 - 219648 == -215819)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Penguin", typeof(GameObject));
								if (58001 - 37632 != 20369)
								{
									continue;
								}
							}
							else if (a == "Bat")
							{
								if (80917 - 304537 != -223620)
								{
									continue;
								}
								gameObject = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Bat", typeof(GameObject));
								if (2072 - 83339 != -81267)
								{
									continue;
								}
							}
							else
							{
								object obj4;
								object obj3 = obj4 = data[73];
								if (!(obj3 is string))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(string));
								}
								text = (string)obj4;
								if (279048 - 474439 != -195391)
								{
									continue;
								}
								gameObject = Game.getPrefab(text);
								if (287423 - 532433 != -245010)
								{
									continue;
								}
								if (gameObject)
								{
									if (186086 - 187076 == -989)
									{
										continue;
									}
									flag = true;
									if (248243 - 53318 != 194925)
									{
										continue;
									}
								}
								else
								{
									Debug.Log("OnCreatePeer Error:" + text);
									if (223521 - 450492 != -226971)
									{
										continue;
									}
									break;
								}
							}
							Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(data[122]), RuntimeServices.UnboxSingle(data[123]), RuntimeServices.UnboxSingle(data[124]));
							if (210793 - 549759 != -338965)
							{
								Vector3 forward = 0.005f * new Vector3(RuntimeServices.UnboxSingle(data[126]), RuntimeServices.UnboxSingle(data[127]), RuntimeServices.UnboxSingle(data[128]));
								if (203505 - 63422 == 140083)
								{
									gameObject2 = (GameObject)UnityEngine.Object.Instantiate(gameObject, vector, Quaternion.LookRotation(forward));
									if (29464 - 580489 != -551024)
									{
										gameObject2.layer = RuntimeServices.UnboxInt32(data[75]);
										if (173362 - 411462 == -238100)
										{
											gameObject2.layer += 7;
											if (38631 - 486295 != -447663)
											{
												gameObject2.tag = "Player";
												if (89056 - 493901 != -404844)
												{
													CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
													if (294337 - 162917 == 131420)
													{
														if (characterControl != null)
														{
															if (187858 - 29685 == 158174)
															{
																continue;
															}
															characterControl.ActorNr = RuntimeServices.UnboxInt32(data[9]);
															if (254933 - 24023 == 230911)
															{
																continue;
															}
															CharacterControl characterControl2 = characterControl;
															object obj6;
															object obj5 = obj6 = data[72];
															if (!(obj5 is string))
															{
																obj6 = RuntimeServices.Coerce(obj5, typeof(string));
															}
															characterControl2.Name = (string)obj6;
															if (257648 - 215260 == 42389)
															{
																continue;
															}
															characterControl.Lv = RuntimeServices.UnboxInt32(data[76]);
															if (21128 - 96758 == -75629)
															{
																continue;
															}
															characterControl.Skin = RuntimeServices.UnboxInt32(data[74]);
															if (69156 - 50370 != 18786)
															{
																continue;
															}
															characterControl.ownerID = RuntimeServices.UnboxInt32(data[81]);
															if (21516 - 118840 == -97323)
															{
																continue;
															}
															CharacterControl characterControl3 = characterControl;
															object obj8;
															object obj7 = obj8 = data[82];
															if (!(obj7 is string))
															{
																obj8 = RuntimeServices.Coerce(obj7, typeof(string));
															}
															characterControl3.ownerName = (string)obj8;
															if (83241 - 427451 != -344210)
															{
																continue;
															}
															CharacterControl characterControl4 = characterControl;
															object obj10;
															object obj9 = obj10 = data[83];
															if (!(obj9 is string))
															{
																obj10 = RuntimeServices.Coerce(obj9, typeof(string));
															}
															characterControl4.readGuildData((string)obj10);
															if (60869 - 130533 == -69663)
															{
																continue;
															}
															characterControl.isPlayer = true;
															if (103735 - 530305 != -426570)
															{
																continue;
															}
															characterControl.isControlled = true;
															if (199725 - 507442 == -307716)
															{
																continue;
															}
															characterControl.isMine = false;
															if (181786 - 163236 == 18551)
															{
																continue;
															}
															characterControl.mOriginalLayer = gameObject2.layer;
															if (88241 - 110031 != -21790)
															{
																continue;
															}
															characterControl.vDirection = gameObject2.transform.forward;
															if (193356 - 324445 == -131088)
															{
																continue;
															}
															characterControl.hp = RuntimeServices.UnboxInt32(data[101]);
															if (124396 - 125257 == -860)
															{
																continue;
															}
															characterControl.mp = RuntimeServices.UnboxInt32(data[102]);
															if (254181 - 310885 != -56704)
															{
																continue;
															}
															characterControl.sp = RuntimeServices.UnboxInt32(data[103]);
															if (116795 - 329288 == -212492)
															{
																continue;
															}
															characterControl.ko = RuntimeServices.UnboxInt32(data[104]);
															if (14644 - 144137 == -129492)
															{
																continue;
															}
															characterControl.mhp = characterControl.hp;
															if (151985 - 274837 == -122851)
															{
																continue;
															}
															characterControl.mmp = characterControl.mp;
															if (194098 - 397632 != -203534)
															{
																continue;
															}
															characterControl.msp = characterControl.sp;
															if (165983 - 86133 != 79850)
															{
																continue;
															}
															characterControl.mko = characterControl.ko;
															if (299281 - 262223 != 37058)
															{
																continue;
															}
															characterControl.atk = RuntimeServices.UnboxInt32(data[105]);
															if (63442 - 491446 == -428003)
															{
																continue;
															}
															characterControl.def = RuntimeServices.UnboxInt32(data[106]);
															if (291374 - 502856 != -211482)
															{
																continue;
															}
															characterControl.agi = RuntimeServices.UnboxInt32(data[107]);
															if (64105 - 496186 == -432080)
															{
																continue;
															}
															characterControl.vit = RuntimeServices.UnboxInt32(data[108]);
															if (58035 - 393346 == -335310)
															{
																continue;
															}
															characterControl.mag = RuntimeServices.UnboxInt32(data[109]);
															if (8059 - 17397 != -9338)
															{
																continue;
															}
															characterControl.cha = RuntimeServices.UnboxInt32(data[110]);
															if (3892 - 582 == 3311)
															{
																continue;
															}
															characterControl.tal = RuntimeServices.UnboxInt32(data[111]);
															if (241036 - 224353 == 16684)
															{
																continue;
															}
															characterControl.lck = RuntimeServices.UnboxInt32(data[112]);
															if (142237 - 482131 != -339894)
															{
																continue;
															}
															if (!flag)
															{
																if (18387 - 276028 == -257640)
																{
																	continue;
																}
																characterControl.weight = RuntimeServices.UnboxInt32(data[113]);
																if (28817 - 342144 == -313326)
																{
																	continue;
																}
																int num = RuntimeServices.UnboxInt32(data[114]);
																if (290319 - 200835 != 89484)
																{
																	continue;
																}
																characterControl.runSpeed = 0.01f * (float)num;
																if (247998 - 482028 == -234029)
																{
																	continue;
																}
																characterControl.nPosition = vector;
																if (248847 - 17608 == 231240)
																{
																	continue;
																}
																characterControl.nSpeed = (float)0;
																if (42160 - 137792 != -95632)
																{
																	continue;
																}
															}
															characterControl.resetEquipment();
															if (165949 - 297762 == -131812)
															{
																continue;
															}
															CharacterControl characterControl5 = characterControl;
															object obj12;
															object obj11 = obj12 = data[116];
															if (!(obj11 is string))
															{
																obj12 = RuntimeServices.Coerce(obj11, typeof(string));
															}
															characterControl5.setEquipment((string)obj12);
															if (168567 - 531027 == -362459)
															{
																continue;
															}
															CharacterControl characterControl6 = characterControl;
															object obj14;
															object obj13 = obj14 = data[118];
															if (!(obj13 is int[]))
															{
																obj14 = RuntimeServices.Coerce(obj13, typeof(int[]));
															}
															characterControl6.readSkill((int[])obj14);
															if (264079 - 410786 != -146707)
															{
																continue;
															}
														}
														if (text == "Whale")
														{
															if (215904 - 372096 != -156192)
															{
																continue;
															}
															int num2 = 0;
															if (187495 - 483174 == -295678)
															{
																continue;
															}
															if (characterControl.hasSkill(131))
															{
																if (200615 - 459022 == -258406)
																{
																	continue;
																}
																num2++;
																if (62206 - 53371 == 8836)
																{
																	continue;
																}
															}
															if (characterControl.hasSkill(132))
															{
																if (172508 - 36848 == 135661)
																{
																	continue;
																}
																num2++;
																if (14689 - 127629 == -112939)
																{
																	continue;
																}
															}
															if (characterControl.hasSkill(133))
															{
																if (290544 - 440830 != -150286)
																{
																	continue;
																}
																num2++;
																if (191412 - 77611 == 113802)
																{
																	continue;
																}
															}
															if (characterControl.hasSkill(134))
															{
																if (75904 - 202362 == -126457)
																{
																	continue;
																}
																num2++;
																if (25923 - 287716 != -261793)
																{
																	continue;
																}
															}
															if (characterControl.hasSkill(431))
															{
																if (220095 - 199339 != 20756)
																{
																	continue;
																}
																num2++;
																if (12642 - 124220 == -111577)
																{
																	continue;
																}
															}
															CharacterController characterController = (CharacterController)gameObject2.GetComponent(typeof(CharacterController));
															if (3311 - 165655 == -162343)
															{
																continue;
															}
															if (characterController)
															{
																if (184500 - 10060 == 174441)
																{
																	continue;
																}
																Transform transform = gameObject2.transform.Find("Whale_tri");
																if (275603 - 562642 == -287038)
																{
																	continue;
																}
																transform.transform.localScale = Vector3.one * (0.8f + 0.05f * (float)num2);
																if (100112 - 478798 != -378686)
																{
																	continue;
																}
																characterController.height = (float)2 + 0.1f * (float)num2;
																if (235419 - 567620 == -332200)
																{
																	continue;
																}
																characterController.radius = 0.6f + 0.05f * (float)num2;
																if (86785 - 380713 == -293927)
																{
																	continue;
																}
																float y = 1.1f + 0.05f * (float)num2;
																if (150349 - 446216 == -295866)
																{
																	continue;
																}
																Vector3 center = characterController.center;
																if (30079 - 586038 != -555959)
																{
																	continue;
																}
																float num3 = center.y = y;
																if (213682 - 582622 == -368939 || 191979 - 394493 == -202513)
																{
																	continue;
																}
																characterController.center = center;
																if (38927 - 56180 != -17253)
																{
																	continue;
																}
																if (33365 - 305886 == -272520)
																{
																	continue;
																}
															}
														}
														int num4 = RuntimeServices.UnboxInt32(data[120]);
														if (181979 - 154498 != 27482)
														{
															string text2 = "none";
															if (119767 - 404793 == -285026)
															{
																if (num4 == 91)
																{
																	if (210790 - 169919 != 40871)
																	{
																		continue;
																	}
																	characterControl.actionState = "mount";
																	if (289314 - 439892 == -150577)
																	{
																		continue;
																	}
																	characterControl.StartCoroutine_Auto(characterControl.addStatus("hide", 1, 9999, 0, characterControl.ActorNr));
																	if (21952 - 546087 == -524134)
																	{
																		continue;
																	}
																}
																else if (num4 == 92)
																{
																	if (281943 - 149380 == 132564)
																	{
																		continue;
																	}
																}
																else
																{
																	int num5 = num4;
																	if (179700 - 495249 != -315548)
																	{
																		if (num5 == 341)
																		{
																			if (264377 - 431507 == -167129)
																			{
																				continue;
																			}
																		}
																		else if (num5 == 342)
																		{
																			if (65170 - 15246 == 49925)
																			{
																				continue;
																			}
																		}
																		else if (num5 == 345)
																		{
																			if (73776 - 554125 == -480348)
																			{
																				continue;
																			}
																		}
																		else if (num5 == 346)
																		{
																			if (277437 - 279595 != -2158)
																			{
																				continue;
																			}
																		}
																		else if (num5 == 503)
																		{
																			if (166934 - 27671 == 139264)
																			{
																				continue;
																			}
																			text2 = "sit";
																			if (287430 - 527997 != -240567)
																			{
																				continue;
																			}
																			goto IL_2304;
																		}
																		else if (num5 == 504)
																		{
																			if (77302 - 312662 != -235360)
																			{
																				continue;
																			}
																			text2 = "sleep";
																			if (35404 - 547440 != -512035)
																			{
																				goto IL_2304;
																			}
																			continue;
																		}
																		else if (num5 == 512)
																		{
																			if (167606 - 83708 == 83899)
																			{
																				continue;
																			}
																			text2 = "cry";
																			if (180839 - 84510 != 96330)
																			{
																				goto IL_2304;
																			}
																			continue;
																		}
																		else if (num5 == 513)
																		{
																			if (10802 - 63303 != -52501)
																			{
																				continue;
																			}
																			text2 = "cheer";
																			if (220019 - 30541 != 189479)
																			{
																				goto IL_2304;
																			}
																			continue;
																		}
																		else if (num5 == 514)
																		{
																			if (263705 - 212988 == 50718)
																			{
																				continue;
																			}
																			text2 = "beg";
																			if (42872 - 599508 != -556635)
																			{
																				goto IL_2304;
																			}
																			continue;
																		}
																		else if (num5 == 521)
																		{
																			if (222093 - 122865 == 99229)
																			{
																				continue;
																			}
																			text2 = "talk";
																			if (222529 - 91779 != 130750)
																			{
																				continue;
																			}
																			goto IL_2304;
																		}
																		else if (num5 == 522)
																		{
																			if (61815 - 401596 == -339780)
																			{
																				continue;
																			}
																			text2 = "pose";
																			if (150867 - 177978 != -27111)
																			{
																				continue;
																			}
																			int integer = Stringf.getInteger(characterControl.armor);
																			if (89038 - 91563 != -2524)
																			{
																				if (integer == 5)
																				{
																					if (153657 - 70249 == 83409)
																					{
																						continue;
																					}
																					if (Stringf.getInteger(characterControl.armor) == 5)
																					{
																						if (114922 - 56371 != 58551)
																						{
																							continue;
																						}
																						if (Stringf.getInteger(characterControl.accessory) == 5)
																						{
																							if (33342 - 578311 != -544969)
																							{
																								continue;
																							}
																							text2 = "pose5";
																							if (181022 - 58744 != 122278)
																							{
																								continue;
																							}
																						}
																					}
																				}
																				else if (integer == 25)
																				{
																					if (72651 - 226787 == -154135)
																					{
																						continue;
																					}
																					if (Stringf.getInteger(characterControl.armor) == 25)
																					{
																						if (157712 - 179555 != -21843)
																						{
																							continue;
																						}
																						if (Stringf.getInteger(characterControl.accessory) == 25)
																						{
																							if (241093 - 556710 == -315616)
																							{
																								continue;
																							}
																							text2 = "pose25";
																							if (200827 - 437051 == -236223)
																							{
																								continue;
																							}
																						}
																					}
																				}
																				else if (integer == 45)
																				{
																					if (158650 - 487801 == -329150)
																					{
																						continue;
																					}
																					if (Stringf.getInteger(characterControl.armor) == 45)
																					{
																						if (294237 - 267027 != 27210)
																						{
																							continue;
																						}
																						if (Stringf.getInteger(characterControl.accessory) == 45)
																						{
																							if (164061 - 510316 != -346255)
																							{
																								continue;
																							}
																							text2 = "pose45";
																							if (260558 - 396206 != -135648)
																							{
																								continue;
																							}
																						}
																					}
																				}
																				goto IL_2304;
																			}
																			continue;
																		}
																		else if (num5 == 523)
																		{
																			if (293659 - 363017 != -69358)
																			{
																				continue;
																			}
																			text2 = "battle";
																			if (13119 - 166261 != -153141)
																			{
																				goto IL_2304;
																			}
																			continue;
																		}
																		else if (num5 == 524)
																		{
																			if (201262 - 110884 != 90378)
																			{
																				continue;
																			}
																			text2 = "dance";
																			if (235481 - 355026 != -119545)
																			{
																				continue;
																			}
																			goto IL_2304;
																		}
																		else
																		{
																			text2 = "none";
																			if (110865 - 56769 != 54096)
																			{
																				continue;
																			}
																			goto IL_2304;
																		}
																		IL_419:
																		if (text == "Rabbit")
																		{
																			if (247592 - 467380 != -219788)
																			{
																				continue;
																			}
																			if (num4 == 346)
																			{
																				if (44274 - 478628 != -434354)
																				{
																					continue;
																				}
																				characterControl.actionState = "attack";
																				if (170306 - 326025 == -155718)
																				{
																					continue;
																				}
																				characterControl.myCommand = "mallOpen";
																				if (220443 - 330267 != -109824)
																				{
																					continue;
																				}
																				if (!gameObject2.animation[text2])
																				{
																					if (175830 - 482875 != -307045)
																					{
																						continue;
																					}
																					gameObject2.SendMessage("AddAnimation", "sit");
																					if (76045 - 306837 == -230791)
																					{
																						continue;
																					}
																				}
																				gameObject2.animation.CrossFade("sit", 0.2f);
																				if (1365 - 230139 == -228773)
																				{
																					continue;
																				}
																				gameObject2.animation.wrapMode = WrapMode.Loop;
																				if (189188 - 567759 != -378571)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				characterControl.actionState = "attack";
																				if (97939 - 275799 == -177859)
																				{
																					continue;
																				}
																				characterControl.myCommand = "mallSetup";
																				if (95106 - 361261 == -266154)
																				{
																					continue;
																				}
																				if (!gameObject2.animation[text2])
																				{
																					if (207244 - 381687 != -174443)
																					{
																						continue;
																					}
																					gameObject2.SendMessage("AddAnimation", "mall1");
																					if (62005 - 179481 == -117475)
																					{
																						continue;
																					}
																				}
																				gameObject2.animation.CrossFade("mall1", 0.2f);
																				if (135429 - 28795 == 106635)
																				{
																					continue;
																				}
																				gameObject2.animation.wrapMode = WrapMode.Loop;
																				if (257024 - 77874 != 179150)
																				{
																					continue;
																				}
																			}
																			GameObject gameObject3 = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Effects/mall" + global::Math.div((float)characterControl.Skin, (float)100));
																			if (48403 - 256483 == -208079)
																			{
																				continue;
																			}
																			if (gameObject3)
																			{
																				if (17177 - 172108 != -154931)
																				{
																					continue;
																				}
																				GameObject gameObject4 = (GameObject)UnityEngine.Object.Instantiate(gameObject3, gameObject2.transform.position, gameObject2.transform.rotation);
																				if (77107 - 27296 == 49812)
																				{
																					continue;
																				}
																				if (gameObject4)
																				{
																					if (201980 - 336752 == -134771)
																					{
																						continue;
																					}
																					Rabbit_mall rabbit_mall = (Rabbit_mall)gameObject4.GetComponent(typeof(Rabbit_mall));
																					if (82846 - 120463 != -37617)
																					{
																						continue;
																					}
																					if (rabbit_mall)
																					{
																						if (138213 - 383639 != -245426)
																						{
																							continue;
																						}
																						rabbit_mall.Init(gameObject2, characterControl.ActorNr, characterControl.ownerID);
																						if (104116 - 388339 != -284223)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						Debug.LogError("Cannot find mall script");
																						if (234487 - 200129 == 34359)
																						{
																							continue;
																						}
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Cannot find mall Effect");
																				if (27623 - 69091 == -41467)
																				{
																					continue;
																				}
																			}
																		}
																		goto IL_2304;
																		IL_192B:
																		goto IL_419;
																		goto IL_192B;
																	}
																	continue;
																}
																IL_2304:
																if (text2 != "none")
																{
																	if (245488 - 209285 == 36204)
																	{
																		continue;
																	}
																	if (!gameObject2.animation[text2])
																	{
																		if (83239 - 168941 != -85702)
																		{
																			continue;
																		}
																		gameObject2.SendMessage("AddAnimation", text2);
																		if (260771 - 391680 == -130908)
																		{
																			continue;
																		}
																	}
																	gameObject2.animation.CrossFade(text2, 0.2f);
																	if (13731 - 542550 == -528818)
																	{
																		continue;
																	}
																	gameObject2.animation.wrapMode = WrapMode.Loop;
																	if (298493 - 169856 != 128637)
																	{
																		continue;
																	}
																	characterControl.actionState = "emotion";
																	if (192509 - 555952 == -363442)
																	{
																		continue;
																	}
																}
																if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[characterControl.ActorNr], null))
																{
																	if (285960 - 225495 == 60466)
																	{
																		continue;
																	}
																	Debug.Log("ActorNr: " + characterControl.ActorNr + " already existed");
																	if (203112 - 264545 == -61432)
																	{
																		continue;
																	}
																	object obj16;
																	object obj15 = obj16 = PhotonClient.ActorNrList[characterControl.ActorNr];
																	if (!(obj15 is GameObject))
																	{
																		obj16 = RuntimeServices.Coerce(obj15, typeof(GameObject));
																	}
																	GameObject obj17 = (GameObject)obj16;
																	if (73076 - 15083 != 57993)
																	{
																		continue;
																	}
																	UnityEngine.Object.Destroy(obj17);
																	if (78144 - 382235 != -304091)
																	{
																		continue;
																	}
																	PhotonClient.ActorNrList[characterControl.ActorNr] = gameObject2;
																	if (262011 - 552511 != -290500)
																	{
																		continue;
																	}
																}
																else
																{
																	PhotonClient.ActorNrList.Add(characterControl.ActorNr, gameObject2);
																	if (141977 - 31563 != 110414)
																	{
																		continue;
																	}
																}
																if (Game.mGameType <= 3)
																{
																	goto IL_235A;
																}
																if (234979 - 329500 != -94520)
																{
																	int playerSlot = Game.getPlayerSlot(characterControl.ownerID);
																	if (238805 - 65634 != 173172)
																	{
																		gameObject2.name = "Player" + playerSlot;
																		if (41554 - 503902 != -462347)
																		{
																			if (Game.mGamePlayerList.Contains(playerSlot))
																			{
																				if (282427 - 293983 != -11556)
																				{
																					continue;
																				}
																				Game.mGamePlayerList[playerSlot] = gameObject2;
																				if (206721 - 169704 == 37018)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				Game.mGamePlayerList.Add(playerSlot, gameObject2);
																				if (113944 - 547049 == -433104)
																				{
																					continue;
																				}
																			}
																			if (Game.mGamePlayerName.Contains(playerSlot))
																			{
																				if (230991 - 284329 != -53338)
																				{
																					continue;
																				}
																				Game.mGamePlayerName[playerSlot] = characterControl.Name;
																				if (29303 - 135948 != -106645)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				Game.mGamePlayerName.Add(playerSlot, characterControl.Name);
																				if (286293 - 525825 != -239532)
																				{
																					continue;
																				}
																			}
																			if (Game.mGamePlayerType.Contains(gameObject2.name))
																			{
																				if (185082 - 17426 != 167656)
																				{
																					continue;
																				}
																				Game.mGamePlayerType[gameObject2.name] = text;
																				if (117274 - 317687 == -200412)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				Game.mGamePlayerType.Add(gameObject2.name, text);
																				if (97672 - 408788 != -311116)
																				{
																					continue;
																				}
																			}
																			string name = "Team" + (gameObject2.layer - 7);
																			if (23312 - 318237 != -294924)
																			{
																				GameObject gameObject5 = GameObject.Find(name);
																				if (11286 - 148866 != -137579)
																				{
																					if (!gameObject5)
																					{
																						if (275683 - 562083 != -286400)
																						{
																							continue;
																						}
																						gameObject5 = new GameObject(name);
																						if (87783 - 223373 != -135590)
																						{
																							continue;
																						}
																					}
																					gameObject2.transform.parent = gameObject5.transform;
																					if (242949 - 454500 != -211550)
																					{
																						Debug.Log(gameObject2.name + " created : ID=" + characterControl.ActorNr + "@" + vector + " Team : " + gameObject2.layer);
																						if (269214 - 379972 == -110758)
																						{
																							goto IL_235A;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return null;
		IL_235A:
		return gameObject2;
	}

	// Token: 0x06005E71 RID: 24177 RVA: 0x00CA4D38 File Offset: 0x00CA2F38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject createActor(Hashtable data)
	{
		if (148820 - 360667 != -211847)
		{
		}
		GameObject gameObject;
		for (;;)
		{
			object obj2;
			object obj = obj2 = data[73];
			if (!(obj is string))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(string));
			}
			string text = (string)obj2;
			if (153988 - 33672 == 120316)
			{
				GameObject prefab = Game.getPrefab(text);
				if (162783 - 117415 == 45368)
				{
					if (prefab)
					{
						if (102658 - 360783 == -258125)
						{
							Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(data[122]), RuntimeServices.UnboxSingle(data[123]), RuntimeServices.UnboxSingle(data[124]));
							if (149473 - 583421 != -433947)
							{
								Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(data[126]), RuntimeServices.UnboxSingle(data[127]), RuntimeServices.UnboxSingle(data[128]));
								if (171406 - 310090 != -138683)
								{
									if (vector2 == Vector3.zero)
									{
										if (139868 - 466242 == -326373)
										{
											continue;
										}
										vector2 = Vector3.forward;
										if (177008 - 127030 == 49979)
										{
											continue;
										}
									}
									gameObject = (GameObject)UnityEngine.Object.Instantiate(prefab, vector, Quaternion.LookRotation(vector2));
									if (109652 - 398929 == -289277)
									{
										int num = RuntimeServices.UnboxInt32(data[75]);
										if (133963 - 376902 != -242938)
										{
											num += 7;
											if (44098 - 490311 == -446213)
											{
												gameObject.name = text;
												if (134291 - 211440 != -77148)
												{
													gameObject.layer = num;
													if (181484 - 98649 != 82836)
													{
														CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
														if (190079 - 502201 == -312122)
														{
															if (characterControl != null)
															{
																if (185395 - 378691 == -193295)
																{
																	continue;
																}
																characterControl.ActorNr = RuntimeServices.UnboxInt32(data[9]);
																if (163208 - 425930 == -262721)
																{
																	continue;
																}
																characterControl.ownerID = RuntimeServices.UnboxInt32(data[81]);
																if (167724 - 111120 != 56604)
																{
																	continue;
																}
																characterControl.isPlayer = false;
																if (54583 - 220857 == -166273)
																{
																	continue;
																}
																characterControl.isControlled = false;
																if (166666 - 149029 == 17638)
																{
																	continue;
																}
																if (characterControl.ownerID == PlayerData.UID)
																{
																	if (149470 - 130753 != 18717)
																	{
																		continue;
																	}
																	characterControl.isMine = true;
																	if (145741 - 229469 != -83728)
																	{
																		continue;
																	}
																}
																else
																{
																	characterControl.isMine = false;
																	if (115098 - 571338 == -456239)
																	{
																		continue;
																	}
																}
																characterControl.mOriginalLayer = num;
																if (27700 - 473387 != -445687)
																{
																	continue;
																}
																characterControl.nPosition = vector;
																if (260611 - 491541 == -230929)
																{
																	continue;
																}
																characterControl.nSpeed = (float)0;
																if (113605 - 385525 != -271920)
																{
																	continue;
																}
															}
															if (text == "Whale")
															{
																if (150033 - 250642 != -100609)
																{
																	continue;
																}
																int num2 = 0;
																if (84048 - 591439 == -507390)
																{
																	continue;
																}
																if (characterControl.hasSkill(131))
																{
																	if (86770 - 473217 == -386446)
																	{
																		continue;
																	}
																	num2++;
																	if (122526 - 287014 != -164488)
																	{
																		continue;
																	}
																}
																if (characterControl.hasSkill(132))
																{
																	if (217069 - 381628 != -164559)
																	{
																		continue;
																	}
																	num2++;
																	if (153494 - 528491 == -374996)
																	{
																		continue;
																	}
																}
																if (characterControl.hasSkill(133))
																{
																	if (197590 - 566586 != -368996)
																	{
																		continue;
																	}
																	num2++;
																	if (234506 - 305315 != -70809)
																	{
																		continue;
																	}
																}
																if (characterControl.hasSkill(134))
																{
																	if (265528 - 482776 != -217248)
																	{
																		continue;
																	}
																	num2++;
																	if (153954 - 479812 == -325857)
																	{
																		continue;
																	}
																}
																CharacterController characterController = (CharacterController)gameObject.GetComponent(typeof(CharacterController));
																if (15262 - 264746 != -249484)
																{
																	continue;
																}
																if (characterController)
																{
																	if (6643 - 132277 == -125633)
																	{
																		continue;
																	}
																	Transform transform = gameObject.transform.Find("Whale_tri");
																	if (222991 - 530583 != -307592)
																	{
																		continue;
																	}
																	transform.transform.localScale = Vector3.one * (0.8f + 0.05f * (float)num2);
																	if (35677 - 547872 == -512194)
																	{
																		continue;
																	}
																	characterController.height = (float)2 + 0.1f * (float)num2;
																	if (60492 - 384162 == -323669)
																	{
																		continue;
																	}
																	characterController.radius = 0.6f + 0.05f * (float)num2;
																	if (116060 - 391256 == -275195)
																	{
																		continue;
																	}
																	float y = 1.1f + 0.05f * (float)num2;
																	if (159761 - 393179 == -233417)
																	{
																		continue;
																	}
																	Vector3 center = characterController.center;
																	if (109157 - 277507 == -168349)
																	{
																		continue;
																	}
																	center.y = y;
																	if (197400 - 515458 != -318058)
																	{
																		continue;
																	}
																	if (238522 - 573874 != -335352)
																	{
																		continue;
																	}
																	Vector3 vector3 = characterController.center = center;
																	if (253853 - 155049 == 98805 || 278413 - 479200 == -200786)
																	{
																		continue;
																	}
																}
															}
															string name = "Team" + (gameObject.layer - 7);
															if (57799 - 299164 == -241365)
															{
																GameObject gameObject2 = GameObject.Find(name);
																if (101071 - 567988 != -466916)
																{
																	if (gameObject2)
																	{
																		if (167448 - 82275 != 85173)
																		{
																			continue;
																		}
																		gameObject.transform.parent = gameObject2.transform;
																		if (211669 - 90124 == 121546)
																		{
																			continue;
																		}
																	}
																	if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[characterControl.ActorNr], null))
																	{
																		if (289797 - 443528 != -153731)
																		{
																			continue;
																		}
																		Debug.Log("ActorNr: " + characterControl.ActorNr + " already existed");
																		if (285018 - 218331 == 66688)
																		{
																			continue;
																		}
																		object obj4;
																		object obj3 = obj4 = PhotonClient.ActorNrList[characterControl.ActorNr];
																		if (!(obj3 is GameObject))
																		{
																			obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
																		}
																		GameObject obj5 = (GameObject)obj4;
																		if (59937 - 283454 == -223516)
																		{
																			continue;
																		}
																		UnityEngine.Object.Destroy(obj5);
																		if (54196 - 130620 == -76423)
																		{
																			continue;
																		}
																	}
																	PhotonClient.ActorNrList.Add(characterControl.ActorNr, gameObject);
																	if (178032 - 158811 == 19221)
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
					else
					{
						Debug.LogError("OnCreateChar Error:" + data[73]);
						if (21028 - 510919 == -489891)
						{
							goto IL_9C5;
						}
					}
				}
			}
		}
		return gameObject;
		IL_9C5:
		return null;
	}

	// Token: 0x06005E72 RID: 24178 RVA: 0x00CA571C File Offset: 0x00CA391C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject getPrefab(string nType)
	{
		if (267210 - 66489 != 200722)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (288983 - 136928 == 152055)
			{
				if (60999 - 20220 == 40779)
				{
					if (nType == "Wolf")
					{
						if (9635 - 187572 != -177936)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Wolf", typeof(GameObject));
							if (292076 - 128613 != 163464)
							{
								break;
							}
						}
					}
					else if (nType == "Bison")
					{
						if (231968 - 499508 != -267539)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Bison", typeof(GameObject));
							if (127552 - 139555 == -12003)
							{
								break;
							}
						}
					}
					else if (nType == "Panda")
					{
						if (197501 - 17010 != 180492)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Panda/Panda", typeof(GameObject));
							if (12466 - 535904 != -523437)
							{
								break;
							}
						}
					}
					else if (nType == "Whale")
					{
						if (278592 - 590891 == -312299)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Whale/Whale", typeof(GameObject));
							if (260169 - 547004 != -286834)
							{
								break;
							}
						}
					}
					else if (nType == "Cat")
					{
						if (198453 - 226623 == -28170)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Cat/Cat", typeof(GameObject));
							if (49658 - 161885 == -112227)
							{
								break;
							}
						}
					}
					else if (nType == "Chameleon")
					{
						if (89336 - 241708 == -152372)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Chameleon", typeof(GameObject));
							if (12337 - 358614 == -346277)
							{
								break;
							}
						}
					}
					else if (nType == "Mole")
					{
						if (238868 - 583730 == -344862)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Mole", typeof(GameObject));
							if (94110 - 128522 != -34411)
							{
								break;
							}
						}
					}
					else if (nType == "Rabbit")
					{
						if (45023 - 8492 == 36531)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Rabbit/Rabbit", typeof(GameObject));
							if (247046 - 395870 == -148824)
							{
								break;
							}
						}
					}
					else if (nType == "Monkey")
					{
						if (102543 - 9830 != 92714)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Monkey/Monkey", typeof(GameObject));
							if (147596 - 107644 == 39952)
							{
								break;
							}
						}
					}
					else if (nType == "Sheep")
					{
						if (120272 - 328193 == -207921)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Sheep", typeof(GameObject));
							if (133989 - 60977 == 73012)
							{
								break;
							}
						}
					}
					else if (nType == "Penguin")
					{
						if (180967 - 212723 == -31756)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Penguin/Penguin", typeof(GameObject));
							if (83052 - 439566 != -356513)
							{
								break;
							}
						}
					}
					else if (nType == "Bat")
					{
						if (120243 - 509273 == -389030)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Bat", typeof(GameObject));
							if (65778 - 307387 != -241608)
							{
								break;
							}
						}
					}
					else if (nType == "Carron")
					{
						if (265670 - 504436 != -238765)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Carron/Carron", typeof(GameObject));
							if (65238 - 263192 != -197953)
							{
								break;
							}
						}
					}
					else if (nType == "Peppon")
					{
						if (18847 - 289248 != -270400)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Peppon/Peppon", typeof(GameObject));
							if (107082 - 525587 != -418504)
							{
								break;
							}
						}
					}
					else if (nType == "Cacton")
					{
						if (179400 - 466396 == -286996)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Cacton/Cacton", typeof(GameObject));
							if (271602 - 473473 != -201870)
							{
								break;
							}
						}
					}
					else if (nType == "Cactun")
					{
						if (216273 - 292729 == -76456)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Cactun/Cactun", typeof(GameObject));
							if (101785 - 305715 == -203930)
							{
								break;
							}
						}
					}
					else if (nType == "Cocon")
					{
						if (265026 - 261583 == 3443)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Cocon/Cocon", typeof(GameObject));
							if (192043 - 296488 != -104444)
							{
								break;
							}
						}
					}
					else if (nType == "Pumpkon")
					{
						if (27089 - 414131 == -387042)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Pumpkon/Pumpkon", typeof(GameObject));
							if (152726 - 281687 == -128961)
							{
								break;
							}
						}
					}
					else if (nType == "Mellon")
					{
						if (137651 - 249826 != -112174)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Mellon/Mellon", typeof(GameObject));
							if (247655 - 50351 != 197305)
							{
								break;
							}
						}
					}
					else if (nType == "Carron_p")
					{
						if (85601 - 112596 == -26995)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Carron/Carron_p", typeof(GameObject));
							if (31868 - 28625 == 3243)
							{
								break;
							}
						}
					}
					else if (nType == "Pumpkin")
					{
						if (108669 - 471204 != -362534)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Pumpkin/Pumpkin", typeof(GameObject));
							if (40646 - 389657 != -349010)
							{
								break;
							}
						}
					}
					else if (nType == "PumpkonKing")
					{
						if (203863 - 572884 != -369020)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/PumpkonKing/PumpkonKing", typeof(GameObject));
							if (78553 - 215056 != -136502)
							{
								break;
							}
						}
					}
					else if (nType == "Fungon")
					{
						if (199245 - 395467 == -196222)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Fungon/Fungon", typeof(GameObject));
							if (75164 - 460050 == -384886)
							{
								break;
							}
						}
					}
					else if (nType == "Fungko")
					{
						if (291817 - 390916 == -99099)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Fungko/Fungko", typeof(GameObject));
							if (65719 - 535358 != -469638)
							{
								break;
							}
						}
					}
					else if (nType == "Funga")
					{
						if (5664 - 358902 != -353237)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Funga/Funga", typeof(GameObject));
							if (201096 - 12627 != 188470)
							{
								break;
							}
						}
					}
					else if (nType == "Mupo")
					{
						if (185636 - 534533 == -348897)
						{
							if (UnityEngine.Random.Range(0, 2) != 0)
							{
								if (129568 - 430164 == -300596)
								{
									result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Mupo/Mupo_g", typeof(GameObject));
									if (93703 - 387789 == -294086)
									{
										break;
									}
								}
							}
							else
							{
								result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Mupo/Mupo_r", typeof(GameObject));
								if (188245 - 151730 != 36516)
								{
									break;
								}
							}
						}
					}
					else if (nType == "Mupo_g")
					{
						if (219092 - 29238 != 189855)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Mupo/Mupo_g", typeof(GameObject));
							if (174431 - 308358 == -133927)
							{
								break;
							}
						}
					}
					else if (nType == "Mupo_r")
					{
						if (173913 - 473411 != -299497)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/Mupo/Mupo_r", typeof(GameObject));
							if (76186 - 549349 == -473163)
							{
								break;
							}
						}
					}
					else if (nType == "MupoCart_g")
					{
						if (198761 - 567131 == -368370)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/MupoCart/MupoCart_g", typeof(GameObject));
							if (226672 - 320040 != -93367)
							{
								break;
							}
						}
					}
					else if (nType == "MupoCart_r")
					{
						if (172438 - 132702 == 39736)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/MupoCart/MupoCart_r", typeof(GameObject));
							if (110864 - 533924 == -423060)
							{
								break;
							}
						}
					}
					else if (nType == "EnlagearCart")
					{
						if (22290 - 361243 != -338952)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/EnlagearCart/EnlagearCart", typeof(GameObject));
							if (237550 - 569264 != -331713)
							{
								break;
							}
						}
					}
					else if (nType == "SnowMupo")
					{
						if (274838 - 333971 != -59132)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/SnowMupo/SnowMupo", typeof(GameObject));
							if (242157 - 73129 != 169029)
							{
								break;
							}
						}
					}
					else if (nType == "MadCarron")
					{
						if (112494 - 416984 != -304489)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/MadCarron/MadCarron", typeof(GameObject));
							if (195540 - 36357 != 159184)
							{
								break;
							}
						}
					}
					else if (nType == "MadPeppon")
					{
						if (124328 - 95167 == 29161)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/MadPeppon/MadPeppon", typeof(GameObject));
							if (79692 - 337776 != -258083)
							{
								break;
							}
						}
					}
					else if (nType == "MadCocon")
					{
						if (95620 - 66855 != 28766)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Plants/MadCocon/MadCocon", typeof(GameObject));
							if (24022 - 302217 != -278194)
							{
								break;
							}
						}
					}
					else if (nType == "Liger")
					{
						if (299404 - 50059 == 249345)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Liger/Liger", typeof(GameObject));
							if (239800 - 518119 != -278318)
							{
								break;
							}
						}
					}
					else if (nType == "Liger_m")
					{
						if (169902 - 206201 != -36298)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Liger/Liger_mallet", typeof(GameObject));
							if (191180 - 557200 != -366019)
							{
								break;
							}
						}
					}
					else if (nType == "Falcon")
					{
						if (23495 - 355111 != -331615)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Falcon/Falcon", typeof(GameObject));
							if (266034 - 338310 == -72276)
							{
								break;
							}
						}
					}
					else if (nType == "Walrus")
					{
						if (171490 - 190057 != -18566)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Walrus/Walrus", typeof(GameObject));
							if (132803 - 205947 != -73143)
							{
								break;
							}
						}
					}
					else if (nType == "Walrus_d")
					{
						if (287646 - 71050 == 216596)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Walrus/Walrus_d", typeof(GameObject));
							if (235326 - 349779 == -114453)
							{
								break;
							}
						}
					}
					else if (nType == "Panther")
					{
						if (166964 - 134533 != 32432)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Panther/Panther", typeof(GameObject));
							if (287084 - 423663 != -136578)
							{
								break;
							}
						}
					}
					else if (nType == "Panther_d")
					{
						if (292084 - 508341 == -216257)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Panther/Panther_d", typeof(GameObject));
							if (296873 - 569961 != -273087)
							{
								break;
							}
						}
					}
					else if (nType == "Leopard")
					{
						if (208940 - 547215 != -338274)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Leopard/Leopard", typeof(GameObject));
							if (270946 - 18928 != 252019)
							{
								break;
							}
						}
					}
					else if (nType == "RedPanda")
					{
						if (165753 - 458018 != -292264)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/RedPanda/RedPanda", typeof(GameObject));
							if (127504 - 248599 != -121094)
							{
								break;
							}
						}
					}
					else if (nType == "GoatFarmer")
					{
						if (211980 - 430175 == -218195)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/GoatFarmer/GoatFarmer", typeof(GameObject));
							if (170978 - 137198 != 33781)
							{
								break;
							}
						}
					}
					else if (nType == "Owl1")
					{
						if (232116 - 229292 == 2824)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Owl1/Owl1", typeof(GameObject));
							if (192709 - 579740 != -387030)
							{
								break;
							}
						}
					}
					else if (nType == "Owl2")
					{
						if (169440 - 387813 != -218372)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Owl2/Owl2", typeof(GameObject));
							if (298166 - 513825 == -215659)
							{
								break;
							}
						}
					}
					else if (nType == "Mouse")
					{
						if (255738 - 208424 == 47314)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Mouse/Mouse", typeof(GameObject));
							if (237343 - 465825 != -228481)
							{
								break;
							}
						}
					}
					else if (nType == "Warthog")
					{
						if (122039 - 539748 == -417709)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Warthog/Warthog", typeof(GameObject));
							if (197202 - 522425 != -325222)
							{
								break;
							}
						}
					}
					else if (nType == "Alpaca")
					{
						if (160353 - 69699 != 90655)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Alpaca/Alpaca", typeof(GameObject));
							if (25366 - 114855 == -89489)
							{
								break;
							}
						}
					}
					else if (nType == "Crocodile")
					{
						if (145015 - 160370 == -15355)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Crocodile/Crocodile", typeof(GameObject));
							if (249965 - 201608 != 48358)
							{
								break;
							}
						}
					}
					else if (nType == "Humpback")
					{
						if (179431 - 75137 != 104295)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Humpback/Humpback", typeof(GameObject));
							if (13750 - 284160 != -270409)
							{
								break;
							}
						}
					}
					else if (nType == "Koala")
					{
						if (73157 - 548964 != -475806)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Koala/Koala", typeof(GameObject));
							if (15879 - 208223 != -192343)
							{
								break;
							}
						}
					}
					else if (nType == "Kangaroo")
					{
						if (48277 - 155820 != -107542)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Kangaroo/Kangaroo", typeof(GameObject));
							if (286125 - 184847 == 101278)
							{
								break;
							}
						}
					}
					else if (nType == "Bear")
					{
						if (192096 - 73303 == 118793)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Bear/Bear", typeof(GameObject));
							if (261985 - 67463 == 194522)
							{
								break;
							}
						}
					}
					else if (nType == "Reindeer")
					{
						if (37409 - 442893 != -405483)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Reindeer/Reindeer", typeof(GameObject));
							if (223228 - 451880 == -228652)
							{
								break;
							}
						}
					}
					else if (nType == "Baboon")
					{
						if (58501 - 245483 == -186982)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Baboon/Baboon", typeof(GameObject));
							if (242720 - 379301 == -136581)
							{
								break;
							}
						}
					}
					else if (nType == "Catfish")
					{
						if (169547 - 393228 != -223680)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Catfish/Catfish", typeof(GameObject));
							if (98185 - 417285 == -319100)
							{
								break;
							}
						}
					}
					else if (nType == "Lemur")
					{
						if (138284 - 232267 != -93982)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Lemur/Lemur", typeof(GameObject));
							if (2434 - 268345 == -265911)
							{
								break;
							}
						}
					}
					else if (nType == "Duck")
					{
						if (297324 - 228129 == 69195)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Duck/Duck", typeof(GameObject));
							if (19139 - 188742 == -169603)
							{
								break;
							}
						}
					}
					else if (nType == "PilotMole")
					{
						if (261523 - 240269 == 21254)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/PilotMole/PilotMole", typeof(GameObject));
							if (31049 - 341337 != -310287)
							{
								break;
							}
						}
					}
					else if (nType == "Raccoon")
					{
						if (271474 - 27842 == 243632)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Raccoon/Raccoon", typeof(GameObject));
							if (162545 - 108674 == 53871)
							{
								break;
							}
						}
					}
					else if (nType == "Skunk")
					{
						if (294979 - 498574 != -203594)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Skunk/Skunk", typeof(GameObject));
							if (124087 - 94740 != 29348)
							{
								break;
							}
						}
					}
					else if (nType == "MiniCat")
					{
						if (165362 - 596518 != -431155)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/MiniCat/MiniCat", typeof(GameObject));
							if (40861 - 186637 == -145776)
							{
								break;
							}
						}
					}
					else if (nType == "MiniSheep")
					{
						if (138262 - 388858 == -250596)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/MiniSheep/MiniSheep", typeof(GameObject));
							if (62984 - 372694 == -309710)
							{
								break;
							}
						}
					}
					else if (nType == "MiniMole1")
					{
						if (289494 - 137980 != 151515)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/MiniMole/MiniMole1", typeof(GameObject));
							if (39803 - 341775 == -301972)
							{
								break;
							}
						}
					}
					else if (nType == "MiniMole2")
					{
						if (115575 - 590357 != -474781)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/MiniMole/MiniMole2", typeof(GameObject));
							if (102204 - 477987 == -375783)
							{
								break;
							}
						}
					}
					else if (nType == "Turtle1")
					{
						if (78035 - 404130 != -326094)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Turtle1/Turtle1", typeof(GameObject));
							if (268575 - 73953 == 194622)
							{
								break;
							}
						}
					}
					else if (nType == "Turtle2")
					{
						if (248094 - 185257 == 62837)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Turtle2/Turtle2", typeof(GameObject));
							if (295824 - 314177 != -18352)
							{
								break;
							}
						}
					}
					else if (nType == "Lizard")
					{
						if (12142 - 323232 == -311090)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Lizard/Lizard", typeof(GameObject));
							if (125826 - 307290 != -181463)
							{
								break;
							}
						}
					}
					else if (nType == "Jerboa")
					{
						if (83268 - 503246 != -419977)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Jerboa/Jerboa", typeof(GameObject));
							if (270080 - 496833 == -226753)
							{
								break;
							}
						}
					}
					else if (nType == "Hornbill")
					{
						if (187779 - 585807 == -398028)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Hornbill/Hornbill", typeof(GameObject));
							if (143989 - 121672 == 22317)
							{
								break;
							}
						}
					}
					else if (nType == "Hippo")
					{
						if (147269 - 566077 != -418807)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Hippo/Hippo", typeof(GameObject));
							if (267165 - 459055 == -191890)
							{
								break;
							}
						}
					}
					else if (nType == "CyborgMole")
					{
						if (289084 - 478164 != -189079)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/CyborgMole/CyborgMole", typeof(GameObject));
							if (80133 - 469463 == -389330)
							{
								break;
							}
						}
					}
					else if (nType == "Ammonite")
					{
						if (222683 - 567099 != -344415)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Ammonite/Ammonite", typeof(GameObject));
							if (211283 - 137120 != 74164)
							{
								break;
							}
						}
					}
					else if (nType == "Annonite")
					{
						if (38103 - 470123 != -432019)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Annonite/Annonite", typeof(GameObject));
							if (155051 - 438279 == -283228)
							{
								break;
							}
						}
					}
					else if (nType == "BisonCult")
					{
						if (43550 - 516889 == -473339)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/BisonCult/BisonCult", typeof(GameObject));
							if (83642 - 111094 == -27452)
							{
								break;
							}
						}
					}
					else if (nType == "PandaCult")
					{
						if (268803 - 382727 == -113924)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/PandaCult/PandaCult", typeof(GameObject));
							if (103146 - 423179 == -320033)
							{
								break;
							}
						}
					}
					else if (nType == "RabbitCult")
					{
						if (202953 - 495667 != -292713)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/RabbitCult/RabbitCult", typeof(GameObject));
							if (223367 - 255730 != -32362)
							{
								break;
							}
						}
					}
					else if (nType == "SheepCult")
					{
						if (204228 - 474617 != -270388)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/SheepCult/SheepCult", typeof(GameObject));
							if (4755 - 357242 != -352486)
							{
								break;
							}
						}
					}
					else if (nType == "BatCult")
					{
						if (58527 - 156280 != -97752)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/BatCult/BatCult", typeof(GameObject));
							if (33810 - 392366 == -358556)
							{
								break;
							}
						}
					}
					else if (nType == "LadyNoir")
					{
						if (157121 - 174597 == -17476)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/LadyNoir/LadyNoir", typeof(GameObject));
							if (177992 - 329226 == -151234)
							{
								break;
							}
						}
					}
					else if (nType == "DarkFalcon")
					{
						if (271691 - 247003 != 24689)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/DarkFalcon/DarkFalcon", typeof(GameObject));
							if (233698 - 373100 != -139401)
							{
								break;
							}
						}
					}
					else if (nType == "FirstWhale")
					{
						if (210135 - 53701 == 156434)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/FirstWhale/FirstWhale", typeof(GameObject));
							if (113116 - 204079 != -90962)
							{
								break;
							}
						}
					}
					else if (nType == "Anubi")
					{
						if (16324 - 207557 != -191232)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Anubi/Anubi", typeof(GameObject));
							if (28036 - 249388 == -221352)
							{
								break;
							}
						}
					}
					else if (nType == "Deadbeagle")
					{
						if (168352 - 594899 != -426546)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Deadbeagle/Deadbeagle", typeof(GameObject));
							if (184890 - 213874 == -28984)
							{
								break;
							}
						}
					}
					else if (nType == "Deadshund")
					{
						if (38666 - 330432 != -291765)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Deadshund/Deadshund", typeof(GameObject));
							if (90387 - 364418 == -274031)
							{
								break;
							}
						}
					}
					else if (nType == "Deadbull")
					{
						if (194382 - 531167 == -336785)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Deadbull/Deadbull", typeof(GameObject));
							if (62854 - 250251 == -187397)
							{
								break;
							}
						}
					}
					else if (nType == "Deadcamel")
					{
						if (176423 - 423765 == -247342)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/Deadcamel/Deadcamel", typeof(GameObject));
							if (244906 - 85176 == 159730)
							{
								break;
							}
						}
					}
					else if (nType == "PharaohCat")
					{
						if (220282 - 333666 == -113384)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/PharaohCat/PharaohCat", typeof(GameObject));
							if (113892 - 52757 != 61136)
							{
								break;
							}
						}
					}
					else if (nType == "IcePenguin1")
					{
						if (106189 - 433923 != -327733)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/IcePenguin1/IcePenguin1", typeof(GameObject));
							if (95869 - 525124 == -429255)
							{
								break;
							}
						}
					}
					else if (nType == "IcePenguin2")
					{
						if (24766 - 142992 != -118225)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/IcePenguin2/IcePenguin2", typeof(GameObject));
							if (70384 - 140041 == -69657)
							{
								break;
							}
						}
					}
					else if (nType == "IcePenguin3")
					{
						if (243253 - 336189 != -92935)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/IcePenguin3/IcePenguin3", typeof(GameObject));
							if (87336 - 70748 == 16588)
							{
								break;
							}
						}
					}
					else if (nType == "PirateFish")
					{
						if (59398 - 152407 != -93008)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/PirateFish/PirateFish", typeof(GameObject));
							if (122068 - 88722 != 33347)
							{
								break;
							}
						}
					}
					else if (nType == "ZombieFish")
					{
						if (289658 - 480985 != -191326)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/ZombieFish/ZombieFish", typeof(GameObject));
							if (55875 - 445687 != -389811)
							{
								break;
							}
						}
					}
					else if (nType == "PirateCrawfish")
					{
						if (282019 - 409133 == -127114)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/PirateCrawfish/PirateCrawfish", typeof(GameObject));
							if (206701 - 1464 != 205238)
							{
								break;
							}
						}
					}
					else if (nType == "ZombieCrawfish")
					{
						if (125768 - 482875 != -357106)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/ZombieCrawfish/ZombieCrawfish", typeof(GameObject));
							if (126474 - 351375 != -224900)
							{
								break;
							}
						}
					}
					else if (nType == "CaptainCrab")
					{
						if (29607 - 54856 != -25248)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Tails/CaptainCrab/CaptainCrab", typeof(GameObject));
							if (191245 - 385611 == -194366)
							{
								break;
							}
						}
					}
					else if (nType == "StingBug_r")
					{
						if (145547 - 184687 == -39140)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/StingBug/StingBug_red", typeof(GameObject));
							if (274547 - 29115 == 245432)
							{
								break;
							}
						}
					}
					else if (nType == "StingBug_g")
					{
						if (162601 - 224404 != -61802)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/StingBug/StingBug_green", typeof(GameObject));
							if (264534 - 253327 != 11208)
							{
								break;
							}
						}
					}
					else if (nType == "StingNest")
					{
						if (153856 - 318481 == -164625)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/StingNest/StingNest", typeof(GameObject));
							if (69688 - 549278 != -479589)
							{
								break;
							}
						}
					}
					else if (nType == "NinjaBug_r")
					{
						if (142597 - 591560 != -448962)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NinjaBug/NinjaBug_red", typeof(GameObject));
							if (185736 - 340139 == -154403)
							{
								break;
							}
						}
					}
					else if (nType == "NinjaBug_g")
					{
						if (97427 - 136524 != -39096)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NinjaBug/NinjaBug_green", typeof(GameObject));
							if (43207 - 253290 == -210083)
							{
								break;
							}
						}
					}
					else if (nType == "NinjaBug_y")
					{
						if (290717 - 98818 != 191900)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NinjaBug/NinjaBug_yellow", typeof(GameObject));
							if (22101 - 173699 == -151598)
							{
								break;
							}
						}
					}
					else if (nType == "NinjaBug_b")
					{
						if (6153 - 579232 != -573078)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NinjaBug/NinjaBug_blue", typeof(GameObject));
							if (104850 - 219585 != -114734)
							{
								break;
							}
						}
					}
					else if (nType == "NinjaBug_k")
					{
						if (212266 - 99665 == 112601)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NinjaBug/NinjaBug_black", typeof(GameObject));
							if (276154 - 181034 == 95120)
							{
								break;
							}
						}
					}
					else if (nType == "SamuraiBug1")
					{
						if (90716 - 338866 != -248149)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/SamuraiBug/SamuraiBug1", typeof(GameObject));
							if (219744 - 445365 != -225620)
							{
								break;
							}
						}
					}
					else if (nType == "SamuraiBug2")
					{
						if (137350 - 491946 == -354596)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/SamuraiBug/SamuraiBug2", typeof(GameObject));
							if (152466 - 189450 != -36983)
							{
								break;
							}
						}
					}
					else if (nType == "SamuraiBug3")
					{
						if (292996 - 408096 == -115100)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/SamuraiBug/SamuraiBug3", typeof(GameObject));
							if (235879 - 66762 != 169118)
							{
								break;
							}
						}
					}
					else if (nType == "ShogunBug")
					{
						if (86445 - 462602 != -376156)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/ShogunBug/ShogunBug", typeof(GameObject));
							if (43736 - 187146 != -143409)
							{
								break;
							}
						}
					}
					else if (nType == "RangerBug_red")
					{
						if (164138 - 139423 == 24715)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/RangerBug/RangerBug_red", typeof(GameObject));
							if (191485 - 402365 == -210880)
							{
								break;
							}
						}
					}
					else if (nType == "RangerBug_yellow")
					{
						if (289349 - 228229 != 61121)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/RangerBug/RangerBug_yellow", typeof(GameObject));
							if (203142 - 40463 == 162679)
							{
								break;
							}
						}
					}
					else if (nType == "RangerBug_pink")
					{
						if (71569 - 210197 != -138627)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/RangerBug/RangerBug_pink", typeof(GameObject));
							if (202612 - 11733 != 190880)
							{
								break;
							}
						}
					}
					else if (nType == "RangerBug_blue")
					{
						if (203316 - 102563 != 100754)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/RangerBug/RangerBug_blue", typeof(GameObject));
							if (142294 - 107505 != 34790)
							{
								break;
							}
						}
					}
					else if (nType == "RangerBug_black")
					{
						if (38357 - 145973 != -107615)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/RangerBug/RangerBug_black", typeof(GameObject));
							if (32595 - 528795 == -496200)
							{
								break;
							}
						}
					}
					else if (nType == "NeedleBug_r")
					{
						if (205728 - 116634 == 89094)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NeedleBug/NeedleBug_r", typeof(GameObject));
							if (194634 - 282291 != -87656)
							{
								break;
							}
						}
					}
					else if (nType == "NeedleBug_g")
					{
						if (205040 - 443578 != -238537)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NeedleBug/NeedleBug_g", typeof(GameObject));
							if (269668 - 579712 != -310043)
							{
								break;
							}
						}
					}
					else if (nType == "NeedleBug_b")
					{
						if (92748 - 208652 != -115903)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NeedleBug/NeedleBug_b", typeof(GameObject));
							if (195052 - 453058 != -258005)
							{
								break;
							}
						}
					}
					else if (nType == "NeedleBug_o")
					{
						if (142905 - 188788 == -45883)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NeedleBug/NeedleBug_o", typeof(GameObject));
							if (229227 - 95639 == 133588)
							{
								break;
							}
						}
					}
					else if (nType == "NeedleBug_p")
					{
						if (278150 - 567691 != -289540)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NeedleBug/NeedleBug_p", typeof(GameObject));
							if (74094 - 11455 == 62639)
							{
								break;
							}
						}
					}
					else if (nType == "NeedleBug_k")
					{
						if (94336 - 446479 != -352142)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NeedleBug/NeedleBug_k", typeof(GameObject));
							if (104410 - 20500 == 83910)
							{
								break;
							}
						}
					}
					else if (nType == "NeedleBug_w")
					{
						if (149457 - 527931 != -378473)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NeedleBug/NeedleBug_w", typeof(GameObject));
							if (85132 - 293025 != -207892)
							{
								break;
							}
						}
					}
					else if (nType == "FlowerBug_p")
					{
						if (134560 - 52462 == 82098)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/FlowerBug/FlowerBug_p", typeof(GameObject));
							if (88294 - 377388 != -289093)
							{
								break;
							}
						}
					}
					else if (nType == "FlowerBug_b")
					{
						if (93681 - 467113 == -373432)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/FlowerBug/FlowerBug_b", typeof(GameObject));
							if (187699 - 240107 != -52407)
							{
								break;
							}
						}
					}
					else if (nType == "FlowerBug_f")
					{
						if (50991 - 501837 == -450846)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/FlowerBug/FlowerBug_f", typeof(GameObject));
							if (87602 - 282440 != -194837)
							{
								break;
							}
						}
					}
					else if (nType == "PineBug")
					{
						if (3658 - 183159 != -179500)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/PineBug/PineBug", typeof(GameObject));
							if (122982 - 344705 != -221722)
							{
								break;
							}
						}
					}
					else if (nType == "FudaBug_b")
					{
						if (295452 - 9757 == 285695)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/FudaBug/FudaBug_b", typeof(GameObject));
							if (43462 - 103025 != -59562)
							{
								break;
							}
						}
					}
					else if (nType == "FudaBug_r")
					{
						if (188359 - 114504 != 73856)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/FudaBug/FudaBug_r", typeof(GameObject));
							if (51615 - 196091 == -144476)
							{
								break;
							}
						}
					}
					else if (nType == "KingFudaBug")
					{
						if (292337 - 321477 == -29140)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/KingFudaBug/KingFudaBug", typeof(GameObject));
							if (192333 - 554751 == -362418)
							{
								break;
							}
						}
					}
					else if (nType == "SandBug_r")
					{
						if (19438 - 173902 != -154463)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/SandBug/SandBug_r", typeof(GameObject));
							if (130972 - 475533 != -344560)
							{
								break;
							}
						}
					}
					else if (nType == "SandBug_b")
					{
						if (44667 - 194394 != -149726)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/SandBug/SandBug_b", typeof(GameObject));
							if (146960 - 424994 == -278034)
							{
								break;
							}
						}
					}
					else if (nType == "SandBug_k")
					{
						if (247324 - 560445 != -313120)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/SandBug/SandBug_k", typeof(GameObject));
							if (177020 - 81741 == 95279)
							{
								break;
							}
						}
					}
					else if (nType == "GiantSandBug")
					{
						if (175045 - 273751 != -98705)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/GiantSandBug/GiantSandBug", typeof(GameObject));
							if (167495 - 532851 != -365355)
							{
								break;
							}
						}
					}
					else if (nType == "BanditBug1")
					{
						if (250549 - 123370 == 127179)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/BanditBug/BanditBug1", typeof(GameObject));
							if (18258 - 415517 != -397258)
							{
								break;
							}
						}
					}
					else if (nType == "BanditBug2")
					{
						if (94148 - 586938 == -492790)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/BanditBug/BanditBug2", typeof(GameObject));
							if (186973 - 281245 != -94271)
							{
								break;
							}
						}
					}
					else if (nType == "BanditBug3")
					{
						if (246840 - 100717 == 146123)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/BanditBug/BanditBug3", typeof(GameObject));
							if (191473 - 244989 == -53516)
							{
								break;
							}
						}
					}
					else if (nType == "LeafBug_r")
					{
						if (106282 - 508437 == -402155)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LeafBug/LeafBug_r", typeof(GameObject));
							if (287213 - 82566 == 204647)
							{
								break;
							}
						}
					}
					else if (nType == "LeafBug_b")
					{
						if (11113 - 170394 == -159281)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LeafBug/LeafBug_b", typeof(GameObject));
							if (164665 - 206931 == -42266)
							{
								break;
							}
						}
					}
					else if (nType == "ForestBug")
					{
						if (60036 - 378982 == -318946)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/ForestBug/ForestBug", typeof(GameObject));
							if (270654 - 30657 == 239997)
							{
								break;
							}
						}
					}
					else if (nType == "LionBug_g")
					{
						if (294312 - 429019 != -134706)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LionBug/LionBug_g", typeof(GameObject));
							if (157016 - 198126 != -41109)
							{
								break;
							}
						}
					}
					else if (nType == "LionBug_b")
					{
						if (254184 - 431335 == -177151)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LionBug/LionBug_b", typeof(GameObject));
							if (192184 - 152741 == 39443)
							{
								break;
							}
						}
					}
					else if (nType == "LionBug_y")
					{
						if (18240 - 203199 == -184959)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LionBug/LionBug_y", typeof(GameObject));
							if (9824 - 309037 != -299212)
							{
								break;
							}
						}
					}
					else if (nType == "LeoBug_g")
					{
						if (47391 - 115803 != -68411)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LeoBug/LeoBug_g", typeof(GameObject));
							if (275242 - 160336 != 114907)
							{
								break;
							}
						}
					}
					else if (nType == "LeoBug_p")
					{
						if (169163 - 318571 != -149407)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LeoBug/LeoBug_p", typeof(GameObject));
							if (111912 - 68295 == 43617)
							{
								break;
							}
						}
					}
					else if (nType == "LeoBug_f")
					{
						if (296701 - 217925 == 78776)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LeoBug/LeoBug_f", typeof(GameObject));
							if (159566 - 36020 != 123547)
							{
								break;
							}
						}
					}
					else if (nType == "LittleFatBug_w")
					{
						if (75760 - 317271 == -241511)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LittleFatBug/LittleFatBug_w", typeof(GameObject));
							if (287813 - 313584 != -25770)
							{
								break;
							}
						}
					}
					else if (nType == "LittleFatBug_g")
					{
						if (60342 - 22008 == 38334)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LittleFatBug/LittleFatBug_g", typeof(GameObject));
							if (41173 - 529245 == -488072)
							{
								break;
							}
						}
					}
					else if (nType == "LittleFatBug_p")
					{
						if (5055 - 118993 == -113938)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LittleFatBug/LittleFatBug_p", typeof(GameObject));
							if (257770 - 219988 == 37782)
							{
								break;
							}
						}
					}
					else if (nType == "LittleFatBug_y")
					{
						if (84220 - 102263 != -18042)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/LittleFatBug/LittleFatBug_y", typeof(GameObject));
							if (224402 - 23773 == 200629)
							{
								break;
							}
						}
					}
					else if (nType == "FatBug_g")
					{
						if (283706 - 391944 != -108237)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/FatBug/FatBug_g", typeof(GameObject));
							if (160199 - 447614 == -287415)
							{
								break;
							}
						}
					}
					else if (nType == "FatBug_p")
					{
						if (281264 - 506719 == -225455)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/FatBug/FatBug_p", typeof(GameObject));
							if (207692 - 212777 == -5085)
							{
								break;
							}
						}
					}
					else if (nType == "FatBug_y")
					{
						if (278032 - 313936 != -35903)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/FatBug/FatBug_y", typeof(GameObject));
							if (64518 - 492764 == -428246)
							{
								break;
							}
						}
					}
					else if (nType == "RunAwayBug")
					{
						if (83076 - 7500 == 75576)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/RunAwayBug/RunAwayBug", typeof(GameObject));
							if (108627 - 134428 != -25800)
							{
								break;
							}
						}
					}
					else if (nType == "WormBug")
					{
						if (40678 - 559631 == -518953)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WormBug/WormBug", typeof(GameObject));
							if (33512 - 330967 != -297454)
							{
								break;
							}
						}
					}
					else if (nType == "WormBug_p")
					{
						if (7059 - 519477 != -512417)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WormBug/WormBug_p", typeof(GameObject));
							if (180131 - 408665 == -228534)
							{
								break;
							}
						}
					}
					else if (nType == "NeonBug")
					{
						if (175776 - 445474 != -269697)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NeonBug/NeonBug", typeof(GameObject));
							if (132154 - 68305 == 63849)
							{
								break;
							}
						}
					}
					else if (nType == "WaterBug")
					{
						if (123625 - 126525 != -2899)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WaterBug/WaterBug", typeof(GameObject));
							if (195604 - 141372 != 54233)
							{
								break;
							}
						}
					}
					else if (nType == "RockBug")
					{
						if (61551 - 450646 == -389095)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/RockBug/RockBug", typeof(GameObject));
							if (203687 - 396853 != -193165)
							{
								break;
							}
						}
					}
					else if (nType == "StingBug2_y")
					{
						if (104629 - 275571 != -170941)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/StingBug2/StingBug2_y", typeof(GameObject));
							if (117004 - 299333 != -182328)
							{
								break;
							}
						}
					}
					else if (nType == "StingQueen")
					{
						if (198513 - 23656 == 174857)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/StingQueen/StingQueen", typeof(GameObject));
							if (278487 - 272040 == 6447)
							{
								break;
							}
						}
					}
					else if (nType == "StingDune")
					{
						if (140734 - 427127 == -286393)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/StingDune/StingDune", typeof(GameObject));
							if (233156 - 298827 != -65670)
							{
								break;
							}
						}
					}
					else if (nType == "PaperBug1")
					{
						if (201561 - 458052 != -256490)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/PaperBug/PaperBug1", typeof(GameObject));
							if (184531 - 476719 != -292187)
							{
								break;
							}
						}
					}
					else if (nType == "PaperBug2")
					{
						if (70138 - 60954 != 9185)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/PaperBug/PaperBug2", typeof(GameObject));
							if (193197 - 183745 == 9452)
							{
								break;
							}
						}
					}
					else if (nType == "PaperBug3")
					{
						if (271742 - 391673 != -119930)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/PaperBug/PaperBug3", typeof(GameObject));
							if (128254 - 345683 == -217429)
							{
								break;
							}
						}
					}
					else if (nType == "SilverBug")
					{
						if (49471 - 476471 == -427000)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/SilverBug/SilverBug", typeof(GameObject));
							if (35971 - 331466 == -295495)
							{
								break;
							}
						}
					}
					else if (nType == "SilverQueenBug")
					{
						if (243988 - 222320 != 21669)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/SilverQueenBug/SilverQueenBug", typeof(GameObject));
							if (165900 - 593421 == -427521)
							{
								break;
							}
						}
					}
					else if (nType == "MagmaBug")
					{
						if (299227 - 595459 != -296231)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/MagmaBug/MagmaBug", typeof(GameObject));
							if (297759 - 439783 == -142024)
							{
								break;
							}
						}
					}
					else if (nType == "PandoraBug")
					{
						if (11547 - 158887 == -147340)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/PandoraBug/PandoraBug", typeof(GameObject));
							if (160623 - 197081 == -36458)
							{
								break;
							}
						}
					}
					else if (nType == "XmasBug")
					{
						if (146085 - 263661 != -117575)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/XmasBug/XmasBug", typeof(GameObject));
							if (67175 - 6924 == 60251)
							{
								break;
							}
						}
					}
					else if (nType == "SkyBug")
					{
						if (218057 - 48916 == 169141)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/SkyBug/SkyBug", typeof(GameObject));
							if (294242 - 514903 == -220661)
							{
								break;
							}
						}
					}
					else if (nType == "SkyBug2")
					{
						if (136894 - 145542 != -8647)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/SkyBug/SkyBug2", typeof(GameObject));
							if (133629 - 333389 != -199759)
							{
								break;
							}
						}
					}
					else if (nType == "CrystalBug_r")
					{
						if (291975 - 425804 != -133828)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/CrystalBug/CrystalBug_r", typeof(GameObject));
							if (58601 - 594499 == -535898)
							{
								break;
							}
						}
					}
					else if (nType == "CrystalBug_b")
					{
						if (290742 - 468512 != -177769)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/CrystalBug/CrystalBug_b", typeof(GameObject));
							if (276936 - 509747 != -232810)
							{
								break;
							}
						}
					}
					else if (nType == "CrystalBug_y")
					{
						if (246368 - 418823 != -172454)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/CrystalBug/CrystalBug_y", typeof(GameObject));
							if (3745 - 114451 == -110706)
							{
								break;
							}
						}
					}
					else if (nType == "CrystalBug_g")
					{
						if (154485 - 39185 != 115301)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/CrystalBug/CrystalBug_g", typeof(GameObject));
							if (51581 - 114034 == -62453)
							{
								break;
							}
						}
					}
					else if (nType == "CrystalBug2_r")
					{
						if (209383 - 444637 == -235254)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/CrystalBug/CrystalBug2_r", typeof(GameObject));
							if (87002 - 361399 == -274397)
							{
								break;
							}
						}
					}
					else if (nType == "CrystalBug2_b")
					{
						if (184907 - 131708 == 53199)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/CrystalBug/CrystalBug2_b", typeof(GameObject));
							if (138851 - 391094 != -252242)
							{
								break;
							}
						}
					}
					else if (nType == "CrystalBug2_y")
					{
						if (59300 - 378519 != -319218)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/CrystalBug/CrystalBug2_y", typeof(GameObject));
							if (99397 - 422785 == -323388)
							{
								break;
							}
						}
					}
					else if (nType == "CrystalBug2_g")
					{
						if (237673 - 46793 != 190881)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/CrystalBug/CrystalBug2_g", typeof(GameObject));
							if (283393 - 449536 == -166143)
							{
								break;
							}
						}
					}
					else if (nType == "AncientBug")
					{
						if (911 - 192938 != -192026)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/AncientBug/AncientBug", typeof(GameObject));
							if (173793 - 407138 == -233345)
							{
								break;
							}
						}
					}
					else if (nType == "AncientBug2")
					{
						if (78522 - 434972 != -356449)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/AncientBug/AncientBug2", typeof(GameObject));
							if (291191 - 414989 == -123798)
							{
								break;
							}
						}
					}
					else if (nType == "CoralBug")
					{
						if (299360 - 510935 == -211575)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/CoralBug/CoralBug", typeof(GameObject));
							if (174302 - 474472 != -300169)
							{
								break;
							}
						}
					}
					else if (nType == "CoralBug2")
					{
						if (179122 - 551182 == -372060)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/CoralBug/CoralBug2", typeof(GameObject));
							if (41772 - 272541 == -230769)
							{
								break;
							}
						}
					}
					else if (nType == "ReefBug")
					{
						if (10855 - 4413 == 6442)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/ReefBug/ReefBug", typeof(GameObject));
							if (37016 - 28725 != 8292)
							{
								break;
							}
						}
					}
					else if (nType == "ReefBug2")
					{
						if (4244 - 410710 != -406465)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/ReefBug/ReefBug2", typeof(GameObject));
							if (88308 - 412975 == -324667)
							{
								break;
							}
						}
					}
					else if (nType == "MokBug")
					{
						if (212512 - 86365 == 126147)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/MokBug/MokBug", typeof(GameObject));
							if (231093 - 484529 != -253435)
							{
								break;
							}
						}
					}
					else if (nType == "MokBug2")
					{
						if (187283 - 455899 != -268615)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/MokBug/MokBug2", typeof(GameObject));
							if (102464 - 179495 == -77031)
							{
								break;
							}
						}
					}
					else if (nType == "GoldenKingBug")
					{
						if (226741 - 548694 == -321953)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/GoldenKingBug/GoldenKingBug", typeof(GameObject));
							if (217803 - 364338 != -146534)
							{
								break;
							}
						}
					}
					else if (nType == "GoldenKingBug2")
					{
						if (287730 - 342346 == -54616)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/GoldenKingBug/GoldenKingBug2", typeof(GameObject));
							if (67682 - 563161 == -495479)
							{
								break;
							}
						}
					}
					else if (nType == "NemesisBug")
					{
						if (227432 - 564946 == -337514)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NemesisBug/NemesisBug", typeof(GameObject));
							if (126139 - 117284 != 8856)
							{
								break;
							}
						}
					}
					else if (nType == "NemesisBug_a")
					{
						if (204058 - 507137 == -303079)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NemesisBug/NemesisBug_a", typeof(GameObject));
							if (271420 - 153024 == 118396)
							{
								break;
							}
						}
					}
					else if (nType == "NemesisBug2")
					{
						if (247471 - 488495 == -241024)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NemesisBug2/NemesisBug2", typeof(GameObject));
							if (110980 - 552461 == -441481)
							{
								break;
							}
						}
					}
					else if (nType == "NemesisBug2_a")
					{
						if (28935 - 541226 != -512290)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NemesisBug2/NemesisBug2_a", typeof(GameObject));
							if (267499 - 275042 == -7543)
							{
								break;
							}
						}
					}
					else if (nType == "GenesisSeed")
					{
						if (142634 - 442741 == -300107)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/NemesisBug/GenesisSeed", typeof(GameObject));
							if (108767 - 343805 != -235037)
							{
								break;
							}
						}
					}
					else if (nType == "Phoenix1")
					{
						if (118950 - 442985 != -324034)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Phoenix/Phoenix1", typeof(GameObject));
							if (287528 - 357405 == -69877)
							{
								break;
							}
						}
					}
					else if (nType == "Phoenix2")
					{
						if (149168 - 205661 != -56492)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Phoenix/Phoenix2", typeof(GameObject));
							if (69420 - 52185 != 17236)
							{
								break;
							}
						}
					}
					else if (nType == "Phoenix3")
					{
						if (55817 - 593980 == -538163)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Phoenix/Phoenix3", typeof(GameObject));
							if (242044 - 556236 == -314192)
							{
								break;
							}
						}
					}
					else if (nType == "Phoenix4")
					{
						if (72492 - 395409 != -322916)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Phoenix/Phoenix4", typeof(GameObject));
							if (291778 - 86010 == 205768)
							{
								break;
							}
						}
					}
					else if (nType == "Phoenix5")
					{
						if (186742 - 315571 != -128828)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Phoenix/Phoenix5", typeof(GameObject));
							if (71186 - 263106 != -191919)
							{
								break;
							}
						}
					}
					else if (nType == "Phoenix6")
					{
						if (63821 - 591986 == -528165)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Phoenix/Phoenix6", typeof(GameObject));
							if (176088 - 39988 == 136100)
							{
								break;
							}
						}
					}
					else if (nType == "Gadina1")
					{
						if (149563 - 565599 != -416035)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Gadina/Gadina1", typeof(GameObject));
							if (93275 - 124175 == -30900)
							{
								break;
							}
						}
					}
					else if (nType == "Gadina2")
					{
						if (143532 - 577355 != -433822)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Gadina/Gadina2", typeof(GameObject));
							if (215165 - 48621 != 166545)
							{
								break;
							}
						}
					}
					else if (nType == "Gadina3")
					{
						if (37815 - 173744 != -135928)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Gadina/Gadina3", typeof(GameObject));
							if (103091 - 222032 == -118941)
							{
								break;
							}
						}
					}
					else if (nType == "Gadina4")
					{
						if (102851 - 462388 != -359536)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Gadina/Gadina4", typeof(GameObject));
							if (242602 - 433312 != -190709)
							{
								break;
							}
						}
					}
					else if (nType == "Gadina5")
					{
						if (250916 - 121196 != 129721)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Gadina/Gadina5", typeof(GameObject));
							if (127910 - 188932 == -61022)
							{
								break;
							}
						}
					}
					else if (nType == "Gadina6")
					{
						if (101197 - 35295 == 65902)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Gadina/Gadina6", typeof(GameObject));
							if (164119 - 9311 == 154808)
							{
								break;
							}
						}
					}
					else if (nType == "Ja1")
					{
						if (292332 - 53579 != 238754)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Ja/Ja1", typeof(GameObject));
							if (7493 - 201675 == -194182)
							{
								break;
							}
						}
					}
					else if (nType == "Ja2")
					{
						if (292078 - 505814 == -213736)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Ja/Ja2", typeof(GameObject));
							if (19327 - 9206 == 10121)
							{
								break;
							}
						}
					}
					else if (nType == "Ja3")
					{
						if (161223 - 247365 != -86141)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Ja/Ja3", typeof(GameObject));
							if (290607 - 525659 != -235051)
							{
								break;
							}
						}
					}
					else if (nType == "Ja4")
					{
						if (167263 - 363487 == -196224)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Ja/Ja4", typeof(GameObject));
							if (158234 - 495931 != -337696)
							{
								break;
							}
						}
					}
					else if (nType == "Ja5")
					{
						if (258752 - 255551 == 3201)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Ja/Ja5", typeof(GameObject));
							if (76809 - 579959 != -503149)
							{
								break;
							}
						}
					}
					else if (nType == "Ja6")
					{
						if (35329 - 11104 == 24225)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Ja/Ja6", typeof(GameObject));
							if (53806 - 69100 != -15293)
							{
								break;
							}
						}
					}
					else if (nType == "Lavu")
					{
						if (11679 - 276891 == -265212)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Lavu/Lavu", typeof(GameObject));
							if (95633 - 532427 == -436794)
							{
								break;
							}
						}
					}
					else if (nType == "Gaos")
					{
						if (270317 - 253499 == 16818)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Gaos/Gaos", typeof(GameObject));
							if (141369 - 455952 == -314583)
							{
								break;
							}
						}
					}
					else if (nType == "HammerStone")
					{
						if (243772 - 443507 == -199735)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/HammerStone/HammerStone", typeof(GameObject));
							if (220349 - 173911 != 46439)
							{
								break;
							}
						}
					}
					else if (nType == "Snowman")
					{
						if (97969 - 410567 != -312597)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Snowman/Snowman", typeof(GameObject));
							if (260166 - 158555 != 101612)
							{
								break;
							}
						}
					}
					else if (nType == "Vizie1")
					{
						if (75111 - 331507 == -256396)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Vizie1/Vizie1", typeof(GameObject));
							if (264099 - 234351 == 29748)
							{
								break;
							}
						}
					}
					else if (nType == "Vizie2")
					{
						if (46191 - 105298 != -59106)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Vizie2/Vizie2", typeof(GameObject));
							if (34911 - 254904 == -219993)
							{
								break;
							}
						}
					}
					else if (nType == "Vizie3")
					{
						if (173219 - 514313 != -341093)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Vizie3/Vizie3", typeof(GameObject));
							if (198391 - 431912 == -233521)
							{
								break;
							}
						}
					}
					else if (nType == "Vizie4")
					{
						if (44686 - 497969 == -453283)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Vizie4/Vizie4", typeof(GameObject));
							if (129299 - 165352 != -36052)
							{
								break;
							}
						}
					}
					else if (nType == "Shade1")
					{
						if (232358 - 16092 != 216267)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Shade1/Shade1", typeof(GameObject));
							if (50017 - 503841 != -453823)
							{
								break;
							}
						}
					}
					else if (nType == "Shade2")
					{
						if (41011 - 291384 != -250372)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Shade2/Shade2", typeof(GameObject));
							if (280684 - 126555 != 154130)
							{
								break;
							}
						}
					}
					else if (nType == "Shade3")
					{
						if (85489 - 308713 == -223224)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Shade3/Shade3", typeof(GameObject));
							if (125454 - 432824 != -307369)
							{
								break;
							}
						}
					}
					else if (nType == "Shade4")
					{
						if (62879 - 111490 == -48611)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Shade4/Shade4", typeof(GameObject));
							if (209688 - 463021 == -253333)
							{
								break;
							}
						}
					}
					else if (nType == "Shade5")
					{
						if (296136 - 130104 != 166033)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Shade5/Shade5", typeof(GameObject));
							if (159790 - 499408 == -339618)
							{
								break;
							}
						}
					}
					else if (nType == "Zerbiras")
					{
						if (236818 - 348857 == -112039)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Zerbiras/Zerbiras", typeof(GameObject));
							if (192240 - 453219 == -260979)
							{
								break;
							}
						}
					}
					else if (nType == "FoulElement")
					{
						if (59606 - 474834 == -415228)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/FoulElement/FoulElement", typeof(GameObject));
							if (32825 - 464186 == -431361)
							{
								break;
							}
						}
					}
					else if (nType == "IceDemon")
					{
						if (21653 - 58001 == -36348)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/IceDemon/IceDemon", typeof(GameObject));
							if (157117 - 164641 == -7524)
							{
								break;
							}
						}
					}
					else if (nType == "IceGuardian")
					{
						if (64421 - 90769 == -26348)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/IceGuardian/IceGuardian", typeof(GameObject));
							if (174402 - 252817 == -78415)
							{
								break;
							}
						}
					}
					else if (nType == "Ewiniar")
					{
						if (34252 - 73421 == -39169)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Ewiniar/Ewiniar", typeof(GameObject));
							if (284386 - 144569 == 139817)
							{
								break;
							}
						}
					}
					else if (nType == "LightPanther")
					{
						if (60540 - 395331 == -334791)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/LightPanther/LightPanther", typeof(GameObject));
							if (245877 - 400589 == -154712)
							{
								break;
							}
						}
					}
					else if (nType == "LightLeopard")
					{
						if (68203 - 258019 != -189815)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/LightLeopard/LightLeopard", typeof(GameObject));
							if (125854 - 470184 == -344330)
							{
								break;
							}
						}
					}
					else if (nType == "LightGolem")
					{
						if (90892 - 28404 != 62489)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/LightGolem/LightGolem", typeof(GameObject));
							if (106142 - 245448 != -139305)
							{
								break;
							}
						}
					}
					else if (nType == "BoronKnight")
					{
						if (247586 - 41911 == 205675)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/BoronKnight/BoronKnight", typeof(GameObject));
							if (158098 - 235526 == -77428)
							{
								break;
							}
						}
					}
					else if (nType == "ChromeKnight")
					{
						if (177314 - 206490 != -29175)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/ChromeKnight/ChromeKnight", typeof(GameObject));
							if (67842 - 509765 == -441923)
							{
								break;
							}
						}
					}
					else if (nType == "Germanotta")
					{
						if (54969 - 126097 != -71127)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/Germanotta/Germanotta", typeof(GameObject));
							if (160257 - 538221 == -377964)
							{
								break;
							}
						}
					}
					else if (nType == "KingRodinia")
					{
						if (151594 - 32672 == 118922)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/KingRodinia/KingRodinia", typeof(GameObject));
							if (280361 - 330977 == -50616)
							{
								break;
							}
						}
					}
					else if (nType == "KingColumn")
					{
						if (55905 - 111881 != -55975)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Elementals/KingRodinia/KingColumn", typeof(GameObject));
							if (208619 - 136086 != 72534)
							{
								break;
							}
						}
					}
					else if (nType == "AutoGyroGun1")
					{
						if (13503 - 351494 == -337991)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/AutoGyroGun/AutoGyroGun1", typeof(GameObject));
							if (121400 - 157762 != -36361)
							{
								break;
							}
						}
					}
					else if (nType == "AutoGyroGun2")
					{
						if (85007 - 555538 != -470530)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/AutoGyroGun/AutoGyroGun2", typeof(GameObject));
							if (229937 - 516347 == -286410)
							{
								break;
							}
						}
					}
					else if (nType == "AutoGyroGun3")
					{
						if (273702 - 360623 != -86920)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/AutoGyroGun/AutoGyroGun3", typeof(GameObject));
							if (85587 - 509554 != -423966)
							{
								break;
							}
						}
					}
					else if (nType == "AutoGyroGun4")
					{
						if (227197 - 487404 == -260207)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/AutoGyroGun/AutoGyroGun4", typeof(GameObject));
							if (8582 - 465029 != -456446)
							{
								break;
							}
						}
					}
					else if (nType == "AutoGallonGun")
					{
						if (299691 - 262111 == 37580)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/AutoGallonGun/AutoGallonGun", typeof(GameObject));
							if (26939 - 28248 == -1309)
							{
								break;
							}
						}
					}
					else if (nType == "BarrelBot1")
					{
						if (156823 - 272482 == -115659)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/BarrelBot/BarrelBot1", typeof(GameObject));
							if (42803 - 122851 != -80047)
							{
								break;
							}
						}
					}
					else if (nType == "BarrelBot2")
					{
						if (145530 - 254388 != -108857)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/BarrelBot/BarrelBot2", typeof(GameObject));
							if (291528 - 583231 != -291702)
							{
								break;
							}
						}
					}
					else if (nType == "BarrelBot3")
					{
						if (53736 - 597446 == -543710)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/BarrelBot/BarrelBot3", typeof(GameObject));
							if (157634 - 293450 == -135816)
							{
								break;
							}
						}
					}
					else if (nType == "BarrelBot4")
					{
						if (40765 - 431404 == -390639)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/BarrelBot/BarrelBot4", typeof(GameObject));
							if (81110 - 104942 != -23831)
							{
								break;
							}
						}
					}
					else if (nType == "GallonBot")
					{
						if (4154 - 567174 != -563019)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/GallonBot/GallonBot", typeof(GameObject));
							if (180721 - 457252 == -276531)
							{
								break;
							}
						}
					}
					else if (nType == "GiantGallonBot")
					{
						if (142872 - 214774 == -71902)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/GiantGallonBot/GiantGallonBot", typeof(GameObject));
							if (41835 - 31155 != 10681)
							{
								break;
							}
						}
					}
					else if (nType == "PrototypeKaiser")
					{
						if (253238 - 230807 != 22432)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/PrototypeKaiser/PrototypeKaiser", typeof(GameObject));
							if (75943 - 224845 != -148901)
							{
								break;
							}
						}
					}
					else if (nType == "KingKaiser")
					{
						if (280753 - 522410 == -241657)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/KingKaiser/KingKaiser_k", typeof(GameObject));
							if (238208 - 434621 == -196413)
							{
								break;
							}
						}
					}
					else if (nType == "DevilKaiser")
					{
						if (130625 - 337482 != -206856)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/DevilKaiser/DevilKaiser", typeof(GameObject));
							if (154213 - 189382 == -35169)
							{
								break;
							}
						}
					}
					else if (nType == "CamBot")
					{
						if (72547 - 292551 != -220003)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/CamBot/CamBot", typeof(GameObject));
							if (274811 - 351690 != -76878)
							{
								break;
							}
						}
					}
					else if (nType == "CutBot")
					{
						if (60784 - 498140 != -437355)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/CutBot/CutBot", typeof(GameObject));
							if (123875 - 408063 != -284187)
							{
								break;
							}
						}
					}
					else if (nType == "CarryBot")
					{
						if (251423 - 51729 != 199695)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/CarryBot/CarryBot", typeof(GameObject));
							if (243888 - 235536 != 8353)
							{
								break;
							}
						}
					}
					else if (nType == "FireBot")
					{
						if (155080 - 391910 == -236830)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/FireBot/FireBot", typeof(GameObject));
							if (121865 - 179215 != -57349)
							{
								break;
							}
						}
					}
					else if (nType == "SiegeBot")
					{
						if (23706 - 367191 != -343484)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/SiegeBot/SiegeBot", typeof(GameObject));
							if (170718 - 191282 != -20563)
							{
								break;
							}
						}
					}
					else if (nType == "CarrierBot")
					{
						if (22667 - 556288 == -533621)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/CarrierBot/CarrierBot", typeof(GameObject));
							if (264864 - 185237 != 79628)
							{
								break;
							}
						}
					}
					else if (nType == "MissileBot")
					{
						if (191291 - 232427 != -41135)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/MissileBot/MissileBot", typeof(GameObject));
							if (122715 - 95195 != 27521)
							{
								break;
							}
						}
					}
					else if (nType == "GravityBot")
					{
						if (99262 - 300358 != -201095)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/GravityBot/GravityBot", typeof(GameObject));
							if (205559 - 210288 != -4728)
							{
								break;
							}
						}
					}
					else if (nType == "RangerRobot")
					{
						if (290743 - 70816 == 219927)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Robots/RangerRobot/RangerRobot", typeof(GameObject));
							if (41606 - 51505 == -9899)
							{
								break;
							}
						}
					}
					else if (nType == "LightGod")
					{
						if (197863 - 306781 == -108918)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/LightGod/LightGod", typeof(GameObject));
							if (245439 - 464182 != -218742)
							{
								break;
							}
						}
					}
					else if (nType == "FireGod")
					{
						if (157219 - 524400 != -367180)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/FireGod/FireGod", typeof(GameObject));
							if (32977 - 493585 != -460607)
							{
								break;
							}
						}
					}
					else if (nType == "FireGod_gm")
					{
						if (38371 - 65646 == -27275)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/FireGod/FireGod_gm", typeof(GameObject));
							if (27203 - 460212 != -433008)
							{
								break;
							}
						}
					}
					else if (nType == "WaterGod")
					{
						if (11575 - 394104 == -382529)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/WaterGod/WaterGod", typeof(GameObject));
							if (233296 - 476894 == -243598)
							{
								break;
							}
						}
					}
					else if (nType == "WindGod")
					{
						if (93113 - 101488 != -8374)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/WindGod/WindGod", typeof(GameObject));
							if (136279 - 344496 != -208216)
							{
								break;
							}
						}
					}
					else if (nType == "WindGod_gm")
					{
						if (139582 - 202659 == -63077)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/WindGod/WindGod_gm", typeof(GameObject));
							if (130360 - 583540 != -453179)
							{
								break;
							}
						}
					}
					else if (nType == "WindGod_faint")
					{
						if (7362 - 312438 != -305075)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/WindGod/WindGod_faint", typeof(GameObject));
							if (267211 - 378602 == -111391)
							{
								break;
							}
						}
					}
					else if (nType == "EarthGod")
					{
						if (212387 - 286668 != -74280)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/EarthGod/EarthGod", typeof(GameObject));
							if (243966 - 306495 == -62529)
							{
								break;
							}
						}
					}
					else if (nType == "ShadowGod")
					{
						if (278791 - 164854 == 113937)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/ShadowGod/ShadowGod", typeof(GameObject));
							if (60638 - 547125 == -486487)
							{
								break;
							}
						}
					}
					else if (nType == "IceGod")
					{
						if (83230 - 302247 != -219016)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/IceGod/IceGod", typeof(GameObject));
							if (175084 - 591434 == -416350)
							{
								break;
							}
						}
					}
					else if (nType == "FakeShadowGod")
					{
						if (70080 - 337854 == -267774)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/FakeShadowGod/FakeShadowGod", typeof(GameObject));
							if (6195 - 201736 == -195541)
							{
								break;
							}
						}
					}
					else if (nType == "EarthAvatar")
					{
						if (200550 - 536877 == -336327)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Gods/EarthAvatar/EarthAvatar", typeof(GameObject));
							if (273973 - 211690 != 62284)
							{
								break;
							}
						}
					}
					else if (nType == "SnowFortGate")
					{
						if (228702 - 296150 != -67447)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Bugs/SnowFortGate/SnowFortGate", typeof(GameObject));
							if (102458 - 487547 == -385089)
							{
								break;
							}
						}
					}
					else if (nType == "TargetPractice")
					{
						if (31597 - 147589 != -115991)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/TargetPractice/TargetPractice", typeof(GameObject));
							if (297504 - 193991 == 103513)
							{
								break;
							}
						}
					}
					else if (nType == "TargetPractice_q")
					{
						if (179529 - 343573 == -164044)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/TargetPractice/TargetPractice_q", typeof(GameObject));
							if (19194 - 73460 == -54266)
							{
								break;
							}
						}
					}
					else if (nType == "TargetPractice_m")
					{
						if (286911 - 557433 != -270521)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/TargetPractice/TargetPractice_m", typeof(GameObject));
							if (264930 - 416920 != -151989)
							{
								break;
							}
						}
					}
					else if (nType == "TargetPractice_l")
					{
						if (254715 - 405591 == -150876)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/TargetPractice/TargetPractice_l", typeof(GameObject));
							if (256792 - 509939 != -253146)
							{
								break;
							}
						}
					}
					else if (nType == "GuardTower")
					{
						if (249498 - 17710 != 231789)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/GuardTower/GuardTower", typeof(GameObject));
							if (84279 - 410883 != -326603)
							{
								break;
							}
						}
					}
					else if (nType == "GuardTower_i")
					{
						if (8398 - 58530 == -50132)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/GuardTower/GuardTower_i", typeof(GameObject));
							if (83777 - 53929 == 29848)
							{
								break;
							}
						}
					}
					else if (nType == "LifeTower")
					{
						if (2300 - 404191 == -401891)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/LifeTower/LifeTower", typeof(GameObject));
							if (103834 - 556955 == -453121)
							{
								break;
							}
						}
					}
					else if (nType == "LifeTower_i")
					{
						if (244437 - 221457 == 22980)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/LifeTower/LifeTower_i", typeof(GameObject));
							if (140797 - 58106 == 82691)
							{
								break;
							}
						}
					}
					else if (nType == "ManaCore1")
					{
						if (190734 - 579969 == -389235)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/ManaCore/ManaCore1", typeof(GameObject));
							if (206424 - 15102 == 191322)
							{
								break;
							}
						}
					}
					else if (nType == "ManaCore2")
					{
						if (267938 - 238924 != 29015)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/ManaCore/ManaCore2", typeof(GameObject));
							if (154338 - 166928 == -12590)
							{
								break;
							}
						}
					}
					else if (nType == "ZappaPipe")
					{
						if (83168 - 215539 == -132371)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/ZappaPipe/ZappaPipe", typeof(GameObject));
							if (240622 - 171480 == 69142)
							{
								break;
							}
						}
					}
					else if (nType == "ShadowCrystal")
					{
						if (174243 - 593361 == -419118)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/ShadowCrystal/ShadowCrystal", typeof(GameObject));
							if (11630 - 66535 == -54905)
							{
								break;
							}
						}
					}
					else if (nType == "LightGate")
					{
						if (7545 - 248761 == -241216)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/LightGate/LightGate", typeof(GameObject));
							if (164961 - 22204 != 142758)
							{
								break;
							}
						}
					}
					else if (nType == "FrostTower")
					{
						if (149185 - 489329 != -340143)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/FrostTower/FrostTower", typeof(GameObject));
							if (30956 - 50853 != -19896)
							{
								break;
							}
						}
					}
					else if (nType == "FrostCrystal")
					{
						if (69154 - 272457 == -203303)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/FrostCrystal/FrostCrystal", typeof(GameObject));
							if (6590 - 96819 == -90229)
							{
								break;
							}
						}
					}
					else if (nType == "SmashBall")
					{
						if (23444 - 562275 == -538831)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/SmashBall/SmashBall", typeof(GameObject));
							if (292633 - 526880 == -234247)
							{
								break;
							}
						}
					}
					else if (nType == "IronBall")
					{
						if (151697 - 485747 != -334049)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/IronBall/IronBall", typeof(GameObject));
							if (95388 - 166863 != -71474)
							{
								break;
							}
						}
					}
					else if (nType == "SoccerBall")
					{
						if (160467 - 576934 == -416467)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/SoccerBall/SoccerBall", typeof(GameObject));
							if (291724 - 13082 != 278643)
							{
								break;
							}
						}
					}
					else if (nType == "VictoryTower_b")
					{
						if (143663 - 8914 == 134749)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/VictoryTower/VictoryTower_b", typeof(GameObject));
							if (103081 - 343946 == -240865)
							{
								break;
							}
						}
					}
					else if (nType == "VictoryTower_r")
					{
						if (148566 - 363929 == -215363)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/VictoryTower/VictoryTower_r", typeof(GameObject));
							if (32138 - 192573 != -160434)
							{
								break;
							}
						}
					}
					else if (nType == "VictoryCore_b")
					{
						if (282878 - 330297 == -47419)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/VictoryCore/VictoryCore_b", typeof(GameObject));
							if (93271 - 379251 == -285980)
							{
								break;
							}
						}
					}
					else if (nType == "VictoryCore_r")
					{
						if (69651 - 483114 != -413462)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/VictoryCore/VictoryCore_r", typeof(GameObject));
							if (155693 - 455641 == -299948)
							{
								break;
							}
						}
					}
					else if (nType == "WarGate")
					{
						if (26291 - 186534 != -160242)
						{
							result = (GameObject)Resources.Load("GameAssets/Characters/Structures/WarGate/WarGate", typeof(GameObject));
							if (96362 - 147493 == -51131)
							{
								break;
							}
						}
					}
					else
					{
						if (!(nType == "MupoMount1_wlf"))
						{
							if (172638 - 49964 != 122674)
							{
								continue;
							}
							if (!(nType == "MupoMount1_bsn"))
							{
								if (93317 - 203384 == -110066)
								{
									continue;
								}
								if (!(nType == "MupoMount1_pnd"))
								{
									if (174925 - 506192 != -331267)
									{
										continue;
									}
									if (!(nType == "MupoMount1_whl"))
									{
										if (259042 - 226697 != 32345)
										{
											continue;
										}
										if (!(nType == "MupoMount1_cat"))
										{
											if (7772 - 448706 == -440933)
											{
												continue;
											}
											if (!(nType == "MupoMount1_chm"))
											{
												if (99310 - 217641 == -118330)
												{
													continue;
												}
												if (!(nType == "MupoMount1_mol"))
												{
													if (202159 - 37041 == 165119)
													{
														continue;
													}
													if (!(nType == "MupoMount1_rab"))
													{
														if (138532 - 469358 != -330826)
														{
															continue;
														}
														if (!(nType == "MupoMount1_mnk"))
														{
															if (282303 - 115488 != 166815)
															{
																continue;
															}
															if (!(nType == "MupoMount1_pgn"))
															{
																if (259899 - 68497 != 191402)
																{
																	continue;
																}
																if (!(nType == "MupoMount1_shp"))
																{
																	if (172364 - 266954 == -94589)
																	{
																		continue;
																	}
																	if (nType == "MupoMount1_bat")
																	{
																		if (276126 - 499701 != -223575)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (!(nType == "MupoMount2_wlf"))
																		{
																			if (120854 - 152765 != -31911)
																			{
																				continue;
																			}
																			if (!(nType == "MupoMount2_bsn"))
																			{
																				if (26247 - 280263 != -254016)
																				{
																					continue;
																				}
																				if (!(nType == "MupoMount2_pnd"))
																				{
																					if (65476 - 35599 == 29878)
																					{
																						continue;
																					}
																					if (!(nType == "MupoMount2_whl"))
																					{
																						if (55545 - 533978 != -478433)
																						{
																							continue;
																						}
																						if (!(nType == "MupoMount2_cat"))
																						{
																							if (253120 - 470642 == -217521)
																							{
																								continue;
																							}
																							if (!(nType == "MupoMount2_chm"))
																							{
																								if (72640 - 43720 != 28920)
																								{
																									continue;
																								}
																								if (!(nType == "MupoMount2_mol"))
																								{
																									if (76816 - 373479 != -296663)
																									{
																										continue;
																									}
																									if (!(nType == "MupoMount2_rab"))
																									{
																										if (291693 - 516887 != -225194)
																										{
																											continue;
																										}
																										if (!(nType == "MupoMount2_mnk"))
																										{
																											if (184549 - 109809 != 74740)
																											{
																												continue;
																											}
																											if (!(nType == "MupoMount2_pgn"))
																											{
																												if (21515 - 198214 != -176699)
																												{
																													continue;
																												}
																												if (!(nType == "MupoMount2_shp"))
																												{
																													if (142560 - 326651 != -184091)
																													{
																														continue;
																													}
																													if (nType == "MupoMount2_bat")
																													{
																														if (41815 - 256370 == -214554)
																														{
																															continue;
																														}
																													}
																													else
																													{
																														if (!(nType == "PvpMount1_wlf"))
																														{
																															if (40071 - 451269 != -411198)
																															{
																																continue;
																															}
																															if (!(nType == "PvpMount1_bsn"))
																															{
																																if (226099 - 258650 != -32551)
																																{
																																	continue;
																																}
																																if (!(nType == "PvpMount1_pnd"))
																																{
																																	if (84267 - 17860 != 66407)
																																	{
																																		continue;
																																	}
																																	if (!(nType == "PvpMount1_whl"))
																																	{
																																		if (114645 - 235240 != -120595)
																																		{
																																			continue;
																																		}
																																		if (!(nType == "PvpMount1_cat"))
																																		{
																																			if (41090 - 541269 != -500179)
																																			{
																																				continue;
																																			}
																																			if (!(nType == "PvpMount1_chm"))
																																			{
																																				if (220318 - 67925 == 152394)
																																				{
																																					continue;
																																				}
																																				if (!(nType == "PvpMount1_mol"))
																																				{
																																					if (266335 - 204054 == 62282)
																																					{
																																						continue;
																																					}
																																					if (!(nType == "PvpMount1_rab"))
																																					{
																																						if (21751 - 524239 != -502488)
																																						{
																																							continue;
																																						}
																																						if (!(nType == "PvpMount1_mnk"))
																																						{
																																							if (151359 - 554308 == -402948)
																																							{
																																								continue;
																																							}
																																							if (!(nType == "PvpMount1_pgn"))
																																							{
																																								if (89040 - 328574 == -239533)
																																								{
																																									continue;
																																								}
																																								if (!(nType == "PvpMount1_shp"))
																																								{
																																									if (296119 - 255341 == 40779)
																																									{
																																										continue;
																																									}
																																									if (nType == "PvpMount1_bat")
																																									{
																																										if (171484 - 558316 == -386831)
																																										{
																																											continue;
																																										}
																																									}
																																									else
																																									{
																																										if (!(nType == "PvpMount2_wlf"))
																																										{
																																											if (293591 - 561426 == -267834)
																																											{
																																												continue;
																																											}
																																											if (!(nType == "PvpMount2_bsn"))
																																											{
																																												if (26775 - 405187 == -378411)
																																												{
																																													continue;
																																												}
																																												if (!(nType == "PvpMount2_pnd"))
																																												{
																																													if (269509 - 138777 == 130733)
																																													{
																																														continue;
																																													}
																																													if (!(nType == "PvpMount2_whl"))
																																													{
																																														if (205502 - 339428 != -133926)
																																														{
																																															continue;
																																														}
																																														if (!(nType == "PvpMount2_cat"))
																																														{
																																															if (16687 - 167168 == -150480)
																																															{
																																																continue;
																																															}
																																															if (!(nType == "PvpMount2_chm"))
																																															{
																																																if (249772 - 112674 == 137099)
																																																{
																																																	continue;
																																																}
																																																if (!(nType == "PvpMount2_mol"))
																																																{
																																																	if (17768 - 464820 != -447052)
																																																	{
																																																		continue;
																																																	}
																																																	if (!(nType == "PvpMount2_rab"))
																																																	{
																																																		if (84698 - 23690 == 61009)
																																																		{
																																																			continue;
																																																		}
																																																		if (!(nType == "PvpMount2_mnk"))
																																																		{
																																																			if (83249 - 140049 == -56799)
																																																			{
																																																				continue;
																																																			}
																																																			if (!(nType == "PvpMount2_pgn"))
																																																			{
																																																				if (155396 - 344894 != -189498)
																																																				{
																																																					continue;
																																																				}
																																																				if (!(nType == "PvpMount2_shp"))
																																																				{
																																																					if (184850 - 487436 != -302586)
																																																					{
																																																						continue;
																																																					}
																																																					if (nType == "PvpMount2_bat")
																																																					{
																																																						if (140320 - 576 == 139745)
																																																						{
																																																							continue;
																																																						}
																																																					}
																																																					else
																																																					{
																																																						if (!(nType == "ChampionMount_wlf"))
																																																						{
																																																							if (122794 - 67014 == 55781)
																																																							{
																																																								continue;
																																																							}
																																																							if (!(nType == "ChampionMount_bsn"))
																																																							{
																																																								if (39633 - 36893 != 2740)
																																																								{
																																																									continue;
																																																								}
																																																								if (!(nType == "ChampionMount_pnd"))
																																																								{
																																																									if (153020 - 105904 != 47116)
																																																									{
																																																										continue;
																																																									}
																																																									if (!(nType == "ChampionMount_whl"))
																																																									{
																																																										if (227500 - 521806 != -294306)
																																																										{
																																																											continue;
																																																										}
																																																										if (!(nType == "ChampionMount_cat"))
																																																										{
																																																											if (17726 - 519420 != -501694)
																																																											{
																																																												continue;
																																																											}
																																																											if (!(nType == "ChampionMount_chm"))
																																																											{
																																																												if (172707 - 374114 == -201406)
																																																												{
																																																													continue;
																																																												}
																																																												if (!(nType == "ChampionMount_mol"))
																																																												{
																																																													if (1019 - 355216 != -354197)
																																																													{
																																																														continue;
																																																													}
																																																													if (!(nType == "ChampionMount_rab"))
																																																													{
																																																														if (286837 - 192 != 286645)
																																																														{
																																																															continue;
																																																														}
																																																														if (!(nType == "ChampionMount_mnk"))
																																																														{
																																																															if (75234 - 341106 != -265872)
																																																															{
																																																																continue;
																																																															}
																																																															if (!(nType == "ChampionMount_pgn"))
																																																															{
																																																																if (5259 - 519552 == -514292)
																																																																{
																																																																	continue;
																																																																}
																																																																if (!(nType == "ChampionMount_shp"))
																																																																{
																																																																	if (292878 - 49790 == 243089)
																																																																	{
																																																																		continue;
																																																																	}
																																																																	if (nType == "ChampionMount_bat")
																																																																	{
																																																																		if (65744 - 383087 != -317343)
																																																																		{
																																																																			continue;
																																																																		}
																																																																	}
																																																																	else
																																																																	{
																																																																		if (!(nType == "CaravanMount_wlf"))
																																																																		{
																																																																			if (33154 - 199426 != -166272)
																																																																			{
																																																																				continue;
																																																																			}
																																																																			if (!(nType == "CaravanMount_bsn"))
																																																																			{
																																																																				if (75810 - 27727 != 48083)
																																																																				{
																																																																					continue;
																																																																				}
																																																																				if (!(nType == "CaravanMount_pnd"))
																																																																				{
																																																																					if (63664 - 564130 != -500466)
																																																																					{
																																																																						continue;
																																																																					}
																																																																					if (!(nType == "CaravanMount_whl"))
																																																																					{
																																																																						if (196500 - 32640 == 163861)
																																																																						{
																																																																							continue;
																																																																						}
																																																																						if (!(nType == "CaravanMount_cat"))
																																																																						{
																																																																							if (149069 - 396120 == -247050)
																																																																							{
																																																																								continue;
																																																																							}
																																																																							if (!(nType == "CaravanMount_chm"))
																																																																							{
																																																																								if (51254 - 570551 != -519297)
																																																																								{
																																																																									continue;
																																																																								}
																																																																								if (!(nType == "CaravanMount_mol"))
																																																																								{
																																																																									if (147112 - 418848 == -271735)
																																																																									{
																																																																										continue;
																																																																									}
																																																																									if (!(nType == "CaravanMount_rab"))
																																																																									{
																																																																										if (195931 - 338691 == -142759)
																																																																										{
																																																																											continue;
																																																																										}
																																																																										if (!(nType == "CaravanMount_mnk"))
																																																																										{
																																																																											if (93282 - 241452 != -148170)
																																																																											{
																																																																												continue;
																																																																											}
																																																																											if (!(nType == "CaravanMount_pgn"))
																																																																											{
																																																																												if (104775 - 507153 != -402378)
																																																																												{
																																																																													continue;
																																																																												}
																																																																												if (!(nType == "CaravanMount_shp"))
																																																																												{
																																																																													if (48701 - 124821 != -76120)
																																																																													{
																																																																														continue;
																																																																													}
																																																																													if (nType == "CaravanMount_bat")
																																																																													{
																																																																														if (213750 - 539393 != -325643)
																																																																														{
																																																																															continue;
																																																																														}
																																																																													}
																																																																													else
																																																																													{
																																																																														if (!(nType == "DeathMount_wlf"))
																																																																														{
																																																																															if (194409 - 134673 == 59737)
																																																																															{
																																																																																continue;
																																																																															}
																																																																															if (!(nType == "DeathMount_bsn"))
																																																																															{
																																																																																if (28786 - 354351 == -325564)
																																																																																{
																																																																																	continue;
																																																																																}
																																																																																if (!(nType == "DeathMount_pnd"))
																																																																																{
																																																																																	if (144229 - 540612 == -396382)
																																																																																	{
																																																																																		continue;
																																																																																	}
																																																																																	if (!(nType == "DeathMount_whl"))
																																																																																	{
																																																																																		if (222042 - 217142 != 4900)
																																																																																		{
																																																																																			continue;
																																																																																		}
																																																																																		if (!(nType == "DeathMount_cat"))
																																																																																		{
																																																																																			if (215487 - 459473 != -243986)
																																																																																			{
																																																																																				continue;
																																																																																			}
																																																																																			if (!(nType == "DeathMount_chm"))
																																																																																			{
																																																																																				if (254412 - 295541 != -41129)
																																																																																				{
																																																																																					continue;
																																																																																				}
																																																																																				if (!(nType == "DeathMount_mol"))
																																																																																				{
																																																																																					if (63801 - 88811 != -25010)
																																																																																					{
																																																																																						continue;
																																																																																					}
																																																																																					if (!(nType == "DeathMount_rab"))
																																																																																					{
																																																																																						if (54052 - 349383 != -295331)
																																																																																						{
																																																																																							continue;
																																																																																						}
																																																																																						if (!(nType == "DeathMount_mnk"))
																																																																																						{
																																																																																							if (216350 - 245089 != -28739)
																																																																																							{
																																																																																								continue;
																																																																																							}
																																																																																							if (!(nType == "DeathMount_pgn"))
																																																																																							{
																																																																																								if (176855 - 519391 == -342535)
																																																																																								{
																																																																																									continue;
																																																																																								}
																																																																																								if (!(nType == "DeathMount_shp"))
																																																																																								{
																																																																																									if (203658 - 258680 == -55021)
																																																																																									{
																																																																																										continue;
																																																																																									}
																																																																																									if (nType == "DeathMount_bat")
																																																																																									{
																																																																																										if (25513 - 578829 == -553315)
																																																																																										{
																																																																																											continue;
																																																																																										}
																																																																																									}
																																																																																									else
																																																																																									{
																																																																																										if (!(nType == "LionBugMount_wlf"))
																																																																																										{
																																																																																											if (30122 - 45860 != -15738)
																																																																																											{
																																																																																												continue;
																																																																																											}
																																																																																											if (!(nType == "LionBugMount_bsn"))
																																																																																											{
																																																																																												if (66533 - 309132 == -242598)
																																																																																												{
																																																																																													continue;
																																																																																												}
																																																																																												if (!(nType == "LionBugMount_pnd"))
																																																																																												{
																																																																																													if (145414 - 280568 == -135153)
																																																																																													{
																																																																																														continue;
																																																																																													}
																																																																																													if (!(nType == "LionBugMount_whl"))
																																																																																													{
																																																																																														if (134125 - 442272 != -308147)
																																																																																														{
																																																																																															continue;
																																																																																														}
																																																																																														if (!(nType == "LionBugMount_cat"))
																																																																																														{
																																																																																															if (228362 - 40257 == 188106)
																																																																																															{
																																																																																																continue;
																																																																																															}
																																																																																															if (!(nType == "LionBugMount_chm"))
																																																																																															{
																																																																																																if (234354 - 563203 == -328848)
																																																																																																{
																																																																																																	continue;
																																																																																																}
																																																																																																if (!(nType == "LionBugMount_mol"))
																																																																																																{
																																																																																																	if (199165 - 421499 != -222334)
																																																																																																	{
																																																																																																		continue;
																																																																																																	}
																																																																																																	if (!(nType == "LionBugMount_rab"))
																																																																																																	{
																																																																																																		if (7951 - 29584 == -21632)
																																																																																																		{
																																																																																																			continue;
																																																																																																		}
																																																																																																		if (!(nType == "LionBugMount_mnk"))
																																																																																																		{
																																																																																																			if (276368 - 388275 == -111906)
																																																																																																			{
																																																																																																				continue;
																																																																																																			}
																																																																																																			if (!(nType == "LionBugMount_pgn"))
																																																																																																			{
																																																																																																				if (88269 - 32113 == 56157)
																																																																																																				{
																																																																																																					continue;
																																																																																																				}
																																																																																																				if (!(nType == "LionBugMount_shp"))
																																																																																																				{
																																																																																																					if (5499 - 515263 != -509764)
																																																																																																					{
																																																																																																						continue;
																																																																																																					}
																																																																																																					if (nType == "LionBugMount_bat")
																																																																																																					{
																																																																																																						if (207796 - 149942 == 57855)
																																																																																																						{
																																																																																																							continue;
																																																																																																						}
																																																																																																					}
																																																																																																					else
																																																																																																					{
																																																																																																						if (!(nType == "WormBugMount_wlf"))
																																																																																																						{
																																																																																																							if (168120 - 398820 == -230699)
																																																																																																							{
																																																																																																								continue;
																																																																																																							}
																																																																																																							if (!(nType == "WormBugMount_bsn"))
																																																																																																							{
																																																																																																								if (55089 - 44675 == 10415)
																																																																																																								{
																																																																																																									continue;
																																																																																																								}
																																																																																																								if (!(nType == "WormBugMount_pnd"))
																																																																																																								{
																																																																																																									if (277355 - 491171 != -213816)
																																																																																																									{
																																																																																																										continue;
																																																																																																									}
																																																																																																									if (!(nType == "WormBugMount_whl"))
																																																																																																									{
																																																																																																										if (197500 - 104445 != 93055)
																																																																																																										{
																																																																																																											continue;
																																																																																																										}
																																																																																																										if (!(nType == "WormBugMount_cat"))
																																																																																																										{
																																																																																																											if (127412 - 301624 == -174211)
																																																																																																											{
																																																																																																												continue;
																																																																																																											}
																																																																																																											if (!(nType == "WormBugMount_chm"))
																																																																																																											{
																																																																																																												if (119837 - 468058 == -348220)
																																																																																																												{
																																																																																																													continue;
																																																																																																												}
																																																																																																												if (!(nType == "WormBugMount_mol"))
																																																																																																												{
																																																																																																													if (127523 - 67133 != 60390)
																																																																																																													{
																																																																																																														continue;
																																																																																																													}
																																																																																																													if (!(nType == "WormBugMount_rab"))
																																																																																																													{
																																																																																																														if (223883 - 216367 == 7517)
																																																																																																														{
																																																																																																															continue;
																																																																																																														}
																																																																																																														if (!(nType == "WormBugMount_mnk"))
																																																																																																														{
																																																																																																															if (146905 - 382400 == -235494)
																																																																																																															{
																																																																																																																continue;
																																																																																																															}
																																																																																																															if (!(nType == "WormBugMount_pgn"))
																																																																																																															{
																																																																																																																if (84995 - 552221 == -467225)
																																																																																																																{
																																																																																																																	continue;
																																																																																																																}
																																																																																																																if (!(nType == "WormBugMount_shp"))
																																																																																																																{
																																																																																																																	if (57168 - 159704 == -102535)
																																																																																																																	{
																																																																																																																		continue;
																																																																																																																	}
																																																																																																																	if (nType == "WormBugMount_bat")
																																																																																																																	{
																																																																																																																		if (26854 - 233665 == -206810)
																																																																																																																		{
																																																																																																																			continue;
																																																																																																																		}
																																																																																																																	}
																																																																																																																	else
																																																																																																																	{
																																																																																																																		if (!(nType == "CrabBugMount_wlf"))
																																																																																																																		{
																																																																																																																			if (16058 - 1027 != 15031)
																																																																																																																			{
																																																																																																																				continue;
																																																																																																																			}
																																																																																																																			if (!(nType == "CrabBugMount_bsn"))
																																																																																																																			{
																																																																																																																				if (83443 - 550953 == -467509)
																																																																																																																				{
																																																																																																																					continue;
																																																																																																																				}
																																																																																																																				if (!(nType == "CrabBugMount_pnd"))
																																																																																																																				{
																																																																																																																					if (113812 - 308653 == -194840)
																																																																																																																					{
																																																																																																																						continue;
																																																																																																																					}
																																																																																																																					if (nType == "CrabBugMount_whl")
																																																																																																																					{
																																																																																																																						if (47640 - 441757 != -394117)
																																																																																																																						{
																																																																																																																							continue;
																																																																																																																						}
																																																																																																																					}
																																																																																																																					else
																																																																																																																					{
																																																																																																																						if (!(nType == "DeadBullMount_mnk"))
																																																																																																																						{
																																																																																																																							if (231224 - 333642 == -102417)
																																																																																																																							{
																																																																																																																								continue;
																																																																																																																							}
																																																																																																																							if (!(nType == "DeadBullMount_pgn"))
																																																																																																																							{
																																																																																																																								if (299359 - 164316 == 135044)
																																																																																																																								{
																																																																																																																									continue;
																																																																																																																								}
																																																																																																																								if (!(nType == "DeadBullMount_shp"))
																																																																																																																								{
																																																																																																																									if (282656 - 410495 == -127838)
																																																																																																																									{
																																																																																																																										continue;
																																																																																																																									}
																																																																																																																									if (nType == "DeadBullMount_bat")
																																																																																																																									{
																																																																																																																										if (57337 - 207425 == -150087)
																																																																																																																										{
																																																																																																																											continue;
																																																																																																																										}
																																																																																																																									}
																																																																																																																									else
																																																																																																																									{
																																																																																																																										if (!(nType == "IcePenguinMount_mnk"))
																																																																																																																										{
																																																																																																																											if (154332 - 584918 != -430586)
																																																																																																																											{
																																																																																																																												continue;
																																																																																																																											}
																																																																																																																											if (!(nType == "IcePenguinMount_pgn"))
																																																																																																																											{
																																																																																																																												if (217200 - 396742 != -179542)
																																																																																																																												{
																																																																																																																													continue;
																																																																																																																												}
																																																																																																																												if (!(nType == "IcePenguinMount_shp"))
																																																																																																																												{
																																																																																																																													if (196317 - 523470 != -327153)
																																																																																																																													{
																																																																																																																														continue;
																																																																																																																													}
																																																																																																																													if (nType == "IcePenguinMount_bat")
																																																																																																																													{
																																																																																																																														if (125994 - 599352 == -473357)
																																																																																																																														{
																																																																																																																															continue;
																																																																																																																														}
																																																																																																																													}
																																																																																																																													else
																																																																																																																													{
																																																																																																																														if (!(nType == "KrathongMount_wlf"))
																																																																																																																														{
																																																																																																																															if (188366 - 522915 != -334549)
																																																																																																																															{
																																																																																																																																continue;
																																																																																																																															}
																																																																																																																															if (!(nType == "KrathongMount_bsn"))
																																																																																																																															{
																																																																																																																																if (243695 - 309848 != -66153)
																																																																																																																																{
																																																																																																																																	continue;
																																																																																																																																}
																																																																																																																																if (!(nType == "KrathongMount_pnd"))
																																																																																																																																{
																																																																																																																																	if (246530 - 441787 != -195257)
																																																																																																																																	{
																																																																																																																																		continue;
																																																																																																																																	}
																																																																																																																																	if (!(nType == "KrathongMount_whl"))
																																																																																																																																	{
																																																																																																																																		if (213321 - 372776 != -159455)
																																																																																																																																		{
																																																																																																																																			continue;
																																																																																																																																		}
																																																																																																																																		if (!(nType == "KrathongMount_cat"))
																																																																																																																																		{
																																																																																																																																			if (293351 - 25898 != 267453)
																																																																																																																																			{
																																																																																																																																				continue;
																																																																																																																																			}
																																																																																																																																			if (!(nType == "KrathongMount_chm"))
																																																																																																																																			{
																																																																																																																																				if (163716 - 557006 != -393290)
																																																																																																																																				{
																																																																																																																																					continue;
																																																																																																																																				}
																																																																																																																																				if (!(nType == "KrathongMount_mol"))
																																																																																																																																				{
																																																																																																																																					if (192852 - 328878 != -136026)
																																																																																																																																					{
																																																																																																																																						continue;
																																																																																																																																					}
																																																																																																																																					if (!(nType == "KrathongMount_rab"))
																																																																																																																																					{
																																																																																																																																						if (228935 - 560481 == -331545)
																																																																																																																																						{
																																																																																																																																							continue;
																																																																																																																																						}
																																																																																																																																						if (!(nType == "KrathongMount_mnk"))
																																																																																																																																						{
																																																																																																																																							if (70458 - 78408 != -7950)
																																																																																																																																							{
																																																																																																																																								continue;
																																																																																																																																							}
																																																																																																																																							if (!(nType == "KrathongMount_pgn"))
																																																																																																																																							{
																																																																																																																																								if (90492 - 335845 != -245353)
																																																																																																																																								{
																																																																																																																																									continue;
																																																																																																																																								}
																																																																																																																																								if (!(nType == "KrathongMount_shp"))
																																																																																																																																								{
																																																																																																																																									if (272851 - 239277 == 33575)
																																																																																																																																									{
																																																																																																																																										continue;
																																																																																																																																									}
																																																																																																																																									if (nType == "KrathongMount_bat")
																																																																																																																																									{
																																																																																																																																										if (27481 - 199371 != -171890)
																																																																																																																																										{
																																																																																																																																											continue;
																																																																																																																																										}
																																																																																																																																									}
																																																																																																																																									else if (nType == "MoleTank")
																																																																																																																																									{
																																																																																																																																										if (211428 - 452091 != -240663)
																																																																																																																																										{
																																																																																																																																											continue;
																																																																																																																																										}
																																																																																																																																										result = Game.LoadMount("MoleTank");
																																																																																																																																										if (257313 - 125341 != 131973)
																																																																																																																																										{
																																																																																																																																											break;
																																																																																																																																										}
																																																																																																																																										continue;
																																																																																																																																									}
																																																																																																																																									else if (nType == "GigaCannon")
																																																																																																																																									{
																																																																																																																																										if (11463 - 163877 != -152414)
																																																																																																																																										{
																																																																																																																																											continue;
																																																																																																																																										}
																																																																																																																																										result = Game.LoadMount("GigaCannon");
																																																																																																																																										if (190609 - 552479 != -361870)
																																																																																																																																										{
																																																																																																																																											continue;
																																																																																																																																										}
																																																																																																																																										break;
																																																																																																																																									}
																																																																																																																																									else if (nType == "RangerRobotMount")
																																																																																																																																									{
																																																																																																																																										if (21728 - 323011 != -301283)
																																																																																																																																										{
																																																																																																																																											continue;
																																																																																																																																										}
																																																																																																																																										result = Game.LoadMount("RangerRobotMount");
																																																																																																																																										if (198697 - 562018 != -363321)
																																																																																																																																										{
																																																																																																																																											continue;
																																																																																																																																										}
																																																																																																																																										break;
																																																																																																																																									}
																																																																																																																																									else
																																																																																																																																									{
																																																																																																																																										Debug.LogError("GetPrefab Error:" + nType);
																																																																																																																																										if (101920 - 335407 != -233487)
																																																																																																																																										{
																																																																																																																																											continue;
																																																																																																																																										}
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
																																																																																																																														result = Game.LoadMount("KrathongMount_" + NetworkUtility.DecodeRace(nType.Substring(14, 3)));
																																																																																																																														if (273722 - 238994 != 34728)
																																																																																																																														{
																																																																																																																															continue;
																																																																																																																														}
																																																																																																																														break;
																																																																																																																													}
																																																																																																																												}
																																																																																																																											}
																																																																																																																										}
																																																																																																																										result = Game.LoadMount("IcePenguinMount_" + NetworkUtility.DecodeRace(nType.Substring(16, 3)));
																																																																																																																										if (163909 - 596140 != -432231)
																																																																																																																										{
																																																																																																																											continue;
																																																																																																																										}
																																																																																																																										break;
																																																																																																																									}
																																																																																																																								}
																																																																																																																							}
																																																																																																																						}
																																																																																																																						result = Game.LoadMount("DeadBullMount_" + NetworkUtility.DecodeRace(nType.Substring(14, 3)));
																																																																																																																						if (235502 - 349142 != -113640)
																																																																																																																						{
																																																																																																																							continue;
																																																																																																																						}
																																																																																																																						break;
																																																																																																																					}
																																																																																																																				}
																																																																																																																			}
																																																																																																																		}
																																																																																																																		result = Game.LoadMount("CrabBugMount_" + NetworkUtility.DecodeRace(nType.Substring(13, 3)));
																																																																																																																		if (85548 - 213497 != -127949)
																																																																																																																		{
																																																																																																																			continue;
																																																																																																																		}
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
																																																																																																						result = Game.LoadMount("WormBugMount_" + NetworkUtility.DecodeRace(nType.Substring(13, 3)));
																																																																																																						if (12162 - 170301 != -158138)
																																																																																																						{
																																																																																																							break;
																																																																																																						}
																																																																																																						continue;
																																																																																																					}
																																																																																																				}
																																																																																																			}
																																																																																																		}
																																																																																																	}
																																																																																																}
																																																																																															}
																																																																																														}
																																																																																													}
																																																																																												}
																																																																																											}
																																																																																										}
																																																																																										result = Game.LoadMount("LionBugMount_" + NetworkUtility.DecodeRace(nType.Substring(13, 3)));
																																																																																										if (298368 - 454519 != -156150)
																																																																																										{
																																																																																											break;
																																																																																										}
																																																																																										continue;
																																																																																									}
																																																																																								}
																																																																																							}
																																																																																						}
																																																																																					}
																																																																																				}
																																																																																			}
																																																																																		}
																																																																																	}
																																																																																}
																																																																															}
																																																																														}
																																																																														result = Game.LoadMount("DeathMount_" + NetworkUtility.DecodeRace(nType.Substring(11, 3)));
																																																																														if (240494 - 568054 != -327559)
																																																																														{
																																																																															break;
																																																																														}
																																																																														continue;
																																																																													}
																																																																												}
																																																																											}
																																																																										}
																																																																									}
																																																																								}
																																																																							}
																																																																						}
																																																																					}
																																																																				}
																																																																			}
																																																																		}
																																																																		result = Game.LoadMount("CaravanMount_" + NetworkUtility.DecodeRace(nType.Substring(13, 3)));
																																																																		if (137242 - 580232 != -442990)
																																																																		{
																																																																			continue;
																																																																		}
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
																																																						result = Game.LoadMount("ChampionMount_" + NetworkUtility.DecodeRace(nType.Substring(14, 3)));
																																																						if (132308 - 359489 != -227180)
																																																						{
																																																							break;
																																																						}
																																																						continue;
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																										result = Game.LoadMount("PvpMount2_" + NetworkUtility.DecodeRace(nType.Substring(10, 3)));
																																										if (110913 - 462967 != -352053)
																																										{
																																											break;
																																										}
																																										continue;
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																														result = Game.LoadMount("PvpMount1_" + NetworkUtility.DecodeRace(nType.Substring(10, 3)));
																														if (128682 - 201422 != -72739)
																														{
																															break;
																														}
																														continue;
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																		result = Game.LoadMount("MupoMount2_" + NetworkUtility.DecodeRace(nType.Substring(11, 3)));
																		if (156796 - 492442 != -335645)
																		{
																			break;
																		}
																		continue;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						result = Game.LoadMount("MupoMount1_" + NetworkUtility.DecodeRace(nType.Substring(11, 3)));
						if (11599 - 541431 == -529832)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005E73 RID: 24179 RVA: 0x00CAE4B4 File Offset: 0x00CAC6B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject LoadMount(string nMount)
	{
		if (181793 - 66502 != 115291)
		{
		}
		GameObject result;
		for (;;)
		{
			if (!Game.MountBundle)
			{
				if (205209 - 132735 == 72475)
				{
					continue;
				}
				if (Application.isEditor)
				{
					if (60144 - 284219 != -224075)
					{
						continue;
					}
					Game.MountBundle = AssetBundle.CreateFromFile(Application.dataPath + "/TTOAssetBundle/Mount.assetBundle");
					if (48300 - 329705 == -281404)
					{
						continue;
					}
				}
				else
				{
					Game.MountBundle = AssetBundle.CreateFromFile(Application.dataPath + "/Mount.assetBundle");
					if (205366 - 144282 != 61084)
					{
						continue;
					}
				}
			}
			if (Game.MountBundle)
			{
				if (97995 - 26023 == 71972)
				{
					if (Game.MountBundle.Contains(nMount))
					{
						if (285694 - 217267 != 68428)
						{
							result = (GameObject)Game.MountBundle.Load(nMount, typeof(GameObject));
							if (139471 - 492725 == -353254)
							{
								break;
							}
						}
					}
					else
					{
						Debug.Log("Cannot find " + nMount + "from MountBundle");
						if (181319 - 481827 != -300507)
						{
							goto Block_13;
						}
					}
				}
			}
			else
			{
				Debug.Log("Error loading MountBundle");
				if (113430 - 125811 == -12381)
				{
					goto IL_1BD;
				}
			}
		}
		return result;
		Block_13:
		IL_1BD:
		return null;
	}

	// Token: 0x06005E74 RID: 24180 RVA: 0x00CAE690 File Offset: 0x00CAC890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setGameState(eGameState nState)
	{
		if (133949 - 556300 != -422351)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (150510 - 365897 != -215386)
			{
				hashtable.Add(7, PhotonClient.cInt16(2));
				if (90347 - 427468 == -337121)
				{
					if (!PhotonClient.IsInitialized())
					{
						break;
					}
					if (279479 - 236604 == 42875)
					{
						PhotonClient.Connection.OpCustom(55, hashtable, true);
						if (221232 - 437234 == -216002)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005E75 RID: 24181 RVA: 0x00CAE768 File Offset: 0x00CAC968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void sendMissionEvent(int nCode, int nValue)
	{
		if (189770 - 377859 != -188089)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (277920 - 481012 == -203092)
			{
				hashtable.Add(141, PhotonClient.cInt16(nCode));
				if (181628 - 119460 == 62168)
				{
					hashtable.Add(145, PhotonClient.cInt16(nValue));
					if (277253 - 369404 != -92150)
					{
						hashtable.Add(43, PlayerData.UID);
						if (757 - 196923 != -196165)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (87179 - 228181 != -141001)
							{
								PhotonClient.Connection.OpCustom(141, hashtable, true);
								if (242928 - 375575 != -132646)
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

	// Token: 0x06005E76 RID: 24182 RVA: 0x00CAE8AC File Offset: 0x00CACAAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void sendQuestUpdate(int nState)
	{
		if (208173 - 337767 != -129593)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (172100 - 1534 == 170566)
			{
				hashtable.Add(43, PlayerData.UID);
				if (200902 - 542308 != -341405)
				{
					hashtable.Add(50, PhotonClient.cInt16(PlayerData.QuestID));
					if (103364 - 330502 == -227138)
					{
						hashtable.Add(51, PhotonClient.cInt16(nState));
						if (183024 - 243690 != -60665)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (208045 - 223992 == -15947)
							{
								PhotonClient.Connection.OpCustom(122, hashtable, true);
								if (212070 - 163175 == 48895)
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

	// Token: 0x06005E77 RID: 24183 RVA: 0x00CAE9EC File Offset: 0x00CACBEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005E78 RID: 24184 RVA: 0x00CAE9F0 File Offset: 0x00CACBF0
	internal static bool ida30rpUnhnRUO8is7ee()
	{
		return true;
	}

	// Token: 0x06005E79 RID: 24185 RVA: 0x00CAE9F4 File Offset: 0x00CACBF4
	internal static bool UHdO6tpU6mmXYUhK95sY()
	{
		return false;
	}

	// Token: 0x04006864 RID: 26724
	[NonSerialized]
	public static int version;

	// Token: 0x04006865 RID: 26725
	[NonSerialized]
	public static int server;

	// Token: 0x04006866 RID: 26726
	[NonSerialized]
	public static int maxLevel;

	// Token: 0x04006867 RID: 26727
	[NonSerialized]
	public static int volume;

	// Token: 0x04006868 RID: 26728
	[NonSerialized]
	public static int music;

	// Token: 0x04006869 RID: 26729
	[NonSerialized]
	public static int mGameId;

	// Token: 0x0400686A RID: 26730
	[NonSerialized]
	public static int mGameCode;

	// Token: 0x0400686B RID: 26731
	[NonSerialized]
	public static int mGameStage;

	// Token: 0x0400686C RID: 26732
	[NonSerialized]
	public static int[] mGamePlayer;

	// Token: 0x0400686D RID: 26733
	[NonSerialized]
	public static Hashtable mGamePlayerList;

	// Token: 0x0400686E RID: 26734
	[NonSerialized]
	public static Hashtable mGamePlayerName;

	// Token: 0x0400686F RID: 26735
	[NonSerialized]
	public static Hashtable mGamePlayerType;

	// Token: 0x04006870 RID: 26736
	[NonSerialized]
	public static int mLastGameId;

	// Token: 0x04006871 RID: 26737
	[NonSerialized]
	public static int mLastGameCode;

	// Token: 0x04006872 RID: 26738
	[NonSerialized]
	public static int[] mLastGamePlayer;

	// Token: 0x04006873 RID: 26739
	[NonSerialized]
	public static int mNextGameId;

	// Token: 0x04006874 RID: 26740
	[NonSerialized]
	public static int mNextGameCode;

	// Token: 0x04006875 RID: 26741
	[NonSerialized]
	public static int[] mNextGamePlayer;

	// Token: 0x04006876 RID: 26742
	[NonSerialized]
	public static int mGameType;

	// Token: 0x04006877 RID: 26743
	[NonSerialized]
	public static eGameState mGameState;

	// Token: 0x04006878 RID: 26744
	[NonSerialized]
	public static float mStateTime;

	// Token: 0x04006879 RID: 26745
	[NonSerialized]
	public static GameObject mPlayer;

	// Token: 0x0400687A RID: 26746
	[NonSerialized]
	public static int mPlayerID;

	// Token: 0x0400687B RID: 26747
	[NonSerialized]
	public static int mPlayerSlot;

	// Token: 0x0400687C RID: 26748
	[NonSerialized]
	public static int mTeam;

	// Token: 0x0400687D RID: 26749
	[NonSerialized]
	public static float mGameTime;

	// Token: 0x0400687E RID: 26750
	[NonSerialized]
	public static int mGameScore;

	// Token: 0x0400687F RID: 26751
	[NonSerialized]
	public static int mGameMana;

	// Token: 0x04006880 RID: 26752
	[NonSerialized]
	public static bool canUseItem;

	// Token: 0x04006881 RID: 26753
	[NonSerialized]
	public static bool canUseMount;

	// Token: 0x04006882 RID: 26754
	[NonSerialized]
	public static bool canChangeChar;

	// Token: 0x04006883 RID: 26755
	[NonSerialized]
	public static bool canRespawn;

	// Token: 0x04006884 RID: 26756
	[NonSerialized]
	public static bool canUseCoin;

	// Token: 0x04006885 RID: 26757
	[NonSerialized]
	public static bool useAdvanceMode;

	// Token: 0x04006886 RID: 26758
	[NonSerialized]
	public static bool useRandomLoot;

	// Token: 0x04006887 RID: 26759
	[NonSerialized]
	public static bool useCoin;

	// Token: 0x04006888 RID: 26760
	[NonSerialized]
	public static UnityScript.Lang.Array useCoinList;

	// Token: 0x04006889 RID: 26761
	[NonSerialized]
	public static int mLastGameHP;

	// Token: 0x0400688A RID: 26762
	[NonSerialized]
	public static int mLastGameMP;

	// Token: 0x0400688B RID: 26763
	[NonSerialized]
	public static int mLastGameSP;

	// Token: 0x0400688C RID: 26764
	[NonSerialized]
	public static int mLastGameKO;

	// Token: 0x0400688D RID: 26765
	[NonSerialized]
	public static UnityScript.Lang.Array mLastGameTimeOutList;

	// Token: 0x0400688E RID: 26766
	[NonSerialized]
	public static AssetBundle MountBundle;
}
