using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C4A RID: 3146
[Serializable]
public class GoatFarmer_AI : MonoBehaviour
{
	// Token: 0x06004658 RID: 18008 RVA: 0x008C98C8 File Offset: 0x008C7AC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GoatFarmer_AI()
	{
		if (74545 - 277685 != -203140)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (54576 - 572952 != -518375)
			{
				base..ctor();
				if (87067 - 578510 != -491442)
				{
					this.AI_state = "none";
					if (106366 - 264202 == -157836)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004659 RID: 18009 RVA: 0x008C9964 File Offset: 0x008C7B64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.fldKvMLicb = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.VyUKlCRTvk = (GoatFarmer)this.GetComponent(typeof(GoatFarmer));
	}

	// Token: 0x0600465A RID: 18010 RVA: 0x008C999C File Offset: 0x008C7B9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (27041 - 359126 != -332084)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (255553 - 205749 == 49805)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (277628 - 386269 == -108640)
				{
					continue;
				}
			}
			if (this.fldKvMLicb.isControlled)
			{
				break;
			}
			if (37361 - 423905 == -386544)
			{
				this.AIControl();
				if (165656 - 371510 != -205853)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600465B RID: 18011 RVA: 0x008C9A68 File Offset: 0x008C7C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (17715 - 275083 != -257367)
		{
		}
		for (;;)
		{
			this.WSLK1GPKe0 = (float)0;
			if (146208 - 304960 != -158751)
			{
				if (this.fldKvMLicb.isMine)
				{
					if (16800 - 257358 != -240557)
					{
						if (this.fldKvMLicb.actionState != "standby")
						{
							if (4279 - 444653 == -440373)
							{
								continue;
							}
							if (this.fldKvMLicb.actionState != "run")
							{
								if (234528 - 593647 != -359119)
								{
									continue;
								}
								break;
							}
						}
						if (!this.fldKvMLicb.isAlert)
						{
							if (210698 - 280546 == -69848)
							{
								if (this.fldKvMLicb.isSummon)
								{
									if (41501 - 486038 != -444537)
									{
										continue;
									}
									if (this.fldKvMLicb.mSummoner != null)
									{
										if (163698 - 583139 == -419440)
										{
											continue;
										}
										Vector3 vector = this.fldKvMLicb.mSummoner.transform.position - this.transform.position;
										if (293287 - 572488 != -279200)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (212357 - 232367 == -20009)
												{
													continue;
												}
												this.AI_follow(this.fldKvMLicb.mSummoner);
												if (109277 - 213456 != -104179)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (209550 - 559315 == -349764)
												{
													continue;
												}
												this.AI_resetTimer();
												if (93664 - 290465 == -196800)
												{
													continue;
												}
												this.AI_visionCheck();
												if (170563 - 422500 != -251937)
												{
													continue;
												}
											}
											goto IL_738;
										}
										continue;
									}
								}
								this.AI_idle(3f, 1f);
								if (223139 - 186628 != 36511)
								{
									continue;
								}
								this.AI_resetTimer();
								if (220313 - 186004 != 34309)
								{
									continue;
								}
								this.AI_visionCheck();
								if (78399 - 596439 == -518039)
								{
									continue;
								}
								IL_738:
								if (!this.fldKvMLicb.myAttackTarget)
								{
									break;
								}
								if (164469 - 586483 != -422013)
								{
									this.fldKvMLicb.isAlert = true;
									if (217724 - 569212 == -351488)
									{
										this.Vk9KGUyKAa = Time.time;
										if (177440 - 287711 == -110271)
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
							if (62395 - 578678 != -516282)
							{
								this.AI_idle(3f, 1f);
								if (127852 - 400385 == -272533)
								{
									this.AI_attack(10f, (float)0);
									if (192017 - 2167 != 189851)
									{
										this.AI_resetTimer();
										if (182022 - 558823 != -376800)
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
					if (this.fldKvMLicb.actionState != "standby")
					{
						if (83627 - 165388 != -81761)
						{
							continue;
						}
						if (this.fldKvMLicb.actionState != "run")
						{
							if (286688 - 202710 != 83978)
							{
								continue;
							}
							break;
						}
					}
					if (this.fldKvMLicb.nSpeed != (float)0)
					{
						if (216489 - 257634 != -41145)
						{
							continue;
						}
						if (this.fldKvMLicb.nPosition != this.fldKvMLicb.oPosition)
						{
							if (214044 - 544574 != -330530)
							{
								continue;
							}
							Vector3 a = this.fldKvMLicb.nPosition + 0.1f * this.fldKvMLicb.runSpeed * this.fldKvMLicb.nDirection;
							if (13045 - 321751 != -308706)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (191659 - 393559 != -201900)
							{
								continue;
							}
							Vector3 normalized = vector2.normalized;
							if (96646 - 350519 == -253872)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.transform.position);
							if (159160 - 44629 == 114532)
							{
								continue;
							}
							float magnitude = vector3.magnitude;
							if (33418 - 44613 != -11195)
							{
								continue;
							}
							if (magnitude > this.fldKvMLicb.runSpeed)
							{
								if (33100 - 83572 == -50471)
								{
									continue;
								}
								this.transform.position = this.fldKvMLicb.nPosition;
								if (274242 - 2638 != 271605)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.fldKvMLicb.runSpeed)
							{
								if (127938 - 408127 == -280188)
								{
									continue;
								}
								this.fldKvMLicb.moveSpeed = Mathf.Lerp(this.fldKvMLicb.moveSpeed, 1.1f * this.fldKvMLicb.runSpeed, (float)10 * Time.deltaTime);
								if (242058 - 468008 != -225950)
								{
									continue;
								}
								this.fldKvMLicb.vDirection = normalized;
								if (201727 - 38066 == 163662)
								{
									continue;
								}
								this.fldKvMLicb.vMovement = normalized;
								if (35971 - 345474 != -309503)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (282243 - 297300 == -15056)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (105531 - 232174 != -126643)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (8537 - 120433 != -111896)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (113549 - 109589 == 3961)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (133014 - 135293 != -2278)
								{
									break;
								}
								continue;
							}
							else
							{
								this.fldKvMLicb.moveSpeed = Mathf.Lerp(this.fldKvMLicb.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (146235 - 16606 == 129630)
								{
									continue;
								}
								this.fldKvMLicb.vDirection = normalized;
								if (115511 - 194612 != -79101)
								{
									continue;
								}
								this.fldKvMLicb.vMovement = normalized;
								if (222148 - 191175 != 30973)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (146006 - 171989 == -25982)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (120233 - 389947 != -269714)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.fldKvMLicb.moveSpeed != (float)0)
					{
						if (258908 - 264472 == -5564)
						{
							Vector3 vector4 = global::Math.vFlat(this.fldKvMLicb.nPosition - this.transform.position);
							if (279125 - 169441 == 109684)
							{
								float sqrMagnitude = vector4.sqrMagnitude;
								if (273926 - 285781 == -11855)
								{
									if (sqrMagnitude > this.fldKvMLicb.runSpeed)
									{
										if (246301 - 136437 != 109865)
										{
											this.transform.position = this.fldKvMLicb.nPosition;
											if (198800 - 41008 != 157793)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (173845 - 57057 == 116788)
										{
											if (sqrMagnitude > (float)1)
											{
												if (270732 - 439997 != -169265)
												{
													continue;
												}
												this.fldKvMLicb.moveSpeed = Mathf.Lerp(this.fldKvMLicb.moveSpeed, this.fldKvMLicb.runSpeed, (float)10 * Time.deltaTime);
												if (43491 - 565793 == -522301)
												{
													continue;
												}
											}
											else
											{
												this.fldKvMLicb.moveSpeed = Mathf.Lerp(this.fldKvMLicb.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (117539 - 392584 != -275045)
												{
													continue;
												}
											}
											this.fldKvMLicb.vMovement = vector4;
											if (254063 - 513607 != -259543)
											{
												this.fldKvMLicb.vDirection = vector4;
												if (12925 - 437318 != -424392)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector4, (float)10 * Time.deltaTime));
													if (131091 - 210062 != -78970)
													{
														this.animation.CrossFade("run", 0.2f);
														if (76812 - 462505 != -385692)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (34544 - 7337 == 27207)
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
										this.fldKvMLicb.vMovement = vector4;
										if (58682 - 591446 != -532763)
										{
											this.fldKvMLicb.moveSpeed = (float)0;
											if (207858 - 58806 == 149052)
											{
												this.transform.rotation = Quaternion.LookRotation(this.fldKvMLicb.vDirection);
												if (50463 - 226072 != -175608)
												{
													this.animation.CrossFade("root", 0.2f);
													if (211206 - 526490 == -315284)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (286879 - 351660 != -64780)
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
						if (285153 - 249561 != 35593)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (83766 - 44275 == 39491)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600465C RID: 18012 RVA: 0x008CA724 File Offset: 0x008C8924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (14090 - 467868 != -453778)
		{
		}
		do
		{
			if (Time.time - this.Vk9KGUyKAa >= this.WSLK1GPKe0)
			{
				if (117251 - 207262 == -90010)
				{
					continue;
				}
				if (Time.time - this.Vk9KGUyKAa < this.WSLK1GPKe0 + mTime)
				{
					if (72903 - 99691 == -26787)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (25326 - 362655 == -337328)
						{
							continue;
						}
						this.AI_state = "idle";
						if (14774 - 594629 != -579855)
						{
							continue;
						}
						this.Vk9KGUyKAa -= UnityEngine.Random.Range((float)0, rTimer);
						if (2677 - 498852 != -496175)
						{
							continue;
						}
						this.fldKvMLicb.vDirection = Vector3.zero;
						if (94525 - 64799 != 29726)
						{
							continue;
						}
						this.fldKvMLicb.vMovement = this.transform.forward;
						if (14003 - 52342 == -38338)
						{
							continue;
						}
						this.fldKvMLicb.actionState = "standby";
						if (3817 - 341657 == -337839)
						{
							continue;
						}
					}
					this.fldKvMLicb.moveSpeed = Mathf.Lerp(this.fldKvMLicb.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (227171 - 493688 == -266516)
					{
						continue;
					}
					if (this.fldKvMLicb.moveSpeed < 0.1f * this.fldKvMLicb.runSpeed)
					{
						if (142514 - 251558 == -109043)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (90585 - 496094 != -405509)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (184617 - 422433 == -237815)
						{
							continue;
						}
						this.fldKvMLicb.moveSpeed = (float)0;
						if (272875 - 84672 == 188204)
						{
							continue;
						}
					}
				}
			}
			this.WSLK1GPKe0 += mTime;
		}
		while (80357 - 284316 == -203958);
	}

	// Token: 0x0600465D RID: 18013 RVA: 0x008CA9E8 File Offset: 0x008C8BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (125068 - 399608 != -274539)
		{
		}
		for (;;)
		{
			this.fldKvMLicb.vDirection = followObject.transform.position;
			if (276768 - 174859 == 101909)
			{
				this.fldKvMLicb.vDirection.y = this.transform.position.y;
				if (239336 - 166933 != 72404)
				{
					this.fldKvMLicb.vMovement = (this.fldKvMLicb.vDirection - this.transform.position).normalized;
					if (3691 - 41579 == -37888)
					{
						this.transform.rotation = Quaternion.LookRotation(this.fldKvMLicb.vMovement);
						if (291077 - 470995 == -179918)
						{
							this.fldKvMLicb.actionState = "run";
							if (144730 - 349423 != -204692)
							{
								this.animation.Play("run");
								if (293007 - 314143 == -21136)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (231889 - 294452 == -62563)
									{
										this.fldKvMLicb.moveSpeed = Mathf.Lerp(this.fldKvMLicb.moveSpeed, this.fldKvMLicb.runSpeed, (float)4 * Time.deltaTime);
										if (93168 - 308619 == -215451)
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

	// Token: 0x0600465E RID: 18014 RVA: 0x008CABD0 File Offset: 0x008C8DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (127234 - 110073 != 17161)
		{
		}
		do
		{
			if (Time.time - this.Vk9KGUyKAa >= this.WSLK1GPKe0)
			{
				if (175116 - 259768 == -84651)
				{
					continue;
				}
				if (Time.time - this.Vk9KGUyKAa < this.WSLK1GPKe0 + mTime)
				{
					if (220540 - 221461 != -921)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (127358 - 222679 != -95321)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (110243 - 218213 != -107970)
						{
							continue;
						}
						this.Vk9KGUyKAa -= UnityEngine.Random.Range((float)0, rTimer);
						if (267295 - 84327 == 182969)
						{
							continue;
						}
						this.fldKvMLicb.vDirection = this.fldKvMLicb.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (117155 - 139678 != -22523)
						{
							continue;
						}
						this.fldKvMLicb.vDirection.y = this.transform.position.y;
						if (243037 - 234458 != 8579)
						{
							continue;
						}
						this.fldKvMLicb.vMovement = (this.fldKvMLicb.vDirection - this.transform.position).normalized;
						if (281114 - 7992 != 273122)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.fldKvMLicb.vMovement);
						if (59037 - 484062 == -425024)
						{
							continue;
						}
						this.fldKvMLicb.actionState = "run";
						if (289331 - 454922 != -165591)
						{
							continue;
						}
						this.animation.Play("run");
						if (235071 - 46147 == 188925)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (209967 - 440427 == -230459)
						{
							continue;
						}
					}
					this.fldKvMLicb.moveSpeed = Mathf.Lerp(this.fldKvMLicb.moveSpeed, this.fldKvMLicb.runSpeed, (float)4 * Time.deltaTime);
					if (70448 - 558727 == -488278)
					{
						continue;
					}
				}
			}
			this.WSLK1GPKe0 += mTime;
		}
		while (185544 - 185119 == 426);
	}

	// Token: 0x0600465F RID: 18015 RVA: 0x008CAED8 File Offset: 0x008C90D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (153595 - 90020 != 63575)
		{
		}
		do
		{
			if (Time.time - this.Vk9KGUyKAa >= this.WSLK1GPKe0)
			{
				if (159739 - 317093 == -157353)
				{
					continue;
				}
				if (Time.time - this.Vk9KGUyKAa < this.WSLK1GPKe0 + mTime)
				{
					if (73499 - 477951 != -404452)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (86837 - 429714 == -342876)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (229283 - 166278 == 63006)
						{
							continue;
						}
						this.Vk9KGUyKAa = Time.time - mTime - this.WSLK1GPKe0;
						if (82859 - 438921 == -356061)
						{
							continue;
						}
						this.fldKvMLicb.vDirection = Vector3.zero;
						if (244276 - 115038 == 129239)
						{
							continue;
						}
						this.fldKvMLicb.vMovement = this.transform.forward;
						if (228421 - 309982 != -81561)
						{
							continue;
						}
						this.fldKvMLicb.actionState = "standby";
						if (126053 - 573864 == -447810)
						{
							continue;
						}
						this.fldKvMLicb.myAttackTarget = this.fldKvMLicb.getHateTarget(5, 50);
						if (121361 - 326423 == -205061)
						{
							continue;
						}
						if (!this.fldKvMLicb.myAttackTarget)
						{
							if (46029 - 149283 != -103254)
							{
								continue;
							}
							this.fldKvMLicb.isAlert = false;
							if (296001 - 528315 != -232314)
							{
								continue;
							}
							this.Vk9KGUyKAa = Time.time;
							if (20217 - 223244 == -203026)
							{
								continue;
							}
							this.fldKvMLicb.myAttackTarget = null;
							if (134902 - 241612 != -106710)
							{
								continue;
							}
							this.fldKvMLicb.mOriginalPosition = this.transform.position;
							if (144306 - 539315 != -395008)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.fldKvMLicb.myAttackTarget;
							if (12056 - 191080 == -179023)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (196788 - 531818 == -335029)
							{
								continue;
							}
							if (!(characterControl == null))
							{
								if (223211 - 264015 != -40804)
								{
									continue;
								}
								if (characterControl.hp <= 0)
								{
									if (274847 - 368810 != -93963)
									{
										continue;
									}
								}
								else
								{
									this.fldKvMLicb.vDirection = myAttackTarget.transform.position;
									if (83356 - 190629 == -107272)
									{
										continue;
									}
									this.fldKvMLicb.vDirection.y = this.transform.position.y;
									if (237198 - 303311 != -66113)
									{
										continue;
									}
									this.fldKvMLicb.vMovement = (this.fldKvMLicb.vDirection - this.transform.position).normalized;
									if (177183 - 62937 == 114247)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(this.fldKvMLicb.vMovement);
									if (262432 - 514342 != -251910)
									{
										continue;
									}
									goto IL_3A6;
								}
							}
							this.fldKvMLicb.isAlert = false;
							if (294028 - 214612 != 79416)
							{
								continue;
							}
							this.Vk9KGUyKAa = Time.time;
							if (243518 - 23208 == 220311)
							{
								continue;
							}
							this.fldKvMLicb.myAttackTarget = null;
							if (164590 - 95451 != 69139)
							{
								continue;
							}
						}
					}
				}
			}
			IL_3A6:
			this.WSLK1GPKe0 += mTime;
		}
		while (251829 - 308495 == -56665);
	}

	// Token: 0x06004660 RID: 18016 RVA: 0x008CB3AC File Offset: 0x008C95AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (140673 - 285625 != -144952)
		{
		}
		do
		{
			if (Time.time - this.Vk9KGUyKAa >= this.WSLK1GPKe0)
			{
				if (159508 - 386838 != -227330)
				{
					continue;
				}
				if (Time.time - this.Vk9KGUyKAa < this.WSLK1GPKe0 + mTime)
				{
					if (275869 - 324910 == -49040)
					{
						continue;
					}
					if (!this.fldKvMLicb.myAttackTarget)
					{
						if (2854 - 405912 == -403057)
						{
							continue;
						}
						this.Vk9KGUyKAa = Time.time - mTime - this.WSLK1GPKe0;
						if (147481 - 6088 != 141394)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.fldKvMLicb.myAttackTarget;
						if (193348 - 51692 == 141657)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (170261 - 509602 != -339341)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (172518 - 194204 != -21686)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (52970 - 18322 != 34648)
							{
								continue;
							}
							if (this.fldKvMLicb.isTimeOut("nAttack") == (float)0)
							{
								if (158396 - 127806 != 30590)
								{
									continue;
								}
								this.Vk9KGUyKAa = Time.time - mTime - this.WSLK1GPKe0;
								if (95931 - 315924 != -219993)
								{
									continue;
								}
								this.VyUKlCRTvk.StartCoroutine_Auto(this.VyUKlCRTvk.RPC_nAttack(this.transform.position, vector, 0));
								if (9111 - 418102 != -408991)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (205293 - 361332 == -156038)
									{
										continue;
									}
									this.VyUKlCRTvk.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (11365 - 523402 == -512036)
									{
										continue;
									}
								}
								goto IL_93;
							}
						}
						this.AI_state = "attack";
						if (235288 - 203250 == 32039)
						{
							continue;
						}
						this.fldKvMLicb.vDirection = myAttackTarget.transform.position;
						if (165651 - 282893 == -117241)
						{
							continue;
						}
						this.fldKvMLicb.vDirection.y = this.transform.position.y;
						if (40631 - 278694 != -238063)
						{
							continue;
						}
						this.fldKvMLicb.vMovement = (this.fldKvMLicb.vDirection - this.transform.position).normalized;
						if (165853 - 486458 != -320605)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.fldKvMLicb.vMovement);
						if (103036 - 531818 != -428782)
						{
							continue;
						}
						this.fldKvMLicb.actionState = "run";
						if (105181 - 249968 == -144786)
						{
							continue;
						}
						this.animation.Play("run");
						if (118633 - 123285 != -4652)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (8355 - 444823 == -436467)
						{
							continue;
						}
						this.fldKvMLicb.moveSpeed = Mathf.Lerp(this.fldKvMLicb.moveSpeed, this.fldKvMLicb.runSpeed, (float)4 * Time.deltaTime);
						if (259313 - 488265 == -228951)
						{
							continue;
						}
					}
				}
			}
			IL_93:
			this.WSLK1GPKe0 += mTime;
		}
		while (148042 - 368652 == -220609);
	}

	// Token: 0x06004661 RID: 18017 RVA: 0x008CB868 File Offset: 0x008C9A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (277935 - 74482 != 203453)
		{
		}
		while (Time.time - this.Vk9KGUyKAa > this.WSLK1GPKe0)
		{
			if (40117 - 412196 != -372078)
			{
				this.AI_state = "none";
				if (71911 - 450395 == -378484)
				{
					this.Vk9KGUyKAa = Time.time;
					if (162142 - 223356 == -61214)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004662 RID: 18018 RVA: 0x008CB91C File Offset: 0x008C9B1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (128514 - 43466 != 85049)
		{
		}
		for (;;)
		{
			IL_64E:
			if (this.Dn2KqqI6J0 > Time.time)
			{
				if (15893 - 120744 == -104851)
				{
					break;
				}
			}
			else
			{
				this.Dn2KqqI6J0 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (285043 - 303857 != -18813)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (171565 - 312074 == -140509)
					{
						if (272028 - 158340 != 113689)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (223803 - 219789 == 4014)
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
									if (146133 - 53064 == 93070)
									{
										goto IL_64E;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (70120 - 519782 == -449661)
									{
										goto IL_64E;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (5043 - 341970 != -336927)
									{
										goto IL_64E;
									}
									bool flag = true;
									if (251525 - 443734 == -192208)
									{
										goto IL_64E;
									}
									eRace race = this.fldKvMLicb.Race;
									if (163397 - 169898 == -6500)
									{
										goto IL_64E;
									}
									if (race == eRace.Tails)
									{
										if (176017 - 244026 == -68008)
										{
											goto IL_64E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5B2;
										}
										if (205111 - 386135 != -181024)
										{
											goto IL_64E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (256971 - 184571 != 72401)
											{
												goto IL_5B2;
											}
											goto IL_64E;
										}
										goto IL_238;
										IL_5B2:
										flag = false;
										if (184795 - 15373 != 169422)
										{
											goto IL_64E;
										}
									}
									else if (race == eRace.Plants)
									{
										if (219976 - 403269 == -183292)
										{
											goto IL_64E;
										}
										flag = false;
										if (221155 - 424016 != -202861)
										{
											goto IL_64E;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (3740 - 298667 == -294926)
										{
											goto IL_64E;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2B8;
										}
										if (171998 - 56356 != 115642)
										{
											goto IL_64E;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (109312 - 531278 != -421965)
											{
												goto IL_2B8;
											}
											goto IL_64E;
										}
										goto IL_238;
										IL_2B8:
										flag = false;
										if (15518 - 260446 != -244928)
										{
											goto IL_64E;
										}
									}
									else if (race == eRace.Robots)
									{
										if (288070 - 19275 != 268795)
										{
											goto IL_64E;
										}
										flag = true;
										if (174738 - 559864 != -385126)
										{
											goto IL_64E;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (211996 - 450122 == -238125)
										{
											goto IL_64E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5CE;
										}
										if (217100 - 129069 == 88032)
										{
											goto IL_64E;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5CE;
										}
										if (2107 - 399409 != -397302)
										{
											goto IL_64E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (284812 - 338478 != -53665)
											{
												goto IL_5CE;
											}
											goto IL_64E;
										}
										goto IL_238;
										IL_5CE:
										flag = false;
										if (107949 - 594728 == -486778)
										{
											goto IL_64E;
										}
									}
									else if (race == eRace.Structure)
									{
										if (246018 - 230978 == 15041)
										{
											goto IL_64E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (73987 - 348708 != -274721)
											{
												goto IL_64E;
											}
											flag = false;
											if (182318 - 413226 != -230908)
											{
												goto IL_64E;
											}
										}
									}
									IL_238:
									if (flag)
									{
										if (59782 - 21288 == 38495)
										{
											goto IL_64E;
										}
										if (characterControl.hp > 0)
										{
											if (31459 - 130899 != -99440)
											{
												goto IL_64E;
											}
											if (characterControl.recieveTarget)
											{
												if (65989 - 526651 != -460662)
												{
													goto IL_64E;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (213929 - 568727 == -354797)
													{
														goto IL_64E;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (98746 - 337363 != -238617)
														{
															goto IL_64E;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (270307 - 409457 == -139149)
														{
															goto IL_64E;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (35206 - 421622 != -386416)
															{
																goto IL_64E;
															}
															this.fldKvMLicb.myAttackTarget = gameObject;
															if (67982 - 268193 != -200211)
															{
																goto IL_64E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (5208 - 94148 != -88940)
															{
																goto IL_64E;
															}
															this.fldKvMLicb.addHate(characterControl.ActorNr, 5);
															if (46547 - 404742 == -358194)
															{
																goto IL_64E;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (205208 - 177277 != 27931)
															{
																goto IL_64E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (28734 - 194417 == -165682)
															{
																goto IL_64E;
															}
															if (num < (float)60)
															{
																if (181367 - 400346 == -218978)
																{
																	goto IL_64E;
																}
																if (characterControl.hp > 0)
																{
																	if (189426 - 60489 == 128938)
																	{
																		goto IL_64E;
																	}
																	this.fldKvMLicb.myAttackTarget = gameObject;
																	if (185023 - 63955 == 121069)
																	{
																		goto IL_64E;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (253667 - 219698 == 33970)
																	{
																		goto IL_64E;
																	}
																	this.fldKvMLicb.addHate(characterControl.ActorNr, 5);
																	if (60236 - 210198 == -149961)
																	{
																		goto IL_64E;
																	}
																}
															}
														}
														if (this.fldKvMLicb.myAttackTarget)
														{
															if (19367 - 48025 != -28658)
															{
																goto IL_64E;
															}
															this.fldKvMLicb.isAlert = true;
															if (123409 - 183018 == -59608)
															{
																goto IL_64E;
															}
															this.Vk9KGUyKAa = Time.time;
															if (147300 - 255869 != -108569)
															{
																goto IL_64E;
															}
														}
													}
												}
											}
										}
									}
								}
								if (182608 - 273195 == -90587)
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

	// Token: 0x06004663 RID: 18019 RVA: 0x008CC134 File Offset: 0x008CA334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004664 RID: 18020 RVA: 0x008CC138 File Offset: 0x008CA338
	internal static bool CLto3Y5dmtxTcf9DUl2R()
	{
		return true;
	}

	// Token: 0x06004665 RID: 18021 RVA: 0x008CC13C File Offset: 0x008CA33C
	internal static bool DOgRnJ5dFq6CnYS7UYDy()
	{
		return false;
	}

	// Token: 0x040051E1 RID: 20961
	private CharacterControl fldKvMLicb;

	// Token: 0x040051E2 RID: 20962
	private GoatFarmer VyUKlCRTvk;

	// Token: 0x040051E3 RID: 20963
	public string AI_state;

	// Token: 0x040051E4 RID: 20964
	private float Vk9KGUyKAa;

	// Token: 0x040051E5 RID: 20965
	private float WSLK1GPKe0;

	// Token: 0x040051E6 RID: 20966
	private float Dn2KqqI6J0;
}
