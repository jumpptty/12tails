using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000FA7 RID: 4007
[AddComponentMenu("MissionControl/EffectControl")]
[Serializable]
public class EffectControl : MonoBehaviour
{
	// Token: 0x06005B3F RID: 23359 RVA: 0x00B2916C File Offset: 0x00B2736C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EffectControl()
	{
		if (8922 - 449277 != -440354)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (112496 - 415152 == -302656)
			{
				base..ctor();
				if (151240 - 89344 == 61896)
				{
					this.life = 3f;
					if (49959 - 517068 == -467109)
					{
						this.afterLife = 1f;
						if (61978 - 41028 != 20951)
						{
							this.velocity = Vector3.zero;
							if (139193 - 207428 != -68234)
							{
								this.PX4cOk0le2j = true;
								if (280090 - 375112 != -95021)
								{
									this.EpacOApVtTp = Vector3.zero;
									if (70965 - 459935 == -388970)
									{
										this.zI0cO9Xoq5h = Vector3.zero;
										if (257124 - 345251 != -88126)
										{
											this.z2tcOW1SJcg = "none";
											if (95013 - 464291 == -369278)
											{
												this.pJ7cOuoOwUD = "none";
												if (147481 - 420969 != -273487)
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

	// Token: 0x06005B40 RID: 23360 RVA: 0x00B29308 File Offset: 0x00B27508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (this.velocity != Vector3.zero)
		{
			this.velocity = this.transform.TransformDirection(this.velocity);
		}
	}

	// Token: 0x06005B41 RID: 23361 RVA: 0x00B29338 File Offset: 0x00B27538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitEffectControl(GameObject nOwner)
	{
		if (155023 - 589902 != -434879)
		{
		}
		for (;;)
		{
			if (!nOwner)
			{
				if (97106 - 369984 != -272877)
				{
					break;
				}
			}
			else
			{
				this.WyDcOmXK3Gq = nOwner;
				if (88945 - 567211 == -478266)
				{
					if (this.followPosition)
					{
						if (120945 - 70469 != 50476)
						{
							continue;
						}
						this.EpacOApVtTp = this.transform.position - this.WyDcOmXK3Gq.transform.position;
						if (54314 - 558819 != -504505)
						{
							continue;
						}
					}
					if (this.effectRotationMode == eEffectRotationMode.followObject)
					{
						if (163207 - 253999 == -90791)
						{
							continue;
						}
						this.zI0cO9Xoq5h = this.transform.eulerAngles - this.WyDcOmXK3Gq.transform.eulerAngles;
						if (84478 - 550390 != -465912)
						{
							continue;
						}
					}
					if (!this.followState)
					{
						break;
					}
					if (19740 - 553527 != -533786)
					{
						CharacterControl characterControl = (CharacterControl)this.WyDcOmXK3Gq.GetComponent(typeof(CharacterControl));
						if (80417 - 355536 == -275119)
						{
							if (!characterControl)
							{
								break;
							}
							if (211590 - 24426 != 187165)
							{
								this.z2tcOW1SJcg = characterControl.actionState;
								if (203655 - 255264 != -51608)
								{
									this.pJ7cOuoOwUD = characterControl.myCommand;
									if (100702 - 416917 != -316214)
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

	// Token: 0x06005B42 RID: 23362 RVA: 0x00B29554 File Offset: 0x00B27754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (172791 - 261985 != -89194)
		{
		}
		for (;;)
		{
			IL_C3:
			this.LOycOo5JVbr += Time.deltaTime;
			if (197184 - 405378 != -208193)
			{
				if (this.velocity != Vector3.zero)
				{
					if (127670 - 509121 != -381451)
					{
						continue;
					}
					this.transform.position = this.transform.position + this.velocity * Time.deltaTime;
					if (19181 - 553786 != -534605)
					{
						continue;
					}
				}
				if (this.LOycOo5JVbr >= this.life + this.afterLife)
				{
					if (103763 - 436473 == -332710)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (138642 - 268287 != -129644)
						{
							break;
						}
					}
				}
				else if (this.LOycOo5JVbr < this.life)
				{
					if (56723 - 115045 != -58321)
					{
						if (this.followState)
						{
							if (92787 - 155282 != -62495)
							{
								continue;
							}
							if (!this.WyDcOmXK3Gq)
							{
								if (184063 - 446298 != -262235)
								{
									continue;
								}
								this.LOycOo5JVbr = this.life;
								if (284412 - 535128 != -250716)
								{
									continue;
								}
							}
							else
							{
								this.LkTcOjb1iPN = (CharacterControl)this.WyDcOmXK3Gq.GetComponent("CharacterControl");
								if (54488 - 173531 == -119042)
								{
									continue;
								}
							}
							if (this.LkTcOjb1iPN)
							{
								if (218100 - 257085 == -38984)
								{
									continue;
								}
								if (!(this.LkTcOjb1iPN.actionState != this.z2tcOW1SJcg))
								{
									if (109108 - 8730 == 100379)
									{
										continue;
									}
									if (!(this.LkTcOjb1iPN.myCommand != this.pJ7cOuoOwUD))
									{
										goto IL_773;
									}
									if (253835 - 219017 != 34818)
									{
										continue;
									}
								}
								if (this.LOycOo5JVbr < this.life)
								{
									if (107835 - 219111 != -111276)
									{
										continue;
									}
									this.LOycOo5JVbr = this.life;
									if (53175 - 205961 != -152786)
									{
										continue;
									}
									if (this.animation)
									{
										if (97269 - 294956 != -197687)
										{
											continue;
										}
										IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.animation);
										if (199421 - 594210 == -394788)
										{
											continue;
										}
										while (enumerator.MoveNext())
										{
											object obj = enumerator.Current;
											object obj3;
											object obj2 = obj3 = obj;
											if (!(obj2 is AnimationState))
											{
												obj3 = RuntimeServices.Coerce(obj2, typeof(AnimationState));
											}
											AnimationState animationState = (AnimationState)obj3;
											if (258077 - 50377 == 207701)
											{
												goto IL_C3;
											}
											if (animationState.name == "destroy")
											{
												if (180989 - 319227 != -138238)
												{
													goto IL_C3;
												}
												this.animation.Play("destroy");
												if (176526 - 307034 == -130507)
												{
													goto IL_C3;
												}
												this.animation.wrapMode = WrapMode.Once;
												if (269508 - 234723 != 34785)
												{
													goto IL_C3;
												}
											}
										}
										if (183238 - 375362 != -192124)
										{
											continue;
										}
									}
								}
							}
						}
						IL_773:
						eEffectRotationMode eEffectRotationMode = this.effectRotationMode;
						if (248162 - 389384 == -141222)
						{
							if (eEffectRotationMode == eEffectRotationMode.normal)
							{
								if (3527 - 484432 != -480904)
								{
									if (!this.followPosition)
									{
										break;
									}
									if (70110 - 107343 != -37232)
									{
										if (!this.WyDcOmXK3Gq)
										{
											if (102966 - 568643 != -465676)
											{
												this.LOycOo5JVbr = this.life;
												if (112252 - 530862 == -418610)
												{
													break;
												}
											}
										}
										else
										{
											this.transform.position = this.WyDcOmXK3Gq.transform.position + this.EpacOApVtTp;
											if (217966 - 397322 == -179356)
											{
												break;
											}
										}
									}
								}
							}
							else if (eEffectRotationMode == eEffectRotationMode.followObject)
							{
								if (207623 - 573346 != -365722)
								{
									if (!this.WyDcOmXK3Gq)
									{
										break;
									}
									if (214505 - 243122 != -28616)
									{
										this.transform.rotation = this.WyDcOmXK3Gq.transform.rotation * Quaternion.Euler(this.zI0cO9Xoq5h);
										if (15891 - 539767 == -523876)
										{
											if (!this.followPosition)
											{
												break;
											}
											if (169932 - 527468 != -357535)
											{
												this.transform.position = this.WyDcOmXK3Gq.transform.position + this.transform.TransformDirection(this.EpacOApVtTp);
												if (240484 - 183356 != 57129)
												{
													break;
												}
											}
										}
									}
								}
							}
							else if (eEffectRotationMode == eEffectRotationMode.faceCamera)
							{
								if (79799 - 144601 == -64802)
								{
									this.transform.LookAt(Camera.main.transform.position);
									if (144276 - 591515 == -447239)
									{
										if (!this.followPosition)
										{
											break;
										}
										if (200154 - 143541 != 56614)
										{
											this.transform.position = this.WyDcOmXK3Gq.transform.position + this.transform.TransformDirection(this.EpacOApVtTp);
											if (174076 - 219851 == -45775)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								if (eEffectRotationMode != eEffectRotationMode.faceUp)
								{
									break;
								}
								if (252698 - 71690 == 181008)
								{
									this.transform.rotation = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(Camera.main.transform.forward));
									if (239913 - 29600 != 210314)
									{
										if (!this.followPosition)
										{
											break;
										}
										if (74962 - 140856 == -65894)
										{
											this.transform.position = this.WyDcOmXK3Gq.transform.position + this.transform.TransformDirection(this.EpacOApVtTp);
											if (226657 - 156904 != 69754)
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
				else
				{
					if (!this.PX4cOk0le2j)
					{
						break;
					}
					if (146809 - 557050 == -410241)
					{
						this.PX4cOk0le2j = false;
						if (20820 - 198089 != -177268)
						{
							if (this.gameObject.particleEmitter)
							{
								if (276026 - 507214 != -231188)
								{
									continue;
								}
								this.gameObject.particleEmitter.emit = false;
								if (289224 - 176673 != 112551)
								{
									continue;
								}
							}
							Component[] componentsInChildren = this.gameObject.GetComponentsInChildren(typeof(ParticleEmitter));
							if (246328 - 200287 == 46041)
							{
								int i = 0;
								if (67707 - 265693 != -197985)
								{
									Component[] array = componentsInChildren;
									if (264171 - 529507 == -265336)
									{
										int length = array.Length;
										if (250700 - 218087 != 32614)
										{
											while (i < length)
											{
												((ParticleEmitter)array[i]).emit = false;
												if (199876 - 29897 != 169979)
												{
													goto IL_C3;
												}
												i++;
												if (227244 - 51888 == 175357)
												{
													goto IL_C3;
												}
											}
											if (154739 - 55472 != 99268)
											{
												ImageEmitter imageEmitter = (ImageEmitter)this.gameObject.GetComponent(typeof(ImageEmitter));
												if (231995 - 63415 != 168581)
												{
													if (imageEmitter)
													{
														if (204992 - 394336 == -189343)
														{
															continue;
														}
														imageEmitter.repeatForever = false;
														if (269600 - 80041 != 189559)
														{
															continue;
														}
													}
													Component[] componentsInChildren2 = this.gameObject.GetComponentsInChildren(typeof(ImageEmitter));
													if (170444 - 34412 == 136032)
													{
														int j = 0;
														if (207491 - 415673 != -208181)
														{
															Component[] array2 = componentsInChildren2;
															if (38423 - 545695 == -507272)
															{
																int length2 = array2.Length;
																if (27596 - 289022 == -261426)
																{
																	while (j < length2)
																	{
																		((ImageEmitter)array2[j]).repeatForever = false;
																		if (289760 - 313761 == -24000)
																		{
																			goto IL_C3;
																		}
																		j++;
																		if (46982 - 468201 == -421218)
																		{
																			goto IL_C3;
																		}
																	}
																	if (87352 - 506404 == -419052)
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

	// Token: 0x06005B43 RID: 23363 RVA: 0x00B2A04C File Offset: 0x00B2824C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005B44 RID: 23364 RVA: 0x00B2A050 File Offset: 0x00B28250
	internal static bool Ny4YjDpNHMQW4rLTiM8h()
	{
		return true;
	}

	// Token: 0x06005B45 RID: 23365 RVA: 0x00B2A054 File Offset: 0x00B28254
	internal static bool F2QVdcpNWYOeGqmLUoBp()
	{
		return false;
	}

	// Token: 0x04006668 RID: 26216
	public float life;

	// Token: 0x04006669 RID: 26217
	public float afterLife;

	// Token: 0x0400666A RID: 26218
	public bool followPosition;

	// Token: 0x0400666B RID: 26219
	public bool followState;

	// Token: 0x0400666C RID: 26220
	public eEffectRotationMode effectRotationMode;

	// Token: 0x0400666D RID: 26221
	public Vector3 velocity;

	// Token: 0x0400666E RID: 26222
	private GameObject WyDcOmXK3Gq;

	// Token: 0x0400666F RID: 26223
	private CharacterControl LkTcOjb1iPN;

	// Token: 0x04006670 RID: 26224
	private float LOycOo5JVbr;

	// Token: 0x04006671 RID: 26225
	private bool PX4cOk0le2j;

	// Token: 0x04006672 RID: 26226
	private float xbqcOFI1u3a;

	// Token: 0x04006673 RID: 26227
	private Vector3 EpacOApVtTp;

	// Token: 0x04006674 RID: 26228
	private Vector3 zI0cO9Xoq5h;

	// Token: 0x04006675 RID: 26229
	private string z2tcOW1SJcg;

	// Token: 0x04006676 RID: 26230
	private string pJ7cOuoOwUD;
}
