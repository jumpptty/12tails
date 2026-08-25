using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000B31 RID: 2865
[Serializable]
public class SoccerBall_trigger : MonoBehaviour
{
	// Token: 0x06003FAE RID: 16302 RVA: 0x008209C4 File Offset: 0x0081EBC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SoccerBall_trigger()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003FAF RID: 16303 RVA: 0x008209D4 File Offset: 0x0081EBD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider nCollider)
	{
		if (nCollider.gameObject.tag == "Player")
		{
			this.transform.parent.SendMessage("OnPlayerKick", nCollider.gameObject);
		}
	}

	// Token: 0x06003FB0 RID: 16304 RVA: 0x00820A0C File Offset: 0x0081EC0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003FB1 RID: 16305 RVA: 0x00820A10 File Offset: 0x0081EC10
	internal static bool Gj6yBA5FZqBqVCFmFoH3()
	{
		return true;
	}

	// Token: 0x06003FB2 RID: 16306 RVA: 0x00820A14 File Offset: 0x0081EC14
	internal static bool kEDsu75FCsYGKako4dJj()
	{
		return false;
	}
}
