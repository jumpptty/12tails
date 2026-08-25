using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000374 RID: 884
[Serializable]
public class Phoenix_AI : MonoBehaviour
{
	// Token: 0x0600141B RID: 5147 RVA: 0x001F9450 File Offset: 0x001F7650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Phoenix_AI()
	{
		if (216335 - 219639 != -3304)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (130626 - 30427 == 100199)
			{
				base..ctor();
				if (13866 - 510608 == -496742)
				{
					this.AI_state = "none";
					if (174221 - 128084 != 46138)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x001F94EC File Offset: 0x001F76EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.lc4tMC2KJS = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.lDltfmMBAp = (Phoenix)this.GetComponent(typeof(Phoenix));
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x001F9524 File Offset: 0x001F7724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (21968 - 92103 != -70135)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (216516 - 192385 == 24132)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (222826 - 42089 == 180738)
				{
					continue;
				}
			}
			if (this.lc4tMC2KJS.isControlled)
			{
				break;
			}
			if (28537 - 334060 == -305523)
			{
				this.AIControl();
				if (2318 - 473045 != -470726)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x001F95F0 File Offset: 0x001F77F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (120835 - 483910 != -363075)
		{
		}
		for (;;)
		{
			this.GFAtwULm1A = (float)0;
			if (222975 - 147670 != 75306)
			{
				if (this.lc4tMC2KJS.isMine)
				{
					if (179797 - 20285 != 159513)
					{
						if (this.lc4tMC2KJS.actionState != "standby")
						{
							if (182700 - 246109 == -63408)
							{
								continue;
							}
							if (this.lc4tMC2KJS.actionState != "run")
							{
								if (113777 - 452326 != -338548)
								{
									break;
								}
								continue;
							}
						}
						if (this.AI_state == "defense")
						{
							if (56367 - 544961 == -488594)
							{
								this.AI_defense();
								if (290514 - 26105 == 264409)
								{
									break;
								}
							}
						}
						else if (!this.lc4tMC2KJS.isAlert)
						{
							if (293231 - 120375 == 172856)
							{
								if (this.lDltfmMBAp.isSummon)
								{
									if (292977 - 477528 != -184550)
									{
										Vector3 vector = this.lDltfmMBAp.mSummoner.transform.position - this.transform.position;
										if (239851 - 135347 != 104505)
										{
											if (vector.magnitude > this.lDltfmMBAp.followDistance)
											{
												if (177817 - 135654 != 42164)
												{
													this.AI_follow(this.lDltfmMBAp.mSummoner);
													if (202789 - 519403 == -316614)
													{
														break;
													}
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (277394 - 78174 == 199220)
												{
													this.AI_resetTimer();
													if (289369 - 424401 != -135031)
													{
														this.AI_visionCheck();
														if (18060 - 347536 != -329475)
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
									this.AI_idle(3f, 1f);
									if (260758 - 361290 == -100532)
									{
										this.AI_patrol(1f, 0.25f);
										if (14005 - 473228 != -459222)
										{
											this.AI_resetTimer();
											if (237933 - 214837 != 23097)
											{
												this.AI_visionCheck();
												if (268609 - 235875 == 32734)
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
							if (this.lDltfmMBAp.isSummon)
							{
								if (97362 - 8825 == 88538)
								{
									continue;
								}
								Vector3 vector2 = this.lDltfmMBAp.mSummoner.transform.position - this.transform.position;
								if (132052 - 324633 == -192580)
								{
									continue;
								}
								if (vector2.magnitude > (float)25)
								{
									if (124738 - 233080 != -108342)
									{
										continue;
									}
									this.lc4tMC2KJS.isAlert = false;
									if (27945 - 565484 != -537539)
									{
										continue;
									}
									this.AI_resetTimer();
									if (200807 - 286419 == -85611)
									{
										continue;
									}
								}
							}
							this.AI_selectTarget(1f, (float)0);
							if (28731 - 252347 == -223616)
							{
								this.AI_idle(1f, 3f - (float)this.lDltfmMBAp.mRapidFireLv);
								if (146032 - 164137 == -18105)
								{
									this.AI_attack(10f, (float)0);
									if (31273 - 329867 != -298593)
									{
										this.AI_resetTimer();
										if (183753 - 585917 == -402164)
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
					if (this.lc4tMC2KJS.actionState != "standby")
					{
						if (109302 - 406700 != -297398)
						{
							continue;
						}
						if (this.lc4tMC2KJS.actionState != "run")
						{
							if (153749 - 575426 != -421677)
							{
								continue;
							}
							break;
						}
					}
					if (this.lc4tMC2KJS.nSpeed != (float)0)
					{
						if (149309 - 234683 == -85373)
						{
							continue;
						}
						if (this.lc4tMC2KJS.nPosition != this.lc4tMC2KJS.oPosition)
						{
							if (287233 - 455219 != -167986)
							{
								continue;
							}
							Vector3 a = this.lc4tMC2KJS.nPosition + 0.1f * this.lc4tMC2KJS.runSpeed * this.lc4tMC2KJS.nDirection;
							if (271924 - 462848 != -190924)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.transform.position);
							if (104698 - 540263 != -435565)
							{
								continue;
							}
							Vector3 normalized = vector3.normalized;
							if (21582 - 573992 != -552410)
							{
								continue;
							}
							Vector3 vector4 = global::Math.vFlat(a - this.transform.position);
							if (155313 - 450721 == -295407)
							{
								continue;
							}
							float magnitude = vector4.magnitude;
							if (30793 - 510401 == -479607)
							{
								continue;
							}
							if (magnitude > this.lc4tMC2KJS.runSpeed)
							{
								if (252034 - 589209 == -337174)
								{
									continue;
								}
								this.transform.position = this.lc4tMC2KJS.nPosition;
								if (15549 - 198707 != -183157)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.lc4tMC2KJS.runSpeed)
							{
								if (1643 - 99796 != -98153)
								{
									continue;
								}
								this.lc4tMC2KJS.moveSpeed = Mathf.Lerp(this.lc4tMC2KJS.moveSpeed, 1.1f * this.lc4tMC2KJS.runSpeed, (float)10 * Time.deltaTime);
								if (86903 - 270799 == -183895)
								{
									continue;
								}
								this.lc4tMC2KJS.vDirection = normalized;
								if (129238 - 241678 != -112440)
								{
									continue;
								}
								this.lc4tMC2KJS.vMovement = normalized;
								if (50052 - 4228 == 45825)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (154232 - 59945 != 94287)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (123457 - 34625 == 88833)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (174502 - 119565 != 54937)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (10787 - 509720 == -498932)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (278883 - 153177 != 125706)
								{
									continue;
								}
								break;
							}
							else
							{
								this.lc4tMC2KJS.moveSpeed = Mathf.Lerp(this.lc4tMC2KJS.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (200870 - 337549 == -136678)
								{
									continue;
								}
								this.lc4tMC2KJS.vDirection = normalized;
								if (293207 - 52875 == 240333)
								{
									continue;
								}
								this.lc4tMC2KJS.vMovement = normalized;
								if (113718 - 139944 != -26226)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (91973 - 291622 == -199648)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (53540 - 442652 != -389112)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.lc4tMC2KJS.moveSpeed != (float)0)
					{
						if (162471 - 89739 == 72732)
						{
							Vector3 vector5 = global::Math.vFlat(this.lc4tMC2KJS.nPosition - this.transform.position);
							if (221782 - 51056 != 170727)
							{
								float sqrMagnitude = vector5.sqrMagnitude;
								if (269575 - 196679 != 72897)
								{
									if (sqrMagnitude > this.lc4tMC2KJS.runSpeed)
									{
										if (291185 - 194568 != 96618)
										{
											this.transform.position = this.lc4tMC2KJS.nPosition;
											if (179883 - 418655 != -238771)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (122091 - 564315 == -442224)
										{
											if (sqrMagnitude > (float)1)
											{
												if (216131 - 399385 == -183253)
												{
													continue;
												}
												this.lc4tMC2KJS.moveSpeed = Mathf.Lerp(this.lc4tMC2KJS.moveSpeed, this.lc4tMC2KJS.runSpeed, (float)10 * Time.deltaTime);
												if (153168 - 184994 == -31825)
												{
													continue;
												}
											}
											else
											{
												this.lc4tMC2KJS.moveSpeed = Mathf.Lerp(this.lc4tMC2KJS.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (262012 - 595588 != -333576)
												{
													continue;
												}
											}
											this.lc4tMC2KJS.vMovement = vector5;
											if (153542 - 580569 == -427027)
											{
												this.lc4tMC2KJS.vDirection = vector5;
												if (186628 - 120970 == 65658)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector5, (float)10 * Time.deltaTime));
													if (230932 - 201880 != 29053)
													{
														this.animation.CrossFade("run", 0.2f);
														if (128248 - 502985 == -374737)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (203913 - 153806 == 50107)
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
										this.lc4tMC2KJS.vMovement = vector5;
										if (182184 - 132502 != 49683)
										{
											this.lc4tMC2KJS.moveSpeed = (float)0;
											if (75876 - 254901 == -179025)
											{
												this.transform.rotation = Quaternion.LookRotation(this.lc4tMC2KJS.vDirection);
												if (16533 - 422441 != -405907)
												{
													this.animation.CrossFade("root", 0.2f);
													if (48233 - 583394 == -535161)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (19308 - 298200 == -278892)
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
						if (95106 - 335625 == -240519)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (277076 - 596103 != -319026)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x001FA36C File Offset: 0x001F856C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_setTimer(float nTime)
	{
		this.AI_state = "none";
		this.ztutLDwPy9 = Time.time - nTime;
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x001FA388 File Offset: 0x001F8588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (243614 - 452044 != -208430)
		{
		}
		for (;;)
		{
			this.lc4tMC2KJS.vDirection = followObject.transform.position;
			if (279622 - 117518 == 162104)
			{
				this.lc4tMC2KJS.vDirection.y = this.transform.position.y;
				if (132460 - 293349 != -160888)
				{
					this.lc4tMC2KJS.vMovement = (this.lc4tMC2KJS.vDirection - this.transform.position).normalized;
					if (219231 - 319528 != -100296)
					{
						this.transform.rotation = Quaternion.LookRotation(this.lc4tMC2KJS.vMovement);
						if (264965 - 467976 == -203011)
						{
							this.lc4tMC2KJS.actionState = "run";
							if (265450 - 497411 == -231961)
							{
								this.animation.Play("run");
								if (142567 - 448839 != -306271)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (138417 - 181904 == -43487)
									{
										this.lc4tMC2KJS.moveSpeed = Mathf.Lerp(this.lc4tMC2KJS.moveSpeed, this.lc4tMC2KJS.runSpeed, (float)4 * Time.deltaTime);
										if (114969 - 582360 == -467391)
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

	// Token: 0x06001421 RID: 5153 RVA: 0x001FA570 File Offset: 0x001F8770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_defense()
	{
		if (24576 - 272134 != -247558)
		{
		}
		for (;;)
		{
			if (!this.lDltfmMBAp.isSummon)
			{
				if (31588 - 472892 != -441303)
				{
					this.AI_resetTimer();
					if (4801 - 440168 != -435366)
					{
						break;
					}
				}
			}
			else
			{
				Vector3 vector = this.lDltfmMBAp.mSummoner.transform.position - this.transform.position;
				if (226943 - 5332 != 221612)
				{
					if (vector.magnitude > this.lDltfmMBAp.followDistance)
					{
						if (281743 - 276270 == 5473)
						{
							this.AI_follow(this.lDltfmMBAp.mSummoner);
							if (172215 - 144809 != 27407)
							{
								break;
							}
						}
					}
					else
					{
						this.lc4tMC2KJS.vDirection = Vector3.zero;
						if (106000 - 260990 != -154989)
						{
							this.lc4tMC2KJS.vMovement = this.transform.forward;
							if (135564 - 319963 != -184398)
							{
								this.lc4tMC2KJS.actionState = "standby";
								if (273675 - 545971 != -272295)
								{
									this.lc4tMC2KJS.moveSpeed = Mathf.Lerp(this.lc4tMC2KJS.moveSpeed, (float)0, (float)4 * Time.deltaTime);
									if (56912 - 346032 != -289119)
									{
										if (this.lc4tMC2KJS.moveSpeed >= 0.1f * this.lc4tMC2KJS.runSpeed)
										{
											break;
										}
										if (52333 - 361200 == -308867)
										{
											this.animation.CrossFade("root", 0.2f);
											if (120836 - 22699 != 98138)
											{
												this.animation.wrapMode = WrapMode.Loop;
												if (143024 - 573323 != -430298)
												{
													this.lc4tMC2KJS.moveSpeed = (float)0;
													if (148189 - 238328 == -90139)
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

	// Token: 0x06001422 RID: 5154 RVA: 0x001FA814 File Offset: 0x001F8A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (219908 - 202024 != 17885)
		{
		}
		do
		{
			if (Time.time - this.ztutLDwPy9 >= this.GFAtwULm1A)
			{
				if (60849 - 425192 != -364343)
				{
					continue;
				}
				if (Time.time - this.ztutLDwPy9 < this.GFAtwULm1A + mTime)
				{
					if (60035 - 243398 == -183362)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (187275 - 290273 != -102998)
						{
							continue;
						}
						this.AI_state = "idle";
						if (188546 - 165966 != 22580)
						{
							continue;
						}
						this.ztutLDwPy9 -= UnityEngine.Random.Range((float)0, rTimer);
						if (235794 - 178459 != 57335)
						{
							continue;
						}
						this.lc4tMC2KJS.vDirection = Vector3.zero;
						if (223314 - 466239 == -242924)
						{
							continue;
						}
						this.lc4tMC2KJS.vMovement = this.transform.forward;
						if (277321 - 104994 != 172327)
						{
							continue;
						}
						this.lc4tMC2KJS.actionState = "standby";
						if (24530 - 505590 != -481060)
						{
							continue;
						}
					}
					this.lc4tMC2KJS.moveSpeed = Mathf.Lerp(this.lc4tMC2KJS.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (64668 - 199373 != -134705)
					{
						continue;
					}
					if (this.lc4tMC2KJS.moveSpeed < 0.1f * this.lc4tMC2KJS.runSpeed)
					{
						if (187963 - 561487 == -373523)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (28351 - 338579 == -310227)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (210447 - 79324 != 131123)
						{
							continue;
						}
						this.lc4tMC2KJS.moveSpeed = (float)0;
						if (285929 - 540862 == -254932)
						{
							continue;
						}
					}
				}
			}
			this.GFAtwULm1A += mTime;
		}
		while (49725 - 95794 == -46068);
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x001FAAD8 File Offset: 0x001F8CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (272121 - 221339 != 50782)
		{
		}
		do
		{
			if (Time.time - this.ztutLDwPy9 >= this.GFAtwULm1A)
			{
				if (108884 - 65090 == 43795)
				{
					continue;
				}
				if (Time.time - this.ztutLDwPy9 < this.GFAtwULm1A + mTime)
				{
					if (252168 - 512940 != -260772)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (64787 - 357755 != -292968)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (181125 - 535581 != -354456)
						{
							continue;
						}
						this.ztutLDwPy9 -= UnityEngine.Random.Range((float)0, rTimer);
						if (30640 - 589311 == -558670)
						{
							continue;
						}
						this.lc4tMC2KJS.vDirection = this.lc4tMC2KJS.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (59690 - 13897 == 45794)
						{
							continue;
						}
						this.lc4tMC2KJS.vDirection.y = this.transform.position.y;
						if (94633 - 72710 == 21924)
						{
							continue;
						}
						this.lc4tMC2KJS.vMovement = (this.lc4tMC2KJS.vDirection - this.transform.position).normalized;
						if (208666 - 550234 == -341567)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.lc4tMC2KJS.vMovement);
						if (180356 - 197926 != -17570)
						{
							continue;
						}
						this.lc4tMC2KJS.actionState = "run";
						if (123182 - 479290 != -356108)
						{
							continue;
						}
						this.animation.Play("run");
						if (24213 - 337757 == -313543)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (197700 - 562580 != -364880)
						{
							continue;
						}
					}
					this.lc4tMC2KJS.moveSpeed = Mathf.Lerp(this.lc4tMC2KJS.moveSpeed, this.lc4tMC2KJS.runSpeed, (float)4 * Time.deltaTime);
					if (124027 - 230112 != -106085)
					{
						continue;
					}
				}
			}
			this.GFAtwULm1A += mTime;
		}
		while (223561 - 239912 != -16351);
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x001FADE0 File Offset: 0x001F8FE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (268204 - 563132 != -294928)
		{
		}
		do
		{
			if (Time.time - this.ztutLDwPy9 >= this.GFAtwULm1A)
			{
				if (98454 - 151672 != -53218)
				{
					continue;
				}
				if (Time.time - this.ztutLDwPy9 < this.GFAtwULm1A + mTime)
				{
					if (224276 - 574980 != -350704)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (159454 - 90745 == 68710)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (123464 - 252198 == -128733)
						{
							continue;
						}
						this.ztutLDwPy9 = Time.time - mTime - this.GFAtwULm1A;
						if (91456 - 599699 != -508243)
						{
							continue;
						}
						this.lc4tMC2KJS.vDirection = Vector3.zero;
						if (285648 - 535614 == -249965)
						{
							continue;
						}
						this.lc4tMC2KJS.vMovement = this.transform.forward;
						if (152980 - 280860 != -127880)
						{
							continue;
						}
						this.lc4tMC2KJS.actionState = "standby";
						if (295154 - 76816 != 218338)
						{
							continue;
						}
						this.lc4tMC2KJS.myAttackTarget = this.lc4tMC2KJS.getHateTarget(15, 40);
						if (95838 - 167208 != -71370)
						{
							continue;
						}
						if (!this.lc4tMC2KJS.myAttackTarget)
						{
							if (63604 - 91883 == -28278)
							{
								continue;
							}
							this.lc4tMC2KJS.isAlert = false;
							if (299012 - 593037 != -294025)
							{
								continue;
							}
							this.ztutLDwPy9 = Time.time;
							if (18946 - 411236 == -392289)
							{
								continue;
							}
							this.lc4tMC2KJS.myAttackTarget = null;
							if (215049 - 597355 == -382305)
							{
								continue;
							}
							this.lc4tMC2KJS.mOriginalPosition = this.transform.position;
							if (161129 - 109507 != 51622)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.lc4tMC2KJS.myAttackTarget;
							if (209428 - 455686 == -246257)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (22414 - 45000 == -22585)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (277098 - 595013 != -317915)
								{
									continue;
								}
								this.lc4tMC2KJS.isAlert = false;
								if (168119 - 474060 == -305940)
								{
									continue;
								}
								this.ztutLDwPy9 = Time.time;
								if (139171 - 178019 != -38848)
								{
									continue;
								}
								this.lc4tMC2KJS.myAttackTarget = null;
								if (176767 - 576128 != -399361)
								{
									continue;
								}
							}
							else
							{
								this.lc4tMC2KJS.vDirection = myAttackTarget.transform.position;
								if (48099 - 10712 == 37388)
								{
									continue;
								}
								this.lc4tMC2KJS.vDirection.y = this.transform.position.y;
								if (185552 - 549382 == -363829)
								{
									continue;
								}
								this.lc4tMC2KJS.vMovement = (this.lc4tMC2KJS.vDirection - this.transform.position).normalized;
								if (115696 - 173119 == -57422)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.lc4tMC2KJS.vMovement);
								if (233243 - 276123 != -42880)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.GFAtwULm1A += mTime;
		}
		while (128787 - 556226 != -427439);
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x001FB290 File Offset: 0x001F9490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (74674 - 523510 != -448835)
		{
		}
		do
		{
			if (Time.time - this.ztutLDwPy9 >= this.GFAtwULm1A)
			{
				if (43155 - 520145 == -476989)
				{
					continue;
				}
				if (Time.time - this.ztutLDwPy9 < this.GFAtwULm1A + mTime)
				{
					if (227282 - 297350 != -70068)
					{
						continue;
					}
					if (!this.lc4tMC2KJS.myAttackTarget)
					{
						if (209722 - 543221 != -333499)
						{
							continue;
						}
						this.ztutLDwPy9 = Time.time - mTime - this.GFAtwULm1A;
						if (190777 - 385165 != -194387)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.lc4tMC2KJS.myAttackTarget;
						if (248130 - 109169 == 138962)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (87131 - 297987 == -210855)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (118832 - 599147 != -480315)
						{
							continue;
						}
						int tID = 0;
						if (61144 - 251172 != -190028)
						{
							continue;
						}
						if (characterControl)
						{
							if (222082 - 531848 != -309766)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (35650 - 422837 != -387187)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (210751 - 479413 == -268661)
						{
							continue;
						}
						if (this.lc4tMC2KJS.hasSkill(412))
						{
							if (125701 - 231238 == -105536)
							{
								continue;
							}
							if (this.lc4tMC2KJS.isTimeOut("instantBlaze") == (float)0)
							{
								if (78400 - 128919 != -50519)
								{
									continue;
								}
								if (num < (float)5)
								{
									if (210520 - 466412 == -255891)
									{
										continue;
									}
									this.ztutLDwPy9 = Time.time - mTime - this.GFAtwULm1A;
									if (75966 - 497079 != -421113)
									{
										continue;
									}
									this.lDltfmMBAp.StartCoroutine_Auto(this.lDltfmMBAp.RPC_instantBlaze(this.transform.position, vector, tID));
									if (269751 - 146672 != 123080)
									{
										if (PhotonClient.IsInitialized())
										{
											if (84171 - 78254 == 5918)
											{
												continue;
											}
											this.lDltfmMBAp.ActionEvent("RPC_instantBlaze", this.transform.position, vector, tID);
											if (104236 - 307371 != -203135)
											{
												continue;
											}
										}
										goto IL_3C4;
									}
									continue;
								}
							}
						}
						if (this.lc4tMC2KJS.isTimeOut("nAttack") == (float)0)
						{
							if (123956 - 393515 != -269559)
							{
								continue;
							}
							this.ztutLDwPy9 = Time.time - mTime - this.GFAtwULm1A;
							if (47253 - 280130 == -232876)
							{
								continue;
							}
							this.lDltfmMBAp.StartCoroutine_Auto(this.lDltfmMBAp.RPC_nAttack(this.transform.position, vector, tID));
							if (81270 - 589802 != -508532)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (291879 - 267330 != 24549)
								{
									continue;
								}
								this.lDltfmMBAp.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
								if (75864 - 94225 != -18361)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (43006 - 308150 == -265143)
							{
								continue;
							}
							if (num < (float)5)
							{
								if (34764 - 408805 == -374040)
								{
									continue;
								}
								this.lc4tMC2KJS.vDirection = myAttackTarget.transform.position;
								if (219597 - 573572 != -353975)
								{
									continue;
								}
								this.lc4tMC2KJS.vDirection.y = this.transform.position.y;
								if (237858 - 260687 == -22828)
								{
									continue;
								}
								this.lc4tMC2KJS.vMovement = (this.lc4tMC2KJS.vDirection - this.transform.position).normalized;
								if (249371 - 502106 == -252734)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.lc4tMC2KJS.vMovement);
								if (239161 - 284506 == -45344)
								{
									continue;
								}
								this.lc4tMC2KJS.actionState = "run";
								if (56889 - 188925 == -132035)
								{
									continue;
								}
								this.animation.Play("root");
								if (67674 - 202115 == -134440)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (237514 - 32621 != 204893)
								{
									continue;
								}
								this.lc4tMC2KJS.moveSpeed = Mathf.Lerp(this.lc4tMC2KJS.moveSpeed, -this.lc4tMC2KJS.runSpeed, (float)4 * Time.deltaTime);
								if (275735 - 179478 != 96257)
								{
									continue;
								}
							}
							else
							{
								this.lc4tMC2KJS.vDirection = myAttackTarget.transform.position;
								if (269601 - 204460 == 65142)
								{
									continue;
								}
								this.lc4tMC2KJS.vDirection.y = this.transform.position.y;
								if (155553 - 60906 != 94647)
								{
									continue;
								}
								this.lc4tMC2KJS.vMovement = (this.lc4tMC2KJS.vDirection - this.transform.position).normalized;
								if (223412 - 493630 != -270218)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.lc4tMC2KJS.vMovement);
								if (128479 - 589945 == -461465)
								{
									continue;
								}
								this.lc4tMC2KJS.actionState = "standby";
								if (200388 - 491911 != -291523)
								{
									continue;
								}
								this.animation.CrossFade("root");
								if (103681 - 35088 != 68593)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (11946 - 356254 != -344308)
								{
									continue;
								}
								this.lc4tMC2KJS.moveSpeed = Mathf.Lerp(this.lc4tMC2KJS.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (260262 - 213615 == 46648)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_3C4:
			this.GFAtwULm1A += mTime;
		}
		while (169463 - 578734 != -409271);
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x001FBAD4 File Offset: 0x001F9CD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (28295 - 64747 != -36452)
		{
		}
		while (Time.time - this.ztutLDwPy9 > this.GFAtwULm1A)
		{
			if (118671 - 199551 != -80879)
			{
				this.AI_state = "none";
				if (32435 - 224260 != -191824)
				{
					this.ztutLDwPy9 = Time.time;
					if (95574 - 90317 != 5258)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001427 RID: 5159 RVA: 0x001FBB88 File Offset: 0x001F9D88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (15855 - 497934 != -482079)
		{
		}
		for (;;)
		{
			IL_298:
			if (this.nqvtUMhscA + (float)1 > Time.time)
			{
				if (8807 - 126902 == -118095)
				{
					break;
				}
			}
			else
			{
				this.nqvtUMhscA = Time.time;
				if (158381 - 372880 != -214498)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)24, this.gameObject.layer);
					if (11204 - 426705 == -415501)
					{
						if (142132 - 30623 == 111509)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (136410 - 164042 == -27632)
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
									if (299581 - 414025 != -114444)
									{
										goto IL_298;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (106848 - 301797 == -194948)
									{
										goto IL_298;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (282795 - 454462 == -171666)
									{
										goto IL_298;
									}
									bool flag = true;
									if (108256 - 79186 == 29071)
									{
										goto IL_298;
									}
									if (this.lDltfmMBAp.isSummon)
									{
										if (10382 - 217794 != -207412)
										{
											goto IL_298;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5BB;
										}
										if (42182 - 474676 == -432493)
										{
											goto IL_298;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (63053 - 527610 != -464557)
											{
												goto IL_298;
											}
											goto IL_5BB;
										}
										goto IL_91;
										IL_5BB:
										flag = false;
										if (77796 - 17868 == 59929)
										{
											goto IL_298;
										}
									}
									else
									{
										if (characterControl.Race != eRace.Plants)
										{
											if (285907 - 393115 == -107207)
											{
												goto IL_298;
											}
											if (characterControl.Race != eRace.Bugs)
											{
												if (107673 - 231582 == -123908)
												{
													goto IL_298;
												}
												if (characterControl.Race != eRace.Structure)
												{
													goto IL_91;
												}
												if (227526 - 347314 == -119787)
												{
													goto IL_298;
												}
											}
										}
										flag = false;
										if (96676 - 409146 != -312470)
										{
											goto IL_298;
										}
									}
									IL_91:
									if (flag)
									{
										if (30016 - 414498 != -384482)
										{
											goto IL_298;
										}
										if (characterControl.hp > 0)
										{
											if (107113 - 394711 != -287598)
											{
												goto IL_298;
											}
											if (characterControl.recieveTarget)
											{
												if (102919 - 125353 != -22434)
												{
													goto IL_298;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (45827 - 546403 != -500576)
													{
														goto IL_298;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (164639 - 266567 == -101927)
														{
															goto IL_298;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (143518 - 59765 != 83753)
														{
															goto IL_298;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (273494 - 194047 != 79447)
															{
																goto IL_298;
															}
															this.lc4tMC2KJS.isAlert = true;
															if (297595 - 62360 == 235236)
															{
																goto IL_298;
															}
															this.ztutLDwPy9 = Time.time;
															if (167013 - 535093 == -368079)
															{
																goto IL_298;
															}
															this.lc4tMC2KJS.myAttackTarget = gameObject;
															if (205966 - 12301 == 193666)
															{
																goto IL_298;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (177291 - 94148 != 83143)
															{
																goto IL_298;
															}
															this.lc4tMC2KJS.addHate(characterControl.ActorNr, 5);
															if (105335 - 300200 != -194865)
															{
																goto IL_298;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (268656 - 400172 != -131516)
															{
																goto IL_298;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (144378 - 357069 != -212691)
															{
																goto IL_298;
															}
															if (num < (float)60)
															{
																if (256175 - 148788 != 107387)
																{
																	goto IL_298;
																}
																if (characterControl.hp > 0)
																{
																	if (214344 - 448402 == -234057)
																	{
																		goto IL_298;
																	}
																	this.lc4tMC2KJS.isAlert = true;
																	if (259088 - 96997 == 162092)
																	{
																		goto IL_298;
																	}
																	this.ztutLDwPy9 = Time.time;
																	if (83457 - 109191 == -25733)
																	{
																		goto IL_298;
																	}
																	this.lc4tMC2KJS.myAttackTarget = gameObject;
																	if (217928 - 159339 == 58590)
																	{
																		goto IL_298;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (286328 - 578529 != -292201)
																	{
																		goto IL_298;
																	}
																	this.lc4tMC2KJS.addHate(characterControl.ActorNr, 5);
																	if (150436 - 522875 == -372438)
																	{
																		goto IL_298;
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
								if (267241 - 372329 == -105088)
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

	// Token: 0x06001428 RID: 5160 RVA: 0x001FC1EC File Offset: 0x001FA3EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001429 RID: 5161 RVA: 0x001FC1F0 File Offset: 0x001FA3F0
	internal static bool KXtNaoOMwHX4m1OtmKc()
	{
		return true;
	}

	// Token: 0x0600142A RID: 5162 RVA: 0x001FC1F4 File Offset: 0x001FA3F4
	internal static bool yq9uTrOxm687nrOtLMQ()
	{
		return false;
	}

	// Token: 0x04001196 RID: 4502
	private CharacterControl lc4tMC2KJS;

	// Token: 0x04001197 RID: 4503
	private Phoenix lDltfmMBAp;

	// Token: 0x04001198 RID: 4504
	public string AI_state;

	// Token: 0x04001199 RID: 4505
	private float ztutLDwPy9;

	// Token: 0x0400119A RID: 4506
	private float GFAtwULm1A;

	// Token: 0x0400119B RID: 4507
	private float nqvtUMhscA;
}
