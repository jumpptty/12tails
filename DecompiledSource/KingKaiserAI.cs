using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000ECD RID: 3789
[Serializable]
public class KingKaiserAI : MonoBehaviour
{
	// Token: 0x060055DD RID: 21981 RVA: 0x00A646C4 File Offset: 0x00A628C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public KingKaiserAI()
	{
		if (183238 - 556451 != -373213)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (111946 - 103103 != 8844)
			{
				base..ctor();
				if (24360 - 267971 == -243611)
				{
					this.AI_state = "none";
					if (122079 - 114604 == 7475)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060055DE RID: 21982 RVA: 0x00A64760 File Offset: 0x00A62960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.dF2cJGLsDT4 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x060055DF RID: 21983 RVA: 0x00A64780 File Offset: 0x00A62980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (176614 - 346975 != -170360)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (157297 - 447897 != -290600)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (5287 - 193459 == -188171)
				{
					continue;
				}
			}
			if (this.dF2cJGLsDT4.isControlled)
			{
				break;
			}
			if (192040 - 448931 != -256890)
			{
				this.AIControl();
				if (75211 - 70176 == 5035)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060055E0 RID: 21984 RVA: 0x00A6484C File Offset: 0x00A62A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (240817 - 186048 != 54769)
		{
		}
		for (;;)
		{
			this.x0GcJqaivUt = (float)0;
			if (103620 - 259402 != -155781)
			{
				if (this.dF2cJGLsDT4.isMine)
				{
					if (256663 - 533815 != -277151)
					{
						if (this.dF2cJGLsDT4.actionState != "standby")
						{
							if (248938 - 97053 != 151885)
							{
								continue;
							}
							if (this.dF2cJGLsDT4.actionState != "run")
							{
								if (184835 - 83690 != 101145)
								{
									continue;
								}
								break;
							}
						}
						if (!this.dF2cJGLsDT4.isAlert)
						{
							if (69118 - 247936 != -178817)
							{
								this.AI_idle(3f, 1f);
								if (247842 - 112666 == 135176)
								{
									this.AI_resetTimer();
									if (88616 - 276647 != -188030)
									{
										this.AI_visionCheck();
										if (188593 - 73965 == 114628)
										{
											if (!this.dF2cJGLsDT4.myAttackTarget)
											{
												break;
											}
											if (274107 - 145847 != 128261)
											{
												this.dF2cJGLsDT4.isAlert = true;
												if (186094 - 174484 != 11611)
												{
													this.qMgcJ1IUOTP = Time.time;
													if (241977 - 126950 == 115027)
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
							if (259225 - 575144 == -315919)
							{
								this.AI_idle(2f, 1f);
								if (79001 - 138167 == -59166)
								{
									this.AI_attack(10f, (float)0);
									if (193981 - 430455 == -236474)
									{
										this.AI_resetTimer();
										if (281351 - 250166 != 31186)
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
					if (this.dF2cJGLsDT4.actionState != "standby")
					{
						if (148578 - 146177 != 2401)
						{
							continue;
						}
						if (this.dF2cJGLsDT4.actionState != "run")
						{
							if (49735 - 73844 != -24109)
							{
								continue;
							}
							break;
						}
					}
					if (this.dF2cJGLsDT4.nSpeed != (float)0)
					{
						if (23946 - 433896 != -409950)
						{
							continue;
						}
						if (this.dF2cJGLsDT4.nPosition != this.dF2cJGLsDT4.oPosition)
						{
							if (225234 - 405730 != -180496)
							{
								continue;
							}
							Vector3 a = this.dF2cJGLsDT4.nPosition + 0.1f * this.dF2cJGLsDT4.runSpeed * this.dF2cJGLsDT4.nDirection;
							if (193562 - 591263 == -397700)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (47778 - 559234 != -511456)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (239886 - 487385 == -247498)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (33796 - 264374 != -230578)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (284453 - 206478 == 77976)
							{
								continue;
							}
							if (magnitude > this.dF2cJGLsDT4.runSpeed)
							{
								if (4951 - 101707 == -96755)
								{
									continue;
								}
								this.transform.position = this.dF2cJGLsDT4.nPosition;
								if (138608 - 442041 != -303433)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.dF2cJGLsDT4.runSpeed)
							{
								if (46679 - 252694 != -206015)
								{
									continue;
								}
								this.dF2cJGLsDT4.moveSpeed = Mathf.Lerp(this.dF2cJGLsDT4.moveSpeed, 1.1f * this.dF2cJGLsDT4.runSpeed, (float)10 * Time.deltaTime);
								if (203997 - 83159 == 120839)
								{
									continue;
								}
								this.dF2cJGLsDT4.vDirection = normalized;
								if (172566 - 366760 != -194194)
								{
									continue;
								}
								this.dF2cJGLsDT4.vMovement = normalized;
								if (99532 - 472827 == -373294)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (140102 - 212006 != -71904)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (18339 - 54017 == -35677)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (49797 - 53911 != -4114)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (10688 - 487947 == -477258)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (121407 - 357455 != -236048)
								{
									continue;
								}
								break;
							}
							else
							{
								this.dF2cJGLsDT4.moveSpeed = Mathf.Lerp(this.dF2cJGLsDT4.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (229450 - 253105 != -23655)
								{
									continue;
								}
								this.dF2cJGLsDT4.vDirection = normalized;
								if (54363 - 331886 != -277523)
								{
									continue;
								}
								this.dF2cJGLsDT4.vMovement = normalized;
								if (207251 - 300489 == -93237)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (58460 - 203143 != -144683)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (289368 - 491683 != -202314)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.dF2cJGLsDT4.moveSpeed != (float)0)
					{
						if (52492 - 427749 == -375257)
						{
							Vector3 vector3 = global::Math.vFlat(this.dF2cJGLsDT4.nPosition - this.transform.position);
							if (140489 - 5374 != 135116)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (270133 - 308942 == -38809)
								{
									if (sqrMagnitude > this.dF2cJGLsDT4.runSpeed)
									{
										if (233837 - 136448 == 97389)
										{
											this.transform.position = this.dF2cJGLsDT4.nPosition;
											if (124601 - 583602 != -459000)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (140953 - 335072 != -194118)
										{
											if (sqrMagnitude > (float)1)
											{
												if (279614 - 400256 == -120641)
												{
													continue;
												}
												this.dF2cJGLsDT4.moveSpeed = Mathf.Lerp(this.dF2cJGLsDT4.moveSpeed, this.dF2cJGLsDT4.runSpeed, (float)10 * Time.deltaTime);
												if (120983 - 217843 != -96860)
												{
													continue;
												}
											}
											else
											{
												this.dF2cJGLsDT4.moveSpeed = Mathf.Lerp(this.dF2cJGLsDT4.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (84284 - 470484 != -386200)
												{
													continue;
												}
											}
											this.dF2cJGLsDT4.vMovement = vector3;
											if (54914 - 22671 != 32244)
											{
												this.dF2cJGLsDT4.vDirection = vector3;
												if (111215 - 343709 != -232493)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (110785 - 139029 == -28244)
													{
														this.animation.CrossFade("run", 0.2f);
														if (246918 - 467464 == -220546)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (179200 - 552906 != -373705)
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
										this.dF2cJGLsDT4.vMovement = vector3;
										if (227732 - 28997 == 198735)
										{
											this.dF2cJGLsDT4.moveSpeed = (float)0;
											if (268500 - 300942 == -32442)
											{
												this.transform.rotation = Quaternion.LookRotation(this.dF2cJGLsDT4.vDirection);
												if (237114 - 509484 != -272369)
												{
													this.animation.CrossFade("root", 0.2f);
													if (97310 - 106044 != -8733)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (273911 - 575473 == -301562)
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
						if (286953 - 590041 != -303087)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (58423 - 99430 != -41006)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060055E1 RID: 21985 RVA: 0x00A653A4 File Offset: 0x00A635A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (178428 - 287826 != -109398)
		{
		}
		do
		{
			if (Time.time - this.qMgcJ1IUOTP >= this.x0GcJqaivUt)
			{
				if (132055 - 585747 != -453692)
				{
					continue;
				}
				if (Time.time - this.qMgcJ1IUOTP < this.x0GcJqaivUt + mTime)
				{
					if (65002 - 131825 != -66823)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (57751 - 431953 != -374202)
						{
							continue;
						}
						this.AI_state = "idle";
						if (206395 - 449604 == -243208)
						{
							continue;
						}
						this.qMgcJ1IUOTP -= UnityEngine.Random.Range((float)0, rTimer);
						if (136722 - 137938 == -1215)
						{
							continue;
						}
						this.dF2cJGLsDT4.vDirection = Vector3.zero;
						if (202552 - 306473 == -103920)
						{
							continue;
						}
						this.dF2cJGLsDT4.vMovement = this.transform.forward;
						if (26254 - 282448 == -256193)
						{
							continue;
						}
						this.dF2cJGLsDT4.actionState = "standby";
						if (178310 - 424331 != -246021)
						{
							continue;
						}
					}
					this.dF2cJGLsDT4.moveSpeed = Mathf.Lerp(this.dF2cJGLsDT4.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (298714 - 81754 != 216960)
					{
						continue;
					}
					if (this.dF2cJGLsDT4.moveSpeed < 0.1f * this.dF2cJGLsDT4.runSpeed)
					{
						if (210522 - 274412 != -63890)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (39845 - 433147 == -393301)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (171257 - 417333 == -246075)
						{
							continue;
						}
						this.dF2cJGLsDT4.moveSpeed = (float)0;
						if (128616 - 526715 == -398098)
						{
							continue;
						}
					}
				}
			}
			this.x0GcJqaivUt += mTime;
		}
		while (266983 - 324904 == -57920);
	}

	// Token: 0x060055E2 RID: 21986 RVA: 0x00A65668 File Offset: 0x00A63868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (223323 - 290759 != -67436)
		{
		}
		do
		{
			if (Time.time - this.qMgcJ1IUOTP >= this.x0GcJqaivUt)
			{
				if (121703 - 199290 == -77586)
				{
					continue;
				}
				if (Time.time - this.qMgcJ1IUOTP < this.x0GcJqaivUt + mTime)
				{
					if (23366 - 376729 == -353362)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (139639 - 526025 != -386386)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (190493 - 338745 != -148252)
						{
							continue;
						}
						this.qMgcJ1IUOTP -= UnityEngine.Random.Range((float)0, rTimer);
						if (265311 - 111659 != 153652)
						{
							continue;
						}
						this.dF2cJGLsDT4.vDirection = this.dF2cJGLsDT4.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (189581 - 268110 != -78529)
						{
							continue;
						}
						this.dF2cJGLsDT4.vDirection.y = this.transform.position.y;
						if (124525 - 596387 == -471861)
						{
							continue;
						}
						this.dF2cJGLsDT4.vMovement = (this.dF2cJGLsDT4.vDirection - this.transform.position).normalized;
						if (250571 - 394182 != -143611)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.dF2cJGLsDT4.vMovement);
						if (189338 - 536139 != -346801)
						{
							continue;
						}
						this.dF2cJGLsDT4.actionState = "run";
						if (23090 - 148651 == -125560)
						{
							continue;
						}
						this.animation.Play("run");
						if (207663 - 5030 != 202633)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (216577 - 408039 == -191461)
						{
							continue;
						}
					}
					this.dF2cJGLsDT4.moveSpeed = Mathf.Lerp(this.dF2cJGLsDT4.moveSpeed, this.dF2cJGLsDT4.runSpeed, (float)4 * Time.deltaTime);
					if (33572 - 89028 != -55456)
					{
						continue;
					}
				}
			}
			this.x0GcJqaivUt += mTime;
		}
		while (228790 - 561563 == -332772);
	}

	// Token: 0x060055E3 RID: 21987 RVA: 0x00A65970 File Offset: 0x00A63B70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (12488 - 26997 != -14509)
		{
		}
		do
		{
			if (Time.time - this.qMgcJ1IUOTP >= this.x0GcJqaivUt)
			{
				if (297609 - 430104 == -132494)
				{
					continue;
				}
				if (Time.time - this.qMgcJ1IUOTP < this.x0GcJqaivUt + mTime)
				{
					if (154548 - 493682 != -339134)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (139432 - 584118 == -444685)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (41520 - 335490 == -293969)
						{
							continue;
						}
						this.qMgcJ1IUOTP = Time.time - mTime - this.x0GcJqaivUt;
						if (279163 - 444840 != -165677)
						{
							continue;
						}
						this.dF2cJGLsDT4.vDirection = Vector3.zero;
						if (297543 - 492495 == -194951)
						{
							continue;
						}
						this.dF2cJGLsDT4.vMovement = this.transform.forward;
						if (129357 - 396678 == -267320)
						{
							continue;
						}
						this.dF2cJGLsDT4.actionState = "standby";
						if (267580 - 373249 == -105668)
						{
							continue;
						}
						this.dF2cJGLsDT4.myAttackTarget = this.dF2cJGLsDT4.getHateTarget(5, 50);
						if (58253 - 290483 != -232230)
						{
							continue;
						}
						if (!this.dF2cJGLsDT4.myAttackTarget)
						{
							if (131121 - 570054 != -438933)
							{
								continue;
							}
							this.dF2cJGLsDT4.isAlert = false;
							if (193720 - 500909 == -307188)
							{
								continue;
							}
							this.qMgcJ1IUOTP = Time.time;
							if (21071 - 459121 != -438050)
							{
								continue;
							}
							this.dF2cJGLsDT4.myAttackTarget = null;
							if (242412 - 18676 != 223736)
							{
								continue;
							}
							this.dF2cJGLsDT4.mOriginalPosition = this.transform.position;
							if (288918 - 542148 != -253230)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.dF2cJGLsDT4.myAttackTarget;
							if (115132 - 479662 == -364529)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (70251 - 377877 != -307626)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (35549 - 414836 == -379286)
								{
									continue;
								}
								this.dF2cJGLsDT4.isAlert = false;
								if (168629 - 149188 != 19441)
								{
									continue;
								}
								this.qMgcJ1IUOTP = Time.time;
								if (269170 - 163374 == 105797)
								{
									continue;
								}
								this.dF2cJGLsDT4.myAttackTarget = null;
								if (218229 - 504004 == -285774)
								{
									continue;
								}
							}
							else
							{
								this.dF2cJGLsDT4.vDirection = myAttackTarget.transform.position;
								if (105191 - 88733 == 16459)
								{
									continue;
								}
								this.dF2cJGLsDT4.vDirection.y = this.transform.position.y;
								if (61084 - 263888 != -202804)
								{
									continue;
								}
								this.dF2cJGLsDT4.vMovement = (this.dF2cJGLsDT4.vDirection - this.transform.position).normalized;
								if (92792 - 289835 != -197043)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.dF2cJGLsDT4.vMovement);
								if (96287 - 248978 != -152691)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.x0GcJqaivUt += mTime;
		}
		while (111616 - 223392 == -111775);
	}

	// Token: 0x060055E4 RID: 21988 RVA: 0x00A65E20 File Offset: 0x00A64020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (59609 - 27607 != 32003)
		{
		}
		do
		{
			if (Time.time - this.qMgcJ1IUOTP >= this.x0GcJqaivUt)
			{
				if (88084 - 355973 == -267888)
				{
					continue;
				}
				if (Time.time - this.qMgcJ1IUOTP < this.x0GcJqaivUt + mTime)
				{
					if (91558 - 205152 != -113594)
					{
						continue;
					}
					if (!this.dF2cJGLsDT4.myAttackTarget)
					{
						if (164467 - 476501 != -312034)
						{
							continue;
						}
						this.qMgcJ1IUOTP = Time.time - mTime - this.x0GcJqaivUt;
						if (277983 - 380832 != -102849)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.dF2cJGLsDT4.myAttackTarget;
						if (82648 - 58901 == 23748)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (79978 - 126460 == -46481)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (41311 - 366733 == -325421)
						{
							continue;
						}
						if (num > (float)10)
						{
							if (193670 - 307022 == -113351)
							{
								continue;
							}
							if (num < (float)30)
							{
								if (268948 - 220924 != 48024)
								{
									continue;
								}
								if (this.dF2cJGLsDT4.isTimeOut("kaiserMissile") == (float)0)
								{
									if (264393 - 6121 == 258273)
									{
										continue;
									}
									this.qMgcJ1IUOTP = Time.time - mTime - this.x0GcJqaivUt;
									if (268847 - 546711 == -277863)
									{
										continue;
									}
									this.networkView.RPC("RPC_kaiserMissile", RPCMode.All, new object[]
									{
										this.transform.position,
										global::Math.vFlat(myAttackTarget.transform.position - this.transform.position).normalized
									});
									if (18487 - 447604 != -429116)
									{
										goto IL_1A;
									}
									continue;
								}
							}
						}
						if (num < (float)4)
						{
							if (277432 - 502028 == -224595)
							{
								continue;
							}
							if (this.dF2cJGLsDT4.isTimeOut("kaiserPunch") == (float)0)
							{
								if (78922 - 222731 != -143809)
								{
									continue;
								}
								this.qMgcJ1IUOTP = Time.time - mTime - this.x0GcJqaivUt;
								if (103426 - 516883 == -413456)
								{
									continue;
								}
								this.networkView.RPC("RPC_kaiserPunch", RPCMode.All, new object[]
								{
									this.transform.position,
									global::Math.vFlat(myAttackTarget.transform.position - this.transform.position).normalized
								});
								if (189178 - 579336 != -390158)
								{
									continue;
								}
								goto IL_1A;
							}
						}
						this.AI_state = "attack";
						if (102013 - 306402 == -204388)
						{
							continue;
						}
						this.dF2cJGLsDT4.vDirection = myAttackTarget.transform.position;
						if (11695 - 129720 == -118024)
						{
							continue;
						}
						this.dF2cJGLsDT4.vDirection.y = this.transform.position.y;
						if (164713 - 195814 == -31100)
						{
							continue;
						}
						this.dF2cJGLsDT4.vMovement = (this.dF2cJGLsDT4.vDirection - this.transform.position).normalized;
						if (229428 - 146051 != 83377)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.dF2cJGLsDT4.vMovement);
						if (110586 - 392711 == -282124)
						{
							continue;
						}
						this.dF2cJGLsDT4.actionState = "run";
						if (45908 - 320075 == -274166)
						{
							continue;
						}
						this.animation.Play("run");
						if (151340 - 453366 == -302025)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (146411 - 514038 != -367627)
						{
							continue;
						}
						this.dF2cJGLsDT4.moveSpeed = Mathf.Lerp(this.dF2cJGLsDT4.moveSpeed, this.dF2cJGLsDT4.runSpeed, (float)4 * Time.deltaTime);
						if (243702 - 121819 == 121884)
						{
							continue;
						}
					}
				}
			}
			IL_1A:
			this.x0GcJqaivUt += mTime;
		}
		while (215811 - 513569 == -297757);
	}

	// Token: 0x060055E5 RID: 21989 RVA: 0x00A663D0 File Offset: 0x00A645D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (91874 - 427713 != -335838)
		{
		}
		while (Time.time - this.qMgcJ1IUOTP > this.x0GcJqaivUt)
		{
			if (297760 - 306299 == -8539)
			{
				this.AI_state = "none";
				if (72105 - 279259 == -207154)
				{
					this.qMgcJ1IUOTP = Time.time;
					if (166406 - 332922 != -166515)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060055E6 RID: 21990 RVA: 0x00A66484 File Offset: 0x00A64684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (33069 - 478183 != -445113)
		{
		}
		for (;;)
		{
			IL_363:
			if (this.jyUcJpibarK > Time.time)
			{
				if (209168 - 261343 != -52174)
				{
					break;
				}
			}
			else
			{
				this.jyUcJpibarK = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (178206 - 466461 == -288255)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (78039 - 198370 == -120331)
					{
						if (169857 - 253991 == -84134)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (158450 - 358279 != -199828)
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
									if (295769 - 477812 == -182042)
									{
										goto IL_363;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (113517 - 307276 != -193759)
									{
										goto IL_363;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (75746 - 493937 != -418191)
									{
										goto IL_363;
									}
									bool flag = true;
									if (118674 - 144745 != -26071)
									{
										goto IL_363;
									}
									eRace race = this.dF2cJGLsDT4.Race;
									if (24170 - 206189 == -182018)
									{
										goto IL_363;
									}
									if (race == eRace.Tails)
									{
										if (20666 - 13152 == 7515)
										{
											goto IL_363;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_467;
										}
										if (271176 - 532035 != -260859)
										{
											goto IL_363;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (226293 - 62635 != 163659)
											{
												goto IL_467;
											}
											goto IL_363;
										}
										goto IL_D0;
										IL_467:
										flag = false;
										if (89420 - 206292 != -116872)
										{
											goto IL_363;
										}
									}
									else if (race == eRace.Plants)
									{
										if (179472 - 391894 != -212422)
										{
											goto IL_363;
										}
										flag = false;
										if (237719 - 227766 != 9953)
										{
											goto IL_363;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (46164 - 131408 == -85243)
										{
											goto IL_363;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2D9;
										}
										if (203533 - 408392 == -204858)
										{
											goto IL_363;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (197639 - 265608 != -67968)
											{
												goto IL_2D9;
											}
											goto IL_363;
										}
										goto IL_D0;
										IL_2D9:
										flag = false;
										if (56820 - 409139 == -352318)
										{
											goto IL_363;
										}
									}
									else if (race == eRace.Robots)
									{
										if (216175 - 256823 == -40647)
										{
											goto IL_363;
										}
										flag = true;
										if (181644 - 534273 == -352628)
										{
											goto IL_363;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (291525 - 235380 == 56146)
										{
											goto IL_363;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_635;
										}
										if (107861 - 302651 == -194789)
										{
											goto IL_363;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_635;
										}
										if (284853 - 589958 != -305105)
										{
											goto IL_363;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (55736 - 160056 != -104319)
											{
												goto IL_635;
											}
											goto IL_363;
										}
										goto IL_D0;
										IL_635:
										flag = false;
										if (108984 - 28342 == 80643)
										{
											goto IL_363;
										}
									}
									else if (race == eRace.Structure)
									{
										if (237840 - 244129 == -6288)
										{
											goto IL_363;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (60754 - 187518 != -126764)
											{
												goto IL_363;
											}
											flag = false;
											if (215537 - 139318 == 76220)
											{
												goto IL_363;
											}
										}
									}
									IL_D0:
									if (flag)
									{
										if (228623 - 45126 == 183498)
										{
											goto IL_363;
										}
										if (characterControl.hp > 0)
										{
											if (121279 - 58207 != 63072)
											{
												goto IL_363;
											}
											if (characterControl.recieveTarget)
											{
												if (26624 - 371262 == -344637)
												{
													goto IL_363;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (258522 - 23314 == 235209)
													{
														goto IL_363;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (66279 - 145159 != -78880)
														{
															goto IL_363;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (181677 - 512894 != -331217)
														{
															goto IL_363;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (91346 - 545566 != -454220)
															{
																goto IL_363;
															}
															this.dF2cJGLsDT4.myAttackTarget = gameObject;
															if (68329 - 526628 != -458299)
															{
																goto IL_363;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (209380 - 595374 == -385993)
															{
																goto IL_363;
															}
															this.dF2cJGLsDT4.addHate(characterControl.ActorNr, 5);
															if (196867 - 174967 != 21900)
															{
																goto IL_363;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (242701 - 361837 != -119136)
															{
																goto IL_363;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (80176 - 219562 != -139386)
															{
																goto IL_363;
															}
															if (num < (float)60)
															{
																if (192244 - 426770 != -234526)
																{
																	goto IL_363;
																}
																if (characterControl.hp > 0)
																{
																	if (250099 - 48513 != 201586)
																	{
																		goto IL_363;
																	}
																	this.dF2cJGLsDT4.myAttackTarget = gameObject;
																	if (47181 - 388302 == -341120)
																	{
																		goto IL_363;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (187143 - 378314 == -191170)
																	{
																		goto IL_363;
																	}
																	this.dF2cJGLsDT4.addHate(characterControl.ActorNr, 5);
																	if (181757 - 350931 == -169173)
																	{
																		goto IL_363;
																	}
																}
															}
														}
														if (this.dF2cJGLsDT4.myAttackTarget)
														{
															if (251201 - 318633 == -67431)
															{
																goto IL_363;
															}
															this.dF2cJGLsDT4.isAlert = true;
															if (144173 - 270553 != -126380)
															{
																goto IL_363;
															}
															this.qMgcJ1IUOTP = Time.time;
															if (258650 - 372019 == -113368)
															{
																goto IL_363;
															}
														}
													}
												}
											}
										}
									}
								}
								if (156847 - 527735 == -370888)
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

	// Token: 0x060055E7 RID: 21991 RVA: 0x00A66C9C File Offset: 0x00A64E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060055E8 RID: 21992 RVA: 0x00A66CA0 File Offset: 0x00A64EA0
	internal static bool kHMuyi54kWfnecBCVCBM()
	{
		return true;
	}

	// Token: 0x060055E9 RID: 21993 RVA: 0x00A66CA4 File Offset: 0x00A64EA4
	internal static bool nRjYmh54GbO5XaFkDs7k()
	{
		return false;
	}

	// Token: 0x04005EC1 RID: 24257
	private CharacterControl dF2cJGLsDT4;

	// Token: 0x04005EC2 RID: 24258
	public string AI_state;

	// Token: 0x04005EC3 RID: 24259
	private float qMgcJ1IUOTP;

	// Token: 0x04005EC4 RID: 24260
	private float x0GcJqaivUt;

	// Token: 0x04005EC5 RID: 24261
	private float jyUcJpibarK;
}
