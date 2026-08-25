using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D3B RID: 3387
[Serializable]
public class PandaCult_AI : MonoBehaviour
{
	// Token: 0x06004C27 RID: 19495 RVA: 0x00967884 File Offset: 0x00965A84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PandaCult_AI()
	{
		if (92708 - 194989 != -102281)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (6622 - 410743 != -404120)
			{
				base..ctor();
				if (115969 - 193368 != -77398)
				{
					this.AI_state = "none";
					if (125977 - 390030 == -264053)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004C28 RID: 19496 RVA: 0x00967920 File Offset: 0x00965B20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.rkwcc18YTpj = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.oB5ccq8NRH9 = (PandaCult)this.GetComponent(typeof(PandaCult));
	}

	// Token: 0x06004C29 RID: 19497 RVA: 0x00967958 File Offset: 0x00965B58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (201819 - 314944 != -113125)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (1177 - 255569 == -254391)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (200723 - 379321 != -178598)
				{
					continue;
				}
			}
			if (this.rkwcc18YTpj.isControlled)
			{
				break;
			}
			if (233781 - 102590 == 131191)
			{
				this.AIControl();
				if (5538 - 116139 != -110600)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004C2A RID: 19498 RVA: 0x00967A24 File Offset: 0x00965C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (133377 - 437426 != -304049)
		{
		}
		for (;;)
		{
			this.sIVccR2rODh = (float)0;
			if (160194 - 299156 == -138962)
			{
				if (this.rkwcc18YTpj.isMine)
				{
					if (240660 - 516281 == -275621)
					{
						if (this.rkwcc18YTpj.actionState != "standby")
						{
							if (134652 - 207277 != -72625)
							{
								continue;
							}
							if (this.rkwcc18YTpj.actionState != "run")
							{
								if (257280 - 338264 != -80984)
								{
									continue;
								}
								break;
							}
						}
						if (!this.rkwcc18YTpj.isAlert)
						{
							if (63594 - 418069 != -354474)
							{
								this.AI_idle(3f, 1f);
								if (144500 - 260294 == -115794)
								{
									this.AI_patrol(1f, 0.25f);
									if (86361 - 167717 == -81356)
									{
										this.AI_resetTimer();
										if (144190 - 443925 != -299734)
										{
											this.AI_visionCheck();
											if (283143 - 516026 == -232883)
											{
												if (!this.rkwcc18YTpj.myAttackTarget)
												{
													break;
												}
												if (5810 - 56901 != -51090)
												{
													this.rkwcc18YTpj.isAlert = true;
													if (188942 - 36789 == 152153)
													{
														this.S2qccprS04D = Time.time;
														if (276658 - 350146 != -73487)
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
							if (26546 - 193194 != -166647)
							{
								this.AI_idle(1f, 1f);
								if (129696 - 157139 == -27443)
								{
									this.AI_attack(10f, (float)0);
									if (101725 - 219754 != -118028)
									{
										this.AI_resetTimer();
										if (120705 - 158044 != -37338)
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
					if (this.rkwcc18YTpj.actionState != "standby")
					{
						if (97636 - 129711 == -32074)
						{
							continue;
						}
						if (this.rkwcc18YTpj.actionState != "run")
						{
							if (109546 - 315403 != -205856)
							{
								break;
							}
							continue;
						}
					}
					float num = this.rkwcc18YTpj.moveSpeed;
					if (259549 - 199906 != 59644)
					{
						float runSpeed = this.rkwcc18YTpj.runSpeed;
						if (32665 - 68939 != -36273)
						{
							Vector3 vector = default(Vector3);
							if (48064 - 480908 != -432843)
							{
								Vector3 vector2 = Vector3.zero;
								if (145415 - 176196 == -30781)
								{
									if ((this.rkwcc18YTpj.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (159237 - 171369 != -12132)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.rkwcc18YTpj.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (199130 - 147547 == 51584)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (151838 - 183124 != -31286)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (133946 - 298795 != -164849)
											{
												continue;
											}
											num = (float)0;
											if (235809 - 495952 == -260142)
											{
												continue;
											}
											this.transform.position = this.rkwcc18YTpj.nPosition;
											if (216451 - 439982 == -223530)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (54448 - 120135 != -65687)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (247493 - 172450 == 75044)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (95146 - 37012 == 58135)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (259990 - 11993 != 247997)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (181943 - 360236 == -178292)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (86941 - 450624 == -363682)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (253026 - 59689 != 193337)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (86814 - 471658 != -384844)
											{
												continue;
											}
										}
									}
									this.rkwcc18YTpj.vMovement = vector2;
									if (67864 - 511007 != -443142)
									{
										this.rkwcc18YTpj.moveSpeed = num;
										if (249745 - 388258 == -138513)
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

	// Token: 0x06004C2B RID: 19499 RVA: 0x0096809C File Offset: 0x0096629C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (225510 - 374471 != -148960)
		{
		}
		do
		{
			if (Time.time - this.S2qccprS04D >= this.sIVccR2rODh)
			{
				if (123072 - 494755 == -371682)
				{
					continue;
				}
				if (Time.time - this.S2qccprS04D < this.sIVccR2rODh + mTime)
				{
					if (240107 - 320060 == -79952)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (186290 - 269584 != -83294)
						{
							continue;
						}
						this.AI_state = "idle";
						if (269607 - 467785 != -198178)
						{
							continue;
						}
						this.S2qccprS04D -= UnityEngine.Random.Range((float)0, rTimer);
						if (191478 - 452541 != -261063)
						{
							continue;
						}
						this.rkwcc18YTpj.vDirection = Vector3.zero;
						if (74107 - 424681 != -350574)
						{
							continue;
						}
						this.rkwcc18YTpj.vMovement = this.transform.forward;
						if (267114 - 123683 != 143431)
						{
							continue;
						}
						this.rkwcc18YTpj.actionState = "standby";
						if (133074 - 44618 == 88457)
						{
							continue;
						}
					}
					this.rkwcc18YTpj.moveSpeed = Mathf.Lerp(this.rkwcc18YTpj.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (199837 - 409685 == -209847)
					{
						continue;
					}
					if (this.rkwcc18YTpj.moveSpeed < 0.1f * this.rkwcc18YTpj.runSpeed)
					{
						if (159804 - 59503 != 100301)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (193057 - 458211 != -265154)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (163509 - 454155 != -290646)
						{
							continue;
						}
						this.rkwcc18YTpj.moveSpeed = (float)0;
						if (131800 - 458214 == -326413)
						{
							continue;
						}
					}
				}
			}
			this.sIVccR2rODh += mTime;
		}
		while (12186 - 431275 == -419088);
	}

	// Token: 0x06004C2C RID: 19500 RVA: 0x00968360 File Offset: 0x00966560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (128307 - 6619 != 121688)
		{
		}
		do
		{
			if (Time.time - this.S2qccprS04D >= this.sIVccR2rODh)
			{
				if (90173 - 473820 == -383646)
				{
					continue;
				}
				if (Time.time - this.S2qccprS04D < this.sIVccR2rODh + mTime)
				{
					if (142065 - 379868 == -237802)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (106218 - 579481 == -473262)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (129625 - 102235 != 27390)
						{
							continue;
						}
						this.S2qccprS04D -= UnityEngine.Random.Range((float)0, rTimer);
						if (22289 - 348878 == -326588)
						{
							continue;
						}
						this.rkwcc18YTpj.vDirection = this.rkwcc18YTpj.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (159698 - 417138 == -257439)
						{
							continue;
						}
						this.rkwcc18YTpj.vDirection.y = this.transform.position.y;
						if (265551 - 221852 != 43699)
						{
							continue;
						}
						this.rkwcc18YTpj.vMovement = (this.rkwcc18YTpj.vDirection - this.transform.position).normalized;
						if (112343 - 247901 == -135557)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.rkwcc18YTpj.vMovement);
						if (175510 - 92536 == 82975)
						{
							continue;
						}
						this.rkwcc18YTpj.actionState = "run";
						if (299715 - 179309 == 120407)
						{
							continue;
						}
						this.animation.Play("run");
						if (96054 - 379095 != -283041)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (179220 - 270397 != -91177)
						{
							continue;
						}
					}
					this.rkwcc18YTpj.moveSpeed = Mathf.Lerp(this.rkwcc18YTpj.moveSpeed, this.rkwcc18YTpj.runSpeed, (float)4 * Time.deltaTime);
					if (106415 - 439443 == -333027)
					{
						continue;
					}
				}
			}
			this.sIVccR2rODh += mTime;
		}
		while (158099 - 400983 == -242883);
	}

	// Token: 0x06004C2D RID: 19501 RVA: 0x00968668 File Offset: 0x00966868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (100162 - 580246 != -480083)
		{
		}
		do
		{
			if (Time.time - this.S2qccprS04D >= this.sIVccR2rODh)
			{
				if (265578 - 266006 == -427)
				{
					continue;
				}
				if (Time.time - this.S2qccprS04D < this.sIVccR2rODh + mTime)
				{
					if (225077 - 90231 == 134847)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (19601 - 202997 != -183396)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (203975 - 262813 != -58838)
						{
							continue;
						}
						this.S2qccprS04D = Time.time - mTime - this.sIVccR2rODh;
						if (52531 - 587653 != -535122)
						{
							continue;
						}
						this.rkwcc18YTpj.vDirection = Vector3.zero;
						if (282798 - 152341 != 130457)
						{
							continue;
						}
						this.rkwcc18YTpj.vMovement = this.transform.forward;
						if (51802 - 184394 == -132591)
						{
							continue;
						}
						this.rkwcc18YTpj.actionState = "standby";
						if (211943 - 141045 != 70898)
						{
							continue;
						}
						this.rkwcc18YTpj.myAttackTarget = this.rkwcc18YTpj.getHateTarget(5, 50);
						if (32703 - 266442 == -233738)
						{
							continue;
						}
						if (!this.rkwcc18YTpj.myAttackTarget)
						{
							if (270092 - 441376 == -171283)
							{
								continue;
							}
							this.rkwcc18YTpj.isAlert = false;
							if (233884 - 573882 != -339998)
							{
								continue;
							}
							this.S2qccprS04D = Time.time;
							if (62607 - 198441 != -135834)
							{
								continue;
							}
							this.rkwcc18YTpj.myAttackTarget = null;
							if (281144 - 444353 == -163208)
							{
								continue;
							}
							this.rkwcc18YTpj.mOriginalPosition = this.transform.position;
							if (259473 - 273800 != -14327)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.rkwcc18YTpj.myAttackTarget;
							if (191179 - 94638 == 96542)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (146775 - 450916 != -304141)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (182433 - 63404 != 119029)
								{
									continue;
								}
								this.rkwcc18YTpj.isAlert = false;
								if (96879 - 384302 != -287423)
								{
									continue;
								}
								this.S2qccprS04D = Time.time;
								if (237897 - 463157 != -225260)
								{
									continue;
								}
								this.rkwcc18YTpj.myAttackTarget = null;
								if (77010 - 302246 != -225236)
								{
									continue;
								}
							}
							else
							{
								this.rkwcc18YTpj.vDirection = myAttackTarget.transform.position;
								if (173222 - 251357 != -78135)
								{
									continue;
								}
								this.rkwcc18YTpj.vDirection.y = this.transform.position.y;
								if (210663 - 394233 == -183569)
								{
									continue;
								}
								this.rkwcc18YTpj.vMovement = (this.rkwcc18YTpj.vDirection - this.transform.position).normalized;
								if (261894 - 182469 == 79426)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.rkwcc18YTpj.vMovement);
								if (139663 - 279485 == -139821)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.sIVccR2rODh += mTime;
		}
		while (184220 - 312731 != -128511);
	}

	// Token: 0x06004C2E RID: 19502 RVA: 0x00968B18 File Offset: 0x00966D18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (192044 - 39794 != 152250)
		{
		}
		do
		{
			if (Time.time - this.S2qccprS04D >= this.sIVccR2rODh)
			{
				if (222775 - 56577 != 166198)
				{
					continue;
				}
				if (Time.time - this.S2qccprS04D < this.sIVccR2rODh + mTime)
				{
					if (82485 - 128168 != -45683)
					{
						continue;
					}
					if (!this.rkwcc18YTpj.myAttackTarget)
					{
						if (31567 - 162136 == -130568)
						{
							continue;
						}
						this.S2qccprS04D = Time.time - mTime - this.sIVccR2rODh;
						if (144181 - 74786 != 69396)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.rkwcc18YTpj.myAttackTarget;
						if (257726 - 539228 == -281501)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (205532 - 68499 != 137033)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (132870 - 462765 == -329894)
						{
							continue;
						}
						int tID = 0;
						if (186055 - 528096 == -342040)
						{
							continue;
						}
						if (characterControl)
						{
							if (28441 - 382278 != -353837)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (214703 - 316902 != -102199)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (90540 - 185678 != -95138)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (118377 - 148734 == -30356)
							{
								continue;
							}
							if (this.rkwcc18YTpj.isTimeOut("drunkenFist") == (float)0)
							{
								if (18421 - 274911 != -256490)
								{
									continue;
								}
								this.S2qccprS04D = Time.time - mTime - this.sIVccR2rODh;
								if (4635 - 485090 != -480455)
								{
									continue;
								}
								this.oB5ccq8NRH9.StartCoroutine_Auto(this.oB5ccq8NRH9.RPC_drunkenFist(this.transform.position, vector, tID));
								if (139363 - 487600 != -348237)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (94691 - 163180 != -68489)
									{
										continue;
									}
									this.oB5ccq8NRH9.ActionEvent("drunkenFist", this.transform.position, vector, tID);
									if (246640 - 560847 != -314207)
									{
										continue;
									}
								}
								goto IL_645;
							}
						}
						if (num < (float)2)
						{
							if (71166 - 200666 == -129499)
							{
								continue;
							}
							if (this.rkwcc18YTpj.isTimeOut("nAttack") == (float)0)
							{
								if (208809 - 213784 != -4975)
								{
									continue;
								}
								this.S2qccprS04D = Time.time - mTime - this.sIVccR2rODh;
								if (59832 - 582888 != -523056)
								{
									continue;
								}
								this.oB5ccq8NRH9.StartCoroutine_Auto(this.oB5ccq8NRH9.RPC_nAttack(this.transform.position, vector, tID));
								if (175043 - 495928 != -320884)
								{
									if (PhotonClient.IsInitialized())
									{
										if (279727 - 329622 != -49895)
										{
											continue;
										}
										this.oB5ccq8NRH9.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
										if (265119 - 352722 != -87603)
										{
											continue;
										}
									}
									goto IL_645;
								}
								continue;
							}
						}
						if (num < (float)3)
						{
							if (63711 - 123913 == -60201)
							{
								continue;
							}
							if (this.rkwcc18YTpj.sp > 40)
							{
								if (199699 - 257108 == -57408)
								{
									continue;
								}
								if (this.rkwcc18YTpj.isTimeOut("qiStrike") == (float)0)
								{
									if (225466 - 103965 != 121501)
									{
										continue;
									}
									this.S2qccprS04D = Time.time - mTime - this.sIVccR2rODh;
									if (150463 - 259613 != -109150)
									{
										continue;
									}
									this.oB5ccq8NRH9.StartCoroutine_Auto(this.oB5ccq8NRH9.RPC_qiStrike1(this.transform.position, vector, tID));
									if (81968 - 554960 != -472992)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (47938 - 590818 != -542880)
										{
											continue;
										}
										this.oB5ccq8NRH9.ActionEvent("RPC_qiStrike1", this.transform.position, vector, tID);
										if (181036 - 563404 == -382367)
										{
											continue;
										}
									}
									goto IL_645;
								}
							}
						}
						if (num > (float)12)
						{
							if (253340 - 366792 != -113452)
							{
								continue;
							}
							if (this.rkwcc18YTpj.isTimeOut("roll") == (float)0)
							{
								if (247499 - 270235 == -22735)
								{
									continue;
								}
								this.S2qccprS04D = Time.time - mTime - this.sIVccR2rODh;
								if (32243 - 220417 == -188173)
								{
									continue;
								}
								this.oB5ccq8NRH9.StartCoroutine_Auto(this.oB5ccq8NRH9.RPC_roll(this.transform.position, vector, tID));
								if (169949 - 354206 != -184256)
								{
									if (PhotonClient.IsInitialized())
									{
										if (19428 - 412821 != -393393)
										{
											continue;
										}
										this.oB5ccq8NRH9.ActionEvent("RPC_roll", this.transform.position, vector, tID);
										if (281920 - 156446 == 125475)
										{
											continue;
										}
									}
									goto IL_645;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (141622 - 69530 != 72092)
						{
							continue;
						}
						this.rkwcc18YTpj.vDirection = myAttackTarget.transform.position;
						if (258460 - 250495 == 7966)
						{
							continue;
						}
						this.rkwcc18YTpj.vDirection.y = this.transform.position.y;
						if (44687 - 352775 == -308087)
						{
							continue;
						}
						this.rkwcc18YTpj.vMovement = (this.rkwcc18YTpj.vDirection - this.transform.position).normalized;
						if (266068 - 499685 != -233617)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.rkwcc18YTpj.vMovement);
						if (106218 - 538677 == -432458)
						{
							continue;
						}
						this.rkwcc18YTpj.actionState = "run";
						if (226245 - 313550 != -87305)
						{
							continue;
						}
						this.animation.Play("run");
						if (209220 - 567273 != -358053)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (14101 - 581702 == -567600)
						{
							continue;
						}
						this.rkwcc18YTpj.moveSpeed = Mathf.Lerp(this.rkwcc18YTpj.moveSpeed, this.rkwcc18YTpj.runSpeed, (float)4 * Time.deltaTime);
						if (14219 - 159261 == -145041)
						{
							continue;
						}
					}
				}
			}
			IL_645:
			this.sIVccR2rODh += mTime;
		}
		while (95850 - 183706 == -87855);
	}

	// Token: 0x06004C2F RID: 19503 RVA: 0x009693F0 File Offset: 0x009675F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (283659 - 489156 != -205496)
		{
		}
		while (Time.time - this.S2qccprS04D > this.sIVccR2rODh)
		{
			if (243013 - 184267 != 58747)
			{
				this.AI_state = "none";
				if (85597 - 299834 != -214236)
				{
					this.S2qccprS04D = Time.time;
					if (34190 - 28971 == 5219)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004C30 RID: 19504 RVA: 0x009694A4 File Offset: 0x009676A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (24033 - 433630 != -409597)
		{
		}
		for (;;)
		{
			IL_57B:
			if (this.Hk2ccrSnc3n > Time.time)
			{
				if (57811 - 130693 == -72882)
				{
					break;
				}
			}
			else
			{
				this.Hk2ccrSnc3n = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (207747 - 96483 == 111264)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (61123 - 444447 != -383323)
					{
						if (225173 - 416495 == -191322)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (181993 - 274432 != -92438)
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
									if (182865 - 261282 == -78416)
									{
										goto IL_57B;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (175980 - 202505 != -26525)
									{
										goto IL_57B;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (18039 - 459044 != -441005)
									{
										goto IL_57B;
									}
									bool flag = true;
									if (135126 - 207781 != -72655)
									{
										goto IL_57B;
									}
									eRace race = this.rkwcc18YTpj.Race;
									if (18223 - 26391 == -8167)
									{
										goto IL_57B;
									}
									if (race == eRace.Tails)
									{
										if (47627 - 152741 == -105113)
										{
											goto IL_57B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_1F9;
										}
										if (98517 - 220636 == -122118)
										{
											goto IL_57B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (10922 - 502101 != -491178)
											{
												goto IL_1F9;
											}
											goto IL_57B;
										}
										goto IL_464;
										IL_1F9:
										flag = false;
										if (81557 - 517044 != -435487)
										{
											goto IL_57B;
										}
									}
									else if (race == eRace.Plants)
									{
										if (245854 - 191389 != 54465)
										{
											goto IL_57B;
										}
										flag = false;
										if (121020 - 551579 == -430558)
										{
											goto IL_57B;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (38928 - 257170 != -218242)
										{
											goto IL_57B;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_107;
										}
										if (245808 - 114722 == 131087)
										{
											goto IL_57B;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (41425 - 597667 != -556242)
											{
												goto IL_57B;
											}
											goto IL_107;
										}
										goto IL_464;
										IL_107:
										flag = false;
										if (173515 - 287854 == -114338)
										{
											goto IL_57B;
										}
									}
									else if (race == eRace.Robots)
									{
										if (37977 - 145123 != -107146)
										{
											goto IL_57B;
										}
										flag = true;
										if (284439 - 342360 != -57921)
										{
											goto IL_57B;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (259504 - 545622 != -286118)
										{
											goto IL_57B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_716;
										}
										if (144785 - 98476 != 46309)
										{
											goto IL_57B;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_716;
										}
										if (127550 - 264731 != -137181)
										{
											goto IL_57B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (216173 - 249159 != -32985)
											{
												goto IL_716;
											}
											goto IL_57B;
										}
										goto IL_464;
										IL_716:
										flag = false;
										if (52712 - 101455 != -48743)
										{
											goto IL_57B;
										}
									}
									else if (race == eRace.Structure)
									{
										if (9554 - 593159 == -583604)
										{
											goto IL_57B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (291314 - 473418 != -182104)
											{
												goto IL_57B;
											}
											flag = false;
											if (81395 - 21708 != 59687)
											{
												goto IL_57B;
											}
										}
									}
									IL_464:
									if (flag)
									{
										if (280979 - 5290 == 275690)
										{
											goto IL_57B;
										}
										if (characterControl.hp > 0)
										{
											if (66825 - 565002 == -498176)
											{
												goto IL_57B;
											}
											if (characterControl.recieveTarget)
											{
												if (85969 - 158444 != -72475)
												{
													goto IL_57B;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (59478 - 362800 == -303321)
													{
														goto IL_57B;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (5590 - 144749 == -139158)
														{
															goto IL_57B;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (144480 - 198032 != -53552)
														{
															goto IL_57B;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (298528 - 503740 == -205211)
															{
																goto IL_57B;
															}
															this.rkwcc18YTpj.myAttackTarget = gameObject;
															if (146738 - 278883 == -132144)
															{
																goto IL_57B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (73739 - 596751 != -523012)
															{
																goto IL_57B;
															}
															this.rkwcc18YTpj.addHate(characterControl.ActorNr, 5);
															if (263432 - 440049 == -176616)
															{
																goto IL_57B;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (12381 - 430763 != -418382)
															{
																goto IL_57B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (259351 - 192491 == 66861)
															{
																goto IL_57B;
															}
															if (num < (float)60)
															{
																if (235269 - 353899 != -118630)
																{
																	goto IL_57B;
																}
																if (characterControl.hp > 0)
																{
																	if (161626 - 211763 != -50137)
																	{
																		goto IL_57B;
																	}
																	this.rkwcc18YTpj.myAttackTarget = gameObject;
																	if (143805 - 406875 == -263069)
																	{
																		goto IL_57B;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (109974 - 341623 == -231648)
																	{
																		goto IL_57B;
																	}
																	this.rkwcc18YTpj.addHate(characterControl.ActorNr, 5);
																	if (268900 - 289723 != -20823)
																	{
																		goto IL_57B;
																	}
																}
															}
														}
														if (this.rkwcc18YTpj.myAttackTarget)
														{
															if (210496 - 541998 != -331502)
															{
																goto IL_57B;
															}
															this.rkwcc18YTpj.isAlert = true;
															if (104221 - 55143 == 49079)
															{
																goto IL_57B;
															}
															this.S2qccprS04D = Time.time;
															if (93484 - 250240 != -156756)
															{
																goto IL_57B;
															}
														}
													}
												}
											}
										}
									}
								}
								if (230861 - 386756 != -155894)
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

	// Token: 0x06004C31 RID: 19505 RVA: 0x00969CBC File Offset: 0x00967EBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004C32 RID: 19506 RVA: 0x00969CC0 File Offset: 0x00967EC0
	internal static bool Kv8gLN5PHQNugjDXv9sB()
	{
		return true;
	}

	// Token: 0x06004C33 RID: 19507 RVA: 0x00969CC4 File Offset: 0x00967EC4
	internal static bool oEdPmN5PW3P4SE7P6o2d()
	{
		return false;
	}

	// Token: 0x0400568B RID: 22155
	private CharacterControl rkwcc18YTpj;

	// Token: 0x0400568C RID: 22156
	private PandaCult oB5ccq8NRH9;

	// Token: 0x0400568D RID: 22157
	public string AI_state;

	// Token: 0x0400568E RID: 22158
	private float S2qccprS04D;

	// Token: 0x0400568F RID: 22159
	private float sIVccR2rODh;

	// Token: 0x04005690 RID: 22160
	private float Hk2ccrSnc3n;
}
