using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E00 RID: 3584
[Serializable]
public class WaterFall : MonoBehaviour
{
	// Token: 0x06005102 RID: 20738 RVA: 0x009EAF20 File Offset: 0x009E9120
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WaterFall()
	{
		if (186064 - 236789 != -50724)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (232328 - 251131 != -18802)
			{
				base..ctor();
				if (266951 - 80148 != 186804)
				{
					this.Layer1_scroll_speed = 0.1f;
					if (7752 - 301885 != -294132)
					{
						this.Layer2_scroll_speed = 0.1f;
						if (111344 - 418683 != -307338)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005103 RID: 20739 RVA: 0x009EAFE4 File Offset: 0x009E91E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		this.renderer.material.SetTextureOffset("_ScrollLayer1", new Vector2((float)0, Time.time * this.Layer1_scroll_speed));
		this.renderer.material.SetTextureOffset("_ScrollLayer2", new Vector2((float)0, Time.time * this.Layer2_scroll_speed));
	}

	// Token: 0x06005104 RID: 20740 RVA: 0x009EB044 File Offset: 0x009E9244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005105 RID: 20741 RVA: 0x009EB048 File Offset: 0x009E9248
	internal static bool q2EqoN5ei5Hf5O20JKxQ()
	{
		return true;
	}

	// Token: 0x06005106 RID: 20742 RVA: 0x009EB04C File Offset: 0x009E924C
	internal static bool xroyBe5eKsgxD033Eou1()
	{
		return false;
	}

	// Token: 0x04005A93 RID: 23187
	public float Layer1_scroll_speed;

	// Token: 0x04005A94 RID: 23188
	public float Layer2_scroll_speed;
}
