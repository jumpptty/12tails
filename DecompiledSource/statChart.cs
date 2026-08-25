using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E02 RID: 3586
[Serializable]
public class statChart : MonoBehaviour
{
	// Token: 0x0600510D RID: 20749 RVA: 0x009EB31C File Offset: 0x009E951C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public statChart()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600510E RID: 20750 RVA: 0x009EB32C File Offset: 0x009E952C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderStatChart()
	{
		GUIUtility.RotateAroundPivot((float)45, new Vector2((float)3, (float)1));
		GUI.Label(new Rect((float)200, (float)200, (float)32, (float)200), this.statChart_LineTexture);
	}

	// Token: 0x0600510F RID: 20751 RVA: 0x009EB364 File Offset: 0x009E9564
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005110 RID: 20752 RVA: 0x009EB368 File Offset: 0x009E9568
	internal static bool ervYN75eDbW3NVnpOijx()
	{
		return true;
	}

	// Token: 0x06005111 RID: 20753 RVA: 0x009EB36C File Offset: 0x009E956C
	internal static bool COEYXo5evyflTSmUYjqc()
	{
		return false;
	}

	// Token: 0x04005A98 RID: 23192
	public Texture statChart_LineTexture;
}
