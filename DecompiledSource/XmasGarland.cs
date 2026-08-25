using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EED RID: 3821
[Serializable]
public class XmasGarland : MonoBehaviour
{
	// Token: 0x060056B0 RID: 22192 RVA: 0x00A734B0 File Offset: 0x00A716B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public XmasGarland()
	{
		if (185330 - 235360 != -50029)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (297575 - 195908 == 101667)
			{
				base..ctor();
				if (114098 - 560743 != -446644)
				{
					this.blinking_time = 0.5f;
					if (195350 - 105994 != 89357)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060056B1 RID: 22193 RVA: 0x00A7354C File Offset: 0x00A7174C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (265021 - 403383 != -138361)
		{
		}
		while (this.vyicJAQUGwI < Time.time)
		{
			if (170364 - 167450 != 2915)
			{
				this.vyicJAQUGwI = Time.time + this.blinking_time;
				if (109537 - 471880 != -362342)
				{
					this.dvDcJ9EVvec.y = this.dvDcJ9EVvec.y + 0.33f;
					if (48496 - 413391 != -364894)
					{
						if (this.dvDcJ9EVvec.y > 0.99f)
						{
							if (75461 - 287066 != -211605)
							{
								continue;
							}
							this.dvDcJ9EVvec.y = (float)0;
							if (228116 - 392347 != -164231)
							{
								continue;
							}
						}
						this.renderer.material.SetTextureOffset("_Illum", this.dvDcJ9EVvec);
						if (83370 - 455739 != -372368)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060056B2 RID: 22194 RVA: 0x00A7369C File Offset: 0x00A7189C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056B3 RID: 22195 RVA: 0x00A736A0 File Offset: 0x00A718A0
	internal static bool sKdcHE5zHv35RKnd4glf()
	{
		return true;
	}

	// Token: 0x060056B4 RID: 22196 RVA: 0x00A736A4 File Offset: 0x00A718A4
	internal static bool cJRtV95zWrjUNjIW2ypP()
	{
		return false;
	}

	// Token: 0x04005F40 RID: 24384
	public float blinking_time;

	// Token: 0x04005F41 RID: 24385
	private float vyicJAQUGwI;

	// Token: 0x04005F42 RID: 24386
	private Vector2 dvDcJ9EVvec;
}
