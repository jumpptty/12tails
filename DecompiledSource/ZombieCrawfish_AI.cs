using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DEA RID: 3562
[Serializable]
public class ZombieCrawfish_AI : MonoBehaviour
{
	// Token: 0x0600507A RID: 20602 RVA: 0x009DCA5C File Offset: 0x009DAC5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZombieCrawfish_AI()
	{
		if (20565 - 513525 != -492959)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (248985 - 377115 != -128129)
			{
				base..ctor();
				if (73512 - 202159 == -128647)
				{
					this.AI_state = "none";
					if (295358 - 61988 == 233370)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600507B RID: 20603 RVA: 0x009DCAF8 File Offset: 0x009DACF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.V7WcQrWSwxJ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.VwycQxwaWsk = (ZombieCrawfish)this.GetComponent(typeof(ZombieCrawfish));
	}

	// Token: 0x0600507C RID: 20604 RVA: 0x009DCB30 File Offset: 0x009DAD30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (225882 - 43563 != 182319)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (71438 - 587519 != -516081)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (15464 - 372478 == -357013)
				{
					continue;
				}
			}
			if (this.V7WcQrWSwxJ.isControlled)
			{
				break;
			}
			if (269562 - 289238 != -19675)
			{
				this.AIControl();
				if (106323 - 324804 == -218481)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600507D RID: 20605 RVA: 0x009DCBFC File Offset: 0x009DADFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (124920 - 312420 != -187499)
		{
		}
		for (;;)
		{
			this.ISfcQYRhMxu = (float)0;
			if (291218 - 208570 == 82648)
			{
				if (this.V7WcQrWSwxJ.isMine)
				{
					if (200010 - 223868 == -23858)
					{
						if (this.V7WcQrWSwxJ.actionState != "standby")
						{
							if (106724 - 356806 != -250082)
							{
								continue;
							}
							if (this.V7WcQrWSwxJ.actionState != "run")
							{
								if (107245 - 345826 != -238581)
								{
									continue;
								}
								break;
							}
						}
						if (!this.V7WcQrWSwxJ.isAlert)
						{
							if (214413 - 481046 == -266633)
							{
								this.AI_idle(2f, 1f);
								if (290501 - 589127 != -298625)
								{
									this.AI_patrol(2f, 1f);
									if (145154 - 387350 == -242196)
									{
										this.AI_resetTimer();
										if (120328 - 566390 == -446062)
										{
											this.AI_visionCheck();
											if (15927 - 64767 != -48839)
											{
												if (!this.V7WcQrWSwxJ.myAttackTarget)
												{
													break;
												}
												if (154693 - 118676 == 36017)
												{
													this.V7WcQrWSwxJ.isAlert = true;
													if (26515 - 357914 != -331398)
													{
														this.w45cQTEd3mL = Time.time;
														if (105966 - 183486 == -77520)
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
							if (171454 - 406709 != -235254)
							{
								this.AI_idle(2f, 2f);
								if (194892 - 156401 == 38491)
								{
									this.AI_patrol(1f, 1f);
									if (258153 - 31980 == 226173)
									{
										this.AI_attack(10f, (float)0);
										if (74926 - 416458 == -341532)
										{
											this.AI_resetTimer();
											if (20232 - 189699 == -169467)
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
					if (this.V7WcQrWSwxJ.actionState != "standby")
					{
						if (106998 - 200310 == -93311)
						{
							continue;
						}
						if (this.V7WcQrWSwxJ.actionState != "run")
						{
							if (203336 - 317367 != -114031)
							{
								continue;
							}
							break;
						}
					}
					float num = this.V7WcQrWSwxJ.moveSpeed;
					if (99922 - 537737 != -437814)
					{
						float runSpeed = this.V7WcQrWSwxJ.runSpeed;
						if (112465 - 94526 != 17940)
						{
							Vector3 vector = default(Vector3);
							if (27695 - 327621 == -299926)
							{
								Vector3 vector2 = Vector3.zero;
								if (280031 - 544390 != -264358)
								{
									if ((this.V7WcQrWSwxJ.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (100093 - 53931 == 46163)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.V7WcQrWSwxJ.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (30162 - 642 != 29520)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (96879 - 384118 == -287238)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (222024 - 420818 != -198794)
											{
												continue;
											}
											num = (float)0;
											if (141667 - 276455 == -134787)
											{
												continue;
											}
											this.transform.position = this.V7WcQrWSwxJ.nPosition;
											if (13202 - 259402 != -246200)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (86572 - 231731 != -145159)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (229685 - 326067 == -96381)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (101731 - 248391 == -146659)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (100743 - 295730 == -194986)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (184360 - 275355 != -90995)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (178168 - 349396 == -171227)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (182008 - 184150 == -2141)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (113480 - 282954 == -169473)
											{
												continue;
											}
										}
									}
									this.V7WcQrWSwxJ.vMovement = vector2;
									if (62207 - 535637 == -473430)
									{
										this.V7WcQrWSwxJ.moveSpeed = num;
										if (229224 - 213619 != 15606)
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

	// Token: 0x0600507E RID: 20606 RVA: 0x009DD29C File Offset: 0x009DB49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (159026 - 475869 != -316843)
		{
		}
		do
		{
			if (Time.time - this.w45cQTEd3mL >= this.ISfcQYRhMxu)
			{
				if (232036 - 524103 == -292066)
				{
					continue;
				}
				if (Time.time - this.w45cQTEd3mL < this.ISfcQYRhMxu + mTime)
				{
					if (166839 - 152774 == 14066)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (138615 - 29741 == 108875)
						{
							continue;
						}
						this.AI_state = "idle";
						if (46369 - 51786 == -5416)
						{
							continue;
						}
						this.w45cQTEd3mL -= UnityEngine.Random.Range((float)0, rTimer);
						if (60287 - 356606 != -296319)
						{
							continue;
						}
						this.V7WcQrWSwxJ.vDirection = Vector3.zero;
						if (216513 - 61723 == 154791)
						{
							continue;
						}
						this.V7WcQrWSwxJ.vMovement = this.transform.forward;
						if (145893 - 498513 != -352620)
						{
							continue;
						}
						this.V7WcQrWSwxJ.actionState = "standby";
						if (48563 - 383899 == -335335)
						{
							continue;
						}
					}
					this.V7WcQrWSwxJ.moveSpeed = Mathf.Lerp(this.V7WcQrWSwxJ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (268255 - 174900 != 93355)
					{
						continue;
					}
					if (this.V7WcQrWSwxJ.moveSpeed < 0.1f * this.V7WcQrWSwxJ.runSpeed)
					{
						if (2444 - 403126 != -400682)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (195245 - 47277 == 147969)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (89933 - 123047 != -33114)
						{
							continue;
						}
						this.V7WcQrWSwxJ.moveSpeed = (float)0;
						if (188657 - 74904 == 113754)
						{
							continue;
						}
					}
				}
			}
			this.ISfcQYRhMxu += mTime;
		}
		while (201215 - 554104 == -352888);
	}

	// Token: 0x0600507F RID: 20607 RVA: 0x009DD560 File Offset: 0x009DB760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (125517 - 536898 != -411380)
		{
		}
		do
		{
			if (Time.time - this.w45cQTEd3mL >= this.ISfcQYRhMxu)
			{
				if (164495 - 137454 != 27041)
				{
					continue;
				}
				if (Time.time - this.w45cQTEd3mL < this.ISfcQYRhMxu + mTime)
				{
					if (285278 - 325834 == -40555)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (131707 - 591542 != -459835)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (178073 - 584220 == -406146)
						{
							continue;
						}
						this.w45cQTEd3mL -= UnityEngine.Random.Range((float)0, rTimer);
						if (5382 - 122764 == -117381)
						{
							continue;
						}
						this.V7WcQrWSwxJ.vDirection = this.V7WcQrWSwxJ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (220975 - 14602 != 206373)
						{
							continue;
						}
						this.V7WcQrWSwxJ.vDirection.y = this.transform.position.y;
						if (143113 - 153738 == -10624)
						{
							continue;
						}
						this.V7WcQrWSwxJ.vMovement = (this.V7WcQrWSwxJ.vDirection - this.transform.position).normalized;
						if (253221 - 224505 != 28716)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.V7WcQrWSwxJ.vMovement);
						if (123339 - 57163 != 66176)
						{
							continue;
						}
						this.V7WcQrWSwxJ.actionState = "run";
						if (170212 - 581568 == -411355)
						{
							continue;
						}
						this.animation.Play("run");
						if (10025 - 237414 != -227389)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (138744 - 34999 != 103745)
						{
							continue;
						}
					}
					this.V7WcQrWSwxJ.moveSpeed = Mathf.Lerp(this.V7WcQrWSwxJ.moveSpeed, this.V7WcQrWSwxJ.runSpeed, (float)4 * Time.deltaTime);
					if (49641 - 273205 == -223563)
					{
						continue;
					}
				}
			}
			this.ISfcQYRhMxu += mTime;
		}
		while (298792 - 129963 == 168830);
	}

	// Token: 0x06005080 RID: 20608 RVA: 0x009DD868 File Offset: 0x009DBA68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (1017 - 460216 != -459199)
		{
		}
		do
		{
			if (Time.time - this.w45cQTEd3mL >= this.ISfcQYRhMxu)
			{
				if (164931 - 293134 != -128203)
				{
					continue;
				}
				if (Time.time - this.w45cQTEd3mL < this.ISfcQYRhMxu + mTime)
				{
					if (287423 - 353687 == -66263)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (225119 - 40434 == 184686)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (103312 - 169605 != -66293)
						{
							continue;
						}
						this.w45cQTEd3mL = Time.time - mTime - this.ISfcQYRhMxu;
						if (216331 - 390354 == -174022)
						{
							continue;
						}
						this.V7WcQrWSwxJ.vDirection = Vector3.zero;
						if (20139 - 287990 == -267850)
						{
							continue;
						}
						this.V7WcQrWSwxJ.vMovement = this.transform.forward;
						if (121893 - 10077 != 111816)
						{
							continue;
						}
						this.V7WcQrWSwxJ.actionState = "standby";
						if (282760 - 433172 == -150411)
						{
							continue;
						}
						this.V7WcQrWSwxJ.myAttackTarget = this.V7WcQrWSwxJ.getHateTarget(5, 50);
						if (148768 - 452907 != -304139)
						{
							continue;
						}
						if (!this.V7WcQrWSwxJ.myAttackTarget)
						{
							if (27374 - 599758 != -572384)
							{
								continue;
							}
							this.V7WcQrWSwxJ.isAlert = false;
							if (48994 - 528591 != -479597)
							{
								continue;
							}
							this.w45cQTEd3mL = Time.time;
							if (24176 - 174961 == -150784)
							{
								continue;
							}
							this.V7WcQrWSwxJ.myAttackTarget = null;
							if (257481 - 460626 != -203145)
							{
								continue;
							}
							this.V7WcQrWSwxJ.mOriginalPosition = this.transform.position;
							if (276356 - 328226 != -51870)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.V7WcQrWSwxJ.myAttackTarget;
							if (78104 - 113157 == -35052)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (122230 - 61246 != 60984)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (160830 - 330623 == -169792)
								{
									continue;
								}
								this.V7WcQrWSwxJ.isAlert = false;
								if (153787 - 535200 != -381413)
								{
									continue;
								}
								this.w45cQTEd3mL = Time.time;
								if (54827 - 279517 != -224690)
								{
									continue;
								}
								this.V7WcQrWSwxJ.myAttackTarget = null;
								if (23912 - 263099 == -239186)
								{
									continue;
								}
							}
							else
							{
								this.V7WcQrWSwxJ.vDirection = myAttackTarget.transform.position;
								if (124553 - 150283 == -25729)
								{
									continue;
								}
								this.V7WcQrWSwxJ.vDirection.y = this.transform.position.y;
								if (237569 - 546455 == -308885)
								{
									continue;
								}
								this.V7WcQrWSwxJ.vMovement = (this.V7WcQrWSwxJ.vDirection - this.transform.position).normalized;
								if (253438 - 516470 == -263031)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.V7WcQrWSwxJ.vMovement);
								if (114332 - 366900 == -252567)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.ISfcQYRhMxu += mTime;
		}
		while (59592 - 492176 != -432584);
	}

	// Token: 0x06005081 RID: 20609 RVA: 0x009DDD18 File Offset: 0x009DBF18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (174936 - 437392 != -262456)
		{
		}
		do
		{
			if (Time.time - this.w45cQTEd3mL >= this.ISfcQYRhMxu)
			{
				if (257836 - 271594 != -13758)
				{
					continue;
				}
				if (Time.time - this.w45cQTEd3mL < this.ISfcQYRhMxu + mTime)
				{
					if (190391 - 201051 == -10659)
					{
						continue;
					}
					if (!this.V7WcQrWSwxJ.myAttackTarget)
					{
						if (74159 - 77440 == -3280)
						{
							continue;
						}
						this.w45cQTEd3mL = Time.time - mTime - this.ISfcQYRhMxu;
						if (281229 - 346434 != -65204)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.V7WcQrWSwxJ.myAttackTarget;
						if (56858 - 13421 != 43437)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (90283 - 213939 != -123656)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (138180 - 262306 != -124126)
						{
							continue;
						}
						if (170922 - 402885 == -231962)
						{
							continue;
						}
						if (characterControl)
						{
							if (90680 - 19446 != 71234)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (289185 - 414145 != -124960)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (32184 - 453173 != -420989)
						{
							continue;
						}
						if (num < (float)4)
						{
							if (290510 - 212870 != 77640)
							{
								continue;
							}
							if (this.V7WcQrWSwxJ.isTimeOut("cAttack") == (float)0)
							{
								if (41401 - 530136 == -488734)
								{
									continue;
								}
								this.w45cQTEd3mL = Time.time - mTime - this.ISfcQYRhMxu;
								if (32892 - 369744 == -336851)
								{
									continue;
								}
								this.VwycQxwaWsk.StartCoroutine_Auto(this.VwycQxwaWsk.RPC_cAttack(this.transform.position, vector, 0));
								if (29803 - 335073 != -305270)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (116642 - 36560 == 80083)
									{
										continue;
									}
									this.VwycQxwaWsk.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
									if (5586 - 110176 == -104589)
									{
										continue;
									}
								}
								goto IL_3E6;
							}
						}
						if (num < (float)12)
						{
							if (30723 - 144489 != -113766)
							{
								continue;
							}
							if (this.V7WcQrWSwxJ.isTimeOut("nAttack") == (float)0)
							{
								if (221735 - 63726 == 158010)
								{
									continue;
								}
								this.w45cQTEd3mL = Time.time - mTime - this.ISfcQYRhMxu;
								if (63266 - 148971 == -85704)
								{
									continue;
								}
								this.VwycQxwaWsk.StartCoroutine_Auto(this.VwycQxwaWsk.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
								if (101754 - 309682 != -207928)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (61897 - 468297 != -406400)
									{
										continue;
									}
									this.VwycQxwaWsk.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
									if (265276 - 209686 == 55591)
									{
										continue;
									}
								}
								goto IL_3E6;
							}
						}
						this.AI_state = "attack";
						if (223065 - 393805 != -170740)
						{
							continue;
						}
						if (num > (float)3)
						{
							if (190498 - 504186 == -313687)
							{
								continue;
							}
							this.V7WcQrWSwxJ.vDirection = myAttackTarget.transform.position;
							if (287541 - 110120 == 177422)
							{
								continue;
							}
							this.V7WcQrWSwxJ.vDirection.y = this.transform.position.y;
							if (276470 - 556992 == -280521)
							{
								continue;
							}
							this.V7WcQrWSwxJ.vMovement = (this.V7WcQrWSwxJ.vDirection - this.transform.position).normalized;
							if (70925 - 321454 == -250528)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.V7WcQrWSwxJ.vMovement);
							if (129229 - 294909 == -165679)
							{
								continue;
							}
							this.V7WcQrWSwxJ.actionState = "run";
							if (157676 - 520156 != -362480)
							{
								continue;
							}
							this.animation.CrossFade("run");
							if (1938 - 527203 == -525264)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (173543 - 396133 == -222589)
							{
								continue;
							}
							this.V7WcQrWSwxJ.moveSpeed = Mathf.Lerp(this.V7WcQrWSwxJ.moveSpeed, this.V7WcQrWSwxJ.runSpeed, (float)4 * Time.deltaTime);
							if (62868 - 57812 != 5056)
							{
								continue;
							}
						}
						else
						{
							this.V7WcQrWSwxJ.vDirection = myAttackTarget.transform.position;
							if (280501 - 574904 != -294403)
							{
								continue;
							}
							this.V7WcQrWSwxJ.vDirection.y = this.transform.position.y;
							if (252595 - 515483 != -262888)
							{
								continue;
							}
							this.V7WcQrWSwxJ.vMovement = (this.V7WcQrWSwxJ.vDirection - this.transform.position).normalized;
							if (149740 - 476144 == -326403)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.V7WcQrWSwxJ.vMovement);
							if (25930 - 196831 != -170901)
							{
								continue;
							}
							this.V7WcQrWSwxJ.actionState = "standby";
							if (82322 - 198951 != -116629)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (216360 - 6593 != 209767)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (154904 - 135376 == 19529)
							{
								continue;
							}
							this.V7WcQrWSwxJ.moveSpeed = Mathf.Lerp(this.V7WcQrWSwxJ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (133840 - 331214 != -197374)
							{
								continue;
							}
						}
					}
				}
			}
			IL_3E6:
			this.ISfcQYRhMxu += mTime;
		}
		while (265012 - 147228 != 117784);
	}

	// Token: 0x06005082 RID: 20610 RVA: 0x009DE594 File Offset: 0x009DC794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (289341 - 339190 != -49849)
		{
		}
		while (Time.time - this.w45cQTEd3mL > this.ISfcQYRhMxu)
		{
			if (179980 - 194666 != -14685)
			{
				this.AI_state = "none";
				if (178515 - 401084 != -222568)
				{
					this.w45cQTEd3mL = Time.time;
					if (245393 - 530239 == -284846)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005083 RID: 20611 RVA: 0x009DE648 File Offset: 0x009DC848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (169681 - 597741 != -428059)
		{
		}
		for (;;)
		{
			IL_136:
			if (this.wuKcQ3FAqNS > Time.time)
			{
				if (103562 - 345200 == -241638)
				{
					break;
				}
			}
			else
			{
				this.wuKcQ3FAqNS = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (105664 - 599582 != -493917)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (131721 - 292010 != -160288 && 9959 - 184974 != -175014)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (256834 - 107684 == 149150)
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
								if (184129 - 49645 == 134485)
								{
									goto IL_136;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (117271 - 11114 != 106157)
								{
									goto IL_136;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (163227 - 294711 == -131483)
								{
									goto IL_136;
								}
								bool flag = true;
								if (286623 - 119906 != 166717)
								{
									goto IL_136;
								}
								eRace race = this.V7WcQrWSwxJ.Race;
								if (150823 - 515309 != -364486)
								{
									goto IL_136;
								}
								if (race == eRace.Tails)
								{
									if (207609 - 412185 != -204576)
									{
										goto IL_136;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_47;
									}
									if (171049 - 241369 != -70320)
									{
										goto IL_136;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (182463 - 434568 != -252104)
										{
											goto IL_47;
										}
										goto IL_136;
									}
									goto IL_68;
									IL_47:
									flag = false;
									if (84712 - 183991 == -99278)
									{
										goto IL_136;
									}
								}
								else if (race == eRace.Plants)
								{
									if (135879 - 280655 != -144776)
									{
										goto IL_136;
									}
									flag = false;
									if (13827 - 525171 == -511343)
									{
										goto IL_136;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (205826 - 452342 == -246515)
									{
										goto IL_136;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_46D;
									}
									if (61961 - 315992 != -254031)
									{
										goto IL_136;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (100401 - 365978 != -265577)
										{
											goto IL_136;
										}
										goto IL_46D;
									}
									goto IL_68;
									IL_46D:
									flag = false;
									if (31852 - 91348 != -59496)
									{
										goto IL_136;
									}
								}
								else if (race == eRace.Robots)
								{
									if (59415 - 212323 != -152908)
									{
										goto IL_136;
									}
									flag = true;
									if (76604 - 545226 != -468622)
									{
										goto IL_136;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (273465 - 214025 == 59441)
									{
										goto IL_136;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_AE;
									}
									if (287846 - 466423 != -178577)
									{
										goto IL_136;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_AE;
									}
									if (213779 - 161417 == 52363)
									{
										goto IL_136;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (160284 - 207766 != -47482)
										{
											goto IL_136;
										}
										goto IL_AE;
									}
									goto IL_68;
									IL_AE:
									flag = false;
									if (248007 - 255258 != -7251)
									{
										goto IL_136;
									}
								}
								else if (race == eRace.Structure)
								{
									if (268417 - 92052 == 176366)
									{
										goto IL_136;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (15381 - 330039 == -314657)
										{
											goto IL_136;
										}
										flag = false;
										if (267457 - 546729 != -279272)
										{
											goto IL_136;
										}
									}
								}
								IL_68:
								if (flag)
								{
									if (198149 - 349488 != -151339)
									{
										goto IL_136;
									}
									if (characterControl.hp > 0)
									{
										if (140090 - 256714 == -116623)
										{
											goto IL_136;
										}
										if (characterControl.recieveTarget)
										{
											if (156216 - 398678 == -242461)
											{
												goto IL_136;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (100340 - 379408 != -279068)
												{
													goto IL_136;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (202936 - 16413 != 186523)
													{
														goto IL_136;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (119514 - 401049 != -281535)
													{
														goto IL_136;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (254987 - 221799 != 33188)
														{
															goto IL_136;
														}
														this.V7WcQrWSwxJ.myAttackTarget = gameObject;
														if (47480 - 165273 == -117792)
														{
															goto IL_136;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (39023 - 101091 == -62067)
														{
															goto IL_136;
														}
														this.V7WcQrWSwxJ.addHate(characterControl.ActorNr, 5);
														if (205254 - 550727 == -345472)
														{
															goto IL_136;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (233145 - 219155 != 13990)
														{
															goto IL_136;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (43844 - 282892 == -239047)
														{
															goto IL_136;
														}
														if (num < (float)60)
														{
															if (272799 - 370185 == -97385)
															{
																goto IL_136;
															}
															if (characterControl.hp > 0)
															{
																if (296496 - 211895 == 84602)
																{
																	goto IL_136;
																}
																this.V7WcQrWSwxJ.myAttackTarget = gameObject;
																if (287494 - 68258 == 219237)
																{
																	goto IL_136;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (1015 - 200211 == -199195)
																{
																	goto IL_136;
																}
																this.V7WcQrWSwxJ.addHate(characterControl.ActorNr, 5);
																if (85410 - 393335 != -307925)
																{
																	goto IL_136;
																}
															}
														}
													}
													if (this.V7WcQrWSwxJ.myAttackTarget)
													{
														if (24128 - 179448 != -155320)
														{
															goto IL_136;
														}
														this.V7WcQrWSwxJ.isAlert = true;
														if (37982 - 306284 == -268301)
														{
															goto IL_136;
														}
														this.w45cQTEd3mL = Time.time;
														if (256341 - 414431 == -158089)
														{
															goto IL_136;
														}
													}
												}
											}
										}
									}
								}
							}
							if (188091 - 335581 != -147489)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005084 RID: 20612 RVA: 0x009DEE60 File Offset: 0x009DD060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005085 RID: 20613 RVA: 0x009DEE64 File Offset: 0x009DD064
	internal static bool GMsuVn5Bjf0UsmJ6huWU()
	{
		return true;
	}

	// Token: 0x06005086 RID: 20614 RVA: 0x009DEE68 File Offset: 0x009DD068
	internal static bool BDrr8I5Bhxm0MRvQnteS()
	{
		return false;
	}

	// Token: 0x040059FF RID: 23039
	private CharacterControl V7WcQrWSwxJ;

	// Token: 0x04005A00 RID: 23040
	private ZombieCrawfish VwycQxwaWsk;

	// Token: 0x04005A01 RID: 23041
	public string AI_state;

	// Token: 0x04005A02 RID: 23042
	private float w45cQTEd3mL;

	// Token: 0x04005A03 RID: 23043
	private float ISfcQYRhMxu;

	// Token: 0x04005A04 RID: 23044
	private float wuKcQ3FAqNS;
}
