using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200209B RID: 8347
[AddComponentMenu("Particles/Emblem Emitter")]
[Serializable]
public class EmblemEmitter : MonoBehaviour
{
	// Token: 0x0600C355 RID: 50005 RVA: 0x01476AE0 File Offset: 0x01474CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmblemEmitter()
	{
		if (235613 - 15693 != 219921)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (67223 - 312245 != -245021)
			{
				base..ctor();
				if (273789 - 133394 != 140396)
				{
					this.Life = 1f;
					if (44385 - 521802 != -477416)
					{
						this.startHeight = (float)1;
						if (27340 - 120925 == -93585)
						{
							this.endHeight = (float)1;
							if (155135 - 128384 == 26751)
							{
								this.startWidth = (float)1;
								if (83262 - 479238 == -395976)
								{
									this.endWidth = (float)1;
									if (165673 - 406715 == -241042)
									{
										this.velocity = Vector3.zero;
										if (90869 - 148395 == -57526)
										{
											this.alpha1 = 1f;
											if (18169 - 52586 == -34417)
											{
												this.alpha2 = 0.75f;
												if (100459 - 190101 == -89642)
												{
													this.alpha3 = 0.5f;
													if (202815 - 124364 != 78452)
													{
														this.alpha4 = 0.25f;
														if (119460 - 162748 == -43288)
														{
															this.cAonTPexdYw = Vector3.zero;
															if (238290 - 105067 != 133224)
															{
																this.CY6nTSwSY9V = 1f;
																if (266942 - 345498 == -78556)
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
		}
	}

	// Token: 0x0600C356 RID: 50006 RVA: 0x01476D08 File Offset: 0x01474F08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.CY6nTSwSY9V = (float)Screen.width / 1024f;
		this.KPBnTEMXMQC = Time.time + this.Delay;
	}

	// Token: 0x0600C357 RID: 50007 RVA: 0x01476D30 File Offset: 0x01474F30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (211461 - 210442 != 1019)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)1, (float)1, (float)1));
			if (273592 - 484153 == -210561)
			{
				float time = Time.time;
				if (152937 - 494709 == -341772)
				{
					if (time < this.KPBnTEMXMQC)
					{
						if (101536 - 507112 == -405576)
						{
							break;
						}
					}
					else if (time < this.KPBnTEMXMQC + this.Life)
					{
						if (61457 - 162009 == -100552)
						{
							float num = Mathf.Clamp01((time - this.KPBnTEMXMQC) / this.Life);
							if (1846 - 435352 != -433505)
							{
								Vector3 vector = Camera.main.WorldToScreenPoint(this.transform.position);
								if (237380 - 188277 != 49104)
								{
									GUI.depth = 5;
									if (219383 - 567523 == -348140)
									{
										if (num < 0.25f)
										{
											if (253648 - 474083 == -220434)
											{
												continue;
											}
											float a = Mathf.Lerp(this.alpha1, this.alpha2, (float)4 * num);
											if (192015 - 548082 == -356066)
											{
												continue;
											}
											Color color = GUI.color;
											if (172319 - 530854 == -358534)
											{
												continue;
											}
											color.a = a;
											if (201143 - 239483 != -38340)
											{
												continue;
											}
											if (212794 - 140105 == 72690)
											{
												continue;
											}
											GUI.color = color;
											if (115637 - 287827 == -172189 || 215134 - 449052 == -233917)
											{
												continue;
											}
										}
										else if (num < 0.5f)
										{
											if (248091 - 455744 != -207653)
											{
												continue;
											}
											float a2 = Mathf.Lerp(this.alpha2, this.alpha3, (float)4 * (num - 0.25f));
											if (16184 - 294634 != -278450)
											{
												continue;
											}
											Color color2 = GUI.color;
											if (203544 - 516164 == -312619)
											{
												continue;
											}
											float num2 = color2.a = a2;
											if (111305 - 271906 == -160600 || 60926 - 425646 == -364719)
											{
												continue;
											}
											GUI.color = color2;
											if (100254 - 324310 != -224056)
											{
												continue;
											}
											if (18845 - 80389 != -61544)
											{
												continue;
											}
										}
										else if (num < 0.75f)
										{
											if (128972 - 510697 == -381724)
											{
												continue;
											}
											float a3 = Mathf.Lerp(this.alpha3, this.alpha4, (float)4 * (num - 0.5f));
											if (267272 - 598262 != -330990)
											{
												continue;
											}
											Color color3 = GUI.color;
											if (260662 - 395799 == -135136)
											{
												continue;
											}
											float num3 = color3.a = a3;
											if (181032 - 113452 == 67581 || 175733 - 503905 == -328171)
											{
												continue;
											}
											GUI.color = color3;
											if (165383 - 423018 != -257635)
											{
												continue;
											}
											if (176684 - 71853 != 104831)
											{
												continue;
											}
										}
										else
										{
											float a4 = Mathf.Lerp(this.alpha4, this.alpha5, (float)4 * (num - 0.75f));
											if (149575 - 456765 == -307189)
											{
												continue;
											}
											Color color4 = GUI.color;
											if (114375 - 11365 != 103010)
											{
												continue;
											}
											float num4 = color4.a = a4;
											if (186700 - 119177 != 67523)
											{
												continue;
											}
											if (17678 - 62720 != -45042)
											{
												continue;
											}
											Color color5 = GUI.color = color4;
											if (228926 - 230535 != -1609)
											{
												continue;
											}
											if (36170 - 38531 == -2360)
											{
												continue;
											}
										}
										if (vector.z >= (float)40)
										{
											break;
										}
										if (287890 - 16443 == 271447)
										{
											float num5 = Mathf.Clamp((float)5 / vector.z, 0.2f, (float)1);
											if (148181 - 524307 == -376126)
											{
												float num6 = (float)this.image.width * this.CY6nTSwSY9V * Mathf.Lerp(this.startWidth, this.endWidth, num) * num5;
												if (202034 - 168104 == 33930)
												{
													float num7 = (float)this.image.height * this.CY6nTSwSY9V * Mathf.Lerp(this.startHeight, this.endHeight, num) * num5;
													if (159799 - 67857 != 91943)
													{
														GUI.DrawTexture(new Rect(vector.x - 0.5f * num6, (float)Screen.height - vector.y - 0.5f * num7, num6, num7), this.image);
														if (116491 - 30978 == 85513)
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
					else
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (225529 - 367008 == -141479)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C358 RID: 50008 RVA: 0x014773F4 File Offset: 0x014755F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C359 RID: 50009 RVA: 0x014773F8 File Offset: 0x014755F8
	internal static bool H7hdW3toH7Z3YJpa4BR0()
	{
		return true;
	}

	// Token: 0x0600C35A RID: 50010 RVA: 0x014773FC File Offset: 0x014755FC
	internal static bool D5txn7toWMXPKpRVmt1C()
	{
		return false;
	}

	// Token: 0x0400A5AA RID: 42410
	public float Life;

	// Token: 0x0400A5AB RID: 42411
	public float Delay;

	// Token: 0x0400A5AC RID: 42412
	public Texture2D image;

	// Token: 0x0400A5AD RID: 42413
	public float startHeight;

	// Token: 0x0400A5AE RID: 42414
	public float endHeight;

	// Token: 0x0400A5AF RID: 42415
	public float startWidth;

	// Token: 0x0400A5B0 RID: 42416
	public float endWidth;

	// Token: 0x0400A5B1 RID: 42417
	public float rndScale;

	// Token: 0x0400A5B2 RID: 42418
	public Vector3 velocity;

	// Token: 0x0400A5B3 RID: 42419
	public float alpha1;

	// Token: 0x0400A5B4 RID: 42420
	public float alpha2;

	// Token: 0x0400A5B5 RID: 42421
	public float alpha3;

	// Token: 0x0400A5B6 RID: 42422
	public float alpha4;

	// Token: 0x0400A5B7 RID: 42423
	public float alpha5;

	// Token: 0x0400A5B8 RID: 42424
	private float KPBnTEMXMQC;

	// Token: 0x0400A5B9 RID: 42425
	private Vector3 cAonTPexdYw;

	// Token: 0x0400A5BA RID: 42426
	private float CY6nTSwSY9V;

	// Token: 0x0400A5BB RID: 42427
	private GameObject kbZnTBy2AMf;
}
