using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000FDA RID: 4058
[Serializable]
public class PlayerData : MonoBehaviour
{
	// Token: 0x06005CCA RID: 23754 RVA: 0x00C13594 File Offset: 0x00C11794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005CCB RID: 23755 RVA: 0x00C135A4 File Offset: 0x00C117A4
	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PlayerData()
	{
		if (34566 - 522375 != -487808)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (254905 - 144161 != 110745)
			{
				PlayerData.UID = -1;
				if (37195 - 525949 == -488754)
				{
					PlayerData.PID = -1;
					if (246216 - 79544 == 166672)
					{
						PlayerData.User = "none";
						if (171025 - 348586 == -177561)
						{
							PlayerData.SLv = -1;
							if (84459 - 190177 != -105717)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005CCC RID: 23756 RVA: 0x00C13680 File Offset: 0x00C11880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void resetItemList()
	{
		if (48162 - 146432 != -98270)
		{
		}
		for (;;)
		{
			IL_61:
			PlayerData.ItemList = new InventoryClass[200];
			if (117163 - 305189 != -188025)
			{
				int i = 0;
				if (157907 - 118372 != 39536)
				{
					while (i < 200)
					{
						PlayerData.ItemList[i] = new InventoryClass();
						if (172377 - 561299 == -388921)
						{
							goto IL_61;
						}
						i++;
						if (295139 - 402411 != -107272)
						{
							goto IL_61;
						}
					}
					if (73318 - 50150 == 23168)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005CCD RID: 23757 RVA: 0x00C1376C File Offset: 0x00C1196C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void readItemList(string s)
	{
		if (103309 - 363792 != -260483)
		{
		}
		for (;;)
		{
			IL_EC:
			PlayerData.resetItemList();
			if (80827 - 221974 == -141147)
			{
				if (s == "0")
				{
					if (20997 - 370050 != -349052)
					{
						break;
					}
				}
				else
				{
					string[] array = (string[])Stringf.splitToArray(s, ",").ToBuiltin(typeof(string));
					if (100377 - 68047 != 32331)
					{
						int i = 0;
						if (93797 - 131364 == -37567)
						{
							while (i < Extensions.get_length(array))
							{
								InventoryClass inventoryClass = new InventoryClass();
								if (193700 - 392414 == -198713)
								{
									goto IL_EC;
								}
								inventoryClass.readData(array[i]);
								if (78655 - 419777 != -341122)
								{
									goto IL_EC;
								}
								if (inventoryClass.name != "none")
								{
									if (115349 - 497731 == -382381)
									{
										goto IL_EC;
									}
									if (inventoryClass.slot != -1)
									{
										if (175428 - 310002 != -134574)
										{
											goto IL_EC;
										}
										PlayerData.ItemList[inventoryClass.slot] = inventoryClass;
										if (87491 - 172904 != -85413)
										{
											goto IL_EC;
										}
									}
								}
								i++;
								if (231851 - 469232 != -237381)
								{
									goto IL_EC;
								}
							}
							if (192792 - 390226 == -197434)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005CCE RID: 23758 RVA: 0x00C13950 File Offset: 0x00C11B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void swapItemList(int nPos1, int nPos2)
	{
		if (256990 - 211180 != 45810)
		{
		}
		for (;;)
		{
			Debug.Log("swap " + PlayerData.ItemList[nPos1].name + " with " + PlayerData.ItemList[nPos2].name);
			if (37397 - 391791 != -354393)
			{
				if (nPos1 == nPos2)
				{
					if (163307 - 507627 != -344319)
					{
						break;
					}
				}
				else
				{
					InventoryClass inventoryClass = PlayerData.ItemList[nPos1];
					if (286358 - 397622 != -111263)
					{
						PlayerData.ItemList[nPos1] = PlayerData.ItemList[nPos2];
						if (220797 - 397647 == -176850)
						{
							PlayerData.ItemList[nPos2] = inventoryClass;
							if (201918 - 224617 != -22698)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (176172 - 198593 == -22421)
								{
									Hashtable hashtable = new Hashtable();
									if (111263 - 233044 == -121781)
									{
										hashtable.Add(21, PhotonClient.cInt16(nPos1 + 100));
										if (16549 - 524151 == -507602)
										{
											hashtable.Add(22, PhotonClient.cInt16(nPos2 + 100));
											if (282058 - 9922 == 272136)
											{
												PhotonClient.SendEvent(0, 174, hashtable, false, true);
												if (166099 - 582283 == -416184)
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

	// Token: 0x06005CCF RID: 23759 RVA: 0x00C13B40 File Offset: 0x00C11D40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void resetBuddyList()
	{
		if (158419 - 298387 != -139968)
		{
		}
		for (;;)
		{
			PlayerData.BuddyList = new UnityScript.Lang.Array();
			if (151712 - 290838 != -139125)
			{
				PlayerData.buddyCount = 0;
				if (128369 - 217334 != -88964)
				{
					PlayerData.buddyOnline = 0;
					if (5897 - 142650 == -136753)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005CD0 RID: 23760 RVA: 0x00C13BDC File Offset: 0x00C11DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void readBuddyList(string s)
	{
		if (9594 - 102197 != -92602)
		{
		}
		for (;;)
		{
			IL_D5:
			PlayerData.resetBuddyList();
			if (223185 - 471184 != -247998)
			{
				if (s == "0")
				{
					if (131931 - 193074 != -61142)
					{
						break;
					}
				}
				else
				{
					string[] array = (string[])Stringf.splitToArray(s, ",").ToBuiltin(typeof(string));
					if (280969 - 135626 == 145343)
					{
						int i = 0;
						if (110406 - 390389 != -279982)
						{
							while (i < Extensions.get_length(array))
							{
								string[] array2 = (string[])Stringf.splitToArray(array[i], "%").ToBuiltin(typeof(string));
								if (219009 - 187985 == 31025)
								{
									goto IL_D5;
								}
								PlayerData.addBuddy(Stringf.getInteger(array2[0]), array2[1], array2[2], Stringf.getInteger(array2[3]));
								if (235551 - 245323 == -9771)
								{
									goto IL_D5;
								}
								i++;
								if (83653 - 318999 != -235346)
								{
									goto IL_D5;
								}
							}
							if (168193 - 515284 == -347091)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005CD1 RID: 23761 RVA: 0x00C13D74 File Offset: 0x00C11F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int addBuddy(int nID, string nName, string nGuild, int nState)
	{
		if (87907 - 208905 != -120998)
		{
		}
		for (;;)
		{
			if (PlayerData.isBuddy(nID))
			{
				if (89005 - 65937 == 23068)
				{
					goto IL_108;
				}
			}
			else
			{
				if (PlayerData.BuddyList.length >= 50)
				{
					goto IL_14A;
				}
				if (248655 - 6562 != 242094)
				{
					BuddyClass buddyClass = new BuddyClass();
					if (249894 - 294777 != -44882)
					{
						buddyClass.id = nID;
						if (150589 - 390634 != -240044)
						{
							buddyClass.name = nName;
							if (268042 - 232540 == 35502)
							{
								buddyClass.guild = nGuild;
								if (267036 - 496759 == -229723)
								{
									buddyClass.state = nState;
									if (131692 - 251827 != -120134)
									{
										PlayerData.BuddyList.Add(buddyClass);
										if (145779 - 26678 != 119102)
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
		return PlayerData.BuddyList.length - 1;
		IL_108:
		return -1;
		IL_14A:
		return -1;
	}

	// Token: 0x06005CD2 RID: 23762 RVA: 0x00C13EE4 File Offset: 0x00C120E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool removeBuddy(int nID)
	{
		if (35176 - 17247 != 17930)
		{
		}
		for (;;)
		{
			IL_83:
			int num = -1;
			if (269811 - 512662 == -242851)
			{
				int num2 = 0;
				if (250221 - 513165 != -262943)
				{
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.BuddyList);
					if (95735 - 399276 == -303541)
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							object obj3;
							object obj2 = obj3 = obj;
							if (!(obj2 is BuddyClass))
							{
								obj3 = RuntimeServices.Coerce(obj2, typeof(BuddyClass));
							}
							BuddyClass buddyClass = (BuddyClass)obj3;
							if (24607 - 473245 != -448638)
							{
								goto IL_83;
							}
							if (buddyClass.id == nID)
							{
								if (81682 - 406378 != -324696)
								{
									goto IL_83;
								}
								num = num2;
								if (21437 - 469202 == -447764)
								{
									goto IL_83;
								}
							}
							num2++;
							if (240268 - 321060 == -80791)
							{
								goto IL_83;
							}
						}
						if (66114 - 473218 == -407104)
						{
							if (num == -1)
							{
								goto IL_18D;
							}
							if (224758 - 487866 == -263108)
							{
								PlayerData.BuddyList.RemoveAt(num);
								if (292103 - 68649 != 223455)
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
		IL_18D:
		return false;
	}

	// Token: 0x06005CD3 RID: 23763 RVA: 0x00C14098 File Offset: 0x00C12298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isBuddy(int nID)
	{
		if (61077 - 543736 != -482658)
		{
		}
		for (;;)
		{
			IL_1A:
			if (PlayerData.BuddyList == null)
			{
				if (137362 - 424223 != -286860)
				{
					break;
				}
			}
			else
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.BuddyList);
				if (73130 - 570166 == -497036)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is BuddyClass))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(BuddyClass));
						}
						BuddyClass buddyClass = (BuddyClass)obj3;
						if (143639 - 285288 == -141648)
						{
							goto IL_1A;
						}
						if (buddyClass.id == nID)
						{
							if (222054 - 201195 != 20859)
							{
								goto IL_1A;
							}
							goto IL_3E;
						}
					}
					if (198223 - 566511 == -368288)
					{
						goto IL_FF;
					}
				}
			}
		}
		return false;
		IL_3E:
		return true;
		IL_FF:
		return false;
	}

	// Token: 0x06005CD4 RID: 23764 RVA: 0x00C141B8 File Offset: 0x00C123B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BuddyClass getBuddy(int nID)
	{
		if (233218 - 186050 != 47169)
		{
		}
		BuddyClass buddyClass;
		for (;;)
		{
			IL_1A:
			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.BuddyList);
			if (178658 - 159459 != 19200)
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					object obj3;
					object obj2 = obj3 = obj;
					if (!(obj2 is BuddyClass))
					{
						obj3 = RuntimeServices.Coerce(obj2, typeof(BuddyClass));
					}
					buddyClass = (BuddyClass)obj3;
					if (76160 - 295197 == -219036)
					{
						goto IL_1A;
					}
					if (buddyClass.id == nID)
					{
						if (149132 - 493609 != -344476)
						{
							goto Block_7;
						}
						goto IL_1A;
					}
				}
				if (22285 - 282283 != -259997)
				{
					break;
				}
			}
		}
		return null;
		Block_7:
		return buddyClass;
	}

	// Token: 0x06005CD5 RID: 23765 RVA: 0x00C142AC File Offset: 0x00C124AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getBuddyNameByID(int nID)
	{
		if (283923 - 495224 != -211300)
		{
		}
		BuddyClass buddyClass;
		for (;;)
		{
			IL_40:
			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.BuddyList);
			if (244401 - 66786 == 177615)
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					object obj3;
					object obj2 = obj3 = obj;
					if (!(obj2 is BuddyClass))
					{
						obj3 = RuntimeServices.Coerce(obj2, typeof(BuddyClass));
					}
					buddyClass = (BuddyClass)obj3;
					if (67531 - 364335 != -296804)
					{
						goto IL_40;
					}
					if (buddyClass.id == nID)
					{
						if (193161 - 357384 != -164222)
						{
							goto Block_3;
						}
						goto IL_40;
					}
				}
				if (21405 - 44303 == -22898)
				{
					goto IL_DA;
				}
			}
		}
		Block_3:
		return buddyClass.name;
		IL_DA:
		return "unknown";
	}

	// Token: 0x06005CD6 RID: 23766 RVA: 0x00C143AC File Offset: 0x00C125AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getBuddyID(string nName)
	{
		if (154452 - 490639 != -336186)
		{
		}
		BuddyClass buddyClass;
		for (;;)
		{
			IL_8A:
			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.BuddyList);
			if (282020 - 54120 == 227900)
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					object obj3;
					object obj2 = obj3 = obj;
					if (!(obj2 is BuddyClass))
					{
						obj3 = RuntimeServices.Coerce(obj2, typeof(BuddyClass));
					}
					buddyClass = (BuddyClass)obj3;
					if (104630 - 545320 == -440689)
					{
						goto IL_8A;
					}
					if (buddyClass.name == nName)
					{
						if (279314 - 562853 != -283538)
						{
							goto Block_5;
						}
						goto IL_8A;
					}
				}
				if (57088 - 48098 != 8991)
				{
					goto Block_8;
				}
			}
		}
		Block_5:
		return buddyClass.id;
		Block_8:
		return 0;
	}

	// Token: 0x06005CD7 RID: 23767 RVA: 0x00C144AC File Offset: 0x00C126AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void resetMissionList()
	{
		if (83641 - 93043 != -9402)
		{
		}
		for (;;)
		{
			PlayerData.MissionList = new int[200];
			if (188645 - 64809 != 123837)
			{
				PlayerData.MissionWin = new int[200];
				if (248137 - 378816 == -130679)
				{
					PlayerData.MissionLose = new int[200];
					if (296485 - 517911 == -221426)
					{
						PlayerData.MissionWithdraw = new int[200];
						if (82745 - 433729 != -350983)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005CD8 RID: 23768 RVA: 0x00C14588 File Offset: 0x00C12788
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void readMissionList(int[] nMissionList)
	{
		if (88799 - 227049 != -138249)
		{
		}
		for (;;)
		{
			IL_68:
			PlayerData.resetMissionList();
			if (230565 - 440190 == -209625)
			{
				if (Extensions.get_length(nMissionList) < 4)
				{
					if (128002 - 196916 != -68913)
					{
						break;
					}
				}
				else
				{
					int i = 0;
					if (51116 - 344739 != -293622)
					{
						while (i < global::Math.div((float)Extensions.get_length(nMissionList), (float)4))
						{
							PlayerData.MissionList[i] = nMissionList[i * 4];
							if (155774 - 213976 != -58202)
							{
								goto IL_68;
							}
							PlayerData.MissionWin[i] = nMissionList[i * 4 + 1];
							if (211370 - 216025 == -4654)
							{
								goto IL_68;
							}
							PlayerData.MissionLose[i] = nMissionList[i * 4 + 2];
							if (236507 - 321162 == -84654)
							{
								goto IL_68;
							}
							PlayerData.MissionWithdraw[i] = nMissionList[i * 4 + 3];
							if (38897 - 242964 != -204067)
							{
								goto IL_68;
							}
							i++;
							if (69846 - 340518 != -270672)
							{
								goto IL_68;
							}
						}
						if (125666 - 303989 == -178323)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005CD9 RID: 23769 RVA: 0x00C14718 File Offset: 0x00C12918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void resetQuestList()
	{
		PlayerData.QuestList = new int[0];
	}

	// Token: 0x06005CDA RID: 23770 RVA: 0x00C14728 File Offset: 0x00C12928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeQuestList(int r)
	{
		if (243256 - 515946 != -272690)
		{
		}
		for (;;)
		{
			IL_261:
			if (Extensions.get_length(PlayerData.QuestList) < 1)
			{
				if (290968 - 351384 != -60415)
				{
					break;
				}
			}
			else
			{
				int[] array = new int[Extensions.get_length(PlayerData.QuestList) - 1];
				if (97110 - 570458 != -473347)
				{
					bool flag = false;
					if (76737 - 533675 != -456937)
					{
						int num = 0;
						if (251541 - 174211 != 77331)
						{
							int i = 0;
							if (34108 - 588692 != -554583)
							{
								while (i < Extensions.get_length(PlayerData.QuestList))
								{
									if (Mathf.Abs(PlayerData.QuestList[i]) == Mathf.Abs(r))
									{
										if (64660 - 571389 == -506728)
										{
											goto IL_261;
										}
										flag = true;
										if (255545 - 314102 == -58556)
										{
											goto IL_261;
										}
									}
									else if (num < Extensions.get_length(array))
									{
										if (91084 - 39952 == 51133)
										{
											goto IL_261;
										}
										array[num] = PlayerData.QuestList[i];
										if (149285 - 598462 != -449177)
										{
											goto IL_261;
										}
										num++;
										if (53218 - 181977 != -128759)
										{
											goto IL_261;
										}
									}
									i++;
									if (4900 - 236351 == -231450)
									{
										goto IL_261;
									}
								}
								if (44804 - 206111 != -161306)
								{
									if (!flag)
									{
										break;
									}
									if (191519 - 207898 == -16379)
									{
										PlayerData.QuestList = new int[Extensions.get_length(array)];
										if (169808 - 159260 == 10548)
										{
											int j = 0;
											if (50187 - 304041 == -253854)
											{
												while (j < Extensions.get_length(array))
												{
													PlayerData.QuestList[j] = array[j];
													if (259055 - 250572 == 8484)
													{
														goto IL_261;
													}
													j++;
													if (263488 - 165953 == 97536)
													{
														goto IL_261;
													}
												}
												if (271054 - 468706 != -197651)
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

	// Token: 0x06005CDB RID: 23771 RVA: 0x00C149F0 File Offset: 0x00C12BF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void readQuestList(int[] s)
	{
		if (96361 - 574161 != -477799)
		{
		}
		for (;;)
		{
			IL_5C:
			if (Extensions.get_length(s) > 0)
			{
				if (108169 - 515278 == -407108)
				{
					continue;
				}
				PlayerData.QuestID = s[0];
				if (79729 - 246836 != -167107)
				{
					continue;
				}
			}
			if (Extensions.get_length(s) > 1)
			{
				if (97431 - 224221 == -126789)
				{
					continue;
				}
				PlayerData.QuestState = s[1];
				if (38383 - 193942 != -155559)
				{
					continue;
				}
			}
			if (Extensions.get_length(s) > 2)
			{
				if (152626 - 385348 == -232721)
				{
					continue;
				}
				PlayerData.QuestTotal = s[2];
				if (202538 - 458163 == -255624)
				{
					continue;
				}
			}
			if (Extensions.get_length(s) > 3)
			{
				if (147212 - 283321 != -136108)
				{
					int num = 0;
					if (63258 - 412938 != -349679)
					{
						int i = 0;
						if (70100 - 503149 == -433049)
						{
							while (i < Extensions.get_length(s) - 3)
							{
								if (s[i + 3] != 0)
								{
									if (248 - 428639 == -428390)
									{
										goto IL_5C;
									}
									num++;
									if (169199 - 81384 == 87816)
									{
										goto IL_5C;
									}
								}
								i++;
								if (111625 - 522710 != -411085)
								{
									goto IL_5C;
								}
							}
							if (221218 - 536735 != -315516)
							{
								PlayerData.QuestList = new int[num];
								if (167776 - 65848 != 101929)
								{
									int num2 = 0;
									if (104286 - 328528 == -224242)
									{
										int j = 0;
										if (148161 - 475343 != -327181)
										{
											while (j < num)
											{
												if (s[j + 3] != 0)
												{
													if (45995 - 99780 == -53784)
													{
														goto IL_5C;
													}
													PlayerData.QuestList[num2] = s[j + 3];
													if (267260 - 141981 == 125280)
													{
														goto IL_5C;
													}
													num2++;
													if (83444 - 80276 != 3168)
													{
														goto IL_5C;
													}
												}
												j++;
												if (185257 - 294328 != -109071)
												{
													goto IL_5C;
												}
											}
											if (241700 - 528280 != -286579)
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
				PlayerData.QuestList = new int[0];
				if (119903 - 398672 != -278768)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005CDC RID: 23772 RVA: 0x00C14D20 File Offset: 0x00C12F20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void resetAuctionList()
	{
		if (282661 - 557221 != -274559)
		{
		}
		for (;;)
		{
			IL_ED:
			PlayerData.AuctionBuyList = new BidClass[10];
			if (274066 - 438707 != -164640)
			{
				PlayerData.AuctionSellList = new BidClass[10];
				if (111114 - 151564 == -40450)
				{
					int i = 0;
					if (10102 - 519701 == -509599)
					{
						while (i < 10)
						{
							PlayerData.AuctionBuyList[i] = new BidClass();
							if (158386 - 284463 != -126077)
							{
								goto IL_ED;
							}
							PlayerData.AuctionSellList[i] = new BidClass();
							if (198166 - 262294 == -64127)
							{
								goto IL_ED;
							}
							i++;
							if (32305 - 232959 != -200654)
							{
								goto IL_ED;
							}
						}
						if (112067 - 482329 != -370261)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005CDD RID: 23773 RVA: 0x00C14E54 File Offset: 0x00C13054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int countAuctionBuyList()
	{
		if (31006 - 354283 != -323277)
		{
		}
		int num;
		for (;;)
		{
			IL_CC:
			num = 0;
			if (269062 - 192949 == 76113)
			{
				int i = 0;
				if (184990 - 424348 == -239358)
				{
					while (i < Extensions.get_length(PlayerData.AuctionBuyList))
					{
						if (PlayerData.AuctionBuyList[i].aid != 0)
						{
							if (46304 - 240952 == -194647)
							{
								goto IL_CC;
							}
							num++;
							if (25130 - 97312 != -72182)
							{
								goto IL_CC;
							}
						}
						i++;
						if (173800 - 36140 == 137661)
						{
							goto IL_CC;
						}
					}
					if (99173 - 434893 != -335719)
					{
						break;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06005CDE RID: 23774 RVA: 0x00C14F5C File Offset: 0x00C1315C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int countAuctionSellList()
	{
		if (35337 - 217177 != -181840)
		{
		}
		int num;
		for (;;)
		{
			IL_90:
			num = 0;
			if (208066 - 344661 == -136595)
			{
				int i = 0;
				if (127498 - 437824 == -310326)
				{
					while (i < Extensions.get_length(PlayerData.AuctionSellList))
					{
						if (PlayerData.AuctionSellList[i].aid != 0)
						{
							if (265965 - 553333 == -287367)
							{
								goto IL_90;
							}
							num++;
							if (826 - 162981 == -162154)
							{
								goto IL_90;
							}
						}
						i++;
						if (46824 - 312169 == -265344)
						{
							goto IL_90;
						}
					}
					if (219378 - 125020 == 94358)
					{
						break;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06005CDF RID: 23775 RVA: 0x00C15064 File Offset: 0x00C13264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool addAuctionBuyList(int nID, int nBid)
	{
		if (74810 - 454978 != -380168)
		{
		}
		for (;;)
		{
			IL_BF:
			int i = 0;
			if (236708 - 156021 != 80688)
			{
				while (i < Extensions.get_length(PlayerData.AuctionBuyList))
				{
					if (PlayerData.AuctionBuyList[i].aid == 0)
					{
						if (82771 - 227520 == -144748)
						{
							goto IL_BF;
						}
						PlayerData.AuctionBuyList[i].aid = nID;
						if (17787 - 159586 != -141799)
						{
							goto IL_BF;
						}
						PlayerData.AuctionBuyList[i].bid = nBid;
						if (23578 - 273889 != -250311)
						{
							goto IL_BF;
						}
						goto IL_1A;
					}
					else
					{
						i++;
						if (127536 - 336126 != -208590)
						{
							goto IL_BF;
						}
					}
				}
				if (242495 - 12646 != 229850)
				{
					goto Block_7;
				}
			}
		}
		IL_1A:
		return true;
		Block_7:
		return false;
	}

	// Token: 0x06005CE0 RID: 23776 RVA: 0x00C15188 File Offset: 0x00C13388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool addAuctionSellList(int nID, int nBid)
	{
		if (104367 - 486475 != -382107)
		{
		}
		for (;;)
		{
			IL_9B:
			int i = 0;
			if (219078 - 358227 != -139148)
			{
				while (i < Extensions.get_length(PlayerData.AuctionSellList))
				{
					if (PlayerData.AuctionSellList[i].aid == 0)
					{
						if (182500 - 419156 != -236656)
						{
							goto IL_9B;
						}
						PlayerData.AuctionSellList[i].aid = nID;
						if (95118 - 49236 != 45882)
						{
							goto IL_9B;
						}
						PlayerData.AuctionSellList[i].bid = nBid;
						if (136954 - 270965 != -134010)
						{
							goto Block_8;
						}
						goto IL_9B;
					}
					else
					{
						i++;
						if (68608 - 449554 == -380945)
						{
							goto IL_9B;
						}
					}
				}
				if (211420 - 492410 != -280989)
				{
					break;
				}
			}
		}
		return false;
		Block_8:
		return true;
	}

	// Token: 0x06005CE1 RID: 23777 RVA: 0x00C152AC File Offset: 0x00C134AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool removeAuctionBuyList(int nID)
	{
		if (76553 - 403520 != -326966)
		{
		}
		for (;;)
		{
			IL_68:
			int i = 0;
			if (262110 - 13437 != 248674)
			{
				while (i < Extensions.get_length(PlayerData.AuctionBuyList))
				{
					if (PlayerData.AuctionBuyList[i].aid == nID)
					{
						if (183228 - 50284 != 132944)
						{
							goto IL_68;
						}
						PlayerData.AuctionBuyList[i].aid = 0;
						if (163412 - 451960 != -288548)
						{
							goto IL_68;
						}
						PlayerData.AuctionBuyList[i].bid = 0;
						if (219310 - 449879 != -230568)
						{
							goto Block_6;
						}
						goto IL_68;
					}
					else
					{
						i++;
						if (190375 - 114134 != 76241)
						{
							goto IL_68;
						}
					}
				}
				if (158618 - 313403 != -154784)
				{
					break;
				}
			}
		}
		return false;
		Block_6:
		return true;
	}

	// Token: 0x06005CE2 RID: 23778 RVA: 0x00C153D0 File Offset: 0x00C135D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool removeAuctionSellList(int nID)
	{
		if (51148 - 395078 != -343929)
		{
		}
		for (;;)
		{
			IL_8F:
			int i = 0;
			if (125460 - 257132 == -131672)
			{
				while (i < Extensions.get_length(PlayerData.AuctionSellList))
				{
					if (PlayerData.AuctionSellList[i].aid == nID)
					{
						if (109136 - 181238 == -72101)
						{
							goto IL_8F;
						}
						PlayerData.AuctionSellList[i].aid = 0;
						if (175951 - 456259 != -280308)
						{
							goto IL_8F;
						}
						PlayerData.AuctionSellList[i].bid = 0;
						if (60136 - 328179 != -268042)
						{
							goto Block_7;
						}
						goto IL_8F;
					}
					else
					{
						i++;
						if (259545 - 245691 == 13855)
						{
							goto IL_8F;
						}
					}
				}
				if (251423 - 521502 == -270079)
				{
					goto IL_103;
				}
			}
		}
		Block_7:
		return true;
		IL_103:
		return false;
	}

	// Token: 0x06005CE3 RID: 23779 RVA: 0x00C154F4 File Offset: 0x00C136F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void readAuctionList(string s)
	{
		if (47073 - 295248 != -248175)
		{
		}
		for (;;)
		{
			IL_20A:
			PlayerData.resetAuctionList();
			if (261528 - 404086 != -142557)
			{
				if (s == "0")
				{
					if (199271 - 100510 != 98762)
					{
						break;
					}
				}
				else
				{
					string[] array = (string[])Stringf.splitToArray(s, "@").ToBuiltin(typeof(string));
					if (231559 - 122112 == 109447)
					{
						if (Extensions.get_length(array) != 2)
						{
							break;
						}
						if (284737 - 563965 != -279227)
						{
							string[] array2 = (string[])Stringf.splitToArray(array[0], ",").ToBuiltin(typeof(string));
							if (184272 - 378870 != -194597)
							{
								int i = 0;
								if (215133 - 520052 != -304918)
								{
									while (i < Extensions.get_length(array2))
									{
										string[] array3 = (string[])Stringf.splitToArray(array2[i], "%").ToBuiltin(typeof(string));
										if (118242 - 278447 == -160204)
										{
											goto IL_20A;
										}
										if (Extensions.get_length(array3) == 2)
										{
											if (22896 - 155276 != -132380)
											{
												goto IL_20A;
											}
											if (i < 10)
											{
												if (31481 - 166207 == -134725)
												{
													goto IL_20A;
												}
												PlayerData.AuctionBuyList[i].aid = Stringf.getInteger(array3[0]);
												if (98608 - 390891 == -292282)
												{
													goto IL_20A;
												}
												PlayerData.AuctionBuyList[i].bid = Stringf.getInteger(array3[1]);
												if (245221 - 408219 != -162998)
												{
													goto IL_20A;
												}
											}
										}
										i++;
										if (129804 - 424993 == -295188)
										{
											goto IL_20A;
										}
									}
									if (230856 - 325502 != -94645)
									{
										string[] array4 = (string[])Stringf.splitToArray(array[1], ",").ToBuiltin(typeof(string));
										if (265535 - 516309 == -250774)
										{
											int j = 0;
											if (243853 - 325762 != -81908)
											{
												while (j < Extensions.get_length(array4))
												{
													string[] array5 = (string[])Stringf.splitToArray(array4[j], "%").ToBuiltin(typeof(string));
													if (71431 - 210815 == -139383)
													{
														goto IL_20A;
													}
													if (Extensions.get_length(array5) == 2)
													{
														if (169206 - 36099 == 133108)
														{
															goto IL_20A;
														}
														if (j < 10)
														{
															if (239540 - 151776 != 87764)
															{
																goto IL_20A;
															}
															PlayerData.AuctionSellList[j].aid = Stringf.getInteger(array5[0]);
															if (197888 - 75295 == 122594)
															{
																goto IL_20A;
															}
															PlayerData.AuctionSellList[j].bid = Stringf.getInteger(array5[1]);
															if (156732 - 465102 == -308369)
															{
																goto IL_20A;
															}
														}
													}
													j++;
													if (86209 - 131461 != -45252)
													{
														goto IL_20A;
													}
												}
												if (148827 - 420307 != -271479)
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

	// Token: 0x06005CE4 RID: 23780 RVA: 0x00C158EC File Offset: 0x00C13AEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void resetRecipeList()
	{
		if (161860 - 70987 != 90874)
		{
		}
		for (;;)
		{
			if (PlayerData.RecipeList == null)
			{
				if (7313 - 289852 == -282539)
				{
					PlayerData.RecipeList = new UnityScript.Lang.Array();
					if (151972 - 250515 != -98542)
					{
						break;
					}
				}
			}
			else
			{
				PlayerData.RecipeList.Clear();
				if (128671 - 348326 != -219654)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005CE5 RID: 23781 RVA: 0x00C15998 File Offset: 0x00C13B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void readRecipeList(int[] s)
	{
		if (232137 - 205857 != 26280)
		{
		}
		for (;;)
		{
			if (Extensions.get_length(s) == 0)
			{
				if (255931 - 389740 == -133809)
				{
					if (PlayerData.RecipeList == null)
					{
						if (234507 - 136908 != 97600)
						{
							PlayerData.RecipeList = new UnityScript.Lang.Array();
							if (64953 - 53925 == 11028)
							{
								break;
							}
						}
					}
					else
					{
						PlayerData.RecipeList.Clear();
						if (47180 - 280854 != -233673)
						{
							break;
						}
					}
				}
			}
			else
			{
				PlayerData.RecipeList = new UnityScript.Lang.Array(s);
				if (203875 - 342249 != -138373)
				{
					PlayerData.RecipeList.Sort();
					if (117493 - 7033 != 110461)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005CE6 RID: 23782 RVA: 0x00C15AB8 File Offset: 0x00C13CB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool hasRecipe(int nRecipe)
	{
		if (92324 - 48747 != 43578)
		{
		}
		for (;;)
		{
			IL_45:
			if (PlayerData.RecipeList == null)
			{
				if (119398 - 262089 != -142690)
				{
					break;
				}
			}
			else
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.RecipeList);
				if (131907 - 29765 != 102143)
				{
					while (enumerator.MoveNext())
					{
						object value = enumerator.Current;
						int num = RuntimeServices.UnboxInt32(value);
						if (196971 - 384526 != -187555)
						{
							goto IL_45;
						}
						if (nRecipe == num)
						{
							if (95482 - 187598 != -92115)
							{
								goto Block_8;
							}
							goto IL_45;
						}
					}
					if (44177 - 392484 != -348306)
					{
						goto Block_6;
					}
				}
			}
		}
		return false;
		Block_6:
		return false;
		Block_8:
		return true;
	}

	// Token: 0x06005CE7 RID: 23783 RVA: 0x00C15BB8 File Offset: 0x00C13DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeRecipe(int nRecipe)
	{
		if (PlayerData.RecipeList != null)
		{
			PlayerData.RecipeList.Remove(nRecipe);
		}
	}

	// Token: 0x06005CE8 RID: 23784 RVA: 0x00C15BDC File Offset: 0x00C13DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void resetCardList()
	{
		if (249969 - 123638 != 126332)
		{
		}
		for (;;)
		{
			if (PlayerData.CardList == null)
			{
				if (154419 - 80291 == 74128)
				{
					PlayerData.CardList = new UnityScript.Lang.Array();
					if (40223 - 326144 != -285920)
					{
						break;
					}
				}
			}
			else
			{
				PlayerData.CardList.Clear();
				if (4418 - 427410 == -422992)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005CE9 RID: 23785 RVA: 0x00C15C88 File Offset: 0x00C13E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void readCardList(int[] s)
	{
		if (211243 - 205904 != 5340)
		{
		}
		for (;;)
		{
			if (Extensions.get_length(s) == 0)
			{
				if (98721 - 580583 != -481861)
				{
					if (PlayerData.CardList == null)
					{
						if (240826 - 246854 != -6027)
						{
							PlayerData.CardList = new UnityScript.Lang.Array();
							if (16177 - 474964 != -458786)
							{
								break;
							}
						}
					}
					else
					{
						PlayerData.CardList.Clear();
						if (117810 - 56950 != 60861)
						{
							break;
						}
					}
				}
			}
			else
			{
				PlayerData.CardList = new UnityScript.Lang.Array(s);
				if (52563 - 22188 == 30375)
				{
					PlayerData.CardList.Sort();
					if (100990 - 411766 != -310775)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005CEA RID: 23786 RVA: 0x00C15DA8 File Offset: 0x00C13FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool hasCard(int nCard)
	{
		if (8026 - 595661 != -587634)
		{
		}
		for (;;)
		{
			IL_45:
			if (PlayerData.CardList == null)
			{
				if (277749 - 77684 != 200066)
				{
					break;
				}
			}
			else
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.CardList);
				if (49877 - 524489 == -474612)
				{
					while (enumerator.MoveNext())
					{
						object value = enumerator.Current;
						int num = RuntimeServices.UnboxInt32(value);
						if (63546 - 232445 != -168899)
						{
							goto IL_45;
						}
						if (nCard == num)
						{
							if (167664 - 280799 != -113135)
							{
								goto IL_45;
							}
							goto IL_69;
						}
					}
					if (46912 - 115141 != -68228)
					{
						goto Block_5;
					}
				}
			}
		}
		return false;
		IL_69:
		return true;
		Block_5:
		return false;
	}

	// Token: 0x06005CEB RID: 23787 RVA: 0x00C15EA8 File Offset: 0x00C140A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void resetSpecialList()
	{
		if (29204 - 317564 != -288359)
		{
		}
		for (;;)
		{
			PlayerData.SaveGuild = 0;
			if (266992 - 386686 == -119694)
			{
				PlayerData.InventoryKey = 0;
				if (62547 - 291632 == -229085)
				{
					PlayerData.SongUnlock = 0;
					if (293773 - 121369 != 172405)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005CEC RID: 23788 RVA: 0x00C15F40 File Offset: 0x00C14140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void readSpecialList(int[] s)
	{
		if (21778 - 581611 != -559833)
		{
		}
		for (;;)
		{
			if (Extensions.get_length(s) > 0)
			{
				if (3457 - 441896 != -438439)
				{
					continue;
				}
				PlayerData.SaveGuild = s[0];
				if (88183 - 492404 == -404220)
				{
					continue;
				}
			}
			if (Extensions.get_length(s) > 1)
			{
				if (226959 - 272466 == -45506)
				{
					continue;
				}
				PlayerData.InventoryKey = s[1];
				if (246425 - 267969 == -21543)
				{
					continue;
				}
			}
			if (Extensions.get_length(s) <= 2)
			{
				break;
			}
			if (179060 - 21373 != 157688)
			{
				PlayerData.SongUnlock = s[2];
				if (140230 - 331006 == -190776)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005CED RID: 23789 RVA: 0x00C16050 File Offset: 0x00C14250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadHashTable(Hashtable data)
	{
		if (268541 - 104990 != 163552)
		{
		}
		for (;;)
		{
			PlayerData.resetItemList();
			if (66725 - 532849 != -466123)
			{
				PlayerData.resetBuddyList();
				if (261326 - 237656 == 23670)
				{
					PlayerData.resetMissionList();
					if (135756 - 188292 != -52535)
					{
						PlayerData.resetQuestList();
						if (183583 - 101368 != 82216)
						{
							PlayerData.resetRecipeList();
							if (208902 - 257383 == -48481)
							{
								PlayerData.resetAuctionList();
								if (10004 - 377821 != -367816)
								{
									PlayerData.resetCardList();
									if (279247 - 401787 != -122539)
									{
										PlayerData.resetSpecialList();
										if (275061 - 190770 == 84291)
										{
											if (!RuntimeServices.EqualityOperator(data[43], null))
											{
												if (147064 - 202069 != -55005)
												{
													continue;
												}
												PlayerData.UID = RuntimeServices.UnboxInt32(data[43]);
												if (98060 - 514662 == -416601)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[44], null))
											{
												if (61518 - 23694 == 37825)
												{
													continue;
												}
												PlayerData.PID = RuntimeServices.UnboxInt32(data[44]);
												if (165344 - 185705 == -20360)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[45], null))
											{
												if (139221 - 162886 != -23665)
												{
													continue;
												}
												object obj2;
												object obj = obj2 = data[45];
												if (!(obj is string))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(string));
												}
												PlayerData.User = (string)obj2;
												if (260705 - 457107 != -196402)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[46], null))
											{
												if (190357 - 444140 == -253782)
												{
													continue;
												}
												PlayerData.SLv = RuntimeServices.UnboxInt32(data[46]);
												if (44013 - 13182 == 30832)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[47], null))
											{
												if (71070 - 259791 == -188720)
												{
													continue;
												}
												PlayerData.GID = RuntimeServices.UnboxInt32(data[47]);
												if (289109 - 529477 != -240368)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[48], null))
											{
												if (97042 - 6355 == 90688)
												{
													continue;
												}
												PlayerData.Gil = RuntimeServices.UnboxInt32(data[48]);
												if (95439 - 288168 != -192729)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[49], null))
											{
												if (104687 - 303463 != -198776)
												{
													continue;
												}
												PlayerData.Jil = RuntimeServices.UnboxInt32(data[49]);
												if (33021 - 562497 == -529475)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[50], null))
											{
												if (126202 - 60736 != 65466)
												{
													continue;
												}
												PlayerData.QuestID = RuntimeServices.UnboxInt32(data[50]);
												if (276447 - 28034 == 248414)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[51], null))
											{
												if (93758 - 332806 == -239047)
												{
													continue;
												}
												PlayerData.QuestState = RuntimeServices.UnboxInt32(data[51]);
												if (277357 - 414957 == -137599)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[52], null))
											{
												if (25411 - 348456 != -323045)
												{
													continue;
												}
												PlayerData.Rank = RuntimeServices.UnboxInt32(data[52]);
												if (112350 - 112897 == -546)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[53], null))
											{
												if (268512 - 150156 != 118356)
												{
													continue;
												}
												PlayerData.RP = RuntimeServices.UnboxInt32(data[53]);
												if (223941 - 192058 == 31884)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[54], null))
											{
												if (257575 - 375940 != -118365)
												{
													continue;
												}
												PlayerData.ARP = RuntimeServices.UnboxInt32(data[54]);
												if (186836 - 84475 == 102362)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[52], null))
											{
												if (250415 - 119592 != 130823)
												{
													continue;
												}
												PlayerData.Rank = RuntimeServices.UnboxInt32(data[52]);
												if (39806 - 325816 == -286009)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[55], null))
											{
												if (175953 - 22898 != 153055)
												{
													continue;
												}
												object obj4;
												object obj3 = obj4 = data[55];
												if (!(obj3 is string))
												{
													obj4 = RuntimeServices.Coerce(obj3, typeof(string));
												}
												PlayerData.readItemList((string)obj4);
												if (197458 - 43375 != 154083)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[56], null))
											{
												if (113870 - 122239 == -8368)
												{
													continue;
												}
												object obj6;
												object obj5 = obj6 = data[56];
												if (!(obj5 is string))
												{
													obj6 = RuntimeServices.Coerce(obj5, typeof(string));
												}
												PlayerData.readBuddyList((string)obj6);
												if (145853 - 164428 == -18574)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[57], null))
											{
												if (163368 - 164557 == -1188)
												{
													continue;
												}
												object obj8;
												object obj7 = obj8 = data[57];
												if (!(obj7 is int[]))
												{
													obj8 = RuntimeServices.Coerce(obj7, typeof(int[]));
												}
												PlayerData.readMissionList((int[])obj8);
												if (47482 - 528251 == -480768)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[58], null))
											{
												if (12083 - 18329 == -6245)
												{
													continue;
												}
												object obj10;
												object obj9 = obj10 = data[58];
												if (!(obj9 is int[]))
												{
													obj10 = RuntimeServices.Coerce(obj9, typeof(int[]));
												}
												PlayerData.readQuestList((int[])obj10);
												if (86358 - 148448 != -62090)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[62], null))
											{
												if (113021 - 380879 != -267858)
												{
													continue;
												}
												object obj12;
												object obj11 = obj12 = data[62];
												if (!(obj11 is string))
												{
													obj12 = RuntimeServices.Coerce(obj11, typeof(string));
												}
												PlayerData.readAuctionList((string)obj12);
												if (19149 - 596323 == -577173)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[63], null))
											{
												if (64747 - 368309 == -303561)
												{
													continue;
												}
												object obj14;
												object obj13 = obj14 = data[63];
												if (!(obj13 is int[]))
												{
													obj14 = RuntimeServices.Coerce(obj13, typeof(int[]));
												}
												PlayerData.readRecipeList((int[])obj14);
												if (205971 - 360986 == -155014)
												{
													continue;
												}
											}
											if (!RuntimeServices.EqualityOperator(data[64], null))
											{
												if (237439 - 294204 == -56764)
												{
													continue;
												}
												object obj16;
												object obj15 = obj16 = data[64];
												if (!(obj15 is int[]))
												{
													obj16 = RuntimeServices.Coerce(obj15, typeof(int[]));
												}
												PlayerData.readCardList((int[])obj16);
												if (90943 - 248454 != -157511)
												{
													continue;
												}
											}
											if (RuntimeServices.EqualityOperator(data[66], null))
											{
												break;
											}
											if (6424 - 372844 != -366419)
											{
												object obj18;
												object obj17 = obj18 = data[66];
												if (!(obj17 is int[]))
												{
													obj18 = RuntimeServices.Coerce(obj17, typeof(int[]));
												}
												PlayerData.readSpecialList((int[])obj18);
												if (188298 - 281955 == -93657)
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

	// Token: 0x06005CEE RID: 23790 RVA: 0x00C16A8C File Offset: 0x00C14C8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateData(Hashtable data)
	{
		if (38714 - 184075 != -145361)
		{
		}
		for (;;)
		{
			if (!RuntimeServices.EqualityOperator(data[43], null))
			{
				if (103850 - 121010 != -17160)
				{
					continue;
				}
				PlayerData.UID = RuntimeServices.UnboxInt32(data[43]);
				if (263751 - 181343 == 82409)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[44], null))
			{
				if (159869 - 533122 == -373252)
				{
					continue;
				}
				PlayerData.PID = RuntimeServices.UnboxInt32(data[44]);
				if (217254 - 189696 == 27559)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[45], null))
			{
				if (298658 - 240791 == 57868)
				{
					continue;
				}
				object obj2;
				object obj = obj2 = data[45];
				if (!(obj is string))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(string));
				}
				PlayerData.User = (string)obj2;
				if (132199 - 206428 == -74228)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[46], null))
			{
				if (298115 - 571155 != -273040)
				{
					continue;
				}
				PlayerData.SLv = RuntimeServices.UnboxInt32(data[46]);
				if (66028 - 534735 == -468706)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[47], null))
			{
				if (196164 - 224575 != -28411)
				{
					continue;
				}
				PlayerData.GID = RuntimeServices.UnboxInt32(data[47]);
				if (116962 - 532283 != -415321)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[48], null))
			{
				if (93841 - 160276 == -66434)
				{
					continue;
				}
				PlayerData.Gil = RuntimeServices.UnboxInt32(data[48]);
				if (185487 - 260014 == -74526)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[49], null))
			{
				if (161517 - 197620 == -36102)
				{
					continue;
				}
				PlayerData.Jil = RuntimeServices.UnboxInt32(data[49]);
				if (114707 - 170994 != -56287)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[50], null))
			{
				if (227378 - 419465 != -192087)
				{
					continue;
				}
				PlayerData.QuestID = RuntimeServices.UnboxInt32(data[50]);
				if (230413 - 142061 == 88353)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[51], null))
			{
				if (238848 - 588449 == -349600)
				{
					continue;
				}
				PlayerData.QuestState = RuntimeServices.UnboxInt32(data[51]);
				if (210886 - 568215 == -357328)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[52], null))
			{
				if (94694 - 162021 != -67327)
				{
					continue;
				}
				PlayerData.Rank = RuntimeServices.UnboxInt32(data[52]);
				if (244340 - 566502 == -322161)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[53], null))
			{
				if (181072 - 156396 != 24676)
				{
					continue;
				}
				PlayerData.RP = RuntimeServices.UnboxInt32(data[53]);
				if (217975 - 149299 == 68677)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[54], null))
			{
				if (31088 - 400321 != -369233)
				{
					continue;
				}
				PlayerData.ARP = RuntimeServices.UnboxInt32(data[54]);
				if (79627 - 232480 == -152852)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[55], null))
			{
				if (107272 - 334795 != -227523)
				{
					continue;
				}
				object obj4;
				object obj3 = obj4 = data[55];
				if (!(obj3 is string))
				{
					obj4 = RuntimeServices.Coerce(obj3, typeof(string));
				}
				PlayerData.readItemList((string)obj4);
				if (220084 - 416077 == -195992)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[56], null))
			{
				if (178594 - 187996 != -9402)
				{
					continue;
				}
				object obj6;
				object obj5 = obj6 = data[56];
				if (!(obj5 is string))
				{
					obj6 = RuntimeServices.Coerce(obj5, typeof(string));
				}
				PlayerData.readBuddyList((string)obj6);
				if (59837 - 370681 != -310844)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[57], null))
			{
				if (231879 - 323960 == -92080)
				{
					continue;
				}
				object obj8;
				object obj7 = obj8 = data[57];
				if (!(obj7 is int[]))
				{
					obj8 = RuntimeServices.Coerce(obj7, typeof(int[]));
				}
				PlayerData.readMissionList((int[])obj8);
				if (161259 - 440072 == -278812)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[58], null))
			{
				if (246097 - 314237 != -68140)
				{
					continue;
				}
				object obj10;
				object obj9 = obj10 = data[58];
				if (!(obj9 is int[]))
				{
					obj10 = RuntimeServices.Coerce(obj9, typeof(int[]));
				}
				PlayerData.readQuestList((int[])obj10);
				if (290667 - 104369 == 186299)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[63], null))
			{
				if (132374 - 452732 == -320357)
				{
					continue;
				}
				object obj12;
				object obj11 = obj12 = data[63];
				if (!(obj11 is int[]))
				{
					obj12 = RuntimeServices.Coerce(obj11, typeof(int[]));
				}
				PlayerData.readRecipeList((int[])obj12);
				if (207876 - 255021 != -47145)
				{
					continue;
				}
			}
			if (RuntimeServices.EqualityOperator(data[62], null))
			{
				break;
			}
			if (29379 - 421221 == -391842)
			{
				object obj14;
				object obj13 = obj14 = data[62];
				if (!(obj13 is string))
				{
					obj14 = RuntimeServices.Coerce(obj13, typeof(string));
				}
				PlayerData.readAuctionList((string)obj14);
				if (253604 - 185933 == 67671)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005CEF RID: 23791 RVA: 0x00C17270 File Offset: 0x00C15470
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005CF0 RID: 23792 RVA: 0x00C17274 File Offset: 0x00C15474
	internal static bool MNsSJOpYjE2U8nG6QcII()
	{
		return true;
	}

	// Token: 0x06005CF1 RID: 23793 RVA: 0x00C17278 File Offset: 0x00C15478
	internal static bool ulQ7gmpYhWIns8PdMLls()
	{
		return false;
	}

	// Token: 0x0400679D RID: 26525
	[NonSerialized]
	public static int UID;

	// Token: 0x0400679E RID: 26526
	[NonSerialized]
	public static int PID;

	// Token: 0x0400679F RID: 26527
	[NonSerialized]
	public static int GID;

	// Token: 0x040067A0 RID: 26528
	[NonSerialized]
	public static string User;

	// Token: 0x040067A1 RID: 26529
	[NonSerialized]
	public static int SLv;

	// Token: 0x040067A2 RID: 26530
	[NonSerialized]
	public static int Gil;

	// Token: 0x040067A3 RID: 26531
	[NonSerialized]
	public static int Jil;

	// Token: 0x040067A4 RID: 26532
	[NonSerialized]
	public static int Rank;

	// Token: 0x040067A5 RID: 26533
	[NonSerialized]
	public static int RP;

	// Token: 0x040067A6 RID: 26534
	[NonSerialized]
	public static int ARP;

	// Token: 0x040067A7 RID: 26535
	[NonSerialized]
	public static InventoryClass[] ItemList;

	// Token: 0x040067A8 RID: 26536
	[NonSerialized]
	public static UnityScript.Lang.Array BuddyList;

	// Token: 0x040067A9 RID: 26537
	[NonSerialized]
	public static int[] MissionList;

	// Token: 0x040067AA RID: 26538
	[NonSerialized]
	public static int[] MissionWin;

	// Token: 0x040067AB RID: 26539
	[NonSerialized]
	public static int[] MissionLose;

	// Token: 0x040067AC RID: 26540
	[NonSerialized]
	public static int[] MissionWithdraw;

	// Token: 0x040067AD RID: 26541
	[NonSerialized]
	public static int[] QuestList;

	// Token: 0x040067AE RID: 26542
	[NonSerialized]
	public static UnityScript.Lang.Array MailList;

	// Token: 0x040067AF RID: 26543
	[NonSerialized]
	public static BidClass[] AuctionBuyList;

	// Token: 0x040067B0 RID: 26544
	[NonSerialized]
	public static BidClass[] AuctionSellList;

	// Token: 0x040067B1 RID: 26545
	[NonSerialized]
	public static UnityScript.Lang.Array RecipeList;

	// Token: 0x040067B2 RID: 26546
	[NonSerialized]
	public static UnityScript.Lang.Array CardList;

	// Token: 0x040067B3 RID: 26547
	[NonSerialized]
	public static int QuestID;

	// Token: 0x040067B4 RID: 26548
	[NonSerialized]
	public static int QuestState;

	// Token: 0x040067B5 RID: 26549
	[NonSerialized]
	public static int QuestTotal;

	// Token: 0x040067B6 RID: 26550
	[NonSerialized]
	public static int QuestHighest;

	// Token: 0x040067B7 RID: 26551
	[NonSerialized]
	public static int SaveGuild;

	// Token: 0x040067B8 RID: 26552
	[NonSerialized]
	public static int InventoryKey;

	// Token: 0x040067B9 RID: 26553
	[NonSerialized]
	public static int SongUnlock;

	// Token: 0x040067BA RID: 26554
	[NonSerialized]
	public static int buddyCount;

	// Token: 0x040067BB RID: 26555
	[NonSerialized]
	public static int buddyOnline;
}
