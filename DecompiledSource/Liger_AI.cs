using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CE1 RID: 3297
[Serializable]
public class Liger_AI : MonoBehaviour
{
	// Token: 0x060049FF RID: 18943 RVA: 0x0092BDA0 File Offset: 0x00929FA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Liger_AI()
	{
		if (41103 - 88305 != -47201)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (82117 - 593915 != -511797)
			{
				base..ctor();
				if (284465 - 82106 == 202359)
				{
					this.AI_state = "none";
					if (51149 - 102563 == -51414)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004A00 RID: 18944 RVA: 0x0092BE3C File Offset: 0x0092A03C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (144822 - 374 != 144449)
		{
		}
		for (;;)
		{
			this.LVVc5tnBFMo = this.transform;
			if (27530 - 477673 != -450142)
			{
				this.J5wc5XdDaNx = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (87519 - 406681 == -319162)
				{
					this.Di3c5OnPjHx = (Liger)this.GetComponent(typeof(Liger));
					if (239437 - 565166 != -325728)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004A01 RID: 18945 RVA: 0x0092BF04 File Offset: 0x0092A104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (295813 - 297537 != -1724)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (271613 - 264509 == 7105)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (18589 - 522800 != -504211)
				{
					continue;
				}
			}
			if (this.J5wc5XdDaNx.isControlled)
			{
				break;
			}
			if (80560 - 405847 != -325286)
			{
				this.AIControl();
				if (119286 - 503744 != -384457)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004A02 RID: 18946 RVA: 0x0092BFD0 File Offset: 0x0092A1D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (3726 - 93595 != -89869)
		{
		}
		for (;;)
		{
			this.rByc5vj1yYC = (float)0;
			if (38196 - 195245 == -157049)
			{
				if (this.J5wc5XdDaNx.isMine)
				{
					if (166487 - 261730 != -95242)
					{
						if (this.J5wc5XdDaNx.actionState != "standby")
						{
							if (93659 - 178640 == -84980)
							{
								continue;
							}
							if (this.J5wc5XdDaNx.actionState != "run")
							{
								if (62103 - 62249 != -145)
								{
									break;
								}
								continue;
							}
						}
						if (!this.J5wc5XdDaNx.isAlert)
						{
							if (43278 - 540266 == -496988)
							{
								if (!this.J5wc5XdDaNx.isSummon)
								{
									goto IL_9DF;
								}
								if (274004 - 448049 != -174045)
								{
									continue;
								}
								if (!(this.J5wc5XdDaNx.mSummoner != null))
								{
									goto IL_9DF;
								}
								if (273937 - 321863 == -47925)
								{
									continue;
								}
								Vector3 vector = this.J5wc5XdDaNx.mSummoner.transform.position - this.transform.position;
								if (254002 - 85802 == 168201)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)36)
								{
									if (275950 - 483256 == -207305)
									{
										continue;
									}
									this.AI_follow(this.J5wc5XdDaNx.mSummoner);
									if (60390 - 27566 == 32825)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (8537 - 278892 == -270354)
									{
										continue;
									}
									this.AI_resetTimer();
									if (173635 - 510940 == -337304)
									{
										continue;
									}
									this.AI_visionCheck();
									if (129882 - 378072 == -248189)
									{
										continue;
									}
								}
								IL_C3D:
								if (!this.J5wc5XdDaNx.myAttackTarget)
								{
									break;
								}
								if (77343 - 223451 != -146108)
								{
									continue;
								}
								this.J5wc5XdDaNx.isAlert = true;
								if (123078 - 503226 == -380147)
								{
									continue;
								}
								this.YaQc52Qmn0L = Time.time;
								if (219551 - 535373 != -315821)
								{
									break;
								}
								continue;
								IL_9DF:
								if (Game.mGameCode == 915)
								{
									if (63586 - 569285 != -505698)
									{
										this.AI_idle(3f, 1f);
										if (228549 - 529249 != -300699)
										{
											this.AI_goToPosition(this.J5wc5XdDaNx.mOriginalPosition, 6f, 2f);
											if (212764 - 180380 != 32385)
											{
												this.AI_resetTimer();
												if (41221 - 559357 != -518135)
												{
													this.AI_visionCheck();
													if (208870 - 579537 != -370666)
													{
														goto IL_C3D;
													}
												}
											}
										}
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (187116 - 486162 != -299045)
									{
										this.AI_resetTimer();
										if (260063 - 76257 != 183807)
										{
											this.AI_visionCheck();
											if (12902 - 327442 == -314540)
											{
												goto IL_C3D;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (124966 - 67359 == 57607)
							{
								this.AI_idle(3f, 1f);
								if (281495 - 304469 == -22974)
								{
									this.AI_attack(10f, (float)0);
									if (154668 - 521651 != -366982)
									{
										this.AI_resetTimer();
										if (226364 - 368305 != -141940)
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
					if (this.J5wc5XdDaNx.actionState != "standby")
					{
						if (194039 - 123452 != 70587)
						{
							continue;
						}
						if (this.J5wc5XdDaNx.actionState != "run")
						{
							if (289192 - 579134 != -289942)
							{
								continue;
							}
							break;
						}
					}
					if (this.J5wc5XdDaNx.nSpeed != (float)0)
					{
						if (15617 - 455727 != -440110)
						{
							continue;
						}
						if (this.J5wc5XdDaNx.nPosition != this.J5wc5XdDaNx.oPosition)
						{
							if (147194 - 557209 != -410015)
							{
								continue;
							}
							Vector3 a = this.J5wc5XdDaNx.nPosition + 0.1f * this.J5wc5XdDaNx.runSpeed * this.J5wc5XdDaNx.nDirection;
							if (205552 - 26743 != 178809)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.LVVc5tnBFMo.position);
							if (228585 - 188068 == 40518)
							{
								continue;
							}
							Vector3 normalized = vector2.normalized;
							if (125879 - 494555 == -368675)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.LVVc5tnBFMo.position);
							if (246866 - 556171 == -309304)
							{
								continue;
							}
							float magnitude = vector3.magnitude;
							if (238655 - 223659 == 14997)
							{
								continue;
							}
							if (magnitude > this.J5wc5XdDaNx.runSpeed)
							{
								if (266267 - 37679 != 228588)
								{
									continue;
								}
								this.LVVc5tnBFMo.position = this.J5wc5XdDaNx.nPosition;
								if (223647 - 538101 != -314453)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.J5wc5XdDaNx.runSpeed)
							{
								if (297605 - 316816 == -19210)
								{
									continue;
								}
								this.J5wc5XdDaNx.moveSpeed = Mathf.Lerp(this.J5wc5XdDaNx.moveSpeed, 1.1f * this.J5wc5XdDaNx.runSpeed, (float)10 * Time.deltaTime);
								if (265658 - 426725 != -161067)
								{
									continue;
								}
								this.J5wc5XdDaNx.vDirection = normalized;
								if (199143 - 511704 == -312560)
								{
									continue;
								}
								this.J5wc5XdDaNx.vMovement = normalized;
								if (191898 - 280841 != -88943)
								{
									continue;
								}
								if (Vector3.Dot(this.LVVc5tnBFMo.forward, normalized) > (float)0)
								{
									if (112924 - 460397 == -347472)
									{
										continue;
									}
									this.LVVc5tnBFMo.rotation = Quaternion.LookRotation(Vector3.Slerp(this.LVVc5tnBFMo.forward, normalized, (float)10 * Time.deltaTime));
									if (139930 - 566642 == -426711)
									{
										continue;
									}
								}
								else
								{
									this.LVVc5tnBFMo.rotation = Quaternion.LookRotation(normalized);
									if (260426 - 551860 == -291433)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (109140 - 200106 == -90965)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (45551 - 252650 != -207098)
								{
									break;
								}
								continue;
							}
							else
							{
								this.J5wc5XdDaNx.moveSpeed = Mathf.Lerp(this.J5wc5XdDaNx.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (247619 - 5762 == 241858)
								{
									continue;
								}
								this.J5wc5XdDaNx.vDirection = normalized;
								if (198528 - 39801 == 158728)
								{
									continue;
								}
								this.J5wc5XdDaNx.vMovement = normalized;
								if (189714 - 151341 != 38373)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (44215 - 363539 != -319324)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (217345 - 162720 != 54626)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.J5wc5XdDaNx.moveSpeed != (float)0)
					{
						if (160840 - 333969 != -173128)
						{
							Vector3 vector4 = global::Math.vFlat(this.J5wc5XdDaNx.nPosition - this.LVVc5tnBFMo.position);
							if (254246 - 188233 == 66013)
							{
								float sqrMagnitude = vector4.sqrMagnitude;
								if (268672 - 361190 != -92517)
								{
									if (sqrMagnitude > this.J5wc5XdDaNx.runSpeed)
									{
										if (289239 - 115615 != 173625)
										{
											this.LVVc5tnBFMo.position = this.J5wc5XdDaNx.nPosition;
											if (168867 - 557036 != -388168)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (234633 - 351096 != -116462)
										{
											if (sqrMagnitude > (float)1)
											{
												if (185677 - 343321 == -157643)
												{
													continue;
												}
												this.J5wc5XdDaNx.moveSpeed = Mathf.Lerp(this.J5wc5XdDaNx.moveSpeed, this.J5wc5XdDaNx.runSpeed, (float)10 * Time.deltaTime);
												if (299972 - 560425 == -260452)
												{
													continue;
												}
											}
											else
											{
												this.J5wc5XdDaNx.moveSpeed = Mathf.Lerp(this.J5wc5XdDaNx.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (263838 - 485868 != -222030)
												{
													continue;
												}
											}
											this.J5wc5XdDaNx.vMovement = vector4;
											if (162006 - 171946 == -9940)
											{
												this.J5wc5XdDaNx.vDirection = vector4;
												if (3133 - 295633 == -292500)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.LVVc5tnBFMo.forward, vector4, (float)10 * Time.deltaTime));
													if (232248 - 377478 == -145230)
													{
														this.animation.CrossFade("run", 0.2f);
														if (192928 - 59080 == 133848)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (202744 - 18097 == 184647)
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
										this.J5wc5XdDaNx.vMovement = vector4;
										if (211569 - 20739 == 190830)
										{
											this.J5wc5XdDaNx.moveSpeed = (float)0;
											if (131731 - 350455 == -218724)
											{
												this.transform.rotation = Quaternion.LookRotation(this.J5wc5XdDaNx.vDirection);
												if (45858 - 72178 != -26319)
												{
													this.animation.CrossFade("root", 0.2f);
													if (116097 - 176921 == -60824)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (125977 - 315480 != -189502)
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
						if (272599 - 308083 != -35483)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (288818 - 557125 == -268307)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A03 RID: 18947 RVA: 0x0092CD58 File Offset: 0x0092AF58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (210627 - 52712 != 157915)
		{
		}
		do
		{
			if (Time.time - this.YaQc52Qmn0L >= this.rByc5vj1yYC)
			{
				if (98057 - 2885 != 95172)
				{
					continue;
				}
				if (Time.time - this.YaQc52Qmn0L < this.rByc5vj1yYC + mTime)
				{
					if (136241 - 184576 != -48335)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (231923 - 383675 != -151752)
						{
							continue;
						}
						this.AI_state = "idle";
						if (188707 - 89605 != 99102)
						{
							continue;
						}
						this.YaQc52Qmn0L -= UnityEngine.Random.Range((float)0, rTimer);
						if (184008 - 6246 == 177763)
						{
							continue;
						}
						this.J5wc5XdDaNx.vDirection = Vector3.zero;
						if (129831 - 512526 != -382695)
						{
							continue;
						}
						this.J5wc5XdDaNx.vMovement = this.LVVc5tnBFMo.forward;
						if (209114 - 330274 != -121160)
						{
							continue;
						}
						this.J5wc5XdDaNx.actionState = "standby";
						if (290626 - 459557 == -168930)
						{
							continue;
						}
					}
					this.J5wc5XdDaNx.moveSpeed = Mathf.Lerp(this.J5wc5XdDaNx.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (243171 - 123129 == 120043)
					{
						continue;
					}
					if (this.J5wc5XdDaNx.moveSpeed < 0.1f * this.J5wc5XdDaNx.runSpeed)
					{
						if (109516 - 374463 == -264946)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (231732 - 137400 != 94332)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (2430 - 120028 != -117598)
						{
							continue;
						}
						this.J5wc5XdDaNx.moveSpeed = (float)0;
						if (210844 - 90981 != 119863)
						{
							continue;
						}
					}
				}
			}
			this.rByc5vj1yYC += mTime;
		}
		while (224252 - 192069 != 32183);
	}

	// Token: 0x06004A04 RID: 18948 RVA: 0x0092D01C File Offset: 0x0092B21C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (123874 - 325041 != -201167)
		{
		}
		for (;;)
		{
			this.J5wc5XdDaNx.vDirection = followObject.transform.position;
			if (163322 - 161656 != 1667)
			{
				this.J5wc5XdDaNx.vDirection.y = this.transform.position.y;
				if (184532 - 537163 == -352631)
				{
					this.J5wc5XdDaNx.vMovement = (this.J5wc5XdDaNx.vDirection - this.transform.position).normalized;
					if (237614 - 544227 != -306612)
					{
						this.transform.rotation = Quaternion.LookRotation(this.J5wc5XdDaNx.vMovement);
						if (145024 - 403324 == -258300)
						{
							this.J5wc5XdDaNx.actionState = "run";
							if (113381 - 44010 == 69371)
							{
								this.animation.Play("run");
								if (270204 - 313482 != -43277)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (293366 - 313901 == -20535)
									{
										this.J5wc5XdDaNx.moveSpeed = Mathf.Lerp(this.J5wc5XdDaNx.moveSpeed, this.J5wc5XdDaNx.runSpeed, (float)4 * Time.deltaTime);
										if (273569 - 385978 != -112408)
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

	// Token: 0x06004A05 RID: 18949 RVA: 0x0092D204 File Offset: 0x0092B404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_goToPosition(Vector3 tPosition, float mTime, float rTimer)
	{
		if (86637 - 88711 != -2073)
		{
		}
		do
		{
			if (Time.time - this.YaQc52Qmn0L >= this.rByc5vj1yYC)
			{
				if (205743 - 349984 == -144240)
				{
					continue;
				}
				if (Time.time - this.YaQc52Qmn0L < this.rByc5vj1yYC + mTime)
				{
					if (17847 - 100017 == -82169)
					{
						continue;
					}
					if (this.AI_state != "goToPosition")
					{
						if (135534 - 398812 == -263277)
						{
							continue;
						}
						this.AI_state = "goToPosition";
						if (277230 - 378093 != -100863)
						{
							continue;
						}
						this.YaQc52Qmn0L -= UnityEngine.Random.Range((float)0, rTimer);
						if (1319 - 232278 == -230958)
						{
							continue;
						}
					}
					Vector3 vector = this.LVVc5tnBFMo.position - tPosition;
					if (175192 - 349707 == -174514)
					{
						continue;
					}
					if (vector.sqrMagnitude > (float)1)
					{
						if (21066 - 298643 == -277576)
						{
							continue;
						}
						this.J5wc5XdDaNx.vDirection = tPosition;
						if (236438 - 23205 == 213234)
						{
							continue;
						}
						this.J5wc5XdDaNx.vDirection.y = this.LVVc5tnBFMo.position.y;
						if (14488 - 490274 == -475785)
						{
							continue;
						}
						this.J5wc5XdDaNx.vMovement = (tPosition - this.LVVc5tnBFMo.position).normalized;
						if (19632 - 572214 != -552582)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.J5wc5XdDaNx.vMovement);
						if (289400 - 526716 == -237315)
						{
							continue;
						}
						this.J5wc5XdDaNx.actionState = "run";
						if (62892 - 240105 == -177212)
						{
							continue;
						}
						this.animation.Play("run");
						if (203698 - 453972 == -250273)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (14317 - 124831 == -110513)
						{
							continue;
						}
						this.J5wc5XdDaNx.moveSpeed = Mathf.Lerp(this.J5wc5XdDaNx.moveSpeed, this.J5wc5XdDaNx.runSpeed, (float)4 * Time.deltaTime);
						if (121546 - 506172 == -384625)
						{
							continue;
						}
					}
					else
					{
						this.J5wc5XdDaNx.vDirection = this.LVVc5tnBFMo.position + this.J5wc5XdDaNx.mOriginalDirection;
						if (75623 - 537303 != -461680)
						{
							continue;
						}
						this.J5wc5XdDaNx.vMovement = this.J5wc5XdDaNx.mOriginalDirection;
						if (105142 - 208217 != -103075)
						{
							continue;
						}
						this.J5wc5XdDaNx.moveSpeed = (float)0;
						if (68721 - 392029 == -323307)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.J5wc5XdDaNx.vMovement);
						if (89004 - 192586 == -103581)
						{
							continue;
						}
						this.YaQc52Qmn0L = Time.time - mTime - this.rByc5vj1yYC;
						if (125541 - 438673 != -313132)
						{
							continue;
						}
					}
				}
			}
			this.rByc5vj1yYC += mTime;
		}
		while (282449 - 369904 != -87455);
	}

	// Token: 0x06004A06 RID: 18950 RVA: 0x0092D638 File Offset: 0x0092B838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (12658 - 351474 != -338816)
		{
		}
		do
		{
			if (Time.time - this.YaQc52Qmn0L >= this.rByc5vj1yYC)
			{
				if (189410 - 455969 != -266559)
				{
					continue;
				}
				if (Time.time - this.YaQc52Qmn0L < this.rByc5vj1yYC + mTime)
				{
					if (51421 - 301452 != -250031)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (246179 - 562570 == -316390)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (35276 - 213873 != -178597)
						{
							continue;
						}
						this.YaQc52Qmn0L -= UnityEngine.Random.Range((float)0, rTimer);
						if (114287 - 405361 != -291074)
						{
							continue;
						}
						this.J5wc5XdDaNx.vDirection = this.J5wc5XdDaNx.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (201878 - 597156 != -395278)
						{
							continue;
						}
						this.J5wc5XdDaNx.vDirection.y = this.LVVc5tnBFMo.position.y;
						if (95292 - 514164 != -418872)
						{
							continue;
						}
						this.J5wc5XdDaNx.vMovement = (this.J5wc5XdDaNx.vDirection - this.LVVc5tnBFMo.position).normalized;
						if (82047 - 341345 == -259297)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.J5wc5XdDaNx.vMovement);
						if (86254 - 46265 == 39990)
						{
							continue;
						}
						this.J5wc5XdDaNx.actionState = "run";
						if (209808 - 109145 != 100663)
						{
							continue;
						}
						this.animation.Play("run");
						if (158418 - 298683 != -140265)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (166561 - 263781 != -97220)
						{
							continue;
						}
					}
					this.J5wc5XdDaNx.moveSpeed = Mathf.Lerp(this.J5wc5XdDaNx.moveSpeed, this.J5wc5XdDaNx.runSpeed, (float)4 * Time.deltaTime);
					if (45702 - 390813 != -345111)
					{
						continue;
					}
				}
			}
			this.rByc5vj1yYC += mTime;
		}
		while (129248 - 430083 != -300835);
	}

	// Token: 0x06004A07 RID: 18951 RVA: 0x0092D940 File Offset: 0x0092BB40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (1727 - 441199 != -439471)
		{
		}
		do
		{
			if (Time.time - this.YaQc52Qmn0L >= this.rByc5vj1yYC)
			{
				if (131489 - 436623 == -305133)
				{
					continue;
				}
				if (Time.time - this.YaQc52Qmn0L < this.rByc5vj1yYC + mTime)
				{
					if (122664 - 434897 != -312233)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (104717 - 196493 == -91775)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (80625 - 455967 != -375342)
						{
							continue;
						}
						this.YaQc52Qmn0L = Time.time - mTime - this.rByc5vj1yYC;
						if (291830 - 515379 == -223548)
						{
							continue;
						}
						this.J5wc5XdDaNx.vDirection = Vector3.zero;
						if (75575 - 306638 == -231062)
						{
							continue;
						}
						this.J5wc5XdDaNx.vMovement = this.LVVc5tnBFMo.forward;
						if (87757 - 540914 == -453156)
						{
							continue;
						}
						this.J5wc5XdDaNx.actionState = "standby";
						if (10814 - 197399 != -186585)
						{
							continue;
						}
						this.J5wc5XdDaNx.myAttackTarget = this.J5wc5XdDaNx.getHateTarget(5, 50);
						if (248824 - 33585 != 215239)
						{
							continue;
						}
						if (!this.J5wc5XdDaNx.myAttackTarget)
						{
							if (139954 - 15559 != 124395)
							{
								continue;
							}
							this.J5wc5XdDaNx.isAlert = false;
							if (258857 - 465514 != -206657)
							{
								continue;
							}
							this.YaQc52Qmn0L = Time.time;
							if (181230 - 236824 != -55594)
							{
								continue;
							}
							this.J5wc5XdDaNx.myAttackTarget = null;
							if (186352 - 130700 == 55653)
							{
								continue;
							}
							if (Game.mGameCode == 915)
							{
								break;
							}
							if (142015 - 481247 == -339231)
							{
								continue;
							}
							this.J5wc5XdDaNx.mOriginalPosition = this.LVVc5tnBFMo.position;
							if (195845 - 376418 != -180573)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.J5wc5XdDaNx.myAttackTarget;
							if (157987 - 510248 != -352261)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (5183 - 10275 != -5092)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (284296 - 349791 == -65494)
								{
									continue;
								}
								this.J5wc5XdDaNx.isAlert = false;
								if (176873 - 393840 != -216967)
								{
									continue;
								}
								this.YaQc52Qmn0L = Time.time;
								if (113398 - 305679 != -192281)
								{
									continue;
								}
								this.J5wc5XdDaNx.myAttackTarget = null;
								if (255995 - 359701 == -103705)
								{
									continue;
								}
							}
							else
							{
								this.J5wc5XdDaNx.vDirection = myAttackTarget.transform.position;
								if (299740 - 441157 == -141416)
								{
									continue;
								}
								this.J5wc5XdDaNx.vDirection.y = this.LVVc5tnBFMo.position.y;
								if (263991 - 84921 != 179070)
								{
									continue;
								}
								this.J5wc5XdDaNx.vMovement = (this.J5wc5XdDaNx.vDirection - this.LVVc5tnBFMo.position).normalized;
								if (282963 - 148236 == 134728)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.J5wc5XdDaNx.vMovement);
								if (117536 - 90742 != 26794)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.rByc5vj1yYC += mTime;
		}
		while (226753 - 466425 != -239672);
	}

	// Token: 0x06004A08 RID: 18952 RVA: 0x0092DE18 File Offset: 0x0092C018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (101830 - 161266 != -59436)
		{
		}
		do
		{
			if (Time.time - this.YaQc52Qmn0L >= this.rByc5vj1yYC)
			{
				if (195661 - 506695 == -311033)
				{
					continue;
				}
				if (Time.time - this.YaQc52Qmn0L < this.rByc5vj1yYC + mTime)
				{
					if (106036 - 175843 != -69807)
					{
						continue;
					}
					if (!this.J5wc5XdDaNx.myAttackTarget)
					{
						if (138364 - 478776 == -340411)
						{
							continue;
						}
						this.YaQc52Qmn0L = Time.time - mTime - this.rByc5vj1yYC;
						if (215992 - 224996 != -9004)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.J5wc5XdDaNx.myAttackTarget;
						if (290449 - 482080 != -191631)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (200392 - 338048 == -137655)
						{
							continue;
						}
						Vector3 tDir = myAttackTarget.transform.position - this.LVVc5tnBFMo.position;
						if (297213 - 199798 != 97415)
						{
							continue;
						}
						int tID = 0;
						if (116558 - 238323 == -121764)
						{
							continue;
						}
						if (characterControl)
						{
							if (59430 - 537613 != -478183)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (115164 - 539710 != -424546)
							{
								continue;
							}
						}
						float num = tDir.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (102472 - 65043 == 37430)
						{
							continue;
						}
						if (num < (float)6)
						{
							if (14075 - 489145 != -475070)
							{
								continue;
							}
							if ((float)this.J5wc5XdDaNx.hp < 0.5f * (float)this.J5wc5XdDaNx.mhp)
							{
								if (89569 - 202038 != -112469)
								{
									continue;
								}
								if (this.Di3c5OnPjHx.mLigerType == eLiger.normal)
								{
									if (47303 - 39064 == 8240)
									{
										continue;
									}
									if (this.J5wc5XdDaNx.isTimeOut("crushingTiger") == (float)0)
									{
										if (76346 - 311099 != -234753)
										{
											continue;
										}
										this.YaQc52Qmn0L = Time.time - mTime - this.rByc5vj1yYC;
										if (20301 - 226874 != -206573)
										{
											continue;
										}
										this.Di3c5OnPjHx.StartCoroutine_Auto(this.Di3c5OnPjHx.RPC_crushingTiger(this.LVVc5tnBFMo.position, tDir, tID));
										if (216049 - 147537 != 68513)
										{
											if (PhotonClient.IsInitialized())
											{
												if (34707 - 152821 == -118113)
												{
													continue;
												}
												this.Di3c5OnPjHx.ActionEvent("RPC_crushingTiger", this.LVVc5tnBFMo.position, tDir, tID);
												if (209686 - 152732 != 56954)
												{
													continue;
												}
											}
											goto IL_3D1;
										}
										continue;
									}
								}
							}
						}
						if (num < (float)6)
						{
							if (147849 - 434547 != -286698)
							{
								continue;
							}
							if (num > (float)4)
							{
								if (10075 - 92645 != -82570)
								{
									continue;
								}
								if (this.Di3c5OnPjHx.mLigerType != eLiger.normal)
								{
									if (246110 - 67412 != 178698)
									{
										continue;
									}
									if (!Game.useAdvanceMode)
									{
										goto IL_A69;
									}
									if (132767 - 448817 == -316049)
									{
										continue;
									}
								}
								if (this.J5wc5XdDaNx.isTimeOut("leapingLion") == (float)0)
								{
									if (137166 - 222093 != -84927)
									{
										continue;
									}
									this.YaQc52Qmn0L = Time.time - mTime - this.rByc5vj1yYC;
									if (114304 - 276646 == -162341)
									{
										continue;
									}
									this.Di3c5OnPjHx.StartCoroutine_Auto(this.Di3c5OnPjHx.RPC_leapingLion(this.LVVc5tnBFMo.position, tDir, 0));
									if (43233 - 48590 != -5356)
									{
										if (PhotonClient.IsInitialized())
										{
											if (18584 - 22940 == -4355)
											{
												continue;
											}
											this.Di3c5OnPjHx.ActionEvent("RPC_leapingLion", this.LVVc5tnBFMo.position, tDir, 0);
											if (17197 - 524018 != -506821)
											{
												continue;
											}
										}
										goto IL_3D1;
									}
									continue;
								}
							}
						}
						IL_A69:
						if (num < (float)3)
						{
							if (279876 - 317033 != -37157)
							{
								continue;
							}
							if (this.J5wc5XdDaNx.isTimeOut("nAttack") == (float)0)
							{
								if (182774 - 499858 != -317084)
								{
									continue;
								}
								this.YaQc52Qmn0L = Time.time - mTime - this.rByc5vj1yYC;
								if (215768 - 371173 == -155404)
								{
									continue;
								}
								this.Di3c5OnPjHx.StartCoroutine_Auto(this.Di3c5OnPjHx.RPC_nAttack(this.LVVc5tnBFMo.position, tDir, 0));
								if (229003 - 302617 != -73613)
								{
									if (PhotonClient.IsInitialized())
									{
										if (223947 - 97767 != 126180)
										{
											continue;
										}
										this.Di3c5OnPjHx.ActionEvent("RPC_nAttack", this.LVVc5tnBFMo.position, tDir, 0);
										if (23574 - 287268 == -263693)
										{
											continue;
										}
									}
									goto IL_3D1;
								}
								continue;
							}
						}
						if (num < (float)9)
						{
							if (97633 - 428193 != -330560)
							{
								continue;
							}
							if (this.Di3c5OnPjHx.mLigerType == eLiger.normal)
							{
								if (58028 - 526607 == -468578)
								{
									continue;
								}
								if (this.J5wc5XdDaNx.isTimeOut("ligerSwing") == (float)0)
								{
									if (160007 - 365362 != -205355)
									{
										continue;
									}
									this.YaQc52Qmn0L = Time.time - mTime - this.rByc5vj1yYC;
									if (155928 - 217963 == -62034)
									{
										continue;
									}
									this.Di3c5OnPjHx.StartCoroutine_Auto(this.Di3c5OnPjHx.RPC_ligerSwing(this.LVVc5tnBFMo.position, tDir, tID));
									if (286138 - 23222 != 262916)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (289235 - 218206 != 71029)
										{
											continue;
										}
										this.Di3c5OnPjHx.ActionEvent("RPC_ligerSwing", this.LVVc5tnBFMo.position, tDir, tID);
										if (180265 - 549019 == -368753)
										{
											continue;
										}
									}
									goto IL_3D1;
								}
							}
						}
						this.AI_state = "attack";
						if (135240 - 278738 == -143497)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (224455 - 563318 == -338862)
							{
								continue;
							}
							this.J5wc5XdDaNx.vDirection = myAttackTarget.transform.position;
							if (108573 - 387323 != -278750)
							{
								continue;
							}
							this.J5wc5XdDaNx.vDirection.y = this.LVVc5tnBFMo.position.y;
							if (34009 - 270503 != -236494)
							{
								continue;
							}
							this.J5wc5XdDaNx.vMovement = (this.J5wc5XdDaNx.vDirection - this.LVVc5tnBFMo.position).normalized;
							if (13243 - 143245 != -130002)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.J5wc5XdDaNx.vMovement);
							if (96706 - 115158 == -18451)
							{
								continue;
							}
							this.J5wc5XdDaNx.actionState = "standby";
							if (247712 - 409753 != -162041)
							{
								continue;
							}
							this.animation.Play("root");
							if (215169 - 244642 != -29473)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (266532 - 427287 == -160754)
							{
								continue;
							}
							this.J5wc5XdDaNx.moveSpeed = (float)0;
							if (257245 - 446356 != -189111)
							{
								continue;
							}
						}
						else
						{
							this.J5wc5XdDaNx.vDirection = myAttackTarget.transform.position;
							if (28396 - 531684 == -503287)
							{
								continue;
							}
							this.J5wc5XdDaNx.vDirection.y = this.LVVc5tnBFMo.position.y;
							if (143925 - 437981 != -294056)
							{
								continue;
							}
							this.J5wc5XdDaNx.vMovement = (this.J5wc5XdDaNx.vDirection - this.LVVc5tnBFMo.position).normalized;
							if (204766 - 216200 != -11434)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.J5wc5XdDaNx.vMovement);
							if (61237 - 290512 == -229274)
							{
								continue;
							}
							this.J5wc5XdDaNx.actionState = "run";
							if (108350 - 231821 != -123471)
							{
								continue;
							}
							this.animation.Play("run");
							if (70872 - 478811 != -407939)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (57347 - 521427 != -464080)
							{
								continue;
							}
							this.J5wc5XdDaNx.moveSpeed = Mathf.Lerp(this.J5wc5XdDaNx.moveSpeed, this.J5wc5XdDaNx.runSpeed, (float)4 * Time.deltaTime);
							if (146500 - 121739 == 24762)
							{
								continue;
							}
						}
					}
				}
			}
			IL_3D1:
			this.rByc5vj1yYC += mTime;
		}
		while (121610 - 14926 == 106685);
	}

	// Token: 0x06004A09 RID: 18953 RVA: 0x0092E980 File Offset: 0x0092CB80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (96426 - 59321 != 37106)
		{
		}
		while (Time.time - this.YaQc52Qmn0L > this.rByc5vj1yYC)
		{
			if (196436 - 415060 == -218624)
			{
				this.AI_state = "none";
				if (26775 - 413139 == -386364)
				{
					this.YaQc52Qmn0L = Time.time;
					if (276052 - 125430 == 150622)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004A0A RID: 18954 RVA: 0x0092EA34 File Offset: 0x0092CC34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (125372 - 314689 != -189317)
		{
		}
		for (;;)
		{
			IL_61E:
			if (this.n5vc5l66RWE > Time.time)
			{
				if (28882 - 406500 == -377618)
				{
					break;
				}
			}
			else
			{
				this.n5vc5l66RWE = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (86259 - 288860 != -202600)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.LVVc5tnBFMo.position, (float)32, this.gameObject.layer);
					if (216189 - 110843 != 105347)
					{
						if (121320 - 14057 == 107263)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (165200 - 517273 != -352072)
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
									if (181961 - 494510 == -312548)
									{
										goto IL_61E;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (39457 - 326287 != -286830)
									{
										goto IL_61E;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (69387 - 166762 != -97375)
									{
										goto IL_61E;
									}
									bool flag = true;
									if (293762 - 262580 == 31183)
									{
										goto IL_61E;
									}
									eRace race = this.J5wc5XdDaNx.Race;
									if (135865 - 538549 == -402683)
									{
										goto IL_61E;
									}
									if (race == eRace.Tails)
									{
										if (124293 - 363243 != -238950)
										{
											goto IL_61E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_3F2;
										}
										if (220471 - 200845 == 19627)
										{
											goto IL_61E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (167867 - 92520 != 75348)
											{
												goto IL_3F2;
											}
											goto IL_61E;
										}
										goto IL_1F;
										IL_3F2:
										flag = false;
										if (117140 - 49829 != 67311)
										{
											goto IL_61E;
										}
									}
									else if (race == eRace.Plants)
									{
										if (232724 - 27517 != 205207)
										{
											goto IL_61E;
										}
										flag = false;
										if (81446 - 132676 == -51229)
										{
											goto IL_61E;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (141598 - 148139 != -6541)
										{
											goto IL_61E;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2F3;
										}
										if (269555 - 140498 != 129057)
										{
											goto IL_61E;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (20964 - 524327 != -503363)
											{
												goto IL_61E;
											}
											goto IL_2F3;
										}
										goto IL_1F;
										IL_2F3:
										flag = false;
										if (247780 - 516637 == -268856)
										{
											goto IL_61E;
										}
									}
									else if (race == eRace.Robots)
									{
										if (12389 - 214696 != -202307)
										{
											goto IL_61E;
										}
										flag = true;
										if (151359 - 57971 != 93388)
										{
											goto IL_61E;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (208367 - 281686 != -73319)
										{
											goto IL_61E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_44F;
										}
										if (174985 - 190737 != -15752)
										{
											goto IL_61E;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_44F;
										}
										if (131704 - 272988 == -141283)
										{
											goto IL_61E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (116808 - 24515 != 92294)
											{
												goto IL_44F;
											}
											goto IL_61E;
										}
										goto IL_1F;
										IL_44F:
										flag = false;
										if (116610 - 246924 != -130314)
										{
											goto IL_61E;
										}
									}
									else if (race == eRace.Structure)
									{
										if (10418 - 236496 != -226078)
										{
											goto IL_61E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (143971 - 257152 != -113181)
											{
												goto IL_61E;
											}
											flag = false;
											if (68468 - 357947 == -289478)
											{
												goto IL_61E;
											}
										}
									}
									IL_1F:
									if (flag)
									{
										if (211398 - 535258 == -323859)
										{
											goto IL_61E;
										}
										if (characterControl.hp > 0)
										{
											if (152758 - 42473 != 110285)
											{
												goto IL_61E;
											}
											if (characterControl.recieveTarget)
											{
												if (293406 - 403919 != -110513)
												{
													goto IL_61E;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (219320 - 443232 == -223911)
													{
														goto IL_61E;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (103063 - 501826 != -398763)
														{
															goto IL_61E;
														}
														Vector3 vector = gameObject.transform.position - this.LVVc5tnBFMo.position;
														if (156624 - 168084 != -11460)
														{
															goto IL_61E;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (235135 - 274585 == -39449)
															{
																goto IL_61E;
															}
															this.J5wc5XdDaNx.myAttackTarget = gameObject;
															if (26298 - 562295 != -535997)
															{
																goto IL_61E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (127459 - 593803 != -466344)
															{
																goto IL_61E;
															}
															this.J5wc5XdDaNx.addHate(characterControl.ActorNr, 5);
															if (141454 - 27185 == 114270)
															{
																goto IL_61E;
															}
														}
														else
														{
															float num = Vector3.Angle(this.LVVc5tnBFMo.forward, gameObject.transform.position - this.LVVc5tnBFMo.position);
															if (284906 - 83733 == 201174)
															{
																goto IL_61E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (226526 - 468233 != -241707)
															{
																goto IL_61E;
															}
															if (num < (float)60)
															{
																if (57378 - 368708 == -311329)
																{
																	goto IL_61E;
																}
																if (characterControl.hp > 0)
																{
																	if (80637 - 453137 == -372499)
																	{
																		goto IL_61E;
																	}
																	this.J5wc5XdDaNx.myAttackTarget = gameObject;
																	if (96485 - 250034 != -153549)
																	{
																		goto IL_61E;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (24492 - 549062 == -524569)
																	{
																		goto IL_61E;
																	}
																	this.J5wc5XdDaNx.addHate(characterControl.ActorNr, 5);
																	if (256461 - 586319 != -329858)
																	{
																		goto IL_61E;
																	}
																}
															}
														}
														if (this.J5wc5XdDaNx.myAttackTarget)
														{
															if (40001 - 149088 == -109086)
															{
																goto IL_61E;
															}
															this.J5wc5XdDaNx.isAlert = true;
															if (194524 - 348107 != -153583)
															{
																goto IL_61E;
															}
															this.YaQc52Qmn0L = Time.time;
															if (3139 - 197839 == -194699)
															{
																goto IL_61E;
															}
														}
													}
												}
											}
										}
									}
								}
								if (290645 - 351929 == -61284)
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

	// Token: 0x06004A0B RID: 18955 RVA: 0x0092F24C File Offset: 0x0092D44C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004A0C RID: 18956 RVA: 0x0092F250 File Offset: 0x0092D450
	internal static bool E0Hv4x5woauVTeyi1ajw()
	{
		return true;
	}

	// Token: 0x06004A0D RID: 18957 RVA: 0x0092F254 File Offset: 0x0092D454
	internal static bool scKVwx5wEVbgNLvKxIn3()
	{
		return false;
	}

	// Token: 0x040054DC RID: 21724
	private Transform LVVc5tnBFMo;

	// Token: 0x040054DD RID: 21725
	private CharacterControl J5wc5XdDaNx;

	// Token: 0x040054DE RID: 21726
	private Liger Di3c5OnPjHx;

	// Token: 0x040054DF RID: 21727
	public string AI_state;

	// Token: 0x040054E0 RID: 21728
	private float YaQc52Qmn0L;

	// Token: 0x040054E1 RID: 21729
	private float rByc5vj1yYC;

	// Token: 0x040054E2 RID: 21730
	private float n5vc5l66RWE;
}
