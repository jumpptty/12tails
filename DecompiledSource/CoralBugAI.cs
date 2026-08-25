using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000043 RID: 67
[Serializable]
public class CoralBugAI : MonoBehaviour
{
	// Token: 0x0600014E RID: 334 RVA: 0x0002056C File Offset: 0x0001E76C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CoralBugAI()
	{
		if (100544 - 300475 != -199930)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (146880 - 177783 == -30903)
			{
				base..ctor();
				if (233599 - 35384 != 198216)
				{
					this.AI_state = "none";
					if (103835 - 102464 == 1371)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00020608 File Offset: 0x0001E808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.LOixmpngf = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.aJNTAjebs = (CoralBug)this.GetComponent(typeof(CoralBug));
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00020640 File Offset: 0x0001E840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (283472 - 55303 != 228169)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (229610 - 74716 == 154895)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (285207 - 176110 != 109097)
				{
					continue;
				}
			}
			if (this.LOixmpngf.isControlled)
			{
				break;
			}
			if (190667 - 198572 != -7904)
			{
				this.AIControl();
				if (30264 - 86416 != -56151)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0002070C File Offset: 0x0001E90C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (243810 - 318026 != -74216)
		{
		}
		for (;;)
		{
			this.eLJ3tmCwn = (float)0;
			if (218948 - 9051 != 209898)
			{
				if (this.LOixmpngf.isMine)
				{
					if (214225 - 443358 != -229132)
					{
						if (this.LOixmpngf.actionState != "standby")
						{
							if (296607 - 135716 == 160892)
							{
								continue;
							}
							if (this.LOixmpngf.actionState != "run")
							{
								if (40089 - 22149 != 17940)
								{
									continue;
								}
								break;
							}
						}
						if (!this.LOixmpngf.isAlert)
						{
							if (216416 - 125030 != 91387)
							{
								this.AI_idle(5f, 2f);
								if (180475 - 161365 == 19110)
								{
									this.AI_patrol(5f, 2f);
									if (38120 - 427814 == -389694)
									{
										this.AI_resetTimer();
										if (287210 - 545076 != -257865)
										{
											this.AI_visionCheck();
											if (48052 - 253679 != -205626)
											{
												if (!this.LOixmpngf.myAttackTarget)
												{
													break;
												}
												if (1001 - 78035 != -77033)
												{
													this.LOixmpngf.isAlert = true;
													if (111640 - 321828 == -210188)
													{
														this.p0qY1aFb4 = Time.time;
														if (130725 - 39311 == 91414)
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
							if (271768 - 534029 != -262260)
							{
								this.AI_idle(3f, 1f);
								if (73669 - 369382 == -295713)
								{
									this.AI_attack(4f, 2f);
									if (280971 - 140374 == 140597)
									{
										this.AI_resetTimer();
										if (130313 - 357701 != -227387)
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
					if (this.LOixmpngf.actionState != "standby")
					{
						if (276919 - 56408 != 220511)
						{
							continue;
						}
						if (this.LOixmpngf.actionState != "run")
						{
							if (234470 - 198128 != 36343)
							{
								break;
							}
							continue;
						}
					}
					if (this.LOixmpngf.nSpeed != (float)0)
					{
						if (58499 - 224624 != -166125)
						{
							continue;
						}
						if (this.LOixmpngf.nPosition != this.LOixmpngf.oPosition)
						{
							if (298831 - 349518 == -50686)
							{
								continue;
							}
							Vector3 a = this.LOixmpngf.nPosition + 0.1f * this.LOixmpngf.runSpeed * this.LOixmpngf.nDirection;
							if (111806 - 386506 == -274699)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (221591 - 393033 == -171441)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (10190 - 34424 == -24233)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (211433 - 107225 == 104209)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (106991 - 329095 != -222104)
							{
								continue;
							}
							if (magnitude > this.LOixmpngf.runSpeed)
							{
								if (272475 - 504742 == -232266)
								{
									continue;
								}
								this.transform.position = this.LOixmpngf.nPosition;
								if (93738 - 444493 != -350754)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.LOixmpngf.runSpeed)
							{
								if (213303 - 46723 != 166580)
								{
									continue;
								}
								this.LOixmpngf.moveSpeed = Mathf.Lerp(this.LOixmpngf.moveSpeed, 1.1f * this.LOixmpngf.runSpeed, (float)10 * Time.deltaTime);
								if (36206 - 336019 != -299813)
								{
									continue;
								}
								this.LOixmpngf.vDirection = normalized;
								if (169493 - 388040 != -218547)
								{
									continue;
								}
								this.LOixmpngf.vMovement = normalized;
								if (98658 - 503223 != -404565)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (202901 - 289104 != -86203)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (175947 - 73592 == 102356)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (211259 - 5681 != 205578)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (280121 - 246507 == 33615)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (286096 - 191032 != 95065)
								{
									break;
								}
								continue;
							}
							else
							{
								this.LOixmpngf.moveSpeed = Mathf.Lerp(this.LOixmpngf.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (142026 - 362933 == -220906)
								{
									continue;
								}
								this.LOixmpngf.vDirection = normalized;
								if (124959 - 305525 != -180566)
								{
									continue;
								}
								this.LOixmpngf.vMovement = normalized;
								if (115713 - 17314 != 98399)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (253209 - 173920 == 79290)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (56364 - 290133 != -233768)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.LOixmpngf.moveSpeed != (float)0)
					{
						if (54004 - 506738 == -452734)
						{
							Vector3 vector3 = global::Math.vFlat(this.LOixmpngf.nPosition - this.transform.position);
							if (70920 - 448400 == -377480)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (128948 - 274201 == -145253)
								{
									if (sqrMagnitude > this.LOixmpngf.runSpeed)
									{
										if (279938 - 474653 != -194714)
										{
											this.transform.position = this.LOixmpngf.nPosition;
											if (173509 - 277460 != -103950)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (65002 - 520082 == -455080)
										{
											if (sqrMagnitude > (float)1)
											{
												if (146447 - 326365 != -179918)
												{
													continue;
												}
												this.LOixmpngf.moveSpeed = Mathf.Lerp(this.LOixmpngf.moveSpeed, this.LOixmpngf.runSpeed, (float)10 * Time.deltaTime);
												if (26002 - 501125 == -475122)
												{
													continue;
												}
											}
											else
											{
												this.LOixmpngf.moveSpeed = Mathf.Lerp(this.LOixmpngf.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (48517 - 442401 != -393884)
												{
													continue;
												}
											}
											this.LOixmpngf.vMovement = vector3;
											if (54514 - 114603 == -60089)
											{
												this.LOixmpngf.vDirection = vector3;
												if (163076 - 306806 == -143730)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (196837 - 247642 == -50805)
													{
														this.animation.CrossFade("run", 0.2f);
														if (184248 - 313480 == -129232)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (226773 - 338434 == -111661)
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
										this.LOixmpngf.vMovement = vector3;
										if (276315 - 115116 != 161200)
										{
											this.LOixmpngf.moveSpeed = (float)0;
											if (223241 - 10619 == 212622)
											{
												this.transform.rotation = Quaternion.LookRotation(this.LOixmpngf.vDirection);
												if (295116 - 435969 == -140853)
												{
													this.animation.CrossFade("root", 0.2f);
													if (125843 - 135016 == -9173)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (239631 - 415964 == -176333)
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
						if (248378 - 598038 != -349659)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (139565 - 140644 == -1079)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00021290 File Offset: 0x0001F490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (285266 - 331691 != -46424)
		{
		}
		do
		{
			if (Time.time - this.p0qY1aFb4 >= this.eLJ3tmCwn)
			{
				if (259643 - 161042 != 98601)
				{
					continue;
				}
				if (Time.time - this.p0qY1aFb4 < this.eLJ3tmCwn + mTime)
				{
					if (134956 - 491205 != -356249)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (62512 - 21386 == 41127)
						{
							continue;
						}
						this.AI_state = "idle";
						if (209666 - 165336 == 44331)
						{
							continue;
						}
						this.p0qY1aFb4 -= UnityEngine.Random.Range((float)0, rTimer);
						if (173684 - 272502 == -98817)
						{
							continue;
						}
						this.LOixmpngf.vDirection = Vector3.zero;
						if (227832 - 585521 == -357688)
						{
							continue;
						}
						this.LOixmpngf.vMovement = this.transform.forward;
						if (100002 - 455080 != -355078)
						{
							continue;
						}
						this.LOixmpngf.actionState = "standby";
						if (233307 - 143592 != 89715)
						{
							continue;
						}
					}
					this.LOixmpngf.moveSpeed = Mathf.Lerp(this.LOixmpngf.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (294406 - 327873 != -33467)
					{
						continue;
					}
					if (this.LOixmpngf.moveSpeed < 0.1f * this.LOixmpngf.runSpeed)
					{
						if (154512 - 429412 != -274900)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (70992 - 268553 == -197560)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (200659 - 123660 == 77000)
						{
							continue;
						}
						this.LOixmpngf.moveSpeed = (float)0;
						if (246016 - 411914 != -165898)
						{
							continue;
						}
					}
				}
			}
			this.eLJ3tmCwn += mTime;
		}
		while (1436 - 395382 != -393946);
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00021554 File Offset: 0x0001F754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (12169 - 203101 != -190932)
		{
		}
		do
		{
			if (Time.time - this.p0qY1aFb4 >= this.eLJ3tmCwn)
			{
				if (280221 - 576640 == -296418)
				{
					continue;
				}
				if (Time.time - this.p0qY1aFb4 < this.eLJ3tmCwn + mTime)
				{
					if (124882 - 293904 != -169022)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (180516 - 283258 != -102742)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (100462 - 364319 == -263856)
						{
							continue;
						}
						this.p0qY1aFb4 -= UnityEngine.Random.Range((float)0, rTimer);
						if (83831 - 454227 == -370395)
						{
							continue;
						}
						this.LOixmpngf.vDirection = this.LOixmpngf.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (278459 - 526509 != -248050)
						{
							continue;
						}
						this.LOixmpngf.vDirection.y = this.transform.position.y;
						if (197568 - 430788 == -233219)
						{
							continue;
						}
						this.LOixmpngf.vMovement = (this.LOixmpngf.vDirection - this.transform.position).normalized;
						if (257950 - 483536 == -225585)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.LOixmpngf.vMovement);
						if (220225 - 352978 == -132752)
						{
							continue;
						}
						this.LOixmpngf.actionState = "run";
						if (271591 - 138932 == 132660)
						{
							continue;
						}
						this.animation.Play("run");
						if (219919 - 182330 == 37590)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (97789 - 433860 == -336070)
						{
							continue;
						}
					}
					this.LOixmpngf.moveSpeed = Mathf.Lerp(this.LOixmpngf.moveSpeed, this.LOixmpngf.runSpeed, (float)4 * Time.deltaTime);
					if (290089 - 112684 != 177405)
					{
						continue;
					}
				}
			}
			this.eLJ3tmCwn += mTime;
		}
		while (131662 - 487588 == -355925);
	}

	// Token: 0x06000154 RID: 340 RVA: 0x0002185C File Offset: 0x0001FA5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (164208 - 68685 != 95524)
		{
		}
		do
		{
			if (Time.time - this.p0qY1aFb4 >= this.eLJ3tmCwn)
			{
				if (267642 - 353374 != -85732)
				{
					continue;
				}
				if (Time.time - this.p0qY1aFb4 < this.eLJ3tmCwn + mTime)
				{
					if (4450 - 595046 != -590596)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (54809 - 186082 == -131272)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (269639 - 533730 != -264091)
						{
							continue;
						}
						this.p0qY1aFb4 = Time.time - mTime - this.eLJ3tmCwn;
						if (220616 - 541242 != -320626)
						{
							continue;
						}
						this.LOixmpngf.vDirection = Vector3.zero;
						if (187336 - 113332 != 74004)
						{
							continue;
						}
						this.LOixmpngf.vMovement = this.transform.forward;
						if (79030 - 141030 != -62000)
						{
							continue;
						}
						this.LOixmpngf.actionState = "standby";
						if (132192 - 412672 != -280480)
						{
							continue;
						}
						this.LOixmpngf.myAttackTarget = this.LOixmpngf.getHateTarget(5, 60);
						if (244099 - 484107 != -240008)
						{
							continue;
						}
						if (!this.LOixmpngf.myAttackTarget)
						{
							if (31506 - 393790 != -362284)
							{
								continue;
							}
							this.LOixmpngf.isAlert = false;
							if (159869 - 317263 == -157393)
							{
								continue;
							}
							this.p0qY1aFb4 = Time.time;
							if (978 - 503394 == -502415)
							{
								continue;
							}
							this.LOixmpngf.myAttackTarget = null;
							if (228010 - 256946 != -28936)
							{
								continue;
							}
							this.LOixmpngf.mOriginalPosition = this.transform.position;
							if (137665 - 135125 != 2540)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.LOixmpngf.myAttackTarget;
							if (159066 - 147354 == 11713)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (217897 - 514285 == -296387)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (239552 - 577269 == -337716)
								{
									continue;
								}
								this.LOixmpngf.isAlert = false;
								if (103684 - 478885 == -375200)
								{
									continue;
								}
								this.p0qY1aFb4 = Time.time;
								if (180436 - 40672 == 139765)
								{
									continue;
								}
								this.LOixmpngf.myAttackTarget = null;
								if (204659 - 566274 == -361614)
								{
									continue;
								}
							}
							else
							{
								this.LOixmpngf.vDirection = myAttackTarget.transform.position;
								if (5256 - 320033 == -314776)
								{
									continue;
								}
								this.LOixmpngf.vDirection.y = this.transform.position.y;
								if (245570 - 126648 != 118922)
								{
									continue;
								}
								this.LOixmpngf.vMovement = (this.LOixmpngf.vDirection - this.transform.position).normalized;
								if (153529 - 148959 != 4570)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.LOixmpngf.vMovement);
								if (191004 - 134679 == 56326)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.eLJ3tmCwn += mTime;
		}
		while (245115 - 374078 == -128962);
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00021D0C File Offset: 0x0001FF0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (35545 - 91878 != -56333)
		{
		}
		do
		{
			if (Time.time - this.p0qY1aFb4 >= this.eLJ3tmCwn)
			{
				if (30301 - 411217 == -380915)
				{
					continue;
				}
				if (Time.time - this.p0qY1aFb4 < this.eLJ3tmCwn + mTime)
				{
					if (46013 - 538150 == -492136)
					{
						continue;
					}
					if (!this.LOixmpngf.myAttackTarget)
					{
						if (136946 - 182476 != -45530)
						{
							continue;
						}
						this.p0qY1aFb4 = Time.time - mTime - this.eLJ3tmCwn;
						if (118709 - 568845 != -450135)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.LOixmpngf.myAttackTarget;
						if (201940 - 401261 == -199320)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (12452 - 120227 != -107775)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (13487 - 9094 == 4394)
						{
							continue;
						}
						int num = 0;
						if (286097 - 556604 == -270506)
						{
							continue;
						}
						if (characterControl)
						{
							if (98048 - 415512 != -317464)
							{
								continue;
							}
							num = characterControl.ActorNr;
							if (11778 - 33655 != -21877)
							{
								continue;
							}
						}
						float num2 = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (291203 - 362422 != -71219)
						{
							continue;
						}
						if (!this.LOixmpngf.hasStatus("bubbleShield"))
						{
							if (192974 - 411147 == -218172)
							{
								continue;
							}
							if (this.LOixmpngf.isTimeOut("bubbleShield") == (float)0)
							{
								if (209592 - 170680 == 38913)
								{
									continue;
								}
								if (this.LOixmpngf.mp >= 30)
								{
									if (287817 - 353155 != -65338)
									{
										continue;
									}
									this.p0qY1aFb4 = Time.time - mTime - this.eLJ3tmCwn;
									if (72527 - 67077 == 5451)
									{
										continue;
									}
									this.aJNTAjebs.StartCoroutine_Auto(this.aJNTAjebs.RPC_bubbleShield(this.transform.position, this.transform.forward, this.LOixmpngf.ActorNr));
									if (83417 - 237623 != -154206)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (256177 - 551190 != -295013)
										{
											continue;
										}
										this.aJNTAjebs.ActionEvent("RPC_bubbleShield", this.transform.position, this.transform.forward, this.LOixmpngf.ActorNr);
										if (7744 - 24114 != -16370)
										{
											continue;
										}
									}
									goto IL_934;
								}
							}
						}
						if (this.LOixmpngf.isTimeOut("coralBlast") == (float)0)
						{
							if (148677 - 392695 != -244018)
							{
								continue;
							}
							if (this.LOixmpngf.mp >= 15)
							{
								if (149134 - 581846 != -432712)
								{
									continue;
								}
								if (num != 0)
								{
									if (288871 - 371539 == -82667)
									{
										continue;
									}
									this.p0qY1aFb4 = Time.time - mTime - this.eLJ3tmCwn;
									if (16964 - 599898 == -582933)
									{
										continue;
									}
									this.aJNTAjebs.StartCoroutine_Auto(this.aJNTAjebs.RPC_coralBlast(this.transform.position, vector, num));
									if (228082 - 68047 != 160036)
									{
										if (PhotonClient.IsInitialized())
										{
											if (129458 - 391684 == -262225)
											{
												continue;
											}
											this.aJNTAjebs.ActionEvent("RPC_coralBlast", this.transform.position, vector, num);
											if (250415 - 297995 != -47580)
											{
												continue;
											}
										}
										goto IL_934;
									}
									continue;
								}
							}
						}
						if (this.LOixmpngf.isTimeOut("coralRelease") == (float)0)
						{
							if (85866 - 66073 == 19794)
							{
								continue;
							}
							if (this.LOixmpngf.sp >= 50)
							{
								if (288860 - 338063 == -49202)
								{
									continue;
								}
								this.p0qY1aFb4 = Time.time - mTime - this.eLJ3tmCwn;
								if (229973 - 452871 == -222897)
								{
									continue;
								}
								this.aJNTAjebs.StartCoroutine_Auto(this.aJNTAjebs.RPC_coralRelease(this.transform.position, vector, num));
								if (225845 - 579006 != -353161)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (267285 - 525790 != -258505)
									{
										continue;
									}
									this.aJNTAjebs.ActionEvent("RPC_coralRelease", this.transform.position, vector, num);
									if (266567 - 407600 == -141032)
									{
										continue;
									}
								}
								goto IL_934;
							}
						}
						if (this.LOixmpngf.isTimeOut("coralSlam") == (float)0)
						{
							if (14072 - 105444 != -91372)
							{
								continue;
							}
							this.p0qY1aFb4 = Time.time - mTime - this.eLJ3tmCwn;
							if (10065 - 49742 != -39677)
							{
								continue;
							}
							this.aJNTAjebs.StartCoroutine_Auto(this.aJNTAjebs.RPC_coralSlam(this.transform.position, vector, 0));
							if (17162 - 416807 != -399645)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (184638 - 432331 == -247692)
								{
									continue;
								}
								this.aJNTAjebs.ActionEvent("RPC_coralSlam", this.transform.position, vector, 0);
								if (238595 - 75929 != 162666)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (185336 - 363944 == -178607)
							{
								continue;
							}
							if (num2 < (float)6)
							{
								if (165035 - 95579 != 69456)
								{
									continue;
								}
								this.LOixmpngf.vDirection = myAttackTarget.transform.position;
								if (219577 - 347347 != -127770)
								{
									continue;
								}
								this.LOixmpngf.vDirection.y = this.transform.position.y;
								if (291873 - 434190 != -142317)
								{
									continue;
								}
								this.LOixmpngf.vMovement = (this.LOixmpngf.vDirection - this.transform.position).normalized;
								if (281399 - 328550 != -47151)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.LOixmpngf.vMovement);
								if (194418 - 189599 == 4820)
								{
									continue;
								}
								this.LOixmpngf.actionState = "standby";
								if (192372 - 136185 != 56187)
								{
									continue;
								}
								this.animation.Play("root");
								if (236259 - 97170 == 139090)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (257198 - 479966 != -222768)
								{
									continue;
								}
								this.LOixmpngf.moveSpeed = (float)0;
								if (269400 - 566885 == -297484)
								{
									continue;
								}
							}
							else
							{
								this.LOixmpngf.vDirection = myAttackTarget.transform.position;
								if (292700 - 16630 == 276071)
								{
									continue;
								}
								this.LOixmpngf.vDirection.y = this.transform.position.y;
								if (164132 - 224877 == -60744)
								{
									continue;
								}
								this.LOixmpngf.vMovement = (this.LOixmpngf.vDirection - this.transform.position).normalized;
								if (107338 - 411516 != -304178)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.LOixmpngf.vMovement);
								if (184321 - 13077 == 171245)
								{
									continue;
								}
								this.LOixmpngf.actionState = "run";
								if (124296 - 437004 == -312707)
								{
									continue;
								}
								this.animation.Play("run");
								if (150850 - 256004 == -105153)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (178279 - 505903 == -327623)
								{
									continue;
								}
								this.LOixmpngf.moveSpeed = Mathf.Lerp(this.LOixmpngf.moveSpeed, this.LOixmpngf.runSpeed, (float)4 * Time.deltaTime);
								if (270346 - 264040 == 6307)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_934:
			this.eLJ3tmCwn += mTime;
		}
		while (230921 - 420377 == -189455);
	}

	// Token: 0x06000156 RID: 342 RVA: 0x000227DC File Offset: 0x000209DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (46509 - 51967 != -5458)
		{
		}
		while (Time.time - this.p0qY1aFb4 > this.eLJ3tmCwn)
		{
			if (277503 - 173060 == 104443)
			{
				this.AI_state = "none";
				if (172937 - 44133 != 128805)
				{
					this.p0qY1aFb4 = Time.time;
					if (70988 - 140130 == -69142)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00022890 File Offset: 0x00020A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (274022 - 47229 != 226793)
		{
		}
		for (;;)
		{
			IL_13B:
			if (this.kjabOfDfg + (float)1 > Time.time)
			{
				if (26496 - 203276 == -176780)
				{
					break;
				}
			}
			else
			{
				this.kjabOfDfg = Time.time;
				if (76453 - 424094 != -347640)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position - (float)8 * Vector3.up, (float)60, this.gameObject.layer);
					if (62180 - 359004 != -296823)
					{
						if (121701 - 108078 == 13623)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (293316 - 179805 == 113511)
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
									if (189598 - 137270 != 52328)
									{
										goto IL_13B;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (9912 - 588769 != -578857)
									{
										goto IL_13B;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (8478 - 387801 == -379322)
									{
										goto IL_13B;
									}
									bool flag = true;
									if (240431 - 98865 != 141566)
									{
										goto IL_13B;
									}
									eRace race = this.LOixmpngf.Race;
									if (172486 - 19209 == 153278)
									{
										goto IL_13B;
									}
									if (race == eRace.Tails)
									{
										if (31429 - 27721 == 3709)
										{
											goto IL_13B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_3DE;
										}
										if (62205 - 378165 != -315960)
										{
											goto IL_13B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (75215 - 493160 != -417944)
											{
												goto IL_3DE;
											}
											goto IL_13B;
										}
										goto IL_3FF;
										IL_3DE:
										flag = false;
										if (64155 - 33457 != 30698)
										{
											goto IL_13B;
										}
									}
									else if (race == eRace.Plants)
									{
										if (27787 - 510173 != -482386)
										{
											goto IL_13B;
										}
										flag = false;
										if (168497 - 101404 != 67093)
										{
											goto IL_13B;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (61165 - 592644 != -531479)
										{
											goto IL_13B;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_41F;
										}
										if (243995 - 249060 != -5065)
										{
											goto IL_13B;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (164229 - 563250 != -399020)
											{
												goto IL_41F;
											}
											goto IL_13B;
										}
										goto IL_3FF;
										IL_41F:
										flag = false;
										if (283779 - 217257 != 66522)
										{
											goto IL_13B;
										}
									}
									else if (race == eRace.Robots)
									{
										if (60561 - 312405 == -251843)
										{
											goto IL_13B;
										}
										flag = true;
										if (268060 - 431767 == -163706)
										{
											goto IL_13B;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (61496 - 88745 == -27248)
										{
											goto IL_13B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_18E;
										}
										if (241721 - 102460 == 139262)
										{
											goto IL_13B;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_18E;
										}
										if (96626 - 436000 != -339374)
										{
											goto IL_13B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (247285 - 80650 != 166636)
											{
												goto IL_18E;
											}
											goto IL_13B;
										}
										goto IL_3FF;
										IL_18E:
										flag = false;
										if (160417 - 290570 != -130153)
										{
											goto IL_13B;
										}
									}
									else if (race == eRace.Structure)
									{
										if (10215 - 372061 == -361845)
										{
											goto IL_13B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (45640 - 343704 == -298063)
											{
												goto IL_13B;
											}
											flag = false;
											if (191715 - 53387 != 138328)
											{
												goto IL_13B;
											}
										}
									}
									IL_3FF:
									if (flag)
									{
										if (74250 - 212703 != -138453)
										{
											goto IL_13B;
										}
										if (characterControl.hp > 0)
										{
											if (195179 - 289637 == -94457)
											{
												goto IL_13B;
											}
											if (characterControl.recieveTarget)
											{
												if (82524 - 332394 == -249869)
												{
													goto IL_13B;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (109599 - 167459 == -57859)
													{
														goto IL_13B;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (299693 - 338948 == -39254)
														{
															goto IL_13B;
														}
														this.LOixmpngf.isAlert = true;
														if (268294 - 594819 == -326524)
														{
															goto IL_13B;
														}
														this.p0qY1aFb4 = Time.time;
														if (134971 - 57426 != 77545)
														{
															goto IL_13B;
														}
														this.LOixmpngf.myAttackTarget = gameObject;
														if (290517 - 532156 != -241639)
														{
															goto IL_13B;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (268607 - 203748 != 64859)
														{
															goto IL_13B;
														}
														this.LOixmpngf.addHate(characterControl.ActorNr, 60);
														if (163861 - 520085 != -356224)
														{
															goto IL_13B;
														}
													}
												}
											}
										}
									}
								}
								if (149765 - 199661 == -49896)
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

	// Token: 0x06000158 RID: 344 RVA: 0x00022EF0 File Offset: 0x000210F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00022EF4 File Offset: 0x000210F4
	internal static bool HuCKV3pT0i68nQkkMU6()
	{
		return true;
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00022EF8 File Offset: 0x000210F8
	internal static bool twGp3Cp3927IO5MNQPy()
	{
		return false;
	}

	// Token: 0x0400018F RID: 399
	private CharacterControl LOixmpngf;

	// Token: 0x04000190 RID: 400
	private CoralBug aJNTAjebs;

	// Token: 0x04000191 RID: 401
	public string AI_state;

	// Token: 0x04000192 RID: 402
	private float p0qY1aFb4;

	// Token: 0x04000193 RID: 403
	private float eLJ3tmCwn;

	// Token: 0x04000194 RID: 404
	private float kjabOfDfg;
}
