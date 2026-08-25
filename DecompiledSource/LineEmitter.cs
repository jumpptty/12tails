using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020020A2 RID: 8354
[RequireComponent(typeof(MeshFilter))]
[AddComponentMenu("Particles/Line Emitter")]
[RequireComponent(typeof(MeshRenderer))]
[Serializable]
public class LineEmitter : MonoBehaviour
{
	// Token: 0x0600C36D RID: 50029 RVA: 0x0147A0FC File Offset: 0x014782FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineEmitter()
	{
		if (58692 - 153023 != -94330)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (284204 - 256340 != 27865)
			{
				base..ctor();
				if (140125 - 408893 != -268767)
				{
					this.Life = 1f;
					if (174415 - 271894 != -97478)
					{
						this.Emission = (float)16;
						if (53119 - 48021 != 5099)
						{
							this.startRadius = (float)1;
							if (124848 - 539075 != -414226)
							{
								this.endRadius = (float)1;
								if (290314 - 490950 != -200635)
								{
									this.startHeight = (float)1;
									if (266681 - 575021 != -308339)
									{
										this.endHeight = (float)1;
										if (165144 - 529986 == -364842)
										{
											this.rndHeight = (float)1;
											if (237439 - 85434 == 152005)
											{
												this.startWidth = 0.05f;
												if (89651 - 253236 == -163585)
												{
													this.endWidth = 0.05f;
													if (290860 - 421725 == -130865)
													{
														this.localVelocity = Vector3.zero;
														if (246972 - 412834 == -165862)
														{
															this.rndVelocity = Vector3.one;
															if (222032 - 337786 != -115753)
															{
																this.Color1 = new Color((float)1, (float)1, (float)1, 0.04f);
																if (266263 - 530970 != -264706)
																{
																	this.Color2 = new Color((float)1, (float)1, (float)1, 0.3f);
																	if (155405 - 501545 == -346140)
																	{
																		this.Color3 = new Color((float)1, (float)1, (float)1, 0.45f);
																		if (119347 - 17381 != 101967)
																		{
																			this.Color4 = new Color((float)1, (float)1, (float)1, 0.3f);
																			if (35951 - 464058 != -428106)
																			{
																				this.Color5 = new Color((float)1, (float)1, (float)1, 0.04f);
																				if (260956 - 404404 == -143448)
																				{
																					this.localRotation = Vector3.zero;
																					if (104586 - 564853 == -460267)
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

	// Token: 0x0600C36E RID: 50030 RVA: 0x0147A410 File Offset: 0x01478610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (139612 - 172614 != -33001)
		{
		}
		for (;;)
		{
			this.m0BnT9jnZy2 = (MeshFilter)this.gameObject.GetComponent(typeof(MeshFilter));
			if (53975 - 184642 == -130667)
			{
				if (!this.m0BnT9jnZy2)
				{
					if (28258 - 185457 != -157198)
					{
						Debug.Log("Image Emitter Error : MeshFilter doesn't exist");
						if (245563 - 77173 != 168391)
						{
							this.enabled = false;
							if (216700 - 21932 != 194769)
							{
								break;
							}
						}
					}
				}
				else
				{
					this.a9enTFHpaeS = this.transform;
					if (50513 - 461377 != -410863)
					{
						this.sMnnTAjdOPh = Camera.main.transform;
						if (5138 - 583615 != -578476)
						{
							if (!this.sMnnTAjdOPh)
							{
								if (236940 - 517454 == -280514)
								{
									this.enabled = false;
									if (90765 - 11727 != 79039)
									{
										break;
									}
								}
							}
							else
							{
								this.zyfnTkqTbA5 = new UnityScript.Lang.Array();
								if (168225 - 218804 == -50579)
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

	// Token: 0x0600C36F RID: 50031 RVA: 0x0147A5BC File Offset: 0x014787BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (98845 - 597142 != -498297)
		{
		}
		for (;;)
		{
			IL_1049:
			this.A0KnTo3CyuN += Time.deltaTime;
			if (149234 - 532573 == -383339)
			{
				if (this.A0KnTo3CyuN >= this.Life + this.Delay + this.EmissionTime)
				{
					if (172272 - 94215 == 78058)
					{
						continue;
					}
					if (this.repeatForever)
					{
						if (62237 - 407073 == -344835)
						{
							continue;
						}
						this.A0KnTo3CyuN = (float)0;
						if (76677 - 401710 == -325032)
						{
							continue;
						}
						this.zyfnTkqTbA5.clear();
						if (82043 - 276199 == -194155)
						{
							continue;
						}
					}
					else
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (101808 - 10984 != 90824)
						{
							continue;
						}
						break;
					}
				}
				if (this.A0KnTo3CyuN < this.Delay)
				{
					if (69983 - 260579 == -190596)
					{
						break;
					}
				}
				else
				{
					if (this.EmissionTime < (float)0)
					{
						if (111076 - 386737 == -275660)
						{
							continue;
						}
						this.EmissionTime = (float)0;
						if (690 - 53068 != -52378)
						{
							continue;
						}
					}
					while ((float)this.zyfnTkqTbA5.length < this.Emission)
					{
						LineParticle lineParticle = new LineParticle();
						if (288608 - 153919 != 134689)
						{
							goto IL_1049;
						}
						lineParticle.life = UnityEngine.Random.Range((float)0, this.EmissionTime);
						if (244416 - 67969 == 176448)
						{
							goto IL_1049;
						}
						lineParticle.velocity.x = this.localVelocity.x + UnityEngine.Random.Range(-this.rndVelocity.x, this.rndVelocity.x);
						if (216143 - 535556 == -319412)
						{
							goto IL_1049;
						}
						lineParticle.velocity.y = this.localVelocity.y + UnityEngine.Random.Range(-this.rndVelocity.y, this.rndVelocity.y);
						if (244587 - 532381 != -287794)
						{
							goto IL_1049;
						}
						lineParticle.velocity.z = this.localVelocity.z + UnityEngine.Random.Range(-this.rndVelocity.z, this.rndVelocity.z);
						if (174767 - 591808 == -417040)
						{
							goto IL_1049;
						}
						lineParticle.rndRadius = UnityEngine.Random.Range((float)0, this.rndRadius);
						if (291246 - 285381 == 5866)
						{
							goto IL_1049;
						}
						lineParticle.rndHeight = UnityEngine.Random.Range((float)0, this.rndHeight);
						if (32903 - 510054 != -477151)
						{
							goto IL_1049;
						}
						lineParticle.rndWidth = UnityEngine.Random.Range((float)0, this.rndWidth);
						if (52502 - 410992 != -358490)
						{
							goto IL_1049;
						}
						this.zyfnTkqTbA5.Push(lineParticle);
						if (17287 - 172297 != -155010)
						{
							goto IL_1049;
						}
					}
					if (99161 - 222793 != -123631)
					{
						if (this.localRotation != Vector3.zero)
						{
							if (6685 - 379446 == -372760)
							{
								continue;
							}
							this.a9enTFHpaeS.Rotate((float)115 * this.localRotation * Time.deltaTime);
							if (267371 - 159023 != 108348)
							{
								continue;
							}
						}
						Vector3[] array = new Vector3[(int)(this.Emission * (float)4)];
						if (279269 - 173253 == 106016)
						{
							Color[] array2 = new Color[(int)(this.Emission * (float)4)];
							if (269742 - 268628 == 1114)
							{
								Vector2[] array3 = new Vector2[(int)(this.Emission * (float)4)];
								if (231988 - 193389 != 38600)
								{
									int[] array4 = new int[(int)(this.Emission * (float)6)];
									if (127939 - 66197 == 61742)
									{
										Mesh mesh = this.m0BnT9jnZy2.mesh;
										if (40131 - 94558 != -54426)
										{
											mesh.Clear();
											if (35776 - 473925 == -438149)
											{
												float num = (float)0;
												if (256512 - 595585 != -339072)
												{
													Vector3 vector = default(Vector3);
													if (47876 - 553683 == -505807)
													{
														Vector3 vector2 = default(Vector3);
														if (123590 - 354754 == -231164)
														{
															float num2 = 0f;
															if (40620 - 591027 == -550407)
															{
																float num3 = 0f;
																if (218988 - 499565 == -280577)
																{
																	Color color = default(Color);
																	if (178218 - 498773 != -320554)
																	{
																		Vector3 a = default(Vector3);
																		if (258029 - 541597 != -283567)
																		{
																			Vector3 vector3 = default(Vector3);
																			if (222320 - 61660 != 160661)
																			{
																				if (this.EmissionTime == (float)0)
																				{
																					if (147172 - 273506 == -126333)
																					{
																						continue;
																					}
																					if (this.A0KnTo3CyuN != (float)0)
																					{
																						if (143836 - 422647 == -278810)
																						{
																							continue;
																						}
																						num = Mathf.Clamp01((this.A0KnTo3CyuN - this.Delay) / this.Life);
																						if (208599 - 85839 == 122761)
																						{
																							continue;
																						}
																					}
																					float num4 = Mathf.Lerp(this.startRadius, this.endRadius, num);
																					if (176027 - 104126 == 71902)
																					{
																						continue;
																					}
																					float num5 = 0.5f * Mathf.Lerp(this.startWidth, this.endWidth, num);
																					if (119716 - 217194 != -97478)
																					{
																						continue;
																					}
																					float num6 = Mathf.Lerp(this.startHeight, this.endHeight, num);
																					if (215340 - 343464 == -128123)
																					{
																						continue;
																					}
																					if (num < 0.25f)
																					{
																						if (156458 - 142343 != 14115)
																						{
																							continue;
																						}
																						color = Color.Lerp(this.Color1, this.Color2, 2.5f * num);
																						if (37197 - 332280 != -295083)
																						{
																							continue;
																						}
																					}
																					else if (num < 0.5f)
																					{
																						if (51822 - 519921 == -468098)
																						{
																							continue;
																						}
																						color = Color.Lerp(this.Color2, this.Color3, 2.5f * (num - 0.25f));
																						if (224321 - 201375 == 22947)
																						{
																							continue;
																						}
																					}
																					else if (num < 0.75f)
																					{
																						if (233669 - 90760 == 142910)
																						{
																							continue;
																						}
																						color = Color.Lerp(this.Color3, this.Color4, 2.5f * (num - 0.5f));
																						if (174035 - 290721 == -116685)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						color = Color.Lerp(this.Color4, this.Color5, 2.5f * (num - 0.75f));
																						if (72137 - 441050 != -368913)
																						{
																							continue;
																						}
																					}
																					int num7 = 0;
																					if (60357 - 290563 != -230206)
																					{
																						continue;
																					}
																					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.zyfnTkqTbA5);
																					if (227410 - 589938 != -362528)
																					{
																						continue;
																					}
																					while (enumerator.MoveNext())
																					{
																						object obj = enumerator.Current;
																						object obj3;
																						object obj2 = obj3 = obj;
																						if (!(obj2 is LineParticle))
																						{
																							obj3 = RuntimeServices.Coerce(obj2, typeof(LineParticle));
																						}
																						LineParticle lineParticle2 = (LineParticle)obj3;
																						if (82183 - 565928 == -483744)
																						{
																							goto IL_1049;
																						}
																						a = lineParticle2.velocity.normalized;
																						if (147067 - 118805 != 28262)
																						{
																							goto IL_1049;
																						}
																						UnityRuntimeServices.Update(enumerator, lineParticle2);
																						if (271970 - 258648 == 13323)
																						{
																							goto IL_1049;
																						}
																						eLineEmitterMode eLineEmitterMode = this.lineEmitterMode;
																						if (198675 - 539489 != -340814)
																						{
																							goto IL_1049;
																						}
																						if (eLineEmitterMode == eLineEmitterMode.directional)
																						{
																							if (54855 - 482801 == -427945)
																							{
																								goto IL_1049;
																							}
																							Vector3 vector4 = Vector3.Cross(this.a9enTFHpaeS.InverseTransformDirection(this.a9enTFHpaeS.up), lineParticle2.velocity);
																							if (16292 - 207490 == -191197)
																							{
																								goto IL_1049;
																							}
																							vector3 = vector4.normalized;
																							if (29878 - 103687 == -73808)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (249922 - 138589 == 111334)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 0] = (num4 + lineParticle2.rndRadius) * a - vector3 * (num5 + lineParticle2.rndWidth);
																							if (105090 - 411147 != -306057)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (263470 - 493821 != -230351)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 1] = (num4 + lineParticle2.rndRadius) * a + vector3 * (num5 + lineParticle2.rndWidth);
																							if (29336 - 210301 == -180964)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (166338 - 488964 == -322625)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 2] = (num4 + lineParticle2.rndRadius + num6 + lineParticle2.rndHeight) * a - vector3 * (num5 + lineParticle2.rndWidth);
																							if (207719 - 428361 == -220641)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (20816 - 390949 != -370133)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 3] = (num4 + lineParticle2.rndRadius + num6 + lineParticle2.rndHeight) * a + vector3 * (num5 + lineParticle2.rndWidth);
																							if (165952 - 317163 == -151210)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (174733 - 596696 == -421962)
																							{
																								goto IL_1049;
																							}
																						}
																						else if (eLineEmitterMode == eLineEmitterMode.alwaysUp)
																						{
																							if (132334 - 144844 != -12510)
																							{
																								goto IL_1049;
																							}
																							vector3 = this.a9enTFHpaeS.up;
																							if (165161 - 365114 == -199952)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 0] = (num4 + lineParticle2.rndRadius) * a - vector3 * (num5 + lineParticle2.rndWidth);
																							if (127566 - 229066 != -101500)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (299111 - 174755 != 124356)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 1] = (num4 + lineParticle2.rndRadius) * a + vector3 * (num5 + lineParticle2.rndWidth);
																							if (54393 - 146803 != -92410)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (46079 - 213332 != -167253)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 2] = (num4 + lineParticle2.rndRadius + num6 + lineParticle2.rndHeight) * a - vector3 * (num5 + lineParticle2.rndWidth);
																							if (208587 - 14974 == 193614)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (132243 - 123889 == 8355)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 3] = (num4 + lineParticle2.rndRadius + num6 + lineParticle2.rndHeight) * a + vector3 * (num5 + lineParticle2.rndWidth);
																							if (162162 - 121255 == 40908)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (184210 - 40012 != 144198)
																							{
																								goto IL_1049;
																							}
																						}
																						else if (eLineEmitterMode == eLineEmitterMode.alwaysHorizontal)
																						{
																							if (4506 - 48272 != -43766)
																							{
																								goto IL_1049;
																							}
																							Vector3 vector5 = Vector3.Cross(this.a9enTFHpaeS.up, new Vector3(lineParticle2.velocity.x, (float)0, lineParticle2.velocity.z));
																							if (110427 - 374612 != -264185)
																							{
																								goto IL_1049;
																							}
																							vector3 = vector5.normalized;
																							if (261058 - 208127 == 52932)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (296222 - 26471 == 269752)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 0] = (num4 + lineParticle2.rndRadius) * a - vector3 * (num5 + lineParticle2.rndWidth);
																							if (90612 - 315143 == -224530)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (24844 - 481866 != -457022)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 1] = (num4 + lineParticle2.rndRadius) * a + vector3 * (num5 + lineParticle2.rndWidth);
																							if (272857 - 239604 != 33253)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (277378 - 414630 == -137251)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 2] = (num4 + lineParticle2.rndRadius + num6 + lineParticle2.rndHeight) * a - vector3 * (num5 + lineParticle2.rndWidth);
																							if (219566 - 462968 == -243401)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (192172 - 567042 == -374869)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 3] = (num4 + lineParticle2.rndRadius + num6 + lineParticle2.rndHeight) * a + vector3 * (num5 + lineParticle2.rndWidth);
																							if (135900 - 122327 == 13574)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (70290 - 580703 == -510412)
																							{
																								goto IL_1049;
																							}
																						}
																						else if (eLineEmitterMode == eLineEmitterMode.faceCamera)
																						{
																							if (183410 - 296429 == -113018)
																							{
																								goto IL_1049;
																							}
																							Vector3 vector6 = Vector3.Cross(this.sMnnTAjdOPh.forward, lineParticle2.velocity);
																							if (264586 - 246933 != 17653)
																							{
																								goto IL_1049;
																							}
																							vector3 = vector6.normalized;
																							if (71233 - 530968 != -459735)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (85052 - 143435 == -58382)
																							{
																								goto IL_1049;
																							}
																							vector3 = this.a9enTFHpaeS.InverseTransformDirection(vector3);
																							if (228719 - 99739 != 128980)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 0] = (num4 + lineParticle2.rndRadius) * a - vector3 * (num5 + lineParticle2.rndWidth);
																							if (170309 - 113550 != 56759)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (291495 - 481328 == -189832)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 1] = (num4 + lineParticle2.rndRadius) * a + vector3 * (num5 + lineParticle2.rndWidth);
																							if (8467 - 35051 == -26583)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (148794 - 424211 == -275416)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 2] = (num4 + lineParticle2.rndRadius + num6 + lineParticle2.rndHeight) * a - vector3 * (num5 + lineParticle2.rndWidth);
																							if (194229 - 73139 == 121091)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (132011 - 86315 == 45697)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 3] = (num4 + lineParticle2.rndRadius + num6 + lineParticle2.rndHeight) * a + vector3 * (num5 + lineParticle2.rndWidth);
																							if (217204 - 590428 != -373224)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (159578 - 584049 == -424470)
																							{
																								goto IL_1049;
																							}
																						}
																						else if (eLineEmitterMode == eLineEmitterMode.localUp)
																						{
																							if (278630 - 13 == 278618)
																							{
																								goto IL_1049;
																							}
																							vector3 = this.a9enTFHpaeS.InverseTransformDirection(this.a9enTFHpaeS.up);
																							if (79485 - 419690 == -340204)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 0] = (num4 + lineParticle2.rndRadius) * a;
																							if (89092 - 337732 != -248640)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (159310 - 598927 != -439617)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 1] = (num4 + lineParticle2.rndRadius) * a + vector3 * (num5 + lineParticle2.rndWidth);
																							if (59519 - 139856 != -80337)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (134255 - 40120 != 94135)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 2] = (num4 + lineParticle2.rndRadius + num6 + lineParticle2.rndHeight) * a;
																							if (156330 - 267276 == -110945)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (98927 - 542435 != -443508)
																							{
																								goto IL_1049;
																							}
																							array[num7 * 4 + 3] = (num4 + lineParticle2.rndRadius + num6 + lineParticle2.rndHeight) * a + vector3 * (num5 + lineParticle2.rndWidth);
																							if (87917 - 164943 != -77026)
																							{
																								goto IL_1049;
																							}
																							UnityRuntimeServices.Update(enumerator, lineParticle2);
																							if (190352 - 466911 == -276558)
																							{
																								goto IL_1049;
																							}
																						}
																						array3[num7 * 4 + 0] = new Vector2((float)0, (float)0);
																						if (214014 - 256151 != -42137)
																						{
																							goto IL_1049;
																						}
																						array3[num7 * 4 + 1] = new Vector2((float)0, (float)1);
																						if (216576 - 33136 == 183441)
																						{
																							goto IL_1049;
																						}
																						array3[num7 * 4 + 2] = new Vector2((float)1, (float)0);
																						if (19966 - 504217 == -484250)
																						{
																							goto IL_1049;
																						}
																						array3[num7 * 4 + 3] = new Vector2((float)1, (float)1);
																						if (150183 - 519185 != -369002)
																						{
																							goto IL_1049;
																						}
																						array2[num7 * 4 + 0] = color;
																						if (240036 - 31299 == 208738)
																						{
																							goto IL_1049;
																						}
																						array2[num7 * 4 + 1] = color;
																						if (195838 - 479748 != -283910)
																						{
																							goto IL_1049;
																						}
																						array2[num7 * 4 + 2] = color;
																						if (69625 - 278412 == -208786)
																						{
																							goto IL_1049;
																						}
																						array2[num7 * 4 + 3] = color;
																						if (293081 - 334266 == -41184)
																						{
																							goto IL_1049;
																						}
																						num7++;
																						if (299338 - 454165 != -154827)
																						{
																							goto IL_1049;
																						}
																					}
																					if (250438 - 189889 != 60549)
																					{
																						continue;
																					}
																					int i = 0;
																					if (164759 - 562851 != -398092)
																					{
																						continue;
																					}
																					while (i < Extensions.get_length(array4) / 6)
																					{
																						array4[i * 6 + 0] = i * 4 + 0;
																						if (106051 - 52410 != 53641)
																						{
																							goto IL_1049;
																						}
																						array4[i * 6 + 1] = i * 4 + 1;
																						if (79241 - 531751 != -452510)
																						{
																							goto IL_1049;
																						}
																						array4[i * 6 + 2] = i * 4 + 2;
																						if (239398 - 294925 == -55526)
																						{
																							goto IL_1049;
																						}
																						array4[i * 6 + 3] = i * 4 + 2;
																						if (65623 - 415245 != -349622)
																						{
																							goto IL_1049;
																						}
																						array4[i * 6 + 4] = i * 4 + 1;
																						if (125357 - 376422 == -251064)
																						{
																							goto IL_1049;
																						}
																						array4[i * 6 + 5] = i * 4 + 3;
																						if (84820 - 540042 == -455221)
																						{
																							goto IL_1049;
																						}
																						i++;
																						if (59854 - 265877 != -206023)
																						{
																							goto IL_1049;
																						}
																					}
																					if (109944 - 572014 != -462070)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					int num8 = 0;
																					if (64330 - 538772 == -474441)
																					{
																						continue;
																					}
																					IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(this.zyfnTkqTbA5);
																					if (221281 - 381115 == -159833)
																					{
																						continue;
																					}
																					while (enumerator2.MoveNext())
																					{
																						object obj4 = enumerator2.Current;
																						object obj6;
																						object obj5 = obj6 = obj4;
																						if (!(obj5 is LineParticle))
																						{
																							obj6 = RuntimeServices.Coerce(obj5, typeof(LineParticle));
																						}
																						LineParticle lineParticle3 = (LineParticle)obj6;
																						if (116731 - 158121 == -41389)
																						{
																							goto IL_1049;
																						}
																						if (this.A0KnTo3CyuN - this.Delay > lineParticle3.life)
																						{
																							if (52780 - 405863 == -353082)
																							{
																								goto IL_1049;
																							}
																							if (this.A0KnTo3CyuN - this.Delay - lineParticle3.life < this.Life)
																							{
																								if (173557 - 547794 == -374236)
																								{
																									goto IL_1049;
																								}
																								if (this.Life != (float)0)
																								{
																									if (275027 - 408582 == -133554)
																									{
																										goto IL_1049;
																									}
																									num = Mathf.Clamp01((this.A0KnTo3CyuN - this.Delay - lineParticle3.life) / this.Life);
																									if (201236 - 461342 != -260106)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (93151 - 80508 != 12643)
																									{
																										goto IL_1049;
																									}
																								}
																								a = lineParticle3.velocity.normalized;
																								if (221746 - 60245 == 161502)
																								{
																									goto IL_1049;
																								}
																								UnityRuntimeServices.Update(enumerator2, lineParticle3);
																								if (21465 - 235536 != -214071)
																								{
																									goto IL_1049;
																								}
																								float num9 = Mathf.Lerp(this.startRadius, this.endRadius, num);
																								if (15550 - 349185 != -333635)
																								{
																									goto IL_1049;
																								}
																								float num10 = 0.5f * Mathf.Lerp(this.startWidth, this.endWidth, num);
																								if (21657 - 132884 == -111226)
																								{
																									goto IL_1049;
																								}
																								float num11 = Mathf.Lerp(this.startHeight, this.endHeight, num);
																								if (266369 - 103102 == 163268)
																								{
																									goto IL_1049;
																								}
																								if (num < 0.25f)
																								{
																									if (289494 - 298237 != -8743)
																									{
																										goto IL_1049;
																									}
																									color = Color.Lerp(this.Color1, this.Color2, (float)4 * num);
																									if (94664 - 558281 != -463617)
																									{
																										goto IL_1049;
																									}
																								}
																								else if (num < 0.5f)
																								{
																									if (88532 - 92718 == -4185)
																									{
																										goto IL_1049;
																									}
																									color = Color.Lerp(this.Color2, this.Color3, (float)4 * (num - 0.25f));
																									if (223570 - 351944 == -128373)
																									{
																										goto IL_1049;
																									}
																								}
																								else if (num < 0.75f)
																								{
																									if (266045 - 229071 != 36974)
																									{
																										goto IL_1049;
																									}
																									color = Color.Lerp(this.Color3, this.Color4, (float)4 * (num - 0.5f));
																									if (136301 - 384063 != -247762)
																									{
																										goto IL_1049;
																									}
																								}
																								else
																								{
																									color = Color.Lerp(this.Color4, this.Color5, (float)4 * (num - 0.75f));
																									if (88284 - 154739 == -66454)
																									{
																										goto IL_1049;
																									}
																								}
																								eLineEmitterMode eLineEmitterMode2 = this.lineEmitterMode;
																								if (201245 - 187873 == 13373)
																								{
																									goto IL_1049;
																								}
																								if (eLineEmitterMode2 == eLineEmitterMode.directional)
																								{
																									if (248633 - 402564 == -153930)
																									{
																										goto IL_1049;
																									}
																									Vector3 vector7 = Vector3.Cross(this.a9enTFHpaeS.up, lineParticle3.velocity);
																									if (129986 - 556620 != -426634)
																									{
																										goto IL_1049;
																									}
																									vector3 = vector7.normalized;
																									if (167366 - 448200 == -280833)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (118818 - 238370 != -119552)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 0] = (num9 + lineParticle3.rndRadius) * a - vector3 * (num10 + lineParticle3.rndWidth);
																									if (254789 - 372758 == -117968)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (39780 - 388122 == -348341)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 1] = (num9 + lineParticle3.rndRadius) * a + vector3 * (num10 + lineParticle3.rndWidth);
																									if (285954 - 163805 == 122150)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (296449 - 54845 == 241605)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 2] = (num9 + lineParticle3.rndRadius + num11 + lineParticle3.rndHeight) * a - vector3 * (num10 + lineParticle3.rndWidth);
																									if (24340 - 102206 == -77865)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (188929 - 366798 == -177868)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 3] = (num9 + lineParticle3.rndRadius + num11 + lineParticle3.rndHeight) * a + vector3 * (num10 + lineParticle3.rndWidth);
																									if (55456 - 178385 == -122928)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (229893 - 298726 != -68833)
																									{
																										goto IL_1049;
																									}
																								}
																								else if (eLineEmitterMode2 == eLineEmitterMode.alwaysUp)
																								{
																									if (253522 - 287105 != -33583)
																									{
																										goto IL_1049;
																									}
																									vector3 = this.a9enTFHpaeS.up;
																									if (128190 - 6657 != 121533)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 0] = (num9 + lineParticle3.rndRadius) * a - vector3 * (num10 + lineParticle3.rndWidth);
																									if (177637 - 540154 != -362517)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (160236 - 417953 == -257716)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 1] = (num9 + lineParticle3.rndRadius) * a + vector3 * (num10 + lineParticle3.rndWidth);
																									if (62377 - 221984 != -159607)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (299493 - 57591 == 241903)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 2] = (num9 + lineParticle3.rndRadius + num11 + lineParticle3.rndHeight) * a - vector3 * (num10 + lineParticle3.rndWidth);
																									if (76615 - 121966 != -45351)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (66190 - 296485 != -230295)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 3] = (num9 + lineParticle3.rndRadius + num11 + lineParticle3.rndHeight) * a + vector3 * (num10 + lineParticle3.rndWidth);
																									if (43686 - 451096 == -407409)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (189690 - 432994 != -243304)
																									{
																										goto IL_1049;
																									}
																								}
																								else if (eLineEmitterMode2 == eLineEmitterMode.alwaysHorizontal)
																								{
																									if (117842 - 129833 != -11991)
																									{
																										goto IL_1049;
																									}
																									Vector3 vector8 = Vector3.Cross(this.a9enTFHpaeS.up, new Vector3(lineParticle3.velocity.x, (float)0, lineParticle3.velocity.z));
																									if (153939 - 372350 == -218410)
																									{
																										goto IL_1049;
																									}
																									vector3 = vector8.normalized;
																									if (266850 - 312706 != -45856)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (295184 - 400569 != -105385)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 0] = (num9 + lineParticle3.rndRadius) * a - vector3 * (num10 + lineParticle3.rndWidth);
																									if (43855 - 596152 == -552296)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (94666 - 53095 == 41572)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 1] = (num9 + lineParticle3.rndRadius) * a + vector3 * (num10 + lineParticle3.rndWidth);
																									if (132202 - 229050 == -96847)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (230806 - 125353 == 105454)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 2] = (num9 + lineParticle3.rndRadius + num11 + lineParticle3.rndHeight) * a - vector3 * (num10 + lineParticle3.rndWidth);
																									if (44343 - 161939 != -117596)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (36950 - 306001 != -269051)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 3] = (num9 + lineParticle3.rndRadius + num11 + lineParticle3.rndHeight) * a + vector3 * (num10 + lineParticle3.rndWidth);
																									if (199078 - 319237 == -120158)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (276619 - 185036 == 91584)
																									{
																										goto IL_1049;
																									}
																								}
																								else if (eLineEmitterMode2 == eLineEmitterMode.faceCamera)
																								{
																									if (74420 - 414476 == -340055)
																									{
																										goto IL_1049;
																									}
																									Vector3 vector9 = Vector3.Cross(this.sMnnTAjdOPh.forward, lineParticle3.velocity);
																									if (42351 - 39211 == 3141)
																									{
																										goto IL_1049;
																									}
																									vector3 = vector9.normalized;
																									if (227584 - 583055 == -355470)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (32193 - 290309 == -258115)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 0] = (num9 + lineParticle3.rndRadius) * a - vector3 * (num10 + lineParticle3.rndWidth);
																									if (70487 - 530254 != -459767)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (189943 - 411851 == -221907)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 1] = (num9 + lineParticle3.rndRadius) * a + vector3 * (num10 + lineParticle3.rndWidth);
																									if (276831 - 527672 != -250841)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (19155 - 95009 != -75854)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 2] = (num9 + lineParticle3.rndRadius + num11 + lineParticle3.rndHeight) * a - vector3 * (num10 + lineParticle3.rndWidth);
																									if (226632 - 51202 != 175430)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (194708 - 157486 == 37223)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 3] = (num9 + lineParticle3.rndRadius + num11 + lineParticle3.rndHeight) * a + vector3 * (num10 + lineParticle3.rndWidth);
																									if (274257 - 281488 != -7231)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (154717 - 107198 != 47519)
																									{
																										goto IL_1049;
																									}
																								}
																								else if (eLineEmitterMode2 == eLineEmitterMode.localUp)
																								{
																									if (32228 - 402961 != -370733)
																									{
																										goto IL_1049;
																									}
																									vector3 = this.a9enTFHpaeS.InverseTransformDirection(this.a9enTFHpaeS.up);
																									if (111447 - 168379 == -56931)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 0] = (num9 + lineParticle3.rndRadius) * a;
																									if (254401 - 203334 != 51067)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (69367 - 198016 != -128649)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 1] = (num9 + lineParticle3.rndRadius) * a + vector3 * (num10 + lineParticle3.rndWidth);
																									if (255033 - 260417 == -5383)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (169176 - 184667 != -15491)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 2] = (num9 + lineParticle3.rndRadius + num11 + lineParticle3.rndHeight) * a;
																									if (208402 - 469134 != -260732)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (64015 - 130164 != -66149)
																									{
																										goto IL_1049;
																									}
																									array[num8 * 4 + 3] = (num9 + lineParticle3.rndRadius + num11 + lineParticle3.rndHeight) * a + vector3 * (num10 + lineParticle3.rndWidth);
																									if (234205 - 569511 != -335306)
																									{
																										goto IL_1049;
																									}
																									UnityRuntimeServices.Update(enumerator2, lineParticle3);
																									if (61370 - 102377 != -41007)
																									{
																										goto IL_1049;
																									}
																								}
																								array3[num8 * 4 + 0] = new Vector2((float)0, (float)0);
																								if (121529 - 379152 == -257622)
																								{
																									goto IL_1049;
																								}
																								array3[num8 * 4 + 1] = new Vector2((float)0, (float)1);
																								if (14024 - 472621 != -458597)
																								{
																									goto IL_1049;
																								}
																								array3[num8 * 4 + 2] = new Vector2((float)1, (float)0);
																								if (169250 - 92677 == 76574)
																								{
																									goto IL_1049;
																								}
																								array3[num8 * 4 + 3] = new Vector2((float)1, (float)1);
																								if (16901 - 575402 != -558501)
																								{
																									goto IL_1049;
																								}
																								array2[num8 * 4 + 0] = color;
																								if (45666 - 177371 != -131705)
																								{
																									goto IL_1049;
																								}
																								array2[num8 * 4 + 1] = color;
																								if (283411 - 54114 != 229297)
																								{
																									goto IL_1049;
																								}
																								array2[num8 * 4 + 2] = color;
																								if (250932 - 539837 == -288904)
																								{
																									goto IL_1049;
																								}
																								array2[num8 * 4 + 3] = color;
																								if (278728 - 118014 == 160715)
																								{
																									goto IL_1049;
																								}
																								num8++;
																								if (292665 - 518346 == -225680)
																								{
																									goto IL_1049;
																								}
																							}
																						}
																						if (num8 > 0)
																						{
																							if (266989 - 579277 == -312287)
																							{
																								goto IL_1049;
																							}
																							array4 = new int[(num8 - 1) * 6];
																							if (85132 - 36966 == 48167)
																							{
																								goto IL_1049;
																							}
																						}
																					}
																					if (111483 - 140593 != -29110)
																					{
																						continue;
																					}
																					int j = 0;
																					if (92881 - 73730 == 19152)
																					{
																						continue;
																					}
																					while (j < Extensions.get_length(array4) / 6)
																					{
																						array4[j * 6 + 0] = j * 4 + 0;
																						if (224527 - 527170 != -302643)
																						{
																							goto IL_1049;
																						}
																						array4[j * 6 + 1] = j * 4 + 1;
																						if (139392 - 30026 == 109367)
																						{
																							goto IL_1049;
																						}
																						array4[j * 6 + 2] = j * 4 + 2;
																						if (132357 - 342516 != -210159)
																						{
																							goto IL_1049;
																						}
																						array4[j * 6 + 3] = j * 4 + 2;
																						if (182260 - 287338 != -105078)
																						{
																							goto IL_1049;
																						}
																						array4[j * 6 + 4] = j * 4 + 1;
																						if (121644 - 468282 != -346638)
																						{
																							goto IL_1049;
																						}
																						array4[j * 6 + 5] = j * 4 + 3;
																						if (124787 - 225161 == -100373)
																						{
																							goto IL_1049;
																						}
																						j++;
																						if (189078 - 100915 != 88163)
																						{
																							goto IL_1049;
																						}
																					}
																					if (241002 - 400263 != -159261)
																					{
																						continue;
																					}
																				}
																				mesh.vertices = array;
																				if (95042 - 380116 == -285074)
																				{
																					mesh.colors = array2;
																					if (278300 - 258544 != 19757)
																					{
																						mesh.uv = array3;
																						if (71062 - 29189 == 41873)
																						{
																							mesh.triangles = array4;
																							if (66344 - 64321 != 2024)
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

	// Token: 0x0600C370 RID: 50032 RVA: 0x0147D2A8 File Offset: 0x0147B4A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C371 RID: 50033 RVA: 0x0147D2AC File Offset: 0x0147B4AC
	internal static bool PfpP1etomjRTCZ5FSxVR()
	{
		return true;
	}

	// Token: 0x0600C372 RID: 50034 RVA: 0x0147D2B0 File Offset: 0x0147B4B0
	internal static bool ahlVfEtoFIuigCZLPGjK()
	{
		return false;
	}

	// Token: 0x0400A5F6 RID: 42486
	public float Life;

	// Token: 0x0400A5F7 RID: 42487
	public float Delay;

	// Token: 0x0400A5F8 RID: 42488
	public float Emission;

	// Token: 0x0400A5F9 RID: 42489
	public float EmissionTime;

	// Token: 0x0400A5FA RID: 42490
	public float startRadius;

	// Token: 0x0400A5FB RID: 42491
	public float endRadius;

	// Token: 0x0400A5FC RID: 42492
	public float rndRadius;

	// Token: 0x0400A5FD RID: 42493
	public float startHeight;

	// Token: 0x0400A5FE RID: 42494
	public float endHeight;

	// Token: 0x0400A5FF RID: 42495
	public float rndHeight;

	// Token: 0x0400A600 RID: 42496
	public float startWidth;

	// Token: 0x0400A601 RID: 42497
	public float endWidth;

	// Token: 0x0400A602 RID: 42498
	public float rndWidth;

	// Token: 0x0400A603 RID: 42499
	public Vector3 localVelocity;

	// Token: 0x0400A604 RID: 42500
	public Vector3 rndVelocity;

	// Token: 0x0400A605 RID: 42501
	public Color Color1;

	// Token: 0x0400A606 RID: 42502
	public Color Color2;

	// Token: 0x0400A607 RID: 42503
	public Color Color3;

	// Token: 0x0400A608 RID: 42504
	public Color Color4;

	// Token: 0x0400A609 RID: 42505
	public Color Color5;

	// Token: 0x0400A60A RID: 42506
	public eLineEmitterMode lineEmitterMode;

	// Token: 0x0400A60B RID: 42507
	public bool symetry;

	// Token: 0x0400A60C RID: 42508
	public Vector3 localRotation;

	// Token: 0x0400A60D RID: 42509
	public bool repeatForever;

	// Token: 0x0400A60E RID: 42510
	private float A0KnTo3CyuN;

	// Token: 0x0400A60F RID: 42511
	private UnityScript.Lang.Array zyfnTkqTbA5;

	// Token: 0x0400A610 RID: 42512
	private Transform a9enTFHpaeS;

	// Token: 0x0400A611 RID: 42513
	private Transform sMnnTAjdOPh;

	// Token: 0x0400A612 RID: 42514
	private MeshFilter m0BnT9jnZy2;
}
