using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200035C RID: 860
[Serializable]
public class LightPantherAI : MonoBehaviour
{
	// Token: 0x06001390 RID: 5008 RVA: 0x001EAB40 File Offset: 0x001E8D40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightPantherAI()
	{
		if (170595 - 474756 != -304160)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (294514 - 569654 == -275140)
			{
				base..ctor();
				if (170392 - 543380 == -372988)
				{
					this.AI_state = "none";
					if (144029 - 518958 != -374928)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x001EABDC File Offset: 0x001E8DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.rNQtY8WmjQ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.z97t3PEl0s = (LightPanther)this.GetComponent(typeof(LightPanther));
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x001EAC14 File Offset: 0x001E8E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (51012 - 313144 != -262132)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (194873 - 421492 != -226619)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (37322 - 557825 != -520503)
				{
					continue;
				}
			}
			if (this.rNQtY8WmjQ.isControlled)
			{
				break;
			}
			if (192134 - 278675 == -86541)
			{
				this.AIControl();
				if (251132 - 504259 == -253127)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x001EACE0 File Offset: 0x001E8EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (25443 - 209659 != -184216)
		{
		}
		for (;;)
		{
			this.tKxtdF4l7W = (float)0;
			if (66524 - 372156 != -305631)
			{
				if (this.rNQtY8WmjQ.isMine)
				{
					if (278241 - 580810 != -302568)
					{
						if (this.rNQtY8WmjQ.actionState != "standby")
						{
							if (238422 - 192576 == 45847)
							{
								continue;
							}
							if (this.rNQtY8WmjQ.actionState != "run")
							{
								if (27224 - 294081 != -266857)
								{
									continue;
								}
								break;
							}
						}
						if (Game.mGameCode != 983)
						{
							if (198214 - 239551 == -41336)
							{
								continue;
							}
							if (Game.mGameCode == 993)
							{
								if (122254 - 537818 != -415564)
								{
									continue;
								}
							}
							else if (!this.rNQtY8WmjQ.isAlert)
							{
								if (54080 - 513502 == -459421)
								{
									continue;
								}
								this.AI_idle(3f, 1f);
								if (92987 - 186542 == -93554)
								{
									continue;
								}
								this.AI_resetTimer();
								if (39829 - 386954 == -347124)
								{
									continue;
								}
								this.AI_visionCheck();
								if (135485 - 426348 == -290862)
								{
									continue;
								}
								if (!this.rNQtY8WmjQ.myAttackTarget)
								{
									break;
								}
								if (83185 - 523369 != -440184)
								{
									continue;
								}
								this.rNQtY8WmjQ.isAlert = true;
								if (226347 - 243402 == -17054)
								{
									continue;
								}
								this.hCStbn2cCY = Time.time;
								if (152830 - 263969 != -111139)
								{
									continue;
								}
								break;
							}
							else
							{
								this.AI_selectTarget(1f, (float)0);
								if (209237 - 232852 != -23615)
								{
									continue;
								}
								this.AI_battle(2f, 1f);
								if (222987 - 248283 == -25295)
								{
									continue;
								}
								this.AI_attack(6f, (float)0);
								if (30511 - 540545 != -510034)
								{
									continue;
								}
								this.AI_resetTimer();
								if (213256 - 535577 != -322321)
								{
									continue;
								}
								break;
							}
						}
						if (!this.rNQtY8WmjQ.isAlert)
						{
							if (88988 - 426010 != -337021)
							{
								this.AI_path(12f, (float)0);
								if (2928 - 127494 == -124566)
								{
									this.AI_resetTimer();
									if (67994 - 465633 == -397639)
									{
										this.AI_visionCheck();
										if (164068 - 363714 == -199646)
										{
											if (!this.rNQtY8WmjQ.myAttackTarget)
											{
												break;
											}
											if (248800 - 188568 != 60233)
											{
												this.rNQtY8WmjQ.isAlert = true;
												if (165328 - 83481 == 81847)
												{
													this.hCStbn2cCY = Time.time;
													if (257129 - 567456 == -310327)
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
							this.AI_selectTarget(1f, (float)0);
							if (186198 - 43595 != 142604)
							{
								this.AI_battle(2f, 1f);
								if (278270 - 260864 != 17407)
								{
									this.AI_attack(6f, (float)0);
									if (229146 - 314125 == -84979)
									{
										this.AI_resetTimer();
										if (90340 - 452965 == -362625)
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
					if (this.rNQtY8WmjQ.actionState != "standby")
					{
						if (208057 - 488056 == -279998)
						{
							continue;
						}
						if (this.rNQtY8WmjQ.actionState != "run")
						{
							if (148469 - 359413 != -210943)
							{
								break;
							}
							continue;
						}
					}
					if (this.rNQtY8WmjQ.nSpeed != (float)0)
					{
						if (63836 - 461957 != -398121)
						{
							continue;
						}
						if (this.rNQtY8WmjQ.nPosition != this.rNQtY8WmjQ.oPosition)
						{
							if (244970 - 105295 != 139675)
							{
								continue;
							}
							Vector3 a = this.rNQtY8WmjQ.nPosition + 0.1f * this.rNQtY8WmjQ.runSpeed * this.rNQtY8WmjQ.nDirection;
							if (18602 - 324566 == -305963)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (148127 - 335538 != -187411)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (201485 - 532208 != -330723)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (268241 - 126981 == 141261)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (135863 - 393095 == -257231)
							{
								continue;
							}
							if (magnitude > this.rNQtY8WmjQ.runSpeed)
							{
								if (160385 - 310734 != -150349)
								{
									continue;
								}
								this.transform.position = this.rNQtY8WmjQ.nPosition;
								if (285075 - 369888 != -84813)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.rNQtY8WmjQ.runSpeed)
							{
								if (141559 - 355796 != -214237)
								{
									continue;
								}
								this.rNQtY8WmjQ.moveSpeed = Mathf.Lerp(this.rNQtY8WmjQ.moveSpeed, 1.1f * this.rNQtY8WmjQ.runSpeed, (float)10 * Time.deltaTime);
								if (78233 - 213129 != -134896)
								{
									continue;
								}
								this.rNQtY8WmjQ.vDirection = normalized;
								if (176585 - 467341 != -290756)
								{
									continue;
								}
								this.rNQtY8WmjQ.vMovement = normalized;
								if (44929 - 482843 != -437914)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (255041 - 164948 == 90094)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (259561 - 39159 != 220402)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (218362 - 354836 == -136473)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (118442 - 259374 == -140931)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (213702 - 157843 != 55859)
								{
									continue;
								}
								break;
							}
							else
							{
								this.rNQtY8WmjQ.moveSpeed = Mathf.Lerp(this.rNQtY8WmjQ.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (99037 - 8711 == 90327)
								{
									continue;
								}
								this.rNQtY8WmjQ.vDirection = normalized;
								if (40493 - 258128 != -217635)
								{
									continue;
								}
								this.rNQtY8WmjQ.vMovement = normalized;
								if (29045 - 198575 != -169530)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (88589 - 64630 == 23960)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (173490 - 61861 != 111629)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.rNQtY8WmjQ.moveSpeed != (float)0)
					{
						if (57482 - 584153 == -526671)
						{
							Vector3 vector3 = global::Math.vFlat(this.rNQtY8WmjQ.nPosition - this.transform.position);
							if (292 - 209329 == -209037)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (65803 - 465542 != -399738)
								{
									if (sqrMagnitude > this.rNQtY8WmjQ.runSpeed)
									{
										if (92324 - 150823 != -58498)
										{
											this.transform.position = this.rNQtY8WmjQ.nPosition;
											if (242136 - 460523 == -218387)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (125692 - 208131 != -82438)
										{
											if (sqrMagnitude > (float)1)
											{
												if (115648 - 15051 == 100598)
												{
													continue;
												}
												this.rNQtY8WmjQ.moveSpeed = Mathf.Lerp(this.rNQtY8WmjQ.moveSpeed, this.rNQtY8WmjQ.runSpeed, (float)10 * Time.deltaTime);
												if (151226 - 370716 == -219489)
												{
													continue;
												}
											}
											else
											{
												this.rNQtY8WmjQ.moveSpeed = Mathf.Lerp(this.rNQtY8WmjQ.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (221792 - 232591 != -10799)
												{
													continue;
												}
											}
											this.rNQtY8WmjQ.vMovement = vector3;
											if (86122 - 557838 == -471716)
											{
												this.rNQtY8WmjQ.vDirection = vector3;
												if (100465 - 566119 != -465653)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (251426 - 200351 != 51076)
													{
														this.animation.CrossFade("run", 0.2f);
														if (161473 - 134297 == 27176)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (85878 - 343256 == -257378)
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
										this.rNQtY8WmjQ.vMovement = vector3;
										if (244832 - 517147 == -272315)
										{
											this.rNQtY8WmjQ.moveSpeed = (float)0;
											if (5325 - 428066 == -422741)
											{
												this.transform.rotation = Quaternion.LookRotation(this.rNQtY8WmjQ.vDirection);
												if (140248 - 96639 != 43610)
												{
													this.animation.CrossFade("root", 0.2f);
													if (39091 - 135493 == -96402)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (207977 - 181493 == 26484)
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
						if (87661 - 113146 != -25484)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (235936 - 568873 != -332936)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x001EBA38 File Offset: 0x001E9C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (56002 - 242509 != -186506)
		{
		}
		do
		{
			if (Time.time - this.hCStbn2cCY >= this.tKxtdF4l7W)
			{
				if (177722 - 580833 != -403111)
				{
					continue;
				}
				if (Time.time - this.hCStbn2cCY < this.tKxtdF4l7W + mTime)
				{
					if (14496 - 514215 == -499718)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (286457 - 33826 != 252631)
						{
							continue;
						}
						this.AI_state = "idle";
						if (102861 - 108825 != -5964)
						{
							continue;
						}
						this.hCStbn2cCY -= UnityEngine.Random.Range((float)0, rTimer);
						if (262904 - 312437 == -49532)
						{
							continue;
						}
						this.rNQtY8WmjQ.vDirection = Vector3.zero;
						if (101143 - 273583 != -172440)
						{
							continue;
						}
						this.rNQtY8WmjQ.vMovement = this.transform.forward;
						if (176389 - 432174 != -255785)
						{
							continue;
						}
						this.rNQtY8WmjQ.actionState = "standby";
						if (166219 - 141137 == 25083)
						{
							continue;
						}
					}
					this.rNQtY8WmjQ.moveSpeed = Mathf.Lerp(this.rNQtY8WmjQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (97517 - 241529 != -144012)
					{
						continue;
					}
					if (this.rNQtY8WmjQ.moveSpeed < 0.1f * this.rNQtY8WmjQ.runSpeed)
					{
						if (240431 - 96166 != 144265)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (127488 - 585516 == -458027)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (221112 - 302251 != -81139)
						{
							continue;
						}
						this.rNQtY8WmjQ.moveSpeed = (float)0;
						if (210047 - 289921 != -79874)
						{
							continue;
						}
					}
				}
			}
			this.tKxtdF4l7W += mTime;
		}
		while (181859 - 459438 == -277578);
	}

	// Token: 0x06001395 RID: 5013 RVA: 0x001EBCFC File Offset: 0x001E9EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (172192 - 366151 != -193958)
		{
		}
		do
		{
			if (Time.time - this.hCStbn2cCY >= this.tKxtdF4l7W)
			{
				if (234842 - 512295 == -277452)
				{
					continue;
				}
				if (Time.time - this.hCStbn2cCY < this.tKxtdF4l7W + mTime)
				{
					if (267865 - 68199 != 199666)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (193084 - 526144 == -333059)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (239292 - 172083 == 67210)
						{
							continue;
						}
						this.hCStbn2cCY -= UnityEngine.Random.Range((float)0, rTimer);
						if (32470 - 163772 == -131301)
						{
							continue;
						}
						this.rNQtY8WmjQ.vDirection = this.rNQtY8WmjQ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (93651 - 597528 == -503876)
						{
							continue;
						}
						this.rNQtY8WmjQ.vDirection.y = this.transform.position.y;
						if (12983 - 39589 != -26606)
						{
							continue;
						}
						this.rNQtY8WmjQ.vMovement = (this.rNQtY8WmjQ.vDirection - this.transform.position).normalized;
						if (109310 - 579752 == -470441)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.rNQtY8WmjQ.vMovement);
						if (264023 - 309671 != -45648)
						{
							continue;
						}
						this.rNQtY8WmjQ.actionState = "run";
						if (178415 - 73327 != 105088)
						{
							continue;
						}
						this.animation.Play("run");
						if (157280 - 535752 != -378472)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (279049 - 516623 != -237574)
						{
							continue;
						}
					}
					this.rNQtY8WmjQ.moveSpeed = Mathf.Lerp(this.rNQtY8WmjQ.moveSpeed, this.rNQtY8WmjQ.runSpeed, (float)4 * Time.deltaTime);
					if (258877 - 470634 != -211757)
					{
						continue;
					}
				}
			}
			this.tKxtdF4l7W += mTime;
		}
		while (141495 - 525600 == -384104);
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x001EC004 File Offset: 0x001EA204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_path(float mTime, float rTimer)
	{
		if (165954 - 228304 != -62349)
		{
		}
		do
		{
			IL_81F:
			if (this.rKOtaPGrwB == null)
			{
				if (47832 - 186060 != -138228)
				{
					continue;
				}
				this.rKOtaPGrwB = new UnityScript.Lang.Array();
				if (79411 - 531563 == -452151)
				{
					continue;
				}
				if (this.gameObject.layer == 8)
				{
					if (110579 - 8574 != 102005)
					{
						continue;
					}
					int i = 0;
					if (145311 - 453192 != -307881)
					{
						continue;
					}
					while (i <= 9)
					{
						Vector3 position = this.gameObject.transform.position;
						if (35999 - 356569 != -320570)
						{
							goto IL_81F;
						}
						if (position.x > (float)0)
						{
							if (76716 - 374481 != -297765)
							{
								goto IL_81F;
							}
							this.rKOtaPGrwB.Add(GameObject.Find("WayPoint1" + i));
							if (260907 - 92501 == 168407)
							{
								goto IL_81F;
							}
						}
						else
						{
							this.rKOtaPGrwB.Add(GameObject.Find("WayPoint2" + i));
							if (187723 - 220417 != -32694)
							{
								goto IL_81F;
							}
						}
						i++;
						if (135115 - 199039 != -63924)
						{
							goto IL_81F;
						}
					}
					if (24733 - 11443 == 13291)
					{
						continue;
					}
					this.rKOtaPGrwB.Add(GameObject.Find("ManaCore2"));
					if (257308 - 53381 == 203928)
					{
						continue;
					}
					object obj2;
					object obj = obj2 = this.rKOtaPGrwB[0];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.Qt5tgP96e1 = (GameObject)obj2;
					if (85047 - 68003 == 17045)
					{
						continue;
					}
				}
				else
				{
					int j = 9;
					if (109780 - 307979 == -198198)
					{
						continue;
					}
					while (j >= 0)
					{
						Vector3 position2 = this.gameObject.transform.position;
						if (13058 - 135259 != -122201)
						{
							goto IL_81F;
						}
						if (position2.x > (float)0)
						{
							if (171278 - 442888 != -271610)
							{
								goto IL_81F;
							}
							this.rKOtaPGrwB.Add(GameObject.Find("WayPoint1" + j));
							if (59550 - 532972 == -473421)
							{
								goto IL_81F;
							}
						}
						else
						{
							this.rKOtaPGrwB.Add(GameObject.Find("WayPoint2" + j));
							if (31457 - 377153 != -345696)
							{
								goto IL_81F;
							}
						}
						j--;
						if (24939 - 485851 == -460911)
						{
							goto IL_81F;
						}
					}
					if (78673 - 54392 == 24282)
					{
						continue;
					}
					this.rKOtaPGrwB.Add(GameObject.Find("ManaCore1"));
					if (12629 - 213175 != -200546)
					{
						continue;
					}
					object obj4;
					object obj3 = obj4 = this.rKOtaPGrwB[0];
					if (!(obj3 is GameObject))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
					}
					this.Qt5tgP96e1 = (GameObject)obj4;
					if (201186 - 360613 != -159427)
					{
						continue;
					}
				}
			}
			if (this.rKOtaPGrwB != null)
			{
				if (295672 - 135152 == 160521)
				{
					continue;
				}
				if (this.rKOtaPGrwB.length > 0)
				{
					if (24663 - 366469 == -341805)
					{
						continue;
					}
					if (Time.time - this.hCStbn2cCY >= this.tKxtdF4l7W)
					{
						if (61958 - 296944 != -234986)
						{
							continue;
						}
						if (Time.time - this.hCStbn2cCY < this.tKxtdF4l7W + mTime)
						{
							if (45441 - 548558 == -503116)
							{
								continue;
							}
							if (this.AI_state != "march")
							{
								if (96532 - 159177 == -62644)
								{
									continue;
								}
								this.AI_state = "march";
								if (151501 - 107197 != 44304)
								{
									continue;
								}
								this.hCStbn2cCY -= UnityEngine.Random.Range((float)0, rTimer);
								if (228440 - 6430 == 222011)
								{
									continue;
								}
								this.rNQtY8WmjQ.vDirection = this.Qt5tgP96e1.transform.position + (float)3 * UnityEngine.Random.onUnitSphere;
								if (59742 - 328925 != -269183)
								{
									continue;
								}
								this.rNQtY8WmjQ.vDirection.y = this.transform.position.y;
								if (40653 - 470501 == -429847)
								{
									continue;
								}
								this.rNQtY8WmjQ.vMovement = (this.rNQtY8WmjQ.vDirection - this.transform.position).normalized;
								if (123064 - 479943 != -356879)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.rNQtY8WmjQ.vMovement);
								if (268232 - 346241 != -78009)
								{
									continue;
								}
								this.rNQtY8WmjQ.actionState = "run";
								if (291643 - 143360 == 148284)
								{
									continue;
								}
								this.animation.Play("run");
								if (276257 - 526066 == -249808)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (299819 - 599914 != -300095)
								{
									continue;
								}
							}
							else
							{
								Vector3 vector = global::Math.vFlat(this.rNQtY8WmjQ.vDirection - this.transform.position);
								if (138744 - 181831 != -43087)
								{
									continue;
								}
								if (this.u85t4bWrot + 1 < this.rKOtaPGrwB.length)
								{
									if (45130 - 284321 == -239190)
									{
										continue;
									}
									if (vector.sqrMagnitude < (float)1)
									{
										if (267934 - 499904 != -231970)
										{
											continue;
										}
										this.u85t4bWrot++;
										if (182213 - 239282 != -57069)
										{
											continue;
										}
										object obj6;
										object obj5 = obj6 = this.rKOtaPGrwB[this.u85t4bWrot];
										if (!(obj5 is GameObject))
										{
											obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
										}
										this.Qt5tgP96e1 = (GameObject)obj6;
										if (185343 - 557583 != -372240)
										{
											continue;
										}
										this.AI_state = "standby";
										if (15062 - 499982 != -484919)
										{
											goto IL_457;
										}
										continue;
									}
								}
								this.rNQtY8WmjQ.vMovement = vector.normalized;
								if (201663 - 274921 == -73257)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.rNQtY8WmjQ.vMovement);
								if (20724 - 28298 == -7573)
								{
									continue;
								}
								this.rNQtY8WmjQ.moveSpeed = Mathf.Lerp(this.rNQtY8WmjQ.moveSpeed, this.rNQtY8WmjQ.runSpeed, (float)4 * Time.deltaTime);
								if (193082 - 485901 == -292818)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_457:
			this.tKxtdF4l7W += mTime;
		}
		while (192865 - 63315 == 129551);
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x001EC8CC File Offset: 0x001EAACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (87916 - 101582 != -13665)
		{
		}
		do
		{
			if (Time.time - this.hCStbn2cCY >= this.tKxtdF4l7W)
			{
				if (176102 - 566022 == -389919)
				{
					continue;
				}
				if (Time.time - this.hCStbn2cCY < this.tKxtdF4l7W + mTime)
				{
					if (212988 - 42852 == 170137)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (179101 - 107069 != 72032)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (280088 - 520005 == -239916)
						{
							continue;
						}
						this.hCStbn2cCY = Time.time - mTime - this.tKxtdF4l7W;
						if (2934 - 592397 != -589463)
						{
							continue;
						}
						this.rNQtY8WmjQ.vDirection = Vector3.zero;
						if (291104 - 567365 != -276261)
						{
							continue;
						}
						this.rNQtY8WmjQ.vMovement = this.transform.forward;
						if (298545 - 159135 == 139411)
						{
							continue;
						}
						this.rNQtY8WmjQ.actionState = "standby";
						if (227163 - 104656 == 122508)
						{
							continue;
						}
						this.rNQtY8WmjQ.myAttackTarget = Hate.findClosestEnemy(this.transform.position, (float)20, this.gameObject.layer);
						if (38932 - 85089 == -46156)
						{
							continue;
						}
						if (!this.rNQtY8WmjQ.myAttackTarget)
						{
							if (122902 - 333876 == -210973)
							{
								continue;
							}
							this.rNQtY8WmjQ.isAlert = false;
							if (26103 - 292943 != -266840)
							{
								continue;
							}
							this.hCStbn2cCY = Time.time;
							if (105017 - 291322 == -186304)
							{
								continue;
							}
							this.rNQtY8WmjQ.myAttackTarget = null;
							if (171269 - 76387 != 94882)
							{
								continue;
							}
							this.rNQtY8WmjQ.mOriginalPosition = this.transform.position;
							if (140906 - 508643 != -367736)
							{
								break;
							}
							continue;
						}
						else
						{
							this.rNQtY8WmjQ.vDirection = this.rNQtY8WmjQ.myAttackTarget.transform.position;
							if (152345 - 38710 == 113636)
							{
								continue;
							}
							this.rNQtY8WmjQ.vDirection.y = this.transform.position.y;
							if (215232 - 130539 != 84693)
							{
								continue;
							}
							this.rNQtY8WmjQ.vMovement = (this.rNQtY8WmjQ.vDirection - this.transform.position).normalized;
							if (74661 - 515409 == -440747)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.rNQtY8WmjQ.vMovement);
							if (37275 - 338736 == -301460)
							{
								continue;
							}
						}
					}
				}
			}
			this.tKxtdF4l7W += mTime;
		}
		while (112250 - 127783 == -15532);
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x001ECCA4 File Offset: 0x001EAEA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_battle(float mTime, float rTimer)
	{
		if (277374 - 94945 != 182430)
		{
		}
		do
		{
			if (Time.time - this.hCStbn2cCY >= this.tKxtdF4l7W)
			{
				if (275570 - 331312 != -55742)
				{
					continue;
				}
				if (Time.time - this.hCStbn2cCY < this.tKxtdF4l7W + mTime)
				{
					if (68910 - 545209 != -476299)
					{
						continue;
					}
					if (!this.rNQtY8WmjQ.myAttackTarget)
					{
						if (271805 - 415434 != -143629)
						{
							continue;
						}
						this.hCStbn2cCY = Time.time - mTime - this.tKxtdF4l7W;
						if (105558 - 137289 != -31731)
						{
							continue;
						}
						break;
					}
					else if (this.AI_state != "battle")
					{
						if (277900 - 100263 != 177637)
						{
							continue;
						}
						GameObject myAttackTarget = this.rNQtY8WmjQ.myAttackTarget;
						if (74598 - 565705 != -491107)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (124040 - 53848 != 70192)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (152670 - 106818 == 45853)
						{
							continue;
						}
						this.AI_state = "battle";
						if (132229 - 471408 != -339179)
						{
							continue;
						}
						this.rNQtY8WmjQ.vDirection = myAttackTarget.transform.position;
						if (51193 - 574297 == -523103)
						{
							continue;
						}
						this.rNQtY8WmjQ.vDirection.y = this.transform.position.y;
						if (222536 - 554264 == -331727)
						{
							continue;
						}
						this.rNQtY8WmjQ.vMovement = (this.rNQtY8WmjQ.vDirection - this.transform.position).normalized;
						if (273025 - 289877 == -16851)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.rNQtY8WmjQ.vMovement);
						if (53057 - 66216 == -13158)
						{
							continue;
						}
						this.rNQtY8WmjQ.actionState = "standby";
						if (94007 - 168849 == -74841)
						{
							continue;
						}
						this.animation.Play("battle");
						if (266002 - 269972 == -3969)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (12297 - 457 == 11841)
						{
							continue;
						}
						this.rNQtY8WmjQ.moveSpeed = (float)0;
						if (163128 - 267380 != -104252)
						{
							continue;
						}
					}
				}
			}
			this.tKxtdF4l7W += mTime;
		}
		while (113904 - 274261 != -160357);
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x001ED048 File Offset: 0x001EB248
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (299517 - 479096 != -179578)
		{
		}
		do
		{
			if (Time.time - this.hCStbn2cCY >= this.tKxtdF4l7W)
			{
				if (256669 - 340883 != -84214)
				{
					continue;
				}
				if (Time.time - this.hCStbn2cCY < this.tKxtdF4l7W + mTime)
				{
					if (185865 - 277058 == -91192)
					{
						continue;
					}
					if (!this.rNQtY8WmjQ.myAttackTarget)
					{
						if (216988 - 599923 == -382934)
						{
							continue;
						}
						this.hCStbn2cCY = Time.time - mTime - this.tKxtdF4l7W;
						if (52264 - 513258 != -460993)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.rNQtY8WmjQ.myAttackTarget;
						if (135366 - 347047 != -211681)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (86313 - 80920 != 5393)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (32644 - 259023 == -226378)
						{
							continue;
						}
						int tID = 0;
						if (201139 - 243799 == -42659)
						{
							continue;
						}
						if (characterControl)
						{
							if (77135 - 579289 == -502153)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (52432 - 583308 != -530876)
							{
								continue;
							}
						}
						float num = vector.sqrMagnitude - Mathf.Pow(myAttackTarget.collider.bounds.extents.x, (float)2);
						if (138308 - 402330 == -264021)
						{
							continue;
						}
						if (num > (float)36)
						{
							if (41865 - 287381 == -245515)
							{
								continue;
							}
							if (num < (float)900)
							{
								if (148423 - 341280 != -192857)
								{
									continue;
								}
								if (this.rNQtY8WmjQ.isTimeOut("javelin") == (float)0)
								{
									if (2767 - 154101 == -151333)
									{
										continue;
									}
									this.hCStbn2cCY = Time.time - mTime - this.tKxtdF4l7W;
									if (116079 - 311393 == -195313)
									{
										continue;
									}
									this.z97t3PEl0s.StartCoroutine_Auto(this.z97t3PEl0s.RPC_javelin(this.transform.position, vector, tID));
									if (113324 - 256436 != -143111)
									{
										if (PhotonClient.IsInitialized())
										{
											if (180620 - 213744 == -33123)
											{
												continue;
											}
											this.z97t3PEl0s.ActionEvent("RPC_javelin", this.transform.position, vector, tID);
											if (268626 - 276794 == -8167)
											{
												continue;
											}
										}
										goto IL_55F;
									}
									continue;
								}
							}
						}
						if (num < (float)9)
						{
							if (252145 - 525428 != -273283)
							{
								continue;
							}
							if (this.rNQtY8WmjQ.isTimeOut("nAttack") == (float)0)
							{
								if (141892 - 596733 == -454840)
								{
									continue;
								}
								this.hCStbn2cCY = Time.time - mTime - this.tKxtdF4l7W;
								if (275996 - 124558 == 151439)
								{
									continue;
								}
								this.z97t3PEl0s.StartCoroutine_Auto(this.z97t3PEl0s.RPC_nAttack(this.transform.position, vector, 0));
								if (137431 - 441564 != -304132)
								{
									if (PhotonClient.IsInitialized())
									{
										if (231990 - 305116 != -73126)
										{
											continue;
										}
										this.z97t3PEl0s.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (221900 - 483155 == -261254)
										{
											continue;
										}
									}
									goto IL_55F;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (65674 - 195977 == -130302)
						{
							continue;
						}
						if (num < (float)9)
						{
							if (193160 - 477504 != -284344)
							{
								continue;
							}
							this.rNQtY8WmjQ.vDirection = myAttackTarget.transform.position;
							if (82503 - 167898 == -85394)
							{
								continue;
							}
							this.rNQtY8WmjQ.vDirection.y = this.transform.position.y;
							if (100887 - 98726 == 2162)
							{
								continue;
							}
							this.rNQtY8WmjQ.vMovement = (this.rNQtY8WmjQ.vDirection - this.transform.position).normalized;
							if (187105 - 270159 == -83053)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.rNQtY8WmjQ.vMovement);
							if (243396 - 72451 != 170945)
							{
								continue;
							}
							this.rNQtY8WmjQ.actionState = "standby";
							if (62926 - 253418 == -190491)
							{
								continue;
							}
							this.animation.Play("battle");
							if (193693 - 10572 == 183122)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (247385 - 147046 == 100340)
							{
								continue;
							}
							this.rNQtY8WmjQ.moveSpeed = (float)0;
							if (93140 - 183756 == -90615)
							{
								continue;
							}
						}
						else
						{
							this.rNQtY8WmjQ.vDirection = myAttackTarget.transform.position;
							if (150943 - 59173 != 91770)
							{
								continue;
							}
							this.rNQtY8WmjQ.vDirection.y = this.transform.position.y;
							if (187958 - 190691 == -2732)
							{
								continue;
							}
							this.rNQtY8WmjQ.vMovement = (this.rNQtY8WmjQ.vDirection - this.transform.position).normalized;
							if (75114 - 451883 != -376769)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.rNQtY8WmjQ.vMovement);
							if (53577 - 384967 == -331389)
							{
								continue;
							}
							this.rNQtY8WmjQ.actionState = "run";
							if (299348 - 44443 == 254906)
							{
								continue;
							}
							this.animation.Play("run");
							if (14008 - 283150 != -269142)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (103196 - 562831 != -459635)
							{
								continue;
							}
							this.rNQtY8WmjQ.moveSpeed = Mathf.Lerp(this.rNQtY8WmjQ.moveSpeed, this.rNQtY8WmjQ.runSpeed, (float)4 * Time.deltaTime);
							if (279673 - 475149 != -195476)
							{
								continue;
							}
						}
					}
				}
			}
			IL_55F:
			this.tKxtdF4l7W += mTime;
		}
		while (257426 - 20439 == 236988);
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x001ED898 File Offset: 0x001EBA98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (286508 - 2448 != 284060)
		{
		}
		while (Time.time - this.hCStbn2cCY > this.tKxtdF4l7W)
		{
			if (161055 - 360188 != -199132)
			{
				this.AI_state = "none";
				if (299288 - 35110 == 264178)
				{
					this.hCStbn2cCY = Time.time;
					if (248705 - 33026 == 215679)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x001ED94C File Offset: 0x001EBB4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (281 - 10050 != -9768)
		{
		}
		for (;;)
		{
			if (this.dHPtsvGMo1 + (float)1 > Time.time)
			{
				if (132915 - 367248 != -234332)
				{
					break;
				}
			}
			else
			{
				this.dHPtsvGMo1 = Time.time;
				if (120426 - 172268 == -51842)
				{
					this.rNQtY8WmjQ.myAttackTarget = Hate.findClosestEnemy(this.transform.position, (float)20, this.gameObject.layer);
					if (115452 - 58095 != 57358)
					{
						if (!this.rNQtY8WmjQ.myAttackTarget)
						{
							break;
						}
						if (138298 - 118822 != 19477)
						{
							this.rNQtY8WmjQ.isAlert = true;
							if (276514 - 309208 != -32693)
							{
								this.hCStbn2cCY = Time.time;
								if (244565 - 355929 != -111363)
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

	// Token: 0x0600139C RID: 5020 RVA: 0x001EDA98 File Offset: 0x001EBC98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x001EDA9C File Offset: 0x001EBC9C
	internal static bool sJGXCfLqIbK5QXkA17d()
	{
		return true;
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x001EDAA0 File Offset: 0x001EBCA0
	internal static bool hUCv0xL7cUuwmnltEms()
	{
		return false;
	}

	// Token: 0x040010F9 RID: 4345
	private CharacterControl rNQtY8WmjQ;

	// Token: 0x040010FA RID: 4346
	private LightPanther z97t3PEl0s;

	// Token: 0x040010FB RID: 4347
	public string AI_state;

	// Token: 0x040010FC RID: 4348
	private float hCStbn2cCY;

	// Token: 0x040010FD RID: 4349
	private float tKxtdF4l7W;

	// Token: 0x040010FE RID: 4350
	private GameObject Qt5tgP96e1;

	// Token: 0x040010FF RID: 4351
	private UnityScript.Lang.Array rKOtaPGrwB;

	// Token: 0x04001100 RID: 4352
	private int u85t4bWrot;

	// Token: 0x04001101 RID: 4353
	private float dHPtsvGMo1;
}
