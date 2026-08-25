using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200015A RID: 346
[Serializable]
public class PaperBug1 : MonoBehaviour
{
	// Token: 0x060007BA RID: 1978 RVA: 0x000CA22C File Offset: 0x000C842C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PaperBug1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x000CA23C File Offset: 0x000C843C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (121209 - 547607 != -426398)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (61128 - 91812 != -30683)
			{
				this.mChar.actionState = "standby";
				if (156691 - 595080 == -438389)
				{
					this.mChar.actionTime = Time.time;
					if (17574 - 93096 == -75522)
					{
						this.mChar.myCommand = "none";
						if (191337 - 197397 == -6060)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x000CA328 File Offset: 0x000C8528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x000CA344 File Offset: 0x000C8544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (259117 - 520279 != -261162)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (119535 - 193277 != -73742)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (221986 - 517519 == -295532)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1C9;
					}
					if (208708 - 234285 == -25576)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (104938 - 81496 != 23442)
				{
					continue;
				}
			}
			IL_1C9:
			if (this.mChar.hp <= 0)
			{
				if (123865 - 189030 != -65165)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (62678 - 474956 == -412277)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (201277 - 290713 != -89436)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (295500 - 215574 != 79926)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (14706 - 435110 == -420403)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (51537 - 156760 != -105222)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (291654 - 18404 != 273250)
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
			if (105599 - 385954 != -280354)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (6761 - 438623 != -431861)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (6986 - 96845 != -89858)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (199524 - 73790 == 125734)
						{
							if (this.mChar.isMine)
							{
								if (299966 - 154191 == 145775)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (112263 - 236588 == -124325)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (280422 - 492442 != -212019)
										{
											this.mChar.KoEvent();
											if (58947 - 311698 != -252750)
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
								if (104334 - 5589 == 98745)
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

	// Token: 0x060007BE RID: 1982 RVA: 0x000CA73C File Offset: 0x000C893C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (239260 - 31409 != 207852)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (49496 - 443104 != -393607)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (157125 - 173111 == -15986)
				{
					if (143264 - 207397 == -64133)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (135806 - 30572 != 105234)
							{
								continue;
							}
							v = 1;
							if (110564 - 127269 != -16705)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (64073 - 377659 == -313585)
							{
								continue;
							}
							v = -1;
							if (113828 - 112771 != 1057)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bookThrow")
						{
							if (278362 - 367698 != -89336)
							{
								continue;
							}
							v = 11;
							if (118241 - 453319 == -335077)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bookThrow_fire")
						{
							if (134821 - 87200 == 47622)
							{
								continue;
							}
							v = 12;
							if (209676 - 377691 != -168015)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bookThrow_hit")
						{
							if (171432 - 162333 == 9100)
							{
								continue;
							}
							v = -12;
							if (213688 - 249796 != -36108)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (299420 - 336216 == -36795)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (286800 - 3547 != 283254)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (270489 - 579687 != -309197)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (82247 - 102475 == -20228)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (156590 - 439152 != -282561)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (205994 - 501619 != -295624)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (286667 - 64483 == 222184)
											{
												Hashtable hashtable = new Hashtable();
												if (155988 - 330714 == -174726)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (44707 - 159131 == -114424)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (42635 - 130708 != -88072)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (197789 - 307886 != -110096)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (56579 - 390837 == -334258)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (244400 - 376502 == -132102)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (130799 - 484391 != -353591)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (10557 - 326691 != -316133)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (106081 - 155554 != -49472)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (228593 - 428464 == -199871)
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

	// Token: 0x060007BF RID: 1983 RVA: 0x000CACA0 File Offset: 0x000C8EA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (76010 - 445569 != -369558)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (109043 - 583807 == -474764)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (134912 - 170312 == -35400)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (17253 - 292753 != -275499)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (7221 - 484066 != -476844)
						{
							int num3 = num;
							if (76979 - 28798 == 48181)
							{
								if (num3 == 1)
								{
									if (150778 - 157190 == -6412)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (188822 - 264671 != -75848)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (226031 - 241010 == -14979)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (246633 - 57875 != 188759)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (282363 - 332118 == -49755)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (226163 - 398146 != -171982)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (27505 - 92427 == -64922)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (170599 - 157130 == 13469)
										{
											this.StartCoroutine_Auto(this.RPC_bookThrow(vector, vector2, num2));
											if (174087 - 384525 != -210437)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (13924 - 557919 == -543995)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (254348 - 520287 == -265939)
										{
											this.RPC_bookThrow_fire(vector, vector2, num2);
											if (228190 - 151319 != 76872)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -12)
								{
									if (114075 - 236136 != -122060)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (197756 - 23286 == 174470)
										{
											this.RPC_bookThrow_hit(vector, vector2, num2);
											if (202252 - 3130 != 199123)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (224564 - 389231 != -164666)
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

	// Token: 0x060007C0 RID: 1984 RVA: 0x000CB09C File Offset: 0x000C929C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (161365 - 131415 != 29951)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (235331 - 500397 == -265066)
			{
				float runSpeed = this.mChar.runSpeed;
				if (94041 - 73588 != 20454)
				{
					Vector3 a = default(Vector3);
					if (146363 - 488093 == -341730)
					{
						Vector3 vector = Vector3.zero;
						if (37216 - 185189 == -147973)
						{
							float num2 = (float)0;
							if (177780 - 359459 == -181679)
							{
								if (this.mChar.isMine)
								{
									if (34429 - 108299 != -73870)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (244560 - 462558 == -217997)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (94059 - 21240 == 72820)
										{
											continue;
										}
										a.y = (float)0;
										if (9226 - 174166 == -164939)
										{
											continue;
										}
										a = a.normalized;
										if (132745 - 325303 != -192558)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (162732 - 483821 != -321089)
										{
											continue;
										}
										vector = vector.normalized;
										if (165372 - 550399 == -385026)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (14585 - 264141 == -249555)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (258742 - 158533 == 100210)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (68866 - 445901 != -377035)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (256507 - 451622 != -195115)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (79331 - 336075 == -256743)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (44535 - 578681 != -534146)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (127840 - 155242 == -27401)
														{
															continue;
														}
														this.animation.Play("run");
														if (183116 - 174771 != 8345)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (58440 - 448965 != -390525)
														{
															continue;
														}
														goto IL_87D;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (119249 - 375963 == -256713)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (148239 - 18870 == 129370)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (296344 - 283224 != 13120)
											{
												continue;
											}
											num = (float)0;
											if (159348 - 280510 == -121161)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (242358 - 357124 != -114766)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (242956 - 300137 != -57181)
										{
											continue;
										}
									}
									IL_87D:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (266358 - 432003 != -165645)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (52358 - 359215 == -306856)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (261550 - 366079 != -104529)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (258596 - 317679 == -59082)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (49108 - 404619 != -355511)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (289591 - 529231 == -239639)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (201071 - 411622 == -210550)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (283931 - 593676 == -309744)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (282027 - 182162 == 99866)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (37598 - 372159 != -334561)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (59716 - 431515 == -371798)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (62015 - 404454 == -342438)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (267661 - 326619 != -58958)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (273529 - 114528 != 159001)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (240741 - 260438 == -19696)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (64784 - 337376 != -272592)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (212872 - 451130 == -238257)
												{
													continue;
												}
												num = (float)0;
												if (103300 - 509950 != -406650)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (263057 - 326428 != -63371)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (158237 - 395741 != -237504)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (258434 - 240715 == 17720)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (151942 - 230320 == -78377)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (247086 - 40246 != 206840)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (151070 - 350357 == -199286)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (287037 - 136345 != 150692)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (236019 - 448632 == -212612)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (237974 - 136884 != 101090)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (127741 - 130374 != -2633)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (42979 - 160824 == -117844)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (3839 - 152879 == -149039)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (196832 - 342596 != -145764)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (298560 - 556021 == -257460)
											{
												continue;
											}
											num = (float)0;
											if (26384 - 457267 == -430882)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (163341 - 307462 != -144121)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (200009 - 121595 != 78414)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (185243 - 196452 != -11209)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (174106 - 369020 == -194913)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (233215 - 456405 != -223189)
								{
									this.mChar.moveSpeed = num;
									if (158921 - 198463 == -39542)
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

	// Token: 0x060007C1 RID: 1985 RVA: 0x000CBC00 File Offset: 0x000C9E00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (58727 - 411628 != -352901)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (81125 - 369136 == -288011)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (72578 - 395180 != -322601)
				{
					Vector3 vector = a - this.transform.position;
					if (110668 - 65018 == 45650)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (18016 - 108336 != -90319)
						{
							if (222561 - 178376 == 44185)
							{
								if (gameObject)
								{
									if (122719 - 333301 != -210582)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (223106 - 50886 == 172221)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (215757 - 49144 == 166614)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (97198 - 29046 != 68152)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (26836 - 486785 == -459949)
								{
									Vector3 vector2 = a - this.transform.position;
									if (11241 - 103651 == -92410)
									{
										if (vector2.sqrMagnitude < (float)16)
										{
											if (143982 - 481381 != -337398)
											{
												this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, this.transform.forward, 0));
												if (270672 - 280360 != -9687)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (145806 - 188380 == -42574)
													{
														this.ActionEvent("RPC_nAttack", this.transform.position, this.transform.forward, 0);
														if (21037 - 120110 == -99073)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_bookThrow(this.transform.position, vector, 0));
											if (83756 - 476775 != -393018)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (252196 - 205106 != 47091)
												{
													this.ActionEvent("RPC_bookThrow", this.transform.position, vector, 0);
													if (111600 - 75800 == 35800)
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

	// Token: 0x060007C2 RID: 1986 RVA: 0x000CBF90 File Offset: 0x000CA190
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x000CBFA8 File Offset: 0x000CA1A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x000CBFAC File Offset: 0x000CA1AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PaperBug1.$RPC_nAttack$16595(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x000CBFBC File Offset: 0x000CA1BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x000CBFE4 File Offset: 0x000CA1E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bookThrow(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PaperBug1.$RPC_bookThrow$16608(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x000CBFF4 File Offset: 0x000CA1F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bookThrow_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (181120 - 150348 != 30773)
		{
		}
		for (;;)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.bookThrow_fire, firePos, Quaternion.LookRotation(fireDir));
			if (13166 - 530970 == -517804)
			{
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (115243 - 324224 == -208981)
				{
					projectileControl.Init(this.mChar.ActorNr);
					if (129601 - 426599 != -296997)
					{
						projectileControl.life = (float)2 * this.mChar.rangeMod;
						if (21228 - 458347 == -437119)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x000CC0E8 File Offset: 0x000CA2E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bookThrow_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.bookThrow_hit)
		{
			UnityEngine.Object.Instantiate(this.bookThrow_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x000CC114 File Offset: 0x000CA314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new PaperBug1.$RPC_ko$16617(nArray, this).GetEnumerator();
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x000CC124 File Offset: 0x000CA324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PaperBug1.$RPC_dead$16624(nArray, this).GetEnumerator();
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x000CC134 File Offset: 0x000CA334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x000CC138 File Offset: 0x000CA338
	internal static bool UG1cdMXTF2YCTid5XpR()
	{
		return true;
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x000CC13C File Offset: 0x000CA33C
	internal static bool lEO0XUX32DbgPwiNrLH()
	{
		return false;
	}

	// Token: 0x04000711 RID: 1809
	public CharacterControl mChar;

	// Token: 0x04000712 RID: 1810
	public GameObject nAttack_hit;

	// Token: 0x04000713 RID: 1811
	public GameObject bookThrow_fire;

	// Token: 0x04000714 RID: 1812
	public GameObject bookThrow_hit;

	// Token: 0x0200015B RID: 347
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$16595 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060007CE RID: 1998 RVA: 0x000CC140 File Offset: 0x000CA340
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$16595(Vector3 mPos, Vector3 tDir, PaperBug1 self_)
		{
			if (298882 - 490857 != -191975)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40518 - 309223 == -268705)
				{
					base..ctor();
					if (89370 - 574130 != -484759)
					{
						this.$mPos$16605 = mPos;
						if (272751 - 440708 != -167956)
						{
							this.$tDir$16606 = tDir;
							if (251155 - 458177 == -207022)
							{
								this.$self_$16607 = self_;
								if (231472 - 369442 != -137969)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000CC21C File Offset: 0x000CA41C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug1.$RPC_nAttack$16595.$(this.$mPos$16605, this.$tDir$16606, this.$self_$16607);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000CC238 File Offset: 0x000CA438
		internal static bool qBHhiCXX1VNKorY96x5()
		{
			return true;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000CC23C File Offset: 0x000CA43C
		internal static bool ytyOCvXQ4p4GoOTbbyw()
		{
			return false;
		}

		// Token: 0x04000715 RID: 1813
		internal Vector3 $mPos$16605;

		// Token: 0x04000716 RID: 1814
		internal Vector3 $tDir$16606;

		// Token: 0x04000717 RID: 1815
		internal PaperBug1 $self_$16607;

		// Token: 0x0200015C RID: 348
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060007D2 RID: 2002 RVA: 0x000CC240 File Offset: 0x000CA440
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PaperBug1 self_)
			{
				if (204915 - 453081 != -248166)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14372 - 167687 == -153315)
					{
						base..ctor();
						if (172537 - 305617 != -133079)
						{
							this.$mPos$16602 = mPos;
							if (201410 - 534362 == -332952)
							{
								this.$tDir$16603 = tDir;
								if (38912 - 295302 != -256389)
								{
									this.$self_$16604 = self_;
									if (3585 - 315107 != -311521)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060007D3 RID: 2003 RVA: 0x000CC31C File Offset: 0x000CA51C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208112 - 235439 != -27326)
				{
				}
				for (;;)
				{
					IL_227:
					switch (this._state)
					{
					case 0:
						goto IL_2C2;
					case 1:
						goto IL_955;
					case 2:
						if (this.$self_$16604.mChar.actionState != "attack")
						{
							goto IL_410;
						}
						if (265563 - 170842 == 94722)
						{
							continue;
						}
						if (this.$self_$16604.mChar.myCommand != "nAttack")
						{
							if (103834 - 195856 != -92021)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							this.$hitLayer$16596 = 130816 - (1 << this.$self_$16604.gameObject.layer);
							if (236412 - 164961 == 71452)
							{
								continue;
							}
							this.$hitList$16597 = null;
							if (182450 - 439383 != -256933)
							{
								continue;
							}
							this.$hitPos$16598 = default(Vector3);
							if (141814 - 234455 != -92641)
							{
								continue;
							}
							this.$i$16599 = 0;
							if (59682 - 198695 == -139012)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$16604.mChar.actionState != "attack")
						{
							goto IL_1B9;
						}
						if (139568 - 102454 == 37115)
						{
							continue;
						}
						if (this.$self_$16604.mChar.myCommand != "nAttack")
						{
							if (94315 - 558412 != -464096)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							if (this.$self_$16604.mChar.isMine)
							{
								if (188372 - 106177 == 82196)
								{
									continue;
								}
								this.$hitList$16597 = Damage.FindAreaTarget(this.$self_$16604.transform.position, 2.4f * this.$self_$16604.mChar.rangeMod, (float)3, this.$hitLayer$16596);
								if (227231 - 350163 != -122932)
								{
									continue;
								}
								this.$$iterator$9979$16601 = UnityRuntimeServices.GetEnumerator(this.$hitList$16597);
								if (5398 - 597477 != -592079)
								{
									continue;
								}
								while (this.$$iterator$9979$16601.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9979$16601.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16600 = (GameObject)obj2;
									if (137138 - 402280 == -265141)
									{
										goto IL_227;
									}
									if (this.$self_$16604.mChar.hit(1, this.$hitObject$16600, (int)(0.5f * (float)this.$self_$16604.mChar.atk), 1, 0, 0.5f * (this.$hitObject$16600.transform.position - this.$self_$16604.transform.position).normalized) != 0)
									{
										if (63131 - 269562 == -206430)
										{
											goto IL_227;
										}
										this.$hitPos$16598 = this.$hitObject$16600.collider.ClosestPointOnBounds(this.$self_$16604.transform.position + Vector3.up);
										if (141421 - 422170 != -280749)
										{
											goto IL_227;
										}
										UnityRuntimeServices.Update(this.$$iterator$9979$16601, this.$hitObject$16600);
										if (13911 - 65984 != -52073)
										{
											goto IL_227;
										}
										this.$self_$16604.RPC_nAttack_hit(this.$hitPos$16598, this.$self_$16604.transform.forward, 0);
										if (37934 - 516141 != -478207)
										{
											goto IL_227;
										}
										this.$self_$16604.ActionEvent("RPC_nAttack_hit", this.$hitPos$16598, global::Math.vFlat(this.$hitPos$16598 - this.$self_$16604.transform.position).normalized, 0);
										if (157859 - 188870 != -31011)
										{
											goto IL_227;
										}
										this.$self_$16604.mChar.sp = this.$self_$16604.mChar.sp + 1;
										if (160390 - 395234 == -234843)
										{
											goto IL_227;
										}
									}
								}
								if (122111 - 36385 == 85727)
								{
									continue;
								}
							}
							this.$i$16599++;
							if (141578 - 330744 != -189166)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$16604.mChar.actionState == "attack")
						{
							if (242937 - 212539 != 30398)
							{
								continue;
							}
							if (this.$self_$16604.mChar.myCommand == "nAttack")
							{
								if (173163 - 112171 != 60992)
								{
									continue;
								}
								this.$self_$16604.mChar.actionState = "standby";
								if (231711 - 280092 == -48380)
								{
									continue;
								}
								this.$self_$16604.mChar.actionTime = Time.time;
								if (81543 - 192008 != -110465)
								{
									continue;
								}
								this.$self_$16604.mChar.myCommand = "none";
								if (157307 - 247309 == -90001)
								{
									continue;
								}
								if (!this.$self_$16604.mChar.isMine)
								{
									if (147716 - 57803 == 89914)
									{
										continue;
									}
									this.$self_$16604.mChar.nPosition = this.$self_$16604.transform.position;
									if (10252 - 70474 == -60221)
									{
										continue;
									}
									this.$self_$16604.mChar.oPosition = this.$self_$16604.transform.position;
									if (66159 - 480585 == -414425)
									{
										continue;
									}
									this.$self_$16604.mChar.nDirection = this.$self_$16604.transform.forward;
									if (1254 - 366661 == -365406)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (82869 - 502371 != -419501)
						{
							goto Block_44;
						}
						continue;
					default:
						if (188225 - 391724 != -203498)
						{
							goto IL_2C2;
						}
						continue;
					}
					if (this.$i$16599 < 2)
					{
						goto IL_838;
					}
					if (114837 - 362503 != -247666)
					{
						continue;
					}
					goto IL_8B6;
					IL_2C2:
					this.$self_$16604.mChar.actionState = "attack";
					if (298314 - 404207 != -105892)
					{
						this.$self_$16604.mChar.actionTime = Time.time;
						if (179986 - 56615 != 123372)
						{
							this.$self_$16604.mChar.myCommand = "nAttack";
							if (146054 - 190786 != -44731)
							{
								this.$self_$16604.mChar.addTimeOut("nAttack", (float)3);
								if (53883 - 153328 != -99444)
								{
									this.$self_$16604.transform.position = this.$mPos$16602;
									if (297834 - 26359 != 271476)
									{
										this.$self_$16604.transform.LookAt(this.$mPos$16602 + global::Math.vFlat(this.$tDir$16603));
										if (161345 - 153709 != 7637)
										{
											this.$self_$16604.animation.CrossFade("nAttack");
											if (180027 - 233406 == -53379)
											{
												this.$self_$16604.animation.wrapMode = WrapMode.Once;
												if (95485 - 125022 == -29537)
												{
													this.$self_$16604.mChar.vMovement = this.$self_$16604.transform.forward;
													if (177415 - 72210 == 105205)
													{
														this.$self_$16604.mChar.moveSpeed = (float)0;
														if (189117 - 39950 == 149167)
														{
															goto IL_385;
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
				Block_10:
				IL_1B9:
				goto IL_955;
				IL_385:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_410:
				goto IL_955;
				Block_44:
				Block_48:
				goto IL_410;
				IL_838:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_8B6:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_955:
				return false;
			}

			// Token: 0x060007D4 RID: 2004 RVA: 0x000CCC90 File Offset: 0x000CAE90
			internal static bool qYxCD7XkTBImQnIIw7Z()
			{
				return true;
			}

			// Token: 0x060007D5 RID: 2005 RVA: 0x000CCC94 File Offset: 0x000CAE94
			internal static bool UCGjhjXGSww6vcBFQym()
			{
				return false;
			}

			// Token: 0x04000718 RID: 1816
			internal int $hitLayer$16596;

			// Token: 0x04000719 RID: 1817
			internal UnityScript.Lang.Array $hitList$16597;

			// Token: 0x0400071A RID: 1818
			internal Vector3 $hitPos$16598;

			// Token: 0x0400071B RID: 1819
			internal int $i$16599;

			// Token: 0x0400071C RID: 1820
			internal GameObject $hitObject$16600;

			// Token: 0x0400071D RID: 1821
			internal IEnumerator $$iterator$9979$16601;

			// Token: 0x0400071E RID: 1822
			internal Vector3 $mPos$16602;

			// Token: 0x0400071F RID: 1823
			internal Vector3 $tDir$16603;

			// Token: 0x04000720 RID: 1824
			internal PaperBug1 $self_$16604;
		}
	}

	// Token: 0x0200015D RID: 349
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bookThrow$16608 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060007D6 RID: 2006 RVA: 0x000CCC98 File Offset: 0x000CAE98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bookThrow$16608(Vector3 mPos, Vector3 tDir, PaperBug1 self_)
		{
			if (31701 - 530921 != -499220)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (250317 - 387762 != -137444)
				{
					base..ctor();
					if (238512 - 474095 != -235582)
					{
						this.$mPos$16614 = mPos;
						if (94642 - 388873 == -294231)
						{
							this.$tDir$16615 = tDir;
							if (49826 - 257021 != -207194)
							{
								this.$self_$16616 = self_;
								if (125256 - 239434 == -114178)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000CCD74 File Offset: 0x000CAF74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug1.$RPC_bookThrow$16608.$(this.$mPos$16614, this.$tDir$16615, this.$self_$16616);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000CCD90 File Offset: 0x000CAF90
		internal static bool PH2ngcXHLhMrPcmukyD()
		{
			return true;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000CCD94 File Offset: 0x000CAF94
		internal static bool iYpjfdXWE2KeG9ZHFSh()
		{
			return false;
		}

		// Token: 0x04000721 RID: 1825
		internal Vector3 $mPos$16614;

		// Token: 0x04000722 RID: 1826
		internal Vector3 $tDir$16615;

		// Token: 0x04000723 RID: 1827
		internal PaperBug1 $self_$16616;

		// Token: 0x0200015E RID: 350
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060007DA RID: 2010 RVA: 0x000CCD98 File Offset: 0x000CAF98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PaperBug1 self_)
			{
				if (20390 - 55642 != -35252)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (41458 - 719 == 40739)
					{
						base..ctor();
						if (289220 - 496751 == -207531)
						{
							this.$mPos$16611 = mPos;
							if (38206 - 444427 == -406221)
							{
								this.$tDir$16612 = tDir;
								if (183560 - 261478 == -77918)
								{
									this.$self_$16613 = self_;
									if (292823 - 298740 != -5916)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060007DB RID: 2011 RVA: 0x000CCE74 File Offset: 0x000CB074
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (200741 - 576131 != -375389)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_61C;
					case 2:
						if (this.$self_$16613.mChar.actionState != "attack")
						{
							goto IL_20A;
						}
						if (89302 - 83227 != 6075)
						{
							continue;
						}
						if (this.$self_$16613.mChar.myCommand != "bookThrow")
						{
							if (144413 - 347442 != -203029)
							{
								continue;
							}
							goto IL_20A;
						}
						else
						{
							if (!this.$self_$16613.mChar.isMine)
							{
								goto IL_3CF;
							}
							if (254540 - 297302 != -42762)
							{
								continue;
							}
							this.$firePos$16609 = this.$mPos$16611 + this.$self_$16613.transform.TransformDirection((float)0, (float)1, (float)1);
							if (244892 - 377112 == -132219)
							{
								continue;
							}
							this.$fireDir$16610 = this.$tDir$16612 - this.$self_$16613.transform.TransformDirection((float)0, (float)1, (float)1);
							if (62666 - 108725 == -46058)
							{
								continue;
							}
							this.$self_$16613.RPC_bookThrow_fire(this.$firePos$16609, this.$fireDir$16610, 0);
							if (198310 - 189898 != 8412)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_3CF;
							}
							if (52038 - 171486 == -119447)
							{
								continue;
							}
							this.$self_$16613.ActionEvent("RPC_bookThrow_fire", this.$firePos$16609, this.$fireDir$16610, 0);
							if (58030 - 80714 != -22683)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16613.mChar.actionState == "attack")
						{
							if (153267 - 349382 == -196114)
							{
								continue;
							}
							if (this.$self_$16613.mChar.myCommand == "bookThrow")
							{
								if (162797 - 166976 == -4178)
								{
									continue;
								}
								this.$self_$16613.mChar.actionState = "standby";
								if (121026 - 414168 == -293141)
								{
									continue;
								}
								this.$self_$16613.mChar.actionTime = Time.time;
								if (150289 - 493113 == -342823)
								{
									continue;
								}
								this.$self_$16613.mChar.myCommand = "none";
								if (299842 - 315065 != -15223)
								{
									continue;
								}
								if (!this.$self_$16613.mChar.isMine)
								{
									if (298966 - 555004 == -256037)
									{
										continue;
									}
									this.$self_$16613.mChar.nPosition = this.$self_$16613.transform.position;
									if (54469 - 76117 == -21647)
									{
										continue;
									}
									this.$self_$16613.mChar.oPosition = this.$self_$16613.transform.position;
									if (41235 - 510979 != -469744)
									{
										continue;
									}
									this.$self_$16613.mChar.nDirection = this.$self_$16613.transform.forward;
									if (218854 - 542287 == -323432)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (80001 - 569995 != -489993)
						{
							goto Block_36;
						}
						continue;
					default:
						if (60566 - 594842 != -534276)
						{
							continue;
						}
						break;
					}
					this.$self_$16613.mChar.actionState = "attack";
					if (262509 - 387360 == -124851)
					{
						this.$self_$16613.mChar.actionTime = Time.time;
						if (24013 - 535321 != -511307)
						{
							this.$self_$16613.mChar.myCommand = "bookThrow";
							if (76503 - 438738 != -362234)
							{
								this.$self_$16613.mChar.addTimeOut("nAttack", (float)3);
								if (150223 - 306294 != -156070)
								{
									this.$self_$16613.transform.position = this.$mPos$16611;
									if (25809 - 37536 == -11727)
									{
										this.$self_$16613.transform.LookAt(this.$mPos$16611 + global::Math.vFlat(this.$tDir$16612));
										if (186434 - 432963 == -246529)
										{
											this.$self_$16613.animation.CrossFade("bookThrow");
											if (161666 - 411800 == -250134)
											{
												this.$self_$16613.animation.wrapMode = WrapMode.Once;
												if (63814 - 68656 == -4842)
												{
													this.$self_$16613.mChar.vMovement = this.$self_$16613.transform.forward;
													if (42586 - 428515 != -385928)
													{
														this.$self_$16613.mChar.moveSpeed = (float)0;
														if (21604 - 333755 == -312151)
														{
															goto IL_31F;
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
				goto IL_3CF;
				IL_20A:
				goto IL_61C;
				IL_31F:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_3CF:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_36:
				IL_61C:
				return false;
			}

			// Token: 0x060007DC RID: 2012 RVA: 0x000CD4B0 File Offset: 0x000CB6B0
			internal static bool idWaM0XAb6RNcoQMS2d()
			{
				return true;
			}

			// Token: 0x060007DD RID: 2013 RVA: 0x000CD4B4 File Offset: 0x000CB6B4
			internal static bool k6p5B1Xl65jWjF7RlIl()
			{
				return false;
			}

			// Token: 0x04000724 RID: 1828
			internal Vector3 $firePos$16609;

			// Token: 0x04000725 RID: 1829
			internal Vector3 $fireDir$16610;

			// Token: 0x04000726 RID: 1830
			internal Vector3 $mPos$16611;

			// Token: 0x04000727 RID: 1831
			internal Vector3 $tDir$16612;

			// Token: 0x04000728 RID: 1832
			internal PaperBug1 $self_$16613;
		}
	}

	// Token: 0x0200015F RID: 351
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16617 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060007DE RID: 2014 RVA: 0x000CD4B8 File Offset: 0x000CB6B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16617(UnityScript.Lang.Array nArray, PaperBug1 self_)
		{
			if (44204 - 232176 != -187972)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (16256 - 557306 == -541050)
				{
					base..ctor();
					if (62987 - 454438 == -391451)
					{
						this.$nArray$16622 = nArray;
						if (50876 - 528191 != -477314)
						{
							this.$self_$16623 = self_;
							if (85066 - 117216 != -32149)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000CD574 File Offset: 0x000CB774
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug1.$RPC_ko$16617.$(this.$nArray$16622, this.$self_$16623);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000CD588 File Offset: 0x000CB788
		internal static bool wawvPIXyL58OAZ3Eb4B()
		{
			return true;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000CD58C File Offset: 0x000CB78C
		internal static bool gHerh4XSKbrlwQR4C0A()
		{
			return false;
		}

		// Token: 0x04000729 RID: 1833
		internal UnityScript.Lang.Array $nArray$16622;

		// Token: 0x0400072A RID: 1834
		internal PaperBug1 $self_$16623;

		// Token: 0x02000160 RID: 352
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060007E2 RID: 2018 RVA: 0x000CD590 File Offset: 0x000CB790
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PaperBug1 self_)
			{
				if (280531 - 181249 != 99283)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277951 - 47889 == 230062)
					{
						base..ctor();
						if (208734 - 80940 == 127794)
						{
							this.$nArray$16620 = nArray;
							if (251303 - 338827 != -87523)
							{
								this.$self_$16621 = self_;
								if (29630 - 222574 == -192944)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060007E3 RID: 2019 RVA: 0x000CD64C File Offset: 0x000CB84C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284139 - 160159 != 123981)
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
						if (this.$self_$16621.mChar.actionState != "ko")
						{
							if (112990 - 14939 != 98052)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$self_$16621.animation.Play("getUp");
							if (146908 - 162393 == -15484)
							{
								continue;
							}
							this.$self_$16621.animation.wrapMode = WrapMode.Once;
							if (164579 - 48890 != 115689)
							{
								continue;
							}
							goto IL_36C;
						}
						break;
					case 3:
						if (this.$self_$16621.mChar.actionState != "ko")
						{
							if (165241 - 316380 != -151138)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$16621.mChar.actionState = "standby";
							if (30924 - 363947 == -333022)
							{
								continue;
							}
							this.$self_$16621.mChar.actionTime = Time.time;
							if (10784 - 33656 != -22872)
							{
								continue;
							}
							this.$self_$16621.mChar.myCommand = "none";
							if (54220 - 431631 != -377411)
							{
								continue;
							}
							this.$self_$16621.mChar.ko = this.$self_$16621.mChar.mko;
							if (197587 - 380729 == -183141)
							{
								continue;
							}
							this.YieldDefault(1);
							if (266507 - 353255 != -86747)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					default:
						if (214911 - 592485 != -377574)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16621.mChar.actionState == "ko")
					{
						break;
					}
					if (219798 - 105355 != 114444)
					{
						if (this.$self_$16621.mChar.actionState == "dead")
						{
							if (97348 - 348519 == -251171)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16618 = (Vector3)this.$nArray$16620[0];
							if (52147 - 561819 != -509671)
							{
								this.$mDir$16619 = (Vector3)this.$nArray$16620[1];
								if (33826 - 484939 == -451113)
								{
									this.$self_$16621.mChar.ko = 0;
									if (203858 - 214994 == -11136)
									{
										this.$self_$16621.mChar.actionState = "ko";
										if (167977 - 334204 == -166227)
										{
											this.$self_$16621.mChar.actionTime = Time.time;
											if (254638 - 554214 != -299575)
											{
												this.$self_$16621.mChar.myCommand = "none";
												if (147471 - 562669 == -415198)
												{
													this.$self_$16621.mChar.vMovement = Vector3.zero;
													if (284286 - 118887 == 165399)
													{
														this.$self_$16621.mChar.moveSpeed = (float)0;
														if (135491 - 136937 != -1445)
														{
															this.$self_$16621.animation.Play("ko");
															if (167493 - 20450 == 147043)
															{
																this.$self_$16621.animation.wrapMode = WrapMode.Once;
																if (132142 - 342361 != -210218)
																{
																	goto Block_7;
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
				Block_6:
				goto IL_48C;
				Block_7:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_11:
				goto IL_48C;
				IL_36C:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_23:
				IL_48C:
				return false;
			}

			// Token: 0x060007E4 RID: 2020 RVA: 0x000CDAF8 File Offset: 0x000CBCF8
			internal static bool CZYCeqXo9W4FcHXSgqE()
			{
				return true;
			}

			// Token: 0x060007E5 RID: 2021 RVA: 0x000CDAFC File Offset: 0x000CBCFC
			internal static bool OhaWVsXE4J58guJ0mso()
			{
				return false;
			}

			// Token: 0x0400072B RID: 1835
			internal Vector3 $mPos$16618;

			// Token: 0x0400072C RID: 1836
			internal Vector3 $mDir$16619;

			// Token: 0x0400072D RID: 1837
			internal UnityScript.Lang.Array $nArray$16620;

			// Token: 0x0400072E RID: 1838
			internal PaperBug1 $self_$16621;
		}
	}

	// Token: 0x02000161 RID: 353
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16624 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060007E6 RID: 2022 RVA: 0x000CDB00 File Offset: 0x000CBD00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16624(UnityScript.Lang.Array nArray, PaperBug1 self_)
		{
			if (228607 - 42074 != 186533)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (253073 - 425973 == -172900)
				{
					base..ctor();
					if (15123 - 293484 != -278360)
					{
						this.$nArray$16629 = nArray;
						if (152473 - 421163 != -268689)
						{
							this.$self_$16630 = self_;
							if (249859 - 422059 != -172199)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000CDBBC File Offset: 0x000CBDBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug1.$RPC_dead$16624.$(this.$nArray$16629, this.$self_$16630);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000CDBD0 File Offset: 0x000CBDD0
		internal static bool jaWJsqX2hX0bHd4md7W()
		{
			return true;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000CDBD4 File Offset: 0x000CBDD4
		internal static bool LWTG8IX8KbMCRDRvL4l()
		{
			return false;
		}

		// Token: 0x0400072F RID: 1839
		internal UnityScript.Lang.Array $nArray$16629;

		// Token: 0x04000730 RID: 1840
		internal PaperBug1 $self_$16630;

		// Token: 0x02000162 RID: 354
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060007EA RID: 2026 RVA: 0x000CDBD8 File Offset: 0x000CBDD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PaperBug1 self_)
			{
				if (45574 - 492092 != -446518)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4136 - 139745 == -135609)
					{
						base..ctor();
						if (226650 - 599499 != -372848)
						{
							this.$nArray$16627 = nArray;
							if (36187 - 367834 != -331646)
							{
								this.$self_$16628 = self_;
								if (106304 - 187256 != -80951)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060007EB RID: 2027 RVA: 0x000CDC94 File Offset: 0x000CBE94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91965 - 361172 != -269206)
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
						if (this.$self_$16628.mChar.actionState != "dead")
						{
							if (56941 - 81186 != -24244)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16628.mChar.isPlayer)
							{
								if (123377 - 525895 != -402518)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16628.gameObject);
								if (4933 - 109717 != -104784)
								{
									continue;
								}
							}
							else if (this.$self_$16628.mChar.isMine)
							{
								if (259517 - 274135 != -14618)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16628.gameObject);
								if (41953 - 219071 != -177118)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (139639 - 119517 != 20122)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (229368 - 217951 != 11417)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16628.mChar.actionState == "dead")
					{
						if (43088 - 122951 != -79862)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$16625 = (Vector3)this.$nArray$16627[0];
						if (208642 - 419644 == -211002)
						{
							this.$myDirection$16626 = (Vector3)this.$nArray$16627[1];
							if (271459 - 2869 != 268591)
							{
								this.$self_$16628.transform.position = this.$myPosition$16625;
								if (69432 - 575576 == -506144)
								{
									this.$self_$16628.transform.LookAt(this.$myPosition$16625 + this.$myDirection$16626);
									if (64569 - 565950 != -501380)
									{
										this.$self_$16628.mChar.hp = 0;
										if (182084 - 243447 == -61363)
										{
											this.$self_$16628.mChar.actionState = "dead";
											if (106075 - 465224 != -359148)
											{
												this.$self_$16628.mChar.actionTime = Time.time;
												if (275225 - 347166 != -71940)
												{
													this.$self_$16628.mChar.myCommand = "none";
													if (259013 - 503632 == -244619)
													{
														this.$self_$16628.mChar.vMovement = Vector3.zero;
														if (62114 - 514659 == -452545)
														{
															this.$self_$16628.mChar.moveSpeed = (float)0;
															if (77396 - 299219 != -221822)
															{
																this.$self_$16628.animation.Rewind();
																if (216389 - 390730 != -174340)
																{
																	this.$self_$16628.animation.Play("ko");
																	if (227505 - 158321 == 69184)
																	{
																		this.$self_$16628.animation.wrapMode = WrapMode.Once;
																		if (184359 - 162525 != 21835)
																		{
																			goto Block_14;
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
				Block_4:
				goto IL_42F;
				Block_14:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x060007EC RID: 2028 RVA: 0x000CE0E4 File Offset: 0x000CC2E4
			internal static bool wsxEY6XZaTILK5Adu1b()
			{
				return true;
			}

			// Token: 0x060007ED RID: 2029 RVA: 0x000CE0E8 File Offset: 0x000CC2E8
			internal static bool ohSFvrXCNd9bUQPTSw8()
			{
				return false;
			}

			// Token: 0x04000731 RID: 1841
			internal Vector3 $myPosition$16625;

			// Token: 0x04000732 RID: 1842
			internal Vector3 $myDirection$16626;

			// Token: 0x04000733 RID: 1843
			internal UnityScript.Lang.Array $nArray$16627;

			// Token: 0x04000734 RID: 1844
			internal PaperBug1 $self_$16628;
		}
	}
}
