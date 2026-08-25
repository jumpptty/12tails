using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000380 RID: 896
[Serializable]
public class Shade2AI : MonoBehaviour
{
	// Token: 0x0600147A RID: 5242 RVA: 0x00203078 File Offset: 0x00201278
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shade2AI()
	{
		if (137007 - 258340 != -121332)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (30099 - 75714 == -45615)
			{
				base..ctor();
				if (183529 - 598349 == -414820)
				{
					this.AI_state = "none";
					if (179047 - 527362 == -348315)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x00203114 File Offset: 0x00201314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.w1Wt0BGUXx = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Tnnt8viklb = (Shade2)this.GetComponent(typeof(Shade2));
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x0020314C File Offset: 0x0020134C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (87466 - 145836 != -58369)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (97706 - 6388 == 91319)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (144193 - 95938 != 48255)
				{
					continue;
				}
			}
			if (this.w1Wt0BGUXx.isControlled)
			{
				break;
			}
			if (155761 - 380927 == -225166)
			{
				this.AIControl();
				if (197974 - 282944 == -84970)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x00203218 File Offset: 0x00201418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (86500 - 168458 != -81957)
		{
		}
		for (;;)
		{
			this.AibtDYL167 = (float)0;
			if (48153 - 530609 == -482456)
			{
				if (this.w1Wt0BGUXx.isMine)
				{
					if (144384 - 545286 == -400902)
					{
						if (this.w1Wt0BGUXx.actionState != "standby")
						{
							if (134870 - 377405 == -242534)
							{
								continue;
							}
							if (this.w1Wt0BGUXx.actionState != "run")
							{
								if (244524 - 47788 != 196737)
								{
									break;
								}
								continue;
							}
						}
						if (!this.w1Wt0BGUXx.isAlert)
						{
							if (277535 - 280379 == -2844)
							{
								this.AI_idle(3f, 1f);
								if (56354 - 285336 != -228981)
								{
									this.AI_patrol(2f, 0.25f);
									if (267077 - 235416 != 31662)
									{
										this.AI_resetTimer();
										if (231074 - 57780 == 173294)
										{
											this.AI_visionCheck();
											if (62878 - 316002 == -253124)
											{
												if (!this.w1Wt0BGUXx.myAttackTarget)
												{
													break;
												}
												if (89552 - 132268 == -42716)
												{
													this.w1Wt0BGUXx.isAlert = true;
													if (239373 - 510835 != -271461)
													{
														this.RGLti32tVl = Time.time;
														if (158056 - 198446 == -40390)
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
							if (253186 - 379125 != -125938)
							{
								this.AI_idle(2f, 1f);
								if (114379 - 495512 == -381133)
								{
									this.AI_patrol(2f, 1f);
									if (46496 - 343105 != -296608)
									{
										this.AI_attack(4f, (float)0);
										if (287483 - 434590 != -147106)
										{
											this.AI_resetTimer();
											if (228827 - 440384 != -211556)
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
					if (this.w1Wt0BGUXx.actionState != "standby")
					{
						if (97523 - 415998 == -318474)
						{
							continue;
						}
						if (this.w1Wt0BGUXx.actionState != "run")
						{
							if (284596 - 233183 != 51414)
							{
								break;
							}
							continue;
						}
					}
					if (this.w1Wt0BGUXx.nSpeed != (float)0)
					{
						if (116711 - 171446 == -54734)
						{
							continue;
						}
						if (this.w1Wt0BGUXx.nPosition != this.w1Wt0BGUXx.oPosition)
						{
							if (49479 - 322418 != -272939)
							{
								continue;
							}
							Vector3 a = this.w1Wt0BGUXx.nPosition + 0.1f * this.w1Wt0BGUXx.runSpeed * this.w1Wt0BGUXx.nDirection;
							if (191927 - 186776 != 5151)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (23381 - 328099 == -304717)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (126877 - 528778 == -401900)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (265902 - 395003 != -129101)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (243167 - 49465 != 193702)
							{
								continue;
							}
							if (magnitude > this.w1Wt0BGUXx.runSpeed)
							{
								if (227430 - 24705 != 202725)
								{
									continue;
								}
								this.transform.position = this.w1Wt0BGUXx.nPosition;
								if (161624 - 517481 != -355857)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.w1Wt0BGUXx.runSpeed)
							{
								if (91745 - 369981 != -278236)
								{
									continue;
								}
								this.w1Wt0BGUXx.moveSpeed = Mathf.Lerp(this.w1Wt0BGUXx.moveSpeed, 1.1f * this.w1Wt0BGUXx.runSpeed, (float)10 * Time.deltaTime);
								if (153256 - 367498 == -214241)
								{
									continue;
								}
								this.w1Wt0BGUXx.vDirection = normalized;
								if (32587 - 382404 != -349817)
								{
									continue;
								}
								this.w1Wt0BGUXx.vMovement = normalized;
								if (2901 - 260090 == -257188)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (47292 - 535613 != -488321)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (299313 - 31789 == 267525)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (20263 - 447368 != -427105)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (72195 - 284215 == -212019)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (15311 - 547418 != -532107)
								{
									continue;
								}
								break;
							}
							else
							{
								this.w1Wt0BGUXx.moveSpeed = Mathf.Lerp(this.w1Wt0BGUXx.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (162724 - 2389 != 160335)
								{
									continue;
								}
								this.w1Wt0BGUXx.vDirection = normalized;
								if (292471 - 408596 == -116124)
								{
									continue;
								}
								this.w1Wt0BGUXx.vMovement = normalized;
								if (170674 - 569158 != -398484)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (188331 - 43109 != 145222)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (131641 - 293001 != -161359)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.w1Wt0BGUXx.moveSpeed != (float)0)
					{
						if (48649 - 570609 != -521959)
						{
							Vector3 vector3 = global::Math.vFlat(this.w1Wt0BGUXx.nPosition - this.transform.position);
							if (230651 - 564477 == -333826)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (95088 - 2549 == 92539)
								{
									if (sqrMagnitude > this.w1Wt0BGUXx.runSpeed)
									{
										if (40998 - 203095 != -162096)
										{
											this.transform.position = this.w1Wt0BGUXx.nPosition;
											if (164026 - 173757 == -9731)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (43893 - 259081 != -215187)
										{
											if (sqrMagnitude > (float)1)
											{
												if (196353 - 92075 == 104279)
												{
													continue;
												}
												this.w1Wt0BGUXx.moveSpeed = Mathf.Lerp(this.w1Wt0BGUXx.moveSpeed, this.w1Wt0BGUXx.runSpeed, (float)10 * Time.deltaTime);
												if (70220 - 556151 == -485930)
												{
													continue;
												}
											}
											else
											{
												this.w1Wt0BGUXx.moveSpeed = Mathf.Lerp(this.w1Wt0BGUXx.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (200033 - 484199 != -284166)
												{
													continue;
												}
											}
											this.w1Wt0BGUXx.vMovement = vector3;
											if (49578 - 35118 != 14461)
											{
												this.w1Wt0BGUXx.vDirection = vector3;
												if (282655 - 407922 != -125266)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (125395 - 7344 != 118052)
													{
														this.animation.CrossFade("run", 0.2f);
														if (182782 - 581762 == -398980)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (17323 - 221631 == -204308)
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
										this.w1Wt0BGUXx.vMovement = vector3;
										if (190840 - 562018 != -371177)
										{
											this.w1Wt0BGUXx.moveSpeed = (float)0;
											if (104438 - 126605 != -22166)
											{
												this.transform.rotation = Quaternion.LookRotation(this.w1Wt0BGUXx.vDirection);
												if (229168 - 257002 == -27834)
												{
													this.animation.CrossFade("root", 0.2f);
													if (18108 - 435529 != -417420)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (71068 - 407092 == -336024)
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
						if (223965 - 402207 == -178242)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (268880 - 425499 == -156619)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00203DC4 File Offset: 0x00201FC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (113938 - 553856 != -439918)
		{
		}
		do
		{
			if (Time.time - this.RGLti32tVl >= this.AibtDYL167)
			{
				if (122608 - 509847 != -387239)
				{
					continue;
				}
				if (Time.time - this.RGLti32tVl < this.AibtDYL167 + mTime)
				{
					if (185126 - 575264 == -390137)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (79667 - 46819 == 32849)
						{
							continue;
						}
						this.AI_state = "idle";
						if (128257 - 570486 == -442228)
						{
							continue;
						}
						this.RGLti32tVl -= UnityEngine.Random.Range((float)0, rTimer);
						if (33002 - 526805 == -493802)
						{
							continue;
						}
						this.w1Wt0BGUXx.vDirection = Vector3.zero;
						if (122076 - 147610 == -25533)
						{
							continue;
						}
						this.w1Wt0BGUXx.vMovement = this.transform.forward;
						if (287090 - 595270 != -308180)
						{
							continue;
						}
						this.w1Wt0BGUXx.actionState = "standby";
						if (282778 - 513587 == -230808)
						{
							continue;
						}
					}
					this.w1Wt0BGUXx.moveSpeed = Mathf.Lerp(this.w1Wt0BGUXx.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (248945 - 174154 != 74791)
					{
						continue;
					}
					if (this.w1Wt0BGUXx.moveSpeed < 0.1f * this.w1Wt0BGUXx.runSpeed)
					{
						if (237713 - 247344 != -9631)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (148711 - 298818 == -150106)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (187615 - 556055 == -368439)
						{
							continue;
						}
						this.w1Wt0BGUXx.moveSpeed = (float)0;
						if (247699 - 434256 == -186556)
						{
							continue;
						}
					}
				}
			}
			this.AibtDYL167 += mTime;
		}
		while (265563 - 467560 == -201996);
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x00204088 File Offset: 0x00202288
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (64900 - 121142 != -56242)
		{
		}
		do
		{
			if (Time.time - this.RGLti32tVl >= this.AibtDYL167)
			{
				if (113594 - 210010 == -96415)
				{
					continue;
				}
				if (Time.time - this.RGLti32tVl < this.AibtDYL167 + mTime)
				{
					if (141049 - 225240 != -84191)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (238987 - 205346 != 33641)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (222781 - 19734 != 203047)
						{
							continue;
						}
						this.RGLti32tVl -= UnityEngine.Random.Range((float)0, rTimer);
						if (162556 - 559605 != -397049)
						{
							continue;
						}
						this.w1Wt0BGUXx.vDirection = this.w1Wt0BGUXx.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (26068 - 85893 != -59825)
						{
							continue;
						}
						this.w1Wt0BGUXx.vDirection.y = this.transform.position.y;
						if (264853 - 7586 != 257267)
						{
							continue;
						}
						this.w1Wt0BGUXx.vMovement = (this.w1Wt0BGUXx.vDirection - this.transform.position).normalized;
						if (271699 - 46899 == 224801)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.w1Wt0BGUXx.vMovement);
						if (85511 - 231964 != -146453)
						{
							continue;
						}
						this.w1Wt0BGUXx.actionState = "run";
						if (156316 - 35444 == 120873)
						{
							continue;
						}
						this.animation.Play("run");
						if (278272 - 278778 != -506)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (74088 - 299584 != -225496)
						{
							continue;
						}
					}
					this.w1Wt0BGUXx.moveSpeed = Mathf.Lerp(this.w1Wt0BGUXx.moveSpeed, this.w1Wt0BGUXx.runSpeed, (float)4 * Time.deltaTime);
					if (276106 - 42594 != 233512)
					{
						continue;
					}
				}
			}
			this.AibtDYL167 += mTime;
		}
		while (25867 - 72742 != -46875);
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x00204390 File Offset: 0x00202590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (4689 - 4554 != 136)
		{
		}
		do
		{
			if (Time.time - this.RGLti32tVl >= this.AibtDYL167)
			{
				if (178757 - 370517 == -191759)
				{
					continue;
				}
				if (Time.time - this.RGLti32tVl < this.AibtDYL167 + mTime)
				{
					if (51811 - 538384 == -486572)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (14102 - 342621 != -328519)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (168407 - 468422 != -300015)
						{
							continue;
						}
						this.RGLti32tVl = Time.time - mTime - this.AibtDYL167;
						if (250975 - 566054 == -315078)
						{
							continue;
						}
						this.w1Wt0BGUXx.vDirection = Vector3.zero;
						if (124414 - 559998 != -435584)
						{
							continue;
						}
						this.w1Wt0BGUXx.vMovement = this.transform.forward;
						if (234290 - 581667 == -347376)
						{
							continue;
						}
						this.w1Wt0BGUXx.actionState = "standby";
						if (220625 - 51766 == 168860)
						{
							continue;
						}
						this.w1Wt0BGUXx.myAttackTarget = this.w1Wt0BGUXx.getHateTarget(15, 40);
						if (253528 - 166936 != 86592)
						{
							continue;
						}
						if (!this.w1Wt0BGUXx.myAttackTarget)
						{
							if (243903 - 469965 != -226062)
							{
								continue;
							}
							this.w1Wt0BGUXx.isAlert = false;
							if (22807 - 472053 == -449245)
							{
								continue;
							}
							this.RGLti32tVl = Time.time;
							if (70129 - 361402 == -291272)
							{
								continue;
							}
							this.w1Wt0BGUXx.myAttackTarget = null;
							if (274323 - 258249 == 16075)
							{
								continue;
							}
							this.w1Wt0BGUXx.mOriginalPosition = this.transform.position;
							if (204071 - 570742 != -366670)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.w1Wt0BGUXx.myAttackTarget;
							if (17277 - 302461 != -285184)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (94707 - 407132 == -312424)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (112193 - 317380 == -205186)
								{
									continue;
								}
								this.w1Wt0BGUXx.isAlert = false;
								if (247805 - 234867 != 12938)
								{
									continue;
								}
								this.RGLti32tVl = Time.time;
								if (226781 - 440839 != -214058)
								{
									continue;
								}
								this.w1Wt0BGUXx.myAttackTarget = null;
								if (107492 - 417931 == -310438)
								{
									continue;
								}
							}
							else
							{
								this.w1Wt0BGUXx.vDirection = myAttackTarget.transform.position;
								if (120743 - 553845 != -433102)
								{
									continue;
								}
								this.w1Wt0BGUXx.vDirection.y = this.transform.position.y;
								if (46672 - 18482 != 28190)
								{
									continue;
								}
								this.w1Wt0BGUXx.vMovement = (this.w1Wt0BGUXx.vDirection - this.transform.position).normalized;
								if (222657 - 17309 != 205348)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.w1Wt0BGUXx.vMovement);
								if (87759 - 573380 == -485620)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.AibtDYL167 += mTime;
		}
		while (231217 - 347819 != -116602);
	}

	// Token: 0x06001481 RID: 5249 RVA: 0x00204840 File Offset: 0x00202A40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (149721 - 261271 != -111549)
		{
		}
		do
		{
			if (Time.time - this.RGLti32tVl >= this.AibtDYL167)
			{
				if (286753 - 345413 == -58659)
				{
					continue;
				}
				if (Time.time - this.RGLti32tVl < this.AibtDYL167 + mTime)
				{
					if (126658 - 21556 == 105103)
					{
						continue;
					}
					if (!this.w1Wt0BGUXx.myAttackTarget)
					{
						if (96488 - 360827 != -264339)
						{
							continue;
						}
						this.RGLti32tVl = Time.time - mTime - this.AibtDYL167;
						if (48126 - 478063 != -429936)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.w1Wt0BGUXx.myAttackTarget;
						if (264280 - 155383 != 108897)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (256921 - 65976 == 190946)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (119005 - 197506 == -78500)
						{
							continue;
						}
						int tID = 0;
						if (208044 - 445066 == -237021)
						{
							continue;
						}
						if (characterControl)
						{
							if (181559 - 50800 != 130759)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (231701 - 108536 != 123165)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (107919 - 89464 == 18456)
						{
							continue;
						}
						if (num < (float)30)
						{
							if (238084 - 104528 == 133557)
							{
								continue;
							}
							if (this.w1Wt0BGUXx.isTimeOut("nAttack") == (float)0)
							{
								if (17307 - 354899 == -337591)
								{
									continue;
								}
								this.RGLti32tVl = Time.time - mTime - this.AibtDYL167;
								if (207628 - 356891 == -149262)
								{
									continue;
								}
								this.Tnnt8viklb.StartCoroutine_Auto(this.Tnnt8viklb.RPC_nAttack(this.transform.position, vector, tID));
								if (79657 - 362477 != -282819)
								{
									if (PhotonClient.IsInitialized())
									{
										if (23759 - 369868 == -346108)
										{
											continue;
										}
										this.Tnnt8viklb.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
										if (90623 - 248832 == -158208)
										{
											continue;
										}
									}
									goto IL_78;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (272172 - 8533 != 263639)
						{
							continue;
						}
						if (num < (float)6)
						{
							if (147877 - 374406 == -226528)
							{
								continue;
							}
							this.w1Wt0BGUXx.vDirection = myAttackTarget.transform.position;
							if (643 - 591587 != -590944)
							{
								continue;
							}
							this.w1Wt0BGUXx.vDirection.y = this.transform.position.y;
							if (229436 - 391656 != -162220)
							{
								continue;
							}
							this.w1Wt0BGUXx.vMovement = (this.transform.position - this.w1Wt0BGUXx.vDirection).normalized;
							if (12800 - 300211 == -287410)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.w1Wt0BGUXx.vMovement);
							if (38661 - 169648 != -130987)
							{
								continue;
							}
							this.w1Wt0BGUXx.actionState = "run";
							if (222160 - 266981 == -44820)
							{
								continue;
							}
							this.animation.Play("run");
							if (69662 - 57442 == 12221)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (234763 - 229699 == 5065)
							{
								continue;
							}
							this.w1Wt0BGUXx.moveSpeed = Mathf.Lerp(this.w1Wt0BGUXx.moveSpeed, this.w1Wt0BGUXx.runSpeed, (float)4 * Time.deltaTime);
							if (218698 - 499666 == -280967)
							{
								continue;
							}
						}
						else if (num < (float)30)
						{
							if (229131 - 309020 != -79889)
							{
								continue;
							}
							this.w1Wt0BGUXx.actionState = "standby";
							if (207754 - 165690 != 42064)
							{
								continue;
							}
							this.animation.Play("root");
							if (121398 - 346278 == -224879)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (220821 - 238535 == -17713)
							{
								continue;
							}
							this.w1Wt0BGUXx.moveSpeed = Mathf.Lerp(this.w1Wt0BGUXx.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (181814 - 224097 == -42282)
							{
								continue;
							}
						}
						else
						{
							this.w1Wt0BGUXx.vDirection = myAttackTarget.transform.position;
							if (70208 - 339855 == -269646)
							{
								continue;
							}
							this.w1Wt0BGUXx.vDirection.y = this.transform.position.y;
							if (36519 - 259659 == -223139)
							{
								continue;
							}
							this.w1Wt0BGUXx.vMovement = (this.w1Wt0BGUXx.vDirection - this.transform.position).normalized;
							if (131107 - 148515 != -17408)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.w1Wt0BGUXx.vMovement);
							if (183303 - 575464 == -392160)
							{
								continue;
							}
							this.w1Wt0BGUXx.actionState = "run";
							if (274680 - 107506 == 167175)
							{
								continue;
							}
							this.animation.Play("run");
							if (193913 - 247445 != -53532)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (232151 - 401049 != -168898)
							{
								continue;
							}
							this.w1Wt0BGUXx.moveSpeed = Mathf.Lerp(this.w1Wt0BGUXx.moveSpeed, this.w1Wt0BGUXx.runSpeed, (float)4 * Time.deltaTime);
							if (206721 - 387702 == -180980)
							{
								continue;
							}
						}
					}
				}
			}
			IL_78:
			this.AibtDYL167 += mTime;
		}
		while (129441 - 544517 != -415076);
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00205044 File Offset: 0x00203244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (236189 - 269645 != -33456)
		{
		}
		for (;;)
		{
			IL_4EA:
			if (this.U84tmvjEhI + (float)1 > Time.time)
			{
				if (262696 - 173981 != 88716)
				{
					break;
				}
			}
			else
			{
				this.U84tmvjEhI = Time.time;
				if (94375 - 542880 != -448504)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)30, this.gameObject.layer);
					if (91873 - 211416 != -119542)
					{
						if (7477 - 243334 == -235857)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (66995 - 118186 == -51191)
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
									if (149978 - 69756 != 80222)
									{
										goto IL_4EA;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (213544 - 45119 == 168426)
									{
										goto IL_4EA;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (262385 - 387852 == -125466)
									{
										goto IL_4EA;
									}
									bool flag = true;
									if (109085 - 422371 != -313286)
									{
										goto IL_4EA;
									}
									eRace race = this.w1Wt0BGUXx.Race;
									if (23165 - 596972 != -573807)
									{
										goto IL_4EA;
									}
									if (race == eRace.Tails)
									{
										if (11316 - 145561 != -134245)
										{
											goto IL_4EA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_261;
										}
										if (111778 - 55240 == 56539)
										{
											goto IL_4EA;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (248710 - 359547 != -110837)
											{
												goto IL_4EA;
											}
											goto IL_261;
										}
										goto IL_769;
										IL_261:
										flag = false;
										if (47305 - 76402 == -29096)
										{
											goto IL_4EA;
										}
									}
									else if (race == eRace.Plants)
									{
										if (218275 - 230328 != -12053)
										{
											goto IL_4EA;
										}
										flag = false;
										if (133943 - 492178 != -358235)
										{
											goto IL_4EA;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (288031 - 537016 != -248985)
										{
											goto IL_4EA;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_27D;
										}
										if (60524 - 332358 != -271834)
										{
											goto IL_4EA;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (275517 - 578435 != -302917)
											{
												goto IL_27D;
											}
											goto IL_4EA;
										}
										goto IL_769;
										IL_27D:
										flag = false;
										if (224322 - 319146 == -94823)
										{
											goto IL_4EA;
										}
									}
									else if (race == eRace.Robots)
									{
										if (189728 - 298656 == -108927)
										{
											goto IL_4EA;
										}
										flag = true;
										if (259251 - 176162 != 83089)
										{
											goto IL_4EA;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (134685 - 292756 == -158070)
										{
											goto IL_4EA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5A6;
										}
										if (82503 - 164373 == -81869)
										{
											goto IL_4EA;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5A6;
										}
										if (84694 - 122504 == -37809)
										{
											goto IL_4EA;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (298504 - 359429 != -60924)
											{
												goto IL_5A6;
											}
											goto IL_4EA;
										}
										goto IL_769;
										IL_5A6:
										flag = false;
										if (234968 - 599495 != -364527)
										{
											goto IL_4EA;
										}
									}
									else if (race == eRace.Structure)
									{
										if (170624 - 198939 != -28315)
										{
											goto IL_4EA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (38969 - 290454 != -251485)
											{
												goto IL_4EA;
											}
											flag = false;
											if (102786 - 297553 == -194766)
											{
												goto IL_4EA;
											}
										}
									}
									IL_769:
									if (flag)
									{
										if (204589 - 202116 == 2474)
										{
											goto IL_4EA;
										}
										if (characterControl.hp > 0)
										{
											if (57617 - 128490 != -70873)
											{
												goto IL_4EA;
											}
											if (characterControl.recieveTarget)
											{
												if (83449 - 81679 != 1770)
												{
													goto IL_4EA;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (184876 - 281175 != -96299)
													{
														goto IL_4EA;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (124317 - 527555 != -403238)
														{
															goto IL_4EA;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (273382 - 108492 == 164891)
														{
															goto IL_4EA;
														}
														if (vector.sqrMagnitude < (float)400)
														{
															if (5389 - 391557 == -386167)
															{
																goto IL_4EA;
															}
															this.w1Wt0BGUXx.isAlert = true;
															if (93625 - 300777 != -207152)
															{
																goto IL_4EA;
															}
															this.RGLti32tVl = Time.time;
															if (280979 - 316189 != -35210)
															{
																goto IL_4EA;
															}
															this.w1Wt0BGUXx.myAttackTarget = gameObject;
															if (165687 - 164040 != 1647)
															{
																goto IL_4EA;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (47585 - 444973 != -397388)
															{
																goto IL_4EA;
															}
															this.w1Wt0BGUXx.addHate(characterControl.ActorNr, 5);
															if (159755 - 287586 == -127830)
															{
																goto IL_4EA;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (231730 - 498982 == -267251)
															{
																goto IL_4EA;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (199901 - 371652 == -171750)
															{
																goto IL_4EA;
															}
															if (num < (float)60)
															{
																if (182439 - 357694 == -175254)
																{
																	goto IL_4EA;
																}
																if (characterControl.hp > 0)
																{
																	if (205444 - 153135 != 52309)
																	{
																		goto IL_4EA;
																	}
																	this.w1Wt0BGUXx.isAlert = true;
																	if (134986 - 379976 == -244989)
																	{
																		goto IL_4EA;
																	}
																	this.RGLti32tVl = Time.time;
																	if (277101 - 69862 == 207240)
																	{
																		goto IL_4EA;
																	}
																	this.w1Wt0BGUXx.myAttackTarget = gameObject;
																	if (113287 - 77695 == 35593)
																	{
																		goto IL_4EA;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (142197 - 165036 == -22838)
																	{
																		goto IL_4EA;
																	}
																	this.w1Wt0BGUXx.addHate(characterControl.ActorNr, 5);
																	if (295149 - 148398 == 146752)
																	{
																		goto IL_4EA;
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
								if (20681 - 19142 != 1540)
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

	// Token: 0x06001483 RID: 5251 RVA: 0x0020586C File Offset: 0x00203A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (60176 - 313326 != -253149)
		{
		}
		while (Time.time - this.RGLti32tVl > this.AibtDYL167)
		{
			if (155398 - 281955 != -126556)
			{
				this.AI_state = "none";
				if (196300 - 585085 == -388785)
				{
					this.RGLti32tVl = Time.time;
					if (184263 - 97970 == 86293)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00205920 File Offset: 0x00203B20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00205924 File Offset: 0x00203B24
	internal static bool KqPYt1OjE13keL8RYvZ()
	{
		return true;
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x00205928 File Offset: 0x00203B28
	internal static bool rbTp0rOhYIjuIsFUuCP()
	{
		return false;
	}

	// Token: 0x040011CB RID: 4555
	private CharacterControl w1Wt0BGUXx;

	// Token: 0x040011CC RID: 4556
	private Shade2 Tnnt8viklb;

	// Token: 0x040011CD RID: 4557
	public string AI_state;

	// Token: 0x040011CE RID: 4558
	private float RGLti32tVl;

	// Token: 0x040011CF RID: 4559
	private float AibtDYL167;

	// Token: 0x040011D0 RID: 4560
	private float U84tmvjEhI;
}
