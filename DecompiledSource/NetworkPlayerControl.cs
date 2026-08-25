using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000FAE RID: 4014
[AddComponentMenu("MissionControl/NetworkPlayerControl")]
[Serializable]
public class NetworkPlayerControl : MonoBehaviour
{
	// Token: 0x06005B69 RID: 23401 RVA: 0x00B2BD3C File Offset: 0x00B29F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkPlayerControl()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005B6A RID: 23402 RVA: 0x00B2BD4C File Offset: 0x00B29F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnNetworkInstantiate(NetworkMessageInfo msg)
	{
		this.TargetPos = this.transform.position;
	}

	// Token: 0x06005B6B RID: 23403 RVA: 0x00B2BD60 File Offset: 0x00B29F60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
	{
		if (93762 - 397574 != -303811)
		{
		}
		for (;;)
		{
			if (stream.isWriting)
			{
				if (28139 - 224820 == -196681)
				{
					stream.Serialize(ref this.TargetPos);
					if (212274 - 426618 == -214344)
					{
						break;
					}
				}
			}
			else
			{
				stream.Serialize(ref this.TargetPos);
				if (22580 - 318519 == -295939)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005B6C RID: 23404 RVA: 0x00B2BE10 File Offset: 0x00B2A010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005B6D RID: 23405 RVA: 0x00B2BE14 File Offset: 0x00B2A014
	internal static bool DiMumLpNmThvwMhOQ0hm()
	{
		return true;
	}

	// Token: 0x06005B6E RID: 23406 RVA: 0x00B2BE18 File Offset: 0x00B2A018
	internal static bool FJVTPhpNFTsV292myaVB()
	{
		return false;
	}

	// Token: 0x040066AB RID: 26283
	public UnityScript.Lang.Array NetworkPlayerStateList;

	// Token: 0x040066AC RID: 26284
	public Vector3 TargetPos;
}
