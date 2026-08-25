using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DC5 RID: 3525
[Serializable]
public class Turtle2_AI : MonoBehaviour
{
	// Token: 0x06004F95 RID: 20373 RVA: 0x009C430C File Offset: 0x009C250C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Turtle2_AI()
	{
		if (87001 - 447695 != -360693)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (239041 - 259065 != -20023)
			{
				base..ctor();
				if (94470 - 154344 == -59874)
				{
					this.AI_state = "none";
					if (197201 - 43713 != 153489)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004F96 RID: 20374 RVA: 0x009C43A8 File Offset: 0x009C25A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.I1rcnAnCsGQ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.lARcn9q7BFI = (Turtle2)this.GetComponent(typeof(Turtle2));
	}

	// Token: 0x06004F97 RID: 20375 RVA: 0x009C43E0 File Offset: 0x009C25E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (48420 - 428864 != -380443)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (16121 - 396149 == -380027)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (204444 - 405608 != -201164)
				{
					continue;
				}
			}
			if (this.I1rcnAnCsGQ.isControlled)
			{
				break;
			}
			if (84018 - 160805 != -76786)
			{
				this.AIControl();
				if (287084 - 84028 == 203056)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004F98 RID: 20376 RVA: 0x009C44AC File Offset: 0x009C26AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (55096 - 450049 != -394953)
		{
		}
		for (;;)
		{
			this.UX8cnuwngU2 = (float)0;
			if (232397 - 468927 == -236530)
			{
				if (this.I1rcnAnCsGQ.isMine)
				{
					if (6148 - 157282 != -151133)
					{
						if (this.I1rcnAnCsGQ.actionState != "standby")
						{
							if (278389 - 39854 == 238536)
							{
								continue;
							}
							if (this.I1rcnAnCsGQ.actionState != "run")
							{
								if (206008 - 138885 != 67123)
								{
									continue;
								}
								break;
							}
						}
						if (!this.I1rcnAnCsGQ.isAlert)
						{
							if (272504 - 73366 != 199139)
							{
								if (this.I1rcnAnCsGQ.isSummon)
								{
									if (254534 - 292082 == -37547)
									{
										continue;
									}
									if (this.I1rcnAnCsGQ.mSummoner != null)
									{
										if (114730 - 90041 == 24690)
										{
											continue;
										}
										Vector3 vector = this.I1rcnAnCsGQ.mSummoner.transform.position - this.transform.position;
										if (190162 - 586927 != -396765)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (175758 - 64821 != 110937)
											{
												continue;
											}
											this.AI_follow(this.I1rcnAnCsGQ.mSummoner);
											if (91047 - 1450 != 89597)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (60054 - 570368 == -510313)
											{
												continue;
											}
											this.AI_resetTimer();
											if (274384 - 75061 == 199324)
											{
												continue;
											}
											this.AI_visionCheck();
											if (25711 - 522410 == -496698)
											{
												continue;
											}
										}
										goto IL_ACC;
									}
								}
								this.AI_idle(3f, 1f);
								if (255300 - 174571 != 80729)
								{
									continue;
								}
								this.AI_resetTimer();
								if (200455 - 399111 != -198656)
								{
									continue;
								}
								this.AI_visionCheck();
								if (118780 - 448258 == -329477)
								{
									continue;
								}
								IL_ACC:
								if (!this.I1rcnAnCsGQ.myAttackTarget)
								{
									break;
								}
								if (178960 - 81985 != 96976)
								{
									this.I1rcnAnCsGQ.isAlert = true;
									if (160202 - 382935 == -222733)
									{
										this.oricnWSTGK2 = Time.time;
										if (175846 - 433029 != -257182)
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
							if (111101 - 435458 != -324356)
							{
								this.AI_battleStance(4f, 2f);
								if (122044 - 156370 != -34325)
								{
									this.AI_patrol(4f, 2f);
									if (124363 - 99358 == 25005)
									{
										this.AI_attack(2f, (float)0);
										if (41348 - 423496 == -382148)
										{
											this.AI_resetTimer();
											if (947 - 238412 == -237465)
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
					if (this.I1rcnAnCsGQ.actionState != "standby")
					{
						if (257343 - 406067 == -148723)
						{
							continue;
						}
						if (this.I1rcnAnCsGQ.actionState != "run")
						{
							if (111852 - 185714 != -73861)
							{
								break;
							}
							continue;
						}
					}
					if (this.I1rcnAnCsGQ.nSpeed != (float)0)
					{
						if (52464 - 540027 != -487563)
						{
							continue;
						}
						if (this.I1rcnAnCsGQ.nPosition != this.I1rcnAnCsGQ.oPosition)
						{
							if (149784 - 287573 == -137788)
							{
								continue;
							}
							Vector3 a = this.I1rcnAnCsGQ.nPosition + 0.1f * this.I1rcnAnCsGQ.runSpeed * this.I1rcnAnCsGQ.nDirection;
							if (174240 - 253840 != -79600)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (297909 - 39809 != 258100)
							{
								continue;
							}
							Vector3 normalized = vector2.normalized;
							if (58445 - 275527 == -217081)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.transform.position);
							if (35424 - 496133 != -460709)
							{
								continue;
							}
							float magnitude = vector3.magnitude;
							if (187730 - 249411 != -61681)
							{
								continue;
							}
							if (magnitude > this.I1rcnAnCsGQ.runSpeed)
							{
								if (289615 - 461036 != -171421)
								{
									continue;
								}
								this.transform.position = this.I1rcnAnCsGQ.nPosition;
								if (294352 - 51648 != 242704)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.I1rcnAnCsGQ.runSpeed)
							{
								if (278821 - 242919 == 35903)
								{
									continue;
								}
								this.I1rcnAnCsGQ.moveSpeed = Mathf.Lerp(this.I1rcnAnCsGQ.moveSpeed, 1.1f * this.I1rcnAnCsGQ.runSpeed, (float)10 * Time.deltaTime);
								if (213860 - 116965 == 96896)
								{
									continue;
								}
								this.I1rcnAnCsGQ.vDirection = normalized;
								if (173881 - 504636 == -330754)
								{
									continue;
								}
								this.I1rcnAnCsGQ.vMovement = normalized;
								if (296142 - 225973 != 70169)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (90986 - 64074 != 26912)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (154306 - 554600 == -400293)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (224729 - 215292 == 9438)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (296042 - 236488 != 59554)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (180696 - 363056 != -182360)
								{
									continue;
								}
								break;
							}
							else
							{
								this.I1rcnAnCsGQ.moveSpeed = Mathf.Lerp(this.I1rcnAnCsGQ.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (69067 - 106596 != -37529)
								{
									continue;
								}
								this.I1rcnAnCsGQ.vDirection = normalized;
								if (56928 - 273268 != -216340)
								{
									continue;
								}
								this.I1rcnAnCsGQ.vMovement = normalized;
								if (120552 - 578939 != -458387)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (253321 - 165106 == 88216)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (212940 - 140353 != 72587)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.I1rcnAnCsGQ.moveSpeed != (float)0)
					{
						if (258949 - 460662 == -201713)
						{
							Vector3 vector4 = global::Math.vFlat(this.I1rcnAnCsGQ.nPosition - this.transform.position);
							if (121835 - 283912 == -162077)
							{
								float sqrMagnitude = vector4.sqrMagnitude;
								if (219475 - 239414 == -19939)
								{
									if (sqrMagnitude > this.I1rcnAnCsGQ.runSpeed)
									{
										if (138119 - 312762 != -174642)
										{
											this.transform.position = this.I1rcnAnCsGQ.nPosition;
											if (187269 - 33451 == 153818)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (48966 - 510803 != -461836)
										{
											if (sqrMagnitude > (float)1)
											{
												if (68725 - 199158 != -130433)
												{
													continue;
												}
												this.I1rcnAnCsGQ.moveSpeed = Mathf.Lerp(this.I1rcnAnCsGQ.moveSpeed, this.I1rcnAnCsGQ.runSpeed, (float)10 * Time.deltaTime);
												if (194413 - 426142 == -231728)
												{
													continue;
												}
											}
											else
											{
												this.I1rcnAnCsGQ.moveSpeed = Mathf.Lerp(this.I1rcnAnCsGQ.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (105970 - 479192 == -373221)
												{
													continue;
												}
											}
											this.I1rcnAnCsGQ.vMovement = vector4;
											if (268090 - 492242 == -224152)
											{
												this.I1rcnAnCsGQ.vDirection = vector4;
												if (64148 - 585067 == -520919)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector4, (float)10 * Time.deltaTime));
													if (166728 - 195035 != -28306)
													{
														this.animation.CrossFade("run", 0.2f);
														if (199637 - 53276 == 146361)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (75905 - 129827 == -53922)
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
										this.I1rcnAnCsGQ.vMovement = vector4;
										if (37643 - 180670 == -143027)
										{
											this.I1rcnAnCsGQ.moveSpeed = (float)0;
											if (221931 - 239125 != -17193)
											{
												this.transform.rotation = Quaternion.LookRotation(this.I1rcnAnCsGQ.vDirection);
												if (103411 - 550545 == -447134)
												{
													this.animation.CrossFade("root", 0.2f);
													if (104875 - 574152 == -469277)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (185300 - 122052 != 63249)
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
						if (234696 - 400553 != -165856)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (157187 - 299471 != -142283)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004F99 RID: 20377 RVA: 0x009C5190 File Offset: 0x009C3390
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (64916 - 229808 != -164891)
		{
		}
		do
		{
			if (Time.time - this.oricnWSTGK2 >= this.UX8cnuwngU2)
			{
				if (167872 - 345958 == -178085)
				{
					continue;
				}
				if (Time.time - this.oricnWSTGK2 < this.UX8cnuwngU2 + mTime)
				{
					if (113965 - 554905 != -440940)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (256062 - 438974 != -182912)
						{
							continue;
						}
						this.AI_state = "idle";
						if (233035 - 43654 == 189382)
						{
							continue;
						}
						this.oricnWSTGK2 -= UnityEngine.Random.Range((float)0, rTimer);
						if (220456 - 379420 != -158964)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vDirection = Vector3.zero;
						if (42843 - 232085 != -189242)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vMovement = this.transform.forward;
						if (164651 - 494181 != -329530)
						{
							continue;
						}
						this.I1rcnAnCsGQ.actionState = "standby";
						if (148701 - 581059 != -432358)
						{
							continue;
						}
					}
					this.I1rcnAnCsGQ.moveSpeed = Mathf.Lerp(this.I1rcnAnCsGQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (26208 - 174705 != -148497)
					{
						continue;
					}
					if (this.I1rcnAnCsGQ.moveSpeed < 0.1f * this.I1rcnAnCsGQ.runSpeed)
					{
						if (211264 - 173224 != 38040)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (236987 - 158513 == 78475)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (247464 - 482494 == -235029)
						{
							continue;
						}
						this.I1rcnAnCsGQ.moveSpeed = (float)0;
						if (80378 - 481869 != -401491)
						{
							continue;
						}
					}
				}
			}
			this.UX8cnuwngU2 += mTime;
		}
		while (96235 - 376443 != -280208);
	}

	// Token: 0x06004F9A RID: 20378 RVA: 0x009C5454 File Offset: 0x009C3654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_battleStance(float mTime, float rTimer)
	{
		if (18803 - 194160 != -175356)
		{
		}
		do
		{
			if (Time.time - this.oricnWSTGK2 >= this.UX8cnuwngU2)
			{
				if (32170 - 204232 != -172062)
				{
					continue;
				}
				if (Time.time - this.oricnWSTGK2 < this.UX8cnuwngU2 + mTime)
				{
					if (187262 - 65295 != 121967)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (251455 - 93957 == 157499)
						{
							continue;
						}
						this.AI_state = "idle";
						if (26951 - 213213 != -186262)
						{
							continue;
						}
						this.oricnWSTGK2 -= UnityEngine.Random.Range((float)0, rTimer);
						if (212889 - 222884 != -9995)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vDirection = Vector3.zero;
						if (292083 - 59311 != 232772)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vMovement = this.transform.forward;
						if (47586 - 88399 != -40813)
						{
							continue;
						}
						this.I1rcnAnCsGQ.actionState = "standby";
						if (215553 - 160039 == 55515)
						{
							continue;
						}
					}
					this.I1rcnAnCsGQ.moveSpeed = Mathf.Lerp(this.I1rcnAnCsGQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (207416 - 309713 != -102297)
					{
						continue;
					}
					if (this.I1rcnAnCsGQ.moveSpeed < 0.1f * this.I1rcnAnCsGQ.runSpeed)
					{
						if (51109 - 255988 != -204879)
						{
							continue;
						}
						if (Time.time - this.oricnWSTGK2 >= this.UX8cnuwngU2 + (float)3)
						{
							if (86072 - 325922 != -239850)
							{
								continue;
							}
							this.animation.Play("battleStance2");
							if (61927 - 551182 == -489254)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (213009 - 155684 == 57326)
							{
								continue;
							}
							this.I1rcnAnCsGQ.moveSpeed = (float)0;
							if (130717 - 597794 != -467077)
							{
								continue;
							}
						}
						else if (Time.time - this.oricnWSTGK2 >= this.UX8cnuwngU2 + (float)2)
						{
							if (211263 - 311683 != -100420)
							{
								continue;
							}
							if (this.I1rcnAnCsGQ.myAttackTarget)
							{
								if (139773 - 587688 == -447914)
								{
									continue;
								}
								this.I1rcnAnCsGQ.vDirection = this.I1rcnAnCsGQ.myAttackTarget.transform.position;
								if (289471 - 407908 != -118437)
								{
									continue;
								}
								this.I1rcnAnCsGQ.vDirection.y = this.transform.position.y;
								if (164212 - 214197 != -49985)
								{
									continue;
								}
								this.I1rcnAnCsGQ.vMovement = (this.I1rcnAnCsGQ.vDirection - this.transform.position).normalized;
								if (298765 - 273332 != 25433)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.I1rcnAnCsGQ.vMovement);
								if (45246 - 175226 == -129979)
								{
									continue;
								}
							}
							this.animation.CrossFade("battleStance1", 0.2f);
							if (286010 - 117230 != 168780)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Once;
							if (8474 - 331959 == -323484)
							{
								continue;
							}
							this.I1rcnAnCsGQ.moveSpeed = (float)0;
							if (46717 - 586431 != -539714)
							{
								continue;
							}
							if (Game.mGameCode == 503)
							{
								if (171123 - 206837 == -35713)
								{
									continue;
								}
								if (this.QIwcnyA6TKe < Time.time)
								{
									if (8498 - 378274 == -369775)
									{
										continue;
									}
									if (129062 - 256748 != -127686)
									{
										continue;
									}
									string message;
									if (this.QIwcnyA6TKe == (float)0)
									{
										if (225757 - 445749 != -219992)
										{
											continue;
										}
										message = Language.getMessage("M503_TwoTurtleSages", 50361);
										if (251690 - 144512 != 107178)
										{
											continue;
										}
									}
									else
									{
										message = Language.getMessage("M503_TwoTurtleSages", UnityEngine.Random.Range(50361, 50370));
										if (233228 - 84566 != 148662)
										{
											continue;
										}
									}
									if (message != string.Empty)
									{
										if (140660 - 344771 == -204110)
										{
											continue;
										}
										Chat.SubmitChat("Guili", message, eChatType.npc, eChatMode.system);
										if (25038 - 193945 == -168906)
										{
											continue;
										}
										this.I1rcnAnCsGQ.doChatBubble(message);
										if (154853 - 291562 == -136708)
										{
											continue;
										}
									}
									this.QIwcnyA6TKe = Time.time + (float)6;
									if (59356 - 350852 != -291496)
									{
										continue;
									}
								}
							}
						}
						else
						{
							this.animation.CrossFade("root", 0.2f);
							if (37039 - 56270 != -19231)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (20572 - 499832 == -479259)
							{
								continue;
							}
							this.I1rcnAnCsGQ.moveSpeed = (float)0;
							if (8608 - 243407 != -234799)
							{
								continue;
							}
						}
					}
				}
			}
			this.UX8cnuwngU2 += mTime;
		}
		while (38979 - 533858 != -494879);
	}

	// Token: 0x06004F9B RID: 20379 RVA: 0x009C5B38 File Offset: 0x009C3D38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (126673 - 389242 != -262568)
		{
		}
		for (;;)
		{
			this.I1rcnAnCsGQ.vDirection = followObject.transform.position;
			if (255345 - 274124 != -18778)
			{
				this.I1rcnAnCsGQ.vDirection.y = this.transform.position.y;
				if (44603 - 502255 != -457651)
				{
					this.I1rcnAnCsGQ.vMovement = (this.I1rcnAnCsGQ.vDirection - this.transform.position).normalized;
					if (155791 - 520070 != -364278)
					{
						this.transform.rotation = Quaternion.LookRotation(this.I1rcnAnCsGQ.vMovement);
						if (90302 - 152847 != -62544)
						{
							this.I1rcnAnCsGQ.actionState = "run";
							if (100781 - 262263 == -161482)
							{
								this.animation.Play("run");
								if (24952 - 446587 == -421635)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (55219 - 232063 == -176844)
									{
										this.I1rcnAnCsGQ.moveSpeed = Mathf.Lerp(this.I1rcnAnCsGQ.moveSpeed, this.I1rcnAnCsGQ.runSpeed, (float)4 * Time.deltaTime);
										if (129704 - 430236 == -300532)
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

	// Token: 0x06004F9C RID: 20380 RVA: 0x009C5D20 File Offset: 0x009C3F20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (181182 - 406983 != -225800)
		{
		}
		do
		{
			if (Time.time - this.oricnWSTGK2 >= this.UX8cnuwngU2)
			{
				if (89666 - 18896 == 70771)
				{
					continue;
				}
				if (Time.time - this.oricnWSTGK2 < this.UX8cnuwngU2 + mTime)
				{
					if (178493 - 576316 != -397823)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (83184 - 218464 == -135279)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (206911 - 96937 != 109974)
						{
							continue;
						}
						this.oricnWSTGK2 -= UnityEngine.Random.Range((float)0, rTimer);
						if (76775 - 275372 != -198597)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vDirection = this.I1rcnAnCsGQ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (223888 - 525991 != -302103)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vDirection.y = this.transform.position.y;
						if (185181 - 172300 == 12882)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vMovement = (this.I1rcnAnCsGQ.vDirection - this.transform.position).normalized;
						if (114012 - 499408 != -385396)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.I1rcnAnCsGQ.vMovement);
						if (79868 - 278925 != -199057)
						{
							continue;
						}
						this.I1rcnAnCsGQ.actionState = "run";
						if (254192 - 376460 == -122267)
						{
							continue;
						}
						this.animation.Play("run");
						if (188640 - 114667 != 73973)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (28705 - 263376 == -234670)
						{
							continue;
						}
					}
					this.I1rcnAnCsGQ.moveSpeed = Mathf.Lerp(this.I1rcnAnCsGQ.moveSpeed, this.I1rcnAnCsGQ.runSpeed, (float)4 * Time.deltaTime);
					if (56449 - 520838 == -464388)
					{
						continue;
					}
				}
			}
			this.UX8cnuwngU2 += mTime;
		}
		while (193434 - 471953 == -278518);
	}

	// Token: 0x06004F9D RID: 20381 RVA: 0x009C6028 File Offset: 0x009C4228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (229477 - 462094 != -232616)
		{
		}
		do
		{
			if (Time.time - this.oricnWSTGK2 >= this.UX8cnuwngU2)
			{
				if (265812 - 414204 == -148391)
				{
					continue;
				}
				if (Time.time - this.oricnWSTGK2 < this.UX8cnuwngU2 + mTime)
				{
					if (135224 - 32147 == 103078)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (152658 - 491392 == -338733)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (129007 - 469603 == -340595)
						{
							continue;
						}
						this.oricnWSTGK2 = Time.time - mTime - this.UX8cnuwngU2;
						if (223310 - 225095 == -1784)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vDirection = Vector3.zero;
						if (69943 - 569925 == -499981)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vMovement = this.transform.forward;
						if (112055 - 71625 != 40430)
						{
							continue;
						}
						this.I1rcnAnCsGQ.actionState = "standby";
						if (177456 - 145972 != 31484)
						{
							continue;
						}
						this.I1rcnAnCsGQ.myAttackTarget = this.I1rcnAnCsGQ.getHateTarget(25, 50);
						if (204667 - 205719 == -1051)
						{
							continue;
						}
						if (!this.I1rcnAnCsGQ.myAttackTarget)
						{
							if (233636 - 212055 == 21582)
							{
								continue;
							}
							this.I1rcnAnCsGQ.isAlert = false;
							if (75675 - 268585 == -192909)
							{
								continue;
							}
							this.oricnWSTGK2 = Time.time;
							if (7319 - 517208 != -509889)
							{
								continue;
							}
							this.I1rcnAnCsGQ.myAttackTarget = null;
							if (42707 - 501297 == -458589)
							{
								continue;
							}
							this.I1rcnAnCsGQ.mOriginalPosition = this.transform.position;
							if (157155 - 109556 != 47600)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.I1rcnAnCsGQ.myAttackTarget;
							if (149528 - 75278 != 74250)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (89345 - 586149 != -496804)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (265885 - 153079 == 112807)
								{
									continue;
								}
								this.I1rcnAnCsGQ.isAlert = false;
								if (102165 - 396909 == -294743)
								{
									continue;
								}
								this.oricnWSTGK2 = Time.time;
								if (61626 - 42040 == 19587)
								{
									continue;
								}
								this.I1rcnAnCsGQ.myAttackTarget = null;
								if (26405 - 353423 == -327017)
								{
									continue;
								}
							}
							else
							{
								this.I1rcnAnCsGQ.vDirection = myAttackTarget.transform.position;
								if (64453 - 231096 != -166643)
								{
									continue;
								}
								this.I1rcnAnCsGQ.vDirection.y = this.transform.position.y;
								if (173533 - 381664 != -208131)
								{
									continue;
								}
								this.I1rcnAnCsGQ.vMovement = (this.I1rcnAnCsGQ.vDirection - this.transform.position).normalized;
								if (184099 - 412057 == -227957)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.I1rcnAnCsGQ.vMovement);
								if (245627 - 310873 != -65246)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.UX8cnuwngU2 += mTime;
		}
		while (146709 - 294441 == -147731);
	}

	// Token: 0x06004F9E RID: 20382 RVA: 0x009C64D8 File Offset: 0x009C46D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (274603 - 511738 != -237135)
		{
		}
		do
		{
			if (Time.time - this.oricnWSTGK2 >= this.UX8cnuwngU2)
			{
				if (288943 - 442130 != -153187)
				{
					continue;
				}
				if (Time.time - this.oricnWSTGK2 < this.UX8cnuwngU2 + mTime)
				{
					if (46664 - 200744 != -154080)
					{
						continue;
					}
					if (!this.I1rcnAnCsGQ.myAttackTarget)
					{
						if (261903 - 246301 != 15602)
						{
							continue;
						}
						this.oricnWSTGK2 = Time.time - mTime - this.UX8cnuwngU2;
						if (249734 - 541254 != -291519)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.I1rcnAnCsGQ.myAttackTarget;
						if (194686 - 394688 == -200001)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (79632 - 549899 == -470266)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (217632 - 238076 == -20443)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (188403 - 405940 == -217536)
						{
							continue;
						}
						if (Game.mGameCode != 503)
						{
							goto IL_39A;
						}
						if (229033 - 170468 == 58566)
						{
							continue;
						}
						if (Game.useAdvanceMode)
						{
							if (110423 - 47394 != 63030)
							{
								goto IL_39A;
							}
							continue;
						}
						IL_1F:
						if (characterControl)
						{
							if (94264 - 11771 != 82493)
							{
								continue;
							}
							if (num < (float)45)
							{
								if (14735 - 521696 == -506960)
								{
									continue;
								}
								if (this.I1rcnAnCsGQ.isTimeOut("nAttack") == (float)0)
								{
									if (81902 - 523181 != -441279)
									{
										continue;
									}
									this.oricnWSTGK2 = Time.time - mTime - this.UX8cnuwngU2;
									if (144982 - 76244 != 68738)
									{
										continue;
									}
									this.lARcn9q7BFI.StartCoroutine_Auto(this.lARcn9q7BFI.RPC_nAttack(this.transform.position, vector, characterControl.ActorNr));
									if (243684 - 274121 != -30436)
									{
										if (PhotonClient.IsInitialized())
										{
											if (292151 - 435601 == -143449)
											{
												continue;
											}
											this.lARcn9q7BFI.ActionEvent("RPC_nAttack", this.transform.position, vector, characterControl.ActorNr);
											if (254107 - 178481 == 75627)
											{
												continue;
											}
										}
										goto IL_279;
									}
									continue;
								}
							}
						}
						this.AI_state = "attack";
						if (138373 - 63224 == 75150)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vDirection = myAttackTarget.transform.position;
						if (243104 - 60192 == 182913)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vDirection.y = this.transform.position.y;
						if (286297 - 381966 != -95669)
						{
							continue;
						}
						this.I1rcnAnCsGQ.vMovement = (this.I1rcnAnCsGQ.vDirection - this.transform.position).normalized;
						if (214137 - 128918 != 85219)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.I1rcnAnCsGQ.vMovement);
						if (291082 - 355528 == -64445)
						{
							continue;
						}
						this.I1rcnAnCsGQ.actionState = "run";
						if (271681 - 148139 != 123542)
						{
							continue;
						}
						this.animation.Play("run");
						if (128096 - 90660 == 37437)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (154480 - 353492 != -199012)
						{
							continue;
						}
						this.I1rcnAnCsGQ.moveSpeed = Mathf.Lerp(this.I1rcnAnCsGQ.moveSpeed, this.I1rcnAnCsGQ.runSpeed, (float)4 * Time.deltaTime);
						if (30532 - 34075 != -3543)
						{
							continue;
						}
						goto IL_279;
						IL_39A:
						if (this.I1rcnAnCsGQ.hp >= 1200)
						{
							goto IL_1F;
						}
						if (206591 - 141320 != 65271)
						{
							continue;
						}
						if (num >= (float)30)
						{
							goto IL_1F;
						}
						if (26128 - 571202 != -545074)
						{
							continue;
						}
						if (this.I1rcnAnCsGQ.isTimeOut("heavenPalm") != (float)0)
						{
							goto IL_1F;
						}
						if (159534 - 453336 != -293802)
						{
							continue;
						}
						this.oricnWSTGK2 = Time.time - mTime - this.UX8cnuwngU2;
						if (135696 - 553572 != -417876)
						{
							continue;
						}
						this.lARcn9q7BFI.StartCoroutine_Auto(this.lARcn9q7BFI.RPC_heavenPalm(this.transform.position, vector, characterControl.ActorNr));
						if (133581 - 208014 == -74432)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (63681 - 405943 == -342261)
							{
								continue;
							}
							this.lARcn9q7BFI.ActionEvent("RPC_heavenPalm", this.transform.position, vector, characterControl.ActorNr);
							if (65095 - 438201 != -373106)
							{
								continue;
							}
						}
					}
				}
			}
			IL_279:
			this.UX8cnuwngU2 += mTime;
		}
		while (58161 - 163648 == -105486);
	}

	// Token: 0x06004F9F RID: 20383 RVA: 0x009C6B94 File Offset: 0x009C4D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (220433 - 341227 != -120794)
		{
		}
		while (Time.time - this.oricnWSTGK2 > this.UX8cnuwngU2)
		{
			if (67408 - 205820 == -138412)
			{
				this.AI_state = "none";
				if (9326 - 43769 != -34442)
				{
					this.oricnWSTGK2 = Time.time;
					if (188853 - 32335 == 156518)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004FA0 RID: 20384 RVA: 0x009C6C48 File Offset: 0x009C4E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (219515 - 482097 != -262581)
		{
		}
		for (;;)
		{
			IL_262:
			if (this.FxAcnVR9enn + (float)1 > Time.time)
			{
				if (273043 - 519397 == -246354)
				{
					break;
				}
			}
			else
			{
				this.FxAcnVR9enn = Time.time;
				if (235166 - 514500 == -279334)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)50, this.gameObject.layer);
					if (233173 - 245067 == -11894)
					{
						if (234525 - 458841 == -224316)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (220594 - 270818 == -50224)
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
									if (266594 - 420943 != -154349)
									{
										goto IL_262;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (268781 - 574832 != -306051)
									{
										goto IL_262;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (283338 - 574150 != -290812)
									{
										goto IL_262;
									}
									bool flag = true;
									if (218674 - 24597 == 194078)
									{
										goto IL_262;
									}
									eRace race = this.I1rcnAnCsGQ.Race;
									if (213460 - 518246 == -304785)
									{
										goto IL_262;
									}
									if (race == eRace.Tails)
									{
										if (193846 - 95783 == 98064)
										{
											goto IL_262;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_220;
										}
										if (186919 - 247528 == -60608)
										{
											goto IL_262;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (101153 - 454684 != -353531)
											{
												goto IL_262;
											}
											goto IL_220;
										}
										goto IL_1F;
										IL_220:
										flag = false;
										if (275430 - 126563 == 148868)
										{
											goto IL_262;
										}
									}
									else if (race == eRace.Plants)
									{
										if (246382 - 295276 == -48893)
										{
											goto IL_262;
										}
										flag = false;
										if (64847 - 67369 == -2521)
										{
											goto IL_262;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (250760 - 192681 != 58079)
										{
											goto IL_262;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_365;
										}
										if (243434 - 452100 != -208666)
										{
											goto IL_262;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (204833 - 435684 != -230850)
											{
												goto IL_365;
											}
											goto IL_262;
										}
										goto IL_1F;
										IL_365:
										flag = false;
										if (57998 - 473471 == -415472)
										{
											goto IL_262;
										}
									}
									else if (race == eRace.Robots)
									{
										if (114858 - 443230 == -328371)
										{
											goto IL_262;
										}
										flag = true;
										if (216677 - 454426 == -237748)
										{
											goto IL_262;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (179184 - 34305 != 144879)
										{
											goto IL_262;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_192;
										}
										if (47691 - 329714 != -282023)
										{
											goto IL_262;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_192;
										}
										if (222745 - 12330 != 210415)
										{
											goto IL_262;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (283445 - 496468 != -213023)
											{
												goto IL_262;
											}
											goto IL_192;
										}
										goto IL_1F;
										IL_192:
										flag = false;
										if (265398 - 559430 != -294032)
										{
											goto IL_262;
										}
									}
									else if (race == eRace.Structure)
									{
										if (6145 - 103502 != -97357)
										{
											goto IL_262;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (216078 - 183803 == 32276)
											{
												goto IL_262;
											}
											flag = false;
											if (14308 - 407692 == -393383)
											{
												goto IL_262;
											}
										}
									}
									IL_1F:
									if (flag)
									{
										if (112198 - 598757 != -486559)
										{
											goto IL_262;
										}
										if (characterControl.hp > 0)
										{
											if (118192 - 475743 != -357551)
											{
												goto IL_262;
											}
											if (characterControl.recieveTarget)
											{
												if (205288 - 56204 != 149084)
												{
													goto IL_262;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (46451 - 582226 == -535774)
													{
														goto IL_262;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (64626 - 30520 == 34107)
														{
															goto IL_262;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (72635 - 88795 != -16160)
														{
															goto IL_262;
														}
														if (vector.sqrMagnitude < (float)1600)
														{
															if (5777 - 534148 == -528370)
															{
																goto IL_262;
															}
															this.I1rcnAnCsGQ.isAlert = true;
															if (118106 - 40731 != 77375)
															{
																goto IL_262;
															}
															this.oricnWSTGK2 = Time.time;
															if (267147 - 452972 != -185825)
															{
																goto IL_262;
															}
															this.I1rcnAnCsGQ.myAttackTarget = gameObject;
															if (22131 - 176786 != -154655)
															{
																goto IL_262;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (200967 - 409366 != -208399)
															{
																goto IL_262;
															}
															this.I1rcnAnCsGQ.addHate(characterControl.ActorNr, 5);
															if (226195 - 310617 != -84422)
															{
																goto IL_262;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (105975 - 421662 == -315686)
															{
																goto IL_262;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (60651 - 69608 == -8956)
															{
																goto IL_262;
															}
															if (num < (float)60)
															{
																if (81223 - 288223 != -207000)
																{
																	goto IL_262;
																}
																if (characterControl.hp > 0)
																{
																	if (288435 - 472535 != -184100)
																	{
																		goto IL_262;
																	}
																	this.I1rcnAnCsGQ.isAlert = true;
																	if (243098 - 128211 == 114888)
																	{
																		goto IL_262;
																	}
																	this.oricnWSTGK2 = Time.time;
																	if (201264 - 549973 == -348708)
																	{
																		goto IL_262;
																	}
																	this.I1rcnAnCsGQ.myAttackTarget = gameObject;
																	if (153060 - 524133 == -371072)
																	{
																		goto IL_262;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (293863 - 363244 == -69380)
																	{
																		goto IL_262;
																	}
																	this.I1rcnAnCsGQ.addHate(characterControl.ActorNr, 5);
																	if (43539 - 457107 == -413567)
																	{
																		goto IL_262;
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
								if (48166 - 129155 == -80989)
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

	// Token: 0x06004FA1 RID: 20385 RVA: 0x009C7470 File Offset: 0x009C5670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004FA2 RID: 20386 RVA: 0x009C7474 File Offset: 0x009C5674
	internal static bool EZPAxb5IRriW3p7L9f57()
	{
		return true;
	}

	// Token: 0x06004FA3 RID: 20387 RVA: 0x009C7478 File Offset: 0x009C5678
	internal static bool USrZSx5Iw16AHUMDGFZ8()
	{
		return false;
	}

	// Token: 0x0400593E RID: 22846
	private CharacterControl I1rcnAnCsGQ;

	// Token: 0x0400593F RID: 22847
	private Turtle2 lARcn9q7BFI;

	// Token: 0x04005940 RID: 22848
	public string AI_state;

	// Token: 0x04005941 RID: 22849
	private float oricnWSTGK2;

	// Token: 0x04005942 RID: 22850
	private float UX8cnuwngU2;

	// Token: 0x04005943 RID: 22851
	private float QIwcnyA6TKe;

	// Token: 0x04005944 RID: 22852
	private float FxAcnVR9enn;
}
