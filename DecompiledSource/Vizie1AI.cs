using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003C6 RID: 966
[Serializable]
public class Vizie1AI : MonoBehaviour
{
	// Token: 0x0600167B RID: 5755 RVA: 0x0024C498 File Offset: 0x0024A698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vizie1AI()
	{
		if (264833 - 531578 != -266744)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (95224 - 218221 != -122996)
			{
				base..ctor();
				if (76412 - 3444 == 72968)
				{
					this.AI_state = "none";
					if (251213 - 118315 == 132898)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x0024C534 File Offset: 0x0024A734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.PTrOxjQLQ8 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.zr3OTCvj6S = (Vizie1)this.GetComponent(typeof(Vizie1));
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x0024C56C File Offset: 0x0024A76C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (143484 - 332034 != -188550)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (81825 - 436349 != -354524)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (222964 - 232701 == -9736)
				{
					continue;
				}
			}
			if (this.PTrOxjQLQ8.isControlled)
			{
				break;
			}
			if (46222 - 306851 == -260629)
			{
				this.AIControl();
				if (125750 - 467186 == -341436)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x0024C638 File Offset: 0x0024A838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (239968 - 18590 != 221379)
		{
		}
		for (;;)
		{
			this.RD9O3bf0DT = (float)0;
			if (162581 - 247091 == -84510)
			{
				if (this.PTrOxjQLQ8.isMine)
				{
					if (48451 - 153677 != -105225)
					{
						if (this.PTrOxjQLQ8.actionState != "standby")
						{
							if (138938 - 369918 == -230979)
							{
								continue;
							}
							if (this.PTrOxjQLQ8.actionState != "run")
							{
								if (122521 - 230713 != -108191)
								{
									break;
								}
								continue;
							}
						}
						if (!this.PTrOxjQLQ8.isAlert)
						{
							if (224552 - 443906 != -219353)
							{
								this.AI_idle(3f, 1f);
								if (294145 - 426788 != -132642)
								{
									this.AI_patrol(3f, 1f);
									if (105783 - 397681 != -291897)
									{
										this.AI_resetTimer();
										if (233260 - 434193 == -200933)
										{
											this.AI_visionCheck();
											if (289937 - 201186 != 88752)
											{
												if (!this.PTrOxjQLQ8.myAttackTarget)
												{
													break;
												}
												if (195504 - 74469 == 121035)
												{
													this.PTrOxjQLQ8.isAlert = true;
													if (168133 - 330806 == -162673)
													{
														this.wvwOYyCIrq = Time.time;
														if (198014 - 557900 == -359886)
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
							if (70571 - 193295 != -122723)
							{
								this.AI_patrol(3f, 1f);
								if (64957 - 484367 == -419410)
								{
									this.AI_attack(5f, (float)0);
									if (91290 - 26186 != 65105)
									{
										this.AI_resetTimer();
										if (11484 - 270416 == -258932)
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
					if (this.PTrOxjQLQ8.actionState != "standby")
					{
						if (170812 - 595581 == -424768)
						{
							continue;
						}
						if (this.PTrOxjQLQ8.actionState != "run")
						{
							if (630 - 313113 != -312483)
							{
								continue;
							}
							break;
						}
					}
					if (this.PTrOxjQLQ8.nSpeed != (float)0)
					{
						if (163122 - 468145 != -305023)
						{
							continue;
						}
						if (this.PTrOxjQLQ8.nPosition != this.PTrOxjQLQ8.oPosition)
						{
							if (111390 - 150986 != -39596)
							{
								continue;
							}
							Vector3 a = this.PTrOxjQLQ8.nPosition + 0.1f * this.PTrOxjQLQ8.runSpeed * this.PTrOxjQLQ8.nDirection;
							if (6507 - 130598 == -124090)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (83226 - 109664 == -26437)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (115899 - 31968 != 83931)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (93384 - 59274 == 34111)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (59657 - 591179 == -531521)
							{
								continue;
							}
							if (magnitude > this.PTrOxjQLQ8.runSpeed)
							{
								if (159507 - 583169 != -423662)
								{
									continue;
								}
								this.transform.position = this.PTrOxjQLQ8.nPosition;
								if (289116 - 356294 != -67178)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.PTrOxjQLQ8.runSpeed)
							{
								if (60960 - 264784 != -203824)
								{
									continue;
								}
								this.PTrOxjQLQ8.moveSpeed = Mathf.Lerp(this.PTrOxjQLQ8.moveSpeed, 1.1f * this.PTrOxjQLQ8.runSpeed, (float)10 * Time.deltaTime);
								if (294857 - 542237 != -247380)
								{
									continue;
								}
								this.PTrOxjQLQ8.vDirection = normalized;
								if (23843 - 23573 == 271)
								{
									continue;
								}
								this.PTrOxjQLQ8.vMovement = normalized;
								if (285314 - 83076 == 202239)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (127936 - 76828 == 51109)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (271300 - 552026 != -280726)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (53624 - 510365 != -456741)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (107939 - 232893 == -124953)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (288441 - 278647 != 9794)
								{
									continue;
								}
								break;
							}
							else
							{
								this.PTrOxjQLQ8.moveSpeed = Mathf.Lerp(this.PTrOxjQLQ8.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (232400 - 92876 != 139524)
								{
									continue;
								}
								this.PTrOxjQLQ8.vDirection = normalized;
								if (247400 - 341875 == -94474)
								{
									continue;
								}
								this.PTrOxjQLQ8.vMovement = normalized;
								if (82461 - 296742 != -214281)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (56491 - 315079 == -258587)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (28969 - 331220 != -302250)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.PTrOxjQLQ8.moveSpeed != (float)0)
					{
						if (50627 - 565371 != -514743)
						{
							Vector3 vector3 = global::Math.vFlat(this.PTrOxjQLQ8.nPosition - this.transform.position);
							if (180678 - 105907 == 74771)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (106501 - 408563 != -302061)
								{
									if (sqrMagnitude > this.PTrOxjQLQ8.runSpeed)
									{
										if (265595 - 423102 == -157507)
										{
											this.transform.position = this.PTrOxjQLQ8.nPosition;
											if (171774 - 188845 == -17071)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (172883 - 388118 == -215235)
										{
											if (sqrMagnitude > (float)1)
											{
												if (172170 - 129359 == 42812)
												{
													continue;
												}
												this.PTrOxjQLQ8.moveSpeed = Mathf.Lerp(this.PTrOxjQLQ8.moveSpeed, this.PTrOxjQLQ8.runSpeed, (float)10 * Time.deltaTime);
												if (84068 - 329548 == -245479)
												{
													continue;
												}
											}
											else
											{
												this.PTrOxjQLQ8.moveSpeed = Mathf.Lerp(this.PTrOxjQLQ8.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (239799 - 233016 == 6784)
												{
													continue;
												}
											}
											this.PTrOxjQLQ8.vMovement = vector3;
											if (98510 - 372391 != -273880)
											{
												this.PTrOxjQLQ8.vDirection = vector3;
												if (1325 - 102412 == -101087)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (42444 - 112451 == -70007)
													{
														this.animation.CrossFade("run", 0.2f);
														if (103158 - 441901 == -338743)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (153841 - 528813 != -374971)
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
										this.PTrOxjQLQ8.vMovement = vector3;
										if (265677 - 213352 != 52326)
										{
											this.PTrOxjQLQ8.moveSpeed = (float)0;
											if (182039 - 470800 == -288761)
											{
												this.transform.rotation = Quaternion.LookRotation(this.PTrOxjQLQ8.vDirection);
												if (40677 - 236 == 40441)
												{
													this.animation.CrossFade("root", 0.2f);
													if (80838 - 502657 != -421818)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (6541 - 364590 != -358048)
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
						if (72314 - 341143 == -268829)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (144370 - 555919 != -411548)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x0024D1B8 File Offset: 0x0024B3B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (210848 - 437365 != -226516)
		{
		}
		do
		{
			if (Time.time - this.wvwOYyCIrq >= this.RD9O3bf0DT)
			{
				if (51296 - 586204 == -534907)
				{
					continue;
				}
				if (Time.time - this.wvwOYyCIrq < this.RD9O3bf0DT + mTime)
				{
					if (272353 - 553722 != -281369)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (217434 - 44362 != 173072)
						{
							continue;
						}
						this.AI_state = "idle";
						if (134215 - 342159 != -207944)
						{
							continue;
						}
						this.wvwOYyCIrq -= UnityEngine.Random.Range((float)0, rTimer);
						if (116033 - 112404 != 3629)
						{
							continue;
						}
						this.PTrOxjQLQ8.vDirection = Vector3.zero;
						if (286493 - 323279 == -36785)
						{
							continue;
						}
						this.PTrOxjQLQ8.vMovement = this.transform.forward;
						if (123686 - 203432 == -79745)
						{
							continue;
						}
						this.PTrOxjQLQ8.actionState = "standby";
						if (47083 - 66567 != -19484)
						{
							continue;
						}
					}
					this.PTrOxjQLQ8.moveSpeed = Mathf.Lerp(this.PTrOxjQLQ8.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (23594 - 188889 == -165294)
					{
						continue;
					}
					if (this.PTrOxjQLQ8.moveSpeed < 0.1f * this.PTrOxjQLQ8.runSpeed)
					{
						if (129483 - 248222 == -118738)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (202165 - 118285 != 83880)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (183395 - 110268 == 73128)
						{
							continue;
						}
						this.PTrOxjQLQ8.moveSpeed = (float)0;
						if (126009 - 28218 != 97791)
						{
							continue;
						}
					}
				}
			}
			this.RD9O3bf0DT += mTime;
		}
		while (99283 - 16661 == 82623);
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x0024D47C File Offset: 0x0024B67C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (182280 - 590291 != -408010)
		{
		}
		do
		{
			if (Time.time - this.wvwOYyCIrq >= this.RD9O3bf0DT)
			{
				if (100786 - 345234 != -244448)
				{
					continue;
				}
				if (Time.time - this.wvwOYyCIrq < this.RD9O3bf0DT + mTime)
				{
					if (129474 - 116913 != 12561)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (179406 - 52196 != 127210)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (247339 - 575367 == -328027)
						{
							continue;
						}
						this.wvwOYyCIrq -= UnityEngine.Random.Range((float)0, rTimer);
						if (227994 - 340009 != -112015)
						{
							continue;
						}
						this.PTrOxjQLQ8.vDirection = this.PTrOxjQLQ8.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (30178 - 399411 != -369233)
						{
							continue;
						}
						this.PTrOxjQLQ8.vDirection.y = this.transform.position.y;
						if (270630 - 586427 != -315797)
						{
							continue;
						}
						this.PTrOxjQLQ8.vMovement = (this.PTrOxjQLQ8.vDirection - this.transform.position).normalized;
						if (241421 - 396727 == -155305)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.PTrOxjQLQ8.vMovement);
						if (10678 - 517129 != -506451)
						{
							continue;
						}
						this.PTrOxjQLQ8.actionState = "run";
						if (293603 - 47302 == 246302)
						{
							continue;
						}
						this.animation.Play("run");
						if (119181 - 475870 != -356689)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (105832 - 382382 != -276550)
						{
							continue;
						}
					}
					this.PTrOxjQLQ8.moveSpeed = Mathf.Lerp(this.PTrOxjQLQ8.moveSpeed, this.PTrOxjQLQ8.runSpeed, (float)4 * Time.deltaTime);
					if (285119 - 500040 == -214920)
					{
						continue;
					}
				}
			}
			this.RD9O3bf0DT += mTime;
		}
		while (205978 - 129762 == 76217);
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x0024D784 File Offset: 0x0024B984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (204495 - 352752 != -148257)
		{
		}
		do
		{
			if (Time.time - this.wvwOYyCIrq >= this.RD9O3bf0DT)
			{
				if (108258 - 580627 != -472369)
				{
					continue;
				}
				if (Time.time - this.wvwOYyCIrq < this.RD9O3bf0DT + mTime)
				{
					if (256496 - 330727 == -74230)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (139292 - 410187 != -270895)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (118416 - 575584 != -457168)
						{
							continue;
						}
						this.wvwOYyCIrq = Time.time - mTime - this.RD9O3bf0DT;
						if (24455 - 47703 == -23247)
						{
							continue;
						}
						this.PTrOxjQLQ8.vDirection = Vector3.zero;
						if (174676 - 267947 == -93270)
						{
							continue;
						}
						this.PTrOxjQLQ8.vMovement = this.transform.forward;
						if (154359 - 234194 != -79835)
						{
							continue;
						}
						this.PTrOxjQLQ8.actionState = "standby";
						if (268677 - 384550 != -115873)
						{
							continue;
						}
						this.PTrOxjQLQ8.myAttackTarget = this.PTrOxjQLQ8.getHateTarget(5, 50);
						if (104810 - 355571 != -250761)
						{
							continue;
						}
						if (!this.PTrOxjQLQ8.myAttackTarget)
						{
							if (126525 - 419839 != -293314)
							{
								continue;
							}
							this.PTrOxjQLQ8.isAlert = false;
							if (10902 - 517839 != -506937)
							{
								continue;
							}
							this.wvwOYyCIrq = Time.time;
							if (66497 - 221845 == -155347)
							{
								continue;
							}
							this.PTrOxjQLQ8.myAttackTarget = null;
							if (243940 - 69845 == 174096)
							{
								continue;
							}
							this.PTrOxjQLQ8.mOriginalPosition = this.transform.position;
							if (38029 - 441991 != -403961)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.PTrOxjQLQ8.myAttackTarget;
							if (152347 - 149239 != 3108)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (12233 - 334244 == -322010)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (277155 - 235884 != 41271)
								{
									continue;
								}
								this.PTrOxjQLQ8.isAlert = false;
								if (184896 - 286585 == -101688)
								{
									continue;
								}
								this.wvwOYyCIrq = Time.time;
								if (58435 - 348854 == -290418)
								{
									continue;
								}
								this.PTrOxjQLQ8.myAttackTarget = null;
								if (25902 - 479592 != -453690)
								{
									continue;
								}
							}
							else
							{
								this.PTrOxjQLQ8.vDirection = myAttackTarget.transform.position;
								if (184061 - 209677 != -25616)
								{
									continue;
								}
								this.PTrOxjQLQ8.vDirection.y = this.transform.position.y;
								if (84135 - 218595 != -134460)
								{
									continue;
								}
								this.PTrOxjQLQ8.vMovement = (this.PTrOxjQLQ8.vDirection - this.transform.position).normalized;
								if (41364 - 131723 != -90359)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.PTrOxjQLQ8.vMovement);
								if (286259 - 428505 == -142245)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.RD9O3bf0DT += mTime;
		}
		while (51398 - 556163 == -504764);
	}

	// Token: 0x06001682 RID: 5762 RVA: 0x0024DC34 File Offset: 0x0024BE34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (276087 - 529377 != -253289)
		{
		}
		do
		{
			if (Time.time - this.wvwOYyCIrq >= this.RD9O3bf0DT)
			{
				if (231877 - 555313 == -323435)
				{
					continue;
				}
				if (Time.time - this.wvwOYyCIrq < this.RD9O3bf0DT + mTime)
				{
					if (150838 - 428395 != -277557)
					{
						continue;
					}
					if (!this.PTrOxjQLQ8.myAttackTarget)
					{
						if (44522 - 67570 == -23047)
						{
							continue;
						}
						this.wvwOYyCIrq = Time.time - mTime - this.RD9O3bf0DT;
						if (258025 - 19487 != 238538)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.PTrOxjQLQ8.myAttackTarget;
						if (231724 - 249646 != -17922)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (291359 - 498116 != -206757)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (190273 - 210513 != -20240)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (175595 - 510274 != -334679)
							{
								continue;
							}
							if (this.PTrOxjQLQ8.isTimeOut("nAttack") == (float)0)
							{
								if (58786 - 69544 == -10757)
								{
									continue;
								}
								this.wvwOYyCIrq = Time.time - mTime - this.RD9O3bf0DT;
								if (75014 - 79791 == -4776)
								{
									continue;
								}
								this.zr3OTCvj6S.StartCoroutine_Auto(this.zr3OTCvj6S.RPC_nAttack(this.transform.position, vector, 0));
								if (143037 - 82363 != 60675)
								{
									if (PhotonClient.IsInitialized())
									{
										if (174371 - 355214 == -180842)
										{
											continue;
										}
										this.zr3OTCvj6S.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (64379 - 457659 != -393280)
										{
											continue;
										}
									}
									goto IL_2E1;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (86116 - 32 == 86085)
						{
							continue;
						}
						this.PTrOxjQLQ8.vDirection = myAttackTarget.transform.position;
						if (281562 - 211368 != 70194)
						{
							continue;
						}
						this.PTrOxjQLQ8.vDirection.y = this.transform.position.y;
						if (156849 - 197070 == -40220)
						{
							continue;
						}
						this.PTrOxjQLQ8.vMovement = (this.PTrOxjQLQ8.vDirection - this.transform.position).normalized;
						if (114465 - 93618 == 20848)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.PTrOxjQLQ8.vMovement);
						if (222800 - 423129 != -200329)
						{
							continue;
						}
						this.PTrOxjQLQ8.actionState = "run";
						if (280994 - 400684 == -119689)
						{
							continue;
						}
						this.animation.Play("run");
						if (209054 - 70241 == 138814)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (144409 - 556235 == -411825)
						{
							continue;
						}
						this.PTrOxjQLQ8.moveSpeed = Mathf.Lerp(this.PTrOxjQLQ8.moveSpeed, this.PTrOxjQLQ8.runSpeed, (float)4 * Time.deltaTime);
						if (249848 - 286166 == -36317)
						{
							continue;
						}
					}
				}
			}
			IL_2E1:
			this.RD9O3bf0DT += mTime;
		}
		while (284113 - 318002 == -33888);
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x0024E0E8 File Offset: 0x0024C2E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (48753 - 311724 != -262970)
		{
		}
		while (Time.time - this.wvwOYyCIrq > this.RD9O3bf0DT)
		{
			if (110207 - 387397 == -277190)
			{
				this.AI_state = "none";
				if (238267 - 481949 != -243681)
				{
					this.wvwOYyCIrq = Time.time;
					if (212735 - 555081 != -342345)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x0024E19C File Offset: 0x0024C39C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (207641 - 433808 != -226166)
		{
		}
		for (;;)
		{
			IL_6CB:
			if (this.vgSObtIw6V > Time.time)
			{
				if (266172 - 104836 != 161337)
				{
					break;
				}
			}
			else
			{
				this.vgSObtIw6V = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (228572 - 117379 != 111194)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (48316 - 321688 == -273372)
					{
						if (87978 - 424574 != -336595)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (168067 - 218750 != -50682)
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
									if (119318 - 444518 != -325200)
									{
										goto IL_6CB;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (209539 - 218961 == -9421)
									{
										goto IL_6CB;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (67039 - 599783 != -532744)
									{
										goto IL_6CB;
									}
									bool flag = true;
									if (77495 - 516297 != -438802)
									{
										goto IL_6CB;
									}
									eRace race = this.PTrOxjQLQ8.Race;
									if (153719 - 470432 == -316712)
									{
										goto IL_6CB;
									}
									if (race == eRace.Tails)
									{
										if (2852 - 536699 == -533846)
										{
											goto IL_6CB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_747;
										}
										if (194262 - 523262 != -329000)
										{
											goto IL_6CB;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (174188 - 59328 != 114860)
											{
												goto IL_6CB;
											}
											goto IL_747;
										}
										goto IL_65F;
										IL_747:
										flag = false;
										if (166621 - 139375 != 27246)
										{
											goto IL_6CB;
										}
									}
									else if (race == eRace.Plants)
									{
										if (292793 - 4253 != 288540)
										{
											goto IL_6CB;
										}
										flag = false;
										if (230716 - 564959 != -334243)
										{
											goto IL_6CB;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (23437 - 492831 == -469393)
										{
											goto IL_6CB;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_46F;
										}
										if (285700 - 73522 == 212179)
										{
											goto IL_6CB;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (183552 - 33238 != 150314)
											{
												goto IL_6CB;
											}
											goto IL_46F;
										}
										goto IL_65F;
										IL_46F:
										flag = false;
										if (206772 - 77159 != 129613)
										{
											goto IL_6CB;
										}
									}
									else if (race == eRace.Robots)
									{
										if (240142 - 553748 == -313605)
										{
											goto IL_6CB;
										}
										flag = true;
										if (106178 - 469557 != -363379)
										{
											goto IL_6CB;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (15382 - 335857 == -320474)
										{
											goto IL_6CB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_4FF;
										}
										if (225152 - 483330 != -258178)
										{
											goto IL_6CB;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_4FF;
										}
										if (281982 - 132939 == 149044)
										{
											goto IL_6CB;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (20382 - 526648 != -506265)
											{
												goto IL_4FF;
											}
											goto IL_6CB;
										}
										goto IL_65F;
										IL_4FF:
										flag = false;
										if (271149 - 495580 == -224430)
										{
											goto IL_6CB;
										}
									}
									else if (race == eRace.Structure)
									{
										if (106416 - 430515 != -324099)
										{
											goto IL_6CB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (276919 - 484675 != -207756)
											{
												goto IL_6CB;
											}
											flag = false;
											if (187162 - 5460 == 181703)
											{
												goto IL_6CB;
											}
										}
									}
									IL_65F:
									if (flag)
									{
										if (23990 - 131598 != -107608)
										{
											goto IL_6CB;
										}
										if (characterControl.hp > 0)
										{
											if (8173 - 500207 != -492034)
											{
												goto IL_6CB;
											}
											if (characterControl.recieveTarget)
											{
												if (29368 - 497690 != -468322)
												{
													goto IL_6CB;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (68445 - 221146 == -152700)
													{
														goto IL_6CB;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (131588 - 24340 == 107249)
														{
															goto IL_6CB;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (268948 - 463780 != -194832)
														{
															goto IL_6CB;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (288891 - 56024 != 232867)
															{
																goto IL_6CB;
															}
															this.PTrOxjQLQ8.myAttackTarget = gameObject;
															if (31311 - 465869 != -434558)
															{
																goto IL_6CB;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (142178 - 382780 != -240602)
															{
																goto IL_6CB;
															}
															this.PTrOxjQLQ8.addHate(characterControl.ActorNr, 5);
															if (286049 - 54956 == 231094)
															{
																goto IL_6CB;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (149964 - 184775 == -34810)
															{
																goto IL_6CB;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (164005 - 122952 != 41053)
															{
																goto IL_6CB;
															}
															if (num < (float)60)
															{
																if (24447 - 13823 != 10624)
																{
																	goto IL_6CB;
																}
																if (characterControl.hp > 0)
																{
																	if (291118 - 19300 != 271818)
																	{
																		goto IL_6CB;
																	}
																	this.PTrOxjQLQ8.myAttackTarget = gameObject;
																	if (78542 - 534728 == -456185)
																	{
																		goto IL_6CB;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (82707 - 102792 == -20084)
																	{
																		goto IL_6CB;
																	}
																	this.PTrOxjQLQ8.addHate(characterControl.ActorNr, 5);
																	if (186078 - 160152 != 25926)
																	{
																		goto IL_6CB;
																	}
																}
															}
														}
														if (this.PTrOxjQLQ8.myAttackTarget)
														{
															if (71321 - 561591 != -490270)
															{
																goto IL_6CB;
															}
															this.PTrOxjQLQ8.isAlert = true;
															if (198269 - 277182 == -78912)
															{
																goto IL_6CB;
															}
															this.wvwOYyCIrq = Time.time;
															if (47325 - 13066 == 34260)
															{
																goto IL_6CB;
															}
														}
													}
												}
											}
										}
									}
								}
								if (174247 - 410487 != -236239)
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

	// Token: 0x06001685 RID: 5765 RVA: 0x0024E9B4 File Offset: 0x0024CBB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001686 RID: 5766 RVA: 0x0024E9B8 File Offset: 0x0024CBB8
	internal static bool BDqWx9MTyltisk0b7Gm()
	{
		return true;
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x0024E9BC File Offset: 0x0024CBBC
	internal static bool owhyLEM3pEbVegnsrIe()
	{
		return false;
	}

	// Token: 0x04001340 RID: 4928
	private CharacterControl PTrOxjQLQ8;

	// Token: 0x04001341 RID: 4929
	private Vizie1 zr3OTCvj6S;

	// Token: 0x04001342 RID: 4930
	public string AI_state;

	// Token: 0x04001343 RID: 4931
	private float wvwOYyCIrq;

	// Token: 0x04001344 RID: 4932
	private float RD9O3bf0DT;

	// Token: 0x04001345 RID: 4933
	private float vgSObtIw6V;
}
