using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200039E RID: 926
[Serializable]
public class ShadowBison_AI : MonoBehaviour
{
	// Token: 0x06001549 RID: 5449 RVA: 0x0021C234 File Offset: 0x0021A434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowBison_AI()
	{
		if (208835 - 593830 != -384994)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (261889 - 476898 != -215008)
			{
				base..ctor();
				if (126364 - 227994 == -101630)
				{
					this.AI_state = "none";
					if (96376 - 372798 != -276421)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x0021C2D0 File Offset: 0x0021A4D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.JtUXOe9iGj = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.kZUX2spQVH = (Bison)this.GetComponent(typeof(Bison));
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x0021C308 File Offset: 0x0021A508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (610 - 166503 != -165893)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (294216 - 491894 == -197677)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (195755 - 509739 != -313984)
				{
					continue;
				}
			}
			if (this.JtUXOe9iGj.isControlled)
			{
				break;
			}
			if (78779 - 449435 == -370656)
			{
				this.AIControl();
				if (120957 - 543853 == -422896)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x0021C3D4 File Offset: 0x0021A5D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.JGsXGORIq9 = nSummoner;
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x0021C3E0 File Offset: 0x0021A5E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (14753 - 312000 != -297247)
		{
		}
		for (;;)
		{
			this.ameXlGsS2U = (float)0;
			if (230966 - 298192 != -67225)
			{
				if (this.JtUXOe9iGj.isMine)
				{
					if (266088 - 365835 != -99746)
					{
						if (this.JtUXOe9iGj.actionState != "standby")
						{
							if (162802 - 52463 == 110340)
							{
								continue;
							}
							if (this.JtUXOe9iGj.actionState != "run")
							{
								if (14763 - 526474 != -511710)
								{
									break;
								}
								continue;
							}
						}
						if (this.JGsXGORIq9)
						{
							if (159945 - 181087 == -21142)
							{
								if (!this.JtUXOe9iGj.isAlert)
								{
									if (202639 - 450180 == -247541)
									{
										Vector3 vector = this.JGsXGORIq9.transform.position - this.transform.position;
										if (263936 - 55664 == 208272)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (148606 - 190756 == -42149)
												{
													continue;
												}
												this.AI_follow(this.JGsXGORIq9);
												if (126027 - 245552 == -119524)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (232511 - 573271 == -340759)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (33353 - 367046 != -333693)
												{
													continue;
												}
												this.AI_resetTimer();
												if (199033 - 13069 != 185964)
												{
													continue;
												}
												this.AI_visionCheck();
												if (237974 - 523718 == -285743)
												{
													continue;
												}
											}
											if (!this.JtUXOe9iGj.myAttackTarget)
											{
												break;
											}
											if (77766 - 62184 != 15583)
											{
												this.JtUXOe9iGj.isAlert = true;
												if (147123 - 518395 != -371271)
												{
													this.r9uXv68834 = Time.time;
													if (224678 - 373995 == -149317)
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
									Vector3 vector2 = this.JGsXGORIq9.transform.position - this.transform.position;
									if (17692 - 292287 != -274594)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (228835 - 26489 != 202347)
											{
												this.JtUXOe9iGj.isAlert = false;
												if (153877 - 259222 == -105345)
												{
													this.AI_resetTimer();
													if (284343 - 19691 != 264653)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (51898 - 453577 == -401679)
											{
												this.AI_patrol(3f, 1f);
												if (46740 - 150276 == -103536)
												{
													this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
													if (47210 - 61470 == -14260)
													{
														this.AI_resetTimer();
														if (142686 - 64449 == 78237)
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
						else if (!this.JtUXOe9iGj.isAlert)
						{
							if (275883 - 301716 == -25833)
							{
								this.AI_idle(3f, 1f);
								if (50711 - 368750 != -318038)
								{
									this.AI_patrol(1f, 0.25f);
									if (226842 - 513625 == -286783)
									{
										this.AI_resetTimer();
										if (298709 - 401687 == -102978)
										{
											this.AI_visionCheck();
											if (159219 - 173349 != -14129)
											{
												if (!this.JtUXOe9iGj.myAttackTarget)
												{
													break;
												}
												if (93478 - 134681 == -41203)
												{
													this.JtUXOe9iGj.isAlert = true;
													if (246415 - 432990 == -186575)
													{
														this.r9uXv68834 = Time.time;
														if (119119 - 318157 != -199037)
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
							if (288921 - 382217 == -93296)
							{
								this.AI_patrol(3f, 1f);
								if (70814 - 350046 == -279232)
								{
									this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
									if (283247 - 377707 == -94460)
									{
										this.AI_resetTimer();
										if (267961 - 429636 == -161675)
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
					if (this.JtUXOe9iGj.actionState != "standby")
					{
						if (283618 - 221050 == 62569)
						{
							continue;
						}
						if (this.JtUXOe9iGj.actionState != "run")
						{
							if (41868 - 590516 != -548648)
							{
								continue;
							}
							break;
						}
					}
					float num = this.JtUXOe9iGj.moveSpeed;
					if (208807 - 151213 != 57595)
					{
						float runSpeed = this.JtUXOe9iGj.runSpeed;
						if (8201 - 457558 != -449356)
						{
							Vector3 vector3 = default(Vector3);
							if (186716 - 238049 == -51333)
							{
								Vector3 vector4 = Vector3.zero;
								if (269488 - 517885 != -248396)
								{
									if ((this.JtUXOe9iGj.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (207813 - 529039 == -321225)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.JtUXOe9iGj.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (242057 - 492981 != -250924)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (27665 - 398831 != -371166)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (105017 - 346425 != -241408)
											{
												continue;
											}
											num = (float)0;
											if (260790 - 256127 == 4664)
											{
												continue;
											}
											this.transform.position = this.JtUXOe9iGj.nPosition;
											if (229598 - 173231 != 56367)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (146934 - 512109 == -365174)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (41134 - 181140 != -140006)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (282225 - 6364 != 275861)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (21899 - 177466 == -155566)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (247615 - 449590 != -201975)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (10481 - 433086 == -422604)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (277234 - 247113 != 30121)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (21919 - 247461 != -225542)
											{
												continue;
											}
										}
									}
									this.JtUXOe9iGj.vMovement = vector4;
									if (134005 - 457686 != -323680)
									{
										this.JtUXOe9iGj.moveSpeed = num;
										if (119316 - 467413 != -348096)
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

	// Token: 0x0600154E RID: 5454 RVA: 0x0021CDAC File Offset: 0x0021AFAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (184398 - 548252 != -363854)
		{
		}
		do
		{
			if (Time.time - this.r9uXv68834 >= this.ameXlGsS2U)
			{
				if (268693 - 399797 != -131104)
				{
					continue;
				}
				if (Time.time - this.r9uXv68834 < this.ameXlGsS2U + mTime)
				{
					if (127553 - 451531 == -323977)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (70136 - 343514 != -273378)
						{
							continue;
						}
						this.AI_state = "idle";
						if (65853 - 486701 == -420847)
						{
							continue;
						}
						this.r9uXv68834 -= UnityEngine.Random.Range((float)0, rTimer);
						if (39655 - 355059 != -315404)
						{
							continue;
						}
						this.JtUXOe9iGj.vDirection = Vector3.zero;
						if (117232 - 567348 == -450115)
						{
							continue;
						}
						this.JtUXOe9iGj.vMovement = this.transform.forward;
						if (278177 - 465170 != -186993)
						{
							continue;
						}
						this.JtUXOe9iGj.actionState = "standby";
						if (39034 - 473944 != -434910)
						{
							continue;
						}
					}
					this.JtUXOe9iGj.moveSpeed = Mathf.Lerp(this.JtUXOe9iGj.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (693 - 210088 != -209395)
					{
						continue;
					}
					if (this.JtUXOe9iGj.moveSpeed < 0.1f * this.JtUXOe9iGj.runSpeed)
					{
						if (135808 - 468836 == -333027)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (298683 - 345414 != -46731)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (272550 - 50321 == 222230)
						{
							continue;
						}
						this.JtUXOe9iGj.moveSpeed = (float)0;
						if (124194 - 67553 != 56641)
						{
							continue;
						}
					}
				}
			}
			this.ameXlGsS2U += mTime;
		}
		while (80448 - 585190 != -504742);
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x0021D070 File Offset: 0x0021B270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (239280 - 33876 != 205404)
		{
		}
		do
		{
			if (Time.time - this.r9uXv68834 >= this.ameXlGsS2U)
			{
				if (129487 - 523674 != -394187)
				{
					continue;
				}
				if (Time.time - this.r9uXv68834 < this.ameXlGsS2U + mTime)
				{
					if (207826 - 90461 == 117366)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (234722 - 438102 != -203380)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (56326 - 391889 == -335562)
						{
							continue;
						}
						this.r9uXv68834 -= UnityEngine.Random.Range((float)0, rTimer);
						if (181155 - 107919 == 73237)
						{
							continue;
						}
						this.JtUXOe9iGj.vDirection = this.JtUXOe9iGj.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (198298 - 308249 == -109950)
						{
							continue;
						}
						this.JtUXOe9iGj.vDirection.y = this.transform.position.y;
						if (97894 - 180509 != -82615)
						{
							continue;
						}
						this.JtUXOe9iGj.vMovement = (this.JtUXOe9iGj.vDirection - this.transform.position).normalized;
						if (219248 - 380483 != -161235)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.JtUXOe9iGj.vMovement);
						if (143262 - 290883 != -147621)
						{
							continue;
						}
						this.JtUXOe9iGj.actionState = "run";
						if (174954 - 561628 == -386673)
						{
							continue;
						}
						this.animation.Play("run");
						if (254474 - 54157 == 200318)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (44643 - 471485 != -426842)
						{
							continue;
						}
					}
					this.JtUXOe9iGj.moveSpeed = Mathf.Lerp(this.JtUXOe9iGj.moveSpeed, this.JtUXOe9iGj.runSpeed, (float)4 * Time.deltaTime);
					if (155649 - 241040 == -85390)
					{
						continue;
					}
				}
			}
			this.ameXlGsS2U += mTime;
		}
		while (101874 - 156004 != -54130);
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x0021D378 File Offset: 0x0021B578
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (260616 - 129161 != 131456)
		{
		}
		for (;;)
		{
			this.JtUXOe9iGj.vDirection = followObject.transform.position;
			if (219833 - 153366 == 66467)
			{
				this.JtUXOe9iGj.vDirection.y = this.transform.position.y;
				if (192145 - 382177 == -190032)
				{
					this.JtUXOe9iGj.vMovement = (this.JtUXOe9iGj.vDirection - this.transform.position).normalized;
					if (284280 - 540223 == -255943)
					{
						this.transform.rotation = Quaternion.LookRotation(this.JtUXOe9iGj.vMovement);
						if (112892 - 80964 != 31929)
						{
							this.JtUXOe9iGj.actionState = "run";
							if (130694 - 381784 != -251089)
							{
								this.animation.Play("run");
								if (27219 - 181882 == -154663)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (70869 - 582715 == -511846)
									{
										this.JtUXOe9iGj.moveSpeed = Mathf.Lerp(this.JtUXOe9iGj.moveSpeed, this.JtUXOe9iGj.runSpeed, (float)4 * Time.deltaTime);
										if (231274 - 130772 != 100503)
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

	// Token: 0x06001551 RID: 5457 RVA: 0x0021D560 File Offset: 0x0021B760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (216369 - 242539 != -26170)
		{
		}
		do
		{
			if (Time.time - this.r9uXv68834 >= this.ameXlGsS2U)
			{
				if (263963 - 182470 != 81493)
				{
					continue;
				}
				if (Time.time - this.r9uXv68834 < this.ameXlGsS2U + mTime)
				{
					if (25634 - 22636 != 2998)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (25584 - 598067 != -572483)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (254558 - 235681 != 18877)
						{
							continue;
						}
						this.r9uXv68834 = Time.time - mTime - this.ameXlGsS2U;
						if (195370 - 430528 != -235158)
						{
							continue;
						}
						this.JtUXOe9iGj.vDirection = Vector3.zero;
						if (11390 - 47881 != -36491)
						{
							continue;
						}
						this.JtUXOe9iGj.vMovement = this.transform.forward;
						if (27978 - 517642 == -489663)
						{
							continue;
						}
						this.JtUXOe9iGj.actionState = "standby";
						if (208642 - 212257 != -3615)
						{
							continue;
						}
						this.JtUXOe9iGj.myAttackTarget = this.JtUXOe9iGj.getHateTarget(5, 50);
						if (207993 - 205905 == 2089)
						{
							continue;
						}
						if (!this.JtUXOe9iGj.myAttackTarget)
						{
							if (61740 - 231028 != -169288)
							{
								continue;
							}
							this.JtUXOe9iGj.isAlert = false;
							if (286004 - 438456 != -152452)
							{
								continue;
							}
							this.r9uXv68834 = Time.time;
							if (257299 - 215304 == 41996)
							{
								continue;
							}
							this.JtUXOe9iGj.myAttackTarget = null;
							if (174593 - 116722 == 57872)
							{
								continue;
							}
							this.JtUXOe9iGj.mOriginalPosition = this.transform.position;
							if (150101 - 579634 != -429533)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.JtUXOe9iGj.myAttackTarget;
							if (101668 - 241214 != -139546)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (17656 - 203441 != -185785)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (203021 - 99630 == 103392)
								{
									continue;
								}
								this.JtUXOe9iGj.isAlert = false;
								if (212455 - 561233 == -348777)
								{
									continue;
								}
								this.r9uXv68834 = Time.time;
								if (116561 - 327231 != -210670)
								{
									continue;
								}
								this.JtUXOe9iGj.myAttackTarget = null;
								if (42424 - 598608 != -556184)
								{
									continue;
								}
							}
							else
							{
								this.JtUXOe9iGj.vDirection = myAttackTarget.transform.position;
								if (146489 - 465767 != -319278)
								{
									continue;
								}
								this.JtUXOe9iGj.vDirection.y = this.transform.position.y;
								if (41093 - 204956 == -163862)
								{
									continue;
								}
								this.JtUXOe9iGj.vMovement = (this.JtUXOe9iGj.vDirection - this.transform.position).normalized;
								if (8373 - 383121 == -374747)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.JtUXOe9iGj.vMovement);
								if (111481 - 267938 == -156456)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.ameXlGsS2U += mTime;
		}
		while (61024 - 228538 == -167513);
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x0021DA10 File Offset: 0x0021BC10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new ShadowBison_AI.$AI_attack$18922(mTime, this).GetEnumerator();
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x0021DA20 File Offset: 0x0021BC20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (6668 - 535803 != -529134)
		{
		}
		while (Time.time - this.r9uXv68834 > this.ameXlGsS2U)
		{
			if (94787 - 496714 == -401927)
			{
				this.AI_state = "none";
				if (134136 - 130912 == 3224)
				{
					this.r9uXv68834 = Time.time;
					if (32460 - 515804 == -483344)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x0021DAD4 File Offset: 0x0021BCD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (121919 - 191229 != -69310)
		{
		}
		for (;;)
		{
			IL_4B1:
			if (this.R7fX1qjEe6 + (float)1 > Time.time)
			{
				if (139413 - 195535 == -56122)
				{
					break;
				}
			}
			else
			{
				this.R7fX1qjEe6 = Time.time;
				if (162768 - 165615 == -2847)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (150821 - 79483 != 71339 && 280920 - 574162 != -293241)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (204650 - 599768 == -395118)
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
								if (293080 - 152691 != 140389)
								{
									goto IL_4B1;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (46804 - 71242 != -24438)
								{
									goto IL_4B1;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (282503 - 195017 == 87487)
								{
									goto IL_4B1;
								}
								bool flag = true;
								if (218523 - 463049 == -244525)
								{
									goto IL_4B1;
								}
								eRace race = this.JtUXOe9iGj.Race;
								if (7845 - 273373 == -265527)
								{
									goto IL_4B1;
								}
								if (race == eRace.Tails)
								{
									if (116080 - 551888 == -435807)
									{
										goto IL_4B1;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_5D;
									}
									if (159838 - 363209 != -203371)
									{
										goto IL_4B1;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (116595 - 451774 != -335179)
										{
											goto IL_4B1;
										}
										goto IL_5D;
									}
									goto IL_572;
									IL_5D:
									flag = false;
									if (198959 - 146686 != 52273)
									{
										goto IL_4B1;
									}
								}
								else if (race == eRace.Plants)
								{
									if (12821 - 358949 != -346128)
									{
										goto IL_4B1;
									}
									flag = false;
									if (127917 - 529312 == -401394)
									{
										goto IL_4B1;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (184170 - 415786 == -231615)
									{
										goto IL_4B1;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_22B;
									}
									if (36112 - 465417 != -429305)
									{
										goto IL_4B1;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (28971 - 300315 != -271343)
										{
											goto IL_22B;
										}
										goto IL_4B1;
									}
									goto IL_572;
									IL_22B:
									flag = false;
									if (258042 - 8449 != 249593)
									{
										goto IL_4B1;
									}
								}
								else if (race == eRace.Robots)
								{
									if (117453 - 100906 != 16547)
									{
										goto IL_4B1;
									}
									flag = true;
									if (297128 - 172041 != 125087)
									{
										goto IL_4B1;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (256630 - 154659 == 101972)
									{
										goto IL_4B1;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_269;
									}
									if (140095 - 151387 == -11291)
									{
										goto IL_4B1;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_269;
									}
									if (18922 - 9918 != 9004)
									{
										goto IL_4B1;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (38321 - 69965 != -31644)
										{
											goto IL_4B1;
										}
										goto IL_269;
									}
									goto IL_572;
									IL_269:
									flag = false;
									if (158985 - 144716 != 14269)
									{
										goto IL_4B1;
									}
								}
								else if (race == eRace.Structure)
								{
									if (10462 - 510237 != -499775)
									{
										goto IL_4B1;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (235804 - 407191 == -171386)
										{
											goto IL_4B1;
										}
										flag = false;
										if (246742 - 507594 != -260852)
										{
											goto IL_4B1;
										}
									}
								}
								IL_572:
								if (flag)
								{
									if (153671 - 142301 != 11370)
									{
										goto IL_4B1;
									}
									if (characterControl.hp > 0)
									{
										if (256882 - 171491 == 85392)
										{
											goto IL_4B1;
										}
										if (characterControl.recieveTarget)
										{
											if (59706 - 183938 != -124232)
											{
												goto IL_4B1;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (160741 - 82549 == 78193)
												{
													goto IL_4B1;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (95260 - 332731 != -237471)
													{
														goto IL_4B1;
													}
													this.JtUXOe9iGj.isAlert = true;
													if (230996 - 462709 == -231712)
													{
														goto IL_4B1;
													}
													this.r9uXv68834 = Time.time;
													if (211998 - 372357 != -160359)
													{
														goto IL_4B1;
													}
													this.JtUXOe9iGj.myAttackTarget = gameObject;
													if (196652 - 110914 == 85739)
													{
														goto IL_4B1;
													}
													UnityRuntimeServices.Update(enumerator, gameObject);
													if (119534 - 439239 == -319704)
													{
														goto IL_4B1;
													}
													this.JtUXOe9iGj.addHate(characterControl.ActorNr, 5);
													if (293214 - 361651 == -68436)
													{
														goto IL_4B1;
													}
												}
											}
										}
									}
								}
							}
							if (54399 - 286039 != -231639)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x0021E124 File Offset: 0x0021C324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x0021E128 File Offset: 0x0021C328
	internal static bool lpDfDLmekQAUvhEvHgo()
	{
		return true;
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x0021E12C File Offset: 0x0021C32C
	internal static bool SDk1ZcmrLt0NdNO0Vnl()
	{
		return false;
	}

	// Token: 0x04001270 RID: 4720
	private CharacterControl JtUXOe9iGj;

	// Token: 0x04001271 RID: 4721
	private Bison kZUX2spQVH;

	// Token: 0x04001272 RID: 4722
	public string AI_state;

	// Token: 0x04001273 RID: 4723
	private float r9uXv68834;

	// Token: 0x04001274 RID: 4724
	private float ameXlGsS2U;

	// Token: 0x04001275 RID: 4725
	private GameObject JGsXGORIq9;

	// Token: 0x04001276 RID: 4726
	private float R7fX1qjEe6;

	// Token: 0x0200039F RID: 927
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$18922 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001558 RID: 5464 RVA: 0x0021E130 File Offset: 0x0021C330
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$18922(float mTime, ShadowBison_AI self_)
		{
			if (86213 - 294431 != -208217)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (64466 - 570101 != -505634)
				{
					base..ctor();
					if (216383 - 360087 != -143703)
					{
						this.$mTime$18930 = mTime;
						if (94714 - 463492 == -368778)
						{
							this.$self_$18931 = self_;
							if (287012 - 118721 != 168292)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0021E1EC File Offset: 0x0021C3EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowBison_AI.$AI_attack$18922.$(this.$mTime$18930, this.$self_$18931);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0021E200 File Offset: 0x0021C400
		internal static bool Ex4vcimjEtolC2eyP3J()
		{
			return true;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0021E204 File Offset: 0x0021C404
		internal static bool W3fGj6mhUlx1DpYZ7nC()
		{
			return false;
		}

		// Token: 0x04001277 RID: 4727
		internal float $mTime$18930;

		// Token: 0x04001278 RID: 4728
		internal ShadowBison_AI $self_$18931;

		// Token: 0x020003A0 RID: 928
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600155C RID: 5468 RVA: 0x0021E208 File Offset: 0x0021C408
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, ShadowBison_AI self_)
			{
				if (123369 - 12304 != 111065)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121082 - 139124 != -18041)
					{
						base..ctor();
						if (237050 - 138746 == 98304)
						{
							this.$mTime$18928 = mTime;
							if (90115 - 461989 == -371874)
							{
								this.$self_$18929 = self_;
								if (178894 - 589702 != -410807)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600155D RID: 5469 RVA: 0x0021E2C4 File Offset: 0x0021C4C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212552 - 22939 != 189613)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1F9F;
					case 2:
						if (this.$self_$18929.JtUXOe9iGj.actionState != "attack")
						{
							goto IL_D65;
						}
						if (35838 - 414869 != -379031)
						{
							continue;
						}
						if (this.$self_$18929.JtUXOe9iGj.myCommand != "nAttack1")
						{
							if (25215 - 381803 != -356587)
							{
								goto Block_56;
							}
							continue;
						}
						else
						{
							this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_nAttack2(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0));
							if (26828 - 76184 == -49355)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_5FA;
							}
							if (184686 - 411934 != -227248)
							{
								continue;
							}
							this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_nAttack2", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
							if (194930 - 563311 != -368381)
							{
								continue;
							}
							goto IL_5FA;
						}
						break;
					case 3:
						if (this.$self_$18929.JtUXOe9iGj.actionState != "attack")
						{
							goto IL_F1A;
						}
						if (1927 - 66778 == -64850)
						{
							continue;
						}
						if (!(this.$self_$18929.JtUXOe9iGj.myCommand != "nAttack2"))
						{
							if (UnityEngine.Random.Range(0, 100) < 60)
							{
								if (141572 - 191743 == -50170)
								{
									continue;
								}
								this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_nAttack3(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0));
								if (204821 - 376979 != -172158)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (136218 - 539024 != -402806)
									{
										continue;
									}
									this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_nAttack3", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
									if (106612 - 461722 != -355110)
									{
										continue;
									}
								}
							}
							else
							{
								this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_nAttack4(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0));
								if (105124 - 482693 != -377569)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (299519 - 4113 == 295407)
									{
										continue;
									}
									this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_nAttack4", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
									if (24884 - 194401 == -169516)
									{
										continue;
									}
								}
							}
							goto IL_D2E;
						}
						if (229382 - 551193 != -321810)
						{
							goto Block_100;
						}
						continue;
					default:
						if (258282 - 258986 == -703)
						{
							continue;
						}
						break;
					}
					if (Time.time - this.$self_$18929.r9uXv68834 >= this.$self_$18929.ameXlGsS2U)
					{
						if (153901 - 250590 == -96688)
						{
							continue;
						}
						if (Time.time - this.$self_$18929.r9uXv68834 < this.$self_$18929.ameXlGsS2U + this.$mTime$18928)
						{
							if (276447 - 474611 == -198163)
							{
								continue;
							}
							if (!this.$self_$18929.JtUXOe9iGj.myAttackTarget)
							{
								if (126660 - 414909 != -288249)
								{
									continue;
								}
								this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
								if (241097 - 24617 != 216481)
								{
									goto Block_115;
								}
								continue;
							}
							else
							{
								this.$tObject$18923 = this.$self_$18929.JtUXOe9iGj.myAttackTarget;
								if (292894 - 488267 != -195373)
								{
									continue;
								}
								this.$tChar$18924 = (CharacterControl)this.$tObject$18923.GetComponent(typeof(CharacterControl));
								if (247381 - 199153 != 48228)
								{
									continue;
								}
								this.$tDir$18925 = global::Math.vFlat(this.$tObject$18923.transform.position - this.$self_$18929.transform.position);
								if (150321 - 365414 == -215092)
								{
									continue;
								}
								this.$tID$18926 = 0;
								if (246818 - 229699 == 17120)
								{
									continue;
								}
								if (this.$tChar$18924)
								{
									if (220897 - 367082 != -146185)
									{
										continue;
									}
									this.$tID$18926 = this.$tChar$18924.ActorNr;
									if (249067 - 350266 != -101199)
									{
										continue;
									}
								}
								this.$distance$18927 = this.$tDir$18925.magnitude - this.$tObject$18923.collider.bounds.extents.x;
								if (24828 - 328201 != -303373)
								{
									continue;
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 60)
								{
									if (97459 - 132988 != -35529)
									{
										continue;
									}
									if (this.$self_$18929.JtUXOe9iGj.hasSkill(372))
									{
										if (66147 - 133767 != -67620)
										{
											continue;
										}
										if (this.$self_$18929.JtUXOe9iGj.isTimeOut("titanForm") == (float)0)
										{
											if (165628 - 87488 != 78140)
											{
												continue;
											}
											this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
											if (190347 - 373242 != -182895)
											{
												continue;
											}
											this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_titanForm(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0, 2));
											if (270699 - 102535 != 168165)
											{
												if (PhotonClient.IsInitialized())
												{
													if (95325 - 183656 != -88331)
													{
														continue;
													}
													this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_titanForm2", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
													if (140393 - 543695 != -403302)
													{
														continue;
													}
												}
												goto IL_D2E;
											}
											continue;
										}
									}
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 55)
								{
									if (51263 - 130310 == -79046)
									{
										continue;
									}
									if (this.$self_$18929.JtUXOe9iGj.hasSkill(272))
									{
										if (259409 - 1102 == 258308)
										{
											continue;
										}
										if (this.$self_$18929.JtUXOe9iGj.isTimeOut("overPower") == (float)0)
										{
											if (97321 - 246475 != -149154)
											{
												continue;
											}
											this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
											if (236530 - 588483 != -351953)
											{
												continue;
											}
											this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_overPower(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0, 2));
											if (140156 - 23191 != 116965)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (244421 - 250344 == -5922)
												{
													continue;
												}
												this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_overPower2", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
												if (103811 - 65899 == 37913)
												{
													continue;
												}
											}
											goto IL_D2E;
										}
									}
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 50)
								{
									if (262615 - 55313 != 207302)
									{
										continue;
									}
									if (this.$distance$18927 < (float)3)
									{
										if (25303 - 149853 != -124550)
										{
											continue;
										}
										if (this.$self_$18929.JtUXOe9iGj.hasSkill(354))
										{
											if (298863 - 205817 != 93046)
											{
												continue;
											}
											if (this.$self_$18929.JtUXOe9iGj.isTimeOut("earthSmasher") == (float)0)
											{
												if (71068 - 593135 == -522066)
												{
													continue;
												}
												this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
												if (288470 - 532200 == -243729)
												{
													continue;
												}
												this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_earthSmasher(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0, 2));
												if (246899 - 261794 != -14895)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (100366 - 14369 == 85998)
													{
														continue;
													}
													this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_earthSmasher2", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
													if (209642 - 481310 != -271668)
													{
														continue;
													}
												}
												goto IL_D2E;
											}
										}
									}
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 45)
								{
									if (280856 - 272604 != 8252)
									{
										continue;
									}
									if (this.$distance$18927 < (float)4)
									{
										if (36677 - 449508 == -412830)
										{
											continue;
										}
										if (this.$self_$18929.JtUXOe9iGj.hasSkill(212))
										{
											if (183911 - 527730 != -343819)
											{
												continue;
											}
											if (this.$self_$18929.JtUXOe9iGj.isTimeOut("trample") == (float)0)
											{
												if (19410 - 31383 == -11972)
												{
													continue;
												}
												this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
												if (163630 - 65247 != 98383)
												{
													continue;
												}
												this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_trample(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0, 2));
												if (249517 - 195627 != 53891)
												{
													if (PhotonClient.IsInitialized())
													{
														if (166542 - 12218 != 154324)
														{
															continue;
														}
														this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_trample2", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
														if (269254 - 310826 != -41572)
														{
															continue;
														}
													}
													goto IL_D2E;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 40)
								{
									if (35269 - 539228 == -503958)
									{
										continue;
									}
									if (this.$distance$18927 < (float)9)
									{
										if (131468 - 398016 != -266548)
										{
											continue;
										}
										if (this.$self_$18929.JtUXOe9iGj.hasSkill(352))
										{
											if (89255 - 150918 != -61663)
											{
												continue;
											}
											if (this.$self_$18929.JtUXOe9iGj.isTimeOut("earthRupture") == (float)0)
											{
												if (6921 - 58999 == -52077)
												{
													continue;
												}
												this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
												if (20441 - 99043 == -78601)
												{
													continue;
												}
												this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_earthRupture(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0, 2));
												if (106269 - 465410 != -359140)
												{
													if (PhotonClient.IsInitialized())
													{
														if (124552 - 173207 != -48655)
														{
															continue;
														}
														this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_earthRupture2", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
														if (204197 - 331548 == -127350)
														{
															continue;
														}
													}
													goto IL_D2E;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 35)
								{
									if (170269 - 455052 != -284783)
									{
										continue;
									}
									if (this.$distance$18927 > (float)8)
									{
										if (118627 - 399221 != -280594)
										{
											continue;
										}
										if (this.$distance$18927 < (float)32)
										{
											if (93102 - 595677 == -502574)
											{
												continue;
											}
											if (this.$self_$18929.JtUXOe9iGj.hasSkill(242))
											{
												if (230581 - 59828 != 170753)
												{
													continue;
												}
												if (this.$self_$18929.JtUXOe9iGj.isTimeOut("farStun") == (float)0)
												{
													if (39352 - 593365 != -554013)
													{
														continue;
													}
													this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
													if (228657 - 166372 != 62285)
													{
														continue;
													}
													this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_farStun(this.$self_$18929.transform.position, this.$tDir$18925.normalized, this.$tID$18926, 2));
													if (6964 - 147602 != -140638)
													{
														continue;
													}
													if (PhotonClient.IsInitialized())
													{
														if (235167 - 166502 != 68665)
														{
															continue;
														}
														this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_farStun2", this.$self_$18929.transform.position, this.$tDir$18925.normalized, this.$tID$18926);
														if (26269 - 427634 != -401365)
														{
															continue;
														}
													}
													goto IL_D2E;
												}
											}
										}
									}
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 30)
								{
									if (142624 - 140509 != 2115)
									{
										continue;
									}
									if (this.$self_$18929.JtUXOe9iGj.hasSkill(334))
									{
										if (185055 - 156016 == 29040)
										{
											continue;
										}
										if (this.$self_$18929.JtUXOe9iGj.isTimeOut("ironShield") == (float)0)
										{
											if (255068 - 27388 != 227680)
											{
												continue;
											}
											this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
											if (62219 - 394470 != -332251)
											{
												continue;
											}
											this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_ironShield(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0, 1));
											if (283049 - 11036 != 272013)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (282487 - 169118 != 113369)
												{
													continue;
												}
												this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_ironShield1", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
												if (192238 - 92406 != 99832)
												{
													continue;
												}
											}
											goto IL_D2E;
										}
									}
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 25)
								{
									if (155766 - 285347 == -129580)
									{
										continue;
									}
									if (this.$distance$18927 < (float)1)
									{
										if (271866 - 147505 == 124362)
										{
											continue;
										}
										if (this.$self_$18929.JtUXOe9iGj.hasSkill(224))
										{
											if (133090 - 240325 != -107235)
											{
												continue;
											}
											if (this.$self_$18929.JtUXOe9iGj.isTimeOut("knockDown") == (float)0)
											{
												if (67547 - 507265 == -439717)
												{
													continue;
												}
												this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
												if (109511 - 286629 != -177118)
												{
													continue;
												}
												this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_knockDown(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0, 4));
												if (157417 - 154867 != 2550)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (66789 - 66339 == 451)
													{
														continue;
													}
													this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_knockDown4", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
													if (145831 - 427690 != -281859)
													{
														continue;
													}
												}
												goto IL_D2E;
											}
										}
									}
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 20)
								{
									if (60977 - 457233 != -396256)
									{
										continue;
									}
									if (this.$self_$18929.JtUXOe9iGj.hasSkill(312))
									{
										if (192118 - 492754 != -300636)
										{
											continue;
										}
										if (this.$self_$18929.JtUXOe9iGj.isTimeOut("warcry") == (float)0)
										{
											if (202721 - 322008 != -119287)
											{
												continue;
											}
											this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
											if (79950 - 700 != 79250)
											{
												continue;
											}
											this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_warcry(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0, 2));
											if (292482 - 278814 != 13668)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (155447 - 490361 == -334913)
												{
													continue;
												}
												this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_warcry2", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
												if (118515 - 486236 == -367720)
												{
													continue;
												}
											}
											goto IL_D2E;
										}
									}
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 15)
								{
									if (24484 - 226433 != -201949)
									{
										continue;
									}
									if (this.$distance$18927 < (float)1)
									{
										if (149707 - 181081 == -31373)
										{
											continue;
										}
										if (this.$self_$18929.JtUXOe9iGj.hasSkill(212))
										{
											if (19132 - 259463 != -240331)
											{
												continue;
											}
											if (this.$self_$18929.JtUXOe9iGj.isTimeOut("slam") == (float)0)
											{
												if (78830 - 484317 == -405486)
												{
													continue;
												}
												this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
												if (258808 - 431736 == -172927)
												{
													continue;
												}
												this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_slam(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0, 2));
												if (101567 - 165257 != -63689)
												{
													if (PhotonClient.IsInitialized())
													{
														if (35139 - 54371 == -19231)
														{
															continue;
														}
														this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_slam2", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
														if (262835 - 71116 == 191720)
														{
															continue;
														}
													}
													goto IL_D2E;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 10)
								{
									if (89445 - 543365 != -453920)
									{
										continue;
									}
									if (this.$distance$18927 < (float)1)
									{
										if (255421 - 22852 == 232570)
										{
											continue;
										}
										if (this.$self_$18929.JtUXOe9iGj.hasSkill(303))
										{
											if (183359 - 546621 == -363261)
											{
												continue;
											}
											if (this.$self_$18929.JtUXOe9iGj.isTimeOut("powerCleave") == (float)0)
											{
												if (223071 - 359845 != -136774)
												{
													continue;
												}
												this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
												if (165724 - 542884 != -377160)
												{
													continue;
												}
												this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_powerCleave(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0, 2));
												if (24192 - 451994 != -427801)
												{
													if (PhotonClient.IsInitialized())
													{
														if (298049 - 456992 == -158942)
														{
															continue;
														}
														this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_powerCleave2", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
														if (253691 - 322660 != -68969)
														{
															continue;
														}
													}
													goto IL_D2E;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18929.JtUXOe9iGj.sp > 5)
								{
									if (119835 - 225082 != -105247)
									{
										continue;
									}
									if (this.$self_$18929.JtUXOe9iGj.hasSkill(204))
									{
										if (11854 - 296037 != -284183)
										{
											continue;
										}
										if (!this.$self_$18929.JtUXOe9iGj.hasStatus("enrage"))
										{
											if (209180 - 200617 == 8564)
											{
												continue;
											}
											if (this.$self_$18929.JtUXOe9iGj.isTimeOut("enrage") == (float)0)
											{
												if (173222 - 75343 == 97880)
												{
													continue;
												}
												this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
												if (263092 - 573440 != -310348)
												{
													continue;
												}
												this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_enrage(this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0, 4));
												if (86191 - 388543 != -302352)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (210291 - 369472 == -159180)
													{
														continue;
													}
													this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_enrage4", this.$self_$18929.transform.position, this.$tDir$18925.normalized, 0);
													if (269885 - 458328 == -188442)
													{
														continue;
													}
												}
												goto IL_D2E;
											}
										}
									}
								}
								if (this.$distance$18927 < (float)1)
								{
									if (166595 - 8731 == 157865)
									{
										continue;
									}
									if (this.$self_$18929.JtUXOe9iGj.isTimeOut("nAttack") == (float)0)
									{
										if (223533 - 287661 != -64128)
										{
											continue;
										}
										this.$self_$18929.r9uXv68834 = Time.time - this.$mTime$18928 - this.$self_$18929.ameXlGsS2U;
										if (151483 - 457415 != -305932)
										{
											continue;
										}
										this.$self_$18929.kZUX2spQVH.StartCoroutine_Auto(this.$self_$18929.kZUX2spQVH.RPC_nAttack1(this.$self_$18929.transform.position, this.$tObject$18923.collider.bounds.center - this.$self_$18929.transform.position, 0));
										if (18278 - 339840 == -321561)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (258726 - 61713 == 197014)
										{
											continue;
										}
										this.$self_$18929.kZUX2spQVH.ActionEvent("RPC_nAttack1", this.$self_$18929.transform.position, this.$tObject$18923.collider.bounds.center - this.$self_$18929.transform.position, 0);
										if (244408 - 112669 != 131740)
										{
											break;
										}
										continue;
									}
								}
								this.$self_$18929.AI_state = "attack";
								if (238859 - 147723 == 91137)
								{
									continue;
								}
								this.$self_$18929.JtUXOe9iGj.vDirection = this.$tObject$18923.transform.position;
								if (200149 - 593465 != -393316)
								{
									continue;
								}
								this.$self_$18929.JtUXOe9iGj.vDirection.y = this.$self_$18929.transform.position.y;
								if (140152 - 315742 != -175590)
								{
									continue;
								}
								this.$self_$18929.JtUXOe9iGj.vMovement = (this.$self_$18929.JtUXOe9iGj.vDirection - this.$self_$18929.transform.position).normalized;
								if (185010 - 104857 != 80153)
								{
									continue;
								}
								this.$self_$18929.transform.rotation = Quaternion.LookRotation(this.$self_$18929.JtUXOe9iGj.vMovement);
								if (148773 - 530102 == -381328)
								{
									continue;
								}
								this.$self_$18929.JtUXOe9iGj.actionState = "run";
								if (279934 - 114792 == 165143)
								{
									continue;
								}
								this.$self_$18929.animation.Play("run");
								if (130744 - 312167 != -181423)
								{
									continue;
								}
								this.$self_$18929.animation.wrapMode = WrapMode.Loop;
								if (134097 - 337507 == -203409)
								{
									continue;
								}
								this.$self_$18929.JtUXOe9iGj.moveSpeed = Mathf.Lerp(this.$self_$18929.JtUXOe9iGj.moveSpeed, this.$self_$18929.JtUXOe9iGj.runSpeed, (float)4 * Time.deltaTime);
								if (104754 - 211826 != -107072)
								{
									continue;
								}
							}
						}
					}
					IL_D2E:
					this.$self_$18929.ameXlGsS2U = this.$self_$18929.ameXlGsS2U + this.$mTime$18928;
					if (158977 - 450814 == -291837)
					{
						this.YieldDefault(1);
						if (291436 - 130466 == 160970)
						{
							goto IL_1F9F;
						}
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_5FA:
				return this.Yield(3, new WaitForSeconds(0.7f));
				Block_56:
				IL_D65:
				IL_F1A:
				goto IL_1F9F;
				Block_100:
				goto IL_F1A;
				goto IL_1A;
				Block_115:
				IL_1F9F:
				return false;
			}

			// Token: 0x0600155E RID: 5470 RVA: 0x00220284 File Offset: 0x0021E484
			internal static bool hGg73MmsUcnpV2cSCsJ()
			{
				return true;
			}

			// Token: 0x0600155F RID: 5471 RVA: 0x00220288 File Offset: 0x0021E488
			internal static bool MS8Fbam9mZ4WI4wvINN()
			{
				return false;
			}

			// Token: 0x04001279 RID: 4729
			internal GameObject $tObject$18923;

			// Token: 0x0400127A RID: 4730
			internal CharacterControl $tChar$18924;

			// Token: 0x0400127B RID: 4731
			internal Vector3 $tDir$18925;

			// Token: 0x0400127C RID: 4732
			internal int $tID$18926;

			// Token: 0x0400127D RID: 4733
			internal float $distance$18927;

			// Token: 0x0400127E RID: 4734
			internal float $mTime$18928;

			// Token: 0x0400127F RID: 4735
			internal ShadowBison_AI $self_$18929;
		}
	}
}
