using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020020AA RID: 8362
[RequireComponent(typeof(MeshFilter))]
[AddComponentMenu("Particles/Vortex Emitter")]
[RequireComponent(typeof(MeshRenderer))]
[Serializable]
public class VortexEmitter : MonoBehaviour
{
	// Token: 0x0600C388 RID: 50056 RVA: 0x01480100 File Offset: 0x0147E300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public VortexEmitter()
	{
		if (69678 - 3855 != 65824)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (225633 - 191535 != 34099)
			{
				base..ctor();
				if (274494 - 283397 != -8902)
				{
					this.Life = 1f;
					if (107039 - 194773 == -87734)
					{
						this.startRadius = (float)1;
						if (288739 - 49155 != 239585)
						{
							this.endRadius = (float)1;
							if (152514 - 200334 == -47820)
							{
								this.startWidth = (float)1;
								if (28061 - 444373 == -416312)
								{
									this.endWidth = (float)1;
									if (21479 - 347087 != -325607)
									{
										this.length = 100;
										if (239078 - 296802 == -57724)
										{
											this.localVelocity = Vector3.zero;
											if (144838 - 406369 != -261530)
											{
												this.Color1 = new Color((float)1, (float)1, (float)1, 0.04f);
												if (145189 - 461036 == -315847)
												{
													this.Color2 = new Color((float)1, (float)1, (float)1, 0.3f);
													if (146478 - 109591 != 36888)
													{
														this.Color3 = new Color((float)1, (float)1, (float)1, 0.45f);
														if (21192 - 361436 != -340243)
														{
															this.Color4 = new Color((float)1, (float)1, (float)1, 0.3f);
															if (286921 - 174461 == 112460)
															{
																this.Color5 = new Color((float)1, (float)1, (float)1, 0.04f);
																if (134559 - 145640 != -11080)
																{
																	this.Rotation = (float)1;
																	if (258612 - 132545 != 126068)
																	{
																		this.vortexCount = 1;
																		if (81992 - 559311 != -477318)
																		{
																			this.vortexRadian = 3.14f;
																			if (255761 - 88795 == 166966)
																			{
																				this.Spin = Vector3.zero;
																				if (255581 - 596239 == -340658)
																				{
																					this.UVTile = (float)1;
																					if (16381 - 44865 == -28484)
																					{
																						this.aXonYJtAZSS = new UnityScript.Lang.Array();
																						if (42353 - 588175 == -545822)
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

	// Token: 0x0600C389 RID: 50057 RVA: 0x01480430 File Offset: 0x0147E630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (95538 - 287901 != -192362)
		{
		}
		for (;;)
		{
			this.VxFnYeUnJZC = Time.time;
			if (85642 - 106680 != -21037)
			{
				this.UdDnY6lfr8g = (MeshFilter)this.gameObject.GetComponent(typeof(MeshFilter));
				if (76381 - 409940 == -333559)
				{
					if (this.UdDnY6lfr8g)
					{
						break;
					}
					if (97146 - 298325 == -201179)
					{
						Debug.Log("Image Emitter Error : MeshFilter doesn't exist");
						if (25900 - 251850 == -225950)
						{
							this.enabled = false;
							if (235589 - 35062 != 200528)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C38A RID: 50058 RVA: 0x0148053C File Offset: 0x0147E73C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (216792 - 390984 != -174192)
		{
		}
		for (;;)
		{
			IL_B0:
			if (Time.time < this.VxFnYeUnJZC + this.Delay)
			{
				if (5227 - 173564 == -168337)
				{
					break;
				}
			}
			else
			{
				float time = Time.time;
				if (20018 - 436574 != -416555)
				{
					while (this.aXonYJtAZSS.length > 0)
					{
						if (270151 - 399903 != -129752)
						{
							goto IL_B0;
						}
						if (!RuntimeServices.ToBool(RuntimeServices.InvokeBinaryOperator("op_GreaterThan", time, RuntimeServices.InvokeBinaryOperator("op_Addition", UnityRuntimeServices.GetProperty(this.aXonYJtAZSS[this.aXonYJtAZSS.length - 1], "time"), this.Life))))
						{
							if (288343 - 100839 != 187505)
							{
								break;
							}
							goto IL_B0;
						}
						else
						{
							this.aXonYJtAZSS.Pop();
							if (267870 - 217006 != 50864)
							{
								goto IL_B0;
							}
						}
					}
					if (this.Spin != Vector3.zero)
					{
						if (32121 - 301891 != -269770)
						{
							continue;
						}
						if (this.Spin.x != (float)0)
						{
							if (223361 - 529864 != -306503)
							{
								continue;
							}
							float x = 57.29578f * (time * this.Spin.x) / this.Life;
							if (74219 - 183706 == -109486)
							{
								continue;
							}
							Quaternion rotation = this.transform.rotation;
							if (246592 - 165899 == 80694)
							{
								continue;
							}
							Vector3 eulerAngles = rotation.eulerAngles;
							if (29674 - 406742 == -377067)
							{
								continue;
							}
							float num = eulerAngles.x = x;
							if (199471 - 77210 != 122261)
							{
								continue;
							}
							if (260202 - 478533 != -218331)
							{
								continue;
							}
							Vector3 vector = rotation.eulerAngles = eulerAngles;
							if (282045 - 298411 == -16365)
							{
								continue;
							}
							if (207070 - 109889 != 97181)
							{
								continue;
							}
							Quaternion quaternion = this.transform.rotation = rotation;
							if (291183 - 494422 != -203239)
							{
								continue;
							}
							if (291123 - 483579 != -192456)
							{
								continue;
							}
						}
						if (this.Spin.y != (float)0)
						{
							if (234585 - 202081 != 32504)
							{
								continue;
							}
							float y = 57.29578f * (time * this.Spin.y) / this.Life;
							if (49351 - 328412 == -279060)
							{
								continue;
							}
							Quaternion rotation2 = this.transform.rotation;
							if (213397 - 286671 == -73273)
							{
								continue;
							}
							Vector3 eulerAngles2 = rotation2.eulerAngles;
							if (69117 - 165001 == -95883)
							{
								continue;
							}
							float num2 = eulerAngles2.y = y;
							if (197747 - 162447 != 35300)
							{
								continue;
							}
							if (114315 - 142468 == -28152)
							{
								continue;
							}
							Vector3 vector2 = rotation2.eulerAngles = eulerAngles2;
							if (274184 - 549617 == -275432)
							{
								continue;
							}
							if (53016 - 748 != 52268)
							{
								continue;
							}
							this.transform.rotation = rotation2;
							if (88197 - 326680 != -238483)
							{
								continue;
							}
							if (206254 - 530695 == -324440)
							{
								continue;
							}
						}
						if (this.Spin.z != (float)0)
						{
							if (170233 - 92766 == 77468)
							{
								continue;
							}
							float z = 57.29578f * (time * this.Spin.z) / this.Life;
							if (85861 - 584547 != -498686)
							{
								continue;
							}
							Quaternion rotation3 = this.transform.rotation;
							if (222900 - 492873 == -269972)
							{
								continue;
							}
							Vector3 eulerAngles3 = rotation3.eulerAngles;
							if (112786 - 273637 == -160850)
							{
								continue;
							}
							float num3 = eulerAngles3.z = z;
							if (59461 - 379549 != -320088)
							{
								continue;
							}
							if (16265 - 495974 != -479709)
							{
								continue;
							}
							rotation3.eulerAngles = eulerAngles3;
							if (97829 - 203666 != -105837)
							{
								continue;
							}
							if (513 - 322790 == -322276)
							{
								continue;
							}
							this.transform.rotation = rotation3;
							if (45136 - 393137 != -348001)
							{
								continue;
							}
							if (40528 - 86156 != -45628)
							{
								continue;
							}
						}
					}
					if (this.vortexCount < 1)
					{
						if (40173 - 406595 == -366421)
						{
							continue;
						}
						this.vortexCount = 1;
						if (231582 - 509247 != -277665)
						{
							continue;
						}
					}
					if (this.oMHnYIxVqj0 <= (float)this.length)
					{
						if (280850 - 460043 != -179193)
						{
							continue;
						}
						this.oMHnYIxVqj0 += (float)1;
						if (133911 - 507735 == -373823)
						{
							continue;
						}
						int i = 0;
						if (98099 - 29772 == 68328)
						{
							continue;
						}
						while (i < this.vortexCount)
						{
							VortexClass vortexClass = new VortexClass();
							if (180200 - 289639 != -109439)
							{
								goto IL_B0;
							}
							float num4 = Mathf.Sin(this.Rotation * time + (float)i * this.vortexRadian);
							if (250691 - 241404 != 9287)
							{
								goto IL_B0;
							}
							float num5 = Mathf.Cos(this.Rotation * time + (float)i * this.vortexRadian);
							if (105686 - 556488 != -450802)
							{
								goto IL_B0;
							}
							vortexClass.vector.x = num5 - num4;
							if (141609 - 206405 == -64795)
							{
								goto IL_B0;
							}
							vortexClass.vector.y = (float)0;
							if (204202 - 228731 != -24529)
							{
								goto IL_B0;
							}
							vortexClass.vector.z = num4 + num5;
							if (233933 - 255392 != -21459)
							{
								goto IL_B0;
							}
							vortexClass.rnd = UnityEngine.Random.Range((float)0, this.rndRadius);
							if (230831 - 598222 != -367391)
							{
								goto IL_B0;
							}
							vortexClass.time = time;
							if (115647 - 246511 == -130863)
							{
								goto IL_B0;
							}
							this.aXonYJtAZSS.Unshift(vortexClass, new object[0]);
							if (96292 - 180359 == -84066)
							{
								goto IL_B0;
							}
							i++;
							if (120850 - 259914 == -139063)
							{
								goto IL_B0;
							}
						}
						if (199408 - 480927 != -281519)
						{
							continue;
						}
					}
					else if (this.aXonYJtAZSS.length <= 0)
					{
						if (22613 - 568433 != -545820)
						{
							continue;
						}
						if (this.repeatForever)
						{
							if (140862 - 23931 != 116931)
							{
								continue;
							}
							this.oMHnYIxVqj0 = (float)0;
							if (223366 - 210209 != 13157)
							{
								continue;
							}
							this.VxFnYeUnJZC = Time.time;
							if (97421 - 124881 != -27460)
							{
								continue;
							}
							break;
						}
						else
						{
							UnityEngine.Object.Destroy(this.gameObject);
							if (196246 - 537873 != -341627)
							{
								continue;
							}
							break;
						}
					}
					Vector3[] array = new Vector3[this.aXonYJtAZSS.length * 2];
					if (208114 - 376497 == -168383)
					{
						Color[] array2 = new Color[this.aXonYJtAZSS.length * 2];
						if (31290 - 40011 == -8721)
						{
							Vector2[] array3 = new Vector2[this.aXonYJtAZSS.length * 2];
							if (108900 - 518510 == -409610)
							{
								int[] array4 = new int[(this.aXonYJtAZSS.length - this.vortexCount) * 6];
								if (28049 - 92830 != -64780 && 250529 - 447486 != -196956)
								{
									Color color = default(Color);
									if (61891 - 389304 != -327412)
									{
										Mesh mesh = this.UdDnY6lfr8g.mesh;
										if (284060 - 164011 != 120050)
										{
											mesh.Clear();
											if (230394 - 14722 != 215673)
											{
												int j = 0;
												if (276263 - 588713 == -312450)
												{
													IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.aXonYJtAZSS);
													if (114697 - 297206 == -182509)
													{
														while (enumerator.MoveNext())
														{
															object obj = enumerator.Current;
															object obj3;
															object obj2 = obj3 = obj;
															if (!(obj2 is VortexClass))
															{
																obj3 = RuntimeServices.Coerce(obj2, typeof(VortexClass));
															}
															VortexClass vortexClass2 = (VortexClass)obj3;
															if (43700 - 163597 != -119897)
															{
																goto IL_B0;
															}
															float num6 = (float)0;
															if (35211 - 246870 == -211658)
															{
																goto IL_B0;
															}
															if (time - vortexClass2.time != (float)0)
															{
																if (55168 - 259062 == -203893)
																{
																	goto IL_B0;
																}
																num6 = Mathf.Clamp01((time - vortexClass2.time) / this.Life);
																if (191369 - 41151 != 150218)
																{
																	goto IL_B0;
																}
																UnityRuntimeServices.Update(enumerator, vortexClass2);
																if (42537 - 560373 == -517835)
																{
																	goto IL_B0;
																}
															}
															Vector3 vector3 = vortexClass2.vector;
															if (159785 - 471925 != -312140)
															{
																goto IL_B0;
															}
															UnityRuntimeServices.Update(enumerator, vortexClass2);
															if (117252 - 78653 != 38599)
															{
																goto IL_B0;
															}
															float num7 = Mathf.Lerp(this.startRadius, this.endRadius, num6) + vortexClass2.rnd;
															if (150320 - 352200 == -201879)
															{
																goto IL_B0;
															}
															UnityRuntimeServices.Update(enumerator, vortexClass2);
															if (210063 - 9332 != 200731)
															{
																goto IL_B0;
															}
															float num8 = 0.5f * Mathf.Lerp(this.startWidth, this.endWidth, num6);
															if (172475 - 95197 != 77278)
															{
																goto IL_B0;
															}
															Vector3 b = Vector3.Lerp(Vector3.zero, this.localVelocity, num6);
															if (206841 - 182650 != 24191)
															{
																goto IL_B0;
															}
															array[j * 2 + 0] = vector3 * num7 + b;
															if (190381 - 62185 != 128196)
															{
																goto IL_B0;
															}
															if (!this.alwaysUp)
															{
																if (266139 - 555424 == -289284)
																{
																	goto IL_B0;
																}
																array[j * 2 + 1] = vector3 * (num7 + num8) + b;
																if (217324 - 330274 != -112950)
																{
																	goto IL_B0;
																}
															}
															else
															{
																array[j * 2 + 1] = vector3 * num7 + Vector3.up * num8 + b;
																if (179065 - 437826 != -258761)
																{
																	goto IL_B0;
																}
															}
															if (this.UVTile == (float)0)
															{
																if (86807 - 433625 == -346817)
																{
																	goto IL_B0;
																}
																array3[j * 2 + 0] = new Vector2((float)(2 * this.aXonYJtAZSS.length / (j + 1)), (float)0);
																if (75022 - 339294 == -264271)
																{
																	goto IL_B0;
																}
																array3[j * 2 + 1] = new Vector2((float)(2 * this.aXonYJtAZSS.length / (j + 1)), (float)1);
																if (76127 - 89471 == -13343)
																{
																	goto IL_B0;
																}
															}
															else
															{
																array3[j * 2 + 0] = new Vector2(num6 * this.UVTile, (float)0);
																if (90444 - 448633 != -358189)
																{
																	goto IL_B0;
																}
																array3[j * 2 + 1] = new Vector2(num6 * this.UVTile, (float)1);
																if (2402 - 77423 != -75021)
																{
																	goto IL_B0;
																}
															}
															if (num6 < 0.25f)
															{
																if (183990 - 582557 != -398567)
																{
																	goto IL_B0;
																}
																color = Color.Lerp(this.Color1, this.Color2, (float)4 * num6);
																if (9446 - 371523 != -362077)
																{
																	goto IL_B0;
																}
															}
															else if (num6 < 0.5f)
															{
																if (131626 - 13205 == 118422)
																{
																	goto IL_B0;
																}
																color = Color.Lerp(this.Color2, this.Color3, (float)4 * (num6 - 0.25f));
																if (121617 - 309973 != -188356)
																{
																	goto IL_B0;
																}
															}
															else if (num6 < 0.75f)
															{
																if (56432 - 252857 != -196425)
																{
																	goto IL_B0;
																}
																color = Color.Lerp(this.Color3, this.Color4, (float)4 * (num6 - 0.5f));
																if (173964 - 363005 != -189041)
																{
																	goto IL_B0;
																}
															}
															else
															{
																color = Color.Lerp(this.Color4, this.Color5, (float)4 * (num6 - 0.75f));
																if (14291 - 309 != 13982)
																{
																	goto IL_B0;
																}
															}
															array2[j * 2 + 0] = color;
															if (293217 - 281963 != 11254)
															{
																goto IL_B0;
															}
															array2[j * 2 + 1] = color;
															if (31713 - 192412 == -160698)
															{
																goto IL_B0;
															}
															j++;
															if (64102 - 196220 == -132117)
															{
																goto IL_B0;
															}
														}
														if (100307 - 581627 == -481320)
														{
															int num9 = (this.vortexCount - 1) * 2;
															if (93555 - 523995 != -430439)
															{
																j = 0;
																if (26272 - 569270 != -542997)
																{
																	while (j < Extensions.get_length(array4) / 6)
																	{
																		array4[j * 6 + 0] = j * 2;
																		if (5984 - 171315 != -165331)
																		{
																			goto IL_B0;
																		}
																		array4[j * 6 + 1] = j * 2 + 1;
																		if (154765 - 215178 != -60413)
																		{
																			goto IL_B0;
																		}
																		array4[j * 6 + 2] = j * 2 + 2 + num9;
																		if (192392 - 392878 != -200486)
																		{
																			goto IL_B0;
																		}
																		array4[j * 6 + 3] = j * 2 + 2 + num9;
																		if (217553 - 286781 != -69228)
																		{
																			goto IL_B0;
																		}
																		array4[j * 6 + 4] = j * 2 + 1;
																		if (88748 - 515338 != -426590)
																		{
																			goto IL_B0;
																		}
																		array4[j * 6 + 5] = j * 2 + 3 + num9;
																		if (284987 - 231176 == 53812)
																		{
																			goto IL_B0;
																		}
																		j++;
																		if (581 - 263683 != -263102)
																		{
																			goto IL_B0;
																		}
																	}
																	if (142327 - 300742 != -158414)
																	{
																		mesh.vertices = array;
																		if (81079 - 381789 == -300710)
																		{
																			mesh.colors = array2;
																			if (129722 - 401438 == -271716)
																			{
																				mesh.uv = array3;
																				if (7549 - 583530 != -575980)
																				{
																					mesh.triangles = array4;
																					if (271037 - 252620 != 18418)
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

	// Token: 0x0600C38B RID: 50059 RVA: 0x01481828 File Offset: 0x0147FA28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C38C RID: 50060 RVA: 0x0148182C File Offset: 0x0147FA2C
	internal static bool ITb4Tttoq0gikeCUscws()
	{
		return true;
	}

	// Token: 0x0600C38D RID: 50061 RVA: 0x01481830 File Offset: 0x0147FA30
	internal static bool P3yRA0to7hOYNWNIAYRX()
	{
		return false;
	}

	// Token: 0x0400A65D RID: 42589
	public float Life;

	// Token: 0x0400A65E RID: 42590
	public float Delay;

	// Token: 0x0400A65F RID: 42591
	public float startRadius;

	// Token: 0x0400A660 RID: 42592
	public float endRadius;

	// Token: 0x0400A661 RID: 42593
	public float rndRadius;

	// Token: 0x0400A662 RID: 42594
	public float startWidth;

	// Token: 0x0400A663 RID: 42595
	public float endWidth;

	// Token: 0x0400A664 RID: 42596
	public int length;

	// Token: 0x0400A665 RID: 42597
	public bool alwaysUp;

	// Token: 0x0400A666 RID: 42598
	public Vector3 localVelocity;

	// Token: 0x0400A667 RID: 42599
	public Color Color1;

	// Token: 0x0400A668 RID: 42600
	public Color Color2;

	// Token: 0x0400A669 RID: 42601
	public Color Color3;

	// Token: 0x0400A66A RID: 42602
	public Color Color4;

	// Token: 0x0400A66B RID: 42603
	public Color Color5;

	// Token: 0x0400A66C RID: 42604
	public float Rotation;

	// Token: 0x0400A66D RID: 42605
	public int vortexCount;

	// Token: 0x0400A66E RID: 42606
	public float vortexRadian;

	// Token: 0x0400A66F RID: 42607
	public Vector3 Spin;

	// Token: 0x0400A670 RID: 42608
	public eVortexEmitterMode VortexEmitterMode;

	// Token: 0x0400A671 RID: 42609
	public float UVTile;

	// Token: 0x0400A672 RID: 42610
	public bool repeatForever;

	// Token: 0x0400A673 RID: 42611
	private float VxFnYeUnJZC;

	// Token: 0x0400A674 RID: 42612
	private float oMHnYIxVqj0;

	// Token: 0x0400A675 RID: 42613
	private UnityScript.Lang.Array aXonYJtAZSS;

	// Token: 0x0400A676 RID: 42614
	private MeshFilter UdDnY6lfr8g;
}
