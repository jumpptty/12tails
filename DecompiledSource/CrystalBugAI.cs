using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200005A RID: 90
[Serializable]
public class CrystalBugAI : MonoBehaviour
{
	// Token: 0x060001C4 RID: 452 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrystalBugAI()
	{
		if (103521 - 241018 != -137496)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (126630 - 304579 == -177949)
			{
				base..ctor();
				if (150813 - 363016 != -212202)
				{
					this.AI_state = "none";
					if (54969 - 79386 == -24417)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x0002C25C File Offset: 0x0002A45C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.CFQa4xFSn = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.zVq4kVLXu = (CrystalBug)this.GetComponent(typeof(CrystalBug));
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x0002C294 File Offset: 0x0002A494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (125192 - 328024 != -202832)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (168682 - 156710 == 11973)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (159424 - 331027 == -171602)
				{
					continue;
				}
			}
			if (this.CFQa4xFSn.isControlled)
			{
				break;
			}
			if (224522 - 227944 != -3421)
			{
				this.AIControl();
				if (179554 - 362225 != -182670)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x0002C360 File Offset: 0x0002A560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (237274 - 393204 != -155929)
		{
		}
		for (;;)
		{
			this.r4ZH3xSeP = (float)0;
			if (257492 - 514715 != -257222)
			{
				if (this.CFQa4xFSn.isMine)
				{
					if (114836 - 252043 != -137206)
					{
						if (this.CFQa4xFSn.actionState != "standby")
						{
							if (160789 - 64953 == 95837)
							{
								continue;
							}
							if (this.CFQa4xFSn.actionState != "run")
							{
								if (236402 - 545743 != -309340)
								{
									break;
								}
								continue;
							}
						}
						if (!this.CFQa4xFSn.isAlert)
						{
							if (257738 - 462940 != -205201)
							{
								this.AI_idle(5f, 1f);
								if (17790 - 402089 == -384299)
								{
									this.AI_patrol(3f, 1f);
									if (112769 - 70270 != 42500)
									{
										this.AI_resetTimer();
										if (117348 - 493467 == -376119)
										{
											this.AI_visionCheck();
											if (76115 - 141376 != -65260)
											{
												if (!this.CFQa4xFSn.myAttackTarget)
												{
													break;
												}
												if (197797 - 272742 == -74945)
												{
													this.CFQa4xFSn.isAlert = true;
													if (152996 - 241881 == -88885)
													{
														this.hRasJ9C16 = Time.time;
														if (22786 - 538328 == -515542)
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
							if (5987 - 358878 != -352890)
							{
								this.AI_idle(2f, 2f);
								if (249660 - 37111 != 212550)
								{
									this.AI_attack(7f, 2f);
									if (245776 - 217345 != 28432)
									{
										this.AI_resetTimer();
										if (6625 - 7076 == -451)
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
					if (this.CFQa4xFSn.actionState != "standby")
					{
						if (111991 - 228826 != -116835)
						{
							continue;
						}
						if (this.CFQa4xFSn.actionState != "run")
						{
							if (87908 - 345205 != -257296)
							{
								break;
							}
							continue;
						}
					}
					if (this.CFQa4xFSn.nSpeed != (float)0)
					{
						if (58631 - 239413 != -180782)
						{
							continue;
						}
						if (this.CFQa4xFSn.nPosition != this.CFQa4xFSn.oPosition)
						{
							if (3636 - 264674 != -261038)
							{
								continue;
							}
							Vector3 a = this.CFQa4xFSn.nPosition + 0.1f * this.CFQa4xFSn.runSpeed * this.CFQa4xFSn.nDirection;
							if (50615 - 590351 == -539735)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (240314 - 261158 != -20844)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (102103 - 37842 != 64261)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (178054 - 465109 == -287054)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (293156 - 547612 != -254456)
							{
								continue;
							}
							if (magnitude > this.CFQa4xFSn.runSpeed)
							{
								if (120833 - 499435 != -378602)
								{
									continue;
								}
								this.transform.position = this.CFQa4xFSn.nPosition;
								if (44123 - 375954 != -331830)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.CFQa4xFSn.runSpeed)
							{
								if (156021 - 352293 != -196272)
								{
									continue;
								}
								this.CFQa4xFSn.moveSpeed = Mathf.Lerp(this.CFQa4xFSn.moveSpeed, 1.1f * this.CFQa4xFSn.runSpeed, (float)10 * Time.deltaTime);
								if (106911 - 459548 == -352636)
								{
									continue;
								}
								this.CFQa4xFSn.vDirection = normalized;
								if (172834 - 38596 == 134239)
								{
									continue;
								}
								this.CFQa4xFSn.vMovement = normalized;
								if (60034 - 151423 == -91388)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (127745 - 324086 != -196341)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (165237 - 572693 == -407455)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (166025 - 12130 == 153896)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (130641 - 318385 == -187743)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (161126 - 145953 != 15173)
								{
									continue;
								}
								break;
							}
							else
							{
								this.CFQa4xFSn.moveSpeed = Mathf.Lerp(this.CFQa4xFSn.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (46853 - 214617 == -167763)
								{
									continue;
								}
								this.CFQa4xFSn.vDirection = normalized;
								if (234100 - 139567 == 94534)
								{
									continue;
								}
								this.CFQa4xFSn.vMovement = normalized;
								if (7168 - 527665 != -520497)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (220520 - 176631 != 43889)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (146248 - 405590 != -259342)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.CFQa4xFSn.moveSpeed != (float)0)
					{
						if (63460 - 94567 != -31106)
						{
							Vector3 vector3 = global::Math.vFlat(this.CFQa4xFSn.nPosition - this.transform.position);
							if (65360 - 133793 == -68433)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (154735 - 305253 == -150518)
								{
									if (sqrMagnitude > this.CFQa4xFSn.runSpeed)
									{
										if (298025 - 97580 != 200446)
										{
											this.transform.position = this.CFQa4xFSn.nPosition;
											if (143037 - 1484 != 141554)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (115234 - 261547 != -146312)
										{
											if (sqrMagnitude > (float)1)
											{
												if (96600 - 363263 == -266662)
												{
													continue;
												}
												this.CFQa4xFSn.moveSpeed = Mathf.Lerp(this.CFQa4xFSn.moveSpeed, this.CFQa4xFSn.runSpeed, (float)10 * Time.deltaTime);
												if (64741 - 45071 == 19671)
												{
													continue;
												}
											}
											else
											{
												this.CFQa4xFSn.moveSpeed = Mathf.Lerp(this.CFQa4xFSn.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (93990 - 340886 == -246895)
												{
													continue;
												}
											}
											this.CFQa4xFSn.vMovement = vector3;
											if (292739 - 29461 != 263279)
											{
												this.CFQa4xFSn.vDirection = vector3;
												if (42911 - 418147 != -375235)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (11008 - 515851 != -504842)
													{
														this.animation.CrossFade("run", 0.2f);
														if (213710 - 356381 != -142670)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (19410 - 170539 == -151129)
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
										this.CFQa4xFSn.vMovement = vector3;
										if (31701 - 321180 == -289479)
										{
											this.CFQa4xFSn.moveSpeed = (float)0;
											if (219849 - 468802 == -248953)
											{
												this.transform.rotation = Quaternion.LookRotation(this.CFQa4xFSn.vDirection);
												if (248914 - 433189 != -184274)
												{
													this.animation.CrossFade("root", 0.2f);
													if (134205 - 543083 != -408877)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (249174 - 327050 == -77876)
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
						if (62766 - 540806 == -478040)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (29248 - 191876 != -162627)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x0002CEE4 File Offset: 0x0002B0E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (206044 - 154903 != 51142)
		{
		}
		do
		{
			if (Time.time - this.hRasJ9C16 >= this.r4ZH3xSeP)
			{
				if (68179 - 31960 != 36219)
				{
					continue;
				}
				if (Time.time - this.hRasJ9C16 < this.r4ZH3xSeP + mTime)
				{
					if (152834 - 471394 != -318560)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (293857 - 77912 != 215945)
						{
							continue;
						}
						this.AI_state = "idle";
						if (154126 - 244856 != -90730)
						{
							continue;
						}
						this.hRasJ9C16 -= UnityEngine.Random.Range((float)0, rTimer);
						if (276012 - 158084 != 117928)
						{
							continue;
						}
						this.CFQa4xFSn.vDirection = Vector3.zero;
						if (66406 - 553173 != -486767)
						{
							continue;
						}
						this.CFQa4xFSn.vMovement = this.transform.forward;
						if (44861 - 172312 == -127450)
						{
							continue;
						}
						this.CFQa4xFSn.actionState = "standby";
						if (240530 - 399489 != -158959)
						{
							continue;
						}
					}
					this.CFQa4xFSn.moveSpeed = Mathf.Lerp(this.CFQa4xFSn.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (205729 - 240550 != -34821)
					{
						continue;
					}
					if (this.CFQa4xFSn.moveSpeed < 0.1f * this.CFQa4xFSn.runSpeed)
					{
						if (97309 - 336372 == -239062)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (56220 - 128972 != -72752)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (41881 - 453770 != -411889)
						{
							continue;
						}
						this.CFQa4xFSn.moveSpeed = (float)0;
						if (55547 - 537970 != -482423)
						{
							continue;
						}
					}
				}
			}
			this.r4ZH3xSeP += mTime;
		}
		while (245766 - 475021 != -229255);
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0002D1A8 File Offset: 0x0002B3A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (160333 - 26132 != 134202)
		{
		}
		do
		{
			if (Time.time - this.hRasJ9C16 >= this.r4ZH3xSeP)
			{
				if (171648 - 341466 == -169817)
				{
					continue;
				}
				if (Time.time - this.hRasJ9C16 < this.r4ZH3xSeP + mTime)
				{
					if (264541 - 437378 != -172837)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (197955 - 393002 != -195047)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (109457 - 402897 != -293440)
						{
							continue;
						}
						this.hRasJ9C16 -= UnityEngine.Random.Range((float)0, rTimer);
						if (226019 - 390868 == -164848)
						{
							continue;
						}
						this.CFQa4xFSn.vDirection = this.CFQa4xFSn.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (18642 - 140622 == -121979)
						{
							continue;
						}
						this.CFQa4xFSn.vDirection.y = this.transform.position.y;
						if (31834 - 204142 != -172308)
						{
							continue;
						}
						this.CFQa4xFSn.vMovement = (this.CFQa4xFSn.vDirection - this.transform.position).normalized;
						if (236730 - 309055 != -72325)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.CFQa4xFSn.vMovement);
						if (32525 - 463311 == -430785)
						{
							continue;
						}
						this.CFQa4xFSn.actionState = "run";
						if (55058 - 145670 != -90612)
						{
							continue;
						}
						this.animation.Play("run");
						if (89535 - 446848 != -357313)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (157736 - 563354 != -405618)
						{
							continue;
						}
					}
					this.CFQa4xFSn.moveSpeed = Mathf.Lerp(this.CFQa4xFSn.moveSpeed, this.CFQa4xFSn.runSpeed, (float)4 * Time.deltaTime);
					if (290613 - 377155 == -86541)
					{
						continue;
					}
				}
			}
			this.r4ZH3xSeP += mTime;
		}
		while (129087 - 270586 != -141499);
	}

	// Token: 0x060001CA RID: 458 RVA: 0x0002D4B0 File Offset: 0x0002B6B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (120633 - 61052 != 59582)
		{
		}
		do
		{
			if (Time.time - this.hRasJ9C16 >= this.r4ZH3xSeP)
			{
				if (66562 - 508034 != -441472)
				{
					continue;
				}
				if (Time.time - this.hRasJ9C16 < this.r4ZH3xSeP + mTime)
				{
					if (29247 - 163556 != -134309)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (112998 - 492036 != -379038)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (233887 - 450000 != -216113)
						{
							continue;
						}
						this.hRasJ9C16 = Time.time - mTime - this.r4ZH3xSeP;
						if (51673 - 153153 == -101479)
						{
							continue;
						}
						this.CFQa4xFSn.vDirection = Vector3.zero;
						if (198813 - 165249 != 33564)
						{
							continue;
						}
						this.CFQa4xFSn.vMovement = this.transform.forward;
						if (64186 - 387192 != -323006)
						{
							continue;
						}
						this.CFQa4xFSn.actionState = "standby";
						if (246364 - 475413 != -229049)
						{
							continue;
						}
						this.CFQa4xFSn.myAttackTarget = this.CFQa4xFSn.getHateTarget(5, 80);
						if (7233 - 32267 != -25034)
						{
							continue;
						}
						if (!this.CFQa4xFSn.myAttackTarget)
						{
							if (84847 - 105957 == -21109)
							{
								continue;
							}
							this.CFQa4xFSn.isAlert = false;
							if (183162 - 553791 == -370628)
							{
								continue;
							}
							this.hRasJ9C16 = Time.time;
							if (11504 - 576567 == -565062)
							{
								continue;
							}
							this.CFQa4xFSn.myAttackTarget = null;
							if (132907 - 566878 == -433970)
							{
								continue;
							}
							this.CFQa4xFSn.mOriginalPosition = this.transform.position;
							if (103365 - 284551 != -181185)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.CFQa4xFSn.myAttackTarget;
							if (234044 - 137967 == 96078)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (169798 - 546739 == -376940)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (85522 - 564509 == -478986)
								{
									continue;
								}
								this.CFQa4xFSn.isAlert = false;
								if (156197 - 58650 == 97548)
								{
									continue;
								}
								this.hRasJ9C16 = Time.time;
								if (163302 - 153961 == 9342)
								{
									continue;
								}
								this.CFQa4xFSn.myAttackTarget = null;
								if (106835 - 70748 == 36088)
								{
									continue;
								}
							}
							else
							{
								this.CFQa4xFSn.vDirection = myAttackTarget.transform.position;
								if (288477 - 585712 != -297235)
								{
									continue;
								}
								this.CFQa4xFSn.vDirection.y = this.transform.position.y;
								if (238965 - 253027 != -14062)
								{
									continue;
								}
								this.CFQa4xFSn.vMovement = (this.CFQa4xFSn.vDirection - this.transform.position).normalized;
								if (115099 - 597506 != -482407)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.CFQa4xFSn.vMovement);
								if (257759 - 15613 == 242147)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.r4ZH3xSeP += mTime;
		}
		while (37669 - 206909 != -169240);
	}

	// Token: 0x060001CB RID: 459 RVA: 0x0002D960 File Offset: 0x0002BB60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (70001 - 503986 != -433985)
		{
		}
		do
		{
			if (Time.time - this.hRasJ9C16 >= this.r4ZH3xSeP)
			{
				if (195761 - 293792 != -98031)
				{
					continue;
				}
				if (Time.time - this.hRasJ9C16 < this.r4ZH3xSeP + mTime)
				{
					if (104585 - 360442 != -255857)
					{
						continue;
					}
					if (!this.CFQa4xFSn.myAttackTarget)
					{
						if (200645 - 27500 == 173146)
						{
							continue;
						}
						this.hRasJ9C16 = Time.time - mTime - this.r4ZH3xSeP;
						if (65546 - 77114 != -11568)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.CFQa4xFSn.myAttackTarget;
						if (143629 - 136021 != 7608)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (90517 - 422546 == -332028)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (268549 - 165233 != 103316)
						{
							continue;
						}
						int num = 0;
						if (90649 - 530342 != -439693)
						{
							continue;
						}
						if (characterControl)
						{
							if (52994 - 425780 == -372785)
							{
								continue;
							}
							num = characterControl.ActorNr;
							if (258381 - 131152 == 127230)
							{
								continue;
							}
						}
						float num2 = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (291141 - 466543 != -175402)
						{
							continue;
						}
						int num3 = UnityEngine.Random.Range(0, 100);
						if (249154 - 400245 == -151090)
						{
							continue;
						}
						if (!Game.useAdvanceMode)
						{
							if (143105 - 175826 == -32720)
							{
								continue;
							}
							if (this.CFQa4xFSn.hp >= 6000)
							{
								goto IL_B7B;
							}
							if (237471 - 221713 != 15758)
							{
								continue;
							}
						}
						if (num2 < (float)20)
						{
							if (206972 - 209554 == -2581)
							{
								continue;
							}
							if (this.CFQa4xFSn.isTimeOut("crystalBreath") == (float)0)
							{
								if (275185 - 423138 != -147953)
								{
									continue;
								}
								this.hRasJ9C16 = Time.time - mTime - this.r4ZH3xSeP;
								if (20503 - 230043 != -209540)
								{
									continue;
								}
								this.zVq4kVLXu.StartCoroutine_Auto(this.zVq4kVLXu.RPC_crystalBreath(this.transform.position, vector, 0));
								if (100849 - 447457 != -346608)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (188264 - 300822 != -112558)
									{
										continue;
									}
									this.zVq4kVLXu.ActionEvent("RPC_crystalBreath", this.transform.position, vector, 0);
									if (115901 - 588365 == -472463)
									{
										continue;
									}
								}
								goto IL_914;
							}
						}
						IL_B7B:
						if (num2 > (float)12)
						{
							if (270725 - 441832 != -171107)
							{
								continue;
							}
							if (num2 < (float)24)
							{
								if (228890 - 6747 == 222144)
								{
									continue;
								}
								if (this.CFQa4xFSn.isTimeOut("crystalStomp") == (float)0)
								{
									if (222367 - 562848 != -340481)
									{
										continue;
									}
									this.hRasJ9C16 = Time.time - mTime - this.r4ZH3xSeP;
									if (47140 - 346409 != -299269)
									{
										continue;
									}
									this.zVq4kVLXu.StartCoroutine_Auto(this.zVq4kVLXu.RPC_crystalStomp(this.transform.position, vector, 0));
									if (227294 - 90578 != 136717)
									{
										if (PhotonClient.IsInitialized())
										{
											if (89747 - 92715 != -2968)
											{
												continue;
											}
											this.zVq4kVLXu.ActionEvent("RPC_crystalStomp", this.transform.position, vector, 0);
											if (228738 - 82506 == 146233)
											{
												continue;
											}
										}
										goto IL_914;
									}
									continue;
								}
							}
						}
						if (num2 > (float)6)
						{
							if (254765 - 374536 == -119770)
							{
								continue;
							}
							if (num2 < (float)40)
							{
								if (226894 - 102496 == 124399)
								{
									continue;
								}
								if (this.CFQa4xFSn.isTimeOut("crystalShard") == (float)0)
								{
									if (4065 - 103540 != -99475)
									{
										continue;
									}
									this.hRasJ9C16 = Time.time - mTime - this.r4ZH3xSeP;
									if (33848 - 523967 != -490119)
									{
										continue;
									}
									this.zVq4kVLXu.StartCoroutine_Auto(this.zVq4kVLXu.RPC_crystalShard(this.transform.position, vector, 0));
									if (76260 - 180734 != -104474)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (75994 - 362663 != -286669)
										{
											continue;
										}
										this.zVq4kVLXu.ActionEvent("RPC_crystalShard", this.transform.position, vector, 0);
										if (155039 - 31963 == 123077)
										{
											continue;
										}
									}
									goto IL_914;
								}
							}
						}
						if (num2 < (float)3)
						{
							if (261390 - 143570 == 117821)
							{
								continue;
							}
							if (this.CFQa4xFSn.isTimeOut("nAttack") == (float)0)
							{
								if (76776 - 567372 == -490595)
								{
									continue;
								}
								this.hRasJ9C16 = Time.time - mTime - this.r4ZH3xSeP;
								if (64693 - 205599 != -140906)
								{
									continue;
								}
								if (this.CFQa4xFSn.isTimeOut("nAttack") == (float)0)
								{
									if (256689 - 183018 == 73672)
									{
										continue;
									}
									if (num3 > 60)
									{
										if (186661 - 39372 != 147289)
										{
											continue;
										}
										this.zVq4kVLXu.StartCoroutine_Auto(this.zVq4kVLXu.RPC_nAttack1(this.transform.position, vector, 0));
										if (234057 - 74274 != 159783)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (183817 - 334829 == -151011)
											{
												continue;
											}
											this.zVq4kVLXu.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
											if (150687 - 466286 == -315598)
											{
												continue;
											}
										}
									}
									else if (num3 > 30)
									{
										if (116155 - 196381 != -80226)
										{
											continue;
										}
										this.zVq4kVLXu.StartCoroutine_Auto(this.zVq4kVLXu.RPC_nAttack2(this.transform.position, vector, 0));
										if (274446 - 286000 == -11553)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (179502 - 595620 == -416117)
											{
												continue;
											}
											this.zVq4kVLXu.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
											if (182847 - 231600 != -48753)
											{
												continue;
											}
										}
									}
									else
									{
										this.zVq4kVLXu.StartCoroutine_Auto(this.zVq4kVLXu.RPC_nAttack3(this.transform.position, vector, 0));
										if (231743 - 236993 != -5250)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (221796 - 266985 != -45189)
											{
												continue;
											}
											this.zVq4kVLXu.ActionEvent("RPC_nAttack3", this.transform.position, vector, 0);
											if (116543 - 592926 != -476383)
											{
												continue;
											}
										}
									}
								}
								goto IL_914;
							}
						}
						if (this.r4ZH3xSeP + mTime - (Time.time - this.hRasJ9C16) <= (float)1)
						{
							if (13181 - 570037 != -556856)
							{
								continue;
							}
							if (num != 0)
							{
								if (136921 - 307944 != -171023)
								{
									continue;
								}
								if (this.CFQa4xFSn.isTimeOut("crystalDrop") == (float)0)
								{
									if (28518 - 511721 != -483203)
									{
										continue;
									}
									this.hRasJ9C16 = Time.time - mTime - this.r4ZH3xSeP;
									if (153712 - 122035 == 31678)
									{
										continue;
									}
									this.zVq4kVLXu.StartCoroutine_Auto(this.zVq4kVLXu.RPC_crystalDrop(this.transform.position, vector, num));
									if (53037 - 581167 != -528129)
									{
										if (PhotonClient.IsInitialized())
										{
											if (261487 - 530218 == -268730)
											{
												continue;
											}
											this.zVq4kVLXu.ActionEvent("RPC_crystalDrop", this.transform.position, vector, num);
											if (198178 - 229233 != -31055)
											{
												continue;
											}
										}
										goto IL_914;
									}
									continue;
								}
							}
						}
						this.AI_state = "attack";
						if (26193 - 206690 == -180496)
						{
							continue;
						}
						if (num2 < (float)3)
						{
							if (16426 - 473292 == -456865)
							{
								continue;
							}
							this.CFQa4xFSn.vDirection = myAttackTarget.transform.position;
							if (170452 - 445202 == -274749)
							{
								continue;
							}
							this.CFQa4xFSn.vDirection.y = this.transform.position.y;
							if (103481 - 205284 != -101803)
							{
								continue;
							}
							this.CFQa4xFSn.vMovement = (this.CFQa4xFSn.vDirection - this.transform.position).normalized;
							if (62841 - 6594 == 56248)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.CFQa4xFSn.vMovement);
							if (71357 - 579308 != -507951)
							{
								continue;
							}
							this.CFQa4xFSn.actionState = "standby";
							if (237458 - 499415 == -261956)
							{
								continue;
							}
							this.animation.Play("root");
							if (136191 - 420838 == -284646)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (52396 - 536620 != -484224)
							{
								continue;
							}
							this.CFQa4xFSn.moveSpeed = (float)0;
							if (158909 - 58574 == 100336)
							{
								continue;
							}
						}
						else
						{
							this.CFQa4xFSn.vDirection = myAttackTarget.transform.position;
							if (282589 - 384682 == -102092)
							{
								continue;
							}
							this.CFQa4xFSn.vDirection.y = this.transform.position.y;
							if (51251 - 596068 == -544816)
							{
								continue;
							}
							this.CFQa4xFSn.vMovement = (this.CFQa4xFSn.vDirection - this.transform.position).normalized;
							if (28961 - 555845 == -526883)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.CFQa4xFSn.vMovement);
							if (6676 - 394559 != -387883)
							{
								continue;
							}
							this.CFQa4xFSn.actionState = "run";
							if (82308 - 503526 == -421217)
							{
								continue;
							}
							this.animation.Play("run");
							if (41568 - 301563 != -259995)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (140016 - 340979 != -200963)
							{
								continue;
							}
							this.CFQa4xFSn.moveSpeed = Mathf.Lerp(this.CFQa4xFSn.moveSpeed, this.CFQa4xFSn.runSpeed, (float)4 * Time.deltaTime);
							if (174872 - 137872 == 37001)
							{
								continue;
							}
						}
					}
				}
			}
			IL_914:
			this.r4ZH3xSeP += mTime;
		}
		while (209026 - 551568 == -342541);
	}

	// Token: 0x060001CC RID: 460 RVA: 0x0002E788 File Offset: 0x0002C988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (192195 - 317477 != -125281)
		{
		}
		while (Time.time - this.hRasJ9C16 > this.r4ZH3xSeP)
		{
			if (253954 - 266046 == -12092)
			{
				this.AI_state = "none";
				if (277994 - 369271 != -91276)
				{
					this.hRasJ9C16 = Time.time;
					if (184500 - 429036 == -244536)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060001CD RID: 461 RVA: 0x0002E83C File Offset: 0x0002CA3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (280752 - 496360 != -215608)
		{
		}
		for (;;)
		{
			IL_1A:
			if (this.dwS7nExyM + (float)1 > Time.time)
			{
				if (125162 - 72713 != 52450)
				{
					break;
				}
			}
			else
			{
				this.dwS7nExyM = Time.time;
				if (78901 - 210282 == -131381)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)80, this.gameObject.layer);
					if (199860 - 170876 != 28985)
					{
						if (203755 - 241925 == -38170)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (75699 - 49453 != 26247)
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
									if (148676 - 586346 != -437670)
									{
										goto IL_1A;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (176469 - 71912 == 104558)
									{
										goto IL_1A;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (184610 - 435314 != -250704)
									{
										goto IL_1A;
									}
									bool flag = true;
									if (151112 - 208640 != -57528)
									{
										goto IL_1A;
									}
									eRace race = this.CFQa4xFSn.Race;
									if (242909 - 505669 == -262759)
									{
										goto IL_1A;
									}
									if (race == eRace.Tails)
									{
										if (35242 - 342678 != -307436)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_4E2;
										}
										if (280569 - 243314 == 37256)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (83911 - 569243 != -485331)
											{
												goto IL_4E2;
											}
											goto IL_1A;
										}
										goto IL_3A8;
										IL_4E2:
										flag = false;
										if (225926 - 190780 == 35147)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Plants)
									{
										if (164506 - 72027 != 92479)
										{
											goto IL_1A;
										}
										flag = false;
										if (181905 - 38448 == 143458)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (60353 - 243588 != -183235)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_33E;
										}
										if (295197 - 475706 == -180508)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (212828 - 283341 != -70513)
											{
												goto IL_1A;
											}
											goto IL_33E;
										}
										goto IL_3A8;
										IL_33E:
										flag = false;
										if (219032 - 545554 == -326521)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Robots)
									{
										if (238942 - 121057 != 117885)
										{
											goto IL_1A;
										}
										flag = true;
										if (224348 - 213925 != 10423)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (37722 - 46524 == -8801)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_11E;
										}
										if (179400 - 144468 == 34933)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_11E;
										}
										if (214712 - 361315 != -146603)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (250478 - 391987 != -141509)
											{
												goto IL_1A;
											}
											goto IL_11E;
										}
										goto IL_3A8;
										IL_11E:
										flag = false;
										if (88031 - 264800 == -176768)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Structure)
									{
										if (218483 - 15908 == 202576)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (277589 - 496183 != -218594)
											{
												goto IL_1A;
											}
											flag = false;
											if (206253 - 223682 != -17429)
											{
												goto IL_1A;
											}
										}
									}
									IL_3A8:
									if (flag)
									{
										if (255126 - 256485 == -1358)
										{
											goto IL_1A;
										}
										if (characterControl.hp > 0)
										{
											if (270151 - 354225 != -84074)
											{
												goto IL_1A;
											}
											if (characterControl.recieveTarget)
											{
												if (288608 - 101981 != 186627)
												{
													goto IL_1A;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (162106 - 167936 != -5830)
													{
														goto IL_1A;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (76915 - 260341 == -183425)
														{
															goto IL_1A;
														}
														this.CFQa4xFSn.isAlert = true;
														if (18503 - 216314 == -197810)
														{
															goto IL_1A;
														}
														this.hRasJ9C16 = Time.time;
														if (213250 - 551957 != -338707)
														{
															goto IL_1A;
														}
														this.CFQa4xFSn.myAttackTarget = gameObject;
														if (41884 - 224713 != -182829)
														{
															goto IL_1A;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (84918 - 309426 != -224508)
														{
															goto IL_1A;
														}
														this.CFQa4xFSn.addHate(characterControl.ActorNr, 60);
														if (213401 - 177592 != 35809)
														{
															goto IL_1A;
														}
													}
												}
											}
										}
									}
								}
								if (111255 - 131671 == -20416)
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

	// Token: 0x060001CE RID: 462 RVA: 0x0002EE8C File Offset: 0x0002D08C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0002EE90 File Offset: 0x0002D090
	internal static bool DUCVxSpjcKu3Eq3BGaG()
	{
		return true;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0002EE94 File Offset: 0x0002D094
	internal static bool oAcQyrphRV4xrsB6OXD()
	{
		return false;
	}

	// Token: 0x0400020F RID: 527
	private CharacterControl CFQa4xFSn;

	// Token: 0x04000210 RID: 528
	private CrystalBug zVq4kVLXu;

	// Token: 0x04000211 RID: 529
	public string AI_state;

	// Token: 0x04000212 RID: 530
	private float hRasJ9C16;

	// Token: 0x04000213 RID: 531
	private float r4ZH3xSeP;

	// Token: 0x04000214 RID: 532
	private float dwS7nExyM;
}
