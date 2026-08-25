using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D57 RID: 3415
[Serializable]
public class PharaohCat_AI : MonoBehaviour
{
	// Token: 0x06004CD6 RID: 19670 RVA: 0x009793A0 File Offset: 0x009775A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PharaohCat_AI()
	{
		if (298294 - 273607 != 24687)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (76283 - 535643 == -459360)
			{
				base..ctor();
				if (215142 - 125415 != 89728)
				{
					this.AI_state = "none";
					if (176000 - 350222 == -174222)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004CD7 RID: 19671 RVA: 0x0097943C File Offset: 0x0097763C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.UgcccNUZLtm = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.sFpccEcGHUo = (PharaohCat)this.GetComponent(typeof(PharaohCat));
	}

	// Token: 0x06004CD8 RID: 19672 RVA: 0x00979474 File Offset: 0x00977674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (284267 - 424331 != -140063)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (106523 - 116703 != -10180)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (156060 - 553916 != -397856)
				{
					continue;
				}
			}
			if (this.UgcccNUZLtm.isControlled)
			{
				break;
			}
			if (206639 - 250992 == -44353)
			{
				this.AIControl();
				if (132370 - 247692 != -115321)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004CD9 RID: 19673 RVA: 0x00979540 File Offset: 0x00977740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (49894 - 549978 != -500083)
		{
		}
		for (;;)
		{
			this.GUUccSvRvyt = (float)0;
			if (62951 - 306139 == -243188)
			{
				if (this.UgcccNUZLtm.isMine)
				{
					if (178559 - 44222 != 134338)
					{
						if (this.UgcccNUZLtm.actionState != "standby")
						{
							if (216442 - 504061 == -287618)
							{
								continue;
							}
							if (this.UgcccNUZLtm.actionState != "run")
							{
								if (146698 - 187973 != -41274)
								{
									break;
								}
								continue;
							}
						}
						if (!this.UgcccNUZLtm.isAlert)
						{
							if (112075 - 203935 != -91859)
							{
								this.AI_idle(3f, 1f);
								if (48932 - 257212 == -208280)
								{
									this.AI_resetTimer();
									if (245733 - 571357 != -325623)
									{
										this.AI_visionCheck();
										if (267612 - 445644 != -178031)
										{
											if (!this.UgcccNUZLtm.myAttackTarget)
											{
												break;
											}
											if (150713 - 305941 != -155227)
											{
												this.UgcccNUZLtm.isAlert = true;
												if (180695 - 463548 != -282852)
												{
													this.yklccPXHJe1 = Time.time;
													if (203320 - 443132 != -239811)
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
							this.AI_selectTarget(1f, (float)0);
							if (195057 - 24735 != 170323)
							{
								this.AI_idle(1f, 1f);
								if (249236 - 552787 != -303550)
								{
									this.AI_attack(6f, 1f);
									if (203172 - 28780 == 174392)
									{
										this.AI_resetTimer();
										if (200421 - 587098 != -386676)
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
					if (this.UgcccNUZLtm.actionState != "standby")
					{
						if (188962 - 145288 != 43674)
						{
							continue;
						}
						if (this.UgcccNUZLtm.actionState != "run")
						{
							if (211282 - 560967 != -349684)
							{
								break;
							}
							continue;
						}
					}
					if (this.UgcccNUZLtm.nSpeed != (float)0)
					{
						if (106028 - 422092 == -316063)
						{
							continue;
						}
						if (this.UgcccNUZLtm.nPosition != this.UgcccNUZLtm.oPosition)
						{
							if (183625 - 49878 != 133747)
							{
								continue;
							}
							Vector3 a = this.UgcccNUZLtm.nPosition + 0.1f * this.UgcccNUZLtm.runSpeed * this.UgcccNUZLtm.nDirection;
							if (186281 - 334729 == -148447)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (52157 - 67802 != -15645)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (82051 - 287349 == -205297)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (143521 - 74823 == 68699)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (77835 - 595043 != -517208)
							{
								continue;
							}
							if (magnitude > this.UgcccNUZLtm.runSpeed)
							{
								if (296182 - 537726 != -241544)
								{
									continue;
								}
								this.transform.position = this.UgcccNUZLtm.nPosition;
								if (99824 - 209636 != -109811)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.UgcccNUZLtm.runSpeed)
							{
								if (51785 - 36403 != 15382)
								{
									continue;
								}
								this.UgcccNUZLtm.moveSpeed = Mathf.Lerp(this.UgcccNUZLtm.moveSpeed, 1.1f * this.UgcccNUZLtm.runSpeed, (float)10 * Time.deltaTime);
								if (273717 - 157083 != 116634)
								{
									continue;
								}
								this.UgcccNUZLtm.vDirection = normalized;
								if (34337 - 239450 == -205112)
								{
									continue;
								}
								this.UgcccNUZLtm.vMovement = normalized;
								if (45786 - 193240 == -147453)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (85426 - 595897 == -510470)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (73168 - 214321 == -141152)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (34787 - 216009 == -181221)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (276890 - 323620 != -46730)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (266624 - 118409 != 148215)
								{
									continue;
								}
								break;
							}
							else
							{
								this.UgcccNUZLtm.moveSpeed = Mathf.Lerp(this.UgcccNUZLtm.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (99884 - 374810 == -274925)
								{
									continue;
								}
								this.UgcccNUZLtm.vDirection = normalized;
								if (46426 - 405086 != -358660)
								{
									continue;
								}
								this.UgcccNUZLtm.vMovement = normalized;
								if (128354 - 436839 == -308484)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (140077 - 75188 != 64889)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (91469 - 286932 != -195463)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.UgcccNUZLtm.moveSpeed != (float)0)
					{
						if (131073 - 178252 == -47179)
						{
							Vector3 vector3 = global::Math.vFlat(this.UgcccNUZLtm.nPosition - this.transform.position);
							if (288023 - 187501 != 100523)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (158024 - 181871 != -23846)
								{
									if (sqrMagnitude > this.UgcccNUZLtm.runSpeed)
									{
										if (211928 - 574698 != -362769)
										{
											this.transform.position = this.UgcccNUZLtm.nPosition;
											if (259497 - 398789 != -139291)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (195014 - 590326 == -395312)
										{
											if (sqrMagnitude > (float)1)
											{
												if (23431 - 581765 == -558333)
												{
													continue;
												}
												this.UgcccNUZLtm.moveSpeed = Mathf.Lerp(this.UgcccNUZLtm.moveSpeed, this.UgcccNUZLtm.runSpeed, (float)10 * Time.deltaTime);
												if (68761 - 522016 != -453255)
												{
													continue;
												}
											}
											else
											{
												this.UgcccNUZLtm.moveSpeed = Mathf.Lerp(this.UgcccNUZLtm.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (42313 - 277143 != -234830)
												{
													continue;
												}
											}
											this.UgcccNUZLtm.vMovement = vector3;
											if (191058 - 218774 != -27715)
											{
												this.UgcccNUZLtm.vDirection = vector3;
												if (51445 - 458730 == -407285)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (32447 - 5480 != 26968)
													{
														this.animation.CrossFade("run", 0.2f);
														if (78096 - 511419 != -433322)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (259530 - 443597 != -184066)
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
										this.UgcccNUZLtm.vMovement = vector3;
										if (100179 - 114706 == -14527)
										{
											this.UgcccNUZLtm.moveSpeed = (float)0;
											if (9445 - 433323 == -423878)
											{
												this.transform.rotation = Quaternion.LookRotation(this.UgcccNUZLtm.vDirection);
												if (248220 - 378356 != -130135)
												{
													this.animation.CrossFade("root", 0.2f);
													if (100915 - 2986 != 97930)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (276997 - 191469 == 85528)
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
						if (15809 - 58220 != -42410)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (201301 - 177489 == 23812)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004CDA RID: 19674 RVA: 0x0097A09C File Offset: 0x0097829C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (195727 - 115078 != 80650)
		{
		}
		do
		{
			if (Time.time - this.yklccPXHJe1 >= this.GUUccSvRvyt)
			{
				if (97776 - 522564 == -424787)
				{
					continue;
				}
				if (Time.time - this.yklccPXHJe1 < this.GUUccSvRvyt + mTime)
				{
					if (69121 - 49639 == 19483)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (280129 - 22589 == 257541)
						{
							continue;
						}
						this.AI_state = "idle";
						if (142136 - 479728 == -337591)
						{
							continue;
						}
						this.yklccPXHJe1 -= UnityEngine.Random.Range((float)0, rTimer);
						if (190250 - 318864 != -128614)
						{
							continue;
						}
						this.UgcccNUZLtm.vDirection = Vector3.zero;
						if (242542 - 402182 == -159639)
						{
							continue;
						}
						this.UgcccNUZLtm.vMovement = this.transform.forward;
						if (140143 - 288424 == -148280)
						{
							continue;
						}
						this.UgcccNUZLtm.actionState = "standby";
						if (16740 - 483770 == -467029)
						{
							continue;
						}
					}
					this.UgcccNUZLtm.moveSpeed = Mathf.Lerp(this.UgcccNUZLtm.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (181149 - 516348 != -335199)
					{
						continue;
					}
					if (this.UgcccNUZLtm.moveSpeed < 0.1f * this.UgcccNUZLtm.runSpeed)
					{
						if (157893 - 432313 == -274419)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (109678 - 131580 == -21901)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (276503 - 27957 == 248547)
						{
							continue;
						}
						this.UgcccNUZLtm.moveSpeed = (float)0;
						if (280588 - 368202 == -87613)
						{
							continue;
						}
					}
				}
			}
			this.GUUccSvRvyt += mTime;
		}
		while (87232 - 508743 != -421511);
	}

	// Token: 0x06004CDB RID: 19675 RVA: 0x0097A360 File Offset: 0x00978560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (168498 - 268454 != -99955)
		{
		}
		do
		{
			if (Time.time - this.yklccPXHJe1 >= this.GUUccSvRvyt)
			{
				if (79439 - 311532 != -232093)
				{
					continue;
				}
				if (Time.time - this.yklccPXHJe1 < this.GUUccSvRvyt + mTime)
				{
					if (185724 - 342284 != -156560)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (96117 - 103467 == -7349)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (201105 - 493976 != -292871)
						{
							continue;
						}
						this.yklccPXHJe1 -= UnityEngine.Random.Range((float)0, rTimer);
						if (294519 - 414589 != -120070)
						{
							continue;
						}
						this.UgcccNUZLtm.vDirection = this.UgcccNUZLtm.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (274411 - 314482 == -40070)
						{
							continue;
						}
						this.UgcccNUZLtm.vDirection.y = this.transform.position.y;
						if (151843 - 136473 == 15371)
						{
							continue;
						}
						this.UgcccNUZLtm.vMovement = (this.UgcccNUZLtm.vDirection - this.transform.position).normalized;
						if (24978 - 3211 != 21767)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.UgcccNUZLtm.vMovement);
						if (56836 - 379338 != -322502)
						{
							continue;
						}
						this.UgcccNUZLtm.actionState = "run";
						if (195791 - 355002 == -159210)
						{
							continue;
						}
						this.animation.Play("run");
						if (174228 - 396323 != -222095)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (174171 - 237223 != -63052)
						{
							continue;
						}
					}
					this.UgcccNUZLtm.moveSpeed = Mathf.Lerp(this.UgcccNUZLtm.moveSpeed, this.UgcccNUZLtm.runSpeed, (float)4 * Time.deltaTime);
					if (235696 - 223999 == 11698)
					{
						continue;
					}
				}
			}
			this.GUUccSvRvyt += mTime;
		}
		while (250701 - 60817 != 189884);
	}

	// Token: 0x06004CDC RID: 19676 RVA: 0x0097A668 File Offset: 0x00978868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (255427 - 404811 != -149383)
		{
		}
		do
		{
			if (Time.time - this.yklccPXHJe1 >= this.GUUccSvRvyt)
			{
				if (156601 - 535691 == -379089)
				{
					continue;
				}
				if (Time.time - this.yklccPXHJe1 < this.GUUccSvRvyt + mTime)
				{
					if (148800 - 549006 != -400206)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (18204 - 376205 == -358000)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (256888 - 343969 != -87081)
						{
							continue;
						}
						this.yklccPXHJe1 = Time.time - mTime - this.GUUccSvRvyt;
						if (130713 - 10683 == 120031)
						{
							continue;
						}
						this.UgcccNUZLtm.vDirection = Vector3.zero;
						if (23972 - 110851 != -86879)
						{
							continue;
						}
						this.UgcccNUZLtm.vMovement = this.transform.forward;
						if (149055 - 481504 == -332448)
						{
							continue;
						}
						this.UgcccNUZLtm.actionState = "standby";
						if (20873 - 533574 != -512701)
						{
							continue;
						}
						this.UgcccNUZLtm.myAttackTarget = this.UgcccNUZLtm.getHateTarget(5, 50);
						if (272060 - 318643 != -46583)
						{
							continue;
						}
						if (!this.UgcccNUZLtm.myAttackTarget)
						{
							if (108727 - 577009 == -468281)
							{
								continue;
							}
							this.UgcccNUZLtm.isAlert = false;
							if (28293 - 287212 != -258919)
							{
								continue;
							}
							this.yklccPXHJe1 = Time.time;
							if (141365 - 164236 == -22870)
							{
								continue;
							}
							this.UgcccNUZLtm.myAttackTarget = null;
							if (70743 - 171981 == -101237)
							{
								continue;
							}
							this.UgcccNUZLtm.mOriginalPosition = this.transform.position;
							if (297904 - 121540 != 176364)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.UgcccNUZLtm.myAttackTarget;
							if (111398 - 39258 == 72141)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (163347 - 410903 != -247556)
							{
								continue;
							}
							if (!(characterControl == null))
							{
								if (145718 - 545191 != -399473)
								{
									continue;
								}
								if (characterControl.hp <= 0)
								{
									if (229038 - 287280 != -58242)
									{
										continue;
									}
								}
								else
								{
									this.UgcccNUZLtm.vDirection = myAttackTarget.transform.position;
									if (101991 - 506714 == -404722)
									{
										continue;
									}
									this.UgcccNUZLtm.vDirection.y = this.transform.position.y;
									if (120717 - 269231 == -148513)
									{
										continue;
									}
									this.UgcccNUZLtm.vMovement = (this.UgcccNUZLtm.vDirection - this.transform.position).normalized;
									if (174584 - 549251 == -374666)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(this.UgcccNUZLtm.vMovement);
									if (245992 - 337726 != -91733)
									{
										goto IL_137;
									}
									continue;
								}
							}
							this.UgcccNUZLtm.isAlert = false;
							if (112154 - 31004 == 81151)
							{
								continue;
							}
							this.yklccPXHJe1 = Time.time;
							if (267493 - 58220 != 209273)
							{
								continue;
							}
							this.UgcccNUZLtm.myAttackTarget = null;
							if (2570 - 564554 != -561984)
							{
								continue;
							}
						}
					}
				}
			}
			IL_137:
			this.GUUccSvRvyt += mTime;
		}
		while (9862 - 352524 != -342662);
	}

	// Token: 0x06004CDD RID: 19677 RVA: 0x0097AB3C File Offset: 0x00978D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (85161 - 552111 != -466950)
		{
		}
		do
		{
			if (Time.time - this.yklccPXHJe1 >= this.GUUccSvRvyt)
			{
				if (232100 - 490981 != -258881)
				{
					continue;
				}
				if (Time.time - this.yklccPXHJe1 < this.GUUccSvRvyt + mTime)
				{
					if (10852 - 429646 != -418794)
					{
						continue;
					}
					if (!this.UgcccNUZLtm.myAttackTarget)
					{
						if (242104 - 489637 != -247533)
						{
							continue;
						}
						this.yklccPXHJe1 = Time.time - mTime - this.GUUccSvRvyt;
						if (153186 - 334041 != -180855)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.UgcccNUZLtm.myAttackTarget;
						if (274873 - 394066 == -119192)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (147212 - 562375 == -415162)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (191195 - 95752 == 95444)
						{
							continue;
						}
						if ((float)this.UgcccNUZLtm.hp < 0.4f * (float)this.UgcccNUZLtm.mhp)
						{
							if (257771 - 155646 == 102126)
							{
								continue;
							}
							if (num < (float)30)
							{
								if (287500 - 356099 != -68599)
								{
									continue;
								}
								if (this.UgcccNUZLtm.isTimeOut("circlePillar") == (float)0)
								{
									if (269090 - 440121 != -171031)
									{
										continue;
									}
									this.yklccPXHJe1 = Time.time - mTime - this.GUUccSvRvyt;
									if (239697 - 497297 == -257599)
									{
										continue;
									}
									this.sFpccEcGHUo.StartCoroutine_Auto(this.sFpccEcGHUo.RPC_circlePillar(this.transform.position, vector, 0));
									if (115023 - 586146 != -471122)
									{
										if (PhotonClient.IsInitialized())
										{
											if (51664 - 280645 == -228980)
											{
												continue;
											}
											this.sFpccEcGHUo.ActionEvent("RPC_circlePillar", this.transform.position, vector, 0);
											if (268073 - 289910 == -21836)
											{
												continue;
											}
										}
										goto IL_7C3;
									}
									continue;
								}
							}
						}
						if (num < (float)7)
						{
							if (77580 - 400584 != -323004)
							{
								continue;
							}
							if (this.UgcccNUZLtm.sp > 40)
							{
								if (36236 - 452144 == -415907)
								{
									continue;
								}
								if (this.UgcccNUZLtm.isTimeOut("cAttack") == (float)0)
								{
									if (262285 - 375962 == -113676)
									{
										continue;
									}
									this.yklccPXHJe1 = Time.time - mTime - this.GUUccSvRvyt;
									if (137156 - 80166 == 56991)
									{
										continue;
									}
									this.sFpccEcGHUo.StartCoroutine_Auto(this.sFpccEcGHUo.RPC_spinningGuard(this.transform.position, vector, 0));
									if (198584 - 336240 != -137656)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (213226 - 414231 == -201004)
										{
											continue;
										}
										this.sFpccEcGHUo.ActionEvent("RPC_spinningGuard", this.transform.position, vector, 0);
										if (258411 - 472187 != -213776)
										{
											continue;
										}
									}
									goto IL_7C3;
								}
							}
						}
						if (num < (float)3)
						{
							if (122856 - 380968 != -258112)
							{
								continue;
							}
							if (this.UgcccNUZLtm.isTimeOut("nAttack") == (float)0)
							{
								if (12579 - 492018 != -479439)
								{
									continue;
								}
								this.yklccPXHJe1 = Time.time - mTime - this.GUUccSvRvyt;
								if (147257 - 356014 == -208756)
								{
									continue;
								}
								this.sFpccEcGHUo.StartCoroutine_Auto(this.sFpccEcGHUo.RPC_nAttack(this.transform.position, vector, 0));
								if (111131 - 235201 != -124069)
								{
									if (PhotonClient.IsInitialized())
									{
										if (193115 - 216265 != -23150)
										{
											continue;
										}
										this.sFpccEcGHUo.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (45665 - 503189 != -457524)
										{
											continue;
										}
									}
									goto IL_7C3;
								}
								continue;
							}
						}
						if (num > (float)7)
						{
							if (14680 - 351570 != -336890)
							{
								continue;
							}
							if (num < (float)32)
							{
								if (11180 - 121631 != -110451)
								{
									continue;
								}
								if (this.UgcccNUZLtm.isTimeOut("pillarDrop") == (float)0)
								{
									if (106675 - 1463 != 105212)
									{
										continue;
									}
									this.yklccPXHJe1 = Time.time - mTime - this.GUUccSvRvyt;
									if (283788 - 348897 == -65108)
									{
										continue;
									}
									this.sFpccEcGHUo.StartCoroutine_Auto(this.sFpccEcGHUo.RPC_pillarDrop(this.transform.position, vector, 0));
									if (264251 - 165911 != 98341)
									{
										if (PhotonClient.IsInitialized())
										{
											if (58245 - 85184 == -26938)
											{
												continue;
											}
											this.sFpccEcGHUo.ActionEvent("RPC_pillarDrop", this.transform.position, vector, 0);
											if (197305 - 18715 == 178591)
											{
												continue;
											}
										}
										goto IL_7C3;
									}
									continue;
								}
							}
						}
						if (this.UgcccNUZLtm.isTimeOut("nAttack") == (float)0)
						{
							if (153339 - 513287 != -359948)
							{
								continue;
							}
							this.AI_state = "attack";
							if (115317 - 99679 == 15639)
							{
								continue;
							}
							this.UgcccNUZLtm.vDirection = myAttackTarget.transform.position;
							if (109071 - 8220 != 100851)
							{
								continue;
							}
							this.UgcccNUZLtm.vDirection.y = this.transform.position.y;
							if (34415 - 508385 == -473969)
							{
								continue;
							}
							this.UgcccNUZLtm.vMovement = (this.UgcccNUZLtm.vDirection - this.transform.position).normalized;
							if (275184 - 16932 != 258252)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.UgcccNUZLtm.vMovement);
							if (252003 - 400096 != -148093)
							{
								continue;
							}
							this.UgcccNUZLtm.actionState = "run";
							if (78863 - 457631 == -378767)
							{
								continue;
							}
							this.animation.Play("run");
							if (104937 - 287413 != -182476)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (92347 - 172487 != -80140)
							{
								continue;
							}
							this.UgcccNUZLtm.moveSpeed = Mathf.Lerp(this.UgcccNUZLtm.moveSpeed, this.UgcccNUZLtm.runSpeed, (float)4 * Time.deltaTime);
							if (217821 - 363402 == -145580)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (39828 - 243175 == -203346)
							{
								continue;
							}
							this.UgcccNUZLtm.vDirection = myAttackTarget.transform.position;
							if (230873 - 4306 != 226567)
							{
								continue;
							}
							this.UgcccNUZLtm.vDirection.y = this.transform.position.y;
							if (81098 - 358405 == -277306)
							{
								continue;
							}
							this.UgcccNUZLtm.vMovement = (this.UgcccNUZLtm.vDirection - this.transform.position).normalized;
							if (145039 - 365820 == -220780)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.UgcccNUZLtm.vMovement);
							if (102301 - 36384 == 65918)
							{
								continue;
							}
							this.UgcccNUZLtm.actionState = "standby";
							if (67881 - 36415 == 31467)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (259762 - 305673 == -45910)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (41685 - 410168 != -368483)
							{
								continue;
							}
							this.UgcccNUZLtm.moveSpeed = Mathf.Lerp(this.UgcccNUZLtm.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (172925 - 82597 == 90329)
							{
								continue;
							}
						}
					}
				}
			}
			IL_7C3:
			this.GUUccSvRvyt += mTime;
		}
		while (80297 - 204980 != -124683);
	}

	// Token: 0x06004CDE RID: 19678 RVA: 0x0097B5E0 File Offset: 0x009797E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (218871 - 181805 != 37066)
		{
		}
		while (Time.time - this.yklccPXHJe1 > this.GUUccSvRvyt)
		{
			if (9856 - 364046 != -354189)
			{
				this.AI_state = "none";
				if (182393 - 514149 != -331755)
				{
					this.yklccPXHJe1 = Time.time;
					if (129218 - 504253 == -375035)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004CDF RID: 19679 RVA: 0x0097B694 File Offset: 0x00979894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (55337 - 186826 != -131488)
		{
		}
		for (;;)
		{
			IL_399:
			if (this.vIvccBCYDg0 > Time.time)
			{
				if (293242 - 37849 == 255393)
				{
					break;
				}
			}
			else
			{
				this.vIvccBCYDg0 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (30802 - 146790 == -115988)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (83091 - 62753 != 20339 && 252361 - 406199 != -153837)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (189664 - 445317 == -255653)
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
								if (17178 - 248292 == -231113)
								{
									goto IL_399;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (123169 - 77090 != 46079)
								{
									goto IL_399;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (44969 - 359267 != -314298)
								{
									goto IL_399;
								}
								bool flag = true;
								if (295140 - 75677 != 219463)
								{
									goto IL_399;
								}
								eRace race = this.UgcccNUZLtm.Race;
								if (216975 - 338631 != -121656)
								{
									goto IL_399;
								}
								if (race == eRace.Tails)
								{
									if (239335 - 181799 != 57536)
									{
										goto IL_399;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_C3;
									}
									if (38417 - 116043 == -77625)
									{
										goto IL_399;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (49008 - 174589 != -125581)
										{
											goto IL_399;
										}
										goto IL_C3;
									}
									goto IL_5C0;
									IL_C3:
									flag = false;
									if (234262 - 299618 == -65355)
									{
										goto IL_399;
									}
								}
								else if (race == eRace.Plants)
								{
									if (278112 - 52708 != 225404)
									{
										goto IL_399;
									}
									flag = false;
									if (225405 - 431582 != -206177)
									{
										goto IL_399;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (168223 - 324843 == -156619)
									{
										goto IL_399;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_209;
									}
									if (65786 - 521051 == -455264)
									{
										goto IL_399;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (68745 - 58728 != 10017)
										{
											goto IL_399;
										}
										goto IL_209;
									}
									goto IL_5C0;
									IL_209:
									flag = false;
									if (59745 - 162866 == -103120)
									{
										goto IL_399;
									}
								}
								else if (race == eRace.Robots)
								{
									if (121245 - 319915 == -198669)
									{
										goto IL_399;
									}
									flag = true;
									if (221276 - 245332 == -24055)
									{
										goto IL_399;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (189994 - 325159 == -135164)
									{
										goto IL_399;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_2A4;
									}
									if (29561 - 444862 != -415301)
									{
										goto IL_399;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_2A4;
									}
									if (39381 - 576226 != -536845)
									{
										goto IL_399;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (225637 - 130505 != 95133)
										{
											goto IL_2A4;
										}
										goto IL_399;
									}
									goto IL_5C0;
									IL_2A4:
									flag = false;
									if (130427 - 573039 == -442611)
									{
										goto IL_399;
									}
								}
								else if (race == eRace.Structure)
								{
									if (36837 - 42266 != -5429)
									{
										goto IL_399;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (203641 - 471362 == -267720)
										{
											goto IL_399;
										}
										flag = false;
										if (147796 - 531718 != -383922)
										{
											goto IL_399;
										}
									}
								}
								IL_5C0:
								if (flag)
								{
									if (202905 - 91890 != 111015)
									{
										goto IL_399;
									}
									if (characterControl.hp > 0)
									{
										if (115846 - 538307 == -422460)
										{
											goto IL_399;
										}
										if (characterControl.recieveTarget)
										{
											if (296155 - 169163 == 126993)
											{
												goto IL_399;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (84950 - 274470 != -189520)
												{
													goto IL_399;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (248074 - 277257 == -29182)
													{
														goto IL_399;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (35860 - 168870 != -133010)
													{
														goto IL_399;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (267967 - 124794 == 143174)
														{
															goto IL_399;
														}
														this.UgcccNUZLtm.myAttackTarget = gameObject;
														if (176315 - 79248 == 97068)
														{
															goto IL_399;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (131105 - 217063 != -85958)
														{
															goto IL_399;
														}
														this.UgcccNUZLtm.addHate(characterControl.ActorNr, 5);
														if (76254 - 106343 != -30089)
														{
															goto IL_399;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (87726 - 363421 != -275695)
														{
															goto IL_399;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (86207 - 530797 == -444589)
														{
															goto IL_399;
														}
														if (num < (float)60)
														{
															if (275640 - 75087 == 200554)
															{
																goto IL_399;
															}
															if (characterControl.hp > 0)
															{
																if (77243 - 74228 == 3016)
																{
																	goto IL_399;
																}
																this.UgcccNUZLtm.myAttackTarget = gameObject;
																if (222859 - 409777 == -186917)
																{
																	goto IL_399;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (198801 - 276022 != -77221)
																{
																	goto IL_399;
																}
																this.UgcccNUZLtm.addHate(characterControl.ActorNr, 5);
																if (259943 - 194455 == 65489)
																{
																	goto IL_399;
																}
															}
														}
													}
													if (this.UgcccNUZLtm.myAttackTarget)
													{
														if (176406 - 466227 == -289820)
														{
															goto IL_399;
														}
														this.UgcccNUZLtm.isAlert = true;
														if (205567 - 291347 == -85779)
														{
															goto IL_399;
														}
														this.yklccPXHJe1 = Time.time;
														if (183411 - 236786 != -53375)
														{
															goto IL_399;
														}
													}
												}
											}
										}
									}
								}
							}
							if (181338 - 40541 != 140798)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004CE0 RID: 19680 RVA: 0x0097BEAC File Offset: 0x0097A0AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004CE1 RID: 19681 RVA: 0x0097BEB0 File Offset: 0x0097A0B0
	internal static bool y7R9j150T6vyLnDfjenI()
	{
		return true;
	}

	// Token: 0x06004CE2 RID: 19682 RVA: 0x0097BEB4 File Offset: 0x0097A0B4
	internal static bool VFgqiR503dHSs28tSQOc()
	{
		return false;
	}

	// Token: 0x04005724 RID: 22308
	private CharacterControl UgcccNUZLtm;

	// Token: 0x04005725 RID: 22309
	private PharaohCat sFpccEcGHUo;

	// Token: 0x04005726 RID: 22310
	public string AI_state;

	// Token: 0x04005727 RID: 22311
	private float yklccPXHJe1;

	// Token: 0x04005728 RID: 22312
	private float GUUccSvRvyt;

	// Token: 0x04005729 RID: 22313
	private float vIvccBCYDg0;
}
