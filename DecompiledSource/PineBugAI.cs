using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000187 RID: 391
[Serializable]
public class PineBugAI : MonoBehaviour
{
	// Token: 0x060008C6 RID: 2246 RVA: 0x000E3450 File Offset: 0x000E1650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PineBugAI()
	{
		if (249509 - 196557 != 52952)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (45119 - 384317 == -339198)
			{
				base..ctor();
				if (277423 - 483474 != -206050)
				{
					this.AI_state = "none";
					if (273012 - 534889 == -261877)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x000E34EC File Offset: 0x000E16EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.snVQGB4bxa = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.xyqQ1hUiA7 = (PineBug)this.GetComponent(typeof(PineBug));
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x000E3524 File Offset: 0x000E1724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (259712 - 429564 != -169851)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (154941 - 377036 == -222094)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (31268 - 88978 == -57709)
				{
					continue;
				}
			}
			if (this.snVQGB4bxa.isControlled)
			{
				break;
			}
			if (146298 - 37831 != 108468)
			{
				this.AIControl();
				if (119248 - 383624 == -264376)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x000E35F0 File Offset: 0x000E17F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (199107 - 429342 != -230234)
		{
		}
		for (;;)
		{
			this.TEIQpBBjhN = (float)0;
			if (94043 - 460351 != -366307)
			{
				if (this.snVQGB4bxa.isMine)
				{
					if (131977 - 78945 != 53033)
					{
						if (this.snVQGB4bxa.actionState != "standby")
						{
							if (138976 - 565719 != -426743)
							{
								continue;
							}
							if (this.snVQGB4bxa.actionState != "run")
							{
								if (149545 - 429702 != -280157)
								{
									continue;
								}
								break;
							}
						}
						if (!this.snVQGB4bxa.isAlert)
						{
							if (63539 - 405890 == -342351)
							{
								this.AI_idle(6f, 1f);
								if (117956 - 354864 == -236908)
								{
									this.AI_patrol(4f, 1f);
									if (128421 - 128804 != -382)
									{
										this.AI_resetTimer();
										if (126153 - 428282 == -302129)
										{
											this.AI_visionCheck();
											if (29257 - 166352 != -137094)
											{
												if (!this.snVQGB4bxa.myAttackTarget)
												{
													break;
												}
												if (187758 - 10393 != 177366)
												{
													this.snVQGB4bxa.isAlert = true;
													if (169173 - 575623 == -406450)
													{
														this.dlLQq3WJZb = Time.time;
														if (210167 - 467122 == -256955)
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
							if (23704 - 58561 == -34857)
							{
								this.AI_idle(3f, 1f);
								if (160345 - 184704 == -24359)
								{
									this.AI_attack(5f, (float)0);
									if (190613 - 422381 == -231768)
									{
										this.AI_resetTimer();
										if (236567 - 101595 == 134972)
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
					if (this.snVQGB4bxa.actionState != "standby")
					{
						if (228460 - 568053 == -339592)
						{
							continue;
						}
						if (this.snVQGB4bxa.actionState != "run")
						{
							if (195943 - 586416 != -390472)
							{
								break;
							}
							continue;
						}
					}
					if (this.snVQGB4bxa.nSpeed != (float)0)
					{
						if (200386 - 394636 != -194250)
						{
							continue;
						}
						if (this.snVQGB4bxa.nPosition != this.snVQGB4bxa.oPosition)
						{
							if (45648 - 271875 != -226227)
							{
								continue;
							}
							Vector3 a = this.snVQGB4bxa.nPosition + 0.1f * this.snVQGB4bxa.runSpeed * this.snVQGB4bxa.nDirection;
							if (44381 - 382188 != -337807)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (211468 - 246043 != -34575)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (86694 - 229991 == -143296)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (32298 - 318656 != -286358)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (189898 - 461756 != -271858)
							{
								continue;
							}
							if (magnitude > this.snVQGB4bxa.runSpeed)
							{
								if (106611 - 392344 != -285733)
								{
									continue;
								}
								this.transform.position = this.snVQGB4bxa.nPosition;
								if (231565 - 195402 != 36164)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.snVQGB4bxa.runSpeed)
							{
								if (291006 - 558670 != -267664)
								{
									continue;
								}
								this.snVQGB4bxa.moveSpeed = Mathf.Lerp(this.snVQGB4bxa.moveSpeed, 1.1f * this.snVQGB4bxa.runSpeed, (float)10 * Time.deltaTime);
								if (155044 - 540294 == -385249)
								{
									continue;
								}
								this.snVQGB4bxa.vDirection = normalized;
								if (15123 - 584641 != -569518)
								{
									continue;
								}
								this.snVQGB4bxa.vMovement = normalized;
								if (121660 - 202376 == -80715)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (65287 - 508365 == -443077)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (286610 - 271797 == 14814)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (14619 - 228701 != -214082)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (56857 - 564470 != -507613)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (299112 - 552355 != -253242)
								{
									break;
								}
								continue;
							}
							else
							{
								this.snVQGB4bxa.moveSpeed = Mathf.Lerp(this.snVQGB4bxa.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (127546 - 233545 != -105999)
								{
									continue;
								}
								this.snVQGB4bxa.vDirection = normalized;
								if (254086 - 8531 != 245555)
								{
									continue;
								}
								this.snVQGB4bxa.vMovement = normalized;
								if (195927 - 563384 == -367456)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (49286 - 25277 != 24009)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (16986 - 196708 != -179722)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.snVQGB4bxa.moveSpeed != (float)0)
					{
						if (262653 - 62011 != 200643)
						{
							Vector3 vector3 = global::Math.vFlat(this.snVQGB4bxa.nPosition - this.transform.position);
							if (43917 - 472520 != -428602)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (129493 - 310283 != -180789)
								{
									if (sqrMagnitude > this.snVQGB4bxa.runSpeed)
									{
										if (69558 - 197854 == -128296)
										{
											this.transform.position = this.snVQGB4bxa.nPosition;
											if (134474 - 343338 == -208864)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (220569 - 482528 == -261959)
										{
											if (sqrMagnitude > (float)1)
											{
												if (54523 - 195590 != -141067)
												{
													continue;
												}
												this.snVQGB4bxa.moveSpeed = Mathf.Lerp(this.snVQGB4bxa.moveSpeed, this.snVQGB4bxa.runSpeed, (float)10 * Time.deltaTime);
												if (208882 - 398848 != -189966)
												{
													continue;
												}
											}
											else
											{
												this.snVQGB4bxa.moveSpeed = Mathf.Lerp(this.snVQGB4bxa.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (12531 - 150975 == -138443)
												{
													continue;
												}
											}
											this.snVQGB4bxa.vMovement = vector3;
											if (231181 - 163209 == 67972)
											{
												this.snVQGB4bxa.vDirection = vector3;
												if (299001 - 22648 != 276354)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (59353 - 532534 != -473180)
													{
														this.animation.CrossFade("run", 0.2f);
														if (40452 - 75227 == -34775)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (213177 - 416817 != -203639)
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
										this.snVQGB4bxa.vMovement = vector3;
										if (197350 - 201895 != -4544)
										{
											this.snVQGB4bxa.moveSpeed = (float)0;
											if (241091 - 215137 != 25955)
											{
												this.transform.rotation = Quaternion.LookRotation(this.snVQGB4bxa.vDirection);
												if (151912 - 352953 != -201040)
												{
													this.animation.CrossFade("root", 0.2f);
													if (150940 - 36590 == 114350)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (29518 - 573222 != -543703)
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
						if (82931 - 519278 != -436346)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (257480 - 432247 == -174767)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x000E4170 File Offset: 0x000E2370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (105768 - 321622 != -215853)
		{
		}
		do
		{
			if (Time.time - this.dlLQq3WJZb >= this.TEIQpBBjhN)
			{
				if (149265 - 107907 == 41359)
				{
					continue;
				}
				if (Time.time - this.dlLQq3WJZb < this.TEIQpBBjhN + mTime)
				{
					if (84048 - 462690 == -378641)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (139275 - 572018 != -432743)
						{
							continue;
						}
						this.AI_state = "idle";
						if (193527 - 61550 == 131978)
						{
							continue;
						}
						this.dlLQq3WJZb -= UnityEngine.Random.Range((float)0, rTimer);
						if (38670 - 382533 != -343863)
						{
							continue;
						}
						this.snVQGB4bxa.vDirection = Vector3.zero;
						if (209080 - 261695 != -52615)
						{
							continue;
						}
						this.snVQGB4bxa.vMovement = this.transform.forward;
						if (63461 - 505796 == -442334)
						{
							continue;
						}
						this.snVQGB4bxa.actionState = "standby";
						if (55938 - 81824 != -25886)
						{
							continue;
						}
					}
					this.snVQGB4bxa.moveSpeed = Mathf.Lerp(this.snVQGB4bxa.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (120562 - 395718 != -275156)
					{
						continue;
					}
					if (this.snVQGB4bxa.moveSpeed < 0.1f * this.snVQGB4bxa.runSpeed)
					{
						if (124 - 256759 != -256635)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (279500 - 127970 == 151531)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (218143 - 211833 == 6311)
						{
							continue;
						}
						this.snVQGB4bxa.moveSpeed = (float)0;
						if (274177 - 230534 != 43643)
						{
							continue;
						}
					}
				}
			}
			this.TEIQpBBjhN += mTime;
		}
		while (67798 - 243098 == -175299);
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x000E4434 File Offset: 0x000E2634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (59512 - 353754 != -294241)
		{
		}
		do
		{
			if (Time.time - this.dlLQq3WJZb >= this.TEIQpBBjhN)
			{
				if (241950 - 438229 == -196278)
				{
					continue;
				}
				if (Time.time - this.dlLQq3WJZb < this.TEIQpBBjhN + mTime)
				{
					if (146016 - 13763 == 132254)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (131708 - 455549 == -323840)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (170950 - 458910 == -287959)
						{
							continue;
						}
						this.dlLQq3WJZb -= UnityEngine.Random.Range((float)0, rTimer);
						if (209967 - 90116 != 119851)
						{
							continue;
						}
						this.snVQGB4bxa.vDirection = this.snVQGB4bxa.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (248388 - 33 != 248355)
						{
							continue;
						}
						this.snVQGB4bxa.vDirection.y = this.transform.position.y;
						if (118527 - 69118 != 49409)
						{
							continue;
						}
						this.snVQGB4bxa.vMovement = (this.snVQGB4bxa.vDirection - this.transform.position).normalized;
						if (219116 - 588001 == -368884)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.snVQGB4bxa.vMovement);
						if (28228 - 274172 == -245943)
						{
							continue;
						}
						this.snVQGB4bxa.actionState = "run";
						if (172211 - 147241 != 24970)
						{
							continue;
						}
						this.animation.Play("run");
						if (83549 - 272812 != -189263)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (252241 - 480238 != -227997)
						{
							continue;
						}
					}
					this.snVQGB4bxa.moveSpeed = Mathf.Lerp(this.snVQGB4bxa.moveSpeed, this.snVQGB4bxa.runSpeed, (float)4 * Time.deltaTime);
					if (123 - 79662 != -79539)
					{
						continue;
					}
				}
			}
			this.TEIQpBBjhN += mTime;
		}
		while (292838 - 111659 != 181179);
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x000E473C File Offset: 0x000E293C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (125225 - 479790 != -354565)
		{
		}
		do
		{
			if (Time.time - this.dlLQq3WJZb >= this.TEIQpBBjhN)
			{
				if (157396 - 117317 != 40079)
				{
					continue;
				}
				if (Time.time - this.dlLQq3WJZb < this.TEIQpBBjhN + mTime)
				{
					if (249386 - 104318 == 145069)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (58115 - 374779 == -316663)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (51978 - 376038 != -324060)
						{
							continue;
						}
						this.dlLQq3WJZb = Time.time - mTime - this.TEIQpBBjhN;
						if (263754 - 63607 == 200148)
						{
							continue;
						}
						this.snVQGB4bxa.vDirection = Vector3.zero;
						if (267042 - 328155 == -61112)
						{
							continue;
						}
						this.snVQGB4bxa.vMovement = this.transform.forward;
						if (167827 - 261256 != -93429)
						{
							continue;
						}
						this.snVQGB4bxa.actionState = "standby";
						if (25686 - 96844 != -71158)
						{
							continue;
						}
						this.snVQGB4bxa.myAttackTarget = this.snVQGB4bxa.getHateTarget(5, 50);
						if (294795 - 424382 != -129587)
						{
							continue;
						}
						if (!this.snVQGB4bxa.myAttackTarget)
						{
							if (173688 - 59999 == 113690)
							{
								continue;
							}
							this.snVQGB4bxa.isAlert = false;
							if (135692 - 190988 == -55295)
							{
								continue;
							}
							this.dlLQq3WJZb = Time.time;
							if (54107 - 20775 != 33332)
							{
								continue;
							}
							this.snVQGB4bxa.myAttackTarget = null;
							if (222934 - 483903 != -260969)
							{
								continue;
							}
							this.snVQGB4bxa.mOriginalPosition = this.transform.position;
							if (80033 - 67053 != 12981)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.snVQGB4bxa.myAttackTarget;
							if (141914 - 228025 == -86110)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (89173 - 582932 != -493759)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (136718 - 587486 != -450768)
								{
									continue;
								}
								this.snVQGB4bxa.isAlert = false;
								if (140685 - 210385 != -69700)
								{
									continue;
								}
								this.dlLQq3WJZb = Time.time;
								if (205950 - 449712 != -243762)
								{
									continue;
								}
								this.snVQGB4bxa.myAttackTarget = null;
								if (216845 - 531892 != -315047)
								{
									continue;
								}
							}
							else
							{
								this.snVQGB4bxa.vDirection = myAttackTarget.transform.position;
								if (290859 - 49945 == 240915)
								{
									continue;
								}
								this.snVQGB4bxa.vDirection.y = this.transform.position.y;
								if (63405 - 197643 == -134237)
								{
									continue;
								}
								this.snVQGB4bxa.vMovement = (this.snVQGB4bxa.vDirection - this.transform.position).normalized;
								if (86816 - 387730 == -300913)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.snVQGB4bxa.vMovement);
								if (136544 - 347610 == -211065)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.TEIQpBBjhN += mTime;
		}
		while (53300 - 292008 == -238707);
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x000E4BEC File Offset: 0x000E2DEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (286802 - 197994 != 88808)
		{
		}
		do
		{
			if (Time.time - this.dlLQq3WJZb >= this.TEIQpBBjhN)
			{
				if (168345 - 366410 == -198064)
				{
					continue;
				}
				if (Time.time - this.dlLQq3WJZb < this.TEIQpBBjhN + mTime)
				{
					if (195314 - 47231 == 148084)
					{
						continue;
					}
					if (!this.snVQGB4bxa.myAttackTarget)
					{
						if (174525 - 252528 == -78002)
						{
							continue;
						}
						this.dlLQq3WJZb = Time.time - mTime - this.TEIQpBBjhN;
						if (94842 - 394019 != -299176)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.snVQGB4bxa.myAttackTarget;
						if (261099 - 589806 == -328706)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (196675 - 20316 != 176359)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (200183 - 409395 != -209212)
						{
							continue;
						}
						if (15774 - 121534 != -105760)
						{
							continue;
						}
						if (characterControl)
						{
							if (125240 - 502742 != -377502)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (252331 - 162423 == 89909)
							{
								continue;
							}
						}
						float num = vector.sqrMagnitude - Mathf.Pow(myAttackTarget.collider.bounds.extents.x, (float)2);
						if (90732 - 36493 != 54239)
						{
							continue;
						}
						if (num < (float)36)
						{
							if (218388 - 344215 == -125826)
							{
								continue;
							}
							if (this.snVQGB4bxa.isTimeOut("pineSmash") == (float)0)
							{
								if (264797 - 313145 == -48347)
								{
									continue;
								}
								if (this.snVQGB4bxa.sp >= 40)
								{
									if (140490 - 132292 != 8198)
									{
										continue;
									}
									this.dlLQq3WJZb = Time.time - mTime - this.TEIQpBBjhN;
									if (199080 - 474621 == -275540)
									{
										continue;
									}
									this.snVQGB4bxa.sp = this.snVQGB4bxa.sp - 40;
									if (258948 - 290146 == -31197)
									{
										continue;
									}
									this.xyqQ1hUiA7.StartCoroutine_Auto(this.xyqQ1hUiA7.RPC_pineSmash(this.transform.position, vector, 0));
									if (130415 - 267528 != -137113)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (219572 - 360456 == -140883)
										{
											continue;
										}
										this.xyqQ1hUiA7.ActionEvent("RPC_pineSmash", this.transform.position, vector, 0);
										if (262212 - 355393 != -93181)
										{
											continue;
										}
									}
									goto IL_142;
								}
							}
						}
						if (num < (float)16)
						{
							if (156878 - 195375 == -38496)
							{
								continue;
							}
							if (this.snVQGB4bxa.isTimeOut("nAttack") == (float)0)
							{
								if (209392 - 455450 != -246058)
								{
									continue;
								}
								this.dlLQq3WJZb = Time.time - mTime - this.TEIQpBBjhN;
								if (94947 - 339904 == -244956)
								{
									continue;
								}
								this.xyqQ1hUiA7.StartCoroutine_Auto(this.xyqQ1hUiA7.RPC_nAttack(this.transform.position, vector, 0));
								if (143029 - 15245 != 127784)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (3543 - 46801 != -43258)
									{
										continue;
									}
									this.xyqQ1hUiA7.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (107046 - 246855 == -139808)
									{
										continue;
									}
								}
								goto IL_142;
							}
						}
						if (num > (float)36)
						{
							if (114549 - 597669 != -483120)
							{
								continue;
							}
							if (num < (float)400)
							{
								if (80852 - 506311 == -425458)
								{
									continue;
								}
								if (this.snVQGB4bxa.isTimeOut("nAttack") == (float)0)
								{
									if (208225 - 15732 == 192494)
									{
										continue;
									}
									this.dlLQq3WJZb = Time.time - mTime - this.TEIQpBBjhN;
									if (58943 - 598876 != -539933)
									{
										continue;
									}
									this.xyqQ1hUiA7.StartCoroutine_Auto(this.xyqQ1hUiA7.RPC_pineShot(this.transform.position, vector, characterControl.ActorNr));
									if (20995 - 153908 != -132912)
									{
										if (PhotonClient.IsInitialized())
										{
											if (40792 - 241868 != -201076)
											{
												continue;
											}
											this.xyqQ1hUiA7.ActionEvent("RPC_pineShot", this.transform.position, vector, characterControl.ActorNr);
											if (32539 - 151397 == -118857)
											{
												continue;
											}
										}
										goto IL_142;
									}
									continue;
								}
							}
						}
						this.AI_state = "attack";
						if (111770 - 242791 != -131021)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (106363 - 1419 != 104944)
							{
								continue;
							}
							this.snVQGB4bxa.vDirection = myAttackTarget.transform.position;
							if (101123 - 51717 != 49406)
							{
								continue;
							}
							this.snVQGB4bxa.vDirection.y = this.transform.position.y;
							if (196785 - 393232 != -196447)
							{
								continue;
							}
							this.snVQGB4bxa.vMovement = (this.snVQGB4bxa.vDirection - this.transform.position).normalized;
							if (209697 - 280369 == -70671)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.snVQGB4bxa.vMovement);
							if (103275 - 232429 != -129154)
							{
								continue;
							}
							this.snVQGB4bxa.actionState = "standby";
							if (280643 - 415693 != -135050)
							{
								continue;
							}
							this.animation.Play("root");
							if (223165 - 326568 != -103403)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (18406 - 472307 != -453901)
							{
								continue;
							}
							this.snVQGB4bxa.moveSpeed = (float)0;
							if (270616 - 185336 != 85280)
							{
								continue;
							}
						}
						else
						{
							this.snVQGB4bxa.vDirection = myAttackTarget.transform.position;
							if (242178 - 153077 != 89101)
							{
								continue;
							}
							this.snVQGB4bxa.vDirection.y = this.transform.position.y;
							if (204425 - 84683 != 119742)
							{
								continue;
							}
							this.snVQGB4bxa.vMovement = (this.snVQGB4bxa.vDirection - this.transform.position).normalized;
							if (222537 - 357237 != -134700)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.snVQGB4bxa.vMovement);
							if (99737 - 508985 != -409248)
							{
								continue;
							}
							this.snVQGB4bxa.actionState = "run";
							if (111168 - 549083 == -437914)
							{
								continue;
							}
							this.animation.Play("run");
							if (171413 - 88198 == 83216)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (155888 - 132650 != 23238)
							{
								continue;
							}
							this.snVQGB4bxa.moveSpeed = Mathf.Lerp(this.snVQGB4bxa.moveSpeed, this.snVQGB4bxa.runSpeed, (float)4 * Time.deltaTime);
							if (185218 - 96057 == 89162)
							{
								continue;
							}
						}
					}
				}
			}
			IL_142:
			this.TEIQpBBjhN += mTime;
		}
		while (30680 - 544715 != -514035);
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x000E55C8 File Offset: 0x000E37C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (118655 - 322364 != -203709)
		{
		}
		while (Time.time - this.dlLQq3WJZb > this.TEIQpBBjhN)
		{
			if (190785 - 457331 == -266546)
			{
				this.AI_state = "none";
				if (227305 - 35933 != 191373)
				{
					this.dlLQq3WJZb = Time.time;
					if (183863 - 525367 == -341504)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x000E567C File Offset: 0x000E387C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (16387 - 48504 != -32117)
		{
		}
		for (;;)
		{
			IL_422:
			if (this.BvCQRBYkdE > Time.time)
			{
				if (147109 - 408588 != -261478)
				{
					break;
				}
			}
			else
			{
				this.BvCQRBYkdE = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (39640 - 72313 != -32672)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (62248 - 322170 != -259921 && 148692 - 433551 != -284858)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (268917 - 322389 == -53472)
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
								if (112942 - 197403 != -84461)
								{
									goto IL_422;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (71308 - 209333 != -138025)
								{
									goto IL_422;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (46468 - 501845 != -455377)
								{
									goto IL_422;
								}
								bool flag = true;
								if (158440 - 364891 == -206450)
								{
									goto IL_422;
								}
								eRace race = this.snVQGB4bxa.Race;
								if (97635 - 174223 != -76588)
								{
									goto IL_422;
								}
								if (race == eRace.Tails)
								{
									if (121683 - 420095 != -298412)
									{
										goto IL_422;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_211;
									}
									if (20498 - 467268 == -446769)
									{
										goto IL_422;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (148355 - 301456 != -153101)
										{
											goto IL_422;
										}
										goto IL_211;
									}
									goto IL_7B4;
									IL_211:
									flag = false;
									if (68679 - 307495 != -238816)
									{
										goto IL_422;
									}
								}
								else if (race == eRace.Plants)
								{
									if (2758 - 530422 != -527664)
									{
										goto IL_422;
									}
									flag = false;
									if (145374 - 400534 != -255160)
									{
										goto IL_422;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (281286 - 525639 != -244353)
									{
										goto IL_422;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_793;
									}
									if (65914 - 580581 == -514666)
									{
										goto IL_422;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (173021 - 195439 != -22417)
										{
											goto IL_793;
										}
										goto IL_422;
									}
									goto IL_7B4;
									IL_793:
									flag = false;
									if (53487 - 351765 == -298277)
									{
										goto IL_422;
									}
								}
								else if (race == eRace.Robots)
								{
									if (243702 - 467950 != -224248)
									{
										goto IL_422;
									}
									flag = true;
									if (63330 - 198078 != -134748)
									{
										goto IL_422;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (95415 - 121809 != -26394)
									{
										goto IL_422;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_473;
									}
									if (291308 - 580030 == -288721)
									{
										goto IL_422;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_473;
									}
									if (227411 - 339993 == -112581)
									{
										goto IL_422;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (68816 - 337164 != -268348)
										{
											goto IL_422;
										}
										goto IL_473;
									}
									goto IL_7B4;
									IL_473:
									flag = false;
									if (64739 - 463585 != -398846)
									{
										goto IL_422;
									}
								}
								else if (race == eRace.Structure)
								{
									if (272774 - 100854 != 171920)
									{
										goto IL_422;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (92283 - 313978 != -221695)
										{
											goto IL_422;
										}
										flag = false;
										if (227657 - 263895 != -36238)
										{
											goto IL_422;
										}
									}
								}
								IL_7B4:
								if (flag)
								{
									if (122234 - 333433 == -211198)
									{
										goto IL_422;
									}
									if (characterControl.hp > 0)
									{
										if (264679 - 588989 == -324309)
										{
											goto IL_422;
										}
										if (characterControl.recieveTarget)
										{
											if (96390 - 192302 == -95911)
											{
												goto IL_422;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (178370 - 482199 != -303829)
												{
													goto IL_422;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (195922 - 343136 != -147214)
													{
														goto IL_422;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (228019 - 61984 != 166035)
													{
														goto IL_422;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (163993 - 498085 != -334092)
														{
															goto IL_422;
														}
														this.snVQGB4bxa.myAttackTarget = gameObject;
														if (208611 - 416697 == -208085)
														{
															goto IL_422;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (295489 - 188390 == 107100)
														{
															goto IL_422;
														}
														this.snVQGB4bxa.addHate(characterControl.ActorNr, 5);
														if (188077 - 244088 != -56011)
														{
															goto IL_422;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (110236 - 35381 == 74856)
														{
															goto IL_422;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (83039 - 346696 == -263656)
														{
															goto IL_422;
														}
														if (num < (float)60)
														{
															if (228783 - 240022 == -11238)
															{
																goto IL_422;
															}
															if (characterControl.hp > 0)
															{
																if (145002 - 254465 != -109463)
																{
																	goto IL_422;
																}
																this.snVQGB4bxa.myAttackTarget = gameObject;
																if (232155 - 223903 == 8253)
																{
																	goto IL_422;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (227974 - 518493 != -290519)
																{
																	goto IL_422;
																}
																this.snVQGB4bxa.addHate(characterControl.ActorNr, 5);
																if (71529 - 414976 != -343447)
																{
																	goto IL_422;
																}
															}
														}
													}
													if (this.snVQGB4bxa.myAttackTarget)
													{
														if (210598 - 450994 != -240396)
														{
															goto IL_422;
														}
														this.snVQGB4bxa.isAlert = true;
														if (163295 - 320679 == -157383)
														{
															goto IL_422;
														}
														this.dlLQq3WJZb = Time.time;
														if (110790 - 41285 == 69506)
														{
															goto IL_422;
														}
													}
												}
											}
										}
									}
								}
							}
							if (180894 - 339778 != -158883)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x000E5E94 File Offset: 0x000E4094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x000E5E98 File Offset: 0x000E4098
	internal static bool SxGuvcQiSEGJhkCxT5t()
	{
		return true;
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x000E5E9C File Offset: 0x000E409C
	internal static bool xajQf9QKTqjSbcGmvLF()
	{
		return false;
	}

	// Token: 0x040007E2 RID: 2018
	private CharacterControl snVQGB4bxa;

	// Token: 0x040007E3 RID: 2019
	private PineBug xyqQ1hUiA7;

	// Token: 0x040007E4 RID: 2020
	public string AI_state;

	// Token: 0x040007E5 RID: 2021
	private float dlLQq3WJZb;

	// Token: 0x040007E6 RID: 2022
	private float TEIQpBBjhN;

	// Token: 0x040007E7 RID: 2023
	private float BvCQRBYkdE;
}
