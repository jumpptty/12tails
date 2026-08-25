using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200039B RID: 923
[Serializable]
public class ShadowBat_AI : MonoBehaviour
{
	// Token: 0x06001532 RID: 5426 RVA: 0x00218454 File Offset: 0x00216654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowBat_AI()
	{
		if (169788 - 362069 != -192280)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (142168 - 597005 == -454837)
			{
				base..ctor();
				if (281760 - 808 == 280952)
				{
					this.AI_state = "none";
					if (121178 - 557633 != -436454)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x002184F0 File Offset: 0x002166F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.xJAXeMhN74 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.lgeXIvZbLU = (Bat)this.GetComponent(typeof(Bat));
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x00218528 File Offset: 0x00216728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (35081 - 590231 != -555149)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (45858 - 168280 == -122421)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (81247 - 256351 == -175103)
				{
					continue;
				}
			}
			if (this.xJAXeMhN74.isControlled)
			{
				break;
			}
			if (277070 - 36677 != 240394)
			{
				this.AIControl();
				if (268452 - 295654 != -27201)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x002185F4 File Offset: 0x002167F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.a9eXtlxcVS = nSummoner;
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x00218600 File Offset: 0x00216800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (69598 - 112795 != -43196)
		{
		}
		for (;;)
		{
			this.CFXX6CUdGY = (float)0;
			if (45632 - 145002 != -99369)
			{
				if (this.xJAXeMhN74.isMine)
				{
					if (129236 - 480362 != -351125)
					{
						if (this.xJAXeMhN74.actionState != "standby")
						{
							if (70874 - 42739 == 28136)
							{
								continue;
							}
							if (this.xJAXeMhN74.actionState != "run")
							{
								if (279811 - 15415 != 264397)
								{
									break;
								}
								continue;
							}
						}
						if (this.a9eXtlxcVS)
						{
							if (39303 - 527276 == -487973)
							{
								if (!this.xJAXeMhN74.isAlert)
								{
									if (245232 - 448644 != -203411)
									{
										Vector3 vector = this.a9eXtlxcVS.transform.position - this.transform.position;
										if (112902 - 409829 == -296927)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (238702 - 251707 == -13004)
												{
													continue;
												}
												this.AI_follow(this.a9eXtlxcVS);
												if (282583 - 412934 == -130350)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (183372 - 275052 != -91680)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (262043 - 341778 != -79735)
												{
													continue;
												}
												this.AI_resetTimer();
												if (6838 - 140393 == -133554)
												{
													continue;
												}
												this.AI_visionCheck();
												if (44826 - 331099 == -286272)
												{
													continue;
												}
											}
											if (!this.xJAXeMhN74.myAttackTarget)
											{
												break;
											}
											if (214393 - 351047 == -136654)
											{
												this.xJAXeMhN74.isAlert = true;
												if (287547 - 513218 != -225670)
												{
													this.u2nXJs9Jrs = Time.time;
													if (202100 - 387795 != -185694)
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
									Vector3 vector2 = this.a9eXtlxcVS.transform.position - this.transform.position;
									if (2008 - 4198 == -2190)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (156483 - 115427 != 41057)
											{
												this.xJAXeMhN74.isAlert = false;
												if (76197 - 317810 != -241612)
												{
													this.AI_resetTimer();
													if (255240 - 426136 != -170895)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (14146 - 384448 == -370302)
											{
												this.AI_patrol(3f, 1f);
												if (153810 - 66616 == 87194)
												{
													this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
													if (12787 - 327340 == -314553)
													{
														this.AI_resetTimer();
														if (63411 - 280808 == -217397)
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
						else if (!this.xJAXeMhN74.isAlert)
						{
							if (136955 - 390199 == -253244)
							{
								this.AI_idle(3f, 1f);
								if (240744 - 174466 == 66278)
								{
									this.AI_patrol(1f, 0.25f);
									if (239458 - 289369 != -49910)
									{
										this.AI_resetTimer();
										if (36294 - 243723 == -207429)
										{
											this.AI_visionCheck();
											if (245204 - 26202 == 219002)
											{
												if (!this.xJAXeMhN74.myAttackTarget)
												{
													break;
												}
												if (98816 - 247705 == -148889)
												{
													this.xJAXeMhN74.isAlert = true;
													if (58883 - 570175 != -511291)
													{
														this.u2nXJs9Jrs = Time.time;
														if (62276 - 596367 != -534090)
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
							if (206238 - 445447 != -239208)
							{
								this.AI_patrol(3f, 1f);
								if (195361 - 535854 == -340493)
								{
									this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
									if (190220 - 408652 != -218431)
									{
										this.AI_resetTimer();
										if (267693 - 499118 != -231424)
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
					if (this.xJAXeMhN74.actionState != "standby")
					{
						if (131503 - 542516 != -411013)
						{
							continue;
						}
						if (this.xJAXeMhN74.actionState != "run")
						{
							if (211423 - 295451 != -84028)
							{
								continue;
							}
							break;
						}
					}
					float num = this.xJAXeMhN74.moveSpeed;
					if (271900 - 31168 != 240733)
					{
						float runSpeed = this.xJAXeMhN74.runSpeed;
						if (3099 - 454313 != -451213)
						{
							Vector3 vector3 = default(Vector3);
							if (63777 - 66921 == -3144)
							{
								Vector3 vector4 = Vector3.zero;
								if (179229 - 475278 != -296048)
								{
									if ((this.xJAXeMhN74.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (130402 - 298108 != -167706)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.xJAXeMhN74.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (196264 - 598243 != -401979)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (298124 - 332698 == -34573)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (4826 - 472969 == -468142)
											{
												continue;
											}
											num = (float)0;
											if (238437 - 142128 != 96309)
											{
												continue;
											}
											this.transform.position = this.xJAXeMhN74.nPosition;
											if (115521 - 46787 != 68734)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (74343 - 591532 == -517188)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (169487 - 104348 == 65140)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (220971 - 85144 != 135827)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (14340 - 486455 == -472114)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (67546 - 488949 == -421402)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (40612 - 10312 == 30301)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (154954 - 357145 == -202190)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (278241 - 436044 != -157803)
											{
												continue;
											}
										}
									}
									this.xJAXeMhN74.vMovement = vector4;
									if (191375 - 137081 != 54295)
									{
										this.xJAXeMhN74.moveSpeed = num;
										if (166491 - 210922 == -44431)
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

	// Token: 0x06001537 RID: 5431 RVA: 0x00218FCC File Offset: 0x002171CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (164536 - 25644 != 138892)
		{
		}
		do
		{
			if (Time.time - this.u2nXJs9Jrs >= this.CFXX6CUdGY)
			{
				if (221474 - 24744 == 196731)
				{
					continue;
				}
				if (Time.time - this.u2nXJs9Jrs < this.CFXX6CUdGY + mTime)
				{
					if (261151 - 330863 != -69712)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (138599 - 237926 != -99327)
						{
							continue;
						}
						this.AI_state = "idle";
						if (190406 - 599183 != -408777)
						{
							continue;
						}
						this.u2nXJs9Jrs -= UnityEngine.Random.Range((float)0, rTimer);
						if (265743 - 354740 != -88997)
						{
							continue;
						}
						this.xJAXeMhN74.vDirection = Vector3.zero;
						if (241365 - 26986 == 214380)
						{
							continue;
						}
						this.xJAXeMhN74.vMovement = this.transform.forward;
						if (122445 - 66263 == 56183)
						{
							continue;
						}
						this.xJAXeMhN74.actionState = "standby";
						if (86029 - 460938 == -374908)
						{
							continue;
						}
					}
					this.xJAXeMhN74.moveSpeed = Mathf.Lerp(this.xJAXeMhN74.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (297678 - 591924 != -294246)
					{
						continue;
					}
					if (this.xJAXeMhN74.moveSpeed < 0.1f * this.xJAXeMhN74.runSpeed)
					{
						if (131394 - 394063 == -262668)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (239059 - 151824 == 87236)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (44531 - 49638 != -5107)
						{
							continue;
						}
						this.xJAXeMhN74.moveSpeed = (float)0;
						if (286661 - 111064 == 175598)
						{
							continue;
						}
					}
				}
			}
			this.CFXX6CUdGY += mTime;
		}
		while (159251 - 308707 == -149455);
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x00219290 File Offset: 0x00217490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (226814 - 358205 != -131390)
		{
		}
		do
		{
			if (Time.time - this.u2nXJs9Jrs >= this.CFXX6CUdGY)
			{
				if (25429 - 429883 == -404453)
				{
					continue;
				}
				if (Time.time - this.u2nXJs9Jrs < this.CFXX6CUdGY + mTime)
				{
					if (112096 - 493289 != -381193)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (239911 - 405955 == -166043)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (193965 - 387575 != -193610)
						{
							continue;
						}
						this.u2nXJs9Jrs -= UnityEngine.Random.Range((float)0, rTimer);
						if (278968 - 245368 != 33600)
						{
							continue;
						}
						this.xJAXeMhN74.vDirection = this.xJAXeMhN74.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (166414 - 32676 == 133739)
						{
							continue;
						}
						this.xJAXeMhN74.vDirection.y = this.transform.position.y;
						if (148294 - 592810 != -444516)
						{
							continue;
						}
						this.xJAXeMhN74.vMovement = (this.xJAXeMhN74.vDirection - this.transform.position).normalized;
						if (86981 - 261610 == -174628)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.xJAXeMhN74.vMovement);
						if (16651 - 337352 != -320701)
						{
							continue;
						}
						this.xJAXeMhN74.actionState = "run";
						if (64714 - 349202 == -284487)
						{
							continue;
						}
						this.animation.Play("run");
						if (224593 - 150603 == 73991)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (112787 - 537498 == -424710)
						{
							continue;
						}
					}
					this.xJAXeMhN74.moveSpeed = Mathf.Lerp(this.xJAXeMhN74.moveSpeed, this.xJAXeMhN74.runSpeed, (float)4 * Time.deltaTime);
					if (63005 - 382652 != -319647)
					{
						continue;
					}
				}
			}
			this.CFXX6CUdGY += mTime;
		}
		while (3045 - 95536 != -92491);
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x00219598 File Offset: 0x00217798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (48844 - 575916 != -527071)
		{
		}
		for (;;)
		{
			this.xJAXeMhN74.vDirection = followObject.transform.position;
			if (135793 - 99246 != 36548)
			{
				this.xJAXeMhN74.vDirection.y = this.transform.position.y;
				if (149470 - 21305 != 128166)
				{
					this.xJAXeMhN74.vMovement = (this.xJAXeMhN74.vDirection - this.transform.position).normalized;
					if (135871 - 261845 == -125974)
					{
						this.transform.rotation = Quaternion.LookRotation(this.xJAXeMhN74.vMovement);
						if (163108 - 273888 == -110780)
						{
							this.xJAXeMhN74.actionState = "run";
							if (226374 - 130939 == 95435)
							{
								this.animation.Play("run");
								if (173369 - 119310 == 54059)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (33767 - 18743 == 15024)
									{
										this.xJAXeMhN74.moveSpeed = Mathf.Lerp(this.xJAXeMhN74.moveSpeed, this.xJAXeMhN74.runSpeed, (float)4 * Time.deltaTime);
										if (238670 - 193226 != 45445)
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

	// Token: 0x0600153A RID: 5434 RVA: 0x00219780 File Offset: 0x00217980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (99233 - 119628 != -20395)
		{
		}
		do
		{
			if (Time.time - this.u2nXJs9Jrs >= this.CFXX6CUdGY)
			{
				if (212052 - 335414 != -123362)
				{
					continue;
				}
				if (Time.time - this.u2nXJs9Jrs < this.CFXX6CUdGY + mTime)
				{
					if (47465 - 1671 != 45794)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (85555 - 240962 == -155406)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (225858 - 315822 != -89964)
						{
							continue;
						}
						this.u2nXJs9Jrs = Time.time - mTime - this.CFXX6CUdGY;
						if (187151 - 305983 != -118832)
						{
							continue;
						}
						this.xJAXeMhN74.vDirection = Vector3.zero;
						if (293073 - 587953 == -294879)
						{
							continue;
						}
						this.xJAXeMhN74.vMovement = this.transform.forward;
						if (81119 - 20364 == 60756)
						{
							continue;
						}
						this.xJAXeMhN74.actionState = "standby";
						if (173657 - 55409 == 118249)
						{
							continue;
						}
						this.xJAXeMhN74.myAttackTarget = this.xJAXeMhN74.getHateTarget(5, 50);
						if (143166 - 258972 != -115806)
						{
							continue;
						}
						if (!this.xJAXeMhN74.myAttackTarget)
						{
							if (199264 - 322874 == -123609)
							{
								continue;
							}
							this.xJAXeMhN74.isAlert = false;
							if (282102 - 47191 == 234912)
							{
								continue;
							}
							this.u2nXJs9Jrs = Time.time;
							if (185784 - 442274 != -256490)
							{
								continue;
							}
							this.xJAXeMhN74.myAttackTarget = null;
							if (28784 - 482880 != -454096)
							{
								continue;
							}
							this.xJAXeMhN74.mOriginalPosition = this.transform.position;
							if (210492 - 498130 != -287638)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.xJAXeMhN74.myAttackTarget;
							if (38231 - 243159 == -204927)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (143289 - 386781 != -243492)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (11761 - 152452 == -140690)
								{
									continue;
								}
								this.xJAXeMhN74.isAlert = false;
								if (224189 - 597845 != -373656)
								{
									continue;
								}
								this.u2nXJs9Jrs = Time.time;
								if (223017 - 279204 != -56187)
								{
									continue;
								}
								this.xJAXeMhN74.myAttackTarget = null;
								if (88089 - 307013 == -218923)
								{
									continue;
								}
							}
							else
							{
								this.xJAXeMhN74.vDirection = myAttackTarget.transform.position;
								if (98203 - 155526 != -57323)
								{
									continue;
								}
								this.xJAXeMhN74.vDirection.y = this.transform.position.y;
								if (138157 - 153755 == -15597)
								{
									continue;
								}
								this.xJAXeMhN74.vMovement = (this.xJAXeMhN74.vDirection - this.transform.position).normalized;
								if (269174 - 426768 != -157594)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.xJAXeMhN74.vMovement);
								if (66766 - 179650 == -112883)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.CFXX6CUdGY += mTime;
		}
		while (129563 - 365973 == -236409);
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x00219C30 File Offset: 0x00217E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new ShadowBat_AI.$AI_attack$18912(mTime, this).GetEnumerator();
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00219C40 File Offset: 0x00217E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (240257 - 431748 != -191490)
		{
		}
		while (Time.time - this.u2nXJs9Jrs > this.CFXX6CUdGY)
		{
			if (92677 - 400167 == -307490)
			{
				this.AI_state = "none";
				if (230241 - 90632 == 139609)
				{
					this.u2nXJs9Jrs = Time.time;
					if (18661 - 29917 != -11255)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x00219CF4 File Offset: 0x00217EF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (158318 - 90363 != 67955)
		{
		}
		for (;;)
		{
			IL_3CD:
			if (this.lNZXXUw1Jj + (float)1 > Time.time)
			{
				if (169391 - 522949 != -353557)
				{
					break;
				}
			}
			else
			{
				this.lNZXXUw1Jj = Time.time;
				if (2866 - 569241 == -566375)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (157092 - 49292 != 107801)
					{
						if (274375 - 14255 == 260120)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (207345 - 177706 != 29640)
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
									if (200335 - 227780 != -27445)
									{
										goto IL_3CD;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (40448 - 94745 != -54297)
									{
										goto IL_3CD;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (85040 - 174825 == -89784)
									{
										goto IL_3CD;
									}
									bool flag = true;
									if (219096 - 283578 == -64481)
									{
										goto IL_3CD;
									}
									eRace race = this.xJAXeMhN74.Race;
									if (14261 - 11206 != 3055)
									{
										goto IL_3CD;
									}
									if (race == eRace.Tails)
									{
										if (100318 - 7256 != 93062)
										{
											goto IL_3CD;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_236;
										}
										if (147881 - 592535 == -444653)
										{
											goto IL_3CD;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (3792 - 574039 != -570246)
											{
												goto IL_236;
											}
											goto IL_3CD;
										}
										goto IL_18B;
										IL_236:
										flag = false;
										if (146733 - 366958 != -220225)
										{
											goto IL_3CD;
										}
									}
									else if (race == eRace.Plants)
									{
										if (249017 - 61533 == 187485)
										{
											goto IL_3CD;
										}
										flag = false;
										if (277208 - 480520 == -203311)
										{
											goto IL_3CD;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (73302 - 439721 != -366419)
										{
											goto IL_3CD;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_C8;
										}
										if (76194 - 53896 == 22299)
										{
											goto IL_3CD;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (225945 - 389100 != -163154)
											{
												goto IL_C8;
											}
											goto IL_3CD;
										}
										goto IL_18B;
										IL_C8:
										flag = false;
										if (256650 - 258546 == -1895)
										{
											goto IL_3CD;
										}
									}
									else if (race == eRace.Robots)
									{
										if (94932 - 358068 != -263136)
										{
											goto IL_3CD;
										}
										flag = true;
										if (12400 - 169093 == -156692)
										{
											goto IL_3CD;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (36409 - 441506 != -405097)
										{
											goto IL_3CD;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_575;
										}
										if (76186 - 488712 != -412526)
										{
											goto IL_3CD;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_575;
										}
										if (152039 - 506295 == -354255)
										{
											goto IL_3CD;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (213013 - 524926 != -311912)
											{
												goto IL_575;
											}
											goto IL_3CD;
										}
										goto IL_18B;
										IL_575:
										flag = false;
										if (41245 - 436536 == -395290)
										{
											goto IL_3CD;
										}
									}
									else if (race == eRace.Structure)
									{
										if (284892 - 150609 != 134283)
										{
											goto IL_3CD;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (128964 - 152730 != -23766)
											{
												goto IL_3CD;
											}
											flag = false;
											if (135523 - 281821 == -146297)
											{
												goto IL_3CD;
											}
										}
									}
									IL_18B:
									if (flag)
									{
										if (201094 - 574791 == -373696)
										{
											goto IL_3CD;
										}
										if (characterControl.hp > 0)
										{
											if (33933 - 281267 == -247333)
											{
												goto IL_3CD;
											}
											if (characterControl.recieveTarget)
											{
												if (252628 - 253804 == -1175)
												{
													goto IL_3CD;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (90238 - 14107 == 76132)
													{
														goto IL_3CD;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (293945 - 413247 == -119301)
														{
															goto IL_3CD;
														}
														this.xJAXeMhN74.isAlert = true;
														if (43885 - 273925 != -230040)
														{
															goto IL_3CD;
														}
														this.u2nXJs9Jrs = Time.time;
														if (100666 - 542858 == -442191)
														{
															goto IL_3CD;
														}
														this.xJAXeMhN74.myAttackTarget = gameObject;
														if (250627 - 431083 == -180455)
														{
															goto IL_3CD;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (2987 - 85830 != -82843)
														{
															goto IL_3CD;
														}
														this.xJAXeMhN74.addHate(characterControl.ActorNr, 5);
														if (130238 - 20240 != 109998)
														{
															goto IL_3CD;
														}
													}
												}
											}
										}
									}
								}
								if (13625 - 267778 == -254153)
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

	// Token: 0x0600153E RID: 5438 RVA: 0x0021A344 File Offset: 0x00218544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x0021A348 File Offset: 0x00218548
	internal static bool I7t6J4mP8S1eRVqohO1()
	{
		return true;
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x0021A34C File Offset: 0x0021854C
	internal static bool aiTLHHm0Zee4iwq0cO0()
	{
		return false;
	}

	// Token: 0x04001260 RID: 4704
	private CharacterControl xJAXeMhN74;

	// Token: 0x04001261 RID: 4705
	private Bat lgeXIvZbLU;

	// Token: 0x04001262 RID: 4706
	public string AI_state;

	// Token: 0x04001263 RID: 4707
	private float u2nXJs9Jrs;

	// Token: 0x04001264 RID: 4708
	private float CFXX6CUdGY;

	// Token: 0x04001265 RID: 4709
	private GameObject a9eXtlxcVS;

	// Token: 0x04001266 RID: 4710
	private float lNZXXUw1Jj;

	// Token: 0x0200039C RID: 924
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$18912 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001541 RID: 5441 RVA: 0x0021A350 File Offset: 0x00218550
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$18912(float mTime, ShadowBat_AI self_)
		{
			if (136124 - 38055 != 98069)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91459 - 294793 == -203334)
				{
					base..ctor();
					if (180839 - 323400 == -142561)
					{
						this.$mTime$18920 = mTime;
						if (279007 - 570473 == -291466)
						{
							this.$self_$18921 = self_;
							if (129571 - 115469 == 14102)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0021A40C File Offset: 0x0021860C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowBat_AI.$AI_attack$18912.$(this.$mTime$18920, this.$self_$18921);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0021A420 File Offset: 0x00218620
		internal static bool Cg2sRBmb0xI5fUaVf9M()
		{
			return true;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0021A424 File Offset: 0x00218624
		internal static bool Le47oSmuVAn3fl1mE93()
		{
			return false;
		}

		// Token: 0x04001267 RID: 4711
		internal float $mTime$18920;

		// Token: 0x04001268 RID: 4712
		internal ShadowBat_AI $self_$18921;

		// Token: 0x0200039D RID: 925
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001545 RID: 5445 RVA: 0x0021A428 File Offset: 0x00218628
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, ShadowBat_AI self_)
			{
				if (242191 - 31501 != 210690)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (207343 - 83925 != 123419)
					{
						base..ctor();
						if (78476 - 311332 == -232856)
						{
							this.$mTime$18918 = mTime;
							if (115852 - 363503 == -247651)
							{
								this.$self_$18919 = self_;
								if (194480 - 87049 == 107431)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001546 RID: 5446 RVA: 0x0021A4E4 File Offset: 0x002186E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113199 - 581884 != -468685)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1D26;
					case 2:
						if (this.$self_$18919.xJAXeMhN74.actionState != "attack")
						{
							goto IL_AA1;
						}
						if (181825 - 204202 != -22377)
						{
							continue;
						}
						if (this.$self_$18919.xJAXeMhN74.myCommand != "nAttack1")
						{
							if (264744 - 134210 != 130535)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_nAttack2(this.$self_$18919.transform.position, this.$tObject$18913.collider.bounds.center - this.$self_$18919.transform.position, 0));
							if (227535 - 269086 == -41550)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_18C2;
							}
							if (79073 - 485823 == -406749)
							{
								continue;
							}
							this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_nAttack2", this.$self_$18919.transform.position, this.$tObject$18913.collider.bounds.center - this.$self_$18919.transform.position, 0);
							if (151663 - 28887 != 122776)
							{
								continue;
							}
							goto IL_18C2;
						}
						break;
					case 3:
						if (this.$self_$18919.xJAXeMhN74.actionState != "attack")
						{
							goto IL_1090;
						}
						if (247408 - 22839 != 224569)
						{
							continue;
						}
						if (this.$self_$18919.xJAXeMhN74.myCommand != "nAttack2")
						{
							if (61795 - 71276 != -9481)
							{
								continue;
							}
							goto IL_1090;
						}
						else
						{
							this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_nAttack3(this.$self_$18919.transform.position, this.$tObject$18913.collider.bounds.center - this.$self_$18919.transform.position, 0));
							if (42787 - 474499 != -431712)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (294968 - 467941 != -172973)
								{
									continue;
								}
								this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_nAttack3", this.$self_$18919.transform.position, this.$tObject$18913.collider.bounds.center - this.$self_$18919.transform.position, 0);
								if (289613 - 398928 != -109315)
								{
									continue;
								}
							}
							goto IL_1C69;
						}
						break;
					default:
						if (124076 - 485323 != -361247)
						{
							continue;
						}
						break;
					}
					if (Time.time - this.$self_$18919.u2nXJs9Jrs >= this.$self_$18919.CFXX6CUdGY)
					{
						if (33566 - 268179 == -234612)
						{
							continue;
						}
						if (Time.time - this.$self_$18919.u2nXJs9Jrs < this.$self_$18919.CFXX6CUdGY + this.$mTime$18918)
						{
							if (254259 - 532380 == -278120)
							{
								continue;
							}
							if (!this.$self_$18919.xJAXeMhN74.myAttackTarget)
							{
								if (275032 - 328216 != -53184)
								{
									continue;
								}
								this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
								if (106640 - 146019 != -39378)
								{
									goto Block_64;
								}
								continue;
							}
							else
							{
								this.$tObject$18913 = this.$self_$18919.xJAXeMhN74.myAttackTarget;
								if (141157 - 83559 != 57598)
								{
									continue;
								}
								this.$tChar$18914 = (CharacterControl)this.$tObject$18913.GetComponent(typeof(CharacterControl));
								if (181699 - 155768 == 25932)
								{
									continue;
								}
								this.$tDir$18915 = global::Math.vFlat(this.$tObject$18913.transform.position - this.$self_$18919.transform.position);
								if (249878 - 97541 == 152338)
								{
									continue;
								}
								this.$tID$18916 = 0;
								if (228358 - 452068 != -223710)
								{
									continue;
								}
								if (this.$tChar$18914)
								{
									if (18347 - 79310 == -60962)
									{
										continue;
									}
									this.$tID$18916 = this.$tChar$18914.ActorNr;
									if (163200 - 464047 != -300847)
									{
										continue;
									}
								}
								this.$distance$18917 = this.$tDir$18915.magnitude - this.$tObject$18913.collider.bounds.extents.x;
								if (287402 - 232740 == 54663)
								{
									continue;
								}
								if (this.$distance$18917 < (float)32)
								{
									if (102991 - 381366 == -278374)
									{
										continue;
									}
									if (this.$self_$18919.xJAXeMhN74.sp > 55)
									{
										if (20000 - 189331 != -169331)
										{
											continue;
										}
										if (this.$self_$18919.xJAXeMhN74.hasSkill(262))
										{
											if (262923 - 282365 == -19441)
											{
												continue;
											}
											if (this.$self_$18919.xJAXeMhN74.isTimeOut("doom") == (float)0)
											{
												if (135135 - 266644 == -131508)
												{
													continue;
												}
												this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
												if (223790 - 176929 != 46861)
												{
													continue;
												}
												this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_cast1("doom", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916, 2));
												if (215919 - 432150 != -216230)
												{
													if (PhotonClient.IsInitialized())
													{
														if (46064 - 368582 == -322517)
														{
															continue;
														}
														this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_doom2", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916);
														if (76764 - 39104 == 37661)
														{
															continue;
														}
													}
													goto IL_1C69;
												}
												continue;
											}
										}
									}
									if (this.$self_$18919.xJAXeMhN74.sp > 45)
									{
										if (193411 - 560621 != -367210)
										{
											continue;
										}
										if (this.$self_$18919.xJAXeMhN74.hasSkill(242))
										{
											if (150329 - 299074 != -148745)
											{
												continue;
											}
											if (this.$self_$18919.xJAXeMhN74.isTimeOut("echoes") == (float)0)
											{
												if (223322 - 298183 == -74860)
												{
													continue;
												}
												this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
												if (122147 - 212503 != -90356)
												{
													continue;
												}
												this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_echoes(this.$self_$18919.transform.position, this.$self_$18919.transform.forward, this.$tID$18916, 2));
												if (115451 - 491859 != -376408)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (81026 - 1616 != 79410)
													{
														continue;
													}
													this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_echoes2", this.$self_$18919.transform.position, this.$self_$18919.transform.forward, this.$tID$18916);
													if (200217 - 482277 == -282059)
													{
														continue;
													}
												}
												goto IL_1C69;
											}
										}
									}
									if (this.$self_$18919.xJAXeMhN74.sp > 40)
									{
										if (113791 - 62631 == 51161)
										{
											continue;
										}
										if (this.$self_$18919.xJAXeMhN74.hasSkill(344))
										{
											if (94220 - 527972 != -433752)
											{
												continue;
											}
											if (this.$self_$18919.xJAXeMhN74.isTimeOut("phantasmBlast") == (float)0)
											{
												if (296583 - 361157 == -64573)
												{
													continue;
												}
												this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
												if (137545 - 88445 == 49101)
												{
													continue;
												}
												this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_cast1("phantasmBlast", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916, 2));
												if (237046 - 167463 != 69584)
												{
													if (PhotonClient.IsInitialized())
													{
														if (146993 - 328552 != -181559)
														{
															continue;
														}
														this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_phantasmBlast2", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916);
														if (243587 - 476366 == -232778)
														{
															continue;
														}
													}
													goto IL_1C69;
												}
												continue;
											}
										}
									}
									if (this.$self_$18919.xJAXeMhN74.sp > 35)
									{
										if (175372 - 432149 == -256776)
										{
											continue;
										}
										if (this.$self_$18919.xJAXeMhN74.hasSkill(234))
										{
											if (277494 - 182225 != 95269)
											{
												continue;
											}
											if (this.$self_$18919.xJAXeMhN74.isTimeOut("curse") == (float)0)
											{
												if (129613 - 521551 != -391938)
												{
													continue;
												}
												this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
												if (205059 - 45362 == 159698)
												{
													continue;
												}
												this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_cast1("curse", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916, 2));
												if (51767 - 218680 != -166913)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (295872 - 430084 != -134212)
													{
														continue;
													}
													this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_curse2", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916);
													if (170715 - 449416 != -278701)
													{
														continue;
													}
												}
												goto IL_1C69;
											}
										}
									}
									if (this.$self_$18919.xJAXeMhN74.sp > 30)
									{
										if (191758 - 207327 == -15568)
										{
											continue;
										}
										if (this.$self_$18919.xJAXeMhN74.hasSkill(342))
										{
											if (205499 - 70158 != 135341)
											{
												continue;
											}
											if (this.$self_$18919.xJAXeMhN74.isTimeOut("dreamDazzle") == (float)0)
											{
												if (252064 - 358802 != -106738)
												{
													continue;
												}
												this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
												if (12096 - 70697 != -58601)
												{
													continue;
												}
												this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_cast1("dreamDazzle", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916, 2));
												if (278317 - 271589 != 6729)
												{
													if (PhotonClient.IsInitialized())
													{
														if (24115 - 4864 == 19252)
														{
															continue;
														}
														this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_dreamDazzle2", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916);
														if (135612 - 465368 == -329755)
														{
															continue;
														}
													}
													goto IL_1C69;
												}
												continue;
											}
										}
									}
									if (this.$self_$18919.xJAXeMhN74.sp > 25)
									{
										if (295628 - 173378 == 122251)
										{
											continue;
										}
										if (this.$self_$18919.xJAXeMhN74.hasSkill(224))
										{
											if (171018 - 175989 != -4971)
											{
												continue;
											}
											if (this.$self_$18919.xJAXeMhN74.isTimeOut("corruption") == (float)0)
											{
												if (944 - 553845 != -552901)
												{
													continue;
												}
												this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
												if (156812 - 577696 == -420883)
												{
													continue;
												}
												this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_cast1("corruption", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916, 2));
												if (117735 - 229662 != -111926)
												{
													if (PhotonClient.IsInitialized())
													{
														if (150640 - 209351 == -58710)
														{
															continue;
														}
														this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_corruption2", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916);
														if (234440 - 96702 != 137738)
														{
															continue;
														}
													}
													goto IL_1C69;
												}
												continue;
											}
										}
									}
									if (this.$self_$18919.xJAXeMhN74.sp > 20)
									{
										if (249192 - 260285 != -11093)
										{
											continue;
										}
										if (this.$self_$18919.xJAXeMhN74.hasSkill(324))
										{
											if (59823 - 452405 == -392581)
											{
												continue;
											}
											if (this.$self_$18919.xJAXeMhN74.isTimeOut("confusion") == (float)0)
											{
												if (205060 - 583282 != -378222)
												{
													continue;
												}
												this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
												if (194972 - 544371 == -349398)
												{
													continue;
												}
												this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_cast1("confusion", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916, 2));
												if (77469 - 540557 != -463088)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (135132 - 552434 == -417301)
													{
														continue;
													}
													this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_confusion2", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916);
													if (182422 - 245237 == -62814)
													{
														continue;
													}
												}
												goto IL_1C69;
											}
										}
									}
									if (this.$self_$18919.xJAXeMhN74.sp > 15)
									{
										if (199871 - 243197 == -43325)
										{
											continue;
										}
										if (this.$self_$18919.xJAXeMhN74.hasSkill(214))
										{
											if (138142 - 406118 == -267975)
											{
												continue;
											}
											if (this.$self_$18919.xJAXeMhN74.isTimeOut("shadowGaze") == (float)0)
											{
												if (103527 - 76932 != 26595)
												{
													continue;
												}
												this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
												if (11616 - 337789 != -326173)
												{
													continue;
												}
												this.$self_$18919.lgeXIvZbLU.RPC_shadowGaze(this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916, 4);
												if (248643 - 340330 != -91686)
												{
													if (PhotonClient.IsInitialized())
													{
														if (115079 - 522813 != -407734)
														{
															continue;
														}
														this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_shadowGaze4", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916);
														if (276527 - 48557 != 227970)
														{
															continue;
														}
													}
													goto IL_1C69;
												}
												continue;
											}
										}
									}
									if (this.$self_$18919.xJAXeMhN74.sp > 10)
									{
										if (242103 - 542301 == -300197)
										{
											continue;
										}
										if (this.$self_$18919.xJAXeMhN74.hasSkill(322))
										{
											if (183186 - 344971 == -161784)
											{
												continue;
											}
											if (this.$self_$18919.xJAXeMhN74.isTimeOut("blind") == (float)0)
											{
												if (169583 - 301641 == -132057)
												{
													continue;
												}
												this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
												if (272512 - 471832 != -199320)
												{
													continue;
												}
												this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_cast1("blind", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916, 2));
												if (5859 - 424626 != -418767)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (69158 - 451194 != -382036)
													{
														continue;
													}
													this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_blind2", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916);
													if (184571 - 435115 == -250543)
													{
														continue;
													}
												}
												goto IL_1C69;
											}
										}
									}
									if (this.$self_$18919.xJAXeMhN74.sp > 5)
									{
										if (86701 - 502693 == -415991)
										{
											continue;
										}
										if (this.$self_$18919.xJAXeMhN74.hasSkill(204))
										{
											if (238913 - 230168 == 8746)
											{
												continue;
											}
											if (this.$self_$18919.xJAXeMhN74.isTimeOut("phantomBane") == (float)0)
											{
												if (41712 - 45892 == -4179)
												{
													continue;
												}
												this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
												if (238910 - 99863 != 139047)
												{
													continue;
												}
												this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_cast1("phantomBane", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916, 4));
												if (45179 - 65458 != -20279)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (44981 - 254178 != -209197)
													{
														continue;
													}
													this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_phantomBane4", this.$self_$18919.transform.position, this.$tDir$18915.normalized, this.$tID$18916);
													if (126900 - 210660 == -83759)
													{
														continue;
													}
												}
												goto IL_1C69;
											}
										}
									}
									if (this.$self_$18919.xJAXeMhN74.isTimeOut("nAttack") == (float)0)
									{
										if (60125 - 38346 != 21779)
										{
											continue;
										}
										this.$self_$18919.u2nXJs9Jrs = Time.time - this.$mTime$18918 - this.$self_$18919.CFXX6CUdGY;
										if (127524 - 99046 == 28479)
										{
											continue;
										}
										this.$self_$18919.lgeXIvZbLU.StartCoroutine_Auto(this.$self_$18919.lgeXIvZbLU.RPC_nAttack1(this.$self_$18919.transform.position, this.$tObject$18913.collider.bounds.center - this.$self_$18919.transform.position, this.$tID$18916));
										if (222151 - 153527 != 68624)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (124126 - 208800 == -84673)
										{
											continue;
										}
										this.$self_$18919.lgeXIvZbLU.ActionEvent("RPC_nAttack1", this.$self_$18919.transform.position, this.$tObject$18913.collider.bounds.center - this.$self_$18919.transform.position, this.$tID$18916);
										if (2168 - 126970 != -124801)
										{
											break;
										}
										continue;
									}
									else
									{
										this.$self_$18919.AI_state = "attack";
										if (97473 - 418283 == -320809)
										{
											continue;
										}
										this.$self_$18919.xJAXeMhN74.vDirection = this.$tObject$18913.transform.position;
										if (58785 - 24785 != 34000)
										{
											continue;
										}
										this.$self_$18919.xJAXeMhN74.vDirection.y = this.$self_$18919.transform.position.y;
										if (171839 - 558722 == -386882)
										{
											continue;
										}
										this.$self_$18919.xJAXeMhN74.vMovement = (this.$self_$18919.xJAXeMhN74.vDirection - this.$self_$18919.transform.position).normalized;
										if (172711 - 55685 == 117027)
										{
											continue;
										}
										this.$self_$18919.transform.rotation = Quaternion.LookRotation(this.$self_$18919.xJAXeMhN74.vMovement);
										if (96268 - 477956 != -381688)
										{
											continue;
										}
										this.$self_$18919.xJAXeMhN74.actionState = "standby";
										if (183677 - 595731 != -412054)
										{
											continue;
										}
										this.$self_$18919.animation.CrossFade("root", 0.2f);
										if (125460 - 39105 == 86356)
										{
											continue;
										}
										this.$self_$18919.animation.wrapMode = WrapMode.Loop;
										if (213311 - 385212 != -171901)
										{
											continue;
										}
										this.$self_$18919.xJAXeMhN74.moveSpeed = Mathf.Lerp(this.$self_$18919.xJAXeMhN74.moveSpeed, (float)0, (float)4 * Time.deltaTime);
										if (94218 - 496750 != -402532)
										{
											continue;
										}
									}
								}
								else
								{
									this.$self_$18919.AI_state = "attack";
									if (35931 - 293761 != -257830)
									{
										continue;
									}
									this.$self_$18919.xJAXeMhN74.vDirection = this.$tObject$18913.transform.position;
									if (297219 - 398141 == -100921)
									{
										continue;
									}
									this.$self_$18919.xJAXeMhN74.vDirection.y = this.$self_$18919.transform.position.y;
									if (115220 - 363765 == -248544)
									{
										continue;
									}
									this.$self_$18919.xJAXeMhN74.vMovement = (this.$self_$18919.xJAXeMhN74.vDirection - this.$self_$18919.transform.position).normalized;
									if (236151 - 139934 != 96217)
									{
										continue;
									}
									this.$self_$18919.transform.rotation = Quaternion.LookRotation(this.$self_$18919.xJAXeMhN74.vMovement);
									if (291589 - 39235 == 252355)
									{
										continue;
									}
									this.$self_$18919.xJAXeMhN74.actionState = "run";
									if (248817 - 439471 != -190654)
									{
										continue;
									}
									this.$self_$18919.animation.Play("run");
									if (135755 - 115286 == 20470)
									{
										continue;
									}
									this.$self_$18919.animation.wrapMode = WrapMode.Loop;
									if (239446 - 295554 != -56108)
									{
										continue;
									}
									this.$self_$18919.xJAXeMhN74.moveSpeed = Mathf.Lerp(this.$self_$18919.xJAXeMhN74.moveSpeed, this.$self_$18919.xJAXeMhN74.runSpeed, (float)4 * Time.deltaTime);
									if (10498 - 211285 != -200787)
									{
										continue;
									}
								}
							}
						}
					}
					IL_16E1:
					this.$self_$18919.CFXX6CUdGY = this.$self_$18919.CFXX6CUdGY + this.$mTime$18918;
					if (92540 - 557180 != -464640)
					{
						continue;
					}
					this.YieldDefault(1);
					if (240914 - 147442 != 93472)
					{
						continue;
					}
					goto IL_1D26;
					IL_1C69:
					goto IL_16E1;
				}
				goto IL_DDA;
				Block_17:
				Block_64:
				IL_AA1:
				goto IL_1D26;
				IL_DDA:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_1090:
				goto IL_1D26;
				IL_18C2:
				return this.Yield(3, new WaitForSeconds(0.6f));
				IL_1D26:
				return false;
			}

			// Token: 0x06001547 RID: 5447 RVA: 0x0021C22C File Offset: 0x0021A42C
			internal static bool ySGTvKmI73YkIDh0NU8()
			{
				return true;
			}

			// Token: 0x06001548 RID: 5448 RVA: 0x0021C230 File Offset: 0x0021A430
			internal static bool Cfg3YNmBhsFk0QN26Gt()
			{
				return false;
			}

			// Token: 0x04001269 RID: 4713
			internal GameObject $tObject$18913;

			// Token: 0x0400126A RID: 4714
			internal CharacterControl $tChar$18914;

			// Token: 0x0400126B RID: 4715
			internal Vector3 $tDir$18915;

			// Token: 0x0400126C RID: 4716
			internal int $tID$18916;

			// Token: 0x0400126D RID: 4717
			internal float $distance$18917;

			// Token: 0x0400126E RID: 4718
			internal float $mTime$18918;

			// Token: 0x0400126F RID: 4719
			internal ShadowBat_AI $self_$18919;
		}
	}
}
