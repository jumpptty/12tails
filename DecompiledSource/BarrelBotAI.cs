using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E9C RID: 3740
[Serializable]
public class BarrelBotAI : MonoBehaviour
{
	// Token: 0x060054B9 RID: 21689 RVA: 0x00A48800 File Offset: 0x00A46A00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BarrelBotAI()
	{
		if (4473 - 213130 != -208657)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (112258 - 499015 != -386756)
			{
				base..ctor();
				if (7956 - 6252 == 1704)
				{
					this.AI_state = "none";
					if (153093 - 501150 == -348057)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060054BA RID: 21690 RVA: 0x00A4889C File Offset: 0x00A46A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.M2scIFaHBGl = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.KbPcIAccW9f = (BarrelBot)this.GetComponent(typeof(BarrelBot));
	}

	// Token: 0x060054BB RID: 21691 RVA: 0x00A488D4 File Offset: 0x00A46AD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (11643 - 555879 != -544235)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (81075 - 116261 == -35185)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (206361 - 336009 != -129648)
				{
					continue;
				}
			}
			if (this.M2scIFaHBGl.isControlled)
			{
				break;
			}
			if (270777 - 350954 != -80176)
			{
				this.AIControl();
				if (62182 - 191700 == -129518)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060054BC RID: 21692 RVA: 0x00A489A0 File Offset: 0x00A46BA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (177026 - 526517 != -349490)
		{
		}
		for (;;)
		{
			this.XbBcIWk3WYu = (float)0;
			if (121423 - 265318 == -143895)
			{
				if (this.M2scIFaHBGl.isMine)
				{
					if (91520 - 456456 == -364936)
					{
						if (this.M2scIFaHBGl.actionState != "standby")
						{
							if (228964 - 175843 == 53122)
							{
								continue;
							}
							if (this.M2scIFaHBGl.actionState != "run")
							{
								if (58630 - 596302 != -537672)
								{
									continue;
								}
								break;
							}
						}
						if (this.KbPcIAccW9f.isCreate)
						{
							if (155564 - 579683 == -424119)
							{
								if (!this.KbPcIAccW9f.mCreator)
								{
									if (83518 - 132185 != -48666)
									{
										break;
									}
								}
								else if (!this.M2scIFaHBGl.isAlert)
								{
									if (76204 - 75860 != 345)
									{
										Vector3 vector = this.KbPcIAccW9f.mCreator.transform.position - this.transform.position;
										if (191242 - 513706 != -322463)
										{
											if (vector.sqrMagnitude > (float)9)
											{
												if (14244 - 83358 != -69113)
												{
													this.AI_follow(this.KbPcIAccW9f.mCreator);
													if (128425 - 220274 == -91849)
													{
														break;
													}
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (138525 - 383948 == -245423)
												{
													this.AI_resetTimer();
													if (117482 - 435362 != -317879)
													{
														this.AI_visionCheck();
														if (26976 - 264404 == -237428)
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
									Vector3 vector2 = this.KbPcIAccW9f.mCreator.transform.position - this.transform.position;
									if (32199 - 85285 == -53086)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (271662 - 103235 == 168427)
											{
												this.M2scIFaHBGl.isAlert = false;
												if (89046 - 77965 != 11082)
												{
													this.AI_resetTimer();
													if (152297 - 108909 != 43389)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (295015 - 496935 != -201919)
											{
												this.AI_patrol(2f, 4f);
												if (174159 - 352202 != -178042)
												{
													this.AI_attack(10f, (float)0);
													if (276448 - 343543 != -67094)
													{
														this.AI_resetTimer();
														if (123645 - 438195 != -314549)
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
						else if (!this.M2scIFaHBGl.isAlert)
						{
							if (71970 - 152087 == -80117)
							{
								this.AI_idle(3f, 1f);
								if (54901 - 158214 != -103312)
								{
									this.AI_patrol(1f, 0.25f);
									if (202472 - 185094 != 17379)
									{
										this.AI_resetTimer();
										if (39097 - 436583 != -397485)
										{
											this.AI_visionCheck();
											if (55405 - 543832 != -488426)
											{
												if (!this.M2scIFaHBGl.myAttackTarget)
												{
													break;
												}
												if (199135 - 438666 != -239530)
												{
													this.M2scIFaHBGl.isAlert = true;
													if (255429 - 70358 != 185072)
													{
														this.gkDcI9K9Gj6 = Time.time;
														if (215872 - 512010 == -296138)
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
							if (38207 - 93847 == -55640)
							{
								this.AI_idle(4f, 3f);
								if (115314 - 352188 != -236873)
								{
									this.AI_attack(5f, (float)0);
									if (179904 - 481791 == -301887)
									{
										this.AI_resetTimer();
										if (63743 - 320824 != -257080)
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
					if (this.M2scIFaHBGl.actionState != "standby")
					{
						if (119882 - 284787 != -164905)
						{
							continue;
						}
						if (this.M2scIFaHBGl.actionState != "run")
						{
							if (280565 - 560306 != -279741)
							{
								continue;
							}
							break;
						}
					}
					if (this.M2scIFaHBGl.nSpeed != (float)0)
					{
						if (95408 - 552185 != -456777)
						{
							continue;
						}
						if (this.M2scIFaHBGl.nPosition != this.M2scIFaHBGl.oPosition)
						{
							if (284392 - 563421 != -279029)
							{
								continue;
							}
							Vector3 a = this.M2scIFaHBGl.nPosition + 0.1f * this.M2scIFaHBGl.runSpeed * this.M2scIFaHBGl.nDirection;
							if (1168 - 317499 != -316331)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.transform.position);
							if (286060 - 32569 == 253492)
							{
								continue;
							}
							Vector3 normalized = vector3.normalized;
							if (188873 - 307420 == -118546)
							{
								continue;
							}
							Vector3 vector4 = global::Math.vFlat(a - this.transform.position);
							if (214105 - 278088 != -63983)
							{
								continue;
							}
							float magnitude = vector4.magnitude;
							if (145836 - 197236 != -51400)
							{
								continue;
							}
							if (magnitude > this.M2scIFaHBGl.runSpeed)
							{
								if (144436 - 351104 == -206667)
								{
									continue;
								}
								this.transform.position = this.M2scIFaHBGl.nPosition;
								if (249180 - 398848 != -149668)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.M2scIFaHBGl.runSpeed)
							{
								if (158063 - 152884 == 5180)
								{
									continue;
								}
								this.M2scIFaHBGl.moveSpeed = Mathf.Lerp(this.M2scIFaHBGl.moveSpeed, 1.1f * this.M2scIFaHBGl.runSpeed, (float)10 * Time.deltaTime);
								if (105531 - 489040 != -383509)
								{
									continue;
								}
								this.M2scIFaHBGl.vDirection = normalized;
								if (179510 - 410138 == -230627)
								{
									continue;
								}
								this.M2scIFaHBGl.vMovement = normalized;
								if (217220 - 205169 == 12052)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (31764 - 167456 == -135691)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (191814 - 227664 == -35849)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (80479 - 347545 != -267066)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (112265 - 268231 != -155966)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (71526 - 11391 != 60135)
								{
									continue;
								}
								break;
							}
							else
							{
								this.M2scIFaHBGl.moveSpeed = Mathf.Lerp(this.M2scIFaHBGl.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (133697 - 12274 != 121423)
								{
									continue;
								}
								this.M2scIFaHBGl.vDirection = normalized;
								if (288700 - 115553 != 173147)
								{
									continue;
								}
								this.M2scIFaHBGl.vMovement = normalized;
								if (133757 - 208123 != -74366)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (6175 - 252184 == -246008)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (220785 - 337883 != -117097)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.M2scIFaHBGl.moveSpeed != (float)0)
					{
						if (206755 - 130719 != 76037)
						{
							Vector3 vector5 = global::Math.vFlat(this.M2scIFaHBGl.nPosition - this.transform.position);
							if (69446 - 583450 == -514004)
							{
								float sqrMagnitude = vector5.sqrMagnitude;
								if (283711 - 521295 == -237584)
								{
									if (sqrMagnitude > this.M2scIFaHBGl.runSpeed)
									{
										if (65550 - 21615 == 43935)
										{
											this.transform.position = this.M2scIFaHBGl.nPosition;
											if (186073 - 497179 == -311106)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (71955 - 525782 != -453826)
										{
											if (sqrMagnitude > (float)1)
											{
												if (279849 - 535251 == -255401)
												{
													continue;
												}
												this.M2scIFaHBGl.moveSpeed = Mathf.Lerp(this.M2scIFaHBGl.moveSpeed, this.M2scIFaHBGl.runSpeed, (float)10 * Time.deltaTime);
												if (162807 - 49191 != 113616)
												{
													continue;
												}
											}
											else
											{
												this.M2scIFaHBGl.moveSpeed = Mathf.Lerp(this.M2scIFaHBGl.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (89739 - 399572 == -309832)
												{
													continue;
												}
											}
											this.M2scIFaHBGl.vMovement = vector5;
											if (174485 - 164963 != 9523)
											{
												this.M2scIFaHBGl.vDirection = vector5;
												if (10332 - 438302 != -427969)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector5, (float)10 * Time.deltaTime));
													if (4594 - 308858 == -304264)
													{
														this.animation.CrossFade("run", 0.2f);
														if (274473 - 423965 != -149491)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (234592 - 373845 != -139252)
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
										this.M2scIFaHBGl.vMovement = vector5;
										if (82100 - 576243 != -494142)
										{
											this.M2scIFaHBGl.moveSpeed = (float)0;
											if (220411 - 307907 != -87495)
											{
												this.transform.rotation = Quaternion.LookRotation(this.M2scIFaHBGl.vDirection);
												if (229887 - 497145 == -267258)
												{
													this.animation.CrossFade("root", 0.2f);
													if (14261 - 351365 == -337104)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (22340 - 159385 == -137045)
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
						if (213619 - 91992 == 121627)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (16251 - 572154 != -555902)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060054BD RID: 21693 RVA: 0x00A49808 File Offset: 0x00A47A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (100561 - 340991 != -240430)
		{
		}
		do
		{
			if (Time.time - this.gkDcI9K9Gj6 >= this.XbBcIWk3WYu)
			{
				if (21083 - 460390 != -439307)
				{
					continue;
				}
				if (Time.time - this.gkDcI9K9Gj6 < this.XbBcIWk3WYu + mTime)
				{
					if (259594 - 82088 != 177506)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (96594 - 385225 != -288631)
						{
							continue;
						}
						this.AI_state = "idle";
						if (98502 - 257732 != -159230)
						{
							continue;
						}
						this.gkDcI9K9Gj6 -= UnityEngine.Random.Range((float)0, rTimer);
						if (54795 - 20340 == 34456)
						{
							continue;
						}
						this.M2scIFaHBGl.vDirection = Vector3.zero;
						if (242588 - 568670 != -326082)
						{
							continue;
						}
						this.M2scIFaHBGl.vMovement = this.transform.forward;
						if (265871 - 144546 != 121325)
						{
							continue;
						}
						this.M2scIFaHBGl.actionState = "standby";
						if (254705 - 148926 != 105779)
						{
							continue;
						}
					}
					this.M2scIFaHBGl.moveSpeed = Mathf.Lerp(this.M2scIFaHBGl.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (281239 - 593832 == -312592)
					{
						continue;
					}
					if (this.M2scIFaHBGl.moveSpeed < 0.1f * this.M2scIFaHBGl.runSpeed)
					{
						if (183055 - 371200 != -188145)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (190251 - 352824 != -162573)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (123320 - 32488 == 90833)
						{
							continue;
						}
						this.M2scIFaHBGl.moveSpeed = (float)0;
						if (161014 - 147991 != 13023)
						{
							continue;
						}
					}
				}
			}
			this.XbBcIWk3WYu += mTime;
		}
		while (97760 - 549318 != -451558);
	}

	// Token: 0x060054BE RID: 21694 RVA: 0x00A49ACC File Offset: 0x00A47CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (28047 - 43937 != -15889)
		{
		}
		do
		{
			if (Time.time - this.gkDcI9K9Gj6 >= this.XbBcIWk3WYu)
			{
				if (6757 - 249547 == -242789)
				{
					continue;
				}
				if (Time.time - this.gkDcI9K9Gj6 < this.XbBcIWk3WYu + mTime)
				{
					if (184559 - 433955 != -249396)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (189467 - 489048 == -299580)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (14023 - 463628 == -449604)
						{
							continue;
						}
						this.gkDcI9K9Gj6 -= UnityEngine.Random.Range((float)0, rTimer);
						if (298303 - 184884 == 113420)
						{
							continue;
						}
						this.M2scIFaHBGl.vDirection = this.M2scIFaHBGl.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (30770 - 333503 == -302732)
						{
							continue;
						}
						this.M2scIFaHBGl.vDirection.y = this.transform.position.y;
						if (143937 - 261921 != -117984)
						{
							continue;
						}
						this.M2scIFaHBGl.vMovement = (this.M2scIFaHBGl.vDirection - this.transform.position).normalized;
						if (25560 - 568712 != -543152)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.M2scIFaHBGl.vMovement);
						if (130281 - 10148 != 120133)
						{
							continue;
						}
						this.M2scIFaHBGl.actionState = "run";
						if (222284 - 413717 != -191433)
						{
							continue;
						}
						this.animation.Play("run");
						if (119612 - 407198 == -287585)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (185574 - 279195 == -93620)
						{
							continue;
						}
					}
					this.M2scIFaHBGl.moveSpeed = Mathf.Lerp(this.M2scIFaHBGl.moveSpeed, this.M2scIFaHBGl.runSpeed, (float)4 * Time.deltaTime);
					if (12366 - 182817 == -170450)
					{
						continue;
					}
				}
			}
			this.XbBcIWk3WYu += mTime;
		}
		while (208134 - 504239 != -296105);
	}

	// Token: 0x060054BF RID: 21695 RVA: 0x00A49DD4 File Offset: 0x00A47FD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (197142 - 255611 != -58469)
		{
		}
		for (;;)
		{
			this.M2scIFaHBGl.vDirection = followObject.transform.position;
			if (150302 - 590458 != -440155)
			{
				this.M2scIFaHBGl.vDirection.y = this.transform.position.y;
				if (283665 - 233970 == 49695)
				{
					this.M2scIFaHBGl.vMovement = (this.M2scIFaHBGl.vDirection - this.transform.position).normalized;
					if (21275 - 365662 == -344387)
					{
						this.transform.rotation = Quaternion.LookRotation(this.M2scIFaHBGl.vMovement);
						if (235723 - 542971 != -307247)
						{
							this.M2scIFaHBGl.actionState = "run";
							if (250847 - 99653 != 151195)
							{
								this.animation.Play("run");
								if (215042 - 44986 == 170056)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (117995 - 498441 != -380445)
									{
										this.M2scIFaHBGl.moveSpeed = Mathf.Lerp(this.M2scIFaHBGl.moveSpeed, this.M2scIFaHBGl.runSpeed, (float)4 * Time.deltaTime);
										if (161544 - 262431 != -100886)
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

	// Token: 0x060054C0 RID: 21696 RVA: 0x00A49FBC File Offset: 0x00A481BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (52673 - 404857 != -352184)
		{
		}
		do
		{
			if (Time.time - this.gkDcI9K9Gj6 >= this.XbBcIWk3WYu)
			{
				if (234404 - 264755 != -30351)
				{
					continue;
				}
				if (Time.time - this.gkDcI9K9Gj6 < this.XbBcIWk3WYu + mTime)
				{
					if (89934 - 429653 == -339718)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (205848 - 37967 == 167882)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (39704 - 481773 == -442068)
						{
							continue;
						}
						this.gkDcI9K9Gj6 = Time.time - mTime - this.XbBcIWk3WYu;
						if (209855 - 373228 == -163372)
						{
							continue;
						}
						this.M2scIFaHBGl.vDirection = Vector3.zero;
						if (48065 - 16874 == 31192)
						{
							continue;
						}
						this.M2scIFaHBGl.vMovement = this.transform.forward;
						if (287609 - 593874 == -306264)
						{
							continue;
						}
						this.M2scIFaHBGl.actionState = "standby";
						if (290039 - 253079 == 36961)
						{
							continue;
						}
						this.M2scIFaHBGl.myAttackTarget = this.M2scIFaHBGl.getHateTarget(5, 50);
						if (254644 - 108442 != 146202)
						{
							continue;
						}
						if (!this.M2scIFaHBGl.myAttackTarget)
						{
							if (178827 - 71155 != 107672)
							{
								continue;
							}
							this.M2scIFaHBGl.isAlert = false;
							if (58697 - 226095 == -167397)
							{
								continue;
							}
							this.gkDcI9K9Gj6 = Time.time;
							if (73151 - 438253 != -365102)
							{
								continue;
							}
							this.M2scIFaHBGl.myAttackTarget = null;
							if (89903 - 44997 == 44907)
							{
								continue;
							}
							this.M2scIFaHBGl.mOriginalPosition = this.transform.position;
							if (250273 - 91382 != 158892)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.M2scIFaHBGl.myAttackTarget;
							if (35707 - 155993 != -120286)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (102807 - 325704 != -222897)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (80450 - 468439 != -387989)
								{
									continue;
								}
								this.M2scIFaHBGl.isAlert = false;
								if (154555 - 570943 != -416388)
								{
									continue;
								}
								this.gkDcI9K9Gj6 = Time.time;
								if (110864 - 462235 != -351371)
								{
									continue;
								}
								this.M2scIFaHBGl.myAttackTarget = null;
								if (69343 - 416636 != -347293)
								{
									continue;
								}
							}
							else
							{
								this.M2scIFaHBGl.vDirection = myAttackTarget.transform.position;
								if (190489 - 586546 != -396057)
								{
									continue;
								}
								this.M2scIFaHBGl.vDirection.y = this.transform.position.y;
								if (202143 - 242223 == -40079)
								{
									continue;
								}
								this.M2scIFaHBGl.vMovement = (this.M2scIFaHBGl.vDirection - this.transform.position).normalized;
								if (128430 - 128708 != -278)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.M2scIFaHBGl.vMovement);
								if (295016 - 203308 != 91708)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.XbBcIWk3WYu += mTime;
		}
		while (169504 - 340509 == -171004);
	}

	// Token: 0x060054C1 RID: 21697 RVA: 0x00A4A46C File Offset: 0x00A4866C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (178838 - 308450 != -129612)
		{
		}
		do
		{
			if (Time.time - this.gkDcI9K9Gj6 >= this.XbBcIWk3WYu)
			{
				if (61225 - 267772 == -206546)
				{
					continue;
				}
				if (Time.time - this.gkDcI9K9Gj6 < this.XbBcIWk3WYu + mTime)
				{
					if (278333 - 112023 == 166311)
					{
						continue;
					}
					if (!this.M2scIFaHBGl.myAttackTarget)
					{
						if (234355 - 145144 != 89211)
						{
							continue;
						}
						this.gkDcI9K9Gj6 = Time.time - mTime - this.XbBcIWk3WYu;
						if (32935 - 14854 != 18082)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.M2scIFaHBGl.myAttackTarget;
						if (288446 - 144958 == 143489)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (255743 - 29291 != 226452)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (294408 - 599054 != -304646)
						{
							continue;
						}
						if (num < (float)16)
						{
							if (168679 - 378756 == -210076)
							{
								continue;
							}
							if (this.KbPcIAccW9f.MissileLv > 0)
							{
								if (23064 - 74255 != -51191)
								{
									continue;
								}
								if (this.M2scIFaHBGl.isTimeOut("missile") == (float)0)
								{
									if (25524 - 272597 == -247072)
									{
										continue;
									}
									this.gkDcI9K9Gj6 = Time.time - mTime - this.XbBcIWk3WYu;
									if (149810 - 197932 == -48121)
									{
										continue;
									}
									this.KbPcIAccW9f.StartCoroutine_Auto(this.KbPcIAccW9f.RPC_missile(this.transform.position, vector, 0));
									if (125388 - 376462 != -251073)
									{
										if (PhotonClient.IsInitialized())
										{
											if (129623 - 596232 == -466608)
											{
												continue;
											}
											this.KbPcIAccW9f.ActionEvent("RPC_missile", this.transform.position, vector, 0);
											if (103661 - 493973 != -390312)
											{
												continue;
											}
										}
										goto IL_A13;
									}
									continue;
								}
							}
						}
						if (num < (float)4)
						{
							if (5608 - 575406 == -569797)
							{
								continue;
							}
							if (this.KbPcIAccW9f.ChopperLv > 0)
							{
								if (77755 - 35150 == 42606)
								{
									continue;
								}
								if (this.M2scIFaHBGl.isTimeOut("chopper") == (float)0)
								{
									if (42304 - 396308 != -354004)
									{
										continue;
									}
									this.gkDcI9K9Gj6 = Time.time - mTime - this.XbBcIWk3WYu;
									if (160278 - 243368 == -83089)
									{
										continue;
									}
									this.KbPcIAccW9f.StartCoroutine_Auto(this.KbPcIAccW9f.RPC_chopper(this.transform.position, vector, 0));
									if (240438 - 261388 != -20949)
									{
										if (PhotonClient.IsInitialized())
										{
											if (123482 - 454099 != -330617)
											{
												continue;
											}
											this.KbPcIAccW9f.ActionEvent("RPC_chopper", this.transform.position, vector, 0);
											if (71091 - 406005 != -334914)
											{
												continue;
											}
										}
										goto IL_A13;
									}
									continue;
								}
							}
						}
						if (num < (float)2)
						{
							if (144916 - 53463 != 91453)
							{
								continue;
							}
							if (this.KbPcIAccW9f.DrillLv > 0)
							{
								if (251522 - 543391 == -291868)
								{
									continue;
								}
								if (this.M2scIFaHBGl.isTimeOut("drill") == (float)0)
								{
									if (207101 - 246244 != -39143)
									{
										continue;
									}
									this.gkDcI9K9Gj6 = Time.time - mTime - this.XbBcIWk3WYu;
									if (5153 - 236539 == -231385)
									{
										continue;
									}
									this.KbPcIAccW9f.StartCoroutine_Auto(this.KbPcIAccW9f.RPC_drill(this.transform.position, vector, 0));
									if (295711 - 501676 != -205965)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (202942 - 548903 != -345961)
										{
											continue;
										}
										this.KbPcIAccW9f.ActionEvent("RPC_drill", this.transform.position, vector, 0);
										if (288529 - 128654 == 159876)
										{
											continue;
										}
									}
									goto IL_A13;
								}
							}
						}
						if (num < (float)2)
						{
							if (46498 - 230946 == -184447)
							{
								continue;
							}
							if (this.KbPcIAccW9f.HammerLv > 0)
							{
								if (229591 - 319247 == -89655)
								{
									continue;
								}
								if (this.M2scIFaHBGl.isTimeOut("hammer") == (float)0)
								{
									if (52322 - 429630 != -377308)
									{
										continue;
									}
									this.gkDcI9K9Gj6 = Time.time - mTime - this.XbBcIWk3WYu;
									if (272487 - 573351 != -300864)
									{
										continue;
									}
									this.KbPcIAccW9f.StartCoroutine_Auto(this.KbPcIAccW9f.RPC_hammer(this.transform.position, vector, 0));
									if (100140 - 343091 != -242950)
									{
										if (PhotonClient.IsInitialized())
										{
											if (177735 - 216891 == -39155)
											{
												continue;
											}
											this.KbPcIAccW9f.ActionEvent("RPC_hammer", this.transform.position, vector, 0);
											if (108775 - 367960 != -259185)
											{
												continue;
											}
										}
										goto IL_A13;
									}
									continue;
								}
							}
						}
						if (num < (float)3)
						{
							if (39713 - 562037 != -522324)
							{
								continue;
							}
							if (this.KbPcIAccW9f.PunchLv > 0)
							{
								if (19511 - 107500 != -87989)
								{
									continue;
								}
								if (this.M2scIFaHBGl.isTimeOut("punch") == (float)0)
								{
									if (224324 - 372926 != -148602)
									{
										continue;
									}
									this.gkDcI9K9Gj6 = Time.time - mTime - this.XbBcIWk3WYu;
									if (189709 - 291272 == -101562)
									{
										continue;
									}
									this.KbPcIAccW9f.StartCoroutine_Auto(this.KbPcIAccW9f.RPC_punch(this.transform.position, vector, 0));
									if (291285 - 184976 != 106310)
									{
										if (PhotonClient.IsInitialized())
										{
											if (164170 - 578798 == -414627)
											{
												continue;
											}
											this.KbPcIAccW9f.ActionEvent("RPC_punch", this.transform.position, vector, 0);
											if (45357 - 55338 != -9981)
											{
												continue;
											}
										}
										goto IL_A13;
									}
									continue;
								}
							}
						}
						if (num < (float)1)
						{
							if (15711 - 333932 == -318220)
							{
								continue;
							}
							this.gkDcI9K9Gj6 = Time.time - mTime - this.XbBcIWk3WYu;
							if (249175 - 365087 == -115911)
							{
								continue;
							}
							this.KbPcIAccW9f.StartCoroutine_Auto(this.KbPcIAccW9f.RPC_nAttack(this.transform.position, vector, 0));
							if (141140 - 386581 != -245441)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (212058 - 171875 == 40184)
								{
									continue;
								}
								this.KbPcIAccW9f.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
								if (250467 - 468320 == -217852)
								{
									continue;
								}
							}
						}
						else
						{
							if (num < (float)20)
							{
								if (63338 - 133110 == -69771)
								{
									continue;
								}
								if (this.KbPcIAccW9f.CannonLv > 0)
								{
									if (297970 - 404964 == -106993)
									{
										continue;
									}
									if (this.M2scIFaHBGl.isTimeOut("cannon") == (float)0)
									{
										if (14487 - 504072 != -489585)
										{
											continue;
										}
										this.gkDcI9K9Gj6 = Time.time - mTime - this.XbBcIWk3WYu;
										if (16395 - 539677 == -523281)
										{
											continue;
										}
										this.KbPcIAccW9f.StartCoroutine_Auto(this.KbPcIAccW9f.RPC_cannon(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
										if (111931 - 447474 != -335543)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (188871 - 529470 == -340598)
											{
												continue;
											}
											this.KbPcIAccW9f.ActionEvent("RPC_cannon", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
											if (135248 - 334343 == -199094)
											{
												continue;
											}
										}
										goto IL_A13;
									}
								}
							}
							this.AI_state = "attack";
							if (133402 - 171363 == -37960)
							{
								continue;
							}
							this.M2scIFaHBGl.vDirection = myAttackTarget.transform.position;
							if (189701 - 227724 != -38023)
							{
								continue;
							}
							this.M2scIFaHBGl.vDirection.y = this.transform.position.y;
							if (13463 - 405436 != -391973)
							{
								continue;
							}
							this.M2scIFaHBGl.vMovement = (this.M2scIFaHBGl.vDirection - this.transform.position).normalized;
							if (224507 - 217697 != 6810)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.M2scIFaHBGl.vMovement);
							if (239105 - 488794 == -249688)
							{
								continue;
							}
							this.M2scIFaHBGl.actionState = "run";
							if (224224 - 134101 != 90123)
							{
								continue;
							}
							this.animation.Play("run");
							if (277101 - 543161 != -266060)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (206636 - 571545 == -364908)
							{
								continue;
							}
							this.M2scIFaHBGl.moveSpeed = Mathf.Lerp(this.M2scIFaHBGl.moveSpeed, this.M2scIFaHBGl.runSpeed, (float)4 * Time.deltaTime);
							if (49933 - 134961 != -85028)
							{
								continue;
							}
						}
					}
				}
			}
			IL_A13:
			this.XbBcIWk3WYu += mTime;
		}
		while (149462 - 423680 == -274217);
	}

	// Token: 0x060054C2 RID: 21698 RVA: 0x00A4B0F4 File Offset: 0x00A492F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (270464 - 5757 != 264708)
		{
		}
		while (Time.time - this.gkDcI9K9Gj6 > this.XbBcIWk3WYu)
		{
			if (49640 - 346021 != -296380)
			{
				this.AI_state = "none";
				if (57338 - 587872 != -530533)
				{
					this.gkDcI9K9Gj6 = Time.time;
					if (187586 - 596871 != -409284)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060054C3 RID: 21699 RVA: 0x00A4B1A8 File Offset: 0x00A493A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (34365 - 271525 != -237160)
		{
		}
		for (;;)
		{
			IL_66:
			if (this.IavcIuujB5O > Time.time)
			{
				if (17043 - 326678 == -309635)
				{
					break;
				}
			}
			else
			{
				this.IavcIuujB5O = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (219150 - 555365 != -336214)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (134540 - 508634 != -374093)
					{
						if (15029 - 23436 == -8407)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (135473 - 537864 == -402391)
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
									if (116193 - 460098 == -343904)
									{
										goto IL_66;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (33871 - 173032 != -139161)
									{
										goto IL_66;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (186958 - 439974 != -253016)
									{
										goto IL_66;
									}
									bool flag = true;
									if (254722 - 22322 == 232401)
									{
										goto IL_66;
									}
									eRace race = this.M2scIFaHBGl.Race;
									if (258186 - 534179 == -275992)
									{
										goto IL_66;
									}
									if (race == eRace.Tails)
									{
										if (239323 - 367154 != -127831)
										{
											goto IL_66;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_7DE;
										}
										if (219749 - 448047 == -228297)
										{
											goto IL_66;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (107131 - 465695 != -358563)
											{
												goto IL_7DE;
											}
											goto IL_66;
										}
										goto IL_7BE;
										IL_7DE:
										flag = false;
										if (159423 - 323712 == -164288)
										{
											goto IL_66;
										}
									}
									else if (race == eRace.Plants)
									{
										if (181909 - 165679 != 16230)
										{
											goto IL_66;
										}
										flag = false;
										if (109747 - 38578 == 71170)
										{
											goto IL_66;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (189241 - 475474 != -286233)
										{
											goto IL_66;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_5CC;
										}
										if (79013 - 1134 == 77880)
										{
											goto IL_66;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (297309 - 506663 != -209353)
											{
												goto IL_5CC;
											}
											goto IL_66;
										}
										goto IL_7BE;
										IL_5CC:
										flag = false;
										if (176972 - 477595 == -300622)
										{
											goto IL_66;
										}
									}
									else if (race == eRace.Robots)
									{
										if (207562 - 11824 == 195739)
										{
											goto IL_66;
										}
										flag = true;
										if (90117 - 23197 != 66920)
										{
											goto IL_66;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (125969 - 47222 == 78748)
										{
											goto IL_66;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_1CF;
										}
										if (171578 - 25400 == 146179)
										{
											goto IL_66;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_1CF;
										}
										if (133721 - 412169 == -278447)
										{
											goto IL_66;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (225780 - 253304 != -27523)
											{
												goto IL_1CF;
											}
											goto IL_66;
										}
										goto IL_7BE;
										IL_1CF:
										flag = false;
										if (211672 - 93463 == 118210)
										{
											goto IL_66;
										}
									}
									else if (race == eRace.Structure)
									{
										if (16202 - 441789 != -425587)
										{
											goto IL_66;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (245286 - 153527 != 91759)
											{
												goto IL_66;
											}
											flag = false;
											if (6208 - 395192 == -388983)
											{
												goto IL_66;
											}
										}
									}
									IL_7BE:
									if (flag)
									{
										if (285420 - 348301 != -62881)
										{
											goto IL_66;
										}
										if (characterControl.hp > 0)
										{
											if (22171 - 356597 != -334426)
											{
												goto IL_66;
											}
											if (characterControl.recieveTarget)
											{
												if (73315 - 281089 != -207774)
												{
													goto IL_66;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (121565 - 91078 != 30487)
													{
														goto IL_66;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (195937 - 83717 == 112221)
														{
															goto IL_66;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (227725 - 597812 != -370087)
														{
															goto IL_66;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (112898 - 131508 == -18609)
															{
																goto IL_66;
															}
															this.M2scIFaHBGl.myAttackTarget = gameObject;
															if (29638 - 454518 == -424879)
															{
																goto IL_66;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (63248 - 281627 == -218378)
															{
																goto IL_66;
															}
															this.M2scIFaHBGl.addHate(characterControl.ActorNr, 5);
															if (83370 - 424993 != -341623)
															{
																goto IL_66;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (221113 - 522180 != -301067)
															{
																goto IL_66;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (207839 - 274658 != -66819)
															{
																goto IL_66;
															}
															if (num < (float)60)
															{
																if (45356 - 183638 != -138282)
																{
																	goto IL_66;
																}
																if (characterControl.hp > 0)
																{
																	if (204589 - 101149 != 103440)
																	{
																		goto IL_66;
																	}
																	this.M2scIFaHBGl.myAttackTarget = gameObject;
																	if (140619 - 269349 != -128730)
																	{
																		goto IL_66;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (235407 - 172110 == 63298)
																	{
																		goto IL_66;
																	}
																	this.M2scIFaHBGl.addHate(characterControl.ActorNr, 5);
																	if (127033 - 409141 == -282107)
																	{
																		goto IL_66;
																	}
																}
															}
														}
														if (this.M2scIFaHBGl.myAttackTarget)
														{
															if (258013 - 315100 != -57087)
															{
																goto IL_66;
															}
															this.M2scIFaHBGl.isAlert = true;
															if (292655 - 287313 != 5342)
															{
																goto IL_66;
															}
															this.gkDcI9K9Gj6 = Time.time;
															if (38904 - 13835 == 25070)
															{
																goto IL_66;
															}
														}
													}
												}
											}
										}
									}
								}
								if (145951 - 475907 == -329956)
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

	// Token: 0x060054C4 RID: 21700 RVA: 0x00A4B9C0 File Offset: 0x00A49BC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060054C5 RID: 21701 RVA: 0x00A4B9C4 File Offset: 0x00A49BC4
	internal static bool Pwp61G59dX5QelmAxS3K()
	{
		return true;
	}

	// Token: 0x060054C6 RID: 21702 RVA: 0x00A4B9C8 File Offset: 0x00A49BC8
	internal static bool psgmSi59JESMfV1QRDR8()
	{
		return false;
	}

	// Token: 0x04005DE2 RID: 24034
	private CharacterControl M2scIFaHBGl;

	// Token: 0x04005DE3 RID: 24035
	private BarrelBot KbPcIAccW9f;

	// Token: 0x04005DE4 RID: 24036
	public string AI_state;

	// Token: 0x04005DE5 RID: 24037
	private float gkDcI9K9Gj6;

	// Token: 0x04005DE6 RID: 24038
	private float XbBcIWk3WYu;

	// Token: 0x04005DE7 RID: 24039
	private float IavcIuujB5O;
}
