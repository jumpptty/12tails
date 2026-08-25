using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000452 RID: 1106
[Serializable]
public class IceGod_AI : MonoBehaviour
{
	// Token: 0x060019AF RID: 6575 RVA: 0x0029A9EC File Offset: 0x00298BEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IceGod_AI()
	{
		if (216008 - 25433 != 190575)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (286256 - 493277 == -207021)
			{
				base..ctor();
				if (35901 - 459551 != -423649)
				{
					this.AI_state = "none";
					if (3743 - 24183 == -20440)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060019B0 RID: 6576 RVA: 0x0029AA88 File Offset: 0x00298C88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ksS2s0EyI6 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.D9I2HF5xgM = (IceGod)this.GetComponent(typeof(IceGod));
	}

	// Token: 0x060019B1 RID: 6577 RVA: 0x0029AAC0 File Offset: 0x00298CC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (156197 - 169994 != -13797)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (39286 - 550230 != -510944)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (91596 - 216941 != -125345)
				{
					continue;
				}
			}
			if (this.ksS2s0EyI6.isControlled)
			{
				break;
			}
			if (66630 - 136679 == -70049)
			{
				this.AIControl();
				if (29212 - 593017 != -563804)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x0029AB8C File Offset: 0x00298D8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (58649 - 118215 != -59565)
		{
		}
		for (;;)
		{
			this.Hk02Z7lJHl = (float)0;
			if (107805 - 27158 == 80647)
			{
				if (this.ksS2s0EyI6.isMine)
				{
					if (289881 - 220939 == 68942)
					{
						if (this.ksS2s0EyI6.actionState != "standby")
						{
							if (255758 - 465374 != -209616)
							{
								continue;
							}
							if (this.ksS2s0EyI6.actionState != "run")
							{
								if (4107 - 81563 != -77456)
								{
									continue;
								}
								break;
							}
						}
						if (!this.ksS2s0EyI6.isAlert)
						{
							if (214010 - 442194 == -228184)
							{
								this.AI_idle(5f, 2f);
								if (142254 - 125523 == 16731)
								{
									this.AI_patrol(4f, 2f);
									if (43141 - 157191 == -114050)
									{
										this.AI_resetTimer();
										if (281496 - 204058 != 77439)
										{
											this.AI_visionCheck();
											if (85919 - 54641 == 31278)
											{
												if (!this.ksS2s0EyI6.myAttackTarget)
												{
													break;
												}
												if (124138 - 402077 == -277939)
												{
													this.ksS2s0EyI6.isAlert = true;
													if (179414 - 310690 != -131275)
													{
														this.fIb27Eta6N = Time.time;
														if (145141 - 105369 != 39773)
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
							if (67119 - 355489 == -288370)
							{
								this.AI_idle(3f, 1f);
								if (234686 - 460771 != -226084)
								{
									this.AI_attack(12f, (float)0);
									if (248838 - 142600 != 106239)
									{
										this.AI_resetTimer();
										if (265114 - 325983 != -60868)
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
					if (this.ksS2s0EyI6.actionState != "standby")
					{
						if (164306 - 431232 == -266925)
						{
							continue;
						}
						if (this.ksS2s0EyI6.actionState != "run")
						{
							if (155518 - 380522 != -225004)
							{
								continue;
							}
							break;
						}
					}
					float num = this.ksS2s0EyI6.moveSpeed;
					if (143753 - 199099 == -55346)
					{
						float runSpeed = this.ksS2s0EyI6.runSpeed;
						if (48140 - 19860 != 28281)
						{
							Vector3 vector = default(Vector3);
							if (157835 - 32578 == 125257)
							{
								Vector3 vector2 = Vector3.zero;
								if (7625 - 592231 == -584606)
								{
									if ((this.ksS2s0EyI6.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (56589 - 134483 != -77894)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.ksS2s0EyI6.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (24668 - 276042 != -251374)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (21013 - 233958 == -212944)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (161455 - 549452 == -387996)
											{
												continue;
											}
											num = (float)0;
											if (253335 - 231238 == 22098)
											{
												continue;
											}
											this.transform.position = this.ksS2s0EyI6.nPosition;
											if (197672 - 759 != 196913)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (44787 - 596326 == -551538)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (83272 - 378450 == -295177)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (189166 - 373215 == -184048)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (164297 - 180926 != -16629)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (284632 - 536676 == -252043)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (62948 - 491819 == -428870)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (210829 - 144105 != 66724)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (233397 - 129184 == 104214)
											{
												continue;
											}
										}
									}
									this.ksS2s0EyI6.vMovement = vector2;
									if (55122 - 439191 == -384069)
									{
										this.ksS2s0EyI6.moveSpeed = num;
										if (43693 - 168676 != -124982)
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

	// Token: 0x060019B3 RID: 6579 RVA: 0x0029B204 File Offset: 0x00299404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (217138 - 117478 != 99661)
		{
		}
		do
		{
			if (Time.time - this.fIb27Eta6N >= this.Hk02Z7lJHl)
			{
				if (33374 - 565732 == -532357)
				{
					continue;
				}
				if (Time.time - this.fIb27Eta6N < this.Hk02Z7lJHl + mTime)
				{
					if (255336 - 44777 == 210560)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (213383 - 279396 != -66013)
						{
							continue;
						}
						this.AI_state = "idle";
						if (155912 - 303915 != -148003)
						{
							continue;
						}
						this.fIb27Eta6N -= UnityEngine.Random.Range((float)0, rTimer);
						if (233676 - 73963 == 159714)
						{
							continue;
						}
						this.ksS2s0EyI6.vDirection = Vector3.zero;
						if (26250 - 552092 != -525842)
						{
							continue;
						}
						this.ksS2s0EyI6.vMovement = this.transform.forward;
						if (239482 - 559784 != -320302)
						{
							continue;
						}
						this.ksS2s0EyI6.actionState = "standby";
						if (197437 - 438124 == -240686)
						{
							continue;
						}
					}
					this.ksS2s0EyI6.moveSpeed = Mathf.Lerp(this.ksS2s0EyI6.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (168303 - 563580 != -395277)
					{
						continue;
					}
					if (this.ksS2s0EyI6.moveSpeed < 0.1f * this.ksS2s0EyI6.runSpeed)
					{
						if (298495 - 307855 == -9359)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (50556 - 262093 != -211537)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (90057 - 162216 == -72158)
						{
							continue;
						}
						this.ksS2s0EyI6.moveSpeed = (float)0;
						if (170382 - 53992 != 116390)
						{
							continue;
						}
					}
				}
			}
			this.Hk02Z7lJHl += mTime;
		}
		while (103136 - 556386 != -453250);
	}

	// Token: 0x060019B4 RID: 6580 RVA: 0x0029B4C8 File Offset: 0x002996C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (191757 - 323991 != -132233)
		{
		}
		do
		{
			if (Time.time - this.fIb27Eta6N >= this.Hk02Z7lJHl)
			{
				if (50108 - 358103 == -307994)
				{
					continue;
				}
				if (Time.time - this.fIb27Eta6N < this.Hk02Z7lJHl + mTime)
				{
					if (294891 - 457575 != -162684)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (283965 - 53019 == 230947)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (213044 - 486528 == -273483)
						{
							continue;
						}
						this.fIb27Eta6N -= UnityEngine.Random.Range((float)0, rTimer);
						if (7604 - 489550 == -481945)
						{
							continue;
						}
						this.ksS2s0EyI6.vDirection = this.ksS2s0EyI6.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (145882 - 343343 != -197461)
						{
							continue;
						}
						this.ksS2s0EyI6.vDirection.y = this.transform.position.y;
						if (14288 - 345506 != -331218)
						{
							continue;
						}
						this.ksS2s0EyI6.vMovement = (this.ksS2s0EyI6.vDirection - this.transform.position).normalized;
						if (52571 - 399019 != -346448)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.ksS2s0EyI6.vMovement);
						if (266955 - 104966 == 161990)
						{
							continue;
						}
						this.ksS2s0EyI6.actionState = "run";
						if (154324 - 19302 == 135023)
						{
							continue;
						}
						this.animation.Play("run");
						if (82753 - 153705 == -70951)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (80830 - 557436 != -476606)
						{
							continue;
						}
					}
					this.ksS2s0EyI6.moveSpeed = Mathf.Lerp(this.ksS2s0EyI6.moveSpeed, this.ksS2s0EyI6.runSpeed, (float)4 * Time.deltaTime);
					if (216194 - 113898 == 102297)
					{
						continue;
					}
				}
			}
			this.Hk02Z7lJHl += mTime;
		}
		while (251082 - 330290 == -79207);
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x0029B7D0 File Offset: 0x002999D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (293593 - 234808 != 58785)
		{
		}
		do
		{
			if (Time.time - this.fIb27Eta6N >= this.Hk02Z7lJHl)
			{
				if (279675 - 202783 == 76893)
				{
					continue;
				}
				if (Time.time - this.fIb27Eta6N < this.Hk02Z7lJHl + mTime)
				{
					if (126041 - 461694 == -335652)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (161647 - 345116 != -183469)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (52880 - 92155 != -39275)
						{
							continue;
						}
						this.fIb27Eta6N = Time.time - mTime - this.Hk02Z7lJHl;
						if (245808 - 5462 == 240347)
						{
							continue;
						}
						this.ksS2s0EyI6.vDirection = Vector3.zero;
						if (170721 - 179454 != -8733)
						{
							continue;
						}
						this.ksS2s0EyI6.vMovement = this.transform.forward;
						if (140111 - 339337 != -199226)
						{
							continue;
						}
						this.ksS2s0EyI6.actionState = "standby";
						if (48551 - 76051 == -27499)
						{
							continue;
						}
						this.ksS2s0EyI6.myAttackTarget = this.ksS2s0EyI6.getHateTarget(5, 50);
						if (118189 - 148289 != -30100)
						{
							continue;
						}
						if (!this.ksS2s0EyI6.myAttackTarget)
						{
							if (46881 - 364399 != -317518)
							{
								continue;
							}
							this.ksS2s0EyI6.isAlert = false;
							if (200450 - 320785 != -120335)
							{
								continue;
							}
							this.fIb27Eta6N = Time.time;
							if (263307 - 80602 != 182705)
							{
								continue;
							}
							this.ksS2s0EyI6.myAttackTarget = null;
							if (181967 - 583637 == -401669)
							{
								continue;
							}
							this.ksS2s0EyI6.mOriginalPosition = this.transform.position;
							if (296086 - 218176 != 77910)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.ksS2s0EyI6.myAttackTarget;
							if (173883 - 75182 != 98701)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (174834 - 32426 != 142408)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (192936 - 433861 != -240925)
								{
									continue;
								}
								this.ksS2s0EyI6.isAlert = false;
								if (219697 - 6445 == 213253)
								{
									continue;
								}
								this.fIb27Eta6N = Time.time;
								if (277979 - 362572 == -84592)
								{
									continue;
								}
								this.ksS2s0EyI6.myAttackTarget = null;
								if (156686 - 459968 != -303282)
								{
									continue;
								}
							}
							else
							{
								this.ksS2s0EyI6.vDirection = myAttackTarget.transform.position;
								if (133064 - 189562 != -56498)
								{
									continue;
								}
								this.ksS2s0EyI6.vDirection.y = this.transform.position.y;
								if (197335 - 437834 != -240499)
								{
									continue;
								}
								this.ksS2s0EyI6.vMovement = (this.ksS2s0EyI6.vDirection - this.transform.position).normalized;
								if (283348 - 294010 != -10662)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ksS2s0EyI6.vMovement);
								if (3965 - 378991 != -375026)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Hk02Z7lJHl += mTime;
		}
		while (64485 - 86694 == -22208);
	}

	// Token: 0x060019B6 RID: 6582 RVA: 0x0029BC80 File Offset: 0x00299E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (109857 - 168974 != -59117)
		{
		}
		do
		{
			if (Time.time - this.fIb27Eta6N >= this.Hk02Z7lJHl)
			{
				if (138782 - 523375 != -384593)
				{
					continue;
				}
				if (Time.time - this.fIb27Eta6N < this.Hk02Z7lJHl + mTime)
				{
					if (29236 - 5326 == 23911)
					{
						continue;
					}
					if (!this.ksS2s0EyI6.myAttackTarget)
					{
						if (24479 - 363073 != -338594)
						{
							continue;
						}
						this.fIb27Eta6N = Time.time - mTime - this.Hk02Z7lJHl;
						if (275943 - 532828 != -256885)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.ksS2s0EyI6.myAttackTarget;
						if (169251 - 445909 == -276657)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (158539 - 286571 != -128032)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (90185 - 300718 != -210533)
						{
							continue;
						}
						int tID = 0;
						if (174377 - 269800 != -95423)
						{
							continue;
						}
						if (characterControl)
						{
							if (184398 - 226289 != -41891)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (41101 - 251110 != -210009)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (238028 - 296906 == -58877)
						{
							continue;
						}
						if ((float)this.ksS2s0EyI6.hp < 0.45f * (float)this.ksS2s0EyI6.mhp)
						{
							if (60909 - 21008 == 39902)
							{
								continue;
							}
							if (this.ksS2s0EyI6.isTimeOut("frozenStorm") == (float)0)
							{
								if (118398 - 358393 == -239994)
								{
									continue;
								}
								this.fIb27Eta6N = Time.time - mTime - this.Hk02Z7lJHl;
								if (112789 - 168253 == -55463)
								{
									continue;
								}
								this.D9I2HF5xgM.StartCoroutine_Auto(this.D9I2HF5xgM.RPC_frozenStorm(this.transform.position, this.transform.forward, 0));
								if (78277 - 506928 != -428651)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (11302 - 50510 != -39208)
									{
										continue;
									}
									this.D9I2HF5xgM.ActionEvent("RPC_frozenStorm", this.transform.position, this.transform.forward, 0);
									if (270497 - 467180 != -196683)
									{
										continue;
									}
								}
								goto IL_948;
							}
						}
						if ((float)this.ksS2s0EyI6.hp < 0.65f * (float)this.ksS2s0EyI6.mhp)
						{
							if (116911 - 43776 != 73135)
							{
								continue;
							}
							if (this.ksS2s0EyI6.isTimeOut("summonIceDemon") == (float)0)
							{
								if (77987 - 146448 == -68460)
								{
									continue;
								}
								this.fIb27Eta6N = Time.time - mTime - this.Hk02Z7lJHl;
								if (26533 - 116316 == -89782)
								{
									continue;
								}
								this.D9I2HF5xgM.StartCoroutine_Auto(this.D9I2HF5xgM.RPC_summonIceDemon(this.transform.position, this.transform.forward, 0));
								if (14958 - 140001 != -125043)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (190457 - 415143 == -224685)
									{
										continue;
									}
									this.D9I2HF5xgM.ActionEvent("RPC_summonIceDemon", this.transform.position, this.transform.forward, 0);
									if (102016 - 462032 == -360015)
									{
										continue;
									}
								}
								goto IL_948;
							}
						}
						if (num > (float)8)
						{
							if (161147 - 417921 == -256773)
							{
								continue;
							}
							if (this.ksS2s0EyI6.isTimeOut("frozenBlade") == (float)0)
							{
								if (244425 - 150974 == 93452)
								{
									continue;
								}
								this.fIb27Eta6N = Time.time - mTime - this.Hk02Z7lJHl;
								if (43787 - 245921 == -202133)
								{
									continue;
								}
								this.D9I2HF5xgM.StartCoroutine_Auto(this.D9I2HF5xgM.RPC_frozenBlade(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
								if (4549 - 479437 != -474887)
								{
									if (PhotonClient.IsInitialized())
									{
										if (245005 - 517513 != -272508)
										{
											continue;
										}
										this.D9I2HF5xgM.ActionEvent("RPC_frozenBlade", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
										if (40882 - 229848 == -188965)
										{
											continue;
										}
									}
									goto IL_948;
								}
								continue;
							}
						}
						if (this.ksS2s0EyI6.isTimeOut("frozenBlast") == (float)0)
						{
							if (117757 - 187856 != -70099)
							{
								continue;
							}
							this.fIb27Eta6N = Time.time - mTime - this.Hk02Z7lJHl;
							if (255460 - 221441 != 34019)
							{
								continue;
							}
							this.D9I2HF5xgM.StartCoroutine_Auto(this.D9I2HF5xgM.RPC_frozenBlast(this.transform.position, vector, tID));
							if (230577 - 554025 == -323447)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (154860 - 196306 == -41445)
								{
									continue;
								}
								this.D9I2HF5xgM.ActionEvent("RPC_frozenBlast", this.transform.position, vector, tID);
								if (57377 - 364461 != -307084)
								{
									continue;
								}
							}
						}
						else
						{
							if (num < (float)4)
							{
								if (224175 - 142049 != 82126)
								{
									continue;
								}
								if (this.ksS2s0EyI6.isTimeOut("nAttack") == (float)0)
								{
									if (113835 - 303090 != -189255)
									{
										continue;
									}
									this.fIb27Eta6N = Time.time - mTime - this.Hk02Z7lJHl;
									if (164118 - 571578 == -407459)
									{
										continue;
									}
									this.D9I2HF5xgM.StartCoroutine_Auto(this.D9I2HF5xgM.RPC_nAttack(this.transform.position, vector, 0));
									if (109293 - 416376 != -307083)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (26875 - 187544 != -160669)
										{
											continue;
										}
										this.D9I2HF5xgM.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (269035 - 325895 != -56860)
										{
											continue;
										}
									}
									goto IL_948;
								}
							}
							this.AI_state = "attack";
							if (182378 - 533898 != -351520)
							{
								continue;
							}
							this.ksS2s0EyI6.vDirection = myAttackTarget.transform.position;
							if (130012 - 591355 == -461342)
							{
								continue;
							}
							this.ksS2s0EyI6.vDirection.y = this.transform.position.y;
							if (271178 - 11455 == 259724)
							{
								continue;
							}
							this.ksS2s0EyI6.vMovement = (this.ksS2s0EyI6.vDirection - this.transform.position).normalized;
							if (1427 - 506538 != -505111)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.ksS2s0EyI6.vMovement);
							if (166126 - 117664 != 48462)
							{
								continue;
							}
							this.ksS2s0EyI6.actionState = "run";
							if (77320 - 511635 == -434314)
							{
								continue;
							}
							this.animation.Play("run");
							if (5582 - 369519 == -363936)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (297441 - 534076 == -236634)
							{
								continue;
							}
							this.ksS2s0EyI6.moveSpeed = Mathf.Lerp(this.ksS2s0EyI6.moveSpeed, this.ksS2s0EyI6.runSpeed, (float)4 * Time.deltaTime);
							if (248816 - 377649 == -128832)
							{
								continue;
							}
						}
					}
				}
			}
			IL_948:
			this.Hk02Z7lJHl += mTime;
		}
		while (163905 - 477421 != -313516);
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x0029C6C8 File Offset: 0x0029A8C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (140025 - 172409 != -32384)
		{
		}
		while (Time.time - this.fIb27Eta6N > this.Hk02Z7lJHl)
		{
			if (102038 - 469154 != -367115)
			{
				this.AI_state = "none";
				if (257166 - 56595 == 200571)
				{
					this.fIb27Eta6N = Time.time;
					if (128638 - 78052 == 50586)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060019B8 RID: 6584 RVA: 0x0029C77C File Offset: 0x0029A97C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (173265 - 336734 != -163468)
		{
		}
		for (;;)
		{
			IL_148:
			if (this.XNy2CZighN > Time.time)
			{
				if (62957 - 275887 == -212930)
				{
					break;
				}
			}
			else
			{
				this.XNy2CZighN = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (275443 - 50050 == 225393)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (91294 - 589347 == -498053)
					{
						if (172212 - 538164 != -365951)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (232775 - 580133 == -347358)
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
									if (27336 - 460008 != -432672)
									{
										goto IL_148;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (244870 - 206952 == 37919)
									{
										goto IL_148;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (200170 - 518647 != -318477)
									{
										goto IL_148;
									}
									bool flag = true;
									if (274500 - 146851 != 127649)
									{
										goto IL_148;
									}
									eRace race = this.ksS2s0EyI6.Race;
									if (134581 - 267692 != -133111)
									{
										goto IL_148;
									}
									if (race == eRace.Tails)
									{
										if (35950 - 491975 == -456024)
										{
											goto IL_148;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_36B;
										}
										if (259347 - 409337 == -149989)
										{
											goto IL_148;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (75705 - 539201 != -463495)
											{
												goto IL_36B;
											}
											goto IL_148;
										}
										goto IL_3CD;
										IL_36B:
										flag = false;
										if (173429 - 8017 == 165413)
										{
											goto IL_148;
										}
									}
									else if (race == eRace.Plants)
									{
										if (23987 - 279430 != -255443)
										{
											goto IL_148;
										}
										flag = false;
										if (291546 - 107444 == 184103)
										{
											goto IL_148;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (64141 - 313697 != -249556)
										{
											goto IL_148;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_1A;
										}
										if (34748 - 573677 == -538928)
										{
											goto IL_148;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (89704 - 240810 != -151106)
											{
												goto IL_148;
											}
											goto IL_1A;
										}
										goto IL_3CD;
										IL_1A:
										flag = false;
										if (146144 - 196088 != -49944)
										{
											goto IL_148;
										}
									}
									else if (race == eRace.Robots)
									{
										if (88571 - 359109 != -270538)
										{
											goto IL_148;
										}
										flag = true;
										if (47297 - 467448 != -420151)
										{
											goto IL_148;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (200789 - 229019 != -28230)
										{
											goto IL_148;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_12C;
										}
										if (63964 - 88275 == -24310)
										{
											goto IL_148;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_12C;
										}
										if (61488 - 398016 != -336528)
										{
											goto IL_148;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (209831 - 163193 != 46638)
											{
												goto IL_148;
											}
											goto IL_12C;
										}
										goto IL_3CD;
										IL_12C:
										flag = false;
										if (268993 - 87583 == 181411)
										{
											goto IL_148;
										}
									}
									else if (race == eRace.Structure)
									{
										if (120131 - 491608 == -371476)
										{
											goto IL_148;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (284985 - 329754 == -44768)
											{
												goto IL_148;
											}
											flag = false;
											if (26997 - 363578 == -336580)
											{
												goto IL_148;
											}
										}
									}
									IL_3CD:
									if (flag)
									{
										if (122245 - 121435 != 810)
										{
											goto IL_148;
										}
										if (characterControl.hp > 0)
										{
											if (12168 - 538884 != -526716)
											{
												goto IL_148;
											}
											if (characterControl.recieveTarget)
											{
												if (178402 - 303499 == -125096)
												{
													goto IL_148;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (287507 - 322771 == -35263)
													{
														goto IL_148;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (27914 - 197041 != -169127)
														{
															goto IL_148;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (265870 - 286837 == -20966)
														{
															goto IL_148;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (142399 - 361079 != -218680)
															{
																goto IL_148;
															}
															this.ksS2s0EyI6.myAttackTarget = gameObject;
															if (281011 - 323526 != -42515)
															{
																goto IL_148;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (26003 - 393560 == -367556)
															{
																goto IL_148;
															}
															this.ksS2s0EyI6.addHate(characterControl.ActorNr, 5);
															if (85398 - 511454 == -426055)
															{
																goto IL_148;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (154894 - 117016 == 37879)
															{
																goto IL_148;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (79922 - 397320 == -317397)
															{
																goto IL_148;
															}
															if (num < (float)60)
															{
																if (203304 - 268805 != -65501)
																{
																	goto IL_148;
																}
																if (characterControl.hp > 0)
																{
																	if (108587 - 45059 != 63528)
																	{
																		goto IL_148;
																	}
																	this.ksS2s0EyI6.myAttackTarget = gameObject;
																	if (274792 - 593427 != -318635)
																	{
																		goto IL_148;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (281489 - 566842 == -285352)
																	{
																		goto IL_148;
																	}
																	this.ksS2s0EyI6.addHate(characterControl.ActorNr, 5);
																	if (277042 - 448163 != -171121)
																	{
																		goto IL_148;
																	}
																}
															}
														}
														if (this.ksS2s0EyI6.myAttackTarget)
														{
															if (49931 - 304386 != -254455)
															{
																goto IL_148;
															}
															this.ksS2s0EyI6.isAlert = true;
															if (76323 - 428250 != -351927)
															{
																goto IL_148;
															}
															this.fIb27Eta6N = Time.time;
															if (180095 - 488625 != -308530)
															{
																goto IL_148;
															}
														}
													}
												}
											}
										}
									}
								}
								if (167383 - 235308 == -67925)
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

	// Token: 0x060019B9 RID: 6585 RVA: 0x0029CF94 File Offset: 0x0029B194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x0029CF98 File Offset: 0x0029B198
	internal static bool PX2fqFnDNl5Bla8GcSu()
	{
		return true;
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x0029CF9C File Offset: 0x0029B19C
	internal static bool Eq2xNpnvMFmbU09uDfm()
	{
		return false;
	}

	// Token: 0x0400161C RID: 5660
	private CharacterControl ksS2s0EyI6;

	// Token: 0x0400161D RID: 5661
	private IceGod D9I2HF5xgM;

	// Token: 0x0400161E RID: 5662
	public string AI_state;

	// Token: 0x0400161F RID: 5663
	private float fIb27Eta6N;

	// Token: 0x04001620 RID: 5664
	private float Hk02Z7lJHl;

	// Token: 0x04001621 RID: 5665
	private float XNy2CZighN;
}
