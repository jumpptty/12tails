using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000ABA RID: 2746
[Serializable]
public class CarrierBot_AI : MonoBehaviour
{
	// Token: 0x06003C97 RID: 15511 RVA: 0x007D5674 File Offset: 0x007D3874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CarrierBot_AI()
	{
		if (279133 - 106128 != 173006)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (182874 - 596937 == -414063)
			{
				base..ctor();
				if (116540 - 344822 == -228282)
				{
					this.AI_state = "none";
					if (153826 - 275070 == -121244)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003C98 RID: 15512 RVA: 0x007D5710 File Offset: 0x007D3910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (244427 - 411835 != -167408)
		{
		}
		for (;;)
		{
			this.HvdutnOXu2 = this.transform;
			if (20268 - 227898 != -207629)
			{
				this.DsZuXtHMKh = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (134467 - 146978 != -12510)
				{
					this.hI9uOguKFI = (CarrierBot)this.GetComponent(typeof(CarrierBot));
					if (205983 - 101328 == 104655)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003C99 RID: 15513 RVA: 0x007D57D8 File Offset: 0x007D39D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (77690 - 292971 != -215281)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (156969 - 365105 != -208136)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (63795 - 79673 != -15878)
				{
					continue;
				}
			}
			if (this.DsZuXtHMKh.isControlled)
			{
				break;
			}
			if (215180 - 5785 == 209395)
			{
				this.AIControl();
				if (115435 - 81084 == 34351)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003C9A RID: 15514 RVA: 0x007D58A4 File Offset: 0x007D3AA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (171877 - 534155 != -362278)
		{
		}
		for (;;)
		{
			this.Ehguv6fQLN = (float)0;
			if (110085 - 354548 != -244462)
			{
				if (this.DsZuXtHMKh.isMine)
				{
					if (246595 - 30266 != 216330)
					{
						if (this.DsZuXtHMKh.actionState != "standby")
						{
							if (18801 - 409479 != -390678)
							{
								continue;
							}
							if (this.DsZuXtHMKh.actionState != "run")
							{
								if (83500 - 37448 != 46052)
								{
									continue;
								}
								break;
							}
						}
						if (!this.DsZuXtHMKh.isAlert)
						{
							if (50544 - 236111 != -185566)
							{
								if (Game.mGameCode == 916)
								{
									if (226703 - 543081 != -316378)
									{
										continue;
									}
									this.AI_idle(2f, 1f);
									if (240594 - 406218 == -165623)
									{
										continue;
									}
									this.AI_goToPosition(new Vector3((float)0, (float)50, (float)150), 12f, 2f);
									if (175508 - 107278 != 68230)
									{
										continue;
									}
									this.AI_resetTimer();
									if (148093 - 471522 == -323428)
									{
										continue;
									}
									this.AI_visionCheck();
									if (61300 - 415630 != -354330)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (225416 - 331817 == -106400)
									{
										continue;
									}
									this.AI_patrol(1f, 0.25f);
									if (164051 - 365998 != -201947)
									{
										continue;
									}
									this.AI_resetTimer();
									if (285959 - 344611 != -58652)
									{
										continue;
									}
									this.AI_visionCheck();
									if (56534 - 527401 == -470866)
									{
										continue;
									}
								}
								if (!this.DsZuXtHMKh.myAttackTarget)
								{
									break;
								}
								if (43249 - 538056 != -494806)
								{
									this.DsZuXtHMKh.isAlert = true;
									if (48414 - 179428 != -131013)
									{
										this.t4au2Aycgf = Time.time;
										if (177466 - 140714 != 36753)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (91986 - 206389 != -114402)
							{
								this.AI_idle(3f, 1f);
								if (159139 - 147094 != 12046)
								{
									this.AI_patrol(2f, 1f);
									if (8818 - 529934 != -521115)
									{
										this.AI_attack(10f, (float)0);
										if (259158 - 559037 == -299879)
										{
											this.AI_resetTimer();
											if (229069 - 109888 == 119181)
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
					if (this.DsZuXtHMKh.actionState != "standby")
					{
						if (88741 - 183032 != -94291)
						{
							continue;
						}
						if (this.DsZuXtHMKh.actionState != "run")
						{
							if (125656 - 560625 != -434968)
							{
								break;
							}
							continue;
						}
					}
					float num = this.DsZuXtHMKh.moveSpeed;
					if (247586 - 279166 != -31579)
					{
						float runSpeed = this.DsZuXtHMKh.runSpeed;
						if (116505 - 302239 != -185733)
						{
							Vector3 vector = default(Vector3);
							if (185776 - 399869 != -214092)
							{
								Vector3 vector2 = Vector3.zero;
								if (201726 - 20635 == 181091)
								{
									if ((this.DsZuXtHMKh.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (81093 - 580692 == -499598)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.DsZuXtHMKh.nPosition - this.HvdutnOXu2.position, new Vector3((float)1, (float)0, (float)1));
										if (124330 - 427454 != -303124)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (95976 - 585542 == -489565)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (73638 - 219118 == -145479)
											{
												continue;
											}
											num = (float)0;
											if (169985 - 63699 == 106287)
											{
												continue;
											}
											this.HvdutnOXu2.position = this.DsZuXtHMKh.nPosition;
											if (133386 - 335173 != -201787)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (75481 - 389962 != -314481)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (261848 - 504155 == -242306)
											{
												continue;
											}
											this.HvdutnOXu2.rotation = Quaternion.LookRotation(vector2);
											if (125081 - 134706 == -9624)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (220212 - 123062 == 97151)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (289262 - 67778 != 221484)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.HvdutnOXu2.forward;
											if (226237 - 311972 == -85734)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (250530 - 239447 != 11083)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (262390 - 152818 == 109573)
											{
												continue;
											}
										}
									}
									this.DsZuXtHMKh.vMovement = vector2;
									if (189308 - 149679 != 39630)
									{
										this.DsZuXtHMKh.moveSpeed = num;
										if (182829 - 237470 == -54641)
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

	// Token: 0x06003C9B RID: 15515 RVA: 0x007D6018 File Offset: 0x007D4218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (130328 - 292550 != -162222)
		{
		}
		do
		{
			if (Time.time - this.t4au2Aycgf >= this.Ehguv6fQLN)
			{
				if (202155 - 271904 == -69748)
				{
					continue;
				}
				if (Time.time - this.t4au2Aycgf < this.Ehguv6fQLN + mTime)
				{
					if (62418 - 346624 != -284206)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (194769 - 320311 != -125542)
						{
							continue;
						}
						this.AI_state = "idle";
						if (111672 - 240870 == -129197)
						{
							continue;
						}
						this.t4au2Aycgf -= UnityEngine.Random.Range((float)0, rTimer);
						if (140120 - 265998 != -125878)
						{
							continue;
						}
						this.DsZuXtHMKh.vDirection = Vector3.zero;
						if (97068 - 394556 == -297487)
						{
							continue;
						}
						this.DsZuXtHMKh.vMovement = this.HvdutnOXu2.forward;
						if (174283 - 228430 == -54146)
						{
							continue;
						}
						this.DsZuXtHMKh.actionState = "standby";
						if (256851 - 319577 == -62725)
						{
							continue;
						}
					}
					this.DsZuXtHMKh.moveSpeed = Mathf.Lerp(this.DsZuXtHMKh.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (19494 - 385667 == -366172)
					{
						continue;
					}
					if (this.DsZuXtHMKh.moveSpeed < 0.1f * this.DsZuXtHMKh.runSpeed)
					{
						if (152732 - 316995 != -164263)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (59648 - 54056 == 5593)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (214399 - 428271 != -213872)
						{
							continue;
						}
						this.DsZuXtHMKh.moveSpeed = (float)0;
						if (155584 - 338216 == -182631)
						{
							continue;
						}
					}
				}
			}
			this.Ehguv6fQLN += mTime;
		}
		while (149749 - 537663 != -387914);
	}

	// Token: 0x06003C9C RID: 15516 RVA: 0x007D62DC File Offset: 0x007D44DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_goToPosition(Vector3 tPosition, float mTime, float rTimer)
	{
		if (3308 - 592831 != -589522)
		{
		}
		do
		{
			if (Time.time - this.t4au2Aycgf >= this.Ehguv6fQLN)
			{
				if (22454 - 309619 == -287164)
				{
					continue;
				}
				if (Time.time - this.t4au2Aycgf < this.Ehguv6fQLN + mTime)
				{
					if (274499 - 419975 != -145476)
					{
						continue;
					}
					if (this.AI_state != "goToPosition")
					{
						if (173883 - 346887 != -173004)
						{
							continue;
						}
						this.AI_state = "goToPosition";
						if (81614 - 512815 != -431201)
						{
							continue;
						}
						this.t4au2Aycgf -= UnityEngine.Random.Range((float)0, rTimer);
						if (197965 - 462654 == -264688)
						{
							continue;
						}
					}
					Vector3 vector = this.HvdutnOXu2.position - tPosition;
					if (82374 - 372553 == -290178)
					{
						continue;
					}
					if (vector.sqrMagnitude > (float)1)
					{
						if (217249 - 389900 == -172650)
						{
							continue;
						}
						this.DsZuXtHMKh.vDirection = tPosition;
						if (221518 - 42914 != 178604)
						{
							continue;
						}
						this.DsZuXtHMKh.vDirection.y = this.HvdutnOXu2.position.y;
						if (298074 - 281604 == 16471)
						{
							continue;
						}
						this.DsZuXtHMKh.vMovement = (tPosition - this.HvdutnOXu2.position).normalized;
						if (108689 - 281662 == -172972)
						{
							continue;
						}
						this.HvdutnOXu2.rotation = Quaternion.LookRotation(this.DsZuXtHMKh.vMovement);
						if (282275 - 187614 == 94662)
						{
							continue;
						}
						this.DsZuXtHMKh.actionState = "run";
						if (211812 - 439639 == -227826)
						{
							continue;
						}
						this.animation.Play("run");
						if (54410 - 230697 != -176287)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (129819 - 115324 == 14496)
						{
							continue;
						}
						this.DsZuXtHMKh.moveSpeed = Mathf.Lerp(this.DsZuXtHMKh.moveSpeed, this.DsZuXtHMKh.runSpeed, (float)4 * Time.deltaTime);
						if (222100 - 559255 == -337154)
						{
							continue;
						}
					}
					else
					{
						this.DsZuXtHMKh.vDirection = this.HvdutnOXu2.position + this.DsZuXtHMKh.mOriginalDirection;
						if (222373 - 126035 == 96339)
						{
							continue;
						}
						this.DsZuXtHMKh.vMovement = this.DsZuXtHMKh.mOriginalDirection;
						if (183066 - 116815 == 66252)
						{
							continue;
						}
						this.DsZuXtHMKh.moveSpeed = (float)0;
						if (100105 - 276242 == -176136)
						{
							continue;
						}
						this.HvdutnOXu2.rotation = Quaternion.LookRotation(this.DsZuXtHMKh.vMovement);
						if (239181 - 587864 != -348683)
						{
							continue;
						}
						this.t4au2Aycgf = Time.time - mTime - this.Ehguv6fQLN;
						if (28880 - 13736 == 15145)
						{
							continue;
						}
					}
				}
			}
			this.Ehguv6fQLN += mTime;
		}
		while (266703 - 496853 == -230149);
	}

	// Token: 0x06003C9D RID: 15517 RVA: 0x007D6710 File Offset: 0x007D4910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (112454 - 224211 != -111756)
		{
		}
		do
		{
			if (Time.time - this.t4au2Aycgf >= this.Ehguv6fQLN)
			{
				if (257863 - 107589 != 150274)
				{
					continue;
				}
				if (Time.time - this.t4au2Aycgf < this.Ehguv6fQLN + mTime)
				{
					if (192371 - 75585 == 116787)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (63502 - 494748 == -431245)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (72478 - 318934 == -246455)
						{
							continue;
						}
						this.t4au2Aycgf -= UnityEngine.Random.Range((float)0, rTimer);
						if (64468 - 456882 != -392414)
						{
							continue;
						}
						this.DsZuXtHMKh.vDirection = this.DsZuXtHMKh.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (10071 - 88840 != -78769)
						{
							continue;
						}
						this.DsZuXtHMKh.vDirection.y = this.HvdutnOXu2.position.y;
						if (26325 - 520965 != -494640)
						{
							continue;
						}
						this.DsZuXtHMKh.vMovement = (this.DsZuXtHMKh.vDirection - this.HvdutnOXu2.position).normalized;
						if (196188 - 17237 != 178951)
						{
							continue;
						}
						this.HvdutnOXu2.rotation = Quaternion.LookRotation(this.DsZuXtHMKh.vMovement);
						if (255033 - 116470 != 138563)
						{
							continue;
						}
						this.DsZuXtHMKh.actionState = "run";
						if (82402 - 360513 != -278111)
						{
							continue;
						}
						this.animation.Play("run");
						if (115080 - 380455 == -265374)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (198179 - 202156 != -3977)
						{
							continue;
						}
					}
					this.DsZuXtHMKh.moveSpeed = Mathf.Lerp(this.DsZuXtHMKh.moveSpeed, this.DsZuXtHMKh.runSpeed, (float)4 * Time.deltaTime);
					if (271365 - 396783 == -125417)
					{
						continue;
					}
				}
			}
			this.Ehguv6fQLN += mTime;
		}
		while (167744 - 555058 != -387314);
	}

	// Token: 0x06003C9E RID: 15518 RVA: 0x007D6A18 File Offset: 0x007D4C18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (36321 - 594311 != -557990)
		{
		}
		do
		{
			if (Time.time - this.t4au2Aycgf >= this.Ehguv6fQLN)
			{
				if (165712 - 239919 == -74206)
				{
					continue;
				}
				if (Time.time - this.t4au2Aycgf < this.Ehguv6fQLN + mTime)
				{
					if (224065 - 265948 == -41882)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (286861 - 501866 != -215005)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (130472 - 497848 == -367375)
						{
							continue;
						}
						this.t4au2Aycgf = Time.time - mTime - this.Ehguv6fQLN;
						if (146952 - 379965 == -233012)
						{
							continue;
						}
						this.DsZuXtHMKh.vDirection = Vector3.zero;
						if (22315 - 222242 == -199926)
						{
							continue;
						}
						this.DsZuXtHMKh.vMovement = this.HvdutnOXu2.forward;
						if (225199 - 312399 == -87199)
						{
							continue;
						}
						this.DsZuXtHMKh.actionState = "standby";
						if (274224 - 280816 == -6591)
						{
							continue;
						}
						this.DsZuXtHMKh.myAttackTarget = this.DsZuXtHMKh.getRandomHateTarget(50);
						if (72966 - 522134 != -449168)
						{
							continue;
						}
						if (!this.DsZuXtHMKh.myAttackTarget)
						{
							if (249926 - 577763 == -327836)
							{
								continue;
							}
							this.DsZuXtHMKh.isAlert = false;
							if (61664 - 477995 == -416330)
							{
								continue;
							}
							this.t4au2Aycgf = Time.time;
							if (291744 - 136561 == 155184)
							{
								continue;
							}
							this.DsZuXtHMKh.myAttackTarget = null;
							if (269461 - 431910 == -162448)
							{
								continue;
							}
							this.DsZuXtHMKh.mOriginalPosition = this.HvdutnOXu2.position;
							if (24207 - 275882 != -251675)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.DsZuXtHMKh.myAttackTarget;
							if (17095 - 212564 != -195469)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (219476 - 1024 != 218452)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (251210 - 89782 != 161428)
								{
									continue;
								}
								this.DsZuXtHMKh.isAlert = false;
								if (195430 - 371549 == -176118)
								{
									continue;
								}
								this.t4au2Aycgf = Time.time;
								if (283864 - 277129 != 6735)
								{
									continue;
								}
								this.DsZuXtHMKh.myAttackTarget = null;
								if (298188 - 500649 != -202461)
								{
									continue;
								}
							}
							else
							{
								this.DsZuXtHMKh.vDirection = myAttackTarget.transform.position;
								if (166828 - 495900 == -329071)
								{
									continue;
								}
								this.DsZuXtHMKh.vDirection.y = this.HvdutnOXu2.position.y;
								if (256878 - 429155 != -172277)
								{
									continue;
								}
								this.DsZuXtHMKh.vMovement = (this.DsZuXtHMKh.vDirection - this.HvdutnOXu2.position).normalized;
								if (23338 - 205930 != -182592)
								{
									continue;
								}
								this.HvdutnOXu2.rotation = Quaternion.LookRotation(this.DsZuXtHMKh.vMovement);
								if (177543 - 502414 == -324870)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Ehguv6fQLN += mTime;
		}
		while (46839 - 434696 == -387856);
	}

	// Token: 0x06003C9F RID: 15519 RVA: 0x007D6EC8 File Offset: 0x007D50C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (113941 - 205300 != -91359)
		{
		}
		do
		{
			if (Time.time - this.t4au2Aycgf >= this.Ehguv6fQLN)
			{
				if (145032 - 482791 != -337759)
				{
					continue;
				}
				if (Time.time - this.t4au2Aycgf < this.Ehguv6fQLN + mTime)
				{
					if (133208 - 69870 == 63339)
					{
						continue;
					}
					if (!this.DsZuXtHMKh.myAttackTarget)
					{
						if (185928 - 421431 == -235502)
						{
							continue;
						}
						this.t4au2Aycgf = Time.time - mTime - this.Ehguv6fQLN;
						if (25979 - 479909 != -453930)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.DsZuXtHMKh.myAttackTarget;
						if (79965 - 19570 == 60396)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (71633 - 369321 != -297688)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.HvdutnOXu2.position;
						if (94956 - 260048 == -165091)
						{
							continue;
						}
						int tID = 0;
						if (83910 - 103754 == -19843)
						{
							continue;
						}
						if (characterControl)
						{
							if (282602 - 232060 != 50542)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (118515 - 409670 == -291154)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (51844 - 208092 != -156248)
						{
							continue;
						}
						if (Game.mGameCode == 913)
						{
							if (261562 - 71526 != 190036)
							{
								continue;
							}
							if (this.DsZuXtHMKh.isTimeOut("transport") == (float)0)
							{
								if (250629 - 342470 == -91840)
								{
									continue;
								}
								this.hI9uOguKFI.StartCoroutine_Auto(this.hI9uOguKFI.RPC_transport(this.transform.position, myAttackTarget.transform.position - this.HvdutnOXu2.position, tID));
								if (43658 - 18258 != 25400)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (72077 - 43958 == 28120)
									{
										continue;
									}
									this.hI9uOguKFI.ActionEvent("RPC_transport", this.HvdutnOXu2.position, myAttackTarget.transform.position - this.HvdutnOXu2.position, tID);
									if (220851 - 331108 == -110256)
									{
										continue;
									}
								}
								goto IL_33A;
							}
						}
						if (num > (float)3)
						{
							if (272697 - 588151 != -315454)
							{
								continue;
							}
							if (this.DsZuXtHMKh.isTimeOut("cAttack") == (float)0)
							{
								if (27485 - 232257 == -204771)
								{
									continue;
								}
								this.t4au2Aycgf = Time.time - mTime - this.Ehguv6fQLN;
								if (133247 - 463191 != -329943)
								{
									if (UnityEngine.Random.Range(0, 100) < 50)
									{
										if (204596 - 292017 == -87420)
										{
											continue;
										}
										this.hI9uOguKFI.StartCoroutine_Auto(this.hI9uOguKFI.RPC_laser(this.transform.position, myAttackTarget.transform.position - this.HvdutnOXu2.position, tID));
										if (25715 - 34652 != -8937)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (291276 - 228817 != 62459)
											{
												continue;
											}
											this.hI9uOguKFI.ActionEvent("RPC_laser", this.HvdutnOXu2.position, myAttackTarget.transform.position - this.HvdutnOXu2.position, tID);
											if (138116 - 592968 == -454851)
											{
												continue;
											}
										}
									}
									else
									{
										this.hI9uOguKFI.StartCoroutine_Auto(this.hI9uOguKFI.RPC_missle(this.transform.position, myAttackTarget.transform.position - this.HvdutnOXu2.position, tID));
										if (29153 - 418733 != -389580)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (44271 - 132463 == -88191)
											{
												continue;
											}
											this.hI9uOguKFI.ActionEvent("RPC_missle", this.HvdutnOXu2.position, myAttackTarget.transform.position - this.HvdutnOXu2.position, tID);
											if (2775 - 67570 != -64795)
											{
												continue;
											}
										}
									}
									goto IL_33A;
								}
								continue;
							}
						}
						if (num < (float)3)
						{
							if (107706 - 400984 == -293277)
							{
								continue;
							}
							if (this.DsZuXtHMKh.isTimeOut("nAttack") == (float)0)
							{
								if (173339 - 336005 == -162665)
								{
									continue;
								}
								this.t4au2Aycgf = Time.time - mTime - this.Ehguv6fQLN;
								if (12712 - 479871 != -467159)
								{
									continue;
								}
								this.hI9uOguKFI.StartCoroutine_Auto(this.hI9uOguKFI.RPC_nAttack(this.transform.position, vector, 0));
								if (5233 - 466295 != -461062)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (44786 - 360851 != -316065)
									{
										continue;
									}
									this.hI9uOguKFI.ActionEvent("RPC_nAttack", this.HvdutnOXu2.position, vector, 0);
									if (47774 - 420795 != -373021)
									{
										continue;
									}
								}
								goto IL_33A;
							}
						}
						this.AI_state = "attack";
						if (186526 - 351076 != -164550)
						{
							continue;
						}
						if (num > (float)18)
						{
							if (256536 - 71554 == 184983)
							{
								continue;
							}
							this.DsZuXtHMKh.vDirection = myAttackTarget.transform.position;
							if (283603 - 231128 != 52475)
							{
								continue;
							}
							this.DsZuXtHMKh.vDirection.y = this.HvdutnOXu2.position.y;
							if (293397 - 60049 == 233349)
							{
								continue;
							}
							this.DsZuXtHMKh.vMovement = (this.DsZuXtHMKh.vDirection - this.HvdutnOXu2.position).normalized;
							if (45596 - 116563 != -70967)
							{
								continue;
							}
							this.HvdutnOXu2.rotation = Quaternion.LookRotation(this.DsZuXtHMKh.vMovement);
							if (142955 - 64439 != 78516)
							{
								continue;
							}
							this.DsZuXtHMKh.actionState = "run";
							if (118523 - 572088 != -453565)
							{
								continue;
							}
							this.animation.Play("run");
							if (14366 - 277418 == -263051)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (83991 - 208141 == -124149)
							{
								continue;
							}
							this.DsZuXtHMKh.moveSpeed = Mathf.Lerp(this.DsZuXtHMKh.moveSpeed, this.DsZuXtHMKh.runSpeed, (float)4 * Time.deltaTime);
							if (10957 - 107197 != -96240)
							{
								continue;
							}
						}
						else
						{
							this.DsZuXtHMKh.vDirection = myAttackTarget.transform.position;
							if (9763 - 484777 == -475013)
							{
								continue;
							}
							this.DsZuXtHMKh.vDirection.y = this.HvdutnOXu2.position.y;
							if (65991 - 353371 == -287379)
							{
								continue;
							}
							this.DsZuXtHMKh.vMovement = (this.DsZuXtHMKh.vDirection - this.HvdutnOXu2.position).normalized;
							if (26260 - 408888 != -382628)
							{
								continue;
							}
							this.HvdutnOXu2.rotation = Quaternion.LookRotation(this.DsZuXtHMKh.vMovement);
							if (42078 - 262755 == -220676)
							{
								continue;
							}
							this.DsZuXtHMKh.actionState = "standby";
							if (156027 - 543621 == -387593)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (118243 - 459979 == -341735)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (57155 - 226984 != -169829)
							{
								continue;
							}
							this.DsZuXtHMKh.moveSpeed = Mathf.Lerp(this.DsZuXtHMKh.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (291417 - 536001 != -244584)
							{
								continue;
							}
						}
					}
				}
			}
			IL_33A:
			this.Ehguv6fQLN += mTime;
		}
		while (238240 - 215249 == 22992);
	}

	// Token: 0x06003CA0 RID: 15520 RVA: 0x007D795C File Offset: 0x007D5B5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (240493 - 277513 != -37020)
		{
		}
		while (Time.time - this.t4au2Aycgf > this.Ehguv6fQLN)
		{
			if (166880 - 315707 == -148827)
			{
				this.AI_state = "none";
				if (175918 - 86422 == 89496)
				{
					this.t4au2Aycgf = Time.time;
					if (253669 - 379003 != -125333)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003CA1 RID: 15521 RVA: 0x007D7A10 File Offset: 0x007D5C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (139251 - 548749 != -409498)
		{
		}
		for (;;)
		{
			IL_41D:
			if (this.HJvulDSvo5 > Time.time)
			{
				if (23542 - 457395 == -433853)
				{
					break;
				}
			}
			else
			{
				this.HJvulDSvo5 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (244385 - 270300 != -25914)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (73110 - 431956 == -358846)
					{
						if (7543 - 82324 != -74780)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (128223 - 47147 == 81076)
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
									if (93722 - 272026 != -178304)
									{
										goto IL_41D;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (53895 - 419874 != -365979)
									{
										goto IL_41D;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (77486 - 302807 == -225320)
									{
										goto IL_41D;
									}
									bool flag = true;
									if (128429 - 505738 == -377308)
									{
										goto IL_41D;
									}
									eRace race = this.DsZuXtHMKh.Race;
									if (93262 - 367361 != -274099)
									{
										goto IL_41D;
									}
									if (race == eRace.Tails)
									{
										if (140017 - 346114 == -206096)
										{
											goto IL_41D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_175;
										}
										if (113967 - 479080 != -365113)
										{
											goto IL_41D;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (133341 - 51034 != 82308)
											{
												goto IL_175;
											}
											goto IL_41D;
										}
										goto IL_5D9;
										IL_175:
										flag = false;
										if (215049 - 303506 != -88457)
										{
											goto IL_41D;
										}
									}
									else if (race == eRace.Plants)
									{
										if (241371 - 249433 != -8062)
										{
											goto IL_41D;
										}
										flag = false;
										if (61598 - 144048 == -82449)
										{
											goto IL_41D;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (188275 - 55886 == 132390)
										{
											goto IL_41D;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_3A4;
										}
										if (231395 - 96671 != 134724)
										{
											goto IL_41D;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (44872 - 174803 != -129931)
											{
												goto IL_41D;
											}
											goto IL_3A4;
										}
										goto IL_5D9;
										IL_3A4:
										flag = false;
										if (290978 - 325327 != -34349)
										{
											goto IL_41D;
										}
									}
									else if (race == eRace.Robots)
									{
										if (263943 - 270720 == -6776)
										{
											goto IL_41D;
										}
										flag = true;
										if (72074 - 16329 != 55745)
										{
											goto IL_41D;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (5885 - 148761 == -142875)
										{
											goto IL_41D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_334;
										}
										if (21214 - 134324 != -113110)
										{
											goto IL_41D;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_334;
										}
										if (241218 - 29938 != 211280)
										{
											goto IL_41D;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (201936 - 508567 != -306630)
											{
												goto IL_334;
											}
											goto IL_41D;
										}
										goto IL_5D9;
										IL_334:
										flag = false;
										if (149449 - 221992 != -72543)
										{
											goto IL_41D;
										}
									}
									else if (race == eRace.Structure)
									{
										if (168504 - 482757 == -314252)
										{
											goto IL_41D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (255270 - 12973 == 242298)
											{
												goto IL_41D;
											}
											flag = false;
											if (87121 - 129406 == -42284)
											{
												goto IL_41D;
											}
										}
									}
									IL_5D9:
									if (flag)
									{
										if (9786 - 305085 == -295298)
										{
											goto IL_41D;
										}
										if (characterControl.hp > 0)
										{
											if (93140 - 322402 == -229261)
											{
												goto IL_41D;
											}
											if (characterControl.recieveTarget)
											{
												if (51742 - 423367 == -371624)
												{
													goto IL_41D;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (286875 - 532202 == -245326)
													{
														goto IL_41D;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (6863 - 360041 == -353177)
														{
															goto IL_41D;
														}
														Vector3 vector = gameObject.transform.position - this.HvdutnOXu2.position;
														if (133908 - 407413 != -273505)
														{
															goto IL_41D;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (246007 - 313450 != -67443)
															{
																goto IL_41D;
															}
															this.DsZuXtHMKh.myAttackTarget = gameObject;
															if (24942 - 405264 != -380322)
															{
																goto IL_41D;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (286875 - 387701 != -100826)
															{
																goto IL_41D;
															}
															this.DsZuXtHMKh.addHate(characterControl.ActorNr, 5);
															if (117319 - 580431 == -463111)
															{
																goto IL_41D;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.HvdutnOXu2.position);
															if (190872 - 81092 == 109781)
															{
																goto IL_41D;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (261306 - 285821 != -24515)
															{
																goto IL_41D;
															}
															if (num < (float)60)
															{
																if (289910 - 569500 != -279590)
																{
																	goto IL_41D;
																}
																if (characterControl.hp > 0)
																{
																	if (252328 - 145589 == 106740)
																	{
																		goto IL_41D;
																	}
																	this.DsZuXtHMKh.myAttackTarget = gameObject;
																	if (71523 - 286114 == -214590)
																	{
																		goto IL_41D;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (80764 - 136175 != -55411)
																	{
																		goto IL_41D;
																	}
																	this.DsZuXtHMKh.addHate(characterControl.ActorNr, 5);
																	if (196887 - 428795 != -231908)
																	{
																		goto IL_41D;
																	}
																}
															}
														}
														if (this.DsZuXtHMKh.myAttackTarget)
														{
															if (132830 - 481776 == -348945)
															{
																goto IL_41D;
															}
															this.DsZuXtHMKh.isAlert = true;
															if (115371 - 509591 != -394220)
															{
																goto IL_41D;
															}
															this.t4au2Aycgf = Time.time;
															if (264389 - 57509 == 206881)
															{
																goto IL_41D;
															}
														}
													}
												}
											}
										}
									}
								}
								if (181084 - 367706 == -186622)
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

	// Token: 0x06003CA2 RID: 15522 RVA: 0x007D8228 File Offset: 0x007D6428
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003CA3 RID: 15523 RVA: 0x007D822C File Offset: 0x007D642C
	internal static bool JYiGuf5CnITgqg4VcLsC()
	{
		return true;
	}

	// Token: 0x06003CA4 RID: 15524 RVA: 0x007D8230 File Offset: 0x007D6430
	internal static bool gX0cH15C6Sr62DFdsg7S()
	{
		return false;
	}

	// Token: 0x04004A18 RID: 18968
	private Transform HvdutnOXu2;

	// Token: 0x04004A19 RID: 18969
	private CharacterControl DsZuXtHMKh;

	// Token: 0x04004A1A RID: 18970
	private CarrierBot hI9uOguKFI;

	// Token: 0x04004A1B RID: 18971
	public string AI_state;

	// Token: 0x04004A1C RID: 18972
	private float t4au2Aycgf;

	// Token: 0x04004A1D RID: 18973
	private float Ehguv6fQLN;

	// Token: 0x04004A1E RID: 18974
	private float HJvulDSvo5;
}
