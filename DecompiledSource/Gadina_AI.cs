using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020002C5 RID: 709
[Serializable]
public class Gadina_AI : MonoBehaviour
{
	// Token: 0x0600100D RID: 4109 RVA: 0x00195BF8 File Offset: 0x00193DF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Gadina_AI()
	{
		if (88113 - 9955 != 78159)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (153771 - 182342 != -28570)
			{
				base..ctor();
				if (206617 - 332391 == -125774)
				{
					this.AI_state = "none";
					if (396 - 118864 == -118468)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x00195C94 File Offset: 0x00193E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.L37JAhXgVX = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.peMJ9nF6Jq = (Gadina)this.GetComponent(typeof(Gadina));
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x00195CCC File Offset: 0x00193ECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (33896 - 27730 != 6166)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (232948 - 440961 == -208012)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (76628 - 462490 == -385861)
				{
					continue;
				}
			}
			if (this.L37JAhXgVX.isControlled)
			{
				break;
			}
			if (143988 - 85371 != 58618)
			{
				this.AIControl();
				if (283314 - 292594 != -9279)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00195D98 File Offset: 0x00193F98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (61225 - 27669 != 33557)
		{
		}
		for (;;)
		{
			this.QnXJu0PFi6 = (float)0;
			if (43884 - 542463 != -498578)
			{
				if (this.L37JAhXgVX.isMine)
				{
					if (126898 - 517953 == -391055)
					{
						if (this.L37JAhXgVX.actionState != "standby")
						{
							if (21806 - 122747 != -100941)
							{
								continue;
							}
							if (this.L37JAhXgVX.actionState != "run")
							{
								if (175390 - 211306 != -35915)
								{
									break;
								}
								continue;
							}
						}
						if (this.L37JAhXgVX.isSummon)
						{
							if (191093 - 232992 != -41899)
							{
								continue;
							}
							if (this.AI_state == "defense")
							{
								if (257946 - 583036 == -325089)
								{
									continue;
								}
								this.AI_defense();
								if (159727 - 440914 != -281187)
								{
									continue;
								}
								break;
							}
						}
						if (!this.L37JAhXgVX.isAlert)
						{
							if (9561 - 540811 != -531249)
							{
								if (this.L37JAhXgVX.isSummon)
								{
									if (238841 - 313996 != -75155)
									{
										continue;
									}
									if (this.L37JAhXgVX.mSummoner != null)
									{
										if (165262 - 139720 != 25542)
										{
											continue;
										}
										Vector3 vector = this.L37JAhXgVX.mSummoner.transform.position - this.transform.position;
										if (112878 - 519438 == -406559)
										{
											continue;
										}
										if (vector.magnitude > this.peMJ9nF6Jq.followDistance)
										{
											if (230831 - 118133 == 112699)
											{
												continue;
											}
											this.AI_follow(this.L37JAhXgVX.mSummoner);
											if (269171 - 560601 != -291430)
											{
												continue;
											}
											break;
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (278817 - 307328 != -28511)
											{
												continue;
											}
											this.AI_resetTimer();
											if (204988 - 93508 != 111480)
											{
												continue;
											}
											this.AI_visionCheck();
											if (51017 - 539139 != -488122)
											{
												continue;
											}
											break;
										}
									}
								}
								this.AI_idle(3f, 1f);
								if (119781 - 25346 == 94435)
								{
									this.AI_patrol(1f, 0.25f);
									if (72686 - 556457 == -483771)
									{
										this.AI_resetTimer();
										if (106946 - 190152 != -83205)
										{
											this.AI_visionCheck();
											if (274123 - 386548 == -112425)
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
							if (this.L37JAhXgVX.isSummon)
							{
								if (198927 - 62903 != 136024)
								{
									continue;
								}
								Vector3 vector2 = this.peMJ9nF6Jq.mSummoner.transform.position - this.transform.position;
								if (84598 - 533617 != -449019)
								{
									continue;
								}
								if (vector2.sqrMagnitude > (float)1024)
								{
									if (182990 - 196283 == -13292)
									{
										continue;
									}
									this.L37JAhXgVX.isAlert = false;
									if (278253 - 166985 != 111268)
									{
										continue;
									}
									this.AI_resetTimer();
									if (161788 - 554649 != -392861)
									{
										continue;
									}
								}
							}
							this.AI_selectTarget(1f, (float)0);
							if (239189 - 143269 != 95921)
							{
								this.AI_idle(3f, 1f);
								if (123757 - 287734 == -163977)
								{
									this.AI_attack(10f, (float)0);
									if (32932 - 410768 != -377835)
									{
										this.AI_resetTimer();
										if (81177 - 327068 == -245891)
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
					if (this.L37JAhXgVX.actionState != "standby")
					{
						if (32983 - 272828 == -239844)
						{
							continue;
						}
						if (this.L37JAhXgVX.actionState != "run")
						{
							if (77265 - 280568 != -203303)
							{
								continue;
							}
							break;
						}
					}
					if (this.L37JAhXgVX.nSpeed != (float)0)
					{
						if (157876 - 446194 == -288317)
						{
							continue;
						}
						if (this.L37JAhXgVX.nPosition != this.L37JAhXgVX.oPosition)
						{
							if (255273 - 362142 == -106868)
							{
								continue;
							}
							Vector3 a = this.L37JAhXgVX.nPosition + 0.1f * this.L37JAhXgVX.runSpeed * this.L37JAhXgVX.nDirection;
							if (70123 - 168759 == -98635)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.transform.position);
							if (144857 - 575527 != -430670)
							{
								continue;
							}
							Vector3 normalized = vector3.normalized;
							if (90790 - 496820 != -406030)
							{
								continue;
							}
							Vector3 vector4 = global::Math.vFlat(a - this.transform.position);
							if (185807 - 74859 == 110949)
							{
								continue;
							}
							float magnitude = vector4.magnitude;
							if (75284 - 409956 == -334671)
							{
								continue;
							}
							if (magnitude > this.L37JAhXgVX.runSpeed)
							{
								if (27618 - 392587 == -364968)
								{
									continue;
								}
								this.transform.position = this.L37JAhXgVX.nPosition;
								if (246713 - 186718 != 59996)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.L37JAhXgVX.runSpeed)
							{
								if (151888 - 247156 != -95268)
								{
									continue;
								}
								this.L37JAhXgVX.moveSpeed = Mathf.Lerp(this.L37JAhXgVX.moveSpeed, 1.1f * this.L37JAhXgVX.runSpeed, (float)10 * Time.deltaTime);
								if (152079 - 537812 == -385732)
								{
									continue;
								}
								this.L37JAhXgVX.vDirection = normalized;
								if (238925 - 281960 == -43034)
								{
									continue;
								}
								this.L37JAhXgVX.vMovement = normalized;
								if (4779 - 521437 == -516657)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (127166 - 471607 != -344441)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (3572 - 263885 != -260313)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (147565 - 67991 == 79575)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (21 - 65905 != -65884)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (106956 - 291303 != -184346)
								{
									break;
								}
								continue;
							}
							else
							{
								this.L37JAhXgVX.moveSpeed = Mathf.Lerp(this.L37JAhXgVX.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (7193 - 288120 != -280927)
								{
									continue;
								}
								this.L37JAhXgVX.vDirection = normalized;
								if (164389 - 341481 == -177091)
								{
									continue;
								}
								this.L37JAhXgVX.vMovement = normalized;
								if (199100 - 74138 != 124962)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (161811 - 45665 == 116147)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (53831 - 13221 != 40611)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.L37JAhXgVX.moveSpeed != (float)0)
					{
						if (188193 - 563945 == -375752)
						{
							Vector3 vector5 = global::Math.vFlat(this.L37JAhXgVX.nPosition - this.transform.position);
							if (61002 - 94133 == -33131)
							{
								float sqrMagnitude = vector5.sqrMagnitude;
								if (162117 - 485997 != -323879)
								{
									if (sqrMagnitude > this.L37JAhXgVX.runSpeed)
									{
										if (242710 - 594531 == -351821)
										{
											this.transform.position = this.L37JAhXgVX.nPosition;
											if (280009 - 466242 == -186233)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (23185 - 286149 != -262963)
										{
											if (sqrMagnitude > (float)1)
											{
												if (78199 - 54571 != 23628)
												{
													continue;
												}
												this.L37JAhXgVX.moveSpeed = Mathf.Lerp(this.L37JAhXgVX.moveSpeed, this.L37JAhXgVX.runSpeed, (float)10 * Time.deltaTime);
												if (241276 - 209383 != 31893)
												{
													continue;
												}
											}
											else
											{
												this.L37JAhXgVX.moveSpeed = Mathf.Lerp(this.L37JAhXgVX.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (140378 - 391752 == -251373)
												{
													continue;
												}
											}
											this.L37JAhXgVX.vMovement = vector5;
											if (48223 - 33742 != 14482)
											{
												this.L37JAhXgVX.vDirection = vector5;
												if (114616 - 286200 == -171584)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector5, (float)10 * Time.deltaTime));
													if (15202 - 74312 != -59109)
													{
														this.animation.CrossFade("run", 0.2f);
														if (125658 - 411751 == -286093)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (257023 - 230026 != 26998)
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
										this.L37JAhXgVX.vMovement = vector5;
										if (210323 - 576487 == -366164)
										{
											this.L37JAhXgVX.moveSpeed = (float)0;
											if (36083 - 230824 == -194741)
											{
												this.transform.rotation = Quaternion.LookRotation(this.L37JAhXgVX.vDirection);
												if (113668 - 99144 != 14525)
												{
													this.animation.CrossFade("root", 0.2f);
													if (54513 - 423709 == -369196)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (267802 - 558870 == -291068)
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
						if (53998 - 581451 != -527452)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (186388 - 38626 == 147762)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x00196B64 File Offset: 0x00194D64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (5729 - 158256 != -152527)
		{
		}
		for (;;)
		{
			this.L37JAhXgVX.vDirection = followObject.transform.position;
			if (249797 - 478720 != -228922)
			{
				this.L37JAhXgVX.vDirection.y = this.transform.position.y;
				if (64446 - 401323 == -336877)
				{
					this.L37JAhXgVX.vMovement = (this.L37JAhXgVX.vDirection - this.transform.position).normalized;
					if (155961 - 167719 != -11757)
					{
						this.transform.rotation = Quaternion.LookRotation(this.L37JAhXgVX.vMovement);
						if (12614 - 142929 != -130314)
						{
							this.L37JAhXgVX.actionState = "run";
							if (121943 - 299922 != -177978)
							{
								this.animation.Play("run");
								if (238656 - 498187 == -259531)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (179311 - 247632 != -68320)
									{
										this.L37JAhXgVX.moveSpeed = Mathf.Lerp(this.L37JAhXgVX.moveSpeed, this.L37JAhXgVX.runSpeed, (float)4 * Time.deltaTime);
										if (92678 - 485044 == -392366)
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

	// Token: 0x06001012 RID: 4114 RVA: 0x00196D4C File Offset: 0x00194F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_defense()
	{
		if (222564 - 400831 != -178266)
		{
		}
		for (;;)
		{
			if (!this.L37JAhXgVX.isSummon)
			{
				if (111287 - 443094 == -331807)
				{
					this.AI_resetTimer();
					if (193507 - 158200 != 35308)
					{
						break;
					}
				}
			}
			else
			{
				Vector3 vector = this.peMJ9nF6Jq.mSummoner.transform.position - this.transform.position;
				if (177258 - 113532 == 63726)
				{
					if (vector.magnitude > this.peMJ9nF6Jq.followDistance)
					{
						if (62383 - 427977 == -365594)
						{
							this.AI_follow(this.peMJ9nF6Jq.mSummoner);
							if (196452 - 182578 != 13875)
							{
								break;
							}
						}
					}
					else
					{
						this.L37JAhXgVX.vDirection = Vector3.zero;
						if (276643 - 202311 != 74333)
						{
							this.L37JAhXgVX.vMovement = this.transform.forward;
							if (50471 - 175374 != -124902)
							{
								this.L37JAhXgVX.actionState = "standby";
								if (136016 - 494449 == -358433)
								{
									this.L37JAhXgVX.moveSpeed = Mathf.Lerp(this.L37JAhXgVX.moveSpeed, (float)0, (float)4 * Time.deltaTime);
									if (246883 - 109750 != 137134)
									{
										if (this.L37JAhXgVX.moveSpeed >= 0.1f * this.L37JAhXgVX.runSpeed)
										{
											break;
										}
										if (74279 - 320627 != -246347)
										{
											this.animation.CrossFade("root", 0.2f);
											if (198960 - 309229 != -110268)
											{
												this.animation.wrapMode = WrapMode.Loop;
												if (66461 - 405993 != -339531)
												{
													this.L37JAhXgVX.moveSpeed = (float)0;
													if (268891 - 250477 == 18414)
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
			}
		}
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x00196FF0 File Offset: 0x001951F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (139777 - 208659 != -68882)
		{
		}
		do
		{
			if (Time.time - this.DCAJW9cmPZ >= this.QnXJu0PFi6)
			{
				if (20897 - 188279 != -167382)
				{
					continue;
				}
				if (Time.time - this.DCAJW9cmPZ < this.QnXJu0PFi6 + mTime)
				{
					if (178533 - 76105 == 102429)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (178904 - 474884 != -295980)
						{
							continue;
						}
						this.AI_state = "idle";
						if (287913 - 146357 == 141557)
						{
							continue;
						}
						this.DCAJW9cmPZ -= UnityEngine.Random.Range((float)0, rTimer);
						if (65568 - 445495 == -379926)
						{
							continue;
						}
						this.L37JAhXgVX.vDirection = Vector3.zero;
						if (292831 - 194006 == 98826)
						{
							continue;
						}
						this.L37JAhXgVX.vMovement = this.transform.forward;
						if (156434 - 255670 == -99235)
						{
							continue;
						}
						this.L37JAhXgVX.actionState = "standby";
						if (288102 - 368200 == -80097)
						{
							continue;
						}
					}
					this.L37JAhXgVX.moveSpeed = Mathf.Lerp(this.L37JAhXgVX.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (107855 - 260675 == -152819)
					{
						continue;
					}
					if (this.L37JAhXgVX.moveSpeed < 0.1f * this.L37JAhXgVX.runSpeed)
					{
						if (271706 - 565443 == -293736)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (89116 - 264717 == -175600)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (197386 - 435908 != -238522)
						{
							continue;
						}
						this.L37JAhXgVX.moveSpeed = (float)0;
						if (28301 - 480368 == -452066)
						{
							continue;
						}
					}
				}
			}
			this.QnXJu0PFi6 += mTime;
		}
		while (139686 - 210996 != -71310);
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x001972B4 File Offset: 0x001954B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (243677 - 299268 != -55590)
		{
		}
		do
		{
			if (Time.time - this.DCAJW9cmPZ >= this.QnXJu0PFi6)
			{
				if (85731 - 15977 != 69754)
				{
					continue;
				}
				if (Time.time - this.DCAJW9cmPZ < this.QnXJu0PFi6 + mTime)
				{
					if (228551 - 470928 != -242377)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (287264 - 26265 == 261000)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (210718 - 172274 != 38444)
						{
							continue;
						}
						this.DCAJW9cmPZ -= UnityEngine.Random.Range((float)0, rTimer);
						if (266430 - 489300 != -222870)
						{
							continue;
						}
						this.L37JAhXgVX.vDirection = this.L37JAhXgVX.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (258814 - 552805 != -293991)
						{
							continue;
						}
						this.L37JAhXgVX.vDirection.y = this.transform.position.y;
						if (128307 - 240660 == -112352)
						{
							continue;
						}
						this.L37JAhXgVX.vMovement = (this.L37JAhXgVX.vDirection - this.transform.position).normalized;
						if (257442 - 222351 == 35092)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.L37JAhXgVX.vMovement);
						if (67906 - 361276 == -293369)
						{
							continue;
						}
						this.L37JAhXgVX.actionState = "run";
						if (92286 - 535211 == -442924)
						{
							continue;
						}
						this.animation.Play("run");
						if (297479 - 416810 == -119330)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (220344 - 326481 != -106137)
						{
							continue;
						}
					}
					this.L37JAhXgVX.moveSpeed = Mathf.Lerp(this.L37JAhXgVX.moveSpeed, this.L37JAhXgVX.runSpeed, (float)4 * Time.deltaTime);
					if (194900 - 106666 != 88234)
					{
						continue;
					}
				}
			}
			this.QnXJu0PFi6 += mTime;
		}
		while (158676 - 385389 != -226713);
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x001975BC File Offset: 0x001957BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (83506 - 48825 != 34682)
		{
		}
		do
		{
			if (Time.time - this.DCAJW9cmPZ >= this.QnXJu0PFi6)
			{
				if (218417 - 558077 != -339660)
				{
					continue;
				}
				if (Time.time - this.DCAJW9cmPZ < this.QnXJu0PFi6 + mTime)
				{
					if (169462 - 84670 == 84793)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (231416 - 319426 == -88009)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (255167 - 493884 != -238717)
						{
							continue;
						}
						this.DCAJW9cmPZ = Time.time - mTime - this.QnXJu0PFi6;
						if (214155 - 371032 == -156876)
						{
							continue;
						}
						this.L37JAhXgVX.vDirection = Vector3.zero;
						if (234294 - 317311 != -83017)
						{
							continue;
						}
						this.L37JAhXgVX.vMovement = this.transform.forward;
						if (246707 - 241735 == 4973)
						{
							continue;
						}
						this.L37JAhXgVX.actionState = "standby";
						if (186557 - 233621 != -47064)
						{
							continue;
						}
						this.L37JAhXgVX.myAttackTarget = this.L37JAhXgVX.getHateTarget(5, 50);
						if (137305 - 287664 == -150358)
						{
							continue;
						}
						if (!this.L37JAhXgVX.myAttackTarget)
						{
							if (36012 - 145908 == -109895)
							{
								continue;
							}
							this.L37JAhXgVX.isAlert = false;
							if (6304 - 458346 != -452042)
							{
								continue;
							}
							this.DCAJW9cmPZ = Time.time;
							if (21035 - 65686 != -44651)
							{
								continue;
							}
							this.L37JAhXgVX.myAttackTarget = null;
							if (227044 - 173793 != 53251)
							{
								continue;
							}
							this.L37JAhXgVX.mOriginalPosition = this.transform.position;
							if (43083 - 39385 != 3699)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.L37JAhXgVX.myAttackTarget;
							if (78282 - 281309 == -203026)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (53723 - 18243 == 35481)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (290648 - 48014 == 242635)
								{
									continue;
								}
								this.L37JAhXgVX.isAlert = false;
								if (124933 - 438512 == -313578)
								{
									continue;
								}
								this.DCAJW9cmPZ = Time.time;
								if (210140 - 134556 == 75585)
								{
									continue;
								}
								this.L37JAhXgVX.myAttackTarget = null;
								if (163563 - 427105 == -263541)
								{
									continue;
								}
							}
							else
							{
								this.L37JAhXgVX.vDirection = myAttackTarget.transform.position;
								if (44595 - 140593 != -95998)
								{
									continue;
								}
								this.L37JAhXgVX.vDirection.y = this.transform.position.y;
								if (178286 - 483455 == -305168)
								{
									continue;
								}
								this.L37JAhXgVX.vMovement = (this.L37JAhXgVX.vDirection - this.transform.position).normalized;
								if (164239 - 31018 == 133222)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.L37JAhXgVX.vMovement);
								if (129421 - 505729 != -376308)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.QnXJu0PFi6 += mTime;
		}
		while (241932 - 87303 == 154630);
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x00197A6C File Offset: 0x00195C6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (339 - 160099 != -159759)
		{
		}
		do
		{
			if (Time.time - this.DCAJW9cmPZ >= this.QnXJu0PFi6)
			{
				if (249840 - 312459 == -62618)
				{
					continue;
				}
				if (Time.time - this.DCAJW9cmPZ < this.QnXJu0PFi6 + mTime)
				{
					if (195770 - 527822 != -332052)
					{
						continue;
					}
					if (!this.L37JAhXgVX.myAttackTarget)
					{
						if (109089 - 332470 != -223381)
						{
							continue;
						}
						this.DCAJW9cmPZ = Time.time - mTime - this.QnXJu0PFi6;
						if (190405 - 172044 != 18361)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.L37JAhXgVX.myAttackTarget;
						if (97594 - 86972 == 10623)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (87606 - 91603 == -3996)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (192080 - 543468 != -351388)
						{
							continue;
						}
						Gadina gadina = (Gadina)this.gameObject.GetComponent(typeof(Gadina));
						if (60958 - 495735 == -434776)
						{
							continue;
						}
						eGadinaType gadinaType = gadina.GadinaType;
						if (35259 - 35168 == 92)
						{
							continue;
						}
						float num2 = (float)0;
						if (176219 - 136608 != 39611)
						{
							continue;
						}
						eGadinaType eGadinaType = gadinaType;
						if (72915 - 199094 == -126178)
						{
							continue;
						}
						if (eGadinaType == eGadinaType.Gadina1)
						{
							if (144013 - 300258 == -156244)
							{
								continue;
							}
							num2 = (float)2;
							if (235575 - 339393 == -103817)
							{
								continue;
							}
						}
						else if (eGadinaType == eGadinaType.Gadina2)
						{
							if (144735 - 309244 != -164509)
							{
								continue;
							}
							num2 = (float)3;
							if (144068 - 36491 == 107578)
							{
								continue;
							}
						}
						else if (eGadinaType == eGadinaType.Gadina3)
						{
							if (48538 - 495127 == -446588)
							{
								continue;
							}
							num2 = (float)4;
							if (20272 - 233403 == -213130)
							{
								continue;
							}
						}
						else if (eGadinaType == eGadinaType.Gadina4)
						{
							if (118764 - 41685 != 77079)
							{
								continue;
							}
							num2 = (float)4;
							if (57669 - 339529 != -281860)
							{
								continue;
							}
						}
						if (this.L37JAhXgVX.hasSkill(413))
						{
							if (273860 - 247853 != 26007)
							{
								continue;
							}
							if ((float)this.L37JAhXgVX.hp < 0.25f * (float)this.L37JAhXgVX.mhp)
							{
								if (98226 - 129319 == -31092)
								{
									continue;
								}
								if (this.L37JAhXgVX.isTimeOut("earthGuard") == (float)0)
								{
									if (262436 - 7312 == 255125)
									{
										continue;
									}
									this.DCAJW9cmPZ = Time.time - mTime - this.QnXJu0PFi6;
									if (14904 - 158547 == -143642)
									{
										continue;
									}
									gadina.StartCoroutine_Auto(gadina.RPC_earthGuard(this.transform.position, this.transform.forward, 0));
									if (93719 - 591817 != -498098)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (270080 - 230248 != 39832)
										{
											continue;
										}
										gadina.ActionEvent("RPC_earthGuard", this.transform.position, this.transform.forward, 0);
										if (211072 - 557790 != -346718)
										{
											continue;
										}
									}
									goto IL_6E4;
								}
							}
						}
						if (num < num2)
						{
							if (113577 - 147840 == -34262)
							{
								continue;
							}
							if (this.L37JAhXgVX.isTimeOut("nAttack") == (float)0)
							{
								if (68094 - 2711 == 65384)
								{
									continue;
								}
								this.DCAJW9cmPZ = Time.time - mTime - this.QnXJu0PFi6;
								if (164562 - 257077 != -92515)
								{
									continue;
								}
								eGadinaType eGadinaType2 = gadinaType;
								if (117528 - 300004 != -182475)
								{
									if (eGadinaType2 == eGadinaType.Gadina1)
									{
										if (184297 - 400024 != -215727)
										{
											continue;
										}
										gadina.StartCoroutine_Auto(gadina.RPC_nAttack1(this.transform.position, vector, 0));
										if (36933 - 377200 == -340266)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (76139 - 290789 == -214649)
											{
												continue;
											}
											gadina.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
											if (101508 - 524563 == -423054)
											{
												continue;
											}
										}
									}
									else if (eGadinaType2 == eGadinaType.Gadina2)
									{
										if (181357 - 140087 == 41271)
										{
											continue;
										}
										gadina.StartCoroutine_Auto(gadina.RPC_nAttack2(this.transform.position, vector, 0));
										if (269641 - 257641 == 12001)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (85469 - 38213 == 47257)
											{
												continue;
											}
											gadina.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
											if (173946 - 386547 == -212600)
											{
												continue;
											}
										}
									}
									else if (eGadinaType2 == eGadinaType.Gadina3)
									{
										if (11932 - 540065 != -528133)
										{
											continue;
										}
										gadina.StartCoroutine_Auto(gadina.RPC_nAttack3(this.transform.position, vector, 0));
										if (5850 - 282674 == -276823)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (36801 - 550235 != -513434)
											{
												continue;
											}
											gadina.ActionEvent("RPC_nAttack3", this.transform.position, vector, 0);
											if (76185 - 236505 == -160319)
											{
												continue;
											}
										}
									}
									else if (eGadinaType2 == eGadinaType.Gadina4)
									{
										if (164349 - 510980 != -346631)
										{
											continue;
										}
										gadina.StartCoroutine_Auto(gadina.RPC_nAttack4(this.transform.position, vector, 0));
										if (94829 - 102473 != -7644)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (247294 - 523115 != -275821)
											{
												continue;
											}
											gadina.ActionEvent("RPC_nAttack4", this.transform.position, vector, 0);
											if (94190 - 415770 == -321579)
											{
												continue;
											}
										}
									}
									goto IL_6E4;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (15128 - 224496 != -209368)
						{
							continue;
						}
						this.L37JAhXgVX.vDirection = myAttackTarget.transform.position;
						if (224680 - 575235 != -350555)
						{
							continue;
						}
						this.L37JAhXgVX.vDirection.y = this.transform.position.y;
						if (205161 - 456887 != -251726)
						{
							continue;
						}
						this.L37JAhXgVX.vMovement = (this.L37JAhXgVX.vDirection - this.transform.position).normalized;
						if (164575 - 418721 == -254145)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.L37JAhXgVX.vMovement);
						if (138721 - 288557 != -149836)
						{
							continue;
						}
						this.L37JAhXgVX.actionState = "run";
						if (85960 - 148286 != -62326)
						{
							continue;
						}
						this.animation.Play("run");
						if (15730 - 353073 != -337343)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (239457 - 383287 != -143830)
						{
							continue;
						}
						this.L37JAhXgVX.moveSpeed = Mathf.Lerp(this.L37JAhXgVX.moveSpeed, this.L37JAhXgVX.runSpeed, (float)4 * Time.deltaTime);
						if (113790 - 74898 == 38893)
						{
							continue;
						}
					}
				}
			}
			IL_6E4:
			this.QnXJu0PFi6 += mTime;
		}
		while (135371 - 516244 != -380873);
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x00198484 File Offset: 0x00196684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_setTimer(float nTime)
	{
		this.AI_state = "none";
		this.DCAJW9cmPZ = Time.time - nTime;
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x001984A0 File Offset: 0x001966A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (67797 - 309895 != -242097)
		{
		}
		while (Time.time - this.DCAJW9cmPZ > this.QnXJu0PFi6)
		{
			if (143138 - 351568 == -208430)
			{
				this.AI_state = "none";
				if (3148 - 191032 == -187884)
				{
					this.DCAJW9cmPZ = Time.time;
					if (142065 - 12024 == 130041)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x00198554 File Offset: 0x00196754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (143464 - 159006 != -15541)
		{
		}
		for (;;)
		{
			IL_197:
			if (this.LOqJysTAFJ + (float)1 > Time.time)
			{
				if (169856 - 320118 == -150262)
				{
					break;
				}
			}
			else
			{
				this.LOqJysTAFJ = Time.time;
				if (3765 - 73299 != -69533)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)24, this.gameObject.layer);
					if (95467 - 540401 != -444933)
					{
						if (220913 - 197316 == 23597)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (185136 - 135098 != 50039)
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
									if (57746 - 263314 != -205568)
									{
										goto IL_197;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (32211 - 66062 == -33850)
									{
										goto IL_197;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (138437 - 322702 != -184265)
									{
										goto IL_197;
									}
									bool flag = true;
									if (270501 - 303399 != -32898)
									{
										goto IL_197;
									}
									if (this.L37JAhXgVX.isSummon)
									{
										if (295627 - 310814 == -15186)
										{
											goto IL_197;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_4BF;
										}
										if (209832 - 248019 != -38187)
										{
											goto IL_197;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (54480 - 544311 != -489830)
											{
												goto IL_4BF;
											}
											goto IL_197;
										}
										goto IL_70;
										IL_4BF:
										flag = false;
										if (134336 - 412989 == -278652)
										{
											goto IL_197;
										}
									}
									else
									{
										if (characterControl.Race != eRace.Plants)
										{
											if (67197 - 213956 != -146759)
											{
												goto IL_197;
											}
											if (characterControl.Race != eRace.Bugs)
											{
												if (90602 - 487359 == -396756)
												{
													goto IL_197;
												}
												if (characterControl.Race != eRace.Structure)
												{
													goto IL_70;
												}
												if (241400 - 9237 != 232163)
												{
													goto IL_197;
												}
											}
										}
										flag = false;
										if (34872 - 93265 == -58392)
										{
											goto IL_197;
										}
									}
									IL_70:
									if (flag)
									{
										if (80197 - 169027 != -88830)
										{
											goto IL_197;
										}
										if (characterControl.hp > 0)
										{
											if (185848 - 378040 == -192191)
											{
												goto IL_197;
											}
											if (characterControl.recieveTarget)
											{
												if (154338 - 385942 == -231603)
												{
													goto IL_197;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (188379 - 447000 == -258620)
													{
														goto IL_197;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (153892 - 82783 == 71110)
														{
															goto IL_197;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (142620 - 248042 == -105421)
														{
															goto IL_197;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (29509 - 599956 != -570447)
															{
																goto IL_197;
															}
															this.L37JAhXgVX.isAlert = true;
															if (18533 - 235418 == -216884)
															{
																goto IL_197;
															}
															this.DCAJW9cmPZ = Time.time;
															if (85701 - 452286 == -366584)
															{
																goto IL_197;
															}
															this.L37JAhXgVX.myAttackTarget = gameObject;
															if (53130 - 247937 == -194806)
															{
																goto IL_197;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (272279 - 279364 == -7084)
															{
																goto IL_197;
															}
															this.L37JAhXgVX.addHate(characterControl.ActorNr, 5);
															if (26115 - 141016 == -114900)
															{
																goto IL_197;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (26384 - 171817 != -145433)
															{
																goto IL_197;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (289429 - 598392 == -308962)
															{
																goto IL_197;
															}
															if (num < (float)60)
															{
																if (29750 - 139045 != -109295)
																{
																	goto IL_197;
																}
																if (characterControl.hp > 0)
																{
																	if (16898 - 33298 == -16399)
																	{
																		goto IL_197;
																	}
																	this.L37JAhXgVX.isAlert = true;
																	if (64713 - 233805 != -169092)
																	{
																		goto IL_197;
																	}
																	this.DCAJW9cmPZ = Time.time;
																	if (264954 - 43123 != 221831)
																	{
																		goto IL_197;
																	}
																	this.L37JAhXgVX.myAttackTarget = gameObject;
																	if (85592 - 248582 == -162989)
																	{
																		goto IL_197;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (145565 - 290082 == -144516)
																	{
																		goto IL_197;
																	}
																	this.L37JAhXgVX.addHate(characterControl.ActorNr, 5);
																	if (183206 - 208447 == -25240)
																	{
																		goto IL_197;
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
								if (171244 - 449298 != -278053)
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

	// Token: 0x0600101A RID: 4122 RVA: 0x00198BB8 File Offset: 0x00196DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00198BBC File Offset: 0x00196DBC
	internal static bool tQeecKEe1f2IG3B5Qnx()
	{
		return true;
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x00198BC0 File Offset: 0x00196DC0
	internal static bool fkGj9AErnre5ffd9lY1()
	{
		return false;
	}

	// Token: 0x04000E03 RID: 3587
	private CharacterControl L37JAhXgVX;

	// Token: 0x04000E04 RID: 3588
	private Gadina peMJ9nF6Jq;

	// Token: 0x04000E05 RID: 3589
	public string AI_state;

	// Token: 0x04000E06 RID: 3590
	private float DCAJW9cmPZ;

	// Token: 0x04000E07 RID: 3591
	private float QnXJu0PFi6;

	// Token: 0x04000E08 RID: 3592
	private float LOqJysTAFJ;
}
