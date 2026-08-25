using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000301 RID: 769
[Serializable]
public class IceDemon_AI : MonoBehaviour
{
	// Token: 0x0600116E RID: 4462 RVA: 0x001B7D48 File Offset: 0x001B5F48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IceDemon_AI()
	{
		if (163358 - 421718 != -258360)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (92980 - 578928 == -485948)
			{
				base..ctor();
				if (46002 - 397519 != -351516)
				{
					this.AI_state = "none";
					if (249219 - 583031 != -333811)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x001B7DE4 File Offset: 0x001B5FE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.BWZ6dehJPf = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.nep6gWBI2F = (IceDemon)this.GetComponent(typeof(IceDemon));
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x001B7E1C File Offset: 0x001B601C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (272280 - 160031 != 112250)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (264890 - 485271 == -220380)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (79549 - 570516 != -490967)
				{
					continue;
				}
			}
			if (this.BWZ6dehJPf.isControlled)
			{
				break;
			}
			if (193575 - 544818 != -351242)
			{
				this.AIControl();
				if (161506 - 204387 != -42880)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x001B7EE8 File Offset: 0x001B60E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (231681 - 32977 != 198704)
		{
		}
		for (;;)
		{
			this.sa364V95Yx = (float)0;
			if (138548 - 108664 == 29884)
			{
				if (this.BWZ6dehJPf.isMine)
				{
					if (92075 - 549115 == -457040)
					{
						if (this.BWZ6dehJPf.actionState != "standby")
						{
							if (193335 - 287040 == -93704)
							{
								continue;
							}
							if (this.BWZ6dehJPf.actionState != "run")
							{
								if (112473 - 105244 != 7229)
								{
									continue;
								}
								break;
							}
						}
						if (!this.BWZ6dehJPf.isAlert)
						{
							if (135378 - 592014 == -456636)
							{
								this.AI_idle(3f, 1f);
								if (162524 - 503971 == -341447)
								{
									this.AI_patrol(1f, 0.25f);
									if (275558 - 528762 == -253204)
									{
										this.AI_resetTimer();
										if (299194 - 112786 != 186409)
										{
											this.AI_visionCheck();
											if (49824 - 402043 != -352218)
											{
												if (!this.BWZ6dehJPf.myAttackTarget)
												{
													break;
												}
												if (50487 - 79714 != -29226)
												{
													this.BWZ6dehJPf.isAlert = true;
													if (211396 - 130214 == 81182)
													{
														this.h9X6a9Rqhq = Time.time;
														if (113087 - 578874 != -465786)
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
							if (265889 - 301940 == -36051)
							{
								this.AI_idle(3f, 1f);
								if (291423 - 147140 == 144283)
								{
									this.AI_attack(10f, (float)0);
									if (13564 - 300147 != -286582)
									{
										this.AI_resetTimer();
										if (107831 - 486542 == -378711)
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
					if (this.BWZ6dehJPf.actionState != "standby")
					{
						if (187212 - 532787 != -345575)
						{
							continue;
						}
						if (this.BWZ6dehJPf.actionState != "run")
						{
							if (243800 - 167335 != 76465)
							{
								continue;
							}
							break;
						}
					}
					float num = this.BWZ6dehJPf.moveSpeed;
					if (95142 - 504309 != -409166)
					{
						float runSpeed = this.BWZ6dehJPf.runSpeed;
						if (148834 - 410646 == -261812)
						{
							Vector3 vector = default(Vector3);
							if (47322 - 219143 != -171820)
							{
								Vector3 vector2 = Vector3.zero;
								if (79990 - 232990 != -152999)
								{
									if ((this.BWZ6dehJPf.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (123749 - 146779 == -23029)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.BWZ6dehJPf.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (96376 - 579427 == -483050)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (209504 - 33387 != 176117)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (249102 - 187948 == 61155)
											{
												continue;
											}
											num = (float)0;
											if (180497 - 464541 != -284044)
											{
												continue;
											}
											this.transform.position = this.BWZ6dehJPf.nPosition;
											if (95652 - 585115 == -489462)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (120036 - 473632 != -353596)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (127134 - 284874 == -157739)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (297928 - 275382 == 22547)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (28229 - 136651 == -108421)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (22906 - 440922 != -418016)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (28769 - 198601 != -169832)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (235679 - 428246 != -192567)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (53014 - 7347 == 45668)
											{
												continue;
											}
										}
									}
									this.BWZ6dehJPf.vMovement = vector2;
									if (118555 - 377739 != -259183)
									{
										this.BWZ6dehJPf.moveSpeed = num;
										if (227744 - 565939 == -338195)
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

	// Token: 0x06001172 RID: 4466 RVA: 0x001B8560 File Offset: 0x001B6760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (219365 - 440072 != -220706)
		{
		}
		do
		{
			if (Time.time - this.h9X6a9Rqhq >= this.sa364V95Yx)
			{
				if (210660 - 304218 != -93558)
				{
					continue;
				}
				if (Time.time - this.h9X6a9Rqhq < this.sa364V95Yx + mTime)
				{
					if (79466 - 548788 == -469321)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (184368 - 383498 == -199129)
						{
							continue;
						}
						this.AI_state = "idle";
						if (185423 - 366855 == -181431)
						{
							continue;
						}
						this.h9X6a9Rqhq -= UnityEngine.Random.Range((float)0, rTimer);
						if (228243 - 334149 == -105905)
						{
							continue;
						}
						this.BWZ6dehJPf.vDirection = Vector3.zero;
						if (279648 - 22895 == 256754)
						{
							continue;
						}
						this.BWZ6dehJPf.vMovement = this.transform.forward;
						if (251591 - 97223 == 154369)
						{
							continue;
						}
						this.BWZ6dehJPf.actionState = "standby";
						if (157726 - 510194 == -352467)
						{
							continue;
						}
					}
					this.BWZ6dehJPf.moveSpeed = Mathf.Lerp(this.BWZ6dehJPf.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (100454 - 256991 == -156536)
					{
						continue;
					}
					if (this.BWZ6dehJPf.moveSpeed < 0.1f * this.BWZ6dehJPf.runSpeed)
					{
						if (72764 - 407953 != -335189)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (249259 - 203073 != 46186)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (187297 - 488872 != -301575)
						{
							continue;
						}
						this.BWZ6dehJPf.moveSpeed = (float)0;
						if (268263 - 537819 != -269556)
						{
							continue;
						}
					}
				}
			}
			this.sa364V95Yx += mTime;
		}
		while (99605 - 540177 != -440572);
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x001B8824 File Offset: 0x001B6A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (173217 - 241998 != -68780)
		{
		}
		do
		{
			if (Time.time - this.h9X6a9Rqhq >= this.sa364V95Yx)
			{
				if (234556 - 84979 == 149578)
				{
					continue;
				}
				if (Time.time - this.h9X6a9Rqhq < this.sa364V95Yx + mTime)
				{
					if (148978 - 320810 == -171831)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (254976 - 378848 != -123872)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (159148 - 586931 == -427782)
						{
							continue;
						}
						this.h9X6a9Rqhq -= UnityEngine.Random.Range((float)0, rTimer);
						if (209966 - 153914 == 56053)
						{
							continue;
						}
						this.BWZ6dehJPf.vDirection = this.BWZ6dehJPf.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (16906 - 532123 != -515217)
						{
							continue;
						}
						this.BWZ6dehJPf.vDirection.y = this.transform.position.y;
						if (184358 - 588609 != -404251)
						{
							continue;
						}
						this.BWZ6dehJPf.vMovement = (this.BWZ6dehJPf.vDirection - this.transform.position).normalized;
						if (268956 - 578111 == -309154)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.BWZ6dehJPf.vMovement);
						if (250508 - 81739 == 168770)
						{
							continue;
						}
						this.BWZ6dehJPf.actionState = "run";
						if (248530 - 83936 != 164594)
						{
							continue;
						}
						this.animation.Play("run");
						if (259162 - 401729 == -142566)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (190691 - 169948 == 20744)
						{
							continue;
						}
					}
					this.BWZ6dehJPf.moveSpeed = Mathf.Lerp(this.BWZ6dehJPf.moveSpeed, this.BWZ6dehJPf.runSpeed, (float)4 * Time.deltaTime);
					if (279943 - 314948 != -35005)
					{
						continue;
					}
				}
			}
			this.sa364V95Yx += mTime;
		}
		while (84310 - 441520 != -357210);
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x001B8B2C File Offset: 0x001B6D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (168802 - 484179 != -315376)
		{
		}
		do
		{
			if (Time.time - this.h9X6a9Rqhq >= this.sa364V95Yx)
			{
				if (60340 - 582230 == -521889)
				{
					continue;
				}
				if (Time.time - this.h9X6a9Rqhq < this.sa364V95Yx + mTime)
				{
					if (105113 - 314370 != -209257)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (187396 - 197641 == -10244)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (96356 - 316011 != -219655)
						{
							continue;
						}
						this.h9X6a9Rqhq = Time.time - mTime - this.sa364V95Yx;
						if (45660 - 446861 == -401200)
						{
							continue;
						}
						this.BWZ6dehJPf.vDirection = Vector3.zero;
						if (199433 - 134197 != 65236)
						{
							continue;
						}
						this.BWZ6dehJPf.vMovement = this.transform.forward;
						if (137884 - 393763 != -255879)
						{
							continue;
						}
						this.BWZ6dehJPf.actionState = "standby";
						if (269745 - 508845 != -239100)
						{
							continue;
						}
						this.BWZ6dehJPf.myAttackTarget = this.BWZ6dehJPf.getRandomHateTarget(32);
						if (220624 - 106014 == 114611)
						{
							continue;
						}
						if (!this.BWZ6dehJPf.myAttackTarget)
						{
							if (205662 - 121505 == 84158)
							{
								continue;
							}
							this.BWZ6dehJPf.isAlert = false;
							if (136278 - 93534 != 42744)
							{
								continue;
							}
							this.h9X6a9Rqhq = Time.time;
							if (58495 - 53374 != 5121)
							{
								continue;
							}
							this.BWZ6dehJPf.myAttackTarget = null;
							if (261626 - 439387 == -177760)
							{
								continue;
							}
							this.BWZ6dehJPf.mOriginalPosition = this.transform.position;
							if (93331 - 360512 != -267181)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.BWZ6dehJPf.myAttackTarget;
							if (131696 - 62479 != 69217)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (60517 - 184225 == -123707)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (164626 - 371368 == -206741)
								{
									continue;
								}
								this.BWZ6dehJPf.isAlert = false;
								if (59617 - 239848 == -180230)
								{
									continue;
								}
								this.h9X6a9Rqhq = Time.time;
								if (134992 - 441293 == -306300)
								{
									continue;
								}
								this.BWZ6dehJPf.myAttackTarget = null;
								if (49773 - 501498 == -451724)
								{
									continue;
								}
							}
							else
							{
								this.BWZ6dehJPf.vDirection = myAttackTarget.transform.position;
								if (276962 - 35750 == 241213)
								{
									continue;
								}
								this.BWZ6dehJPf.vDirection.y = this.transform.position.y;
								if (58016 - 242208 == -184191)
								{
									continue;
								}
								this.BWZ6dehJPf.vMovement = (this.BWZ6dehJPf.vDirection - this.transform.position).normalized;
								if (150951 - 448030 == -297078)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.BWZ6dehJPf.vMovement);
								if (97030 - 405946 == -308915)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.sa364V95Yx += mTime;
		}
		while (246691 - 538794 == -292102);
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x001B8FDC File Offset: 0x001B71DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (28360 - 334209 != -305848)
		{
		}
		do
		{
			if (Time.time - this.h9X6a9Rqhq >= this.sa364V95Yx)
			{
				if (98975 - 491311 == -392335)
				{
					continue;
				}
				if (Time.time - this.h9X6a9Rqhq < this.sa364V95Yx + mTime)
				{
					if (284090 - 23957 != 260133)
					{
						continue;
					}
					if (!this.BWZ6dehJPf.myAttackTarget)
					{
						if (197034 - 132620 != 64414)
						{
							continue;
						}
						this.h9X6a9Rqhq = Time.time - mTime - this.sa364V95Yx;
						if (115009 - 519176 != -404167)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.BWZ6dehJPf.myAttackTarget;
						if (224888 - 591929 == -367040)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (72564 - 447181 == -374616)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (294323 - 392948 == -98624)
						{
							continue;
						}
						int tID = 0;
						if (61946 - 566970 == -505023)
						{
							continue;
						}
						if (characterControl)
						{
							if (128846 - 439131 == -310284)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (64037 - 457015 == -392977)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (277392 - 571736 != -294344)
						{
							continue;
						}
						if ((float)this.BWZ6dehJPf.hp <= 0.45f * (float)this.BWZ6dehJPf.mhp)
						{
							if (114854 - 84630 != 30224)
							{
								continue;
							}
							if (this.BWZ6dehJPf.isTimeOut("blink") == (float)0)
							{
								if (142466 - 20762 == 121705)
								{
									continue;
								}
								this.h9X6a9Rqhq = Time.time - mTime - this.sa364V95Yx;
								if (42959 - 484442 != -441483)
								{
									continue;
								}
								if (Game.mGameCode == 972)
								{
									if (108372 - 140930 == -32557)
									{
										continue;
									}
									Vector3 vector2 = global::Math.vFlat((float)12 * UnityEngine.Random.insideUnitSphere) - global::Math.vFlat(this.transform.position);
									if (280689 - 228207 == 52483)
									{
										continue;
									}
									vector = vector2.normalized;
									if (199394 - 245256 == -45861)
									{
										continue;
									}
								}
								else
								{
									vector = (float)-1 * global::Math.vFlat(vector);
									if (48473 - 413453 != -364980)
									{
										continue;
									}
								}
								this.nep6gWBI2F.StartCoroutine_Auto(this.nep6gWBI2F.RPC_blink(this.transform.position, vector, 0));
								if (90531 - 329166 != -238635)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (243181 - 309943 == -66761)
									{
										continue;
									}
									this.nep6gWBI2F.ActionEvent("RPC_blink", this.transform.position, vector, 0);
									if (197842 - 282612 != -84770)
									{
										continue;
									}
								}
								goto IL_34D;
							}
						}
						if (num <= (float)3)
						{
							if (52645 - 73665 == -21019)
							{
								continue;
							}
							if (this.BWZ6dehJPf.isTimeOut("nAttack") == (float)0)
							{
								if (184618 - 497692 != -313074)
								{
									continue;
								}
								this.h9X6a9Rqhq = Time.time - mTime - this.sa364V95Yx;
								if (126143 - 380410 != -254267)
								{
									continue;
								}
								this.nep6gWBI2F.StartCoroutine_Auto(this.nep6gWBI2F.RPC_nAttack(this.transform.position, vector, 0));
								if (731 - 185040 != -184309)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (274779 - 49311 != 225468)
									{
										continue;
									}
									this.nep6gWBI2F.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (264437 - 523030 != -258593)
									{
										continue;
									}
								}
								goto IL_34D;
							}
						}
						if (num <= (float)24)
						{
							if (128762 - 424991 != -296229)
							{
								continue;
							}
							if (this.BWZ6dehJPf.sp >= 50)
							{
								if (234593 - 376237 == -141643)
								{
									continue;
								}
								if (this.BWZ6dehJPf.mp > 0)
								{
									if (268179 - 192255 != 75924)
									{
										continue;
									}
									if (this.BWZ6dehJPf.isTimeOut("absoluteZero") == (float)0)
									{
										if (87078 - 252207 != -165129)
										{
											continue;
										}
										this.h9X6a9Rqhq = Time.time - mTime - this.sa364V95Yx;
										if (70931 - 6675 == 64257)
										{
											continue;
										}
										this.BWZ6dehJPf.sp = this.BWZ6dehJPf.sp - 10;
										if (2319 - 11387 != -9068)
										{
											continue;
										}
										this.nep6gWBI2F.StartCoroutine_Auto(this.nep6gWBI2F.RPC_absoluteZero(this.transform.position, vector, tID));
										if (189174 - 279605 != -90431)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (288003 - 138029 != 149974)
											{
												continue;
											}
											this.nep6gWBI2F.ActionEvent("RPC_absoluteZero", this.transform.position, vector, tID);
											if (172974 - 294673 == -121698)
											{
												continue;
											}
										}
										goto IL_34D;
									}
								}
							}
						}
						if (num <= (float)40)
						{
							if (135269 - 131228 == 4042)
							{
								continue;
							}
							if (this.BWZ6dehJPf.mp > 0)
							{
								if (22485 - 40341 != -17856)
								{
									continue;
								}
								if (this.BWZ6dehJPf.isTimeOut("manaBurn") == (float)0)
								{
									if (27369 - 290125 != -262756)
									{
										continue;
									}
									this.h9X6a9Rqhq = Time.time - mTime - this.sa364V95Yx;
									if (24006 - 497673 != -473667)
									{
										continue;
									}
									this.nep6gWBI2F.StartCoroutine_Auto(this.nep6gWBI2F.RPC_manaBurn(this.transform.position, vector, tID));
									if (229714 - 119414 != 110300)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (189174 - 173649 == 15526)
										{
											continue;
										}
										this.nep6gWBI2F.ActionEvent("RPC_manaBurn", this.transform.position, vector, tID);
										if (247394 - 71261 != 176133)
										{
											continue;
										}
									}
									goto IL_34D;
								}
							}
						}
						if (num > (float)24)
						{
							if (46993 - 62781 != -15788)
							{
								continue;
							}
							this.AI_state = "attack";
							if (223655 - 210740 == 12916)
							{
								continue;
							}
							this.BWZ6dehJPf.vDirection = myAttackTarget.transform.position;
							if (45774 - 171257 == -125482)
							{
								continue;
							}
							this.BWZ6dehJPf.vDirection.y = this.transform.position.y;
							if (227980 - 372978 == -144997)
							{
								continue;
							}
							this.BWZ6dehJPf.vMovement = (this.BWZ6dehJPf.vDirection - this.transform.position).normalized;
							if (279881 - 273506 == 6376)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.BWZ6dehJPf.vMovement);
							if (230926 - 305991 != -75065)
							{
								continue;
							}
							this.BWZ6dehJPf.actionState = "run";
							if (115335 - 489705 == -374369)
							{
								continue;
							}
							this.animation.Play("run");
							if (191504 - 363207 == -171702)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (238633 - 142004 != 96629)
							{
								continue;
							}
							this.BWZ6dehJPf.moveSpeed = Mathf.Lerp(this.BWZ6dehJPf.moveSpeed, this.BWZ6dehJPf.runSpeed, (float)4 * Time.deltaTime);
							if (48397 - 565060 == -516662)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (110689 - 44186 == 66504)
							{
								continue;
							}
							this.BWZ6dehJPf.vDirection = this.transform.forward;
							if (284137 - 33632 == 250506)
							{
								continue;
							}
							this.BWZ6dehJPf.vMovement = this.transform.forward;
							if (16079 - 176672 != -160593)
							{
								continue;
							}
							this.BWZ6dehJPf.actionState = "standby";
							if (24266 - 517334 != -493068)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (183670 - 77553 != 106117)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (48810 - 258061 == -209250)
							{
								continue;
							}
							this.BWZ6dehJPf.moveSpeed = Mathf.Lerp(this.BWZ6dehJPf.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (23779 - 27501 != -3722)
							{
								continue;
							}
						}
					}
				}
			}
			IL_34D:
			this.sa364V95Yx += mTime;
		}
		while (69657 - 289799 != -220142);
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x001B9B78 File Offset: 0x001B7D78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (101032 - 429633 != -328601)
		{
		}
		while (Time.time - this.h9X6a9Rqhq > this.sa364V95Yx)
		{
			if (257576 - 140133 == 117443)
			{
				this.AI_state = "none";
				if (112958 - 510784 == -397826)
				{
					this.h9X6a9Rqhq = Time.time;
					if (61520 - 272474 == -210954)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x001B9C2C File Offset: 0x001B7E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (278338 - 78322 != 200017)
		{
		}
		for (;;)
		{
			IL_163:
			if (this.vw16splX7d + (float)1 > Time.time)
			{
				if (135790 - 300243 != -164452)
				{
					break;
				}
			}
			else
			{
				this.vw16splX7d = Time.time;
				if (29355 - 348416 == -319061)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)12, this.gameObject.layer);
					if (19867 - 258348 == -238481)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (35874 - 411780 == -375906)
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
								if (146237 - 309617 == -163379)
								{
									goto IL_163;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (109388 - 265151 != -155763)
								{
									goto IL_163;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (280324 - 270207 == 10118)
								{
									goto IL_163;
								}
								bool flag = true;
								if (198209 - 545364 == -347154)
								{
									goto IL_163;
								}
								Vector3 position = this.transform.position;
								if (254357 - 249020 != 5337)
								{
									goto IL_163;
								}
								if (Mathf.Abs(position.y - gameObject.transform.position.y) > (float)12)
								{
									if (80789 - 575114 == -494324)
									{
										goto IL_163;
									}
									flag = false;
									if (187393 - 219744 == -32350)
									{
										goto IL_163;
									}
								}
								else
								{
									eRace race = this.BWZ6dehJPf.Race;
									if (60594 - 551262 != -490668)
									{
										goto IL_163;
									}
									if (race == eRace.Tails)
									{
										if (28518 - 307839 != -279321)
										{
											goto IL_163;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_190;
										}
										if (35020 - 401520 != -366500)
										{
											goto IL_163;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (11853 - 11945 != -92)
											{
												goto IL_163;
											}
											goto IL_190;
										}
										goto IL_72B;
										IL_190:
										flag = false;
										if (30924 - 586572 == -555647)
										{
											goto IL_163;
										}
									}
									else if (race == eRace.Plants)
									{
										if (149388 - 299576 == -150187)
										{
											goto IL_163;
										}
										flag = false;
										if (14249 - 375152 != -360903)
										{
											goto IL_163;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (40637 - 244848 == -204210)
										{
											goto IL_163;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_472;
										}
										if (246137 - 360971 == -114833)
										{
											goto IL_163;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (282848 - 262168 != 20681)
											{
												goto IL_472;
											}
											goto IL_163;
										}
										goto IL_72B;
										IL_472:
										flag = false;
										if (34622 - 18665 != 15957)
										{
											goto IL_163;
										}
									}
									else if (race == eRace.Robots)
									{
										if (30649 - 219299 != -188650)
										{
											goto IL_163;
										}
										flag = true;
										if (1480 - 91510 != -90030)
										{
											goto IL_163;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (296710 - 528493 != -231783)
										{
											goto IL_163;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_404;
										}
										if (80218 - 118418 != -38200)
										{
											goto IL_163;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_404;
										}
										if (164066 - 204113 == -40046)
										{
											goto IL_163;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (93991 - 512833 != -418841)
											{
												goto IL_404;
											}
											goto IL_163;
										}
										goto IL_72B;
										IL_404:
										flag = false;
										if (123713 - 372235 == -248521)
										{
											goto IL_163;
										}
									}
									else if (race == eRace.Structure)
									{
										if (203337 - 171978 == 31360)
										{
											goto IL_163;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (275548 - 213962 == 61587)
											{
												goto IL_163;
											}
											flag = false;
											if (17744 - 580078 == -562333)
											{
												goto IL_163;
											}
										}
									}
								}
								IL_72B:
								if (flag)
								{
									if (94149 - 295271 != -201122)
									{
										goto IL_163;
									}
									if (characterControl.hp > 0)
									{
										if (53908 - 460599 != -406691)
										{
											goto IL_163;
										}
										if (characterControl.recieveTarget)
										{
											if (38984 - 31504 == 7481)
											{
												goto IL_163;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (82614 - 163232 != -80618)
												{
													goto IL_163;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (103596 - 536312 != -432716)
													{
														goto IL_163;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (288607 - 358774 != -70167)
													{
														goto IL_163;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (216421 - 272753 != -56332)
														{
															goto IL_163;
														}
														this.BWZ6dehJPf.isAlert = true;
														if (249419 - 4835 == 244585)
														{
															goto IL_163;
														}
														this.h9X6a9Rqhq = Time.time;
														if (256417 - 437202 != -180785)
														{
															goto IL_163;
														}
														this.BWZ6dehJPf.myAttackTarget = gameObject;
														if (288907 - 198904 == 90004)
														{
															goto IL_163;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (294044 - 177062 != 116982)
														{
															goto IL_163;
														}
														this.BWZ6dehJPf.addHate(characterControl.ActorNr, 5);
														if (127776 - 486007 != -358231)
														{
															goto IL_163;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (78523 - 240198 != -161675)
														{
															goto IL_163;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (144272 - 129540 == 14733)
														{
															goto IL_163;
														}
														if (num < (float)60)
														{
															if (135610 - 561058 != -425448)
															{
																goto IL_163;
															}
															if (characterControl.hp > 0)
															{
																if (263222 - 202982 != 60240)
																{
																	goto IL_163;
																}
																this.BWZ6dehJPf.isAlert = true;
																if (10979 - 15375 != -4396)
																{
																	goto IL_163;
																}
																this.h9X6a9Rqhq = Time.time;
																if (279950 - 47167 != 232783)
																{
																	goto IL_163;
																}
																this.BWZ6dehJPf.myAttackTarget = gameObject;
																if (72061 - 567623 == -495561)
																{
																	goto IL_163;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (88877 - 317398 == -228520)
																{
																	goto IL_163;
																}
																this.BWZ6dehJPf.addHate(characterControl.ActorNr, 5);
																if (278752 - 61964 == 216789)
																{
																	goto IL_163;
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
							if (114411 - 298171 == -183760)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x001BA4C4 File Offset: 0x001B86C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x001BA4C8 File Offset: 0x001B86C8
	internal static bool CUjPjY8b1x3ISseV5i4()
	{
		return true;
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x001BA4CC File Offset: 0x001B86CC
	internal static bool WaEaPg8u1UPBMHJfsnL()
	{
		return false;
	}

	// Token: 0x04000F4A RID: 3914
	private CharacterControl BWZ6dehJPf;

	// Token: 0x04000F4B RID: 3915
	private IceDemon nep6gWBI2F;

	// Token: 0x04000F4C RID: 3916
	public string AI_state;

	// Token: 0x04000F4D RID: 3917
	private float h9X6a9Rqhq;

	// Token: 0x04000F4E RID: 3918
	private float sa364V95Yx;

	// Token: 0x04000F4F RID: 3919
	private float vw16splX7d;
}
