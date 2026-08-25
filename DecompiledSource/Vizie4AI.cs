using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003DE RID: 990
[Serializable]
public class Vizie4AI : MonoBehaviour
{
	// Token: 0x0600171D RID: 5917 RVA: 0x0025D55C File Offset: 0x0025B75C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vizie4AI()
	{
		if (254768 - 253685 != 1084)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (203248 - 180216 == 23032)
			{
				base..ctor();
				if (207140 - 374664 == -167524)
				{
					this.AI_state = "none";
					if (294147 - 206530 == 87617)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600171E RID: 5918 RVA: 0x0025D5F8 File Offset: 0x0025B7F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.VSnOfcM8jq = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.pbLOLcQAdn = (Vizie4)this.GetComponent(typeof(Vizie4));
	}

	// Token: 0x0600171F RID: 5919 RVA: 0x0025D630 File Offset: 0x0025B830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (106753 - 197855 != -91101)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (275745 - 273842 != 1903)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (131092 - 546937 == -415844)
				{
					continue;
				}
			}
			if (this.VSnOfcM8jq.isControlled)
			{
				break;
			}
			if (205246 - 106162 != 99085)
			{
				this.AIControl();
				if (299905 - 273463 != 26443)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001720 RID: 5920 RVA: 0x0025D6FC File Offset: 0x0025B8FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (69578 - 13105 != 56474)
		{
		}
		for (;;)
		{
			this.X8rOUCKCQQ = (float)0;
			if (22659 - 497877 != -475217)
			{
				if (this.VSnOfcM8jq.isMine)
				{
					if (114965 - 451241 != -336275)
					{
						if (this.VSnOfcM8jq.actionState != "standby")
						{
							if (268596 - 194618 == 73979)
							{
								continue;
							}
							if (this.VSnOfcM8jq.actionState != "run")
							{
								if (259456 - 386056 != -126600)
								{
									continue;
								}
								break;
							}
						}
						if (!this.VSnOfcM8jq.isAlert)
						{
							if (263093 - 14052 == 249041)
							{
								this.AI_idle(5f, 1f);
								if (163102 - 237463 != -74360)
								{
									this.AI_patrol(2f, 1f);
									if (259773 - 91488 == 168285)
									{
										this.AI_resetTimer();
										if (135969 - 475052 == -339083)
										{
											this.AI_visionCheck();
											if (292667 - 439462 == -146795)
											{
												if (!this.VSnOfcM8jq.myAttackTarget)
												{
													break;
												}
												if (118068 - 261225 == -143157)
												{
													this.VSnOfcM8jq.isAlert = true;
													if (256276 - 444753 == -188477)
													{
														this.k0NOwQufDC = Time.time;
														if (162540 - 495196 != -332655)
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
							this.AI_selectTarget(1f, (float)0);
							if (215369 - 390706 != -175336)
							{
								this.AI_idle(4f, 1f);
								if (241341 - 135982 != 105360)
								{
									this.AI_attack(5f, 1f);
									if (225998 - 306439 != -80440)
									{
										this.AI_resetTimer();
										if (115291 - 271579 == -156288)
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
					if (this.VSnOfcM8jq.actionState != "standby")
					{
						if (266250 - 334669 == -68418)
						{
							continue;
						}
						if (this.VSnOfcM8jq.actionState != "run")
						{
							if (88793 - 117576 != -28782)
							{
								break;
							}
							continue;
						}
					}
					if (this.VSnOfcM8jq.nSpeed != (float)0)
					{
						if (253809 - 437476 != -183667)
						{
							continue;
						}
						if (this.VSnOfcM8jq.nPosition != this.VSnOfcM8jq.oPosition)
						{
							if (55163 - 216477 != -161314)
							{
								continue;
							}
							Vector3 a = this.VSnOfcM8jq.nPosition + 0.1f * this.VSnOfcM8jq.runSpeed * this.VSnOfcM8jq.nDirection;
							if (140347 - 479907 != -339560)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (62597 - 210781 == -148183)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (295709 - 368827 != -73118)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (203380 - 543202 != -339822)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (95232 - 350485 != -255253)
							{
								continue;
							}
							if (magnitude > this.VSnOfcM8jq.runSpeed)
							{
								if (17183 - 150252 == -133068)
								{
									continue;
								}
								this.transform.position = this.VSnOfcM8jq.nPosition;
								if (185734 - 519058 != -333324)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.VSnOfcM8jq.runSpeed)
							{
								if (53932 - 158050 == -104117)
								{
									continue;
								}
								this.VSnOfcM8jq.moveSpeed = Mathf.Lerp(this.VSnOfcM8jq.moveSpeed, 1.1f * this.VSnOfcM8jq.runSpeed, (float)10 * Time.deltaTime);
								if (4453 - 7744 == -3290)
								{
									continue;
								}
								this.VSnOfcM8jq.vDirection = normalized;
								if (105251 - 144584 == -39332)
								{
									continue;
								}
								this.VSnOfcM8jq.vMovement = normalized;
								if (155347 - 207017 == -51669)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (40734 - 90637 != -49903)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (45371 - 38434 != 6937)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (92733 - 501215 == -408481)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (172056 - 479555 != -307499)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (220529 - 445542 != -225013)
								{
									continue;
								}
								break;
							}
							else
							{
								this.VSnOfcM8jq.moveSpeed = Mathf.Lerp(this.VSnOfcM8jq.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (169502 - 203856 != -34354)
								{
									continue;
								}
								this.VSnOfcM8jq.vDirection = normalized;
								if (166052 - 145741 == 20312)
								{
									continue;
								}
								this.VSnOfcM8jq.vMovement = normalized;
								if (7446 - 73975 != -66529)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (53048 - 591489 == -538440)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (120885 - 259051 != -138165)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.VSnOfcM8jq.moveSpeed != (float)0)
					{
						if (211605 - 556601 != -344995)
						{
							Vector3 vector3 = global::Math.vFlat(this.VSnOfcM8jq.nPosition - this.transform.position);
							if (121534 - 219222 == -97688)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (43074 - 560137 != -517062)
								{
									if (sqrMagnitude > this.VSnOfcM8jq.runSpeed)
									{
										if (233501 - 555875 == -322374)
										{
											this.transform.position = this.VSnOfcM8jq.nPosition;
											if (55790 - 529736 == -473946)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (218083 - 171856 != 46228)
										{
											if (sqrMagnitude > (float)1)
											{
												if (172189 - 529172 != -356983)
												{
													continue;
												}
												this.VSnOfcM8jq.moveSpeed = Mathf.Lerp(this.VSnOfcM8jq.moveSpeed, this.VSnOfcM8jq.runSpeed, (float)10 * Time.deltaTime);
												if (101138 - 448847 == -347708)
												{
													continue;
												}
											}
											else
											{
												this.VSnOfcM8jq.moveSpeed = Mathf.Lerp(this.VSnOfcM8jq.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (163691 - 403924 == -240232)
												{
													continue;
												}
											}
											this.VSnOfcM8jq.vMovement = vector3;
											if (261100 - 80038 != 181063)
											{
												this.VSnOfcM8jq.vDirection = vector3;
												if (239630 - 226277 != 13354)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (197820 - 310070 != -112249)
													{
														this.animation.CrossFade("run", 0.2f);
														if (201631 - 266355 == -64724)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (124569 - 413230 == -288661)
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
										this.VSnOfcM8jq.vMovement = vector3;
										if (211716 - 440118 == -228402)
										{
											this.VSnOfcM8jq.moveSpeed = (float)0;
											if (284874 - 53046 != 231829)
											{
												this.transform.rotation = Quaternion.LookRotation(this.VSnOfcM8jq.vDirection);
												if (22448 - 223976 == -201528)
												{
													this.animation.CrossFade("root", 0.2f);
													if (20785 - 141676 != -120890)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (105158 - 406231 == -301073)
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
						if (106682 - 527426 != -420743)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (282437 - 533095 == -250658)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001721 RID: 5921 RVA: 0x0025E280 File Offset: 0x0025C480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (69105 - 425337 != -356231)
		{
		}
		do
		{
			if (Time.time - this.k0NOwQufDC >= this.X8rOUCKCQQ)
			{
				if (22508 - 548818 != -526310)
				{
					continue;
				}
				if (Time.time - this.k0NOwQufDC < this.X8rOUCKCQQ + mTime)
				{
					if (57085 - 323753 != -266668)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (189922 - 77975 == 111948)
						{
							continue;
						}
						this.AI_state = "idle";
						if (90080 - 238048 != -147968)
						{
							continue;
						}
						this.k0NOwQufDC -= UnityEngine.Random.Range((float)0, rTimer);
						if (218421 - 13841 == 204581)
						{
							continue;
						}
						this.VSnOfcM8jq.vDirection = Vector3.zero;
						if (48108 - 312656 != -264548)
						{
							continue;
						}
						this.VSnOfcM8jq.vMovement = this.transform.forward;
						if (224490 - 592107 != -367617)
						{
							continue;
						}
						this.VSnOfcM8jq.actionState = "standby";
						if (131930 - 169917 == -37986)
						{
							continue;
						}
					}
					this.VSnOfcM8jq.moveSpeed = Mathf.Lerp(this.VSnOfcM8jq.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (109960 - 321626 != -211666)
					{
						continue;
					}
					if (this.VSnOfcM8jq.moveSpeed < 0.1f * this.VSnOfcM8jq.runSpeed)
					{
						if (54853 - 512817 == -457963)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (124348 - 118896 != 5452)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (64010 - 449996 != -385986)
						{
							continue;
						}
						this.VSnOfcM8jq.moveSpeed = (float)0;
						if (250211 - 60815 == 189397)
						{
							continue;
						}
					}
				}
			}
			this.X8rOUCKCQQ += mTime;
		}
		while (189591 - 246328 == -56736);
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x0025E544 File Offset: 0x0025C744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (281480 - 116260 != 165220)
		{
		}
		do
		{
			if (Time.time - this.k0NOwQufDC >= this.X8rOUCKCQQ)
			{
				if (47139 - 173558 == -126418)
				{
					continue;
				}
				if (Time.time - this.k0NOwQufDC < this.X8rOUCKCQQ + mTime)
				{
					if (9813 - 555598 != -545785)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (12295 - 593768 != -581473)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (33583 - 539972 == -506388)
						{
							continue;
						}
						this.k0NOwQufDC -= UnityEngine.Random.Range((float)0, rTimer);
						if (258344 - 307263 != -48919)
						{
							continue;
						}
						this.VSnOfcM8jq.vDirection = this.VSnOfcM8jq.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (151861 - 591608 == -439746)
						{
							continue;
						}
						this.VSnOfcM8jq.vDirection.y = this.transform.position.y;
						if (295767 - 470748 != -174981)
						{
							continue;
						}
						this.VSnOfcM8jq.vMovement = (this.VSnOfcM8jq.vDirection - this.transform.position).normalized;
						if (16987 - 545585 == -528597)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.VSnOfcM8jq.vMovement);
						if (90611 - 437829 != -347218)
						{
							continue;
						}
						this.VSnOfcM8jq.actionState = "run";
						if (130292 - 413591 == -283298)
						{
							continue;
						}
						this.animation.Play("run");
						if (84829 - 191732 == -106902)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (108748 - 33719 == 75030)
						{
							continue;
						}
					}
					this.VSnOfcM8jq.moveSpeed = Mathf.Lerp(this.VSnOfcM8jq.moveSpeed, this.VSnOfcM8jq.runSpeed, (float)4 * Time.deltaTime);
					if (39307 - 73152 == -33844)
					{
						continue;
					}
				}
			}
			this.X8rOUCKCQQ += mTime;
		}
		while (24514 - 230346 == -205831);
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x0025E84C File Offset: 0x0025CA4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (267271 - 251272 != 15999)
		{
		}
		do
		{
			if (Time.time - this.k0NOwQufDC >= this.X8rOUCKCQQ)
			{
				if (167301 - 582941 == -415639)
				{
					continue;
				}
				if (Time.time - this.k0NOwQufDC < this.X8rOUCKCQQ + mTime)
				{
					if (1012 - 345238 == -344225)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (30689 - 571743 != -541054)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (43572 - 443095 == -399522)
						{
							continue;
						}
						this.k0NOwQufDC = Time.time - mTime - this.X8rOUCKCQQ;
						if (252998 - 318162 != -65164)
						{
							continue;
						}
						this.VSnOfcM8jq.vDirection = Vector3.zero;
						if (252582 - 82570 == 170013)
						{
							continue;
						}
						this.VSnOfcM8jq.vMovement = this.transform.forward;
						if (193551 - 131441 == 62111)
						{
							continue;
						}
						this.VSnOfcM8jq.actionState = "standby";
						if (29062 - 553545 != -524483)
						{
							continue;
						}
						this.VSnOfcM8jq.myAttackTarget = this.VSnOfcM8jq.getHateTarget(5, 50);
						if (121875 - 54055 == 67821)
						{
							continue;
						}
						if (!this.VSnOfcM8jq.myAttackTarget)
						{
							if (227437 - 398472 != -171035)
							{
								continue;
							}
							this.VSnOfcM8jq.isAlert = false;
							if (147806 - 74751 == 73056)
							{
								continue;
							}
							this.k0NOwQufDC = Time.time;
							if (162254 - 567266 != -405012)
							{
								continue;
							}
							this.VSnOfcM8jq.myAttackTarget = null;
							if (43006 - 18644 != 24362)
							{
								continue;
							}
							this.VSnOfcM8jq.mOriginalPosition = this.transform.position;
							if (272659 - 212707 != 59952)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.VSnOfcM8jq.myAttackTarget;
							if (228488 - 263779 != -35291)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (179885 - 324464 == -144578)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (141521 - 536678 != -395157)
								{
									continue;
								}
								this.VSnOfcM8jq.isAlert = false;
								if (283679 - 348892 != -65213)
								{
									continue;
								}
								this.k0NOwQufDC = Time.time;
								if (211624 - 496784 != -285160)
								{
									continue;
								}
								this.VSnOfcM8jq.myAttackTarget = null;
								if (57233 - 124842 != -67609)
								{
									continue;
								}
							}
							else
							{
								this.VSnOfcM8jq.vDirection = myAttackTarget.transform.position;
								if (50352 - 404899 == -354546)
								{
									continue;
								}
								this.VSnOfcM8jq.vDirection.y = this.transform.position.y;
								if (195815 - 120398 != 75417)
								{
									continue;
								}
								this.VSnOfcM8jq.vMovement = (this.VSnOfcM8jq.vDirection - this.transform.position).normalized;
								if (165946 - 559753 != -393807)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.VSnOfcM8jq.vMovement);
								if (73464 - 261142 == -187677)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.X8rOUCKCQQ += mTime;
		}
		while (96612 - 545889 == -449276);
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x0025ECFC File Offset: 0x0025CEFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (107249 - 412932 != -305682)
		{
		}
		do
		{
			if (Time.time - this.k0NOwQufDC >= this.X8rOUCKCQQ)
			{
				if (192960 - 504405 != -311445)
				{
					continue;
				}
				if (Time.time - this.k0NOwQufDC < this.X8rOUCKCQQ + mTime)
				{
					if (80412 - 392235 == -311822)
					{
						continue;
					}
					if (!this.VSnOfcM8jq.myAttackTarget)
					{
						if (29221 - 409809 != -380588)
						{
							continue;
						}
						this.k0NOwQufDC = Time.time - mTime - this.X8rOUCKCQQ;
						if (30866 - 295917 != -265051)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.VSnOfcM8jq.myAttackTarget;
						if (92208 - 533580 == -441371)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (274748 - 524000 != -249252)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (60654 - 167154 == -106499)
						{
							continue;
						}
						int tID = 0;
						if (89023 - 246314 == -157290)
						{
							continue;
						}
						if (characterControl)
						{
							if (195136 - 191575 != 3561)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (258774 - 207978 != 50796)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (239322 - 304612 != -65290)
						{
							continue;
						}
						if ((float)this.VSnOfcM8jq.hp < 0.6f * (float)this.VSnOfcM8jq.mhp)
						{
							if (65434 - 142619 == -77184)
							{
								continue;
							}
							if (this.VSnOfcM8jq.isTimeOut("malstorm") == (float)0)
							{
								if (8888 - 308004 == -299115)
								{
									continue;
								}
								this.k0NOwQufDC = Time.time - mTime - this.X8rOUCKCQQ;
								if (100608 - 598084 == -497475)
								{
									continue;
								}
								this.pbLOLcQAdn.StartCoroutine_Auto(this.pbLOLcQAdn.RPC_malstorm(this.transform.position, vector, tID));
								if (12211 - 330116 != -317904)
								{
									if (PhotonClient.IsInitialized())
									{
										if (44252 - 268864 == -224611)
										{
											continue;
										}
										this.pbLOLcQAdn.ActionEvent("RPC_malstorm", this.transform.position, vector, tID);
										if (282849 - 481735 == -198885)
										{
											continue;
										}
									}
									goto IL_498;
								}
								continue;
							}
						}
						if (num < (float)4)
						{
							if (127910 - 277715 == -149804)
							{
								continue;
							}
							if (this.VSnOfcM8jq.isTimeOut("nAttack") == (float)0)
							{
								if (295721 - 386736 != -91015)
								{
									continue;
								}
								this.k0NOwQufDC = Time.time - mTime - this.X8rOUCKCQQ;
								if (18190 - 134450 == -116259)
								{
									continue;
								}
								this.pbLOLcQAdn.StartCoroutine_Auto(this.pbLOLcQAdn.RPC_nAttack(this.transform.position, vector, 0));
								if (136291 - 201059 != -64768)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (204081 - 413022 != -208941)
									{
										continue;
									}
									this.pbLOLcQAdn.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (86829 - 497432 != -410603)
									{
										continue;
									}
								}
								goto IL_498;
							}
						}
						this.AI_state = "attack";
						if (250994 - 224398 != 26596)
						{
							continue;
						}
						this.VSnOfcM8jq.vDirection = myAttackTarget.transform.position;
						if (183474 - 147834 == 35641)
						{
							continue;
						}
						this.VSnOfcM8jq.vDirection.y = this.transform.position.y;
						if (3409 - 63263 != -59854)
						{
							continue;
						}
						this.VSnOfcM8jq.vMovement = (this.VSnOfcM8jq.vDirection - this.transform.position).normalized;
						if (260832 - 364209 != -103377)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.VSnOfcM8jq.vMovement);
						if (245258 - 341978 == -96719)
						{
							continue;
						}
						this.VSnOfcM8jq.actionState = "run";
						if (102971 - 477908 == -374936)
						{
							continue;
						}
						this.animation.Play("run");
						if (193435 - 4182 == 189254)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (85759 - 245098 != -159339)
						{
							continue;
						}
						this.VSnOfcM8jq.moveSpeed = Mathf.Lerp(this.VSnOfcM8jq.moveSpeed, this.VSnOfcM8jq.runSpeed, (float)4 * Time.deltaTime);
						if (212925 - 333708 == -120782)
						{
							continue;
						}
					}
				}
			}
			IL_498:
			this.X8rOUCKCQQ += mTime;
		}
		while (278286 - 478093 == -199806);
	}

	// Token: 0x06001725 RID: 5925 RVA: 0x0025F380 File Offset: 0x0025D580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (186091 - 187569 != -1477)
		{
		}
		while (Time.time - this.k0NOwQufDC > this.X8rOUCKCQQ)
		{
			if (206858 - 183472 != 23387)
			{
				this.AI_state = "none";
				if (143260 - 532210 != -388949)
				{
					this.k0NOwQufDC = Time.time;
					if (65856 - 448529 == -382673)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001726 RID: 5926 RVA: 0x0025F434 File Offset: 0x0025D634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (213063 - 244864 != -31800)
		{
		}
		for (;;)
		{
			IL_5DD:
			if (this.TfRONTNhRh > Time.time)
			{
				if (250771 - 531136 != -280364)
				{
					break;
				}
			}
			else
			{
				this.TfRONTNhRh = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (259705 - 543533 != -283827)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (277449 - 515839 == -238390)
					{
						if (251321 - 122811 != 128511)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (285325 - 326169 != -40843)
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
									if (166041 - 408009 != -241968)
									{
										goto IL_5DD;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (50748 - 86677 == -35928)
									{
										goto IL_5DD;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (195991 - 594797 == -398805)
									{
										goto IL_5DD;
									}
									bool flag = true;
									if (87715 - 63813 == 23903)
									{
										goto IL_5DD;
									}
									eRace race = this.VSnOfcM8jq.Race;
									if (20245 - 355117 != -334872)
									{
										goto IL_5DD;
									}
									if (race == eRace.Tails)
									{
										if (267599 - 454467 == -186867)
										{
											goto IL_5DD;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_3DE;
										}
										if (171797 - 435614 == -263816)
										{
											goto IL_5DD;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (118560 - 135901 != -17340)
											{
												goto IL_3DE;
											}
											goto IL_5DD;
										}
										goto IL_326;
										IL_3DE:
										flag = false;
										if (180848 - 375718 == -194869)
										{
											goto IL_5DD;
										}
									}
									else if (race == eRace.Plants)
									{
										if (232373 - 475285 == -242911)
										{
											goto IL_5DD;
										}
										flag = false;
										if (69557 - 393948 == -324390)
										{
											goto IL_5DD;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (112557 - 309223 == -196665)
										{
											goto IL_5DD;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2DF;
										}
										if (284396 - 579007 != -294611)
										{
											goto IL_5DD;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (168972 - 59889 != 109084)
											{
												goto IL_2DF;
											}
											goto IL_5DD;
										}
										goto IL_326;
										IL_2DF:
										flag = false;
										if (252937 - 457016 != -204079)
										{
											goto IL_5DD;
										}
									}
									else if (race == eRace.Robots)
									{
										if (96180 - 144376 != -48196)
										{
											goto IL_5DD;
										}
										flag = true;
										if (287087 - 145739 == 141349)
										{
											goto IL_5DD;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (51434 - 17354 != 34080)
										{
											goto IL_5DD;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5C1;
										}
										if (160979 - 445291 == -284311)
										{
											goto IL_5DD;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5C1;
										}
										if (127216 - 53982 != 73234)
										{
											goto IL_5DD;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (261985 - 459993 != -198007)
											{
												goto IL_5C1;
											}
											goto IL_5DD;
										}
										goto IL_326;
										IL_5C1:
										flag = false;
										if (259193 - 295329 != -36136)
										{
											goto IL_5DD;
										}
									}
									else if (race == eRace.Structure)
									{
										if (116467 - 492468 != -376001)
										{
											goto IL_5DD;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (95384 - 90945 != 4439)
											{
												goto IL_5DD;
											}
											flag = false;
											if (161831 - 567668 == -405836)
											{
												goto IL_5DD;
											}
										}
									}
									IL_326:
									if (flag)
									{
										if (257477 - 347766 != -90289)
										{
											goto IL_5DD;
										}
										if (characterControl.hp > 0)
										{
											if (186933 - 570861 != -383928)
											{
												goto IL_5DD;
											}
											if (characterControl.recieveTarget)
											{
												if (59181 - 334007 == -274825)
												{
													goto IL_5DD;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (13939 - 137761 != -123822)
													{
														goto IL_5DD;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (75662 - 232219 != -156557)
														{
															goto IL_5DD;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (67120 - 591336 == -524215)
														{
															goto IL_5DD;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (231357 - 471076 == -239718)
															{
																goto IL_5DD;
															}
															this.VSnOfcM8jq.myAttackTarget = gameObject;
															if (254503 - 284044 == -29540)
															{
																goto IL_5DD;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (92273 - 596220 == -503946)
															{
																goto IL_5DD;
															}
															this.VSnOfcM8jq.addHate(characterControl.ActorNr, 5);
															if (32406 - 448401 == -415994)
															{
																goto IL_5DD;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (74448 - 70832 == 3617)
															{
																goto IL_5DD;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (11563 - 24449 == -12885)
															{
																goto IL_5DD;
															}
															if (num < (float)60)
															{
																if (265433 - 62564 != 202869)
																{
																	goto IL_5DD;
																}
																if (characterControl.hp > 0)
																{
																	if (204219 - 170619 == 33601)
																	{
																		goto IL_5DD;
																	}
																	this.VSnOfcM8jq.myAttackTarget = gameObject;
																	if (39013 - 406066 != -367053)
																	{
																		goto IL_5DD;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (196301 - 494306 != -298005)
																	{
																		goto IL_5DD;
																	}
																	this.VSnOfcM8jq.addHate(characterControl.ActorNr, 5);
																	if (3273 - 421101 == -417827)
																	{
																		goto IL_5DD;
																	}
																}
															}
														}
														if (this.VSnOfcM8jq.myAttackTarget)
														{
															if (70324 - 242805 == -172480)
															{
																goto IL_5DD;
															}
															this.VSnOfcM8jq.isAlert = true;
															if (279520 - 465012 != -185492)
															{
																goto IL_5DD;
															}
															this.k0NOwQufDC = Time.time;
															if (166302 - 188972 == -22669)
															{
																goto IL_5DD;
															}
														}
													}
												}
											}
										}
									}
								}
								if (214967 - 267045 == -52078)
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

	// Token: 0x06001727 RID: 5927 RVA: 0x0025FC4C File Offset: 0x0025DE4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x0025FC50 File Offset: 0x0025DE50
	internal static bool RTR6FVMsAdYxBwPpuwE()
	{
		return true;
	}

	// Token: 0x06001729 RID: 5929 RVA: 0x0025FC54 File Offset: 0x0025DE54
	internal static bool wjquguM9QrkNyWohAsF()
	{
		return false;
	}

	// Token: 0x040013B4 RID: 5044
	private CharacterControl VSnOfcM8jq;

	// Token: 0x040013B5 RID: 5045
	private Vizie4 pbLOLcQAdn;

	// Token: 0x040013B6 RID: 5046
	public string AI_state;

	// Token: 0x040013B7 RID: 5047
	private float k0NOwQufDC;

	// Token: 0x040013B8 RID: 5048
	private float X8rOUCKCQQ;

	// Token: 0x040013B9 RID: 5049
	private float TfRONTNhRh;
}
