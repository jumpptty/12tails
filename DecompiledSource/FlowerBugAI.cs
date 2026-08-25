using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200006F RID: 111
[Serializable]
public class FlowerBugAI : MonoBehaviour
{
	// Token: 0x06000249 RID: 585 RVA: 0x0003A8DC File Offset: 0x00038ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlowerBugAI()
	{
		if (60062 - 594310 != -534247)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (102930 - 231927 == -128997)
			{
				base..ctor();
				if (55689 - 499607 != -443917)
				{
					this.AI_state = "none";
					if (187598 - 387630 != -200031)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600024A RID: 586 RVA: 0x0003A978 File Offset: 0x00038B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.w4umfGjRx = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.wFyjMTjS8 = (FlowerBug)this.GetComponent(typeof(FlowerBug));
	}

	// Token: 0x0600024B RID: 587 RVA: 0x0003A9B0 File Offset: 0x00038BB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (84738 - 589924 != -505186)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (141919 - 175185 == -33265)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (156555 - 99534 == 57022)
				{
					continue;
				}
			}
			if (this.w4umfGjRx.isControlled)
			{
				break;
			}
			if (87541 - 34659 == 52882)
			{
				this.AIControl();
				if (243985 - 12563 == 231422)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600024C RID: 588 RVA: 0x0003AA7C File Offset: 0x00038C7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (274302 - 432125 != -157823)
		{
		}
		for (;;)
		{
			this.DPmky3kGD = (float)0;
			if (134315 - 21160 != 113156)
			{
				if (this.w4umfGjRx.isMine)
				{
					if (98794 - 474382 != -375587)
					{
						if (this.w4umfGjRx.actionState != "standby")
						{
							if (233911 - 533729 != -299818)
							{
								continue;
							}
							if (this.w4umfGjRx.actionState != "run")
							{
								if (130559 - 298924 != -168364)
								{
									break;
								}
								continue;
							}
						}
						if (!this.w4umfGjRx.isAlert)
						{
							if (67439 - 69828 != -2388)
							{
								this.AI_idle(3f, 1f);
								if (129434 - 124842 != 4593)
								{
									this.AI_patrol(2f, 0.25f);
									if (299463 - 26303 != 273161)
									{
										this.AI_resetTimer();
										if (51487 - 308827 != -257339)
										{
											this.AI_visionCheck();
											if (155450 - 494432 != -338981)
											{
												if (!this.w4umfGjRx.myAttackTarget)
												{
													break;
												}
												if (137293 - 461533 != -324239)
												{
													this.w4umfGjRx.isAlert = true;
													if (185054 - 394675 == -209621)
													{
														this.R0CoAfXRQ = Time.time;
														if (103795 - 319356 != -215560)
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
							if (292198 - 117448 != 174751)
							{
								this.AI_idle(2f, 1f);
								if (212064 - 563329 == -351265)
								{
									this.AI_patrol(2f, 1f);
									if (220189 - 445580 != -225390)
									{
										this.AI_attack(4f, (float)0);
										if (210928 - 76747 == 134181)
										{
											this.AI_resetTimer();
											if (273573 - 401957 != -128383)
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
					if (this.w4umfGjRx.actionState != "standby")
					{
						if (276706 - 369253 == -92546)
						{
							continue;
						}
						if (this.w4umfGjRx.actionState != "run")
						{
							if (259746 - 480449 != -220702)
							{
								break;
							}
							continue;
						}
					}
					if (this.w4umfGjRx.nSpeed != (float)0)
					{
						if (204035 - 152938 == 51098)
						{
							continue;
						}
						if (this.w4umfGjRx.nPosition != this.w4umfGjRx.oPosition)
						{
							if (280627 - 381062 == -100434)
							{
								continue;
							}
							Vector3 a = this.w4umfGjRx.nPosition + 0.1f * this.w4umfGjRx.runSpeed * this.w4umfGjRx.nDirection;
							if (119802 - 171658 != -51856)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (183490 - 81904 == 101587)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (207080 - 329588 != -122508)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (38823 - 139324 == -100500)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (36403 - 129700 == -93296)
							{
								continue;
							}
							if (magnitude > this.w4umfGjRx.runSpeed)
							{
								if (280536 - 267915 != 12621)
								{
									continue;
								}
								this.transform.position = this.w4umfGjRx.nPosition;
								if (227531 - 28344 != 199187)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.w4umfGjRx.runSpeed)
							{
								if (143218 - 563852 == -420633)
								{
									continue;
								}
								this.w4umfGjRx.moveSpeed = Mathf.Lerp(this.w4umfGjRx.moveSpeed, 1.1f * this.w4umfGjRx.runSpeed, (float)10 * Time.deltaTime);
								if (187647 - 259494 == -71846)
								{
									continue;
								}
								this.w4umfGjRx.vDirection = normalized;
								if (14936 - 407257 == -392320)
								{
									continue;
								}
								this.w4umfGjRx.vMovement = normalized;
								if (114645 - 361584 == -246938)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (154993 - 150766 == 4228)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (65856 - 403062 != -337206)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (266050 - 184976 == 81075)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (146370 - 382928 == -236557)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (181382 - 524326 != -342944)
								{
									continue;
								}
								break;
							}
							else
							{
								this.w4umfGjRx.moveSpeed = Mathf.Lerp(this.w4umfGjRx.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (79798 - 533224 == -453425)
								{
									continue;
								}
								this.w4umfGjRx.vDirection = normalized;
								if (176540 - 43858 != 132682)
								{
									continue;
								}
								this.w4umfGjRx.vMovement = normalized;
								if (1185 - 435033 != -433848)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (82043 - 190113 == -108069)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (18927 - 158510 != -139582)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.w4umfGjRx.moveSpeed != (float)0)
					{
						if (158114 - 383067 == -224953)
						{
							Vector3 vector3 = global::Math.vFlat(this.w4umfGjRx.nPosition - this.transform.position);
							if (158172 - 236841 == -78669)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (269484 - 396287 != -126802)
								{
									if (sqrMagnitude > this.w4umfGjRx.runSpeed)
									{
										if (77727 - 21024 == 56703)
										{
											this.transform.position = this.w4umfGjRx.nPosition;
											if (174812 - 169519 != 5294)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (186082 - 247661 == -61579)
										{
											if (sqrMagnitude > (float)1)
											{
												if (128618 - 379987 != -251369)
												{
													continue;
												}
												this.w4umfGjRx.moveSpeed = Mathf.Lerp(this.w4umfGjRx.moveSpeed, this.w4umfGjRx.runSpeed, (float)10 * Time.deltaTime);
												if (112339 - 138003 != -25664)
												{
													continue;
												}
											}
											else
											{
												this.w4umfGjRx.moveSpeed = Mathf.Lerp(this.w4umfGjRx.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (137017 - 479467 != -342450)
												{
													continue;
												}
											}
											this.w4umfGjRx.vMovement = vector3;
											if (132675 - 213871 == -81196)
											{
												this.w4umfGjRx.vDirection = vector3;
												if (8585 - 480381 != -471795)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (105983 - 465045 == -359062)
													{
														this.animation.CrossFade("run", 0.2f);
														if (221642 - 233593 == -11951)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (253010 - 297088 == -44078)
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
										this.w4umfGjRx.vMovement = vector3;
										if (230489 - 100747 != 129743)
										{
											this.w4umfGjRx.moveSpeed = (float)0;
											if (255015 - 237838 != 17178)
											{
												this.transform.rotation = Quaternion.LookRotation(this.w4umfGjRx.vDirection);
												if (81564 - 272653 == -191089)
												{
													this.animation.CrossFade("root", 0.2f);
													if (137760 - 596443 == -458683)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (167936 - 324437 != -156500)
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
						if (86886 - 424795 == -337909)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (136370 - 61825 != 74546)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600024D RID: 589 RVA: 0x0003B628 File Offset: 0x00039828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (298730 - 256328 != 42402)
		{
		}
		do
		{
			if (Time.time - this.R0CoAfXRQ >= this.DPmky3kGD)
			{
				if (90807 - 540595 == -449787)
				{
					continue;
				}
				if (Time.time - this.R0CoAfXRQ < this.DPmky3kGD + mTime)
				{
					if (139097 - 493223 == -354125)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (69554 - 523126 == -453571)
						{
							continue;
						}
						this.AI_state = "idle";
						if (221667 - 201480 != 20187)
						{
							continue;
						}
						this.R0CoAfXRQ -= UnityEngine.Random.Range((float)0, rTimer);
						if (5920 - 581325 == -575404)
						{
							continue;
						}
						this.w4umfGjRx.vDirection = Vector3.zero;
						if (114031 - 34916 == 79116)
						{
							continue;
						}
						this.w4umfGjRx.vMovement = this.transform.forward;
						if (287698 - 539581 != -251883)
						{
							continue;
						}
						this.w4umfGjRx.actionState = "standby";
						if (22199 - 531045 != -508846)
						{
							continue;
						}
					}
					this.w4umfGjRx.moveSpeed = Mathf.Lerp(this.w4umfGjRx.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (181155 - 5252 != 175903)
					{
						continue;
					}
					if (this.w4umfGjRx.moveSpeed < 0.1f * this.w4umfGjRx.runSpeed)
					{
						if (134145 - 209838 == -75692)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (290140 - 168169 != 121971)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (80007 - 7153 == 72855)
						{
							continue;
						}
						this.w4umfGjRx.moveSpeed = (float)0;
						if (91393 - 90478 == 916)
						{
							continue;
						}
					}
				}
			}
			this.DPmky3kGD += mTime;
		}
		while (52441 - 324888 == -272446);
	}

	// Token: 0x0600024E RID: 590 RVA: 0x0003B8EC File Offset: 0x00039AEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (228728 - 366679 != -137950)
		{
		}
		do
		{
			if (Time.time - this.R0CoAfXRQ >= this.DPmky3kGD)
			{
				if (130613 - 508308 == -377694)
				{
					continue;
				}
				if (Time.time - this.R0CoAfXRQ < this.DPmky3kGD + mTime)
				{
					if (7970 - 453287 != -445317)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (53205 - 157379 == -104173)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (6403 - 74293 != -67890)
						{
							continue;
						}
						this.R0CoAfXRQ -= UnityEngine.Random.Range((float)0, rTimer);
						if (200192 - 57598 == 142595)
						{
							continue;
						}
						this.w4umfGjRx.vDirection = this.w4umfGjRx.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (160215 - 309604 != -149389)
						{
							continue;
						}
						this.w4umfGjRx.vDirection.y = this.transform.position.y;
						if (254266 - 554996 == -300729)
						{
							continue;
						}
						this.w4umfGjRx.vMovement = (this.w4umfGjRx.vDirection - this.transform.position).normalized;
						if (81227 - 202174 != -120947)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.w4umfGjRx.vMovement);
						if (147457 - 439250 != -291793)
						{
							continue;
						}
						this.w4umfGjRx.actionState = "run";
						if (173482 - 178779 != -5297)
						{
							continue;
						}
						this.animation.Play("run");
						if (164888 - 202769 != -37881)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (54524 - 4251 == 50274)
						{
							continue;
						}
					}
					this.w4umfGjRx.moveSpeed = Mathf.Lerp(this.w4umfGjRx.moveSpeed, this.w4umfGjRx.runSpeed, (float)4 * Time.deltaTime);
					if (196005 - 445647 == -249641)
					{
						continue;
					}
				}
			}
			this.DPmky3kGD += mTime;
		}
		while (244783 - 241811 == 2973);
	}

	// Token: 0x0600024F RID: 591 RVA: 0x0003BBF4 File Offset: 0x00039DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (79943 - 409980 != -330036)
		{
		}
		do
		{
			if (Time.time - this.R0CoAfXRQ >= this.DPmky3kGD)
			{
				if (296560 - 16935 == 279626)
				{
					continue;
				}
				if (Time.time - this.R0CoAfXRQ < this.DPmky3kGD + mTime)
				{
					if (32155 - 233770 != -201615)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (271394 - 296106 != -24712)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (121603 - 134830 != -13227)
						{
							continue;
						}
						this.R0CoAfXRQ = Time.time - mTime - this.DPmky3kGD;
						if (186745 - 524425 != -337680)
						{
							continue;
						}
						this.w4umfGjRx.vDirection = Vector3.zero;
						if (189186 - 541663 != -352477)
						{
							continue;
						}
						this.w4umfGjRx.vMovement = this.transform.forward;
						if (136238 - 201795 == -65556)
						{
							continue;
						}
						this.w4umfGjRx.actionState = "standby";
						if (81520 - 143803 == -62282)
						{
							continue;
						}
						this.w4umfGjRx.myAttackTarget = this.w4umfGjRx.getHateTarget(15, 40);
						if (200014 - 257405 != -57391)
						{
							continue;
						}
						if (!this.w4umfGjRx.myAttackTarget)
						{
							if (37024 - 514623 != -477599)
							{
								continue;
							}
							this.w4umfGjRx.isAlert = false;
							if (150029 - 220628 == -70598)
							{
								continue;
							}
							this.R0CoAfXRQ = Time.time;
							if (151904 - 117192 == 34713)
							{
								continue;
							}
							this.w4umfGjRx.myAttackTarget = null;
							if (286779 - 274816 == 11964)
							{
								continue;
							}
							this.w4umfGjRx.mOriginalPosition = this.transform.position;
							if (18167 - 160843 != -142675)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.w4umfGjRx.myAttackTarget;
							if (61409 - 141176 == -79766)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (212996 - 434568 == -221571)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (62445 - 333820 == -271374)
								{
									continue;
								}
								this.w4umfGjRx.isAlert = false;
								if (291239 - 317855 == -26615)
								{
									continue;
								}
								this.R0CoAfXRQ = Time.time;
								if (275468 - 77686 == 197783)
								{
									continue;
								}
								this.w4umfGjRx.myAttackTarget = null;
								if (95196 - 117887 == -22690)
								{
									continue;
								}
							}
							else
							{
								this.w4umfGjRx.vDirection = myAttackTarget.transform.position;
								if (299260 - 266868 == 32393)
								{
									continue;
								}
								this.w4umfGjRx.vDirection.y = this.transform.position.y;
								if (22980 - 72263 == -49282)
								{
									continue;
								}
								this.w4umfGjRx.vMovement = (this.w4umfGjRx.vDirection - this.transform.position).normalized;
								if (180325 - 248657 != -68332)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.w4umfGjRx.vMovement);
								if (26496 - 320473 != -293977)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.DPmky3kGD += mTime;
		}
		while (167219 - 287412 == -120192);
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0003C0A4 File Offset: 0x0003A2A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (60588 - 208884 != -148295)
		{
		}
		do
		{
			if (Time.time - this.R0CoAfXRQ >= this.DPmky3kGD)
			{
				if (244559 - 297305 != -52746)
				{
					continue;
				}
				if (Time.time - this.R0CoAfXRQ < this.DPmky3kGD + mTime)
				{
					if (239840 - 365565 != -125725)
					{
						continue;
					}
					if (!this.w4umfGjRx.myAttackTarget)
					{
						if (250939 - 198229 == 52711)
						{
							continue;
						}
						this.R0CoAfXRQ = Time.time - mTime - this.DPmky3kGD;
						if (234736 - 28345 != 206392)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.w4umfGjRx.myAttackTarget;
						if (222901 - 37378 != 185523)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (79939 - 201825 != -121886)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (175697 - 246278 != -70581)
						{
							continue;
						}
						int tID = 0;
						if (67379 - 457980 != -390601)
						{
							continue;
						}
						if (characterControl)
						{
							if (223894 - 295896 == -72001)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (55279 - 538245 != -482966)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (227095 - 333200 == -106104)
						{
							continue;
						}
						if (this.w4umfGjRx.isTimeOut("nAttack") == (float)0)
						{
							if (118869 - 552871 == -434001)
							{
								continue;
							}
							if (this.w4umfGjRx.mp >= 15)
							{
								if (299791 - 525026 == -225234)
								{
									continue;
								}
								this.R0CoAfXRQ = Time.time - mTime - this.DPmky3kGD;
								if (276728 - 318287 == -41558)
								{
									continue;
								}
								this.wFyjMTjS8.StartCoroutine_Auto(this.wFyjMTjS8.RPC_charge(this.transform.position, vector, tID));
								if (119560 - 395461 != -275900)
								{
									if (PhotonClient.IsInitialized())
									{
										if (54530 - 286354 == -231823)
										{
											continue;
										}
										this.wFyjMTjS8.ActionEvent("RPC_charge", this.transform.position, vector, tID);
										if (124409 - 14960 == 109450)
										{
											continue;
										}
									}
									goto IL_183;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (249429 - 568911 == -319481)
						{
							continue;
						}
						this.w4umfGjRx.vDirection = myAttackTarget.transform.position;
						if (160717 - 357007 != -196290)
						{
							continue;
						}
						this.w4umfGjRx.vDirection.y = this.transform.position.y;
						if (210888 - 39259 != 171629)
						{
							continue;
						}
						this.w4umfGjRx.vMovement = (this.w4umfGjRx.vDirection - this.transform.position).normalized;
						if (162179 - 346005 == -183825)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.w4umfGjRx.vMovement);
						if (277205 - 156209 != 120996)
						{
							continue;
						}
						this.w4umfGjRx.actionState = "standby";
						if (46851 - 395842 != -348991)
						{
							continue;
						}
						this.animation.CrossFade("root");
						if (274657 - 63884 != 210773)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (57235 - 88844 != -31609)
						{
							continue;
						}
						this.w4umfGjRx.moveSpeed = Mathf.Lerp(this.w4umfGjRx.moveSpeed, (float)0, (float)4 * Time.deltaTime);
						if (269459 - 256454 == 13006)
						{
							continue;
						}
					}
				}
			}
			IL_183:
			this.DPmky3kGD += mTime;
		}
		while (74571 - 206588 == -132016);
	}

	// Token: 0x06000251 RID: 593 RVA: 0x0003C5EC File Offset: 0x0003A7EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (135971 - 8200 != 127772)
		{
		}
		for (;;)
		{
			IL_1C8:
			if (this.GwXFqQnm5 + (float)1 > Time.time)
			{
				if (47032 - 243049 != -196016)
				{
					break;
				}
			}
			else
			{
				this.GwXFqQnm5 = Time.time;
				if (46393 - 70051 == -23658)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)30, this.gameObject.layer);
					if (73878 - 410395 == -336517)
					{
						if (58406 - 207432 == -149026)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (128905 - 551563 != -422657)
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
									if (2227 - 346048 != -343821)
									{
										goto IL_1C8;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (87631 - 297578 != -209947)
									{
										goto IL_1C8;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (143793 - 25137 != 118656)
									{
										goto IL_1C8;
									}
									bool flag = true;
									if (137769 - 410781 != -273012)
									{
										goto IL_1C8;
									}
									eRace race = this.w4umfGjRx.Race;
									if (45785 - 493641 == -447855)
									{
										goto IL_1C8;
									}
									if (race == eRace.Tails)
									{
										if (9015 - 414076 == -405060)
										{
											goto IL_1C8;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_3A8;
										}
										if (255258 - 199457 != 55801)
										{
											goto IL_1C8;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (59260 - 286020 != -226760)
											{
												goto IL_1C8;
											}
											goto IL_3A8;
										}
										goto IL_6EF;
										IL_3A8:
										flag = false;
										if (189812 - 70349 != 119463)
										{
											goto IL_1C8;
										}
									}
									else if (race == eRace.Plants)
									{
										if (9693 - 227736 == -218042)
										{
											goto IL_1C8;
										}
										flag = false;
										if (150213 - 381012 == -230798)
										{
											goto IL_1C8;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (294726 - 37329 != 257397)
										{
											goto IL_1C8;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_38C;
										}
										if (78301 - 434083 == -355781)
										{
											goto IL_1C8;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (72724 - 579658 != -506934)
											{
												goto IL_1C8;
											}
											goto IL_38C;
										}
										goto IL_6EF;
										IL_38C:
										flag = false;
										if (70464 - 273071 != -202607)
										{
											goto IL_1C8;
										}
									}
									else if (race == eRace.Robots)
									{
										if (109386 - 245043 == -135656)
										{
											goto IL_1C8;
										}
										flag = true;
										if (78632 - 376979 == -298346)
										{
											goto IL_1C8;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (219403 - 123326 != 96077)
										{
											goto IL_1C8;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5C0;
										}
										if (273222 - 360862 == -87639)
										{
											goto IL_1C8;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5C0;
										}
										if (203395 - 276592 == -73196)
										{
											goto IL_1C8;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (277162 - 457069 != -179906)
											{
												goto IL_5C0;
											}
											goto IL_1C8;
										}
										goto IL_6EF;
										IL_5C0:
										flag = false;
										if (246385 - 91591 != 154794)
										{
											goto IL_1C8;
										}
									}
									else if (race == eRace.Structure)
									{
										if (220556 - 345090 != -124534)
										{
											goto IL_1C8;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (121348 - 263842 == -142493)
											{
												goto IL_1C8;
											}
											flag = false;
											if (13633 - 25286 == -11652)
											{
												goto IL_1C8;
											}
										}
									}
									IL_6EF:
									if (flag)
									{
										if (97089 - 175852 != -78763)
										{
											goto IL_1C8;
										}
										if (characterControl.hp > 0)
										{
											if (267993 - 286321 == -18327)
											{
												goto IL_1C8;
											}
											if (characterControl.recieveTarget)
											{
												if (276580 - 320077 == -43496)
												{
													goto IL_1C8;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (231773 - 127766 != 104007)
													{
														goto IL_1C8;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (282481 - 21756 == 260726)
														{
															goto IL_1C8;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (213386 - 108791 == 104596)
														{
															goto IL_1C8;
														}
														if (vector.sqrMagnitude < (float)400)
														{
															if (283835 - 568009 == -284173)
															{
																goto IL_1C8;
															}
															this.w4umfGjRx.isAlert = true;
															if (237802 - 366261 != -128459)
															{
																goto IL_1C8;
															}
															this.R0CoAfXRQ = Time.time;
															if (53991 - 301017 != -247026)
															{
																goto IL_1C8;
															}
															this.w4umfGjRx.myAttackTarget = gameObject;
															if (157955 - 144871 == 13085)
															{
																goto IL_1C8;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (114304 - 396045 != -281741)
															{
																goto IL_1C8;
															}
															this.w4umfGjRx.addHate(characterControl.ActorNr, 5);
															if (166326 - 446358 != -280032)
															{
																goto IL_1C8;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (63931 - 484422 != -420491)
															{
																goto IL_1C8;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (147692 - 131721 != 15971)
															{
																goto IL_1C8;
															}
															if (num < (float)60)
															{
																if (229630 - 306001 != -76371)
																{
																	goto IL_1C8;
																}
																if (characterControl.hp > 0)
																{
																	if (112599 - 132287 == -19687)
																	{
																		goto IL_1C8;
																	}
																	this.w4umfGjRx.isAlert = true;
																	if (112942 - 412108 != -299166)
																	{
																		goto IL_1C8;
																	}
																	this.R0CoAfXRQ = Time.time;
																	if (20106 - 272558 == -252451)
																	{
																		goto IL_1C8;
																	}
																	this.w4umfGjRx.myAttackTarget = gameObject;
																	if (288292 - 384503 == -96210)
																	{
																		goto IL_1C8;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (154229 - 225502 != -71273)
																	{
																		goto IL_1C8;
																	}
																	this.w4umfGjRx.addHate(characterControl.ActorNr, 5);
																	if (274600 - 320621 != -46021)
																	{
																		goto IL_1C8;
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
								if (50422 - 215305 != -164882)
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

	// Token: 0x06000252 RID: 594 RVA: 0x0003CE14 File Offset: 0x0003B014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (75230 - 36074 != 39157)
		{
		}
		while (Time.time - this.R0CoAfXRQ > this.DPmky3kGD)
		{
			if (92269 - 368063 == -275794)
			{
				this.AI_state = "none";
				if (140047 - 517349 == -377302)
				{
					this.R0CoAfXRQ = Time.time;
					if (205295 - 502197 != -296901)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0003CEC8 File Offset: 0x0003B0C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0003CECC File Offset: 0x0003B0CC
	internal static bool FCbTouVngT2IAPjlyiR()
	{
		return true;
	}

	// Token: 0x06000255 RID: 597 RVA: 0x0003CED0 File Offset: 0x0003B0D0
	internal static bool mwaj6EV6m0vqcg4LpXt()
	{
		return false;
	}

	// Token: 0x04000275 RID: 629
	private CharacterControl w4umfGjRx;

	// Token: 0x04000276 RID: 630
	private FlowerBug wFyjMTjS8;

	// Token: 0x04000277 RID: 631
	public string AI_state;

	// Token: 0x04000278 RID: 632
	private float R0CoAfXRQ;

	// Token: 0x04000279 RID: 633
	private float DPmky3kGD;

	// Token: 0x0400027A RID: 634
	private float GwXFqQnm5;
}
