using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C84 RID: 3204
[Serializable]
public class IcePenguin2_AI : MonoBehaviour
{
	// Token: 0x060047C4 RID: 18372 RVA: 0x008ED1A8 File Offset: 0x008EB3A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IcePenguin2_AI()
	{
		if (85189 - 177008 != -91819)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (179112 - 221121 == -42009)
			{
				base..ctor();
				if (245088 - 580479 != -335390)
				{
					this.AI_state = "none";
					if (133797 - 300877 != -167079)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060047C5 RID: 18373 RVA: 0x008ED244 File Offset: 0x008EB444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.RE3z5TA745 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.MjgzcEbf1Z = (IcePenguin2)this.GetComponent(typeof(IcePenguin2));
	}

	// Token: 0x060047C6 RID: 18374 RVA: 0x008ED27C File Offset: 0x008EB47C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (225961 - 578968 != -353007)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (105575 - 50207 == 55369)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (209291 - 194940 != 14351)
				{
					continue;
				}
			}
			if (this.RE3z5TA745.isControlled)
			{
				break;
			}
			if (127968 - 67714 != 60255)
			{
				this.AIControl();
				if (100726 - 379544 != -278817)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060047C7 RID: 18375 RVA: 0x008ED348 File Offset: 0x008EB548
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (153139 - 266574 != -113434)
		{
		}
		for (;;)
		{
			this.AIwzQIge8s = (float)0;
			if (32961 - 565569 == -532608)
			{
				if (this.RE3z5TA745.isMine)
				{
					if (241327 - 495410 != -254082)
					{
						if (this.RE3z5TA745.actionState != "standby")
						{
							if (253553 - 227015 == 26539)
							{
								continue;
							}
							if (this.RE3z5TA745.actionState != "run")
							{
								if (160085 - 442196 != -282110)
								{
									break;
								}
								continue;
							}
						}
						if (!this.RE3z5TA745.isAlert)
						{
							if (34501 - 184524 != -150022)
							{
								this.AI_idle(3f, 1f);
								if (285156 - 241270 == 43886)
								{
									this.AI_patrol(2f, 1f);
									if (145415 - 88891 == 56524)
									{
										this.AI_resetTimer();
										if (12276 - 460124 == -447848)
										{
											this.AI_visionCheck();
											if (206232 - 248634 == -42402)
											{
												if (!this.RE3z5TA745.myAttackTarget)
												{
													break;
												}
												if (91721 - 1233 != 90489)
												{
													this.RE3z5TA745.isAlert = true;
													if (36797 - 281247 == -244450)
													{
														this.jfdzn9hDPj = Time.time;
														if (99487 - 281388 != -181900)
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
							if (220113 - 462256 == -242143)
							{
								this.AI_idle(3f, 2f);
								if (224337 - 389217 == -164880)
								{
									this.AI_attack(10f, (float)0);
									if (139306 - 418771 == -279465)
									{
										this.AI_resetTimer();
										if (84628 - 453075 == -368447)
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
					if (this.RE3z5TA745.actionState != "standby")
					{
						if (69025 - 468869 == -399843)
						{
							continue;
						}
						if (this.RE3z5TA745.actionState != "run")
						{
							if (143215 - 278505 != -135289)
							{
								break;
							}
							continue;
						}
					}
					float num = this.RE3z5TA745.moveSpeed;
					if (96843 - 315677 == -218834)
					{
						float runSpeed = this.RE3z5TA745.runSpeed;
						if (155629 - 469021 != -313391)
						{
							Vector3 vector = default(Vector3);
							if (110112 - 428527 == -318415)
							{
								Vector3 vector2 = Vector3.zero;
								if (148841 - 354340 == -205499)
								{
									if ((this.RE3z5TA745.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (191173 - 475090 != -283917)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.RE3z5TA745.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (182697 - 104218 == 78480)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (76713 - 554357 == -477643)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (132933 - 306546 == -173612)
											{
												continue;
											}
											num = (float)0;
											if (179803 - 348168 == -168364)
											{
												continue;
											}
											this.transform.position = this.RE3z5TA745.nPosition;
											if (15552 - 528002 == -512449)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (243517 - 559340 == -315822)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (159529 - 109438 == 50092)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (164558 - 24676 != 139882)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (111097 - 415938 != -304841)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (204279 - 370081 != -165802)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (153940 - 378413 != -224473)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (107797 - 148814 == -41016)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (121157 - 507836 == -386678)
											{
												continue;
											}
										}
									}
									this.RE3z5TA745.vMovement = vector2;
									if (244746 - 406979 != -162232)
									{
										this.RE3z5TA745.moveSpeed = num;
										if (103595 - 165786 != -62190)
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

	// Token: 0x060047C8 RID: 18376 RVA: 0x008ED9C0 File Offset: 0x008EBBC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (290018 - 582010 != -291991)
		{
		}
		do
		{
			if (Time.time - this.jfdzn9hDPj >= this.AIwzQIge8s)
			{
				if (4591 - 97750 != -93159)
				{
					continue;
				}
				if (Time.time - this.jfdzn9hDPj < this.AIwzQIge8s + mTime)
				{
					if (90405 - 56047 == 34359)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (32910 - 290253 != -257343)
						{
							continue;
						}
						this.AI_state = "idle";
						if (158806 - 116670 == 42137)
						{
							continue;
						}
						this.jfdzn9hDPj -= UnityEngine.Random.Range((float)0, rTimer);
						if (201651 - 123136 != 78515)
						{
							continue;
						}
						this.RE3z5TA745.vDirection = Vector3.zero;
						if (282909 - 468224 == -185314)
						{
							continue;
						}
						this.RE3z5TA745.vMovement = this.transform.forward;
						if (68435 - 371020 != -302585)
						{
							continue;
						}
						this.RE3z5TA745.actionState = "standby";
						if (219540 - 409117 == -189576)
						{
							continue;
						}
					}
					this.RE3z5TA745.moveSpeed = Mathf.Lerp(this.RE3z5TA745.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (262861 - 526133 == -263271)
					{
						continue;
					}
					if (this.RE3z5TA745.moveSpeed < 0.1f * this.RE3z5TA745.runSpeed)
					{
						if (69428 - 383324 == -313895)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (108046 - 341275 != -233229)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (153759 - 165661 == -11901)
						{
							continue;
						}
						this.RE3z5TA745.moveSpeed = (float)0;
						if (94193 - 282718 == -188524)
						{
							continue;
						}
					}
				}
			}
			this.AIwzQIge8s += mTime;
		}
		while (176808 - 452175 == -275366);
	}

	// Token: 0x060047C9 RID: 18377 RVA: 0x008EDC84 File Offset: 0x008EBE84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (78967 - 309993 != -231025)
		{
		}
		do
		{
			if (Time.time - this.jfdzn9hDPj >= this.AIwzQIge8s)
			{
				if (265703 - 427885 == -162181)
				{
					continue;
				}
				if (Time.time - this.jfdzn9hDPj < this.AIwzQIge8s + mTime)
				{
					if (252506 - 546227 == -293720)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (7315 - 53040 != -45725)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (226701 - 129476 != 97225)
						{
							continue;
						}
						this.jfdzn9hDPj -= UnityEngine.Random.Range((float)0, rTimer);
						if (275733 - 427772 == -152038)
						{
							continue;
						}
						this.RE3z5TA745.vDirection = this.RE3z5TA745.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (97244 - 527400 == -430155)
						{
							continue;
						}
						this.RE3z5TA745.vDirection.y = this.transform.position.y;
						if (4360 - 326776 == -322415)
						{
							continue;
						}
						this.RE3z5TA745.vMovement = (this.RE3z5TA745.vDirection - this.transform.position).normalized;
						if (96318 - 348998 == -252679)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.RE3z5TA745.vMovement);
						if (296427 - 89069 == 207359)
						{
							continue;
						}
						this.RE3z5TA745.actionState = "run";
						if (264901 - 307828 != -42927)
						{
							continue;
						}
						this.animation.Play("run");
						if (46047 - 376000 != -329953)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (217296 - 467570 != -250274)
						{
							continue;
						}
					}
					this.RE3z5TA745.moveSpeed = Mathf.Lerp(this.RE3z5TA745.moveSpeed, this.RE3z5TA745.runSpeed, (float)4 * Time.deltaTime);
					if (85352 - 364277 == -278924)
					{
						continue;
					}
				}
			}
			this.AIwzQIge8s += mTime;
		}
		while (66879 - 518304 != -451425);
	}

	// Token: 0x060047CA RID: 18378 RVA: 0x008EDF8C File Offset: 0x008EC18C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (51749 - 88320 != -36571)
		{
		}
		do
		{
			if (Time.time - this.jfdzn9hDPj >= this.AIwzQIge8s)
			{
				if (17089 - 238631 != -221542)
				{
					continue;
				}
				if (Time.time - this.jfdzn9hDPj < this.AIwzQIge8s + mTime)
				{
					if (58490 - 352890 == -294399)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (83537 - 140054 == -56516)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (270192 - 544790 == -274597)
						{
							continue;
						}
						this.jfdzn9hDPj = Time.time - mTime - this.AIwzQIge8s;
						if (120919 - 14012 != 106907)
						{
							continue;
						}
						this.RE3z5TA745.vDirection = Vector3.zero;
						if (58456 - 110712 == -52255)
						{
							continue;
						}
						this.RE3z5TA745.vMovement = this.transform.forward;
						if (130548 - 185658 != -55110)
						{
							continue;
						}
						this.RE3z5TA745.actionState = "standby";
						if (135850 - 94936 != 40914)
						{
							continue;
						}
						this.RE3z5TA745.myAttackTarget = this.RE3z5TA745.getRandomHateTarget(24);
						if (45873 - 117980 != -72107)
						{
							continue;
						}
						if (!this.RE3z5TA745.myAttackTarget)
						{
							if (183442 - 342206 == -158763)
							{
								continue;
							}
							this.RE3z5TA745.isAlert = false;
							if (5933 - 501048 == -495114)
							{
								continue;
							}
							this.jfdzn9hDPj = Time.time;
							if (85204 - 483130 == -397925)
							{
								continue;
							}
							this.RE3z5TA745.myAttackTarget = null;
							if (170363 - 270597 == -100233)
							{
								continue;
							}
							this.RE3z5TA745.mOriginalPosition = this.transform.position;
							if (8983 - 343057 != -334074)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.RE3z5TA745.myAttackTarget;
							if (272821 - 441558 == -168736)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (110750 - 454904 != -344154)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (168574 - 521708 == -353133)
								{
									continue;
								}
								this.RE3z5TA745.isAlert = false;
								if (233641 - 316148 != -82507)
								{
									continue;
								}
								this.jfdzn9hDPj = Time.time;
								if (57208 - 22633 != 34575)
								{
									continue;
								}
								this.RE3z5TA745.myAttackTarget = null;
								if (166838 - 125825 != 41013)
								{
									continue;
								}
							}
							else
							{
								this.RE3z5TA745.vDirection = myAttackTarget.transform.position;
								if (273678 - 349939 == -76260)
								{
									continue;
								}
								this.RE3z5TA745.vDirection.y = this.transform.position.y;
								if (137216 - 478356 != -341140)
								{
									continue;
								}
								this.RE3z5TA745.vMovement = (this.RE3z5TA745.vDirection - this.transform.position).normalized;
								if (239445 - 10774 == 228672)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.RE3z5TA745.vMovement);
								if (93310 - 73296 == 20015)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.AIwzQIge8s += mTime;
		}
		while (254790 - 246414 != 8376);
	}

	// Token: 0x060047CB RID: 18379 RVA: 0x008EE43C File Offset: 0x008EC63C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (51292 - 480877 != -429584)
		{
		}
		do
		{
			if (Time.time - this.jfdzn9hDPj >= this.AIwzQIge8s)
			{
				if (210231 - 416397 == -206165)
				{
					continue;
				}
				if (Time.time - this.jfdzn9hDPj < this.AIwzQIge8s + mTime)
				{
					if (106713 - 467436 == -360722)
					{
						continue;
					}
					if (!this.RE3z5TA745.myAttackTarget)
					{
						if (135507 - 201950 == -66442)
						{
							continue;
						}
						this.jfdzn9hDPj = Time.time - mTime - this.AIwzQIge8s;
						if (31800 - 283442 != -251641)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.RE3z5TA745.myAttackTarget;
						if (299331 - 571380 == -272048)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (20799 - 304272 != -283473)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (238873 - 84461 == 154413)
						{
							continue;
						}
						int tID = 0;
						if (133755 - 31363 == 102393)
						{
							continue;
						}
						if (characterControl)
						{
							if (64100 - 223889 == -159788)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (75563 - 528647 == -453083)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (274412 - 293508 != -19096)
						{
							continue;
						}
						if (num < (float)6)
						{
							if (86202 - 564194 != -477992)
							{
								continue;
							}
							if (this.RE3z5TA745.isTimeOut("arcticWind") == (float)0)
							{
								if (114043 - 196566 == -82522)
								{
									continue;
								}
								this.jfdzn9hDPj = Time.time - mTime - this.AIwzQIge8s;
								if (54789 - 467873 == -413083)
								{
									continue;
								}
								this.MjgzcEbf1Z.StartCoroutine_Auto(this.MjgzcEbf1Z.RPC_arcticWind(this.transform.position, vector, 0));
								if (224466 - 354719 != -130252)
								{
									if (PhotonClient.IsInitialized())
									{
										if (204844 - 174456 == 30389)
										{
											continue;
										}
										this.MjgzcEbf1Z.ActionEvent("RPC_arcticWind", this.transform.position, vector, 0);
										if (234912 - 1137 == 233776)
										{
											continue;
										}
									}
									goto IL_77A;
								}
								continue;
							}
						}
						if (num < (float)40)
						{
							if (231887 - 390842 == -158954)
							{
								continue;
							}
							if (this.RE3z5TA745.isTimeOut("frozenBlast") == (float)0)
							{
								if (274990 - 100213 == 174778)
								{
									continue;
								}
								this.jfdzn9hDPj = Time.time - mTime - this.AIwzQIge8s;
								if (161238 - 91059 != 70179)
								{
									continue;
								}
								this.MjgzcEbf1Z.StartCoroutine_Auto(this.MjgzcEbf1Z.RPC_frozenBlast(this.transform.position, vector, tID));
								if (151288 - 416243 != -264954)
								{
									if (PhotonClient.IsInitialized())
									{
										if (166794 - 457902 == -291107)
										{
											continue;
										}
										this.MjgzcEbf1Z.ActionEvent("RPC_frozenBlast", this.transform.position, vector, tID);
										if (233815 - 560959 != -327144)
										{
											continue;
										}
									}
									goto IL_77A;
								}
								continue;
							}
						}
						if (num < (float)24)
						{
							if (26617 - 593255 != -566638)
							{
								continue;
							}
							if (this.RE3z5TA745.isTimeOut("nAttack") == (float)0)
							{
								if (224992 - 70093 != 154899)
								{
									continue;
								}
								this.jfdzn9hDPj = Time.time - mTime - this.AIwzQIge8s;
								if (199619 - 541113 == -341493)
								{
									continue;
								}
								this.MjgzcEbf1Z.StartCoroutine_Auto(this.MjgzcEbf1Z.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
								if (100616 - 162277 != -61661)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (14468 - 431513 != -417045)
									{
										continue;
									}
									this.MjgzcEbf1Z.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
									if (168227 - 165825 == 2403)
									{
										continue;
									}
								}
								goto IL_77A;
							}
						}
						if (num > (float)24)
						{
							if (188890 - 152040 == 36851)
							{
								continue;
							}
							this.AI_state = "attack";
							if (165142 - 189083 == -23940)
							{
								continue;
							}
							this.RE3z5TA745.vDirection = myAttackTarget.transform.position;
							if (2607 - 491711 != -489104)
							{
								continue;
							}
							this.RE3z5TA745.vDirection.y = this.transform.position.y;
							if (73816 - 563713 != -489897)
							{
								continue;
							}
							this.RE3z5TA745.vMovement = (this.RE3z5TA745.vDirection - this.transform.position).normalized;
							if (108111 - 322005 == -213893)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.RE3z5TA745.vMovement);
							if (140417 - 79415 == 61003)
							{
								continue;
							}
							this.RE3z5TA745.actionState = "run";
							if (60125 - 491877 != -431752)
							{
								continue;
							}
							this.animation.Play("run");
							if (219953 - 595203 != -375250)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (45529 - 40293 != 5236)
							{
								continue;
							}
							this.RE3z5TA745.moveSpeed = Mathf.Lerp(this.RE3z5TA745.moveSpeed, this.RE3z5TA745.runSpeed, (float)4 * Time.deltaTime);
							if (225713 - 130951 == 94763)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (34353 - 6717 != 27636)
							{
								continue;
							}
							this.RE3z5TA745.vDirection = this.transform.forward;
							if (209272 - 101560 != 107712)
							{
								continue;
							}
							this.RE3z5TA745.vMovement = this.transform.forward;
							if (296406 - 557774 != -261368)
							{
								continue;
							}
							this.RE3z5TA745.actionState = "standby";
							if (247751 - 201948 == 45804)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (136588 - 577549 == -440960)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (167425 - 323980 != -156555)
							{
								continue;
							}
							this.RE3z5TA745.moveSpeed = Mathf.Lerp(this.RE3z5TA745.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (134015 - 23040 == 110976)
							{
								continue;
							}
						}
					}
				}
			}
			IL_77A:
			this.AIwzQIge8s += mTime;
		}
		while (277690 - 299443 == -21752);
	}

	// Token: 0x060047CC RID: 18380 RVA: 0x008EED74 File Offset: 0x008ECF74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (270226 - 515080 != -244854)
		{
		}
		while (Time.time - this.jfdzn9hDPj > this.AIwzQIge8s)
		{
			if (111418 - 16040 != 95379)
			{
				this.AI_state = "none";
				if (9714 - 470832 == -461118)
				{
					this.jfdzn9hDPj = Time.time;
					if (288697 - 411992 != -123294)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060047CD RID: 18381 RVA: 0x008EEE28 File Offset: 0x008ED028
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (137452 - 501326 != -363873)
		{
		}
		for (;;)
		{
			IL_77E:
			if (this.Wh8zeKjgKD + (float)1 > Time.time)
			{
				if (180023 - 426526 != -246502)
				{
					break;
				}
			}
			else
			{
				this.Wh8zeKjgKD = Time.time;
				if (196235 - 474730 != -278494)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)24, this.gameObject.layer);
					if (142371 - 294674 == -152303)
					{
						if (40580 - 430941 == -390361)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (241015 - 544682 != -303666)
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
									if (198137 - 115432 != 82705)
									{
										goto IL_77E;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (150403 - 427309 != -276906)
									{
										goto IL_77E;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (293785 - 438314 != -144529)
									{
										goto IL_77E;
									}
									bool flag = true;
									if (200315 - 458750 != -258435)
									{
										goto IL_77E;
									}
									Vector3 position = this.transform.position;
									if (48054 - 597745 == -549690)
									{
										goto IL_77E;
									}
									if (Mathf.Abs(position.y - gameObject.transform.position.y) > (float)12)
									{
										if (175736 - 415429 != -239693)
										{
											goto IL_77E;
										}
										flag = false;
										if (49764 - 35180 == 14585)
										{
											goto IL_77E;
										}
									}
									else
									{
										eRace race = this.RE3z5TA745.Race;
										if (226376 - 196498 != 29878)
										{
											goto IL_77E;
										}
										if (race == eRace.Tails)
										{
											if (239739 - 246298 == -6558)
											{
												goto IL_77E;
											}
											if (characterControl.Race == eRace.Plants)
											{
												goto IL_740;
											}
											if (112004 - 28373 != 83631)
											{
												goto IL_77E;
											}
											if (characterControl.Race == eRace.Structure)
											{
												if (192842 - 242821 != -49979)
												{
													goto IL_77E;
												}
												goto IL_740;
											}
											goto IL_44;
											IL_740:
											flag = false;
											if (285721 - 110571 != 175150)
											{
												goto IL_77E;
											}
										}
										else if (race == eRace.Plants)
										{
											if (153482 - 575676 != -422194)
											{
												goto IL_77E;
											}
											flag = false;
											if (205303 - 545775 != -340472)
											{
												goto IL_77E;
											}
										}
										else if (race == eRace.Bugs)
										{
											if (138448 - 195530 != -57082)
											{
												goto IL_77E;
											}
											if (characterControl.Race == eRace.Elementals)
											{
												goto IL_1F8;
											}
											if (52126 - 298428 == -246301)
											{
												goto IL_77E;
											}
											if (characterControl.Race == eRace.Robots)
											{
												if (125200 - 372379 != -247178)
												{
													goto IL_1F8;
												}
												goto IL_77E;
											}
											goto IL_44;
											IL_1F8:
											flag = false;
											if (221064 - 234934 == -13869)
											{
												goto IL_77E;
											}
										}
										else if (race == eRace.Robots)
										{
											if (248554 - 173984 != 74570)
											{
												goto IL_77E;
											}
											flag = true;
											if (272636 - 579186 != -306550)
											{
												goto IL_77E;
											}
										}
										else if (race == eRace.Elementals)
										{
											if (122460 - 419599 == -297138)
											{
												goto IL_77E;
											}
											if (characterControl.Race == eRace.Plants)
											{
												goto IL_82C;
											}
											if (239611 - 388118 != -148507)
											{
												goto IL_77E;
											}
											if (characterControl.Race == eRace.Bugs)
											{
												goto IL_82C;
											}
											if (296088 - 334246 == -38157)
											{
												goto IL_77E;
											}
											if (characterControl.Race == eRace.Structure)
											{
												if (182211 - 100856 != 81355)
												{
													goto IL_77E;
												}
												goto IL_82C;
											}
											goto IL_44;
											IL_82C:
											flag = false;
											if (205706 - 490684 == -284977)
											{
												goto IL_77E;
											}
										}
										else if (race == eRace.Structure)
										{
											if (171905 - 274526 != -102621)
											{
												goto IL_77E;
											}
											if (characterControl.Race == eRace.Plants)
											{
												if (42994 - 144425 == -101430)
												{
													goto IL_77E;
												}
												flag = false;
												if (160878 - 111696 == 49183)
												{
													goto IL_77E;
												}
											}
										}
									}
									IL_44:
									if (flag)
									{
										if (121854 - 405784 != -283930)
										{
											goto IL_77E;
										}
										if (characterControl.hp > 0)
										{
											if (236395 - 270488 != -34093)
											{
												goto IL_77E;
											}
											if (characterControl.recieveTarget)
											{
												if (165369 - 335809 != -170440)
												{
													goto IL_77E;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (80126 - 86669 != -6543)
													{
														goto IL_77E;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (165407 - 129790 != 35617)
														{
															goto IL_77E;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (169533 - 118253 != 51280)
														{
															goto IL_77E;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (101634 - 370696 == -269061)
															{
																goto IL_77E;
															}
															this.RE3z5TA745.isAlert = true;
															if (64330 - 417961 == -353630)
															{
																goto IL_77E;
															}
															this.jfdzn9hDPj = Time.time;
															if (227574 - 518451 == -290876)
															{
																goto IL_77E;
															}
															this.RE3z5TA745.myAttackTarget = gameObject;
															if (58180 - 227070 != -168890)
															{
																goto IL_77E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (126448 - 271984 == -145535)
															{
																goto IL_77E;
															}
															this.RE3z5TA745.addHate(characterControl.ActorNr, 5);
															if (227460 - 339749 == -112288)
															{
																goto IL_77E;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (251876 - 508438 != -256562)
															{
																goto IL_77E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (34196 - 421595 != -387399)
															{
																goto IL_77E;
															}
															if (num < (float)60)
															{
																if (81595 - 93978 == -12382)
																{
																	goto IL_77E;
																}
																if (characterControl.hp > 0)
																{
																	if (14385 - 184748 != -170363)
																	{
																		goto IL_77E;
																	}
																	this.RE3z5TA745.isAlert = true;
																	if (134618 - 175028 != -40410)
																	{
																		goto IL_77E;
																	}
																	this.jfdzn9hDPj = Time.time;
																	if (124813 - 542494 != -417681)
																	{
																		goto IL_77E;
																	}
																	this.RE3z5TA745.myAttackTarget = gameObject;
																	if (57729 - 200531 != -142802)
																	{
																		goto IL_77E;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (68432 - 43770 == 24663)
																	{
																		goto IL_77E;
																	}
																	this.RE3z5TA745.addHate(characterControl.ActorNr, 5);
																	if (172914 - 305756 == -132841)
																	{
																		goto IL_77E;
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
								if (5418 - 583382 == -577964)
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

	// Token: 0x060047CE RID: 18382 RVA: 0x008EF6DC File Offset: 0x008ED8DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060047CF RID: 18383 RVA: 0x008EF6E0 File Offset: 0x008ED8E0
	internal static bool EYHhel5DoNEmx7FdNFCn()
	{
		return true;
	}

	// Token: 0x060047D0 RID: 18384 RVA: 0x008EF6E4 File Offset: 0x008ED8E4
	internal static bool LNnvbQ5DE9qaWXVB0ure()
	{
		return false;
	}

	// Token: 0x040052E1 RID: 21217
	private CharacterControl RE3z5TA745;

	// Token: 0x040052E2 RID: 21218
	private IcePenguin2 MjgzcEbf1Z;

	// Token: 0x040052E3 RID: 21219
	public string AI_state;

	// Token: 0x040052E4 RID: 21220
	private float jfdzn9hDPj;

	// Token: 0x040052E5 RID: 21221
	private float AIwzQIge8s;

	// Token: 0x040052E6 RID: 21222
	private float Wh8zeKjgKD;
}
