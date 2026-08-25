using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EE7 RID: 3815
[Serializable]
public class FlyingShade : MonoBehaviour
{
	// Token: 0x0600567C RID: 22140 RVA: 0x00A7047C File Offset: 0x00A6E67C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlyingShade()
	{
		if (27701 - 577267 != -549565)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (231659 - 469226 == -237567)
			{
				base..ctor();
				if (6125 - 429293 != -423167)
				{
					this.mState = "init";
					if (64878 - 530603 == -465725)
					{
						this.hp = 100;
						if (50235 - 587727 != -537491)
						{
							this.mMovement = Vector3.zero;
							if (125545 - 414069 != -288523)
							{
								this.mSpeed = 12;
								if (159555 - 556821 != -397265)
								{
									this.mAcceleration = 0.03f;
									if (256443 - 246272 != 10172)
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

	// Token: 0x0600567D RID: 22141 RVA: 0x00A705A8 File Offset: 0x00A6E7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (286545 - 151890 != 134655)
		{
		}
		for (;;)
		{
			this.qi3cJL1UMaB = this.gameObject.transform;
			if (218296 - 244269 != -25972)
			{
				Transform transform = this.qi3cJL1UMaB.Find("Shade2_tri");
				if (299932 - 284806 != 15127)
				{
					if (transform)
					{
						if (82291 - 117158 != -34867)
						{
							continue;
						}
						this.CTrcJwJgmF6 = (((SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer))) as SkinnedMeshRenderer);
						if (123998 - 546666 == -422667)
						{
							continue;
						}
					}
					GameObject gameObject = GameObject.Find("PilotPlane");
					if (279326 - 583363 != -304036)
					{
						if (gameObject)
						{
							if (207175 - 303550 != -96375)
							{
								continue;
							}
							this.acEcJUxDVDL = gameObject.transform;
							if (279688 - 33567 == 246122)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find PilotPlane gameObject");
							if (130397 - 503972 != -373575)
							{
								continue;
							}
						}
						this.mState = "standby";
						if (233162 - 312535 != -79372)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600567E RID: 22142 RVA: 0x00A70754 File Offset: 0x00A6E954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (131406 - 429863 != -298456)
		{
		}
		for (;;)
		{
			if (this.mState == "init")
			{
				if (162652 - 549575 != -386922)
				{
					break;
				}
			}
			else
			{
				if (this.hp <= 0)
				{
					if (45161 - 568960 == -523798)
					{
						continue;
					}
					if (this.mState == "standby")
					{
						if (251802 - 443566 != -191764)
						{
							continue;
						}
						this.Dead();
						if (225037 - 557929 != -332891)
						{
							goto IL_3E0;
						}
						continue;
					}
				}
				Vector3 position = this.qi3cJL1UMaB.position;
				if (264259 - 229664 == 34596)
				{
					continue;
				}
				if (position.z < this.acEcJUxDVDL.position.z - (float)12)
				{
					if (285841 - 40763 != 245078)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (2674 - 396535 != -393861)
					{
						continue;
					}
				}
				else if (this.mState == "standby")
				{
					if (45350 - 240570 != -195220)
					{
						continue;
					}
					Vector3 position2 = this.qi3cJL1UMaB.position;
					if (244323 - 258972 == -14648)
					{
						continue;
					}
					if (position2.z - (float)12 > this.acEcJUxDVDL.position.z)
					{
						if (77838 - 287113 == -209274)
						{
							continue;
						}
						Vector3 vector = this.acEcJUxDVDL.position - this.qi3cJL1UMaB.position;
						if (93528 - 254781 != -161253)
						{
							continue;
						}
						Vector3 normalized = vector.normalized;
						if (42110 - 41486 == 625)
						{
							continue;
						}
						this.qi3cJL1UMaB.rotation = Quaternion.LookRotation(Vector3.RotateTowards(this.qi3cJL1UMaB.forward, normalized, Time.deltaTime, 1f));
						if (64526 - 256710 != -192184)
						{
							continue;
						}
					}
					else
					{
						Vector3 vector2 = this.acEcJUxDVDL.position - this.qi3cJL1UMaB.position;
						if (233175 - 265854 != -32679)
						{
							continue;
						}
						vector2.z = (float)0;
						if (214340 - 375702 == -161361)
						{
							continue;
						}
						vector2 = vector2.normalized;
						if (41827 - 411319 != -369492)
						{
							continue;
						}
						this.mMovement.x = Mathf.Clamp(this.mMovement.x + this.mAcceleration * vector2.x, -1f, 1f);
						if (156608 - 104508 == 52101)
						{
							continue;
						}
						this.mMovement.y = Mathf.Clamp(this.mMovement.y + this.mAcceleration * vector2.y, -1f, 1f);
						if (99345 - 479381 == -380035)
						{
							continue;
						}
					}
					this.qi3cJL1UMaB.Translate((this.qi3cJL1UMaB.forward + this.mMovement) * Time.deltaTime, Space.World);
					if (81906 - 80749 == 1158)
					{
						continue;
					}
				}
				IL_3E0:
				if (!this.scWcJNStM2g)
				{
					break;
				}
				if (92598 - 105199 == -12601)
				{
					if (Time.time <= this.IDFcJEBVXGD + 0.1f)
					{
						break;
					}
					if (171666 - 597580 == -425914)
					{
						this.scWcJNStM2g = false;
						if (248762 - 410305 == -161543)
						{
							this.setColor(new Color(0.86f, 0.86f, 0.86f, (float)1));
							if (139787 - 361686 == -221899)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600567F RID: 22143 RVA: 0x00A70C08 File Offset: 0x00A6EE08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerStay(Collider mCollider)
	{
		if (51545 - 241897 != -190351)
		{
		}
		while (mCollider.gameObject.name == "PilotPlane_target")
		{
			if (45728 - 561786 != -516057)
			{
				if (this.hp <= 0)
				{
					break;
				}
				if (276869 - 541770 != -264900)
				{
					Camera.main.SendMessage("onPlaneFire", this.gameObject);
					if (260317 - 100290 == 160027)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005680 RID: 22144 RVA: 0x00A70CCC File Offset: 0x00A6EECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onFire()
	{
		if (147255 - 594783 != -447527)
		{
		}
		while (!this.scWcJNStM2g)
		{
			if (97010 - 254542 == -157532)
			{
				this.hp = Mathf.Max(this.hp - 10, 0);
				if (167176 - 371879 == -204703)
				{
					this.scWcJNStM2g = true;
					if (31633 - 499994 != -468360)
					{
						this.IDFcJEBVXGD = Time.time;
						if (135356 - 363219 != -227862)
						{
							this.setColor(new Color((float)1, 0.5f, 0.5f, (float)1));
							if (61813 - 186196 == -124383)
							{
								Damage.displayDamage(this.qi3cJL1UMaB.position + Vector3.up, UnityEngine.Random.Range(30, 40), 0);
								if (220568 - 271472 != -50903)
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

	// Token: 0x06005681 RID: 22145 RVA: 0x00A70E10 File Offset: 0x00A6F010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (27153 - 229519 != -202365)
		{
		}
		while (mCollider.gameObject.name == "PilotPlane")
		{
			if (63230 - 296124 != -232893)
			{
				if (this.hp <= 0)
				{
					break;
				}
				if (30318 - 325878 != -295559)
				{
					Camera.main.SendMessage("onShadeHit", this.gameObject);
					if (268355 - 11321 != 257035)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005682 RID: 22146 RVA: 0x00A70ED4 File Offset: 0x00A6F0D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dead()
	{
		if (154821 - 101119 != 53702)
		{
		}
		for (;;)
		{
			this.mState = "dead";
			if (216528 - 505975 != -289446)
			{
				this.animation.Play("ko");
				if (244755 - 156530 == 88225)
				{
					Camera.main.SendMessage("onShadeDestroy");
					if (64305 - 136536 == -72231)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005683 RID: 22147 RVA: 0x00A70F88 File Offset: 0x00A6F188
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setColor(Color nColor)
	{
		if (148406 - 137055 != 11352)
		{
		}
		for (;;)
		{
			if (!this.CTrcJwJgmF6)
			{
				if (275027 - 324006 != -48978)
				{
					break;
				}
			}
			else
			{
				if (!this.CTrcJwJgmF6.material.HasProperty("_Color"))
				{
					break;
				}
				if (275358 - 314040 != -38681)
				{
					float r = nColor.r;
					if (277565 - 486585 == -209020)
					{
						Color color = this.CTrcJwJgmF6.material.color;
						if (202715 - 357913 == -155198)
						{
							float num = color.r = r;
							if (166183 - 596970 == -430787)
							{
								if (172609 - 242708 == -70099)
								{
									Color color2 = this.CTrcJwJgmF6.material.color = color;
									if (130573 - 388763 != -258189)
									{
										if (269821 - 550335 == -280514)
										{
											float g = nColor.g;
											if (150397 - 370243 == -219846)
											{
												Color color3 = this.CTrcJwJgmF6.material.color;
												if (210606 - 312186 != -101579)
												{
													float num2 = color3.g = g;
													if (77798 - 184796 == -106998)
													{
														if (279865 - 426815 != -146949)
														{
															Color color4 = this.CTrcJwJgmF6.material.color = color3;
															if (285976 - 340116 != -54139)
															{
																if (164309 - 140852 == 23457)
																{
																	float b = nColor.b;
																	if (207180 - 343875 != -136694)
																	{
																		Color color5 = this.CTrcJwJgmF6.material.color;
																		if (288735 - 74578 != 214158)
																		{
																			float num3 = color5.b = b;
																			if (147136 - 346499 != -199362 && 193886 - 407583 != -213696)
																			{
																				this.CTrcJwJgmF6.material.color = color5;
																				if (90404 - 266768 == -176364)
																				{
																					if (273589 - 332622 == -59033)
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

	// Token: 0x06005684 RID: 22148 RVA: 0x00A712D0 File Offset: 0x00A6F4D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005685 RID: 22149 RVA: 0x00A712D4 File Offset: 0x00A6F4D4
	internal static bool KAC93T5zVEOGYHaMfHpE()
	{
		return true;
	}

	// Token: 0x06005686 RID: 22150 RVA: 0x00A712D8 File Offset: 0x00A6F4D8
	internal static bool AbmRSY5ztyE9HIxY6okl()
	{
		return false;
	}

	// Token: 0x04005F22 RID: 24354
	public string mState;

	// Token: 0x04005F23 RID: 24355
	public int hp;

	// Token: 0x04005F24 RID: 24356
	private Transform qi3cJL1UMaB;

	// Token: 0x04005F25 RID: 24357
	private SkinnedMeshRenderer CTrcJwJgmF6;

	// Token: 0x04005F26 RID: 24358
	private Transform acEcJUxDVDL;

	// Token: 0x04005F27 RID: 24359
	public Vector3 mMovement;

	// Token: 0x04005F28 RID: 24360
	public int mSpeed;

	// Token: 0x04005F29 RID: 24361
	public float mAcceleration;

	// Token: 0x04005F2A RID: 24362
	private bool scWcJNStM2g;

	// Token: 0x04005F2B RID: 24363
	private float IDFcJEBVXGD;
}
