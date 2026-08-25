using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B48 RID: 2888
[Serializable]
public class Alpaca_AI : MonoBehaviour
{
	// Token: 0x06004043 RID: 16451 RVA: 0x0082AC9C File Offset: 0x00828E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Alpaca_AI()
	{
		if (247950 - 261611 != -13661)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (96326 - 107248 == -10922)
			{
				base..ctor();
				if (172592 - 205704 == -33112)
				{
					this.AI_state = "none";
					if (208833 - 64483 != 144351)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004044 RID: 16452 RVA: 0x0082AD38 File Offset: 0x00828F38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.Ty8yo8i5RG = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.e95ykDAatV = (Alpaca)this.GetComponent(typeof(Alpaca));
	}

	// Token: 0x06004045 RID: 16453 RVA: 0x0082AD70 File Offset: 0x00828F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (264024 - 348924 != -84900)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (272081 - 228716 == 43366)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (197717 - 94260 == 103458)
				{
					continue;
				}
			}
			if (this.Ty8yo8i5RG.isControlled)
			{
				break;
			}
			if (210159 - 512685 == -302526)
			{
				this.AIControl();
				if (15177 - 34505 != -19327)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004046 RID: 16454 RVA: 0x0082AE3C File Offset: 0x0082903C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (183160 - 192003 != -8843)
		{
		}
		for (;;)
		{
			this.S4NyAyT48u = (float)0;
			if (270917 - 63186 == 207731)
			{
				if (this.Ty8yo8i5RG.isMine)
				{
					if (101147 - 459941 != -358793)
					{
						if (this.Ty8yo8i5RG.actionState != "standby")
						{
							if (261015 - 20820 == 240196)
							{
								continue;
							}
							if (this.Ty8yo8i5RG.actionState != "run")
							{
								if (151621 - 305543 != -153921)
								{
									break;
								}
								continue;
							}
						}
						if (!this.Ty8yo8i5RG.isAlert)
						{
							if (30691 - 323295 == -292604)
							{
								if (!this.Ty8yo8i5RG.isSummon)
								{
									goto IL_3BD;
								}
								if (214294 - 95726 != 118568)
								{
									continue;
								}
								if (!(this.Ty8yo8i5RG.mSummoner != null))
								{
									goto IL_3BD;
								}
								if (98217 - 35631 == 62587)
								{
									continue;
								}
								Vector3 vector = this.Ty8yo8i5RG.mSummoner.transform.position - this.transform.position;
								if (87567 - 241460 != -153893)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)36)
								{
									if (166847 - 36090 != 130757)
									{
										continue;
									}
									this.AI_follow(this.Ty8yo8i5RG.mSummoner);
									if (120343 - 549725 == -429381)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (184305 - 265011 != -80706)
									{
										continue;
									}
									this.AI_resetTimer();
									if (131725 - 519694 != -387969)
									{
										continue;
									}
									this.AI_visionCheck();
									if (277995 - 379996 == -102000)
									{
										continue;
									}
								}
								IL_652:
								if (!this.Ty8yo8i5RG.myAttackTarget)
								{
									break;
								}
								if (65374 - 417420 != -352046)
								{
									continue;
								}
								this.Ty8yo8i5RG.isAlert = true;
								if (69800 - 167951 != -98151)
								{
									continue;
								}
								this.YMtyF1h9TF = Time.time;
								if (291481 - 158677 != 132805)
								{
									break;
								}
								continue;
								IL_3BD:
								this.AI_idle(3f, 1f);
								if (169265 - 440381 == -271116)
								{
									this.AI_resetTimer();
									if (280705 - 589034 != -308328)
									{
										this.AI_visionCheck();
										if (61771 - 345296 != -283524)
										{
											goto IL_652;
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (199966 - 325562 != -125595)
							{
								this.AI_idle(1f, 1f);
								if (9441 - 431662 != -422220)
								{
									this.AI_attack(6f, 1f);
									if (249009 - 396333 != -147323)
									{
										this.AI_resetTimer();
										if (267872 - 509781 != -241908)
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
					if (this.Ty8yo8i5RG.actionState != "standby")
					{
						if (88476 - 8511 != 79965)
						{
							continue;
						}
						if (this.Ty8yo8i5RG.actionState != "run")
						{
							if (92158 - 11281 != 80877)
							{
								continue;
							}
							break;
						}
					}
					if (this.Ty8yo8i5RG.nSpeed != (float)0)
					{
						if (35095 - 266035 == -230939)
						{
							continue;
						}
						if (this.Ty8yo8i5RG.nPosition != this.Ty8yo8i5RG.oPosition)
						{
							if (138085 - 599236 != -461151)
							{
								continue;
							}
							Vector3 a = this.Ty8yo8i5RG.nPosition + 0.1f * this.Ty8yo8i5RG.runSpeed * this.Ty8yo8i5RG.nDirection;
							if (79956 - 357121 != -277165)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (295482 - 255013 == 40470)
							{
								continue;
							}
							Vector3 normalized = vector2.normalized;
							if (20085 - 462146 == -442060)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.transform.position);
							if (109674 - 192030 != -82356)
							{
								continue;
							}
							float magnitude = vector3.magnitude;
							if (92663 - 389591 != -296928)
							{
								continue;
							}
							if (magnitude > this.Ty8yo8i5RG.runSpeed)
							{
								if (89950 - 356120 != -266170)
								{
									continue;
								}
								this.transform.position = this.Ty8yo8i5RG.nPosition;
								if (18168 - 182181 != -164013)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.Ty8yo8i5RG.runSpeed)
							{
								if (111083 - 207238 == -96154)
								{
									continue;
								}
								this.Ty8yo8i5RG.moveSpeed = Mathf.Lerp(this.Ty8yo8i5RG.moveSpeed, 1.1f * this.Ty8yo8i5RG.runSpeed, (float)10 * Time.deltaTime);
								if (259129 - 503376 != -244247)
								{
									continue;
								}
								this.Ty8yo8i5RG.vDirection = normalized;
								if (271337 - 465764 != -194427)
								{
									continue;
								}
								this.Ty8yo8i5RG.vMovement = normalized;
								if (20768 - 381406 == -360637)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (179914 - 186539 != -6625)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (186045 - 115941 == 70105)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (207393 - 142565 != 64828)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (261693 - 377164 != -115471)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (142775 - 507111 != -364335)
								{
									break;
								}
								continue;
							}
							else
							{
								this.Ty8yo8i5RG.moveSpeed = Mathf.Lerp(this.Ty8yo8i5RG.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (248092 - 12384 == 235709)
								{
									continue;
								}
								this.Ty8yo8i5RG.vDirection = normalized;
								if (111768 - 93851 == 17918)
								{
									continue;
								}
								this.Ty8yo8i5RG.vMovement = normalized;
								if (24710 - 175518 == -150807)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (199815 - 33469 == 166347)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (83228 - 599785 != -516556)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.Ty8yo8i5RG.moveSpeed != (float)0)
					{
						if (225715 - 401540 == -175825)
						{
							Vector3 vector4 = global::Math.vFlat(this.Ty8yo8i5RG.nPosition - this.transform.position);
							if (18073 - 104696 != -86622)
							{
								float sqrMagnitude = vector4.sqrMagnitude;
								if (256291 - 425475 != -169183)
								{
									if (sqrMagnitude > this.Ty8yo8i5RG.runSpeed)
									{
										if (140717 - 145028 == -4311)
										{
											this.transform.position = this.Ty8yo8i5RG.nPosition;
											if (206823 - 247276 == -40453)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (33742 - 167517 != -133774)
										{
											if (sqrMagnitude > (float)1)
											{
												if (269096 - 379362 == -110265)
												{
													continue;
												}
												this.Ty8yo8i5RG.moveSpeed = Mathf.Lerp(this.Ty8yo8i5RG.moveSpeed, this.Ty8yo8i5RG.runSpeed, (float)10 * Time.deltaTime);
												if (69279 - 502047 == -432767)
												{
													continue;
												}
											}
											else
											{
												this.Ty8yo8i5RG.moveSpeed = Mathf.Lerp(this.Ty8yo8i5RG.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (12374 - 453902 != -441528)
												{
													continue;
												}
											}
											this.Ty8yo8i5RG.vMovement = vector4;
											if (192842 - 499690 == -306848)
											{
												this.Ty8yo8i5RG.vDirection = vector4;
												if (38430 - 594827 != -556396)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector4, (float)10 * Time.deltaTime));
													if (170173 - 550666 == -380493)
													{
														this.animation.CrossFade("run", 0.2f);
														if (229063 - 548741 != -319677)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (125595 - 50910 == 74685)
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
										this.Ty8yo8i5RG.vMovement = vector4;
										if (200006 - 388976 == -188970)
										{
											this.Ty8yo8i5RG.moveSpeed = (float)0;
											if (25600 - 524191 != -498590)
											{
												this.transform.rotation = Quaternion.LookRotation(this.Ty8yo8i5RG.vDirection);
												if (156704 - 199849 == -43145)
												{
													this.animation.CrossFade("root", 0.2f);
													if (33261 - 216820 == -183559)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (57895 - 81992 != -24096)
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
						if (275906 - 526787 != -250880)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (85110 - 93475 != -8364)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004047 RID: 16455 RVA: 0x0082BAF8 File Offset: 0x00829CF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (230469 - 85784 != 144685)
		{
		}
		do
		{
			if (Time.time - this.YMtyF1h9TF >= this.S4NyAyT48u)
			{
				if (251781 - 160902 == 90880)
				{
					continue;
				}
				if (Time.time - this.YMtyF1h9TF < this.S4NyAyT48u + mTime)
				{
					if (206227 - 399340 != -193113)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (286969 - 332189 != -45220)
						{
							continue;
						}
						this.AI_state = "idle";
						if (118536 - 368245 == -249708)
						{
							continue;
						}
						this.YMtyF1h9TF -= UnityEngine.Random.Range((float)0, rTimer);
						if (73286 - 261199 != -187913)
						{
							continue;
						}
						this.Ty8yo8i5RG.vDirection = Vector3.zero;
						if (156774 - 572426 == -415651)
						{
							continue;
						}
						this.Ty8yo8i5RG.vMovement = this.transform.forward;
						if (84574 - 567232 == -482657)
						{
							continue;
						}
						this.Ty8yo8i5RG.actionState = "standby";
						if (44554 - 119728 != -75174)
						{
							continue;
						}
					}
					this.Ty8yo8i5RG.moveSpeed = Mathf.Lerp(this.Ty8yo8i5RG.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (22168 - 70234 != -48066)
					{
						continue;
					}
					if (this.Ty8yo8i5RG.moveSpeed < 0.1f * this.Ty8yo8i5RG.runSpeed)
					{
						if (169251 - 501932 != -332681)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (227769 - 149513 == 78257)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (241258 - 546663 != -305405)
						{
							continue;
						}
						this.Ty8yo8i5RG.moveSpeed = (float)0;
						if (248508 - 536825 != -288317)
						{
							continue;
						}
					}
				}
			}
			this.S4NyAyT48u += mTime;
		}
		while (271215 - 171096 != 100119);
	}

	// Token: 0x06004048 RID: 16456 RVA: 0x0082BDBC File Offset: 0x00829FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (191780 - 413420 != -221640)
		{
		}
		for (;;)
		{
			this.Ty8yo8i5RG.vDirection = followObject.transform.position;
			if (111631 - 462593 != -350961)
			{
				this.Ty8yo8i5RG.vDirection.y = this.transform.position.y;
				if (165684 - 450552 != -284867)
				{
					this.Ty8yo8i5RG.vMovement = (this.Ty8yo8i5RG.vDirection - this.transform.position).normalized;
					if (263374 - 296783 == -33409)
					{
						this.transform.rotation = Quaternion.LookRotation(this.Ty8yo8i5RG.vMovement);
						if (181004 - 329654 != -148649)
						{
							this.Ty8yo8i5RG.actionState = "run";
							if (121277 - 212484 == -91207)
							{
								this.animation.Play("run");
								if (79498 - 484012 == -404514)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (8041 - 566452 == -558411)
									{
										this.Ty8yo8i5RG.moveSpeed = Mathf.Lerp(this.Ty8yo8i5RG.moveSpeed, this.Ty8yo8i5RG.runSpeed, (float)4 * Time.deltaTime);
										if (193513 - 167778 != 25736)
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

	// Token: 0x06004049 RID: 16457 RVA: 0x0082BFA4 File Offset: 0x0082A1A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (110914 - 504851 != -393937)
		{
		}
		do
		{
			if (Time.time - this.YMtyF1h9TF >= this.S4NyAyT48u)
			{
				if (104425 - 101073 != 3352)
				{
					continue;
				}
				if (Time.time - this.YMtyF1h9TF < this.S4NyAyT48u + mTime)
				{
					if (104204 - 527001 != -422797)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (35730 - 60920 == -25189)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (63434 - 456208 == -392773)
						{
							continue;
						}
						this.YMtyF1h9TF -= UnityEngine.Random.Range((float)0, rTimer);
						if (196017 - 363562 == -167544)
						{
							continue;
						}
						this.Ty8yo8i5RG.vDirection = this.Ty8yo8i5RG.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (89530 - 484228 == -394697)
						{
							continue;
						}
						this.Ty8yo8i5RG.vDirection.y = this.transform.position.y;
						if (268618 - 364759 != -96141)
						{
							continue;
						}
						this.Ty8yo8i5RG.vMovement = (this.Ty8yo8i5RG.vDirection - this.transform.position).normalized;
						if (138876 - 205089 != -66213)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Ty8yo8i5RG.vMovement);
						if (98864 - 121352 != -22488)
						{
							continue;
						}
						this.Ty8yo8i5RG.actionState = "run";
						if (33045 - 382933 == -349887)
						{
							continue;
						}
						this.animation.Play("run");
						if (106788 - 491662 != -384874)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (107259 - 5301 == 101959)
						{
							continue;
						}
					}
					this.Ty8yo8i5RG.moveSpeed = Mathf.Lerp(this.Ty8yo8i5RG.moveSpeed, this.Ty8yo8i5RG.runSpeed, (float)4 * Time.deltaTime);
					if (74189 - 216510 != -142321)
					{
						continue;
					}
				}
			}
			this.S4NyAyT48u += mTime;
		}
		while (13536 - 182311 == -168774);
	}

	// Token: 0x0600404A RID: 16458 RVA: 0x0082C2AC File Offset: 0x0082A4AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (265734 - 401474 != -135740)
		{
		}
		do
		{
			if (Time.time - this.YMtyF1h9TF >= this.S4NyAyT48u)
			{
				if (154140 - 273236 != -119096)
				{
					continue;
				}
				if (Time.time - this.YMtyF1h9TF < this.S4NyAyT48u + mTime)
				{
					if (281261 - 115206 != 166055)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (17195 - 555377 != -538182)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (273951 - 310743 != -36792)
						{
							continue;
						}
						this.YMtyF1h9TF = Time.time - mTime - this.S4NyAyT48u;
						if (223478 - 288322 != -64844)
						{
							continue;
						}
						this.Ty8yo8i5RG.vDirection = Vector3.zero;
						if (67295 - 63974 == 3322)
						{
							continue;
						}
						this.Ty8yo8i5RG.vMovement = this.transform.forward;
						if (192608 - 590230 == -397621)
						{
							continue;
						}
						this.Ty8yo8i5RG.actionState = "standby";
						if (25263 - 191341 != -166078)
						{
							continue;
						}
						this.Ty8yo8i5RG.myAttackTarget = this.Ty8yo8i5RG.getHateTarget(5, 50);
						if (164907 - 559916 == -395008)
						{
							continue;
						}
						if (!this.Ty8yo8i5RG.myAttackTarget)
						{
							if (130675 - 92851 != 37824)
							{
								continue;
							}
							this.Ty8yo8i5RG.isAlert = false;
							if (249882 - 412349 != -162467)
							{
								continue;
							}
							this.YMtyF1h9TF = Time.time;
							if (8396 - 28269 == -19872)
							{
								continue;
							}
							this.Ty8yo8i5RG.myAttackTarget = null;
							if (228482 - 353479 != -124997)
							{
								continue;
							}
							this.Ty8yo8i5RG.mOriginalPosition = this.transform.position;
							if (68174 - 145420 != -77246)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.Ty8yo8i5RG.myAttackTarget;
							if (52770 - 265688 == -212917)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (87675 - 210059 == -122383)
							{
								continue;
							}
							if (!(characterControl == null))
							{
								if (295135 - 126720 != 168415)
								{
									continue;
								}
								if (characterControl.hp <= 0)
								{
									if (120764 - 204266 == -83501)
									{
										continue;
									}
								}
								else
								{
									this.Ty8yo8i5RG.vDirection = myAttackTarget.transform.position;
									if (219836 - 48492 == 171345)
									{
										continue;
									}
									this.Ty8yo8i5RG.vDirection.y = this.transform.position.y;
									if (57166 - 174915 == -117748)
									{
										continue;
									}
									this.Ty8yo8i5RG.vMovement = (this.Ty8yo8i5RG.vDirection - this.transform.position).normalized;
									if (161699 - 582111 != -420412)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(this.Ty8yo8i5RG.vMovement);
									if (61712 - 231252 != -169540)
									{
										continue;
									}
									goto IL_F8;
								}
							}
							this.Ty8yo8i5RG.isAlert = false;
							if (299409 - 570315 != -270906)
							{
								continue;
							}
							this.YMtyF1h9TF = Time.time;
							if (15736 - 26067 != -10331)
							{
								continue;
							}
							this.Ty8yo8i5RG.myAttackTarget = null;
							if (165986 - 561823 == -395836)
							{
								continue;
							}
						}
					}
				}
			}
			IL_F8:
			this.S4NyAyT48u += mTime;
		}
		while (157030 - 584990 == -427959);
	}

	// Token: 0x0600404B RID: 16459 RVA: 0x0082C780 File Offset: 0x0082A980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (293941 - 229635 != 64306)
		{
		}
		do
		{
			if (Time.time - this.YMtyF1h9TF >= this.S4NyAyT48u)
			{
				if (214329 - 559389 != -345060)
				{
					continue;
				}
				if (Time.time - this.YMtyF1h9TF < this.S4NyAyT48u + mTime)
				{
					if (176574 - 16439 == 160136)
					{
						continue;
					}
					if (!this.Ty8yo8i5RG.myAttackTarget)
					{
						if (259024 - 78010 != 181014)
						{
							continue;
						}
						this.YMtyF1h9TF = Time.time - mTime - this.S4NyAyT48u;
						if (165263 - 52826 != 112438)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.Ty8yo8i5RG.myAttackTarget;
						if (246060 - 259209 == -13148)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (166955 - 359007 == -192051)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (65035 - 282107 == -217071)
						{
							continue;
						}
						if (num < (float)1)
						{
							if (68040 - 580153 != -512113)
							{
								continue;
							}
							if (this.Ty8yo8i5RG.isTimeOut("nAttack") == (float)0)
							{
								if (133411 - 127722 == 5690)
								{
									continue;
								}
								this.YMtyF1h9TF = Time.time - mTime - this.S4NyAyT48u;
								if (149988 - 479821 != -329833)
								{
									continue;
								}
								this.e95ykDAatV.StartCoroutine_Auto(this.e95ykDAatV.RPC_nAttack(this.transform.position, vector, 0));
								if (57614 - 381800 != -324185)
								{
									if (PhotonClient.IsInitialized())
									{
										if (90594 - 105707 != -15113)
										{
											continue;
										}
										this.e95ykDAatV.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (151426 - 434219 != -282793)
										{
											continue;
										}
									}
									goto IL_A8;
								}
								continue;
							}
						}
						if (this.Ty8yo8i5RG.isTimeOut("nAttack") == (float)0)
						{
							if (62365 - 22678 == 39688)
							{
								continue;
							}
							this.AI_state = "attack";
							if (108272 - 502547 != -394275)
							{
								continue;
							}
							this.Ty8yo8i5RG.vDirection = myAttackTarget.transform.position;
							if (292944 - 315691 != -22747)
							{
								continue;
							}
							this.Ty8yo8i5RG.vDirection.y = this.transform.position.y;
							if (202512 - 304033 == -101520)
							{
								continue;
							}
							this.Ty8yo8i5RG.vMovement = (this.Ty8yo8i5RG.vDirection - this.transform.position).normalized;
							if (189854 - 273423 != -83569)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.Ty8yo8i5RG.vMovement);
							if (269916 - 203046 == 66871)
							{
								continue;
							}
							this.Ty8yo8i5RG.actionState = "run";
							if (272762 - 410570 == -137807)
							{
								continue;
							}
							this.animation.Play("run");
							if (173727 - 268066 != -94339)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (42017 - 182114 != -140097)
							{
								continue;
							}
							this.Ty8yo8i5RG.moveSpeed = Mathf.Lerp(this.Ty8yo8i5RG.moveSpeed, this.Ty8yo8i5RG.runSpeed, (float)4 * Time.deltaTime);
							if (68284 - 485204 == -416919)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (224681 - 381000 == -156318)
							{
								continue;
							}
							this.Ty8yo8i5RG.vDirection = myAttackTarget.transform.position;
							if (97760 - 145911 == -48150)
							{
								continue;
							}
							this.Ty8yo8i5RG.vDirection.y = this.transform.position.y;
							if (33151 - 109473 != -76322)
							{
								continue;
							}
							this.Ty8yo8i5RG.vMovement = (this.Ty8yo8i5RG.vDirection - this.transform.position).normalized;
							if (10874 - 159477 == -148602)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.Ty8yo8i5RG.vMovement);
							if (247612 - 542264 != -294652)
							{
								continue;
							}
							this.Ty8yo8i5RG.actionState = "standby";
							if (73242 - 421754 != -348512)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (18100 - 113104 != -95004)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (8678 - 357576 == -348897)
							{
								continue;
							}
							this.Ty8yo8i5RG.moveSpeed = Mathf.Lerp(this.Ty8yo8i5RG.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (268351 - 517208 != -248857)
							{
								continue;
							}
						}
					}
				}
			}
			IL_A8:
			this.S4NyAyT48u += mTime;
		}
		while (221445 - 397934 != -176489);
	}

	// Token: 0x0600404C RID: 16460 RVA: 0x0082CE3C File Offset: 0x0082B03C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (201724 - 332748 != -131023)
		{
		}
		while (Time.time - this.YMtyF1h9TF > this.S4NyAyT48u)
		{
			if (90839 - 588247 != -497407)
			{
				this.AI_state = "none";
				if (294866 - 354546 == -59680)
				{
					this.YMtyF1h9TF = Time.time;
					if (106162 - 199925 == -93763)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600404D RID: 16461 RVA: 0x0082CEF0 File Offset: 0x0082B0F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (292813 - 71536 != 221277)
		{
		}
		for (;;)
		{
			IL_1A:
			if (this.h7ay9loAq0 > Time.time)
			{
				if (262784 - 545056 == -282272)
				{
					break;
				}
			}
			else
			{
				this.h7ay9loAq0 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (222199 - 406122 == -183923)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (106882 - 17281 != 89602)
					{
						if (253206 - 87956 == 165250)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (228466 - 347015 == -118549)
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
									if (267951 - 329245 != -61294)
									{
										goto IL_1A;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (145952 - 410405 == -264452)
									{
										goto IL_1A;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (182734 - 435217 != -252483)
									{
										goto IL_1A;
									}
									bool flag = true;
									if (241534 - 83799 != 157735)
									{
										goto IL_1A;
									}
									eRace race = this.Ty8yo8i5RG.Race;
									if (204272 - 301205 == -96932)
									{
										goto IL_1A;
									}
									if (race == eRace.Tails)
									{
										if (75633 - 262186 != -186553)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_A4;
										}
										if (256389 - 470232 != -213843)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (234544 - 210988 != 23557)
											{
												goto IL_A4;
											}
											goto IL_1A;
										}
										goto IL_75E;
										IL_A4:
										flag = false;
										if (165370 - 257536 != -92166)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Plants)
									{
										if (209928 - 487941 == -278012)
										{
											goto IL_1A;
										}
										flag = false;
										if (273548 - 166875 != 106673)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (296015 - 281717 == 14299)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_44B;
										}
										if (133346 - 152105 != -18759)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (124623 - 198542 != -73919)
											{
												goto IL_1A;
											}
											goto IL_44B;
										}
										goto IL_75E;
										IL_44B:
										flag = false;
										if (23743 - 442818 == -419074)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Robots)
									{
										if (280831 - 557026 == -276194)
										{
											goto IL_1A;
										}
										flag = true;
										if (225591 - 25646 == 199946)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (172247 - 208384 != -36137)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_88;
										}
										if (152557 - 565958 != -413401)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_88;
										}
										if (102340 - 381691 != -279351)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (41319 - 487818 != -446499)
											{
												goto IL_1A;
											}
											goto IL_88;
										}
										goto IL_75E;
										IL_88:
										flag = false;
										if (274821 - 512309 != -237488)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Structure)
									{
										if (146713 - 325897 == -179183)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (265156 - 37699 != 227457)
											{
												goto IL_1A;
											}
											flag = false;
											if (158993 - 165134 != -6141)
											{
												goto IL_1A;
											}
										}
									}
									IL_75E:
									if (flag)
									{
										if (45238 - 463607 != -418369)
										{
											goto IL_1A;
										}
										if (characterControl.hp > 0)
										{
											if (152820 - 263350 == -110529)
											{
												goto IL_1A;
											}
											if (characterControl.recieveTarget)
											{
												if (115537 - 378388 != -262851)
												{
													goto IL_1A;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (79028 - 366043 == -287014)
													{
														goto IL_1A;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (105957 - 357554 != -251597)
														{
															goto IL_1A;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (261777 - 491602 == -229824)
														{
															goto IL_1A;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (82492 - 319893 == -237400)
															{
																goto IL_1A;
															}
															this.Ty8yo8i5RG.myAttackTarget = gameObject;
															if (267758 - 312255 == -44496)
															{
																goto IL_1A;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (261889 - 524525 != -262636)
															{
																goto IL_1A;
															}
															this.Ty8yo8i5RG.addHate(characterControl.ActorNr, 5);
															if (106401 - 187740 != -81339)
															{
																goto IL_1A;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (211458 - 419383 != -207925)
															{
																goto IL_1A;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (297089 - 467002 == -169912)
															{
																goto IL_1A;
															}
															if (num < (float)60)
															{
																if (76643 - 367738 == -291094)
																{
																	goto IL_1A;
																}
																if (characterControl.hp > 0)
																{
																	if (119152 - 46639 == 72514)
																	{
																		goto IL_1A;
																	}
																	this.Ty8yo8i5RG.myAttackTarget = gameObject;
																	if (7371 - 27281 != -19910)
																	{
																		goto IL_1A;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (163514 - 523960 == -360445)
																	{
																		goto IL_1A;
																	}
																	this.Ty8yo8i5RG.addHate(characterControl.ActorNr, 5);
																	if (45008 - 555283 != -510275)
																	{
																		goto IL_1A;
																	}
																}
															}
														}
														if (this.Ty8yo8i5RG.myAttackTarget)
														{
															if (188955 - 462478 == -273522)
															{
																goto IL_1A;
															}
															this.Ty8yo8i5RG.isAlert = true;
															if (125791 - 86269 == 39523)
															{
																goto IL_1A;
															}
															this.YMtyF1h9TF = Time.time;
															if (3407 - 493840 == -490432)
															{
																goto IL_1A;
															}
														}
													}
												}
											}
										}
									}
								}
								if (13874 - 177707 == -163833)
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

	// Token: 0x0600404E RID: 16462 RVA: 0x0082D708 File Offset: 0x0082B908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600404F RID: 16463 RVA: 0x0082D70C File Offset: 0x0082B90C
	internal static bool XNRFOo5MTMoDr5kSbywZ()
	{
		return true;
	}

	// Token: 0x06004050 RID: 16464 RVA: 0x0082D710 File Offset: 0x0082B910
	internal static bool XM9x335M3S4lp9V0R9V0()
	{
		return false;
	}

	// Token: 0x04004CA7 RID: 19623
	private CharacterControl Ty8yo8i5RG;

	// Token: 0x04004CA8 RID: 19624
	private Alpaca e95ykDAatV;

	// Token: 0x04004CA9 RID: 19625
	public string AI_state;

	// Token: 0x04004CAA RID: 19626
	private float YMtyF1h9TF;

	// Token: 0x04004CAB RID: 19627
	private float S4NyAyT48u;

	// Token: 0x04004CAC RID: 19628
	private float h7ay9loAq0;
}
