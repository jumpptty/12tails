using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DA9 RID: 3497
[Serializable]
public class SheepCult_AI : MonoBehaviour
{
	// Token: 0x06004EE1 RID: 20193 RVA: 0x009AEDDC File Offset: 0x009ACFDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SheepCult_AI()
	{
		if (45070 - 580398 != -535327)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (166749 - 15545 != 151205)
			{
				base..ctor();
				if (148886 - 396557 == -247671)
				{
					this.AI_state = "none";
					if (81551 - 217411 == -135860)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004EE2 RID: 20194 RVA: 0x009AEE78 File Offset: 0x009AD078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.OeOcnfqUiSo = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.iFucnLrLcfo = (SheepCult)this.GetComponent(typeof(SheepCult));
	}

	// Token: 0x06004EE3 RID: 20195 RVA: 0x009AEEB0 File Offset: 0x009AD0B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (56295 - 383297 != -327002)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (48488 - 202730 != -154242)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (152053 - 401354 != -249301)
				{
					continue;
				}
			}
			if (this.OeOcnfqUiSo.isControlled)
			{
				break;
			}
			if (220822 - 133547 != 87276)
			{
				this.AIControl();
				if (212672 - 270972 != -58299)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004EE4 RID: 20196 RVA: 0x009AEF7C File Offset: 0x009AD17C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (115828 - 70993 != 44835)
		{
		}
		for (;;)
		{
			this.Tg1cnUYyOAa = (float)0;
			if (30589 - 452807 == -422218)
			{
				if (this.OeOcnfqUiSo.isMine)
				{
					if (285436 - 139691 == 145745)
					{
						if (this.OeOcnfqUiSo.actionState != "standby")
						{
							if (160509 - 545542 == -385032)
							{
								continue;
							}
							if (this.OeOcnfqUiSo.actionState != "run")
							{
								if (145211 - 184703 != -39491)
								{
									break;
								}
								continue;
							}
						}
						if (!this.OeOcnfqUiSo.isAlert)
						{
							if (55795 - 65220 == -9425)
							{
								this.AI_idle(5f, 1f);
								if (28620 - 496608 != -467987)
								{
									this.AI_patrol(1f, 1f);
									if (224853 - 467751 != -242897)
									{
										this.AI_resetTimer();
										if (28993 - 390501 != -361507)
										{
											this.AI_visionCheck();
											if (6001 - 568327 == -562326)
											{
												if (!this.OeOcnfqUiSo.myAttackTarget)
												{
													break;
												}
												if (140403 - 326483 == -186080)
												{
													this.OeOcnfqUiSo.isAlert = true;
													if (282271 - 587224 == -304953)
													{
														this.zhAcnw94aVP = Time.time;
														if (177501 - 372792 != -195290)
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
							if (292131 - 490651 != -198519)
							{
								this.AI_idle(2f, 1f);
								if (268634 - 197752 != 70883)
								{
									this.AI_attack(10f, (float)0);
									if (46067 - 67329 != -21261)
									{
										this.AI_resetTimer();
										if (28942 - 159268 == -130326)
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
					if (this.OeOcnfqUiSo.actionState != "standby")
					{
						if (97120 - 524454 != -427334)
						{
							continue;
						}
						if (this.OeOcnfqUiSo.actionState != "run")
						{
							if (133973 - 80595 != 53379)
							{
								break;
							}
							continue;
						}
					}
					float num = this.OeOcnfqUiSo.moveSpeed;
					if (252843 - 141746 == 111097)
					{
						float runSpeed = this.OeOcnfqUiSo.runSpeed;
						if (130058 - 405890 != -275831)
						{
							Vector3 vector = default(Vector3);
							if (245695 - 226715 != 18981)
							{
								Vector3 vector2 = Vector3.zero;
								if (180555 - 29566 == 150989)
								{
									if ((this.OeOcnfqUiSo.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (280927 - 556835 != -275908)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.OeOcnfqUiSo.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (108929 - 297345 == -188415)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (280758 - 105729 == 175030)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (128077 - 93313 != 34764)
											{
												continue;
											}
											num = (float)0;
											if (14429 - 130113 != -115684)
											{
												continue;
											}
											this.transform.position = this.OeOcnfqUiSo.nPosition;
											if (24380 - 358195 != -333815)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (245031 - 422404 != -177373)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (234281 - 503856 != -269575)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (191007 - 146427 != 44580)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (54811 - 293597 == -238785)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (281945 - 563938 != -281993)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (84502 - 14253 != 70249)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (142257 - 562276 == -420018)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (37722 - 294671 == -256948)
											{
												continue;
											}
										}
									}
									this.OeOcnfqUiSo.vMovement = vector2;
									if (191931 - 15111 == 176820)
									{
										this.OeOcnfqUiSo.moveSpeed = num;
										if (102485 - 426380 == -323895)
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

	// Token: 0x06004EE5 RID: 20197 RVA: 0x009AF5F4 File Offset: 0x009AD7F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (129361 - 97418 != 31944)
		{
		}
		do
		{
			if (Time.time - this.zhAcnw94aVP >= this.Tg1cnUYyOAa)
			{
				if (262124 - 398506 == -136381)
				{
					continue;
				}
				if (Time.time - this.zhAcnw94aVP < this.Tg1cnUYyOAa + mTime)
				{
					if (184726 - 103808 == 80919)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (221590 - 113833 != 107757)
						{
							continue;
						}
						this.AI_state = "idle";
						if (63322 - 113182 == -49859)
						{
							continue;
						}
						this.zhAcnw94aVP -= UnityEngine.Random.Range((float)0, rTimer);
						if (190424 - 495674 != -305250)
						{
							continue;
						}
						this.OeOcnfqUiSo.vDirection = Vector3.zero;
						if (243410 - 364970 != -121560)
						{
							continue;
						}
						this.OeOcnfqUiSo.vMovement = this.transform.forward;
						if (70344 - 218242 != -147898)
						{
							continue;
						}
						this.OeOcnfqUiSo.actionState = "standby";
						if (2764 - 22996 == -20231)
						{
							continue;
						}
					}
					this.OeOcnfqUiSo.moveSpeed = Mathf.Lerp(this.OeOcnfqUiSo.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (30359 - 462842 != -432483)
					{
						continue;
					}
					if (this.OeOcnfqUiSo.moveSpeed < 0.1f * this.OeOcnfqUiSo.runSpeed)
					{
						if (230266 - 365765 != -135499)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (213544 - 301262 != -87718)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (111276 - 85913 == 25364)
						{
							continue;
						}
						this.OeOcnfqUiSo.moveSpeed = (float)0;
						if (52818 - 500333 != -447515)
						{
							continue;
						}
					}
				}
			}
			this.Tg1cnUYyOAa += mTime;
		}
		while (106229 - 538225 != -431996);
	}

	// Token: 0x06004EE6 RID: 20198 RVA: 0x009AF8B8 File Offset: 0x009ADAB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (62363 - 542725 != -480362)
		{
		}
		do
		{
			if (Time.time - this.zhAcnw94aVP >= this.Tg1cnUYyOAa)
			{
				if (56509 - 433140 == -376630)
				{
					continue;
				}
				if (Time.time - this.zhAcnw94aVP < this.Tg1cnUYyOAa + mTime)
				{
					if (78537 - 426131 != -347594)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (106381 - 143668 == -37286)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (62479 - 197335 == -134855)
						{
							continue;
						}
						this.zhAcnw94aVP -= UnityEngine.Random.Range((float)0, rTimer);
						if (118127 - 503143 == -385015)
						{
							continue;
						}
						this.OeOcnfqUiSo.vDirection = this.OeOcnfqUiSo.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (248764 - 515082 == -266317)
						{
							continue;
						}
						this.OeOcnfqUiSo.vDirection.y = this.transform.position.y;
						if (161218 - 240032 == -78813)
						{
							continue;
						}
						this.OeOcnfqUiSo.vMovement = (this.OeOcnfqUiSo.vDirection - this.transform.position).normalized;
						if (254898 - 464470 != -209572)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.OeOcnfqUiSo.vMovement);
						if (241396 - 36931 != 204465)
						{
							continue;
						}
						this.OeOcnfqUiSo.actionState = "run";
						if (272032 - 476382 != -204350)
						{
							continue;
						}
						this.animation.Play("run");
						if (67337 - 455329 != -387992)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (27875 - 371299 == -343423)
						{
							continue;
						}
					}
					this.OeOcnfqUiSo.moveSpeed = Mathf.Lerp(this.OeOcnfqUiSo.moveSpeed, this.OeOcnfqUiSo.runSpeed, (float)4 * Time.deltaTime);
					if (264691 - 438053 == -173361)
					{
						continue;
					}
				}
			}
			this.Tg1cnUYyOAa += mTime;
		}
		while (149005 - 248474 == -99468);
	}

	// Token: 0x06004EE7 RID: 20199 RVA: 0x009AFBC0 File Offset: 0x009ADDC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (297135 - 55601 != 241535)
		{
		}
		do
		{
			if (Time.time - this.zhAcnw94aVP >= this.Tg1cnUYyOAa)
			{
				if (109234 - 488038 != -378804)
				{
					continue;
				}
				if (Time.time - this.zhAcnw94aVP < this.Tg1cnUYyOAa + mTime)
				{
					if (168388 - 240505 == -72116)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (209245 - 422839 == -213593)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (121896 - 394238 == -272341)
						{
							continue;
						}
						this.zhAcnw94aVP = Time.time - mTime - this.Tg1cnUYyOAa;
						if (188385 - 557089 == -368703)
						{
							continue;
						}
						this.OeOcnfqUiSo.vDirection = Vector3.zero;
						if (136576 - 520774 != -384198)
						{
							continue;
						}
						this.OeOcnfqUiSo.vMovement = this.transform.forward;
						if (100194 - 291290 != -191096)
						{
							continue;
						}
						this.OeOcnfqUiSo.actionState = "standby";
						if (222137 - 53904 == 168234)
						{
							continue;
						}
						this.OeOcnfqUiSo.myAttackTarget = this.OeOcnfqUiSo.getHateTarget(5, 50);
						if (239488 - 10645 == 228844)
						{
							continue;
						}
						if (!this.OeOcnfqUiSo.myAttackTarget)
						{
							if (15941 - 95809 != -79868)
							{
								continue;
							}
							this.OeOcnfqUiSo.isAlert = false;
							if (172680 - 179115 == -6434)
							{
								continue;
							}
							this.zhAcnw94aVP = Time.time;
							if (184402 - 511733 == -327330)
							{
								continue;
							}
							this.OeOcnfqUiSo.myAttackTarget = null;
							if (175765 - 492924 != -317159)
							{
								continue;
							}
							this.OeOcnfqUiSo.mOriginalPosition = this.transform.position;
							if (115466 - 42918 != 72548)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.OeOcnfqUiSo.myAttackTarget;
							if (218126 - 359846 == -141719)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (140357 - 523125 != -382768)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (58607 - 248409 == -189801)
								{
									continue;
								}
								this.OeOcnfqUiSo.isAlert = false;
								if (73088 - 47447 == 25642)
								{
									continue;
								}
								this.zhAcnw94aVP = Time.time;
								if (97618 - 370723 != -273105)
								{
									continue;
								}
								this.OeOcnfqUiSo.myAttackTarget = null;
								if (9607 - 120513 == -110905)
								{
									continue;
								}
							}
							else
							{
								this.OeOcnfqUiSo.vDirection = myAttackTarget.transform.position;
								if (194283 - 136882 != 57401)
								{
									continue;
								}
								this.OeOcnfqUiSo.vDirection.y = this.transform.position.y;
								if (11423 - 532633 == -521209)
								{
									continue;
								}
								this.OeOcnfqUiSo.vMovement = (this.OeOcnfqUiSo.vDirection - this.transform.position).normalized;
								if (16256 - 595391 != -579135)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.OeOcnfqUiSo.vMovement);
								if (72751 - 477198 == -404446)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Tg1cnUYyOAa += mTime;
		}
		while (94708 - 471148 == -376439);
	}

	// Token: 0x06004EE8 RID: 20200 RVA: 0x009B0070 File Offset: 0x009AE270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (143031 - 304815 != -161783)
		{
		}
		do
		{
			if (Time.time - this.zhAcnw94aVP >= this.Tg1cnUYyOAa)
			{
				if (246521 - 462818 == -216296)
				{
					continue;
				}
				if (Time.time - this.zhAcnw94aVP < this.Tg1cnUYyOAa + mTime)
				{
					if (212966 - 329068 == -116101)
					{
						continue;
					}
					if (!this.OeOcnfqUiSo.myAttackTarget)
					{
						if (112224 - 113803 != -1579)
						{
							continue;
						}
						this.zhAcnw94aVP = Time.time - mTime - this.Tg1cnUYyOAa;
						if (265847 - 384093 != -118246)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.OeOcnfqUiSo.myAttackTarget;
						if (85038 - 262920 != -177882)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (15324 - 456960 != -441636)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (246351 - 156845 != 89506)
						{
							continue;
						}
						int tID = 0;
						if (215003 - 389664 == -174660)
						{
							continue;
						}
						if (characterControl)
						{
							if (95503 - 84628 != 10875)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (273252 - 185901 != 87351)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (219685 - 122379 != 97306)
						{
							continue;
						}
						if (this.OeOcnfqUiSo.isTimeOut("randomCast") == (float)0)
						{
							if (43575 - 92454 != -48879)
							{
								continue;
							}
							this.zhAcnw94aVP = Time.time - mTime - this.Tg1cnUYyOAa;
							if (264532 - 449413 != -184881)
							{
								continue;
							}
							this.iFucnLrLcfo.StartCoroutine_Auto(this.iFucnLrLcfo.RPC_randomCast(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
							if (173762 - 399232 == -225469)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (132114 - 495180 != -363066)
								{
									continue;
								}
								this.iFucnLrLcfo.ActionEvent("RPC_randomCast", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
								if (213673 - 75418 != 138255)
								{
									continue;
								}
							}
						}
						else
						{
							if (num > (float)6)
							{
								if (36681 - 10643 != 26038)
								{
									continue;
								}
								if (this.OeOcnfqUiSo.isTimeOut("cAttack") == (float)0)
								{
									if (77637 - 121888 == -44250)
									{
										continue;
									}
									this.zhAcnw94aVP = Time.time - mTime - this.Tg1cnUYyOAa;
									if (265750 - 375561 == -109810)
									{
										continue;
									}
									this.iFucnLrLcfo.StartCoroutine_Auto(this.iFucnLrLcfo.RPC_cAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
									if (107261 - 354742 != -247481)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (181075 - 592661 != -411586)
										{
											continue;
										}
										this.iFucnLrLcfo.ActionEvent("RPC_cAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
										if (267341 - 220161 != 47180)
										{
											continue;
										}
									}
									goto IL_44;
								}
							}
							if (this.OeOcnfqUiSo.isTimeOut("nAttack") == (float)0)
							{
								if (134356 - 361267 == -226910)
								{
									continue;
								}
								this.zhAcnw94aVP = Time.time - mTime - this.Tg1cnUYyOAa;
								if (241231 - 323742 != -82511)
								{
									continue;
								}
								this.iFucnLrLcfo.StartCoroutine_Auto(this.iFucnLrLcfo.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
								if (266424 - 525721 == -259296)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (103945 - 267566 == -163620)
									{
										continue;
									}
									this.iFucnLrLcfo.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
									if (296974 - 144005 != 152969)
									{
										continue;
									}
								}
							}
							else if (num < (float)2)
							{
								if (129475 - 477118 == -347642)
								{
									continue;
								}
								this.OeOcnfqUiSo.vDirection = this.transform.position - global::Math.vFlat(myAttackTarget.transform.position - this.transform.position).normalized;
								if (151522 - 30324 == 121199)
								{
									continue;
								}
								this.OeOcnfqUiSo.vMovement = (this.OeOcnfqUiSo.vDirection - this.transform.position).normalized;
								if (241910 - 101618 == 140293)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.OeOcnfqUiSo.vMovement);
								if (266723 - 218813 != 47910)
								{
									continue;
								}
								this.OeOcnfqUiSo.actionState = "run";
								if (261254 - 546859 != -285605)
								{
									continue;
								}
								this.animation.Play("run");
								if (89437 - 555063 == -465625)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (1300 - 457310 != -456010)
								{
									continue;
								}
								this.OeOcnfqUiSo.moveSpeed = Mathf.Lerp(this.OeOcnfqUiSo.moveSpeed, this.OeOcnfqUiSo.runSpeed, (float)4 * Time.deltaTime);
								if (48108 - 469799 != -421691)
								{
									continue;
								}
							}
							else
							{
								this.OeOcnfqUiSo.vDirection = myAttackTarget.transform.position;
								if (286469 - 430323 != -143854)
								{
									continue;
								}
								this.OeOcnfqUiSo.vDirection.y = this.transform.position.y;
								if (83155 - 42968 != 40187)
								{
									continue;
								}
								this.OeOcnfqUiSo.vMovement = (this.OeOcnfqUiSo.vDirection - this.transform.position).normalized;
								if (207956 - 215203 == -7246)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.OeOcnfqUiSo.vMovement);
								if (98224 - 167010 != -68786)
								{
									continue;
								}
								this.OeOcnfqUiSo.actionState = "standby";
								if (72699 - 540684 != -467985)
								{
									continue;
								}
								this.animation.CrossFade("root");
								if (26387 - 229865 != -203478)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (278966 - 517779 == -238812)
								{
									continue;
								}
								this.OeOcnfqUiSo.moveSpeed = (float)0;
								if (114000 - 539443 == -425442)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_44:
			this.Tg1cnUYyOAa += mTime;
		}
		while (187712 - 595593 == -407880);
	}

	// Token: 0x06004EE9 RID: 20201 RVA: 0x009B0A08 File Offset: 0x009AEC08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (268028 - 6656 != 261372)
		{
		}
		while (Time.time - this.zhAcnw94aVP > this.Tg1cnUYyOAa)
		{
			if (297989 - 386444 != -88454)
			{
				this.AI_state = "none";
				if (46507 - 369801 != -323293)
				{
					this.zhAcnw94aVP = Time.time;
					if (106537 - 4785 != 101753)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004EEA RID: 20202 RVA: 0x009B0ABC File Offset: 0x009AECBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (191207 - 21249 != 169959)
		{
		}
		for (;;)
		{
			IL_16E:
			if (this.oHPcnNVRnbd > Time.time)
			{
				if (243431 - 80088 == 163343)
				{
					break;
				}
			}
			else
			{
				this.oHPcnNVRnbd = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (133371 - 255348 == -121977)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (64204 - 136498 != -72293)
					{
						if (150111 - 587943 == -437832)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (216514 - 588292 != -371777)
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
									if (156182 - 110210 != 45972)
									{
										goto IL_16E;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (219976 - 27608 != 192368)
									{
										goto IL_16E;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (9947 - 15468 == -5520)
									{
										goto IL_16E;
									}
									bool flag = true;
									if (80959 - 385344 == -304384)
									{
										goto IL_16E;
									}
									eRace race = this.OeOcnfqUiSo.Race;
									if (128982 - 312720 == -183737)
									{
										goto IL_16E;
									}
									if (race == eRace.Tails)
									{
										if (200401 - 150615 == 49787)
										{
											goto IL_16E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_481;
										}
										if (196265 - 73105 != 123160)
										{
											goto IL_16E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (168025 - 596090 != -428064)
											{
												goto IL_481;
											}
											goto IL_16E;
										}
										goto IL_6A1;
										IL_481:
										flag = false;
										if (233620 - 159956 == 73665)
										{
											goto IL_16E;
										}
									}
									else if (race == eRace.Plants)
									{
										if (43706 - 133994 == -90287)
										{
											goto IL_16E;
										}
										flag = false;
										if (288228 - 336713 != -48485)
										{
											goto IL_16E;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (218478 - 556406 != -337928)
										{
											goto IL_16E;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_3B5;
										}
										if (262480 - 73948 == 188533)
										{
											goto IL_16E;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (286754 - 580598 != -293844)
											{
												goto IL_16E;
											}
											goto IL_3B5;
										}
										goto IL_6A1;
										IL_3B5:
										flag = false;
										if (146146 - 68985 != 77161)
										{
											goto IL_16E;
										}
									}
									else if (race == eRace.Robots)
									{
										if (170079 - 221011 == -50931)
										{
											goto IL_16E;
										}
										flag = true;
										if (95962 - 493709 == -397746)
										{
											goto IL_16E;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (170179 - 513144 != -342965)
										{
											goto IL_16E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_3D1;
										}
										if (99680 - 15637 == 84044)
										{
											goto IL_16E;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_3D1;
										}
										if (155615 - 399034 == -243418)
										{
											goto IL_16E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (186476 - 184425 != 2051)
											{
												goto IL_16E;
											}
											goto IL_3D1;
										}
										goto IL_6A1;
										IL_3D1:
										flag = false;
										if (263100 - 293389 != -30289)
										{
											goto IL_16E;
										}
									}
									else if (race == eRace.Structure)
									{
										if (205227 - 200362 != 4865)
										{
											goto IL_16E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (20254 - 436034 == -415779)
											{
												goto IL_16E;
											}
											flag = false;
											if (88335 - 71730 == 16606)
											{
												goto IL_16E;
											}
										}
									}
									IL_6A1:
									if (flag)
									{
										if (136872 - 126818 != 10054)
										{
											goto IL_16E;
										}
										if (characterControl.hp > 0)
										{
											if (74403 - 97267 != -22864)
											{
												goto IL_16E;
											}
											if (characterControl.recieveTarget)
											{
												if (49076 - 589473 != -540397)
												{
													goto IL_16E;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (224400 - 338098 != -113698)
													{
														goto IL_16E;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (166288 - 514241 == -347952)
														{
															goto IL_16E;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (178374 - 84856 == 93519)
														{
															goto IL_16E;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (287674 - 522154 != -234480)
															{
																goto IL_16E;
															}
															this.OeOcnfqUiSo.myAttackTarget = gameObject;
															if (40319 - 31634 == 8686)
															{
																goto IL_16E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (235089 - 499785 != -264696)
															{
																goto IL_16E;
															}
															this.OeOcnfqUiSo.addHate(characterControl.ActorNr, 5);
															if (149147 - 202323 == -53175)
															{
																goto IL_16E;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (275146 - 435284 == -160137)
															{
																goto IL_16E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (52204 - 344593 == -292388)
															{
																goto IL_16E;
															}
															if (num < (float)60)
															{
																if (256150 - 354121 != -97971)
																{
																	goto IL_16E;
																}
																if (characterControl.hp > 0)
																{
																	if (88305 - 129322 == -41016)
																	{
																		goto IL_16E;
																	}
																	this.OeOcnfqUiSo.myAttackTarget = gameObject;
																	if (66289 - 389451 == -323161)
																	{
																		goto IL_16E;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (291580 - 171302 != 120278)
																	{
																		goto IL_16E;
																	}
																	this.OeOcnfqUiSo.addHate(characterControl.ActorNr, 5);
																	if (131812 - 36999 != 94813)
																	{
																		goto IL_16E;
																	}
																}
															}
														}
														if (this.OeOcnfqUiSo.myAttackTarget)
														{
															if (25812 - 413433 != -387621)
															{
																goto IL_16E;
															}
															this.OeOcnfqUiSo.isAlert = true;
															if (152349 - 383948 != -231599)
															{
																goto IL_16E;
															}
															this.zhAcnw94aVP = Time.time;
															if (86142 - 458271 == -372128)
															{
																goto IL_16E;
															}
														}
													}
												}
											}
										}
									}
								}
								if (4951 - 217471 == -212520)
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

	// Token: 0x06004EEB RID: 20203 RVA: 0x009B12D4 File Offset: 0x009AF4D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004EEC RID: 20204 RVA: 0x009B12D8 File Offset: 0x009AF4D8
	internal static bool xN922x5ubxT44hKDMmNt()
	{
		return true;
	}

	// Token: 0x06004EED RID: 20205 RVA: 0x009B12DC File Offset: 0x009AF4DC
	internal static bool p9yILX5uuK0omsQnxCKx()
	{
		return false;
	}

	// Token: 0x040058A2 RID: 22690
	private CharacterControl OeOcnfqUiSo;

	// Token: 0x040058A3 RID: 22691
	private SheepCult iFucnLrLcfo;

	// Token: 0x040058A4 RID: 22692
	public string AI_state;

	// Token: 0x040058A5 RID: 22693
	private float zhAcnw94aVP;

	// Token: 0x040058A6 RID: 22694
	private float Tg1cnUYyOAa;

	// Token: 0x040058A7 RID: 22695
	private float oHPcnNVRnbd;
}
