using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CAF RID: 3247
[Serializable]
public class LadyNoir : MonoBehaviour
{
	// Token: 0x060048DE RID: 18654 RVA: 0x0090BE74 File Offset: 0x0090A074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LadyNoir()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060048DF RID: 18655 RVA: 0x0090BE84 File Offset: 0x0090A084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (10039 - 576612 != -566573)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (38682 - 378932 == -340250)
			{
				this.mChar.actionState = "standby";
				if (111699 - 261410 != -149710)
				{
					this.mChar.actionTime = Time.time;
					if (166730 - 208456 == -41726)
					{
						this.mChar.myCommand = "none";
						if (250632 - 262370 != -11737)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060048E0 RID: 18656 RVA: 0x0090BF70 File Offset: 0x0090A170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (90224 - 409597 != -319373)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (154500 - 77743 == 76758)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (40726 - 57567 != -16841)
				{
					continue;
				}
			}
			if (Game.mGameCode != 934)
			{
				break;
			}
			if (7772 - 81892 != -74119)
			{
				if (this.mChar.ActorNr == 0)
				{
					break;
				}
				if (75734 - 169464 != -93729)
				{
					this.mChar.StartCoroutine_Auto(this.mChar.addStatus("darkRitual", 1, 999, 0, this.mChar.ActorNr));
					if (175616 - 505127 == -329511)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060048E1 RID: 18657 RVA: 0x0090C090 File Offset: 0x0090A290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playWingFlapEvent(AnimationEvent animEvent)
	{
		if (this.wingFlap)
		{
			this.audio.PlayOneShot(this.wingFlap);
		}
	}

	// Token: 0x060048E2 RID: 18658 RVA: 0x0090C0B4 File Offset: 0x0090A2B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (165797 - 131628 != 34169)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (51368 - 299084 != -247716)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (164833 - 25918 == 138916)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_32C;
					}
					if (145021 - 422681 != -277660)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (249245 - 400947 != -151702)
				{
					continue;
				}
			}
			IL_32C:
			if (this.mChar.hp <= 0)
			{
				if (21448 - 159092 != -137644)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (45356 - 220831 == -175474)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (99292 - 487608 == -388315)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (252991 - 198481 == 54511)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (120240 - 390486 != -270246)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (85826 - 583056 != -497230)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (14902 - 403397 != -388495)
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
			if (88670 - 588174 != -499503)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (216857 - 379631 == -162774)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (179361 - 177369 == 1992)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (115678 - 323881 != -208202)
						{
							if (this.mChar.isMine)
							{
								if (33963 - 480126 == -446163)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (187796 - 242995 == -55199)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (99761 - 568362 != -468600)
										{
											this.mChar.KoEvent();
											if (206244 - 564172 == -357928)
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
								if (276228 - 414698 != -138469)
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

	// Token: 0x060048E3 RID: 18659 RVA: 0x0090C4AC File Offset: 0x0090A6AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (205939 - 586585 != -380646)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (104601 - 51894 == 52707)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (66688 - 276418 == -209730)
				{
					if (72380 - 160799 != -88418)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (30956 - 139198 != -108242)
							{
								continue;
							}
							v = 1;
							if (151669 - 487357 != -335688)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire")
						{
							if (243243 - 100356 != 142887)
							{
								continue;
							}
							v = 2;
							if (22473 - 206138 == -183664)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (282186 - 319592 != -37406)
							{
								continue;
							}
							v = -1;
							if (276428 - 295503 == -19074)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (144893 - 310024 == -165130)
							{
								continue;
							}
							v = 11;
							if (218993 - 535493 == -316499)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack0")
						{
							if (17793 - 175004 == -157210)
							{
								continue;
							}
							v = -11;
							if (257901 - 400690 == -142788)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_demonGaze")
						{
							if (220808 - 589962 != -369154)
							{
								continue;
							}
							v = 21;
							if (63494 - 548303 != -484809)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_shame")
						{
							if (109187 - 70332 != 38855)
							{
								continue;
							}
							v = 31;
							if (73139 - 1444 == 71696)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nefariousWhip")
						{
							if (81924 - 128472 == -46547)
							{
								continue;
							}
							v = 41;
							if (258611 - 523399 != -264788)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nefariousWhip_hit")
						{
							if (169382 - 133340 == 36043)
							{
								continue;
							}
							v = -41;
							if (241937 - 34379 == 207559)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_darkIllusion")
						{
							if (141147 - 54935 == 86213)
							{
								continue;
							}
							v = 51;
							if (71824 - 500167 == -428342)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (295781 - 344801 == -49019)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (178838 - 206124 != -27285)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (117531 - 82138 != 35394)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (122145 - 201346 == -79201)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (150681 - 114127 != 36555)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (188786 - 317301 != -128514)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (246166 - 423666 != -177499)
											{
												Hashtable hashtable = new Hashtable();
												if (56980 - 368342 != -311361)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (2580 - 485334 != -482753)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (43390 - 440387 != -396996)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (261170 - 479403 == -218233)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (17582 - 144608 != -127025)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (113403 - 244324 == -130921)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (65654 - 270632 == -204978)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (145360 - 280132 == -134772)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (121465 - 173069 == -51604)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (275157 - 432282 != -157124)
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

	// Token: 0x060048E4 RID: 18660 RVA: 0x0090CB88 File Offset: 0x0090AD88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (37142 - 451164 != -414021)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (159073 - 53566 != 105508)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (280660 - 360622 != -79961)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (130651 - 288803 != -158151)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (40379 - 389625 != -349245)
						{
							int num3 = num;
							if (231668 - 187328 != 44341)
							{
								if (num3 == 1)
								{
									if (123732 - 96550 != 27183)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (4177 - 460118 != -455940)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (294993 - 292899 != 2095)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (44794 - 34703 != 10092)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (45182 - 476105 == -430923)
										{
											this.RPC_nAttack_fire(vector, vector2, num2);
											if (113289 - 124904 == -11615)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (209302 - 426646 == -217344)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (287246 - 339491 == -52245)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (64715 - 103537 != -38821)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (48383 - 499311 != -450927)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (142505 - 69526 == 72979)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (178661 - 129519 == 49142)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (260117 - 559620 != -299502)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (239939 - 402246 == -162307)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack0(vector, vector2, num2));
											if (263630 - 491680 != -228049)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (43587 - 294884 != -251296)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (121254 - 481440 == -360186)
										{
											this.RPC_demonGaze(vector, vector2, num2);
											if (189215 - 11835 != 177381)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (260977 - 472000 == -211023)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (257719 - 371554 == -113835)
										{
											this.StartCoroutine_Auto(this.RPC_shame(vector, vector2, num2));
											if (162618 - 36864 != 125755)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (1533 - 408219 == -406686)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (299670 - 315692 != -16021)
										{
											this.StartCoroutine_Auto(this.RPC_nefariousWhip(vector, vector2, num2));
											if (67951 - 15665 != 52287)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -41)
								{
									if (12208 - 489454 != -477245)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (161521 - 515195 == -353674)
										{
											this.StartCoroutine_Auto(this.RPC_nefariousWhip_hit(vector, vector2, num2));
											if (155121 - 402858 == -247737)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 51)
								{
									if (176420 - 541491 == -365071)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (255961 - 39443 != 216519)
										{
											this.StartCoroutine_Auto(this.RPC_darkIllusion(vector, vector2, num2));
											if (176628 - 39429 == 137199)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (141358 - 93714 == 47644)
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

	// Token: 0x060048E5 RID: 18661 RVA: 0x0090D1EC File Offset: 0x0090B3EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (65540 - 211351 != -145811)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (34860 - 165662 == -130802)
			{
				float runSpeed = this.mChar.runSpeed;
				if (190230 - 163677 != 26554)
				{
					Vector3 a = default(Vector3);
					if (48806 - 108560 != -59753)
					{
						Vector3 vector = Vector3.zero;
						if (83365 - 151768 == -68403)
						{
							float num2 = (float)0;
							if (143458 - 89747 == 53711)
							{
								if (this.mChar.isMine)
								{
									if (237607 - 540473 == -302865)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (2622 - 508266 != -505644)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (224347 - 214359 != 9988)
										{
											continue;
										}
										a.y = (float)0;
										if (66258 - 29277 == 36982)
										{
											continue;
										}
										a = a.normalized;
										if (181877 - 565794 != -383917)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (258008 - 513978 == -255969)
										{
											continue;
										}
										vector = vector.normalized;
										if (268173 - 257025 == 11149)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (174503 - 475201 != -300698)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (142077 - 399064 != -256987)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (253459 - 168888 == 84572)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (240351 - 218392 != 21959)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (228297 - 456875 == -228577)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (95774 - 37620 != 58154)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (241520 - 179443 != 62077)
														{
															continue;
														}
														this.animation.Play("run");
														if (187170 - 352265 == -165094)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (256986 - 310189 != -53202)
														{
															goto IL_1D7;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (155531 - 6466 == 149066)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (39312 - 240370 == -201057)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (58362 - 185618 == -127255)
											{
												continue;
											}
											num = (float)0;
											if (292464 - 386848 == -94383)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (36042 - 246717 == -210674)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (57089 - 80160 != -23071)
										{
											continue;
										}
									}
									IL_1D7:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (18677 - 310593 == -291915)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (52303 - 380275 == -327971)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (244401 - 567909 == -323507)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (51588 - 333498 == -281909)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (105444 - 209841 == -104396)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (182138 - 50262 != 131876)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (211122 - 173439 == 37684)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (20227 - 539469 != -519242)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (237580 - 479007 != -241427)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (153840 - 396235 == -242394)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (195417 - 45714 == 149704)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (49502 - 302207 != -252705)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (134172 - 429167 != -294995)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (288070 - 269867 != 18203)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (276712 - 354214 == -77501)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (132316 - 363604 != -231288)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (11894 - 142844 == -130949)
												{
													continue;
												}
												num = (float)0;
												if (158313 - 446295 != -287982)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (181054 - 517144 == -336089)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (17098 - 251869 == -234770)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (100098 - 531815 != -431717)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (219435 - 435205 == -215769)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (179627 - 76232 == 103396)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (247701 - 26141 == 221561)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (144705 - 187964 == -43258)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (106187 - 587313 == -481125)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (145754 - 453763 == -308008)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (275260 - 347747 != -72487)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (43710 - 494730 != -451020)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (148050 - 149277 != -1227)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (57782 - 597479 == -539696)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (116829 - 85557 == 31273)
											{
												continue;
											}
											num = (float)0;
											if (73808 - 494778 != -420970)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (114306 - 308574 != -194268)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (30586 - 109696 != -79110)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (8726 - 487733 != -479007)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (170669 - 18092 != 152577)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (272615 - 233336 != 39280)
								{
									this.mChar.moveSpeed = num;
									if (212459 - 194648 == 17811)
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

	// Token: 0x060048E6 RID: 18662 RVA: 0x0090DD50 File Offset: 0x0090BF50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (291488 - 580341 != -288853)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (17160 - 42287 == -25127)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (135287 - 206686 != -71398)
				{
					Vector3 vector = a - this.transform.position;
					if (294956 - 16139 != 278818)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (89182 - 89701 != -518)
						{
							CharacterControl characterControl = null;
							if (268681 - 281322 != -12640)
							{
								int tID = 0;
								if (281027 - 135900 != 145128)
								{
									if (gameObject)
									{
										if (75001 - 500741 == -425739)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (206991 - 569519 == -362527)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (170376 - 114777 == 55600)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (78024 - 472107 == -394082)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (111444 - 435249 == -323804)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (9585 - 365654 == -356068)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (178359 - 596644 == -418285)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, tID));
										if (102257 - 204472 != -102214)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (51492 - 259263 != -207770)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
												if (214388 - 58508 == 155880)
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

	// Token: 0x060048E7 RID: 18663 RVA: 0x0090E04C File Offset: 0x0090C24C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (298736 - 529525 != -230789)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (213381 - 94053 != 119329)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (132877 - 245702 == -112825)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (44013 - 169530 != -125516)
					{
						Vector3 normalized = vector.normalized;
						if (192266 - 576796 == -384530)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (203396 - 302383 != -98986)
							{
								CharacterControl characterControl = null;
								if (140863 - 188293 == -47430)
								{
									int tID = 0;
									if (3640 - 515534 == -511894)
									{
										if (gameObject)
										{
											if (266300 - 134544 == 131757)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (187810 - 415914 == -228103)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (194448 - 62400 != 132048)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (239593 - 14325 == 225269)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (61840 - 209768 != -147928)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (143250 - 236886 != -93636)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (12640 - 367471 != -354830)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, tID));
											if (215581 - 578082 != -362500)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (134839 - 279817 != -144977)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, tID);
													if (64259 - 460387 == -396128)
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

	// Token: 0x060048E8 RID: 18664 RVA: 0x0090E370 File Offset: 0x0090C570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060048E9 RID: 18665 RVA: 0x0090E374 File Offset: 0x0090C574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LadyNoir.$RPC_nAttack$32486(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060048EA RID: 18666 RVA: 0x0090E384 File Offset: 0x0090C584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (202204 - 335174 != -132970)
		{
		}
		for (;;)
		{
			if (this.nAttack_fire)
			{
				if (224420 - 266813 != -42392)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos, Quaternion.FromToRotation(Vector3.forward, fireDir));
					if (20453 - 386438 == -365985)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (61037 - 309642 != -248604)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (259183 - 162472 != 96712)
							{
								projectileControl.life = 1.25f;
								if (125147 - 553720 != -428572)
								{
									gameObject.SendMessage("InitHoming", tID);
									if (126520 - 203500 != -76979)
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
				Debug.LogError("Missing nAttack_fire");
				if (264690 - 141440 == 123250)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060048EB RID: 18667 RVA: 0x0090E4F4 File Offset: 0x0090C6F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (44385 - 283664 != -239278)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (49032 - 29848 == 19184)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (65729 - 400923 != -335193)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit");
				if (74104 - 415031 != -340926)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060048EC RID: 18668 RVA: 0x0090E5B4 File Offset: 0x0090C7B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LadyNoir.$RPC_cAttack$32497(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060048ED RID: 18669 RVA: 0x0090E5C4 File Offset: 0x0090C7C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack0(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LadyNoir.$RPC_cAttack0$32515(mPos, this).GetEnumerator();
	}

	// Token: 0x060048EE RID: 18670 RVA: 0x0090E5D4 File Offset: 0x0090C7D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_demonGaze(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (46403 - 8265 != 38138)
		{
		}
		for (;;)
		{
			IL_4DC:
			if (tID == 0)
			{
				if (200405 - 161017 != 39389)
				{
					break;
				}
			}
			else
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[tID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (30120 - 402522 != -372401)
				{
					if (!gameObject)
					{
						if (254672 - 223968 != 30705)
						{
							break;
						}
					}
					else
					{
						this.mChar.actionTime = Time.time;
						if (201466 - 591730 != -390263)
						{
							this.mChar.addTimeOut("demonGaze", (float)13);
							if (43122 - 503212 == -460090)
							{
								if (PlayerPrefs.GetInt("pvoice", 1) != 0)
								{
									if (196769 - 525979 != -329210)
									{
										continue;
									}
									if (this.demonGaze_vc)
									{
										if (139497 - 354292 != -214795)
										{
											continue;
										}
										this.audio.PlayOneShot(this.demonGaze_vc);
										if (119945 - 219902 == -99956)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Missing demonGaze voice");
										if (22179 - 376334 != -354155)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (272850 - 346450 != -73599)
								{
									if (this.demonGaze_fx)
									{
										if (123075 - 95582 != 27493)
										{
											continue;
										}
										this.audio.PlayOneShot(this.demonGaze_fx);
										if (260436 - 311988 == -51551)
										{
											continue;
										}
									}
									int layerMask = 130816 - (1 << this.gameObject.layer);
									if (24739 - 84307 == -59568)
									{
										UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(gameObject.transform.position, (float)18, (float)9, layerMask);
										if (152910 - 276353 != -123442)
										{
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
											if (43522 - 285506 == -241984)
											{
												while (enumerator.MoveNext())
												{
													object obj4 = enumerator.Current;
													object obj6;
													object obj5 = obj6 = obj4;
													if (!(obj5 is GameObject))
													{
														obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
													}
													GameObject gameObject2 = (GameObject)obj6;
													if (222542 - 311024 == -88481)
													{
														goto IL_4DC;
													}
													if (this.mChar.isMine)
													{
														if (85288 - 480981 == -395692)
														{
															goto IL_4DC;
														}
														this.mChar.hit(31, gameObject2, this.mChar.talAdjust(60), 0, 0, Vector3.zero);
														if (146015 - 22257 != 123758)
														{
															goto IL_4DC;
														}
														UnityRuntimeServices.Update(enumerator, gameObject2);
														if (146683 - 478176 == -331492)
														{
															goto IL_4DC;
														}
													}
													if (this.demonGaze_hit)
													{
														if (172704 - 419323 == -246618)
														{
															goto IL_4DC;
														}
														UnityEngine.Object.Instantiate(this.demonGaze_hit, gameObject2.collider.bounds.center, Quaternion.identity);
														if (232439 - 400527 == -168087)
														{
															goto IL_4DC;
														}
														UnityRuntimeServices.Update(enumerator, gameObject2);
														if (210768 - 449235 == -238466)
														{
															goto IL_4DC;
														}
													}
													else
													{
														Debug.LogError("Missing demonGaze_hit Effect");
														if (3139 - 240914 == -237774)
														{
															goto IL_4DC;
														}
													}
													if (gameObject2 == Game.mPlayer)
													{
														if (276313 - 314731 != -38418)
														{
															goto IL_4DC;
														}
														CameraEffect cameraEffect = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
														if (56100 - 318900 != -262800)
														{
															goto IL_4DC;
														}
														cameraEffect.AddColorRamp("shadowRamp", "none", (float)10, new Vector4((float)0, 0.1f, 0.1f, (float)0));
														if (142949 - 405538 == -262588)
														{
															goto IL_4DC;
														}
													}
												}
												if (33654 - 433894 == -400240)
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

	// Token: 0x060048EF RID: 18671 RVA: 0x0090EAF0 File Offset: 0x0090CCF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_shame(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LadyNoir.$RPC_shame$32520(mPos, tID, this).GetEnumerator();
	}

	// Token: 0x060048F0 RID: 18672 RVA: 0x0090EB00 File Offset: 0x0090CD00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nefariousWhip(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LadyNoir.$RPC_nefariousWhip$32534(mPos, tID, this).GetEnumerator();
	}

	// Token: 0x060048F1 RID: 18673 RVA: 0x0090EB10 File Offset: 0x0090CD10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nefariousWhip_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new LadyNoir.$RPC_nefariousWhip_hit$32548(hitPos, hitID, this).GetEnumerator();
	}

	// Token: 0x060048F2 RID: 18674 RVA: 0x0090EB20 File Offset: 0x0090CD20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_darkIllusion(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LadyNoir.$RPC_darkIllusion$32563(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060048F3 RID: 18675 RVA: 0x0090EB30 File Offset: 0x0090CD30
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createLadyNoir(Vector3 nPos, Vector3 nDir)
	{
		if (241458 - 365142 != -123684)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (17510 - 363777 != -346266)
			{
				hashtable.Add(43, PlayerData.UID);
				if (201729 - 100089 != 101641)
				{
					hashtable.Add(73, "LadyNoir");
					if (186245 - 56206 != 130040)
					{
						hashtable.Add(75, PhotonClient.cInt16(8));
						if (232852 - 95812 == 137040)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (55122 - 267471 == -212349)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (257383 - 432163 != -174779)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (231896 - 29549 != 202348)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (142878 - 398333 == -255455)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (283788 - 545305 != -261516)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (270815 - 151665 == 119150)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (285117 - 488456 == -203339)
													{
														PhotonClient.Connection.OpCustom(63, hashtable, true);
														if (7853 - 342791 != -334937)
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

	// Token: 0x060048F4 RID: 18676 RVA: 0x0090EE10 File Offset: 0x0090D010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new LadyNoir.$RPC_ko$32577(nArray, this).GetEnumerator();
	}

	// Token: 0x060048F5 RID: 18677 RVA: 0x0090EE20 File Offset: 0x0090D020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new LadyNoir.$RPC_dead$32584(nArray, this).GetEnumerator();
	}

	// Token: 0x060048F6 RID: 18678 RVA: 0x0090EE30 File Offset: 0x0090D030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060048F7 RID: 18679 RVA: 0x0090EE34 File Offset: 0x0090D034
	internal static bool p0n8iM5vqHjkhkeTJlfP()
	{
		return true;
	}

	// Token: 0x060048F8 RID: 18680 RVA: 0x0090EE38 File Offset: 0x0090D038
	internal static bool WKobaS5v7QOAUOylshLc()
	{
		return false;
	}

	// Token: 0x040053B8 RID: 21432
	public CharacterControl mChar;

	// Token: 0x040053B9 RID: 21433
	public AudioClip wingFlap;

	// Token: 0x040053BA RID: 21434
	public AudioClip nAttack_vc;

	// Token: 0x040053BB RID: 21435
	public GameObject nAttack_fire;

	// Token: 0x040053BC RID: 21436
	public GameObject nAttack_hit;

	// Token: 0x040053BD RID: 21437
	public GameObject drainLife;

	// Token: 0x040053BE RID: 21438
	public GameObject drainLife_charge;

	// Token: 0x040053BF RID: 21439
	public AudioClip cAttack_vc;

	// Token: 0x040053C0 RID: 21440
	public GameObject demonGaze_hit;

	// Token: 0x040053C1 RID: 21441
	public AudioClip demonGaze_fx;

	// Token: 0x040053C2 RID: 21442
	public AudioClip demonGaze_vc;

	// Token: 0x040053C3 RID: 21443
	public GameObject castRing;

	// Token: 0x040053C4 RID: 21444
	public GameObject castEffect;

	// Token: 0x040053C5 RID: 21445
	public AudioClip nefariousWhip_vc;

	// Token: 0x040053C6 RID: 21446
	public GameObject nefariousWhip_hit;

	// Token: 0x040053C7 RID: 21447
	public AudioClip darkIllusion_vc;

	// Token: 0x040053C8 RID: 21448
	public AudioClip ko_vc;

	// Token: 0x040053C9 RID: 21449
	public AudioClip dead_vc;

	// Token: 0x02000CB0 RID: 3248
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32486 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060048F9 RID: 18681 RVA: 0x0090EE3C File Offset: 0x0090D03C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32486(Vector3 mPos, Vector3 tDir, int tID, LadyNoir self_)
		{
			if (184997 - 318084 != -133086)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70892 - 175431 == -104539)
				{
					base..ctor();
					if (86410 - 304612 != -218201)
					{
						this.$mPos$32493 = mPos;
						if (199680 - 18706 != 180975)
						{
							this.$tDir$32494 = tDir;
							if (128922 - 530470 != -401547)
							{
								this.$tID$32495 = tID;
								if (211954 - 464221 != -252266)
								{
									this.$self_$32496 = self_;
									if (103599 - 66313 == 37286)
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

		// Token: 0x060048FA RID: 18682 RVA: 0x0090EF3C File Offset: 0x0090D13C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LadyNoir.$RPC_nAttack$32486.$(this.$mPos$32493, this.$tDir$32494, this.$tID$32495, this.$self_$32496);
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x0090EF5C File Offset: 0x0090D15C
		internal static bool BSPtY35vPrDei2heHMXu()
		{
			return true;
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x0090EF60 File Offset: 0x0090D160
		internal static bool O5V6Jb5v0Ven4O7WMqh8()
		{
			return false;
		}

		// Token: 0x040053CA RID: 21450
		internal Vector3 $mPos$32493;

		// Token: 0x040053CB RID: 21451
		internal Vector3 $tDir$32494;

		// Token: 0x040053CC RID: 21452
		internal int $tID$32495;

		// Token: 0x040053CD RID: 21453
		internal LadyNoir $self_$32496;

		// Token: 0x02000CB1 RID: 3249
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060048FD RID: 18685 RVA: 0x0090EF64 File Offset: 0x0090D164
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, LadyNoir self_)
			{
				if (167656 - 490995 != -323338)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (170061 - 351931 != -181869)
					{
						base..ctor();
						if (161031 - 553327 == -392296)
						{
							this.$mPos$32489 = mPos;
							if (264879 - 87812 != 177068)
							{
								this.$tDir$32490 = tDir;
								if (233311 - 56422 != 176890)
								{
									this.$tID$32491 = tID;
									if (63008 - 186189 == -123181)
									{
										this.$self_$32492 = self_;
										if (85465 - 221075 == -135610)
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

			// Token: 0x060048FE RID: 18686 RVA: 0x0090F064 File Offset: 0x0090D264
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270572 - 485507 != -214935)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6AA;
					case 2:
						if (this.$self_$32492.mChar.actionState != "attack")
						{
							if (253592 - 390798 != -137206)
							{
								continue;
							}
							goto IL_224;
						}
						else
						{
							if (!this.$self_$32492.mChar.isMine)
							{
								goto IL_3E6;
							}
							if (146390 - 347752 == -201361)
							{
								continue;
							}
							this.$firePos$32487 = this.$mPos$32489 + this.$self_$32492.transform.TransformDirection(new Vector3((float)0, 1.3f, (float)1));
							if (49494 - 27096 != 22398)
							{
								continue;
							}
							this.$fireDir$32488 = this.$tDir$32490 - this.$self_$32492.transform.TransformDirection(new Vector3((float)0, 1.3f, (float)1));
							if (256028 - 44043 == 211986)
							{
								continue;
							}
							this.$self_$32492.RPC_nAttack_fire(this.$firePos$32487, this.$fireDir$32488, this.$tID$32491);
							if (41375 - 100010 == -58634)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_3E6;
							}
							if (283606 - 386381 == -102774)
							{
								continue;
							}
							this.$self_$32492.ActionEvent("RPC_nAttack_fire", this.$firePos$32487, this.$fireDir$32488, this.$tID$32491);
							if (271304 - 6411 != 264893)
							{
								continue;
							}
							goto IL_3E6;
						}
						break;
					case 3:
						if (this.$self_$32492.mChar.actionState == "attack")
						{
							if (87996 - 426607 == -338610)
							{
								continue;
							}
							if (this.$self_$32492.mChar.myCommand == "nAttack")
							{
								if (56479 - 458489 == -402009)
								{
									continue;
								}
								this.$self_$32492.mChar.actionState = "standby";
								if (197538 - 22209 == 175330)
								{
									continue;
								}
								this.$self_$32492.mChar.actionTime = Time.time;
								if (242830 - 526109 == -283278)
								{
									continue;
								}
								this.$self_$32492.mChar.myCommand = "none";
								if (131984 - 15161 == 116824)
								{
									continue;
								}
								if (!this.$self_$32492.mChar.isMine)
								{
									if (73083 - 182082 == -108998)
									{
										continue;
									}
									this.$self_$32492.mChar.nPosition = this.$self_$32492.transform.position;
									if (233797 - 44913 != 188884)
									{
										continue;
									}
									this.$self_$32492.mChar.oPosition = this.$self_$32492.transform.position;
									if (40041 - 552900 != -512859)
									{
										continue;
									}
									this.$self_$32492.mChar.nDirection = this.$self_$32492.transform.forward;
									if (140898 - 8479 != 132419)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (211182 - 44742 != 166440)
						{
							continue;
						}
						goto IL_6AA;
					default:
						if (84930 - 422748 == -337817)
						{
							continue;
						}
						break;
					}
					this.$self_$32492.mChar.actionState = "attack";
					if (75056 - 455387 != -380330)
					{
						this.$self_$32492.mChar.actionTime = Time.time;
						if (200681 - 322274 == -121593)
						{
							this.$self_$32492.mChar.myCommand = "nAttack";
							if (277597 - 440980 != -163382)
							{
								this.$self_$32492.mChar.addTimeOut("nAttack", (float)3);
								if (175687 - 243973 != -68285)
								{
									this.$self_$32492.transform.position = this.$mPos$32489;
									if (29695 - 489058 == -459363)
									{
										this.$self_$32492.transform.LookAt(this.$mPos$32489 + global::Math.vFlat(this.$tDir$32490));
										if (142604 - 506684 != -364079)
										{
											this.$self_$32492.animation.Play("nAttack");
											if (43052 - 521148 != -478095)
											{
												this.$self_$32492.animation.wrapMode = WrapMode.Once;
												if (134912 - 413465 != -278552)
												{
													this.$self_$32492.mChar.vMovement = Vector3.zero;
													if (96713 - 77147 == 19566)
													{
														this.$self_$32492.mChar.moveSpeed = (float)0;
														if (76320 - 97954 == -21634)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_65B;
															}
															if (43201 - 239493 != -196291)
															{
																if (this.$self_$32492.nAttack_vc)
																{
																	if (30810 - 500540 != -469729)
																	{
																		this.$self_$32492.audio.PlayOneShot(this.$self_$32492.nAttack_vc);
																		if (119225 - 102960 == 16265)
																		{
																			goto IL_359;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find nAttack voice");
																	if (122328 - 538808 != -416479)
																	{
																		goto Block_21;
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
				IL_224:
				goto IL_6AA;
				IL_359:
				Block_21:
				goto IL_65B;
				IL_3E6:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_65B:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_6AA:
				return false;
			}

			// Token: 0x060048FF RID: 18687 RVA: 0x0090F730 File Offset: 0x0090D930
			internal static bool aU2QZD5vbmghyPBIQSPL()
			{
				return true;
			}

			// Token: 0x06004900 RID: 18688 RVA: 0x0090F734 File Offset: 0x0090D934
			internal static bool xVNsq45vuF9MYTAdjXmp()
			{
				return false;
			}

			// Token: 0x040053CE RID: 21454
			internal Vector3 $firePos$32487;

			// Token: 0x040053CF RID: 21455
			internal Vector3 $fireDir$32488;

			// Token: 0x040053D0 RID: 21456
			internal Vector3 $mPos$32489;

			// Token: 0x040053D1 RID: 21457
			internal Vector3 $tDir$32490;

			// Token: 0x040053D2 RID: 21458
			internal int $tID$32491;

			// Token: 0x040053D3 RID: 21459
			internal LadyNoir $self_$32492;
		}
	}

	// Token: 0x02000CB2 RID: 3250
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$32497 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004901 RID: 18689 RVA: 0x0090F738 File Offset: 0x0090D938
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$32497(Vector3 mPos, Vector3 tDir, int tID, LadyNoir self_)
		{
			if (176830 - 506058 != -329227)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (104551 - 537180 != -432628)
				{
					base..ctor();
					if (61295 - 488352 != -427056)
					{
						this.$mPos$32511 = mPos;
						if (102708 - 46679 == 56029)
						{
							this.$tDir$32512 = tDir;
							if (63559 - 169803 != -106243)
							{
								this.$tID$32513 = tID;
								if (122415 - 434440 != -312024)
								{
									this.$self_$32514 = self_;
									if (8544 - 521836 != -513291)
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

		// Token: 0x06004902 RID: 18690 RVA: 0x0090F838 File Offset: 0x0090DA38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LadyNoir.$RPC_cAttack$32497.$(this.$mPos$32511, this.$tDir$32512, this.$tID$32513, this.$self_$32514);
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x0090F858 File Offset: 0x0090DA58
		internal static bool Qp7Dl45vIB7WJ4Id9Gs8()
		{
			return true;
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x0090F85C File Offset: 0x0090DA5C
		internal static bool wSDZyf5vBEGCnP1cZynQ()
		{
			return false;
		}

		// Token: 0x040053D4 RID: 21460
		internal Vector3 $mPos$32511;

		// Token: 0x040053D5 RID: 21461
		internal Vector3 $tDir$32512;

		// Token: 0x040053D6 RID: 21462
		internal int $tID$32513;

		// Token: 0x040053D7 RID: 21463
		internal LadyNoir $self_$32514;

		// Token: 0x02000CB3 RID: 3251
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004905 RID: 18693 RVA: 0x0090F860 File Offset: 0x0090DA60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, LadyNoir self_)
			{
				if (26598 - 418031 != -391432)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286383 - 280937 != 5447)
					{
						base..ctor();
						if (243322 - 113689 != 129634)
						{
							this.$mPos$32507 = mPos;
							if (51809 - 578897 == -527088)
							{
								this.$tDir$32508 = tDir;
								if (242397 - 179879 == 62518)
								{
									this.$tID$32509 = tID;
									if (202956 - 390339 != -187382)
									{
										this.$self_$32510 = self_;
										if (119861 - 169922 != -50060)
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

			// Token: 0x06004906 RID: 18694 RVA: 0x0090F960 File Offset: 0x0090DB60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (296077 - 112790 != 183288)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_EA0;
					case 1:
						goto IL_F26;
					case 2:
						if (this.$self_$32510.mChar.actionState != "attack")
						{
							if (8142 - 219958 == -211815)
							{
								continue;
							}
							if (this.$self_$32510.mChar.myCommand != "cAttack1")
							{
								if (58861 - 384132 != -325270)
								{
									goto Block_21;
								}
								continue;
							}
						}
						this.$self_$32510.mChar.moveSpeed = -0.5f;
						if (105576 - 437866 != -332289)
						{
							goto Block_83;
						}
						continue;
					case 3:
						if (this.$self_$32510.mChar.actionState != "attack")
						{
							if (144240 - 367065 == -222824)
							{
								continue;
							}
							if (this.$self_$32510.mChar.myCommand != "cAttack1")
							{
								if (43371 - 566692 != -523321)
								{
									continue;
								}
								goto IL_22D;
							}
						}
						this.$self_$32510.mChar.moveSpeed = (float)0;
						if (250177 - 535638 != -285461)
						{
							continue;
						}
						this.$mDrainlife_charge$32501 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$32510.drainLife_charge, this.$self_$32510.transform.position + 1.2f * Vector3.up, Quaternion.identity);
						if (70106 - 36446 == 33661)
						{
							continue;
						}
						this.$mEffectControl$32502 = (EffectControl)this.$mDrainlife_charge$32501.GetComponent(typeof(EffectControl));
						if (169130 - 140657 != 28473)
						{
							continue;
						}
						this.$mEffectControl$32502.InitEffectControl(this.$self_$32510.gameObject);
						if (269954 - 560932 != -290977)
						{
							goto Block_72;
						}
						continue;
					case 4:
						if (this.$self_$32510.mChar.actionState != "attack")
						{
							if (129083 - 252408 != -123325)
							{
								continue;
							}
							if (this.$self_$32510.mChar.myCommand != "cAttack1")
							{
								if (52577 - 273451 != -220873)
								{
									goto Block_47;
								}
								continue;
							}
						}
						this.$self_$32510.animation.Play("cAttack2");
						if (40256 - 529474 != -489218)
						{
							continue;
						}
						this.$self_$32510.animation.wrapMode = WrapMode.Loop;
						if (137239 - 314835 != -177596)
						{
							continue;
						}
						this.$mDrainLife$32503 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$32510.drainLife, this.$self_$32510.transform.position + this.$self_$32510.transform.TransformDirection((float)0, 0.82f, 0.88f), Quaternion.identity);
						if (101614 - 451793 == -350178)
						{
							continue;
						}
						this.$mDrainLife_BoltEmitter$32504 = (BoltEmitter)this.$mDrainLife$32503.GetComponent(typeof(BoltEmitter));
						if (79157 - 386933 != -307776)
						{
							continue;
						}
						this.$drainLifeTimer$32505 = Time.time + (float)1;
						if (297255 - 524646 == -227390)
						{
							continue;
						}
						this.$drainDamage$32506 = Mathf.Clamp(Mathf.CeilToInt(0.3f * (float)this.$self_$32510.mChar.atk), 9, 36);
						if (135069 - 478444 != -343375)
						{
							continue;
						}
						break;
					case 5:
						break;
					default:
						if (50645 - 560374 != -509728)
						{
							goto IL_EA0;
						}
						continue;
					}
					if (this.$self_$32510.mChar.actionState == "attack")
					{
						if (274062 - 161979 != 112083)
						{
							continue;
						}
						if (!(this.$self_$32510.mChar.myCommand == "cAttack1"))
						{
							if (203245 - 399666 == -196420)
							{
								continue;
							}
						}
						else
						{
							if (this.$tObject$32498)
							{
								if (128465 - 28165 != 100300)
								{
									continue;
								}
								if (Time.time > this.$self_$32510.mChar.actionTime + (float)13)
								{
									if (4346 - 340152 != -335806)
									{
										continue;
									}
								}
								else
								{
									this.$tPos$32500 = this.$tObject$32498.transform.position;
									if (2611 - 133119 == -130507)
									{
										continue;
									}
									this.$tPos$32500.y = this.$self_$32510.transform.position.y;
									if (103783 - 321476 == -217692)
									{
										continue;
									}
									this.$self_$32510.transform.LookAt(this.$tPos$32500);
									if (144161 - 218508 != -74347)
									{
										continue;
									}
									this.$mDrainLife$32503.transform.position = this.$self_$32510.transform.position + this.$self_$32510.transform.TransformDirection(0.1f, 1.25f, 0.65f);
									if (130909 - 117185 != 13724)
									{
										continue;
									}
									this.$mDrainLife_BoltEmitter$32504.TargetPosition = this.$tObject$32498.collider.bounds.center;
									if (79336 - 304134 != -224798)
									{
										continue;
									}
									if (!this.$self_$32510.mChar.isMine)
									{
										goto IL_37B;
									}
									if (65741 - 527849 == -462107)
									{
										continue;
									}
									Vector3 vector = this.$self_$32510.transform.position - this.$tPos$32500;
									if (64642 - 463886 == -399243)
									{
										continue;
									}
									if (vector.sqrMagnitude > (float)324)
									{
										if (60519 - 183741 != -123222)
										{
											continue;
										}
										this.$self_$32510.StartCoroutine_Auto(this.$self_$32510.RPC_cAttack0(this.$self_$32510.transform.position, this.$tDir$32508, 0));
										if (106427 - 178188 != -71761)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (102805 - 317765 == -214959)
											{
												continue;
											}
											this.$self_$32510.ActionEvent("RPC_cAttack0", this.$self_$32510.transform.position, this.$tDir$32508, 0);
											if (190060 - 86805 != 103255)
											{
												continue;
											}
										}
									}
									if (this.$drainLifeTimer$32505 >= Time.time)
									{
										goto IL_37B;
									}
									if (116386 - 435952 == -319565)
									{
										continue;
									}
									this.$drainLifeTimer$32505 = Time.time + (float)1;
									if (276183 - 36671 != 239512)
									{
										continue;
									}
									if (this.$tChar$32499.hp > 0)
									{
										if (156877 - 13169 != 143708)
										{
											continue;
										}
										this.$tChar$32499.RPC_AddDamage(11, this.$drainDamage$32506, 0, 2, Vector3.zero, this.$self_$32510.mChar.ActorNr);
										if (284371 - 313772 == -29400)
										{
											continue;
										}
										this.$self_$32510.mChar.RPC_AddHeal(11, this.$drainDamage$32506, 0, 0, 0, 0, this.$self_$32510.mChar.ActorNr);
										if (77191 - 594476 != -517284)
										{
											goto Block_84;
										}
										continue;
									}
									else
									{
										this.$self_$32510.StartCoroutine_Auto(this.$self_$32510.RPC_cAttack0(this.$self_$32510.transform.position, this.$tDir$32508, 0));
										if (137340 - 454318 == -316977)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											goto IL_37B;
										}
										if (134747 - 349792 == -215044)
										{
											continue;
										}
										this.$self_$32510.ActionEvent("RPC_cAttack0", this.$self_$32510.transform.position, this.$tDir$32508, 0);
										if (109121 - 483966 != -374845)
										{
											continue;
										}
										goto IL_37B;
									}
								}
							}
							if (!this.$self_$32510.mChar.isMine)
							{
								goto IL_3C0;
							}
							if (298048 - 205780 != 92268)
							{
								continue;
							}
							this.$self_$32510.StartCoroutine_Auto(this.$self_$32510.RPC_cAttack0(this.$self_$32510.transform.position, this.$tDir$32508, 0));
							if (184151 - 484804 != -300653)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_3C0;
							}
							if (211337 - 31311 != 180026)
							{
								continue;
							}
							this.$self_$32510.ActionEvent("RPC_cAttack0", this.$self_$32510.transform.position, this.$tDir$32508, 0);
							if (152742 - 329261 != -176518)
							{
								goto Block_29;
							}
							continue;
						}
					}
					if (this.$mDrainLife$32503)
					{
						if (115206 - 417997 == -302790)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$mDrainLife$32503);
						if (222473 - 391643 == -169169)
						{
							continue;
						}
					}
					if (this.$mDrainlife_charge$32501)
					{
						if (223729 - 458731 != -235002)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$mDrainlife_charge$32501);
						if (279253 - 10214 != 269039)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (178426 - 95174 != 83253)
					{
						break;
					}
					continue;
					IL_EA0:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$32509];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$32498 = (GameObject)obj2;
					if (147141 - 550737 != -403595)
					{
						if (!this.$tObject$32498)
						{
							if (132984 - 264069 == -131085)
							{
								break;
							}
						}
						else
						{
							this.$tChar$32499 = (CharacterControl)this.$tObject$32498.GetComponent(typeof(CharacterControl));
							if (173268 - 124702 != 48567)
							{
								if (!this.$tChar$32499)
								{
									if (128479 - 97973 != 30507)
									{
										break;
									}
								}
								else
								{
									this.$tPos$32500 = this.$tObject$32498.transform.position;
									if (293035 - 304573 == -11538)
									{
										this.$tPos$32500.y = this.$mPos$32507.y;
										if (213222 - 136063 == 77159)
										{
											this.$self_$32510.transform.position = this.$mPos$32507;
											if (47281 - 12791 != 34491)
											{
												this.$self_$32510.transform.LookAt(this.$tPos$32500);
												if (230070 - 99199 != 130872)
												{
													this.$self_$32510.mChar.actionState = "attack";
													if (102511 - 37216 == 65295)
													{
														this.$self_$32510.mChar.actionTime = Time.time;
														if (74267 - 433641 == -359374)
														{
															this.$self_$32510.mChar.myCommand = "cAttack1";
															if (161549 - 169460 == -7911)
															{
																this.$self_$32510.mChar.vMovement = this.$self_$32510.transform.forward;
																if (235932 - 358071 == -122139)
																{
																	this.$self_$32510.mChar.moveSpeed = (float)0;
																	if (117250 - 31119 == 86131)
																	{
																		this.$self_$32510.mChar.addTimeOut("cAttack", (float)15);
																		if (19600 - 60481 == -40881)
																		{
																			this.$self_$32510.animation.Play("cAttack1");
																			if (15796 - 494420 != -478623)
																			{
																				this.$self_$32510.animation.wrapMode = WrapMode.Once;
																				if (254304 - 8354 == 245950)
																				{
																					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																					{
																						goto IL_970;
																					}
																					if (173773 - 152701 != 21073)
																					{
																						if (this.$self_$32510.cAttack_vc)
																						{
																							if (210021 - 255469 == -45448)
																							{
																								this.$self_$32510.audio.PlayOneShot(this.$self_$32510.cAttack_vc);
																								if (33876 - 41318 != -7441)
																								{
																									goto Block_81;
																								}
																							}
																						}
																						else
																						{
																							Debug.LogError("Cannot find cAttack voice");
																							if (99764 - 31779 != 67986)
																							{
																								goto Block_59;
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
				IL_22D:
				Block_21:
				goto IL_F26;
				IL_37B:
				return this.YieldDefault(5);
				IL_3C0:
				goto IL_37B;
				Block_29:
				goto IL_3C0;
				Block_47:
				goto IL_F26;
				Block_59:
				IL_970:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_72:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_81:
				goto IL_970;
				Block_83:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_84:
				goto IL_37B;
				IL_F26:
				return false;
			}

			// Token: 0x06004907 RID: 18695 RVA: 0x009108A8 File Offset: 0x0090EAA8
			internal static bool f2otSo5veKRrQCAypHUA()
			{
				return true;
			}

			// Token: 0x06004908 RID: 18696 RVA: 0x009108AC File Offset: 0x0090EAAC
			internal static bool HbDTSX5vrWZm6bFnnmBB()
			{
				return false;
			}

			// Token: 0x040053D8 RID: 21464
			internal GameObject $tObject$32498;

			// Token: 0x040053D9 RID: 21465
			internal CharacterControl $tChar$32499;

			// Token: 0x040053DA RID: 21466
			internal Vector3 $tPos$32500;

			// Token: 0x040053DB RID: 21467
			internal GameObject $mDrainlife_charge$32501;

			// Token: 0x040053DC RID: 21468
			internal EffectControl $mEffectControl$32502;

			// Token: 0x040053DD RID: 21469
			internal GameObject $mDrainLife$32503;

			// Token: 0x040053DE RID: 21470
			internal BoltEmitter $mDrainLife_BoltEmitter$32504;

			// Token: 0x040053DF RID: 21471
			internal float $drainLifeTimer$32505;

			// Token: 0x040053E0 RID: 21472
			internal int $drainDamage$32506;

			// Token: 0x040053E1 RID: 21473
			internal Vector3 $mPos$32507;

			// Token: 0x040053E2 RID: 21474
			internal Vector3 $tDir$32508;

			// Token: 0x040053E3 RID: 21475
			internal int $tID$32509;

			// Token: 0x040053E4 RID: 21476
			internal LadyNoir $self_$32510;
		}
	}

	// Token: 0x02000CB4 RID: 3252
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack0$32515 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004909 RID: 18697 RVA: 0x009108B0 File Offset: 0x0090EAB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack0$32515(Vector3 mPos, LadyNoir self_)
		{
			if (113757 - 246251 != -132494)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (196181 - 194148 != 2034)
				{
					base..ctor();
					if (194920 - 163485 == 31435)
					{
						this.$mPos$32518 = mPos;
						if (245048 - 521803 == -276755)
						{
							this.$self_$32519 = self_;
							if (52951 - 77967 == -25016)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x0091096C File Offset: 0x0090EB6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LadyNoir.$RPC_cAttack0$32515.$(this.$mPos$32518, this.$self_$32519);
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x00910980 File Offset: 0x0090EB80
		internal static bool fI1Kj15vj485QgOaem67()
		{
			return true;
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x00910984 File Offset: 0x0090EB84
		internal static bool GkF9Lg5vh0RuYcoVkviQ()
		{
			return false;
		}

		// Token: 0x040053E5 RID: 21477
		internal Vector3 $mPos$32518;

		// Token: 0x040053E6 RID: 21478
		internal LadyNoir $self_$32519;

		// Token: 0x02000CB5 RID: 3253
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600490D RID: 18701 RVA: 0x00910988 File Offset: 0x0090EB88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, LadyNoir self_)
			{
				if (83409 - 348734 != -265324)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (90841 - 231964 == -141123)
					{
						base..ctor();
						if (196932 - 454104 == -257172)
						{
							this.$mPos$32516 = mPos;
							if (263130 - 102485 != 160646)
							{
								this.$self_$32517 = self_;
								if (62868 - 356297 == -293429)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600490E RID: 18702 RVA: 0x00910A44 File Offset: 0x0090EC44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (78833 - 258973 != -180140)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_273;
					case 2:
						if (this.$self_$32517.mChar.actionState == "attack")
						{
							if (27538 - 312896 != -285358)
							{
								continue;
							}
							if (this.$self_$32517.mChar.myCommand == "cAttack0")
							{
								if (46377 - 486971 == -440593)
								{
									continue;
								}
								this.$self_$32517.mChar.actionState = "standby";
								if (187095 - 83551 == 103545)
								{
									continue;
								}
								this.$self_$32517.mChar.actionTime = Time.time;
								if (166319 - 109382 != 56937)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (136092 - 337591 != -201498)
						{
							goto Block_14;
						}
						continue;
					default:
						if (290254 - 374998 != -84744)
						{
							continue;
						}
						break;
					}
					this.$self_$32517.mChar.actionState = "attack";
					if (98162 - 515737 != -417574)
					{
						this.$self_$32517.mChar.actionTime = Time.time;
						if (99814 - 57253 == 42561)
						{
							this.$self_$32517.mChar.myCommand = "cAttack0";
							if (171405 - 377469 == -206064)
							{
								this.$self_$32517.mChar.vMovement = Vector3.zero;
								if (46246 - 347145 == -300899)
								{
									this.$self_$32517.transform.position = this.$mPos$32516;
									if (106598 - 473919 != -367320)
									{
										this.$self_$32517.animation.CrossFade("root", 0.35f);
										if (58394 - 518953 == -460559)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.35f));
				Block_14:
				IL_273:
				return false;
			}

			// Token: 0x0600490F RID: 18703 RVA: 0x00910CD8 File Offset: 0x0090EED8
			internal static bool Psf9Cc5vs1pSZ7oeClNw()
			{
				return true;
			}

			// Token: 0x06004910 RID: 18704 RVA: 0x00910CDC File Offset: 0x0090EEDC
			internal static bool YBrocM5v9GQySOsyp22W()
			{
				return false;
			}

			// Token: 0x040053E7 RID: 21479
			internal Vector3 $mPos$32516;

			// Token: 0x040053E8 RID: 21480
			internal LadyNoir $self_$32517;
		}
	}

	// Token: 0x02000CB6 RID: 3254
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_shame$32520 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004911 RID: 18705 RVA: 0x00910CE0 File Offset: 0x0090EEE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_shame$32520(Vector3 mPos, int tID, LadyNoir self_)
		{
			if (71924 - 318137 != -246213)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (267905 - 509419 == -241514)
				{
					base..ctor();
					if (130367 - 255136 == -124769)
					{
						this.$mPos$32531 = mPos;
						if (269832 - 264674 != 5159)
						{
							this.$tID$32532 = tID;
							if (76883 - 395491 == -318608)
							{
								this.$self_$32533 = self_;
								if (112057 - 460396 == -348339)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00910DBC File Offset: 0x0090EFBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LadyNoir.$RPC_shame$32520.$(this.$mPos$32531, this.$tID$32532, this.$self_$32533);
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00910DD8 File Offset: 0x0090EFD8
		internal static bool Uw0oUw5v1LDGgBue0SgL()
		{
			return true;
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00910DDC File Offset: 0x0090EFDC
		internal static bool jyQHJA5v4eRmFZV6qGRB()
		{
			return false;
		}

		// Token: 0x040053E9 RID: 21481
		internal Vector3 $mPos$32531;

		// Token: 0x040053EA RID: 21482
		internal int $tID$32532;

		// Token: 0x040053EB RID: 21483
		internal LadyNoir $self_$32533;

		// Token: 0x02000CB7 RID: 3255
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004915 RID: 18709 RVA: 0x00910DE0 File Offset: 0x0090EFE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, int tID, LadyNoir self_)
			{
				if (101265 - 228168 != -126903)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (295191 - 533426 == -238235)
					{
						base..ctor();
						if (231662 - 44585 != 187078)
						{
							this.$mPos$32528 = mPos;
							if (122682 - 501803 != -379120)
							{
								this.$tID$32529 = tID;
								if (52276 - 467038 == -414762)
								{
									this.$self_$32530 = self_;
									if (136465 - 316468 == -180003)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004916 RID: 18710 RVA: 0x00910EBC File Offset: 0x0090F0BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (69727 - 296090 != -226363)
				{
				}
				for (;;)
				{
					IL_A2F:
					switch (this._state)
					{
					case 0:
						goto IL_2F0;
					case 1:
						goto IL_ACB;
					case 2:
						if (this.$self_$32530.castRing)
						{
							if (254065 - 151578 == 102488)
							{
								continue;
							}
							this.$self_$32530.mChar.createEffect(this.$self_$32530.castRing, this.$self_$32530.transform.position, Quaternion.Euler((float)270, (float)90, (float)0));
							if (211968 - 18099 == 193870)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$32530.mChar.actionState != "attack")
						{
							goto IL_1EE;
						}
						if (194306 - 182403 != 11903)
						{
							continue;
						}
						if (this.$self_$32530.mChar.myCommand != "shame")
						{
							if (39324 - 569791 != -530467)
							{
								continue;
							}
							goto IL_1EE;
						}
						break;
					case 4:
						if (this.$self_$32530.mChar.actionState != "attack")
						{
							goto IL_410;
						}
						if (152612 - 342667 != -190055)
						{
							continue;
						}
						if (this.$self_$32530.mChar.myCommand != "shame")
						{
							if (207399 - 536016 != -328617)
							{
								continue;
							}
							goto IL_410;
						}
						else
						{
							this.$self_$32530.mChar.moveSpeed = (float)0;
							if (236697 - 377034 != -140337)
							{
								continue;
							}
							if (!this.$tObject$32521)
							{
								goto IL_9A7;
							}
							if (141222 - 252147 != -110925)
							{
								continue;
							}
							if (!this.$self_$32530.mChar.isMine)
							{
								goto IL_9A7;
							}
							if (120046 - 28653 == 91394)
							{
								continue;
							}
							this.$hitLayer$32523 = 130816 - (1 << this.$self_$32530.gameObject.layer);
							if (51589 - 483748 != -432159)
							{
								continue;
							}
							this.$hitList$32524 = Damage.FindAreaTarget(this.$tObject$32521.transform.position, (float)18, (float)9, this.$hitLayer$32523);
							if (172203 - 338705 == -166501)
							{
								continue;
							}
							this.$$iterator$10763$32527 = UnityRuntimeServices.GetEnumerator(this.$hitList$32524);
							if (193330 - 386106 == -192775)
							{
								continue;
							}
							while (this.$$iterator$10763$32527.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10763$32527.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32525 = (GameObject)obj2;
								if (174214 - 592690 == -418475)
								{
									goto IL_A2F;
								}
								this.$tChar$32526 = (CharacterControl)this.$hitObject$32525.GetComponent(typeof(CharacterControl));
								if (146694 - 386756 != -240062)
								{
									goto IL_A2F;
								}
								UnityRuntimeServices.Update(this.$$iterator$10763$32527, this.$hitObject$32525);
								if (10162 - 61308 == -51145)
								{
									goto IL_A2F;
								}
								if (this.$tChar$32526)
								{
									if (162169 - 516716 != -354547)
									{
										goto IL_A2F;
									}
									this.$tChar$32526.RPC_AddStatus("shame", 5, Damage.getDebuff((float)15, this.$self_$32530.mChar.cha, this.$tChar$32526.cha), 0, this.$self_$32530.mChar.ActorNr);
									if (169671 - 22068 != 147603)
									{
										goto IL_A2F;
									}
								}
							}
							if (71857 - 542056 != -470198)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$32530.mChar.actionState != "attack")
						{
							goto IL_2BC;
						}
						if (83898 - 578559 != -494661)
						{
							continue;
						}
						if (this.$self_$32530.mChar.myCommand != "shame")
						{
							if (241103 - 122436 != 118668)
							{
								goto Block_64;
							}
							continue;
						}
						else
						{
							this.$self_$32530.mChar.actionState = "standby";
							if (255420 - 590165 == -334744)
							{
								continue;
							}
							this.$self_$32530.mChar.actionTime = Time.time;
							if (28262 - 249812 == -221549)
							{
								continue;
							}
							this.$self_$32530.mChar.myCommand = "none";
							if (211099 - 217985 != -6886)
							{
								continue;
							}
							this.$self_$32530.mChar.nPosition = this.$self_$32530.transform.position;
							if (123104 - 467825 != -344721)
							{
								continue;
							}
							this.YieldDefault(1);
							if (251995 - 520213 != -268218)
							{
								continue;
							}
							goto IL_ACB;
						}
						break;
					default:
						if (292627 - 456786 != -164158)
						{
							goto IL_2F0;
						}
						continue;
					}
					if (Time.time >= this.$self_$32530.mChar.actionTime + 2f)
					{
						if (293762 - 408805 == -115042)
						{
							continue;
						}
						this.$self_$32530.mChar.vMovement = this.$self_$32530.transform.forward;
						if (194487 - 122880 != 71607)
						{
							continue;
						}
						this.$self_$32530.mChar.moveSpeed = -0.5f;
						if (159789 - 374546 != -214757)
						{
							continue;
						}
						if (!this.$self_$32530.castEffect)
						{
							goto IL_15E;
						}
						if (8178 - 219017 != -210839)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$32530.castEffect, this.$self_$32530.transform.position + this.$self_$32530.transform.TransformDirection((float)0, 1.3f, (float)1), this.$self_$32530.transform.rotation);
						if (189652 - 271364 != -81712)
						{
							continue;
						}
						goto IL_15E;
					}
					else
					{
						if (!this.$tObject$32521)
						{
							break;
						}
						if (242428 - 269888 == -27459)
						{
							continue;
						}
						if (!(this.$tObject$32521 != this.$self_$32530.gameObject))
						{
							break;
						}
						if (75076 - 272704 != -197628)
						{
							continue;
						}
						this.$tPos$32522 = global::Math.vFlat(this.$tObject$32521.transform.position) + Vector3.up * this.$self_$32530.transform.position.y;
						if (85653 - 337226 == -251572)
						{
							continue;
						}
						this.$self_$32530.transform.LookAt(this.$tPos$32522);
						if (219627 - 176045 != 43583)
						{
							break;
						}
						continue;
					}
					IL_2F0:
					object obj4;
					object obj3 = obj4 = PhotonClient.ActorNrList[this.$tID$32529];
					if (!(obj3 is GameObject))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
					}
					this.$tObject$32521 = (GameObject)obj4;
					if (5895 - 192023 != -186127)
					{
						this.$tPos$32522 = this.$tObject$32521.transform.position;
						if (95165 - 252562 == -157397)
						{
							this.$tPos$32522.y = this.$mPos$32528.y;
							if (258049 - 88516 != 169534)
							{
								this.$self_$32530.transform.position = this.$mPos$32528;
								if (105228 - 57179 != 48050)
								{
									this.$self_$32530.transform.LookAt(this.$tPos$32522);
									if (260718 - 510973 != -250254)
									{
										this.$self_$32530.animation.CrossFade("cast", 0.2f);
										if (270002 - 560639 == -290637)
										{
											this.$self_$32530.animation.wrapMode = WrapMode.Once;
											if (59380 - 533419 != -474038)
											{
												this.$self_$32530.mChar.actionState = "attack";
												if (86531 - 86789 == -258)
												{
													this.$self_$32530.mChar.actionTime = Time.time;
													if (144250 - 324320 != -180069)
													{
														this.$self_$32530.mChar.myCommand = "shame";
														if (168352 - 125541 == 42811)
														{
															this.$self_$32530.mChar.vMovement = this.$self_$32530.transform.forward;
															if (179143 - 222615 == -43472)
															{
																this.$self_$32530.mChar.moveSpeed = (float)0;
																if (23320 - 282643 == -259323)
																{
																	this.$self_$32530.mChar.addTimeOut("shame", (float)30);
																	if (222531 - 369948 == -147417)
																	{
																		goto IL_5AE;
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
				IL_AA:
				return this.YieldDefault(3);
				IL_15E:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_1EE:
				IL_2BC:
				IL_410:
				goto IL_ACB;
				Block_30:
				goto IL_9A7;
				IL_5AE:
				return this.Yield(2, new WaitForSeconds(0.2f));
				goto IL_AA;
				IL_9A7:
				return this.Yield(5, new WaitForSeconds(0.4f));
				Block_64:
				IL_ACB:
				return false;
			}

			// Token: 0x06004917 RID: 18711 RVA: 0x009119A8 File Offset: 0x0090FBA8
			internal static bool Fn2MYR5vz7h9AkUbLNGu()
			{
				return true;
			}

			// Token: 0x06004918 RID: 18712 RVA: 0x009119AC File Offset: 0x0090FBAC
			internal static bool dsRLfD5RakNg3yMOgqKe()
			{
				return false;
			}

			// Token: 0x040053EC RID: 21484
			internal GameObject $tObject$32521;

			// Token: 0x040053ED RID: 21485
			internal Vector3 $tPos$32522;

			// Token: 0x040053EE RID: 21486
			internal int $hitLayer$32523;

			// Token: 0x040053EF RID: 21487
			internal UnityScript.Lang.Array $hitList$32524;

			// Token: 0x040053F0 RID: 21488
			internal GameObject $hitObject$32525;

			// Token: 0x040053F1 RID: 21489
			internal CharacterControl $tChar$32526;

			// Token: 0x040053F2 RID: 21490
			internal IEnumerator $$iterator$10763$32527;

			// Token: 0x040053F3 RID: 21491
			internal Vector3 $mPos$32528;

			// Token: 0x040053F4 RID: 21492
			internal int $tID$32529;

			// Token: 0x040053F5 RID: 21493
			internal LadyNoir $self_$32530;
		}
	}

	// Token: 0x02000CB8 RID: 3256
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nefariousWhip$32534 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004919 RID: 18713 RVA: 0x009119B0 File Offset: 0x0090FBB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nefariousWhip$32534(Vector3 mPos, int tID, LadyNoir self_)
		{
			if (11269 - 67937 != -56668)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (273238 - 33361 != 239878)
				{
					base..ctor();
					if (255609 - 293610 == -38001)
					{
						this.$mPos$32545 = mPos;
						if (33943 - 119578 == -85635)
						{
							this.$tID$32546 = tID;
							if (71248 - 358870 != -287621)
							{
								this.$self_$32547 = self_;
								if (46330 - 283654 == -237324)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x00911A8C File Offset: 0x0090FC8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LadyNoir.$RPC_nefariousWhip$32534.$(this.$mPos$32545, this.$tID$32546, this.$self_$32547);
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x00911AA8 File Offset: 0x0090FCA8
		internal static bool c0OYNS5R5EdYV2MuhZlj()
		{
			return true;
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x00911AAC File Offset: 0x0090FCAC
		internal static bool EsPjmQ5RpfGhqBGfsBwE()
		{
			return false;
		}

		// Token: 0x040053F6 RID: 21494
		internal Vector3 $mPos$32545;

		// Token: 0x040053F7 RID: 21495
		internal int $tID$32546;

		// Token: 0x040053F8 RID: 21496
		internal LadyNoir $self_$32547;

		// Token: 0x02000CB9 RID: 3257
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600491D RID: 18717 RVA: 0x00911AB0 File Offset: 0x0090FCB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, int tID, LadyNoir self_)
			{
				if (148218 - 269560 != -121341)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7921 - 405137 != -397215)
					{
						base..ctor();
						if (150495 - 349493 == -198998)
						{
							this.$mPos$32542 = mPos;
							if (40307 - 456638 == -416331)
							{
								this.$tID$32543 = tID;
								if (70949 - 123455 == -52506)
								{
									this.$self_$32544 = self_;
									if (150174 - 534543 != -384368)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600491E RID: 18718 RVA: 0x00911B8C File Offset: 0x0090FD8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128583 - 277144 != -148560)
				{
				}
				for (;;)
				{
					IL_D0:
					switch (this._state)
					{
					case 0:
						goto IL_3E2;
					case 1:
						goto IL_C23;
					case 2:
						if (this.$self_$32544.castRing)
						{
							if (268560 - 137898 == 130663)
							{
								continue;
							}
							this.$self_$32544.mChar.createEffect(this.$self_$32544.castRing, this.$self_$32544.transform.position, Quaternion.Euler((float)270, (float)90, (float)0));
							if (291618 - 158576 == 133043)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$32544.mChar.actionState != "attack")
						{
							goto IL_436;
						}
						if (58404 - 548087 == -489682)
						{
							continue;
						}
						if (this.$self_$32544.mChar.myCommand != "nefariousWhip")
						{
							if (64167 - 413733 != -349566)
							{
								continue;
							}
							goto IL_436;
						}
						break;
					case 4:
						if (this.$self_$32544.mChar.actionState != "attack")
						{
							goto IL_937;
						}
						if (62173 - 532415 == -470241)
						{
							continue;
						}
						if (this.$self_$32544.mChar.myCommand != "nefariousWhip")
						{
							if (199241 - 558271 != -359029)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$self_$32544.mChar.moveSpeed = (float)0;
							if (189573 - 82063 == 107511)
							{
								continue;
							}
							if (!this.$tObject$32535)
							{
								goto IL_475;
							}
							if (21839 - 348666 == -326826)
							{
								continue;
							}
							if (!this.$self_$32544.mChar.isMine)
							{
								goto IL_475;
							}
							if (191214 - 391377 != -200163)
							{
								continue;
							}
							this.$hitLayer$32537 = 130816 - (1 << this.$self_$32544.gameObject.layer);
							if (42262 - 520153 == -477890)
							{
								continue;
							}
							this.$hitList$32538 = Damage.FindAreaTarget(this.$tObject$32535.transform.position, (float)18, (float)9, this.$hitLayer$32537);
							if (269856 - 150758 != 119098)
							{
								continue;
							}
							this.$$iterator$10765$32541 = UnityRuntimeServices.GetEnumerator(this.$hitList$32538);
							if (227287 - 71576 != 155711)
							{
								continue;
							}
							while (this.$$iterator$10765$32541.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10765$32541.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32539 = (GameObject)obj2;
								if (118810 - 132802 != -13992)
								{
									goto IL_D0;
								}
								this.$hitChar$32540 = (CharacterControl)this.$hitObject$32539.GetComponent(typeof(CharacterControl));
								if (145747 - 29865 == 115883)
								{
									goto IL_D0;
								}
								UnityRuntimeServices.Update(this.$$iterator$10765$32541, this.$hitObject$32539);
								if (164627 - 19275 == 145353)
								{
									goto IL_D0;
								}
								if (this.$hitChar$32540)
								{
									if (279190 - 433889 != -154699)
									{
										goto IL_D0;
									}
									if (this.$hitChar$32540.hp > 0)
									{
										if (242555 - 490511 == -247955)
										{
											goto IL_D0;
										}
										this.$self_$32544.StartCoroutine_Auto(this.$self_$32544.RPC_nefariousWhip_hit(this.$self_$32544.transform.position, this.$self_$32544.transform.forward, this.$hitChar$32540.ActorNr));
										if (79471 - 213019 == -133547)
										{
											goto IL_D0;
										}
										if (PhotonClient.IsInitialized())
										{
											if (6198 - 458763 != -452565)
											{
												goto IL_D0;
											}
											this.$self_$32544.ActionEvent("RPC_nefariousWhip_hit", this.$self_$32544.transform.position, this.$self_$32544.transform.forward, this.$hitChar$32540.ActorNr);
											if (197021 - 591629 != -394608)
											{
												goto IL_D0;
											}
										}
									}
								}
							}
							if (159112 - 489705 != -330593)
							{
								continue;
							}
							goto IL_475;
						}
						break;
					case 5:
						if (this.$self_$32544.mChar.actionState != "attack")
						{
							goto IL_8D8;
						}
						if (90810 - 598693 == -507882)
						{
							continue;
						}
						if (this.$self_$32544.mChar.myCommand != "nefariousWhip")
						{
							if (225435 - 229875 != -4440)
							{
								continue;
							}
							goto IL_8D8;
						}
						else
						{
							this.$self_$32544.mChar.actionState = "standby";
							if (83355 - 299188 == -215832)
							{
								continue;
							}
							this.$self_$32544.mChar.actionTime = Time.time;
							if (273766 - 384988 != -111222)
							{
								continue;
							}
							this.$self_$32544.mChar.myCommand = "none";
							if (82743 - 162300 != -79557)
							{
								continue;
							}
							this.$self_$32544.mChar.nPosition = this.$self_$32544.transform.position;
							if (112019 - 463897 != -351878)
							{
								continue;
							}
							this.YieldDefault(1);
							if (148865 - 358282 != -209416)
							{
								goto Block_60;
							}
							continue;
						}
						break;
					default:
						if (259082 - 294310 != -35228)
						{
							continue;
						}
						goto IL_3E2;
					}
					if (Time.time >= this.$self_$32544.mChar.actionTime + 2f)
					{
						if (130205 - 198028 != -67823)
						{
							continue;
						}
						this.$self_$32544.mChar.vMovement = this.$self_$32544.transform.forward;
						if (204101 - 70511 != 133590)
						{
							continue;
						}
						this.$self_$32544.mChar.moveSpeed = -0.5f;
						if (110092 - 387167 != -277075)
						{
							continue;
						}
						if (!this.$self_$32544.castEffect)
						{
							goto IL_4F3;
						}
						if (4748 - 473155 == -468406)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$32544.castEffect, this.$self_$32544.transform.position + this.$self_$32544.transform.TransformDirection((float)0, 1.3f, (float)1), this.$self_$32544.transform.rotation);
						if (189032 - 483692 != -294660)
						{
							continue;
						}
						goto IL_4F3;
					}
					else
					{
						if (!this.$tObject$32535)
						{
							goto IL_727;
						}
						if (35032 - 104283 != -69251)
						{
							continue;
						}
						if (!(this.$tObject$32535 != this.$self_$32544.gameObject))
						{
							goto IL_727;
						}
						if (59418 - 22515 == 36904)
						{
							continue;
						}
						this.$tPos$32536 = global::Math.vFlat(this.$tObject$32535.transform.position) + Vector3.up * this.$self_$32544.transform.position.y;
						if (224059 - 103967 != 120092)
						{
							continue;
						}
						this.$self_$32544.transform.LookAt(this.$tPos$32536);
						if (163963 - 390206 != -226243)
						{
							continue;
						}
						goto IL_727;
					}
					IL_3E2:
					object obj4;
					object obj3 = obj4 = PhotonClient.ActorNrList[this.$tID$32543];
					if (!(obj3 is GameObject))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
					}
					this.$tObject$32535 = (GameObject)obj4;
					if (110201 - 97291 == 12910)
					{
						this.$tPos$32536 = this.$tObject$32535.transform.position;
						if (259058 - 480971 == -221913)
						{
							this.$tPos$32536.y = this.$mPos$32542.y;
							if (31935 - 168443 == -136508)
							{
								this.$self_$32544.transform.position = this.$mPos$32542;
								if (276488 - 570192 != -293703)
								{
									this.$self_$32544.transform.LookAt(this.$tPos$32536);
									if (255948 - 184921 != 71028)
									{
										this.$self_$32544.animation.CrossFade("cast", 0.2f);
										if (274023 - 275516 == -1493)
										{
											this.$self_$32544.animation.wrapMode = WrapMode.Once;
											if (165234 - 482904 != -317669)
											{
												this.$self_$32544.mChar.actionState = "attack";
												if (184538 - 39277 == 145261)
												{
													this.$self_$32544.mChar.actionTime = Time.time;
													if (116907 - 127651 == -10744)
													{
														this.$self_$32544.mChar.myCommand = "nefariousWhip";
														if (120257 - 42759 != 77499)
														{
															this.$self_$32544.mChar.vMovement = this.$self_$32544.transform.forward;
															if (33718 - 335491 == -301773)
															{
																this.$self_$32544.mChar.moveSpeed = (float)0;
																if (189002 - 344719 != -155716)
																{
																	this.$self_$32544.mChar.addTimeOut("nefariousWhip", (float)30);
																	if (113179 - 307764 != -194584)
																	{
																		if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																		{
																			goto IL_9B9;
																		}
																		if (89322 - 337066 == -247744)
																		{
																			if (this.$self_$32544.nefariousWhip_vc)
																			{
																				if (39820 - 395254 == -355434)
																				{
																					this.$self_$32544.audio.PlayOneShot(this.$self_$32544.nefariousWhip_vc);
																					if (123527 - 373124 == -249597)
																					{
																						goto IL_846;
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Cannot find nefariousWhip voice");
																				if (52287 - 8794 != 43494)
																				{
																					goto Block_54;
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
				Block_11:
				IL_436:
				goto IL_C23;
				IL_475:
				return this.Yield(5, new WaitForSeconds(0.4f));
				IL_4F3:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_727:
				return this.YieldDefault(3);
				IL_846:
				Block_54:
				goto IL_9B9;
				IL_8D8:
				IL_937:
				Block_60:
				goto IL_C23;
				IL_9B9:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_C23:
				return false;
			}

			// Token: 0x0600491F RID: 18719 RVA: 0x009127D0 File Offset: 0x009109D0
			internal static bool QJFDGh5RV5mVb5CE1rhF()
			{
				return true;
			}

			// Token: 0x06004920 RID: 18720 RVA: 0x009127D4 File Offset: 0x009109D4
			internal static bool JYa4gX5RtHMJKjlfpxSR()
			{
				return false;
			}

			// Token: 0x040053F9 RID: 21497
			internal GameObject $tObject$32535;

			// Token: 0x040053FA RID: 21498
			internal Vector3 $tPos$32536;

			// Token: 0x040053FB RID: 21499
			internal int $hitLayer$32537;

			// Token: 0x040053FC RID: 21500
			internal UnityScript.Lang.Array $hitList$32538;

			// Token: 0x040053FD RID: 21501
			internal GameObject $hitObject$32539;

			// Token: 0x040053FE RID: 21502
			internal CharacterControl $hitChar$32540;

			// Token: 0x040053FF RID: 21503
			internal IEnumerator $$iterator$10765$32541;

			// Token: 0x04005400 RID: 21504
			internal Vector3 $mPos$32542;

			// Token: 0x04005401 RID: 21505
			internal int $tID$32543;

			// Token: 0x04005402 RID: 21506
			internal LadyNoir $self_$32544;
		}
	}

	// Token: 0x02000CBA RID: 3258
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nefariousWhip_hit$32548 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004921 RID: 18721 RVA: 0x009127D8 File Offset: 0x009109D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nefariousWhip_hit$32548(Vector3 hitPos, int hitID, LadyNoir self_)
		{
			if (182733 - 172255 != 10479)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (116718 - 331070 == -214352)
				{
					base..ctor();
					if (21323 - 439424 != -418100)
					{
						this.$hitPos$32560 = hitPos;
						if (12242 - 323262 != -311019)
						{
							this.$hitID$32561 = hitID;
							if (177642 - 21987 == 155655)
							{
								this.$self_$32562 = self_;
								if (225550 - 533672 == -308122)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x009128B4 File Offset: 0x00910AB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LadyNoir.$RPC_nefariousWhip_hit$32548.$(this.$hitPos$32560, this.$hitID$32561, this.$self_$32562);
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x009128D0 File Offset: 0x00910AD0
		internal static bool cvcPa95RNl0ymeBwhkgo()
		{
			return true;
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x009128D4 File Offset: 0x00910AD4
		internal static bool As5C2f5RYZXaq5dZ0dbC()
		{
			return false;
		}

		// Token: 0x04005403 RID: 21507
		internal Vector3 $hitPos$32560;

		// Token: 0x04005404 RID: 21508
		internal int $hitID$32561;

		// Token: 0x04005405 RID: 21509
		internal LadyNoir $self_$32562;

		// Token: 0x02000CBB RID: 3259
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004925 RID: 18725 RVA: 0x009128D8 File Offset: 0x00910AD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, int hitID, LadyNoir self_)
			{
				if (134432 - 464319 != -329886)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109310 - 347063 == -237753)
					{
						base..ctor();
						if (281727 - 353866 == -72139)
						{
							this.$hitPos$32557 = hitPos;
							if (263389 - 192980 == 70409)
							{
								this.$hitID$32558 = hitID;
								if (167358 - 294767 != -127408)
								{
									this.$self_$32559 = self_;
									if (244584 - 523006 == -278422)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004926 RID: 18726 RVA: 0x009129B4 File Offset: 0x00910BB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (184965 - 343268 != -158303)
				{
				}
				for (;;)
				{
					IL_31C:
					switch (this._state)
					{
					case 0:
						goto IL_34D;
					case 1:
						goto IL_50B;
					case 2:
						if (this.$tObject$32549)
						{
							if (288081 - 150667 != 137414)
							{
								continue;
							}
							this.$hitPos$32557 = this.$tObject$32549.transform.position;
							if (146810 - 102699 != 44111)
							{
								continue;
							}
						}
						this.$hitLayer$32552 = 130816 - (1 << this.$self_$32559.gameObject.layer);
						if (222240 - 584972 == -362731)
						{
							continue;
						}
						this.$hitList$32553 = Damage.FindAreaTarget(this.$hitPos$32557, (float)4, (float)6, this.$hitLayer$32552);
						if (108747 - 471882 == -363134)
						{
							continue;
						}
						this.$$iterator$10764$32556 = UnityRuntimeServices.GetEnumerator(this.$hitList$32553);
						if (13193 - 129385 != -116192)
						{
							continue;
						}
						while (this.$$iterator$10764$32556.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10764$32556.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$32554 = (GameObject)obj2;
							if (117257 - 298527 == -181269)
							{
								goto IL_31C;
							}
							this.$hitChar$32555 = (CharacterControl)this.$hitObject$32554.GetComponent(typeof(CharacterControl));
							if (149985 - 228818 != -78833)
							{
								goto IL_31C;
							}
							UnityRuntimeServices.Update(this.$$iterator$10764$32556, this.$hitObject$32554);
							if (37232 - 318416 != -281184)
							{
								goto IL_31C;
							}
							if (this.$hitChar$32555)
							{
								if (84198 - 274943 != -190745)
								{
									goto IL_31C;
								}
								this.$hitChar$32555.RPC_AddEffectDamage(41, (int)(0.5f * (float)this.$self_$32559.mChar.cha), 0, 0, 0.5f * Vector3.up, this.$self_$32559.mChar.ActorNr);
								if (293127 - 263358 == 29770)
								{
									goto IL_31C;
								}
							}
						}
						if (274421 - 11617 == 262805)
						{
							continue;
						}
						this.$i$32551++;
						if (79306 - 470895 != -391589)
						{
							continue;
						}
						goto IL_1FA;
					default:
						if (221277 - 343281 != -122003)
						{
							goto IL_34D;
						}
						continue;
					}
					IL_110:
					this.YieldDefault(1);
					if (77181 - 81550 != -4369)
					{
						continue;
					}
					goto IL_50B;
					IL_34D:
					object obj4;
					object obj3 = obj4 = PhotonClient.ActorNrList[this.$hitID$32558];
					if (!(obj3 is GameObject))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
					}
					this.$tObject$32549 = (GameObject)obj4;
					if (123460 - 157410 != -33950)
					{
						continue;
					}
					if (!this.$tObject$32549)
					{
						goto IL_110;
					}
					if (63705 - 329721 == -266015)
					{
						continue;
					}
					this.$tChar$32550 = (CharacterControl)this.$tObject$32549.GetComponent(typeof(CharacterControl));
					if (243554 - 73587 != 169967)
					{
						continue;
					}
					if (this.$tChar$32550)
					{
						if (237329 - 412419 != -175090)
						{
							continue;
						}
						if (this.$self_$32559.nefariousWhip_hit)
						{
							if (37758 - 453792 != -416034)
							{
								continue;
							}
							this.$tChar$32550.createEffect(this.$self_$32559.nefariousWhip_hit, this.$tObject$32549.transform.position, this.$self_$32559.transform.rotation);
							if (263975 - 8475 != 255500)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find nefariousWhip_hit Effect");
							if (170063 - 232219 == -62155)
							{
								continue;
							}
						}
					}
					if (!this.$self_$32559.mChar.isMine)
					{
						goto IL_110;
					}
					if (178757 - 596338 != -417581)
					{
						continue;
					}
					this.$i$32551 = 0;
					if (82022 - 334030 == -252007)
					{
						continue;
					}
					IL_1FA:
					if (this.$i$32551 < 8)
					{
						break;
					}
					if (144447 - 223786 != -79338)
					{
						goto IL_110;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_50B:
				return false;
			}

			// Token: 0x06004927 RID: 18727 RVA: 0x00912EE0 File Offset: 0x009110E0
			internal static bool MdK0wJ5RcMtJJDhaBoSV()
			{
				return true;
			}

			// Token: 0x06004928 RID: 18728 RVA: 0x00912EE4 File Offset: 0x009110E4
			internal static bool c3BxjM5RU1jAhlmPAqsQ()
			{
				return false;
			}

			// Token: 0x04005406 RID: 21510
			internal GameObject $tObject$32549;

			// Token: 0x04005407 RID: 21511
			internal CharacterControl $tChar$32550;

			// Token: 0x04005408 RID: 21512
			internal int $i$32551;

			// Token: 0x04005409 RID: 21513
			internal int $hitLayer$32552;

			// Token: 0x0400540A RID: 21514
			internal UnityScript.Lang.Array $hitList$32553;

			// Token: 0x0400540B RID: 21515
			internal GameObject $hitObject$32554;

			// Token: 0x0400540C RID: 21516
			internal CharacterControl $hitChar$32555;

			// Token: 0x0400540D RID: 21517
			internal IEnumerator $$iterator$10764$32556;

			// Token: 0x0400540E RID: 21518
			internal Vector3 $hitPos$32557;

			// Token: 0x0400540F RID: 21519
			internal int $hitID$32558;

			// Token: 0x04005410 RID: 21520
			internal LadyNoir $self_$32559;
		}
	}

	// Token: 0x02000CBC RID: 3260
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_darkIllusion$32563 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004929 RID: 18729 RVA: 0x00912EE8 File Offset: 0x009110E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_darkIllusion$32563(Vector3 mPos, Vector3 tDir, LadyNoir self_)
		{
			if (135002 - 353993 != -218991)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (49419 - 459621 == -410202)
				{
					base..ctor();
					if (277498 - 356478 != -78979)
					{
						this.$mPos$32574 = mPos;
						if (142449 - 565550 == -423101)
						{
							this.$tDir$32575 = tDir;
							if (61903 - 135476 == -73573)
							{
								this.$self_$32576 = self_;
								if (129928 - 456976 == -327048)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x00912FC4 File Offset: 0x009111C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LadyNoir.$RPC_darkIllusion$32563.$(this.$mPos$32574, this.$tDir$32575, this.$self_$32576);
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x00912FE0 File Offset: 0x009111E0
		internal static bool KtOPVT5RTmysaukF1gP3()
		{
			return true;
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x00912FE4 File Offset: 0x009111E4
		internal static bool mvL2T65R3pv1JSjnptHd()
		{
			return false;
		}

		// Token: 0x04005411 RID: 21521
		internal Vector3 $mPos$32574;

		// Token: 0x04005412 RID: 21522
		internal Vector3 $tDir$32575;

		// Token: 0x04005413 RID: 21523
		internal LadyNoir $self_$32576;

		// Token: 0x02000CBD RID: 3261
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600492D RID: 18733 RVA: 0x00912FE8 File Offset: 0x009111E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LadyNoir self_)
			{
				if (35205 - 398252 != -363046)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (129462 - 86508 != 42955)
					{
						base..ctor();
						if (115979 - 454304 == -338325)
						{
							this.$mPos$32571 = mPos;
							if (174787 - 127525 == 47262)
							{
								this.$tDir$32572 = tDir;
								if (283770 - 188840 != 94931)
								{
									this.$self_$32573 = self_;
									if (39801 - 542436 != -502634)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600492E RID: 18734 RVA: 0x009130C4 File Offset: 0x009112C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (248352 - 309336 != -60983)
				{
				}
				for (;;)
				{
					IL_66C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AAF;
					case 2:
						if (!this.$self_$32573.castRing)
						{
							goto IL_184;
						}
						if (98888 - 448519 != -349631)
						{
							continue;
						}
						this.$self_$32573.mChar.createEffect(this.$self_$32573.castRing, this.$self_$32573.transform.position, Quaternion.Euler((float)270, (float)90, (float)0));
						if (284419 - 422324 != -137904)
						{
							goto Block_49;
						}
						continue;
					case 3:
						if (this.$self_$32573.mChar.actionState != "attack")
						{
							goto IL_305;
						}
						if (244216 - 303213 != -58997)
						{
							continue;
						}
						if (this.$self_$32573.mChar.myCommand != "darkIllusion")
						{
							if (230572 - 136823 != 93749)
							{
								continue;
							}
							goto IL_305;
						}
						else
						{
							if (!this.$self_$32573.castEffect)
							{
								goto IL_553;
							}
							if (194203 - 249737 == -55533)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$32573.castEffect, this.$self_$32573.transform.position + this.$self_$32573.transform.TransformDirection((float)0, 1.3f, (float)1), this.$self_$32573.transform.rotation);
							if (44959 - 150399 != -105439)
							{
								goto Block_54;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$32573.mChar.actionState != "attack")
						{
							goto IL_3E8;
						}
						if (17885 - 463347 == -445461)
						{
							continue;
						}
						if (this.$self_$32573.mChar.myCommand != "darkIllusion")
						{
							if (265829 - 572022 != -306193)
							{
								continue;
							}
							goto IL_3E8;
						}
						else
						{
							if (!this.$self_$32573.mChar.isMine)
							{
								goto IL_CC;
							}
							if (76288 - 56529 != 19759)
							{
								continue;
							}
							this.$mLadyCount$32564 = 0;
							if (147728 - 571050 == -423321)
							{
								continue;
							}
							this.$tList$32565 = Damage.FindAreaTarget(this.$self_$32573.transform.position, (float)100, (float)12, 1 << this.$self_$32573.gameObject.layer);
							if (77416 - 151045 == -73628)
							{
								continue;
							}
							this.$$iterator$10766$32568 = UnityRuntimeServices.GetEnumerator(this.$tList$32565);
							if (97264 - 258854 != -161590)
							{
								continue;
							}
							while (this.$$iterator$10766$32568.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10766$32568.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$32566 = (GameObject)obj2;
								if (46241 - 321340 != -275099)
								{
									goto IL_66C;
								}
								this.$tChar$32567 = (CharacterControl)this.$tObject$32566.GetComponent(typeof(CharacterControl));
								if (182292 - 40287 == 142006)
								{
									goto IL_66C;
								}
								UnityRuntimeServices.Update(this.$$iterator$10766$32568, this.$tObject$32566);
								if (5622 - 555328 == -549705)
								{
									goto IL_66C;
								}
								if (this.$tObject$32566 != this.$self_$32573.gameObject)
								{
									if (141857 - 68336 == 73522)
									{
										goto IL_66C;
									}
									if (this.$tChar$32567.Type == "LadyNoir")
									{
										if (261187 - 484286 == -223098)
										{
											goto IL_66C;
										}
										this.$mLadyCount$32564++;
										if (264258 - 126899 != 137359)
										{
											goto IL_66C;
										}
									}
								}
							}
							if (174791 - 274425 != -99634)
							{
								continue;
							}
							if (this.$mLadyCount$32564 >= 3)
							{
								goto IL_CC;
							}
							if (36664 - 423709 == -387044)
							{
								continue;
							}
							this.$nPos1$32569 = global::Math.getSpawnVector(this.$self_$32573.transform.position + Vector3.up, this.$self_$32573.transform.TransformDirection(-1.5f, (float)-1, 2.6f));
							if (290168 - 381324 == -91155)
							{
								continue;
							}
							this.$nPos2$32570 = global::Math.getSpawnVector(this.$self_$32573.transform.position + Vector3.up, this.$self_$32573.transform.TransformDirection(1.5f, (float)-1, 2.6f));
							if (286058 - 532096 == -246037)
							{
								continue;
							}
							if (this.$nPos1$32569 != Vector3.zero)
							{
								if (47296 - 36470 != 10826)
								{
									continue;
								}
								this.$self_$32573.createLadyNoir(this.$nPos1$32569, this.$self_$32573.transform.forward);
								if (70894 - 575051 != -504157)
								{
									continue;
								}
							}
							if (!(this.$nPos2$32570 != Vector3.zero))
							{
								goto IL_CC;
							}
							if (148297 - 438074 != -289777)
							{
								continue;
							}
							this.$self_$32573.createLadyNoir(this.$nPos2$32570, this.$self_$32573.transform.forward);
							if (152975 - 368851 != -215876)
							{
								continue;
							}
							goto IL_CC;
						}
						break;
					case 5:
						if (this.$self_$32573.mChar.actionState != "attack")
						{
							goto IL_3B4;
						}
						if (191106 - 260436 == -69329)
						{
							continue;
						}
						if (this.$self_$32573.mChar.myCommand != "darkIllusion")
						{
							if (218437 - 317163 != -98726)
							{
								continue;
							}
							goto IL_3B4;
						}
						else
						{
							this.$self_$32573.mChar.actionState = "standby";
							if (288479 - 299245 == -10765)
							{
								continue;
							}
							this.$self_$32573.mChar.actionTime = Time.time;
							if (127070 - 453059 == -325988)
							{
								continue;
							}
							this.$self_$32573.mChar.myCommand = "none";
							if (268252 - 567032 != -298780)
							{
								continue;
							}
							this.$self_$32573.mChar.nPosition = this.$self_$32573.transform.position;
							if (48176 - 321763 == -273586)
							{
								continue;
							}
							this.YieldDefault(1);
							if (19858 - 512160 != -492301)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					default:
						if (70781 - 311520 != -240739)
						{
							continue;
						}
						break;
					}
					this.$self_$32573.transform.position = this.$mPos$32571;
					if (134284 - 293281 == -158997)
					{
						this.$self_$32573.transform.LookAt(this.$mPos$32571 + global::Math.vFlat(this.$tDir$32572));
						if (184212 - 209882 == -25670)
						{
							this.$self_$32573.animation.CrossFade("bigCast", 0.2f);
							if (273805 - 582339 != -308533)
							{
								this.$self_$32573.animation.wrapMode = WrapMode.Loop;
								if (64351 - 571496 == -507145)
								{
									this.$self_$32573.mChar.actionState = "attack";
									if (26667 - 254754 == -228087)
									{
										this.$self_$32573.mChar.actionTime = Time.time;
										if (42535 - 149121 != -106585)
										{
											this.$self_$32573.mChar.myCommand = "darkIllusion";
											if (91488 - 125474 == -33986)
											{
												this.$self_$32573.mChar.vMovement = this.$self_$32573.transform.forward;
												if (105908 - 362106 == -256198)
												{
													this.$self_$32573.mChar.moveSpeed = (float)0;
													if (75985 - 64051 == 11934)
													{
														this.$self_$32573.mChar.addTimeOut("darkIllusion", (float)600);
														if (79844 - 443849 != -364004)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_7D6;
															}
															if (269204 - 418049 != -148844)
															{
																if (this.$self_$32573.darkIllusion_vc)
																{
																	if (191501 - 305665 != -114163)
																	{
																		this.$self_$32573.audio.PlayOneShot(this.$self_$32573.darkIllusion_vc);
																		if (291048 - 23871 == 267177)
																		{
																			goto IL_98F;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find darkIllusion_vc voice");
																	if (245395 - 480821 == -235426)
																	{
																		goto IL_7D6;
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
				IL_CC:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_184:
				return this.Yield(3, new WaitForSeconds(2.8f));
				IL_305:
				IL_3B4:
				IL_3E8:
				goto IL_AAF;
				IL_553:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_48:
				goto IL_AAF;
				Block_49:
				goto IL_184;
				IL_7D6:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_54:
				goto IL_553;
				IL_98F:
				goto IL_7D6;
				IL_AAF:
				return false;
			}

			// Token: 0x0600492F RID: 18735 RVA: 0x00913B94 File Offset: 0x00911D94
			internal static bool aQU5fA5RX8reuhp7fm0j()
			{
				return true;
			}

			// Token: 0x06004930 RID: 18736 RVA: 0x00913B98 File Offset: 0x00911D98
			internal static bool PE66AG5RQ07PI4yDQAir()
			{
				return false;
			}

			// Token: 0x04005414 RID: 21524
			internal int $mLadyCount$32564;

			// Token: 0x04005415 RID: 21525
			internal UnityScript.Lang.Array $tList$32565;

			// Token: 0x04005416 RID: 21526
			internal GameObject $tObject$32566;

			// Token: 0x04005417 RID: 21527
			internal CharacterControl $tChar$32567;

			// Token: 0x04005418 RID: 21528
			internal IEnumerator $$iterator$10766$32568;

			// Token: 0x04005419 RID: 21529
			internal Vector3 $nPos1$32569;

			// Token: 0x0400541A RID: 21530
			internal Vector3 $nPos2$32570;

			// Token: 0x0400541B RID: 21531
			internal Vector3 $mPos$32571;

			// Token: 0x0400541C RID: 21532
			internal Vector3 $tDir$32572;

			// Token: 0x0400541D RID: 21533
			internal LadyNoir $self_$32573;
		}
	}

	// Token: 0x02000CBE RID: 3262
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32577 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004931 RID: 18737 RVA: 0x00913B9C File Offset: 0x00911D9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32577(UnityScript.Lang.Array nArray, LadyNoir self_)
		{
			if (40555 - 230772 != -190216)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (176228 - 261052 == -84824)
				{
					base..ctor();
					if (109073 - 467902 == -358829)
					{
						this.$nArray$32582 = nArray;
						if (203371 - 252290 == -48919)
						{
							this.$self_$32583 = self_;
							if (186930 - 250832 == -63902)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x00913C58 File Offset: 0x00911E58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LadyNoir.$RPC_ko$32577.$(this.$nArray$32582, this.$self_$32583);
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x00913C6C File Offset: 0x00911E6C
		internal static bool BQS33Z5RkdcsjTRlhPpC()
		{
			return true;
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x00913C70 File Offset: 0x00911E70
		internal static bool roErri5RGYXUgfW6SwAR()
		{
			return false;
		}

		// Token: 0x0400541E RID: 21534
		internal UnityScript.Lang.Array $nArray$32582;

		// Token: 0x0400541F RID: 21535
		internal LadyNoir $self_$32583;

		// Token: 0x02000CBF RID: 3263
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004935 RID: 18741 RVA: 0x00913C74 File Offset: 0x00911E74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LadyNoir self_)
			{
				if (235528 - 487026 != -251497)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75268 - 244990 != -169721)
					{
						base..ctor();
						if (119936 - 570160 == -450224)
						{
							this.$nArray$32580 = nArray;
							if (175856 - 123322 == 52534)
							{
								this.$self_$32581 = self_;
								if (86068 - 217818 == -131750)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004936 RID: 18742 RVA: 0x00913D30 File Offset: 0x00911F30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60920 - 577667 != -516747)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_543;
					case 2:
						if (this.$self_$32581.mChar.actionState != "ko")
						{
							if (76219 - 413199 != -336979)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$self_$32581.animation.Play("getUp");
							if (290131 - 537870 == -247738)
							{
								continue;
							}
							this.$self_$32581.animation.wrapMode = WrapMode.Once;
							if (81659 - 38554 != 43106)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32581.mChar.actionState != "ko")
						{
							if (217693 - 324048 != -106354)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$self_$32581.mChar.actionState = "standby";
							if (133533 - 503054 == -369520)
							{
								continue;
							}
							this.$self_$32581.mChar.actionTime = Time.time;
							if (218061 - 218292 == -230)
							{
								continue;
							}
							this.$self_$32581.mChar.myCommand = "none";
							if (103510 - 159158 != -55648)
							{
								continue;
							}
							this.$self_$32581.mChar.ko = this.$self_$32581.mChar.mko;
							if (97965 - 399424 == -301458)
							{
								continue;
							}
							this.YieldDefault(1);
							if (290292 - 232432 != 57860)
							{
								continue;
							}
							goto IL_543;
						}
						break;
					default:
						if (154524 - 190808 != -36284)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32581.mChar.actionState == "ko")
					{
						break;
					}
					if (234516 - 396814 != -162297)
					{
						if (this.$self_$32581.mChar.actionState == "dead")
						{
							if (107223 - 237966 == -130743)
							{
								break;
							}
						}
						else
						{
							this.$mPos$32578 = (Vector3)this.$nArray$32580[0];
							if (178827 - 134614 == 44213)
							{
								this.$mDir$32579 = (Vector3)this.$nArray$32580[1];
								if (222222 - 545827 != -323604)
								{
									this.$self_$32581.mChar.ko = 0;
									if (205598 - 59130 == 146468)
									{
										this.$self_$32581.mChar.actionState = "ko";
										if (127343 - 180156 == -52813)
										{
											this.$self_$32581.mChar.actionTime = Time.time;
											if (229515 - 586925 == -357410)
											{
												this.$self_$32581.mChar.myCommand = "none";
												if (12238 - 62475 != -50236)
												{
													this.$self_$32581.mChar.vMovement = Vector3.zero;
													if (160637 - 21210 == 139427)
													{
														this.$self_$32581.mChar.moveSpeed = (float)0;
														if (84753 - 221564 != -136810)
														{
															this.$self_$32581.animation.Play("ko");
															if (93147 - 342151 != -249003)
															{
																this.$self_$32581.animation.wrapMode = WrapMode.Once;
																if (159766 - 86880 == 72886)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		goto IL_449;
																	}
																	if (30260 - 138360 != -108099)
																	{
																		if (this.$self_$32581.ko_vc)
																		{
																			if (23282 - 371243 == -347961)
																			{
																				this.$self_$32581.audio.PlayOneShot(this.$self_$32581.ko_vc);
																				if (145906 - 374243 == -228337)
																				{
																					goto IL_420;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (204839 - 521281 != -316441)
																			{
																				goto IL_449;
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
				goto IL_543;
				Block_25:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_420:
				IL_449:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_28:
				Block_30:
				IL_543:
				return false;
			}

			// Token: 0x06004937 RID: 18743 RVA: 0x00914294 File Offset: 0x00912494
			internal static bool j1aAwJ5RHOf9dDpgQYgD()
			{
				return true;
			}

			// Token: 0x06004938 RID: 18744 RVA: 0x00914298 File Offset: 0x00912498
			internal static bool a5vXGr5RW8aTYpOcALPf()
			{
				return false;
			}

			// Token: 0x04005420 RID: 21536
			internal Vector3 $mPos$32578;

			// Token: 0x04005421 RID: 21537
			internal Vector3 $mDir$32579;

			// Token: 0x04005422 RID: 21538
			internal UnityScript.Lang.Array $nArray$32580;

			// Token: 0x04005423 RID: 21539
			internal LadyNoir $self_$32581;
		}
	}

	// Token: 0x02000CC0 RID: 3264
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32584 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004939 RID: 18745 RVA: 0x0091429C File Offset: 0x0091249C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32584(UnityScript.Lang.Array nArray, LadyNoir self_)
		{
			if (196975 - 119449 != 77527)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (281918 - 577304 != -295385)
				{
					base..ctor();
					if (94084 - 114045 != -19960)
					{
						this.$nArray$32589 = nArray;
						if (281217 - 578107 != -296889)
						{
							this.$self_$32590 = self_;
							if (106344 - 267487 == -161143)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00914358 File Offset: 0x00912558
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LadyNoir.$RPC_dead$32584.$(this.$nArray$32589, this.$self_$32590);
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x0091436C File Offset: 0x0091256C
		internal static bool IPErse5RAlItyZu4ZpB4()
		{
			return true;
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x00914370 File Offset: 0x00912570
		internal static bool MC4PHR5RldxawAwjgwmG()
		{
			return false;
		}

		// Token: 0x04005424 RID: 21540
		internal UnityScript.Lang.Array $nArray$32589;

		// Token: 0x04005425 RID: 21541
		internal LadyNoir $self_$32590;

		// Token: 0x02000CC1 RID: 3265
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600493D RID: 18749 RVA: 0x00914374 File Offset: 0x00912574
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LadyNoir self_)
			{
				if (220558 - 499982 != -279424)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (273689 - 582184 != -308494)
					{
						base..ctor();
						if (263914 - 248646 == 15268)
						{
							this.$nArray$32587 = nArray;
							if (220663 - 586929 == -366266)
							{
								this.$self_$32588 = self_;
								if (209349 - 252415 != -43065)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600493E RID: 18750 RVA: 0x00914430 File Offset: 0x00912630
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81406 - 268283 != -186877)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4E6;
					case 2:
						if (this.$self_$32588.mChar.actionState != "dead")
						{
							if (224560 - 203104 != 21456)
							{
								continue;
							}
							goto IL_338;
						}
						else
						{
							if (!this.$self_$32588.mChar.isPlayer)
							{
								if (151239 - 450886 != -299647)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32588.gameObject);
								if (220055 - 183708 != 36347)
								{
									continue;
								}
							}
							else if (this.$self_$32588.mChar.isMine)
							{
								if (283745 - 277808 != 5937)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32588.gameObject);
								if (144804 - 303760 == -158955)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (60984 - 472380 != -411396)
							{
								continue;
							}
							goto IL_4E6;
						}
						break;
					default:
						if (165982 - 268520 != -102538)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32588.mChar.actionState == "dead")
					{
						if (71465 - 399328 == -327863)
						{
							goto IL_453;
						}
					}
					else
					{
						this.$myPosition$32585 = (Vector3)this.$nArray$32587[0];
						if (17105 - 556715 != -539609)
						{
							this.$myDirection$32586 = (Vector3)this.$nArray$32587[1];
							if (188992 - 244432 != -55439)
							{
								this.$self_$32588.transform.position = this.$myPosition$32585;
								if (71795 - 419431 == -347636)
								{
									this.$self_$32588.transform.LookAt(this.$myPosition$32585 + this.$myDirection$32586);
									if (71442 - 72789 == -1347)
									{
										this.$self_$32588.mChar.hp = 0;
										if (126058 - 525696 != -399637)
										{
											this.$self_$32588.mChar.actionState = "dead";
											if (138837 - 346229 == -207392)
											{
												this.$self_$32588.mChar.actionTime = Time.time;
												if (94977 - 555877 != -460899)
												{
													this.$self_$32588.mChar.myCommand = "none";
													if (22202 - 82504 == -60302)
													{
														this.$self_$32588.mChar.vMovement = Vector3.zero;
														if (76292 - 450497 == -374205)
														{
															this.$self_$32588.mChar.moveSpeed = (float)0;
															if (118328 - 580606 != -462277)
															{
																this.$self_$32588.animation.Rewind();
																if (275076 - 164914 == 110162)
																{
																	this.$self_$32588.animation.Play("ko");
																	if (165858 - 443351 != -277492)
																	{
																		this.$self_$32588.animation.wrapMode = WrapMode.Once;
																		if (207544 - 297338 != -89793)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				break;
																			}
																			if (19701 - 281210 == -261509)
																			{
																				if (this.$self_$32588.dead_vc)
																				{
																					if (45359 - 168912 == -123553)
																					{
																						this.$self_$32588.audio.PlayOneShot(this.$self_$32588.dead_vc);
																						if (72201 - 419318 == -347117)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (209231 - 248591 != -39359)
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
				IL_16E:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_338:
				IL_453:
				goto IL_4E6;
				goto IL_16E;
				IL_4E6:
				return false;
			}

			// Token: 0x0600493F RID: 18751 RVA: 0x00914938 File Offset: 0x00912B38
			internal static bool k1qqnt5RyfRNwfe0r9xy()
			{
				return true;
			}

			// Token: 0x06004940 RID: 18752 RVA: 0x0091493C File Offset: 0x00912B3C
			internal static bool Jndaod5RSbFlHjI9Bhvk()
			{
				return false;
			}

			// Token: 0x04005426 RID: 21542
			internal Vector3 $myPosition$32585;

			// Token: 0x04005427 RID: 21543
			internal Vector3 $myDirection$32586;

			// Token: 0x04005428 RID: 21544
			internal UnityScript.Lang.Array $nArray$32587;

			// Token: 0x04005429 RID: 21545
			internal LadyNoir $self_$32588;
		}
	}
}
