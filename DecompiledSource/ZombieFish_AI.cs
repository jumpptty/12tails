using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DF4 RID: 3572
[Serializable]
public class ZombieFish_AI : MonoBehaviour
{
	// Token: 0x060050BA RID: 20666 RVA: 0x009E3A58 File Offset: 0x009E1C58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZombieFish_AI()
	{
		if (235965 - 198561 != 37404)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (60699 - 76106 != -15406)
			{
				base..ctor();
				if (139977 - 63289 == 76688)
				{
					this.AI_state = "none";
					if (296121 - 74016 == 222105)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060050BB RID: 20667 RVA: 0x009E3AF4 File Offset: 0x009E1CF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.h8lcQgbmoFj = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.LBLcQa9E1V3 = (ZombieFish)this.GetComponent(typeof(ZombieFish));
	}

	// Token: 0x060050BC RID: 20668 RVA: 0x009E3B2C File Offset: 0x009E1D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (97530 - 252147 != -154616)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (157141 - 65019 != 92122)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (73097 - 284260 != -211163)
				{
					continue;
				}
			}
			if (this.h8lcQgbmoFj.isControlled)
			{
				break;
			}
			if (114596 - 217760 == -103164)
			{
				this.AIControl();
				if (34008 - 106279 != -72270)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060050BD RID: 20669 RVA: 0x009E3BF8 File Offset: 0x009E1DF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (26632 - 396655 != -370023)
		{
		}
		for (;;)
		{
			this.dFJcQsmfcXO = (float)0;
			if (185247 - 166981 == 18266)
			{
				if (this.h8lcQgbmoFj.isMine)
				{
					if (111898 - 221753 != -109854)
					{
						if (this.h8lcQgbmoFj.actionState != "standby")
						{
							if (263643 - 212643 != 51000)
							{
								continue;
							}
							if (this.h8lcQgbmoFj.actionState != "run")
							{
								if (192604 - 323470 != -130866)
								{
									continue;
								}
								break;
							}
						}
						if (!this.h8lcQgbmoFj.isAlert)
						{
							if (62004 - 169319 != -107314)
							{
								this.AI_idle(3f, 2f);
								if (97625 - 109620 == -11995)
								{
									this.AI_patrol(1f, 1f);
									if (136799 - 195439 == -58640)
									{
										this.AI_resetTimer();
										if (275095 - 293373 != -18277)
										{
											this.AI_visionCheck();
											if (42857 - 118979 != -76121)
											{
												if (!this.h8lcQgbmoFj.myAttackTarget)
												{
													break;
												}
												if (153566 - 123589 != 29978)
												{
													this.h8lcQgbmoFj.isAlert = true;
													if (170345 - 176513 != -6167)
													{
														this.vkbcQ4dZW7E = Time.time;
														if (195411 - 493950 == -298539)
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
							if (203644 - 20133 == 183511)
							{
								this.AI_idle(1f, 1f);
								if (20125 - 325432 == -305307)
								{
									this.AI_attack(12f, (float)0);
									if (32391 - 246713 != -214321)
									{
										this.AI_resetTimer();
										if (117569 - 226251 != -108681)
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
					if (this.h8lcQgbmoFj.actionState != "standby")
					{
						if (91522 - 413552 == -322029)
						{
							continue;
						}
						if (this.h8lcQgbmoFj.actionState != "run")
						{
							if (12252 - 334150 != -321898)
							{
								continue;
							}
							break;
						}
					}
					float num = this.h8lcQgbmoFj.moveSpeed;
					if (298842 - 191064 == 107778)
					{
						float runSpeed = this.h8lcQgbmoFj.runSpeed;
						if (10262 - 559770 != -549507)
						{
							Vector3 vector = default(Vector3);
							if (83103 - 153186 == -70083)
							{
								Vector3 vector2 = Vector3.zero;
								if (8655 - 46668 != -38012)
								{
									if ((this.h8lcQgbmoFj.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (5797 - 51188 != -45391)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.h8lcQgbmoFj.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (64548 - 392381 == -327832)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (173834 - 11071 == 162764)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (55283 - 32379 != 22904)
											{
												continue;
											}
											num = (float)0;
											if (180055 - 491939 != -311884)
											{
												continue;
											}
											this.transform.position = this.h8lcQgbmoFj.nPosition;
											if (204077 - 61595 == 142483)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (263103 - 236925 != 26178)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (122312 - 353670 == -231357)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (141069 - 555296 == -414226)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (182136 - 550513 == -368376)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (280433 - 46904 == 233530)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (178919 - 63667 != 115252)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (66477 - 482803 == -416325)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (78555 - 401179 != -322624)
											{
												continue;
											}
										}
									}
									this.h8lcQgbmoFj.vMovement = vector2;
									if (188791 - 385327 == -196536)
									{
										this.h8lcQgbmoFj.moveSpeed = num;
										if (7693 - 279355 != -271661)
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

	// Token: 0x060050BE RID: 20670 RVA: 0x009E4270 File Offset: 0x009E2470
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (279934 - 354183 != -74249)
		{
		}
		do
		{
			if (Time.time - this.vkbcQ4dZW7E >= this.dFJcQsmfcXO)
			{
				if (76601 - 398451 == -321849)
				{
					continue;
				}
				if (Time.time - this.vkbcQ4dZW7E < this.dFJcQsmfcXO + mTime)
				{
					if (184190 - 120014 != 64176)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (113283 - 350205 != -236922)
						{
							continue;
						}
						this.AI_state = "idle";
						if (104789 - 228594 == -123804)
						{
							continue;
						}
						this.vkbcQ4dZW7E -= UnityEngine.Random.Range((float)0, rTimer);
						if (31783 - 70427 != -38644)
						{
							continue;
						}
						this.h8lcQgbmoFj.vDirection = Vector3.zero;
						if (272300 - 23616 == 248685)
						{
							continue;
						}
						this.h8lcQgbmoFj.vMovement = this.transform.forward;
						if (99817 - 197219 == -97401)
						{
							continue;
						}
						this.h8lcQgbmoFj.actionState = "standby";
						if (182744 - 384939 != -202195)
						{
							continue;
						}
					}
					this.h8lcQgbmoFj.moveSpeed = Mathf.Lerp(this.h8lcQgbmoFj.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (127483 - 298721 != -171238)
					{
						continue;
					}
					if (this.h8lcQgbmoFj.moveSpeed < 0.1f * this.h8lcQgbmoFj.runSpeed)
					{
						if (50028 - 34262 == 15767)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (188160 - 28405 != 159755)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (191648 - 306041 != -114393)
						{
							continue;
						}
						this.h8lcQgbmoFj.moveSpeed = (float)0;
						if (23885 - 542975 == -519089)
						{
							continue;
						}
					}
				}
			}
			this.dFJcQsmfcXO += mTime;
		}
		while (23436 - 18835 != 4601);
	}

	// Token: 0x060050BF RID: 20671 RVA: 0x009E4534 File Offset: 0x009E2734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (58535 - 389342 != -330807)
		{
		}
		do
		{
			if (Time.time - this.vkbcQ4dZW7E >= this.dFJcQsmfcXO)
			{
				if (61750 - 373023 == -311272)
				{
					continue;
				}
				if (Time.time - this.vkbcQ4dZW7E < this.dFJcQsmfcXO + mTime)
				{
					if (8314 - 448813 != -440499)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (155176 - 151822 == 3355)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (104498 - 327208 == -222709)
						{
							continue;
						}
						this.vkbcQ4dZW7E -= UnityEngine.Random.Range((float)0, rTimer);
						if (129805 - 202139 != -72334)
						{
							continue;
						}
						this.h8lcQgbmoFj.vDirection = this.h8lcQgbmoFj.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (48855 - 230586 == -181730)
						{
							continue;
						}
						this.h8lcQgbmoFj.vDirection.y = this.transform.position.y;
						if (273100 - 160530 != 112570)
						{
							continue;
						}
						this.h8lcQgbmoFj.vMovement = (this.h8lcQgbmoFj.vDirection - this.transform.position).normalized;
						if (31421 - 410660 == -379238)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.h8lcQgbmoFj.vMovement);
						if (212167 - 111399 == 100769)
						{
							continue;
						}
						this.h8lcQgbmoFj.actionState = "run";
						if (106606 - 324402 == -217795)
						{
							continue;
						}
						this.animation.Play("run");
						if (109921 - 456001 != -346080)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (217449 - 303618 == -86168)
						{
							continue;
						}
					}
					this.h8lcQgbmoFj.moveSpeed = Mathf.Lerp(this.h8lcQgbmoFj.moveSpeed, this.h8lcQgbmoFj.runSpeed, (float)4 * Time.deltaTime);
					if (291989 - 124897 == 167093)
					{
						continue;
					}
				}
			}
			this.dFJcQsmfcXO += mTime;
		}
		while (58079 - 360306 != -302227);
	}

	// Token: 0x060050C0 RID: 20672 RVA: 0x009E483C File Offset: 0x009E2A3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (175097 - 551454 != -376357)
		{
		}
		do
		{
			if (Time.time - this.vkbcQ4dZW7E >= this.dFJcQsmfcXO)
			{
				if (97160 - 346020 != -248860)
				{
					continue;
				}
				if (Time.time - this.vkbcQ4dZW7E < this.dFJcQsmfcXO + mTime)
				{
					if (220718 - 392220 == -171501)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (85820 - 113919 == -28098)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (20117 - 312788 == -292670)
						{
							continue;
						}
						this.vkbcQ4dZW7E = Time.time - mTime - this.dFJcQsmfcXO;
						if (243287 - 327561 == -84273)
						{
							continue;
						}
						this.h8lcQgbmoFj.vDirection = Vector3.zero;
						if (127618 - 274548 != -146930)
						{
							continue;
						}
						this.h8lcQgbmoFj.vMovement = this.transform.forward;
						if (290960 - 378172 != -87212)
						{
							continue;
						}
						this.h8lcQgbmoFj.actionState = "standby";
						if (18370 - 449246 != -430876)
						{
							continue;
						}
						this.h8lcQgbmoFj.myAttackTarget = this.h8lcQgbmoFj.getHateTarget(5, 50);
						if (297087 - 363206 != -66119)
						{
							continue;
						}
						if (!this.h8lcQgbmoFj.myAttackTarget)
						{
							if (14683 - 556513 == -541829)
							{
								continue;
							}
							this.h8lcQgbmoFj.isAlert = false;
							if (227153 - 564725 != -337572)
							{
								continue;
							}
							this.vkbcQ4dZW7E = Time.time;
							if (62442 - 166673 != -104231)
							{
								continue;
							}
							this.h8lcQgbmoFj.myAttackTarget = null;
							if (125967 - 62439 == 63529)
							{
								continue;
							}
							this.h8lcQgbmoFj.mOriginalPosition = this.transform.position;
							if (271723 - 232818 != 38905)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.h8lcQgbmoFj.myAttackTarget;
							if (180065 - 320752 == -140686)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (261658 - 285497 == -23838)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (168707 - 39577 == 129131)
								{
									continue;
								}
								this.h8lcQgbmoFj.isAlert = false;
								if (27722 - 108545 == -80822)
								{
									continue;
								}
								this.vkbcQ4dZW7E = Time.time;
								if (167256 - 509882 == -342625)
								{
									continue;
								}
								this.h8lcQgbmoFj.myAttackTarget = null;
								if (237869 - 319262 == -81392)
								{
									continue;
								}
							}
							else
							{
								this.h8lcQgbmoFj.vDirection = myAttackTarget.transform.position;
								if (298541 - 559944 == -261402)
								{
									continue;
								}
								this.h8lcQgbmoFj.vDirection.y = this.transform.position.y;
								if (188168 - 197577 != -9409)
								{
									continue;
								}
								this.h8lcQgbmoFj.vMovement = (this.h8lcQgbmoFj.vDirection - this.transform.position).normalized;
								if (45536 - 56097 != -10561)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.h8lcQgbmoFj.vMovement);
								if (45839 - 518125 == -472285)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.dFJcQsmfcXO += mTime;
		}
		while (80005 - 330703 != -250698);
	}

	// Token: 0x060050C1 RID: 20673 RVA: 0x009E4CEC File Offset: 0x009E2EEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (50950 - 477707 != -426756)
		{
		}
		do
		{
			if (Time.time - this.vkbcQ4dZW7E >= this.dFJcQsmfcXO)
			{
				if (239418 - 129884 != 109534)
				{
					continue;
				}
				if (Time.time - this.vkbcQ4dZW7E < this.dFJcQsmfcXO + mTime)
				{
					if (130756 - 487355 == -356598)
					{
						continue;
					}
					if (!this.h8lcQgbmoFj.myAttackTarget)
					{
						if (121130 - 399077 != -277947)
						{
							continue;
						}
						this.vkbcQ4dZW7E = Time.time - mTime - this.dFJcQsmfcXO;
						if (278244 - 225342 != 52902)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.h8lcQgbmoFj.myAttackTarget;
						if (155919 - 43685 != 112234)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (45886 - 476429 == -430542)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (92788 - 97565 != -4777)
						{
							continue;
						}
						if (156120 - 388219 != -232099)
						{
							continue;
						}
						if (characterControl)
						{
							if (82203 - 26425 != 55778)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (57115 - 212149 != -155034)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (181617 - 179246 == 2372)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (11917 - 165527 == -153609)
							{
								continue;
							}
							if (this.h8lcQgbmoFj.isTimeOut("nAttack") == (float)0)
							{
								if (4793 - 201210 != -196417)
								{
									continue;
								}
								this.vkbcQ4dZW7E = Time.time - mTime - this.dFJcQsmfcXO;
								if (151285 - 141861 != 9424)
								{
									continue;
								}
								this.LBLcQa9E1V3.StartCoroutine_Auto(this.LBLcQa9E1V3.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
								if (14678 - 176988 != -162310)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (62799 - 29619 == 33181)
									{
										continue;
									}
									this.LBLcQa9E1V3.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
									if (246430 - 194755 == 51676)
									{
										continue;
									}
								}
								goto IL_188;
							}
						}
						if (num < (float)5)
						{
							if (180109 - 1884 == 178226)
							{
								continue;
							}
							if (this.h8lcQgbmoFj.isTimeOut("cAttack") == (float)0)
							{
								if (5312 - 53626 != -48314)
								{
									continue;
								}
								this.vkbcQ4dZW7E = Time.time - mTime - this.dFJcQsmfcXO;
								if (144708 - 143216 == 1493)
								{
									continue;
								}
								this.LBLcQa9E1V3.StartCoroutine_Auto(this.LBLcQa9E1V3.RPC_cAttack(this.transform.position, vector, 0));
								if (276785 - 278456 != -1670)
								{
									if (PhotonClient.IsInitialized())
									{
										if (126527 - 7411 != 119116)
										{
											continue;
										}
										this.LBLcQa9E1V3.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
										if (81931 - 555947 == -474015)
										{
											continue;
										}
									}
									goto IL_188;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (142328 - 261815 != -119487)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (127771 - 424854 == -297082)
							{
								continue;
							}
							this.h8lcQgbmoFj.vDirection = myAttackTarget.transform.position;
							if (91284 - 228724 == -137439)
							{
								continue;
							}
							this.h8lcQgbmoFj.vDirection.y = this.transform.position.y;
							if (190607 - 463364 != -272757)
							{
								continue;
							}
							this.h8lcQgbmoFj.vMovement = (this.h8lcQgbmoFj.vDirection - this.transform.position).normalized;
							if (55532 - 436389 == -380856)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.h8lcQgbmoFj.vMovement);
							if (288103 - 455484 != -167381)
							{
								continue;
							}
							this.h8lcQgbmoFj.actionState = "run";
							if (267324 - 506569 != -239245)
							{
								continue;
							}
							this.animation.CrossFade("run");
							if (189650 - 399437 != -209787)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (74655 - 114389 == -39733)
							{
								continue;
							}
							this.h8lcQgbmoFj.moveSpeed = Mathf.Lerp(this.h8lcQgbmoFj.moveSpeed, this.h8lcQgbmoFj.runSpeed, (float)4 * Time.deltaTime);
							if (251636 - 178864 != 72772)
							{
								continue;
							}
						}
						else
						{
							this.h8lcQgbmoFj.vDirection = myAttackTarget.transform.position;
							if (93839 - 188630 == -94790)
							{
								continue;
							}
							this.h8lcQgbmoFj.vDirection.y = this.transform.position.y;
							if (233096 - 31661 != 201435)
							{
								continue;
							}
							this.h8lcQgbmoFj.vMovement = (this.h8lcQgbmoFj.vDirection - this.transform.position).normalized;
							if (3880 - 303068 != -299188)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.h8lcQgbmoFj.vMovement);
							if (22723 - 254886 != -232163)
							{
								continue;
							}
							this.h8lcQgbmoFj.actionState = "standby";
							if (60037 - 3296 != 56741)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (112527 - 323327 == -210799)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (55966 - 299476 != -243510)
							{
								continue;
							}
							this.h8lcQgbmoFj.moveSpeed = Mathf.Lerp(this.h8lcQgbmoFj.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (208192 - 335626 == -127433)
							{
								continue;
							}
						}
					}
				}
			}
			IL_188:
			this.dFJcQsmfcXO += mTime;
		}
		while (129543 - 367765 != -238222);
	}

	// Token: 0x060050C2 RID: 20674 RVA: 0x009E5568 File Offset: 0x009E3768
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (89150 - 74283 != 14867)
		{
		}
		while (Time.time - this.vkbcQ4dZW7E > this.dFJcQsmfcXO)
		{
			if (178966 - 182089 == -3123)
			{
				this.AI_state = "none";
				if (131334 - 204424 == -73090)
				{
					this.vkbcQ4dZW7E = Time.time;
					if (211275 - 205399 == 5876)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060050C3 RID: 20675 RVA: 0x009E561C File Offset: 0x009E381C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (272664 - 91521 != 181144)
		{
		}
		for (;;)
		{
			IL_35E:
			if (this.IMXcQHGUc2J > Time.time)
			{
				if (239726 - 164457 != 75270)
				{
					break;
				}
			}
			else
			{
				this.IMXcQHGUc2J = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (203099 - 544613 != -341513)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (208634 - 232170 == -23536)
					{
						if (69378 - 485173 != -415794)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (30972 - 303110 == -272138)
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
									if (270435 - 345131 == -74695)
									{
										goto IL_35E;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (3287 - 469925 != -466638)
									{
										goto IL_35E;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (113938 - 45532 == 68407)
									{
										goto IL_35E;
									}
									bool flag = true;
									if (262039 - 260142 != 1897)
									{
										goto IL_35E;
									}
									eRace race = this.h8lcQgbmoFj.Race;
									if (152590 - 301532 == -148941)
									{
										goto IL_35E;
									}
									if (race == eRace.Tails)
									{
										if (45578 - 25269 == 20310)
										{
											goto IL_35E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_3F4;
										}
										if (30311 - 56376 != -26065)
										{
											goto IL_35E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (264831 - 48096 != 216736)
											{
												goto IL_3F4;
											}
											goto IL_35E;
										}
										goto IL_1A4;
										IL_3F4:
										flag = false;
										if (14113 - 17969 == -3855)
										{
											goto IL_35E;
										}
									}
									else if (race == eRace.Plants)
									{
										if (126563 - 132724 == -6160)
										{
											goto IL_35E;
										}
										flag = false;
										if (238329 - 390679 == -152349)
										{
											goto IL_35E;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (184208 - 395843 != -211635)
										{
											goto IL_35E;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_7DE;
										}
										if (271157 - 570646 != -299489)
										{
											goto IL_35E;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (87298 - 429953 != -342654)
											{
												goto IL_7DE;
											}
											goto IL_35E;
										}
										goto IL_1A4;
										IL_7DE:
										flag = false;
										if (240867 - 268969 != -28102)
										{
											goto IL_35E;
										}
									}
									else if (race == eRace.Robots)
									{
										if (262367 - 151056 == 111312)
										{
											goto IL_35E;
										}
										flag = true;
										if (31488 - 495051 == -463562)
										{
											goto IL_35E;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (111382 - 420688 == -309305)
										{
											goto IL_35E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_489;
										}
										if (60986 - 125729 != -64743)
										{
											goto IL_35E;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_489;
										}
										if (84384 - 97581 == -13196)
										{
											goto IL_35E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (58485 - 279082 != -220596)
											{
												goto IL_489;
											}
											goto IL_35E;
										}
										goto IL_1A4;
										IL_489:
										flag = false;
										if (202087 - 524562 == -322474)
										{
											goto IL_35E;
										}
									}
									else if (race == eRace.Structure)
									{
										if (98922 - 253700 == -154777)
										{
											goto IL_35E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (292401 - 532042 == -239640)
											{
												goto IL_35E;
											}
											flag = false;
											if (250578 - 30261 == 220318)
											{
												goto IL_35E;
											}
										}
									}
									IL_1A4:
									if (flag)
									{
										if (246603 - 363737 != -117134)
										{
											goto IL_35E;
										}
										if (characterControl.hp > 0)
										{
											if (167527 - 93300 != 74227)
											{
												goto IL_35E;
											}
											if (characterControl.recieveTarget)
											{
												if (39899 - 11426 == 28474)
												{
													goto IL_35E;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (235369 - 325587 == -90217)
													{
														goto IL_35E;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (172454 - 341591 != -169137)
														{
															goto IL_35E;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (14021 - 492753 == -478731)
														{
															goto IL_35E;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (80435 - 581100 != -500665)
															{
																goto IL_35E;
															}
															this.h8lcQgbmoFj.myAttackTarget = gameObject;
															if (71142 - 233322 != -162180)
															{
																goto IL_35E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (120858 - 566624 != -445766)
															{
																goto IL_35E;
															}
															this.h8lcQgbmoFj.addHate(characterControl.ActorNr, 5);
															if (249131 - 381031 != -131900)
															{
																goto IL_35E;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (150236 - 545820 == -395583)
															{
																goto IL_35E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (54123 - 121433 != -67310)
															{
																goto IL_35E;
															}
															if (num < (float)60)
															{
																if (280175 - 436657 != -156482)
																{
																	goto IL_35E;
																}
																if (characterControl.hp > 0)
																{
																	if (247049 - 352701 != -105652)
																	{
																		goto IL_35E;
																	}
																	this.h8lcQgbmoFj.myAttackTarget = gameObject;
																	if (252994 - 306142 == -53147)
																	{
																		goto IL_35E;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (119234 - 396714 != -277480)
																	{
																		goto IL_35E;
																	}
																	this.h8lcQgbmoFj.addHate(characterControl.ActorNr, 5);
																	if (133684 - 562050 != -428366)
																	{
																		goto IL_35E;
																	}
																}
															}
														}
														if (this.h8lcQgbmoFj.myAttackTarget)
														{
															if (87680 - 391107 == -303426)
															{
																goto IL_35E;
															}
															this.h8lcQgbmoFj.isAlert = true;
															if (243522 - 23803 == 219720)
															{
																goto IL_35E;
															}
															this.vkbcQ4dZW7E = Time.time;
															if (253758 - 238382 == 15377)
															{
																goto IL_35E;
															}
														}
													}
												}
											}
										}
									}
								}
								if (150058 - 24412 != 125647)
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

	// Token: 0x060050C4 RID: 20676 RVA: 0x009E5E34 File Offset: 0x009E4034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060050C5 RID: 20677 RVA: 0x009E5E38 File Offset: 0x009E4038
	internal static bool Ljuq6X5eksp7AFjsmxFt()
	{
		return true;
	}

	// Token: 0x060050C6 RID: 20678 RVA: 0x009E5E3C File Offset: 0x009E403C
	internal static bool YWykyO5eG24J1lqiW2eJ()
	{
		return false;
	}

	// Token: 0x04005A32 RID: 23090
	private CharacterControl h8lcQgbmoFj;

	// Token: 0x04005A33 RID: 23091
	private ZombieFish LBLcQa9E1V3;

	// Token: 0x04005A34 RID: 23092
	public string AI_state;

	// Token: 0x04005A35 RID: 23093
	private float vkbcQ4dZW7E;

	// Token: 0x04005A36 RID: 23094
	private float dFJcQsmfcXO;

	// Token: 0x04005A37 RID: 23095
	private float IMXcQHGUc2J;
}
