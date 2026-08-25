using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CD2 RID: 3282
[Serializable]
public class Leopard_AI : MonoBehaviour
{
	// Token: 0x060049AC RID: 18860 RVA: 0x00920308 File Offset: 0x0091E508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Leopard_AI()
	{
		if (19592 - 405497 != -385904)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (221319 - 45571 == 175748)
			{
				base..ctor();
				if (86660 - 99253 == -12593)
				{
					this.AI_state = "none";
					if (26856 - 467795 == -440939)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060049AD RID: 18861 RVA: 0x009203A4 File Offset: 0x0091E5A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (295835 - 130158 != 165678)
		{
		}
		for (;;)
		{
			this.EmkzzqVeOj = this.transform;
			if (17425 - 225218 == -207793)
			{
				this.V21c55q1WWJ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (53398 - 502607 != -449208)
				{
					this.nDGc5cpqgq3 = (Leopard)this.GetComponent(typeof(Leopard));
					if (204594 - 25346 != 179249)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060049AE RID: 18862 RVA: 0x0092046C File Offset: 0x0091E66C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (225015 - 581496 != -356481)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (231300 - 73854 != 157446)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (166589 - 170823 == -4233)
				{
					continue;
				}
			}
			if (this.V21c55q1WWJ.isControlled)
			{
				break;
			}
			if (196401 - 247152 != -50750)
			{
				this.AIControl();
				if (165812 - 562047 != -396234)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060049AF RID: 18863 RVA: 0x00920538 File Offset: 0x0091E738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (142459 - 357790 != -215330)
		{
		}
		for (;;)
		{
			this.yItc5Q2h35n = (float)0;
			if (73432 - 453890 == -380458)
			{
				if (this.V21c55q1WWJ.isMine)
				{
					if (183825 - 560538 != -376712)
					{
						if (this.V21c55q1WWJ.actionState != "standby")
						{
							if (178171 - 561879 == -383707)
							{
								continue;
							}
							if (this.V21c55q1WWJ.actionState != "run")
							{
								if (83549 - 337400 != -253850)
								{
									break;
								}
								continue;
							}
						}
						if (!this.V21c55q1WWJ.isAlert)
						{
							if (173119 - 320363 == -147244)
							{
								if (this.V21c55q1WWJ.isSummon)
								{
									if (270649 - 377374 != -106725)
									{
										continue;
									}
									if (this.V21c55q1WWJ.mSummoner != null)
									{
										if (198369 - 556954 != -358585)
										{
											continue;
										}
										Vector3 vector = this.V21c55q1WWJ.mSummoner.transform.position - this.transform.position;
										if (24574 - 334532 != -309957)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (110783 - 322731 == -211947)
												{
													continue;
												}
												this.AI_follow(this.V21c55q1WWJ.mSummoner);
												if (203175 - 425782 != -222607)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (30588 - 425428 != -394840)
												{
													continue;
												}
												this.AI_resetTimer();
												if (73213 - 572734 == -499520)
												{
													continue;
												}
												this.AI_visionCheck();
												if (218986 - 172434 == 46553)
												{
													continue;
												}
											}
											goto IL_895;
										}
										continue;
									}
								}
								if (Game.mGameCode == 915)
								{
									if (278059 - 388824 == -110764)
									{
										continue;
									}
									this.AI_idle(2f, 1f);
									if (1370 - 515143 == -513772)
									{
										continue;
									}
									this.AI_goToPosition(this.V21c55q1WWJ.mOriginalPosition, 6f, 2f);
									if (282630 - 400766 == -118135)
									{
										continue;
									}
									this.AI_resetTimer();
									if (179809 - 13175 == 166635)
									{
										continue;
									}
									this.AI_visionCheck();
									if (193916 - 158347 == 35570)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (198889 - 452415 != -253526)
									{
										continue;
									}
									this.AI_resetTimer();
									if (135572 - 61320 != 74252)
									{
										continue;
									}
									this.AI_visionCheck();
									if (2381 - 568463 != -566082)
									{
										continue;
									}
								}
								IL_895:
								if (!this.V21c55q1WWJ.myAttackTarget)
								{
									break;
								}
								if (144620 - 133851 == 10769)
								{
									this.V21c55q1WWJ.isAlert = true;
									if (101808 - 250098 == -148290)
									{
										this.Sfkc5nXsagR = Time.time;
										if (202462 - 585072 == -382610)
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
							if (260859 - 203923 != 56937)
							{
								this.AI_battle(1f, 1f);
								if (111657 - 181532 == -69875)
								{
									this.AI_attack(6f, (float)0);
									if (108614 - 142388 != -33773)
									{
										this.AI_resetTimer();
										if (44296 - 7827 == 36469)
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
					if (this.V21c55q1WWJ.actionState != "standby")
					{
						if (52723 - 255915 == -203191)
						{
							continue;
						}
						if (this.V21c55q1WWJ.actionState != "run")
						{
							if (104529 - 360329 != -255800)
							{
								continue;
							}
							break;
						}
					}
					if (this.V21c55q1WWJ.nSpeed != (float)0)
					{
						if (218976 - 272217 == -53240)
						{
							continue;
						}
						if (this.V21c55q1WWJ.nPosition != this.V21c55q1WWJ.oPosition)
						{
							if (233589 - 368045 == -134455)
							{
								continue;
							}
							Vector3 a = this.V21c55q1WWJ.nPosition + 0.1f * this.V21c55q1WWJ.runSpeed * this.V21c55q1WWJ.nDirection;
							if (28590 - 292386 != -263796)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.EmkzzqVeOj.position);
							if (6459 - 116709 != -110250)
							{
								continue;
							}
							Vector3 normalized = vector2.normalized;
							if (261636 - 456621 == -194984)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.EmkzzqVeOj.position);
							if (265246 - 93468 != 171778)
							{
								continue;
							}
							float magnitude = vector3.magnitude;
							if (183435 - 445926 == -262490)
							{
								continue;
							}
							if (magnitude > this.V21c55q1WWJ.runSpeed)
							{
								if (200909 - 279836 != -78927)
								{
									continue;
								}
								this.EmkzzqVeOj.position = this.V21c55q1WWJ.nPosition;
								if (100000 - 274498 != -174498)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.V21c55q1WWJ.runSpeed)
							{
								if (270831 - 58338 == 212494)
								{
									continue;
								}
								this.V21c55q1WWJ.moveSpeed = Mathf.Lerp(this.V21c55q1WWJ.moveSpeed, 1.1f * this.V21c55q1WWJ.runSpeed, (float)10 * Time.deltaTime);
								if (139060 - 267077 != -128017)
								{
									continue;
								}
								this.V21c55q1WWJ.vDirection = normalized;
								if (1136 - 86963 == -85826)
								{
									continue;
								}
								this.V21c55q1WWJ.vMovement = normalized;
								if (288052 - 123267 != 164785)
								{
									continue;
								}
								if (Vector3.Dot(this.EmkzzqVeOj.forward, normalized) > (float)0)
								{
									if (133337 - 573791 != -440454)
									{
										continue;
									}
									this.EmkzzqVeOj.rotation = Quaternion.LookRotation(Vector3.Slerp(this.EmkzzqVeOj.forward, normalized, (float)10 * Time.deltaTime));
									if (244898 - 371554 == -126655)
									{
										continue;
									}
								}
								else
								{
									this.EmkzzqVeOj.rotation = Quaternion.LookRotation(normalized);
									if (248769 - 492555 != -243786)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (255576 - 180875 == 74702)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (260016 - 440142 != -180126)
								{
									continue;
								}
								break;
							}
							else
							{
								this.V21c55q1WWJ.moveSpeed = Mathf.Lerp(this.V21c55q1WWJ.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (99258 - 310851 != -211593)
								{
									continue;
								}
								this.V21c55q1WWJ.vDirection = normalized;
								if (157352 - 169560 == -12207)
								{
									continue;
								}
								this.V21c55q1WWJ.vMovement = normalized;
								if (295438 - 175235 != 120203)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (275796 - 475925 != -200129)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (197758 - 310996 != -113238)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.V21c55q1WWJ.moveSpeed != (float)0)
					{
						if (100191 - 574479 != -474287)
						{
							Vector3 vector4 = global::Math.vFlat(this.V21c55q1WWJ.nPosition - this.EmkzzqVeOj.position);
							if (99308 - 583939 == -484631)
							{
								float sqrMagnitude = vector4.sqrMagnitude;
								if (59833 - 349305 == -289472)
								{
									if (sqrMagnitude > this.V21c55q1WWJ.runSpeed)
									{
										if (242453 - 324889 != -82435)
										{
											this.EmkzzqVeOj.position = this.V21c55q1WWJ.nPosition;
											if (61572 - 516293 != -454720)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (35446 - 297607 == -262161)
										{
											if (sqrMagnitude > (float)1)
											{
												if (102884 - 418943 != -316059)
												{
													continue;
												}
												this.V21c55q1WWJ.moveSpeed = Mathf.Lerp(this.V21c55q1WWJ.moveSpeed, this.V21c55q1WWJ.runSpeed, (float)10 * Time.deltaTime);
												if (167792 - 308764 == -140971)
												{
													continue;
												}
											}
											else
											{
												this.V21c55q1WWJ.moveSpeed = Mathf.Lerp(this.V21c55q1WWJ.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (88688 - 418160 != -329472)
												{
													continue;
												}
											}
											this.V21c55q1WWJ.vMovement = vector4;
											if (16655 - 130637 == -113982)
											{
												this.V21c55q1WWJ.vDirection = vector4;
												if (149980 - 455898 == -305918)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.EmkzzqVeOj.forward, vector4, (float)10 * Time.deltaTime));
													if (103556 - 588362 != -484805)
													{
														this.animation.CrossFade("run", 0.2f);
														if (210979 - 66390 != 144590)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (67571 - 461193 == -393622)
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
										this.V21c55q1WWJ.vMovement = vector4;
										if (11353 - 282569 != -271215)
										{
											this.V21c55q1WWJ.moveSpeed = (float)0;
											if (197517 - 78395 == 119122)
											{
												this.transform.rotation = Quaternion.LookRotation(this.V21c55q1WWJ.vDirection);
												if (149708 - 422174 == -272466)
												{
													this.animation.CrossFade("root", 0.2f);
													if (191442 - 520584 != -329141)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (213752 - 591474 != -377721)
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
						if (98055 - 516427 == -418372)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (114452 - 203417 == -88965)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060049B0 RID: 18864 RVA: 0x009212C0 File Offset: 0x0091F4C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (18206 - 539232 != -521025)
		{
		}
		do
		{
			if (Time.time - this.Sfkc5nXsagR >= this.yItc5Q2h35n)
			{
				if (228178 - 314896 != -86718)
				{
					continue;
				}
				if (Time.time - this.Sfkc5nXsagR < this.yItc5Q2h35n + mTime)
				{
					if (38423 - 187890 != -149467)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (289072 - 364906 == -75833)
						{
							continue;
						}
						this.AI_state = "idle";
						if (269294 - 274800 != -5506)
						{
							continue;
						}
						this.Sfkc5nXsagR -= UnityEngine.Random.Range((float)0, rTimer);
						if (76937 - 466348 == -389410)
						{
							continue;
						}
						this.V21c55q1WWJ.vDirection = Vector3.zero;
						if (270707 - 371784 == -101076)
						{
							continue;
						}
						this.V21c55q1WWJ.vMovement = this.EmkzzqVeOj.forward;
						if (206324 - 187902 != 18422)
						{
							continue;
						}
						this.V21c55q1WWJ.actionState = "standby";
						if (230958 - 574896 != -343938)
						{
							continue;
						}
					}
					this.V21c55q1WWJ.moveSpeed = Mathf.Lerp(this.V21c55q1WWJ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (151749 - 547708 != -395959)
					{
						continue;
					}
					if (this.V21c55q1WWJ.moveSpeed < 0.1f * this.V21c55q1WWJ.runSpeed)
					{
						if (273121 - 356402 == -83280)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (218681 - 487526 != -268845)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (147655 - 58866 != 88789)
						{
							continue;
						}
						this.V21c55q1WWJ.moveSpeed = (float)0;
						if (127973 - 559106 != -431133)
						{
							continue;
						}
					}
				}
			}
			this.yItc5Q2h35n += mTime;
		}
		while (182963 - 187975 == -5011);
	}

	// Token: 0x060049B1 RID: 18865 RVA: 0x00921584 File Offset: 0x0091F784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_goToPosition(Vector3 tPosition, float mTime, float rTimer)
	{
		if (283410 - 189781 != 93630)
		{
		}
		do
		{
			if (Time.time - this.Sfkc5nXsagR >= this.yItc5Q2h35n)
			{
				if (291651 - 469286 != -177635)
				{
					continue;
				}
				if (Time.time - this.Sfkc5nXsagR < this.yItc5Q2h35n + mTime)
				{
					if (7050 - 594470 == -587419)
					{
						continue;
					}
					if (this.AI_state != "goToPosition")
					{
						if (296301 - 507943 != -211642)
						{
							continue;
						}
						this.AI_state = "goToPosition";
						if (212213 - 322915 == -110701)
						{
							continue;
						}
						this.Sfkc5nXsagR -= UnityEngine.Random.Range((float)0, rTimer);
						if (292782 - 583317 != -290535)
						{
							continue;
						}
					}
					Vector3 vector = this.EmkzzqVeOj.position - tPosition;
					if (223429 - 597264 == -373834)
					{
						continue;
					}
					if (vector.sqrMagnitude > (float)1)
					{
						if (264377 - 57547 == 206831)
						{
							continue;
						}
						this.V21c55q1WWJ.vDirection = tPosition;
						if (140829 - 171998 == -31168)
						{
							continue;
						}
						this.V21c55q1WWJ.vDirection.y = this.EmkzzqVeOj.position.y;
						if (276669 - 569796 == -293126)
						{
							continue;
						}
						this.V21c55q1WWJ.vMovement = (tPosition - this.EmkzzqVeOj.position).normalized;
						if (231947 - 342567 != -110620)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.V21c55q1WWJ.vMovement);
						if (259286 - 275589 != -16303)
						{
							continue;
						}
						this.V21c55q1WWJ.actionState = "run";
						if (236996 - 58673 != 178323)
						{
							continue;
						}
						this.animation.Play("run");
						if (35865 - 118436 != -82571)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (255788 - 43633 == 212156)
						{
							continue;
						}
						this.V21c55q1WWJ.moveSpeed = Mathf.Lerp(this.V21c55q1WWJ.moveSpeed, this.V21c55q1WWJ.runSpeed, (float)4 * Time.deltaTime);
						if (70606 - 472344 == -401737)
						{
							continue;
						}
					}
					else
					{
						this.V21c55q1WWJ.vDirection = this.EmkzzqVeOj.position + this.V21c55q1WWJ.mOriginalDirection;
						if (127283 - 189448 == -62164)
						{
							continue;
						}
						this.V21c55q1WWJ.vMovement = this.V21c55q1WWJ.mOriginalDirection;
						if (188000 - 93075 != 94925)
						{
							continue;
						}
						this.V21c55q1WWJ.moveSpeed = (float)0;
						if (124851 - 375748 != -250897)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.V21c55q1WWJ.vMovement);
						if (222145 - 309969 == -87823)
						{
							continue;
						}
						this.Sfkc5nXsagR = Time.time - mTime - this.yItc5Q2h35n;
						if (283582 - 483078 != -199496)
						{
							continue;
						}
					}
				}
			}
			this.yItc5Q2h35n += mTime;
		}
		while (179467 - 310283 == -130815);
	}

	// Token: 0x060049B2 RID: 18866 RVA: 0x009219B8 File Offset: 0x0091FBB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (37148 - 439000 != -401852)
		{
		}
		for (;;)
		{
			this.V21c55q1WWJ.vDirection = followObject.transform.position;
			if (190671 - 85877 != 104795)
			{
				this.V21c55q1WWJ.vDirection.y = this.transform.position.y;
				if (122750 - 259750 == -137000)
				{
					this.V21c55q1WWJ.vMovement = (this.V21c55q1WWJ.vDirection - this.transform.position).normalized;
					if (48938 - 439957 != -391018)
					{
						this.transform.rotation = Quaternion.LookRotation(this.V21c55q1WWJ.vMovement);
						if (283441 - 478811 != -195369)
						{
							this.V21c55q1WWJ.actionState = "run";
							if (199477 - 407358 == -207881)
							{
								this.animation.Play("run");
								if (18367 - 228920 != -210552)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (284284 - 372118 == -87834)
									{
										this.V21c55q1WWJ.moveSpeed = Mathf.Lerp(this.V21c55q1WWJ.moveSpeed, this.V21c55q1WWJ.runSpeed, (float)4 * Time.deltaTime);
										if (24108 - 188450 == -164342)
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

	// Token: 0x060049B3 RID: 18867 RVA: 0x00921BA0 File Offset: 0x0091FDA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_battle(float mTime, float rTimer)
	{
		if (258643 - 283207 != -24564)
		{
		}
		do
		{
			if (Time.time - this.Sfkc5nXsagR >= this.yItc5Q2h35n)
			{
				if (79456 - 123580 == -44123)
				{
					continue;
				}
				if (Time.time - this.Sfkc5nXsagR < this.yItc5Q2h35n + mTime)
				{
					if (228640 - 551771 != -323131)
					{
						continue;
					}
					if (!this.V21c55q1WWJ.myAttackTarget)
					{
						if (87576 - 195878 == -108301)
						{
							continue;
						}
						this.Sfkc5nXsagR = Time.time - mTime - this.yItc5Q2h35n;
						if (145266 - 550660 != -405394)
						{
							continue;
						}
						break;
					}
					else if (this.AI_state != "battle")
					{
						if (76903 - 350255 == -273351)
						{
							continue;
						}
						GameObject myAttackTarget = this.V21c55q1WWJ.myAttackTarget;
						if (196139 - 58631 != 137508)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.EmkzzqVeOj.position;
						if (72097 - 225445 == -153347)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (93449 - 219930 == -126480)
						{
							continue;
						}
						this.AI_state = "battle";
						if (295245 - 164343 != 130902)
						{
							continue;
						}
						this.V21c55q1WWJ.vDirection = myAttackTarget.transform.position;
						if (165671 - 593653 != -427982)
						{
							continue;
						}
						this.V21c55q1WWJ.vDirection.y = this.EmkzzqVeOj.position.y;
						if (199367 - 519845 == -320477)
						{
							continue;
						}
						this.V21c55q1WWJ.vMovement = (this.V21c55q1WWJ.vDirection - this.EmkzzqVeOj.position).normalized;
						if (210584 - 68230 == 142355)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.V21c55q1WWJ.vMovement);
						if (54270 - 26400 != 27870)
						{
							continue;
						}
						this.V21c55q1WWJ.actionState = "standby";
						if (232900 - 343128 != -110228)
						{
							continue;
						}
						this.animation.Play("battle");
						if (24248 - 143270 != -119022)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (36100 - 305218 != -269118)
						{
							continue;
						}
						this.V21c55q1WWJ.moveSpeed = (float)0;
						if (154533 - 553365 != -398832)
						{
							continue;
						}
					}
				}
			}
			this.yItc5Q2h35n += mTime;
		}
		while (80187 - 126308 != -46121);
	}

	// Token: 0x060049B4 RID: 18868 RVA: 0x00921F44 File Offset: 0x00920144
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (241678 - 435221 != -193542)
		{
		}
		do
		{
			if (Time.time - this.Sfkc5nXsagR >= this.yItc5Q2h35n)
			{
				if (184075 - 323405 != -139330)
				{
					continue;
				}
				if (Time.time - this.Sfkc5nXsagR < this.yItc5Q2h35n + mTime)
				{
					if (282804 - 571131 != -288327)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (280878 - 310258 != -29380)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (88760 - 496101 == -407340)
						{
							continue;
						}
						this.Sfkc5nXsagR -= UnityEngine.Random.Range((float)0, rTimer);
						if (235150 - 268035 == -32884)
						{
							continue;
						}
						this.V21c55q1WWJ.vDirection = this.V21c55q1WWJ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (21593 - 341769 != -320176)
						{
							continue;
						}
						this.V21c55q1WWJ.vDirection.y = this.EmkzzqVeOj.position.y;
						if (215961 - 456273 == -240311)
						{
							continue;
						}
						this.V21c55q1WWJ.vMovement = (this.V21c55q1WWJ.vDirection - this.EmkzzqVeOj.position).normalized;
						if (229511 - 116170 != 113341)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.V21c55q1WWJ.vMovement);
						if (79228 - 177551 != -98323)
						{
							continue;
						}
						this.V21c55q1WWJ.actionState = "run";
						if (204526 - 116575 != 87951)
						{
							continue;
						}
						this.animation.Play("run");
						if (267027 - 281078 == -14050)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (51661 - 91299 != -39638)
						{
							continue;
						}
					}
					this.V21c55q1WWJ.moveSpeed = Mathf.Lerp(this.V21c55q1WWJ.moveSpeed, this.V21c55q1WWJ.runSpeed, (float)4 * Time.deltaTime);
					if (149407 - 599270 == -449862)
					{
						continue;
					}
				}
			}
			this.yItc5Q2h35n += mTime;
		}
		while (187546 - 103817 == 83730);
	}

	// Token: 0x060049B5 RID: 18869 RVA: 0x0092224C File Offset: 0x0092044C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (222136 - 266046 != -43910)
		{
		}
		do
		{
			if (Time.time - this.Sfkc5nXsagR >= this.yItc5Q2h35n)
			{
				if (276293 - 81886 != 194407)
				{
					continue;
				}
				if (Time.time - this.Sfkc5nXsagR < this.yItc5Q2h35n + mTime)
				{
					if (25104 - 499071 == -473966)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (39352 - 199179 == -159826)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (221205 - 140057 != 81148)
						{
							continue;
						}
						this.Sfkc5nXsagR = Time.time - mTime - this.yItc5Q2h35n;
						if (64055 - 343433 != -279378)
						{
							continue;
						}
						this.V21c55q1WWJ.vDirection = Vector3.zero;
						if (66937 - 167504 != -100567)
						{
							continue;
						}
						this.V21c55q1WWJ.vMovement = this.EmkzzqVeOj.forward;
						if (232004 - 26567 != 205437)
						{
							continue;
						}
						this.V21c55q1WWJ.actionState = "standby";
						if (18811 - 12280 != 6531)
						{
							continue;
						}
						this.V21c55q1WWJ.myAttackTarget = this.V21c55q1WWJ.getHateTarget(5, 50);
						if (165845 - 576700 != -410855)
						{
							continue;
						}
						if (!this.V21c55q1WWJ.myAttackTarget)
						{
							if (256584 - 288509 == -31924)
							{
								continue;
							}
							this.V21c55q1WWJ.isAlert = false;
							if (180042 - 515770 != -335728)
							{
								continue;
							}
							this.Sfkc5nXsagR = Time.time;
							if (224485 - 115171 == 109315)
							{
								continue;
							}
							this.V21c55q1WWJ.myAttackTarget = null;
							if (91999 - 330458 != -238459)
							{
								continue;
							}
							if (Game.mGameCode == 915)
							{
								break;
							}
							if (40825 - 241189 != -200364)
							{
								continue;
							}
							this.V21c55q1WWJ.mOriginalPosition = this.EmkzzqVeOj.position;
							if (251651 - 152110 != 99542)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.V21c55q1WWJ.myAttackTarget;
							if (120918 - 150236 == -29317)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (271959 - 579892 == -307932)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (155767 - 582674 == -426906)
								{
									continue;
								}
								this.V21c55q1WWJ.isAlert = false;
								if (283600 - 95705 == 187896)
								{
									continue;
								}
								this.Sfkc5nXsagR = Time.time;
								if (269008 - 61551 == 207458)
								{
									continue;
								}
								this.V21c55q1WWJ.myAttackTarget = null;
								if (39626 - 396932 != -357306)
								{
									continue;
								}
							}
							else
							{
								this.V21c55q1WWJ.vDirection = myAttackTarget.transform.position;
								if (33621 - 448439 != -414818)
								{
									continue;
								}
								this.V21c55q1WWJ.vDirection.y = this.EmkzzqVeOj.position.y;
								if (82816 - 518013 != -435197)
								{
									continue;
								}
								this.V21c55q1WWJ.vMovement = (this.V21c55q1WWJ.vDirection - this.EmkzzqVeOj.position).normalized;
								if (276924 - 579092 != -302168)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.V21c55q1WWJ.vMovement);
								if (118977 - 566924 == -447946)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.yItc5Q2h35n += mTime;
		}
		while (263967 - 444528 != -180561);
	}

	// Token: 0x060049B6 RID: 18870 RVA: 0x00922724 File Offset: 0x00920924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (281389 - 514565 != -233175)
		{
		}
		do
		{
			if (Time.time - this.Sfkc5nXsagR >= this.yItc5Q2h35n)
			{
				if (28919 - 61831 == -32911)
				{
					continue;
				}
				if (Time.time - this.Sfkc5nXsagR < this.yItc5Q2h35n + mTime)
				{
					if (151600 - 573447 != -421847)
					{
						continue;
					}
					if (!this.V21c55q1WWJ.myAttackTarget)
					{
						if (45037 - 174951 != -129914)
						{
							continue;
						}
						this.Sfkc5nXsagR = Time.time - mTime - this.yItc5Q2h35n;
						if (39913 - 264983 != -225070)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.V21c55q1WWJ.myAttackTarget;
						if (231119 - 365957 == -134837)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (87248 - 170420 != -83172)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.EmkzzqVeOj.position;
						if (35612 - 470033 != -434421)
						{
							continue;
						}
						int tID = 0;
						if (27056 - 52412 == -25355)
						{
							continue;
						}
						if (characterControl)
						{
							if (297037 - 223048 != 73989)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (12875 - 116429 != -103554)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (267360 - 25295 == 242066)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (44668 - 556316 == -511647)
							{
								continue;
							}
							if (this.V21c55q1WWJ.sp > 20)
							{
								if (241674 - 16481 != 225193)
								{
									continue;
								}
								if (this.V21c55q1WWJ.isTimeOut("leoSmash") == (float)0)
								{
									if (109885 - 167946 == -58060)
									{
										continue;
									}
									this.Sfkc5nXsagR = Time.time - mTime - this.yItc5Q2h35n;
									if (123911 - 46151 == 77761)
									{
										continue;
									}
									this.nDGc5cpqgq3.StartCoroutine_Auto(this.nDGc5cpqgq3.RPC_leoSmash(this.EmkzzqVeOj.position, vector, tID));
									if (256397 - 200691 != 55707)
									{
										if (PhotonClient.IsInitialized())
										{
											if (185350 - 45819 != 139531)
											{
												continue;
											}
											this.nDGc5cpqgq3.ActionEvent("RPC_leoSmash", this.EmkzzqVeOj.position, vector, tID);
											if (114588 - 400866 == -286277)
											{
												continue;
											}
										}
										goto IL_1E3;
									}
									continue;
								}
							}
						}
						if (num < (float)2)
						{
							if (151 - 75107 != -74956)
							{
								continue;
							}
							if (this.V21c55q1WWJ.isTimeOut("nAttack") == (float)0)
							{
								if (218563 - 418716 != -200153)
								{
									continue;
								}
								this.Sfkc5nXsagR = Time.time - mTime - this.yItc5Q2h35n;
								if (257235 - 259301 != -2066)
								{
									continue;
								}
								this.nDGc5cpqgq3.StartCoroutine_Auto(this.nDGc5cpqgq3.RPC_nAttack(this.EmkzzqVeOj.position, vector, 0));
								if (123005 - 441883 != -318878)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (216697 - 241872 != -25175)
									{
										continue;
									}
									this.nDGc5cpqgq3.ActionEvent("RPC_nAttack", this.EmkzzqVeOj.position, vector, 0);
									if (99022 - 449510 != -350488)
									{
										continue;
									}
								}
								goto IL_1E3;
							}
						}
						this.AI_state = "attack";
						if (266722 - 175682 == 91041)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (188666 - 340882 != -152216)
							{
								continue;
							}
							this.V21c55q1WWJ.vDirection = myAttackTarget.transform.position;
							if (115062 - 126026 == -10963)
							{
								continue;
							}
							this.V21c55q1WWJ.vDirection.y = this.EmkzzqVeOj.position.y;
							if (57703 - 106831 == -49127)
							{
								continue;
							}
							this.V21c55q1WWJ.vMovement = (this.V21c55q1WWJ.vDirection - this.EmkzzqVeOj.position).normalized;
							if (174051 - 170870 == 3182)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.V21c55q1WWJ.vMovement);
							if (99021 - 566920 != -467899)
							{
								continue;
							}
							this.V21c55q1WWJ.actionState = "standby";
							if (202036 - 10108 != 191928)
							{
								continue;
							}
							this.animation.Play("battle");
							if (213769 - 89416 != 124353)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (206234 - 181761 != 24473)
							{
								continue;
							}
							this.V21c55q1WWJ.moveSpeed = (float)0;
							if (30310 - 193302 == -162991)
							{
								continue;
							}
						}
						else
						{
							this.V21c55q1WWJ.vDirection = myAttackTarget.transform.position;
							if (147134 - 335401 == -188266)
							{
								continue;
							}
							this.V21c55q1WWJ.vDirection.y = this.EmkzzqVeOj.position.y;
							if (13359 - 18134 == -4774)
							{
								continue;
							}
							this.V21c55q1WWJ.vMovement = (this.V21c55q1WWJ.vDirection - this.EmkzzqVeOj.position).normalized;
							if (280277 - 502845 == -222567)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.V21c55q1WWJ.vMovement);
							if (235389 - 286283 == -50893)
							{
								continue;
							}
							this.V21c55q1WWJ.actionState = "run";
							if (292693 - 516849 != -224156)
							{
								continue;
							}
							this.animation.Play("run");
							if (152684 - 238163 != -85479)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (229428 - 44638 != 184790)
							{
								continue;
							}
							this.V21c55q1WWJ.moveSpeed = Mathf.Lerp(this.V21c55q1WWJ.moveSpeed, this.V21c55q1WWJ.runSpeed, (float)4 * Time.deltaTime);
							if (39840 - 506763 != -466923)
							{
								continue;
							}
						}
					}
				}
			}
			IL_1E3:
			this.yItc5Q2h35n += mTime;
		}
		while (296976 - 90025 != 206951);
	}

	// Token: 0x060049B7 RID: 18871 RVA: 0x00922F70 File Offset: 0x00921170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (48144 - 29760 != 18384)
		{
		}
		while (Time.time - this.Sfkc5nXsagR > this.yItc5Q2h35n)
		{
			if (50918 - 396018 == -345100)
			{
				this.AI_state = "none";
				if (2005 - 420905 != -418899)
				{
					this.Sfkc5nXsagR = Time.time;
					if (78249 - 568858 == -490609)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060049B8 RID: 18872 RVA: 0x00923024 File Offset: 0x00921224
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (65405 - 586131 != -520725)
		{
		}
		for (;;)
		{
			IL_2A2:
			if (this.LEHc5e6dKEI + (float)1 > Time.time)
			{
				if (108407 - 50720 != 57688)
				{
					break;
				}
			}
			else
			{
				this.LEHc5e6dKEI = Time.time;
				if (284005 - 449368 != -165362)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.EmkzzqVeOj.position, (float)30, this.gameObject.layer);
					if (272027 - 501522 == -229495)
					{
						if (140375 - 349635 == -209260)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (159935 - 418435 == -258500)
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
									if (44108 - 298198 == -254089)
									{
										goto IL_2A2;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (113468 - 206666 != -93198)
									{
										goto IL_2A2;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (175616 - 243979 != -68363)
									{
										goto IL_2A2;
									}
									bool flag = true;
									if (147424 - 21717 == 125708)
									{
										goto IL_2A2;
									}
									eRace race = this.V21c55q1WWJ.Race;
									if (58733 - 85131 != -26398)
									{
										goto IL_2A2;
									}
									if (race == eRace.Tails)
									{
										if (283328 - 130652 == 152677)
										{
											goto IL_2A2;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_8E;
										}
										if (17708 - 485207 != -467499)
										{
											goto IL_2A2;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (185638 - 275656 != -90017)
											{
												goto IL_8E;
											}
											goto IL_2A2;
										}
										goto IL_571;
										IL_8E:
										flag = false;
										if (200965 - 296936 != -95971)
										{
											goto IL_2A2;
										}
									}
									else if (race == eRace.Plants)
									{
										if (84205 - 3711 != 80494)
										{
											goto IL_2A2;
										}
										flag = false;
										if (48771 - 430877 != -382106)
										{
											goto IL_2A2;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (42506 - 595646 == -553139)
										{
											goto IL_2A2;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_CF;
										}
										if (81227 - 179620 != -98393)
										{
											goto IL_2A2;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (50247 - 551785 != -501538)
											{
												goto IL_2A2;
											}
											goto IL_CF;
										}
										goto IL_571;
										IL_CF:
										flag = false;
										if (178617 - 423352 != -244735)
										{
											goto IL_2A2;
										}
									}
									else if (race == eRace.Robots)
									{
										if (285742 - 130589 == 155154)
										{
											goto IL_2A2;
										}
										flag = true;
										if (122873 - 113257 != 9616)
										{
											goto IL_2A2;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (126226 - 494445 != -368219)
										{
											goto IL_2A2;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_372;
										}
										if (289692 - 96521 == 193172)
										{
											goto IL_2A2;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_372;
										}
										if (111466 - 25341 == 86126)
										{
											goto IL_2A2;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (4890 - 396512 != -391621)
											{
												goto IL_372;
											}
											goto IL_2A2;
										}
										goto IL_571;
										IL_372:
										flag = false;
										if (157550 - 526131 != -368581)
										{
											goto IL_2A2;
										}
									}
									else if (race == eRace.Structure)
									{
										if (188915 - 403508 == -214592)
										{
											goto IL_2A2;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (162016 - 305406 != -143390)
											{
												goto IL_2A2;
											}
											flag = false;
											if (183971 - 41473 == 142499)
											{
												goto IL_2A2;
											}
										}
									}
									IL_571:
									if (flag)
									{
										if (87307 - 143276 != -55969)
										{
											goto IL_2A2;
										}
										if (characterControl.hp > 0)
										{
											if (95857 - 72182 != 23675)
											{
												goto IL_2A2;
											}
											if (characterControl.recieveTarget)
											{
												if (28935 - 101807 == -72871)
												{
													goto IL_2A2;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (23216 - 308679 == -285462)
													{
														goto IL_2A2;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (276762 - 301469 == -24706)
														{
															goto IL_2A2;
														}
														Vector3 vector = gameObject.transform.position - this.EmkzzqVeOj.position;
														if (279543 - 218217 != 61326)
														{
															goto IL_2A2;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (3160 - 430133 != -426973)
															{
																goto IL_2A2;
															}
															this.V21c55q1WWJ.isAlert = true;
															if (259429 - 182474 == 76956)
															{
																goto IL_2A2;
															}
															this.Sfkc5nXsagR = Time.time;
															if (238881 - 69756 != 169125)
															{
																goto IL_2A2;
															}
															this.V21c55q1WWJ.myAttackTarget = gameObject;
															if (41843 - 105720 != -63877)
															{
																goto IL_2A2;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (27475 - 345061 == -317585)
															{
																goto IL_2A2;
															}
															this.V21c55q1WWJ.addHate(characterControl.ActorNr, 5);
															if (93655 - 470054 == -376398)
															{
																goto IL_2A2;
															}
														}
														else
														{
															float num = Vector3.Angle(this.EmkzzqVeOj.forward, gameObject.transform.position - this.EmkzzqVeOj.position);
															if (105119 - 179283 != -74164)
															{
																goto IL_2A2;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (106566 - 373222 != -266656)
															{
																goto IL_2A2;
															}
															if (num < (float)60)
															{
																if (24192 - 116132 == -91939)
																{
																	goto IL_2A2;
																}
																if (characterControl.hp > 0)
																{
																	if (209399 - 302055 == -92655)
																	{
																		goto IL_2A2;
																	}
																	this.V21c55q1WWJ.isAlert = true;
																	if (282280 - 145011 != 137269)
																	{
																		goto IL_2A2;
																	}
																	this.Sfkc5nXsagR = Time.time;
																	if (227858 - 138254 != 89604)
																	{
																		goto IL_2A2;
																	}
																	this.V21c55q1WWJ.myAttackTarget = gameObject;
																	if (45141 - 229356 != -184215)
																	{
																		goto IL_2A2;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (79797 - 169213 != -89416)
																	{
																		goto IL_2A2;
																	}
																	this.V21c55q1WWJ.addHate(characterControl.ActorNr, 5);
																	if (123914 - 553582 != -429668)
																	{
																		goto IL_2A2;
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
								if (68963 - 448758 != -379794)
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

	// Token: 0x060049B9 RID: 18873 RVA: 0x0092384C File Offset: 0x00921A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060049BA RID: 18874 RVA: 0x00923850 File Offset: 0x00921A50
	internal static bool jtjX8G5ReF6rVvcxobcU()
	{
		return true;
	}

	// Token: 0x060049BB RID: 18875 RVA: 0x00923854 File Offset: 0x00921A54
	internal static bool wigDQ45Rr1D8gRZNngfL()
	{
		return false;
	}

	// Token: 0x0400546A RID: 21610
	private Transform EmkzzqVeOj;

	// Token: 0x0400546B RID: 21611
	private CharacterControl V21c55q1WWJ;

	// Token: 0x0400546C RID: 21612
	private Leopard nDGc5cpqgq3;

	// Token: 0x0400546D RID: 21613
	public string AI_state;

	// Token: 0x0400546E RID: 21614
	private float Sfkc5nXsagR;

	// Token: 0x0400546F RID: 21615
	private float yItc5Q2h35n;

	// Token: 0x04005470 RID: 21616
	private float LEHc5e6dKEI;
}
