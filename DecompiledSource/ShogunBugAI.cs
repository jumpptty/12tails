using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001E3 RID: 483
[Serializable]
public class ShogunBugAI : MonoBehaviour
{
	// Token: 0x06000AD5 RID: 2773 RVA: 0x00115C44 File Offset: 0x00113E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShogunBugAI()
	{
		if (194912 - 595215 != -400302)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (87533 - 278431 != -190897)
			{
				base..ctor();
				if (163924 - 189283 != -25358)
				{
					this.AI_state = "none";
					if (63829 - 418895 != -355065)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x00115CE0 File Offset: 0x00113EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.JgXe690qbm = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.NPhetaWJ69 = (ShogunBug)this.GetComponent(typeof(ShogunBug));
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x00115D18 File Offset: 0x00113F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (220728 - 372584 != -151855)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (90947 - 89178 == 1770)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (156718 - 49637 == 107082)
				{
					continue;
				}
			}
			if (this.JgXe690qbm.isControlled)
			{
				break;
			}
			if (152383 - 510541 != -358157)
			{
				this.AIControl();
				if (44318 - 525779 == -481461)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x00115DE4 File Offset: 0x00113FE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (113843 - 9237 != 104606)
		{
		}
		for (;;)
		{
			this.vpteOqhJck = (float)0;
			if (273845 - 386818 == -112973)
			{
				if (this.JgXe690qbm.isMine)
				{
					if (50019 - 416065 != -366045)
					{
						if (this.JgXe690qbm.actionState != "standby")
						{
							if (115374 - 116730 == -1355)
							{
								continue;
							}
							if (this.JgXe690qbm.actionState != "run")
							{
								if (157520 - 286002 != -128482)
								{
									continue;
								}
								break;
							}
						}
						if (!this.JgXe690qbm.isAlert)
						{
							if (161580 - 210841 != -49260)
							{
								this.AI_idle(3f, 1f);
								if (196046 - 84331 != 111716)
								{
									this.AI_patrol(3f, 1f);
									if (79338 - 442762 == -363424)
									{
										this.AI_resetTimer();
										if (271961 - 128527 != 143435)
										{
											this.AI_visionCheck();
											if (41452 - 218920 == -177468)
											{
												if (!this.JgXe690qbm.myAttackTarget)
												{
													break;
												}
												if (46891 - 565936 == -519045)
												{
													this.JgXe690qbm.isAlert = true;
													if (269448 - 491614 == -222166)
													{
														this.jDIeXZDqxB = Time.time;
														if (88791 - 450065 == -361274)
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
							if (142961 - 55846 != 87116)
							{
								this.AI_idle(2f, 1f);
								if (189863 - 110915 == 78948)
								{
									this.AI_attack(12f, (float)0);
									if (104931 - 515162 == -410231)
									{
										this.AI_resetTimer();
										if (176302 - 365420 != -189117)
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
					if (this.JgXe690qbm.actionState != "standby")
					{
						if (158365 - 370885 == -212519)
						{
							continue;
						}
						if (this.JgXe690qbm.actionState != "run")
						{
							if (289358 - 253535 != 35824)
							{
								break;
							}
							continue;
						}
					}
					if (this.JgXe690qbm.nSpeed != (float)0)
					{
						if (175706 - 132114 == 43593)
						{
							continue;
						}
						if (this.JgXe690qbm.nPosition != this.JgXe690qbm.oPosition)
						{
							if (183217 - 275693 == -92475)
							{
								continue;
							}
							Vector3 a = this.JgXe690qbm.nPosition + 0.1f * this.JgXe690qbm.runSpeed * this.JgXe690qbm.nDirection;
							if (158112 - 510610 != -352498)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (49431 - 481100 != -431669)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (274615 - 418524 != -143909)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (284607 - 412235 == -127627)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (217081 - 375394 != -158313)
							{
								continue;
							}
							if (magnitude > this.JgXe690qbm.runSpeed)
							{
								if (60365 - 290513 == -230147)
								{
									continue;
								}
								this.transform.position = this.JgXe690qbm.nPosition;
								if (104913 - 292418 != -187505)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.JgXe690qbm.runSpeed)
							{
								if (48444 - 166253 != -117809)
								{
									continue;
								}
								this.JgXe690qbm.moveSpeed = Mathf.Lerp(this.JgXe690qbm.moveSpeed, 1.1f * this.JgXe690qbm.runSpeed, (float)10 * Time.deltaTime);
								if (266943 - 293238 == -26294)
								{
									continue;
								}
								this.JgXe690qbm.vDirection = normalized;
								if (30508 - 403788 == -373279)
								{
									continue;
								}
								this.JgXe690qbm.vMovement = normalized;
								if (190130 - 591719 == -401588)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (97630 - 11845 == 85786)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (177282 - 438887 == -261604)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (136168 - 515876 != -379708)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (60286 - 497899 == -437612)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (212860 - 21780 != 191080)
								{
									continue;
								}
								break;
							}
							else
							{
								this.JgXe690qbm.moveSpeed = Mathf.Lerp(this.JgXe690qbm.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (91673 - 514316 != -422643)
								{
									continue;
								}
								this.JgXe690qbm.vDirection = normalized;
								if (299747 - 232905 != 66842)
								{
									continue;
								}
								this.JgXe690qbm.vMovement = normalized;
								if (94605 - 544444 == -449838)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (129226 - 545370 == -416143)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (173737 - 500544 != -326806)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.JgXe690qbm.moveSpeed != (float)0)
					{
						if (109603 - 463474 == -353871)
						{
							Vector3 vector3 = global::Math.vFlat(this.JgXe690qbm.nPosition - this.transform.position);
							if (35310 - 281848 == -246538)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (1813 - 41117 != -39303)
								{
									if (sqrMagnitude > this.JgXe690qbm.runSpeed)
									{
										if (273710 - 319161 != -45450)
										{
											this.transform.position = this.JgXe690qbm.nPosition;
											if (238384 - 387765 == -149381)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (2596 - 355552 != -352955)
										{
											if (sqrMagnitude > (float)1)
											{
												if (190166 - 56672 != 133494)
												{
													continue;
												}
												this.JgXe690qbm.moveSpeed = Mathf.Lerp(this.JgXe690qbm.moveSpeed, this.JgXe690qbm.runSpeed, (float)10 * Time.deltaTime);
												if (91363 - 511488 == -420124)
												{
													continue;
												}
											}
											else
											{
												this.JgXe690qbm.moveSpeed = Mathf.Lerp(this.JgXe690qbm.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (254730 - 79391 != 175339)
												{
													continue;
												}
											}
											this.JgXe690qbm.vMovement = vector3;
											if (13385 - 91470 != -78084)
											{
												this.JgXe690qbm.vDirection = vector3;
												if (261044 - 422199 == -161155)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (112179 - 340451 == -228272)
													{
														this.animation.CrossFade("run", 0.2f);
														if (63240 - 388320 != -325079)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (204932 - 79809 != 125124)
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
										this.JgXe690qbm.vMovement = vector3;
										if (4060 - 403972 == -399912)
										{
											this.JgXe690qbm.moveSpeed = (float)0;
											if (87598 - 566573 == -478975)
											{
												this.transform.rotation = Quaternion.LookRotation(this.JgXe690qbm.vDirection);
												if (70146 - 262918 == -192772)
												{
													this.animation.CrossFade("root", 0.2f);
													if (47169 - 480045 != -432875)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (132611 - 212502 == -79891)
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
						if (283181 - 473640 != -190458)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (96724 - 346848 == -250124)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00116964 File Offset: 0x00114B64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (159924 - 294906 != -134981)
		{
		}
		do
		{
			if (Time.time - this.jDIeXZDqxB >= this.vpteOqhJck)
			{
				if (245110 - 357122 == -112011)
				{
					continue;
				}
				if (Time.time - this.jDIeXZDqxB < this.vpteOqhJck + mTime)
				{
					if (59321 - 402559 == -343237)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (235617 - 29744 != 205873)
						{
							continue;
						}
						this.AI_state = "idle";
						if (227152 - 271752 != -44600)
						{
							continue;
						}
						this.jDIeXZDqxB -= UnityEngine.Random.Range((float)0, rTimer);
						if (251889 - 392084 != -140195)
						{
							continue;
						}
						this.JgXe690qbm.vDirection = Vector3.zero;
						if (264090 - 392481 == -128390)
						{
							continue;
						}
						this.JgXe690qbm.vMovement = this.transform.forward;
						if (21792 - 97831 == -76038)
						{
							continue;
						}
						this.JgXe690qbm.actionState = "standby";
						if (177462 - 154294 == 23169)
						{
							continue;
						}
					}
					this.JgXe690qbm.moveSpeed = Mathf.Lerp(this.JgXe690qbm.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (41499 - 481906 != -440407)
					{
						continue;
					}
					if (this.JgXe690qbm.moveSpeed < 0.1f * this.JgXe690qbm.runSpeed)
					{
						if (32060 - 279561 == -247500)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (252040 - 38100 == 213941)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (63902 - 285195 == -221292)
						{
							continue;
						}
						this.JgXe690qbm.moveSpeed = (float)0;
						if (126715 - 239989 == -113273)
						{
							continue;
						}
					}
				}
			}
			this.vpteOqhJck += mTime;
		}
		while (282116 - 353508 == -71391);
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x00116C28 File Offset: 0x00114E28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (103670 - 305933 != -202262)
		{
		}
		do
		{
			if (Time.time - this.jDIeXZDqxB >= this.vpteOqhJck)
			{
				if (82887 - 391345 == -308457)
				{
					continue;
				}
				if (Time.time - this.jDIeXZDqxB < this.vpteOqhJck + mTime)
				{
					if (252408 - 171130 == 81279)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (258077 - 54150 == 203928)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (204818 - 441187 == -236368)
						{
							continue;
						}
						this.jDIeXZDqxB -= UnityEngine.Random.Range((float)0, rTimer);
						if (95383 - 462948 == -367564)
						{
							continue;
						}
						this.JgXe690qbm.vDirection = this.JgXe690qbm.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (243985 - 389782 != -145797)
						{
							continue;
						}
						this.JgXe690qbm.vDirection.y = this.transform.position.y;
						if (199855 - 527671 == -327815)
						{
							continue;
						}
						this.JgXe690qbm.vMovement = (this.JgXe690qbm.vDirection - this.transform.position).normalized;
						if (96384 - 378305 == -281920)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.JgXe690qbm.vMovement);
						if (109410 - 572483 == -463072)
						{
							continue;
						}
						this.JgXe690qbm.actionState = "run";
						if (227043 - 272689 == -45645)
						{
							continue;
						}
						this.animation.Play("run");
						if (86779 - 299077 != -212298)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (253206 - 590547 != -337341)
						{
							continue;
						}
					}
					this.JgXe690qbm.moveSpeed = Mathf.Lerp(this.JgXe690qbm.moveSpeed, this.JgXe690qbm.runSpeed, (float)4 * Time.deltaTime);
					if (13242 - 218482 == -205239)
					{
						continue;
					}
				}
			}
			this.vpteOqhJck += mTime;
		}
		while (7513 - 250366 == -242852);
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00116F30 File Offset: 0x00115130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (147888 - 158753 != -10865)
		{
		}
		do
		{
			if (Time.time - this.jDIeXZDqxB >= this.vpteOqhJck)
			{
				if (192639 - 181650 != 10989)
				{
					continue;
				}
				if (Time.time - this.jDIeXZDqxB < this.vpteOqhJck + mTime)
				{
					if (25023 - 390560 != -365537)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (171420 - 194108 != -22688)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (115855 - 478042 != -362187)
						{
							continue;
						}
						this.jDIeXZDqxB = Time.time - mTime - this.vpteOqhJck;
						if (281057 - 248812 == 32246)
						{
							continue;
						}
						this.JgXe690qbm.vDirection = Vector3.zero;
						if (292765 - 433016 == -140250)
						{
							continue;
						}
						this.JgXe690qbm.vMovement = this.transform.forward;
						if (54215 - 175210 != -120995)
						{
							continue;
						}
						this.JgXe690qbm.actionState = "standby";
						if (72952 - 31376 != 41576)
						{
							continue;
						}
						this.JgXe690qbm.myAttackTarget = this.JgXe690qbm.getHateTarget(5, 50);
						if (255566 - 527342 == -271775)
						{
							continue;
						}
						if (!this.JgXe690qbm.myAttackTarget)
						{
							if (120188 - 55948 != 64240)
							{
								continue;
							}
							this.JgXe690qbm.isAlert = false;
							if (70882 - 93044 == -22161)
							{
								continue;
							}
							this.jDIeXZDqxB = Time.time;
							if (172465 - 174194 != -1729)
							{
								continue;
							}
							this.JgXe690qbm.myAttackTarget = null;
							if (9741 - 464268 != -454527)
							{
								continue;
							}
							this.JgXe690qbm.mOriginalPosition = this.transform.position;
							if (183323 - 50575 != 132749)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.JgXe690qbm.myAttackTarget;
							if (197429 - 170571 == 26859)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (108798 - 140792 != -31994)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (86637 - 412131 == -325493)
								{
									continue;
								}
								this.JgXe690qbm.isAlert = false;
								if (173253 - 400027 == -226773)
								{
									continue;
								}
								this.jDIeXZDqxB = Time.time;
								if (233082 - 548377 != -315295)
								{
									continue;
								}
								this.JgXe690qbm.myAttackTarget = null;
								if (42882 - 483602 == -440719)
								{
									continue;
								}
							}
							else
							{
								this.JgXe690qbm.vDirection = myAttackTarget.transform.position;
								if (24793 - 332681 != -307888)
								{
									continue;
								}
								this.JgXe690qbm.vDirection.y = this.transform.position.y;
								if (189067 - 575995 != -386928)
								{
									continue;
								}
								this.JgXe690qbm.vMovement = (this.JgXe690qbm.vDirection - this.transform.position).normalized;
								if (236104 - 513539 != -277435)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.JgXe690qbm.vMovement);
								if (67525 - 146347 == -78821)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.vpteOqhJck += mTime;
		}
		while (160280 - 176992 == -16711);
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x001173E0 File Offset: 0x001155E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (44726 - 175669 != -130943)
		{
		}
		do
		{
			if (Time.time - this.jDIeXZDqxB >= this.vpteOqhJck)
			{
				if (58331 - 157793 != -99462)
				{
					continue;
				}
				if (Time.time - this.jDIeXZDqxB < this.vpteOqhJck + mTime)
				{
					if (19579 - 50478 != -30899)
					{
						continue;
					}
					if (!this.JgXe690qbm.myAttackTarget)
					{
						if (182817 - 91455 != 91362)
						{
							continue;
						}
						this.jDIeXZDqxB = Time.time - mTime - this.vpteOqhJck;
						if (57464 - 384684 != -327219)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.JgXe690qbm.myAttackTarget;
						if (38407 - 213887 != -175480)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (288922 - 541997 != -253075)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (243086 - 209184 != 33902)
						{
							continue;
						}
						if (233435 - 264196 != -30761)
						{
							continue;
						}
						if (characterControl)
						{
							if (32518 - 174364 == -141845)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (296174 - 64235 != 231939)
							{
								continue;
							}
						}
						float num = vector.sqrMagnitude - Mathf.Pow(myAttackTarget.collider.bounds.extents.x, (float)2);
						if (220079 - 384973 == -164893)
						{
							continue;
						}
						if (this.JgXe690qbm.isTimeOut("braveSpirit") == (float)0)
						{
							if (90520 - 373632 != -283112)
							{
								continue;
							}
							this.jDIeXZDqxB = Time.time - mTime - this.vpteOqhJck;
							if (59706 - 327488 == -267781)
							{
								continue;
							}
							this.NPhetaWJ69.StartCoroutine_Auto(this.NPhetaWJ69.RPC_braveSpirit(this.transform.position, vector, 0));
							if (94470 - 590481 == -496010)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (187210 - 86327 != 100883)
								{
									continue;
								}
								this.NPhetaWJ69.ActionEvent("RPC_braveSpirit", this.transform.position, vector, 0);
								if (16807 - 355228 == -338420)
								{
									continue;
								}
							}
						}
						else
						{
							if (num < (float)4)
							{
								if (264882 - 187672 == 77211)
								{
									continue;
								}
								if (this.JgXe690qbm.isTimeOut("nAttack") == (float)0)
								{
									if (34244 - 445130 == -410885)
									{
										continue;
									}
									this.jDIeXZDqxB = Time.time - mTime - this.vpteOqhJck;
									if (106701 - 300286 == -193584)
									{
										continue;
									}
									this.NPhetaWJ69.StartCoroutine_Auto(this.NPhetaWJ69.RPC_nAttack(this.transform.position, vector, 0));
									if (277170 - 520027 != -242856)
									{
										if (PhotonClient.IsInitialized())
										{
											if (115920 - 401918 != -285998)
											{
												continue;
											}
											this.NPhetaWJ69.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (30977 - 78680 == -47702)
											{
												continue;
											}
										}
										goto IL_557;
									}
									continue;
								}
							}
							if (num < (float)24)
							{
								if (35756 - 291495 == -255738)
								{
									continue;
								}
								if (this.JgXe690qbm.isTimeOut("shogunSpear") == (float)0)
								{
									if (197841 - 408825 != -210984)
									{
										continue;
									}
									if (this.JgXe690qbm.sp > 30)
									{
										if (172197 - 380768 == -208570)
										{
											continue;
										}
										this.jDIeXZDqxB = Time.time - mTime - this.vpteOqhJck;
										if (266220 - 585196 == -318975)
										{
											continue;
										}
										this.JgXe690qbm.sp = this.JgXe690qbm.sp - 30;
										if (205928 - 94828 != 111100)
										{
											continue;
										}
										this.NPhetaWJ69.StartCoroutine_Auto(this.NPhetaWJ69.RPC_shogunSpear(this.transform.position, vector, 0));
										if (84856 - 94509 != -9653)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (207843 - 419780 != -211937)
											{
												continue;
											}
											this.NPhetaWJ69.ActionEvent("RPC_shogunSpear", this.transform.position, vector, 0);
											if (124761 - 139481 == -14719)
											{
												continue;
											}
										}
										goto IL_557;
									}
								}
							}
							this.AI_state = "attack";
							if (121430 - 449635 == -328204)
							{
								continue;
							}
							if (num < (float)3)
							{
								if (50603 - 438116 != -387513)
								{
									continue;
								}
								this.JgXe690qbm.vDirection = myAttackTarget.transform.position;
								if (136856 - 105207 != 31649)
								{
									continue;
								}
								this.JgXe690qbm.vDirection.y = this.transform.position.y;
								if (220853 - 328341 != -107488)
								{
									continue;
								}
								this.JgXe690qbm.vMovement = (this.JgXe690qbm.vDirection - this.transform.position).normalized;
								if (194545 - 394165 != -199620)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.JgXe690qbm.vMovement);
								if (95475 - 560997 != -465522)
								{
									continue;
								}
								this.JgXe690qbm.actionState = "standby";
								if (107734 - 482529 == -374794)
								{
									continue;
								}
								this.animation.Play("root");
								if (20764 - 143369 != -122605)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (11355 - 509571 != -498216)
								{
									continue;
								}
								this.JgXe690qbm.moveSpeed = (float)0;
								if (143103 - 579173 != -436070)
								{
									continue;
								}
							}
							else
							{
								this.JgXe690qbm.vDirection = myAttackTarget.transform.position;
								if (171634 - 8703 == 162932)
								{
									continue;
								}
								this.JgXe690qbm.vDirection.y = this.transform.position.y;
								if (93547 - 255055 == -161507)
								{
									continue;
								}
								this.JgXe690qbm.vMovement = (this.JgXe690qbm.vDirection - this.transform.position).normalized;
								if (18451 - 516688 != -498237)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.JgXe690qbm.vMovement);
								if (90958 - 424786 == -333827)
								{
									continue;
								}
								this.JgXe690qbm.actionState = "run";
								if (110077 - 526148 != -416071)
								{
									continue;
								}
								this.animation.Play("run");
								if (274607 - 457413 != -182806)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (233364 - 309610 != -76246)
								{
									continue;
								}
								this.JgXe690qbm.moveSpeed = Mathf.Lerp(this.JgXe690qbm.moveSpeed, this.JgXe690qbm.runSpeed, (float)4 * Time.deltaTime);
								if (66762 - 540359 == -473596)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_557:
			this.vpteOqhJck += mTime;
		}
		while (162700 - 276723 != -114023);
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00117D64 File Offset: 0x00115F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (73253 - 223630 != -150377)
		{
		}
		while (Time.time - this.jDIeXZDqxB > this.vpteOqhJck)
		{
			if (254104 - 572627 == -318523)
			{
				this.AI_state = "none";
				if (215013 - 453363 == -238350)
				{
					this.jDIeXZDqxB = Time.time;
					if (174699 - 564830 == -390131)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x00117E18 File Offset: 0x00116018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (205147 - 320175 != -115028)
		{
		}
		for (;;)
		{
			IL_7AA:
			if (this.mYHe26H5XJ > Time.time)
			{
				if (86480 - 374428 == -287948)
				{
					break;
				}
			}
			else
			{
				this.mYHe26H5XJ = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (143745 - 256630 == -112885)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (275171 - 522942 == -247771)
					{
						if (141425 - 45397 != 96029)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (227547 - 478683 != -251135)
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
									if (77456 - 534647 == -457190)
									{
										goto IL_7AA;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (43063 - 383571 != -340508)
									{
										goto IL_7AA;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (79469 - 366495 != -287026)
									{
										goto IL_7AA;
									}
									bool flag = true;
									if (287932 - 125778 == 162155)
									{
										goto IL_7AA;
									}
									eRace race = this.JgXe690qbm.Race;
									if (205157 - 461486 == -256328)
									{
										goto IL_7AA;
									}
									if (race == eRace.Tails)
									{
										if (18950 - 126095 != -107145)
										{
											goto IL_7AA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_745;
										}
										if (296020 - 419281 != -123261)
										{
											goto IL_7AA;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (134424 - 211051 != -76627)
											{
												goto IL_7AA;
											}
											goto IL_745;
										}
										goto IL_6DF;
										IL_745:
										flag = false;
										if (155415 - 213265 != -57850)
										{
											goto IL_7AA;
										}
									}
									else if (race == eRace.Plants)
									{
										if (67366 - 162942 == -95575)
										{
											goto IL_7AA;
										}
										flag = false;
										if (93866 - 324878 != -231012)
										{
											goto IL_7AA;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (226038 - 216626 != 9412)
										{
											goto IL_7AA;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_4B7;
										}
										if (79282 - 348872 == -269589)
										{
											goto IL_7AA;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (140729 - 16428 != 124301)
											{
												goto IL_7AA;
											}
											goto IL_4B7;
										}
										goto IL_6DF;
										IL_4B7:
										flag = false;
										if (30184 - 498985 == -468800)
										{
											goto IL_7AA;
										}
									}
									else if (race == eRace.Robots)
									{
										if (255562 - 480186 != -224624)
										{
											goto IL_7AA;
										}
										flag = true;
										if (230950 - 436868 == -205917)
										{
											goto IL_7AA;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (282167 - 402534 == -120366)
										{
											goto IL_7AA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_1B3;
										}
										if (212440 - 16555 == 195886)
										{
											goto IL_7AA;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_1B3;
										}
										if (42651 - 493843 == -451191)
										{
											goto IL_7AA;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (246907 - 519301 != -272393)
											{
												goto IL_1B3;
											}
											goto IL_7AA;
										}
										goto IL_6DF;
										IL_1B3:
										flag = false;
										if (243162 - 343188 != -100026)
										{
											goto IL_7AA;
										}
									}
									else if (race == eRace.Structure)
									{
										if (11905 - 131669 != -119764)
										{
											goto IL_7AA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (231041 - 320695 != -89654)
											{
												goto IL_7AA;
											}
											flag = false;
											if (219469 - 153767 != 65702)
											{
												goto IL_7AA;
											}
										}
									}
									IL_6DF:
									if (flag)
									{
										if (199263 - 111384 == 87880)
										{
											goto IL_7AA;
										}
										if (characterControl.hp > 0)
										{
											if (194281 - 156783 != 37498)
											{
												goto IL_7AA;
											}
											if (characterControl.recieveTarget)
											{
												if (228527 - 105429 == 123099)
												{
													goto IL_7AA;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (68283 - 549471 == -481187)
													{
														goto IL_7AA;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (257308 - 465082 == -207773)
														{
															goto IL_7AA;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (86656 - 69568 != 17088)
														{
															goto IL_7AA;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (134714 - 396202 != -261488)
															{
																goto IL_7AA;
															}
															this.JgXe690qbm.myAttackTarget = gameObject;
															if (74544 - 552239 != -477695)
															{
																goto IL_7AA;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (206663 - 254204 == -47540)
															{
																goto IL_7AA;
															}
															this.JgXe690qbm.addHate(characterControl.ActorNr, 5);
															if (76363 - 76816 == -452)
															{
																goto IL_7AA;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (42955 - 102320 != -59365)
															{
																goto IL_7AA;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (237189 - 491874 == -254684)
															{
																goto IL_7AA;
															}
															if (num < (float)60)
															{
																if (18366 - 571556 != -553190)
																{
																	goto IL_7AA;
																}
																if (characterControl.hp > 0)
																{
																	if (265357 - 333398 != -68041)
																	{
																		goto IL_7AA;
																	}
																	this.JgXe690qbm.myAttackTarget = gameObject;
																	if (209087 - 489443 != -280356)
																	{
																		goto IL_7AA;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (254627 - 122777 != 131850)
																	{
																		goto IL_7AA;
																	}
																	this.JgXe690qbm.addHate(characterControl.ActorNr, 5);
																	if (166421 - 54015 == 112407)
																	{
																		goto IL_7AA;
																	}
																}
															}
														}
														if (this.JgXe690qbm.myAttackTarget)
														{
															if (254164 - 178133 == 76032)
															{
																goto IL_7AA;
															}
															this.JgXe690qbm.isAlert = true;
															if (165759 - 156426 == 9334)
															{
																goto IL_7AA;
															}
															this.jDIeXZDqxB = Time.time;
															if (7907 - 74062 == -66154)
															{
																goto IL_7AA;
															}
														}
													}
												}
											}
										}
									}
								}
								if (267778 - 59112 == 208666)
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

	// Token: 0x06000ADF RID: 2783 RVA: 0x00118630 File Offset: 0x00116830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x00118634 File Offset: 0x00116834
	internal static bool EfYC77Hnbu0LQ7XKjMe()
	{
		return true;
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00118638 File Offset: 0x00116838
	internal static bool ayrmaYH6B1KdLp1KTrj()
	{
		return false;
	}

	// Token: 0x040009A9 RID: 2473
	private CharacterControl JgXe690qbm;

	// Token: 0x040009AA RID: 2474
	private ShogunBug NPhetaWJ69;

	// Token: 0x040009AB RID: 2475
	public string AI_state;

	// Token: 0x040009AC RID: 2476
	private float jDIeXZDqxB;

	// Token: 0x040009AD RID: 2477
	private float vpteOqhJck;

	// Token: 0x040009AE RID: 2478
	private float mYHe26H5XJ;
}
