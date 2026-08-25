using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CEB RID: 3307
[Serializable]
public class Lizard_AI : MonoBehaviour
{
	// Token: 0x06004A40 RID: 19008 RVA: 0x00933940 File Offset: 0x00931B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Lizard_AI()
	{
		if (182461 - 26498 != 155963)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (193243 - 393475 != -200231)
			{
				base..ctor();
				if (92766 - 521066 == -428300)
				{
					this.AI_state = "none";
					if (124741 - 256178 != -131436)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004A41 RID: 19009 RVA: 0x009339DC File Offset: 0x00931BDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.Nivc5Gi8nqQ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.AUFc5132wcb = (Lizard)this.GetComponent(typeof(Lizard));
	}

	// Token: 0x06004A42 RID: 19010 RVA: 0x00933A14 File Offset: 0x00931C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (60741 - 163373 != -102631)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (226235 - 209706 == 16530)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (188211 - 37479 != 150732)
				{
					continue;
				}
			}
			if (this.Nivc5Gi8nqQ.isControlled)
			{
				break;
			}
			if (31111 - 225394 == -194283)
			{
				this.AIControl();
				if (21045 - 246681 == -225636)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004A43 RID: 19011 RVA: 0x00933AE0 File Offset: 0x00931CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (79026 - 173024 != -93998)
		{
		}
		for (;;)
		{
			this.ehlc5pQbe4u = (float)0;
			if (205870 - 341473 != -135602)
			{
				if (this.Nivc5Gi8nqQ.isMine)
				{
					if (139400 - 415014 != -275613)
					{
						if (this.Nivc5Gi8nqQ.actionState != "standby")
						{
							if (105058 - 330602 != -225544)
							{
								continue;
							}
							if (this.Nivc5Gi8nqQ.actionState != "run")
							{
								if (47445 - 156561 != -109116)
								{
									continue;
								}
								break;
							}
						}
						if (!this.Nivc5Gi8nqQ.isAlert)
						{
							if (143484 - 430253 == -286769)
							{
								if (this.Nivc5Gi8nqQ.isSummon)
								{
									if (283674 - 31245 != 252429)
									{
										continue;
									}
									if (this.Nivc5Gi8nqQ.mSummoner != null)
									{
										if (218060 - 460682 == -242621)
										{
											continue;
										}
										Vector3 vector = this.Nivc5Gi8nqQ.mSummoner.transform.position - this.transform.position;
										if (283474 - 497279 != -213804)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (52657 - 569096 == -516438)
												{
													continue;
												}
												this.AI_follow(this.Nivc5Gi8nqQ.mSummoner);
												if (194090 - 565984 == -371893)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (256677 - 306570 != -49893)
												{
													continue;
												}
												this.AI_resetTimer();
												if (33276 - 315509 != -282233)
												{
													continue;
												}
												this.AI_visionCheck();
												if (150350 - 427868 == -277517)
												{
													continue;
												}
											}
											goto IL_C40;
										}
										continue;
									}
								}
								this.AI_idle(3f, 1f);
								if (156117 - 242130 != -86013)
								{
									continue;
								}
								this.AI_resetTimer();
								if (132209 - 127483 != 4726)
								{
									continue;
								}
								this.AI_visionCheck();
								if (186468 - 229733 == -43264)
								{
									continue;
								}
								IL_C40:
								if (!this.Nivc5Gi8nqQ.myAttackTarget)
								{
									break;
								}
								if (142394 - 42358 != 100037)
								{
									this.Nivc5Gi8nqQ.isAlert = true;
									if (53333 - 150270 != -96936)
									{
										this.oKuc5qCHoV7 = Time.time;
										if (239466 - 579239 == -339773)
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
							if (89419 - 157423 != -68003)
							{
								this.AI_idle(1f, 1f);
								if (1325 - 140675 == -139350)
								{
									this.AI_attack(6f, 1f);
									if (51864 - 77297 != -25432)
									{
										this.AI_resetTimer();
										if (53057 - 38085 != 14973)
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
					if (this.Nivc5Gi8nqQ.actionState != "standby")
					{
						if (206395 - 396548 != -190153)
						{
							continue;
						}
						if (this.Nivc5Gi8nqQ.actionState != "run")
						{
							if (176228 - 512534 != -336305)
							{
								break;
							}
							continue;
						}
					}
					if (this.Nivc5Gi8nqQ.nSpeed != (float)0)
					{
						if (55974 - 429487 != -373513)
						{
							continue;
						}
						if (this.Nivc5Gi8nqQ.nPosition != this.Nivc5Gi8nqQ.oPosition)
						{
							if (97227 - 226808 == -129580)
							{
								continue;
							}
							Vector3 a = this.Nivc5Gi8nqQ.nPosition + 0.1f * this.Nivc5Gi8nqQ.runSpeed * this.Nivc5Gi8nqQ.nDirection;
							if (1265 - 562091 == -560825)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (103521 - 590094 != -486573)
							{
								continue;
							}
							Vector3 normalized = vector2.normalized;
							if (158828 - 249289 != -90461)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.transform.position);
							if (266397 - 75087 != 191310)
							{
								continue;
							}
							float magnitude = vector3.magnitude;
							if (192770 - 519180 != -326410)
							{
								continue;
							}
							if (magnitude > this.Nivc5Gi8nqQ.runSpeed)
							{
								if (81939 - 61618 != 20321)
								{
									continue;
								}
								this.transform.position = this.Nivc5Gi8nqQ.nPosition;
								if (102509 - 179620 != -77111)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.Nivc5Gi8nqQ.runSpeed)
							{
								if (37805 - 437815 == -400009)
								{
									continue;
								}
								this.Nivc5Gi8nqQ.moveSpeed = Mathf.Lerp(this.Nivc5Gi8nqQ.moveSpeed, 1.1f * this.Nivc5Gi8nqQ.runSpeed, (float)10 * Time.deltaTime);
								if (17580 - 133258 != -115678)
								{
									continue;
								}
								this.Nivc5Gi8nqQ.vDirection = normalized;
								if (93107 - 158895 != -65788)
								{
									continue;
								}
								this.Nivc5Gi8nqQ.vMovement = normalized;
								if (83367 - 347758 != -264391)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (125282 - 120984 != 4298)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (119784 - 186980 != -67196)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (115042 - 446580 != -331538)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (207323 - 323417 != -116094)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (215869 - 212995 != 2875)
								{
									break;
								}
								continue;
							}
							else
							{
								this.Nivc5Gi8nqQ.moveSpeed = Mathf.Lerp(this.Nivc5Gi8nqQ.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (293011 - 547308 == -254296)
								{
									continue;
								}
								this.Nivc5Gi8nqQ.vDirection = normalized;
								if (209878 - 8449 != 201429)
								{
									continue;
								}
								this.Nivc5Gi8nqQ.vMovement = normalized;
								if (121777 - 37988 != 83789)
								{
									continue;
								}
								this.animation.CrossFade("battle", 0.5f);
								if (34364 - 109245 != -74881)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (255702 - 222220 != 33482)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.Nivc5Gi8nqQ.moveSpeed != (float)0)
					{
						if (159519 - 476745 == -317226)
						{
							Vector3 vector4 = global::Math.vFlat(this.Nivc5Gi8nqQ.nPosition - this.transform.position);
							if (32216 - 260953 != -228736)
							{
								float sqrMagnitude = vector4.sqrMagnitude;
								if (27746 - 532007 == -504261)
								{
									if (sqrMagnitude > this.Nivc5Gi8nqQ.runSpeed)
									{
										if (55608 - 195963 != -140354)
										{
											this.transform.position = this.Nivc5Gi8nqQ.nPosition;
											if (140115 - 466522 != -326406)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (167500 - 299441 != -131940)
										{
											if (sqrMagnitude > (float)1)
											{
												if (97971 - 388913 != -290942)
												{
													continue;
												}
												this.Nivc5Gi8nqQ.moveSpeed = Mathf.Lerp(this.Nivc5Gi8nqQ.moveSpeed, this.Nivc5Gi8nqQ.runSpeed, (float)10 * Time.deltaTime);
												if (1208 - 309069 != -307861)
												{
													continue;
												}
											}
											else
											{
												this.Nivc5Gi8nqQ.moveSpeed = Mathf.Lerp(this.Nivc5Gi8nqQ.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (230295 - 311122 == -80826)
												{
													continue;
												}
											}
											this.Nivc5Gi8nqQ.vMovement = vector4;
											if (188171 - 152756 == 35415)
											{
												this.Nivc5Gi8nqQ.vDirection = vector4;
												if (277444 - 513726 != -236281)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector4, (float)10 * Time.deltaTime));
													if (113516 - 322662 == -209146)
													{
														this.animation.CrossFade("run", 0.2f);
														if (108485 - 478531 == -370046)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (139337 - 418611 != -279273)
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
										this.Nivc5Gi8nqQ.vMovement = vector4;
										if (295192 - 432846 != -137653)
										{
											this.Nivc5Gi8nqQ.moveSpeed = (float)0;
											if (271024 - 120570 == 150454)
											{
												this.transform.rotation = Quaternion.LookRotation(this.Nivc5Gi8nqQ.vDirection);
												if (14815 - 515583 == -500768)
												{
													this.animation.CrossFade("battle", 0.2f);
													if (158447 - 410010 != -251562)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (165364 - 379111 == -213747)
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
						this.animation.CrossFade("battle", 0.2f);
						if (68653 - 196374 == -127721)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (219056 - 106971 == 112085)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A44 RID: 19012 RVA: 0x0093479C File Offset: 0x0093299C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (30774 - 301789 != -271015)
		{
		}
		do
		{
			if (Time.time - this.oKuc5qCHoV7 >= this.ehlc5pQbe4u)
			{
				if (294042 - 579685 == -285642)
				{
					continue;
				}
				if (Time.time - this.oKuc5qCHoV7 < this.ehlc5pQbe4u + mTime)
				{
					if (172521 - 137509 == 35013)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (88795 - 242319 == -153523)
						{
							continue;
						}
						this.AI_state = "idle";
						if (57351 - 200211 == -142859)
						{
							continue;
						}
						this.oKuc5qCHoV7 -= UnityEngine.Random.Range((float)0, rTimer);
						if (157759 - 119626 == 38134)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.vDirection = Vector3.zero;
						if (45016 - 208230 == -163213)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.vMovement = this.transform.forward;
						if (29538 - 258486 == -228947)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.actionState = "standby";
						if (118484 - 512206 != -393722)
						{
							continue;
						}
					}
					this.Nivc5Gi8nqQ.moveSpeed = Mathf.Lerp(this.Nivc5Gi8nqQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (245984 - 260448 != -14464)
					{
						continue;
					}
					if (this.Nivc5Gi8nqQ.moveSpeed < 0.1f * this.Nivc5Gi8nqQ.runSpeed)
					{
						if (247391 - 154830 != 92561)
						{
							continue;
						}
						this.animation.CrossFade("battle", 0.2f);
						if (140739 - 277774 != -137035)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (153353 - 121589 == 31765)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.moveSpeed = (float)0;
						if (35015 - 288257 == -253241)
						{
							continue;
						}
					}
				}
			}
			this.ehlc5pQbe4u += mTime;
		}
		while (64348 - 78263 == -13914);
	}

	// Token: 0x06004A45 RID: 19013 RVA: 0x00934A60 File Offset: 0x00932C60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (171310 - 334980 != -163670)
		{
		}
		for (;;)
		{
			this.Nivc5Gi8nqQ.vDirection = followObject.transform.position;
			if (108576 - 425705 != -317128)
			{
				this.Nivc5Gi8nqQ.vDirection.y = this.transform.position.y;
				if (230252 - 409241 != -178988)
				{
					this.Nivc5Gi8nqQ.vMovement = (this.Nivc5Gi8nqQ.vDirection - this.transform.position).normalized;
					if (288880 - 546523 != -257642)
					{
						this.transform.rotation = Quaternion.LookRotation(this.Nivc5Gi8nqQ.vMovement);
						if (259101 - 144012 == 115089)
						{
							this.Nivc5Gi8nqQ.actionState = "run";
							if (263615 - 564467 == -300852)
							{
								this.animation.Play("run");
								if (188900 - 518277 != -329376)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (255132 - 579944 == -324812)
									{
										this.Nivc5Gi8nqQ.moveSpeed = Mathf.Lerp(this.Nivc5Gi8nqQ.moveSpeed, this.Nivc5Gi8nqQ.runSpeed, (float)4 * Time.deltaTime);
										if (217136 - 499516 != -282379)
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

	// Token: 0x06004A46 RID: 19014 RVA: 0x00934C48 File Offset: 0x00932E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (64662 - 301211 != -236549)
		{
		}
		do
		{
			if (Time.time - this.oKuc5qCHoV7 >= this.ehlc5pQbe4u)
			{
				if (212020 - 558460 == -346439)
				{
					continue;
				}
				if (Time.time - this.oKuc5qCHoV7 < this.ehlc5pQbe4u + mTime)
				{
					if (106107 - 325071 == -218963)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (285699 - 573320 == -287620)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (181130 - 127921 != 53209)
						{
							continue;
						}
						this.oKuc5qCHoV7 -= UnityEngine.Random.Range((float)0, rTimer);
						if (28823 - 17098 == 11726)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.vDirection = this.Nivc5Gi8nqQ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (115129 - 447338 != -332209)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.vDirection.y = this.transform.position.y;
						if (30933 - 323458 != -292525)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.vMovement = (this.Nivc5Gi8nqQ.vDirection - this.transform.position).normalized;
						if (60538 - 7705 != 52833)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Nivc5Gi8nqQ.vMovement);
						if (207689 - 463998 != -256309)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.actionState = "run";
						if (7891 - 237551 != -229660)
						{
							continue;
						}
						this.animation.Play("run");
						if (286108 - 105184 == 180925)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (155193 - 214727 != -59534)
						{
							continue;
						}
					}
					this.Nivc5Gi8nqQ.moveSpeed = Mathf.Lerp(this.Nivc5Gi8nqQ.moveSpeed, this.Nivc5Gi8nqQ.runSpeed, (float)4 * Time.deltaTime);
					if (157617 - 277411 == -119793)
					{
						continue;
					}
				}
			}
			this.ehlc5pQbe4u += mTime;
		}
		while (288542 - 265108 != 23434);
	}

	// Token: 0x06004A47 RID: 19015 RVA: 0x00934F50 File Offset: 0x00933150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (111816 - 35679 != 76137)
		{
		}
		do
		{
			if (Time.time - this.oKuc5qCHoV7 >= this.ehlc5pQbe4u)
			{
				if (210537 - 437172 == -226634)
				{
					continue;
				}
				if (Time.time - this.oKuc5qCHoV7 < this.ehlc5pQbe4u + mTime)
				{
					if (288793 - 361 == 288433)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (288961 - 297737 != -8776)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (57276 - 232968 == -175691)
						{
							continue;
						}
						this.oKuc5qCHoV7 = Time.time - mTime - this.ehlc5pQbe4u;
						if (190875 - 342556 == -151680)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.vDirection = Vector3.zero;
						if (24027 - 444713 != -420686)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.vMovement = this.transform.forward;
						if (131575 - 232052 == -100476)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.actionState = "standby";
						if (44031 - 255873 == -211841)
						{
							continue;
						}
						this.Nivc5Gi8nqQ.myAttackTarget = this.Nivc5Gi8nqQ.getHateTarget(5, 50);
						if (151430 - 120428 == 31003)
						{
							continue;
						}
						if (!this.Nivc5Gi8nqQ.myAttackTarget)
						{
							if (203937 - 555693 == -351755)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.isAlert = false;
							if (8062 - 373357 != -365295)
							{
								continue;
							}
							this.oKuc5qCHoV7 = Time.time;
							if (137862 - 282616 != -144754)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.myAttackTarget = null;
							if (34420 - 182266 != -147846)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.mOriginalPosition = this.transform.position;
							if (69930 - 517289 != -447359)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.Nivc5Gi8nqQ.myAttackTarget;
							if (139326 - 98105 != 41221)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (69404 - 261433 == -192028)
							{
								continue;
							}
							if (!(characterControl == null))
							{
								if (64482 - 454376 != -389894)
								{
									continue;
								}
								if (characterControl.hp <= 0)
								{
									if (192580 - 376555 != -183975)
									{
										continue;
									}
								}
								else
								{
									this.Nivc5Gi8nqQ.vDirection = myAttackTarget.transform.position;
									if (257251 - 275447 != -18196)
									{
										continue;
									}
									this.Nivc5Gi8nqQ.vDirection.y = this.transform.position.y;
									if (205510 - 221344 == -15833)
									{
										continue;
									}
									this.Nivc5Gi8nqQ.vMovement = (this.Nivc5Gi8nqQ.vDirection - this.transform.position).normalized;
									if (67551 - 234741 == -167189)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(this.Nivc5Gi8nqQ.vMovement);
									if (216026 - 390308 != -174282)
									{
										continue;
									}
									goto IL_70;
								}
							}
							this.Nivc5Gi8nqQ.isAlert = false;
							if (180463 - 346235 != -165772)
							{
								continue;
							}
							this.oKuc5qCHoV7 = Time.time;
							if (218329 - 501171 == -282841)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.myAttackTarget = null;
							if (74497 - 564820 != -490323)
							{
								continue;
							}
						}
					}
				}
			}
			IL_70:
			this.ehlc5pQbe4u += mTime;
		}
		while (146331 - 289819 != -143488);
	}

	// Token: 0x06004A48 RID: 19016 RVA: 0x00935424 File Offset: 0x00933624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (273940 - 543551 != -269611)
		{
		}
		do
		{
			IL_893:
			if (Time.time - this.oKuc5qCHoV7 >= this.ehlc5pQbe4u)
			{
				if (69193 - 477851 != -408658)
				{
					continue;
				}
				if (Time.time - this.oKuc5qCHoV7 < this.ehlc5pQbe4u + mTime)
				{
					if (28023 - 264315 == -236291)
					{
						continue;
					}
					if (!this.Nivc5Gi8nqQ.myAttackTarget)
					{
						if (102880 - 36296 != 66584)
						{
							continue;
						}
						this.oKuc5qCHoV7 = Time.time - mTime - this.ehlc5pQbe4u;
						if (122710 - 250707 != -127996)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.Nivc5Gi8nqQ.myAttackTarget;
						if (191218 - 296967 != -105749)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (110127 - 372393 != -262266)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (82324 - 503486 == -421161)
						{
							continue;
						}
						if ((float)this.Nivc5Gi8nqQ.hp < 0.5f * (float)this.Nivc5Gi8nqQ.mhp)
						{
							if (130357 - 94879 == 35479)
							{
								continue;
							}
							if (this.Nivc5Gi8nqQ.isTimeOut("cAttack") == (float)0)
							{
								if (11042 - 300502 == -289459)
								{
									continue;
								}
								UnityScript.Lang.Array obj = Hate.findFriends(this.transform.position, (float)24, this.gameObject.layer);
								if (89045 - 83236 == 5810)
								{
									continue;
								}
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
								if (223683 - 55575 == 168109)
								{
									continue;
								}
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
									if (79229 - 599322 == -520092)
									{
										goto IL_893;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (88872 - 502501 == -413628)
									{
										goto IL_893;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (65072 - 485838 != -420766)
									{
										goto IL_893;
									}
									if ((float)characterControl.hp < 0.5f * (float)characterControl.mhp)
									{
										if (60161 - 147108 == -86946)
										{
											goto IL_893;
										}
										if (characterControl.hp < this.Nivc5Gi8nqQ.hp)
										{
											if (58576 - 415333 != -356757)
											{
												goto IL_893;
											}
											Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
											if (209345 - 232443 != -23098)
											{
												goto IL_893;
											}
											vector = vector2.normalized;
											if (216969 - 100718 == 116252)
											{
												goto IL_893;
											}
											UnityRuntimeServices.Update(enumerator, gameObject);
											if (97817 - 464540 == -366722)
											{
												goto IL_893;
											}
											this.oKuc5qCHoV7 = Time.time - mTime - this.ehlc5pQbe4u;
											if (77243 - 502735 == -425491)
											{
												goto IL_893;
											}
											this.AUFc5132wcb.StartCoroutine_Auto(this.AUFc5132wcb.RPC_potion(this.transform.position, vector, characterControl.ActorNr));
											if (40585 - 119096 != -78511)
											{
												goto IL_893;
											}
											if (!PhotonClient.IsInitialized())
											{
												return;
											}
											if (154144 - 414828 != -260684)
											{
												goto IL_893;
											}
											this.AUFc5132wcb.ActionEvent("RPC_potion", this.transform.position, vector, characterControl.ActorNr);
											if (226155 - 21487 != 204669)
											{
												return;
											}
											goto IL_893;
										}
									}
								}
								if (22263 - 116770 == -94506)
								{
									continue;
								}
								this.oKuc5qCHoV7 = Time.time - mTime - this.ehlc5pQbe4u;
								if (110987 - 414186 == -303198)
								{
									continue;
								}
								this.AUFc5132wcb.StartCoroutine_Auto(this.AUFc5132wcb.RPC_nAttack(this.transform.position, this.transform.forward, this.Nivc5Gi8nqQ.ActorNr));
								if (239454 - 146316 != 93139)
								{
									if (PhotonClient.IsInitialized())
									{
										if (76319 - 78832 == -2512)
										{
											continue;
										}
										this.AUFc5132wcb.ActionEvent("RPC_nAttack", this.transform.position, this.transform.forward, this.Nivc5Gi8nqQ.ActorNr);
										if (127936 - 108288 == 19649)
										{
											continue;
										}
									}
									goto IL_4CE;
								}
								continue;
							}
						}
						if (num < (float)3)
						{
							if (102424 - 213799 == -111374)
							{
								continue;
							}
							if (this.Nivc5Gi8nqQ.isTimeOut("nAttack") == (float)0)
							{
								if (90315 - 80863 != 9452)
								{
									continue;
								}
								this.oKuc5qCHoV7 = Time.time - mTime - this.ehlc5pQbe4u;
								if (257101 - 65339 != 191762)
								{
									continue;
								}
								this.AUFc5132wcb.StartCoroutine_Auto(this.AUFc5132wcb.RPC_nAttack(this.transform.position, vector, 0));
								if (242609 - 112590 != 130020)
								{
									if (PhotonClient.IsInitialized())
									{
										if (182949 - 238657 == -55707)
										{
											continue;
										}
										this.AUFc5132wcb.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (83687 - 126153 == -42465)
										{
											continue;
										}
									}
									goto IL_4CE;
								}
								continue;
							}
						}
						if (this.Nivc5Gi8nqQ.isTimeOut("nAttack") == (float)0)
						{
							if (248163 - 512198 != -264035)
							{
								continue;
							}
							this.AI_state = "attack";
							if (119181 - 352564 == -233382)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.vDirection = myAttackTarget.transform.position;
							if (141915 - 301220 == -159304)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.vDirection.y = this.transform.position.y;
							if (51852 - 363163 == -311310)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.vMovement = (this.Nivc5Gi8nqQ.vDirection - this.transform.position).normalized;
							if (85494 - 373859 == -288364)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.Nivc5Gi8nqQ.vMovement);
							if (111675 - 423431 != -311756)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.actionState = "run";
							if (70132 - 138769 == -68636)
							{
								continue;
							}
							this.animation.Play("run");
							if (189421 - 224334 != -34913)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (87305 - 578880 != -491575)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.moveSpeed = Mathf.Lerp(this.Nivc5Gi8nqQ.moveSpeed, this.Nivc5Gi8nqQ.runSpeed, (float)4 * Time.deltaTime);
							if (143081 - 118992 == 24090)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (80457 - 588571 == -508113)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.vDirection = myAttackTarget.transform.position;
							if (139668 - 268235 != -128567)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.vDirection.y = this.transform.position.y;
							if (40562 - 103728 == -63165)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.vMovement = (this.Nivc5Gi8nqQ.vDirection - this.transform.position).normalized;
							if (277269 - 89592 != 187677)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.Nivc5Gi8nqQ.vMovement);
							if (166302 - 422178 == -255875)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.actionState = "standby";
							if (33807 - 513016 == -479208)
							{
								continue;
							}
							this.animation.CrossFade("battle");
							if (130273 - 435227 == -304953)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (98654 - 258994 == -160339)
							{
								continue;
							}
							this.Nivc5Gi8nqQ.moveSpeed = Mathf.Lerp(this.Nivc5Gi8nqQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (140396 - 207843 == -67446)
							{
								continue;
							}
						}
					}
				}
			}
			IL_4CE:
			this.ehlc5pQbe4u += mTime;
		}
		while (127326 - 252830 == -125503);
	}

	// Token: 0x06004A49 RID: 19017 RVA: 0x00935F20 File Offset: 0x00934120
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (37352 - 338840 != -301488)
		{
		}
		while (Time.time - this.oKuc5qCHoV7 > this.ehlc5pQbe4u)
		{
			if (22346 - 563674 == -541328)
			{
				this.AI_state = "none";
				if (52469 - 419551 == -367082)
				{
					this.oKuc5qCHoV7 = Time.time;
					if (25165 - 22225 != 2941)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004A4A RID: 19018 RVA: 0x00935FD4 File Offset: 0x009341D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (131920 - 175875 != -43955)
		{
		}
		for (;;)
		{
			IL_351:
			if (this.hCfc5R7hJyD > Time.time)
			{
				if (227496 - 76800 == 150696)
				{
					break;
				}
			}
			else
			{
				this.hCfc5R7hJyD = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (65157 - 598634 != -533476)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (155963 - 293182 == -137219)
					{
						if (199280 - 361851 == -162571)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (237576 - 28449 != 209128)
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
									if (115510 - 268758 != -153248)
									{
										goto IL_351;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (226633 - 112257 == 114377)
									{
										goto IL_351;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (82689 - 377239 == -294549)
									{
										goto IL_351;
									}
									bool flag = true;
									if (2962 - 137022 != -134060)
									{
										goto IL_351;
									}
									eRace race = this.Nivc5Gi8nqQ.Race;
									if (214072 - 330607 == -116534)
									{
										goto IL_351;
									}
									if (race == eRace.Tails)
									{
										if (297521 - 106036 == 191486)
										{
											goto IL_351;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_632;
										}
										if (268598 - 30282 != 238316)
										{
											goto IL_351;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (128226 - 101291 != 26935)
											{
												goto IL_351;
											}
											goto IL_632;
										}
										goto IL_2F9;
										IL_632:
										flag = false;
										if (259649 - 553031 == -293381)
										{
											goto IL_351;
										}
									}
									else if (race == eRace.Plants)
									{
										if (53001 - 287873 == -234871)
										{
											goto IL_351;
										}
										flag = false;
										if (231133 - 136913 == 94221)
										{
											goto IL_351;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (30274 - 6410 != 23864)
										{
											goto IL_351;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_319;
										}
										if (56085 - 362465 == -306379)
										{
											goto IL_351;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (263946 - 109916 != 154031)
											{
												goto IL_319;
											}
											goto IL_351;
										}
										goto IL_2F9;
										IL_319:
										flag = false;
										if (187318 - 377394 != -190076)
										{
											goto IL_351;
										}
									}
									else if (race == eRace.Robots)
									{
										if (103568 - 11300 != 92268)
										{
											goto IL_351;
										}
										flag = true;
										if (235052 - 353290 != -118238)
										{
											goto IL_351;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (33886 - 175451 == -141564)
										{
											goto IL_351;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_DB;
										}
										if (251565 - 371326 == -119760)
										{
											goto IL_351;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_DB;
										}
										if (226300 - 180942 == 45359)
										{
											goto IL_351;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (116194 - 155413 != -39219)
											{
												goto IL_351;
											}
											goto IL_DB;
										}
										goto IL_2F9;
										IL_DB:
										flag = false;
										if (106869 - 3995 != 102874)
										{
											goto IL_351;
										}
									}
									else if (race == eRace.Structure)
									{
										if (201274 - 298797 == -97522)
										{
											goto IL_351;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (163427 - 93550 != 69877)
											{
												goto IL_351;
											}
											flag = false;
											if (131493 - 188519 != -57026)
											{
												goto IL_351;
											}
										}
									}
									IL_2F9:
									if (flag)
									{
										if (291670 - 78861 == 212810)
										{
											goto IL_351;
										}
										if (characterControl.hp > 0)
										{
											if (250391 - 37395 == 212997)
											{
												goto IL_351;
											}
											if (characterControl.recieveTarget)
											{
												if (110066 - 524546 == -414479)
												{
													goto IL_351;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (47490 - 52882 == -5391)
													{
														goto IL_351;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (240147 - 504648 != -264501)
														{
															goto IL_351;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (170906 - 125166 == 45741)
														{
															goto IL_351;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (195245 - 334922 == -139676)
															{
																goto IL_351;
															}
															this.Nivc5Gi8nqQ.myAttackTarget = gameObject;
															if (270691 - 376384 != -105693)
															{
																goto IL_351;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (176031 - 363376 == -187344)
															{
																goto IL_351;
															}
															this.Nivc5Gi8nqQ.addHate(characterControl.ActorNr, 5);
															if (196408 - 310074 != -113666)
															{
																goto IL_351;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (50458 - 220227 == -169768)
															{
																goto IL_351;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (61199 - 252018 != -190819)
															{
																goto IL_351;
															}
															if (num < (float)60)
															{
																if (139668 - 323243 != -183575)
																{
																	goto IL_351;
																}
																if (characterControl.hp > 0)
																{
																	if (207026 - 415589 != -208563)
																	{
																		goto IL_351;
																	}
																	this.Nivc5Gi8nqQ.myAttackTarget = gameObject;
																	if (202485 - 189003 == 13483)
																	{
																		goto IL_351;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (206259 - 189376 == 16884)
																	{
																		goto IL_351;
																	}
																	this.Nivc5Gi8nqQ.addHate(characterControl.ActorNr, 5);
																	if (241530 - 261938 == -20407)
																	{
																		goto IL_351;
																	}
																}
															}
														}
														if (this.Nivc5Gi8nqQ.myAttackTarget)
														{
															if (117446 - 269293 == -151846)
															{
																goto IL_351;
															}
															this.Nivc5Gi8nqQ.isAlert = true;
															if (80263 - 535932 == -455668)
															{
																goto IL_351;
															}
															this.oKuc5qCHoV7 = Time.time;
															if (36662 - 424749 != -388087)
															{
																goto IL_351;
															}
														}
													}
												}
											}
										}
									}
								}
								if (11334 - 221791 != -210456)
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

	// Token: 0x06004A4B RID: 19019 RVA: 0x009367EC File Offset: 0x009349EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004A4C RID: 19020 RVA: 0x009367F0 File Offset: 0x009349F0
	internal static bool arFmeB5wDG0IyDNJCOwa()
	{
		return true;
	}

	// Token: 0x06004A4D RID: 19021 RVA: 0x009367F4 File Offset: 0x009349F4
	internal static bool z5HHn25wv6q1iYkqETEN()
	{
		return false;
	}

	// Token: 0x0400550A RID: 21770
	private CharacterControl Nivc5Gi8nqQ;

	// Token: 0x0400550B RID: 21771
	private Lizard AUFc5132wcb;

	// Token: 0x0400550C RID: 21772
	public string AI_state;

	// Token: 0x0400550D RID: 21773
	private float oKuc5qCHoV7;

	// Token: 0x0400550E RID: 21774
	private float ehlc5pQbe4u;

	// Token: 0x0400550F RID: 21775
	private float hCfc5R7hJyD;
}
