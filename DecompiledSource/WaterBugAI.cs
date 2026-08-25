using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000243 RID: 579
[Serializable]
public class WaterBugAI : MonoBehaviour
{
	// Token: 0x06000D27 RID: 3367 RVA: 0x0014DD8C File Offset: 0x0014BF8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WaterBugAI()
	{
		if (143539 - 581810 != -438270)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (122653 - 580999 != -458345)
			{
				base..ctor();
				if (91009 - 274556 == -183547)
				{
					this.AI_state = "none";
					if (9832 - 34295 == -24463)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x0014DE28 File Offset: 0x0014C028
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.E35I1UZCxG = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.TZmIqCbBuT = (WaterBug)this.GetComponent(typeof(WaterBug));
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x0014DE60 File Offset: 0x0014C060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (203283 - 131720 != 71564)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (10136 - 238045 != -227909)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (282875 - 474190 != -191315)
				{
					continue;
				}
			}
			if (this.E35I1UZCxG.isControlled)
			{
				break;
			}
			if (39932 - 477767 != -437834)
			{
				this.AIControl();
				if (140717 - 452838 == -312121)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x0014DF2C File Offset: 0x0014C12C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (227735 - 218758 != 8977)
		{
		}
		for (;;)
		{
			this.gHnIR5f05y = (float)0;
			if (8672 - 248355 != -239682)
			{
				if (this.E35I1UZCxG.isMine)
				{
					if (22623 - 90877 == -68254)
					{
						if (this.E35I1UZCxG.actionState != "standby")
						{
							if (254884 - 438487 != -183603)
							{
								continue;
							}
							if (this.E35I1UZCxG.actionState != "run")
							{
								if (921 - 514174 != -513253)
								{
									continue;
								}
								break;
							}
						}
						if (!this.E35I1UZCxG.isAlert)
						{
							if (296665 - 427509 == -130844)
							{
								this.AI_idle(3f, 1f);
								if (208973 - 271171 != -62197)
								{
									this.AI_patrol(2f, 0.25f);
									if (137525 - 222742 == -85217)
									{
										this.AI_resetTimer();
										if (288812 - 198296 == 90516)
										{
											this.AI_visionCheck();
											if (233971 - 338864 != -104892)
											{
												if (!this.E35I1UZCxG.myAttackTarget)
												{
													break;
												}
												if (95417 - 394188 != -298770)
												{
													this.E35I1UZCxG.isAlert = true;
													if (78301 - 269603 == -191302)
													{
														this.L3XIpBZqdx = Time.time;
														if (30474 - 489914 == -459440)
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
							if (44984 - 130324 == -85340)
							{
								this.AI_idle(2f, 1f);
								if (11881 - 126144 == -114263)
								{
									this.AI_patrol(2f, 1f);
									if (206372 - 392352 == -185980)
									{
										this.AI_attack(4f, (float)0);
										if (228846 - 388012 != -159165)
										{
											this.AI_resetTimer();
											if (24913 - 352620 != -327706)
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
					if (this.E35I1UZCxG.actionState != "standby")
					{
						if (116450 - 237812 == -121361)
						{
							continue;
						}
						if (this.E35I1UZCxG.actionState != "run")
						{
							if (89157 - 509695 != -420537)
							{
								break;
							}
							continue;
						}
					}
					if (this.E35I1UZCxG.nSpeed != (float)0)
					{
						if (250454 - 142529 == 107926)
						{
							continue;
						}
						if (this.E35I1UZCxG.nPosition != this.E35I1UZCxG.oPosition)
						{
							if (15885 - 66833 == -50947)
							{
								continue;
							}
							Vector3 a = this.E35I1UZCxG.nPosition + 0.1f * this.E35I1UZCxG.runSpeed * this.E35I1UZCxG.nDirection;
							if (268475 - 357403 != -88928)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (40815 - 28550 != 12265)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (156659 - 16527 == 140133)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (281552 - 7620 == 273933)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (1271 - 598603 == -597331)
							{
								continue;
							}
							if (magnitude > this.E35I1UZCxG.runSpeed)
							{
								if (256060 - 275780 != -19720)
								{
									continue;
								}
								this.transform.position = this.E35I1UZCxG.nPosition;
								if (262614 - 119316 != 143298)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.E35I1UZCxG.runSpeed)
							{
								if (75427 - 240828 == -165400)
								{
									continue;
								}
								this.E35I1UZCxG.moveSpeed = Mathf.Lerp(this.E35I1UZCxG.moveSpeed, 1.1f * this.E35I1UZCxG.runSpeed, (float)10 * Time.deltaTime);
								if (99424 - 596662 == -497237)
								{
									continue;
								}
								this.E35I1UZCxG.vDirection = normalized;
								if (192964 - 178533 != 14431)
								{
									continue;
								}
								this.E35I1UZCxG.vMovement = normalized;
								if (49329 - 458402 == -409072)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (138731 - 371785 != -233054)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (31085 - 299675 != -268590)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (80534 - 246537 != -166003)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (100349 - 509043 != -408694)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (162155 - 491996 != -329840)
								{
									break;
								}
								continue;
							}
							else
							{
								this.E35I1UZCxG.moveSpeed = Mathf.Lerp(this.E35I1UZCxG.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (155642 - 576074 != -420432)
								{
									continue;
								}
								this.E35I1UZCxG.vDirection = normalized;
								if (124977 - 249669 == -124691)
								{
									continue;
								}
								this.E35I1UZCxG.vMovement = normalized;
								if (172696 - 499019 != -326323)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (276898 - 335748 != -58850)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (190305 - 9426 != 180880)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.E35I1UZCxG.moveSpeed != (float)0)
					{
						if (163229 - 36053 == 127176)
						{
							Vector3 vector3 = global::Math.vFlat(this.E35I1UZCxG.nPosition - this.transform.position);
							if (162823 - 185034 != -22210)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (244571 - 488032 != -243460)
								{
									if (sqrMagnitude > this.E35I1UZCxG.runSpeed)
									{
										if (243073 - 307235 != -64161)
										{
											this.transform.position = this.E35I1UZCxG.nPosition;
											if (73133 - 344228 == -271095)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (47373 - 199847 == -152474)
										{
											if (sqrMagnitude > (float)1)
											{
												if (74767 - 265736 == -190968)
												{
													continue;
												}
												this.E35I1UZCxG.moveSpeed = Mathf.Lerp(this.E35I1UZCxG.moveSpeed, this.E35I1UZCxG.runSpeed, (float)10 * Time.deltaTime);
												if (164965 - 509420 == -344454)
												{
													continue;
												}
											}
											else
											{
												this.E35I1UZCxG.moveSpeed = Mathf.Lerp(this.E35I1UZCxG.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (252448 - 266878 != -14430)
												{
													continue;
												}
											}
											this.E35I1UZCxG.vMovement = vector3;
											if (178933 - 107523 != 71411)
											{
												this.E35I1UZCxG.vDirection = vector3;
												if (242066 - 495994 == -253928)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (235484 - 318502 == -83018)
													{
														this.animation.CrossFade("run", 0.2f);
														if (9540 - 196096 == -186556)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (57268 - 57352 == -84)
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
										this.E35I1UZCxG.vMovement = vector3;
										if (259916 - 58458 != 201459)
										{
											this.E35I1UZCxG.moveSpeed = (float)0;
											if (143 - 301102 == -300959)
											{
												this.transform.rotation = Quaternion.LookRotation(this.E35I1UZCxG.vDirection);
												if (84689 - 419678 != -334988)
												{
													this.animation.CrossFade("root", 0.2f);
													if (72612 - 196449 == -123837)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (177560 - 74659 != 102902)
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
					else
					{
						this.animation.CrossFade("root", 0.2f);
						if (13498 - 434468 == -420970)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (239562 - 529107 != -289544)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000D2B RID: 3371 RVA: 0x0014EAD8 File Offset: 0x0014CCD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (143031 - 284714 != -141683)
		{
		}
		do
		{
			if (Time.time - this.L3XIpBZqdx >= this.gHnIR5f05y)
			{
				if (251812 - 455948 != -204136)
				{
					continue;
				}
				if (Time.time - this.L3XIpBZqdx < this.gHnIR5f05y + mTime)
				{
					if (96499 - 333665 == -237165)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (190678 - 124003 == 66676)
						{
							continue;
						}
						this.AI_state = "idle";
						if (112006 - 186756 == -74749)
						{
							continue;
						}
						this.L3XIpBZqdx -= UnityEngine.Random.Range((float)0, rTimer);
						if (144122 - 309965 == -165842)
						{
							continue;
						}
						this.E35I1UZCxG.vDirection = Vector3.zero;
						if (16841 - 348889 != -332048)
						{
							continue;
						}
						this.E35I1UZCxG.vMovement = this.transform.forward;
						if (91662 - 435242 == -343579)
						{
							continue;
						}
						this.E35I1UZCxG.actionState = "standby";
						if (153964 - 28808 != 125156)
						{
							continue;
						}
					}
					this.E35I1UZCxG.moveSpeed = Mathf.Lerp(this.E35I1UZCxG.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (1800 - 332134 == -330333)
					{
						continue;
					}
					if (this.E35I1UZCxG.moveSpeed < 0.1f * this.E35I1UZCxG.runSpeed)
					{
						if (249926 - 368993 != -119067)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (94195 - 403956 != -309761)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (284050 - 394780 == -110729)
						{
							continue;
						}
						this.E35I1UZCxG.moveSpeed = (float)0;
						if (122027 - 317561 != -195534)
						{
							continue;
						}
					}
				}
			}
			this.gHnIR5f05y += mTime;
		}
		while (284585 - 338943 != -54358);
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x0014ED9C File Offset: 0x0014CF9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (238129 - 348180 != -110050)
		{
		}
		do
		{
			if (Time.time - this.L3XIpBZqdx >= this.gHnIR5f05y)
			{
				if (242532 - 387652 != -145120)
				{
					continue;
				}
				if (Time.time - this.L3XIpBZqdx < this.gHnIR5f05y + mTime)
				{
					if (53071 - 194331 == -141259)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (44879 - 166950 != -122071)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (211934 - 569144 == -357209)
						{
							continue;
						}
						this.L3XIpBZqdx -= UnityEngine.Random.Range((float)0, rTimer);
						if (53185 - 197141 == -143955)
						{
							continue;
						}
						this.E35I1UZCxG.vDirection = this.E35I1UZCxG.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (173081 - 403671 == -230589)
						{
							continue;
						}
						this.E35I1UZCxG.vDirection.y = this.transform.position.y;
						if (104137 - 207168 == -103030)
						{
							continue;
						}
						this.E35I1UZCxG.vMovement = (this.E35I1UZCxG.vDirection - this.transform.position).normalized;
						if (93439 - 595621 == -502181)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.E35I1UZCxG.vMovement);
						if (125159 - 462354 != -337195)
						{
							continue;
						}
						this.E35I1UZCxG.actionState = "run";
						if (114329 - 229544 == -115214)
						{
							continue;
						}
						this.animation.Play("run");
						if (10065 - 50237 != -40172)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (72339 - 306667 != -234328)
						{
							continue;
						}
					}
					this.E35I1UZCxG.moveSpeed = Mathf.Lerp(this.E35I1UZCxG.moveSpeed, this.E35I1UZCxG.runSpeed, (float)4 * Time.deltaTime);
					if (177726 - 293759 != -116033)
					{
						continue;
					}
				}
			}
			this.gHnIR5f05y += mTime;
		}
		while (6739 - 515483 == -508743);
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x0014F0A4 File Offset: 0x0014D2A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (54694 - 498063 != -443368)
		{
		}
		do
		{
			if (Time.time - this.L3XIpBZqdx >= this.gHnIR5f05y)
			{
				if (205210 - 526380 != -321170)
				{
					continue;
				}
				if (Time.time - this.L3XIpBZqdx < this.gHnIR5f05y + mTime)
				{
					if (275439 - 384037 == -108597)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (183876 - 81555 != 102321)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (26705 - 469738 == -443032)
						{
							continue;
						}
						this.L3XIpBZqdx = Time.time - mTime - this.gHnIR5f05y;
						if (59496 - 253084 != -193588)
						{
							continue;
						}
						this.E35I1UZCxG.vDirection = Vector3.zero;
						if (21173 - 18942 != 2231)
						{
							continue;
						}
						this.E35I1UZCxG.vMovement = this.transform.forward;
						if (82217 - 521616 != -439399)
						{
							continue;
						}
						this.E35I1UZCxG.actionState = "standby";
						if (151465 - 306146 == -154680)
						{
							continue;
						}
						this.E35I1UZCxG.myAttackTarget = this.E35I1UZCxG.getHateTarget(15, 40);
						if (40803 - 380794 == -339990)
						{
							continue;
						}
						if (!this.E35I1UZCxG.myAttackTarget)
						{
							if (8323 - 397407 != -389084)
							{
								continue;
							}
							this.E35I1UZCxG.isAlert = false;
							if (55593 - 587341 != -531748)
							{
								continue;
							}
							this.L3XIpBZqdx = Time.time;
							if (123486 - 460321 == -336834)
							{
								continue;
							}
							this.E35I1UZCxG.myAttackTarget = null;
							if (55370 - 167761 != -112391)
							{
								continue;
							}
							this.E35I1UZCxG.mOriginalPosition = this.transform.position;
							if (203638 - 294597 != -90959)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.E35I1UZCxG.myAttackTarget;
							if (58492 - 416424 != -357932)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (289417 - 323318 == -33900)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (201445 - 367170 == -165724)
								{
									continue;
								}
								this.E35I1UZCxG.isAlert = false;
								if (241611 - 201791 != 39820)
								{
									continue;
								}
								this.L3XIpBZqdx = Time.time;
								if (97826 - 587927 != -490101)
								{
									continue;
								}
								this.E35I1UZCxG.myAttackTarget = null;
								if (239589 - 182650 == 56940)
								{
									continue;
								}
							}
							else
							{
								this.E35I1UZCxG.vDirection = myAttackTarget.transform.position;
								if (204510 - 586743 == -382232)
								{
									continue;
								}
								this.E35I1UZCxG.vDirection.y = this.transform.position.y;
								if (245806 - 225725 != 20081)
								{
									continue;
								}
								this.E35I1UZCxG.vMovement = (this.E35I1UZCxG.vDirection - this.transform.position).normalized;
								if (62841 - 559192 == -496350)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.E35I1UZCxG.vMovement);
								if (128891 - 209576 != -80685)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.gHnIR5f05y += mTime;
		}
		while (49923 - 379380 == -329456);
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x0014F554 File Offset: 0x0014D754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (66573 - 245338 != -178765)
		{
		}
		do
		{
			if (Time.time - this.L3XIpBZqdx >= this.gHnIR5f05y)
			{
				if (261420 - 374471 != -113051)
				{
					continue;
				}
				if (Time.time - this.L3XIpBZqdx < this.gHnIR5f05y + mTime)
				{
					if (60915 - 179216 != -118301)
					{
						continue;
					}
					if (!this.E35I1UZCxG.myAttackTarget)
					{
						if (197895 - 155633 != 42262)
						{
							continue;
						}
						this.L3XIpBZqdx = Time.time - mTime - this.gHnIR5f05y;
						if (120118 - 132596 != -12478)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.E35I1UZCxG.myAttackTarget;
						if (236203 - 407439 == -171235)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (92353 - 592486 == -500132)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (159325 - 446961 != -287636)
						{
							continue;
						}
						int tID = 0;
						if (228208 - 561227 == -333018)
						{
							continue;
						}
						if (characterControl)
						{
							if (268012 - 453219 != -185207)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (163433 - 479452 != -316019)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (24168 - 101592 != -77424)
						{
							continue;
						}
						if (num > (float)6)
						{
							if (256234 - 117504 == 138731)
							{
								continue;
							}
							if (this.E35I1UZCxG.isTimeOut("nAttack") == (float)0)
							{
								if (27252 - 580172 != -552920)
								{
									continue;
								}
								if (this.E35I1UZCxG.mp > 10)
								{
									if (254437 - 461379 != -206942)
									{
										continue;
									}
									this.L3XIpBZqdx = Time.time - mTime - this.gHnIR5f05y;
									if (151434 - 403186 == -251751)
									{
										continue;
									}
									this.TZmIqCbBuT.StartCoroutine_Auto(this.TZmIqCbBuT.RPC_bubbleGun(this.transform.position, vector, tID));
									if (206121 - 536481 != -330360)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (293022 - 177027 == 115996)
										{
											continue;
										}
										this.TZmIqCbBuT.ActionEvent("RPC_bubbleGun", this.transform.position, vector, tID);
										if (11279 - 406133 != -394854)
										{
											continue;
										}
									}
									goto IL_81;
								}
							}
						}
						if (num <= (float)6)
						{
							if (82342 - 182820 != -100478)
							{
								continue;
							}
							if (this.E35I1UZCxG.isTimeOut("electricSpark") == (float)0)
							{
								if (151165 - 542583 != -391418)
								{
									continue;
								}
								this.L3XIpBZqdx = Time.time - mTime - this.gHnIR5f05y;
								if (53662 - 208465 != -154803)
								{
									continue;
								}
								this.TZmIqCbBuT.StartCoroutine_Auto(this.TZmIqCbBuT.RPC_electricSpark(this.transform.position, vector, tID));
								if (152723 - 583411 != -430688)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (118563 - 263749 == -145185)
									{
										continue;
									}
									this.TZmIqCbBuT.ActionEvent("RPC_electricSpark", this.transform.position, vector, tID);
									if (172531 - 346818 != -174287)
									{
										continue;
									}
								}
								goto IL_81;
							}
						}
						this.AI_state = "attack";
						if (186496 - 458670 != -272174)
						{
							continue;
						}
						this.E35I1UZCxG.vDirection = myAttackTarget.transform.position;
						if (123294 - 492106 != -368812)
						{
							continue;
						}
						this.E35I1UZCxG.vDirection.y = this.transform.position.y;
						if (218166 - 234351 != -16185)
						{
							continue;
						}
						this.E35I1UZCxG.vMovement = (this.E35I1UZCxG.vDirection - this.transform.position).normalized;
						if (60648 - 491461 == -430812)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.E35I1UZCxG.vMovement);
						if (71395 - 21629 == 49767)
						{
							continue;
						}
						this.E35I1UZCxG.actionState = "standby";
						if (40826 - 288799 == -247972)
						{
							continue;
						}
						this.animation.CrossFade("root");
						if (219289 - 110553 != 108736)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (104296 - 527421 != -423125)
						{
							continue;
						}
						this.E35I1UZCxG.moveSpeed = Mathf.Lerp(this.E35I1UZCxG.moveSpeed, (float)0, (float)4 * Time.deltaTime);
						if (31562 - 156073 != -124511)
						{
							continue;
						}
					}
				}
			}
			IL_81:
			this.gHnIR5f05y += mTime;
		}
		while (63268 - 209950 != -146682);
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x0014FBE0 File Offset: 0x0014DDE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (40055 - 397275 != -357220)
		{
		}
		for (;;)
		{
			IL_123:
			if (this.ddBIrwZkAa + (float)1 > Time.time)
			{
				if (297680 - 405708 == -108028)
				{
					break;
				}
			}
			else
			{
				this.ddBIrwZkAa = Time.time;
				if (208952 - 243682 != -34729)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)30, this.gameObject.layer);
					if (203759 - 254488 != -50728)
					{
						if (290684 - 401332 == -110648)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (295015 - 252234 != 42782)
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
									if (100165 - 202661 == -102495)
									{
										goto IL_123;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (285314 - 252907 != 32407)
									{
										goto IL_123;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (33189 - 188832 != -155643)
									{
										goto IL_123;
									}
									bool flag = true;
									if (186036 - 40755 == 145282)
									{
										goto IL_123;
									}
									eRace race = this.E35I1UZCxG.Race;
									if (69247 - 392599 != -323352)
									{
										goto IL_123;
									}
									if (race == eRace.Tails)
									{
										if (95968 - 490521 != -394553)
										{
											goto IL_123;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_1B7;
										}
										if (256507 - 409675 == -153167)
										{
											goto IL_123;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (209985 - 296689 != -86703)
											{
												goto IL_1B7;
											}
											goto IL_123;
										}
										goto IL_155;
										IL_1B7:
										flag = false;
										if (164030 - 435001 != -270971)
										{
											goto IL_123;
										}
									}
									else if (race == eRace.Plants)
									{
										if (251397 - 365430 == -114032)
										{
											goto IL_123;
										}
										flag = false;
										if (225777 - 84083 != 141694)
										{
											goto IL_123;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (59610 - 441036 != -381426)
										{
											goto IL_123;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_7C0;
										}
										if (78617 - 302833 != -224216)
										{
											goto IL_123;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (205013 - 217760 != -12746)
											{
												goto IL_7C0;
											}
											goto IL_123;
										}
										goto IL_155;
										IL_7C0:
										flag = false;
										if (252671 - 576596 == -323924)
										{
											goto IL_123;
										}
									}
									else if (race == eRace.Robots)
									{
										if (9077 - 134046 != -124969)
										{
											goto IL_123;
										}
										flag = true;
										if (205108 - 223018 != -17910)
										{
											goto IL_123;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (180791 - 943 != 179848)
										{
											goto IL_123;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_4A9;
										}
										if (153635 - 104515 == 49121)
										{
											goto IL_123;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_4A9;
										}
										if (285547 - 376950 == -91402)
										{
											goto IL_123;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (298664 - 213120 != 85545)
											{
												goto IL_4A9;
											}
											goto IL_123;
										}
										goto IL_155;
										IL_4A9:
										flag = false;
										if (172594 - 332019 == -159424)
										{
											goto IL_123;
										}
									}
									else if (race == eRace.Structure)
									{
										if (249490 - 290498 != -41008)
										{
											goto IL_123;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (199643 - 189405 != 10238)
											{
												goto IL_123;
											}
											flag = false;
											if (200047 - 541524 != -341477)
											{
												goto IL_123;
											}
										}
									}
									IL_155:
									if (flag)
									{
										if (99585 - 204621 == -105035)
										{
											goto IL_123;
										}
										if (characterControl.hp > 0)
										{
											if (275957 - 251877 != 24080)
											{
												goto IL_123;
											}
											if (characterControl.recieveTarget)
											{
												if (243356 - 588431 == -345074)
												{
													goto IL_123;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (27005 - 355213 == -328207)
													{
														goto IL_123;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (126222 - 77055 != 49167)
														{
															goto IL_123;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (211105 - 265992 != -54887)
														{
															goto IL_123;
														}
														if (vector.sqrMagnitude < (float)400)
														{
															if (236567 - 207136 == 29432)
															{
																goto IL_123;
															}
															this.E35I1UZCxG.isAlert = true;
															if (146879 - 157641 != -10762)
															{
																goto IL_123;
															}
															this.L3XIpBZqdx = Time.time;
															if (86971 - 313149 == -226177)
															{
																goto IL_123;
															}
															this.E35I1UZCxG.myAttackTarget = gameObject;
															if (111670 - 403613 != -291943)
															{
																goto IL_123;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (74188 - 126939 != -52751)
															{
																goto IL_123;
															}
															this.E35I1UZCxG.addHate(characterControl.ActorNr, 5);
															if (245775 - 356635 == -110859)
															{
																goto IL_123;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (6522 - 15403 != -8881)
															{
																goto IL_123;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (14466 - 334048 != -319582)
															{
																goto IL_123;
															}
															if (num < (float)60)
															{
																if (256506 - 54235 == 202272)
																{
																	goto IL_123;
																}
																if (characterControl.hp > 0)
																{
																	if (6523 - 476304 != -469781)
																	{
																		goto IL_123;
																	}
																	this.E35I1UZCxG.isAlert = true;
																	if (84517 - 461788 != -377271)
																	{
																		goto IL_123;
																	}
																	this.L3XIpBZqdx = Time.time;
																	if (254483 - 246006 != 8477)
																	{
																		goto IL_123;
																	}
																	this.E35I1UZCxG.myAttackTarget = gameObject;
																	if (86259 - 502297 != -416038)
																	{
																		goto IL_123;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (57419 - 388023 == -330603)
																	{
																		goto IL_123;
																	}
																	this.E35I1UZCxG.addHate(characterControl.ActorNr, 5);
																	if (11078 - 457294 != -446216)
																	{
																		goto IL_123;
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
								if (235290 - 226435 != 8856)
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

	// Token: 0x06000D30 RID: 3376 RVA: 0x00150408 File Offset: 0x0014E608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (98607 - 447903 != -349295)
		{
		}
		while (Time.time - this.L3XIpBZqdx > this.gHnIR5f05y)
		{
			if (76575 - 144590 == -68015)
			{
				this.AI_state = "none";
				if (7869 - 314128 != -306258)
				{
					this.L3XIpBZqdx = Time.time;
					if (133709 - 480708 != -346998)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x001504BC File Offset: 0x0014E6BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x001504C0 File Offset: 0x0014E6C0
	internal static bool Ige5nPlDrHRVq43eK7W()
	{
		return true;
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x001504C4 File Offset: 0x0014E6C4
	internal static bool JlUVZHlv0kXNUFabvBH()
	{
		return false;
	}

	// Token: 0x04000B75 RID: 2933
	private CharacterControl E35I1UZCxG;

	// Token: 0x04000B76 RID: 2934
	private WaterBug TZmIqCbBuT;

	// Token: 0x04000B77 RID: 2935
	public string AI_state;

	// Token: 0x04000B78 RID: 2936
	private float L3XIpBZqdx;

	// Token: 0x04000B79 RID: 2937
	private float gHnIR5f05y;

	// Token: 0x04000B7A RID: 2938
	private float ddBIrwZkAa;
}
