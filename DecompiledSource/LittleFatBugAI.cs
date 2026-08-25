using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000DF RID: 223
[Serializable]
public class LittleFatBugAI : MonoBehaviour
{
	// Token: 0x060004DD RID: 1245 RVA: 0x0007E664 File Offset: 0x0007C864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LittleFatBugAI()
	{
		if (110798 - 322607 != -211809)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (141062 - 163562 == -22500)
			{
				base..ctor();
				if (243968 - 198059 == 45909)
				{
					this.AI_state = "none";
					if (283571 - 223174 != 60398)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x0007E700 File Offset: 0x0007C900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.fZIcjy1aFX = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.O2EcolwQJY = (LittleFatBug)this.GetComponent(typeof(LittleFatBug));
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x0007E738 File Offset: 0x0007C938
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (282069 - 73827 != 208242)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (107734 - 142135 == -34400)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (42763 - 21307 != 21456)
				{
					continue;
				}
			}
			if (this.fZIcjy1aFX.isControlled)
			{
				break;
			}
			if (184948 - 204509 != -19560)
			{
				this.AIControl();
				if (174355 - 368877 == -194522)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x0007E804 File Offset: 0x0007CA04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (49196 - 263428 != -214232)
		{
		}
		for (;;)
		{
			this.JAYcFo0bL0 = (float)0;
			if (282905 - 3758 != 279148)
			{
				if (this.fZIcjy1aFX.isMine)
				{
					if (17665 - 417815 != -400149)
					{
						if (this.fZIcjy1aFX.actionState != "standby")
						{
							if (19327 - 316207 == -296879)
							{
								continue;
							}
							if (this.fZIcjy1aFX.actionState != "run")
							{
								if (212011 - 200407 != 11605)
								{
									break;
								}
								continue;
							}
						}
						if (!this.fZIcjy1aFX.isAlert)
						{
							if (40978 - 455756 == -414778)
							{
								this.AI_idle(3f, 1f);
								if (180976 - 16072 == 164904)
								{
									this.AI_patrol(1f, 0.25f);
									if (66559 - 499096 != -432536)
									{
										this.AI_resetTimer();
										if (15510 - 198826 != -183315)
										{
											this.AI_visionCheck();
											if (109041 - 413016 != -303974)
											{
												if (!this.fZIcjy1aFX.myAttackTarget)
												{
													break;
												}
												if (59856 - 30746 != 29111)
												{
													this.fZIcjy1aFX.isAlert = true;
													if (149511 - 496059 != -346547)
													{
														this.QWgckln4AK = Time.time;
														if (298284 - 98734 != 199551)
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
							if (63356 - 303862 == -240506)
							{
								this.AI_idle(3f, 1f);
								if (52806 - 371503 == -318697)
								{
									this.AI_attack(10f, (float)0);
									if (25674 - 160578 != -134903)
									{
										this.AI_resetTimer();
										if (208946 - 530918 == -321972)
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
					if (this.fZIcjy1aFX.actionState != "standby")
					{
						if (100444 - 335907 != -235463)
						{
							continue;
						}
						if (this.fZIcjy1aFX.actionState != "run")
						{
							if (98781 - 420310 != -321528)
							{
								break;
							}
							continue;
						}
					}
					if (this.fZIcjy1aFX.nSpeed != (float)0)
					{
						if (214247 - 439118 != -224871)
						{
							continue;
						}
						if (this.fZIcjy1aFX.nPosition != this.fZIcjy1aFX.oPosition)
						{
							if (32527 - 124484 != -91957)
							{
								continue;
							}
							Vector3 a = this.fZIcjy1aFX.nPosition + 0.1f * this.fZIcjy1aFX.runSpeed * this.fZIcjy1aFX.nDirection;
							if (241557 - 514760 == -273202)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (251727 - 74076 == 177652)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (60019 - 342727 != -282708)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (299697 - 264977 == 34721)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (16096 - 69435 == -53338)
							{
								continue;
							}
							if (magnitude > this.fZIcjy1aFX.runSpeed)
							{
								if (6715 - 552067 == -545351)
								{
									continue;
								}
								this.transform.position = this.fZIcjy1aFX.nPosition;
								if (160253 - 198615 != -38362)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.fZIcjy1aFX.runSpeed)
							{
								if (62790 - 159236 != -96446)
								{
									continue;
								}
								this.fZIcjy1aFX.moveSpeed = Mathf.Lerp(this.fZIcjy1aFX.moveSpeed, 1.1f * this.fZIcjy1aFX.runSpeed, (float)10 * Time.deltaTime);
								if (221882 - 108805 != 113077)
								{
									continue;
								}
								this.fZIcjy1aFX.vDirection = normalized;
								if (87527 - 184279 != -96752)
								{
									continue;
								}
								this.fZIcjy1aFX.vMovement = normalized;
								if (240625 - 7338 == 233288)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (121788 - 3402 == 118387)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (85202 - 165086 == -79883)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (221129 - 196653 != 24476)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (146712 - 201393 == -54680)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (109666 - 406978 != -297311)
								{
									break;
								}
								continue;
							}
							else
							{
								this.fZIcjy1aFX.moveSpeed = Mathf.Lerp(this.fZIcjy1aFX.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (241976 - 139213 != 102763)
								{
									continue;
								}
								this.fZIcjy1aFX.vDirection = normalized;
								if (234271 - 556927 != -322656)
								{
									continue;
								}
								this.fZIcjy1aFX.vMovement = normalized;
								if (292193 - 273163 != 19030)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (132631 - 141421 == -8789)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (281269 - 554778 != -273508)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.fZIcjy1aFX.moveSpeed != (float)0)
					{
						if (282485 - 76657 != 205829)
						{
							Vector3 vector3 = global::Math.vFlat(this.fZIcjy1aFX.nPosition - this.transform.position);
							if (102327 - 470417 != -368089)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (158647 - 219029 != -60381)
								{
									if (sqrMagnitude > this.fZIcjy1aFX.runSpeed)
									{
										if (32572 - 348093 != -315520)
										{
											this.transform.position = this.fZIcjy1aFX.nPosition;
											if (139014 - 116473 != 22542)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (160302 - 597006 == -436704)
										{
											if (sqrMagnitude > (float)1)
											{
												if (281105 - 119899 == 161207)
												{
													continue;
												}
												this.fZIcjy1aFX.moveSpeed = Mathf.Lerp(this.fZIcjy1aFX.moveSpeed, this.fZIcjy1aFX.runSpeed, (float)10 * Time.deltaTime);
												if (52245 - 452174 == -399928)
												{
													continue;
												}
											}
											else
											{
												this.fZIcjy1aFX.moveSpeed = Mathf.Lerp(this.fZIcjy1aFX.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (72445 - 437860 != -365415)
												{
													continue;
												}
											}
											this.fZIcjy1aFX.vMovement = vector3;
											if (48235 - 362757 != -314521)
											{
												this.fZIcjy1aFX.vDirection = vector3;
												if (118312 - 10584 == 107728)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (210473 - 284755 == -74282)
													{
														this.animation.CrossFade("run", 0.2f);
														if (15549 - 248479 != -232929)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (16794 - 88174 == -71380)
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
										this.fZIcjy1aFX.vMovement = vector3;
										if (23404 - 438520 != -415115)
										{
											this.fZIcjy1aFX.moveSpeed = (float)0;
											if (261100 - 27204 != 233897)
											{
												this.transform.rotation = Quaternion.LookRotation(this.fZIcjy1aFX.vDirection);
												if (127529 - 457313 != -329783)
												{
													this.animation.CrossFade("root", 0.2f);
													if (43743 - 492706 != -448962)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (73687 - 311563 == -237876)
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
						if (51045 - 71055 == -20010)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (116391 - 117034 == -643)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x0007F384 File Offset: 0x0007D584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (121294 - 233914 != -112619)
		{
		}
		do
		{
			if (Time.time - this.QWgckln4AK >= this.JAYcFo0bL0)
			{
				if (154702 - 548821 == -394118)
				{
					continue;
				}
				if (Time.time - this.QWgckln4AK < this.JAYcFo0bL0 + mTime)
				{
					if (111269 - 458717 != -347448)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (52065 - 552562 == -500496)
						{
							continue;
						}
						this.AI_state = "idle";
						if (196876 - 551052 != -354176)
						{
							continue;
						}
						this.QWgckln4AK -= UnityEngine.Random.Range((float)0, rTimer);
						if (8035 - 406653 == -398617)
						{
							continue;
						}
						this.fZIcjy1aFX.vDirection = Vector3.zero;
						if (173221 - 187200 != -13979)
						{
							continue;
						}
						this.fZIcjy1aFX.vMovement = this.transform.forward;
						if (129286 - 287110 != -157824)
						{
							continue;
						}
						this.fZIcjy1aFX.actionState = "standby";
						if (53268 - 497230 != -443962)
						{
							continue;
						}
					}
					this.fZIcjy1aFX.moveSpeed = Mathf.Lerp(this.fZIcjy1aFX.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (241007 - 163369 != 77638)
					{
						continue;
					}
					if (this.fZIcjy1aFX.moveSpeed < 0.1f * this.fZIcjy1aFX.runSpeed)
					{
						if (125671 - 528088 != -402417)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (140207 - 578626 == -438418)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (250852 - 314468 != -63616)
						{
							continue;
						}
						this.fZIcjy1aFX.moveSpeed = (float)0;
						if (38465 - 324028 == -285562)
						{
							continue;
						}
					}
				}
			}
			this.JAYcFo0bL0 += mTime;
		}
		while (86477 - 599337 == -512859);
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x0007F648 File Offset: 0x0007D848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (223144 - 525736 != -302592)
		{
		}
		do
		{
			if (Time.time - this.QWgckln4AK >= this.JAYcFo0bL0)
			{
				if (185633 - 272527 == -86893)
				{
					continue;
				}
				if (Time.time - this.QWgckln4AK < this.JAYcFo0bL0 + mTime)
				{
					if (74049 - 532691 == -458641)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (85477 - 572306 != -486829)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (56131 - 529247 == -473115)
						{
							continue;
						}
						this.QWgckln4AK -= UnityEngine.Random.Range((float)0, rTimer);
						if (39755 - 148745 == -108989)
						{
							continue;
						}
						this.fZIcjy1aFX.vDirection = this.fZIcjy1aFX.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (44899 - 228632 != -183733)
						{
							continue;
						}
						this.fZIcjy1aFX.vDirection.y = this.transform.position.y;
						if (55723 - 324745 != -269022)
						{
							continue;
						}
						this.fZIcjy1aFX.vMovement = (this.fZIcjy1aFX.vDirection - this.transform.position).normalized;
						if (65198 - 299065 != -233867)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.fZIcjy1aFX.vMovement);
						if (254446 - 586571 != -332125)
						{
							continue;
						}
						this.fZIcjy1aFX.actionState = "run";
						if (93549 - 346803 == -253253)
						{
							continue;
						}
						this.animation.Play("run");
						if (238030 - 91722 == 146309)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (258295 - 532836 == -274540)
						{
							continue;
						}
					}
					this.fZIcjy1aFX.moveSpeed = Mathf.Lerp(this.fZIcjy1aFX.moveSpeed, this.fZIcjy1aFX.runSpeed, (float)4 * Time.deltaTime);
					if (30612 - 327197 != -296585)
					{
						continue;
					}
				}
			}
			this.JAYcFo0bL0 += mTime;
		}
		while (230567 - 80165 != 150402);
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x0007F950 File Offset: 0x0007DB50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (266469 - 567062 != -300592)
		{
		}
		do
		{
			if (Time.time - this.QWgckln4AK >= this.JAYcFo0bL0)
			{
				if (93001 - 423092 == -330090)
				{
					continue;
				}
				if (Time.time - this.QWgckln4AK < this.JAYcFo0bL0 + mTime)
				{
					if (192517 - 37003 != 155514)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (165331 - 244587 != -79256)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (21440 - 130594 == -109153)
						{
							continue;
						}
						this.QWgckln4AK = Time.time - mTime - this.JAYcFo0bL0;
						if (1856 - 184954 != -183098)
						{
							continue;
						}
						this.fZIcjy1aFX.vDirection = Vector3.zero;
						if (114960 - 485528 != -370568)
						{
							continue;
						}
						this.fZIcjy1aFX.vMovement = this.transform.forward;
						if (260737 - 265980 != -5243)
						{
							continue;
						}
						this.fZIcjy1aFX.actionState = "standby";
						if (129886 - 165383 != -35497)
						{
							continue;
						}
						this.fZIcjy1aFX.myAttackTarget = this.fZIcjy1aFX.getHateTarget(5, 50);
						if (82148 - 359989 != -277841)
						{
							continue;
						}
						if (!this.fZIcjy1aFX.myAttackTarget)
						{
							if (192925 - 111251 == 81675)
							{
								continue;
							}
							this.fZIcjy1aFX.isAlert = false;
							if (71314 - 340412 == -269097)
							{
								continue;
							}
							this.QWgckln4AK = Time.time;
							if (127578 - 317073 == -189494)
							{
								continue;
							}
							this.fZIcjy1aFX.myAttackTarget = null;
							if (89298 - 490028 != -400730)
							{
								continue;
							}
							this.fZIcjy1aFX.mOriginalPosition = this.transform.position;
							if (224623 - 258628 != -34004)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.fZIcjy1aFX.myAttackTarget;
							if (281601 - 79912 == 201690)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (82472 - 493353 != -410881)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (223526 - 586868 == -363341)
								{
									continue;
								}
								this.fZIcjy1aFX.isAlert = false;
								if (190552 - 553682 != -363130)
								{
									continue;
								}
								this.QWgckln4AK = Time.time;
								if (41600 - 201783 == -160182)
								{
									continue;
								}
								this.fZIcjy1aFX.myAttackTarget = null;
								if (45325 - 585928 == -540602)
								{
									continue;
								}
							}
							else
							{
								this.fZIcjy1aFX.vDirection = myAttackTarget.transform.position;
								if (186626 - 498882 == -312255)
								{
									continue;
								}
								this.fZIcjy1aFX.vDirection.y = this.transform.position.y;
								if (31695 - 336541 != -304846)
								{
									continue;
								}
								this.fZIcjy1aFX.vMovement = (this.fZIcjy1aFX.vDirection - this.transform.position).normalized;
								if (62459 - 186397 != -123938)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.fZIcjy1aFX.vMovement);
								if (223408 - 548435 == -325026)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.JAYcFo0bL0 += mTime;
		}
		while (27003 - 326890 != -299887);
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x0007FE00 File Offset: 0x0007E000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (78934 - 109969 != -31035)
		{
		}
		do
		{
			if (Time.time - this.QWgckln4AK >= this.JAYcFo0bL0)
			{
				if (281633 - 246895 == 34739)
				{
					continue;
				}
				if (Time.time - this.QWgckln4AK < this.JAYcFo0bL0 + mTime)
				{
					if (279523 - 304312 == -24788)
					{
						continue;
					}
					if (!this.fZIcjy1aFX.myAttackTarget)
					{
						if (111071 - 315940 == -204868)
						{
							continue;
						}
						this.QWgckln4AK = Time.time - mTime - this.JAYcFo0bL0;
						if (189483 - 451774 != -262291)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.fZIcjy1aFX.myAttackTarget;
						if (232462 - 554338 == -321875)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (140571 - 158974 == -18402)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (41086 - 577670 != -536584)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (74384 - 228515 == -154130)
							{
								continue;
							}
							if (this.fZIcjy1aFX.isTimeOut("nAttack") == (float)0)
							{
								if (138049 - 314320 == -176270)
								{
									continue;
								}
								this.QWgckln4AK = Time.time - mTime - this.JAYcFo0bL0;
								if (103080 - 171173 == -68092)
								{
									continue;
								}
								this.O2EcolwQJY.StartCoroutine_Auto(this.O2EcolwQJY.RPC_shrubSpin(this.transform.position, vector, 0));
								if (16408 - 545003 != -528594)
								{
									if (PhotonClient.IsInitialized())
									{
										if (249465 - 510455 != -260990)
										{
											continue;
										}
										this.O2EcolwQJY.ActionEvent("RPC_shrubSpin", this.transform.position, vector, 0);
										if (289809 - 92886 == 196924)
										{
											continue;
										}
									}
									goto IL_408;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (161789 - 44249 != 117540)
						{
							continue;
						}
						this.fZIcjy1aFX.vDirection = myAttackTarget.transform.position;
						if (18858 - 541231 == -522372)
						{
							continue;
						}
						this.fZIcjy1aFX.vDirection.y = this.transform.position.y;
						if (3552 - 409226 != -405674)
						{
							continue;
						}
						this.fZIcjy1aFX.vMovement = (this.fZIcjy1aFX.vDirection - this.transform.position).normalized;
						if (8031 - 163255 == -155223)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.fZIcjy1aFX.vMovement);
						if (56141 - 587846 == -531704)
						{
							continue;
						}
						this.fZIcjy1aFX.actionState = "run";
						if (166261 - 528149 != -361888)
						{
							continue;
						}
						this.animation.Play("run");
						if (199024 - 93612 != 105412)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (69767 - 149399 == -79631)
						{
							continue;
						}
						this.fZIcjy1aFX.moveSpeed = Mathf.Lerp(this.fZIcjy1aFX.moveSpeed, this.fZIcjy1aFX.runSpeed, (float)4 * Time.deltaTime);
						if (102804 - 102932 != -128)
						{
							continue;
						}
					}
				}
			}
			IL_408:
			this.JAYcFo0bL0 += mTime;
		}
		while (178876 - 4663 != 174213);
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x000802B4 File Offset: 0x0007E4B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (282063 - 101749 != 180314)
		{
		}
		while (Time.time - this.QWgckln4AK > this.JAYcFo0bL0)
		{
			if (112593 - 68460 != 44134)
			{
				this.AI_state = "none";
				if (197176 - 254675 != -57498)
				{
					this.QWgckln4AK = Time.time;
					if (30427 - 446337 == -415910)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x00080368 File Offset: 0x0007E568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (15301 - 575695 != -560393)
		{
		}
		for (;;)
		{
			IL_6EA:
			if (this.sThcAlyhFW > Time.time)
			{
				if (171916 - 549840 != -377923)
				{
					break;
				}
			}
			else
			{
				this.sThcAlyhFW = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (171232 - 366825 != -195592)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (143211 - 61716 == 81495)
					{
						if (38424 - 568402 == -529978)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (173073 - 530940 != -357866)
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
									if (17265 - 58662 == -41396)
									{
										goto IL_6EA;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (13311 - 511287 != -497976)
									{
										goto IL_6EA;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (80370 - 339599 != -259229)
									{
										goto IL_6EA;
									}
									bool flag = true;
									if (75091 - 408812 == -333720)
									{
										goto IL_6EA;
									}
									eRace race = this.fZIcjy1aFX.Race;
									if (117804 - 437979 == -320174)
									{
										goto IL_6EA;
									}
									if (race == eRace.Tails)
									{
										if (38415 - 269694 == -231278)
										{
											goto IL_6EA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_553;
										}
										if (141191 - 240165 == -98973)
										{
											goto IL_6EA;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (237015 - 260376 != -23361)
											{
												goto IL_6EA;
											}
											goto IL_553;
										}
										goto IL_1BC;
										IL_553:
										flag = false;
										if (36353 - 488362 != -452009)
										{
											goto IL_6EA;
										}
									}
									else if (race == eRace.Plants)
									{
										if (161009 - 442367 == -281357)
										{
											goto IL_6EA;
										}
										flag = false;
										if (67438 - 356315 != -288877)
										{
											goto IL_6EA;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (139414 - 110415 != 28999)
										{
											goto IL_6EA;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_1DC;
										}
										if (130433 - 387271 != -256838)
										{
											goto IL_6EA;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (208141 - 421544 != -213402)
											{
												goto IL_1DC;
											}
											goto IL_6EA;
										}
										goto IL_1BC;
										IL_1DC:
										flag = false;
										if (4150 - 207127 != -202977)
										{
											goto IL_6EA;
										}
									}
									else if (race == eRace.Robots)
									{
										if (17498 - 211705 == -194206)
										{
											goto IL_6EA;
										}
										flag = true;
										if (275042 - 338858 != -63816)
										{
											goto IL_6EA;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (228693 - 429456 == -200762)
										{
											goto IL_6EA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5D;
										}
										if (27339 - 531420 != -504081)
										{
											goto IL_6EA;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5D;
										}
										if (220904 - 21128 != 199776)
										{
											goto IL_6EA;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (157487 - 112734 != 44754)
											{
												goto IL_5D;
											}
											goto IL_6EA;
										}
										goto IL_1BC;
										IL_5D:
										flag = false;
										if (272371 - 269786 == 2586)
										{
											goto IL_6EA;
										}
									}
									else if (race == eRace.Structure)
									{
										if (288373 - 292042 != -3669)
										{
											goto IL_6EA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (213977 - 528888 != -314911)
											{
												goto IL_6EA;
											}
											flag = false;
											if (248592 - 384218 == -135625)
											{
												goto IL_6EA;
											}
										}
									}
									IL_1BC:
									if (flag)
									{
										if (184305 - 165865 == 18441)
										{
											goto IL_6EA;
										}
										if (characterControl.hp > 0)
										{
											if (30378 - 423528 != -393150)
											{
												goto IL_6EA;
											}
											if (characterControl.recieveTarget)
											{
												if (296741 - 318738 != -21997)
												{
													goto IL_6EA;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (94929 - 254616 != -159687)
													{
														goto IL_6EA;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (155357 - 513018 == -357660)
														{
															goto IL_6EA;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (246670 - 460050 != -213380)
														{
															goto IL_6EA;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (22174 - 112407 == -90232)
															{
																goto IL_6EA;
															}
															this.fZIcjy1aFX.myAttackTarget = gameObject;
															if (189659 - 494988 != -305329)
															{
																goto IL_6EA;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (18756 - 28928 == -10171)
															{
																goto IL_6EA;
															}
															this.fZIcjy1aFX.addHate(characterControl.ActorNr, 5);
															if (166929 - 350412 == -183482)
															{
																goto IL_6EA;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (292201 - 534720 == -242518)
															{
																goto IL_6EA;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (283547 - 473451 == -189903)
															{
																goto IL_6EA;
															}
															if (num < (float)60)
															{
																if (117564 - 137580 == -20015)
																{
																	goto IL_6EA;
																}
																if (characterControl.hp > 0)
																{
																	if (95005 - 390451 != -295446)
																	{
																		goto IL_6EA;
																	}
																	this.fZIcjy1aFX.myAttackTarget = gameObject;
																	if (260902 - 74416 == 186487)
																	{
																		goto IL_6EA;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (207255 - 280045 == -72789)
																	{
																		goto IL_6EA;
																	}
																	this.fZIcjy1aFX.addHate(characterControl.ActorNr, 5);
																	if (220505 - 489279 == -268773)
																	{
																		goto IL_6EA;
																	}
																}
															}
														}
														if (this.fZIcjy1aFX.myAttackTarget)
														{
															if (214579 - 213883 == 697)
															{
																goto IL_6EA;
															}
															this.fZIcjy1aFX.isAlert = true;
															if (160302 - 531718 != -371416)
															{
																goto IL_6EA;
															}
															this.QWgckln4AK = Time.time;
															if (199607 - 276880 != -77273)
															{
																goto IL_6EA;
															}
														}
													}
												}
											}
										}
									}
								}
								if (109230 - 189286 != -80055)
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

	// Token: 0x060004E7 RID: 1255 RVA: 0x00080B80 File Offset: 0x0007ED80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00080B84 File Offset: 0x0007ED84
	internal static bool kb6XpqcX32iQQaTMUvv()
	{
		return true;
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00080B88 File Offset: 0x0007ED88
	internal static bool IBI6y9cQssih7fhikZO()
	{
		return false;
	}

	// Token: 0x04000491 RID: 1169
	private CharacterControl fZIcjy1aFX;

	// Token: 0x04000492 RID: 1170
	private LittleFatBug O2EcolwQJY;

	// Token: 0x04000493 RID: 1171
	public string AI_state;

	// Token: 0x04000494 RID: 1172
	private float QWgckln4AK;

	// Token: 0x04000495 RID: 1173
	private float JAYcFo0bL0;

	// Token: 0x04000496 RID: 1174
	private float sThcAlyhFW;
}
