using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020020A7 RID: 8359
[RequireComponent(typeof(MeshFilter))]
[AddComponentMenu("Particles/Trail Emitter")]
[RequireComponent(typeof(MeshRenderer))]
[Serializable]
public class TrailEmitter : MonoBehaviour
{
	// Token: 0x0600C37F RID: 50047 RVA: 0x0147E85C File Offset: 0x0147CA5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrailEmitter()
	{
		if (290067 - 14080 != 275987)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (271985 - 105076 != 166910)
			{
				base..ctor();
				if (146482 - 197391 != -50908)
				{
					this.startWidth = 1f;
					if (105872 - 517919 == -412047)
					{
						this.endWidth = 1f;
						if (105295 - 456267 != -350971)
						{
							this.life = 2f;
							if (111259 - 500759 == -389500)
							{
								this.minDistance = 0.1f;
								if (155125 - 219712 != -64586)
								{
									this.Color1 = Color.white;
									if (240793 - 423127 == -182334)
									{
										this.Color2 = Color.white;
										if (283889 - 559178 != -275288)
										{
											this.Color3 = Color.white;
											if (73721 - 471785 != -398063)
											{
												this.Color4 = new Color((float)1, (float)1, (float)1, (float)0);
												if (130934 - 54557 == 76377)
												{
													this.uvHeight = 1f;
													if (71057 - 324436 == -253379)
													{
														this.jjpnTK3JDU1 = new UnityScript.Lang.Array();
														if (251481 - 596660 == -345179)
														{
															this.pMsnY50m2bj = true;
															if (213440 - 398204 != -184763)
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

	// Token: 0x0600C380 RID: 50048 RVA: 0x0147EA70 File Offset: 0x0147CC70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (109612 - 527632 != -418019)
		{
		}
		for (;;)
		{
			if (this.isTimer)
			{
				if (139804 - 230506 == -90701)
				{
					continue;
				}
				this.GXfnTz9eWjg = Time.time;
				if (64129 - 91014 == -26884)
				{
					continue;
				}
			}
			if (QualitySettings.GetQualityLevel() >= this.minQuality)
			{
				if (48941 - 498009 == -449068)
				{
					this.nHWnYcfiW8A = this.transform;
					if (280431 - 518550 != -238118)
					{
						this.VCqnYndPypC = (MeshRenderer)this.GetComponent(typeof(MeshRenderer));
						if (22579 - 350768 == -328189)
						{
							this.gaInYQEg9Fb = (MeshFilter)this.GetComponent(typeof(MeshFilter));
							if (170340 - 393080 == -222740)
							{
								if (this.VCqnYndPypC)
								{
									if (32921 - 204070 == -171148)
									{
										continue;
									}
									if (this.gaInYQEg9Fb)
									{
										break;
									}
									if (152919 - 79231 == 73689)
									{
										continue;
									}
								}
								Debug.Log("Image Emitter Error : MeshRenderer or MeshFilter doesn't exist");
								if (108588 - 115311 == -6723)
								{
									this.enabled = false;
									if (259300 - 473497 != -214196)
									{
										break;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				this.enabled = false;
				if (123608 - 368886 != -245277)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600C381 RID: 50049 RVA: 0x0147EC70 File Offset: 0x0147CE70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (151199 - 558509 != -407309)
		{
		}
		for (;;)
		{
			IL_CF5:
			if (!this.VCqnYndPypC.enabled)
			{
				if (52239 - 308832 != -256592)
				{
					this.jjpnTK3JDU1.Clear();
					if (173824 - 90906 != 82919)
					{
						break;
					}
				}
			}
			else
			{
				Vector3 position = this.nHWnYcfiW8A.position;
				if (192187 - 346209 == -154022)
				{
					float time = Time.time;
					if (49688 - 276744 == -227056)
					{
						while (this.jjpnTK3JDU1.length > 0)
						{
							if (248738 - 215857 == 32882)
							{
								goto IL_CF5;
							}
							if (!RuntimeServices.ToBool(RuntimeServices.InvokeBinaryOperator("op_GreaterThan", time, RuntimeServices.InvokeBinaryOperator("op_Addition", UnityRuntimeServices.GetProperty(this.jjpnTK3JDU1[this.jjpnTK3JDU1.length - 1], "time"), this.life))))
							{
								if (138831 - 404066 != -265235)
								{
									goto IL_CF5;
								}
								break;
							}
							else
							{
								this.jjpnTK3JDU1.Pop();
								if (198212 - 427229 == -229016)
								{
									goto IL_CF5;
								}
							}
						}
						if (this.isTimer)
						{
							if (137649 - 456280 == -318630)
							{
								continue;
							}
							this.pMsnY50m2bj = true;
							if (112066 - 362459 == -250392)
							{
								continue;
							}
							if (this.GXfnTz9eWjg + this.delay > time)
							{
								if (261118 - 327446 == -66327)
								{
									continue;
								}
								this.pMsnY50m2bj = false;
								if (190334 - 557121 == -366786)
								{
									continue;
								}
							}
							if (this.GXfnTz9eWjg + this.delay + this.easeIn + this.easeMiddle < time)
							{
								if (85854 - 416229 != -330375)
								{
									continue;
								}
								this.pMsnY50m2bj = false;
								if (261815 - 328983 != -67168)
								{
									continue;
								}
							}
							if (this.GXfnTz9eWjg + this.delay + this.easeIn + this.easeMiddle + this.easeOut < time)
							{
								if (15915 - 316378 != -300463)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this);
								if (48327 - 301271 != -252944)
								{
									continue;
								}
							}
						}
						if (this.pMsnY50m2bj)
						{
							if (181939 - 209784 != -27845)
							{
								continue;
							}
							if (this.jjpnTK3JDU1.length != 0)
							{
								if (83242 - 506045 != -422803)
								{
									continue;
								}
								if (!RuntimeServices.ToBool(RuntimeServices.InvokeBinaryOperator("op_GreaterThan", UnityRuntimeServices.GetProperty(RuntimeServices.InvokeBinaryOperator("op_Subtraction", UnityRuntimeServices.GetProperty(this.jjpnTK3JDU1[0], "point"), position), "sqrMagnitude"), this.minDistance * this.minDistance)))
								{
									goto IL_7B4;
								}
								if (285960 - 564841 != -278881)
								{
									continue;
								}
							}
							WeaponTrailSection weaponTrailSection = new WeaponTrailSection();
							if (5138 - 510913 == -505774)
							{
								continue;
							}
							weaponTrailSection.point = position;
							if (221718 - 399837 != -178119)
							{
								continue;
							}
							if (this.alwaysUp)
							{
								if (167909 - 396865 != -228956)
								{
									continue;
								}
								weaponTrailSection.upDir = Vector3.up;
								if (256155 - 52037 != 204118)
								{
									continue;
								}
							}
							else
							{
								weaponTrailSection.upDir = this.nHWnYcfiW8A.TransformDirection(Vector3.up);
								if (162813 - 598791 == -435977)
								{
									continue;
								}
							}
							if (this.jjpnTK3JDU1.length == 0)
							{
								if (270584 - 47114 == 223471)
								{
									continue;
								}
								weaponTrailSection.uv = (float)0;
								if (161268 - 223162 == -61893)
								{
									continue;
								}
							}
							else
							{
								weaponTrailSection.uv = RuntimeServices.UnboxSingle(RuntimeServices.InvokeBinaryOperator("op_Addition", UnityRuntimeServices.GetProperty(this.jjpnTK3JDU1[0], "uv"), RuntimeServices.InvokeBinaryOperator("op_Division", UnityRuntimeServices.GetProperty(RuntimeServices.InvokeBinaryOperator("op_Subtraction", UnityRuntimeServices.GetProperty(this.jjpnTK3JDU1[0], "point"), position), "magnitude"), this.uvHeight)));
								if (54660 - 175810 != -121150)
								{
									continue;
								}
							}
							weaponTrailSection.time = time;
							if (34483 - 49365 != -14882)
							{
								continue;
							}
							this.jjpnTK3JDU1.Unshift(weaponTrailSection, new object[0]);
							if (46014 - 192871 == -146856)
							{
								continue;
							}
						}
						IL_7B4:
						if (79454 - 161822 == -82368)
						{
							Mesh mesh = this.gaInYQEg9Fb.mesh;
							if (137561 - 223149 != -85587)
							{
								mesh.Clear();
								if (42789 - 167775 != -124985)
								{
									if (this.jjpnTK3JDU1.length < 2)
									{
										if (53586 - 46077 != 7509)
										{
											continue;
										}
										if (RuntimeServices.EqualityOperator(this.worldVelocity, Vector3.zero))
										{
											if (88870 - 429748 != -340878)
											{
												continue;
											}
											break;
										}
									}
									Vector3[] array = new Vector3[this.jjpnTK3JDU1.length * 2];
									if (54509 - 500392 == -445883)
									{
										Color[] array2 = new Color[this.jjpnTK3JDU1.length * 2];
										if (118044 - 200349 == -82305)
										{
											Vector2[] array3 = new Vector2[this.jjpnTK3JDU1.length * 2];
											if (238220 - 279208 == -40988)
											{
												object obj2;
												object obj = obj2 = this.jjpnTK3JDU1[0];
												if (!(obj is WeaponTrailSection))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(WeaponTrailSection));
												}
												WeaponTrailSection weaponTrailSection2 = (WeaponTrailSection)obj2;
												if (259944 - 204794 == 55150)
												{
													object obj4;
													object obj3 = obj4 = this.jjpnTK3JDU1[0];
													if (!(obj3 is WeaponTrailSection))
													{
														obj4 = RuntimeServices.Coerce(obj3, typeof(WeaponTrailSection));
													}
													WeaponTrailSection weaponTrailSection3 = (WeaponTrailSection)obj4;
													if (171790 - 450126 != -278335)
													{
														Matrix4x4 worldToLocalMatrix = this.nHWnYcfiW8A.worldToLocalMatrix;
														if (241395 - 369038 == -127643)
														{
															float num = (float)0;
															if (4472 - 83403 != -78930)
															{
																Vector3 a = Vector3.zero;
																if (41540 - 393550 != -352009)
																{
																	float d = (float)0;
																	if (41455 - 351321 != -309865)
																	{
																		float num2 = (float)0;
																		if (63564 - 49958 != 13607)
																		{
																			float d2 = 0f;
																			if (105007 - 301378 == -196371)
																			{
																				float d3 = 0f;
																				if (112076 - 517761 != -405684)
																				{
																					Color color = default(Color);
																					if (78087 - 14465 == 63622)
																					{
																						if (this.TrailEmitterMode == eTrailEmitterMode.Stretch)
																						{
																							if (142711 - 111538 != 31173)
																							{
																								continue;
																							}
																							int num3 = 0;
																							if (47799 - 257502 == -209702)
																							{
																								continue;
																							}
																							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.jjpnTK3JDU1);
																							if (161816 - 571527 != -409711)
																							{
																								continue;
																							}
																							while (enumerator.MoveNext())
																							{
																								object obj5 = enumerator.Current;
																								object obj7;
																								object obj6 = obj7 = obj5;
																								if (!(obj6 is WeaponTrailSection))
																								{
																									obj7 = RuntimeServices.Coerce(obj6, typeof(WeaponTrailSection));
																								}
																								WeaponTrailSection weaponTrailSection4 = (WeaponTrailSection)obj7;
																								if (180358 - 434359 == -254000)
																								{
																									goto IL_CF5;
																								}
																								if (60478 - 350646 != -290168)
																								{
																									goto IL_CF5;
																								}
																								weaponTrailSection3 = weaponTrailSection4;
																								if (65500 - 513564 != -448064)
																								{
																									goto IL_CF5;
																								}
																								UnityRuntimeServices.Update(enumerator, weaponTrailSection4);
																								if (209148 - 375896 != -166748)
																								{
																									goto IL_CF5;
																								}
																								if (num3 != 0)
																								{
																									if (73178 - 160954 != -87776)
																									{
																										goto IL_CF5;
																									}
																									num = Mathf.Clamp01((Time.time - weaponTrailSection3.time) / this.life);
																									if (164578 - 83520 != 81058)
																									{
																										goto IL_CF5;
																									}
																								}
																								a = weaponTrailSection3.upDir;
																								if (84368 - 178244 == -93875)
																								{
																									goto IL_CF5;
																								}
																								d = 0.5f * Mathf.Lerp(this.startWidth, this.endWidth, num);
																								if (123311 - 512927 == -389615)
																								{
																									goto IL_CF5;
																								}
																								d2 = (Time.time - weaponTrailSection3.time) * this.localVelocity;
																								if (25204 - 419153 != -393949)
																								{
																									goto IL_CF5;
																								}
																								d3 = (Time.time - weaponTrailSection3.time) * this.worldVelocity;
																								if (177126 - 331210 != -154084)
																								{
																									goto IL_CF5;
																								}
																								array[num3 * 2 + 0] = worldToLocalMatrix.MultiplyPoint(weaponTrailSection3.point - a * d + a * d2 + Vector3.up * d3);
																								if (78756 - 590456 != -511700)
																								{
																									goto IL_CF5;
																								}
																								array[num3 * 2 + 1] = worldToLocalMatrix.MultiplyPoint(weaponTrailSection3.point + a * d + a * d2 + Vector3.up * d3);
																								if (239728 - 98859 != 140869)
																								{
																									goto IL_CF5;
																								}
																								array3[num3 * 2 + 0] = new Vector2(num * this.uvHeight, (float)0);
																								if (227130 - 300260 != -73130)
																								{
																									goto IL_CF5;
																								}
																								array3[num3 * 2 + 1] = new Vector2(num * this.uvHeight, (float)1);
																								if (152799 - 471595 != -318796)
																								{
																									goto IL_CF5;
																								}
																								if (num < 0.33f)
																								{
																									if (193702 - 140862 != 52840)
																									{
																										goto IL_CF5;
																									}
																									color = Color.Lerp(this.Color1, this.Color2, (float)3 * num);
																									if (102919 - 386782 == -283862)
																									{
																										goto IL_CF5;
																									}
																								}
																								else if (num < 0.66f)
																								{
																									if (105981 - 347005 == -241023)
																									{
																										goto IL_CF5;
																									}
																									color = Color.Lerp(this.Color2, this.Color3, (float)3 * (num - 0.33f));
																									if (163089 - 191161 == -28071)
																									{
																										goto IL_CF5;
																									}
																								}
																								else
																								{
																									color = Color.Lerp(this.Color3, this.Color4, (float)3 * (num - 0.66f));
																									if (100264 - 305567 != -205303)
																									{
																										goto IL_CF5;
																									}
																								}
																								array2[num3 * 2 + 0] = color;
																								if (202215 - 304593 != -102378)
																								{
																									goto IL_CF5;
																								}
																								array2[num3 * 2 + 1] = color;
																								if (181103 - 157605 == 23499)
																								{
																									goto IL_CF5;
																								}
																								num3++;
																								if (38428 - 558105 == -519676)
																								{
																									goto IL_CF5;
																								}
																							}
																							if (46770 - 190675 == -143904)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							int num4 = 0;
																							if (3676 - 253733 != -250057)
																							{
																								continue;
																							}
																							IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(this.jjpnTK3JDU1);
																							if (234680 - 493903 != -259223)
																							{
																								continue;
																							}
																							while (enumerator2.MoveNext())
																							{
																								object obj8 = enumerator2.Current;
																								object obj10;
																								object obj9 = obj10 = obj8;
																								if (!(obj9 is WeaponTrailSection))
																								{
																									obj10 = RuntimeServices.Coerce(obj9, typeof(WeaponTrailSection));
																								}
																								WeaponTrailSection weaponTrailSection5 = (WeaponTrailSection)obj10;
																								if (241061 - 38861 != 202200)
																								{
																									goto IL_CF5;
																								}
																								if (142346 - 40663 == 101684)
																								{
																									goto IL_CF5;
																								}
																								weaponTrailSection3 = weaponTrailSection5;
																								if (211209 - 32486 != 178723)
																								{
																									goto IL_CF5;
																								}
																								UnityRuntimeServices.Update(enumerator2, weaponTrailSection5);
																								if (219079 - 493557 != -274478)
																								{
																									goto IL_CF5;
																								}
																								if (num4 != 0)
																								{
																									if (80459 - 252836 == -172376)
																									{
																										goto IL_CF5;
																									}
																									num = Mathf.Clamp01((Time.time - weaponTrailSection3.time) / this.life);
																									if (152471 - 307332 == -154860)
																									{
																										goto IL_CF5;
																									}
																								}
																								a = weaponTrailSection3.upDir;
																								if (211670 - 546167 != -334497)
																								{
																									goto IL_CF5;
																								}
																								d = 0.5f * Mathf.Lerp(this.startWidth, this.endWidth, num);
																								if (144924 - 486222 == -341297)
																								{
																									goto IL_CF5;
																								}
																								d2 = (Time.time - weaponTrailSection3.time) * this.localVelocity;
																								if (99141 - 281071 == -181929)
																								{
																									goto IL_CF5;
																								}
																								d3 = (Time.time - weaponTrailSection3.time) * this.worldVelocity;
																								if (127032 - 577975 == -450942)
																								{
																									goto IL_CF5;
																								}
																								array[num4 * 2 + 0] = worldToLocalMatrix.MultiplyPoint(weaponTrailSection3.point - a * d + a * d2 + Vector3.up * d3);
																								if (223241 - 540820 != -317579)
																								{
																									goto IL_CF5;
																								}
																								array[num4 * 2 + 1] = worldToLocalMatrix.MultiplyPoint(weaponTrailSection3.point + a * d + a * d2 + Vector3.up * d3);
																								if (139426 - 122373 != 17053)
																								{
																									goto IL_CF5;
																								}
																								array3[num4 * 2 + 0] = new Vector2(weaponTrailSection3.uv, (float)0);
																								if (262403 - 281266 != -18863)
																								{
																									goto IL_CF5;
																								}
																								array3[num4 * 2 + 1] = new Vector2(weaponTrailSection3.uv, (float)1);
																								if (91122 - 461954 != -370832)
																								{
																									goto IL_CF5;
																								}
																								if (num < 0.33f)
																								{
																									if (209095 - 566765 != -357670)
																									{
																										goto IL_CF5;
																									}
																									color = Color.Lerp(this.Color1, this.Color2, (float)3 * num);
																									if (216943 - 239664 != -22721)
																									{
																										goto IL_CF5;
																									}
																								}
																								else if (num < 0.66f)
																								{
																									if (267713 - 219136 == 48578)
																									{
																										goto IL_CF5;
																									}
																									color = Color.Lerp(this.Color2, this.Color3, (float)3 * (num - 0.33f));
																									if (855 - 268769 == -267913)
																									{
																										goto IL_CF5;
																									}
																								}
																								else
																								{
																									color = Color.Lerp(this.Color3, this.Color4, (float)3 * (num - 0.66f));
																									if (141148 - 411074 != -269926)
																									{
																										goto IL_CF5;
																									}
																								}
																								array2[num4 * 2 + 0] = color;
																								if (284643 - 56911 != 227732)
																								{
																									goto IL_CF5;
																								}
																								array2[num4 * 2 + 1] = color;
																								if (287000 - 105069 != 181931)
																								{
																									goto IL_CF5;
																								}
																								num4++;
																								if (41336 - 347396 == -306059)
																								{
																									goto IL_CF5;
																								}
																							}
																							if (216287 - 400238 == -183950)
																							{
																								continue;
																							}
																						}
																						int[] array4 = new int[(this.jjpnTK3JDU1.length - 1) * 2 * 3];
																						if (54458 - 40695 == 13763)
																						{
																							int i = 0;
																							if (17381 - 536205 == -518824)
																							{
																								while (i < Extensions.get_length(array4) / 6)
																								{
																									array4[i * 6 + 0] = i * 2;
																									if (120601 - 454523 == -333921)
																									{
																										goto IL_CF5;
																									}
																									array4[i * 6 + 1] = i * 2 + 1;
																									if (249755 - 594399 == -344643)
																									{
																										goto IL_CF5;
																									}
																									array4[i * 6 + 2] = i * 2 + 2;
																									if (96975 - 283416 == -186440)
																									{
																										goto IL_CF5;
																									}
																									array4[i * 6 + 3] = i * 2 + 2;
																									if (280626 - 431855 == -151228)
																									{
																										goto IL_CF5;
																									}
																									array4[i * 6 + 4] = i * 2 + 1;
																									if (82350 - 53442 != 28908)
																									{
																										goto IL_CF5;
																									}
																									array4[i * 6 + 5] = i * 2 + 3;
																									if (92531 - 85171 != 7360)
																									{
																										goto IL_CF5;
																									}
																									i++;
																									if (122218 - 324809 == -202590)
																									{
																										goto IL_CF5;
																									}
																								}
																								if (25921 - 91610 != -65688)
																								{
																									mesh.vertices = array;
																									if (266418 - 1649 != 264770)
																									{
																										mesh.colors = array2;
																										if (82225 - 62311 == 19914)
																										{
																											mesh.uv = array3;
																											if (149029 - 253949 == -104920)
																											{
																												mesh.triangles = array4;
																												if (7593 - 58111 == -50518)
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

	// Token: 0x0600C382 RID: 50050 RVA: 0x014800DC File Offset: 0x0147E2DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C383 RID: 50051 RVA: 0x014800E0 File Offset: 0x0147E2E0
	internal static bool aZm0AftodjfMj9ZkKZy0()
	{
		return true;
	}

	// Token: 0x0600C384 RID: 50052 RVA: 0x014800E4 File Offset: 0x0147E2E4
	internal static bool vDtyfPtoJ3RLX1r528j2()
	{
		return false;
	}

	// Token: 0x0400A63E RID: 42558
	public float startWidth;

	// Token: 0x0400A63F RID: 42559
	public float endWidth;

	// Token: 0x0400A640 RID: 42560
	public float life;

	// Token: 0x0400A641 RID: 42561
	public bool alwaysUp;

	// Token: 0x0400A642 RID: 42562
	public float minDistance;

	// Token: 0x0400A643 RID: 42563
	public Color Color1;

	// Token: 0x0400A644 RID: 42564
	public Color Color2;

	// Token: 0x0400A645 RID: 42565
	public Color Color3;

	// Token: 0x0400A646 RID: 42566
	public Color Color4;

	// Token: 0x0400A647 RID: 42567
	public eTrailEmitterMode TrailEmitterMode;

	// Token: 0x0400A648 RID: 42568
	public float uvHeight;

	// Token: 0x0400A649 RID: 42569
	public float localVelocity;

	// Token: 0x0400A64A RID: 42570
	public float worldVelocity;

	// Token: 0x0400A64B RID: 42571
	public bool isTimer;

	// Token: 0x0400A64C RID: 42572
	public float delay;

	// Token: 0x0400A64D RID: 42573
	public float easeIn;

	// Token: 0x0400A64E RID: 42574
	public float easeMiddle;

	// Token: 0x0400A64F RID: 42575
	public float easeOut;

	// Token: 0x0400A650 RID: 42576
	public int minQuality;

	// Token: 0x0400A651 RID: 42577
	private UnityScript.Lang.Array jjpnTK3JDU1;

	// Token: 0x0400A652 RID: 42578
	private float GXfnTz9eWjg;

	// Token: 0x0400A653 RID: 42579
	private bool pMsnY50m2bj;

	// Token: 0x0400A654 RID: 42580
	private Transform nHWnYcfiW8A;

	// Token: 0x0400A655 RID: 42581
	private MeshRenderer VCqnYndPypC;

	// Token: 0x0400A656 RID: 42582
	private MeshFilter gaInYQEg9Fb;
}
