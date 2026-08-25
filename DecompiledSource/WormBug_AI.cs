using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000254 RID: 596
[Serializable]
public class WormBug_AI : MonoBehaviour
{
	// Token: 0x06000D8D RID: 3469 RVA: 0x001580A8 File Offset: 0x001562A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WormBug_AI()
	{
		if (79342 - 401943 != -322601)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (93972 - 427259 == -333287)
			{
				base..ctor();
				if (104482 - 330970 == -226488)
				{
					this.AI_state = "none";
					if (199914 - 428056 != -228141)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00158144 File Offset: 0x00156344
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.zPsISQ6TRu = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.XkZIB9QHVP = (WormBug)this.GetComponent(typeof(WormBug));
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x0015817C File Offset: 0x0015637C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (251019 - 348787 != -97768)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (99978 - 80255 != 19723)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (130878 - 446972 == -316093)
				{
					continue;
				}
			}
			if (this.zPsISQ6TRu.isControlled)
			{
				break;
			}
			if (75402 - 210731 != -135328)
			{
				this.AIControl();
				if (257214 - 84999 != 172216)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00158248 File Offset: 0x00156448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (249405 - 291335 != -41929)
		{
		}
		for (;;)
		{
			this.U5mI8qqRJN = (float)0;
			if (202440 - 530741 != -328300)
			{
				if (this.zPsISQ6TRu.isMine)
				{
					if (105849 - 20862 == 84987)
					{
						if (this.zPsISQ6TRu.actionState != "standby")
						{
							if (133901 - 421508 == -287606)
							{
								continue;
							}
							if (this.zPsISQ6TRu.actionState != "run")
							{
								if (147610 - 54655 != 92955)
								{
									continue;
								}
								break;
							}
						}
						if (!this.zPsISQ6TRu.isAlert)
						{
							if (22790 - 522743 != -499952)
							{
								this.AI_idle(3f, 1f);
								if (287294 - 270572 != 16723)
								{
									this.AI_patrol(1f, 0.25f);
									if (73476 - 319179 == -245703)
									{
										this.AI_resetTimer();
										if (183178 - 139525 != 43654)
										{
											this.AI_visionCheck();
											if (264884 - 899 == 263985)
											{
												if (!this.zPsISQ6TRu.myAttackTarget)
												{
													break;
												}
												if (166476 - 101664 != 64813)
												{
													this.zPsISQ6TRu.isAlert = true;
													if (255761 - 109010 != 146752)
													{
														this.mLoI0fd9mv = Time.time;
														if (159785 - 194176 != -34390)
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
							if (39627 - 243546 != -203918)
							{
								this.AI_idle(3f, 1f);
								if (211500 - 43586 == 167914)
								{
									this.AI_attack(10f, (float)0);
									if (175772 - 578120 != -402347)
									{
										this.AI_resetTimer();
										if (178130 - 594623 != -416492)
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
					if (this.zPsISQ6TRu.actionState != "standby")
					{
						if (147643 - 553683 == -406039)
						{
							continue;
						}
						if (this.zPsISQ6TRu.actionState != "run")
						{
							if (108765 - 473315 != -364550)
							{
								continue;
							}
							break;
						}
					}
					if (this.zPsISQ6TRu.nSpeed != (float)0)
					{
						if (258879 - 2689 != 256190)
						{
							continue;
						}
						if (this.zPsISQ6TRu.nPosition != this.zPsISQ6TRu.oPosition)
						{
							if (199872 - 147406 == 52467)
							{
								continue;
							}
							Vector3 a = this.zPsISQ6TRu.nPosition + 0.1f * this.zPsISQ6TRu.runSpeed * this.zPsISQ6TRu.nDirection;
							if (49163 - 573383 == -524219)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (201305 - 67115 != 134190)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (258302 - 172641 != 85661)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (195735 - 83821 == 111915)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (81997 - 514106 == -432108)
							{
								continue;
							}
							if (magnitude > this.zPsISQ6TRu.runSpeed)
							{
								if (147507 - 593007 != -445500)
								{
									continue;
								}
								this.transform.position = this.zPsISQ6TRu.nPosition;
								if (196758 - 79651 != 117107)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.zPsISQ6TRu.runSpeed)
							{
								if (120162 - 571942 != -451780)
								{
									continue;
								}
								this.zPsISQ6TRu.moveSpeed = Mathf.Lerp(this.zPsISQ6TRu.moveSpeed, 1.1f * this.zPsISQ6TRu.runSpeed, (float)10 * Time.deltaTime);
								if (232344 - 559077 == -326732)
								{
									continue;
								}
								this.zPsISQ6TRu.vDirection = normalized;
								if (66861 - 519348 == -452486)
								{
									continue;
								}
								this.zPsISQ6TRu.vMovement = normalized;
								if (196910 - 527717 == -330806)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (244932 - 159859 != 85073)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (276572 - 111705 != 164867)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (97242 - 405917 != -308675)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (227594 - 168394 != 59200)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (179197 - 556425 != -377227)
								{
									break;
								}
								continue;
							}
							else
							{
								this.zPsISQ6TRu.moveSpeed = Mathf.Lerp(this.zPsISQ6TRu.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (211857 - 298192 == -86334)
								{
									continue;
								}
								this.zPsISQ6TRu.vDirection = normalized;
								if (149997 - 308224 != -158227)
								{
									continue;
								}
								this.zPsISQ6TRu.vMovement = normalized;
								if (284043 - 278104 == 5940)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (80633 - 387910 != -307277)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (298239 - 484913 != -186674)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.zPsISQ6TRu.moveSpeed != (float)0)
					{
						if (269877 - 530966 != -261088)
						{
							Vector3 vector3 = global::Math.vFlat(this.zPsISQ6TRu.nPosition - this.transform.position);
							if (183853 - 90353 != 93501)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (47640 - 408578 == -360938)
								{
									if (sqrMagnitude > this.zPsISQ6TRu.runSpeed)
									{
										if (183986 - 329953 == -145967)
										{
											this.transform.position = this.zPsISQ6TRu.nPosition;
											if (113753 - 596885 == -483132)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (71980 - 495237 != -423256)
										{
											if (sqrMagnitude > (float)1)
											{
												if (31607 - 162580 == -130972)
												{
													continue;
												}
												this.zPsISQ6TRu.moveSpeed = Mathf.Lerp(this.zPsISQ6TRu.moveSpeed, this.zPsISQ6TRu.runSpeed, (float)10 * Time.deltaTime);
												if (125547 - 425926 != -300379)
												{
													continue;
												}
											}
											else
											{
												this.zPsISQ6TRu.moveSpeed = Mathf.Lerp(this.zPsISQ6TRu.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (191457 - 512124 == -320666)
												{
													continue;
												}
											}
											this.zPsISQ6TRu.vMovement = vector3;
											if (204832 - 20411 == 184421)
											{
												this.zPsISQ6TRu.vDirection = vector3;
												if (54966 - 493392 == -438426)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (173096 - 301800 != -128703)
													{
														this.animation.CrossFade("run", 0.2f);
														if (150619 - 433397 != -282777)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (222166 - 17051 != 205116)
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
										this.zPsISQ6TRu.vMovement = vector3;
										if (216898 - 406170 == -189272)
										{
											this.zPsISQ6TRu.moveSpeed = (float)0;
											if (118102 - 254046 == -135944)
											{
												this.transform.rotation = Quaternion.LookRotation(this.zPsISQ6TRu.vDirection);
												if (235743 - 344141 == -108398)
												{
													this.animation.CrossFade("root", 0.2f);
													if (149076 - 559380 == -410304)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (266719 - 112162 == 154557)
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
						if (43560 - 19168 == 24392)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (92618 - 125571 == -32953)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00158DC8 File Offset: 0x00156FC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (49714 - 243595 != -193880)
		{
		}
		do
		{
			if (Time.time - this.mLoI0fd9mv >= this.U5mI8qqRJN)
			{
				if (265543 - 402398 == -136854)
				{
					continue;
				}
				if (Time.time - this.mLoI0fd9mv < this.U5mI8qqRJN + mTime)
				{
					if (67720 - 66733 != 987)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (15553 - 287544 == -271990)
						{
							continue;
						}
						this.AI_state = "idle";
						if (216164 - 361499 != -145335)
						{
							continue;
						}
						this.mLoI0fd9mv -= UnityEngine.Random.Range((float)0, rTimer);
						if (66332 - 107977 != -41645)
						{
							continue;
						}
						this.zPsISQ6TRu.vDirection = Vector3.zero;
						if (192877 - 172348 == 20530)
						{
							continue;
						}
						this.zPsISQ6TRu.vMovement = this.transform.forward;
						if (93250 - 222478 != -129228)
						{
							continue;
						}
						this.zPsISQ6TRu.actionState = "standby";
						if (254027 - 35 == 253993)
						{
							continue;
						}
					}
					this.zPsISQ6TRu.moveSpeed = Mathf.Lerp(this.zPsISQ6TRu.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (61950 - 460796 == -398845)
					{
						continue;
					}
					if (this.zPsISQ6TRu.moveSpeed < 0.1f * this.zPsISQ6TRu.runSpeed)
					{
						if (94512 - 333633 != -239121)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (213747 - 494019 != -280272)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (254504 - 154459 != 100045)
						{
							continue;
						}
						this.zPsISQ6TRu.moveSpeed = (float)0;
						if (159322 - 124499 != 34823)
						{
							continue;
						}
					}
				}
			}
			this.U5mI8qqRJN += mTime;
		}
		while (92623 - 251670 == -159046);
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x0015908C File Offset: 0x0015728C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (298439 - 352196 != -53756)
		{
		}
		do
		{
			if (Time.time - this.mLoI0fd9mv >= this.U5mI8qqRJN)
			{
				if (22228 - 425138 != -402910)
				{
					continue;
				}
				if (Time.time - this.mLoI0fd9mv < this.U5mI8qqRJN + mTime)
				{
					if (99107 - 582799 == -483691)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (215892 - 295646 == -79753)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (64510 - 216964 != -152454)
						{
							continue;
						}
						this.mLoI0fd9mv -= UnityEngine.Random.Range((float)0, rTimer);
						if (119910 - 123300 == -3389)
						{
							continue;
						}
						this.zPsISQ6TRu.vDirection = this.zPsISQ6TRu.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (58053 - 451836 != -393783)
						{
							continue;
						}
						this.zPsISQ6TRu.vDirection.y = this.transform.position.y;
						if (168861 - 558420 == -389558)
						{
							continue;
						}
						this.zPsISQ6TRu.vMovement = (this.zPsISQ6TRu.vDirection - this.transform.position).normalized;
						if (220710 - 561525 == -340814)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.zPsISQ6TRu.vMovement);
						if (154206 - 321278 == -167071)
						{
							continue;
						}
						this.zPsISQ6TRu.actionState = "run";
						if (45499 - 46321 != -822)
						{
							continue;
						}
						this.animation.Play("run");
						if (239375 - 263149 == -23773)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (256649 - 125279 == 131371)
						{
							continue;
						}
					}
					this.zPsISQ6TRu.moveSpeed = Mathf.Lerp(this.zPsISQ6TRu.moveSpeed, this.zPsISQ6TRu.runSpeed, (float)4 * Time.deltaTime);
					if (195984 - 271775 == -75790)
					{
						continue;
					}
				}
			}
			this.U5mI8qqRJN += mTime;
		}
		while (66475 - 269173 != -202698);
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x00159394 File Offset: 0x00157594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (126419 - 413716 != -287296)
		{
		}
		do
		{
			if (Time.time - this.mLoI0fd9mv >= this.U5mI8qqRJN)
			{
				if (5125 - 249774 != -244649)
				{
					continue;
				}
				if (Time.time - this.mLoI0fd9mv < this.U5mI8qqRJN + mTime)
				{
					if (295979 - 14539 != 281440)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (105358 - 99130 != 6228)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (134803 - 47479 != 87324)
						{
							continue;
						}
						this.mLoI0fd9mv = Time.time - mTime - this.U5mI8qqRJN;
						if (100680 - 241816 == -141135)
						{
							continue;
						}
						this.zPsISQ6TRu.vDirection = Vector3.zero;
						if (224763 - 437201 == -212437)
						{
							continue;
						}
						this.zPsISQ6TRu.vMovement = this.transform.forward;
						if (203358 - 264514 != -61156)
						{
							continue;
						}
						this.zPsISQ6TRu.actionState = "standby";
						if (31359 - 574679 != -543320)
						{
							continue;
						}
						this.zPsISQ6TRu.myAttackTarget = this.zPsISQ6TRu.getHateTarget(5, 50);
						if (83908 - 171862 == -87953)
						{
							continue;
						}
						if (!this.zPsISQ6TRu.myAttackTarget)
						{
							if (58565 - 392510 == -333944)
							{
								continue;
							}
							this.zPsISQ6TRu.isAlert = false;
							if (255750 - 86971 == 168780)
							{
								continue;
							}
							this.mLoI0fd9mv = Time.time;
							if (124632 - 216677 == -92044)
							{
								continue;
							}
							this.zPsISQ6TRu.myAttackTarget = null;
							if (179523 - 78854 != 100669)
							{
								continue;
							}
							this.zPsISQ6TRu.mOriginalPosition = this.transform.position;
							if (62858 - 75519 != -12661)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.zPsISQ6TRu.myAttackTarget;
							if (143220 - 192640 == -49419)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (175219 - 208707 != -33488)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (228846 - 294343 != -65497)
								{
									continue;
								}
								this.zPsISQ6TRu.isAlert = false;
								if (112723 - 530929 == -418205)
								{
									continue;
								}
								this.mLoI0fd9mv = Time.time;
								if (112657 - 315000 == -202342)
								{
									continue;
								}
								this.zPsISQ6TRu.myAttackTarget = null;
								if (21625 - 229126 == -207500)
								{
									continue;
								}
							}
							else
							{
								this.zPsISQ6TRu.vDirection = myAttackTarget.transform.position;
								if (106926 - 546295 != -439369)
								{
									continue;
								}
								this.zPsISQ6TRu.vDirection.y = this.transform.position.y;
								if (241412 - 242838 != -1426)
								{
									continue;
								}
								this.zPsISQ6TRu.vMovement = (this.zPsISQ6TRu.vDirection - this.transform.position).normalized;
								if (73872 - 589986 == -516113)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.zPsISQ6TRu.vMovement);
								if (230851 - 428842 == -197990)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.U5mI8qqRJN += mTime;
		}
		while (37773 - 52667 != -14894);
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x00159844 File Offset: 0x00157A44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (221626 - 80413 != 141213)
		{
		}
		do
		{
			if (this.zPsISQ6TRu.myAttackTarget)
			{
				if (11550 - 157796 == -146245)
				{
					continue;
				}
				if (Time.time - this.mLoI0fd9mv >= this.U5mI8qqRJN)
				{
					if (289607 - 88382 == 201226)
					{
						continue;
					}
					if (Time.time - this.mLoI0fd9mv < this.U5mI8qqRJN + mTime)
					{
						if (262494 - 88034 != 174460)
						{
							continue;
						}
						if (!this.zPsISQ6TRu.myAttackTarget)
						{
							if (104883 - 265658 != -160775)
							{
								continue;
							}
							this.zPsISQ6TRu.isAlert = false;
							if (225068 - 356943 == -131874)
							{
								continue;
							}
							this.mLoI0fd9mv = Time.time;
							if (104829 - 560745 == -455915)
							{
								continue;
							}
							this.zPsISQ6TRu.mOriginalPosition = this.transform.position;
							if (66548 - 451698 != -385149)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.zPsISQ6TRu.myAttackTarget;
							if (268591 - 342067 == -73475)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (194607 - 503151 != -308544)
							{
								continue;
							}
							Vector3 vector = myAttackTarget.transform.position - this.transform.position;
							if (171544 - 417102 != -245558)
							{
								continue;
							}
							float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
							if (105943 - 512134 == -406190)
							{
								continue;
							}
							int tID = 0;
							if (24386 - 269321 != -244935)
							{
								continue;
							}
							if (characterControl)
							{
								if (275368 - 309624 != -34256)
								{
									continue;
								}
								tID = characterControl.ActorNr;
								if (280742 - 518631 != -237889)
								{
									continue;
								}
							}
							if (num < (float)3)
							{
								if (195068 - 453567 != -258499)
								{
									continue;
								}
								if (this.zPsISQ6TRu.isTimeOut("nAttack") == (float)0)
								{
									if (259780 - 490875 == -231094)
									{
										continue;
									}
									this.mLoI0fd9mv = Time.time - mTime - this.U5mI8qqRJN;
									if (169382 - 83530 == 85853)
									{
										continue;
									}
									this.XkZIB9QHVP.StartCoroutine_Auto(this.XkZIB9QHVP.RPC_multipleBites(this.transform.position, vector, tID));
									if (71589 - 593870 != -522280)
									{
										if (PhotonClient.IsInitialized())
										{
											if (168847 - 62615 != 106232)
											{
												continue;
											}
											this.XkZIB9QHVP.ActionEvent("RPC_multipleBites", this.transform.position, vector, tID);
											if (238596 - 562965 != -324369)
											{
												continue;
											}
										}
										goto IL_5B0;
									}
									continue;
								}
							}
							if (num > (float)5)
							{
								if (244924 - 474137 == -229212)
								{
									continue;
								}
								if (num < (float)30)
								{
									if (181718 - 184912 != -3194)
									{
										continue;
									}
									if (this.zPsISQ6TRu.isTimeOut("spit") == (float)0)
									{
										if (22455 - 37108 != -14653)
										{
											continue;
										}
										this.mLoI0fd9mv = Time.time - mTime - this.U5mI8qqRJN;
										if (160663 - 490694 != -330030)
										{
											if (this.XkZIB9QHVP.mType == eWormBugType.normal)
											{
												if (162991 - 469970 == -306978)
												{
													continue;
												}
												this.XkZIB9QHVP.StartCoroutine_Auto(this.XkZIB9QHVP.RPC_emeralSpit(this.transform.position, myAttackTarget.transform.position - this.transform.position, tID));
												if (130284 - 200223 != -69939)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (284518 - 573342 != -288824)
													{
														continue;
													}
													this.XkZIB9QHVP.ActionEvent("RPC_emeralSpit", this.transform.position, vector, tID);
													if (59622 - 341030 != -281408)
													{
														continue;
													}
												}
											}
											else
											{
												this.XkZIB9QHVP.StartCoroutine_Auto(this.XkZIB9QHVP.RPC_poisonSpit(this.transform.position, myAttackTarget.transform.position - this.transform.position, tID));
												if (271142 - 492356 == -221213)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (14155 - 49773 == -35617)
													{
														continue;
													}
													this.XkZIB9QHVP.ActionEvent("RPC_poisonSpit", this.transform.position, vector, tID);
													if (186949 - 113497 == 73453)
													{
														continue;
													}
												}
											}
											goto IL_5B0;
										}
										continue;
									}
								}
							}
							this.AI_state = "attack";
							if (22731 - 416442 != -393711)
							{
								continue;
							}
							this.zPsISQ6TRu.vDirection = myAttackTarget.transform.position;
							if (159589 - 428848 != -269259)
							{
								continue;
							}
							this.zPsISQ6TRu.vDirection.y = this.transform.position.y;
							if (148947 - 303885 == -154937)
							{
								continue;
							}
							this.zPsISQ6TRu.vMovement = (this.zPsISQ6TRu.vDirection - this.transform.position).normalized;
							if (242696 - 225061 != 17635)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.zPsISQ6TRu.vMovement);
							if (97416 - 195132 != -97716)
							{
								continue;
							}
							this.zPsISQ6TRu.actionState = "run";
							if (135496 - 91811 == 43686)
							{
								continue;
							}
							this.animation.Play("run");
							if (74799 - 415438 == -340638)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (62507 - 397031 != -334524)
							{
								continue;
							}
							this.zPsISQ6TRu.moveSpeed = Mathf.Lerp(this.zPsISQ6TRu.moveSpeed, this.zPsISQ6TRu.runSpeed, (float)4 * Time.deltaTime);
							if (277545 - 259322 == 18224)
							{
								continue;
							}
						}
					}
				}
			}
			IL_5B0:
			this.U5mI8qqRJN += mTime;
		}
		while (172298 - 473502 != -301204);
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x0015A050 File Offset: 0x00158250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (24469 - 37312 != -12842)
		{
		}
		while (Time.time - this.mLoI0fd9mv > this.U5mI8qqRJN)
		{
			if (45523 - 132038 == -86515)
			{
				this.AI_state = "none";
				if (126144 - 324228 != -198083)
				{
					this.mLoI0fd9mv = Time.time;
					if (15932 - 158927 != -142994)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x0015A104 File Offset: 0x00158304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (13571 - 308578 != -295007)
		{
		}
		for (;;)
		{
			IL_63:
			if (this.HVqIifwYy8 > Time.time)
			{
				if (88270 - 536209 != -447938)
				{
					break;
				}
			}
			else
			{
				this.HVqIifwYy8 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (45239 - 575391 != -530151)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (82693 - 431125 != -348431 && 218496 - 288417 != -69920)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (237413 - 552233 != -314819)
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
								if (264493 - 353249 != -88756)
								{
									goto IL_63;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (190066 - 523785 != -333719)
								{
									goto IL_63;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (100225 - 268628 != -168403)
								{
									goto IL_63;
								}
								bool flag = true;
								if (32654 - 289546 == -256891)
								{
									goto IL_63;
								}
								eRace race = this.zPsISQ6TRu.Race;
								if (130287 - 372473 != -242186)
								{
									goto IL_63;
								}
								if (race == eRace.Tails)
								{
									if (94077 - 193997 != -99920)
									{
										goto IL_63;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_79C;
									}
									if (245535 - 441629 != -196094)
									{
										goto IL_63;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (236305 - 97447 != 138858)
										{
											goto IL_63;
										}
										goto IL_79C;
									}
									goto IL_19A;
									IL_79C:
									flag = false;
									if (92084 - 402427 != -310343)
									{
										goto IL_63;
									}
								}
								else if (race == eRace.Plants)
								{
									if (108964 - 421844 == -312879)
									{
										goto IL_63;
									}
									flag = false;
									if (70249 - 440624 != -370375)
									{
										goto IL_63;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (246462 - 287078 != -40616)
									{
										goto IL_63;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_75A;
									}
									if (290663 - 411862 == -121198)
									{
										goto IL_63;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (271412 - 216041 != 55372)
										{
											goto IL_75A;
										}
										goto IL_63;
									}
									goto IL_19A;
									IL_75A:
									flag = false;
									if (57461 - 3705 == 53757)
									{
										goto IL_63;
									}
								}
								else if (race == eRace.Robots)
								{
									if (63392 - 158089 == -94696)
									{
										goto IL_63;
									}
									flag = true;
									if (51999 - 510266 != -458267)
									{
										goto IL_63;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (110461 - 319351 == -208889)
									{
										goto IL_63;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_14D;
									}
									if (262609 - 402246 != -139637)
									{
										goto IL_63;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_14D;
									}
									if (65591 - 244077 == -178485)
									{
										goto IL_63;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (190286 - 189218 != 1068)
										{
											goto IL_63;
										}
										goto IL_14D;
									}
									goto IL_19A;
									IL_14D:
									flag = false;
									if (242788 - 245715 == -2926)
									{
										goto IL_63;
									}
								}
								else if (race == eRace.Structure)
								{
									if (44052 - 364491 != -320439)
									{
										goto IL_63;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (239351 - 194110 == 45242)
										{
											goto IL_63;
										}
										flag = false;
										if (222608 - 320432 != -97824)
										{
											goto IL_63;
										}
									}
								}
								IL_19A:
								if (flag)
								{
									if (273878 - 583780 == -309901)
									{
										goto IL_63;
									}
									if (characterControl.hp > 0)
									{
										if (43774 - 233280 != -189506)
										{
											goto IL_63;
										}
										if (characterControl.recieveTarget)
										{
											if (103064 - 391482 == -288417)
											{
												goto IL_63;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (189468 - 227423 != -37955)
												{
													goto IL_63;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (299567 - 110931 != 188636)
													{
														goto IL_63;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (170023 - 234235 == -64211)
													{
														goto IL_63;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (42697 - 13205 != 29492)
														{
															goto IL_63;
														}
														this.zPsISQ6TRu.myAttackTarget = gameObject;
														if (140351 - 95440 != 44911)
														{
															goto IL_63;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (278303 - 435841 == -157537)
														{
															goto IL_63;
														}
														this.zPsISQ6TRu.addHate(characterControl.ActorNr, 5);
														if (198962 - 391286 == -192323)
														{
															goto IL_63;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (7172 - 559115 != -551943)
														{
															goto IL_63;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (30231 - 543825 != -513594)
														{
															goto IL_63;
														}
														if (num < (float)60)
														{
															if (140725 - 4506 == 136220)
															{
																goto IL_63;
															}
															if (characterControl.hp > 0)
															{
																if (177431 - 151721 != 25710)
																{
																	goto IL_63;
																}
																this.zPsISQ6TRu.myAttackTarget = gameObject;
																if (23883 - 467798 == -443914)
																{
																	goto IL_63;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (215240 - 396903 == -181662)
																{
																	goto IL_63;
																}
																this.zPsISQ6TRu.addHate(characterControl.ActorNr, 5);
																if (41449 - 478106 != -436657)
																{
																	goto IL_63;
																}
															}
														}
													}
													if (this.zPsISQ6TRu.myAttackTarget)
													{
														if (144101 - 405319 != -261218)
														{
															goto IL_63;
														}
														this.zPsISQ6TRu.isAlert = true;
														if (161918 - 174682 != -12764)
														{
															goto IL_63;
														}
														this.mLoI0fd9mv = Time.time;
														if (269550 - 112942 != 156608)
														{
															goto IL_63;
														}
													}
												}
											}
										}
									}
								}
							}
							if (122016 - 408312 != -286295)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x0015A91C File Offset: 0x00158B1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x0015A920 File Offset: 0x00158B20
	internal static bool X4FKpeykSDntN3j1r8M()
	{
		return true;
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x0015A924 File Offset: 0x00158B24
	internal static bool BZnD2IyG4ttjpL9wSMn()
	{
		return false;
	}

	// Token: 0x04000BCD RID: 3021
	private CharacterControl zPsISQ6TRu;

	// Token: 0x04000BCE RID: 3022
	private WormBug XkZIB9QHVP;

	// Token: 0x04000BCF RID: 3023
	public string AI_state;

	// Token: 0x04000BD0 RID: 3024
	private float mLoI0fd9mv;

	// Token: 0x04000BD1 RID: 3025
	private float U5mI8qqRJN;

	// Token: 0x04000BD2 RID: 3026
	private float HVqIifwYy8;
}
