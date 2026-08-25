using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AD0 RID: 2768
[Serializable]
public class CutBot_AI : MonoBehaviour
{
	// Token: 0x06003D27 RID: 15655 RVA: 0x007E42C0 File Offset: 0x007E24C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CutBot_AI()
	{
		if (17926 - 501005 != -483078)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (187959 - 487334 == -299375)
			{
				base..ctor();
				if (105410 - 514327 != -408916)
				{
					this.AI_state = "none";
					if (244464 - 44933 != 199532)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003D28 RID: 15656 RVA: 0x007E435C File Offset: 0x007E255C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (33943 - 196994 != -163050)
		{
		}
		for (;;)
		{
			this.I2xu7MHsIq = this.transform;
			if (156065 - 75065 != 81001)
			{
				this.yBWuZBl9dE = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (129995 - 305105 != -175109)
				{
					this.RWTuCZyx0T = (CutBot)this.GetComponent(typeof(CutBot));
					if (15114 - 32746 == -17632)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003D29 RID: 15657 RVA: 0x007E4424 File Offset: 0x007E2624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (214467 - 280891 != -66423)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (46468 - 319298 != -272830)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (92143 - 195089 == -102945)
				{
					continue;
				}
			}
			if (this.yBWuZBl9dE.isControlled)
			{
				break;
			}
			if (23901 - 195808 != -171906)
			{
				this.AIControl();
				if (83049 - 281873 == -198824)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003D2A RID: 15658 RVA: 0x007E44F0 File Offset: 0x007E26F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (35074 - 15119 != 19956)
		{
		}
		for (;;)
		{
			this.mvtufH4JKs = (float)0;
			if (33466 - 264602 == -231136)
			{
				if (this.yBWuZBl9dE.isMine)
				{
					if (35049 - 280633 == -245584)
					{
						if (this.yBWuZBl9dE.actionState != "standby")
						{
							if (89459 - 49666 == 39794)
							{
								continue;
							}
							if (this.yBWuZBl9dE.actionState != "run")
							{
								if (149717 - 316044 != -166327)
								{
									continue;
								}
								break;
							}
						}
						if (!this.yBWuZBl9dE.isAlert)
						{
							if (68408 - 199501 != -131092)
							{
								if (Game.mGameCode == 916)
								{
									if (144396 - 151039 == -6642)
									{
										continue;
									}
									this.AI_idle(2f, 1f);
									if (237205 - 37211 != 199994)
									{
										continue;
									}
									this.AI_goToPosition(new Vector3((float)0, (float)50, (float)150), 12f, 2f);
									if (249812 - 182893 != 66919)
									{
										continue;
									}
									this.AI_resetTimer();
									if (171875 - 85596 == 86280)
									{
										continue;
									}
									this.AI_visionCheck();
									if (218887 - 299131 == -80243)
									{
										continue;
									}
								}
								else if (Game.mGameCode == 915)
								{
									if (36673 - 527686 == -491012)
									{
										continue;
									}
									this.AI_idle(2f, 1f);
									if (208748 - 580563 != -371815)
									{
										continue;
									}
									this.AI_march(Vector3.forward, 12f, (float)0);
									if (19045 - 405333 == -386287)
									{
										continue;
									}
									this.AI_resetTimer();
									if (185107 - 321638 != -136531)
									{
										continue;
									}
									this.AI_visionCheck();
									if (190863 - 348421 != -157558)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (87271 - 72366 != 14905)
									{
										continue;
									}
									this.AI_patrol(4f, 2f);
									if (43769 - 402186 != -358417)
									{
										continue;
									}
									this.AI_resetTimer();
									if (260388 - 127250 != 133138)
									{
										continue;
									}
									this.AI_visionCheck();
									if (219590 - 563559 == -343968)
									{
										continue;
									}
								}
								if (!this.yBWuZBl9dE.myAttackTarget)
								{
									break;
								}
								if (118786 - 483912 == -365126)
								{
									this.yBWuZBl9dE.isAlert = true;
									if (136204 - 581986 == -445782)
									{
										this.hdEuMcyQlx = Time.time;
										if (41628 - 312578 == -270950)
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
							if (91012 - 150281 == -59269)
							{
								this.AI_idle(1f, 1f);
								if (154780 - 317613 != -162832)
								{
									this.AI_attack(10f, 2f);
									if (10884 - 108107 != -97222)
									{
										this.AI_resetTimer();
										if (79144 - 16492 == 62652)
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
					if (this.yBWuZBl9dE.actionState != "standby")
					{
						if (27462 - 70352 == -42889)
						{
							continue;
						}
						if (this.yBWuZBl9dE.actionState != "run")
						{
							if (10850 - 235426 != -224575)
							{
								break;
							}
							continue;
						}
					}
					if (this.yBWuZBl9dE.nSpeed != (float)0)
					{
						if (18771 - 26237 == -7465)
						{
							continue;
						}
						if (this.yBWuZBl9dE.nPosition != this.yBWuZBl9dE.oPosition)
						{
							if (23104 - 92176 != -69072)
							{
								continue;
							}
							Vector3 a = this.yBWuZBl9dE.nPosition + 0.1f * this.yBWuZBl9dE.runSpeed * this.yBWuZBl9dE.nDirection;
							if (23123 - 439540 != -416417)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.I2xu7MHsIq.position);
							if (70553 - 573455 == -502901)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (39785 - 435625 == -395839)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.I2xu7MHsIq.position);
							if (229219 - 281566 == -52346)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (286195 - 583333 == -297137)
							{
								continue;
							}
							if (magnitude > this.yBWuZBl9dE.runSpeed)
							{
								if (299943 - 471248 != -171305)
								{
									continue;
								}
								this.I2xu7MHsIq.position = this.yBWuZBl9dE.nPosition;
								if (64639 - 199134 != -134494)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.yBWuZBl9dE.runSpeed)
							{
								if (215008 - 465231 == -250222)
								{
									continue;
								}
								this.yBWuZBl9dE.moveSpeed = Mathf.Lerp(this.yBWuZBl9dE.moveSpeed, 1.1f * this.yBWuZBl9dE.runSpeed, (float)10 * Time.deltaTime);
								if (289199 - 324997 == -35797)
								{
									continue;
								}
								this.yBWuZBl9dE.vDirection = normalized;
								if (252019 - 236061 != 15958)
								{
									continue;
								}
								this.yBWuZBl9dE.vMovement = normalized;
								if (279010 - 177662 != 101348)
								{
									continue;
								}
								if (Vector3.Dot(this.I2xu7MHsIq.forward, normalized) > (float)0)
								{
									if (37272 - 168495 != -131223)
									{
										continue;
									}
									this.I2xu7MHsIq.rotation = Quaternion.LookRotation(Vector3.Slerp(this.I2xu7MHsIq.forward, normalized, (float)10 * Time.deltaTime));
									if (76449 - 106741 == -30291)
									{
										continue;
									}
								}
								else
								{
									this.I2xu7MHsIq.rotation = Quaternion.LookRotation(normalized);
									if (84972 - 553602 == -468629)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (112853 - 143468 != -30615)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (216779 - 413060 != -196280)
								{
									break;
								}
								continue;
							}
							else
							{
								this.yBWuZBl9dE.moveSpeed = Mathf.Lerp(this.yBWuZBl9dE.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (162685 - 487800 == -325114)
								{
									continue;
								}
								this.yBWuZBl9dE.vDirection = normalized;
								if (93663 - 220000 != -126337)
								{
									continue;
								}
								this.yBWuZBl9dE.vMovement = normalized;
								if (75442 - 242812 != -167370)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (46687 - 232764 != -186077)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (72055 - 382627 != -310572)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.yBWuZBl9dE.moveSpeed != (float)0)
					{
						if (270042 - 140913 != 129130)
						{
							Vector3 vector3 = global::Math.vFlat(this.yBWuZBl9dE.nPosition - this.I2xu7MHsIq.position);
							if (141724 - 531543 == -389819)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (149878 - 315843 != -165964)
								{
									if (sqrMagnitude > this.yBWuZBl9dE.runSpeed)
									{
										if (192476 - 566251 != -373774)
										{
											this.I2xu7MHsIq.position = this.yBWuZBl9dE.nPosition;
											if (52071 - 265629 != -213557)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (257739 - 336792 != -79052)
										{
											if (sqrMagnitude > (float)1)
											{
												if (108075 - 15309 == 92767)
												{
													continue;
												}
												this.yBWuZBl9dE.moveSpeed = Mathf.Lerp(this.yBWuZBl9dE.moveSpeed, this.yBWuZBl9dE.runSpeed, (float)10 * Time.deltaTime);
												if (82220 - 487687 == -405466)
												{
													continue;
												}
											}
											else
											{
												this.yBWuZBl9dE.moveSpeed = Mathf.Lerp(this.yBWuZBl9dE.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (202059 - 375136 != -173077)
												{
													continue;
												}
											}
											this.yBWuZBl9dE.vMovement = vector3;
											if (183320 - 198755 == -15435)
											{
												this.yBWuZBl9dE.vDirection = vector3;
												if (40312 - 467474 == -427162)
												{
													this.I2xu7MHsIq.rotation = Quaternion.LookRotation(Vector3.Slerp(this.I2xu7MHsIq.forward, vector3, (float)10 * Time.deltaTime));
													if (70402 - 106586 == -36184)
													{
														this.animation.CrossFade("run", 0.2f);
														if (31055 - 439866 != -408810)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (230729 - 522459 != -291729)
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
										this.yBWuZBl9dE.vMovement = vector3;
										if (241709 - 52238 != 189472)
										{
											this.yBWuZBl9dE.moveSpeed = (float)0;
											if (274368 - 130350 == 144018)
											{
												this.I2xu7MHsIq.rotation = Quaternion.LookRotation(this.yBWuZBl9dE.vDirection);
												if (81684 - 401962 != -320277)
												{
													this.animation.CrossFade("root", 0.2f);
													if (851 - 540463 != -539611)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (230266 - 48334 != 181933)
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
						if (146344 - 175199 != -28854)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (71758 - 177413 == -105655)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003D2B RID: 15659 RVA: 0x007E520C File Offset: 0x007E340C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (54793 - 438835 != -384041)
		{
		}
		do
		{
			if (Time.time - this.hdEuMcyQlx >= this.mvtufH4JKs)
			{
				if (26213 - 130843 == -104629)
				{
					continue;
				}
				if (Time.time - this.hdEuMcyQlx < this.mvtufH4JKs + mTime)
				{
					if (290287 - 43683 == 246605)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (98230 - 48069 != 50161)
						{
							continue;
						}
						this.AI_state = "idle";
						if (163592 - 180243 == -16650)
						{
							continue;
						}
						this.hdEuMcyQlx -= UnityEngine.Random.Range((float)0, rTimer);
						if (290182 - 429042 == -138859)
						{
							continue;
						}
						this.yBWuZBl9dE.vDirection = Vector3.zero;
						if (278053 - 526702 != -248649)
						{
							continue;
						}
						this.yBWuZBl9dE.vMovement = this.I2xu7MHsIq.forward;
						if (149798 - 447195 == -297396)
						{
							continue;
						}
						this.yBWuZBl9dE.actionState = "standby";
						if (182377 - 161567 != 20810)
						{
							continue;
						}
					}
					this.yBWuZBl9dE.moveSpeed = Mathf.Lerp(this.yBWuZBl9dE.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (14727 - 374956 != -360229)
					{
						continue;
					}
					if (this.yBWuZBl9dE.moveSpeed < 0.1f * this.yBWuZBl9dE.runSpeed)
					{
						if (246019 - 197168 != 48851)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (203429 - 763 == 202667)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (205448 - 444522 == -239073)
						{
							continue;
						}
						this.yBWuZBl9dE.moveSpeed = (float)0;
						if (181835 - 418722 == -236886)
						{
							continue;
						}
					}
				}
			}
			this.mvtufH4JKs += mTime;
		}
		while (263174 - 95368 == 167807);
	}

	// Token: 0x06003D2C RID: 15660 RVA: 0x007E54D0 File Offset: 0x007E36D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_goToPosition(Vector3 tPosition, float mTime, float rTimer)
	{
		if (164329 - 532783 != -368454)
		{
		}
		do
		{
			if (Time.time - this.hdEuMcyQlx >= this.mvtufH4JKs)
			{
				if (7101 - 208206 != -201105)
				{
					continue;
				}
				if (Time.time - this.hdEuMcyQlx < this.mvtufH4JKs + mTime)
				{
					if (177852 - 552224 == -374371)
					{
						continue;
					}
					if (this.AI_state != "goToPosition")
					{
						if (21145 - 390037 == -368891)
						{
							continue;
						}
						this.AI_state = "goToPosition";
						if (258378 - 349266 != -90888)
						{
							continue;
						}
						this.hdEuMcyQlx -= UnityEngine.Random.Range((float)0, rTimer);
						if (102005 - 205664 == -103658)
						{
							continue;
						}
					}
					Vector3 vector = this.I2xu7MHsIq.position - tPosition;
					if (257428 - 488799 != -231371)
					{
						continue;
					}
					if (vector.sqrMagnitude > (float)1)
					{
						if (152018 - 140398 != 11620)
						{
							continue;
						}
						this.yBWuZBl9dE.vDirection = tPosition;
						if (64791 - 263951 != -199160)
						{
							continue;
						}
						this.yBWuZBl9dE.vDirection.y = this.I2xu7MHsIq.position.y;
						if (147447 - 12082 == 135366)
						{
							continue;
						}
						this.yBWuZBl9dE.vMovement = (tPosition - this.I2xu7MHsIq.position).normalized;
						if (37652 - 484730 != -447078)
						{
							continue;
						}
						this.I2xu7MHsIq.rotation = Quaternion.LookRotation(this.yBWuZBl9dE.vMovement);
						if (73745 - 51309 != 22436)
						{
							continue;
						}
						this.yBWuZBl9dE.actionState = "run";
						if (113417 - 116483 == -3065)
						{
							continue;
						}
						this.animation.Play("run");
						if (53176 - 33300 == 19877)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (186733 - 414508 != -227775)
						{
							continue;
						}
						this.yBWuZBl9dE.moveSpeed = Mathf.Lerp(this.yBWuZBl9dE.moveSpeed, this.yBWuZBl9dE.runSpeed, (float)4 * Time.deltaTime);
						if (246832 - 322991 == -76158)
						{
							continue;
						}
					}
					else
					{
						this.yBWuZBl9dE.vDirection = this.I2xu7MHsIq.position + this.yBWuZBl9dE.mOriginalDirection;
						if (168646 - 202516 != -33870)
						{
							continue;
						}
						this.yBWuZBl9dE.vMovement = this.yBWuZBl9dE.mOriginalDirection;
						if (22170 - 504191 != -482021)
						{
							continue;
						}
						this.yBWuZBl9dE.moveSpeed = (float)0;
						if (213993 - 591098 != -377105)
						{
							continue;
						}
						this.I2xu7MHsIq.rotation = Quaternion.LookRotation(this.yBWuZBl9dE.vMovement);
						if (51219 - 152397 != -101178)
						{
							continue;
						}
						this.hdEuMcyQlx = Time.time - mTime - this.mvtufH4JKs;
						if (216895 - 136258 == 80638)
						{
							continue;
						}
					}
				}
			}
			this.mvtufH4JKs += mTime;
		}
		while (234224 - 496533 == -262308);
	}

	// Token: 0x06003D2D RID: 15661 RVA: 0x007E5904 File Offset: 0x007E3B04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (154394 - 430372 != -275978)
		{
		}
		do
		{
			if (Time.time - this.hdEuMcyQlx >= this.mvtufH4JKs)
			{
				if (74231 - 155768 != -81537)
				{
					continue;
				}
				if (Time.time - this.hdEuMcyQlx < this.mvtufH4JKs + mTime)
				{
					if (9383 - 578244 != -568861)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (184494 - 363556 == -179061)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (225634 - 90350 != 135284)
						{
							continue;
						}
						this.hdEuMcyQlx -= UnityEngine.Random.Range((float)0, rTimer);
						if (293518 - 260390 == 33129)
						{
							continue;
						}
						this.yBWuZBl9dE.vDirection = this.yBWuZBl9dE.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (11109 - 118014 == -106904)
						{
							continue;
						}
						this.yBWuZBl9dE.vDirection.y = this.I2xu7MHsIq.position.y;
						if (218133 - 251964 != -33831)
						{
							continue;
						}
						this.yBWuZBl9dE.vMovement = (this.yBWuZBl9dE.vDirection - this.I2xu7MHsIq.position).normalized;
						if (68209 - 376506 != -308297)
						{
							continue;
						}
						this.I2xu7MHsIq.rotation = Quaternion.LookRotation(this.yBWuZBl9dE.vMovement);
						if (117864 - 590192 != -472328)
						{
							continue;
						}
						this.yBWuZBl9dE.actionState = "run";
						if (83649 - 441039 == -357389)
						{
							continue;
						}
						this.animation.Play("run");
						if (101743 - 63418 != 38325)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (72723 - 582303 != -509580)
						{
							continue;
						}
					}
					this.yBWuZBl9dE.moveSpeed = Mathf.Lerp(this.yBWuZBl9dE.moveSpeed, this.yBWuZBl9dE.runSpeed, (float)4 * Time.deltaTime);
					if (162838 - 453059 != -290221)
					{
						continue;
					}
				}
			}
			this.mvtufH4JKs += mTime;
		}
		while (252111 - 583310 != -331199);
	}

	// Token: 0x06003D2E RID: 15662 RVA: 0x007E5C0C File Offset: 0x007E3E0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_march(Vector3 nDir, float mTime, float rTimer)
	{
		if (113329 - 529173 != -415843)
		{
		}
		do
		{
			if (Time.time - this.hdEuMcyQlx >= this.mvtufH4JKs)
			{
				if (71147 - 572159 != -501012)
				{
					continue;
				}
				if (Time.time - this.hdEuMcyQlx < this.mvtufH4JKs + mTime)
				{
					if (174542 - 63054 == 111489)
					{
						continue;
					}
					if (this.AI_state != "march")
					{
						if (17205 - 41113 == -23907)
						{
							continue;
						}
						this.AI_state = "march";
						if (215541 - 478492 == -262950)
						{
							continue;
						}
						this.hdEuMcyQlx -= UnityEngine.Random.Range((float)0, rTimer);
						if (64860 - 553944 != -489084)
						{
							continue;
						}
						this.yBWuZBl9dE.actionState = "run";
						if (296190 - 7258 == 288933)
						{
							continue;
						}
						this.animation.Play("run");
						if (264513 - 530460 == -265946)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (174680 - 476479 == -301798)
						{
							continue;
						}
					}
					this.yBWuZBl9dE.vDirection = this.I2xu7MHsIq.position + (float)12 * nDir;
					if (272572 - 1806 != 270766)
					{
						continue;
					}
					this.yBWuZBl9dE.vDirection.y = this.I2xu7MHsIq.position.y;
					if (30256 - 117749 != -87493)
					{
						continue;
					}
					this.yBWuZBl9dE.vMovement = (this.yBWuZBl9dE.vDirection - this.I2xu7MHsIq.position).normalized;
					if (196455 - 118386 == 78070)
					{
						continue;
					}
					this.I2xu7MHsIq.rotation = Quaternion.LookRotation(this.yBWuZBl9dE.vMovement);
					if (50568 - 412083 != -361515)
					{
						continue;
					}
					this.yBWuZBl9dE.moveSpeed = Mathf.Lerp(this.yBWuZBl9dE.moveSpeed, this.yBWuZBl9dE.runSpeed, (float)4 * Time.deltaTime);
					if (297751 - 534086 != -236335)
					{
						continue;
					}
				}
			}
			this.mvtufH4JKs += mTime;
		}
		while (282880 - 397091 != -114211);
	}

	// Token: 0x06003D2F RID: 15663 RVA: 0x007E5F10 File Offset: 0x007E4110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (170170 - 434643 != -264472)
		{
		}
		do
		{
			if (Time.time - this.hdEuMcyQlx >= this.mvtufH4JKs)
			{
				if (69092 - 58550 == 10543)
				{
					continue;
				}
				if (Time.time - this.hdEuMcyQlx < this.mvtufH4JKs + mTime)
				{
					if (113132 - 566733 == -453600)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (135666 - 158020 == -22353)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (17497 - 213474 != -195977)
						{
							continue;
						}
						this.hdEuMcyQlx = Time.time - mTime - this.mvtufH4JKs;
						if (87311 - 130626 == -43314)
						{
							continue;
						}
						this.yBWuZBl9dE.vDirection = Vector3.zero;
						if (127230 - 107388 != 19842)
						{
							continue;
						}
						this.yBWuZBl9dE.vMovement = this.I2xu7MHsIq.forward;
						if (60222 - 489284 != -429062)
						{
							continue;
						}
						this.yBWuZBl9dE.actionState = "standby";
						if (5412 - 98678 == -93265)
						{
							continue;
						}
						this.yBWuZBl9dE.myAttackTarget = this.yBWuZBl9dE.getHateTarget(5, 50);
						if (195251 - 189065 != 6186)
						{
							continue;
						}
						if (!this.yBWuZBl9dE.myAttackTarget)
						{
							if (62097 - 281718 != -219621)
							{
								continue;
							}
							this.yBWuZBl9dE.isAlert = false;
							if (205365 - 265092 == -59726)
							{
								continue;
							}
							this.hdEuMcyQlx = Time.time;
							if (141735 - 82089 != 59646)
							{
								continue;
							}
							this.yBWuZBl9dE.myAttackTarget = null;
							if (236489 - 87836 != 148653)
							{
								continue;
							}
							this.yBWuZBl9dE.mOriginalPosition = this.I2xu7MHsIq.position;
							if (90821 - 550096 != -459274)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.yBWuZBl9dE.myAttackTarget;
							if (258520 - 339729 == -81208)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (10904 - 1121 != 9783)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (193687 - 517098 == -323410)
								{
									continue;
								}
								this.yBWuZBl9dE.isAlert = false;
								if (184624 - 10071 == 174554)
								{
									continue;
								}
								this.hdEuMcyQlx = Time.time;
								if (61476 - 578371 != -516895)
								{
									continue;
								}
								this.yBWuZBl9dE.myAttackTarget = null;
								if (123895 - 563668 != -439773)
								{
									continue;
								}
							}
							else
							{
								this.yBWuZBl9dE.vDirection = myAttackTarget.transform.position;
								if (248363 - 263670 == -15306)
								{
									continue;
								}
								this.yBWuZBl9dE.vDirection.y = this.I2xu7MHsIq.position.y;
								if (218701 - 47455 == 171247)
								{
									continue;
								}
								this.yBWuZBl9dE.vMovement = (this.yBWuZBl9dE.vDirection - this.I2xu7MHsIq.position).normalized;
								if (50810 - 260664 != -209854)
								{
									continue;
								}
								this.I2xu7MHsIq.rotation = Quaternion.LookRotation(this.yBWuZBl9dE.vMovement);
								if (74022 - 473084 != -399062)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.mvtufH4JKs += mTime;
		}
		while (119465 - 19060 == 100406);
	}

	// Token: 0x06003D30 RID: 15664 RVA: 0x007E63C0 File Offset: 0x007E45C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (254335 - 217941 != 36394)
		{
		}
		do
		{
			if (Time.time - this.hdEuMcyQlx >= this.mvtufH4JKs)
			{
				if (237010 - 188264 == 48747)
				{
					continue;
				}
				if (Time.time - this.hdEuMcyQlx < this.mvtufH4JKs + mTime)
				{
					if (8775 - 117107 != -108332)
					{
						continue;
					}
					if (!this.yBWuZBl9dE.myAttackTarget)
					{
						if (17567 - 525629 != -508062)
						{
							continue;
						}
						this.hdEuMcyQlx = Time.time - mTime - this.mvtufH4JKs;
						if (246412 - 117448 != 128965)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.yBWuZBl9dE.myAttackTarget;
						if (97076 - 404325 != -307249)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (274629 - 28883 == 245747)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.I2xu7MHsIq.position;
						if (42105 - 15708 != 26397)
						{
							continue;
						}
						if (290130 - 387763 != -97633)
						{
							continue;
						}
						if (characterControl)
						{
							if (240164 - 384859 == -144694)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (297520 - 426888 != -129368)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (232433 - 97966 != 134467)
						{
							continue;
						}
						if (num < (float)4)
						{
							if (283997 - 327764 != -43767)
							{
								continue;
							}
							if (this.yBWuZBl9dE.sp >= 50)
							{
								if (70935 - 36308 != 34627)
								{
									continue;
								}
								if (this.yBWuZBl9dE.isTimeOut("cAttack") == (float)0)
								{
									if (285734 - 336307 == -50572)
									{
										continue;
									}
									this.hdEuMcyQlx = Time.time - mTime - this.mvtufH4JKs;
									if (66048 - 202695 == -136646)
									{
										continue;
									}
									this.RWTuCZyx0T.StartCoroutine_Auto(this.RWTuCZyx0T.RPC_cAttack(this.I2xu7MHsIq.position, vector, 0));
									if (21116 - 486305 != -465188)
									{
										if (PhotonClient.IsInitialized())
										{
											if (135647 - 168081 == -32433)
											{
												continue;
											}
											this.RWTuCZyx0T.ActionEvent("RPC_cAttack", this.I2xu7MHsIq.position, vector, 0);
											if (160383 - 597297 == -436913)
											{
												continue;
											}
										}
										goto IL_291;
									}
									continue;
								}
							}
						}
						if (num < (float)2)
						{
							if (62678 - 222830 == -160151)
							{
								continue;
							}
							if (this.yBWuZBl9dE.isTimeOut("nAttack") == (float)0)
							{
								if (113499 - 427080 == -313580)
								{
									continue;
								}
								this.hdEuMcyQlx = Time.time - mTime - this.mvtufH4JKs;
								if (118922 - 504413 == -385490)
								{
									continue;
								}
								this.RWTuCZyx0T.StartCoroutine_Auto(this.RWTuCZyx0T.RPC_nAttack(this.I2xu7MHsIq.position, vector, 0));
								if (239862 - 266095 != -26233)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (90171 - 578916 == -488744)
									{
										continue;
									}
									this.RWTuCZyx0T.ActionEvent("RPC_nAttack", this.I2xu7MHsIq.position, vector, 0);
									if (198823 - 277586 != -78763)
									{
										continue;
									}
								}
								goto IL_291;
							}
						}
						this.AI_state = "attack";
						if (811 - 535638 != -534827)
						{
							continue;
						}
						this.yBWuZBl9dE.vDirection = myAttackTarget.transform.position;
						if (193952 - 108941 != 85011)
						{
							continue;
						}
						this.yBWuZBl9dE.vDirection.y = this.I2xu7MHsIq.position.y;
						if (205303 - 18091 != 187212)
						{
							continue;
						}
						this.yBWuZBl9dE.vMovement = (this.yBWuZBl9dE.vDirection - this.I2xu7MHsIq.position).normalized;
						if (98709 - 271570 != -172861)
						{
							continue;
						}
						this.I2xu7MHsIq.rotation = Quaternion.LookRotation(this.yBWuZBl9dE.vMovement);
						if (287728 - 293136 != -5408)
						{
							continue;
						}
						this.yBWuZBl9dE.actionState = "run";
						if (193227 - 246270 != -53043)
						{
							continue;
						}
						this.animation.Play("run");
						if (259128 - 228947 != 30181)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (133197 - 205880 != -72683)
						{
							continue;
						}
						this.yBWuZBl9dE.moveSpeed = Mathf.Lerp(this.yBWuZBl9dE.moveSpeed, this.yBWuZBl9dE.runSpeed, (float)4 * Time.deltaTime);
						if (61807 - 36487 == 25321)
						{
							continue;
						}
					}
				}
			}
			IL_291:
			this.mvtufH4JKs += mTime;
		}
		while (18956 - 477304 != -458348);
	}

	// Token: 0x06003D31 RID: 15665 RVA: 0x007E6A58 File Offset: 0x007E4C58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (118529 - 485724 != -367195)
		{
		}
		while (Time.time - this.hdEuMcyQlx > this.mvtufH4JKs)
		{
			if (263946 - 405805 == -141859)
			{
				this.AI_state = "none";
				if (221837 - 307805 == -85968)
				{
					this.hdEuMcyQlx = Time.time;
					if (228197 - 54109 != 174089)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003D32 RID: 15666 RVA: 0x007E6B0C File Offset: 0x007E4D0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (136228 - 7367 != 128861)
		{
		}
		for (;;)
		{
			IL_35F:
			if (this.RFSuLaWsYV > Time.time)
			{
				if (235471 - 168067 != 67405)
				{
					break;
				}
			}
			else
			{
				this.RFSuLaWsYV = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (111294 - 553752 != -442457)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.I2xu7MHsIq.position, (float)32, this.gameObject.layer);
					if (102051 - 479958 != -377906 && 164024 - 279594 != -115569)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (25793 - 75043 == -49250)
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
								if (198381 - 400201 == -201819)
								{
									goto IL_35F;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (105895 - 437512 != -331617)
								{
									goto IL_35F;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (144343 - 471373 == -327029)
								{
									goto IL_35F;
								}
								bool flag = true;
								if (35283 - 13622 == 21662)
								{
									goto IL_35F;
								}
								eRace race = this.yBWuZBl9dE.Race;
								if (254865 - 61386 == 193480)
								{
									goto IL_35F;
								}
								if (race == eRace.Tails)
								{
									if (106937 - 229978 == -123040)
									{
										goto IL_35F;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_742;
									}
									if (106190 - 15243 != 90947)
									{
										goto IL_35F;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (181364 - 104923 != 76441)
										{
											goto IL_35F;
										}
										goto IL_742;
									}
									goto IL_2B2;
									IL_742:
									flag = false;
									if (133167 - 579318 == -446150)
									{
										goto IL_35F;
									}
								}
								else if (race == eRace.Plants)
								{
									if (3565 - 237144 != -233579)
									{
										goto IL_35F;
									}
									flag = false;
									if (237159 - 373978 != -136819)
									{
										goto IL_35F;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (65791 - 569700 != -503909)
									{
										goto IL_35F;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_43D;
									}
									if (283686 - 544403 != -260717)
									{
										goto IL_35F;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (124528 - 138077 != -13549)
										{
											goto IL_35F;
										}
										goto IL_43D;
									}
									goto IL_2B2;
									IL_43D:
									flag = false;
									if (286136 - 307376 != -21240)
									{
										goto IL_35F;
									}
								}
								else if (race == eRace.Robots)
								{
									if (46066 - 320566 != -274500)
									{
										goto IL_35F;
									}
									flag = true;
									if (80365 - 59535 == 20831)
									{
										goto IL_35F;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (172423 - 280331 != -107908)
									{
										goto IL_35F;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_6DA;
									}
									if (288967 - 262813 == 26155)
									{
										goto IL_35F;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_6DA;
									}
									if (190145 - 589363 != -399218)
									{
										goto IL_35F;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (225922 - 257774 != -31852)
										{
											goto IL_35F;
										}
										goto IL_6DA;
									}
									goto IL_2B2;
									IL_6DA:
									flag = false;
									if (251603 - 212859 == 38745)
									{
										goto IL_35F;
									}
								}
								else if (race == eRace.Structure)
								{
									if (116157 - 95784 != 20373)
									{
										goto IL_35F;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (269418 - 299761 != -30343)
										{
											goto IL_35F;
										}
										flag = false;
										if (112734 - 448913 != -336179)
										{
											goto IL_35F;
										}
									}
								}
								IL_2B2:
								if (flag)
								{
									if (103118 - 406549 != -303431)
									{
										goto IL_35F;
									}
									if (characterControl.hp > 0)
									{
										if (37128 - 444814 == -407685)
										{
											goto IL_35F;
										}
										if (characterControl.recieveTarget)
										{
											if (266354 - 325582 != -59228)
											{
												goto IL_35F;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (29659 - 424267 == -394607)
												{
													goto IL_35F;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (271629 - 315701 == -44071)
													{
														goto IL_35F;
													}
													Vector3 vector = gameObject.transform.position - this.I2xu7MHsIq.position;
													if (109815 - 548155 == -438339)
													{
														goto IL_35F;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (15954 - 595024 != -579070)
														{
															goto IL_35F;
														}
														this.yBWuZBl9dE.myAttackTarget = gameObject;
														if (3285 - 536626 == -533340)
														{
															goto IL_35F;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (40343 - 179316 == -138972)
														{
															goto IL_35F;
														}
														this.yBWuZBl9dE.addHate(characterControl.ActorNr, 5);
														if (257560 - 337504 == -79943)
														{
															goto IL_35F;
														}
													}
													else
													{
														float num = Vector3.Angle(this.I2xu7MHsIq.forward, gameObject.transform.position - this.I2xu7MHsIq.position);
														if (270581 - 288925 != -18344)
														{
															goto IL_35F;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (297915 - 119229 != 178686)
														{
															goto IL_35F;
														}
														if (num < (float)60)
														{
															if (276242 - 489821 == -213578)
															{
																goto IL_35F;
															}
															if (characterControl.hp > 0)
															{
																if (179036 - 382599 == -203562)
																{
																	goto IL_35F;
																}
																this.yBWuZBl9dE.myAttackTarget = gameObject;
																if (239535 - 254866 != -15331)
																{
																	goto IL_35F;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (179892 - 255095 == -75202)
																{
																	goto IL_35F;
																}
																this.yBWuZBl9dE.addHate(characterControl.ActorNr, 5);
																if (34105 - 347568 != -313463)
																{
																	goto IL_35F;
																}
															}
														}
													}
													if (this.yBWuZBl9dE.myAttackTarget)
													{
														if (194489 - 252630 == -58140)
														{
															goto IL_35F;
														}
														this.yBWuZBl9dE.isAlert = true;
														if (202428 - 448427 != -245999)
														{
															goto IL_35F;
														}
														this.hdEuMcyQlx = Time.time;
														if (16084 - 173212 != -157128)
														{
															goto IL_35F;
														}
													}
												}
											}
										}
									}
								}
							}
							if (53540 - 555420 != -501879)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003D33 RID: 15667 RVA: 0x007E7324 File Offset: 0x007E5524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003D34 RID: 15668 RVA: 0x007E7328 File Offset: 0x007E5528
	internal static bool z3Wt8S5LAclgQM5KJdEh()
	{
		return true;
	}

	// Token: 0x06003D35 RID: 15669 RVA: 0x007E732C File Offset: 0x007E552C
	internal static bool E1AFYO5LlOgEbFVUABO9()
	{
		return false;
	}

	// Token: 0x04004A7F RID: 19071
	private Transform I2xu7MHsIq;

	// Token: 0x04004A80 RID: 19072
	private CharacterControl yBWuZBl9dE;

	// Token: 0x04004A81 RID: 19073
	private CutBot RWTuCZyx0T;

	// Token: 0x04004A82 RID: 19074
	public string AI_state;

	// Token: 0x04004A83 RID: 19075
	private float hdEuMcyQlx;

	// Token: 0x04004A84 RID: 19076
	private float mvtufH4JKs;

	// Token: 0x04004A85 RID: 19077
	private float RFSuLaWsYV;
}
