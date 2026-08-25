using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000238 RID: 568
[Serializable]
public class StingQueenAI : MonoBehaviour
{
	// Token: 0x06000CE1 RID: 3297 RVA: 0x00146C40 File Offset: 0x00144E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StingQueenAI()
	{
		if (287052 - 321758 != -34705)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (193781 - 481913 == -288132)
			{
				base..ctor();
				if (230102 - 302924 != -72821)
				{
					this.AI_state = "none";
					if (26185 - 18181 == 8004)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x00146CDC File Offset: 0x00144EDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.qMmIQZOdfJ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.cfRIeqfZdo = (StingQueen)this.GetComponent(typeof(StingQueen));
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x00146D14 File Offset: 0x00144F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (260769 - 99279 != 161491)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (151984 - 262626 != -110642)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (58170 - 139644 != -81474)
				{
					continue;
				}
			}
			if (this.qMmIQZOdfJ.isControlled)
			{
				break;
			}
			if (266098 - 487310 != -221211)
			{
				this.AIControl();
				if (19523 - 230138 != -210614)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x00146DE0 File Offset: 0x00144FE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (35401 - 70271 != -34869)
		{
		}
		for (;;)
		{
			this.yfLIJTMY8g = (float)0;
			if (1038 - 417282 == -416244)
			{
				if (this.qMmIQZOdfJ.isMine)
				{
					if (223379 - 393983 != -170603)
					{
						if (this.qMmIQZOdfJ.actionState != "standby")
						{
							if (155106 - 497757 == -342650)
							{
								continue;
							}
							if (this.qMmIQZOdfJ.actionState != "run")
							{
								if (45448 - 299170 != -253722)
								{
									continue;
								}
								break;
							}
						}
						if (!this.qMmIQZOdfJ.isAlert)
						{
							if (166738 - 552866 == -386128)
							{
								this.AI_idle(3f, 1f);
								if (231198 - 34810 == 196388)
								{
									this.AI_patrol(1f, 0.25f);
									if (277963 - 241613 == 36350)
									{
										this.AI_resetTimer();
										if (84769 - 125083 == -40314)
										{
											this.AI_visionCheck();
											if (138420 - 336846 == -198426)
											{
												if (!this.qMmIQZOdfJ.myAttackTarget)
												{
													break;
												}
												if (170561 - 44583 != 125979)
												{
													this.qMmIQZOdfJ.isAlert = true;
													if (41467 - 556072 != -514604)
													{
														this.SpKIINGRba = Time.time;
														if (156680 - 420639 == -263959)
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
							if (120667 - 283528 != -162860)
							{
								this.AI_idle(3f, 1f);
								if (131368 - 499768 != -368399)
								{
									this.AI_attack(10f, (float)0);
									if (49075 - 353402 != -304326)
									{
										this.AI_resetTimer();
										if (119627 - 175984 == -56357)
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
					if (this.qMmIQZOdfJ.actionState != "standby")
					{
						if (104373 - 357236 != -252863)
						{
							continue;
						}
						if (this.qMmIQZOdfJ.actionState != "run")
						{
							if (148681 - 375521 != -226839)
							{
								break;
							}
							continue;
						}
					}
					float num = this.qMmIQZOdfJ.moveSpeed;
					if (299269 - 303426 != -4156)
					{
						float runSpeed = this.qMmIQZOdfJ.runSpeed;
						if (165889 - 279251 == -113362)
						{
							Vector3 vector = default(Vector3);
							if (21857 - 542518 != -520660)
							{
								Vector3 vector2 = Vector3.zero;
								if (269988 - 450289 == -180301)
								{
									if ((this.qMmIQZOdfJ.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (245599 - 97877 != 147722)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.qMmIQZOdfJ.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (82166 - 131116 == -48949)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (124377 - 466923 == -342545)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (47683 - 202843 == -155159)
											{
												continue;
											}
											num = (float)0;
											if (155687 - 97696 == 57992)
											{
												continue;
											}
											this.transform.position = this.qMmIQZOdfJ.nPosition;
											if (39666 - 277793 == -238126)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (101258 - 443031 == -341772)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (226541 - 498481 != -271940)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (291502 - 445855 == -154352)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (99849 - 188528 == -88678)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (202263 - 211212 == -8948)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (197243 - 478288 != -281045)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (48264 - 11367 == 36898)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (297477 - 394902 == -97424)
											{
												continue;
											}
										}
									}
									this.qMmIQZOdfJ.vMovement = vector2;
									if (253054 - 554640 != -301585)
									{
										this.qMmIQZOdfJ.moveSpeed = num;
										if (290142 - 387743 == -97601)
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

	// Token: 0x06000CE5 RID: 3301 RVA: 0x00147458 File Offset: 0x00145658
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (220988 - 568046 != -347057)
		{
		}
		do
		{
			if (Time.time - this.SpKIINGRba >= this.yfLIJTMY8g)
			{
				if (1020 - 76761 != -75741)
				{
					continue;
				}
				if (Time.time - this.SpKIINGRba < this.yfLIJTMY8g + mTime)
				{
					if (10233 - 599995 == -589761)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (38550 - 576377 != -537827)
						{
							continue;
						}
						this.AI_state = "idle";
						if (115773 - 257830 != -142057)
						{
							continue;
						}
						this.SpKIINGRba -= UnityEngine.Random.Range((float)0, rTimer);
						if (82134 - 291893 != -209759)
						{
							continue;
						}
						this.qMmIQZOdfJ.vDirection = Vector3.zero;
						if (137495 - 317931 == -180435)
						{
							continue;
						}
						this.qMmIQZOdfJ.vMovement = this.transform.forward;
						if (18933 - 465878 != -446945)
						{
							continue;
						}
						this.qMmIQZOdfJ.actionState = "standby";
						if (218627 - 550689 == -332061)
						{
							continue;
						}
					}
					this.qMmIQZOdfJ.moveSpeed = Mathf.Lerp(this.qMmIQZOdfJ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (208077 - 274104 == -66026)
					{
						continue;
					}
					if (this.qMmIQZOdfJ.moveSpeed < 0.1f * this.qMmIQZOdfJ.runSpeed)
					{
						if (277724 - 89456 == 188269)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (2913 - 3830 != -917)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (235781 - 97153 == 138629)
						{
							continue;
						}
						this.qMmIQZOdfJ.moveSpeed = (float)0;
						if (137905 - 93719 == 44187)
						{
							continue;
						}
					}
				}
			}
			this.yfLIJTMY8g += mTime;
		}
		while (144595 - 227581 != -82986);
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x0014771C File Offset: 0x0014591C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (162084 - 131353 != 30731)
		{
		}
		do
		{
			if (Time.time - this.SpKIINGRba >= this.yfLIJTMY8g)
			{
				if (2113 - 573868 != -571755)
				{
					continue;
				}
				if (Time.time - this.SpKIINGRba < this.yfLIJTMY8g + mTime)
				{
					if (281365 - 369272 != -87907)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (264721 - 510085 != -245364)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (26002 - 519704 == -493701)
						{
							continue;
						}
						this.SpKIINGRba -= UnityEngine.Random.Range((float)0, rTimer);
						if (253206 - 185864 == 67343)
						{
							continue;
						}
						this.qMmIQZOdfJ.vDirection = this.qMmIQZOdfJ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (135652 - 88586 == 47067)
						{
							continue;
						}
						this.qMmIQZOdfJ.vDirection.y = this.transform.position.y;
						if (212340 - 473489 == -261148)
						{
							continue;
						}
						this.qMmIQZOdfJ.vMovement = (this.qMmIQZOdfJ.vDirection - this.transform.position).normalized;
						if (4998 - 81957 != -76959)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.qMmIQZOdfJ.vMovement);
						if (38260 - 137831 != -99571)
						{
							continue;
						}
						this.qMmIQZOdfJ.actionState = "run";
						if (91218 - 217225 != -126007)
						{
							continue;
						}
						this.animation.Play("run");
						if (181686 - 229297 == -47610)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (41214 - 578998 == -537783)
						{
							continue;
						}
					}
					this.qMmIQZOdfJ.moveSpeed = Mathf.Lerp(this.qMmIQZOdfJ.moveSpeed, this.qMmIQZOdfJ.runSpeed, (float)4 * Time.deltaTime);
					if (138380 - 34854 == 103527)
					{
						continue;
					}
				}
			}
			this.yfLIJTMY8g += mTime;
		}
		while (51177 - 563883 != -512706);
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x00147A24 File Offset: 0x00145C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (201409 - 515139 != -313730)
		{
		}
		do
		{
			if (Time.time - this.SpKIINGRba >= this.yfLIJTMY8g)
			{
				if (223739 - 525038 != -301299)
				{
					continue;
				}
				if (Time.time - this.SpKIINGRba < this.yfLIJTMY8g + mTime)
				{
					if (73084 - 534924 == -461839)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (174563 - 167613 == 6951)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (40934 - 17136 == 23799)
						{
							continue;
						}
						this.SpKIINGRba = Time.time - mTime - this.yfLIJTMY8g;
						if (246789 - 305224 == -58434)
						{
							continue;
						}
						this.qMmIQZOdfJ.vDirection = Vector3.zero;
						if (73788 - 193655 != -119867)
						{
							continue;
						}
						this.qMmIQZOdfJ.vMovement = this.transform.forward;
						if (241576 - 177312 == 64265)
						{
							continue;
						}
						this.qMmIQZOdfJ.actionState = "standby";
						if (67322 - 517558 == -450235)
						{
							continue;
						}
						this.qMmIQZOdfJ.myAttackTarget = this.qMmIQZOdfJ.getHateTarget(5, 50);
						if (170184 - 149133 != 21051)
						{
							continue;
						}
						if (!this.qMmIQZOdfJ.myAttackTarget)
						{
							if (150385 - 513700 == -363314)
							{
								continue;
							}
							this.qMmIQZOdfJ.isAlert = false;
							if (199118 - 322400 != -123282)
							{
								continue;
							}
							this.SpKIINGRba = Time.time;
							if (264091 - 58230 == 205862)
							{
								continue;
							}
							this.qMmIQZOdfJ.myAttackTarget = null;
							if (239451 - 566558 != -327107)
							{
								continue;
							}
							this.qMmIQZOdfJ.mOriginalPosition = this.transform.position;
							if (201351 - 453866 != -252514)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.qMmIQZOdfJ.myAttackTarget;
							if (117027 - 166735 != -49708)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (23465 - 373264 != -349799)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (174293 - 412627 != -238334)
								{
									continue;
								}
								this.qMmIQZOdfJ.isAlert = false;
								if (94404 - 44033 == 50372)
								{
									continue;
								}
								this.SpKIINGRba = Time.time;
								if (178557 - 446429 != -267872)
								{
									continue;
								}
								this.qMmIQZOdfJ.myAttackTarget = null;
								if (280203 - 305642 != -25439)
								{
									continue;
								}
							}
							else
							{
								this.qMmIQZOdfJ.vDirection = myAttackTarget.transform.position;
								if (136976 - 152495 != -15519)
								{
									continue;
								}
								this.qMmIQZOdfJ.vDirection.y = this.transform.position.y;
								if (254771 - 423799 != -169028)
								{
									continue;
								}
								this.qMmIQZOdfJ.vMovement = (this.qMmIQZOdfJ.vDirection - this.transform.position).normalized;
								if (120101 - 307788 == -187686)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.qMmIQZOdfJ.vMovement);
								if (204910 - 103972 != 100938)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.yfLIJTMY8g += mTime;
		}
		while (172533 - 541814 == -369280);
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x00147ED4 File Offset: 0x001460D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (206885 - 536383 != -329498)
		{
		}
		do
		{
			IL_629:
			if (Time.time - this.SpKIINGRba >= this.yfLIJTMY8g)
			{
				if (222488 - 215400 == 7089)
				{
					continue;
				}
				if (Time.time - this.SpKIINGRba < this.yfLIJTMY8g + mTime)
				{
					if (71041 - 211042 == -140000)
					{
						continue;
					}
					if (!this.qMmIQZOdfJ.myAttackTarget)
					{
						if (81405 - 304848 == -223442)
						{
							continue;
						}
						this.SpKIINGRba = Time.time - mTime - this.yfLIJTMY8g;
						if (75676 - 448147 != -372471)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.qMmIQZOdfJ.myAttackTarget;
						if (85184 - 348044 != -262860)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (260920 - 44956 != 215964)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (101490 - 445665 == -344174)
						{
							continue;
						}
						int num = 0;
						if (11245 - 322042 != -310797)
						{
							continue;
						}
						if (characterControl)
						{
							if (40969 - 559822 == -518852)
							{
								continue;
							}
							num = characterControl.ActorNr;
							if (16568 - 307021 == -290452)
							{
								continue;
							}
						}
						float num2 = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (230674 - 489027 != -258353)
						{
							continue;
						}
						if (num2 < (float)2)
						{
							if (274711 - 342744 != -68033)
							{
								continue;
							}
							if (this.qMmIQZOdfJ.isTimeOut("nAttack") == (float)0)
							{
								if (190113 - 48142 == 141972)
								{
									continue;
								}
								this.SpKIINGRba = Time.time - mTime - this.yfLIJTMY8g;
								if (41643 - 205759 != -164115)
								{
									if (UnityEngine.Random.Range(0, 100) < 60)
									{
										if (82359 - 106964 == -24604)
										{
											continue;
										}
										this.cfRIeqfZdo.StartCoroutine_Auto(this.cfRIeqfZdo.RPC_nAttack(this.transform.position, vector, 0));
										if (287422 - 334259 == -46836)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (47896 - 599780 != -551884)
											{
												continue;
											}
											this.cfRIeqfZdo.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (229682 - 39801 != 189881)
											{
												continue;
											}
										}
									}
									else
									{
										this.cfRIeqfZdo.StartCoroutine_Auto(this.cfRIeqfZdo.RPC_sting(this.transform.position, vector, 0));
										if (270040 - 493205 != -223165)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (248332 - 184482 == 63851)
											{
												continue;
											}
											this.cfRIeqfZdo.ActionEvent("RPC_sting", this.transform.position, vector, 0);
											if (261622 - 161132 != 100490)
											{
												continue;
											}
										}
									}
									goto IL_53F;
								}
								continue;
							}
						}
						if (UnityEngine.Random.Range(0, 100) < 30)
						{
							if (172561 - 187049 != -14488)
							{
								continue;
							}
							if (this.qMmIQZOdfJ.isTimeOut("cAttack") == (float)0)
							{
								if (179148 - 34270 != 144878)
								{
									continue;
								}
								this.SpKIINGRba = Time.time - mTime - this.yfLIJTMY8g;
								if (205890 - 482535 == -276644)
								{
									continue;
								}
								UnityScript.Lang.Array obj = Hate.findFriends(this.transform.position, (float)12, this.gameObject.layer);
								if (135254 - 204000 == -68745)
								{
									continue;
								}
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
								if (21093 - 125415 != -104322)
								{
									continue;
								}
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
									if (213477 - 207338 == 6140)
									{
										goto IL_629;
									}
									CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (290481 - 54938 == 235544)
									{
										goto IL_629;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (22519 - 526958 != -504439)
									{
										goto IL_629;
									}
									if (characterControl2)
									{
										if (120482 - 486787 == -366304)
										{
											goto IL_629;
										}
										if (!characterControl2.hasStatus("bless"))
										{
											if (211190 - 408139 != -196949)
											{
												goto IL_629;
											}
											Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
											if (96990 - 216544 != -119554)
											{
												goto IL_629;
											}
											vector = vector2.normalized;
											if (28781 - 200711 != -171930)
											{
												goto IL_629;
											}
											UnityRuntimeServices.Update(enumerator, gameObject);
											if (227768 - 378509 == -150740)
											{
												goto IL_629;
											}
											this.cfRIeqfZdo.StartCoroutine_Auto(this.cfRIeqfZdo.RPC_bless(this.transform.position, vector, characterControl2.ActorNr));
											if (67037 - 68988 != -1951)
											{
												goto IL_629;
											}
											if (!PhotonClient.IsInitialized())
											{
												return;
											}
											if (231455 - 206693 == 24763)
											{
												goto IL_629;
											}
											this.cfRIeqfZdo.ActionEvent("RPC_bless", this.transform.position, vector, characterControl2.ActorNr);
											if (48110 - 592828 != -544717)
											{
												return;
											}
											goto IL_629;
										}
									}
								}
								if (56792 - 278863 != -222070)
								{
									goto IL_53F;
								}
								continue;
							}
						}
						if (num != 0)
						{
							if (167478 - 30843 == 136636)
							{
								continue;
							}
							if (num2 < (float)30)
							{
								if (85988 - 353778 != -267790)
								{
									continue;
								}
								if (this.qMmIQZOdfJ.isTimeOut("cAttack") == (float)0)
								{
									if (58482 - 286127 != -227645)
									{
										continue;
									}
									this.SpKIINGRba = Time.time - mTime - this.yfLIJTMY8g;
									if (224393 - 418198 == -193804)
									{
										continue;
									}
									this.cfRIeqfZdo.StartCoroutine_Auto(this.cfRIeqfZdo.RPC_divinitySpear(this.transform.position, vector, num));
									if (263463 - 307180 != -43716)
									{
										if (PhotonClient.IsInitialized())
										{
											if (248188 - 379325 == -131136)
											{
												continue;
											}
											this.cfRIeqfZdo.ActionEvent("RPC_divinitySpear", this.transform.position, vector, num);
											if (297353 - 232023 != 65330)
											{
												continue;
											}
										}
										goto IL_53F;
									}
									continue;
								}
							}
						}
						this.AI_state = "attack";
						if (248179 - 451220 == -203040)
						{
							continue;
						}
						this.qMmIQZOdfJ.vDirection = myAttackTarget.transform.position;
						if (118552 - 325443 == -206890)
						{
							continue;
						}
						this.qMmIQZOdfJ.vDirection.y = this.transform.position.y;
						if (23108 - 92210 == -69101)
						{
							continue;
						}
						this.qMmIQZOdfJ.vMovement = (this.qMmIQZOdfJ.vDirection - this.transform.position).normalized;
						if (280729 - 142086 == 138644)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.qMmIQZOdfJ.vMovement);
						if (157607 - 64276 != 93331)
						{
							continue;
						}
						this.qMmIQZOdfJ.actionState = "run";
						if (299757 - 356084 != -56327)
						{
							continue;
						}
						this.animation.Play("run");
						if (169208 - 133041 != 36167)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (99379 - 534820 != -435441)
						{
							continue;
						}
						this.qMmIQZOdfJ.moveSpeed = Mathf.Lerp(this.qMmIQZOdfJ.moveSpeed, this.qMmIQZOdfJ.runSpeed, (float)4 * Time.deltaTime);
						if (45906 - 68143 != -22237)
						{
							continue;
						}
					}
				}
			}
			IL_53F:
			this.yfLIJTMY8g += mTime;
		}
		while (6570 - 165848 == -159277);
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x00148950 File Offset: 0x00146B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (8341 - 31200 != -22858)
		{
		}
		while (Time.time - this.SpKIINGRba > this.yfLIJTMY8g)
		{
			if (20250 - 535782 == -515532)
			{
				this.AI_state = "none";
				if (199022 - 314143 == -115121)
				{
					this.SpKIINGRba = Time.time;
					if (129740 - 261122 == -131382)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x00148A04 File Offset: 0x00146C04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (274817 - 385766 != -110949)
		{
		}
		for (;;)
		{
			IL_221:
			if (this.kJaI6w9Dr5 > Time.time)
			{
				if (261423 - 84020 != 177404)
				{
					break;
				}
			}
			else
			{
				this.kJaI6w9Dr5 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (241159 - 423923 != -182763)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (119242 - 582624 != -463381)
					{
						if (109212 - 148367 == -39155)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (99312 - 317006 != -217693)
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
									if (54085 - 307148 != -253063)
									{
										goto IL_221;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (6256 - 46079 == -39822)
									{
										goto IL_221;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (116825 - 496770 != -379945)
									{
										goto IL_221;
									}
									bool flag = true;
									if (45415 - 481947 != -436532)
									{
										goto IL_221;
									}
									eRace race = this.qMmIQZOdfJ.Race;
									if (105537 - 274614 != -169077)
									{
										goto IL_221;
									}
									if (race == eRace.Tails)
									{
										if (183008 - 414431 != -231423)
										{
											goto IL_221;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_24B;
										}
										if (17631 - 461181 != -443550)
										{
											goto IL_221;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (134947 - 78871 != 56076)
											{
												goto IL_221;
											}
											goto IL_24B;
										}
										goto IL_3CF;
										IL_24B:
										flag = false;
										if (186953 - 488624 != -301671)
										{
											goto IL_221;
										}
									}
									else if (race == eRace.Plants)
									{
										if (174513 - 186023 != -11510)
										{
											goto IL_221;
										}
										flag = false;
										if (219273 - 279201 == -59927)
										{
											goto IL_221;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (222817 - 531879 != -309062)
										{
											goto IL_221;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2A9;
										}
										if (167639 - 97135 != 70504)
										{
											goto IL_221;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (152965 - 242257 != -89292)
											{
												goto IL_221;
											}
											goto IL_2A9;
										}
										goto IL_3CF;
										IL_2A9:
										flag = false;
										if (45494 - 363669 != -318175)
										{
											goto IL_221;
										}
									}
									else if (race == eRace.Robots)
									{
										if (68568 - 334703 == -266134)
										{
											goto IL_221;
										}
										flag = true;
										if (221556 - 374497 == -152940)
										{
											goto IL_221;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (45336 - 535969 == -490632)
										{
											goto IL_221;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_41E;
										}
										if (34171 - 161005 == -126833)
										{
											goto IL_221;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_41E;
										}
										if (253877 - 306125 != -52248)
										{
											goto IL_221;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (137547 - 335851 != -198303)
											{
												goto IL_41E;
											}
											goto IL_221;
										}
										goto IL_3CF;
										IL_41E:
										flag = false;
										if (72491 - 422280 != -349789)
										{
											goto IL_221;
										}
									}
									else if (race == eRace.Structure)
									{
										if (42083 - 451597 == -409513)
										{
											goto IL_221;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (173222 - 586920 == -413697)
											{
												goto IL_221;
											}
											flag = false;
											if (30721 - 4393 == 26329)
											{
												goto IL_221;
											}
										}
									}
									IL_3CF:
									if (flag)
									{
										if (10169 - 399960 != -389791)
										{
											goto IL_221;
										}
										if (characterControl.hp > 0)
										{
											if (275128 - 323264 == -48135)
											{
												goto IL_221;
											}
											if (characterControl.recieveTarget)
											{
												if (162227 - 198745 == -36517)
												{
													goto IL_221;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (153677 - 264331 != -110654)
													{
														goto IL_221;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (122417 - 565990 == -443572)
														{
															goto IL_221;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (104240 - 304763 != -200523)
														{
															goto IL_221;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (68878 - 596330 != -527452)
															{
																goto IL_221;
															}
															this.qMmIQZOdfJ.myAttackTarget = gameObject;
															if (347 - 30931 == -30583)
															{
																goto IL_221;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (60064 - 256794 != -196730)
															{
																goto IL_221;
															}
															this.qMmIQZOdfJ.addHate(characterControl.ActorNr, 5);
															if (64812 - 34205 != 30607)
															{
																goto IL_221;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (69784 - 284848 != -215064)
															{
																goto IL_221;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (78878 - 68666 != 10212)
															{
																goto IL_221;
															}
															if (num < (float)60)
															{
																if (72449 - 15213 == 57237)
																{
																	goto IL_221;
																}
																if (characterControl.hp > 0)
																{
																	if (111800 - 575369 == -463568)
																	{
																		goto IL_221;
																	}
																	this.qMmIQZOdfJ.myAttackTarget = gameObject;
																	if (22035 - 278109 == -256073)
																	{
																		goto IL_221;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (143423 - 13168 == 130256)
																	{
																		goto IL_221;
																	}
																	this.qMmIQZOdfJ.addHate(characterControl.ActorNr, 5);
																	if (213653 - 500857 == -287203)
																	{
																		goto IL_221;
																	}
																}
															}
														}
														if (this.qMmIQZOdfJ.myAttackTarget)
														{
															if (270610 - 515289 == -244678)
															{
																goto IL_221;
															}
															this.qMmIQZOdfJ.isAlert = true;
															if (120315 - 518175 != -397860)
															{
																goto IL_221;
															}
															this.SpKIINGRba = Time.time;
															if (100117 - 245001 != -144884)
															{
																goto IL_221;
															}
														}
													}
												}
											}
										}
									}
								}
								if (138322 - 196922 != -58599)
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

	// Token: 0x06000CEB RID: 3307 RVA: 0x0014921C File Offset: 0x0014741C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x00149220 File Offset: 0x00147420
	internal static bool QeqyMyly5RxGGTIltVv()
	{
		return true;
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x00149224 File Offset: 0x00147424
	internal static bool iVVmqLlSV5cHMHN5mnq()
	{
		return false;
	}

	// Token: 0x04000B45 RID: 2885
	private CharacterControl qMmIQZOdfJ;

	// Token: 0x04000B46 RID: 2886
	private StingQueen cfRIeqfZdo;

	// Token: 0x04000B47 RID: 2887
	public string AI_state;

	// Token: 0x04000B48 RID: 2888
	private float SpKIINGRba;

	// Token: 0x04000B49 RID: 2889
	private float yfLIJTMY8g;

	// Token: 0x04000B4A RID: 2890
	private float kJaI6w9Dr5;
}
