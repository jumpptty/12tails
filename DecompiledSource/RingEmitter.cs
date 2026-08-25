using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020020A4 RID: 8356
[RequireComponent(typeof(MeshRenderer))]
[AddComponentMenu("Particles/Ring Emitter")]
[RequireComponent(typeof(MeshFilter))]
[Serializable]
public class RingEmitter : MonoBehaviour
{
	// Token: 0x0600C376 RID: 50038 RVA: 0x0147D2CC File Offset: 0x0147B4CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RingEmitter()
	{
		if (168081 - 9584 != 158497)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (236361 - 129610 == 106751)
			{
				base..ctor();
				if (19864 - 203888 == -184024)
				{
					this.Life = 3f;
					if (65938 - 424331 != -358392)
					{
						this.Emission = (float)1;
						if (136040 - 261767 != -125726)
						{
							this.startRadius = (float)1;
							if (20255 - 504424 == -484169)
							{
								this.endRadius = (float)2;
								if (95366 - 16521 != 78846)
								{
									this.startHeight = (float)1;
									if (14745 - 197107 != -182361)
									{
										this.endHeight = (float)1;
										if (282700 - 198739 != 83962)
										{
											this.startWidth = 0.5f;
											if (26423 - 1762 == 24661)
											{
												this.endWidth = 0.5f;
												if (65604 - 152008 != -86403)
												{
													this.localVelocity = Vector3.zero;
													if (97692 - 431332 != -333639)
													{
														this.rndVelocity = Vector3.zero;
														if (149615 - 466221 != -316605)
														{
															this.Color1 = new Color((float)1, (float)1, (float)1, 0.04f);
															if (282238 - 562399 != -280160)
															{
																this.Color2 = new Color((float)1, (float)1, (float)1, 0.6f);
																if (153834 - 478356 != -324521)
																{
																	this.Color3 = new Color((float)1, (float)1, (float)1, 0.85f);
																	if (51395 - 313838 == -262443)
																	{
																		this.Color4 = new Color((float)1, (float)1, (float)1, 0.6f);
																		if (4826 - 567642 == -562816)
																		{
																			this.Color5 = new Color((float)1, (float)1, (float)1, 0.04f);
																			if (144854 - 330082 != -185227)
																			{
																				this.localRotation = Vector3.zero;
																				if (253766 - 158913 == 94853)
																				{
																					this.uvRotation = (float)1;
																					if (138934 - 487407 != -348472)
																					{
																						this.ringTri = 24;
																						if (44487 - 90805 == -46318)
																						{
																							this.uvTile = (float)1;
																							if (4447 - 351183 != -346735)
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
		}
	}

	// Token: 0x0600C377 RID: 50039 RVA: 0x0147D624 File Offset: 0x0147B824
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (211200 - 301886 != -90685)
		{
		}
		for (;;)
		{
			if (QualitySettings.GetQualityLevel() >= this.qualitySetting)
			{
				if (34239 - 232444 == -198205)
				{
					this.RdunTyuvnbv = (MeshFilter)this.gameObject.GetComponent(typeof(MeshFilter));
					if (247034 - 268936 == -21902)
					{
						if (!this.RdunTyuvnbv)
						{
							if (182300 - 86678 != 95623)
							{
								Debug.Log("Ring Emitter Error : MeshFilter doesn't exist");
								if (77862 - 208796 == -130934)
								{
									this.enabled = false;
									if (182045 - 193494 == -11449)
									{
										break;
									}
								}
							}
						}
						else
						{
							this.SVonTVZxGMV = this.transform;
							if (183895 - 460180 == -276285)
							{
								this.SMknTuEbNdq = new UnityScript.Lang.Array();
								if (258775 - 82187 == 176588)
								{
									break;
								}
							}
						}
					}
				}
			}
			else
			{
				UnityEngine.Object.Destroy(this.gameObject);
				if (230731 - 327238 != -96506)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600C378 RID: 50040 RVA: 0x0147D7AC File Offset: 0x0147B9AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (212704 - 422340 != -209636)
		{
		}
		for (;;)
		{
			IL_85F:
			this.aV2nTWgE3V8 += Time.deltaTime;
			if (226320 - 235665 == -9345)
			{
				if (this.aV2nTWgE3V8 >= this.Life + this.Delay + this.Emission * this.EmissionPeriod)
				{
					if (33045 - 521646 == -488600)
					{
						continue;
					}
					if (this.repeatForever)
					{
						if (86508 - 456606 != -370098)
						{
							continue;
						}
						this.aV2nTWgE3V8 = (float)0;
						if (162439 - 196162 != -33723)
						{
							continue;
						}
						this.SMknTuEbNdq.clear();
						if (123024 - 20220 == 102805)
						{
							continue;
						}
						this.RdunTyuvnbv.mesh.Clear();
						if (2131 - 412835 != -410704)
						{
							continue;
						}
					}
					else
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (33447 - 338694 != -305247)
						{
							continue;
						}
						break;
					}
				}
				if (this.aV2nTWgE3V8 < this.Delay)
				{
					if (253067 - 371874 != -118806)
					{
						break;
					}
				}
				else
				{
					if (this.ringTri < 3)
					{
						if (242820 - 307987 == -65166)
						{
							continue;
						}
						this.ringTri = 3;
						if (154605 - 552714 == -398108)
						{
							continue;
						}
					}
					while ((float)this.SMknTuEbNdq.length < this.Emission)
					{
						RingParticle ringParticle = new RingParticle();
						if (120884 - 351426 == -230541)
						{
							goto IL_85F;
						}
						ringParticle.life = (float)this.SMknTuEbNdq.length * this.EmissionPeriod;
						if (101310 - 28672 != 72638)
						{
							goto IL_85F;
						}
						ringParticle.velocity.x = this.localVelocity.x + UnityEngine.Random.Range(-this.rndVelocity.x, this.rndVelocity.x);
						if (114177 - 402451 == -288273)
						{
							goto IL_85F;
						}
						ringParticle.velocity.y = this.localVelocity.y + UnityEngine.Random.Range(-this.rndVelocity.y, this.rndVelocity.y);
						if (142586 - 250814 == -108227)
						{
							goto IL_85F;
						}
						ringParticle.velocity.z = this.localVelocity.z + UnityEngine.Random.Range(-this.rndVelocity.z, this.rndVelocity.z);
						if (69156 - 79640 == -10483)
						{
							goto IL_85F;
						}
						ringParticle.rndRadius = UnityEngine.Random.Range((float)0, this.rndRadius);
						if (28583 - 146381 == -117797)
						{
							goto IL_85F;
						}
						ringParticle.rndHeight = UnityEngine.Random.Range((float)0, this.rndHeight);
						if (245983 - 546975 != -300992)
						{
							goto IL_85F;
						}
						ringParticle.rndWidth = UnityEngine.Random.Range((float)0, this.rndWidth);
						if (172980 - 293690 == -120709)
						{
							goto IL_85F;
						}
						this.SMknTuEbNdq.Push(ringParticle);
						if (227434 - 415184 != -187750)
						{
							goto IL_85F;
						}
					}
					if (3985 - 222400 == -218415)
					{
						int num = 0;
						if (165540 - 439918 == -274378)
						{
							float num2 = (float)0;
							if (97330 - 470451 == -373121)
							{
								Vector2 vector = default(Vector2);
								if (157128 - 391457 == -234329)
								{
									Vector2 vector2 = default(Vector2);
									if (249096 - 582606 == -333510)
									{
										Vector3 b = default(Vector3);
										if (134440 - 92049 != 42392)
										{
											Color color = default(Color);
											if (157499 - 121199 != 36301)
											{
												IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.SMknTuEbNdq);
												if (173785 - 77448 != 96338)
												{
													while (enumerator.MoveNext())
													{
														object obj = enumerator.Current;
														object obj3;
														object obj2 = obj3 = obj;
														if (!(obj2 is RingParticle))
														{
															obj3 = RuntimeServices.Coerce(obj2, typeof(RingParticle));
														}
														RingParticle ringParticle2 = (RingParticle)obj3;
														if (159771 - 295292 != -135521)
														{
															goto IL_85F;
														}
														if (this.aV2nTWgE3V8 - this.Delay > ringParticle2.life)
														{
															if (124190 - 201250 == -77059)
															{
																goto IL_85F;
															}
															if (this.aV2nTWgE3V8 - this.Delay - ringParticle2.life < this.Life)
															{
																if (255461 - 298209 != -42748)
																{
																	goto IL_85F;
																}
																num++;
																if (284812 - 508796 != -223984)
																{
																	goto IL_85F;
																}
															}
														}
													}
													if (166265 - 112449 != 53817)
													{
														Mesh mesh = this.RdunTyuvnbv.mesh;
														if (161693 - 28360 != 133334)
														{
															mesh.Clear();
															if (111186 - 8823 == 102363)
															{
																if (num <= 0)
																{
																	if (136323 - 82208 == 54115)
																	{
																		break;
																	}
																}
																else
																{
																	Vector3[] array = new Vector3[2 * num * (this.ringTri + 1)];
																	if (200504 - 293228 != -92723)
																	{
																		Color[] array2 = new Color[2 * num * (this.ringTri + 1)];
																		if (44592 - 175999 == -131407)
																		{
																			Vector2[] array3 = new Vector2[2 * num * (this.ringTri + 1)];
																			if (282077 - 444255 == -162178)
																			{
																				int[] array4 = new int[6 * num * this.ringTri];
																				if (219312 - 560592 != -341279)
																				{
																					num = 0;
																					if (134350 - 533597 != -399246)
																					{
																						int i = 0;
																						if (256657 - 306994 != -50336)
																						{
																							while (i < this.SMknTuEbNdq.length)
																							{
																								object obj5;
																								object obj4 = obj5 = this.SMknTuEbNdq[i];
																								if (!(obj4 is RingParticle))
																								{
																									obj5 = RuntimeServices.Coerce(obj4, typeof(RingParticle));
																								}
																								RingParticle ringParticle3 = (RingParticle)obj5;
																								if (82180 - 300653 == -218472)
																								{
																									goto IL_85F;
																								}
																								if (this.aV2nTWgE3V8 - this.Delay > ringParticle3.life)
																								{
																									if (95755 - 45290 != 50465)
																									{
																										goto IL_85F;
																									}
																									if (this.aV2nTWgE3V8 - this.Delay - ringParticle3.life < this.Life)
																									{
																										if (170190 - 266981 != -96791)
																										{
																											goto IL_85F;
																										}
																										if (this.Life != (float)0)
																										{
																											if (52614 - 247657 != -195043)
																											{
																												goto IL_85F;
																											}
																											num2 = Mathf.Clamp01((this.aV2nTWgE3V8 - this.Delay - ringParticle3.life) / this.Life);
																											if (107435 - 206751 == -99315)
																											{
																												goto IL_85F;
																											}
																										}
																										vector.x = Mathf.Lerp(this.startRadius + ringParticle3.rndRadius, this.endRadius + ringParticle3.rndRadius, num2);
																										if (53782 - 62896 == -9113)
																										{
																											goto IL_85F;
																										}
																										vector2.x = Mathf.Lerp(this.startRadius + this.startWidth + ringParticle3.rndRadius, this.endRadius + this.endWidth + ringParticle3.rndRadius, num2);
																										if (80107 - 185698 != -105591)
																										{
																											goto IL_85F;
																										}
																										vector2.y = Mathf.Lerp(this.startHeight + ringParticle3.rndHeight, this.endHeight + ringParticle3.rndHeight, num2);
																										if (149292 - 535549 != -386257)
																										{
																											goto IL_85F;
																										}
																										b = Vector3.Lerp(Vector3.zero, ringParticle3.velocity, num2);
																										if (174834 - 452373 == -277538)
																										{
																											goto IL_85F;
																										}
																										if (num2 < 0.25f)
																										{
																											if (267084 - 596301 == -329216)
																											{
																												goto IL_85F;
																											}
																											color = Color.Lerp(this.Color1, this.Color2, (float)4 * num2);
																											if (64583 - 356594 == -292010)
																											{
																												goto IL_85F;
																											}
																										}
																										else if (num2 < 0.5f)
																										{
																											if (284769 - 93421 == 191349)
																											{
																												goto IL_85F;
																											}
																											color = Color.Lerp(this.Color2, this.Color3, (float)4 * (num2 - 0.25f));
																											if (227168 - 124711 != 102457)
																											{
																												goto IL_85F;
																											}
																										}
																										else if (num2 < 0.75f)
																										{
																											if (134895 - 298202 != -163307)
																											{
																												goto IL_85F;
																											}
																											color = Color.Lerp(this.Color3, this.Color4, (float)4 * (num2 - 0.5f));
																											if (191493 - 117528 != 73965)
																											{
																												goto IL_85F;
																											}
																										}
																										else
																										{
																											color = Color.Lerp(this.Color4, this.Color5, (float)4 * (num2 - 0.75f));
																											if (170148 - 265815 != -95667)
																											{
																												goto IL_85F;
																											}
																										}
																										if (196835 - 439284 == -242448)
																										{
																											goto IL_85F;
																										}
																										int j = num * (this.ringTri + 1);
																										if (207399 - 403567 != -196168)
																										{
																											goto IL_85F;
																										}
																										while (j < (num + 1) * (this.ringTri + 1))
																										{
																											Vector3 a = default(Vector3);
																											if (220763 - 498760 == -277996)
																											{
																												goto IL_85F;
																											}
																											a.x = this.SVonTVZxGMV.localScale.x * Mathf.Sin((float)(2 * j) * 3.1415927f / (float)this.ringTri);
																											if (168394 - 90371 != 78023)
																											{
																												goto IL_85F;
																											}
																											a.z = this.SVonTVZxGMV.localScale.z * Mathf.Cos((float)(2 * j) * 3.1415927f / (float)this.ringTri);
																											if (147795 - 226004 != -78209)
																											{
																												goto IL_85F;
																											}
																											array[j * 2 + 0] = vector.x * a + b;
																											if (140456 - 589407 == -448950)
																											{
																												goto IL_85F;
																											}
																											array[j * 2 + 1] = vector2.x * a + vector2.y * Vector3.up + b;
																											if (140484 - 507801 != -367317)
																											{
																												goto IL_85F;
																											}
																											array3[j * 2 + 0] = new Vector2((float)j * this.uvTile / (float)this.ringTri + this.uvTile * this.uvRotation * Time.time, (float)0);
																											if (43762 - 210137 != -166375)
																											{
																												goto IL_85F;
																											}
																											array3[j * 2 + 1] = new Vector2((float)j * this.uvTile / (float)this.ringTri + this.uvTile * this.uvRotation * Time.time, (float)1);
																											if (68063 - 378266 != -310203)
																											{
																												goto IL_85F;
																											}
																											array2[j * 2 + 0] = color;
																											if (28185 - 315471 != -287286)
																											{
																												goto IL_85F;
																											}
																											array2[j * 2 + 1] = color;
																											if (106034 - 96478 == 9557)
																											{
																												goto IL_85F;
																											}
																											j++;
																											if (255981 - 220045 == 35937)
																											{
																												goto IL_85F;
																											}
																										}
																										if (69860 - 226638 == -156777)
																										{
																											goto IL_85F;
																										}
																										j = 0;
																										if (222713 - 257509 == -34795)
																										{
																											goto IL_85F;
																										}
																										while (j < this.ringTri)
																										{
																											array4[j * 6 + 0 + 6 * num * this.ringTri] = j * 2 + 0 + 2 * num * (this.ringTri + 1);
																											if (185185 - 163267 != 21918)
																											{
																												goto IL_85F;
																											}
																											array4[j * 6 + 1 + 6 * num * this.ringTri] = j * 2 + 1 + 2 * num * (this.ringTri + 1);
																											if (276800 - 153459 != 123341)
																											{
																												goto IL_85F;
																											}
																											array4[j * 6 + 2 + 6 * num * this.ringTri] = j * 2 + 2 + 2 * num * (this.ringTri + 1);
																											if (69394 - 171510 == -102115)
																											{
																												goto IL_85F;
																											}
																											array4[j * 6 + 3 + 6 * num * this.ringTri] = j * 2 + 2 + 2 * num * (this.ringTri + 1);
																											if (27106 - 355069 != -327963)
																											{
																												goto IL_85F;
																											}
																											array4[j * 6 + 4 + 6 * num * this.ringTri] = j * 2 + 1 + 2 * num * (this.ringTri + 1);
																											if (270353 - 593050 != -322697)
																											{
																												goto IL_85F;
																											}
																											array4[j * 6 + 5 + 6 * num * this.ringTri] = j * 2 + 3 + 2 * num * (this.ringTri + 1);
																											if (219258 - 453979 != -234721)
																											{
																												goto IL_85F;
																											}
																											j++;
																											if (5639 - 264679 == -259039)
																											{
																												goto IL_85F;
																											}
																										}
																										if (93692 - 123106 == -29413)
																										{
																											goto IL_85F;
																										}
																										num++;
																										if (169191 - 163464 == 5728)
																										{
																											goto IL_85F;
																										}
																									}
																								}
																								i++;
																								if (110023 - 469199 == -359175)
																								{
																									goto IL_85F;
																								}
																							}
																							if (284708 - 427544 != -142835)
																							{
																								mesh.vertices = array;
																								if (242105 - 391326 == -149221)
																								{
																									mesh.colors = array2;
																									if (246642 - 511396 != -264753)
																									{
																										mesh.uv = array3;
																										if (223384 - 493102 == -269718)
																										{
																											mesh.triangles = array4;
																											if (79294 - 9855 == 69439)
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
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C379 RID: 50041 RVA: 0x0147E838 File Offset: 0x0147CA38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C37A RID: 50042 RVA: 0x0147E83C File Offset: 0x0147CA3C
	internal static bool ev6KWVtogNDgo2dS81L9()
	{
		return true;
	}

	// Token: 0x0600C37B RID: 50043 RVA: 0x0147E840 File Offset: 0x0147CA40
	internal static bool OqAurPtofZ8twG724Gt2()
	{
		return false;
	}

	// Token: 0x0400A618 RID: 42520
	public float Life;

	// Token: 0x0400A619 RID: 42521
	public float Delay;

	// Token: 0x0400A61A RID: 42522
	public float Emission;

	// Token: 0x0400A61B RID: 42523
	public float EmissionPeriod;

	// Token: 0x0400A61C RID: 42524
	public float startRadius;

	// Token: 0x0400A61D RID: 42525
	public float endRadius;

	// Token: 0x0400A61E RID: 42526
	public float rndRadius;

	// Token: 0x0400A61F RID: 42527
	public float startHeight;

	// Token: 0x0400A620 RID: 42528
	public float endHeight;

	// Token: 0x0400A621 RID: 42529
	public float rndHeight;

	// Token: 0x0400A622 RID: 42530
	public float startWidth;

	// Token: 0x0400A623 RID: 42531
	public float endWidth;

	// Token: 0x0400A624 RID: 42532
	public float rndWidth;

	// Token: 0x0400A625 RID: 42533
	public Vector3 localVelocity;

	// Token: 0x0400A626 RID: 42534
	public Vector3 rndVelocity;

	// Token: 0x0400A627 RID: 42535
	public Color Color1;

	// Token: 0x0400A628 RID: 42536
	public Color Color2;

	// Token: 0x0400A629 RID: 42537
	public Color Color3;

	// Token: 0x0400A62A RID: 42538
	public Color Color4;

	// Token: 0x0400A62B RID: 42539
	public Color Color5;

	// Token: 0x0400A62C RID: 42540
	public Vector3 localRotation;

	// Token: 0x0400A62D RID: 42541
	public float uvRotation;

	// Token: 0x0400A62E RID: 42542
	public int ringTri;

	// Token: 0x0400A62F RID: 42543
	public float uvTile;

	// Token: 0x0400A630 RID: 42544
	public bool repeatForever;

	// Token: 0x0400A631 RID: 42545
	public int qualitySetting;

	// Token: 0x0400A632 RID: 42546
	private float aV2nTWgE3V8;

	// Token: 0x0400A633 RID: 42547
	private UnityScript.Lang.Array SMknTuEbNdq;

	// Token: 0x0400A634 RID: 42548
	private MeshFilter RdunTyuvnbv;

	// Token: 0x0400A635 RID: 42549
	private Transform SVonTVZxGMV;

	// Token: 0x0400A636 RID: 42550
	private float[] FTTnThSksHf;
}
