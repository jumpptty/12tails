using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C07 RID: 3079
[Serializable]
public class Deadcamel_AI : MonoBehaviour
{
	// Token: 0x060044C2 RID: 17602 RVA: 0x0089F800 File Offset: 0x0089DA00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Deadcamel_AI()
	{
		if (122883 - 212698 != -89814)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (45552 - 407087 == -361535)
			{
				base..ctor();
				if (125955 - 423012 == -297057)
				{
					this.AI_state = "none";
					if (223024 - 36601 == 186423)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060044C3 RID: 17603 RVA: 0x0089F89C File Offset: 0x0089DA9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.srLhsNxE0C = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.wnwhHeVVq6 = (Deadcamel)this.GetComponent(typeof(Deadcamel));
	}

	// Token: 0x060044C4 RID: 17604 RVA: 0x0089F8D4 File Offset: 0x0089DAD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (154271 - 265384 != -111113)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (291900 - 192388 != 99512)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (13369 - 166349 != -152980)
				{
					continue;
				}
			}
			if (this.srLhsNxE0C.isControlled)
			{
				break;
			}
			if (27381 - 209739 == -182358)
			{
				this.AIControl();
				if (120417 - 370234 == -249817)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060044C5 RID: 17605 RVA: 0x0089F9A0 File Offset: 0x0089DBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (199389 - 424351 != -224961)
		{
		}
		for (;;)
		{
			this.fLxhZXJvVp = (float)0;
			if (173266 - 39568 == 133698)
			{
				if (this.srLhsNxE0C.isMine)
				{
					if (178069 - 489344 == -311275)
					{
						if (this.srLhsNxE0C.actionState != "standby")
						{
							if (179753 - 340387 != -160634)
							{
								continue;
							}
							if (this.srLhsNxE0C.actionState != "run")
							{
								if (4060 - 318679 != -314618)
								{
									break;
								}
								continue;
							}
						}
						if (!this.srLhsNxE0C.isAlert)
						{
							if (113642 - 501080 == -387438)
							{
								this.AI_idle(3f, 1f);
								if (194697 - 27068 == 167629)
								{
									this.AI_resetTimer();
									if (253180 - 218849 == 34331)
									{
										this.AI_visionCheck();
										if (12125 - 418192 != -406066)
										{
											if (!this.srLhsNxE0C.myAttackTarget)
											{
												break;
											}
											if (85275 - 313884 == -228609)
											{
												this.srLhsNxE0C.isAlert = true;
												if (199651 - 463858 != -264206)
												{
													this.z5Vh7QE44W = Time.time;
													if (18608 - 190860 != -172251)
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
							this.AI_selectTarget(1f, (float)0);
							if (211868 - 419617 == -207749)
							{
								this.AI_idle(1f, 1f);
								if (158737 - 244882 == -86145)
								{
									this.AI_attack(6f, 1f);
									if (118273 - 166603 == -48330)
									{
										this.AI_resetTimer();
										if (187137 - 343458 == -156321)
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
					if (this.srLhsNxE0C.actionState != "standby")
					{
						if (144159 - 231157 == -86997)
						{
							continue;
						}
						if (this.srLhsNxE0C.actionState != "run")
						{
							if (130647 - 123340 != 7307)
							{
								continue;
							}
							break;
						}
					}
					if (this.srLhsNxE0C.nSpeed != (float)0)
					{
						if (1676 - 328523 == -326846)
						{
							continue;
						}
						if (this.srLhsNxE0C.nPosition != this.srLhsNxE0C.oPosition)
						{
							if (68033 - 174701 != -106668)
							{
								continue;
							}
							Vector3 a = this.srLhsNxE0C.nPosition + 0.1f * this.srLhsNxE0C.runSpeed * this.srLhsNxE0C.nDirection;
							if (263093 - 402582 != -139489)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (239241 - 79238 != 160003)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (164936 - 283161 != -118225)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (3252 - 283481 == -280228)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (60303 - 10817 != 49486)
							{
								continue;
							}
							if (magnitude > this.srLhsNxE0C.runSpeed)
							{
								if (47786 - 416401 != -368615)
								{
									continue;
								}
								this.transform.position = this.srLhsNxE0C.nPosition;
								if (39747 - 113561 != -73813)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.srLhsNxE0C.runSpeed)
							{
								if (188806 - 502647 != -313841)
								{
									continue;
								}
								this.srLhsNxE0C.moveSpeed = Mathf.Lerp(this.srLhsNxE0C.moveSpeed, 1.1f * this.srLhsNxE0C.runSpeed, (float)10 * Time.deltaTime);
								if (40315 - 260517 == -220201)
								{
									continue;
								}
								this.srLhsNxE0C.vDirection = normalized;
								if (239644 - 503463 == -263818)
								{
									continue;
								}
								this.srLhsNxE0C.vMovement = normalized;
								if (121609 - 195320 != -73711)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (60050 - 286509 != -226459)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (216761 - 284857 != -68096)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (65276 - 182524 != -117248)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (281167 - 166287 == 114881)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (216232 - 133399 != 82834)
								{
									break;
								}
								continue;
							}
							else
							{
								this.srLhsNxE0C.moveSpeed = Mathf.Lerp(this.srLhsNxE0C.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (149450 - 526445 != -376995)
								{
									continue;
								}
								this.srLhsNxE0C.vDirection = normalized;
								if (167422 - 487425 != -320003)
								{
									continue;
								}
								this.srLhsNxE0C.vMovement = normalized;
								if (273674 - 352203 != -78529)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (190327 - 7776 != 182551)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (27804 - 584080 != -556276)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.srLhsNxE0C.moveSpeed != (float)0)
					{
						if (164370 - 198454 != -34083)
						{
							Vector3 vector3 = global::Math.vFlat(this.srLhsNxE0C.nPosition - this.transform.position);
							if (241718 - 213258 != 28461)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (111464 - 415873 != -304408)
								{
									if (sqrMagnitude > this.srLhsNxE0C.runSpeed)
									{
										if (264539 - 189902 != 74638)
										{
											this.transform.position = this.srLhsNxE0C.nPosition;
											if (198602 - 382863 != -184260)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (147571 - 72708 == 74863)
										{
											if (sqrMagnitude > (float)1)
											{
												if (163132 - 364068 == -200935)
												{
													continue;
												}
												this.srLhsNxE0C.moveSpeed = Mathf.Lerp(this.srLhsNxE0C.moveSpeed, this.srLhsNxE0C.runSpeed, (float)10 * Time.deltaTime);
												if (152012 - 408487 != -256475)
												{
													continue;
												}
											}
											else
											{
												this.srLhsNxE0C.moveSpeed = Mathf.Lerp(this.srLhsNxE0C.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (104615 - 235752 != -131137)
												{
													continue;
												}
											}
											this.srLhsNxE0C.vMovement = vector3;
											if (230019 - 415234 == -185215)
											{
												this.srLhsNxE0C.vDirection = vector3;
												if (257929 - 212197 != 45733)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (249716 - 459410 == -209694)
													{
														this.animation.CrossFade("run", 0.2f);
														if (204276 - 452550 == -248274)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (27441 - 145523 != -118081)
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
										this.srLhsNxE0C.vMovement = vector3;
										if (211540 - 579860 != -368319)
										{
											this.srLhsNxE0C.moveSpeed = (float)0;
											if (52642 - 312032 != -259389)
											{
												this.transform.rotation = Quaternion.LookRotation(this.srLhsNxE0C.vDirection);
												if (65689 - 176742 != -111052)
												{
													this.animation.CrossFade("root", 0.2f);
													if (267413 - 420744 == -153331)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (41408 - 179882 == -138474)
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
					else
					{
						this.animation.CrossFade("root", 0.2f);
						if (215026 - 139894 == 75132)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (208334 - 553977 != -345642)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060044C6 RID: 17606 RVA: 0x008A04FC File Offset: 0x0089E6FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (270393 - 120442 != 149951)
		{
		}
		do
		{
			if (Time.time - this.z5Vh7QE44W >= this.fLxhZXJvVp)
			{
				if (9914 - 29251 != -19337)
				{
					continue;
				}
				if (Time.time - this.z5Vh7QE44W < this.fLxhZXJvVp + mTime)
				{
					if (14161 - 399437 == -385275)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (17556 - 407909 == -390352)
						{
							continue;
						}
						this.AI_state = "idle";
						if (108957 - 327258 == -218300)
						{
							continue;
						}
						this.z5Vh7QE44W -= UnityEngine.Random.Range((float)0, rTimer);
						if (206826 - 140625 == 66202)
						{
							continue;
						}
						this.srLhsNxE0C.vDirection = Vector3.zero;
						if (177341 - 469056 != -291715)
						{
							continue;
						}
						this.srLhsNxE0C.vMovement = this.transform.forward;
						if (149076 - 186207 != -37131)
						{
							continue;
						}
						this.srLhsNxE0C.actionState = "standby";
						if (288690 - 136906 != 151784)
						{
							continue;
						}
					}
					this.srLhsNxE0C.moveSpeed = Mathf.Lerp(this.srLhsNxE0C.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (79275 - 298591 != -219316)
					{
						continue;
					}
					if (this.srLhsNxE0C.moveSpeed < 0.1f * this.srLhsNxE0C.runSpeed)
					{
						if (115889 - 38091 == 77799)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (22791 - 192504 == -169712)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (243938 - 199391 == 44548)
						{
							continue;
						}
						this.srLhsNxE0C.moveSpeed = (float)0;
						if (20095 - 319190 == -299094)
						{
							continue;
						}
					}
				}
			}
			this.fLxhZXJvVp += mTime;
		}
		while (270114 - 509874 == -239759);
	}

	// Token: 0x060044C7 RID: 17607 RVA: 0x008A07C0 File Offset: 0x0089E9C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (90990 - 450440 != -359449)
		{
		}
		do
		{
			if (Time.time - this.z5Vh7QE44W >= this.fLxhZXJvVp)
			{
				if (278269 - 318925 != -40656)
				{
					continue;
				}
				if (Time.time - this.z5Vh7QE44W < this.fLxhZXJvVp + mTime)
				{
					if (36178 - 199828 != -163650)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (252477 - 113966 == 138512)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (227784 - 300756 == -72971)
						{
							continue;
						}
						this.z5Vh7QE44W -= UnityEngine.Random.Range((float)0, rTimer);
						if (284952 - 120767 != 164185)
						{
							continue;
						}
						this.srLhsNxE0C.vDirection = this.srLhsNxE0C.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (22479 - 392322 == -369842)
						{
							continue;
						}
						this.srLhsNxE0C.vDirection.y = this.transform.position.y;
						if (250346 - 419316 != -168970)
						{
							continue;
						}
						this.srLhsNxE0C.vMovement = (this.srLhsNxE0C.vDirection - this.transform.position).normalized;
						if (116502 - 413999 == -297496)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.srLhsNxE0C.vMovement);
						if (253486 - 545170 == -291683)
						{
							continue;
						}
						this.srLhsNxE0C.actionState = "run";
						if (15165 - 383432 == -368266)
						{
							continue;
						}
						this.animation.Play("run");
						if (70469 - 427649 != -357180)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (119887 - 170831 != -50944)
						{
							continue;
						}
					}
					this.srLhsNxE0C.moveSpeed = Mathf.Lerp(this.srLhsNxE0C.moveSpeed, this.srLhsNxE0C.runSpeed, (float)4 * Time.deltaTime);
					if (112577 - 245185 == -132607)
					{
						continue;
					}
				}
			}
			this.fLxhZXJvVp += mTime;
		}
		while (162002 - 254647 == -92644);
	}

	// Token: 0x060044C8 RID: 17608 RVA: 0x008A0AC8 File Offset: 0x0089ECC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (200196 - 204571 != -4374)
		{
		}
		do
		{
			if (Time.time - this.z5Vh7QE44W >= this.fLxhZXJvVp)
			{
				if (254505 - 524322 != -269817)
				{
					continue;
				}
				if (Time.time - this.z5Vh7QE44W < this.fLxhZXJvVp + mTime)
				{
					if (197582 - 68599 != 128983)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (281549 - 328887 == -47337)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (237282 - 115265 != 122017)
						{
							continue;
						}
						this.z5Vh7QE44W = Time.time - mTime - this.fLxhZXJvVp;
						if (188352 - 420787 == -232434)
						{
							continue;
						}
						this.srLhsNxE0C.vDirection = Vector3.zero;
						if (91223 - 145593 != -54370)
						{
							continue;
						}
						this.srLhsNxE0C.vMovement = this.transform.forward;
						if (27611 - 365433 != -337822)
						{
							continue;
						}
						this.srLhsNxE0C.actionState = "standby";
						if (80342 - 109745 == -29402)
						{
							continue;
						}
						this.srLhsNxE0C.myAttackTarget = this.srLhsNxE0C.getHateTarget(5, 50);
						if (243792 - 557285 != -313493)
						{
							continue;
						}
						if (!this.srLhsNxE0C.myAttackTarget)
						{
							if (231590 - 222654 == 8937)
							{
								continue;
							}
							this.srLhsNxE0C.isAlert = false;
							if (89590 - 275782 != -186192)
							{
								continue;
							}
							this.z5Vh7QE44W = Time.time;
							if (125696 - 444355 != -318659)
							{
								continue;
							}
							this.srLhsNxE0C.myAttackTarget = null;
							if (13622 - 277304 != -263682)
							{
								continue;
							}
							this.srLhsNxE0C.mOriginalPosition = this.transform.position;
							if (108237 - 398212 != -289974)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.srLhsNxE0C.myAttackTarget;
							if (183033 - 90690 == 92344)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (47160 - 123937 != -76777)
							{
								continue;
							}
							if (!(characterControl == null))
							{
								if (200644 - 264920 != -64276)
								{
									continue;
								}
								if (characterControl.hp <= 0)
								{
									if (197240 - 448206 == -250965)
									{
										continue;
									}
								}
								else
								{
									this.srLhsNxE0C.vDirection = myAttackTarget.transform.position;
									if (3327 - 110026 == -106698)
									{
										continue;
									}
									this.srLhsNxE0C.vDirection.y = this.transform.position.y;
									if (224891 - 25392 == 199500)
									{
										continue;
									}
									this.srLhsNxE0C.vMovement = (this.srLhsNxE0C.vDirection - this.transform.position).normalized;
									if (7792 - 584422 != -576630)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(this.srLhsNxE0C.vMovement);
									if (55232 - 62334 != -7101)
									{
										goto IL_1F1;
									}
									continue;
								}
							}
							this.srLhsNxE0C.isAlert = false;
							if (241825 - 57116 != 184709)
							{
								continue;
							}
							this.z5Vh7QE44W = Time.time;
							if (203871 - 449148 == -245276)
							{
								continue;
							}
							this.srLhsNxE0C.myAttackTarget = null;
							if (274772 - 311303 == -36530)
							{
								continue;
							}
						}
					}
				}
			}
			IL_1F1:
			this.fLxhZXJvVp += mTime;
		}
		while (139461 - 198225 == -58763);
	}

	// Token: 0x060044C9 RID: 17609 RVA: 0x008A0F9C File Offset: 0x0089F19C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (115971 - 492121 != -376150)
		{
		}
		do
		{
			if (Time.time - this.z5Vh7QE44W >= this.fLxhZXJvVp)
			{
				if (147818 - 411220 != -263402)
				{
					continue;
				}
				if (Time.time - this.z5Vh7QE44W < this.fLxhZXJvVp + mTime)
				{
					if (87421 - 110479 != -23058)
					{
						continue;
					}
					if (!this.srLhsNxE0C.myAttackTarget)
					{
						if (132195 - 577312 == -445116)
						{
							continue;
						}
						this.z5Vh7QE44W = Time.time - mTime - this.fLxhZXJvVp;
						if (10544 - 30948 != -20404)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.srLhsNxE0C.myAttackTarget;
						if (210130 - 151513 == 58618)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (190665 - 257591 != -66926)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (173894 - 399024 == -225129)
						{
							continue;
						}
						if (this.srLhsNxE0C.sp >= 40)
						{
							if (232451 - 182319 != 50132)
							{
								continue;
							}
							if (this.srLhsNxE0C.isTimeOut("cAttack") == (float)0)
							{
								if (155934 - 367811 != -211877)
								{
									continue;
								}
								this.z5Vh7QE44W = Time.time - mTime - this.fLxhZXJvVp;
								if (6099 - 6884 != -785)
								{
									continue;
								}
								this.wnwhHeVVq6.StartCoroutine_Auto(this.wnwhHeVVq6.RPC_stoneFall(this.transform.position, vector, 0));
								if (79528 - 532171 != -452643)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (29529 - 417556 != -388027)
									{
										continue;
									}
									this.wnwhHeVVq6.ActionEvent("RPC_stoneFall", this.transform.position, vector, 0);
									if (86482 - 467085 == -380602)
									{
										continue;
									}
								}
								goto IL_7EB;
							}
						}
						if (num < (float)7)
						{
							if (125650 - 153734 == -28083)
							{
								continue;
							}
							Vector3 position = myAttackTarget.transform.position;
							if (12871 - 387082 != -374211)
							{
								continue;
							}
							if (position.y - this.transform.position.y >= (float)1)
							{
								if (34118 - 472066 == -437947)
								{
									continue;
								}
								if (this.srLhsNxE0C.isTimeOut("nAttack") == (float)0)
								{
									if (6071 - 569593 == -563521)
									{
										continue;
									}
									this.z5Vh7QE44W = Time.time - mTime - this.fLxhZXJvVp;
									if (248057 - 388081 == -140023)
									{
										continue;
									}
									this.wnwhHeVVq6.StartCoroutine_Auto(this.wnwhHeVVq6.RPC_nAttack2(this.transform.position, vector, 0));
									if (39597 - 364364 != -324766)
									{
										if (PhotonClient.IsInitialized())
										{
											if (200388 - 506296 != -305908)
											{
												continue;
											}
											this.wnwhHeVVq6.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
											if (11814 - 219467 != -207653)
											{
												continue;
											}
										}
										goto IL_7EB;
									}
									continue;
								}
							}
						}
						if (num < (float)3)
						{
							if (4395 - 412043 != -407648)
							{
								continue;
							}
							if (this.srLhsNxE0C.isTimeOut("nAttack") == (float)0)
							{
								if (4796 - 16373 != -11577)
								{
									continue;
								}
								this.z5Vh7QE44W = Time.time - mTime - this.fLxhZXJvVp;
								if (114778 - 513799 != -399021)
								{
									continue;
								}
								this.wnwhHeVVq6.StartCoroutine_Auto(this.wnwhHeVVq6.RPC_nAttack1(this.transform.position, vector, 0));
								if (240245 - 80128 != 160118)
								{
									if (PhotonClient.IsInitialized())
									{
										if (26058 - 484931 == -458872)
										{
											continue;
										}
										this.wnwhHeVVq6.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
										if (119534 - 350877 == -231342)
										{
											continue;
										}
									}
									goto IL_7EB;
								}
								continue;
							}
						}
						if (this.srLhsNxE0C.isTimeOut("nAttack") == (float)0)
						{
							if (282822 - 344019 == -61196)
							{
								continue;
							}
							this.AI_state = "attack";
							if (38756 - 252069 != -213313)
							{
								continue;
							}
							this.srLhsNxE0C.vDirection = myAttackTarget.transform.position;
							if (278653 - 224923 != 53730)
							{
								continue;
							}
							this.srLhsNxE0C.vDirection.y = this.transform.position.y;
							if (84085 - 558738 == -474652)
							{
								continue;
							}
							this.srLhsNxE0C.vMovement = (this.srLhsNxE0C.vDirection - this.transform.position).normalized;
							if (34898 - 218544 == -183645)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.srLhsNxE0C.vMovement);
							if (229918 - 537630 != -307712)
							{
								continue;
							}
							this.srLhsNxE0C.actionState = "run";
							if (177414 - 450296 == -272881)
							{
								continue;
							}
							this.animation.Play("run");
							if (123247 - 514247 == -390999)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (86748 - 291622 == -204873)
							{
								continue;
							}
							this.srLhsNxE0C.moveSpeed = Mathf.Lerp(this.srLhsNxE0C.moveSpeed, this.srLhsNxE0C.runSpeed, (float)4 * Time.deltaTime);
							if (92001 - 117072 != -25071)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (51399 - 273348 == -221948)
							{
								continue;
							}
							this.srLhsNxE0C.vDirection = myAttackTarget.transform.position;
							if (139014 - 449617 != -310603)
							{
								continue;
							}
							this.srLhsNxE0C.vDirection.y = this.transform.position.y;
							if (60365 - 161111 != -100746)
							{
								continue;
							}
							this.srLhsNxE0C.vMovement = (this.srLhsNxE0C.vDirection - this.transform.position).normalized;
							if (75282 - 248920 == -173637)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.srLhsNxE0C.vMovement);
							if (280415 - 155706 != 124709)
							{
								continue;
							}
							this.srLhsNxE0C.actionState = "standby";
							if (267702 - 165486 != 102216)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (130147 - 20031 == 110117)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (178569 - 334149 != -155580)
							{
								continue;
							}
							this.srLhsNxE0C.moveSpeed = Mathf.Lerp(this.srLhsNxE0C.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (231228 - 201045 != 30183)
							{
								continue;
							}
						}
					}
				}
			}
			IL_7EB:
			this.fLxhZXJvVp += mTime;
		}
		while (169894 - 488579 == -318684);
	}

	// Token: 0x060044CA RID: 17610 RVA: 0x008A1904 File Offset: 0x0089FB04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (42790 - 424527 != -381736)
		{
		}
		while (Time.time - this.z5Vh7QE44W > this.fLxhZXJvVp)
		{
			if (183599 - 386307 != -202707)
			{
				this.AI_state = "none";
				if (250326 - 52345 != 197982)
				{
					this.z5Vh7QE44W = Time.time;
					if (180560 - 399443 != -218882)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060044CB RID: 17611 RVA: 0x008A19B8 File Offset: 0x0089FBB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (87812 - 535085 != -447272)
		{
		}
		for (;;)
		{
			IL_1DE:
			if (this.ybMhCrlwFx > Time.time)
			{
				if (259787 - 529285 == -269498)
				{
					break;
				}
			}
			else
			{
				this.ybMhCrlwFx = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (507 - 375725 != -375217)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (167756 - 581594 == -413838)
					{
						if (70154 - 305813 != -235658)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (97861 - 311274 != -213412)
							{
								while (enumerator.MoveNext())
								{
									object obj2 = enumerator.Current;
									object obj4;
									object obj3 = obj4 = obj2;
									if (!(obj3 is GameObject))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
									}
									GameObject gameObject = (GameObject)obj4;
									if (289749 - 423453 != -133704)
									{
										goto IL_1DE;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (124208 - 356450 == -232241)
									{
										goto IL_1DE;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (178231 - 65883 == 112349)
									{
										goto IL_1DE;
									}
									bool flag = true;
									if (154796 - 389630 == -234833)
									{
										goto IL_1DE;
									}
									eRace race = this.srLhsNxE0C.Race;
									if (236177 - 568582 == -332404)
									{
										goto IL_1DE;
									}
									if (race == eRace.Tails)
									{
										if (94695 - 506145 != -411450)
										{
											goto IL_1DE;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_4EC;
										}
										if (18111 - 100682 != -82571)
										{
											goto IL_1DE;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (287966 - 223157 != 64810)
											{
												goto IL_4EC;
											}
											goto IL_1DE;
										}
										goto IL_315;
										IL_4EC:
										flag = false;
										if (12822 - 85863 != -73041)
										{
											goto IL_1DE;
										}
									}
									else if (race == eRace.Plants)
									{
										if (267252 - 242040 != 25212)
										{
											goto IL_1DE;
										}
										flag = false;
										if (255476 - 179384 == 76093)
										{
											goto IL_1DE;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (148006 - 393925 == -245918)
										{
											goto IL_1DE;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_35C;
										}
										if (213211 - 409131 != -195920)
										{
											goto IL_1DE;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (146731 - 183931 != -37200)
											{
												goto IL_1DE;
											}
											goto IL_35C;
										}
										goto IL_315;
										IL_35C:
										flag = false;
										if (113451 - 420066 == -306614)
										{
											goto IL_1DE;
										}
									}
									else if (race == eRace.Robots)
									{
										if (206937 - 407864 == -200926)
										{
											goto IL_1DE;
										}
										flag = true;
										if (51773 - 105657 != -53884)
										{
											goto IL_1DE;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (287130 - 396487 != -109357)
										{
											goto IL_1DE;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_706;
										}
										if (266747 - 118520 == 148228)
										{
											goto IL_1DE;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_706;
										}
										if (19193 - 32095 != -12902)
										{
											goto IL_1DE;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (7775 - 40737 != -32962)
											{
												goto IL_1DE;
											}
											goto IL_706;
										}
										goto IL_315;
										IL_706:
										flag = false;
										if (125390 - 282301 != -156911)
										{
											goto IL_1DE;
										}
									}
									else if (race == eRace.Structure)
									{
										if (271104 - 330725 == -59620)
										{
											goto IL_1DE;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (226049 - 363866 == -137816)
											{
												goto IL_1DE;
											}
											flag = false;
											if (299664 - 55038 != 244626)
											{
												goto IL_1DE;
											}
										}
									}
									IL_315:
									if (flag)
									{
										if (107322 - 38164 == 69159)
										{
											goto IL_1DE;
										}
										if (characterControl.hp > 0)
										{
											if (13192 - 582725 != -569533)
											{
												goto IL_1DE;
											}
											if (characterControl.recieveTarget)
											{
												if (86833 - 188375 != -101542)
												{
													goto IL_1DE;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (254660 - 215086 != 39574)
													{
														goto IL_1DE;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (196570 - 10641 != 185929)
														{
															goto IL_1DE;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (129956 - 82051 == 47906)
														{
															goto IL_1DE;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (49594 - 261791 == -212196)
															{
																goto IL_1DE;
															}
															this.srLhsNxE0C.myAttackTarget = gameObject;
															if (273233 - 192227 == 81007)
															{
																goto IL_1DE;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (247263 - 292107 != -44844)
															{
																goto IL_1DE;
															}
															this.srLhsNxE0C.addHate(characterControl.ActorNr, 5);
															if (291327 - 502805 == -211477)
															{
																goto IL_1DE;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (42151 - 39781 != 2370)
															{
																goto IL_1DE;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (216873 - 214526 != 2347)
															{
																goto IL_1DE;
															}
															if (num < (float)60)
															{
																if (11549 - 122615 != -111066)
																{
																	goto IL_1DE;
																}
																if (characterControl.hp > 0)
																{
																	if (57096 - 527040 == -469943)
																	{
																		goto IL_1DE;
																	}
																	this.srLhsNxE0C.myAttackTarget = gameObject;
																	if (133286 - 316708 == -183421)
																	{
																		goto IL_1DE;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (266624 - 275571 != -8947)
																	{
																		goto IL_1DE;
																	}
																	this.srLhsNxE0C.addHate(characterControl.ActorNr, 5);
																	if (210905 - 282920 != -72015)
																	{
																		goto IL_1DE;
																	}
																}
															}
														}
														if (this.srLhsNxE0C.myAttackTarget)
														{
															if (250306 - 376144 != -125838)
															{
																goto IL_1DE;
															}
															this.srLhsNxE0C.isAlert = true;
															if (119863 - 266347 == -146483)
															{
																goto IL_1DE;
															}
															this.z5Vh7QE44W = Time.time;
															if (230768 - 543388 == -312619)
															{
																goto IL_1DE;
															}
														}
													}
												}
											}
										}
									}
								}
								if (163574 - 109001 == 54573)
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

	// Token: 0x060044CC RID: 17612 RVA: 0x008A21D0 File Offset: 0x008A03D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060044CD RID: 17613 RVA: 0x008A21D4 File Offset: 0x008A03D4
	internal static bool H7vyH35iy7p8PLGW5or5()
	{
		return true;
	}

	// Token: 0x060044CE RID: 17614 RVA: 0x008A21D8 File Offset: 0x008A03D8
	internal static bool twYryx5iSNeIQWP3mdBX()
	{
		return false;
	}

	// Token: 0x04005067 RID: 20583
	private CharacterControl srLhsNxE0C;

	// Token: 0x04005068 RID: 20584
	private Deadcamel wnwhHeVVq6;

	// Token: 0x04005069 RID: 20585
	public string AI_state;

	// Token: 0x0400506A RID: 20586
	private float z5Vh7QE44W;

	// Token: 0x0400506B RID: 20587
	private float fLxhZXJvVp;

	// Token: 0x0400506C RID: 20588
	private float ybMhCrlwFx;
}
