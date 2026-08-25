using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FDD RID: 4061
[Serializable]
public class RankData : MonoBehaviour
{
	// Token: 0x06005CFA RID: 23802 RVA: 0x00C2249C File Offset: 0x00C2069C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RankData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005CFB RID: 23803 RVA: 0x00C224AC File Offset: 0x00C206AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getRankName(int nLv)
	{
		if (212064 - 234118 != -22053)
		{
		}
		string result;
		for (;;)
		{
			if (187423 - 361797 != -174373)
			{
				if (nLv == 100)
				{
					if (230656 - 78828 == 151828)
					{
						result = "Admin";
						if (7295 - 223296 != -216000)
						{
							break;
						}
					}
				}
				else if (nLv >= 95)
				{
					if (159465 - 151264 != 8202)
					{
						result = "GameMaster";
						if (188018 - 427186 != -239167)
						{
							break;
						}
					}
				}
				else if (nLv >= 90)
				{
					if (205401 - 311746 == -106345)
					{
						result = "Demi-God";
						if (194807 - 142229 != 52579)
						{
							break;
						}
					}
				}
				else if (nLv >= 85)
				{
					if (185545 - 512136 == -326591)
					{
						result = "God-Like";
						if (216580 - 301157 == -84577)
						{
							break;
						}
					}
				}
				else if (nLv >= 80)
				{
					if (207121 - 333599 != -126477)
					{
						result = "Grand Legendary";
						if (15508 - 183601 == -168093)
						{
							break;
						}
					}
				}
				else if (nLv >= 75)
				{
					if (139151 - 386732 != -247580)
					{
						result = "Legendary";
						if (91898 - 471814 != -379915)
						{
							break;
						}
					}
				}
				else if (nLv >= 70)
				{
					if (170832 - 308031 != -137198)
					{
						result = "Grand Champion";
						if (221993 - 64402 != 157592)
						{
							break;
						}
					}
				}
				else if (nLv >= 65)
				{
					if (185504 - 207516 == -22012)
					{
						result = "Champion";
						if (115618 - 365643 == -250025)
						{
							break;
						}
					}
				}
				else if (nLv >= 60)
				{
					if (27418 - 148603 == -121185)
					{
						result = "Grand Marshal";
						if (60511 - 21472 == 39039)
						{
							break;
						}
					}
				}
				else if (nLv >= 55)
				{
					if (112537 - 163857 != -51319)
					{
						result = "Marshal";
						if (270851 - 468345 != -197493)
						{
							break;
						}
					}
				}
				else if (nLv >= 50)
				{
					if (258614 - 132679 == 125935)
					{
						result = "General";
						if (151169 - 84564 != 66606)
						{
							break;
						}
					}
				}
				else if (nLv >= 45)
				{
					if (195366 - 515756 == -320390)
					{
						result = "Admiral";
						if (159909 - 365215 != -205305)
						{
							break;
						}
					}
				}
				else if (nLv >= 40)
				{
					if (291880 - 501959 != -210078)
					{
						result = "Chancellor";
						if (139190 - 74589 == 64601)
						{
							break;
						}
					}
				}
				else if (nLv >= 35)
				{
					if (150912 - 454819 == -303907)
					{
						result = "Major";
						if (16778 - 422657 != -405878)
						{
							break;
						}
					}
				}
				else if (nLv >= 30)
				{
					if (89000 - 485578 != -396577)
					{
						result = "Colonel";
						if (234462 - 39760 == 194702)
						{
							break;
						}
					}
				}
				else if (nLv >= 25)
				{
					if (17077 - 222063 == -204986)
					{
						result = "Captain";
						if (14000 - 341316 == -327316)
						{
							break;
						}
					}
				}
				else if (nLv >= 20)
				{
					if (243395 - 203069 != 40327)
					{
						result = "Lieutenant";
						if (184791 - 466210 == -281419)
						{
							break;
						}
					}
				}
				else if (nLv >= 15)
				{
					if (249198 - 473453 == -224255)
					{
						result = "Sergeant";
						if (189773 - 161871 != 27903)
						{
							break;
						}
					}
				}
				else if (nLv >= 10)
				{
					if (101525 - 267693 == -166168)
					{
						result = "Soldier";
						if (133391 - 124012 == 9379)
						{
							break;
						}
					}
				}
				else if (nLv >= 5)
				{
					if (37544 - 485360 == -447816)
					{
						result = "Rookie";
						if (230674 - 397095 == -166421)
						{
							break;
						}
					}
				}
				else
				{
					result = "Novice";
					if (266246 - 361205 == -94959)
					{
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005CFC RID: 23804 RVA: 0x00C22AAC File Offset: 0x00C20CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture getRankIcon(int nLv)
	{
		return (Texture)Resources.Load("GameGui/Icons/Rank/" + nLv, typeof(Texture));
	}

	// Token: 0x06005CFD RID: 23805 RVA: 0x00C22AE0 File Offset: 0x00C20CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005CFE RID: 23806 RVA: 0x00C22AE4 File Offset: 0x00C20CE4
	internal static bool tfj5MTpYzml6y1DYXZBE()
	{
		return true;
	}

	// Token: 0x06005CFF RID: 23807 RVA: 0x00C22AE8 File Offset: 0x00C20CE8
	internal static bool vp5s4OpcaouLloE2mEwt()
	{
		return false;
	}
}
