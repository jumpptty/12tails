using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000285 RID: 645
[Serializable]
public class ChromeKnight_AI : MonoBehaviour
{
	// Token: 0x06000EBD RID: 3773 RVA: 0x0017585C File Offset: 0x00173A5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChromeKnight_AI()
	{
		if (54113 - 288555 != -234441)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (145270 - 148189 == -2919)
			{
				base..ctor();
				if (187905 - 255097 == -67192)
				{
					this.AI_state = "none";
					if (235343 - 407241 == -171898)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x001758F8 File Offset: 0x00173AF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.qoyJpTIsuc = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.njGJRuX4l2 = (ChromeKnight)this.GetComponent(typeof(ChromeKnight));
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00175930 File Offset: 0x00173B30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (102658 - 195189 != -92531)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (57947 - 428581 == -370633)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (130734 - 471378 != -340644)
				{
					continue;
				}
			}
			if (this.qoyJpTIsuc.isControlled)
			{
				break;
			}
			if (68010 - 108917 == -40907)
			{
				this.AIControl();
				if (126540 - 60501 != 66040)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x001759FC File Offset: 0x00173BFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (149247 - 567961 != -418713)
		{
		}
		for (;;)
		{
			this.Ds8JxxXSI2 = (float)0;
			if (179917 - 138409 == 41508)
			{
				if (this.qoyJpTIsuc.isMine)
				{
					if (191535 - 17203 != 174333)
					{
						if (this.qoyJpTIsuc.actionState != "standby")
						{
							if (144206 - 195967 == -51760)
							{
								continue;
							}
							if (this.qoyJpTIsuc.actionState != "run")
							{
								if (292146 - 566831 != -274685)
								{
									continue;
								}
								break;
							}
						}
						if (!this.qoyJpTIsuc.isAlert)
						{
							if (250346 - 184968 != 65379)
							{
								this.AI_idle(5f, 2f);
								if (55231 - 567960 != -512728)
								{
									this.AI_patrol(1f, 0.25f);
									if (40 - 85154 == -85114)
									{
										this.AI_resetTimer();
										if (197336 - 558209 != -360872)
										{
											this.AI_visionCheck();
											if (80060 - 474776 != -394715)
											{
												if (!this.qoyJpTIsuc.myAttackTarget)
												{
													break;
												}
												if (55380 - 528406 != -473025)
												{
													this.qoyJpTIsuc.isAlert = true;
													if (231682 - 589508 == -357826)
													{
														this.aoiJr6LeHt = Time.time;
														if (161944 - 494899 == -332955)
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
							if (64622 - 129866 != -65243)
							{
								this.AI_idle(2f, 1f);
								if (230153 - 500490 == -270337)
								{
									this.AI_attack(10f, (float)0);
									if (298963 - 54190 == 244773)
									{
										this.AI_resetTimer();
										if (72281 - 94573 == -22292)
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
					if (this.qoyJpTIsuc.actionState != "standby")
					{
						if (165027 - 453056 != -288029)
						{
							continue;
						}
						if (this.qoyJpTIsuc.actionState != "run")
						{
							if (72661 - 89527 != -16865)
							{
								break;
							}
							continue;
						}
					}
					float num = this.qoyJpTIsuc.moveSpeed;
					if (15914 - 137864 == -121950)
					{
						float runSpeed = this.qoyJpTIsuc.runSpeed;
						if (54839 - 318259 == -263420)
						{
							Vector3 vector = default(Vector3);
							if (54205 - 222816 != -168610)
							{
								Vector3 vector2 = Vector3.zero;
								if (3573 - 89359 == -85786)
								{
									if ((this.qoyJpTIsuc.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (160653 - 561033 != -400380)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.qoyJpTIsuc.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (136456 - 164894 != -28438)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (139146 - 320174 == -181027)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (127799 - 570480 == -442680)
											{
												continue;
											}
											num = (float)0;
											if (153747 - 371617 != -217870)
											{
												continue;
											}
											this.transform.position = this.qoyJpTIsuc.nPosition;
											if (88191 - 219974 == -131782)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (76564 - 12454 != 64110)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (138090 - 362132 != -224042)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (33945 - 515569 == -481623)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (188730 - 2768 == 185963)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (29573 - 524415 == -494841)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (72800 - 462293 != -389493)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (227184 - 9276 == 217909)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (290642 - 488964 == -198321)
											{
												continue;
											}
										}
									}
									this.qoyJpTIsuc.vMovement = vector2;
									if (78543 - 391506 != -312962)
									{
										this.qoyJpTIsuc.moveSpeed = num;
										if (105913 - 94427 != 11487)
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

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00176074 File Offset: 0x00174274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (201143 - 398417 != -197274)
		{
		}
		do
		{
			if (Time.time - this.aoiJr6LeHt >= this.Ds8JxxXSI2)
			{
				if (5117 - 324587 == -319469)
				{
					continue;
				}
				if (Time.time - this.aoiJr6LeHt < this.Ds8JxxXSI2 + mTime)
				{
					if (67358 - 492765 != -425407)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (210302 - 223123 != -12821)
						{
							continue;
						}
						this.AI_state = "idle";
						if (287891 - 555464 == -267572)
						{
							continue;
						}
						this.aoiJr6LeHt -= UnityEngine.Random.Range((float)0, rTimer);
						if (63026 - 353491 == -290464)
						{
							continue;
						}
						this.qoyJpTIsuc.vDirection = Vector3.zero;
						if (174837 - 531146 != -356309)
						{
							continue;
						}
						this.qoyJpTIsuc.vMovement = this.transform.forward;
						if (149343 - 242892 != -93549)
						{
							continue;
						}
						this.qoyJpTIsuc.actionState = "standby";
						if (1807 - 588316 == -586508)
						{
							continue;
						}
					}
					this.qoyJpTIsuc.moveSpeed = Mathf.Lerp(this.qoyJpTIsuc.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (120950 - 116537 != 4413)
					{
						continue;
					}
					if (this.qoyJpTIsuc.moveSpeed < 0.1f * this.qoyJpTIsuc.runSpeed)
					{
						if (79461 - 349827 != -270366)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (23868 - 83166 == -59297)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (128763 - 326550 != -197787)
						{
							continue;
						}
						this.qoyJpTIsuc.moveSpeed = (float)0;
						if (127995 - 14649 == 113347)
						{
							continue;
						}
					}
				}
			}
			this.Ds8JxxXSI2 += mTime;
		}
		while (91623 - 535075 == -443451);
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00176338 File Offset: 0x00174538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (298604 - 317807 != -19203)
		{
		}
		do
		{
			if (Time.time - this.aoiJr6LeHt >= this.Ds8JxxXSI2)
			{
				if (147777 - 581822 != -434045)
				{
					continue;
				}
				if (Time.time - this.aoiJr6LeHt < this.Ds8JxxXSI2 + mTime)
				{
					if (195886 - 32140 != 163746)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (226954 - 92077 == 134878)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (206390 - 91512 != 114878)
						{
							continue;
						}
						this.aoiJr6LeHt -= UnityEngine.Random.Range((float)0, rTimer);
						if (266452 - 392721 == -126268)
						{
							continue;
						}
						this.qoyJpTIsuc.vDirection = this.qoyJpTIsuc.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (270180 - 599382 != -329202)
						{
							continue;
						}
						this.qoyJpTIsuc.vDirection.y = this.transform.position.y;
						if (136231 - 590883 == -454651)
						{
							continue;
						}
						this.qoyJpTIsuc.vMovement = (this.qoyJpTIsuc.vDirection - this.transform.position).normalized;
						if (41299 - 197900 != -156601)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.qoyJpTIsuc.vMovement);
						if (130625 - 382316 == -251690)
						{
							continue;
						}
						this.qoyJpTIsuc.actionState = "run";
						if (169009 - 162619 != 6390)
						{
							continue;
						}
						this.animation.Play("run");
						if (221427 - 550211 == -328783)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (259927 - 591982 != -332055)
						{
							continue;
						}
					}
					this.qoyJpTIsuc.moveSpeed = Mathf.Lerp(this.qoyJpTIsuc.moveSpeed, this.qoyJpTIsuc.runSpeed, (float)4 * Time.deltaTime);
					if (41805 - 335838 == -294032)
					{
						continue;
					}
				}
			}
			this.Ds8JxxXSI2 += mTime;
		}
		while (7999 - 168624 != -160625);
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00176640 File Offset: 0x00174840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (231139 - 13343 != 217796)
		{
		}
		do
		{
			if (Time.time - this.aoiJr6LeHt >= this.Ds8JxxXSI2)
			{
				if (246064 - 593806 == -347741)
				{
					continue;
				}
				if (Time.time - this.aoiJr6LeHt < this.Ds8JxxXSI2 + mTime)
				{
					if (124402 - 277946 == -153543)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (221092 - 353781 == -132688)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (89460 - 380117 == -290656)
						{
							continue;
						}
						this.aoiJr6LeHt = Time.time - mTime - this.Ds8JxxXSI2;
						if (22107 - 545598 != -523491)
						{
							continue;
						}
						this.qoyJpTIsuc.vDirection = Vector3.zero;
						if (20187 - 545198 == -525010)
						{
							continue;
						}
						this.qoyJpTIsuc.vMovement = this.transform.forward;
						if (86677 - 356042 == -269364)
						{
							continue;
						}
						this.qoyJpTIsuc.actionState = "standby";
						if (257192 - 85099 != 172093)
						{
							continue;
						}
						this.qoyJpTIsuc.myAttackTarget = this.qoyJpTIsuc.getRandomHateTarget(50);
						if (293625 - 539031 != -245406)
						{
							continue;
						}
						if (!this.qoyJpTIsuc.myAttackTarget)
						{
							if (206644 - 115448 != 91196)
							{
								continue;
							}
							this.qoyJpTIsuc.isAlert = false;
							if (42845 - 87094 == -44248)
							{
								continue;
							}
							this.aoiJr6LeHt = Time.time;
							if (1624 - 213149 == -211524)
							{
								continue;
							}
							this.qoyJpTIsuc.myAttackTarget = null;
							if (253263 - 483005 == -229741)
							{
								continue;
							}
							this.qoyJpTIsuc.mOriginalPosition = this.transform.position;
							if (155912 - 407182 != -251269)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.qoyJpTIsuc.myAttackTarget;
							if (269771 - 149778 != 119993)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (152840 - 450099 == -297258)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (173624 - 273680 != -100056)
								{
									continue;
								}
								this.qoyJpTIsuc.isAlert = false;
								if (54992 - 594220 != -539228)
								{
									continue;
								}
								this.aoiJr6LeHt = Time.time;
								if (70608 - 285520 != -214912)
								{
									continue;
								}
								this.qoyJpTIsuc.myAttackTarget = null;
								if (160552 - 415051 != -254499)
								{
									continue;
								}
							}
							else
							{
								this.qoyJpTIsuc.vDirection = myAttackTarget.transform.position;
								if (89824 - 482552 == -392727)
								{
									continue;
								}
								this.qoyJpTIsuc.vDirection.y = this.transform.position.y;
								if (128126 - 50548 != 77578)
								{
									continue;
								}
								this.qoyJpTIsuc.vMovement = (this.qoyJpTIsuc.vDirection - this.transform.position).normalized;
								if (69053 - 587246 != -518193)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.qoyJpTIsuc.vMovement);
								if (101897 - 25648 == 76250)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Ds8JxxXSI2 += mTime;
		}
		while (287573 - 144014 != 143559);
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x00176AF0 File Offset: 0x00174CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (231180 - 166543 != 64638)
		{
		}
		do
		{
			if (Time.time - this.aoiJr6LeHt >= this.Ds8JxxXSI2)
			{
				if (275412 - 73479 != 201933)
				{
					continue;
				}
				if (Time.time - this.aoiJr6LeHt < this.Ds8JxxXSI2 + mTime)
				{
					if (144362 - 422565 == -278202)
					{
						continue;
					}
					if (!this.qoyJpTIsuc.myAttackTarget)
					{
						if (178866 - 228699 == -49832)
						{
							continue;
						}
						this.aoiJr6LeHt = Time.time - mTime - this.Ds8JxxXSI2;
						if (124775 - 592040 != -467265)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.qoyJpTIsuc.myAttackTarget;
						if (262859 - 166406 == 96454)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (264142 - 271294 == -7151)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (194956 - 265569 == -70612)
						{
							continue;
						}
						int tID = 0;
						if (134210 - 118230 == 15981)
						{
							continue;
						}
						if (characterControl)
						{
							if (127710 - 102122 == 25589)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (130278 - 503267 != -372989)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (136007 - 162590 == -26582)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (271749 - 546212 == -274462)
							{
								continue;
							}
							if (this.qoyJpTIsuc.isTimeOut("nAttack") == (float)0)
							{
								if (158605 - 162207 == -3601)
								{
									continue;
								}
								this.aoiJr6LeHt = Time.time - mTime - this.Ds8JxxXSI2;
								if (35605 - 93442 != -57837)
								{
									continue;
								}
								if (UnityEngine.Random.Range(0, 2) == 0)
								{
									if (91849 - 154176 != -62327)
									{
										continue;
									}
									this.njGJRuX4l2.StartCoroutine_Auto(this.njGJRuX4l2.RPC_nAttack1(this.transform.position, vector.normalized, tID));
									if (282616 - 434345 != -151729)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (92484 - 557444 != -464960)
										{
											continue;
										}
										this.njGJRuX4l2.ActionEvent("RPC_nAttack1", this.transform.position, vector.normalized, tID);
										if (270295 - 572656 != -302361)
										{
											continue;
										}
									}
								}
								else
								{
									this.njGJRuX4l2.StartCoroutine_Auto(this.njGJRuX4l2.RPC_nAttack2(this.transform.position, vector.normalized, tID));
									if (215796 - 242549 != -26753)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (50689 - 435616 == -384926)
										{
											continue;
										}
										this.njGJRuX4l2.ActionEvent("RPC_nAttack2", this.transform.position, vector.normalized, tID);
										if (212816 - 348872 == -136055)
										{
											continue;
										}
									}
								}
								goto IL_249;
							}
						}
						this.AI_state = "attack";
						if (199354 - 479108 != -279754)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (56042 - 243864 != -187822)
							{
								continue;
							}
							this.qoyJpTIsuc.vDirection = myAttackTarget.transform.position;
							if (113314 - 510788 != -397474)
							{
								continue;
							}
							this.qoyJpTIsuc.vDirection.y = this.transform.position.y;
							if (209561 - 219882 != -10321)
							{
								continue;
							}
							this.qoyJpTIsuc.vMovement = (this.qoyJpTIsuc.vDirection - this.transform.position).normalized;
							if (182642 - 421093 != -238451)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.qoyJpTIsuc.vMovement);
							if (262774 - 405366 == -142591)
							{
								continue;
							}
							this.qoyJpTIsuc.actionState = "run";
							if (23130 - 107343 == -84212)
							{
								continue;
							}
							this.animation.Play("run");
							if (202714 - 206915 == -4200)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (38404 - 188523 == -150118)
							{
								continue;
							}
							this.qoyJpTIsuc.moveSpeed = Mathf.Lerp(this.qoyJpTIsuc.moveSpeed, this.qoyJpTIsuc.runSpeed, (float)4 * Time.deltaTime);
							if (22439 - 71741 == -49301)
							{
								continue;
							}
						}
						else
						{
							this.qoyJpTIsuc.vDirection = myAttackTarget.transform.position;
							if (228431 - 527182 == -298750)
							{
								continue;
							}
							this.qoyJpTIsuc.vDirection.y = this.transform.position.y;
							if (216710 - 55133 == 161578)
							{
								continue;
							}
							this.qoyJpTIsuc.vMovement = (this.qoyJpTIsuc.vDirection - this.transform.position).normalized;
							if (53970 - 595912 != -541942)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.qoyJpTIsuc.vMovement);
							if (248625 - 350771 != -102146)
							{
								continue;
							}
							this.qoyJpTIsuc.actionState = "standby";
							if (230178 - 208078 == 22101)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (253413 - 164831 != 88582)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (87790 - 234588 == -146797)
							{
								continue;
							}
							this.qoyJpTIsuc.moveSpeed = Mathf.Lerp(this.qoyJpTIsuc.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (5564 - 74901 != -69337)
							{
								continue;
							}
						}
					}
				}
			}
			IL_249:
			this.Ds8JxxXSI2 += mTime;
		}
		while (10020 - 564718 != -554698);
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x001772E4 File Offset: 0x001754E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (42821 - 61067 != -18245)
		{
		}
		while (Time.time - this.aoiJr6LeHt > this.Ds8JxxXSI2)
		{
			if (48885 - 210649 == -161764)
			{
				this.AI_state = "none";
				if (28265 - 326168 != -297902)
				{
					this.aoiJr6LeHt = Time.time;
					if (249206 - 138933 == 110273)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00177398 File Offset: 0x00175598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (73879 - 582280 != -508401)
		{
		}
		for (;;)
		{
			IL_30F:
			if (this.mnNJT96pUw > Time.time)
			{
				if (55078 - 169290 == -114212)
				{
					break;
				}
			}
			else
			{
				this.mnNJT96pUw = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (287455 - 511666 != -224210)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)50, this.gameObject.layer);
					if (168845 - 133393 != 35453)
					{
						if (62745 - 7527 == 55218)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (62651 - 209888 != -147236)
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
									if (28300 - 373541 != -345241)
									{
										goto IL_30F;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (33509 - 130350 != -96841)
									{
										goto IL_30F;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (194675 - 284805 != -90130)
									{
										goto IL_30F;
									}
									bool flag = true;
									if (76760 - 70303 != 6457)
									{
										goto IL_30F;
									}
									eRace race = this.qoyJpTIsuc.Race;
									if (10949 - 182010 == -171060)
									{
										goto IL_30F;
									}
									if (race == eRace.Tails)
									{
										if (162212 - 144485 != 17727)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_2D7;
										}
										if (171953 - 166983 == 4971)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (95876 - 65625 != 30252)
											{
												goto IL_2D7;
											}
											goto IL_30F;
										}
										goto IL_4C1;
										IL_2D7:
										flag = false;
										if (94799 - 309697 != -214898)
										{
											goto IL_30F;
										}
									}
									else if (race == eRace.Plants)
									{
										if (116588 - 64498 != 52090)
										{
											goto IL_30F;
										}
										flag = false;
										if (10997 - 304846 != -293849)
										{
											goto IL_30F;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (182529 - 318095 != -135566)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_503;
										}
										if (148676 - 575724 != -427048)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (66766 - 417005 != -350239)
											{
												goto IL_30F;
											}
											goto IL_503;
										}
										goto IL_4C1;
										IL_503:
										flag = false;
										if (215317 - 163451 == 51867)
										{
											goto IL_30F;
										}
									}
									else if (race == eRace.Robots)
									{
										if (125560 - 139502 != -13942)
										{
											goto IL_30F;
										}
										flag = true;
										if (212895 - 578982 != -366087)
										{
											goto IL_30F;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (256576 - 118313 != 138263)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_2F3;
										}
										if (288290 - 382039 != -93749)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_2F3;
										}
										if (62799 - 494067 == -431267)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (218240 - 131516 != 86725)
											{
												goto IL_2F3;
											}
											goto IL_30F;
										}
										goto IL_4C1;
										IL_2F3:
										flag = false;
										if (46732 - 167852 != -121120)
										{
											goto IL_30F;
										}
									}
									else if (race == eRace.Structure)
									{
										if (253897 - 583195 != -329298)
										{
											goto IL_30F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (91436 - 488444 == -397007)
											{
												goto IL_30F;
											}
											flag = false;
											if (147363 - 15863 != 131500)
											{
												goto IL_30F;
											}
										}
									}
									IL_4C1:
									if (flag)
									{
										if (228626 - 449628 != -221002)
										{
											goto IL_30F;
										}
										if (characterControl.hp > 0)
										{
											if (299402 - 591814 != -292412)
											{
												goto IL_30F;
											}
											if (characterControl.recieveTarget)
											{
												if (200962 - 432024 != -231062)
												{
													goto IL_30F;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (54323 - 253908 == -199584)
													{
														goto IL_30F;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (94268 - 392335 == -298066)
														{
															goto IL_30F;
														}
														this.qoyJpTIsuc.myAttackTarget = gameObject;
														if (210620 - 249059 == -38438)
														{
															goto IL_30F;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (90480 - 95788 != -5308)
														{
															goto IL_30F;
														}
														this.qoyJpTIsuc.addHate(characterControl.ActorNr, 50);
														if (230321 - 88031 == 142291)
														{
															goto IL_30F;
														}
														this.qoyJpTIsuc.isAlert = true;
														if (111098 - 484709 != -373611)
														{
															goto IL_30F;
														}
														this.aoiJr6LeHt = Time.time;
														if (264650 - 496327 != -231677)
														{
															goto IL_30F;
														}
													}
												}
											}
										}
									}
								}
								if (39186 - 262004 != -222817)
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

	// Token: 0x06000EC7 RID: 3783 RVA: 0x001779F4 File Offset: 0x00175BF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x001779F8 File Offset: 0x00175BF8
	internal static bool wa83MXSb2bNEwL7R0Ps()
	{
		return true;
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x001779FC File Offset: 0x00175BFC
	internal static bool M0riXBSuPrQuSIJpe1r()
	{
		return false;
	}

	// Token: 0x04000CB9 RID: 3257
	private CharacterControl qoyJpTIsuc;

	// Token: 0x04000CBA RID: 3258
	private ChromeKnight njGJRuX4l2;

	// Token: 0x04000CBB RID: 3259
	public string AI_state;

	// Token: 0x04000CBC RID: 3260
	private float aoiJr6LeHt;

	// Token: 0x04000CBD RID: 3261
	private float Ds8JxxXSI2;

	// Token: 0x04000CBE RID: 3262
	private float mnNJT96pUw;
}
