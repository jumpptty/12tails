using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003A1 RID: 929
[Serializable]
public class ShadowCat_AI : MonoBehaviour
{
	// Token: 0x06001560 RID: 5472 RVA: 0x0022028C File Offset: 0x0021E48C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowCat_AI()
	{
		if (144391 - 552700 != -408308)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (104845 - 351725 != -246879)
			{
				base..ctor();
				if (118283 - 308105 == -189822)
				{
					this.AI_state = "none";
					if (220950 - 385453 == -164503)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001561 RID: 5473 RVA: 0x00220328 File Offset: 0x0021E528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ysBXqb4RlA = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.nVrXp39L06 = (Cat)this.GetComponent(typeof(Cat));
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x00220360 File Offset: 0x0021E560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (185865 - 8904 != 176961)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (271866 - 377604 != -105738)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (165203 - 358746 != -193543)
				{
					continue;
				}
			}
			if (this.ysBXqb4RlA.isControlled)
			{
				break;
			}
			if (122787 - 110952 == 11835)
			{
				this.AIControl();
				if (113989 - 121442 != -7452)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x0022042C File Offset: 0x0021E62C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.k4mXxAJXYb = nSummoner;
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x00220438 File Offset: 0x0021E638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (108698 - 588018 != -479319)
		{
		}
		for (;;)
		{
			this.TIOXrASudt = (float)0;
			if (183471 - 481853 == -298382)
			{
				if (this.ysBXqb4RlA.isMine)
				{
					if (19003 - 31909 != -12905)
					{
						if (this.ysBXqb4RlA.actionState != "standby")
						{
							if (25416 - 447866 == -422449)
							{
								continue;
							}
							if (this.ysBXqb4RlA.actionState != "run")
							{
								if (113874 - 580716 != -466841)
								{
									break;
								}
								continue;
							}
						}
						if (this.k4mXxAJXYb)
						{
							if (9807 - 20303 == -10496)
							{
								if (!this.ysBXqb4RlA.isAlert)
								{
									if (257871 - 75309 == 182562)
									{
										Vector3 vector = this.k4mXxAJXYb.transform.position - this.transform.position;
										if (20791 - 400364 != -379572)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (178660 - 281627 != -102967)
												{
													continue;
												}
												this.AI_follow(this.k4mXxAJXYb);
												if (24421 - 103033 == -78611)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (267292 - 164673 == 102620)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (58969 - 226840 != -167871)
												{
													continue;
												}
												this.AI_resetTimer();
												if (161536 - 126078 == 35459)
												{
													continue;
												}
												this.AI_visionCheck();
												if (235502 - 301305 == -65802)
												{
													continue;
												}
											}
											if (!this.ysBXqb4RlA.myAttackTarget)
											{
												break;
											}
											if (267440 - 371497 == -104057)
											{
												this.ysBXqb4RlA.isAlert = true;
												if (177694 - 472694 != -294999)
												{
													this.AosXRXkm9n = Time.time;
													if (3067 - 313243 != -310175)
													{
														break;
													}
												}
											}
										}
									}
								}
								else
								{
									Vector3 vector2 = this.k4mXxAJXYb.transform.position - this.transform.position;
									if (21412 - 527437 != -506024)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (8056 - 131919 != -123862)
											{
												this.ysBXqb4RlA.isAlert = false;
												if (31663 - 532996 == -501333)
												{
													this.AI_resetTimer();
													if (129928 - 193260 == -63332)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (289263 - 225979 == 63284)
											{
												this.AI_patrol(3f, 1f);
												if (248531 - 353872 == -105341)
												{
													this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
													if (282655 - 314613 == -31958)
													{
														this.AI_resetTimer();
														if (149994 - 60564 == 89430)
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
						else if (!this.ysBXqb4RlA.isAlert)
						{
							if (189326 - 96584 != 92743)
							{
								this.AI_idle(3f, 1f);
								if (292000 - 109792 == 182208)
								{
									this.AI_patrol(1f, 0.25f);
									if (205836 - 118641 == 87195)
									{
										this.AI_resetTimer();
										if (192384 - 91627 == 100757)
										{
											this.AI_visionCheck();
											if (42237 - 509574 == -467337)
											{
												if (!this.ysBXqb4RlA.myAttackTarget)
												{
													break;
												}
												if (287054 - 314493 != -27438)
												{
													this.ysBXqb4RlA.isAlert = true;
													if (234223 - 403697 != -169473)
													{
														this.AosXRXkm9n = Time.time;
														if (181490 - 400022 != -218531)
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
							if (2165 - 230170 == -228005)
							{
								this.AI_patrol(3f, 1f);
								if (269399 - 80383 == 189016)
								{
									this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
									if (297737 - 3796 == 293941)
									{
										this.AI_resetTimer();
										if (190090 - 489231 != -299140)
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
					if (this.ysBXqb4RlA.actionState != "standby")
					{
						if (178581 - 348522 == -169940)
						{
							continue;
						}
						if (this.ysBXqb4RlA.actionState != "run")
						{
							if (28551 - 371641 != -343090)
							{
								continue;
							}
							break;
						}
					}
					float num = this.ysBXqb4RlA.moveSpeed;
					if (88450 - 436534 == -348084)
					{
						float runSpeed = this.ysBXqb4RlA.runSpeed;
						if (243411 - 200547 == 42864)
						{
							Vector3 vector3 = default(Vector3);
							if (245530 - 413717 == -168187)
							{
								Vector3 vector4 = Vector3.zero;
								if (273110 - 71495 != 201616)
								{
									if ((this.ysBXqb4RlA.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (227678 - 161835 != 65843)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.ysBXqb4RlA.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (161923 - 3883 == 158041)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (228905 - 104689 == 124217)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (195851 - 482589 == -286737)
											{
												continue;
											}
											num = (float)0;
											if (188536 - 13679 != 174857)
											{
												continue;
											}
											this.transform.position = this.ysBXqb4RlA.nPosition;
											if (294639 - 169941 != 124698)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (55552 - 420693 != -365141)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (19642 - 5375 != 14267)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (239322 - 460741 == -221418)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (292156 - 569923 != -277767)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (173423 - 74502 != 98921)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (17308 - 272501 != -255193)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (278159 - 475623 == -197463)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (36039 - 49064 != -13025)
											{
												continue;
											}
										}
									}
									this.ysBXqb4RlA.vMovement = vector4;
									if (207273 - 389478 == -182205)
									{
										this.ysBXqb4RlA.moveSpeed = num;
										if (162541 - 452026 == -289485)
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

	// Token: 0x06001565 RID: 5477 RVA: 0x00220E04 File Offset: 0x0021F004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (195627 - 395993 != -200366)
		{
		}
		do
		{
			if (Time.time - this.AosXRXkm9n >= this.TIOXrASudt)
			{
				if (150002 - 216123 == -66120)
				{
					continue;
				}
				if (Time.time - this.AosXRXkm9n < this.TIOXrASudt + mTime)
				{
					if (27738 - 345826 == -318087)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (120871 - 105273 == 15599)
						{
							continue;
						}
						this.AI_state = "idle";
						if (297896 - 445782 != -147886)
						{
							continue;
						}
						this.AosXRXkm9n -= UnityEngine.Random.Range((float)0, rTimer);
						if (197255 - 575414 != -378159)
						{
							continue;
						}
						this.ysBXqb4RlA.vDirection = Vector3.zero;
						if (58120 - 2773 != 55347)
						{
							continue;
						}
						this.ysBXqb4RlA.vMovement = this.transform.forward;
						if (49570 - 524029 != -474459)
						{
							continue;
						}
						this.ysBXqb4RlA.actionState = "standby";
						if (10040 - 160822 != -150782)
						{
							continue;
						}
					}
					this.ysBXqb4RlA.moveSpeed = Mathf.Lerp(this.ysBXqb4RlA.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (253549 - 212836 == 40714)
					{
						continue;
					}
					if (this.ysBXqb4RlA.moveSpeed < 0.1f * this.ysBXqb4RlA.runSpeed)
					{
						if (260020 - 526020 != -266000)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (283628 - 142445 != 141183)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (285826 - 137810 != 148016)
						{
							continue;
						}
						this.ysBXqb4RlA.moveSpeed = (float)0;
						if (241123 - 2787 == 238337)
						{
							continue;
						}
					}
				}
			}
			this.TIOXrASudt += mTime;
		}
		while (29442 - 462433 == -432990);
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x002210C8 File Offset: 0x0021F2C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (210176 - 210278 != -101)
		{
		}
		do
		{
			if (Time.time - this.AosXRXkm9n >= this.TIOXrASudt)
			{
				if (181441 - 539474 == -358032)
				{
					continue;
				}
				if (Time.time - this.AosXRXkm9n < this.TIOXrASudt + mTime)
				{
					if (149917 - 152415 == -2497)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (252412 - 464822 != -212410)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (129256 - 361084 != -231828)
						{
							continue;
						}
						this.AosXRXkm9n -= UnityEngine.Random.Range((float)0, rTimer);
						if (221633 - 415370 != -193737)
						{
							continue;
						}
						this.ysBXqb4RlA.vDirection = this.ysBXqb4RlA.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (244326 - 245589 != -1263)
						{
							continue;
						}
						this.ysBXqb4RlA.vDirection.y = this.transform.position.y;
						if (153792 - 445073 == -291280)
						{
							continue;
						}
						this.ysBXqb4RlA.vMovement = (this.ysBXqb4RlA.vDirection - this.transform.position).normalized;
						if (193816 - 463178 != -269362)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.ysBXqb4RlA.vMovement);
						if (187596 - 64878 == 122719)
						{
							continue;
						}
						this.ysBXqb4RlA.actionState = "run";
						if (120832 - 229454 == -108621)
						{
							continue;
						}
						this.animation.Play("run");
						if (114928 - 536408 == -421479)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (234162 - 114928 != 119234)
						{
							continue;
						}
					}
					this.ysBXqb4RlA.moveSpeed = Mathf.Lerp(this.ysBXqb4RlA.moveSpeed, this.ysBXqb4RlA.runSpeed, (float)4 * Time.deltaTime);
					if (125541 - 78663 == 46879)
					{
						continue;
					}
				}
			}
			this.TIOXrASudt += mTime;
		}
		while (176802 - 573743 == -396940);
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x002213D0 File Offset: 0x0021F5D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (273004 - 101457 != 171547)
		{
		}
		for (;;)
		{
			this.ysBXqb4RlA.vDirection = followObject.transform.position;
			if (64682 - 249491 != -184808)
			{
				this.ysBXqb4RlA.vDirection.y = this.transform.position.y;
				if (245823 - 276899 != -31075)
				{
					this.ysBXqb4RlA.vMovement = (this.ysBXqb4RlA.vDirection - this.transform.position).normalized;
					if (295480 - 25574 == 269906)
					{
						this.transform.rotation = Quaternion.LookRotation(this.ysBXqb4RlA.vMovement);
						if (216742 - 225754 != -9011)
						{
							this.ysBXqb4RlA.actionState = "run";
							if (181050 - 306635 != -125584)
							{
								this.animation.Play("run");
								if (283405 - 342559 != -59153)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (152198 - 465112 == -312914)
									{
										this.ysBXqb4RlA.moveSpeed = Mathf.Lerp(this.ysBXqb4RlA.moveSpeed, this.ysBXqb4RlA.runSpeed, (float)4 * Time.deltaTime);
										if (87978 - 477726 != -389747)
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

	// Token: 0x06001568 RID: 5480 RVA: 0x002215B8 File Offset: 0x0021F7B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (267735 - 587928 != -320192)
		{
		}
		do
		{
			if (Time.time - this.AosXRXkm9n >= this.TIOXrASudt)
			{
				if (84848 - 42633 != 42215)
				{
					continue;
				}
				if (Time.time - this.AosXRXkm9n < this.TIOXrASudt + mTime)
				{
					if (10517 - 286586 == -276068)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (124488 - 411418 != -286930)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (213253 - 19726 != 193527)
						{
							continue;
						}
						this.AosXRXkm9n = Time.time - mTime - this.TIOXrASudt;
						if (20394 - 249706 != -229312)
						{
							continue;
						}
						this.ysBXqb4RlA.vDirection = Vector3.zero;
						if (174032 - 445106 == -271073)
						{
							continue;
						}
						this.ysBXqb4RlA.vMovement = this.transform.forward;
						if (224431 - 85170 != 139261)
						{
							continue;
						}
						this.ysBXqb4RlA.actionState = "standby";
						if (212193 - 48857 != 163336)
						{
							continue;
						}
						this.ysBXqb4RlA.myAttackTarget = this.ysBXqb4RlA.getHateTarget(5, 50);
						if (237478 - 557078 != -319600)
						{
							continue;
						}
						if (!this.ysBXqb4RlA.myAttackTarget)
						{
							if (11084 - 556144 == -545059)
							{
								continue;
							}
							this.ysBXqb4RlA.isAlert = false;
							if (161131 - 107788 == 53344)
							{
								continue;
							}
							this.AosXRXkm9n = Time.time;
							if (37063 - 244098 != -207035)
							{
								continue;
							}
							this.ysBXqb4RlA.myAttackTarget = null;
							if (228344 - 509597 != -281253)
							{
								continue;
							}
							this.ysBXqb4RlA.mOriginalPosition = this.transform.position;
							if (155629 - 346233 != -190604)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.ysBXqb4RlA.myAttackTarget;
							if (167022 - 238261 == -71238)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (241938 - 274239 == -32300)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (63549 - 207622 == -144072)
								{
									continue;
								}
								this.ysBXqb4RlA.isAlert = false;
								if (122196 - 323576 == -201379)
								{
									continue;
								}
								this.AosXRXkm9n = Time.time;
								if (41543 - 288417 == -246873)
								{
									continue;
								}
								this.ysBXqb4RlA.myAttackTarget = null;
								if (44734 - 371767 != -327033)
								{
									continue;
								}
							}
							else
							{
								this.ysBXqb4RlA.vDirection = myAttackTarget.transform.position;
								if (207935 - 574319 != -366384)
								{
									continue;
								}
								this.ysBXqb4RlA.vDirection.y = this.transform.position.y;
								if (5838 - 125001 != -119163)
								{
									continue;
								}
								this.ysBXqb4RlA.vMovement = (this.ysBXqb4RlA.vDirection - this.transform.position).normalized;
								if (114804 - 446724 != -331920)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ysBXqb4RlA.vMovement);
								if (228278 - 57909 == 170370)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.TIOXrASudt += mTime;
		}
		while (42383 - 312458 == -270074);
	}

	// Token: 0x06001569 RID: 5481 RVA: 0x00221A68 File Offset: 0x0021FC68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new ShadowCat_AI.$AI_attack$18932(mTime, this).GetEnumerator();
	}

	// Token: 0x0600156A RID: 5482 RVA: 0x00221A78 File Offset: 0x0021FC78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (9071 - 469238 != -460167)
		{
		}
		while (Time.time - this.AosXRXkm9n > this.TIOXrASudt)
		{
			if (225009 - 99000 == 126009)
			{
				this.AI_state = "none";
				if (187867 - 264544 != -76676)
				{
					this.AosXRXkm9n = Time.time;
					if (42573 - 11023 == 31550)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600156B RID: 5483 RVA: 0x00221B2C File Offset: 0x0021FD2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (160235 - 286646 != -126410)
		{
		}
		for (;;)
		{
			IL_1FA:
			if (this.RUpXTBWIor + (float)1 > Time.time)
			{
				if (278213 - 313366 != -35152)
				{
					break;
				}
			}
			else
			{
				this.RUpXTBWIor = Time.time;
				if (279529 - 165862 == 113667)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (235559 - 242246 != -6686 && 209164 - 254283 != -45118)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (240544 - 363015 == -122471)
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
								if (165953 - 218836 == -52882)
								{
									goto IL_1FA;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (207991 - 499580 != -291589)
								{
									goto IL_1FA;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (71551 - 261490 == -189938)
								{
									goto IL_1FA;
								}
								bool flag = true;
								if (124070 - 78295 != 45775)
								{
									goto IL_1FA;
								}
								eRace race = this.ysBXqb4RlA.Race;
								if (108807 - 472185 != -363378)
								{
									goto IL_1FA;
								}
								if (race == eRace.Tails)
								{
									if (23246 - 311194 != -287948)
									{
										goto IL_1FA;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_5B;
									}
									if (195831 - 9424 != 186407)
									{
										goto IL_1FA;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (192115 - 537807 != -345692)
										{
											goto IL_1FA;
										}
										goto IL_5B;
									}
									goto IL_553;
									IL_5B:
									flag = false;
									if (44820 - 12713 != 32107)
									{
										goto IL_1FA;
									}
								}
								else if (race == eRace.Plants)
								{
									if (68514 - 535484 == -466969)
									{
										goto IL_1FA;
									}
									flag = false;
									if (49927 - 396252 != -346325)
									{
										goto IL_1FA;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (173549 - 246421 != -72872)
									{
										goto IL_1FA;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_1A;
									}
									if (160092 - 523590 == -363497)
									{
										goto IL_1FA;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (2376 - 253842 != -251466)
										{
											goto IL_1FA;
										}
										goto IL_1A;
									}
									goto IL_553;
									IL_1A:
									flag = false;
									if (185199 - 385628 != -200429)
									{
										goto IL_1FA;
									}
								}
								else if (race == eRace.Robots)
								{
									if (135958 - 377628 != -241670)
									{
										goto IL_1FA;
									}
									flag = true;
									if (242646 - 357719 == -115072)
									{
										goto IL_1FA;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (228005 - 289699 != -61694)
									{
										goto IL_1FA;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_4CA;
									}
									if (240077 - 328114 != -88037)
									{
										goto IL_1FA;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_4CA;
									}
									if (277451 - 479881 == -202429)
									{
										goto IL_1FA;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (63641 - 473988 != -410347)
										{
											goto IL_1FA;
										}
										goto IL_4CA;
									}
									goto IL_553;
									IL_4CA:
									flag = false;
									if (44992 - 241728 != -196736)
									{
										goto IL_1FA;
									}
								}
								else if (race == eRace.Structure)
								{
									if (29630 - 62934 == -33303)
									{
										goto IL_1FA;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (238311 - 347414 == -109102)
										{
											goto IL_1FA;
										}
										flag = false;
										if (69668 - 110888 == -41219)
										{
											goto IL_1FA;
										}
									}
								}
								IL_553:
								if (flag)
								{
									if (280371 - 183682 == 96690)
									{
										goto IL_1FA;
									}
									if (characterControl.hp > 0)
									{
										if (161529 - 242046 != -80517)
										{
											goto IL_1FA;
										}
										if (characterControl.recieveTarget)
										{
											if (74568 - 9141 != 65427)
											{
												goto IL_1FA;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (203406 - 366256 == -162849)
												{
													goto IL_1FA;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (69443 - 3839 != 65604)
													{
														goto IL_1FA;
													}
													this.ysBXqb4RlA.isAlert = true;
													if (262333 - 574815 != -312482)
													{
														goto IL_1FA;
													}
													this.AosXRXkm9n = Time.time;
													if (96506 - 187839 != -91333)
													{
														goto IL_1FA;
													}
													this.ysBXqb4RlA.myAttackTarget = gameObject;
													if (52319 - 408617 != -356298)
													{
														goto IL_1FA;
													}
													UnityRuntimeServices.Update(enumerator, gameObject);
													if (270287 - 529062 != -258775)
													{
														goto IL_1FA;
													}
													this.ysBXqb4RlA.addHate(characterControl.ActorNr, 5);
													if (187434 - 191106 != -3672)
													{
														goto IL_1FA;
													}
												}
											}
										}
									}
								}
							}
							if (256276 - 470390 != -214113)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600156C RID: 5484 RVA: 0x0022217C File Offset: 0x0022037C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x00222180 File Offset: 0x00220380
	internal static bool XbBL2Qm1uxe3vMbdnNF()
	{
		return true;
	}

	// Token: 0x0600156E RID: 5486 RVA: 0x00222184 File Offset: 0x00220384
	internal static bool WZXbNhm44VZr7chtnSh()
	{
		return false;
	}

	// Token: 0x04001280 RID: 4736
	private CharacterControl ysBXqb4RlA;

	// Token: 0x04001281 RID: 4737
	private Cat nVrXp39L06;

	// Token: 0x04001282 RID: 4738
	public string AI_state;

	// Token: 0x04001283 RID: 4739
	private float AosXRXkm9n;

	// Token: 0x04001284 RID: 4740
	private float TIOXrASudt;

	// Token: 0x04001285 RID: 4741
	private GameObject k4mXxAJXYb;

	// Token: 0x04001286 RID: 4742
	private float RUpXTBWIor;

	// Token: 0x020003A2 RID: 930
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$18932 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600156F RID: 5487 RVA: 0x00222188 File Offset: 0x00220388
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$18932(float mTime, ShadowCat_AI self_)
		{
			if (255346 - 362782 != -107435)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193367 - 204380 == -11013)
				{
					base..ctor();
					if (1739 - 397593 == -395854)
					{
						this.$mTime$18940 = mTime;
						if (294208 - 88573 != 205636)
						{
							this.$self_$18941 = self_;
							if (249736 - 208182 == 41554)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00222244 File Offset: 0x00220444
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowCat_AI.$AI_attack$18932.$(this.$mTime$18940, this.$self_$18941);
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00222258 File Offset: 0x00220458
		internal static bool V5e7E3mz2Kn07ArsVi2()
		{
			return true;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0022225C File Offset: 0x0022045C
		internal static bool t9CX0EFa7pABPe4QqAG()
		{
			return false;
		}

		// Token: 0x04001287 RID: 4743
		internal float $mTime$18940;

		// Token: 0x04001288 RID: 4744
		internal ShadowCat_AI $self_$18941;

		// Token: 0x020003A3 RID: 931
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001573 RID: 5491 RVA: 0x00222260 File Offset: 0x00220460
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, ShadowCat_AI self_)
			{
				if (19986 - 227022 != -207035)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (87719 - 101831 == -14112)
					{
						base..ctor();
						if (204520 - 115781 == 88739)
						{
							this.$mTime$18938 = mTime;
							if (99219 - 475916 == -376697)
							{
								this.$self_$18939 = self_;
								if (41272 - 80468 == -39196)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001574 RID: 5492 RVA: 0x0022231C File Offset: 0x0022051C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224977 - 432014 != -207037)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2257;
					case 2:
						if (!this.$tObject$18933)
						{
							goto IL_17E6;
						}
						if (252845 - 457559 != -204714)
						{
							continue;
						}
						if (this.$self_$18939.ysBXqb4RlA.actionState != "attack")
						{
							goto IL_17E6;
						}
						if (186829 - 222004 == -35174)
						{
							continue;
						}
						if (this.$self_$18939.ysBXqb4RlA.myCommand != "nAttack1")
						{
							if (204880 - 219856 != -14975)
							{
								goto Block_72;
							}
							continue;
						}
						else
						{
							this.$tDir$18935 = global::Math.vFlat(this.$tObject$18933.transform.position - this.$self_$18939.transform.position);
							if (228358 - 477486 != -249128)
							{
								continue;
							}
							if (this.$tDir$18935.magnitude > (float)2)
							{
								if (46400 - 19606 != 26794)
								{
									continue;
								}
								goto IL_E1;
							}
							else
							{
								this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_nAttack2(this.$self_$18939.transform.position, this.$tDir$18935.normalized, 0));
								if (285628 - 55460 == 230169)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_3EC;
								}
								if (157958 - 351890 != -193932)
								{
									continue;
								}
								this.$self_$18939.nVrXp39L06.ActionEvent("RPC_nAttack2", this.$self_$18939.transform.position, this.$tDir$18935.normalized, 0);
								if (299192 - 105688 != 193504)
								{
									continue;
								}
								goto IL_3EC;
							}
						}
						break;
					case 3:
						if (!this.$tObject$18933)
						{
							goto IL_9A3;
						}
						if (36281 - 365817 != -329536)
						{
							continue;
						}
						if (this.$self_$18939.ysBXqb4RlA.actionState != "attack")
						{
							goto IL_9A3;
						}
						if (83022 - 578062 == -495039)
						{
							continue;
						}
						if (this.$self_$18939.ysBXqb4RlA.myCommand != "nAttack2")
						{
							if (32592 - 370693 != -338101)
							{
								continue;
							}
							goto IL_9A3;
						}
						else
						{
							this.$tDir$18935 = global::Math.vFlat(this.$tObject$18933.transform.position - this.$self_$18939.transform.position);
							if (39161 - 159749 == -120587)
							{
								continue;
							}
							if (this.$tDir$18935.magnitude > (float)2)
							{
								if (60171 - 161399 != -101228)
								{
									continue;
								}
								goto IL_1AD2;
							}
							else
							{
								this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_nAttack3(this.$self_$18939.transform.position, this.$tDir$18935.normalized, 0));
								if (241584 - 133282 == 108303)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_EF4;
								}
								if (114454 - 359296 != -244842)
								{
									continue;
								}
								this.$self_$18939.nVrXp39L06.ActionEvent("RPC_nAttack3", this.$self_$18939.transform.position, this.$tDir$18935.normalized, 0);
								if (177857 - 378903 != -201045)
								{
									goto Block_57;
								}
								continue;
							}
						}
						break;
					case 4:
						if (!this.$tObject$18933)
						{
							goto IL_6E;
						}
						if (133406 - 480545 == -347138)
						{
							continue;
						}
						if (this.$self_$18939.ysBXqb4RlA.actionState != "attack")
						{
							goto IL_6E;
						}
						if (68103 - 569521 == -501417)
						{
							continue;
						}
						if (this.$self_$18939.ysBXqb4RlA.myCommand != "nAttack3")
						{
							if (235555 - 71714 != 163842)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$tDir$18935 = global::Math.vFlat(this.$tObject$18933.transform.position - this.$self_$18939.transform.position);
							if (66884 - 595664 == -528779)
							{
								continue;
							}
							if (this.$tDir$18935.magnitude > (float)2)
							{
								if (28618 - 435248 != -406629)
								{
									goto Block_169;
								}
								continue;
							}
							else
							{
								this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_nAttack4(this.$self_$18939.transform.position, this.$tDir$18935.normalized, 0));
								if (294651 - 443922 != -149270)
								{
									if (PhotonClient.IsInitialized())
									{
										if (222780 - 133796 != 88984)
										{
											continue;
										}
										this.$self_$18939.nVrXp39L06.ActionEvent("RPC_nAttack4", this.$self_$18939.transform.position, this.$tDir$18935.normalized, 0);
										if (104882 - 146628 != -41746)
										{
											continue;
										}
									}
									goto IL_C85;
								}
								continue;
							}
						}
						break;
					default:
						if (198438 - 486804 == -288365)
						{
							continue;
						}
						break;
					}
					if (Time.time - this.$self_$18939.AosXRXkm9n >= this.$self_$18939.TIOXrASudt)
					{
						if (196030 - 381503 != -185473)
						{
							continue;
						}
						if (Time.time - this.$self_$18939.AosXRXkm9n < this.$self_$18939.TIOXrASudt + this.$mTime$18938)
						{
							if (176107 - 29460 != 146647)
							{
								continue;
							}
							if (!this.$self_$18939.ysBXqb4RlA.myAttackTarget)
							{
								if (103690 - 575926 != -472236)
								{
									continue;
								}
								this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
								if (51493 - 409948 != -358454)
								{
									break;
								}
								continue;
							}
							else
							{
								this.$tObject$18933 = this.$self_$18939.ysBXqb4RlA.myAttackTarget;
								if (141934 - 513400 != -371466)
								{
									continue;
								}
								this.$tChar$18934 = (CharacterControl)this.$tObject$18933.GetComponent(typeof(CharacterControl));
								if (249714 - 217111 == 32604)
								{
									continue;
								}
								this.$tDir$18935 = global::Math.vFlat(this.$tObject$18933.transform.position - this.$self_$18939.transform.position);
								if (160199 - 552951 != -392752)
								{
									continue;
								}
								this.$tID$18936 = 0;
								if (101536 - 298952 != -197416)
								{
									continue;
								}
								if (this.$tChar$18934)
								{
									if (201806 - 518211 != -316405)
									{
										continue;
									}
									this.$tID$18936 = this.$tChar$18934.ActorNr;
									if (129006 - 246857 != -117851)
									{
										continue;
									}
								}
								this.$distance$18937 = this.$tDir$18935.magnitude - this.$tObject$18933.collider.bounds.extents.x;
								if (105590 - 362023 == -256432)
								{
									continue;
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 90)
								{
									if (207194 - 147270 == 59925)
									{
										continue;
									}
									if (this.$self_$18939.ysBXqb4RlA.hasSkill(272))
									{
										if (277781 - 111855 == 165927)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.isTimeOut("grandCasinoArcade") == (float)0)
										{
											if (164680 - 116759 != 47921)
											{
												continue;
											}
											this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
											if (236907 - 296725 != -59818)
											{
												continue;
											}
											this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_grandCasinoArcade(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 2));
											if (191637 - 78610 != 113027)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (5746 - 358005 != -352259)
												{
													continue;
												}
												this.$self_$18939.nVrXp39L06.ActionEvent("RPC_grandCasinoArcade2", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
												if (59065 - 30360 != 28705)
												{
													continue;
												}
											}
											goto IL_C85;
										}
									}
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 60)
								{
									if (15764 - 20552 == -4787)
									{
										continue;
									}
									if (this.$distance$18937 < (float)3)
									{
										if (174332 - 17449 != 156883)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.hasSkill(372))
										{
											if (30328 - 354220 == -323891)
											{
												continue;
											}
											if (this.$self_$18939.ysBXqb4RlA.isTimeOut("deltaStrike") == (float)0)
											{
												if (25282 - 17316 == 7967)
												{
													continue;
												}
												this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
												if (130371 - 533167 != -402796)
												{
													continue;
												}
												this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_deltaStrike(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 2));
												if (270054 - 323141 != -53087)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (125653 - 70032 != 55621)
													{
														continue;
													}
													this.$self_$18939.nVrXp39L06.ActionEvent("RPC_deltaStrike2", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
													if (210390 - 42818 == 167573)
													{
														continue;
													}
												}
												goto IL_C85;
											}
										}
									}
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 50)
								{
									if (48802 - 521359 == -472556)
									{
										continue;
									}
									if (this.$distance$18937 < (float)4)
									{
										if (150821 - 300330 != -149509)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.hasSkill(354))
										{
											if (87964 - 204475 != -116511)
											{
												continue;
											}
											if (this.$self_$18939.ysBXqb4RlA.isTimeOut("moonStorm") == (float)0)
											{
												if (114458 - 402915 != -288457)
												{
													continue;
												}
												this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
												if (65184 - 25405 == 39780)
												{
													continue;
												}
												this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_moonStorm(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 2));
												if (144680 - 418058 != -273378)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (143138 - 409627 == -266488)
													{
														continue;
													}
													this.$self_$18939.nVrXp39L06.ActionEvent("RPC_moonStorm2", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
													if (206587 - 533392 != -326805)
													{
														continue;
													}
												}
												goto IL_C85;
											}
										}
									}
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 45)
								{
									if (265651 - 71778 == 193874)
									{
										continue;
									}
									if (this.$distance$18937 < (float)4)
									{
										if (33850 - 286285 == -252434)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.hasSkill(262))
										{
											if (213989 - 442277 == -228287)
											{
												continue;
											}
											if (this.$self_$18939.ysBXqb4RlA.isTimeOut("damageRoulette") == (float)0)
											{
												if (194672 - 468204 != -273532)
												{
													continue;
												}
												this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
												if (66270 - 246724 != -180454)
												{
													continue;
												}
												this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_damageRoulette(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 2));
												if (155037 - 514176 != -359139)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (216109 - 207965 != 8144)
													{
														continue;
													}
													this.$self_$18939.nVrXp39L06.ActionEvent("RPC_damageRoulette2", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
													if (49612 - 519900 != -470288)
													{
														continue;
													}
												}
												goto IL_C85;
											}
										}
									}
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 40)
								{
									if (3815 - 359676 == -355860)
									{
										continue;
									}
									if (this.$distance$18937 < (float)1)
									{
										if (173507 - 362338 != -188831)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.hasSkill(344))
										{
											if (266611 - 29935 != 236676)
											{
												continue;
											}
											if (this.$self_$18939.ysBXqb4RlA.isTimeOut("bleed") == (float)0)
											{
												if (182722 - 246519 == -63796)
												{
													continue;
												}
												this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
												if (85743 - 414927 == -329183)
												{
													continue;
												}
												this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_bleed(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 2));
												if (86933 - 199905 != -112972)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (111022 - 254687 != -143665)
													{
														continue;
													}
													this.$self_$18939.nVrXp39L06.ActionEvent("RPC_bleed2", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
													if (274460 - 218521 == 55940)
													{
														continue;
													}
												}
												goto IL_C85;
											}
										}
									}
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 35)
								{
									if (141281 - 124971 == 16311)
									{
										continue;
									}
									if (this.$distance$18937 < (float)4)
									{
										if (84280 - 161254 != -76974)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.hasSkill(232))
										{
											if (79947 - 210923 != -130976)
											{
												continue;
											}
											if (this.$self_$18939.ysBXqb4RlA.isTimeOut("luckyDice") == (float)0)
											{
												if (150333 - 6547 == 143787)
												{
													continue;
												}
												this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
												if (171933 - 198306 != -26373)
												{
													continue;
												}
												this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_luckyDice(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 2));
												if (188738 - 320450 != -131711)
												{
													if (PhotonClient.IsInitialized())
													{
														if (158773 - 195962 == -37188)
														{
															continue;
														}
														this.$self_$18939.nVrXp39L06.ActionEvent("RPC_luckyDice2", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
														if (74687 - 219833 == -145145)
														{
															continue;
														}
													}
													goto IL_C85;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 30)
								{
									if (233841 - 93008 != 140833)
									{
										continue;
									}
									if (this.$distance$18937 < (float)1)
									{
										if (33258 - 301855 == -268596)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.hasSkill(314))
										{
											if (136089 - 230848 != -94759)
											{
												continue;
											}
											if (this.$self_$18939.ysBXqb4RlA.isTimeOut("reverseThrust") == (float)0)
											{
												if (292593 - 315282 != -22689)
												{
													continue;
												}
												this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
												if (35192 - 320709 == -285516)
												{
													continue;
												}
												this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_reverseThrust(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 2));
												if (51026 - 27003 != 24024)
												{
													if (PhotonClient.IsInitialized())
													{
														if (148166 - 5472 == 142695)
														{
															continue;
														}
														this.$self_$18939.nVrXp39L06.ActionEvent("RPC_reverseThrust2", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
														if (77695 - 151663 == -73967)
														{
															continue;
														}
													}
													goto IL_C85;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 25)
								{
									if (184641 - 433113 != -248472)
									{
										continue;
									}
									if (this.$self_$18939.ysBXqb4RlA.hp < Mathf.FloorToInt(0.6f * (float)this.$self_$18939.ysBXqb4RlA.mhp))
									{
										if (51258 - 477236 == -425977)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.hasSkill(223))
										{
											if (256051 - 68426 == 187626)
											{
												continue;
											}
											if (this.$self_$18939.ysBXqb4RlA.isTimeOut("lifeGamble") == (float)0)
											{
												if (134377 - 192981 == -58603)
												{
													continue;
												}
												this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
												if (97516 - 289488 != -191972)
												{
													continue;
												}
												this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_lifeGamble(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 2));
												if (243215 - 101631 != 141584)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (61902 - 383997 == -322094)
													{
														continue;
													}
													this.$self_$18939.nVrXp39L06.ActionEvent("RPC_lifeGamble2", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
													if (186155 - 144524 == 41632)
													{
														continue;
													}
												}
												goto IL_C85;
											}
										}
									}
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 20)
								{
									if (102792 - 64541 == 38252)
									{
										continue;
									}
									if (this.$distance$18937 < (float)3)
									{
										if (230038 - 97725 == 132314)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.hasSkill(313))
										{
											if (66292 - 359640 == -293347)
											{
												continue;
											}
											if (this.$self_$18939.ysBXqb4RlA.isTimeOut("forwardLunge") == (float)0)
											{
												if (86596 - 596843 == -510246)
												{
													continue;
												}
												this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
												if (242922 - 411001 != -168079)
												{
													continue;
												}
												this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_forwardLunge(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 2));
												if (84438 - 522736 != -438297)
												{
													if (PhotonClient.IsInitialized())
													{
														if (253387 - 596143 != -342756)
														{
															continue;
														}
														this.$self_$18939.nVrXp39L06.ActionEvent("RPC_forwardLunge2", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
														if (255718 - 470943 == -215224)
														{
															continue;
														}
													}
													goto IL_C85;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 15)
								{
									if (298019 - 356004 != -57985)
									{
										continue;
									}
									if (this.$distance$18937 < (float)18)
									{
										if (79298 - 466901 == -387602)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.hasSkill(214))
										{
											if (158647 - 368742 == -210094)
											{
												continue;
											}
											if (this.$self_$18939.ysBXqb4RlA.isTimeOut("fateDraw") == (float)0)
											{
												if (297669 - 263628 != 34041)
												{
													continue;
												}
												this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
												if (240726 - 84617 == 156110)
												{
													continue;
												}
												this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_fateDraw(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 4));
												if (137657 - 537046 != -399389)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (236342 - 3199 == 233144)
													{
														continue;
													}
													this.$self_$18939.nVrXp39L06.ActionEvent("RPC_fateDraw4", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
													if (85124 - 559631 != -474507)
													{
														continue;
													}
												}
												goto IL_C85;
											}
										}
									}
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 10)
								{
									if (20182 - 164675 == -144492)
									{
										continue;
									}
									if (this.$distance$18937 < (float)18)
									{
										if (140807 - 379579 != -238772)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.hasSkill(304))
										{
											if (132634 - 128445 != 4189)
											{
												continue;
											}
											if (this.$self_$18939.ysBXqb4RlA.isTimeOut("flyingDagger") == (float)0)
											{
												if (271465 - 533756 == -262290)
												{
													continue;
												}
												this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
												if (211514 - 226981 != -15467)
												{
													continue;
												}
												this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_flyingDagger(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 4));
												if (295509 - 391148 != -95638)
												{
													if (PhotonClient.IsInitialized())
													{
														if (153186 - 95756 == 57431)
														{
															continue;
														}
														this.$self_$18939.nVrXp39L06.ActionEvent("RPC_flyingDagger4", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
														if (90519 - 37029 != 53490)
														{
															continue;
														}
													}
													goto IL_C85;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18939.ysBXqb4RlA.sp > 5)
								{
									if (84677 - 576881 != -492204)
									{
										continue;
									}
									if (this.$self_$18939.ysBXqb4RlA.hasSkill(204))
									{
										if (47449 - 262625 != -215176)
										{
											continue;
										}
										if (this.$self_$18939.ysBXqb4RlA.isTimeOut("luckyCard") == (float)0)
										{
											if (95363 - 344637 != -249274)
											{
												continue;
											}
											this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
											if (220738 - 547191 != -326453)
											{
												continue;
											}
											this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_luckyCard(this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936, 4));
											if (289467 - 380990 != -91522)
											{
												if (PhotonClient.IsInitialized())
												{
													if (212196 - 212295 != -99)
													{
														continue;
													}
													this.$self_$18939.nVrXp39L06.ActionEvent("RPC_luckyCard4", this.$self_$18939.transform.position, this.$tDir$18935.normalized, this.$tID$18936);
													if (244852 - 593068 != -348216)
													{
														continue;
													}
												}
												goto IL_C85;
											}
											continue;
										}
									}
								}
								if (this.$distance$18937 < (float)2)
								{
									if (136932 - 76341 == 60592)
									{
										continue;
									}
									if (this.$self_$18939.ysBXqb4RlA.isTimeOut("nAttack") == (float)0)
									{
										if (50669 - 350126 != -299457)
										{
											continue;
										}
										this.$self_$18939.AosXRXkm9n = Time.time - this.$mTime$18938 - this.$self_$18939.TIOXrASudt;
										if (15337 - 452751 == -437413)
										{
											continue;
										}
										this.$self_$18939.nVrXp39L06.StartCoroutine_Auto(this.$self_$18939.nVrXp39L06.RPC_nAttack1(this.$self_$18939.transform.position, this.$tDir$18935.normalized, 0));
										if (271351 - 221921 == 49431)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											goto IL_161F;
										}
										if (40925 - 395679 != -354754)
										{
											continue;
										}
										this.$self_$18939.nVrXp39L06.ActionEvent("RPC_nAttack1", this.$self_$18939.transform.position, this.$tDir$18935.normalized, 0);
										if (202400 - 561916 != -359516)
										{
											continue;
										}
										goto IL_161F;
									}
								}
								this.$self_$18939.AI_state = "attack";
								if (210030 - 48917 != 161113)
								{
									continue;
								}
								this.$self_$18939.ysBXqb4RlA.vDirection = this.$tObject$18933.transform.position;
								if (142051 - 13777 == 128275)
								{
									continue;
								}
								this.$self_$18939.ysBXqb4RlA.vDirection.y = this.$self_$18939.transform.position.y;
								if (243023 - 26838 != 216185)
								{
									continue;
								}
								this.$self_$18939.ysBXqb4RlA.vMovement = (this.$self_$18939.ysBXqb4RlA.vDirection - this.$self_$18939.transform.position).normalized;
								if (191928 - 243444 == -51515)
								{
									continue;
								}
								this.$self_$18939.transform.rotation = Quaternion.LookRotation(this.$self_$18939.ysBXqb4RlA.vMovement);
								if (170663 - 21141 != 149522)
								{
									continue;
								}
								this.$self_$18939.ysBXqb4RlA.actionState = "run";
								if (277842 - 270232 != 7610)
								{
									continue;
								}
								this.$self_$18939.animation.Play("run");
								if (196350 - 578194 == -381843)
								{
									continue;
								}
								this.$self_$18939.animation.wrapMode = WrapMode.Loop;
								if (290346 - 139586 != 150760)
								{
									continue;
								}
								this.$self_$18939.ysBXqb4RlA.moveSpeed = Mathf.Lerp(this.$self_$18939.ysBXqb4RlA.moveSpeed, this.$self_$18939.ysBXqb4RlA.runSpeed, (float)4 * Time.deltaTime);
								if (59 - 555781 == -555721)
								{
									continue;
								}
							}
						}
					}
					IL_C85:
					this.$self_$18939.TIOXrASudt = this.$self_$18939.TIOXrASudt + this.$mTime$18938;
					if (68033 - 219165 == -151132)
					{
						this.YieldDefault(1);
						if (168889 - 512640 == -343751)
						{
							break;
						}
					}
				}
				IL_6E:
				goto IL_2257;
				IL_E1:
				Block_18:
				goto IL_6E;
				IL_3EC:
				return this.Yield(3, new WaitForSeconds(0.6f));
				Block_57:
				goto IL_EF4;
				IL_9A3:
				Block_72:
				goto IL_2257;
				IL_EF4:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_161F:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_17E6:
				Block_169:
				IL_1AD2:
				IL_2257:
				return false;
			}

			// Token: 0x06001575 RID: 5493 RVA: 0x00224594 File Offset: 0x00222794
			internal static bool MPf1w3F5PZ6BLJNuk7a()
			{
				return true;
			}

			// Token: 0x06001576 RID: 5494 RVA: 0x00224598 File Offset: 0x00222798
			internal static bool Gl6qDlFpp12cIsFhjgi()
			{
				return false;
			}

			// Token: 0x04001289 RID: 4745
			internal GameObject $tObject$18933;

			// Token: 0x0400128A RID: 4746
			internal CharacterControl $tChar$18934;

			// Token: 0x0400128B RID: 4747
			internal Vector3 $tDir$18935;

			// Token: 0x0400128C RID: 4748
			internal int $tID$18936;

			// Token: 0x0400128D RID: 4749
			internal float $distance$18937;

			// Token: 0x0400128E RID: 4750
			internal float $mTime$18938;

			// Token: 0x0400128F RID: 4751
			internal ShadowCat_AI $self_$18939;
		}
	}
}
