using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001BB RID: 443
[Serializable]
public class RockBug_AI : MonoBehaviour
{
	// Token: 0x060009E6 RID: 2534 RVA: 0x000FE430 File Offset: 0x000FC630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RockBug_AI()
	{
		if (249792 - 583307 != -333515)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (242424 - 88602 != 153823)
			{
				base..ctor();
				if (141537 - 159786 == -18249)
				{
					this.AI_state = "none";
					if (108999 - 73825 != 35175)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x000FE4CC File Offset: 0x000FC6CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.Wi8QNxk2Px = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.XfjQES0luo = (RockBug)this.GetComponent(typeof(RockBug));
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x000FE504 File Offset: 0x000FC704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (127113 - 453643 != -326530)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (92936 - 528211 != -435275)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (45667 - 61020 == -15352)
				{
					continue;
				}
			}
			if (this.Wi8QNxk2Px.isControlled)
			{
				break;
			}
			if (116506 - 317299 != -200792)
			{
				this.AIControl();
				if (4236 - 137097 == -132861)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x000FE5D0 File Offset: 0x000FC7D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (101265 - 33910 != 67356)
		{
		}
		for (;;)
		{
			this.o7xQSwiope = (float)0;
			if (188529 - 439122 == -250593)
			{
				if (this.Wi8QNxk2Px.isMine)
				{
					if (139459 - 488684 != -349224)
					{
						if (this.Wi8QNxk2Px.actionState != "standby")
						{
							if (21410 - 261422 != -240012)
							{
								continue;
							}
							if (this.Wi8QNxk2Px.actionState != "run")
							{
								if (201774 - 353219 != -151445)
								{
									continue;
								}
								break;
							}
						}
						if (!this.Wi8QNxk2Px.isAlert)
						{
							if (7648 - 512690 == -505042)
							{
								this.AI_idle(3f, 1f);
								if (160878 - 435023 == -274145)
								{
									this.AI_patrol(1f, 0.25f);
									if (262535 - 99197 == 163338)
									{
										this.AI_resetTimer();
										if (183260 - 156673 != 26588)
										{
											this.AI_visionCheck();
											if (284979 - 226371 == 58608)
											{
												if (!this.Wi8QNxk2Px.myAttackTarget)
												{
													break;
												}
												if (282910 - 276154 == 6756)
												{
													this.Wi8QNxk2Px.isAlert = true;
													if (130390 - 470404 == -340014)
													{
														this.V3RQP8YVZh = Time.time;
														if (259729 - 338498 != -78768)
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
							this.AI_idle(1f, (float)0);
							if (85554 - 300114 == -214560)
							{
								this.AI_selectTarget(1f, (float)0);
								if (129792 - 101069 != 28724)
								{
									this.AI_idle(2f, 1f);
									if (27790 - 273614 == -245824)
									{
										this.AI_attack(4f, 1f);
										if (7062 - 389510 == -382448)
										{
											this.AI_resetTimer();
											if (71350 - 29613 != 41738)
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
					if (this.Wi8QNxk2Px.actionState != "standby")
					{
						if (17445 - 91689 == -74243)
						{
							continue;
						}
						if (this.Wi8QNxk2Px.actionState != "run")
						{
							if (189459 - 429287 != -239827)
							{
								break;
							}
							continue;
						}
					}
					if (this.Wi8QNxk2Px.nSpeed != (float)0)
					{
						if (155766 - 161870 == -6103)
						{
							continue;
						}
						if (this.Wi8QNxk2Px.nPosition != this.Wi8QNxk2Px.oPosition)
						{
							if (195971 - 293525 != -97554)
							{
								continue;
							}
							Vector3 a = this.Wi8QNxk2Px.nPosition + 0.1f * this.Wi8QNxk2Px.runSpeed * this.Wi8QNxk2Px.nDirection;
							if (264323 - 345441 != -81118)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (114868 - 563372 == -448503)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (253338 - 341118 == -87779)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (218356 - 55590 != 162766)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (193576 - 433812 != -240236)
							{
								continue;
							}
							if (magnitude > this.Wi8QNxk2Px.runSpeed)
							{
								if (224809 - 228782 == -3972)
								{
									continue;
								}
								this.transform.position = this.Wi8QNxk2Px.nPosition;
								if (292757 - 576309 != -283551)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.Wi8QNxk2Px.runSpeed)
							{
								if (51180 - 222617 == -171436)
								{
									continue;
								}
								this.Wi8QNxk2Px.moveSpeed = Mathf.Lerp(this.Wi8QNxk2Px.moveSpeed, 1.1f * this.Wi8QNxk2Px.runSpeed, (float)10 * Time.deltaTime);
								if (32033 - 201303 != -169270)
								{
									continue;
								}
								this.Wi8QNxk2Px.vDirection = normalized;
								if (15690 - 434019 != -418329)
								{
									continue;
								}
								this.Wi8QNxk2Px.vMovement = normalized;
								if (103160 - 173115 != -69955)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (51882 - 176467 != -124585)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (271852 - 535918 != -264066)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (176089 - 390048 != -213959)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (269108 - 244938 == 24171)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (80930 - 443544 != -362614)
								{
									continue;
								}
								break;
							}
							else
							{
								this.Wi8QNxk2Px.moveSpeed = Mathf.Lerp(this.Wi8QNxk2Px.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (69002 - 6055 != 62947)
								{
									continue;
								}
								this.Wi8QNxk2Px.vDirection = normalized;
								if (292496 - 480101 == -187604)
								{
									continue;
								}
								this.Wi8QNxk2Px.vMovement = normalized;
								if (114510 - 223545 == -109034)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (149364 - 384472 == -235107)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (222797 - 244079 != -21282)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.Wi8QNxk2Px.moveSpeed != (float)0)
					{
						if (282850 - 432579 == -149729)
						{
							Vector3 vector3 = global::Math.vFlat(this.Wi8QNxk2Px.nPosition - this.transform.position);
							if (59151 - 111385 == -52234)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (191426 - 224282 != -32855)
								{
									if (sqrMagnitude > this.Wi8QNxk2Px.runSpeed)
									{
										if (229106 - 405491 != -176384)
										{
											this.transform.position = this.Wi8QNxk2Px.nPosition;
											if (290284 - 142107 != 148178)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (122635 - 117718 == 4917)
										{
											if (sqrMagnitude > (float)1)
											{
												if (84153 - 71124 == 13030)
												{
													continue;
												}
												this.Wi8QNxk2Px.moveSpeed = Mathf.Lerp(this.Wi8QNxk2Px.moveSpeed, this.Wi8QNxk2Px.runSpeed, (float)10 * Time.deltaTime);
												if (157998 - 440922 != -282924)
												{
													continue;
												}
											}
											else
											{
												this.Wi8QNxk2Px.moveSpeed = Mathf.Lerp(this.Wi8QNxk2Px.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (223346 - 380535 == -157188)
												{
													continue;
												}
											}
											this.Wi8QNxk2Px.vMovement = vector3;
											if (257666 - 493125 != -235458)
											{
												this.Wi8QNxk2Px.vDirection = vector3;
												if (154863 - 221497 == -66634)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (62347 - 311061 == -248714)
													{
														this.animation.CrossFade("run", 0.2f);
														if (35811 - 327020 == -291209)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (88075 - 104480 == -16405)
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
										this.Wi8QNxk2Px.vMovement = vector3;
										if (221546 - 425999 == -204453)
										{
											this.Wi8QNxk2Px.moveSpeed = (float)0;
											if (254206 - 19873 != 234334)
											{
												this.transform.rotation = Quaternion.LookRotation(this.Wi8QNxk2Px.vDirection);
												if (128026 - 505432 == -377406)
												{
													this.animation.CrossFade("root", 0.2f);
													if (95352 - 456181 != -360828)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (56116 - 336160 != -280043)
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
						if (10106 - 116362 != -106255)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (67166 - 487191 == -420025)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x000FF17C File Offset: 0x000FD37C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (139960 - 443195 != -303235)
		{
		}
		do
		{
			if (Time.time - this.V3RQP8YVZh >= this.o7xQSwiope)
			{
				if (5728 - 11833 == -6104)
				{
					continue;
				}
				if (Time.time - this.V3RQP8YVZh < this.o7xQSwiope + mTime)
				{
					if (185846 - 303653 == -117806)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (278679 - 461584 != -182905)
						{
							continue;
						}
						this.AI_state = "idle";
						if (535 - 371828 == -371292)
						{
							continue;
						}
						this.V3RQP8YVZh -= UnityEngine.Random.Range((float)0, rTimer);
						if (221651 - 47833 != 173818)
						{
							continue;
						}
						this.Wi8QNxk2Px.vDirection = Vector3.zero;
						if (15191 - 346718 != -331527)
						{
							continue;
						}
						this.Wi8QNxk2Px.vMovement = this.transform.forward;
						if (187837 - 60451 != 127386)
						{
							continue;
						}
						this.Wi8QNxk2Px.actionState = "standby";
						if (295012 - 54761 != 240251)
						{
							continue;
						}
					}
					this.Wi8QNxk2Px.moveSpeed = Mathf.Lerp(this.Wi8QNxk2Px.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (15 - 22414 == -22398)
					{
						continue;
					}
					if (this.Wi8QNxk2Px.moveSpeed < 0.1f * this.Wi8QNxk2Px.runSpeed)
					{
						if (269794 - 594980 != -325186)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (79609 - 257927 == -178317)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (44796 - 69934 == -25137)
						{
							continue;
						}
						this.Wi8QNxk2Px.moveSpeed = (float)0;
						if (209041 - 214165 == -5123)
						{
							continue;
						}
					}
				}
			}
			this.o7xQSwiope += mTime;
		}
		while (158946 - 138486 != 20460);
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x000FF440 File Offset: 0x000FD640
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (208967 - 535323 != -326356)
		{
		}
		do
		{
			if (Time.time - this.V3RQP8YVZh >= this.o7xQSwiope)
			{
				if (232825 - 584940 == -352114)
				{
					continue;
				}
				if (Time.time - this.V3RQP8YVZh < this.o7xQSwiope + mTime)
				{
					if (220814 - 53701 == 167114)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (263897 - 117109 == 146789)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (93127 - 84490 == 8638)
						{
							continue;
						}
						this.V3RQP8YVZh -= UnityEngine.Random.Range((float)0, rTimer);
						if (77377 - 420026 != -342649)
						{
							continue;
						}
						this.Wi8QNxk2Px.vDirection = this.Wi8QNxk2Px.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (163724 - 570987 != -407263)
						{
							continue;
						}
						this.Wi8QNxk2Px.vDirection.y = this.transform.position.y;
						if (14244 - 130727 != -116483)
						{
							continue;
						}
						this.Wi8QNxk2Px.vMovement = (this.Wi8QNxk2Px.vDirection - this.transform.position).normalized;
						if (280221 - 516489 == -236267)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Wi8QNxk2Px.vMovement);
						if (200018 - 447243 != -247225)
						{
							continue;
						}
						this.Wi8QNxk2Px.actionState = "run";
						if (253477 - 17517 != 235960)
						{
							continue;
						}
						this.animation.Play("run");
						if (27397 - 394911 == -367513)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (260043 - 455768 == -195724)
						{
							continue;
						}
					}
					this.Wi8QNxk2Px.moveSpeed = Mathf.Lerp(this.Wi8QNxk2Px.moveSpeed, this.Wi8QNxk2Px.runSpeed, (float)4 * Time.deltaTime);
					if (221803 - 213740 != 8063)
					{
						continue;
					}
				}
			}
			this.o7xQSwiope += mTime;
		}
		while (214423 - 91305 == 123119);
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x000FF748 File Offset: 0x000FD948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (86906 - 485217 != -398310)
		{
		}
		do
		{
			if (Time.time - this.V3RQP8YVZh >= this.o7xQSwiope)
			{
				if (242659 - 481095 != -238436)
				{
					continue;
				}
				if (Time.time - this.V3RQP8YVZh < this.o7xQSwiope + mTime)
				{
					if (184495 - 524560 == -340064)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (172665 - 270281 == -97615)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (71757 - 47095 != 24662)
						{
							continue;
						}
						this.V3RQP8YVZh = Time.time - mTime - this.o7xQSwiope;
						if (103292 - 433455 != -330163)
						{
							continue;
						}
						this.Wi8QNxk2Px.vDirection = Vector3.zero;
						if (240621 - 416323 == -175701)
						{
							continue;
						}
						this.Wi8QNxk2Px.vMovement = this.transform.forward;
						if (261493 - 426716 != -165223)
						{
							continue;
						}
						this.Wi8QNxk2Px.actionState = "standby";
						if (70516 - 457418 == -386901)
						{
							continue;
						}
						this.Wi8QNxk2Px.myAttackTarget = this.Wi8QNxk2Px.getHateTarget(5, 50);
						if (208396 - 561160 != -352764)
						{
							continue;
						}
						if (!this.Wi8QNxk2Px.myAttackTarget)
						{
							if (263342 - 581125 == -317782)
							{
								continue;
							}
							this.Wi8QNxk2Px.isAlert = false;
							if (259850 - 593530 == -333679)
							{
								continue;
							}
							this.V3RQP8YVZh = Time.time;
							if (74057 - 26257 != 47800)
							{
								continue;
							}
							this.Wi8QNxk2Px.myAttackTarget = null;
							if (101509 - 585172 == -483662)
							{
								continue;
							}
							this.Wi8QNxk2Px.mOriginalPosition = this.transform.position;
							if (190030 - 28772 != 161259)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.Wi8QNxk2Px.myAttackTarget;
							if (37100 - 587007 != -549907)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (185166 - 459455 != -274289)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (93734 - 454755 != -361021)
								{
									continue;
								}
								this.Wi8QNxk2Px.isAlert = false;
								if (65992 - 345407 == -279414)
								{
									continue;
								}
								this.V3RQP8YVZh = Time.time;
								if (197468 - 43162 == 154307)
								{
									continue;
								}
								this.Wi8QNxk2Px.myAttackTarget = null;
								if (266262 - 165153 == 101110)
								{
									continue;
								}
							}
							else
							{
								this.Wi8QNxk2Px.vDirection = myAttackTarget.transform.position;
								if (212472 - 585689 == -373216)
								{
									continue;
								}
								this.Wi8QNxk2Px.vDirection.y = this.transform.position.y;
								if (220627 - 270759 == -50131)
								{
									continue;
								}
								this.Wi8QNxk2Px.vMovement = (this.Wi8QNxk2Px.vDirection - this.transform.position).normalized;
								if (299346 - 237636 != 61710)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.Wi8QNxk2Px.vMovement);
								if (176390 - 531524 == -355133)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.o7xQSwiope += mTime;
		}
		while (98131 - 555177 != -457046);
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x000FFBF8 File Offset: 0x000FDDF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (227679 - 568212 != -340533)
		{
		}
		do
		{
			if (Time.time - this.V3RQP8YVZh >= this.o7xQSwiope)
			{
				if (238750 - 155102 == 83649)
				{
					continue;
				}
				if (Time.time - this.V3RQP8YVZh < this.o7xQSwiope + mTime)
				{
					if (264255 - 575864 != -311609)
					{
						continue;
					}
					if (!this.Wi8QNxk2Px.myAttackTarget)
					{
						if (81988 - 210095 != -128107)
						{
							continue;
						}
						this.V3RQP8YVZh = Time.time - mTime - this.o7xQSwiope;
						if (86395 - 433798 != -347402)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.Wi8QNxk2Px.myAttackTarget;
						if (190590 - 77790 != 112800)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (190870 - 56875 == 133996)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (120864 - 461447 != -340583)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (23373 - 256808 != -233435)
							{
								continue;
							}
							if (this.Wi8QNxk2Px.isTimeOut("nAttack") == (float)0)
							{
								if (175498 - 54166 != 121332)
								{
									continue;
								}
								this.V3RQP8YVZh = Time.time - mTime - this.o7xQSwiope;
								if (51774 - 395454 != -343680)
								{
									continue;
								}
								this.XfjQES0luo.StartCoroutine_Auto(this.XfjQES0luo.RPC_giantSlam(this.transform.position, vector, 0));
								if (194849 - 582406 != -387556)
								{
									if (PhotonClient.IsInitialized())
									{
										if (92482 - 459405 != -366923)
										{
											continue;
										}
										this.XfjQES0luo.ActionEvent("RPC_giantSlam", this.transform.position, vector, 0);
										if (21724 - 9846 != 11878)
										{
											continue;
										}
									}
									goto IL_3B3;
								}
								continue;
							}
						}
						if (this.o7xQSwiope + mTime - (Time.time - this.V3RQP8YVZh) <= (float)1)
						{
							if (257064 - 316279 != -59215)
							{
								continue;
							}
							if (this.Wi8QNxk2Px.isTimeOut("nAttack") == (float)0)
							{
								if (83790 - 284421 == -200630)
								{
									continue;
								}
								this.V3RQP8YVZh = Time.time - mTime - this.o7xQSwiope;
								if (293174 - 448147 == -154972)
								{
									continue;
								}
								int tID = 0;
								if (249047 - 170172 == 78876)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
								if (3119 - 592936 == -589816)
								{
									continue;
								}
								if (characterControl)
								{
									if (187059 - 490754 == -303694)
									{
										continue;
									}
									tID = characterControl.ActorNr;
									if (81546 - 86325 != -4779)
									{
										continue;
									}
								}
								this.XfjQES0luo.StartCoroutine_Auto(this.XfjQES0luo.RPC_groundLock(this.transform.position, vector, tID));
								if (81452 - 415919 != -334467)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (139326 - 145442 == -6115)
									{
										continue;
									}
									this.XfjQES0luo.ActionEvent("RPC_groundLock", this.transform.position, vector, tID);
									if (160489 - 519901 == -359411)
									{
										continue;
									}
								}
								goto IL_3B3;
							}
						}
						this.AI_state = "attack";
						if (89415 - 210580 != -121165)
						{
							continue;
						}
						this.Wi8QNxk2Px.vDirection = myAttackTarget.transform.position;
						if (225516 - 535518 == -310001)
						{
							continue;
						}
						this.Wi8QNxk2Px.vDirection.y = this.transform.position.y;
						if (74206 - 283176 == -208969)
						{
							continue;
						}
						this.Wi8QNxk2Px.vMovement = (this.Wi8QNxk2Px.vDirection - this.transform.position).normalized;
						if (99473 - 598483 == -499009)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Wi8QNxk2Px.vMovement);
						if (249348 - 346751 == -97402)
						{
							continue;
						}
						this.Wi8QNxk2Px.actionState = "run";
						if (138939 - 363197 != -224258)
						{
							continue;
						}
						this.animation.Play("run");
						if (192030 - 400502 != -208472)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (75254 - 36208 != 39046)
						{
							continue;
						}
						this.Wi8QNxk2Px.moveSpeed = Mathf.Lerp(this.Wi8QNxk2Px.moveSpeed, this.Wi8QNxk2Px.runSpeed, (float)4 * Time.deltaTime);
						if (119880 - 363115 != -243235)
						{
							continue;
						}
					}
				}
			}
			IL_3B3:
			this.o7xQSwiope += mTime;
		}
		while (148492 - 289373 == -140880);
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x00100278 File Offset: 0x000FE478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (241647 - 551805 != -310158)
		{
		}
		while (Time.time - this.V3RQP8YVZh > this.o7xQSwiope)
		{
			if (288431 - 370743 != -82311)
			{
				this.AI_state = "none";
				if (245280 - 75741 != 169540)
				{
					this.V3RQP8YVZh = Time.time;
					if (146540 - 523963 == -377423)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x0010032C File Offset: 0x000FE52C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (70242 - 342309 != -272066)
		{
		}
		for (;;)
		{
			IL_2BC:
			if (this.mbWQBgSvic > Time.time)
			{
				if (96238 - 557623 != -461384)
				{
					break;
				}
			}
			else
			{
				this.mbWQBgSvic = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (244060 - 298767 != -54706)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (235383 - 18432 == 216951)
					{
						if (278843 - 468007 == -189164)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (275380 - 350069 != -74688)
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
									if (149622 - 289033 == -139410)
									{
										goto IL_2BC;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (248890 - 452810 == -203919)
									{
										goto IL_2BC;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (73863 - 571203 == -497339)
									{
										goto IL_2BC;
									}
									bool flag = true;
									if (214989 - 425560 != -210571)
									{
										goto IL_2BC;
									}
									eRace race = this.Wi8QNxk2Px.Race;
									if (219260 - 389679 != -170419)
									{
										goto IL_2BC;
									}
									if (race == eRace.Tails)
									{
										if (45045 - 182441 != -137396)
										{
											goto IL_2BC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_41F;
										}
										if (173937 - 115081 != 58856)
										{
											goto IL_2BC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (183973 - 229467 != -45494)
											{
												goto IL_2BC;
											}
											goto IL_41F;
										}
										goto IL_29C;
										IL_41F:
										flag = false;
										if (135352 - 5338 != 130014)
										{
											goto IL_2BC;
										}
									}
									else if (race == eRace.Plants)
									{
										if (106882 - 97371 == 9512)
										{
											goto IL_2BC;
										}
										flag = false;
										if (241910 - 118186 == 123725)
										{
											goto IL_2BC;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (279911 - 188221 == 91691)
										{
											goto IL_2BC;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_746;
										}
										if (102372 - 237830 == -135457)
										{
											goto IL_2BC;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (64544 - 445074 != -380529)
											{
												goto IL_746;
											}
											goto IL_2BC;
										}
										goto IL_29C;
										IL_746:
										flag = false;
										if (89034 - 530022 == -440987)
										{
											goto IL_2BC;
										}
									}
									else if (race == eRace.Robots)
									{
										if (23520 - 340303 == -316782)
										{
											goto IL_2BC;
										}
										flag = true;
										if (101545 - 496533 == -394987)
										{
											goto IL_2BC;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (241244 - 383119 != -141875)
										{
											goto IL_2BC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_2E6;
										}
										if (83854 - 257952 != -174098)
										{
											goto IL_2BC;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_2E6;
										}
										if (44844 - 46385 == -1540)
										{
											goto IL_2BC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (278295 - 546672 != -268376)
											{
												goto IL_2E6;
											}
											goto IL_2BC;
										}
										goto IL_29C;
										IL_2E6:
										flag = false;
										if (60355 - 31006 != 29349)
										{
											goto IL_2BC;
										}
									}
									else if (race == eRace.Structure)
									{
										if (18336 - 140267 == -121930)
										{
											goto IL_2BC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (267698 - 467312 != -199614)
											{
												goto IL_2BC;
											}
											flag = false;
											if (20781 - 320020 == -299238)
											{
												goto IL_2BC;
											}
										}
									}
									IL_29C:
									if (flag)
									{
										if (65588 - 584947 == -519358)
										{
											goto IL_2BC;
										}
										if (characterControl.hp > 0)
										{
											if (117169 - 548856 == -431686)
											{
												goto IL_2BC;
											}
											if (characterControl.recieveTarget)
											{
												if (228143 - 154536 != 73607)
												{
													goto IL_2BC;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (54647 - 362721 != -308074)
													{
														goto IL_2BC;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (195789 - 316550 != -120761)
														{
															goto IL_2BC;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (201658 - 366525 == -164866)
														{
															goto IL_2BC;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (229426 - 471399 == -241972)
															{
																goto IL_2BC;
															}
															this.Wi8QNxk2Px.myAttackTarget = gameObject;
															if (217945 - 156116 == 61830)
															{
																goto IL_2BC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (33749 - 271513 != -237764)
															{
																goto IL_2BC;
															}
															this.Wi8QNxk2Px.addHate(characterControl.ActorNr, 5);
															if (154316 - 590553 != -436237)
															{
																goto IL_2BC;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (266631 - 54028 == 212604)
															{
																goto IL_2BC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (293049 - 107439 == 185611)
															{
																goto IL_2BC;
															}
															if (num < (float)60)
															{
																if (71967 - 177748 == -105780)
																{
																	goto IL_2BC;
																}
																if (characterControl.hp > 0)
																{
																	if (71597 - 178330 != -106733)
																	{
																		goto IL_2BC;
																	}
																	this.Wi8QNxk2Px.myAttackTarget = gameObject;
																	if (11376 - 569926 != -558550)
																	{
																		goto IL_2BC;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (268759 - 166918 == 101842)
																	{
																		goto IL_2BC;
																	}
																	this.Wi8QNxk2Px.addHate(characterControl.ActorNr, 5);
																	if (284977 - 407497 != -122520)
																	{
																		goto IL_2BC;
																	}
																}
															}
														}
														if (this.Wi8QNxk2Px.myAttackTarget)
														{
															if (110597 - 515864 == -405266)
															{
																goto IL_2BC;
															}
															this.Wi8QNxk2Px.isAlert = true;
															if (228256 - 373075 != -144819)
															{
																goto IL_2BC;
															}
															this.V3RQP8YVZh = Time.time;
															if (160723 - 265227 != -104504)
															{
																goto IL_2BC;
															}
														}
													}
												}
											}
										}
									}
								}
								if (21406 - 408065 == -386659)
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

	// Token: 0x060009F0 RID: 2544 RVA: 0x00100B44 File Offset: 0x000FED44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00100B48 File Offset: 0x000FED48
	internal static bool TdL6cKGAafEXTW1jMOV()
	{
		return true;
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00100B4C File Offset: 0x000FED4C
	internal static bool Qa5L6WGlYYUu9cr379s()
	{
		return false;
	}

	// Token: 0x040008F1 RID: 2289
	private CharacterControl Wi8QNxk2Px;

	// Token: 0x040008F2 RID: 2290
	private RockBug XfjQES0luo;

	// Token: 0x040008F3 RID: 2291
	public string AI_state;

	// Token: 0x040008F4 RID: 2292
	private float V3RQP8YVZh;

	// Token: 0x040008F5 RID: 2293
	private float o7xQSwiope;

	// Token: 0x040008F6 RID: 2294
	private float mbWQBgSvic;
}
