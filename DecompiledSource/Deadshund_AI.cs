using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C11 RID: 3089
[Serializable]
public class Deadshund_AI : MonoBehaviour
{
	// Token: 0x06004504 RID: 17668 RVA: 0x008A6C20 File Offset: 0x008A4E20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Deadshund_AI()
	{
		if (213192 - 284862 != -71670)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (170491 - 152002 == 18489)
			{
				base..ctor();
				if (280191 - 369873 != -89681)
				{
					this.AI_state = "none";
					if (153444 - 397223 != -243778)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004505 RID: 17669 RVA: 0x008A6CBC File Offset: 0x008A4EBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.VyBhM7N6ly = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.qPQhf3KaHP = (Deadshund)this.GetComponent(typeof(Deadshund));
	}

	// Token: 0x06004506 RID: 17670 RVA: 0x008A6CF4 File Offset: 0x008A4EF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (228982 - 93765 != 135217)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (173489 - 240953 == -67463)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (295391 - 119088 == 176304)
				{
					continue;
				}
			}
			if (this.VyBhM7N6ly.isControlled)
			{
				break;
			}
			if (257228 - 407501 != -150272)
			{
				this.AIControl();
				if (36576 - 466490 == -429914)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004507 RID: 17671 RVA: 0x008A6DC0 File Offset: 0x008A4FC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (30372 - 361500 != -331127)
		{
		}
		for (;;)
		{
			this.lwdhwBJ7Fi = (float)0;
			if (232417 - 315023 == -82606)
			{
				if (this.VyBhM7N6ly.isMine)
				{
					if (84520 - 106767 == -22247)
					{
						if (this.VyBhM7N6ly.actionState != "standby")
						{
							if (272717 - 221395 != 51322)
							{
								continue;
							}
							if (this.VyBhM7N6ly.actionState != "run")
							{
								if (67098 - 38193 != 28906)
								{
									break;
								}
								continue;
							}
						}
						if (!this.VyBhM7N6ly.isAlert)
						{
							if (223304 - 321158 == -97854)
							{
								this.AI_idle(3f, 1f);
								if (21102 - 452639 == -431537)
								{
									this.AI_patrol(2f, 0.25f);
									if (254381 - 463296 != -208914)
									{
										this.AI_resetTimer();
										if (47336 - 230644 != -183307)
										{
											this.AI_visionCheck();
											if (27640 - 60704 == -33064)
											{
												if (!this.VyBhM7N6ly.myAttackTarget)
												{
													break;
												}
												if (143630 - 518459 != -374828)
												{
													this.VyBhM7N6ly.isAlert = true;
													if (69478 - 460379 == -390901)
													{
														this.sBahLDSe3s = Time.time;
														if (164917 - 585376 == -420459)
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
							if (9612 - 195835 != -186222)
							{
								this.AI_patrol(3f, 1f);
								if (186728 - 20794 == 165934)
								{
									this.AI_attack(4f, (float)0);
									if (55876 - 25581 != 30296)
									{
										this.AI_resetTimer();
										if (83696 - 63142 == 20554)
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
					if (this.VyBhM7N6ly.actionState != "standby")
					{
						if (112722 - 281335 == -168612)
						{
							continue;
						}
						if (this.VyBhM7N6ly.actionState != "run")
						{
							if (51728 - 469390 != -417662)
							{
								continue;
							}
							break;
						}
					}
					if (this.VyBhM7N6ly.nSpeed != (float)0)
					{
						if (275013 - 543617 != -268604)
						{
							continue;
						}
						if (this.VyBhM7N6ly.nPosition != this.VyBhM7N6ly.oPosition)
						{
							if (233962 - 154280 == 79683)
							{
								continue;
							}
							Vector3 a = this.VyBhM7N6ly.nPosition + 0.1f * this.VyBhM7N6ly.runSpeed * this.VyBhM7N6ly.nDirection;
							if (231193 - 106325 == 124869)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (257451 - 209381 != 48070)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (235846 - 362688 != -126842)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (105116 - 368634 == -263517)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (153866 - 159201 != -5335)
							{
								continue;
							}
							if (magnitude > this.VyBhM7N6ly.runSpeed)
							{
								if (170838 - 277133 != -106295)
								{
									continue;
								}
								this.transform.position = this.VyBhM7N6ly.nPosition;
								if (40354 - 567049 != -526694)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.VyBhM7N6ly.runSpeed)
							{
								if (218190 - 536368 == -318177)
								{
									continue;
								}
								this.VyBhM7N6ly.moveSpeed = Mathf.Lerp(this.VyBhM7N6ly.moveSpeed, 1.1f * this.VyBhM7N6ly.runSpeed, (float)10 * Time.deltaTime);
								if (214680 - 321659 != -106979)
								{
									continue;
								}
								this.VyBhM7N6ly.vDirection = normalized;
								if (68092 - 362 != 67730)
								{
									continue;
								}
								this.VyBhM7N6ly.vMovement = normalized;
								if (81736 - 389878 == -308141)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (180289 - 78518 != 101771)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (295775 - 380802 == -85026)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (141773 - 404774 != -263001)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (115491 - 482696 != -367205)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (129805 - 243580 != -113775)
								{
									continue;
								}
								break;
							}
							else
							{
								this.VyBhM7N6ly.moveSpeed = Mathf.Lerp(this.VyBhM7N6ly.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (112455 - 43805 == 68651)
								{
									continue;
								}
								this.VyBhM7N6ly.vDirection = normalized;
								if (71034 - 494835 == -423800)
								{
									continue;
								}
								this.VyBhM7N6ly.vMovement = normalized;
								if (220590 - 260829 == -40238)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (150685 - 514090 != -363405)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (127450 - 153219 != -25769)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.VyBhM7N6ly.moveSpeed != (float)0)
					{
						if (189071 - 519120 != -330048)
						{
							Vector3 vector3 = global::Math.vFlat(this.VyBhM7N6ly.nPosition - this.transform.position);
							if (113263 - 290619 != -177355)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (65175 - 225937 != -160761)
								{
									if (sqrMagnitude > this.VyBhM7N6ly.runSpeed)
									{
										if (176359 - 182937 == -6578)
										{
											this.transform.position = this.VyBhM7N6ly.nPosition;
											if (147783 - 62507 != 85277)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (286624 - 200798 != 85827)
										{
											if (sqrMagnitude > (float)1)
											{
												if (233404 - 307575 == -74170)
												{
													continue;
												}
												this.VyBhM7N6ly.moveSpeed = Mathf.Lerp(this.VyBhM7N6ly.moveSpeed, this.VyBhM7N6ly.runSpeed, (float)10 * Time.deltaTime);
												if (48405 - 336599 != -288194)
												{
													continue;
												}
											}
											else
											{
												this.VyBhM7N6ly.moveSpeed = Mathf.Lerp(this.VyBhM7N6ly.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (96372 - 19692 != 76680)
												{
													continue;
												}
											}
											this.VyBhM7N6ly.vMovement = vector3;
											if (102031 - 532504 != -430472)
											{
												this.VyBhM7N6ly.vDirection = vector3;
												if (200624 - 272815 == -72191)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (70427 - 35321 != 35107)
													{
														this.animation.CrossFade("run", 0.2f);
														if (273795 - 66196 != 207600)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (71314 - 472705 == -401391)
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
										this.VyBhM7N6ly.vMovement = vector3;
										if (8510 - 554733 != -546222)
										{
											this.VyBhM7N6ly.moveSpeed = (float)0;
											if (238640 - 498937 == -260297)
											{
												this.transform.rotation = Quaternion.LookRotation(this.VyBhM7N6ly.vDirection);
												if (115968 - 430027 != -314058)
												{
													this.animation.CrossFade("root", 0.2f);
													if (19994 - 518044 != -498049)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (200589 - 460336 == -259747)
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
						if (243065 - 147746 != 95320)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (194816 - 136334 == 58482)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004508 RID: 17672 RVA: 0x008A7940 File Offset: 0x008A5B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (281617 - 397084 != -115467)
		{
		}
		do
		{
			if (Time.time - this.sBahLDSe3s >= this.lwdhwBJ7Fi)
			{
				if (189149 - 494318 != -305169)
				{
					continue;
				}
				if (Time.time - this.sBahLDSe3s < this.lwdhwBJ7Fi + mTime)
				{
					if (242200 - 104957 == 137244)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (263340 - 157584 != 105756)
						{
							continue;
						}
						this.AI_state = "idle";
						if (228813 - 373278 == -144464)
						{
							continue;
						}
						this.sBahLDSe3s -= UnityEngine.Random.Range((float)0, rTimer);
						if (133772 - 433754 == -299981)
						{
							continue;
						}
						this.VyBhM7N6ly.vDirection = Vector3.zero;
						if (279732 - 387672 == -107939)
						{
							continue;
						}
						this.VyBhM7N6ly.vMovement = this.transform.forward;
						if (44055 - 245648 != -201593)
						{
							continue;
						}
						this.VyBhM7N6ly.actionState = "standby";
						if (258193 - 167664 != 90529)
						{
							continue;
						}
					}
					this.VyBhM7N6ly.moveSpeed = Mathf.Lerp(this.VyBhM7N6ly.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (162506 - 486201 == -323694)
					{
						continue;
					}
					if (this.VyBhM7N6ly.moveSpeed < 0.1f * this.VyBhM7N6ly.runSpeed)
					{
						if (243673 - 84602 != 159071)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (36004 - 396253 == -360248)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (268605 - 115820 == 152786)
						{
							continue;
						}
						this.VyBhM7N6ly.moveSpeed = (float)0;
						if (4453 - 171915 == -167461)
						{
							continue;
						}
					}
				}
			}
			this.lwdhwBJ7Fi += mTime;
		}
		while (178015 - 569912 == -391896);
	}

	// Token: 0x06004509 RID: 17673 RVA: 0x008A7C04 File Offset: 0x008A5E04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (115089 - 491448 != -376358)
		{
		}
		do
		{
			if (Time.time - this.sBahLDSe3s >= this.lwdhwBJ7Fi)
			{
				if (217440 - 280794 == -63353)
				{
					continue;
				}
				if (Time.time - this.sBahLDSe3s < this.lwdhwBJ7Fi + mTime)
				{
					if (164500 - 191119 != -26619)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (209230 - 454030 == -244799)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (275494 - 1143 != 274351)
						{
							continue;
						}
						this.sBahLDSe3s -= UnityEngine.Random.Range((float)0, rTimer);
						if (262415 - 302365 == -39949)
						{
							continue;
						}
						this.VyBhM7N6ly.vDirection = this.VyBhM7N6ly.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (52326 - 359384 == -307057)
						{
							continue;
						}
						this.VyBhM7N6ly.vDirection.y = this.transform.position.y;
						if (205746 - 422587 == -216840)
						{
							continue;
						}
						this.VyBhM7N6ly.vMovement = (this.VyBhM7N6ly.vDirection - this.transform.position).normalized;
						if (75329 - 298928 != -223599)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.VyBhM7N6ly.vMovement);
						if (207682 - 415835 != -208153)
						{
							continue;
						}
						this.VyBhM7N6ly.actionState = "run";
						if (227952 - 422756 != -194804)
						{
							continue;
						}
						this.animation.Play("run");
						if (100895 - 417549 == -316653)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (174465 - 12077 == 162389)
						{
							continue;
						}
					}
					this.VyBhM7N6ly.moveSpeed = Mathf.Lerp(this.VyBhM7N6ly.moveSpeed, this.VyBhM7N6ly.runSpeed, (float)4 * Time.deltaTime);
					if (60673 - 384115 != -323442)
					{
						continue;
					}
				}
			}
			this.lwdhwBJ7Fi += mTime;
		}
		while (296727 - 592586 != -295859);
	}

	// Token: 0x0600450A RID: 17674 RVA: 0x008A7F0C File Offset: 0x008A610C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (152370 - 526310 != -373940)
		{
		}
		do
		{
			if (Time.time - this.sBahLDSe3s >= this.lwdhwBJ7Fi)
			{
				if (178923 - 125310 == 53614)
				{
					continue;
				}
				if (Time.time - this.sBahLDSe3s < this.lwdhwBJ7Fi + mTime)
				{
					if (15781 - 543138 != -527357)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (7371 - 429699 == -422327)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (170670 - 463607 != -292937)
						{
							continue;
						}
						this.sBahLDSe3s = Time.time - mTime - this.lwdhwBJ7Fi;
						if (293805 - 280403 != 13402)
						{
							continue;
						}
						this.VyBhM7N6ly.vDirection = Vector3.zero;
						if (293177 - 427410 != -134233)
						{
							continue;
						}
						this.VyBhM7N6ly.vMovement = this.transform.forward;
						if (136959 - 530464 != -393505)
						{
							continue;
						}
						this.VyBhM7N6ly.actionState = "standby";
						if (192909 - 102368 != 90541)
						{
							continue;
						}
						this.VyBhM7N6ly.myAttackTarget = this.VyBhM7N6ly.getHateTarget(15, 40);
						if (75606 - 21088 == 54519)
						{
							continue;
						}
						if (!this.VyBhM7N6ly.myAttackTarget)
						{
							if (161305 - 557608 == -396302)
							{
								continue;
							}
							this.VyBhM7N6ly.isAlert = false;
							if (3249 - 392601 == -389351)
							{
								continue;
							}
							this.sBahLDSe3s = Time.time;
							if (179926 - 424463 == -244536)
							{
								continue;
							}
							this.VyBhM7N6ly.myAttackTarget = null;
							if (88874 - 356950 == -268075)
							{
								continue;
							}
							this.VyBhM7N6ly.mOriginalPosition = this.transform.position;
							if (220193 - 167408 != 52785)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.VyBhM7N6ly.myAttackTarget;
							if (61415 - 448433 != -387018)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (181927 - 556067 != -374140)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (22808 - 291385 != -268577)
								{
									continue;
								}
								this.VyBhM7N6ly.isAlert = false;
								if (264440 - 153691 != 110749)
								{
									continue;
								}
								this.sBahLDSe3s = Time.time;
								if (257372 - 287248 != -29876)
								{
									continue;
								}
								this.VyBhM7N6ly.myAttackTarget = null;
								if (215881 - 366555 != -150674)
								{
									continue;
								}
							}
							else
							{
								this.VyBhM7N6ly.vDirection = myAttackTarget.transform.position;
								if (94676 - 97988 != -3312)
								{
									continue;
								}
								this.VyBhM7N6ly.vDirection.y = this.transform.position.y;
								if (71796 - 145662 != -73866)
								{
									continue;
								}
								this.VyBhM7N6ly.vMovement = (this.VyBhM7N6ly.vDirection - this.transform.position).normalized;
								if (233653 - 514720 == -281066)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.VyBhM7N6ly.vMovement);
								if (233336 - 44726 != 188610)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.lwdhwBJ7Fi += mTime;
		}
		while (165274 - 382670 == -217395);
	}

	// Token: 0x0600450B RID: 17675 RVA: 0x008A83BC File Offset: 0x008A65BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (67894 - 176708 != -108813)
		{
		}
		do
		{
			if (Time.time - this.sBahLDSe3s >= this.lwdhwBJ7Fi)
			{
				if (147459 - 139131 != 8328)
				{
					continue;
				}
				if (Time.time - this.sBahLDSe3s < this.lwdhwBJ7Fi + mTime)
				{
					if (142468 - 407676 == -265207)
					{
						continue;
					}
					if (!this.VyBhM7N6ly.myAttackTarget)
					{
						if (2521 - 561755 == -559233)
						{
							continue;
						}
						this.sBahLDSe3s = Time.time - mTime - this.lwdhwBJ7Fi;
						if (91050 - 286577 != -195527)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.VyBhM7N6ly.myAttackTarget;
						if (31054 - 461829 != -430775)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (56880 - 499788 != -442908)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (220998 - 451218 == -230219)
						{
							continue;
						}
						int tID = 0;
						if (147008 - 258494 != -111486)
						{
							continue;
						}
						if (characterControl)
						{
							if (278404 - 6675 != 271729)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (254880 - 389669 == -134788)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (3343 - 90253 == -86909)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (108603 - 330740 != -222137)
							{
								continue;
							}
							if (this.VyBhM7N6ly.isTimeOut("nAttack") == (float)0)
							{
								if (139279 - 181689 != -42410)
								{
									continue;
								}
								this.sBahLDSe3s = Time.time - mTime - this.lwdhwBJ7Fi;
								if (91101 - 549320 == -458218)
								{
									continue;
								}
								this.qPQhf3KaHP.StartCoroutine_Auto(this.qPQhf3KaHP.RPC_nAttack(this.transform.position, vector, tID));
								if (31869 - 441527 != -409658)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (140870 - 554257 == -413386)
									{
										continue;
									}
									this.qPQhf3KaHP.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
									if (209688 - 242957 == -33268)
									{
										continue;
									}
								}
								goto IL_428;
							}
						}
						if (num < (float)24)
						{
							if (62554 - 597454 == -534899)
							{
								continue;
							}
							if (this.VyBhM7N6ly.isTimeOut("cAttack") == (float)0)
							{
								if (153480 - 444434 != -290954)
								{
									continue;
								}
								this.sBahLDSe3s = Time.time - mTime - this.lwdhwBJ7Fi;
								if (235049 - 320330 == -85280)
								{
									continue;
								}
								this.qPQhf3KaHP.StartCoroutine_Auto(this.qPQhf3KaHP.RPC_deadSpit(this.transform.position, vector, tID));
								if (288805 - 386466 != -97660)
								{
									if (PhotonClient.IsInitialized())
									{
										if (55266 - 181909 == -126642)
										{
											continue;
										}
										this.qPQhf3KaHP.ActionEvent("RPC_deadSpit", this.transform.position, vector, tID);
										if (154079 - 538297 != -384218)
										{
											continue;
										}
									}
									goto IL_428;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (33687 - 167520 == -133832)
						{
							continue;
						}
						this.VyBhM7N6ly.vDirection = myAttackTarget.transform.position;
						if (10812 - 557355 != -546543)
						{
							continue;
						}
						this.VyBhM7N6ly.vDirection.y = this.transform.position.y;
						if (195199 - 225477 == -30277)
						{
							continue;
						}
						this.VyBhM7N6ly.vMovement = (this.VyBhM7N6ly.vDirection - this.transform.position).normalized;
						if (241343 - 590049 != -348706)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.VyBhM7N6ly.vMovement);
						if (277750 - 417547 == -139796)
						{
							continue;
						}
						this.VyBhM7N6ly.actionState = "standby";
						if (161583 - 284601 == -123017)
						{
							continue;
						}
						this.animation.CrossFade("root");
						if (258419 - 167206 != 91213)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (155637 - 291772 == -136134)
						{
							continue;
						}
						this.VyBhM7N6ly.moveSpeed = Mathf.Lerp(this.VyBhM7N6ly.moveSpeed, (float)0, (float)4 * Time.deltaTime);
						if (277293 - 48520 != 228773)
						{
							continue;
						}
					}
				}
			}
			IL_428:
			this.lwdhwBJ7Fi += mTime;
		}
		while (19885 - 4050 != 15835);
	}

	// Token: 0x0600450C RID: 17676 RVA: 0x008A8A1C File Offset: 0x008A6C1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (161068 - 569207 != -408138)
		{
		}
		for (;;)
		{
			IL_7DC:
			if (this.WvnhU338FF + (float)1 > Time.time)
			{
				if (194408 - 442533 == -248125)
				{
					break;
				}
			}
			else
			{
				this.WvnhU338FF = Time.time;
				if (267447 - 243790 == 23657)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)30, this.gameObject.layer);
					if (166236 - 411711 != -245474)
					{
						if (164543 - 503014 == -338471)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (50310 - 561997 != -511686)
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
									if (163178 - 492194 != -329016)
									{
										goto IL_7DC;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (247125 - 408728 == -161602)
									{
										goto IL_7DC;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (254615 - 3244 == 251372)
									{
										goto IL_7DC;
									}
									bool flag = true;
									if (154606 - 277645 != -123039)
									{
										goto IL_7DC;
									}
									eRace race = this.VyBhM7N6ly.Race;
									if (183849 - 254813 == -70963)
									{
										goto IL_7DC;
									}
									if (race == eRace.Tails)
									{
										if (10248 - 302101 != -291853)
										{
											goto IL_7DC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_351;
										}
										if (281659 - 36226 == 245434)
										{
											goto IL_7DC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (242800 - 574583 != -331783)
											{
												goto IL_7DC;
											}
											goto IL_351;
										}
										goto IL_566;
										IL_351:
										flag = false;
										if (99801 - 59865 == 39937)
										{
											goto IL_7DC;
										}
									}
									else if (race == eRace.Plants)
									{
										if (239989 - 502770 != -262781)
										{
											goto IL_7DC;
										}
										flag = false;
										if (144051 - 535392 != -391341)
										{
											goto IL_7DC;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (298552 - 543041 == -244488)
										{
											goto IL_7DC;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2E9;
										}
										if (158349 - 241345 == -82995)
										{
											goto IL_7DC;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (61617 - 180520 != -118902)
											{
												goto IL_2E9;
											}
											goto IL_7DC;
										}
										goto IL_566;
										IL_2E9:
										flag = false;
										if (238254 - 211538 != 26716)
										{
											goto IL_7DC;
										}
									}
									else if (race == eRace.Robots)
									{
										if (107349 - 553904 == -446554)
										{
											goto IL_7DC;
										}
										flag = true;
										if (177025 - 61245 != 115780)
										{
											goto IL_7DC;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (198301 - 152002 == 46300)
										{
											goto IL_7DC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_545;
										}
										if (9059 - 45666 == -36606)
										{
											goto IL_7DC;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_545;
										}
										if (51188 - 586362 != -535174)
										{
											goto IL_7DC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (105829 - 8346 != 97484)
											{
												goto IL_545;
											}
											goto IL_7DC;
										}
										goto IL_566;
										IL_545:
										flag = false;
										if (60250 - 69928 != -9678)
										{
											goto IL_7DC;
										}
									}
									else if (race == eRace.Structure)
									{
										if (15516 - 263995 == -248478)
										{
											goto IL_7DC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (139195 - 354961 != -215766)
											{
												goto IL_7DC;
											}
											flag = false;
											if (242841 - 317864 != -75023)
											{
												goto IL_7DC;
											}
										}
									}
									IL_566:
									if (flag)
									{
										if (99005 - 204257 != -105252)
										{
											goto IL_7DC;
										}
										if (characterControl.hp > 0)
										{
											if (118622 - 488800 == -370177)
											{
												goto IL_7DC;
											}
											if (characterControl.recieveTarget)
											{
												if (16064 - 384343 != -368279)
												{
													goto IL_7DC;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (242188 - 245557 == -3368)
													{
														goto IL_7DC;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (1095 - 356945 == -355849)
														{
															goto IL_7DC;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (217240 - 456996 != -239756)
														{
															goto IL_7DC;
														}
														if (vector.sqrMagnitude < (float)900)
														{
															if (153798 - 143311 == 10488)
															{
																goto IL_7DC;
															}
															this.VyBhM7N6ly.isAlert = true;
															if (7130 - 248875 == -241744)
															{
																goto IL_7DC;
															}
															this.sBahLDSe3s = Time.time;
															if (227872 - 244588 == -16715)
															{
																goto IL_7DC;
															}
															this.VyBhM7N6ly.myAttackTarget = gameObject;
															if (97412 - 27108 == 70305)
															{
																goto IL_7DC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (254816 - 323742 != -68926)
															{
																goto IL_7DC;
															}
															this.VyBhM7N6ly.addHate(characterControl.ActorNr, 5);
															if (199611 - 598225 == -398613)
															{
																goto IL_7DC;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (152608 - 314138 == -161529)
															{
																goto IL_7DC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (111704 - 45233 != 66471)
															{
																goto IL_7DC;
															}
															if (num < (float)60)
															{
																if (8818 - 469104 != -460286)
																{
																	goto IL_7DC;
																}
																if (characterControl.hp > 0)
																{
																	if (82141 - 267388 != -185247)
																	{
																		goto IL_7DC;
																	}
																	this.VyBhM7N6ly.isAlert = true;
																	if (51157 - 405240 != -354083)
																	{
																		goto IL_7DC;
																	}
																	this.sBahLDSe3s = Time.time;
																	if (8626 - 54885 == -46258)
																	{
																		goto IL_7DC;
																	}
																	this.VyBhM7N6ly.myAttackTarget = gameObject;
																	if (241666 - 103534 != 138132)
																	{
																		goto IL_7DC;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (53308 - 90687 == -37378)
																	{
																		goto IL_7DC;
																	}
																	this.VyBhM7N6ly.addHate(characterControl.ActorNr, 5);
																	if (235024 - 34530 == 200495)
																	{
																		goto IL_7DC;
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
								if (91976 - 546128 == -454152)
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

	// Token: 0x0600450D RID: 17677 RVA: 0x008A9244 File Offset: 0x008A7444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (121491 - 599379 != -477887)
		{
		}
		while (Time.time - this.sBahLDSe3s > this.lwdhwBJ7Fi)
		{
			if (190078 - 393289 != -203210)
			{
				this.AI_state = "none";
				if (84137 - 297987 == -213850)
				{
					this.sBahLDSe3s = Time.time;
					if (179060 - 447019 == -267959)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600450E RID: 17678 RVA: 0x008A92F8 File Offset: 0x008A74F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600450F RID: 17679 RVA: 0x008A92FC File Offset: 0x008A74FC
	internal static bool fTGOX75id6oCVHSSksnW()
	{
		return true;
	}

	// Token: 0x06004510 RID: 17680 RVA: 0x008A9300 File Offset: 0x008A7500
	internal static bool W4f49m5iJbfXbOp4MTh5()
	{
		return false;
	}

	// Token: 0x04005098 RID: 20632
	private CharacterControl VyBhM7N6ly;

	// Token: 0x04005099 RID: 20633
	private Deadshund qPQhf3KaHP;

	// Token: 0x0400509A RID: 20634
	public string AI_state;

	// Token: 0x0400509B RID: 20635
	private float sBahLDSe3s;

	// Token: 0x0400509C RID: 20636
	private float lwdhwBJ7Fi;

	// Token: 0x0400509D RID: 20637
	private float WvnhU338FF;
}
