using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E49 RID: 3657
[Serializable]
public class Mhaou_AI : MonoBehaviour
{
	// Token: 0x060052B7 RID: 21175 RVA: 0x00A169D8 File Offset: 0x00A14BD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mhaou_AI()
	{
		if (87832 - 8068 != 79765)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (24236 - 459967 == -435731)
			{
				base..ctor();
				if (121619 - 4161 != 117459)
				{
					this.AI_state = "none";
					if (92263 - 246796 == -154533)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060052B8 RID: 21176 RVA: 0x00A16A74 File Offset: 0x00A14C74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.pyOcIn3DQsi = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.D6LcIQNhW7r = (Mhaou)this.GetComponent(typeof(Mhaou));
	}

	// Token: 0x060052B9 RID: 21177 RVA: 0x00A16AAC File Offset: 0x00A14CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (239000 - 79665 != 159335)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (289634 - 411221 != -121587)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (165145 - 164997 == 149)
				{
					continue;
				}
			}
			if (this.pyOcIn3DQsi.isControlled)
			{
				break;
			}
			if (17397 - 543320 != -525922)
			{
				this.AIControl();
				if (247325 - 73597 == 173728)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060052BA RID: 21178 RVA: 0x00A16B78 File Offset: 0x00A14D78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (60410 - 276232 != -215822)
		{
		}
		for (;;)
		{
			this.MCScIIPTMos = (float)0;
			if (229241 - 352817 == -123576)
			{
				if (this.pyOcIn3DQsi.isMine)
				{
					if (203384 - 369756 != -166371)
					{
						if (this.pyOcIn3DQsi.actionState != "standby")
						{
							if (79519 - 300480 == -220960)
							{
								continue;
							}
							if (this.pyOcIn3DQsi.actionState != "run")
							{
								if (5670 - 372784 != -367113)
								{
									break;
								}
								continue;
							}
						}
						if (!this.pyOcIn3DQsi.isAlert)
						{
							if (273571 - 209654 == 63917)
							{
								this.AI_idle(3f, 1f);
								if (83169 - 139965 == -56796)
								{
									this.AI_patrol(1f, 0.25f);
									if (211061 - 123007 == 88054)
									{
										this.AI_resetTimer();
										if (32240 - 276683 == -244443)
										{
											this.AI_visionCheck();
											if (20722 - 67788 == -47066)
											{
												if (!this.pyOcIn3DQsi.myAttackTarget)
												{
													break;
												}
												if (258600 - 438097 != -179496)
												{
													this.pyOcIn3DQsi.isAlert = true;
													if (167027 - 120550 == 46477)
													{
														this.KoRcIeCncFE = Time.time;
														if (295066 - 174772 == 120294)
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
							if (286408 - 220147 != 66262)
							{
								this.AI_idle(3f, 1f);
								if (234973 - 24348 == 210625)
								{
									this.AI_attack(10f, (float)0);
									if (82078 - 364201 != -282122)
									{
										this.AI_resetTimer();
										if (25278 - 4411 == 20867)
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
					if (this.pyOcIn3DQsi.actionState != "standby")
					{
						if (183501 - 56773 != 126728)
						{
							continue;
						}
						if (this.pyOcIn3DQsi.actionState != "run")
						{
							if (137855 - 214983 != -77127)
							{
								break;
							}
							continue;
						}
					}
					float num = this.pyOcIn3DQsi.moveSpeed;
					if (235825 - 398970 == -163145)
					{
						float runSpeed = this.pyOcIn3DQsi.runSpeed;
						if (250589 - 589604 != -339014)
						{
							Vector3 vector = default(Vector3);
							if (150742 - 535051 == -384309)
							{
								Vector3 vector2 = Vector3.zero;
								if (112901 - 563850 == -450949)
								{
									if ((this.pyOcIn3DQsi.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (90966 - 345164 == -254197)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.pyOcIn3DQsi.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (154292 - 114962 != 39330)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (163968 - 168684 != -4716)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (154540 - 192649 == -38108)
											{
												continue;
											}
											num = (float)0;
											if (298599 - 306598 != -7999)
											{
												continue;
											}
											this.transform.position = this.pyOcIn3DQsi.nPosition;
											if (2873 - 330399 == -327525)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (283910 - 262316 != 21594)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (124326 - 416079 == -291752)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (94255 - 318078 != -223823)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (7710 - 84694 == -76983)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (231364 - 225825 == 5540)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (26217 - 378627 == -352409)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (247655 - 146948 == 100708)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (285067 - 319940 != -34873)
											{
												continue;
											}
										}
									}
									this.pyOcIn3DQsi.vMovement = vector2;
									if (112722 - 369388 != -256665)
									{
										this.pyOcIn3DQsi.moveSpeed = num;
										if (108966 - 433310 != -324343)
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

	// Token: 0x060052BB RID: 21179 RVA: 0x00A171F0 File Offset: 0x00A153F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (59261 - 443627 != -384366)
		{
		}
		do
		{
			if (Time.time - this.KoRcIeCncFE >= this.MCScIIPTMos)
			{
				if (234551 - 275701 == -41149)
				{
					continue;
				}
				if (Time.time - this.KoRcIeCncFE < this.MCScIIPTMos + mTime)
				{
					if (135279 - 333891 != -198612)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (151546 - 269593 != -118047)
						{
							continue;
						}
						this.AI_state = "idle";
						if (193922 - 399442 == -205519)
						{
							continue;
						}
						this.KoRcIeCncFE -= UnityEngine.Random.Range((float)0, rTimer);
						if (196199 - 498629 != -302430)
						{
							continue;
						}
						this.pyOcIn3DQsi.vDirection = Vector3.zero;
						if (10228 - 480886 == -470657)
						{
							continue;
						}
						this.pyOcIn3DQsi.vMovement = this.transform.forward;
						if (282074 - 98900 != 183174)
						{
							continue;
						}
						this.pyOcIn3DQsi.actionState = "standby";
						if (288933 - 389920 != -100987)
						{
							continue;
						}
					}
					this.pyOcIn3DQsi.moveSpeed = Mathf.Lerp(this.pyOcIn3DQsi.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (16811 - 323505 == -306693)
					{
						continue;
					}
					if (this.pyOcIn3DQsi.moveSpeed < 0.1f * this.pyOcIn3DQsi.runSpeed)
					{
						if (42060 - 547994 != -505934)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (53060 - 103127 == -50066)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (216078 - 406742 != -190664)
						{
							continue;
						}
						this.pyOcIn3DQsi.moveSpeed = (float)0;
						if (130389 - 483600 != -353211)
						{
							continue;
						}
					}
				}
			}
			this.MCScIIPTMos += mTime;
		}
		while (206320 - 453729 == -247408);
	}

	// Token: 0x060052BC RID: 21180 RVA: 0x00A174B4 File Offset: 0x00A156B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (162421 - 528734 != -366312)
		{
		}
		for (;;)
		{
			this.pyOcIn3DQsi.vDirection = followObject.transform.position;
			if (30044 - 220925 == -190881)
			{
				this.pyOcIn3DQsi.vDirection.y = this.transform.position.y;
				if (269399 - 543055 != -273655)
				{
					this.pyOcIn3DQsi.vMovement = (this.pyOcIn3DQsi.vDirection - this.transform.position).normalized;
					if (140101 - 324538 == -184437)
					{
						this.transform.rotation = Quaternion.LookRotation(this.pyOcIn3DQsi.vMovement);
						if (253206 - 458536 == -205330)
						{
							this.pyOcIn3DQsi.actionState = "run";
							if (241029 - 362854 == -121825)
							{
								this.animation.Play("run");
								if (175387 - 123705 != 51683)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (59151 - 580479 != -521327)
									{
										this.pyOcIn3DQsi.moveSpeed = Mathf.Lerp(this.pyOcIn3DQsi.moveSpeed, this.pyOcIn3DQsi.runSpeed, (float)4 * Time.deltaTime);
										if (277514 - 42138 == 235376)
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

	// Token: 0x060052BD RID: 21181 RVA: 0x00A1769C File Offset: 0x00A1589C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (126266 - 349384 != -223117)
		{
		}
		do
		{
			if (Time.time - this.KoRcIeCncFE >= this.MCScIIPTMos)
			{
				if (29475 - 320394 == -290918)
				{
					continue;
				}
				if (Time.time - this.KoRcIeCncFE < this.MCScIIPTMos + mTime)
				{
					if (229415 - 533794 != -304379)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (43901 - 460812 != -416911)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (160988 - 73477 == 87512)
						{
							continue;
						}
						this.KoRcIeCncFE -= UnityEngine.Random.Range((float)0, rTimer);
						if (166309 - 3758 == 162552)
						{
							continue;
						}
						this.pyOcIn3DQsi.vDirection = this.pyOcIn3DQsi.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (278915 - 125433 != 153482)
						{
							continue;
						}
						this.pyOcIn3DQsi.vDirection.y = this.transform.position.y;
						if (142141 - 315742 != -173601)
						{
							continue;
						}
						this.pyOcIn3DQsi.vMovement = (this.pyOcIn3DQsi.vDirection - this.transform.position).normalized;
						if (146534 - 222987 != -76453)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.pyOcIn3DQsi.vMovement);
						if (25943 - 144810 == -118866)
						{
							continue;
						}
						this.pyOcIn3DQsi.actionState = "run";
						if (114004 - 257388 == -143383)
						{
							continue;
						}
						this.animation.Play("run");
						if (69418 - 74662 == -5243)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (220731 - 226452 != -5721)
						{
							continue;
						}
					}
					this.pyOcIn3DQsi.moveSpeed = Mathf.Lerp(this.pyOcIn3DQsi.moveSpeed, this.pyOcIn3DQsi.runSpeed, (float)4 * Time.deltaTime);
					if (161523 - 548285 != -386762)
					{
						continue;
					}
				}
			}
			this.MCScIIPTMos += mTime;
		}
		while (199671 - 324560 == -124888);
	}

	// Token: 0x060052BE RID: 21182 RVA: 0x00A179A4 File Offset: 0x00A15BA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (232272 - 95031 != 137242)
		{
		}
		do
		{
			if (Time.time - this.KoRcIeCncFE >= this.MCScIIPTMos)
			{
				if (47062 - 174054 != -126992)
				{
					continue;
				}
				if (Time.time - this.KoRcIeCncFE < this.MCScIIPTMos + mTime)
				{
					if (141528 - 55052 == 86477)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (47485 - 289189 == -241703)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (241100 - 484154 != -243054)
						{
							continue;
						}
						this.KoRcIeCncFE = Time.time - mTime - this.MCScIIPTMos;
						if (149294 - 213963 != -64669)
						{
							continue;
						}
						this.pyOcIn3DQsi.vDirection = Vector3.zero;
						if (155217 - 498383 == -343165)
						{
							continue;
						}
						this.pyOcIn3DQsi.vMovement = this.transform.forward;
						if (67055 - 83118 != -16063)
						{
							continue;
						}
						this.pyOcIn3DQsi.actionState = "standby";
						if (151963 - 288454 != -136491)
						{
							continue;
						}
						this.pyOcIn3DQsi.myAttackTarget = this.pyOcIn3DQsi.getHateTarget(5, 50);
						if (175795 - 296415 != -120620)
						{
							continue;
						}
						if (!this.pyOcIn3DQsi.myAttackTarget)
						{
							if (261752 - 187701 != 74051)
							{
								continue;
							}
							this.pyOcIn3DQsi.isAlert = false;
							if (69265 - 5673 != 63592)
							{
								continue;
							}
							this.KoRcIeCncFE = Time.time;
							if (75802 - 379794 != -303992)
							{
								continue;
							}
							this.pyOcIn3DQsi.myAttackTarget = null;
							if (235993 - 562989 != -326996)
							{
								continue;
							}
							this.pyOcIn3DQsi.mOriginalPosition = this.transform.position;
							if (271300 - 81549 != 189752)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.pyOcIn3DQsi.myAttackTarget;
							if (71263 - 469709 == -398445)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (218692 - 583983 != -365291)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (275279 - 378073 == -102793)
								{
									continue;
								}
								this.pyOcIn3DQsi.isAlert = false;
								if (117380 - 420667 == -303286)
								{
									continue;
								}
								this.KoRcIeCncFE = Time.time;
								if (82736 - 267827 == -185090)
								{
									continue;
								}
								this.pyOcIn3DQsi.myAttackTarget = null;
								if (89471 - 462936 == -373464)
								{
									continue;
								}
							}
							else
							{
								this.pyOcIn3DQsi.vDirection = myAttackTarget.transform.position;
								if (168269 - 23060 != 145209)
								{
									continue;
								}
								this.pyOcIn3DQsi.vDirection.y = this.transform.position.y;
								if (191272 - 361034 != -169762)
								{
									continue;
								}
								this.pyOcIn3DQsi.vMovement = (this.pyOcIn3DQsi.vDirection - this.transform.position).normalized;
								if (150485 - 531084 == -380598)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.pyOcIn3DQsi.vMovement);
								if (167190 - 222867 == -55676)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.MCScIIPTMos += mTime;
		}
		while (203359 - 284610 == -81250);
	}

	// Token: 0x060052BF RID: 21183 RVA: 0x00A17E54 File Offset: 0x00A16054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (89606 - 91045 != -1438)
		{
		}
		do
		{
			if (Time.time - this.KoRcIeCncFE >= this.MCScIIPTMos)
			{
				if (229768 - 146818 != 82950)
				{
					continue;
				}
				if (Time.time - this.KoRcIeCncFE < this.MCScIIPTMos + mTime)
				{
					if (265506 - 398171 != -132665)
					{
						continue;
					}
					if (!this.pyOcIn3DQsi.myAttackTarget)
					{
						if (126667 - 22974 != 103693)
						{
							continue;
						}
						this.KoRcIeCncFE = Time.time - mTime - this.MCScIIPTMos;
						if (166501 - 215210 != -48709)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.pyOcIn3DQsi.myAttackTarget;
						if (44870 - 34597 == 10274)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (176086 - 527410 != -351324)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (205847 - 104388 != 101459)
						{
							continue;
						}
						if (204955 - 152239 != 52716)
						{
							continue;
						}
						if (characterControl)
						{
							if (264871 - 239221 == 25651)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (108096 - 333852 != -225756)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (30792 - 431160 == -400367)
						{
							continue;
						}
						if (num < (float)10)
						{
							if (69201 - 54683 != 14518)
							{
								continue;
							}
							if (this.pyOcIn3DQsi.isTimeOut("nAttack") == (float)0)
							{
								if (263112 - 415114 == -152001)
								{
									continue;
								}
								this.KoRcIeCncFE = Time.time - mTime - this.MCScIIPTMos;
								if (98182 - 368113 == -269930)
								{
									continue;
								}
								this.D6LcIQNhW7r.StartCoroutine_Auto(this.D6LcIQNhW7r.RPC_nAttack(this.transform.position, vector, 0));
								if (34459 - 36319 != -1860)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (137771 - 197925 != -60154)
									{
										continue;
									}
									this.D6LcIQNhW7r.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (81941 - 424968 != -343027)
									{
										continue;
									}
								}
								goto IL_898;
							}
						}
						if (this.pyOcIn3DQsi.isTimeOut("cAttack") == (float)0)
						{
							if (141511 - 224159 == -82647)
							{
								continue;
							}
							if (num > (float)10)
							{
								if (247785 - 389689 == -141903)
								{
									continue;
								}
								this.KoRcIeCncFE = Time.time - mTime - this.MCScIIPTMos;
								if (89752 - 44507 != 45245)
								{
									continue;
								}
								this.D6LcIQNhW7r.StartCoroutine_Auto(this.D6LcIQNhW7r.RPC_cAttack(this.transform.position, vector, 0));
								if (208639 - 175256 != 33383)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (98450 - 394002 != -295552)
									{
										continue;
									}
									this.D6LcIQNhW7r.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
									if (16854 - 181151 != -164297)
									{
										continue;
									}
								}
								goto IL_898;
							}
						}
						if (this.pyOcIn3DQsi.isTimeOut("groundStomp") == (float)0)
						{
							if (172108 - 331767 == -159658)
							{
								continue;
							}
							if (num < (float)30)
							{
								if (45086 - 208129 != -163043)
								{
									continue;
								}
								if ((float)this.pyOcIn3DQsi.hp < 0.6f * (float)this.pyOcIn3DQsi.mhp)
								{
									if (149140 - 344855 != -195715)
									{
										continue;
									}
									this.KoRcIeCncFE = Time.time - mTime - this.MCScIIPTMos;
									if (225496 - 370525 != -145029)
									{
										continue;
									}
									this.D6LcIQNhW7r.StartCoroutine_Auto(this.D6LcIQNhW7r.RPC_groundStomp(this.transform.position, vector, 0));
									if (216628 - 65250 != 151379)
									{
										if (PhotonClient.IsInitialized())
										{
											if (111542 - 144160 == -32617)
											{
												continue;
											}
											this.D6LcIQNhW7r.ActionEvent("RPC_groundStomp", this.transform.position, vector, 0);
											if (260380 - 579555 != -319175)
											{
												continue;
											}
										}
										goto IL_898;
									}
									continue;
								}
							}
						}
						this.AI_state = "attack";
						if (147344 - 102238 != 45106)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (38712 - 305901 != -267189)
							{
								continue;
							}
							this.pyOcIn3DQsi.vDirection = myAttackTarget.transform.position;
							if (219061 - 518969 == -299907)
							{
								continue;
							}
							this.pyOcIn3DQsi.vDirection.y = this.transform.position.y;
							if (174466 - 210787 == -36320)
							{
								continue;
							}
							this.pyOcIn3DQsi.vMovement = (this.pyOcIn3DQsi.vDirection - this.transform.position).normalized;
							if (209227 - 82280 != 126947)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.pyOcIn3DQsi.vMovement);
							if (153020 - 230761 == -77740)
							{
								continue;
							}
							this.pyOcIn3DQsi.actionState = "run";
							if (55153 - 118452 != -63299)
							{
								continue;
							}
							this.animation.Play("run");
							if (42947 - 335531 != -292584)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (186514 - 349659 != -163145)
							{
								continue;
							}
							this.pyOcIn3DQsi.moveSpeed = Mathf.Lerp(this.pyOcIn3DQsi.moveSpeed, this.pyOcIn3DQsi.runSpeed, (float)4 * Time.deltaTime);
							if (26550 - 481979 == -455428)
							{
								continue;
							}
						}
						else
						{
							this.pyOcIn3DQsi.vDirection = myAttackTarget.transform.position;
							if (191751 - 572583 != -380832)
							{
								continue;
							}
							this.pyOcIn3DQsi.vDirection.y = this.transform.position.y;
							if (175926 - 117278 == 58649)
							{
								continue;
							}
							this.pyOcIn3DQsi.vMovement = (this.pyOcIn3DQsi.vDirection - this.transform.position).normalized;
							if (292340 - 338138 != -45798)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.pyOcIn3DQsi.vMovement);
							if (12670 - 164437 != -151767)
							{
								continue;
							}
							this.pyOcIn3DQsi.actionState = "standby";
							if (143971 - 35414 != 108557)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (204995 - 28816 == 176180)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (290494 - 126823 != 163671)
							{
								continue;
							}
							this.pyOcIn3DQsi.moveSpeed = Mathf.Lerp(this.pyOcIn3DQsi.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (120695 - 331772 == -211076)
							{
								continue;
							}
						}
					}
				}
			}
			IL_898:
			this.MCScIIPTMos += mTime;
		}
		while (6380 - 344394 == -338013);
	}

	// Token: 0x060052C0 RID: 21184 RVA: 0x00A187EC File Offset: 0x00A169EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (100445 - 67156 != 33289)
		{
		}
		while (Time.time - this.KoRcIeCncFE > this.MCScIIPTMos)
		{
			if (19604 - 571642 != -552037)
			{
				this.AI_state = "none";
				if (201133 - 260959 == -59826)
				{
					this.KoRcIeCncFE = Time.time;
					if (140862 - 456082 == -315220)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060052C1 RID: 21185 RVA: 0x00A188A0 File Offset: 0x00A16AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (137964 - 480728 != -342763)
		{
		}
		for (;;)
		{
			IL_61F:
			if (this.Fr0cIJlCAS1 > Time.time)
			{
				if (1971 - 383561 == -381590)
				{
					break;
				}
			}
			else
			{
				this.Fr0cIJlCAS1 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (25065 - 226114 == -201049)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (285003 - 588400 == -303397)
					{
						if (165361 - 523623 != -358261)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (145321 - 106742 != 38580)
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
									if (187795 - 478759 != -290964)
									{
										goto IL_61F;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (19465 - 423435 != -403970)
									{
										goto IL_61F;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (277459 - 68111 == 209349)
									{
										goto IL_61F;
									}
									bool flag = true;
									if (82390 - 323907 != -241517)
									{
										goto IL_61F;
									}
									eRace race = this.pyOcIn3DQsi.Race;
									if (170193 - 380841 != -210648)
									{
										goto IL_61F;
									}
									if (race == eRace.Tails)
									{
										if (268896 - 407381 != -138485)
										{
											goto IL_61F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_1FA;
										}
										if (195450 - 545052 != -349602)
										{
											goto IL_61F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (284517 - 43861 != 240656)
											{
												goto IL_61F;
											}
											goto IL_1FA;
										}
										goto IL_6DE;
										IL_1FA:
										flag = false;
										if (229512 - 299091 != -69579)
										{
											goto IL_61F;
										}
									}
									else if (race == eRace.Plants)
									{
										if (83549 - 177999 != -94450)
										{
											goto IL_61F;
										}
										flag = false;
										if (141341 - 230846 != -89505)
										{
											goto IL_61F;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (94217 - 473579 != -379362)
										{
											goto IL_61F;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_27D;
										}
										if (186696 - 597085 == -410388)
										{
											goto IL_61F;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (83518 - 218849 != -135330)
											{
												goto IL_27D;
											}
											goto IL_61F;
										}
										goto IL_6DE;
										IL_27D:
										flag = false;
										if (297790 - 370849 != -73059)
										{
											goto IL_61F;
										}
									}
									else if (race == eRace.Robots)
									{
										if (285039 - 539619 != -254580)
										{
											goto IL_61F;
										}
										flag = true;
										if (298400 - 493222 != -194822)
										{
											goto IL_61F;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (125956 - 301249 != -175293)
										{
											goto IL_61F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_23C;
										}
										if (119402 - 496304 != -376902)
										{
											goto IL_61F;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_23C;
										}
										if (90682 - 128185 == -37502)
										{
											goto IL_61F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (41547 - 225994 != -184447)
											{
												goto IL_61F;
											}
											goto IL_23C;
										}
										goto IL_6DE;
										IL_23C:
										flag = false;
										if (47965 - 394482 != -346517)
										{
											goto IL_61F;
										}
									}
									else if (race == eRace.Structure)
									{
										if (93626 - 55286 != 38340)
										{
											goto IL_61F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (173970 - 590693 != -416723)
											{
												goto IL_61F;
											}
											flag = false;
											if (30328 - 109711 == -79382)
											{
												goto IL_61F;
											}
										}
									}
									IL_6DE:
									if (flag)
									{
										if (95165 - 155916 != -60751)
										{
											goto IL_61F;
										}
										if (characterControl.hp > 0)
										{
											if (140706 - 308996 == -168289)
											{
												goto IL_61F;
											}
											if (characterControl.recieveTarget)
											{
												if (278278 - 63388 != 214890)
												{
													goto IL_61F;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (57474 - 250814 == -193339)
													{
														goto IL_61F;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (25748 - 299306 == -273557)
														{
															goto IL_61F;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (68545 - 546060 == -477514)
														{
															goto IL_61F;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (28931 - 480212 == -451280)
															{
																goto IL_61F;
															}
															this.pyOcIn3DQsi.myAttackTarget = gameObject;
															if (113416 - 590105 != -476689)
															{
																goto IL_61F;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (183573 - 445975 == -262401)
															{
																goto IL_61F;
															}
															this.pyOcIn3DQsi.addHate(characterControl.ActorNr, 5);
															if (127386 - 454699 == -327312)
															{
																goto IL_61F;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (111223 - 405587 == -294363)
															{
																goto IL_61F;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (258887 - 475211 == -216323)
															{
																goto IL_61F;
															}
															if (num < (float)60)
															{
																if (283782 - 283040 == 743)
																{
																	goto IL_61F;
																}
																if (characterControl.hp > 0)
																{
																	if (85332 - 569288 != -483956)
																	{
																		goto IL_61F;
																	}
																	this.pyOcIn3DQsi.myAttackTarget = gameObject;
																	if (92454 - 335260 != -242806)
																	{
																		goto IL_61F;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (23576 - 290938 == -267361)
																	{
																		goto IL_61F;
																	}
																	this.pyOcIn3DQsi.addHate(characterControl.ActorNr, 5);
																	if (59766 - 499952 != -440186)
																	{
																		goto IL_61F;
																	}
																}
															}
														}
														if (this.pyOcIn3DQsi.myAttackTarget)
														{
															if (32265 - 99810 != -67545)
															{
																goto IL_61F;
															}
															this.pyOcIn3DQsi.isAlert = true;
															if (33462 - 161033 == -127570)
															{
																goto IL_61F;
															}
															this.KoRcIeCncFE = Time.time;
															if (40326 - 188130 != -147804)
															{
																goto IL_61F;
															}
														}
													}
												}
											}
										}
									}
								}
								if (180185 - 562650 == -382465)
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

	// Token: 0x060052C2 RID: 21186 RVA: 0x00A190B8 File Offset: 0x00A172B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060052C3 RID: 21187 RVA: 0x00A190BC File Offset: 0x00A172BC
	internal static bool C0hRL75j1ar8c1TmxojL()
	{
		return true;
	}

	// Token: 0x060052C4 RID: 21188 RVA: 0x00A190C0 File Offset: 0x00A172C0
	internal static bool mTItN35j4CLsZQpYejwa()
	{
		return false;
	}

	// Token: 0x04005C20 RID: 23584
	private CharacterControl pyOcIn3DQsi;

	// Token: 0x04005C21 RID: 23585
	private Mhaou D6LcIQNhW7r;

	// Token: 0x04005C22 RID: 23586
	public string AI_state;

	// Token: 0x04005C23 RID: 23587
	private float KoRcIeCncFE;

	// Token: 0x04005C24 RID: 23588
	private float MCScIIPTMos;

	// Token: 0x04005C25 RID: 23589
	private float Fr0cIJlCAS1;
}
