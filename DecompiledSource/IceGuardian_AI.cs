using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000311 RID: 785
[Serializable]
public class IceGuardian_AI : MonoBehaviour
{
	// Token: 0x060011C9 RID: 4553 RVA: 0x001C0C54 File Offset: 0x001BEE54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IceGuardian_AI()
	{
		if (189575 - 599072 != -409496)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (116092 - 544343 == -428251)
			{
				base..ctor();
				if (278672 - 20538 == 258134)
				{
					this.AI_state = "none";
					if (289333 - 293235 == -3902)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x001C0CF0 File Offset: 0x001BEEF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.VGX6HG9dG2 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.htR674htTC = (IceGuardian)this.GetComponent(typeof(IceGuardian));
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x001C0D28 File Offset: 0x001BEF28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (96087 - 426381 != -330293)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (5175 - 378962 == -373786)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (48040 - 283724 == -235683)
				{
					continue;
				}
			}
			if (this.VGX6HG9dG2.isControlled)
			{
				break;
			}
			if (60807 - 561907 != -501099)
			{
				this.AIControl();
				if (162079 - 386699 == -224620)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x001C0DF4 File Offset: 0x001BEFF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (99137 - 82931 != 16207)
		{
		}
		for (;;)
		{
			this.Mws6CMliF8 = (float)0;
			if (63810 - 387538 != -323727)
			{
				if (this.VGX6HG9dG2.isMine)
				{
					if (196431 - 30611 == 165820)
					{
						if (this.VGX6HG9dG2.actionState != "standby")
						{
							if (2685 - 216605 == -213919)
							{
								continue;
							}
							if (this.VGX6HG9dG2.actionState != "run")
							{
								if (55030 - 284803 != -229772)
								{
									break;
								}
								continue;
							}
						}
						if (!this.VGX6HG9dG2.isAlert)
						{
							if (125230 - 547324 != -422093)
							{
								this.AI_idle(3f, 1f);
								if (102763 - 496918 == -394155)
								{
									this.AI_patrol(1f, 0.25f);
									if (298399 - 75330 != 223070)
									{
										this.AI_resetTimer();
										if (102691 - 438842 == -336151)
										{
											this.AI_visionCheck();
											if (203371 - 569184 == -365813)
											{
												if (!this.VGX6HG9dG2.myAttackTarget)
												{
													break;
												}
												if (218325 - 186727 == 31598)
												{
													this.VGX6HG9dG2.isAlert = true;
													if (39738 - 573756 != -534017)
													{
														this.SCZ6ZHOMix = Time.time;
														if (6172 - 256465 == -250293)
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
							if (255077 - 598276 == -343199)
							{
								this.AI_patrol(4f, 2f);
								if (74531 - 423838 == -349307)
								{
									this.AI_attack(12f, (float)0);
									if (236828 - 133842 != 102987)
									{
										this.AI_resetTimer();
										if (295185 - 333854 != -38668)
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
					if (this.VGX6HG9dG2.actionState != "standby")
					{
						if (285466 - 101269 == 184198)
						{
							continue;
						}
						if (this.VGX6HG9dG2.actionState != "run")
						{
							if (89212 - 280191 != -190978)
							{
								break;
							}
							continue;
						}
					}
					float num = this.VGX6HG9dG2.moveSpeed;
					if (10940 - 155331 == -144391)
					{
						float runSpeed = this.VGX6HG9dG2.runSpeed;
						if (90307 - 550913 != -460605)
						{
							Vector3 vector = default(Vector3);
							if (52613 - 70391 == -17778)
							{
								Vector3 vector2 = Vector3.zero;
								if (210516 - 425896 == -215380)
								{
									if ((this.VGX6HG9dG2.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (50248 - 435463 != -385215)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.VGX6HG9dG2.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (250392 - 579022 != -328630)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (278762 - 225285 == 53478)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (105349 - 414750 != -309401)
											{
												continue;
											}
											num = (float)0;
											if (250268 - 443791 == -193522)
											{
												continue;
											}
											this.transform.position = this.VGX6HG9dG2.nPosition;
											if (255734 - 265986 != -10252)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (130957 - 236436 == -105478)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (252369 - 434466 != -182097)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (67374 - 135365 != -67991)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (111874 - 352513 == -240638)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (89179 - 397511 != -308332)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (125861 - 552468 == -426606)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (47100 - 272318 != -225218)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (135589 - 488201 == -352611)
											{
												continue;
											}
										}
									}
									this.VGX6HG9dG2.vMovement = vector2;
									if (72451 - 562197 != -489745)
									{
										this.VGX6HG9dG2.moveSpeed = num;
										if (289465 - 189146 != 100320)
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

	// Token: 0x060011CD RID: 4557 RVA: 0x001C146C File Offset: 0x001BF66C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (64220 - 504351 != -440130)
		{
		}
		do
		{
			if (Time.time - this.SCZ6ZHOMix >= this.Mws6CMliF8)
			{
				if (134738 - 106422 == 28317)
				{
					continue;
				}
				if (Time.time - this.SCZ6ZHOMix < this.Mws6CMliF8 + mTime)
				{
					if (112264 - 590950 == -478685)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (38887 - 64053 != -25166)
						{
							continue;
						}
						this.AI_state = "idle";
						if (3698 - 211098 != -207400)
						{
							continue;
						}
						this.SCZ6ZHOMix -= UnityEngine.Random.Range((float)0, rTimer);
						if (255659 - 542925 != -287266)
						{
							continue;
						}
						this.VGX6HG9dG2.vDirection = Vector3.zero;
						if (95959 - 462752 == -366792)
						{
							continue;
						}
						this.VGX6HG9dG2.vMovement = this.transform.forward;
						if (86953 - 33632 == 53322)
						{
							continue;
						}
						this.VGX6HG9dG2.actionState = "standby";
						if (171067 - 156123 == 14945)
						{
							continue;
						}
					}
					this.VGX6HG9dG2.moveSpeed = Mathf.Lerp(this.VGX6HG9dG2.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (173385 - 494933 != -321548)
					{
						continue;
					}
					if (this.VGX6HG9dG2.moveSpeed < 0.1f * this.VGX6HG9dG2.runSpeed)
					{
						if (47609 - 70864 == -23254)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (207796 - 361378 != -153582)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (170959 - 410092 == -239132)
						{
							continue;
						}
						this.VGX6HG9dG2.moveSpeed = (float)0;
						if (27230 - 346276 != -319046)
						{
							continue;
						}
					}
				}
			}
			this.Mws6CMliF8 += mTime;
		}
		while (79059 - 412768 != -333709);
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x001C1730 File Offset: 0x001BF930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (48319 - 393724 != -345405)
		{
		}
		do
		{
			if (Time.time - this.SCZ6ZHOMix >= this.Mws6CMliF8)
			{
				if (39166 - 496982 != -457816)
				{
					continue;
				}
				if (Time.time - this.SCZ6ZHOMix < this.Mws6CMliF8 + mTime)
				{
					if (147494 - 7983 != 139511)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (14880 - 355705 != -340825)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (7753 - 373746 != -365993)
						{
							continue;
						}
						this.SCZ6ZHOMix -= UnityEngine.Random.Range((float)0, rTimer);
						if (130753 - 314512 == -183758)
						{
							continue;
						}
						this.VGX6HG9dG2.vDirection = this.VGX6HG9dG2.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (35670 - 554384 != -518714)
						{
							continue;
						}
						this.VGX6HG9dG2.vDirection.y = this.transform.position.y;
						if (121044 - 587251 != -466207)
						{
							continue;
						}
						this.VGX6HG9dG2.vMovement = (this.VGX6HG9dG2.vDirection - this.transform.position).normalized;
						if (223434 - 329156 == -105721)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.VGX6HG9dG2.vMovement);
						if (205689 - 223571 == -17881)
						{
							continue;
						}
						this.VGX6HG9dG2.actionState = "run";
						if (284569 - 279062 == 5508)
						{
							continue;
						}
						this.animation.Play("run");
						if (33941 - 168676 == -134734)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (97176 - 586290 != -489114)
						{
							continue;
						}
					}
					this.VGX6HG9dG2.moveSpeed = Mathf.Lerp(this.VGX6HG9dG2.moveSpeed, this.VGX6HG9dG2.runSpeed, (float)4 * Time.deltaTime);
					if (251998 - 526805 == -274806)
					{
						continue;
					}
				}
			}
			this.Mws6CMliF8 += mTime;
		}
		while (196260 - 148666 == 47595);
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x001C1A38 File Offset: 0x001BFC38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (67378 - 71776 != -4398)
		{
		}
		do
		{
			if (Time.time - this.SCZ6ZHOMix >= this.Mws6CMliF8)
			{
				if (136035 - 425513 == -289477)
				{
					continue;
				}
				if (Time.time - this.SCZ6ZHOMix < this.Mws6CMliF8 + mTime)
				{
					if (21073 - 484060 == -462986)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (279687 - 83626 == 196062)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (48184 - 346640 != -298456)
						{
							continue;
						}
						this.SCZ6ZHOMix = Time.time - mTime - this.Mws6CMliF8;
						if (219941 - 294260 != -74319)
						{
							continue;
						}
						this.VGX6HG9dG2.vDirection = Vector3.zero;
						if (113249 - 404863 != -291614)
						{
							continue;
						}
						this.VGX6HG9dG2.vMovement = this.transform.forward;
						if (247472 - 407539 != -160067)
						{
							continue;
						}
						this.VGX6HG9dG2.actionState = "standby";
						if (236022 - 267414 != -31392)
						{
							continue;
						}
						this.VGX6HG9dG2.myAttackTarget = this.VGX6HG9dG2.getRandomHateTarget(50);
						if (2440 - 571985 != -569545)
						{
							continue;
						}
						if (!this.VGX6HG9dG2.myAttackTarget)
						{
							if (187499 - 125431 == 62069)
							{
								continue;
							}
							this.VGX6HG9dG2.isAlert = false;
							if (253477 - 434684 != -181207)
							{
								continue;
							}
							this.SCZ6ZHOMix = Time.time;
							if (125293 - 514121 != -388828)
							{
								continue;
							}
							this.VGX6HG9dG2.myAttackTarget = null;
							if (223024 - 306827 != -83803)
							{
								continue;
							}
							this.VGX6HG9dG2.mOriginalPosition = this.transform.position;
							if (126899 - 204146 != -77247)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.VGX6HG9dG2.myAttackTarget;
							if (187986 - 300903 != -112917)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (103388 - 400053 == -296664)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (24741 - 300855 == -276113)
								{
									continue;
								}
								this.VGX6HG9dG2.isAlert = false;
								if (99882 - 392156 != -292274)
								{
									continue;
								}
								this.SCZ6ZHOMix = Time.time;
								if (229791 - 178325 != 51466)
								{
									continue;
								}
								this.VGX6HG9dG2.myAttackTarget = null;
								if (47105 - 207412 == -160306)
								{
									continue;
								}
							}
							else
							{
								this.VGX6HG9dG2.vDirection = myAttackTarget.transform.position;
								if (157785 - 143413 != 14372)
								{
									continue;
								}
								this.VGX6HG9dG2.vDirection.y = this.transform.position.y;
								if (45576 - 315336 != -269760)
								{
									continue;
								}
								this.VGX6HG9dG2.vMovement = (this.VGX6HG9dG2.vDirection - this.transform.position).normalized;
								if (69361 - 148220 == -78858)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.VGX6HG9dG2.vMovement);
								if (244675 - 252479 != -7804)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Mws6CMliF8 += mTime;
		}
		while (289979 - 279734 != 10245);
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x001C1EE8 File Offset: 0x001C00E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (71676 - 341862 != -270185)
		{
		}
		do
		{
			if (Time.time - this.SCZ6ZHOMix >= this.Mws6CMliF8)
			{
				if (150747 - 554776 == -404028)
				{
					continue;
				}
				if (Time.time - this.SCZ6ZHOMix < this.Mws6CMliF8 + mTime)
				{
					if (59032 - 396272 != -337240)
					{
						continue;
					}
					if (!this.VGX6HG9dG2.myAttackTarget)
					{
						if (156679 - 171904 != -15225)
						{
							continue;
						}
						this.SCZ6ZHOMix = Time.time - mTime - this.Mws6CMliF8;
						if (112770 - 294944 != -182173)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.VGX6HG9dG2.myAttackTarget;
						if (51730 - 346965 != -295235)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (280406 - 540197 == -259790)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (273210 - 132430 == 140781 || 171934 - 242999 == -71064)
						{
							continue;
						}
						if (characterControl)
						{
							if (94504 - 293220 == -198715)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (194555 - 494629 == -300073)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (153370 - 35304 == 118067)
						{
							continue;
						}
						if (num <= (float)9)
						{
							if (238386 - 172833 != 65553)
							{
								continue;
							}
							if (this.VGX6HG9dG2.sp >= 63)
							{
								if (11781 - 381054 != -369273)
								{
									continue;
								}
								if (this.VGX6HG9dG2.isTimeOut("cAttack") == (float)0)
								{
									if (175455 - 564415 == -388959)
									{
										continue;
									}
									this.SCZ6ZHOMix = Time.time - mTime - this.Mws6CMliF8;
									if (1177 - 196809 != -195632)
									{
										continue;
									}
									this.VGX6HG9dG2.sp = this.VGX6HG9dG2.sp - 13;
									if (46136 - 110661 == -64524)
									{
										continue;
									}
									this.htR674htTC.StartCoroutine_Auto(this.htR674htTC.RPC_cAttack(this.transform.position, vector, 0));
									if (111310 - 331933 != -220623)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (58968 - 330925 == -271956)
										{
											continue;
										}
										this.htR674htTC.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
										if (254580 - 235352 == 19229)
										{
											continue;
										}
									}
									goto IL_652;
								}
							}
						}
						if (num <= (float)16)
						{
							if (89247 - 235143 == -145895)
							{
								continue;
							}
							if (this.VGX6HG9dG2.isTimeOut("iceStream") == (float)0)
							{
								if (88587 - 159900 == -71312)
								{
									continue;
								}
								this.SCZ6ZHOMix = Time.time - mTime - this.Mws6CMliF8;
								if (261012 - 199231 != 61781)
								{
									continue;
								}
								this.htR674htTC.StartCoroutine_Auto(this.htR674htTC.RPC_iceStream(this.transform.position, vector, 0));
								if (116931 - 250366 != -133435)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (233511 - 536566 == -303054)
									{
										continue;
									}
									this.htR674htTC.ActionEvent("RPC_iceStream", this.transform.position, vector, 0);
									if (250755 - 21938 == 228818)
									{
										continue;
									}
								}
								goto IL_652;
							}
						}
						if ((float)this.VGX6HG9dG2.hp <= 0.35f * (float)this.VGX6HG9dG2.mhp)
						{
							if (28789 - 74691 != -45902)
							{
								continue;
							}
							if (this.VGX6HG9dG2.mp > 0)
							{
								if (46607 - 429657 != -383050)
								{
									continue;
								}
								if (this.VGX6HG9dG2.isTimeOut("blizzard") == (float)0)
								{
									if (239990 - 464237 == -224246)
									{
										continue;
									}
									this.SCZ6ZHOMix = Time.time - mTime - this.Mws6CMliF8;
									if (106161 - 458133 != -351972)
									{
										continue;
									}
									this.htR674htTC.StartCoroutine_Auto(this.htR674htTC.RPC_blizzard(this.transform.position, vector, 0));
									if (248252 - 118136 != 130116)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (278032 - 308409 == -30376)
										{
											continue;
										}
										this.htR674htTC.ActionEvent("RPC_blizzard", this.transform.position, vector, 0);
										if (244188 - 125464 != 118724)
										{
											continue;
										}
									}
									goto IL_652;
								}
							}
						}
						if (num <= (float)3)
						{
							if (214569 - 358524 == -143954)
							{
								continue;
							}
							if (this.VGX6HG9dG2.isTimeOut("nAttack") == (float)0)
							{
								if (53184 - 188783 != -135599)
								{
									continue;
								}
								this.SCZ6ZHOMix = Time.time - mTime - this.Mws6CMliF8;
								if (201220 - 350480 == -149259)
								{
									continue;
								}
								this.htR674htTC.StartCoroutine_Auto(this.htR674htTC.RPC_nAttack(this.transform.position, vector, 0));
								if (90803 - 185795 != -94992)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (27334 - 433262 != -405928)
									{
										continue;
									}
									this.htR674htTC.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (42513 - 399189 != -356676)
									{
										continue;
									}
								}
								goto IL_652;
							}
						}
						if (this.VGX6HG9dG2.isTimeOut("dispell") == (float)0)
						{
							if (228089 - 519487 != -291398)
							{
								continue;
							}
							this.SCZ6ZHOMix = Time.time - mTime - this.Mws6CMliF8;
							if (241296 - 60133 != 181163)
							{
								continue;
							}
							this.htR674htTC.StartCoroutine_Auto(this.htR674htTC.RPC_dispell(this.transform.position, vector, 0));
							if (12883 - 584727 != -571844)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (247046 - 107697 != 139349)
								{
									continue;
								}
								this.htR674htTC.ActionEvent("RPC_dispell", this.transform.position, vector, 0);
								if (86587 - 61022 == 25566)
								{
									continue;
								}
							}
						}
						else if (num > (float)6)
						{
							if (259486 - 334260 != -74774)
							{
								continue;
							}
							this.AI_state = "attack";
							if (212415 - 13798 != 198617)
							{
								continue;
							}
							this.VGX6HG9dG2.vDirection = myAttackTarget.transform.position;
							if (263530 - 155468 == 108063)
							{
								continue;
							}
							this.VGX6HG9dG2.vDirection.y = this.transform.position.y;
							if (45392 - 487417 == -442024)
							{
								continue;
							}
							this.VGX6HG9dG2.vMovement = (this.VGX6HG9dG2.vDirection - this.transform.position).normalized;
							if (210006 - 276557 == -66550)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.VGX6HG9dG2.vMovement);
							if (96832 - 162981 == -66148)
							{
								continue;
							}
							this.VGX6HG9dG2.actionState = "run";
							if (148498 - 90499 != 57999)
							{
								continue;
							}
							this.animation.Play("run");
							if (24403 - 500918 == -476514)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (69489 - 430642 == -361152)
							{
								continue;
							}
							this.VGX6HG9dG2.moveSpeed = Mathf.Lerp(this.VGX6HG9dG2.moveSpeed, this.VGX6HG9dG2.runSpeed, (float)4 * Time.deltaTime);
							if (234944 - 339620 != -104676)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (135512 - 206559 != -71047)
							{
								continue;
							}
							this.VGX6HG9dG2.vDirection = this.transform.forward;
							if (165647 - 539091 != -373444)
							{
								continue;
							}
							this.VGX6HG9dG2.vMovement = this.transform.forward;
							if (9811 - 201028 != -191217)
							{
								continue;
							}
							this.VGX6HG9dG2.actionState = "standby";
							if (98662 - 393161 != -294499)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (72735 - 533940 != -461205)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (82546 - 569504 != -486958)
							{
								continue;
							}
							this.VGX6HG9dG2.moveSpeed = Mathf.Lerp(this.VGX6HG9dG2.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (54421 - 551539 != -497118)
							{
								continue;
							}
						}
					}
				}
			}
			IL_652:
			this.Mws6CMliF8 += mTime;
		}
		while (252893 - 291248 != -38355);
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x001C2A9C File Offset: 0x001C0C9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (256876 - 211607 != 45270)
		{
		}
		while (Time.time - this.SCZ6ZHOMix > this.Mws6CMliF8)
		{
			if (133144 - 115013 == 18131)
			{
				this.AI_state = "none";
				if (206076 - 113300 != 92777)
				{
					this.SCZ6ZHOMix = Time.time;
					if (260985 - 375241 == -114256)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x001C2B50 File Offset: 0x001C0D50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (177216 - 95734 != 81483)
		{
		}
		for (;;)
		{
			IL_1A:
			if (this.NmB6MWmUly > Time.time)
			{
				if (160211 - 493722 != -333510)
				{
					break;
				}
			}
			else
			{
				this.NmB6MWmUly = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (28387 - 90955 != -62567)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (200027 - 281393 == -81366)
					{
						if (138796 - 210889 != -72092)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (62447 - 467550 != -405102)
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
									if (249032 - 408996 == -159963)
									{
										goto IL_1A;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (95347 - 349485 != -254138)
									{
										goto IL_1A;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (67624 - 336070 == -268445)
									{
										goto IL_1A;
									}
									bool flag = true;
									if (100574 - 474456 != -373882)
									{
										goto IL_1A;
									}
									eRace race = this.VGX6HG9dG2.Race;
									if (207560 - 270304 == -62743)
									{
										goto IL_1A;
									}
									if (race == eRace.Tails)
									{
										if (208004 - 566724 != -358720)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_D9;
										}
										if (259953 - 355920 == -95966)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (39256 - 227910 != -188653)
											{
												goto IL_D9;
											}
											goto IL_1A;
										}
										goto IL_7B4;
										IL_D9:
										flag = false;
										if (290860 - 85322 == 205539)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Plants)
									{
										if (214012 - 493546 != -279534)
										{
											goto IL_1A;
										}
										flag = false;
										if (123601 - 79095 != 44506)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (68885 - 363979 == -295093)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_512;
										}
										if (278253 - 350516 == -72262)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (292925 - 370982 != -78056)
											{
												goto IL_512;
											}
											goto IL_1A;
										}
										goto IL_7B4;
										IL_512:
										flag = false;
										if (181492 - 503157 == -321664)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Robots)
									{
										if (261318 - 433161 == -171842)
										{
											goto IL_1A;
										}
										flag = true;
										if (37439 - 110318 == -72878)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (235122 - 157378 == 77745)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_332;
										}
										if (207628 - 234181 != -26553)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_332;
										}
										if (180083 - 150914 == 29170)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (78845 - 311407 != -232561)
											{
												goto IL_332;
											}
											goto IL_1A;
										}
										goto IL_7B4;
										IL_332:
										flag = false;
										if (278165 - 339213 != -61048)
										{
											goto IL_1A;
										}
									}
									else if (race == eRace.Structure)
									{
										if (274988 - 577192 != -302204)
										{
											goto IL_1A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (62904 - 370952 != -308048)
											{
												goto IL_1A;
											}
											flag = false;
											if (232353 - 372833 == -140479)
											{
												goto IL_1A;
											}
										}
									}
									IL_7B4:
									if (flag)
									{
										if (247020 - 91190 == 155831)
										{
											goto IL_1A;
										}
										if (characterControl.hp > 0)
										{
											if (8453 - 303155 == -294701)
											{
												goto IL_1A;
											}
											if (characterControl.recieveTarget)
											{
												if (228810 - 264882 != -36072)
												{
													goto IL_1A;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (288012 - 121998 == 166015)
													{
														goto IL_1A;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (151186 - 216963 == -65776)
														{
															goto IL_1A;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (36483 - 315958 == -279474)
														{
															goto IL_1A;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (298101 - 558421 == -260319)
															{
																goto IL_1A;
															}
															this.VGX6HG9dG2.myAttackTarget = gameObject;
															if (118057 - 346624 == -228566)
															{
																goto IL_1A;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (160788 - 69913 == 90876)
															{
																goto IL_1A;
															}
															this.VGX6HG9dG2.addHate(characterControl.ActorNr, 5);
															if (239459 - 532826 != -293367)
															{
																goto IL_1A;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (182356 - 532552 == -350195)
															{
																goto IL_1A;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (294117 - 308109 != -13992)
															{
																goto IL_1A;
															}
															if (num < (float)60)
															{
																if (218418 - 352451 != -134033)
																{
																	goto IL_1A;
																}
																if (characterControl.hp > 0)
																{
																	if (257804 - 268623 != -10819)
																	{
																		goto IL_1A;
																	}
																	this.VGX6HG9dG2.myAttackTarget = gameObject;
																	if (1281 - 97511 != -96230)
																	{
																		goto IL_1A;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (197458 - 54340 != 143118)
																	{
																		goto IL_1A;
																	}
																	this.VGX6HG9dG2.addHate(characterControl.ActorNr, 5);
																	if (36006 - 178271 != -142265)
																	{
																		goto IL_1A;
																	}
																}
															}
														}
														if (this.VGX6HG9dG2.myAttackTarget)
														{
															if (198591 - 290042 == -91450)
															{
																goto IL_1A;
															}
															this.VGX6HG9dG2.isAlert = true;
															if (191912 - 417557 == -225644)
															{
																goto IL_1A;
															}
															this.SCZ6ZHOMix = Time.time;
															if (232922 - 286246 != -53324)
															{
																goto IL_1A;
															}
														}
													}
												}
											}
										}
									}
								}
								if (2452 - 494996 == -492544)
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

	// Token: 0x060011D3 RID: 4563 RVA: 0x001C3368 File Offset: 0x001C1568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x001C336C File Offset: 0x001C156C
	internal static bool CdOQNgZyegsHv0f5fWF()
	{
		return true;
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x001C3370 File Offset: 0x001C1570
	internal static bool aVKlhyZSiJFFnwyXxKW()
	{
		return false;
	}

	// Token: 0x04000FA0 RID: 4000
	private CharacterControl VGX6HG9dG2;

	// Token: 0x04000FA1 RID: 4001
	private IceGuardian htR674htTC;

	// Token: 0x04000FA2 RID: 4002
	public string AI_state;

	// Token: 0x04000FA3 RID: 4003
	private float SCZ6ZHOMix;

	// Token: 0x04000FA4 RID: 4004
	private float Mws6CMliF8;

	// Token: 0x04000FA5 RID: 4005
	private float NmB6MWmUly;
}
