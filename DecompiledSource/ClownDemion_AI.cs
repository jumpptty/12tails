using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E0C RID: 3596
[Serializable]
public class ClownDemion_AI : MonoBehaviour
{
	// Token: 0x06005145 RID: 20805 RVA: 0x009EF7D8 File Offset: 0x009ED9D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClownDemion_AI()
	{
		if (57071 - 208430 != -151358)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (25426 - 446541 != -421114)
			{
				base..ctor();
				if (153700 - 11597 == 142103)
				{
					this.AI_state = "none";
					if (267681 - 87733 == 179948)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005146 RID: 20806 RVA: 0x009EF874 File Offset: 0x009EDA74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.dbLceggbTHv = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.tCHceaD2F2e = (ClownDemion)this.GetComponent(typeof(ClownDemion));
	}

	// Token: 0x06005147 RID: 20807 RVA: 0x009EF8AC File Offset: 0x009EDAAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (217850 - 209263 != 8587)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (139821 - 590795 != -450974)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (231913 - 128465 != 103448)
				{
					continue;
				}
			}
			if (this.dbLceggbTHv.isControlled)
			{
				break;
			}
			if (5825 - 570269 != -564443)
			{
				this.AIControl();
				if (200033 - 250046 == -50013)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005148 RID: 20808 RVA: 0x009EF978 File Offset: 0x009EDB78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (283629 - 71360 != 212269)
		{
		}
		for (;;)
		{
			this.PRDcesIqn0a = (float)0;
			if (291134 - 124677 != 166458)
			{
				if (this.dbLceggbTHv.isMine)
				{
					if (288058 - 277150 == 10908)
					{
						if (this.dbLceggbTHv.actionState != "standby")
						{
							if (53216 - 384225 != -331009)
							{
								continue;
							}
							if (this.dbLceggbTHv.actionState != "run")
							{
								if (202783 - 473537 != -270754)
								{
									continue;
								}
								break;
							}
						}
						if (!this.dbLceggbTHv.isAlert)
						{
							if (260550 - 92225 != 168326)
							{
								this.AI_idle(3f, 1f);
								if (52788 - 158311 == -105523)
								{
									this.AI_patrol(1f, 0.25f);
									if (105238 - 99708 == 5530)
									{
										this.AI_resetTimer();
										if (35111 - 98398 != -63286)
										{
											this.AI_visionCheck();
											if (120357 - 475264 != -354906)
											{
												if (!this.dbLceggbTHv.myAttackTarget)
												{
													break;
												}
												if (243170 - 26417 != 216754)
												{
													this.dbLceggbTHv.isAlert = true;
													if (268173 - 76147 == 192026)
													{
														this.weqce4ZChCV = Time.time;
														if (81460 - 63176 != 18285)
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
							if (284961 - 406951 == -121990)
							{
								this.AI_idle(1f, 1f);
								if (194672 - 137 != 194536)
								{
									this.AI_attack(10f, (float)0);
									if (195853 - 577478 == -381625)
									{
										this.AI_resetTimer();
										if (299614 - 221963 == 77651)
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
					if (this.dbLceggbTHv.actionState != "standby")
					{
						if (235023 - 247294 != -12271)
						{
							continue;
						}
						if (this.dbLceggbTHv.actionState != "run")
						{
							if (242042 - 251448 != -9406)
							{
								continue;
							}
							break;
						}
					}
					float num = this.dbLceggbTHv.moveSpeed;
					if (72610 - 388471 != -315860)
					{
						float runSpeed = this.dbLceggbTHv.runSpeed;
						if (299787 - 257527 == 42260)
						{
							Vector3 vector = default(Vector3);
							if (111824 - 107780 != 4045)
							{
								Vector3 vector2 = Vector3.zero;
								if (57859 - 29811 != 28049)
								{
									if ((this.dbLceggbTHv.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (31803 - 501740 != -469937)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.dbLceggbTHv.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (277363 - 553928 == -276564)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (148034 - 551793 != -403759)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (149989 - 349970 != -199981)
											{
												continue;
											}
											num = (float)0;
											if (115885 - 566181 == -450295)
											{
												continue;
											}
											this.transform.position = this.dbLceggbTHv.nPosition;
											if (211613 - 479994 != -268381)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (287417 - 524785 != -237368)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (14884 - 533532 == -518647)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (273460 - 296641 == -23180)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (240562 - 580717 != -340155)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (264272 - 37772 == 226501)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (291533 - 2681 != 288852)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (148524 - 418373 != -269849)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (137610 - 543153 != -405543)
											{
												continue;
											}
										}
									}
									this.dbLceggbTHv.vMovement = vector2;
									if (281964 - 558486 != -276521)
									{
										this.dbLceggbTHv.moveSpeed = num;
										if (72484 - 103910 == -31426)
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

	// Token: 0x06005149 RID: 20809 RVA: 0x009EFFF0 File Offset: 0x009EE1F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (15866 - 286171 != -270305)
		{
		}
		do
		{
			if (Time.time - this.weqce4ZChCV >= this.PRDcesIqn0a)
			{
				if (232980 - 361016 == -128035)
				{
					continue;
				}
				if (Time.time - this.weqce4ZChCV < this.PRDcesIqn0a + mTime)
				{
					if (1186 - 443273 == -442086)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (158302 - 374500 == -216197)
						{
							continue;
						}
						this.AI_state = "idle";
						if (24055 - 147788 == -123732)
						{
							continue;
						}
						this.weqce4ZChCV -= UnityEngine.Random.Range((float)0, rTimer);
						if (61627 - 56741 != 4886)
						{
							continue;
						}
						this.dbLceggbTHv.vDirection = Vector3.zero;
						if (247148 - 196640 == 50509)
						{
							continue;
						}
						this.dbLceggbTHv.vMovement = this.transform.forward;
						if (203982 - 171315 != 32667)
						{
							continue;
						}
						this.dbLceggbTHv.actionState = "standby";
						if (81815 - 258355 == -176539)
						{
							continue;
						}
					}
					this.dbLceggbTHv.moveSpeed = Mathf.Lerp(this.dbLceggbTHv.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (10680 - 474181 != -463501)
					{
						continue;
					}
					if (this.dbLceggbTHv.moveSpeed < 0.1f * this.dbLceggbTHv.runSpeed)
					{
						if (273039 - 21696 == 251344)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (156551 - 373392 == -216840)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (4200 - 149515 != -145315)
						{
							continue;
						}
						this.dbLceggbTHv.moveSpeed = (float)0;
						if (210555 - 69801 == 140755)
						{
							continue;
						}
					}
				}
			}
			this.PRDcesIqn0a += mTime;
		}
		while (244045 - 14289 == 229757);
	}

	// Token: 0x0600514A RID: 20810 RVA: 0x009F02B4 File Offset: 0x009EE4B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (57950 - 264849 != -206898)
		{
		}
		do
		{
			if (Time.time - this.weqce4ZChCV >= this.PRDcesIqn0a)
			{
				if (19698 - 443123 != -423425)
				{
					continue;
				}
				if (Time.time - this.weqce4ZChCV < this.PRDcesIqn0a + mTime)
				{
					if (158417 - 557409 != -398992)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (91718 - 441323 != -349605)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (20374 - 297786 != -277412)
						{
							continue;
						}
						this.weqce4ZChCV -= UnityEngine.Random.Range((float)0, rTimer);
						if (178749 - 374493 != -195744)
						{
							continue;
						}
						this.dbLceggbTHv.vDirection = this.dbLceggbTHv.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (172327 - 172493 != -166)
						{
							continue;
						}
						this.dbLceggbTHv.vDirection.y = this.transform.position.y;
						if (39232 - 509449 != -470217)
						{
							continue;
						}
						this.dbLceggbTHv.vMovement = (this.dbLceggbTHv.vDirection - this.transform.position).normalized;
						if (264299 - 49413 == 214887)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.dbLceggbTHv.vMovement);
						if (273796 - 154185 == 119612)
						{
							continue;
						}
						this.dbLceggbTHv.actionState = "run";
						if (229886 - 120131 != 109755)
						{
							continue;
						}
						this.animation.Play("run");
						if (106579 - 456720 == -350140)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (277602 - 83288 != 194314)
						{
							continue;
						}
					}
					this.dbLceggbTHv.moveSpeed = Mathf.Lerp(this.dbLceggbTHv.moveSpeed, this.dbLceggbTHv.runSpeed, (float)4 * Time.deltaTime);
					if (197994 - 219437 == -21442)
					{
						continue;
					}
				}
			}
			this.PRDcesIqn0a += mTime;
		}
		while (175554 - 357163 == -181608);
	}

	// Token: 0x0600514B RID: 20811 RVA: 0x009F05BC File Offset: 0x009EE7BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (283951 - 596822 != -312870)
		{
		}
		do
		{
			if (Time.time - this.weqce4ZChCV >= this.PRDcesIqn0a)
			{
				if (271488 - 237296 != 34192)
				{
					continue;
				}
				if (Time.time - this.weqce4ZChCV < this.PRDcesIqn0a + mTime)
				{
					if (222373 - 18552 != 203821)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (262371 - 266584 != -4213)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (56133 - 562225 == -506091)
						{
							continue;
						}
						this.weqce4ZChCV = Time.time - mTime - this.PRDcesIqn0a;
						if (3949 - 70350 == -66400)
						{
							continue;
						}
						this.dbLceggbTHv.vDirection = Vector3.zero;
						if (205460 - 213860 != -8400)
						{
							continue;
						}
						this.dbLceggbTHv.vMovement = this.transform.forward;
						if (43055 - 54496 == -11440)
						{
							continue;
						}
						this.dbLceggbTHv.actionState = "standby";
						if (136984 - 442059 != -305075)
						{
							continue;
						}
						this.dbLceggbTHv.myAttackTarget = this.dbLceggbTHv.getRandomHateTarget(50);
						if (20656 - 154536 != -133880)
						{
							continue;
						}
						if (!this.dbLceggbTHv.myAttackTarget)
						{
							if (261579 - 482044 == -220464)
							{
								continue;
							}
							this.dbLceggbTHv.isAlert = false;
							if (242252 - 398270 != -156018)
							{
								continue;
							}
							this.weqce4ZChCV = Time.time;
							if (279620 - 540912 == -261291)
							{
								continue;
							}
							this.dbLceggbTHv.myAttackTarget = null;
							if (215233 - 435480 == -220246)
							{
								continue;
							}
							this.dbLceggbTHv.mOriginalPosition = this.transform.position;
							if (226060 - 86544 != 139517)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.dbLceggbTHv.myAttackTarget;
							if (21295 - 553320 != -532025)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (214689 - 461143 != -246454)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (49625 - 4491 != 45134)
								{
									continue;
								}
								this.dbLceggbTHv.isAlert = false;
								if (237313 - 93670 != 143643)
								{
									continue;
								}
								this.weqce4ZChCV = Time.time;
								if (9219 - 519182 == -509962)
								{
									continue;
								}
								this.dbLceggbTHv.myAttackTarget = null;
								if (4557 - 551193 == -546635)
								{
									continue;
								}
							}
							else
							{
								this.dbLceggbTHv.vDirection = myAttackTarget.transform.position;
								if (2251 - 70653 == -68401)
								{
									continue;
								}
								this.dbLceggbTHv.vDirection.y = this.transform.position.y;
								if (24045 - 176615 != -152570)
								{
									continue;
								}
								this.dbLceggbTHv.vMovement = (this.dbLceggbTHv.vDirection - this.transform.position).normalized;
								if (80930 - 277838 == -196907)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.dbLceggbTHv.vMovement);
								if (107549 - 232897 != -125348)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.PRDcesIqn0a += mTime;
		}
		while (159297 - 545148 == -385850);
	}

	// Token: 0x0600514C RID: 20812 RVA: 0x009F0A6C File Offset: 0x009EEC6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (159922 - 64862 != 95060)
		{
		}
		do
		{
			if (Time.time - this.weqce4ZChCV >= this.PRDcesIqn0a)
			{
				if (251240 - 532232 != -280992)
				{
					continue;
				}
				if (Time.time - this.weqce4ZChCV < this.PRDcesIqn0a + mTime)
				{
					if (147898 - 328021 != -180123)
					{
						continue;
					}
					if (!this.dbLceggbTHv.myAttackTarget)
					{
						if (296252 - 100999 != 195253)
						{
							continue;
						}
						this.weqce4ZChCV = Time.time - mTime - this.PRDcesIqn0a;
						if (52235 - 439918 != -387682)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.dbLceggbTHv.myAttackTarget;
						if (171212 - 92826 == 78387)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (140758 - 136975 == 3784)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (283074 - 225593 != 57481)
						{
							continue;
						}
						int tID = 0;
						if (283107 - 273815 != 9292)
						{
							continue;
						}
						if (characterControl)
						{
							if (53060 - 268593 == -215532)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (24145 - 5876 != 18269)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (183975 - 217604 != -33629)
						{
							continue;
						}
						if (num < (float)4)
						{
							if (111551 - 121170 == -9618)
							{
								continue;
							}
							if (this.dbLceggbTHv.isTimeOut("cAttack") == (float)0)
							{
								if (97322 - 326386 != -229064)
								{
									continue;
								}
								this.weqce4ZChCV = Time.time - mTime - this.PRDcesIqn0a;
								if (75299 - 266305 == -191005)
								{
									continue;
								}
								this.tCHceaD2F2e.StartCoroutine_Auto(this.tCHceaD2F2e.RPC_cAttack(this.transform.position, vector.normalized, tID));
								if (182220 - 502600 != -320380)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (238556 - 392789 == -154232)
									{
										continue;
									}
									this.tCHceaD2F2e.ActionEvent("RPC_cAttack", this.transform.position, vector.normalized, tID);
									if (82876 - 17762 != 65114)
									{
										continue;
									}
								}
								goto IL_1A;
							}
						}
						if (num < (float)2)
						{
							if (187688 - 82730 == 104959)
							{
								continue;
							}
							if (this.dbLceggbTHv.isTimeOut("nAttack") == (float)0)
							{
								if (202329 - 162954 != 39375)
								{
									continue;
								}
								this.tCHceaD2F2e.StartCoroutine_Auto(this.tCHceaD2F2e.RPC_nAttack(this.transform.position, vector.normalized, tID));
								if (126568 - 592985 != -466416)
								{
									if (PhotonClient.IsInitialized())
									{
										if (165866 - 550680 != -384814)
										{
											continue;
										}
										this.tCHceaD2F2e.ActionEvent("RPC_nAttack", this.transform.position, vector.normalized, tID);
										if (241863 - 44667 == 197197)
										{
											continue;
										}
									}
									goto IL_1A;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (123609 - 435272 == -311662)
						{
							continue;
						}
						if (this.dbLceggbTHv.isTimeOut("nAttack") == (float)0)
						{
							if (133855 - 481580 != -347725)
							{
								continue;
							}
							this.dbLceggbTHv.vDirection = myAttackTarget.transform.position;
							if (154613 - 133112 != 21501)
							{
								continue;
							}
							this.dbLceggbTHv.vDirection.y = this.transform.position.y;
							if (129693 - 345421 == -215727)
							{
								continue;
							}
							this.dbLceggbTHv.vMovement = (this.dbLceggbTHv.vDirection - this.transform.position).normalized;
							if (82700 - 279515 != -196815)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.dbLceggbTHv.vMovement);
							if (59772 - 539430 != -479658)
							{
								continue;
							}
							this.dbLceggbTHv.actionState = "run";
							if (207324 - 319260 != -111936)
							{
								continue;
							}
							this.animation.Play("run");
							if (216845 - 218479 == -1633)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (51178 - 466507 == -415328)
							{
								continue;
							}
							this.dbLceggbTHv.moveSpeed = Mathf.Lerp(this.dbLceggbTHv.moveSpeed, this.dbLceggbTHv.runSpeed, (float)4 * Time.deltaTime);
							if (201357 - 525751 == -324393)
							{
								continue;
							}
						}
						else
						{
							this.dbLceggbTHv.vDirection = myAttackTarget.transform.position;
							if (247536 - 531338 == -283801)
							{
								continue;
							}
							this.dbLceggbTHv.vDirection.y = this.transform.position.y;
							if (41774 - 94155 != -52381)
							{
								continue;
							}
							this.dbLceggbTHv.vMovement = (this.dbLceggbTHv.vDirection - this.transform.position).normalized;
							if (188782 - 403425 == -214642)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.dbLceggbTHv.vMovement);
							if (236992 - 400966 != -163974)
							{
								continue;
							}
							this.dbLceggbTHv.actionState = "standby";
							if (78815 - 202647 == -123831)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (269160 - 405048 == -135887)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (177256 - 26257 == 151000)
							{
								continue;
							}
							this.dbLceggbTHv.moveSpeed = Mathf.Lerp(this.dbLceggbTHv.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (242560 - 173945 == 68616)
							{
								continue;
							}
						}
					}
				}
			}
			IL_1A:
			this.PRDcesIqn0a += mTime;
		}
		while (266669 - 481954 != -215285);
	}

	// Token: 0x0600514D RID: 20813 RVA: 0x009F129C File Offset: 0x009EF49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (223733 - 123302 != 100431)
		{
		}
		while (Time.time - this.weqce4ZChCV > this.PRDcesIqn0a)
		{
			if (50414 - 482886 == -432472)
			{
				this.AI_state = "none";
				if (215867 - 440450 != -224582)
				{
					this.weqce4ZChCV = Time.time;
					if (214327 - 394522 != -180194)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600514E RID: 20814 RVA: 0x009F1350 File Offset: 0x009EF550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (108635 - 557256 != -448620)
		{
		}
		for (;;)
		{
			IL_567:
			if (this.O9TceHltBkX > Time.time)
			{
				if (240499 - 36966 == 203533)
				{
					break;
				}
			}
			else
			{
				this.O9TceHltBkX = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (86324 - 173618 == -87294)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (2223 - 18114 != -15890)
					{
						if (164921 - 381470 == -216549)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (198528 - 584450 != -385921)
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
									if (149251 - 369857 == -220605)
									{
										goto IL_567;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (23808 - 322720 != -298912)
									{
										goto IL_567;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (156856 - 58079 == 98778)
									{
										goto IL_567;
									}
									bool flag = true;
									if (182796 - 488146 == -305349)
									{
										goto IL_567;
									}
									eRace race = this.dbLceggbTHv.Race;
									if (149187 - 15753 != 133434)
									{
										goto IL_567;
									}
									if (race == eRace.Tails)
									{
										if (142527 - 274463 != -131936)
										{
											goto IL_567;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5C;
										}
										if (240231 - 170217 != 70014)
										{
											goto IL_567;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (172198 - 384583 != -212385)
											{
												goto IL_567;
											}
											goto IL_5C;
										}
										goto IL_21E;
										IL_5C:
										flag = false;
										if (114093 - 284727 != -170634)
										{
											goto IL_567;
										}
									}
									else if (race == eRace.Plants)
									{
										if (197060 - 94330 == 102731)
										{
											goto IL_567;
										}
										flag = false;
										if (245232 - 144227 != 101005)
										{
											goto IL_567;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (187981 - 258516 != -70535)
										{
											goto IL_567;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_40;
										}
										if (52537 - 463097 == -410559)
										{
											goto IL_567;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (106951 - 489330 != -382379)
											{
												goto IL_567;
											}
											goto IL_40;
										}
										goto IL_21E;
										IL_40:
										flag = false;
										if (128913 - 100304 != 28609)
										{
											goto IL_567;
										}
									}
									else if (race == eRace.Robots)
									{
										if (133024 - 44041 != 88983)
										{
											goto IL_567;
										}
										flag = true;
										if (26774 - 287431 == -260656)
										{
											goto IL_567;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (13306 - 514459 == -501152)
										{
											goto IL_567;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_35C;
										}
										if (619 - 516015 != -515396)
										{
											goto IL_567;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_35C;
										}
										if (150918 - 434993 == -284074)
										{
											goto IL_567;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (257447 - 74466 != 182982)
											{
												goto IL_35C;
											}
											goto IL_567;
										}
										goto IL_21E;
										IL_35C:
										flag = false;
										if (258529 - 318255 == -59725)
										{
											goto IL_567;
										}
									}
									else if (race == eRace.Structure)
									{
										if (62350 - 30152 != 32198)
										{
											goto IL_567;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (39313 - 414335 != -375022)
											{
												goto IL_567;
											}
											flag = false;
											if (258163 - 368317 == -110153)
											{
												goto IL_567;
											}
										}
									}
									IL_21E:
									if (flag)
									{
										if (121809 - 522269 == -400459)
										{
											goto IL_567;
										}
										if (characterControl.hp > 0)
										{
											if (269697 - 36019 == 233679)
											{
												goto IL_567;
											}
											if (characterControl.recieveTarget)
											{
												if (16173 - 475227 == -459053)
												{
													goto IL_567;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (20522 - 273686 == -253163)
													{
														goto IL_567;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (54162 - 92253 != -38091)
														{
															goto IL_567;
														}
														this.dbLceggbTHv.myAttackTarget = gameObject;
														if (136369 - 361166 == -224796)
														{
															goto IL_567;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (13649 - 328310 == -314660)
														{
															goto IL_567;
														}
														this.dbLceggbTHv.addHate(characterControl.ActorNr, 50);
														if (8554 - 81067 != -72513)
														{
															goto IL_567;
														}
														this.dbLceggbTHv.isAlert = true;
														if (65701 - 206270 == -140568)
														{
															goto IL_567;
														}
														this.weqce4ZChCV = Time.time;
														if (153813 - 145660 != 8153)
														{
															goto IL_567;
														}
													}
												}
											}
										}
									}
								}
								if (108781 - 505569 != -396787)
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

	// Token: 0x0600514F RID: 20815 RVA: 0x009F19AC File Offset: 0x009EFBAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005150 RID: 20816 RVA: 0x009F19B0 File Offset: 0x009EFBB0
	internal static bool nSXfY65ezvsLvsgmT5yG()
	{
		return true;
	}

	// Token: 0x06005151 RID: 20817 RVA: 0x009F19B4 File Offset: 0x009EFBB4
	internal static bool DtDPJc5raG1DVKM4IoZl()
	{
		return false;
	}

	// Token: 0x04005AC6 RID: 23238
	private CharacterControl dbLceggbTHv;

	// Token: 0x04005AC7 RID: 23239
	private ClownDemion tCHceaD2F2e;

	// Token: 0x04005AC8 RID: 23240
	public string AI_state;

	// Token: 0x04005AC9 RID: 23241
	private float weqce4ZChCV;

	// Token: 0x04005ACA RID: 23242
	private float PRDcesIqn0a;

	// Token: 0x04005ACB RID: 23243
	private float O9TceHltBkX;
}
