using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000CF RID: 207
[Serializable]
public class LeoBug_AI : MonoBehaviour
{
	// Token: 0x06000473 RID: 1139 RVA: 0x000728E0 File Offset: 0x00070AE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeoBug_AI()
	{
		if (91972 - 180370 != -88397)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (171847 - 3951 != 167897)
			{
				base..ctor();
				if (142692 - 480107 == -337415)
				{
					this.AI_state = "none";
					if (123654 - 29426 == 94228)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x0007297C File Offset: 0x00070B7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.saRcNEI4tc = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.l4OcEZOvH8 = (LeoBug)this.GetComponent(typeof(LeoBug));
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x000729B4 File Offset: 0x00070BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (186735 - 29400 != 157335)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (68004 - 254494 == -186489)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (134206 - 277125 == -142918)
				{
					continue;
				}
			}
			if (this.saRcNEI4tc.isControlled)
			{
				break;
			}
			if (263562 - 443686 == -180124)
			{
				this.AIControl();
				if (108601 - 593484 != -484882)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x00072A80 File Offset: 0x00070C80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (196369 - 500991 != -304621)
		{
		}
		for (;;)
		{
			this.mgocSJmPKm = (float)0;
			if (69711 - 51906 != 17806)
			{
				if (this.saRcNEI4tc.isMine)
				{
					if (137585 - 399492 == -261907)
					{
						if (this.saRcNEI4tc.actionState != "standby")
						{
							if (103576 - 43662 != 59914)
							{
								continue;
							}
							if (this.saRcNEI4tc.actionState != "run")
							{
								if (237274 - 317327 != -80052)
								{
									break;
								}
								continue;
							}
						}
						if (!this.saRcNEI4tc.isAlert)
						{
							if (93884 - 190482 == -96598)
							{
								this.AI_idle(3f, 1f);
								if (283819 - 170374 == 113445)
								{
									this.AI_patrol(1f, 0.25f);
									if (58120 - 173381 != -115260)
									{
										this.AI_resetTimer();
										if (37565 - 497956 == -460391)
										{
											this.AI_visionCheck();
											if (189929 - 562639 != -372709)
											{
												if (!this.saRcNEI4tc.myAttackTarget)
												{
													break;
												}
												if (288991 - 452221 == -163230)
												{
													this.saRcNEI4tc.isAlert = true;
													if (266448 - 481437 != -214988)
													{
														this.Hj3cPHZldC = Time.time;
														if (287649 - 537913 == -250264)
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
							if (295972 - 391825 != -95852)
							{
								this.AI_idle(2f, 1f);
								if (174894 - 546215 != -371320)
								{
									this.AI_attack(10f, (float)0);
									if (170684 - 579690 != -409005)
									{
										this.AI_resetTimer();
										if (103529 - 591376 != -487846)
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
					if (this.saRcNEI4tc.actionState != "standby")
					{
						if (255715 - 154018 != 101697)
						{
							continue;
						}
						if (this.saRcNEI4tc.actionState != "run")
						{
							if (258754 - 395801 != -137046)
							{
								break;
							}
							continue;
						}
					}
					if (this.saRcNEI4tc.nSpeed != (float)0)
					{
						if (93266 - 596364 == -503097)
						{
							continue;
						}
						if (this.saRcNEI4tc.nPosition != this.saRcNEI4tc.oPosition)
						{
							if (220131 - 167339 == 52793)
							{
								continue;
							}
							Vector3 a = this.saRcNEI4tc.nPosition + 0.1f * this.saRcNEI4tc.runSpeed * this.saRcNEI4tc.nDirection;
							if (169628 - 561209 == -391580)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (46332 - 173418 != -127086)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (132649 - 68898 == 63752)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (128204 - 346590 != -218386)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (244579 - 325332 != -80753)
							{
								continue;
							}
							if (magnitude > this.saRcNEI4tc.runSpeed)
							{
								if (83425 - 147593 == -64167)
								{
									continue;
								}
								this.transform.position = this.saRcNEI4tc.nPosition;
								if (90478 - 333912 != -243434)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.saRcNEI4tc.runSpeed)
							{
								if (91546 - 396962 == -305415)
								{
									continue;
								}
								this.saRcNEI4tc.moveSpeed = Mathf.Lerp(this.saRcNEI4tc.moveSpeed, 1.1f * this.saRcNEI4tc.runSpeed, (float)10 * Time.deltaTime);
								if (225095 - 288078 != -62983)
								{
									continue;
								}
								this.saRcNEI4tc.vDirection = normalized;
								if (61830 - 194569 == -132738)
								{
									continue;
								}
								this.saRcNEI4tc.vMovement = normalized;
								if (247641 - 597919 == -350277)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (184610 - 521073 != -336463)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (141489 - 375544 != -234055)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (291434 - 242841 != 48593)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (151586 - 593892 == -442305)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (148714 - 100771 != 47944)
								{
									break;
								}
								continue;
							}
							else
							{
								this.saRcNEI4tc.moveSpeed = Mathf.Lerp(this.saRcNEI4tc.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (175278 - 492992 != -317714)
								{
									continue;
								}
								this.saRcNEI4tc.vDirection = normalized;
								if (26115 - 44914 == -18798)
								{
									continue;
								}
								this.saRcNEI4tc.vMovement = normalized;
								if (255380 - 322211 == -66830)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (176758 - 102202 != 74556)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (292787 - 455930 != -163142)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.saRcNEI4tc.moveSpeed != (float)0)
					{
						if (29416 - 80017 != -50600)
						{
							Vector3 vector3 = global::Math.vFlat(this.saRcNEI4tc.nPosition - this.transform.position);
							if (227863 - 24121 == 203742)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (281938 - 433721 != -151782)
								{
									if (sqrMagnitude > this.saRcNEI4tc.runSpeed)
									{
										if (194195 - 540529 == -346334)
										{
											this.transform.position = this.saRcNEI4tc.nPosition;
											if (255105 - 469878 != -214772)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (257979 - 303337 != -45357)
										{
											if (sqrMagnitude > (float)1)
											{
												if (71762 - 454773 != -383011)
												{
													continue;
												}
												this.saRcNEI4tc.moveSpeed = Mathf.Lerp(this.saRcNEI4tc.moveSpeed, this.saRcNEI4tc.runSpeed, (float)10 * Time.deltaTime);
												if (261778 - 14698 == 247081)
												{
													continue;
												}
											}
											else
											{
												this.saRcNEI4tc.moveSpeed = Mathf.Lerp(this.saRcNEI4tc.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (112800 - 403552 != -290752)
												{
													continue;
												}
											}
											this.saRcNEI4tc.vMovement = vector3;
											if (43828 - 171521 == -127693)
											{
												this.saRcNEI4tc.vDirection = vector3;
												if (59274 - 85749 == -26475)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (243456 - 207397 != 36060)
													{
														this.animation.CrossFade("run", 0.2f);
														if (99108 - 237830 == -138722)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (233896 - 18543 == 215353)
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
										this.saRcNEI4tc.vMovement = vector3;
										if (278198 - 342041 == -63843)
										{
											this.saRcNEI4tc.moveSpeed = (float)0;
											if (273041 - 108443 == 164598)
											{
												this.transform.rotation = Quaternion.LookRotation(this.saRcNEI4tc.vDirection);
												if (9199 - 63011 != -53811)
												{
													this.animation.CrossFade("root", 0.2f);
													if (74653 - 574512 != -499858)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (262162 - 157601 == 104561)
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
						if (118782 - 22845 == 95937)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (100139 - 494092 == -393953)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00073600 File Offset: 0x00071800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (165080 - 583564 != -418483)
		{
		}
		do
		{
			if (Time.time - this.Hj3cPHZldC >= this.mgocSJmPKm)
			{
				if (233971 - 433055 != -199084)
				{
					continue;
				}
				if (Time.time - this.Hj3cPHZldC < this.mgocSJmPKm + mTime)
				{
					if (17495 - 580200 != -562705)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (3208 - 233791 == -230582)
						{
							continue;
						}
						this.AI_state = "idle";
						if (210929 - 204901 != 6028)
						{
							continue;
						}
						this.Hj3cPHZldC -= UnityEngine.Random.Range((float)0, rTimer);
						if (90124 - 33992 == 56133)
						{
							continue;
						}
						this.saRcNEI4tc.vDirection = Vector3.zero;
						if (154716 - 577551 == -422834)
						{
							continue;
						}
						this.saRcNEI4tc.vMovement = this.transform.forward;
						if (170518 - 92227 != 78291)
						{
							continue;
						}
						this.saRcNEI4tc.actionState = "standby";
						if (109487 - 521955 != -412468)
						{
							continue;
						}
					}
					this.saRcNEI4tc.moveSpeed = Mathf.Lerp(this.saRcNEI4tc.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (138514 - 161625 == -23110)
					{
						continue;
					}
					if (this.saRcNEI4tc.moveSpeed < 0.1f * this.saRcNEI4tc.runSpeed)
					{
						if (63437 - 507817 == -444379)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (162852 - 403864 == -241011)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (120903 - 187531 == -66627)
						{
							continue;
						}
						this.saRcNEI4tc.moveSpeed = (float)0;
						if (101438 - 254023 == -152584)
						{
							continue;
						}
					}
				}
			}
			this.mgocSJmPKm += mTime;
		}
		while (273843 - 457392 == -183548);
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x000738C4 File Offset: 0x00071AC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (240305 - 595523 != -355218)
		{
		}
		do
		{
			if (Time.time - this.Hj3cPHZldC >= this.mgocSJmPKm)
			{
				if (104139 - 547169 != -443030)
				{
					continue;
				}
				if (Time.time - this.Hj3cPHZldC < this.mgocSJmPKm + mTime)
				{
					if (217197 - 31278 != 185919)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (252045 - 495490 == -243444)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (24629 - 230251 == -205621)
						{
							continue;
						}
						this.Hj3cPHZldC -= UnityEngine.Random.Range((float)0, rTimer);
						if (86444 - 298720 != -212276)
						{
							continue;
						}
						this.saRcNEI4tc.vDirection = this.saRcNEI4tc.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (143313 - 46261 != 97052)
						{
							continue;
						}
						this.saRcNEI4tc.vDirection.y = this.transform.position.y;
						if (155303 - 384926 != -229623)
						{
							continue;
						}
						this.saRcNEI4tc.vMovement = (this.saRcNEI4tc.vDirection - this.transform.position).normalized;
						if (76382 - 562616 == -486233)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.saRcNEI4tc.vMovement);
						if (83450 - 247284 != -163834)
						{
							continue;
						}
						this.saRcNEI4tc.actionState = "run";
						if (133591 - 360207 != -226616)
						{
							continue;
						}
						this.animation.CrossFade("run", 0.2f);
						if (203301 - 77628 != 125673)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (262262 - 405566 == -143303)
						{
							continue;
						}
					}
					this.saRcNEI4tc.moveSpeed = Mathf.Lerp(this.saRcNEI4tc.moveSpeed, this.saRcNEI4tc.runSpeed, (float)4 * Time.deltaTime);
					if (187323 - 76339 == 110985)
					{
						continue;
					}
				}
			}
			this.mgocSJmPKm += mTime;
		}
		while (39167 - 274774 != -235607);
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00073BD0 File Offset: 0x00071DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (228629 - 581991 != -353362)
		{
		}
		do
		{
			if (Time.time - this.Hj3cPHZldC >= this.mgocSJmPKm)
			{
				if (57437 - 122258 != -64821)
				{
					continue;
				}
				if (Time.time - this.Hj3cPHZldC < this.mgocSJmPKm + mTime)
				{
					if (267643 - 484619 == -216975)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (36180 - 540411 != -504231)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (279068 - 29486 == 249583)
						{
							continue;
						}
						this.Hj3cPHZldC = Time.time - mTime - this.mgocSJmPKm;
						if (97956 - 392793 == -294836)
						{
							continue;
						}
						this.saRcNEI4tc.vDirection = Vector3.zero;
						if (202051 - 172781 == 29271)
						{
							continue;
						}
						this.saRcNEI4tc.vMovement = this.transform.forward;
						if (209483 - 175114 == 34370)
						{
							continue;
						}
						this.saRcNEI4tc.actionState = "standby";
						if (131494 - 490416 != -358922)
						{
							continue;
						}
						this.saRcNEI4tc.myAttackTarget = this.saRcNEI4tc.getHateTarget(5, 50);
						if (41687 - 596190 == -554502)
						{
							continue;
						}
						if (!this.saRcNEI4tc.myAttackTarget)
						{
							if (299590 - 170689 != 128901)
							{
								continue;
							}
							this.saRcNEI4tc.isAlert = false;
							if (292055 - 119674 == 172382)
							{
								continue;
							}
							this.Hj3cPHZldC = Time.time;
							if (50472 - 41068 != 9404)
							{
								continue;
							}
							this.saRcNEI4tc.myAttackTarget = null;
							if (201367 - 34757 == 166611)
							{
								continue;
							}
							this.saRcNEI4tc.mOriginalPosition = this.transform.position;
							if (264518 - 526281 != -261762)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.saRcNEI4tc.myAttackTarget;
							if (268814 - 457212 == -188397)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (92940 - 413152 == -320211)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (121222 - 191996 != -70774)
								{
									continue;
								}
								this.saRcNEI4tc.isAlert = false;
								if (142537 - 348763 != -206226)
								{
									continue;
								}
								this.Hj3cPHZldC = Time.time;
								if (32878 - 251614 != -218736)
								{
									continue;
								}
								this.saRcNEI4tc.myAttackTarget = null;
								if (296353 - 342937 != -46584)
								{
									continue;
								}
							}
							else
							{
								this.saRcNEI4tc.vDirection = myAttackTarget.transform.position;
								if (293865 - 66358 == 227508)
								{
									continue;
								}
								this.saRcNEI4tc.vDirection.y = this.transform.position.y;
								if (21083 - 572177 == -551093)
								{
									continue;
								}
								this.saRcNEI4tc.vMovement = (this.saRcNEI4tc.vDirection - this.transform.position).normalized;
								if (103733 - 389611 == -285877)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.saRcNEI4tc.vMovement);
								if (155855 - 590248 == -434392)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.mgocSJmPKm += mTime;
		}
		while (95146 - 105129 != -9983);
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00074080 File Offset: 0x00072280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (25132 - 130674 != -105542)
		{
		}
		do
		{
			if (Time.time - this.Hj3cPHZldC >= this.mgocSJmPKm)
			{
				if (242852 - 170915 == 71938)
				{
					continue;
				}
				if (Time.time - this.Hj3cPHZldC < this.mgocSJmPKm + mTime)
				{
					if (211378 - 388972 == -177593)
					{
						continue;
					}
					if (!this.saRcNEI4tc.myAttackTarget)
					{
						if (230292 - 269227 != -38935)
						{
							continue;
						}
						this.Hj3cPHZldC = Time.time - mTime - this.mgocSJmPKm;
						if (260518 - 140540 != 119979)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.saRcNEI4tc.myAttackTarget;
						if (272242 - 185449 != 86793)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (182643 - 567515 != -384872)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (156400 - 465455 == -309054)
						{
							continue;
						}
						if (num > (float)3)
						{
							if (135287 - 159777 == -24489)
							{
								continue;
							}
							if (num < (float)24)
							{
								if (279699 - 31859 == 247841)
								{
									continue;
								}
								if (this.saRcNEI4tc.isTimeOut("leoBeam") == (float)0)
								{
									if (192728 - 79140 == 113589)
									{
										continue;
									}
									if (this.saRcNEI4tc.sp >= 40)
									{
										if (47189 - 144286 != -97097)
										{
											continue;
										}
										if (this.saRcNEI4tc.Type != "LeoBug_f")
										{
											if (15437 - 1666 == 13772)
											{
												continue;
											}
											this.Hj3cPHZldC = Time.time - mTime - this.mgocSJmPKm;
											if (26726 - 283765 == -257038)
											{
												continue;
											}
											this.l4OcEZOvH8.StartCoroutine_Auto(this.l4OcEZOvH8.RPC_leoBeam(this.transform.position, vector, 0));
											if (60410 - 202577 != -142167)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (136345 - 79522 != 56823)
												{
													continue;
												}
												this.l4OcEZOvH8.ActionEvent("RPC_leoBeam", this.transform.position, vector, 0);
												if (267565 - 206768 == 60798)
												{
													continue;
												}
											}
											goto IL_23B;
										}
									}
								}
							}
						}
						if (num < (float)18)
						{
							if (106043 - 102961 == 3083)
							{
								continue;
							}
							if (this.saRcNEI4tc.isTimeOut("primalRoar") == (float)0)
							{
								if (236321 - 296120 != -59799)
								{
									continue;
								}
								this.Hj3cPHZldC = Time.time - mTime - this.mgocSJmPKm;
								if (264990 - 232945 == 32046)
								{
									continue;
								}
								this.l4OcEZOvH8.StartCoroutine_Auto(this.l4OcEZOvH8.RPC_primalRoar(this.transform.position, vector, 0));
								if (241605 - 104477 != 137128)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (298642 - 255582 == 43061)
									{
										continue;
									}
									this.l4OcEZOvH8.ActionEvent("RPC_primalRoar", this.transform.position, vector, 0);
									if (218180 - 582837 != -364657)
									{
										continue;
									}
								}
								goto IL_23B;
							}
						}
						if (num < (float)2)
						{
							if (131664 - 440375 != -308711)
							{
								continue;
							}
							if (this.saRcNEI4tc.isTimeOut("nAttack") == (float)0)
							{
								if (184437 - 135403 == 49035)
								{
									continue;
								}
								this.Hj3cPHZldC = Time.time - mTime - this.mgocSJmPKm;
								if (161433 - 8284 != 153149)
								{
									continue;
								}
								this.l4OcEZOvH8.StartCoroutine_Auto(this.l4OcEZOvH8.RPC_nAttack(this.transform.position, vector, 0));
								if (164231 - 20691 != 143541)
								{
									if (PhotonClient.IsInitialized())
									{
										if (112773 - 473966 == -361192)
										{
											continue;
										}
										this.l4OcEZOvH8.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (273177 - 202363 == 70815)
										{
											continue;
										}
									}
									goto IL_23B;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (259055 - 491315 == -232259)
						{
							continue;
						}
						this.saRcNEI4tc.vDirection = myAttackTarget.transform.position;
						if (5788 - 385092 == -379303)
						{
							continue;
						}
						this.saRcNEI4tc.vDirection.y = this.transform.position.y;
						if (34109 - 368226 == -334116)
						{
							continue;
						}
						this.saRcNEI4tc.vMovement = (this.saRcNEI4tc.vDirection - this.transform.position).normalized;
						if (262096 - 57879 == 204218)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.saRcNEI4tc.vMovement);
						if (276966 - 29261 == 247706)
						{
							continue;
						}
						this.saRcNEI4tc.actionState = "run";
						if (160097 - 392817 != -232720)
						{
							continue;
						}
						this.animation.CrossFade("run", 0.2f);
						if (235091 - 409185 == -174093)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (28317 - 117875 != -89558)
						{
							continue;
						}
						this.saRcNEI4tc.moveSpeed = Mathf.Lerp(this.saRcNEI4tc.moveSpeed, this.saRcNEI4tc.runSpeed, (float)4 * Time.deltaTime);
						if (10865 - 154247 == -143381)
						{
							continue;
						}
					}
				}
			}
			IL_23B:
			this.mgocSJmPKm += mTime;
		}
		while (137554 - 189294 == -51739);
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x000747FC File Offset: 0x000729FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (37122 - 472270 != -435148)
		{
		}
		while (Time.time - this.Hj3cPHZldC > this.mgocSJmPKm)
		{
			if (268118 - 354662 != -86543)
			{
				this.AI_state = "none";
				if (90866 - 570852 != -479985)
				{
					this.Hj3cPHZldC = Time.time;
					if (119430 - 282591 == -163161)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x000748B0 File Offset: 0x00072AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (85337 - 265518 != -180181)
		{
		}
		for (;;)
		{
			IL_44C:
			if (this.DolcB1ce75 + (float)1 > Time.time)
			{
				if (181333 - 151528 != 29806)
				{
					break;
				}
			}
			else
			{
				this.DolcB1ce75 = Time.time;
				if (214745 - 474174 != -259428)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)30, this.gameObject.layer);
					if (99314 - 66687 == 32627)
					{
						if (266749 - 181281 != 85469)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (12137 - 545544 == -533407)
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
									if (190570 - 273054 == -82483)
									{
										goto IL_44C;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (57958 - 241011 != -183053)
									{
										goto IL_44C;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (177116 - 29522 == 147595)
									{
										goto IL_44C;
									}
									bool flag = true;
									if (12228 - 300162 != -287934)
									{
										goto IL_44C;
									}
									eRace race = this.saRcNEI4tc.Race;
									if (20853 - 227624 == -206770)
									{
										goto IL_44C;
									}
									if (race == eRace.Tails)
									{
										if (156217 - 485199 == -328981)
										{
											goto IL_44C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5F4;
										}
										if (256171 - 109617 == 146555)
										{
											goto IL_44C;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (58840 - 81785 != -22945)
											{
												goto IL_44C;
											}
											goto IL_5F4;
										}
										goto IL_759;
										IL_5F4:
										flag = false;
										if (260191 - 155436 == 104756)
										{
											goto IL_44C;
										}
									}
									else if (race == eRace.Plants)
									{
										if (80315 - 391099 == -310783)
										{
											goto IL_44C;
										}
										flag = false;
										if (71660 - 112875 == -41214)
										{
											goto IL_44C;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (123923 - 227376 == -103452)
										{
											goto IL_44C;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_263;
										}
										if (208322 - 87717 == 120606)
										{
											goto IL_44C;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (108279 - 470931 != -362651)
											{
												goto IL_263;
											}
											goto IL_44C;
										}
										goto IL_759;
										IL_263:
										flag = false;
										if (270274 - 350040 != -79766)
										{
											goto IL_44C;
										}
									}
									else if (race == eRace.Robots)
									{
										if (207562 - 160051 == 47512)
										{
											goto IL_44C;
										}
										flag = true;
										if (278778 - 397412 == -118633)
										{
											goto IL_44C;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (221869 - 266746 != -44877)
										{
											goto IL_44C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_79F;
										}
										if (50908 - 129686 == -78777)
										{
											goto IL_44C;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_79F;
										}
										if (96659 - 564483 == -467823)
										{
											goto IL_44C;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (77754 - 481657 != -403902)
											{
												goto IL_79F;
											}
											goto IL_44C;
										}
										goto IL_759;
										IL_79F:
										flag = false;
										if (290405 - 289853 != 552)
										{
											goto IL_44C;
										}
									}
									else if (race == eRace.Structure)
									{
										if (96188 - 87874 != 8314)
										{
											goto IL_44C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (44675 - 496520 == -451844)
											{
												goto IL_44C;
											}
											flag = false;
											if (279380 - 119737 == 159644)
											{
												goto IL_44C;
											}
										}
									}
									IL_759:
									if (flag)
									{
										if (12321 - 508526 == -496204)
										{
											goto IL_44C;
										}
										if (characterControl.hp > 0)
										{
											if (257066 - 479544 == -222477)
											{
												goto IL_44C;
											}
											if (characterControl.recieveTarget)
											{
												if (148039 - 181822 != -33783)
												{
													goto IL_44C;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (194289 - 161765 == 32525)
													{
														goto IL_44C;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (119468 - 359610 != -240142)
														{
															goto IL_44C;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (260890 - 97705 != 163185)
														{
															goto IL_44C;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (26081 - 477462 != -451381)
															{
																goto IL_44C;
															}
															this.saRcNEI4tc.isAlert = true;
															if (238458 - 489601 == -251142)
															{
																goto IL_44C;
															}
															this.Hj3cPHZldC = Time.time;
															if (102328 - 295134 != -192806)
															{
																goto IL_44C;
															}
															this.saRcNEI4tc.myAttackTarget = gameObject;
															if (145599 - 387804 != -242205)
															{
																goto IL_44C;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (89897 - 461093 != -371196)
															{
																goto IL_44C;
															}
															this.saRcNEI4tc.addHate(characterControl.ActorNr, 5);
															if (38941 - 524753 != -485812)
															{
																goto IL_44C;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (280464 - 60282 != 220182)
															{
																goto IL_44C;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (76859 - 32562 != 44297)
															{
																goto IL_44C;
															}
															if (num < (float)60)
															{
																if (195859 - 197764 != -1905)
																{
																	goto IL_44C;
																}
																if (characterControl.hp > 0)
																{
																	if (68587 - 329838 == -261250)
																	{
																		goto IL_44C;
																	}
																	this.saRcNEI4tc.isAlert = true;
																	if (99380 - 201760 != -102380)
																	{
																		goto IL_44C;
																	}
																	this.Hj3cPHZldC = Time.time;
																	if (158292 - 383886 == -225593)
																	{
																		goto IL_44C;
																	}
																	this.saRcNEI4tc.myAttackTarget = gameObject;
																	if (75052 - 211712 == -136659)
																	{
																		goto IL_44C;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (11965 - 51794 != -39829)
																	{
																		goto IL_44C;
																	}
																	this.saRcNEI4tc.addHate(characterControl.ActorNr, 5);
																	if (115700 - 468646 != -352946)
																	{
																		goto IL_44C;
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
								if (31408 - 376276 != -344867)
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

	// Token: 0x0600047D RID: 1149 RVA: 0x000750D8 File Offset: 0x000732D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x000750DC File Offset: 0x000732DC
	internal static bool TgKit2YDKZhJtSa4t3e()
	{
		return true;
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x000750E0 File Offset: 0x000732E0
	internal static bool Kh2al4YvsqESmMOsgGa()
	{
		return false;
	}

	// Token: 0x0400044A RID: 1098
	private CharacterControl saRcNEI4tc;

	// Token: 0x0400044B RID: 1099
	private LeoBug l4OcEZOvH8;

	// Token: 0x0400044C RID: 1100
	public string AI_state;

	// Token: 0x0400044D RID: 1101
	private float Hj3cPHZldC;

	// Token: 0x0400044E RID: 1102
	private float mgocSJmPKm;

	// Token: 0x0400044F RID: 1103
	private float DolcB1ce75;
}
