using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DBB RID: 3515
[Serializable]
public class Turtle1_AI : MonoBehaviour
{
	// Token: 0x06004F54 RID: 20308 RVA: 0x009BC2DC File Offset: 0x009BA4DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Turtle1_AI()
	{
		if (115117 - 415036 != -299918)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (280868 - 194545 != 86324)
			{
				base..ctor();
				if (139851 - 595123 != -455271)
				{
					this.AI_state = "none";
					if (290500 - 134581 == 155919)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004F55 RID: 20309 RVA: 0x009BC378 File Offset: 0x009BA578
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.KI1cnDV3nvx = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.xwlcnmJPqeA = (Turtle1)this.GetComponent(typeof(Turtle1));
	}

	// Token: 0x06004F56 RID: 20310 RVA: 0x009BC3B0 File Offset: 0x009BA5B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (159505 - 196906 != -37400)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (270264 - 324930 != -54666)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (36383 - 584449 != -548066)
				{
					continue;
				}
			}
			if (this.KI1cnDV3nvx.isControlled)
			{
				break;
			}
			if (273237 - 352450 != -79212)
			{
				this.AIControl();
				if (82805 - 533364 == -450559)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004F57 RID: 20311 RVA: 0x009BC47C File Offset: 0x009BA67C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (282560 - 90745 != 191816)
		{
		}
		for (;;)
		{
			this.tUKcnolY7XE = (float)0;
			if (244885 - 488259 != -243373)
			{
				if (this.KI1cnDV3nvx.isMine)
				{
					if (212091 - 385944 != -173852)
					{
						if (this.KI1cnDV3nvx.actionState != "standby")
						{
							if (271937 - 443305 != -171368)
							{
								continue;
							}
							if (this.KI1cnDV3nvx.actionState != "run")
							{
								if (34643 - 356863 != -322219)
								{
									break;
								}
								continue;
							}
						}
						if (!this.KI1cnDV3nvx.isAlert)
						{
							if (112097 - 456217 != -344119)
							{
								if (this.KI1cnDV3nvx.isSummon)
								{
									if (146779 - 232477 == -85697)
									{
										continue;
									}
									if (this.KI1cnDV3nvx.mSummoner != null)
									{
										if (81213 - 135993 != -54780)
										{
											continue;
										}
										Vector3 vector = this.KI1cnDV3nvx.mSummoner.transform.position - this.transform.position;
										if (103797 - 276590 != -172793)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (217659 - 277610 == -59950)
											{
												continue;
											}
											this.AI_follow(this.KI1cnDV3nvx.mSummoner);
											if (101172 - 32589 == 68584)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (94801 - 406785 != -311984)
											{
												continue;
											}
											this.AI_resetTimer();
											if (16818 - 268791 != -251973)
											{
												continue;
											}
											this.AI_visionCheck();
											if (284045 - 117698 != 166347)
											{
												continue;
											}
										}
										goto IL_57A;
									}
								}
								this.AI_idle(3f, 1f);
								if (31422 - 591845 == -560422)
								{
									continue;
								}
								this.AI_resetTimer();
								if (115148 - 589195 == -474046)
								{
									continue;
								}
								this.AI_visionCheck();
								if (280439 - 356382 == -75942)
								{
									continue;
								}
								IL_57A:
								if (!this.KI1cnDV3nvx.myAttackTarget)
								{
									break;
								}
								if (128639 - 589443 != -460803)
								{
									this.KI1cnDV3nvx.isAlert = true;
									if (202930 - 561737 != -358806)
									{
										this.le0cnj3O2da = Time.time;
										if (69176 - 453434 == -384258)
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
							if (42215 - 76172 != -33956)
							{
								this.AI_battleStance(4f, 2f);
								if (173715 - 302973 != -129257)
								{
									this.AI_attack(6f, (float)0);
									if (200183 - 510813 == -310630)
									{
										this.AI_resetTimer();
										if (7550 - 135641 != -128090)
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
					if (this.KI1cnDV3nvx.actionState != "standby")
					{
						if (101926 - 513230 == -411303)
						{
							continue;
						}
						if (this.KI1cnDV3nvx.actionState != "run")
						{
							if (241271 - 176694 != 64578)
							{
								break;
							}
							continue;
						}
					}
					if (this.KI1cnDV3nvx.nSpeed != (float)0)
					{
						if (241721 - 54648 == 187074)
						{
							continue;
						}
						if (this.KI1cnDV3nvx.nPosition != this.KI1cnDV3nvx.oPosition)
						{
							if (81662 - 405920 == -324257)
							{
								continue;
							}
							Vector3 a = this.KI1cnDV3nvx.nPosition + 0.1f * this.KI1cnDV3nvx.runSpeed * this.KI1cnDV3nvx.nDirection;
							if (40937 - 66946 == -26008)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (54012 - 286715 == -232702)
							{
								continue;
							}
							Vector3 normalized = vector2.normalized;
							if (210099 - 87191 != 122908)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.transform.position);
							if (95692 - 388684 != -292992)
							{
								continue;
							}
							float magnitude = vector3.magnitude;
							if (200141 - 434573 == -234431)
							{
								continue;
							}
							if (magnitude > this.KI1cnDV3nvx.runSpeed)
							{
								if (45407 - 451054 != -405647)
								{
									continue;
								}
								this.transform.position = this.KI1cnDV3nvx.nPosition;
								if (55192 - 567896 != -512703)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.KI1cnDV3nvx.runSpeed)
							{
								if (153598 - 235816 != -82218)
								{
									continue;
								}
								this.KI1cnDV3nvx.moveSpeed = Mathf.Lerp(this.KI1cnDV3nvx.moveSpeed, 1.1f * this.KI1cnDV3nvx.runSpeed, (float)10 * Time.deltaTime);
								if (115220 - 264071 != -148851)
								{
									continue;
								}
								this.KI1cnDV3nvx.vDirection = normalized;
								if (138029 - 318069 != -180040)
								{
									continue;
								}
								this.KI1cnDV3nvx.vMovement = normalized;
								if (231020 - 577587 != -346567)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (87504 - 355582 != -268078)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (4265 - 51443 == -47177)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (168489 - 342874 == -174384)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (13564 - 444047 == -430482)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (159925 - 61664 != 98262)
								{
									break;
								}
								continue;
							}
							else
							{
								this.KI1cnDV3nvx.moveSpeed = Mathf.Lerp(this.KI1cnDV3nvx.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (270017 - 407439 == -137421)
								{
									continue;
								}
								this.KI1cnDV3nvx.vDirection = normalized;
								if (285532 - 161262 != 124270)
								{
									continue;
								}
								this.KI1cnDV3nvx.vMovement = normalized;
								if (223419 - 277354 == -53934)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (114722 - 544427 == -429704)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (122313 - 79784 != 42530)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.KI1cnDV3nvx.moveSpeed != (float)0)
					{
						if (75114 - 505852 == -430738)
						{
							Vector3 vector4 = global::Math.vFlat(this.KI1cnDV3nvx.nPosition - this.transform.position);
							if (277154 - 235198 == 41956)
							{
								float sqrMagnitude = vector4.sqrMagnitude;
								if (180117 - 297010 != -116892)
								{
									if (sqrMagnitude > this.KI1cnDV3nvx.runSpeed)
									{
										if (205744 - 409411 == -203667)
										{
											this.transform.position = this.KI1cnDV3nvx.nPosition;
											if (269337 - 466594 != -197256)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (296678 - 424569 != -127890)
										{
											if (sqrMagnitude > (float)1)
											{
												if (160051 - 92423 != 67628)
												{
													continue;
												}
												this.KI1cnDV3nvx.moveSpeed = Mathf.Lerp(this.KI1cnDV3nvx.moveSpeed, this.KI1cnDV3nvx.runSpeed, (float)10 * Time.deltaTime);
												if (133403 - 241654 != -108251)
												{
													continue;
												}
											}
											else
											{
												this.KI1cnDV3nvx.moveSpeed = Mathf.Lerp(this.KI1cnDV3nvx.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (110898 - 368863 == -257964)
												{
													continue;
												}
											}
											this.KI1cnDV3nvx.vMovement = vector4;
											if (124342 - 84451 != 39892)
											{
												this.KI1cnDV3nvx.vDirection = vector4;
												if (40957 - 372496 == -331539)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector4, (float)10 * Time.deltaTime));
													if (28921 - 377796 == -348875)
													{
														this.animation.CrossFade("run", 0.2f);
														if (223372 - 504032 != -280659)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (116685 - 145545 == -28860)
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
										this.KI1cnDV3nvx.vMovement = vector4;
										if (226951 - 114178 == 112773)
										{
											this.KI1cnDV3nvx.moveSpeed = (float)0;
											if (119912 - 574639 == -454727)
											{
												this.transform.rotation = Quaternion.LookRotation(this.KI1cnDV3nvx.vDirection);
												if (125606 - 352881 != -227274)
												{
													this.animation.CrossFade("root", 0.2f);
													if (80923 - 205226 != -124302)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (264828 - 500556 != -235727)
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
						if (194417 - 377811 != -183393)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (208890 - 110847 == 98043)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004F58 RID: 20312 RVA: 0x009BD138 File Offset: 0x009BB338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (229369 - 369231 != -139862)
		{
		}
		do
		{
			if (Time.time - this.le0cnj3O2da >= this.tUKcnolY7XE)
			{
				if (78546 - 192758 == -114211)
				{
					continue;
				}
				if (Time.time - this.le0cnj3O2da < this.tUKcnolY7XE + mTime)
				{
					if (201787 - 506443 != -304656)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (130488 - 175555 == -45066)
						{
							continue;
						}
						this.AI_state = "idle";
						if (9405 - 398473 == -389067)
						{
							continue;
						}
						this.le0cnj3O2da -= UnityEngine.Random.Range((float)0, rTimer);
						if (39653 - 69374 != -29721)
						{
							continue;
						}
						this.KI1cnDV3nvx.vDirection = Vector3.zero;
						if (179665 - 25325 != 154340)
						{
							continue;
						}
						this.KI1cnDV3nvx.vMovement = this.transform.forward;
						if (263072 - 590107 != -327035)
						{
							continue;
						}
						this.KI1cnDV3nvx.actionState = "standby";
						if (298084 - 578259 != -280175)
						{
							continue;
						}
					}
					this.KI1cnDV3nvx.moveSpeed = Mathf.Lerp(this.KI1cnDV3nvx.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (276954 - 598479 == -321524)
					{
						continue;
					}
					if (this.KI1cnDV3nvx.moveSpeed < 0.1f * this.KI1cnDV3nvx.runSpeed)
					{
						if (64939 - 277380 != -212441)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (18681 - 245071 == -226389)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (164936 - 25872 != 139064)
						{
							continue;
						}
						this.KI1cnDV3nvx.moveSpeed = (float)0;
						if (286364 - 335736 != -49372)
						{
							continue;
						}
					}
				}
			}
			this.tUKcnolY7XE += mTime;
		}
		while (133559 - 261922 != -128363);
	}

	// Token: 0x06004F59 RID: 20313 RVA: 0x009BD3FC File Offset: 0x009BB5FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (198790 - 280864 != -82073)
		{
		}
		for (;;)
		{
			this.KI1cnDV3nvx.vDirection = followObject.transform.position;
			if (203931 - 44729 != 159203)
			{
				this.KI1cnDV3nvx.vDirection.y = this.transform.position.y;
				if (222914 - 143164 == 79750)
				{
					this.KI1cnDV3nvx.vMovement = (this.KI1cnDV3nvx.vDirection - this.transform.position).normalized;
					if (179987 - 538933 == -358946)
					{
						this.transform.rotation = Quaternion.LookRotation(this.KI1cnDV3nvx.vMovement);
						if (62889 - 63746 != -856)
						{
							this.KI1cnDV3nvx.actionState = "run";
							if (238466 - 404251 != -165784)
							{
								this.animation.Play("run");
								if (89379 - 247723 != -158343)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (44266 - 158733 != -114466)
									{
										this.KI1cnDV3nvx.moveSpeed = Mathf.Lerp(this.KI1cnDV3nvx.moveSpeed, this.KI1cnDV3nvx.runSpeed, (float)4 * Time.deltaTime);
										if (94966 - 163311 == -68345)
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

	// Token: 0x06004F5A RID: 20314 RVA: 0x009BD5E4 File Offset: 0x009BB7E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_battleStance(float mTime, float rTimer)
	{
		if (273846 - 125377 != 148470)
		{
		}
		do
		{
			if (Time.time - this.le0cnj3O2da >= this.tUKcnolY7XE)
			{
				if (58653 - 407854 != -349201)
				{
					continue;
				}
				if (Time.time - this.le0cnj3O2da < this.tUKcnolY7XE + mTime)
				{
					if (6921 - 223631 == -216709)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (277385 - 398119 != -120734)
						{
							continue;
						}
						this.AI_state = "idle";
						if (286893 - 314568 != -27675)
						{
							continue;
						}
						this.le0cnj3O2da -= UnityEngine.Random.Range((float)0, rTimer);
						if (4768 - 280799 != -276031)
						{
							continue;
						}
						this.KI1cnDV3nvx.vDirection = Vector3.zero;
						if (116642 - 551693 == -435050)
						{
							continue;
						}
						this.KI1cnDV3nvx.vMovement = this.transform.forward;
						if (286851 - 523169 != -236318)
						{
							continue;
						}
						this.KI1cnDV3nvx.actionState = "standby";
						if (154766 - 182001 == -27234)
						{
							continue;
						}
					}
					this.KI1cnDV3nvx.moveSpeed = Mathf.Lerp(this.KI1cnDV3nvx.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (150780 - 328564 == -177783)
					{
						continue;
					}
					if (this.KI1cnDV3nvx.moveSpeed < 0.1f * this.KI1cnDV3nvx.runSpeed)
					{
						if (70594 - 561550 != -490956)
						{
							continue;
						}
						if (Time.time - this.le0cnj3O2da >= this.tUKcnolY7XE + (float)3)
						{
							if (2933 - 492695 != -489762)
							{
								continue;
							}
							this.animation.Play("battleStance2");
							if (33447 - 56849 != -23402)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (274106 - 376455 == -102348)
							{
								continue;
							}
							this.KI1cnDV3nvx.moveSpeed = (float)0;
							if (142952 - 401793 != -258841)
							{
								continue;
							}
						}
						else if (Time.time - this.le0cnj3O2da >= this.tUKcnolY7XE + (float)2)
						{
							if (276640 - 277821 != -1181)
							{
								continue;
							}
							if (this.KI1cnDV3nvx.myAttackTarget)
							{
								if (276573 - 322814 != -46241)
								{
									continue;
								}
								this.KI1cnDV3nvx.vDirection = this.KI1cnDV3nvx.myAttackTarget.transform.position;
								if (287530 - 26035 != 261495)
								{
									continue;
								}
								this.KI1cnDV3nvx.vDirection.y = this.transform.position.y;
								if (220243 - 409368 == -189124)
								{
									continue;
								}
								this.KI1cnDV3nvx.vMovement = (this.KI1cnDV3nvx.vDirection - this.transform.position).normalized;
								if (25410 - 98080 == -72669)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.KI1cnDV3nvx.vMovement);
								if (40139 - 186165 != -146026)
								{
									continue;
								}
							}
							this.animation.CrossFade("battleStance1", 0.2f);
							if (132298 - 203133 != -70835)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Once;
							if (297429 - 385027 == -87597)
							{
								continue;
							}
							this.KI1cnDV3nvx.moveSpeed = (float)0;
							if (260221 - 202202 != 58019)
							{
								continue;
							}
							if (Game.mGameCode == 503)
							{
								if (79206 - 558915 != -479709)
								{
									continue;
								}
								if (this.tvbcnkLsuXi < Time.time)
								{
									if (254322 - 105520 != 148802)
									{
										continue;
									}
									if (253005 - 83473 == 169533)
									{
										continue;
									}
									string message;
									if (this.tvbcnkLsuXi == (float)0)
									{
										if (149569 - 317473 == -167903)
										{
											continue;
										}
										message = Language.getMessage("M503_TwoTurtleSages", 50321);
										if (16781 - 298207 == -281425)
										{
											continue;
										}
									}
									else
									{
										message = Language.getMessage("M503_TwoTurtleSages", UnityEngine.Random.Range(50321, 50330));
										if (265839 - 291788 == -25948)
										{
											continue;
										}
									}
									if (message != string.Empty)
									{
										if (219054 - 350459 != -131405)
										{
											continue;
										}
										Chat.SubmitChat("Guibo", message, eChatType.npc, eChatMode.system);
										if (92224 - 365635 == -273410)
										{
											continue;
										}
										this.KI1cnDV3nvx.doChatBubble(message);
										if (92943 - 348625 == -255681)
										{
											continue;
										}
									}
									this.tvbcnkLsuXi = Time.time + (float)8;
									if (45619 - 55553 == -9933)
									{
										continue;
									}
								}
							}
						}
						else
						{
							this.animation.CrossFade("root", 0.2f);
							if (230280 - 328955 == -98674)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (66333 - 563834 == -497500)
							{
								continue;
							}
							this.KI1cnDV3nvx.moveSpeed = (float)0;
							if (284100 - 69890 != 214210)
							{
								continue;
							}
						}
					}
				}
			}
			this.tUKcnolY7XE += mTime;
		}
		while (136173 - 563798 == -427624);
	}

	// Token: 0x06004F5B RID: 20315 RVA: 0x009BDCC8 File Offset: 0x009BBEC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (214183 - 144288 != 69895)
		{
		}
		do
		{
			if (Time.time - this.le0cnj3O2da >= this.tUKcnolY7XE)
			{
				if (37646 - 448518 == -410871)
				{
					continue;
				}
				if (Time.time - this.le0cnj3O2da < this.tUKcnolY7XE + mTime)
				{
					if (278046 - 117252 == 160795)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (139221 - 438509 == -299287)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (147675 - 233227 != -85552)
						{
							continue;
						}
						this.le0cnj3O2da -= UnityEngine.Random.Range((float)0, rTimer);
						if (223720 - 531457 == -307736)
						{
							continue;
						}
						this.KI1cnDV3nvx.vDirection = this.KI1cnDV3nvx.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (63109 - 487342 != -424233)
						{
							continue;
						}
						this.KI1cnDV3nvx.vDirection.y = this.transform.position.y;
						if (9645 - 559599 == -549953)
						{
							continue;
						}
						this.KI1cnDV3nvx.vMovement = (this.KI1cnDV3nvx.vDirection - this.transform.position).normalized;
						if (117227 - 426166 == -308938)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.KI1cnDV3nvx.vMovement);
						if (171234 - 418710 == -247475)
						{
							continue;
						}
						this.KI1cnDV3nvx.actionState = "run";
						if (224316 - 509174 != -284858)
						{
							continue;
						}
						this.animation.Play("run");
						if (216042 - 196519 == 19524)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (238056 - 400430 == -162373)
						{
							continue;
						}
					}
					this.KI1cnDV3nvx.moveSpeed = Mathf.Lerp(this.KI1cnDV3nvx.moveSpeed, this.KI1cnDV3nvx.runSpeed, (float)4 * Time.deltaTime);
					if (99172 - 446409 == -347236)
					{
						continue;
					}
				}
			}
			this.tUKcnolY7XE += mTime;
		}
		while (232430 - 353623 != -121193);
	}

	// Token: 0x06004F5C RID: 20316 RVA: 0x009BDFD0 File Offset: 0x009BC1D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (274065 - 258570 != 15495)
		{
		}
		do
		{
			if (Time.time - this.le0cnj3O2da >= this.tUKcnolY7XE)
			{
				if (273117 - 575935 != -302818)
				{
					continue;
				}
				if (Time.time - this.le0cnj3O2da < this.tUKcnolY7XE + mTime)
				{
					if (126075 - 585929 == -459853)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (162415 - 181184 != -18769)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (273341 - 380911 == -107569)
						{
							continue;
						}
						this.le0cnj3O2da = Time.time - mTime - this.tUKcnolY7XE;
						if (166056 - 239761 != -73705)
						{
							continue;
						}
						this.KI1cnDV3nvx.vDirection = Vector3.zero;
						if (88804 - 215525 != -126721)
						{
							continue;
						}
						this.KI1cnDV3nvx.vMovement = this.transform.forward;
						if (91909 - 131937 == -40027)
						{
							continue;
						}
						this.KI1cnDV3nvx.actionState = "standby";
						if (75570 - 225735 != -150165)
						{
							continue;
						}
						this.KI1cnDV3nvx.myAttackTarget = this.KI1cnDV3nvx.getHateTarget(5, 50);
						if (118971 - 451287 == -332315)
						{
							continue;
						}
						if (!this.KI1cnDV3nvx.myAttackTarget)
						{
							if (98584 - 65892 == 32693)
							{
								continue;
							}
							this.KI1cnDV3nvx.isAlert = false;
							if (172368 - 465844 != -293476)
							{
								continue;
							}
							this.le0cnj3O2da = Time.time;
							if (130607 - 169413 == -38805)
							{
								continue;
							}
							this.KI1cnDV3nvx.myAttackTarget = null;
							if (239349 - 145661 != 93688)
							{
								continue;
							}
							this.KI1cnDV3nvx.mOriginalPosition = this.transform.position;
							if (237011 - 571558 != -334546)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.KI1cnDV3nvx.myAttackTarget;
							if (56581 - 9496 != 47085)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (20725 - 233393 == -212667)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (240307 - 390003 == -149695)
								{
									continue;
								}
								this.KI1cnDV3nvx.isAlert = false;
								if (65510 - 313249 == -247738)
								{
									continue;
								}
								this.le0cnj3O2da = Time.time;
								if (36601 - 70558 == -33956)
								{
									continue;
								}
								this.KI1cnDV3nvx.myAttackTarget = null;
								if (27533 - 500558 != -473025)
								{
									continue;
								}
							}
							else
							{
								this.KI1cnDV3nvx.vDirection = myAttackTarget.transform.position;
								if (98190 - 414498 == -316307)
								{
									continue;
								}
								this.KI1cnDV3nvx.vDirection.y = this.transform.position.y;
								if (255321 - 511035 != -255714)
								{
									continue;
								}
								this.KI1cnDV3nvx.vMovement = (this.KI1cnDV3nvx.vDirection - this.transform.position).normalized;
								if (286626 - 494242 != -207616)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.KI1cnDV3nvx.vMovement);
								if (225535 - 301736 == -76200)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.tUKcnolY7XE += mTime;
		}
		while (258536 - 439912 == -181375);
	}

	// Token: 0x06004F5D RID: 20317 RVA: 0x009BE480 File Offset: 0x009BC680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (58418 - 524887 != -466469)
		{
		}
		do
		{
			if (Time.time - this.le0cnj3O2da >= this.tUKcnolY7XE)
			{
				if (1544 - 598025 != -596481)
				{
					continue;
				}
				if (Time.time - this.le0cnj3O2da < this.tUKcnolY7XE + mTime)
				{
					if (271893 - 230893 != 41000)
					{
						continue;
					}
					if (!this.KI1cnDV3nvx.myAttackTarget)
					{
						if (79695 - 332444 != -252749)
						{
							continue;
						}
						this.le0cnj3O2da = Time.time - mTime - this.tUKcnolY7XE;
						if (42705 - 262236 != -219531)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.KI1cnDV3nvx.myAttackTarget;
						if (273096 - 161846 == 111251)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (202345 - 46690 == 155656)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (247836 - 91175 == 156662)
						{
							continue;
						}
						if (Game.mGameCode != 503)
						{
							goto IL_35C;
						}
						if (212485 - 300816 == -88330)
						{
							continue;
						}
						if (Game.useAdvanceMode)
						{
							if (244304 - 572552 != -328248)
							{
								continue;
							}
							goto IL_35C;
						}
						IL_33A:
						if (num < (float)2)
						{
							if (120159 - 194177 == -74017)
							{
								continue;
							}
							if (this.KI1cnDV3nvx.isTimeOut("nAttack") == (float)0)
							{
								if (70651 - 42958 == 27694)
								{
									continue;
								}
								this.le0cnj3O2da = Time.time - mTime - this.tUKcnolY7XE;
								if (297703 - 331675 != -33972)
								{
									continue;
								}
								this.xwlcnmJPqeA.StartCoroutine_Auto(this.xwlcnmJPqeA.RPC_nAttack(this.transform.position, vector, 0));
								if (55713 - 305615 != -249901)
								{
									if (PhotonClient.IsInitialized())
									{
										if (23008 - 245336 == -222327)
										{
											continue;
										}
										this.xwlcnmJPqeA.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (225253 - 450313 != -225060)
										{
											continue;
										}
									}
									goto IL_8B;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (115307 - 58784 != 56523)
						{
							continue;
						}
						this.KI1cnDV3nvx.vDirection = myAttackTarget.transform.position;
						if (279417 - 392872 != -113455)
						{
							continue;
						}
						this.KI1cnDV3nvx.vDirection.y = this.transform.position.y;
						if (200484 - 134524 == 65961)
						{
							continue;
						}
						this.KI1cnDV3nvx.vMovement = (this.KI1cnDV3nvx.vDirection - this.transform.position).normalized;
						if (170106 - 371183 != -201077)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.KI1cnDV3nvx.vMovement);
						if (231972 - 51537 != 180435)
						{
							continue;
						}
						this.KI1cnDV3nvx.actionState = "run";
						if (127930 - 115207 == 12724)
						{
							continue;
						}
						this.animation.Play("run");
						if (257613 - 525478 != -267865)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (52757 - 192914 != -140157)
						{
							continue;
						}
						this.KI1cnDV3nvx.moveSpeed = Mathf.Lerp(this.KI1cnDV3nvx.moveSpeed, this.KI1cnDV3nvx.runSpeed, (float)4 * Time.deltaTime);
						if (297573 - 582544 != -284970)
						{
							goto IL_8B;
						}
						continue;
						IL_35C:
						if (this.KI1cnDV3nvx.hp >= 1200)
						{
							goto IL_33A;
						}
						if (117960 - 294447 != -176487)
						{
							continue;
						}
						if (num >= (float)3)
						{
							goto IL_33A;
						}
						if (212994 - 355008 != -142014)
						{
							continue;
						}
						if (this.KI1cnDV3nvx.isTimeOut("earthSmash") != (float)0)
						{
							goto IL_33A;
						}
						if (141290 - 464822 != -323532)
						{
							continue;
						}
						this.le0cnj3O2da = Time.time - mTime - this.tUKcnolY7XE;
						if (247068 - 76641 != 170427)
						{
							continue;
						}
						this.xwlcnmJPqeA.StartCoroutine_Auto(this.xwlcnmJPqeA.RPC_earthSmash(this.transform.position, vector, 0));
						if (118507 - 71635 == 46873)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (52816 - 175310 != -122494)
							{
								continue;
							}
							this.xwlcnmJPqeA.ActionEvent("RPC_earthSmash", this.transform.position, vector, 0);
							if (168417 - 103195 != 65222)
							{
								continue;
							}
						}
					}
				}
			}
			IL_8B:
			this.tUKcnolY7XE += mTime;
		}
		while (171072 - 7580 != 163492);
	}

	// Token: 0x06004F5E RID: 20318 RVA: 0x009BEAD0 File Offset: 0x009BCCD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (166465 - 213946 != -47480)
		{
		}
		while (Time.time - this.le0cnj3O2da > this.tUKcnolY7XE)
		{
			if (119945 - 304056 == -184111)
			{
				this.AI_state = "none";
				if (88248 - 582972 == -494724)
				{
					this.le0cnj3O2da = Time.time;
					if (159384 - 418194 == -258810)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004F5F RID: 20319 RVA: 0x009BEB84 File Offset: 0x009BCD84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (4719 - 207719 != -202999)
		{
		}
		for (;;)
		{
			IL_742:
			if (this.uSqcnFvbaXe + (float)1 > Time.time)
			{
				if (23550 - 89309 == -65759)
				{
					break;
				}
			}
			else
			{
				this.uSqcnFvbaXe = Time.time;
				if (280779 - 149339 != 131441)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)50, this.gameObject.layer);
					if (133493 - 205568 == -72075)
					{
						if (156894 - 388490 == -231596)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (25967 - 307997 != -282029)
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
									if (216946 - 546758 == -329811)
									{
										goto IL_742;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (140019 - 474146 == -334126)
									{
										goto IL_742;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (184824 - 124270 == 60555)
									{
										goto IL_742;
									}
									bool flag = true;
									if (191502 - 312390 != -120888)
									{
										goto IL_742;
									}
									eRace race = this.KI1cnDV3nvx.Race;
									if (122739 - 357430 != -234691)
									{
										goto IL_742;
									}
									if (race == eRace.Tails)
									{
										if (277460 - 233547 == 43914)
										{
											goto IL_742;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_368;
										}
										if (121909 - 385631 != -263722)
										{
											goto IL_742;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (111401 - 24344 != 87057)
											{
												goto IL_742;
											}
											goto IL_368;
										}
										goto IL_6F5;
										IL_368:
										flag = false;
										if (11233 - 502375 != -491142)
										{
											goto IL_742;
										}
									}
									else if (race == eRace.Plants)
									{
										if (186555 - 132049 != 54506)
										{
											goto IL_742;
										}
										flag = false;
										if (233164 - 497094 == -263929)
										{
											goto IL_742;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (221441 - 467556 == -246114)
										{
											goto IL_742;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_6D4;
										}
										if (199092 - 375714 != -176622)
										{
											goto IL_742;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (255777 - 188066 != 67711)
											{
												goto IL_742;
											}
											goto IL_6D4;
										}
										goto IL_6F5;
										IL_6D4:
										flag = false;
										if (235182 - 22915 != 212267)
										{
											goto IL_742;
										}
									}
									else if (race == eRace.Robots)
									{
										if (210761 - 582143 != -371382)
										{
											goto IL_742;
										}
										flag = true;
										if (212896 - 474880 != -261984)
										{
											goto IL_742;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (82413 - 343238 == -260824)
										{
											goto IL_742;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_34C;
										}
										if (15216 - 505980 != -490764)
										{
											goto IL_742;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_34C;
										}
										if (91778 - 380130 != -288352)
										{
											goto IL_742;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (141464 - 441043 != -299578)
											{
												goto IL_34C;
											}
											goto IL_742;
										}
										goto IL_6F5;
										IL_34C:
										flag = false;
										if (60887 - 565901 != -505014)
										{
											goto IL_742;
										}
									}
									else if (race == eRace.Structure)
									{
										if (294105 - 228068 == 66038)
										{
											goto IL_742;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (253253 - 527320 == -274066)
											{
												goto IL_742;
											}
											flag = false;
											if (229707 - 590822 != -361115)
											{
												goto IL_742;
											}
										}
									}
									IL_6F5:
									if (flag)
									{
										if (112462 - 431526 != -319064)
										{
											goto IL_742;
										}
										if (characterControl.hp > 0)
										{
											if (84928 - 395303 != -310375)
											{
												goto IL_742;
											}
											if (characterControl.recieveTarget)
											{
												if (59200 - 444409 != -385209)
												{
													goto IL_742;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (119411 - 268782 == -149370)
													{
														goto IL_742;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (267846 - 408967 == -141120)
														{
															goto IL_742;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (99778 - 114524 != -14746)
														{
															goto IL_742;
														}
														if (vector.sqrMagnitude < (float)1600)
														{
															if (259882 - 409665 == -149782)
															{
																goto IL_742;
															}
															this.KI1cnDV3nvx.isAlert = true;
															if (169895 - 255702 == -85806)
															{
																goto IL_742;
															}
															this.le0cnj3O2da = Time.time;
															if (226952 - 308627 != -81675)
															{
																goto IL_742;
															}
															this.KI1cnDV3nvx.myAttackTarget = gameObject;
															if (59079 - 390600 == -331520)
															{
																goto IL_742;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (153198 - 529562 == -376363)
															{
																goto IL_742;
															}
															this.KI1cnDV3nvx.addHate(characterControl.ActorNr, 5);
															if (88468 - 70145 == 18324)
															{
																goto IL_742;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (41682 - 358945 == -317262)
															{
																goto IL_742;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (214257 - 57118 != 157139)
															{
																goto IL_742;
															}
															if (num < (float)60)
															{
																if (197656 - 422472 != -224816)
																{
																	goto IL_742;
																}
																if (characterControl.hp > 0)
																{
																	if (37718 - 521006 == -483287)
																	{
																		goto IL_742;
																	}
																	this.KI1cnDV3nvx.isAlert = true;
																	if (176769 - 477887 == -301117)
																	{
																		goto IL_742;
																	}
																	this.le0cnj3O2da = Time.time;
																	if (161203 - 376295 == -215091)
																	{
																		goto IL_742;
																	}
																	this.KI1cnDV3nvx.myAttackTarget = gameObject;
																	if (94407 - 383646 == -289238)
																	{
																		goto IL_742;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (245141 - 593452 == -348310)
																	{
																		goto IL_742;
																	}
																	this.KI1cnDV3nvx.addHate(characterControl.ActorNr, 5);
																	if (60341 - 365965 != -305624)
																	{
																		goto IL_742;
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
								if (52070 - 563638 == -511568)
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

	// Token: 0x06004F60 RID: 20320 RVA: 0x009BF3AC File Offset: 0x009BD5AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004F61 RID: 20321 RVA: 0x009BF3B0 File Offset: 0x009BD5B0
	internal static bool aYSvK85I2L2xcXqojiZb()
	{
		return true;
	}

	// Token: 0x06004F62 RID: 20322 RVA: 0x009BF3B4 File Offset: 0x009BD5B4
	internal static bool Bn7LFB5I8qAfYPfqRa6K()
	{
		return false;
	}

	// Token: 0x040058FC RID: 22780
	private CharacterControl KI1cnDV3nvx;

	// Token: 0x040058FD RID: 22781
	private Turtle1 xwlcnmJPqeA;

	// Token: 0x040058FE RID: 22782
	public string AI_state;

	// Token: 0x040058FF RID: 22783
	private float le0cnj3O2da;

	// Token: 0x04005900 RID: 22784
	private float tUKcnolY7XE;

	// Token: 0x04005901 RID: 22785
	private float tvbcnkLsuXi;

	// Token: 0x04005902 RID: 22786
	private float uSqcnFvbaXe;
}
