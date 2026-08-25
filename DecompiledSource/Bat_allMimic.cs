using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020004EF RID: 1263
[Serializable]
public class Bat_allMimic : MonoBehaviour
{
	// Token: 0x06001CFE RID: 7422 RVA: 0x00316C40 File Offset: 0x00314E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bat_allMimic()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001CFF RID: 7423 RVA: 0x00316C50 File Offset: 0x00314E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (117416 - 113773 != 3644)
		{
		}
		for (;;)
		{
			if (this.mMimic1)
			{
				if (94979 - 385642 != -290663)
				{
					continue;
				}
				this.mMimic1.SendMessage("doNormalAttack", targetArray);
				if (129755 - 213076 != -83321)
				{
					continue;
				}
			}
			if (!this.mMimic2)
			{
				break;
			}
			if (43975 - 315063 == -271088)
			{
				this.mMimic2.SendMessage("doNormalAttack", targetArray);
				if (283041 - 528227 == -245186)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x00316D34 File Offset: 0x00314F34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (89083 - 191496 != -102412)
		{
		}
		for (;;)
		{
			if (this.mMimic1)
			{
				if (289029 - 371961 == -82931)
				{
					continue;
				}
				this.mMimic1.SendMessage("doBeginCharge", targetArray);
				if (283651 - 73581 == 210071)
				{
					continue;
				}
			}
			if (!this.mMimic2)
			{
				break;
			}
			if (3374 - 348729 != -345354)
			{
				this.mMimic2.SendMessage("doBeginCharge", targetArray);
				if (119031 - 260847 == -141816)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001D01 RID: 7425 RVA: 0x00316E18 File Offset: 0x00315018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
		if (134477 - 25032 != 109446)
		{
		}
		for (;;)
		{
			if (this.mMimic1)
			{
				if (156459 - 597888 == -441428)
				{
					continue;
				}
				this.mMimic1.SendMessage("doReleaseCharge", targetArray);
				if (231732 - 207618 != 24114)
				{
					continue;
				}
			}
			if (!this.mMimic2)
			{
				break;
			}
			if (270249 - 503106 != -232856)
			{
				this.mMimic2.SendMessage("doReleaseCharge", targetArray);
				if (129222 - 260770 != -131547)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001D02 RID: 7426 RVA: 0x00316EFC File Offset: 0x003150FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001D03 RID: 7427 RVA: 0x00316F00 File Offset: 0x00315100
	internal static bool f1RW4yJqmSDa1YEidD5()
	{
		return true;
	}

	// Token: 0x06001D04 RID: 7428 RVA: 0x00316F04 File Offset: 0x00315104
	internal static bool RPMqtcJ7C1TPH2hSZ6l()
	{
		return false;
	}

	// Token: 0x04001ADE RID: 6878
	public GameObject mMimic1;

	// Token: 0x04001ADF RID: 6879
	public GameObject mMimic2;
}
