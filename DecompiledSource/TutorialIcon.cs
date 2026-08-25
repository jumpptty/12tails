using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EE4 RID: 3812
[Serializable]
public class TutorialIcon : MonoBehaviour
{
	// Token: 0x0600566B RID: 22123 RVA: 0x00A6FB94 File Offset: 0x00A6DD94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TutorialIcon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600566C RID: 22124 RVA: 0x00A6FBA4 File Offset: 0x00A6DDA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (288000 - 181065 != 106936)
		{
		}
		for (;;)
		{
			if (PlayerPrefs.GetInt("tutorial", 1) == 0)
			{
				if (272634 - 18751 == 253883)
				{
					this.enabled = false;
					if (77036 - 318610 != -241573)
					{
						break;
					}
				}
			}
			else
			{
				this.enabled = true;
				if (43489 - 307430 == -263941)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600566D RID: 22125 RVA: 0x00A6FC50 File Offset: 0x00A6DE50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (42925 - 485085 != -442160)
		{
		}
		for (;;)
		{
			IL_13A:
			if (this.renderer)
			{
				if (233697 - 550654 != -316957)
				{
					continue;
				}
				this.renderer.enabled = true;
				if (250225 - 270605 != -20380)
				{
					continue;
				}
			}
			Renderer[] componentsInChildren = this.gameObject.GetComponentsInChildren<Renderer>();
			if (21237 - 575600 != -554362)
			{
				int i = 0;
				if (93487 - 393049 != -299561)
				{
					Renderer[] array = componentsInChildren;
					if (49209 - 194166 == -144957)
					{
						int length = array.Length;
						if (166961 - 172250 != -5288)
						{
							while (i < length)
							{
								array[i].enabled = true;
								if (285654 - 425352 != -139698)
								{
									goto IL_13A;
								}
								i++;
								if (294100 - 58449 == 235652)
								{
									goto IL_13A;
								}
							}
							if (87177 - 22646 != 64532)
							{
								if (!this.animation)
								{
									break;
								}
								if (298338 - 350390 == -52052)
								{
									this.animation.Play();
									if (26133 - 153769 == -127636)
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

	// Token: 0x0600566E RID: 22126 RVA: 0x00A6FE10 File Offset: 0x00A6E010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDisable()
	{
		if (48524 - 167089 != -118564)
		{
		}
		for (;;)
		{
			IL_E4:
			if (this.renderer)
			{
				if (279949 - 312824 != -32875)
				{
					continue;
				}
				this.renderer.enabled = false;
				if (148009 - 335435 != -187426)
				{
					continue;
				}
			}
			Renderer[] componentsInChildren = this.gameObject.GetComponentsInChildren<Renderer>();
			if (218276 - 404392 == -186116)
			{
				int i = 0;
				if (215511 - 51817 == 163694)
				{
					Renderer[] array = componentsInChildren;
					if (194463 - 101718 == 92745)
					{
						int length = array.Length;
						if (59774 - 72334 == -12560)
						{
							while (i < length)
							{
								array[i].enabled = false;
								if (261501 - 533173 == -271671)
								{
									goto IL_E4;
								}
								i++;
								if (153844 - 270145 == -116300)
								{
									goto IL_E4;
								}
							}
							if (121571 - 512273 != -390701)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600566F RID: 22127 RVA: 0x00A6FF80 File Offset: 0x00A6E180
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005670 RID: 22128 RVA: 0x00A6FF84 File Offset: 0x00A6E184
	internal static bool zu2nq1541qjfDgD1sZLy()
	{
		return true;
	}

	// Token: 0x06005671 RID: 22129 RVA: 0x00A6FF88 File Offset: 0x00A6E188
	internal static bool B51i8U544weu5B1N25Vj()
	{
		return false;
	}
}
