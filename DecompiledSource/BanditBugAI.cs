using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000034 RID: 52
[Serializable]
public class BanditBugAI : MonoBehaviour
{
	// Token: 0x060000F5 RID: 245 RVA: 0x000175CC File Offset: 0x000157CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BanditBugAI()
	{
		if (212495 - 90695 != 121801)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (250738 - 459038 == -208300)
			{
				base..ctor();
				if (94042 - 115714 != -21671)
				{
					this.AI_state = "none";
					if (58080 - 371050 != -312969)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00017668 File Offset: 0x00015868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.z4N29mLCP = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.OZuvm1Eeb = (BanditBug)this.GetComponent(typeof(BanditBug));
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x000176A0 File Offset: 0x000158A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (5086 - 559983 != -554896)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (51971 - 341255 != -289284)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (237763 - 107384 == 130380)
				{
					continue;
				}
			}
			if (this.z4N29mLCP.isControlled)
			{
				break;
			}
			if (198137 - 150065 != 48073)
			{
				this.AIControl();
				if (49473 - 71887 == -22414)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x0001776C File Offset: 0x0001596C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (27039 - 428412 != -401373)
		{
		}
		for (;;)
		{
			this.Q30GCZWJx = (float)0;
			if (173827 - 51334 != 122494)
			{
				if (this.z4N29mLCP.isMine)
				{
					if (58042 - 30774 == 27268)
					{
						if (this.z4N29mLCP.actionState != "standby")
						{
							if (190187 - 411480 == -221292)
							{
								continue;
							}
							if (this.z4N29mLCP.actionState != "run")
							{
								if (230949 - 148415 != 82534)
								{
									continue;
								}
								break;
							}
						}
						if (!this.z4N29mLCP.isAlert)
						{
							if (204941 - 579139 != -374197)
							{
								this.AI_idle(3f, 1f);
								if (160997 - 127027 != 33971)
								{
									this.AI_patrol(1f, 0.25f);
									if (174985 - 33182 != 141804)
									{
										this.AI_resetTimer();
										if (137546 - 265336 == -127790)
										{
											this.AI_visionCheck();
											if (191069 - 105698 != 85372)
											{
												if (!this.z4N29mLCP.myAttackTarget)
												{
													break;
												}
												if (70497 - 452435 == -381938)
												{
													this.z4N29mLCP.isAlert = true;
													if (200873 - 500083 != -299209)
													{
														this.UshlLHaJi = Time.time;
														if (121491 - 318532 != -197040)
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
							if (112778 - 239367 == -126589)
							{
								this.AI_idle(1f, 1f);
								if (201899 - 102309 == 99590)
								{
									this.AI_patrol(1f, 0.5f);
									if (97974 - 418782 != -320807)
									{
										this.AI_attack(10f, (float)0);
										if (77079 - 462675 == -385596)
										{
											this.AI_resetTimer();
											if (113196 - 46156 != 67041)
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
					if (this.z4N29mLCP.actionState != "standby")
					{
						if (92895 - 559878 != -466983)
						{
							continue;
						}
						if (this.z4N29mLCP.actionState != "run")
						{
							if (288943 - 344165 != -55221)
							{
								break;
							}
							continue;
						}
					}
					if (this.z4N29mLCP.nSpeed != (float)0)
					{
						if (229055 - 414576 == -185520)
						{
							continue;
						}
						if (this.z4N29mLCP.nPosition != this.z4N29mLCP.oPosition)
						{
							if (259635 - 413661 != -154026)
							{
								continue;
							}
							Vector3 a = this.z4N29mLCP.nPosition + 0.1f * this.z4N29mLCP.runSpeed * this.z4N29mLCP.nDirection;
							if (215552 - 57644 == 157909)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (104874 - 259614 == -154739)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (3629 - 398606 != -394977)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (171924 - 203175 != -31251)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (272010 - 489483 == -217472)
							{
								continue;
							}
							if (magnitude > this.z4N29mLCP.runSpeed)
							{
								if (84156 - 159147 == -74990)
								{
									continue;
								}
								this.transform.position = this.z4N29mLCP.nPosition;
								if (258083 - 58090 != 199994)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.z4N29mLCP.runSpeed)
							{
								if (43944 - 79614 == -35669)
								{
									continue;
								}
								this.z4N29mLCP.moveSpeed = Mathf.Lerp(this.z4N29mLCP.moveSpeed, 1.1f * this.z4N29mLCP.runSpeed, (float)10 * Time.deltaTime);
								if (102320 - 333486 == -231165)
								{
									continue;
								}
								this.z4N29mLCP.vDirection = normalized;
								if (231621 - 39577 == 192045)
								{
									continue;
								}
								this.z4N29mLCP.vMovement = normalized;
								if (194071 - 198479 != -4408)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (241908 - 429336 == -187427)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (248608 - 276749 != -28141)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (45678 - 507259 != -461581)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (145079 - 322122 == -177042)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (253232 - 462181 != -208948)
								{
									break;
								}
								continue;
							}
							else
							{
								this.z4N29mLCP.moveSpeed = Mathf.Lerp(this.z4N29mLCP.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (77356 - 77774 != -418)
								{
									continue;
								}
								this.z4N29mLCP.vDirection = normalized;
								if (254640 - 330181 == -75540)
								{
									continue;
								}
								this.z4N29mLCP.vMovement = normalized;
								if (24014 - 347318 != -323304)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (263518 - 12121 == 251398)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (29980 - 32729 != -2748)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.z4N29mLCP.moveSpeed != (float)0)
					{
						if (12300 - 434508 != -422207)
						{
							Vector3 vector3 = global::Math.vFlat(this.z4N29mLCP.nPosition - this.transform.position);
							if (69628 - 473158 != -403529)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (217937 - 502835 != -284897)
								{
									if (sqrMagnitude > this.z4N29mLCP.runSpeed)
									{
										if (139528 - 18532 != 120997)
										{
											this.transform.position = this.z4N29mLCP.nPosition;
											if (199163 - 217772 == -18609)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (75660 - 171858 != -96197)
										{
											if (sqrMagnitude > (float)1)
											{
												if (191351 - 232994 == -41642)
												{
													continue;
												}
												this.z4N29mLCP.moveSpeed = Mathf.Lerp(this.z4N29mLCP.moveSpeed, this.z4N29mLCP.runSpeed, (float)10 * Time.deltaTime);
												if (154742 - 256911 != -102169)
												{
													continue;
												}
											}
											else
											{
												this.z4N29mLCP.moveSpeed = Mathf.Lerp(this.z4N29mLCP.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (113929 - 310979 == -197049)
												{
													continue;
												}
											}
											this.z4N29mLCP.vMovement = vector3;
											if (229076 - 226162 != 2915)
											{
												this.z4N29mLCP.vDirection = vector3;
												if (55586 - 135251 == -79665)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (174088 - 458638 == -284550)
													{
														this.animation.CrossFade("run", 0.2f);
														if (213670 - 194887 != 18784)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (182060 - 310262 == -128202)
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
										this.z4N29mLCP.vMovement = vector3;
										if (274665 - 408974 == -134309)
										{
											this.z4N29mLCP.moveSpeed = (float)0;
											if (224939 - 207344 != 17596)
											{
												this.transform.rotation = Quaternion.LookRotation(this.z4N29mLCP.vDirection);
												if (262065 - 577953 != -315887)
												{
													this.animation.CrossFade("root", 0.2f);
													if (106051 - 331482 != -225430)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (299173 - 224259 == 74914)
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
						if (216181 - 66371 == 149810)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (275073 - 370734 != -95660)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00018318 File Offset: 0x00016518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (140634 - 447134 != -306500)
		{
		}
		do
		{
			if (Time.time - this.UshlLHaJi >= this.Q30GCZWJx)
			{
				if (201322 - 454771 == -253448)
				{
					continue;
				}
				if (Time.time - this.UshlLHaJi < this.Q30GCZWJx + mTime)
				{
					if (8003 - 564137 == -556133)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (261316 - 288792 == -27475)
						{
							continue;
						}
						this.AI_state = "idle";
						if (196376 - 347277 == -150900)
						{
							continue;
						}
						this.UshlLHaJi -= UnityEngine.Random.Range((float)0, rTimer);
						if (37898 - 74469 == -36570)
						{
							continue;
						}
						this.z4N29mLCP.vDirection = Vector3.zero;
						if (56026 - 427161 != -371135)
						{
							continue;
						}
						this.z4N29mLCP.vMovement = this.transform.forward;
						if (211317 - 527210 != -315893)
						{
							continue;
						}
						this.z4N29mLCP.actionState = "standby";
						if (243163 - 530986 == -287822)
						{
							continue;
						}
					}
					this.z4N29mLCP.moveSpeed = Mathf.Lerp(this.z4N29mLCP.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (229414 - 571600 != -342186)
					{
						continue;
					}
					if (this.z4N29mLCP.moveSpeed < 0.1f * this.z4N29mLCP.runSpeed)
					{
						if (200019 - 174684 == 25336)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (54606 - 592765 != -538159)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (164499 - 237486 != -72987)
						{
							continue;
						}
						this.z4N29mLCP.moveSpeed = (float)0;
						if (201554 - 516739 != -315185)
						{
							continue;
						}
					}
				}
			}
			this.Q30GCZWJx += mTime;
		}
		while (197926 - 565813 == -367886);
	}

	// Token: 0x060000FA RID: 250 RVA: 0x000185DC File Offset: 0x000167DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (297585 - 345412 != -47827)
		{
		}
		do
		{
			if (Time.time - this.UshlLHaJi >= this.Q30GCZWJx)
			{
				if (87040 - 121633 != -34593)
				{
					continue;
				}
				if (Time.time - this.UshlLHaJi < this.Q30GCZWJx + mTime)
				{
					if (195572 - 516173 != -320601)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (100055 - 545617 != -445562)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (246712 - 329108 != -82396)
						{
							continue;
						}
						this.UshlLHaJi -= UnityEngine.Random.Range((float)0, rTimer);
						if (69292 - 493197 == -423904)
						{
							continue;
						}
						this.z4N29mLCP.vDirection = this.z4N29mLCP.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (223904 - 331784 == -107879)
						{
							continue;
						}
						this.z4N29mLCP.vDirection.y = this.transform.position.y;
						if (100819 - 257627 == -156807)
						{
							continue;
						}
						this.z4N29mLCP.vMovement = (this.z4N29mLCP.vDirection - this.transform.position).normalized;
						if (284244 - 542835 != -258591)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.z4N29mLCP.vMovement);
						if (26816 - 350411 != -323595)
						{
							continue;
						}
						this.z4N29mLCP.actionState = "run";
						if (215122 - 413657 != -198535)
						{
							continue;
						}
						this.animation.Play("run");
						if (121008 - 151736 == -30727)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (259779 - 410607 == -150827)
						{
							continue;
						}
					}
					this.z4N29mLCP.moveSpeed = Mathf.Lerp(this.z4N29mLCP.moveSpeed, this.z4N29mLCP.runSpeed, (float)4 * Time.deltaTime);
					if (92084 - 591941 == -499856)
					{
						continue;
					}
				}
			}
			this.Q30GCZWJx += mTime;
		}
		while (190388 - 180086 != 10302);
	}

	// Token: 0x060000FB RID: 251 RVA: 0x000188E4 File Offset: 0x00016AE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (53960 - 172655 != -118694)
		{
		}
		do
		{
			if (Time.time - this.UshlLHaJi >= this.Q30GCZWJx)
			{
				if (42957 - 201929 != -158972)
				{
					continue;
				}
				if (Time.time - this.UshlLHaJi < this.Q30GCZWJx + mTime)
				{
					if (185080 - 585231 == -400150)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (147237 - 369480 != -222243)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (280987 - 414134 != -133147)
						{
							continue;
						}
						this.UshlLHaJi = Time.time - mTime - this.Q30GCZWJx;
						if (68441 - 525194 == -456752)
						{
							continue;
						}
						this.z4N29mLCP.vDirection = Vector3.zero;
						if (25979 - 51798 != -25819)
						{
							continue;
						}
						this.z4N29mLCP.vMovement = this.transform.forward;
						if (145684 - 115424 == 30261)
						{
							continue;
						}
						this.z4N29mLCP.actionState = "standby";
						if (204434 - 215007 != -10573)
						{
							continue;
						}
						this.z4N29mLCP.myAttackTarget = this.z4N29mLCP.getHateTarget(5, 50);
						if (140440 - 160786 != -20346)
						{
							continue;
						}
						if (!this.z4N29mLCP.myAttackTarget)
						{
							if (92192 - 311778 != -219586)
							{
								continue;
							}
							this.z4N29mLCP.isAlert = false;
							if (263101 - 566379 == -303277)
							{
								continue;
							}
							this.UshlLHaJi = Time.time;
							if (216306 - 157856 == 58451)
							{
								continue;
							}
							this.z4N29mLCP.myAttackTarget = null;
							if (226354 - 521212 != -294858)
							{
								continue;
							}
							this.z4N29mLCP.mOriginalPosition = this.transform.position;
							if (62569 - 475768 != -413198)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.z4N29mLCP.myAttackTarget;
							if (52617 - 136106 == -83488)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (111734 - 153741 == -42006)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (246297 - 177407 != 68890)
								{
									continue;
								}
								this.z4N29mLCP.isAlert = false;
								if (32317 - 401694 != -369377)
								{
									continue;
								}
								this.UshlLHaJi = Time.time;
								if (287803 - 266203 == 21601)
								{
									continue;
								}
								this.z4N29mLCP.myAttackTarget = null;
								if (37759 - 248211 != -210452)
								{
									continue;
								}
							}
							else
							{
								this.z4N29mLCP.vDirection = myAttackTarget.transform.position;
								if (53617 - 471961 != -418344)
								{
									continue;
								}
								this.z4N29mLCP.vDirection.y = this.transform.position.y;
								if (210407 - 356621 != -146214)
								{
									continue;
								}
								this.z4N29mLCP.vMovement = (this.z4N29mLCP.vDirection - this.transform.position).normalized;
								if (197607 - 286147 != -88540)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.z4N29mLCP.vMovement);
								if (173037 - 461364 != -288327)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Q30GCZWJx += mTime;
		}
		while (118839 - 417515 == -298675);
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00018D94 File Offset: 0x00016F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (180549 - 485218 != -304668)
		{
		}
		do
		{
			if (Time.time - this.UshlLHaJi >= this.Q30GCZWJx)
			{
				if (106583 - 180317 == -73733)
				{
					continue;
				}
				if (Time.time - this.UshlLHaJi < this.Q30GCZWJx + mTime)
				{
					if (89381 - 326269 != -236888)
					{
						continue;
					}
					GameObject myAttackTarget = this.z4N29mLCP.myAttackTarget;
					if (85798 - 95685 != -9887)
					{
						continue;
					}
					CharacterControl exists = null;
					if (12369 - 585992 == -573622)
					{
						continue;
					}
					if (myAttackTarget)
					{
						if (205160 - 499514 == -294353)
						{
							continue;
						}
						exists = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (124336 - 175562 == -51225)
						{
							continue;
						}
					}
					if (!exists)
					{
						if (216688 - 66480 != 150208)
						{
							continue;
						}
						this.UshlLHaJi = Time.time - mTime - this.Q30GCZWJx;
						if (168812 - 248461 != -79648)
						{
							break;
						}
						continue;
					}
					else
					{
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (39430 - 519837 != -480407)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (110454 - 189616 != -79162)
						{
							continue;
						}
						eBanditBugType eBanditBugType = (eBanditBugType)UnityRuntimeServices.GetProperty(this.GetComponent("BanditBug"), "BanditBugType");
						if (100544 - 6545 != 93999)
						{
							continue;
						}
						float num2 = (float)0;
						if (240514 - 588116 == -347601)
						{
							continue;
						}
						eBanditBugType eBanditBugType2 = eBanditBugType;
						if (180765 - 443654 != -262889)
						{
							continue;
						}
						if (eBanditBugType2 == eBanditBugType.scythe)
						{
							if (394 - 368419 == -368024)
							{
								continue;
							}
							num2 = (float)4;
							if (219391 - 25464 == 193928)
							{
								continue;
							}
						}
						else if (eBanditBugType2 == eBanditBugType.sword)
						{
							if (46117 - 95954 == -49836)
							{
								continue;
							}
							num2 = (float)2;
							if (98940 - 376481 != -277541)
							{
								continue;
							}
						}
						else if (eBanditBugType2 == eBanditBugType.bomb)
						{
							if (51383 - 39209 == 12175)
							{
								continue;
							}
							num2 = (float)9;
							if (282567 - 70157 != 212410)
							{
								continue;
							}
						}
						if (num < num2)
						{
							if (245127 - 519780 != -274653)
							{
								continue;
							}
							if (this.z4N29mLCP.sp >= 32)
							{
								if (131645 - 464256 != -332611)
								{
									continue;
								}
								if (this.z4N29mLCP.isTimeOut("cAttack") == (float)0)
								{
									if (274842 - 95031 == 179812)
									{
										continue;
									}
									this.UshlLHaJi = Time.time - mTime - this.Q30GCZWJx;
									if (154183 - 97991 == 56193)
									{
										continue;
									}
									eBanditBugType eBanditBugType3 = eBanditBugType;
									if (8274 - 26104 != -17829)
									{
										if (eBanditBugType3 == eBanditBugType.scythe)
										{
											if (251624 - 404605 == -152980)
											{
												continue;
											}
											this.OZuvm1Eeb.StartCoroutine_Auto(this.OZuvm1Eeb.RPC_scythe2(this.transform.position, vector, 0));
											if (67936 - 112085 != -44149)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (15630 - 568815 != -553185)
												{
													continue;
												}
												this.OZuvm1Eeb.ActionEvent("RPC_scythe2", this.transform.position, vector, 0);
												if (34233 - 380223 == -345989)
												{
													continue;
												}
											}
										}
										else if (eBanditBugType3 == eBanditBugType.sword)
										{
											if (277481 - 156157 != 121324)
											{
												continue;
											}
											this.OZuvm1Eeb.StartCoroutine_Auto(this.OZuvm1Eeb.RPC_swordSpin(this.transform.position, vector, 0));
											if (137499 - 521172 == -383672)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (28201 - 460520 != -432319)
												{
													continue;
												}
												this.OZuvm1Eeb.ActionEvent("RPC_swordSpin", this.transform.position, vector, 0);
												if (200635 - 125652 != 74983)
												{
													continue;
												}
											}
										}
										else if (eBanditBugType3 == eBanditBugType.bomb)
										{
											if (39319 - 79473 == -40153)
											{
												continue;
											}
											this.OZuvm1Eeb.StartCoroutine_Auto(this.OZuvm1Eeb.RPC_bomb2(this.transform.position, vector, 0));
											if (921 - 174382 != -173461)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (281030 - 384888 == -103857)
												{
													continue;
												}
												this.OZuvm1Eeb.ActionEvent("RPC_bomb2", this.transform.position, vector, 0);
												if (18384 - 229395 != -211011)
												{
													continue;
												}
											}
										}
										goto IL_627;
									}
									continue;
								}
							}
						}
						if (num < num2)
						{
							if (167146 - 169 == 166978)
							{
								continue;
							}
							if (this.z4N29mLCP.isTimeOut("nAttack") == (float)0)
							{
								if (146967 - 598521 == -451553)
								{
									continue;
								}
								this.UshlLHaJi = Time.time - mTime - this.Q30GCZWJx;
								if (72915 - 20821 == 52095)
								{
									continue;
								}
								eBanditBugType eBanditBugType4 = eBanditBugType;
								if (26576 - 557181 != -530604)
								{
									if (eBanditBugType4 == eBanditBugType.scythe)
									{
										if (68596 - 158063 != -89467)
										{
											continue;
										}
										this.OZuvm1Eeb.StartCoroutine_Auto(this.OZuvm1Eeb.RPC_scythe(this.transform.position, vector, 0));
										if (280851 - 368185 == -87333)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (189596 - 19987 == 169610)
											{
												continue;
											}
											this.OZuvm1Eeb.ActionEvent("RPC_scythe", this.transform.position, vector, 0);
											if (203172 - 219829 == -16656)
											{
												continue;
											}
										}
									}
									else if (eBanditBugType4 == eBanditBugType.sword)
									{
										if (261135 - 334938 == -73802)
										{
											continue;
										}
										this.OZuvm1Eeb.StartCoroutine_Auto(this.OZuvm1Eeb.RPC_sword(this.transform.position, vector, 0));
										if (123270 - 60867 != 62403)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (179900 - 276972 != -97072)
											{
												continue;
											}
											this.OZuvm1Eeb.ActionEvent("RPC_sword", this.transform.position, vector, 0);
											if (263240 - 239490 != 23750)
											{
												continue;
											}
										}
									}
									else if (eBanditBugType4 == eBanditBugType.bomb)
									{
										if (90775 - 383301 == -292525)
										{
											continue;
										}
										this.OZuvm1Eeb.StartCoroutine_Auto(this.OZuvm1Eeb.RPC_bomb(this.transform.position, vector, 0));
										if (105772 - 390759 != -284987)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (160203 - 451975 == -291771)
											{
												continue;
											}
											this.OZuvm1Eeb.ActionEvent("RPC_bomb", this.transform.position, vector, 0);
											if (4445 - 82662 != -78217)
											{
												continue;
											}
										}
									}
									goto IL_627;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (64873 - 257256 == -192382)
						{
							continue;
						}
						this.z4N29mLCP.vDirection = myAttackTarget.transform.position;
						if (138576 - 371663 == -233086)
						{
							continue;
						}
						this.z4N29mLCP.vDirection.y = this.transform.position.y;
						if (225140 - 423511 != -198371)
						{
							continue;
						}
						this.z4N29mLCP.vMovement = (this.z4N29mLCP.vDirection - this.transform.position).normalized;
						if (7976 - 117543 != -109567)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.z4N29mLCP.vMovement);
						if (138368 - 11068 == 127301)
						{
							continue;
						}
						this.z4N29mLCP.actionState = "run";
						if (27184 - 585694 == -558509)
						{
							continue;
						}
						this.animation.Play("run");
						if (20960 - 346410 == -325449)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (182707 - 368373 == -185665)
						{
							continue;
						}
						this.z4N29mLCP.moveSpeed = Mathf.Lerp(this.z4N29mLCP.moveSpeed, this.z4N29mLCP.runSpeed, (float)4 * Time.deltaTime);
						if (246436 - 4281 == 242156)
						{
							continue;
						}
					}
				}
			}
			IL_627:
			this.Q30GCZWJx += mTime;
		}
		while (44305 - 375680 != -331375);
	}

	// Token: 0x060000FD RID: 253 RVA: 0x000198D4 File Offset: 0x00017AD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (280220 - 121682 != 158538)
		{
		}
		while (Time.time - this.UshlLHaJi > this.Q30GCZWJx)
		{
			if (298367 - 543887 != -245519)
			{
				this.AI_state = "none";
				if (177384 - 418523 == -241139)
				{
					this.UshlLHaJi = Time.time;
					if (134990 - 47334 != 87657)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00019988 File Offset: 0x00017B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (7074 - 467441 != -460366)
		{
		}
		for (;;)
		{
			IL_154:
			if (this.XVP1k7EML > Time.time)
			{
				if (44531 - 255611 != -211079)
				{
					break;
				}
			}
			else
			{
				this.XVP1k7EML = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (56535 - 55155 != 1381)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (132921 - 418876 != -285954)
					{
						if (295512 - 534836 == -239324)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (64637 - 352797 == -288160)
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
									if (255265 - 403296 != -148031)
									{
										goto IL_154;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (114325 - 86889 == 27437)
									{
										goto IL_154;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (44805 - 120182 == -75376)
									{
										goto IL_154;
									}
									bool flag = true;
									if (7903 - 596809 != -588906)
									{
										goto IL_154;
									}
									eRace race = this.z4N29mLCP.Race;
									if (91993 - 438876 != -346883)
									{
										goto IL_154;
									}
									if (race == eRace.Tails)
									{
										if (1924 - 179241 == -177316)
										{
											goto IL_154;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_759;
										}
										if (140587 - 198828 != -58241)
										{
											goto IL_154;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (238755 - 2638 != 236117)
											{
												goto IL_154;
											}
											goto IL_759;
										}
										goto IL_4A5;
										IL_759:
										flag = false;
										if (295416 - 487955 != -192539)
										{
											goto IL_154;
										}
									}
									else if (race == eRace.Plants)
									{
										if (250873 - 371592 != -120719)
										{
											goto IL_154;
										}
										flag = false;
										if (247231 - 384683 != -137452)
										{
											goto IL_154;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (80131 - 197567 == -117435)
										{
											goto IL_154;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_277;
										}
										if (45564 - 251466 != -205902)
										{
											goto IL_154;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (18678 - 88032 != -69353)
											{
												goto IL_277;
											}
											goto IL_154;
										}
										goto IL_4A5;
										IL_277:
										flag = false;
										if (247740 - 220962 == 26779)
										{
											goto IL_154;
										}
									}
									else if (race == eRace.Robots)
									{
										if (170849 - 297113 == -126263)
										{
											goto IL_154;
										}
										flag = true;
										if (152760 - 168514 == -15753)
										{
											goto IL_154;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (121377 - 143497 == -22119)
										{
											goto IL_154;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_46;
										}
										if (165676 - 262944 == -97267)
										{
											goto IL_154;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_46;
										}
										if (87041 - 457500 != -370459)
										{
											goto IL_154;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (262940 - 356392 != -93451)
											{
												goto IL_46;
											}
											goto IL_154;
										}
										goto IL_4A5;
										IL_46:
										flag = false;
										if (33837 - 597731 != -563894)
										{
											goto IL_154;
										}
									}
									else if (race == eRace.Structure)
									{
										if (299890 - 67205 == 232686)
										{
											goto IL_154;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (74995 - 304090 != -229095)
											{
												goto IL_154;
											}
											flag = false;
											if (146916 - 424800 != -277884)
											{
												goto IL_154;
											}
										}
									}
									IL_4A5:
									if (flag)
									{
										if (53115 - 380011 != -326896)
										{
											goto IL_154;
										}
										if (characterControl.hp > 0)
										{
											if (250857 - 229417 != 21440)
											{
												goto IL_154;
											}
											if (characterControl.recieveTarget)
											{
												if (171922 - 459167 != -287245)
												{
													goto IL_154;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (227784 - 583820 != -356036)
													{
														goto IL_154;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (187007 - 222437 == -35429)
														{
															goto IL_154;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (16051 - 127145 == -111093)
														{
															goto IL_154;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (235560 - 191324 == 44237)
															{
																goto IL_154;
															}
															this.z4N29mLCP.myAttackTarget = gameObject;
															if (297074 - 80484 != 216590)
															{
																goto IL_154;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (251247 - 107374 == 143874)
															{
																goto IL_154;
															}
															this.z4N29mLCP.addHate(characterControl.ActorNr, 5);
															if (112149 - 389250 != -277101)
															{
																goto IL_154;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (275093 - 110046 == 165048)
															{
																goto IL_154;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (172707 - 333229 == -160521)
															{
																goto IL_154;
															}
															if (num < (float)60)
															{
																if (43393 - 421867 == -378473)
																{
																	goto IL_154;
																}
																if (characterControl.hp > 0)
																{
																	if (166461 - 341936 == -175474)
																	{
																		goto IL_154;
																	}
																	this.z4N29mLCP.myAttackTarget = gameObject;
																	if (155751 - 198686 != -42935)
																	{
																		goto IL_154;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (253094 - 38588 != 214506)
																	{
																		goto IL_154;
																	}
																	this.z4N29mLCP.addHate(characterControl.ActorNr, 5);
																	if (134033 - 262130 == -128096)
																	{
																		goto IL_154;
																	}
																}
															}
														}
														if (this.z4N29mLCP.myAttackTarget)
														{
															if (119320 - 54729 != 64591)
															{
																goto IL_154;
															}
															this.z4N29mLCP.isAlert = true;
															if (124772 - 304528 != -179756)
															{
																goto IL_154;
															}
															this.UshlLHaJi = Time.time;
															if (115695 - 484470 == -368774)
															{
																goto IL_154;
															}
														}
													}
												}
											}
										}
									}
								}
								if (70511 - 333763 != -263251)
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

	// Token: 0x060000FF RID: 255 RVA: 0x0001A1A0 File Offset: 0x000183A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000100 RID: 256 RVA: 0x0001A1A4 File Offset: 0x000183A4
	internal static bool oQgtd85D1jKoyUhOtIw()
	{
		return true;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x0001A1A8 File Offset: 0x000183A8
	internal static bool rJ4N1c5v9ysXUoCPgiD()
	{
		return false;
	}

	// Token: 0x04000147 RID: 327
	private CharacterControl z4N29mLCP;

	// Token: 0x04000148 RID: 328
	private BanditBug OZuvm1Eeb;

	// Token: 0x04000149 RID: 329
	public string AI_state;

	// Token: 0x0400014A RID: 330
	private float UshlLHaJi;

	// Token: 0x0400014B RID: 331
	private float Q30GCZWJx;

	// Token: 0x0400014C RID: 332
	private float XVP1k7EML;
}
