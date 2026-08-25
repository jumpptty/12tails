using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C42 RID: 3138
[Serializable]
public class FirstWhale_AI : MonoBehaviour
{
	// Token: 0x06004623 RID: 17955 RVA: 0x008C3ACC File Offset: 0x008C1CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FirstWhale_AI()
	{
		if (35978 - 204977 != -168998)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (289496 - 273681 == 15815)
			{
				base..ctor();
				if (138243 - 486010 == -347767)
				{
					this.AI_state = "none";
					if (133189 - 438782 == -305593)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004624 RID: 17956 RVA: 0x008C3B68 File Offset: 0x008C1D68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.PVsK6k3TqL = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.qUFKtP5UOD = (FirstWhale)this.GetComponent(typeof(FirstWhale));
	}

	// Token: 0x06004625 RID: 17957 RVA: 0x008C3BA0 File Offset: 0x008C1DA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (232547 - 524216 != -291668)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (280883 - 409504 == -128620)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (6959 - 349336 == -342376)
				{
					continue;
				}
			}
			if (this.PVsK6k3TqL.isControlled)
			{
				break;
			}
			if (248362 - 200590 == 47772)
			{
				this.AIControl();
				if (70278 - 346939 == -276661)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004626 RID: 17958 RVA: 0x008C3C6C File Offset: 0x008C1E6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (4584 - 518364 != -513779)
		{
		}
		for (;;)
		{
			this.W8SKOTejpx = (float)0;
			if (122024 - 92027 == 29997)
			{
				if (this.PVsK6k3TqL.isMine)
				{
					if (290383 - 363829 == -73446)
					{
						if (this.PVsK6k3TqL.actionState != "standby")
						{
							if (5339 - 394612 != -389273)
							{
								continue;
							}
							if (this.PVsK6k3TqL.actionState != "run")
							{
								if (246459 - 386263 != -139804)
								{
									continue;
								}
								break;
							}
						}
						if (!this.PVsK6k3TqL.isAlert)
						{
							if (219714 - 54558 == 165156)
							{
								this.AI_idle(3f, 1f);
								if (121819 - 129824 == -8005)
								{
									this.AI_patrol(1f, 0.25f);
									if (40475 - 511995 != -471519)
									{
										this.AI_resetTimer();
										if (226719 - 407239 == -180520)
										{
											this.AI_visionCheck();
											if (167949 - 571260 == -403311)
											{
												if (!this.PVsK6k3TqL.myAttackTarget)
												{
													break;
												}
												if (242377 - 469140 != -226762)
												{
													this.PVsK6k3TqL.isAlert = true;
													if (63479 - 206643 == -143164)
													{
														this.JmQKXpvQ43 = Time.time;
														if (108363 - 113615 == -5252)
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
							if (271156 - 284015 != -12858)
							{
								this.AI_idle(2f, 1f);
								if (283925 - 31644 == 252281)
								{
									this.AI_attack(5f, (float)0);
									if (131769 - 452058 != -320288)
									{
										this.AI_resetTimer();
										if (158268 - 292419 == -134151)
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
					if (this.PVsK6k3TqL.actionState != "standby")
					{
						if (206804 - 163173 != 43631)
						{
							continue;
						}
						if (this.PVsK6k3TqL.actionState != "run")
						{
							if (113317 - 58959 != 54359)
							{
								break;
							}
							continue;
						}
					}
					float num = this.PVsK6k3TqL.moveSpeed;
					if (66471 - 480581 == -414110)
					{
						float runSpeed = this.PVsK6k3TqL.runSpeed;
						if (114988 - 369176 == -254188)
						{
							Vector3 vector = default(Vector3);
							if (262937 - 295780 != -32842)
							{
								Vector3 vector2 = Vector3.zero;
								if (137540 - 245391 == -107851)
								{
									if ((this.PVsK6k3TqL.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (155095 - 3159 != 151936)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.PVsK6k3TqL.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (229958 - 319309 != -89351)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (31178 - 16044 == 15135)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (80588 - 317338 == -236749)
											{
												continue;
											}
											num = (float)0;
											if (87711 - 96548 == -8836)
											{
												continue;
											}
											this.transform.position = this.PVsK6k3TqL.nPosition;
											if (223565 - 118215 != 105350)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (219673 - 116317 != 103356)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (207451 - 393901 != -186450)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (155071 - 18662 != 136409)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (217619 - 383448 == -165828)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (167471 - 402408 == -234936)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (231153 - 31249 != 199904)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (123397 - 404195 == -280797)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (244305 - 512741 == -268435)
											{
												continue;
											}
										}
									}
									this.PVsK6k3TqL.vMovement = vector2;
									if (274839 - 565888 == -291049)
									{
										this.PVsK6k3TqL.moveSpeed = num;
										if (113109 - 428710 != -315600)
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

	// Token: 0x06004627 RID: 17959 RVA: 0x008C42E4 File Offset: 0x008C24E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (227657 - 282834 != -55176)
		{
		}
		do
		{
			if (Time.time - this.JmQKXpvQ43 >= this.W8SKOTejpx)
			{
				if (285975 - 42331 == 243645)
				{
					continue;
				}
				if (Time.time - this.JmQKXpvQ43 < this.W8SKOTejpx + mTime)
				{
					if (161068 - 146607 == 14462)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (49452 - 107163 == -57710)
						{
							continue;
						}
						this.AI_state = "idle";
						if (180366 - 85710 == 94657)
						{
							continue;
						}
						this.JmQKXpvQ43 -= UnityEngine.Random.Range((float)0, rTimer);
						if (297209 - 93758 != 203451)
						{
							continue;
						}
						this.PVsK6k3TqL.vDirection = Vector3.zero;
						if (69975 - 124139 != -54164)
						{
							continue;
						}
						this.PVsK6k3TqL.vMovement = this.transform.forward;
						if (79177 - 477674 == -398496)
						{
							continue;
						}
						this.PVsK6k3TqL.actionState = "standby";
						if (100781 - 340547 == -239765)
						{
							continue;
						}
					}
					this.PVsK6k3TqL.moveSpeed = Mathf.Lerp(this.PVsK6k3TqL.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (28735 - 184953 == -156217)
					{
						continue;
					}
					if (this.PVsK6k3TqL.moveSpeed < 0.1f * this.PVsK6k3TqL.runSpeed)
					{
						if (1598 - 118841 != -117243)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (59217 - 506759 == -447541)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (177994 - 541051 == -363056)
						{
							continue;
						}
						this.PVsK6k3TqL.moveSpeed = (float)0;
						if (94391 - 512412 != -418021)
						{
							continue;
						}
					}
				}
			}
			this.W8SKOTejpx += mTime;
		}
		while (231846 - 572101 != -340255);
	}

	// Token: 0x06004628 RID: 17960 RVA: 0x008C45A8 File Offset: 0x008C27A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (24883 - 450566 != -425683)
		{
		}
		do
		{
			if (Time.time - this.JmQKXpvQ43 >= this.W8SKOTejpx)
			{
				if (49324 - 528422 != -479098)
				{
					continue;
				}
				if (Time.time - this.JmQKXpvQ43 < this.W8SKOTejpx + mTime)
				{
					if (263057 - 270214 != -7157)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (190353 - 328678 == -138324)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (145051 - 380055 != -235004)
						{
							continue;
						}
						this.JmQKXpvQ43 -= UnityEngine.Random.Range((float)0, rTimer);
						if (12737 - 165099 != -152362)
						{
							continue;
						}
						this.PVsK6k3TqL.vDirection = this.PVsK6k3TqL.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (36538 - 529171 != -492633)
						{
							continue;
						}
						this.PVsK6k3TqL.vDirection.y = this.transform.position.y;
						if (256281 - 425602 == -169320)
						{
							continue;
						}
						this.PVsK6k3TqL.vMovement = (this.PVsK6k3TqL.vDirection - this.transform.position).normalized;
						if (127714 - 136030 == -8315)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.PVsK6k3TqL.vMovement);
						if (100337 - 536084 == -435746)
						{
							continue;
						}
						this.PVsK6k3TqL.actionState = "run";
						if (27520 - 436710 != -409190)
						{
							continue;
						}
						this.animation.Play("run");
						if (298124 - 20885 != 277239)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (114118 - 408584 == -294465)
						{
							continue;
						}
					}
					this.PVsK6k3TqL.moveSpeed = Mathf.Lerp(this.PVsK6k3TqL.moveSpeed, this.PVsK6k3TqL.runSpeed, (float)4 * Time.deltaTime);
					if (188992 - 481858 != -292866)
					{
						continue;
					}
				}
			}
			this.W8SKOTejpx += mTime;
		}
		while (279909 - 295693 != -15784);
	}

	// Token: 0x06004629 RID: 17961 RVA: 0x008C48B0 File Offset: 0x008C2AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (51753 - 74443 != -22689)
		{
		}
		do
		{
			if (Time.time - this.JmQKXpvQ43 >= this.W8SKOTejpx)
			{
				if (238181 - 397148 != -158967)
				{
					continue;
				}
				if (Time.time - this.JmQKXpvQ43 < this.W8SKOTejpx + mTime)
				{
					if (249252 - 533350 != -284098)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (135714 - 129494 != 6220)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (158012 - 332955 == -174942)
						{
							continue;
						}
						this.JmQKXpvQ43 = Time.time - mTime - this.W8SKOTejpx;
						if (6726 - 114194 != -107468)
						{
							continue;
						}
						this.PVsK6k3TqL.vDirection = Vector3.zero;
						if (296204 - 45656 != 250548)
						{
							continue;
						}
						this.PVsK6k3TqL.vMovement = this.transform.forward;
						if (298034 - 49659 != 248375)
						{
							continue;
						}
						this.PVsK6k3TqL.actionState = "standby";
						if (223050 - 497123 != -274073)
						{
							continue;
						}
						this.PVsK6k3TqL.myAttackTarget = this.PVsK6k3TqL.getHateTarget(5, 50);
						if (259395 - 494935 == -235539)
						{
							continue;
						}
						if (!this.PVsK6k3TqL.myAttackTarget)
						{
							if (48548 - 136323 != -87775)
							{
								continue;
							}
							this.PVsK6k3TqL.isAlert = false;
							if (141837 - 142490 != -653)
							{
								continue;
							}
							this.JmQKXpvQ43 = Time.time;
							if (65973 - 16533 == 49441)
							{
								continue;
							}
							this.PVsK6k3TqL.myAttackTarget = null;
							if (56018 - 279539 == -223520)
							{
								continue;
							}
							this.PVsK6k3TqL.mOriginalPosition = this.transform.position;
							if (259571 - 360399 != -100827)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.PVsK6k3TqL.myAttackTarget;
							if (263666 - 141471 != 122195)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (50907 - 143531 != -92624)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (31954 - 429893 != -397939)
								{
									continue;
								}
								this.PVsK6k3TqL.isAlert = false;
								if (25721 - 101412 == -75690)
								{
									continue;
								}
								this.JmQKXpvQ43 = Time.time;
								if (211502 - 128340 != 83162)
								{
									continue;
								}
								this.PVsK6k3TqL.myAttackTarget = null;
								if (36684 - 266070 == -229385)
								{
									continue;
								}
							}
							else
							{
								this.PVsK6k3TqL.vDirection = myAttackTarget.transform.position;
								if (252036 - 390142 == -138105)
								{
									continue;
								}
								this.PVsK6k3TqL.vDirection.y = this.transform.position.y;
								if (69134 - 290655 != -221521)
								{
									continue;
								}
								this.PVsK6k3TqL.vMovement = (this.PVsK6k3TqL.vDirection - this.transform.position).normalized;
								if (186700 - 191292 == -4591)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.PVsK6k3TqL.vMovement);
								if (122871 - 291593 == -168721)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.W8SKOTejpx += mTime;
		}
		while (154167 - 88882 != 65285);
	}

	// Token: 0x0600462A RID: 17962 RVA: 0x008C4D60 File Offset: 0x008C2F60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (144460 - 513644 != -369183)
		{
		}
		do
		{
			if (Time.time - this.JmQKXpvQ43 >= this.W8SKOTejpx)
			{
				if (162198 - 524174 != -361976)
				{
					continue;
				}
				if (Time.time - this.JmQKXpvQ43 < this.W8SKOTejpx + mTime)
				{
					if (187906 - 261106 == -73199)
					{
						continue;
					}
					if (!this.PVsK6k3TqL.myAttackTarget)
					{
						if (164277 - 548565 != -384288)
						{
							continue;
						}
						this.JmQKXpvQ43 = Time.time - mTime - this.W8SKOTejpx;
						if (224724 - 164010 != 60714)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.PVsK6k3TqL.myAttackTarget;
						if (211487 - 49285 != 162202)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (128766 - 59206 != 69560)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (16502 - 247960 == -231457)
						{
							continue;
						}
						int tID = 0;
						if (243961 - 278676 == -34714)
						{
							continue;
						}
						if (characterControl)
						{
							if (24901 - 422410 == -397508)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (31284 - 570844 != -539560)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (44315 - 408848 != -364533)
						{
							continue;
						}
						if ((float)this.PVsK6k3TqL.hp < 0.3f * (float)this.PVsK6k3TqL.mhp)
						{
							if (175809 - 125209 == 50601)
							{
								continue;
							}
							if (this.PVsK6k3TqL.mp > 50)
							{
								if (198094 - 36101 == 161994)
								{
									continue;
								}
								if (this.PVsK6k3TqL.isTimeOut("megalodon") == (float)0)
								{
									if (1860 - 586320 == -584459)
									{
										continue;
									}
									this.JmQKXpvQ43 = Time.time - mTime - this.W8SKOTejpx;
									if (86044 - 588906 != -502862)
									{
										continue;
									}
									this.qUFKtP5UOD.StartCoroutine_Auto(this.qUFKtP5UOD.RPC_megalodon(this.transform.position, this.transform.forward, tID));
									if (285260 - 521489 != -236228)
									{
										if (PhotonClient.IsInitialized())
										{
											if (278853 - 298908 == -20054)
											{
												continue;
											}
											this.qUFKtP5UOD.ActionEvent("RPC_megalodon", this.transform.position, this.transform.forward, tID);
											if (180880 - 497817 != -316937)
											{
												continue;
											}
										}
										goto IL_238;
									}
									continue;
								}
							}
						}
						if ((float)this.PVsK6k3TqL.hp < 0.5f * (float)this.PVsK6k3TqL.mhp)
						{
							if (40203 - 280622 != -240419)
							{
								continue;
							}
							if (this.PVsK6k3TqL.isTimeOut("damageBounce") == (float)0)
							{
								if (10156 - 224487 != -214331)
								{
									continue;
								}
								this.JmQKXpvQ43 = Time.time - mTime - this.W8SKOTejpx;
								if (291525 - 388483 != -96958)
								{
									continue;
								}
								this.qUFKtP5UOD.StartCoroutine_Auto(this.qUFKtP5UOD.RPC_damageBounce(this.transform.position, this.transform.forward, tID));
								if (200121 - 279561 != -79440)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (215427 - 124699 != 90728)
									{
										continue;
									}
									this.qUFKtP5UOD.ActionEvent("RPC_damageBounce", this.transform.position, this.transform.forward, tID);
									if (9975 - 60261 == -50285)
									{
										continue;
									}
								}
								goto IL_238;
							}
						}
						if (num > (float)12)
						{
							if (148378 - 259758 != -111380)
							{
								continue;
							}
							if ((float)this.PVsK6k3TqL.hp < 0.7f * (float)this.PVsK6k3TqL.mhp)
							{
								if (21031 - 307340 != -286309)
								{
									continue;
								}
								if (this.PVsK6k3TqL.isTimeOut("hydroBlast") == (float)0)
								{
									if (226429 - 154867 == 71563)
									{
										continue;
									}
									this.JmQKXpvQ43 = Time.time - mTime - this.W8SKOTejpx;
									if (201645 - 412308 != -210663)
									{
										continue;
									}
									this.qUFKtP5UOD.StartCoroutine_Auto(this.qUFKtP5UOD.RPC_hydroBlast(this.transform.position, vector, tID));
									if (228962 - 597453 != -368490)
									{
										if (PhotonClient.IsInitialized())
										{
											if (255673 - 47203 == 208471)
											{
												continue;
											}
											this.qUFKtP5UOD.ActionEvent("RPC_hydroBlast", this.transform.position, vector, tID);
											if (281307 - 179823 != 101484)
											{
												continue;
											}
										}
										goto IL_238;
									}
									continue;
								}
							}
						}
						if ((float)this.PVsK6k3TqL.hp < 0.8f * (float)this.PVsK6k3TqL.mhp)
						{
							if (51876 - 431550 == -379673)
							{
								continue;
							}
							if (this.PVsK6k3TqL.sp > 50)
							{
								if (63378 - 146351 == -82972)
								{
									continue;
								}
								if (this.PVsK6k3TqL.isTimeOut("stomp") == (float)0)
								{
									if (145266 - 536881 != -391615)
									{
										continue;
									}
									this.JmQKXpvQ43 = Time.time - mTime - this.W8SKOTejpx;
									if (93133 - 310309 == -217175)
									{
										continue;
									}
									this.qUFKtP5UOD.StartCoroutine_Auto(this.qUFKtP5UOD.RPC_stomp(this.transform.position, vector.normalized, tID));
									if (228938 - 166095 != 62843)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (143614 - 213107 != -69493)
										{
											continue;
										}
										this.qUFKtP5UOD.ActionEvent("RPC_stomp", this.transform.position, vector.normalized, tID);
										if (243070 - 519771 != -276701)
										{
											continue;
										}
									}
									goto IL_238;
								}
							}
						}
						if (num < (float)8)
						{
							if (292341 - 252089 != 40252)
							{
								continue;
							}
							if (this.PVsK6k3TqL.isTimeOut("sweep") == (float)0)
							{
								if (7228 - 173219 != -165991)
								{
									continue;
								}
								this.JmQKXpvQ43 = Time.time - mTime - this.W8SKOTejpx;
								if (226851 - 374415 == -147563)
								{
									continue;
								}
								this.qUFKtP5UOD.StartCoroutine_Auto(this.qUFKtP5UOD.RPC_sweep(this.transform.position, vector.normalized, tID));
								if (173884 - 577191 != -403307)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (144067 - 530499 == -386431)
									{
										continue;
									}
									this.qUFKtP5UOD.ActionEvent("RPC_sweep", this.transform.position, vector.normalized, tID);
									if (158915 - 293039 == -134123)
									{
										continue;
									}
								}
								goto IL_238;
							}
						}
						if (!this.PVsK6k3TqL.hasStatus("bubbleShield"))
						{
							if (147354 - 90755 == 56600)
							{
								continue;
							}
							if (this.PVsK6k3TqL.isTimeOut("bubbleShield") == (float)0)
							{
								if (132583 - 591954 == -459370)
								{
									continue;
								}
								this.JmQKXpvQ43 = Time.time - mTime - this.W8SKOTejpx;
								if (193613 - 482812 == -289198)
								{
									continue;
								}
								this.qUFKtP5UOD.StartCoroutine_Auto(this.qUFKtP5UOD.RPC_bubbleShield(this.transform.position, this.transform.forward, this.PVsK6k3TqL.ActorNr));
								if (23196 - 28997 != -5801)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (210551 - 587048 != -376497)
									{
										continue;
									}
									this.qUFKtP5UOD.ActionEvent("RPC_bubbleShield", this.transform.position, this.transform.forward, this.PVsK6k3TqL.ActorNr);
									if (139475 - 358981 == -219505)
									{
										continue;
									}
								}
								goto IL_238;
							}
						}
						if (num > (float)8)
						{
							if (140318 - 91321 != 48997)
							{
								continue;
							}
							if (this.PVsK6k3TqL.isTimeOut("javelin") == (float)0)
							{
								if (239145 - 219679 != 19466)
								{
									continue;
								}
								this.JmQKXpvQ43 = Time.time - mTime - this.W8SKOTejpx;
								if (183887 - 452791 != -268904)
								{
									continue;
								}
								this.qUFKtP5UOD.StartCoroutine_Auto(this.qUFKtP5UOD.RPC_javelin(this.transform.position, vector, tID));
								if (151764 - 177808 != -26043)
								{
									if (PhotonClient.IsInitialized())
									{
										if (180994 - 41198 == 139797)
										{
											continue;
										}
										this.qUFKtP5UOD.ActionEvent("RPC_javelin", this.transform.position, vector, tID);
										if (269944 - 552858 != -282914)
										{
											continue;
										}
									}
									goto IL_238;
								}
								continue;
							}
						}
						if (num < (float)8)
						{
							if (224621 - 326905 == -102283)
							{
								continue;
							}
							if (this.PVsK6k3TqL.isTimeOut("nAttack") == (float)0)
							{
								if (229615 - 51921 == 177695)
								{
									continue;
								}
								this.JmQKXpvQ43 = Time.time - mTime - this.W8SKOTejpx;
								if (245110 - 343269 == -98158)
								{
									continue;
								}
								this.qUFKtP5UOD.StartCoroutine_Auto(this.qUFKtP5UOD.RPC_nAttack(this.transform.position, vector.normalized, tID));
								if (128269 - 574516 != -446247)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (26847 - 518629 != -491782)
									{
										continue;
									}
									this.qUFKtP5UOD.ActionEvent("RPC_nAttack", this.transform.position, vector.normalized, tID);
									if (245310 - 337188 == -91877)
									{
										continue;
									}
								}
								goto IL_238;
							}
						}
						this.AI_state = "attack";
						if (119637 - 39516 == 80122)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (84936 - 348136 == -263199)
							{
								continue;
							}
							this.PVsK6k3TqL.vDirection = myAttackTarget.transform.position;
							if (261656 - 157375 == 104282)
							{
								continue;
							}
							this.PVsK6k3TqL.vDirection.y = this.transform.position.y;
							if (22229 - 564976 != -542747)
							{
								continue;
							}
							this.PVsK6k3TqL.vMovement = (this.PVsK6k3TqL.vDirection - this.transform.position).normalized;
							if (231518 - 52871 != 178647)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.PVsK6k3TqL.vMovement);
							if (243920 - 350113 != -106193)
							{
								continue;
							}
							this.PVsK6k3TqL.actionState = "run";
							if (227266 - 133704 != 93562)
							{
								continue;
							}
							this.animation.Play("run");
							if (49942 - 345719 != -295777)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (102650 - 328728 != -226078)
							{
								continue;
							}
							this.PVsK6k3TqL.moveSpeed = Mathf.Lerp(this.PVsK6k3TqL.moveSpeed, this.PVsK6k3TqL.runSpeed, (float)4 * Time.deltaTime);
							if (87990 - 524355 == -436364)
							{
								continue;
							}
						}
						else
						{
							this.PVsK6k3TqL.vDirection = myAttackTarget.transform.position;
							if (243582 - 99576 == 144007)
							{
								continue;
							}
							this.PVsK6k3TqL.vDirection.y = this.transform.position.y;
							if (87852 - 223786 == -135933)
							{
								continue;
							}
							this.PVsK6k3TqL.vMovement = (this.PVsK6k3TqL.vDirection - this.transform.position).normalized;
							if (205022 - 206599 != -1577)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.PVsK6k3TqL.vMovement);
							if (148005 - 184448 != -36443)
							{
								continue;
							}
							this.PVsK6k3TqL.actionState = "standby";
							if (239901 - 493102 == -253200)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (17878 - 288390 == -270511)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (30704 - 59010 != -28306)
							{
								continue;
							}
							this.PVsK6k3TqL.moveSpeed = Mathf.Lerp(this.PVsK6k3TqL.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (149244 - 599525 == -450280)
							{
								continue;
							}
						}
					}
				}
			}
			IL_238:
			this.W8SKOTejpx += mTime;
		}
		while (201538 - 30531 != 171007);
	}

	// Token: 0x0600462B RID: 17963 RVA: 0x008C5DBC File Offset: 0x008C3FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (59320 - 63588 != -4268)
		{
		}
		while (Time.time - this.JmQKXpvQ43 > this.W8SKOTejpx)
		{
			if (132728 - 427852 != -295123)
			{
				this.AI_state = "none";
				if (94132 - 130406 == -36274)
				{
					this.JmQKXpvQ43 = Time.time;
					if (29941 - 500640 == -470699)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600462C RID: 17964 RVA: 0x008C5E70 File Offset: 0x008C4070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (201981 - 247526 != -45545)
		{
		}
		for (;;)
		{
			IL_356:
			if (this.glbK2w82vy > Time.time)
			{
				if (16791 - 297731 == -280940)
				{
					break;
				}
			}
			else
			{
				this.glbK2w82vy = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (298550 - 192526 == 106024)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (254397 - 142692 != 111706 && 187279 - 546841 != -359561)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (148361 - 372469 == -224108)
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
								if (160489 - 89159 != 71330)
								{
									goto IL_356;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (125853 - 284412 != -158559)
								{
									goto IL_356;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (261334 - 366162 == -104827)
								{
									goto IL_356;
								}
								bool flag = true;
								if (18585 - 511876 == -493290)
								{
									goto IL_356;
								}
								eRace race = this.PVsK6k3TqL.Race;
								if (223492 - 189495 != 33997)
								{
									goto IL_356;
								}
								if (race == eRace.Tails)
								{
									if (243690 - 463898 != -220208)
									{
										goto IL_356;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_40;
									}
									if (66396 - 259301 == -192904)
									{
										goto IL_356;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (280984 - 346549 != -65565)
										{
											goto IL_356;
										}
										goto IL_40;
									}
									goto IL_3A1;
									IL_40:
									flag = false;
									if (73175 - 528837 != -455662)
									{
										goto IL_356;
									}
								}
								else if (race == eRace.Plants)
								{
									if (227064 - 267232 != -40168)
									{
										goto IL_356;
									}
									flag = false;
									if (207704 - 244660 != -36956)
									{
										goto IL_356;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (198573 - 573257 == -374683)
									{
										goto IL_356;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_380;
									}
									if (78331 - 268581 != -190250)
									{
										goto IL_356;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (246786 - 109143 != 137644)
										{
											goto IL_380;
										}
										goto IL_356;
									}
									goto IL_3A1;
									IL_380:
									flag = false;
									if (170596 - 584154 != -413558)
									{
										goto IL_356;
									}
								}
								else if (race == eRace.Robots)
								{
									if (274869 - 526694 == -251824)
									{
										goto IL_356;
									}
									flag = true;
									if (47984 - 419608 != -371624)
									{
										goto IL_356;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (95865 - 550927 != -455062)
									{
										goto IL_356;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_6F8;
									}
									if (99932 - 275881 == -175948)
									{
										goto IL_356;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_6F8;
									}
									if (122248 - 21223 != 101025)
									{
										goto IL_356;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (151542 - 235152 != -83610)
										{
											goto IL_356;
										}
										goto IL_6F8;
									}
									goto IL_3A1;
									IL_6F8:
									flag = false;
									if (192922 - 406844 == -213921)
									{
										goto IL_356;
									}
								}
								else if (race == eRace.Structure)
								{
									if (153807 - 86178 == 67630)
									{
										goto IL_356;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (262665 - 367895 == -105229)
										{
											goto IL_356;
										}
										flag = false;
										if (216389 - 282650 != -66261)
										{
											goto IL_356;
										}
									}
								}
								IL_3A1:
								if (flag)
								{
									if (45298 - 397951 == -352652)
									{
										goto IL_356;
									}
									if (characterControl.hp > 0)
									{
										if (276400 - 566473 == -290072)
										{
											goto IL_356;
										}
										if (characterControl.recieveTarget)
										{
											if (287084 - 586538 == -299453)
											{
												goto IL_356;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (178750 - 434910 != -256160)
												{
													goto IL_356;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (271540 - 138543 == 132998)
													{
														goto IL_356;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (37342 - 152837 != -115495)
													{
														goto IL_356;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (232271 - 125121 != 107150)
														{
															goto IL_356;
														}
														this.PVsK6k3TqL.myAttackTarget = gameObject;
														if (156807 - 541173 != -384366)
														{
															goto IL_356;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (20606 - 553567 != -532961)
														{
															goto IL_356;
														}
														this.PVsK6k3TqL.addHate(characterControl.ActorNr, 5);
														if (296159 - 150381 == 145779)
														{
															goto IL_356;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (191256 - 357132 == -165875)
														{
															goto IL_356;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (178596 - 373362 != -194766)
														{
															goto IL_356;
														}
														if (num < (float)60)
														{
															if (62231 - 349956 == -287724)
															{
																goto IL_356;
															}
															if (characterControl.hp > 0)
															{
																if (102471 - 427132 == -324660)
																{
																	goto IL_356;
																}
																this.PVsK6k3TqL.myAttackTarget = gameObject;
																if (206662 - 258424 != -51762)
																{
																	goto IL_356;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (200013 - 475794 == -275780)
																{
																	goto IL_356;
																}
																this.PVsK6k3TqL.addHate(characterControl.ActorNr, 5);
																if (77278 - 314257 != -236979)
																{
																	goto IL_356;
																}
															}
														}
													}
													if (this.PVsK6k3TqL.myAttackTarget)
													{
														if (39656 - 553692 == -514035)
														{
															goto IL_356;
														}
														this.PVsK6k3TqL.isAlert = true;
														if (294428 - 233016 != 61412)
														{
															goto IL_356;
														}
														this.JmQKXpvQ43 = Time.time;
														if (263616 - 556873 == -293256)
														{
															goto IL_356;
														}
													}
												}
											}
										}
									}
								}
							}
							if (252134 - 395213 == -143079)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600462D RID: 17965 RVA: 0x008C6688 File Offset: 0x008C4888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600462E RID: 17966 RVA: 0x008C668C File Offset: 0x008C488C
	internal static bool PW2c415dk62FCDFgf5Ro()
	{
		return true;
	}

	// Token: 0x0600462F RID: 17967 RVA: 0x008C6690 File Offset: 0x008C4890
	internal static bool XWwKMU5dGOKZSEAUFl2v()
	{
		return false;
	}

	// Token: 0x040051C1 RID: 20929
	private CharacterControl PVsK6k3TqL;

	// Token: 0x040051C2 RID: 20930
	private FirstWhale qUFKtP5UOD;

	// Token: 0x040051C3 RID: 20931
	public string AI_state;

	// Token: 0x040051C4 RID: 20932
	private float JmQKXpvQ43;

	// Token: 0x040051C5 RID: 20933
	private float W8SKOTejpx;

	// Token: 0x040051C6 RID: 20934
	private float glbK2w82vy;
}
