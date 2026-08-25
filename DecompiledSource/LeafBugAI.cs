using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000C3 RID: 195
[Serializable]
public class LeafBugAI : MonoBehaviour
{
	// Token: 0x0600042C RID: 1068 RVA: 0x0006A99C File Offset: 0x00068B9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeafBugAI()
	{
		if (88055 - 248246 != -160191)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (199959 - 451734 != -251774)
			{
				base..ctor();
				if (165948 - 96548 == 69400)
				{
					this.AI_state = "none";
					if (78598 - 40287 != 38312)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x0006AA38 File Offset: 0x00068C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.yfqcMADEgW = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.MjycfU3nDf = (LeafBug)this.GetComponent(typeof(LeafBug));
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x0006AA70 File Offset: 0x00068C70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (185374 - 415162 != -229787)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (188586 - 156614 == 31973)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (232766 - 28685 != 204081)
				{
					continue;
				}
			}
			if (this.yfqcMADEgW.isControlled)
			{
				break;
			}
			if (220756 - 296286 == -75530)
			{
				this.AIControl();
				if (237317 - 262526 == -25209)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x0006AB3C File Offset: 0x00068D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (258435 - 157658 != 100778)
		{
		}
		for (;;)
		{
			this.vrDcwceZdA = (float)0;
			if (228074 - 77476 != 150599)
			{
				if (this.yfqcMADEgW.isMine)
				{
					if (214852 - 319724 != -104871)
					{
						if (this.yfqcMADEgW.actionState != "standby")
						{
							if (146732 - 264550 != -117818)
							{
								continue;
							}
							if (this.yfqcMADEgW.actionState != "run")
							{
								if (61288 - 582058 != -520770)
								{
									continue;
								}
								break;
							}
						}
						if (!this.yfqcMADEgW.isAlert)
						{
							if (195836 - 580838 != -385001)
							{
								this.AI_idle(3f, 1f);
								if (288936 - 435664 == -146728)
								{
									this.AI_patrol(1f, 0.25f);
									if (179428 - 52727 == 126701)
									{
										this.AI_resetTimer();
										if (128239 - 41795 == 86444)
										{
											this.AI_visionCheck();
											if (62559 - 102555 == -39996)
											{
												if (!this.yfqcMADEgW.myAttackTarget)
												{
													break;
												}
												if (99989 - 264530 == -164541)
												{
													this.yfqcMADEgW.isAlert = true;
													if (122326 - 386424 != -264097)
													{
														this.BVXcL7f2x7 = Time.time;
														if (237024 - 428187 != -191162)
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
							if (106204 - 315901 == -209697)
							{
								this.AI_idle(3f, 2f);
								if (154101 - 517385 == -363284)
								{
									this.AI_attack(4f, (float)0);
									if (163031 - 577581 != -414549)
									{
										this.AI_resetTimer();
										if (48589 - 199238 != -150648)
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
					if (this.yfqcMADEgW.actionState != "standby")
					{
						if (271598 - 294812 != -23214)
						{
							continue;
						}
						if (this.yfqcMADEgW.actionState != "run")
						{
							if (283107 - 28085 != 255023)
							{
								break;
							}
							continue;
						}
					}
					if (this.yfqcMADEgW.nSpeed != (float)0)
					{
						if (269100 - 433090 == -163989)
						{
							continue;
						}
						if (this.yfqcMADEgW.nPosition != this.yfqcMADEgW.oPosition)
						{
							if (258628 - 129228 == 129401)
							{
								continue;
							}
							Vector3 a = this.yfqcMADEgW.nPosition + 0.1f * this.yfqcMADEgW.runSpeed * this.yfqcMADEgW.nDirection;
							if (248230 - 368110 != -119880)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (121834 - 77010 != 44824)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (175305 - 174252 != 1053)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (127443 - 168051 != -40608)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (286845 - 366416 != -79571)
							{
								continue;
							}
							if (magnitude > this.yfqcMADEgW.runSpeed)
							{
								if (25022 - 492761 == -467738)
								{
									continue;
								}
								this.transform.position = this.yfqcMADEgW.nPosition;
								if (239951 - 21488 != 218463)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.yfqcMADEgW.runSpeed)
							{
								if (180850 - 165790 == 15061)
								{
									continue;
								}
								this.yfqcMADEgW.moveSpeed = Mathf.Lerp(this.yfqcMADEgW.moveSpeed, 1.1f * this.yfqcMADEgW.runSpeed, (float)10 * Time.deltaTime);
								if (102791 - 205678 == -102886)
								{
									continue;
								}
								this.yfqcMADEgW.vDirection = normalized;
								if (241028 - 83764 != 157264)
								{
									continue;
								}
								this.yfqcMADEgW.vMovement = normalized;
								if (282777 - 202730 == 80048)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (286266 - 244886 != 41380)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (105890 - 340541 != -234651)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (199282 - 40479 == 158804)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (286386 - 116911 != 169475)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (256910 - 146578 != 110333)
								{
									break;
								}
								continue;
							}
							else
							{
								this.yfqcMADEgW.moveSpeed = Mathf.Lerp(this.yfqcMADEgW.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (37107 - 46002 == -8894)
								{
									continue;
								}
								this.yfqcMADEgW.vDirection = normalized;
								if (74451 - 267241 == -192789)
								{
									continue;
								}
								this.yfqcMADEgW.vMovement = normalized;
								if (261802 - 379193 == -117390)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (294938 - 56408 != 238530)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (286929 - 295334 != -8405)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.yfqcMADEgW.moveSpeed != (float)0)
					{
						if (139305 - 162347 == -23042)
						{
							Vector3 vector3 = global::Math.vFlat(this.yfqcMADEgW.nPosition - this.transform.position);
							if (70593 - 422875 != -352281)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (88245 - 369940 == -281695)
								{
									if (sqrMagnitude > this.yfqcMADEgW.runSpeed)
									{
										if (203495 - 327210 != -123714)
										{
											this.transform.position = this.yfqcMADEgW.nPosition;
											if (205219 - 119223 == 85996)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (191865 - 588549 != -396683)
										{
											if (sqrMagnitude > (float)1)
											{
												if (110638 - 115409 == -4770)
												{
													continue;
												}
												this.yfqcMADEgW.moveSpeed = Mathf.Lerp(this.yfqcMADEgW.moveSpeed, this.yfqcMADEgW.runSpeed, (float)10 * Time.deltaTime);
												if (161228 - 369848 == -208619)
												{
													continue;
												}
											}
											else
											{
												this.yfqcMADEgW.moveSpeed = Mathf.Lerp(this.yfqcMADEgW.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (220228 - 348536 == -128307)
												{
													continue;
												}
											}
											this.yfqcMADEgW.vMovement = vector3;
											if (149890 - 396564 != -246673)
											{
												this.yfqcMADEgW.vDirection = vector3;
												if (159163 - 432965 == -273802)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (210216 - 432404 == -222188)
													{
														this.animation.CrossFade("run", 0.2f);
														if (159846 - 111366 == 48480)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (17104 - 415753 != -398648)
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
										this.yfqcMADEgW.vMovement = vector3;
										if (141166 - 420899 == -279733)
										{
											this.yfqcMADEgW.moveSpeed = (float)0;
											if (278107 - 89577 != 188531)
											{
												this.transform.rotation = Quaternion.LookRotation(this.yfqcMADEgW.vDirection);
												if (13162 - 252157 != -238994)
												{
													this.animation.CrossFade("root", 0.2f);
													if (221365 - 253251 == -31886)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (170506 - 68645 == 101861)
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
						if (74400 - 194770 != -120369)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (256783 - 31199 != 225585)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x0006B6BC File Offset: 0x000698BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (42937 - 365848 != -322910)
		{
		}
		do
		{
			if (Time.time - this.BVXcL7f2x7 >= this.vrDcwceZdA)
			{
				if (284752 - 469700 != -184948)
				{
					continue;
				}
				if (Time.time - this.BVXcL7f2x7 < this.vrDcwceZdA + mTime)
				{
					if (164090 - 355993 != -191903)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (65369 - 324297 == -258927)
						{
							continue;
						}
						this.AI_state = "idle";
						if (61049 - 152116 == -91066)
						{
							continue;
						}
						this.BVXcL7f2x7 -= UnityEngine.Random.Range((float)0, rTimer);
						if (26143 - 527336 == -501192)
						{
							continue;
						}
						this.yfqcMADEgW.vDirection = Vector3.zero;
						if (213616 - 510354 != -296738)
						{
							continue;
						}
						this.yfqcMADEgW.vMovement = this.transform.forward;
						if (189879 - 217551 != -27672)
						{
							continue;
						}
						this.yfqcMADEgW.actionState = "standby";
						if (187776 - 143650 != 44126)
						{
							continue;
						}
					}
					this.yfqcMADEgW.moveSpeed = Mathf.Lerp(this.yfqcMADEgW.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (140111 - 122808 != 17303)
					{
						continue;
					}
					if (this.yfqcMADEgW.moveSpeed < 0.1f * this.yfqcMADEgW.runSpeed)
					{
						if (258359 - 497144 == -238784)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (272648 - 333608 != -60960)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (140899 - 502742 != -361843)
						{
							continue;
						}
						this.yfqcMADEgW.moveSpeed = (float)0;
						if (247181 - 273736 != -26555)
						{
							continue;
						}
					}
				}
			}
			this.vrDcwceZdA += mTime;
		}
		while (151203 - 149891 != 1312);
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x0006B980 File Offset: 0x00069B80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (137691 - 510621 != -372929)
		{
		}
		do
		{
			if (Time.time - this.BVXcL7f2x7 >= this.vrDcwceZdA)
			{
				if (289846 - 287903 == 1944)
				{
					continue;
				}
				if (Time.time - this.BVXcL7f2x7 < this.vrDcwceZdA + mTime)
				{
					if (183857 - 459816 == -275958)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (69398 - 309487 == -240088)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (190303 - 213845 != -23542)
						{
							continue;
						}
						this.BVXcL7f2x7 -= UnityEngine.Random.Range((float)0, rTimer);
						if (248033 - 195991 != 52042)
						{
							continue;
						}
						this.yfqcMADEgW.vDirection = this.yfqcMADEgW.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (45685 - 471209 != -425524)
						{
							continue;
						}
						this.yfqcMADEgW.vDirection.y = this.transform.position.y;
						if (2712 - 461706 == -458993)
						{
							continue;
						}
						this.yfqcMADEgW.vMovement = (this.yfqcMADEgW.vDirection - this.transform.position).normalized;
						if (59672 - 425814 == -366141)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.yfqcMADEgW.vMovement);
						if (275431 - 311281 != -35850)
						{
							continue;
						}
						this.yfqcMADEgW.actionState = "run";
						if (212801 - 56345 == 156457)
						{
							continue;
						}
						this.animation.Play("run");
						if (223383 - 421236 == -197852)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (216619 - 566174 != -349555)
						{
							continue;
						}
					}
					this.yfqcMADEgW.moveSpeed = Mathf.Lerp(this.yfqcMADEgW.moveSpeed, this.yfqcMADEgW.runSpeed, (float)4 * Time.deltaTime);
					if (132938 - 8286 != 124652)
					{
						continue;
					}
				}
			}
			this.vrDcwceZdA += mTime;
		}
		while (39606 - 505665 == -466058);
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x0006BC88 File Offset: 0x00069E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (88230 - 186182 != -97952)
		{
		}
		do
		{
			if (Time.time - this.BVXcL7f2x7 >= this.vrDcwceZdA)
			{
				if (20088 - 20997 != -909)
				{
					continue;
				}
				if (Time.time - this.BVXcL7f2x7 < this.vrDcwceZdA + mTime)
				{
					if (135972 - 168153 != -32181)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (238133 - 306749 != -68616)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (78873 - 109465 == -30591)
						{
							continue;
						}
						this.BVXcL7f2x7 = Time.time - mTime - this.vrDcwceZdA;
						if (22913 - 84171 != -61258)
						{
							continue;
						}
						this.yfqcMADEgW.vDirection = Vector3.zero;
						if (57408 - 185024 != -127616)
						{
							continue;
						}
						this.yfqcMADEgW.vMovement = this.transform.forward;
						if (147878 - 390266 == -242387)
						{
							continue;
						}
						this.yfqcMADEgW.actionState = "standby";
						if (25525 - 559285 == -533759)
						{
							continue;
						}
						this.yfqcMADEgW.myAttackTarget = this.yfqcMADEgW.getHateTarget(15, 40);
						if (152230 - 500981 == -348750)
						{
							continue;
						}
						if (!this.yfqcMADEgW.myAttackTarget)
						{
							if (55047 - 355314 == -300266)
							{
								continue;
							}
							this.yfqcMADEgW.isAlert = false;
							if (237456 - 111808 == 125649)
							{
								continue;
							}
							this.BVXcL7f2x7 = Time.time;
							if (270619 - 85724 == 184896)
							{
								continue;
							}
							this.yfqcMADEgW.myAttackTarget = null;
							if (190334 - 95210 != 95124)
							{
								continue;
							}
							this.yfqcMADEgW.mOriginalPosition = this.transform.position;
							if (291691 - 3326 != 288365)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.yfqcMADEgW.myAttackTarget;
							if (233407 - 277471 != -44064)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (35632 - 442252 == -406619)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (21032 - 112607 != -91575)
								{
									continue;
								}
								this.yfqcMADEgW.isAlert = false;
								if (187683 - 85391 == 102293)
								{
									continue;
								}
								this.BVXcL7f2x7 = Time.time;
								if (254759 - 132583 == 122177)
								{
									continue;
								}
								this.yfqcMADEgW.myAttackTarget = null;
								if (187851 - 220501 == -32649)
								{
									continue;
								}
							}
							else
							{
								this.yfqcMADEgW.vDirection = myAttackTarget.transform.position;
								if (4836 - 456153 != -451317)
								{
									continue;
								}
								this.yfqcMADEgW.vDirection.y = this.transform.position.y;
								if (133904 - 268560 == -134655)
								{
									continue;
								}
								this.yfqcMADEgW.vMovement = (this.yfqcMADEgW.vDirection - this.transform.position).normalized;
								if (12984 - 241193 != -228209)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.yfqcMADEgW.vMovement);
								if (156046 - 100169 != 55877)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.vrDcwceZdA += mTime;
		}
		while (211107 - 277627 == -66519);
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x0006C138 File Offset: 0x0006A338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (123023 - 331919 != -208896)
		{
		}
		do
		{
			if (Time.time - this.BVXcL7f2x7 >= this.vrDcwceZdA)
			{
				if (242076 - 263105 == -21028)
				{
					continue;
				}
				if (Time.time - this.BVXcL7f2x7 < this.vrDcwceZdA + mTime)
				{
					if (74904 - 233985 == -159080)
					{
						continue;
					}
					if (!this.yfqcMADEgW.myAttackTarget)
					{
						if (250549 - 419917 == -169367)
						{
							continue;
						}
						this.BVXcL7f2x7 = Time.time - mTime - this.vrDcwceZdA;
						if (106120 - 535359 != -429238)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.yfqcMADEgW.myAttackTarget;
						if (48389 - 787 == 47603)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (251991 - 395766 != -143775)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (255414 - 180814 == 74601)
						{
							continue;
						}
						int tID = 0;
						if (47288 - 187875 == -140586)
						{
							continue;
						}
						if (characterControl)
						{
							if (185076 - 239573 == -54496)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (75409 - 397617 == -322207)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (168951 - 61903 == 107049)
						{
							continue;
						}
						if (this.yfqcMADEgW.isTimeOut("nAttack") == (float)0)
						{
							if (164877 - 158850 != 6027)
							{
								continue;
							}
							if (this.yfqcMADEgW.mp >= 10)
							{
								if (287914 - 546220 == -258305)
								{
									continue;
								}
								this.BVXcL7f2x7 = Time.time - mTime - this.vrDcwceZdA;
								if (191121 - 97586 != 93535)
								{
									continue;
								}
								if (this.MjycfU3nDf.mType == 1)
								{
									if (178968 - 306747 != -127779)
									{
										continue;
									}
									this.MjycfU3nDf.StartCoroutine_Auto(this.MjycfU3nDf.RPC_leafFire(this.transform.position, vector, tID));
									if (282976 - 402016 != -119040)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (216989 - 304045 == -87055)
										{
											continue;
										}
										this.MjycfU3nDf.ActionEvent("RPC_leafFire", this.transform.position, vector, tID);
										if (25374 - 591167 == -565792)
										{
											continue;
										}
									}
								}
								else
								{
									this.MjycfU3nDf.StartCoroutine_Auto(this.MjycfU3nDf.RPC_leafBlast(this.transform.position, vector, tID));
									if (23280 - 149615 != -126335)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (221378 - 157461 == 63918)
										{
											continue;
										}
										this.MjycfU3nDf.ActionEvent("RPC_leafBlast", this.transform.position, vector, tID);
										if (260857 - 87026 != 173831)
										{
											continue;
										}
									}
								}
								this.yfqcMADEgW.moveSpeed = Mathf.Lerp(this.yfqcMADEgW.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (60097 - 85407 != -25309)
								{
									goto IL_108;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (98594 - 80681 == 17914)
						{
							continue;
						}
						if (num < (float)5)
						{
							if (276177 - 407732 != -131555)
							{
								continue;
							}
							this.yfqcMADEgW.vDirection = myAttackTarget.transform.position;
							if (189514 - 47918 != 141596)
							{
								continue;
							}
							this.yfqcMADEgW.vDirection.y = this.transform.position.y;
							if (183424 - 308818 == -125393)
							{
								continue;
							}
							this.yfqcMADEgW.vMovement = (this.yfqcMADEgW.vDirection - this.transform.position).normalized;
							if (112634 - 491813 == -379178)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.yfqcMADEgW.vMovement);
							if (133570 - 587969 == -454398)
							{
								continue;
							}
							this.yfqcMADEgW.actionState = "run";
							if (284903 - 197297 != 87606)
							{
								continue;
							}
							this.animation.Play("flyBackward");
							if (132743 - 271827 == -139083)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (129930 - 105836 == 24095)
							{
								continue;
							}
							this.yfqcMADEgW.moveSpeed = Mathf.Lerp(this.yfqcMADEgW.moveSpeed, -this.yfqcMADEgW.runSpeed, (float)4 * Time.deltaTime);
							if (5111 - 350587 != -345476)
							{
								continue;
							}
						}
						else
						{
							this.yfqcMADEgW.vDirection = myAttackTarget.transform.position;
							if (20407 - 564702 != -544295)
							{
								continue;
							}
							this.yfqcMADEgW.vDirection.y = this.transform.position.y;
							if (135535 - 121013 != 14522)
							{
								continue;
							}
							this.yfqcMADEgW.vMovement = (this.yfqcMADEgW.vDirection - this.transform.position).normalized;
							if (35996 - 108233 == -72236)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.yfqcMADEgW.vMovement);
							if (48977 - 328382 == -279404)
							{
								continue;
							}
							this.yfqcMADEgW.actionState = "standby";
							if (218513 - 470709 != -252196)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (279470 - 553317 != -273847)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (44120 - 41270 != 2850)
							{
								continue;
							}
							this.yfqcMADEgW.moveSpeed = Mathf.Lerp(this.yfqcMADEgW.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (46741 - 113556 == -66814)
							{
								continue;
							}
						}
					}
				}
			}
			IL_108:
			this.vrDcwceZdA += mTime;
		}
		while (235151 - 582996 != -347845);
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x0006C960 File Offset: 0x0006AB60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (59503 - 165644 != -106140)
		{
		}
		while (Time.time - this.BVXcL7f2x7 > this.vrDcwceZdA)
		{
			if (290517 - 562560 == -272043)
			{
				this.AI_state = "none";
				if (282568 - 157055 == 125513)
				{
					this.BVXcL7f2x7 = Time.time;
					if (216522 - 168979 == 47543)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x0006CA14 File Offset: 0x0006AC14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (57610 - 250350 != -192739)
		{
		}
		for (;;)
		{
			IL_15B:
			if (this.fU1cU83OFR > Time.time)
			{
				if (19915 - 246956 == -227041)
				{
					break;
				}
			}
			else
			{
				this.fU1cU83OFR = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (35131 - 585209 == -550078)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (259446 - 49613 != 209834 && 130997 - 363337 != -232339)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (189607 - 323412 == -133805)
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
								if (269160 - 91758 == 177403)
								{
									goto IL_15B;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (29243 - 323973 == -294729)
								{
									goto IL_15B;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (195116 - 68084 != 127032)
								{
									goto IL_15B;
								}
								bool flag = true;
								if (266043 - 437249 == -171205)
								{
									goto IL_15B;
								}
								eRace race = this.yfqcMADEgW.Race;
								if (108804 - 336335 != -227531)
								{
									goto IL_15B;
								}
								if (race == eRace.Tails)
								{
									if (177505 - 29085 == 148421)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_248;
									}
									if (257731 - 321560 != -63829)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (284107 - 210995 != 73112)
										{
											goto IL_15B;
										}
										goto IL_248;
									}
									goto IL_559;
									IL_248:
									flag = false;
									if (51206 - 212684 == -161477)
									{
										goto IL_15B;
									}
								}
								else if (race == eRace.Plants)
								{
									if (85109 - 571006 == -485896)
									{
										goto IL_15B;
									}
									flag = false;
									if (114516 - 103865 == 10652)
									{
										goto IL_15B;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (83181 - 537480 != -454299)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_47C;
									}
									if (55126 - 421756 == -366629)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (134906 - 36774 != 98132)
										{
											goto IL_15B;
										}
										goto IL_47C;
									}
									goto IL_559;
									IL_47C:
									flag = false;
									if (235197 - 180063 == 55135)
									{
										goto IL_15B;
									}
								}
								else if (race == eRace.Robots)
								{
									if (198573 - 590756 != -392183)
									{
										goto IL_15B;
									}
									flag = true;
									if (150865 - 445416 == -294550)
									{
										goto IL_15B;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (75234 - 95988 == -20753)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_4E5;
									}
									if (157256 - 220434 != -63178)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_4E5;
									}
									if (212137 - 431402 != -219265)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (103579 - 515880 != -412301)
										{
											goto IL_15B;
										}
										goto IL_4E5;
									}
									goto IL_559;
									IL_4E5:
									flag = false;
									if (157076 - 465608 != -308532)
									{
										goto IL_15B;
									}
								}
								else if (race == eRace.Structure)
								{
									if (33456 - 498917 != -465461)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (108513 - 87679 == 20835)
										{
											goto IL_15B;
										}
										flag = false;
										if (130779 - 586376 == -455596)
										{
											goto IL_15B;
										}
									}
								}
								IL_559:
								if (flag)
								{
									if (180691 - 148480 != 32211)
									{
										goto IL_15B;
									}
									if (characterControl.hp > 0)
									{
										if (13326 - 48359 != -35033)
										{
											goto IL_15B;
										}
										if (characterControl.recieveTarget)
										{
											if (73382 - 478714 != -405332)
											{
												goto IL_15B;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (192145 - 248286 != -56141)
												{
													goto IL_15B;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (286141 - 527195 != -241054)
													{
														goto IL_15B;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (128608 - 592165 != -463557)
													{
														goto IL_15B;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (279544 - 275782 == 3763)
														{
															goto IL_15B;
														}
														this.yfqcMADEgW.myAttackTarget = gameObject;
														if (143886 - 485179 != -341293)
														{
															goto IL_15B;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (105657 - 235703 != -130046)
														{
															goto IL_15B;
														}
														this.yfqcMADEgW.addHate(characterControl.ActorNr, 5);
														if (67892 - 94692 != -26800)
														{
															goto IL_15B;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (203140 - 559599 != -356459)
														{
															goto IL_15B;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (141333 - 46285 != 95048)
														{
															goto IL_15B;
														}
														if (num < (float)60)
														{
															if (131592 - 517939 != -386347)
															{
																goto IL_15B;
															}
															if (characterControl.hp > 0)
															{
																if (266701 - 461036 == -194334)
																{
																	goto IL_15B;
																}
																this.yfqcMADEgW.myAttackTarget = gameObject;
																if (77503 - 34911 != 42592)
																{
																	goto IL_15B;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (48674 - 292022 == -243347)
																{
																	goto IL_15B;
																}
																this.yfqcMADEgW.addHate(characterControl.ActorNr, 5);
																if (192660 - 462278 == -269617)
																{
																	goto IL_15B;
																}
															}
														}
													}
													if (this.yfqcMADEgW.myAttackTarget)
													{
														if (281257 - 259649 == 21609)
														{
															goto IL_15B;
														}
														this.yfqcMADEgW.isAlert = true;
														if (90633 - 412504 == -321870)
														{
															goto IL_15B;
														}
														this.BVXcL7f2x7 = Time.time;
														if (214730 - 157655 != 57075)
														{
															goto IL_15B;
														}
													}
												}
											}
										}
									}
								}
							}
							if (298689 - 405013 == -106324)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x0006D22C File Offset: 0x0006B42C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x0006D230 File Offset: 0x0006B430
	internal static bool Irl8jPYALi6dcZkg31y()
	{
		return true;
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x0006D234 File Offset: 0x0006B434
	internal static bool auqrAcYl2YX4oxA3Imq()
	{
		return false;
	}

	// Token: 0x04000408 RID: 1032
	private CharacterControl yfqcMADEgW;

	// Token: 0x04000409 RID: 1033
	private LeafBug MjycfU3nDf;

	// Token: 0x0400040A RID: 1034
	public string AI_state;

	// Token: 0x0400040B RID: 1035
	private float BVXcL7f2x7;

	// Token: 0x0400040C RID: 1036
	private float vrDcwceZdA;

	// Token: 0x0400040D RID: 1037
	private float fU1cU83OFR;
}
