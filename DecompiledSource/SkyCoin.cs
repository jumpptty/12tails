using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EEA RID: 3818
[Serializable]
public class SkyCoin : MonoBehaviour
{
	// Token: 0x0600569F RID: 22175 RVA: 0x00A72E14 File Offset: 0x00A71014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SkyCoin()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060056A0 RID: 22176 RVA: 0x00A72E24 File Offset: 0x00A71024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		this.z7ZcJFrNwru = Stringf.getInteger(this.gameObject.name);
	}

	// Token: 0x060056A1 RID: 22177 RVA: 0x00A72E3C File Offset: 0x00A7103C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (228786 - 399822 != -171036)
		{
		}
		while (mCollider.gameObject.name == "PilotPlane")
		{
			if (47600 - 121519 == -73919)
			{
				Camera.main.SendMessage("onSkyCoin");
				if (4116 - 524407 != -520290)
				{
					this.DestroyMissionCoin();
					if (293684 - 529612 != -235927)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060056A2 RID: 22178 RVA: 0x00A72EF4 File Offset: 0x00A710F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyMissionCoin()
	{
		if (25181 - 125478 != -100296)
		{
		}
		do
		{
			if (this.skyCoin_effect)
			{
				if (195465 - 214445 == -18979)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.skyCoin_effect, this.transform.position, Quaternion.identity);
				if (191114 - 236312 == -45197)
				{
					continue;
				}
			}
			UnityEngine.Object.Destroy(this.gameObject);
		}
		while (6759 - 26529 != -19770);
	}

	// Token: 0x060056A3 RID: 22179 RVA: 0x00A72FB4 File Offset: 0x00A711B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056A4 RID: 22180 RVA: 0x00A72FB8 File Offset: 0x00A711B8
	internal static bool YD0pu95zTjPDHDfBhn0Q()
	{
		return true;
	}

	// Token: 0x060056A5 RID: 22181 RVA: 0x00A72FBC File Offset: 0x00A711BC
	internal static bool GRTdUd5z3egcPHkxwaeP()
	{
		return false;
	}

	// Token: 0x04005F3D RID: 24381
	private int z7ZcJFrNwru;

	// Token: 0x04005F3E RID: 24382
	public GameObject skyCoin_effect;
}
