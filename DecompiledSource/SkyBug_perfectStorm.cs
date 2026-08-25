using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020001FC RID: 508
[Serializable]
public class SkyBug_perfectStorm : MonoBehaviour
{
	// Token: 0x06000B76 RID: 2934 RVA: 0x001280C4 File Offset: 0x001262C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SkyBug_perfectStorm()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x001280D4 File Offset: 0x001262D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		if (157439 - 379612 != -222172)
		{
		}
		for (;;)
		{
			this.Yb4edn9Oyy = nOwner;
			if (140279 - 137672 == 2607)
			{
				if (!this.Yb4edn9Oyy)
				{
					break;
				}
				if (85919 - 366951 != -281031)
				{
					this.KeGegKnUdg = (CharacterControl)this.Yb4edn9Oyy.GetComponent(typeof(CharacterControl));
					if (294873 - 135361 != 159513)
					{
						this.TKFeaP41mt = (SkyBug)this.Yb4edn9Oyy.GetComponent(typeof(SkyBug));
						if (162205 - 266188 != -103982)
						{
							if (!this.KeGegKnUdg)
							{
								break;
							}
							if (163384 - 196101 != -32716)
							{
								if (!this.TKFeaP41mt)
								{
									break;
								}
								if (20588 - 461712 == -441124)
								{
									this.N5Ge4tL9ab = true;
									if (281274 - 254230 == 27044)
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
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00128240 File Offset: 0x00126440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider nCollider)
	{
		if (120623 - 237689 != -117066)
		{
		}
		for (;;)
		{
			if (!this.N5Ge4tL9ab)
			{
				if (202680 - 449104 != -246423)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = nCollider.gameObject;
				if (58274 - 149713 == -91439)
				{
					if (!gameObject)
					{
						break;
					}
					if (272598 - 22647 != 249952)
					{
						if (!(gameObject.tag == "Player"))
						{
							if (98434 - 198224 == -99789)
							{
								continue;
							}
							if (!(gameObject.tag == "Enemy"))
							{
								break;
							}
							if (138480 - 522537 == -384056)
							{
								continue;
							}
						}
						if (gameObject.layer == this.Yb4edn9Oyy.layer)
						{
							break;
						}
						if (98043 - 284457 != -186413)
						{
							if (gameObject.layer == 2)
							{
								if (257083 - 464696 != -207612)
								{
									break;
								}
							}
							else
							{
								if (!this.KeGegKnUdg)
								{
									break;
								}
								if (53287 - 566057 != -512769)
								{
									if (!this.KeGegKnUdg.isMine)
									{
										break;
									}
									if (48934 - 458846 != -409911)
									{
										if (this.TKFeaP41mt)
										{
											if (22337 - 121926 == -99588)
											{
												continue;
											}
											this.TKFeaP41mt.RPC_perfectStorm_hit(gameObject.transform.position + Vector3.up, this.transform.forward, 0);
											if (290539 - 360534 != -69995)
											{
												continue;
											}
											this.TKFeaP41mt.ActionEvent("RPC_perfectStorm_hit", gameObject.transform.position + Vector3.up, this.transform.forward, 0);
											if (81664 - 510208 != -428544)
											{
												continue;
											}
										}
										this.KeGegKnUdg.hit(40, gameObject, this.KeGegKnUdg.talAdjust(120), 10, 0, (float)2 * Vector3.up);
										if (124103 - 193387 == -69284)
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
		}
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x001284F8 File Offset: 0x001266F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x001284FC File Offset: 0x001266FC
	internal static bool O7LIdYW2FgtGSgOKjy9()
	{
		return true;
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x00128500 File Offset: 0x00126700
	internal static bool KwDWpRW8LPrspBrx2YZ()
	{
		return false;
	}

	// Token: 0x04000A37 RID: 2615
	private GameObject Yb4edn9Oyy;

	// Token: 0x04000A38 RID: 2616
	private CharacterControl KeGegKnUdg;

	// Token: 0x04000A39 RID: 2617
	private SkyBug TKFeaP41mt;

	// Token: 0x04000A3A RID: 2618
	private bool N5Ge4tL9ab;
}
