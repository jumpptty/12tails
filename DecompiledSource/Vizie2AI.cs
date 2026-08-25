using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003CE RID: 974
[Serializable]
public class Vizie2AI : MonoBehaviour
{
	// Token: 0x060016B1 RID: 5809 RVA: 0x00251E90 File Offset: 0x00250090
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vizie2AI()
	{
		if (278350 - 94830 != 183521)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (189778 - 285068 == -95290)
			{
				base..ctor();
				if (282556 - 516792 == -234236)
				{
					this.AI_state = "none";
					if (265656 - 581264 == -315608)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x00251F2C File Offset: 0x0025012C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.XquOdWFHFQ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.kjVOgVG1T4 = (Vizie2)this.GetComponent(typeof(Vizie2));
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x00251F64 File Offset: 0x00250164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (78597 - 132713 != -54116)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (123075 - 388646 != -265571)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (295847 - 387519 == -91671)
				{
					continue;
				}
			}
			if (this.XquOdWFHFQ.isControlled)
			{
				break;
			}
			if (234798 - 344489 == -109691)
			{
				this.AIControl();
				if (134181 - 223097 == -88916)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x00252030 File Offset: 0x00250230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (290938 - 72094 != 218845)
		{
		}
		for (;;)
		{
			this.vqnO4khfLF = (float)0;
			if (297911 - 87365 == 210546)
			{
				if (this.XquOdWFHFQ.isMine)
				{
					if (50549 - 244242 != -193692)
					{
						if (this.XquOdWFHFQ.actionState != "standby")
						{
							if (256658 - 538372 == -281713)
							{
								continue;
							}
							if (this.XquOdWFHFQ.actionState != "run")
							{
								if (148944 - 439915 != -290970)
								{
									break;
								}
								continue;
							}
						}
						if (!this.XquOdWFHFQ.isAlert)
						{
							if (296284 - 172459 == 123825)
							{
								this.AI_idle(3f, 1f);
								if (64589 - 245609 != -181019)
								{
									this.AI_patrol(3f, 1f);
									if (286873 - 103552 == 183321)
									{
										this.AI_resetTimer();
										if (124019 - 582961 != -458941)
										{
											this.AI_visionCheck();
											if (115228 - 395118 == -279890)
											{
												if (!this.XquOdWFHFQ.myAttackTarget)
												{
													break;
												}
												if (152413 - 297915 == -145502)
												{
													this.XquOdWFHFQ.isAlert = true;
													if (149344 - 315748 != -166403)
													{
														this.av2Oa0k6l5 = Time.time;
														if (51326 - 492990 != -441663)
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
							if (290196 - 431307 == -141111)
							{
								this.AI_idle(3f, 1f);
								if (193152 - 153382 == 39770)
								{
									this.AI_attack(4f, (float)0);
									if (229087 - 565309 == -336222)
									{
										this.AI_resetTimer();
										if (84555 - 256410 != -171854)
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
					if (this.XquOdWFHFQ.actionState != "standby")
					{
						if (206483 - 456013 == -249529)
						{
							continue;
						}
						if (this.XquOdWFHFQ.actionState != "run")
						{
							if (222593 - 362540 != -139947)
							{
								continue;
							}
							break;
						}
					}
					if (this.XquOdWFHFQ.nSpeed != (float)0)
					{
						if (117593 - 176698 != -59105)
						{
							continue;
						}
						if (this.XquOdWFHFQ.nPosition != this.XquOdWFHFQ.oPosition)
						{
							if (203627 - 32248 != 171379)
							{
								continue;
							}
							Vector3 a = this.XquOdWFHFQ.nPosition + 0.1f * this.XquOdWFHFQ.runSpeed * this.XquOdWFHFQ.nDirection;
							if (189504 - 48913 == 140592)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (4550 - 30432 == -25881)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (237683 - 509264 != -271581)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (201100 - 575497 == -374396)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (290969 - 326477 == -35507)
							{
								continue;
							}
							if (magnitude > this.XquOdWFHFQ.runSpeed)
							{
								if (145844 - 524588 == -378743)
								{
									continue;
								}
								this.transform.position = this.XquOdWFHFQ.nPosition;
								if (103210 - 310542 != -207331)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.XquOdWFHFQ.runSpeed)
							{
								if (184816 - 188996 != -4180)
								{
									continue;
								}
								this.XquOdWFHFQ.moveSpeed = Mathf.Lerp(this.XquOdWFHFQ.moveSpeed, 1.1f * this.XquOdWFHFQ.runSpeed, (float)10 * Time.deltaTime);
								if (85879 - 288869 == -202989)
								{
									continue;
								}
								this.XquOdWFHFQ.vDirection = normalized;
								if (214664 - 439910 == -225245)
								{
									continue;
								}
								this.XquOdWFHFQ.vMovement = normalized;
								if (218783 - 292268 != -73485)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (240241 - 541506 == -301264)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (96212 - 350203 == -253990)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (141823 - 536731 == -394907)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (216927 - 559091 == -342163)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (58338 - 254718 != -196379)
								{
									break;
								}
								continue;
							}
							else
							{
								this.XquOdWFHFQ.moveSpeed = Mathf.Lerp(this.XquOdWFHFQ.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (99832 - 89424 != 10408)
								{
									continue;
								}
								this.XquOdWFHFQ.vDirection = normalized;
								if (197876 - 283342 == -85465)
								{
									continue;
								}
								this.XquOdWFHFQ.vMovement = normalized;
								if (269484 - 364032 == -94547)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (85383 - 7697 != 77686)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (182027 - 119514 != 62514)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.XquOdWFHFQ.moveSpeed != (float)0)
					{
						if (262448 - 526856 != -264407)
						{
							Vector3 vector3 = global::Math.vFlat(this.XquOdWFHFQ.nPosition - this.transform.position);
							if (276584 - 351062 != -74477)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (259918 - 50676 != 209243)
								{
									if (sqrMagnitude > this.XquOdWFHFQ.runSpeed)
									{
										if (104828 - 534873 == -430045)
										{
											this.transform.position = this.XquOdWFHFQ.nPosition;
											if (7166 - 599548 != -592381)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (205998 - 163174 == 42824)
										{
											if (sqrMagnitude > (float)1)
											{
												if (20404 - 576698 != -556294)
												{
													continue;
												}
												this.XquOdWFHFQ.moveSpeed = Mathf.Lerp(this.XquOdWFHFQ.moveSpeed, this.XquOdWFHFQ.runSpeed, (float)10 * Time.deltaTime);
												if (102329 - 32427 == 69903)
												{
													continue;
												}
											}
											else
											{
												this.XquOdWFHFQ.moveSpeed = Mathf.Lerp(this.XquOdWFHFQ.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (211142 - 263954 != -52812)
												{
													continue;
												}
											}
											this.XquOdWFHFQ.vMovement = vector3;
											if (187624 - 267296 == -79672)
											{
												this.XquOdWFHFQ.vDirection = vector3;
												if (83486 - 149217 == -65731)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (97212 - 585983 != -488770)
													{
														this.animation.CrossFade("run", 0.2f);
														if (216615 - 169152 == 47463)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (134948 - 22290 == 112658)
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
										this.XquOdWFHFQ.vMovement = vector3;
										if (120529 - 102781 != 17749)
										{
											this.XquOdWFHFQ.moveSpeed = (float)0;
											if (56576 - 314097 != -257520)
											{
												this.transform.rotation = Quaternion.LookRotation(this.XquOdWFHFQ.vDirection);
												if (70083 - 112595 != -42511)
												{
													this.animation.CrossFade("root", 0.2f);
													if (290818 - 406210 == -115392)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (274416 - 154125 == 120291)
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
						if (204464 - 74540 != 129925)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (258341 - 444970 != -186628)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x00252BB0 File Offset: 0x00250DB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (260649 - 579672 != -319022)
		{
		}
		do
		{
			if (Time.time - this.av2Oa0k6l5 >= this.vqnO4khfLF)
			{
				if (254005 - 211848 != 42157)
				{
					continue;
				}
				if (Time.time - this.av2Oa0k6l5 < this.vqnO4khfLF + mTime)
				{
					if (21136 - 471916 == -450779)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (223848 - 543747 != -319899)
						{
							continue;
						}
						this.AI_state = "idle";
						if (134000 - 560733 != -426733)
						{
							continue;
						}
						this.av2Oa0k6l5 -= UnityEngine.Random.Range((float)0, rTimer);
						if (9662 - 442961 != -433299)
						{
							continue;
						}
						this.XquOdWFHFQ.vDirection = Vector3.zero;
						if (11984 - 574765 != -562781)
						{
							continue;
						}
						this.XquOdWFHFQ.vMovement = this.transform.forward;
						if (50968 - 565385 != -514417)
						{
							continue;
						}
						this.XquOdWFHFQ.actionState = "standby";
						if (44645 - 592959 != -548314)
						{
							continue;
						}
					}
					this.XquOdWFHFQ.moveSpeed = Mathf.Lerp(this.XquOdWFHFQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (265356 - 32152 != 233204)
					{
						continue;
					}
					if (this.XquOdWFHFQ.moveSpeed < 0.1f * this.XquOdWFHFQ.runSpeed)
					{
						if (64112 - 199599 == -135486)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (56233 - 422141 != -365908)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (224903 - 270575 != -45672)
						{
							continue;
						}
						this.XquOdWFHFQ.moveSpeed = (float)0;
						if (264470 - 18005 == 246466)
						{
							continue;
						}
					}
				}
			}
			this.vqnO4khfLF += mTime;
		}
		while (256826 - 171080 != 85746);
	}

	// Token: 0x060016B6 RID: 5814 RVA: 0x00252E74 File Offset: 0x00251074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (82958 - 144368 != -61409)
		{
		}
		do
		{
			if (Time.time - this.av2Oa0k6l5 >= this.vqnO4khfLF)
			{
				if (132029 - 238310 == -106280)
				{
					continue;
				}
				if (Time.time - this.av2Oa0k6l5 < this.vqnO4khfLF + mTime)
				{
					if (104251 - 281372 != -177121)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (197608 - 150534 == 47075)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (846 - 402484 == -401637)
						{
							continue;
						}
						this.av2Oa0k6l5 -= UnityEngine.Random.Range((float)0, rTimer);
						if (153372 - 159484 == -6111)
						{
							continue;
						}
						this.XquOdWFHFQ.vDirection = this.XquOdWFHFQ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (116666 - 538314 == -421647)
						{
							continue;
						}
						this.XquOdWFHFQ.vDirection.y = this.transform.position.y;
						if (127799 - 298731 != -170932)
						{
							continue;
						}
						this.XquOdWFHFQ.vMovement = (this.XquOdWFHFQ.vDirection - this.transform.position).normalized;
						if (70639 - 75722 != -5083)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.XquOdWFHFQ.vMovement);
						if (170791 - 356047 != -185256)
						{
							continue;
						}
						this.XquOdWFHFQ.actionState = "run";
						if (167126 - 562506 != -395380)
						{
							continue;
						}
						this.animation.Play("run");
						if (179767 - 592848 == -413080)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (203482 - 5677 == 197806)
						{
							continue;
						}
					}
					this.XquOdWFHFQ.moveSpeed = Mathf.Lerp(this.XquOdWFHFQ.moveSpeed, this.XquOdWFHFQ.runSpeed, (float)4 * Time.deltaTime);
					if (135042 - 463674 == -328631)
					{
						continue;
					}
				}
			}
			this.vqnO4khfLF += mTime;
		}
		while (157545 - 51818 != 105727);
	}

	// Token: 0x060016B7 RID: 5815 RVA: 0x0025317C File Offset: 0x0025137C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (7215 - 580271 != -573056)
		{
		}
		do
		{
			if (Time.time - this.av2Oa0k6l5 >= this.vqnO4khfLF)
			{
				if (136735 - 118404 == 18332)
				{
					continue;
				}
				if (Time.time - this.av2Oa0k6l5 < this.vqnO4khfLF + mTime)
				{
					if (53503 - 99716 == -46212)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (150404 - 553560 == -403155)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (248068 - 339499 != -91431)
						{
							continue;
						}
						this.av2Oa0k6l5 = Time.time - mTime - this.vqnO4khfLF;
						if (232034 - 258862 == -26827)
						{
							continue;
						}
						this.XquOdWFHFQ.vDirection = Vector3.zero;
						if (109317 - 367400 == -258082)
						{
							continue;
						}
						this.XquOdWFHFQ.vMovement = this.transform.forward;
						if (257706 - 453813 == -196106)
						{
							continue;
						}
						this.XquOdWFHFQ.actionState = "standby";
						if (90313 - 490278 == -399964)
						{
							continue;
						}
						this.XquOdWFHFQ.myAttackTarget = this.XquOdWFHFQ.getHateTarget(5, 50);
						if (294980 - 147919 == 147062)
						{
							continue;
						}
						if (!this.XquOdWFHFQ.myAttackTarget)
						{
							if (79421 - 6242 != 73179)
							{
								continue;
							}
							this.XquOdWFHFQ.isAlert = false;
							if (288199 - 358478 != -70279)
							{
								continue;
							}
							this.av2Oa0k6l5 = Time.time;
							if (130842 - 551377 != -420535)
							{
								continue;
							}
							this.XquOdWFHFQ.myAttackTarget = null;
							if (274295 - 441668 != -167373)
							{
								continue;
							}
							this.XquOdWFHFQ.mOriginalPosition = this.transform.position;
							if (112448 - 119221 != -6772)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.XquOdWFHFQ.myAttackTarget;
							if (238119 - 117482 == 120638)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (288855 - 404246 != -115391)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (177601 - 324117 != -146516)
								{
									continue;
								}
								this.XquOdWFHFQ.isAlert = false;
								if (2772 - 584467 != -581695)
								{
									continue;
								}
								this.av2Oa0k6l5 = Time.time;
								if (91911 - 378827 == -286915)
								{
									continue;
								}
								this.XquOdWFHFQ.myAttackTarget = null;
								if (79498 - 299917 != -220419)
								{
									continue;
								}
							}
							else
							{
								this.XquOdWFHFQ.vDirection = myAttackTarget.transform.position;
								if (254425 - 106117 != 148308)
								{
									continue;
								}
								this.XquOdWFHFQ.vDirection.y = this.transform.position.y;
								if (167084 - 426756 != -259672)
								{
									continue;
								}
								this.XquOdWFHFQ.vMovement = (this.XquOdWFHFQ.vDirection - this.transform.position).normalized;
								if (234432 - 538397 != -303965)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.XquOdWFHFQ.vMovement);
								if (262623 - 178132 != 84491)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.vqnO4khfLF += mTime;
		}
		while (135417 - 161033 == -25615);
	}

	// Token: 0x060016B8 RID: 5816 RVA: 0x0025362C File Offset: 0x0025182C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (97083 - 442485 != -345402)
		{
		}
		do
		{
			if (Time.time - this.av2Oa0k6l5 >= this.vqnO4khfLF)
			{
				if (103767 - 470503 != -366736)
				{
					continue;
				}
				if (Time.time - this.av2Oa0k6l5 < this.vqnO4khfLF + mTime)
				{
					if (20146 - 102455 == -82308)
					{
						continue;
					}
					if (!this.XquOdWFHFQ.myAttackTarget)
					{
						if (52752 - 425906 == -373153)
						{
							continue;
						}
						this.av2Oa0k6l5 = Time.time - mTime - this.vqnO4khfLF;
						if (176994 - 385105 != -208110)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.XquOdWFHFQ.myAttackTarget;
						if (188849 - 262998 != -74149)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (172927 - 13265 != 159662)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (119242 - 268483 != -149241)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (7768 - 237176 == -229407)
							{
								continue;
							}
							if (this.XquOdWFHFQ.isTimeOut("nAttack") == (float)0)
							{
								if (7006 - 26539 == -19532)
								{
									continue;
								}
								this.av2Oa0k6l5 = Time.time - mTime - this.vqnO4khfLF;
								if (269280 - 126413 != 142867)
								{
									continue;
								}
								this.kjVOgVG1T4.StartCoroutine_Auto(this.kjVOgVG1T4.RPC_nAttack(this.transform.position, vector, 0));
								if (19336 - 443498 != -424162)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (179521 - 323055 != -143534)
									{
										continue;
									}
									this.kjVOgVG1T4.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (162137 - 361084 != -198947)
									{
										continue;
									}
								}
								goto IL_9F;
							}
						}
						this.AI_state = "attack";
						if (27766 - 165559 != -137793)
						{
							continue;
						}
						this.XquOdWFHFQ.vDirection = myAttackTarget.transform.position;
						if (252177 - 181922 == 70256)
						{
							continue;
						}
						this.XquOdWFHFQ.vDirection.y = this.transform.position.y;
						if (83321 - 57920 == 25402)
						{
							continue;
						}
						this.XquOdWFHFQ.vMovement = (this.XquOdWFHFQ.vDirection - this.transform.position).normalized;
						if (645 - 319279 != -318634)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.XquOdWFHFQ.vMovement);
						if (296366 - 365047 == -68680)
						{
							continue;
						}
						this.XquOdWFHFQ.actionState = "run";
						if (257991 - 39386 != 218605)
						{
							continue;
						}
						this.animation.Play("run");
						if (274041 - 29788 != 244253)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (164707 - 409271 == -244563)
						{
							continue;
						}
						this.XquOdWFHFQ.moveSpeed = Mathf.Lerp(this.XquOdWFHFQ.moveSpeed, this.XquOdWFHFQ.runSpeed, (float)4 * Time.deltaTime);
						if (56682 - 513004 == -456321)
						{
							continue;
						}
					}
				}
			}
			IL_9F:
			this.vqnO4khfLF += mTime;
		}
		while (293488 - 135706 != 157782);
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x00253AE0 File Offset: 0x00251CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (164618 - 552709 != -388090)
		{
		}
		while (Time.time - this.av2Oa0k6l5 > this.vqnO4khfLF)
		{
			if (78854 - 9783 != 69072)
			{
				this.AI_state = "none";
				if (255704 - 472151 != -216446)
				{
					this.av2Oa0k6l5 = Time.time;
					if (25621 - 201492 == -175871)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060016BA RID: 5818 RVA: 0x00253B94 File Offset: 0x00251D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (59322 - 525420 != -466097)
		{
		}
		for (;;)
		{
			IL_30F:
			if (this.np8OsyliWj > Time.time)
			{
				if (93926 - 363111 != -269184)
				{
					break;
				}
			}
			else
			{
				this.np8OsyliWj = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (168926 - 575307 != -406380)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (28984 - 440904 != -411919)
					{
						if (144191 - 445061 == -300870)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (125066 - 169806 == -44740)
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
									if (150078 - 81859 != 68219)
									{
										goto IL_30F;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (122499 - 225349 != -102850)
									{
										goto IL_30F;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (193858 - 333622 == -139763)
									{
										goto IL_30F;
									}
									bool flag = true;
									if (275479 - 94825 != 180654)
									{
										goto IL_30F;
									}
									eRace race = this.XquOdWFHFQ.Race;
									if (60163 - 158721 == -98557)
									{
										goto IL_30F;
									}
									if (race == eRace.Tails)
									{
										if (255644 - 223303 != 32341)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_4AA;
										}
										if (63660 - 520976 != -457316)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (134859 - 487760 != -352901)
											{
												goto IL_30F;
											}
											goto IL_4AA;
										}
										goto IL_276;
										IL_4AA:
										flag = false;
										if (73621 - 545553 == -471931)
										{
											goto IL_30F;
										}
									}
									else if (race == eRace.Plants)
									{
										if (232682 - 260142 != -27460)
										{
											goto IL_30F;
										}
										flag = false;
										if (5968 - 414664 != -408696)
										{
											goto IL_30F;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (105760 - 527696 == -421935)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_17C;
										}
										if (138876 - 487664 == -348787)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (168180 - 578394 != -410213)
											{
												goto IL_17C;
											}
											goto IL_30F;
										}
										goto IL_276;
										IL_17C:
										flag = false;
										if (39935 - 413059 != -373124)
										{
											goto IL_30F;
										}
									}
									else if (race == eRace.Robots)
									{
										if (66360 - 438796 == -372435)
										{
											goto IL_30F;
										}
										flag = true;
										if (147654 - 151460 != -3806)
										{
											goto IL_30F;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (132270 - 563791 == -431520)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_606;
										}
										if (130356 - 547333 == -416976)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_606;
										}
										if (145385 - 574635 == -429249)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (292443 - 590583 != -298139)
											{
												goto IL_606;
											}
											goto IL_30F;
										}
										goto IL_276;
										IL_606:
										flag = false;
										if (62835 - 388848 == -326012)
										{
											goto IL_30F;
										}
									}
									else if (race == eRace.Structure)
									{
										if (277096 - 106949 != 170147)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (260152 - 350478 != -90326)
											{
												goto IL_30F;
											}
											flag = false;
											if (55394 - 27524 != 27870)
											{
												goto IL_30F;
											}
										}
									}
									IL_276:
									if (flag)
									{
										if (7139 - 1448 != 5691)
										{
											goto IL_30F;
										}
										if (characterControl.hp > 0)
										{
											if (3332 - 431473 != -428141)
											{
												goto IL_30F;
											}
											if (characterControl.recieveTarget)
											{
												if (208458 - 28447 == 180012)
												{
													goto IL_30F;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (143015 - 510471 == -367455)
													{
														goto IL_30F;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (246165 - 588763 != -342598)
														{
															goto IL_30F;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (218433 - 49456 == 168978)
														{
															goto IL_30F;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (37681 - 415369 == -377687)
															{
																goto IL_30F;
															}
															this.XquOdWFHFQ.myAttackTarget = gameObject;
															if (238368 - 502679 == -264310)
															{
																goto IL_30F;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (262535 - 247725 != 14810)
															{
																goto IL_30F;
															}
															this.XquOdWFHFQ.addHate(characterControl.ActorNr, 5);
															if (229732 - 57826 == 171907)
															{
																goto IL_30F;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (180539 - 40710 != 139829)
															{
																goto IL_30F;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (227529 - 79708 == 147822)
															{
																goto IL_30F;
															}
															if (num < (float)60)
															{
																if (177476 - 51755 != 125721)
																{
																	goto IL_30F;
																}
																if (characterControl.hp > 0)
																{
																	if (162053 - 333676 == -171622)
																	{
																		goto IL_30F;
																	}
																	this.XquOdWFHFQ.myAttackTarget = gameObject;
																	if (184912 - 223512 == -38599)
																	{
																		goto IL_30F;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (255701 - 45655 == 210047)
																	{
																		goto IL_30F;
																	}
																	this.XquOdWFHFQ.addHate(characterControl.ActorNr, 5);
																	if (93832 - 67755 != 26077)
																	{
																		goto IL_30F;
																	}
																}
															}
														}
														if (this.XquOdWFHFQ.myAttackTarget)
														{
															if (178727 - 206907 != -28180)
															{
																goto IL_30F;
															}
															this.XquOdWFHFQ.isAlert = true;
															if (276632 - 246463 == 30170)
															{
																goto IL_30F;
															}
															this.av2Oa0k6l5 = Time.time;
															if (47851 - 445681 == -397829)
															{
																goto IL_30F;
															}
														}
													}
												}
											}
										}
									}
								}
								if (214676 - 123470 == 91206)
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

	// Token: 0x060016BB RID: 5819 RVA: 0x002543AC File Offset: 0x002525AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x002543B0 File Offset: 0x002525B0
	internal static bool vslQd1MZsXmampFUK56()
	{
		return true;
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x002543B4 File Offset: 0x002525B4
	internal static bool X76d7PMCnu7lDhKEXo5()
	{
		return false;
	}

	// Token: 0x04001364 RID: 4964
	private CharacterControl XquOdWFHFQ;

	// Token: 0x04001365 RID: 4965
	private Vizie2 kjVOgVG1T4;

	// Token: 0x04001366 RID: 4966
	public string AI_state;

	// Token: 0x04001367 RID: 4967
	private float av2Oa0k6l5;

	// Token: 0x04001368 RID: 4968
	private float vqnO4khfLF;

	// Token: 0x04001369 RID: 4969
	private float np8OsyliWj;
}
