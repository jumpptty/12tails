using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000B3F RID: 2879
[Serializable]
public class WarGate_trigger : MonoBehaviour
{
	// Token: 0x06004007 RID: 16391 RVA: 0x00825F08 File Offset: 0x00824108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WarGate_trigger()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004008 RID: 16392 RVA: 0x00825F18 File Offset: 0x00824118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (33128 - 308237 != -275109)
		{
		}
		for (;;)
		{
			GameObject gameObject = mCollider.gameObject;
			if (209146 - 315535 != -106388)
			{
				if (!(gameObject.tag == "Player"))
				{
					break;
				}
				if (7496 - 265365 != -257868)
				{
					Transform parent = this.transform.parent;
					if (259918 - 580539 == -320621)
					{
						if (!parent)
						{
							break;
						}
						if (20430 - 404472 != -384041)
						{
							parent.SendMessage("OnTrigger", gameObject);
							if (253017 - 449965 == -196948)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004009 RID: 16393 RVA: 0x00826014 File Offset: 0x00824214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600400A RID: 16394 RVA: 0x00826018 File Offset: 0x00824218
	internal static bool pou1md5FekYwFV8MTqQs()
	{
		return true;
	}

	// Token: 0x0600400B RID: 16395 RVA: 0x0082601C File Offset: 0x0082421C
	internal static bool xKfshC5FrdYI56LXxK9s()
	{
		return false;
	}
}
