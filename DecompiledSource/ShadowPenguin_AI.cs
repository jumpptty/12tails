using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003B1 RID: 945
[Serializable]
public class ShadowPenguin_AI : MonoBehaviour
{
	// Token: 0x060015D9 RID: 5593 RVA: 0x00234CE0 File Offset: 0x00232EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowPenguin_AI()
	{
		if (17976 - 380597 != -362621)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (97407 - 537865 != -440457)
			{
				base..ctor();
				if (110008 - 584457 != -474448)
				{
					this.AI_state = "none";
					if (92078 - 559197 == -467119)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x00234D7C File Offset: 0x00232F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.SyqXonIwSS = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.UImXkWX7Og = (Penguin)this.GetComponent(typeof(Penguin));
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x00234DB4 File Offset: 0x00232FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (297816 - 417738 != -119922)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (235116 - 76232 == 158885)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (40375 - 537837 == -497461)
				{
					continue;
				}
			}
			if (this.SyqXonIwSS.isControlled)
			{
				break;
			}
			if (1743 - 305937 == -304194)
			{
				this.AIControl();
				if (232376 - 78571 == 153805)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x00234E80 File Offset: 0x00233080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.mqjX9NpZrq = nSummoner;
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x00234E8C File Offset: 0x0023308C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (29693 - 585443 != -555750)
		{
		}
		for (;;)
		{
			this.Xm7XAL8RHa = (float)0;
			if (181574 - 129584 == 51990)
			{
				if (this.SyqXonIwSS.isMine)
				{
					if (244285 - 468116 == -223831)
					{
						if (this.SyqXonIwSS.actionState != "standby")
						{
							if (6496 - 270511 != -264015)
							{
								continue;
							}
							if (this.SyqXonIwSS.actionState != "run")
							{
								if (3927 - 221350 != -217422)
								{
									break;
								}
								continue;
							}
						}
						if (this.mqjX9NpZrq)
						{
							if (207087 - 231228 != -24140)
							{
								if (!this.SyqXonIwSS.isAlert)
								{
									if (148563 - 282624 == -134061)
									{
										Vector3 vector = this.mqjX9NpZrq.transform.position - this.transform.position;
										if (6063 - 174257 != -168193)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (82677 - 77801 != 4876)
												{
													continue;
												}
												this.AI_follow(this.mqjX9NpZrq);
												if (244493 - 599254 != -354761)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (4572 - 451738 == -447165)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (264281 - 497374 == -233092)
												{
													continue;
												}
												this.AI_resetTimer();
												if (202182 - 235214 != -33032)
												{
													continue;
												}
												this.AI_visionCheck();
												if (70091 - 403556 == -333464)
												{
													continue;
												}
											}
											if (!this.SyqXonIwSS.myAttackTarget)
											{
												break;
											}
											if (74382 - 283386 != -209003)
											{
												this.SyqXonIwSS.isAlert = true;
												if (167369 - 281440 == -114071)
												{
													this.WcGXFTcZy7 = Time.time;
													if (30947 - 14091 != 16857)
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
									Vector3 vector2 = this.mqjX9NpZrq.transform.position - this.transform.position;
									if (66227 - 241575 == -175348)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (174548 - 414660 != -240111)
											{
												this.SyqXonIwSS.isAlert = false;
												if (62053 - 126342 != -64288)
												{
													this.AI_resetTimer();
													if (69009 - 340233 == -271224)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (55148 - 35531 == 19617)
											{
												this.AI_patrol(3f, 1f);
												if (70962 - 248206 == -177244)
												{
													this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
													if (88958 - 14301 != 74658)
													{
														this.AI_resetTimer();
														if (120565 - 236456 != -115890)
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
						else if (!this.SyqXonIwSS.isAlert)
						{
							if (143417 - 42745 == 100672)
							{
								this.AI_idle(3f, 1f);
								if (246025 - 439339 != -193313)
								{
									this.AI_patrol(1f, 0.25f);
									if (242515 - 352586 != -110070)
									{
										this.AI_resetTimer();
										if (269848 - 438718 == -168870)
										{
											this.AI_visionCheck();
											if (105414 - 355326 != -249911)
											{
												if (!this.SyqXonIwSS.myAttackTarget)
												{
													break;
												}
												if (263111 - 57628 != 205484)
												{
													this.SyqXonIwSS.isAlert = true;
													if (18278 - 461835 != -443556)
													{
														this.WcGXFTcZy7 = Time.time;
														if (36875 - 507021 != -470145)
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
							if (91848 - 553274 != -461425)
							{
								this.AI_patrol(3f, 1f);
								if (260464 - 347617 == -87153)
								{
									this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
									if (194697 - 229771 == -35074)
									{
										this.AI_resetTimer();
										if (191011 - 85653 != 105359)
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
					if (this.SyqXonIwSS.actionState != "standby")
					{
						if (61954 - 259658 == -197703)
						{
							continue;
						}
						if (this.SyqXonIwSS.actionState != "run")
						{
							if (285026 - 131232 != 153795)
							{
								break;
							}
							continue;
						}
					}
					float num = this.SyqXonIwSS.moveSpeed;
					if (67208 - 32031 != 35178)
					{
						float runSpeed = this.SyqXonIwSS.runSpeed;
						if (252878 - 79138 == 173740)
						{
							Vector3 vector3 = default(Vector3);
							if (33446 - 361950 != -328503)
							{
								Vector3 vector4 = Vector3.zero;
								if (166566 - 468125 == -301559)
								{
									if ((this.SyqXonIwSS.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (47950 - 445574 == -397623)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.SyqXonIwSS.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (213578 - 470471 != -256893)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (136481 - 477192 != -340711)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (155375 - 164854 != -9479)
											{
												continue;
											}
											num = (float)0;
											if (62823 - 5178 == 57646)
											{
												continue;
											}
											this.transform.position = this.SyqXonIwSS.nPosition;
											if (48305 - 593497 != -545192)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (23734 - 597563 == -573828)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (269264 - 577251 != -307987)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (213379 - 291945 != -78566)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (198185 - 425062 != -226877)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (284814 - 402171 == -117356)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (11551 - 409877 != -398326)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (198295 - 288349 != -90054)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (277856 - 574116 != -296260)
											{
												continue;
											}
										}
									}
									this.SyqXonIwSS.vMovement = vector4;
									if (128319 - 205032 == -76713)
									{
										this.SyqXonIwSS.moveSpeed = num;
										if (92643 - 520542 != -427898)
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

	// Token: 0x060015DE RID: 5598 RVA: 0x00235858 File Offset: 0x00233A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (33839 - 542098 != -508258)
		{
		}
		do
		{
			if (Time.time - this.WcGXFTcZy7 >= this.Xm7XAL8RHa)
			{
				if (166808 - 342045 != -175237)
				{
					continue;
				}
				if (Time.time - this.WcGXFTcZy7 < this.Xm7XAL8RHa + mTime)
				{
					if (118713 - 200471 == -81757)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (259036 - 494200 == -235163)
						{
							continue;
						}
						this.AI_state = "idle";
						if (73737 - 433191 != -359454)
						{
							continue;
						}
						this.WcGXFTcZy7 -= UnityEngine.Random.Range((float)0, rTimer);
						if (154781 - 514247 != -359466)
						{
							continue;
						}
						this.SyqXonIwSS.vDirection = Vector3.zero;
						if (127614 - 173640 != -46026)
						{
							continue;
						}
						this.SyqXonIwSS.vMovement = this.transform.forward;
						if (293389 - 434250 != -140861)
						{
							continue;
						}
						this.SyqXonIwSS.actionState = "standby";
						if (65452 - 45536 == 19917)
						{
							continue;
						}
					}
					this.SyqXonIwSS.moveSpeed = Mathf.Lerp(this.SyqXonIwSS.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (57549 - 498646 != -441097)
					{
						continue;
					}
					if (this.SyqXonIwSS.moveSpeed < 0.1f * this.SyqXonIwSS.runSpeed)
					{
						if (163115 - 235325 != -72210)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (166630 - 331925 != -165295)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (291784 - 596781 != -304997)
						{
							continue;
						}
						this.SyqXonIwSS.moveSpeed = (float)0;
						if (298949 - 560253 != -261304)
						{
							continue;
						}
					}
				}
			}
			this.Xm7XAL8RHa += mTime;
		}
		while (131024 - 156142 == -25117);
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x00235B1C File Offset: 0x00233D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (177723 - 84281 != 93442)
		{
		}
		do
		{
			if (Time.time - this.WcGXFTcZy7 >= this.Xm7XAL8RHa)
			{
				if (179986 - 178824 == 1163)
				{
					continue;
				}
				if (Time.time - this.WcGXFTcZy7 < this.Xm7XAL8RHa + mTime)
				{
					if (137192 - 210723 != -73531)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (153803 - 240432 == -86628)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (97261 - 93279 == 3983)
						{
							continue;
						}
						this.WcGXFTcZy7 -= UnityEngine.Random.Range((float)0, rTimer);
						if (79295 - 546078 != -466783)
						{
							continue;
						}
						this.SyqXonIwSS.vDirection = this.SyqXonIwSS.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (53991 - 149452 != -95461)
						{
							continue;
						}
						this.SyqXonIwSS.vDirection.y = this.transform.position.y;
						if (193331 - 72036 == 121296)
						{
							continue;
						}
						this.SyqXonIwSS.vMovement = (this.SyqXonIwSS.vDirection - this.transform.position).normalized;
						if (267378 - 341544 == -74165)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.SyqXonIwSS.vMovement);
						if (195193 - 29534 == 165660)
						{
							continue;
						}
						this.SyqXonIwSS.actionState = "run";
						if (145684 - 222450 == -76765)
						{
							continue;
						}
						this.animation.Play("run");
						if (158953 - 271689 != -112736)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (204146 - 129377 == 74770)
						{
							continue;
						}
					}
					this.SyqXonIwSS.moveSpeed = Mathf.Lerp(this.SyqXonIwSS.moveSpeed, this.SyqXonIwSS.runSpeed, (float)4 * Time.deltaTime);
					if (269810 - 551592 == -281781)
					{
						continue;
					}
				}
			}
			this.Xm7XAL8RHa += mTime;
		}
		while (48535 - 98108 == -49572);
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x00235E24 File Offset: 0x00234024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (234251 - 213179 != 21073)
		{
		}
		for (;;)
		{
			this.SyqXonIwSS.vDirection = followObject.transform.position;
			if (131806 - 339589 != -207782)
			{
				this.SyqXonIwSS.vDirection.y = this.transform.position.y;
				if (189591 - 66362 != 123230)
				{
					this.SyqXonIwSS.vMovement = (this.SyqXonIwSS.vDirection - this.transform.position).normalized;
					if (189643 - 165671 == 23972)
					{
						this.transform.rotation = Quaternion.LookRotation(this.SyqXonIwSS.vMovement);
						if (163323 - 320253 == -156930)
						{
							this.SyqXonIwSS.actionState = "run";
							if (14599 - 268774 == -254175)
							{
								this.animation.Play("run");
								if (60142 - 347100 == -286958)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (286643 - 200299 == 86344)
									{
										this.SyqXonIwSS.moveSpeed = Mathf.Lerp(this.SyqXonIwSS.moveSpeed, this.SyqXonIwSS.runSpeed, (float)4 * Time.deltaTime);
										if (128944 - 177127 != -48182)
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

	// Token: 0x060015E1 RID: 5601 RVA: 0x0023600C File Offset: 0x0023420C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (138222 - 387836 != -249613)
		{
		}
		do
		{
			if (Time.time - this.WcGXFTcZy7 >= this.Xm7XAL8RHa)
			{
				if (16345 - 527745 == -511399)
				{
					continue;
				}
				if (Time.time - this.WcGXFTcZy7 < this.Xm7XAL8RHa + mTime)
				{
					if (258070 - 166405 != 91665)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (252878 - 469553 != -216675)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (299745 - 282857 == 16889)
						{
							continue;
						}
						this.WcGXFTcZy7 = Time.time - mTime - this.Xm7XAL8RHa;
						if (155670 - 133592 == 22079)
						{
							continue;
						}
						this.SyqXonIwSS.vDirection = Vector3.zero;
						if (200252 - 356764 == -156511)
						{
							continue;
						}
						this.SyqXonIwSS.vMovement = this.transform.forward;
						if (235611 - 255712 == -20100)
						{
							continue;
						}
						this.SyqXonIwSS.actionState = "standby";
						if (43124 - 366469 == -323344)
						{
							continue;
						}
						this.SyqXonIwSS.myAttackTarget = this.SyqXonIwSS.getHateTarget(5, 50);
						if (63592 - 277124 == -213531)
						{
							continue;
						}
						if (!this.SyqXonIwSS.myAttackTarget)
						{
							if (40990 - 126439 == -85448)
							{
								continue;
							}
							this.SyqXonIwSS.isAlert = false;
							if (255719 - 103125 != 152594)
							{
								continue;
							}
							this.WcGXFTcZy7 = Time.time;
							if (41470 - 185056 != -143586)
							{
								continue;
							}
							this.SyqXonIwSS.myAttackTarget = null;
							if (272607 - 488687 == -216079)
							{
								continue;
							}
							this.SyqXonIwSS.mOriginalPosition = this.transform.position;
							if (293749 - 45726 != 248024)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.SyqXonIwSS.myAttackTarget;
							if (121982 - 451779 != -329797)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (4963 - 489076 != -484113)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (174979 - 268397 == -93417)
								{
									continue;
								}
								this.SyqXonIwSS.isAlert = false;
								if (113698 - 270397 != -156699)
								{
									continue;
								}
								this.WcGXFTcZy7 = Time.time;
								if (280130 - 381924 == -101793)
								{
									continue;
								}
								this.SyqXonIwSS.myAttackTarget = null;
								if (279032 - 211222 == 67811)
								{
									continue;
								}
							}
							else
							{
								this.SyqXonIwSS.vDirection = myAttackTarget.transform.position;
								if (143338 - 172212 == -28873)
								{
									continue;
								}
								this.SyqXonIwSS.vDirection.y = this.transform.position.y;
								if (30273 - 535342 != -505069)
								{
									continue;
								}
								this.SyqXonIwSS.vMovement = (this.SyqXonIwSS.vDirection - this.transform.position).normalized;
								if (34168 - 410838 == -376669)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.SyqXonIwSS.vMovement);
								if (106723 - 10297 == 96427)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Xm7XAL8RHa += mTime;
		}
		while (277644 - 89186 != 188458);
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x002364BC File Offset: 0x002346BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new ShadowPenguin_AI.$AI_attack$18983(mTime, this).GetEnumerator();
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x002364CC File Offset: 0x002346CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (217257 - 303782 != -86525)
		{
		}
		while (Time.time - this.WcGXFTcZy7 > this.Xm7XAL8RHa)
		{
			if (82785 - 512229 == -429444)
			{
				this.AI_state = "none";
				if (128436 - 36932 == 91504)
				{
					this.WcGXFTcZy7 = Time.time;
					if (893 - 392215 == -391322)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x00236580 File Offset: 0x00234780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (100054 - 488574 != -388519)
		{
		}
		for (;;)
		{
			IL_20E:
			if (this.FRKXW7dH7C + (float)1 > Time.time)
			{
				if (83191 - 61181 != 22011)
				{
					break;
				}
			}
			else
			{
				this.FRKXW7dH7C = Time.time;
				if (48753 - 314001 != -265247)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (126279 - 337648 != -211368)
					{
						if (103089 - 105060 == -1971)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (38995 - 429088 != -390092)
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
									if (295603 - 551324 == -255720)
									{
										goto IL_20E;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (241855 - 483826 != -241971)
									{
										goto IL_20E;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (224234 - 225647 != -1413)
									{
										goto IL_20E;
									}
									bool flag = true;
									if (40717 - 214465 != -173748)
									{
										goto IL_20E;
									}
									eRace race = this.SyqXonIwSS.Race;
									if (244688 - 12778 == 231911)
									{
										goto IL_20E;
									}
									if (race == eRace.Tails)
									{
										if (298084 - 170408 == 127677)
										{
											goto IL_20E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_121;
										}
										if (113944 - 268486 != -154542)
										{
											goto IL_20E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (233710 - 288371 != -54661)
											{
												goto IL_20E;
											}
											goto IL_121;
										}
										goto IL_328;
										IL_121:
										flag = false;
										if (123340 - 514175 == -390834)
										{
											goto IL_20E;
										}
									}
									else if (race == eRace.Plants)
									{
										if (220259 - 496798 != -276539)
										{
											goto IL_20E;
										}
										flag = false;
										if (142409 - 239942 == -97532)
										{
											goto IL_20E;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (61379 - 232087 == -170707)
										{
											goto IL_20E;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2EB;
										}
										if (274082 - 520489 == -246406)
										{
											goto IL_20E;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (35943 - 537264 != -501321)
											{
												goto IL_20E;
											}
											goto IL_2EB;
										}
										goto IL_328;
										IL_2EB:
										flag = false;
										if (138219 - 125616 != 12603)
										{
											goto IL_20E;
										}
									}
									else if (race == eRace.Robots)
									{
										if (76521 - 389644 == -313122)
										{
											goto IL_20E;
										}
										flag = true;
										if (284757 - 488388 == -203630)
										{
											goto IL_20E;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (16224 - 34724 != -18500)
										{
											goto IL_20E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_575;
										}
										if (174521 - 214046 != -39525)
										{
											goto IL_20E;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_575;
										}
										if (256631 - 101279 != 155352)
										{
											goto IL_20E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (8143 - 103490 != -95347)
											{
												goto IL_20E;
											}
											goto IL_575;
										}
										goto IL_328;
										IL_575:
										flag = false;
										if (32108 - 324473 != -292365)
										{
											goto IL_20E;
										}
									}
									else if (race == eRace.Structure)
									{
										if (92786 - 239734 != -146948)
										{
											goto IL_20E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (224395 - 362416 == -138020)
											{
												goto IL_20E;
											}
											flag = false;
											if (180095 - 466228 != -286133)
											{
												goto IL_20E;
											}
										}
									}
									IL_328:
									if (flag)
									{
										if (33212 - 563868 == -530655)
										{
											goto IL_20E;
										}
										if (characterControl.hp > 0)
										{
											if (258711 - 290415 == -31703)
											{
												goto IL_20E;
											}
											if (characterControl.recieveTarget)
											{
												if (43833 - 511297 == -467463)
												{
													goto IL_20E;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (56330 - 93937 != -37607)
													{
														goto IL_20E;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (272100 - 198522 != 73578)
														{
															goto IL_20E;
														}
														this.SyqXonIwSS.isAlert = true;
														if (147339 - 67303 != 80036)
														{
															goto IL_20E;
														}
														this.WcGXFTcZy7 = Time.time;
														if (145417 - 498924 != -353507)
														{
															goto IL_20E;
														}
														this.SyqXonIwSS.myAttackTarget = gameObject;
														if (282050 - 125253 == 156798)
														{
															goto IL_20E;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (265591 - 236511 == 29081)
														{
															goto IL_20E;
														}
														this.SyqXonIwSS.addHate(characterControl.ActorNr, 5);
														if (183235 - 236253 != -53018)
														{
															goto IL_20E;
														}
													}
												}
											}
										}
									}
								}
								if (211872 - 475895 != -264022)
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

	// Token: 0x060015E5 RID: 5605 RVA: 0x00236BD0 File Offset: 0x00234DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x00236BD4 File Offset: 0x00234DD4
	internal static bool Fuo6GEFmKDfXhIlG1Qe()
	{
		return true;
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x00236BD8 File Offset: 0x00234DD8
	internal static bool aOiRbJFFnhqTRUIjv77()
	{
		return false;
	}

	// Token: 0x040012D5 RID: 4821
	private CharacterControl SyqXonIwSS;

	// Token: 0x040012D6 RID: 4822
	private Penguin UImXkWX7Og;

	// Token: 0x040012D7 RID: 4823
	public string AI_state;

	// Token: 0x040012D8 RID: 4824
	private float WcGXFTcZy7;

	// Token: 0x040012D9 RID: 4825
	private float Xm7XAL8RHa;

	// Token: 0x040012DA RID: 4826
	private GameObject mqjX9NpZrq;

	// Token: 0x040012DB RID: 4827
	private float FRKXW7dH7C;

	// Token: 0x020003B2 RID: 946
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$18983 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060015E8 RID: 5608 RVA: 0x00236BDC File Offset: 0x00234DDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$18983(float mTime, ShadowPenguin_AI self_)
		{
			if (54886 - 459533 != -404646)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270743 - 283181 != -12437)
				{
					base..ctor();
					if (119820 - 465450 != -345629)
					{
						this.$mTime$18991 = mTime;
						if (215085 - 97402 != 117684)
						{
							this.$self_$18992 = self_;
							if (244806 - 125530 != 119277)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00236C98 File Offset: 0x00234E98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowPenguin_AI.$AI_attack$18983.$(this.$mTime$18991, this.$self_$18992);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00236CAC File Offset: 0x00234EAC
		internal static bool ith3w6FMk9xVsVPp3kU()
		{
			return true;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00236CB0 File Offset: 0x00234EB0
		internal static bool GdiklFFxOeOERPTKSIc()
		{
			return false;
		}

		// Token: 0x040012DC RID: 4828
		internal float $mTime$18991;

		// Token: 0x040012DD RID: 4829
		internal ShadowPenguin_AI $self_$18992;

		// Token: 0x020003B3 RID: 947
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060015EC RID: 5612 RVA: 0x00236CB4 File Offset: 0x00234EB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, ShadowPenguin_AI self_)
			{
				if (167624 - 16213 != 151412)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (168421 - 187659 != -19237)
					{
						base..ctor();
						if (137595 - 132854 != 4742)
						{
							this.$mTime$18989 = mTime;
							if (33536 - 134987 == -101451)
							{
								this.$self_$18990 = self_;
								if (141093 - 348311 != -207217)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060015ED RID: 5613 RVA: 0x00236D70 File Offset: 0x00234F70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (70961 - 487498 != -416537)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2161;
					case 2:
						if (this.$self_$18990.SyqXonIwSS.actionState != "attack")
						{
							goto IL_3BE;
						}
						if (52979 - 281659 != -228680)
						{
							continue;
						}
						if (this.$self_$18990.SyqXonIwSS.myCommand != "nAttack1")
						{
							if (142229 - 581400 != -439170)
							{
								goto Block_178;
							}
							continue;
						}
						else
						{
							this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_nAttack2(this.$self_$18990.transform.position, this.$tObject$18984.collider.bounds.center - this.$self_$18990.transform.position, 0));
							if (97000 - 510597 != -413597)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_1E11;
							}
							if (207414 - 492769 != -285355)
							{
								continue;
							}
							this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_nAttack2", this.$self_$18990.transform.position, this.$tObject$18984.collider.bounds.center - this.$self_$18990.transform.position, 0);
							if (99809 - 53959 != 45850)
							{
								continue;
							}
							goto IL_1E11;
						}
						break;
					case 3:
						if (this.$self_$18990.SyqXonIwSS.actionState != "attack")
						{
							goto IL_175D;
						}
						if (255416 - 490691 == -235274)
						{
							continue;
						}
						if (this.$self_$18990.SyqXonIwSS.myCommand != "nAttack2")
						{
							if (174051 - 559722 != -385671)
							{
								continue;
							}
							goto IL_175D;
						}
						else
						{
							this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_nAttack3(this.$self_$18990.transform.position, this.$tObject$18984.collider.bounds.center - this.$self_$18990.transform.position, 0));
							if (19101 - 426535 != -407434)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (151026 - 578305 != -427279)
								{
									continue;
								}
								this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_nAttack3", this.$self_$18990.transform.position, this.$tObject$18984.collider.bounds.center - this.$self_$18990.transform.position, 0);
								if (178731 - 58062 != 120669)
								{
									continue;
								}
							}
							goto IL_2050;
						}
						break;
					default:
						if (252052 - 310610 == -58557)
						{
							continue;
						}
						break;
					}
					if (Time.time - this.$self_$18990.WcGXFTcZy7 >= this.$self_$18990.Xm7XAL8RHa)
					{
						if (189104 - 511986 != -322882)
						{
							continue;
						}
						if (Time.time - this.$self_$18990.WcGXFTcZy7 < this.$self_$18990.Xm7XAL8RHa + this.$mTime$18989)
						{
							if (119537 - 125235 == -5697)
							{
								continue;
							}
							if (!this.$self_$18990.SyqXonIwSS.myAttackTarget)
							{
								if (152532 - 558807 == -406274)
								{
									continue;
								}
								this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
								if (271692 - 111737 != 159955)
								{
									continue;
								}
								break;
							}
							else
							{
								this.$tObject$18984 = this.$self_$18990.SyqXonIwSS.myAttackTarget;
								if (1470 - 91099 != -89629)
								{
									continue;
								}
								this.$tChar$18985 = (CharacterControl)this.$tObject$18984.GetComponent(typeof(CharacterControl));
								if (112232 - 200988 == -88755)
								{
									continue;
								}
								this.$tDir$18986 = global::Math.vFlat(this.$tObject$18984.transform.position - this.$self_$18990.transform.position);
								if (210468 - 450949 != -240481)
								{
									continue;
								}
								this.$tID$18987 = 0;
								if (94892 - 108279 != -13387)
								{
									continue;
								}
								if (this.$tChar$18985)
								{
									if (213046 - 98106 != 114940)
									{
										continue;
									}
									this.$tID$18987 = this.$tChar$18985.ActorNr;
									if (183380 - 181059 != 2321)
									{
										continue;
									}
								}
								this.$distance$18988 = this.$tDir$18986.magnitude - this.$tObject$18984.collider.bounds.extents.x;
								if (195610 - 511610 != -316000)
								{
									continue;
								}
								if (this.$distance$18988 < (float)32)
								{
									if (241868 - 129121 != 112747)
									{
										continue;
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 60)
									{
										if (248986 - 141250 != 107736)
										{
											continue;
										}
										if (this.$distance$18988 < (float)4)
										{
											if (245552 - 460870 != -215318)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.hasSkill(372))
											{
												if (203239 - 113834 != 89405)
												{
													continue;
												}
												if (this.$self_$18990.SyqXonIwSS.isTimeOut("arcticEmperor") == (float)0)
												{
													if (151055 - 224044 != -72989)
													{
														continue;
													}
													this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
													if (67332 - 332285 != -264953)
													{
														continue;
													}
													this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_cast1("arcticEmperor", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987, 2));
													if (155262 - 62405 != 92858)
													{
														if (PhotonClient.IsInitialized())
														{
															if (291944 - 337673 != -45729)
															{
																continue;
															}
															this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_arcticEmperor2", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987);
															if (60622 - 471223 != -410601)
															{
																continue;
															}
														}
														goto IL_2050;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 55)
									{
										if (95451 - 431577 != -336126)
										{
											continue;
										}
										if (this.$self_$18990.SyqXonIwSS.hasSkill(272))
										{
											if (50694 - 541805 == -491110)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.isTimeOut("meteora") == (float)0)
											{
												if (176186 - 410770 == -234583)
												{
													continue;
												}
												this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
												if (145553 - 108218 == 37336)
												{
													continue;
												}
												this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_cast1("meteora", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987, 2));
												if (273583 - 118514 != 155069)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (193089 - 537188 == -344098)
													{
														continue;
													}
													this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_meteora2", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987);
													if (142713 - 586574 == -443860)
													{
														continue;
													}
												}
												goto IL_2050;
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 50)
									{
										if (180003 - 382754 != -202751)
										{
											continue;
										}
										if (this.$distance$18988 < (float)3)
										{
											if (36892 - 199397 == -162504)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.hasSkill(362))
											{
												if (2659 - 464733 != -462074)
												{
													continue;
												}
												if (this.$self_$18990.SyqXonIwSS.isTimeOut("absoluteZero") == (float)0)
												{
													if (43902 - 34529 == 9374)
													{
														continue;
													}
													this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
													if (93326 - 522669 != -429343)
													{
														continue;
													}
													this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_cast1("absoluteZero", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987, 2));
													if (151934 - 500220 != -348285)
													{
														if (PhotonClient.IsInitialized())
														{
															if (200551 - 71274 == 129278)
															{
																continue;
															}
															this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_absoluteZero2", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987);
															if (112024 - 556465 != -444441)
															{
																continue;
															}
														}
														goto IL_2050;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 45)
									{
										if (71964 - 382029 != -310065)
										{
											continue;
										}
										if (this.$self_$18990.SyqXonIwSS.hasSkill(244))
										{
											if (77120 - 136251 == -59130)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.isTimeOut("fallingComets") == (float)0)
											{
												if (59411 - 25282 == 34130)
												{
													continue;
												}
												this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
												if (255393 - 295314 == -39920)
												{
													continue;
												}
												this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_cast1("fallingComets", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987, 2));
												if (42689 - 302815 != -260125)
												{
													if (PhotonClient.IsInitialized())
													{
														if (85607 - 1369 != 84238)
														{
															continue;
														}
														this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_fallingComets2", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987);
														if (5766 - 91397 == -85630)
														{
															continue;
														}
													}
													goto IL_2050;
												}
												continue;
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 40)
									{
										if (180063 - 457995 != -277932)
										{
											continue;
										}
										if (this.$distance$18988 < (float)12)
										{
											if (170787 - 120153 == 50635)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.hasSkill(344))
											{
												if (34631 - 237666 != -203035)
												{
													continue;
												}
												if (this.$self_$18990.SyqXonIwSS.isTimeOut("tornado") == (float)0)
												{
													if (25137 - 229959 == -204821)
													{
														continue;
													}
													this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
													if (86307 - 464974 == -378666)
													{
														continue;
													}
													this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_cast1("tornado", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987, 3));
													if (156518 - 593493 != -436974)
													{
														if (PhotonClient.IsInitialized())
														{
															if (105604 - 224827 == -119222)
															{
																continue;
															}
															this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_tornado3", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987);
															if (164847 - 137600 == 27248)
															{
																continue;
															}
														}
														goto IL_2050;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 35)
									{
										if (196208 - 263365 == -67156)
										{
											continue;
										}
										if (this.$self_$18990.SyqXonIwSS.hasSkill(242))
										{
											if (176052 - 159149 != 16903)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.isTimeOut("fallingStars") == (float)0)
											{
												if (56387 - 293263 != -236876)
												{
													continue;
												}
												this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
												if (163018 - 175716 == -12697)
												{
													continue;
												}
												this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_fallingStars(this.$self_$18990.transform.position, this.$tDir$18986, this.$tID$18987, 2));
												if (76955 - 50403 != 26553)
												{
													if (PhotonClient.IsInitialized())
													{
														if (60974 - 106640 != -45666)
														{
															continue;
														}
														this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_fallingStars2", this.$self_$18990.transform.position, this.$tDir$18986, this.$tID$18987);
														if (103685 - 105388 == -1702)
														{
															continue;
														}
													}
													goto IL_2050;
												}
												continue;
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 30)
									{
										if (86328 - 462749 != -376421)
										{
											continue;
										}
										if (this.$self_$18990.SyqXonIwSS.hasSkill(324))
										{
											if (253962 - 463831 == -209868)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.isTimeOut("arcticWind") == (float)0)
											{
												if (62682 - 201184 != -138502)
												{
													continue;
												}
												this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
												if (21003 - 480913 != -459910)
												{
													continue;
												}
												this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_cast1("iceShield", this.$self_$18990.transform.position, this.$self_$18990.transform.forward, this.$self_$18990.SyqXonIwSS.ActorNr, 4));
												if (270837 - 348314 != -77476)
												{
													if (PhotonClient.IsInitialized())
													{
														if (217412 - 424229 != -206817)
														{
															continue;
														}
														this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_iceShield4", this.$self_$18990.transform.position, this.$self_$18990.transform.forward, this.$self_$18990.SyqXonIwSS.ActorNr);
														if (187407 - 50400 != 137007)
														{
															continue;
														}
													}
													goto IL_2050;
												}
												continue;
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 25)
									{
										if (217693 - 281902 != -64209)
										{
											continue;
										}
										if (this.$self_$18990.SyqXonIwSS.hasSkill(234))
										{
											if (173101 - 123537 == 49565)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.isTimeOut("manaBurn") == (float)0)
											{
												if (134926 - 197153 == -62226)
												{
													continue;
												}
												this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
												if (243605 - 386831 != -143226)
												{
													continue;
												}
												this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_cast1("manaBurn", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987, 2));
												if (211135 - 285080 != -73944)
												{
													if (PhotonClient.IsInitialized())
													{
														if (102692 - 435703 != -333011)
														{
															continue;
														}
														this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_manaBurn2", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987);
														if (222280 - 542537 != -320257)
														{
															continue;
														}
													}
													goto IL_2050;
												}
												continue;
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 20)
									{
										if (4362 - 487713 == -483350)
										{
											continue;
										}
										if (this.$distance$18988 < (float)3)
										{
											if (188382 - 251858 != -63476)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.hasSkill(314))
											{
												if (55098 - 327871 == -272772)
												{
													continue;
												}
												if (this.$self_$18990.SyqXonIwSS.isTimeOut("arcticWind") == (float)0)
												{
													if (191960 - 411922 == -219961)
													{
														continue;
													}
													this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
													if (134824 - 383866 == -249041)
													{
														continue;
													}
													this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_cast1("arcticWind", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987, 3));
													if (112252 - 177321 != -65068)
													{
														if (PhotonClient.IsInitialized())
														{
															if (290104 - 539930 != -249826)
															{
																continue;
															}
															this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_arcticWind3", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987);
															if (199622 - 111238 != 88384)
															{
																continue;
															}
														}
														goto IL_2050;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 15)
									{
										if (54972 - 162413 == -107440)
										{
											continue;
										}
										if (this.$distance$18988 < (float)3)
										{
											if (273337 - 300303 != -26966)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.hasSkill(214))
											{
												if (90120 - 223159 != -133039)
												{
													continue;
												}
												if (this.$self_$18990.SyqXonIwSS.isTimeOut("manaArc") == (float)0)
												{
													if (292592 - 331403 != -38811)
													{
														continue;
													}
													this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
													if (258180 - 174468 == 83713)
													{
														continue;
													}
													this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_manaArc(this.$self_$18990.transform.position, this.$tDir$18986, this.$tID$18987, 4));
													if (257288 - 312742 != -55454)
													{
														continue;
													}
													if (PhotonClient.IsInitialized())
													{
														if (189468 - 40079 == 149390)
														{
															continue;
														}
														this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_manaArc4", this.$self_$18990.transform.position, this.$tDir$18986, this.$tID$18987);
														if (263792 - 115225 != 148567)
														{
															continue;
														}
													}
													goto IL_2050;
												}
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 10)
									{
										if (238523 - 583075 != -344552)
										{
											continue;
										}
										if (this.$self_$18990.SyqXonIwSS.hasSkill(304))
										{
											if (258440 - 162404 != 96036)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.isTimeOut("frozenBlast") == (float)0)
											{
												if (96077 - 462269 != -366192)
												{
													continue;
												}
												this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
												if (8370 - 419780 != -411410)
												{
													continue;
												}
												this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_cast1("frozenBlast", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987, 4));
												if (91417 - 253744 != -162327)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (49137 - 272815 == -223677)
													{
														continue;
													}
													this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_frozenBlast4", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987);
													if (191318 - 581721 == -390402)
													{
														continue;
													}
												}
												goto IL_2050;
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.sp > 5)
									{
										if (84433 - 586900 != -502467)
										{
											continue;
										}
										if (this.$self_$18990.SyqXonIwSS.hasSkill(204))
										{
											if (22817 - 144624 != -121807)
											{
												continue;
											}
											if (this.$self_$18990.SyqXonIwSS.isTimeOut("manaMissile") == (float)0)
											{
												if (250052 - 4984 != 245068)
												{
													continue;
												}
												this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
												if (57327 - 530290 != -472963)
												{
													continue;
												}
												this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_cast1("manaMissile", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987, 4));
												if (57637 - 211525 != -153888)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (165303 - 459664 != -294361)
													{
														continue;
													}
													this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_manaMissile4", this.$self_$18990.transform.position, this.$tDir$18986.normalized, this.$tID$18987);
													if (84826 - 443217 != -358391)
													{
														continue;
													}
												}
												goto IL_2050;
											}
										}
									}
									if (this.$self_$18990.SyqXonIwSS.isTimeOut("nAttack") == (float)0)
									{
										if (58889 - 259661 != -200772)
										{
											continue;
										}
										this.$self_$18990.WcGXFTcZy7 = Time.time - this.$mTime$18989 - this.$self_$18990.Xm7XAL8RHa;
										if (246307 - 536951 == -290643)
										{
											continue;
										}
										this.$self_$18990.UImXkWX7Og.StartCoroutine_Auto(this.$self_$18990.UImXkWX7Og.RPC_nAttack1(this.$self_$18990.transform.position, this.$tObject$18984.collider.bounds.center - this.$self_$18990.transform.position, this.$tID$18987));
										if (261099 - 284434 != -23335)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											goto IL_207F;
										}
										if (28118 - 389935 == -361816)
										{
											continue;
										}
										this.$self_$18990.UImXkWX7Og.ActionEvent("RPC_nAttack1", this.$self_$18990.transform.position, this.$tObject$18984.collider.bounds.center - this.$self_$18990.transform.position, this.$tID$18987);
										if (51342 - 471006 != -419663)
										{
											goto Block_69;
										}
										continue;
									}
									else
									{
										this.$self_$18990.AI_state = "attack";
										if (81013 - 584042 == -503028)
										{
											continue;
										}
										this.$self_$18990.SyqXonIwSS.vDirection = this.$tObject$18984.transform.position;
										if (5541 - 187108 != -181567)
										{
											continue;
										}
										this.$self_$18990.SyqXonIwSS.vDirection.y = this.$self_$18990.transform.position.y;
										if (109774 - 323678 == -213903)
										{
											continue;
										}
										this.$self_$18990.SyqXonIwSS.vMovement = (this.$self_$18990.SyqXonIwSS.vDirection - this.$self_$18990.transform.position).normalized;
										if (199110 - 337848 == -138737)
										{
											continue;
										}
										this.$self_$18990.transform.rotation = Quaternion.LookRotation(this.$self_$18990.SyqXonIwSS.vMovement);
										if (48395 - 458033 != -409638)
										{
											continue;
										}
										this.$self_$18990.SyqXonIwSS.actionState = "standby";
										if (3669 - 177242 == -173572)
										{
											continue;
										}
										this.$self_$18990.animation.CrossFade("root", 0.2f);
										if (219712 - 426371 != -206659)
										{
											continue;
										}
										this.$self_$18990.animation.wrapMode = WrapMode.Loop;
										if (94378 - 31318 == 63061)
										{
											continue;
										}
										this.$self_$18990.SyqXonIwSS.moveSpeed = Mathf.Lerp(this.$self_$18990.SyqXonIwSS.moveSpeed, (float)0, (float)4 * Time.deltaTime);
										if (87079 - 195188 != -108109)
										{
											continue;
										}
									}
								}
								else
								{
									this.$self_$18990.AI_state = "attack";
									if (119274 - 209241 != -89967)
									{
										continue;
									}
									this.$self_$18990.SyqXonIwSS.vDirection = this.$tObject$18984.transform.position;
									if (210432 - 547255 == -336822)
									{
										continue;
									}
									this.$self_$18990.SyqXonIwSS.vDirection.y = this.$self_$18990.transform.position.y;
									if (244406 - 560991 != -316585)
									{
										continue;
									}
									this.$self_$18990.SyqXonIwSS.vMovement = (this.$self_$18990.SyqXonIwSS.vDirection - this.$self_$18990.transform.position).normalized;
									if (167061 - 86285 != 80776)
									{
										continue;
									}
									this.$self_$18990.transform.rotation = Quaternion.LookRotation(this.$self_$18990.SyqXonIwSS.vMovement);
									if (182476 - 256387 == -73910)
									{
										continue;
									}
									this.$self_$18990.SyqXonIwSS.actionState = "run";
									if (20146 - 147762 != -127616)
									{
										continue;
									}
									this.$self_$18990.animation.Play("run");
									if (293828 - 229797 == 64032)
									{
										continue;
									}
									this.$self_$18990.animation.wrapMode = WrapMode.Loop;
									if (176558 - 419824 == -243265)
									{
										continue;
									}
									this.$self_$18990.SyqXonIwSS.moveSpeed = Mathf.Lerp(this.$self_$18990.SyqXonIwSS.moveSpeed, this.$self_$18990.SyqXonIwSS.runSpeed, (float)4 * Time.deltaTime);
									if (260566 - 14115 != 246451)
									{
										continue;
									}
								}
							}
						}
					}
					IL_11BB:
					this.$self_$18990.Xm7XAL8RHa = this.$self_$18990.Xm7XAL8RHa + this.$mTime$18989;
					if (26566 - 12860 != 13706)
					{
						continue;
					}
					this.YieldDefault(1);
					if (94635 - 66961 != 27675)
					{
						break;
					}
					continue;
					IL_2050:
					goto IL_11BB;
				}
				IL_3BE:
				goto IL_2161;
				Block_69:
				goto IL_207F;
				IL_175D:
				Block_178:
				goto IL_3BE;
				IL_1E11:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_207F:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2161:
				return false;
			}

			// Token: 0x060015EE RID: 5614 RVA: 0x00238EF0 File Offset: 0x002370F0
			internal static bool LpwcXrFg7T3WkaqnXyg()
			{
				return true;
			}

			// Token: 0x060015EF RID: 5615 RVA: 0x00238EF4 File Offset: 0x002370F4
			internal static bool NJJUVtFf4ZtjotDaGH4()
			{
				return false;
			}

			// Token: 0x040012DE RID: 4830
			internal GameObject $tObject$18984;

			// Token: 0x040012DF RID: 4831
			internal CharacterControl $tChar$18985;

			// Token: 0x040012E0 RID: 4832
			internal Vector3 $tDir$18986;

			// Token: 0x040012E1 RID: 4833
			internal int $tID$18987;

			// Token: 0x040012E2 RID: 4834
			internal float $distance$18988;

			// Token: 0x040012E3 RID: 4835
			internal float $mTime$18989;

			// Token: 0x040012E4 RID: 4836
			internal ShadowPenguin_AI $self_$18990;
		}
	}
}
