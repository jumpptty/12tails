using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003D4 RID: 980
[Serializable]
public class Vizie3AI : MonoBehaviour
{
	// Token: 0x060016DE RID: 5854 RVA: 0x00257480 File Offset: 0x00255680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vizie3AI()
	{
		if (17418 - 278718 != -261299)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (219592 - 217356 != 2237)
			{
				base..ctor();
				if (189037 - 34593 != 154445)
				{
					this.AI_state = "none";
					if (206968 - 261201 == -54233)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x0025751C File Offset: 0x0025571C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.aiSOHwv3SB = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.zjHO7GgHm7 = (Vizie3)this.GetComponent(typeof(Vizie3));
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x00257554 File Offset: 0x00255754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (132073 - 540345 != -408272)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (62938 - 538651 == -475712)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (146757 - 525354 == -378596)
				{
					continue;
				}
			}
			if (this.aiSOHwv3SB.isControlled)
			{
				break;
			}
			if (23424 - 417594 == -394170)
			{
				this.AIControl();
				if (12258 - 563992 != -551733)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060016E1 RID: 5857 RVA: 0x00257620 File Offset: 0x00255820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (128259 - 93638 != 34621)
		{
		}
		for (;;)
		{
			this.aHVOCL5jeR = (float)0;
			if (296690 - 15408 == 281282)
			{
				if (this.aiSOHwv3SB.isMine)
				{
					if (60501 - 389116 == -328615)
					{
						if (this.aiSOHwv3SB.actionState != "standby")
						{
							if (201824 - 358064 == -156239)
							{
								continue;
							}
							if (this.aiSOHwv3SB.actionState != "run")
							{
								if (159399 - 558376 != -398976)
								{
									break;
								}
								continue;
							}
						}
						if (!this.aiSOHwv3SB.isAlert)
						{
							if (38555 - 307066 != -268510)
							{
								this.AI_idle(6f, 1f);
								if (297537 - 545079 == -247542)
								{
									this.AI_patrol(2f, 1f);
									if (257487 - 53005 != 204483)
									{
										this.AI_resetTimer();
										if (238005 - 508364 != -270358)
										{
											this.AI_visionCheck();
											if (94821 - 194656 != -99834)
											{
												if (!this.aiSOHwv3SB.myAttackTarget)
												{
													break;
												}
												if (167698 - 334524 == -166826)
												{
													this.aiSOHwv3SB.isAlert = true;
													if (73869 - 229302 == -155433)
													{
														this.pnnOZLTk8e = Time.time;
														if (269097 - 344824 != -75726)
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
							if (123854 - 312672 != -188817)
							{
								this.AI_idle(2f, 1f);
								if (225436 - 101929 != 123508)
								{
									this.AI_patrol(1f, (float)0);
									if (271591 - 518360 == -246769)
									{
										this.AI_attack(8f, (float)0);
										if (81199 - 404614 != -323414)
										{
											this.AI_resetTimer();
											if (8219 - 43433 != -35213)
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
					if (this.aiSOHwv3SB.actionState != "standby")
					{
						if (275204 - 566157 != -290953)
						{
							continue;
						}
						if (this.aiSOHwv3SB.actionState != "run")
						{
							if (63232 - 236127 != -172895)
							{
								continue;
							}
							break;
						}
					}
					if (this.aiSOHwv3SB.nSpeed != (float)0)
					{
						if (216601 - 91600 != 125001)
						{
							continue;
						}
						if (this.aiSOHwv3SB.nPosition != this.aiSOHwv3SB.oPosition)
						{
							if (39468 - 119168 != -79700)
							{
								continue;
							}
							Vector3 a = this.aiSOHwv3SB.nPosition + 0.1f * this.aiSOHwv3SB.runSpeed * this.aiSOHwv3SB.nDirection;
							if (223504 - 566389 != -342885)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (114816 - 49858 == 64959)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (111772 - 566030 != -454258)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (202184 - 589560 != -387376)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (69589 - 396662 == -327072)
							{
								continue;
							}
							if (magnitude > this.aiSOHwv3SB.runSpeed)
							{
								if (186475 - 422762 == -236286)
								{
									continue;
								}
								this.transform.position = this.aiSOHwv3SB.nPosition;
								if (93105 - 489548 != -396443)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.aiSOHwv3SB.runSpeed)
							{
								if (249703 - 7579 == 242125)
								{
									continue;
								}
								this.aiSOHwv3SB.moveSpeed = Mathf.Lerp(this.aiSOHwv3SB.moveSpeed, 1.1f * this.aiSOHwv3SB.runSpeed, (float)10 * Time.deltaTime);
								if (266104 - 343046 == -76941)
								{
									continue;
								}
								this.aiSOHwv3SB.vDirection = normalized;
								if (63174 - 181915 == -118740)
								{
									continue;
								}
								this.aiSOHwv3SB.vMovement = normalized;
								if (116413 - 43467 == 72947)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (118933 - 415020 != -296087)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (244859 - 221726 != 23133)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (37208 - 219837 == -182628)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (151002 - 372140 != -221138)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (269432 - 440894 != -171462)
								{
									continue;
								}
								break;
							}
							else
							{
								this.aiSOHwv3SB.moveSpeed = Mathf.Lerp(this.aiSOHwv3SB.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (178880 - 110996 == 67885)
								{
									continue;
								}
								this.aiSOHwv3SB.vDirection = normalized;
								if (222941 - 4315 == 218627)
								{
									continue;
								}
								this.aiSOHwv3SB.vMovement = normalized;
								if (140453 - 136940 != 3513)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (243443 - 254711 != -11268)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (127856 - 161924 != -34067)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.aiSOHwv3SB.moveSpeed != (float)0)
					{
						if (267357 - 219548 != 47810)
						{
							Vector3 vector3 = global::Math.vFlat(this.aiSOHwv3SB.nPosition - this.transform.position);
							if (134131 - 448392 == -314261)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (161317 - 204483 == -43166)
								{
									if (sqrMagnitude > this.aiSOHwv3SB.runSpeed)
									{
										if (209625 - 284402 != -74776)
										{
											this.transform.position = this.aiSOHwv3SB.nPosition;
											if (144426 - 457087 == -312661)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (259265 - 196507 != 62759)
										{
											if (sqrMagnitude > (float)1)
											{
												if (54583 - 59345 != -4762)
												{
													continue;
												}
												this.aiSOHwv3SB.moveSpeed = Mathf.Lerp(this.aiSOHwv3SB.moveSpeed, this.aiSOHwv3SB.runSpeed, (float)10 * Time.deltaTime);
												if (88006 - 586257 != -498251)
												{
													continue;
												}
											}
											else
											{
												this.aiSOHwv3SB.moveSpeed = Mathf.Lerp(this.aiSOHwv3SB.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (260180 - 224582 == 35599)
												{
													continue;
												}
											}
											this.aiSOHwv3SB.vMovement = vector3;
											if (122148 - 370979 == -248831)
											{
												this.aiSOHwv3SB.vDirection = vector3;
												if (116428 - 498417 != -381988)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (202747 - 71496 != 131252)
													{
														this.animation.CrossFade("run", 0.2f);
														if (245928 - 252205 == -6277)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (208699 - 444067 != -235367)
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
										this.aiSOHwv3SB.vMovement = vector3;
										if (186558 - 347818 != -161259)
										{
											this.aiSOHwv3SB.moveSpeed = (float)0;
											if (65622 - 131710 == -66088)
											{
												this.transform.rotation = Quaternion.LookRotation(this.aiSOHwv3SB.vDirection);
												if (140287 - 439806 == -299519)
												{
													this.animation.CrossFade("root", 0.2f);
													if (193473 - 231882 != -38408)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (246337 - 416947 == -170610)
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
						if (285176 - 327585 == -42409)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (15224 - 116419 != -101194)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x002581C8 File Offset: 0x002563C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (298889 - 527436 != -228547)
		{
		}
		do
		{
			if (Time.time - this.pnnOZLTk8e >= this.aHVOCL5jeR)
			{
				if (208550 - 86200 != 122350)
				{
					continue;
				}
				if (Time.time - this.pnnOZLTk8e < this.aHVOCL5jeR + mTime)
				{
					if (22581 - 38130 != -15549)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (82506 - 295279 == -212772)
						{
							continue;
						}
						this.AI_state = "idle";
						if (198465 - 487617 == -289151)
						{
							continue;
						}
						this.pnnOZLTk8e -= UnityEngine.Random.Range((float)0, rTimer);
						if (181706 - 544953 == -363246)
						{
							continue;
						}
						this.aiSOHwv3SB.vDirection = Vector3.zero;
						if (70120 - 496859 == -426738)
						{
							continue;
						}
						this.aiSOHwv3SB.vMovement = this.transform.forward;
						if (135566 - 585884 == -450317)
						{
							continue;
						}
						this.aiSOHwv3SB.actionState = "standby";
						if (295967 - 584417 != -288450)
						{
							continue;
						}
					}
					this.aiSOHwv3SB.moveSpeed = Mathf.Lerp(this.aiSOHwv3SB.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (267570 - 225026 != 42544)
					{
						continue;
					}
					if (this.aiSOHwv3SB.moveSpeed < 0.1f * this.aiSOHwv3SB.runSpeed)
					{
						if (116899 - 60959 == 55941)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (16476 - 238013 == -221536)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (127364 - 56647 == 70718)
						{
							continue;
						}
						this.aiSOHwv3SB.moveSpeed = (float)0;
						if (202762 - 434450 == -231687)
						{
							continue;
						}
					}
				}
			}
			this.aHVOCL5jeR += mTime;
		}
		while (108661 - 453463 != -344802);
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x0025848C File Offset: 0x0025668C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (248797 - 481423 != -232626)
		{
		}
		do
		{
			if (Time.time - this.pnnOZLTk8e >= this.aHVOCL5jeR)
			{
				if (100645 - 575407 == -474761)
				{
					continue;
				}
				if (Time.time - this.pnnOZLTk8e < this.aHVOCL5jeR + mTime)
				{
					if (185481 - 510209 == -324727)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (103507 - 596967 == -493459)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (32464 - 520341 != -487877)
						{
							continue;
						}
						this.pnnOZLTk8e -= UnityEngine.Random.Range((float)0, rTimer);
						if (297797 - 159541 != 138256)
						{
							continue;
						}
						this.aiSOHwv3SB.vDirection = this.aiSOHwv3SB.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (238051 - 456303 != -218252)
						{
							continue;
						}
						this.aiSOHwv3SB.vDirection.y = this.transform.position.y;
						if (141570 - 401696 == -260125)
						{
							continue;
						}
						this.aiSOHwv3SB.vMovement = (this.aiSOHwv3SB.vDirection - this.transform.position).normalized;
						if (106191 - 205707 != -99516)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.aiSOHwv3SB.vMovement);
						if (283980 - 167588 != 116392)
						{
							continue;
						}
						this.aiSOHwv3SB.actionState = "run";
						if (61013 - 229859 == -168845)
						{
							continue;
						}
						this.animation.Play("run");
						if (13487 - 436452 == -422964)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (160158 - 340813 == -180654)
						{
							continue;
						}
					}
					this.aiSOHwv3SB.moveSpeed = Mathf.Lerp(this.aiSOHwv3SB.moveSpeed, this.aiSOHwv3SB.runSpeed, (float)4 * Time.deltaTime);
					if (53766 - 594417 != -540651)
					{
						continue;
					}
				}
			}
			this.aHVOCL5jeR += mTime;
		}
		while (84277 - 241718 == -157440);
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x00258794 File Offset: 0x00256994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (128683 - 394272 != -265589)
		{
		}
		do
		{
			if (Time.time - this.pnnOZLTk8e >= this.aHVOCL5jeR)
			{
				if (78561 - 200691 != -122130)
				{
					continue;
				}
				if (Time.time - this.pnnOZLTk8e < this.aHVOCL5jeR + mTime)
				{
					if (228058 - 483738 == -255679)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (169379 - 420486 != -251107)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (205809 - 267356 == -61546)
						{
							continue;
						}
						this.pnnOZLTk8e = Time.time - mTime - this.aHVOCL5jeR;
						if (285869 - 378944 != -93075)
						{
							continue;
						}
						this.aiSOHwv3SB.vDirection = Vector3.zero;
						if (279158 - 348285 == -69126)
						{
							continue;
						}
						this.aiSOHwv3SB.vMovement = this.transform.forward;
						if (193535 - 568278 == -374742)
						{
							continue;
						}
						this.aiSOHwv3SB.actionState = "standby";
						if (188621 - 128073 != 60548)
						{
							continue;
						}
						this.aiSOHwv3SB.myAttackTarget = this.aiSOHwv3SB.getHateTarget(5, 50);
						if (207344 - 433886 == -226541)
						{
							continue;
						}
						if (!this.aiSOHwv3SB.myAttackTarget)
						{
							if (118977 - 404618 != -285641)
							{
								continue;
							}
							this.aiSOHwv3SB.isAlert = false;
							if (206585 - 534099 != -327514)
							{
								continue;
							}
							this.pnnOZLTk8e = Time.time;
							if (176241 - 257608 == -81366)
							{
								continue;
							}
							this.aiSOHwv3SB.myAttackTarget = null;
							if (290088 - 158452 != 131636)
							{
								continue;
							}
							this.aiSOHwv3SB.mOriginalPosition = this.transform.position;
							if (240168 - 260628 != -20459)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.aiSOHwv3SB.myAttackTarget;
							if (203430 - 553339 != -349909)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (172511 - 597617 == -425105)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (252800 - 544495 != -291695)
								{
									continue;
								}
								this.aiSOHwv3SB.isAlert = false;
								if (29326 - 18229 != 11097)
								{
									continue;
								}
								this.pnnOZLTk8e = Time.time;
								if (21461 - 131734 == -110272)
								{
									continue;
								}
								this.aiSOHwv3SB.myAttackTarget = null;
								if (210913 - 83213 == 127701)
								{
									continue;
								}
							}
							else
							{
								this.aiSOHwv3SB.vDirection = myAttackTarget.transform.position;
								if (232082 - 381003 != -148921)
								{
									continue;
								}
								this.aiSOHwv3SB.vDirection.y = this.transform.position.y;
								if (245381 - 185261 != 60120)
								{
									continue;
								}
								this.aiSOHwv3SB.vMovement = (this.aiSOHwv3SB.vDirection - this.transform.position).normalized;
								if (121230 - 350428 != -229198)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.aiSOHwv3SB.vMovement);
								if (188365 - 223996 != -35631)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.aHVOCL5jeR += mTime;
		}
		while (177737 - 522275 != -344538);
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x00258C44 File Offset: 0x00256E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (88284 - 409652 != -321368)
		{
		}
		do
		{
			if (Time.time - this.pnnOZLTk8e >= this.aHVOCL5jeR)
			{
				if (27882 - 571865 != -543983)
				{
					continue;
				}
				if (Time.time - this.pnnOZLTk8e < this.aHVOCL5jeR + mTime)
				{
					if (60916 - 271761 == -210844)
					{
						continue;
					}
					if (!this.aiSOHwv3SB.myAttackTarget)
					{
						if (195706 - 183960 == 11747)
						{
							continue;
						}
						this.pnnOZLTk8e = Time.time - mTime - this.aHVOCL5jeR;
						if (38891 - 304522 != -265631)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.aiSOHwv3SB.myAttackTarget;
						if (107422 - 10638 == 96785)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (138123 - 283960 != -145837)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (238713 - 200289 == 38425)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (187074 - 471340 == -284265)
							{
								continue;
							}
							if (this.aiSOHwv3SB.isTimeOut("nAttack") == (float)0)
							{
								if (82803 - 483837 == -401033)
								{
									continue;
								}
								this.pnnOZLTk8e = Time.time - mTime - this.aHVOCL5jeR;
								if (252842 - 501371 != -248529)
								{
									continue;
								}
								this.zjHO7GgHm7.StartCoroutine_Auto(this.zjHO7GgHm7.RPC_nAttack(this.transform.position, vector, 0));
								if (43690 - 526848 != -483157)
								{
									if (PhotonClient.IsInitialized())
									{
										if (52726 - 176944 == -124217)
										{
											continue;
										}
										this.zjHO7GgHm7.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (286614 - 100068 != 186546)
										{
											continue;
										}
									}
									goto IL_46E;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (264617 - 327098 != -62481)
						{
							continue;
						}
						this.aiSOHwv3SB.vDirection = myAttackTarget.transform.position;
						if (264553 - 270397 == -5843)
						{
							continue;
						}
						this.aiSOHwv3SB.vDirection.y = this.transform.position.y;
						if (53000 - 470207 != -417207)
						{
							continue;
						}
						this.aiSOHwv3SB.vMovement = (this.aiSOHwv3SB.vDirection - this.transform.position).normalized;
						if (247578 - 109920 == 137659)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.aiSOHwv3SB.vMovement);
						if (136824 - 311136 == -174311)
						{
							continue;
						}
						this.aiSOHwv3SB.actionState = "run";
						if (258372 - 386805 != -128433)
						{
							continue;
						}
						this.animation.Play("run");
						if (187586 - 408721 == -221134)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (81707 - 267641 == -185933)
						{
							continue;
						}
						this.aiSOHwv3SB.moveSpeed = Mathf.Lerp(this.aiSOHwv3SB.moveSpeed, this.aiSOHwv3SB.runSpeed, (float)4 * Time.deltaTime);
						if (220173 - 128267 != 91906)
						{
							continue;
						}
					}
				}
			}
			IL_46E:
			this.aHVOCL5jeR += mTime;
		}
		while (229793 - 269423 != -39630);
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x002590F8 File Offset: 0x002572F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (148472 - 56603 != 91869)
		{
		}
		while (Time.time - this.pnnOZLTk8e > this.aHVOCL5jeR)
		{
			if (170854 - 298462 != -127607)
			{
				this.AI_state = "none";
				if (242342 - 9074 != 233269)
				{
					this.pnnOZLTk8e = Time.time;
					if (270040 - 176893 == 93147)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x002591AC File Offset: 0x002573AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (138162 - 73850 != 64313)
		{
		}
		for (;;)
		{
			IL_61B:
			if (this.A0dOMHsQAs > Time.time)
			{
				if (256966 - 374414 != -117447)
				{
					break;
				}
			}
			else
			{
				this.A0dOMHsQAs = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (295903 - 71308 == 224595)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (152426 - 280934 == -128508)
					{
						if (21058 - 5198 != 15861)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (95417 - 307509 == -212092)
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
									if (132064 - 153686 == -21621)
									{
										goto IL_61B;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (186643 - 228665 == -42021)
									{
										goto IL_61B;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (295812 - 159900 != 135912)
									{
										goto IL_61B;
									}
									bool flag = true;
									if (261837 - 170546 != 91291)
									{
										goto IL_61B;
									}
									eRace race = this.aiSOHwv3SB.Race;
									if (214502 - 39056 != 175446)
									{
										goto IL_61B;
									}
									if (race == eRace.Tails)
									{
										if (135556 - 345653 == -210096)
										{
											goto IL_61B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_372;
										}
										if (272337 - 592866 != -320529)
										{
											goto IL_61B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (93505 - 336510 != -243005)
											{
												goto IL_61B;
											}
											goto IL_372;
										}
										goto IL_F9;
										IL_372:
										flag = false;
										if (239850 - 503839 != -263989)
										{
											goto IL_61B;
										}
									}
									else if (race == eRace.Plants)
									{
										if (6232 - 393779 != -387547)
										{
											goto IL_61B;
										}
										flag = false;
										if (123342 - 541384 != -418042)
										{
											goto IL_61B;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (238715 - 390553 == -151837)
										{
											goto IL_61B;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_792;
										}
										if (234124 - 407323 != -173199)
										{
											goto IL_61B;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (96985 - 519946 != -422960)
											{
												goto IL_792;
											}
											goto IL_61B;
										}
										goto IL_F9;
										IL_792:
										flag = false;
										if (144527 - 144128 == 400)
										{
											goto IL_61B;
										}
									}
									else if (race == eRace.Robots)
									{
										if (30097 - 467080 == -436982)
										{
											goto IL_61B;
										}
										flag = true;
										if (289773 - 357738 == -67964)
										{
											goto IL_61B;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (148672 - 431281 == -282608)
										{
											goto IL_61B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_6D8;
										}
										if (223267 - 114098 == 109170)
										{
											goto IL_61B;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_6D8;
										}
										if (72472 - 411600 != -339128)
										{
											goto IL_61B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (103947 - 514054 != -410107)
											{
												goto IL_61B;
											}
											goto IL_6D8;
										}
										goto IL_F9;
										IL_6D8:
										flag = false;
										if (113032 - 388889 != -275857)
										{
											goto IL_61B;
										}
									}
									else if (race == eRace.Structure)
									{
										if (198903 - 253109 != -54206)
										{
											goto IL_61B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (145644 - 32076 != 113568)
											{
												goto IL_61B;
											}
											flag = false;
											if (119838 - 221631 != -101793)
											{
												goto IL_61B;
											}
										}
									}
									IL_F9:
									if (flag)
									{
										if (209376 - 479980 == -270603)
										{
											goto IL_61B;
										}
										if (characterControl.hp > 0)
										{
											if (58820 - 503912 == -445091)
											{
												goto IL_61B;
											}
											if (characterControl.recieveTarget)
											{
												if (91039 - 568726 == -477686)
												{
													goto IL_61B;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (206217 - 366802 == -160584)
													{
														goto IL_61B;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (231891 - 406888 == -174996)
														{
															goto IL_61B;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (173719 - 215911 == -42191)
														{
															goto IL_61B;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (243679 - 430174 == -186494)
															{
																goto IL_61B;
															}
															this.aiSOHwv3SB.myAttackTarget = gameObject;
															if (72518 - 279343 == -206824)
															{
																goto IL_61B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (258641 - 561179 != -302538)
															{
																goto IL_61B;
															}
															this.aiSOHwv3SB.addHate(characterControl.ActorNr, 5);
															if (199852 - 523197 != -323345)
															{
																goto IL_61B;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (235181 - 113547 == 121635)
															{
																goto IL_61B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (146240 - 122750 == 23491)
															{
																goto IL_61B;
															}
															if (num < (float)60)
															{
																if (190916 - 327025 != -136109)
																{
																	goto IL_61B;
																}
																if (characterControl.hp > 0)
																{
																	if (245918 - 75865 == 170054)
																	{
																		goto IL_61B;
																	}
																	this.aiSOHwv3SB.myAttackTarget = gameObject;
																	if (184931 - 304511 != -119580)
																	{
																		goto IL_61B;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (32146 - 563147 == -531000)
																	{
																		goto IL_61B;
																	}
																	this.aiSOHwv3SB.addHate(characterControl.ActorNr, 5);
																	if (297344 - 347167 == -49822)
																	{
																		goto IL_61B;
																	}
																}
															}
														}
														if (this.aiSOHwv3SB.myAttackTarget)
														{
															if (25475 - 130087 == -104611)
															{
																goto IL_61B;
															}
															this.aiSOHwv3SB.isAlert = true;
															if (225571 - 142569 == 83003)
															{
																goto IL_61B;
															}
															this.pnnOZLTk8e = Time.time;
															if (27106 - 115522 == -88415)
															{
																goto IL_61B;
															}
														}
													}
												}
											}
										}
									}
								}
								if (299482 - 531917 == -232435)
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

	// Token: 0x060016E8 RID: 5864 RVA: 0x002599C4 File Offset: 0x00257BC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x002599C8 File Offset: 0x00257BC8
	internal static bool Ip3IUNMiiQOeXAqyqKx()
	{
		return true;
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x002599CC File Offset: 0x00257BCC
	internal static bool BY10LoMK8fZFAF6wXUK()
	{
		return false;
	}

	// Token: 0x04001385 RID: 4997
	private CharacterControl aiSOHwv3SB;

	// Token: 0x04001386 RID: 4998
	private Vizie3 zjHO7GgHm7;

	// Token: 0x04001387 RID: 4999
	public string AI_state;

	// Token: 0x04001388 RID: 5000
	private float pnnOZLTk8e;

	// Token: 0x04001389 RID: 5001
	private float aHVOCL5jeR;

	// Token: 0x0400138A RID: 5002
	private float A0dOMHsQAs;
}
