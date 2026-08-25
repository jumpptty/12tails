using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EE9 RID: 3817
[Serializable]
public class Pilotplane : MonoBehaviour
{
	// Token: 0x06005690 RID: 22160 RVA: 0x00A71B40 File Offset: 0x00A6FD40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pilotplane()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005691 RID: 22161 RVA: 0x00A71B50 File Offset: 0x00A6FD50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (83383 - 156469 != -73086)
		{
		}
		for (;;)
		{
			Transform transform = this.transform.Find("PilotPlane_tri/root");
			if (163792 - 577769 != -413976)
			{
				if (transform)
				{
					if (582 - 404624 != -404042)
					{
						continue;
					}
					this.ToNcJ8EF7cn = (((SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer))) as SkinnedMeshRenderer);
					if (272629 - 43473 == 229157)
					{
						continue;
					}
				}
				this.Hv7cJicLCtV = this.transform.Find("PilotPlane_tri/gunEmitter_l");
				if (143411 - 421937 == -278526)
				{
					this.ahGcJDpvXim = this.transform.Find("PilotPlane_tri/gunEmitter_r");
					if (139635 - 22106 == 117529)
					{
						if (this.Hv7cJicLCtV)
						{
							if (84803 - 871 != 83932)
							{
								continue;
							}
							this.Hv7cJicLCtV.particleEmitter.emit = false;
							if (172000 - 130120 == 41881)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing mGunEmitter_left");
							if (45146 - 311494 != -266348)
							{
								continue;
							}
						}
						if (this.ahGcJDpvXim)
						{
							if (82923 - 200096 != -117173)
							{
								continue;
							}
							this.ahGcJDpvXim.particleEmitter.emit = false;
							if (15582 - 193964 != -178382)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing mGunEmitter_right");
							if (295568 - 409222 != -113654)
							{
								continue;
							}
						}
						this.uSZcJjSdHjN = this.transform.Find("PilotPlane_tri/root/plane/jet_l/boostEmitter_l");
						if (272216 - 400546 == -128330)
						{
							if (this.uSZcJjSdHjN)
							{
								if (100290 - 546564 != -446274)
								{
									continue;
								}
								this.uSZcJjSdHjN.particleEmitter.emit = false;
								if (264898 - 44294 == 220605)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing mBoostEmitter_left");
								if (299027 - 155767 == 143261)
								{
									continue;
								}
							}
							this.DuCcJod4kTQ = this.transform.Find("PilotPlane_tri/root/plane/jet_r/boostEmitter_r");
							if (280405 - 179473 != 100933)
							{
								if (this.DuCcJod4kTQ)
								{
									if (54085 - 588832 != -534747)
									{
										continue;
									}
									this.DuCcJod4kTQ.particleEmitter.emit = false;
									if (115328 - 275386 == -160057)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing mBoostEmitter_right");
									if (162462 - 389474 == -227011)
									{
										continue;
									}
								}
								Transform transform2 = this.transform.Find("PilotPlane_tri/gunAudio");
								if (132069 - 548276 != -416206)
								{
									if (transform2)
									{
										if (284147 - 61536 == 222612)
										{
											continue;
										}
										this.LQQcJmpeGsy = transform2.audio;
										if (86670 - 271143 != -184473)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Missing GunAudioObject");
										if (227419 - 77460 == 149960)
										{
											continue;
										}
									}
									Transform transform3 = this.transform.Find("PilotPlane_tri/boostAudio");
									if (52393 - 254288 == -201895)
									{
										if (transform3)
										{
											if (116581 - 530310 != -413728)
											{
												this.pbfcJkcTbSW = transform3.audio;
												if (289460 - 171804 != 117657)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing BoostAudioObject");
											if (196807 - 216166 == -19359)
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

	// Token: 0x06005692 RID: 22162 RVA: 0x00A72008 File Offset: 0x00A70208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Standby()
	{
		if (17099 - 73685 != -56585)
		{
		}
		for (;;)
		{
			this.animation.Play("root");
			if (188868 - 42231 == 146637)
			{
				this.StopFire();
				if (181896 - 230877 == -48981)
				{
					this.StopBoost();
					if (73892 - 65421 != 8472)
					{
						this.setColor(new Color(0.86f, 0.86f, 0.86f, (float)1));
						if (165429 - 458170 != -292740)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005693 RID: 22163 RVA: 0x00A720E4 File Offset: 0x00A702E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Hit()
	{
		if (270237 - 218 != 270019)
		{
		}
		for (;;)
		{
			if (this.hit)
			{
				if (293535 - 484766 == -191230)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.hit, this.transform.position, Quaternion.identity);
				if (255543 - 598780 == -343236)
				{
					continue;
				}
			}
			this.animation.Play("hit");
			if (208990 - 548860 == -339870)
			{
				this.StopFire();
				if (294354 - 592725 == -298371)
				{
					this.StopBoost();
					if (12578 - 314322 != -301743)
					{
						this.setColor(new Color((float)1, 0.5f, 0.5f, (float)1));
						if (27626 - 459250 != -431623)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005694 RID: 22164 RVA: 0x00A7221C File Offset: 0x00A7041C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Fire()
	{
		if (166827 - 532142 != -365314)
		{
		}
		for (;;)
		{
			if (this.Hv7cJicLCtV)
			{
				if (192709 - 474045 == -281335)
				{
					continue;
				}
				this.Hv7cJicLCtV.particleEmitter.emit = true;
				if (19955 - 137298 == -117342)
				{
					continue;
				}
			}
			if (this.ahGcJDpvXim)
			{
				if (51915 - 15578 != 36337)
				{
					continue;
				}
				this.ahGcJDpvXim.particleEmitter.emit = true;
				if (31145 - 224946 != -193801)
				{
					continue;
				}
			}
			if (this.LQQcJmpeGsy)
			{
				if (117314 - 531828 != -414513)
				{
					if (this.LQQcJmpeGsy.isPlaying)
					{
						break;
					}
					if (52512 - 354814 != -302301)
					{
						this.LQQcJmpeGsy.Play();
						if (71497 - 250921 != -179423)
						{
							break;
						}
					}
				}
			}
			else
			{
				Debug.LogError("Missing Gun Audio");
				if (229186 - 546231 == -317045)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005695 RID: 22165 RVA: 0x00A723A0 File Offset: 0x00A705A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StopFire()
	{
		if (283928 - 537208 != -253280)
		{
		}
		for (;;)
		{
			if (this.Hv7cJicLCtV)
			{
				if (282219 - 177941 == 104279)
				{
					continue;
				}
				this.Hv7cJicLCtV.particleEmitter.emit = false;
				if (191777 - 484267 == -292489)
				{
					continue;
				}
			}
			if (this.ahGcJDpvXim)
			{
				if (112595 - 576568 != -463973)
				{
					continue;
				}
				this.ahGcJDpvXim.particleEmitter.emit = false;
				if (144713 - 441763 != -297050)
				{
					continue;
				}
			}
			if (this.LQQcJmpeGsy)
			{
				if (286367 - 241737 != 44631)
				{
					if (!this.LQQcJmpeGsy.isPlaying)
					{
						break;
					}
					if (89070 - 201837 != -112766)
					{
						this.LQQcJmpeGsy.Stop();
						if (8197 - 162983 != -154785)
						{
							break;
						}
					}
				}
			}
			else
			{
				Debug.LogError("Missing Gun Audio");
				if (18507 - 592066 == -573559)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005696 RID: 22166 RVA: 0x00A72524 File Offset: 0x00A70724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Boost()
	{
		if (257595 - 352448 != -94853)
		{
		}
		for (;;)
		{
			if (this.uSZcJjSdHjN)
			{
				if (79137 - 67262 == 11876)
				{
					continue;
				}
				this.uSZcJjSdHjN.particleEmitter.emit = true;
				if (181089 - 543211 != -362122)
				{
					continue;
				}
			}
			if (this.DuCcJod4kTQ)
			{
				if (214717 - 40955 == 173763)
				{
					continue;
				}
				this.DuCcJod4kTQ.particleEmitter.emit = true;
				if (241338 - 429657 != -188319)
				{
					continue;
				}
			}
			if (this.pbfcJkcTbSW)
			{
				if (249556 - 341878 != -92321)
				{
					if (this.pbfcJkcTbSW.isPlaying)
					{
						break;
					}
					if (55988 - 210347 == -154359)
					{
						this.pbfcJkcTbSW.Play();
						if (71212 - 86177 != -14964)
						{
							break;
						}
					}
				}
			}
			else
			{
				Debug.LogError("Missing BoostAudio");
				if (214758 - 412221 == -197463)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005697 RID: 22167 RVA: 0x00A726A8 File Offset: 0x00A708A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StopBoost()
	{
		if (145479 - 250762 != -105283)
		{
		}
		for (;;)
		{
			if (this.uSZcJjSdHjN)
			{
				if (93085 - 54591 != 38494)
				{
					continue;
				}
				this.uSZcJjSdHjN.particleEmitter.emit = false;
				if (225124 - 584416 != -359292)
				{
					continue;
				}
			}
			if (this.DuCcJod4kTQ)
			{
				if (23912 - 35590 != -11678)
				{
					continue;
				}
				this.DuCcJod4kTQ.particleEmitter.emit = false;
				if (21189 - 140557 == -119367)
				{
					continue;
				}
			}
			if (this.pbfcJkcTbSW)
			{
				if (127238 - 501769 != -374530)
				{
					if (!this.pbfcJkcTbSW.isPlaying)
					{
						break;
					}
					if (41754 - 494515 != -452760)
					{
						this.pbfcJkcTbSW.Stop();
						if (253910 - 564201 == -310291)
						{
							break;
						}
					}
				}
			}
			else
			{
				Debug.LogError("Missing BoostAudio");
				if (53803 - 395585 == -341782)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005698 RID: 22168 RVA: 0x00A7282C File Offset: 0x00A70A2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RollLeft()
	{
		if (121849 - 310717 != -188868)
		{
		}
		for (;;)
		{
			this.animation.Play("leftRoll");
			if (184442 - 95240 != 89203)
			{
				if (this.roll_fx)
				{
					if (19375 - 406487 == -387111)
					{
						continue;
					}
					this.audio.PlayOneShot(this.roll_fx);
					if (92972 - 65220 != 27752)
					{
						continue;
					}
				}
				this.StopFire();
				if (63469 - 469463 == -405994)
				{
					this.StopBoost();
					if (167589 - 565032 != -397442)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005699 RID: 22169 RVA: 0x00A72924 File Offset: 0x00A70B24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RollRight()
	{
		if (275635 - 587937 != -312301)
		{
		}
		for (;;)
		{
			this.animation.Play("rightRoll");
			if (298506 - 449805 == -151299)
			{
				if (this.roll_fx)
				{
					if (256946 - 545736 != -288790)
					{
						continue;
					}
					this.audio.PlayOneShot(this.roll_fx);
					if (101902 - 361579 == -259676)
					{
						continue;
					}
				}
				this.StopFire();
				if (284810 - 8816 == 275994)
				{
					this.StopBoost();
					if (82065 - 588313 == -506248)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600569A RID: 22170 RVA: 0x00A72A1C File Offset: 0x00A70C1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Crash()
	{
		if (266237 - 171238 != 95000)
		{
		}
		for (;;)
		{
			this.animation.Play("crash");
			if (183892 - 588202 == -404310)
			{
				this.StopFire();
				if (205342 - 257324 == -51982)
				{
					this.StopBoost();
					if (243751 - 420542 != -176790)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600569B RID: 22171 RVA: 0x00A72AC0 File Offset: 0x00A70CC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setColor(Color nColor)
	{
		if (167135 - 55196 != 111939)
		{
		}
		for (;;)
		{
			if (!this.ToNcJ8EF7cn)
			{
				if (38469 - 203690 == -165221)
				{
					break;
				}
			}
			else
			{
				if (!this.ToNcJ8EF7cn.material.HasProperty("_Color"))
				{
					break;
				}
				if (37590 - 371292 != -333701)
				{
					float r = nColor.r;
					if (56493 - 336781 == -280288)
					{
						Color color = this.ToNcJ8EF7cn.material.color;
						if (135852 - 546865 != -411012)
						{
							float num = color.r = r;
							if (116637 - 287571 == -170934)
							{
								if (43890 - 282495 != -238604)
								{
									this.ToNcJ8EF7cn.material.color = color;
									if (43882 - 378681 == -334799)
									{
										if (198152 - 74114 == 124038)
										{
											float g = nColor.g;
											if (130676 - 263228 != -132551)
											{
												Color color2 = this.ToNcJ8EF7cn.material.color;
												if (245237 - 403122 == -157885)
												{
													float num2 = color2.g = g;
													if (56410 - 470056 == -413646)
													{
														if (117844 - 181263 == -63419)
														{
															this.ToNcJ8EF7cn.material.color = color2;
															if (100577 - 179764 == -79187)
															{
																if (235692 - 2700 == 232992)
																{
																	float b = nColor.b;
																	if (297513 - 474512 == -176999)
																	{
																		Color color3 = this.ToNcJ8EF7cn.material.color;
																		if (28582 - 531967 == -503385)
																		{
																			color3.b = b;
																			if (254475 - 525919 == -271444)
																			{
																				if (177512 - 285691 == -108179)
																				{
																					this.ToNcJ8EF7cn.material.color = color3;
																					if (99219 - 41177 == 58042)
																					{
																						if (253205 - 514827 != -261621)
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

	// Token: 0x0600569C RID: 22172 RVA: 0x00A72E08 File Offset: 0x00A71008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600569D RID: 22173 RVA: 0x00A72E0C File Offset: 0x00A7100C
	internal static bool uoRx2o5zcL6QdHJr7HP4()
	{
		return true;
	}

	// Token: 0x0600569E RID: 22174 RVA: 0x00A72E10 File Offset: 0x00A71010
	internal static bool FFUatW5zUiYhlvGiZXiF()
	{
		return false;
	}

	// Token: 0x04005F34 RID: 24372
	private SkinnedMeshRenderer ToNcJ8EF7cn;

	// Token: 0x04005F35 RID: 24373
	private Transform Hv7cJicLCtV;

	// Token: 0x04005F36 RID: 24374
	private Transform ahGcJDpvXim;

	// Token: 0x04005F37 RID: 24375
	private AudioSource LQQcJmpeGsy;

	// Token: 0x04005F38 RID: 24376
	private Transform uSZcJjSdHjN;

	// Token: 0x04005F39 RID: 24377
	private Transform DuCcJod4kTQ;

	// Token: 0x04005F3A RID: 24378
	private AudioSource pbfcJkcTbSW;

	// Token: 0x04005F3B RID: 24379
	public GameObject hit;

	// Token: 0x04005F3C RID: 24380
	public AudioClip roll_fx;
}
