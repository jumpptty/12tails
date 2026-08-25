using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D46 RID: 3398
[Serializable]
public class Panther_AI : MonoBehaviour
{
	// Token: 0x06004C6F RID: 19567 RVA: 0x0096EE7C File Offset: 0x0096D07C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Panther_AI()
	{
		if (44705 - 121765 != -77059)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (298535 - 545751 != -247215)
			{
				base..ctor();
				if (161986 - 274178 != -112191)
				{
					this.AI_state = "none";
					if (48020 - 279123 != -231102)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004C70 RID: 19568 RVA: 0x0096EF18 File Offset: 0x0096D118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (191189 - 123692 != 67498)
		{
		}
		for (;;)
		{
			this.Lqvccafx8lg = this.transform;
			if (155446 - 51664 != 103783)
			{
				this.UmKcc486yUR = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (34604 - 427524 != -392919)
				{
					this.GxvccsbJfLu = (Panther)this.GetComponent(typeof(Panther));
					if (183986 - 444470 == -260484)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004C71 RID: 19569 RVA: 0x0096EFE0 File Offset: 0x0096D1E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (14747 - 394525 != -379778)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (296425 - 218043 != 78382)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (141238 - 69143 == 72096)
				{
					continue;
				}
			}
			if (this.UmKcc486yUR.isControlled)
			{
				break;
			}
			if (244775 - 360124 != -115348)
			{
				this.AIControl();
				if (273468 - 133262 == 140206)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004C72 RID: 19570 RVA: 0x0096F0AC File Offset: 0x0096D2AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (215505 - 423147 != -207641)
		{
		}
		for (;;)
		{
			this.YSlcc7TD5Sm = (float)0;
			if (79607 - 511102 != -431494)
			{
				if (this.UmKcc486yUR.isMine)
				{
					if (39009 - 54025 != -15015)
					{
						if (this.UmKcc486yUR.actionState != "standby")
						{
							if (51878 - 153169 == -101290)
							{
								continue;
							}
							if (this.UmKcc486yUR.actionState != "run")
							{
								if (112442 - 211856 != -99413)
								{
									break;
								}
								continue;
							}
						}
						if (!this.UmKcc486yUR.isAlert)
						{
							if (149215 - 439304 == -290089)
							{
								if (this.UmKcc486yUR.isSummon)
								{
									if (191507 - 284072 != -92565)
									{
										continue;
									}
									if (this.UmKcc486yUR.mSummoner != null)
									{
										if (51179 - 496729 != -445550)
										{
											continue;
										}
										Vector3 vector = this.UmKcc486yUR.mSummoner.transform.position - this.transform.position;
										if (221849 - 576336 != -354486)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (170936 - 193653 != -22717)
												{
													continue;
												}
												this.AI_follow(this.UmKcc486yUR.mSummoner);
												if (118591 - 60042 != 58549)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (165020 - 291592 == -126571)
												{
													continue;
												}
												this.AI_resetTimer();
												if (100495 - 190879 != -90384)
												{
													continue;
												}
												this.AI_visionCheck();
												if (157397 - 520412 == -363014)
												{
													continue;
												}
											}
											goto IL_CEB;
										}
										continue;
									}
								}
								if (Game.mGameCode != 915)
								{
									if (152030 - 281822 == -129791)
									{
										continue;
									}
									if (Game.mGameCode == 916)
									{
										if (225422 - 370282 != -144860)
										{
											continue;
										}
									}
									else
									{
										this.AI_idle(3f, 1f);
										if (36308 - 162267 == -125958)
										{
											continue;
										}
										this.AI_resetTimer();
										if (282610 - 118696 == 163915)
										{
											continue;
										}
										this.AI_visionCheck();
										if (162740 - 118751 != 43989)
										{
											continue;
										}
										goto IL_CEB;
									}
								}
								this.AI_idle(2f, 1f);
								if (88800 - 251382 == -162581)
								{
									continue;
								}
								this.AI_goToPosition(this.UmKcc486yUR.mOriginalPosition, 6f, 2f);
								if (231457 - 439831 == -208373)
								{
									continue;
								}
								this.AI_resetTimer();
								if (101939 - 316208 != -214269)
								{
									continue;
								}
								this.AI_visionCheck();
								if (116780 - 495354 == -378573)
								{
									continue;
								}
								IL_CEB:
								if (!this.UmKcc486yUR.myAttackTarget)
								{
									break;
								}
								if (202083 - 520510 != -318426)
								{
									this.UmKcc486yUR.isAlert = true;
									if (266754 - 451601 == -184847)
									{
										this.crGccHF4JMa = Time.time;
										if (276534 - 5724 == 270810)
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
							if (109265 - 285042 == -175777)
							{
								this.AI_battle(2f, 1f);
								if (173509 - 80922 == 92587)
								{
									this.AI_attack(6f, (float)0);
									if (213055 - 223015 == -9960)
									{
										this.AI_resetTimer();
										if (172093 - 195041 != -22947)
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
					if (this.UmKcc486yUR.actionState != "standby")
					{
						if (239996 - 329791 == -89794)
						{
							continue;
						}
						if (this.UmKcc486yUR.actionState != "run")
						{
							if (258876 - 264044 != -5167)
							{
								break;
							}
							continue;
						}
					}
					if (this.UmKcc486yUR.nSpeed != (float)0)
					{
						if (203199 - 120362 == 82838)
						{
							continue;
						}
						if (this.UmKcc486yUR.nPosition != this.UmKcc486yUR.oPosition)
						{
							if (215598 - 129574 == 86025)
							{
								continue;
							}
							Vector3 a = this.UmKcc486yUR.nPosition + 0.1f * this.UmKcc486yUR.runSpeed * this.UmKcc486yUR.nDirection;
							if (83752 - 81386 != 2366)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.Lqvccafx8lg.position);
							if (185131 - 65184 == 119948)
							{
								continue;
							}
							Vector3 normalized = vector2.normalized;
							if (298674 - 431107 != -132433)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.Lqvccafx8lg.position);
							if (134933 - 296559 != -161626)
							{
								continue;
							}
							float magnitude = vector3.magnitude;
							if (187904 - 580831 == -392926)
							{
								continue;
							}
							if (magnitude > this.UmKcc486yUR.runSpeed)
							{
								if (169919 - 567258 != -397339)
								{
									continue;
								}
								this.Lqvccafx8lg.position = this.UmKcc486yUR.nPosition;
								if (176986 - 593286 != -416300)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.UmKcc486yUR.runSpeed)
							{
								if (153749 - 106165 == 47585)
								{
									continue;
								}
								this.UmKcc486yUR.moveSpeed = Mathf.Lerp(this.UmKcc486yUR.moveSpeed, 1.1f * this.UmKcc486yUR.runSpeed, (float)10 * Time.deltaTime);
								if (116946 - 282286 != -165340)
								{
									continue;
								}
								this.UmKcc486yUR.vDirection = normalized;
								if (288552 - 484252 == -195699)
								{
									continue;
								}
								this.UmKcc486yUR.vMovement = normalized;
								if (231171 - 548593 == -317421)
								{
									continue;
								}
								if (Vector3.Dot(this.Lqvccafx8lg.forward, normalized) > (float)0)
								{
									if (15385 - 547082 != -531697)
									{
										continue;
									}
									this.Lqvccafx8lg.rotation = Quaternion.LookRotation(Vector3.Slerp(this.Lqvccafx8lg.forward, normalized, (float)10 * Time.deltaTime));
									if (195392 - 381473 != -186081)
									{
										continue;
									}
								}
								else
								{
									this.Lqvccafx8lg.rotation = Quaternion.LookRotation(normalized);
									if (212323 - 568427 == -356103)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (171071 - 191462 == -20390)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (227736 - 324767 != -97031)
								{
									continue;
								}
								break;
							}
							else
							{
								this.UmKcc486yUR.moveSpeed = Mathf.Lerp(this.UmKcc486yUR.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (187549 - 478452 == -290902)
								{
									continue;
								}
								this.UmKcc486yUR.vDirection = normalized;
								if (280817 - 58692 != 222125)
								{
									continue;
								}
								this.UmKcc486yUR.vMovement = normalized;
								if (215389 - 198202 != 17187)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (43621 - 579549 == -535927)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (197914 - 161456 != 36459)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.UmKcc486yUR.moveSpeed != (float)0)
					{
						if (64313 - 318056 == -253743)
						{
							Vector3 vector4 = global::Math.vFlat(this.UmKcc486yUR.nPosition - this.Lqvccafx8lg.position);
							if (265447 - 521492 == -256045)
							{
								float sqrMagnitude = vector4.sqrMagnitude;
								if (184090 - 229236 == -45146)
								{
									if (sqrMagnitude > this.UmKcc486yUR.runSpeed)
									{
										if (229789 - 529092 == -299303)
										{
											this.Lqvccafx8lg.position = this.UmKcc486yUR.nPosition;
											if (199941 - 520104 == -320163)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (140503 - 118612 == 21891)
										{
											if (sqrMagnitude > (float)1)
											{
												if (60595 - 246867 != -186272)
												{
													continue;
												}
												this.UmKcc486yUR.moveSpeed = Mathf.Lerp(this.UmKcc486yUR.moveSpeed, this.UmKcc486yUR.runSpeed, (float)10 * Time.deltaTime);
												if (120944 - 595339 != -474395)
												{
													continue;
												}
											}
											else
											{
												this.UmKcc486yUR.moveSpeed = Mathf.Lerp(this.UmKcc486yUR.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (1770 - 451980 == -450209)
												{
													continue;
												}
											}
											this.UmKcc486yUR.vMovement = vector4;
											if (263197 - 579505 != -316307)
											{
												this.UmKcc486yUR.vDirection = vector4;
												if (70674 - 72521 == -1847)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.Lqvccafx8lg.forward, vector4, (float)10 * Time.deltaTime));
													if (37265 - 213856 == -176591)
													{
														this.animation.CrossFade("run", 0.2f);
														if (218561 - 451961 == -233400)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (11545 - 432471 != -420925)
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
										this.UmKcc486yUR.vMovement = vector4;
										if (5376 - 516269 == -510893)
										{
											this.UmKcc486yUR.moveSpeed = (float)0;
											if (123907 - 521174 != -397266)
											{
												this.transform.rotation = Quaternion.LookRotation(this.UmKcc486yUR.vDirection);
												if (290173 - 296861 != -6687)
												{
													this.animation.CrossFade("root", 0.2f);
													if (133321 - 254908 != -121586)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (229801 - 341536 != -111734)
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
						if (202468 - 411145 == -208677)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (222569 - 148784 == 73785)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004C73 RID: 19571 RVA: 0x0096FE5C File Offset: 0x0096E05C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (96793 - 197351 != -100557)
		{
		}
		do
		{
			if (Time.time - this.crGccHF4JMa >= this.YSlcc7TD5Sm)
			{
				if (79390 - 505228 == -425837)
				{
					continue;
				}
				if (Time.time - this.crGccHF4JMa < this.YSlcc7TD5Sm + mTime)
				{
					if (109490 - 539246 == -429755)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (274021 - 451771 != -177750)
						{
							continue;
						}
						this.AI_state = "idle";
						if (284260 - 440749 != -156489)
						{
							continue;
						}
						this.crGccHF4JMa -= UnityEngine.Random.Range((float)0, rTimer);
						if (213206 - 475614 == -262407)
						{
							continue;
						}
						this.UmKcc486yUR.vDirection = Vector3.zero;
						if (258931 - 49261 == 209671)
						{
							continue;
						}
						this.UmKcc486yUR.vMovement = this.Lqvccafx8lg.forward;
						if (108727 - 87479 != 21248)
						{
							continue;
						}
						this.UmKcc486yUR.actionState = "standby";
						if (208660 - 490683 == -282022)
						{
							continue;
						}
					}
					this.UmKcc486yUR.moveSpeed = Mathf.Lerp(this.UmKcc486yUR.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (256022 - 64186 == 191837)
					{
						continue;
					}
					if (this.UmKcc486yUR.moveSpeed < 0.1f * this.UmKcc486yUR.runSpeed)
					{
						if (141860 - 238996 == -97135)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (259423 - 475406 == -215982)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (217664 - 365406 == -147741)
						{
							continue;
						}
						this.UmKcc486yUR.moveSpeed = (float)0;
						if (881 - 196707 != -195826)
						{
							continue;
						}
					}
				}
			}
			this.YSlcc7TD5Sm += mTime;
		}
		while (280901 - 557025 != -276124);
	}

	// Token: 0x06004C74 RID: 19572 RVA: 0x00970120 File Offset: 0x0096E320
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_goToPosition(Vector3 tPosition, float mTime, float rTimer)
	{
		if (113349 - 252955 != -139606)
		{
		}
		do
		{
			if (Time.time - this.crGccHF4JMa >= this.YSlcc7TD5Sm)
			{
				if (147034 - 502746 == -355711)
				{
					continue;
				}
				if (Time.time - this.crGccHF4JMa < this.YSlcc7TD5Sm + mTime)
				{
					if (234213 - 284081 != -49868)
					{
						continue;
					}
					if (this.AI_state != "goToPosition")
					{
						if (181275 - 435092 != -253817)
						{
							continue;
						}
						this.AI_state = "goToPosition";
						if (253390 - 454319 == -200928)
						{
							continue;
						}
						this.crGccHF4JMa -= UnityEngine.Random.Range((float)0, rTimer);
						if (196597 - 408642 == -212044)
						{
							continue;
						}
					}
					Vector3 vector = this.Lqvccafx8lg.position - tPosition;
					if (250311 - 244692 != 5619)
					{
						continue;
					}
					if (vector.sqrMagnitude > (float)1)
					{
						if (197341 - 430835 == -233493)
						{
							continue;
						}
						this.UmKcc486yUR.vDirection = tPosition;
						if (290312 - 266548 != 23764)
						{
							continue;
						}
						this.UmKcc486yUR.vDirection.y = this.Lqvccafx8lg.position.y;
						if (132523 - 212429 == -79905)
						{
							continue;
						}
						this.UmKcc486yUR.vMovement = (tPosition - this.Lqvccafx8lg.position).normalized;
						if (22942 - 488502 != -465560)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.UmKcc486yUR.vMovement);
						if (202208 - 79199 != 123009)
						{
							continue;
						}
						this.UmKcc486yUR.actionState = "run";
						if (120487 - 382550 != -262063)
						{
							continue;
						}
						this.animation.Play("run");
						if (240341 - 107306 != 133035)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (246697 - 387398 == -140700)
						{
							continue;
						}
						this.UmKcc486yUR.moveSpeed = Mathf.Lerp(this.UmKcc486yUR.moveSpeed, this.UmKcc486yUR.runSpeed, (float)4 * Time.deltaTime);
						if (127628 - 377559 != -249931)
						{
							continue;
						}
					}
					else
					{
						this.UmKcc486yUR.vDirection = this.Lqvccafx8lg.position + this.UmKcc486yUR.mOriginalDirection;
						if (53000 - 15259 == 37742)
						{
							continue;
						}
						this.UmKcc486yUR.vMovement = this.UmKcc486yUR.mOriginalDirection;
						if (241786 - 118762 == 123025)
						{
							continue;
						}
						this.UmKcc486yUR.moveSpeed = (float)0;
						if (247663 - 310374 == -62710)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.UmKcc486yUR.vMovement);
						if (181968 - 595951 != -413983)
						{
							continue;
						}
						this.crGccHF4JMa = Time.time - mTime - this.YSlcc7TD5Sm;
						if (195125 - 634 == 194492)
						{
							continue;
						}
					}
				}
			}
			this.YSlcc7TD5Sm += mTime;
		}
		while (50672 - 308351 != -257679);
	}

	// Token: 0x06004C75 RID: 19573 RVA: 0x00970554 File Offset: 0x0096E754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (145069 - 63204 != 81866)
		{
		}
		for (;;)
		{
			this.UmKcc486yUR.vDirection = followObject.transform.position;
			if (233214 - 551613 != -318398)
			{
				this.UmKcc486yUR.vDirection.y = this.transform.position.y;
				if (242366 - 61043 != 181324)
				{
					this.UmKcc486yUR.vMovement = (this.UmKcc486yUR.vDirection - this.transform.position).normalized;
					if (287289 - 430855 != -143565)
					{
						this.transform.rotation = Quaternion.LookRotation(this.UmKcc486yUR.vMovement);
						if (54443 - 527434 == -472991)
						{
							this.UmKcc486yUR.actionState = "run";
							if (100211 - 490919 == -390708)
							{
								this.animation.Play("run");
								if (264579 - 395907 != -131327)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (108720 - 328188 == -219468)
									{
										this.UmKcc486yUR.moveSpeed = Mathf.Lerp(this.UmKcc486yUR.moveSpeed, this.UmKcc486yUR.runSpeed, (float)4 * Time.deltaTime);
										if (236360 - 389078 != -152717)
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

	// Token: 0x06004C76 RID: 19574 RVA: 0x0097073C File Offset: 0x0096E93C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (239309 - 415291 != -175981)
		{
		}
		do
		{
			if (Time.time - this.crGccHF4JMa >= this.YSlcc7TD5Sm)
			{
				if (91945 - 105795 != -13850)
				{
					continue;
				}
				if (Time.time - this.crGccHF4JMa < this.YSlcc7TD5Sm + mTime)
				{
					if (93226 - 404900 == -311673)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (284073 - 490192 != -206119)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (180657 - 111428 == 69230)
						{
							continue;
						}
						this.crGccHF4JMa -= UnityEngine.Random.Range((float)0, rTimer);
						if (231446 - 51789 != 179657)
						{
							continue;
						}
						this.UmKcc486yUR.vDirection = this.UmKcc486yUR.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (238556 - 34102 == 204455)
						{
							continue;
						}
						this.UmKcc486yUR.vDirection.y = this.Lqvccafx8lg.position.y;
						if (41971 - 235314 != -193343)
						{
							continue;
						}
						this.UmKcc486yUR.vMovement = (this.UmKcc486yUR.vDirection - this.Lqvccafx8lg.position).normalized;
						if (264796 - 161410 == 103387)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.UmKcc486yUR.vMovement);
						if (297049 - 419451 == -122401)
						{
							continue;
						}
						this.UmKcc486yUR.actionState = "run";
						if (255847 - 591796 == -335948)
						{
							continue;
						}
						this.animation.Play("run");
						if (154508 - 478454 != -323946)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (273548 - 406422 == -132873)
						{
							continue;
						}
					}
					this.UmKcc486yUR.moveSpeed = Mathf.Lerp(this.UmKcc486yUR.moveSpeed, this.UmKcc486yUR.runSpeed, (float)4 * Time.deltaTime);
					if (70022 - 447823 == -377800)
					{
						continue;
					}
				}
			}
			this.YSlcc7TD5Sm += mTime;
		}
		while (38686 - 70946 == -32259);
	}

	// Token: 0x06004C77 RID: 19575 RVA: 0x00970A44 File Offset: 0x0096EC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (51656 - 288893 != -237237)
		{
		}
		do
		{
			if (Time.time - this.crGccHF4JMa >= this.YSlcc7TD5Sm)
			{
				if (249668 - 218204 != 31464)
				{
					continue;
				}
				if (Time.time - this.crGccHF4JMa < this.YSlcc7TD5Sm + mTime)
				{
					if (212450 - 15450 == 197001)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (280566 - 33361 != 247205)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (99309 - 557952 != -458643)
						{
							continue;
						}
						this.crGccHF4JMa = Time.time - mTime - this.YSlcc7TD5Sm;
						if (151485 - 92293 == 59193)
						{
							continue;
						}
						this.UmKcc486yUR.vDirection = Vector3.zero;
						if (62400 - 355443 != -293043)
						{
							continue;
						}
						this.UmKcc486yUR.vMovement = this.Lqvccafx8lg.forward;
						if (97470 - 368339 != -270869)
						{
							continue;
						}
						this.UmKcc486yUR.actionState = "standby";
						if (124069 - 224872 == -100802)
						{
							continue;
						}
						this.UmKcc486yUR.myAttackTarget = this.UmKcc486yUR.getHateTarget(5, 50);
						if (254954 - 173840 != 81114)
						{
							continue;
						}
						if (!this.UmKcc486yUR.myAttackTarget)
						{
							if (41210 - 318744 != -277534)
							{
								continue;
							}
							this.UmKcc486yUR.isAlert = false;
							if (241086 - 440062 != -198976)
							{
								continue;
							}
							this.crGccHF4JMa = Time.time;
							if (207131 - 405787 != -198656)
							{
								continue;
							}
							this.UmKcc486yUR.myAttackTarget = null;
							if (123700 - 517574 == -393873)
							{
								continue;
							}
							if (Game.mGameCode == 915)
							{
								break;
							}
							if (176087 - 322401 == -146313)
							{
								continue;
							}
							if (Game.mGameCode == 916)
							{
								break;
							}
							if (168351 - 35690 != 132661)
							{
								continue;
							}
							this.UmKcc486yUR.mOriginalPosition = this.Lqvccafx8lg.position;
							if (122140 - 378975 != -256835)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.UmKcc486yUR.myAttackTarget;
							if (290379 - 185243 == 105137)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (296476 - 207858 == 88619)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (50171 - 88775 == -38603)
								{
									continue;
								}
								this.UmKcc486yUR.isAlert = false;
								if (248546 - 297396 == -48849)
								{
									continue;
								}
								this.crGccHF4JMa = Time.time;
								if (34871 - 277540 == -242668)
								{
									continue;
								}
								this.UmKcc486yUR.myAttackTarget = null;
								if (262437 - 484248 == -221810)
								{
									continue;
								}
							}
							else
							{
								this.UmKcc486yUR.vDirection = myAttackTarget.transform.position;
								if (2438 - 184762 != -182324)
								{
									continue;
								}
								this.UmKcc486yUR.vDirection.y = this.Lqvccafx8lg.position.y;
								if (292336 - 222943 == 69394)
								{
									continue;
								}
								this.UmKcc486yUR.vMovement = (this.UmKcc486yUR.vDirection - this.Lqvccafx8lg.position).normalized;
								if (185809 - 469509 != -283700)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.UmKcc486yUR.vMovement);
								if (252030 - 142171 == 109860)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.YSlcc7TD5Sm += mTime;
		}
		while (194383 - 587344 == -392960);
	}

	// Token: 0x06004C78 RID: 19576 RVA: 0x00970F44 File Offset: 0x0096F144
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_battle(float mTime, float rTimer)
	{
		if (219811 - 307525 != -87713)
		{
		}
		do
		{
			if (Time.time - this.crGccHF4JMa >= this.YSlcc7TD5Sm)
			{
				if (92551 - 228920 != -136369)
				{
					continue;
				}
				if (Time.time - this.crGccHF4JMa < this.YSlcc7TD5Sm + mTime)
				{
					if (148788 - 526768 == -377979)
					{
						continue;
					}
					if (!this.UmKcc486yUR.myAttackTarget)
					{
						if (220253 - 299038 != -78785)
						{
							continue;
						}
						this.crGccHF4JMa = Time.time - mTime - this.YSlcc7TD5Sm;
						if (284007 - 488626 != -204619)
						{
							continue;
						}
						break;
					}
					else if (this.AI_state != "battle")
					{
						if (249089 - 576163 == -327073)
						{
							continue;
						}
						GameObject myAttackTarget = this.UmKcc486yUR.myAttackTarget;
						if (56628 - 338487 != -281859)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.Lqvccafx8lg.position;
						if (163072 - 108847 != 54225)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (184605 - 102283 != 82322)
						{
							continue;
						}
						this.AI_state = "battle";
						if (165914 - 103494 != 62420)
						{
							continue;
						}
						this.UmKcc486yUR.vDirection = myAttackTarget.transform.position;
						if (119850 - 168756 == -48905)
						{
							continue;
						}
						this.UmKcc486yUR.vDirection.y = this.Lqvccafx8lg.position.y;
						if (262281 - 348196 == -85914)
						{
							continue;
						}
						this.UmKcc486yUR.vMovement = (this.UmKcc486yUR.vDirection - this.Lqvccafx8lg.position).normalized;
						if (167619 - 487861 != -320242)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.UmKcc486yUR.vMovement);
						if (173742 - 193247 != -19505)
						{
							continue;
						}
						this.UmKcc486yUR.actionState = "standby";
						if (50397 - 401760 != -351363)
						{
							continue;
						}
						this.animation.Play("battle");
						if (198929 - 336969 == -138039)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (6444 - 400442 == -393997)
						{
							continue;
						}
						this.UmKcc486yUR.moveSpeed = (float)0;
						if (30907 - 528643 == -497735)
						{
							continue;
						}
					}
				}
			}
			this.YSlcc7TD5Sm += mTime;
		}
		while (299553 - 62521 != 237032);
	}

	// Token: 0x06004C79 RID: 19577 RVA: 0x009712E8 File Offset: 0x0096F4E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (182815 - 335563 != -152747)
		{
		}
		do
		{
			if (Time.time - this.crGccHF4JMa >= this.YSlcc7TD5Sm)
			{
				if (260560 - 165588 == 94973)
				{
					continue;
				}
				if (Time.time - this.crGccHF4JMa < this.YSlcc7TD5Sm + mTime)
				{
					if (145644 - 228950 != -83306)
					{
						continue;
					}
					if (!this.UmKcc486yUR.myAttackTarget)
					{
						if (38831 - 59656 == -20824)
						{
							continue;
						}
						this.crGccHF4JMa = Time.time - mTime - this.YSlcc7TD5Sm;
						if (291407 - 484862 != -193454)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.UmKcc486yUR.myAttackTarget;
						if (139712 - 503968 == -364255)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (178117 - 87450 != 90667)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.Lqvccafx8lg.position;
						if (200138 - 483499 != -283361)
						{
							continue;
						}
						int tID = 0;
						if (125830 - 317822 != -191992)
						{
							continue;
						}
						if (characterControl)
						{
							if (56587 - 211802 == -155214)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (153671 - 597422 == -443750)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (17833 - 366642 == -348808)
						{
							continue;
						}
						if (num > (float)6)
						{
							if (76176 - 569628 == -493451)
							{
								continue;
							}
							if (num < (float)30)
							{
								if (242689 - 322915 == -80225)
								{
									continue;
								}
								if (this.UmKcc486yUR.isTimeOut("javelin") == (float)0)
								{
									if (197982 - 388458 == -190475)
									{
										continue;
									}
									this.crGccHF4JMa = Time.time - mTime - this.YSlcc7TD5Sm;
									if (267776 - 458599 == -190822)
									{
										continue;
									}
									this.GxvccsbJfLu.StartCoroutine_Auto(this.GxvccsbJfLu.RPC_javelin(this.Lqvccafx8lg.position, vector, tID));
									if (254031 - 135231 != 118800)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (199674 - 216899 != -17225)
										{
											continue;
										}
										this.GxvccsbJfLu.ActionEvent("RPC_javelin", this.Lqvccafx8lg.position, vector, tID);
										if (106448 - 556877 != -450429)
										{
											continue;
										}
									}
									goto IL_628;
								}
							}
						}
						if (num < (float)3)
						{
							if (197474 - 158977 != 38497)
							{
								continue;
							}
							if (this.UmKcc486yUR.isTimeOut("nAttack") == (float)0)
							{
								if (161257 - 130891 == 30367)
								{
									continue;
								}
								this.crGccHF4JMa = Time.time - mTime - this.YSlcc7TD5Sm;
								if (249706 - 309626 != -59920)
								{
									continue;
								}
								this.GxvccsbJfLu.StartCoroutine_Auto(this.GxvccsbJfLu.RPC_nAttack(this.Lqvccafx8lg.position, vector, 0));
								if (43087 - 214601 != -171513)
								{
									if (PhotonClient.IsInitialized())
									{
										if (149147 - 298384 == -149236)
										{
											continue;
										}
										this.GxvccsbJfLu.ActionEvent("RPC_nAttack", this.Lqvccafx8lg.position, vector, 0);
										if (280592 - 448182 != -167590)
										{
											continue;
										}
									}
									goto IL_628;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (134799 - 73202 != 61597)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (154468 - 475579 == -321110)
							{
								continue;
							}
							this.UmKcc486yUR.vDirection = myAttackTarget.transform.position;
							if (84268 - 160222 == -75953)
							{
								continue;
							}
							this.UmKcc486yUR.vDirection.y = this.Lqvccafx8lg.position.y;
							if (8466 - 12844 != -4378)
							{
								continue;
							}
							this.UmKcc486yUR.vMovement = (this.UmKcc486yUR.vDirection - this.Lqvccafx8lg.position).normalized;
							if (27526 - 513139 != -485613)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.UmKcc486yUR.vMovement);
							if (74613 - 453668 == -379054)
							{
								continue;
							}
							this.UmKcc486yUR.actionState = "standby";
							if (171846 - 563500 != -391654)
							{
								continue;
							}
							this.animation.Play("battle");
							if (19525 - 391121 != -371596)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (8960 - 214335 == -205374)
							{
								continue;
							}
							this.UmKcc486yUR.moveSpeed = (float)0;
							if (271208 - 477719 != -206511)
							{
								continue;
							}
						}
						else
						{
							this.UmKcc486yUR.vDirection = myAttackTarget.transform.position;
							if (237754 - 224393 == 13362)
							{
								continue;
							}
							this.UmKcc486yUR.vDirection.y = this.Lqvccafx8lg.position.y;
							if (49314 - 571755 == -522440)
							{
								continue;
							}
							this.UmKcc486yUR.vMovement = (this.UmKcc486yUR.vDirection - this.Lqvccafx8lg.position).normalized;
							if (122234 - 537124 == -414889)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.UmKcc486yUR.vMovement);
							if (144661 - 239063 != -94402)
							{
								continue;
							}
							this.UmKcc486yUR.actionState = "run";
							if (101015 - 383637 != -282622)
							{
								continue;
							}
							this.animation.Play("run");
							if (60786 - 595253 != -534467)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (159241 - 157726 == 1516)
							{
								continue;
							}
							this.UmKcc486yUR.moveSpeed = Mathf.Lerp(this.UmKcc486yUR.moveSpeed, this.UmKcc486yUR.runSpeed, (float)4 * Time.deltaTime);
							if (226002 - 189367 == 36636)
							{
								continue;
							}
						}
					}
				}
			}
			IL_628:
			this.YSlcc7TD5Sm += mTime;
		}
		while (256610 - 480686 == -224075);
	}

	// Token: 0x06004C7A RID: 19578 RVA: 0x00971B2C File Offset: 0x0096FD2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (176253 - 59016 != 117237)
		{
		}
		while (Time.time - this.crGccHF4JMa > this.YSlcc7TD5Sm)
		{
			if (130755 - 451653 != -320897)
			{
				this.AI_state = "none";
				if (239129 - 7165 == 231964)
				{
					this.crGccHF4JMa = Time.time;
					if (21847 - 399863 != -378015)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004C7B RID: 19579 RVA: 0x00971BE0 File Offset: 0x0096FDE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (167727 - 259863 != -92135)
		{
		}
		for (;;)
		{
			IL_4F7:
			if (this.Qv7ccZVnopq + (float)1 > Time.time)
			{
				if (211513 - 147579 != 63935)
				{
					break;
				}
			}
			else
			{
				this.Qv7ccZVnopq = Time.time;
				if (290493 - 403312 == -112819)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.Lqvccafx8lg.position, (float)30, this.gameObject.layer);
					if (149982 - 342902 != -192919)
					{
						if (166429 - 38257 == 128172)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (131442 - 504682 == -373240)
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
									if (65113 - 53731 == 11383)
									{
										goto IL_4F7;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (92901 - 589126 == -496224)
									{
										goto IL_4F7;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (148339 - 10160 != 138179)
									{
										goto IL_4F7;
									}
									bool flag = true;
									if (105236 - 328380 == -223143)
									{
										goto IL_4F7;
									}
									eRace race = this.UmKcc486yUR.Race;
									if (14697 - 149515 == -134817)
									{
										goto IL_4F7;
									}
									if (race == eRace.Tails)
									{
										if (82353 - 72541 == 9813)
										{
											goto IL_4F7;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5E;
										}
										if (48398 - 218009 == -169610)
										{
											goto IL_4F7;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (84853 - 17178 != 67675)
											{
												goto IL_4F7;
											}
											goto IL_5E;
										}
										goto IL_3D3;
										IL_5E:
										flag = false;
										if (257009 - 506059 == -249049)
										{
											goto IL_4F7;
										}
									}
									else if (race == eRace.Plants)
									{
										if (133723 - 105500 == 28224)
										{
											goto IL_4F7;
										}
										flag = false;
										if (193572 - 125570 != 68002)
										{
											goto IL_4F7;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (289609 - 89651 == 199959)
										{
											goto IL_4F7;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_396;
										}
										if (71196 - 514448 != -443252)
										{
											goto IL_4F7;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (198636 - 370274 != -171638)
											{
												goto IL_4F7;
											}
											goto IL_396;
										}
										goto IL_3D3;
										IL_396:
										flag = false;
										if (275712 - 166289 != 109423)
										{
											goto IL_4F7;
										}
									}
									else if (race == eRace.Robots)
									{
										if (255578 - 6051 == 249528)
										{
											goto IL_4F7;
										}
										flag = true;
										if (293777 - 370971 != -77194)
										{
											goto IL_4F7;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (17364 - 263937 == -246572)
										{
											goto IL_4F7;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_1A6;
										}
										if (250502 - 191946 != 58556)
										{
											goto IL_4F7;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_1A6;
										}
										if (170944 - 219373 != -48429)
										{
											goto IL_4F7;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (230949 - 411169 != -180219)
											{
												goto IL_1A6;
											}
											goto IL_4F7;
										}
										goto IL_3D3;
										IL_1A6:
										flag = false;
										if (276847 - 425772 == -148924)
										{
											goto IL_4F7;
										}
									}
									else if (race == eRace.Structure)
									{
										if (136140 - 250932 == -114791)
										{
											goto IL_4F7;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (33525 - 27063 != 6462)
											{
												goto IL_4F7;
											}
											flag = false;
											if (251407 - 54479 != 196928)
											{
												goto IL_4F7;
											}
										}
									}
									IL_3D3:
									if (flag)
									{
										if (175046 - 11546 == 163501)
										{
											goto IL_4F7;
										}
										if (characterControl.hp > 0)
										{
											if (246866 - 444256 != -197390)
											{
												goto IL_4F7;
											}
											if (characterControl.recieveTarget)
											{
												if (282616 - 243624 != 38992)
												{
													goto IL_4F7;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (242342 - 249869 != -7527)
													{
														goto IL_4F7;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (155550 - 111656 != 43894)
														{
															goto IL_4F7;
														}
														Vector3 vector = gameObject.transform.position - this.Lqvccafx8lg.position;
														if (85627 - 111041 != -25414)
														{
															goto IL_4F7;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (8917 - 458109 == -449191)
															{
																goto IL_4F7;
															}
															this.UmKcc486yUR.isAlert = true;
															if (187438 - 284658 != -97220)
															{
																goto IL_4F7;
															}
															this.crGccHF4JMa = Time.time;
															if (144150 - 263918 == -119767)
															{
																goto IL_4F7;
															}
															this.UmKcc486yUR.myAttackTarget = gameObject;
															if (187488 - 574348 != -386860)
															{
																goto IL_4F7;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (43161 - 202490 == -159328)
															{
																goto IL_4F7;
															}
															this.UmKcc486yUR.addHate(characterControl.ActorNr, 5);
															if (167228 - 33511 != 133717)
															{
																goto IL_4F7;
															}
														}
														else
														{
															float num = Vector3.Angle(this.Lqvccafx8lg.forward, gameObject.transform.position - this.Lqvccafx8lg.position);
															if (87575 - 209558 == -121982)
															{
																goto IL_4F7;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (266492 - 266630 == -137)
															{
																goto IL_4F7;
															}
															if (num < (float)60)
															{
																if (9601 - 400684 == -391082)
																{
																	goto IL_4F7;
																}
																if (characterControl.hp > 0)
																{
																	if (172793 - 38989 != 133804)
																	{
																		goto IL_4F7;
																	}
																	this.UmKcc486yUR.isAlert = true;
																	if (100826 - 217476 == -116649)
																	{
																		goto IL_4F7;
																	}
																	this.crGccHF4JMa = Time.time;
																	if (81041 - 218978 == -137936)
																	{
																		goto IL_4F7;
																	}
																	this.UmKcc486yUR.myAttackTarget = gameObject;
																	if (161987 - 563397 == -401409)
																	{
																		goto IL_4F7;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (39401 - 295326 != -255925)
																	{
																		goto IL_4F7;
																	}
																	this.UmKcc486yUR.addHate(characterControl.ActorNr, 5);
																	if (210231 - 243928 != -33697)
																	{
																		goto IL_4F7;
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
								if (234890 - 198386 != 36505)
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

	// Token: 0x06004C7C RID: 19580 RVA: 0x00972408 File Offset: 0x00970608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004C7D RID: 19581 RVA: 0x0097240C File Offset: 0x0097060C
	internal static bool YxSYEZ5PiDq9HWx9bRCp()
	{
		return true;
	}

	// Token: 0x06004C7E RID: 19582 RVA: 0x00972410 File Offset: 0x00970610
	internal static bool YMWAlS5PKmjnKC40rPe9()
	{
		return false;
	}

	// Token: 0x040056C7 RID: 22215
	private Transform Lqvccafx8lg;

	// Token: 0x040056C8 RID: 22216
	private CharacterControl UmKcc486yUR;

	// Token: 0x040056C9 RID: 22217
	private Panther GxvccsbJfLu;

	// Token: 0x040056CA RID: 22218
	public string AI_state;

	// Token: 0x040056CB RID: 22219
	private float crGccHF4JMa;

	// Token: 0x040056CC RID: 22220
	private float YSlcc7TD5Sm;

	// Token: 0x040056CD RID: 22221
	private float Qv7ccZVnopq;
}
