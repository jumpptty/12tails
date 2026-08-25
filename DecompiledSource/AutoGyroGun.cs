using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E7A RID: 3706
[Serializable]
public class AutoGyroGun : MonoBehaviour
{
	// Token: 0x06005406 RID: 21510 RVA: 0x00A39818 File Offset: 0x00A37A18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AutoGyroGun()
	{
		if (241749 - 407158 != -165408)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (66460 - 408412 == -341952)
			{
				base..ctor();
				if (163870 - 379 == 163491)
				{
					this.mLv = 1;
					if (93704 - 273410 == -179706)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005407 RID: 21511 RVA: 0x00A398B0 File Offset: 0x00A37AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (248529 - 560846 != -312317)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (196039 - 494661 == -298622)
			{
				this.mChar.actionTime = Time.time;
				if (188496 - 178526 != 9971)
				{
					this.mChar.myCommand = "none";
					if (257887 - 414406 == -156519)
					{
						this.oE5cIo72oLg = Time.time + (float)2;
						if (18775 - 185579 == -166804)
						{
							this.gR3cIjab8wb = Time.time + (float)3;
							if (34750 - 76434 != -41683)
							{
								this.vaQcImMuTT2 = this.transform.Find("AutoGyroGun_tri/base/leg1");
								if (14154 - 100050 != -85895)
								{
									string type = this.mChar.Type;
									if (101702 - 588392 == -486690)
									{
										if (type == "AutoGyroGun1")
										{
											if (252626 - 471434 != -218807)
											{
												this.mChar.hp = (this.mChar.mhp = 50);
												if (283249 - 445834 != -162584)
												{
													this.mChar.atk = (this.mChar.def = (this.mChar.agi = (this.mChar.vit = (this.mChar.mag = (this.mChar.cha = (this.mChar.tal = (this.mChar.lck = 10)))))));
													if (183581 - 474044 != -290462)
													{
														break;
													}
												}
											}
										}
										else if (type == "AutoGyroGun2")
										{
											if (110450 - 307909 == -197459)
											{
												this.mChar.hp = (this.mChar.mhp = 100);
												if (7751 - 208915 != -201163)
												{
													this.mChar.atk = (this.mChar.def = (this.mChar.agi = (this.mChar.vit = (this.mChar.mag = (this.mChar.cha = (this.mChar.tal = (this.mChar.lck = 20)))))));
													if (174763 - 281274 != -106510)
													{
														break;
													}
												}
											}
										}
										else if (type == "AutoGyroGun3")
										{
											if (142835 - 527068 != -384232)
											{
												this.mChar.hp = (this.mChar.mhp = 150);
												if (149652 - 39184 == 110468)
												{
													this.mChar.atk = (this.mChar.def = (this.mChar.agi = (this.mChar.vit = (this.mChar.mag = (this.mChar.cha = (this.mChar.tal = (this.mChar.lck = 30)))))));
													if (26032 - 469099 == -443067)
													{
														break;
													}
												}
											}
										}
										else
										{
											if (!(type == "AutoGyroGun4"))
											{
												break;
											}
											if (267974 - 161543 != 106432)
											{
												this.mChar.hp = (this.mChar.mhp = 200);
												if (121988 - 555772 == -433784)
												{
													this.mChar.atk = (this.mChar.def = (this.mChar.agi = (this.mChar.vit = (this.mChar.mag = (this.mChar.cha = (this.mChar.tal = (this.mChar.lck = 40)))))));
													if (298889 - 192199 == 106690)
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

	// Token: 0x06005408 RID: 21512 RVA: 0x00A39E0C File Offset: 0x00A3800C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (131576 - 113288 != 18289)
		{
		}
		for (;;)
		{
			if (!this.WtCcIiIfuee)
			{
				if (87268 - 2738 == 84530)
				{
					break;
				}
			}
			else if (this.k89cIDqXwNa)
			{
				if (205610 - 88132 == 117478)
				{
					break;
				}
			}
			else
			{
				if (this.mChar.hp <= 0)
				{
					if (14385 - 5981 == 8405)
					{
						continue;
					}
					if (this.mChar.actionState != "dead")
					{
						if (242344 - 565803 != -323459)
						{
							continue;
						}
						if (this.mChar.isMine)
						{
							if (72369 - 349825 != -277456)
							{
								continue;
							}
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (205635 - 359208 == -153572)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (178714 - 586580 == -407865)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (126823 - 563346 != -436522)
							{
								break;
							}
							continue;
						}
						else
						{
							this.mChar.hp = 1;
							if (282901 - 199917 != 82985)
							{
								break;
							}
							continue;
						}
					}
				}
				if (this.mChar.isSummon)
				{
					if (30146 - 412054 == -381907)
					{
						continue;
					}
					if (!this.T6UcIB6luWJ)
					{
						if (156864 - 191445 != -34581)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (207937 - 547287 != -339350)
						{
							continue;
						}
						break;
					}
				}
				if (this.mChar.isSummon)
				{
					if (273881 - 516963 != -243082)
					{
						continue;
					}
					if (this.T6UcIB6luWJ.hp <= 0)
					{
						if (203777 - 577626 == -373848)
						{
							continue;
						}
						if (this.mChar.actionState != "dead")
						{
							if (24005 - 392092 != -368087)
							{
								continue;
							}
							if (!this.mChar.isMine)
							{
								break;
							}
							if (252247 - 84181 != 168066)
							{
								continue;
							}
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (275978 - 145860 != 130118)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (162684 - 231288 == -68603)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (232398 - 514921 != -282523)
							{
								continue;
							}
							break;
						}
					}
				}
				if (this.mChar.isSummon)
				{
					if (176286 - 491564 != -315278)
					{
						continue;
					}
					if (Time.time > this.kb3cI81tTRs)
					{
						if (204998 - 176412 != 28586)
						{
							continue;
						}
						if (this.mChar.actionState != "dead")
						{
							if (142664 - 381993 == -239328)
							{
								continue;
							}
							if (!this.mChar.isMine)
							{
								break;
							}
							if (46256 - 419267 != -373011)
							{
								continue;
							}
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (208464 - 189033 != 19431)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (187567 - 35600 != 151967)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (29114 - 485997 != -456882)
							{
								break;
							}
							continue;
						}
					}
				}
				if (!this.mChar.isMine)
				{
					break;
				}
				if (145506 - 388454 != -242947)
				{
					if (this.mChar.isControlled)
					{
						break;
					}
					if (228069 - 557328 == -329259)
					{
						this.AIControl();
						if (122726 - 220584 == -97858)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005409 RID: 21513 RVA: 0x00A3A398 File Offset: 0x00A38598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (3110 - 588314 != -585204)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (5736 - 139085 != -133348)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (240313 - 529454 == -289141)
				{
					if (35603 - 206418 != -170814)
					{
						if (ActionName == "RPC_fire")
						{
							if (247912 - 454521 != -206609)
							{
								continue;
							}
							v = 1;
							if (210923 - 21230 == 189694)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_hide")
						{
							if (58598 - 243160 != -184562)
							{
								continue;
							}
							v = 11;
							if (30671 - 112123 == -81451)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_unhide")
						{
							if (241771 - 426770 != -184999)
							{
								continue;
							}
							v = 12;
							if (223037 - 37478 == 185560)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (284577 - 504087 != -219509)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (212162 - 563058 != -350895)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (207427 - 210395 == -2968)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (185656 - 90441 != 95216)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (100431 - 377651 != -277219)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (258656 - 50601 != 208056)
											{
												Hashtable hashtable = new Hashtable();
												if (295603 - 532019 == -236416)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (189439 - 377183 != -187743)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (12935 - 353874 == -340939)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (22382 - 202344 != -179961)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (242617 - 53967 != 188651)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (65325 - 443830 == -378505)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (280622 - 105361 == 175261)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (156869 - 518544 != -361674)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (189995 - 456965 != -266969)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (754 - 401593 == -400839)
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

	// Token: 0x0600540A RID: 21514 RVA: 0x00A3A838 File Offset: 0x00A38A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (233647 - 171748 != 61899)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (166013 - 159153 != 6861)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (120750 - 440300 != -319549)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (121233 - 192837 == -71604)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (37440 - 539659 != -502218)
						{
							int num2 = num;
							if (149659 - 579460 == -429801)
							{
								if (num2 == 1)
								{
									if (42407 - 579208 != -536800)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (46824 - 305017 == -258193)
										{
											this.StartCoroutine_Auto(this.RPC_fire(mPos, tDir, tID));
											if (137054 - 589739 != -452684)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (213599 - 233283 != -19683)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (138010 - 548206 != -410195)
										{
											this.StartCoroutine_Auto(this.RPC_hide(mPos, tDir, tID));
											if (139562 - 86012 == 53550)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 12)
								{
									if (6304 - 481563 == -475259)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (261657 - 491916 != -230258)
										{
											this.StartCoroutine_Auto(this.RPC_unhide(mPos, tDir, tID));
											if (213340 - 95232 == 118108)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (204558 - 299039 == -94481)
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

	// Token: 0x0600540B RID: 21515 RVA: 0x00A3AB50 File Offset: 0x00A38D50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (44783 - 123491 != -78707)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (237489 - 199455 == 38034)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (18657 - 314193 == -295536)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (46768 - 279359 != -232590)
					{
						Vector3 normalized = vector.normalized;
						if (278249 - 335444 == -57195)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (245216 - 435185 != -189968)
							{
								if (68886 - 544989 == -476103)
								{
									if (gameObject)
									{
										if (111006 - 75814 == 35193)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (265604 - 271166 != -5562)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (174055 - 164220 != 9835)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (21126 - 415071 != -393945)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (30874 - 115623 != -84748)
									{
										this.StartCoroutine_Auto(this.RPC_fire(this.transform.position, normalized, 0));
										if (89171 - 342863 != -253691)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (230070 - 128615 != 101456)
											{
												this.ActionEvent("RPC_fire", this.transform.position, normalized, 0);
												if (146957 - 85793 == 61164)
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

	// Token: 0x0600540C RID: 21516 RVA: 0x00A3AE0C File Offset: 0x00A3900C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x0600540D RID: 21517 RVA: 0x00A3AE24 File Offset: 0x00A39024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600540E RID: 21518 RVA: 0x00A3AE28 File Offset: 0x00A39028
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AutoGyroGun.$RPC_fire$34300(tDir, this).GetEnumerator();
	}

	// Token: 0x0600540F RID: 21519 RVA: 0x00A3AE38 File Offset: 0x00A39038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator create(CharacterControl nOwnerChar, int nOwnerID, int nLife)
	{
		return new AutoGyroGun.$create$34315(nOwnerChar, nOwnerID, nLife, this).GetEnumerator();
	}

	// Token: 0x06005410 RID: 21520 RVA: 0x00A3AE48 File Offset: 0x00A39048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_hide(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AutoGyroGun.$RPC_hide$34324(this).GetEnumerator();
	}

	// Token: 0x06005411 RID: 21521 RVA: 0x00A3AE58 File Offset: 0x00A39058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_unhide(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AutoGyroGun.$RPC_unhide$34327(this).GetEnumerator();
	}

	// Token: 0x06005412 RID: 21522 RVA: 0x00A3AE68 File Offset: 0x00A39068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (99953 - 321982 != -222029)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (34024 - 40559 == -6534)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					if (83992 - 65769 != 18223)
					{
						continue;
					}
					break;
				}
			}
			if (this.mChar.actionState == "standby")
			{
				if (49157 - 29664 != 19494)
				{
					if (Time.time > this.oE5cIo72oLg)
					{
						if (248423 - 259634 == -11210)
						{
							continue;
						}
						if (this.mChar.isTimeOut("nAttack") == (float)0)
						{
							if (98810 - 225696 == -126885)
							{
								continue;
							}
							this.oE5cIo72oLg = Time.time + (float)1;
							if (168036 - 206022 == -37985)
							{
								continue;
							}
							this.findAttackTarget();
							if (229145 - 255914 == -26768)
							{
								continue;
							}
							if (this.QJKcIkhDjgc)
							{
								if (133200 - 597588 == -464387)
								{
									continue;
								}
								if ((CharacterControl)this.QJKcIkhDjgc.GetComponent(typeof(CharacterControl)) != null)
								{
									if (219753 - 364528 == -144774)
									{
										continue;
									}
									this.gR3cIjab8wb = Time.time + (float)6;
									if (33398 - 320870 != -287472)
									{
										continue;
									}
									this.StartCoroutine_Auto(this.RPC_fire(this.transform.position, this.QJKcIkhDjgc.collider.bounds.center - this.transform.position, 0));
									if (204294 - 421005 == -216710)
									{
										continue;
									}
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (249525 - 516215 == -266689)
									{
										continue;
									}
									this.ActionEvent("RPC_fire", this.transform.position, this.QJKcIkhDjgc.collider.bounds.center - this.transform.position, 0);
									if (71165 - 310967 != -239801)
									{
										break;
									}
									continue;
								}
							}
							this.mChar.actionTime = Time.time;
							if (21744 - 593381 == -571636)
							{
								continue;
							}
							if (!this.T6UcIB6luWJ)
							{
								break;
							}
							if (214636 - 497088 == -282451)
							{
								continue;
							}
							if (!this.T6UcIB6luWJ.hasSkill(403))
							{
								break;
							}
							if (235657 - 146700 == 88958)
							{
								continue;
							}
							if (this.gR3cIjab8wb >= Time.time)
							{
								break;
							}
							if (162031 - 307360 == -145328)
							{
								continue;
							}
							this.StartCoroutine_Auto(this.RPC_hide(this.transform.position, this.transform.forward, 0));
							if (150574 - 96975 == 53600)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (75458 - 100971 != -25513)
							{
								continue;
							}
							this.ActionEvent("RPC_hide", this.transform.position, this.transform.forward, 0);
							if (182190 - 586916 != -404725)
							{
								break;
							}
							continue;
						}
					}
					if (!this.QJKcIkhDjgc)
					{
						break;
					}
					if (107205 - 932 != 106274)
					{
						if (Vector3.Distance(this.transform.position, this.QJKcIkhDjgc.transform.position) > (float)(8 + 4 * this.mLv))
						{
							if (72513 - 444088 == -371575)
							{
								this.QJKcIkhDjgc = null;
								if (91403 - 276962 == -185559)
								{
									break;
								}
							}
						}
						else
						{
							this.vaQcImMuTT2.rotation = Quaternion.FromToRotation(Vector3.right, global::Math.vFlat(this.QJKcIkhDjgc.transform.position - this.transform.position));
							if (93204 - 582031 != -488826)
							{
								Vector3 localEulerAngles = this.vaQcImMuTT2.localEulerAngles;
								if (17756 - 15836 == 1920)
								{
									float z = localEulerAngles.z - (float)90;
									if (95872 - 244188 != -148315)
									{
										Vector3 localEulerAngles2 = this.vaQcImMuTT2.localEulerAngles;
										if (32119 - 126699 != -94579)
										{
											localEulerAngles2.z = z;
											if (60934 - 257441 != -196506 && 231415 - 29292 != 202124)
											{
												this.vaQcImMuTT2.localEulerAngles = localEulerAngles2;
												if (217485 - 414621 == -197136)
												{
													if (21166 - 57133 != -35966)
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
				if (!(this.mChar.actionState == "attack"))
				{
					break;
				}
				if (158410 - 550893 == -392483)
				{
					if (!(this.mChar.myCommand == "hide"))
					{
						break;
					}
					if (79705 - 397332 == -317627)
					{
						if (Time.time <= this.oE5cIo72oLg)
						{
							break;
						}
						if (18083 - 248543 != -230459)
						{
							this.oE5cIo72oLg = Time.time + (float)1;
							if (266474 - 373375 == -106901)
							{
								this.findAttackTarget();
								if (140317 - 423056 == -282739)
								{
									if (!this.QJKcIkhDjgc)
									{
										break;
									}
									if (167142 - 73561 != 93582)
									{
										if (!((CharacterControl)this.QJKcIkhDjgc.GetComponent(typeof(CharacterControl)) != null))
										{
											break;
										}
										if (115142 - 551348 == -436206)
										{
											this.gR3cIjab8wb = Time.time + (float)6;
											if (113400 - 19958 == 93442)
											{
												this.StartCoroutine_Auto(this.RPC_unhide(this.transform.position, this.transform.forward, 0));
												if (40152 - 238068 != -197915)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (76177 - 285187 != -209009)
													{
														this.ActionEvent("RPC_unhide", this.transform.position, this.transform.forward, 0);
														if (261378 - 355650 == -94272)
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

	// Token: 0x06005413 RID: 21523 RVA: 0x00A3B680 File Offset: 0x00A39880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void findAttackTarget()
	{
		if (121455 - 89963 != 31493)
		{
		}
		for (;;)
		{
			UnityScript.Lang.Array array = Hate.findEnemies(this.transform.position, (float)(8 + 4 * this.mLv), this.gameObject.layer);
			if (195711 - 533221 != -337509)
			{
				if (array.length > 0)
				{
					if (272584 - 159366 == 113218)
					{
						object obj2;
						object obj = obj2 = array[UnityEngine.Random.Range(0, array.length)];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.QJKcIkhDjgc = (GameObject)obj2;
						if (191387 - 368765 == -177378)
						{
							break;
						}
					}
				}
				else
				{
					this.QJKcIkhDjgc = null;
					if (59127 - 64103 != -4975)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005414 RID: 21524 RVA: 0x00A3B798 File Offset: 0x00A39998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new AutoGyroGun.$RPC_dead$34330(nArray, this).GetEnumerator();
	}

	// Token: 0x06005415 RID: 21525 RVA: 0x00A3B7A8 File Offset: 0x00A399A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005416 RID: 21526 RVA: 0x00A3B7AC File Offset: 0x00A399AC
	internal static bool EtAdMv5sgglwokn9iKu5()
	{
		return true;
	}

	// Token: 0x06005417 RID: 21527 RVA: 0x00A3B7B0 File Offset: 0x00A399B0
	internal static bool NyMUub5sfDvv3hjNPVG2()
	{
		return false;
	}

	// Token: 0x04005D1D RID: 23837
	public CharacterControl mChar;

	// Token: 0x04005D1E RID: 23838
	public int mLv;

	// Token: 0x04005D1F RID: 23839
	private CharacterControl T6UcIB6luWJ;

	// Token: 0x04005D20 RID: 23840
	private int I7BcI0A0wLj;

	// Token: 0x04005D21 RID: 23841
	private float kb3cI81tTRs;

	// Token: 0x04005D22 RID: 23842
	private bool WtCcIiIfuee;

	// Token: 0x04005D23 RID: 23843
	private bool k89cIDqXwNa;

	// Token: 0x04005D24 RID: 23844
	private Transform vaQcImMuTT2;

	// Token: 0x04005D25 RID: 23845
	private float gR3cIjab8wb;

	// Token: 0x04005D26 RID: 23846
	public GameObject autoGyroGun_fire;

	// Token: 0x04005D27 RID: 23847
	public AudioClip nAttack_fx;

	// Token: 0x04005D28 RID: 23848
	public AudioClip create_fx;

	// Token: 0x04005D29 RID: 23849
	private float oE5cIo72oLg;

	// Token: 0x04005D2A RID: 23850
	private GameObject QJKcIkhDjgc;

	// Token: 0x02000E7B RID: 3707
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fire$34300 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005418 RID: 21528 RVA: 0x00A3B7B4 File Offset: 0x00A399B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fire$34300(Vector3 tDir, AutoGyroGun self_)
		{
			if (80418 - 270163 != -189745)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247659 - 250829 != -3169)
				{
					base..ctor();
					if (174306 - 576959 != -402652)
					{
						this.$tDir$34313 = tDir;
						if (22691 - 246861 == -224170)
						{
							this.$self_$34314 = self_;
							if (152539 - 285675 == -133136)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x00A3B870 File Offset: 0x00A39A70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AutoGyroGun.$RPC_fire$34300.$(this.$tDir$34313, this.$self_$34314);
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x00A3B884 File Offset: 0x00A39A84
		internal static bool AudZZh5sngoMmkGchwZI()
		{
			return true;
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x00A3B888 File Offset: 0x00A39A88
		internal static bool Cho1Yh5s6c8YNbaQLnmw()
		{
			return false;
		}

		// Token: 0x04005D2B RID: 23851
		internal Vector3 $tDir$34313;

		// Token: 0x04005D2C RID: 23852
		internal AutoGyroGun $self_$34314;

		// Token: 0x02000E7C RID: 3708
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600541C RID: 21532 RVA: 0x00A3B88C File Offset: 0x00A39A8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 tDir, AutoGyroGun self_)
			{
				if (196322 - 209649 != -13327)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277501 - 270142 != 7360)
					{
						base..ctor();
						if (195116 - 80140 == 114976)
						{
							this.$tDir$34311 = tDir;
							if (117395 - 141887 != -24491)
							{
								this.$self_$34312 = self_;
								if (287996 - 588340 == -300344)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600541D RID: 21533 RVA: 0x00A3B948 File Offset: 0x00A39B48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212305 - 66302 != 146003)
				{
				}
				for (;;)
				{
					IL_140:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A47;
					case 2:
						if (!this.$self_$34312.mChar.isMine)
						{
							goto IL_3B9;
						}
						if (170901 - 492380 != -321479)
						{
							continue;
						}
						this.$hitLayer$34305 = 130816 - (1 << this.$self_$34312.gameObject.layer);
						if (285737 - 479505 != -193768)
						{
							continue;
						}
						this.$hitList$34306 = Damage.FindRecTarget(this.$self_$34312.transform.position, this.$fireVector$34301, 0.2f, 0.5f, (float)(8 + 4 * this.$self_$34312.mLv), (float)2, this.$hitLayer$34305);
						if (288024 - 391290 != -103266)
						{
							continue;
						}
						this.$$iterator$9842$34308 = UnityRuntimeServices.GetEnumerator(this.$hitList$34306);
						if (28108 - 519745 != -491637)
						{
							continue;
						}
						while (this.$$iterator$9842$34308.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$9842$34308.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$34307 = (GameObject)obj2;
							if (199983 - 221315 != -21332)
							{
								goto IL_140;
							}
							this.$self_$34312.mChar.hit(1, this.$hitObject$34307, this.$self_$34312.mChar.atk, 1, 0, Vector3.zero);
							if (11930 - 356381 != -344451)
							{
								goto IL_140;
							}
							UnityRuntimeServices.Update(this.$$iterator$9842$34308, this.$hitObject$34307);
							if (69719 - 155289 != -85570)
							{
								goto IL_140;
							}
						}
						if (163655 - 162307 != 1348)
						{
							continue;
						}
						goto IL_3B9;
					case 3:
						if (this.$self_$34312.mChar.actionState == "attack")
						{
							if (176195 - 102240 == 73956)
							{
								continue;
							}
							if (this.$self_$34312.mChar.myCommand == "fire")
							{
								if (266475 - 376125 == -109649)
								{
									continue;
								}
								this.$self_$34312.mChar.actionState = "standby";
								if (188288 - 228148 == -39859)
								{
									continue;
								}
								this.$self_$34312.mChar.actionTime = Time.time;
								if (261828 - 73057 == 188772)
								{
									continue;
								}
								this.$self_$34312.mChar.myCommand = "none";
								if (264882 - 205708 != 59174)
								{
									continue;
								}
								this.$self_$34312.mChar.nPosition = this.$self_$34312.transform.position;
								if (186892 - 148034 == 38859)
								{
									continue;
								}
								this.$self_$34312.animation.CrossFade("root");
								if (263506 - 389392 == -125885)
								{
									continue;
								}
								this.$self_$34312.animation.wrapMode = WrapMode.Loop;
								if (115258 - 218097 != -102839)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (105653 - 554267 != -448614)
						{
							continue;
						}
						goto IL_A47;
					default:
						if (70339 - 522967 != -452628)
						{
							continue;
						}
						break;
					}
					this.$self_$34312.mChar.actionState = "attack";
					if (196829 - 422526 == -225697)
					{
						this.$self_$34312.mChar.actionTime = Time.time;
						if (150236 - 351802 != -201565)
						{
							this.$self_$34312.mChar.myCommand = "fire";
							if (167036 - 342291 != -175254)
							{
								this.$self_$34312.mChar.addTimeOut("nAttack", (float)2);
								if (205950 - 254323 == -48373)
								{
									this.$self_$34312.vaQcImMuTT2.rotation = Quaternion.FromToRotation(Vector3.right, global::Math.vFlat(this.$tDir$34311));
									if (83451 - 70152 == 13299)
									{
										this.$$13800$34309 = this.$self_$34312.vaQcImMuTT2.localEulerAngles.z - (float)90;
										if (295663 - 20985 != 274679 && 142029 - 527813 != -385783)
										{
											this.$$13801$34310 = this.$self_$34312.vaQcImMuTT2.localEulerAngles;
											if (123174 - 310464 != -187289)
											{
												if (47059 - 373293 == -326234)
												{
													float num = this.$$13801$34310.z = this.$$13800$34309;
													if (17785 - 242684 == -224899)
													{
														if (233789 - 380896 == -147107)
														{
															Vector3 vector = this.$self_$34312.vaQcImMuTT2.localEulerAngles = this.$$13801$34310;
															if (86984 - 330935 == -243951)
															{
																if (260457 - 161308 != 99150)
																{
																	this.$self_$34312.animation.CrossFade("fire");
																	if (162658 - 211723 != -49064)
																	{
																		this.$self_$34312.animation.wrapMode = WrapMode.Loop;
																		if (142915 - 358572 == -215657)
																		{
																			if (this.$self_$34312.nAttack_fx)
																			{
																				if (41161 - 583450 == -542288)
																				{
																					continue;
																				}
																				this.$self_$34312.audio.PlayOneShot(this.$self_$34312.nAttack_fx);
																				if (13007 - 502215 != -489208)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				Debug.LogError("Cannot find nAttack_fx effect");
																				if (15159 - 475946 != -460787)
																				{
																					continue;
																				}
																			}
																			this.$fireVector$34301 = global::Math.vFlat(this.$tDir$34311).normalized;
																			if (65501 - 166679 != -101177)
																			{
																				this.$firePos$34302 = this.$self_$34312.transform.position;
																				if (157557 - 352610 != -195052)
																				{
																					this.$fireRot$34303 = Quaternion.FromToRotation(Vector3.forward, this.$fireVector$34301);
																					if (120684 - 277701 != -157016)
																					{
																						this.$$switch$3912$34304 = this.$self_$34312.mLv;
																						if (149671 - 466723 != -317051)
																						{
																							if (this.$$switch$3912$34304 == 1)
																							{
																								if (278563 - 196128 == 82436)
																								{
																									continue;
																								}
																								this.$firePos$34302 += this.$self_$34312.transform.TransformDirection((float)0, 0.7f, 0.5f);
																								if (259853 - 358144 != -98291)
																								{
																									continue;
																								}
																							}
																							else if (this.$$switch$3912$34304 == 2)
																							{
																								if (296678 - 484828 != -188150)
																								{
																									continue;
																								}
																								this.$firePos$34302 += this.$self_$34312.transform.TransformDirection((float)0, 0.8f, 0.5f);
																								if (132338 - 522656 == -390317)
																								{
																									continue;
																								}
																							}
																							else if (this.$$switch$3912$34304 == 3)
																							{
																								if (234350 - 514464 != -280114)
																								{
																									continue;
																								}
																								this.$firePos$34302 += this.$self_$34312.transform.TransformDirection((float)0, 1f, 0.5f);
																								if (38645 - 121860 == -83214)
																								{
																									continue;
																								}
																							}
																							else if (this.$$switch$3912$34304 == 4)
																							{
																								if (142806 - 322558 != -179752)
																								{
																									continue;
																								}
																								this.$firePos$34302 += this.$self_$34312.transform.TransformDirection((float)0, 1.2f, 0.5f);
																								if (138422 - 550722 == -412299)
																								{
																									continue;
																								}
																							}
																							if (this.$self_$34312.autoGyroGun_fire)
																							{
																								if (254355 - 210021 != 44335)
																								{
																									UnityEngine.Object.Instantiate(this.$self_$34312.autoGyroGun_fire, this.$firePos$34302, this.$fireRot$34303);
																									if (171232 - 107523 != 63710)
																									{
																										goto Block_40;
																									}
																								}
																							}
																							else
																							{
																								Debug.LogError("Cannot find autoGyroGun_fire effect");
																								if (215033 - 503499 == -288466)
																								{
																									goto IL_58F;
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
				IL_3B9:
				return this.Yield(3, new WaitForSeconds(0.6f));
				IL_58F:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_40:
				goto IL_58F;
				IL_A47:
				return false;
			}

			// Token: 0x0600541E RID: 21534 RVA: 0x00A3C3B0 File Offset: 0x00A3A5B0
			internal static bool dlIGeB5si4iREkXeX6nb()
			{
				return true;
			}

			// Token: 0x0600541F RID: 21535 RVA: 0x00A3C3B4 File Offset: 0x00A3A5B4
			internal static bool fCpADt5sKlE3ekIVVZwi()
			{
				return false;
			}

			// Token: 0x04005D2D RID: 23853
			internal Vector3 $fireVector$34301;

			// Token: 0x04005D2E RID: 23854
			internal Vector3 $firePos$34302;

			// Token: 0x04005D2F RID: 23855
			internal Quaternion $fireRot$34303;

			// Token: 0x04005D30 RID: 23856
			internal int $$switch$3912$34304;

			// Token: 0x04005D31 RID: 23857
			internal int $hitLayer$34305;

			// Token: 0x04005D32 RID: 23858
			internal UnityScript.Lang.Array $hitList$34306;

			// Token: 0x04005D33 RID: 23859
			internal GameObject $hitObject$34307;

			// Token: 0x04005D34 RID: 23860
			internal IEnumerator $$iterator$9842$34308;

			// Token: 0x04005D35 RID: 23861
			internal float $$13800$34309;

			// Token: 0x04005D36 RID: 23862
			internal Vector3 $$13801$34310;

			// Token: 0x04005D37 RID: 23863
			internal Vector3 $tDir$34311;

			// Token: 0x04005D38 RID: 23864
			internal AutoGyroGun $self_$34312;
		}
	}

	// Token: 0x02000E7D RID: 3709
	[CompilerGenerated]
	[Serializable]
	internal sealed class $create$34315 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005420 RID: 21536 RVA: 0x00A3C3B8 File Offset: 0x00A3A5B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $create$34315(CharacterControl nOwnerChar, int nOwnerID, int nLife, AutoGyroGun self_)
		{
			if (4469 - 527852 != -523383)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (257415 - 212772 == 44643)
				{
					base..ctor();
					if (92348 - 524925 != -432576)
					{
						this.$nOwnerChar$34320 = nOwnerChar;
						if (214967 - 355285 == -140318)
						{
							this.$nOwnerID$34321 = nOwnerID;
							if (68324 - 34207 == 34117)
							{
								this.$nLife$34322 = nLife;
								if (1170 - 202533 != -201362)
								{
									this.$self_$34323 = self_;
									if (144026 - 318189 == -174163)
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

		// Token: 0x06005421 RID: 21537 RVA: 0x00A3C4B8 File Offset: 0x00A3A6B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AutoGyroGun.$create$34315.$(this.$nOwnerChar$34320, this.$nOwnerID$34321, this.$nLife$34322, this.$self_$34323);
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x00A3C4D8 File Offset: 0x00A3A6D8
		internal static bool aL0DGe5sdbJ1JyMyGM3o()
		{
			return true;
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x00A3C4DC File Offset: 0x00A3A6DC
		internal static bool MyXmff5sJrHUkyi6QvGB()
		{
			return false;
		}

		// Token: 0x04005D39 RID: 23865
		internal CharacterControl $nOwnerChar$34320;

		// Token: 0x04005D3A RID: 23866
		internal int $nOwnerID$34321;

		// Token: 0x04005D3B RID: 23867
		internal int $nLife$34322;

		// Token: 0x04005D3C RID: 23868
		internal AutoGyroGun $self_$34323;

		// Token: 0x02000E7E RID: 3710
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005424 RID: 21540 RVA: 0x00A3C4E0 File Offset: 0x00A3A6E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(CharacterControl nOwnerChar, int nOwnerID, int nLife, AutoGyroGun self_)
			{
				if (116603 - 271876 != -155273)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (155134 - 537092 == -381958)
					{
						base..ctor();
						if (32585 - 343750 == -311165)
						{
							this.$nOwnerChar$34316 = nOwnerChar;
							if (144022 - 43696 != 100327)
							{
								this.$nOwnerID$34317 = nOwnerID;
								if (281858 - 432274 == -150416)
								{
									this.$nLife$34318 = nLife;
									if (231971 - 43052 == 188919)
									{
										this.$self_$34319 = self_;
										if (253579 - 323882 == -70303)
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

			// Token: 0x06005425 RID: 21541 RVA: 0x00A3C5E0 File Offset: 0x00A3A7E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48437 - 401563 != -353126)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2A7;
					case 2:
						this.$self_$34319.mChar.actionState = "standby";
						if (135737 - 483563 == -347825)
						{
							continue;
						}
						this.$self_$34319.animation.Play("root");
						if (293779 - 99829 != 193950)
						{
							continue;
						}
						this.$self_$34319.animation.wrapMode = WrapMode.Loop;
						if (74072 - 182682 == -108609)
						{
							continue;
						}
						this.$self_$34319.WtCcIiIfuee = true;
						if (28678 - 329107 != -300429)
						{
							continue;
						}
						this.YieldDefault(1);
						if (140164 - 395890 != -255725)
						{
							goto Block_15;
						}
						continue;
					default:
						if (186764 - 65794 != 120970)
						{
							continue;
						}
						break;
					}
					this.$self_$34319.T6UcIB6luWJ = this.$nOwnerChar$34316;
					if (249068 - 416206 != -167137)
					{
						this.$self_$34319.I7BcI0A0wLj = this.$nOwnerID$34317;
						if (148070 - 536175 != -388104)
						{
							this.$self_$34319.kb3cI81tTRs = Time.time + (float)this.$nLife$34318;
							if (44698 - 326034 == -281336)
							{
								this.$self_$34319.mChar.actionState = "create";
								if (119906 - 234491 != -114584)
								{
									this.$self_$34319.animation.Play("create");
									if (55415 - 507622 != -452206)
									{
										if (this.$self_$34319.create_fx)
										{
											if (285766 - 340446 == -54680)
											{
												this.$self_$34319.audio.PlayOneShot(this.$self_$34319.create_fx);
												if (294750 - 519838 == -225088)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Cannot find create_fx effect");
											if (37447 - 478627 != -441179)
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
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_15:
				IL_2A7:
				return false;
			}

			// Token: 0x06005426 RID: 21542 RVA: 0x00A3C8A8 File Offset: 0x00A3AAA8
			internal static bool gvMN8s5sDORPVfdddGCo()
			{
				return true;
			}

			// Token: 0x06005427 RID: 21543 RVA: 0x00A3C8AC File Offset: 0x00A3AAAC
			internal static bool TZJvmW5svTDlYvThYK1L()
			{
				return false;
			}

			// Token: 0x04005D3D RID: 23869
			internal CharacterControl $nOwnerChar$34316;

			// Token: 0x04005D3E RID: 23870
			internal int $nOwnerID$34317;

			// Token: 0x04005D3F RID: 23871
			internal int $nLife$34318;

			// Token: 0x04005D40 RID: 23872
			internal AutoGyroGun $self_$34319;
		}
	}

	// Token: 0x02000E7F RID: 3711
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_hide$34324 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005428 RID: 21544 RVA: 0x00A3C8B0 File Offset: 0x00A3AAB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_hide$34324(AutoGyroGun self_)
		{
			if (208690 - 309578 != -100887)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (188121 - 438222 != -250100)
				{
					base..ctor();
					if (245331 - 182570 == 62761)
					{
						this.$self_$34326 = self_;
						if (77808 - 223345 != -145536)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x00A3C948 File Offset: 0x00A3AB48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AutoGyroGun.$RPC_hide$34324.$(this.$self_$34326);
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x00A3C958 File Offset: 0x00A3AB58
		internal static bool tYMrPy5sRl51Z3KLFvd4()
		{
			return true;
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x00A3C95C File Offset: 0x00A3AB5C
		internal static bool KUWr0M5swppmPvQZEq38()
		{
			return false;
		}

		// Token: 0x04005D41 RID: 23873
		internal AutoGyroGun $self_$34326;

		// Token: 0x02000E80 RID: 3712
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600542C RID: 21548 RVA: 0x00A3C960 File Offset: 0x00A3AB60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(AutoGyroGun self_)
			{
				if (11506 - 513746 != -502240)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (81110 - 450224 == -369114)
					{
						base..ctor();
						if (222496 - 185177 == 37319)
						{
							this.$self_$34325 = self_;
							if (237426 - 372819 != -135392)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600542D RID: 21549 RVA: 0x00A3C9F8 File Offset: 0x00A3ABF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208955 - 310131 != -101176)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2D4;
					case 2:
						if (this.$self_$34325.mChar.actionState == "attack")
						{
							if (285670 - 183618 == 102053)
							{
								continue;
							}
							if (this.$self_$34325.mChar.myCommand == "hide")
							{
								if (296650 - 82331 == 214320)
								{
									continue;
								}
								this.$self_$34325.mChar.actionState = "attack";
								if (61385 - 546826 != -485441)
								{
									continue;
								}
								this.$self_$34325.mChar.actionTime = Time.time;
								if (1480 - 139716 != -138236)
								{
									continue;
								}
								this.$self_$34325.mChar.myCommand = "hide";
								if (33393 - 16271 != 17122)
								{
									continue;
								}
								this.$self_$34325.mChar.nPosition = this.$self_$34325.transform.position;
								if (251007 - 141216 != 109791)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (50573 - 276907 != -226334)
						{
							continue;
						}
						goto IL_2D4;
					default:
						if (192665 - 228349 != -35684)
						{
							continue;
						}
						break;
					}
					this.$self_$34325.mChar.actionState = "attack";
					if (160459 - 246871 != -86411)
					{
						this.$self_$34325.mChar.actionTime = Time.time;
						if (171588 - 291445 != -119856)
						{
							this.$self_$34325.mChar.myCommand = "hide";
							if (174183 - 243326 == -69143)
							{
								this.$self_$34325.mChar.addTimeOut("hide", (float)3);
								if (30510 - 359852 == -329342)
								{
									this.$self_$34325.animation.CrossFade("hide");
									if (217017 - 550476 != -333458)
									{
										this.$self_$34325.animation.wrapMode = WrapMode.Once;
										if (114091 - 207522 != -93430)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_2D4:
				return false;
			}

			// Token: 0x0600542E RID: 21550 RVA: 0x00A3CCEC File Offset: 0x00A3AEEC
			internal static bool sIFIib5sqW5waIDjO1oC()
			{
				return true;
			}

			// Token: 0x0600542F RID: 21551 RVA: 0x00A3CCF0 File Offset: 0x00A3AEF0
			internal static bool e8K53A5s7YiR8iUKNKFc()
			{
				return false;
			}

			// Token: 0x04005D42 RID: 23874
			internal AutoGyroGun $self_$34325;
		}
	}

	// Token: 0x02000E81 RID: 3713
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_unhide$34327 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005430 RID: 21552 RVA: 0x00A3CCF4 File Offset: 0x00A3AEF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_unhide$34327(AutoGyroGun self_)
		{
			if (11296 - 99760 != -88464)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (263666 - 575986 != -312319)
				{
					base..ctor();
					if (94558 - 165827 != -71268)
					{
						this.$self_$34329 = self_;
						if (182605 - 183102 == -497)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x00A3CD8C File Offset: 0x00A3AF8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AutoGyroGun.$RPC_unhide$34327.$(this.$self_$34329);
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x00A3CD9C File Offset: 0x00A3AF9C
		internal static bool DOLLPZ5sPHrr7oDVXGq6()
		{
			return true;
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x00A3CDA0 File Offset: 0x00A3AFA0
		internal static bool wGUfVA5s0ISNy2ry6Xwe()
		{
			return false;
		}

		// Token: 0x04005D43 RID: 23875
		internal AutoGyroGun $self_$34329;

		// Token: 0x02000E82 RID: 3714
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005434 RID: 21556 RVA: 0x00A3CDA4 File Offset: 0x00A3AFA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(AutoGyroGun self_)
			{
				if (296030 - 542372 != -246342)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (115651 - 282011 != -166359)
					{
						base..ctor();
						if (269737 - 16927 == 252810)
						{
							this.$self_$34328 = self_;
							if (73197 - 414440 == -341243)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06005435 RID: 21557 RVA: 0x00A3CE3C File Offset: 0x00A3B03C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (298381 - 90249 != 208132)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_32F;
					case 2:
						if (this.$self_$34328.mChar.actionState == "attack")
						{
							if (155276 - 60016 != 95260)
							{
								continue;
							}
							if (this.$self_$34328.mChar.myCommand == "unhide")
							{
								if (104596 - 509159 == -404562)
								{
									continue;
								}
								this.$self_$34328.mChar.actionState = "standby";
								if (5403 - 204519 == -199115)
								{
									continue;
								}
								this.$self_$34328.mChar.actionTime = Time.time;
								if (291924 - 74519 == 217406)
								{
									continue;
								}
								this.$self_$34328.mChar.myCommand = "none";
								if (41126 - 10445 == 30682)
								{
									continue;
								}
								this.$self_$34328.mChar.nPosition = this.$self_$34328.transform.position;
								if (92791 - 404822 == -312030)
								{
									continue;
								}
								this.$self_$34328.animation.Play("root");
								if (114064 - 212953 == -98888)
								{
									continue;
								}
								this.$self_$34328.animation.wrapMode = WrapMode.Loop;
								if (106173 - 353166 == -246992)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (183915 - 22612 != 161304)
						{
							goto Block_11;
						}
						continue;
					default:
						if (290044 - 587736 == -297691)
						{
							continue;
						}
						break;
					}
					this.$self_$34328.mChar.actionState = "attack";
					if (154970 - 287707 == -132737)
					{
						this.$self_$34328.mChar.actionTime = Time.time;
						if (234856 - 379723 == -144867)
						{
							this.$self_$34328.mChar.myCommand = "unhide";
							if (238811 - 177558 == 61253)
							{
								this.$self_$34328.mChar.addTimeOut("hide", (float)3);
								if (232191 - 167133 == 65058)
								{
									this.$self_$34328.animation.CrossFade("create");
									if (236642 - 59595 != 177048)
									{
										this.$self_$34328.animation.wrapMode = WrapMode.Once;
										if (28347 - 398945 != -370597)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_11:
				IL_32F:
				return false;
			}

			// Token: 0x06005436 RID: 21558 RVA: 0x00A3D18C File Offset: 0x00A3B38C
			internal static bool YBqHfU5sbaA1VjYELgBO()
			{
				return true;
			}

			// Token: 0x06005437 RID: 21559 RVA: 0x00A3D190 File Offset: 0x00A3B390
			internal static bool JGJeno5sucG1lPj7uZy9()
			{
				return false;
			}

			// Token: 0x04005D44 RID: 23876
			internal AutoGyroGun $self_$34328;
		}
	}

	// Token: 0x02000E83 RID: 3715
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$34330 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005438 RID: 21560 RVA: 0x00A3D194 File Offset: 0x00A3B394
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$34330(UnityScript.Lang.Array nArray, AutoGyroGun self_)
		{
			if (252195 - 182616 != 69580)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (81904 - 126520 == -44616)
				{
					base..ctor();
					if (256232 - 444856 != -188623)
					{
						this.$nArray$34335 = nArray;
						if (193778 - 170048 != 23731)
						{
							this.$self_$34336 = self_;
							if (145008 - 6000 == 139008)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005439 RID: 21561 RVA: 0x00A3D250 File Offset: 0x00A3B450
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AutoGyroGun.$RPC_dead$34330.$(this.$nArray$34335, this.$self_$34336);
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x00A3D264 File Offset: 0x00A3B464
		internal static bool DSqs2G5sIlMQjxF2ceXa()
		{
			return true;
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x00A3D268 File Offset: 0x00A3B468
		internal static bool GNhN195sBklCU1Ar33We()
		{
			return false;
		}

		// Token: 0x04005D45 RID: 23877
		internal UnityScript.Lang.Array $nArray$34335;

		// Token: 0x04005D46 RID: 23878
		internal AutoGyroGun $self_$34336;

		// Token: 0x02000E84 RID: 3716
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600543C RID: 21564 RVA: 0x00A3D26C File Offset: 0x00A3B46C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, AutoGyroGun self_)
			{
				if (154862 - 528387 != -373524)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222050 - 28071 != 193980)
					{
						base..ctor();
						if (75318 - 75948 != -629)
						{
							this.$nArray$34333 = nArray;
							if (197947 - 460947 == -263000)
							{
								this.$self_$34334 = self_;
								if (97447 - 398291 == -300844)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600543D RID: 21565 RVA: 0x00A3D328 File Offset: 0x00A3B528
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (135442 - 133111 != 2331)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3F1;
					case 2:
						if (!this.$self_$34334.mChar.isPlayer)
						{
							goto IL_2C1;
						}
						if (34139 - 555400 == -521260)
						{
							continue;
						}
						if (!this.$self_$34334.mChar.isMine)
						{
							goto IL_2C1;
						}
						if (129109 - 293485 == -164375)
						{
							continue;
						}
						Camera.main.SendMessage("onDeadPlayer", this.$self_$34334.gameObject);
						if (239372 - 453753 == -214380)
						{
							continue;
						}
						IL_49:
						this.YieldDefault(1);
						if (256185 - 339275 != -83089)
						{
							goto Block_3;
						}
						continue;
						IL_2C1:
						UnityEngine.Object.Destroy(this.$self_$34334.gameObject);
						if (165055 - 215779 != -50723)
						{
							goto IL_49;
						}
						continue;
					default:
						if (77688 - 409993 == -332304)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34334.mChar.actionState == "dead")
					{
						if (3440 - 56848 == -53408)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$34331 = (Vector3)this.$nArray$34333[0];
						if (83450 - 133522 == -50072)
						{
							this.$myDirection$34332 = (Vector3)this.$nArray$34333[1];
							if (89010 - 444208 != -355197)
							{
								this.$self_$34334.transform.position = this.$myPosition$34331;
								if (139327 - 360636 != -221308)
								{
									this.$self_$34334.transform.LookAt(this.$myPosition$34331 + this.$myDirection$34332);
									if (33166 - 185774 != -152607)
									{
										this.$self_$34334.mChar.hp = 0;
										if (28010 - 229877 != -201866)
										{
											this.$self_$34334.mChar.actionState = "dead";
											if (259039 - 593632 != -334592)
											{
												this.$self_$34334.mChar.actionTime = Time.time;
												if (121836 - 514616 != -392779)
												{
													this.$self_$34334.mChar.myCommand = "none";
													if (154429 - 210044 != -55614)
													{
														this.$self_$34334.mChar.vMovement = Vector3.zero;
														if (35129 - 384181 != -349051)
														{
															this.$self_$34334.mChar.moveSpeed = (float)0;
															if (29333 - 498309 != -468975)
															{
																this.$self_$34334.animation.Rewind();
																if (223595 - 359426 != -135830)
																{
																	this.$self_$34334.animation.Play("destroy");
																	if (163837 - 224450 == -60613)
																	{
																		this.$self_$34334.animation.wrapMode = WrapMode.Once;
																		if (169684 - 255052 != -85367)
																		{
																			goto Block_24;
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
				Block_3:
				goto IL_3F1;
				Block_24:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_3F1:
				return false;
			}

			// Token: 0x0600543E RID: 21566 RVA: 0x00A3D738 File Offset: 0x00A3B938
			internal static bool ssjOaf5se1ZkYKavwhub()
			{
				return true;
			}

			// Token: 0x0600543F RID: 21567 RVA: 0x00A3D73C File Offset: 0x00A3B93C
			internal static bool x8W2QB5sroXkK3ygjfga()
			{
				return false;
			}

			// Token: 0x04005D47 RID: 23879
			internal Vector3 $myPosition$34331;

			// Token: 0x04005D48 RID: 23880
			internal Vector3 $myDirection$34332;

			// Token: 0x04005D49 RID: 23881
			internal UnityScript.Lang.Array $nArray$34333;

			// Token: 0x04005D4A RID: 23882
			internal AutoGyroGun $self_$34334;
		}
	}
}
