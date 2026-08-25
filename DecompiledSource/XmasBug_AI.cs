using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000260 RID: 608
[Serializable]
public class XmasBug_AI : MonoBehaviour
{
	// Token: 0x06000DD6 RID: 3542 RVA: 0x0015FA68 File Offset: 0x0015DC68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public XmasBug_AI()
	{
		if (195624 - 77253 != 118372)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (244823 - 2314 != 242510)
			{
				base..ctor();
				if (197846 - 100587 == 97259)
				{
					this.AI_state = "none";
					if (246223 - 512635 == -266412)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x0015FB04 File Offset: 0x0015DD04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.eUsIDvlLZp = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.tILImH9EZq = (XmasBug)this.GetComponent(typeof(XmasBug));
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x0015FB3C File Offset: 0x0015DD3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (18463 - 221371 != -202908)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (9573 - 27875 != -18302)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (192354 - 576754 != -384400)
				{
					continue;
				}
			}
			if (this.eUsIDvlLZp.isControlled)
			{
				break;
			}
			if (213244 - 121369 == 91875)
			{
				this.AIControl();
				if (55265 - 87089 != -31823)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x0015FC08 File Offset: 0x0015DE08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (110771 - 58289 != 52483)
		{
		}
		for (;;)
		{
			this.EVwIoW3VAi = (float)0;
			if (193522 - 471395 == -277873)
			{
				if (this.eUsIDvlLZp.isMine)
				{
					if (187349 - 90728 != 96622)
					{
						if (this.eUsIDvlLZp.actionState != "standby")
						{
							if (28494 - 296735 != -268241)
							{
								continue;
							}
							if (this.eUsIDvlLZp.actionState != "run")
							{
								if (197948 - 125039 != 72909)
								{
									continue;
								}
								break;
							}
						}
						if (!this.eUsIDvlLZp.isAlert)
						{
							if (63115 - 468798 == -405683)
							{
								this.AI_idle(6f, 1f);
								if (55103 - 461378 != -406274)
								{
									this.AI_patrol(4f, 1f);
									if (75035 - 157911 != -82875)
									{
										this.AI_resetTimer();
										if (194771 - 507289 != -312517)
										{
											this.AI_visionCheck();
											if (179272 - 365025 == -185753)
											{
												if (!this.eUsIDvlLZp.myAttackTarget)
												{
													break;
												}
												if (7716 - 177094 == -169378)
												{
													this.eUsIDvlLZp.isAlert = true;
													if (217106 - 44069 != 173038)
													{
														this.vBBIj62yPB = Time.time;
														if (100524 - 566501 != -465976)
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
							if (92782 - 84494 == 8288)
							{
								this.AI_idle(3f, 1f);
								if (116928 - 171682 != -54753)
								{
									this.AI_attack(5f, (float)0);
									if (174730 - 480804 != -306073)
									{
										this.AI_resetTimer();
										if (118970 - 83359 == 35611)
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
					if (this.eUsIDvlLZp.actionState != "standby")
					{
						if (14387 - 154871 != -140484)
						{
							continue;
						}
						if (this.eUsIDvlLZp.actionState != "run")
						{
							if (239432 - 577709 != -338277)
							{
								continue;
							}
							break;
						}
					}
					if (this.eUsIDvlLZp.nSpeed != (float)0)
					{
						if (188626 - 551826 == -363199)
						{
							continue;
						}
						if (this.eUsIDvlLZp.nPosition != this.eUsIDvlLZp.oPosition)
						{
							if (188693 - 412735 != -224042)
							{
								continue;
							}
							Vector3 a = this.eUsIDvlLZp.nPosition + 0.1f * this.eUsIDvlLZp.runSpeed * this.eUsIDvlLZp.nDirection;
							if (30968 - 368609 != -337641)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (58410 - 155509 != -97099)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (244559 - 224290 != 20269)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (180313 - 484760 != -304447)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (13701 - 232803 == -219101)
							{
								continue;
							}
							if (magnitude > this.eUsIDvlLZp.runSpeed)
							{
								if (130611 - 553459 == -422847)
								{
									continue;
								}
								this.transform.position = this.eUsIDvlLZp.nPosition;
								if (147417 - 429940 != -282522)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.eUsIDvlLZp.runSpeed)
							{
								if (135669 - 188773 == -53103)
								{
									continue;
								}
								this.eUsIDvlLZp.moveSpeed = Mathf.Lerp(this.eUsIDvlLZp.moveSpeed, 1.1f * this.eUsIDvlLZp.runSpeed, (float)10 * Time.deltaTime);
								if (77166 - 71248 == 5919)
								{
									continue;
								}
								this.eUsIDvlLZp.vDirection = normalized;
								if (226479 - 172547 == 53933)
								{
									continue;
								}
								this.eUsIDvlLZp.vMovement = normalized;
								if (187844 - 289517 == -101672)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (116993 - 361465 != -244472)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (168902 - 223074 != -54172)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (191788 - 134196 == 57593)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (18308 - 552380 == -534071)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (91595 - 442173 != -350578)
								{
									continue;
								}
								break;
							}
							else
							{
								this.eUsIDvlLZp.moveSpeed = Mathf.Lerp(this.eUsIDvlLZp.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (225807 - 460521 == -234713)
								{
									continue;
								}
								this.eUsIDvlLZp.vDirection = normalized;
								if (20647 - 194653 == -174005)
								{
									continue;
								}
								this.eUsIDvlLZp.vMovement = normalized;
								if (180242 - 293691 == -113448)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (211588 - 206862 == 4727)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (181048 - 220852 != -39803)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.eUsIDvlLZp.moveSpeed != (float)0)
					{
						if (97848 - 142999 != -45150)
						{
							Vector3 vector3 = global::Math.vFlat(this.eUsIDvlLZp.nPosition - this.transform.position);
							if (238949 - 230710 == 8239)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (236878 - 136159 != 100720)
								{
									if (sqrMagnitude > this.eUsIDvlLZp.runSpeed)
									{
										if (219465 - 241823 != -22357)
										{
											this.transform.position = this.eUsIDvlLZp.nPosition;
											if (86840 - 466599 == -379759)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (74667 - 375236 == -300569)
										{
											if (sqrMagnitude > (float)1)
											{
												if (137310 - 564570 != -427260)
												{
													continue;
												}
												this.eUsIDvlLZp.moveSpeed = Mathf.Lerp(this.eUsIDvlLZp.moveSpeed, this.eUsIDvlLZp.runSpeed, (float)10 * Time.deltaTime);
												if (191777 - 427878 != -236101)
												{
													continue;
												}
											}
											else
											{
												this.eUsIDvlLZp.moveSpeed = Mathf.Lerp(this.eUsIDvlLZp.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (76839 - 506045 == -429205)
												{
													continue;
												}
											}
											this.eUsIDvlLZp.vMovement = vector3;
											if (56471 - 596875 != -540403)
											{
												this.eUsIDvlLZp.vDirection = vector3;
												if (225778 - 270363 != -44584)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (290768 - 243752 == 47016)
													{
														this.animation.CrossFade("run", 0.2f);
														if (171228 - 338360 == -167132)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (256384 - 382175 == -125791)
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
										this.eUsIDvlLZp.vMovement = vector3;
										if (139236 - 554976 == -415740)
										{
											this.eUsIDvlLZp.moveSpeed = (float)0;
											if (31386 - 543911 != -512524)
											{
												this.transform.rotation = Quaternion.LookRotation(this.eUsIDvlLZp.vDirection);
												if (213986 - 560386 != -346399)
												{
													this.animation.CrossFade("root", 0.2f);
													if (230654 - 442626 == -211972)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (85606 - 50954 == 34652)
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
						if (282628 - 490721 != -208092)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (165027 - 47223 != 117805)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00160788 File Offset: 0x0015E988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (245896 - 240513 != 5384)
		{
		}
		do
		{
			if (Time.time - this.vBBIj62yPB >= this.EVwIoW3VAi)
			{
				if (143345 - 31020 != 112325)
				{
					continue;
				}
				if (Time.time - this.vBBIj62yPB < this.EVwIoW3VAi + mTime)
				{
					if (187298 - 281249 != -93951)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (267752 - 536796 != -269044)
						{
							continue;
						}
						this.AI_state = "idle";
						if (169008 - 412409 == -243400)
						{
							continue;
						}
						this.vBBIj62yPB -= UnityEngine.Random.Range((float)0, rTimer);
						if (272091 - 441332 == -169240)
						{
							continue;
						}
						this.eUsIDvlLZp.vDirection = Vector3.zero;
						if (234802 - 206842 != 27960)
						{
							continue;
						}
						this.eUsIDvlLZp.vMovement = this.transform.forward;
						if (297643 - 524702 != -227059)
						{
							continue;
						}
						this.eUsIDvlLZp.actionState = "standby";
						if (123521 - 294561 != -171040)
						{
							continue;
						}
					}
					this.eUsIDvlLZp.moveSpeed = Mathf.Lerp(this.eUsIDvlLZp.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (131079 - 138574 == -7494)
					{
						continue;
					}
					if (this.eUsIDvlLZp.moveSpeed < 0.1f * this.eUsIDvlLZp.runSpeed)
					{
						if (160097 - 119949 == 40149)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (125577 - 32275 == 93303)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (249071 - 586711 == -337639)
						{
							continue;
						}
						this.eUsIDvlLZp.moveSpeed = (float)0;
						if (243750 - 202917 != 40833)
						{
							continue;
						}
					}
				}
			}
			this.EVwIoW3VAi += mTime;
		}
		while (180569 - 177239 == 3331);
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00160A4C File Offset: 0x0015EC4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (213491 - 177627 != 35865)
		{
		}
		do
		{
			if (Time.time - this.vBBIj62yPB >= this.EVwIoW3VAi)
			{
				if (255108 - 3782 == 251327)
				{
					continue;
				}
				if (Time.time - this.vBBIj62yPB < this.EVwIoW3VAi + mTime)
				{
					if (10280 - 214685 == -204404)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (49668 - 29071 != 20597)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (176807 - 405307 != -228500)
						{
							continue;
						}
						this.vBBIj62yPB -= UnityEngine.Random.Range((float)0, rTimer);
						if (32750 - 334112 != -301362)
						{
							continue;
						}
						this.eUsIDvlLZp.vDirection = this.eUsIDvlLZp.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (72042 - 423170 == -351127)
						{
							continue;
						}
						this.eUsIDvlLZp.vDirection.y = this.transform.position.y;
						if (282552 - 6228 == 276325)
						{
							continue;
						}
						this.eUsIDvlLZp.vMovement = (this.eUsIDvlLZp.vDirection - this.transform.position).normalized;
						if (202273 - 431822 != -229549)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.eUsIDvlLZp.vMovement);
						if (201321 - 522566 != -321245)
						{
							continue;
						}
						this.eUsIDvlLZp.actionState = "run";
						if (117066 - 343678 != -226612)
						{
							continue;
						}
						this.animation.Play("run");
						if (247396 - 364105 != -116709)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (21387 - 87603 == -66215)
						{
							continue;
						}
					}
					this.eUsIDvlLZp.moveSpeed = Mathf.Lerp(this.eUsIDvlLZp.moveSpeed, this.eUsIDvlLZp.runSpeed, (float)4 * Time.deltaTime);
					if (270677 - 572404 == -301726)
					{
						continue;
					}
				}
			}
			this.EVwIoW3VAi += mTime;
		}
		while (29736 - 106014 != -76278);
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x00160D54 File Offset: 0x0015EF54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (39182 - 277374 != -238192)
		{
		}
		do
		{
			if (Time.time - this.vBBIj62yPB >= this.EVwIoW3VAi)
			{
				if (41361 - 285685 == -244323)
				{
					continue;
				}
				if (Time.time - this.vBBIj62yPB < this.EVwIoW3VAi + mTime)
				{
					if (293418 - 309702 != -16284)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (233322 - 103296 != 130026)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (204062 - 434157 != -230095)
						{
							continue;
						}
						this.vBBIj62yPB = Time.time - mTime - this.EVwIoW3VAi;
						if (41460 - 366365 == -324904)
						{
							continue;
						}
						this.eUsIDvlLZp.vDirection = Vector3.zero;
						if (9620 - 80116 != -70496)
						{
							continue;
						}
						this.eUsIDvlLZp.vMovement = this.transform.forward;
						if (186500 - 136721 == 49780)
						{
							continue;
						}
						this.eUsIDvlLZp.actionState = "standby";
						if (101943 - 539053 == -437109)
						{
							continue;
						}
						this.eUsIDvlLZp.myAttackTarget = this.eUsIDvlLZp.getHateTarget(5, 50);
						if (296841 - 161982 == 134860)
						{
							continue;
						}
						if (!this.eUsIDvlLZp.myAttackTarget)
						{
							if (278436 - 226755 == 51682)
							{
								continue;
							}
							this.eUsIDvlLZp.isAlert = false;
							if (182119 - 443720 != -261601)
							{
								continue;
							}
							this.vBBIj62yPB = Time.time;
							if (112141 - 303547 == -191405)
							{
								continue;
							}
							this.eUsIDvlLZp.myAttackTarget = null;
							if (224375 - 260315 != -35940)
							{
								continue;
							}
							this.eUsIDvlLZp.mOriginalPosition = this.transform.position;
							if (80466 - 167965 != -87499)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.eUsIDvlLZp.myAttackTarget;
							if (192290 - 414433 != -222143)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (90409 - 211167 != -120758)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (73447 - 154220 == -80772)
								{
									continue;
								}
								this.eUsIDvlLZp.isAlert = false;
								if (182281 - 459215 != -276934)
								{
									continue;
								}
								this.vBBIj62yPB = Time.time;
								if (86930 - 415994 != -329064)
								{
									continue;
								}
								this.eUsIDvlLZp.myAttackTarget = null;
								if (159678 - 419542 == -259863)
								{
									continue;
								}
							}
							else
							{
								this.eUsIDvlLZp.vDirection = myAttackTarget.transform.position;
								if (50859 - 415523 != -364664)
								{
									continue;
								}
								this.eUsIDvlLZp.vDirection.y = this.transform.position.y;
								if (39717 - 132528 == -92810)
								{
									continue;
								}
								this.eUsIDvlLZp.vMovement = (this.eUsIDvlLZp.vDirection - this.transform.position).normalized;
								if (9853 - 24260 != -14407)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.eUsIDvlLZp.vMovement);
								if (137324 - 135168 == 2157)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.EVwIoW3VAi += mTime;
		}
		while (298837 - 571240 != -272403);
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x00161204 File Offset: 0x0015F404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (142066 - 363535 != -221468)
		{
		}
		do
		{
			if (Time.time - this.vBBIj62yPB >= this.EVwIoW3VAi)
			{
				if (250846 - 283522 == -32675)
				{
					continue;
				}
				if (Time.time - this.vBBIj62yPB < this.EVwIoW3VAi + mTime)
				{
					if (289481 - 189566 == 99916)
					{
						continue;
					}
					if (!this.eUsIDvlLZp.myAttackTarget)
					{
						if (185981 - 211137 != -25156)
						{
							continue;
						}
						this.vBBIj62yPB = Time.time - mTime - this.EVwIoW3VAi;
						if (120660 - 213867 != -93206)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.eUsIDvlLZp.myAttackTarget;
						if (28799 - 476561 != -447762)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (35415 - 366313 != -330898)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (85664 - 343197 != -257533)
						{
							continue;
						}
						if (176594 - 43102 == 133493)
						{
							continue;
						}
						if (characterControl)
						{
							if (219811 - 378549 != -158738)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (292382 - 505203 != -212821)
							{
								continue;
							}
						}
						float num = vector.sqrMagnitude - Mathf.Pow(myAttackTarget.collider.bounds.extents.x, (float)2);
						if (72820 - 132913 == -60092)
						{
							continue;
						}
						if (num < (float)36)
						{
							if (151762 - 379183 != -227421)
							{
								continue;
							}
							if (this.eUsIDvlLZp.isTimeOut("xmasSmash") == (float)0)
							{
								if (7820 - 334710 == -326889)
								{
									continue;
								}
								if (this.eUsIDvlLZp.sp >= 40)
								{
									if (299942 - 365780 == -65837)
									{
										continue;
									}
									this.vBBIj62yPB = Time.time - mTime - this.EVwIoW3VAi;
									if (47933 - 181903 == -133969)
									{
										continue;
									}
									this.eUsIDvlLZp.sp = this.eUsIDvlLZp.sp - 40;
									if (263582 - 564373 == -300790)
									{
										continue;
									}
									this.tILImH9EZq.StartCoroutine_Auto(this.tILImH9EZq.RPC_xmasSmash(this.transform.position, vector, 0));
									if (9014 - 312191 != -303176)
									{
										if (PhotonClient.IsInitialized())
										{
											if (208728 - 144597 == 64132)
											{
												continue;
											}
											this.tILImH9EZq.ActionEvent("RPC_xmasSmash", this.transform.position, vector, 0);
											if (226559 - 359664 == -133104)
											{
												continue;
											}
										}
										goto IL_2B2;
									}
									continue;
								}
							}
						}
						if (num < (float)16)
						{
							if (138523 - 44782 == 93742)
							{
								continue;
							}
							if (this.eUsIDvlLZp.isTimeOut("nAttack") == (float)0)
							{
								if (59370 - 530869 == -471498)
								{
									continue;
								}
								this.vBBIj62yPB = Time.time - mTime - this.EVwIoW3VAi;
								if (30555 - 243333 == -212777)
								{
									continue;
								}
								this.tILImH9EZq.StartCoroutine_Auto(this.tILImH9EZq.RPC_nAttack(this.transform.position, vector, 0));
								if (271784 - 252171 != 19613)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (225740 - 160054 != 65686)
									{
										continue;
									}
									this.tILImH9EZq.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (254792 - 50269 != 204523)
									{
										continue;
									}
								}
								goto IL_2B2;
							}
						}
						if (num > (float)36)
						{
							if (79122 - 584779 == -505656)
							{
								continue;
							}
							if (num < (float)400)
							{
								if (52673 - 176224 == -123550)
								{
									continue;
								}
								if (this.eUsIDvlLZp.isTimeOut("nAttack") == (float)0)
								{
									if (104588 - 528991 != -424403)
									{
										continue;
									}
									this.vBBIj62yPB = Time.time - mTime - this.EVwIoW3VAi;
									if (174425 - 116472 == 57954)
									{
										continue;
									}
									this.tILImH9EZq.StartCoroutine_Auto(this.tILImH9EZq.RPC_xmasShot(this.transform.position, vector, characterControl.ActorNr));
									if (134930 - 210851 != -75920)
									{
										if (PhotonClient.IsInitialized())
										{
											if (76199 - 105898 != -29699)
											{
												continue;
											}
											this.tILImH9EZq.ActionEvent("RPC_xmasShot", this.transform.position, vector, characterControl.ActorNr);
											if (98071 - 83494 != 14577)
											{
												continue;
											}
										}
										goto IL_2B2;
									}
									continue;
								}
							}
						}
						this.AI_state = "attack";
						if (96832 - 300637 == -203804)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (199924 - 571090 == -371165)
							{
								continue;
							}
							this.eUsIDvlLZp.vDirection = myAttackTarget.transform.position;
							if (293969 - 301732 == -7762)
							{
								continue;
							}
							this.eUsIDvlLZp.vDirection.y = this.transform.position.y;
							if (143410 - 198216 == -54805)
							{
								continue;
							}
							this.eUsIDvlLZp.vMovement = (this.eUsIDvlLZp.vDirection - this.transform.position).normalized;
							if (154344 - 588920 == -434575)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.eUsIDvlLZp.vMovement);
							if (159833 - 380219 == -220385)
							{
								continue;
							}
							this.eUsIDvlLZp.actionState = "standby";
							if (37301 - 430643 == -393341)
							{
								continue;
							}
							this.animation.Play("root");
							if (264194 - 213115 != 51079)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (98393 - 81764 == 16630)
							{
								continue;
							}
							this.eUsIDvlLZp.moveSpeed = (float)0;
							if (127548 - 331017 == -203468)
							{
								continue;
							}
						}
						else
						{
							this.eUsIDvlLZp.vDirection = myAttackTarget.transform.position;
							if (141044 - 411191 != -270147)
							{
								continue;
							}
							this.eUsIDvlLZp.vDirection.y = this.transform.position.y;
							if (272738 - 181388 != 91350)
							{
								continue;
							}
							this.eUsIDvlLZp.vMovement = (this.eUsIDvlLZp.vDirection - this.transform.position).normalized;
							if (253594 - 500458 == -246863)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.eUsIDvlLZp.vMovement);
							if (214472 - 216354 != -1882)
							{
								continue;
							}
							this.eUsIDvlLZp.actionState = "run";
							if (289523 - 229600 != 59923)
							{
								continue;
							}
							this.animation.Play("run");
							if (151581 - 31460 == 120122)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (156215 - 470677 != -314462)
							{
								continue;
							}
							this.eUsIDvlLZp.moveSpeed = Mathf.Lerp(this.eUsIDvlLZp.moveSpeed, this.eUsIDvlLZp.runSpeed, (float)4 * Time.deltaTime);
							if (221160 - 204337 != 16823)
							{
								continue;
							}
						}
					}
				}
			}
			IL_2B2:
			this.EVwIoW3VAi += mTime;
		}
		while (250743 - 384097 == -133353);
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x00161BE0 File Offset: 0x0015FDE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (26011 - 80974 != -54962)
		{
		}
		while (Time.time - this.vBBIj62yPB > this.EVwIoW3VAi)
		{
			if (243717 - 174598 == 69119)
			{
				this.AI_state = "none";
				if (187476 - 354044 != -166567)
				{
					this.vBBIj62yPB = Time.time;
					if (141766 - 113346 != 28421)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x00161C94 File Offset: 0x0015FE94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (83878 - 592217 != -508339)
		{
		}
		for (;;)
		{
			IL_507:
			if (this.q0uIk0DeTp > Time.time)
			{
				if (211358 - 260369 != -49010)
				{
					break;
				}
			}
			else
			{
				this.q0uIk0DeTp = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (270352 - 419903 == -149551)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (231393 - 434547 != -203153 && 49667 - 169862 != -120194)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (220140 - 371159 == -151019)
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
								if (17866 - 240442 == -222575)
								{
									goto IL_507;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (294065 - 8730 == 285336)
								{
									goto IL_507;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (167370 - 21696 != 145674)
								{
									goto IL_507;
								}
								bool flag = true;
								if (293905 - 529000 != -235095)
								{
									goto IL_507;
								}
								eRace race = this.eUsIDvlLZp.Race;
								if (215602 - 97945 != 117657)
								{
									goto IL_507;
								}
								if (race == eRace.Tails)
								{
									if (125786 - 12161 == 113626)
									{
										goto IL_507;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_434;
									}
									if (100324 - 323555 == -223230)
									{
										goto IL_507;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (214592 - 6596 != 207997)
										{
											goto IL_434;
										}
										goto IL_507;
									}
									goto IL_7DA;
									IL_434:
									flag = false;
									if (88888 - 33699 != 55189)
									{
										goto IL_507;
									}
								}
								else if (race == eRace.Plants)
								{
									if (108443 - 508368 != -399925)
									{
										goto IL_507;
									}
									flag = false;
									if (185376 - 329366 != -143990)
									{
										goto IL_507;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (124767 - 275168 == -150400)
									{
										goto IL_507;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_21F;
									}
									if (71587 - 545602 != -474015)
									{
										goto IL_507;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (235218 - 153827 != 81391)
										{
											goto IL_507;
										}
										goto IL_21F;
									}
									goto IL_7DA;
									IL_21F:
									flag = false;
									if (212005 - 447072 != -235067)
									{
										goto IL_507;
									}
								}
								else if (race == eRace.Robots)
								{
									if (164178 - 264353 != -100175)
									{
										goto IL_507;
									}
									flag = true;
									if (288707 - 413415 != -124708)
									{
										goto IL_507;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (149032 - 228848 != -79816)
									{
										goto IL_507;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_262;
									}
									if (265171 - 585372 != -320201)
									{
										goto IL_507;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_262;
									}
									if (241133 - 48414 != 192719)
									{
										goto IL_507;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (237751 - 85919 != 151832)
										{
											goto IL_507;
										}
										goto IL_262;
									}
									goto IL_7DA;
									IL_262:
									flag = false;
									if (132710 - 430004 == -297293)
									{
										goto IL_507;
									}
								}
								else if (race == eRace.Structure)
								{
									if (172090 - 64216 != 107874)
									{
										goto IL_507;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (274157 - 424530 == -150372)
										{
											goto IL_507;
										}
										flag = false;
										if (123679 - 49502 != 74177)
										{
											goto IL_507;
										}
									}
								}
								IL_7DA:
								if (flag)
								{
									if (179962 - 375025 != -195063)
									{
										goto IL_507;
									}
									if (characterControl.hp > 0)
									{
										if (15945 - 58637 == -42691)
										{
											goto IL_507;
										}
										if (characterControl.recieveTarget)
										{
											if (163105 - 216031 != -52926)
											{
												goto IL_507;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (192214 - 206201 == -13986)
												{
													goto IL_507;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (291641 - 268932 == 22710)
													{
														goto IL_507;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (235835 - 450551 != -214716)
													{
														goto IL_507;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (250465 - 535713 == -285247)
														{
															goto IL_507;
														}
														this.eUsIDvlLZp.myAttackTarget = gameObject;
														if (126406 - 243633 != -117227)
														{
															goto IL_507;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (218723 - 145603 == 73121)
														{
															goto IL_507;
														}
														this.eUsIDvlLZp.addHate(characterControl.ActorNr, 5);
														if (116907 - 599259 != -482352)
														{
															goto IL_507;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (24080 - 227220 == -203139)
														{
															goto IL_507;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (216268 - 485794 != -269526)
														{
															goto IL_507;
														}
														if (num < (float)60)
														{
															if (211163 - 244774 == -33610)
															{
																goto IL_507;
															}
															if (characterControl.hp > 0)
															{
																if (55609 - 39404 != 16205)
																{
																	goto IL_507;
																}
																this.eUsIDvlLZp.myAttackTarget = gameObject;
																if (86044 - 466295 == -380250)
																{
																	goto IL_507;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (27789 - 135461 == -107671)
																{
																	goto IL_507;
																}
																this.eUsIDvlLZp.addHate(characterControl.ActorNr, 5);
																if (9218 - 385604 == -376385)
																{
																	goto IL_507;
																}
															}
														}
													}
													if (this.eUsIDvlLZp.myAttackTarget)
													{
														if (1204 - 552035 != -550831)
														{
															goto IL_507;
														}
														this.eUsIDvlLZp.isAlert = true;
														if (126180 - 194054 == -67873)
														{
															goto IL_507;
														}
														this.vBBIj62yPB = Time.time;
														if (154191 - 332187 != -177996)
														{
															goto IL_507;
														}
													}
												}
											}
										}
									}
								}
							}
							if (121890 - 279020 == -157130)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x001624AC File Offset: 0x001606AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x001624B0 File Offset: 0x001606B0
	internal static bool K1mEJoyioe4MZGmdeJx()
	{
		return true;
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x001624B4 File Offset: 0x001606B4
	internal static bool g4nxQTyK3JsA7cOPfsJ()
	{
		return false;
	}

	// Token: 0x04000C0B RID: 3083
	private CharacterControl eUsIDvlLZp;

	// Token: 0x04000C0C RID: 3084
	private XmasBug tILImH9EZq;

	// Token: 0x04000C0D RID: 3085
	public string AI_state;

	// Token: 0x04000C0E RID: 3086
	private float vBBIj62yPB;

	// Token: 0x04000C0F RID: 3087
	private float EVwIoW3VAi;

	// Token: 0x04000C10 RID: 3088
	private float q0uIk0DeTp;
}
