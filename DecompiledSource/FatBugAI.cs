using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000065 RID: 101
[Serializable]
public class FatBugAI : MonoBehaviour
{
	// Token: 0x0600020B RID: 523 RVA: 0x00033E14 File Offset: 0x00032014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FatBugAI()
	{
		if (130899 - 551080 != -420181)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (92621 - 439818 != -347196)
			{
				base..ctor();
				if (84104 - 161607 != -77502)
				{
					this.AI_state = "none";
					if (241541 - 410931 == -169390)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00033EB0 File Offset: 0x000320B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.SiPNrlyMi = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.ie3EfrLwk = (FatBug)this.GetComponent(typeof(FatBug));
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00033EE8 File Offset: 0x000320E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (116579 - 502187 != -385607)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (188938 - 57894 != 131044)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (79791 - 123106 != -43315)
				{
					continue;
				}
			}
			if (this.SiPNrlyMi.isControlled)
			{
				break;
			}
			if (63169 - 460251 == -397082)
			{
				this.AIControl();
				if (103089 - 222379 == -119290)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00033FB4 File Offset: 0x000321B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (260963 - 494578 != -233615)
		{
		}
		for (;;)
		{
			this.xplSHwH7h = (float)0;
			if (278387 - 415351 != -136963)
			{
				if (this.SiPNrlyMi.isMine)
				{
					if (132996 - 547774 != -414777)
					{
						if (this.SiPNrlyMi.actionState != "standby")
						{
							if (129915 - 568919 != -439004)
							{
								continue;
							}
							if (this.SiPNrlyMi.actionState != "run")
							{
								if (135580 - 597282 != -461702)
								{
									continue;
								}
								break;
							}
						}
						if (!this.SiPNrlyMi.isAlert)
						{
							if (5546 - 584781 == -579235)
							{
								this.AI_idle(3f, 1f);
								if (72778 - 543698 == -470920)
								{
									this.AI_patrol(1f, 0.25f);
									if (134658 - 356807 != -222148)
									{
										this.AI_resetTimer();
										if (298798 - 470533 == -171735)
										{
											this.AI_visionCheck();
											if (144159 - 170487 == -26328)
											{
												if (!this.SiPNrlyMi.myAttackTarget)
												{
													break;
												}
												if (117479 - 148505 == -31026)
												{
													this.SiPNrlyMi.isAlert = true;
													if (30029 - 308031 == -278002)
													{
														this.VsNPAcGBK = Time.time;
														if (160367 - 339068 != -178700)
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
							if (201844 - 531547 != -329702)
							{
								this.AI_idle(4f, 2f);
								if (61514 - 273201 != -211686)
								{
									this.AI_attack(5f, 2f);
									if (30540 - 452532 == -421992)
									{
										this.AI_resetTimer();
										if (33917 - 288781 != -254863)
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
					if (this.SiPNrlyMi.actionState != "standby")
					{
						if (140589 - 527288 == -386698)
						{
							continue;
						}
						if (this.SiPNrlyMi.actionState != "run")
						{
							if (135020 - 461760 != -326739)
							{
								break;
							}
							continue;
						}
					}
					if (this.SiPNrlyMi.nSpeed != (float)0)
					{
						if (146690 - 419590 != -272900)
						{
							continue;
						}
						if (this.SiPNrlyMi.nPosition != this.SiPNrlyMi.oPosition)
						{
							if (256948 - 453761 == -196812)
							{
								continue;
							}
							Vector3 a = this.SiPNrlyMi.nPosition + 0.1f * this.SiPNrlyMi.runSpeed * this.SiPNrlyMi.nDirection;
							if (162481 - 176685 == -14203)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (204668 - 38799 == 165870)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (53209 - 414465 == -361255)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (223610 - 408486 != -184876)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (297109 - 453729 != -156620)
							{
								continue;
							}
							if (magnitude > this.SiPNrlyMi.runSpeed)
							{
								if (25492 - 405166 == -379673)
								{
									continue;
								}
								this.transform.position = this.SiPNrlyMi.nPosition;
								if (99331 - 167913 != -68582)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.SiPNrlyMi.runSpeed)
							{
								if (265190 - 410179 == -144988)
								{
									continue;
								}
								this.SiPNrlyMi.moveSpeed = Mathf.Lerp(this.SiPNrlyMi.moveSpeed, 1.1f * this.SiPNrlyMi.runSpeed, (float)10 * Time.deltaTime);
								if (10822 - 425090 != -414268)
								{
									continue;
								}
								this.SiPNrlyMi.vDirection = normalized;
								if (265724 - 18771 == 246954)
								{
									continue;
								}
								this.SiPNrlyMi.vMovement = normalized;
								if (270030 - 15830 == 254201)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (148768 - 564286 == -415517)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (211606 - 193884 != 17722)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (224953 - 364936 != -139983)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (27419 - 17110 == 10310)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (31853 - 81360 != -49506)
								{
									break;
								}
								continue;
							}
							else
							{
								this.SiPNrlyMi.moveSpeed = Mathf.Lerp(this.SiPNrlyMi.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (42685 - 182677 == -139991)
								{
									continue;
								}
								this.SiPNrlyMi.vDirection = normalized;
								if (209910 - 571292 != -361382)
								{
									continue;
								}
								this.SiPNrlyMi.vMovement = normalized;
								if (25334 - 212286 == -186951)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (9018 - 526636 != -517618)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (277356 - 287882 != -10525)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.SiPNrlyMi.moveSpeed != (float)0)
					{
						if (62874 - 425453 != -362578)
						{
							Vector3 vector3 = global::Math.vFlat(this.SiPNrlyMi.nPosition - this.transform.position);
							if (148717 - 271468 != -122750)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (264251 - 382148 == -117897)
								{
									if (sqrMagnitude > this.SiPNrlyMi.runSpeed)
									{
										if (119391 - 263537 != -144145)
										{
											this.transform.position = this.SiPNrlyMi.nPosition;
											if (166959 - 528526 == -361567)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (107607 - 45530 != 62078)
										{
											if (sqrMagnitude > (float)1)
											{
												if (187117 - 223044 != -35927)
												{
													continue;
												}
												this.SiPNrlyMi.moveSpeed = Mathf.Lerp(this.SiPNrlyMi.moveSpeed, this.SiPNrlyMi.runSpeed, (float)10 * Time.deltaTime);
												if (176951 - 251595 == -74643)
												{
													continue;
												}
											}
											else
											{
												this.SiPNrlyMi.moveSpeed = Mathf.Lerp(this.SiPNrlyMi.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (81131 - 108515 == -27383)
												{
													continue;
												}
											}
											this.SiPNrlyMi.vMovement = vector3;
											if (53245 - 419208 == -365963)
											{
												this.SiPNrlyMi.vDirection = vector3;
												if (37846 - 266668 == -228822)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (294013 - 315185 != -21171)
													{
														this.animation.CrossFade("run", 0.2f);
														if (163418 - 193263 == -29845)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (278233 - 594039 != -315805)
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
										this.SiPNrlyMi.vMovement = vector3;
										if (119867 - 555480 != -435612)
										{
											this.SiPNrlyMi.moveSpeed = (float)0;
											if (177515 - 439156 == -261641)
											{
												this.transform.rotation = Quaternion.LookRotation(this.SiPNrlyMi.vDirection);
												if (34675 - 219983 != -185307)
												{
													this.animation.CrossFade("root", 0.2f);
													if (134008 - 506666 != -372657)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (149500 - 510430 != -360929)
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
						if (264406 - 22792 != 241615)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (286315 - 41468 == 244847)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00034B38 File Offset: 0x00032D38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (52700 - 90898 != -38198)
		{
		}
		do
		{
			if (Time.time - this.VsNPAcGBK >= this.xplSHwH7h)
			{
				if (139432 - 358868 != -219436)
				{
					continue;
				}
				if (Time.time - this.VsNPAcGBK < this.xplSHwH7h + mTime)
				{
					if (254719 - 271547 != -16828)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (204071 - 348364 == -144292)
						{
							continue;
						}
						this.AI_state = "idle";
						if (80307 - 473851 == -393543)
						{
							continue;
						}
						this.VsNPAcGBK -= UnityEngine.Random.Range((float)0, rTimer);
						if (293511 - 308350 == -14838)
						{
							continue;
						}
						this.SiPNrlyMi.vDirection = Vector3.zero;
						if (45066 - 244901 == -199834)
						{
							continue;
						}
						this.SiPNrlyMi.vMovement = this.transform.forward;
						if (62447 - 425292 == -362844)
						{
							continue;
						}
						this.SiPNrlyMi.actionState = "standby";
						if (66897 - 156043 == -89145)
						{
							continue;
						}
					}
					this.SiPNrlyMi.moveSpeed = Mathf.Lerp(this.SiPNrlyMi.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (139386 - 525950 == -386563)
					{
						continue;
					}
					if (this.SiPNrlyMi.moveSpeed < 0.1f * this.SiPNrlyMi.runSpeed)
					{
						if (252152 - 100055 == 152098)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (8619 - 331704 != -323085)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (33087 - 456258 == -423170)
						{
							continue;
						}
						this.SiPNrlyMi.moveSpeed = (float)0;
						if (274138 - 102903 == 171236)
						{
							continue;
						}
					}
				}
			}
			this.xplSHwH7h += mTime;
		}
		while (192700 - 149392 != 43308);
	}

	// Token: 0x06000210 RID: 528 RVA: 0x00034DFC File Offset: 0x00032FFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (254232 - 279956 != -25723)
		{
		}
		do
		{
			if (Time.time - this.VsNPAcGBK >= this.xplSHwH7h)
			{
				if (62221 - 234246 != -172025)
				{
					continue;
				}
				if (Time.time - this.VsNPAcGBK < this.xplSHwH7h + mTime)
				{
					if (21558 - 538612 != -517054)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (108148 - 233206 == -125057)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (35676 - 21442 != 14234)
						{
							continue;
						}
						this.VsNPAcGBK -= UnityEngine.Random.Range((float)0, rTimer);
						if (31716 - 320327 == -288610)
						{
							continue;
						}
						this.SiPNrlyMi.vDirection = this.SiPNrlyMi.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (53538 - 420686 != -367148)
						{
							continue;
						}
						this.SiPNrlyMi.vDirection.y = this.transform.position.y;
						if (4830 - 199670 == -194839)
						{
							continue;
						}
						this.SiPNrlyMi.vMovement = (this.SiPNrlyMi.vDirection - this.transform.position).normalized;
						if (264221 - 70511 == 193711)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.SiPNrlyMi.vMovement);
						if (96876 - 271069 != -174193)
						{
							continue;
						}
						this.SiPNrlyMi.actionState = "run";
						if (153489 - 315633 != -162144)
						{
							continue;
						}
						this.animation.Play("run");
						if (138046 - 87450 != 50596)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (157611 - 351197 != -193586)
						{
							continue;
						}
					}
					this.SiPNrlyMi.moveSpeed = Mathf.Lerp(this.SiPNrlyMi.moveSpeed, this.SiPNrlyMi.runSpeed, (float)4 * Time.deltaTime);
					if (82625 - 129151 != -46526)
					{
						continue;
					}
				}
			}
			this.xplSHwH7h += mTime;
		}
		while (21183 - 214616 == -193432);
	}

	// Token: 0x06000211 RID: 529 RVA: 0x00035104 File Offset: 0x00033304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (236293 - 550321 != -314028)
		{
		}
		do
		{
			if (Time.time - this.VsNPAcGBK >= this.xplSHwH7h)
			{
				if (115697 - 421785 != -306088)
				{
					continue;
				}
				if (Time.time - this.VsNPAcGBK < this.xplSHwH7h + mTime)
				{
					if (9310 - 416870 == -407559)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (614 - 321282 != -320668)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (226472 - 569168 != -342696)
						{
							continue;
						}
						this.VsNPAcGBK = Time.time - mTime - this.xplSHwH7h;
						if (139283 - 437120 != -297837)
						{
							continue;
						}
						this.SiPNrlyMi.vDirection = Vector3.zero;
						if (243780 - 266287 != -22507)
						{
							continue;
						}
						this.SiPNrlyMi.vMovement = this.transform.forward;
						if (2866 - 543715 != -540849)
						{
							continue;
						}
						this.SiPNrlyMi.actionState = "standby";
						if (37022 - 329859 == -292836)
						{
							continue;
						}
						this.SiPNrlyMi.myAttackTarget = this.SiPNrlyMi.getHateTarget(5, 50);
						if (58770 - 339212 != -280442)
						{
							continue;
						}
						if (!this.SiPNrlyMi.myAttackTarget)
						{
							if (220285 - 442727 != -222442)
							{
								continue;
							}
							this.SiPNrlyMi.isAlert = false;
							if (282960 - 364221 != -81261)
							{
								continue;
							}
							this.VsNPAcGBK = Time.time;
							if (235120 - 350010 == -114889)
							{
								continue;
							}
							this.SiPNrlyMi.myAttackTarget = null;
							if (221670 - 232422 == -10751)
							{
								continue;
							}
							this.SiPNrlyMi.mOriginalPosition = this.transform.position;
							if (187703 - 206666 != -18962)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.SiPNrlyMi.myAttackTarget;
							if (264468 - 81685 == 182784)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (93873 - 453641 == -359767)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (127892 - 535953 == -408060)
								{
									continue;
								}
								this.SiPNrlyMi.isAlert = false;
								if (50016 - 194455 == -144438)
								{
									continue;
								}
								this.VsNPAcGBK = Time.time;
								if (63141 - 255704 != -192563)
								{
									continue;
								}
								this.SiPNrlyMi.myAttackTarget = null;
								if (170329 - 410570 != -240241)
								{
									continue;
								}
							}
							else
							{
								this.SiPNrlyMi.vDirection = myAttackTarget.transform.position;
								if (230056 - 345960 == -115903)
								{
									continue;
								}
								this.SiPNrlyMi.vDirection.y = this.transform.position.y;
								if (113317 - 75584 == 37734)
								{
									continue;
								}
								this.SiPNrlyMi.vMovement = (this.SiPNrlyMi.vDirection - this.transform.position).normalized;
								if (183637 - 244651 == -61013)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.SiPNrlyMi.vMovement);
								if (72969 - 2278 != 70691)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.xplSHwH7h += mTime;
		}
		while (250594 - 484399 == -233804);
	}

	// Token: 0x06000212 RID: 530 RVA: 0x000355B4 File Offset: 0x000337B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (277509 - 277714 != -205)
		{
		}
		do
		{
			if (Time.time - this.VsNPAcGBK >= this.xplSHwH7h)
			{
				if (235134 - 194629 != 40505)
				{
					continue;
				}
				if (Time.time - this.VsNPAcGBK < this.xplSHwH7h + mTime)
				{
					if (284478 - 47652 != 236826)
					{
						continue;
					}
					if (!this.SiPNrlyMi.myAttackTarget)
					{
						if (95200 - 402628 == -307427)
						{
							continue;
						}
						this.VsNPAcGBK = Time.time - mTime - this.xplSHwH7h;
						if (223681 - 19087 != 204595)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.SiPNrlyMi.myAttackTarget;
						if (72967 - 302558 != -229591)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (6413 - 88648 != -82235)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (41605 - 561398 == -519792 || 233650 - 531448 == -297797)
						{
							continue;
						}
						if (characterControl)
						{
							if (62565 - 594158 == -531592)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (154630 - 402828 == -248197)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (87219 - 201207 == -113987)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (45576 - 14149 == 31428)
							{
								continue;
							}
							if (this.SiPNrlyMi.isTimeOut("nAttack") == (float)0)
							{
								if (212934 - 415726 != -202792)
								{
									continue;
								}
								this.VsNPAcGBK = Time.time - mTime - this.xplSHwH7h;
								if (125804 - 292623 != -166819)
								{
									continue;
								}
								if (UnityEngine.Random.Range(0, 100) <= 65)
								{
									if (289508 - 183472 != 106036)
									{
										continue;
									}
									this.ie3EfrLwk.StartCoroutine_Auto(this.ie3EfrLwk.RPC_weedSwipe(this.transform.position, vector, 0));
									if (88803 - 518192 != -429389)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (81998 - 122323 != -40325)
										{
											continue;
										}
										this.ie3EfrLwk.ActionEvent("RPC_weedSwipe", this.transform.position, vector, 0);
										if (183197 - 70340 == 112858)
										{
											continue;
										}
									}
								}
								else
								{
									this.ie3EfrLwk.StartCoroutine_Auto(this.ie3EfrLwk.RPC_bellyBump(this.transform.position, vector, 0));
									if (267619 - 507220 != -239601)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (195879 - 416508 != -220629)
										{
											continue;
										}
										this.ie3EfrLwk.ActionEvent("RPC_bellyBump", this.transform.position, vector, 0);
										if (240075 - 223098 == 16978)
										{
											continue;
										}
									}
								}
								goto IL_43D;
							}
						}
						this.AI_state = "attack";
						if (237495 - 561757 == -324261)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (296711 - 287657 == 9055)
							{
								continue;
							}
							this.SiPNrlyMi.vDirection = myAttackTarget.transform.position;
							if (22308 - 231711 != -209403)
							{
								continue;
							}
							this.SiPNrlyMi.vDirection.y = this.transform.position.y;
							if (97031 - 25385 != 71646)
							{
								continue;
							}
							this.SiPNrlyMi.vMovement = (this.SiPNrlyMi.vDirection - this.transform.position).normalized;
							if (123255 - 216889 != -93634)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.SiPNrlyMi.vMovement);
							if (40475 - 90465 != -49990)
							{
								continue;
							}
							this.SiPNrlyMi.actionState = "standby";
							if (142865 - 48216 == 94650)
							{
								continue;
							}
							this.animation.Play("root");
							if (252390 - 534969 != -282579)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (262743 - 477801 == -215057)
							{
								continue;
							}
							this.SiPNrlyMi.moveSpeed = (float)0;
							if (136739 - 142084 == -5344)
							{
								continue;
							}
						}
						else
						{
							this.SiPNrlyMi.vDirection = myAttackTarget.transform.position;
							if (270155 - 550230 == -280074)
							{
								continue;
							}
							this.SiPNrlyMi.vDirection.y = this.transform.position.y;
							if (90037 - 545248 == -455210)
							{
								continue;
							}
							this.SiPNrlyMi.vMovement = (this.SiPNrlyMi.vDirection - this.transform.position).normalized;
							if (48550 - 478362 == -429811)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.SiPNrlyMi.vMovement);
							if (185850 - 464561 == -278710)
							{
								continue;
							}
							this.SiPNrlyMi.actionState = "run";
							if (173382 - 414159 != -240777)
							{
								continue;
							}
							this.animation.Play("run");
							if (137044 - 282879 != -145835)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (241522 - 122880 == 118643)
							{
								continue;
							}
							this.SiPNrlyMi.moveSpeed = Mathf.Lerp(this.SiPNrlyMi.moveSpeed, this.SiPNrlyMi.runSpeed, (float)4 * Time.deltaTime);
							if (230764 - 450327 != -219563)
							{
								continue;
							}
						}
					}
				}
			}
			IL_43D:
			this.xplSHwH7h += mTime;
		}
		while (203771 - 117109 != 86662);
	}

	// Token: 0x06000213 RID: 531 RVA: 0x00035D7C File Offset: 0x00033F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (150453 - 285748 != -135295)
		{
		}
		while (Time.time - this.VsNPAcGBK > this.xplSHwH7h)
		{
			if (10080 - 338327 == -328247)
			{
				this.AI_state = "none";
				if (175826 - 186190 == -10364)
				{
					this.VsNPAcGBK = Time.time;
					if (36406 - 467692 != -431285)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00035E30 File Offset: 0x00034030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (164928 - 534205 != -369277)
		{
		}
		for (;;)
		{
			IL_39F:
			if (this.hneBTsGdj > Time.time)
			{
				if (234489 - 405600 == -171111)
				{
					break;
				}
			}
			else
			{
				this.hneBTsGdj = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (105896 - 197113 != -91216)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (124345 - 515334 == -390989)
					{
						if (234103 - 265119 != -31015)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (271864 - 13907 == 257957)
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
									if (280892 - 536491 != -255599)
									{
										goto IL_39F;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (227869 - 444514 != -216645)
									{
										goto IL_39F;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (243504 - 361926 == -118421)
									{
										goto IL_39F;
									}
									bool flag = true;
									if (176193 - 25476 == 150718)
									{
										goto IL_39F;
									}
									eRace race = this.SiPNrlyMi.Race;
									if (203571 - 572195 != -368624)
									{
										goto IL_39F;
									}
									if (race == eRace.Tails)
									{
										if (276663 - 578468 == -301804)
										{
											goto IL_39F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_6F4;
										}
										if (76758 - 70007 == 6752)
										{
											goto IL_39F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (26275 - 203349 != -177073)
											{
												goto IL_6F4;
											}
											goto IL_39F;
										}
										goto IL_3F4;
										IL_6F4:
										flag = false;
										if (294959 - 421829 != -126870)
										{
											goto IL_39F;
										}
									}
									else if (race == eRace.Plants)
									{
										if (188893 - 479852 != -290959)
										{
											goto IL_39F;
										}
										flag = false;
										if (82251 - 238202 != -155951)
										{
											goto IL_39F;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (204830 - 246720 == -41889)
										{
											goto IL_39F;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_683;
										}
										if (57802 - 490037 == -432234)
										{
											goto IL_39F;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (258360 - 276025 != -17665)
											{
												goto IL_39F;
											}
											goto IL_683;
										}
										goto IL_3F4;
										IL_683:
										flag = false;
										if (114283 - 2461 == 111823)
										{
											goto IL_39F;
										}
									}
									else if (race == eRace.Robots)
									{
										if (16029 - 150835 == -134805)
										{
											goto IL_39F;
										}
										flag = true;
										if (42052 - 159233 == -117180)
										{
											goto IL_39F;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (103769 - 261968 != -158199)
										{
											goto IL_39F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_583;
										}
										if (17063 - 121706 != -104643)
										{
											goto IL_39F;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_583;
										}
										if (258923 - 410580 == -151656)
										{
											goto IL_39F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (284582 - 438496 != -153914)
											{
												goto IL_39F;
											}
											goto IL_583;
										}
										goto IL_3F4;
										IL_583:
										flag = false;
										if (91034 - 296478 == -205443)
										{
											goto IL_39F;
										}
									}
									else if (race == eRace.Structure)
									{
										if (275413 - 492879 == -217465)
										{
											goto IL_39F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (61060 - 582408 == -521347)
											{
												goto IL_39F;
											}
											flag = false;
											if (29849 - 586507 == -556657)
											{
												goto IL_39F;
											}
										}
									}
									IL_3F4:
									if (flag)
									{
										if (123028 - 425735 != -302707)
										{
											goto IL_39F;
										}
										if (characterControl.hp > 0)
										{
											if (45996 - 342165 != -296169)
											{
												goto IL_39F;
											}
											if (characterControl.recieveTarget)
											{
												if (182413 - 445042 == -262628)
												{
													goto IL_39F;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (119610 - 436498 != -316888)
													{
														goto IL_39F;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (224520 - 192770 == 31751)
														{
															goto IL_39F;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (254481 - 516823 == -262341)
														{
															goto IL_39F;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (241330 - 204493 == 36838)
															{
																goto IL_39F;
															}
															this.SiPNrlyMi.myAttackTarget = gameObject;
															if (159766 - 145805 != 13961)
															{
																goto IL_39F;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (179575 - 439912 == -260336)
															{
																goto IL_39F;
															}
															this.SiPNrlyMi.addHate(characterControl.ActorNr, 5);
															if (79029 - 144147 == -65117)
															{
																goto IL_39F;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (111958 - 374166 == -262207)
															{
																goto IL_39F;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (212667 - 388354 != -175687)
															{
																goto IL_39F;
															}
															if (num < (float)60)
															{
																if (263017 - 312573 == -49555)
																{
																	goto IL_39F;
																}
																if (characterControl.hp > 0)
																{
																	if (141355 - 70853 != 70502)
																	{
																		goto IL_39F;
																	}
																	this.SiPNrlyMi.myAttackTarget = gameObject;
																	if (249664 - 190224 == 59441)
																	{
																		goto IL_39F;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (186439 - 102371 != 84068)
																	{
																		goto IL_39F;
																	}
																	this.SiPNrlyMi.addHate(characterControl.ActorNr, 5);
																	if (145246 - 89193 == 56054)
																	{
																		goto IL_39F;
																	}
																}
															}
														}
														if (this.SiPNrlyMi.myAttackTarget)
														{
															if (274673 - 65924 == 208750)
															{
																goto IL_39F;
															}
															this.SiPNrlyMi.isAlert = true;
															if (71036 - 479617 == -408580)
															{
																goto IL_39F;
															}
															this.VsNPAcGBK = Time.time;
															if (284261 - 146773 != 137488)
															{
																goto IL_39F;
															}
														}
													}
												}
											}
										}
									}
								}
								if (296774 - 301883 == -5109)
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

	// Token: 0x06000215 RID: 533 RVA: 0x00036648 File Offset: 0x00034848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000216 RID: 534 RVA: 0x0003664C File Offset: 0x0003484C
	internal static bool eV1k9rVHnR9oZSq2J2J()
	{
		return true;
	}

	// Token: 0x06000217 RID: 535 RVA: 0x00036650 File Offset: 0x00034850
	internal static bool DW3CNqVWQlM1WrieXFn()
	{
		return false;
	}

	// Token: 0x0400024B RID: 587
	private CharacterControl SiPNrlyMi;

	// Token: 0x0400024C RID: 588
	private FatBug ie3EfrLwk;

	// Token: 0x0400024D RID: 589
	public string AI_state;

	// Token: 0x0400024E RID: 590
	private float VsNPAcGBK;

	// Token: 0x0400024F RID: 591
	private float xplSHwH7h;

	// Token: 0x04000250 RID: 592
	private float hneBTsGdj;
}
