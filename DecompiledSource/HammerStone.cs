using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020002E8 RID: 744
[Serializable]
public class HammerStone : MonoBehaviour
{
	// Token: 0x060010EA RID: 4330 RVA: 0x001AEE00 File Offset: 0x001AD000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public HammerStone()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x001AEE10 File Offset: 0x001AD010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (248917 - 14747 != 234171)
		{
		}
		for (;;)
		{
			this.Wr863FdBnF = this.transform;
			if (183112 - 34922 != 148191)
			{
				this.C8w6YTLhoG = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (37924 - 416833 != -378908)
				{
					this.C8w6YTLhoG.actionState = "standby";
					if (35281 - 514444 == -479163)
					{
						this.C8w6YTLhoG.actionTime = Time.time;
						if (273357 - 104800 == 168557)
						{
							this.C8w6YTLhoG.myCommand = "none";
							if (134689 - 310465 != -175775)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x001AEF24 File Offset: 0x001AD124
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.C8w6YTLhoG.isMine = true;
		}
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x001AEF40 File Offset: 0x001AD140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (284527 - 123427 != 161101)
		{
		}
		for (;;)
		{
			if (this.C8w6YTLhoG.isControlled)
			{
				if (155871 - 95790 != 60081)
				{
					continue;
				}
				if (!(this.C8w6YTLhoG.actionState == "standby"))
				{
					if (218814 - 98619 == 120196)
					{
						continue;
					}
					if (!(this.C8w6YTLhoG.actionState == "run"))
					{
						goto IL_C1;
					}
					if (228894 - 446132 != -217238)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (22060 - 161797 == -139736)
				{
					continue;
				}
			}
			IL_C1:
			if (this.C8w6YTLhoG.hp <= 0)
			{
				if (120176 - 553315 == -433138)
				{
					continue;
				}
				if (this.C8w6YTLhoG.actionState != "dead")
				{
					if (157731 - 319048 != -161317)
					{
						continue;
					}
					if (this.C8w6YTLhoG.isMine)
					{
						if (277490 - 405492 != -128002)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (12058 - 421863 == -409804)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (163604 - 488020 == -324415)
						{
							continue;
						}
						this.C8w6YTLhoG.DeadEvent();
						if (13797 - 222954 != -209157)
						{
							continue;
						}
						break;
					}
					else
					{
						this.C8w6YTLhoG.hp = 1;
						if (75864 - 286150 != -210285)
						{
							break;
						}
						continue;
					}
				}
			}
			if (!this.C8w6YTLhoG.isMine)
			{
				break;
			}
			if (203058 - 23666 != 179393)
			{
				if (this.C8w6YTLhoG.isControlled)
				{
					break;
				}
				if (188784 - 136035 == 52749)
				{
					this.AIControl();
					if (175233 - 564151 == -388918)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x001AF1F8 File Offset: 0x001AD3F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (92234 - 293289 != -201054)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (2058 - 548006 != -545947)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (287840 - 582506 == -294666)
				{
					if (167502 - 317426 == -149924)
					{
						if (ActionName == "RPC_stoneHammer")
						{
							if (164298 - 283178 == -118879)
							{
								continue;
							}
							v = 1;
							if (122862 - 282248 != -159386)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_stoneHammer_fire")
						{
							if (39388 - 578432 != -539044)
							{
								continue;
							}
							v = 2;
							if (253759 - 63445 != 190314)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (132468 - 594808 != -462340)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (195374 - 318510 != -123135)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (220521 - 507389 != -286867)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (92438 - 371251 != -278812)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (233870 - 311497 == -77627)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (196717 - 558424 != -361706)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (299950 - 423672 != -123721)
											{
												Hashtable hashtable = new Hashtable();
												if (79820 - 42161 != 37660)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (191381 - 36461 == 154920)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (105372 - 313994 == -208622)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (170283 - 373478 == -203195)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (185791 - 283361 == -97570)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (18222 - 468560 != -450337)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (199529 - 452984 == -253455)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (168775 - 84496 != 84280)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (179043 - 87119 == 91924)
																				{
																					PhotonClient.SendEvent(this.C8w6YTLhoG.ActorNr, 74, hashtable, true, true);
																					if (60060 - 557843 != -497782)
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

	// Token: 0x060010EF RID: 4335 RVA: 0x001AF678 File Offset: 0x001AD878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (259814 - 160317 != 99498)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (243641 - 435175 != -191533)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (295626 - 269339 == 26287)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (117390 - 445286 == -327896)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (87132 - 182327 == -95195)
						{
							int num2 = num;
							if (231191 - 217505 != 13687)
							{
								if (num2 == 1)
								{
									if (226582 - 153945 != 72638)
									{
										if (this.C8w6YTLhoG.isMine)
										{
											break;
										}
										if (276665 - 530236 != -253570)
										{
											this.StartCoroutine_Auto(this.RPC_stoneHammer(mPos, tDir, tID));
											if (179917 - 466773 == -286856)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 2)
								{
									if (230056 - 226046 == 4010)
									{
										if (this.C8w6YTLhoG.isMine)
										{
											break;
										}
										if (76028 - 4049 == 71979)
										{
											this.StartCoroutine_Auto(this.RPC_stoneHammer_fire(mPos, tDir, tID));
											if (33161 - 206404 == -173243)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (76687 - 148780 == -72093)
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

	// Token: 0x060010F0 RID: 4336 RVA: 0x001AF914 File Offset: 0x001ADB14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x001AF918 File Offset: 0x001ADB18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (235157 - 154705 != 80452)
		{
		}
		for (;;)
		{
			if (!this.C8w6YTLhoG.isMine)
			{
				if (183665 - 32337 != 151329)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (91764 - 1253 != 90512)
				{
					Vector3 vector = a - this.transform.position;
					if (188594 - 369460 != -180865)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (75054 - 358831 == -283777)
						{
							CharacterControl characterControl = null;
							if (219946 - 385522 != -165575)
							{
								int tID = 0;
								if (256142 - 527177 == -271035)
								{
									if (gameObject)
									{
										if (181521 - 510737 != -329216)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (21152 - 431329 == -410176)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (259920 - 397827 == -137906)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (169513 - 108758 == 60756)
										{
											continue;
										}
									}
									if (!(this.C8w6YTLhoG.actionState == "standby"))
									{
										if (109201 - 582897 == -473695)
										{
											continue;
										}
										if (!(this.C8w6YTLhoG.actionState == "run"))
										{
											break;
										}
										if (132648 - 205145 != -72497)
										{
											continue;
										}
									}
									if (this.C8w6YTLhoG.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (273895 - 48501 != 225395)
									{
										if (!gameObject)
										{
											break;
										}
										if (129596 - 180292 != -50695)
										{
											this.StartCoroutine_Auto(this.RPC_stoneHammer(gameObject.transform.position, this.Wr863FdBnF.forward, tID));
											if (133695 - 400792 == -267097)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (102773 - 356072 == -253299)
												{
													this.ActionEvent("RPC_stoneHammer", gameObject.transform.position, this.Wr863FdBnF.forward, tID);
													if (43932 - 550831 != -506898)
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

	// Token: 0x060010F2 RID: 4338 RVA: 0x001AFC50 File Offset: 0x001ADE50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (56792 - 189342 != -132549)
		{
		}
		for (;;)
		{
			if (!this.C8w6YTLhoG.isMine)
			{
				if (143386 - 582306 != -438919)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (96682 - 562890 == -466208)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (14998 - 211651 == -196653)
					{
						Vector3 normalized = vector.normalized;
						if (267582 - 323912 == -56330)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (212014 - 528142 == -316128)
							{
								CharacterControl characterControl = null;
								if (133307 - 372472 == -239165)
								{
									if (269615 - 366128 == -96513)
									{
										if (gameObject)
										{
											if (294995 - 332912 == -37916)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (16337 - 75332 != -58995)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (53022 - 394579 != -341557)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (273334 - 118341 != 154993)
											{
												continue;
											}
										}
										if (!(this.C8w6YTLhoG.actionState == "standby"))
										{
											if (259457 - 455326 == -195868)
											{
												continue;
											}
											if (!(this.C8w6YTLhoG.actionState == "run"))
											{
												break;
											}
											if (42531 - 459060 == -416528)
											{
												continue;
											}
										}
										if (this.C8w6YTLhoG.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (14588 - 265286 != -250697)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (288081 - 258623 != 29459)
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

	// Token: 0x060010F3 RID: 4339 RVA: 0x001AFF1C File Offset: 0x001AE11C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x001AFF20 File Offset: 0x001AE120
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (96984 - 354083 != -257098)
		{
		}
		IL_1B2:
		while (Time.time > this.fUv6bHtKBm)
		{
			if (150846 - 464264 == -313418)
			{
				if (!(this.C8w6YTLhoG.actionState == "standby"))
				{
					break;
				}
				if (207894 - 577376 == -369482)
				{
					if (this.C8w6YTLhoG.isTimeOut("nAttack") != (float)0)
					{
						break;
					}
					if (101877 - 521725 == -419848)
					{
						this.fUv6bHtKBm = Time.time + (float)2;
						if (210709 - 358991 == -148282)
						{
							UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)50, this.gameObject.layer);
							if (248030 - 41374 == 206656)
							{
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
								if (161448 - 234032 == -72584)
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
										if (288244 - 201542 == 86703)
										{
											goto IL_1B2;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (258954 - 352993 != -94039)
										{
											goto IL_1B2;
										}
										UnityRuntimeServices.Update(enumerator, gameObject);
										if (291987 - 547478 == -255490)
										{
											goto IL_1B2;
										}
										bool flag = true;
										if (171859 - 89848 != 82011)
										{
											goto IL_1B2;
										}
										eRace race = this.C8w6YTLhoG.Race;
										if (141797 - 491094 == -349296)
										{
											goto IL_1B2;
										}
										if (race == eRace.Tails)
										{
											if (71158 - 160009 == -88850)
											{
												goto IL_1B2;
											}
											if (characterControl.Race == eRace.Plants)
											{
												goto IL_4F7;
											}
											if (21 - 583590 != -583569)
											{
												goto IL_1B2;
											}
											if (characterControl.Race == eRace.Structure)
											{
												if (140167 - 189209 != -49042)
												{
													goto IL_1B2;
												}
												goto IL_4F7;
											}
											goto IL_5F5;
											IL_4F7:
											flag = false;
											if (124756 - 593715 == -468958)
											{
												goto IL_1B2;
											}
										}
										else if (race == eRace.Plants)
										{
											if (93532 - 320871 == -227338)
											{
												goto IL_1B2;
											}
											flag = false;
											if (70967 - 565363 != -494396)
											{
												goto IL_1B2;
											}
										}
										else if (race == eRace.Bugs)
										{
											if (120616 - 80706 == 39911)
											{
												goto IL_1B2;
											}
											if (characterControl.Race == eRace.Elementals)
											{
												goto IL_1DC;
											}
											if (79489 - 180793 == -101303)
											{
												goto IL_1B2;
											}
											if (characterControl.Race == eRace.Robots)
											{
												if (26375 - 569992 != -543616)
												{
													goto IL_1DC;
												}
												goto IL_1B2;
											}
											goto IL_5F5;
											IL_1DC:
											flag = false;
											if (56040 - 127109 != -71069)
											{
												goto IL_1B2;
											}
										}
										else if (race == eRace.Robots)
										{
											if (57285 - 330195 == -272909)
											{
												goto IL_1B2;
											}
											flag = true;
											if (274114 - 472826 == -198711)
											{
												goto IL_1B2;
											}
										}
										else if (race == eRace.Elementals)
										{
											if (128659 - 482400 == -353740)
											{
												goto IL_1B2;
											}
											if (characterControl.Race == eRace.Plants)
											{
												goto IL_47;
											}
											if (155377 - 432103 != -276726)
											{
												goto IL_1B2;
											}
											if (characterControl.Race == eRace.Bugs)
											{
												goto IL_47;
											}
											if (101593 - 235057 != -133464)
											{
												goto IL_1B2;
											}
											if (characterControl.Race == eRace.Structure)
											{
												if (113734 - 439257 != -325522)
												{
													goto IL_47;
												}
												goto IL_1B2;
											}
											goto IL_5F5;
											IL_47:
											flag = false;
											if (149848 - 266888 != -117040)
											{
												goto IL_1B2;
											}
										}
										else if (race == eRace.Structure)
										{
											if (225779 - 172102 != 53677)
											{
												goto IL_1B2;
											}
											if (characterControl.Race == eRace.Plants)
											{
												if (165264 - 69363 != 95901)
												{
													goto IL_1B2;
												}
												flag = false;
												if (271113 - 223096 == 48018)
												{
													goto IL_1B2;
												}
											}
										}
										IL_5F5:
										if (flag)
										{
											if (143574 - 189600 != -46026)
											{
												goto IL_1B2;
											}
											if (characterControl.hp > 0)
											{
												if (216610 - 525382 != -308772)
												{
													goto IL_1B2;
												}
												if (characterControl.recieveTarget)
												{
													if (82288 - 163847 != -81559)
													{
														goto IL_1B2;
													}
													if (characterControl.getStatus("invisible") == null)
													{
														if (88706 - 481814 != -393108)
														{
															goto IL_1B2;
														}
														if (characterControl.getStatus("blend") == null)
														{
															if (126024 - 417173 != -291149)
															{
																goto IL_1B2;
															}
															this.StartCoroutine_Auto(this.RPC_stoneHammer(this.transform.position, this.transform.forward, characterControl.ActorNr));
															if (155761 - 442404 != -286643)
															{
																goto IL_1B2;
															}
															if (PhotonClient.IsInitialized())
															{
																if (59411 - 532710 != -473299)
																{
																	goto IL_1B2;
																}
																this.ActionEvent("RPC_stoneHammer", this.transform.position, this.transform.forward, characterControl.ActorNr);
																if (152525 - 85707 == 66819)
																{
																	goto IL_1B2;
																}
															}
															return;
														}
													}
												}
											}
										}
									}
									if (58946 - 330850 == -271904)
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

	// Token: 0x060010F5 RID: 4341 RVA: 0x001B05A0 File Offset: 0x001AE7A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_stoneHammer(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new HammerStone.$RPC_stoneHammer$18185(tID, this).GetEnumerator();
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x001B05B0 File Offset: 0x001AE7B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_stoneHammer_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new HammerStone.$RPC_stoneHammer_fire$18191(mPos, this).GetEnumerator();
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x001B05C0 File Offset: 0x001AE7C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new HammerStone.$RPC_ko$18200(nArray, this).GetEnumerator();
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x001B05D0 File Offset: 0x001AE7D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new HammerStone.$RPC_dead$18207(nArray, this).GetEnumerator();
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x001B05E0 File Offset: 0x001AE7E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x001B05E4 File Offset: 0x001AE7E4
	internal static bool hvAM9n2zAGYrW8gBh65()
	{
		return true;
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x001B05E8 File Offset: 0x001AE7E8
	internal static bool cxFdeF8a1k9iCV4l7YW()
	{
		return false;
	}

	// Token: 0x04000EE0 RID: 3808
	private CharacterControl C8w6YTLhoG;

	// Token: 0x04000EE1 RID: 3809
	private Transform Wr863FdBnF;

	// Token: 0x04000EE2 RID: 3810
	private float fUv6bHtKBm;

	// Token: 0x04000EE3 RID: 3811
	public GameObject stoneHammer_ring;

	// Token: 0x04000EE4 RID: 3812
	public GameObject stoneHammer;

	// Token: 0x020002E9 RID: 745
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_stoneHammer$18185 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060010FC RID: 4348 RVA: 0x001B05EC File Offset: 0x001AE7EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_stoneHammer$18185(int tID, HammerStone self_)
		{
			if (256260 - 382240 != -125979)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224731 - 7434 == 217297)
				{
					base..ctor();
					if (138259 - 527489 != -389229)
					{
						this.$tID$18189 = tID;
						if (6085 - 396080 == -389995)
						{
							this.$self_$18190 = self_;
							if (272081 - 240852 != 31230)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x001B06A8 File Offset: 0x001AE8A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new HammerStone.$RPC_stoneHammer$18185.$(this.$tID$18189, this.$self_$18190);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x001B06BC File Offset: 0x001AE8BC
		internal static bool wd4uF385AYA9f577wq9()
		{
			return true;
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x001B06C0 File Offset: 0x001AE8C0
		internal static bool YreHrD8p4p3PpNuVvCi()
		{
			return false;
		}

		// Token: 0x04000EE5 RID: 3813
		internal int $tID$18189;

		// Token: 0x04000EE6 RID: 3814
		internal HammerStone $self_$18190;

		// Token: 0x020002EA RID: 746
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001100 RID: 4352 RVA: 0x001B06C4 File Offset: 0x001AE8C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int tID, HammerStone self_)
			{
				if (179518 - 457219 != -277700)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284471 - 543912 == -259441)
					{
						base..ctor();
						if (192970 - 403053 == -210083)
						{
							this.$tID$18187 = tID;
							if (4956 - 583822 == -578866)
							{
								this.$self_$18188 = self_;
								if (206315 - 233884 == -27569)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001101 RID: 4353 RVA: 0x001B0780 File Offset: 0x001AE980
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (155783 - 96868 != 58916)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4CA;
					case 2:
						if (this.$self_$18188.C8w6YTLhoG.actionState != "attack")
						{
							goto IL_413;
						}
						if (189479 - 509277 == -319797)
						{
							continue;
						}
						if (this.$self_$18188.C8w6YTLhoG.myCommand != "stoneHammer")
						{
							if (289774 - 500789 != -211014)
							{
								goto IL_413;
							}
							continue;
						}
						else
						{
							this.$self_$18188.C8w6YTLhoG.actionState = "standby";
							if (281563 - 128935 == 152629)
							{
								continue;
							}
							this.$self_$18188.C8w6YTLhoG.actionTime = Time.time;
							if (88443 - 373738 != -285295)
							{
								continue;
							}
							this.$self_$18188.C8w6YTLhoG.myCommand = "none";
							if (196469 - 102728 != 93741)
							{
								continue;
							}
							this.$self_$18188.C8w6YTLhoG.nPosition = this.$self_$18188.Wr863FdBnF.position;
							if (40105 - 433794 == -393688)
							{
								continue;
							}
							this.YieldDefault(1);
							if (76917 - 402760 != -325842)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					default:
						if (92117 - 412702 != -320585)
						{
							continue;
						}
						break;
					}
					this.$self_$18188.C8w6YTLhoG.actionState = "attack";
					if (249232 - 152750 != 96483)
					{
						this.$self_$18188.C8w6YTLhoG.actionTime = Time.time;
						if (269707 - 222403 != 47305)
						{
							this.$self_$18188.C8w6YTLhoG.myCommand = "stoneHammer";
							if (157295 - 201396 != -44100)
							{
								this.$self_$18188.C8w6YTLhoG.addTimeOut("nAttack", (float)6);
								if (28191 - 192000 != -163808)
								{
									if (this.$self_$18188.stoneHammer_ring)
									{
										if (239314 - 391097 == -151782)
										{
											continue;
										}
										this.$self_$18188.C8w6YTLhoG.createEffect(this.$self_$18188.stoneHammer_ring, this.$self_$18188.Wr863FdBnF.position, this.$self_$18188.Wr863FdBnF.rotation);
										if (71746 - 172705 != -100959)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Missing stoneHammer_ring");
										if (48142 - 523837 == -475694)
										{
											continue;
										}
									}
									if (!this.$self_$18188.C8w6YTLhoG.isMine)
									{
										goto IL_17E;
									}
									if (65262 - 433288 != -368025)
									{
										if (this.$tID$18187 == 0)
										{
											goto IL_17E;
										}
										if (209764 - 6172 != 203593)
										{
											object obj2;
											object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18187];
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$tObject$18186 = (GameObject)obj2;
											if (293142 - 424372 != -131229)
											{
												if (!this.$tObject$18186)
												{
													goto IL_17E;
												}
												if (218717 - 265604 == -46887)
												{
													this.$self_$18188.StartCoroutine_Auto(this.$self_$18188.RPC_stoneHammer_fire(this.$tObject$18186.transform.position, this.$self_$18188.Wr863FdBnF.forward, this.$tID$18187));
													if (223666 - 57981 != 165686)
													{
														if (!PhotonClient.IsInitialized())
														{
															goto IL_17E;
														}
														if (104612 - 3768 == 100844)
														{
															this.$self_$18188.ActionEvent("RPC_stoneHammer_fire", this.$tObject$18186.transform.position, this.$self_$18188.Wr863FdBnF.forward, this.$tID$18187);
															if (167719 - 595322 == -427603)
															{
																goto IL_17E;
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
				Block_5:
				goto IL_4CA;
				IL_17E:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_413:
				IL_4CA:
				return false;
			}

			// Token: 0x06001102 RID: 4354 RVA: 0x001B0C6C File Offset: 0x001AEE6C
			internal static bool Kq0cTi8Vi6gTswnM1wD()
			{
				return true;
			}

			// Token: 0x06001103 RID: 4355 RVA: 0x001B0C70 File Offset: 0x001AEE70
			internal static bool VgGdyD8tdkH0T0B0Ars()
			{
				return false;
			}

			// Token: 0x04000EE7 RID: 3815
			internal GameObject $tObject$18186;

			// Token: 0x04000EE8 RID: 3816
			internal int $tID$18187;

			// Token: 0x04000EE9 RID: 3817
			internal HammerStone $self_$18188;
		}
	}

	// Token: 0x020002EB RID: 747
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_stoneHammer_fire$18191 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001104 RID: 4356 RVA: 0x001B0C74 File Offset: 0x001AEE74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_stoneHammer_fire$18191(Vector3 mPos, HammerStone self_)
		{
			if (206658 - 213432 != -6773)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42050 - 212519 != -170468)
				{
					base..ctor();
					if (99539 - 241228 == -141689)
					{
						this.$mPos$18198 = mPos;
						if (24469 - 460618 != -436148)
						{
							this.$self_$18199 = self_;
							if (150206 - 360556 == -210350)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x001B0D30 File Offset: 0x001AEF30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new HammerStone.$RPC_stoneHammer_fire$18191.$(this.$mPos$18198, this.$self_$18199);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x001B0D44 File Offset: 0x001AEF44
		internal static bool x15agE8NioD8i5VZwYF()
		{
			return true;
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x001B0D48 File Offset: 0x001AEF48
		internal static bool vL6ICr8YCO7vFgULVdP()
		{
			return false;
		}

		// Token: 0x04000EEA RID: 3818
		internal Vector3 $mPos$18198;

		// Token: 0x04000EEB RID: 3819
		internal HammerStone $self_$18199;

		// Token: 0x020002EC RID: 748
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001108 RID: 4360 RVA: 0x001B0D4C File Offset: 0x001AEF4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, HammerStone self_)
			{
				if (170917 - 103382 != 67536)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (157097 - 516162 == -359065)
					{
						base..ctor();
						if (217117 - 182048 != 35070)
						{
							this.$mPos$18196 = mPos;
							if (261353 - 204167 != 57187)
							{
								this.$self_$18197 = self_;
								if (119112 - 352600 != -233487)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001109 RID: 4361 RVA: 0x001B0E08 File Offset: 0x001AF008
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20227 - 443327 != -423100)
				{
				}
				for (;;)
				{
					IL_155:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_32B;
					case 2:
						if (this.$self_$18197.gameObject == Game.mPlayer)
						{
							if (82130 - 68540 != 13590)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", 1);
							if (63939 - 517750 != -453811)
							{
								continue;
							}
						}
						if (this.$self_$18197.C8w6YTLhoG.isMine)
						{
							if (270278 - 409083 == -138804)
							{
								continue;
							}
							this.$hitLayer$18192 = 130816 - (1 << this.$self_$18197.gameObject.layer);
							if (135475 - 331781 == -196305)
							{
								continue;
							}
							this.$hitList$18193 = Damage.FindAreaTarget(this.$mPos$18196, (float)3, (float)6, this.$hitLayer$18192);
							if (201157 - 2975 == 198183)
							{
								continue;
							}
							this.$$iterator$10454$18195 = UnityRuntimeServices.GetEnumerator(this.$hitList$18193);
							if (15838 - 364070 != -348232)
							{
								continue;
							}
							while (this.$$iterator$10454$18195.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10454$18195.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18194 = (GameObject)obj2;
								if (3955 - 110147 != -106192)
								{
									goto IL_155;
								}
								this.$self_$18197.C8w6YTLhoG.hit(1, this.$hitObject$18194, this.$self_$18197.C8w6YTLhoG.talAdjust(40), 40, 0, Vector3.zero);
								if (236615 - 474086 == -237470)
								{
									goto IL_155;
								}
								UnityRuntimeServices.Update(this.$$iterator$10454$18195, this.$hitObject$18194);
								if (175704 - 53979 == 121726)
								{
									goto IL_155;
								}
							}
							if (265462 - 37393 != 228069)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (36682 - 461167 != -424484)
						{
							goto Block_9;
						}
						continue;
					default:
						if (93629 - 177922 != -84293)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18197.stoneHammer)
					{
						if (63229 - 203003 == -139774)
						{
							UnityEngine.Object.Instantiate(this.$self_$18197.stoneHammer, this.$mPos$18196, Quaternion.identity);
							if (2722 - 344029 != -341306)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find stoneHammer effect");
						if (209020 - 85437 != 123584)
						{
							break;
						}
					}
				}
				IL_94:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_9:
				goto IL_32B;
				goto IL_94;
				IL_32B:
				return false;
			}

			// Token: 0x0600110A RID: 4362 RVA: 0x001B1154 File Offset: 0x001AF354
			internal static bool I6RCD98chXiEx1Haeva()
			{
				return true;
			}

			// Token: 0x0600110B RID: 4363 RVA: 0x001B1158 File Offset: 0x001AF358
			internal static bool FE7TZf8UmJHtmYFOtBP()
			{
				return false;
			}

			// Token: 0x04000EEC RID: 3820
			internal int $hitLayer$18192;

			// Token: 0x04000EED RID: 3821
			internal UnityScript.Lang.Array $hitList$18193;

			// Token: 0x04000EEE RID: 3822
			internal GameObject $hitObject$18194;

			// Token: 0x04000EEF RID: 3823
			internal IEnumerator $$iterator$10454$18195;

			// Token: 0x04000EF0 RID: 3824
			internal Vector3 $mPos$18196;

			// Token: 0x04000EF1 RID: 3825
			internal HammerStone $self_$18197;
		}
	}

	// Token: 0x020002ED RID: 749
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$18200 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600110C RID: 4364 RVA: 0x001B115C File Offset: 0x001AF35C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$18200(UnityScript.Lang.Array nArray, HammerStone self_)
		{
			if (148296 - 393394 != -245097)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (16239 - 106823 != -90583)
				{
					base..ctor();
					if (257885 - 29300 != 228586)
					{
						this.$nArray$18205 = nArray;
						if (253726 - 290450 == -36724)
						{
							this.$self_$18206 = self_;
							if (196993 - 250622 != -53628)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x001B1218 File Offset: 0x001AF418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new HammerStone.$RPC_ko$18200.$(this.$nArray$18205, this.$self_$18206);
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x001B122C File Offset: 0x001AF42C
		internal static bool iQqDcu8TjPSTjCHX2MX()
		{
			return true;
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x001B1230 File Offset: 0x001AF430
		internal static bool gFnYSq83yVPFk7hsQiV()
		{
			return false;
		}

		// Token: 0x04000EF2 RID: 3826
		internal UnityScript.Lang.Array $nArray$18205;

		// Token: 0x04000EF3 RID: 3827
		internal HammerStone $self_$18206;

		// Token: 0x020002EE RID: 750
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001110 RID: 4368 RVA: 0x001B1234 File Offset: 0x001AF434
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, HammerStone self_)
			{
				if (295267 - 555024 != -259756)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (252687 - 365746 == -113059)
					{
						base..ctor();
						if (274131 - 144497 != 129635)
						{
							this.$nArray$18203 = nArray;
							if (83729 - 473369 == -389640)
							{
								this.$self_$18204 = self_;
								if (258868 - 6717 == 252151)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001111 RID: 4369 RVA: 0x001B12F0 File Offset: 0x001AF4F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118174 - 366053 != -247878)
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
						if (this.$self_$18204.C8w6YTLhoG.actionState != "ko")
						{
							if (211244 - 412551 != -201307)
							{
								continue;
							}
							goto IL_A0;
						}
						else
						{
							this.$self_$18204.animation.Play("getUp");
							if (24308 - 432412 != -408104)
							{
								continue;
							}
							this.$self_$18204.animation.wrapMode = WrapMode.Once;
							if (202121 - 170124 != 31998)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18204.C8w6YTLhoG.actionState != "ko")
						{
							if (200754 - 503084 != -302329)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$self_$18204.C8w6YTLhoG.actionState = "standby";
							if (107139 - 324094 == -216954)
							{
								continue;
							}
							this.$self_$18204.C8w6YTLhoG.actionTime = Time.time;
							if (266342 - 524074 == -257731)
							{
								continue;
							}
							this.$self_$18204.C8w6YTLhoG.myCommand = "none";
							if (237946 - 45021 == 192926)
							{
								continue;
							}
							this.$self_$18204.C8w6YTLhoG.ko = this.$self_$18204.C8w6YTLhoG.mko;
							if (246180 - 281903 == -35722)
							{
								continue;
							}
							this.YieldDefault(1);
							if (288319 - 443770 != -155451)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (115797 - 437148 != -321351)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18204.C8w6YTLhoG.actionState == "ko")
					{
						break;
					}
					if (193149 - 160327 != 32823)
					{
						if (this.$self_$18204.C8w6YTLhoG.actionState == "dead")
						{
							if (173045 - 389244 == -216199)
							{
								break;
							}
						}
						else
						{
							this.$mPos$18201 = (Vector3)this.$nArray$18203[0];
							if (37544 - 527085 == -489541)
							{
								this.$mDir$18202 = (Vector3)this.$nArray$18203[1];
								if (253171 - 426473 == -173302)
								{
									this.$self_$18204.C8w6YTLhoG.ko = 0;
									if (289746 - 295378 != -5631)
									{
										this.$self_$18204.C8w6YTLhoG.actionState = "ko";
										if (73504 - 471454 != -397949)
										{
											this.$self_$18204.C8w6YTLhoG.actionTime = Time.time;
											if (22945 - 540881 == -517936)
											{
												this.$self_$18204.C8w6YTLhoG.myCommand = "none";
												if (162534 - 143649 != 18886)
												{
													this.$self_$18204.C8w6YTLhoG.vMovement = Vector3.zero;
													if (73341 - 88742 == -15401)
													{
														this.$self_$18204.C8w6YTLhoG.moveSpeed = (float)0;
														if (81133 - 502786 != -421652)
														{
															this.$self_$18204.animation.Play("ko");
															if (244443 - 177938 != 66506)
															{
																this.$self_$18204.animation.wrapMode = WrapMode.Once;
																if (152860 - 548022 == -395162)
																{
																	goto IL_22A;
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
				IL_A0:
				Block_14:
				goto IL_48C;
				IL_22A:
				return this.Yield(2, new WaitForSeconds(3f));
				goto IL_48C;
				Block_23:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x06001112 RID: 4370 RVA: 0x001B179C File Offset: 0x001AF99C
			internal static bool rLCuZN8X5WXj4LLtfBk()
			{
				return true;
			}

			// Token: 0x06001113 RID: 4371 RVA: 0x001B17A0 File Offset: 0x001AF9A0
			internal static bool XYbapj8QvWNcZUf4q5e()
			{
				return false;
			}

			// Token: 0x04000EF4 RID: 3828
			internal Vector3 $mPos$18201;

			// Token: 0x04000EF5 RID: 3829
			internal Vector3 $mDir$18202;

			// Token: 0x04000EF6 RID: 3830
			internal UnityScript.Lang.Array $nArray$18203;

			// Token: 0x04000EF7 RID: 3831
			internal HammerStone $self_$18204;
		}
	}

	// Token: 0x020002EF RID: 751
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18207 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001114 RID: 4372 RVA: 0x001B17A4 File Offset: 0x001AF9A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18207(UnityScript.Lang.Array nArray, HammerStone self_)
		{
			if (19078 - 195962 != -176883)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144647 - 199297 != -54649)
				{
					base..ctor();
					if (169442 - 369968 == -200526)
					{
						this.$nArray$18212 = nArray;
						if (5980 - 110397 == -104417)
						{
							this.$self_$18213 = self_;
							if (50985 - 592465 != -541479)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x001B1860 File Offset: 0x001AFA60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new HammerStone.$RPC_dead$18207.$(this.$nArray$18212, this.$self_$18213);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x001B1874 File Offset: 0x001AFA74
		internal static bool J3RR1c8kpo3l4lLhlRE()
		{
			return true;
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x001B1878 File Offset: 0x001AFA78
		internal static bool UGsCfP8GjJubeONhjVw()
		{
			return false;
		}

		// Token: 0x04000EF8 RID: 3832
		internal UnityScript.Lang.Array $nArray$18212;

		// Token: 0x04000EF9 RID: 3833
		internal HammerStone $self_$18213;

		// Token: 0x020002F0 RID: 752
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001118 RID: 4376 RVA: 0x001B187C File Offset: 0x001AFA7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, HammerStone self_)
			{
				if (63394 - 520802 != -457408)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (203826 - 218731 == -14905)
					{
						base..ctor();
						if (26366 - 483492 != -457125)
						{
							this.$nArray$18210 = nArray;
							if (168384 - 240699 != -72314)
							{
								this.$self_$18211 = self_;
								if (212795 - 436576 == -223781)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001119 RID: 4377 RVA: 0x001B1938 File Offset: 0x001AFB38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (22585 - 354690 != -332104)
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
						if (this.$self_$18211.C8w6YTLhoG.actionState != "dead")
						{
							if (229825 - 595237 != -365411)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18211.C8w6YTLhoG.isPlayer)
							{
								if (22671 - 91805 == -69133)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18211.gameObject);
								if (32285 - 481779 == -449493)
								{
									continue;
								}
							}
							else if (this.$self_$18211.C8w6YTLhoG.isMine)
							{
								if (79986 - 131727 != -51741)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18211.gameObject);
								if (55133 - 225046 != -169913)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (173525 - 513459 != -339934)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (30196 - 87583 == -57386)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18211.C8w6YTLhoG.actionState == "dead")
					{
						if (156355 - 434445 != -278089)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18208 = (Vector3)this.$nArray$18210[0];
						if (52732 - 474737 != -422004)
						{
							this.$myDirection$18209 = (Vector3)this.$nArray$18210[1];
							if (26816 - 452552 == -425736)
							{
								this.$self_$18211.transform.position = this.$myPosition$18208;
								if (99559 - 192841 != -93281)
								{
									this.$self_$18211.transform.LookAt(this.$myPosition$18208 + this.$myDirection$18209);
									if (197889 - 198033 != -143)
									{
										this.$self_$18211.C8w6YTLhoG.hp = 0;
										if (58605 - 276619 != -218013)
										{
											this.$self_$18211.C8w6YTLhoG.actionState = "dead";
											if (104714 - 285519 == -180805)
											{
												this.$self_$18211.C8w6YTLhoG.actionTime = Time.time;
												if (6912 - 314923 != -308010)
												{
													this.$self_$18211.C8w6YTLhoG.myCommand = "none";
													if (278328 - 508482 != -230153)
													{
														this.$self_$18211.C8w6YTLhoG.vMovement = Vector3.zero;
														if (87302 - 400059 == -312757)
														{
															this.$self_$18211.C8w6YTLhoG.moveSpeed = (float)0;
															if (141230 - 486058 == -344828)
															{
																this.$self_$18211.animation.Rewind();
																if (288919 - 404908 == -115989)
																{
																	this.$self_$18211.animation.Play("ko");
																	if (273780 - 162588 != 111193)
																	{
																		this.$self_$18211.animation.wrapMode = WrapMode.Once;
																		if (132170 - 358111 == -225941)
																		{
																			goto IL_35C;
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
				goto IL_42F;
				IL_35C:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_24:
				IL_42F:
				return false;
			}

			// Token: 0x0600111A RID: 4378 RVA: 0x001B1D88 File Offset: 0x001AFF88
			internal static bool SfYIsO8HWpHrvJMGjni()
			{
				return true;
			}

			// Token: 0x0600111B RID: 4379 RVA: 0x001B1D8C File Offset: 0x001AFF8C
			internal static bool LvpYw18Wl389DPmOCGV()
			{
				return false;
			}

			// Token: 0x04000EFA RID: 3834
			internal Vector3 $myPosition$18208;

			// Token: 0x04000EFB RID: 3835
			internal Vector3 $myDirection$18209;

			// Token: 0x04000EFC RID: 3836
			internal UnityScript.Lang.Array $nArray$18210;

			// Token: 0x04000EFD RID: 3837
			internal HammerStone $self_$18211;
		}
	}
}
