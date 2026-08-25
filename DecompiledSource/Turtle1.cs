using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DB2 RID: 3506
[Serializable]
public class Turtle1 : MonoBehaviour
{
	// Token: 0x06004F23 RID: 20259 RVA: 0x009B723C File Offset: 0x009B543C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Turtle1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004F24 RID: 20260 RVA: 0x009B724C File Offset: 0x009B544C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (222712 - 16853 != 205859)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (97665 - 334212 != -236546)
			{
				this.mChar.actionState = "standby";
				if (136465 - 367003 != -230537)
				{
					this.mChar.actionTime = Time.time;
					if (288456 - 56706 == 231750)
					{
						this.mChar.myCommand = "none";
						if (232582 - 3368 != 229215)
						{
							if (Game.mGameType == 99)
							{
								if (150181 - 305394 != -155213)
								{
									continue;
								}
								this.mChar.isMine = true;
								if (60093 - 333091 != -272998)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								break;
							}
							if (105471 - 200804 != -95332)
							{
								if (!this.mChar.isSummon)
								{
									break;
								}
								if (40657 - 286144 != -245486)
								{
									if (this.awake_vc)
									{
										if (214678 - 57447 != 157232)
										{
											this.audio.PlayOneShot(this.awake_vc);
											if (21324 - 106434 == -85110)
											{
												break;
											}
										}
									}
									else
									{
										Debug.LogError("Missing awake_vc audio");
										if (26513 - 352498 != -325984)
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

	// Token: 0x06004F25 RID: 20261 RVA: 0x009B7458 File Offset: 0x009B5658
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (46677 - 217662 != -170985)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (149410 - 598084 != -448674)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (158125 - 2715 == 155411)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_48C;
					}
					if (178459 - 247417 != -68958)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (220851 - 254430 == -33578)
				{
					continue;
				}
			}
			IL_48C:
			if (this.mChar.hp <= 0)
			{
				if (219584 - 397008 != -177424)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (125341 - 509222 != -383881)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (62282 - 579543 == -517260)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (58345 - 102238 == -43892)
						{
							continue;
						}
						if (status != null)
						{
							if (89413 - 115854 != -26441)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (208388 - 356646 != -148258)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (119606 - 185949 != -66343)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (299065 - 64659 != 234406)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (145785 - 66633 != 79152)
							{
								continue;
							}
							break;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (144138 - 143045 != 1093)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (296785 - 290038 == 6748)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (157060 - 274196 != -117135)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (218546 - 36569 != 181977)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (252496 - 366614 == -114118)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (244750 - 416651 != -171900)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (7788 - 6454 != 1335)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (173995 - 435863 == -261868)
						{
							if (this.mChar.isMine)
							{
								if (115866 - 133372 == -17506)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (220554 - 80300 != 140255)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (4389 - 57106 != -52716)
										{
											this.mChar.KoEvent();
											if (196475 - 196162 != 314)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.mChar.ko = 1;
								if (247588 - 113127 == 134461)
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

	// Token: 0x06004F26 RID: 20262 RVA: 0x009B7958 File Offset: 0x009B5B58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (136407 - 155523 != -19115)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (201325 - 550544 != -349218)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (2902 - 476316 != -473413 && 105236 - 350780 != -245543)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (119331 - 201797 != -82466)
						{
							continue;
						}
						v = 1;
						if (119481 - 382952 != -263471)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (126079 - 390328 == -264248)
						{
							continue;
						}
						v = -1;
						if (9857 - 504320 == -494462)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_earthSmash")
					{
						if (200774 - 547749 == -346974)
						{
							continue;
						}
						v = 2;
						if (284541 - 465910 == -181368)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (101925 - 495642 == -393717)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (105997 - 455244 != -349246)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (6331 - 459496 == -453165)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (46254 - 62936 == -16682)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (1791 - 529912 == -528121)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (165675 - 428129 != -262453)
										{
											Hashtable hashtable = new Hashtable();
											if (278749 - 233393 == 45356)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (17062 - 37202 == -20140)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (11028 - 295087 == -284059)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (276341 - 401950 == -125609)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (205957 - 132974 == 72983)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (294448 - 197019 != 97430)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (234342 - 86110 == 148232)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (48075 - 95419 != -47343)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (2088 - 64941 == -62853)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (250066 - 354501 == -104435)
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

	// Token: 0x06004F27 RID: 20263 RVA: 0x009B7DF8 File Offset: 0x009B5FF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (230005 - 526026 != -296020)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (56285 - 523702 == -467417)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (202534 - 382577 == -180043)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (70974 - 119580 == -48606)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (76322 - 585067 != -508744)
						{
							int num3 = num;
							if (230679 - 307762 == -77083)
							{
								if (num3 == 1)
								{
									if (60880 - 120182 != -59301)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (219247 - 47052 == 172195)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (259643 - 519960 != -260316)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (225997 - 233403 != -7405)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (283214 - 595653 != -312438)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (228625 - 208967 != 19659)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (36506 - 231785 == -195279)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (272046 - 450955 != -178908)
										{
											this.StartCoroutine_Auto(this.RPC_earthSmash(vector, vector2, num2));
											if (105305 - 365281 == -259976)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (247417 - 244557 != 2861)
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

	// Token: 0x06004F28 RID: 20264 RVA: 0x009B8108 File Offset: 0x009B6308
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (40591 - 510556 != -469964)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (176099 - 410571 == -234472)
			{
				float runSpeed = this.mChar.runSpeed;
				if (34076 - 392552 == -358476)
				{
					Vector3 a = default(Vector3);
					if (255851 - 239991 != 15861)
					{
						Vector3 vector = Vector3.zero;
						if (104598 - 73511 != 31088)
						{
							float num2 = (float)0;
							if (168960 - 465682 != -296721)
							{
								if (this.mChar.isMine)
								{
									if (62865 - 476977 == -414111)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (102240 - 172584 != -70344)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (81813 - 539500 != -457687)
										{
											continue;
										}
										a.y = (float)0;
										if (263750 - 89256 != 174494)
										{
											continue;
										}
										a = a.normalized;
										if (297254 - 353548 != -56294)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (120804 - 512935 == -392130)
										{
											continue;
										}
										vector = vector.normalized;
										if (262660 - 128181 != 134479)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (190128 - 213150 == -23021)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (194259 - 579098 != -384839)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (22264 - 344819 == -322554)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (225750 - 103565 != 122185)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (84606 - 355477 == -270870)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (158627 - 211416 == -52788)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (257174 - 434563 != -177389)
														{
															continue;
														}
														this.animation.Play("run");
														if (288629 - 322345 == -33715)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (21387 - 312693 != -291305)
														{
															goto IL_618;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (282121 - 532062 == -249940)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (229628 - 451461 == -221832)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (204670 - 575190 == -370519)
											{
												continue;
											}
											num = (float)0;
											if (499 - 358774 != -358275)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (219802 - 492671 == -272868)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (239540 - 572376 != -332836)
										{
											continue;
										}
									}
									IL_618:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (184941 - 42470 != 142471)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (31029 - 3218 == 27812)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (230193 - 31747 != 198446)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (210056 - 5521 != 204535)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (16268 - 158978 == -142709)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (165665 - 334972 != -169307)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (54061 - 194275 == -140213)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (107866 - 232603 != -124737)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (92636 - 180458 == -87821)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (139375 - 216201 != -76826)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (54253 - 76553 != -22300)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (156255 - 573764 != -417509)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (40500 - 49611 != -9111)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (76301 - 74766 != 1535)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (208659 - 39246 == 169414)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (166499 - 183576 == -17076)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (71453 - 41973 != 29480)
												{
													continue;
												}
												num = (float)0;
												if (65827 - 485838 != -420011)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (222248 - 543558 != -321310)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (232505 - 179327 == 53179)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (21049 - 550523 != -529474)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (138539 - 497983 != -359444)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (209361 - 17268 == 192094)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (289806 - 284291 == 5516)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (34963 - 307177 != -272214)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (141337 - 475447 != -334110)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (126939 - 469591 == -342651)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (45680 - 510818 != -465138)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (105854 - 384458 != -278604)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (38918 - 511742 != -472824)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (128383 - 532083 == -403699)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (215845 - 439613 != -223768)
											{
												continue;
											}
											num = (float)0;
											if (248491 - 554405 == -305913)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (49548 - 379671 != -330123)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (174875 - 303854 == -128978)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (298971 - 440149 != -141178)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (174828 - 341526 == -166697)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (97142 - 432837 != -335694)
								{
									this.mChar.moveSpeed = num;
									if (190633 - 507791 == -317158)
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

	// Token: 0x06004F29 RID: 20265 RVA: 0x009B8C6C File Offset: 0x009B6E6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (86760 - 197616 != -110855)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (260818 - 519047 != -258228)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (291942 - 383595 != -91652)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (248123 - 497699 == -249576)
					{
						Vector3 vector2 = vector.normalized;
						if (14743 - 10314 != 4430)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (75274 - 546066 != -470791)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (272495 - 169385 != 103110)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (291577 - 98804 == 192774)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (228057 - 161886 != 66172)
								{
									if (gameObject)
									{
										if (204949 - 421808 == -216858)
										{
											continue;
										}
										if (!(gameObject == this.gameObject))
										{
											goto IL_177;
										}
										if (202449 - 66614 == 135836)
										{
											continue;
										}
									}
									vector2 = this.transform.forward;
									if (218491 - 62799 == 155693)
									{
										continue;
									}
									IL_177:
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector2, 0));
									if (278443 - 464067 != -185623)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (92098 - 272602 == -180504)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector2, 0);
											if (149135 - 320283 == -171148)
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

	// Token: 0x06004F2A RID: 20266 RVA: 0x009B8F2C File Offset: 0x009B712C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (19370 - 67201 != -47831)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (233726 - 550498 != -316771)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (130196 - 139519 == -9323)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (67578 - 358583 == -291005)
					{
						Vector3 normalized = vector.normalized;
						if (264523 - 331943 == -67420)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (222881 - 336322 == -113441)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (87832 - 294148 == -206315)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (228517 - 42024 == 186494)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("earthSmash") != (float)0)
								{
									break;
								}
								if (159725 - 184063 != -24337)
								{
									this.StartCoroutine_Auto(this.RPC_earthSmash(this.transform.position, normalized, 0));
									if (89957 - 379469 != -289511)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (205415 - 583652 == -378237)
										{
											this.ActionEvent("RPC_earthSmash", this.transform.position, normalized, 0);
											if (52675 - 481139 != -428463)
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

	// Token: 0x06004F2B RID: 20267 RVA: 0x009B9178 File Offset: 0x009B7378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004F2C RID: 20268 RVA: 0x009B917C File Offset: 0x009B737C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Turtle1.$RPC_nAttack$33506(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004F2D RID: 20269 RVA: 0x009B918C File Offset: 0x009B738C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06004F2E RID: 20270 RVA: 0x009B91A8 File Offset: 0x009B73A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_earthSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Turtle1.$RPC_earthSmash$33521(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004F2F RID: 20271 RVA: 0x009B91B8 File Offset: 0x009B73B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Turtle1.$RPC_ko$33537(nArray, this).GetEnumerator();
	}

	// Token: 0x06004F30 RID: 20272 RVA: 0x009B91C8 File Offset: 0x009B73C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Turtle1.$RPC_dead$33545(nArray, this).GetEnumerator();
	}

	// Token: 0x06004F31 RID: 20273 RVA: 0x009B91D8 File Offset: 0x009B73D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004F32 RID: 20274 RVA: 0x009B91DC File Offset: 0x009B73DC
	internal static bool kPAUpo5IN6eajy67J6Ji()
	{
		return true;
	}

	// Token: 0x06004F33 RID: 20275 RVA: 0x009B91E0 File Offset: 0x009B73E0
	internal static bool QCfK485IY4UABRp1uI4I()
	{
		return false;
	}

	// Token: 0x040058C8 RID: 22728
	public CharacterControl mChar;

	// Token: 0x040058C9 RID: 22729
	public AudioClip awake_vc;

	// Token: 0x040058CA RID: 22730
	public AudioClip nAttack_vc;

	// Token: 0x040058CB RID: 22731
	public GameObject nAttack_hit;

	// Token: 0x040058CC RID: 22732
	public GameObject earthSmash;

	// Token: 0x040058CD RID: 22733
	public AudioClip earthSmash1_vc;

	// Token: 0x040058CE RID: 22734
	public AudioClip earthSmash2_vc;

	// Token: 0x040058CF RID: 22735
	public AudioClip ko_vc;

	// Token: 0x040058D0 RID: 22736
	public AudioClip dead_vc;

	// Token: 0x02000DB3 RID: 3507
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33506 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004F34 RID: 20276 RVA: 0x009B91E4 File Offset: 0x009B73E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33506(Vector3 mPos, Vector3 tDir, Turtle1 self_)
		{
			if (78193 - 405134 != -326940)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (38254 - 412195 != -373940)
				{
					base..ctor();
					if (151034 - 314987 == -163953)
					{
						this.$mPos$33518 = mPos;
						if (11242 - 315916 == -304674)
						{
							this.$tDir$33519 = tDir;
							if (152649 - 123278 != 29372)
							{
								this.$self_$33520 = self_;
								if (210410 - 92875 == 117535)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x009B92C0 File Offset: 0x009B74C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Turtle1.$RPC_nAttack$33506.$(this.$mPos$33518, this.$tDir$33519, this.$self_$33520);
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x009B92DC File Offset: 0x009B74DC
		internal static bool BIKfGJ5IcbNqItnpZ31y()
		{
			return true;
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x009B92E0 File Offset: 0x009B74E0
		internal static bool uoN4p45IUxheNnV9xMR7()
		{
			return false;
		}

		// Token: 0x040058D1 RID: 22737
		internal Vector3 $mPos$33518;

		// Token: 0x040058D2 RID: 22738
		internal Vector3 $tDir$33519;

		// Token: 0x040058D3 RID: 22739
		internal Turtle1 $self_$33520;

		// Token: 0x02000DB4 RID: 3508
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004F38 RID: 20280 RVA: 0x009B92E4 File Offset: 0x009B74E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Turtle1 self_)
			{
				if (250804 - 111657 != 139148)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289890 - 20341 == 269549)
					{
						base..ctor();
						if (75312 - 176111 != -100798)
						{
							this.$mPos$33515 = mPos;
							if (217914 - 513911 != -295996)
							{
								this.$tDir$33516 = tDir;
								if (278994 - 576701 == -297707)
								{
									this.$self_$33517 = self_;
									if (70519 - 170950 != -100430)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004F39 RID: 20281 RVA: 0x009B93C0 File Offset: 0x009B75C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (192442 - 466590 != -274147)
				{
				}
				for (;;)
				{
					IL_C45:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_F08;
					case 2:
						if (this.$self_$33517.mChar.actionState != "attack")
						{
							if (1943 - 77327 != -75384)
							{
								continue;
							}
							if (this.$self_$33517.mChar.myCommand != "nAttack")
							{
								if (129539 - 101686 != 27854)
								{
									goto Block_38;
								}
								continue;
							}
						}
						this.$self_$33517.mChar.moveSpeed = (float)12;
						if (267774 - 510222 != -242448)
						{
							continue;
						}
						goto IL_E93;
					case 3:
						if (this.$self_$33517.mChar.actionState != "attack")
						{
							if (159267 - 231208 != -71941)
							{
								continue;
							}
							if (this.$self_$33517.mChar.myCommand != "nAttack")
							{
								if (152928 - 167673 != -14744)
								{
									goto Block_49;
								}
								continue;
							}
						}
						this.$self_$33517.mChar.moveSpeed = (float)0;
						if (29798 - 241979 == -212180)
						{
							continue;
						}
						this.$hitLayer$33507 = 130816 - (1 << this.$self_$33517.gameObject.layer);
						if (241183 - 431689 == -190505)
						{
							continue;
						}
						this.$hitList$33508 = null;
						if (115999 - 498162 == -382162)
						{
							continue;
						}
						this.$hitPos$33509 = default(Vector3);
						if (78047 - 456355 != -378308)
						{
							continue;
						}
						this.$hitDir$33510 = default(Vector3);
						if (19415 - 370905 == -351489)
						{
							continue;
						}
						if (!this.$self_$33517.mChar.isMine)
						{
							goto IL_BF6;
						}
						if (226189 - 214925 != 11264)
						{
							continue;
						}
						this.$hitList$33508 = Damage.FindRecTarget(this.$self_$33517.transform.position - (float)2 * this.$self_$33517.transform.forward, this.$self_$33517.transform.forward, (float)2, (float)2, (float)5, (float)3, this.$hitLayer$33507);
						if (73254 - 527269 != -454015)
						{
							continue;
						}
						this.$$iterator$10831$33512 = UnityRuntimeServices.GetEnumerator(this.$hitList$33508);
						if (113303 - 174635 == -61331)
						{
							continue;
						}
						while (this.$$iterator$10831$33512.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10831$33512.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$33511 = (GameObject)obj2;
							if (118823 - 284784 == -165960)
							{
								goto IL_C45;
							}
							this.$hitDir$33510 = global::Math.vFlat(this.$hitObject$33511.transform.position - this.$self_$33517.transform.position).normalized;
							if (4461 - 181126 == -176664)
							{
								goto IL_C45;
							}
							UnityRuntimeServices.Update(this.$$iterator$10831$33512, this.$hitObject$33511);
							if (292170 - 334180 == -42009)
							{
								goto IL_C45;
							}
							if (this.$self_$33517.mChar.hit(99, this.$hitObject$33511, this.$self_$33517.mChar.atk, 5, 0, this.$hitDir$33510) != 0)
							{
								if (243243 - 437885 != -194642)
								{
									goto IL_C45;
								}
								this.$hitPos$33509 = this.$hitObject$33511.collider.ClosestPointOnBounds(this.$self_$33517.transform.position + Vector3.up);
								if (123651 - 103339 != 20312)
								{
									goto IL_C45;
								}
								UnityRuntimeServices.Update(this.$$iterator$10831$33512, this.$hitObject$33511);
								if (132546 - 134362 == -1815)
								{
									goto IL_C45;
								}
								this.$self_$33517.RPC_nAttack_hit(this.$hitPos$33509, this.$hitDir$33510, 0);
								if (5066 - 404213 != -399147)
								{
									goto IL_C45;
								}
								this.$self_$33517.ActionEvent("RPC_nAttack_hit", this.$hitPos$33509, this.$hitDir$33510, 0);
								if (243603 - 224147 == 19457)
								{
									goto IL_C45;
								}
							}
						}
						if (134096 - 444899 != -310802)
						{
							goto Block_81;
						}
						continue;
					case 4:
						if (this.$self_$33517.mChar.actionState != "attack")
						{
							if (117406 - 284543 != -167137)
							{
								continue;
							}
							if (this.$self_$33517.mChar.myCommand != "nAttack")
							{
								if (98668 - 186435 != -87766)
								{
									goto Block_47;
								}
								continue;
							}
						}
						this.$self_$33517.mChar.moveSpeed = (float)10;
						if (128874 - 400255 != -271380)
						{
							goto Block_4;
						}
						continue;
					case 5:
						if (this.$self_$33517.mChar.actionState != "attack")
						{
							if (131589 - 497214 != -365625)
							{
								continue;
							}
							if (this.$self_$33517.mChar.myCommand != "nAttack")
							{
								if (92678 - 259064 != -166385)
								{
									goto Block_56;
								}
								continue;
							}
						}
						if (!this.$self_$33517.mChar.isMine)
						{
							goto IL_C8A;
						}
						if (158106 - 240340 != -82234)
						{
							continue;
						}
						this.$hitList$33508 = Damage.FindRecTarget(this.$self_$33517.transform.position - (float)2 * this.$self_$33517.transform.forward, this.$self_$33517.transform.forward, (float)2, (float)2, (float)5, (float)3, this.$hitLayer$33507);
						if (8363 - 502698 == -494334)
						{
							continue;
						}
						this.$$iterator$10832$33514 = UnityRuntimeServices.GetEnumerator(this.$hitList$33508);
						if (285682 - 533408 != -247726)
						{
							continue;
						}
						while (this.$$iterator$10832$33514.MoveNext())
						{
							object obj4;
							object obj3 = obj4 = this.$$iterator$10832$33514.Current;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							this.$hitObject$33513 = (GameObject)obj4;
							if (249744 - 243430 != 6314)
							{
								goto IL_C45;
							}
							this.$hitDir$33510 = global::Math.vFlat(this.$hitObject$33513.transform.position - this.$self_$33517.transform.position).normalized;
							if (188626 - 360130 == -171503)
							{
								goto IL_C45;
							}
							UnityRuntimeServices.Update(this.$$iterator$10832$33514, this.$hitObject$33513);
							if (95893 - 150764 == -54870)
							{
								goto IL_C45;
							}
							if (this.$self_$33517.mChar.hit(99, this.$hitObject$33513, this.$self_$33517.mChar.atk, 5, 0, this.$hitDir$33510) != 0)
							{
								if (65481 - 463551 != -398070)
								{
									goto IL_C45;
								}
								this.$hitPos$33509 = this.$hitObject$33513.collider.ClosestPointOnBounds(this.$self_$33517.transform.position + Vector3.up);
								if (264353 - 496439 == -232085)
								{
									goto IL_C45;
								}
								UnityRuntimeServices.Update(this.$$iterator$10832$33514, this.$hitObject$33513);
								if (32399 - 215865 == -183465)
								{
									goto IL_C45;
								}
								this.$self_$33517.RPC_nAttack_hit(this.$hitPos$33509, this.$hitDir$33510, 0);
								if (20679 - 87340 == -66660)
								{
									goto IL_C45;
								}
								this.$self_$33517.ActionEvent("RPC_nAttack_hit", this.$hitPos$33509, this.$hitDir$33510, 0);
								if (20839 - 98657 != -77818)
								{
									goto IL_C45;
								}
							}
						}
						if (108733 - 35215 != 73519)
						{
							goto Block_24;
						}
						continue;
					case 6:
						if (this.$self_$33517.mChar.actionState != "attack")
						{
							if (123912 - 295977 != -172065)
							{
								continue;
							}
							if (this.$self_$33517.mChar.myCommand != "nAttack")
							{
								if (283655 - 270473 != 13183)
								{
									goto Block_30;
								}
								continue;
							}
						}
						this.$self_$33517.mChar.moveSpeed = (float)0;
						if (264225 - 284722 != -20496)
						{
							goto Block_70;
						}
						continue;
					case 7:
						if (this.$self_$33517.mChar.actionState == "attack")
						{
							if (189970 - 310638 == -120667)
							{
								continue;
							}
							if (this.$self_$33517.mChar.myCommand == "nAttack")
							{
								if (251608 - 398224 == -146615)
								{
									continue;
								}
								this.$self_$33517.mChar.actionState = "standby";
								if (160632 - 587924 == -427291)
								{
									continue;
								}
								this.$self_$33517.mChar.actionTime = Time.time;
								if (291640 - 535042 == -243401)
								{
									continue;
								}
								this.$self_$33517.mChar.myCommand = "none";
								if (290909 - 559696 != -268787)
								{
									continue;
								}
								if (!this.$self_$33517.mChar.isMine)
								{
									if (132295 - 281833 == -149537)
									{
										continue;
									}
									this.$self_$33517.mChar.nPosition = this.$self_$33517.transform.position;
									if (58622 - 226506 != -167884)
									{
										continue;
									}
									this.$self_$33517.mChar.oPosition = this.$self_$33517.transform.position;
									if (195222 - 384626 != -189404)
									{
										continue;
									}
									this.$self_$33517.mChar.nDirection = this.$self_$33517.transform.forward;
									if (137003 - 236424 != -99421)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (1146 - 119806 != -118659)
						{
							goto Block_16;
						}
						continue;
					default:
						if (285389 - 550350 != -264961)
						{
							continue;
						}
						break;
					}
					this.$self_$33517.mChar.actionState = "attack";
					if (60685 - 308306 == -247621)
					{
						this.$self_$33517.mChar.actionTime = Time.time;
						if (176680 - 556221 == -379541)
						{
							this.$self_$33517.mChar.myCommand = "nAttack";
							if (277042 - 209580 != 67463)
							{
								this.$self_$33517.mChar.addTimeOut("nAttack", (float)1);
								if (183119 - 127340 != 55780)
								{
									this.$self_$33517.transform.position = this.$mPos$33515;
									if (98021 - 504540 != -406518)
									{
										this.$self_$33517.transform.LookAt(this.$mPos$33515 + global::Math.vFlat(this.$tDir$33516));
										if (84527 - 117864 != -33336)
										{
											this.$self_$33517.animation.CrossFade("nAttack");
											if (190162 - 529504 == -339342)
											{
												this.$self_$33517.animation.wrapMode = WrapMode.Once;
												if (154638 - 28920 == 125718)
												{
													this.$self_$33517.mChar.vMovement = this.$self_$33517.transform.forward;
													if (278984 - 465486 == -186502)
													{
														this.$self_$33517.mChar.moveSpeed = (float)0;
														if (226230 - 389140 != -162909)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																break;
															}
															if (290979 - 224253 == 66726)
															{
																if (this.$self_$33517.nAttack_vc)
																{
																	if (249334 - 164239 == 85095)
																	{
																		this.$self_$33517.audio.PlayOneShot(this.$self_$33517.nAttack_vc);
																		if (204982 - 214708 != -9725)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find nAttack1 voice");
																	if (208678 - 162942 == 45736)
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
				IL_1A:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_4:
				return this.Yield(5, new WaitForSeconds(0.1f));
				Block_16:
				goto IL_F08;
				Block_24:
				goto IL_C8A;
				Block_30:
				Block_38:
				Block_47:
				Block_49:
				Block_56:
				goto IL_F08;
				Block_70:
				return this.Yield(7, new WaitForSeconds(0.3f));
				goto IL_1A;
				IL_BF6:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_C8A:
				return this.Yield(6, new WaitForSeconds(0.1f));
				Block_81:
				goto IL_BF6;
				IL_E93:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_F08:
				return false;
			}

			// Token: 0x06004F3A RID: 20282 RVA: 0x009BA2E8 File Offset: 0x009B84E8
			internal static bool hnEDAH5ITIQJAoDgJPGK()
			{
				return true;
			}

			// Token: 0x06004F3B RID: 20283 RVA: 0x009BA2EC File Offset: 0x009B84EC
			internal static bool pCHK9R5I3ikjcX1qHgUh()
			{
				return false;
			}

			// Token: 0x040058D4 RID: 22740
			internal int $hitLayer$33507;

			// Token: 0x040058D5 RID: 22741
			internal UnityScript.Lang.Array $hitList$33508;

			// Token: 0x040058D6 RID: 22742
			internal Vector3 $hitPos$33509;

			// Token: 0x040058D7 RID: 22743
			internal Vector3 $hitDir$33510;

			// Token: 0x040058D8 RID: 22744
			internal GameObject $hitObject$33511;

			// Token: 0x040058D9 RID: 22745
			internal IEnumerator $$iterator$10831$33512;

			// Token: 0x040058DA RID: 22746
			internal GameObject $hitObject$33513;

			// Token: 0x040058DB RID: 22747
			internal IEnumerator $$iterator$10832$33514;

			// Token: 0x040058DC RID: 22748
			internal Vector3 $mPos$33515;

			// Token: 0x040058DD RID: 22749
			internal Vector3 $tDir$33516;

			// Token: 0x040058DE RID: 22750
			internal Turtle1 $self_$33517;
		}
	}

	// Token: 0x02000DB5 RID: 3509
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_earthSmash$33521 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004F3C RID: 20284 RVA: 0x009BA2F0 File Offset: 0x009B84F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_earthSmash$33521(Vector3 mPos, Vector3 tDir, Turtle1 self_)
		{
			if (129493 - 125031 != 4463)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (46714 - 169352 == -122638)
				{
					base..ctor();
					if (165532 - 154844 == 10688)
					{
						this.$mPos$33534 = mPos;
						if (44064 - 378530 != -334465)
						{
							this.$tDir$33535 = tDir;
							if (196513 - 195233 != 1281)
							{
								this.$self_$33536 = self_;
								if (51153 - 13778 == 37375)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x009BA3CC File Offset: 0x009B85CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Turtle1.$RPC_earthSmash$33521.$(this.$mPos$33534, this.$tDir$33535, this.$self_$33536);
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x009BA3E8 File Offset: 0x009B85E8
		internal static bool lCS16Y5IXXhX2m3jToHV()
		{
			return true;
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x009BA3EC File Offset: 0x009B85EC
		internal static bool aOLXNh5IQ8A8GuWkOkvI()
		{
			return false;
		}

		// Token: 0x040058DF RID: 22751
		internal Vector3 $mPos$33534;

		// Token: 0x040058E0 RID: 22752
		internal Vector3 $tDir$33535;

		// Token: 0x040058E1 RID: 22753
		internal Turtle1 $self_$33536;

		// Token: 0x02000DB6 RID: 3510
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004F40 RID: 20288 RVA: 0x009BA3F0 File Offset: 0x009B85F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Turtle1 self_)
			{
				if (61859 - 203527 != -141668)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (296518 - 304790 != -8271)
					{
						base..ctor();
						if (133105 - 415430 != -282324)
						{
							this.$mPos$33531 = mPos;
							if (75045 - 364348 != -289302)
							{
								this.$tDir$33532 = tDir;
								if (179958 - 354339 != -174380)
								{
									this.$self_$33533 = self_;
									if (61489 - 96049 == -34560)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004F41 RID: 20289 RVA: 0x009BA4CC File Offset: 0x009B86CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169080 - 471792 != -302711)
				{
				}
				for (;;)
				{
					IL_80B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_DF3;
					case 2:
						if (this.$self_$33533.mChar.actionState != "attack")
						{
							if (12935 - 392662 != -379727)
							{
								continue;
							}
							if (this.$self_$33533.mChar.myCommand != "earthSmash")
							{
								if (155925 - 456082 != -300157)
								{
									continue;
								}
								goto IL_96F;
							}
						}
						this.$self_$33533.mChar.moveSpeed = (float)6;
						if (131822 - 317468 != -185645)
						{
							goto Block_59;
						}
						continue;
					case 3:
						if (this.$self_$33533.mChar.actionState != "attack")
						{
							if (43128 - 418616 != -375488)
							{
								continue;
							}
							if (this.$self_$33533.mChar.myCommand != "earthSmash")
							{
								if (41029 - 249629 != -208600)
								{
									continue;
								}
								goto IL_B04;
							}
						}
						this.$self_$33533.mChar.moveSpeed = (float)0;
						if (153500 - 433726 == -280225)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$33533.earthSmash, this.$self_$33533.transform.position + this.$self_$33533.transform.TransformDirection(0.3f, (float)0, 0.7f), Quaternion.identity);
						if (260634 - 439946 != -179312)
						{
							continue;
						}
						this.$hitLayer$33523 = 130816 - (1 << this.$self_$33533.gameObject.layer);
						if (101748 - 481533 == -379784)
						{
							continue;
						}
						this.$hitList$33524 = null;
						if (21873 - 523760 != -501887)
						{
							continue;
						}
						this.$hitPos$33525 = default(Vector3);
						if (231597 - 311594 != -79997)
						{
							continue;
						}
						this.$hitDir$33526 = default(Vector3);
						if (8969 - 471730 != -462761)
						{
							continue;
						}
						if (!this.$self_$33533.mChar.isMine)
						{
							goto IL_238;
						}
						if (90705 - 263262 != -172557)
						{
							continue;
						}
						this.$hitList$33524 = Damage.FindAreaTarget(this.$self_$33533.transform.position, (float)3, (float)3, this.$hitLayer$33523);
						if (8589 - 268283 != -259694)
						{
							continue;
						}
						this.$$iterator$10833$33528 = UnityRuntimeServices.GetEnumerator(this.$hitList$33524);
						if (243070 - 248673 != -5603)
						{
							continue;
						}
						while (this.$$iterator$10833$33528.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10833$33528.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$33527 = (GameObject)obj2;
							if (158122 - 48511 != 109611)
							{
								goto IL_80B;
							}
							this.$hitDir$33526 = global::Math.vFlat(this.$hitObject$33527.transform.position - this.$self_$33533.transform.position).normalized;
							if (27910 - 531429 != -503519)
							{
								goto IL_80B;
							}
							UnityRuntimeServices.Update(this.$$iterator$10833$33528, this.$hitObject$33527);
							if (81502 - 513545 == -432042)
							{
								goto IL_80B;
							}
							this.$self_$33533.mChar.hit(99, this.$hitObject$33527, (int)(0.5f * (float)this.$self_$33533.mChar.atk + (float)this.$self_$33533.mChar.talAdjust(60)), 5, 0, this.$hitDir$33526);
							if (218281 - 362966 != -144685)
							{
								goto IL_80B;
							}
							UnityRuntimeServices.Update(this.$$iterator$10833$33528, this.$hitObject$33527);
							if (205823 - 129720 != 76103)
							{
								goto IL_80B;
							}
						}
						if (193579 - 69460 != 124120)
						{
							goto Block_29;
						}
						continue;
					case 4:
						if (this.$self_$33533.mChar.actionState != "attack")
						{
							if (120084 - 155478 != -35394)
							{
								continue;
							}
							if (this.$self_$33533.mChar.myCommand != "earthSmash")
							{
								if (49318 - 324837 != -275518)
								{
									goto Block_32;
								}
								continue;
							}
						}
						if (!this.$self_$33533.mChar.isMine)
						{
							goto IL_448;
						}
						if (160763 - 30806 == 129958)
						{
							continue;
						}
						this.$hitList$33524 = Damage.FindAreaTarget(this.$self_$33533.transform.position, (float)6, (float)3, this.$hitLayer$33523);
						if (121272 - 347185 == -225912)
						{
							continue;
						}
						this.$$iterator$10834$33530 = UnityRuntimeServices.GetEnumerator(this.$hitList$33524);
						if (34981 - 360607 != -325626)
						{
							continue;
						}
						while (this.$$iterator$10834$33530.MoveNext())
						{
							object obj4;
							object obj3 = obj4 = this.$$iterator$10834$33530.Current;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							this.$hitObject$33529 = (GameObject)obj4;
							if (173116 - 150805 == 22312)
							{
								goto IL_80B;
							}
							this.$hitDir$33526 = global::Math.vFlat(this.$hitObject$33529.transform.position - this.$self_$33533.transform.position).normalized;
							if (117450 - 133000 == -15549)
							{
								goto IL_80B;
							}
							UnityRuntimeServices.Update(this.$$iterator$10834$33530, this.$hitObject$33529);
							if (130163 - 468727 != -338564)
							{
								goto IL_80B;
							}
							this.$self_$33533.mChar.hit(99, this.$hitObject$33529, (int)(0.5f * (float)this.$self_$33533.mChar.atk + (float)this.$self_$33533.mChar.talAdjust(60)), 5, 0, this.$hitDir$33526);
							if (172189 - 245666 == -73476)
							{
								goto IL_80B;
							}
							UnityRuntimeServices.Update(this.$$iterator$10834$33530, this.$hitObject$33529);
							if (86280 - 378993 == -292712)
							{
								goto IL_80B;
							}
						}
						if (255451 - 344041 != -88589)
						{
							goto Block_55;
						}
						continue;
					case 5:
						if (this.$self_$33533.mChar.actionState == "attack")
						{
							if (115063 - 215560 != -100497)
							{
								continue;
							}
							if (this.$self_$33533.mChar.myCommand == "earthSmash")
							{
								if (192592 - 433431 != -240839)
								{
									continue;
								}
								this.$self_$33533.mChar.actionState = "standby";
								if (254259 - 433492 == -179232)
								{
									continue;
								}
								this.$self_$33533.mChar.actionTime = Time.time;
								if (108013 - 139773 == -31759)
								{
									continue;
								}
								this.$self_$33533.mChar.myCommand = "none";
								if (247418 - 489036 == -241617)
								{
									continue;
								}
								if (!this.$self_$33533.mChar.isMine)
								{
									if (178789 - 151710 != 27079)
									{
										continue;
									}
									this.$self_$33533.mChar.nPosition = this.$self_$33533.transform.position;
									if (221090 - 404400 != -183310)
									{
										continue;
									}
									this.$self_$33533.mChar.oPosition = this.$self_$33533.transform.position;
									if (62775 - 464851 == -402075)
									{
										continue;
									}
									this.$self_$33533.mChar.nDirection = this.$self_$33533.transform.forward;
									if (211477 - 29375 == 182103)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (200927 - 408384 != -207456)
						{
							goto Block_66;
						}
						continue;
					default:
						if (33981 - 478724 == -444742)
						{
							continue;
						}
						break;
					}
					this.$self_$33533.mChar.actionState = "attack";
					if (272198 - 33275 != 238924)
					{
						this.$self_$33533.mChar.actionTime = Time.time;
						if (183899 - 153726 == 30173)
						{
							this.$self_$33533.mChar.myCommand = "earthSmash";
							if (260040 - 106759 == 153281)
							{
								this.$self_$33533.mChar.addTimeOut("earthSmash", (float)12);
								if (139641 - 367120 == -227479)
								{
									this.$self_$33533.transform.position = this.$mPos$33531;
									if (241211 - 570965 == -329754)
									{
										this.$self_$33533.transform.LookAt(this.$mPos$33531 + global::Math.vFlat(this.$tDir$33532));
										if (82469 - 79202 != 3268)
										{
											this.$self_$33533.animation.CrossFade("earthSmash");
											if (210546 - 21627 != 188920)
											{
												this.$self_$33533.animation.wrapMode = WrapMode.Once;
												if (18396 - 547320 != -528923)
												{
													this.$self_$33533.mChar.vMovement = this.$self_$33533.transform.forward;
													if (59806 - 395629 != -335822)
													{
														this.$self_$33533.mChar.moveSpeed = (float)0;
														if (124536 - 70741 != 53796)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (44766 - 239920 != -195154)
																{
																	continue;
																}
																if (UnityEngine.Random.Range(0, 2) == 0)
																{
																	if (130214 - 494291 == -364076)
																	{
																		continue;
																	}
																	if (this.$self_$33533.earthSmash1_vc)
																	{
																		if (251854 - 204811 == 47044)
																		{
																			continue;
																		}
																		this.$self_$33533.audio.PlayOneShot(this.$self_$33533.earthSmash1_vc);
																		if (82252 - 457116 != -374864)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find earthSmash1 voice");
																		if (167395 - 172909 != -5514)
																		{
																			continue;
																		}
																	}
																}
																else if (this.$self_$33533.earthSmash2_vc)
																{
																	if (182128 - 500240 != -318112)
																	{
																		continue;
																	}
																	this.$self_$33533.audio.PlayOneShot(this.$self_$33533.earthSmash2_vc);
																	if (203189 - 229833 != -26644)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find earthSmash2 voice");
																	if (68878 - 329848 != -260970)
																	{
																		continue;
																	}
																}
															}
															if (Game.mGameCode != 503)
															{
																goto IL_6C5;
															}
															if (166987 - 303221 == -136234)
															{
																this.$m$33522 = Language.getMessage("M503_TwoTurtleSages", 50311);
																if (176018 - 561712 == -385694)
																{
																	if (!(this.$m$33522 != string.Empty))
																	{
																		goto IL_6C5;
																	}
																	if (285218 - 589070 == -303852)
																	{
																		Chat.SubmitChat("Guibo", this.$m$33522, eChatType.enemy, eChatMode.system);
																		if (237988 - 112145 != 125844)
																		{
																			this.$self_$33533.mChar.doChatBubble(this.$m$33522);
																			if (17524 - 258145 != -240620)
																			{
																				goto Block_84;
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
				IL_238:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_448:
				return this.Yield(5, new WaitForSeconds(0.3f));
				Block_29:
				goto IL_238;
				Block_32:
				goto IL_DF3;
				IL_6C5:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_55:
				goto IL_448;
				IL_96F:
				goto IL_DF3;
				Block_59:
				return this.Yield(3, new WaitForSeconds(0.6f));
				Block_66:
				IL_B04:
				goto IL_DF3;
				Block_84:
				goto IL_6C5;
				IL_DF3:
				return false;
			}

			// Token: 0x06004F42 RID: 20290 RVA: 0x009BB2E0 File Offset: 0x009B94E0
			internal static bool Uj7y8S5Ik3dPkQrbWxN8()
			{
				return true;
			}

			// Token: 0x06004F43 RID: 20291 RVA: 0x009BB2E4 File Offset: 0x009B94E4
			internal static bool Pv4K3O5IGMTxAD2t5jHh()
			{
				return false;
			}

			// Token: 0x040058E2 RID: 22754
			internal string $m$33522;

			// Token: 0x040058E3 RID: 22755
			internal int $hitLayer$33523;

			// Token: 0x040058E4 RID: 22756
			internal UnityScript.Lang.Array $hitList$33524;

			// Token: 0x040058E5 RID: 22757
			internal Vector3 $hitPos$33525;

			// Token: 0x040058E6 RID: 22758
			internal Vector3 $hitDir$33526;

			// Token: 0x040058E7 RID: 22759
			internal GameObject $hitObject$33527;

			// Token: 0x040058E8 RID: 22760
			internal IEnumerator $$iterator$10833$33528;

			// Token: 0x040058E9 RID: 22761
			internal GameObject $hitObject$33529;

			// Token: 0x040058EA RID: 22762
			internal IEnumerator $$iterator$10834$33530;

			// Token: 0x040058EB RID: 22763
			internal Vector3 $mPos$33531;

			// Token: 0x040058EC RID: 22764
			internal Vector3 $tDir$33532;

			// Token: 0x040058ED RID: 22765
			internal Turtle1 $self_$33533;
		}
	}

	// Token: 0x02000DB7 RID: 3511
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33537 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004F44 RID: 20292 RVA: 0x009BB2E8 File Offset: 0x009B94E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33537(UnityScript.Lang.Array nArray, Turtle1 self_)
		{
			if (287211 - 573699 != -286487)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82109 - 1008 != 81102)
				{
					base..ctor();
					if (230240 - 24080 == 206160)
					{
						this.$nArray$33543 = nArray;
						if (28076 - 48420 != -20343)
						{
							this.$self_$33544 = self_;
							if (252854 - 251565 != 1290)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x009BB3A4 File Offset: 0x009B95A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Turtle1.$RPC_ko$33537.$(this.$nArray$33543, this.$self_$33544);
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x009BB3B8 File Offset: 0x009B95B8
		internal static bool tKbnlK5IHq92SPdQ93jR()
		{
			return true;
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x009BB3BC File Offset: 0x009B95BC
		internal static bool M35pe05IWU1yNPxeMQRK()
		{
			return false;
		}

		// Token: 0x040058EE RID: 22766
		internal UnityScript.Lang.Array $nArray$33543;

		// Token: 0x040058EF RID: 22767
		internal Turtle1 $self_$33544;

		// Token: 0x02000DB8 RID: 3512
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004F48 RID: 20296 RVA: 0x009BB3C0 File Offset: 0x009B95C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Turtle1 self_)
			{
				if (284731 - 301459 != -16728)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (223047 - 321847 == -98800)
					{
						base..ctor();
						if (36150 - 30313 == 5837)
						{
							this.$nArray$33541 = nArray;
							if (260913 - 24819 != 236095)
							{
								this.$self_$33542 = self_;
								if (30576 - 559401 != -528824)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004F49 RID: 20297 RVA: 0x009BB47C File Offset: 0x009B967C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (287831 - 464171 != -176340)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_626;
					case 2:
						if (this.$self_$33542.mChar.actionState != "ko")
						{
							if (168920 - 305302 != -136381)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$33542.animation.Play("getUp");
							if (35739 - 393692 == -357952)
							{
								continue;
							}
							this.$self_$33542.animation.wrapMode = WrapMode.Once;
							if (487 - 536700 != -536212)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33542.mChar.actionState != "ko")
						{
							if (87628 - 74440 != 13188)
							{
								continue;
							}
							goto IL_233;
						}
						else
						{
							this.$self_$33542.mChar.actionState = "standby";
							if (110812 - 81002 == 29811)
							{
								continue;
							}
							this.$self_$33542.mChar.actionTime = Time.time;
							if (190092 - 315997 == -125904)
							{
								continue;
							}
							this.$self_$33542.mChar.myCommand = "none";
							if (177500 - 314504 != -137004)
							{
								continue;
							}
							this.$self_$33542.mChar.ko = this.$self_$33542.mChar.mko;
							if (42529 - 20726 != 21803)
							{
								continue;
							}
							this.YieldDefault(1);
							if (60854 - 154172 != -93317)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					default:
						if (11720 - 44856 != -33136)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33542.mChar.actionState == "ko")
					{
						goto IL_1A7;
					}
					if (158275 - 335157 == -176882)
					{
						if (this.$self_$33542.mChar.actionState == "dead")
						{
							if (238857 - 121428 == 117429)
							{
								goto IL_1A7;
							}
						}
						else
						{
							if (Game.mGameCode == 503)
							{
								if (281364 - 375165 != -93801)
								{
									continue;
								}
								this.$m$33538 = Language.getMessage("M503_TwoTurtleSages", 50312);
								if (207219 - 314253 != -107034)
								{
									continue;
								}
								if (this.$m$33538 != string.Empty)
								{
									if (225242 - 556126 != -330884)
									{
										continue;
									}
									Chat.SubmitChat("Guibo", this.$m$33538, eChatType.enemy, eChatMode.system);
									if (206033 - 468077 != -262044)
									{
										continue;
									}
									this.$self_$33542.mChar.doChatBubble(this.$m$33538);
									if (226491 - 552060 == -325568)
									{
										continue;
									}
								}
							}
							this.$mPos$33539 = (Vector3)this.$nArray$33541[0];
							if (240347 - 80983 == 159364)
							{
								this.$mDir$33540 = (Vector3)this.$nArray$33541[1];
								if (283365 - 583125 == -299760)
								{
									this.$self_$33542.mChar.ko = 0;
									if (251181 - 201715 == 49466)
									{
										this.$self_$33542.mChar.actionState = "ko";
										if (186404 - 568575 == -382171)
										{
											this.$self_$33542.mChar.actionTime = Time.time;
											if (24600 - 35799 != -11198)
											{
												this.$self_$33542.mChar.myCommand = "none";
												if (34256 - 581587 != -547330)
												{
													this.$self_$33542.mChar.vMovement = Vector3.zero;
													if (10325 - 487026 == -476701)
													{
														this.$self_$33542.mChar.moveSpeed = (float)0;
														if (167602 - 588087 != -420484)
														{
															this.$self_$33542.animation.Play("ko");
															if (22801 - 421911 != -399109)
															{
																this.$self_$33542.animation.wrapMode = WrapMode.Once;
																if (91237 - 579868 != -488630)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		break;
																	}
																	if (236509 - 216279 != 20231)
																	{
																		if (this.$self_$33542.ko_vc)
																		{
																			if (128240 - 125084 == 3156)
																			{
																				this.$self_$33542.audio.PlayOneShot(this.$self_$33542.ko_vc);
																				if (52832 - 124681 != -71848)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (303 - 315889 == -315586)
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
				IL_1A:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_3:
				goto IL_626;
				Block_5:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_7:
				IL_1A7:
				IL_233:
				goto IL_626;
				goto IL_1A;
				IL_626:
				return false;
			}

			// Token: 0x06004F4A RID: 20298 RVA: 0x009BBAC4 File Offset: 0x009B9CC4
			internal static bool ivS8by5IAncQOJufjtIK()
			{
				return true;
			}

			// Token: 0x06004F4B RID: 20299 RVA: 0x009BBAC8 File Offset: 0x009B9CC8
			internal static bool xRF6vy5IlI9TYwKx4n37()
			{
				return false;
			}

			// Token: 0x040058F0 RID: 22768
			internal string $m$33538;

			// Token: 0x040058F1 RID: 22769
			internal Vector3 $mPos$33539;

			// Token: 0x040058F2 RID: 22770
			internal Vector3 $mDir$33540;

			// Token: 0x040058F3 RID: 22771
			internal UnityScript.Lang.Array $nArray$33541;

			// Token: 0x040058F4 RID: 22772
			internal Turtle1 $self_$33542;
		}
	}

	// Token: 0x02000DB9 RID: 3513
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33545 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004F4C RID: 20300 RVA: 0x009BBACC File Offset: 0x009B9CCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33545(UnityScript.Lang.Array nArray, Turtle1 self_)
		{
			if (200410 - 29841 != 170569)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (41201 - 403016 != -361814)
				{
					base..ctor();
					if (96376 - 123811 != -27434)
					{
						this.$nArray$33551 = nArray;
						if (80252 - 581453 != -501200)
						{
							this.$self_$33552 = self_;
							if (274230 - 272981 != 1250)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x009BBB88 File Offset: 0x009B9D88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Turtle1.$RPC_dead$33545.$(this.$nArray$33551, this.$self_$33552);
		}

		// Token: 0x06004F4E RID: 20302 RVA: 0x009BBB9C File Offset: 0x009B9D9C
		internal static bool ulOmBD5IyTr46Ruw6dDt()
		{
			return true;
		}

		// Token: 0x06004F4F RID: 20303 RVA: 0x009BBBA0 File Offset: 0x009B9DA0
		internal static bool tjPEqO5ISrNlRiBCsyhX()
		{
			return false;
		}

		// Token: 0x040058F5 RID: 22773
		internal UnityScript.Lang.Array $nArray$33551;

		// Token: 0x040058F6 RID: 22774
		internal Turtle1 $self_$33552;

		// Token: 0x02000DBA RID: 3514
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004F50 RID: 20304 RVA: 0x009BBBA4 File Offset: 0x009B9DA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Turtle1 self_)
			{
				if (167822 - 174806 != -6984)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (195887 - 305013 != -109125)
					{
						base..ctor();
						if (226507 - 85803 != 140705)
						{
							this.$nArray$33549 = nArray;
							if (182499 - 37851 == 144648)
							{
								this.$self_$33550 = self_;
								if (217195 - 595412 == -378217)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004F51 RID: 20305 RVA: 0x009BBC60 File Offset: 0x009B9E60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (27704 - 203249 != -175544)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_653;
					case 2:
						if (this.$self_$33550.mChar.isPlayer)
						{
							if (27175 - 186623 == -159447)
							{
								continue;
							}
							if (this.$self_$33550.mChar.isMine)
							{
								if (298220 - 256713 != 41507)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33550.gameObject);
								if (209060 - 351874 != -142813)
								{
									goto IL_31D;
								}
								continue;
							}
						}
						if (Game.mGameCode == 503)
						{
							if (263217 - 230466 != 32751)
							{
								continue;
							}
							this.$self_$33550.gameObject.layer = 0;
							if (214261 - 415348 != -201087)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$33550.mChar);
							if (42497 - 83296 == -40798)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$33550);
							if (91111 - 272209 == -181097)
							{
								continue;
							}
						}
						else
						{
							UnityEngine.Object.Destroy(this.$self_$33550.gameObject);
							if (248959 - 237119 == 11841)
							{
								continue;
							}
						}
						IL_31D:
						this.YieldDefault(1);
						if (197171 - 557766 != -360594)
						{
							goto Block_21;
						}
						continue;
					default:
						if (132507 - 167201 == -34693)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33550.mChar.actionState == "dead")
					{
						if (283144 - 47133 == 236011)
						{
							break;
						}
					}
					else
					{
						if (Game.mGameCode == 503)
						{
							if (282830 - 561459 != -278629)
							{
								continue;
							}
							this.$m$33546 = Language.getMessage("M503_TwoTurtleSages", 50313);
							if (120472 - 217458 == -96985)
							{
								continue;
							}
							if (this.$m$33546 != string.Empty)
							{
								if (29372 - 44125 != -14753)
								{
									continue;
								}
								Chat.SubmitChat("Guibo", this.$m$33546, eChatType.enemy, eChatMode.system);
								if (145211 - 541143 == -395931)
								{
									continue;
								}
								this.$self_$33550.mChar.doChatBubble(this.$m$33546);
								if (255841 - 559143 == -303301)
								{
									continue;
								}
							}
							Game.useAdvanceMode = true;
							if (117009 - 120271 == -3261)
							{
								continue;
							}
						}
						this.$myPosition$33547 = (Vector3)this.$nArray$33549[0];
						if (298507 - 200899 != 97609)
						{
							this.$myDirection$33548 = (Vector3)this.$nArray$33549[1];
							if (245759 - 526892 == -281133)
							{
								this.$self_$33550.transform.position = this.$myPosition$33547;
								if (230155 - 405252 != -175096)
								{
									this.$self_$33550.transform.LookAt(this.$myPosition$33547 + this.$myDirection$33548);
									if (26298 - 530586 != -504287)
									{
										this.$self_$33550.mChar.hp = 0;
										if (106255 - 460066 != -353810)
										{
											this.$self_$33550.mChar.actionState = "dead";
											if (108634 - 206878 != -98243)
											{
												this.$self_$33550.mChar.actionTime = Time.time;
												if (99580 - 347470 == -247890)
												{
													this.$self_$33550.mChar.myCommand = "none";
													if (131926 - 545378 == -413452)
													{
														this.$self_$33550.mChar.vMovement = Vector3.zero;
														if (174633 - 285280 != -110646)
														{
															this.$self_$33550.mChar.moveSpeed = (float)0;
															if (252480 - 248596 != 3885)
															{
																this.$self_$33550.animation.Rewind();
																if (230735 - 323956 == -93221)
																{
																	this.$self_$33550.animation.Play("ko");
																	if (79302 - 377206 != -297903)
																	{
																		this.$self_$33550.animation.wrapMode = WrapMode.Once;
																		if (16274 - 41880 == -25606)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				goto IL_423;
																			}
																			if (252813 - 451039 != -198225)
																			{
																				if (this.$self_$33550.dead_vc)
																				{
																					if (254686 - 562168 != -307481)
																					{
																						this.$self_$33550.audio.PlayOneShot(this.$self_$33550.dead_vc);
																						if (94736 - 79670 == 15066)
																						{
																							goto IL_33F;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (90831 - 379115 != -288283)
																					{
																						goto Block_22;
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
				Block_21:
				goto IL_653;
				IL_33F:
				Block_22:
				goto IL_423;
				goto IL_653;
				IL_423:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_653:
				return false;
			}

			// Token: 0x06004F52 RID: 20306 RVA: 0x009BC2D4 File Offset: 0x009BA4D4
			internal static bool MnmRZb5IotdYOPLIKiAd()
			{
				return true;
			}

			// Token: 0x06004F53 RID: 20307 RVA: 0x009BC2D8 File Offset: 0x009BA4D8
			internal static bool QkfZhl5IElVH0HYmhIMg()
			{
				return false;
			}

			// Token: 0x040058F7 RID: 22775
			internal string $m$33546;

			// Token: 0x040058F8 RID: 22776
			internal Vector3 $myPosition$33547;

			// Token: 0x040058F9 RID: 22777
			internal Vector3 $myDirection$33548;

			// Token: 0x040058FA RID: 22778
			internal UnityScript.Lang.Array $nArray$33549;

			// Token: 0x040058FB RID: 22779
			internal Turtle1 $self_$33550;
		}
	}
}
