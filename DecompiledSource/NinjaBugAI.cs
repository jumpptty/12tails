using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200014C RID: 332
[Serializable]
public class NinjaBugAI : MonoBehaviour
{
	// Token: 0x0600075F RID: 1887 RVA: 0x000C0930 File Offset: 0x000BEB30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NinjaBugAI()
	{
		if (23065 - 157099 != -134033)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (213936 - 494281 != -280344)
			{
				base..ctor();
				if (58358 - 596652 == -538294)
				{
					this.AI_state = "none";
					if (237312 - 373171 != -135858)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x000C09CC File Offset: 0x000BEBCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.c9Pni9J3wE = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.YIDnDQXxcK = (NinjaBug)this.GetComponent(typeof(NinjaBug));
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x000C0A04 File Offset: 0x000BEC04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (259663 - 335196 != -75532)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (92396 - 114422 != -22026)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (222825 - 114024 != 108801)
				{
					continue;
				}
			}
			if (this.c9Pni9J3wE.isControlled)
			{
				break;
			}
			if (215565 - 78407 == 137158)
			{
				this.AIControl();
				if (163976 - 402766 != -238789)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x000C0AD0 File Offset: 0x000BECD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (287420 - 90614 != 196807)
		{
		}
		for (;;)
		{
			this.mXTnjTJJHY = (float)0;
			if (219936 - 188414 == 31522)
			{
				if (this.c9Pni9J3wE.isMine)
				{
					if (173868 - 150388 != 23481)
					{
						if (this.c9Pni9J3wE.actionState != "standby")
						{
							if (79122 - 93089 == -13966)
							{
								continue;
							}
							if (this.c9Pni9J3wE.actionState != "run")
							{
								if (153427 - 536988 != -383560)
								{
									break;
								}
								continue;
							}
						}
						if (!this.c9Pni9J3wE.isAlert)
						{
							if (154144 - 235910 != -81765)
							{
								this.AI_idle(3f, 1f);
								if (237592 - 6253 != 231340)
								{
									this.AI_patrol(1f, 0.25f);
									if (274983 - 502355 != -227371)
									{
										this.AI_resetTimer();
										if (188351 - 267825 == -79474)
										{
											this.AI_visionCheck();
											if (230755 - 425458 != -194702)
											{
												if (!this.c9Pni9J3wE.myAttackTarget)
												{
													break;
												}
												if (295562 - 268142 == 27420)
												{
													this.c9Pni9J3wE.isAlert = true;
													if (274079 - 375183 == -101104)
													{
														this.V2Vnm0BjTA = Time.time;
														if (52828 - 471438 == -418610)
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
							if (86615 - 450506 == -363891)
							{
								this.AI_idle(3f, 1f);
								if (178613 - 365064 != -186450)
								{
									this.AI_attack(10f, (float)0);
									if (244377 - 74352 == 170025)
									{
										this.AI_resetTimer();
										if (248759 - 158320 == 90439)
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
					if (this.c9Pni9J3wE.actionState != "standby")
					{
						if (126854 - 325362 != -198508)
						{
							continue;
						}
						if (this.c9Pni9J3wE.actionState != "run")
						{
							if (129522 - 592907 != -463385)
							{
								continue;
							}
							break;
						}
					}
					if (this.c9Pni9J3wE.nSpeed != (float)0)
					{
						if (156242 - 521935 != -365693)
						{
							continue;
						}
						if (this.c9Pni9J3wE.nPosition != this.c9Pni9J3wE.oPosition)
						{
							if (269351 - 593265 != -323914)
							{
								continue;
							}
							Vector3 a = this.c9Pni9J3wE.nPosition + 0.1f * this.c9Pni9J3wE.runSpeed * this.c9Pni9J3wE.nDirection;
							if (264495 - 453713 != -189218)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (271741 - 360090 == -88348)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (168986 - 225377 != -56391)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (242926 - 454738 != -211812)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (287510 - 215462 != 72048)
							{
								continue;
							}
							if (magnitude > this.c9Pni9J3wE.runSpeed)
							{
								if (247655 - 364062 != -116407)
								{
									continue;
								}
								this.transform.position = this.c9Pni9J3wE.nPosition;
								if (4677 - 283948 != -279271)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.c9Pni9J3wE.runSpeed)
							{
								if (102672 - 434247 == -331574)
								{
									continue;
								}
								this.c9Pni9J3wE.moveSpeed = Mathf.Lerp(this.c9Pni9J3wE.moveSpeed, 1.1f * this.c9Pni9J3wE.runSpeed, (float)10 * Time.deltaTime);
								if (124690 - 498515 != -373825)
								{
									continue;
								}
								this.c9Pni9J3wE.vDirection = normalized;
								if (24415 - 164352 == -139936)
								{
									continue;
								}
								this.c9Pni9J3wE.vMovement = normalized;
								if (220447 - 13014 == 207434)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (64529 - 226045 != -161516)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (120954 - 499419 == -378464)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (205304 - 296891 == -91586)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (11725 - 108097 == -96371)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (199385 - 400240 != -200854)
								{
									break;
								}
								continue;
							}
							else
							{
								this.c9Pni9J3wE.moveSpeed = Mathf.Lerp(this.c9Pni9J3wE.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (246309 - 211117 == 35193)
								{
									continue;
								}
								this.c9Pni9J3wE.vDirection = normalized;
								if (98521 - 596676 != -498155)
								{
									continue;
								}
								this.c9Pni9J3wE.vMovement = normalized;
								if (207304 - 278519 == -71214)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (29947 - 362561 == -332613)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (75115 - 97691 != -22575)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.c9Pni9J3wE.moveSpeed != (float)0)
					{
						if (200076 - 82023 != 118054)
						{
							Vector3 vector3 = global::Math.vFlat(this.c9Pni9J3wE.nPosition - this.transform.position);
							if (181539 - 552050 != -370510)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (180955 - 184429 != -3473)
								{
									if (sqrMagnitude > this.c9Pni9J3wE.runSpeed)
									{
										if (113058 - 397510 == -284452)
										{
											this.transform.position = this.c9Pni9J3wE.nPosition;
											if (158368 - 127239 != 31130)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (126633 - 476770 != -350136)
										{
											if (sqrMagnitude > (float)1)
											{
												if (232192 - 491430 != -259238)
												{
													continue;
												}
												this.c9Pni9J3wE.moveSpeed = Mathf.Lerp(this.c9Pni9J3wE.moveSpeed, this.c9Pni9J3wE.runSpeed, (float)10 * Time.deltaTime);
												if (119386 - 439792 == -320405)
												{
													continue;
												}
											}
											else
											{
												this.c9Pni9J3wE.moveSpeed = Mathf.Lerp(this.c9Pni9J3wE.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (183133 - 589253 == -406119)
												{
													continue;
												}
											}
											this.c9Pni9J3wE.vMovement = vector3;
											if (225172 - 253845 != -28672)
											{
												this.c9Pni9J3wE.vDirection = vector3;
												if (88534 - 391041 == -302507)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (121924 - 168131 == -46207)
													{
														this.animation.CrossFade("run", 0.2f);
														if (216341 - 312639 != -96297)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (83503 - 64491 != 19013)
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
										this.c9Pni9J3wE.vMovement = vector3;
										if (290182 - 441809 == -151627)
										{
											this.c9Pni9J3wE.moveSpeed = (float)0;
											if (248977 - 508460 == -259483)
											{
												this.transform.rotation = Quaternion.LookRotation(this.c9Pni9J3wE.vDirection);
												if (274331 - 336588 != -62256)
												{
													this.animation.CrossFade("root", 0.2f);
													if (125369 - 160108 == -34739)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (6686 - 425836 != -419149)
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
						if (102609 - 577208 != -474598)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (50996 - 17543 == 33453)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x000C1650 File Offset: 0x000BF850
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (75360 - 308885 != -233524)
		{
		}
		do
		{
			if (Time.time - this.V2Vnm0BjTA >= this.mXTnjTJJHY)
			{
				if (184268 - 401800 == -217531)
				{
					continue;
				}
				if (Time.time - this.V2Vnm0BjTA < this.mXTnjTJJHY + mTime)
				{
					if (46871 - 176860 == -129988)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (296697 - 76066 != 220631)
						{
							continue;
						}
						this.AI_state = "idle";
						if (195539 - 110688 != 84851)
						{
							continue;
						}
						this.V2Vnm0BjTA -= UnityEngine.Random.Range((float)0, rTimer);
						if (197753 - 562414 != -364661)
						{
							continue;
						}
						this.c9Pni9J3wE.vDirection = Vector3.zero;
						if (55321 - 314919 == -259597)
						{
							continue;
						}
						this.c9Pni9J3wE.vMovement = this.transform.forward;
						if (183936 - 64868 != 119068)
						{
							continue;
						}
						this.c9Pni9J3wE.actionState = "standby";
						if (131303 - 164080 == -32776)
						{
							continue;
						}
					}
					this.c9Pni9J3wE.moveSpeed = Mathf.Lerp(this.c9Pni9J3wE.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (197018 - 313046 == -116027)
					{
						continue;
					}
					if (this.c9Pni9J3wE.moveSpeed < 0.1f * this.c9Pni9J3wE.runSpeed)
					{
						if (103108 - 13410 != 89698)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (244883 - 234851 == 10033)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (62465 - 209290 != -146825)
						{
							continue;
						}
						this.c9Pni9J3wE.moveSpeed = (float)0;
						if (8275 - 222156 != -213881)
						{
							continue;
						}
					}
				}
			}
			this.mXTnjTJJHY += mTime;
		}
		while (277770 - 349867 == -72096);
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x000C1914 File Offset: 0x000BFB14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (171262 - 188625 != -17362)
		{
		}
		do
		{
			if (Time.time - this.V2Vnm0BjTA >= this.mXTnjTJJHY)
			{
				if (278320 - 208725 == 69596)
				{
					continue;
				}
				if (Time.time - this.V2Vnm0BjTA < this.mXTnjTJJHY + mTime)
				{
					if (159811 - 236284 != -76473)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (230610 - 431150 == -200539)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (203675 - 86295 == 117381)
						{
							continue;
						}
						this.V2Vnm0BjTA -= UnityEngine.Random.Range((float)0, rTimer);
						if (58237 - 567120 == -508882)
						{
							continue;
						}
						this.c9Pni9J3wE.vDirection = this.c9Pni9J3wE.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (9212 - 393425 == -384212)
						{
							continue;
						}
						this.c9Pni9J3wE.vDirection.y = this.transform.position.y;
						if (36527 - 589109 != -552582)
						{
							continue;
						}
						this.c9Pni9J3wE.vMovement = (this.c9Pni9J3wE.vDirection - this.transform.position).normalized;
						if (6609 - 166397 != -159788)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.c9Pni9J3wE.vMovement);
						if (9674 - 46216 == -36541)
						{
							continue;
						}
						this.c9Pni9J3wE.actionState = "run";
						if (277008 - 561770 != -284762)
						{
							continue;
						}
						this.animation.Play("run");
						if (55865 - 473389 == -417523)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (148497 - 36982 != 111515)
						{
							continue;
						}
					}
					this.c9Pni9J3wE.moveSpeed = Mathf.Lerp(this.c9Pni9J3wE.moveSpeed, this.c9Pni9J3wE.runSpeed, (float)4 * Time.deltaTime);
					if (145121 - 437502 == -292380)
					{
						continue;
					}
				}
			}
			this.mXTnjTJJHY += mTime;
		}
		while (299112 - 123658 != 175454);
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x000C1C1C File Offset: 0x000BFE1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (284607 - 300730 != -16123)
		{
		}
		do
		{
			if (Time.time - this.V2Vnm0BjTA >= this.mXTnjTJJHY)
			{
				if (126293 - 275393 != -149100)
				{
					continue;
				}
				if (Time.time - this.V2Vnm0BjTA < this.mXTnjTJJHY + mTime)
				{
					if (107764 - 61673 != 46091)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (228645 - 120987 == 107659)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (88168 - 249843 != -161675)
						{
							continue;
						}
						this.V2Vnm0BjTA = Time.time - mTime - this.mXTnjTJJHY;
						if (128611 - 450236 != -321625)
						{
							continue;
						}
						this.c9Pni9J3wE.vDirection = Vector3.zero;
						if (167812 - 71845 == 95968)
						{
							continue;
						}
						this.c9Pni9J3wE.vMovement = this.transform.forward;
						if (106408 - 182055 == -75646)
						{
							continue;
						}
						this.c9Pni9J3wE.actionState = "standby";
						if (54336 - 73500 == -19163)
						{
							continue;
						}
						this.c9Pni9J3wE.myAttackTarget = this.c9Pni9J3wE.getHateTarget(5, 50);
						if (214002 - 246901 == -32898)
						{
							continue;
						}
						if (!this.c9Pni9J3wE.myAttackTarget)
						{
							if (164433 - 490523 != -326090)
							{
								continue;
							}
							this.c9Pni9J3wE.isAlert = false;
							if (22359 - 57606 == -35246)
							{
								continue;
							}
							this.V2Vnm0BjTA = Time.time;
							if (205505 - 70790 != 134715)
							{
								continue;
							}
							this.c9Pni9J3wE.myAttackTarget = null;
							if (78959 - 16757 != 62202)
							{
								continue;
							}
							this.c9Pni9J3wE.mOriginalPosition = this.transform.position;
							if (1037 - 159921 != -158884)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.c9Pni9J3wE.myAttackTarget;
							if (49155 - 143881 == -94725)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (56465 - 320734 != -264269)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (283107 - 434916 != -151809)
								{
									continue;
								}
								this.c9Pni9J3wE.isAlert = false;
								if (24014 - 170567 != -146553)
								{
									continue;
								}
								this.V2Vnm0BjTA = Time.time;
								if (131038 - 326367 == -195328)
								{
									continue;
								}
								this.c9Pni9J3wE.myAttackTarget = null;
								if (169080 - 266471 != -97391)
								{
									continue;
								}
							}
							else
							{
								this.c9Pni9J3wE.vDirection = myAttackTarget.transform.position;
								if (207593 - 227142 != -19549)
								{
									continue;
								}
								this.c9Pni9J3wE.vDirection.y = this.transform.position.y;
								if (293004 - 227247 != 65757)
								{
									continue;
								}
								this.c9Pni9J3wE.vMovement = (this.c9Pni9J3wE.vDirection - this.transform.position).normalized;
								if (209599 - 278309 == -68709)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.c9Pni9J3wE.vMovement);
								if (91766 - 83378 != 8388)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.mXTnjTJJHY += mTime;
		}
		while (193311 - 369591 != -176280);
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x000C20CC File Offset: 0x000C02CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (31963 - 11398 != 20565)
		{
		}
		do
		{
			if (Time.time - this.V2Vnm0BjTA >= this.mXTnjTJJHY)
			{
				if (65558 - 57090 != 8468)
				{
					continue;
				}
				if (Time.time - this.V2Vnm0BjTA < this.mXTnjTJJHY + mTime)
				{
					if (50545 - 355295 != -304750)
					{
						continue;
					}
					GameObject myAttackTarget = this.c9Pni9J3wE.myAttackTarget;
					if (72413 - 57289 == 15125)
					{
						continue;
					}
					CharacterControl characterControl = null;
					if (14695 - 243415 == -228719)
					{
						continue;
					}
					if (myAttackTarget)
					{
						if (85659 - 53446 != 32213)
						{
							continue;
						}
						characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (165205 - 819 != 164386)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (274173 - 401662 == -127488)
						{
							continue;
						}
						this.V2Vnm0BjTA = Time.time - mTime - this.mXTnjTJJHY;
						if (38598 - 284736 != -246137)
						{
							break;
						}
						continue;
					}
					else
					{
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (278829 - 418301 != -139472)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (207664 - 91067 == 116598)
						{
							continue;
						}
						eNinjaBugType eNinjaBugType = (eNinjaBugType)UnityRuntimeServices.GetProperty(this.GetComponent("NinjaBug"), "ninjaBugType");
						if (160458 - 374762 == -214303)
						{
							continue;
						}
						float num2 = (float)0;
						if (148564 - 342607 == -194042)
						{
							continue;
						}
						eNinjaBugType eNinjaBugType2 = eNinjaBugType;
						if (32668 - 206064 == -173395)
						{
							continue;
						}
						if (eNinjaBugType2 == eNinjaBugType.sword)
						{
							if (233664 - 522931 != -289267)
							{
								continue;
							}
							num2 = (float)2;
							if (275978 - 25485 != 250493)
							{
								continue;
							}
						}
						else if (eNinjaBugType2 == eNinjaBugType.shuriken)
						{
							if (38931 - 485929 == -446997)
							{
								continue;
							}
							num2 = (float)20;
							if (64728 - 496641 == -431912)
							{
								continue;
							}
						}
						else if (eNinjaBugType2 == eNinjaBugType.bomb)
						{
							if (110520 - 322869 != -212349)
							{
								continue;
							}
							num2 = (float)9;
							if (256208 - 583405 == -327196)
							{
								continue;
							}
						}
						else if (eNinjaBugType2 == eNinjaBugType.scythe)
						{
							if (30150 - 484792 == -454641)
							{
								continue;
							}
							num2 = (float)4;
							if (177328 - 219433 == -42104)
							{
								continue;
							}
						}
						else if (eNinjaBugType2 == eNinjaBugType.knife)
						{
							if (247435 - 475932 == -228496)
							{
								continue;
							}
							num2 = (float)15;
							if (175132 - 259383 == -84250)
							{
								continue;
							}
						}
						if (num < num2)
						{
							if (162804 - 337263 == -174458)
							{
								continue;
							}
							if (this.c9Pni9J3wE.isTimeOut("nAttack") == (float)0)
							{
								if (36784 - 595637 != -558853)
								{
									continue;
								}
								this.V2Vnm0BjTA = Time.time - mTime - this.mXTnjTJJHY;
								if (261410 - 515999 == -254588)
								{
									continue;
								}
								eNinjaBugType eNinjaBugType3 = eNinjaBugType;
								if (201291 - 586807 != -385515)
								{
									if (eNinjaBugType3 == eNinjaBugType.sword)
									{
										if (120931 - 547855 == -426923)
										{
											continue;
										}
										this.YIDnDQXxcK.StartCoroutine_Auto(this.YIDnDQXxcK.RPC_sword(this.transform.position, vector, 0));
										if (229448 - 100159 != 129289)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (85658 - 501227 != -415569)
											{
												continue;
											}
											this.YIDnDQXxcK.ActionEvent("RPC_sword", this.transform.position, vector, 0);
											if (16273 - 314491 == -298217)
											{
												continue;
											}
										}
									}
									else if (eNinjaBugType3 == eNinjaBugType.shuriken)
									{
										if (200498 - 446706 != -246208)
										{
											continue;
										}
										this.YIDnDQXxcK.StartCoroutine_Auto(this.YIDnDQXxcK.RPC_shuriken(this.transform.position, vector, characterControl.ActorNr));
										if (170785 - 318596 == -147810)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (143531 - 36050 != 107481)
											{
												continue;
											}
											this.YIDnDQXxcK.ActionEvent("RPC_shuriken", this.transform.position, vector, characterControl.ActorNr);
											if (240256 - 226158 != 14098)
											{
												continue;
											}
										}
									}
									else if (eNinjaBugType3 == eNinjaBugType.bomb)
									{
										if (266528 - 22783 == 243746)
										{
											continue;
										}
										this.YIDnDQXxcK.StartCoroutine_Auto(this.YIDnDQXxcK.RPC_bomb(this.transform.position, vector, 0));
										if (294913 - 356262 != -61349)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (243069 - 271720 == -28650)
											{
												continue;
											}
											this.YIDnDQXxcK.ActionEvent("RPC_bomb", this.transform.position, vector, 0);
											if (92744 - 511744 != -419000)
											{
												continue;
											}
										}
									}
									else if (eNinjaBugType3 == eNinjaBugType.scythe)
									{
										if (235778 - 384701 != -148923)
										{
											continue;
										}
										this.YIDnDQXxcK.StartCoroutine_Auto(this.YIDnDQXxcK.RPC_scythe(this.transform.position, vector, 0));
										if (138046 - 108675 != 29371)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (278300 - 591938 != -313638)
											{
												continue;
											}
											this.YIDnDQXxcK.ActionEvent("RPC_scythe", this.transform.position, vector, 0);
											if (264598 - 491269 == -226670)
											{
												continue;
											}
										}
									}
									else if (eNinjaBugType3 == eNinjaBugType.knife)
									{
										if (46604 - 347129 == -300524)
										{
											continue;
										}
										this.YIDnDQXxcK.StartCoroutine_Auto(this.YIDnDQXxcK.RPC_knife(this.transform.position, vector, characterControl.ActorNr));
										if (203887 - 407538 != -203651)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (184054 - 559768 != -375714)
											{
												continue;
											}
											this.YIDnDQXxcK.ActionEvent("RPC_knife", this.transform.position, vector, characterControl.ActorNr);
											if (169587 - 278964 == -109376)
											{
												continue;
											}
										}
									}
									goto IL_84;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (101822 - 297753 == -195930)
						{
							continue;
						}
						this.c9Pni9J3wE.vDirection = myAttackTarget.transform.position;
						if (51823 - 239096 == -187272)
						{
							continue;
						}
						this.c9Pni9J3wE.vDirection.y = this.transform.position.y;
						if (12725 - 560994 == -548268)
						{
							continue;
						}
						this.c9Pni9J3wE.vMovement = (this.c9Pni9J3wE.vDirection - this.transform.position).normalized;
						if (53790 - 585875 != -532085)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.c9Pni9J3wE.vMovement);
						if (115770 - 281692 != -165922)
						{
							continue;
						}
						this.c9Pni9J3wE.actionState = "run";
						if (61002 - 11425 == 49578)
						{
							continue;
						}
						this.animation.Play("run");
						if (47305 - 255547 != -208242)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (228420 - 63213 != 165207)
						{
							continue;
						}
						this.c9Pni9J3wE.moveSpeed = Mathf.Lerp(this.c9Pni9J3wE.moveSpeed, this.c9Pni9J3wE.runSpeed, (float)4 * Time.deltaTime);
						if (250859 - 182943 == 67917)
						{
							continue;
						}
					}
				}
			}
			IL_84:
			this.mXTnjTJJHY += mTime;
		}
		while (165072 - 495624 != -330552);
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x000C2B1C File Offset: 0x000C0D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (51738 - 111744 != -60005)
		{
		}
		while (Time.time - this.V2Vnm0BjTA > this.mXTnjTJJHY)
		{
			if (230449 - 514675 == -284226)
			{
				this.AI_state = "none";
				if (89972 - 444344 == -354372)
				{
					this.V2Vnm0BjTA = Time.time;
					if (286513 - 334654 == -48141)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x000C2BD0 File Offset: 0x000C0DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (252784 - 348406 != -95622)
		{
		}
		for (;;)
		{
			IL_3EB:
			if (this.zv0non27S4 > Time.time)
			{
				if (112521 - 61852 == 50669)
				{
					break;
				}
			}
			else
			{
				this.zv0non27S4 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (153805 - 468138 == -314333)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (71437 - 160635 == -89198)
					{
						if (65644 - 393784 != -328139)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (51602 - 128935 == -77333)
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
									if (33290 - 279674 != -246384)
									{
										goto IL_3EB;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (173237 - 478702 == -305464)
									{
										goto IL_3EB;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (290887 - 470678 == -179790)
									{
										goto IL_3EB;
									}
									bool flag = true;
									if (75651 - 271599 != -195948)
									{
										goto IL_3EB;
									}
									eRace race = this.c9Pni9J3wE.Race;
									if (129714 - 218282 == -88567)
									{
										goto IL_3EB;
									}
									if (race == eRace.Tails)
									{
										if (120623 - 324070 == -203446)
										{
											goto IL_3EB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_18D;
										}
										if (72151 - 108194 != -36043)
										{
											goto IL_3EB;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (180436 - 102981 != 77455)
											{
												goto IL_3EB;
											}
											goto IL_18D;
										}
										goto IL_768;
										IL_18D:
										flag = false;
										if (190502 - 594205 == -403702)
										{
											goto IL_3EB;
										}
									}
									else if (race == eRace.Plants)
									{
										if (271986 - 124554 == 147433)
										{
											goto IL_3EB;
										}
										flag = false;
										if (146363 - 202024 != -55661)
										{
											goto IL_3EB;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (71699 - 254058 == -182358)
										{
											goto IL_3EB;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_415;
										}
										if (155952 - 450539 != -294587)
										{
											goto IL_3EB;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (237050 - 557535 != -320485)
											{
												goto IL_3EB;
											}
											goto IL_415;
										}
										goto IL_768;
										IL_415:
										flag = false;
										if (30896 - 350663 != -319767)
										{
											goto IL_3EB;
										}
									}
									else if (race == eRace.Robots)
									{
										if (241955 - 147715 == 94241)
										{
											goto IL_3EB;
										}
										flag = true;
										if (166920 - 595878 == -428957)
										{
											goto IL_3EB;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (325 - 28803 != -28478)
										{
											goto IL_3EB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_A9;
										}
										if (175000 - 405545 == -230544)
										{
											goto IL_3EB;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_A9;
										}
										if (105155 - 241277 != -136122)
										{
											goto IL_3EB;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (32165 - 374153 != -341988)
											{
												goto IL_3EB;
											}
											goto IL_A9;
										}
										goto IL_768;
										IL_A9:
										flag = false;
										if (193048 - 94628 == 98421)
										{
											goto IL_3EB;
										}
									}
									else if (race == eRace.Structure)
									{
										if (220306 - 596388 != -376082)
										{
											goto IL_3EB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (71341 - 263482 == -192140)
											{
												goto IL_3EB;
											}
											flag = false;
											if (33333 - 85531 == -52197)
											{
												goto IL_3EB;
											}
										}
									}
									IL_768:
									if (flag)
									{
										if (50287 - 431959 == -381671)
										{
											goto IL_3EB;
										}
										if (characterControl.hp > 0)
										{
											if (156821 - 536124 == -379302)
											{
												goto IL_3EB;
											}
											if (characterControl.recieveTarget)
											{
												if (217745 - 407751 == -190005)
												{
													goto IL_3EB;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (92350 - 329869 != -237519)
													{
														goto IL_3EB;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (2099 - 149613 != -147514)
														{
															goto IL_3EB;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (157150 - 492872 == -335721)
														{
															goto IL_3EB;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (211565 - 534215 == -322649)
															{
																goto IL_3EB;
															}
															this.c9Pni9J3wE.myAttackTarget = gameObject;
															if (78968 - 447215 == -368246)
															{
																goto IL_3EB;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (43664 - 266254 == -222589)
															{
																goto IL_3EB;
															}
															this.c9Pni9J3wE.addHate(characterControl.ActorNr, 5);
															if (132945 - 151890 != -18945)
															{
																goto IL_3EB;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (8134 - 536381 != -528247)
															{
																goto IL_3EB;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (217450 - 129937 != 87513)
															{
																goto IL_3EB;
															}
															if (num < (float)60)
															{
																if (200701 - 235134 == -34432)
																{
																	goto IL_3EB;
																}
																if (characterControl.hp > 0)
																{
																	if (293399 - 183342 != 110057)
																	{
																		goto IL_3EB;
																	}
																	this.c9Pni9J3wE.myAttackTarget = gameObject;
																	if (191876 - 396849 != -204973)
																	{
																		goto IL_3EB;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (210558 - 566901 == -356342)
																	{
																		goto IL_3EB;
																	}
																	this.c9Pni9J3wE.addHate(characterControl.ActorNr, 5);
																	if (298218 - 85534 != 212684)
																	{
																		goto IL_3EB;
																	}
																}
															}
														}
														if (this.c9Pni9J3wE.myAttackTarget)
														{
															if (45940 - 32960 != 12980)
															{
																goto IL_3EB;
															}
															this.c9Pni9J3wE.isAlert = true;
															if (115916 - 511664 != -395748)
															{
																goto IL_3EB;
															}
															this.V2Vnm0BjTA = Time.time;
															if (67628 - 22585 == 45044)
															{
																goto IL_3EB;
															}
														}
													}
												}
											}
										}
									}
								}
								if (79177 - 501913 == -422736)
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

	// Token: 0x06000769 RID: 1897 RVA: 0x000C33E8 File Offset: 0x000C15E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x000C33EC File Offset: 0x000C15EC
	internal static bool o3auyG3RPdubKTo55iv()
	{
		return true;
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x000C33F0 File Offset: 0x000C15F0
	internal static bool J2E91G3w2KGqhZtV9xX()
	{
		return false;
	}

	// Token: 0x040006D3 RID: 1747
	private CharacterControl c9Pni9J3wE;

	// Token: 0x040006D4 RID: 1748
	private NinjaBug YIDnDQXxcK;

	// Token: 0x040006D5 RID: 1749
	public string AI_state;

	// Token: 0x040006D6 RID: 1750
	private float V2Vnm0BjTA;

	// Token: 0x040006D7 RID: 1751
	private float mXTnjTJJHY;

	// Token: 0x040006D8 RID: 1752
	private float zv0non27S4;
}
