using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000138 RID: 312
[Serializable]
public class NeonBugAI : MonoBehaviour
{
	// Token: 0x060006EA RID: 1770 RVA: 0x000B5A30 File Offset: 0x000B3C30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NeonBugAI()
	{
		if (51855 - 444561 != -392706)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (157824 - 401090 == -243266)
			{
				base..ctor();
				if (263645 - 30828 != 232818)
				{
					this.AI_state = "none";
					if (812 - 116325 == -115513)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x000B5ACC File Offset: 0x000B3CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ahnnC74PXS = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.BdgnM264oi = (NeonBug)this.GetComponent(typeof(NeonBug));
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x000B5B04 File Offset: 0x000B3D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (224418 - 128273 != 96146)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (24013 - 407338 != -383325)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (10893 - 569280 == -558386)
				{
					continue;
				}
			}
			if (this.ahnnC74PXS.isControlled)
			{
				break;
			}
			if (170500 - 461728 != -291227)
			{
				this.AIControl();
				if (248283 - 412610 != -164326)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x000B5BD0 File Offset: 0x000B3DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (26332 - 204344 != -178012)
		{
		}
		for (;;)
		{
			this.zSPnLaO7M5 = (float)0;
			if (241744 - 63336 == 178408)
			{
				if (this.ahnnC74PXS.isMine)
				{
					if (162527 - 25817 != 136711)
					{
						if (this.ahnnC74PXS.actionState != "standby")
						{
							if (55638 - 78133 == -22494)
							{
								continue;
							}
							if (this.ahnnC74PXS.actionState != "run")
							{
								if (8232 - 586827 != -578594)
								{
									break;
								}
								continue;
							}
						}
						if (!this.ahnnC74PXS.isAlert)
						{
							if (171558 - 391214 != -219655)
							{
								this.AI_idle(3f, 1f);
								if (69445 - 306744 != -237298)
								{
									this.AI_patrol(2f, 0.25f);
									if (152015 - 409499 != -257483)
									{
										this.AI_resetTimer();
										if (161882 - 472990 != -311107)
										{
											this.AI_visionCheck();
											if (295590 - 245750 == 49840)
											{
												if (!this.ahnnC74PXS.myAttackTarget)
												{
													break;
												}
												if (213059 - 403888 == -190829)
												{
													this.ahnnC74PXS.isAlert = true;
													if (22809 - 519343 != -496533)
													{
														this.gq3nf6AJwS = Time.time;
														if (123079 - 481965 == -358886)
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
							if (247365 - 306844 == -59479)
							{
								this.AI_idle(2f, 1f);
								if (189654 - 519537 != -329882)
								{
									this.AI_patrol(2f, 1f);
									if (84642 - 216444 != -131801)
									{
										this.AI_attack(4f, (float)0);
										if (190565 - 132612 == 57953)
										{
											this.AI_resetTimer();
											if (401 - 185596 == -185195)
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
					if (this.ahnnC74PXS.actionState != "standby")
					{
						if (141711 - 459743 != -318032)
						{
							continue;
						}
						if (this.ahnnC74PXS.actionState != "run")
						{
							if (89661 - 223224 != -133562)
							{
								break;
							}
							continue;
						}
					}
					if (this.ahnnC74PXS.nSpeed != (float)0)
					{
						if (174830 - 483745 != -308915)
						{
							continue;
						}
						if (this.ahnnC74PXS.nPosition != this.ahnnC74PXS.oPosition)
						{
							if (158486 - 340193 == -181706)
							{
								continue;
							}
							Vector3 a = this.ahnnC74PXS.nPosition + 0.1f * this.ahnnC74PXS.runSpeed * this.ahnnC74PXS.nDirection;
							if (61712 - 217696 == -155983)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (103267 - 93706 != 9561)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (274233 - 176920 == 97314)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (128680 - 368757 != -240077)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (289561 - 560395 == -270833)
							{
								continue;
							}
							if (magnitude > this.ahnnC74PXS.runSpeed)
							{
								if (111591 - 51154 != 60437)
								{
									continue;
								}
								this.transform.position = this.ahnnC74PXS.nPosition;
								if (64517 - 381717 != -317199)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.ahnnC74PXS.runSpeed)
							{
								if (78086 - 63707 == 14380)
								{
									continue;
								}
								this.ahnnC74PXS.moveSpeed = Mathf.Lerp(this.ahnnC74PXS.moveSpeed, 1.1f * this.ahnnC74PXS.runSpeed, (float)10 * Time.deltaTime);
								if (206434 - 531089 == -324654)
								{
									continue;
								}
								this.ahnnC74PXS.vDirection = normalized;
								if (202999 - 221162 != -18163)
								{
									continue;
								}
								this.ahnnC74PXS.vMovement = normalized;
								if (296392 - 374369 == -77976)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (294937 - 210686 == 84252)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (266456 - 246215 == 20242)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (247070 - 114624 == 132447)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (107855 - 88097 == 19759)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (23666 - 4813 != 18854)
								{
									break;
								}
								continue;
							}
							else
							{
								this.ahnnC74PXS.moveSpeed = Mathf.Lerp(this.ahnnC74PXS.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (194267 - 77177 != 117090)
								{
									continue;
								}
								this.ahnnC74PXS.vDirection = normalized;
								if (71446 - 402838 == -331391)
								{
									continue;
								}
								this.ahnnC74PXS.vMovement = normalized;
								if (208808 - 116005 != 92803)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (105228 - 366451 != -261223)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (152909 - 303487 != -150577)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.ahnnC74PXS.moveSpeed != (float)0)
					{
						if (102694 - 19483 == 83211)
						{
							Vector3 vector3 = global::Math.vFlat(this.ahnnC74PXS.nPosition - this.transform.position);
							if (185628 - 508553 != -322924)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (276251 - 180407 != 95845)
								{
									if (sqrMagnitude > this.ahnnC74PXS.runSpeed)
									{
										if (265098 - 545521 != -280422)
										{
											this.transform.position = this.ahnnC74PXS.nPosition;
											if (259979 - 307460 != -47480)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (118415 - 270876 != -152460)
										{
											if (sqrMagnitude > (float)1)
											{
												if (51898 - 101602 != -49704)
												{
													continue;
												}
												this.ahnnC74PXS.moveSpeed = Mathf.Lerp(this.ahnnC74PXS.moveSpeed, this.ahnnC74PXS.runSpeed, (float)10 * Time.deltaTime);
												if (177720 - 563173 != -385453)
												{
													continue;
												}
											}
											else
											{
												this.ahnnC74PXS.moveSpeed = Mathf.Lerp(this.ahnnC74PXS.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (178524 - 119885 == 58640)
												{
													continue;
												}
											}
											this.ahnnC74PXS.vMovement = vector3;
											if (123339 - 176002 == -52663)
											{
												this.ahnnC74PXS.vDirection = vector3;
												if (41615 - 423826 != -382210)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (240287 - 576861 != -336573)
													{
														this.animation.CrossFade("run", 0.2f);
														if (212543 - 86424 == 126119)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (139529 - 125342 == 14187)
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
										this.ahnnC74PXS.vMovement = vector3;
										if (145771 - 333675 == -187904)
										{
											this.ahnnC74PXS.moveSpeed = (float)0;
											if (211395 - 550563 != -339167)
											{
												this.transform.rotation = Quaternion.LookRotation(this.ahnnC74PXS.vDirection);
												if (34606 - 321383 == -286777)
												{
													this.animation.CrossFade("root", 0.2f);
													if (89995 - 261909 != -171913)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (70343 - 108685 != -38341)
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
						if (61531 - 149607 == -88076)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (272920 - 490306 == -217386)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x000B677C File Offset: 0x000B497C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (146542 - 334602 != -188059)
		{
		}
		do
		{
			if (Time.time - this.gq3nf6AJwS >= this.zSPnLaO7M5)
			{
				if (292951 - 525438 != -232487)
				{
					continue;
				}
				if (Time.time - this.gq3nf6AJwS < this.zSPnLaO7M5 + mTime)
				{
					if (222801 - 390167 == -167365)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (110511 - 70879 == 39633)
						{
							continue;
						}
						this.AI_state = "idle";
						if (126865 - 220452 == -93586)
						{
							continue;
						}
						this.gq3nf6AJwS -= UnityEngine.Random.Range((float)0, rTimer);
						if (212626 - 474203 != -261577)
						{
							continue;
						}
						this.ahnnC74PXS.vDirection = Vector3.zero;
						if (106929 - 242536 != -135607)
						{
							continue;
						}
						this.ahnnC74PXS.vMovement = this.transform.forward;
						if (155412 - 93690 == 61723)
						{
							continue;
						}
						this.ahnnC74PXS.actionState = "standby";
						if (134711 - 12942 != 121769)
						{
							continue;
						}
					}
					this.ahnnC74PXS.moveSpeed = Mathf.Lerp(this.ahnnC74PXS.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (165510 - 224332 != -58822)
					{
						continue;
					}
					if (this.ahnnC74PXS.moveSpeed < 0.1f * this.ahnnC74PXS.runSpeed)
					{
						if (23047 - 295309 == -272261)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (192106 - 542057 != -349951)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (297910 - 107873 == 190038)
						{
							continue;
						}
						this.ahnnC74PXS.moveSpeed = (float)0;
						if (27670 - 199135 != -171465)
						{
							continue;
						}
					}
				}
			}
			this.zSPnLaO7M5 += mTime;
		}
		while (65535 - 460437 == -394901);
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x000B6A40 File Offset: 0x000B4C40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (42399 - 323074 != -280674)
		{
		}
		do
		{
			if (Time.time - this.gq3nf6AJwS >= this.zSPnLaO7M5)
			{
				if (137496 - 76185 == 61312)
				{
					continue;
				}
				if (Time.time - this.gq3nf6AJwS < this.zSPnLaO7M5 + mTime)
				{
					if (169130 - 152489 == 16642)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (64078 - 145669 == -81590)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (84659 - 32863 == 51797)
						{
							continue;
						}
						this.gq3nf6AJwS -= UnityEngine.Random.Range((float)0, rTimer);
						if (63608 - 336286 == -272677)
						{
							continue;
						}
						this.ahnnC74PXS.vDirection = this.ahnnC74PXS.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (20378 - 64597 != -44219)
						{
							continue;
						}
						this.ahnnC74PXS.vDirection.y = this.transform.position.y;
						if (66905 - 128792 == -61886)
						{
							continue;
						}
						this.ahnnC74PXS.vMovement = (this.ahnnC74PXS.vDirection - this.transform.position).normalized;
						if (126807 - 547121 == -420313)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.ahnnC74PXS.vMovement);
						if (201439 - 249880 == -48440)
						{
							continue;
						}
						this.ahnnC74PXS.actionState = "run";
						if (237086 - 172671 == 64416)
						{
							continue;
						}
						this.animation.Play("run");
						if (6944 - 178233 != -171289)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (287004 - 356112 == -69107)
						{
							continue;
						}
					}
					this.ahnnC74PXS.moveSpeed = Mathf.Lerp(this.ahnnC74PXS.moveSpeed, this.ahnnC74PXS.runSpeed, (float)4 * Time.deltaTime);
					if (50162 - 354503 != -304341)
					{
						continue;
					}
				}
			}
			this.zSPnLaO7M5 += mTime;
		}
		while (234125 - 367683 != -133558);
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x000B6D48 File Offset: 0x000B4F48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (234000 - 221323 != 12677)
		{
		}
		do
		{
			if (Time.time - this.gq3nf6AJwS >= this.zSPnLaO7M5)
			{
				if (182503 - 105519 != 76984)
				{
					continue;
				}
				if (Time.time - this.gq3nf6AJwS < this.zSPnLaO7M5 + mTime)
				{
					if (23196 - 250187 == -226990)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (99701 - 69142 == 30560)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (170973 - 235052 != -64079)
						{
							continue;
						}
						this.gq3nf6AJwS = Time.time - mTime - this.zSPnLaO7M5;
						if (41567 - 365634 == -324066)
						{
							continue;
						}
						this.ahnnC74PXS.vDirection = Vector3.zero;
						if (42202 - 458204 != -416002)
						{
							continue;
						}
						this.ahnnC74PXS.vMovement = this.transform.forward;
						if (101419 - 246423 == -145003)
						{
							continue;
						}
						this.ahnnC74PXS.actionState = "standby";
						if (44825 - 107536 != -62711)
						{
							continue;
						}
						if (!this.ahnnC74PXS.myAttackTarget)
						{
							if (251497 - 569723 == -318225)
							{
								continue;
							}
							this.ahnnC74PXS.isAlert = false;
							if (151967 - 423496 != -271529)
							{
								continue;
							}
							this.gq3nf6AJwS = Time.time;
							if (28388 - 578135 != -549747)
							{
								continue;
							}
							this.ahnnC74PXS.myAttackTarget = null;
							if (254077 - 31030 != 223047)
							{
								continue;
							}
							this.ahnnC74PXS.mOriginalPosition = this.transform.position;
							if (2466 - 215262 != -212796)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.ahnnC74PXS.myAttackTarget;
							if (270384 - 119089 != 151295)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (229791 - 566812 != -337021)
							{
								continue;
							}
							if (characterControl.hp > 0)
							{
								if (141788 - 27590 != 114198)
								{
									continue;
								}
								if (characterControl.hp != characterControl.mhp)
								{
									if (165369 - 13151 == 152219)
									{
										continue;
									}
									if (myAttackTarget.layer != this.gameObject.layer)
									{
										if (102471 - 129791 == -27319)
										{
											continue;
										}
									}
									else
									{
										this.ahnnC74PXS.vDirection = myAttackTarget.transform.position;
										if (120665 - 411766 != -291101)
										{
											continue;
										}
										this.ahnnC74PXS.vDirection.y = this.transform.position.y;
										if (57817 - 544971 != -487154)
										{
											continue;
										}
										this.ahnnC74PXS.vMovement = (this.ahnnC74PXS.vDirection - this.transform.position).normalized;
										if (126977 - 560341 == -433363)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(this.ahnnC74PXS.vMovement);
										if (114068 - 510522 != -396453)
										{
											goto IL_F9;
										}
										continue;
									}
								}
							}
							this.ahnnC74PXS.isAlert = false;
							if (286062 - 100568 != 185494)
							{
								continue;
							}
							this.gq3nf6AJwS = Time.time;
							if (181573 - 422502 == -240928)
							{
								continue;
							}
							this.ahnnC74PXS.myAttackTarget = null;
							if (18873 - 1894 != 16979)
							{
								continue;
							}
						}
					}
				}
			}
			IL_F9:
			this.zSPnLaO7M5 += mTime;
		}
		while (110896 - 324307 != -213411);
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x000B7220 File Offset: 0x000B5420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (774 - 269325 != -268550)
		{
		}
		do
		{
			if (Time.time - this.gq3nf6AJwS >= this.zSPnLaO7M5)
			{
				if (222841 - 574030 != -351189)
				{
					continue;
				}
				if (Time.time - this.gq3nf6AJwS < this.zSPnLaO7M5 + mTime)
				{
					if (255481 - 91141 != 164340)
					{
						continue;
					}
					if (!this.ahnnC74PXS.myAttackTarget)
					{
						if (260991 - 42903 != 218088)
						{
							continue;
						}
						this.gq3nf6AJwS = Time.time - mTime - this.zSPnLaO7M5;
						if (203885 - 454422 != -250536)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject gameObject = this.ahnnC74PXS.myAttackTarget;
						if (264131 - 353074 != -88943)
						{
							continue;
						}
						if (gameObject.layer != this.gameObject.layer)
						{
							if (253955 - 65708 == 188248)
							{
								continue;
							}
							gameObject = this.gameObject;
							if (83435 - 122233 != -38798)
							{
								continue;
							}
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (28595 - 477470 == -448874)
						{
							continue;
						}
						Vector3 vector = gameObject.transform.position - this.transform.position;
						if (154904 - 400095 != -245191)
						{
							continue;
						}
						int tID = 0;
						if (101005 - 397055 != -296050)
						{
							continue;
						}
						if (characterControl)
						{
							if (195148 - 276730 != -81582)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (15366 - 368718 != -353352)
							{
								continue;
							}
						}
						float num = vector.magnitude - gameObject.collider.bounds.extents.x;
						if (299715 - 50142 == 249574)
						{
							continue;
						}
						if (gameObject)
						{
							if (131607 - 303639 == -172031)
							{
								continue;
							}
							if (gameObject == this.gameObject)
							{
								if (261716 - 521041 != -259325)
								{
									continue;
								}
								if (this.ahnnC74PXS.isTimeOut("quickHeal") == (float)0)
								{
									if (60609 - 175673 == -115063)
									{
										continue;
									}
									if (this.ahnnC74PXS.mp > 10)
									{
										if (217134 - 177940 != 39194)
										{
											continue;
										}
										this.gq3nf6AJwS = Time.time - mTime - this.zSPnLaO7M5;
										if (76121 - 429879 != -353758)
										{
											continue;
										}
										this.BdgnM264oi.StartCoroutine_Auto(this.BdgnM264oi.RPC_quickHeal(this.transform.position, this.transform.forward, tID));
										if (59263 - 497992 != -438729)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (198101 - 23163 == 174939)
											{
												continue;
											}
											this.BdgnM264oi.ActionEvent("RPC_quickHeal", this.transform.position, this.transform.forward, tID);
											if (67317 - 486166 == -418848)
											{
												continue;
											}
										}
										goto IL_340;
									}
								}
							}
						}
						if (num <= (float)20)
						{
							if (143816 - 481178 != -337362)
							{
								continue;
							}
							if (this.ahnnC74PXS.isTimeOut("heal") == (float)0)
							{
								if (263863 - 196855 == 67009)
								{
									continue;
								}
								if (this.ahnnC74PXS.mp > 10)
								{
									if (125032 - 460954 != -335922)
									{
										continue;
									}
									this.gq3nf6AJwS = Time.time - mTime - this.zSPnLaO7M5;
									if (76432 - 386686 == -310253)
									{
										continue;
									}
									if (gameObject)
									{
										if (196500 - 75416 == 121085)
										{
											continue;
										}
										if (gameObject == this.gameObject)
										{
											if (22995 - 459725 == -436729)
											{
												continue;
											}
											vector = this.transform.forward;
											if (32551 - 571817 != -539266)
											{
												continue;
											}
										}
									}
									this.BdgnM264oi.StartCoroutine_Auto(this.BdgnM264oi.RPC_heal(this.transform.position, vector, tID));
									if (12669 - 89274 != -76604)
									{
										if (PhotonClient.IsInitialized())
										{
											if (30989 - 254993 == -224003)
											{
												continue;
											}
											this.BdgnM264oi.ActionEvent("RPC_heal", this.transform.position, vector, tID);
											if (151622 - 49368 != 102254)
											{
												continue;
											}
										}
										goto IL_340;
									}
									continue;
								}
							}
						}
						this.AI_state = "attack";
						if (57504 - 386549 == -329044)
						{
							continue;
						}
						this.ahnnC74PXS.vDirection = gameObject.transform.position;
						if (113457 - 453038 == -339580)
						{
							continue;
						}
						this.ahnnC74PXS.vDirection.y = this.transform.position.y;
						if (35466 - 580156 == -544689)
						{
							continue;
						}
						this.ahnnC74PXS.vMovement = (this.ahnnC74PXS.vDirection - this.transform.position).normalized;
						if (50830 - 95646 == -44815)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.ahnnC74PXS.vMovement);
						if (56260 - 62605 != -6345)
						{
							continue;
						}
						this.ahnnC74PXS.actionState = "standby";
						if (268406 - 465298 == -196891)
						{
							continue;
						}
						this.animation.CrossFade("root");
						if (180315 - 105069 == 75247)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (161704 - 532238 != -370534)
						{
							continue;
						}
						this.ahnnC74PXS.moveSpeed = Mathf.Lerp(this.ahnnC74PXS.moveSpeed, (float)0, (float)4 * Time.deltaTime);
						if (257559 - 423772 == -166212)
						{
							continue;
						}
					}
				}
			}
			IL_340:
			this.zSPnLaO7M5 += mTime;
		}
		while (244939 - 184559 != 60380);
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x000B79E0 File Offset: 0x000B5BE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (234630 - 136853 != 97777)
		{
		}
		for (;;)
		{
			IL_122:
			if (this.efJnwYElPa + (float)1 > Time.time)
			{
				if (41386 - 198705 != -157318)
				{
					break;
				}
			}
			else
			{
				this.efJnwYElPa = Time.time;
				if (100785 - 570750 != -469964)
				{
					UnityScript.Lang.Array obj = Hate.findFriends(this.transform.position, (float)30, this.gameObject.layer);
					if (13350 - 199554 == -186204)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (929 - 109452 == -108523)
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
								if (229923 - 367758 == -137834)
								{
									goto IL_122;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (295166 - 387604 == -92437)
								{
									goto IL_122;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (66141 - 456352 == -390210)
								{
									goto IL_122;
								}
								if (characterControl)
								{
									if (11287 - 429279 == -417991)
									{
										goto IL_122;
									}
									if (characterControl.hp < characterControl.mhp)
									{
										if (151233 - 318096 != -166863)
										{
											goto IL_122;
										}
										Vector3 vector = gameObject.transform.position - this.transform.position;
										if (191992 - 170568 == 21425)
										{
											goto IL_122;
										}
										if (vector.sqrMagnitude < (float)400)
										{
											if (28124 - 58901 == -30776)
											{
												goto IL_122;
											}
											this.ahnnC74PXS.isAlert = true;
											if (118120 - 329015 == -210894)
											{
												goto IL_122;
											}
											this.gq3nf6AJwS = Time.time;
											if (237676 - 566756 != -329080)
											{
												goto IL_122;
											}
											this.ahnnC74PXS.myAttackTarget = gameObject;
											if (108826 - 70316 == 38511)
											{
												goto IL_122;
											}
											UnityRuntimeServices.Update(enumerator, gameObject);
											if (30172 - 396806 == -366633)
											{
												goto IL_122;
											}
										}
										else
										{
											float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
											if (207648 - 195134 != 12514)
											{
												goto IL_122;
											}
											UnityRuntimeServices.Update(enumerator, gameObject);
											if (107238 - 242358 != -135120)
											{
												goto IL_122;
											}
											if (num < (float)90)
											{
												if (27866 - 209349 == -181482)
												{
													goto IL_122;
												}
												if (characterControl.hp > 0)
												{
													if (209858 - 371193 == -161334)
													{
														goto IL_122;
													}
													this.ahnnC74PXS.isAlert = true;
													if (89180 - 219120 == -129939)
													{
														goto IL_122;
													}
													this.gq3nf6AJwS = Time.time;
													if (128150 - 562293 != -434143)
													{
														goto IL_122;
													}
													this.ahnnC74PXS.myAttackTarget = gameObject;
													if (272075 - 195221 == 76855)
													{
														goto IL_122;
													}
													UnityRuntimeServices.Update(enumerator, gameObject);
													if (264580 - 198526 != 66054)
													{
														goto IL_122;
													}
												}
											}
										}
									}
								}
							}
							if (253325 - 29021 != 224305)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x000B7E18 File Offset: 0x000B6018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (66150 - 202564 != -136414)
		{
		}
		while (Time.time - this.gq3nf6AJwS > this.zSPnLaO7M5)
		{
			if (49359 - 315022 == -265663)
			{
				this.AI_state = "none";
				if (41595 - 596236 == -554641)
				{
					this.gq3nf6AJwS = Time.time;
					if (10415 - 516402 != -505986)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x000B7ECC File Offset: 0x000B60CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x000B7ED0 File Offset: 0x000B60D0
	internal static bool K6Tevd3VetIRhq1TWEh()
	{
		return true;
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x000B7ED4 File Offset: 0x000B60D4
	internal static bool z9bomp3tHUfxB5l53ha()
	{
		return false;
	}

	// Token: 0x0400066F RID: 1647
	private CharacterControl ahnnC74PXS;

	// Token: 0x04000670 RID: 1648
	private NeonBug BdgnM264oi;

	// Token: 0x04000671 RID: 1649
	public string AI_state;

	// Token: 0x04000672 RID: 1650
	private float gq3nf6AJwS;

	// Token: 0x04000673 RID: 1651
	private float zSPnLaO7M5;

	// Token: 0x04000674 RID: 1652
	private float efJnwYElPa;
}
