using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AAB RID: 2731
[Serializable]
public class CamBotAI : MonoBehaviour
{
	// Token: 0x06003C38 RID: 15416 RVA: 0x007CB62C File Offset: 0x007C982C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CamBotAI()
	{
		if (293073 - 489077 != -196003)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (224228 - 570609 != -346380)
			{
				base..ctor();
				if (241849 - 475318 != -233468)
				{
					this.AI_state = "none";
					if (11168 - 452741 == -441573)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003C39 RID: 15417 RVA: 0x007CB6C8 File Offset: 0x007C98C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (298684 - 411566 != -112881)
		{
		}
		for (;;)
		{
			this.jBpWu3HEFQ = this.transform;
			if (220566 - 167895 != 52672)
			{
				this.DjLWyO5Idx = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (118098 - 230169 != -112070)
				{
					this.UZMWVhPrnY = (CamBot)this.GetComponent(typeof(CamBot));
					if (27029 - 174190 != -147160)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003C3A RID: 15418 RVA: 0x007CB790 File Offset: 0x007C9990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (11037 - 439252 != -428215)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (173384 - 457484 == -284099)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (277106 - 516008 == -238901)
				{
					continue;
				}
			}
			if (this.DjLWyO5Idx.isControlled)
			{
				break;
			}
			if (16784 - 199398 == -182614)
			{
				this.AIControl();
				if (75848 - 514906 == -439058)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003C3B RID: 15419 RVA: 0x007CB85C File Offset: 0x007C9A5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (33097 - 18347 != 14751)
		{
		}
		for (;;)
		{
			this.HVaWK15y4p = (float)0;
			if (193563 - 173786 == 19777)
			{
				if (this.DjLWyO5Idx.isMine)
				{
					if (1069 - 450177 == -449108)
					{
						if (this.DjLWyO5Idx.actionState != "standby")
						{
							if (251120 - 364820 != -113700)
							{
								continue;
							}
							if (this.DjLWyO5Idx.actionState != "run")
							{
								if (110274 - 510195 != -399921)
								{
									continue;
								}
								break;
							}
						}
						if (Game.mGameCode == 701)
						{
							if (216793 - 98406 != 118388)
							{
								this.AI_escape(5f, 1f);
								if (247068 - 344309 == -97241)
								{
									this.AI_selectTarget(1f, (float)0);
									if (11793 - 297901 != -286107)
									{
										this.AI_attack(1f, (float)0);
										if (15962 - 309615 == -293653)
										{
											this.AI_resetTimer();
											if (77322 - 424558 != -347235)
											{
												break;
											}
										}
									}
								}
							}
						}
						else if (!this.DjLWyO5Idx.isAlert)
						{
							if (177466 - 28928 == 148538)
							{
								if (Game.mGameCode == 916)
								{
									if (77741 - 200843 != -123102)
									{
										continue;
									}
									this.AI_idle(2f, 1f);
									if (90782 - 434298 != -343516)
									{
										continue;
									}
									this.AI_goToPosition(new Vector3((float)0, (float)50, (float)150), 5f, 1f);
									if (218270 - 169493 == 48778)
									{
										continue;
									}
									this.AI_resetTimer();
									if (117381 - 491230 != -373849)
									{
										continue;
									}
									this.AI_visionCheck();
									if (128433 - 215498 == -87064)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (274800 - 158433 == 116368)
									{
										continue;
									}
									this.AI_patrol(2f, 0.25f);
									if (19011 - 29675 != -10664)
									{
										continue;
									}
									this.AI_resetTimer();
									if (21455 - 476555 != -455100)
									{
										continue;
									}
									this.AI_visionCheck();
									if (89140 - 98211 != -9071)
									{
										continue;
									}
								}
								if (!this.DjLWyO5Idx.myAttackTarget)
								{
									break;
								}
								if (188333 - 250673 != -62339)
								{
									this.DjLWyO5Idx.isAlert = true;
									if (258356 - 481965 != -223608)
									{
										this.cPQWh1Hg8x = Time.time;
										if (213507 - 519656 != -306148)
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
							if (259891 - 541054 != -281162)
							{
								this.AI_idle(2f, 1f);
								if (99217 - 434193 == -334976)
								{
									this.AI_patrol(2f, 1f);
									if (192073 - 388738 == -196665)
									{
										this.AI_attack(4f, (float)0);
										if (62028 - 410976 != -348947)
										{
											this.AI_resetTimer();
											if (26469 - 196799 == -170330)
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
					if (this.DjLWyO5Idx.actionState != "standby")
					{
						if (47532 - 328552 == -281019)
						{
							continue;
						}
						if (this.DjLWyO5Idx.actionState != "run")
						{
							if (216487 - 555334 != -338846)
							{
								break;
							}
							continue;
						}
					}
					if (this.DjLWyO5Idx.nSpeed != (float)0)
					{
						if (165794 - 488672 == -322877)
						{
							continue;
						}
						if (this.DjLWyO5Idx.nPosition != this.DjLWyO5Idx.oPosition)
						{
							if (287180 - 399364 != -112184)
							{
								continue;
							}
							Vector3 a = this.DjLWyO5Idx.nPosition + 0.1f * this.DjLWyO5Idx.runSpeed * this.DjLWyO5Idx.nDirection;
							if (279424 - 225800 == 53625)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.jBpWu3HEFQ.position);
							if (86692 - 111881 != -25189)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (120388 - 597897 != -477509)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.jBpWu3HEFQ.position);
							if (213569 - 24228 == 189342)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (236070 - 315408 == -79337)
							{
								continue;
							}
							if (magnitude > this.DjLWyO5Idx.runSpeed)
							{
								if (15161 - 203905 == -188743)
								{
									continue;
								}
								this.jBpWu3HEFQ.position = this.DjLWyO5Idx.nPosition;
								if (218456 - 471491 != -253034)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.DjLWyO5Idx.runSpeed)
							{
								if (86844 - 385555 == -298710)
								{
									continue;
								}
								this.DjLWyO5Idx.moveSpeed = Mathf.Lerp(this.DjLWyO5Idx.moveSpeed, 1.1f * this.DjLWyO5Idx.runSpeed, (float)10 * Time.deltaTime);
								if (130065 - 583703 == -453637)
								{
									continue;
								}
								this.DjLWyO5Idx.vDirection = normalized;
								if (261405 - 211096 == 50310)
								{
									continue;
								}
								this.DjLWyO5Idx.vMovement = normalized;
								if (270048 - 449877 != -179829)
								{
									continue;
								}
								if (Vector3.Dot(this.jBpWu3HEFQ.forward, normalized) > (float)0)
								{
									if (28050 - 279411 == -251360)
									{
										continue;
									}
									this.jBpWu3HEFQ.rotation = Quaternion.LookRotation(Vector3.Slerp(this.jBpWu3HEFQ.forward, normalized, (float)10 * Time.deltaTime));
									if (155998 - 559404 == -403405)
									{
										continue;
									}
								}
								else
								{
									this.jBpWu3HEFQ.rotation = Quaternion.LookRotation(normalized);
									if (167518 - 584931 == -417412)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (288569 - 526885 == -238315)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (165354 - 305688 != -140334)
								{
									continue;
								}
								break;
							}
							else
							{
								this.DjLWyO5Idx.moveSpeed = Mathf.Lerp(this.DjLWyO5Idx.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (143971 - 92129 == 51843)
								{
									continue;
								}
								this.DjLWyO5Idx.vDirection = normalized;
								if (157008 - 94203 != 62805)
								{
									continue;
								}
								this.DjLWyO5Idx.vMovement = normalized;
								if (125073 - 130756 == -5682)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (17762 - 415935 != -398173)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (66004 - 274986 != -208982)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.DjLWyO5Idx.moveSpeed != (float)0)
					{
						if (55217 - 301720 != -246502)
						{
							Vector3 vector3 = global::Math.vFlat(this.DjLWyO5Idx.nPosition - this.jBpWu3HEFQ.position);
							if (245503 - 30102 != 215402)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (32045 - 142530 != -110484)
								{
									if (sqrMagnitude > this.DjLWyO5Idx.runSpeed)
									{
										if (13594 - 492192 == -478598)
										{
											this.jBpWu3HEFQ.position = this.DjLWyO5Idx.nPosition;
											if (91930 - 323657 != -231726)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (144113 - 379555 != -235441)
										{
											if (sqrMagnitude > (float)1)
											{
												if (248800 - 296785 != -47985)
												{
													continue;
												}
												this.DjLWyO5Idx.moveSpeed = Mathf.Lerp(this.DjLWyO5Idx.moveSpeed, this.DjLWyO5Idx.runSpeed, (float)10 * Time.deltaTime);
												if (242255 - 228353 == 13903)
												{
													continue;
												}
											}
											else
											{
												this.DjLWyO5Idx.moveSpeed = Mathf.Lerp(this.DjLWyO5Idx.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (228559 - 466366 == -237806)
												{
													continue;
												}
											}
											this.DjLWyO5Idx.vMovement = vector3;
											if (277682 - 233592 == 44090)
											{
												this.DjLWyO5Idx.vDirection = vector3;
												if (131285 - 134607 != -3321)
												{
													this.jBpWu3HEFQ.rotation = Quaternion.LookRotation(Vector3.Slerp(this.jBpWu3HEFQ.forward, vector3, (float)10 * Time.deltaTime));
													if (147245 - 120365 != 26881)
													{
														this.animation.CrossFade("run", 0.2f);
														if (187253 - 495520 != -308266)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (28463 - 503232 != -474768)
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
										this.DjLWyO5Idx.vMovement = vector3;
										if (143413 - 117845 != 25569)
										{
											this.DjLWyO5Idx.moveSpeed = (float)0;
											if (169210 - 533438 != -364227)
											{
												this.jBpWu3HEFQ.rotation = Quaternion.LookRotation(this.DjLWyO5Idx.vDirection);
												if (197111 - 70154 == 126957)
												{
													this.animation.CrossFade("root", 0.2f);
													if (115590 - 202188 != -86597)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (211143 - 487494 != -276350)
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
						if (275411 - 134599 == 140812)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (54254 - 526665 != -472410)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003C3C RID: 15420 RVA: 0x007CC5A0 File Offset: 0x007CA7A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (70696 - 296596 != -225900)
		{
		}
		do
		{
			if (Time.time - this.cPQWh1Hg8x >= this.HVaWK15y4p)
			{
				if (170850 - 121732 == 49119)
				{
					continue;
				}
				if (Time.time - this.cPQWh1Hg8x < this.HVaWK15y4p + mTime)
				{
					if (238963 - 30427 == 208537)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (174301 - 32089 != 142212)
						{
							continue;
						}
						this.AI_state = "idle";
						if (153875 - 565384 != -411509)
						{
							continue;
						}
						this.cPQWh1Hg8x -= UnityEngine.Random.Range((float)0, rTimer);
						if (221443 - 175445 == 45999)
						{
							continue;
						}
						this.DjLWyO5Idx.vDirection = Vector3.zero;
						if (292040 - 593900 == -301859)
						{
							continue;
						}
						this.DjLWyO5Idx.vMovement = this.jBpWu3HEFQ.forward;
						if (239470 - 367319 == -127848)
						{
							continue;
						}
						this.DjLWyO5Idx.actionState = "standby";
						if (192917 - 379105 == -186187)
						{
							continue;
						}
					}
					this.DjLWyO5Idx.moveSpeed = Mathf.Lerp(this.DjLWyO5Idx.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (30036 - 165353 != -135317)
					{
						continue;
					}
					if (this.DjLWyO5Idx.moveSpeed < 0.1f * this.DjLWyO5Idx.runSpeed)
					{
						if (11363 - 67007 != -55644)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (128351 - 566420 == -438068)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (107567 - 575 == 106993)
						{
							continue;
						}
						this.DjLWyO5Idx.moveSpeed = (float)0;
						if (298230 - 579130 != -280900)
						{
							continue;
						}
					}
				}
			}
			this.HVaWK15y4p += mTime;
		}
		while (103378 - 179481 == -76102);
	}

	// Token: 0x06003C3D RID: 15421 RVA: 0x007CC864 File Offset: 0x007CAA64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_goToPosition(Vector3 tPosition, float mTime, float rTimer)
	{
		if (228508 - 504660 != -276151)
		{
		}
		do
		{
			if (Time.time - this.cPQWh1Hg8x >= this.HVaWK15y4p)
			{
				if (1973 - 130001 == -128027)
				{
					continue;
				}
				if (Time.time - this.cPQWh1Hg8x < this.HVaWK15y4p + mTime)
				{
					if (16510 - 278913 == -262402)
					{
						continue;
					}
					if (this.AI_state != "goToPosition")
					{
						if (78253 - 588337 != -510084)
						{
							continue;
						}
						this.AI_state = "goToPosition";
						if (162129 - 599930 != -437801)
						{
							continue;
						}
						this.cPQWh1Hg8x -= UnityEngine.Random.Range((float)0, rTimer);
						if (245548 - 349449 == -103900)
						{
							continue;
						}
					}
					Vector3 vector = this.jBpWu3HEFQ.position - tPosition;
					if (275675 - 292593 != -16918)
					{
						continue;
					}
					if (vector.sqrMagnitude > (float)1)
					{
						if (172100 - 325580 == -153479)
						{
							continue;
						}
						this.DjLWyO5Idx.vDirection = tPosition;
						if (275937 - 360458 == -84520)
						{
							continue;
						}
						this.DjLWyO5Idx.vDirection.y = this.jBpWu3HEFQ.position.y;
						if (122821 - 133852 == -11030)
						{
							continue;
						}
						this.DjLWyO5Idx.vMovement = (tPosition - this.jBpWu3HEFQ.position).normalized;
						if (45409 - 140613 != -95204)
						{
							continue;
						}
						this.jBpWu3HEFQ.rotation = Quaternion.LookRotation(this.DjLWyO5Idx.vMovement);
						if (117372 - 440793 != -323421)
						{
							continue;
						}
						this.DjLWyO5Idx.actionState = "run";
						if (216710 - 372743 == -156032)
						{
							continue;
						}
						this.animation.Play("run");
						if (185416 - 183942 != 1474)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (196344 - 596481 != -400137)
						{
							continue;
						}
						this.DjLWyO5Idx.moveSpeed = Mathf.Lerp(this.DjLWyO5Idx.moveSpeed, this.DjLWyO5Idx.runSpeed, (float)4 * Time.deltaTime);
						if (147 - 467137 == -466989)
						{
							continue;
						}
					}
					else
					{
						this.DjLWyO5Idx.vDirection = this.jBpWu3HEFQ.position + this.DjLWyO5Idx.mOriginalDirection;
						if (142246 - 290214 != -147968)
						{
							continue;
						}
						this.DjLWyO5Idx.vMovement = this.DjLWyO5Idx.mOriginalDirection;
						if (172809 - 587160 != -414351)
						{
							continue;
						}
						this.DjLWyO5Idx.moveSpeed = (float)0;
						if (92562 - 249649 == -157086)
						{
							continue;
						}
						this.jBpWu3HEFQ.rotation = Quaternion.LookRotation(this.DjLWyO5Idx.vMovement);
						if (147341 - 503202 != -355861)
						{
							continue;
						}
						this.cPQWh1Hg8x = Time.time - mTime - this.HVaWK15y4p;
						if (42686 - 303940 != -261254)
						{
							continue;
						}
					}
				}
			}
			this.HVaWK15y4p += mTime;
		}
		while (109221 - 39118 != 70103);
	}

	// Token: 0x06003C3E RID: 15422 RVA: 0x007CCC98 File Offset: 0x007CAE98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (144370 - 67352 != 77019)
		{
		}
		do
		{
			if (Time.time - this.cPQWh1Hg8x >= this.HVaWK15y4p)
			{
				if (48389 - 452104 == -403714)
				{
					continue;
				}
				if (Time.time - this.cPQWh1Hg8x < this.HVaWK15y4p + mTime)
				{
					if (36146 - 225228 == -189081)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (95108 - 329082 != -233974)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (264340 - 572510 == -308169)
						{
							continue;
						}
						this.cPQWh1Hg8x -= UnityEngine.Random.Range((float)0, rTimer);
						if (36815 - 261421 == -224605)
						{
							continue;
						}
						this.DjLWyO5Idx.vDirection = this.DjLWyO5Idx.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (145684 - 129277 != 16407)
						{
							continue;
						}
						this.DjLWyO5Idx.vDirection.y = this.jBpWu3HEFQ.position.y;
						if (173420 - 235473 == -62052)
						{
							continue;
						}
						this.DjLWyO5Idx.vMovement = (this.DjLWyO5Idx.vDirection - this.jBpWu3HEFQ.position).normalized;
						if (178976 - 547101 == -368124)
						{
							continue;
						}
						this.jBpWu3HEFQ.rotation = Quaternion.LookRotation(this.DjLWyO5Idx.vMovement);
						if (211795 - 534362 == -322566)
						{
							continue;
						}
						this.DjLWyO5Idx.actionState = "run";
						if (16698 - 228223 == -211524)
						{
							continue;
						}
						this.animation.Play("run");
						if (177690 - 241664 == -63973)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (54150 - 414318 == -360167)
						{
							continue;
						}
					}
					this.DjLWyO5Idx.moveSpeed = Mathf.Lerp(this.DjLWyO5Idx.moveSpeed, this.DjLWyO5Idx.runSpeed, (float)4 * Time.deltaTime);
					if (99962 - 491863 == -391900)
					{
						continue;
					}
				}
			}
			this.HVaWK15y4p += mTime;
		}
		while (181377 - 392497 == -211119);
	}

	// Token: 0x06003C3F RID: 15423 RVA: 0x007CCFA0 File Offset: 0x007CB1A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (52059 - 38024 != 14035)
		{
		}
		do
		{
			if (Time.time - this.cPQWh1Hg8x >= this.HVaWK15y4p)
			{
				if (229214 - 327025 != -97811)
				{
					continue;
				}
				if (Time.time - this.cPQWh1Hg8x < this.HVaWK15y4p + mTime)
				{
					if (193485 - 383787 == -190301)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (285168 - 326425 == -41256)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (71235 - 33096 != 38139)
						{
							continue;
						}
						this.cPQWh1Hg8x = Time.time - mTime - this.HVaWK15y4p;
						if (273948 - 360033 != -86085)
						{
							continue;
						}
						this.DjLWyO5Idx.vDirection = Vector3.zero;
						if (168291 - 184422 == -16130)
						{
							continue;
						}
						this.DjLWyO5Idx.vMovement = this.jBpWu3HEFQ.forward;
						if (196410 - 575944 == -379533)
						{
							continue;
						}
						this.DjLWyO5Idx.actionState = "standby";
						if (116517 - 40088 != 76429)
						{
							continue;
						}
						this.DjLWyO5Idx.myAttackTarget = this.DjLWyO5Idx.getHateTarget(15, 40);
						if (70617 - 118477 == -47859)
						{
							continue;
						}
						if (!this.DjLWyO5Idx.myAttackTarget)
						{
							if (279578 - 465546 != -185968)
							{
								continue;
							}
							this.DjLWyO5Idx.isAlert = false;
							if (139053 - 35855 != 103198)
							{
								continue;
							}
							this.cPQWh1Hg8x = Time.time;
							if (190621 - 339459 != -148838)
							{
								continue;
							}
							this.DjLWyO5Idx.myAttackTarget = null;
							if (86463 - 384941 != -298478)
							{
								continue;
							}
							this.DjLWyO5Idx.mOriginalPosition = this.jBpWu3HEFQ.position;
							if (143611 - 271314 != -127703)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.DjLWyO5Idx.myAttackTarget;
							if (60599 - 103105 == -42505)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (111230 - 517881 == -406650)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (122688 - 232839 == -110150)
								{
									continue;
								}
								this.DjLWyO5Idx.isAlert = false;
								if (190800 - 160812 == 29989)
								{
									continue;
								}
								this.cPQWh1Hg8x = Time.time;
								if (162830 - 377187 != -214357)
								{
									continue;
								}
								this.DjLWyO5Idx.myAttackTarget = null;
								if (151053 - 365912 == -214858)
								{
									continue;
								}
							}
							else
							{
								this.DjLWyO5Idx.vDirection = myAttackTarget.transform.position;
								if (263992 - 188681 == 75312)
								{
									continue;
								}
								this.DjLWyO5Idx.vDirection.y = this.jBpWu3HEFQ.position.y;
								if (31400 - 474869 == -443468)
								{
									continue;
								}
								this.DjLWyO5Idx.vMovement = (this.DjLWyO5Idx.vDirection - this.jBpWu3HEFQ.position).normalized;
								if (142288 - 146390 != -4102)
								{
									continue;
								}
								this.jBpWu3HEFQ.rotation = Quaternion.LookRotation(this.DjLWyO5Idx.vMovement);
								if (212090 - 355497 == -143406)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.HVaWK15y4p += mTime;
		}
		while (238833 - 375451 == -136617);
	}

	// Token: 0x06003C40 RID: 15424 RVA: 0x007CD450 File Offset: 0x007CB650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (47243 - 259817 != -212574)
		{
		}
		do
		{
			if (Time.time - this.cPQWh1Hg8x >= this.HVaWK15y4p)
			{
				if (191554 - 23092 != 168462)
				{
					continue;
				}
				if (Time.time - this.cPQWh1Hg8x < this.HVaWK15y4p + mTime)
				{
					if (273769 - 539807 != -266038)
					{
						continue;
					}
					if (!this.DjLWyO5Idx.myAttackTarget)
					{
						if (31395 - 67362 == -35966)
						{
							continue;
						}
						this.cPQWh1Hg8x = Time.time - mTime - this.HVaWK15y4p;
						if (285777 - 436968 != -151190)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.DjLWyO5Idx.myAttackTarget;
						if (71299 - 90681 == -19381)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (99174 - 501410 == -402235)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.jBpWu3HEFQ.position;
						if (122223 - 124270 == -2046)
						{
							continue;
						}
						int num = 0;
						if (65508 - 147543 != -82035)
						{
							continue;
						}
						if (characterControl)
						{
							if (291624 - 594537 == -302912)
							{
								continue;
							}
							num = characterControl.ActorNr;
							if (5640 - 112440 == -106799)
							{
								continue;
							}
						}
						float num2 = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (249502 - 187856 != 61646)
						{
							continue;
						}
						if (num2 < (float)4)
						{
							if (99730 - 463852 != -364122)
							{
								continue;
							}
							if (this.DjLWyO5Idx.isTimeOut("emp") == (float)0)
							{
								if (39098 - 392199 != -353101)
								{
									continue;
								}
								this.cPQWh1Hg8x = Time.time - mTime - this.HVaWK15y4p;
								if (42232 - 554820 == -512587)
								{
									continue;
								}
								this.UZMWVhPrnY.StartCoroutine_Auto(this.UZMWVhPrnY.RPC_emp(this.jBpWu3HEFQ.position, this.jBpWu3HEFQ.forward, num));
								if (157153 - 555273 != -398120)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (7970 - 206168 != -198198)
									{
										continue;
									}
									this.UZMWVhPrnY.ActionEvent("RPC_emp", this.jBpWu3HEFQ.position, this.jBpWu3HEFQ.forward, num);
									if (38733 - 184359 != -145626)
									{
										continue;
									}
								}
								goto IL_680;
							}
						}
						if (num2 < (float)40)
						{
							if (282837 - 439890 != -157053)
							{
								continue;
							}
							if (this.DjLWyO5Idx.isTimeOut("nAttack") == (float)0)
							{
								if (160400 - 406594 != -246194)
								{
									continue;
								}
								this.cPQWh1Hg8x = Time.time - mTime - this.HVaWK15y4p;
								if (183555 - 49665 != 133891)
								{
									if (this.DjLWyO5Idx.moveSpeed > (float)1)
									{
										if (82035 - 469430 == -387394)
										{
											continue;
										}
										if (num != 0)
										{
											if (176885 - 502419 == -325533)
											{
												continue;
											}
											this.UZMWVhPrnY.StartCoroutine_Auto(this.UZMWVhPrnY.RPC_laserBackward(this.jBpWu3HEFQ.position, this.jBpWu3HEFQ.forward, num));
											if (285051 - 555550 != -270498)
											{
												if (PhotonClient.IsInitialized())
												{
													if (168464 - 333195 != -164731)
													{
														continue;
													}
													this.UZMWVhPrnY.ActionEvent("RPC_laserBackward", this.jBpWu3HEFQ.position, this.jBpWu3HEFQ.forward, num);
													if (231738 - 164675 == 67064)
													{
														continue;
													}
												}
												goto IL_656;
											}
											continue;
										}
									}
									this.UZMWVhPrnY.StartCoroutine_Auto(this.UZMWVhPrnY.RPC_laser(this.jBpWu3HEFQ.position, vector, num));
									if (133694 - 429932 != -296238)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (172970 - 182961 != -9991)
										{
											continue;
										}
										this.UZMWVhPrnY.ActionEvent("RPC_laser", this.jBpWu3HEFQ.position, vector, num);
										if (246003 - 330923 == -84919)
										{
											continue;
										}
									}
									IL_656:
									goto IL_680;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (10784 - 435333 == -424548)
						{
							continue;
						}
						if (num2 < (float)5)
						{
							if (299842 - 247356 != 52486)
							{
								continue;
							}
							this.DjLWyO5Idx.vDirection = myAttackTarget.transform.position;
							if (125996 - 284157 == -158160)
							{
								continue;
							}
							this.DjLWyO5Idx.vDirection.y = this.jBpWu3HEFQ.position.y;
							if (207590 - 582711 == -375120)
							{
								continue;
							}
							this.DjLWyO5Idx.vMovement = (this.DjLWyO5Idx.vDirection - this.jBpWu3HEFQ.position).normalized;
							if (152748 - 50617 == 102132)
							{
								continue;
							}
							this.jBpWu3HEFQ.rotation = Quaternion.LookRotation(this.DjLWyO5Idx.vMovement);
							if (4055 - 158910 == -154854)
							{
								continue;
							}
							this.DjLWyO5Idx.actionState = "run";
							if (255375 - 276382 != -21007)
							{
								continue;
							}
							this.animation.Play("run");
							if (228169 - 167155 == 61015)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (289721 - 354256 == -64534)
							{
								continue;
							}
							this.DjLWyO5Idx.moveSpeed = Mathf.Lerp(this.DjLWyO5Idx.moveSpeed, -this.DjLWyO5Idx.runSpeed, (float)4 * Time.deltaTime);
							if (267433 - 464952 == -197518)
							{
								continue;
							}
						}
						else
						{
							this.DjLWyO5Idx.vDirection = myAttackTarget.transform.position;
							if (219602 - 563801 == -344198)
							{
								continue;
							}
							this.DjLWyO5Idx.vDirection.y = this.jBpWu3HEFQ.position.y;
							if (282164 - 232472 == 49693)
							{
								continue;
							}
							this.DjLWyO5Idx.vMovement = (this.DjLWyO5Idx.vDirection - this.jBpWu3HEFQ.position).normalized;
							if (244641 - 74395 != 170246)
							{
								continue;
							}
							this.jBpWu3HEFQ.rotation = Quaternion.LookRotation(this.DjLWyO5Idx.vMovement);
							if (295149 - 143125 != 152024)
							{
								continue;
							}
							this.DjLWyO5Idx.actionState = "standby";
							if (106841 - 155629 != -48788)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (231903 - 451420 != -219517)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (103006 - 419524 != -316518)
							{
								continue;
							}
							this.DjLWyO5Idx.moveSpeed = Mathf.Lerp(this.DjLWyO5Idx.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (107756 - 143271 != -35515)
							{
								continue;
							}
						}
					}
				}
			}
			IL_680:
			this.HVaWK15y4p += mTime;
		}
		while (231186 - 4510 == 226677);
	}

	// Token: 0x06003C41 RID: 15425 RVA: 0x007CDD9C File Offset: 0x007CBF9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (194344 - 441774 != -247429)
		{
		}
		for (;;)
		{
			IL_726:
			if (this.mbMWzDUGHf + (float)1 > Time.time)
			{
				if (256651 - 463662 != -207010)
				{
					break;
				}
			}
			else
			{
				this.mbMWzDUGHf = Time.time;
				if (226086 - 18785 == 207301)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.jBpWu3HEFQ.position, (float)30, this.gameObject.layer);
					if (238747 - 228647 != 10101 && 278231 - 596465 != -318233)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (110352 - 504207 == -393855)
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
								if (183722 - 350769 != -167047)
								{
									goto IL_726;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (198677 - 5185 == 193493)
								{
									goto IL_726;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (109626 - 436402 != -326776)
								{
									goto IL_726;
								}
								bool flag = true;
								if (62557 - 27768 == 34790)
								{
									goto IL_726;
								}
								eRace race = this.DjLWyO5Idx.Race;
								if (216618 - 305885 == -89266)
								{
									goto IL_726;
								}
								if (race == eRace.Tails)
								{
									if (28528 - 240225 == -211696)
									{
										goto IL_726;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_7ED;
									}
									if (24876 - 481276 != -456400)
									{
										goto IL_726;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (70394 - 590292 != -519897)
										{
											goto IL_7ED;
										}
										goto IL_726;
									}
									goto IL_4C9;
									IL_7ED:
									flag = false;
									if (202274 - 72419 != 129855)
									{
										goto IL_726;
									}
								}
								else if (race == eRace.Plants)
								{
									if (3214 - 270949 == -267734)
									{
										goto IL_726;
									}
									flag = false;
									if (9287 - 572791 == -563503)
									{
										goto IL_726;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (202207 - 481233 == -279025)
									{
										goto IL_726;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_27A;
									}
									if (283123 - 139552 == 143572)
									{
										goto IL_726;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (14684 - 126491 != -111806)
										{
											goto IL_27A;
										}
										goto IL_726;
									}
									goto IL_4C9;
									IL_27A:
									flag = false;
									if (185914 - 404036 == -218121)
									{
										goto IL_726;
									}
								}
								else if (race == eRace.Robots)
								{
									if (39520 - 345243 == -305722)
									{
										goto IL_726;
									}
									flag = true;
									if (273814 - 6048 == 267767)
									{
										goto IL_726;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (44400 - 566549 != -522149)
									{
										goto IL_726;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_2DF;
									}
									if (39400 - 72557 == -33156)
									{
										goto IL_726;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_2DF;
									}
									if (75749 - 359498 == -283748)
									{
										goto IL_726;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (259387 - 302690 != -43302)
										{
											goto IL_2DF;
										}
										goto IL_726;
									}
									goto IL_4C9;
									IL_2DF:
									flag = false;
									if (223772 - 382632 == -158859)
									{
										goto IL_726;
									}
								}
								else if (race == eRace.Structure)
								{
									if (61945 - 56194 == 5752)
									{
										goto IL_726;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (180478 - 184722 != -4244)
										{
											goto IL_726;
										}
										flag = false;
										if (185702 - 48219 != 137483)
										{
											goto IL_726;
										}
									}
								}
								IL_4C9:
								if (flag)
								{
									if (191472 - 316602 != -125130)
									{
										goto IL_726;
									}
									if (characterControl.hp > 0)
									{
										if (106068 - 542059 == -435990)
										{
											goto IL_726;
										}
										if (characterControl.recieveTarget)
										{
											if (273349 - 384556 != -111207)
											{
												goto IL_726;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (34006 - 536453 == -502446)
												{
													goto IL_726;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (42644 - 71830 != -29186)
													{
														goto IL_726;
													}
													Vector3 vector = gameObject.transform.position - this.jBpWu3HEFQ.position;
													if (14089 - 127508 != -113419)
													{
														goto IL_726;
													}
													if (vector.sqrMagnitude < (float)400)
													{
														if (2925 - 76024 == -73098)
														{
															goto IL_726;
														}
														this.DjLWyO5Idx.isAlert = true;
														if (289440 - 28358 == 261083)
														{
															goto IL_726;
														}
														this.cPQWh1Hg8x = Time.time;
														if (55365 - 116953 == -61587)
														{
															goto IL_726;
														}
														this.DjLWyO5Idx.myAttackTarget = gameObject;
														if (219661 - 231034 != -11373)
														{
															goto IL_726;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (205337 - 361209 == -155871)
														{
															goto IL_726;
														}
														this.DjLWyO5Idx.addHate(characterControl.ActorNr, 5);
														if (270186 - 328188 == -58001)
														{
															goto IL_726;
														}
													}
													else
													{
														float num = Vector3.Angle(this.jBpWu3HEFQ.forward, gameObject.transform.position - this.jBpWu3HEFQ.position);
														if (146280 - 534366 != -388086)
														{
															goto IL_726;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (129855 - 322249 == -192393)
														{
															goto IL_726;
														}
														if (num < (float)60)
														{
															if (98744 - 150854 != -52110)
															{
																goto IL_726;
															}
															if (characterControl.hp > 0)
															{
																if (192711 - 540707 == -347995)
																{
																	goto IL_726;
																}
																this.DjLWyO5Idx.isAlert = true;
																if (101124 - 242225 == -141100)
																{
																	goto IL_726;
																}
																this.cPQWh1Hg8x = Time.time;
																if (109245 - 220031 == -110785)
																{
																	goto IL_726;
																}
																this.DjLWyO5Idx.myAttackTarget = gameObject;
																if (114757 - 573652 != -458895)
																{
																	goto IL_726;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (213431 - 447016 != -233585)
																{
																	goto IL_726;
																}
																this.DjLWyO5Idx.addHate(characterControl.ActorNr, 5);
																if (106147 - 552657 == -446509)
																{
																	goto IL_726;
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
							if (148907 - 309690 == -160783)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003C42 RID: 15426 RVA: 0x007CE5C4 File Offset: 0x007CC7C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_escape(float mTime, float rTimer)
	{
		if (203031 - 556213 != -353182)
		{
		}
		for (;;)
		{
			IL_285:
			if (Game.mGameCode != 701)
			{
				if (167831 - 85885 == 81946)
				{
					break;
				}
			}
			else
			{
				if (Time.time - this.cPQWh1Hg8x >= this.HVaWK15y4p)
				{
					if (60218 - 15879 == 44340)
					{
						continue;
					}
					if (Time.time - this.cPQWh1Hg8x < this.HVaWK15y4p + mTime)
					{
						if (95567 - 273666 == -178098)
						{
							continue;
						}
						if (!this.RJZucnSaR1)
						{
							if (277112 - 499544 == -222431)
							{
								continue;
							}
							if (this.E9xu5DRWaJ < 5)
							{
								if (252567 - 585990 != -333423)
								{
									continue;
								}
								this.E9xu5DRWaJ++;
								if (231883 - 80612 == 151272)
								{
									continue;
								}
								int num = 90000;
								if (189783 - 364374 != -174591)
								{
									continue;
								}
								int i = this.E9xu5DRWaJ;
								if (235479 - 595024 != -359545)
								{
									continue;
								}
								while (i <= 5)
								{
									GameObject gameObject = GameObject.Find("WayPoint" + i);
									if (95845 - 41231 != 54614)
									{
										goto IL_285;
									}
									Vector3 vector = global::Math.vFlat(gameObject.transform.position - this.jBpWu3HEFQ.position);
									if (204622 - 421662 != -217040)
									{
										goto IL_285;
									}
									int num2 = (int)vector.sqrMagnitude;
									if (129294 - 80182 == 49113)
									{
										goto IL_285;
									}
									if (num > num2)
									{
										if (123604 - 379957 != -256353)
										{
											goto IL_285;
										}
										this.E9xu5DRWaJ = i;
										if (120004 - 453331 == -333326)
										{
											goto IL_285;
										}
										this.RJZucnSaR1 = gameObject;
										if (192084 - 597267 != -405183)
										{
											goto IL_285;
										}
										num = num2;
										if (259537 - 121376 == 138162)
										{
											goto IL_285;
										}
									}
									i++;
									if (98588 - 184722 == -86133)
									{
										goto IL_285;
									}
								}
								if (276717 - 448676 == -171958)
								{
									continue;
								}
							}
						}
						if (this.RJZucnSaR1)
						{
							if (69227 - 510617 == -441389)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(this.RJZucnSaR1.transform.position - this.jBpWu3HEFQ.position);
							if (292882 - 211269 == 81614)
							{
								continue;
							}
							float sqrMagnitude = vector2.sqrMagnitude;
							if (88696 - 511043 == -422346)
							{
								continue;
							}
							if (sqrMagnitude < (float)4)
							{
								if (208621 - 284496 != -75875)
								{
									continue;
								}
								if (this.E9xu5DRWaJ == 2)
								{
									goto IL_498;
								}
								if (97691 - 491951 != -394260)
								{
									continue;
								}
								if (this.E9xu5DRWaJ == 5)
								{
									if (88069 - 598447 != -510378)
									{
										continue;
									}
									goto IL_498;
								}
								else
								{
									this.RJZucnSaR1 = null;
									if (146744 - 564228 == -417483)
									{
										continue;
									}
								}
								goto IL_377;
								IL_498:
								this.UZMWVhPrnY.RPC_escape(this.jBpWu3HEFQ.position, this.jBpWu3HEFQ.forward, 0);
								if (212168 - 467102 == -254933)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (233599 - 48001 != 185598)
									{
										continue;
									}
									this.UZMWVhPrnY.ActionEvent("RPC_escape", this.jBpWu3HEFQ.position, this.jBpWu3HEFQ.forward, 0);
									if (260789 - 403978 != -143189)
									{
										continue;
									}
								}
							}
							else
							{
								this.AI_state = "escape";
								if (55140 - 351511 != -296371)
								{
									continue;
								}
								this.DjLWyO5Idx.vMovement = vector2.normalized;
								if (110621 - 69673 != 40948)
								{
									continue;
								}
								this.jBpWu3HEFQ.rotation = Quaternion.LookRotation(this.DjLWyO5Idx.vMovement);
								if (12456 - 282184 == -269727)
								{
									continue;
								}
								this.DjLWyO5Idx.actionState = "run";
								if (274449 - 546425 != -271976)
								{
									continue;
								}
								this.animation.Play("run");
								if (117208 - 69508 != 47700)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (145184 - 137561 != 7623)
								{
									continue;
								}
								this.DjLWyO5Idx.moveSpeed = Mathf.Lerp(this.DjLWyO5Idx.moveSpeed, this.DjLWyO5Idx.runSpeed, (float)4 * Time.deltaTime);
								if (82986 - 83249 == -262)
								{
									continue;
								}
							}
						}
					}
				}
				IL_377:
				this.HVaWK15y4p += mTime;
				if (118300 - 391577 == -273277)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003C43 RID: 15427 RVA: 0x007CEBD4 File Offset: 0x007CCDD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (26128 - 185260 != -159132)
		{
		}
		while (Time.time - this.cPQWh1Hg8x > this.HVaWK15y4p)
		{
			if (186327 - 504048 != -317720)
			{
				this.AI_state = "none";
				if (162786 - 549511 == -386725)
				{
					this.cPQWh1Hg8x = Time.time;
					if (213331 - 278871 != -65539)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003C44 RID: 15428 RVA: 0x007CEC88 File Offset: 0x007CCE88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003C45 RID: 15429 RVA: 0x007CEC8C File Offset: 0x007CCE8C
	internal static bool WptWOV5CNySxC8cXy7FY()
	{
		return true;
	}

	// Token: 0x06003C46 RID: 15430 RVA: 0x007CEC90 File Offset: 0x007CCE90
	internal static bool iLvhND5CYUofP9YHD99C()
	{
		return false;
	}

	// Token: 0x040049C7 RID: 18887
	private Transform jBpWu3HEFQ;

	// Token: 0x040049C8 RID: 18888
	private CharacterControl DjLWyO5Idx;

	// Token: 0x040049C9 RID: 18889
	private CamBot UZMWVhPrnY;

	// Token: 0x040049CA RID: 18890
	public string AI_state;

	// Token: 0x040049CB RID: 18891
	private float cPQWh1Hg8x;

	// Token: 0x040049CC RID: 18892
	private float HVaWK15y4p;

	// Token: 0x040049CD RID: 18893
	private float mbMWzDUGHf;

	// Token: 0x040049CE RID: 18894
	private int E9xu5DRWaJ;

	// Token: 0x040049CF RID: 18895
	private GameObject RJZucnSaR1;
}
