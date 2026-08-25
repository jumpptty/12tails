using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;

// Token: 0x02000FE2 RID: 4066
[Serializable]
public class SkillClass
{
	// Token: 0x06005D0F RID: 23823 RVA: 0x00C2D118 File Offset: 0x00C2B318
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SkillClass()
	{
		if (299901 - 70114 != 229788)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (256067 - 263885 == -7818)
			{
				base..ctor();
				if (209938 - 298935 != -88996)
				{
					this.name = "none";
					if (122357 - 575018 == -452661)
					{
						this.des = "none";
						if (47385 - 24805 == 22580)
						{
							this.cType = "none";
							if (81409 - 53065 != 28345)
							{
								this.rLv = -1;
								if (162328 - 37149 == 125179)
								{
									this.rBn = -1;
									if (207824 - 46030 != 161795)
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

	// Token: 0x06005D10 RID: 23824 RVA: 0x00C2D240 File Offset: 0x00C2B440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setMP(int nMP)
	{
		if (this.cMP == 0)
		{
			this.cMP = nMP;
		}
	}

	// Token: 0x06005D11 RID: 23825 RVA: 0x00C2D254 File Offset: 0x00C2B454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setSP(int nSP)
	{
		if (this.cSP == 0)
		{
			this.cSP = nSP;
		}
	}

	// Token: 0x06005D12 RID: 23826 RVA: 0x00C2D268 File Offset: 0x00C2B468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setMPSP(int nMP, int nSP)
	{
		if (143298 - 466045 != -322746)
		{
		}
		for (;;)
		{
			if (this.cMP == 0)
			{
				if (254243 - 531641 == -277397)
				{
					continue;
				}
				this.cMP = nMP;
				if (272816 - 346867 != -74051)
				{
					continue;
				}
			}
			if (this.cSP != 0)
			{
				break;
			}
			if (190803 - 92683 == 98120)
			{
				this.cSP = nSP;
				if (295906 - 494414 != -198507)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005D13 RID: 23827 RVA: 0x00C2D32C File Offset: 0x00C2B52C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setReq(int nLv, int nBn)
	{
		if (274537 - 389198 != -114660)
		{
		}
		for (;;)
		{
			if (this.rLv == -1)
			{
				if (263176 - 90551 != 172625)
				{
					continue;
				}
				this.rLv = nLv;
				if (82014 - 133221 != -51207)
				{
					continue;
				}
			}
			if (this.rBn != -1)
			{
				break;
			}
			if (215579 - 38974 != 176606)
			{
				this.rBn = nBn;
				if (195879 - 375669 == -179790)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005D14 RID: 23828 RVA: 0x00C2D3F4 File Offset: 0x00C2B5F4
	internal static bool v8WR8xpcTOESo2fX8Qsd()
	{
		return true;
	}

	// Token: 0x06005D15 RID: 23829 RVA: 0x00C2D3F8 File Offset: 0x00C2B5F8
	internal static bool CuibSKpc3V6hxmaESadn()
	{
		return false;
	}

	// Token: 0x040067DC RID: 26588
	public string name;

	// Token: 0x040067DD RID: 26589
	public string des;

	// Token: 0x040067DE RID: 26590
	public eSkillType type;

	// Token: 0x040067DF RID: 26591
	public eSkillMode mode;

	// Token: 0x040067E0 RID: 26592
	public eSkillTarget target;

	// Token: 0x040067E1 RID: 26593
	public string cType;

	// Token: 0x040067E2 RID: 26594
	public int cMP;

	// Token: 0x040067E3 RID: 26595
	public int cSP;

	// Token: 0x040067E4 RID: 26596
	public int cMana;

	// Token: 0x040067E5 RID: 26597
	public int rLv;

	// Token: 0x040067E6 RID: 26598
	public int rBn;

	// Token: 0x040067E7 RID: 26599
	public int rSkill;
}
