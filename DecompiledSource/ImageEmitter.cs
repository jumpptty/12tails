using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200209F RID: 8351
[RequireComponent(typeof(MeshFilter))]
[AddComponentMenu("Particles/Image Emitter")]
[RequireComponent(typeof(MeshRenderer))]
[Serializable]
public class ImageEmitter : MonoBehaviour
{
	// Token: 0x0600C364 RID: 50020 RVA: 0x014777F0 File Offset: 0x014759F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageEmitter()
	{
		if (26125 - 442358 != -416233)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (143162 - 124599 != 18564)
			{
				base..ctor();
				if (235212 - 527445 != -292232)
				{
					this.Emission = 1;
					if (203551 - 494225 == -290674)
					{
						this.Life = 1f;
						if (35576 - 93213 != -57636)
						{
							this.startHeight = (float)1;
							if (237095 - 24637 != 212459)
							{
								this.endHeight = (float)1;
								if (235293 - 342176 != -106882)
								{
									this.startWidth = (float)1;
									if (19728 - 365900 == -346172)
									{
										this.endWidth = (float)1;
										if (286654 - 177258 == 109396)
										{
											this.startPosition = Vector3.zero;
											if (208583 - 377320 != -168736)
											{
												this.worldVelocity = Vector3.zero;
												if (295658 - 383689 == -88031)
												{
													this.Color1 = new Color((float)1, (float)1, (float)1, 0.04f);
													if (83486 - 543293 == -459807)
													{
														this.Color2 = new Color((float)1, (float)1, (float)1, 0.3f);
														if (145058 - 494489 == -349431)
														{
															this.Color3 = new Color((float)1, (float)1, (float)1, 0.45f);
															if (195100 - 360840 != -165739)
															{
																this.Color4 = new Color((float)1, (float)1, (float)1, 0.3f);
																if (271662 - 381862 == -110200)
																{
																	this.Color5 = new Color((float)1, (float)1, (float)1, 0.04f);
																	if (295036 - 337823 == -42787)
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

	// Token: 0x0600C365 RID: 50021 RVA: 0x01477A70 File Offset: 0x01475C70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (91074 - 116312 != -25237)
		{
		}
		for (;;)
		{
			if (this.Emission < 1)
			{
				if (292871 - 21931 == 270941)
				{
					continue;
				}
				this.Emission = 1;
				if (214245 - 56629 == 157617)
				{
					continue;
				}
			}
			this.mMeshFilter = (MeshFilter)this.gameObject.GetComponent(typeof(MeshFilter));
			if (115556 - 150216 == -34660)
			{
				if (!this.mMeshFilter)
				{
					if (121592 - 506360 != -384767)
					{
						Debug.Log("Image Emitter Error : MeshFilter doesn't exist");
						if (260740 - 400330 != -139589)
						{
							this.enabled = false;
							if (90732 - 258319 != -167586)
							{
								break;
							}
						}
					}
				}
				else
				{
					this.iC7nTm50ASa = this.transform;
					if (56056 - 12575 == 43481)
					{
						this.EZHnTjWfZPq = Camera.main.transform;
						if (255493 - 206921 == 48572)
						{
							if (!this.EZHnTjWfZPq)
							{
								if (157452 - 278385 == -120933)
								{
									this.enabled = false;
									if (7688 - 226632 != -218943)
									{
										break;
									}
								}
							}
							else
							{
								this.HlZnTDg9iDn = new UnityScript.Lang.Array();
								if (130206 - 51272 != 78935)
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

	// Token: 0x0600C366 RID: 50022 RVA: 0x01477C64 File Offset: 0x01475E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (285968 - 531175 != -245206)
		{
		}
		for (;;)
		{
			IL_1363:
			float time = Time.time;
			if (230847 - 10165 != 220683)
			{
				this.kROnTihwD4c += Time.deltaTime;
				if (77552 - 256104 == -178552)
				{
					if (this.kROnTihwD4c >= this.Life + this.Delay + this.EmissionTime)
					{
						if (206633 - 370688 != -164055)
						{
							continue;
						}
						if (this.repeatForever)
						{
							if (54082 - 3643 != 50439)
							{
								continue;
							}
							this.kROnTihwD4c = (float)0;
							if (282297 - 553815 != -271518)
							{
								continue;
							}
							this.HlZnTDg9iDn.clear();
							if (104095 - 334206 != -230111)
							{
								continue;
							}
							this.mMeshFilter.mesh.Clear();
							if (256687 - 69000 == 187688)
							{
								continue;
							}
						}
						else
						{
							UnityEngine.Object.Destroy(this.gameObject);
							if (47526 - 383825 != -336298)
							{
								break;
							}
							continue;
						}
					}
					if (this.kROnTihwD4c < this.Delay)
					{
						if (133164 - 100208 != 32957)
						{
							break;
						}
					}
					else
					{
						if (this.EmissionTime == (float)0)
						{
							if (138666 - 47436 != 91230)
							{
								continue;
							}
							if (this.Emission > 99)
							{
								if (18991 - 465971 == -446979)
								{
									continue;
								}
								this.Emission = 99;
								if (250246 - 229001 == 21246)
								{
									continue;
								}
							}
						}
						else if ((float)this.Emission / this.EmissionTime > (float)999)
						{
							if (255743 - 205856 == 49888)
							{
								continue;
							}
							this.Emission = (int)((float)999 * this.EmissionTime);
							if (1524 - 140307 != -138783)
							{
								continue;
							}
						}
						while (this.HlZnTDg9iDn.length < this.Emission)
						{
							ImageParticle imageParticle = new ImageParticle();
							if (257763 - 443954 != -186191)
							{
								goto IL_1363;
							}
							imageParticle.life = (float)this.HlZnTDg9iDn.length * (this.EmissionTime / (float)this.Emission);
							if (25772 - 237571 == -211798)
							{
								goto IL_1363;
							}
							if (this.useWorldSpace)
							{
								if (3155 - 541488 != -538333)
								{
									goto IL_1363;
								}
								imageParticle.point = Vector3.zero;
								if (23462 - 366741 == -343278)
								{
									goto IL_1363;
								}
							}
							else
							{
								imageParticle.point.x = UnityEngine.Random.Range(-this.startPosition.x, this.startPosition.x);
								if (273798 - 501851 == -228052)
								{
									goto IL_1363;
								}
								imageParticle.point.y = UnityEngine.Random.Range(-this.startPosition.y, this.startPosition.y);
								if (47405 - 528433 != -481028)
								{
									goto IL_1363;
								}
								imageParticle.point.z = UnityEngine.Random.Range(-this.startPosition.z, this.startPosition.z);
								if (62404 - 307771 != -245367)
								{
									goto IL_1363;
								}
							}
							imageParticle.velocity = imageParticle.point.normalized * (this.localVelocity + UnityEngine.Random.Range((float)0, this.rndVelocity));
							if (18160 - 135868 != -117708)
							{
								goto IL_1363;
							}
							imageParticle.rndScale = UnityEngine.Random.Range((float)0, this.rndScale);
							if (208914 - 163127 == 45788)
							{
								goto IL_1363;
							}
							imageParticle.rndRotation = UnityEngine.Random.Range((float)0, this.rndRotation) + this.startAngle + this.spreadAngle * (float)this.HlZnTDg9iDn.length;
							if (265280 - 296396 != -31116)
							{
								goto IL_1363;
							}
							imageParticle.rndLife = UnityEngine.Random.Range((float)0, this.rndLife);
							if (206363 - 395956 != -189593)
							{
								goto IL_1363;
							}
							this.HlZnTDg9iDn.Push(imageParticle);
							if (159725 - 595816 == -436090)
							{
								goto IL_1363;
							}
						}
						if (55090 - 455315 == -400225)
						{
							Vector3[] array = new Vector3[this.Emission * 4];
							if (61878 - 36676 == 25202)
							{
								Color[] array2 = new Color[this.Emission * 4];
								if (132892 - 96423 == 36469)
								{
									Vector2[] array3 = new Vector2[this.Emission * 4];
									if (190258 - 535552 != -345293)
									{
										int[] array4 = new int[this.Emission * 6];
										if (266543 - 351134 == -84591)
										{
											Mesh mesh = this.mMeshFilter.mesh;
											if (203161 - 497166 != -294004)
											{
												mesh.Clear();
												if (262550 - 392118 == -129568)
												{
													float num = (float)0;
													if (171343 - 101980 == 69363)
													{
														float d = 0f;
														if (167490 - 396325 == -228835)
														{
															float d2 = 0f;
															if (265082 - 26134 == 238948)
															{
																Vector3 vector = default(Vector3);
																if (35823 - 217656 != -181832)
																{
																	Vector3 vector2 = default(Vector3);
																	if (245892 - 155163 != 90730)
																	{
																		float d3 = 0f;
																		if (110399 - 111681 == -1282)
																		{
																			float d4 = 0f;
																			if (73442 - 472754 == -399312)
																			{
																				Vector3 vector3 = default(Vector3);
																				if (99922 - 127365 == -27443)
																				{
																					Vector3 b = default(Vector3);
																					if (284679 - 312843 != -28163)
																					{
																						float num2 = 0f;
																						if (180340 - 1781 != 178560)
																						{
																							float f = 0f;
																							if (23801 - 343788 != -319986)
																							{
																								Color color = default(Color);
																								if (238234 - 383494 == -145260)
																								{
																									if (this.EmissionTime == (float)0)
																									{
																										if (64312 - 384389 == -320076)
																										{
																											continue;
																										}
																										int num3 = 0;
																										if (232832 - 587299 != -354467)
																										{
																											continue;
																										}
																										IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.HlZnTDg9iDn);
																										if (192503 - 63963 == 128541)
																										{
																											continue;
																										}
																										while (enumerator.MoveNext())
																										{
																											object obj = enumerator.Current;
																											object obj3;
																											object obj2 = obj3 = obj;
																											if (!(obj2 is ImageParticle))
																											{
																												obj3 = RuntimeServices.Coerce(obj2, typeof(ImageParticle));
																											}
																											ImageParticle imageParticle2 = (ImageParticle)obj3;
																											if (107187 - 502171 == -394983)
																											{
																												goto IL_1363;
																											}
																											if (this.Life - imageParticle2.rndLife > (float)0)
																											{
																												if (232237 - 91235 != 141002)
																												{
																													goto IL_1363;
																												}
																												num = Mathf.Clamp01((this.kROnTihwD4c - this.Delay - imageParticle2.life - imageParticle2.rndLife) / (this.Life - imageParticle2.rndLife));
																												if (148280 - 488077 != -339797)
																												{
																													goto IL_1363;
																												}
																												UnityRuntimeServices.Update(enumerator, imageParticle2);
																												if (240187 - 565394 != -325207)
																												{
																													goto IL_1363;
																												}
																											}
																											else
																											{
																												num = (float)0;
																												if (165104 - 556798 != -391694)
																												{
																													goto IL_1363;
																												}
																											}
																											if (this.useWorldSpace)
																											{
																												if (175312 - 12909 != 162403)
																												{
																													goto IL_1363;
																												}
																												if (imageParticle2.point == Vector3.zero)
																												{
																													if (250031 - 330612 == -80580)
																													{
																														goto IL_1363;
																													}
																													vector3.x = UnityEngine.Random.Range(-this.startPosition.x, this.startPosition.x);
																													if (215219 - 305205 != -89986)
																													{
																														goto IL_1363;
																													}
																													vector3.y = UnityEngine.Random.Range(-this.startPosition.y, this.startPosition.y);
																													if (168895 - 68394 == 100502)
																													{
																														goto IL_1363;
																													}
																													vector3.z = UnityEngine.Random.Range(-this.startPosition.z, this.startPosition.z);
																													if (58749 - 221762 == -163012)
																													{
																														goto IL_1363;
																													}
																													imageParticle2.point = this.iC7nTm50ASa.TransformPoint(vector3);
																													if (277214 - 488151 == -210936)
																													{
																														goto IL_1363;
																													}
																													UnityRuntimeServices.Update(enumerator, imageParticle2);
																													if (251092 - 170547 == 80546)
																													{
																														goto IL_1363;
																													}
																												}
																												else
																												{
																													vector3 = this.iC7nTm50ASa.InverseTransformPoint(imageParticle2.point);
																													if (220802 - 273621 != -52819)
																													{
																														goto IL_1363;
																													}
																													UnityRuntimeServices.Update(enumerator, imageParticle2);
																													if (217966 - 216306 == 1661)
																													{
																														goto IL_1363;
																													}
																												}
																											}
																											else
																											{
																												vector3 = imageParticle2.point;
																												if (251559 - 344640 != -93081)
																												{
																													goto IL_1363;
																												}
																												UnityRuntimeServices.Update(enumerator, imageParticle2);
																												if (14510 - 326063 != -311553)
																												{
																													goto IL_1363;
																												}
																											}
																											b = num * (imageParticle2.velocity + this.worldVelocity);
																											if (13155 - 19220 == -6064)
																											{
																												goto IL_1363;
																											}
																											UnityRuntimeServices.Update(enumerator, imageParticle2);
																											if (9774 - 482419 == -472644)
																											{
																												goto IL_1363;
																											}
																											num2 = (float)1 + imageParticle2.rndScale;
																											if (117396 - 505912 == -388515)
																											{
																												goto IL_1363;
																											}
																											UnityRuntimeServices.Update(enumerator, imageParticle2);
																											if (153161 - 325974 != -172813)
																											{
																												goto IL_1363;
																											}
																											f = Mathf.Lerp(imageParticle2.rndRotation, this.Rotation + imageParticle2.rndRotation, num);
																											if (161403 - 371566 != -210163)
																											{
																												goto IL_1363;
																											}
																											UnityRuntimeServices.Update(enumerator, imageParticle2);
																											if (197667 - 583621 != -385954)
																											{
																												goto IL_1363;
																											}
																											d = 0.5f * Mathf.Lerp(this.startWidth, this.endWidth, num);
																											if (22375 - 494880 == -472504)
																											{
																												goto IL_1363;
																											}
																											d2 = 0.5f * Mathf.Lerp(this.startHeight, this.endHeight, num);
																											if (130775 - 459181 == -328405)
																											{
																												goto IL_1363;
																											}
																											if (num < 0.25f)
																											{
																												if (9598 - 385247 == -375648)
																												{
																													goto IL_1363;
																												}
																												color = Color.Lerp(this.Color1, this.Color2, (float)4 * num);
																												if (28325 - 355783 == -327457)
																												{
																													goto IL_1363;
																												}
																											}
																											else if (num < 0.5f)
																											{
																												if (156049 - 454704 != -298655)
																												{
																													goto IL_1363;
																												}
																												color = Color.Lerp(this.Color2, this.Color3, (float)4 * (num - 0.25f));
																												if (100468 - 370255 == -269786)
																												{
																													goto IL_1363;
																												}
																											}
																											else if (num < 0.75f)
																											{
																												if (283074 - 282480 == 595)
																												{
																													goto IL_1363;
																												}
																												color = Color.Lerp(this.Color3, this.Color4, (float)4 * (num - 0.5f));
																												if (80267 - 450237 == -369969)
																												{
																													goto IL_1363;
																												}
																											}
																											else
																											{
																												color = Color.Lerp(this.Color4, this.Color5, (float)4 * (num - 0.75f));
																												if (106676 - 549720 != -443044)
																												{
																													goto IL_1363;
																												}
																											}
																											d3 = Mathf.Sin(f);
																											if (271966 - 330127 != -58161)
																											{
																												goto IL_1363;
																											}
																											d4 = Mathf.Cos(f);
																											if (286318 - 308901 == -22582)
																											{
																												goto IL_1363;
																											}
																											eImageEmitterMode imageEmitterMode = this.ImageEmitterMode;
																											if (54052 - 159171 != -105119)
																											{
																												goto IL_1363;
																											}
																											if (imageEmitterMode == eImageEmitterMode.Horizontal)
																											{
																												if (291766 - 97280 != 194486)
																												{
																													goto IL_1363;
																												}
																												vector = d2 * (d4 * Vector3.forward - d3 * Vector3.right);
																												if (219748 - 321134 == -101385)
																												{
																													goto IL_1363;
																												}
																												vector2 = d * (d3 * Vector3.forward + d4 * Vector3.right);
																												if (241604 - 196860 != 44744)
																												{
																													goto IL_1363;
																												}
																												vector = this.iC7nTm50ASa.InverseTransformDirection(vector);
																												if (47301 - 445685 != -398384)
																												{
																													goto IL_1363;
																												}
																												vector2 = this.iC7nTm50ASa.InverseTransformDirection(vector2);
																												if (781 - 453223 == -452441)
																												{
																													goto IL_1363;
																												}
																											}
																											else if (imageEmitterMode == eImageEmitterMode.Vertical)
																											{
																												if (238658 - 371516 == -132857)
																												{
																													goto IL_1363;
																												}
																												vector = d2 * (d4 * Vector3.up - d3 * Vector3.right);
																												if (262166 - 101282 == 160885)
																												{
																													goto IL_1363;
																												}
																												vector2 = d * (d3 * this.EZHnTjWfZPq.up + d4 * this.EZHnTjWfZPq.right);
																												if (122761 - 33388 != 89373)
																												{
																													goto IL_1363;
																												}
																												vector = this.iC7nTm50ASa.InverseTransformDirection(vector);
																												if (246682 - 430759 != -184077)
																												{
																													goto IL_1363;
																												}
																												vector2 = this.iC7nTm50ASa.InverseTransformDirection(vector2);
																												if (92705 - 359896 == -267190)
																												{
																													goto IL_1363;
																												}
																											}
																											else if (imageEmitterMode == eImageEmitterMode.LocalRotation)
																											{
																												if (121590 - 576444 == -454853)
																												{
																													goto IL_1363;
																												}
																												vector = d2 * (d4 * Vector3.up - d3 * Vector3.right);
																												if (48667 - 151108 == -102440)
																												{
																													goto IL_1363;
																												}
																												vector2 = d * (d3 * Vector3.up + d4 * Vector3.right);
																												if (184986 - 319750 == -134763)
																												{
																													goto IL_1363;
																												}
																											}
																											else
																											{
																												vector = d2 * (d4 * this.EZHnTjWfZPq.up - d3 * this.EZHnTjWfZPq.right);
																												if (109835 - 55991 == 53845)
																												{
																													goto IL_1363;
																												}
																												vector2 = d * (d3 * this.EZHnTjWfZPq.up + d4 * this.EZHnTjWfZPq.right);
																												if (18563 - 368095 != -349532)
																												{
																													goto IL_1363;
																												}
																												vector = this.iC7nTm50ASa.InverseTransformDirection(vector);
																												if (104770 - 553964 != -449194)
																												{
																													goto IL_1363;
																												}
																												vector2 = this.iC7nTm50ASa.InverseTransformDirection(vector2);
																												if (167476 - 550139 == -382662)
																												{
																													goto IL_1363;
																												}
																											}
																											array[num3 * 4 + 0] = vector3 + num2 * (-vector - vector2) + b;
																											if (176671 - 203477 != -26806)
																											{
																												goto IL_1363;
																											}
																											array[num3 * 4 + 1] = vector3 + num2 * (-vector + vector2) + b;
																											if (284687 - 278803 == 5885)
																											{
																												goto IL_1363;
																											}
																											array[num3 * 4 + 2] = vector3 + num2 * (vector - vector2) + b;
																											if (234614 - 178535 != 56079)
																											{
																												goto IL_1363;
																											}
																											array[num3 * 4 + 3] = vector3 + num2 * (vector + vector2) + b;
																											if (155833 - 553204 != -397371)
																											{
																												goto IL_1363;
																											}
																											array3[num3 * 4 + 0] = new Vector2((float)0, (float)0);
																											if (21328 - 161063 != -139735)
																											{
																												goto IL_1363;
																											}
																											array3[num3 * 4 + 1] = new Vector2((float)0, (float)1);
																											if (190644 - 100790 != 89854)
																											{
																												goto IL_1363;
																											}
																											array3[num3 * 4 + 2] = new Vector2((float)1, (float)0);
																											if (70343 - 547489 != -477146)
																											{
																												goto IL_1363;
																											}
																											array3[num3 * 4 + 3] = new Vector2((float)1, (float)1);
																											if (272103 - 532602 != -260499)
																											{
																												goto IL_1363;
																											}
																											array2[num3 * 4 + 0] = color;
																											if (219369 - 516415 != -297046)
																											{
																												goto IL_1363;
																											}
																											array2[num3 * 4 + 1] = color;
																											if (84085 - 267706 != -183621)
																											{
																												goto IL_1363;
																											}
																											array2[num3 * 4 + 2] = color;
																											if (204882 - 562213 == -357330)
																											{
																												goto IL_1363;
																											}
																											array2[num3 * 4 + 3] = color;
																											if (247507 - 498190 == -250682)
																											{
																												goto IL_1363;
																											}
																											num3++;
																											if (83670 - 121022 == -37351)
																											{
																												goto IL_1363;
																											}
																										}
																										if (47178 - 222966 != -175788)
																										{
																											continue;
																										}
																									}
																									else
																									{
																										int num4 = 0;
																										if (9777 - 121398 == -111620)
																										{
																											continue;
																										}
																										IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(this.HlZnTDg9iDn);
																										if (293054 - 180634 == 112421)
																										{
																											continue;
																										}
																										while (enumerator2.MoveNext())
																										{
																											object obj4 = enumerator2.Current;
																											object obj6;
																											object obj5 = obj6 = obj4;
																											if (!(obj5 is ImageParticle))
																											{
																												obj6 = RuntimeServices.Coerce(obj5, typeof(ImageParticle));
																											}
																											ImageParticle imageParticle3 = (ImageParticle)obj6;
																											if (76760 - 111876 == -35115)
																											{
																												goto IL_1363;
																											}
																											if (imageParticle3.life <= this.kROnTihwD4c - this.Delay)
																											{
																												if (213714 - 570986 != -357272)
																												{
																													goto IL_1363;
																												}
																												if (imageParticle3.life + this.Life > this.kROnTihwD4c - this.Delay)
																												{
																													if (145661 - 148002 == -2340)
																													{
																														goto IL_1363;
																													}
																													if (this.Life - imageParticle3.rndLife > (float)0)
																													{
																														if (161615 - 347408 == -185792)
																														{
																															goto IL_1363;
																														}
																														num = Mathf.Clamp01((this.kROnTihwD4c - this.Delay - imageParticle3.life - imageParticle3.rndLife) / (this.Life - imageParticle3.rndLife));
																														if (17268 - 478150 != -460882)
																														{
																															goto IL_1363;
																														}
																														UnityRuntimeServices.Update(enumerator2, imageParticle3);
																														if (181330 - 279085 != -97755)
																														{
																															goto IL_1363;
																														}
																													}
																													else
																													{
																														num = (float)0;
																														if (176713 - 560254 != -383541)
																														{
																															goto IL_1363;
																														}
																													}
																													if (this.useWorldSpace)
																													{
																														if (278516 - 92370 == 186147)
																														{
																															goto IL_1363;
																														}
																														if (imageParticle3.point == Vector3.zero)
																														{
																															if (273997 - 196352 != 77645)
																															{
																																goto IL_1363;
																															}
																															vector3.x = UnityEngine.Random.Range(-this.startPosition.x, this.startPosition.x);
																															if (161417 - 69256 == 92162)
																															{
																																goto IL_1363;
																															}
																															vector3.y = UnityEngine.Random.Range(-this.startPosition.y, this.startPosition.y);
																															if (227178 - 432236 == -205057)
																															{
																																goto IL_1363;
																															}
																															vector3.z = UnityEngine.Random.Range(-this.startPosition.z, this.startPosition.z);
																															if (214542 - 396674 != -182132)
																															{
																																goto IL_1363;
																															}
																															imageParticle3.point = this.iC7nTm50ASa.TransformPoint(vector3);
																															if (86490 - 231936 == -145445)
																															{
																																goto IL_1363;
																															}
																															UnityRuntimeServices.Update(enumerator2, imageParticle3);
																															if (50412 - 45986 == 4427)
																															{
																																goto IL_1363;
																															}
																														}
																														else
																														{
																															vector3 = this.iC7nTm50ASa.InverseTransformPoint(imageParticle3.point);
																															if (68360 - 123777 != -55417)
																															{
																																goto IL_1363;
																															}
																															UnityRuntimeServices.Update(enumerator2, imageParticle3);
																															if (61333 - 381476 != -320143)
																															{
																																goto IL_1363;
																															}
																														}
																													}
																													else
																													{
																														vector3 = imageParticle3.point;
																														if (259928 - 218924 != 41004)
																														{
																															goto IL_1363;
																														}
																														UnityRuntimeServices.Update(enumerator2, imageParticle3);
																														if (276348 - 166737 != 109611)
																														{
																															goto IL_1363;
																														}
																													}
																													b = num * (imageParticle3.velocity + this.worldVelocity);
																													if (82546 - 85195 == -2648)
																													{
																														goto IL_1363;
																													}
																													UnityRuntimeServices.Update(enumerator2, imageParticle3);
																													if (227933 - 41 == 227893)
																													{
																														goto IL_1363;
																													}
																													num2 = (float)1 + imageParticle3.rndScale;
																													if (23679 - 493623 != -469944)
																													{
																														goto IL_1363;
																													}
																													UnityRuntimeServices.Update(enumerator2, imageParticle3);
																													if (69153 - 319155 != -250002)
																													{
																														goto IL_1363;
																													}
																													f = Mathf.Lerp(imageParticle3.rndRotation, this.Rotation + imageParticle3.rndRotation, num);
																													if (267621 - 471621 != -204000)
																													{
																														goto IL_1363;
																													}
																													UnityRuntimeServices.Update(enumerator2, imageParticle3);
																													if (281897 - 531263 == -249365)
																													{
																														goto IL_1363;
																													}
																													d = 0.5f * num2 * Mathf.Lerp(this.startWidth, this.endWidth, num);
																													if (195230 - 142044 != 53186)
																													{
																														goto IL_1363;
																													}
																													d2 = 0.5f * num2 * Mathf.Lerp(this.startHeight, this.endHeight, num);
																													if (30911 - 283653 != -252742)
																													{
																														goto IL_1363;
																													}
																													d3 = Mathf.Sin(f);
																													if (27001 - 23456 != 3545)
																													{
																														goto IL_1363;
																													}
																													d4 = Mathf.Cos(f);
																													if (125712 - 98356 == 27357)
																													{
																														goto IL_1363;
																													}
																													eImageEmitterMode imageEmitterMode2 = this.ImageEmitterMode;
																													if (283803 - 398012 == -114208)
																													{
																														goto IL_1363;
																													}
																													if (imageEmitterMode2 == eImageEmitterMode.Horizontal)
																													{
																														if (150785 - 66736 == 84050)
																														{
																															goto IL_1363;
																														}
																														vector = d2 * (d4 * Vector3.forward - d3 * Vector3.right);
																														if (184200 - 152138 == 32063)
																														{
																															goto IL_1363;
																														}
																														vector2 = d * (d3 * Vector3.forward + d4 * Vector3.right);
																														if (288321 - 42560 != 245761)
																														{
																															goto IL_1363;
																														}
																														vector = this.iC7nTm50ASa.InverseTransformDirection(vector);
																														if (225779 - 262595 == -36815)
																														{
																															goto IL_1363;
																														}
																														vector2 = this.iC7nTm50ASa.InverseTransformDirection(vector2);
																														if (230996 - 202351 == 28646)
																														{
																															goto IL_1363;
																														}
																													}
																													else if (imageEmitterMode2 == eImageEmitterMode.Vertical)
																													{
																														if (218768 - 336629 == -117860)
																														{
																															goto IL_1363;
																														}
																														vector = d2 * (d4 * Vector3.up - d3 * Vector3.right);
																														if (264138 - 104429 == 159710)
																														{
																															goto IL_1363;
																														}
																														vector2 = d * (d3 * this.EZHnTjWfZPq.up + d4 * this.EZHnTjWfZPq.right);
																														if (147574 - 419776 != -272202)
																														{
																															goto IL_1363;
																														}
																														vector = this.iC7nTm50ASa.InverseTransformDirection(vector);
																														if (10329 - 14043 != -3714)
																														{
																															goto IL_1363;
																														}
																														vector2 = this.iC7nTm50ASa.InverseTransformDirection(vector2);
																														if (160804 - 4970 == 155835)
																														{
																															goto IL_1363;
																														}
																													}
																													else if (imageEmitterMode2 == eImageEmitterMode.LocalRotation)
																													{
																														if (76966 - 24177 != 52789)
																														{
																															goto IL_1363;
																														}
																														vector = d2 * (d4 * Vector3.up - d3 * Vector3.right);
																														if (266567 - 484434 != -217867)
																														{
																															goto IL_1363;
																														}
																														vector2 = d * (d3 * Vector3.up + d4 * Vector3.right);
																														if (290666 - 521409 == -230742)
																														{
																															goto IL_1363;
																														}
																													}
																													else
																													{
																														vector = d2 * (d4 * this.EZHnTjWfZPq.up - d3 * this.EZHnTjWfZPq.right);
																														if (62181 - 311874 != -249693)
																														{
																															goto IL_1363;
																														}
																														vector2 = d * (d3 * this.EZHnTjWfZPq.up + d4 * this.EZHnTjWfZPq.right);
																														if (71813 - 280268 != -208455)
																														{
																															goto IL_1363;
																														}
																														vector = this.iC7nTm50ASa.InverseTransformDirection(vector);
																														if (60231 - 114838 == -54606)
																														{
																															goto IL_1363;
																														}
																														vector2 = this.iC7nTm50ASa.InverseTransformDirection(vector2);
																														if (127217 - 264699 != -137482)
																														{
																															goto IL_1363;
																														}
																													}
																													if (num < 0.25f)
																													{
																														if (15055 - 58784 != -43729)
																														{
																															goto IL_1363;
																														}
																														color = Color.Lerp(this.Color1, this.Color2, (float)4 * num);
																														if (123949 - 382532 != -258583)
																														{
																															goto IL_1363;
																														}
																													}
																													else if (num < 0.5f)
																													{
																														if (50777 - 252843 == -202065)
																														{
																															goto IL_1363;
																														}
																														color = Color.Lerp(this.Color2, this.Color3, (float)4 * (num - 0.25f));
																														if (48823 - 390629 == -341805)
																														{
																															goto IL_1363;
																														}
																													}
																													else if (num < 0.75f)
																													{
																														if (99318 - 115970 != -16652)
																														{
																															goto IL_1363;
																														}
																														color = Color.Lerp(this.Color3, this.Color4, (float)4 * (num - 0.5f));
																														if (11353 - 224147 != -212794)
																														{
																															goto IL_1363;
																														}
																													}
																													else
																													{
																														color = Color.Lerp(this.Color4, this.Color5, (float)4 * (num - 0.75f));
																														if (145639 - 579676 != -434037)
																														{
																															goto IL_1363;
																														}
																													}
																													array[num4 * 4 + 0] = vector3 + (-vector - vector2) + b;
																													if (37195 - 209990 != -172795)
																													{
																														goto IL_1363;
																													}
																													array[num4 * 4 + 1] = vector3 + (-vector + vector2) + b;
																													if (27579 - 533096 == -505516)
																													{
																														goto IL_1363;
																													}
																													array[num4 * 4 + 2] = vector3 + (vector - vector2) + b;
																													if (22594 - 154956 == -132361)
																													{
																														goto IL_1363;
																													}
																													array[num4 * 4 + 3] = vector3 + (vector + vector2) + b;
																													if (44580 - 28029 == 16552)
																													{
																														goto IL_1363;
																													}
																													array3[num4 * 4 + 0] = new Vector2((float)0, (float)0);
																													if (241178 - 445017 != -203839)
																													{
																														goto IL_1363;
																													}
																													array3[num4 * 4 + 1] = new Vector2((float)0, (float)1);
																													if (134783 - 481297 == -346513)
																													{
																														goto IL_1363;
																													}
																													array3[num4 * 4 + 2] = new Vector2((float)1, (float)0);
																													if (183595 - 563721 != -380126)
																													{
																														goto IL_1363;
																													}
																													array3[num4 * 4 + 3] = new Vector2((float)1, (float)1);
																													if (99653 - 338059 != -238406)
																													{
																														goto IL_1363;
																													}
																													array2[num4 * 4 + 0] = color;
																													if (269958 - 595762 == -325803)
																													{
																														goto IL_1363;
																													}
																													array2[num4 * 4 + 1] = color;
																													if (128890 - 228075 != -99185)
																													{
																														goto IL_1363;
																													}
																													array2[num4 * 4 + 2] = color;
																													if (210104 - 137030 == 73075)
																													{
																														goto IL_1363;
																													}
																													array2[num4 * 4 + 3] = color;
																													if (293687 - 56543 == 237145)
																													{
																														goto IL_1363;
																													}
																													num4++;
																													if (89804 - 224027 != -134223)
																													{
																														goto IL_1363;
																													}
																												}
																											}
																										}
																										if (53264 - 266315 == -213050)
																										{
																											continue;
																										}
																										if (num4 > 0)
																										{
																											if (156002 - 130575 != 25427)
																											{
																												continue;
																											}
																											array4 = new int[num4 * 6];
																											if (95936 - 107384 == -11447)
																											{
																												continue;
																											}
																										}
																									}
																									int i = 0;
																									if (2905 - 449460 == -446555)
																									{
																										while (i < Extensions.get_length(array4) / 6)
																										{
																											array4[i * 6 + 0] = i * 4 + 0;
																											if (43291 - 567931 == -524639)
																											{
																												goto IL_1363;
																											}
																											array4[i * 6 + 1] = i * 4 + 1;
																											if (227353 - 259038 == -31684)
																											{
																												goto IL_1363;
																											}
																											array4[i * 6 + 2] = i * 4 + 2;
																											if (78583 - 341989 == -263405)
																											{
																												goto IL_1363;
																											}
																											array4[i * 6 + 3] = i * 4 + 2;
																											if (296526 - 469322 != -172796)
																											{
																												goto IL_1363;
																											}
																											array4[i * 6 + 4] = i * 4 + 1;
																											if (72240 - 320034 == -247793)
																											{
																												goto IL_1363;
																											}
																											array4[i * 6 + 5] = i * 4 + 3;
																											if (133260 - 235724 != -102464)
																											{
																												goto IL_1363;
																											}
																											i++;
																											if (232005 - 31325 != 200680)
																											{
																												goto IL_1363;
																											}
																										}
																										if (87168 - 217226 == -130058)
																										{
																											mesh.vertices = array;
																											if (64216 - 257241 == -193025)
																											{
																												mesh.colors = array2;
																												if (131016 - 137453 != -6436)
																												{
																													mesh.uv = array3;
																													if (79371 - 173686 != -94314)
																													{
																														mesh.triangles = array4;
																														if (30347 - 329070 != -298722)
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
			}
		}
	}

	// Token: 0x0600C367 RID: 50023 RVA: 0x0147A0D8 File Offset: 0x014782D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C368 RID: 50024 RVA: 0x0147A0DC File Offset: 0x014782DC
	internal static bool IwIJ7Lto23KkppYLU6hu()
	{
		return true;
	}

	// Token: 0x0600C369 RID: 50025 RVA: 0x0147A0E0 File Offset: 0x014782E0
	internal static bool QPEMCnto8YbsebUJ8R0L()
	{
		return false;
	}

	// Token: 0x0400A5CC RID: 42444
	public int Emission;

	// Token: 0x0400A5CD RID: 42445
	public float EmissionTime;

	// Token: 0x0400A5CE RID: 42446
	public float Life;

	// Token: 0x0400A5CF RID: 42447
	public float Delay;

	// Token: 0x0400A5D0 RID: 42448
	public float startHeight;

	// Token: 0x0400A5D1 RID: 42449
	public float endHeight;

	// Token: 0x0400A5D2 RID: 42450
	public float startWidth;

	// Token: 0x0400A5D3 RID: 42451
	public float endWidth;

	// Token: 0x0400A5D4 RID: 42452
	public float rndScale;

	// Token: 0x0400A5D5 RID: 42453
	public float rndLife;

	// Token: 0x0400A5D6 RID: 42454
	public Vector3 startPosition;

	// Token: 0x0400A5D7 RID: 42455
	public float localVelocity;

	// Token: 0x0400A5D8 RID: 42456
	public float rndVelocity;

	// Token: 0x0400A5D9 RID: 42457
	public Vector3 worldVelocity;

	// Token: 0x0400A5DA RID: 42458
	public eImageEmitterMode ImageEmitterMode;

	// Token: 0x0400A5DB RID: 42459
	public bool useWorldSpace;

	// Token: 0x0400A5DC RID: 42460
	public Color Color1;

	// Token: 0x0400A5DD RID: 42461
	public Color Color2;

	// Token: 0x0400A5DE RID: 42462
	public Color Color3;

	// Token: 0x0400A5DF RID: 42463
	public Color Color4;

	// Token: 0x0400A5E0 RID: 42464
	public Color Color5;

	// Token: 0x0400A5E1 RID: 42465
	public float Rotation;

	// Token: 0x0400A5E2 RID: 42466
	public float rndRotation;

	// Token: 0x0400A5E3 RID: 42467
	public float startAngle;

	// Token: 0x0400A5E4 RID: 42468
	public float spreadAngle;

	// Token: 0x0400A5E5 RID: 42469
	public bool repeatForever;

	// Token: 0x0400A5E6 RID: 42470
	private float kROnTihwD4c;

	// Token: 0x0400A5E7 RID: 42471
	private UnityScript.Lang.Array HlZnTDg9iDn;

	// Token: 0x0400A5E8 RID: 42472
	private Transform iC7nTm50ASa;

	// Token: 0x0400A5E9 RID: 42473
	private Transform EZHnTjWfZPq;

	// Token: 0x0400A5EA RID: 42474
	public MeshFilter mMeshFilter;
}
