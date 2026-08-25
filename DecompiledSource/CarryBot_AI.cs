using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AC6 RID: 2758
[Serializable]
public class CarryBot_AI : MonoBehaviour
{
	// Token: 0x06003CE7 RID: 15591 RVA: 0x007DCEE8 File Offset: 0x007DB0E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CarryBot_AI()
	{
		if (224196 - 107088 != 117108)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (283585 - 480915 != -197329)
			{
				base..ctor();
				if (8526 - 17582 != -9055)
				{
					this.AI_state = "none";
					if (21867 - 77971 != -56103)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003CE8 RID: 15592 RVA: 0x007DCF84 File Offset: 0x007DB184
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ycfubU4JiK = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.msbudcCe4t = (CarryBot)this.GetComponent(typeof(CarryBot));
	}

	// Token: 0x06003CE9 RID: 15593 RVA: 0x007DCFBC File Offset: 0x007DB1BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (113001 - 528435 != -415433)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (278597 - 525544 != -246947)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (47398 - 92151 != -44753)
				{
					continue;
				}
			}
			if (this.ycfubU4JiK.isControlled)
			{
				break;
			}
			if (235559 - 271315 != -35755)
			{
				this.AIControl();
				if (145898 - 375486 == -229588)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003CEA RID: 15594 RVA: 0x007DD088 File Offset: 0x007DB288
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (163339 - 43888 != 119451)
		{
		}
		for (;;)
		{
			this.ITiuao8xbb = (float)0;
			if (158005 - 70168 == 87837)
			{
				if (this.ycfubU4JiK.isMine)
				{
					if (210021 - 343823 == -133802)
					{
						if (this.ycfubU4JiK.actionState != "standby")
						{
							if (120078 - 250285 == -130206)
							{
								continue;
							}
							if (this.ycfubU4JiK.actionState != "run")
							{
								if (27346 - 482391 != -455044)
								{
									break;
								}
								continue;
							}
						}
						if (!this.ycfubU4JiK.isAlert)
						{
							if (116251 - 461321 == -345070)
							{
								if (Game.mGameCode == 915)
								{
									if (146419 - 310970 != -164551)
									{
										continue;
									}
									this.AI_idle(2f, 1f);
									if (45902 - 498694 != -452792)
									{
										continue;
									}
									this.AI_march(Vector3.forward, 12f, (float)0);
									if (71588 - 154372 == -82783)
									{
										continue;
									}
									this.AI_resetTimer();
									if (163544 - 3289 != 160255)
									{
										continue;
									}
									this.AI_visionCheck();
									if (165724 - 266338 != -100614)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (5381 - 524674 == -519292)
									{
										continue;
									}
									this.AI_patrol(4f, 2f);
									if (182314 - 83648 != 98666)
									{
										continue;
									}
									this.AI_resetTimer();
									if (89153 - 182282 == -93128)
									{
										continue;
									}
									this.AI_visionCheck();
									if (214882 - 234777 != -19895)
									{
										continue;
									}
								}
								if (!this.ycfubU4JiK.myAttackTarget)
								{
									break;
								}
								if (50865 - 267527 != -216661)
								{
									this.ycfubU4JiK.isAlert = true;
									if (68472 - 105603 != -37130)
									{
										this.B2nugsmyPp = Time.time;
										if (155920 - 491139 != -335218)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (114101 - 333617 == -219516)
							{
								this.AI_idle(1f, 1f);
								if (199575 - 85685 != 113891)
								{
									this.AI_attack(10f, 2f);
									if (287559 - 114264 != 173296)
									{
										this.AI_resetTimer();
										if (162564 - 257547 != -94982)
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
					if (this.ycfubU4JiK.actionState != "standby")
					{
						if (10777 - 163194 == -152416)
						{
							continue;
						}
						if (this.ycfubU4JiK.actionState != "run")
						{
							if (69909 - 379380 != -309470)
							{
								break;
							}
							continue;
						}
					}
					if (this.ycfubU4JiK.nSpeed != (float)0)
					{
						if (278710 - 547830 != -269120)
						{
							continue;
						}
						if (this.ycfubU4JiK.nPosition != this.ycfubU4JiK.oPosition)
						{
							if (247704 - 346950 != -99246)
							{
								continue;
							}
							Vector3 a = this.ycfubU4JiK.nPosition + 0.1f * this.ycfubU4JiK.runSpeed * this.ycfubU4JiK.nDirection;
							if (56451 - 68481 != -12030)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (273255 - 434942 != -161687)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (72254 - 433281 == -361026)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (200052 - 498884 != -298832)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (81343 - 222029 != -140686)
							{
								continue;
							}
							if (magnitude > this.ycfubU4JiK.runSpeed)
							{
								if (180533 - 339392 == -158858)
								{
									continue;
								}
								this.transform.position = this.ycfubU4JiK.nPosition;
								if (253940 - 117497 != 136444)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.ycfubU4JiK.runSpeed)
							{
								if (262051 - 354501 != -92450)
								{
									continue;
								}
								this.ycfubU4JiK.moveSpeed = Mathf.Lerp(this.ycfubU4JiK.moveSpeed, 1.1f * this.ycfubU4JiK.runSpeed, (float)10 * Time.deltaTime);
								if (164755 - 442217 != -277462)
								{
									continue;
								}
								this.ycfubU4JiK.vDirection = normalized;
								if (79087 - 273592 == -194504)
								{
									continue;
								}
								this.ycfubU4JiK.vMovement = normalized;
								if (63004 - 337903 != -274899)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (296982 - 500757 == -203774)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (26145 - 330384 == -304238)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (15859 - 242998 == -227138)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (294298 - 418514 == -124215)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (284570 - 68898 != 215672)
								{
									continue;
								}
								break;
							}
							else
							{
								this.ycfubU4JiK.moveSpeed = Mathf.Lerp(this.ycfubU4JiK.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (91691 - 54389 == 37303)
								{
									continue;
								}
								this.ycfubU4JiK.vDirection = normalized;
								if (87984 - 578268 == -490283)
								{
									continue;
								}
								this.ycfubU4JiK.vMovement = normalized;
								if (243463 - 75894 == 167570)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (38273 - 535098 == -496824)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (118897 - 5695 != 113202)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.ycfubU4JiK.moveSpeed != (float)0)
					{
						if (32336 - 495375 == -463039)
						{
							Vector3 vector3 = global::Math.vFlat(this.ycfubU4JiK.nPosition - this.transform.position);
							if (182770 - 153158 == 29612)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (189193 - 328387 != -139193)
								{
									if (sqrMagnitude > this.ycfubU4JiK.runSpeed)
									{
										if (293629 - 474903 != -181273)
										{
											this.transform.position = this.ycfubU4JiK.nPosition;
											if (292096 - 302248 == -10152)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (152824 - 263862 != -111037)
										{
											if (sqrMagnitude > (float)1)
											{
												if (27427 - 517807 == -490379)
												{
													continue;
												}
												this.ycfubU4JiK.moveSpeed = Mathf.Lerp(this.ycfubU4JiK.moveSpeed, this.ycfubU4JiK.runSpeed, (float)10 * Time.deltaTime);
												if (38697 - 28005 == 10693)
												{
													continue;
												}
											}
											else
											{
												this.ycfubU4JiK.moveSpeed = Mathf.Lerp(this.ycfubU4JiK.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (12352 - 18128 != -5776)
												{
													continue;
												}
											}
											this.ycfubU4JiK.vMovement = vector3;
											if (138458 - 98434 == 40024)
											{
												this.ycfubU4JiK.vDirection = vector3;
												if (162797 - 471364 == -308567)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (169569 - 164292 != 5278)
													{
														this.animation.CrossFade("run", 0.2f);
														if (121338 - 260709 != -139370)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (182567 - 401696 == -219129)
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
										this.ycfubU4JiK.vMovement = vector3;
										if (259491 - 50204 != 209288)
										{
											this.ycfubU4JiK.moveSpeed = (float)0;
											if (99151 - 592435 == -493284)
											{
												this.transform.rotation = Quaternion.LookRotation(this.ycfubU4JiK.vDirection);
												if (153624 - 129125 == 24499)
												{
													this.animation.CrossFade("root", 0.2f);
													if (60654 - 30643 == 30011)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (64399 - 48948 == 15451)
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
						if (225856 - 197723 == 28133)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (272389 - 566315 != -293925)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003CEB RID: 15595 RVA: 0x007DDCD0 File Offset: 0x007DBED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (204952 - 498768 != -293816)
		{
		}
		do
		{
			if (Time.time - this.B2nugsmyPp >= this.ITiuao8xbb)
			{
				if (202042 - 93132 == 108911)
				{
					continue;
				}
				if (Time.time - this.B2nugsmyPp < this.ITiuao8xbb + mTime)
				{
					if (123370 - 308294 != -184924)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (209109 - 561710 == -352600)
						{
							continue;
						}
						this.AI_state = "idle";
						if (157096 - 413236 == -256139)
						{
							continue;
						}
						this.B2nugsmyPp -= UnityEngine.Random.Range((float)0, rTimer);
						if (73040 - 472901 == -399860)
						{
							continue;
						}
						this.ycfubU4JiK.vDirection = Vector3.zero;
						if (22643 - 332480 != -309837)
						{
							continue;
						}
						this.ycfubU4JiK.vMovement = this.transform.forward;
						if (102964 - 489698 == -386733)
						{
							continue;
						}
						this.ycfubU4JiK.actionState = "standby";
						if (42973 - 349952 != -306979)
						{
							continue;
						}
					}
					this.ycfubU4JiK.moveSpeed = Mathf.Lerp(this.ycfubU4JiK.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (31369 - 226046 != -194677)
					{
						continue;
					}
					if (this.ycfubU4JiK.moveSpeed < 0.1f * this.ycfubU4JiK.runSpeed)
					{
						if (39364 - 66582 == -27217)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (123020 - 571230 != -448210)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (233519 - 291985 != -58466)
						{
							continue;
						}
						this.ycfubU4JiK.moveSpeed = (float)0;
						if (114617 - 333555 == -218937)
						{
							continue;
						}
					}
				}
			}
			this.ITiuao8xbb += mTime;
		}
		while (57930 - 87985 == -30054);
	}

	// Token: 0x06003CEC RID: 15596 RVA: 0x007DDF94 File Offset: 0x007DC194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (179335 - 250153 != -70818)
		{
		}
		do
		{
			if (Time.time - this.B2nugsmyPp >= this.ITiuao8xbb)
			{
				if (241733 - 45847 != 195886)
				{
					continue;
				}
				if (Time.time - this.B2nugsmyPp < this.ITiuao8xbb + mTime)
				{
					if (118029 - 339090 != -221061)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (271923 - 118774 != 153149)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (286232 - 172726 != 113506)
						{
							continue;
						}
						this.B2nugsmyPp -= UnityEngine.Random.Range((float)0, rTimer);
						if (266903 - 51088 == 215816)
						{
							continue;
						}
						this.ycfubU4JiK.vDirection = this.ycfubU4JiK.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (288156 - 15998 != 272158)
						{
							continue;
						}
						this.ycfubU4JiK.vDirection.y = this.transform.position.y;
						if (1973 - 496051 == -494077)
						{
							continue;
						}
						this.ycfubU4JiK.vMovement = (this.ycfubU4JiK.vDirection - this.transform.position).normalized;
						if (285145 - 323771 == -38625)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.ycfubU4JiK.vMovement);
						if (19080 - 288178 == -269097)
						{
							continue;
						}
						this.ycfubU4JiK.actionState = "run";
						if (281578 - 377295 != -95717)
						{
							continue;
						}
						this.animation.Play("run");
						if (13960 - 463446 == -449485)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (36983 - 208131 != -171148)
						{
							continue;
						}
					}
					this.ycfubU4JiK.moveSpeed = Mathf.Lerp(this.ycfubU4JiK.moveSpeed, this.ycfubU4JiK.runSpeed, (float)4 * Time.deltaTime);
					if (57253 - 205392 == -148138)
					{
						continue;
					}
				}
			}
			this.ITiuao8xbb += mTime;
		}
		while (202448 - 166388 == 36061);
	}

	// Token: 0x06003CED RID: 15597 RVA: 0x007DE29C File Offset: 0x007DC49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_march(Vector3 nDir, float mTime, float rTimer)
	{
		if (183876 - 583629 != -399752)
		{
		}
		do
		{
			if (Time.time - this.B2nugsmyPp >= this.ITiuao8xbb)
			{
				if (234737 - 53348 == 181390)
				{
					continue;
				}
				if (Time.time - this.B2nugsmyPp < this.ITiuao8xbb + mTime)
				{
					if (245539 - 230786 != 14753)
					{
						continue;
					}
					if (this.AI_state != "march")
					{
						if (283961 - 61000 == 222962)
						{
							continue;
						}
						this.AI_state = "march";
						if (17374 - 298947 != -281573)
						{
							continue;
						}
						this.B2nugsmyPp -= UnityEngine.Random.Range((float)0, rTimer);
						if (134243 - 527818 == -393574)
						{
							continue;
						}
						this.ycfubU4JiK.actionState = "run";
						if (293758 - 543342 != -249584)
						{
							continue;
						}
						this.animation.Play("run");
						if (219126 - 85704 != 133422)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (55926 - 293449 == -237522)
						{
							continue;
						}
					}
					this.ycfubU4JiK.vDirection = this.transform.position + (float)12 * nDir;
					if (162448 - 253408 != -90960)
					{
						continue;
					}
					this.ycfubU4JiK.vDirection.y = this.transform.position.y;
					if (203430 - 519674 != -316244)
					{
						continue;
					}
					this.ycfubU4JiK.vMovement = (this.ycfubU4JiK.vDirection - this.transform.position).normalized;
					if (45809 - 175902 == -130092)
					{
						continue;
					}
					this.transform.rotation = Quaternion.LookRotation(this.ycfubU4JiK.vMovement);
					if (239734 - 190405 == 49330)
					{
						continue;
					}
					this.ycfubU4JiK.moveSpeed = Mathf.Lerp(this.ycfubU4JiK.moveSpeed, this.ycfubU4JiK.runSpeed, (float)4 * Time.deltaTime);
					if (85790 - 44198 == 41593)
					{
						continue;
					}
				}
			}
			this.ITiuao8xbb += mTime;
		}
		while (264922 - 5970 != 258952);
	}

	// Token: 0x06003CEE RID: 15598 RVA: 0x007DE5A0 File Offset: 0x007DC7A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (3533 - 66351 != -62817)
		{
		}
		do
		{
			if (Time.time - this.B2nugsmyPp >= this.ITiuao8xbb)
			{
				if (3472 - 71960 != -68488)
				{
					continue;
				}
				if (Time.time - this.B2nugsmyPp < this.ITiuao8xbb + mTime)
				{
					if (187689 - 54197 == 133493)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (190986 - 173372 != 17614)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (125784 - 13236 != 112548)
						{
							continue;
						}
						this.B2nugsmyPp = Time.time - mTime - this.ITiuao8xbb;
						if (209451 - 247825 != -38374)
						{
							continue;
						}
						this.ycfubU4JiK.vDirection = Vector3.zero;
						if (184245 - 571953 == -387707)
						{
							continue;
						}
						this.ycfubU4JiK.vMovement = this.transform.forward;
						if (259107 - 318076 == -58968)
						{
							continue;
						}
						this.ycfubU4JiK.actionState = "standby";
						if (108959 - 202904 == -93944)
						{
							continue;
						}
						this.ycfubU4JiK.myAttackTarget = this.ycfubU4JiK.getHateTarget(5, 50);
						if (273752 - 239419 == 34334)
						{
							continue;
						}
						if (!this.ycfubU4JiK.myAttackTarget)
						{
							if (163353 - 418991 != -255638)
							{
								continue;
							}
							this.ycfubU4JiK.isAlert = false;
							if (147249 - 521706 != -374457)
							{
								continue;
							}
							this.B2nugsmyPp = Time.time;
							if (252540 - 346714 == -94173)
							{
								continue;
							}
							this.ycfubU4JiK.myAttackTarget = null;
							if (106804 - 335906 != -229102)
							{
								continue;
							}
							this.ycfubU4JiK.mOriginalPosition = this.transform.position;
							if (236413 - 331936 != -95522)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.ycfubU4JiK.myAttackTarget;
							if (142963 - 212528 != -69565)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (14589 - 309217 != -294628)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (177448 - 9359 != 168089)
								{
									continue;
								}
								this.ycfubU4JiK.isAlert = false;
								if (47360 - 523776 != -476416)
								{
									continue;
								}
								this.B2nugsmyPp = Time.time;
								if (268638 - 368004 == -99365)
								{
									continue;
								}
								this.ycfubU4JiK.myAttackTarget = null;
								if (241039 - 487151 != -246112)
								{
									continue;
								}
							}
							else
							{
								this.ycfubU4JiK.vDirection = myAttackTarget.transform.position;
								if (205499 - 68493 == 137007)
								{
									continue;
								}
								this.ycfubU4JiK.vDirection.y = this.transform.position.y;
								if (3395 - 178519 == -175123)
								{
									continue;
								}
								this.ycfubU4JiK.vMovement = (this.ycfubU4JiK.vDirection - this.transform.position).normalized;
								if (148736 - 189756 != -41020)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ycfubU4JiK.vMovement);
								if (88177 - 252683 == -164505)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.ITiuao8xbb += mTime;
		}
		while (167707 - 118620 != 49087);
	}

	// Token: 0x06003CEF RID: 15599 RVA: 0x007DEA50 File Offset: 0x007DCC50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (294183 - 586547 != -292364)
		{
		}
		do
		{
			if (Time.time - this.B2nugsmyPp >= this.ITiuao8xbb)
			{
				if (105562 - 549712 == -444149)
				{
					continue;
				}
				if (Time.time - this.B2nugsmyPp < this.ITiuao8xbb + mTime)
				{
					if (110764 - 375204 == -264439)
					{
						continue;
					}
					if (!this.ycfubU4JiK.myAttackTarget)
					{
						if (152667 - 587827 == -435159)
						{
							continue;
						}
						this.B2nugsmyPp = Time.time - mTime - this.ITiuao8xbb;
						if (457 - 423416 != -422959)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.ycfubU4JiK.myAttackTarget;
						if (51933 - 120372 == -68438)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (274109 - 181539 != 92570)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (237688 - 232822 != 4866)
						{
							continue;
						}
						int tID = 0;
						if (245664 - 310660 != -64996)
						{
							continue;
						}
						if (characterControl)
						{
							if (161489 - 175439 == -13949)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (286582 - 45902 != 240680)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (84284 - 500653 != -416369)
						{
							continue;
						}
						if (num < (float)12)
						{
							if (40621 - 11337 == 29285)
							{
								continue;
							}
							if (this.ycfubU4JiK.isTimeOut("earthShock") == (float)0)
							{
								if (85419 - 86452 == -1032)
								{
									continue;
								}
								this.B2nugsmyPp = Time.time - mTime - this.ITiuao8xbb;
								if (91287 - 86094 != 5193)
								{
									continue;
								}
								this.msbudcCe4t.StartCoroutine_Auto(this.msbudcCe4t.RPC_earthShock(this.transform.position, vector, tID));
								if (84336 - 138267 != -53930)
								{
									if (PhotonClient.IsInitialized())
									{
										if (212291 - 186538 != 25753)
										{
											continue;
										}
										this.msbudcCe4t.ActionEvent("RPC_earthShock", this.transform.position, vector, tID);
										if (289762 - 291566 != -1804)
										{
											continue;
										}
									}
									goto IL_7B0;
								}
								continue;
							}
						}
						if (num < (float)32)
						{
							if (122039 - 309248 != -187209)
							{
								continue;
							}
							if (this.ycfubU4JiK.isTimeOut("nAttack") == (float)0)
							{
								if (175612 - 530053 != -354441)
								{
									continue;
								}
								this.B2nugsmyPp = Time.time - mTime - this.ITiuao8xbb;
								if (78033 - 36027 != 42006)
								{
									continue;
								}
								this.msbudcCe4t.StartCoroutine_Auto(this.msbudcCe4t.RPC_nAttack(this.transform.position, vector, tID));
								if (51998 - 515204 != -463206)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (27642 - 450419 == -422776)
									{
										continue;
									}
									this.msbudcCe4t.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
									if (207537 - 43314 != 164223)
									{
										continue;
									}
								}
								goto IL_7B0;
							}
						}
						if (num < (float)3)
						{
							if (239883 - 423228 != -183345)
							{
								continue;
							}
							this.ycfubU4JiK.vDirection = myAttackTarget.transform.position;
							if (255291 - 334324 == -79032)
							{
								continue;
							}
							this.ycfubU4JiK.vDirection.y = this.transform.position.y;
							if (164870 - 371197 != -206327)
							{
								continue;
							}
							this.ycfubU4JiK.vMovement = (this.ycfubU4JiK.vDirection - this.transform.position).normalized;
							if (262716 - 557876 == -295159)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.ycfubU4JiK.vMovement);
							if (108418 - 466058 == -357639)
							{
								continue;
							}
							this.ycfubU4JiK.actionState = "standby";
							if (89131 - 121728 == -32596)
							{
								continue;
							}
							this.animation.Play("root");
							if (105472 - 261818 == -156345)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (197950 - 572604 != -374654)
							{
								continue;
							}
							this.ycfubU4JiK.moveSpeed = (float)0;
							if (84139 - 430784 == -346644)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (246759 - 580120 == -333360)
							{
								continue;
							}
							this.ycfubU4JiK.vDirection = myAttackTarget.transform.position;
							if (6678 - 219079 == -212400)
							{
								continue;
							}
							this.ycfubU4JiK.vDirection.y = this.transform.position.y;
							if (144972 - 544479 != -399507)
							{
								continue;
							}
							this.ycfubU4JiK.vMovement = (this.ycfubU4JiK.vDirection - this.transform.position).normalized;
							if (182244 - 187457 == -5212)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.ycfubU4JiK.vMovement);
							if (238855 - 182952 != 55903)
							{
								continue;
							}
							this.ycfubU4JiK.actionState = "run";
							if (160721 - 504878 != -344157)
							{
								continue;
							}
							this.animation.Play("run");
							if (215010 - 35946 != 179064)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (7814 - 299556 != -291742)
							{
								continue;
							}
							this.ycfubU4JiK.moveSpeed = Mathf.Lerp(this.ycfubU4JiK.moveSpeed, this.ycfubU4JiK.runSpeed, (float)4 * Time.deltaTime);
							if (255594 - 311243 != -55649)
							{
								continue;
							}
						}
					}
				}
			}
			IL_7B0:
			this.ITiuao8xbb += mTime;
		}
		while (284241 - 569446 != -285205);
	}

	// Token: 0x06003CF0 RID: 15600 RVA: 0x007DF274 File Offset: 0x007DD474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (5480 - 154207 != -148727)
		{
		}
		while (Time.time - this.B2nugsmyPp > this.ITiuao8xbb)
		{
			if (13246 - 236364 != -223117)
			{
				this.AI_state = "none";
				if (33148 - 285809 != -252660)
				{
					this.B2nugsmyPp = Time.time;
					if (181284 - 479638 == -298354)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003CF1 RID: 15601 RVA: 0x007DF328 File Offset: 0x007DD528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (278468 - 564720 != -286252)
		{
		}
		for (;;)
		{
			IL_250:
			if (this.IVGu42Xql8 + (float)1 > Time.time)
			{
				if (187927 - 184514 == 3413)
				{
					break;
				}
			}
			else
			{
				this.IVGu42Xql8 = Time.time;
				if (62854 - 295397 != -232542)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (171761 - 413024 == -241263)
					{
						if (277670 - 567078 == -289408)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (73721 - 219755 == -146034)
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
									if (129807 - 47852 == 81956)
									{
										goto IL_250;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (281567 - 432111 == -150543)
									{
										goto IL_250;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (45913 - 594688 != -548775)
									{
										goto IL_250;
									}
									bool flag = true;
									if (198509 - 529186 != -330677)
									{
										goto IL_250;
									}
									eRace race = this.ycfubU4JiK.Race;
									if (192403 - 98632 != 93771)
									{
										goto IL_250;
									}
									if (race == eRace.Tails)
									{
										if (199631 - 278369 != -78738)
										{
											goto IL_250;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_4B4;
										}
										if (100160 - 112309 != -12149)
										{
											goto IL_250;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (298864 - 247426 != 51439)
											{
												goto IL_4B4;
											}
											goto IL_250;
										}
										goto IL_3DF;
										IL_4B4:
										flag = false;
										if (261453 - 228852 == 32602)
										{
											goto IL_250;
										}
									}
									else if (race == eRace.Plants)
									{
										if (31140 - 71857 != -40717)
										{
											goto IL_250;
										}
										flag = false;
										if (299368 - 263866 == 35503)
										{
											goto IL_250;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (177016 - 509794 == -332777)
										{
											goto IL_250;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_1F4;
										}
										if (182240 - 231871 == -49630)
										{
											goto IL_250;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (145208 - 579150 != -433942)
											{
												goto IL_250;
											}
											goto IL_1F4;
										}
										goto IL_3DF;
										IL_1F4:
										flag = false;
										if (192185 - 339313 != -147128)
										{
											goto IL_250;
										}
									}
									else if (race == eRace.Robots)
									{
										if (243070 - 351646 != -108576)
										{
											goto IL_250;
										}
										flag = true;
										if (205165 - 141500 == 63666)
										{
											goto IL_250;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (94969 - 245999 != -151030)
										{
											goto IL_250;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_498;
										}
										if (101633 - 200553 != -98920)
										{
											goto IL_250;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_498;
										}
										if (206396 - 128981 != 77415)
										{
											goto IL_250;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (151770 - 112907 != 38863)
											{
												goto IL_250;
											}
											goto IL_498;
										}
										goto IL_3DF;
										IL_498:
										flag = false;
										if (230068 - 194663 == 35406)
										{
											goto IL_250;
										}
									}
									else if (race == eRace.Structure)
									{
										if (276564 - 417806 == -141241)
										{
											goto IL_250;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (14196 - 532234 != -518038)
											{
												goto IL_250;
											}
											flag = false;
											if (29508 - 595983 == -566474)
											{
												goto IL_250;
											}
										}
									}
									IL_3DF:
									if (flag)
									{
										if (134911 - 59180 != 75731)
										{
											goto IL_250;
										}
										if (characterControl.hp > 0)
										{
											if (269819 - 248807 != 21012)
											{
												goto IL_250;
											}
											if (characterControl.recieveTarget)
											{
												if (202583 - 443204 == -240620)
												{
													goto IL_250;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (65038 - 234182 != -169144)
													{
														goto IL_250;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (252199 - 71044 == 181156)
														{
															goto IL_250;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (42415 - 218116 == -175700)
														{
															goto IL_250;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (65338 - 366524 != -301186)
															{
																goto IL_250;
															}
															this.ycfubU4JiK.isAlert = true;
															if (113219 - 215674 == -102454)
															{
																goto IL_250;
															}
															this.B2nugsmyPp = Time.time;
															if (79565 - 474278 != -394713)
															{
																goto IL_250;
															}
															this.ycfubU4JiK.myAttackTarget = gameObject;
															if (66898 - 190846 != -123948)
															{
																goto IL_250;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (298949 - 276219 == 22731)
															{
																goto IL_250;
															}
															this.ycfubU4JiK.addHate(characterControl.ActorNr, 5);
															if (88434 - 243119 == -154684)
															{
																goto IL_250;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (292127 - 9624 != 282503)
															{
																goto IL_250;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (104482 - 530303 != -425821)
															{
																goto IL_250;
															}
															if (num < (float)60)
															{
																if (147684 - 238221 == -90536)
																{
																	goto IL_250;
																}
																if (characterControl.hp > 0)
																{
																	if (287327 - 439670 != -152343)
																	{
																		goto IL_250;
																	}
																	this.ycfubU4JiK.isAlert = true;
																	if (49737 - 380228 != -330491)
																	{
																		goto IL_250;
																	}
																	this.B2nugsmyPp = Time.time;
																	if (68625 - 358327 != -289702)
																	{
																		goto IL_250;
																	}
																	this.ycfubU4JiK.myAttackTarget = gameObject;
																	if (194501 - 529990 != -335489)
																	{
																		goto IL_250;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (189646 - 469967 == -280320)
																	{
																		goto IL_250;
																	}
																	this.ycfubU4JiK.addHate(characterControl.ActorNr, 5);
																	if (47430 - 110259 == -62828)
																	{
																		goto IL_250;
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
								if (214141 - 197372 == 16769)
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

	// Token: 0x06003CF2 RID: 15602 RVA: 0x007DFB50 File Offset: 0x007DDD50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003CF3 RID: 15603 RVA: 0x007DFB54 File Offset: 0x007DDD54
	internal static bool z57ZmN5C1tdfCQjHLLVj()
	{
		return true;
	}

	// Token: 0x06003CF4 RID: 15604 RVA: 0x007DFB58 File Offset: 0x007DDD58
	internal static bool yPCoML5C4PsikYtcxw4s()
	{
		return false;
	}

	// Token: 0x04004A4E RID: 19022
	private CharacterControl ycfubU4JiK;

	// Token: 0x04004A4F RID: 19023
	private CarryBot msbudcCe4t;

	// Token: 0x04004A50 RID: 19024
	public string AI_state;

	// Token: 0x04004A51 RID: 19025
	private float B2nugsmyPp;

	// Token: 0x04004A52 RID: 19026
	private float ITiuao8xbb;

	// Token: 0x04004A53 RID: 19027
	private float IVGu42Xql8;
}
