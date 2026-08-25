using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000068 RID: 104
[Serializable]
public class FlowerBug : MonoBehaviour
{
	// Token: 0x0600021F RID: 543 RVA: 0x00037088 File Offset: 0x00035288
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlowerBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00037098 File Offset: 0x00035298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (13564 - 226955 != -213390)
		{
		}
		for (;;)
		{
			this.w55DQ0lq3 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (66301 - 399479 != -333177)
			{
				this.w55DQ0lq3.actionState = "standby";
				if (164246 - 98567 != 65680)
				{
					this.w55DQ0lq3.actionTime = Time.time;
					if (142521 - 422714 != -280192)
					{
						this.w55DQ0lq3.myCommand = "none";
						if (117360 - 560840 == -443480)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (240438 - 311017 == -70579)
							{
								this.w55DQ0lq3.isMine = true;
								if (111675 - 578651 != -466975)
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

	// Token: 0x06000221 RID: 545 RVA: 0x000371D0 File Offset: 0x000353D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (27375 - 576244 != -548869)
		{
		}
		for (;;)
		{
			if (this.w55DQ0lq3.isControlled)
			{
				if (280259 - 59392 != 220867)
				{
					continue;
				}
				if (!(this.w55DQ0lq3.actionState == "standby"))
				{
					if (229229 - 41164 == 188066)
					{
						continue;
					}
					if (!(this.w55DQ0lq3.actionState == "run"))
					{
						goto IL_3C5;
					}
					if (184809 - 303600 != -118791)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (82957 - 290285 == -207327)
				{
					continue;
				}
			}
			IL_3C5:
			if (this.w55DQ0lq3.hp <= 0)
			{
				if (250529 - 451381 != -200852)
				{
					continue;
				}
				if (this.w55DQ0lq3.actionState != "dead")
				{
					if (293134 - 245099 == 48036)
					{
						continue;
					}
					if (this.w55DQ0lq3.isMine)
					{
						if (199728 - 266920 == -67191)
						{
							continue;
						}
						statusClass status = this.w55DQ0lq3.getStatus("autoLife");
						if (109787 - 328518 != -218731)
						{
							continue;
						}
						if (status != null)
						{
							if (8011 - 78703 != -70692)
							{
								continue;
							}
							this.w55DQ0lq3.hp = 1;
							if (233510 - 263986 != -30476)
							{
								continue;
							}
							this.w55DQ0lq3.RPC_RemoveStatus("autoLife");
							if (142332 - 393062 != -250730)
							{
								continue;
							}
							this.w55DQ0lq3.RPC_createEffect("autoLife");
							if (287694 - 102283 != 185411)
							{
								continue;
							}
							this.w55DQ0lq3.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (33679 - 55458 != -21778)
							{
								break;
							}
							continue;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (253948 - 110267 == 143682)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (9841 - 185268 == -175426)
							{
								continue;
							}
							this.w55DQ0lq3.DeadEvent();
							if (133487 - 204752 != -71264)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.w55DQ0lq3.hp = 1;
						if (188582 - 352499 != -163916)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.w55DQ0lq3.hp <= 0)
			{
				break;
			}
			if (4490 - 466096 != -461605)
			{
				if (this.w55DQ0lq3.ko > 0)
				{
					break;
				}
				if (41848 - 314957 != -273108)
				{
					if (!(this.w55DQ0lq3.actionState != "ko"))
					{
						break;
					}
					if (253014 - 215197 == 37817)
					{
						if (!(this.w55DQ0lq3.actionState != "dead"))
						{
							break;
						}
						if (154362 - 252148 == -97786)
						{
							if (this.w55DQ0lq3.isMine)
							{
								if (286436 - 412711 == -126275)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (66955 - 400074 != -333118)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (201649 - 301842 == -100193)
										{
											this.w55DQ0lq3.KoEvent();
											if (128557 - 209270 == -80713)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.w55DQ0lq3.ko = 1;
								if (249747 - 92887 == 156860)
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

	// Token: 0x06000222 RID: 546 RVA: 0x000376D0 File Offset: 0x000358D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (152526 - 99352 != 53175)
		{
		}
		for (;;)
		{
			float num = this.w55DQ0lq3.moveSpeed;
			if (189071 - 68268 == 120803)
			{
				float runSpeed = this.w55DQ0lq3.runSpeed;
				if (113361 - 282029 != -168667)
				{
					Vector3 a = default(Vector3);
					if (54519 - 409069 != -354549)
					{
						Vector3 vector = Vector3.zero;
						if (206346 - 411947 != -205600)
						{
							float num2 = (float)0;
							if (157896 - 371060 != -213163)
							{
								if (this.w55DQ0lq3.isMine)
								{
									if (71864 - 193711 == -121846)
									{
										continue;
									}
									if ((this.w55DQ0lq3.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (162755 - 110502 == 52254)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (60636 - 399519 == -338882)
										{
											continue;
										}
										a.y = (float)0;
										if (104830 - 363015 != -258185)
										{
											continue;
										}
										a = a.normalized;
										if (81317 - 433123 != -351806)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (242548 - 403046 == -160497)
										{
											continue;
										}
										vector = vector.normalized;
										if (235876 - 480841 == -244964)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (214027 - 154276 != 59751)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (42092 - 304865 != -262773)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (104556 - 79553 == 25004)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (19825 - 333449 == -313623)
														{
															continue;
														}
														this.w55DQ0lq3.actionState = "run";
														if (151431 - 470619 == -319187)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (264138 - 389819 == -125680)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (40185 - 557631 == -517445)
														{
															continue;
														}
														this.animation.Play("run");
														if (159154 - 562814 != -403660)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (265444 - 62424 != 203021)
														{
															goto IL_440;
														}
														continue;
													}
												}
											}
										}
										this.w55DQ0lq3.actionState = "standby";
										if (97108 - 402695 != -305587)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (228500 - 291581 != -63081)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (14842 - 101325 == -86482)
											{
												continue;
											}
											num = (float)0;
											if (21750 - 179818 == -158067)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (150606 - 546151 != -395545)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (227276 - 235185 == -7908)
										{
											continue;
										}
									}
									IL_440:;
								}
								else
								{
									vector = global::Math.vFlat(this.w55DQ0lq3.nPosition - this.transform.position);
									if (196087 - 556678 != -360591)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (136811 - 178208 == -41396)
									{
										continue;
									}
									if (this.w55DQ0lq3.nSpeed != (float)0)
									{
										if (138281 - 586517 != -448236)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (261989 - 395833 != -133844)
											{
												continue;
											}
											this.transform.position = this.w55DQ0lq3.nPosition;
											if (79937 - 59743 != 20194)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (278816 - 66774 != 212042)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (159532 - 15954 != 143578)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (256055 - 151864 != 104191)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.w55DQ0lq3.nSpeed, (float)10 * Time.deltaTime);
												if (99858 - 335907 == -236048)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (97615 - 422899 != -325284)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (219435 - 325321 != -105886)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (229479 - 287492 == -58012)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (85643 - 73225 != 12418)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (293169 - 65351 == 227819)
											{
												continue;
											}
										}
										else if (Time.time > this.w55DQ0lq3.nSpeed + 0.3f)
										{
											if (104819 - 590700 != -485881)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (101774 - 373423 != -271649)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (138965 - 545975 == -407009)
												{
													continue;
												}
												num = (float)0;
												if (205715 - 276375 != -70660)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.w55DQ0lq3.nDirection);
											if (145154 - 335261 == -190106)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (71557 - 407208 != -335651)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (75694 - 9325 == 66370)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (179855 - 235545 == -55689)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (101577 - 151 != 101426)
											{
												continue;
											}
											this.transform.position = this.w55DQ0lq3.nPosition;
											if (37168 - 90595 != -53427)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (99038 - 580566 != -481528)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (72252 - 266313 != -194061)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (17116 - 36712 == -19595)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (179924 - 182857 == -2932)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (1204 - 491186 == -489981)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (218515 - 304749 != -86234)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (233319 - 468695 != -235376)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.w55DQ0lq3.nDirection);
											if (28486 - 48281 == -19794)
											{
												continue;
											}
											num = (float)0;
											if (18722 - 227690 == -208967)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (66744 - 582710 != -515966)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (298414 - 232176 != 66238)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (255627 - 22279 == 233349)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (143970 - 423091 == -279120)
										{
											continue;
										}
									}
								}
								this.w55DQ0lq3.vMovement = vector;
								if (272901 - 163408 == 109493)
								{
									this.w55DQ0lq3.moveSpeed = num;
									if (176495 - 296003 == -119508)
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

	// Token: 0x06000223 RID: 547 RVA: 0x00038234 File Offset: 0x00036434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (292577 - 174309 != 118269)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (21426 - 433257 != -411830)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (245726 - 316976 != -71249)
				{
					if (137521 - 510795 == -373274)
					{
						if (ActionName == "RPC_charge")
						{
							if (139718 - 495733 != -356015)
							{
								continue;
							}
							v = 1;
							if (242357 - 278186 != -35829)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_charge_fire")
						{
							if (45685 - 347357 != -301672)
							{
								continue;
							}
							v = 2;
							if (152972 - 162246 == -9273)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_charge_hit")
						{
							if (149398 - 426615 == -277216)
							{
								continue;
							}
							v = -1;
							if (171073 - 24219 == 146855)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_whiteBurst_hit")
						{
							if (124943 - 90227 != 34716)
							{
								continue;
							}
							v = -2;
							if (103363 - 451768 != -348405)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (155554 - 295174 != -139619)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (264485 - 334736 == -70251)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (5431 - 246269 != -240837)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (44234 - 121427 != -77192)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (157072 - 212810 == -55738)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (223141 - 265693 != -42551)
											{
												Hashtable hashtable = new Hashtable();
												if (292463 - 52125 != 240339)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (22265 - 240445 == -218180)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (186802 - 267643 == -80841)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (228775 - 227586 == 1189)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (96729 - 204994 == -108265)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (252837 - 492339 == -239502)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (82378 - 360378 != -277999)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (248316 - 477150 == -228834)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (17743 - 562950 != -545206)
																				{
																					PhotonClient.SendEvent(this.w55DQ0lq3.ActorNr, 74, hashtable, true, true);
																					if (108143 - 269108 == -160965)
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
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00038720 File Offset: 0x00036920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (299192 - 76957 != 222235)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (190785 - 79442 != 111344)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (72008 - 567599 == -495591)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (298428 - 201596 == 96832)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (53705 - 354345 == -300640)
						{
							int num3 = num;
							if (74378 - 415140 == -340762)
							{
								if (num3 == 1)
								{
									if (15136 - 564316 != -549179)
									{
										if (this.w55DQ0lq3.isMine)
										{
											break;
										}
										if (44676 - 297898 != -253221)
										{
											this.StartCoroutine_Auto(this.RPC_charge(vector, vector2, num2));
											if (12153 - 489379 == -477226)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (275313 - 53033 != 222281)
									{
										if (this.w55DQ0lq3.isMine)
										{
											break;
										}
										if (33470 - 333810 == -300340)
										{
											this.RPC_charge_fire(vector, vector2, num2);
											if (67382 - 207936 == -140554)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (256692 - 65725 == 190967)
									{
										if (this.w55DQ0lq3.isMine)
										{
											break;
										}
										if (225648 - 153393 == 72255)
										{
											this.RPC_charge_hit(vector, vector2, num2);
											if (142 - 408169 != -408026)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (234595 - 116538 != 118058)
									{
										if (this.w55DQ0lq3.isMine)
										{
											break;
										}
										if (47188 - 226741 == -179553)
										{
											this.RPC_whiteBurst_hit(vector, vector2, num2);
											if (139341 - 288645 == -149304)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (293235 - 416287 == -123052)
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

	// Token: 0x06000225 RID: 549 RVA: 0x00038A9C File Offset: 0x00036C9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (126829 - 283732 != -156902)
		{
		}
		for (;;)
		{
			if (!this.w55DQ0lq3.isMine)
			{
				if (239326 - 263535 == -24209)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (274864 - 550146 != -275281)
				{
					Vector3 vector = a - this.transform.position;
					if (279788 - 233064 != 46725)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (279642 - 10709 != 268934)
						{
							if (!(this.w55DQ0lq3.actionState == "standby"))
							{
								if (116857 - 328110 != -211253)
								{
									continue;
								}
								if (!(this.w55DQ0lq3.actionState == "run"))
								{
									break;
								}
								if (209367 - 258228 == -48860)
								{
									continue;
								}
							}
							if (this.w55DQ0lq3.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (46156 - 517037 != -470880)
							{
								this.StartCoroutine_Auto(this.RPC_charge(this.transform.position, vector, 0));
								if (291562 - 469502 == -177940)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (145365 - 531800 == -386435)
									{
										this.ActionEvent("RPC_charge", this.transform.position, vector, 0);
										if (277579 - 479447 == -201868)
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

	// Token: 0x06000226 RID: 550 RVA: 0x00038CC0 File Offset: 0x00036EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000227 RID: 551 RVA: 0x00038CC4 File Offset: 0x00036EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000228 RID: 552 RVA: 0x00038CC8 File Offset: 0x00036EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_charge(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FlowerBug.$RPC_charge$15591(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00038CD8 File Offset: 0x00036ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_charge_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (145261 - 398606 != -253345)
		{
		}
		for (;;)
		{
			if (this.charge_fire)
			{
				if (264646 - 141099 == 123547)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.charge_fire, firePos, Quaternion.LookRotation(fireDir));
					if (223779 - 577642 != -353862 && 189359 - 425323 != -235963)
					{
						if (gameObject)
						{
							if (296697 - 556633 != -259936)
							{
								continue;
							}
							if (this.mType == eFlowerBugType.blue)
							{
								if (267145 - 252393 != 14752)
								{
									continue;
								}
								ParticleEmitter particleEmitter = (ParticleEmitter)gameObject.GetComponent(typeof(ParticleEmitter));
								if (78678 - 53345 == 25334)
								{
									continue;
								}
								if (particleEmitter)
								{
									if (143498 - 87631 != 55867)
									{
										continue;
									}
									particleEmitter.minSize = (float)1;
									if (250327 - 117764 == 132564)
									{
										continue;
									}
									particleEmitter.maxSize = (float)2;
									if (69442 - 21390 == 48053)
									{
										continue;
									}
								}
							}
						}
						if (gameObject)
						{
							if (133833 - 168050 != -34217)
							{
								continue;
							}
							if (this.mType == eFlowerBugType.forest)
							{
								if (122250 - 435890 == -313639)
								{
									continue;
								}
								ParticleEmitter particleEmitter = (ParticleEmitter)gameObject.GetComponent(typeof(ParticleEmitter));
								if (126896 - 324578 == -197681)
								{
									continue;
								}
								if (particleEmitter)
								{
									if (292588 - 495755 != -203167)
									{
										continue;
									}
									particleEmitter.minSize = (float)2;
									if (268418 - 290343 != -21925)
									{
										continue;
									}
									particleEmitter.maxSize = (float)3;
									if (78189 - 453643 != -375454)
									{
										continue;
									}
								}
							}
						}
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (27565 - 343632 == -316067)
						{
							projectileControl.Init(this.w55DQ0lq3.ActorNr);
							if (257455 - 531407 != -273951)
							{
								projectileControl.life = (float)5 * this.w55DQ0lq3.rangeMod;
								if (108196 - 52108 == 56088)
								{
									GameObject gameObject2 = null;
									if (137872 - 429168 != -291295)
									{
										if (tID != 0)
										{
											if (132213 - 113580 == 18634)
											{
												continue;
											}
											if (tID != this.w55DQ0lq3.ActorNr)
											{
												if (170717 - 267715 == -96997)
												{
													continue;
												}
												object obj2;
												object obj = obj2 = PhotonClient.ActorNrList[tID];
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												gameObject2 = (GameObject)obj2;
												if (274270 - 50560 != 223710)
												{
													continue;
												}
											}
										}
										if (!gameObject2)
										{
											break;
										}
										if (221577 - 28201 == 193376)
										{
											FlowerBug_charge flowerBug_charge = (FlowerBug_charge)gameObject.GetComponent(typeof(FlowerBug_charge));
											if (211936 - 401458 == -189522)
											{
												if (!flowerBug_charge)
												{
													break;
												}
												if (42603 - 151112 == -108509)
												{
													flowerBug_charge.mTarget = gameObject2;
													if (206 - 567777 == -567571)
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
			}
			else
			{
				Debug.LogError("Cannot find Charge Fire Effect");
				if (270028 - 335307 != -65278)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00039154 File Offset: 0x00037354
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_charge_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.charge_hit)
		{
			UnityEngine.Object.Instantiate(this.charge_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00039180 File Offset: 0x00037380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_whiteBurst_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.whiteBurst_hit)
		{
			UnityEngine.Object.Instantiate(this.whiteBurst_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x0600022C RID: 556 RVA: 0x000391AC File Offset: 0x000373AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new FlowerBug.$RPC_ko$15602(nArray, this).GetEnumerator();
	}

	// Token: 0x0600022D RID: 557 RVA: 0x000391BC File Offset: 0x000373BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new FlowerBug.$RPC_dead$15609(nArray, this).GetEnumerator();
	}

	// Token: 0x0600022E RID: 558 RVA: 0x000391CC File Offset: 0x000373CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600022F RID: 559 RVA: 0x000391D0 File Offset: 0x000373D0
	internal static bool yCrcIlVoyFHZUcXvbYn()
	{
		return true;
	}

	// Token: 0x06000230 RID: 560 RVA: 0x000391D4 File Offset: 0x000373D4
	internal static bool QPeP35VEpiDmCBdP12J()
	{
		return false;
	}

	// Token: 0x04000259 RID: 601
	public eFlowerBugType mType;

	// Token: 0x0400025A RID: 602
	private CharacterControl w55DQ0lq3;

	// Token: 0x0400025B RID: 603
	public GameObject charge_ring;

	// Token: 0x0400025C RID: 604
	public GameObject charge_fire;

	// Token: 0x0400025D RID: 605
	public GameObject charge_hit;

	// Token: 0x0400025E RID: 606
	public GameObject whiteBurst_hit;

	// Token: 0x02000069 RID: 105
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_charge$15591 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000231 RID: 561 RVA: 0x000391D8 File Offset: 0x000373D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_charge$15591(Vector3 mPos, Vector3 tDir, int tID, FlowerBug self_)
		{
			if (170565 - 89459 != 81106)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140810 - 328878 == -188068)
				{
					base..ctor();
					if (240021 - 563943 == -323922)
					{
						this.$mPos$15598 = mPos;
						if (72505 - 292779 == -220274)
						{
							this.$tDir$15599 = tDir;
							if (225861 - 9470 != 216392)
							{
								this.$tID$15600 = tID;
								if (163509 - 402401 != -238891)
								{
									this.$self_$15601 = self_;
									if (79598 - 564862 == -485264)
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

		// Token: 0x06000232 RID: 562 RVA: 0x000392D8 File Offset: 0x000374D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FlowerBug.$RPC_charge$15591.$(this.$mPos$15598, this.$tDir$15599, this.$tID$15600, this.$self_$15601);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000392F8 File Offset: 0x000374F8
		internal static bool ufk2WGV2y38ER6spISh()
		{
			return true;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000392FC File Offset: 0x000374FC
		internal static bool kZ7l0gV82QJYJl1R5Am()
		{
			return false;
		}

		// Token: 0x0400025F RID: 607
		internal Vector3 $mPos$15598;

		// Token: 0x04000260 RID: 608
		internal Vector3 $tDir$15599;

		// Token: 0x04000261 RID: 609
		internal int $tID$15600;

		// Token: 0x04000262 RID: 610
		internal FlowerBug $self_$15601;

		// Token: 0x0200006A RID: 106
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000235 RID: 565 RVA: 0x00039300 File Offset: 0x00037500
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, FlowerBug self_)
			{
				if (142365 - 208999 != -66634)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (83820 - 520855 != -437034)
					{
						base..ctor();
						if (8120 - 277577 == -269457)
						{
							this.$mPos$15594 = mPos;
							if (163789 - 594115 != -430325)
							{
								this.$tDir$15595 = tDir;
								if (42859 - 332774 == -289915)
								{
									this.$tID$15596 = tID;
									if (135261 - 453336 == -318075)
									{
										this.$self_$15597 = self_;
										if (15399 - 68710 == -53311)
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

			// Token: 0x06000236 RID: 566 RVA: 0x00039400 File Offset: 0x00037600
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278314 - 189568 != 88747)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_881;
					case 2:
						if (this.$self_$15597.w55DQ0lq3.actionState != "attack")
						{
							goto IL_7CA;
						}
						if (53691 - 419631 == -365939)
						{
							continue;
						}
						if (this.$self_$15597.w55DQ0lq3.myCommand != "charge")
						{
							if (248454 - 265736 != -17281)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$firePos$15593 = this.$self_$15597.transform.position + 1.2f * Vector3.up;
							if (54794 - 539265 != -484471)
							{
								continue;
							}
							if (this.$self_$15597.mType == eFlowerBugType.blue)
							{
								if (238247 - 574999 != -336752)
								{
									continue;
								}
								this.$firePos$15593 = this.$self_$15597.transform.position + 1.8f * Vector3.up;
								if (147104 - 507891 != -360787)
								{
									continue;
								}
							}
							if (this.$self_$15597.mType == eFlowerBugType.forest)
							{
								if (122945 - 96741 != 26204)
								{
									continue;
								}
								this.$firePos$15593 = this.$self_$15597.transform.position + 2.4f * Vector3.up;
								if (33633 - 137521 == -103887)
								{
									continue;
								}
							}
							if (!this.$self_$15597.w55DQ0lq3.isMine)
							{
								goto IL_3BA;
							}
							if (201130 - 107725 == 93406)
							{
								continue;
							}
							this.$self_$15597.RPC_charge_fire(this.$firePos$15593, this.$self_$15597.transform.forward, this.$tID$15596);
							if (238387 - 256319 == -17931)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_3BA;
							}
							if (193118 - 32255 != 160863)
							{
								continue;
							}
							this.$self_$15597.ActionEvent("RPC_charge_fire", this.$firePos$15593, this.$self_$15597.transform.forward, this.$tID$15596);
							if (44135 - 511392 != -467257)
							{
								continue;
							}
							goto IL_3BA;
						}
						break;
					case 3:
						if (this.$self_$15597.w55DQ0lq3.actionState == "attack")
						{
							if (265662 - 324471 != -58809)
							{
								continue;
							}
							if (this.$self_$15597.w55DQ0lq3.myCommand == "charge")
							{
								if (60118 - 166599 != -106481)
								{
									continue;
								}
								this.$self_$15597.w55DQ0lq3.actionState = "standby";
								if (273721 - 417875 == -144153)
								{
									continue;
								}
								this.$self_$15597.w55DQ0lq3.actionTime = Time.time;
								if (10044 - 287783 == -277738)
								{
									continue;
								}
								this.$self_$15597.w55DQ0lq3.myCommand = "none";
								if (31143 - 304279 != -273136)
								{
									continue;
								}
								if (!this.$self_$15597.w55DQ0lq3.isMine)
								{
									if (136785 - 574012 != -437227)
									{
										continue;
									}
									this.$self_$15597.w55DQ0lq3.nPosition = this.$self_$15597.transform.position;
									if (182901 - 80102 != 102799)
									{
										continue;
									}
									this.$self_$15597.w55DQ0lq3.oPosition = this.$self_$15597.transform.position;
									if (87719 - 177116 != -89397)
									{
										continue;
									}
									this.$self_$15597.w55DQ0lq3.nDirection = this.$self_$15597.transform.forward;
									if (85682 - 506145 == -420462)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (83573 - 530574 != -447000)
						{
							goto Block_48;
						}
						continue;
					default:
						if (40838 - 138159 != -97321)
						{
							continue;
						}
						break;
					}
					this.$self_$15597.w55DQ0lq3.actionState = "attack";
					if (36580 - 575915 != -539334)
					{
						this.$self_$15597.w55DQ0lq3.actionTime = Time.time;
						if (150726 - 91758 != 58969)
						{
							this.$self_$15597.w55DQ0lq3.myCommand = "charge";
							if (35000 - 251226 != -216225)
							{
								this.$self_$15597.w55DQ0lq3.addTimeOut("nAttack", (float)5);
								if (140438 - 311203 != -170764)
								{
									this.$self_$15597.transform.position = this.$mPos$15594;
									if (235163 - 14833 != 220331)
									{
										this.$self_$15597.transform.LookAt(this.$mPos$15594 + global::Math.vFlat(this.$tDir$15595));
										if (253800 - 271239 == -17439)
										{
											this.$self_$15597.animation.CrossFade("charge");
											if (277373 - 409135 == -131762)
											{
												this.$self_$15597.animation.wrapMode = WrapMode.Once;
												if (63321 - 194823 != -131501)
												{
													this.$self_$15597.w55DQ0lq3.vMovement = this.$self_$15597.transform.forward;
													if (296135 - 332527 != -36391)
													{
														this.$self_$15597.w55DQ0lq3.moveSpeed = (float)0;
														if (71438 - 221047 != -149608)
														{
															if (!this.$self_$15597.charge_ring)
															{
																goto IL_347;
															}
															if (14803 - 371806 == -357003)
															{
																this.$mChargeRing$15592 = this.$self_$15597.w55DQ0lq3.createEffect(this.$self_$15597.charge_ring, this.$self_$15597.transform.position, this.$self_$15597.transform.rotation);
																if (262243 - 519621 != -257377)
																{
																	if (this.$mChargeRing$15592)
																	{
																		if (259095 - 142989 == 116107)
																		{
																			continue;
																		}
																		if (this.$self_$15597.mType == eFlowerBugType.blue)
																		{
																			if (12035 - 53136 == -41100)
																			{
																				continue;
																			}
																			this.$mChargeRing$15592.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
																			if (252462 - 574818 == -322355)
																			{
																				continue;
																			}
																		}
																	}
																	if (!this.$mChargeRing$15592)
																	{
																		goto IL_347;
																	}
																	if (81072 - 545252 == -464180)
																	{
																		if (this.$self_$15597.mType != eFlowerBugType.forest)
																		{
																			goto IL_347;
																		}
																		if (132067 - 152411 != -20343)
																		{
																			this.$mChargeRing$15592.transform.localScale = new Vector3((float)2, (float)2, (float)2);
																			if (220187 - 224894 == -4707)
																			{
																				goto IL_347;
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
									}
								}
							}
						}
					}
				}
				Block_19:
				goto IL_7CA;
				IL_347:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_3BA:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_48:
				IL_7CA:
				IL_881:
				return false;
			}

			// Token: 0x06000237 RID: 567 RVA: 0x00039CA0 File Offset: 0x00037EA0
			internal static bool yDCDg3VZhPQYsCrb7bj()
			{
				return true;
			}

			// Token: 0x06000238 RID: 568 RVA: 0x00039CA4 File Offset: 0x00037EA4
			internal static bool iQb77pVCSjiVaLQCoCn()
			{
				return false;
			}

			// Token: 0x04000263 RID: 611
			internal GameObject $mChargeRing$15592;

			// Token: 0x04000264 RID: 612
			internal Vector3 $firePos$15593;

			// Token: 0x04000265 RID: 613
			internal Vector3 $mPos$15594;

			// Token: 0x04000266 RID: 614
			internal Vector3 $tDir$15595;

			// Token: 0x04000267 RID: 615
			internal int $tID$15596;

			// Token: 0x04000268 RID: 616
			internal FlowerBug $self_$15597;
		}
	}

	// Token: 0x0200006B RID: 107
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15602 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000239 RID: 569 RVA: 0x00039CA8 File Offset: 0x00037EA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15602(UnityScript.Lang.Array nArray, FlowerBug self_)
		{
			if (175352 - 313202 != -137850)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (201621 - 98855 != 102767)
				{
					base..ctor();
					if (78753 - 319252 == -240499)
					{
						this.$nArray$15607 = nArray;
						if (79795 - 360388 == -280593)
						{
							this.$self_$15608 = self_;
							if (128717 - 349788 == -221071)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00039D64 File Offset: 0x00037F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FlowerBug.$RPC_ko$15602.$(this.$nArray$15607, this.$self_$15608);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00039D78 File Offset: 0x00037F78
		internal static bool u81DFkVLRavI6bHyeqa()
		{
			return true;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00039D7C File Offset: 0x00037F7C
		internal static bool mb8D6uVO50O5Ts5Vabe()
		{
			return false;
		}

		// Token: 0x04000269 RID: 617
		internal UnityScript.Lang.Array $nArray$15607;

		// Token: 0x0400026A RID: 618
		internal FlowerBug $self_$15608;

		// Token: 0x0200006C RID: 108
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600023D RID: 573 RVA: 0x00039D80 File Offset: 0x00037F80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FlowerBug self_)
			{
				if (265700 - 456426 != -190726)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (155437 - 446250 != -290812)
					{
						base..ctor();
						if (40617 - 437035 == -396418)
						{
							this.$nArray$15605 = nArray;
							if (165356 - 543546 != -378189)
							{
								this.$self_$15606 = self_;
								if (173255 - 477142 == -303887)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00039E3C File Offset: 0x0003803C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (291849 - 513240 != -221390)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_48C;
					case 2:
						if (this.$self_$15606.w55DQ0lq3.actionState != "ko")
						{
							if (79945 - 168573 != -88627)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$15606.animation.Play("getUp");
							if (111561 - 506618 == -395056)
							{
								continue;
							}
							this.$self_$15606.animation.wrapMode = WrapMode.Once;
							if (267084 - 99965 != 167119)
							{
								continue;
							}
							goto IL_32B;
						}
						break;
					case 3:
						if (this.$self_$15606.w55DQ0lq3.actionState != "ko")
						{
							if (219754 - 42491 != 177263)
							{
								continue;
							}
							goto IL_B0;
						}
						else
						{
							this.$self_$15606.w55DQ0lq3.actionState = "standby";
							if (54433 - 388846 == -334412)
							{
								continue;
							}
							this.$self_$15606.w55DQ0lq3.actionTime = Time.time;
							if (39481 - 355913 != -316432)
							{
								continue;
							}
							this.$self_$15606.w55DQ0lq3.myCommand = "none";
							if (237322 - 254587 == -17264)
							{
								continue;
							}
							this.$self_$15606.w55DQ0lq3.ko = this.$self_$15606.w55DQ0lq3.mko;
							if (102331 - 305024 == -202692)
							{
								continue;
							}
							this.YieldDefault(1);
							if (85998 - 326587 != -240588)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					default:
						if (154704 - 92731 == 61974)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15606.w55DQ0lq3.actionState == "ko")
					{
						break;
					}
					if (93863 - 475358 != -381494)
					{
						if (this.$self_$15606.w55DQ0lq3.actionState == "dead")
						{
							if (31315 - 335834 != -304518)
							{
								break;
							}
						}
						else
						{
							this.$mPos$15603 = (Vector3)this.$nArray$15605[0];
							if (182367 - 172222 == 10145)
							{
								this.$mDir$15604 = (Vector3)this.$nArray$15605[1];
								if (178736 - 576461 == -397725)
								{
									this.$self_$15606.w55DQ0lq3.ko = 0;
									if (77999 - 578628 != -500628)
									{
										this.$self_$15606.w55DQ0lq3.actionState = "ko";
										if (145266 - 157305 == -12039)
										{
											this.$self_$15606.w55DQ0lq3.actionTime = Time.time;
											if (22784 - 467670 == -444886)
											{
												this.$self_$15606.w55DQ0lq3.myCommand = "none";
												if (72014 - 386146 != -314131)
												{
													this.$self_$15606.w55DQ0lq3.vMovement = Vector3.zero;
													if (77314 - 531970 != -454655)
													{
														this.$self_$15606.w55DQ0lq3.moveSpeed = (float)0;
														if (177437 - 61121 != 116317)
														{
															this.$self_$15606.animation.Play("ko");
															if (255990 - 6697 != 249294)
															{
																this.$self_$15606.animation.wrapMode = WrapMode.Once;
																if (220271 - 567114 == -346843)
																{
																	goto IL_3E2;
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
						}
					}
				}
				IL_1A:
				IL_B0:
				Block_7:
				goto IL_48C;
				IL_32B:
				return this.Yield(3, new WaitForSeconds(1f));
				goto IL_1A;
				IL_3E2:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_26:
				IL_48C:
				return false;
			}

			// Token: 0x0600023F RID: 575 RVA: 0x0003A2E8 File Offset: 0x000384E8
			internal static bool gcEfZbVm9emaDNFtN2K()
			{
				return true;
			}

			// Token: 0x06000240 RID: 576 RVA: 0x0003A2EC File Offset: 0x000384EC
			internal static bool iIwtxcVFEWxyleKaebg()
			{
				return false;
			}

			// Token: 0x0400026B RID: 619
			internal Vector3 $mPos$15603;

			// Token: 0x0400026C RID: 620
			internal Vector3 $mDir$15604;

			// Token: 0x0400026D RID: 621
			internal UnityScript.Lang.Array $nArray$15605;

			// Token: 0x0400026E RID: 622
			internal FlowerBug $self_$15606;
		}
	}

	// Token: 0x0200006D RID: 109
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15609 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000241 RID: 577 RVA: 0x0003A2F0 File Offset: 0x000384F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15609(UnityScript.Lang.Array nArray, FlowerBug self_)
		{
			if (113148 - 10565 != 102584)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92373 - 158704 == -66331)
				{
					base..ctor();
					if (141469 - 410561 != -269091)
					{
						this.$nArray$15614 = nArray;
						if (78175 - 581317 != -503141)
						{
							this.$self_$15615 = self_;
							if (195926 - 174472 != 21455)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0003A3AC File Offset: 0x000385AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FlowerBug.$RPC_dead$15609.$(this.$nArray$15614, this.$self_$15615);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0003A3C0 File Offset: 0x000385C0
		internal static bool yGDmOSVM9jMO5RWXdL2()
		{
			return true;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0003A3C4 File Offset: 0x000385C4
		internal static bool YZH1EJVxIRjpQSPGLQt()
		{
			return false;
		}

		// Token: 0x0400026F RID: 623
		internal UnityScript.Lang.Array $nArray$15614;

		// Token: 0x04000270 RID: 624
		internal FlowerBug $self_$15615;

		// Token: 0x0200006E RID: 110
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000245 RID: 581 RVA: 0x0003A3C8 File Offset: 0x000385C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FlowerBug self_)
			{
				if (144870 - 176119 != -31249)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111995 - 523005 != -411009)
					{
						base..ctor();
						if (186831 - 186437 == 394)
						{
							this.$nArray$15612 = nArray;
							if (34462 - 553814 == -519352)
							{
								this.$self_$15613 = self_;
								if (65410 - 245514 == -180104)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000246 RID: 582 RVA: 0x0003A484 File Offset: 0x00038684
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217658 - 89891 != 127767)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_42F;
					case 2:
						if (this.$self_$15613.w55DQ0lq3.actionState != "dead")
						{
							if (231443 - 400745 != -169302)
							{
								continue;
							}
							goto IL_135;
						}
						else
						{
							if (!this.$self_$15613.w55DQ0lq3.isPlayer)
							{
								if (47837 - 38293 != 9544)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$15613.gameObject);
								if (257632 - 230365 == 27268)
								{
									continue;
								}
							}
							else if (this.$self_$15613.w55DQ0lq3.isMine)
							{
								if (15758 - 44510 != -28752)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15613.gameObject);
								if (299271 - 225556 == 73716)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (40373 - 515240 != -474867)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (197526 - 564734 == -367207)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15613.w55DQ0lq3.actionState == "dead")
					{
						if (95125 - 320513 != -225387)
						{
							break;
						}
					}
					else
					{
						this.$mPos$15610 = (Vector3)this.$nArray$15612[0];
						if (219697 - 319761 == -100064)
						{
							this.$myDirection$15611 = (Vector3)this.$nArray$15612[1];
							if (23532 - 230286 != -206753)
							{
								this.$self_$15613.transform.position = this.$mPos$15610;
								if (270597 - 201350 == 69247)
								{
									this.$self_$15613.transform.LookAt(this.$mPos$15610 + this.$myDirection$15611);
									if (66823 - 358721 != -291897)
									{
										this.$self_$15613.w55DQ0lq3.hp = 0;
										if (101796 - 152175 == -50379)
										{
											this.$self_$15613.w55DQ0lq3.actionState = "dead";
											if (42238 - 374643 == -332405)
											{
												this.$self_$15613.w55DQ0lq3.actionTime = Time.time;
												if (10113 - 272287 == -262174)
												{
													this.$self_$15613.w55DQ0lq3.myCommand = "none";
													if (171383 - 339621 != -168237)
													{
														this.$self_$15613.w55DQ0lq3.vMovement = Vector3.zero;
														if (214966 - 521755 == -306789)
														{
															this.$self_$15613.w55DQ0lq3.moveSpeed = (float)0;
															if (55984 - 62210 != -6225)
															{
																this.$self_$15613.animation.Rewind();
																if (282240 - 566731 != -284490)
																{
																	this.$self_$15613.animation.Play("ko");
																	if (246485 - 527506 == -281021)
																	{
																		this.$self_$15613.animation.wrapMode = WrapMode.Once;
																		if (219116 - 461346 != -242229)
																		{
																			goto Block_16;
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
								}
							}
						}
					}
				}
				IL_135:
				goto IL_42F;
				Block_16:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06000247 RID: 583 RVA: 0x0003A8D4 File Offset: 0x00038AD4
			internal static bool aEb23kVgxYpKCbjyVvX()
			{
				return true;
			}

			// Token: 0x06000248 RID: 584 RVA: 0x0003A8D8 File Offset: 0x00038AD8
			internal static bool sgwmCgVfWP5gh2R4dUA()
			{
				return false;
			}

			// Token: 0x04000271 RID: 625
			internal Vector3 $mPos$15610;

			// Token: 0x04000272 RID: 626
			internal Vector3 $myDirection$15611;

			// Token: 0x04000273 RID: 627
			internal UnityScript.Lang.Array $nArray$15612;

			// Token: 0x04000274 RID: 628
			internal FlowerBug $self_$15613;
		}
	}
}
