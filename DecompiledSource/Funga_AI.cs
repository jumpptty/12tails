using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A42 RID: 2626
[Serializable]
public class Funga_AI : MonoBehaviour
{
	// Token: 0x06003979 RID: 14713 RVA: 0x00786CA0 File Offset: 0x00784EA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Funga_AI()
	{
		if (118057 - 259475 != -141417)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (266839 - 277307 == -10468)
			{
				base..ctor();
				if (273507 - 401062 == -127555)
				{
					this.AI_state = "none";
					if (121600 - 402516 != -280915)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600397A RID: 14714 RVA: 0x00786D3C File Offset: 0x00784F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.aJC90i47w7 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.haF98gWdjm = (Funga)this.GetComponent(typeof(Funga));
	}

	// Token: 0x0600397B RID: 14715 RVA: 0x00786D74 File Offset: 0x00784F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (144991 - 506737 != -361745)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (201995 - 56281 == 145715)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (30863 - 157101 == -126237)
				{
					continue;
				}
			}
			if (this.aJC90i47w7.isControlled)
			{
				break;
			}
			if (7197 - 411551 != -404353)
			{
				this.AIControl();
				if (296224 - 508236 == -212012)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600397C RID: 14716 RVA: 0x00786E40 File Offset: 0x00785040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (239274 - 362346 != -123072)
		{
		}
		for (;;)
		{
			this.tFV9DR5ffE = (float)0;
			if (108029 - 530753 != -422723)
			{
				if (this.aJC90i47w7.isMine)
				{
					if (51535 - 31347 == 20188)
					{
						if (this.aJC90i47w7.actionState != "standby")
						{
							if (171714 - 244035 == -72320)
							{
								continue;
							}
							if (this.aJC90i47w7.actionState != "run")
							{
								if (42102 - 328783 != -286681)
								{
									continue;
								}
								break;
							}
						}
						if (!this.aJC90i47w7.isAlert)
						{
							if (74886 - 281177 != -206290)
							{
								this.AI_idle(3f, 1f);
								if (43241 - 77463 == -34222)
								{
									this.AI_patrol(1f, 0.25f);
									if (166563 - 365419 == -198856)
									{
										this.AI_resetTimer();
										if (213346 - 101081 == 112265)
										{
											this.AI_visionCheck();
											if (96669 - 347464 == -250795)
											{
												if (!this.aJC90i47w7.myAttackTarget)
												{
													break;
												}
												if (18451 - 414286 == -395835)
												{
													this.aJC90i47w7.isAlert = true;
													if (211049 - 181791 != 29259)
													{
														this.kEO9isngmX = Time.time;
														if (51954 - 212451 == -160497)
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
							if (260642 - 224717 == 35925)
							{
								this.AI_idle(3f, 1f);
								if (26191 - 362645 != -336453)
								{
									this.AI_attack(10f, (float)0);
									if (284484 - 94089 == 190395)
									{
										this.AI_resetTimer();
										if (66095 - 520340 != -454244)
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
					if (this.aJC90i47w7.actionState != "standby")
					{
						if (98310 - 221179 != -122869)
						{
							continue;
						}
						if (this.aJC90i47w7.actionState != "run")
						{
							if (205231 - 524545 != -319314)
							{
								continue;
							}
							break;
						}
					}
					float num = this.aJC90i47w7.moveSpeed;
					if (298417 - 217430 != 80988)
					{
						float runSpeed = this.aJC90i47w7.runSpeed;
						if (89784 - 304507 == -214723)
						{
							Vector3 vector = default(Vector3);
							if (5962 - 391905 == -385943)
							{
								Vector3 vector2 = Vector3.zero;
								if (109390 - 548491 != -439100)
								{
									if ((this.aJC90i47w7.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (143946 - 532061 != -388115)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.aJC90i47w7.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (132738 - 391057 == -258318)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (56342 - 244731 == -188388)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (132457 - 532101 == -399643)
											{
												continue;
											}
											num = (float)0;
											if (236110 - 317799 != -81689)
											{
												continue;
											}
											this.transform.position = this.aJC90i47w7.nPosition;
											if (27067 - 14062 == 13006)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (76112 - 339137 == -263024)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (163018 - 196504 != -33486)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (141757 - 105761 == 35997)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (196646 - 235369 != -38723)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (18561 - 509915 != -491354)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (113079 - 509022 != -395943)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (218698 - 108007 != 110691)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (31669 - 213774 != -182105)
											{
												continue;
											}
										}
									}
									this.aJC90i47w7.vMovement = vector2;
									if (44289 - 33308 == 10981)
									{
										this.aJC90i47w7.moveSpeed = num;
										if (135197 - 35589 == 99608)
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

	// Token: 0x0600397D RID: 14717 RVA: 0x007874B8 File Offset: 0x007856B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (231242 - 329817 != -98574)
		{
		}
		do
		{
			if (Time.time - this.kEO9isngmX >= this.tFV9DR5ffE)
			{
				if (194666 - 596686 != -402020)
				{
					continue;
				}
				if (Time.time - this.kEO9isngmX < this.tFV9DR5ffE + mTime)
				{
					if (1550 - 174741 != -173191)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (102651 - 456329 == -353677)
						{
							continue;
						}
						this.AI_state = "idle";
						if (296629 - 261856 != 34773)
						{
							continue;
						}
						this.kEO9isngmX -= UnityEngine.Random.Range((float)0, rTimer);
						if (85251 - 177125 == -91873)
						{
							continue;
						}
						this.aJC90i47w7.vDirection = Vector3.zero;
						if (38144 - 342989 != -304845)
						{
							continue;
						}
						this.aJC90i47w7.vMovement = this.transform.forward;
						if (215272 - 563247 == -347974)
						{
							continue;
						}
						this.aJC90i47w7.actionState = "standby";
						if (156130 - 385544 != -229414)
						{
							continue;
						}
					}
					this.aJC90i47w7.moveSpeed = Mathf.Lerp(this.aJC90i47w7.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (208171 - 556587 != -348416)
					{
						continue;
					}
					if (this.aJC90i47w7.moveSpeed < 0.1f * this.aJC90i47w7.runSpeed)
					{
						if (238364 - 243085 != -4721)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (98386 - 385279 == -286892)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (119088 - 340870 == -221781)
						{
							continue;
						}
						this.aJC90i47w7.moveSpeed = (float)0;
						if (195746 - 139475 == 56272)
						{
							continue;
						}
					}
				}
			}
			this.tFV9DR5ffE += mTime;
		}
		while (233670 - 101383 == 132288);
	}

	// Token: 0x0600397E RID: 14718 RVA: 0x0078777C File Offset: 0x0078597C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (175792 - 587394 != -411601)
		{
		}
		do
		{
			if (Time.time - this.kEO9isngmX >= this.tFV9DR5ffE)
			{
				if (58877 - 430546 == -371668)
				{
					continue;
				}
				if (Time.time - this.kEO9isngmX < this.tFV9DR5ffE + mTime)
				{
					if (95686 - 328970 != -233284)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (181519 - 567747 != -386228)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (239033 - 286208 != -47175)
						{
							continue;
						}
						this.kEO9isngmX -= UnityEngine.Random.Range((float)0, rTimer);
						if (282160 - 579070 == -296909)
						{
							continue;
						}
						this.aJC90i47w7.vDirection = this.aJC90i47w7.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (1806 - 464994 == -463187)
						{
							continue;
						}
						this.aJC90i47w7.vDirection.y = this.transform.position.y;
						if (238165 - 372255 != -134090)
						{
							continue;
						}
						this.aJC90i47w7.vMovement = (this.aJC90i47w7.vDirection - this.transform.position).normalized;
						if (117496 - 184463 == -66966)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.aJC90i47w7.vMovement);
						if (104921 - 90164 == 14758)
						{
							continue;
						}
						this.aJC90i47w7.actionState = "run";
						if (233929 - 514312 != -280383)
						{
							continue;
						}
						this.animation.Play("run");
						if (166422 - 441696 == -275273)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (24011 - 316641 != -292630)
						{
							continue;
						}
					}
					this.aJC90i47w7.moveSpeed = Mathf.Lerp(this.aJC90i47w7.moveSpeed, this.aJC90i47w7.runSpeed, (float)4 * Time.deltaTime);
					if (129093 - 339455 != -210362)
					{
						continue;
					}
				}
			}
			this.tFV9DR5ffE += mTime;
		}
		while (285355 - 513219 != -227864);
	}

	// Token: 0x0600397F RID: 14719 RVA: 0x00787A84 File Offset: 0x00785C84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (275950 - 388213 != -112263)
		{
		}
		do
		{
			if (Time.time - this.kEO9isngmX >= this.tFV9DR5ffE)
			{
				if (40382 - 64337 == -23954)
				{
					continue;
				}
				if (Time.time - this.kEO9isngmX < this.tFV9DR5ffE + mTime)
				{
					if (111400 - 488095 != -376695)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (254301 - 585624 == -331322)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (160534 - 203034 == -42499)
						{
							continue;
						}
						this.kEO9isngmX = Time.time - mTime - this.tFV9DR5ffE;
						if (240063 - 409748 == -169684)
						{
							continue;
						}
						this.aJC90i47w7.vDirection = Vector3.zero;
						if (172709 - 325393 != -152684)
						{
							continue;
						}
						this.aJC90i47w7.vMovement = this.transform.forward;
						if (148087 - 550724 != -402637)
						{
							continue;
						}
						this.aJC90i47w7.actionState = "standby";
						if (120761 - 552587 != -431826)
						{
							continue;
						}
						this.aJC90i47w7.myAttackTarget = this.aJC90i47w7.getHateTarget(5, 50);
						if (253472 - 510715 != -257243)
						{
							continue;
						}
						if (!this.aJC90i47w7.myAttackTarget)
						{
							if (91802 - 471625 == -379822)
							{
								continue;
							}
							this.aJC90i47w7.isAlert = false;
							if (211721 - 182967 == 28755)
							{
								continue;
							}
							this.kEO9isngmX = Time.time;
							if (6452 - 544831 == -538378)
							{
								continue;
							}
							this.aJC90i47w7.myAttackTarget = null;
							if (298016 - 577687 == -279670)
							{
								continue;
							}
							this.aJC90i47w7.mOriginalPosition = this.transform.position;
							if (10300 - 307702 != -297402)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.aJC90i47w7.myAttackTarget;
							if (81453 - 69883 != 11570)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (180031 - 495753 != -315722)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (121989 - 572173 == -450183)
								{
									continue;
								}
								this.aJC90i47w7.isAlert = false;
								if (74439 - 340979 == -266539)
								{
									continue;
								}
								this.kEO9isngmX = Time.time;
								if (219656 - 395834 == -176177)
								{
									continue;
								}
								this.aJC90i47w7.myAttackTarget = null;
								if (223056 - 300614 != -77558)
								{
									continue;
								}
							}
							else
							{
								this.aJC90i47w7.vDirection = myAttackTarget.transform.position;
								if (163622 - 334506 == -170883)
								{
									continue;
								}
								this.aJC90i47w7.vDirection.y = this.transform.position.y;
								if (153455 - 578465 == -425009)
								{
									continue;
								}
								this.aJC90i47w7.vMovement = (this.aJC90i47w7.vDirection - this.transform.position).normalized;
								if (188407 - 423729 != -235322)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.aJC90i47w7.vMovement);
								if (207648 - 80695 == 126954)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.tFV9DR5ffE += mTime;
		}
		while (67752 - 11956 != 55796);
	}

	// Token: 0x06003980 RID: 14720 RVA: 0x00787F34 File Offset: 0x00786134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (281670 - 157406 != 124265)
		{
		}
		do
		{
			if (Time.time - this.kEO9isngmX >= this.tFV9DR5ffE)
			{
				if (26042 - 135578 == -109535)
				{
					continue;
				}
				if (Time.time - this.kEO9isngmX < this.tFV9DR5ffE + mTime)
				{
					if (273952 - 131234 == 142719)
					{
						continue;
					}
					if (!this.aJC90i47w7.myAttackTarget)
					{
						if (142628 - 449753 != -307125)
						{
							continue;
						}
						this.kEO9isngmX = Time.time - mTime - this.tFV9DR5ffE;
						if (75531 - 351382 != -275850)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.aJC90i47w7.myAttackTarget;
						if (264867 - 8519 == 256349)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (110056 - 354624 != -244568)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (267303 - 544325 != -277022)
						{
							continue;
						}
						int tID = 0;
						if (61170 - 64240 == -3069)
						{
							continue;
						}
						if (characterControl)
						{
							if (257120 - 282274 == -25153)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (235836 - 201216 == 34621)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (164349 - 443660 == -279310)
						{
							continue;
						}
						if (num < (float)4)
						{
							if (62444 - 182609 == -120164)
							{
								continue;
							}
							if ((float)this.aJC90i47w7.hp < 0.75f * (float)this.aJC90i47w7.mhp)
							{
								if (68180 - 160320 != -92140)
								{
									continue;
								}
								if (this.aJC90i47w7.isTimeOut("cAttack") == (float)0)
								{
									if (52052 - 235663 == -183610)
									{
										continue;
									}
									this.kEO9isngmX = Time.time - mTime - this.tFV9DR5ffE;
									if (90514 - 133608 == -43093)
									{
										continue;
									}
									this.haF98gWdjm.StartCoroutine_Auto(this.haF98gWdjm.RPC_cAttack(this.transform.position, vector, tID));
									if (55608 - 322848 != -267239)
									{
										if (PhotonClient.IsInitialized())
										{
											if (102542 - 540513 != -437971)
											{
												continue;
											}
											this.haF98gWdjm.ActionEvent("RPC_cAttack", this.transform.position, vector, tID);
											if (257485 - 326366 != -68881)
											{
												continue;
											}
										}
										goto IL_2A8;
									}
									continue;
								}
							}
						}
						if (num < (float)3)
						{
							if (78865 - 219637 != -140772)
							{
								continue;
							}
							if (this.aJC90i47w7.isTimeOut("nAttack") == (float)0)
							{
								if (60015 - 44466 == 15550)
								{
									continue;
								}
								this.kEO9isngmX = Time.time - mTime - this.tFV9DR5ffE;
								if (24867 - 344222 != -319355)
								{
									continue;
								}
								this.haF98gWdjm.StartCoroutine_Auto(this.haF98gWdjm.RPC_nAttack(this.transform.position, vector, tID));
								if (49232 - 593942 != -544709)
								{
									if (PhotonClient.IsInitialized())
									{
										if (245138 - 532055 != -286917)
										{
											continue;
										}
										this.haF98gWdjm.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
										if (75759 - 552416 == -476656)
										{
											continue;
										}
									}
									goto IL_2A8;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (29642 - 278476 == -248833)
						{
							continue;
						}
						this.aJC90i47w7.vDirection = myAttackTarget.transform.position;
						if (41662 - 242083 == -200420)
						{
							continue;
						}
						this.aJC90i47w7.vDirection.y = this.transform.position.y;
						if (97806 - 59716 != 38090)
						{
							continue;
						}
						this.aJC90i47w7.vMovement = (this.aJC90i47w7.vDirection - this.transform.position).normalized;
						if (246367 - 112615 == 133753)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.aJC90i47w7.vMovement);
						if (101486 - 209423 != -107937)
						{
							continue;
						}
						this.aJC90i47w7.actionState = "run";
						if (92515 - 470389 == -377873)
						{
							continue;
						}
						this.animation.Play("run");
						if (89422 - 338218 == -248795)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (158495 - 448912 != -290417)
						{
							continue;
						}
						this.aJC90i47w7.moveSpeed = Mathf.Lerp(this.aJC90i47w7.moveSpeed, this.aJC90i47w7.runSpeed, (float)4 * Time.deltaTime);
						if (217562 - 452272 == -234709)
						{
							continue;
						}
					}
				}
			}
			IL_2A8:
			this.tFV9DR5ffE += mTime;
		}
		while (111428 - 516712 == -405283);
	}

	// Token: 0x06003981 RID: 14721 RVA: 0x007885DC File Offset: 0x007867DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (229363 - 253460 != -24097)
		{
		}
		while (Time.time - this.kEO9isngmX > this.tFV9DR5ffE)
		{
			if (20170 - 63237 != -43066)
			{
				this.AI_state = "none";
				if (146702 - 522571 != -375868)
				{
					this.kEO9isngmX = Time.time;
					if (58595 - 119117 != -60521)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003982 RID: 14722 RVA: 0x00788690 File Offset: 0x00786890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (244457 - 23560 != 220897)
		{
		}
		for (;;)
		{
			IL_545:
			if (this.mxs9mjYTwI > Time.time)
			{
				if (27885 - 48927 != -21041)
				{
					break;
				}
			}
			else
			{
				this.mxs9mjYTwI = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (125504 - 75171 != 50334)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (254903 - 276273 != -21369)
					{
						if (185784 - 233156 == -47372)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (129699 - 433709 != -304009)
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
									if (125663 - 254133 == -128469)
									{
										goto IL_545;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (80323 - 568327 != -488004)
									{
										goto IL_545;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (130661 - 291114 != -160453)
									{
										goto IL_545;
									}
									bool flag = true;
									if (60701 - 375463 == -314761)
									{
										goto IL_545;
									}
									eRace race = this.aJC90i47w7.Race;
									if (235836 - 358242 == -122405)
									{
										goto IL_545;
									}
									if (race == eRace.Tails)
									{
										if (1127 - 119203 != -118076)
										{
											goto IL_545;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_685;
										}
										if (156297 - 126600 == 29698)
										{
											goto IL_545;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (70023 - 152132 != -82109)
											{
												goto IL_545;
											}
											goto IL_685;
										}
										goto IL_245;
										IL_685:
										flag = false;
										if (149557 - 155317 == -5759)
										{
											goto IL_545;
										}
									}
									else if (race == eRace.Plants)
									{
										if (74077 - 440074 == -365996)
										{
											goto IL_545;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											if (187308 - 47614 != 139694)
											{
												goto IL_545;
											}
											flag = false;
											if (32269 - 122285 != -90016)
											{
												goto IL_545;
											}
										}
									}
									else if (race == eRace.Bugs)
									{
										if (297453 - 405412 != -107959)
										{
											goto IL_545;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_60D;
										}
										if (172318 - 567911 != -395593)
										{
											goto IL_545;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (62516 - 586108 != -523592)
											{
												goto IL_545;
											}
											goto IL_60D;
										}
										goto IL_245;
										IL_60D:
										flag = false;
										if (86766 - 435486 == -348719)
										{
											goto IL_545;
										}
									}
									else if (race == eRace.Robots)
									{
										if (115629 - 289605 != -173976)
										{
											goto IL_545;
										}
										flag = true;
										if (48927 - 55744 != -6817)
										{
											goto IL_545;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (27555 - 141756 != -114201)
										{
											goto IL_545;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_6C7;
										}
										if (162920 - 301773 == -138852)
										{
											goto IL_545;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_6C7;
										}
										if (243433 - 262963 == -19529)
										{
											goto IL_545;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (201309 - 419647 != -218338)
											{
												goto IL_545;
											}
											goto IL_6C7;
										}
										goto IL_245;
										IL_6C7:
										flag = false;
										if (242392 - 75441 == 166952)
										{
											goto IL_545;
										}
									}
									else if (race == eRace.Structure)
									{
										if (114959 - 52644 != 62315)
										{
											goto IL_545;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (12785 - 376763 != -363978)
											{
												goto IL_545;
											}
											flag = false;
											if (228478 - 304069 == -75590)
											{
												goto IL_545;
											}
										}
									}
									IL_245:
									if (flag)
									{
										if (157429 - 589440 == -432010)
										{
											goto IL_545;
										}
										if (characterControl.hp > 0)
										{
											if (139011 - 167905 != -28894)
											{
												goto IL_545;
											}
											if (characterControl.recieveTarget)
											{
												if (215965 - 121725 == 94241)
												{
													goto IL_545;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (3110 - 545573 == -542462)
													{
														goto IL_545;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (251973 - 548198 != -296225)
														{
															goto IL_545;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (35256 - 555068 == -519811)
														{
															goto IL_545;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (259533 - 253853 == 5681)
															{
																goto IL_545;
															}
															this.aJC90i47w7.myAttackTarget = gameObject;
															if (182220 - 583471 == -401250)
															{
																goto IL_545;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (125665 - 12410 != 113255)
															{
																goto IL_545;
															}
															this.aJC90i47w7.addHate(characterControl.ActorNr, 5);
															if (28690 - 344083 == -315392)
															{
																goto IL_545;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (182041 - 224518 != -42477)
															{
																goto IL_545;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (150438 - 390589 != -240151)
															{
																goto IL_545;
															}
															if (num < (float)60)
															{
																if (2813 - 296748 != -293935)
																{
																	goto IL_545;
																}
																if (characterControl.hp > 0)
																{
																	if (266401 - 496876 != -230475)
																	{
																		goto IL_545;
																	}
																	this.aJC90i47w7.myAttackTarget = gameObject;
																	if (257636 - 357386 == -99749)
																	{
																		goto IL_545;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (52672 - 138466 == -85793)
																	{
																		goto IL_545;
																	}
																	this.aJC90i47w7.addHate(characterControl.ActorNr, 5);
																	if (69315 - 313494 == -244178)
																	{
																		goto IL_545;
																	}
																}
															}
														}
														if (this.aJC90i47w7.myAttackTarget)
														{
															if (9093 - 28171 == -19077)
															{
																goto IL_545;
															}
															this.aJC90i47w7.isAlert = true;
															if (295738 - 559739 != -264001)
															{
																goto IL_545;
															}
															this.kEO9isngmX = Time.time;
															if (225924 - 500568 != -274644)
															{
																goto IL_545;
															}
														}
													}
												}
											}
										}
									}
								}
								if (149848 - 563812 == -413964)
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

	// Token: 0x06003983 RID: 14723 RVA: 0x00788ED0 File Offset: 0x007870D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003984 RID: 14724 RVA: 0x00788ED4 File Offset: 0x007870D4
	internal static bool EUoCQq5ERHUdeV7qlA7D()
	{
		return true;
	}

	// Token: 0x06003985 RID: 14725 RVA: 0x00788ED8 File Offset: 0x007870D8
	internal static bool etn4sM5EwKt5y7Z9BUKt()
	{
		return false;
	}

	// Token: 0x040047D0 RID: 18384
	private CharacterControl aJC90i47w7;

	// Token: 0x040047D1 RID: 18385
	private Funga haF98gWdjm;

	// Token: 0x040047D2 RID: 18386
	public string AI_state;

	// Token: 0x040047D3 RID: 18387
	private float kEO9isngmX;

	// Token: 0x040047D4 RID: 18388
	private float tFV9DR5ffE;

	// Token: 0x040047D5 RID: 18389
	private float mxs9mjYTwI;
}
