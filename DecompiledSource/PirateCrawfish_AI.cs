using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D71 RID: 3441
[Serializable]
public class PirateCrawfish_AI : MonoBehaviour
{
	// Token: 0x06004D6F RID: 19823 RVA: 0x00988504 File Offset: 0x00986704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PirateCrawfish_AI()
	{
		if (7714 - 438804 != -431089)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (130145 - 452026 != -321880)
			{
				base..ctor();
				if (200452 - 417027 == -216575)
				{
					this.AI_state = "none";
					if (195143 - 229027 == -33884)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004D70 RID: 19824 RVA: 0x009885A0 File Offset: 0x009867A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.oMEccAeBG40 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.UuAcc93ymut = (PirateCrawfish)this.GetComponent(typeof(PirateCrawfish));
	}

	// Token: 0x06004D71 RID: 19825 RVA: 0x009885D8 File Offset: 0x009867D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (104167 - 432151 != -327984)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (26823 - 196864 != -170041)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (17680 - 12167 != 5513)
				{
					continue;
				}
			}
			if (this.oMEccAeBG40.isControlled)
			{
				break;
			}
			if (128749 - 487882 == -359133)
			{
				this.AIControl();
				if (217334 - 138102 != 79233)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004D72 RID: 19826 RVA: 0x009886A4 File Offset: 0x009868A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (273278 - 47692 != 225586)
		{
		}
		for (;;)
		{
			this.phDccu0UQNE = (float)0;
			if (113903 - 70027 == 43876)
			{
				if (this.oMEccAeBG40.isMine)
				{
					if (122402 - 370305 == -247903)
					{
						if (this.oMEccAeBG40.actionState != "standby")
						{
							if (106388 - 394309 != -287921)
							{
								continue;
							}
							if (this.oMEccAeBG40.actionState != "run")
							{
								if (52249 - 115131 != -62882)
								{
									continue;
								}
								break;
							}
						}
						if (!this.oMEccAeBG40.isAlert)
						{
							if (62066 - 427091 != -365024)
							{
								this.AI_idle(2f, 1f);
								if (125620 - 552230 != -426609)
								{
									this.AI_patrol(2f, 1f);
									if (25081 - 561092 == -536011)
									{
										this.AI_resetTimer();
										if (41564 - 36671 == 4893)
										{
											this.AI_visionCheck();
											if (221013 - 75761 == 145252)
											{
												if (!this.oMEccAeBG40.myAttackTarget)
												{
													break;
												}
												if (268729 - 338495 != -69765)
												{
													this.oMEccAeBG40.isAlert = true;
													if (289408 - 347512 != -58103)
													{
														this.vrOccWFra29 = Time.time;
														if (160856 - 485752 != -324895)
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
							if (107305 - 484309 != -377003)
							{
								this.AI_idle(2f, 2f);
								if (265289 - 119316 != 145974)
								{
									this.AI_patrol(1f, 1f);
									if (92406 - 390140 == -297734)
									{
										this.AI_attack(10f, (float)0);
										if (250718 - 184958 == 65760)
										{
											this.AI_resetTimer();
											if (165332 - 473993 != -308660)
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
					if (this.oMEccAeBG40.actionState != "standby")
					{
						if (115741 - 163990 != -48249)
						{
							continue;
						}
						if (this.oMEccAeBG40.actionState != "run")
						{
							if (243419 - 332637 != -89217)
							{
								break;
							}
							continue;
						}
					}
					float num = this.oMEccAeBG40.moveSpeed;
					if (127634 - 70282 != 57353)
					{
						float runSpeed = this.oMEccAeBG40.runSpeed;
						if (131400 - 187122 == -55722)
						{
							Vector3 vector = default(Vector3);
							if (234303 - 413196 == -178893)
							{
								Vector3 vector2 = Vector3.zero;
								if (140777 - 143574 != -2796)
								{
									if ((this.oMEccAeBG40.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (93113 - 142674 != -49561)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.oMEccAeBG40.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (141419 - 339230 == -197810)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (279121 - 594008 == -314886)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (143164 - 532034 != -388870)
											{
												continue;
											}
											num = (float)0;
											if (58038 - 67561 != -9523)
											{
												continue;
											}
											this.transform.position = this.oMEccAeBG40.nPosition;
											if (297992 - 585821 != -287829)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (149923 - 480801 == -330877)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (102581 - 193355 != -90774)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (81862 - 209624 != -127762)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (51520 - 429111 != -377591)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (222370 - 79423 == 142948)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (285685 - 155418 == 130268)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (168006 - 124648 == 43359)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (89388 - 108779 == -19390)
											{
												continue;
											}
										}
									}
									this.oMEccAeBG40.vMovement = vector2;
									if (110105 - 99894 != 10212)
									{
										this.oMEccAeBG40.moveSpeed = num;
										if (252599 - 106582 != 146018)
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

	// Token: 0x06004D73 RID: 19827 RVA: 0x00988D44 File Offset: 0x00986F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (106849 - 298498 != -191648)
		{
		}
		do
		{
			if (Time.time - this.vrOccWFra29 >= this.phDccu0UQNE)
			{
				if (2847 - 122429 != -119582)
				{
					continue;
				}
				if (Time.time - this.vrOccWFra29 < this.phDccu0UQNE + mTime)
				{
					if (38528 - 196857 != -158329)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (189176 - 309688 != -120512)
						{
							continue;
						}
						this.AI_state = "idle";
						if (18526 - 522892 == -504365)
						{
							continue;
						}
						this.vrOccWFra29 -= UnityEngine.Random.Range((float)0, rTimer);
						if (285911 - 309854 == -23942)
						{
							continue;
						}
						this.oMEccAeBG40.vDirection = Vector3.zero;
						if (298706 - 522953 != -224247)
						{
							continue;
						}
						this.oMEccAeBG40.vMovement = this.transform.forward;
						if (223483 - 249696 != -26213)
						{
							continue;
						}
						this.oMEccAeBG40.actionState = "standby";
						if (39644 - 135758 != -96114)
						{
							continue;
						}
					}
					this.oMEccAeBG40.moveSpeed = Mathf.Lerp(this.oMEccAeBG40.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (33696 - 370939 == -337242)
					{
						continue;
					}
					if (this.oMEccAeBG40.moveSpeed < 0.1f * this.oMEccAeBG40.runSpeed)
					{
						if (260465 - 473827 != -213362)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (31696 - 523030 == -491333)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (268119 - 374282 == -106162)
						{
							continue;
						}
						this.oMEccAeBG40.moveSpeed = (float)0;
						if (156083 - 143665 == 12419)
						{
							continue;
						}
					}
				}
			}
			this.phDccu0UQNE += mTime;
		}
		while (235820 - 462111 == -226290);
	}

	// Token: 0x06004D74 RID: 19828 RVA: 0x00989008 File Offset: 0x00987208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (285375 - 167959 != 117416)
		{
		}
		do
		{
			if (Time.time - this.vrOccWFra29 >= this.phDccu0UQNE)
			{
				if (213842 - 258151 == -44308)
				{
					continue;
				}
				if (Time.time - this.vrOccWFra29 < this.phDccu0UQNE + mTime)
				{
					if (41070 - 152383 == -111312)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (31726 - 241759 == -210032)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (205033 - 78800 == 126234)
						{
							continue;
						}
						this.vrOccWFra29 -= UnityEngine.Random.Range((float)0, rTimer);
						if (299326 - 527680 == -228353)
						{
							continue;
						}
						this.oMEccAeBG40.vDirection = this.oMEccAeBG40.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (118052 - 591608 == -473555)
						{
							continue;
						}
						this.oMEccAeBG40.vDirection.y = this.transform.position.y;
						if (64245 - 423306 == -359060)
						{
							continue;
						}
						this.oMEccAeBG40.vMovement = (this.oMEccAeBG40.vDirection - this.transform.position).normalized;
						if (103119 - 576321 == -473201)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.oMEccAeBG40.vMovement);
						if (135362 - 495874 != -360512)
						{
							continue;
						}
						this.oMEccAeBG40.actionState = "run";
						if (290938 - 358893 == -67954)
						{
							continue;
						}
						this.animation.Play("run");
						if (15037 - 503254 != -488217)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (223840 - 62044 == 161797)
						{
							continue;
						}
					}
					this.oMEccAeBG40.moveSpeed = Mathf.Lerp(this.oMEccAeBG40.moveSpeed, this.oMEccAeBG40.runSpeed, (float)4 * Time.deltaTime);
					if (137597 - 523120 == -385522)
					{
						continue;
					}
				}
			}
			this.phDccu0UQNE += mTime;
		}
		while (208702 - 346794 == -138091);
	}

	// Token: 0x06004D75 RID: 19829 RVA: 0x00989310 File Offset: 0x00987510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (174629 - 150297 != 24332)
		{
		}
		do
		{
			if (Time.time - this.vrOccWFra29 >= this.phDccu0UQNE)
			{
				if (161551 - 148641 != 12910)
				{
					continue;
				}
				if (Time.time - this.vrOccWFra29 < this.phDccu0UQNE + mTime)
				{
					if (220780 - 545633 == -324852)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (73771 - 413308 != -339537)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (123944 - 475791 == -351846)
						{
							continue;
						}
						this.vrOccWFra29 = Time.time - mTime - this.phDccu0UQNE;
						if (101769 - 71220 != 30549)
						{
							continue;
						}
						this.oMEccAeBG40.vDirection = Vector3.zero;
						if (15111 - 538213 != -523102)
						{
							continue;
						}
						this.oMEccAeBG40.vMovement = this.transform.forward;
						if (156601 - 376202 != -219601)
						{
							continue;
						}
						this.oMEccAeBG40.actionState = "standby";
						if (74696 - 400153 == -325456)
						{
							continue;
						}
						this.oMEccAeBG40.myAttackTarget = this.oMEccAeBG40.getHateTarget(5, 50);
						if (263506 - 120848 == 142659)
						{
							continue;
						}
						if (!this.oMEccAeBG40.myAttackTarget)
						{
							if (288797 - 472861 == -184063)
							{
								continue;
							}
							this.oMEccAeBG40.isAlert = false;
							if (174316 - 542927 != -368611)
							{
								continue;
							}
							this.vrOccWFra29 = Time.time;
							if (128362 - 585828 == -457465)
							{
								continue;
							}
							this.oMEccAeBG40.myAttackTarget = null;
							if (225408 - 538453 == -313044)
							{
								continue;
							}
							this.oMEccAeBG40.mOriginalPosition = this.transform.position;
							if (68372 - 113917 != -45545)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.oMEccAeBG40.myAttackTarget;
							if (19058 - 551432 == -532373)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (159063 - 329050 == -169986)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (266762 - 437813 == -171050)
								{
									continue;
								}
								this.oMEccAeBG40.isAlert = false;
								if (52254 - 506214 == -453959)
								{
									continue;
								}
								this.vrOccWFra29 = Time.time;
								if (171698 - 16743 == 154956)
								{
									continue;
								}
								this.oMEccAeBG40.myAttackTarget = null;
								if (75433 - 568690 == -493256)
								{
									continue;
								}
							}
							else
							{
								this.oMEccAeBG40.vDirection = myAttackTarget.transform.position;
								if (25659 - 376889 != -351230)
								{
									continue;
								}
								this.oMEccAeBG40.vDirection.y = this.transform.position.y;
								if (62211 - 25823 == 36389)
								{
									continue;
								}
								this.oMEccAeBG40.vMovement = (this.oMEccAeBG40.vDirection - this.transform.position).normalized;
								if (63397 - 415539 != -352142)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.oMEccAeBG40.vMovement);
								if (231529 - 135118 != 96411)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.phDccu0UQNE += mTime;
		}
		while (163920 - 519616 != -355696);
	}

	// Token: 0x06004D76 RID: 19830 RVA: 0x009897C0 File Offset: 0x009879C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (128074 - 114380 != 13695)
		{
		}
		do
		{
			if (Time.time - this.vrOccWFra29 >= this.phDccu0UQNE)
			{
				if (209262 - 328570 != -119308)
				{
					continue;
				}
				if (Time.time - this.vrOccWFra29 < this.phDccu0UQNE + mTime)
				{
					if (274531 - 473416 != -198885)
					{
						continue;
					}
					if (!this.oMEccAeBG40.myAttackTarget)
					{
						if (91273 - 310073 != -218800)
						{
							continue;
						}
						this.vrOccWFra29 = Time.time - mTime - this.phDccu0UQNE;
						if (120690 - 119840 != 850)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.oMEccAeBG40.myAttackTarget;
						if (18725 - 306804 != -288079)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (245706 - 27726 != 217980)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (175335 - 73279 != 102056)
						{
							continue;
						}
						if (276487 - 323891 != -47404)
						{
							continue;
						}
						if (characterControl)
						{
							if (8474 - 341927 != -333453)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (138084 - 396193 != -258109)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (187587 - 293085 == -105497)
						{
							continue;
						}
						if (num < (float)6)
						{
							if (259782 - 536678 != -276896)
							{
								continue;
							}
							if (this.oMEccAeBG40.isTimeOut("drunkenFlame") == (float)0)
							{
								if (260741 - 265457 != -4716)
								{
									continue;
								}
								this.vrOccWFra29 = Time.time - mTime - this.phDccu0UQNE;
								if (33893 - 140931 == -107037)
								{
									continue;
								}
								this.UuAcc93ymut.StartCoroutine_Auto(this.UuAcc93ymut.RPC_drunkenFlame(this.transform.position, vector, 0));
								if (228437 - 449324 != -220886)
								{
									if (PhotonClient.IsInitialized())
									{
										if (247852 - 241589 != 6263)
										{
											continue;
										}
										this.UuAcc93ymut.ActionEvent("RPC_drunkenFlame", this.transform.position, vector, 0);
										if (221732 - 258927 == -37194)
										{
											continue;
										}
									}
									goto IL_7B1;
								}
								continue;
							}
						}
						if (num < (float)36)
						{
							if (293973 - 578735 != -284762)
							{
								continue;
							}
							if (this.oMEccAeBG40.isTimeOut("nAttack") == (float)0)
							{
								if (279708 - 484100 == -204391)
								{
									continue;
								}
								this.vrOccWFra29 = Time.time - mTime - this.phDccu0UQNE;
								if (171103 - 15712 != 155392)
								{
									if (num > (float)2)
									{
										if (267147 - 226322 != 40825)
										{
											continue;
										}
										this.UuAcc93ymut.StartCoroutine_Auto(this.UuAcc93ymut.RPC_nAttack1(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
										if (172572 - 471544 != -298972)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (224247 - 140441 == 83807)
											{
												continue;
											}
											this.UuAcc93ymut.ActionEvent("RPC_nAttack1", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
											if (284370 - 339961 == -55590)
											{
												continue;
											}
										}
									}
									else
									{
										this.UuAcc93ymut.StartCoroutine_Auto(this.UuAcc93ymut.RPC_nAttack2(this.transform.position, vector, 0));
										if (295314 - 156894 != 138420)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (267974 - 63051 != 204923)
											{
												continue;
											}
											this.UuAcc93ymut.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
											if (181149 - 75720 != 105429)
											{
												continue;
											}
										}
									}
									goto IL_7B1;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (213820 - 321569 == -107748)
						{
							continue;
						}
						if (num > (float)27)
						{
							if (213985 - 406128 != -192143)
							{
								continue;
							}
							this.oMEccAeBG40.vDirection = myAttackTarget.transform.position;
							if (195266 - 521006 != -325740)
							{
								continue;
							}
							this.oMEccAeBG40.vDirection.y = this.transform.position.y;
							if (286644 - 203247 == 83398)
							{
								continue;
							}
							this.oMEccAeBG40.vMovement = (this.oMEccAeBG40.vDirection - this.transform.position).normalized;
							if (16715 - 94123 != -77408)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.oMEccAeBG40.vMovement);
							if (124450 - 281576 != -157126)
							{
								continue;
							}
							this.oMEccAeBG40.actionState = "run";
							if (213880 - 171984 == 41897)
							{
								continue;
							}
							this.animation.CrossFade("run");
							if (174913 - 124583 == 50331)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (238937 - 182308 == 56630)
							{
								continue;
							}
							this.oMEccAeBG40.moveSpeed = Mathf.Lerp(this.oMEccAeBG40.moveSpeed, this.oMEccAeBG40.runSpeed, (float)4 * Time.deltaTime);
							if (158236 - 244514 == -86277)
							{
								continue;
							}
						}
						else
						{
							this.oMEccAeBG40.vDirection = myAttackTarget.transform.position;
							if (240692 - 263142 == -22449)
							{
								continue;
							}
							this.oMEccAeBG40.vDirection.y = this.transform.position.y;
							if (133253 - 368144 != -234891)
							{
								continue;
							}
							this.oMEccAeBG40.vMovement = (this.oMEccAeBG40.vDirection - this.transform.position).normalized;
							if (225670 - 65715 != 159955)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.oMEccAeBG40.vMovement);
							if (100617 - 16805 == 83813)
							{
								continue;
							}
							this.oMEccAeBG40.actionState = "standby";
							if (127184 - 506604 == -379419)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (157313 - 498398 != -341085)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (103168 - 120219 == -17050)
							{
								continue;
							}
							this.oMEccAeBG40.moveSpeed = Mathf.Lerp(this.oMEccAeBG40.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (167386 - 366692 != -199306)
							{
								continue;
							}
						}
					}
				}
			}
			IL_7B1:
			this.phDccu0UQNE += mTime;
		}
		while (171518 - 406127 != -234609);
	}

	// Token: 0x06004D77 RID: 19831 RVA: 0x0098A100 File Offset: 0x00988300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (113354 - 362010 != -248655)
		{
		}
		while (Time.time - this.vrOccWFra29 > this.phDccu0UQNE)
		{
			if (188372 - 55300 != 133073)
			{
				this.AI_state = "none";
				if (11464 - 215692 != -204227)
				{
					this.vrOccWFra29 = Time.time;
					if (237881 - 301539 == -63658)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004D78 RID: 19832 RVA: 0x0098A1B4 File Offset: 0x009883B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (193528 - 386656 != -193127)
		{
		}
		for (;;)
		{
			IL_557:
			if (this.UDGccyoCt6a > Time.time)
			{
				if (280508 - 254166 == 26342)
				{
					break;
				}
			}
			else
			{
				this.UDGccyoCt6a = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (283589 - 566735 != -283145)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (53540 - 88022 != -34481)
					{
						if (213418 - 63774 == 149644)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (8179 - 152794 != -144614)
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
									if (168833 - 152579 != 16254)
									{
										goto IL_557;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (283892 - 568116 != -284224)
									{
										goto IL_557;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (964 - 590453 == -589488)
									{
										goto IL_557;
									}
									bool flag = true;
									if (148099 - 548570 == -400470)
									{
										goto IL_557;
									}
									eRace race = this.oMEccAeBG40.Race;
									if (161542 - 569683 == -408140)
									{
										goto IL_557;
									}
									if (race == eRace.Tails)
									{
										if (266151 - 375122 == -108970)
										{
											goto IL_557;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_2E4;
										}
										if (121303 - 244339 != -123036)
										{
											goto IL_557;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (67156 - 166798 != -99642)
											{
												goto IL_557;
											}
											goto IL_2E4;
										}
										goto IL_15B;
										IL_2E4:
										flag = false;
										if (249144 - 357713 == -108568)
										{
											goto IL_557;
										}
									}
									else if (race == eRace.Plants)
									{
										if (207187 - 427981 != -220794)
										{
											goto IL_557;
										}
										flag = false;
										if (183561 - 169251 != 14310)
										{
											goto IL_557;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (32433 - 365187 == -332753)
										{
											goto IL_557;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_10D;
										}
										if (249068 - 387580 == -138511)
										{
											goto IL_557;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (116018 - 582223 != -466205)
											{
												goto IL_557;
											}
											goto IL_10D;
										}
										goto IL_15B;
										IL_10D:
										flag = false;
										if (206011 - 470982 != -264971)
										{
											goto IL_557;
										}
									}
									else if (race == eRace.Robots)
									{
										if (113046 - 408894 == -295847)
										{
											goto IL_557;
										}
										flag = true;
										if (36916 - 460330 != -423414)
										{
											goto IL_557;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (69168 - 79420 != -10252)
										{
											goto IL_557;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_F1;
										}
										if (269153 - 561391 != -292238)
										{
											goto IL_557;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_F1;
										}
										if (153483 - 28490 != 124993)
										{
											goto IL_557;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (89143 - 16322 != 72821)
											{
												goto IL_557;
											}
											goto IL_F1;
										}
										goto IL_15B;
										IL_F1:
										flag = false;
										if (218817 - 289734 == -70916)
										{
											goto IL_557;
										}
									}
									else if (race == eRace.Structure)
									{
										if (257385 - 400380 != -142995)
										{
											goto IL_557;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (44925 - 544941 == -500015)
											{
												goto IL_557;
											}
											flag = false;
											if (292696 - 258653 != 34043)
											{
												goto IL_557;
											}
										}
									}
									IL_15B:
									if (flag)
									{
										if (187202 - 157177 != 30025)
										{
											goto IL_557;
										}
										if (characterControl.hp > 0)
										{
											if (269744 - 302986 != -33242)
											{
												goto IL_557;
											}
											if (characterControl.recieveTarget)
											{
												if (400 - 343212 != -342812)
												{
													goto IL_557;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (124915 - 505751 == -380835)
													{
														goto IL_557;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (108519 - 578551 != -470032)
														{
															goto IL_557;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (224917 - 117099 == 107819)
														{
															goto IL_557;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (118457 - 425753 == -307295)
															{
																goto IL_557;
															}
															this.oMEccAeBG40.myAttackTarget = gameObject;
															if (167242 - 154378 == 12865)
															{
																goto IL_557;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (182866 - 390703 != -207837)
															{
																goto IL_557;
															}
															this.oMEccAeBG40.addHate(characterControl.ActorNr, 5);
															if (59270 - 564313 == -505042)
															{
																goto IL_557;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (208743 - 67889 != 140854)
															{
																goto IL_557;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (61897 - 307891 != -245994)
															{
																goto IL_557;
															}
															if (num < (float)60)
															{
																if (182845 - 93700 == 89146)
																{
																	goto IL_557;
																}
																if (characterControl.hp > 0)
																{
																	if (58818 - 352207 == -293388)
																	{
																		goto IL_557;
																	}
																	this.oMEccAeBG40.myAttackTarget = gameObject;
																	if (139288 - 478508 == -339219)
																	{
																		goto IL_557;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (146304 - 552230 == -405925)
																	{
																		goto IL_557;
																	}
																	this.oMEccAeBG40.addHate(characterControl.ActorNr, 5);
																	if (74449 - 317850 == -243400)
																	{
																		goto IL_557;
																	}
																}
															}
														}
														if (this.oMEccAeBG40.myAttackTarget)
														{
															if (170258 - 341073 != -170815)
															{
																goto IL_557;
															}
															this.oMEccAeBG40.isAlert = true;
															if (278117 - 129595 != 148522)
															{
																goto IL_557;
															}
															this.vrOccWFra29 = Time.time;
															if (135401 - 4790 != 130611)
															{
																goto IL_557;
															}
														}
													}
												}
											}
										}
									}
								}
								if (204673 - 324007 != -119333)
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

	// Token: 0x06004D79 RID: 19833 RVA: 0x0098A9CC File Offset: 0x00988BCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004D7A RID: 19834 RVA: 0x0098A9D0 File Offset: 0x00988BD0
	internal static bool zEZTPc50zvnwl31IyJcq()
	{
		return true;
	}

	// Token: 0x06004D7B RID: 19835 RVA: 0x0098A9D4 File Offset: 0x00988BD4
	internal static bool M8D2R15ba9xc6AAZ50Pa()
	{
		return false;
	}

	// Token: 0x040057A4 RID: 22436
	private CharacterControl oMEccAeBG40;

	// Token: 0x040057A5 RID: 22437
	private PirateCrawfish UuAcc93ymut;

	// Token: 0x040057A6 RID: 22438
	public string AI_state;

	// Token: 0x040057A7 RID: 22439
	private float vrOccWFra29;

	// Token: 0x040057A8 RID: 22440
	private float phDccu0UQNE;

	// Token: 0x040057A9 RID: 22441
	private float UDGccyoCt6a;
}
