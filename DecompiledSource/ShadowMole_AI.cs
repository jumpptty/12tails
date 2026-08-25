using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003A8 RID: 936
[Serializable]
public class ShadowMole_AI : MonoBehaviour
{
	// Token: 0x06001594 RID: 5524 RVA: 0x00229398 File Offset: 0x00227598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowMole_AI()
	{
		if (155257 - 493323 != -338066)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (155613 - 536394 == -380781)
			{
				base..ctor();
				if (179747 - 180135 == -388)
				{
					this.AI_state = "none";
					if (175597 - 73870 != 101728)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001595 RID: 5525 RVA: 0x00229434 File Offset: 0x00227634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.R1XXZ2M6mT = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.JqBXC1fBbl = (Mole)this.GetComponent(typeof(Mole));
	}

	// Token: 0x06001596 RID: 5526 RVA: 0x0022946C File Offset: 0x0022766C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (98437 - 454175 != -355738)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (245411 - 294704 == -49292)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (123162 - 561822 != -438660)
				{
					continue;
				}
			}
			if (this.R1XXZ2M6mT.isControlled)
			{
				break;
			}
			if (177578 - 124702 != 52877)
			{
				this.AIControl();
				if (224909 - 256485 != -31575)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001597 RID: 5527 RVA: 0x00229538 File Offset: 0x00227738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.kuGXLWppGc = nSummoner;
	}

	// Token: 0x06001598 RID: 5528 RVA: 0x00229544 File Offset: 0x00227744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (228137 - 18191 != 209947)
		{
		}
		for (;;)
		{
			this.uEpXfZwvYa = (float)0;
			if (174881 - 143458 != 31424)
			{
				if (this.R1XXZ2M6mT.isMine)
				{
					if (165017 - 455479 != -290461)
					{
						if (this.R1XXZ2M6mT.actionState != "standby")
						{
							if (51376 - 80362 == -28985)
							{
								continue;
							}
							if (this.R1XXZ2M6mT.actionState != "run")
							{
								if (48678 - 432106 != -383427)
								{
									break;
								}
								continue;
							}
						}
						if (this.kuGXLWppGc)
						{
							if (74581 - 207589 == -133008)
							{
								if (!this.R1XXZ2M6mT.isAlert)
								{
									if (116158 - 284471 != -168312)
									{
										Vector3 vector = this.kuGXLWppGc.transform.position - this.transform.position;
										if (58568 - 396939 == -338371)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (87170 - 394030 == -306859)
												{
													continue;
												}
												this.AI_follow(this.kuGXLWppGc);
												if (290432 - 395174 != -104742)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (71175 - 236307 != -165132)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (112561 - 435758 == -323196)
												{
													continue;
												}
												this.AI_resetTimer();
												if (256862 - 488090 == -231227)
												{
													continue;
												}
												this.AI_visionCheck();
												if (114031 - 145987 == -31955)
												{
													continue;
												}
											}
											if (!this.R1XXZ2M6mT.myAttackTarget)
											{
												break;
											}
											if (152514 - 354351 == -201837)
											{
												this.R1XXZ2M6mT.isAlert = true;
												if (29207 - 418399 == -389192)
												{
													this.N2GXMxBwFv = Time.time;
													if (72383 - 168264 == -95881)
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
									Vector3 vector2 = this.kuGXLWppGc.transform.position - this.transform.position;
									if (146895 - 231795 == -84900)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (174792 - 89814 != 84979)
											{
												this.R1XXZ2M6mT.isAlert = false;
												if (179875 - 120738 != 59138)
												{
													this.AI_resetTimer();
													if (196023 - 479256 == -283233)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (9592 - 304322 == -294730)
											{
												this.AI_patrol(3f, 1f);
												if (74398 - 182005 == -107607)
												{
													this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
													if (220708 - 241861 != -21152)
													{
														this.AI_resetTimer();
														if (151968 - 333862 != -181893)
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
						else if (!this.R1XXZ2M6mT.isAlert)
						{
							if (198814 - 167522 != 31293)
							{
								this.AI_idle(3f, 1f);
								if (222726 - 102592 != 120135)
								{
									this.AI_patrol(1f, 0.25f);
									if (156638 - 152425 == 4213)
									{
										this.AI_resetTimer();
										if (67528 - 553269 != -485740)
										{
											this.AI_visionCheck();
											if (117365 - 384191 == -266826)
											{
												if (!this.R1XXZ2M6mT.myAttackTarget)
												{
													break;
												}
												if (114528 - 120977 != -6448)
												{
													this.R1XXZ2M6mT.isAlert = true;
													if (2503 - 438222 == -435719)
													{
														this.N2GXMxBwFv = Time.time;
														if (123934 - 293648 != -169713)
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
							if (175267 - 567936 != -392668)
							{
								this.AI_patrol(3f, 1f);
								if (81323 - 411080 == -329757)
								{
									this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
									if (89229 - 80042 == 9187)
									{
										this.AI_resetTimer();
										if (104555 - 117170 == -12615)
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
					if (this.R1XXZ2M6mT.actionState != "standby")
					{
						if (1155 - 365294 == -364138)
						{
							continue;
						}
						if (this.R1XXZ2M6mT.actionState != "run")
						{
							if (118270 - 302203 != -183932)
							{
								break;
							}
							continue;
						}
					}
					float num = this.R1XXZ2M6mT.moveSpeed;
					if (221571 - 442383 == -220812)
					{
						float runSpeed = this.R1XXZ2M6mT.runSpeed;
						if (139152 - 220160 == -81008)
						{
							Vector3 vector3 = default(Vector3);
							if (63344 - 417509 == -354165)
							{
								Vector3 vector4 = Vector3.zero;
								if (69560 - 232760 == -163200)
								{
									if ((this.R1XXZ2M6mT.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (164257 - 248417 != -84160)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.R1XXZ2M6mT.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (16264 - 500429 == -484164)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (248816 - 522192 == -273375)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (158022 - 460617 == -302594)
											{
												continue;
											}
											num = (float)0;
											if (251935 - 350225 == -98289)
											{
												continue;
											}
											this.transform.position = this.R1XXZ2M6mT.nPosition;
											if (261071 - 544431 == -283359)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (189338 - 152607 == 36732)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (88697 - 239917 != -151220)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (85614 - 303416 != -217802)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (53573 - 40345 == 13229)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (266610 - 274986 == -8375)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (293514 - 51771 != 241743)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (26843 - 198063 != -171220)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (239771 - 361205 != -121434)
											{
												continue;
											}
										}
									}
									this.R1XXZ2M6mT.vMovement = vector4;
									if (163298 - 338133 == -174835)
									{
										this.R1XXZ2M6mT.moveSpeed = num;
										if (60415 - 266438 == -206023)
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

	// Token: 0x06001599 RID: 5529 RVA: 0x00229F10 File Offset: 0x00228110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (282392 - 200375 != 82018)
		{
		}
		do
		{
			if (Time.time - this.N2GXMxBwFv >= this.uEpXfZwvYa)
			{
				if (3284 - 133034 != -129750)
				{
					continue;
				}
				if (Time.time - this.N2GXMxBwFv < this.uEpXfZwvYa + mTime)
				{
					if (192542 - 474759 != -282217)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (97157 - 369985 != -272828)
						{
							continue;
						}
						this.AI_state = "idle";
						if (79299 - 193764 != -114465)
						{
							continue;
						}
						this.N2GXMxBwFv -= UnityEngine.Random.Range((float)0, rTimer);
						if (112362 - 167048 == -54685)
						{
							continue;
						}
						this.R1XXZ2M6mT.vDirection = Vector3.zero;
						if (7274 - 170061 == -162786)
						{
							continue;
						}
						this.R1XXZ2M6mT.vMovement = this.transform.forward;
						if (10403 - 391893 == -381489)
						{
							continue;
						}
						this.R1XXZ2M6mT.actionState = "standby";
						if (226794 - 479866 != -253072)
						{
							continue;
						}
					}
					this.R1XXZ2M6mT.moveSpeed = Mathf.Lerp(this.R1XXZ2M6mT.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (157747 - 16188 != 141559)
					{
						continue;
					}
					if (this.R1XXZ2M6mT.moveSpeed < 0.1f * this.R1XXZ2M6mT.runSpeed)
					{
						if (241291 - 394337 == -153045)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (148910 - 313295 != -164385)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (286335 - 11377 == 274959)
						{
							continue;
						}
						this.R1XXZ2M6mT.moveSpeed = (float)0;
						if (206641 - 570931 != -364290)
						{
							continue;
						}
					}
				}
			}
			this.uEpXfZwvYa += mTime;
		}
		while (52796 - 126958 == -74161);
	}

	// Token: 0x0600159A RID: 5530 RVA: 0x0022A1D4 File Offset: 0x002283D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (226550 - 83430 != 143121)
		{
		}
		do
		{
			if (Time.time - this.N2GXMxBwFv >= this.uEpXfZwvYa)
			{
				if (241231 - 358744 == -117512)
				{
					continue;
				}
				if (Time.time - this.N2GXMxBwFv < this.uEpXfZwvYa + mTime)
				{
					if (119342 - 241550 == -122207)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (216963 - 248365 == -31401)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (123472 - 570202 == -446729)
						{
							continue;
						}
						this.N2GXMxBwFv -= UnityEngine.Random.Range((float)0, rTimer);
						if (24481 - 365332 == -340850)
						{
							continue;
						}
						this.R1XXZ2M6mT.vDirection = this.R1XXZ2M6mT.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (274423 - 521170 == -246746)
						{
							continue;
						}
						this.R1XXZ2M6mT.vDirection.y = this.transform.position.y;
						if (152651 - 32308 == 120344)
						{
							continue;
						}
						this.R1XXZ2M6mT.vMovement = (this.R1XXZ2M6mT.vDirection - this.transform.position).normalized;
						if (291981 - 231759 == 60223)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.R1XXZ2M6mT.vMovement);
						if (114476 - 511856 == -397379)
						{
							continue;
						}
						this.R1XXZ2M6mT.actionState = "run";
						if (139003 - 249039 != -110036)
						{
							continue;
						}
						this.animation.Play("run");
						if (89056 - 493936 != -404880)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (102507 - 545655 != -443148)
						{
							continue;
						}
					}
					this.R1XXZ2M6mT.moveSpeed = Mathf.Lerp(this.R1XXZ2M6mT.moveSpeed, this.R1XXZ2M6mT.runSpeed, (float)4 * Time.deltaTime);
					if (134048 - 556293 != -422245)
					{
						continue;
					}
				}
			}
			this.uEpXfZwvYa += mTime;
		}
		while (7459 - 254818 != -247359);
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x0022A4DC File Offset: 0x002286DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (163585 - 334523 != -170938)
		{
		}
		for (;;)
		{
			this.R1XXZ2M6mT.vDirection = followObject.transform.position;
			if (247678 - 541774 != -294095)
			{
				this.R1XXZ2M6mT.vDirection.y = this.transform.position.y;
				if (161206 - 324233 == -163027)
				{
					this.R1XXZ2M6mT.vMovement = (this.R1XXZ2M6mT.vDirection - this.transform.position).normalized;
					if (110485 - 202590 != -92104)
					{
						this.transform.rotation = Quaternion.LookRotation(this.R1XXZ2M6mT.vMovement);
						if (211996 - 501306 != -289309)
						{
							this.R1XXZ2M6mT.actionState = "run";
							if (145365 - 569605 != -424239)
							{
								this.animation.Play("run");
								if (13541 - 99767 != -86225)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (16013 - 279799 == -263786)
									{
										this.R1XXZ2M6mT.moveSpeed = Mathf.Lerp(this.R1XXZ2M6mT.moveSpeed, this.R1XXZ2M6mT.runSpeed, (float)4 * Time.deltaTime);
										if (4476 - 216595 == -212119)
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

	// Token: 0x0600159C RID: 5532 RVA: 0x0022A6C4 File Offset: 0x002288C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (114070 - 228922 != -114851)
		{
		}
		do
		{
			if (Time.time - this.N2GXMxBwFv >= this.uEpXfZwvYa)
			{
				if (214804 - 260869 == -46064)
				{
					continue;
				}
				if (Time.time - this.N2GXMxBwFv < this.uEpXfZwvYa + mTime)
				{
					if (94528 - 308874 == -214345)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (104428 - 208139 != -103711)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (62729 - 326571 != -263842)
						{
							continue;
						}
						this.N2GXMxBwFv = Time.time - mTime - this.uEpXfZwvYa;
						if (177002 - 372104 != -195102)
						{
							continue;
						}
						this.R1XXZ2M6mT.vDirection = Vector3.zero;
						if (175009 - 197664 != -22655)
						{
							continue;
						}
						this.R1XXZ2M6mT.vMovement = this.transform.forward;
						if (220102 - 347507 != -127405)
						{
							continue;
						}
						this.R1XXZ2M6mT.actionState = "standby";
						if (278072 - 464403 == -186330)
						{
							continue;
						}
						this.R1XXZ2M6mT.myAttackTarget = this.R1XXZ2M6mT.getHateTarget(5, 50);
						if (34900 - 449535 == -414634)
						{
							continue;
						}
						if (!this.R1XXZ2M6mT.myAttackTarget)
						{
							if (190614 - 595632 == -405017)
							{
								continue;
							}
							this.R1XXZ2M6mT.isAlert = false;
							if (36058 - 599920 == -563861)
							{
								continue;
							}
							this.N2GXMxBwFv = Time.time;
							if (68447 - 32616 == 35832)
							{
								continue;
							}
							this.R1XXZ2M6mT.myAttackTarget = null;
							if (29850 - 242094 == -212243)
							{
								continue;
							}
							this.R1XXZ2M6mT.mOriginalPosition = this.transform.position;
							if (287228 - 88440 != 198789)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.R1XXZ2M6mT.myAttackTarget;
							if (284146 - 504273 == -220126)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (232870 - 562791 == -329920)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (156867 - 584347 == -427479)
								{
									continue;
								}
								this.R1XXZ2M6mT.isAlert = false;
								if (60026 - 198864 != -138838)
								{
									continue;
								}
								this.N2GXMxBwFv = Time.time;
								if (69485 - 483540 == -414054)
								{
									continue;
								}
								this.R1XXZ2M6mT.myAttackTarget = null;
								if (7726 - 235180 == -227453)
								{
									continue;
								}
							}
							else
							{
								this.R1XXZ2M6mT.vDirection = myAttackTarget.transform.position;
								if (82873 - 595770 != -512897)
								{
									continue;
								}
								this.R1XXZ2M6mT.vDirection.y = this.transform.position.y;
								if (32854 - 364852 == -331997)
								{
									continue;
								}
								this.R1XXZ2M6mT.vMovement = (this.R1XXZ2M6mT.vDirection - this.transform.position).normalized;
								if (212907 - 526799 != -313892)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.R1XXZ2M6mT.vMovement);
								if (6884 - 455416 == -448531)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.uEpXfZwvYa += mTime;
		}
		while (289087 - 570281 == -281193);
	}

	// Token: 0x0600159D RID: 5533 RVA: 0x0022AB74 File Offset: 0x00228D74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new ShadowMole_AI.$AI_attack$18953(mTime, this).GetEnumerator();
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x0022AB84 File Offset: 0x00228D84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (178098 - 118167 != 59931)
		{
		}
		while (Time.time - this.N2GXMxBwFv > this.uEpXfZwvYa)
		{
			if (269058 - 375353 == -106295)
			{
				this.AI_state = "none";
				if (42098 - 666 == 41432)
				{
					this.N2GXMxBwFv = Time.time;
					if (9174 - 154657 == -145483)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x0022AC38 File Offset: 0x00228E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (263885 - 325544 != -61659)
		{
		}
		for (;;)
		{
			IL_1EF:
			if (this.dTBXwqBK8c + (float)1 > Time.time)
			{
				if (175830 - 1425 == 174405)
				{
					break;
				}
			}
			else
			{
				this.dTBXwqBK8c = Time.time;
				if (248351 - 43612 == 204739)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (104473 - 527392 == -422919)
					{
						if (166263 - 526784 != -360520)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (259885 - 205757 != 54129)
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
									if (93100 - 422754 != -329654)
									{
										goto IL_1EF;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (60096 - 553956 != -493860)
									{
										goto IL_1EF;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (66883 - 171387 == -104503)
									{
										goto IL_1EF;
									}
									bool flag = true;
									if (162962 - 86443 == 76520)
									{
										goto IL_1EF;
									}
									eRace race = this.R1XXZ2M6mT.Race;
									if (149592 - 326596 == -177003)
									{
										goto IL_1EF;
									}
									if (race == eRace.Tails)
									{
										if (126078 - 82238 != 43840)
										{
											goto IL_1EF;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_F5;
										}
										if (198212 - 266699 == -68486)
										{
											goto IL_1EF;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (283214 - 288886 != -5672)
											{
												goto IL_1EF;
											}
											goto IL_F5;
										}
										goto IL_288;
										IL_F5:
										flag = false;
										if (238577 - 192838 == 45740)
										{
											goto IL_1EF;
										}
									}
									else if (race == eRace.Plants)
									{
										if (208988 - 472948 == -263959)
										{
											goto IL_1EF;
										}
										flag = false;
										if (110775 - 223336 != -112561)
										{
											goto IL_1EF;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (213372 - 494965 != -281593)
										{
											goto IL_1EF;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_1A;
										}
										if (284555 - 512196 != -227641)
										{
											goto IL_1EF;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (81413 - 90283 != -8869)
											{
												goto IL_1A;
											}
											goto IL_1EF;
										}
										goto IL_288;
										IL_1A:
										flag = false;
										if (241644 - 154797 != 86847)
										{
											goto IL_1EF;
										}
									}
									else if (race == eRace.Robots)
									{
										if (125575 - 137241 == -11665)
										{
											goto IL_1EF;
										}
										flag = true;
										if (174190 - 441243 == -267052)
										{
											goto IL_1EF;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (142267 - 469301 != -327034)
										{
											goto IL_1EF;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_396;
										}
										if (13770 - 163944 == -150173)
										{
											goto IL_1EF;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_396;
										}
										if (267155 - 546331 == -279175)
										{
											goto IL_1EF;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (162521 - 409910 != -247388)
											{
												goto IL_396;
											}
											goto IL_1EF;
										}
										goto IL_288;
										IL_396:
										flag = false;
										if (166507 - 297690 != -131183)
										{
											goto IL_1EF;
										}
									}
									else if (race == eRace.Structure)
									{
										if (188089 - 372897 != -184808)
										{
											goto IL_1EF;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (57126 - 355745 != -298619)
											{
												goto IL_1EF;
											}
											flag = false;
											if (105190 - 347244 != -242054)
											{
												goto IL_1EF;
											}
										}
									}
									IL_288:
									if (flag)
									{
										if (144487 - 137488 == 7000)
										{
											goto IL_1EF;
										}
										if (characterControl.hp > 0)
										{
											if (164048 - 410235 != -246187)
											{
												goto IL_1EF;
											}
											if (characterControl.recieveTarget)
											{
												if (96304 - 114438 != -18134)
												{
													goto IL_1EF;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (8041 - 86023 != -77982)
													{
														goto IL_1EF;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (105315 - 439740 != -334425)
														{
															goto IL_1EF;
														}
														this.R1XXZ2M6mT.isAlert = true;
														if (241543 - 234900 == 6644)
														{
															goto IL_1EF;
														}
														this.N2GXMxBwFv = Time.time;
														if (61030 - 26609 == 34422)
														{
															goto IL_1EF;
														}
														this.R1XXZ2M6mT.myAttackTarget = gameObject;
														if (224005 - 98704 != 125301)
														{
															goto IL_1EF;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (258213 - 200423 != 57790)
														{
															goto IL_1EF;
														}
														this.R1XXZ2M6mT.addHate(characterControl.ActorNr, 5);
														if (177203 - 576590 != -399387)
														{
															goto IL_1EF;
														}
													}
												}
											}
										}
									}
								}
								if (204289 - 336075 == -131786)
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

	// Token: 0x060015A0 RID: 5536 RVA: 0x0022B288 File Offset: 0x00229488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x0022B28C File Offset: 0x0022948C
	internal static bool f2Sjk8FXPk6fy5kvxMV()
	{
		return true;
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x0022B290 File Offset: 0x00229490
	internal static bool p5qRpBFQYB8WGK1jCcT()
	{
		return false;
	}

	// Token: 0x040012A5 RID: 4773
	private CharacterControl R1XXZ2M6mT;

	// Token: 0x040012A6 RID: 4774
	private Mole JqBXC1fBbl;

	// Token: 0x040012A7 RID: 4775
	public string AI_state;

	// Token: 0x040012A8 RID: 4776
	private float N2GXMxBwFv;

	// Token: 0x040012A9 RID: 4777
	private float uEpXfZwvYa;

	// Token: 0x040012AA RID: 4778
	private GameObject kuGXLWppGc;

	// Token: 0x040012AB RID: 4779
	private float dTBXwqBK8c;

	// Token: 0x020003A9 RID: 937
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$18953 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060015A3 RID: 5539 RVA: 0x0022B294 File Offset: 0x00229494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$18953(float mTime, ShadowMole_AI self_)
		{
			if (204929 - 221899 != -16969)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175582 - 467314 == -291732)
				{
					base..ctor();
					if (50060 - 61502 == -11442)
					{
						this.$mTime$18961 = mTime;
						if (152276 - 47719 == 104557)
						{
							this.$self_$18962 = self_;
							if (136910 - 298781 == -161871)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0022B350 File Offset: 0x00229550
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowMole_AI.$AI_attack$18953.$(this.$mTime$18961, this.$self_$18962);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0022B364 File Offset: 0x00229564
		internal static bool VKhQ4yFkLVp79KquePy()
		{
			return true;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0022B368 File Offset: 0x00229568
		internal static bool TC1OECFGCyridZFq5cc()
		{
			return false;
		}

		// Token: 0x040012AC RID: 4780
		internal float $mTime$18961;

		// Token: 0x040012AD RID: 4781
		internal ShadowMole_AI $self_$18962;

		// Token: 0x020003AA RID: 938
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060015A7 RID: 5543 RVA: 0x0022B36C File Offset: 0x0022956C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, ShadowMole_AI self_)
			{
				if (255908 - 579922 != -324014)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247947 - 576662 != -328714)
					{
						base..ctor();
						if (103527 - 83922 != 19606)
						{
							this.$mTime$18959 = mTime;
							if (88680 - 404116 == -315436)
							{
								this.$self_$18960 = self_;
								if (241173 - 538289 == -297116)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060015A8 RID: 5544 RVA: 0x0022B428 File Offset: 0x00229628
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237113 - 294047 != -56934)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1CB7;
					case 2:
						if (!this.$tObject$18954)
						{
							goto IL_1B3;
						}
						if (119162 - 60410 == 58753)
						{
							continue;
						}
						if (this.$self_$18960.R1XXZ2M6mT.actionState != "attack")
						{
							goto IL_1B3;
						}
						if (155097 - 367884 == -212786)
						{
							continue;
						}
						if (this.$self_$18960.R1XXZ2M6mT.myCommand != "nAttack1")
						{
							if (57432 - 297364 != -239932)
							{
								continue;
							}
							goto IL_1B3;
						}
						else
						{
							this.$tDir$18956 = global::Math.vFlat(this.$tObject$18954.transform.position - this.$self_$18960.transform.position);
							if (4587 - 76969 == -72381)
							{
								continue;
							}
							if (this.$tDir$18956.magnitude > (float)12)
							{
								if (45753 - 276066 != -230312)
								{
									goto Block_174;
								}
								continue;
							}
							else
							{
								this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_nAttack2(this.$self_$18960.transform.position, this.$tDir$18956, 0));
								if (75548 - 148543 != -72995)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_12D7;
								}
								if (69784 - 462520 == -392735)
								{
									continue;
								}
								this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_nAttack2", this.$self_$18960.transform.position, this.$tDir$18956, 0);
								if (161717 - 502392 != -340675)
								{
									continue;
								}
								goto IL_12D7;
							}
						}
						break;
					case 3:
						if (!this.$tObject$18954)
						{
							goto IL_1A7A;
						}
						if (224672 - 477399 != -252727)
						{
							continue;
						}
						if (this.$self_$18960.R1XXZ2M6mT.actionState != "attack")
						{
							goto IL_1A7A;
						}
						if (149998 - 7797 != 142201)
						{
							continue;
						}
						if (this.$self_$18960.R1XXZ2M6mT.myCommand != "nAttack2")
						{
							if (249446 - 198403 != 51044)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$tDir$18956 = global::Math.vFlat(this.$tObject$18954.transform.position - this.$self_$18960.transform.position);
							if (124096 - 206778 != -82682)
							{
								continue;
							}
							if (this.$tDir$18956.magnitude > (float)12)
							{
								if (33144 - 220417 != -187272)
								{
									goto Block_51;
								}
								continue;
							}
							else
							{
								this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_nAttack2(this.$self_$18960.transform.position, this.$tDir$18956, 0));
								if (299310 - 377344 != -78034)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (213612 - 7355 != 206257)
									{
										continue;
									}
									this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_nAttack2", this.$self_$18960.transform.position, this.$tDir$18956, 0);
									if (83957 - 420179 != -336222)
									{
										continue;
									}
								}
								goto IL_19C5;
							}
						}
						break;
					default:
						if (39057 - 208198 != -169141)
						{
							continue;
						}
						break;
					}
					if (Time.time - this.$self_$18960.N2GXMxBwFv >= this.$self_$18960.uEpXfZwvYa)
					{
						if (269156 - 237626 != 31530)
						{
							continue;
						}
						if (Time.time - this.$self_$18960.N2GXMxBwFv < this.$self_$18960.uEpXfZwvYa + this.$mTime$18959)
						{
							if (17365 - 362100 != -344735)
							{
								continue;
							}
							if (!this.$self_$18960.R1XXZ2M6mT.myAttackTarget)
							{
								if (150874 - 6057 != 144817)
								{
									continue;
								}
								this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
								if (177590 - 562495 != -384904)
								{
									break;
								}
								continue;
							}
							else
							{
								this.$tObject$18954 = this.$self_$18960.R1XXZ2M6mT.myAttackTarget;
								if (184063 - 195648 == -11584)
								{
									continue;
								}
								this.$tChar$18955 = (CharacterControl)this.$tObject$18954.GetComponent(typeof(CharacterControl));
								if (134737 - 238863 == -104125)
								{
									continue;
								}
								this.$tDir$18956 = global::Math.vFlat(this.$tObject$18954.transform.position - this.$self_$18960.transform.position);
								if (128733 - 491059 != -362326)
								{
									continue;
								}
								this.$tID$18957 = 0;
								if (260158 - 233840 != 26318)
								{
									continue;
								}
								if (this.$tChar$18955)
								{
									if (74849 - 530502 != -455653)
									{
										continue;
									}
									this.$tID$18957 = this.$tChar$18955.ActorNr;
									if (202759 - 249509 != -46750)
									{
										continue;
									}
								}
								this.$distance$18958 = this.$tDir$18956.magnitude - this.$tObject$18954.collider.bounds.extents.x;
								if (55270 - 396231 == -340960)
								{
									continue;
								}
								if (this.$self_$18960.R1XXZ2M6mT.sp > 55)
								{
									if (190511 - 517011 == -326499)
									{
										continue;
									}
									if (this.$self_$18960.R1XXZ2M6mT.hasSkill(272))
									{
										if (85964 - 237747 == -151782)
										{
											continue;
										}
										if (this.$self_$18960.R1XXZ2M6mT.isTimeOut("timeNuke") == (float)0)
										{
											if (148432 - 557527 == -409094)
											{
												continue;
											}
											this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
											if (92184 - 292848 == -200663)
											{
												continue;
											}
											this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_timeNuke(this.$self_$18960.transform.position, this.$tDir$18956.normalized, 0, 2));
											if (112292 - 153664 != -41372)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (218946 - 263387 != -44441)
												{
													continue;
												}
												this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_timeNuke2", this.$self_$18960.transform.position, this.$tDir$18956.normalized, 0);
												if (43954 - 118209 != -74255)
												{
													continue;
												}
											}
											goto IL_19C5;
										}
									}
								}
								if (this.$self_$18960.R1XXZ2M6mT.sp > 45)
								{
									if (112580 - 174809 == -62228)
									{
										continue;
									}
									if (this.$distance$18958 > (float)2)
									{
										if (178688 - 272791 == -94102)
										{
											continue;
										}
										if (this.$distance$18958 < (float)8)
										{
											if (54754 - 258033 != -203279)
											{
												continue;
											}
											if (this.$self_$18960.R1XXZ2M6mT.hasSkill(243))
											{
												if (248855 - 115784 == 133072)
												{
													continue;
												}
												if (this.$self_$18960.R1XXZ2M6mT.isTimeOut("flameTurret") == (float)0)
												{
													if (37263 - 39952 != -2689)
													{
														continue;
													}
													this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
													if (167396 - 571363 == -403966)
													{
														continue;
													}
													this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_flameTurret(this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957, 2));
													if (184111 - 490148 != -306037)
													{
														continue;
													}
													if (PhotonClient.IsInitialized())
													{
														if (163672 - 470066 == -306393)
														{
															continue;
														}
														this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_flameTurret2", this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957);
														if (268377 - 131977 == 136401)
														{
															continue;
														}
													}
													goto IL_19C5;
												}
											}
										}
									}
								}
								if (this.$self_$18960.R1XXZ2M6mT.sp > 40)
								{
									if (293994 - 3517 != 290477)
									{
										continue;
									}
									if (this.$distance$18958 < (float)12)
									{
										if (156577 - 296357 == -139779)
										{
											continue;
										}
										if (this.$self_$18960.R1XXZ2M6mT.hasSkill(354))
										{
											if (55832 - 180019 == -124186)
											{
												continue;
											}
											if (this.$self_$18960.R1XXZ2M6mT.isTimeOut("missile") == (float)0)
											{
												if (109803 - 203133 != -93330)
												{
													continue;
												}
												this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
												if (85402 - 307001 == -221598)
												{
													continue;
												}
												this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_missile(this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957, 4));
												if (48325 - 233480 != -185155)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (226645 - 36355 == 190291)
													{
														continue;
													}
													this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_missile4", this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957);
													if (34160 - 540421 != -506261)
													{
														continue;
													}
												}
												goto IL_19C5;
											}
										}
									}
								}
								if (this.$self_$18960.R1XXZ2M6mT.sp > 35)
								{
									if (271335 - 471597 != -200262)
									{
										continue;
									}
									if (this.$distance$18958 > (float)6)
									{
										if (47383 - 372936 != -325553)
										{
											continue;
										}
										if (this.$distance$18958 < (float)12)
										{
											if (137608 - 88686 != 48922)
											{
												continue;
											}
											if (this.$self_$18960.R1XXZ2M6mT.hasSkill(234))
											{
												if (146441 - 258778 == -112336)
												{
													continue;
												}
												if (this.$self_$18960.R1XXZ2M6mT.isTimeOut("stunGrenade") == (float)0)
												{
													if (143617 - 418093 != -274476)
													{
														continue;
													}
													this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
													if (133348 - 240777 != -107429)
													{
														continue;
													}
													this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_stunGrenade(this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957, 2));
													if (35679 - 144031 != -108352)
													{
														continue;
													}
													if (PhotonClient.IsInitialized())
													{
														if (62535 - 433799 != -371264)
														{
															continue;
														}
														this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_stunGrenade2", this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957);
														if (8161 - 513794 == -505632)
														{
															continue;
														}
													}
													goto IL_19C5;
												}
											}
										}
									}
								}
								if (this.$self_$18960.R1XXZ2M6mT.sp > 30)
								{
									if (62813 - 327699 != -264886)
									{
										continue;
									}
									if (this.$distance$18958 < (float)7)
									{
										if (296255 - 12324 != 283931)
										{
											continue;
										}
										if (this.$self_$18960.R1XXZ2M6mT.hasSkill(343))
										{
											if (154313 - 33634 == 120680)
											{
												continue;
											}
											if (this.$self_$18960.R1XXZ2M6mT.isTimeOut("chopper") == (float)0)
											{
												if (239877 - 148014 == 91864)
												{
													continue;
												}
												this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
												if (190193 - 528004 != -337811)
												{
													continue;
												}
												this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_chopper(this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957, 3));
												if (278525 - 107000 != 171525)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (156296 - 36371 != 119925)
													{
														continue;
													}
													this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_chopper3", this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957);
													if (216066 - 464164 == -248097)
													{
														continue;
													}
												}
												goto IL_19C5;
											}
										}
									}
								}
								if (this.$self_$18960.R1XXZ2M6mT.sp > 25)
								{
									if (60482 - 335541 != -275059)
									{
										continue;
									}
									if (this.$distance$18958 > (float)14)
									{
										if (122139 - 448577 == -326437)
										{
											continue;
										}
										if (this.$distance$18958 < (float)18)
										{
											if (45233 - 304158 == -258924)
											{
												continue;
											}
											if (this.$self_$18960.R1XXZ2M6mT.hasSkill(224))
											{
												if (41819 - 482862 == -441042)
												{
													continue;
												}
												if (this.$self_$18960.R1XXZ2M6mT.isTimeOut("tnt2") == (float)0)
												{
													if (193048 - 590232 == -397183)
													{
														continue;
													}
													this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
													if (108805 - 59926 == 48880)
													{
														continue;
													}
													this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_tnt(this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957, 2));
													if (136823 - 558108 != -421284)
													{
														if (PhotonClient.IsInitialized())
														{
															if (118317 - 66396 == 51922)
															{
																continue;
															}
															this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_tnt2", this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957);
															if (162337 - 209028 != -46691)
															{
																continue;
															}
														}
														goto IL_19C5;
													}
													continue;
												}
											}
										}
									}
								}
								if (this.$self_$18960.R1XXZ2M6mT.sp > 20)
								{
									if (103684 - 552677 != -448993)
									{
										continue;
									}
									if (this.$distance$18958 < (float)2)
									{
										if (3154 - 323461 != -320307)
										{
											continue;
										}
										if (this.$self_$18960.R1XXZ2M6mT.hasSkill(334))
										{
											if (63649 - 444142 == -380492)
											{
												continue;
											}
											if (this.$self_$18960.R1XXZ2M6mT.isTimeOut("megaHammer") == (float)0)
											{
												if (233634 - 270938 == -37303)
												{
													continue;
												}
												this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
												if (273415 - 516688 != -243273)
												{
													continue;
												}
												this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_megaHammer(this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957, 2));
												if (289339 - 368995 != -79655)
												{
													if (PhotonClient.IsInitialized())
													{
														if (280977 - 75483 != 205494)
														{
															continue;
														}
														this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_megaHammer2", this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957);
														if (27771 - 519802 == -492030)
														{
															continue;
														}
													}
													goto IL_19C5;
												}
												continue;
											}
										}
									}
								}
								if (this.$self_$18960.R1XXZ2M6mT.sp > 15)
								{
									if (240787 - 181300 == 59488)
									{
										continue;
									}
									if (this.$self_$18960.R1XXZ2M6mT.hasSkill(214))
									{
										if (186950 - 354206 != -167256)
										{
											continue;
										}
										if (this.$self_$18960.R1XXZ2M6mT.isTimeOut("mortarShot") == (float)0)
										{
											if (122284 - 472274 == -349989)
											{
												continue;
											}
											this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
											if (211610 - 37899 == 173712)
											{
												continue;
											}
											this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_mortarShot(this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957, 4));
											if (100528 - 285227 != -184699)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (36124 - 30359 == 5766)
												{
													continue;
												}
												this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_mortarShot4", this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957);
												if (294442 - 284580 != 9862)
												{
													continue;
												}
											}
											goto IL_19C5;
										}
									}
								}
								if (this.$self_$18960.R1XXZ2M6mT.sp > 10)
								{
									if (158825 - 268400 != -109575)
									{
										continue;
									}
									if (this.$distance$18958 < (float)2)
									{
										if (294645 - 158348 == 136298)
										{
											continue;
										}
										if (this.$self_$18960.R1XXZ2M6mT.hasSkill(332))
										{
											if (178336 - 40274 == 138063)
											{
												continue;
											}
											if (this.$self_$18960.R1XXZ2M6mT.isTimeOut("megaPunch") == (float)0)
											{
												if (84222 - 409744 == -325521)
												{
													continue;
												}
												this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
												if (49994 - 359984 != -309990)
												{
													continue;
												}
												this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_megaPunch(this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957, 2));
												if (88902 - 101265 != -12363)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (259231 - 296900 == -37668)
													{
														continue;
													}
													this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_megaPunch2", this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957);
													if (28880 - 273791 != -244911)
													{
														continue;
													}
												}
												goto IL_19C5;
											}
										}
									}
								}
								if (this.$self_$18960.R1XXZ2M6mT.sp > 5)
								{
									if (110102 - 231225 == -121122)
									{
										continue;
									}
									if (this.$self_$18960.R1XXZ2M6mT.hasSkill(204))
									{
										if (26151 - 550535 != -524384)
										{
											continue;
										}
										if (this.$self_$18960.R1XXZ2M6mT.isTimeOut("mine") == (float)0)
										{
											if (219892 - 102289 != 117603)
											{
												continue;
											}
											this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
											if (225600 - 212716 != 12884)
											{
												continue;
											}
											this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_mine(this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957, 4));
											if (168851 - 172437 != -3585)
											{
												if (PhotonClient.IsInitialized())
												{
													if (133015 - 188476 == -55460)
													{
														continue;
													}
													this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_mine4", this.$self_$18960.transform.position, this.$tDir$18956.normalized, this.$tID$18957);
													if (194108 - 510265 != -316157)
													{
														continue;
													}
												}
												goto IL_19C5;
											}
											continue;
										}
									}
								}
								if (this.$distance$18958 < (float)2)
								{
									if (245612 - 244057 != 1555)
									{
										continue;
									}
									if (this.$self_$18960.R1XXZ2M6mT.isTimeOut("nAttack") == (float)0)
									{
										if (225864 - 393110 == -167245)
										{
											continue;
										}
										this.$self_$18960.N2GXMxBwFv = Time.time - this.$mTime$18959 - this.$self_$18960.uEpXfZwvYa;
										if (80329 - 232911 != -152582)
										{
											continue;
										}
										this.$self_$18960.JqBXC1fBbl.StartCoroutine_Auto(this.$self_$18960.JqBXC1fBbl.RPC_nAttack1(this.$self_$18960.transform.position, this.$tDir$18956, 0));
										if (263397 - 465879 == -202481)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											goto IL_E7E;
										}
										if (211123 - 274797 != -63674)
										{
											continue;
										}
										this.$self_$18960.JqBXC1fBbl.ActionEvent("RPC_nAttack1", this.$self_$18960.transform.position, this.$tDir$18956, 0);
										if (64495 - 466896 != -402401)
										{
											continue;
										}
										goto IL_E7E;
									}
								}
								this.$self_$18960.AI_state = "attack";
								if (60101 - 193033 != -132932)
								{
									continue;
								}
								this.$self_$18960.R1XXZ2M6mT.vDirection = this.$tObject$18954.transform.position;
								if (182875 - 535684 != -352809)
								{
									continue;
								}
								this.$self_$18960.R1XXZ2M6mT.vDirection.y = this.$self_$18960.transform.position.y;
								if (222891 - 182289 == 40603)
								{
									continue;
								}
								this.$self_$18960.R1XXZ2M6mT.vMovement = (this.$self_$18960.R1XXZ2M6mT.vDirection - this.$self_$18960.transform.position).normalized;
								if (18136 - 100285 != -82149)
								{
									continue;
								}
								this.$self_$18960.transform.rotation = Quaternion.LookRotation(this.$self_$18960.R1XXZ2M6mT.vMovement);
								if (232108 - 56415 == 175694)
								{
									continue;
								}
								this.$self_$18960.R1XXZ2M6mT.actionState = "run";
								if (273821 - 396817 == -122995)
								{
									continue;
								}
								this.$self_$18960.animation.Play("run");
								if (27819 - 427571 == -399751)
								{
									continue;
								}
								this.$self_$18960.animation.wrapMode = WrapMode.Loop;
								if (20586 - 555089 == -534502)
								{
									continue;
								}
								this.$self_$18960.R1XXZ2M6mT.moveSpeed = Mathf.Lerp(this.$self_$18960.R1XXZ2M6mT.moveSpeed, this.$self_$18960.R1XXZ2M6mT.runSpeed, (float)4 * Time.deltaTime);
								if (76905 - 509948 == -433042)
								{
									continue;
								}
							}
						}
					}
					IL_19C5:
					this.$self_$18960.uEpXfZwvYa = this.$self_$18960.uEpXfZwvYa + this.$mTime$18959;
					if (241599 - 332380 == -90781)
					{
						this.YieldDefault(1);
						if (141921 - 540035 == -398114)
						{
							break;
						}
					}
				}
				IL_1B3:
				Block_22:
				Block_51:
				goto IL_1CB7;
				IL_E7E:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_12D7:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_174:
				IL_1A7A:
				IL_1CB7:
				return false;
			}

			// Token: 0x060015A9 RID: 5545 RVA: 0x0022D100 File Offset: 0x0022B300
			internal static bool d9p9IQFHxSNvigyypaU()
			{
				return true;
			}

			// Token: 0x060015AA RID: 5546 RVA: 0x0022D104 File Offset: 0x0022B304
			internal static bool ylAHB7FW9kwD8XaZ59b()
			{
				return false;
			}

			// Token: 0x040012AE RID: 4782
			internal GameObject $tObject$18954;

			// Token: 0x040012AF RID: 4783
			internal CharacterControl $tChar$18955;

			// Token: 0x040012B0 RID: 4784
			internal Vector3 $tDir$18956;

			// Token: 0x040012B1 RID: 4785
			internal int $tID$18957;

			// Token: 0x040012B2 RID: 4786
			internal float $distance$18958;

			// Token: 0x040012B3 RID: 4787
			internal float $mTime$18959;

			// Token: 0x040012B4 RID: 4788
			internal ShadowMole_AI $self_$18960;
		}
	}
}
