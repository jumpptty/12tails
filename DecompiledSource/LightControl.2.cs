using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FAB RID: 4011
[Serializable]
public class LightControl : MonoBehaviour
{
	// Token: 0x06005B57 RID: 23383 RVA: 0x00B2AC1C File Offset: 0x00B28E1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightControl()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005B58 RID: 23384 RVA: 0x00B2AC2C File Offset: 0x00B28E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.WMmcOKDJ8hO = (Light)this.GetComponent(typeof(Light));
	}

	// Token: 0x06005B59 RID: 23385 RVA: 0x00B2AC4C File Offset: 0x00B28E4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (124507 - 356635 != -232127)
		{
		}
		for (;;)
		{
			this.uSpcOzw4w4Y += Time.deltaTime;
			if (7078 - 348848 != -341769)
			{
				if (!this.WMmcOKDJ8hO)
				{
					break;
				}
				if (10381 - 218752 != -208370)
				{
					float num = this.uSpcOzw4w4Y / this.duration;
					if (133170 - 391116 != -257945)
					{
						float num2 = 0f;
						if (266211 - 337493 != -71281)
						{
							if (num < 0.25f)
							{
								if (76180 - 574678 != -498497)
								{
									this.WMmcOKDJ8hO.intensity = Mathf.Lerp(this.intensity1, this.intensity2, 2.5f * num);
									if (9374 - 171927 == -162553)
									{
										break;
									}
								}
							}
							else if (num < 0.5f)
							{
								if (230271 - 142266 != 88006)
								{
									this.WMmcOKDJ8hO.intensity = Mathf.Lerp(this.intensity2, this.intensity3, 2.5f * (num - 0.25f));
									if (92492 - 278390 == -185898)
									{
										break;
									}
								}
							}
							else if (num < 0.75f)
							{
								if (1382 - 91618 == -90236)
								{
									this.WMmcOKDJ8hO.intensity = Mathf.Lerp(this.intensity3, this.intensity4, 2.5f * (num - 0.5f));
									if (14510 - 233318 != -218807)
									{
										break;
									}
								}
							}
							else if (num < 1f)
							{
								if (134991 - 265512 == -130521)
								{
									this.WMmcOKDJ8hO.intensity = Mathf.Lerp(this.intensity4, this.intensity5, 2.5f * (num - 0.75f));
									if (50140 - 495010 != -444869)
									{
										break;
									}
								}
							}
							else
							{
								this.WMmcOKDJ8hO.intensity = this.intensity5;
								if (217953 - 508303 == -290350)
								{
									if (!this.isLoop)
									{
										break;
									}
									if (2570 - 220895 == -218325)
									{
										this.uSpcOzw4w4Y = (float)0;
										if (32657 - 350390 == -317733)
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

	// Token: 0x06005B5A RID: 23386 RVA: 0x00B2AF44 File Offset: 0x00B29144
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005B5B RID: 23387 RVA: 0x00B2AF48 File Offset: 0x00B29148
	internal static bool tqgCGJpN2hndxbgB3FUw()
	{
		return true;
	}

	// Token: 0x06005B5C RID: 23388 RVA: 0x00B2AF4C File Offset: 0x00B2914C
	internal static bool oAh5RIpN80cWZBoBQBlP()
	{
		return false;
	}

	// Token: 0x0400668D RID: 26253
	public float duration;

	// Token: 0x0400668E RID: 26254
	public float delay;

	// Token: 0x0400668F RID: 26255
	public float intensity1;

	// Token: 0x04006690 RID: 26256
	public float intensity2;

	// Token: 0x04006691 RID: 26257
	public float intensity3;

	// Token: 0x04006692 RID: 26258
	public float intensity4;

	// Token: 0x04006693 RID: 26259
	public float intensity5;

	// Token: 0x04006694 RID: 26260
	public bool isLoop;

	// Token: 0x04006695 RID: 26261
	private Light WMmcOKDJ8hO;

	// Token: 0x04006696 RID: 26262
	private float uSpcOzw4w4Y;
}
