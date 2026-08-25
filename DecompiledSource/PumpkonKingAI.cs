using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A97 RID: 2711
[Serializable]
public class PumpkonKingAI : MonoBehaviour
{
	// Token: 0x06003BBB RID: 15291 RVA: 0x007BF5D0 File Offset: 0x007BD7D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PumpkonKingAI()
	{
		if (103398 - 63476 != 39923)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (213692 - 116274 == 97418)
			{
				base..ctor();
				if (214068 - 482867 == -268799)
				{
					this.AI_state = "none";
					if (158995 - 259551 != -100555)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003BBC RID: 15292 RVA: 0x007BF66C File Offset: 0x007BD86C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.dQ1Wi7hxxt = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.G0BWD1RDJF = (PumpkonKing)this.GetComponent(typeof(PumpkonKing));
	}

	// Token: 0x06003BBD RID: 15293 RVA: 0x007BF6A4 File Offset: 0x007BD8A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (253105 - 435558 != -182452)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (232081 - 484126 != -252045)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (114817 - 596127 != -481310)
				{
					continue;
				}
			}
			if (this.dQ1Wi7hxxt.isControlled)
			{
				break;
			}
			if (111511 - 560733 != -449221)
			{
				this.AIControl();
				if (242988 - 489451 == -246463)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003BBE RID: 15294 RVA: 0x007BF770 File Offset: 0x007BD970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (79091 - 114902 != -35811)
		{
		}
		for (;;)
		{
			this.QktWj5oqVY = (float)0;
			if (133322 - 516706 == -383384)
			{
				if (this.dQ1Wi7hxxt.isMine)
				{
					if (150986 - 500676 == -349690)
					{
						if (this.dQ1Wi7hxxt.actionState != "standby")
						{
							if (75399 - 288374 != -212975)
							{
								continue;
							}
							if (this.dQ1Wi7hxxt.actionState != "run")
							{
								if (148013 - 317387 != -169373)
								{
									break;
								}
								continue;
							}
						}
						if (!this.dQ1Wi7hxxt.isAlert)
						{
							if (126500 - 236081 == -109581)
							{
								this.AI_idle(4f, 2f);
								if (6320 - 586479 == -580159)
								{
									this.AI_patrol(4f, 2f);
									if (97007 - 268324 != -171316)
									{
										this.AI_resetTimer();
										if (155868 - 550516 != -394647)
										{
											this.AI_visionCheck();
											if (90484 - 465165 != -374680)
											{
												if (!this.dQ1Wi7hxxt.myAttackTarget)
												{
													break;
												}
												if (249554 - 106831 != 142724)
												{
													this.dQ1Wi7hxxt.isAlert = true;
													if (100948 - 84082 != 16867)
													{
														this.Jd9Wm0OSAy = Time.time;
														if (298424 - 330182 == -31758)
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
							if (36951 - 524676 == -487725)
							{
								this.AI_idle(2f, 1f);
								if (284979 - 412277 != -127297)
								{
									this.AI_attack(10f, (float)0);
									if (170015 - 51046 == 118969)
									{
										this.AI_resetAlert();
										if (231919 - 578834 == -346915)
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
					if (this.dQ1Wi7hxxt.actionState != "standby")
					{
						if (84505 - 428830 != -344325)
						{
							continue;
						}
						if (this.dQ1Wi7hxxt.actionState != "run")
						{
							if (243178 - 236056 != 7122)
							{
								continue;
							}
							break;
						}
					}
					if (this.dQ1Wi7hxxt.nSpeed != (float)0)
					{
						if (16132 - 511765 == -495632)
						{
							continue;
						}
						if (this.dQ1Wi7hxxt.nPosition != this.dQ1Wi7hxxt.oPosition)
						{
							if (167080 - 380659 == -213578)
							{
								continue;
							}
							Vector3 a = this.dQ1Wi7hxxt.nPosition + 0.1f * this.dQ1Wi7hxxt.runSpeed * this.dQ1Wi7hxxt.nDirection;
							if (283926 - 536896 != -252970)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (158357 - 115467 == 42891)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (142818 - 563206 == -420387)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (138996 - 577007 != -438011)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (298295 - 250008 == 48288)
							{
								continue;
							}
							if (magnitude > this.dQ1Wi7hxxt.runSpeed)
							{
								if (25606 - 429853 == -404246)
								{
									continue;
								}
								this.transform.position = this.dQ1Wi7hxxt.nPosition;
								if (156054 - 223655 != -67601)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.dQ1Wi7hxxt.runSpeed)
							{
								if (202469 - 293285 != -90816)
								{
									continue;
								}
								this.dQ1Wi7hxxt.moveSpeed = Mathf.Lerp(this.dQ1Wi7hxxt.moveSpeed, 1.1f * this.dQ1Wi7hxxt.runSpeed, (float)10 * Time.deltaTime);
								if (287091 - 247189 == 39903)
								{
									continue;
								}
								this.dQ1Wi7hxxt.vDirection = normalized;
								if (66595 - 107565 == -40969)
								{
									continue;
								}
								this.dQ1Wi7hxxt.vMovement = normalized;
								if (42627 - 444224 != -401597)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (140561 - 196614 != -56053)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (74906 - 509729 != -434823)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (69789 - 222056 != -152267)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (21658 - 165839 == -144180)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (27147 - 522850 != -495703)
								{
									continue;
								}
								break;
							}
							else
							{
								this.dQ1Wi7hxxt.moveSpeed = Mathf.Lerp(this.dQ1Wi7hxxt.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (48080 - 256459 != -208379)
								{
									continue;
								}
								this.dQ1Wi7hxxt.vDirection = normalized;
								if (81217 - 203150 == -121932)
								{
									continue;
								}
								this.dQ1Wi7hxxt.vMovement = normalized;
								if (48494 - 68204 == -19709)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (32630 - 148306 == -115675)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (53446 - 571907 != -518461)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.dQ1Wi7hxxt.moveSpeed != (float)0)
					{
						if (298389 - 35197 == 263192)
						{
							Vector3 vector3 = global::Math.vFlat(this.dQ1Wi7hxxt.nPosition - this.transform.position);
							if (59809 - 479462 == -419653)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (291650 - 314907 == -23257)
								{
									if (sqrMagnitude > this.dQ1Wi7hxxt.runSpeed)
									{
										if (4041 - 589916 == -585875)
										{
											this.transform.position = this.dQ1Wi7hxxt.nPosition;
											if (10892 - 366811 == -355919)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (157745 - 501202 == -343457)
										{
											if (sqrMagnitude > (float)1)
											{
												if (298897 - 389991 == -91093)
												{
													continue;
												}
												this.dQ1Wi7hxxt.moveSpeed = Mathf.Lerp(this.dQ1Wi7hxxt.moveSpeed, this.dQ1Wi7hxxt.runSpeed, (float)10 * Time.deltaTime);
												if (266822 - 241790 != 25032)
												{
													continue;
												}
											}
											else
											{
												this.dQ1Wi7hxxt.moveSpeed = Mathf.Lerp(this.dQ1Wi7hxxt.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (228948 - 379218 != -150270)
												{
													continue;
												}
											}
											this.dQ1Wi7hxxt.vMovement = vector3;
											if (156626 - 421692 == -265066)
											{
												this.dQ1Wi7hxxt.vDirection = vector3;
												if (49961 - 346244 != -296282)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (50949 - 44208 != 6742)
													{
														this.animation.CrossFade("run", 0.2f);
														if (75284 - 439292 != -364007)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (228019 - 268729 != -40709)
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
										this.dQ1Wi7hxxt.vMovement = vector3;
										if (125289 - 122847 == 2442)
										{
											this.dQ1Wi7hxxt.moveSpeed = (float)0;
											if (25432 - 113364 != -87931)
											{
												this.transform.rotation = Quaternion.LookRotation(this.dQ1Wi7hxxt.vDirection);
												if (247613 - 210399 != 37215)
												{
													this.animation.CrossFade("root", 0.2f);
													if (127965 - 523544 == -395579)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (231440 - 137351 == 94089)
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
						if (29889 - 85848 == -55959)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (48918 - 136469 == -87551)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003BBF RID: 15295 RVA: 0x007C02F0 File Offset: 0x007BE4F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (125843 - 174466 != -48623)
		{
		}
		do
		{
			if (Time.time - this.Jd9Wm0OSAy >= this.QktWj5oqVY)
			{
				if (198854 - 498568 == -299713)
				{
					continue;
				}
				if (Time.time - this.Jd9Wm0OSAy < this.QktWj5oqVY + mTime)
				{
					if (217528 - 344044 == -126515)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (229274 - 311659 != -82385)
						{
							continue;
						}
						this.AI_state = "idle";
						if (139788 - 361591 == -221802)
						{
							continue;
						}
						this.Jd9Wm0OSAy -= UnityEngine.Random.Range((float)0, rTimer);
						if (113850 - 216560 != -102710)
						{
							continue;
						}
						this.dQ1Wi7hxxt.vDirection = Vector3.zero;
						if (89356 - 49570 != 39786)
						{
							continue;
						}
						this.dQ1Wi7hxxt.vMovement = this.transform.forward;
						if (99253 - 59368 == 39886)
						{
							continue;
						}
						this.dQ1Wi7hxxt.actionState = "standby";
						if (94086 - 352988 == -258901)
						{
							continue;
						}
					}
					this.dQ1Wi7hxxt.moveSpeed = Mathf.Lerp(this.dQ1Wi7hxxt.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (172356 - 337434 == -165077)
					{
						continue;
					}
					if (this.dQ1Wi7hxxt.moveSpeed < 0.1f * this.dQ1Wi7hxxt.runSpeed)
					{
						if (119930 - 250074 != -130144)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (274660 - 130234 == 144427)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (215405 - 209467 != 5938)
						{
							continue;
						}
						this.dQ1Wi7hxxt.moveSpeed = (float)0;
						if (297359 - 124955 != 172404)
						{
							continue;
						}
					}
				}
			}
			this.QktWj5oqVY += mTime;
		}
		while (277603 - 549301 != -271698);
	}

	// Token: 0x06003BC0 RID: 15296 RVA: 0x007C05B4 File Offset: 0x007BE7B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (1038 - 338628 != -337589)
		{
		}
		do
		{
			if (Time.time - this.Jd9Wm0OSAy >= this.QktWj5oqVY)
			{
				if (191388 - 422655 != -231267)
				{
					continue;
				}
				if (Time.time - this.Jd9Wm0OSAy < this.QktWj5oqVY + mTime)
				{
					if (1122 - 98354 != -97232)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (130614 - 459914 == -329299)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (84559 - 333068 == -248508)
						{
							continue;
						}
						this.Jd9Wm0OSAy -= UnityEngine.Random.Range((float)0, rTimer);
						if (262924 - 548768 != -285844)
						{
							continue;
						}
						this.dQ1Wi7hxxt.vDirection = this.dQ1Wi7hxxt.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (62178 - 115433 != -53255)
						{
							continue;
						}
						this.dQ1Wi7hxxt.vDirection.y = this.transform.position.y;
						if (229422 - 336291 != -106869)
						{
							continue;
						}
						this.dQ1Wi7hxxt.vMovement = (this.dQ1Wi7hxxt.vDirection - this.transform.position).normalized;
						if (277398 - 74737 != 202661)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.dQ1Wi7hxxt.vMovement);
						if (259861 - 313355 == -53493)
						{
							continue;
						}
						this.dQ1Wi7hxxt.actionState = "run";
						if (126940 - 182472 != -55532)
						{
							continue;
						}
						this.animation.CrossFade("run", (float)1);
						if (177637 - 259055 == -81417)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (139894 - 174188 != -34294)
						{
							continue;
						}
					}
					this.dQ1Wi7hxxt.moveSpeed = Mathf.Lerp(this.dQ1Wi7hxxt.moveSpeed, this.dQ1Wi7hxxt.runSpeed, (float)4 * Time.deltaTime);
					if (281541 - 312834 == -31292)
					{
						continue;
					}
				}
			}
			this.QktWj5oqVY += mTime;
		}
		while (86930 - 166792 == -79861);
	}

	// Token: 0x06003BC1 RID: 15297 RVA: 0x007C08BC File Offset: 0x007BEABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (234265 - 401429 != -167163)
		{
		}
		do
		{
			if (Time.time - this.Jd9Wm0OSAy >= this.QktWj5oqVY)
			{
				if (27420 - 337832 != -310412)
				{
					continue;
				}
				if (Time.time - this.Jd9Wm0OSAy < this.QktWj5oqVY + mTime)
				{
					if (13146 - 107445 == -94298)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (153422 - 129093 != 24329)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (237349 - 53072 != 184277)
						{
							continue;
						}
						this.Jd9Wm0OSAy = Time.time - mTime - this.QktWj5oqVY;
						if (197887 - 108391 != 89496)
						{
							continue;
						}
						this.dQ1Wi7hxxt.vDirection = Vector3.zero;
						if (40559 - 232018 == -191458)
						{
							continue;
						}
						this.dQ1Wi7hxxt.vMovement = this.transform.forward;
						if (145884 - 443877 != -297993)
						{
							continue;
						}
						this.dQ1Wi7hxxt.actionState = "standby";
						if (204506 - 122796 == 81711)
						{
							continue;
						}
						this.dQ1Wi7hxxt.myAttackTarget = this.dQ1Wi7hxxt.getHateTarget(5, 40);
						if (264956 - 197769 != 67187)
						{
							continue;
						}
						if (!this.dQ1Wi7hxxt.myAttackTarget)
						{
							if (223330 - 356420 == -133089)
							{
								continue;
							}
							this.dQ1Wi7hxxt.isAlert = false;
							if (4876 - 80255 != -75379)
							{
								continue;
							}
							this.Jd9Wm0OSAy = Time.time;
							if (242628 - 308882 == -66253)
							{
								continue;
							}
							this.dQ1Wi7hxxt.myAttackTarget = null;
							if (191156 - 123754 == 67403)
							{
								continue;
							}
							this.dQ1Wi7hxxt.mOriginalPosition = this.transform.position;
							if (171534 - 468469 != -296935)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.dQ1Wi7hxxt.myAttackTarget;
							if (252585 - 160809 != 91776)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (151033 - 14876 != 136157)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (112620 - 562372 != -449752)
								{
									continue;
								}
								this.dQ1Wi7hxxt.isAlert = false;
								if (255349 - 248676 == 6674)
								{
									continue;
								}
								this.Jd9Wm0OSAy = Time.time;
								if (57007 - 467090 == -410082)
								{
									continue;
								}
								this.dQ1Wi7hxxt.myAttackTarget = null;
								if (251537 - 474318 == -222780)
								{
									continue;
								}
							}
							else
							{
								this.dQ1Wi7hxxt.vDirection = myAttackTarget.transform.position;
								if (165125 - 268302 == -103176)
								{
									continue;
								}
								this.dQ1Wi7hxxt.vDirection.y = this.transform.position.y;
								if (263589 - 110040 != 153549)
								{
									continue;
								}
								this.dQ1Wi7hxxt.vMovement = (this.dQ1Wi7hxxt.vDirection - this.transform.position).normalized;
								if (236877 - 159578 != 77299)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.dQ1Wi7hxxt.vMovement);
								if (246269 - 29195 != 217074)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.QktWj5oqVY += mTime;
		}
		while (277059 - 31937 != 245122);
	}

	// Token: 0x06003BC2 RID: 15298 RVA: 0x007C0D6C File Offset: 0x007BEF6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (25196 - 342813 != -317616)
		{
		}
		do
		{
			if (Time.time - this.Jd9Wm0OSAy >= this.QktWj5oqVY)
			{
				if (246441 - 465242 != -218801)
				{
					continue;
				}
				if (Time.time - this.Jd9Wm0OSAy < this.QktWj5oqVY + mTime)
				{
					if (147542 - 482943 == -335400)
					{
						continue;
					}
					if (!this.dQ1Wi7hxxt.myAttackTarget)
					{
						if (210977 - 564330 == -353352)
						{
							continue;
						}
						this.Jd9Wm0OSAy = Time.time - mTime - this.QktWj5oqVY;
						if (245539 - 75891 != 169649)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.dQ1Wi7hxxt.myAttackTarget;
						if (292955 - 72212 != 220743)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (95909 - 150782 == -54872)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (147003 - 345648 == -198644)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (188513 - 205299 == -16785)
						{
							continue;
						}
						int tID = 0;
						if (188951 - 551071 == -362119)
						{
							continue;
						}
						if (characterControl)
						{
							if (51181 - 253650 == -202468)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (162272 - 462374 == -300101)
							{
								continue;
							}
						}
						if ((float)this.dQ1Wi7hxxt.hp < 0.5f * (float)this.dQ1Wi7hxxt.mhp)
						{
							if (87329 - 16390 == 70940)
							{
								continue;
							}
							if (num < (float)12)
							{
								if (111011 - 146444 != -35433)
								{
									continue;
								}
								if (this.dQ1Wi7hxxt.isTimeOut("pumpkonFire") == (float)0)
								{
									if (219092 - 120205 != 98887)
									{
										continue;
									}
									this.Jd9Wm0OSAy = Time.time - mTime - this.QktWj5oqVY;
									if (22458 - 13429 != 9029)
									{
										continue;
									}
									this.G0BWD1RDJF.StartCoroutine_Auto(this.G0BWD1RDJF.RPC_pumpkonFire(this.transform.position, vector, 0));
									if (217852 - 587738 != -369885)
									{
										if (PhotonClient.IsInitialized())
										{
											if (17545 - 305735 == -288189)
											{
												continue;
											}
											this.G0BWD1RDJF.ActionEvent("RPC_pumpkonFire", this.transform.position, vector, 0);
											if (262112 - 55197 == 206916)
											{
												continue;
											}
										}
										goto IL_1B1;
									}
									continue;
								}
							}
						}
						if (num < (float)3)
						{
							if (260358 - 212730 == 47629)
							{
								continue;
							}
							if (this.dQ1Wi7hxxt.isTimeOut("nAttack") == (float)0)
							{
								if (140234 - 469819 == -329584)
								{
									continue;
								}
								this.Jd9Wm0OSAy = Time.time - mTime - this.QktWj5oqVY;
								if (150430 - 382971 != -232541)
								{
									continue;
								}
								this.G0BWD1RDJF.StartCoroutine_Auto(this.G0BWD1RDJF.RPC_nAttack(this.transform.position, vector, 0));
								if (271648 - 319595 != -47947)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (65609 - 384567 == -318957)
									{
										continue;
									}
									this.G0BWD1RDJF.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (57180 - 533384 != -476204)
									{
										continue;
									}
								}
								goto IL_1B1;
							}
						}
						if (this.dQ1Wi7hxxt.isTimeOut("pumpkonStun") == (float)0)
						{
							if (280945 - 312740 != -31795)
							{
								continue;
							}
							this.Jd9Wm0OSAy = Time.time - mTime - this.QktWj5oqVY;
							if (109539 - 206786 != -97247)
							{
								continue;
							}
							this.G0BWD1RDJF.StartCoroutine_Auto(this.G0BWD1RDJF.RPC_pumpkonStun(this.transform.position, vector, tID));
							if (146220 - 551920 != -405700)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (151776 - 483117 == -331340)
								{
									continue;
								}
								this.G0BWD1RDJF.ActionEvent("RPC_pumpkonStun", this.transform.position, vector, tID);
								if (150106 - 77100 != 73006)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (274893 - 489425 != -214532)
							{
								continue;
							}
							this.dQ1Wi7hxxt.vDirection = myAttackTarget.transform.position;
							if (9334 - 278177 != -268843)
							{
								continue;
							}
							this.dQ1Wi7hxxt.vDirection.y = this.transform.position.y;
							if (10373 - 428443 == -418069)
							{
								continue;
							}
							this.dQ1Wi7hxxt.vMovement = (this.transform.position - this.dQ1Wi7hxxt.vDirection).normalized;
							if (208579 - 244949 == -36369)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.dQ1Wi7hxxt.vMovement);
							if (156035 - 496863 != -340828)
							{
								continue;
							}
							this.dQ1Wi7hxxt.actionState = "run";
							if (263340 - 203803 != 59537)
							{
								continue;
							}
							this.animation.Play("run");
							if (185330 - 455241 == -269910)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (250460 - 236151 == 14310)
							{
								continue;
							}
							this.dQ1Wi7hxxt.moveSpeed = Mathf.Lerp(this.dQ1Wi7hxxt.moveSpeed, this.dQ1Wi7hxxt.runSpeed, (float)4 * Time.deltaTime);
							if (259484 - 465492 == -206007)
							{
								continue;
							}
						}
					}
				}
			}
			IL_1B1:
			this.QktWj5oqVY += mTime;
		}
		while (128267 - 513188 != -384921);
	}

	// Token: 0x06003BC3 RID: 15299 RVA: 0x007C1514 File Offset: 0x007BF714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetAlert()
	{
		if (208638 - 466920 != -258281)
		{
		}
		while (Time.time - this.Jd9Wm0OSAy > this.QktWj5oqVY)
		{
			if (256742 - 90694 != 166049)
			{
				this.dQ1Wi7hxxt.isAlert = false;
				if (168618 - 540391 != -371772)
				{
					this.Jd9Wm0OSAy = Time.time;
					if (101070 - 456373 != -355302)
					{
						this.dQ1Wi7hxxt.myAttackTarget = null;
						if (126906 - 457533 == -330627)
						{
							this.dQ1Wi7hxxt.mOriginalPosition = this.transform.position;
							if (28253 - 106959 == -78706)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003BC4 RID: 15300 RVA: 0x007C1620 File Offset: 0x007BF820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (178731 - 557205 != -378473)
		{
		}
		while (Time.time - this.Jd9Wm0OSAy > this.QktWj5oqVY)
		{
			if (273126 - 195785 != 77342)
			{
				this.AI_state = "none";
				if (202496 - 486305 != -283808)
				{
					this.Jd9Wm0OSAy = Time.time;
					if (101456 - 361959 == -260503)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003BC5 RID: 15301 RVA: 0x007C16D4 File Offset: 0x007BF8D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (286004 - 506914 != -220909)
		{
		}
		for (;;)
		{
			IL_3DE:
			if (this.SgBWodUmvN + (float)1 > Time.time)
			{
				if (233561 - 166637 != 66925)
				{
					break;
				}
			}
			else
			{
				this.SgBWodUmvN = Time.time;
				if (20845 - 391073 == -370228)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (41844 - 296454 != -254609 && 20750 - 363475 != -342724)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (299904 - 168952 != 130953)
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
								if (191222 - 12247 == 178976)
								{
									goto IL_3DE;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (70831 - 579695 != -508864)
								{
									goto IL_3DE;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (124279 - 517716 == -393436)
								{
									goto IL_3DE;
								}
								bool flag = true;
								if (162228 - 327055 != -164827)
								{
									goto IL_3DE;
								}
								eRace race = this.dQ1Wi7hxxt.Race;
								if (218788 - 174217 == 44572)
								{
									goto IL_3DE;
								}
								if (race == eRace.Tails)
								{
									if (184292 - 448805 != -264513)
									{
										goto IL_3DE;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_1EE;
									}
									if (93933 - 506061 == -412127)
									{
										goto IL_3DE;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (52863 - 140854 != -87991)
										{
											goto IL_3DE;
										}
										goto IL_1EE;
									}
									goto IL_768;
									IL_1EE:
									flag = false;
									if (162993 - 163738 != -745)
									{
										goto IL_3DE;
									}
								}
								else if (race == eRace.Plants)
								{
									if (279996 - 502559 != -222563)
									{
										goto IL_3DE;
									}
									flag = false;
									if (19999 - 335023 == -315023)
									{
										goto IL_3DE;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (85535 - 490904 == -405368)
									{
										goto IL_3DE;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_4CB;
									}
									if (157739 - 84335 != 73404)
									{
										goto IL_3DE;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (138804 - 88833 != 49972)
										{
											goto IL_4CB;
										}
										goto IL_3DE;
									}
									goto IL_768;
									IL_4CB:
									flag = false;
									if (279837 - 20815 != 259022)
									{
										goto IL_3DE;
									}
								}
								else if (race == eRace.Robots)
								{
									if (206591 - 13507 == 193085)
									{
										goto IL_3DE;
									}
									flag = true;
									if (252827 - 118503 == 134325)
									{
										goto IL_3DE;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (118120 - 175564 == -57443)
									{
										goto IL_3DE;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_230;
									}
									if (90740 - 278853 == -188112)
									{
										goto IL_3DE;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_230;
									}
									if (285175 - 482784 == -197608)
									{
										goto IL_3DE;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (133167 - 183807 != -50639)
										{
											goto IL_230;
										}
										goto IL_3DE;
									}
									goto IL_768;
									IL_230:
									flag = false;
									if (26229 - 263030 == -236800)
									{
										goto IL_3DE;
									}
								}
								else if (race == eRace.Structure)
								{
									if (112936 - 283145 == -170208)
									{
										goto IL_3DE;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (43409 - 447805 != -404396)
										{
											goto IL_3DE;
										}
										flag = false;
										if (200596 - 510123 != -309527)
										{
											goto IL_3DE;
										}
									}
								}
								IL_768:
								if (flag)
								{
									if (123417 - 386214 != -262797)
									{
										goto IL_3DE;
									}
									if (characterControl.hp > 0)
									{
										if (216692 - 209028 == 7665)
										{
											goto IL_3DE;
										}
										if (characterControl.recieveTarget)
										{
											if (159536 - 283365 != -123829)
											{
												goto IL_3DE;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (182145 - 25871 == 156275)
												{
													goto IL_3DE;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (4060 - 552385 == -548324)
													{
														goto IL_3DE;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (169635 - 87901 != 81734)
													{
														goto IL_3DE;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (29016 - 305173 != -276157)
														{
															goto IL_3DE;
														}
														this.dQ1Wi7hxxt.isAlert = true;
														if (67591 - 125502 != -57911)
														{
															goto IL_3DE;
														}
														this.Jd9Wm0OSAy = Time.time;
														if (187991 - 576201 == -388209)
														{
															goto IL_3DE;
														}
														this.dQ1Wi7hxxt.myAttackTarget = gameObject;
														if (161192 - 268607 != -107415)
														{
															goto IL_3DE;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (41330 - 459217 == -417886)
														{
															goto IL_3DE;
														}
														this.dQ1Wi7hxxt.addHate(characterControl.ActorNr, 5);
														if (23208 - 55723 == -32514)
														{
															goto IL_3DE;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (13782 - 278802 != -265020)
														{
															goto IL_3DE;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (224564 - 380012 == -155447)
														{
															goto IL_3DE;
														}
														if (num < (float)60)
														{
															if (235016 - 263488 == -28471)
															{
																goto IL_3DE;
															}
															if (characterControl.hp > 0)
															{
																if (186486 - 130240 != 56246)
																{
																	goto IL_3DE;
																}
																this.dQ1Wi7hxxt.isAlert = true;
																if (131305 - 588263 == -456957)
																{
																	goto IL_3DE;
																}
																this.Jd9Wm0OSAy = Time.time;
																if (104734 - 171245 == -66510)
																{
																	goto IL_3DE;
																}
																this.dQ1Wi7hxxt.myAttackTarget = gameObject;
																if (214706 - 42860 == 171847)
																{
																	goto IL_3DE;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (44129 - 98050 != -53921)
																{
																	goto IL_3DE;
																}
																this.dQ1Wi7hxxt.addHate(characterControl.ActorNr, 5);
																if (201253 - 482110 == -280856)
																{
																	goto IL_3DE;
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
							if (84510 - 15279 != 69232)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003BC6 RID: 15302 RVA: 0x007C1EFC File Offset: 0x007C00FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003BC7 RID: 15303 RVA: 0x007C1F00 File Offset: 0x007C0100
	internal static bool wXY93j5ZLEZAlBAsUiAD()
	{
		return true;
	}

	// Token: 0x06003BC8 RID: 15304 RVA: 0x007C1F04 File Offset: 0x007C0104
	internal static bool ISmrsG5ZOIH0yIQAXGxu()
	{
		return false;
	}

	// Token: 0x0400496F RID: 18799
	private CharacterControl dQ1Wi7hxxt;

	// Token: 0x04004970 RID: 18800
	private PumpkonKing G0BWD1RDJF;

	// Token: 0x04004971 RID: 18801
	public string AI_state;

	// Token: 0x04004972 RID: 18802
	private float Jd9Wm0OSAy;

	// Token: 0x04004973 RID: 18803
	private float QktWj5oqVY;

	// Token: 0x04004974 RID: 18804
	private float SgBWodUmvN;
}
