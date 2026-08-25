using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003AE RID: 942
[Serializable]
public class ShadowPanda_AI : MonoBehaviour
{
	// Token: 0x060015C2 RID: 5570 RVA: 0x002307D4 File Offset: 0x0022E9D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowPanda_AI()
	{
		if (216523 - 509408 != -292884)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (78165 - 508121 != -429955)
			{
				base..ctor();
				if (161065 - 204814 == -43749)
				{
					this.AI_state = "none";
					if (110058 - 221042 == -110984)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x00230870 File Offset: 0x0022EA70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.taLX04rrHw = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.zvaX8spaXR = (Panda)this.GetComponent(typeof(Panda));
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x002308A8 File Offset: 0x0022EAA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (243333 - 73314 != 170019)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (17266 - 548012 != -530746)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (167555 - 222618 != -55063)
				{
					continue;
				}
			}
			if (this.taLX04rrHw.isControlled)
			{
				break;
			}
			if (124603 - 140966 != -16362)
			{
				this.AIControl();
				if (269538 - 103198 == 166340)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x00230974 File Offset: 0x0022EB74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.OaoXmLlFMj = nSummoner;
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x00230980 File Offset: 0x0022EB80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (6271 - 284572 != -278301)
		{
		}
		for (;;)
		{
			this.uOFXDRYJjW = (float)0;
			if (101533 - 305923 != -204389)
			{
				if (this.taLX04rrHw.isMine)
				{
					if (165993 - 587140 == -421147)
					{
						if (this.taLX04rrHw.actionState != "standby")
						{
							if (39368 - 305079 == -265710)
							{
								continue;
							}
							if (this.taLX04rrHw.actionState != "run")
							{
								if (18767 - 565367 != -546599)
								{
									break;
								}
								continue;
							}
						}
						if (this.OaoXmLlFMj)
						{
							if (18997 - 71191 != -52193)
							{
								if (!this.taLX04rrHw.isAlert)
								{
									if (289583 - 205656 != 83928)
									{
										Vector3 vector = this.OaoXmLlFMj.transform.position - this.transform.position;
										if (204325 - 436621 != -232295)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (298895 - 325342 == -26446)
												{
													continue;
												}
												this.AI_follow(this.OaoXmLlFMj);
												if (273224 - 225366 == 47859)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (276685 - 118878 == 157808)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (145718 - 168622 == -22903)
												{
													continue;
												}
												this.AI_resetTimer();
												if (99727 - 559287 != -459560)
												{
													continue;
												}
												this.AI_visionCheck();
												if (243606 - 205114 == 38493)
												{
													continue;
												}
											}
											if (!this.taLX04rrHw.myAttackTarget)
											{
												break;
											}
											if (185911 - 197728 == -11817)
											{
												this.taLX04rrHw.isAlert = true;
												if (85092 - 565716 != -480623)
												{
													this.xGcXiZHfhw = Time.time;
													if (283345 - 224378 != 58968)
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
									Vector3 vector2 = this.OaoXmLlFMj.transform.position - this.transform.position;
									if (161717 - 128882 != 32836)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (197090 - 520067 == -322977)
											{
												this.taLX04rrHw.isAlert = false;
												if (198739 - 284763 != -86023)
												{
													this.AI_resetTimer();
													if (31338 - 22936 == 8402)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (43907 - 486477 == -442570)
											{
												this.AI_patrol(3f, 1f);
												if (150403 - 56985 == 93418)
												{
													this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
													if (255285 - 358237 != -102951)
													{
														this.AI_resetTimer();
														if (226446 - 393080 != -166633)
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
						else if (!this.taLX04rrHw.isAlert)
						{
							if (245706 - 564166 == -318460)
							{
								this.AI_idle(3f, 1f);
								if (205992 - 84785 == 121207)
								{
									this.AI_patrol(1f, 0.25f);
									if (260609 - 186378 != 74232)
									{
										this.AI_resetTimer();
										if (135431 - 421877 != -286445)
										{
											this.AI_visionCheck();
											if (131783 - 321852 == -190069)
											{
												if (!this.taLX04rrHw.myAttackTarget)
												{
													break;
												}
												if (289748 - 83755 != 205994)
												{
													this.taLX04rrHw.isAlert = true;
													if (209202 - 165471 != 43732)
													{
														this.xGcXiZHfhw = Time.time;
														if (154223 - 52022 == 102201)
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
							if (50696 - 290725 == -240029)
							{
								this.AI_patrol(3f, 1f);
								if (34331 - 78374 == -44043)
								{
									this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
									if (186457 - 519938 != -333480)
									{
										this.AI_resetTimer();
										if (122886 - 54163 != 68724)
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
					if (this.taLX04rrHw.actionState != "standby")
					{
						if (35301 - 341350 == -306048)
						{
							continue;
						}
						if (this.taLX04rrHw.actionState != "run")
						{
							if (207731 - 194911 != 12821)
							{
								break;
							}
							continue;
						}
					}
					float num = this.taLX04rrHw.moveSpeed;
					if (136056 - 506787 == -370731)
					{
						float runSpeed = this.taLX04rrHw.runSpeed;
						if (192053 - 18307 == 173746)
						{
							Vector3 vector3 = default(Vector3);
							if (153252 - 123432 != 29821)
							{
								Vector3 vector4 = Vector3.zero;
								if (234946 - 298224 != -63277)
								{
									if ((this.taLX04rrHw.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (156523 - 401673 == -245149)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.taLX04rrHw.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (117314 - 245114 == -127799)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (203316 - 55310 != 148006)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (216890 - 558201 != -341311)
											{
												continue;
											}
											num = (float)0;
											if (174227 - 335872 == -161644)
											{
												continue;
											}
											this.transform.position = this.taLX04rrHw.nPosition;
											if (161555 - 284091 == -122535)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (73235 - 199380 != -126145)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (17951 - 455382 != -437431)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (104260 - 520237 == -415976)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (12798 - 344982 == -332183)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (152706 - 503280 != -350574)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (1478 - 583518 != -582040)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (231858 - 517940 != -286082)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (32143 - 36125 != -3982)
											{
												continue;
											}
										}
									}
									this.taLX04rrHw.vMovement = vector4;
									if (22197 - 243076 != -220878)
									{
										this.taLX04rrHw.moveSpeed = num;
										if (3069 - 360469 != -357399)
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

	// Token: 0x060015C7 RID: 5575 RVA: 0x0023134C File Offset: 0x0022F54C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (222331 - 326489 != -104158)
		{
		}
		do
		{
			if (Time.time - this.xGcXiZHfhw >= this.uOFXDRYJjW)
			{
				if (243163 - 436912 != -193749)
				{
					continue;
				}
				if (Time.time - this.xGcXiZHfhw < this.uOFXDRYJjW + mTime)
				{
					if (151280 - 412900 == -261619)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (278101 - 494265 == -216163)
						{
							continue;
						}
						this.AI_state = "idle";
						if (68300 - 203579 == -135278)
						{
							continue;
						}
						this.xGcXiZHfhw -= UnityEngine.Random.Range((float)0, rTimer);
						if (185546 - 542598 != -357052)
						{
							continue;
						}
						this.taLX04rrHw.vDirection = Vector3.zero;
						if (210480 - 310670 == -100189)
						{
							continue;
						}
						this.taLX04rrHw.vMovement = this.transform.forward;
						if (280157 - 444429 == -164271)
						{
							continue;
						}
						this.taLX04rrHw.actionState = "standby";
						if (96880 - 130089 == -33208)
						{
							continue;
						}
					}
					this.taLX04rrHw.moveSpeed = Mathf.Lerp(this.taLX04rrHw.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (94289 - 217160 == -122870)
					{
						continue;
					}
					if (this.taLX04rrHw.moveSpeed < 0.1f * this.taLX04rrHw.runSpeed)
					{
						if (125993 - 350665 == -224671)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (74620 - 170843 != -96223)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (135778 - 87851 == 47928)
						{
							continue;
						}
						this.taLX04rrHw.moveSpeed = (float)0;
						if (99011 - 487412 == -388400)
						{
							continue;
						}
					}
				}
			}
			this.uOFXDRYJjW += mTime;
		}
		while (295138 - 161698 == 133441);
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x00231610 File Offset: 0x0022F810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (133896 - 150518 != -16622)
		{
		}
		do
		{
			if (Time.time - this.xGcXiZHfhw >= this.uOFXDRYJjW)
			{
				if (111966 - 142628 != -30662)
				{
					continue;
				}
				if (Time.time - this.xGcXiZHfhw < this.uOFXDRYJjW + mTime)
				{
					if (45955 - 82298 != -36343)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (238181 - 198609 != 39572)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (242113 - 582031 != -339918)
						{
							continue;
						}
						this.xGcXiZHfhw -= UnityEngine.Random.Range((float)0, rTimer);
						if (89993 - 191467 == -101473)
						{
							continue;
						}
						this.taLX04rrHw.vDirection = this.taLX04rrHw.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (294208 - 553516 == -259307)
						{
							continue;
						}
						this.taLX04rrHw.vDirection.y = this.transform.position.y;
						if (26629 - 363002 == -336372)
						{
							continue;
						}
						this.taLX04rrHw.vMovement = (this.taLX04rrHw.vDirection - this.transform.position).normalized;
						if (155140 - 209823 == -54682)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.taLX04rrHw.vMovement);
						if (55632 - 442377 != -386745)
						{
							continue;
						}
						this.taLX04rrHw.actionState = "run";
						if (211759 - 196537 != 15222)
						{
							continue;
						}
						this.animation.Play("run");
						if (280369 - 468106 == -187736)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (132915 - 233516 == -100600)
						{
							continue;
						}
					}
					this.taLX04rrHw.moveSpeed = Mathf.Lerp(this.taLX04rrHw.moveSpeed, this.taLX04rrHw.runSpeed, (float)4 * Time.deltaTime);
					if (110052 - 270031 == -159978)
					{
						continue;
					}
				}
			}
			this.uOFXDRYJjW += mTime;
		}
		while (290305 - 531317 == -241011);
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x00231918 File Offset: 0x0022FB18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (206253 - 361960 != -155707)
		{
		}
		for (;;)
		{
			this.taLX04rrHw.vDirection = followObject.transform.position;
			if (42817 - 345867 != -303049)
			{
				this.taLX04rrHw.vDirection.y = this.transform.position.y;
				if (297897 - 353833 != -55935)
				{
					this.taLX04rrHw.vMovement = (this.taLX04rrHw.vDirection - this.transform.position).normalized;
					if (96937 - 21035 == 75902)
					{
						this.transform.rotation = Quaternion.LookRotation(this.taLX04rrHw.vMovement);
						if (286071 - 237178 != 48894)
						{
							this.taLX04rrHw.actionState = "run";
							if (203849 - 413674 == -209825)
							{
								this.animation.Play("run");
								if (285643 - 455748 != -170104)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (281041 - 530230 != -249188)
									{
										this.taLX04rrHw.moveSpeed = Mathf.Lerp(this.taLX04rrHw.moveSpeed, this.taLX04rrHw.runSpeed, (float)4 * Time.deltaTime);
										if (263562 - 367707 == -104145)
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

	// Token: 0x060015CA RID: 5578 RVA: 0x00231B00 File Offset: 0x0022FD00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (21968 - 124782 != -102814)
		{
		}
		do
		{
			if (Time.time - this.xGcXiZHfhw >= this.uOFXDRYJjW)
			{
				if (100451 - 445599 == -345147)
				{
					continue;
				}
				if (Time.time - this.xGcXiZHfhw < this.uOFXDRYJjW + mTime)
				{
					if (277816 - 281654 == -3837)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (100066 - 96797 == 3270)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (110213 - 48156 == 62058)
						{
							continue;
						}
						this.xGcXiZHfhw = Time.time - mTime - this.uOFXDRYJjW;
						if (220609 - 315932 == -95322)
						{
							continue;
						}
						this.taLX04rrHw.vDirection = Vector3.zero;
						if (184456 - 93416 != 91040)
						{
							continue;
						}
						this.taLX04rrHw.vMovement = this.transform.forward;
						if (100850 - 569269 != -468419)
						{
							continue;
						}
						this.taLX04rrHw.actionState = "standby";
						if (262136 - 566787 == -304650)
						{
							continue;
						}
						this.taLX04rrHw.myAttackTarget = this.taLX04rrHw.getHateTarget(5, 50);
						if (15989 - 205317 == -189327)
						{
							continue;
						}
						if (!this.taLX04rrHw.myAttackTarget)
						{
							if (5608 - 109514 == -103905)
							{
								continue;
							}
							this.taLX04rrHw.isAlert = false;
							if (181793 - 498146 != -316353)
							{
								continue;
							}
							this.xGcXiZHfhw = Time.time;
							if (277218 - 292796 == -15577)
							{
								continue;
							}
							this.taLX04rrHw.myAttackTarget = null;
							if (25826 - 301035 != -275209)
							{
								continue;
							}
							this.taLX04rrHw.mOriginalPosition = this.transform.position;
							if (61037 - 256935 != -195898)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.taLX04rrHw.myAttackTarget;
							if (196749 - 141825 == 54925)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (279324 - 255778 == 23547)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (192040 - 351994 == -159953)
								{
									continue;
								}
								this.taLX04rrHw.isAlert = false;
								if (77200 - 67502 != 9698)
								{
									continue;
								}
								this.xGcXiZHfhw = Time.time;
								if (31527 - 223399 != -191872)
								{
									continue;
								}
								this.taLX04rrHw.myAttackTarget = null;
								if (117313 - 163865 == -46551)
								{
									continue;
								}
							}
							else
							{
								this.taLX04rrHw.vDirection = myAttackTarget.transform.position;
								if (121696 - 524199 != -402503)
								{
									continue;
								}
								this.taLX04rrHw.vDirection.y = this.transform.position.y;
								if (118428 - 474600 != -356172)
								{
									continue;
								}
								this.taLX04rrHw.vMovement = (this.taLX04rrHw.vDirection - this.transform.position).normalized;
								if (133914 - 258720 == -124805)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.taLX04rrHw.vMovement);
								if (190274 - 596719 == -406444)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.uOFXDRYJjW += mTime;
		}
		while (274942 - 435516 != -160574);
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x00231FB0 File Offset: 0x002301B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new ShadowPanda_AI.$AI_attack$18973(mTime, this).GetEnumerator();
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x00231FC0 File Offset: 0x002301C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (116756 - 3413 != 113344)
		{
		}
		while (Time.time - this.xGcXiZHfhw > this.uOFXDRYJjW)
		{
			if (143967 - 55487 != 88481)
			{
				this.AI_state = "none";
				if (24429 - 446097 == -421668)
				{
					this.xGcXiZHfhw = Time.time;
					if (118405 - 429809 == -311404)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x00232074 File Offset: 0x00230274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (286207 - 389512 != -103304)
		{
		}
		for (;;)
		{
			IL_F3:
			if (this.NRmXjRSpUP + (float)1 > Time.time)
			{
				if (176889 - 440082 == -263193)
				{
					break;
				}
			}
			else
			{
				this.NRmXjRSpUP = Time.time;
				if (116107 - 235342 == -119235)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (267297 - 93655 == 173642)
					{
						if (67555 - 66055 != 1501)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (5484 - 44888 == -39404)
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
									if (231574 - 412732 == -181157)
									{
										goto IL_F3;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (219760 - 372984 != -153224)
									{
										goto IL_F3;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (135854 - 568282 != -432428)
									{
										goto IL_F3;
									}
									bool flag = true;
									if (226943 - 517335 == -290391)
									{
										goto IL_F3;
									}
									eRace race = this.taLX04rrHw.Race;
									if (176257 - 45702 != 130555)
									{
										goto IL_F3;
									}
									if (race == eRace.Tails)
									{
										if (41750 - 328047 == -286296)
										{
											goto IL_F3;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_18A;
										}
										if (129550 - 184300 == -54749)
										{
											goto IL_F3;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (164293 - 316505 != -152211)
											{
												goto IL_18A;
											}
											goto IL_F3;
										}
										goto IL_21A;
										IL_18A:
										flag = false;
										if (178775 - 301332 != -122557)
										{
											goto IL_F3;
										}
									}
									else if (race == eRace.Plants)
									{
										if (129371 - 316712 == -187340)
										{
											goto IL_F3;
										}
										flag = false;
										if (129107 - 106220 != 22887)
										{
											goto IL_F3;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (107373 - 249472 != -142099)
										{
											goto IL_F3;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_4EA;
										}
										if (4811 - 224548 != -219737)
										{
											goto IL_F3;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (281368 - 104686 != 176682)
											{
												goto IL_F3;
											}
											goto IL_4EA;
										}
										goto IL_21A;
										IL_4EA:
										flag = false;
										if (171179 - 405569 == -234389)
										{
											goto IL_F3;
										}
									}
									else if (race == eRace.Robots)
									{
										if (258669 - 514046 != -255377)
										{
											goto IL_F3;
										}
										flag = true;
										if (42876 - 79029 == -36152)
										{
											goto IL_F3;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (88784 - 510955 == -422170)
										{
											goto IL_F3;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_4A8;
										}
										if (128683 - 141134 == -12450)
										{
											goto IL_F3;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_4A8;
										}
										if (140460 - 227266 != -86806)
										{
											goto IL_F3;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (154541 - 48305 != 106236)
											{
												goto IL_F3;
											}
											goto IL_4A8;
										}
										goto IL_21A;
										IL_4A8:
										flag = false;
										if (252264 - 198114 != 54150)
										{
											goto IL_F3;
										}
									}
									else if (race == eRace.Structure)
									{
										if (121882 - 378300 != -256418)
										{
											goto IL_F3;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (61576 - 191417 != -129841)
											{
												goto IL_F3;
											}
											flag = false;
											if (20436 - 283291 != -262855)
											{
												goto IL_F3;
											}
										}
									}
									IL_21A:
									if (flag)
									{
										if (265955 - 266985 == -1029)
										{
											goto IL_F3;
										}
										if (characterControl.hp > 0)
										{
											if (282785 - 311914 != -29129)
											{
												goto IL_F3;
											}
											if (characterControl.recieveTarget)
											{
												if (147952 - 572261 != -424309)
												{
													goto IL_F3;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (119769 - 68789 != 50980)
													{
														goto IL_F3;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (146242 - 438631 != -292389)
														{
															goto IL_F3;
														}
														this.taLX04rrHw.isAlert = true;
														if (16102 - 94386 == -78283)
														{
															goto IL_F3;
														}
														this.xGcXiZHfhw = Time.time;
														if (126144 - 324156 != -198012)
														{
															goto IL_F3;
														}
														this.taLX04rrHw.myAttackTarget = gameObject;
														if (90276 - 8243 != 82033)
														{
															goto IL_F3;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (21496 - 54381 != -32885)
														{
															goto IL_F3;
														}
														this.taLX04rrHw.addHate(characterControl.ActorNr, 5);
														if (62174 - 359829 == -297654)
														{
															goto IL_F3;
														}
													}
												}
											}
										}
									}
								}
								if (126700 - 94379 != 32322)
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

	// Token: 0x060015CE RID: 5582 RVA: 0x002326C4 File Offset: 0x002308C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060015CF RID: 5583 RVA: 0x002326C8 File Offset: 0x002308C8
	internal static bool Ei1exjF2m6pGiYhcSsf()
	{
		return true;
	}

	// Token: 0x060015D0 RID: 5584 RVA: 0x002326CC File Offset: 0x002308CC
	internal static bool px73E8F8SUOOtGtdqaY()
	{
		return false;
	}

	// Token: 0x040012C5 RID: 4805
	private CharacterControl taLX04rrHw;

	// Token: 0x040012C6 RID: 4806
	private Panda zvaX8spaXR;

	// Token: 0x040012C7 RID: 4807
	public string AI_state;

	// Token: 0x040012C8 RID: 4808
	private float xGcXiZHfhw;

	// Token: 0x040012C9 RID: 4809
	private float uOFXDRYJjW;

	// Token: 0x040012CA RID: 4810
	private GameObject OaoXmLlFMj;

	// Token: 0x040012CB RID: 4811
	private float NRmXjRSpUP;

	// Token: 0x020003AF RID: 943
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$18973 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060015D1 RID: 5585 RVA: 0x002326D0 File Offset: 0x002308D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$18973(float mTime, ShadowPanda_AI self_)
		{
			if (266804 - 523268 != -256463)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (48042 - 394319 != -346276)
				{
					base..ctor();
					if (69067 - 551032 != -481964)
					{
						this.$mTime$18981 = mTime;
						if (159018 - 459258 == -300240)
						{
							this.$self_$18982 = self_;
							if (82519 - 190482 == -107963)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0023278C File Offset: 0x0023098C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowPanda_AI.$AI_attack$18973.$(this.$mTime$18981, this.$self_$18982);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x002327A0 File Offset: 0x002309A0
		internal static bool ti2y27FZBLjAV4UUcE1()
		{
			return true;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x002327A4 File Offset: 0x002309A4
		internal static bool HgstorFCCw4RyeYBG5h()
		{
			return false;
		}

		// Token: 0x040012CC RID: 4812
		internal float $mTime$18981;

		// Token: 0x040012CD RID: 4813
		internal ShadowPanda_AI $self_$18982;

		// Token: 0x020003B0 RID: 944
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060015D5 RID: 5589 RVA: 0x002327A8 File Offset: 0x002309A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, ShadowPanda_AI self_)
			{
				if (211069 - 88385 != 122684)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202220 - 597549 != -395328)
					{
						base..ctor();
						if (296843 - 104581 != 192263)
						{
							this.$mTime$18979 = mTime;
							if (56234 - 377956 != -321721)
							{
								this.$self_$18980 = self_;
								if (56815 - 588373 != -531557)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060015D6 RID: 5590 RVA: 0x00232864 File Offset: 0x00230A64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (265226 - 445277 != -180051)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2455;
					case 2:
						if (!this.$tObject$18974)
						{
							goto IL_1E88;
						}
						if (261858 - 595316 != -333458)
						{
							continue;
						}
						if (this.$self_$18980.taLX04rrHw.actionState != "attack")
						{
							goto IL_1E88;
						}
						if (242037 - 333824 == -91786)
						{
							continue;
						}
						if (this.$self_$18980.taLX04rrHw.myCommand != "nAttack1")
						{
							if (228749 - 157880 != 70870)
							{
								goto Block_183;
							}
							continue;
						}
						else
						{
							this.$tDir$18976 = global::Math.vFlat(this.$tObject$18974.transform.position - this.$self_$18980.transform.position);
							if (193634 - 597128 != -403494)
							{
								continue;
							}
							if (this.$tDir$18976.magnitude > (float)1)
							{
								if (289718 - 420410 != -130691)
								{
									goto Block_15;
								}
								continue;
							}
							else
							{
								this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_nAttack2(this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0));
								if (198594 - 333618 == -135023)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_1C62;
								}
								if (155048 - 338970 == -183921)
								{
									continue;
								}
								this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_nAttack2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0);
								if (80645 - 427506 != -346861)
								{
									continue;
								}
								goto IL_1C62;
							}
						}
						break;
					case 3:
						if (!this.$tObject$18974)
						{
							goto IL_1F5C;
						}
						if (261758 - 45872 == 215887)
						{
							continue;
						}
						if (this.$self_$18980.taLX04rrHw.actionState != "attack")
						{
							goto IL_1F5C;
						}
						if (173052 - 441615 != -268563)
						{
							continue;
						}
						if (this.$self_$18980.taLX04rrHw.myCommand != "nAttack2")
						{
							if (180981 - 203085 != -22103)
							{
								goto Block_129;
							}
							continue;
						}
						else
						{
							this.$tDir$18976 = global::Math.vFlat(this.$tObject$18974.transform.position - this.$self_$18980.transform.position);
							if (250440 - 114082 != 136358)
							{
								continue;
							}
							if (this.$tDir$18976.magnitude > (float)1)
							{
								if (68549 - 157826 != -89276)
								{
									goto Block_51;
								}
								continue;
							}
							else
							{
								this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_nAttack3(this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0));
								if (125830 - 390505 == -264674)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_20E2;
								}
								if (24908 - 298011 == -273102)
								{
									continue;
								}
								this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_nAttack3", this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0);
								if (93116 - 191580 != -98463)
								{
									goto Block_157;
								}
								continue;
							}
						}
						break;
					case 4:
						if (!this.$tObject$18974)
						{
							goto IL_E93;
						}
						if (161727 - 244013 == -82285)
						{
							continue;
						}
						if (this.$self_$18980.taLX04rrHw.actionState != "attack")
						{
							goto IL_E93;
						}
						if (4261 - 317129 != -312868)
						{
							continue;
						}
						if (this.$self_$18980.taLX04rrHw.myCommand != "nAttack3")
						{
							if (25746 - 4647 != 21100)
							{
								goto Block_221;
							}
							continue;
						}
						else
						{
							this.$tDir$18976 = global::Math.vFlat(this.$tObject$18974.transform.position - this.$self_$18980.transform.position);
							if (280737 - 134180 != 146557)
							{
								continue;
							}
							if (this.$tDir$18976.magnitude > (float)1)
							{
								if (182268 - 572522 != -390254)
								{
									continue;
								}
								goto IL_115E;
							}
							else
							{
								this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_nAttack4(this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0));
								if (23933 - 466118 != -442185)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_228;
								}
								if (287804 - 308470 == -20665)
								{
									continue;
								}
								this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_nAttack4", this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0);
								if (176465 - 518365 != -341899)
								{
									goto Block_130;
								}
								continue;
							}
						}
						break;
					case 5:
						if (!this.$tObject$18974)
						{
							goto IL_104F;
						}
						if (69576 - 4283 != 65293)
						{
							continue;
						}
						if (this.$self_$18980.taLX04rrHw.actionState != "attack")
						{
							goto IL_104F;
						}
						if (225296 - 7633 != 217663)
						{
							continue;
						}
						if (this.$self_$18980.taLX04rrHw.myCommand != "nAttack4")
						{
							if (107007 - 372017 != -265010)
							{
								continue;
							}
							goto IL_104F;
						}
						else
						{
							this.$tDir$18976 = global::Math.vFlat(this.$tObject$18974.transform.position - this.$self_$18980.transform.position);
							if (253204 - 8109 != 245095)
							{
								continue;
							}
							if (this.$tDir$18976.magnitude > (float)1)
							{
								if (36646 - 181230 != -144583)
								{
									goto Block_198;
								}
								continue;
							}
							else
							{
								this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_nAttack5(this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0));
								if (220379 - 320020 != -99641)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (142792 - 415429 == -272636)
									{
										continue;
									}
									this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_nAttack5", this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0);
									if (276865 - 210668 == 66198)
									{
										continue;
									}
								}
								goto IL_9D5;
							}
						}
						break;
					default:
						if (264341 - 373848 == -109506)
						{
							continue;
						}
						break;
					}
					if (Time.time - this.$self_$18980.xGcXiZHfhw >= this.$self_$18980.uOFXDRYJjW)
					{
						if (189762 - 492430 != -302668)
						{
							continue;
						}
						if (Time.time - this.$self_$18980.xGcXiZHfhw < this.$self_$18980.uOFXDRYJjW + this.$mTime$18979)
						{
							if (148365 - 405705 == -257339)
							{
								continue;
							}
							if (!this.$self_$18980.taLX04rrHw.myAttackTarget)
							{
								if (150169 - 98025 != 52144)
								{
									continue;
								}
								this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
								if (15605 - 386643 != -371037)
								{
									break;
								}
								continue;
							}
							else
							{
								this.$tObject$18974 = this.$self_$18980.taLX04rrHw.myAttackTarget;
								if (39090 - 386191 == -347100)
								{
									continue;
								}
								this.$tChar$18975 = (CharacterControl)this.$tObject$18974.GetComponent(typeof(CharacterControl));
								if (190134 - 208958 != -18824)
								{
									continue;
								}
								this.$tDir$18976 = global::Math.vFlat(this.$tObject$18974.transform.position - this.$self_$18980.transform.position);
								if (279080 - 414223 != -135143)
								{
									continue;
								}
								this.$tID$18977 = 0;
								if (118476 - 436987 != -318511)
								{
									continue;
								}
								if (this.$tChar$18975)
								{
									if (145745 - 492389 != -346644)
									{
										continue;
									}
									this.$tID$18977 = this.$tChar$18975.ActorNr;
									if (269057 - 255956 != 13101)
									{
										continue;
									}
								}
								this.$distance$18978 = this.$tDir$18976.magnitude - this.$tObject$18974.collider.bounds.extents.x;
								if (223162 - 357487 == -134324)
								{
									continue;
								}
								if (this.$self_$18980.taLX04rrHw.sp > 90)
								{
									if (14551 - 467511 == -452959)
									{
										continue;
									}
									if (this.$distance$18978 > (float)12)
									{
										if (251292 - 332148 == -80855)
										{
											continue;
										}
										if (this.$distance$18978 < (float)24)
										{
											if (69120 - 341355 != -272235)
											{
												continue;
											}
											if (this.$self_$18980.taLX04rrHw.hasSkill(364))
											{
												if (298661 - 59342 != 239319)
												{
													continue;
												}
												if (this.$self_$18980.taLX04rrHw.isTimeOut("heavenPalm") == (float)0)
												{
													if (183958 - 448461 != -264503)
													{
														continue;
													}
													this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
													if (9008 - 170100 == -161091)
													{
														continue;
													}
													this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_heavenPalm(this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977, 2));
													if (4414 - 287018 != -282603)
													{
														if (PhotonClient.IsInitialized())
														{
															if (14549 - 104483 != -89934)
															{
																continue;
															}
															this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_heavenPalm2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977);
															if (23269 - 178769 != -155500)
															{
																continue;
															}
														}
														goto IL_9D5;
													}
													continue;
												}
											}
										}
									}
								}
								if (this.$self_$18980.taLX04rrHw.sp > 55)
								{
									if (46064 - 560382 != -514318)
									{
										continue;
									}
									if (this.$self_$18980.taLX04rrHw.hasSkill(272))
									{
										if (215331 - 539501 != -324170)
										{
											continue;
										}
										if (this.$self_$18980.taLX04rrHw.isTimeOut("ashura") == (float)0)
										{
											if (100777 - 69619 != 31158)
											{
												continue;
											}
											this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
											if (64006 - 363886 != -299880)
											{
												continue;
											}
											this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_ashura(this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977, 2));
											if (192464 - 225314 != -32849)
											{
												if (PhotonClient.IsInitialized())
												{
													if (127670 - 105976 != 21694)
													{
														continue;
													}
													this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_ashura2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977);
													if (6213 - 583653 == -577439)
													{
														continue;
													}
												}
												goto IL_9D5;
											}
											continue;
										}
									}
								}
								if (this.$self_$18980.taLX04rrHw.sp > 50)
								{
									if (18238 - 226206 == -207967)
									{
										continue;
									}
									if (this.$distance$18978 < (float)3)
									{
										if (15205 - 300117 != -284912)
										{
											continue;
										}
										if (this.$self_$18980.taLX04rrHw.hasSkill(354))
										{
											if (91688 - 334622 != -242934)
											{
												continue;
											}
											if (this.$self_$18980.taLX04rrHw.isTimeOut("rain&storm") == (float)0)
											{
												if (245742 - 265401 == -19658)
												{
													continue;
												}
												this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
												if (274863 - 378368 != -103505)
												{
													continue;
												}
												this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_rainStorm(this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977, 2));
												if (225912 - 182208 != 43705)
												{
													if (PhotonClient.IsInitialized())
													{
														if (187580 - 215170 != -27590)
														{
															continue;
														}
														this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_rainStorm2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977);
														if (141327 - 201184 != -59857)
														{
															continue;
														}
													}
													goto IL_9D5;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18980.taLX04rrHw.sp > 45)
								{
									if (102698 - 533402 == -430703)
									{
										continue;
									}
									if (this.$distance$18978 < (float)2)
									{
										if (12057 - 175081 == -163023)
										{
											continue;
										}
										if (this.$self_$18980.taLX04rrHw.hasSkill(254))
										{
											if (4120 - 165872 == -161751)
											{
												continue;
											}
											if (this.$self_$18980.taLX04rrHw.isTimeOut("risingDragons") == (float)0)
											{
												if (164545 - 411815 != -247270)
												{
													continue;
												}
												this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
												if (100714 - 346529 != -245815)
												{
													continue;
												}
												this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_risingDragons(this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977, 2));
												if (13376 - 499263 != -485887)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (59849 - 245063 != -185214)
													{
														continue;
													}
													this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_risingDragons2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977);
													if (81503 - 538671 != -457168)
													{
														continue;
													}
												}
												goto IL_9D5;
											}
										}
									}
								}
								if (this.$self_$18980.taLX04rrHw.sp > 40)
								{
									if (166015 - 407912 != -241897)
									{
										continue;
									}
									if (this.$distance$18978 < (float)3)
									{
										if (79663 - 361621 != -281958)
										{
											continue;
										}
										if (this.$self_$18980.taLX04rrHw.hasSkill(322))
										{
											if (29652 - 328284 == -298631)
											{
												continue;
											}
											if (this.$self_$18980.taLX04rrHw.isTimeOut("stasisBlow") == (float)0)
											{
												if (28468 - 253428 == -224959)
												{
													continue;
												}
												this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
												if (20041 - 188531 == -168489)
												{
													continue;
												}
												this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_stasisBlow(this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977, 2));
												if (127393 - 403651 != -276257)
												{
													if (PhotonClient.IsInitialized())
													{
														if (73163 - 599023 == -525859)
														{
															continue;
														}
														this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_stasisBlow2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977);
														if (183900 - 500964 != -317064)
														{
															continue;
														}
													}
													goto IL_9D5;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18980.taLX04rrHw.sp > 35)
								{
									if (239390 - 142300 != 97090)
									{
										continue;
									}
									if (this.$distance$18978 < (float)3)
									{
										if (204290 - 222783 == -18492)
										{
											continue;
										}
										if (this.$self_$18980.taLX04rrHw.hasSkill(252))
										{
											if (117246 - 200543 != -83297)
											{
												continue;
											}
											if (this.$self_$18980.taLX04rrHw.isTimeOut("risingVortex") == (float)0)
											{
												if (48208 - 99118 == -50909)
												{
													continue;
												}
												this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
												if (177087 - 393593 != -216506)
												{
													continue;
												}
												this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_risingVortex(this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977, 2));
												if (274612 - 354709 != -80097)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (168746 - 477048 == -308301)
													{
														continue;
													}
													this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_risingVortex2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977);
													if (174538 - 529112 != -354574)
													{
														continue;
													}
												}
												goto IL_9D5;
											}
										}
									}
								}
								if (this.$self_$18980.taLX04rrHw.sp > 30)
								{
									if (226811 - 491328 == -264516)
									{
										continue;
									}
									if (this.$distance$18978 < (float)3)
									{
										if (111979 - 458387 == -346407)
										{
											continue;
										}
										if (this.$self_$18980.taLX04rrHw.hasSkill(322))
										{
											if (117488 - 173915 == -56426)
											{
												continue;
											}
											if (this.$self_$18980.taLX04rrHw.isTimeOut("stasisBlow") == (float)0)
											{
												if (257627 - 417189 == -159561)
												{
													continue;
												}
												this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
												if (292726 - 373313 == -80586)
												{
													continue;
												}
												this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_stasisBlow(this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977, 2));
												if (14657 - 407037 != -392379)
												{
													if (PhotonClient.IsInitialized())
													{
														if (226369 - 459301 == -232931)
														{
															continue;
														}
														this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_stasisBlow2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977);
														if (294819 - 225285 == 69535)
														{
															continue;
														}
													}
													goto IL_9D5;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18980.taLX04rrHw.sp > 25)
								{
									if (39022 - 286145 == -247122)
									{
										continue;
									}
									if (this.$distance$18978 < (float)2)
									{
										if (197920 - 553909 != -355989)
										{
											continue;
										}
										if (this.$self_$18980.taLX04rrHw.hasSkill(223))
										{
											if (280074 - 237883 == 42192)
											{
												continue;
											}
											if (this.$self_$18980.taLX04rrHw.isTimeOut("pummel") == (float)0)
											{
												if (18627 - 57838 == -39210)
												{
													continue;
												}
												this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
												if (1249 - 86223 != -84974)
												{
													continue;
												}
												this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_pummel(this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977, 2));
												if (119311 - 531517 != -412205)
												{
													if (PhotonClient.IsInitialized())
													{
														if (1557 - 62001 != -60444)
														{
															continue;
														}
														this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_pummel2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, this.$tID$18977);
														if (117790 - 460553 != -342763)
														{
															continue;
														}
													}
													goto IL_9D5;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18980.taLX04rrHw.sp > 20)
								{
									if (23716 - 259602 == -235885)
									{
										continue;
									}
									if (this.$distance$18978 < (float)2)
									{
										if (71678 - 453970 != -382292)
										{
											continue;
										}
										if (this.$self_$18980.taLX04rrHw.hasSkill(314))
										{
											if (112308 - 116738 != -4430)
											{
												continue;
											}
											if (this.$self_$18980.taLX04rrHw.isTimeOut("waterCrane") == (float)0)
											{
												if (160954 - 241233 == -80278)
												{
													continue;
												}
												this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
												if (293030 - 439188 == -146157)
												{
													continue;
												}
												this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_waterCrane(this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0, 2));
												if (117757 - 568143 != -450386)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (280374 - 261884 == 18491)
													{
														continue;
													}
													this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_waterCrane2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0);
													if (71723 - 497148 != -425425)
													{
														continue;
													}
												}
												goto IL_9D5;
											}
										}
									}
								}
								if (this.$self_$18980.taLX04rrHw.sp > 15)
								{
									if (127818 - 565387 == -437568)
									{
										continue;
									}
									if (this.$distance$18978 < (float)4)
									{
										if (296626 - 6752 != 289874)
										{
											continue;
										}
										if (this.$self_$18980.taLX04rrHw.hasSkill(204))
										{
											if (264077 - 535482 == -271404)
											{
												continue;
											}
											if (this.$self_$18980.taLX04rrHw.isTimeOut("rushingFalcon") == (float)0)
											{
												if (243891 - 574246 != -330355)
												{
													continue;
												}
												this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
												if (6986 - 80443 != -73457)
												{
													continue;
												}
												this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_rushingFalcon(this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0, 2));
												if (96370 - 537041 != -440671)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (52244 - 366914 == -314669)
													{
														continue;
													}
													this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_rushingFalcon2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0);
													if (264909 - 240149 == 24761)
													{
														continue;
													}
												}
												goto IL_9D5;
											}
										}
									}
								}
								if (this.$self_$18980.taLX04rrHw.sp > 10)
								{
									if (178943 - 19700 != 159243)
									{
										continue;
									}
									if (this.$distance$18978 < (float)1)
									{
										if (249450 - 511776 != -262326)
										{
											continue;
										}
										if (this.$self_$18980.taLX04rrHw.hasSkill(302))
										{
											if (52414 - 39748 != 12666)
											{
												continue;
											}
											if (this.$self_$18980.taLX04rrHw.isTimeOut("drunkenFist") == (float)0)
											{
												if (295869 - 423 == 295447)
												{
													continue;
												}
												this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
												if (204907 - 374789 != -169882)
												{
													continue;
												}
												this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_drunkenFist(this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0, 2));
												if (80802 - 149868 != -69066)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (160924 - 189690 != -28766)
													{
														continue;
													}
													this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_drunkenFist2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0);
													if (123066 - 275486 != -152420)
													{
														continue;
													}
												}
												goto IL_9D5;
											}
										}
									}
								}
								if (this.$self_$18980.taLX04rrHw.sp > 5)
								{
									if (9067 - 181967 == -172899)
									{
										continue;
									}
									if (this.$distance$18978 < (float)2)
									{
										if (254812 - 138240 == 116573)
										{
											continue;
										}
										if (this.$self_$18980.taLX04rrHw.hasSkill(202))
										{
											if (111961 - 9180 == 102782)
											{
												continue;
											}
											if (this.$self_$18980.taLX04rrHw.isTimeOut("threeStep") == (float)0)
											{
												if (238420 - 467187 != -228767)
												{
													continue;
												}
												this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
												if (172391 - 460592 != -288201)
												{
													continue;
												}
												this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_threeStep(this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0, 2));
												if (246795 - 364009 != -117214)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (16628 - 55125 == -38496)
													{
														continue;
													}
													this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_threeStep2", this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0);
													if (284183 - 297104 != -12921)
													{
														continue;
													}
												}
												goto IL_9D5;
											}
										}
									}
								}
								if (this.$distance$18978 < (float)1)
								{
									if (100949 - 383103 == -282153)
									{
										continue;
									}
									if (this.$self_$18980.taLX04rrHw.isTimeOut("nAttack") == (float)0)
									{
										if (103118 - 86163 != 16955)
										{
											continue;
										}
										this.$self_$18980.xGcXiZHfhw = Time.time - this.$mTime$18979 - this.$self_$18980.uOFXDRYJjW;
										if (194218 - 17920 == 176299)
										{
											continue;
										}
										this.$self_$18980.zvaX8spaXR.StartCoroutine_Auto(this.$self_$18980.zvaX8spaXR.RPC_nAttack1(this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0));
										if (57017 - 169118 == -112100)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											goto IL_2122;
										}
										if (226843 - 485333 == -258489)
										{
											continue;
										}
										this.$self_$18980.zvaX8spaXR.ActionEvent("RPC_nAttack1", this.$self_$18980.transform.position, this.$tDir$18976.normalized, 0);
										if (264368 - 430732 != -166364)
										{
											continue;
										}
										goto IL_2122;
									}
								}
								this.$self_$18980.AI_state = "attack";
								if (110953 - 382312 == -271358)
								{
									continue;
								}
								this.$self_$18980.taLX04rrHw.vDirection = this.$tObject$18974.transform.position;
								if (24655 - 136895 != -112240)
								{
									continue;
								}
								this.$self_$18980.taLX04rrHw.vDirection.y = this.$self_$18980.transform.position.y;
								if (31365 - 223104 == -191738)
								{
									continue;
								}
								this.$self_$18980.taLX04rrHw.vMovement = (this.$self_$18980.taLX04rrHw.vDirection - this.$self_$18980.transform.position).normalized;
								if (204672 - 399348 == -194675)
								{
									continue;
								}
								this.$self_$18980.transform.rotation = Quaternion.LookRotation(this.$self_$18980.taLX04rrHw.vMovement);
								if (18324 - 362641 == -344316)
								{
									continue;
								}
								this.$self_$18980.taLX04rrHw.actionState = "run";
								if (156325 - 343344 == -187018)
								{
									continue;
								}
								this.$self_$18980.animation.Play("run");
								if (284418 - 207597 != 76821)
								{
									continue;
								}
								this.$self_$18980.animation.wrapMode = WrapMode.Loop;
								if (270598 - 423744 == -153145)
								{
									continue;
								}
								this.$self_$18980.taLX04rrHw.moveSpeed = Mathf.Lerp(this.$self_$18980.taLX04rrHw.moveSpeed, this.$self_$18980.taLX04rrHw.runSpeed, (float)4 * Time.deltaTime);
								if (30381 - 426669 == -396287)
								{
									continue;
								}
							}
						}
					}
					IL_9D5:
					this.$self_$18980.uOFXDRYJjW = this.$self_$18980.uOFXDRYJjW + this.$mTime$18979;
					if (5444 - 272080 != -266635)
					{
						this.YieldDefault(1);
						if (182531 - 422611 == -240080)
						{
							break;
						}
					}
				}
				Block_15:
				goto IL_2455;
				IL_228:
				return this.Yield(5, new WaitForSeconds(0.6f));
				Block_51:
				IL_E93:
				goto IL_2455;
				IL_104F:
				IL_115E:
				Block_129:
				goto IL_1F5C;
				Block_130:
				goto IL_228;
				Block_157:
				goto IL_20E2;
				Block_183:
				goto IL_1E88;
				IL_1C62:
				return this.Yield(3, new WaitForSeconds(0.9f));
				Block_198:
				IL_1E88:
				IL_1F5C:
				Block_221:
				goto IL_E93;
				IL_20E2:
				return this.Yield(4, new WaitForSeconds(0.9f));
				IL_2122:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_2455:
				return false;
			}

			// Token: 0x060015D7 RID: 5591 RVA: 0x00234CD8 File Offset: 0x00232ED8
			internal static bool aMAw3EFLdYtDOI513TD()
			{
				return true;
			}

			// Token: 0x060015D8 RID: 5592 RVA: 0x00234CDC File Offset: 0x00232EDC
			internal static bool OR0bX5FOXaHMMjJXZJa()
			{
				return false;
			}

			// Token: 0x040012CE RID: 4814
			internal GameObject $tObject$18974;

			// Token: 0x040012CF RID: 4815
			internal CharacterControl $tChar$18975;

			// Token: 0x040012D0 RID: 4816
			internal Vector3 $tDir$18976;

			// Token: 0x040012D1 RID: 4817
			internal int $tID$18977;

			// Token: 0x040012D2 RID: 4818
			internal float $distance$18978;

			// Token: 0x040012D3 RID: 4819
			internal float $mTime$18979;

			// Token: 0x040012D4 RID: 4820
			internal ShadowPanda_AI $self_$18980;
		}
	}
}
