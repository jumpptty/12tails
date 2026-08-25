using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AE0 RID: 2784
[Serializable]
public class DevilKaiserAI : MonoBehaviour
{
	// Token: 0x06003D86 RID: 15750 RVA: 0x007EE758 File Offset: 0x007EC958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DevilKaiserAI()
	{
		if (154115 - 269903 != -115787)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (254893 - 178541 == 76352)
			{
				base..ctor();
				if (130368 - 384591 != -254222)
				{
					this.AI_state = "none";
					if (262213 - 176677 == 85536)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003D87 RID: 15751 RVA: 0x007EE7F4 File Offset: 0x007EC9F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.x8yuwfZg5H = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.RmXuU9x3Wb = (DevilKaiser)this.GetComponent(typeof(DevilKaiser));
	}

	// Token: 0x06003D88 RID: 15752 RVA: 0x007EE82C File Offset: 0x007ECA2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (297003 - 402984 != -105981)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (271148 - 341702 == -70553)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (235825 - 84665 != 151160)
				{
					continue;
				}
			}
			if (this.x8yuwfZg5H.isControlled)
			{
				break;
			}
			if (62729 - 61466 == 1263)
			{
				this.AIControl();
				if (160657 - 317897 == -157240)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003D89 RID: 15753 RVA: 0x007EE8F8 File Offset: 0x007ECAF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (189033 - 541420 != -352386)
		{
		}
		for (;;)
		{
			this.xIHuETkMUb = (float)0;
			if (112579 - 433651 != -321071)
			{
				if (this.x8yuwfZg5H.isMine)
				{
					if (97175 - 432132 != -334956)
					{
						if (this.x8yuwfZg5H.actionState != "standby")
						{
							if (198051 - 358175 == -160123)
							{
								continue;
							}
							if (this.x8yuwfZg5H.actionState != "run")
							{
								if (136753 - 498184 != -361430)
								{
									break;
								}
								continue;
							}
						}
						if (!this.x8yuwfZg5H.isAlert)
						{
							if (61138 - 494326 == -433188)
							{
								this.AI_idle(3f, 1f);
								if (126825 - 131973 != -5147)
								{
									this.AI_patrol(1f, 0.25f);
									if (137069 - 494806 == -357737)
									{
										this.AI_resetTimer();
										if (86996 - 315170 == -228174)
										{
											this.AI_visionCheck();
											if (166858 - 77611 == 89247)
											{
												if (!this.x8yuwfZg5H.myAttackTarget)
												{
													break;
												}
												if (177650 - 33585 != 144066)
												{
													this.x8yuwfZg5H.isAlert = true;
													if (67959 - 253598 == -185639)
													{
														this.jC9uNAViOE = Time.time;
														if (279959 - 89788 == 190171)
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
							if (94447 - 332845 == -238398)
							{
								this.AI_idle(1f, 1f);
								if (109704 - 487229 == -377525)
								{
									this.AI_attack(10f, (float)0);
									if (172572 - 92822 != 79751)
									{
										this.AI_resetTimer();
										if (129857 - 537750 == -407893)
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
					if (this.x8yuwfZg5H.actionState != "standby")
					{
						if (121097 - 277467 == -156369)
						{
							continue;
						}
						if (this.x8yuwfZg5H.actionState != "run")
						{
							if (25832 - 452782 != -426949)
							{
								break;
							}
							continue;
						}
					}
					float num = this.x8yuwfZg5H.moveSpeed;
					if (200578 - 537518 == -336940)
					{
						float runSpeed = this.x8yuwfZg5H.runSpeed;
						if (268882 - 15243 != 253640)
						{
							Vector3 vector = default(Vector3);
							if (216503 - 484346 != -267842)
							{
								Vector3 vector2 = Vector3.zero;
								if (243208 - 322105 == -78897)
								{
									if ((this.x8yuwfZg5H.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (278520 - 260365 == 18156)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.x8yuwfZg5H.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (37693 - 338089 != -300396)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (271384 - 349480 == -78095)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (216597 - 585470 == -368872)
											{
												continue;
											}
											num = (float)0;
											if (93164 - 200772 != -107608)
											{
												continue;
											}
											this.transform.position = this.x8yuwfZg5H.nPosition;
											if (61820 - 285985 != -224165)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (171002 - 383778 == -212775)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (164268 - 291730 != -127462)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (215336 - 217893 == -2556)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (290181 - 164807 != 125374)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (51831 - 83868 != -32037)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (176874 - 254970 != -78096)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (175047 - 273837 == -98789)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (17294 - 239890 == -222595)
											{
												continue;
											}
										}
									}
									this.x8yuwfZg5H.vMovement = vector2;
									if (258860 - 456124 == -197264)
									{
										this.x8yuwfZg5H.moveSpeed = num;
										if (13002 - 562743 != -549740)
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

	// Token: 0x06003D8A RID: 15754 RVA: 0x007EEF70 File Offset: 0x007ED170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (2262 - 98666 != -96404)
		{
		}
		do
		{
			if (Time.time - this.jC9uNAViOE >= this.xIHuETkMUb)
			{
				if (39665 - 191963 != -152298)
				{
					continue;
				}
				if (Time.time - this.jC9uNAViOE < this.xIHuETkMUb + mTime)
				{
					if (14964 - 548548 != -533584)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (70512 - 54770 != 15742)
						{
							continue;
						}
						this.AI_state = "idle";
						if (97545 - 115959 != -18414)
						{
							continue;
						}
						this.jC9uNAViOE -= UnityEngine.Random.Range((float)0, rTimer);
						if (68810 - 302268 != -233458)
						{
							continue;
						}
						this.x8yuwfZg5H.vDirection = Vector3.zero;
						if (106883 - 524334 == -417450)
						{
							continue;
						}
						this.x8yuwfZg5H.vMovement = this.transform.forward;
						if (130942 - 365978 != -235036)
						{
							continue;
						}
						this.x8yuwfZg5H.actionState = "standby";
						if (148229 - 575846 != -427617)
						{
							continue;
						}
					}
					this.x8yuwfZg5H.moveSpeed = Mathf.Lerp(this.x8yuwfZg5H.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (112732 - 576750 == -464017)
					{
						continue;
					}
					if (this.x8yuwfZg5H.moveSpeed < 0.1f * this.x8yuwfZg5H.runSpeed)
					{
						if (58661 - 465086 != -406425)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (5236 - 152186 != -146950)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (19537 - 400515 != -380978)
						{
							continue;
						}
						this.x8yuwfZg5H.moveSpeed = (float)0;
						if (210980 - 459618 != -248638)
						{
							continue;
						}
					}
				}
			}
			this.xIHuETkMUb += mTime;
		}
		while (268861 - 64984 == 203878);
	}

	// Token: 0x06003D8B RID: 15755 RVA: 0x007EF234 File Offset: 0x007ED434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (79649 - 454289 != -374640)
		{
		}
		do
		{
			if (Time.time - this.jC9uNAViOE >= this.xIHuETkMUb)
			{
				if (209034 - 183816 != 25218)
				{
					continue;
				}
				if (Time.time - this.jC9uNAViOE < this.xIHuETkMUb + mTime)
				{
					if (250489 - 243580 == 6910)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (27362 - 450247 == -422884)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (251994 - 26411 != 225583)
						{
							continue;
						}
						this.jC9uNAViOE -= UnityEngine.Random.Range((float)0, rTimer);
						if (94590 - 484325 == -389734)
						{
							continue;
						}
						this.x8yuwfZg5H.vDirection = this.x8yuwfZg5H.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (276498 - 15595 != 260903)
						{
							continue;
						}
						this.x8yuwfZg5H.vDirection.y = this.transform.position.y;
						if (200166 - 486593 != -286427)
						{
							continue;
						}
						this.x8yuwfZg5H.vMovement = (this.x8yuwfZg5H.vDirection - this.transform.position).normalized;
						if (215159 - 235576 != -20417)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.x8yuwfZg5H.vMovement);
						if (86740 - 109955 == -23214)
						{
							continue;
						}
						this.x8yuwfZg5H.actionState = "run";
						if (36700 - 269378 == -232677)
						{
							continue;
						}
						this.animation.Play("run");
						if (4875 - 338609 == -333733)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (214532 - 587097 != -372565)
						{
							continue;
						}
					}
					this.x8yuwfZg5H.moveSpeed = Mathf.Lerp(this.x8yuwfZg5H.moveSpeed, this.x8yuwfZg5H.runSpeed, (float)4 * Time.deltaTime);
					if (170233 - 404606 != -234373)
					{
						continue;
					}
				}
			}
			this.xIHuETkMUb += mTime;
		}
		while (23914 - 388676 != -364762);
	}

	// Token: 0x06003D8C RID: 15756 RVA: 0x007EF53C File Offset: 0x007ED73C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (176753 - 457212 != -280459)
		{
		}
		do
		{
			if (Time.time - this.jC9uNAViOE >= this.xIHuETkMUb)
			{
				if (227367 - 580279 != -352912)
				{
					continue;
				}
				if (Time.time - this.jC9uNAViOE < this.xIHuETkMUb + mTime)
				{
					if (140091 - 373479 != -233388)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (235336 - 533058 != -297722)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (222338 - 589510 != -367172)
						{
							continue;
						}
						this.jC9uNAViOE = Time.time - mTime - this.xIHuETkMUb;
						if (67086 - 189488 != -122402)
						{
							continue;
						}
						this.x8yuwfZg5H.vDirection = Vector3.zero;
						if (38983 - 525210 != -486227)
						{
							continue;
						}
						this.x8yuwfZg5H.vMovement = this.transform.forward;
						if (189346 - 379395 == -190048)
						{
							continue;
						}
						this.x8yuwfZg5H.actionState = "standby";
						if (246191 - 545686 != -299495)
						{
							continue;
						}
						this.x8yuwfZg5H.myAttackTarget = this.x8yuwfZg5H.getHateTarget(5, 50);
						if (286348 - 332002 == -45653)
						{
							continue;
						}
						if (!this.x8yuwfZg5H.myAttackTarget)
						{
							if (130241 - 203681 != -73440)
							{
								continue;
							}
							this.x8yuwfZg5H.isAlert = false;
							if (55206 - 217330 != -162124)
							{
								continue;
							}
							this.jC9uNAViOE = Time.time;
							if (189811 - 260706 == -70894)
							{
								continue;
							}
							this.x8yuwfZg5H.myAttackTarget = null;
							if (292887 - 373467 != -80580)
							{
								continue;
							}
							this.x8yuwfZg5H.mOriginalPosition = this.transform.position;
							if (277710 - 241211 != 36500)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.x8yuwfZg5H.myAttackTarget;
							if (66459 - 2049 == 64411)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (116305 - 544495 == -428189)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (129666 - 579494 == -449827)
								{
									continue;
								}
								this.x8yuwfZg5H.isAlert = false;
								if (60988 - 251054 != -190066)
								{
									continue;
								}
								this.jC9uNAViOE = Time.time;
								if (46450 - 176351 != -129901)
								{
									continue;
								}
								this.x8yuwfZg5H.myAttackTarget = null;
								if (176656 - 398925 != -222269)
								{
									continue;
								}
							}
							else
							{
								this.x8yuwfZg5H.vDirection = myAttackTarget.transform.position;
								if (233539 - 394654 == -161114)
								{
									continue;
								}
								this.x8yuwfZg5H.vDirection.y = this.transform.position.y;
								if (94611 - 515435 != -420824)
								{
									continue;
								}
								this.x8yuwfZg5H.vMovement = (this.x8yuwfZg5H.vDirection - this.transform.position).normalized;
								if (92505 - 595659 == -503153)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.x8yuwfZg5H.vMovement);
								if (196209 - 245108 == -48898)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.xIHuETkMUb += mTime;
		}
		while (137190 - 390347 != -253157);
	}

	// Token: 0x06003D8D RID: 15757 RVA: 0x007EF9EC File Offset: 0x007EDBEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (271934 - 10064 != 261871)
		{
		}
		do
		{
			if (Time.time - this.jC9uNAViOE >= this.xIHuETkMUb)
			{
				if (148314 - 598496 == -450181)
				{
					continue;
				}
				if (Time.time - this.jC9uNAViOE < this.xIHuETkMUb + mTime)
				{
					if (138420 - 277787 != -139367)
					{
						continue;
					}
					if (!this.x8yuwfZg5H.myAttackTarget)
					{
						if (210672 - 128623 == 82050)
						{
							continue;
						}
						this.jC9uNAViOE = Time.time - mTime - this.xIHuETkMUb;
						if (80595 - 464098 != -383502)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.x8yuwfZg5H.myAttackTarget;
						if (14597 - 288435 != -273838)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (53053 - 314067 != -261014)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (224638 - 449152 == -224513)
						{
							continue;
						}
						int tID = 0;
						if (213115 - 329329 == -116213)
						{
							continue;
						}
						if (characterControl)
						{
							if (273236 - 305610 == -32373)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (62618 - 355026 == -292407)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (101359 - 63426 == 37934)
						{
							continue;
						}
						if (num < (float)24)
						{
							if (92407 - 551973 == -459565)
							{
								continue;
							}
							if (this.x8yuwfZg5H.isTimeOut("devilBeam") == (float)0)
							{
								if (40207 - 432068 != -391861)
								{
									continue;
								}
								this.jC9uNAViOE = Time.time - mTime - this.xIHuETkMUb;
								if (249699 - 324090 == -74390)
								{
									continue;
								}
								this.RmXuU9x3Wb.StartCoroutine_Auto(this.RmXuU9x3Wb.RPC_devilBeam1(this.transform.position, vector, tID));
								if (143750 - 121305 != 22445)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (232645 - 544820 != -312175)
									{
										continue;
									}
									this.RmXuU9x3Wb.ActionEvent("RPC_devilBeam1", this.transform.position, vector, tID);
									if (95528 - 390780 != -295252)
									{
										continue;
									}
								}
								goto IL_3C8;
							}
						}
						if (num < (float)3)
						{
							if (81417 - 126888 != -45471)
							{
								continue;
							}
							if (this.x8yuwfZg5H.isTimeOut("nAttack") == (float)0)
							{
								if (36964 - 350952 == -313987)
								{
									continue;
								}
								this.jC9uNAViOE = Time.time - mTime - this.xIHuETkMUb;
								if (149339 - 131495 != 17844)
								{
									continue;
								}
								this.RmXuU9x3Wb.StartCoroutine_Auto(this.RmXuU9x3Wb.RPC_nAttack(this.transform.position, vector, tID));
								if (50386 - 100638 != -50251)
								{
									if (PhotonClient.IsInitialized())
									{
										if (53323 - 599464 != -546141)
										{
											continue;
										}
										this.RmXuU9x3Wb.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
										if (6448 - 107977 == -101528)
										{
											continue;
										}
									}
									goto IL_3C8;
								}
								continue;
							}
						}
						if (num > (float)9)
						{
							if (225961 - 457578 != -231617)
							{
								continue;
							}
							if (num < (float)24)
							{
								if (215553 - 585705 == -370151)
								{
									continue;
								}
								if (this.x8yuwfZg5H.isTimeOut("devilCannon") == (float)0)
								{
									if (247003 - 542005 != -295002)
									{
										continue;
									}
									this.jC9uNAViOE = Time.time - mTime - this.xIHuETkMUb;
									if (217278 - 223940 == -6661)
									{
										continue;
									}
									this.RmXuU9x3Wb.StartCoroutine_Auto(this.RmXuU9x3Wb.RPC_devilCannon(this.transform.position, vector, tID));
									if (90725 - 445238 != -354513)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (14101 - 57959 != -43858)
										{
											continue;
										}
										this.RmXuU9x3Wb.ActionEvent("RPC_devilCannon", this.transform.position, vector, tID);
										if (298707 - 430496 == -131788)
										{
											continue;
										}
									}
									goto IL_3C8;
								}
							}
						}
						this.AI_state = "attack";
						if (20322 - 458647 == -438324)
						{
							continue;
						}
						this.x8yuwfZg5H.vDirection = myAttackTarget.transform.position;
						if (102337 - 595110 == -492772)
						{
							continue;
						}
						this.x8yuwfZg5H.vDirection.y = this.transform.position.y;
						if (205455 - 243746 != -38291)
						{
							continue;
						}
						this.x8yuwfZg5H.vMovement = (this.x8yuwfZg5H.vDirection - this.transform.position).normalized;
						if (259055 - 542527 != -283472)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.x8yuwfZg5H.vMovement);
						if (224866 - 71771 == 153096)
						{
							continue;
						}
						this.x8yuwfZg5H.actionState = "run";
						if (258765 - 273853 == -15087)
						{
							continue;
						}
						this.animation.Play("run");
						if (14782 - 195128 != -180346)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (10587 - 554696 != -544109)
						{
							continue;
						}
						this.x8yuwfZg5H.moveSpeed = Mathf.Lerp(this.x8yuwfZg5H.moveSpeed, this.x8yuwfZg5H.runSpeed, (float)4 * Time.deltaTime);
						if (122463 - 89881 != 32582)
						{
							continue;
						}
					}
				}
			}
			IL_3C8:
			this.xIHuETkMUb += mTime;
		}
		while (47747 - 161737 != -113990);
	}

	// Token: 0x06003D8E RID: 15758 RVA: 0x007F019C File Offset: 0x007EE39C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (272591 - 490476 != -217885)
		{
		}
		while (Time.time - this.jC9uNAViOE > this.xIHuETkMUb)
		{
			if (10622 - 4872 != 5751)
			{
				this.AI_state = "none";
				if (253862 - 198815 == 55047)
				{
					this.jC9uNAViOE = Time.time;
					if (184977 - 181712 == 3265)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003D8F RID: 15759 RVA: 0x007F0250 File Offset: 0x007EE450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (273779 - 92994 != 180785)
		{
		}
		for (;;)
		{
			IL_193:
			if (this.VXXuPNHyPL > Time.time)
			{
				if (158601 - 261428 != -102826)
				{
					break;
				}
			}
			else
			{
				this.VXXuPNHyPL = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (28996 - 94288 != -65291)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (144842 - 340482 != -195639 && 283157 - 154568 != 128590)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (6645 - 567084 == -560439)
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
								if (71537 - 236095 == -164557)
								{
									goto IL_193;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (59135 - 196228 == -137092)
								{
									goto IL_193;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (153621 - 8954 != 144667)
								{
									goto IL_193;
								}
								bool flag = true;
								if (91290 - 280289 != -188999)
								{
									goto IL_193;
								}
								eRace race = this.x8yuwfZg5H.Race;
								if (39162 - 209922 != -170760)
								{
									goto IL_193;
								}
								if (race == eRace.Tails)
								{
									if (296090 - 310595 != -14505)
									{
										goto IL_193;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_55C;
									}
									if (250427 - 242514 == 7914)
									{
										goto IL_193;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (233089 - 314812 != -81723)
										{
											goto IL_193;
										}
										goto IL_55C;
									}
									goto IL_4FA;
									IL_55C:
									flag = false;
									if (245244 - 109197 == 136048)
									{
										goto IL_193;
									}
								}
								else if (race == eRace.Plants)
								{
									if (76842 - 386005 == -309162)
									{
										goto IL_193;
									}
									flag = false;
									if (207463 - 236253 == -28789)
									{
										goto IL_193;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (165056 - 272301 == -107244)
									{
										goto IL_193;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_2F3;
									}
									if (53759 - 245420 == -191660)
									{
										goto IL_193;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (152809 - 191940 != -39130)
										{
											goto IL_2F3;
										}
										goto IL_193;
									}
									goto IL_4FA;
									IL_2F3:
									flag = false;
									if (68747 - 351220 != -282473)
									{
										goto IL_193;
									}
								}
								else if (race == eRace.Robots)
								{
									if (268821 - 335130 != -66309)
									{
										goto IL_193;
									}
									flag = true;
									if (10854 - 475426 != -464572)
									{
										goto IL_193;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (83254 - 205731 != -122477)
									{
										goto IL_193;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_51A;
									}
									if (116965 - 298332 == -181366)
									{
										goto IL_193;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_51A;
									}
									if (272895 - 564793 == -291897)
									{
										goto IL_193;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (211712 - 400633 != -188921)
										{
											goto IL_193;
										}
										goto IL_51A;
									}
									goto IL_4FA;
									IL_51A:
									flag = false;
									if (177953 - 251721 != -73768)
									{
										goto IL_193;
									}
								}
								else if (race == eRace.Structure)
								{
									if (78733 - 4470 != 74263)
									{
										goto IL_193;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (221849 - 305600 == -83750)
										{
											goto IL_193;
										}
										flag = false;
										if (83164 - 318203 != -235039)
										{
											goto IL_193;
										}
									}
								}
								IL_4FA:
								if (flag)
								{
									if (163136 - 263877 == -100740)
									{
										goto IL_193;
									}
									if (characterControl.hp > 0)
									{
										if (51643 - 22119 != 29524)
										{
											goto IL_193;
										}
										if (characterControl.recieveTarget)
										{
											if (240191 - 257207 != -17016)
											{
												goto IL_193;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (49833 - 192742 == -142908)
												{
													goto IL_193;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (271341 - 598813 != -327472)
													{
														goto IL_193;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (65652 - 305151 == -239498)
													{
														goto IL_193;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (2081 - 20417 != -18336)
														{
															goto IL_193;
														}
														this.x8yuwfZg5H.myAttackTarget = gameObject;
														if (181833 - 409693 == -227859)
														{
															goto IL_193;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (84128 - 331548 == -247419)
														{
															goto IL_193;
														}
														this.x8yuwfZg5H.addHate(characterControl.ActorNr, 5);
														if (55874 - 132513 == -76638)
														{
															goto IL_193;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (251227 - 352802 == -101574)
														{
															goto IL_193;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (50823 - 564800 != -513977)
														{
															goto IL_193;
														}
														if (num < (float)60)
														{
															if (103562 - 316511 == -212948)
															{
																goto IL_193;
															}
															if (characterControl.hp > 0)
															{
																if (286624 - 187612 != 99012)
																{
																	goto IL_193;
																}
																this.x8yuwfZg5H.myAttackTarget = gameObject;
																if (31213 - 220727 != -189514)
																{
																	goto IL_193;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (159458 - 317220 == -157761)
																{
																	goto IL_193;
																}
																this.x8yuwfZg5H.addHate(characterControl.ActorNr, 5);
																if (261466 - 460724 != -199258)
																{
																	goto IL_193;
																}
															}
														}
													}
													if (this.x8yuwfZg5H.myAttackTarget)
													{
														if (216921 - 354416 != -137495)
														{
															goto IL_193;
														}
														this.x8yuwfZg5H.isAlert = true;
														if (145507 - 67544 != 77963)
														{
															goto IL_193;
														}
														this.jC9uNAViOE = Time.time;
														if (267386 - 481220 == -213833)
														{
															goto IL_193;
														}
													}
												}
											}
										}
									}
								}
							}
							if (150806 - 146407 != 4400)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003D90 RID: 15760 RVA: 0x007F0A68 File Offset: 0x007EEC68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003D91 RID: 15761 RVA: 0x007F0A6C File Offset: 0x007EEC6C
	internal static bool zHa85T5LbDPJmvlv7bVL()
	{
		return true;
	}

	// Token: 0x06003D92 RID: 15762 RVA: 0x007F0A70 File Offset: 0x007EEC70
	internal static bool JBgZPf5LujacCmyE9uRH()
	{
		return false;
	}

	// Token: 0x04004ACF RID: 19151
	private CharacterControl x8yuwfZg5H;

	// Token: 0x04004AD0 RID: 19152
	private DevilKaiser RmXuU9x3Wb;

	// Token: 0x04004AD1 RID: 19153
	public string AI_state;

	// Token: 0x04004AD2 RID: 19154
	private float jC9uNAViOE;

	// Token: 0x04004AD3 RID: 19155
	private float xIHuETkMUb;

	// Token: 0x04004AD4 RID: 19156
	private float VXXuPNHyPL;
}
