using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B58 RID: 2904
[Serializable]
public class Ammonite_AI : MonoBehaviour
{
	// Token: 0x0600409F RID: 16543 RVA: 0x00833678 File Offset: 0x00831878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ammonite_AI()
	{
		if (262664 - 591152 != -328488)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (91072 - 418831 != -327758)
			{
				base..ctor();
				if (42233 - 489291 == -447058)
				{
					this.AI_state = "none";
					if (252889 - 441712 == -188823)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060040A0 RID: 16544 RVA: 0x00833714 File Offset: 0x00831914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.PBpyuRtO6N = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.dhQyyBm0lZ = (Ammonite)this.GetComponent(typeof(Ammonite));
	}

	// Token: 0x060040A1 RID: 16545 RVA: 0x0083374C File Offset: 0x0083194C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (11729 - 423376 != -411647)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (119476 - 293566 == -174089)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (30405 - 518742 != -488337)
				{
					continue;
				}
			}
			if (this.PBpyuRtO6N.isControlled)
			{
				break;
			}
			if (262111 - 201621 == 60490)
			{
				this.AIControl();
				if (733 - 317509 != -316775)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060040A2 RID: 16546 RVA: 0x00833818 File Offset: 0x00831A18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (113546 - 105488 != 8059)
		{
		}
		for (;;)
		{
			this.wjYyh2pJri = (float)0;
			if (136264 - 115964 == 20300)
			{
				if (this.PBpyuRtO6N.isMine)
				{
					if (118867 - 103021 != 15847)
					{
						if (this.PBpyuRtO6N.actionState != "standby")
						{
							if (130830 - 295023 != -164193)
							{
								continue;
							}
							if (this.PBpyuRtO6N.actionState != "run")
							{
								if (250352 - 360272 != -109920)
								{
									continue;
								}
								break;
							}
						}
						if (!this.PBpyuRtO6N.isAlert)
						{
							if (247610 - 49638 == 197972)
							{
								this.AI_idle(3f, 1f);
								if (110920 - 503624 != -392703)
								{
									this.AI_patrol(5f, 1f);
									if (25015 - 268662 == -243647)
									{
										this.AI_resetTimer();
										if (93773 - 304046 == -210273)
										{
											this.AI_visionCheck();
											if (10344 - 266402 == -256058)
											{
												if (!this.PBpyuRtO6N.myAttackTarget)
												{
													break;
												}
												if (231263 - 191496 != 39768)
												{
													this.PBpyuRtO6N.isAlert = true;
													if (186855 - 358754 != -171898)
													{
														this.dk4yV4jSLk = Time.time;
														if (294040 - 590914 != -296873)
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
							if (289591 - 220013 == 69578)
							{
								this.AI_idle(3f, 1f);
								if (145 - 18695 != -18549)
								{
									this.AI_attack(6f, 2f);
									if (283240 - 36308 == 246932)
									{
										this.AI_resetTimer();
										if (289589 - 340131 == -50542)
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
					if (this.PBpyuRtO6N.actionState != "standby")
					{
						if (64243 - 106630 == -42386)
						{
							continue;
						}
						if (this.PBpyuRtO6N.actionState != "run")
						{
							if (44021 - 305781 != -261759)
							{
								break;
							}
							continue;
						}
					}
					if (this.PBpyuRtO6N.nSpeed != (float)0)
					{
						if (145391 - 516067 == -370675)
						{
							continue;
						}
						if (this.PBpyuRtO6N.nPosition != this.PBpyuRtO6N.oPosition)
						{
							if (226257 - 121909 != 104348)
							{
								continue;
							}
							Vector3 a = this.PBpyuRtO6N.nPosition + 0.1f * this.PBpyuRtO6N.runSpeed * this.PBpyuRtO6N.nDirection;
							if (122292 - 142798 == -20505)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (198712 - 63384 == 135329)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (144118 - 210385 == -66266)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (56872 - 342787 == -285914)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (13033 - 288019 != -274986)
							{
								continue;
							}
							if (magnitude > this.PBpyuRtO6N.runSpeed)
							{
								if (277247 - 71273 != 205974)
								{
									continue;
								}
								this.transform.position = this.PBpyuRtO6N.nPosition;
								if (270845 - 391343 != -120497)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.PBpyuRtO6N.runSpeed)
							{
								if (33438 - 5908 != 27530)
								{
									continue;
								}
								this.PBpyuRtO6N.moveSpeed = Mathf.Lerp(this.PBpyuRtO6N.moveSpeed, 1.1f * this.PBpyuRtO6N.runSpeed, (float)10 * Time.deltaTime);
								if (135962 - 106748 == 29215)
								{
									continue;
								}
								this.PBpyuRtO6N.vDirection = normalized;
								if (259634 - 305106 == -45471)
								{
									continue;
								}
								this.PBpyuRtO6N.vMovement = normalized;
								if (17317 - 444149 != -426832)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (110257 - 239242 == -128984)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (151042 - 261539 != -110497)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (102964 - 468949 != -365985)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (27184 - 393095 == -365910)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (125213 - 546315 != -421102)
								{
									continue;
								}
								break;
							}
							else
							{
								this.PBpyuRtO6N.moveSpeed = Mathf.Lerp(this.PBpyuRtO6N.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (267315 - 168023 != 99292)
								{
									continue;
								}
								this.PBpyuRtO6N.vDirection = normalized;
								if (131830 - 174251 == -42420)
								{
									continue;
								}
								this.PBpyuRtO6N.vMovement = normalized;
								if (53614 - 402829 != -349215)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (141503 - 200532 == -59028)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (221578 - 137849 != 83730)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.PBpyuRtO6N.moveSpeed != (float)0)
					{
						if (257152 - 461161 != -204008)
						{
							Vector3 vector3 = global::Math.vFlat(this.PBpyuRtO6N.nPosition - this.transform.position);
							if (18191 - 399397 != -381205)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (223361 - 301620 != -78258)
								{
									if (sqrMagnitude > this.PBpyuRtO6N.runSpeed)
									{
										if (281490 - 300526 != -19035)
										{
											this.transform.position = this.PBpyuRtO6N.nPosition;
											if (58230 - 236227 == -177997)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (18463 - 438835 != -420371)
										{
											if (sqrMagnitude > (float)1)
											{
												if (62119 - 112501 != -50382)
												{
													continue;
												}
												this.PBpyuRtO6N.moveSpeed = Mathf.Lerp(this.PBpyuRtO6N.moveSpeed, this.PBpyuRtO6N.runSpeed, (float)10 * Time.deltaTime);
												if (160266 - 409050 == -248783)
												{
													continue;
												}
											}
											else
											{
												this.PBpyuRtO6N.moveSpeed = Mathf.Lerp(this.PBpyuRtO6N.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (93093 - 490254 != -397161)
												{
													continue;
												}
											}
											this.PBpyuRtO6N.vMovement = vector3;
											if (126612 - 390831 != -264218)
											{
												this.PBpyuRtO6N.vDirection = vector3;
												if (96870 - 244803 != -147932)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (105803 - 159748 == -53945)
													{
														this.animation.CrossFade("run", 0.2f);
														if (26938 - 13151 == 13787)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (163083 - 288804 != -125720)
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
										this.PBpyuRtO6N.vMovement = vector3;
										if (140068 - 405009 == -264941)
										{
											this.PBpyuRtO6N.moveSpeed = (float)0;
											if (215752 - 591234 != -375481)
											{
												this.transform.rotation = Quaternion.LookRotation(this.PBpyuRtO6N.vDirection);
												if (260478 - 434371 != -173892)
												{
													this.animation.CrossFade("root", 0.2f);
													if (286454 - 57609 != 228846)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (177727 - 535343 != -357615)
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
						if (43732 - 588624 != -544891)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (182454 - 120907 != 61548)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060040A3 RID: 16547 RVA: 0x0083439C File Offset: 0x0083259C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (244377 - 238827 != 5550)
		{
		}
		do
		{
			if (Time.time - this.dk4yV4jSLk >= this.wjYyh2pJri)
			{
				if (18432 - 351957 == -333524)
				{
					continue;
				}
				if (Time.time - this.dk4yV4jSLk < this.wjYyh2pJri + mTime)
				{
					if (128038 - 428769 != -300731)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (57115 - 170466 == -113350)
						{
							continue;
						}
						this.AI_state = "idle";
						if (114690 - 427359 == -312668)
						{
							continue;
						}
						this.dk4yV4jSLk -= UnityEngine.Random.Range((float)0, rTimer);
						if (259127 - 184405 == 74723)
						{
							continue;
						}
						this.PBpyuRtO6N.vDirection = Vector3.zero;
						if (105734 - 291045 == -185310)
						{
							continue;
						}
						this.PBpyuRtO6N.vMovement = this.transform.forward;
						if (238219 - 151984 == 86236)
						{
							continue;
						}
						this.PBpyuRtO6N.actionState = "standby";
						if (94918 - 386160 == -291241)
						{
							continue;
						}
					}
					this.PBpyuRtO6N.moveSpeed = Mathf.Lerp(this.PBpyuRtO6N.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (189481 - 22730 == 166752)
					{
						continue;
					}
					if (this.PBpyuRtO6N.moveSpeed < 0.1f * this.PBpyuRtO6N.runSpeed)
					{
						if (122348 - 184148 != -61800)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (126853 - 147638 != -20785)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (162292 - 63014 != 99278)
						{
							continue;
						}
						this.PBpyuRtO6N.moveSpeed = (float)0;
						if (202456 - 481114 != -278658)
						{
							continue;
						}
					}
				}
			}
			this.wjYyh2pJri += mTime;
		}
		while (1542 - 427122 != -425580);
	}

	// Token: 0x060040A4 RID: 16548 RVA: 0x00834660 File Offset: 0x00832860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (278385 - 82089 != 196296)
		{
		}
		do
		{
			if (Time.time - this.dk4yV4jSLk >= this.wjYyh2pJri)
			{
				if (160417 - 53482 != 106935)
				{
					continue;
				}
				if (Time.time - this.dk4yV4jSLk < this.wjYyh2pJri + mTime)
				{
					if (249567 - 155223 == 94345)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (200000 - 472131 != -272131)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (272728 - 55098 == 217631)
						{
							continue;
						}
						this.dk4yV4jSLk -= UnityEngine.Random.Range((float)0, rTimer);
						if (147061 - 164418 == -17356)
						{
							continue;
						}
						this.PBpyuRtO6N.vDirection = this.PBpyuRtO6N.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (230116 - 173303 == 56814)
						{
							continue;
						}
						this.PBpyuRtO6N.vDirection.y = this.transform.position.y;
						if (122493 - 153209 == -30715)
						{
							continue;
						}
						this.PBpyuRtO6N.vMovement = (this.PBpyuRtO6N.vDirection - this.transform.position).normalized;
						if (296167 - 407074 != -110907)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.PBpyuRtO6N.vMovement);
						if (134206 - 207305 == -73098)
						{
							continue;
						}
						this.PBpyuRtO6N.actionState = "run";
						if (176000 - 474317 != -298317)
						{
							continue;
						}
						this.animation.Play("run");
						if (50538 - 458687 == -408148)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (152930 - 394088 == -241157)
						{
							continue;
						}
					}
					this.PBpyuRtO6N.moveSpeed = Mathf.Lerp(this.PBpyuRtO6N.moveSpeed, this.PBpyuRtO6N.runSpeed, (float)4 * Time.deltaTime);
					if (19126 - 343725 != -324599)
					{
						continue;
					}
				}
			}
			this.wjYyh2pJri += mTime;
		}
		while (203985 - 107449 == 96537);
	}

	// Token: 0x060040A5 RID: 16549 RVA: 0x00834968 File Offset: 0x00832B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (171831 - 534497 != -362665)
		{
		}
		do
		{
			if (Time.time - this.dk4yV4jSLk >= this.wjYyh2pJri)
			{
				if (77497 - 509038 == -431540)
				{
					continue;
				}
				if (Time.time - this.dk4yV4jSLk < this.wjYyh2pJri + mTime)
				{
					if (204052 - 527356 == -323303)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (121495 - 126959 != -5464)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (114938 - 256952 != -142014)
						{
							continue;
						}
						this.dk4yV4jSLk = Time.time - mTime - this.wjYyh2pJri;
						if (106366 - 370067 == -263700)
						{
							continue;
						}
						this.PBpyuRtO6N.vDirection = Vector3.zero;
						if (220050 - 453459 != -233409)
						{
							continue;
						}
						this.PBpyuRtO6N.vMovement = this.transform.forward;
						if (116806 - 556479 == -439672)
						{
							continue;
						}
						this.PBpyuRtO6N.actionState = "standby";
						if (129444 - 248741 != -119297)
						{
							continue;
						}
						this.PBpyuRtO6N.myAttackTarget = this.PBpyuRtO6N.getHateTarget(15, 40);
						if (132761 - 419724 != -286963)
						{
							continue;
						}
						if (!this.PBpyuRtO6N.myAttackTarget)
						{
							if (62550 - 49154 != 13396)
							{
								continue;
							}
							this.PBpyuRtO6N.isAlert = false;
							if (240753 - 589819 == -349065)
							{
								continue;
							}
							this.dk4yV4jSLk = Time.time;
							if (196245 - 526727 == -330481)
							{
								continue;
							}
							this.PBpyuRtO6N.myAttackTarget = null;
							if (100019 - 164579 == -64559)
							{
								continue;
							}
							this.PBpyuRtO6N.mOriginalPosition = this.transform.position;
							if (80711 - 518258 != -437546)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.PBpyuRtO6N.myAttackTarget;
							if (163810 - 114716 == 49095)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (139127 - 424057 == -284929)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (299772 - 187367 == 112406)
								{
									continue;
								}
								this.PBpyuRtO6N.isAlert = false;
								if (106898 - 504365 != -397467)
								{
									continue;
								}
								this.dk4yV4jSLk = Time.time;
								if (296694 - 242160 == 54535)
								{
									continue;
								}
								this.PBpyuRtO6N.myAttackTarget = null;
								if (200194 - 134428 == 65767)
								{
									continue;
								}
							}
							else
							{
								this.PBpyuRtO6N.vDirection = myAttackTarget.transform.position;
								if (91632 - 181132 != -89500)
								{
									continue;
								}
								this.PBpyuRtO6N.vDirection.y = this.transform.position.y;
								if (105527 - 370607 != -265080)
								{
									continue;
								}
								this.PBpyuRtO6N.vMovement = (this.PBpyuRtO6N.vDirection - this.transform.position).normalized;
								if (11384 - 123817 != -112433)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.PBpyuRtO6N.vMovement);
								if (31015 - 385620 != -354605)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.wjYyh2pJri += mTime;
		}
		while (89051 - 553508 == -464456);
	}

	// Token: 0x060040A6 RID: 16550 RVA: 0x00834E18 File Offset: 0x00833018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (81364 - 127258 != -45894)
		{
		}
		do
		{
			if (Time.time - this.dk4yV4jSLk >= this.wjYyh2pJri)
			{
				if (34441 - 95570 != -61129)
				{
					continue;
				}
				if (Time.time - this.dk4yV4jSLk < this.wjYyh2pJri + mTime)
				{
					if (156578 - 315846 == -159267)
					{
						continue;
					}
					if (!this.PBpyuRtO6N.myAttackTarget)
					{
						if (125886 - 17875 != 108011)
						{
							continue;
						}
						this.dk4yV4jSLk = Time.time - mTime - this.wjYyh2pJri;
						if (94410 - 210095 != -115685)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.PBpyuRtO6N.myAttackTarget;
						if (1032 - 496710 == -495677)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (280903 - 530133 != -249230)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (22320 - 221972 == -199651)
						{
							continue;
						}
						int tID = 0;
						if (295143 - 430779 == -135635)
						{
							continue;
						}
						if (characterControl)
						{
							if (134776 - 187688 == -52911)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (109799 - 143551 != -33752)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (238715 - 18464 != 220251)
						{
							continue;
						}
						if (num > (float)12)
						{
							if (29222 - 268741 != -239519)
							{
								continue;
							}
							if (this.PBpyuRtO6N.isTimeOut("hydroBlast") == (float)0)
							{
								if (179385 - 595948 == -416562)
								{
									continue;
								}
								this.dk4yV4jSLk = Time.time - mTime - this.wjYyh2pJri;
								if (119348 - 240654 != -121306)
								{
									continue;
								}
								this.dhQyyBm0lZ.StartCoroutine_Auto(this.dhQyyBm0lZ.RPC_hydroBlast(this.transform.position, vector, tID));
								if (2481 - 389238 != -386757)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (280236 - 67066 != 213170)
									{
										continue;
									}
									this.dhQyyBm0lZ.ActionEvent("RPC_hydroBlast", this.transform.position, vector, tID);
									if (27925 - 556392 == -528466)
									{
										continue;
									}
								}
								goto IL_5B3;
							}
						}
						if ((float)this.PBpyuRtO6N.hp < 0.8f * (float)this.PBpyuRtO6N.mhp)
						{
							if (247945 - 239747 == 8199)
							{
								continue;
							}
							if (this.PBpyuRtO6N.isTimeOut("guard") == (float)0)
							{
								if (91436 - 133520 != -42084)
								{
									continue;
								}
								this.dk4yV4jSLk = Time.time - mTime - this.wjYyh2pJri;
								if (139046 - 30844 == 108203)
								{
									continue;
								}
								this.dhQyyBm0lZ.StartCoroutine_Auto(this.dhQyyBm0lZ.RPC_guard(this.transform.position, this.transform.forward, 0));
								if (255291 - 352228 != -96937)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (99649 - 165947 != -66298)
									{
										continue;
									}
									this.dhQyyBm0lZ.ActionEvent("RPC_guard", this.transform.position, this.transform.forward, 0);
									if (207833 - 376575 != -168742)
									{
										continue;
									}
								}
								goto IL_5B3;
							}
						}
						if ((float)this.PBpyuRtO6N.hp < 0.4f * (float)this.PBpyuRtO6N.mhp)
						{
							if (100485 - 102083 != -1598)
							{
								continue;
							}
							if (num < (float)20)
							{
								if (141416 - 502524 != -361108)
								{
									continue;
								}
								if (this.PBpyuRtO6N.isTimeOut("rollingSmash") == (float)0)
								{
									if (120007 - 285778 != -165771)
									{
										continue;
									}
									this.dk4yV4jSLk = Time.time - mTime - this.wjYyh2pJri;
									if (296362 - 513416 != -217054)
									{
										continue;
									}
									this.dhQyyBm0lZ.StartCoroutine_Auto(this.dhQyyBm0lZ.RPC_rollingSmash(this.transform.position, vector, 0));
									if (173358 - 162189 != 11169)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (193805 - 153345 != 40460)
										{
											continue;
										}
										this.dhQyyBm0lZ.ActionEvent("RPC_rollingSmash", this.transform.position, vector, 0);
										if (22617 - 438227 != -415610)
										{
											continue;
										}
									}
									goto IL_5B3;
								}
							}
						}
						if (num <= (float)4)
						{
							if (65612 - 158393 != -92781)
							{
								continue;
							}
							if (this.PBpyuRtO6N.isTimeOut("nAttack") == (float)0)
							{
								if (293646 - 88504 == 205143)
								{
									continue;
								}
								this.dk4yV4jSLk = Time.time - mTime - this.wjYyh2pJri;
								if (259745 - 314927 != -55182)
								{
									continue;
								}
								this.dhQyyBm0lZ.StartCoroutine_Auto(this.dhQyyBm0lZ.RPC_nAttack(this.transform.position, vector, 0));
								if (93460 - 376701 != -283241)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (237385 - 301231 != -63846)
									{
										continue;
									}
									this.dhQyyBm0lZ.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (176758 - 492076 != -315318)
									{
										continue;
									}
								}
								goto IL_5B3;
							}
						}
						this.AI_state = "attack";
						if (201237 - 354994 == -153756)
						{
							continue;
						}
						this.PBpyuRtO6N.vDirection = myAttackTarget.transform.position;
						if (259014 - 446662 != -187648)
						{
							continue;
						}
						this.PBpyuRtO6N.vDirection.y = this.transform.position.y;
						if (50461 - 455666 != -405205)
						{
							continue;
						}
						this.PBpyuRtO6N.vMovement = (this.PBpyuRtO6N.vDirection - this.transform.position).normalized;
						if (227500 - 351121 != -123621)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.PBpyuRtO6N.vMovement);
						if (79357 - 338831 == -259473)
						{
							continue;
						}
						this.PBpyuRtO6N.actionState = "run";
						if (116338 - 371915 == -255576)
						{
							continue;
						}
						this.animation.Play("run");
						if (241598 - 359261 != -117663)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (59888 - 418398 == -358509)
						{
							continue;
						}
						this.PBpyuRtO6N.moveSpeed = Mathf.Lerp(this.PBpyuRtO6N.moveSpeed, this.PBpyuRtO6N.runSpeed, (float)4 * Time.deltaTime);
						if (216282 - 215757 == 526)
						{
							continue;
						}
					}
				}
			}
			IL_5B3:
			this.wjYyh2pJri += mTime;
		}
		while (285383 - 127288 != 158095);
	}

	// Token: 0x060040A7 RID: 16551 RVA: 0x00835730 File Offset: 0x00833930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (109924 - 317379 != -207454)
		{
		}
		for (;;)
		{
			IL_14D:
			if (this.okyyK1jk6J + (float)1 > Time.time)
			{
				if (268260 - 495508 != -227247)
				{
					break;
				}
			}
			else
			{
				this.okyyK1jk6J = Time.time;
				if (124161 - 523363 != -399201)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)30, this.gameObject.layer);
					if (109422 - 396952 != -287529 && 149713 - 516316 != -366602)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (199930 - 524412 == -324482)
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
								if (235550 - 446107 == -210556)
								{
									goto IL_14D;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (253433 - 50197 != 203236)
								{
									goto IL_14D;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (237758 - 19177 == 218582)
								{
									goto IL_14D;
								}
								bool flag = true;
								if (98635 - 316965 == -218329)
								{
									goto IL_14D;
								}
								eRace race = this.PBpyuRtO6N.Race;
								if (102845 - 214887 != -112042)
								{
									goto IL_14D;
								}
								if (race == eRace.Tails)
								{
									if (29777 - 203055 == -173277)
									{
										goto IL_14D;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_225;
									}
									if (26041 - 172417 == -146375)
									{
										goto IL_14D;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (154023 - 193452 != -39428)
										{
											goto IL_225;
										}
										goto IL_14D;
									}
									goto IL_272;
									IL_225:
									flag = false;
									if (129582 - 363830 != -234248)
									{
										goto IL_14D;
									}
								}
								else if (race == eRace.Plants)
								{
									if (67490 - 477256 != -409766)
									{
										goto IL_14D;
									}
									flag = false;
									if (46474 - 383897 != -337423)
									{
										goto IL_14D;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (145781 - 59039 == 86743)
									{
										goto IL_14D;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_209;
									}
									if (113262 - 97947 != 15315)
									{
										goto IL_14D;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (170461 - 459388 != -288927)
										{
											goto IL_14D;
										}
										goto IL_209;
									}
									goto IL_272;
									IL_209:
									flag = false;
									if (181629 - 387475 != -205846)
									{
										goto IL_14D;
									}
								}
								else if (race == eRace.Robots)
								{
									if (86783 - 142103 == -55319)
									{
										goto IL_14D;
									}
									flag = true;
									if (60935 - 20612 == 40324)
									{
										goto IL_14D;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (181811 - 200120 == -18308)
									{
										goto IL_14D;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_675;
									}
									if (243104 - 299426 == -56321)
									{
										goto IL_14D;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_675;
									}
									if (67093 - 225818 == -158724)
									{
										goto IL_14D;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (149353 - 153170 != -3816)
										{
											goto IL_675;
										}
										goto IL_14D;
									}
									goto IL_272;
									IL_675:
									flag = false;
									if (200241 - 154324 != 45917)
									{
										goto IL_14D;
									}
								}
								else if (race == eRace.Structure)
								{
									if (266115 - 420404 != -154289)
									{
										goto IL_14D;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (50220 - 243076 == -192855)
										{
											goto IL_14D;
										}
										flag = false;
										if (228269 - 140847 == 87423)
										{
											goto IL_14D;
										}
									}
								}
								IL_272:
								if (flag)
								{
									if (285797 - 233933 != 51864)
									{
										goto IL_14D;
									}
									if (characterControl.hp > 0)
									{
										if (183850 - 237462 != -53612)
										{
											goto IL_14D;
										}
										if (characterControl.recieveTarget)
										{
											if (278758 - 235149 == 43610)
											{
												goto IL_14D;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (17058 - 71873 != -54815)
												{
													goto IL_14D;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (36877 - 235889 != -199012)
													{
														goto IL_14D;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (218479 - 238039 == -19559)
													{
														goto IL_14D;
													}
													if (vector.sqrMagnitude < (float)400)
													{
														if (93404 - 319557 == -226152)
														{
															goto IL_14D;
														}
														this.PBpyuRtO6N.isAlert = true;
														if (35043 - 576879 == -541835)
														{
															goto IL_14D;
														}
														this.dk4yV4jSLk = Time.time;
														if (193978 - 305120 != -111142)
														{
															goto IL_14D;
														}
														this.PBpyuRtO6N.myAttackTarget = gameObject;
														if (41351 - 440861 == -399509)
														{
															goto IL_14D;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (170071 - 582934 == -412862)
														{
															goto IL_14D;
														}
														this.PBpyuRtO6N.addHate(characterControl.ActorNr, 5);
														if (137577 - 531771 != -394194)
														{
															goto IL_14D;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (290143 - 416549 != -126406)
														{
															goto IL_14D;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (41400 - 225554 == -184153)
														{
															goto IL_14D;
														}
														if (num < (float)60)
														{
															if (176505 - 49532 == 126974)
															{
																goto IL_14D;
															}
															if (characterControl.hp > 0)
															{
																if (115869 - 11441 != 104428)
																{
																	goto IL_14D;
																}
																this.PBpyuRtO6N.isAlert = true;
																if (81359 - 92115 == -10755)
																{
																	goto IL_14D;
																}
																this.dk4yV4jSLk = Time.time;
																if (211305 - 356681 == -145375)
																{
																	goto IL_14D;
																}
																this.PBpyuRtO6N.myAttackTarget = gameObject;
																if (205365 - 360299 != -154934)
																{
																	goto IL_14D;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (182861 - 460905 == -278043)
																{
																	goto IL_14D;
																}
																this.PBpyuRtO6N.addHate(characterControl.ActorNr, 5);
																if (255570 - 42158 != 213412)
																{
																	goto IL_14D;
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
							if (120551 - 31280 == 89271)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060040A8 RID: 16552 RVA: 0x00835F58 File Offset: 0x00834158
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (245688 - 371970 != -126281)
		{
		}
		while (Time.time - this.dk4yV4jSLk > this.wjYyh2pJri)
		{
			if (6557 - 545134 != -538576)
			{
				this.AI_state = "none";
				if (178104 - 189852 == -11748)
				{
					this.dk4yV4jSLk = Time.time;
					if (39167 - 249633 != -210465)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060040A9 RID: 16553 RVA: 0x0083600C File Offset: 0x0083420C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060040AA RID: 16554 RVA: 0x00836010 File Offset: 0x00834210
	internal static bool dk2R9K5MDYjqi6J1a7S2()
	{
		return true;
	}

	// Token: 0x060040AB RID: 16555 RVA: 0x00836014 File Offset: 0x00834214
	internal static bool MqkbVI5MvbXnPEWsnT8y()
	{
		return false;
	}

	// Token: 0x04004CEB RID: 19691
	private CharacterControl PBpyuRtO6N;

	// Token: 0x04004CEC RID: 19692
	private Ammonite dhQyyBm0lZ;

	// Token: 0x04004CED RID: 19693
	public string AI_state;

	// Token: 0x04004CEE RID: 19694
	private float dk4yV4jSLk;

	// Token: 0x04004CEF RID: 19695
	private float wjYyh2pJri;

	// Token: 0x04004CF0 RID: 19696
	private float okyyK1jk6J;
}
