using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200209A RID: 8346
[RequireComponent(typeof(MeshFilter))]
[AddComponentMenu("Particles/Bolt Emitter")]
[RequireComponent(typeof(MeshRenderer))]
[Serializable]
public class BoltEmitter : MonoBehaviour
{
	// Token: 0x0600C34F RID: 49999 RVA: 0x01475B24 File Offset: 0x01473D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BoltEmitter()
	{
		if (237172 - 553486 != -316314)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (98532 - 317884 == -219352)
			{
				base..ctor();
				if (157183 - 275363 != -118179)
				{
					this.Height = 0.5f;
					if (269981 - 245295 == 24686)
					{
						this.StartWidth = 0.1f;
						if (121998 - 366633 == -244635)
						{
							this.EndWidth = 0.1f;
							if (116683 - 518483 == -401800)
							{
								this.Width1 = 0.1f;
								if (221481 - 189586 != 31896)
								{
									this.Width2 = 0.1f;
									if (167868 - 471114 != -303245)
									{
										this.Width3 = 0.1f;
										if (68644 - 170041 == -101397)
										{
											this.Width4 = 0.1f;
											if (299815 - 206940 == 92875)
											{
												this.Width5 = 0.1f;
												if (128727 - 103714 != 25014)
												{
													this.rndZigg = 0.2f;
													if (28222 - 440625 != -412402)
													{
														this.Color1 = new Color((float)1, (float)1, (float)1, 0.04f);
														if (172838 - 79680 == 93158)
														{
															this.Color2 = new Color((float)1, (float)1, (float)1, 0.3f);
															if (12263 - 263673 == -251410)
															{
																this.Color3 = new Color((float)1, (float)1, (float)1, 0.45f);
																if (224724 - 9187 == 215537)
																{
																	this.Color4 = new Color((float)1, (float)1, (float)1, 0.3f);
																	if (173110 - 119412 != 53699)
																	{
																		this.Color5 = new Color((float)1, (float)1, (float)1, 0.04f);
																		if (33981 - 173578 != -139596)
																		{
																			this.BoltCount = 1;
																			if (116707 - 313073 == -196366)
																			{
																				this.nGVnTfiwS4c = 0.01f;
																				if (37493 - 460352 == -422859)
																				{
																					this.GmwnTLi0NGV = 50f;
																					if (32728 - 579159 == -546431)
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
					}
				}
			}
		}
	}

	// Token: 0x0600C350 RID: 50000 RVA: 0x01475E44 File Offset: 0x01474044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (298424 - 32819 != 265605)
		{
		}
		for (;;)
		{
			this.lMtnTNCnJKQ = (MeshFilter)this.gameObject.GetComponent(typeof(MeshFilter));
			if (268466 - 86404 == 182062)
			{
				if (!this.lMtnTNCnJKQ)
				{
					if (212767 - 551390 != -338622)
					{
						Debug.Log("Image Emitter Error : MeshFilter doesn't exist");
						if (220484 - 274069 != -53584)
						{
							this.enabled = false;
							if (226273 - 191464 == 34809)
							{
								break;
							}
						}
					}
				}
				else
				{
					this.a04nTw9BVsc = this.transform;
					if (4071 - 263596 != -259524)
					{
						this.uGknTUTFv8r = Camera.main.transform;
						if (258999 - 46583 == 212416)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C351 RID: 50001 RVA: 0x01475F7C File Offset: 0x0147417C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (89053 - 195841 != -106787)
		{
		}
		for (;;)
		{
			IL_A85:
			if (this.TargetCollider)
			{
				if (166259 - 130140 != 36119)
				{
					continue;
				}
				this.TargetPosition = this.TargetCollider.bounds.center;
				if (214646 - 461314 == -246667)
				{
					continue;
				}
			}
			if (this.TargetObject)
			{
				if (115716 - 309786 != -194070)
				{
					continue;
				}
				this.TargetPosition = this.TargetObject.transform.position;
				if (53194 - 439860 != -386666)
				{
					continue;
				}
			}
			Vector3 vector = this.a04nTw9BVsc.InverseTransformDirection((this.TargetPosition - this.a04nTw9BVsc.position).normalized);
			if (170700 - 359409 != -188708)
			{
				Vector3 a = this.a04nTw9BVsc.InverseTransformDirection(Vector3.Cross(vector, this.uGknTUTFv8r.forward));
				if (271090 - 89887 != 181204)
				{
					Vector3 vector2 = this.TargetPosition - this.a04nTw9BVsc.position;
					if (43444 - 239581 != -196136)
					{
						float magnitude = vector2.magnitude;
						if (179048 - 96613 == 82435)
						{
							int num = global::Math.divf(magnitude, this.Height) + 1;
							if (252235 - 8471 == 243764)
							{
								if (magnitude <= this.nGVnTfiwS4c)
								{
									break;
								}
								if (61600 - 35283 == 26317)
								{
									if (magnitude >= this.GmwnTLi0NGV)
									{
										break;
									}
									if (279864 - 217380 == 62484)
									{
										Vector3[] array = new Vector3[num * this.BoltCount * 2];
										if (295781 - 358850 != -63068)
										{
											Vector2[] array2 = new Vector2[num * this.BoltCount * 2];
											if (126927 - 379973 != -253045)
											{
												Color[] array3 = new Color[num * this.BoltCount * 2];
												if (252154 - 462345 == -210191)
												{
													int[] array4 = new int[(num - 1) * this.BoltCount * 6];
													if (103946 - 558801 == -454855)
													{
														Mesh mesh = this.lMtnTNCnJKQ.mesh;
														if (91304 - 323071 != -231766)
														{
															mesh.Clear();
															if (240562 - 484720 != -244157)
															{
																int i = 0;
																if (213602 - 168649 == 44953)
																{
																	while (i < this.BoltCount)
																	{
																		float num2 = (float)0;
																		if (134982 - 576176 == -441193)
																		{
																			goto IL_A85;
																		}
																		int j = i * (num + 1);
																		if (279113 - 540311 == -261197)
																		{
																			goto IL_A85;
																		}
																		while (j < (i + 1) * num)
																		{
																			float num3 = (float)(j - i * num);
																			if (77300 - 462732 != -385432)
																			{
																				goto IL_A85;
																			}
																			float num4 = num3 / (float)num;
																			if (233239 - 121867 == 111373)
																			{
																				goto IL_A85;
																			}
																			float num5 = Mathf.Lerp(this.StartWidth, this.EndWidth, num4) + UnityEngine.Random.Range((float)0, this.rndWidth);
																			if (141333 - 301708 != -160375)
																			{
																				goto IL_A85;
																			}
																			float num6 = (float)0;
																			if (172715 - 149185 == 23531)
																			{
																				goto IL_A85;
																			}
																			Color color = default(Color);
																			if (69797 - 438528 == -368730)
																			{
																				goto IL_A85;
																			}
																			if (num4 < 0.25f)
																			{
																				if (79387 - 11763 != 67624)
																				{
																					goto IL_A85;
																				}
																				num6 = Mathf.Lerp(this.Width1, this.Width2, (float)4 * num4);
																				if (219554 - 30597 == 188958)
																				{
																					goto IL_A85;
																				}
																				num2 = Mathf.Clamp(num2 + UnityEngine.Random.Range(-this.rndZigg, this.rndZigg), -num6, num6);
																				if (72018 - 198550 == -126531)
																				{
																					goto IL_A85;
																				}
																				color = Color.Lerp(this.Color1, this.Color2, (float)4 * num4);
																				if (78145 - 514640 == -436494)
																				{
																					goto IL_A85;
																				}
																			}
																			else if (num4 < 0.5f)
																			{
																				if (125555 - 188323 == -62767)
																				{
																					goto IL_A85;
																				}
																				num6 = Mathf.Lerp(this.Width2, this.Width3, (float)4 * (num4 - 0.25f));
																				if (65841 - 178689 == -112847)
																				{
																					goto IL_A85;
																				}
																				num2 = Mathf.Clamp(num2 + UnityEngine.Random.Range(-this.rndZigg, this.rndZigg), -num6, num6);
																				if (135622 - 117475 != 18147)
																				{
																					goto IL_A85;
																				}
																				color = Color.Lerp(this.Color2, this.Color3, (float)4 * (num4 - 0.25f));
																				if (163419 - 75121 != 88298)
																				{
																					goto IL_A85;
																				}
																			}
																			else if (num4 < 0.75f)
																			{
																				if (130149 - 285438 != -155289)
																				{
																					goto IL_A85;
																				}
																				num6 = Mathf.Lerp(this.Width3, this.Width4, (float)4 * (num4 - 0.5f));
																				if (256312 - 470434 == -214121)
																				{
																					goto IL_A85;
																				}
																				num2 = Mathf.Clamp(num2 + UnityEngine.Random.Range(-this.rndZigg, this.rndZigg), -num6, num6);
																				if (164726 - 355780 != -191054)
																				{
																					goto IL_A85;
																				}
																				color = Color.Lerp(this.Color3, this.Color4, (float)4 * (num4 - 0.5f));
																				if (241852 - 474078 != -232226)
																				{
																					goto IL_A85;
																				}
																			}
																			else
																			{
																				num6 = Mathf.Lerp(this.Width4, this.Width5, (float)4 * (num4 - 0.75f));
																				if (67808 - 588366 == -520557)
																				{
																					goto IL_A85;
																				}
																				num2 = Mathf.Clamp(num2 + UnityEngine.Random.Range(-this.rndZigg, this.rndZigg), -num6, num6);
																				if (81588 - 365089 == -283500)
																				{
																					goto IL_A85;
																				}
																				color = Color.Lerp(this.Color4, this.Color5, (float)4 * (num4 - 0.75f));
																				if (57623 - 333946 == -276322)
																				{
																					goto IL_A85;
																				}
																			}
																			array[j * 2 + 0] = num3 * vector * this.Height - (num5 - num2) * a;
																			if (204952 - 452494 == -247541)
																			{
																				goto IL_A85;
																			}
																			array[j * 2 + 1] = num3 * vector * this.Height + (num5 + num2) * a;
																			if (186748 - 46522 != 140226)
																			{
																				goto IL_A85;
																			}
																			array2[j * 2 + 0] = new Vector2(num4, (float)0);
																			if (122335 - 93777 == 28559)
																			{
																				goto IL_A85;
																			}
																			array2[j * 2 + 1] = new Vector2(num4, (float)1);
																			if (291981 - 426291 != -134310)
																			{
																				goto IL_A85;
																			}
																			array3[j * 2 + 0] = color;
																			if (241198 - 277868 != -36670)
																			{
																				goto IL_A85;
																			}
																			array3[j * 2 + 1] = color;
																			if (155599 - 516603 != -361004)
																			{
																				goto IL_A85;
																			}
																			j++;
																			if (105815 - 539280 != -433465)
																			{
																				goto IL_A85;
																			}
																		}
																		if (100599 - 188730 == -88130)
																		{
																			goto IL_A85;
																		}
																		j = i * num;
																		if (284553 - 236592 == 47962)
																		{
																			goto IL_A85;
																		}
																		while (j < (i + 1) * (num - 1))
																		{
																			array4[j * 6 + 0] = j * 2;
																			if (103650 - 92414 == 11237)
																			{
																				goto IL_A85;
																			}
																			array4[j * 6 + 1] = j * 2 + 1;
																			if (221572 - 271246 != -49674)
																			{
																				goto IL_A85;
																			}
																			array4[j * 6 + 2] = j * 2 + 2;
																			if (255780 - 594535 == -338754)
																			{
																				goto IL_A85;
																			}
																			array4[j * 6 + 3] = j * 2 + 2;
																			if (72123 - 464712 == -392588)
																			{
																				goto IL_A85;
																			}
																			array4[j * 6 + 4] = j * 2 + 1;
																			if (285106 - 343407 == -58300)
																			{
																				goto IL_A85;
																			}
																			array4[j * 6 + 5] = j * 2 + 3;
																			if (271004 - 165098 == 105907)
																			{
																				goto IL_A85;
																			}
																			j++;
																			if (166209 - 236572 != -70363)
																			{
																				goto IL_A85;
																			}
																		}
																		if (281732 - 499026 != -217294)
																		{
																			goto IL_A85;
																		}
																		i++;
																		if (62722 - 335504 == -272781)
																		{
																			goto IL_A85;
																		}
																	}
																	if (44684 - 145083 != -100398)
																	{
																		mesh.vertices = array;
																		if (278440 - 467796 == -189356)
																		{
																			mesh.colors = array3;
																			if (120072 - 207635 == -87563)
																			{
																				mesh.uv = array2;
																				if (178003 - 155444 != 22560)
																				{
																					mesh.triangles = array4;
																					if (248848 - 245074 == 3774)
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
					}
				}
			}
		}
	}

	// Token: 0x0600C352 RID: 50002 RVA: 0x01476AD4 File Offset: 0x01474CD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C353 RID: 50003 RVA: 0x01476AD8 File Offset: 0x01474CD8
	internal static bool dAOmJLtoklTXjQ4rnEf9()
	{
		return true;
	}

	// Token: 0x0600C354 RID: 50004 RVA: 0x01476ADC File Offset: 0x01474CDC
	internal static bool e4Fm27toGeA77b81P3se()
	{
		return false;
	}

	// Token: 0x0400A592 RID: 42386
	public Vector3 TargetPosition;

	// Token: 0x0400A593 RID: 42387
	public GameObject TargetObject;

	// Token: 0x0400A594 RID: 42388
	public Collider TargetCollider;

	// Token: 0x0400A595 RID: 42389
	public float Height;

	// Token: 0x0400A596 RID: 42390
	public float StartWidth;

	// Token: 0x0400A597 RID: 42391
	public float EndWidth;

	// Token: 0x0400A598 RID: 42392
	public float Width1;

	// Token: 0x0400A599 RID: 42393
	public float Width2;

	// Token: 0x0400A59A RID: 42394
	public float Width3;

	// Token: 0x0400A59B RID: 42395
	public float Width4;

	// Token: 0x0400A59C RID: 42396
	public float Width5;

	// Token: 0x0400A59D RID: 42397
	public float rndWidth;

	// Token: 0x0400A59E RID: 42398
	public float rndZigg;

	// Token: 0x0400A59F RID: 42399
	public Color Color1;

	// Token: 0x0400A5A0 RID: 42400
	public Color Color2;

	// Token: 0x0400A5A1 RID: 42401
	public Color Color3;

	// Token: 0x0400A5A2 RID: 42402
	public Color Color4;

	// Token: 0x0400A5A3 RID: 42403
	public Color Color5;

	// Token: 0x0400A5A4 RID: 42404
	public int BoltCount;

	// Token: 0x0400A5A5 RID: 42405
	private float nGVnTfiwS4c;

	// Token: 0x0400A5A6 RID: 42406
	private float GmwnTLi0NGV;

	// Token: 0x0400A5A7 RID: 42407
	private Transform a04nTw9BVsc;

	// Token: 0x0400A5A8 RID: 42408
	private Transform uGknTUTFv8r;

	// Token: 0x0400A5A9 RID: 42409
	private MeshFilter lMtnTNCnJKQ;
}
