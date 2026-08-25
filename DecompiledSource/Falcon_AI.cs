using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C27 RID: 3111
[Serializable]
public class Falcon_AI : MonoBehaviour
{
	// Token: 0x06004590 RID: 17808 RVA: 0x008B61B8 File Offset: 0x008B43B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Falcon_AI()
	{
		if (89063 - 324574 != -235510)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (12280 - 160850 == -148570)
			{
				base..ctor();
				if (149698 - 383186 != -233487)
				{
					this.AI_state = "none";
					if (53444 - 382230 == -328786)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004591 RID: 17809 RVA: 0x008B6254 File Offset: 0x008B4454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.f6shWjMVTb = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.nmChuae4Gb = (Falcon)this.GetComponent(typeof(Falcon));
	}

	// Token: 0x06004592 RID: 17810 RVA: 0x008B628C File Offset: 0x008B448C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (258050 - 193741 != 64309)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (224622 - 456784 == -232161)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (235122 - 66322 != 168800)
				{
					continue;
				}
			}
			if (this.f6shWjMVTb.isControlled)
			{
				break;
			}
			if (287537 - 90487 == 197050)
			{
				this.AIControl();
				if (262721 - 584563 != -321841)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004593 RID: 17811 RVA: 0x008B6358 File Offset: 0x008B4558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (182293 - 549023 != -366729)
		{
		}
		for (;;)
		{
			this.RTehVy0YAq = (float)0;
			if (95357 - 446788 == -351431)
			{
				if (this.f6shWjMVTb.isMine)
				{
					if (95804 - 584130 == -488326)
					{
						if (this.f6shWjMVTb.actionState != "standby")
						{
							if (280764 - 433462 == -152697)
							{
								continue;
							}
							if (this.f6shWjMVTb.actionState != "run")
							{
								if (200476 - 550359 != -349883)
								{
									continue;
								}
								break;
							}
						}
						if (!this.f6shWjMVTb.isAlert)
						{
							if (150874 - 440753 == -289879)
							{
								if (!this.f6shWjMVTb.isSummon)
								{
									goto IL_9D6;
								}
								if (51257 - 193289 != -142032)
								{
									continue;
								}
								if (!(this.f6shWjMVTb.mSummoner != null))
								{
									goto IL_9D6;
								}
								if (132106 - 414931 != -282825)
								{
									continue;
								}
								Vector3 vector = this.f6shWjMVTb.mSummoner.transform.position - this.transform.position;
								if (215372 - 72430 == 142943)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)36)
								{
									if (171280 - 230543 != -59263)
									{
										continue;
									}
									this.AI_follow(this.f6shWjMVTb.mSummoner);
									if (249204 - 9153 == 240052)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (225894 - 96479 != 129415)
									{
										continue;
									}
									this.AI_resetTimer();
									if (103149 - 308282 == -205132)
									{
										continue;
									}
									this.AI_visionCheck();
									if (282622 - 306157 != -23535)
									{
										continue;
									}
								}
								IL_8B0:
								if (!this.f6shWjMVTb.myAttackTarget)
								{
									break;
								}
								if (100512 - 436370 == -335857)
								{
									continue;
								}
								this.f6shWjMVTb.isAlert = true;
								if (255411 - 391888 == -136476)
								{
									continue;
								}
								this.h1EhyPE261 = Time.time;
								if (71186 - 298797 != -227610)
								{
									break;
								}
								continue;
								IL_9D6:
								this.AI_idle(3f, 1f);
								if (204814 - 609 != 204206)
								{
									this.AI_resetTimer();
									if (253096 - 177115 == 75981)
									{
										this.AI_visionCheck();
										if (294738 - 532993 != -238254)
										{
											goto IL_8B0;
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (288816 - 145032 != 143785)
							{
								this.AI_idle(2f, 1f);
								if (50074 - 289117 == -239043)
								{
									this.AI_patrol(2f, 1f);
									if (178478 - 234932 != -56453)
									{
										this.AI_attack(10f, (float)0);
										if (155374 - 272686 == -117312)
										{
											this.AI_resetTimer();
											if (168650 - 388417 == -219767)
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
					if (this.f6shWjMVTb.actionState != "standby")
					{
						if (66687 - 534465 == -467777)
						{
							continue;
						}
						if (this.f6shWjMVTb.actionState != "run")
						{
							if (240165 - 421928 != -181763)
							{
								continue;
							}
							break;
						}
					}
					if (this.f6shWjMVTb.nSpeed != (float)0)
					{
						if (252737 - 367668 == -114930)
						{
							continue;
						}
						if (this.f6shWjMVTb.nPosition != this.f6shWjMVTb.oPosition)
						{
							if (88737 - 468104 == -379366)
							{
								continue;
							}
							Vector3 a = this.f6shWjMVTb.nPosition + 0.1f * this.f6shWjMVTb.runSpeed * this.f6shWjMVTb.nDirection;
							if (224383 - 118131 != 106252)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (190827 - 506104 == -315276)
							{
								continue;
							}
							Vector3 normalized = vector2.normalized;
							if (13017 - 74233 != -61216)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.transform.position);
							if (60086 - 536582 == -476495)
							{
								continue;
							}
							float magnitude = vector3.magnitude;
							if (229281 - 451364 != -222083)
							{
								continue;
							}
							if (magnitude > this.f6shWjMVTb.runSpeed)
							{
								if (153738 - 282659 != -128921)
								{
									continue;
								}
								this.transform.position = this.f6shWjMVTb.nPosition;
								if (100519 - 189399 != -88879)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.f6shWjMVTb.runSpeed)
							{
								if (176825 - 572397 != -395572)
								{
									continue;
								}
								this.f6shWjMVTb.moveSpeed = Mathf.Lerp(this.f6shWjMVTb.moveSpeed, 1.1f * this.f6shWjMVTb.runSpeed, (float)10 * Time.deltaTime);
								if (217161 - 33710 != 183451)
								{
									continue;
								}
								this.f6shWjMVTb.vDirection = normalized;
								if (201564 - 248045 == -46480)
								{
									continue;
								}
								this.f6shWjMVTb.vMovement = normalized;
								if (103718 - 580211 == -476492)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (7563 - 192901 == -185337)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (207322 - 52838 != 154484)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (144505 - 359390 == -214884)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (229555 - 462346 != -232791)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (173703 - 185793 != -12090)
								{
									continue;
								}
								break;
							}
							else
							{
								this.f6shWjMVTb.moveSpeed = Mathf.Lerp(this.f6shWjMVTb.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (121447 - 81157 != 40290)
								{
									continue;
								}
								this.f6shWjMVTb.vDirection = normalized;
								if (218127 - 472304 == -254176)
								{
									continue;
								}
								this.f6shWjMVTb.vMovement = normalized;
								if (188599 - 34692 != 153907)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (265518 - 459145 != -193627)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (295541 - 312730 != -17189)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.f6shWjMVTb.moveSpeed != (float)0)
					{
						if (283954 - 373048 != -89093)
						{
							Vector3 vector4 = global::Math.vFlat(this.f6shWjMVTb.nPosition - this.transform.position);
							if (86048 - 486127 != -400078)
							{
								float sqrMagnitude = vector4.sqrMagnitude;
								if (51065 - 34536 != 16530)
								{
									if (sqrMagnitude > this.f6shWjMVTb.runSpeed)
									{
										if (297764 - 185465 == 112299)
										{
											this.transform.position = this.f6shWjMVTb.nPosition;
											if (131513 - 119183 == 12330)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (27284 - 401467 != -374182)
										{
											if (sqrMagnitude > (float)1)
											{
												if (223035 - 552237 == -329201)
												{
													continue;
												}
												this.f6shWjMVTb.moveSpeed = Mathf.Lerp(this.f6shWjMVTb.moveSpeed, this.f6shWjMVTb.runSpeed, (float)10 * Time.deltaTime);
												if (236695 - 525492 == -288796)
												{
													continue;
												}
											}
											else
											{
												this.f6shWjMVTb.moveSpeed = Mathf.Lerp(this.f6shWjMVTb.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (54430 - 113613 != -59183)
												{
													continue;
												}
											}
											this.f6shWjMVTb.vMovement = vector4;
											if (153050 - 148069 != 4982)
											{
												this.f6shWjMVTb.vDirection = vector4;
												if (226007 - 341079 == -115072)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector4, (float)10 * Time.deltaTime));
													if (213462 - 355578 == -142116)
													{
														this.animation.CrossFade("run", 0.2f);
														if (255736 - 187586 != 68151)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (202932 - 387854 != -184921)
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
										this.f6shWjMVTb.vMovement = vector4;
										if (120758 - 340914 == -220156)
										{
											this.f6shWjMVTb.moveSpeed = (float)0;
											if (133036 - 281187 == -148151)
											{
												this.transform.rotation = Quaternion.LookRotation(this.f6shWjMVTb.vDirection);
												if (24310 - 205106 != -180795)
												{
													this.animation.CrossFade("root", 0.2f);
													if (27784 - 578358 == -550574)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (248548 - 258569 == -10021)
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
						if (279924 - 587364 == -307440)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (107231 - 167259 != -60027)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004594 RID: 17812 RVA: 0x008B703C File Offset: 0x008B523C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (202323 - 316543 != -114219)
		{
		}
		do
		{
			if (Time.time - this.h1EhyPE261 >= this.RTehVy0YAq)
			{
				if (270800 - 285040 == -14239)
				{
					continue;
				}
				if (Time.time - this.h1EhyPE261 < this.RTehVy0YAq + mTime)
				{
					if (295207 - 424415 != -129208)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (141088 - 473503 == -332414)
						{
							continue;
						}
						this.AI_state = "idle";
						if (53188 - 292901 != -239713)
						{
							continue;
						}
						this.h1EhyPE261 -= UnityEngine.Random.Range((float)0, rTimer);
						if (194312 - 340159 != -145847)
						{
							continue;
						}
						this.f6shWjMVTb.vDirection = Vector3.zero;
						if (167882 - 398909 == -231026)
						{
							continue;
						}
						this.f6shWjMVTb.vMovement = this.transform.forward;
						if (218662 - 89879 == 128784)
						{
							continue;
						}
						this.f6shWjMVTb.actionState = "standby";
						if (38987 - 75713 == -36725)
						{
							continue;
						}
					}
					this.f6shWjMVTb.moveSpeed = Mathf.Lerp(this.f6shWjMVTb.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (158111 - 300892 != -142781)
					{
						continue;
					}
					if (this.f6shWjMVTb.moveSpeed < 0.1f * this.f6shWjMVTb.runSpeed)
					{
						if (287584 - 44973 != 242611)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (228551 - 19485 != 209066)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (157919 - 288366 != -130447)
						{
							continue;
						}
						this.f6shWjMVTb.moveSpeed = (float)0;
						if (67650 - 411928 != -344278)
						{
							continue;
						}
					}
				}
			}
			this.RTehVy0YAq += mTime;
		}
		while (223530 - 192793 != 30737);
	}

	// Token: 0x06004595 RID: 17813 RVA: 0x008B7300 File Offset: 0x008B5500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (264312 - 513226 != -248914)
		{
		}
		for (;;)
		{
			this.f6shWjMVTb.vDirection = followObject.transform.position;
			if (100113 - 552376 == -452263)
			{
				this.f6shWjMVTb.vDirection.y = this.transform.position.y;
				if (54488 - 24410 == 30078)
				{
					this.f6shWjMVTb.vMovement = (this.f6shWjMVTb.vDirection - this.transform.position).normalized;
					if (164838 - 212473 == -47635)
					{
						this.transform.rotation = Quaternion.LookRotation(this.f6shWjMVTb.vMovement);
						if (18522 - 486204 != -467681)
						{
							this.f6shWjMVTb.actionState = "run";
							if (272014 - 347295 == -75281)
							{
								this.animation.Play("run");
								if (142242 - 232689 == -90447)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (150911 - 571701 == -420790)
									{
										this.f6shWjMVTb.moveSpeed = Mathf.Lerp(this.f6shWjMVTb.moveSpeed, this.f6shWjMVTb.runSpeed, (float)4 * Time.deltaTime);
										if (104277 - 527574 == -423297)
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

	// Token: 0x06004596 RID: 17814 RVA: 0x008B74E8 File Offset: 0x008B56E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (77679 - 23921 != 53758)
		{
		}
		do
		{
			if (Time.time - this.h1EhyPE261 >= this.RTehVy0YAq)
			{
				if (276197 - 532958 != -256761)
				{
					continue;
				}
				if (Time.time - this.h1EhyPE261 < this.RTehVy0YAq + mTime)
				{
					if (293927 - 340689 == -46761)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (161052 - 596638 == -435585)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (65248 - 480118 != -414870)
						{
							continue;
						}
						this.h1EhyPE261 -= UnityEngine.Random.Range((float)0, rTimer);
						if (188557 - 585155 != -396598)
						{
							continue;
						}
						this.f6shWjMVTb.vDirection = this.f6shWjMVTb.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (78150 - 513364 != -435214)
						{
							continue;
						}
						this.f6shWjMVTb.vDirection.y = this.transform.position.y;
						if (176069 - 198097 == -22027)
						{
							continue;
						}
						this.f6shWjMVTb.vMovement = (this.f6shWjMVTb.vDirection - this.transform.position).normalized;
						if (32349 - 288888 != -256539)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.f6shWjMVTb.vMovement);
						if (29889 - 497901 == -468011)
						{
							continue;
						}
						this.f6shWjMVTb.actionState = "run";
						if (165578 - 370682 != -205104)
						{
							continue;
						}
						this.animation.Play("run");
						if (69100 - 559426 != -490326)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (209144 - 117325 == 91820)
						{
							continue;
						}
					}
					this.f6shWjMVTb.moveSpeed = Mathf.Lerp(this.f6shWjMVTb.moveSpeed, this.f6shWjMVTb.runSpeed, (float)4 * Time.deltaTime);
					if (44114 - 198543 == -154428)
					{
						continue;
					}
				}
			}
			this.RTehVy0YAq += mTime;
		}
		while (42545 - 91605 == -49059);
	}

	// Token: 0x06004597 RID: 17815 RVA: 0x008B77F0 File Offset: 0x008B59F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (275983 - 288974 != -12991)
		{
		}
		do
		{
			if (Time.time - this.h1EhyPE261 >= this.RTehVy0YAq)
			{
				if (188125 - 166342 == 21784)
				{
					continue;
				}
				if (Time.time - this.h1EhyPE261 < this.RTehVy0YAq + mTime)
				{
					if (177882 - 270579 == -92696)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (193704 - 252495 != -58791)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (235217 - 128872 != 106345)
						{
							continue;
						}
						this.h1EhyPE261 = Time.time - mTime - this.RTehVy0YAq;
						if (298085 - 578472 != -280387)
						{
							continue;
						}
						this.f6shWjMVTb.vDirection = Vector3.zero;
						if (255846 - 473715 == -217868)
						{
							continue;
						}
						this.f6shWjMVTb.vMovement = this.transform.forward;
						if (164890 - 456081 != -291191)
						{
							continue;
						}
						this.f6shWjMVTb.actionState = "standby";
						if (161804 - 378568 != -216764)
						{
							continue;
						}
						if (UnityEngine.Random.Range(0, 100) < 40)
						{
							if (245581 - 481885 != -236304)
							{
								continue;
							}
							this.f6shWjMVTb.myAttackTarget = this.f6shWjMVTb.getHateTarget(15, 50);
							if (20686 - 151006 == -130319)
							{
								continue;
							}
						}
						else
						{
							this.f6shWjMVTb.myAttackTarget = this.f6shWjMVTb.getRandomHateTarget(50);
							if (155601 - 406634 == -251032)
							{
								continue;
							}
						}
						if (!this.f6shWjMVTb.myAttackTarget)
						{
							if (284653 - 173450 != 111203)
							{
								continue;
							}
							this.f6shWjMVTb.isAlert = false;
							if (161983 - 158282 == 3702)
							{
								continue;
							}
							this.h1EhyPE261 = Time.time;
							if (97279 - 51861 == 45419)
							{
								continue;
							}
							this.f6shWjMVTb.myAttackTarget = null;
							if (40348 - 246449 == -206100)
							{
								continue;
							}
							this.f6shWjMVTb.mOriginalPosition = this.transform.position;
							if (80902 - 53633 != 27270)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.f6shWjMVTb.myAttackTarget;
							if (6108 - 24205 == -18096)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (241538 - 282561 == -41022)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (276990 - 460560 != -183570)
								{
									continue;
								}
								this.f6shWjMVTb.isAlert = false;
								if (62703 - 125257 != -62554)
								{
									continue;
								}
								this.h1EhyPE261 = Time.time;
								if (185370 - 385563 != -200193)
								{
									continue;
								}
								this.f6shWjMVTb.myAttackTarget = null;
								if (101296 - 446956 == -345659)
								{
									continue;
								}
							}
							else
							{
								this.f6shWjMVTb.vDirection = myAttackTarget.transform.position;
								if (15900 - 522583 == -506682)
								{
									continue;
								}
								this.f6shWjMVTb.vDirection.y = this.transform.position.y;
								if (133694 - 571154 != -437460)
								{
									continue;
								}
								this.f6shWjMVTb.vMovement = (this.f6shWjMVTb.vDirection - this.transform.position).normalized;
								if (101712 - 349856 != -248144)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.f6shWjMVTb.vMovement);
								if (292663 - 572324 != -279661)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.RTehVy0YAq += mTime;
		}
		while (188489 - 420303 == -231813);
	}

	// Token: 0x06004598 RID: 17816 RVA: 0x008B7D00 File Offset: 0x008B5F00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (255562 - 353922 != -98359)
		{
		}
		do
		{
			if (Time.time - this.h1EhyPE261 >= this.RTehVy0YAq)
			{
				if (139014 - 22771 == 116244)
				{
					continue;
				}
				if (Time.time - this.h1EhyPE261 < this.RTehVy0YAq + mTime)
				{
					if (32705 - 254299 != -221594)
					{
						continue;
					}
					if (!this.f6shWjMVTb.myAttackTarget)
					{
						if (77640 - 69521 != 8119)
						{
							continue;
						}
						this.h1EhyPE261 = Time.time - mTime - this.RTehVy0YAq;
						if (113015 - 85347 != 27669)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.f6shWjMVTb.myAttackTarget;
						if (22283 - 577049 == -554765)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (229323 - 482923 != -253600)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (109147 - 66260 != 42887)
						{
							continue;
						}
						int tID = 0;
						if (241711 - 337417 != -95706)
						{
							continue;
						}
						if (characterControl)
						{
							if (148379 - 385670 != -237291)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (99013 - 463987 != -364974)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (45239 - 365823 == -320583)
						{
							continue;
						}
						if (this.f6shWjMVTb.sp > 45)
						{
							if (30587 - 547210 != -516623)
							{
								continue;
							}
							if (num < (float)20)
							{
								if (271634 - 120832 != 150802)
								{
									continue;
								}
								if (this.f6shWjMVTb.isTimeOut("thousandShot") == (float)0)
								{
									if (30453 - 388253 == -357799)
									{
										continue;
									}
									this.h1EhyPE261 = Time.time - mTime - this.RTehVy0YAq;
									if (83620 - 437739 != -354119)
									{
										continue;
									}
									this.nmChuae4Gb.StartCoroutine_Auto(this.nmChuae4Gb.RPC_thousandShot(this.transform.position, vector, tID));
									if (222627 - 81668 != 140960)
									{
										if (PhotonClient.IsInitialized())
										{
											if (268952 - 354653 != -85701)
											{
												continue;
											}
											this.nmChuae4Gb.ActionEvent("RPC_thousandShot", this.transform.position, vector, tID);
											if (166206 - 235737 == -69530)
											{
												continue;
											}
										}
										goto IL_2B7;
									}
									continue;
								}
							}
						}
						if ((float)this.f6shWjMVTb.hp < 0.5f * (float)this.f6shWjMVTb.mhp)
						{
							if (175024 - 439148 == -264123)
							{
								continue;
							}
							if (num < (float)16)
							{
								if (190674 - 531230 == -340555)
								{
									continue;
								}
								if (this.f6shWjMVTb.isTimeOut("bulletRain") == (float)0)
								{
									if (692 - 21016 != -20324)
									{
										continue;
									}
									this.h1EhyPE261 = Time.time - mTime - this.RTehVy0YAq;
									if (117339 - 523073 != -405734)
									{
										continue;
									}
									this.nmChuae4Gb.StartCoroutine_Auto(this.nmChuae4Gb.RPC_bulletRain(this.transform.position, vector, tID));
									if (204188 - 456226 != -252037)
									{
										if (PhotonClient.IsInitialized())
										{
											if (270862 - 386100 == -115237)
											{
												continue;
											}
											this.nmChuae4Gb.ActionEvent("RPC_bulletRain", this.transform.position, vector, tID);
											if (153858 - 268010 == -114151)
											{
												continue;
											}
										}
										goto IL_2B7;
									}
									continue;
								}
							}
						}
						if (num < (float)6)
						{
							if (12628 - 524104 == -511475)
							{
								continue;
							}
							if (this.f6shWjMVTb.isTimeOut("nAttack") == (float)0)
							{
								if (114057 - 222243 == -108185)
								{
									continue;
								}
								this.h1EhyPE261 = Time.time - mTime - this.RTehVy0YAq;
								if (105151 - 360367 == -255215)
								{
									continue;
								}
								this.nmChuae4Gb.StartCoroutine_Auto(this.nmChuae4Gb.RPC_backDraw(this.transform.position, vector, tID));
								if (202670 - 77795 != 124876)
								{
									if (PhotonClient.IsInitialized())
									{
										if (263898 - 520247 != -256349)
										{
											continue;
										}
										this.nmChuae4Gb.ActionEvent("RPC_backDraw", this.transform.position, vector, tID);
										if (25961 - 294459 == -268497)
										{
											continue;
										}
									}
									goto IL_2B7;
								}
								continue;
							}
						}
						if (num < (float)18)
						{
							if (59269 - 74589 == -15319)
							{
								continue;
							}
							if (this.f6shWjMVTb.isTimeOut("nAttack") == (float)0)
							{
								if (228539 - 254019 == -25479)
								{
									continue;
								}
								this.h1EhyPE261 = Time.time - mTime - this.RTehVy0YAq;
								if (150027 - 250552 != -100525)
								{
									continue;
								}
								this.nmChuae4Gb.StartCoroutine_Auto(this.nmChuae4Gb.RPC_pointBlank(this.transform.position, vector, tID));
								if (62019 - 312819 != -250799)
								{
									if (PhotonClient.IsInitialized())
									{
										if (245505 - 318149 != -72644)
										{
											continue;
										}
										this.nmChuae4Gb.ActionEvent("RPC_pointBlank", this.transform.position, vector, tID);
										if (252289 - 594259 != -341970)
										{
											continue;
										}
									}
									goto IL_2B7;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (41410 - 449003 != -407593)
						{
							continue;
						}
						this.f6shWjMVTb.vDirection = myAttackTarget.transform.position;
						if (280613 - 291067 == -10453)
						{
							continue;
						}
						this.f6shWjMVTb.vDirection.y = this.transform.position.y;
						if (60145 - 287809 == -227663)
						{
							continue;
						}
						this.f6shWjMVTb.vMovement = (this.f6shWjMVTb.vDirection - this.transform.position).normalized;
						if (58706 - 360392 != -301686)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.f6shWjMVTb.vMovement);
						if (280632 - 59428 != 221204)
						{
							continue;
						}
						this.f6shWjMVTb.actionState = "run";
						if (267159 - 460411 != -193252)
						{
							continue;
						}
						this.animation.Play("run");
						if (223227 - 344618 == -121390)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (26475 - 180012 != -153537)
						{
							continue;
						}
						this.f6shWjMVTb.moveSpeed = Mathf.Lerp(this.f6shWjMVTb.moveSpeed, this.f6shWjMVTb.runSpeed, (float)4 * Time.deltaTime);
						if (172577 - 131521 != 41056)
						{
							continue;
						}
					}
				}
			}
			IL_2B7:
			this.RTehVy0YAq += mTime;
		}
		while (15387 - 448147 == -432759);
	}

	// Token: 0x06004599 RID: 17817 RVA: 0x008B8618 File Offset: 0x008B6818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (8578 - 409895 != -401317)
		{
		}
		while (Time.time - this.h1EhyPE261 > this.RTehVy0YAq)
		{
			if (223497 - 94887 == 128610)
			{
				this.AI_state = "none";
				if (78095 - 155526 == -77431)
				{
					this.h1EhyPE261 = Time.time;
					if (232880 - 391555 == -158675)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600459A RID: 17818 RVA: 0x008B86CC File Offset: 0x008B68CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (189813 - 532138 != -342324)
		{
		}
		for (;;)
		{
			IL_61:
			if (this.MlFhh3CCsM + (float)1 > Time.time)
			{
				if (62930 - 222107 == -159177)
				{
					break;
				}
			}
			else
			{
				this.MlFhh3CCsM = Time.time;
				if (174238 - 136886 == 37352)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)50, this.gameObject.layer);
					if (33230 - 562702 != -529471)
					{
						if (122575 - 407422 == -284847)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (44511 - 312841 == -268330)
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
									if (22006 - 549064 != -527058)
									{
										goto IL_61;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (37123 - 127061 != -89938)
									{
										goto IL_61;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (181807 - 549487 != -367680)
									{
										goto IL_61;
									}
									bool flag = true;
									if (190952 - 64857 == 126096)
									{
										goto IL_61;
									}
									eRace race = this.f6shWjMVTb.Race;
									if (227774 - 565550 == -337775)
									{
										goto IL_61;
									}
									if (race == eRace.Tails)
									{
										if (168574 - 444055 != -275481)
										{
											goto IL_61;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_30C;
										}
										if (32200 - 208822 == -176621)
										{
											goto IL_61;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_30C;
										}
										if (286731 - 144118 == 142614)
										{
											goto IL_61;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (5964 - 363226 != -357262)
											{
												goto IL_61;
											}
											goto IL_30C;
										}
										goto IL_1F0;
										IL_30C:
										flag = false;
										if (110356 - 531917 == -421560)
										{
											goto IL_61;
										}
									}
									else if (race == eRace.Plants)
									{
										if (126096 - 247007 != -120911)
										{
											goto IL_61;
										}
										flag = false;
										if (66421 - 301994 == -235572)
										{
											goto IL_61;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (51810 - 289215 != -237405)
										{
											goto IL_61;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2F0;
										}
										if (94601 - 478794 == -384192)
										{
											goto IL_61;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (145423 - 531839 != -386416)
											{
												goto IL_61;
											}
											goto IL_2F0;
										}
										goto IL_1F0;
										IL_2F0:
										flag = false;
										if (295782 - 153480 == 142303)
										{
											goto IL_61;
										}
									}
									else if (race == eRace.Robots)
									{
										if (72584 - 577494 != -504910)
										{
											goto IL_61;
										}
										flag = true;
										if (113798 - 522999 == -409200)
										{
											goto IL_61;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (181854 - 89457 == 92398)
										{
											goto IL_61;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_659;
										}
										if (84775 - 393327 != -308552)
										{
											goto IL_61;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_659;
										}
										if (31597 - 560504 != -528907)
										{
											goto IL_61;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (236515 - 241163 != -4648)
											{
												goto IL_61;
											}
											goto IL_659;
										}
										goto IL_1F0;
										IL_659:
										flag = false;
										if (116730 - 127029 != -10299)
										{
											goto IL_61;
										}
									}
									else if (race == eRace.Structure)
									{
										if (68620 - 432014 == -363393)
										{
											goto IL_61;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (173329 - 511682 == -338352)
											{
												goto IL_61;
											}
											flag = false;
											if (115619 - 417732 != -302113)
											{
												goto IL_61;
											}
										}
									}
									IL_1F0:
									if (flag)
									{
										if (289664 - 522187 != -232523)
										{
											goto IL_61;
										}
										if (characterControl.hp > 0)
										{
											if (243359 - 170495 != 72864)
											{
												goto IL_61;
											}
											if (characterControl.recieveTarget)
											{
												if (143752 - 527364 != -383612)
												{
													goto IL_61;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (149718 - 221378 == -71659)
													{
														goto IL_61;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (13223 - 240712 != -227489)
														{
															goto IL_61;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (44457 - 250605 != -206148)
														{
															goto IL_61;
														}
														if (vector.sqrMagnitude < (float)2500)
														{
															if (282518 - 401736 != -119218)
															{
																goto IL_61;
															}
															this.f6shWjMVTb.isAlert = true;
															if (31701 - 155551 != -123850)
															{
																goto IL_61;
															}
															this.h1EhyPE261 = Time.time;
															if (103098 - 90919 != 12179)
															{
																goto IL_61;
															}
															this.f6shWjMVTb.myAttackTarget = gameObject;
															if (127366 - 553108 != -425742)
															{
																goto IL_61;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (193420 - 426427 != -233007)
															{
																goto IL_61;
															}
															this.f6shWjMVTb.addHate(characterControl.ActorNr, 5);
															if (241201 - 8107 != 233094)
															{
																goto IL_61;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (299899 - 393997 == -94097)
															{
																goto IL_61;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (236812 - 287952 == -51139)
															{
																goto IL_61;
															}
															if (num < (float)60)
															{
																if (260132 - 418849 == -158716)
																{
																	goto IL_61;
																}
																if (characterControl.hp > 0)
																{
																	if (7402 - 32182 == -24779)
																	{
																		goto IL_61;
																	}
																	this.f6shWjMVTb.isAlert = true;
																	if (271317 - 247815 == 23503)
																	{
																		goto IL_61;
																	}
																	this.h1EhyPE261 = Time.time;
																	if (274161 - 145947 != 128214)
																	{
																		goto IL_61;
																	}
																	this.f6shWjMVTb.myAttackTarget = gameObject;
																	if (129714 - 67437 != 62277)
																	{
																		goto IL_61;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (65079 - 513844 == -448764)
																	{
																		goto IL_61;
																	}
																	this.f6shWjMVTb.addHate(characterControl.ActorNr, 5);
																	if (155007 - 576115 != -421108)
																	{
																		goto IL_61;
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
								if (3265 - 394375 == -391110)
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

	// Token: 0x0600459B RID: 17819 RVA: 0x008B8F1C File Offset: 0x008B711C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600459C RID: 17820 RVA: 0x008B8F20 File Offset: 0x008B7120
	internal static bool fbBiIJ5KoijWkG3PWyiZ()
	{
		return true;
	}

	// Token: 0x0600459D RID: 17821 RVA: 0x008B8F24 File Offset: 0x008B7124
	internal static bool kBDsy15KEUqsd6WE0umo()
	{
		return false;
	}

	// Token: 0x0400511C RID: 20764
	private CharacterControl f6shWjMVTb;

	// Token: 0x0400511D RID: 20765
	private Falcon nmChuae4Gb;

	// Token: 0x0400511E RID: 20766
	public string AI_state;

	// Token: 0x0400511F RID: 20767
	private float h1EhyPE261;

	// Token: 0x04005120 RID: 20768
	private float RTehVy0YAq;

	// Token: 0x04005121 RID: 20769
	private float MlFhh3CCsM;
}
