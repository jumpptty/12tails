using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020005D9 RID: 1497
[Serializable]
public class Cat_grandCasinoArcade : MonoBehaviour
{
	// Token: 0x060021E9 RID: 8681 RVA: 0x003E4E74 File Offset: 0x003E3074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Cat_grandCasinoArcade()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x003E4E84 File Offset: 0x003E3084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (133129 - 336526 != -203397)
		{
		}
		for (;;)
		{
			if (this.mRenderer)
			{
				if (29334 - 443741 != -414406)
				{
					if (Extensions.get_length(this.mRenderer.materials) > 1)
					{
						if (18381 - 202487 != -184106)
						{
							continue;
						}
						this.sQpTrSb8ri = this.mRenderer.materials[1];
						if (425 - 274243 == -273817)
						{
							continue;
						}
					}
					if (Extensions.get_length(this.mRenderer.materials) > 2)
					{
						if (111282 - 427456 == -316173)
						{
							continue;
						}
						this.NH5TxXGGpM = this.mRenderer.materials[2];
						if (45133 - 473036 != -427903)
						{
							continue;
						}
					}
					if (this.sQpTrSb8ri)
					{
						if (128790 - 204050 == -75259)
						{
							continue;
						}
						if (this.NH5TxXGGpM)
						{
							break;
						}
						if (98961 - 34425 == 64537)
						{
							continue;
						}
					}
					Debug.Log("Material Error");
					if (12264 - 475491 != -463226)
					{
						break;
					}
				}
			}
			else if (59965 - 302576 != -242610)
			{
				break;
			}
		}
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x003E503C File Offset: 0x003E323C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (93596 - 324286 != -230689)
		{
		}
		for (;;)
		{
			float num = 0.15f * Mathf.Sin((float)4 * Time.time);
			if (109477 - 540474 == -430997)
			{
				if (this.sQpTrSb8ri)
				{
					if (116324 - 228033 != -111709)
					{
						continue;
					}
					this.sQpTrSb8ri.SetColor("_TintColor", new Color(0.5f, 0.5f, 0.5f, num));
					if (100839 - 109020 == -8180)
					{
						continue;
					}
				}
				if (!this.NH5TxXGGpM)
				{
					break;
				}
				if (172571 - 380233 != -207661)
				{
					this.NH5TxXGGpM.SetColor("_TintColor", new Color(0.5f, 0.5f, 0.5f, 0.15f - num));
					if (127750 - 545290 == -417540)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x003E517C File Offset: 0x003E337C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x003E5180 File Offset: 0x003E3380
	internal static bool xdy57s0A4kZWhlfJ1Rm()
	{
		return true;
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x003E5184 File Offset: 0x003E3384
	internal static bool WWvRO80lR1dliBbU2wO()
	{
		return false;
	}

	// Token: 0x04002316 RID: 8982
	public SkinnedMeshRenderer mRenderer;

	// Token: 0x04002317 RID: 8983
	private Material sQpTrSb8ri;

	// Token: 0x04002318 RID: 8984
	private Material NH5TxXGGpM;
}
