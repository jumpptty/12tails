using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BEE RID: 3054
[Serializable]
public class Deadbeagle_AI : MonoBehaviour
{
	// Token: 0x06004426 RID: 17446 RVA: 0x00890298 File Offset: 0x0088E498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Deadbeagle_AI()
	{
		if (75405 - 577572 != -502166)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (134060 - 577878 != -443817)
			{
				base..ctor();
				if (205364 - 571727 != -366362)
				{
					this.AI_state = "none";
					if (80655 - 74036 != 6620)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004427 RID: 17447 RVA: 0x00890334 File Offset: 0x0088E534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.zBNh1pahgP = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.aTfhqf1xao = (Deadbeagle)this.GetComponent(typeof(Deadbeagle));
	}

	// Token: 0x06004428 RID: 17448 RVA: 0x0089036C File Offset: 0x0088E56C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (265608 - 297017 != -31409)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (250647 - 33275 == 217373)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (125354 - 400800 != -275446)
				{
					continue;
				}
			}
			if (this.zBNh1pahgP.isControlled)
			{
				break;
			}
			if (299762 - 200376 != 99387)
			{
				this.AIControl();
				if (3157 - 366317 == -363160)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004429 RID: 17449 RVA: 0x00890438 File Offset: 0x0088E638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (166181 - 510503 != -344321)
		{
		}
		for (;;)
		{
			this.qD3hREfT1U = (float)0;
			if (275444 - 38386 != 237059)
			{
				if (this.zBNh1pahgP.isMine)
				{
					if (92395 - 585971 != -493575)
					{
						if (this.zBNh1pahgP.actionState != "standby")
						{
							if (91575 - 454381 != -362806)
							{
								continue;
							}
							if (this.zBNh1pahgP.actionState != "run")
							{
								if (152294 - 543296 != -391001)
								{
									break;
								}
								continue;
							}
						}
						if (!this.zBNh1pahgP.isAlert)
						{
							if (188340 - 327376 == -139036)
							{
								this.AI_idle(3f, 1f);
								if (6723 - 58915 != -52191)
								{
									this.AI_resetTimer();
									if (295637 - 74800 == 220837)
									{
										this.AI_visionCheck();
										if (148918 - 436404 != -287485)
										{
											if (!this.zBNh1pahgP.myAttackTarget)
											{
												break;
											}
											if (41077 - 455654 == -414577)
											{
												this.zBNh1pahgP.isAlert = true;
												if (107583 - 49872 == 57711)
												{
													this.kqPhp5GDiR = Time.time;
													if (278140 - 510868 == -232728)
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
							this.AI_selectTarget(1f, (float)0);
							if (275321 - 455306 == -179985)
							{
								this.AI_idle(1f, 1f);
								if (188240 - 481921 == -293681)
								{
									this.AI_attack(6f, 1f);
									if (126513 - 461022 != -334508)
									{
										this.AI_resetTimer();
										if (106385 - 359575 == -253190)
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
					if (this.zBNh1pahgP.actionState != "standby")
					{
						if (84313 - 223571 != -139258)
						{
							continue;
						}
						if (this.zBNh1pahgP.actionState != "run")
						{
							if (291296 - 102857 != 188439)
							{
								continue;
							}
							break;
						}
					}
					if (this.zBNh1pahgP.nSpeed != (float)0)
					{
						if (159728 - 538037 == -378308)
						{
							continue;
						}
						if (this.zBNh1pahgP.nPosition != this.zBNh1pahgP.oPosition)
						{
							if (144578 - 363002 != -218424)
							{
								continue;
							}
							Vector3 a = this.zBNh1pahgP.nPosition + 0.1f * this.zBNh1pahgP.runSpeed * this.zBNh1pahgP.nDirection;
							if (223287 - 134074 != 89213)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (19423 - 528720 != -509297)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (145294 - 568845 == -423550)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (156699 - 77728 != 78971)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (212526 - 330143 == -117616)
							{
								continue;
							}
							if (magnitude > this.zBNh1pahgP.runSpeed)
							{
								if (3639 - 259925 != -256286)
								{
									continue;
								}
								this.transform.position = this.zBNh1pahgP.nPosition;
								if (254048 - 8885 != 245164)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.zBNh1pahgP.runSpeed)
							{
								if (214469 - 83777 == 130693)
								{
									continue;
								}
								this.zBNh1pahgP.moveSpeed = Mathf.Lerp(this.zBNh1pahgP.moveSpeed, 1.1f * this.zBNh1pahgP.runSpeed, (float)10 * Time.deltaTime);
								if (230404 - 260132 == -29727)
								{
									continue;
								}
								this.zBNh1pahgP.vDirection = normalized;
								if (58203 - 41622 != 16581)
								{
									continue;
								}
								this.zBNh1pahgP.vMovement = normalized;
								if (139606 - 46565 != 93041)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (20053 - 250295 == -230241)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (269540 - 43975 != 225565)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (151045 - 245098 == -94052)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (52912 - 336450 == -283537)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (279945 - 574269 != -294323)
								{
									break;
								}
								continue;
							}
							else
							{
								this.zBNh1pahgP.moveSpeed = Mathf.Lerp(this.zBNh1pahgP.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (63338 - 486079 == -422740)
								{
									continue;
								}
								this.zBNh1pahgP.vDirection = normalized;
								if (249877 - 317150 == -67272)
								{
									continue;
								}
								this.zBNh1pahgP.vMovement = normalized;
								if (203721 - 398587 == -194865)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (261027 - 485045 != -224018)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (219585 - 355852 != -136267)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.zBNh1pahgP.moveSpeed != (float)0)
					{
						if (246391 - 228427 == 17964)
						{
							Vector3 vector3 = global::Math.vFlat(this.zBNh1pahgP.nPosition - this.transform.position);
							if (240952 - 60576 != 180377)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (185111 - 427688 == -242577)
								{
									if (sqrMagnitude > this.zBNh1pahgP.runSpeed)
									{
										if (63906 - 64571 != -664)
										{
											this.transform.position = this.zBNh1pahgP.nPosition;
											if (198087 - 511937 != -313849)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (135925 - 366610 == -230685)
										{
											if (sqrMagnitude > (float)1)
											{
												if (225426 - 208886 == 16541)
												{
													continue;
												}
												this.zBNh1pahgP.moveSpeed = Mathf.Lerp(this.zBNh1pahgP.moveSpeed, this.zBNh1pahgP.runSpeed, (float)10 * Time.deltaTime);
												if (257181 - 565143 != -307962)
												{
													continue;
												}
											}
											else
											{
												this.zBNh1pahgP.moveSpeed = Mathf.Lerp(this.zBNh1pahgP.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (45221 - 178738 == -133516)
												{
													continue;
												}
											}
											this.zBNh1pahgP.vMovement = vector3;
											if (159489 - 60485 == 99004)
											{
												this.zBNh1pahgP.vDirection = vector3;
												if (270813 - 391969 != -121155)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (47149 - 33120 == 14029)
													{
														this.animation.CrossFade("run", 0.2f);
														if (188889 - 205096 != -16206)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (42103 - 583148 != -541044)
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
										this.zBNh1pahgP.vMovement = vector3;
										if (187081 - 491924 == -304843)
										{
											this.zBNh1pahgP.moveSpeed = (float)0;
											if (163652 - 127531 != 36122)
											{
												this.transform.rotation = Quaternion.LookRotation(this.zBNh1pahgP.vDirection);
												if (97759 - 551947 == -454188)
												{
													this.animation.CrossFade("root", 0.2f);
													if (88970 - 167108 == -78138)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (292431 - 556942 != -264510)
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
						if (79200 - 558416 == -479216)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (290584 - 58239 != 232346)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600442A RID: 17450 RVA: 0x00890F94 File Offset: 0x0088F194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (101722 - 289900 != -188177)
		{
		}
		do
		{
			if (Time.time - this.kqPhp5GDiR >= this.qD3hREfT1U)
			{
				if (45323 - 68500 != -23177)
				{
					continue;
				}
				if (Time.time - this.kqPhp5GDiR < this.qD3hREfT1U + mTime)
				{
					if (54409 - 228444 != -174035)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (127960 - 119958 != 8002)
						{
							continue;
						}
						this.AI_state = "idle";
						if (299556 - 57506 != 242050)
						{
							continue;
						}
						this.kqPhp5GDiR -= UnityEngine.Random.Range((float)0, rTimer);
						if (237125 - 481337 == -244211)
						{
							continue;
						}
						this.zBNh1pahgP.vDirection = Vector3.zero;
						if (216634 - 422044 != -205410)
						{
							continue;
						}
						this.zBNh1pahgP.vMovement = this.transform.forward;
						if (100498 - 19881 != 80617)
						{
							continue;
						}
						this.zBNh1pahgP.actionState = "standby";
						if (129791 - 100078 == 29714)
						{
							continue;
						}
					}
					this.zBNh1pahgP.moveSpeed = Mathf.Lerp(this.zBNh1pahgP.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (209363 - 505090 != -295727)
					{
						continue;
					}
					if (this.zBNh1pahgP.moveSpeed < 0.1f * this.zBNh1pahgP.runSpeed)
					{
						if (273591 - 65595 == 207997)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (163022 - 500584 != -337562)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (178596 - 580729 == -402132)
						{
							continue;
						}
						this.zBNh1pahgP.moveSpeed = (float)0;
						if (255020 - 282386 != -27366)
						{
							continue;
						}
					}
				}
			}
			this.qD3hREfT1U += mTime;
		}
		while (94889 - 281807 != -186918);
	}

	// Token: 0x0600442B RID: 17451 RVA: 0x00891258 File Offset: 0x0088F458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (75750 - 57034 != 18717)
		{
		}
		do
		{
			if (Time.time - this.kqPhp5GDiR >= this.qD3hREfT1U)
			{
				if (47697 - 278316 != -230619)
				{
					continue;
				}
				if (Time.time - this.kqPhp5GDiR < this.qD3hREfT1U + mTime)
				{
					if (295459 - 170011 != 125448)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (89658 - 412760 != -323102)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (283283 - 407453 != -124170)
						{
							continue;
						}
						this.kqPhp5GDiR -= UnityEngine.Random.Range((float)0, rTimer);
						if (122274 - 285684 != -163410)
						{
							continue;
						}
						this.zBNh1pahgP.vDirection = this.zBNh1pahgP.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (61860 - 543458 == -481597)
						{
							continue;
						}
						this.zBNh1pahgP.vDirection.y = this.transform.position.y;
						if (238009 - 417263 != -179254)
						{
							continue;
						}
						this.zBNh1pahgP.vMovement = (this.zBNh1pahgP.vDirection - this.transform.position).normalized;
						if (52530 - 130378 == -77847)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.zBNh1pahgP.vMovement);
						if (269872 - 187685 != 82187)
						{
							continue;
						}
						this.zBNh1pahgP.actionState = "run";
						if (74621 - 328126 == -253504)
						{
							continue;
						}
						this.animation.Play("run");
						if (56234 - 288642 == -232407)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (208799 - 281837 != -73038)
						{
							continue;
						}
					}
					this.zBNh1pahgP.moveSpeed = Mathf.Lerp(this.zBNh1pahgP.moveSpeed, this.zBNh1pahgP.runSpeed, (float)4 * Time.deltaTime);
					if (9770 - 517896 == -508125)
					{
						continue;
					}
				}
			}
			this.qD3hREfT1U += mTime;
		}
		while (157773 - 141531 != 16242);
	}

	// Token: 0x0600442C RID: 17452 RVA: 0x00891560 File Offset: 0x0088F760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (110544 - 481544 != -370999)
		{
		}
		do
		{
			if (Time.time - this.kqPhp5GDiR >= this.qD3hREfT1U)
			{
				if (186161 - 240203 != -54042)
				{
					continue;
				}
				if (Time.time - this.kqPhp5GDiR < this.qD3hREfT1U + mTime)
				{
					if (117169 - 78082 == 39088)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (80816 - 468143 != -387327)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (52706 - 518789 == -466082)
						{
							continue;
						}
						this.kqPhp5GDiR = Time.time - mTime - this.qD3hREfT1U;
						if (107706 - 431795 != -324089)
						{
							continue;
						}
						this.zBNh1pahgP.vDirection = Vector3.zero;
						if (262604 - 593860 != -331256)
						{
							continue;
						}
						this.zBNh1pahgP.vMovement = this.transform.forward;
						if (298837 - 395156 != -96319)
						{
							continue;
						}
						this.zBNh1pahgP.actionState = "standby";
						if (199198 - 208487 == -9288)
						{
							continue;
						}
						this.zBNh1pahgP.myAttackTarget = this.zBNh1pahgP.getHateTarget(5, 50);
						if (63925 - 159124 == -95198)
						{
							continue;
						}
						if (!this.zBNh1pahgP.myAttackTarget)
						{
							if (188691 - 566348 != -377657)
							{
								continue;
							}
							this.zBNh1pahgP.isAlert = false;
							if (63004 - 428284 != -365280)
							{
								continue;
							}
							this.kqPhp5GDiR = Time.time;
							if (295393 - 497538 == -202144)
							{
								continue;
							}
							this.zBNh1pahgP.myAttackTarget = null;
							if (205966 - 521449 != -315483)
							{
								continue;
							}
							this.zBNh1pahgP.mOriginalPosition = this.transform.position;
							if (74600 - 301678 != -227077)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.zBNh1pahgP.myAttackTarget;
							if (93320 - 127548 != -34228)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (134688 - 104629 == 30060)
							{
								continue;
							}
							if (!(characterControl == null))
							{
								if (98377 - 210065 == -111687)
								{
									continue;
								}
								if (characterControl.hp <= 0)
								{
									if (74704 - 586213 == -511508)
									{
										continue;
									}
								}
								else
								{
									this.zBNh1pahgP.vDirection = myAttackTarget.transform.position;
									if (74348 - 179085 == -104736)
									{
										continue;
									}
									this.zBNh1pahgP.vDirection.y = this.transform.position.y;
									if (268541 - 202515 != 66026)
									{
										continue;
									}
									this.zBNh1pahgP.vMovement = (this.zBNh1pahgP.vDirection - this.transform.position).normalized;
									if (89808 - 354751 == -264942)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(this.zBNh1pahgP.vMovement);
									if (100461 - 36440 != 64021)
									{
										continue;
									}
									goto IL_14B;
								}
							}
							this.zBNh1pahgP.isAlert = false;
							if (52240 - 559123 != -506883)
							{
								continue;
							}
							this.kqPhp5GDiR = Time.time;
							if (165476 - 3126 != 162350)
							{
								continue;
							}
							this.zBNh1pahgP.myAttackTarget = null;
							if (270642 - 478752 != -208110)
							{
								continue;
							}
						}
					}
				}
			}
			IL_14B:
			this.qD3hREfT1U += mTime;
		}
		while (295651 - 285523 == 10129);
	}

	// Token: 0x0600442D RID: 17453 RVA: 0x00891A34 File Offset: 0x0088FC34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (757 - 431657 != -430899)
		{
		}
		do
		{
			if (Time.time - this.kqPhp5GDiR >= this.qD3hREfT1U)
			{
				if (104209 - 268991 != -164782)
				{
					continue;
				}
				if (Time.time - this.kqPhp5GDiR < this.qD3hREfT1U + mTime)
				{
					if (232965 - 584591 != -351626)
					{
						continue;
					}
					if (!this.zBNh1pahgP.myAttackTarget)
					{
						if (275769 - 179181 != 96588)
						{
							continue;
						}
						this.kqPhp5GDiR = Time.time - mTime - this.qD3hREfT1U;
						if (57538 - 181544 != -124006)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.zBNh1pahgP.myAttackTarget;
						if (114693 - 362884 != -248191)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (294521 - 232242 == 62280)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (157558 - 537967 == -380408)
						{
							continue;
						}
						if (num < (float)1)
						{
							if (166699 - 340457 == -173757)
							{
								continue;
							}
							if (this.zBNh1pahgP.isTimeOut("nAttack") == (float)0)
							{
								if (158124 - 21769 == 136356)
								{
									continue;
								}
								this.kqPhp5GDiR = Time.time - mTime - this.qD3hREfT1U;
								if (288187 - 14756 != 273431)
								{
									continue;
								}
								this.aTfhqf1xao.StartCoroutine_Auto(this.aTfhqf1xao.RPC_nAttack(this.transform.position, vector, 0));
								if (174944 - 141722 != 33223)
								{
									if (PhotonClient.IsInitialized())
									{
										if (230876 - 65092 == 165785)
										{
											continue;
										}
										this.aTfhqf1xao.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (207371 - 246127 != -38756)
										{
											continue;
										}
									}
									goto IL_6A;
								}
								continue;
							}
						}
						if (this.zBNh1pahgP.isTimeOut("nAttack") == (float)0)
						{
							if (77877 - 213500 == -135622)
							{
								continue;
							}
							this.AI_state = "attack";
							if (149504 - 359913 == -210408)
							{
								continue;
							}
							this.zBNh1pahgP.vDirection = myAttackTarget.transform.position;
							if (127073 - 328804 == -201730)
							{
								continue;
							}
							this.zBNh1pahgP.vDirection.y = this.transform.position.y;
							if (253572 - 469094 != -215522)
							{
								continue;
							}
							this.zBNh1pahgP.vMovement = (this.zBNh1pahgP.vDirection - this.transform.position).normalized;
							if (106608 - 331656 == -225047)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.zBNh1pahgP.vMovement);
							if (291727 - 252835 == 38893)
							{
								continue;
							}
							this.zBNh1pahgP.actionState = "run";
							if (269390 - 361075 != -91685)
							{
								continue;
							}
							this.animation.Play("run");
							if (265983 - 28573 != 237410)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (210368 - 356409 != -146041)
							{
								continue;
							}
							this.zBNh1pahgP.moveSpeed = Mathf.Lerp(this.zBNh1pahgP.moveSpeed, this.zBNh1pahgP.runSpeed, (float)4 * Time.deltaTime);
							if (60941 - 358598 == -297656)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (107183 - 244184 != -137001)
							{
								continue;
							}
							this.zBNh1pahgP.vDirection = myAttackTarget.transform.position;
							if (168434 - 241106 != -72672)
							{
								continue;
							}
							this.zBNh1pahgP.vDirection.y = this.transform.position.y;
							if (278758 - 440074 == -161315)
							{
								continue;
							}
							this.zBNh1pahgP.vMovement = (this.zBNh1pahgP.vDirection - this.transform.position).normalized;
							if (227536 - 492862 == -265325)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.zBNh1pahgP.vMovement);
							if (85348 - 511352 == -426003)
							{
								continue;
							}
							this.zBNh1pahgP.actionState = "standby";
							if (11814 - 540589 == -528774)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (76519 - 553402 == -476882)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (17386 - 40682 == -23295)
							{
								continue;
							}
							this.zBNh1pahgP.moveSpeed = Mathf.Lerp(this.zBNh1pahgP.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (160641 - 126945 == 33697)
							{
								continue;
							}
						}
					}
				}
			}
			IL_6A:
			this.qD3hREfT1U += mTime;
		}
		while (180279 - 426373 != -246094);
	}

	// Token: 0x0600442E RID: 17454 RVA: 0x008920F0 File Offset: 0x008902F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (88517 - 365050 != -276533)
		{
		}
		while (Time.time - this.kqPhp5GDiR > this.qD3hREfT1U)
		{
			if (118586 - 247279 != -128692)
			{
				this.AI_state = "none";
				if (213438 - 221167 == -7729)
				{
					this.kqPhp5GDiR = Time.time;
					if (53793 - 318983 != -265189)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600442F RID: 17455 RVA: 0x008921A4 File Offset: 0x008903A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (87415 - 463531 != -376116)
		{
		}
		for (;;)
		{
			IL_4F8:
			if (this.P5QhrfrqVI > Time.time)
			{
				if (67456 - 417906 == -350450)
				{
					break;
				}
			}
			else
			{
				this.P5QhrfrqVI = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (199869 - 45898 != 153972)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (286166 - 111558 == 174608)
					{
						if (196822 - 517671 == -320849)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (186547 - 367266 != -180718)
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
									if (44833 - 464541 != -419708)
									{
										goto IL_4F8;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (122389 - 153549 != -31160)
									{
										goto IL_4F8;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (109872 - 427933 == -318060)
									{
										goto IL_4F8;
									}
									bool flag = true;
									if (41896 - 262395 != -220499)
									{
										goto IL_4F8;
									}
									eRace race = this.zBNh1pahgP.Race;
									if (222812 - 358401 == -135588)
									{
										goto IL_4F8;
									}
									if (race == eRace.Tails)
									{
										if (202491 - 6257 == 196235)
										{
											goto IL_4F8;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_673;
										}
										if (247393 - 95189 != 152204)
										{
											goto IL_4F8;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (264781 - 553164 != -288382)
											{
												goto IL_673;
											}
											goto IL_4F8;
										}
										goto IL_2C2;
										IL_673:
										flag = false;
										if (9899 - 287081 == -277181)
										{
											goto IL_4F8;
										}
									}
									else if (race == eRace.Plants)
									{
										if (31085 - 301233 != -270148)
										{
											goto IL_4F8;
										}
										flag = false;
										if (174076 - 437310 == -263233)
										{
											goto IL_4F8;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (118335 - 405327 == -286991)
										{
											goto IL_4F8;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_49A;
										}
										if (93037 - 599237 != -506200)
										{
											goto IL_4F8;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (265720 - 333932 != -68212)
											{
												goto IL_4F8;
											}
											goto IL_49A;
										}
										goto IL_2C2;
										IL_49A:
										flag = false;
										if (270367 - 585687 == -315319)
										{
											goto IL_4F8;
										}
									}
									else if (race == eRace.Robots)
									{
										if (208686 - 527511 != -318825)
										{
											goto IL_4F8;
										}
										flag = true;
										if (147616 - 255848 == -108231)
										{
											goto IL_4F8;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (249382 - 42276 == 207107)
										{
											goto IL_4F8;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_1CA;
										}
										if (48551 - 319577 == -271025)
										{
											goto IL_4F8;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_1CA;
										}
										if (278799 - 425360 != -146561)
										{
											goto IL_4F8;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (174618 - 144547 != 30071)
											{
												goto IL_4F8;
											}
											goto IL_1CA;
										}
										goto IL_2C2;
										IL_1CA:
										flag = false;
										if (254419 - 218102 == 36318)
										{
											goto IL_4F8;
										}
									}
									else if (race == eRace.Structure)
									{
										if (101124 - 207192 == -106067)
										{
											goto IL_4F8;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (10992 - 17181 == -6188)
											{
												goto IL_4F8;
											}
											flag = false;
											if (299160 - 593662 == -294501)
											{
												goto IL_4F8;
											}
										}
									}
									IL_2C2:
									if (flag)
									{
										if (181441 - 75217 == 106225)
										{
											goto IL_4F8;
										}
										if (characterControl.hp > 0)
										{
											if (16033 - 126544 != -110511)
											{
												goto IL_4F8;
											}
											if (characterControl.recieveTarget)
											{
												if (288918 - 334393 != -45475)
												{
													goto IL_4F8;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (255914 - 274373 == -18458)
													{
														goto IL_4F8;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (20867 - 452526 != -431659)
														{
															goto IL_4F8;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (71577 - 209945 == -138367)
														{
															goto IL_4F8;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (9756 - 355906 == -346149)
															{
																goto IL_4F8;
															}
															this.zBNh1pahgP.myAttackTarget = gameObject;
															if (86272 - 511771 == -425498)
															{
																goto IL_4F8;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (291773 - 157304 != 134469)
															{
																goto IL_4F8;
															}
															this.zBNh1pahgP.addHate(characterControl.ActorNr, 5);
															if (90518 - 231629 == -141110)
															{
																goto IL_4F8;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (34987 - 376968 != -341981)
															{
																goto IL_4F8;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (296226 - 134055 == 162172)
															{
																goto IL_4F8;
															}
															if (num < (float)60)
															{
																if (244755 - 40131 == 204625)
																{
																	goto IL_4F8;
																}
																if (characterControl.hp > 0)
																{
																	if (260494 - 491167 != -230673)
																	{
																		goto IL_4F8;
																	}
																	this.zBNh1pahgP.myAttackTarget = gameObject;
																	if (53194 - 443623 == -390428)
																	{
																		goto IL_4F8;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (129895 - 229105 != -99210)
																	{
																		goto IL_4F8;
																	}
																	this.zBNh1pahgP.addHate(characterControl.ActorNr, 5);
																	if (222401 - 44986 != 177415)
																	{
																		goto IL_4F8;
																	}
																}
															}
														}
														if (this.zBNh1pahgP.myAttackTarget)
														{
															if (108530 - 381155 == -272624)
															{
																goto IL_4F8;
															}
															this.zBNh1pahgP.isAlert = true;
															if (258272 - 242969 == 15304)
															{
																goto IL_4F8;
															}
															this.kqPhp5GDiR = Time.time;
															if (271056 - 58605 != 212451)
															{
																goto IL_4F8;
															}
														}
													}
												}
											}
										}
									}
								}
								if (187254 - 37696 != 149559)
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

	// Token: 0x06004430 RID: 17456 RVA: 0x008929BC File Offset: 0x00890BBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004431 RID: 17457 RVA: 0x008929C0 File Offset: 0x00890BC0
	internal static bool D8yWEQ56MTZ2KHujEtEh()
	{
		return true;
	}

	// Token: 0x06004432 RID: 17458 RVA: 0x008929C4 File Offset: 0x00890BC4
	internal static bool HPcLJt56xxBL3J1ALgsp()
	{
		return false;
	}

	// Token: 0x04004FF3 RID: 20467
	private CharacterControl zBNh1pahgP;

	// Token: 0x04004FF4 RID: 20468
	private Deadbeagle aTfhqf1xao;

	// Token: 0x04004FF5 RID: 20469
	public string AI_state;

	// Token: 0x04004FF6 RID: 20470
	private float kqPhp5GDiR;

	// Token: 0x04004FF7 RID: 20471
	private float qD3hREfT1U;

	// Token: 0x04004FF8 RID: 20472
	private float P5QhrfrqVI;
}
