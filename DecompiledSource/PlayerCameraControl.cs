using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FB1 RID: 4017
[Serializable]
public class PlayerCameraControl : MonoBehaviour
{
	// Token: 0x06005B77 RID: 23415 RVA: 0x00B2DAD4 File Offset: 0x00B2BCD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerCameraControl()
	{
		if (248768 - 348754 != -99985)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (162895 - 70541 != 92355)
			{
				base..ctor();
				if (3808 - 301328 == -297520)
				{
					this.distance = 6f;
					if (124411 - 354209 != -229797)
					{
						this.zoom = 5f;
						if (81484 - 299625 == -218141)
						{
							this.clipPlaneMultiplier = 1f;
							if (215753 - 447972 == -232219)
							{
								this.A3Fc2sApeH3 = 1f;
								if (90834 - 49729 != 41106)
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

	// Token: 0x06005B78 RID: 23416 RVA: 0x00B2DBE0 File Offset: 0x00B2BDE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (86000 - 58574 != 27426)
		{
		}
		for (;;)
		{
			this.UD1c21qDTl7 = 0.2f;
			if (112620 - 113171 != -550)
			{
				this.BQec2q1HC5b = 10f;
				if (47540 - 363540 == -316000)
				{
					this.unFc2pAA7ao = 0.3f;
					if (185061 - 147888 == 37173)
					{
						this.n1mc2R9xYU2 = 65286;
						if (62824 - 570992 != -508167)
						{
							this.MGgc2xh8Ksk = Vector3.zero;
							if (83719 - 340573 != -256853)
							{
								this.kAoc2T2DXxQ = Vector3.zero;
								if (152390 - 150752 == 1638)
								{
									this.t7Zc2YSdV9U = (float)0;
									if (299613 - 105678 == 193935)
									{
										this.YHkc23RMrpF = Vector3.zero;
										if (45109 - 310374 == -265265)
										{
											this.fGqc2bRsiwn = Vector3.zero;
											if (158343 - 190695 != -32351)
											{
												this.NfVc2dbj5C3 = (float)0;
												if (53451 - 222916 == -169465)
												{
													this.ylbc243ehEX = this.transform;
													if (39588 - 547193 == -507605)
													{
														if (PlayerPrefs.GetInt("lowAngle", 0) != 0)
														{
															if (132665 - 46271 == 86395)
															{
																continue;
															}
															this.lowAngle = true;
															if (4299 - 515343 == -511043)
															{
																continue;
															}
														}
														int qualityLevel = QualitySettings.GetQualityLevel();
														if (29047 - 154850 != -125802)
														{
															if (qualityLevel == 0)
															{
																if (229597 - 341665 == -112068)
																{
																	this.camera.farClipPlane = Mathf.Clamp(this.clipPlaneMultiplier, 0.5f, (float)2) * 100f;
																	if (32134 - 437266 != -405131)
																	{
																		break;
																	}
																}
															}
															else if (qualityLevel == 1)
															{
																if (26296 - 193695 != -167398)
																{
																	this.camera.farClipPlane = Mathf.Clamp(this.clipPlaneMultiplier, 0.5f, (float)2) * 150f;
																	if (202055 - 131860 != 70196)
																	{
																		break;
																	}
																}
															}
															else if (qualityLevel == 2)
															{
																if (92709 - 446010 != -353300)
																{
																	this.camera.farClipPlane = Mathf.Clamp(this.clipPlaneMultiplier, 0.5f, (float)2) * 200f;
																	if (88960 - 527769 == -438809)
																	{
																		break;
																	}
																}
															}
															else if (qualityLevel == 3)
															{
																if (232317 - 452700 != -220382)
																{
																	this.camera.farClipPlane = Mathf.Clamp(this.clipPlaneMultiplier, 0.5f, (float)2) * 300f;
																	if (124180 - 215958 != -91777)
																	{
																		break;
																	}
																}
															}
															else if (qualityLevel == 4)
															{
																if (40860 - 580411 == -539551)
																{
																	this.camera.farClipPlane = Mathf.Clamp(this.clipPlaneMultiplier, 0.5f, (float)2) * 400f;
																	if (128422 - 445423 == -317001)
																	{
																		break;
																	}
																}
															}
															else
															{
																if (qualityLevel != 5)
																{
																	break;
																}
																if (259151 - 5071 != 254081)
																{
																	this.camera.farClipPlane = Mathf.Clamp(this.clipPlaneMultiplier, 0.5f, (float)2) * 500f;
																	if (227445 - 139437 == 88008)
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

	// Token: 0x06005B79 RID: 23417 RVA: 0x00B2E06C File Offset: 0x00B2C26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (260460 - 537741 != -277280)
		{
		}
		for (;;)
		{
			if (!this.target)
			{
				if (245491 - 68027 != 177465)
				{
					break;
				}
			}
			else
			{
				this.gctc2rX8xMi = (CharacterController)this.target.GetComponent(typeof(CharacterController));
				if (288027 - 464554 == -176527)
				{
					if (this.specialTarget)
					{
						if (120735 - 505869 == -385134)
						{
							if (this.OxLc2aevdMp > Time.time)
							{
								if (281133 - 415181 != -134048)
								{
									continue;
								}
								float t = (Time.time - this.kRrc2g3eIOp) / (this.OxLc2aevdMp - this.kRrc2g3eIOp);
								if (199248 - 266635 != -67387)
								{
									continue;
								}
								float x = Mathf.SmoothStep(this.j8ac2MSmQmq.x, this.specialTarget.transform.position.x, t);
								if (43379 - 444578 != -401199)
								{
									continue;
								}
								Vector3 position = this.ylbc243ehEX.position;
								if (190174 - 385942 != -195768)
								{
									continue;
								}
								position.x = x;
								if (74611 - 517781 == -443169 || 109561 - 137244 == -27682)
								{
									continue;
								}
								Vector3 vector = this.ylbc243ehEX.position = position;
								if (84454 - 536632 != -452178)
								{
									continue;
								}
								if (214010 - 276450 != -62440)
								{
									continue;
								}
								float y = Mathf.SmoothStep(this.j8ac2MSmQmq.y, this.specialTarget.transform.position.y, t);
								if (28702 - 203921 == -175218)
								{
									continue;
								}
								Vector3 position2 = this.ylbc243ehEX.position;
								if (164657 - 235250 != -70593)
								{
									continue;
								}
								float num = position2.y = y;
								if (194126 - 92712 == 101415)
								{
									continue;
								}
								if (144967 - 530202 != -385235)
								{
									continue;
								}
								Vector3 vector2 = this.ylbc243ehEX.position = position2;
								if (271896 - 130987 != 140909)
								{
									continue;
								}
								if (237421 - 16359 == 221063)
								{
									continue;
								}
								float z = Mathf.SmoothStep(this.j8ac2MSmQmq.z, this.specialTarget.transform.position.z, t);
								if (209723 - 421302 == -211578)
								{
									continue;
								}
								Vector3 position3 = this.ylbc243ehEX.position;
								if (189031 - 388265 == -199233)
								{
									continue;
								}
								float num2 = position3.z = z;
								if (255979 - 35537 == 220443)
								{
									continue;
								}
								if (169993 - 130961 != 39032)
								{
									continue;
								}
								Vector3 vector3 = this.ylbc243ehEX.position = position3;
								if (52516 - 451952 == -399435)
								{
									continue;
								}
								if (57819 - 370778 != -312959)
								{
									continue;
								}
								this.ylbc243ehEX.rotation = Quaternion.Slerp(this.YZIc2fpVecw, this.specialTarget.transform.rotation, t);
								if (275448 - 257333 != 18115)
								{
									continue;
								}
							}
							else
							{
								this.ylbc243ehEX.position = this.specialTarget.transform.position;
								if (84769 - 466478 == -381708)
								{
									continue;
								}
								this.ylbc243ehEX.rotation = this.specialTarget.transform.rotation;
								if (137 - 581878 != -581741)
								{
									continue;
								}
							}
							this.ApplyCameraShake();
							if (143311 - 326843 != -183531)
							{
								break;
							}
						}
					}
					else
					{
						Bounds bounds = this.gctc2rX8xMi.bounds;
						if (67726 - 47731 != 19996)
						{
							Vector3 center = bounds.center;
							if (198599 - 472634 != -274034)
							{
								this.NfVc2dbj5C3 = this.gctc2rX8xMi.height - 1.5f;
								if (78601 - 111903 != -33301)
								{
									if (this.NfVc2dbj5C3 < (float)0)
									{
										if (279982 - 137073 != 142909)
										{
											continue;
										}
										this.NfVc2dbj5C3 = (float)0;
										if (262667 - 205429 != 57238)
										{
											continue;
										}
									}
									this.MGgc2xh8Ksk.y = 0.2f * this.gctc2rX8xMi.height;
									if (246586 - 40954 == 205632)
									{
										this.distance += this.zoom;
										if (115458 - 555668 != -440209)
										{
											if (this.distance < (float)2)
											{
												if (235574 - 361701 == -126126)
												{
													continue;
												}
												this.distance = (float)2;
												if (181173 - 295080 != -113907)
												{
													continue;
												}
											}
											if (this.distance > (float)12)
											{
												if (88414 - 2114 == 86301)
												{
													continue;
												}
												this.distance = (float)12;
												if (95216 - 337256 == -242039)
												{
													continue;
												}
											}
											this.zoom = (float)0;
											if (70023 - 245057 == -175034)
											{
												int num3 = 4;
												if (79522 - 298548 == -219026)
												{
													if (this.lowAngle)
													{
														if (129829 - 567889 == -438059)
														{
															continue;
														}
														num3 = 16;
														if (123386 - 170256 != -46870)
														{
															continue;
														}
													}
													if (!this.lockedTarget)
													{
														goto IL_780;
													}
													if (52823 - 51199 != 1624)
													{
														continue;
													}
													if (!this.isLocked)
													{
														goto IL_780;
													}
													if (101833 - 539815 == -437981)
													{
														continue;
													}
													Quaternion to = Quaternion.LookRotation(this.lockedTarget.transform.position - this.ylbc243ehEX.position);
													if (272490 - 338359 == -65868)
													{
														continue;
													}
													this.ylbc243ehEX.rotation = Quaternion.Slerp(this.ylbc243ehEX.rotation, to, Time.deltaTime * (float)3);
													if (288687 - 104389 != 184298)
													{
														continue;
													}
													Vector3 eulerAngles = this.ylbc243ehEX.eulerAngles;
													if (272364 - 506632 == -234267)
													{
														continue;
													}
													float x2 = Mathf.SmoothDampAngle(eulerAngles.x, (float)4 * this.distance - (float)num3, ref this.t7Zc2YSdV9U, 0.3f);
													if (148406 - 451181 != -302775)
													{
														continue;
													}
													Vector3 eulerAngles2 = this.ylbc243ehEX.eulerAngles;
													if (279195 - 336194 == -56998)
													{
														continue;
													}
													eulerAngles2.x = x2;
													if (179481 - 336461 == -156979)
													{
														continue;
													}
													if (65362 - 554955 != -489593)
													{
														continue;
													}
													this.ylbc243ehEX.eulerAngles = eulerAngles2;
													if (213422 - 426272 == -212849 || 184387 - 517197 == -332809)
													{
														continue;
													}
													IL_836:
													this.ApplyPositionDamping(center + this.MGgc2xh8Ksk);
													if (44103 - 171062 != -126959)
													{
														continue;
													}
													this.ApplyCameraShake();
													if (15126 - 141369 != -126243)
													{
														continue;
													}
													break;
													IL_780:
													this.ylbc243ehEX.RotateAround(this.target.transform.position, Vector3.up, this.rotation);
													if (297962 - 381686 != -83723)
													{
														this.rotation = (float)0;
														if (220746 - 197670 != 23077)
														{
															Vector3 eulerAngles3 = this.ylbc243ehEX.eulerAngles;
															if (126907 - 92366 != 34542)
															{
																float x3 = Mathf.SmoothDampAngle(eulerAngles3.x, (float)4 * this.distance - (float)num3, ref this.t7Zc2YSdV9U, 0.3f);
																if (95372 - 242210 == -146838)
																{
																	Vector3 eulerAngles4 = this.ylbc243ehEX.eulerAngles;
																	if (35436 - 217826 != -182389)
																	{
																		eulerAngles4.x = x3;
																		if (251303 - 78937 == 172366)
																		{
																			if (152257 - 467695 == -315438)
																			{
																				this.ylbc243ehEX.eulerAngles = eulerAngles4;
																				if (209946 - 211335 == -1389)
																				{
																					if (184321 - 42884 == 141437)
																					{
																						int num4 = 0;
																						if (228027 - 43785 != 184243)
																						{
																							Vector3 eulerAngles5 = this.ylbc243ehEX.eulerAngles;
																							if (284946 - 364629 != -79682)
																							{
																								float num5 = eulerAngles5.z = (float)num4;
																								if (15623 - 461809 == -446186)
																								{
																									if (45370 - 330300 == -284930)
																									{
																										Vector3 vector4 = this.ylbc243ehEX.eulerAngles = eulerAngles5;
																										if (43014 - 432822 != -389807 && 176364 - 56142 != 120223)
																										{
																											goto IL_836;
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

	// Token: 0x06005B7A RID: 23418 RVA: 0x00B2EC20 File Offset: 0x00B2CE20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector3 AdjustLineOfSight(Vector3 newPosition, Vector3 target)
	{
		if (125551 - 518627 != -393075)
		{
		}
		RaycastHit raycastHit;
		for (;;)
		{
			raycastHit = default(RaycastHit);
			if (2067 - 267961 == -265894)
			{
				if (Physics.Linecast(target, newPosition, out raycastHit, ~this.n1mc2R9xYU2.value))
				{
					if (143489 - 243648 != -100159)
					{
						continue;
					}
					RaycastHit raycastHit2 = default(RaycastHit);
					if (99412 - 376257 != -276845)
					{
						continue;
					}
					Physics.Linecast(newPosition, target, out raycastHit2, ~this.n1mc2R9xYU2.value);
					if (209238 - 183339 == 25900)
					{
						continue;
					}
					if (raycastHit.collider != raycastHit2.collider)
					{
						if (243089 - 61478 != 181611)
						{
							continue;
						}
						this.kAoc2T2DXxQ = Vector3.zero;
						if (108614 - 555643 != -447029)
						{
							continue;
						}
						if (raycastHit.distance >= (float)1)
						{
							if (277325 - 472170 == -194844)
							{
								continue;
							}
							this.YHkc23RMrpF = Vector3.Lerp(this.YHkc23RMrpF, 0.2f * raycastHit.normal, Time.deltaTime * (float)4);
							if (251053 - 37027 != 214026)
							{
								continue;
							}
							break;
						}
						else
						{
							this.YHkc23RMrpF = Vector3.Lerp(this.YHkc23RMrpF, ((float)1 - raycastHit.distance) * Vector3.up, Time.deltaTime * (float)2);
							if (62943 - 132279 != -69335)
							{
								goto Block_4;
							}
							continue;
						}
					}
				}
				this.YHkc23RMrpF = Vector3.Lerp(this.YHkc23RMrpF, Vector3.zero, Time.deltaTime * (float)4);
				if (161889 - 29336 != 132554)
				{
					goto Block_5;
				}
			}
		}
		return raycastHit.point;
		Block_4:
		return target - this.ylbc243ehEX.forward;
		Block_5:
		return newPosition;
	}

	// Token: 0x06005B7B RID: 23419 RVA: 0x00B2EE68 File Offset: 0x00B2D068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyPositionDamping(Vector3 targetCenter)
	{
		if (481 - 465226 != -464745)
		{
		}
		for (;;)
		{
			float num = Mathf.Clamp(this.distance, (float)2, (float)12);
			if (173838 - 519507 != -345668)
			{
				Vector3 position = this.ylbc243ehEX.position;
				if (65603 - 74577 == -8974)
				{
					Vector3 eulerAngles = this.ylbc243ehEX.eulerAngles;
					if (110774 - 413610 == -302836)
					{
						float f = eulerAngles.x * 0.017453292f;
						if (209360 - 500997 != -291636)
						{
							Vector3 eulerAngles2 = this.ylbc243ehEX.eulerAngles;
							if (222243 - 121891 == 100352)
							{
								float f2 = eulerAngles2.y * 0.017453292f;
								if (228496 - 192685 == 35811)
								{
									float num2 = Mathf.Cos(f) * (num + this.NfVc2dbj5C3);
									if (184565 - 307456 != -122890)
									{
										float num3 = Mathf.Sin(f) * (num + this.NfVc2dbj5C3);
										if (78121 - 95972 != -17850)
										{
											Vector3 to = default(Vector3);
											if (115779 - 261242 == -145463)
											{
												to.x = (float)-1 * Mathf.Sin(f2) * num2 + targetCenter.x;
												if (195654 - 389551 == -193897)
												{
													to.y = num3 + targetCenter.y;
													if (197307 - 384410 != -187102)
													{
														to.z = (float)-1 * Mathf.Cos(f2) * num2 + targetCenter.z;
														if (75603 - 62735 == 12868)
														{
															Vector3 vector = Vector3.Lerp(position - this.YHkc23RMrpF, to, Time.deltaTime * (float)4);
															if (247522 - 331716 == -84194)
															{
																vector = this.AdjustLineOfSight(vector, targetCenter);
																if (208922 - 379575 == -170653)
																{
																	this.ylbc243ehEX.position = vector + this.YHkc23RMrpF;
																	if (47410 - 387453 != -340042)
																	{
																		this.camera.fieldOfView = Mathf.Clamp((float)45 + (targetCenter - vector).magnitude + (float)5 * this.NfVc2dbj5C3, (float)15, (float)90);
																		if (208127 - 148420 == 59707)
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

	// Token: 0x06005B7C RID: 23420 RVA: 0x00B2F188 File Offset: 0x00B2D388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddCamereShake(float nMagnitude)
	{
		this.ShakeMagnitude += nMagnitude;
	}

	// Token: 0x06005B7D RID: 23421 RVA: 0x00B2F198 File Offset: 0x00B2D398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyCameraShake()
	{
		if (145948 - 250455 != -104507)
		{
		}
		while (this.ShakeMagnitude > (float)0)
		{
			if (37729 - 25237 == 12492)
			{
				this.A3Fc2sApeH3 *= (float)-1;
				if (151736 - 115602 == 36134)
				{
					this.ylbc243ehEX.position = this.ylbc243ehEX.position + Vector3.up * Mathf.Clamp(this.ShakeMagnitude / (float)5, (float)0, 0.5f) * this.A3Fc2sApeH3;
					if (173170 - 469662 != -296491)
					{
						this.ShakeMagnitude = Mathf.Lerp(this.ShakeMagnitude, (float)0, Time.deltaTime * (float)4);
						if (2828 - 443946 != -441117)
						{
							if (this.ShakeMagnitude >= 0.1f)
							{
								break;
							}
							if (261093 - 342961 != -81867)
							{
								this.ShakeMagnitude = (float)0;
								if (190596 - 64056 != 126541)
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

	// Token: 0x06005B7E RID: 23422 RVA: 0x00B2F300 File Offset: 0x00B2D500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float AngleDistance(float a, float b)
	{
		a = Mathf.Repeat(a, (float)360);
		b = Mathf.Repeat(b, (float)360);
		return Mathf.Abs(b - a);
	}

	// Token: 0x06005B7F RID: 23423 RVA: 0x00B2F330 File Offset: 0x00B2D530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AutoZoom(float targetDistance, float targetTime)
	{
		return new PlayerCameraControl.$AutoZoom$36072(targetDistance, targetTime, this).GetEnumerator();
	}

	// Token: 0x06005B80 RID: 23424 RVA: 0x00B2F340 File Offset: 0x00B2D540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void snapToObject(string nTargetName)
	{
		if (70280 - 401093 != -330813)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find(nTargetName);
			if (296096 - 35717 == 260379)
			{
				if (gameObject)
				{
					if (87134 - 553379 == -466245)
					{
						this.transform.position = gameObject.transform.position;
						if (299899 - 229793 != 70107)
						{
							this.transform.rotation = gameObject.transform.rotation;
							if (134701 - 519538 != -384836)
							{
								break;
							}
						}
					}
				}
				else
				{
					Debug.LogError("snapToObject Error - Cannon find target name:" + nTargetName);
					if (108727 - 449298 == -340571)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005B81 RID: 23425 RVA: 0x00B2F450 File Offset: 0x00B2D650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void alignToObject(string nTargetName)
	{
		if (57388 - 585263 != -527874)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find(nTargetName);
			if (115729 - 348951 == -233222)
			{
				if (gameObject)
				{
					if (154924 - 549832 == -394908)
					{
						this.transform.position = gameObject.transform.position;
						if (289952 - 562058 != -272105)
						{
							this.transform.rotation = gameObject.transform.rotation;
							if (97076 - 481730 == -384654)
							{
								this.enabled = false;
								if (122696 - 332075 != -209378)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					Debug.LogError("alignToObject Error - Cannon find target name:" + nTargetName);
					if (199979 - 209388 != -9408)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005B82 RID: 23426 RVA: 0x00B2F580 File Offset: 0x00B2D780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator slerpToObject(string nTargetName, float nTimer)
	{
		return new PlayerCameraControl.$slerpToObject$36081(nTargetName, nTimer, this).GetEnumerator();
	}

	// Token: 0x06005B83 RID: 23427 RVA: 0x00B2F590 File Offset: 0x00B2D790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setSpecialTarget(GameObject nSpecialTarget, float nLag)
	{
		if (256354 - 300322 != -43967)
		{
		}
		for (;;)
		{
			this.specialTarget = nSpecialTarget;
			if (212072 - 233772 != -21699)
			{
				this.kRrc2g3eIOp = Time.time;
				if (143410 - 36420 == 106990)
				{
					this.OxLc2aevdMp = this.kRrc2g3eIOp + nLag;
					if (140654 - 3649 == 137005)
					{
						this.j8ac2MSmQmq = this.transform.position;
						if (230486 - 333337 != -102850)
						{
							this.YZIc2fpVecw = this.transform.rotation;
							if (190759 - 47705 == 143054)
							{
								this.enabled = true;
								if (130606 - 331136 != -200529)
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

	// Token: 0x06005B84 RID: 23428 RVA: 0x00B2F6B0 File Offset: 0x00B2D8B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setSpecialCamera(string nTargetName, float nFOV, float nLag)
	{
		if (244555 - 395071 != -150515)
		{
		}
		for (;;)
		{
			GameObject exists = GameObject.Find(nTargetName);
			if (250173 - 290368 != -40194)
			{
				if (exists)
				{
					if (181756 - 351924 != -170167)
					{
						this.specialTarget = exists;
						if (28786 - 168863 == -140077)
						{
							this.kRrc2g3eIOp = Time.time;
							if (234794 - 198996 == 35798)
							{
								this.OxLc2aevdMp = this.kRrc2g3eIOp + nLag;
								if (19175 - 12805 != 6371)
								{
									this.j8ac2MSmQmq = this.transform.position;
									if (219688 - 157011 != 62678)
									{
										this.YZIc2fpVecw = this.transform.rotation;
										if (217130 - 447772 == -230642)
										{
											this.camera.fieldOfView = nFOV;
											if (81733 - 437534 != -355800)
											{
												this.enabled = true;
												if (29950 - 400760 != -370809)
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
				else
				{
					Debug.LogError("alignToObject Error - Cannon find target name:" + nTargetName);
					if (37034 - 265337 != -228302)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005B85 RID: 23429 RVA: 0x00B2F868 File Offset: 0x00B2DA68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void resetPlayerCamera()
	{
		this.specialTarget = null;
		this.enabled = true;
	}

	// Token: 0x06005B86 RID: 23430 RVA: 0x00B2F878 File Offset: 0x00B2DA78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005B87 RID: 23431 RVA: 0x00B2F87C File Offset: 0x00B2DA7C
	internal static bool aIwR6PpNnh8kR0RmxqCf()
	{
		return true;
	}

	// Token: 0x06005B88 RID: 23432 RVA: 0x00B2F880 File Offset: 0x00B2DA80
	internal static bool kp2fPgpN6rBFCnnBq9dt()
	{
		return false;
	}

	// Token: 0x040066CA RID: 26314
	public GameObject target;

	// Token: 0x040066CB RID: 26315
	public GameObject specialTarget;

	// Token: 0x040066CC RID: 26316
	public GameObject lockedTarget;

	// Token: 0x040066CD RID: 26317
	public bool isLocked;

	// Token: 0x040066CE RID: 26318
	public bool lowAngle;

	// Token: 0x040066CF RID: 26319
	public float distance;

	// Token: 0x040066D0 RID: 26320
	public float rotation;

	// Token: 0x040066D1 RID: 26321
	public float zoom;

	// Token: 0x040066D2 RID: 26322
	public float clipPlaneMultiplier;

	// Token: 0x040066D3 RID: 26323
	private float UD1c21qDTl7;

	// Token: 0x040066D4 RID: 26324
	private float BQec2q1HC5b;

	// Token: 0x040066D5 RID: 26325
	private float unFc2pAA7ao;

	// Token: 0x040066D6 RID: 26326
	private LayerMask n1mc2R9xYU2;

	// Token: 0x040066D7 RID: 26327
	private CharacterController gctc2rX8xMi;

	// Token: 0x040066D8 RID: 26328
	private Vector3 MGgc2xh8Ksk;

	// Token: 0x040066D9 RID: 26329
	private Vector3 kAoc2T2DXxQ;

	// Token: 0x040066DA RID: 26330
	private float t7Zc2YSdV9U;

	// Token: 0x040066DB RID: 26331
	private Vector3 YHkc23RMrpF;

	// Token: 0x040066DC RID: 26332
	private Vector3 fGqc2bRsiwn;

	// Token: 0x040066DD RID: 26333
	private float NfVc2dbj5C3;

	// Token: 0x040066DE RID: 26334
	private float kRrc2g3eIOp;

	// Token: 0x040066DF RID: 26335
	private float OxLc2aevdMp;

	// Token: 0x040066E0 RID: 26336
	private Transform ylbc243ehEX;

	// Token: 0x040066E1 RID: 26337
	public float ShakeMagnitude;

	// Token: 0x040066E2 RID: 26338
	private float A3Fc2sApeH3;

	// Token: 0x040066E3 RID: 26339
	private bool cSHc2HSmSrn;

	// Token: 0x040066E4 RID: 26340
	private float SMKc27Ciux9;

	// Token: 0x040066E5 RID: 26341
	private float DYmc2ZIOU40;

	// Token: 0x040066E6 RID: 26342
	private float ugmc2C8dZWA;

	// Token: 0x040066E7 RID: 26343
	private Vector3 j8ac2MSmQmq;

	// Token: 0x040066E8 RID: 26344
	private Quaternion YZIc2fpVecw;

	// Token: 0x02000FB2 RID: 4018
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AutoZoom$36072 : GenericGenerator<object>
	{
		// Token: 0x06005B89 RID: 23433 RVA: 0x00B2F884 File Offset: 0x00B2DA84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AutoZoom$36072(float targetDistance, float targetTime, PlayerCameraControl self_)
		{
			if (218315 - 339733 != -121418)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70386 - 507841 == -437455)
				{
					base..ctor();
					if (234937 - 273667 == -38730)
					{
						this.$targetDistance$36078 = targetDistance;
						if (257303 - 462803 == -205500)
						{
							this.$targetTime$36079 = targetTime;
							if (34114 - 157612 == -123498)
							{
								this.$self_$36080 = self_;
								if (176276 - 245762 != -69485)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x00B2F960 File Offset: 0x00B2DB60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new PlayerCameraControl.$AutoZoom$36072.$(this.$targetDistance$36078, this.$targetTime$36079, this.$self_$36080);
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x00B2F97C File Offset: 0x00B2DB7C
		internal static bool DpktPtpNixNvN6PhhXCI()
		{
			return true;
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x00B2F980 File Offset: 0x00B2DB80
		internal static bool NHjnckpNKVDh7kqIPDqe()
		{
			return false;
		}

		// Token: 0x040066E9 RID: 26345
		internal float $targetDistance$36078;

		// Token: 0x040066EA RID: 26346
		internal float $targetTime$36079;

		// Token: 0x040066EB RID: 26347
		internal PlayerCameraControl $self_$36080;

		// Token: 0x02000FB3 RID: 4019
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x06005B8D RID: 23437 RVA: 0x00B2F984 File Offset: 0x00B2DB84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float targetDistance, float targetTime, PlayerCameraControl self_)
			{
				if (620 - 282245 != -281625)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136783 - 170105 == -33322)
					{
						base..ctor();
						if (5480 - 426850 != -421369)
						{
							this.$targetDistance$36075 = targetDistance;
							if (12053 - 243216 != -231162)
							{
								this.$targetTime$36076 = targetTime;
								if (161872 - 473316 != -311443)
								{
									this.$self_$36077 = self_;
									if (166865 - 21045 == 145820)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005B8E RID: 23438 RVA: 0x00B2FA60 File Offset: 0x00B2DC60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (24669 - 362844 != -338175)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_220;
					case 1:
						goto IL_283;
					case 2:
						break;
					default:
						if (120926 - 64775 != 56151)
						{
							continue;
						}
						goto IL_220;
					}
					IL_1F6:
					if (this.$self_$36077.cSHc2HSmSrn)
					{
						if (39798 - 178562 == -138763)
						{
							continue;
						}
						if (Time.time >= this.$autoZoom_timer$36073)
						{
							if (226293 - 189450 == 36844)
							{
								continue;
							}
						}
						else
						{
							this.$self_$36077.zoom = this.$self_$36077.zoom + this.$deltaZoom$36074 * Time.deltaTime;
							if (9432 - 544213 != -534781)
							{
								continue;
							}
							break;
						}
					}
					this.$self_$36077.cSHc2HSmSrn = false;
					if (36105 - 25392 == 10714)
					{
						continue;
					}
					this.YieldDefault(1);
					if (10246 - 254792 != -244546)
					{
						continue;
					}
					goto IL_283;
					IL_220:
					if (this.$self_$36077.cSHc2HSmSrn)
					{
						if (240470 - 106146 != 134325)
						{
							goto Block_18;
						}
					}
					else
					{
						this.$self_$36077.cSHc2HSmSrn = true;
						if (37802 - 263975 != -226172)
						{
							if (this.$targetDistance$36075 < (float)2)
							{
								if (249869 - 538281 == -288411)
								{
									continue;
								}
								this.$targetDistance$36075 = (float)2;
								if (1168 - 45285 != -44117)
								{
									continue;
								}
							}
							if (this.$targetDistance$36075 > (float)12)
							{
								if (407 - 589825 != -589418)
								{
									continue;
								}
								this.$targetDistance$36075 = (float)12;
								if (220979 - 290346 == -69366)
								{
									continue;
								}
							}
							this.$autoZoom_timer$36073 = Time.time + this.$targetTime$36076;
							if (101713 - 240465 == -138752)
							{
								this.$deltaZoom$36074 = (this.$targetDistance$36075 - this.$self_$36077.distance) / this.$targetTime$36076;
								if (53583 - 89515 != -35931)
								{
									goto IL_1F6;
								}
							}
						}
					}
				}
				return this.YieldDefault(2);
				Block_18:
				IL_283:
				return false;
			}

			// Token: 0x06005B8F RID: 23439 RVA: 0x00B2FD04 File Offset: 0x00B2DF04
			internal static bool Tfe76vpNdnJLVbEaBn64()
			{
				return true;
			}

			// Token: 0x06005B90 RID: 23440 RVA: 0x00B2FD08 File Offset: 0x00B2DF08
			internal static bool iUUHEqpNJmsVpKejT3A1()
			{
				return false;
			}

			// Token: 0x040066EC RID: 26348
			internal float $autoZoom_timer$36073;

			// Token: 0x040066ED RID: 26349
			internal float $deltaZoom$36074;

			// Token: 0x040066EE RID: 26350
			internal float $targetDistance$36075;

			// Token: 0x040066EF RID: 26351
			internal float $targetTime$36076;

			// Token: 0x040066F0 RID: 26352
			internal PlayerCameraControl $self_$36077;
		}
	}

	// Token: 0x02000FB4 RID: 4020
	[CompilerGenerated]
	[Serializable]
	internal sealed class $slerpToObject$36081 : GenericGenerator<object>
	{
		// Token: 0x06005B91 RID: 23441 RVA: 0x00B2FD0C File Offset: 0x00B2DF0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $slerpToObject$36081(string nTargetName, float nTimer, PlayerCameraControl self_)
		{
			if (296512 - 564814 != -268301)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (18452 - 454857 != -436404)
				{
					base..ctor();
					if (31229 - 530845 == -499616)
					{
						this.$nTargetName$36104 = nTargetName;
						if (44494 - 37105 == 7389)
						{
							this.$nTimer$36105 = nTimer;
							if (242663 - 198727 != 43937)
							{
								this.$self_$36106 = self_;
								if (148285 - 88327 == 59958)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x00B2FDE8 File Offset: 0x00B2DFE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new PlayerCameraControl.$slerpToObject$36081.$(this.$nTargetName$36104, this.$nTimer$36105, this.$self_$36106);
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x00B2FE04 File Offset: 0x00B2E004
		internal static bool i4tR28pNDmXhDm7SqCYF()
		{
			return true;
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x00B2FE08 File Offset: 0x00B2E008
		internal static bool cFOFFmpNv42SpWtWa2rl()
		{
			return false;
		}

		// Token: 0x040066F1 RID: 26353
		internal string $nTargetName$36104;

		// Token: 0x040066F2 RID: 26354
		internal float $nTimer$36105;

		// Token: 0x040066F3 RID: 26355
		internal PlayerCameraControl $self_$36106;

		// Token: 0x02000FB5 RID: 4021
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x06005B95 RID: 23445 RVA: 0x00B2FE0C File Offset: 0x00B2E00C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(string nTargetName, float nTimer, PlayerCameraControl self_)
			{
				if (120572 - 132304 != -11732)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (2238 - 292621 == -290383)
					{
						base..ctor();
						if (134131 - 140196 == -6065)
						{
							this.$nTargetName$36101 = nTargetName;
							if (223023 - 239569 == -16546)
							{
								this.$nTimer$36102 = nTimer;
								if (192440 - 364199 == -171759)
								{
									this.$self_$36103 = self_;
									if (209503 - 411584 != -202080)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005B96 RID: 23446 RVA: 0x00B2FEE8 File Offset: 0x00B2E0E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (283054 - 599247 != -316193)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B3C;
					case 2:
						goto IL_AA5;
					default:
						if (122145 - 469063 != -346918)
						{
							continue;
						}
						break;
					}
					this.$mTargetObject$36082 = GameObject.Find(this.$nTargetName$36101);
					if (173153 - 83550 == 89604)
					{
						continue;
					}
					if (this.$mTargetObject$36082)
					{
						if (246425 - 184902 != 61523)
						{
							continue;
						}
						if (this.$nTimer$36102 > (float)0)
						{
							if (157817 - 40993 == 116825)
							{
								continue;
							}
							this.$nPos$36083 = this.$mTargetObject$36082.transform.position;
							if (11071 - 491290 == -480218)
							{
								continue;
							}
							this.$nRot$36084 = this.$mTargetObject$36082.transform.eulerAngles;
							if (175262 - 19285 == 155978)
							{
								continue;
							}
							this.$oPos$36085 = this.$self_$36103.ylbc243ehEX.position;
							if (129461 - 331313 == -201851)
							{
								continue;
							}
							this.$oRot$36086 = this.$self_$36103.ylbc243ehEX.eulerAngles;
							if (2031 - 390286 == -388254)
							{
								continue;
							}
							this.$tRot$36087 = new Vector3(this.$oRot$36086.x + Mathf.DeltaAngle(this.$oRot$36086.x, this.$nRot$36084.x), this.$oRot$36086.y + Mathf.DeltaAngle(this.$oRot$36086.y, this.$nRot$36084.y), this.$oRot$36086.z + Mathf.DeltaAngle(this.$oRot$36086.z, this.$nRot$36084.z));
							if (44445 - 590142 != -545697)
							{
								continue;
							}
							this.$nStartTime$36088 = Time.time;
							if (185491 - 489698 == -304206)
							{
								continue;
							}
							this.$self_$36103.enabled = false;
							if (89430 - 365382 != -275951)
							{
								goto IL_AA5;
							}
							continue;
						}
					}
					Debug.LogError("slerpToObject Error - Cannon find target name:" + this.$nTargetName$36101);
					if (43231 - 520601 != -477370)
					{
						continue;
					}
					goto IL_3F9;
					IL_AA5:
					if (Time.time < this.$nStartTime$36088 + this.$nTimer$36102)
					{
						if (216320 - 290683 != -74363)
						{
							continue;
						}
						if (this.$self_$36103.enabled)
						{
							if (217861 - 449018 != -231157)
							{
								continue;
							}
						}
						else
						{
							float num = this.$$13854$36089 = Mathf.SmoothStep(this.$oPos$36085.x, this.$nPos$36083.x, (Time.time - this.$nStartTime$36088) / this.$nTimer$36102);
							if (285890 - 142739 != 143151)
							{
								continue;
							}
							if (196886 - 578736 != -381850)
							{
								continue;
							}
							this.$$13855$36090 = this.$self_$36103.ylbc243ehEX.position;
							if (52773 - 341297 != -288524)
							{
								continue;
							}
							if (9172 - 246264 == -237091)
							{
								continue;
							}
							this.$$13855$36090.x = this.$$13854$36089;
							if (7041 - 371742 == -364700 || 150392 - 349388 == -198995)
							{
								continue;
							}
							this.$self_$36103.ylbc243ehEX.position = this.$$13855$36090;
							if (82598 - 252286 != -169688)
							{
								continue;
							}
							if (227149 - 206661 == 20489)
							{
								continue;
							}
							float num2 = this.$$13856$36091 = Mathf.SmoothStep(this.$oPos$36085.y, this.$nPos$36083.y, (Time.time - this.$nStartTime$36088) / this.$nTimer$36102);
							if (200842 - 467401 == -266558)
							{
								continue;
							}
							if (202550 - 42211 != 160339)
							{
								continue;
							}
							Vector3 vector = this.$$13857$36092 = this.$self_$36103.ylbc243ehEX.position;
							if (258507 - 484450 != -225943)
							{
								continue;
							}
							if (128643 - 35109 != 93534)
							{
								continue;
							}
							this.$$13857$36092.y = this.$$13856$36091;
							if (234392 - 340917 == -106524 || 284801 - 86501 == 198301)
							{
								continue;
							}
							Vector3 vector2 = this.$self_$36103.ylbc243ehEX.position = this.$$13857$36092;
							if (7967 - 475799 == -467831)
							{
								continue;
							}
							if (222702 - 519588 != -296886)
							{
								continue;
							}
							this.$$13858$36093 = Mathf.SmoothStep(this.$oPos$36085.z, this.$nPos$36083.z, (Time.time - this.$nStartTime$36088) / this.$nTimer$36102);
							if (242144 - 75279 == 166866 || 124336 - 409119 == -284782)
							{
								continue;
							}
							this.$$13859$36094 = this.$self_$36103.ylbc243ehEX.position;
							if (39015 - 314579 == -275563 || 100298 - 107811 == -7512)
							{
								continue;
							}
							float num3 = this.$$13859$36094.z = this.$$13858$36093;
							if (37706 - 453835 == -416128 || 299595 - 428324 == -128728)
							{
								continue;
							}
							this.$self_$36103.ylbc243ehEX.position = this.$$13859$36094;
							if (276466 - 96068 == 180399)
							{
								continue;
							}
							if (48473 - 365010 != -316537)
							{
								continue;
							}
							this.$$13860$36095 = Mathf.SmoothStep(this.$oRot$36086.x, this.$tRot$36087.x, (Time.time - this.$nStartTime$36088) / this.$nTimer$36102);
							if (16393 - 479705 == -463311)
							{
								continue;
							}
							if (258694 - 137568 != 121126)
							{
								continue;
							}
							this.$$13861$36096 = this.$self_$36103.ylbc243ehEX.eulerAngles;
							if (2514 - 511590 != -509076)
							{
								continue;
							}
							if (4178 - 98529 == -94350)
							{
								continue;
							}
							float num4 = this.$$13861$36096.x = this.$$13860$36095;
							if (141488 - 595071 != -453583)
							{
								continue;
							}
							if (223894 - 82584 != 141310)
							{
								continue;
							}
							this.$self_$36103.ylbc243ehEX.eulerAngles = this.$$13861$36096;
							if (163019 - 150174 != 12845)
							{
								continue;
							}
							if (147441 - 55288 != 92153)
							{
								continue;
							}
							float num5 = this.$$13862$36097 = Mathf.SmoothStep(this.$oRot$36086.y, this.$tRot$36087.y, (Time.time - this.$nStartTime$36088) / this.$nTimer$36102);
							if (244258 - 87093 != 157165)
							{
								continue;
							}
							if (33304 - 425589 != -392285)
							{
								continue;
							}
							Vector3 vector3 = this.$$13863$36098 = this.$self_$36103.ylbc243ehEX.eulerAngles;
							if (195868 - 541481 != -345613)
							{
								continue;
							}
							if (104884 - 522920 != -418036)
							{
								continue;
							}
							this.$$13863$36098.y = this.$$13862$36097;
							if (55896 - 273782 == -217885 || 92805 - 579328 == -486522)
							{
								continue;
							}
							this.$self_$36103.ylbc243ehEX.eulerAngles = this.$$13863$36098;
							if (299443 - 144974 == 154470)
							{
								continue;
							}
							if (164998 - 165792 != -794)
							{
								continue;
							}
							this.$$13864$36099 = Mathf.SmoothStep(this.$oRot$36086.z, this.$tRot$36087.z, (Time.time - this.$nStartTime$36088) / this.$nTimer$36102);
							if (267262 - 31279 != 235983)
							{
								continue;
							}
							if (219593 - 520059 != -300466)
							{
								continue;
							}
							this.$$13865$36100 = this.$self_$36103.ylbc243ehEX.eulerAngles;
							if (162451 - 93704 == 68748)
							{
								continue;
							}
							if (214701 - 140911 != 73790)
							{
								continue;
							}
							this.$$13865$36100.z = this.$$13864$36099;
							if (212295 - 416176 != -203881)
							{
								continue;
							}
							if (131458 - 300398 == -168939)
							{
								continue;
							}
							this.$self_$36103.ylbc243ehEX.eulerAngles = this.$$13865$36100;
							if (177782 - 328106 != -150324)
							{
								continue;
							}
							if (281279 - 484939 != -203659)
							{
								break;
							}
							continue;
						}
					}
					IL_3F9:
					this.YieldDefault(1);
					if (172700 - 355179 == -182479)
					{
						goto IL_B3C;
					}
				}
				return this.YieldDefault(2);
				IL_B3C:
				return false;
			}

			// Token: 0x06005B97 RID: 23447 RVA: 0x00B30A44 File Offset: 0x00B2EC44
			internal static bool rlKPtNpNRB3Mjid6Gsb0()
			{
				return true;
			}

			// Token: 0x06005B98 RID: 23448 RVA: 0x00B30A48 File Offset: 0x00B2EC48
			internal static bool K3v082pNw7l1t3hfWSIP()
			{
				return false;
			}

			// Token: 0x040066F4 RID: 26356
			internal GameObject $mTargetObject$36082;

			// Token: 0x040066F5 RID: 26357
			internal Vector3 $nPos$36083;

			// Token: 0x040066F6 RID: 26358
			internal Vector3 $nRot$36084;

			// Token: 0x040066F7 RID: 26359
			internal Vector3 $oPos$36085;

			// Token: 0x040066F8 RID: 26360
			internal Vector3 $oRot$36086;

			// Token: 0x040066F9 RID: 26361
			internal Vector3 $tRot$36087;

			// Token: 0x040066FA RID: 26362
			internal float $nStartTime$36088;

			// Token: 0x040066FB RID: 26363
			internal float $$13854$36089;

			// Token: 0x040066FC RID: 26364
			internal Vector3 $$13855$36090;

			// Token: 0x040066FD RID: 26365
			internal float $$13856$36091;

			// Token: 0x040066FE RID: 26366
			internal Vector3 $$13857$36092;

			// Token: 0x040066FF RID: 26367
			internal float $$13858$36093;

			// Token: 0x04006700 RID: 26368
			internal Vector3 $$13859$36094;

			// Token: 0x04006701 RID: 26369
			internal float $$13860$36095;

			// Token: 0x04006702 RID: 26370
			internal Vector3 $$13861$36096;

			// Token: 0x04006703 RID: 26371
			internal float $$13862$36097;

			// Token: 0x04006704 RID: 26372
			internal Vector3 $$13863$36098;

			// Token: 0x04006705 RID: 26373
			internal float $$13864$36099;

			// Token: 0x04006706 RID: 26374
			internal Vector3 $$13865$36100;

			// Token: 0x04006707 RID: 26375
			internal string $nTargetName$36101;

			// Token: 0x04006708 RID: 26376
			internal float $nTimer$36102;

			// Token: 0x04006709 RID: 26377
			internal PlayerCameraControl $self_$36103;
		}
	}
}
