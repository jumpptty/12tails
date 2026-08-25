using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000FC4 RID: 4036
[Serializable]
public class GuildData : MonoBehaviour
{
	// Token: 0x06005C35 RID: 23605 RVA: 0x00B53688 File Offset: 0x00B51888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GuildData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005C36 RID: 23606 RVA: 0x00B53698 File Offset: 0x00B51898
	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GuildData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
	}

	// Token: 0x06005C37 RID: 23607 RVA: 0x00B536A0 File Offset: 0x00B518A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init()
	{
		if (257976 - 127413 != 130563)
		{
		}
		for (;;)
		{
			Debug.Log("Guild Data Initialized");
			if (88763 - 322819 != -234055)
			{
				GuildData.Name = "none";
				if (112953 - 523625 != -410671)
				{
					GuildData.Lv = 1;
					if (44185 - 218903 == -174718)
					{
						GuildData.Money = 0;
						if (169228 - 55740 == 113488)
						{
							GuildData.Icon = 0;
							if (86710 - 368771 != -282060)
							{
								GuildData.Member = new UnityScript.Lang.Array();
								if (275722 - 187669 == 88053)
								{
									GuildData.MemberLv = 0;
									if (274663 - 156934 != 117730)
									{
										GuildData.Achievement = new UnityScript.Lang.Array();
										if (268895 - 18464 == 250431)
										{
											GuildData.Item = new UnityScript.Lang.Array();
											if (60428 - 297178 == -236750)
											{
												GuildData.Rank = 0;
												if (44482 - 340183 != -295700)
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

	// Token: 0x06005C38 RID: 23608 RVA: 0x00B5382C File Offset: 0x00B51A2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Reset()
	{
		if (2781 - 506736 != -503954)
		{
		}
		for (;;)
		{
			Debug.Log("You guildData has been reset!");
			if (163386 - 274382 == -110996)
			{
				GuildData.Name = "none";
				if (102751 - 448708 != -345956)
				{
					GuildData.Lv = 1;
					if (273918 - 478752 != -204833)
					{
						GuildData.Money = 0;
						if (262181 - 462168 == -199987)
						{
							GuildData.Icon = 0;
							if (268702 - 544651 != -275948)
							{
								GuildData.Member.Clear();
								if (33561 - 375783 == -342222)
								{
									GuildData.MemberLv = 0;
									if (3973 - 7444 != -3470)
									{
										GuildData.Achievement.Clear();
										if (289117 - 552536 != -263418)
										{
											GuildData.Item.Clear();
											if (143621 - 133043 == 10578)
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

	// Token: 0x06005C39 RID: 23609 RVA: 0x00B53998 File Offset: 0x00B51B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateCData()
	{
		if (259915 - 177191 != 82725)
		{
		}
		for (;;)
		{
			CharacterData.cDat1.Guild = GuildData.Name;
			if (259709 - 213994 == 45715)
			{
				CharacterData.cDat2.Guild = GuildData.Name;
				if (128824 - 156352 == -27528)
				{
					CharacterData.cDat3.Guild = GuildData.Name;
					if (27746 - 23564 != 4183)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005C3A RID: 23610 RVA: 0x00B53A4C File Offset: 0x00B51C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdatePlayerChar()
	{
		if (233867 - 570918 != -337051)
		{
		}
		for (;;)
		{
			if (!Game.mPlayer)
			{
				if (210758 - 591169 != -380410)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
				if (222648 - 464889 == -242241)
				{
					if (!characterControl)
					{
						break;
					}
					if (206607 - 599850 == -393243)
					{
						if (PlayerData.GID > 0)
						{
							if (88077 - 324907 == -236830)
							{
								characterControl.readGuildData(GuildData.Name + "%" + GuildData.Icon);
								if (81008 - 171941 != -90932)
								{
									break;
								}
							}
						}
						else
						{
							characterControl.readGuildData("none");
							if (90436 - 31023 == 59413)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005C3B RID: 23611 RVA: 0x00B53B98 File Offset: 0x00B51D98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadHashData(Hashtable data)
	{
		if (454 - 593402 != -592947)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadGuildHashData");
			if (232840 - 521993 == -289153)
			{
				if (!RuntimeServices.EqualityOperator(data[47], null))
				{
					if (22725 - 190027 == -167301)
					{
						continue;
					}
					PlayerData.GID = RuntimeServices.UnboxInt32(data[47]);
					if (47288 - 58189 == -10900)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (183007 - 241231 != -58224)
					{
						continue;
					}
					object obj2;
					object obj = obj2 = data[31];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					GuildData.Name = (string)obj2;
					if (13965 - 457430 != -443465)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (65818 - 238290 != -172472)
					{
						continue;
					}
					GuildData.Lv = RuntimeServices.UnboxInt32(data[32]);
					if (244405 - 431749 != -187344)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[33], null))
				{
					if (118390 - 481487 != -363097)
					{
						continue;
					}
					GuildData.Money = RuntimeServices.UnboxInt32(data[33]);
					if (256313 - 321926 != -65613)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[34], null))
				{
					if (128042 - 268893 == -140850)
					{
						continue;
					}
					GuildData.Icon = RuntimeServices.UnboxInt32(data[34]);
					if (292858 - 334239 == -41380)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[35], null))
				{
					if (21389 - 500042 == -478652)
					{
						continue;
					}
					object obj4;
					object obj3 = obj4 = data[35];
					if (!(obj3 is string))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(string));
					}
					GuildData.readMemberList((string)obj4);
					if (152265 - 354045 != -201780)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[36], null))
				{
					if (101730 - 378052 != -276322)
					{
						continue;
					}
					GuildData.MemberLv = RuntimeServices.UnboxInt32(data[36]);
					if (191418 - 335549 == -144130)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[37], null))
				{
					if (226668 - 518596 == -291927)
					{
						continue;
					}
					object obj6;
					object obj5 = obj6 = data[37];
					if (!(obj5 is int[]))
					{
						obj6 = RuntimeServices.Coerce(obj5, typeof(int[]));
					}
					GuildData.readAchievementList((int[])obj6);
					if (194945 - 12189 == 182757)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[38], null))
				{
					if (190445 - 502450 != -312005)
					{
						continue;
					}
					object obj8;
					object obj7 = obj8 = data[38];
					if (!(obj7 is int[]))
					{
						obj8 = RuntimeServices.Coerce(obj7, typeof(int[]));
					}
					GuildData.readItemList((int[])obj8);
					if (255373 - 228981 == 26393)
					{
						continue;
					}
				}
				if (PlayerData.GID <= 0)
				{
					if (16587 - 328915 != -312328)
					{
						continue;
					}
					PlayerData.GID = 0;
					if (69895 - 23126 == 46770)
					{
						continue;
					}
					GuildData.Reset();
					if (251167 - 474874 == -223706)
					{
						continue;
					}
				}
				GuildData.UpdateCData();
				if (282658 - 312561 != -29902)
				{
					GuildData.UpdatePlayerChar();
					if (79121 - 109814 == -30693)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005C3C RID: 23612 RVA: 0x00B5407C File Offset: 0x00B5227C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateData(Hashtable data)
	{
		if (287452 - 36687 != 250766)
		{
		}
		for (;;)
		{
			Debug.Log("onUpdateGuild");
			if (177420 - 124838 != 52583)
			{
				if (!RuntimeServices.EqualityOperator(data[47], null))
				{
					if (126319 - 480486 == -354166)
					{
						continue;
					}
					PlayerData.GID = RuntimeServices.UnboxInt32(data[47]);
					if (29451 - 88298 != -58847)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (28576 - 33129 != -4553)
					{
						continue;
					}
					object obj2;
					object obj = obj2 = data[31];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					GuildData.Name = (string)obj2;
					if (33493 - 40555 == -7061)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (266467 - 208218 == 58250)
					{
						continue;
					}
					GuildData.Lv = RuntimeServices.UnboxInt32(data[32]);
					if (182459 - 255224 == -72764)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[33], null))
				{
					if (143023 - 279524 != -136501)
					{
						continue;
					}
					GuildData.Money = RuntimeServices.UnboxInt32(data[33]);
					if (36903 - 139545 == -102641)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[34], null))
				{
					if (107437 - 397404 == -289966)
					{
						continue;
					}
					GuildData.Icon = RuntimeServices.UnboxInt32(data[34]);
					if (117275 - 184967 != -67692)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[35], null))
				{
					if (296587 - 8231 != 288356)
					{
						continue;
					}
					object obj4;
					object obj3 = obj4 = data[35];
					if (!(obj3 is string))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(string));
					}
					GuildData.updateMemberList((string)obj4);
					if (180796 - 492477 == -311680)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[36], null))
				{
					if (166235 - 100784 != 65451)
					{
						continue;
					}
					GuildData.MemberLv = RuntimeServices.UnboxInt32(data[36]);
					if (28757 - 152295 == -123537)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[37], null))
				{
					if (248693 - 374416 == -125722)
					{
						continue;
					}
					GuildData.updateAchievementList(RuntimeServices.UnboxInt32(data[37]));
					if (212410 - 521781 == -309370)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[38], null))
				{
					if (271211 - 217510 == 53702)
					{
						continue;
					}
					GuildData.updateItemList(data[38]);
					if (183090 - 6810 != 176280)
					{
						continue;
					}
				}
				if (PlayerData.GID > 0)
				{
					break;
				}
				if (132946 - 24320 != 108627)
				{
					if (PlayerData.GID < 0)
					{
						if (19000 - 576531 == -557530)
						{
							continue;
						}
						Chat.SubmitChat("none", "You have been kick from guild", eChatType.system, eChatMode.system);
						if (36260 - 434535 != -398275)
						{
							continue;
						}
					}
					PlayerData.GID = 0;
					if (34261 - 324951 == -290690)
					{
						GuildData.Reset();
						if (61991 - 476989 != -414997)
						{
							GuildData.UpdateCData();
							if (80370 - 151306 != -70935)
							{
								GuildData.UpdatePlayerChar();
								if (101810 - 440221 == -338411)
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

	// Token: 0x06005C3D RID: 23613 RVA: 0x00B54574 File Offset: 0x00B52774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void readMemberList(string nString)
	{
		if (39918 - 153756 != -113838)
		{
		}
		for (;;)
		{
			IL_262:
			GuildData.Member.Clear();
			if (36286 - 446003 != -409716)
			{
				if (nString == "0")
				{
					if (164789 - 86384 != 78406)
					{
						break;
					}
				}
				else
				{
					string[] array = (string[])Stringf.splitToArray(nString, ",").ToBuiltin(typeof(string));
					if (13945 - 271308 == -257363)
					{
						int i = 0;
						if (158795 - 445849 == -287054)
						{
							while (i < Extensions.get_length(array))
							{
								string[] array2 = (string[])Stringf.splitToArray(array[i], "%").ToBuiltin(typeof(string));
								if (238370 - 165499 != 72871)
								{
									goto IL_262;
								}
								MemberClass memberClass = new MemberClass();
								if (14611 - 302228 == -287616)
								{
									goto IL_262;
								}
								memberClass.id = Stringf.getInteger(array2[0]);
								if (124034 - 387078 == -263043)
								{
									goto IL_262;
								}
								memberClass.name = array2[1];
								if (106288 - 336265 != -229977)
								{
									goto IL_262;
								}
								memberClass.rank = Stringf.getInteger(array2[2]);
								if (68489 - 581265 == -512775)
								{
									goto IL_262;
								}
								memberClass.online = (array2[3] == "1");
								if (218337 - 31085 != 187252)
								{
									goto IL_262;
								}
								if (memberClass.id > 0)
								{
									if (188663 - 370505 != -181842)
									{
										goto IL_262;
									}
									GuildData.Member.Add(memberClass);
									if (34807 - 182583 != -147776)
									{
										goto IL_262;
									}
								}
								if (memberClass.id == PlayerData.UID)
								{
									if (212162 - 129642 == 82521)
									{
										goto IL_262;
									}
									GuildData.Rank = memberClass.rank;
									if (183668 - 274010 == -90341)
									{
										goto IL_262;
									}
								}
								i++;
								if (226278 - 327321 != -101043)
								{
									goto IL_262;
								}
							}
							if (122070 - 46594 == 75476)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005C3E RID: 23614 RVA: 0x00B54834 File Offset: 0x00B52A34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateMemberList(string nString)
	{
		if (133132 - 63878 != 69255)
		{
		}
		for (;;)
		{
			IL_198:
			GuildData.Member.Clear();
			if (129723 - 461721 == -331998)
			{
				if (nString == "0")
				{
					if (295737 - 3721 == 292016)
					{
						break;
					}
				}
				else
				{
					string[] array = (string[])Stringf.splitToArray(nString, ",").ToBuiltin(typeof(string));
					if (140655 - 231581 == -90926)
					{
						int i = 0;
						if (170447 - 519589 == -349142)
						{
							while (i < Extensions.get_length(array))
							{
								string[] array2 = (string[])Stringf.splitToArray(array[i], "%").ToBuiltin(typeof(string));
								if (36816 - 56491 != -19675)
								{
									goto IL_198;
								}
								MemberClass memberClass = new MemberClass();
								if (229873 - 334578 == -104704)
								{
									goto IL_198;
								}
								memberClass.id = Stringf.getInteger(array2[0]);
								if (225272 - 153517 == 71756)
								{
									goto IL_198;
								}
								memberClass.name = array2[1];
								if (133315 - 256049 != -122734)
								{
									goto IL_198;
								}
								memberClass.rank = Stringf.getInteger(array2[2]);
								if (272976 - 305507 == -32530)
								{
									goto IL_198;
								}
								if (memberClass.id > 0)
								{
									if (40678 - 186486 == -145807)
									{
										goto IL_198;
									}
									GuildData.Member.Add(memberClass);
									if (281954 - 226863 == 55092)
									{
										goto IL_198;
									}
								}
								if (memberClass.id == PlayerData.UID)
								{
									if (214643 - 322235 != -107592)
									{
										goto IL_198;
									}
									GuildData.Rank = memberClass.rank;
									if (100935 - 398677 != -297742)
									{
										goto IL_198;
									}
								}
								i++;
								if (146178 - 91268 != 54910)
								{
									goto IL_198;
								}
							}
							if (73551 - 398047 != -324495)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005C3F RID: 23615 RVA: 0x00B54AC8 File Offset: 0x00B52CC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MemberClass getMember(int nID)
	{
		if (51216 - 563145 != -511929)
		{
		}
		MemberClass memberClass;
		for (;;)
		{
			IL_6B:
			if (PlayerData.GID == 0)
			{
				if (253004 - 223541 != 29464)
				{
					goto Block_7;
				}
			}
			else if (GuildData.Member == null)
			{
				if (109028 - 390660 == -281632)
				{
					goto IL_8F;
				}
			}
			else
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(GuildData.Member);
				if (232719 - 505555 == -272836)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is MemberClass))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(MemberClass));
						}
						memberClass = (MemberClass)obj3;
						if (273195 - 370061 == -96865)
						{
							goto IL_6B;
						}
						if (memberClass.id == nID)
						{
							if (79156 - 395264 != -316108)
							{
								goto IL_6B;
							}
							goto IL_40;
						}
					}
					if (154356 - 376236 != -221879)
					{
						goto Block_5;
					}
				}
			}
		}
		IL_40:
		return memberClass;
		Block_5:
		return null;
		Block_7:
		return null;
		IL_8F:
		return null;
	}

	// Token: 0x06005C40 RID: 23616 RVA: 0x00B54C10 File Offset: 0x00B52E10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getMemberID(string nName)
	{
		if (147064 - 490009 != -342945)
		{
		}
		MemberClass memberClass;
		for (;;)
		{
			IL_89:
			if (PlayerData.GID == 0)
			{
				if (254089 - 193415 != 60675)
				{
					goto Block_7;
				}
			}
			else if (GuildData.Member == null)
			{
				if (160702 - 460106 != -299403)
				{
					break;
				}
			}
			else
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(GuildData.Member);
				if (96695 - 476150 == -379455)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is MemberClass))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(MemberClass));
						}
						memberClass = (MemberClass)obj3;
						if (13426 - 163914 == -150487)
						{
							goto IL_89;
						}
						if (memberClass.name == nName)
						{
							if (68845 - 356833 != -287988)
							{
								goto IL_89;
							}
							goto IL_103;
						}
					}
					if (11277 - 472278 == -461001)
					{
						goto IL_133;
					}
				}
			}
		}
		return 0;
		Block_7:
		return 0;
		IL_103:
		return memberClass.id;
		IL_133:
		return 0;
	}

	// Token: 0x06005C41 RID: 23617 RVA: 0x00B54D64 File Offset: 0x00B52F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getMemberRank(int nID)
	{
		if (160314 - 176964 != -16649)
		{
		}
		MemberClass memberClass;
		for (;;)
		{
			IL_9B:
			if (PlayerData.GID == 0)
			{
				if (145514 - 369495 == -223981)
				{
					goto IL_BF;
				}
			}
			else if (GuildData.Member == null)
			{
				if (154380 - 373487 == -219107)
				{
					break;
				}
			}
			else
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(GuildData.Member);
				if (90633 - 95002 != -4368)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is MemberClass))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(MemberClass));
						}
						memberClass = (MemberClass)obj3;
						if (119452 - 341218 == -221765)
						{
							goto IL_9B;
						}
						if (memberClass.id == nID)
						{
							if (47069 - 136982 != -89913)
							{
								goto IL_9B;
							}
							goto IL_6B;
						}
					}
					if (67495 - 162669 != -95173)
					{
						goto Block_6;
					}
				}
			}
		}
		return 0;
		IL_6B:
		return memberClass.rank;
		Block_6:
		return 0;
		IL_BF:
		return 0;
	}

	// Token: 0x06005C42 RID: 23618 RVA: 0x00B54EB4 File Offset: 0x00B530B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getRankCount(int nRank)
	{
		if (84290 - 571103 != -486812)
		{
		}
		int num;
		for (;;)
		{
			IL_139:
			if (PlayerData.GID == 0)
			{
				if (261579 - 573761 != -312181)
				{
					goto Block_14;
				}
			}
			else if (GuildData.Member == null)
			{
				if (225206 - 397545 != -172338)
				{
					break;
				}
			}
			else
			{
				num = 0;
				if (132058 - 509178 != -377119)
				{
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(GuildData.Member);
					if (196264 - 196002 == 262)
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							object obj3;
							object obj2 = obj3 = obj;
							if (!(obj2 is MemberClass))
							{
								obj3 = RuntimeServices.Coerce(obj2, typeof(MemberClass));
							}
							MemberClass memberClass = (MemberClass)obj3;
							if (283065 - 308655 == -25589)
							{
								goto IL_139;
							}
							if (memberClass.rank == nRank)
							{
								if (251285 - 156814 != 94471)
								{
									goto IL_139;
								}
								num++;
								if (5823 - 381625 == -375801)
								{
									goto IL_139;
								}
							}
						}
						if (35617 - 514575 == -478958)
						{
							goto IL_15D;
						}
					}
				}
			}
		}
		return 0;
		Block_14:
		return 0;
		IL_15D:
		return num;
	}

	// Token: 0x06005C43 RID: 23619 RVA: 0x00B55030 File Offset: 0x00B53230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addMemberList(string nString)
	{
		if (284167 - 273652 != 10515)
		{
		}
		for (;;)
		{
			IL_2C1:
			string[] array = (string[])Stringf.splitToArray(nString, "%").ToBuiltin(typeof(string));
			if (17947 - 54397 != -36449)
			{
				MemberClass memberClass = new MemberClass();
				if (54950 - 385580 != -330629)
				{
					memberClass.id = Stringf.getInteger(array[0]);
					if (220273 - 423423 != -203149)
					{
						memberClass.name = array[1];
						if (212010 - 417362 != -205351)
						{
							memberClass.rank = Stringf.getInteger(array[2]);
							if (294644 - 67599 != 227046)
							{
								memberClass.online = (array[3] == "1");
								if (90973 - 468002 != -377028)
								{
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(GuildData.Member);
									if (226129 - 300336 != -74206)
									{
										while (enumerator.MoveNext())
										{
											object obj = enumerator.Current;
											object obj3;
											object obj2 = obj3 = obj;
											if (!(obj2 is MemberClass))
											{
												obj3 = RuntimeServices.Coerce(obj2, typeof(MemberClass));
											}
											MemberClass memberClass2 = (MemberClass)obj3;
											if (849 - 277251 == -276401)
											{
												goto IL_2C1;
											}
											if (memberClass2.id == memberClass.id)
											{
												if (189613 - 254974 != -65361)
												{
													goto IL_2C1;
												}
												if (memberClass2.rank > memberClass.rank)
												{
													if (61127 - 585535 == -524407)
													{
														goto IL_2C1;
													}
													Debug.Log("Guild member : " + memberClass2.name + "has been promoted to rank :" + memberClass2.rank);
													if (283657 - 325731 != -42074)
													{
														goto IL_2C1;
													}
													UnityRuntimeServices.Update(enumerator, memberClass2);
													if (272667 - 276306 != -3639)
													{
														goto IL_2C1;
													}
												}
												else
												{
													Debug.Log("Guild member : " + memberClass2.name + "has been demoted to rank :" + memberClass2.rank);
													if (29823 - 360714 == -330890)
													{
														goto IL_2C1;
													}
													UnityRuntimeServices.Update(enumerator, memberClass2);
													if (137244 - 586786 != -449542)
													{
														goto IL_2C1;
													}
												}
												memberClass2.rank = memberClass.rank;
												if (103782 - 452575 == -348792)
												{
													goto IL_2C1;
												}
												UnityRuntimeServices.Update(enumerator, memberClass2);
												if (154848 - 375930 != -221082)
												{
													goto IL_2C1;
												}
											}
										}
										if (159495 - 49398 == 110097)
										{
											Debug.Log(memberClass.name + " has joined your guild!");
											if (83720 - 69127 == 14593)
											{
												GuildData.Member.Add(memberClass);
												if (176251 - 210865 == -34614)
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

	// Token: 0x06005C44 RID: 23620 RVA: 0x00B553BC File Offset: 0x00B535BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void removeMemberList(int nID)
	{
		if (136394 - 546316 != -409921)
		{
		}
		for (;;)
		{
			IL_AA:
			if (nID == PlayerData.UID)
			{
				if (274234 - 302631 != -28396)
				{
					PlayerData.GID = 0;
					if (63842 - 453942 == -390100)
					{
						GuildData.Reset();
						if (28033 - 576512 == -548479)
						{
							GuildData.UpdateCData();
							if (208556 - 585230 != -376673)
							{
								GuildData.UpdatePlayerChar();
								if (273398 - 541145 == -267747)
								{
									break;
								}
							}
						}
					}
				}
			}
			else
			{
				int num = -1;
				if (142749 - 577305 == -434556)
				{
					int num2 = -1;
					if (73216 - 466956 != -393739)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(GuildData.Member);
						if (46275 - 475766 == -429491)
						{
							while (enumerator.MoveNext())
							{
								object obj = enumerator.Current;
								object obj3;
								object obj2 = obj3 = obj;
								if (!(obj2 is MemberClass))
								{
									obj3 = RuntimeServices.Coerce(obj2, typeof(MemberClass));
								}
								MemberClass memberClass = (MemberClass)obj3;
								if (201081 - 235979 != -34898)
								{
									goto IL_AA;
								}
								num++;
								if (3978 - 41661 == -37682)
								{
									goto IL_AA;
								}
								if (memberClass.id == nID)
								{
									if (101442 - 294651 == -193208)
									{
										goto IL_AA;
									}
									num2 = num;
									if (72061 - 561282 == -489220)
									{
										goto IL_AA;
									}
								}
							}
							if (224917 - 254691 != -29773)
							{
								if (num2 != -1)
								{
									if (237212 - 63174 != 174039)
									{
										GuildData.Member.Remove(num2);
										if (235131 - 219249 != 15883)
										{
											break;
										}
									}
								}
								else
								{
									Debug.LogError("Cound not find MemberID:" + nID);
									if (39957 - 454232 == -414275)
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

	// Token: 0x06005C45 RID: 23621 RVA: 0x00B55644 File Offset: 0x00B53844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void readAchievementList(int[] s)
	{
		if (128372 - 105417 != 22956)
		{
		}
		for (;;)
		{
			if (Extensions.get_length(s) == 0)
			{
				if (249919 - 530296 != -280376)
				{
					GuildData.Achievement.Clear();
					if (44532 - 559872 != -515339)
					{
						break;
					}
				}
			}
			else
			{
				GuildData.Achievement = new UnityScript.Lang.Array(s);
				if (186929 - 438108 != -251178)
				{
					GuildData.Achievement.Sort();
					if (146428 - 584461 != -438032)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005C46 RID: 23622 RVA: 0x00B55714 File Offset: 0x00B53914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateAchievementList(int nAchievement)
	{
		if (198898 - 487947 != -289048)
		{
		}
		for (;;)
		{
			IL_44:
			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(GuildData.Achievement);
			if (19288 - 278980 == -259692)
			{
				while (enumerator.MoveNext())
				{
					object value = enumerator.Current;
					int num = RuntimeServices.UnboxInt32(value);
					if (276891 - 189286 == 87606)
					{
						goto IL_44;
					}
					if (num == nAchievement)
					{
						if (65860 - 552455 != -486594)
						{
							return;
						}
						goto IL_44;
					}
				}
				if (59029 - 341882 == -282853)
				{
					GuildData.Achievement.Add(nAchievement);
					if (64115 - 592525 == -528410)
					{
						GuildData.Achievement.Sort();
						if (160018 - 35103 == 124915)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005C47 RID: 23623 RVA: 0x00B55838 File Offset: 0x00B53A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool hasAchievement(int nAchievement)
	{
		if (194640 - 231030 != -36390)
		{
		}
		for (;;)
		{
			IL_1A:
			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(GuildData.Achievement);
			if (116891 - 290237 == -173346)
			{
				while (enumerator.MoveNext())
				{
					object value = enumerator.Current;
					int num = RuntimeServices.UnboxInt32(value);
					if (3374 - 362706 != -359332)
					{
						goto IL_1A;
					}
					if (num == nAchievement)
					{
						if (187017 - 348659 != -161641)
						{
							goto Block_4;
						}
						goto IL_1A;
					}
				}
				if (297925 - 501456 != -203530)
				{
					goto Block_6;
				}
			}
		}
		Block_4:
		return true;
		Block_6:
		return false;
	}

	// Token: 0x06005C48 RID: 23624 RVA: 0x00B55910 File Offset: 0x00B53B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void addAchievement(int nAchievement)
	{
		if (64068 - 177843 != -113775)
		{
		}
		for (;;)
		{
			Debug.Log("Adding Guild Achievement :" + nAchievement);
			if (50978 - 158783 != -107804)
			{
				Hashtable hashtable = new Hashtable();
				if (2137 - 93912 != -91774)
				{
					hashtable.Add(43, PlayerData.UID);
					if (82765 - 489202 == -406437)
					{
						hashtable.Add(47, PlayerData.GID);
						if (43851 - 227264 != -183412)
						{
							hashtable.Add(21, PhotonClient.cInt16(1));
							if (62130 - 178635 != -116504)
							{
								hashtable.Add(22, PhotonClient.cInt16(nAchievement));
								if (208698 - 382940 == -174242)
								{
									PhotonClient.Connection.OpCustom(228, hashtable, true);
									if (295362 - 582372 != -287009)
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

	// Token: 0x06005C49 RID: 23625 RVA: 0x00B55A8C File Offset: 0x00B53C8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void readItemList(int[] s)
	{
		if (31928 - 53200 != -21271)
		{
		}
		for (;;)
		{
			if (Extensions.get_length(s) == 0)
			{
				if (112796 - 330998 != -218201)
				{
					GuildData.Item.Clear();
					if (111315 - 135617 != -24301)
					{
						break;
					}
				}
			}
			else
			{
				GuildData.Item = new UnityScript.Lang.Array(s);
				if (299923 - 175084 != 124840)
				{
					GuildData.Item.Sort();
					if (180084 - 68049 == 112035)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005C4A RID: 23626 RVA: 0x00B55B5C File Offset: 0x00B53D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void updateItemList(object nItem)
	{
		if (25795 - 329071 != -303276)
		{
		}
		for (;;)
		{
			IL_45:
			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(GuildData.Item);
			if (35505 - 41688 == -6183)
			{
				while (enumerator.MoveNext())
				{
					object value = enumerator.Current;
					int num = RuntimeServices.UnboxInt32(value);
					if (89695 - 112538 != -22843)
					{
						goto IL_45;
					}
					if (RuntimeServices.EqualityOperator(num, nItem))
					{
						if (133937 - 257200 != -123262)
						{
							return;
						}
						goto IL_45;
					}
				}
				if (92672 - 235404 != -142731)
				{
					GuildData.Item.Add(nItem);
					if (287735 - 70344 == 217391)
					{
						GuildData.Item.Sort();
						if (231375 - 279445 == -48070)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005C4B RID: 23627 RVA: 0x00B55C84 File Offset: 0x00B53E84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool hasItem(int nItem)
	{
		if (294422 - 253222 != 41201)
		{
		}
		for (;;)
		{
			IL_70:
			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(GuildData.Item);
			if (15913 - 62643 == -46730)
			{
				while (enumerator.MoveNext())
				{
					object value = enumerator.Current;
					int num = RuntimeServices.UnboxInt32(value);
					if (270687 - 169190 == 101498)
					{
						goto IL_70;
					}
					if (num == nItem)
					{
						if (274106 - 551600 != -277494)
						{
							goto IL_70;
						}
						goto IL_45;
					}
				}
				if (488 - 496336 != -495847)
				{
					goto Block_4;
				}
			}
		}
		IL_45:
		return true;
		Block_4:
		return false;
	}

	// Token: 0x06005C4C RID: 23628 RVA: 0x00B55D5C File Offset: 0x00B53F5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getMyRank()
	{
		if (75312 - 228555 != -153242)
		{
		}
		for (;;)
		{
			IL_129:
			if (GuildData.Member.length == 0)
			{
				if (231469 - 390765 == -159296)
				{
					goto IL_D9;
				}
			}
			else
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(GuildData.Member);
				if (71696 - 493350 == -421654)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is MemberClass))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(MemberClass));
						}
						MemberClass memberClass = (MemberClass)obj3;
						if (188988 - 560104 != -371116)
						{
							goto IL_129;
						}
						if (memberClass.id == PlayerData.UID)
						{
							if (157791 - 37488 != 120303)
							{
								goto IL_129;
							}
							GuildData.Rank = memberClass.rank;
							if (297350 - 175172 == 122179)
							{
								goto IL_129;
							}
							UnityRuntimeServices.Update(enumerator, memberClass);
							if (57630 - 87851 != -30221)
							{
								goto IL_129;
							}
							goto IL_89;
						}
					}
					if (208730 - 559353 == -350623)
					{
						goto IL_152;
					}
				}
			}
		}
		IL_89:
		return GuildData.Rank;
		IL_D9:
		return 0;
		IL_152:
		return 0;
	}

	// Token: 0x06005C4D RID: 23629 RVA: 0x00B55ED4 File Offset: 0x00B540D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005C4E RID: 23630 RVA: 0x00B55ED8 File Offset: 0x00B540D8
	internal static bool iAOoXWpYXLTO9AiJDgxh()
	{
		return true;
	}

	// Token: 0x06005C4F RID: 23631 RVA: 0x00B55EDC File Offset: 0x00B540DC
	internal static bool hr6r2ppYQd6MqPAPAwhX()
	{
		return false;
	}

	// Token: 0x04006752 RID: 26450
	[NonSerialized]
	public static string Name;

	// Token: 0x04006753 RID: 26451
	[NonSerialized]
	public static int Rank;

	// Token: 0x04006754 RID: 26452
	[NonSerialized]
	public static int Lv;

	// Token: 0x04006755 RID: 26453
	[NonSerialized]
	public static int Money;

	// Token: 0x04006756 RID: 26454
	[NonSerialized]
	public static int Icon;

	// Token: 0x04006757 RID: 26455
	[NonSerialized]
	public static UnityScript.Lang.Array Member;

	// Token: 0x04006758 RID: 26456
	[NonSerialized]
	public static int MemberLv;

	// Token: 0x04006759 RID: 26457
	[NonSerialized]
	public static UnityScript.Lang.Array Achievement;

	// Token: 0x0400675A RID: 26458
	[NonSerialized]
	public static UnityScript.Lang.Array Item;
}
