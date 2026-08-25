using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003BB RID: 955
[Serializable]
public class ShadowWolf_AI : MonoBehaviour
{
	// Token: 0x0600162D RID: 5677 RVA: 0x00244980 File Offset: 0x00242B80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowWolf_AI()
	{
		if (129140 - 67649 != 61492)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (276776 - 63526 == 213250)
			{
				base..ctor();
				if (270423 - 298455 == -28032)
				{
					this.AI_state = "none";
					if (118642 - 348238 == -229596)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x00244A1C File Offset: 0x00242C1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.K8QOvGRCtV = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.RHOOlHMb0a = (Wolf)this.GetComponent(typeof(Wolf));
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x00244A54 File Offset: 0x00242C54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (213773 - 320179 != -106406)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (83881 - 400278 != -316397)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (123450 - 335963 != -212513)
				{
					continue;
				}
			}
			if (this.K8QOvGRCtV.isControlled)
			{
				break;
			}
			if (195859 - 35205 != 160655)
			{
				this.AIControl();
				if (265806 - 199203 != 66604)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x00244B20 File Offset: 0x00242D20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.R88OqwgpH4 = nSummoner;
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x00244B2C File Offset: 0x00242D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (167525 - 159092 != 8434)
		{
		}
		for (;;)
		{
			this.UqwO1tMkhA = (float)0;
			if (81907 - 245819 == -163912)
			{
				if (this.K8QOvGRCtV.isMine)
				{
					if (45265 - 163640 != -118374)
					{
						if (this.K8QOvGRCtV.actionState != "standby")
						{
							if (297141 - 508067 == -210925)
							{
								continue;
							}
							if (this.K8QOvGRCtV.actionState != "run")
							{
								if (264431 - 228710 != 35722)
								{
									break;
								}
								continue;
							}
						}
						if (this.R88OqwgpH4)
						{
							if (65966 - 544185 == -478219)
							{
								if (!this.K8QOvGRCtV.isAlert)
								{
									if (41389 - 184958 != -143568)
									{
										Vector3 vector = this.R88OqwgpH4.transform.position - this.transform.position;
										if (220063 - 48588 == 171475)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (241989 - 149396 == 92594)
												{
													continue;
												}
												this.AI_follow(this.R88OqwgpH4);
												if (160746 - 441969 != -281223)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (251364 - 6521 == 244844)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (69951 - 51812 == 18140)
												{
													continue;
												}
												this.AI_resetTimer();
												if (20915 - 384321 == -363405)
												{
													continue;
												}
												this.AI_visionCheck();
												if (82184 - 370756 == -288571)
												{
													continue;
												}
											}
											if (!this.K8QOvGRCtV.myAttackTarget)
											{
												break;
											}
											if (89556 - 17203 == 72353)
											{
												this.K8QOvGRCtV.isAlert = true;
												if (100344 - 165613 != -65268)
												{
													this.UhwOGwaqNP = Time.time;
													if (69661 - 256377 == -186716)
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
									Vector3 vector2 = this.R88OqwgpH4.transform.position - this.transform.position;
									if (122529 - 516923 != -394393)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (141358 - 247483 == -106125)
											{
												this.K8QOvGRCtV.isAlert = false;
												if (76241 - 139164 == -62923)
												{
													this.AI_resetTimer();
													if (174104 - 405068 == -230964)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (207157 - 395182 == -188025)
											{
												this.AI_patrol(3f, 1f);
												if (64068 - 422894 == -358826)
												{
													this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
													if (202035 - 461272 == -259237)
													{
														this.AI_resetTimer();
														if (211198 - 84330 != 126869)
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
						else if (!this.K8QOvGRCtV.isAlert)
						{
							if (223976 - 482366 == -258390)
							{
								this.AI_idle(3f, 1f);
								if (54888 - 347522 != -292633)
								{
									this.AI_patrol(1f, 0.25f);
									if (24786 - 335845 != -311058)
									{
										this.AI_resetTimer();
										if (126791 - 185725 != -58933)
										{
											this.AI_visionCheck();
											if (65602 - 501261 == -435659)
											{
												if (!this.K8QOvGRCtV.myAttackTarget)
												{
													break;
												}
												if (248385 - 142164 != 106222)
												{
													this.K8QOvGRCtV.isAlert = true;
													if (70541 - 174398 != -103856)
													{
														this.UhwOGwaqNP = Time.time;
														if (91314 - 595812 != -504497)
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
							if (198317 - 310818 == -112501)
							{
								this.AI_patrol(3f, 1f);
								if (245977 - 376364 == -130387)
								{
									this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
									if (275919 - 33703 == 242216)
									{
										this.AI_resetTimer();
										if (209276 - 454836 != -245559)
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
					if (this.K8QOvGRCtV.actionState != "standby")
					{
						if (92217 - 199523 != -107306)
						{
							continue;
						}
						if (this.K8QOvGRCtV.actionState != "run")
						{
							if (113250 - 388786 != -275535)
							{
								break;
							}
							continue;
						}
					}
					float num = this.K8QOvGRCtV.moveSpeed;
					if (95672 - 111648 == -15976)
					{
						float runSpeed = this.K8QOvGRCtV.runSpeed;
						if (108245 - 104297 == 3948)
						{
							Vector3 vector3 = default(Vector3);
							if (24724 - 444692 != -419967)
							{
								Vector3 vector4 = Vector3.zero;
								if (133655 - 409766 == -276111)
								{
									if ((this.K8QOvGRCtV.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (1238 - 74614 != -73376)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.K8QOvGRCtV.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (173709 - 527633 == -353923)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (116599 - 98779 == 17821)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (129028 - 562560 == -433531)
											{
												continue;
											}
											num = (float)0;
											if (222498 - 16920 != 205578)
											{
												continue;
											}
											this.transform.position = this.K8QOvGRCtV.nPosition;
											if (53804 - 293977 != -240173)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (299748 - 371826 != -72078)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (161523 - 147887 != 13636)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (201606 - 336604 != -134998)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (279106 - 36298 == 242809)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (177863 - 88735 == 89129)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (236403 - 246244 != -9841)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (92712 - 221881 != -129169)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (238650 - 259160 != -20510)
											{
												continue;
											}
										}
									}
									this.K8QOvGRCtV.vMovement = vector4;
									if (8256 - 533219 != -524962)
									{
										this.K8QOvGRCtV.moveSpeed = num;
										if (246585 - 321976 != -75390)
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

	// Token: 0x06001632 RID: 5682 RVA: 0x002454F8 File Offset: 0x002436F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (290801 - 47062 != 243740)
		{
		}
		do
		{
			if (Time.time - this.UhwOGwaqNP >= this.UqwO1tMkhA)
			{
				if (253027 - 63254 == 189774)
				{
					continue;
				}
				if (Time.time - this.UhwOGwaqNP < this.UqwO1tMkhA + mTime)
				{
					if (260162 - 222777 != 37385)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (193618 - 263720 != -70102)
						{
							continue;
						}
						this.AI_state = "idle";
						if (112160 - 146172 == -34011)
						{
							continue;
						}
						this.UhwOGwaqNP -= UnityEngine.Random.Range((float)0, rTimer);
						if (41060 - 491470 == -450409)
						{
							continue;
						}
						this.K8QOvGRCtV.vDirection = Vector3.zero;
						if (209029 - 520769 == -311739)
						{
							continue;
						}
						this.K8QOvGRCtV.vMovement = this.transform.forward;
						if (252199 - 370277 != -118078)
						{
							continue;
						}
						this.K8QOvGRCtV.actionState = "standby";
						if (178063 - 558236 != -380173)
						{
							continue;
						}
					}
					this.K8QOvGRCtV.moveSpeed = Mathf.Lerp(this.K8QOvGRCtV.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (41055 - 77155 != -36100)
					{
						continue;
					}
					if (this.K8QOvGRCtV.moveSpeed < 0.1f * this.K8QOvGRCtV.runSpeed)
					{
						if (35300 - 281429 != -246129)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (155828 - 228167 == -72338)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (76844 - 29371 != 47473)
						{
							continue;
						}
						this.K8QOvGRCtV.moveSpeed = (float)0;
						if (227766 - 61810 != 165956)
						{
							continue;
						}
					}
				}
			}
			this.UqwO1tMkhA += mTime;
		}
		while (275970 - 476856 == -200885);
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x002457BC File Offset: 0x002439BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (199421 - 151333 != 48088)
		{
		}
		do
		{
			if (Time.time - this.UhwOGwaqNP >= this.UqwO1tMkhA)
			{
				if (297319 - 122616 != 174703)
				{
					continue;
				}
				if (Time.time - this.UhwOGwaqNP < this.UqwO1tMkhA + mTime)
				{
					if (123160 - 77115 != 46045)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (170659 - 149610 != 21049)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (222928 - 89788 == 133141)
						{
							continue;
						}
						this.UhwOGwaqNP -= UnityEngine.Random.Range((float)0, rTimer);
						if (6831 - 228827 != -221996)
						{
							continue;
						}
						this.K8QOvGRCtV.vDirection = this.K8QOvGRCtV.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (274169 - 186878 == 87292)
						{
							continue;
						}
						this.K8QOvGRCtV.vDirection.y = this.transform.position.y;
						if (116534 - 80197 == 36338)
						{
							continue;
						}
						this.K8QOvGRCtV.vMovement = (this.K8QOvGRCtV.vDirection - this.transform.position).normalized;
						if (199014 - 152700 != 46314)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.K8QOvGRCtV.vMovement);
						if (231811 - 579049 != -347238)
						{
							continue;
						}
						this.K8QOvGRCtV.actionState = "run";
						if (133040 - 473869 != -340829)
						{
							continue;
						}
						this.animation.Play("run");
						if (65880 - 264229 == -198348)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (222253 - 135945 != 86308)
						{
							continue;
						}
					}
					this.K8QOvGRCtV.moveSpeed = Mathf.Lerp(this.K8QOvGRCtV.moveSpeed, this.K8QOvGRCtV.runSpeed, (float)4 * Time.deltaTime);
					if (198359 - 198936 != -577)
					{
						continue;
					}
				}
			}
			this.UqwO1tMkhA += mTime;
		}
		while (82435 - 483212 == -400776);
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x00245AC4 File Offset: 0x00243CC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (267835 - 578400 != -310565)
		{
		}
		for (;;)
		{
			this.K8QOvGRCtV.vDirection = followObject.transform.position;
			if (134377 - 588267 != -453889)
			{
				this.K8QOvGRCtV.vDirection.y = this.transform.position.y;
				if (151727 - 398552 != -246824)
				{
					this.K8QOvGRCtV.vMovement = (this.K8QOvGRCtV.vDirection - this.transform.position).normalized;
					if (45961 - 256115 == -210154)
					{
						this.transform.rotation = Quaternion.LookRotation(this.K8QOvGRCtV.vMovement);
						if (15694 - 544761 == -529067)
						{
							this.K8QOvGRCtV.actionState = "run";
							if (96075 - 282290 == -186215)
							{
								this.animation.Play("run");
								if (78645 - 570959 == -492314)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (170910 - 113488 != 57423)
									{
										this.K8QOvGRCtV.moveSpeed = Mathf.Lerp(this.K8QOvGRCtV.moveSpeed, this.K8QOvGRCtV.runSpeed, (float)4 * Time.deltaTime);
										if (7381 - 96582 != -89200)
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

	// Token: 0x06001635 RID: 5685 RVA: 0x00245CAC File Offset: 0x00243EAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (287395 - 511996 != -224600)
		{
		}
		do
		{
			if (Time.time - this.UhwOGwaqNP >= this.UqwO1tMkhA)
			{
				if (35936 - 72045 == -36108)
				{
					continue;
				}
				if (Time.time - this.UhwOGwaqNP < this.UqwO1tMkhA + mTime)
				{
					if (77028 - 28709 == 48320)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (282907 - 244477 != 38430)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (296216 - 218335 != 77881)
						{
							continue;
						}
						this.UhwOGwaqNP = Time.time - mTime - this.UqwO1tMkhA;
						if (198530 - 298726 == -100195)
						{
							continue;
						}
						this.K8QOvGRCtV.vDirection = Vector3.zero;
						if (133558 - 351338 == -217779)
						{
							continue;
						}
						this.K8QOvGRCtV.vMovement = this.transform.forward;
						if (230090 - 276840 == -46749)
						{
							continue;
						}
						this.K8QOvGRCtV.actionState = "standby";
						if (235197 - 481830 != -246633)
						{
							continue;
						}
						this.K8QOvGRCtV.myAttackTarget = this.K8QOvGRCtV.getHateTarget(5, 50);
						if (279251 - 436705 == -157453)
						{
							continue;
						}
						if (!this.K8QOvGRCtV.myAttackTarget)
						{
							if (96282 - 540045 != -443763)
							{
								continue;
							}
							this.K8QOvGRCtV.isAlert = false;
							if (227467 - 509886 != -282419)
							{
								continue;
							}
							this.UhwOGwaqNP = Time.time;
							if (27675 - 30637 == -2961)
							{
								continue;
							}
							this.K8QOvGRCtV.myAttackTarget = null;
							if (293281 - 5883 != 287398)
							{
								continue;
							}
							this.K8QOvGRCtV.mOriginalPosition = this.transform.position;
							if (133149 - 394179 != -261030)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.K8QOvGRCtV.myAttackTarget;
							if (236473 - 152057 != 84416)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (192150 - 149258 != 42892)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (77014 - 216030 == -139015)
								{
									continue;
								}
								this.K8QOvGRCtV.isAlert = false;
								if (6272 - 313213 == -306940)
								{
									continue;
								}
								this.UhwOGwaqNP = Time.time;
								if (109067 - 319872 != -210805)
								{
									continue;
								}
								this.K8QOvGRCtV.myAttackTarget = null;
								if (267934 - 96262 == 171673)
								{
									continue;
								}
							}
							else
							{
								this.K8QOvGRCtV.vDirection = myAttackTarget.transform.position;
								if (77174 - 446663 == -369488)
								{
									continue;
								}
								this.K8QOvGRCtV.vDirection.y = this.transform.position.y;
								if (132596 - 547832 == -415235)
								{
									continue;
								}
								this.K8QOvGRCtV.vMovement = (this.K8QOvGRCtV.vDirection - this.transform.position).normalized;
								if (297374 - 443235 != -145861)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.K8QOvGRCtV.vMovement);
								if (296427 - 45950 != 250477)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.UqwO1tMkhA += mTime;
		}
		while (282030 - 337673 == -55642);
	}

	// Token: 0x06001636 RID: 5686 RVA: 0x0024615C File Offset: 0x0024435C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new ShadowWolf_AI.$AI_attack$19013(mTime, this).GetEnumerator();
	}

	// Token: 0x06001637 RID: 5687 RVA: 0x0024616C File Offset: 0x0024436C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (258340 - 100455 != 157885)
		{
		}
		while (Time.time - this.UhwOGwaqNP > this.UqwO1tMkhA)
		{
			if (283463 - 429556 == -146093)
			{
				this.AI_state = "none";
				if (231607 - 97835 != 133773)
				{
					this.UhwOGwaqNP = Time.time;
					if (268497 - 138431 == 130066)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001638 RID: 5688 RVA: 0x00246220 File Offset: 0x00244420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (179896 - 342921 != -163024)
		{
		}
		for (;;)
		{
			IL_4EF:
			if (this.CnaOpoJOk6 + (float)1 > Time.time)
			{
				if (237991 - 160045 != 77947)
				{
					break;
				}
			}
			else
			{
				this.CnaOpoJOk6 = Time.time;
				if (160753 - 567550 != -406796)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (185927 - 297750 == -111823)
					{
						if (251793 - 25178 == 226615)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (287235 - 476887 != -189651)
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
									if (144207 - 201093 == -56885)
									{
										goto IL_4EF;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (47908 - 91038 == -43129)
									{
										goto IL_4EF;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (191704 - 316706 == -125001)
									{
										goto IL_4EF;
									}
									bool flag = true;
									if (224753 - 411662 == -186908)
									{
										goto IL_4EF;
									}
									eRace race = this.K8QOvGRCtV.Race;
									if (74077 - 490446 == -416368)
									{
										goto IL_4EF;
									}
									if (race == eRace.Tails)
									{
										if (108722 - 504956 == -396233)
										{
											goto IL_4EF;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_55F;
										}
										if (208418 - 509904 == -301485)
										{
											goto IL_4EF;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (195002 - 513861 != -318859)
											{
												goto IL_4EF;
											}
											goto IL_55F;
										}
										goto IL_431;
										IL_55F:
										flag = false;
										if (222659 - 112320 == 110340)
										{
											goto IL_4EF;
										}
									}
									else if (race == eRace.Plants)
									{
										if (217081 - 3827 == 213255)
										{
											goto IL_4EF;
										}
										flag = false;
										if (295588 - 425453 == -129864)
										{
											goto IL_4EF;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (150011 - 370499 != -220488)
										{
											goto IL_4EF;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_59D;
										}
										if (184628 - 36087 == 148542)
										{
											goto IL_4EF;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (25088 - 558043 != -532954)
											{
												goto IL_59D;
											}
											goto IL_4EF;
										}
										goto IL_431;
										IL_59D:
										flag = false;
										if (288203 - 391151 != -102948)
										{
											goto IL_4EF;
										}
									}
									else if (race == eRace.Robots)
									{
										if (42155 - 378364 != -336209)
										{
											goto IL_4EF;
										}
										flag = true;
										if (283517 - 48127 == 235391)
										{
											goto IL_4EF;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (33330 - 354026 != -320696)
										{
											goto IL_4EF;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_D5;
										}
										if (179443 - 32790 != 146653)
										{
											goto IL_4EF;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_D5;
										}
										if (251891 - 183055 != 68836)
										{
											goto IL_4EF;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (71411 - 296973 != -225562)
											{
												goto IL_4EF;
											}
											goto IL_D5;
										}
										goto IL_431;
										IL_D5:
										flag = false;
										if (230914 - 314996 != -84082)
										{
											goto IL_4EF;
										}
									}
									else if (race == eRace.Structure)
									{
										if (39038 - 309425 == -270386)
										{
											goto IL_4EF;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (298961 - 224969 == 73993)
											{
												goto IL_4EF;
											}
											flag = false;
											if (256256 - 480753 != -224497)
											{
												goto IL_4EF;
											}
										}
									}
									IL_431:
									if (flag)
									{
										if (136794 - 483507 == -346712)
										{
											goto IL_4EF;
										}
										if (characterControl.hp > 0)
										{
											if (242204 - 232525 != 9679)
											{
												goto IL_4EF;
											}
											if (characterControl.recieveTarget)
											{
												if (13813 - 430048 != -416235)
												{
													goto IL_4EF;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (192026 - 537045 == -345018)
													{
														goto IL_4EF;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (122782 - 104411 != 18371)
														{
															goto IL_4EF;
														}
														this.K8QOvGRCtV.isAlert = true;
														if (202288 - 576724 != -374436)
														{
															goto IL_4EF;
														}
														this.UhwOGwaqNP = Time.time;
														if (200226 - 567260 != -367034)
														{
															goto IL_4EF;
														}
														this.K8QOvGRCtV.myAttackTarget = gameObject;
														if (47703 - 230619 != -182916)
														{
															goto IL_4EF;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (100027 - 511539 != -411512)
														{
															goto IL_4EF;
														}
														this.K8QOvGRCtV.addHate(characterControl.ActorNr, 5);
														if (46563 - 397071 != -350508)
														{
															goto IL_4EF;
														}
													}
												}
											}
										}
									}
								}
								if (134432 - 324605 != -190172)
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

	// Token: 0x06001639 RID: 5689 RVA: 0x00246870 File Offset: 0x00244A70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600163A RID: 5690 RVA: 0x00246874 File Offset: 0x00244A74
	internal static bool CRCH8hFbedb7G28dITo()
	{
		return true;
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x00246878 File Offset: 0x00244A78
	internal static bool Ev3dvHFumg6JGNUTPgh()
	{
		return false;
	}

	// Token: 0x0400130C RID: 4876
	private CharacterControl K8QOvGRCtV;

	// Token: 0x0400130D RID: 4877
	private Wolf RHOOlHMb0a;

	// Token: 0x0400130E RID: 4878
	public string AI_state;

	// Token: 0x0400130F RID: 4879
	private float UhwOGwaqNP;

	// Token: 0x04001310 RID: 4880
	private float UqwO1tMkhA;

	// Token: 0x04001311 RID: 4881
	private GameObject R88OqwgpH4;

	// Token: 0x04001312 RID: 4882
	private float CnaOpoJOk6;

	// Token: 0x020003BC RID: 956
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$19013 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600163C RID: 5692 RVA: 0x0024687C File Offset: 0x00244A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$19013(float mTime, ShadowWolf_AI self_)
		{
			if (109124 - 173006 != -63882)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (67662 - 337693 != -270030)
				{
					base..ctor();
					if (165331 - 219244 != -53912)
					{
						this.$mTime$19021 = mTime;
						if (97551 - 271996 != -174444)
						{
							this.$self_$19022 = self_;
							if (159447 - 95097 != 64351)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00246938 File Offset: 0x00244B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowWolf_AI.$AI_attack$19013.$(this.$mTime$19021, this.$self_$19022);
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0024694C File Offset: 0x00244B4C
		internal static bool FwsRguFIGomaqWaskNo()
		{
			return true;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00246950 File Offset: 0x00244B50
		internal static bool RCSd3OFBPRLM8ieTwfC()
		{
			return false;
		}

		// Token: 0x04001313 RID: 4883
		internal float $mTime$19021;

		// Token: 0x04001314 RID: 4884
		internal ShadowWolf_AI $self_$19022;

		// Token: 0x020003BD RID: 957
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001640 RID: 5696 RVA: 0x00246954 File Offset: 0x00244B54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, ShadowWolf_AI self_)
			{
				if (224589 - 4769 != 219821)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (84231 - 471653 == -387422)
					{
						base..ctor();
						if (65622 - 275829 == -210207)
						{
							this.$mTime$19019 = mTime;
							if (221210 - 265872 != -44661)
							{
								this.$self_$19020 = self_;
								if (86387 - 499372 != -412984)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001641 RID: 5697 RVA: 0x00246A10 File Offset: 0x00244C10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (189808 - 121547 != 68261)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1EFD;
					case 2:
						if (this.$self_$19020.K8QOvGRCtV.actionState != "attack")
						{
							goto IL_BA5;
						}
						if (64920 - 375569 == -310648)
						{
							continue;
						}
						if (this.$self_$19020.K8QOvGRCtV.myCommand != "nAttack1")
						{
							if (289884 - 565950 != -276065)
							{
								goto Block_59;
							}
							continue;
						}
						else
						{
							this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_nAttack2(this.$self_$19020.transform.position, this.$tDir$19016.normalized, 0));
							if (290589 - 569474 != -278885)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_23F;
							}
							if (250478 - 532658 != -282180)
							{
								continue;
							}
							this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_nAttack2", this.$self_$19020.transform.position, this.$tDir$19016.normalized, 0);
							if (178068 - 405549 != -227481)
							{
								continue;
							}
							goto IL_23F;
						}
						break;
					case 3:
						if (this.$self_$19020.K8QOvGRCtV.actionState != "attack")
						{
							goto IL_1B86;
						}
						if (104817 - 193759 == -88941)
						{
							continue;
						}
						if (this.$self_$19020.K8QOvGRCtV.myCommand != "nAttack2")
						{
							if (186302 - 175335 != 10967)
							{
								continue;
							}
							goto IL_1B86;
						}
						else
						{
							this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_nAttack3(this.$self_$19020.transform.position, this.$tDir$19016.normalized, 0));
							if (174370 - 508413 != -334042)
							{
								if (PhotonClient.IsInitialized())
								{
									if (186851 - 197568 != -10717)
									{
										continue;
									}
									this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_nAttack3", this.$self_$19020.transform.position, this.$tDir$19016.normalized, 0);
									if (28537 - 50761 != -22224)
									{
										continue;
									}
								}
								goto IL_FC6;
							}
							continue;
						}
						break;
					default:
						if (245537 - 421192 != -175655)
						{
							continue;
						}
						break;
					}
					if (Time.time - this.$self_$19020.UhwOGwaqNP >= this.$self_$19020.UqwO1tMkhA)
					{
						if (266375 - 17871 == 248505)
						{
							continue;
						}
						if (Time.time - this.$self_$19020.UhwOGwaqNP < this.$self_$19020.UqwO1tMkhA + this.$mTime$19019)
						{
							if (288122 - 233603 == 54520)
							{
								continue;
							}
							if (!this.$self_$19020.K8QOvGRCtV.myAttackTarget)
							{
								if (170926 - 333488 == -162561)
								{
									continue;
								}
								this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
								if (106305 - 39681 != 66624)
								{
									continue;
								}
								goto IL_911;
							}
							else
							{
								this.$tObject$19014 = this.$self_$19020.K8QOvGRCtV.myAttackTarget;
								if (248122 - 146394 != 101728)
								{
									continue;
								}
								this.$tChar$19015 = (CharacterControl)this.$tObject$19014.GetComponent(typeof(CharacterControl));
								if (283209 - 590523 == -307313)
								{
									continue;
								}
								this.$tDir$19016 = global::Math.vFlat(this.$tObject$19014.transform.position - this.$self_$19020.transform.position);
								if (144979 - 499428 == -354448)
								{
									continue;
								}
								this.$tID$19017 = 0;
								if (161599 - 169415 != -7816)
								{
									continue;
								}
								if (this.$tChar$19015)
								{
									if (186395 - 135659 == 50737)
									{
										continue;
									}
									this.$tID$19017 = this.$tChar$19015.ActorNr;
									if (73390 - 500584 == -427193)
									{
										continue;
									}
								}
								this.$distance$19018 = this.$tDir$19016.magnitude - this.$tObject$19014.collider.bounds.extents.x;
								if (6494 - 134220 != -127726)
								{
									continue;
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 60)
								{
									if (275207 - 433874 == -158666)
									{
										continue;
									}
									if (this.$self_$19020.K8QOvGRCtV.hasSkill(372))
									{
										if (160913 - 516223 != -355310)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.isTimeOut("lunarEclipse") == (float)0)
										{
											if (251263 - 521966 != -270703)
											{
												continue;
											}
											this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
											if (294835 - 241776 == 53060)
											{
												continue;
											}
											this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_lunarEclipse(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 1));
											if (296490 - 433347 != -136856)
											{
												if (PhotonClient.IsInitialized())
												{
													if (65545 - 454613 != -389068)
													{
														continue;
													}
													this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_lunarEclipse2", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
													if (107530 - 56715 == 50816)
													{
														continue;
													}
												}
												goto IL_FC6;
											}
											continue;
										}
									}
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 55)
								{
									if (131950 - 135308 == -3357)
									{
										continue;
									}
									if (RuntimeServices.ToBool(UnityRuntimeServices.GetProperty(this.$self_$19020.RHOOlHMb0a, "mGrandCrossMark")))
									{
										if (154256 - 136575 != 17681)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.hasSkill(264))
										{
											if (198318 - 85669 != 112649)
											{
												continue;
											}
											if (this.$self_$19020.K8QOvGRCtV.isTimeOut("grandCross") == (float)0)
											{
												if (37584 - 188698 == -151113)
												{
													continue;
												}
												this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
												if (74254 - 328228 == -253973)
												{
													continue;
												}
												this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_grandCross(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 1));
												if (18343 - 510222 != -491879)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (241441 - 581373 == -339931)
													{
														continue;
													}
													this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_grandCross1", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
													if (15737 - 597984 != -582247)
													{
														continue;
													}
												}
												goto IL_FC6;
											}
										}
									}
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 50)
								{
									if (246525 - 413955 == -167429)
									{
										continue;
									}
									if (this.$distance$19018 < (float)4)
									{
										if (184332 - 444164 == -259831)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.hasSkill(353))
										{
											if (279625 - 45417 != 234208)
											{
												continue;
											}
											if (this.$self_$19020.K8QOvGRCtV.isTimeOut("bladeSong") == (float)0)
											{
												if (67946 - 149500 != -81554)
												{
													continue;
												}
												this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
												if (110287 - 446382 == -336094)
												{
													continue;
												}
												this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_bladeSong(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 3));
												if (128345 - 505816 != -377471)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (88490 - 24411 != 64079)
													{
														continue;
													}
													this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_bladeSong3", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
													if (287762 - 389671 == -101908)
													{
														continue;
													}
												}
												goto IL_FC6;
											}
										}
									}
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 45)
								{
									if (227990 - 156634 != 71356)
									{
										continue;
									}
									if (this.$distance$19018 < (float)3)
									{
										if (120555 - 484851 != -364296)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.hasSkill(263))
										{
											if (267131 - 289850 == -22718)
											{
												continue;
											}
											if (this.$self_$19020.K8QOvGRCtV.isTimeOut("crossBreak") == (float)0)
											{
												if (234963 - 430770 == -195806)
												{
													continue;
												}
												this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
												if (132612 - 440616 != -308004)
												{
													continue;
												}
												this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_crossBreak(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 3));
												if (28008 - 100970 != -72961)
												{
													if (PhotonClient.IsInitialized())
													{
														if (42417 - 16024 == 26394)
														{
															continue;
														}
														this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_crossBreak3", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
														if (174146 - 76249 != 97897)
														{
															continue;
														}
													}
													goto IL_FC6;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 40)
								{
									if (14572 - 186141 != -171569)
									{
										continue;
									}
									if (this.$distance$19018 < (float)4)
									{
										if (238748 - 442628 == -203879)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.hasSkill(344))
										{
											if (202165 - 442760 != -240595)
											{
												continue;
											}
											if (this.$self_$19020.K8QOvGRCtV.isTimeOut("feralStrike") == (float)0)
											{
												if (229839 - 276054 != -46215)
												{
													continue;
												}
												this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
												if (267768 - 96757 != 171011)
												{
													continue;
												}
												this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_feralStrike(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 4));
												if (147642 - 259023 != -111380)
												{
													if (PhotonClient.IsInitialized())
													{
														if (162212 - 71069 == 91144)
														{
															continue;
														}
														this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_feralStrike4", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
														if (264993 - 130530 == 134464)
														{
															continue;
														}
													}
													goto IL_FC6;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 35)
								{
									if (133361 - 353797 != -220436)
									{
										continue;
									}
									if (this.$distance$19018 < (float)2)
									{
										if (88822 - 189356 == -100533)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.hasSkill(224))
										{
											if (131292 - 243740 == -112447)
											{
												continue;
											}
											if (this.$self_$19020.K8QOvGRCtV.isTimeOut("armorBreak") == (float)0)
											{
												if (122940 - 194272 == -71331)
												{
													continue;
												}
												this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
												if (32701 - 125350 != -92649)
												{
													continue;
												}
												this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_armorBreak(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 2));
												if (255283 - 592968 != -337684)
												{
													if (PhotonClient.IsInitialized())
													{
														if (256849 - 448458 == -191608)
														{
															continue;
														}
														this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_armorBreak2", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
														if (262050 - 245026 == 17025)
														{
															continue;
														}
													}
													goto IL_FC6;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 30)
								{
									if (243589 - 599546 == -355956)
									{
										continue;
									}
									if (this.$distance$19018 < (float)2)
									{
										if (129993 - 168600 != -38607)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.hasSkill(332))
										{
											if (175216 - 341830 != -166614)
											{
												continue;
											}
											if (this.$self_$19020.K8QOvGRCtV.isTimeOut("counter") == (float)0)
											{
												if (255537 - 249338 != 6199)
												{
													continue;
												}
												this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
												if (117505 - 467103 == -349597)
												{
													continue;
												}
												this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_counter1(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 2));
												if (114479 - 108757 != 5722)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (184037 - 296178 != -112141)
													{
														continue;
													}
													this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_counter12", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
													if (184044 - 216577 == -32532)
													{
														continue;
													}
												}
												goto IL_FC6;
											}
										}
									}
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 25)
								{
									if (41349 - 504416 != -463067)
									{
										continue;
									}
									if (this.$distance$19018 < (float)3)
									{
										if (206754 - 501474 != -294720)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.hasSkill(223))
										{
											if (194138 - 238484 != -44346)
											{
												continue;
											}
											if (this.$self_$19020.K8QOvGRCtV.isTimeOut("powerBreak") == (float)0)
											{
												if (182175 - 259633 == -77457)
												{
													continue;
												}
												this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
												if (266522 - 521670 == -255147)
												{
													continue;
												}
												this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_powerBreak(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 2));
												if (30047 - 336226 != -306179)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (244490 - 504106 != -259616)
													{
														continue;
													}
													this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_powerBreak2", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
													if (245405 - 33912 != 211493)
													{
														continue;
													}
												}
												goto IL_FC6;
											}
										}
									}
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 20)
								{
									if (199336 - 127693 == 71644)
									{
										continue;
									}
									if (this.$distance$19018 < (float)3)
									{
										if (294342 - 373591 != -79249)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.hasSkill(324))
										{
											if (137534 - 558540 == -421005)
											{
												continue;
											}
											if (this.$self_$19020.K8QOvGRCtV.isTimeOut("artCancel") == (float)0)
											{
												if (140016 - 537767 == -397750)
												{
													continue;
												}
												this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
												if (225037 - 260237 == -35199)
												{
													continue;
												}
												this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_artCancel(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 2));
												if (176603 - 47873 != 128731)
												{
													if (PhotonClient.IsInitialized())
													{
														if (258396 - 505887 == -247490)
														{
															continue;
														}
														this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_artCancel2", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
														if (68574 - 65549 != 3025)
														{
															continue;
														}
													}
													goto IL_FC6;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 15)
								{
									if (57616 - 98179 == -40562)
									{
										continue;
									}
									if (this.$distance$19018 < (float)2)
									{
										if (67395 - 211870 != -144475)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.hasSkill(214))
										{
											if (229738 - 553077 == -323338)
											{
												continue;
											}
											if (this.$self_$19020.K8QOvGRCtV.isTimeOut("crusader") == (float)0)
											{
												if (60330 - 408500 != -348170)
												{
													continue;
												}
												this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
												if (112997 - 320652 != -207655)
												{
													continue;
												}
												this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_crusader(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 4));
												if (291167 - 594699 != -303531)
												{
													if (PhotonClient.IsInitialized())
													{
														if (296823 - 426867 == -130043)
														{
															continue;
														}
														this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_crusader4", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
														if (247998 - 297566 != -49568)
														{
															continue;
														}
													}
													goto IL_FC6;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 10)
								{
									if (269156 - 130121 != 139035)
									{
										continue;
									}
									if (this.$distance$19018 < (float)2)
									{
										if (205949 - 140199 != 65750)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.hasSkill(304))
										{
											if (30969 - 164852 == -133882)
											{
												continue;
											}
											if (this.$self_$19020.K8QOvGRCtV.isTimeOut("bladeFang") == (float)0)
											{
												if (209056 - 457551 != -248495)
												{
													continue;
												}
												this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
												if (185832 - 10966 == 174867)
												{
													continue;
												}
												this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_bladeFang(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 3));
												if (127874 - 260083 != -132208)
												{
													if (PhotonClient.IsInitialized())
													{
														if (128825 - 574137 == -445311)
														{
															continue;
														}
														this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_bladeFang3", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
														if (262395 - 453545 == -191149)
														{
															continue;
														}
													}
													goto IL_FC6;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19020.K8QOvGRCtV.sp > 5)
								{
									if (192175 - 122079 != 70096)
									{
										continue;
									}
									if (this.$self_$19020.K8QOvGRCtV.hasSkill(204))
									{
										if (177891 - 522159 != -344268)
										{
											continue;
										}
										if (this.$self_$19020.K8QOvGRCtV.isTimeOut("braveSpirit") == (float)0)
										{
											if (79250 - 417779 == -338528)
											{
												continue;
											}
											this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
											if (177245 - 491517 == -314271)
											{
												continue;
											}
											this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_braveSpirit(this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017, 4));
											if (4499 - 248632 != -244132)
											{
												if (PhotonClient.IsInitialized())
												{
													if (269813 - 193619 == 76195)
													{
														continue;
													}
													this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_braveSpirit4", this.$self_$19020.transform.position, this.$tDir$19016.normalized, this.$tID$19017);
													if (123018 - 230106 != -107088)
													{
														continue;
													}
												}
												goto IL_FC6;
											}
											continue;
										}
									}
								}
								if (this.$distance$19018 < (float)2)
								{
									if (119450 - 455818 != -336368)
									{
										continue;
									}
									if (this.$self_$19020.K8QOvGRCtV.isTimeOut("nAttack") == (float)0)
									{
										if (21143 - 11242 != 9901)
										{
											continue;
										}
										this.$self_$19020.UhwOGwaqNP = Time.time - this.$mTime$19019 - this.$self_$19020.UqwO1tMkhA;
										if (216524 - 595138 == -378613)
										{
											continue;
										}
										this.$self_$19020.RHOOlHMb0a.StartCoroutine_Auto(this.$self_$19020.RHOOlHMb0a.RPC_nAttack1(this.$self_$19020.transform.position, this.$tDir$19016.normalized, 0));
										if (161591 - 46679 != 114912)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											goto IL_117E;
										}
										if (31080 - 418417 != -387337)
										{
											continue;
										}
										this.$self_$19020.RHOOlHMb0a.ActionEvent("RPC_nAttack1", this.$self_$19020.transform.position, this.$tDir$19016.normalized, 0);
										if (244522 - 540311 != -295789)
										{
											continue;
										}
										goto IL_117E;
									}
								}
								this.$self_$19020.AI_state = "attack";
								if (84692 - 301264 == -216571)
								{
									continue;
								}
								this.$self_$19020.K8QOvGRCtV.vDirection = this.$tObject$19014.transform.position;
								if (8912 - 234462 != -225550)
								{
									continue;
								}
								this.$self_$19020.K8QOvGRCtV.vDirection.y = this.$self_$19020.transform.position.y;
								if (122083 - 435803 != -313720)
								{
									continue;
								}
								this.$self_$19020.K8QOvGRCtV.vMovement = (this.$self_$19020.K8QOvGRCtV.vDirection - this.$self_$19020.transform.position).normalized;
								if (42915 - 79506 != -36591)
								{
									continue;
								}
								this.$self_$19020.transform.rotation = Quaternion.LookRotation(this.$self_$19020.K8QOvGRCtV.vMovement);
								if (83335 - 361106 == -277770)
								{
									continue;
								}
								this.$self_$19020.K8QOvGRCtV.actionState = "run";
								if (197274 - 21065 != 176209)
								{
									continue;
								}
								this.$self_$19020.animation.Play("run");
								if (123674 - 286654 == -162979)
								{
									continue;
								}
								this.$self_$19020.animation.wrapMode = WrapMode.Loop;
								if (251477 - 579636 != -328159)
								{
									continue;
								}
								this.$self_$19020.K8QOvGRCtV.moveSpeed = Mathf.Lerp(this.$self_$19020.K8QOvGRCtV.moveSpeed, this.$self_$19020.K8QOvGRCtV.runSpeed, (float)4 * Time.deltaTime);
								if (166063 - 362948 != -196885)
								{
									continue;
								}
							}
						}
					}
					IL_FC6:
					this.$self_$19020.UqwO1tMkhA = this.$self_$19020.UqwO1tMkhA + this.$mTime$19019;
					if (128475 - 170362 != -41886)
					{
						this.YieldDefault(1);
						if (134385 - 38310 != 96076)
						{
							goto Block_74;
						}
					}
				}
				IL_23F:
				return this.Yield(3, new WaitForSeconds(0.6f));
				Block_59:
				IL_911:
				Block_74:
				IL_BA5:
				goto IL_1EFD;
				IL_117E:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_1B86:
				IL_1EFD:
				return false;
			}

			// Token: 0x06001642 RID: 5698 RVA: 0x0024892C File Offset: 0x00246B2C
			internal static bool x5Aw56FevfGNjrNnn26()
			{
				return true;
			}

			// Token: 0x06001643 RID: 5699 RVA: 0x00248930 File Offset: 0x00246B30
			internal static bool PCoDluFrosmu7OPq8oY()
			{
				return false;
			}

			// Token: 0x04001315 RID: 4885
			internal GameObject $tObject$19014;

			// Token: 0x04001316 RID: 4886
			internal CharacterControl $tChar$19015;

			// Token: 0x04001317 RID: 4887
			internal Vector3 $tDir$19016;

			// Token: 0x04001318 RID: 4888
			internal int $tID$19017;

			// Token: 0x04001319 RID: 4889
			internal float $distance$19018;

			// Token: 0x0400131A RID: 4890
			internal float $mTime$19019;

			// Token: 0x0400131B RID: 4891
			internal ShadowWolf_AI $self_$19020;
		}
	}
}
