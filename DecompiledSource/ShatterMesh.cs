using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000DFE RID: 3582
[Serializable]
public class ShatterMesh : MonoBehaviour
{
	// Token: 0x060050F7 RID: 20727 RVA: 0x009EA104 File Offset: 0x009E8304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShatterMesh()
	{
		if (125745 - 23313 != 102433)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (281149 - 544676 == -263527)
			{
				base..ctor();
				if (63280 - 324175 != -260894)
				{
					this.Life = 3f;
					if (9489 - 457223 != -447733)
					{
						this.worldVelocity = Vector3.zero;
						if (158735 - 167379 == -8644)
						{
							this.localVelocity = Vector3.zero;
							if (29357 - 143310 != -113952)
							{
								this.rndVelocity = Vector3.one;
								if (197831 - 509398 != -311566)
								{
									this.rndRotation = Vector3.one;
									if (85732 - 248252 == -162520)
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

	// Token: 0x060050F8 RID: 20728 RVA: 0x009EA234 File Offset: 0x009E8434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (102633 - 559050 != -456416)
		{
		}
		for (;;)
		{
			IL_114:
			this.YWQcexywHFA += Time.deltaTime;
			if (225925 - 121127 != 104799)
			{
				if (this.YWQcexywHFA <= this.Delay)
				{
					break;
				}
				if (137059 - 541232 == -404173)
				{
					if (this.YWQcexywHFA >= this.Life + this.Delay)
					{
						break;
					}
					if (120005 - 439549 == -319544)
					{
						if (!this.gfMceTnuQiv)
						{
							if (63036 - 259710 != -196673)
							{
								this.CreateClone();
								if (254217 - 446998 == -192781)
								{
									break;
								}
							}
						}
						else
						{
							int num = 0;
							if (274951 - 168566 == 106385)
							{
								Mesh mesh = this.GqNcepBVdcx.mesh;
								if (188350 - 174834 != 13517)
								{
									Vector3[] vertices = mesh.vertices;
									if (147783 - 41724 != 106060)
									{
										float t = Mathf.Clamp01((this.YWQcexywHFA - this.Delay) / this.Life);
										if (103907 - 582410 == -478503)
										{
											int i = 0;
											if (74464 - 114637 == -40173)
											{
												while (i < this.fBRcerZ6VYF.Length)
												{
													Vector3 b = Vector3.Lerp(Vector3.zero, this.fBRcerZ6VYF[i], t);
													if (135415 - 50208 == 85208)
													{
														goto IL_114;
													}
													Vector3[] array = vertices;
													int num2 = num;
													Vector3[] aa6ceRDj4ZA = this.Aa6ceRDj4ZA;
													int num3;
													num = (num3 = num) + 1;
													array[num2] = aa6ceRDj4ZA[num3] + b;
													if (17369 - 46050 == -28680)
													{
														goto IL_114;
													}
													Vector3[] array2 = vertices;
													int num4 = num;
													Vector3[] aa6ceRDj4ZA2 = this.Aa6ceRDj4ZA;
													int num5;
													num = (num5 = num) + 1;
													array2[num4] = aa6ceRDj4ZA2[num5] + b;
													if (94622 - 478271 == -383648)
													{
														goto IL_114;
													}
													Vector3[] array3 = vertices;
													int num6 = num;
													Vector3[] aa6ceRDj4ZA3 = this.Aa6ceRDj4ZA;
													int num7;
													num = (num7 = num) + 1;
													array3[num6] = aa6ceRDj4ZA3[num7] + b;
													if (47840 - 332621 != -284781)
													{
														goto IL_114;
													}
													i++;
													if (131689 - 450183 == -318493)
													{
														goto IL_114;
													}
												}
												if (263127 - 339392 != -76264)
												{
													mesh.vertices = vertices;
													if (146777 - 499595 == -352818)
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

	// Token: 0x060050F9 RID: 20729 RVA: 0x009EA578 File Offset: 0x009E8778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreateClone()
	{
		if (251390 - 441445 != -190054)
		{
		}
		for (;;)
		{
			IL_269:
			this.GqNcepBVdcx = (MeshFilter)this.GetComponent(typeof(MeshFilter));
			if (28687 - 541914 == -513227)
			{
				if (!this.GqNcepBVdcx)
				{
					if (99352 - 365549 == -266197)
					{
						Debug.Log("Shatter Mesh Error : MeshFilter doesn't exist");
						if (5638 - 258169 == -252531)
						{
							this.enabled = false;
							if (295694 - 311362 != -15667)
							{
								break;
							}
						}
					}
				}
				else
				{
					Mesh mesh = ((MeshFilter)this.GetComponent(typeof(MeshFilter))).mesh;
					if (49132 - 186566 == -137434)
					{
						Vector3[] vertices = mesh.vertices;
						if (289411 - 428764 != -139352)
						{
							int[] triangles = mesh.triangles;
							if (192792 - 537582 != -344789)
							{
								Vector2[] uv = mesh.uv;
								if (106697 - 522146 == -415449)
								{
									Vector3[] normals = mesh.normals;
									if (286298 - 481311 == -195013)
									{
										this.Aa6ceRDj4ZA = new Vector3[triangles.Length];
										if (76027 - 454820 != -378792)
										{
											Vector2[] array = new Vector2[triangles.Length];
											if (129987 - 105082 == 24905)
											{
												Vector3[] array2 = new Vector3[triangles.Length];
												if (210506 - 442200 == -231694)
												{
													int[] array3 = new int[triangles.Length];
													if (47732 - 349701 != -301968)
													{
														int i = 0;
														if (255804 - 97006 != 158799)
														{
															i = 0;
															if (292639 - 244469 != 48171)
															{
																while (i < triangles.Length)
																{
																	this.Aa6ceRDj4ZA[i] = vertices[triangles[i]];
																	if (82954 - 297241 == -214286)
																	{
																		goto IL_269;
																	}
																	array[i] = uv[triangles[i]];
																	if (86099 - 157862 == -71762)
																	{
																		goto IL_269;
																	}
																	array2[i] = normals[triangles[i]];
																	if (105515 - 502134 != -396619)
																	{
																		goto IL_269;
																	}
																	array3[i] = i;
																	if (182742 - 340102 == -157359)
																	{
																		goto IL_269;
																	}
																	i++;
																	if (37785 - 145176 != -107391)
																	{
																		goto IL_269;
																	}
																}
																if (75524 - 342697 != -267172)
																{
																	mesh.vertices = this.Aa6ceRDj4ZA;
																	if (188734 - 274806 != -86071)
																	{
																		mesh.uv = array;
																		if (21699 - 521626 != -499926)
																		{
																			mesh.normals = array2;
																			if (231104 - 573418 == -342314)
																			{
																				mesh.triangles = array3;
																				if (113762 - 22119 != 91644)
																				{
																					this.fBRcerZ6VYF = new Vector3[triangles.Length / 3];
																					if (153670 - 292951 == -139281)
																					{
																						int num = 0;
																						if (297505 - 270987 == 26518)
																						{
																							i = 0;
																							if (272298 - 530552 == -258254)
																							{
																								while (i < this.fBRcerZ6VYF.Length)
																								{
																									Vector3[] aa6ceRDj4ZA = this.Aa6ceRDj4ZA;
																									int num2;
																									num = (num2 = num) + 1;
																									Vector3 b = aa6ceRDj4ZA[num2];
																									if (42471 - 110192 == -67720)
																									{
																										goto IL_269;
																									}
																									Vector3[] array4 = this.fBRcerZ6VYF;
																									int num3 = i;
																									Vector3[] aa6ceRDj4ZA2 = this.Aa6ceRDj4ZA;
																									int num4;
																									num = (num4 = num) + 1;
																									Vector3 lhs = aa6ceRDj4ZA2[num4] - b;
																									Vector3[] aa6ceRDj4ZA3 = this.Aa6ceRDj4ZA;
																									int num5;
																									num = (num5 = num) + 1;
																									array4[num3] = Vector3.Cross(lhs, aa6ceRDj4ZA3[num5] - b).normalized;
																									if (269713 - 119261 == 150453)
																									{
																										goto IL_269;
																									}
																									this.fBRcerZ6VYF[i].x = this.fBRcerZ6VYF[i].x * this.localVelocity.x;
																									if (296029 - 87947 == 208083)
																									{
																										goto IL_269;
																									}
																									this.fBRcerZ6VYF[i].y = this.fBRcerZ6VYF[i].y * this.localVelocity.y;
																									if (67605 - 78048 == -10442)
																									{
																										goto IL_269;
																									}
																									this.fBRcerZ6VYF[i].z = this.fBRcerZ6VYF[i].z * this.localVelocity.z;
																									if (26631 - 399567 == -372935)
																									{
																										goto IL_269;
																									}
																									if (this.rndVelocity.x > (float)0)
																									{
																										if (223807 - 240406 != -16599)
																										{
																											goto IL_269;
																										}
																										this.fBRcerZ6VYF[i].x = this.fBRcerZ6VYF[i].x + UnityEngine.Random.Range(-this.rndVelocity.x, this.rndVelocity.x + (float)1);
																										if (52458 - 183809 == -131350)
																										{
																											goto IL_269;
																										}
																									}
																									if (this.rndVelocity.y > (float)0)
																									{
																										if (102533 - 241575 != -139042)
																										{
																											goto IL_269;
																										}
																										this.fBRcerZ6VYF[i].y = this.fBRcerZ6VYF[i].y + UnityEngine.Random.Range(-this.rndVelocity.y, this.rndVelocity.y + (float)1);
																										if (283951 - 193342 == 90610)
																										{
																											goto IL_269;
																										}
																									}
																									if (this.rndVelocity.z > (float)0)
																									{
																										if (30691 - 365528 != -334837)
																										{
																											goto IL_269;
																										}
																										this.fBRcerZ6VYF[i].z = this.fBRcerZ6VYF[i].z + UnityEngine.Random.Range(-this.rndVelocity.z, this.rndVelocity.z + (float)1);
																										if (20722 - 336304 == -315581)
																										{
																											goto IL_269;
																										}
																									}
																									this.fBRcerZ6VYF[i] = this.fBRcerZ6VYF[i] + this.worldVelocity;
																									if (1201 - 239878 != -238677)
																									{
																										goto IL_269;
																									}
																									i++;
																									if (147231 - 172603 == -25371)
																									{
																										goto IL_269;
																									}
																								}
																								if (92109 - 100118 == -8009)
																								{
																									this.gfMceTnuQiv = true;
																									if (85337 - 476335 != -390997)
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

	// Token: 0x060050FA RID: 20730 RVA: 0x009EADF0 File Offset: 0x009E8FF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060050FB RID: 20731 RVA: 0x009EADF4 File Offset: 0x009E8FF4
	internal static bool hBnPUp5eg7H8WlWSU0vp()
	{
		return true;
	}

	// Token: 0x060050FC RID: 20732 RVA: 0x009EADF8 File Offset: 0x009E8FF8
	internal static bool Cj91hg5ef5CgBXK3P6Am()
	{
		return false;
	}

	// Token: 0x04005A86 RID: 23174
	public float Life;

	// Token: 0x04005A87 RID: 23175
	public float Delay;

	// Token: 0x04005A88 RID: 23176
	public Vector3 worldVelocity;

	// Token: 0x04005A89 RID: 23177
	public Vector3 localVelocity;

	// Token: 0x04005A8A RID: 23178
	public Vector3 rndVelocity;

	// Token: 0x04005A8B RID: 23179
	public Vector3 rndRotation;

	// Token: 0x04005A8C RID: 23180
	private MeshFilter GqNcepBVdcx;

	// Token: 0x04005A8D RID: 23181
	private Vector3[] Aa6ceRDj4ZA;

	// Token: 0x04005A8E RID: 23182
	private Vector3[] fBRcerZ6VYF;

	// Token: 0x04005A8F RID: 23183
	private float YWQcexywHFA;

	// Token: 0x04005A90 RID: 23184
	private bool gfMceTnuQiv;
}
