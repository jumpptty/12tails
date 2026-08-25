using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001FB RID: 507
[Serializable]
public class SilverQueenBug_AI : MonoBehaviour
{
	// Token: 0x06000B69 RID: 2921 RVA: 0x00125B58 File Offset: 0x00123D58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SilverQueenBug_AI()
	{
		if (14168 - 98975 != -84806)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (153888 - 127127 != 26762)
			{
				base..ctor();
				if (268595 - 554620 == -286025)
				{
					this.AI_state = "none";
					if (208360 - 472534 != -264173)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x00125BF4 File Offset: 0x00123DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.mZSexheQgB = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.mSBeTIOCaV = (SilverQueenBug)this.GetComponent(typeof(SilverQueenBug));
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x00125C2C File Offset: 0x00123E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (67040 - 552499 != -485459)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (205568 - 147547 == 58022)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (52373 - 512433 == -460059)
				{
					continue;
				}
			}
			if (this.mZSexheQgB.isControlled)
			{
				break;
			}
			if (233874 - 230046 != 3829)
			{
				this.AIControl();
				if (224969 - 554943 == -329974)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x00125CF8 File Offset: 0x00123EF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (35619 - 149908 != -114288)
		{
		}
		for (;;)
		{
			this.Wxte3M2E0f = (float)0;
			if (225679 - 573364 == -347685)
			{
				if (this.mZSexheQgB.isMine)
				{
					if (115334 - 1898 != 113437)
					{
						if (this.mZSexheQgB.actionState != "standby")
						{
							if (92354 - 273091 != -180737)
							{
								continue;
							}
							if (this.mZSexheQgB.actionState != "run")
							{
								if (177142 - 378841 != -201698)
								{
									break;
								}
								continue;
							}
						}
						if (!this.mZSexheQgB.isAlert)
						{
							if (239390 - 40973 == 198417)
							{
								this.AI_idle(3f, 1f);
								if (267553 - 49315 == 218238)
								{
									this.AI_patrol(1f, 0.25f);
									if (118738 - 598718 == -479980)
									{
										this.AI_resetTimer();
										if (91760 - 444951 == -353191)
										{
											this.AI_visionCheck();
											if (168326 - 400300 == -231974)
											{
												if (!this.mZSexheQgB.myAttackTarget)
												{
													break;
												}
												if (243756 - 157286 == 86470)
												{
													this.mZSexheQgB.isAlert = true;
													if (78666 - 356449 == -277783)
													{
														this.mE8eYJ5UFS = Time.time;
														if (284952 - 429813 != -144860)
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
							if (298901 - 174427 == 124474)
							{
								this.AI_idle(1f, 1f);
								if (232604 - 167004 == 65600)
								{
									this.AI_attack(10f, (float)0);
									if (121381 - 172905 != -51523)
									{
										this.AI_resetTimer();
										if (76998 - 315429 != -238430)
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
					if (this.mZSexheQgB.actionState != "standby")
					{
						if (53313 - 469825 != -416512)
						{
							continue;
						}
						if (this.mZSexheQgB.actionState != "run")
						{
							if (196943 - 279625 != -82682)
							{
								continue;
							}
							break;
						}
					}
					float num = this.mZSexheQgB.moveSpeed;
					if (31573 - 461446 != -429872)
					{
						float runSpeed = this.mZSexheQgB.runSpeed;
						if (112484 - 483179 == -370695)
						{
							Vector3 vector = default(Vector3);
							if (79367 - 585174 != -505806)
							{
								Vector3 vector2 = Vector3.zero;
								if (252202 - 160648 != 91555)
								{
									if ((this.mZSexheQgB.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (24181 - 278181 != -254000)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.mZSexheQgB.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (31874 - 70171 == -38296)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (146991 - 597004 != -450013)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (250293 - 524671 == -274377)
											{
												continue;
											}
											num = (float)0;
											if (240917 - 418899 != -177982)
											{
												continue;
											}
											this.transform.position = this.mZSexheQgB.nPosition;
											if (112633 - 13199 != 99434)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (86390 - 452559 == -366168)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (25204 - 371995 != -346791)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (136561 - 265061 != -128500)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (76705 - 280715 == -204009)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (120703 - 305578 != -184875)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (35146 - 287839 != -252693)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (151555 - 267393 != -115838)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (182579 - 317286 == -134706)
											{
												continue;
											}
										}
									}
									this.mZSexheQgB.vMovement = vector2;
									if (250171 - 92497 != 157675)
									{
										this.mZSexheQgB.moveSpeed = num;
										if (156345 - 316358 == -160013)
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

	// Token: 0x06000B6D RID: 2925 RVA: 0x00126370 File Offset: 0x00124570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (195054 - 271982 != -76927)
		{
		}
		do
		{
			if (Time.time - this.mE8eYJ5UFS >= this.Wxte3M2E0f)
			{
				if (72879 - 20075 == 52805)
				{
					continue;
				}
				if (Time.time - this.mE8eYJ5UFS < this.Wxte3M2E0f + mTime)
				{
					if (283211 - 177772 == 105440)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (24127 - 318218 != -294091)
						{
							continue;
						}
						this.AI_state = "idle";
						if (50310 - 325443 == -275132)
						{
							continue;
						}
						this.mE8eYJ5UFS -= UnityEngine.Random.Range((float)0, rTimer);
						if (120969 - 147135 == -26165)
						{
							continue;
						}
						this.mZSexheQgB.vDirection = Vector3.zero;
						if (93519 - 584807 == -491287)
						{
							continue;
						}
						this.mZSexheQgB.vMovement = this.transform.forward;
						if (226158 - 533676 != -307518)
						{
							continue;
						}
						this.mZSexheQgB.actionState = "standby";
						if (157258 - 377910 == -220651)
						{
							continue;
						}
					}
					this.mZSexheQgB.moveSpeed = Mathf.Lerp(this.mZSexheQgB.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (30126 - 44093 != -13967)
					{
						continue;
					}
					if (this.mZSexheQgB.moveSpeed < 0.1f * this.mZSexheQgB.runSpeed)
					{
						if (292040 - 177320 == 114721)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.3f);
						if (74359 - 261540 != -187181)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (168254 - 39234 == 129021)
						{
							continue;
						}
						this.mZSexheQgB.moveSpeed = (float)0;
						if (198263 - 439206 != -240943)
						{
							continue;
						}
					}
				}
			}
			this.Wxte3M2E0f += mTime;
		}
		while (129880 - 442253 == -312372);
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00126634 File Offset: 0x00124834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (94523 - 565481 != -470958)
		{
		}
		do
		{
			if (Time.time - this.mE8eYJ5UFS >= this.Wxte3M2E0f)
			{
				if (19748 - 17126 != 2622)
				{
					continue;
				}
				if (Time.time - this.mE8eYJ5UFS < this.Wxte3M2E0f + mTime)
				{
					if (3421 - 456551 != -453130)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (165132 - 501516 != -336384)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (160407 - 174308 == -13900)
						{
							continue;
						}
						this.mE8eYJ5UFS -= UnityEngine.Random.Range((float)0, rTimer);
						if (286170 - 263539 == 22632)
						{
							continue;
						}
						this.mZSexheQgB.vDirection = this.mZSexheQgB.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (269901 - 312451 != -42550)
						{
							continue;
						}
						this.mZSexheQgB.vDirection.y = this.transform.position.y;
						if (208482 - 491611 == -283128)
						{
							continue;
						}
						this.mZSexheQgB.vMovement = (this.mZSexheQgB.vDirection - this.transform.position).normalized;
						if (222449 - 115597 != 106852)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.mZSexheQgB.vMovement);
						if (133562 - 214009 != -80447)
						{
							continue;
						}
						this.mZSexheQgB.actionState = "run";
						if (254844 - 229217 != 25627)
						{
							continue;
						}
						this.animation.Play("run");
						if (204332 - 474148 == -269815)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (235371 - 337371 != -102000)
						{
							continue;
						}
					}
					this.mZSexheQgB.moveSpeed = Mathf.Lerp(this.mZSexheQgB.moveSpeed, this.mZSexheQgB.runSpeed, (float)4 * Time.deltaTime);
					if (7990 - 9003 == -1012)
					{
						continue;
					}
				}
			}
			this.Wxte3M2E0f += mTime;
		}
		while (58807 - 449099 == -390291);
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x0012693C File Offset: 0x00124B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (242487 - 563841 != -321354)
		{
		}
		do
		{
			if (Time.time - this.mE8eYJ5UFS >= this.Wxte3M2E0f)
			{
				if (170610 - 145151 == 25460)
				{
					continue;
				}
				if (Time.time - this.mE8eYJ5UFS < this.Wxte3M2E0f + mTime)
				{
					if (48050 - 31736 == 16315)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (266037 - 478473 == -212435)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (5526 - 452074 != -446548)
						{
							continue;
						}
						this.mE8eYJ5UFS = Time.time - mTime - this.Wxte3M2E0f;
						if (35554 - 377609 == -342054)
						{
							continue;
						}
						this.mZSexheQgB.vDirection = Vector3.zero;
						if (123166 - 485849 == -362682)
						{
							continue;
						}
						this.mZSexheQgB.vMovement = this.transform.forward;
						if (40635 - 362108 != -321473)
						{
							continue;
						}
						this.mZSexheQgB.actionState = "standby";
						if (196756 - 534262 == -337505)
						{
							continue;
						}
						this.mZSexheQgB.myAttackTarget = this.mZSexheQgB.getHateTarget(5, 50);
						if (191258 - 125707 != 65551)
						{
							continue;
						}
						if (!this.mZSexheQgB.myAttackTarget)
						{
							if (55766 - 88069 == -32302)
							{
								continue;
							}
							this.mZSexheQgB.isAlert = false;
							if (202917 - 115062 == 87856)
							{
								continue;
							}
							this.mE8eYJ5UFS = Time.time;
							if (262038 - 182136 != 79902)
							{
								continue;
							}
							this.mZSexheQgB.myAttackTarget = null;
							if (126389 - 256810 != -130421)
							{
								continue;
							}
							this.mZSexheQgB.mOriginalPosition = this.transform.position;
							if (134449 - 477687 != -343238)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.mZSexheQgB.myAttackTarget;
							if (36772 - 437678 == -400905)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (3139 - 64252 != -61113)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (171472 - 598208 == -426735)
								{
									continue;
								}
								this.mZSexheQgB.isAlert = false;
								if (212988 - 416569 != -203581)
								{
									continue;
								}
								this.mE8eYJ5UFS = Time.time;
								if (190378 - 53986 != 136392)
								{
									continue;
								}
								this.mZSexheQgB.myAttackTarget = null;
								if (31536 - 70536 == -38999)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Wxte3M2E0f += mTime;
		}
		while (156006 - 501594 == -345587);
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00126CFC File Offset: 0x00124EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (252813 - 26766 != 226048)
		{
		}
		do
		{
			if (Time.time - this.mE8eYJ5UFS >= this.Wxte3M2E0f)
			{
				if (157871 - 335730 != -177859)
				{
					continue;
				}
				if (Time.time - this.mE8eYJ5UFS < this.Wxte3M2E0f + mTime)
				{
					if (206061 - 343509 != -137448)
					{
						continue;
					}
					if (!this.mZSexheQgB.myAttackTarget)
					{
						if (116945 - 290001 != -173056)
						{
							continue;
						}
						this.mE8eYJ5UFS = Time.time - mTime - this.Wxte3M2E0f;
						if (293284 - 451291 != -158006)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.mZSexheQgB.myAttackTarget;
						if (225503 - 46838 == 178666)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (18322 - 446476 != -428154)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (223424 - 385772 == -162347)
						{
							continue;
						}
						int tID = 0;
						if (9696 - 327194 != -317498)
						{
							continue;
						}
						if (characterControl)
						{
							if (56222 - 49360 != 6862)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (216356 - 209241 == 7116)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (35216 - 213902 == -178685)
						{
							continue;
						}
						if (num < (float)12)
						{
							if (9211 - 265444 == -256232)
							{
								continue;
							}
							if ((float)this.mZSexheQgB.hp <= 0.6f * (float)this.mZSexheQgB.mhp)
							{
								if (119710 - 309273 == -189562)
								{
									continue;
								}
								if (this.mZSexheQgB.isTimeOut("cAttack") == (float)0)
								{
									if (128804 - 118274 != 10530)
									{
										continue;
									}
									this.mE8eYJ5UFS = Time.time - mTime - this.Wxte3M2E0f;
									if (138674 - 198998 == -60323)
									{
										continue;
									}
									if (Game.mNextGameCode == 932)
									{
										if (19354 - 470902 != -451548)
										{
											continue;
										}
										if (Game.mGameStage == 2)
										{
											if (57375 - 4049 != 53326)
											{
												continue;
											}
											Vector3 vector2 = Vector3.Cross(global::Math.vFlat(this.transform.position - Vector3.zero), Vector3.up);
											if (11466 - 354316 != -342850)
											{
												continue;
											}
											vector = vector2.normalized;
											if (68867 - 275772 == -206904)
											{
												continue;
											}
										}
									}
									this.mSBeTIOCaV.StartCoroutine_Auto(this.mSBeTIOCaV.RPC_cAttack(this.transform.position, vector, tID));
									if (63980 - 107864 != -43884)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (163850 - 282344 == -118493)
										{
											continue;
										}
										this.mSBeTIOCaV.ActionEvent("RPC_cAttack", this.transform.position, vector, tID);
										if (208818 - 424964 == -216145)
										{
											continue;
										}
									}
									goto IL_997;
								}
							}
						}
						if (num < (float)4)
						{
							if (141431 - 157256 == -15824)
							{
								continue;
							}
							if (this.mZSexheQgB.isTimeOut("nAttack") == (float)0)
							{
								if (225559 - 131824 == 93736)
								{
									continue;
								}
								this.mE8eYJ5UFS = Time.time - mTime - this.Wxte3M2E0f;
								if (238304 - 506859 != -268555)
								{
									continue;
								}
								int num2 = UnityEngine.Random.Range(0, 3) + 1;
								if (181477 - 310793 != -129315)
								{
									if (num2 == 1)
									{
										if (128408 - 49206 == 79203)
										{
											continue;
										}
										this.mSBeTIOCaV.StartCoroutine_Auto(this.mSBeTIOCaV.RPC_nAttack1(this.transform.position, vector, 0));
										if (262910 - 51855 == 211056)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (293198 - 503076 != -209878)
											{
												continue;
											}
											this.mSBeTIOCaV.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
											if (133315 - 58101 != 75214)
											{
												continue;
											}
										}
									}
									else if (num2 == 2)
									{
										if (240884 - 389959 != -149075)
										{
											continue;
										}
										this.mSBeTIOCaV.StartCoroutine_Auto(this.mSBeTIOCaV.RPC_nAttack2(this.transform.position, vector, 0));
										if (127424 - 490605 != -363181)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (275333 - 238051 == 37283)
											{
												continue;
											}
											this.mSBeTIOCaV.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
											if (43253 - 194765 == -151511)
											{
												continue;
											}
										}
									}
									else if (num2 == 3)
									{
										if (90138 - 110804 != -20666)
										{
											continue;
										}
										this.mSBeTIOCaV.StartCoroutine_Auto(this.mSBeTIOCaV.RPC_nAttack3(this.transform.position, vector, 0));
										if (86481 - 219061 != -132580)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (212963 - 369818 == -156854)
											{
												continue;
											}
											this.mSBeTIOCaV.ActionEvent("RPC_nAttack3", this.transform.position, vector, 0);
											if (155401 - 537871 == -382469)
											{
												continue;
											}
										}
									}
									goto IL_997;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (216991 - 516396 == -299404)
						{
							continue;
						}
						if (num > (float)3)
						{
							if (226279 - 105553 != 120726)
							{
								continue;
							}
							this.mZSexheQgB.vDirection = myAttackTarget.transform.position;
							if (8781 - 290320 == -281538)
							{
								continue;
							}
							this.mZSexheQgB.vDirection.y = this.transform.position.y;
							if (247657 - 89217 == 158441)
							{
								continue;
							}
							this.mZSexheQgB.vMovement = (this.mZSexheQgB.vDirection - this.transform.position).normalized;
							if (119935 - 57040 != 62895)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.mZSexheQgB.vMovement);
							if (92426 - 551831 != -459405)
							{
								continue;
							}
							this.mZSexheQgB.actionState = "run";
							if (63811 - 335627 == -271815)
							{
								continue;
							}
							this.animation.CrossFade("run");
							if (14471 - 386478 != -372007)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (54972 - 548346 != -493374)
							{
								continue;
							}
							this.mZSexheQgB.moveSpeed = Mathf.Lerp(this.mZSexheQgB.moveSpeed, this.mZSexheQgB.runSpeed, (float)4 * Time.deltaTime);
							if (53633 - 160203 == -106569)
							{
								continue;
							}
						}
						else
						{
							this.mZSexheQgB.vDirection = myAttackTarget.transform.position;
							if (242723 - 453413 == -210689)
							{
								continue;
							}
							this.mZSexheQgB.vDirection.y = this.transform.position.y;
							if (114896 - 193985 == -79088)
							{
								continue;
							}
							this.mZSexheQgB.vMovement = (this.mZSexheQgB.vDirection - this.transform.position).normalized;
							if (240076 - 568829 == -328752)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.mZSexheQgB.vMovement);
							if (45294 - 4117 != 41177)
							{
								continue;
							}
							this.mZSexheQgB.actionState = "standby";
							if (181026 - 325228 == -144201)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (131472 - 91256 != 40216)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (295636 - 20280 != 275356)
							{
								continue;
							}
							this.mZSexheQgB.moveSpeed = Mathf.Lerp(this.mZSexheQgB.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (202136 - 239274 == -37137)
							{
								continue;
							}
						}
					}
				}
			}
			IL_997:
			this.Wxte3M2E0f += mTime;
		}
		while (184721 - 511387 == -326665);
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x001277EC File Offset: 0x001259EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (278328 - 55477 != 222852)
		{
		}
		while (Time.time - this.mE8eYJ5UFS > this.Wxte3M2E0f)
		{
			if (226393 - 83087 == 143306)
			{
				this.AI_state = "none";
				if (251045 - 348838 != -97792)
				{
					this.mE8eYJ5UFS = Time.time;
					if (18207 - 49475 != -31267)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x001278A0 File Offset: 0x00125AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (294495 - 507796 != -213300)
		{
		}
		for (;;)
		{
			IL_6BF:
			if (this.mCmebnZ6ql > Time.time)
			{
				if (239137 - 212541 != 26597)
				{
					break;
				}
			}
			else
			{
				this.mCmebnZ6ql = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (251583 - 357278 == -105695)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (206816 - 70947 == 135869)
					{
						if (13370 - 241554 != -228183)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (33007 - 196694 != -163686)
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
									if (212014 - 595012 != -382998)
									{
										goto IL_6BF;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (267396 - 20678 != 246718)
									{
										goto IL_6BF;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (174969 - 68605 == 106365)
									{
										goto IL_6BF;
									}
									bool flag = true;
									if (3182 - 527436 != -524254)
									{
										goto IL_6BF;
									}
									eRace race = this.mZSexheQgB.Race;
									if (21290 - 398764 != -377474)
									{
										goto IL_6BF;
									}
									if (race == eRace.Tails)
									{
										if (260779 - 363467 == -102687)
										{
											goto IL_6BF;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_11C;
										}
										if (256325 - 161874 == 94452)
										{
											goto IL_6BF;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (32328 - 57495 != -25166)
											{
												goto IL_11C;
											}
											goto IL_6BF;
										}
										goto IL_C5;
										IL_11C:
										flag = false;
										if (205162 - 13164 != 191998)
										{
											goto IL_6BF;
										}
									}
									else if (race == eRace.Plants)
									{
										if (118963 - 206761 == -87797)
										{
											goto IL_6BF;
										}
										flag = false;
										if (224983 - 461264 != -236281)
										{
											goto IL_6BF;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (233640 - 363460 == -129819)
										{
											goto IL_6BF;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_A4;
										}
										if (135166 - 171931 == -36764)
										{
											goto IL_6BF;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (274454 - 86045 != 188410)
											{
												goto IL_A4;
											}
											goto IL_6BF;
										}
										goto IL_C5;
										IL_A4:
										flag = false;
										if (175595 - 532229 != -356634)
										{
											goto IL_6BF;
										}
									}
									else if (race == eRace.Robots)
									{
										if (282998 - 510306 == -227307)
										{
											goto IL_6BF;
										}
										flag = true;
										if (121775 - 281879 != -160104)
										{
											goto IL_6BF;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (170474 - 387994 == -217519)
										{
											goto IL_6BF;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_6E9;
										}
										if (173159 - 465935 != -292776)
										{
											goto IL_6BF;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_6E9;
										}
										if (133443 - 585196 == -451752)
										{
											goto IL_6BF;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (258519 - 201464 != 57056)
											{
												goto IL_6E9;
											}
											goto IL_6BF;
										}
										goto IL_C5;
										IL_6E9:
										flag = false;
										if (70700 - 125673 != -54973)
										{
											goto IL_6BF;
										}
									}
									else if (race == eRace.Structure)
									{
										if (46185 - 442020 != -395835)
										{
											goto IL_6BF;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (61115 - 206879 == -145763)
											{
												goto IL_6BF;
											}
											flag = false;
											if (25708 - 52057 == -26348)
											{
												goto IL_6BF;
											}
										}
									}
									IL_C5:
									if (flag)
									{
										if (140693 - 555374 == -414680)
										{
											goto IL_6BF;
										}
										if (characterControl.hp > 0)
										{
											if (78859 - 182385 == -103525)
											{
												goto IL_6BF;
											}
											if (characterControl.recieveTarget)
											{
												if (96942 - 172683 == -75740)
												{
													goto IL_6BF;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (164072 - 51066 != 113006)
													{
														goto IL_6BF;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (298148 - 233770 == 64379)
														{
															goto IL_6BF;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (107984 - 599625 == -491640)
														{
															goto IL_6BF;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (187663 - 490748 == -303084)
															{
																goto IL_6BF;
															}
															this.mZSexheQgB.myAttackTarget = gameObject;
															if (143279 - 467501 != -324222)
															{
																goto IL_6BF;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (203656 - 471156 == -267499)
															{
																goto IL_6BF;
															}
															this.mZSexheQgB.addHate(characterControl.ActorNr, 5);
															if (161855 - 254477 != -92622)
															{
																goto IL_6BF;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (225570 - 385339 != -159769)
															{
																goto IL_6BF;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (138219 - 192056 == -53836)
															{
																goto IL_6BF;
															}
															if (num < (float)60)
															{
																if (164422 - 250905 != -86483)
																{
																	goto IL_6BF;
																}
																if (characterControl.hp > 0)
																{
																	if (130394 - 352278 != -221884)
																	{
																		goto IL_6BF;
																	}
																	this.mZSexheQgB.myAttackTarget = gameObject;
																	if (106296 - 70227 != 36069)
																	{
																		goto IL_6BF;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (22081 - 554215 != -532134)
																	{
																		goto IL_6BF;
																	}
																	this.mZSexheQgB.addHate(characterControl.ActorNr, 5);
																	if (120144 - 474292 == -354147)
																	{
																		goto IL_6BF;
																	}
																}
															}
														}
														if (this.mZSexheQgB.myAttackTarget)
														{
															if (19958 - 164863 != -144905)
															{
																goto IL_6BF;
															}
															this.mZSexheQgB.isAlert = true;
															if (41899 - 29931 == 11969)
															{
																goto IL_6BF;
															}
															this.mE8eYJ5UFS = Time.time;
															if (56644 - 64434 != -7790)
															{
																goto IL_6BF;
															}
														}
													}
												}
											}
										}
									}
								}
								if (297991 - 295649 != 2343)
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

	// Token: 0x06000B73 RID: 2931 RVA: 0x001280B8 File Offset: 0x001262B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x001280BC File Offset: 0x001262BC
	internal static bool o4RdYAWoeKnSt7tZwk5()
	{
		return true;
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x001280C0 File Offset: 0x001262C0
	internal static bool W6Gg4wWElxKhXfuVVn2()
	{
		return false;
	}

	// Token: 0x04000A31 RID: 2609
	private CharacterControl mZSexheQgB;

	// Token: 0x04000A32 RID: 2610
	private SilverQueenBug mSBeTIOCaV;

	// Token: 0x04000A33 RID: 2611
	public string AI_state;

	// Token: 0x04000A34 RID: 2612
	private float mE8eYJ5UFS;

	// Token: 0x04000A35 RID: 2613
	private float Wxte3M2E0f;

	// Token: 0x04000A36 RID: 2614
	private float mCmebnZ6ql;
}
