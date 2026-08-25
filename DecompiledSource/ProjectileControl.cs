using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FB6 RID: 4022
[AddComponentMenu("MissionControl/ProjectileControl")]
[Serializable]
public class ProjectileControl : MonoBehaviour
{
	// Token: 0x06005B99 RID: 23449 RVA: 0x00B30A4C File Offset: 0x00B2EC4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ProjectileControl()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005B9A RID: 23450 RVA: 0x00B30A5C File Offset: 0x00B2EC5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nOwnerID)
	{
		if (239058 - 122085 != 116974)
		{
		}
		while (!this.isInitialized)
		{
			if (195971 - 348466 != -152494)
			{
				if (this.isDestroyed)
				{
					if (188963 - 496477 != -307513)
					{
						break;
					}
				}
				else
				{
					this.isInitialized = true;
					if (166060 - 489991 != -323930)
					{
						this.OwnerID = nOwnerID;
						if (36002 - 127248 == -91246)
						{
							return;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005B9B RID: 23451 RVA: 0x00B30B28 File Offset: 0x00B2ED28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005B9C RID: 23452 RVA: 0x00B30B2C File Offset: 0x00B2ED2C
	internal static bool xjc2hfpNqJTf0jZKq7Lc()
	{
		return true;
	}

	// Token: 0x06005B9D RID: 23453 RVA: 0x00B30B30 File Offset: 0x00B2ED30
	internal static bool Amk1GepN7UVGIX26JRrK()
	{
		return false;
	}

	// Token: 0x0400670A RID: 26378
	public float life;

	// Token: 0x0400670B RID: 26379
	public float dmg;

	// Token: 0x0400670C RID: 26380
	public Vector3 velocity;

	// Token: 0x0400670D RID: 26381
	public int OwnerID;

	// Token: 0x0400670E RID: 26382
	public bool isInitialized;

	// Token: 0x0400670F RID: 26383
	public bool isDestroyed;
}
