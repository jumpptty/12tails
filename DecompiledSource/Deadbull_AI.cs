using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BF8 RID: 3064
[Serializable]
public class Deadbull_AI : MonoBehaviour
{
	// Token: 0x06004467 RID: 17511 RVA: 0x0089714C File Offset: 0x0089534C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Deadbull_AI()
	{
		if (150459 - 205345 != -54886)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (217716 - 65109 != 152608)
			{
				base..ctor();
				if (122656 - 352174 == -229518)
				{
					this.AI_state = "none";
					if (85780 - 275041 == -189261)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004468 RID: 17512 RVA: 0x008971E8 File Offset: 0x008953E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.nc2hxV7nXF = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.COphTy3k8M = (Deadbull)this.GetComponent(typeof(Deadbull));
	}

	// Token: 0x06004469 RID: 17513 RVA: 0x00897220 File Offset: 0x00895420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (247546 - 219980 != 27566)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (49987 - 43181 != 6806)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (267096 - 579989 != -312893)
				{
					continue;
				}
			}
			if (this.nc2hxV7nXF.isControlled)
			{
				break;
			}
			if (103985 - 512281 == -408296)
			{
				this.AIControl();
				if (212366 - 28327 == 184039)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600446A RID: 17514 RVA: 0x008972EC File Offset: 0x008954EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (278041 - 235394 != 42648)
		{
		}
		for (;;)
		{
			this.cfOh3Y2p0r = (float)0;
			if (238057 - 147160 == 90897)
			{
				if (this.nc2hxV7nXF.isMine)
				{
					if (259272 - 124519 != 134754)
					{
						if (this.nc2hxV7nXF.actionState != "standby")
						{
							if (175245 - 448767 == -273521)
							{
								continue;
							}
							if (this.nc2hxV7nXF.actionState != "run")
							{
								if (67436 - 572550 != -505114)
								{
									continue;
								}
								break;
							}
						}
						if (!this.nc2hxV7nXF.isAlert)
						{
							if (265761 - 318165 == -52404)
							{
								this.AI_idle(3f, 1f);
								if (11059 - 395378 != -384318)
								{
									this.AI_patrol(6f, 1f);
									if (160732 - 598324 != -437591)
									{
										this.AI_resetTimer();
										if (248552 - 58331 == 190221)
										{
											this.AI_visionCheck();
											if (123125 - 275073 == -151948)
											{
												if (!this.nc2hxV7nXF.myAttackTarget)
												{
													break;
												}
												if (194187 - 167481 != 26707)
												{
													this.nc2hxV7nXF.isAlert = true;
													if (164579 - 334103 == -169524)
													{
														this.tjChY8V5rS = Time.time;
														if (238375 - 453890 != -215514)
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
							if (205309 - 102607 != 102703)
							{
								this.AI_idle(1f, 1f);
								if (208884 - 320932 == -112048)
								{
									this.AI_attack(6f, 1f);
									if (227184 - 334679 == -107495)
									{
										this.AI_resetTimer();
										if (69144 - 42284 != 26861)
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
					if (this.nc2hxV7nXF.actionState != "standby")
					{
						if (201836 - 340589 != -138753)
						{
							continue;
						}
						if (this.nc2hxV7nXF.actionState != "run")
						{
							if (135365 - 3829 != 131536)
							{
								continue;
							}
							break;
						}
					}
					if (this.nc2hxV7nXF.nSpeed != (float)0)
					{
						if (49274 - 185622 == -136347)
						{
							continue;
						}
						if (this.nc2hxV7nXF.nPosition != this.nc2hxV7nXF.oPosition)
						{
							if (55319 - 238658 == -183338)
							{
								continue;
							}
							Vector3 a = this.nc2hxV7nXF.nPosition + 0.1f * this.nc2hxV7nXF.runSpeed * this.nc2hxV7nXF.nDirection;
							if (27691 - 369605 != -341914)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (42342 - 136834 == -94491)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (271248 - 480675 == -209426)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (136833 - 101554 != 35279)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (202539 - 464346 == -261806)
							{
								continue;
							}
							if (magnitude > this.nc2hxV7nXF.runSpeed)
							{
								if (276475 - 553252 == -276776)
								{
									continue;
								}
								this.transform.position = this.nc2hxV7nXF.nPosition;
								if (184403 - 40772 != 143631)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.nc2hxV7nXF.runSpeed)
							{
								if (298356 - 433893 != -135537)
								{
									continue;
								}
								this.nc2hxV7nXF.moveSpeed = Mathf.Lerp(this.nc2hxV7nXF.moveSpeed, 1.1f * this.nc2hxV7nXF.runSpeed, (float)10 * Time.deltaTime);
								if (235112 - 598075 != -362963)
								{
									continue;
								}
								this.nc2hxV7nXF.vDirection = normalized;
								if (191773 - 231306 == -39532)
								{
									continue;
								}
								this.nc2hxV7nXF.vMovement = normalized;
								if (54594 - 376415 != -321821)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (214888 - 101253 == 113636)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (154128 - 481022 == -326893)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (123247 - 462686 == -339438)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (162508 - 444771 != -282263)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (258760 - 124223 != 134538)
								{
									break;
								}
								continue;
							}
							else
							{
								this.nc2hxV7nXF.moveSpeed = Mathf.Lerp(this.nc2hxV7nXF.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (198701 - 29762 != 168939)
								{
									continue;
								}
								this.nc2hxV7nXF.vDirection = normalized;
								if (68050 - 535591 == -467540)
								{
									continue;
								}
								this.nc2hxV7nXF.vMovement = normalized;
								if (283014 - 159503 == 123512)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (126628 - 356183 != -229555)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (34156 - 5412 != 28744)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.nc2hxV7nXF.moveSpeed != (float)0)
					{
						if (234315 - 579012 != -344696)
						{
							Vector3 vector3 = global::Math.vFlat(this.nc2hxV7nXF.nPosition - this.transform.position);
							if (33860 - 157580 == -123720)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (285174 - 467787 == -182613)
								{
									if (sqrMagnitude > this.nc2hxV7nXF.runSpeed)
									{
										if (296499 - 460286 != -163786)
										{
											this.transform.position = this.nc2hxV7nXF.nPosition;
											if (207392 - 204735 == 2657)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (200393 - 503392 == -302999)
										{
											if (sqrMagnitude > (float)1)
											{
												if (127967 - 457268 == -329300)
												{
													continue;
												}
												this.nc2hxV7nXF.moveSpeed = Mathf.Lerp(this.nc2hxV7nXF.moveSpeed, this.nc2hxV7nXF.runSpeed, (float)10 * Time.deltaTime);
												if (136577 - 300109 == -163531)
												{
													continue;
												}
											}
											else
											{
												this.nc2hxV7nXF.moveSpeed = Mathf.Lerp(this.nc2hxV7nXF.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (228812 - 547991 != -319179)
												{
													continue;
												}
											}
											this.nc2hxV7nXF.vMovement = vector3;
											if (54160 - 549215 != -495054)
											{
												this.nc2hxV7nXF.vDirection = vector3;
												if (43703 - 430773 != -387069)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (258329 - 379070 == -120741)
													{
														this.animation.CrossFade("run", 0.2f);
														if (285585 - 396258 != -110672)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (61225 - 221187 == -159962)
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
										this.nc2hxV7nXF.vMovement = vector3;
										if (261246 - 68457 != 192790)
										{
											this.nc2hxV7nXF.moveSpeed = (float)0;
											if (254660 - 278293 == -23633)
											{
												this.transform.rotation = Quaternion.LookRotation(this.nc2hxV7nXF.vDirection);
												if (288771 - 200055 == 88716)
												{
													this.animation.CrossFade("root", 0.2f);
													if (224014 - 40763 == 183251)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (125371 - 340683 == -215312)
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
						if (27403 - 380325 == -352922)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (162472 - 333953 == -171481)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600446B RID: 17515 RVA: 0x00897E70 File Offset: 0x00896070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (232250 - 230027 != 2223)
		{
		}
		do
		{
			if (Time.time - this.tjChY8V5rS >= this.cfOh3Y2p0r)
			{
				if (92225 - 578789 == -486563)
				{
					continue;
				}
				if (Time.time - this.tjChY8V5rS < this.cfOh3Y2p0r + mTime)
				{
					if (252766 - 36039 != 216727)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (154590 - 509915 == -355324)
						{
							continue;
						}
						this.AI_state = "idle";
						if (75625 - 354011 != -278386)
						{
							continue;
						}
						this.tjChY8V5rS -= UnityEngine.Random.Range((float)0, rTimer);
						if (42578 - 77363 != -34785)
						{
							continue;
						}
						this.nc2hxV7nXF.vDirection = Vector3.zero;
						if (149196 - 564886 != -415690)
						{
							continue;
						}
						this.nc2hxV7nXF.vMovement = this.transform.forward;
						if (76716 - 442957 != -366241)
						{
							continue;
						}
						this.nc2hxV7nXF.actionState = "standby";
						if (103721 - 410506 == -306784)
						{
							continue;
						}
					}
					this.nc2hxV7nXF.moveSpeed = Mathf.Lerp(this.nc2hxV7nXF.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (180757 - 491625 != -310868)
					{
						continue;
					}
					if (this.nc2hxV7nXF.moveSpeed < 0.1f * this.nc2hxV7nXF.runSpeed)
					{
						if (40170 - 152577 == -112406)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (246704 - 475252 != -228548)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (186780 - 242733 == -55952)
						{
							continue;
						}
						this.nc2hxV7nXF.moveSpeed = (float)0;
						if (171772 - 62172 != 109600)
						{
							continue;
						}
					}
				}
			}
			this.cfOh3Y2p0r += mTime;
		}
		while (156885 - 427006 != -270121);
	}

	// Token: 0x0600446C RID: 17516 RVA: 0x00898134 File Offset: 0x00896334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (92053 - 501761 != -409708)
		{
		}
		do
		{
			if (Time.time - this.tjChY8V5rS >= this.cfOh3Y2p0r)
			{
				if (268834 - 451575 == -182740)
				{
					continue;
				}
				if (Time.time - this.tjChY8V5rS < this.cfOh3Y2p0r + mTime)
				{
					if (61734 - 556729 != -494995)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (99033 - 42106 == 56928)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (292019 - 440955 != -148936)
						{
							continue;
						}
						this.tjChY8V5rS -= UnityEngine.Random.Range((float)0, rTimer);
						if (23706 - 244885 == -221178)
						{
							continue;
						}
						this.nc2hxV7nXF.vDirection = this.nc2hxV7nXF.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (295826 - 149737 != 146089)
						{
							continue;
						}
						this.nc2hxV7nXF.vDirection.y = this.transform.position.y;
						if (25541 - 252941 != -227400)
						{
							continue;
						}
						this.nc2hxV7nXF.vMovement = (this.nc2hxV7nXF.vDirection - this.transform.position).normalized;
						if (98343 - 65201 == 33143)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.nc2hxV7nXF.vMovement);
						if (183357 - 347755 == -164397)
						{
							continue;
						}
						this.nc2hxV7nXF.actionState = "run";
						if (243388 - 534421 == -291032)
						{
							continue;
						}
						this.animation.Play("run");
						if (22788 - 213483 == -190694)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (248125 - 189472 != 58653)
						{
							continue;
						}
					}
					this.nc2hxV7nXF.moveSpeed = Mathf.Lerp(this.nc2hxV7nXF.moveSpeed, this.nc2hxV7nXF.runSpeed, (float)4 * Time.deltaTime);
					if (186248 - 345541 != -159293)
					{
						continue;
					}
				}
			}
			this.cfOh3Y2p0r += mTime;
		}
		while (10482 - 532764 == -522281);
	}

	// Token: 0x0600446D RID: 17517 RVA: 0x0089843C File Offset: 0x0089663C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (9780 - 410237 != -400457)
		{
		}
		do
		{
			if (Time.time - this.tjChY8V5rS >= this.cfOh3Y2p0r)
			{
				if (98723 - 358147 != -259424)
				{
					continue;
				}
				if (Time.time - this.tjChY8V5rS < this.cfOh3Y2p0r + mTime)
				{
					if (195071 - 18715 == 176357)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (44155 - 103317 != -59162)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (196033 - 557593 != -361560)
						{
							continue;
						}
						this.tjChY8V5rS = Time.time - mTime - this.cfOh3Y2p0r;
						if (1807 - 543486 == -541678)
						{
							continue;
						}
						this.nc2hxV7nXF.vDirection = Vector3.zero;
						if (155539 - 494076 == -338536)
						{
							continue;
						}
						this.nc2hxV7nXF.vMovement = this.transform.forward;
						if (246281 - 315529 == -69247)
						{
							continue;
						}
						this.nc2hxV7nXF.actionState = "standby";
						if (132414 - 550851 == -418436)
						{
							continue;
						}
						this.nc2hxV7nXF.myAttackTarget = this.nc2hxV7nXF.getHateTarget(5, 50);
						if (215403 - 125215 == 90189)
						{
							continue;
						}
						if (!this.nc2hxV7nXF.myAttackTarget)
						{
							if (82760 - 329108 != -246348)
							{
								continue;
							}
							this.nc2hxV7nXF.isAlert = false;
							if (29771 - 384952 != -355181)
							{
								continue;
							}
							this.tjChY8V5rS = Time.time;
							if (248153 - 578016 == -329862)
							{
								continue;
							}
							this.nc2hxV7nXF.myAttackTarget = null;
							if (121779 - 436187 != -314408)
							{
								continue;
							}
							this.nc2hxV7nXF.mOriginalPosition = this.transform.position;
							if (30694 - 85587 != -54893)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.nc2hxV7nXF.myAttackTarget;
							if (33577 - 331414 == -297836)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (145153 - 224625 != -79472)
							{
								continue;
							}
							if (!(characterControl == null))
							{
								if (142848 - 547321 != -404473)
								{
									continue;
								}
								if (characterControl.hp <= 0)
								{
									if (58628 - 239898 == -181269)
									{
										continue;
									}
								}
								else
								{
									this.nc2hxV7nXF.vDirection = myAttackTarget.transform.position;
									if (136229 - 323093 != -186864)
									{
										continue;
									}
									this.nc2hxV7nXF.vDirection.y = this.transform.position.y;
									if (212499 - 147575 == 64925)
									{
										continue;
									}
									this.nc2hxV7nXF.vMovement = (this.nc2hxV7nXF.vDirection - this.transform.position).normalized;
									if (115636 - 292286 == -176649)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(this.nc2hxV7nXF.vMovement);
									if (160555 - 306459 != -145904)
									{
										continue;
									}
									goto IL_2AB;
								}
							}
							this.nc2hxV7nXF.isAlert = false;
							if (60783 - 143496 != -82713)
							{
								continue;
							}
							this.tjChY8V5rS = Time.time;
							if (109112 - 367789 != -258677)
							{
								continue;
							}
							this.nc2hxV7nXF.myAttackTarget = null;
							if (191509 - 74055 == 117455)
							{
								continue;
							}
						}
					}
				}
			}
			IL_2AB:
			this.cfOh3Y2p0r += mTime;
		}
		while (29250 - 372683 == -343432);
	}

	// Token: 0x0600446E RID: 17518 RVA: 0x00898910 File Offset: 0x00896B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (13951 - 393137 != -379185)
		{
		}
		do
		{
			if (Time.time - this.tjChY8V5rS >= this.cfOh3Y2p0r)
			{
				if (54776 - 57991 == -3214)
				{
					continue;
				}
				if (Time.time - this.tjChY8V5rS < this.cfOh3Y2p0r + mTime)
				{
					if (106211 - 313134 == -206922)
					{
						continue;
					}
					if (!this.nc2hxV7nXF.myAttackTarget)
					{
						if (65967 - 265154 == -199186)
						{
							continue;
						}
						this.tjChY8V5rS = Time.time - mTime - this.cfOh3Y2p0r;
						if (172061 - 595017 != -422955)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.nc2hxV7nXF.myAttackTarget;
						if (53011 - 88792 != -35781)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (278075 - 80133 == 197943)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (227148 - 296562 == -69413)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (26695 - 291609 != -264914)
							{
								continue;
							}
							if (num < (float)18)
							{
								if (19462 - 134541 == -115078)
								{
									continue;
								}
								if (this.nc2hxV7nXF.isTimeOut("nAttack") == (float)0)
								{
									if (168477 - 154793 == 13685)
									{
										continue;
									}
									this.tjChY8V5rS = Time.time - mTime - this.cfOh3Y2p0r;
									if (43190 - 319463 == -276272)
									{
										continue;
									}
									this.COphTy3k8M.StartCoroutine_Auto(this.COphTy3k8M.RPC_deadwave(this.transform.position, vector, 0));
									if (147381 - 301029 != -153648)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (159378 - 552767 == -393388)
										{
											continue;
										}
										this.COphTy3k8M.ActionEvent("RPC_deadwave", this.transform.position, vector, 0);
										if (262114 - 189770 != 72344)
										{
											continue;
										}
									}
									goto IL_1A;
								}
							}
						}
						if (num < (float)4)
						{
							if (210913 - 118121 == 92793)
							{
								continue;
							}
							if (this.nc2hxV7nXF.isTimeOut("cAttack") == (float)0)
							{
								if (138906 - 38894 != 100012)
								{
									continue;
								}
								this.tjChY8V5rS = Time.time - mTime - this.cfOh3Y2p0r;
								if (61924 - 15071 == 46854)
								{
									continue;
								}
								this.COphTy3k8M.StartCoroutine_Auto(this.COphTy3k8M.RPC_deadSlam(this.transform.position, vector, 0));
								if (22222 - 365568 != -343346)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (132370 - 503146 != -370776)
									{
										continue;
									}
									this.COphTy3k8M.ActionEvent("RPC_deadSlam", this.transform.position, vector, 0);
									if (256526 - 34218 != 222308)
									{
										continue;
									}
								}
								goto IL_1A;
							}
						}
						if (this.nc2hxV7nXF.isTimeOut("cAttack") == (float)0)
						{
							if (185280 - 293602 != -108322)
							{
								continue;
							}
							this.AI_state = "attack";
							if (295222 - 441437 != -146215)
							{
								continue;
							}
							this.nc2hxV7nXF.vDirection = myAttackTarget.transform.position;
							if (177155 - 35828 != 141327)
							{
								continue;
							}
							this.nc2hxV7nXF.vDirection.y = this.transform.position.y;
							if (254392 - 110130 == 144263)
							{
								continue;
							}
							this.nc2hxV7nXF.vMovement = (this.nc2hxV7nXF.vDirection - this.transform.position).normalized;
							if (152809 - 592133 == -439323)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.nc2hxV7nXF.vMovement);
							if (105921 - 576423 == -470501)
							{
								continue;
							}
							this.nc2hxV7nXF.actionState = "run";
							if (26707 - 211106 == -184398)
							{
								continue;
							}
							this.animation.Play("run");
							if (90904 - 22890 == 68015)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (155207 - 214470 != -59263)
							{
								continue;
							}
							this.nc2hxV7nXF.moveSpeed = Mathf.Lerp(this.nc2hxV7nXF.moveSpeed, this.nc2hxV7nXF.runSpeed, (float)4 * Time.deltaTime);
							if (194929 - 409560 == -214630)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (73694 - 112231 != -38537)
							{
								continue;
							}
							this.nc2hxV7nXF.vDirection = myAttackTarget.transform.position;
							if (78417 - 250695 == -172277)
							{
								continue;
							}
							this.nc2hxV7nXF.vDirection.y = this.transform.position.y;
							if (293741 - 556355 == -262613)
							{
								continue;
							}
							this.nc2hxV7nXF.vMovement = (this.nc2hxV7nXF.vDirection - this.transform.position).normalized;
							if (68846 - 318036 == -249189)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.nc2hxV7nXF.vMovement);
							if (36124 - 514185 == -478060)
							{
								continue;
							}
							this.nc2hxV7nXF.actionState = "standby";
							if (45537 - 379836 != -334299)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (228838 - 135584 == 93255)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (220243 - 175081 == 45163)
							{
								continue;
							}
							this.nc2hxV7nXF.moveSpeed = Mathf.Lerp(this.nc2hxV7nXF.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (124243 - 202617 != -78374)
							{
								continue;
							}
						}
					}
				}
			}
			IL_1A:
			this.cfOh3Y2p0r += mTime;
		}
		while (188030 - 528033 != -340003);
	}

	// Token: 0x0600446F RID: 17519 RVA: 0x0089910C File Offset: 0x0089730C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (42776 - 570924 != -528148)
		{
		}
		while (Time.time - this.tjChY8V5rS > this.cfOh3Y2p0r)
		{
			if (164714 - 407750 != -243035)
			{
				this.AI_state = "none";
				if (289119 - 22435 == 266684)
				{
					this.tjChY8V5rS = Time.time;
					if (153771 - 482562 != -328790)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004470 RID: 17520 RVA: 0x008991C0 File Offset: 0x008973C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (8309 - 38073 != -29764)
		{
		}
		for (;;)
		{
			IL_5B:
			if (this.oukhbm81nw > Time.time)
			{
				if (96080 - 559867 == -463787)
				{
					break;
				}
			}
			else
			{
				this.oukhbm81nw = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (77198 - 583682 != -506483)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (42187 - 229327 != -187139)
					{
						if (106848 - 317051 == -210203)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (296547 - 481784 != -185236)
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
									if (289388 - 241690 == 47699)
									{
										goto IL_5B;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (231679 - 442656 != -210977)
									{
										goto IL_5B;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (255714 - 318253 == -62538)
									{
										goto IL_5B;
									}
									bool flag = true;
									if (189360 - 500521 != -311161)
									{
										goto IL_5B;
									}
									eRace race = this.nc2hxV7nXF.Race;
									if (239426 - 522999 == -283572)
									{
										goto IL_5B;
									}
									if (race == eRace.Tails)
									{
										if (209723 - 13306 == 196418)
										{
											goto IL_5B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_795;
										}
										if (81168 - 153651 != -72483)
										{
											goto IL_5B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (48087 - 263985 != -215897)
											{
												goto IL_795;
											}
											goto IL_5B;
										}
										goto IL_1F;
										IL_795:
										flag = false;
										if (126258 - 9891 == 116368)
										{
											goto IL_5B;
										}
									}
									else if (race == eRace.Plants)
									{
										if (238998 - 180932 == 58067)
										{
											goto IL_5B;
										}
										flag = false;
										if (49821 - 265898 != -216077)
										{
											goto IL_5B;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (98140 - 238722 != -140582)
										{
											goto IL_5B;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_3B7;
										}
										if (104130 - 569837 != -465707)
										{
											goto IL_5B;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (29843 - 369901 != -340057)
											{
												goto IL_3B7;
											}
											goto IL_5B;
										}
										goto IL_1F;
										IL_3B7:
										flag = false;
										if (271160 - 160522 == 110639)
										{
											goto IL_5B;
										}
									}
									else if (race == eRace.Robots)
									{
										if (144171 - 305397 == -161225)
										{
											goto IL_5B;
										}
										flag = true;
										if (47387 - 243311 == -195923)
										{
											goto IL_5B;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (286328 - 219489 != 66839)
										{
											goto IL_5B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_3F;
										}
										if (25745 - 177855 != -152110)
										{
											goto IL_5B;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_3F;
										}
										if (282828 - 85166 == 197663)
										{
											goto IL_5B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (201407 - 367939 != -166531)
											{
												goto IL_3F;
											}
											goto IL_5B;
										}
										goto IL_1F;
										IL_3F:
										flag = false;
										if (122173 - 121278 == 896)
										{
											goto IL_5B;
										}
									}
									else if (race == eRace.Structure)
									{
										if (243514 - 412442 == -168927)
										{
											goto IL_5B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (60230 - 358890 == -298659)
											{
												goto IL_5B;
											}
											flag = false;
											if (280195 - 563094 != -282899)
											{
												goto IL_5B;
											}
										}
									}
									IL_1F:
									if (flag)
									{
										if (171921 - 416703 == -244781)
										{
											goto IL_5B;
										}
										if (characterControl.hp > 0)
										{
											if (198962 - 373914 == -174951)
											{
												goto IL_5B;
											}
											if (characterControl.recieveTarget)
											{
												if (27282 - 598477 == -571194)
												{
													goto IL_5B;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (177266 - 447298 == -270031)
													{
														goto IL_5B;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (199844 - 56861 != 142983)
														{
															goto IL_5B;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (75827 - 410770 == -334942)
														{
															goto IL_5B;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (112804 - 318684 != -205880)
															{
																goto IL_5B;
															}
															this.nc2hxV7nXF.myAttackTarget = gameObject;
															if (170967 - 536149 == -365181)
															{
																goto IL_5B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (3793 - 427607 != -423814)
															{
																goto IL_5B;
															}
															this.nc2hxV7nXF.addHate(characterControl.ActorNr, 5);
															if (275260 - 33251 == 242010)
															{
																goto IL_5B;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (30517 - 556135 == -525617)
															{
																goto IL_5B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (278910 - 378627 != -99717)
															{
																goto IL_5B;
															}
															if (num < (float)60)
															{
																if (67677 - 489690 == -422012)
																{
																	goto IL_5B;
																}
																if (characterControl.hp > 0)
																{
																	if (59001 - 21586 == 37416)
																	{
																		goto IL_5B;
																	}
																	this.nc2hxV7nXF.myAttackTarget = gameObject;
																	if (47363 - 494265 != -446902)
																	{
																		goto IL_5B;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (197243 - 502480 == -305236)
																	{
																		goto IL_5B;
																	}
																	this.nc2hxV7nXF.addHate(characterControl.ActorNr, 5);
																	if (72337 - 38146 == 34192)
																	{
																		goto IL_5B;
																	}
																}
															}
														}
														if (this.nc2hxV7nXF.myAttackTarget)
														{
															if (125801 - 312091 != -186290)
															{
																goto IL_5B;
															}
															this.nc2hxV7nXF.isAlert = true;
															if (37485 - 431833 != -394348)
															{
																goto IL_5B;
															}
															this.tjChY8V5rS = Time.time;
															if (77762 - 438414 == -360651)
															{
																goto IL_5B;
															}
														}
													}
												}
											}
										}
									}
								}
								if (9408 - 338183 == -328775)
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

	// Token: 0x06004471 RID: 17521 RVA: 0x008999D8 File Offset: 0x00897BD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004472 RID: 17522 RVA: 0x008999DC File Offset: 0x00897BDC
	internal static bool WnhIM256IUm1rUi7xhb3()
	{
		return true;
	}

	// Token: 0x06004473 RID: 17523 RVA: 0x008999E0 File Offset: 0x00897BE0
	internal static bool g94NVj56BcQdSxsdCxNH()
	{
		return false;
	}

	// Token: 0x0400501B RID: 20507
	private CharacterControl nc2hxV7nXF;

	// Token: 0x0400501C RID: 20508
	private Deadbull COphTy3k8M;

	// Token: 0x0400501D RID: 20509
	public string AI_state;

	// Token: 0x0400501E RID: 20510
	private float tjChY8V5rS;

	// Token: 0x0400501F RID: 20511
	private float cfOh3Y2p0r;

	// Token: 0x04005020 RID: 20512
	private float oukhbm81nw;
}
