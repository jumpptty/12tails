using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003B8 RID: 952
[Serializable]
public class ShadowWhale_AI : MonoBehaviour
{
	// Token: 0x06001616 RID: 5654 RVA: 0x00240898 File Offset: 0x0023EA98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowWhale_AI()
	{
		if (218129 - 305982 != -87853)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (287970 - 204338 == 83632)
			{
				base..ctor();
				if (156119 - 340162 == -184043)
				{
					this.AI_state = "none";
					if (178956 - 512513 == -333557)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x00240934 File Offset: 0x0023EB34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.rrpOJ4w3jG = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.MpRO6fPs7u = (Whale)this.GetComponent(typeof(Whale));
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x0024096C File Offset: 0x0023EB6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (141831 - 416493 != -274662)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (292822 - 439025 == -146202)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (156228 - 308137 != -151909)
				{
					continue;
				}
			}
			if (this.rrpOJ4w3jG.isControlled)
			{
				break;
			}
			if (162847 - 327944 == -165097)
			{
				this.AIControl();
				if (218776 - 313102 == -94326)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x00240A38 File Offset: 0x0023EC38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.hFfOO361t2 = nSummoner;
	}

	// Token: 0x0600161A RID: 5658 RVA: 0x00240A44 File Offset: 0x0023EC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (36665 - 408887 != -372221)
		{
		}
		for (;;)
		{
			this.zBiOXhwwdW = (float)0;
			if (179697 - 471586 == -291889)
			{
				if (this.rrpOJ4w3jG.isMine)
				{
					if (271869 - 461772 == -189903)
					{
						if (this.rrpOJ4w3jG.actionState != "standby")
						{
							if (186411 - 332927 != -146516)
							{
								continue;
							}
							if (this.rrpOJ4w3jG.actionState != "run")
							{
								if (290349 - 581586 != -291236)
								{
									break;
								}
								continue;
							}
						}
						if (this.hFfOO361t2)
						{
							if (257216 - 118356 != 138861)
							{
								if (!this.rrpOJ4w3jG.isAlert)
								{
									if (189679 - 346922 == -157243)
									{
										Vector3 vector = this.hFfOO361t2.transform.position - this.transform.position;
										if (229541 - 306285 != -76743)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (60037 - 563424 == -503386)
												{
													continue;
												}
												this.AI_follow(this.hFfOO361t2);
												if (194597 - 187464 == 7134)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (284871 - 79255 != 205616)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (108659 - 54728 != 53931)
												{
													continue;
												}
												this.AI_resetTimer();
												if (113017 - 589515 != -476498)
												{
													continue;
												}
												this.AI_visionCheck();
												if (72645 - 499472 == -426826)
												{
													continue;
												}
											}
											if (!this.rrpOJ4w3jG.myAttackTarget)
											{
												break;
											}
											if (15747 - 520204 != -504456)
											{
												this.rrpOJ4w3jG.isAlert = true;
												if (57196 - 444577 == -387381)
												{
													this.oBuOto7uIM = Time.time;
													if (299034 - 438843 == -139809)
													{
														break;
													}
												}
											}
										}
									}
								}
								else
								{
									Vector3 vector2 = this.hFfOO361t2.transform.position - this.transform.position;
									if (97954 - 463498 != -365543)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (290425 - 52833 == 237592)
											{
												this.rrpOJ4w3jG.isAlert = false;
												if (60873 - 242822 == -181949)
												{
													this.AI_resetTimer();
													if (83756 - 537364 != -453607)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (228133 - 157086 != 71048)
											{
												this.AI_patrol(3f, 1f);
												if (143469 - 520140 == -376671)
												{
													this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
													if (15704 - 67380 == -51676)
													{
														this.AI_resetTimer();
														if (271878 - 488243 == -216365)
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
						else if (!this.rrpOJ4w3jG.isAlert)
						{
							if (182833 - 270995 != -88161)
							{
								this.AI_idle(3f, 1f);
								if (54467 - 340090 != -285622)
								{
									this.AI_patrol(1f, 0.25f);
									if (137622 - 337475 != -199852)
									{
										this.AI_resetTimer();
										if (131926 - 309938 == -178012)
										{
											this.AI_visionCheck();
											if (3064 - 558570 == -555506)
											{
												if (!this.rrpOJ4w3jG.myAttackTarget)
												{
													break;
												}
												if (32843 - 570467 == -537624)
												{
													this.rrpOJ4w3jG.isAlert = true;
													if (213814 - 366531 == -152717)
													{
														this.oBuOto7uIM = Time.time;
														if (44549 - 120272 != -75722)
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
							if (272033 - 561563 == -289530)
							{
								this.AI_patrol(3f, 1f);
								if (237789 - 127957 != 109833)
								{
									this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
									if (169340 - 50483 != 118858)
									{
										this.AI_resetTimer();
										if (144384 - 555235 == -410851)
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
					if (this.rrpOJ4w3jG.actionState != "standby")
					{
						if (120430 - 430966 != -310536)
						{
							continue;
						}
						if (this.rrpOJ4w3jG.actionState != "run")
						{
							if (164799 - 470686 != -305886)
							{
								break;
							}
							continue;
						}
					}
					float num = this.rrpOJ4w3jG.moveSpeed;
					if (68295 - 447480 != -379184)
					{
						float runSpeed = this.rrpOJ4w3jG.runSpeed;
						if (132100 - 264209 == -132109)
						{
							Vector3 vector3 = default(Vector3);
							if (72595 - 308843 == -236248)
							{
								Vector3 vector4 = Vector3.zero;
								if (177662 - 141518 != 36145)
								{
									if ((this.rrpOJ4w3jG.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (186239 - 490609 != -304370)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.rrpOJ4w3jG.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (129254 - 349212 != -219958)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (190205 - 344074 != -153869)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (196187 - 267862 != -71675)
											{
												continue;
											}
											num = (float)0;
											if (171479 - 283788 != -112309)
											{
												continue;
											}
											this.transform.position = this.rrpOJ4w3jG.nPosition;
											if (213545 - 311812 == -98266)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (151494 - 582045 == -430550)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (237606 - 283284 == -45677)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (298924 - 136287 == 162638)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (107153 - 6571 != 100582)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (246539 - 22648 == 223892)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (128670 - 425731 == -297060)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (254319 - 506246 != -251927)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (8631 - 577875 == -569243)
											{
												continue;
											}
										}
									}
									this.rrpOJ4w3jG.vMovement = vector4;
									if (282430 - 62686 == 219744)
									{
										this.rrpOJ4w3jG.moveSpeed = num;
										if (214961 - 169905 == 45056)
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

	// Token: 0x0600161B RID: 5659 RVA: 0x00241410 File Offset: 0x0023F610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (153806 - 316023 != -162217)
		{
		}
		do
		{
			if (Time.time - this.oBuOto7uIM >= this.zBiOXhwwdW)
			{
				if (265460 - 366333 == -100872)
				{
					continue;
				}
				if (Time.time - this.oBuOto7uIM < this.zBiOXhwwdW + mTime)
				{
					if (113210 - 426443 != -313233)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (270735 - 219135 == 51601)
						{
							continue;
						}
						this.AI_state = "idle";
						if (273337 - 126882 == 146456)
						{
							continue;
						}
						this.oBuOto7uIM -= UnityEngine.Random.Range((float)0, rTimer);
						if (235988 - 512302 != -276314)
						{
							continue;
						}
						this.rrpOJ4w3jG.vDirection = Vector3.zero;
						if (227258 - 26664 != 200594)
						{
							continue;
						}
						this.rrpOJ4w3jG.vMovement = this.transform.forward;
						if (676 - 398902 == -398225)
						{
							continue;
						}
						this.rrpOJ4w3jG.actionState = "standby";
						if (224048 - 77744 != 146304)
						{
							continue;
						}
					}
					this.rrpOJ4w3jG.moveSpeed = Mathf.Lerp(this.rrpOJ4w3jG.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (222252 - 306569 == -84316)
					{
						continue;
					}
					if (this.rrpOJ4w3jG.moveSpeed < 0.1f * this.rrpOJ4w3jG.runSpeed)
					{
						if (227631 - 155965 != 71666)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (197778 - 366359 != -168581)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (42991 - 389856 != -346865)
						{
							continue;
						}
						this.rrpOJ4w3jG.moveSpeed = (float)0;
						if (67632 - 225985 != -158353)
						{
							continue;
						}
					}
				}
			}
			this.zBiOXhwwdW += mTime;
		}
		while (39197 - 406089 == -366891);
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x002416D4 File Offset: 0x0023F8D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (46821 - 486381 != -439559)
		{
		}
		do
		{
			if (Time.time - this.oBuOto7uIM >= this.zBiOXhwwdW)
			{
				if (100871 - 496084 != -395213)
				{
					continue;
				}
				if (Time.time - this.oBuOto7uIM < this.zBiOXhwwdW + mTime)
				{
					if (98486 - 373710 == -275223)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (284389 - 570637 == -286247)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (294398 - 242251 != 52147)
						{
							continue;
						}
						this.oBuOto7uIM -= UnityEngine.Random.Range((float)0, rTimer);
						if (33904 - 88578 == -54673)
						{
							continue;
						}
						this.rrpOJ4w3jG.vDirection = this.rrpOJ4w3jG.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (164048 - 530316 != -366268)
						{
							continue;
						}
						this.rrpOJ4w3jG.vDirection.y = this.transform.position.y;
						if (235034 - 388243 != -153209)
						{
							continue;
						}
						this.rrpOJ4w3jG.vMovement = (this.rrpOJ4w3jG.vDirection - this.transform.position).normalized;
						if (141096 - 114310 == 26787)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.rrpOJ4w3jG.vMovement);
						if (96214 - 43543 != 52671)
						{
							continue;
						}
						this.rrpOJ4w3jG.actionState = "run";
						if (55119 - 408269 == -353149)
						{
							continue;
						}
						this.animation.Play("run");
						if (208072 - 506330 == -298257)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (66422 - 584756 != -518334)
						{
							continue;
						}
					}
					this.rrpOJ4w3jG.moveSpeed = Mathf.Lerp(this.rrpOJ4w3jG.moveSpeed, this.rrpOJ4w3jG.runSpeed, (float)4 * Time.deltaTime);
					if (44672 - 259208 == -214535)
					{
						continue;
					}
				}
			}
			this.zBiOXhwwdW += mTime;
		}
		while (167129 - 223765 == -56635);
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x002419DC File Offset: 0x0023FBDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (122624 - 477137 != -354513)
		{
		}
		for (;;)
		{
			this.rrpOJ4w3jG.vDirection = followObject.transform.position;
			if (26341 - 229482 != -203140)
			{
				this.rrpOJ4w3jG.vDirection.y = this.transform.position.y;
				if (70706 - 581712 != -511005)
				{
					this.rrpOJ4w3jG.vMovement = (this.rrpOJ4w3jG.vDirection - this.transform.position).normalized;
					if (49936 - 391150 == -341214)
					{
						this.transform.rotation = Quaternion.LookRotation(this.rrpOJ4w3jG.vMovement);
						if (206387 - 298940 == -92553)
						{
							this.rrpOJ4w3jG.actionState = "run";
							if (150564 - 452999 == -302435)
							{
								this.animation.Play("run");
								if (12216 - 188485 == -176269)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (20309 - 296630 == -276321)
									{
										this.rrpOJ4w3jG.moveSpeed = Mathf.Lerp(this.rrpOJ4w3jG.moveSpeed, this.rrpOJ4w3jG.runSpeed, (float)4 * Time.deltaTime);
										if (96069 - 534662 != -438592)
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

	// Token: 0x0600161E RID: 5662 RVA: 0x00241BC4 File Offset: 0x0023FDC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (31112 - 442697 != -411585)
		{
		}
		do
		{
			if (Time.time - this.oBuOto7uIM >= this.zBiOXhwwdW)
			{
				if (273716 - 356072 == -82355)
				{
					continue;
				}
				if (Time.time - this.oBuOto7uIM < this.zBiOXhwwdW + mTime)
				{
					if (61166 - 186252 == -125085)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (260674 - 237268 != 23406)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (9990 - 216037 != -206047)
						{
							continue;
						}
						this.oBuOto7uIM = Time.time - mTime - this.zBiOXhwwdW;
						if (59363 - 23335 != 36028)
						{
							continue;
						}
						this.rrpOJ4w3jG.vDirection = Vector3.zero;
						if (108658 - 112375 == -3716)
						{
							continue;
						}
						this.rrpOJ4w3jG.vMovement = this.transform.forward;
						if (18691 - 348791 != -330100)
						{
							continue;
						}
						this.rrpOJ4w3jG.actionState = "standby";
						if (28654 - 335377 == -306722)
						{
							continue;
						}
						this.rrpOJ4w3jG.myAttackTarget = this.rrpOJ4w3jG.getHateTarget(5, 50);
						if (77477 - 465053 != -387576)
						{
							continue;
						}
						if (!this.rrpOJ4w3jG.myAttackTarget)
						{
							if (251083 - 294888 != -43805)
							{
								continue;
							}
							this.rrpOJ4w3jG.isAlert = false;
							if (106037 - 367304 != -261267)
							{
								continue;
							}
							this.oBuOto7uIM = Time.time;
							if (20628 - 398405 == -377776)
							{
								continue;
							}
							this.rrpOJ4w3jG.myAttackTarget = null;
							if (176612 - 200202 != -23590)
							{
								continue;
							}
							this.rrpOJ4w3jG.mOriginalPosition = this.transform.position;
							if (16749 - 117719 != -100969)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.rrpOJ4w3jG.myAttackTarget;
							if (246403 - 326891 == -80487)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (196781 - 249549 == -52767)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (261168 - 87874 == 173295)
								{
									continue;
								}
								this.rrpOJ4w3jG.isAlert = false;
								if (115306 - 199827 != -84521)
								{
									continue;
								}
								this.oBuOto7uIM = Time.time;
								if (253816 - 342227 != -88411)
								{
									continue;
								}
								this.rrpOJ4w3jG.myAttackTarget = null;
								if (9427 - 241525 != -232098)
								{
									continue;
								}
							}
							else
							{
								this.rrpOJ4w3jG.vDirection = myAttackTarget.transform.position;
								if (236624 - 361797 != -125173)
								{
									continue;
								}
								this.rrpOJ4w3jG.vDirection.y = this.transform.position.y;
								if (84030 - 497401 != -413371)
								{
									continue;
								}
								this.rrpOJ4w3jG.vMovement = (this.rrpOJ4w3jG.vDirection - this.transform.position).normalized;
								if (77143 - 382086 != -304943)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.rrpOJ4w3jG.vMovement);
								if (94511 - 421342 != -326831)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.zBiOXhwwdW += mTime;
		}
		while (255036 - 439334 == -184297);
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x00242074 File Offset: 0x00240274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new ShadowWhale_AI.$AI_attack$19003(mTime, this).GetEnumerator();
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x00242084 File Offset: 0x00240284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (83596 - 181937 != -98340)
		{
		}
		while (Time.time - this.oBuOto7uIM > this.zBiOXhwwdW)
		{
			if (10870 - 597577 == -586707)
			{
				this.AI_state = "none";
				if (23172 - 108251 == -85079)
				{
					this.oBuOto7uIM = Time.time;
					if (161725 - 393794 != -232068)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001621 RID: 5665 RVA: 0x00242138 File Offset: 0x00240338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (32912 - 200747 != -167834)
		{
		}
		for (;;)
		{
			IL_602:
			if (this.gmaO2us48M + (float)1 > Time.time)
			{
				if (54021 - 368014 == -313993)
				{
					break;
				}
			}
			else
			{
				this.gmaO2us48M = Time.time;
				if (53870 - 469162 == -415292)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (100812 - 437683 != -336870 && 251191 - 427468 != -176276)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (145262 - 225489 == -80227)
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
								if (184889 - 184776 != 113)
								{
									goto IL_602;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (58998 - 305866 != -246868)
								{
									goto IL_602;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (74591 - 483390 == -408798)
								{
									goto IL_602;
								}
								bool flag = true;
								if (80557 - 181945 == -101387)
								{
									goto IL_602;
								}
								eRace race = this.rrpOJ4w3jG.Race;
								if (194867 - 29988 == 164880)
								{
									goto IL_602;
								}
								if (race == eRace.Tails)
								{
									if (210953 - 222954 == -12000)
									{
										goto IL_602;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_124;
									}
									if (107479 - 568748 == -461268)
									{
										goto IL_602;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (201011 - 170899 != 30112)
										{
											goto IL_602;
										}
										goto IL_124;
									}
									goto IL_213;
									IL_124:
									flag = false;
									if (193228 - 118162 != 75066)
									{
										goto IL_602;
									}
								}
								else if (race == eRace.Plants)
								{
									if (28727 - 392461 == -363733)
									{
										goto IL_602;
									}
									flag = false;
									if (223546 - 438457 != -214911)
									{
										goto IL_602;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (235925 - 235975 != -50)
									{
										goto IL_602;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_25A;
									}
									if (254939 - 310882 == -55942)
									{
										goto IL_602;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (258802 - 239102 != 19700)
										{
											goto IL_602;
										}
										goto IL_25A;
									}
									goto IL_213;
									IL_25A:
									flag = false;
									if (61804 - 99000 != -37196)
									{
										goto IL_602;
									}
								}
								else if (race == eRace.Robots)
								{
									if (42149 - 593064 == -550914)
									{
										goto IL_602;
									}
									flag = true;
									if (195768 - 134444 == 61325)
									{
										goto IL_602;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (252615 - 5179 != 247436)
									{
										goto IL_602;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_578;
									}
									if (2869 - 190535 != -187666)
									{
										goto IL_602;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_578;
									}
									if (170376 - 13552 != 156824)
									{
										goto IL_602;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (283975 - 285598 != -1622)
										{
											goto IL_578;
										}
										goto IL_602;
									}
									goto IL_213;
									IL_578:
									flag = false;
									if (125959 - 5307 == 120653)
									{
										goto IL_602;
									}
								}
								else if (race == eRace.Structure)
								{
									if (34347 - 352225 != -317878)
									{
										goto IL_602;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (151314 - 540104 != -388790)
										{
											goto IL_602;
										}
										flag = false;
										if (99444 - 106299 == -6854)
										{
											goto IL_602;
										}
									}
								}
								IL_213:
								if (flag)
								{
									if (42026 - 396337 == -354310)
									{
										goto IL_602;
									}
									if (characterControl.hp > 0)
									{
										if (70329 - 584895 == -514565)
										{
											goto IL_602;
										}
										if (characterControl.recieveTarget)
										{
											if (96356 - 265397 != -169041)
											{
												goto IL_602;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (146180 - 535815 != -389635)
												{
													goto IL_602;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (30055 - 321234 == -291178)
													{
														goto IL_602;
													}
													this.rrpOJ4w3jG.isAlert = true;
													if (35731 - 99423 != -63692)
													{
														goto IL_602;
													}
													this.oBuOto7uIM = Time.time;
													if (136003 - 314986 != -178983)
													{
														goto IL_602;
													}
													this.rrpOJ4w3jG.myAttackTarget = gameObject;
													if (204287 - 397302 != -193015)
													{
														goto IL_602;
													}
													UnityRuntimeServices.Update(enumerator, gameObject);
													if (108214 - 246304 == -138089)
													{
														goto IL_602;
													}
													this.rrpOJ4w3jG.addHate(characterControl.ActorNr, 5);
													if (265815 - 2297 != 263518)
													{
														goto IL_602;
													}
												}
											}
										}
									}
								}
							}
							if (745 - 151183 == -150438)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001622 RID: 5666 RVA: 0x00242788 File Offset: 0x00240988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001623 RID: 5667 RVA: 0x0024278C File Offset: 0x0024098C
	internal static bool gdqEx0FRgJScT1KODNs()
	{
		return true;
	}

	// Token: 0x06001624 RID: 5668 RVA: 0x00242790 File Offset: 0x00240990
	internal static bool MZVhgOFw5kWrkyb8APs()
	{
		return false;
	}

	// Token: 0x040012FC RID: 4860
	private CharacterControl rrpOJ4w3jG;

	// Token: 0x040012FD RID: 4861
	private Whale MpRO6fPs7u;

	// Token: 0x040012FE RID: 4862
	public string AI_state;

	// Token: 0x040012FF RID: 4863
	private float oBuOto7uIM;

	// Token: 0x04001300 RID: 4864
	private float zBiOXhwwdW;

	// Token: 0x04001301 RID: 4865
	private GameObject hFfOO361t2;

	// Token: 0x04001302 RID: 4866
	private float gmaO2us48M;

	// Token: 0x020003B9 RID: 953
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$19003 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001625 RID: 5669 RVA: 0x00242794 File Offset: 0x00240994
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$19003(float mTime, ShadowWhale_AI self_)
		{
			if (239476 - 813 != 238663)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237525 - 494327 != -256801)
				{
					base..ctor();
					if (57173 - 286649 != -229475)
					{
						this.$mTime$19011 = mTime;
						if (257751 - 390580 == -132829)
						{
							this.$self_$19012 = self_;
							if (168534 - 453599 == -285065)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00242850 File Offset: 0x00240A50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowWhale_AI.$AI_attack$19003.$(this.$mTime$19011, this.$self_$19012);
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00242864 File Offset: 0x00240A64
		internal static bool NOWyxHFqDUTWLMf3yEv()
		{
			return true;
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00242868 File Offset: 0x00240A68
		internal static bool TRrNWsF73EjEDP05GXc()
		{
			return false;
		}

		// Token: 0x04001303 RID: 4867
		internal float $mTime$19011;

		// Token: 0x04001304 RID: 4868
		internal ShadowWhale_AI $self_$19012;

		// Token: 0x020003BA RID: 954
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001629 RID: 5673 RVA: 0x0024286C File Offset: 0x00240A6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, ShadowWhale_AI self_)
			{
				if (173659 - 584176 != -410516)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (69601 - 104009 != -34407)
					{
						base..ctor();
						if (9965 - 52375 != -42409)
						{
							this.$mTime$19009 = mTime;
							if (294016 - 588227 != -294210)
							{
								this.$self_$19010 = self_;
								if (152100 - 219960 != -67859)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600162A RID: 5674 RVA: 0x00242928 File Offset: 0x00240B28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (22583 - 442629 != -420046)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2031;
					case 2:
						if (this.$self_$19010.rrpOJ4w3jG.actionState != "attack")
						{
							goto IL_EED;
						}
						if (265699 - 389130 == -123430)
						{
							continue;
						}
						if (this.$self_$19010.rrpOJ4w3jG.myCommand != "nAttack1")
						{
							if (124347 - 222437 != -98089)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_nAttack2(this.$self_$19010.transform.position, this.$tDir$19006.normalized, 0));
							if (186075 - 51229 != 134846)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_BAA;
							}
							if (146977 - 386071 == -239093)
							{
								continue;
							}
							this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_nAttack2", this.$self_$19010.transform.position, this.$tDir$19006.normalized, 0);
							if (258079 - 599856 != -341776)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19010.rrpOJ4w3jG.actionState != "attack")
						{
							goto IL_13E1;
						}
						if (106385 - 204176 != -97791)
						{
							continue;
						}
						if (this.$self_$19010.rrpOJ4w3jG.myCommand != "nAttack2")
						{
							if (225206 - 513499 != -288292)
							{
								goto Block_211;
							}
							continue;
						}
						else
						{
							this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_nAttack3(this.$self_$19010.transform.position, this.$tDir$19006.normalized, 0));
							if (77163 - 543928 != -466764)
							{
								if (PhotonClient.IsInitialized())
								{
									if (290080 - 268501 != 21579)
									{
										continue;
									}
									this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_nAttack3", this.$self_$19010.transform.position, this.$tDir$19006.normalized, 0);
									if (227193 - 299587 == -72393)
									{
										continue;
									}
								}
								goto IL_8A4;
							}
							continue;
						}
						break;
					default:
						if (274315 - 496130 != -221815)
						{
							continue;
						}
						break;
					}
					if (Time.time - this.$self_$19010.oBuOto7uIM >= this.$self_$19010.zBiOXhwwdW)
					{
						if (143812 - 131674 != 12138)
						{
							continue;
						}
						if (Time.time - this.$self_$19010.oBuOto7uIM < this.$self_$19010.zBiOXhwwdW + this.$mTime$19009)
						{
							if (3491 - 437694 != -434203)
							{
								continue;
							}
							if (!this.$self_$19010.rrpOJ4w3jG.myAttackTarget)
							{
								if (290767 - 111491 != 179276)
								{
									continue;
								}
								this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
								if (158640 - 315361 != -156720)
								{
									goto Block_72;
								}
								continue;
							}
							else
							{
								this.$tObject$19004 = this.$self_$19010.rrpOJ4w3jG.myAttackTarget;
								if (32464 - 239988 == -207523)
								{
									continue;
								}
								this.$tChar$19005 = (CharacterControl)this.$tObject$19004.GetComponent(typeof(CharacterControl));
								if (178679 - 79701 != 98978)
								{
									continue;
								}
								this.$tDir$19006 = global::Math.vFlat(this.$tObject$19004.transform.position - this.$self_$19010.transform.position);
								if (207598 - 526275 == -318676)
								{
									continue;
								}
								this.$tID$19007 = 0;
								if (127407 - 546055 != -418648)
								{
									continue;
								}
								if (this.$tChar$19005)
								{
									if (70209 - 343347 == -273137)
									{
										continue;
									}
									this.$tID$19007 = this.$tChar$19005.ActorNr;
									if (13245 - 292421 != -279176)
									{
										continue;
									}
								}
								this.$distance$19008 = this.$tDir$19006.magnitude - this.$tObject$19004.collider.bounds.extents.x;
								if (257936 - 438719 == -180782)
								{
									continue;
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 90)
								{
									if (150081 - 310321 != -160240)
									{
										continue;
									}
									if (this.$distance$19008 < (float)32)
									{
										if (174554 - 365471 == -190916)
										{
											continue;
										}
										if (this.$self_$19010.rrpOJ4w3jG.hasSkill(372))
										{
											if (223119 - 327974 == -104854)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("megalodon") == (float)0)
											{
												if (119438 - 569114 == -449675)
												{
													continue;
												}
												this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
												if (203495 - 348698 == -145202)
												{
													continue;
												}
												this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_cast1("megalodon", this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007, 2));
												if (258263 - 158925 != 99338)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (163495 - 163746 != -251)
													{
														continue;
													}
													this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_megalodon2", this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007);
													if (204151 - 10205 == 193947)
													{
														continue;
													}
												}
												goto IL_8A4;
											}
										}
									}
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 85)
								{
									if (265953 - 529156 != -263203)
									{
										continue;
									}
									if (this.$distance$19008 < (float)32)
									{
										if (179672 - 559720 == -380047)
										{
											continue;
										}
										if (this.$self_$19010.rrpOJ4w3jG.hasSkill(272))
										{
											if (44420 - 107358 == -62937)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("12thKingdomKnight") == (float)0)
											{
												if (151856 - 357882 == -206025)
												{
													continue;
												}
												this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
												if (110899 - 276528 != -165629)
												{
													continue;
												}
												this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_kingdomKnight(this.$self_$19010.transform.position, this.$self_$19010.transform.forward, this.$self_$19010.rrpOJ4w3jG.ActorNr, 2));
												if (278729 - 375479 != -96749)
												{
													if (PhotonClient.IsInitialized())
													{
														if (113256 - 164194 == -50937)
														{
															continue;
														}
														this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_kingdomKnight2", this.$self_$19010.transform.position, this.$self_$19010.transform.forward, this.$self_$19010.rrpOJ4w3jG.ActorNr);
														if (142881 - 113760 == 29122)
														{
															continue;
														}
													}
													goto IL_8A4;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 50)
								{
									if (132348 - 225071 == -92722)
									{
										continue;
									}
									if (this.$distance$19008 < (float)2)
									{
										if (110831 - 189425 == -78593)
										{
											continue;
										}
										if (this.$self_$19010.rrpOJ4w3jG.hasSkill(344))
										{
											if (225965 - 6741 == 219225)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("malStorm") == (float)0)
											{
												if (235872 - 371642 != -135770)
												{
													continue;
												}
												this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
												if (180861 - 252007 != -71146)
												{
													continue;
												}
												this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_malStorm(this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007, 2));
												if (298824 - 476581 != -177756)
												{
													if (PhotonClient.IsInitialized())
													{
														if (129547 - 248135 != -118588)
														{
															continue;
														}
														this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_malStorm2", this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007);
														if (167801 - 446356 == -278554)
														{
															continue;
														}
													}
													goto IL_8A4;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 45)
								{
									if (20223 - 64639 == -44415)
									{
										continue;
									}
									if (this.$distance$19008 < (float)2)
									{
										if (230840 - 511147 == -280306)
										{
											continue;
										}
										if (this.$self_$19010.rrpOJ4w3jG.hasSkill(244))
										{
											if (53969 - 122215 == -68245)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("peninsulaRound") == (float)0)
											{
												if (99765 - 49699 == 50067)
												{
													continue;
												}
												this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
												if (267746 - 378707 == -110960)
												{
													continue;
												}
												this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_peninsulaRound(this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007, 2));
												if (128072 - 206831 != -78758)
												{
													if (PhotonClient.IsInitialized())
													{
														if (13617 - 96745 == -83127)
														{
															continue;
														}
														this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_peninsulaRound2", this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007);
														if (242259 - 121836 != 120423)
														{
															continue;
														}
													}
													goto IL_8A4;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 40)
								{
									if (214976 - 401739 == -186762)
									{
										continue;
									}
									if (this.$distance$19008 < (float)2)
									{
										if (31774 - 146328 == -114553)
										{
											continue;
										}
										if (this.$self_$19010.rrpOJ4w3jG.hasSkill(342))
										{
											if (264040 - 41466 != 222574)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("whaleWave") == (float)0)
											{
												if (10645 - 254371 == -243725)
												{
													continue;
												}
												this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
												if (57150 - 347329 != -290179)
												{
													continue;
												}
												this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_whaleWave(this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007, 2));
												if (89860 - 213270 != -123410)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (117842 - 215328 == -97485)
													{
														continue;
													}
													this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_whaleWave2", this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007);
													if (213220 - 397209 != -183989)
													{
														continue;
													}
												}
												goto IL_8A4;
											}
										}
									}
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 35)
								{
									if (94606 - 266137 == -171530)
									{
										continue;
									}
									if (this.$distance$19008 < (float)2)
									{
										if (79404 - 476139 == -396734)
										{
											continue;
										}
										if (this.$self_$19010.rrpOJ4w3jG.hasSkill(242))
										{
											if (187588 - 570953 != -383365)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("peninsulaImpale") == (float)0)
											{
												if (251395 - 556906 == -305510)
												{
													continue;
												}
												this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
												if (165630 - 251123 != -85493)
												{
													continue;
												}
												this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_peninsulaImpale(this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007, 2));
												if (59313 - 26697 != 32617)
												{
													if (PhotonClient.IsInitialized())
													{
														if (140904 - 379307 == -238402)
														{
															continue;
														}
														this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_peninsulaImpale2", this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007);
														if (186883 - 35291 != 151592)
														{
															continue;
														}
													}
													goto IL_8A4;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 30)
								{
									if (45231 - 271529 == -226297)
									{
										continue;
									}
									if (!this.$self_$19010.rrpOJ4w3jG.hasStatus("rejuvenate"))
									{
										if (298907 - 72445 == 226463)
										{
											continue;
										}
										if (this.$self_$19010.rrpOJ4w3jG.hasSkill(334))
										{
											if (107656 - 110337 != -2681)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("rejuvenate") == (float)0)
											{
												if (223565 - 23455 == 200111)
												{
													continue;
												}
												this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
												if (109502 - 501590 != -392088)
												{
													continue;
												}
												this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_cast1("rejuvenate", this.$self_$19010.transform.position, this.$self_$19010.transform.forward, this.$self_$19010.rrpOJ4w3jG.ActorNr, 4));
												if (130755 - 439454 != -308699)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (51543 - 512702 == -461158)
													{
														continue;
													}
													this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_rejuvenate4", this.$self_$19010.transform.position, this.$self_$19010.transform.forward, this.$self_$19010.rrpOJ4w3jG.ActorNr);
													if (193418 - 194498 == -1079)
													{
														continue;
													}
												}
												goto IL_8A4;
											}
										}
									}
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 25)
								{
									if (293495 - 132755 != 160740)
									{
										continue;
									}
									if (this.$distance$19008 < (float)2)
									{
										if (184361 - 598797 != -414436)
										{
											continue;
										}
										if (this.$self_$19010.rrpOJ4w3jG.hasSkill(222))
										{
											if (163717 - 309684 != -145967)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("shieldRush") == (float)0)
											{
												if (253882 - 579601 != -325719)
												{
													continue;
												}
												this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
												if (264702 - 49511 == 215192)
												{
													continue;
												}
												this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_shieldRush(this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007, 2));
												if (151296 - 245291 != -93995)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (198853 - 568652 != -369799)
													{
														continue;
													}
													this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_shieldRush2", this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007);
													if (197475 - 303956 != -106481)
													{
														continue;
													}
												}
												goto IL_8A4;
											}
										}
									}
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 20)
								{
									if (148515 - 485799 == -337283)
									{
										continue;
									}
									if (this.$distance$19008 > (float)4)
									{
										if (271234 - 163783 != 107451)
										{
											continue;
										}
										if (this.$self_$19010.rrpOJ4w3jG.hasSkill(324))
										{
											if (126704 - 51286 != 75418)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("hydroBlast") == (float)0)
											{
												if (162938 - 71834 == 91105)
												{
													continue;
												}
												this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
												if (151289 - 210278 == -58988)
												{
													continue;
												}
												this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_cast1("hydroBlast", this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007, 4));
												if (298957 - 420340 != -121382)
												{
													if (PhotonClient.IsInitialized())
													{
														if (64885 - 97803 == -32917)
														{
															continue;
														}
														this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_hydroBlast4", this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007);
														if (250177 - 40343 == 209835)
														{
															continue;
														}
													}
													goto IL_8A4;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 15)
								{
									if (139781 - 155319 != -15538)
									{
										continue;
									}
									if (this.$distance$19008 > (float)4)
									{
										if (15900 - 166637 != -150737)
										{
											continue;
										}
										if (this.$distance$19008 < (float)12)
										{
											if (154986 - 8620 == 146367)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.hasSkill(204))
											{
												if (70864 - 415671 != -344807)
												{
													continue;
												}
												if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("javelin") == (float)0)
												{
													if (210551 - 176950 != 33601)
													{
														continue;
													}
													this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
													if (10659 - 537498 == -526838)
													{
														continue;
													}
													this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_javelin(this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007, 2));
													if (190815 - 259975 != -69159)
													{
														if (PhotonClient.IsInitialized())
														{
															if (206091 - 404056 == -197964)
															{
																continue;
															}
															this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_javelin2", this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007);
															if (105700 - 72241 != 33459)
															{
																continue;
															}
														}
														goto IL_8A4;
													}
													continue;
												}
											}
										}
									}
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 10)
								{
									if (131781 - 448140 != -316359)
									{
										continue;
									}
									if (!this.$self_$19010.rrpOJ4w3jG.hasStatus("bubbleShield"))
									{
										if (3818 - 492732 == -488913)
										{
											continue;
										}
										if (this.$self_$19010.rrpOJ4w3jG.hasSkill(304))
										{
											if (6509 - 55458 != -48949)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("bubbleShield") == (float)0)
											{
												if (146489 - 54182 == 92308)
												{
													continue;
												}
												this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
												if (201545 - 521903 == -320357)
												{
													continue;
												}
												this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_cast1("bubbleShield", this.$self_$19010.transform.position, this.$self_$19010.transform.forward, this.$self_$19010.rrpOJ4w3jG.ActorNr, 4));
												if (155048 - 485989 != -330940)
												{
													if (PhotonClient.IsInitialized())
													{
														if (212307 - 164715 == 47593)
														{
															continue;
														}
														this.$self_$19010.MpRO6fPs7u.ActionEvent("bubbleShield", this.$self_$19010.transform.position, this.$self_$19010.transform.forward, this.$self_$19010.rrpOJ4w3jG.ActorNr);
														if (9525 - 537797 == -528271)
														{
															continue;
														}
													}
													goto IL_8A4;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$19010.rrpOJ4w3jG.sp > 5)
								{
									if (228310 - 481801 != -253491)
									{
										continue;
									}
									if (this.$distance$19008 < (float)2)
									{
										if (126379 - 120369 != 6010)
										{
											continue;
										}
										if (this.$self_$19010.rrpOJ4w3jG.hasSkill(202))
										{
											if (110431 - 575101 == -464669)
											{
												continue;
											}
											if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("sweep") == (float)0)
											{
												if (127496 - 496381 == -368884)
												{
													continue;
												}
												this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
												if (52275 - 78444 == -26168)
												{
													continue;
												}
												this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_sweep(this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007, 2));
												if (43926 - 498230 != -454304)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (52027 - 503773 == -451745)
													{
														continue;
													}
													this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_sweep2", this.$self_$19010.transform.position, this.$tDir$19006.normalized, this.$tID$19007);
													if (148664 - 299060 != -150396)
													{
														continue;
													}
												}
												goto IL_8A4;
											}
										}
									}
								}
								if (this.$distance$19008 < (float)1)
								{
									if (23989 - 323229 == -299239)
									{
										continue;
									}
									if (this.$self_$19010.rrpOJ4w3jG.isTimeOut("nAttack") == (float)0)
									{
										if (256286 - 23723 == 232564)
										{
											continue;
										}
										this.$self_$19010.oBuOto7uIM = Time.time - this.$mTime$19009 - this.$self_$19010.zBiOXhwwdW;
										if (291994 - 429598 != -137604)
										{
											continue;
										}
										this.$self_$19010.MpRO6fPs7u.StartCoroutine_Auto(this.$self_$19010.MpRO6fPs7u.RPC_nAttack1(this.$self_$19010.transform.position, this.$tObject$19004.collider.bounds.center - this.$self_$19010.transform.position, 0));
										if (102205 - 573438 == -471232)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											goto IL_1F05;
										}
										if (82169 - 394357 == -312187)
										{
											continue;
										}
										this.$self_$19010.MpRO6fPs7u.ActionEvent("RPC_nAttack1", this.$self_$19010.transform.position, this.$tObject$19004.collider.bounds.center - this.$self_$19010.transform.position, 0);
										if (72873 - 320340 != -247466)
										{
											goto Block_159;
										}
										continue;
									}
								}
								this.$self_$19010.AI_state = "attack";
								if (83281 - 299767 == -216485)
								{
									continue;
								}
								this.$self_$19010.rrpOJ4w3jG.vDirection = this.$tObject$19004.transform.position;
								if (81902 - 325283 != -243381)
								{
									continue;
								}
								this.$self_$19010.rrpOJ4w3jG.vDirection.y = this.$self_$19010.transform.position.y;
								if (149580 - 85393 != 64187)
								{
									continue;
								}
								this.$self_$19010.rrpOJ4w3jG.vMovement = (this.$self_$19010.rrpOJ4w3jG.vDirection - this.$self_$19010.transform.position).normalized;
								if (239479 - 338881 != -99402)
								{
									continue;
								}
								this.$self_$19010.transform.rotation = Quaternion.LookRotation(this.$self_$19010.rrpOJ4w3jG.vMovement);
								if (99952 - 150546 != -50594)
								{
									continue;
								}
								this.$self_$19010.rrpOJ4w3jG.actionState = "run";
								if (63534 - 124997 == -61462)
								{
									continue;
								}
								this.$self_$19010.animation.Play("run");
								if (290901 - 273948 != 16953)
								{
									continue;
								}
								this.$self_$19010.animation.wrapMode = WrapMode.Loop;
								if (255487 - 454022 != -198535)
								{
									continue;
								}
								this.$self_$19010.rrpOJ4w3jG.moveSpeed = Mathf.Lerp(this.$self_$19010.rrpOJ4w3jG.moveSpeed, this.$self_$19010.rrpOJ4w3jG.runSpeed, (float)4 * Time.deltaTime);
								if (256636 - 72130 != 184506)
								{
									continue;
								}
							}
						}
					}
					IL_8A4:
					this.$self_$19010.zBiOXhwwdW = this.$self_$19010.zBiOXhwwdW + this.$mTime$19009;
					if (291057 - 514096 != -223038)
					{
						this.YieldDefault(1);
						if (284964 - 584797 == -299833)
						{
							goto IL_2031;
						}
					}
				}
				Block_19:
				goto IL_BAA;
				Block_26:
				Block_72:
				goto IL_2031;
				IL_BAA:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_EED:
				IL_13E1:
				goto IL_2031;
				Block_159:
				IL_1F05:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_211:
				IL_2031:
				return false;
			}

			// Token: 0x0600162B RID: 5675 RVA: 0x00244978 File Offset: 0x00242B78
			internal static bool GRbL4bFPQGdxItns1sU()
			{
				return true;
			}

			// Token: 0x0600162C RID: 5676 RVA: 0x0024497C File Offset: 0x00242B7C
			internal static bool lwNYrJF0qE1JdfE3rSi()
			{
				return false;
			}

			// Token: 0x04001305 RID: 4869
			internal GameObject $tObject$19004;

			// Token: 0x04001306 RID: 4870
			internal CharacterControl $tChar$19005;

			// Token: 0x04001307 RID: 4871
			internal Vector3 $tDir$19006;

			// Token: 0x04001308 RID: 4872
			internal int $tID$19007;

			// Token: 0x04001309 RID: 4873
			internal float $distance$19008;

			// Token: 0x0400130A RID: 4874
			internal float $mTime$19009;

			// Token: 0x0400130B RID: 4875
			internal ShadowWhale_AI $self_$19010;
		}
	}
}
