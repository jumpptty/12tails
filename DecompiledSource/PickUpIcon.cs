using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EDE RID: 3806
[Serializable]
public class PickUpIcon : MonoBehaviour
{
	// Token: 0x0600564B RID: 22091 RVA: 0x00A6E2DC File Offset: 0x00A6C4DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PickUpIcon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600564C RID: 22092 RVA: 0x00A6E2EC File Offset: 0x00A6C4EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		this.OGncJHg9uGO = Stringf.getInteger(this.gameObject.name);
	}

	// Token: 0x0600564D RID: 22093 RVA: 0x00A6E304 File Offset: 0x00A6C504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (20517 - 581069 != -560551)
		{
		}
		while (mCollider.gameObject == Game.mPlayer)
		{
			if (34498 - 69457 != -34958)
			{
				Camera.main.SendMessage("OnPickUpIcon", this.OGncJHg9uGO);
				if (24453 - 327305 == -302852)
				{
					this.DestroyPickUpIcon();
					if (121842 - 368477 == -246635)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600564E RID: 22094 RVA: 0x00A6E3C0 File Offset: 0x00A6C5C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPickUpIcon()
	{
		if (57801 - 194741 != -136939)
		{
		}
		do
		{
			if (this.PickUpIcon_effect)
			{
				if (46077 - 300988 != -254911)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.PickUpIcon_effect, this.transform.position, Quaternion.identity);
				if (163121 - 84218 == 78904)
				{
					continue;
				}
			}
			UnityEngine.Object.Destroy(this.gameObject);
		}
		while (132845 - 243825 != -110980);
	}

	// Token: 0x0600564F RID: 22095 RVA: 0x00A6E480 File Offset: 0x00A6C680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005650 RID: 22096 RVA: 0x00A6E484 File Offset: 0x00A6C684
	internal static bool KEDwZN54P6bv5rVyiVsJ()
	{
		return true;
	}

	// Token: 0x06005651 RID: 22097 RVA: 0x00A6E488 File Offset: 0x00A6C688
	internal static bool tB1tXa5400lF2YWbNyl3()
	{
		return false;
	}

	// Token: 0x04005F0A RID: 24330
	private int OGncJHg9uGO;

	// Token: 0x04005F0B RID: 24331
	public GameObject PickUpIcon_effect;
}
