using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B0B RID: 2827
[Serializable]
public class RangerRobot_AI : MonoBehaviour
{
	// Token: 0x06003E8B RID: 16011 RVA: 0x0080943C File Offset: 0x0080763C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RangerRobot_AI()
	{
		if (98694 - 11861 != 86833)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (178402 - 30918 == 147484)
			{
				base..ctor();
				if (106753 - 90055 != 16699)
				{
					this.AI_state = "none";
					if (107978 - 457709 == -349731)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003E8C RID: 16012 RVA: 0x008094D8 File Offset: 0x008076D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ppwyeZvVwD = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.ebpyIUJJl7 = (RangerRobot)this.GetComponent(typeof(RangerRobot));
	}

	// Token: 0x06003E8D RID: 16013 RVA: 0x00809510 File Offset: 0x00807710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (254450 - 412953 != -158502)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (261341 - 31470 == 229872)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (274152 - 110526 == 163627)
				{
					continue;
				}
			}
			if (this.ppwyeZvVwD.isControlled)
			{
				break;
			}
			if (34503 - 299377 != -264873)
			{
				this.AIControl();
				if (155037 - 42316 != 112722)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003E8E RID: 16014 RVA: 0x008095DC File Offset: 0x008077DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (263486 - 566048 != -302562)
		{
		}
		for (;;)
		{
			this.Ou4y60yr60 = (float)0;
			if (273546 - 424762 == -151216)
			{
				if (this.ppwyeZvVwD.isMine)
				{
					if (72814 - 446253 != -373438)
					{
						if (this.ppwyeZvVwD.actionState != "standby")
						{
							if (245196 - 587470 != -342274)
							{
								continue;
							}
							if (this.ppwyeZvVwD.actionState != "run")
							{
								if (84160 - 171595 != -87434)
								{
									break;
								}
								continue;
							}
						}
						if (!this.ppwyeZvVwD.isAlert)
						{
							if (227255 - 34796 == 192459)
							{
								this.AI_idle(3f, 1f);
								if (232316 - 230305 == 2011)
								{
									this.AI_patrol(1f, 0.25f);
									if (128913 - 210763 == -81850)
									{
										this.AI_resetTimer();
										if (77420 - 75996 != 1425)
										{
											this.AI_visionCheck();
											if (99295 - 345902 != -246606)
											{
												if (!this.ppwyeZvVwD.myAttackTarget)
												{
													break;
												}
												if (61326 - 443818 == -382492)
												{
													this.ppwyeZvVwD.isAlert = true;
													if (20029 - 307054 == -287025)
													{
														this.DfIyJtuQch = Time.time;
														if (40249 - 335472 == -295223)
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
							if (46455 - 453884 != -407428)
							{
								this.AI_idle(1f, 1f);
								if (78064 - 164668 != -86603)
								{
									this.AI_attack(10f, (float)0);
									if (119269 - 480343 == -361074)
									{
										this.AI_resetTimer();
										if (283026 - 380209 == -97183)
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
					if (this.ppwyeZvVwD.actionState != "standby")
					{
						if (30520 - 476089 != -445569)
						{
							continue;
						}
						if (this.ppwyeZvVwD.actionState != "run")
						{
							if (253141 - 363059 != -109918)
							{
								continue;
							}
							break;
						}
					}
					float num = this.ppwyeZvVwD.moveSpeed;
					if (272196 - 104957 != 167240)
					{
						float runSpeed = this.ppwyeZvVwD.runSpeed;
						if (1500 - 508192 == -506692)
						{
							Vector3 vector = default(Vector3);
							if (141470 - 164936 == -23466)
							{
								Vector3 vector2 = Vector3.zero;
								if (206995 - 31449 != 175547)
								{
									if ((this.ppwyeZvVwD.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (53549 - 325004 != -271455)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.ppwyeZvVwD.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (147729 - 517251 != -369522)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (12240 - 574482 == -562241)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (294091 - 297335 != -3244)
											{
												continue;
											}
											num = (float)0;
											if (213971 - 535367 == -321395)
											{
												continue;
											}
											this.transform.position = this.ppwyeZvVwD.nPosition;
											if (225094 - 453849 == -228754)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (213090 - 488206 == -275115)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (55516 - 95910 == -40393)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (236965 - 64355 != 172610)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (84192 - 80170 == 4023)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (4128 - 311461 != -307333)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (178976 - 425931 == -246954)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (219340 - 571546 == -352205)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (86525 - 411419 != -324894)
											{
												continue;
											}
										}
									}
									this.ppwyeZvVwD.vMovement = vector2;
									if (181249 - 297423 == -116174)
									{
										this.ppwyeZvVwD.moveSpeed = num;
										if (195762 - 247691 == -51929)
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

	// Token: 0x06003E8F RID: 16015 RVA: 0x00809C54 File Offset: 0x00807E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (37581 - 359406 != -321825)
		{
		}
		do
		{
			if (Time.time - this.DfIyJtuQch >= this.Ou4y60yr60)
			{
				if (105855 - 574063 == -468207)
				{
					continue;
				}
				if (Time.time - this.DfIyJtuQch < this.Ou4y60yr60 + mTime)
				{
					if (75398 - 449149 != -373751)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (183358 - 251669 == -68310)
						{
							continue;
						}
						this.AI_state = "idle";
						if (252355 - 569459 != -317104)
						{
							continue;
						}
						this.DfIyJtuQch -= UnityEngine.Random.Range((float)0, rTimer);
						if (239698 - 386394 != -146696)
						{
							continue;
						}
						this.ppwyeZvVwD.vDirection = Vector3.zero;
						if (36721 - 324372 != -287651)
						{
							continue;
						}
						this.ppwyeZvVwD.vMovement = this.transform.forward;
						if (116752 - 481597 != -364845)
						{
							continue;
						}
						this.ppwyeZvVwD.actionState = "standby";
						if (249229 - 447925 == -198695)
						{
							continue;
						}
					}
					this.ppwyeZvVwD.moveSpeed = Mathf.Lerp(this.ppwyeZvVwD.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (104214 - 536841 != -432627)
					{
						continue;
					}
					if (this.ppwyeZvVwD.moveSpeed < 0.1f * this.ppwyeZvVwD.runSpeed)
					{
						if (8751 - 117119 != -108368)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (72829 - 316424 != -243595)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (231809 - 503949 == -272139)
						{
							continue;
						}
						this.ppwyeZvVwD.moveSpeed = (float)0;
						if (192583 - 68937 == 123647)
						{
							continue;
						}
					}
				}
			}
			this.Ou4y60yr60 += mTime;
		}
		while (299443 - 545446 != -246003);
	}

	// Token: 0x06003E90 RID: 16016 RVA: 0x00809F18 File Offset: 0x00808118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (235336 - 90771 != 144565)
		{
		}
		do
		{
			if (Time.time - this.DfIyJtuQch >= this.Ou4y60yr60)
			{
				if (71882 - 234743 != -162861)
				{
					continue;
				}
				if (Time.time - this.DfIyJtuQch < this.Ou4y60yr60 + mTime)
				{
					if (256458 - 189641 != 66817)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (278508 - 578313 == -299804)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (55032 - 325717 != -270685)
						{
							continue;
						}
						this.DfIyJtuQch -= UnityEngine.Random.Range((float)0, rTimer);
						if (187611 - 145817 != 41794)
						{
							continue;
						}
						this.ppwyeZvVwD.vDirection = this.ppwyeZvVwD.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (39222 - 157936 == -118713)
						{
							continue;
						}
						this.ppwyeZvVwD.vDirection.y = this.transform.position.y;
						if (50036 - 476528 != -426492)
						{
							continue;
						}
						this.ppwyeZvVwD.vMovement = (this.ppwyeZvVwD.vDirection - this.transform.position).normalized;
						if (158321 - 134967 != 23354)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.ppwyeZvVwD.vMovement);
						if (39344 - 247886 == -208541)
						{
							continue;
						}
						this.ppwyeZvVwD.actionState = "run";
						if (228640 - 273706 != -45066)
						{
							continue;
						}
						this.animation.Play("run");
						if (100775 - 182408 == -81632)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (131080 - 482803 == -351722)
						{
							continue;
						}
					}
					this.ppwyeZvVwD.moveSpeed = Mathf.Lerp(this.ppwyeZvVwD.moveSpeed, this.ppwyeZvVwD.runSpeed, (float)4 * Time.deltaTime);
					if (156855 - 121779 == 35077)
					{
						continue;
					}
				}
			}
			this.Ou4y60yr60 += mTime;
		}
		while (296471 - 424242 == -127770);
	}

	// Token: 0x06003E91 RID: 16017 RVA: 0x0080A220 File Offset: 0x00808420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (222149 - 216039 != 6111)
		{
		}
		do
		{
			if (Time.time - this.DfIyJtuQch >= this.Ou4y60yr60)
			{
				if (49933 - 74739 == -24805)
				{
					continue;
				}
				if (Time.time - this.DfIyJtuQch < this.Ou4y60yr60 + mTime)
				{
					if (274782 - 76442 == 198341)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (126699 - 224476 == -97776)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (195826 - 87712 != 108114)
						{
							continue;
						}
						this.DfIyJtuQch = Time.time - mTime - this.Ou4y60yr60;
						if (85320 - 128344 == -43023)
						{
							continue;
						}
						this.ppwyeZvVwD.vDirection = Vector3.zero;
						if (200888 - 352140 == -151251)
						{
							continue;
						}
						this.ppwyeZvVwD.vMovement = this.transform.forward;
						if (183889 - 189318 != -5429)
						{
							continue;
						}
						this.ppwyeZvVwD.actionState = "standby";
						if (203967 - 244884 == -40916)
						{
							continue;
						}
						this.ppwyeZvVwD.myAttackTarget = this.ppwyeZvVwD.getHateClosestTarget(50);
						if (94839 - 349030 == -254190)
						{
							continue;
						}
						if (!this.ppwyeZvVwD.myAttackTarget)
						{
							if (223136 - 374112 == -150975)
							{
								continue;
							}
							this.ppwyeZvVwD.isAlert = false;
							if (168525 - 279570 == -111044)
							{
								continue;
							}
							this.DfIyJtuQch = Time.time;
							if (176676 - 228841 == -52164)
							{
								continue;
							}
							this.ppwyeZvVwD.myAttackTarget = null;
							if (151714 - 32399 == 119316)
							{
								continue;
							}
							this.ppwyeZvVwD.mOriginalPosition = this.transform.position;
							if (98896 - 243306 != -144409)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.ppwyeZvVwD.myAttackTarget;
							if (35784 - 247254 != -211470)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (297801 - 401480 == -103678)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (210576 - 414850 == -204273)
								{
									continue;
								}
								this.ppwyeZvVwD.isAlert = false;
								if (234010 - 593599 == -359588)
								{
									continue;
								}
								this.DfIyJtuQch = Time.time;
								if (8737 - 157861 == -149123)
								{
									continue;
								}
								this.ppwyeZvVwD.myAttackTarget = null;
								if (256647 - 282455 != -25808)
								{
									continue;
								}
							}
							else
							{
								this.ppwyeZvVwD.vDirection = myAttackTarget.transform.position;
								if (257021 - 28390 != 228631)
								{
									continue;
								}
								this.ppwyeZvVwD.vDirection.y = this.transform.position.y;
								if (49874 - 244813 == -194938)
								{
									continue;
								}
								this.ppwyeZvVwD.vMovement = (this.ppwyeZvVwD.vDirection - this.transform.position).normalized;
								if (164439 - 522747 != -358308)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ppwyeZvVwD.vMovement);
								if (257970 - 456232 == -198261)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Ou4y60yr60 += mTime;
		}
		while (215373 - 284960 == -69586);
	}

	// Token: 0x06003E92 RID: 16018 RVA: 0x0080A6D0 File Offset: 0x008088D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (94000 - 45665 != 48336)
		{
		}
		do
		{
			if (Time.time - this.DfIyJtuQch >= this.Ou4y60yr60)
			{
				if (284971 - 52326 == 232646)
				{
					continue;
				}
				if (Time.time - this.DfIyJtuQch < this.Ou4y60yr60 + mTime)
				{
					if (238562 - 188644 != 49918)
					{
						continue;
					}
					if (!this.ppwyeZvVwD.myAttackTarget)
					{
						if (164647 - 489333 != -324686)
						{
							continue;
						}
						this.DfIyJtuQch = Time.time - mTime - this.Ou4y60yr60;
						if (130826 - 67456 != 63371)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.ppwyeZvVwD.myAttackTarget;
						if (289859 - 311771 != -21912)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (234786 - 590081 != -355295)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (76082 - 165480 == -89397)
						{
							continue;
						}
						int tID = 0;
						if (129196 - 181477 != -52281)
						{
							continue;
						}
						if (characterControl)
						{
							if (14767 - 360066 != -345299)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (174556 - 202033 != -27477)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (130250 - 224635 != -94385)
						{
							continue;
						}
						if (num < (float)40)
						{
							if (92382 - 28813 != 63569)
							{
								continue;
							}
							if ((float)this.ppwyeZvVwD.hp < 0.4f * (float)this.ppwyeZvVwD.mhp)
							{
								if (158547 - 230468 != -71921)
								{
									continue;
								}
								if (this.ppwyeZvVwD.sp >= 80)
								{
									if (265380 - 142274 == 123107)
									{
										continue;
									}
									if (this.ppwyeZvVwD.isTimeOut("galaxyBlade") == (float)0)
									{
										if (64112 - 297245 != -233133)
										{
											continue;
										}
										this.DfIyJtuQch = Time.time - mTime - this.Ou4y60yr60;
										if (30458 - 305215 != -274757)
										{
											continue;
										}
										this.ebpyIUJJl7.StartCoroutine_Auto(this.ebpyIUJJl7.RPC_galaxyBlade(this.transform.position, vector, tID));
										if (280786 - 59316 != 221471)
										{
											if (PhotonClient.IsInitialized())
											{
												if (237522 - 563048 == -325525)
												{
													continue;
												}
												this.ebpyIUJJl7.ActionEvent("RPC_galaxyBlade", this.transform.position, vector, tID);
												if (268805 - 196434 != 72371)
												{
													continue;
												}
											}
											goto IL_43C;
										}
										continue;
									}
								}
							}
						}
						if (num > (float)6)
						{
							if (240248 - 80413 == 159836)
							{
								continue;
							}
							if ((float)this.ppwyeZvVwD.hp < 0.8f * (float)this.ppwyeZvVwD.mhp)
							{
								if (110006 - 320014 == -210007)
								{
									continue;
								}
								if (this.ppwyeZvVwD.isTimeOut("clawPincer") == (float)0)
								{
									if (24619 - 417183 != -392564)
									{
										continue;
									}
									this.DfIyJtuQch = Time.time - mTime - this.Ou4y60yr60;
									if (154079 - 314023 == -159943)
									{
										continue;
									}
									this.ebpyIUJJl7.StartCoroutine_Auto(this.ebpyIUJJl7.RPC_clawPincer(this.transform.position, vector, tID));
									if (38158 - 289877 != -251719)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (143833 - 86255 == 57579)
										{
											continue;
										}
										this.ebpyIUJJl7.ActionEvent("RPC_clawPincer", this.transform.position, vector, tID);
										if (177626 - 25427 == 152200)
										{
											continue;
										}
									}
									goto IL_43C;
								}
							}
						}
						if (num < (float)5)
						{
							if (243280 - 450773 == -207492)
							{
								continue;
							}
							if ((float)this.ppwyeZvVwD.hp < 0.9f * (float)this.ppwyeZvVwD.mhp)
							{
								if (222523 - 434623 == -212099)
								{
									continue;
								}
								if (this.ppwyeZvVwD.isTimeOut("drillPunch") == (float)0)
								{
									if (66701 - 366083 != -299382)
									{
										continue;
									}
									this.DfIyJtuQch = Time.time - mTime - this.Ou4y60yr60;
									if (131825 - 39260 != 92565)
									{
										continue;
									}
									this.ebpyIUJJl7.StartCoroutine_Auto(this.ebpyIUJJl7.RPC_drillPunch(this.transform.position, vector, tID));
									if (270684 - 287849 != -17164)
									{
										if (PhotonClient.IsInitialized())
										{
											if (27617 - 111959 == -84341)
											{
												continue;
											}
											this.ebpyIUJJl7.ActionEvent("RPC_drillPunch", this.transform.position, vector, tID);
											if (229060 - 217687 != 11373)
											{
												continue;
											}
										}
										goto IL_43C;
									}
									continue;
								}
							}
						}
						if (num < (float)2)
						{
							if (210284 - 471975 == -261690)
							{
								continue;
							}
							if (this.ppwyeZvVwD.isTimeOut("nAttack") == (float)0)
							{
								if (88169 - 269233 != -181064)
								{
									continue;
								}
								this.DfIyJtuQch = Time.time - mTime - this.Ou4y60yr60;
								if (213596 - 62702 != 150894)
								{
									continue;
								}
								if (UnityEngine.Random.Range(0, 100) < 60)
								{
									if (59249 - 381266 != -322017)
									{
										continue;
									}
									this.ebpyIUJJl7.StartCoroutine_Auto(this.ebpyIUJJl7.RPC_nAttack1(this.transform.position, vector, 0));
									if (194107 - 556322 != -362215)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (215465 - 36376 == 179090)
										{
											continue;
										}
										this.ebpyIUJJl7.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
										if (191359 - 592120 == -400760)
										{
											continue;
										}
									}
								}
								else
								{
									this.ebpyIUJJl7.StartCoroutine_Auto(this.ebpyIUJJl7.RPC_nAttack2(this.transform.position, vector, 0));
									if (80608 - 445561 != -364953)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (12083 - 15855 == -3771)
										{
											continue;
										}
										this.ebpyIUJJl7.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
										if (123501 - 72089 == 51413)
										{
											continue;
										}
									}
								}
								goto IL_43C;
							}
						}
						this.AI_state = "attack";
						if (266469 - 339080 == -72610)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (292607 - 7677 != 284930)
							{
								continue;
							}
							this.ppwyeZvVwD.vDirection = myAttackTarget.transform.position;
							if (284066 - 308855 != -24789)
							{
								continue;
							}
							this.ppwyeZvVwD.vDirection.y = this.transform.position.y;
							if (48365 - 530952 != -482587)
							{
								continue;
							}
							this.ppwyeZvVwD.vMovement = (this.ppwyeZvVwD.vDirection - this.transform.position).normalized;
							if (160533 - 330427 == -169893)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.ppwyeZvVwD.vMovement);
							if (51062 - 173441 == -122378)
							{
								continue;
							}
							this.ppwyeZvVwD.actionState = "run";
							if (141355 - 461497 == -320141)
							{
								continue;
							}
							this.animation.Play("run");
							if (131040 - 550039 != -418999)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (275559 - 48554 == 227006)
							{
								continue;
							}
							this.ppwyeZvVwD.moveSpeed = Mathf.Lerp(this.ppwyeZvVwD.moveSpeed, this.ppwyeZvVwD.runSpeed, (float)4 * Time.deltaTime);
							if (42677 - 545952 != -503275)
							{
								continue;
							}
						}
						else
						{
							this.ppwyeZvVwD.vDirection = myAttackTarget.transform.position;
							if (30623 - 239313 == -208689)
							{
								continue;
							}
							this.ppwyeZvVwD.vDirection.y = this.transform.position.y;
							if (91692 - 213540 == -121847)
							{
								continue;
							}
							this.ppwyeZvVwD.vMovement = (this.ppwyeZvVwD.vDirection - this.transform.position).normalized;
							if (222561 - 3945 != 218616)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.ppwyeZvVwD.vMovement);
							if (140049 - 343039 != -202990)
							{
								continue;
							}
							this.ppwyeZvVwD.actionState = "standby";
							if (62735 - 188684 != -125949)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (213328 - 467442 == -254113)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (24220 - 571273 != -547053)
							{
								continue;
							}
							this.ppwyeZvVwD.moveSpeed = Mathf.Lerp(this.ppwyeZvVwD.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (187102 - 517869 != -330767)
							{
								continue;
							}
						}
					}
				}
			}
			IL_43C:
			this.Ou4y60yr60 += mTime;
		}
		while (242582 - 60263 != 182319);
	}

	// Token: 0x06003E93 RID: 16019 RVA: 0x0080B2F4 File Offset: 0x008094F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (69904 - 487912 != -418007)
		{
		}
		while (Time.time - this.DfIyJtuQch > this.Ou4y60yr60)
		{
			if (97930 - 221723 == -123793)
			{
				this.AI_state = "none";
				if (211970 - 262149 == -50179)
				{
					this.DfIyJtuQch = Time.time;
					if (223157 - 18340 == 204817)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003E94 RID: 16020 RVA: 0x0080B3A8 File Offset: 0x008095A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (57778 - 363863 != -306085)
		{
		}
		for (;;)
		{
			IL_4B3:
			if (this.w3xytrKPDN > Time.time)
			{
				if (98444 - 25373 != 73072)
				{
					break;
				}
			}
			else
			{
				this.w3xytrKPDN = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (192989 - 592624 != -399634)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (58963 - 560134 != -501170)
					{
						if (216041 - 32273 == 183768)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (117253 - 12741 != 104513)
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
									if (17051 - 56635 == -39583)
									{
										goto IL_4B3;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (146842 - 49842 == 97001)
									{
										goto IL_4B3;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (190383 - 411795 == -221411)
									{
										goto IL_4B3;
									}
									bool flag = true;
									if (109327 - 189423 != -80096)
									{
										goto IL_4B3;
									}
									eRace race = this.ppwyeZvVwD.Race;
									if (158328 - 331884 == -173555)
									{
										goto IL_4B3;
									}
									if (race == eRace.Tails)
									{
										if (48949 - 274168 == -225218)
										{
											goto IL_4B3;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_278;
										}
										if (178878 - 357420 == -178541)
										{
											goto IL_4B3;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (293363 - 164409 != 128955)
											{
												goto IL_278;
											}
											goto IL_4B3;
										}
										goto IL_299;
										IL_278:
										flag = false;
										if (220897 - 576019 == -355121)
										{
											goto IL_4B3;
										}
									}
									else if (race == eRace.Plants)
									{
										if (254031 - 359745 != -105714)
										{
											goto IL_4B3;
										}
										flag = false;
										if (270017 - 36012 == 234006)
										{
											goto IL_4B3;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (124237 - 516103 == -391865)
										{
											goto IL_4B3;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_1A0;
										}
										if (104871 - 105217 == -345)
										{
											goto IL_4B3;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (78810 - 580606 != -501795)
											{
												goto IL_1A0;
											}
											goto IL_4B3;
										}
										goto IL_299;
										IL_1A0:
										flag = false;
										if (268719 - 386865 != -118146)
										{
											goto IL_4B3;
										}
									}
									else if (race == eRace.Robots)
									{
										if (239977 - 217368 != 22609)
										{
											goto IL_4B3;
										}
										flag = true;
										if (66727 - 474314 == -407586)
										{
											goto IL_4B3;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (2018 - 449598 == -447579)
										{
											goto IL_4B3;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_6B3;
										}
										if (13316 - 480461 != -467145)
										{
											goto IL_4B3;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_6B3;
										}
										if (299702 - 68311 != 231391)
										{
											goto IL_4B3;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (47792 - 111020 != -63227)
											{
												goto IL_6B3;
											}
											goto IL_4B3;
										}
										goto IL_299;
										IL_6B3:
										flag = false;
										if (238550 - 389141 == -150590)
										{
											goto IL_4B3;
										}
									}
									else if (race == eRace.Structure)
									{
										if (277378 - 392616 == -115237)
										{
											goto IL_4B3;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (277291 - 344312 == -67020)
											{
												goto IL_4B3;
											}
											flag = false;
											if (274653 - 593008 == -318354)
											{
												goto IL_4B3;
											}
										}
									}
									IL_299:
									if (flag)
									{
										if (289599 - 550337 == -260737)
										{
											goto IL_4B3;
										}
										if (characterControl.hp > 0)
										{
											if (173778 - 231376 == -57597)
											{
												goto IL_4B3;
											}
											if (characterControl.recieveTarget)
											{
												if (286122 - 126057 != 160065)
												{
													goto IL_4B3;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (1538 - 430551 != -429013)
													{
														goto IL_4B3;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (134422 - 567925 != -433503)
														{
															goto IL_4B3;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (122105 - 445220 != -323115)
														{
															goto IL_4B3;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (43245 - 520694 != -477449)
															{
																goto IL_4B3;
															}
															this.ppwyeZvVwD.myAttackTarget = gameObject;
															if (176888 - 327089 != -150201)
															{
																goto IL_4B3;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (85792 - 187978 == -102185)
															{
																goto IL_4B3;
															}
															this.ppwyeZvVwD.addHate(characterControl.ActorNr, 5);
															if (83304 - 381341 != -298037)
															{
																goto IL_4B3;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (153519 - 274649 == -121129)
															{
																goto IL_4B3;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (103311 - 517256 == -413944)
															{
																goto IL_4B3;
															}
															if (num < (float)60)
															{
																if (42536 - 137778 != -95242)
																{
																	goto IL_4B3;
																}
																if (characterControl.hp > 0)
																{
																	if (211315 - 562759 == -351443)
																	{
																		goto IL_4B3;
																	}
																	this.ppwyeZvVwD.myAttackTarget = gameObject;
																	if (106623 - 286665 != -180042)
																	{
																		goto IL_4B3;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (212585 - 28992 == 183594)
																	{
																		goto IL_4B3;
																	}
																	this.ppwyeZvVwD.addHate(characterControl.ActorNr, 5);
																	if (17771 - 590132 == -572360)
																	{
																		goto IL_4B3;
																	}
																}
															}
														}
														if (this.ppwyeZvVwD.myAttackTarget)
														{
															if (55925 - 266407 == -210481)
															{
																goto IL_4B3;
															}
															this.ppwyeZvVwD.isAlert = true;
															if (273479 - 33822 != 239657)
															{
																goto IL_4B3;
															}
															this.DfIyJtuQch = Time.time;
															if (75602 - 213871 == -138268)
															{
																goto IL_4B3;
															}
														}
													}
												}
											}
										}
									}
								}
								if (85376 - 50326 != 35051)
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

	// Token: 0x06003E95 RID: 16021 RVA: 0x0080BBC0 File Offset: 0x00809DC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003E96 RID: 16022 RVA: 0x0080BBC4 File Offset: 0x00809DC4
	internal static bool GpWCxD5mXnEOdauyV6lp()
	{
		return true;
	}

	// Token: 0x06003E97 RID: 16023 RVA: 0x0080BBC8 File Offset: 0x00809DC8
	internal static bool lmUDYl5mQ3ehi2eR52AM()
	{
		return false;
	}

	// Token: 0x04004BBA RID: 19386
	private CharacterControl ppwyeZvVwD;

	// Token: 0x04004BBB RID: 19387
	private RangerRobot ebpyIUJJl7;

	// Token: 0x04004BBC RID: 19388
	public string AI_state;

	// Token: 0x04004BBD RID: 19389
	private float DfIyJtuQch;

	// Token: 0x04004BBE RID: 19390
	private float Ou4y60yr60;

	// Token: 0x04004BBF RID: 19391
	private float w3xytrKPDN;
}
