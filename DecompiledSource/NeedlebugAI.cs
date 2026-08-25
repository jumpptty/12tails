using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000105 RID: 261
[Serializable]
public class NeedlebugAI : MonoBehaviour
{
	// Token: 0x060005C4 RID: 1476 RVA: 0x000999F8 File Offset: 0x00097BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NeedlebugAI()
	{
		if (232551 - 552317 != -319766)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (120410 - 106501 == 13909)
			{
				base..ctor();
				if (276429 - 268308 == 8121)
				{
					this.AI_state = "none";
					if (97702 - 410046 == -312344)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x00099A94 File Offset: 0x00097C94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.co5nJPyqxW = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.UFZn6765Ik = (NeedleBug)this.GetComponent(typeof(NeedleBug));
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x00099ACC File Offset: 0x00097CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (204924 - 134412 != 70513)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (81934 - 59381 == 22554)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (163901 - 356938 != -193037)
				{
					continue;
				}
			}
			if (this.co5nJPyqxW.isControlled)
			{
				break;
			}
			if (139587 - 64854 != 74734)
			{
				this.AIControl();
				if (188868 - 144420 == 44448)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00099B98 File Offset: 0x00097D98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (165506 - 291233 != -125727)
		{
		}
		for (;;)
		{
			this.GpfnXehQE3 = (float)0;
			if (6230 - 195986 != -189755)
			{
				if (this.co5nJPyqxW.isMine)
				{
					if (175923 - 47054 != 128870)
					{
						if (this.co5nJPyqxW.actionState != "standby")
						{
							if (233497 - 394921 != -161424)
							{
								continue;
							}
							if (this.co5nJPyqxW.actionState != "run")
							{
								if (71858 - 581796 != -509937)
								{
									break;
								}
								continue;
							}
						}
						if (!this.co5nJPyqxW.isAlert)
						{
							if (19663 - 377688 == -358025)
							{
								this.AI_idle(3f, 1f);
								if (296609 - 504670 == -208061)
								{
									this.AI_patrol(1f, 0.25f);
									if (124081 - 183815 != -59733)
									{
										this.AI_resetTimer();
										if (179878 - 596093 != -416214)
										{
											this.AI_visionCheck();
											if (250380 - 422434 == -172054)
											{
												if (!this.co5nJPyqxW.myAttackTarget)
												{
													break;
												}
												if (217644 - 108900 == 108744)
												{
													this.co5nJPyqxW.isAlert = true;
													if (151992 - 566055 != -414062)
													{
														this.nx4nt49fxH = Time.time;
														if (299408 - 542743 != -243334)
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
							if (250585 - 519270 != -268684)
							{
								this.AI_attack(5f, (float)0);
								if (294696 - 311696 == -17000)
								{
									this.AI_resetTimer();
									if (132488 - 165136 != -32647)
									{
										break;
									}
								}
							}
						}
					}
				}
				else
				{
					if (this.co5nJPyqxW.actionState != "standby")
					{
						if (235683 - 482544 == -246860)
						{
							continue;
						}
						if (this.co5nJPyqxW.actionState != "run")
						{
							if (291349 - 521791 != -230441)
							{
								break;
							}
							continue;
						}
					}
					if (this.co5nJPyqxW.nSpeed != (float)0)
					{
						if (99006 - 223381 == -124374)
						{
							continue;
						}
						if (this.co5nJPyqxW.nPosition != this.co5nJPyqxW.oPosition)
						{
							if (72319 - 322543 != -250224)
							{
								continue;
							}
							Vector3 a = this.co5nJPyqxW.nPosition + 0.1f * this.co5nJPyqxW.runSpeed * this.co5nJPyqxW.nDirection;
							if (47415 - 393449 != -346034)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (24799 - 342600 != -317801)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (254648 - 303484 != -48836)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (159104 - 137988 == 21117)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (191718 - 7426 == 184293)
							{
								continue;
							}
							if (magnitude > this.co5nJPyqxW.runSpeed)
							{
								if (179021 - 580305 == -401283)
								{
									continue;
								}
								this.transform.position = this.co5nJPyqxW.nPosition;
								if (42402 - 384194 != -341792)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.co5nJPyqxW.runSpeed)
							{
								if (101821 - 13000 != 88821)
								{
									continue;
								}
								this.co5nJPyqxW.moveSpeed = Mathf.Lerp(this.co5nJPyqxW.moveSpeed, 1.1f * this.co5nJPyqxW.runSpeed, (float)10 * Time.deltaTime);
								if (263904 - 411648 != -147744)
								{
									continue;
								}
								this.co5nJPyqxW.vDirection = normalized;
								if (287990 - 309094 != -21104)
								{
									continue;
								}
								this.co5nJPyqxW.vMovement = normalized;
								if (123552 - 372047 == -248494)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (240672 - 490831 == -250158)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (112867 - 188054 != -75187)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (89387 - 408257 != -318870)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (33356 - 247158 == -213801)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (163775 - 76829 != 86947)
								{
									break;
								}
								continue;
							}
							else
							{
								this.co5nJPyqxW.moveSpeed = Mathf.Lerp(this.co5nJPyqxW.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (101121 - 498761 != -397640)
								{
									continue;
								}
								this.co5nJPyqxW.vDirection = normalized;
								if (268664 - 526399 != -257735)
								{
									continue;
								}
								this.co5nJPyqxW.vMovement = normalized;
								if (177533 - 236198 == -58664)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (43717 - 168261 == -124543)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (277782 - 434146 != -156363)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.co5nJPyqxW.moveSpeed != (float)0)
					{
						if (212480 - 25966 == 186514)
						{
							Vector3 vector3 = global::Math.vFlat(this.co5nJPyqxW.nPosition - this.transform.position);
							if (240747 - 566081 != -325333)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (155771 - 470654 != -314882)
								{
									if (sqrMagnitude > this.co5nJPyqxW.runSpeed)
									{
										if (176819 - 276556 != -99736)
										{
											this.transform.position = this.co5nJPyqxW.nPosition;
											if (69654 - 440538 == -370884)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (22214 - 402019 != -379804)
										{
											if (sqrMagnitude > (float)1)
											{
												if (148482 - 476573 != -328091)
												{
													continue;
												}
												this.co5nJPyqxW.moveSpeed = Mathf.Lerp(this.co5nJPyqxW.moveSpeed, this.co5nJPyqxW.runSpeed, (float)10 * Time.deltaTime);
												if (181009 - 153399 == 27611)
												{
													continue;
												}
											}
											else
											{
												this.co5nJPyqxW.moveSpeed = Mathf.Lerp(this.co5nJPyqxW.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (187704 - 326326 == -138621)
												{
													continue;
												}
											}
											this.co5nJPyqxW.vMovement = vector3;
											if (176765 - 193400 != -16634)
											{
												this.co5nJPyqxW.vDirection = vector3;
												if (294878 - 513100 != -218221)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (43616 - 504123 == -460507)
													{
														this.animation.CrossFade("run", 0.2f);
														if (74988 - 508944 != -433955)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (37907 - 575924 == -538017)
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
										this.co5nJPyqxW.vMovement = vector3;
										if (250929 - 114432 != 136498)
										{
											this.co5nJPyqxW.moveSpeed = (float)0;
											if (60175 - 541202 != -481026)
											{
												this.transform.rotation = Quaternion.LookRotation(this.co5nJPyqxW.vDirection);
												if (216625 - 154061 != 62565)
												{
													this.animation.CrossFade("root", 0.2f);
													if (248795 - 445920 == -197125)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (184205 - 137322 != 46884)
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
						if (281205 - 566844 == -285639)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (237048 - 351989 != -114940)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x0009A6F0 File Offset: 0x000988F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (111070 - 28358 != 82713)
		{
		}
		do
		{
			if (Time.time - this.nx4nt49fxH >= this.GpfnXehQE3)
			{
				if (151329 - 529238 != -377909)
				{
					continue;
				}
				if (Time.time - this.nx4nt49fxH < this.GpfnXehQE3 + mTime)
				{
					if (247014 - 151316 == 95699)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (159323 - 66423 != 92900)
						{
							continue;
						}
						this.AI_state = "idle";
						if (204973 - 328181 == -123207)
						{
							continue;
						}
						this.nx4nt49fxH -= UnityEngine.Random.Range((float)0, rTimer);
						if (260019 - 137626 == 122394)
						{
							continue;
						}
						this.co5nJPyqxW.vDirection = Vector3.zero;
						if (36681 - 495105 != -458424)
						{
							continue;
						}
						this.co5nJPyqxW.vMovement = this.transform.forward;
						if (260662 - 396015 == -135352)
						{
							continue;
						}
						this.co5nJPyqxW.actionState = "standby";
						if (235444 - 232940 != 2504)
						{
							continue;
						}
					}
					this.co5nJPyqxW.moveSpeed = Mathf.Lerp(this.co5nJPyqxW.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (3944 - 316833 == -312888)
					{
						continue;
					}
					if (this.co5nJPyqxW.moveSpeed < 0.1f * this.co5nJPyqxW.runSpeed)
					{
						if (280256 - 2807 != 277449)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (28828 - 483582 != -454754)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (215543 - 234051 == -18507)
						{
							continue;
						}
						this.co5nJPyqxW.moveSpeed = (float)0;
						if (207431 - 274800 == -67368)
						{
							continue;
						}
					}
				}
			}
			this.GpfnXehQE3 += mTime;
		}
		while (208591 - 36898 != 171693);
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0009A9B4 File Offset: 0x00098BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (225941 - 38255 != 187686)
		{
		}
		do
		{
			if (Time.time - this.nx4nt49fxH >= this.GpfnXehQE3)
			{
				if (40748 - 335911 == -295162)
				{
					continue;
				}
				if (Time.time - this.nx4nt49fxH < this.GpfnXehQE3 + mTime)
				{
					if (204705 - 378910 == -174204)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (220117 - 229055 != -8938)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (130744 - 299993 != -169249)
						{
							continue;
						}
						this.nx4nt49fxH -= UnityEngine.Random.Range((float)0, rTimer);
						if (52667 - 484765 != -432098)
						{
							continue;
						}
						this.co5nJPyqxW.vDirection = this.co5nJPyqxW.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (85698 - 558732 == -473033)
						{
							continue;
						}
						this.co5nJPyqxW.vDirection.y = this.transform.position.y;
						if (228976 - 306094 != -77118)
						{
							continue;
						}
						this.co5nJPyqxW.vMovement = (this.co5nJPyqxW.vDirection - this.transform.position).normalized;
						if (251981 - 117015 == 134967)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.co5nJPyqxW.vMovement);
						if (54913 - 473116 == -418202)
						{
							continue;
						}
						this.co5nJPyqxW.actionState = "run";
						if (270171 - 52166 != 218005)
						{
							continue;
						}
						this.animation.Play("run");
						if (113839 - 507110 == -393270)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (76032 - 13463 != 62569)
						{
							continue;
						}
					}
					this.co5nJPyqxW.moveSpeed = Mathf.Lerp(this.co5nJPyqxW.moveSpeed, this.co5nJPyqxW.runSpeed, (float)4 * Time.deltaTime);
					if (118461 - 96070 == 22392)
					{
						continue;
					}
				}
			}
			this.GpfnXehQE3 += mTime;
		}
		while (241531 - 60443 != 181088);
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0009ACBC File Offset: 0x00098EBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (131342 - 529585 != -398243)
		{
		}
		do
		{
			if (Time.time - this.nx4nt49fxH >= this.GpfnXehQE3)
			{
				if (73730 - 553323 != -479593)
				{
					continue;
				}
				if (Time.time - this.nx4nt49fxH < this.GpfnXehQE3 + mTime)
				{
					if (150883 - 546704 != -395821)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (140480 - 567152 != -426672)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (140678 - 28576 == 112103)
						{
							continue;
						}
						this.nx4nt49fxH = Time.time - mTime - this.GpfnXehQE3;
						if (146453 - 210479 == -64025)
						{
							continue;
						}
						this.co5nJPyqxW.vDirection = Vector3.zero;
						if (242842 - 288462 != -45620)
						{
							continue;
						}
						this.co5nJPyqxW.vMovement = this.transform.forward;
						if (227708 - 457532 == -229823)
						{
							continue;
						}
						this.co5nJPyqxW.actionState = "standby";
						if (105113 - 543013 == -437899)
						{
							continue;
						}
						this.co5nJPyqxW.myAttackTarget = this.co5nJPyqxW.getHateTarget(3, 5);
						if (33779 - 503826 != -470047)
						{
							continue;
						}
						if (!this.co5nJPyqxW.myAttackTarget)
						{
							if (236198 - 186435 == 49764)
							{
								continue;
							}
							this.co5nJPyqxW.isAlert = false;
							if (266218 - 208274 == 57945)
							{
								continue;
							}
							this.nx4nt49fxH = Time.time;
							if (246680 - 193552 == 53129)
							{
								continue;
							}
							this.co5nJPyqxW.myAttackTarget = null;
							if (224213 - 260877 != -36664)
							{
								continue;
							}
							this.co5nJPyqxW.mOriginalPosition = this.transform.position;
							if (243512 - 496017 != -252505)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.co5nJPyqxW.myAttackTarget;
							if (118982 - 473574 != -354592)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (114665 - 161523 == -46857)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (72100 - 348342 != -276242)
								{
									continue;
								}
								this.co5nJPyqxW.isAlert = false;
								if (72090 - 121595 != -49505)
								{
									continue;
								}
								this.nx4nt49fxH = Time.time;
								if (96753 - 180202 != -83449)
								{
									continue;
								}
								this.co5nJPyqxW.myAttackTarget = null;
								if (208328 - 232079 == -23750)
								{
									continue;
								}
							}
							else
							{
								this.co5nJPyqxW.vDirection = myAttackTarget.transform.position;
								if (159872 - 22503 == 137370)
								{
									continue;
								}
								this.co5nJPyqxW.vDirection.y = this.transform.position.y;
								if (130978 - 308684 == -177705)
								{
									continue;
								}
								this.co5nJPyqxW.vMovement = (this.co5nJPyqxW.vDirection - this.transform.position).normalized;
								if (189789 - 544539 == -354749)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.co5nJPyqxW.vMovement);
								if (162884 - 323828 != -160944)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.GpfnXehQE3 += mTime;
		}
		while (155629 - 586448 != -430819);
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x0009B16C File Offset: 0x0009936C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (105293 - 69950 != 35343)
		{
		}
		do
		{
			if (Time.time - this.nx4nt49fxH >= this.GpfnXehQE3)
			{
				if (29086 - 328285 == -299198)
				{
					continue;
				}
				if (Time.time - this.nx4nt49fxH < this.GpfnXehQE3 + mTime)
				{
					if (175199 - 5124 == 170076)
					{
						continue;
					}
					if (!this.co5nJPyqxW.myAttackTarget)
					{
						if (55717 - 445209 == -389491)
						{
							continue;
						}
						this.nx4nt49fxH = Time.time - mTime - this.GpfnXehQE3;
						if (260034 - 409767 != -149733)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.co5nJPyqxW.myAttackTarget;
						if (231709 - 119546 != 112163)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (121998 - 232375 == -110376)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (230660 - 286308 == -55647)
						{
							continue;
						}
						if (num < (float)4)
						{
							if (126249 - 23942 == 102308)
							{
								continue;
							}
							if (this.co5nJPyqxW.isTimeOut("nAttack") == (float)0)
							{
								if (276674 - 214155 == 62520)
								{
									continue;
								}
								this.nx4nt49fxH = Time.time - mTime - this.GpfnXehQE3;
								if (49280 - 9508 != 39772)
								{
									continue;
								}
								if (UnityEngine.Random.Range(0, 100) <= 65)
								{
									if (14617 - 179301 != -164684)
									{
										continue;
									}
									this.UFZn6765Ik.StartCoroutine_Auto(this.UFZn6765Ik.RPC_needleFlip(this.transform.position, vector, 0));
									if (282850 - 126522 == 156329)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (251635 - 474320 == -222684)
										{
											continue;
										}
										this.UFZn6765Ik.ActionEvent("RPC_needleFlip", this.transform.position, vector, 0);
										if (254509 - 512693 == -258183)
										{
											continue;
										}
									}
								}
								else
								{
									this.UFZn6765Ik.StartCoroutine_Auto(this.UFZn6765Ik.RPC_needleSpray(this.transform.position, vector, 0));
									if (289208 - 211962 == 77247)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (138998 - 498242 == -359243)
										{
											continue;
										}
										this.UFZn6765Ik.ActionEvent("RPC_needleSpray", this.transform.position, vector, 0);
										if (128128 - 598389 != -470261)
										{
											continue;
										}
									}
								}
								goto IL_2BE;
							}
						}
						this.AI_state = "attack";
						if (35478 - 455470 != -419992)
						{
							continue;
						}
						this.co5nJPyqxW.vDirection = myAttackTarget.transform.position;
						if (236483 - 538937 != -302454)
						{
							continue;
						}
						this.co5nJPyqxW.vDirection.y = this.transform.position.y;
						if (123745 - 459500 != -335755)
						{
							continue;
						}
						this.co5nJPyqxW.vMovement = (this.co5nJPyqxW.vDirection - this.transform.position).normalized;
						if (125755 - 468187 != -342432)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.co5nJPyqxW.vMovement);
						if (55409 - 136169 == -80759)
						{
							continue;
						}
						this.co5nJPyqxW.actionState = "run";
						if (180011 - 576122 != -396111)
						{
							continue;
						}
						this.animation.CrossFade("run");
						if (74039 - 166971 == -92931)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (136905 - 136182 != 723)
						{
							continue;
						}
						this.co5nJPyqxW.moveSpeed = Mathf.Lerp(this.co5nJPyqxW.moveSpeed, this.co5nJPyqxW.runSpeed, (float)4 * Time.deltaTime);
						if (275129 - 12628 != 262501)
						{
							continue;
						}
					}
				}
			}
			IL_2BE:
			this.GpfnXehQE3 += mTime;
		}
		while (200615 - 277104 != -76489);
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x0009B6E8 File Offset: 0x000998E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (267601 - 553050 != -285449)
		{
		}
		while (Time.time - this.nx4nt49fxH > this.GpfnXehQE3)
		{
			if (155760 - 421299 == -265539)
			{
				this.AI_state = "none";
				if (148979 - 397103 == -248124)
				{
					this.nx4nt49fxH = Time.time;
					if (60973 - 182628 != -121654)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0009B79C File Offset: 0x0009999C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (226088 - 468276 != -242188)
		{
		}
		for (;;)
		{
			IL_257:
			if (this.NlLnO4fh2h + (float)1 > Time.time)
			{
				if (63270 - 362583 == -299313)
				{
					break;
				}
			}
			else
			{
				this.NlLnO4fh2h = Time.time;
				if (90056 - 349780 != -259723)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)10, this.gameObject.layer);
					if (256963 - 221521 == 35442)
					{
						if (92107 - 391120 != -299012)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (2895 - 313156 == -310261)
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
									if (74772 - 598934 == -524161)
									{
										goto IL_257;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (29259 - 203310 != -174051)
									{
										goto IL_257;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (103934 - 597103 != -493169)
									{
										goto IL_257;
									}
									bool flag = true;
									if (83836 - 360657 == -276820)
									{
										goto IL_257;
									}
									eRace race = this.co5nJPyqxW.Race;
									if (176562 - 306350 == -129787)
									{
										goto IL_257;
									}
									if (race == eRace.Tails)
									{
										if (216153 - 289766 == -73612)
										{
											goto IL_257;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_63E;
										}
										if (88301 - 247370 == -159068)
										{
											goto IL_257;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (55934 - 395718 != -339783)
											{
												goto IL_63E;
											}
											goto IL_257;
										}
										goto IL_5B5;
										IL_63E:
										flag = false;
										if (91777 - 432838 != -341061)
										{
											goto IL_257;
										}
									}
									else if (race == eRace.Plants)
									{
										if (249153 - 45559 != 203594)
										{
											goto IL_257;
										}
										flag = false;
										if (262623 - 505108 != -242485)
										{
											goto IL_257;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (17115 - 130698 == -113582)
										{
											goto IL_257;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_7B4;
										}
										if (238974 - 45804 != 193170)
										{
											goto IL_257;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (20877 - 449843 != -428965)
											{
												goto IL_7B4;
											}
											goto IL_257;
										}
										goto IL_5B5;
										IL_7B4:
										flag = false;
										if (37437 - 323393 != -285956)
										{
											goto IL_257;
										}
									}
									else if (race == eRace.Robots)
									{
										if (249121 - 207151 == 41971)
										{
											goto IL_257;
										}
										flag = true;
										if (179600 - 542119 == -362518)
										{
											goto IL_257;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (184484 - 56107 != 128377)
										{
											goto IL_257;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5D5;
										}
										if (78719 - 429670 != -350951)
										{
											goto IL_257;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5D5;
										}
										if (46048 - 845 == 45204)
										{
											goto IL_257;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (101061 - 106229 != -5167)
											{
												goto IL_5D5;
											}
											goto IL_257;
										}
										goto IL_5B5;
										IL_5D5:
										flag = false;
										if (273488 - 203470 != 70018)
										{
											goto IL_257;
										}
									}
									else if (race == eRace.Structure)
									{
										if (35962 - 570965 != -535003)
										{
											goto IL_257;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (262754 - 299109 == -36354)
											{
												goto IL_257;
											}
											flag = false;
											if (194030 - 581468 == -387437)
											{
												goto IL_257;
											}
										}
									}
									IL_5B5:
									if (flag)
									{
										if (40726 - 42601 == -1874)
										{
											goto IL_257;
										}
										if (characterControl.hp > 0)
										{
											if (213311 - 343282 == -129970)
											{
												goto IL_257;
											}
											if (characterControl.recieveTarget)
											{
												if (19088 - 342849 != -323761)
												{
													goto IL_257;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (252206 - 321377 != -69171)
													{
														goto IL_257;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (14650 - 225905 == -211254)
														{
															goto IL_257;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (270264 - 547285 == -277020)
														{
															goto IL_257;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (192825 - 154917 != 37908)
															{
																goto IL_257;
															}
															this.co5nJPyqxW.isAlert = true;
															if (171861 - 254812 != -82951)
															{
																goto IL_257;
															}
															this.nx4nt49fxH = Time.time;
															if (287395 - 208741 != 78654)
															{
																goto IL_257;
															}
															this.co5nJPyqxW.myAttackTarget = gameObject;
															if (174835 - 343867 != -169032)
															{
																goto IL_257;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (60505 - 105411 == -44905)
															{
																goto IL_257;
															}
															this.co5nJPyqxW.addHate(characterControl.ActorNr, 5);
															if (132092 - 187310 == -55217)
															{
																goto IL_257;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (105150 - 546985 != -441835)
															{
																goto IL_257;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (100034 - 506769 != -406735)
															{
																goto IL_257;
															}
															if (num < (float)60)
															{
																if (4198 - 413165 == -408966)
																{
																	goto IL_257;
																}
																if (characterControl.hp > 0)
																{
																	if (124089 - 457031 != -332942)
																	{
																		goto IL_257;
																	}
																	this.co5nJPyqxW.isAlert = true;
																	if (67500 - 185383 == -117882)
																	{
																		goto IL_257;
																	}
																	this.nx4nt49fxH = Time.time;
																	if (73529 - 477852 == -404322)
																	{
																		goto IL_257;
																	}
																	this.co5nJPyqxW.myAttackTarget = gameObject;
																	if (216476 - 268068 == -51591)
																	{
																		goto IL_257;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (60935 - 212312 != -151377)
																	{
																		goto IL_257;
																	}
																	this.co5nJPyqxW.addHate(characterControl.ActorNr, 5);
																	if (93566 - 302390 == -208823)
																	{
																		goto IL_257;
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
								if (78794 - 417531 != -338736)
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

	// Token: 0x060005CE RID: 1486 RVA: 0x0009BFC4 File Offset: 0x0009A1C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x0009BFC8 File Offset: 0x0009A1C8
	internal static bool I8eTB5UZr66AnVOJQed()
	{
		return true;
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x0009BFCC File Offset: 0x0009A1CC
	internal static bool MdMe81UC1WUmsPtTS2I()
	{
		return false;
	}

	// Token: 0x04000565 RID: 1381
	private CharacterControl co5nJPyqxW;

	// Token: 0x04000566 RID: 1382
	private NeedleBug UFZn6765Ik;

	// Token: 0x04000567 RID: 1383
	public string AI_state;

	// Token: 0x04000568 RID: 1384
	private float nx4nt49fxH;

	// Token: 0x04000569 RID: 1385
	private float GpfnXehQE3;

	// Token: 0x0400056A RID: 1386
	private float NlLnO4fh2h;
}
