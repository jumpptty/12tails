using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000396 RID: 918
[Serializable]
public class Shade4AI : MonoBehaviour
{
	// Token: 0x06001503 RID: 5379 RVA: 0x00212814 File Offset: 0x00210A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shade4AI()
	{
		if (193317 - 299140 != -105822)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (291904 - 549808 == -257904)
			{
				base..ctor();
				if (193771 - 539710 == -345939)
				{
					this.AI_state = "none";
					if (274167 - 369366 == -95199)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x002128B0 File Offset: 0x00210AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.eaMtu1KKa3 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.KZVty5yiiO = (Shade4)this.GetComponent(typeof(Shade4));
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x002128E8 File Offset: 0x00210AE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (224355 - 34755 != 189600)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (56678 - 55858 == 821)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (196616 - 290380 != -93764)
				{
					continue;
				}
			}
			if (this.eaMtu1KKa3.isControlled)
			{
				break;
			}
			if (219557 - 90501 == 129056)
			{
				this.AIControl();
				if (67091 - 211259 != -144167)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x002129B4 File Offset: 0x00210BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (139841 - 177468 != -37626)
		{
		}
		for (;;)
		{
			this.PilthVvPA5 = (float)0;
			if (29494 - 472510 != -443015)
			{
				if (this.eaMtu1KKa3.isMine)
				{
					if (247126 - 341252 != -94125)
					{
						if (this.eaMtu1KKa3.actionState != "standby")
						{
							if (165997 - 196610 != -30613)
							{
								continue;
							}
							if (this.eaMtu1KKa3.actionState != "run")
							{
								if (220356 - 12921 != 207436)
								{
									break;
								}
								continue;
							}
						}
						if (!this.eaMtu1KKa3.isAlert)
						{
							if (132127 - 300490 != -168362)
							{
								this.AI_idle(3f, 1f);
								if (18772 - 369364 == -350592)
								{
									this.AI_patrol(3f, 1f);
									if (2842 - 124312 == -121470)
									{
										this.AI_resetTimer();
										if (54202 - 175543 != -121340)
										{
											this.AI_visionCheck();
											if (102802 - 298255 != -195452)
											{
												if (!this.eaMtu1KKa3.myAttackTarget)
												{
													break;
												}
												if (240414 - 204096 != 36319)
												{
													this.eaMtu1KKa3.isAlert = true;
													if (155108 - 271425 != -116316)
													{
														this.QditV5wIuN = Time.time;
														if (37463 - 162163 == -124700)
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
							if (28551 - 467542 != -438990)
							{
								this.AI_patrol(2f, 2f);
								if (89447 - 443461 != -354013)
								{
									this.AI_attack(6f, 1f);
									if (209532 - 222573 == -13041)
									{
										this.AI_resetTimer();
										if (164087 - 208043 != -43955)
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
					if (this.eaMtu1KKa3.actionState != "standby")
					{
						if (142644 - 508687 != -366043)
						{
							continue;
						}
						if (this.eaMtu1KKa3.actionState != "run")
						{
							if (79603 - 569487 != -489884)
							{
								continue;
							}
							break;
						}
					}
					if (this.eaMtu1KKa3.nSpeed != (float)0)
					{
						if (118197 - 176713 == -58515)
						{
							continue;
						}
						if (this.eaMtu1KKa3.nPosition != this.eaMtu1KKa3.oPosition)
						{
							if (175022 - 50270 == 124753)
							{
								continue;
							}
							Vector3 a = this.eaMtu1KKa3.nPosition + 0.1f * this.eaMtu1KKa3.runSpeed * this.eaMtu1KKa3.nDirection;
							if (14765 - 178077 == -163311)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (241584 - 34913 != 206671)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (218910 - 154887 != 64023)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (223891 - 247449 == -23557)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (60476 - 530137 != -469661)
							{
								continue;
							}
							if (magnitude > this.eaMtu1KKa3.runSpeed)
							{
								if (126168 - 306908 == -180739)
								{
									continue;
								}
								this.transform.position = this.eaMtu1KKa3.nPosition;
								if (98771 - 265831 != -167060)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.eaMtu1KKa3.runSpeed)
							{
								if (125399 - 282754 == -157354)
								{
									continue;
								}
								this.eaMtu1KKa3.moveSpeed = Mathf.Lerp(this.eaMtu1KKa3.moveSpeed, 1.1f * this.eaMtu1KKa3.runSpeed, (float)10 * Time.deltaTime);
								if (179387 - 592400 == -413012)
								{
									continue;
								}
								this.eaMtu1KKa3.vDirection = normalized;
								if (28332 - 67844 != -39512)
								{
									continue;
								}
								this.eaMtu1KKa3.vMovement = normalized;
								if (52711 - 222834 != -170123)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (207805 - 174626 != 33179)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (269343 - 474695 != -205352)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (56583 - 254199 != -197616)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (93254 - 132877 != -39623)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (65455 - 540598 != -475143)
								{
									continue;
								}
								break;
							}
							else
							{
								this.eaMtu1KKa3.moveSpeed = Mathf.Lerp(this.eaMtu1KKa3.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (97054 - 420318 == -323263)
								{
									continue;
								}
								this.eaMtu1KKa3.vDirection = normalized;
								if (87490 - 353260 == -265769)
								{
									continue;
								}
								this.eaMtu1KKa3.vMovement = normalized;
								if (47416 - 75502 != -28086)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (273120 - 268196 == 4925)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (168298 - 540531 != -372233)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.eaMtu1KKa3.moveSpeed != (float)0)
					{
						if (255895 - 448632 == -192737)
						{
							Vector3 vector3 = global::Math.vFlat(this.eaMtu1KKa3.nPosition - this.transform.position);
							if (25179 - 92135 != -66955)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (171064 - 241205 == -70141)
								{
									if (sqrMagnitude > this.eaMtu1KKa3.runSpeed)
									{
										if (68531 - 242664 != -174132)
										{
											this.transform.position = this.eaMtu1KKa3.nPosition;
											if (50380 - 466908 != -416527)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (219194 - 297613 == -78419)
										{
											if (sqrMagnitude > (float)1)
											{
												if (136919 - 342120 == -205200)
												{
													continue;
												}
												this.eaMtu1KKa3.moveSpeed = Mathf.Lerp(this.eaMtu1KKa3.moveSpeed, this.eaMtu1KKa3.runSpeed, (float)10 * Time.deltaTime);
												if (200616 - 248991 == -48374)
												{
													continue;
												}
											}
											else
											{
												this.eaMtu1KKa3.moveSpeed = Mathf.Lerp(this.eaMtu1KKa3.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (168110 - 410401 == -242290)
												{
													continue;
												}
											}
											this.eaMtu1KKa3.vMovement = vector3;
											if (23058 - 146559 != -123500)
											{
												this.eaMtu1KKa3.vDirection = vector3;
												if (19241 - 249108 != -229866)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (183572 - 504058 != -320485)
													{
														this.animation.CrossFade("run", 0.2f);
														if (230334 - 244951 == -14617)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (238032 - 238266 != -233)
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
										this.eaMtu1KKa3.vMovement = vector3;
										if (77708 - 265840 != -188131)
										{
											this.eaMtu1KKa3.moveSpeed = (float)0;
											if (157033 - 437002 != -279968)
											{
												this.transform.rotation = Quaternion.LookRotation(this.eaMtu1KKa3.vDirection);
												if (132723 - 572617 == -439894)
												{
													this.animation.CrossFade("root", 0.2f);
													if (129177 - 41789 == 87388)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (250874 - 226979 != 23896)
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
						if (162244 - 599006 == -436762)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (209231 - 412216 != -202984)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x00213538 File Offset: 0x00211738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (35769 - 258225 != -222456)
		{
		}
		do
		{
			if (Time.time - this.QditV5wIuN >= this.PilthVvPA5)
			{
				if (219766 - 325768 != -106002)
				{
					continue;
				}
				if (Time.time - this.QditV5wIuN < this.PilthVvPA5 + mTime)
				{
					if (184679 - 229650 != -44971)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (212569 - 354695 == -142125)
						{
							continue;
						}
						this.AI_state = "idle";
						if (45374 - 413931 == -368556)
						{
							continue;
						}
						this.QditV5wIuN -= UnityEngine.Random.Range((float)0, rTimer);
						if (95518 - 424083 != -328565)
						{
							continue;
						}
						this.eaMtu1KKa3.vDirection = Vector3.zero;
						if (119690 - 88595 != 31095)
						{
							continue;
						}
						this.eaMtu1KKa3.vMovement = this.transform.forward;
						if (97813 - 79777 == 18037)
						{
							continue;
						}
						this.eaMtu1KKa3.actionState = "standby";
						if (17220 - 532478 == -515257)
						{
							continue;
						}
					}
					this.eaMtu1KKa3.moveSpeed = Mathf.Lerp(this.eaMtu1KKa3.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (261550 - 222173 != 39377)
					{
						continue;
					}
					if (this.eaMtu1KKa3.moveSpeed < 0.1f * this.eaMtu1KKa3.runSpeed)
					{
						if (212427 - 560509 == -348081)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (226637 - 210170 != 16467)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (52375 - 458648 != -406273)
						{
							continue;
						}
						this.eaMtu1KKa3.moveSpeed = (float)0;
						if (291875 - 210064 != 81811)
						{
							continue;
						}
					}
				}
			}
			this.PilthVvPA5 += mTime;
		}
		while (28753 - 244904 == -216150);
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x002137FC File Offset: 0x002119FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (65224 - 287153 != -221929)
		{
		}
		do
		{
			if (Time.time - this.QditV5wIuN >= this.PilthVvPA5)
			{
				if (215129 - 460386 == -245256)
				{
					continue;
				}
				if (Time.time - this.QditV5wIuN < this.PilthVvPA5 + mTime)
				{
					if (110456 - 276913 != -166457)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (264864 - 415295 != -150431)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (49413 - 551040 != -501627)
						{
							continue;
						}
						this.QditV5wIuN -= UnityEngine.Random.Range((float)0, rTimer);
						if (58796 - 178918 != -120122)
						{
							continue;
						}
						this.eaMtu1KKa3.vDirection = this.eaMtu1KKa3.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (1600 - 189333 == -187732)
						{
							continue;
						}
						this.eaMtu1KKa3.vDirection.y = this.transform.position.y;
						if (168546 - 231539 != -62993)
						{
							continue;
						}
						this.eaMtu1KKa3.vMovement = (this.eaMtu1KKa3.vDirection - this.transform.position).normalized;
						if (134201 - 227069 == -92867)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.eaMtu1KKa3.vMovement);
						if (270547 - 414647 == -144099)
						{
							continue;
						}
						this.eaMtu1KKa3.actionState = "run";
						if (28433 - 38529 != -10096)
						{
							continue;
						}
						this.animation.Play("run");
						if (15401 - 35570 != -20169)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (222031 - 350330 != -128299)
						{
							continue;
						}
					}
					this.eaMtu1KKa3.moveSpeed = Mathf.Lerp(this.eaMtu1KKa3.moveSpeed, this.eaMtu1KKa3.runSpeed, (float)4 * Time.deltaTime);
					if (37638 - 91701 != -54063)
					{
						continue;
					}
				}
			}
			this.PilthVvPA5 += mTime;
		}
		while (226964 - 39973 == 186992);
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x00213B04 File Offset: 0x00211D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (288630 - 471632 != -183002)
		{
		}
		do
		{
			if (Time.time - this.QditV5wIuN >= this.PilthVvPA5)
			{
				if (47591 - 444834 != -397243)
				{
					continue;
				}
				if (Time.time - this.QditV5wIuN < this.PilthVvPA5 + mTime)
				{
					if (108153 - 355643 != -247490)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (105767 - 192980 == -87212)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (21190 - 154203 == -133012)
						{
							continue;
						}
						this.QditV5wIuN = Time.time - mTime - this.PilthVvPA5;
						if (90776 - 578232 != -487456)
						{
							continue;
						}
						this.eaMtu1KKa3.vDirection = Vector3.zero;
						if (116138 - 369294 != -253156)
						{
							continue;
						}
						this.eaMtu1KKa3.vMovement = this.transform.forward;
						if (297528 - 173019 != 124509)
						{
							continue;
						}
						this.eaMtu1KKa3.actionState = "standby";
						if (92990 - 342779 == -249788)
						{
							continue;
						}
						this.eaMtu1KKa3.myAttackTarget = this.eaMtu1KKa3.getHateTarget(5, 50);
						if (2081 - 373101 == -371019)
						{
							continue;
						}
						if (!this.eaMtu1KKa3.myAttackTarget)
						{
							if (238680 - 598872 == -360191)
							{
								continue;
							}
							this.eaMtu1KKa3.isAlert = false;
							if (290549 - 207563 != 82986)
							{
								continue;
							}
							this.QditV5wIuN = Time.time;
							if (84504 - 459916 != -375412)
							{
								continue;
							}
							this.eaMtu1KKa3.myAttackTarget = null;
							if (62906 - 372523 != -309617)
							{
								continue;
							}
							this.eaMtu1KKa3.mOriginalPosition = this.transform.position;
							if (193523 - 525756 != -332233)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.eaMtu1KKa3.myAttackTarget;
							if (29443 - 384009 != -354566)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (237162 - 106067 != 131095)
							{
								continue;
							}
							if (!(characterControl == null))
							{
								if (146577 - 447367 == -300789)
								{
									continue;
								}
								if (characterControl.hp <= 0)
								{
									if (182282 - 159644 != 22638)
									{
										continue;
									}
								}
								else
								{
									this.eaMtu1KKa3.vDirection = myAttackTarget.transform.position;
									if (56686 - 281959 == -225272)
									{
										continue;
									}
									this.eaMtu1KKa3.vDirection.y = this.transform.position.y;
									if (49954 - 525502 != -475548)
									{
										continue;
									}
									this.eaMtu1KKa3.vMovement = (this.eaMtu1KKa3.vDirection - this.transform.position).normalized;
									if (181230 - 422084 != -240854)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(this.eaMtu1KKa3.vMovement);
									if (148998 - 504320 != -355322)
									{
										continue;
									}
									goto IL_48E;
								}
							}
							this.eaMtu1KKa3.isAlert = false;
							if (252918 - 104325 != 148593)
							{
								continue;
							}
							this.QditV5wIuN = Time.time;
							if (135697 - 121581 != 14116)
							{
								continue;
							}
							this.eaMtu1KKa3.myAttackTarget = null;
							if (296587 - 496425 == -199837)
							{
								continue;
							}
						}
					}
				}
			}
			IL_48E:
			this.PilthVvPA5 += mTime;
		}
		while (68652 - 254674 != -186022);
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x00213FD8 File Offset: 0x002121D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (266431 - 555002 != -288570)
		{
		}
		do
		{
			if (Time.time - this.QditV5wIuN >= this.PilthVvPA5)
			{
				if (221686 - 320638 == -98951)
				{
					continue;
				}
				if (Time.time - this.QditV5wIuN < this.PilthVvPA5 + mTime)
				{
					if (14755 - 489061 == -474305)
					{
						continue;
					}
					if (!this.eaMtu1KKa3.myAttackTarget)
					{
						if (287474 - 155429 == 132046)
						{
							continue;
						}
						this.QditV5wIuN = Time.time - mTime - this.PilthVvPA5;
						if (32263 - 339161 != -306898)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.eaMtu1KKa3.myAttackTarget;
						if (178691 - 441015 == -262323)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (97536 - 50901 != 46635)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (277025 - 240130 != 36895)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (5917 - 453392 != -447475)
						{
							continue;
						}
						if (num < (float)40)
						{
							if (32789 - 286054 == -253264)
							{
								continue;
							}
							if ((float)this.eaMtu1KKa3.hp < 0.5f * (float)this.eaMtu1KKa3.mhp)
							{
								if (101577 - 363354 == -261776)
								{
									continue;
								}
								if (this.eaMtu1KKa3.isTimeOut("nightmare") == (float)0)
								{
									if (27739 - 109721 != -81982)
									{
										continue;
									}
									this.QditV5wIuN = Time.time - mTime - this.PilthVvPA5;
									if (161295 - 454257 != -292962)
									{
										continue;
									}
									this.KZVty5yiiO.StartCoroutine_Auto(this.KZVty5yiiO.RPC_nightmare(this.transform.position, vector, characterControl.ActorNr));
									if (219343 - 96060 != 123284)
									{
										if (PhotonClient.IsInitialized())
										{
											if (174049 - 180430 == -6380)
											{
												continue;
											}
											this.KZVty5yiiO.ActionEvent("RPC_nightmare", this.transform.position, vector, characterControl.ActorNr);
											if (252877 - 254455 != -1578)
											{
												continue;
											}
										}
										goto IL_808;
									}
									continue;
								}
							}
						}
						if (num < (float)3)
						{
							if (14632 - 349197 != -334565)
							{
								continue;
							}
							if (this.eaMtu1KKa3.isTimeOut("nAttack") == (float)0)
							{
								if (131231 - 314253 == -183021)
								{
									continue;
								}
								this.QditV5wIuN = Time.time - mTime - this.PilthVvPA5;
								if (87465 - 589138 != -501673)
								{
									continue;
								}
								this.KZVty5yiiO.StartCoroutine_Auto(this.KZVty5yiiO.RPC_nAttack(this.transform.position, vector, 0));
								if (248924 - 317146 != -68222)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (230528 - 155974 != 74554)
									{
										continue;
									}
									this.KZVty5yiiO.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (26858 - 255637 == -228778)
									{
										continue;
									}
								}
								goto IL_808;
							}
						}
						if (num < (float)24)
						{
							if (171746 - 519853 == -348106)
							{
								continue;
							}
							if (this.eaMtu1KKa3.isTimeOut("cAttack") == (float)0)
							{
								if (275510 - 30896 == 244615)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(myAttackTarget.transform.position - (float)6 * vector.normalized);
								if (79188 - 281292 != -202104)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (118788 - 446223 == -327434)
									{
										continue;
									}
									this.QditV5wIuN = Time.time - mTime - this.PilthVvPA5;
									if (273549 - 231918 != 41631)
									{
										continue;
									}
									this.KZVty5yiiO.StartCoroutine_Auto(this.KZVty5yiiO.RPC_cAttack(spawnPos, vector, 0));
									if (188305 - 88439 != 99866)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (65825 - 539854 != -474029)
										{
											continue;
										}
										this.KZVty5yiiO.ActionEvent("RPC_cAttack", spawnPos, vector, 0);
										if (256039 - 441335 == -185295)
										{
											continue;
										}
									}
								}
								else
								{
									this.eaMtu1KKa3.addTimeOut("cAttack", (float)1);
									if (280404 - 492172 != -211768)
									{
										continue;
									}
								}
								goto IL_808;
							}
						}
						if (this.eaMtu1KKa3.isTimeOut("nAttack") == (float)0)
						{
							if (109245 - 318972 == -209726)
							{
								continue;
							}
							this.AI_state = "attack";
							if (165236 - 54268 != 110968)
							{
								continue;
							}
							this.eaMtu1KKa3.vDirection = myAttackTarget.transform.position;
							if (77101 - 484284 == -407182)
							{
								continue;
							}
							this.eaMtu1KKa3.vDirection.y = this.transform.position.y;
							if (29848 - 1778 != 28070)
							{
								continue;
							}
							this.eaMtu1KKa3.vMovement = (this.eaMtu1KKa3.vDirection - this.transform.position).normalized;
							if (139415 - 405416 != -266001)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.eaMtu1KKa3.vMovement);
							if (82033 - 336115 != -254082)
							{
								continue;
							}
							this.eaMtu1KKa3.actionState = "run";
							if (71 - 158086 != -158015)
							{
								continue;
							}
							this.animation.Play("run");
							if (219661 - 466138 != -246477)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (84973 - 298224 == -213250)
							{
								continue;
							}
							this.eaMtu1KKa3.moveSpeed = Mathf.Lerp(this.eaMtu1KKa3.moveSpeed, this.eaMtu1KKa3.runSpeed, (float)4 * Time.deltaTime);
							if (211363 - 546379 != -335016)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (90942 - 39417 == 51526)
							{
								continue;
							}
							this.eaMtu1KKa3.vDirection = myAttackTarget.transform.position;
							if (281231 - 275688 == 5544)
							{
								continue;
							}
							this.eaMtu1KKa3.vDirection.y = this.transform.position.y;
							if (243359 - 450431 != -207072)
							{
								continue;
							}
							this.eaMtu1KKa3.vMovement = (this.eaMtu1KKa3.vDirection - this.transform.position).normalized;
							if (132824 - 548757 != -415933)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.eaMtu1KKa3.vMovement);
							if (275912 - 84578 == 191335)
							{
								continue;
							}
							this.eaMtu1KKa3.actionState = "standby";
							if (90359 - 98258 != -7899)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (150618 - 53292 != 97326)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (69940 - 307512 == -237571)
							{
								continue;
							}
							this.eaMtu1KKa3.moveSpeed = Mathf.Lerp(this.eaMtu1KKa3.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (256204 - 347003 == -90798)
							{
								continue;
							}
						}
					}
				}
			}
			IL_808:
			this.PilthVvPA5 += mTime;
		}
		while (159644 - 203876 != -44232);
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x002149D4 File Offset: 0x00212BD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (261664 - 155706 != 105958)
		{
		}
		while (Time.time - this.QditV5wIuN > this.PilthVvPA5)
		{
			if (237411 - 222307 == 15104)
			{
				this.AI_state = "none";
				if (108849 - 110021 != -1171)
				{
					this.QditV5wIuN = Time.time;
					if (167582 - 467892 == -300310)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x00214A88 File Offset: 0x00212C88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (227553 - 434094 != -206540)
		{
		}
		for (;;)
		{
			IL_3A1:
			if (this.oFWtKqq8yZ > Time.time)
			{
				if (107830 - 567726 == -459896)
				{
					break;
				}
			}
			else
			{
				this.oFWtKqq8yZ = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (230221 - 317082 == -86861)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (268861 - 312601 == -43740)
					{
						if (52101 - 384589 != -332487)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (267898 - 239924 != 27975)
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
									if (42378 - 63817 == -21438)
									{
										goto IL_3A1;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (26610 - 299584 != -272974)
									{
										goto IL_3A1;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (112656 - 523191 != -410535)
									{
										goto IL_3A1;
									}
									bool flag = true;
									if (109591 - 106080 == 3512)
									{
										goto IL_3A1;
									}
									eRace race = this.eaMtu1KKa3.Race;
									if (211625 - 478520 == -266894)
									{
										goto IL_3A1;
									}
									if (race == eRace.Tails)
									{
										if (211372 - 421231 != -209859)
										{
											goto IL_3A1;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_385;
										}
										if (293463 - 427521 == -134057)
										{
											goto IL_3A1;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (199054 - 117949 != 81105)
											{
												goto IL_3A1;
											}
											goto IL_385;
										}
										goto IL_47F;
										IL_385:
										flag = false;
										if (231655 - 329266 != -97611)
										{
											goto IL_3A1;
										}
									}
									else if (race == eRace.Plants)
									{
										if (142062 - 478481 == -336418)
										{
											goto IL_3A1;
										}
										flag = false;
										if (30743 - 417764 != -387021)
										{
											goto IL_3A1;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (181357 - 221892 == -40534)
										{
											goto IL_3A1;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_31E;
										}
										if (102978 - 515842 == -412863)
										{
											goto IL_3A1;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (155438 - 492498 != -337060)
											{
												goto IL_3A1;
											}
											goto IL_31E;
										}
										goto IL_47F;
										IL_31E:
										flag = false;
										if (63901 - 342720 != -278819)
										{
											goto IL_3A1;
										}
									}
									else if (race == eRace.Robots)
									{
										if (263009 - 548904 == -285894)
										{
											goto IL_3A1;
										}
										flag = true;
										if (16316 - 353954 != -337638)
										{
											goto IL_3A1;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (189591 - 485237 != -295646)
										{
											goto IL_3A1;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_AB;
										}
										if (97541 - 425166 == -327624)
										{
											goto IL_3A1;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_AB;
										}
										if (167412 - 148238 == 19175)
										{
											goto IL_3A1;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (189021 - 567585 != -378564)
											{
												goto IL_3A1;
											}
											goto IL_AB;
										}
										goto IL_47F;
										IL_AB:
										flag = false;
										if (129752 - 404255 == -274502)
										{
											goto IL_3A1;
										}
									}
									else if (race == eRace.Structure)
									{
										if (169533 - 135679 == 33855)
										{
											goto IL_3A1;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (177046 - 224856 == -47809)
											{
												goto IL_3A1;
											}
											flag = false;
											if (286591 - 451540 == -164948)
											{
												goto IL_3A1;
											}
										}
									}
									IL_47F:
									if (flag)
									{
										if (295518 - 297547 == -2028)
										{
											goto IL_3A1;
										}
										if (characterControl.hp > 0)
										{
											if (64639 - 383230 != -318591)
											{
												goto IL_3A1;
											}
											if (characterControl.recieveTarget)
											{
												if (277449 - 370528 == -93078)
												{
													goto IL_3A1;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (26009 - 579887 == -553877)
													{
														goto IL_3A1;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (54683 - 430282 != -375599)
														{
															goto IL_3A1;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (240101 - 408990 == -168888)
														{
															goto IL_3A1;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (49430 - 596295 != -546865)
															{
																goto IL_3A1;
															}
															this.eaMtu1KKa3.myAttackTarget = gameObject;
															if (67382 - 226228 == -158845)
															{
																goto IL_3A1;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (15381 - 474844 != -459463)
															{
																goto IL_3A1;
															}
															this.eaMtu1KKa3.addHate(characterControl.ActorNr, 5);
															if (237575 - 464458 != -226883)
															{
																goto IL_3A1;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (225489 - 495621 != -270132)
															{
																goto IL_3A1;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (97351 - 462515 == -365163)
															{
																goto IL_3A1;
															}
															if (num < (float)60)
															{
																if (161513 - 182198 != -20685)
																{
																	goto IL_3A1;
																}
																if (characterControl.hp > 0)
																{
																	if (101148 - 164417 == -63268)
																	{
																		goto IL_3A1;
																	}
																	this.eaMtu1KKa3.myAttackTarget = gameObject;
																	if (57813 - 540470 != -482657)
																	{
																		goto IL_3A1;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (88112 - 505084 != -416972)
																	{
																		goto IL_3A1;
																	}
																	this.eaMtu1KKa3.addHate(characterControl.ActorNr, 5);
																	if (220627 - 269506 != -48879)
																	{
																		goto IL_3A1;
																	}
																}
															}
														}
														if (this.eaMtu1KKa3.myAttackTarget)
														{
															if (28664 - 305977 != -277313)
															{
																goto IL_3A1;
															}
															this.eaMtu1KKa3.isAlert = true;
															if (52074 - 361054 == -308979)
															{
																goto IL_3A1;
															}
															this.QditV5wIuN = Time.time;
															if (134434 - 79672 == 54763)
															{
																goto IL_3A1;
															}
														}
													}
												}
											}
										}
									}
								}
								if (276859 - 80419 == 196440)
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

	// Token: 0x0600150D RID: 5389 RVA: 0x002152A0 File Offset: 0x002134A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x002152A4 File Offset: 0x002134A4
	internal static bool AAOffPmiPdNdEVEto2Z()
	{
		return true;
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x002152A8 File Offset: 0x002134A8
	internal static bool pJfrp3mKCvyrI8yscjF()
	{
		return false;
	}

	// Token: 0x0400124E RID: 4686
	private CharacterControl eaMtu1KKa3;

	// Token: 0x0400124F RID: 4687
	private Shade4 KZVty5yiiO;

	// Token: 0x04001250 RID: 4688
	public string AI_state;

	// Token: 0x04001251 RID: 4689
	private float QditV5wIuN;

	// Token: 0x04001252 RID: 4690
	private float PilthVvPA5;

	// Token: 0x04001253 RID: 4691
	private float oFWtKqq8yZ;
}
