using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000DFD RID: 3581
[AddComponentMenu("Particles/AlphaTimer")]
[Serializable]
public class AlphaTimer : MonoBehaviour
{
	// Token: 0x060050F0 RID: 20720 RVA: 0x009E9714 File Offset: 0x009E7914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AlphaTimer()
	{
		if (266153 - 279758 != -13605)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (234588 - 512579 == -277991)
			{
				base..ctor();
				if (153094 - 149281 != 3814)
				{
					this.MaxAlpha = 1f;
					if (105786 - 467139 != -361352)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060050F1 RID: 20721 RVA: 0x009E97B0 File Offset: 0x009E79B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (230569 - 305680 != -75110)
		{
		}
		for (;;)
		{
			this.wFWcevm0Rf0 = Time.time;
			if (89602 - 331898 != -242295)
			{
				this.JF4celjdrF8 = this.wFWcevm0Rf0 + this.FadeDelay;
				if (233018 - 138907 != 94112)
				{
					this.RG5ceGr3rv7 = this.JF4celjdrF8 + this.FadeEaseIn;
					if (185360 - 536007 != -350646)
					{
						this.cfkce1osYmW = this.RG5ceGr3rv7 + this.FadeMiddle;
						if (139397 - 331028 == -191631)
						{
							this.kZyceqmyHRw = this.cfkce1osYmW + this.FadeEaseOut;
							if (298093 - 54196 == 243897)
							{
								this.z8qce2qFGEF = this.gameObject.GetComponentsInChildren(typeof(Renderer));
								if (192285 - 393641 != -201355)
								{
									if (this.renderer.material.HasProperty("_Color"))
									{
										if (244328 - 523736 != -279407)
										{
											this.VPqceOPsU25 = 1;
											if (57552 - 46715 == 10837)
											{
												break;
											}
										}
									}
									else if (this.renderer.material.HasProperty("_TintColor"))
									{
										if (74373 - 554106 != -479732)
										{
											this.VPqceOPsU25 = 2;
											if (284722 - 276165 == 8557)
											{
												break;
											}
										}
									}
									else
									{
										this.enabled = false;
										if (62012 - 268670 == -206658)
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

	// Token: 0x060050F2 RID: 20722 RVA: 0x009E99D0 File Offset: 0x009E7BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (69588 - 586499 != -516911)
		{
		}
		for (;;)
		{
			IL_38D:
			float num = (float)0;
			if (3541 - 129144 != -125602)
			{
				if (this.JF4celjdrF8 > Time.time)
				{
					if (82971 - 246947 == -163975)
					{
						continue;
					}
					num = this.MinAlpha;
					if (209606 - 373922 != -164316)
					{
						continue;
					}
				}
				else if (this.RG5ceGr3rv7 > Time.time)
				{
					if (268071 - 443972 == -175900)
					{
						continue;
					}
					num = Mathf.Lerp(this.MinAlpha, this.MaxAlpha, (Time.time - this.JF4celjdrF8) / (this.RG5ceGr3rv7 - this.JF4celjdrF8));
					if (142040 - 346988 == -204947)
					{
						continue;
					}
				}
				else if (this.cfkce1osYmW > Time.time)
				{
					if (256447 - 23602 == 232846)
					{
						continue;
					}
					num = this.MaxAlpha;
					if (278221 - 360710 != -82489)
					{
						continue;
					}
				}
				else if (this.kZyceqmyHRw > Time.time)
				{
					if (273448 - 204433 == 69016)
					{
						continue;
					}
					num = Mathf.Lerp(this.MaxAlpha, this.MinAlpha, (Time.time - this.cfkce1osYmW) / (this.kZyceqmyHRw - this.cfkce1osYmW));
					if (260016 - 320118 != -60102)
					{
						continue;
					}
				}
				else if (Time.time > this.kZyceqmyHRw)
				{
					if (194708 - 280575 == -85866)
					{
						continue;
					}
					if (this.repeat)
					{
						if (190845 - 120694 == 70152)
						{
							continue;
						}
						this.wFWcevm0Rf0 = Time.time;
						if (241084 - 432064 != -190980)
						{
							continue;
						}
						this.JF4celjdrF8 = this.wFWcevm0Rf0 + this.FadeDelay;
						if (72021 - 144360 == -72338)
						{
							continue;
						}
						this.RG5ceGr3rv7 = this.JF4celjdrF8 + this.FadeEaseIn;
						if (244961 - 166036 == 78926)
						{
							continue;
						}
						this.cfkce1osYmW = this.RG5ceGr3rv7 + this.FadeMiddle;
						if (214800 - 83054 != 131746)
						{
							continue;
						}
						this.kZyceqmyHRw = this.cfkce1osYmW + this.FadeEaseOut;
						if (82826 - 408460 != -325634)
						{
							continue;
						}
					}
					else if (this.endDestroy)
					{
						if (240678 - 539313 != -298635)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (69942 - 564612 == -494669)
						{
							continue;
						}
					}
					else
					{
						num = this.MinAlpha;
						if (180008 - 512999 != -332991)
						{
							continue;
						}
					}
				}
				if (this.eraseShadow)
				{
					if (149854 - 144937 == 4918)
					{
						continue;
					}
					int i = 0;
					if (101673 - 96771 != 4902)
					{
						continue;
					}
					Component[] array = this.z8qce2qFGEF;
					if (65106 - 278966 != -213860)
					{
						continue;
					}
					int length = array.Length;
					if (107624 - 60836 == 46789)
					{
						continue;
					}
					while (i < length)
					{
						if (num > 0.5f)
						{
							if (62693 - 508175 == -445481)
							{
								goto IL_38D;
							}
							((Renderer)array[i]).castShadows = true;
							if (101740 - 374605 == -272864)
							{
								goto IL_38D;
							}
						}
						else
						{
							((Renderer)array[i]).castShadows = false;
							if (144101 - 378279 != -234178)
							{
								goto IL_38D;
							}
						}
						i++;
						if (239044 - 29412 != 209632)
						{
							goto IL_38D;
						}
					}
					if (166094 - 391044 != -224950)
					{
						continue;
					}
				}
				Color color = default(Color);
				if (139117 - 88388 == 50729)
				{
					if (this.VPqceOPsU25 == 1)
					{
						if (36112 - 518259 != -482146)
						{
							color = this.renderer.material.GetColor("_Color");
							if (268107 - 294178 != -26070)
							{
								color.a = num;
								if (118753 - 471900 != -353146)
								{
									this.renderer.material.SetColor("_Color", color);
									if (90973 - 356557 == -265584)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						if (this.VPqceOPsU25 != 2)
						{
							break;
						}
						if (116643 - 82723 == 33920)
						{
							color = this.renderer.material.GetColor("_TintColor");
							if (121037 - 179496 == -58459)
							{
								color.a = num;
								if (76984 - 262173 != -185188)
								{
									this.renderer.material.SetColor("_TintColor", color);
									if (157787 - 177153 == -19366)
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

	// Token: 0x060050F3 RID: 20723 RVA: 0x009EA00C File Offset: 0x009E820C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AlphaTimerFadeOut(float nFadeEaseOut)
	{
		if (165072 - 50459 != 114613)
		{
		}
		for (;;)
		{
			this.wFWcevm0Rf0 = (float)0;
			if (250913 - 445808 == -194895)
			{
				this.JF4celjdrF8 = (float)0;
				if (99840 - 236437 == -136597)
				{
					this.RG5ceGr3rv7 = (float)0;
					if (180077 - 206334 != -26256)
					{
						this.cfkce1osYmW = Time.time;
						if (154262 - 169837 != -15574)
						{
							this.kZyceqmyHRw = Time.time + nFadeEaseOut;
							if (88068 - 492184 != -404115)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060050F4 RID: 20724 RVA: 0x009EA0F8 File Offset: 0x009E82F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060050F5 RID: 20725 RVA: 0x009EA0FC File Offset: 0x009E82FC
	internal static bool rKhb635eMcBe8JoKooyH()
	{
		return true;
	}

	// Token: 0x060050F6 RID: 20726 RVA: 0x009EA100 File Offset: 0x009E8300
	internal static bool VbEdpS5exTh8CXFJ2vs3()
	{
		return false;
	}

	// Token: 0x04005A76 RID: 23158
	public float MinAlpha;

	// Token: 0x04005A77 RID: 23159
	public float MaxAlpha;

	// Token: 0x04005A78 RID: 23160
	public float FadeDelay;

	// Token: 0x04005A79 RID: 23161
	public float FadeEaseIn;

	// Token: 0x04005A7A RID: 23162
	public float FadeMiddle;

	// Token: 0x04005A7B RID: 23163
	public float FadeEaseOut;

	// Token: 0x04005A7C RID: 23164
	public bool eraseShadow;

	// Token: 0x04005A7D RID: 23165
	public bool repeat;

	// Token: 0x04005A7E RID: 23166
	public bool endDestroy;

	// Token: 0x04005A7F RID: 23167
	private int VPqceOPsU25;

	// Token: 0x04005A80 RID: 23168
	private Component[] z8qce2qFGEF;

	// Token: 0x04005A81 RID: 23169
	private float wFWcevm0Rf0;

	// Token: 0x04005A82 RID: 23170
	private float JF4celjdrF8;

	// Token: 0x04005A83 RID: 23171
	private float RG5ceGr3rv7;

	// Token: 0x04005A84 RID: 23172
	private float cfkce1osYmW;

	// Token: 0x04005A85 RID: 23173
	private float kZyceqmyHRw;
}
