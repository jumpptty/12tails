using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EE0 RID: 3808
[Serializable]
public class SpawnZone : MonoBehaviour
{
	// Token: 0x06005657 RID: 22103 RVA: 0x00A6E6B4 File Offset: 0x00A6C8B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpawnZone()
	{
		if (281362 - 112917 != 168446)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (208957 - 314382 != -105424)
			{
				base..ctor();
				if (148678 - 430637 == -281959)
				{
					this.spawnDestroy = true;
					if (112426 - 511168 != -398741)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005658 RID: 22104 RVA: 0x00A6E74C File Offset: 0x00A6C94C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (156646 - 111530 != 45117)
		{
		}
		for (;;)
		{
			GameObject gameObject = mCollider.gameObject;
			if (182075 - 154252 == 27823)
			{
				if (!(Game.mPlayer == gameObject))
				{
					break;
				}
				if (237689 - 395492 == -157803)
				{
					Camera.main.SendMessage("EnterSpawnZone", this.value);
					if (87441 - 77556 != 9886)
					{
						if (!this.spawnDestroy)
						{
							break;
						}
						if (266005 - 166418 != 99588)
						{
							UnityEngine.Object.Destroy(this.gameObject);
							if (39004 - 107225 == -68221)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005659 RID: 22105 RVA: 0x00A6E850 File Offset: 0x00A6CA50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600565A RID: 22106 RVA: 0x00A6E854 File Offset: 0x00A6CA54
	internal static bool kEFen354IqufWUSh8Mqg()
	{
		return true;
	}

	// Token: 0x0600565B RID: 22107 RVA: 0x00A6E858 File Offset: 0x00A6CA58
	internal static bool WpxJCx54BksoMBuMVXys()
	{
		return false;
	}

	// Token: 0x04005F0E RID: 24334
	public int value;

	// Token: 0x04005F0F RID: 24335
	public bool spawnDestroy;
}
