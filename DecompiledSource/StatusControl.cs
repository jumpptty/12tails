using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FB7 RID: 4023
[Serializable]
public class StatusControl : MonoBehaviour
{
	// Token: 0x06005B9E RID: 23454 RVA: 0x00B30B34 File Offset: 0x00B2ED34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StatusControl()
	{
		if (261725 - 506776 != -245051)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (200488 - 457158 == -256670)
			{
				base..ctor();
				if (45965 - 92687 == -46722)
				{
					this.PVgc2wPmyDX = "none";
					if (152853 - 261364 == -108511)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005B9F RID: 23455 RVA: 0x00B30BD0 File Offset: 0x00B2EDD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(CharacterControl nChar, string nStatus)
	{
		if (38 - 187663 != -187625)
		{
		}
		for (;;)
		{
			this.qiAc2L1XqXa = nChar;
			if (86114 - 27488 == 58626)
			{
				this.PVgc2wPmyDX = nStatus;
				if (103753 - 486657 == -382904)
				{
					this.aMDc2U1iMkF = Time.time + 0.5f;
					if (148607 - 254995 != -106387)
					{
						this.PgZc2NFbD77 = true;
						if (93476 - 185271 == -91795)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BA0 RID: 23456 RVA: 0x00B30C98 File Offset: 0x00B2EE98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (251899 - 298283 != -46383)
		{
		}
		for (;;)
		{
			if (!this.PgZc2NFbD77)
			{
				if (152079 - 577970 != -425890)
				{
					break;
				}
			}
			else
			{
				if (this.aMDc2U1iMkF >= Time.time)
				{
					break;
				}
				if (98048 - 531158 == -433110)
				{
					this.aMDc2U1iMkF = Time.time + 0.5f;
					if (60687 - 134910 == -74223)
					{
						if (!this.qiAc2L1XqXa)
						{
							if (64104 - 184571 == -120467)
							{
								UnityEngine.Object.Destroy(this.gameObject);
								if (20381 - 437150 != -416768)
								{
									break;
								}
							}
						}
						else
						{
							if (this.qiAc2L1XqXa.getStatusLv(this.PVgc2wPmyDX) > 0)
							{
								break;
							}
							if (137686 - 164711 == -27025)
							{
								UnityEngine.Object.Destroy(this.gameObject);
								if (208357 - 124254 == 84103)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BA1 RID: 23457 RVA: 0x00B30DFC File Offset: 0x00B2EFFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005BA2 RID: 23458 RVA: 0x00B30E00 File Offset: 0x00B2F000
	internal static bool rO4fh2pNP6dTAWCWt5YY()
	{
		return true;
	}

	// Token: 0x06005BA3 RID: 23459 RVA: 0x00B30E04 File Offset: 0x00B2F004
	internal static bool vlkqfZpN0GpY6xOlp8Uf()
	{
		return false;
	}

	// Token: 0x04006710 RID: 26384
	private CharacterControl qiAc2L1XqXa;

	// Token: 0x04006711 RID: 26385
	private string PVgc2wPmyDX;

	// Token: 0x04006712 RID: 26386
	private float aMDc2U1iMkF;

	// Token: 0x04006713 RID: 26387
	private bool PgZc2NFbD77;
}
