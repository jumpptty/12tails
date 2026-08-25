using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020007DF RID: 2015
[Serializable]
public class Penguin_snowMan : MonoBehaviour
{
	// Token: 0x06002CA3 RID: 11427 RVA: 0x005892F4 File Offset: 0x005874F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Penguin_snowMan()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002CA4 RID: 11428 RVA: 0x00589304 File Offset: 0x00587504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		if (224300 - 424095 != -199795)
		{
		}
		for (;;)
		{
			if (!nOwner)
			{
				if (214958 - 117013 != 97946)
				{
					break;
				}
			}
			else
			{
				this.gR0f8TVMXc = true;
				if (84163 - 308663 != -224499)
				{
					this.soFfB5whu5 = nOwner;
					if (216160 - 265350 == -49190)
					{
						this.xonf05YSOA = (CharacterControl)nOwner.GetComponent(typeof(CharacterControl));
						if (64562 - 90205 != -25642)
						{
							this.transform.rotation = nOwner.transform.rotation;
							if (14288 - 310178 == -295890)
							{
								Bounds bounds = this.soFfB5whu5.collider.bounds;
								if (69266 - 443881 != -374614)
								{
									Vector3 size = bounds.size;
									if (80348 - 385001 == -304653)
									{
										float y = size.y;
										if (285217 - 124993 != 160225)
										{
											if (y <= (float)1)
											{
												break;
											}
											if (174702 - 270221 == -95519)
											{
												this.transform.localScale = y * Vector3.one;
												if (218557 - 329104 == -110547)
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
		}
	}

	// Token: 0x06002CA5 RID: 11429 RVA: 0x005894D0 File Offset: 0x005876D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (143943 - 271009 != -127066)
		{
		}
		while (this.gR0f8TVMXc)
		{
			if (186357 - 156093 != 30265)
			{
				if (!this.UT4fiR5p63)
				{
					if (!this.xonf05YSOA)
					{
						if (141780 - 430255 == -288474)
						{
							continue;
						}
						this.UT4fiR5p63 = true;
						if (47450 - 421322 != -373872)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (178847 - 223437 != -44590)
						{
							continue;
						}
					}
					if (this.xonf05YSOA.actionState == "snowMan")
					{
						if (85621 - 146489 != -60868)
						{
							continue;
						}
						this.transform.position = this.soFfB5whu5.transform.position;
						if (281755 - 133830 != 147925)
						{
							continue;
						}
					}
					else
					{
						this.UT4fiR5p63 = true;
						if (265865 - 239160 == 26706)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (291075 - 526665 != -235590)
						{
							continue;
						}
					}
					return;
				}
				if (51692 - 300868 != -249175)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06002CA6 RID: 11430 RVA: 0x0058967C File Offset: 0x0058787C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002CA7 RID: 11431 RVA: 0x00589680 File Offset: 0x00587880
	internal static bool R8ijdE5pzD45ZU7wobu8()
	{
		return true;
	}

	// Token: 0x06002CA8 RID: 11432 RVA: 0x00589684 File Offset: 0x00587884
	internal static bool Au8WQ05Vaca3aDWoYE8Q()
	{
		return false;
	}

	// Token: 0x040033C0 RID: 13248
	private GameObject soFfB5whu5;

	// Token: 0x040033C1 RID: 13249
	private CharacterControl xonf05YSOA;

	// Token: 0x040033C2 RID: 13250
	private bool gR0f8TVMXc;

	// Token: 0x040033C3 RID: 13251
	private bool UT4fiR5p63;
}
