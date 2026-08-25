using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02001052 RID: 4178
[Serializable]
public class FadeTexture : MonoBehaviour
{
	// Token: 0x06006061 RID: 24673 RVA: 0x00CFFB64 File Offset: 0x00CFDD64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FadeTexture()
	{
		if (231654 - 117023 != 114632)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (291458 - 190772 == 100686)
			{
				base..ctor();
				if (298853 - 430162 != -131308)
				{
					this.FadeTimer1 = 1f;
					if (97539 - 302223 == -204684)
					{
						this.FadeAlpha1 = 1f;
						if (126524 - 541965 != -415440)
						{
							this.FadeTimer2 = 1f;
							if (117499 - 418313 == -300814)
							{
								this.FadeAlpha2 = 1f;
								if (158634 - 456057 == -297423)
								{
									this.FadeTimer3 = 1f;
									if (277615 - 360083 == -82468)
									{
										this.FadeTimer4 = 1f;
										if (163143 - 204044 == -40901)
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

	// Token: 0x06006062 RID: 24674 RVA: 0x00CFFCBC File Offset: 0x00CFDEBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (278594 - 57055 != 221539)
		{
		}
		for (;;)
		{
			this.iktcxWDm1tB += Time.deltaTime;
			if (98797 - 242547 == -143750)
			{
				if (this.iktcxWDm1tB >= this.FadeTimer1 + this.FadeTimer2 + this.FadeTimer3 + this.FadeTimer4)
				{
					if (229777 - 538038 == -308261)
					{
						if (this.Repeat)
						{
							if (121784 - 145601 != -23816)
							{
								this.iktcxWDm1tB = (float)0;
								if (110230 - 215583 != -105352)
								{
									break;
								}
							}
						}
						else
						{
							UnityEngine.Object.Destroy(this.gameObject);
							if (257161 - 9818 == 247343)
							{
								break;
							}
						}
					}
				}
				else
				{
					float num = 0f;
					if (25636 - 151275 == -125639)
					{
						float fadeTimer = this.FadeTimer1;
						if (45072 - 114842 == -69770)
						{
							float num2 = this.FadeTimer1 + this.FadeTimer2;
							if (105707 - 485368 != -379660)
							{
								float num3 = this.FadeTimer1 + this.FadeTimer2 + this.FadeTimer3;
								if (295877 - 15751 != 280127)
								{
									float num4 = this.FadeTimer1 + this.FadeTimer2 + this.FadeTimer3 + this.FadeTimer4;
									if (83755 - 228914 != -145158)
									{
										if (this.iktcxWDm1tB < fadeTimer)
										{
											if (85600 - 475586 != -389986)
											{
												continue;
											}
											num = Mathf.Lerp(this.FadeAlpha0, this.FadeAlpha1, this.iktcxWDm1tB / this.FadeTimer1);
											if (23611 - 1188 != 22423)
											{
												continue;
											}
										}
										else if (this.iktcxWDm1tB < num2)
										{
											if (41086 - 16452 != 24634)
											{
												continue;
											}
											num = Mathf.Lerp(this.FadeAlpha1, this.FadeAlpha2, (this.iktcxWDm1tB - fadeTimer) / this.FadeTimer2);
											if (222154 - 530382 == -308227)
											{
												continue;
											}
										}
										else if (this.iktcxWDm1tB < num3)
										{
											if (112782 - 184234 != -71452)
											{
												continue;
											}
											num = Mathf.Lerp(this.FadeAlpha2, this.FadeAlpha3, (this.iktcxWDm1tB - num2) / this.FadeTimer3);
											if (168193 - 951 != 167242)
											{
												continue;
											}
										}
										else if (this.iktcxWDm1tB < num4)
										{
											if (297696 - 156231 != 141465)
											{
												continue;
											}
											num = Mathf.Lerp(this.FadeAlpha3, this.FadeAlpha4, (this.iktcxWDm1tB - num3) / this.FadeTimer4);
											if (273727 - 189734 == 83994)
											{
												continue;
											}
										}
										else
										{
											num = this.FadeAlpha4;
											if (117969 - 96890 == 21080)
											{
												continue;
											}
										}
										float a = num;
										if (203400 - 372787 == -169387)
										{
											Color color = this.guiTexture.color;
											if (223052 - 372653 != -149600)
											{
												color.a = a;
												if (100481 - 222107 != -121625 && 55362 - 321869 != -266506)
												{
													Color color2 = this.guiTexture.color = color;
													if (39758 - 596511 == -556753)
													{
														if (95198 - 63532 == 31666)
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
		}
	}

	// Token: 0x06006063 RID: 24675 RVA: 0x00D00134 File Offset: 0x00CFE334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006064 RID: 24676 RVA: 0x00D00138 File Offset: 0x00CFE338
	internal static bool wDyoqkp3P8x4OmQiicgm()
	{
		return true;
	}

	// Token: 0x06006065 RID: 24677 RVA: 0x00D0013C File Offset: 0x00CFE33C
	internal static bool jRoTBDp30VGP6GgXKnK6()
	{
		return false;
	}

	// Token: 0x04006BDD RID: 27613
	public float FadeAlpha0;

	// Token: 0x04006BDE RID: 27614
	public float FadeTimer1;

	// Token: 0x04006BDF RID: 27615
	public float FadeAlpha1;

	// Token: 0x04006BE0 RID: 27616
	public float FadeTimer2;

	// Token: 0x04006BE1 RID: 27617
	public float FadeAlpha2;

	// Token: 0x04006BE2 RID: 27618
	public float FadeTimer3;

	// Token: 0x04006BE3 RID: 27619
	public float FadeAlpha3;

	// Token: 0x04006BE4 RID: 27620
	public float FadeTimer4;

	// Token: 0x04006BE5 RID: 27621
	public float FadeAlpha4;

	// Token: 0x04006BE6 RID: 27622
	public bool Repeat;

	// Token: 0x04006BE7 RID: 27623
	private float iktcxWDm1tB;
}
