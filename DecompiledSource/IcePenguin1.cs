using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C6C RID: 3180
[Serializable]
public class IcePenguin1 : MonoBehaviour
{
	// Token: 0x06004738 RID: 18232 RVA: 0x008E184C File Offset: 0x008DFA4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IcePenguin1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004739 RID: 18233 RVA: 0x008E185C File Offset: 0x008DFA5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (276453 - 95028 != 181425)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (32879 - 430653 == -397774)
			{
				this.mChar.actionState = "standby";
				if (17412 - 240605 == -223193)
				{
					this.mChar.actionTime = Time.time;
					if (103377 - 318916 != -215538)
					{
						this.mChar.myCommand = "none";
						if (139813 - 350670 == -210857)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600473A RID: 18234 RVA: 0x008E1948 File Offset: 0x008DFB48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (217439 - 162950 != 54490)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (155344 - 222474 == -67129)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (206181 - 205631 == 551)
				{
					continue;
				}
			}
			if (!this.mChar)
			{
				break;
			}
			if (34477 - 122334 != -87856)
			{
				this.mChar.StartCoroutine_Auto(this.mChar.addStatus("iceShield", 3, 300, 400, this.mChar.ActorNr));
				if (156416 - 459450 == -303034)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600473B RID: 18235 RVA: 0x008E1A44 File Offset: 0x008DFC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (171901 - 420639 != -248737)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (52439 - 136048 == -83608)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (99349 - 314022 == -214672)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1C5;
					}
					if (229550 - 410751 != -181201)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (103208 - 326024 != -222816)
				{
					continue;
				}
			}
			IL_1C5:
			if (this.mChar.hp <= 0)
			{
				if (203957 - 234604 == -30646)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (250694 - 82211 == 168484)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (242098 - 268910 != -26812)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (136978 - 805 != 136173)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (255183 - 430473 != -175290)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (285390 - 91948 != 193443)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (262681 - 203258 != 59423)
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
			if (62989 - 551232 == -488243)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (48827 - 71757 != -22929)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (158400 - 588279 != -429878)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (71914 - 530429 != -458514)
						{
							if (this.mChar.isMine)
							{
								if (59407 - 529490 == -470083)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (162111 - 126404 == 35707)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (232073 - 526694 == -294621)
										{
											this.mChar.KoEvent();
											if (31384 - 349633 == -318249)
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
								if (78091 - 56740 == 21351)
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

	// Token: 0x0600473C RID: 18236 RVA: 0x008E1E3C File Offset: 0x008E003C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (248168 - 37558 != 210610)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (15179 - 572967 == -557788)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (208926 - 73368 == 135558)
				{
					if (18924 - 540354 != -521429)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (185847 - 445375 != -259528)
							{
								continue;
							}
							v = 1;
							if (167737 - 398199 == -230461)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire")
						{
							if (222240 - 88636 == 133605)
							{
								continue;
							}
							v = 2;
							if (141475 - 553585 != -412110)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (212994 - 7090 == 205905)
							{
								continue;
							}
							v = -1;
							if (133928 - 481091 == -347162)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (124349 - 188731 != -64382)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (241357 - 154943 == 86414)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (61657 - 193412 != -131754)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (298069 - 81754 == 216315)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (114570 - 179113 != -64542)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (71105 - 292587 != -221481)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (130094 - 135472 != -5377)
											{
												Hashtable hashtable = new Hashtable();
												if (6165 - 279775 == -273610)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (15537 - 71914 != -56376)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (22345 - 31242 == -8897)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (17683 - 352782 != -335098)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (108311 - 552829 != -444517)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (161612 - 445154 != -283541)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (125953 - 386896 == -260943)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (26677 - 402303 != -375625)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (3162 - 18866 == -15704)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (264571 - 273484 == -8913)
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

	// Token: 0x0600473D RID: 18237 RVA: 0x008E2304 File Offset: 0x008E0504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (186993 - 444796 != -257803)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (119894 - 270014 != -150119)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (97704 - 182973 == -85269)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (107429 - 577241 == -469812)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (219168 - 306661 != -87492)
						{
							int num3 = num;
							if (154869 - 36696 != 118174)
							{
								if (num3 == 1)
								{
									if (31464 - 379818 != -348353)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (118525 - 425421 == -306896)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (256035 - 368010 != -111974)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (225284 - 462595 != -237310)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (41270 - 44650 != -3379)
										{
											this.RPC_nAttack_fire(vector, vector2, num2);
											if (261932 - 153250 != 108683)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (54453 - 488628 != -434174)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (67302 - 406309 == -339007)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (75766 - 26179 == 49587)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (16037 - 277054 != -261016)
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

	// Token: 0x0600473E RID: 18238 RVA: 0x008E260C File Offset: 0x008E080C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (57290 - 18033 != 39257)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (3653 - 95790 != -92136)
			{
				float runSpeed = this.mChar.runSpeed;
				if (188298 - 194461 == -6163)
				{
					Vector3 a = default(Vector3);
					if (255101 - 25959 == 229142)
					{
						Vector3 vector = Vector3.zero;
						if (258265 - 285026 == -26761)
						{
							float num2 = (float)0;
							if (28043 - 519589 == -491546)
							{
								if (this.mChar.isMine)
								{
									if (185025 - 589715 == -404689)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (24831 - 347832 != -323001)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (69213 - 406025 != -336812)
										{
											continue;
										}
										a.y = (float)0;
										if (115725 - 91894 == 23832)
										{
											continue;
										}
										a = a.normalized;
										if (188019 - 465244 == -277224)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (258707 - 579539 == -320831)
										{
											continue;
										}
										vector = vector.normalized;
										if (212521 - 272135 == -59613)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (41119 - 164762 != -123643)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (41650 - 426836 != -385186)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (123614 - 74283 != 49331)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (6318 - 418965 == -412646)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (100838 - 262976 == -162137)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (113251 - 197387 != -84136)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (86273 - 24177 != 62096)
														{
															continue;
														}
														this.animation.Play("run");
														if (20151 - 405385 != -385234)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (56930 - 416103 != -359172)
														{
															goto IL_691;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (250855 - 155904 != 94951)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (251502 - 300214 != -48712)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (203553 - 342076 != -138523)
											{
												continue;
											}
											num = (float)0;
											if (220140 - 302202 != -82062)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (136722 - 61755 != 74967)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (170933 - 435767 == -264833)
										{
											continue;
										}
										IL_691:;
									}
									else if (this.mChar.verticalSpeed < -9.18f)
									{
										if (266197 - 365333 == -99135)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (110175 - 308415 == -198239)
										{
											continue;
										}
										this.animation.CrossFade("falling", 0.2f);
										if (213806 - 475806 == -261999)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (94001 - 269139 != -175138)
										{
											continue;
										}
									}
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (103542 - 446309 != -342767)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (263572 - 229767 == 33806)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (263842 - 193372 != 70470)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (106938 - 342213 == -235274)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (247817 - 301040 != -53223)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (23048 - 11174 == 11875)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (33850 - 202167 == -168316)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (55487 - 93371 == -37883)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (239954 - 94124 == 145831)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (111897 - 311635 != -199738)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (76313 - 592793 != -516480)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (113940 - 507814 != -393874)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (10773 - 440857 == -430083)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (31052 - 356959 == -325906)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (265626 - 13916 != 251710)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (24948 - 377524 != -352576)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (134740 - 128534 == 6207)
												{
													continue;
												}
												num = (float)0;
												if (56460 - 352458 == -295997)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (83352 - 57542 == 25811)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (122623 - 99091 != 23532)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (70847 - 172862 == -102014)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (212599 - 111580 == 101020)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (56982 - 519995 == -463012)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (250446 - 63850 == 186597)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (116479 - 3836 == 112644)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (235913 - 301260 != -65347)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (257693 - 345510 != -87817)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (88481 - 375842 == -287360)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (4290 - 186651 == -182360)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (141569 - 113708 == 27862)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (219633 - 412693 == -193059)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (151374 - 241865 != -90491)
											{
												continue;
											}
											num = (float)0;
											if (133571 - 346369 == -212797)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (84904 - 529364 == -444459)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (112833 - 422390 == -309556)
											{
												continue;
											}
										}
									}
									else if (this.mChar.verticalSpeed < -9.18f)
									{
										if (6727 - 83247 != -76520)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (139217 - 373042 == -233824)
										{
											continue;
										}
										this.animation.CrossFade("falling", 0.2f);
										if (179898 - 327654 != -147756)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (36856 - 365714 == -328857)
										{
											continue;
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (142809 - 594338 == -451528)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (286816 - 237875 == 48942)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (188816 - 402808 != -213991)
								{
									this.mChar.moveSpeed = num;
									if (250951 - 324486 != -73534)
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

	// Token: 0x0600473F RID: 18239 RVA: 0x008E32D8 File Offset: 0x008E14D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (110193 - 115168 != -4975)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (271846 - 581566 != -309719)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (254396 - 567626 == -313230)
				{
					Vector3 vector = a - this.transform.position;
					if (144290 - 28756 != 115535)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (217319 - 464894 == -247575)
						{
							CharacterControl characterControl = null;
							if (271385 - 482536 == -211151)
							{
								if (19025 - 220489 == -201464)
								{
									if (gameObject)
									{
										if (221547 - 180207 != 41340)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (162616 - 207711 != -45095)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (32112 - 416378 == -384265)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (148976 - 215928 == -66951)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (43569 - 207833 != -164264)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (285058 - 431642 == -146583)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (206197 - 380878 == -174681)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (117079 - 247445 != -130365)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (110605 - 296401 == -185796)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (151819 - 485551 == -333732)
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

	// Token: 0x06004740 RID: 18240 RVA: 0x008E35D0 File Offset: 0x008E17D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (248226 - 402907 != -154681)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (145717 - 79424 == 66293)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (180419 - 76038 == 104381)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (292287 - 470951 != -178663)
					{
						Vector3 normalized = vector.normalized;
						if (155753 - 84685 != 71069)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (105201 - 363389 != -258187)
							{
								CharacterControl characterControl = null;
								if (251402 - 382260 == -130858)
								{
									if (176358 - 292495 != -116136)
									{
										if (gameObject)
										{
											if (88234 - 103208 == -14973)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (144976 - 248138 == -103161)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (145655 - 418444 == -272788)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (209476 - 357204 == -147727)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (16549 - 437045 == -420495)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (183615 - 245529 == -61913)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (281093 - 22684 != 258410)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (33599 - 70257 != -36657)
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

	// Token: 0x06004741 RID: 18241 RVA: 0x008E389C File Offset: 0x008E1A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004742 RID: 18242 RVA: 0x008E38A0 File Offset: 0x008E1AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IcePenguin1.$RPC_nAttack$32246(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004743 RID: 18243 RVA: 0x008E38B0 File Offset: 0x008E1AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (203339 - 95176 != 108164)
		{
		}
		while (this.nAttack_fire)
		{
			if (174501 - 57875 == 116626)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos, Quaternion.FromToRotation(Vector3.forward, fireDir));
				if (256060 - 29637 == 226423)
				{
					ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
					if (183491 - 180829 == 2662)
					{
						projectileControl.Init(this.mChar.ActorNr);
						if (84658 - 280289 != -195630)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004744 RID: 18244 RVA: 0x008E39A4 File Offset: 0x008E1BA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06004745 RID: 18245 RVA: 0x008E39D0 File Offset: 0x008E1BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new IcePenguin1.$RPC_ko$32255(nArray, this).GetEnumerator();
	}

	// Token: 0x06004746 RID: 18246 RVA: 0x008E39E0 File Offset: 0x008E1BE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new IcePenguin1.$RPC_dead$32262(nArray, this).GetEnumerator();
	}

	// Token: 0x06004747 RID: 18247 RVA: 0x008E39F0 File Offset: 0x008E1BF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004748 RID: 18248 RVA: 0x008E39F4 File Offset: 0x008E1BF4
	internal static bool gHRNDH5JnDK8Em1Nh24v()
	{
		return true;
	}

	// Token: 0x06004749 RID: 18249 RVA: 0x008E39F8 File Offset: 0x008E1BF8
	internal static bool aTKF8o5J6U8v6k9MbkMe()
	{
		return false;
	}

	// Token: 0x04005284 RID: 21124
	public CharacterControl mChar;

	// Token: 0x04005285 RID: 21125
	public GameObject nAttack_fire;

	// Token: 0x04005286 RID: 21126
	public GameObject nAttack_hit;

	// Token: 0x02000C6D RID: 3181
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32246 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600474A RID: 18250 RVA: 0x008E39FC File Offset: 0x008E1BFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32246(Vector3 mPos, Vector3 tDir, IcePenguin1 self_)
		{
			if (261546 - 296229 != -34683)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51108 - 325988 == -274880)
				{
					base..ctor();
					if (81442 - 322771 == -241329)
					{
						this.$mPos$32252 = mPos;
						if (240437 - 270809 == -30372)
						{
							this.$tDir$32253 = tDir;
							if (114143 - 486426 != -372282)
							{
								this.$self_$32254 = self_;
								if (78895 - 47062 == 31833)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x008E3AD8 File Offset: 0x008E1CD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin1.$RPC_nAttack$32246.$(this.$mPos$32252, this.$tDir$32253, this.$self_$32254);
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x008E3AF4 File Offset: 0x008E1CF4
		internal static bool r9lX3j5Ji30g4MN4y0Ab()
		{
			return true;
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x008E3AF8 File Offset: 0x008E1CF8
		internal static bool e3EnVT5JKoGeNQQRW2vc()
		{
			return false;
		}

		// Token: 0x04005287 RID: 21127
		internal Vector3 $mPos$32252;

		// Token: 0x04005288 RID: 21128
		internal Vector3 $tDir$32253;

		// Token: 0x04005289 RID: 21129
		internal IcePenguin1 $self_$32254;

		// Token: 0x02000C6E RID: 3182
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600474E RID: 18254 RVA: 0x008E3AFC File Offset: 0x008E1CFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IcePenguin1 self_)
			{
				if (123892 - 478270 != -354377)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112873 - 479061 != -366187)
					{
						base..ctor();
						if (130841 - 304975 != -174133)
						{
							this.$mPos$32249 = mPos;
							if (137440 - 105768 != 31673)
							{
								this.$tDir$32250 = tDir;
								if (292027 - 485852 != -193824)
								{
									this.$self_$32251 = self_;
									if (94555 - 139519 == -44964)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600474F RID: 18255 RVA: 0x008E3BD8 File Offset: 0x008E1DD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (285626 - 296673 != -11046)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_638;
					case 2:
						if (this.$self_$32251.mChar.actionState != "attack")
						{
							goto IL_287;
						}
						if (143436 - 306871 == -163434)
						{
							continue;
						}
						if (this.$self_$32251.mChar.myCommand != "nAttack")
						{
							if (50545 - 230259 != -179714)
							{
								continue;
							}
							goto IL_287;
						}
						else
						{
							if (!this.$self_$32251.mChar.isMine)
							{
								goto IL_196;
							}
							if (55132 - 27670 != 27462)
							{
								continue;
							}
							this.$firePos$32247 = this.$mPos$32249 + this.$self_$32251.transform.TransformDirection(new Vector3(0.5f, 0.75f, 0.5f));
							if (77281 - 114895 != -37614)
							{
								continue;
							}
							this.$fireDir$32248 = this.$tDir$32250 - this.$self_$32251.transform.TransformDirection(new Vector3(0.5f, 0.75f, 0.5f));
							if (291477 - 99548 == 191930)
							{
								continue;
							}
							this.$self_$32251.RPC_nAttack_fire(this.$firePos$32247, this.$fireDir$32248, 0);
							if (265787 - 469220 == -203432)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_196;
							}
							if (286511 - 242828 == 43684)
							{
								continue;
							}
							this.$self_$32251.ActionEvent("RPC_nAttack_fire", this.$firePos$32247, this.$fireDir$32248, 0);
							if (299044 - 526844 != -227799)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32251.mChar.actionState == "attack")
						{
							if (285958 - 265422 == 20537)
							{
								continue;
							}
							if (this.$self_$32251.mChar.myCommand == "nAttack")
							{
								if (299044 - 109238 != 189806)
								{
									continue;
								}
								this.$self_$32251.mChar.actionState = "standby";
								if (222384 - 137256 != 85128)
								{
									continue;
								}
								this.$self_$32251.mChar.actionTime = Time.time;
								if (197178 - 114177 != 83001)
								{
									continue;
								}
								this.$self_$32251.mChar.myCommand = "none";
								if (201032 - 38659 != 162373)
								{
									continue;
								}
								if (!this.$self_$32251.mChar.isMine)
								{
									if (50454 - 525247 != -474793)
									{
										continue;
									}
									this.$self_$32251.mChar.nPosition = this.$self_$32251.transform.position;
									if (159898 - 481252 == -321353)
									{
										continue;
									}
									this.$self_$32251.mChar.oPosition = this.$self_$32251.transform.position;
									if (78370 - 209323 != -130953)
									{
										continue;
									}
									this.$self_$32251.mChar.nDirection = this.$self_$32251.transform.forward;
									if (252371 - 355660 == -103288)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (210577 - 448703 != -238126)
						{
							continue;
						}
						goto IL_638;
					default:
						if (295192 - 548067 != -252875)
						{
							continue;
						}
						break;
					}
					this.$self_$32251.mChar.actionState = "attack";
					if (184664 - 176227 != 8438)
					{
						this.$self_$32251.mChar.actionTime = Time.time;
						if (86 - 133417 != -133330)
						{
							this.$self_$32251.mChar.myCommand = "nAttack";
							if (224250 - 97240 == 127010)
							{
								this.$self_$32251.mChar.addTimeOut("nAttack", (float)2);
								if (76901 - 66530 != 10372)
								{
									this.$self_$32251.transform.position = this.$mPos$32249;
									if (173796 - 111469 == 62327)
									{
										this.$self_$32251.transform.LookAt(this.$mPos$32249 + global::Math.vFlat(this.$tDir$32250));
										if (226718 - 91866 != 134853)
										{
											this.$self_$32251.animation.CrossFade("nAttack");
											if (199401 - 504245 != -304843)
											{
												this.$self_$32251.animation.wrapMode = WrapMode.Once;
												if (116213 - 576743 != -460529)
												{
													this.$self_$32251.mChar.vMovement = this.$self_$32251.transform.forward;
													if (166253 - 423834 != -257580)
													{
														this.$self_$32251.mChar.moveSpeed = (float)0;
														if (68519 - 155864 == -87345)
														{
															goto IL_214;
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
				IL_196:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_214:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_287:
				goto IL_638;
				Block_24:
				goto IL_196;
				IL_638:
				return false;
			}

			// Token: 0x06004750 RID: 18256 RVA: 0x008E4230 File Offset: 0x008E2430
			internal static bool PeDmje5JdQejA3qko9l4()
			{
				return true;
			}

			// Token: 0x06004751 RID: 18257 RVA: 0x008E4234 File Offset: 0x008E2434
			internal static bool kAtYjH5JJQoEBEj2sp1j()
			{
				return false;
			}

			// Token: 0x0400528A RID: 21130
			internal Vector3 $firePos$32247;

			// Token: 0x0400528B RID: 21131
			internal Vector3 $fireDir$32248;

			// Token: 0x0400528C RID: 21132
			internal Vector3 $mPos$32249;

			// Token: 0x0400528D RID: 21133
			internal Vector3 $tDir$32250;

			// Token: 0x0400528E RID: 21134
			internal IcePenguin1 $self_$32251;
		}
	}

	// Token: 0x02000C6F RID: 3183
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32255 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004752 RID: 18258 RVA: 0x008E4238 File Offset: 0x008E2438
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32255(UnityScript.Lang.Array nArray, IcePenguin1 self_)
		{
			if (53828 - 111142 != -57313)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4867 - 191642 == -186775)
				{
					base..ctor();
					if (62116 - 25044 != 37073)
					{
						this.$nArray$32260 = nArray;
						if (174612 - 405800 != -231187)
						{
							this.$self_$32261 = self_;
							if (178689 - 22985 == 155704)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x008E42F4 File Offset: 0x008E24F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin1.$RPC_ko$32255.$(this.$nArray$32260, this.$self_$32261);
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x008E4308 File Offset: 0x008E2508
		internal static bool O1hnNE5JDcosqjstrEYG()
		{
			return true;
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x008E430C File Offset: 0x008E250C
		internal static bool DYOOUW5JvTb5KQZGnDa9()
		{
			return false;
		}

		// Token: 0x0400528F RID: 21135
		internal UnityScript.Lang.Array $nArray$32260;

		// Token: 0x04005290 RID: 21136
		internal IcePenguin1 $self_$32261;

		// Token: 0x02000C70 RID: 3184
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004756 RID: 18262 RVA: 0x008E4310 File Offset: 0x008E2510
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, IcePenguin1 self_)
			{
				if (290945 - 451137 != -160192)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (227685 - 49870 == 177815)
					{
						base..ctor();
						if (103985 - 486743 != -382757)
						{
							this.$nArray$32258 = nArray;
							if (58395 - 426827 == -368432)
							{
								this.$self_$32259 = self_;
								if (268879 - 265694 != 3186)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004757 RID: 18263 RVA: 0x008E43CC File Offset: 0x008E25CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (171055 - 576179 != -405124)
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
						if (this.$self_$32259.mChar.actionState != "ko")
						{
							if (297251 - 213744 != 83507)
							{
								continue;
							}
							goto IL_244;
						}
						else
						{
							this.$self_$32259.animation.Play("getUp");
							if (173819 - 201315 == -27495)
							{
								continue;
							}
							this.$self_$32259.animation.wrapMode = WrapMode.Once;
							if (22011 - 65621 != -43610)
							{
								continue;
							}
							goto IL_106;
						}
						break;
					case 3:
						if (this.$self_$32259.mChar.actionState != "ko")
						{
							if (204965 - 598136 != -393170)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$self_$32259.mChar.actionState = "standby";
							if (287275 - 225380 == 61896)
							{
								continue;
							}
							this.$self_$32259.mChar.actionTime = Time.time;
							if (22986 - 459994 == -437007)
							{
								continue;
							}
							this.$self_$32259.mChar.myCommand = "none";
							if (203846 - 194555 != 9291)
							{
								continue;
							}
							this.$self_$32259.mChar.ko = this.$self_$32259.mChar.mko;
							if (131308 - 161703 != -30395)
							{
								continue;
							}
							this.YieldDefault(1);
							if (115628 - 275918 != -160289)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					default:
						if (229319 - 558804 == -329484)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32259.mChar.actionState == "ko")
					{
						goto IL_1B8;
					}
					if (252784 - 246391 == 6393)
					{
						if (this.$self_$32259.mChar.actionState == "dead")
						{
							if (293242 - 300941 == -7699)
							{
								goto IL_1B8;
							}
						}
						else
						{
							this.$mPos$32256 = (Vector3)this.$nArray$32258[0];
							if (58049 - 54768 == 3281)
							{
								this.$mDir$32257 = (Vector3)this.$nArray$32258[1];
								if (179967 - 529650 == -349683)
								{
									this.$self_$32259.mChar.ko = 0;
									if (35380 - 45669 != -10288)
									{
										this.$self_$32259.mChar.actionState = "ko";
										if (32754 - 330922 != -298167)
										{
											this.$self_$32259.mChar.actionTime = Time.time;
											if (112097 - 521810 != -409712)
											{
												this.$self_$32259.mChar.myCommand = "none";
												if (6281 - 62627 == -56346)
												{
													this.$self_$32259.mChar.vMovement = Vector3.zero;
													if (151606 - 236486 == -84880)
													{
														this.$self_$32259.mChar.moveSpeed = (float)0;
														if (227064 - 426950 == -199886)
														{
															this.$self_$32259.animation.Play("ko");
															if (64481 - 559340 == -494859)
															{
																this.$self_$32259.animation.wrapMode = WrapMode.Once;
																if (3463 - 13552 != -10088)
																{
																	goto Block_17;
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
				IL_106:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_8:
				IL_1B8:
				Block_12:
				IL_244:
				goto IL_48C;
				Block_17:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06004758 RID: 18264 RVA: 0x008E4878 File Offset: 0x008E2A78
			internal static bool MPKY5X5JRGPZunatYpXC()
			{
				return true;
			}

			// Token: 0x06004759 RID: 18265 RVA: 0x008E487C File Offset: 0x008E2A7C
			internal static bool NFmdBk5JwwEb2TfKbU6P()
			{
				return false;
			}

			// Token: 0x04005291 RID: 21137
			internal Vector3 $mPos$32256;

			// Token: 0x04005292 RID: 21138
			internal Vector3 $mDir$32257;

			// Token: 0x04005293 RID: 21139
			internal UnityScript.Lang.Array $nArray$32258;

			// Token: 0x04005294 RID: 21140
			internal IcePenguin1 $self_$32259;
		}
	}

	// Token: 0x02000C71 RID: 3185
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32262 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600475A RID: 18266 RVA: 0x008E4880 File Offset: 0x008E2A80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32262(UnityScript.Lang.Array nArray, IcePenguin1 self_)
		{
			if (118200 - 412258 != -294057)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (154641 - 35743 == 118898)
				{
					base..ctor();
					if (183995 - 414734 == -230739)
					{
						this.$nArray$32267 = nArray;
						if (8818 - 322959 == -314141)
						{
							this.$self_$32268 = self_;
							if (155625 - 415283 == -259658)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x008E493C File Offset: 0x008E2B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin1.$RPC_dead$32262.$(this.$nArray$32267, this.$self_$32268);
		}

		// Token: 0x0600475C RID: 18268 RVA: 0x008E4950 File Offset: 0x008E2B50
		internal static bool F4sZZq5JqIK8xb9ZgdkN()
		{
			return true;
		}

		// Token: 0x0600475D RID: 18269 RVA: 0x008E4954 File Offset: 0x008E2B54
		internal static bool A0FbGd5J7bPpBj2ljSaD()
		{
			return false;
		}

		// Token: 0x04005295 RID: 21141
		internal UnityScript.Lang.Array $nArray$32267;

		// Token: 0x04005296 RID: 21142
		internal IcePenguin1 $self_$32268;

		// Token: 0x02000C72 RID: 3186
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600475E RID: 18270 RVA: 0x008E4958 File Offset: 0x008E2B58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, IcePenguin1 self_)
			{
				if (116043 - 155750 != -39707)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283293 - 381712 == -98419)
					{
						base..ctor();
						if (160664 - 324138 != -163473)
						{
							this.$nArray$32265 = nArray;
							if (254308 - 369066 == -114758)
							{
								this.$self_$32266 = self_;
								if (13453 - 464420 != -450966)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600475F RID: 18271 RVA: 0x008E4A14 File Offset: 0x008E2C14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56057 - 369591 != -313534)
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
						if (this.$self_$32266.mChar.actionState != "dead")
						{
							if (297004 - 212797 != 84207)
							{
								continue;
							}
							goto IL_AF;
						}
						else
						{
							if (!this.$self_$32266.mChar.isPlayer)
							{
								if (221332 - 478754 != -257422)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32266.gameObject);
								if (104039 - 42885 != 61154)
								{
									continue;
								}
							}
							else if (this.$self_$32266.mChar.isMine)
							{
								if (15021 - 246341 != -231320)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32266.gameObject);
								if (227348 - 158026 == 69323)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (268175 - 108275 != 159900)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (92176 - 485406 == -393229)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32266.mChar.actionState == "dead")
					{
						if (241656 - 458474 == -216818)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32263 = (Vector3)this.$nArray$32265[0];
						if (173280 - 546400 == -373120)
						{
							this.$myDirection$32264 = (Vector3)this.$nArray$32265[1];
							if (147460 - 3211 == 144249)
							{
								this.$self_$32266.transform.position = this.$myPosition$32263;
								if (251207 - 1422 == 249785)
								{
									this.$self_$32266.transform.LookAt(this.$myPosition$32263 + this.$myDirection$32264);
									if (69357 - 11831 == 57526)
									{
										this.$self_$32266.mChar.hp = 0;
										if (220793 - 593341 == -372548)
										{
											this.$self_$32266.mChar.actionState = "dead";
											if (267060 - 53087 == 213973)
											{
												this.$self_$32266.mChar.actionTime = Time.time;
												if (162792 - 172800 == -10008)
												{
													this.$self_$32266.mChar.myCommand = "none";
													if (69451 - 537276 != -467824)
													{
														this.$self_$32266.mChar.vMovement = Vector3.zero;
														if (58911 - 54261 != 4651)
														{
															this.$self_$32266.mChar.moveSpeed = (float)0;
															if (192962 - 444722 != -251759)
															{
																this.$self_$32266.animation.Rewind();
																if (163510 - 242178 == -78668)
																{
																	this.$self_$32266.animation.Play("ko");
																	if (121603 - 502525 != -380921)
																	{
																		this.$self_$32266.animation.wrapMode = WrapMode.Once;
																		if (84064 - 11376 != 72689)
																		{
																			goto Block_8;
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
				IL_AF:
				goto IL_42F;
				Block_8:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06004760 RID: 18272 RVA: 0x008E4E64 File Offset: 0x008E3064
			internal static bool aOOvYh5JP0O7A5yB7ChA()
			{
				return true;
			}

			// Token: 0x06004761 RID: 18273 RVA: 0x008E4E68 File Offset: 0x008E3068
			internal static bool s3vP5o5J0rTWa1yAMhZ6()
			{
				return false;
			}

			// Token: 0x04005297 RID: 21143
			internal Vector3 $myPosition$32263;

			// Token: 0x04005298 RID: 21144
			internal Vector3 $myDirection$32264;

			// Token: 0x04005299 RID: 21145
			internal UnityScript.Lang.Array $nArray$32265;

			// Token: 0x0400529A RID: 21146
			internal IcePenguin1 $self_$32266;
		}
	}
}
