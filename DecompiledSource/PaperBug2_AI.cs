using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200016F RID: 367
[Serializable]
public class PaperBug2_AI : MonoBehaviour
{
	// Token: 0x06000835 RID: 2101 RVA: 0x000D4BBC File Offset: 0x000D2DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PaperBug2_AI()
	{
		if (36242 - 227481 != -191239)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (200360 - 520618 == -320258)
			{
				base..ctor();
				if (63984 - 202832 == -138848)
				{
					this.AI_state = "none";
					if (225673 - 137621 == 88052)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x000D4C58 File Offset: 0x000D2E58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.l5gQeCT4Ds = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.HcLQIcWVne = (PaperBug2)this.GetComponent(typeof(PaperBug2));
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x000D4C90 File Offset: 0x000D2E90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (156149 - 169336 != -13186)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (85387 - 130599 == -45211)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (237072 - 251124 == -14051)
				{
					continue;
				}
			}
			if (this.l5gQeCT4Ds.isControlled)
			{
				break;
			}
			if (228003 - 232947 == -4944)
			{
				this.AIControl();
				if (264507 - 380783 != -116275)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x000D4D5C File Offset: 0x000D2F5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (95534 - 355095 != -259560)
		{
		}
		for (;;)
		{
			this.GKOQ65JGTw = (float)0;
			if (261825 - 375974 == -114149)
			{
				if (this.l5gQeCT4Ds.isMine)
				{
					if (134934 - 472467 != -337532)
					{
						if (this.l5gQeCT4Ds.actionState != "standby")
						{
							if (291727 - 406562 == -114834)
							{
								continue;
							}
							if (this.l5gQeCT4Ds.actionState != "run")
							{
								if (234131 - 431684 != -197553)
								{
									continue;
								}
								break;
							}
						}
						if (!this.l5gQeCT4Ds.isAlert)
						{
							if (231867 - 205069 == 26798)
							{
								this.AI_idle(12f, 2f);
								if (288303 - 492980 == -204677)
								{
									this.AI_patrol(3f, 1f);
									if (97496 - 307375 != -209878)
									{
										this.AI_resetTimer();
										if (87829 - 324944 == -237115)
										{
											this.AI_visionCheck();
											if (30221 - 464427 != -434205)
											{
												if (!this.l5gQeCT4Ds.myAttackTarget)
												{
													break;
												}
												if (98385 - 62727 != 35659)
												{
													this.l5gQeCT4Ds.isAlert = true;
													if (149202 - 322247 == -173045)
													{
														this.NLQQJZMXjH = Time.time;
														if (103734 - 396667 == -292933)
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
							if (86435 - 135776 == -49341)
							{
								this.AI_idle(2f, 2f);
								if (131777 - 94566 != 37212)
								{
									this.AI_patrol(2f, 2f);
									if (11996 - 526807 != -514810)
									{
										this.AI_attack(6f, (float)0);
										if (159770 - 241774 != -82003)
										{
											this.AI_resetTimer();
											if (241528 - 574350 == -332822)
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
					if (this.l5gQeCT4Ds.actionState != "standby")
					{
						if (165181 - 351990 != -186809)
						{
							continue;
						}
						if (this.l5gQeCT4Ds.actionState != "run")
						{
							if (111648 - 263400 != -151751)
							{
								break;
							}
							continue;
						}
					}
					float num = this.l5gQeCT4Ds.moveSpeed;
					if (117533 - 48585 == 68948)
					{
						float runSpeed = this.l5gQeCT4Ds.runSpeed;
						if (243040 - 577928 != -334887)
						{
							Vector3 vector = default(Vector3);
							if (242550 - 93615 != 148936)
							{
								Vector3 vector2 = Vector3.zero;
								if (82235 - 168280 != -86044)
								{
									if ((this.l5gQeCT4Ds.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (18195 - 105506 != -87311)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.l5gQeCT4Ds.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (274069 - 490457 == -216387)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (123880 - 289708 != -165828)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (53482 - 574963 != -521481)
											{
												continue;
											}
											num = (float)0;
											if (89242 - 287427 == -198184)
											{
												continue;
											}
											this.transform.position = this.l5gQeCT4Ds.nPosition;
											if (146960 - 24221 == 122740)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (152355 - 452254 == -299898)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (272057 - 281884 == -9826)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (74306 - 545980 == -471673)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (4589 - 284197 != -279608)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (262489 - 319725 == -57235)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (213645 - 313752 != -100107)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (279646 - 86031 == 193616)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (115120 - 305431 == -190310)
											{
												continue;
											}
										}
									}
									this.l5gQeCT4Ds.vMovement = vector2;
									if (192838 - 80315 != 112524)
									{
										this.l5gQeCT4Ds.moveSpeed = num;
										if (142876 - 411481 != -268604)
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

	// Token: 0x06000839 RID: 2105 RVA: 0x000D53FC File Offset: 0x000D35FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (18945 - 274827 != -255882)
		{
		}
		do
		{
			if (Time.time - this.NLQQJZMXjH >= this.GKOQ65JGTw)
			{
				if (195246 - 532451 != -337205)
				{
					continue;
				}
				if (Time.time - this.NLQQJZMXjH < this.GKOQ65JGTw + mTime)
				{
					if (130595 - 96351 != 34244)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (18790 - 577253 != -558463)
						{
							continue;
						}
						this.AI_state = "idle";
						if (85113 - 65687 == 19427)
						{
							continue;
						}
						this.NLQQJZMXjH -= UnityEngine.Random.Range((float)0, rTimer);
						if (171311 - 487811 != -316500)
						{
							continue;
						}
						this.l5gQeCT4Ds.vDirection = Vector3.zero;
						if (194643 - 170222 != 24421)
						{
							continue;
						}
						this.l5gQeCT4Ds.vMovement = this.transform.forward;
						if (127888 - 35922 != 91966)
						{
							continue;
						}
						this.l5gQeCT4Ds.actionState = "standby";
						if (25508 - 276188 == -250679)
						{
							continue;
						}
					}
					this.l5gQeCT4Ds.moveSpeed = Mathf.Lerp(this.l5gQeCT4Ds.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (131886 - 167569 != -35683)
					{
						continue;
					}
					if (this.l5gQeCT4Ds.moveSpeed < 0.1f * this.l5gQeCT4Ds.runSpeed)
					{
						if (131024 - 170413 != -39389)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (185509 - 312407 != -126898)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (297690 - 19000 == 278691)
						{
							continue;
						}
						this.l5gQeCT4Ds.moveSpeed = (float)0;
						if (46889 - 556236 != -509347)
						{
							continue;
						}
					}
				}
			}
			this.GKOQ65JGTw += mTime;
		}
		while (259529 - 556990 == -297460);
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x000D56C0 File Offset: 0x000D38C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (14063 - 436692 != -422628)
		{
		}
		do
		{
			if (Time.time - this.NLQQJZMXjH >= this.GKOQ65JGTw)
			{
				if (118916 - 250587 != -131671)
				{
					continue;
				}
				if (Time.time - this.NLQQJZMXjH < this.GKOQ65JGTw + mTime)
				{
					if (285963 - 217446 == 68518)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (169568 - 173276 == -3707)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (266283 - 539985 == -273701)
						{
							continue;
						}
						this.NLQQJZMXjH -= UnityEngine.Random.Range((float)0, rTimer);
						if (35985 - 112065 != -76080)
						{
							continue;
						}
						this.l5gQeCT4Ds.vDirection = this.l5gQeCT4Ds.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (40491 - 351516 != -311025)
						{
							continue;
						}
						this.l5gQeCT4Ds.vDirection.y = this.transform.position.y;
						if (193597 - 549168 == -355570)
						{
							continue;
						}
						this.l5gQeCT4Ds.vMovement = (this.l5gQeCT4Ds.vDirection - this.transform.position).normalized;
						if (227144 - 588741 != -361597)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.l5gQeCT4Ds.vMovement);
						if (94590 - 121420 == -26829)
						{
							continue;
						}
						this.l5gQeCT4Ds.actionState = "run";
						if (104144 - 423294 == -319149)
						{
							continue;
						}
						this.animation.Play("run");
						if (69536 - 352753 != -283217)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (97195 - 515039 != -417844)
						{
							continue;
						}
					}
					this.l5gQeCT4Ds.moveSpeed = Mathf.Lerp(this.l5gQeCT4Ds.moveSpeed, this.l5gQeCT4Ds.runSpeed, (float)4 * Time.deltaTime);
					if (10165 - 520342 == -510176)
					{
						continue;
					}
				}
			}
			this.GKOQ65JGTw += mTime;
		}
		while (189161 - 481068 == -291906);
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x000D59C8 File Offset: 0x000D3BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (272812 - 425061 != -152249)
		{
		}
		do
		{
			if (Time.time - this.NLQQJZMXjH >= this.GKOQ65JGTw)
			{
				if (155547 - 27920 != 127627)
				{
					continue;
				}
				if (Time.time - this.NLQQJZMXjH < this.GKOQ65JGTw + mTime)
				{
					if (255487 - 304542 == -49054)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (92059 - 425695 != -333636)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (280649 - 499280 != -218631)
						{
							continue;
						}
						this.NLQQJZMXjH = Time.time - mTime - this.GKOQ65JGTw;
						if (79444 - 177493 == -98048)
						{
							continue;
						}
						this.l5gQeCT4Ds.vDirection = Vector3.zero;
						if (228158 - 507170 != -279012)
						{
							continue;
						}
						this.l5gQeCT4Ds.vMovement = this.transform.forward;
						if (123254 - 87363 == 35892)
						{
							continue;
						}
						this.l5gQeCT4Ds.actionState = "standby";
						if (215903 - 437976 != -222073)
						{
							continue;
						}
						this.l5gQeCT4Ds.myAttackTarget = this.l5gQeCT4Ds.getHateTarget(5, 50);
						if (206216 - 562725 != -356509)
						{
							continue;
						}
						if (!this.l5gQeCT4Ds.myAttackTarget)
						{
							if (135734 - 59053 != 76681)
							{
								continue;
							}
							this.l5gQeCT4Ds.isAlert = false;
							if (1025 - 561039 == -560013)
							{
								continue;
							}
							this.NLQQJZMXjH = Time.time;
							if (204241 - 407949 == -203707)
							{
								continue;
							}
							this.l5gQeCT4Ds.myAttackTarget = null;
							if (257891 - 139412 == 118480)
							{
								continue;
							}
							this.l5gQeCT4Ds.mOriginalPosition = this.transform.position;
							if (194923 - 565675 != -370752)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.l5gQeCT4Ds.myAttackTarget;
							if (30036 - 42971 == -12934)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (239522 - 522917 == -283394)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (148148 - 341006 == -192857)
								{
									continue;
								}
								this.l5gQeCT4Ds.isAlert = false;
								if (138347 - 200727 != -62380)
								{
									continue;
								}
								this.NLQQJZMXjH = Time.time;
								if (57949 - 119174 == -61224)
								{
									continue;
								}
								this.l5gQeCT4Ds.myAttackTarget = null;
								if (53054 - 313514 == -260459)
								{
									continue;
								}
							}
							else
							{
								this.l5gQeCT4Ds.vDirection = myAttackTarget.transform.position;
								if (274575 - 576971 == -302395)
								{
									continue;
								}
								this.l5gQeCT4Ds.vDirection.y = this.transform.position.y;
								if (86313 - 481626 == -395312)
								{
									continue;
								}
								this.l5gQeCT4Ds.vMovement = (this.l5gQeCT4Ds.vDirection - this.transform.position).normalized;
								if (178032 - 529770 == -351737)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.l5gQeCT4Ds.vMovement);
								if (155794 - 178193 != -22399)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.GKOQ65JGTw += mTime;
		}
		while (26283 - 65864 != -39581);
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x000D5E78 File Offset: 0x000D4078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (77837 - 245073 != -167236)
		{
		}
		do
		{
			if (Time.time - this.NLQQJZMXjH >= this.GKOQ65JGTw)
			{
				if (150924 - 367362 != -216438)
				{
					continue;
				}
				if (Time.time - this.NLQQJZMXjH < this.GKOQ65JGTw + mTime)
				{
					if (272412 - 91982 == 180431)
					{
						continue;
					}
					if (!this.l5gQeCT4Ds.myAttackTarget)
					{
						if (240618 - 334335 == -93716)
						{
							continue;
						}
						this.NLQQJZMXjH = Time.time - mTime - this.GKOQ65JGTw;
						if (205279 - 594819 != -389539)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.l5gQeCT4Ds.myAttackTarget;
						if (117764 - 398814 == -281049)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (16479 - 312825 == -296345)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (227858 - 182664 == 45195)
						{
							continue;
						}
						int tID = 0;
						if (84787 - 19972 == 64816)
						{
							continue;
						}
						if (characterControl)
						{
							if (259140 - 161462 == 97679)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (177063 - 212768 == -35704)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (263299 - 427692 == -164392)
						{
							continue;
						}
						if (num < (float)24)
						{
							if (73110 - 402268 != -329158)
							{
								continue;
							}
							if (this.l5gQeCT4Ds.isTimeOut("sleep") == (float)0)
							{
								if (209222 - 355731 != -146509)
								{
									continue;
								}
								this.NLQQJZMXjH = Time.time - mTime - this.GKOQ65JGTw;
								if (256609 - 82332 == 174278)
								{
									continue;
								}
								this.HcLQIcWVne.StartCoroutine_Auto(this.HcLQIcWVne.RPC_sleep(this.transform.position, vector, tID));
								if (136904 - 239499 != -102595)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (173594 - 286318 == -112723)
									{
										continue;
									}
									this.HcLQIcWVne.ActionEvent("RPC_sleep", this.transform.position, vector, tID);
									if (43709 - 380328 == -336618)
									{
										continue;
									}
								}
								goto IL_50D;
							}
						}
						if (num < (float)24)
						{
							if (141559 - 149870 != -8311)
							{
								continue;
							}
							if (this.l5gQeCT4Ds.isTimeOut("fallingComet") == (float)0)
							{
								if (230639 - 519699 != -289060)
								{
									continue;
								}
								this.NLQQJZMXjH = Time.time - mTime - this.GKOQ65JGTw;
								if (38280 - 363765 == -325484)
								{
									continue;
								}
								this.HcLQIcWVne.StartCoroutine_Auto(this.HcLQIcWVne.RPC_fallingComet(this.transform.position, vector, tID));
								if (167138 - 587278 != -420140)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (54031 - 221021 != -166990)
									{
										continue;
									}
									this.HcLQIcWVne.ActionEvent("RPC_fallingComet", this.transform.position, vector, tID);
									if (298752 - 24573 == 274180)
									{
										continue;
									}
								}
								goto IL_50D;
							}
						}
						this.AI_state = "attack";
						if (269256 - 239525 == 29732)
						{
							continue;
						}
						this.l5gQeCT4Ds.vDirection = myAttackTarget.transform.position;
						if (12123 - 487423 != -475300)
						{
							continue;
						}
						this.l5gQeCT4Ds.vDirection.y = this.transform.position.y;
						if (277416 - 88232 == 189185)
						{
							continue;
						}
						this.l5gQeCT4Ds.vMovement = (this.l5gQeCT4Ds.vDirection - this.transform.position).normalized;
						if (126901 - 201352 == -74450)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.l5gQeCT4Ds.vMovement);
						if (290254 - 476868 == -186613)
						{
							continue;
						}
						this.l5gQeCT4Ds.actionState = "run";
						if (8755 - 319567 != -310812)
						{
							continue;
						}
						this.animation.Play("run");
						if (160621 - 175270 != -14649)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (275235 - 530631 == -255395)
						{
							continue;
						}
						this.l5gQeCT4Ds.moveSpeed = Mathf.Lerp(this.l5gQeCT4Ds.moveSpeed, this.l5gQeCT4Ds.runSpeed, (float)4 * Time.deltaTime);
						if (158672 - 366827 != -208155)
						{
							continue;
						}
					}
				}
			}
			IL_50D:
			this.GKOQ65JGTw += mTime;
		}
		while (110079 - 558052 == -447972);
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x000D64E4 File Offset: 0x000D46E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (130437 - 584020 != -453583)
		{
		}
		while (Time.time - this.NLQQJZMXjH > this.GKOQ65JGTw)
		{
			if (90414 - 190380 == -99966)
			{
				this.AI_state = "none";
				if (9429 - 299491 == -290062)
				{
					this.NLQQJZMXjH = Time.time;
					if (203142 - 590303 == -387161)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x000D6598 File Offset: 0x000D4798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (224335 - 393130 != -168795)
		{
		}
		for (;;)
		{
			IL_544:
			if (this.c5QQtG0MZL + (float)1 > Time.time)
			{
				if (77348 - 324139 != -246790)
				{
					break;
				}
			}
			else
			{
				this.c5QQtG0MZL = Time.time;
				if (178064 - 516912 == -338848)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (179385 - 364027 != -184641 && 159055 - 312227 != -153171)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (28036 - 151990 == -123954)
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
								if (294394 - 318846 == -24451)
								{
									goto IL_544;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (112135 - 71611 == 40525)
								{
									goto IL_544;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (234963 - 47356 != 187607)
								{
									goto IL_544;
								}
								bool flag = true;
								if (1166 - 482656 == -481489)
								{
									goto IL_544;
								}
								eRace race = this.l5gQeCT4Ds.Race;
								if (80836 - 415131 == -334294)
								{
									goto IL_544;
								}
								if (race == eRace.Tails)
								{
									if (101822 - 477560 == -375737)
									{
										goto IL_544;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_2F6;
									}
									if (114612 - 100690 != 13922)
									{
										goto IL_544;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (297587 - 580286 != -282699)
										{
											goto IL_544;
										}
										goto IL_2F6;
									}
									goto IL_405;
									IL_2F6:
									flag = false;
									if (219376 - 451981 == -232604)
									{
										goto IL_544;
									}
								}
								else if (race == eRace.Plants)
								{
									if (279551 - 468852 != -189301)
									{
										goto IL_544;
									}
									flag = false;
									if (240008 - 163714 != 76294)
									{
										goto IL_544;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (165625 - 123178 != 42447)
									{
										goto IL_544;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_6DE;
									}
									if (20285 - 113326 != -93041)
									{
										goto IL_544;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (11010 - 231173 != -220162)
										{
											goto IL_6DE;
										}
										goto IL_544;
									}
									goto IL_405;
									IL_6DE:
									flag = false;
									if (154259 - 377282 != -223023)
									{
										goto IL_544;
									}
								}
								else if (race == eRace.Robots)
								{
									if (30259 - 336144 != -305885)
									{
										goto IL_544;
									}
									flag = true;
									if (206732 - 138521 != 68211)
									{
										goto IL_544;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (66471 - 457201 != -390730)
									{
										goto IL_544;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_41;
									}
									if (174914 - 249208 == -74293)
									{
										goto IL_544;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_41;
									}
									if (61939 - 425149 == -363209)
									{
										goto IL_544;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (3103 - 528423 != -525319)
										{
											goto IL_41;
										}
										goto IL_544;
									}
									goto IL_405;
									IL_41:
									flag = false;
									if (80624 - 278945 == -198320)
									{
										goto IL_544;
									}
								}
								else if (race == eRace.Structure)
								{
									if (151464 - 383389 == -231924)
									{
										goto IL_544;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (276442 - 248675 != 27767)
										{
											goto IL_544;
										}
										flag = false;
										if (72125 - 585289 == -513163)
										{
											goto IL_544;
										}
									}
								}
								IL_405:
								if (flag)
								{
									if (246982 - 414389 == -167406)
									{
										goto IL_544;
									}
									if (characterControl.hp > 0)
									{
										if (186318 - 216314 != -29996)
										{
											goto IL_544;
										}
										if (characterControl.recieveTarget)
										{
											if (222951 - 484992 != -262041)
											{
												goto IL_544;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (279937 - 193719 != 86218)
												{
													goto IL_544;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (111425 - 440446 != -329021)
													{
														goto IL_544;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (105032 - 408135 != -303103)
													{
														goto IL_544;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (5244 - 210008 == -204763)
														{
															goto IL_544;
														}
														this.l5gQeCT4Ds.isAlert = true;
														if (119657 - 408261 != -288604)
														{
															goto IL_544;
														}
														this.NLQQJZMXjH = Time.time;
														if (289940 - 180071 == 109870)
														{
															goto IL_544;
														}
														this.l5gQeCT4Ds.myAttackTarget = gameObject;
														if (186396 - 137566 == 48831)
														{
															goto IL_544;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (50973 - 482017 != -431044)
														{
															goto IL_544;
														}
														this.l5gQeCT4Ds.addHate(characterControl.ActorNr, 5);
														if (138889 - 389129 == -250239)
														{
															goto IL_544;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (14460 - 217186 == -202725)
														{
															goto IL_544;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (43383 - 374151 != -330768)
														{
															goto IL_544;
														}
														if (num < (float)90)
														{
															if (297781 - 567094 != -269313)
															{
																goto IL_544;
															}
															this.l5gQeCT4Ds.isAlert = true;
															if (267193 - 450486 == -183292)
															{
																goto IL_544;
															}
															this.NLQQJZMXjH = Time.time;
															if (118129 - 323333 != -205204)
															{
																goto IL_544;
															}
															this.l5gQeCT4Ds.myAttackTarget = gameObject;
															if (97520 - 210730 != -113210)
															{
																goto IL_544;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (2472 - 556060 == -553587)
															{
																goto IL_544;
															}
															this.l5gQeCT4Ds.addHate(characterControl.ActorNr, 5);
															if (123703 - 327070 != -203367)
															{
																goto IL_544;
															}
														}
													}
												}
											}
										}
									}
								}
							}
							if (70441 - 110615 != -40173)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x000D6D9C File Offset: 0x000D4F9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x000D6DA0 File Offset: 0x000D4FA0
	internal static bool HqOGSTXIYhmcpw6uJt6()
	{
		return true;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x000D6DA4 File Offset: 0x000D4FA4
	internal static bool fQwVnfXBgAVYQIIAER1()
	{
		return false;
	}

	// Token: 0x0400076C RID: 1900
	private CharacterControl l5gQeCT4Ds;

	// Token: 0x0400076D RID: 1901
	private PaperBug2 HcLQIcWVne;

	// Token: 0x0400076E RID: 1902
	public string AI_state;

	// Token: 0x0400076F RID: 1903
	private float NLQQJZMXjH;

	// Token: 0x04000770 RID: 1904
	private float GKOQ65JGTw;

	// Token: 0x04000771 RID: 1905
	private float c5QQtG0MZL;
}
