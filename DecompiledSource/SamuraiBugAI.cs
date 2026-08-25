using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001CE RID: 462
[Serializable]
public class SamuraiBugAI : MonoBehaviour
{
	// Token: 0x06000A54 RID: 2644 RVA: 0x00108250 File Offset: 0x00106450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SamuraiBugAI()
	{
		if (270402 - 130111 != 140292)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (218432 - 411864 == -193432)
			{
				base..ctor();
				if (6938 - 349544 == -342606)
				{
					this.AI_state = "none";
					if (151003 - 511836 == -360833)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x001082EC File Offset: 0x001064EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.xtaQFsK5lm = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.eAZQACrjR4 = (SamuraiBug)this.GetComponent(typeof(SamuraiBug));
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x00108324 File Offset: 0x00106524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (165163 - 266584 != -101421)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (134215 - 294239 == -160023)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (182668 - 505010 != -322342)
				{
					continue;
				}
			}
			if (this.xtaQFsK5lm.isControlled)
			{
				break;
			}
			if (124451 - 572694 == -448243)
			{
				this.AIControl();
				if (228953 - 146533 == 82420)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x001083F0 File Offset: 0x001065F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (296528 - 477533 != -181005)
		{
		}
		for (;;)
		{
			this.FCaQWmV1nJ = (float)0;
			if (96569 - 531028 != -434458)
			{
				if (this.xtaQFsK5lm.isMine)
				{
					if (254627 - 425335 == -170708)
					{
						if (this.xtaQFsK5lm.actionState != "standby")
						{
							if (245068 - 169541 != 75527)
							{
								continue;
							}
							if (this.xtaQFsK5lm.actionState != "run")
							{
								if (58320 - 529064 != -470743)
								{
									break;
								}
								continue;
							}
						}
						if (!this.xtaQFsK5lm.isAlert)
						{
							if (160971 - 356619 != -195647)
							{
								this.AI_idle(3f, 1f);
								if (116585 - 36456 == 80129)
								{
									this.AI_patrol(1f, 0.25f);
									if (136376 - 569838 == -433462)
									{
										this.AI_resetTimer();
										if (228939 - 172467 == 56472)
										{
											this.AI_visionCheck();
											if (23535 - 119831 == -96296)
											{
												if (!this.xtaQFsK5lm.myAttackTarget)
												{
													break;
												}
												if (54718 - 342104 == -287386)
												{
													this.xtaQFsK5lm.isAlert = true;
													if (293112 - 220985 == 72127)
													{
														this.MNNQ9pMvvE = Time.time;
														if (262288 - 523402 != -261113)
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
							if (43708 - 275913 == -232205)
							{
								this.AI_idle(3f, 1f);
								if (76759 - 16120 != 60640)
								{
									this.AI_attack(10f, (float)0);
									if (180919 - 508333 == -327414)
									{
										this.AI_resetTimer();
										if (195363 - 112331 == 83032)
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
					if (this.xtaQFsK5lm.actionState != "standby")
					{
						if (157401 - 333806 != -176405)
						{
							continue;
						}
						if (this.xtaQFsK5lm.actionState != "run")
						{
							if (269539 - 542721 != -273182)
							{
								continue;
							}
							break;
						}
					}
					if (this.xtaQFsK5lm.nSpeed != (float)0)
					{
						if (33957 - 578472 == -544514)
						{
							continue;
						}
						if (this.xtaQFsK5lm.nPosition != this.xtaQFsK5lm.oPosition)
						{
							if (281301 - 143220 == 138082)
							{
								continue;
							}
							Vector3 a = this.xtaQFsK5lm.nPosition + 0.1f * this.xtaQFsK5lm.runSpeed * this.xtaQFsK5lm.nDirection;
							if (113334 - 469312 == -355977)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (42483 - 579302 == -536818)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (121056 - 166019 != -44963)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (48070 - 85181 != -37111)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (63105 - 123617 != -60512)
							{
								continue;
							}
							if (magnitude > this.xtaQFsK5lm.runSpeed)
							{
								if (120752 - 372878 != -252126)
								{
									continue;
								}
								this.transform.position = this.xtaQFsK5lm.nPosition;
								if (68940 - 25645 != 43296)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.xtaQFsK5lm.runSpeed)
							{
								if (243031 - 202098 == 40934)
								{
									continue;
								}
								this.xtaQFsK5lm.moveSpeed = Mathf.Lerp(this.xtaQFsK5lm.moveSpeed, 1.1f * this.xtaQFsK5lm.runSpeed, (float)10 * Time.deltaTime);
								if (274531 - 144029 != 130502)
								{
									continue;
								}
								this.xtaQFsK5lm.vDirection = normalized;
								if (289797 - 146647 != 143150)
								{
									continue;
								}
								this.xtaQFsK5lm.vMovement = normalized;
								if (191036 - 37109 != 153927)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (228565 - 160628 != 67937)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (270807 - 269859 != 948)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (256181 - 324153 == -67971)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (187114 - 364348 != -177234)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (108628 - 371890 != -263261)
								{
									break;
								}
								continue;
							}
							else
							{
								this.xtaQFsK5lm.moveSpeed = Mathf.Lerp(this.xtaQFsK5lm.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (172441 - 224454 != -52013)
								{
									continue;
								}
								this.xtaQFsK5lm.vDirection = normalized;
								if (162116 - 99768 != 62348)
								{
									continue;
								}
								this.xtaQFsK5lm.vMovement = normalized;
								if (239065 - 567022 == -327956)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (283474 - 135676 == 147799)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (153518 - 217566 != -64048)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.xtaQFsK5lm.moveSpeed != (float)0)
					{
						if (32165 - 369346 != -337180)
						{
							Vector3 vector3 = global::Math.vFlat(this.xtaQFsK5lm.nPosition - this.transform.position);
							if (201249 - 87145 != 114105)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (9989 - 299097 != -289107)
								{
									if (sqrMagnitude > this.xtaQFsK5lm.runSpeed)
									{
										if (209030 - 321938 != -112907)
										{
											this.transform.position = this.xtaQFsK5lm.nPosition;
											if (91421 - 51 != 91371)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (163715 - 524531 != -360815)
										{
											if (sqrMagnitude > (float)1)
											{
												if (189004 - 327860 != -138856)
												{
													continue;
												}
												this.xtaQFsK5lm.moveSpeed = Mathf.Lerp(this.xtaQFsK5lm.moveSpeed, this.xtaQFsK5lm.runSpeed, (float)10 * Time.deltaTime);
												if (139824 - 346616 == -206791)
												{
													continue;
												}
											}
											else
											{
												this.xtaQFsK5lm.moveSpeed = Mathf.Lerp(this.xtaQFsK5lm.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (146966 - 305442 == -158475)
												{
													continue;
												}
											}
											this.xtaQFsK5lm.vMovement = vector3;
											if (159639 - 446374 != -286734)
											{
												this.xtaQFsK5lm.vDirection = vector3;
												if (15201 - 169355 == -154154)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (265606 - 94637 != 170970)
													{
														this.animation.CrossFade("run", 0.2f);
														if (132047 - 391782 != -259734)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (32277 - 57893 == -25616)
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
										this.xtaQFsK5lm.vMovement = vector3;
										if (109621 - 70948 == 38673)
										{
											this.xtaQFsK5lm.moveSpeed = (float)0;
											if (30512 - 71224 == -40712)
											{
												this.transform.rotation = Quaternion.LookRotation(this.xtaQFsK5lm.vDirection);
												if (243549 - 359773 != -116223)
												{
													this.animation.CrossFade("root", 0.2f);
													if (275345 - 314775 == -39430)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (294347 - 379356 != -85008)
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
						if (110924 - 481802 != -370877)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (36582 - 296491 == -259909)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x00108F70 File Offset: 0x00107170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (224874 - 372715 != -147841)
		{
		}
		do
		{
			if (Time.time - this.MNNQ9pMvvE >= this.FCaQWmV1nJ)
			{
				if (141740 - 534102 == -392361)
				{
					continue;
				}
				if (Time.time - this.MNNQ9pMvvE < this.FCaQWmV1nJ + mTime)
				{
					if (27587 - 566842 == -539254)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (100076 - 52901 == 47176)
						{
							continue;
						}
						this.AI_state = "idle";
						if (127820 - 19748 == 108073)
						{
							continue;
						}
						this.MNNQ9pMvvE -= UnityEngine.Random.Range((float)0, rTimer);
						if (4361 - 585733 != -581372)
						{
							continue;
						}
						this.xtaQFsK5lm.vDirection = Vector3.zero;
						if (181397 - 221016 != -39619)
						{
							continue;
						}
						this.xtaQFsK5lm.vMovement = this.transform.forward;
						if (189665 - 257411 != -67746)
						{
							continue;
						}
						this.xtaQFsK5lm.actionState = "standby";
						if (156869 - 554145 == -397275)
						{
							continue;
						}
					}
					this.xtaQFsK5lm.moveSpeed = Mathf.Lerp(this.xtaQFsK5lm.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (299450 - 372696 == -73245)
					{
						continue;
					}
					if (this.xtaQFsK5lm.moveSpeed < 0.1f * this.xtaQFsK5lm.runSpeed)
					{
						if (269946 - 92769 == 177178)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (135781 - 159005 != -23224)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (191136 - 147563 != 43573)
						{
							continue;
						}
						this.xtaQFsK5lm.moveSpeed = (float)0;
						if (274976 - 361026 != -86050)
						{
							continue;
						}
					}
				}
			}
			this.FCaQWmV1nJ += mTime;
		}
		while (98532 - 347073 == -248540);
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00109234 File Offset: 0x00107434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (129017 - 160225 != -31207)
		{
		}
		do
		{
			if (Time.time - this.MNNQ9pMvvE >= this.FCaQWmV1nJ)
			{
				if (58823 - 368244 != -309421)
				{
					continue;
				}
				if (Time.time - this.MNNQ9pMvvE < this.FCaQWmV1nJ + mTime)
				{
					if (245111 - 267025 == -21913)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (243409 - 201160 == 42250)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (221887 - 520614 == -298726)
						{
							continue;
						}
						this.MNNQ9pMvvE -= UnityEngine.Random.Range((float)0, rTimer);
						if (254325 - 385761 == -131435)
						{
							continue;
						}
						this.xtaQFsK5lm.vDirection = this.xtaQFsK5lm.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (25422 - 595275 == -569852)
						{
							continue;
						}
						this.xtaQFsK5lm.vDirection.y = this.transform.position.y;
						if (47130 - 412508 != -365378)
						{
							continue;
						}
						this.xtaQFsK5lm.vMovement = (this.xtaQFsK5lm.vDirection - this.transform.position).normalized;
						if (212211 - 81529 != 130682)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.xtaQFsK5lm.vMovement);
						if (71385 - 137020 != -65635)
						{
							continue;
						}
						this.xtaQFsK5lm.actionState = "run";
						if (175677 - 588087 == -412409)
						{
							continue;
						}
						this.animation.Play("run");
						if (286248 - 99091 == 187158)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (15282 - 539815 != -524533)
						{
							continue;
						}
					}
					this.xtaQFsK5lm.moveSpeed = Mathf.Lerp(this.xtaQFsK5lm.moveSpeed, this.xtaQFsK5lm.runSpeed, (float)4 * Time.deltaTime);
					if (91947 - 41663 != 50284)
					{
						continue;
					}
				}
			}
			this.FCaQWmV1nJ += mTime;
		}
		while (261832 - 76403 == 185430);
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x0010953C File Offset: 0x0010773C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (124348 - 473764 != -349416)
		{
		}
		do
		{
			if (Time.time - this.MNNQ9pMvvE >= this.FCaQWmV1nJ)
			{
				if (281533 - 282671 == -1137)
				{
					continue;
				}
				if (Time.time - this.MNNQ9pMvvE < this.FCaQWmV1nJ + mTime)
				{
					if (232398 - 507446 != -275048)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (291079 - 446339 == -155259)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (189515 - 154967 == 34549)
						{
							continue;
						}
						this.MNNQ9pMvvE = Time.time - mTime - this.FCaQWmV1nJ;
						if (136292 - 54388 == 81905)
						{
							continue;
						}
						this.xtaQFsK5lm.vDirection = Vector3.zero;
						if (164642 - 348672 != -184030)
						{
							continue;
						}
						this.xtaQFsK5lm.vMovement = this.transform.forward;
						if (45670 - 222170 == -176499)
						{
							continue;
						}
						this.xtaQFsK5lm.actionState = "standby";
						if (183953 - 293638 != -109685)
						{
							continue;
						}
						this.xtaQFsK5lm.myAttackTarget = this.xtaQFsK5lm.getHateTarget(5, 50);
						if (142832 - 110284 == 32549)
						{
							continue;
						}
						if (!this.xtaQFsK5lm.myAttackTarget)
						{
							if (74952 - 199041 == -124088)
							{
								continue;
							}
							this.xtaQFsK5lm.isAlert = false;
							if (62303 - 389275 == -326971)
							{
								continue;
							}
							this.MNNQ9pMvvE = Time.time;
							if (171927 - 573823 != -401896)
							{
								continue;
							}
							this.xtaQFsK5lm.myAttackTarget = null;
							if (27043 - 124413 != -97370)
							{
								continue;
							}
							this.xtaQFsK5lm.mOriginalPosition = this.transform.position;
							if (257918 - 201986 != 55933)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.xtaQFsK5lm.myAttackTarget;
							if (143975 - 74908 != 69067)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (238811 - 188733 == 50079)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (288371 - 274373 != 13998)
								{
									continue;
								}
								this.xtaQFsK5lm.isAlert = false;
								if (170854 - 585125 == -414270)
								{
									continue;
								}
								this.MNNQ9pMvvE = Time.time;
								if (168020 - 156818 == 11203)
								{
									continue;
								}
								this.xtaQFsK5lm.myAttackTarget = null;
								if (156537 - 35988 != 120549)
								{
									continue;
								}
							}
							else
							{
								this.xtaQFsK5lm.vDirection = myAttackTarget.transform.position;
								if (170689 - 426548 == -255858)
								{
									continue;
								}
								this.xtaQFsK5lm.vDirection.y = this.transform.position.y;
								if (285052 - 224831 == 60222)
								{
									continue;
								}
								this.xtaQFsK5lm.vMovement = (this.xtaQFsK5lm.vDirection - this.transform.position).normalized;
								if (291514 - 595858 == -304343)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.xtaQFsK5lm.vMovement);
								if (100977 - 442832 != -341855)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.FCaQWmV1nJ += mTime;
		}
		while (292335 - 585611 != -293276);
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x001099EC File Offset: 0x00107BEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (130156 - 204666 != -74509)
		{
		}
		do
		{
			if (Time.time - this.MNNQ9pMvvE >= this.FCaQWmV1nJ)
			{
				if (145093 - 366451 == -221357)
				{
					continue;
				}
				if (Time.time - this.MNNQ9pMvvE < this.FCaQWmV1nJ + mTime)
				{
					if (111954 - 387066 == -275111)
					{
						continue;
					}
					GameObject myAttackTarget = this.xtaQFsK5lm.myAttackTarget;
					if (197972 - 413565 != -215593)
					{
						continue;
					}
					CharacterControl characterControl = null;
					if (100077 - 306905 == -206827)
					{
						continue;
					}
					if (myAttackTarget)
					{
						if (57644 - 201797 != -144153)
						{
							continue;
						}
						characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (159928 - 144353 == 15576)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (43028 - 252246 != -209218)
						{
							continue;
						}
						this.MNNQ9pMvvE = Time.time - mTime - this.FCaQWmV1nJ;
						if (269349 - 293323 != -23974)
						{
							continue;
						}
						break;
					}
					else
					{
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (173998 - 421463 == -247464)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (30283 - 208133 != -177850)
						{
							continue;
						}
						eSamuraiBugType eSamuraiBugType = (eSamuraiBugType)UnityRuntimeServices.GetProperty(this.GetComponent("SamuraiBug"), "SamuraiBugType");
						if (184709 - 132945 == 51765)
						{
							continue;
						}
						float num2 = (float)0;
						if (92475 - 89285 == 3191)
						{
							continue;
						}
						eSamuraiBugType eSamuraiBugType2 = eSamuraiBugType;
						if (115850 - 225302 != -109452)
						{
							continue;
						}
						if (eSamuraiBugType2 == eSamuraiBugType.sword)
						{
							if (45345 - 361637 != -316292)
							{
								continue;
							}
							num2 = (float)3;
							if (89725 - 537207 != -447482)
							{
								continue;
							}
						}
						else if (eSamuraiBugType2 == eSamuraiBugType.staff)
						{
							if (157963 - 183461 == -25497)
							{
								continue;
							}
							num2 = (float)2;
							if (120857 - 441990 == -321132)
							{
								continue;
							}
						}
						else if (eSamuraiBugType2 == eSamuraiBugType.gun)
						{
							if (139534 - 66347 != 73187)
							{
								continue;
							}
							num2 = (float)28;
							if (48568 - 489359 == -440790)
							{
								continue;
							}
						}
						if (num < num2)
						{
							if (158123 - 76227 != 81896)
							{
								continue;
							}
							if (this.xtaQFsK5lm.isTimeOut("nAttack") == (float)0)
							{
								if (203623 - 220605 != -16982)
								{
									continue;
								}
								this.MNNQ9pMvvE = Time.time - mTime - this.FCaQWmV1nJ;
								if (9423 - 422935 == -413511)
								{
									continue;
								}
								eSamuraiBugType eSamuraiBugType3 = eSamuraiBugType;
								if (224629 - 531344 != -306715)
								{
									continue;
								}
								if (eSamuraiBugType3 == eSamuraiBugType.sword)
								{
									if (265219 - 87433 != 177786)
									{
										continue;
									}
									this.eAZQACrjR4.StartCoroutine_Auto(this.eAZQACrjR4.RPC_sword(this.transform.position, vector, 0));
									if (219778 - 472915 == -253136)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (173449 - 272340 != -98891)
										{
											continue;
										}
										this.eAZQACrjR4.ActionEvent("RPC_sword", this.transform.position, vector, 0);
										if (245630 - 190223 != 55407)
										{
											continue;
										}
									}
								}
								else if (eSamuraiBugType3 == eSamuraiBugType.staff)
								{
									if (272379 - 558159 != -285780)
									{
										continue;
									}
									this.eAZQACrjR4.StartCoroutine_Auto(this.eAZQACrjR4.RPC_staff(this.transform.position, vector, characterControl.ActorNr));
									if (107029 - 452723 != -345694)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (35770 - 530080 == -494309)
										{
											continue;
										}
										this.eAZQACrjR4.ActionEvent("RPC_staff", this.transform.position, vector, characterControl.ActorNr);
										if (167910 - 376514 == -208603)
										{
											continue;
										}
									}
								}
								else if (eSamuraiBugType3 == eSamuraiBugType.gun)
								{
									if (106903 - 337902 == -230998)
									{
										continue;
									}
									this.eAZQACrjR4.StartCoroutine_Auto(this.eAZQACrjR4.RPC_gun(this.transform.position, vector, characterControl.ActorNr));
									if (12355 - 365111 == -352755)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (68764 - 244296 == -175531)
										{
											continue;
										}
										this.eAZQACrjR4.ActionEvent("RPC_gun", this.transform.position, vector, characterControl.ActorNr);
										if (195655 - 568305 != -372650)
										{
											continue;
										}
									}
								}
								goto IL_4EC;
							}
						}
						this.AI_state = "attack";
						if (9893 - 5982 == 3912)
						{
							continue;
						}
						this.xtaQFsK5lm.vDirection = myAttackTarget.transform.position;
						if (288172 - 277589 == 10584)
						{
							continue;
						}
						this.xtaQFsK5lm.vDirection.y = this.transform.position.y;
						if (175333 - 78697 == 96637)
						{
							continue;
						}
						this.xtaQFsK5lm.vMovement = (this.xtaQFsK5lm.vDirection - this.transform.position).normalized;
						if (173013 - 572049 != -399036)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.xtaQFsK5lm.vMovement);
						if (243713 - 167070 == 76644)
						{
							continue;
						}
						this.xtaQFsK5lm.actionState = "run";
						if (216034 - 430465 == -214430)
						{
							continue;
						}
						this.animation.Play("run");
						if (228649 - 427088 != -198439)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (3925 - 101714 == -97788)
						{
							continue;
						}
						this.xtaQFsK5lm.moveSpeed = Mathf.Lerp(this.xtaQFsK5lm.moveSpeed, this.xtaQFsK5lm.runSpeed, (float)4 * Time.deltaTime);
						if (37289 - 505769 == -468479)
						{
							continue;
						}
					}
				}
			}
			IL_4EC:
			this.FCaQWmV1nJ += mTime;
		}
		while (163138 - 13437 != 149701);
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x0010A230 File Offset: 0x00108430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (131583 - 149751 != -18168)
		{
		}
		while (Time.time - this.MNNQ9pMvvE > this.FCaQWmV1nJ)
		{
			if (196634 - 337880 != -141245)
			{
				this.AI_state = "none";
				if (278750 - 55490 == 223260)
				{
					this.MNNQ9pMvvE = Time.time;
					if (19425 - 43173 == -23748)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x0010A2E4 File Offset: 0x001084E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (7631 - 212763 != -205131)
		{
		}
		for (;;)
		{
			IL_408:
			if (this.kcjQu2nKwB > Time.time)
			{
				if (8326 - 59670 != -51343)
				{
					break;
				}
			}
			else
			{
				this.kcjQu2nKwB = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (211271 - 235414 != -24142)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (298988 - 28861 == 270127)
					{
						if (241917 - 95289 == 146628)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (26461 - 386142 == -359681)
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
									if (77066 - 568123 != -491057)
									{
										goto IL_408;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (249774 - 333513 == -83738)
									{
										goto IL_408;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (71016 - 470236 == -399219)
									{
										goto IL_408;
									}
									bool flag = true;
									if (129295 - 368430 == -239134)
									{
										goto IL_408;
									}
									eRace race = this.xtaQFsK5lm.Race;
									if (245396 - 54587 == 190810)
									{
										goto IL_408;
									}
									if (race == eRace.Tails)
									{
										if (92748 - 382361 == -289612)
										{
											goto IL_408;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_60D;
										}
										if (186856 - 584470 != -397614)
										{
											goto IL_408;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (43457 - 76458 != -33000)
											{
												goto IL_60D;
											}
											goto IL_408;
										}
										goto IL_67;
										IL_60D:
										flag = false;
										if (214862 - 146625 == 68238)
										{
											goto IL_408;
										}
									}
									else if (race == eRace.Plants)
									{
										if (50195 - 203075 != -152880)
										{
											goto IL_408;
										}
										flag = false;
										if (193169 - 86028 == 107142)
										{
											goto IL_408;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (189567 - 415485 == -225917)
										{
											goto IL_408;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_381;
										}
										if (76917 - 593210 == -516292)
										{
											goto IL_408;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (269023 - 417579 != -148555)
											{
												goto IL_381;
											}
											goto IL_408;
										}
										goto IL_67;
										IL_381:
										flag = false;
										if (127294 - 4546 != 122748)
										{
											goto IL_408;
										}
									}
									else if (race == eRace.Robots)
									{
										if (271467 - 275827 != -4360)
										{
											goto IL_408;
										}
										flag = true;
										if (121447 - 430589 != -309142)
										{
											goto IL_408;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (257935 - 409865 != -151930)
										{
											goto IL_408;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_539;
										}
										if (50088 - 76832 != -26744)
										{
											goto IL_408;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_539;
										}
										if (227435 - 58283 != 169152)
										{
											goto IL_408;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (36304 - 293725 != -257420)
											{
												goto IL_539;
											}
											goto IL_408;
										}
										goto IL_67;
										IL_539:
										flag = false;
										if (103749 - 341680 != -237931)
										{
											goto IL_408;
										}
									}
									else if (race == eRace.Structure)
									{
										if (102708 - 181857 == -79148)
										{
											goto IL_408;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (80974 - 137310 != -56336)
											{
												goto IL_408;
											}
											flag = false;
											if (17840 - 305779 != -287939)
											{
												goto IL_408;
											}
										}
									}
									IL_67:
									if (flag)
									{
										if (125213 - 404383 == -279169)
										{
											goto IL_408;
										}
										if (characterControl.hp > 0)
										{
											if (220559 - 69807 != 150752)
											{
												goto IL_408;
											}
											if (characterControl.recieveTarget)
											{
												if (41377 - 116487 != -75110)
												{
													goto IL_408;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (11261 - 195007 == -183745)
													{
														goto IL_408;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (253830 - 116486 != 137344)
														{
															goto IL_408;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (173137 - 361903 != -188766)
														{
															goto IL_408;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (274178 - 319682 == -45503)
															{
																goto IL_408;
															}
															this.xtaQFsK5lm.myAttackTarget = gameObject;
															if (167134 - 520957 == -353822)
															{
																goto IL_408;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (280862 - 358817 == -77954)
															{
																goto IL_408;
															}
															this.xtaQFsK5lm.addHate(characterControl.ActorNr, 5);
															if (131355 - 459792 == -328436)
															{
																goto IL_408;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (94457 - 353447 != -258990)
															{
																goto IL_408;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (121002 - 530469 == -409466)
															{
																goto IL_408;
															}
															if (num < (float)60)
															{
																if (7795 - 249812 == -242016)
																{
																	goto IL_408;
																}
																if (characterControl.hp > 0)
																{
																	if (272992 - 502569 == -229576)
																	{
																		goto IL_408;
																	}
																	this.xtaQFsK5lm.myAttackTarget = gameObject;
																	if (181156 - 494784 == -313627)
																	{
																		goto IL_408;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (267796 - 479056 == -211259)
																	{
																		goto IL_408;
																	}
																	this.xtaQFsK5lm.addHate(characterControl.ActorNr, 5);
																	if (227450 - 4533 != 222917)
																	{
																		goto IL_408;
																	}
																}
															}
														}
														if (this.xtaQFsK5lm.myAttackTarget)
														{
															if (8543 - 297108 != -288565)
															{
																goto IL_408;
															}
															this.xtaQFsK5lm.isAlert = true;
															if (297866 - 401734 == -103867)
															{
																goto IL_408;
															}
															this.MNNQ9pMvvE = Time.time;
															if (94595 - 451358 != -356763)
															{
																goto IL_408;
															}
														}
													}
												}
											}
										}
									}
								}
								if (17603 - 364261 != -346657)
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

	// Token: 0x06000A5E RID: 2654 RVA: 0x0010AAFC File Offset: 0x00108CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x0010AB00 File Offset: 0x00108D00
	internal static bool WYHhN1GjXsB56AdG2YA()
	{
		return true;
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x0010AB04 File Offset: 0x00108D04
	internal static bool OjTNjYGhmlEtMG6wU4t()
	{
		return false;
	}

	// Token: 0x04000943 RID: 2371
	private CharacterControl xtaQFsK5lm;

	// Token: 0x04000944 RID: 2372
	private SamuraiBug eAZQACrjR4;

	// Token: 0x04000945 RID: 2373
	public string AI_state;

	// Token: 0x04000946 RID: 2374
	private float MNNQ9pMvvE;

	// Token: 0x04000947 RID: 2375
	private float FCaQWmV1nJ;

	// Token: 0x04000948 RID: 2376
	private float kcjQu2nKwB;
}
