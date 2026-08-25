using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000DFF RID: 3583
[AddComponentMenu("Particles/UV Scroll")]
[Serializable]
public class UVScroll : MonoBehaviour
{
	// Token: 0x060050FD RID: 20733 RVA: 0x009EADFC File Offset: 0x009E8FFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public UVScroll()
	{
		if (42077 - 5005 != 37073)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (73655 - 82210 != -8554)
			{
				base..ctor();
				if (198159 - 159979 != 38181)
				{
					this.scroll_x = 0.1f;
					if (88919 - 90426 == -1507)
					{
						this.scroll_y = 0.1f;
						if (204171 - 525243 != -321071)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060050FE RID: 20734 RVA: 0x009EAEC0 File Offset: 0x009E90C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		Vector2 offset = new Vector2(Mathf.Repeat(Time.time * this.scroll_x, (float)100), Mathf.Repeat(Time.time * this.scroll_y, (float)100));
		this.renderer.material.SetTextureOffset("_MainTex", offset);
	}

	// Token: 0x060050FF RID: 20735 RVA: 0x009EAF14 File Offset: 0x009E9114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005100 RID: 20736 RVA: 0x009EAF18 File Offset: 0x009E9118
	internal static bool YeMMX55enfc8nX1crrLA()
	{
		return true;
	}

	// Token: 0x06005101 RID: 20737 RVA: 0x009EAF1C File Offset: 0x009E911C
	internal static bool Vvn3K85e6VyQwpcR35YX()
	{
		return false;
	}

	// Token: 0x04005A91 RID: 23185
	public float scroll_x;

	// Token: 0x04005A92 RID: 23186
	public float scroll_y;
}
