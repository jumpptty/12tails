using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000189 RID: 393
[Serializable]
public class RangerBug : MonoBehaviour
{
	// Token: 0x060008D3 RID: 2259 RVA: 0x000E5EA0 File Offset: 0x000E40A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RangerBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x000E5EB0 File Offset: 0x000E40B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (124321 - 315127 != -190805)
		{
		}
		for (;;)
		{
			this.rY4Qr3WmLm = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (50702 - 569274 != -518571)
			{
				this.rY4Qr3WmLm.actionState = "standby";
				if (106218 - 190886 == -84668)
				{
					this.rY4Qr3WmLm.actionTime = Time.time;
					if (223038 - 586793 == -363755)
					{
						this.rY4Qr3WmLm.myCommand = "none";
						if (73854 - 63077 != 10778)
						{
							if (this.rY4Qr3WmLm)
							{
								if (285497 - 533377 == -247879)
								{
									continue;
								}
								eRangerBugType eRangerBugType = this.rangerBugType;
								if (130551 - 231418 != -100867)
								{
									continue;
								}
								if (eRangerBugType == eRangerBugType.red)
								{
									if (86784 - 72183 == 14602)
									{
										continue;
									}
									this.rY4Qr3WmLm.mImmuneList = new UnityScript.Lang.Array(new object[]
									{
										"powerBreak",
										"armorBreak",
										"burn"
									});
									if (91292 - 272553 != -181261)
									{
										continue;
									}
								}
								else if (eRangerBugType == eRangerBugType.yellow)
								{
									if (25465 - 226572 == -201106)
									{
										continue;
									}
									this.rY4Qr3WmLm.mImmuneList = new UnityScript.Lang.Array(new object[]
									{
										"lightBind",
										"sleep",
										"paralysis"
									});
									if (59162 - 566658 == -507495)
									{
										continue;
									}
								}
								else if (eRangerBugType == eRangerBugType.pink)
								{
									if (120471 - 422417 != -301946)
									{
										continue;
									}
									this.rY4Qr3WmLm.mImmuneList = new UnityScript.Lang.Array(new object[]
									{
										"charm",
										"confuse",
										"mindControl"
									});
									if (174715 - 359611 == -184895)
									{
										continue;
									}
								}
								else if (eRangerBugType == eRangerBugType.blue)
								{
									if (73357 - 45201 != 28156)
									{
										continue;
									}
									this.rY4Qr3WmLm.mImmuneList = new UnityScript.Lang.Array(new object[]
									{
										"ice",
										"frost",
										"snowman"
									});
									if (193393 - 194221 != -828)
									{
										continue;
									}
								}
								else if (eRangerBugType == eRangerBugType.black)
								{
									if (191178 - 140785 == 50394)
									{
										continue;
									}
									this.rY4Qr3WmLm.mImmuneList = new UnityScript.Lang.Array(new object[]
									{
										"needlePrison",
										"groundLock",
										"sticky",
										"petrify"
									});
									if (173736 - 100240 != 73496)
									{
										continue;
									}
								}
							}
							if (Game.mGameCode == 938)
							{
								if (131518 - 553397 == -421879)
								{
									this.StartCoroutine_Auto(this.RPC_summon(this.transform.position, this.transform.forward, 0));
									if (294892 - 222869 == 72023)
									{
										break;
									}
								}
							}
							else
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (97650 - 324307 != -226656)
								{
									this.rY4Qr3WmLm.isMine = true;
									if (293052 - 20972 != 272081)
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

	// Token: 0x060008D5 RID: 2261 RVA: 0x000E62CC File Offset: 0x000E44CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (275397 - 307693 != -32296)
		{
		}
		for (;;)
		{
			if (this.rY4Qr3WmLm.isControlled)
			{
				if (216017 - 223663 == -7645)
				{
					continue;
				}
				if (!(this.rY4Qr3WmLm.actionState == "standby"))
				{
					if (95380 - 162884 != -67504)
					{
						continue;
					}
					if (!(this.rY4Qr3WmLm.actionState == "run"))
					{
						goto IL_1A;
					}
					if (13354 - 290564 == -277209)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (191404 - 309297 != -117893)
				{
					continue;
				}
			}
			IL_1A:
			if (this.rY4Qr3WmLm.hp <= 0)
			{
				if (218036 - 449160 == -231123)
				{
					continue;
				}
				if (this.rY4Qr3WmLm.actionState != "dead")
				{
					if (101793 - 358473 != -256680)
					{
						continue;
					}
					if (this.rY4Qr3WmLm.isMine)
					{
						if (203035 - 45971 == 157065)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (264620 - 154513 == 110108)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (185733 - 10853 != 174880)
						{
							continue;
						}
						this.rY4Qr3WmLm.DeadEvent();
						if (294389 - 348597 != -54207)
						{
							break;
						}
						continue;
					}
					else
					{
						this.rY4Qr3WmLm.hp = 1;
						if (120591 - 111509 != 9082)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.rY4Qr3WmLm.hp <= 0)
			{
				break;
			}
			if (43812 - 298922 != -255109)
			{
				if (this.rY4Qr3WmLm.ko > 0)
				{
					break;
				}
				if (62965 - 19645 == 43320)
				{
					if (!(this.rY4Qr3WmLm.actionState != "ko"))
					{
						break;
					}
					if (132431 - 368283 != -235851)
					{
						if (!(this.rY4Qr3WmLm.actionState != "dead"))
						{
							break;
						}
						if (185500 - 598372 == -412872)
						{
							if (this.rY4Qr3WmLm.isMine)
							{
								if (65050 - 564796 != -499745)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (142199 - 211880 != -69680)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (191228 - 237234 != -46005)
										{
											this.rY4Qr3WmLm.KoEvent();
											if (151951 - 204732 != -52780)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.rY4Qr3WmLm.ko = 1;
								if (181393 - 172961 == 8432)
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

	// Token: 0x060008D6 RID: 2262 RVA: 0x000E66C4 File Offset: 0x000E48C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (240825 - 290449 != -49623)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (8087 - 457537 != -449449)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (21843 - 77986 == -56143)
				{
					if (200391 - 390619 != -190227)
					{
						if (ActionName == "RPC_nAttack_red")
						{
							if (239577 - 235590 != 3987)
							{
								continue;
							}
							v = 1;
							if (135215 - 139352 != -4137)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_red_hit")
						{
							if (5902 - 236881 == -230978)
							{
								continue;
							}
							v = -1;
							if (198307 - 540837 != -342530)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_yellow")
						{
							if (219480 - 500929 == -281448)
							{
								continue;
							}
							v = 2;
							if (172317 - 288219 == -115901)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_yellow_hit")
						{
							if (213441 - 298573 == -85131)
							{
								continue;
							}
							v = -2;
							if (30693 - 423346 != -392653)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_pink")
						{
							if (217662 - 100228 != 117434)
							{
								continue;
							}
							v = 3;
							if (60825 - 230129 != -169304)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_blue")
						{
							if (118590 - 256452 == -137861)
							{
								continue;
							}
							v = 4;
							if (23988 - 534555 != -510567)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_black")
						{
							if (186102 - 170052 != 16050)
							{
								continue;
							}
							v = 5;
							if (42409 - 483720 == -441310)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (268898 - 156460 != 112438)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (143892 - 117863 == 26029)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (291586 - 480771 != -189184)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (269158 - 328161 == -59003)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (39114 - 412556 != -373441)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (273636 - 481786 != -208149)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (266753 - 28788 != 237966)
											{
												Hashtable hashtable = new Hashtable();
												if (293604 - 37918 == 255686)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (201824 - 12 != 201813)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (205842 - 476847 != -271004)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (144394 - 529965 == -385571)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (38672 - 528879 == -490207)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (19089 - 115028 == -95939)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (256509 - 362431 == -105922)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (19673 - 489070 != -469396)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (260921 - 308936 != -48014)
																				{
																					PhotonClient.SendEvent(this.rY4Qr3WmLm.ActorNr, 74, hashtable, true, true);
																					if (248113 - 125617 != 122497)
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

	// Token: 0x060008D7 RID: 2263 RVA: 0x000E6CBC File Offset: 0x000E4EBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (9128 - 132840 != -123712)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (146632 - 102792 != 43841)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (205580 - 491758 != -286177)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (132995 - 414280 != -281284)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (294722 - 227201 == 67521)
						{
							int num3 = num;
							if (91813 - 179151 == -87338)
							{
								if (num3 == 1)
								{
									if (41380 - 402263 == -360883)
									{
										if (this.rY4Qr3WmLm.isMine)
										{
											break;
										}
										if (281254 - 408455 != -127200)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_red(vector, vector2, num2));
											if (31607 - 557538 != -525930)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (289192 - 101592 != 187601)
									{
										if (this.rY4Qr3WmLm.isMine)
										{
											break;
										}
										if (32873 - 495847 == -462974)
										{
											this.RPC_nAttack_red_hit(vector, vector2, num2);
											if (298448 - 320659 != -22210)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (19512 - 315950 != -296437)
									{
										if (this.rY4Qr3WmLm.isMine)
										{
											break;
										}
										if (151440 - 388168 == -236728)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_yellow(vector, vector2, num2));
											if (299618 - 395928 != -96309)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (55813 - 425168 == -369355)
									{
										if (this.rY4Qr3WmLm.isMine)
										{
											break;
										}
										if (207300 - 362258 != -154957)
										{
											this.RPC_nAttack_yellow_hit(vector, vector2, num2);
											if (165758 - 56241 != 109518)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (298070 - 527595 != -229524)
									{
										if (this.rY4Qr3WmLm.isMine)
										{
											break;
										}
										if (152763 - 408598 != -255834)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_pink(vector, vector2, num2));
											if (229353 - 366786 == -137433)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 4)
								{
									if (41752 - 210806 == -169054)
									{
										if (this.rY4Qr3WmLm.isMine)
										{
											break;
										}
										if (173081 - 428948 != -255866)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_blue(vector, vector2, num2));
											if (139399 - 278395 != -138995)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 5)
								{
									if (141991 - 404088 == -262097)
									{
										if (this.rY4Qr3WmLm.isMine)
										{
											break;
										}
										if (121322 - 173724 == -52402)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_black(vector, vector2, num2));
											if (913 - 216159 == -215246)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (59433 - 23109 == 36324)
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

	// Token: 0x060008D8 RID: 2264 RVA: 0x000E71B0 File Offset: 0x000E53B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (189396 - 221758 != -32362)
		{
		}
		for (;;)
		{
			float num = this.rY4Qr3WmLm.moveSpeed;
			if (125661 - 134927 == -9266)
			{
				float runSpeed = this.rY4Qr3WmLm.runSpeed;
				if (59760 - 304466 == -244706)
				{
					Vector3 a = default(Vector3);
					if (172610 - 204044 != -31433)
					{
						Vector3 vector = Vector3.zero;
						if (149108 - 422623 == -273515)
						{
							float num2 = (float)0;
							if (162413 - 74399 == 88014)
							{
								if (this.rY4Qr3WmLm.isMine)
								{
									if (103663 - 257202 == -153538)
									{
										continue;
									}
									if ((this.rY4Qr3WmLm.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (24306 - 528076 != -503770)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (172230 - 245034 == -72803)
										{
											continue;
										}
										a.y = (float)0;
										if (64346 - 239278 != -174932)
										{
											continue;
										}
										a = a.normalized;
										if (101098 - 93064 == 8035)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (17644 - 270789 != -253145)
										{
											continue;
										}
										vector = vector.normalized;
										if (73145 - 157734 != -84589)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (48623 - 153859 == -105235)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (54104 - 581229 == -527124)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (182631 - 558553 != -375922)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (15728 - 194504 != -178776)
														{
															continue;
														}
														this.rY4Qr3WmLm.actionState = "run";
														if (239219 - 374890 == -135670)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (286199 - 94401 == 191799)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (137054 - 174243 == -37188)
														{
															continue;
														}
														this.animation.Play("run");
														if (110149 - 427185 == -317035)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (37828 - 320235 != -282406)
														{
															goto IL_6F7;
														}
														continue;
													}
												}
											}
										}
										this.rY4Qr3WmLm.actionState = "standby";
										if (49352 - 122186 == -72833)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (19508 - 488031 != -468523)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (28681 - 87488 != -58807)
											{
												continue;
											}
											num = (float)0;
											if (31086 - 473213 == -442126)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (258384 - 565332 == -306947)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (174042 - 410681 == -236638)
										{
											continue;
										}
									}
									IL_6F7:;
								}
								else
								{
									vector = global::Math.vFlat(this.rY4Qr3WmLm.nPosition - this.transform.position);
									if (274245 - 222504 != 51741)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (42366 - 529014 == -486647)
									{
										continue;
									}
									if (this.rY4Qr3WmLm.nSpeed != (float)0)
									{
										if (148763 - 232261 != -83498)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (270394 - 55916 == 214479)
											{
												continue;
											}
											this.transform.position = this.rY4Qr3WmLm.nPosition;
											if (103873 - 214047 != -110174)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (57437 - 272625 != -215188)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (188126 - 324409 != -136283)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (9365 - 528833 == -519467)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.rY4Qr3WmLm.nSpeed, (float)10 * Time.deltaTime);
												if (185889 - 247729 == -61839)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (223699 - 75468 != 148231)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (245925 - 265402 != -19477)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (287461 - 590878 != -303417)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (104391 - 474345 == -369953)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (51456 - 503356 != -451900)
											{
												continue;
											}
										}
										else if (Time.time > this.rY4Qr3WmLm.nSpeed + 0.3f)
										{
											if (48165 - 163944 == -115778)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (272863 - 33574 != 239289)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (56122 - 17496 != 38626)
												{
													continue;
												}
												num = (float)0;
												if (194970 - 395684 != -200714)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.rY4Qr3WmLm.nDirection);
											if (296749 - 212163 == 84587)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (271471 - 497896 == -226424)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (223186 - 240899 != -17713)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (71141 - 67696 != 3445)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (117376 - 566530 == -449153)
											{
												continue;
											}
											this.transform.position = this.rY4Qr3WmLm.nPosition;
											if (288855 - 507899 != -219044)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (135725 - 259755 != -124030)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (181879 - 241721 == -59841)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (149080 - 163323 != -14243)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (1612 - 467498 == -465885)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (110974 - 220568 != -109594)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (39329 - 548291 == -508961)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (249797 - 319858 == -70060)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.rY4Qr3WmLm.nDirection);
											if (260181 - 158838 == 101344)
											{
												continue;
											}
											num = (float)0;
											if (275479 - 58850 == 216630)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (156015 - 574784 == -418768)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (79276 - 505647 == -426370)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (21807 - 230327 != -208520)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (108941 - 340355 == -231413)
										{
											continue;
										}
									}
								}
								this.rY4Qr3WmLm.vMovement = vector;
								if (45531 - 485048 == -439517)
								{
									this.rY4Qr3WmLm.moveSpeed = num;
									if (83516 - 421077 == -337561)
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

	// Token: 0x060008D9 RID: 2265 RVA: 0x000E7D14 File Offset: 0x000E5F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (288940 - 302119 != -13179)
		{
		}
		for (;;)
		{
			if (!this.rY4Qr3WmLm.isMine)
			{
				if (66723 - 184495 != -117771)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (113238 - 91938 == 21300)
				{
					Vector3 vector = a - this.transform.position;
					if (244873 - 436890 == -192017)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (102519 - 106268 != -3748)
						{
							CharacterControl characterControl = null;
							if (222535 - 131214 == 91321)
							{
								int tID = 0;
								if (252403 - 168358 == 84045)
								{
									if (gameObject)
									{
										if (253156 - 66110 != 187046)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (269210 - 25676 != 243534)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (203696 - 316488 != -112792)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (298928 - 455501 == -156572)
										{
											continue;
										}
									}
									if (!(this.rY4Qr3WmLm.actionState == "standby"))
									{
										if (76007 - 39606 == 36402)
										{
											continue;
										}
										if (!(this.rY4Qr3WmLm.actionState == "run"))
										{
											break;
										}
										if (188868 - 4133 == 184736)
										{
											continue;
										}
									}
									if (this.rY4Qr3WmLm.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (271438 - 41303 != 230136)
									{
										eRangerBugType eRangerBugType = this.rangerBugType;
										if (241962 - 106278 != 135685)
										{
											if (eRangerBugType == eRangerBugType.red)
											{
												if (58997 - 128529 == -69532)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack_red(this.transform.position, vector, tID));
													if (89895 - 440862 == -350967)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (188113 - 158503 != 29611)
														{
															this.ActionEvent("RPC_nAttack_red", this.transform.position, vector, tID);
															if (170253 - 4486 != 165768)
															{
																break;
															}
														}
													}
												}
											}
											else if (eRangerBugType == eRangerBugType.yellow)
											{
												if (291995 - 98758 != 193238)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack_yellow(this.transform.position, vector, tID));
													if (44152 - 315298 != -271145)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (50743 - 239690 == -188947)
														{
															this.ActionEvent("RPC_nAttack_yellow", this.transform.position, vector, tID);
															if (67333 - 287479 == -220146)
															{
																break;
															}
														}
													}
												}
											}
											else if (eRangerBugType == eRangerBugType.pink)
											{
												if (28407 - 325240 != -296832)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack_pink(this.transform.position, vector, tID));
													if (11627 - 595783 == -584156)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (84778 - 78334 != 6445)
														{
															this.ActionEvent("RPC_nAttack_pink", this.transform.position, vector, tID);
															if (237578 - 154769 != 82810)
															{
																break;
															}
														}
													}
												}
											}
											else if (eRangerBugType == eRangerBugType.blue)
											{
												if (200618 - 441727 != -241108)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack_blue(this.transform.position, vector, tID));
													if (25592 - 117149 == -91557)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (205805 - 36390 != 169416)
														{
															this.ActionEvent("RPC_nAttack_blue", this.transform.position, vector, tID);
															if (90476 - 49760 == 40716)
															{
																break;
															}
														}
													}
												}
											}
											else
											{
												if (eRangerBugType != eRangerBugType.black)
												{
													break;
												}
												if (94599 - 440010 != -345410)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack_black(this.transform.position, vector, 0));
													if (22144 - 322218 != -300073)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (200502 - 345169 == -144667)
														{
															this.ActionEvent("RPC_nAttack_black", this.transform.position, vector, 0);
															if (205783 - 452114 == -246331)
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

	// Token: 0x060008DA RID: 2266 RVA: 0x000E8324 File Offset: 0x000E6524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (57918 - 145295 != -87376)
		{
		}
		for (;;)
		{
			if (!this.rY4Qr3WmLm.isMine)
			{
				if (236569 - 366048 != -129478)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (113275 - 195679 != -82403)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (49785 - 2619 == 47166)
					{
						Vector3 normalized = vector.normalized;
						if (1844 - 573389 == -571545)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (55806 - 430300 != -374493)
							{
								CharacterControl characterControl = null;
								if (138809 - 379203 != -240393)
								{
									if (189411 - 181280 == 8131)
									{
										if (gameObject)
										{
											if (137439 - 510408 != -372969)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (137729 - 154122 == -16392)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (46887 - 240816 != -193929)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (91980 - 264329 == -172348)
											{
												continue;
											}
										}
										if (!(this.rY4Qr3WmLm.actionState == "standby"))
										{
											if (134170 - 502683 != -368513)
											{
												continue;
											}
											if (!(this.rY4Qr3WmLm.actionState == "run"))
											{
												break;
											}
											if (110037 - 451151 != -341114)
											{
												continue;
											}
										}
										if (this.rY4Qr3WmLm.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (147213 - 39506 == 107707)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (173773 - 42387 != 131387)
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

	// Token: 0x060008DB RID: 2267 RVA: 0x000E85F0 File Offset: 0x000E67F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x000E85F4 File Offset: 0x000E67F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_red(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerBug.$RPC_nAttack_red$16787(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x000E8604 File Offset: 0x000E6804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_red_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (64165 - 403263 != -339097)
		{
		}
		for (;;)
		{
			if (this.nAttack_red_hit)
			{
				if (228570 - 597114 != -368544)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_red_hit, hitPos, Quaternion.identity);
				if (30958 - 434372 == -403413)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_red_hit effect");
				if (72079 - 265713 == -193633)
				{
					continue;
				}
			}
			if (Time.time <= this.BZGQxknsNs)
			{
				break;
			}
			if (139343 - 213073 != -73729)
			{
				this.BZGQxknsNs = Time.time + 0.1f;
				if (285073 - 436016 == -150943)
				{
					if (!this.nAttack_red_hitFX)
					{
						break;
					}
					if (181953 - 268401 == -86448)
					{
						this.audio.PlayOneShot(this.nAttack_red_hitFX);
						if (245289 - 247075 == -1786)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x000E8768 File Offset: 0x000E6968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_yellow(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerBug.$RPC_nAttack_yellow$16800(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x000E8778 File Offset: 0x000E6978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_yellow_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (97010 - 450009 != -352999)
		{
		}
		for (;;)
		{
			if (this.nAttack_yellow_hit)
			{
				if (75303 - 189869 != -114566)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_yellow_hit, hitPos, Quaternion.identity);
				if (161547 - 515474 != -353927)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_yellow_hit effect");
				if (161108 - 498033 != -336925)
				{
					continue;
				}
			}
			if (Time.time <= this.RJFQTG2h1I)
			{
				break;
			}
			if (127284 - 119270 != 8015)
			{
				this.RJFQTG2h1I = Time.time + 0.1f;
				if (71940 - 447582 != -375641)
				{
					if (!this.nAttack_yellow_hitFX)
					{
						break;
					}
					if (190107 - 308896 == -118789)
					{
						this.audio.PlayOneShot(this.nAttack_yellow_hitFX);
						if (138138 - 62453 == 75685)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x000E88DC File Offset: 0x000E6ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_pink(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerBug.$RPC_nAttack_pink$16814(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x000E88EC File Offset: 0x000E6AEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_blue(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerBug.$RPC_nAttack_blue$16825(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x000E88FC File Offset: 0x000E6AFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_black(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerBug.$RPC_nAttack_black$16839(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x000E890C File Offset: 0x000E6B0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_summon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerBug.$RPC_summon$16850(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x000E891C File Offset: 0x000E6B1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new RangerBug.$RPC_ko$16857(nArray, this).GetEnumerator();
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x000E892C File Offset: 0x000E6B2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new RangerBug.$RPC_dead$16864(nArray, this).GetEnumerator();
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x000E893C File Offset: 0x000E6B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x000E8940 File Offset: 0x000E6B40
	internal static bool PwZ4PIQDYxyB74eWB63()
	{
		return true;
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x000E8944 File Offset: 0x000E6B44
	internal static bool nqgj2wQvVCV4ljHEcV7()
	{
		return false;
	}

	// Token: 0x040007EE RID: 2030
	public eRangerBugType rangerBugType;

	// Token: 0x040007EF RID: 2031
	private CharacterControl rY4Qr3WmLm;

	// Token: 0x040007F0 RID: 2032
	public GameObject nAttack_red_ring;

	// Token: 0x040007F1 RID: 2033
	public GameObject nAttack_red_hit;

	// Token: 0x040007F2 RID: 2034
	public AudioClip nAttack_red_hitFX;

	// Token: 0x040007F3 RID: 2035
	private float BZGQxknsNs;

	// Token: 0x040007F4 RID: 2036
	public GameObject nAttack_yellow_ring;

	// Token: 0x040007F5 RID: 2037
	public GameObject nAttack_yellow_hit;

	// Token: 0x040007F6 RID: 2038
	public AudioClip nAttack_yellow_hitFX;

	// Token: 0x040007F7 RID: 2039
	private float RJFQTG2h1I;

	// Token: 0x040007F8 RID: 2040
	public GameObject nAttack_pink_ring;

	// Token: 0x040007F9 RID: 2041
	public GameObject nAttack_pink_hit;

	// Token: 0x040007FA RID: 2042
	public GameObject nAttack_blue_ring;

	// Token: 0x040007FB RID: 2043
	public GameObject nAttack_blue_hit;

	// Token: 0x040007FC RID: 2044
	public GameObject nAttack_black_ring;

	// Token: 0x040007FD RID: 2045
	public GameObject summon_ring;

	// Token: 0x040007FE RID: 2046
	public GameObject deadEffect;

	// Token: 0x0200018A RID: 394
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_red$16787 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060008E9 RID: 2281 RVA: 0x000E8948 File Offset: 0x000E6B48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_red$16787(Vector3 mPos, Vector3 tDir, RangerBug self_)
		{
			if (276568 - 544628 != -268059)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (38373 - 465873 == -427500)
				{
					base..ctor();
					if (8137 - 488949 == -480812)
					{
						this.$mPos$16797 = mPos;
						if (149119 - 577571 != -428451)
						{
							this.$tDir$16798 = tDir;
							if (229975 - 166224 == 63751)
							{
								this.$self_$16799 = self_;
								if (150105 - 421355 == -271250)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x000E8A24 File Offset: 0x000E6C24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerBug.$RPC_nAttack_red$16787.$(this.$mPos$16797, this.$tDir$16798, this.$self_$16799);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000E8A40 File Offset: 0x000E6C40
		internal static bool a0NkaWQR0F8kaefa5pW()
		{
			return true;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000E8A44 File Offset: 0x000E6C44
		internal static bool TED16uQwPQGhbanRJye()
		{
			return false;
		}

		// Token: 0x040007FF RID: 2047
		internal Vector3 $mPos$16797;

		// Token: 0x04000800 RID: 2048
		internal Vector3 $tDir$16798;

		// Token: 0x04000801 RID: 2049
		internal RangerBug $self_$16799;

		// Token: 0x0200018B RID: 395
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060008ED RID: 2285 RVA: 0x000E8A48 File Offset: 0x000E6C48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerBug self_)
			{
				if (58638 - 104616 != -45977)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211377 - 471074 == -259697)
					{
						base..ctor();
						if (232567 - 270819 == -38252)
						{
							this.$mPos$16794 = mPos;
							if (21925 - 293289 != -271363)
							{
								this.$tDir$16795 = tDir;
								if (91539 - 565513 != -473973)
								{
									this.$self_$16796 = self_;
									if (59275 - 347960 == -288685)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060008EE RID: 2286 RVA: 0x000E8B24 File Offset: 0x000E6D24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (190915 - 428667 != -237751)
				{
				}
				for (;;)
				{
					IL_6BD:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_95B;
					case 2:
						if (this.$self_$16796.rY4Qr3WmLm.actionState != "attack")
						{
							goto IL_399;
						}
						if (183857 - 458102 != -274245)
						{
							continue;
						}
						if (this.$self_$16796.rY4Qr3WmLm.myCommand != "nAttack_red")
						{
							if (287715 - 178105 != 109610)
							{
								continue;
							}
							goto IL_399;
						}
						else
						{
							this.$self_$16796.rY4Qr3WmLm.moveSpeed = (float)0;
							if (5012 - 496656 == -491643)
							{
								continue;
							}
							if (!this.$self_$16796.rY4Qr3WmLm.isMine)
							{
								goto IL_90C;
							}
							if (49274 - 58556 == -9281)
							{
								continue;
							}
							this.$hitLayer$16788 = 130816 - (1 << this.$self_$16796.gameObject.layer);
							if (299409 - 423971 != -124562)
							{
								continue;
							}
							this.$hitList$16789 = Damage.FindRecTarget(this.$self_$16796.transform.position, this.$self_$16796.transform.forward, (float)1, (float)1, (float)6, (float)1, this.$hitLayer$16788);
							if (658 - 18815 == -18156)
							{
								continue;
							}
							this.$$iterator$9991$16793 = UnityRuntimeServices.GetEnumerator(this.$hitList$16789);
							if (168677 - 563600 != -394923)
							{
								continue;
							}
							while (this.$$iterator$9991$16793.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9991$16793.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16790 = (GameObject)obj2;
								if (86647 - 165276 != -78629)
								{
									goto IL_6BD;
								}
								if (this.$self_$16796.rY4Qr3WmLm.hit(1, this.$hitObject$16790, 3 * this.$self_$16796.rY4Qr3WmLm.atk, 10, 0, 0.5f * this.$self_$16796.transform.forward) != 0)
								{
									if (268332 - 111669 == 156664)
									{
										goto IL_6BD;
									}
									this.$hitPoint$16791 = this.$hitObject$16790.collider.ClosestPointOnBounds(this.$self_$16796.transform.position + Vector3.up);
									if (87406 - 297874 == -210467)
									{
										goto IL_6BD;
									}
									UnityRuntimeServices.Update(this.$$iterator$9991$16793, this.$hitObject$16790);
									if (289670 - 28532 == 261139)
									{
										goto IL_6BD;
									}
									this.$tChar$16792 = (CharacterControl)this.$hitObject$16790.GetComponent(typeof(CharacterControl));
									if (5593 - 322315 != -316722)
									{
										goto IL_6BD;
									}
									UnityRuntimeServices.Update(this.$$iterator$9991$16793, this.$hitObject$16790);
									if (220973 - 353035 != -132062)
									{
										goto IL_6BD;
									}
									if (this.$tChar$16792)
									{
										if (14963 - 122809 == -107845)
										{
											goto IL_6BD;
										}
										this.$tChar$16792.RPC_AddStatus("armorBreak", 4, Damage.getDebuff((float)15, this.$self_$16796.rY4Qr3WmLm.cha, this.$tChar$16792.cha), 0, this.$self_$16796.rY4Qr3WmLm.ActorNr);
										if (148691 - 203717 != -55026)
										{
											goto IL_6BD;
										}
									}
									this.$self_$16796.RPC_nAttack_red_hit(this.$hitPoint$16791, this.$self_$16796.transform.forward, 0);
									if (248376 - 444301 == -195924)
									{
										goto IL_6BD;
									}
									this.$self_$16796.ActionEvent("RPC_nAttack_red_hit", this.$hitPoint$16791, this.$self_$16796.transform.forward, 0);
									if (74444 - 286505 != -212061)
									{
										goto IL_6BD;
									}
								}
							}
							if (296536 - 579363 != -282826)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16796.rY4Qr3WmLm.actionState == "attack")
						{
							if (99390 - 568555 == -469164)
							{
								continue;
							}
							if (this.$self_$16796.rY4Qr3WmLm.myCommand == "nAttack_red")
							{
								if (194460 - 265823 != -71363)
								{
									continue;
								}
								this.$self_$16796.rY4Qr3WmLm.actionState = "standby";
								if (137019 - 197008 == -59988)
								{
									continue;
								}
								this.$self_$16796.rY4Qr3WmLm.actionTime = Time.time;
								if (180633 - 329347 == -148713)
								{
									continue;
								}
								this.$self_$16796.rY4Qr3WmLm.myCommand = "none";
								if (80798 - 451044 != -370246)
								{
									continue;
								}
								if (!this.$self_$16796.rY4Qr3WmLm.isMine)
								{
									if (155827 - 201361 == -45533)
									{
										continue;
									}
									this.$self_$16796.rY4Qr3WmLm.nPosition = this.$self_$16796.transform.position;
									if (277827 - 408815 == -130987)
									{
										continue;
									}
									this.$self_$16796.rY4Qr3WmLm.oPosition = this.$self_$16796.transform.position;
									if (27897 - 206533 != -178636)
									{
										continue;
									}
									this.$self_$16796.rY4Qr3WmLm.nDirection = this.$self_$16796.transform.forward;
									if (107184 - 143441 != -36257)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (30575 - 581229 != -550654)
						{
							continue;
						}
						goto IL_95B;
					default:
						if (204861 - 216136 != -11275)
						{
							continue;
						}
						break;
					}
					this.$self_$16796.rY4Qr3WmLm.actionState = "attack";
					if (156527 - 406245 == -249718)
					{
						this.$self_$16796.rY4Qr3WmLm.actionTime = Time.time;
						if (44683 - 103922 != -59238)
						{
							this.$self_$16796.rY4Qr3WmLm.myCommand = "nAttack_red";
							if (82449 - 244043 != -161593)
							{
								this.$self_$16796.rY4Qr3WmLm.addTimeOut("nAttack", (float)3);
								if (83238 - 511745 == -428507)
								{
									this.$self_$16796.transform.position = this.$mPos$16794;
									if (212418 - 480473 == -268055)
									{
										this.$self_$16796.transform.LookAt(this.$mPos$16794 + global::Math.vFlat(this.$tDir$16795));
										if (215305 - 70451 == 144854)
										{
											this.$self_$16796.animation.CrossFade("nAttack");
											if (234698 - 410301 == -175603)
											{
												this.$self_$16796.animation.wrapMode = WrapMode.Once;
												if (30892 - 538810 == -507918)
												{
													this.$self_$16796.rY4Qr3WmLm.vMovement = this.$self_$16796.transform.forward;
													if (53283 - 492314 != -439030)
													{
														this.$self_$16796.rY4Qr3WmLm.moveSpeed = (float)4;
														if (254766 - 123813 != 130954)
														{
															if (this.$self_$16796.nAttack_red_ring)
															{
																if (55445 - 458347 == -402902)
																{
																	this.$self_$16796.rY4Qr3WmLm.createEffect(this.$self_$16796.nAttack_red_ring, this.$self_$16796.transform.position, this.$self_$16796.transform.rotation);
																	if (296921 - 196811 != 100111)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_red ring effect");
																if (97420 - 198709 == -101289)
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
				IL_F6:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_16:
				goto IL_90C;
				goto IL_F6;
				IL_399:
				goto IL_95B;
				IL_90C:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_95B:
				return false;
			}

			// Token: 0x060008EF RID: 2287 RVA: 0x000E94A0 File Offset: 0x000E76A0
			internal static bool ah4h9vQqw4MEs3P7NWX()
			{
				return true;
			}

			// Token: 0x060008F0 RID: 2288 RVA: 0x000E94A4 File Offset: 0x000E76A4
			internal static bool AJfCikQ7rcke54JiZEj()
			{
				return false;
			}

			// Token: 0x04000802 RID: 2050
			internal int $hitLayer$16788;

			// Token: 0x04000803 RID: 2051
			internal UnityScript.Lang.Array $hitList$16789;

			// Token: 0x04000804 RID: 2052
			internal GameObject $hitObject$16790;

			// Token: 0x04000805 RID: 2053
			internal Vector3 $hitPoint$16791;

			// Token: 0x04000806 RID: 2054
			internal CharacterControl $tChar$16792;

			// Token: 0x04000807 RID: 2055
			internal IEnumerator $$iterator$9991$16793;

			// Token: 0x04000808 RID: 2056
			internal Vector3 $mPos$16794;

			// Token: 0x04000809 RID: 2057
			internal Vector3 $tDir$16795;

			// Token: 0x0400080A RID: 2058
			internal RangerBug $self_$16796;
		}
	}

	// Token: 0x0200018C RID: 396
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_yellow$16800 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x000E94A8 File Offset: 0x000E76A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_yellow$16800(Vector3 mPos, Vector3 tDir, RangerBug self_)
		{
			if (208285 - 554536 != -346251)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (279121 - 436817 == -157696)
				{
					base..ctor();
					if (201677 - 136425 == 65252)
					{
						this.$mPos$16811 = mPos;
						if (23407 - 279583 == -256176)
						{
							this.$tDir$16812 = tDir;
							if (56567 - 547754 == -491187)
							{
								this.$self_$16813 = self_;
								if (79061 - 209386 == -130325)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000E9584 File Offset: 0x000E7784
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerBug.$RPC_nAttack_yellow$16800.$(this.$mPos$16811, this.$tDir$16812, this.$self_$16813);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000E95A0 File Offset: 0x000E77A0
		internal static bool AuH4OyQP3sF1TNoTsXi()
		{
			return true;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000E95A4 File Offset: 0x000E77A4
		internal static bool v3BFMKQ0viuaju80qVq()
		{
			return false;
		}

		// Token: 0x0400080B RID: 2059
		internal Vector3 $mPos$16811;

		// Token: 0x0400080C RID: 2060
		internal Vector3 $tDir$16812;

		// Token: 0x0400080D RID: 2061
		internal RangerBug $self_$16813;

		// Token: 0x0200018D RID: 397
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060008F5 RID: 2293 RVA: 0x000E95A8 File Offset: 0x000E77A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerBug self_)
			{
				if (130513 - 142603 != -12089)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (20565 - 315211 == -294646)
					{
						base..ctor();
						if (159167 - 569464 != -410296)
						{
							this.$mPos$16808 = mPos;
							if (188986 - 419462 == -230476)
							{
								this.$tDir$16809 = tDir;
								if (130204 - 548144 == -417940)
								{
									this.$self_$16810 = self_;
									if (67491 - 323461 == -255970)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060008F6 RID: 2294 RVA: 0x000E9684 File Offset: 0x000E7884
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (42930 - 194149 != -151219)
				{
				}
				for (;;)
				{
					IL_2C8:
					switch (this._state)
					{
					case 0:
						goto IL_603;
					case 1:
						goto IL_A4A;
					case 2:
						if (this.$self_$16810.rY4Qr3WmLm.actionState != "attack")
						{
							goto IL_8DC;
						}
						if (37250 - 578583 != -541333)
						{
							continue;
						}
						if (this.$self_$16810.rY4Qr3WmLm.myCommand != "nAttack_yellow")
						{
							if (59689 - 225416 != -165727)
							{
								continue;
							}
							goto IL_8DC;
						}
						else
						{
							this.$self_$16810.rY4Qr3WmLm.moveSpeed = (float)0;
							if (205557 - 542767 == -337209)
							{
								continue;
							}
							this.$i$16801 = 0;
							if (124429 - 306461 != -182032)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$16810.rY4Qr3WmLm.actionState != "attack")
						{
							goto IL_74C;
						}
						if (171987 - 242675 == -70687)
						{
							continue;
						}
						if (this.$self_$16810.rY4Qr3WmLm.myCommand != "nAttack_yellow")
						{
							if (114478 - 552902 != -438423)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$i$16801++;
							if (10261 - 544457 != -534196)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$16810.rY4Qr3WmLm.actionState == "attack")
						{
							if (100698 - 556586 != -455888)
							{
								continue;
							}
							if (this.$self_$16810.rY4Qr3WmLm.myCommand == "nAttack_yellow")
							{
								if (216361 - 308208 == -91846)
								{
									continue;
								}
								this.$self_$16810.rY4Qr3WmLm.actionState = "standby";
								if (287661 - 177508 != 110153)
								{
									continue;
								}
								this.$self_$16810.rY4Qr3WmLm.actionTime = Time.time;
								if (125012 - 213479 != -88467)
								{
									continue;
								}
								this.$self_$16810.rY4Qr3WmLm.myCommand = "none";
								if (248901 - 498037 != -249136)
								{
									continue;
								}
								if (!this.$self_$16810.rY4Qr3WmLm.isMine)
								{
									if (155164 - 290605 == -135440)
									{
										continue;
									}
									this.$self_$16810.rY4Qr3WmLm.nPosition = this.$self_$16810.transform.position;
									if (187566 - 236724 == -49157)
									{
										continue;
									}
									this.$self_$16810.rY4Qr3WmLm.oPosition = this.$self_$16810.transform.position;
									if (123174 - 445241 != -322067)
									{
										continue;
									}
									this.$self_$16810.rY4Qr3WmLm.nDirection = this.$self_$16810.transform.forward;
									if (236468 - 298442 != -61974)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (57890 - 419347 != -361456)
						{
							goto Block_60;
						}
						continue;
					default:
						if (95186 - 242820 != -147633)
						{
							goto IL_603;
						}
						continue;
					}
					if (this.$i$16801 >= 2)
					{
						if (5527 - 1969 != 3559)
						{
							goto Block_63;
						}
						continue;
					}
					else
					{
						if (!this.$self_$16810.rY4Qr3WmLm.isMine)
						{
							goto IL_837;
						}
						if (112308 - 160966 != -48658)
						{
							continue;
						}
						this.$hitLayer$16802 = 130816 - (1 << this.$self_$16810.gameObject.layer);
						if (30095 - 578102 != -548007)
						{
							continue;
						}
						this.$hitList$16803 = Damage.FindRecTarget(this.$self_$16810.transform.position, this.$self_$16810.transform.forward, (float)2, (float)2, (float)3, (float)12, this.$hitLayer$16802);
						if (295702 - 355000 != -59298)
						{
							continue;
						}
						this.$$iterator$9992$16807 = UnityRuntimeServices.GetEnumerator(this.$hitList$16803);
						if (181038 - 484376 == -303337)
						{
							continue;
						}
						while (this.$$iterator$9992$16807.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$9992$16807.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$16804 = (GameObject)obj2;
							if (192393 - 516809 != -324416)
							{
								goto IL_2C8;
							}
							if (this.$self_$16810.rY4Qr3WmLm.hit(1, this.$hitObject$16804, 2 * this.$self_$16810.rY4Qr3WmLm.atk, 5, 0, Vector3.zero) != 0)
							{
								if (81900 - 315926 == -234025)
								{
									goto IL_2C8;
								}
								this.$hitPoint$16805 = this.$hitObject$16804.collider.ClosestPointOnBounds(this.$self_$16810.transform.position + Vector3.up);
								if (121852 - 134299 == -12446)
								{
									goto IL_2C8;
								}
								UnityRuntimeServices.Update(this.$$iterator$9992$16807, this.$hitObject$16804);
								if (29244 - 390563 != -361319)
								{
									goto IL_2C8;
								}
								this.$tChar$16806 = (CharacterControl)this.$hitObject$16804.GetComponent(typeof(CharacterControl));
								if (133598 - 483449 != -349851)
								{
									goto IL_2C8;
								}
								UnityRuntimeServices.Update(this.$$iterator$9992$16807, this.$hitObject$16804);
								if (209327 - 471777 == -262449)
								{
									goto IL_2C8;
								}
								if (this.$tChar$16806)
								{
									if (287023 - 161922 == 125102)
									{
										goto IL_2C8;
									}
									this.$tChar$16806.RPC_AddStatus("paralysis", 1, Damage.getDebuff((float)3, this.$self_$16810.rY4Qr3WmLm.cha, this.$tChar$16806.cha), 0, this.$self_$16810.rY4Qr3WmLm.ActorNr);
									if (222128 - 77989 != 144139)
									{
										goto IL_2C8;
									}
								}
								this.$self_$16810.RPC_nAttack_yellow_hit(this.$hitPoint$16805, this.$self_$16810.transform.forward, 0);
								if (98061 - 323255 != -225194)
								{
									goto IL_2C8;
								}
								this.$self_$16810.ActionEvent("RPC_nAttack_yellow_hit", this.$hitPoint$16805, this.$self_$16810.transform.forward, 0);
								if (172842 - 411206 != -238364)
								{
									goto IL_2C8;
								}
							}
						}
						if (118442 - 60453 != 57990)
						{
							goto Block_53;
						}
						continue;
					}
					IL_603:
					this.$self_$16810.rY4Qr3WmLm.actionState = "attack";
					if (47760 - 425954 == -378194)
					{
						this.$self_$16810.rY4Qr3WmLm.actionTime = Time.time;
						if (256678 - 597443 != -340764)
						{
							this.$self_$16810.rY4Qr3WmLm.myCommand = "nAttack_yellow";
							if (254712 - 151102 == 103610)
							{
								this.$self_$16810.rY4Qr3WmLm.addTimeOut("nAttack", (float)3);
								if (197982 - 387241 == -189259)
								{
									this.$self_$16810.transform.position = this.$mPos$16808;
									if (265764 - 460507 != -194742)
									{
										this.$self_$16810.transform.LookAt(this.$mPos$16808 + global::Math.vFlat(this.$tDir$16809));
										if (277429 - 165775 == 111654)
										{
											this.$self_$16810.animation.CrossFade("nAttack");
											if (20712 - 52687 != -31974)
											{
												this.$self_$16810.animation.wrapMode = WrapMode.Once;
												if (82077 - 121072 == -38995)
												{
													this.$self_$16810.rY4Qr3WmLm.vMovement = this.$self_$16810.transform.forward;
													if (247216 - 464010 == -216794)
													{
														this.$self_$16810.rY4Qr3WmLm.moveSpeed = (float)4;
														if (239905 - 430240 == -190335)
														{
															if (this.$self_$16810.nAttack_yellow_ring)
															{
																if (259534 - 491488 == -231954)
																{
																	this.$self_$16810.rY4Qr3WmLm.createEffect(this.$self_$16810.nAttack_yellow_ring, this.$self_$16810.transform.position, this.$self_$16810.transform.rotation);
																	if (242304 - 489591 == -247287)
																	{
																		goto IL_6CD;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_yellow ring effect");
																if (190325 - 186915 == 3410)
																{
																	goto IL_632;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_13:
				goto IL_74C;
				IL_632:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_6CD:
				goto IL_632;
				IL_74C:
				goto IL_A4A;
				IL_837:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_8DC:
				goto IL_A4A;
				Block_53:
				goto IL_837;
				Block_60:
				goto IL_A4A;
				Block_63:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_A4A:
				return false;
			}

			// Token: 0x060008F7 RID: 2295 RVA: 0x000EA0F0 File Offset: 0x000E82F0
			internal static bool lXaks1QbFeNhUAtl6EA()
			{
				return true;
			}

			// Token: 0x060008F8 RID: 2296 RVA: 0x000EA0F4 File Offset: 0x000E82F4
			internal static bool gT2pPYQu0B6sx5kIIyp()
			{
				return false;
			}

			// Token: 0x0400080E RID: 2062
			internal int $i$16801;

			// Token: 0x0400080F RID: 2063
			internal int $hitLayer$16802;

			// Token: 0x04000810 RID: 2064
			internal UnityScript.Lang.Array $hitList$16803;

			// Token: 0x04000811 RID: 2065
			internal GameObject $hitObject$16804;

			// Token: 0x04000812 RID: 2066
			internal Vector3 $hitPoint$16805;

			// Token: 0x04000813 RID: 2067
			internal CharacterControl $tChar$16806;

			// Token: 0x04000814 RID: 2068
			internal IEnumerator $$iterator$9992$16807;

			// Token: 0x04000815 RID: 2069
			internal Vector3 $mPos$16808;

			// Token: 0x04000816 RID: 2070
			internal Vector3 $tDir$16809;

			// Token: 0x04000817 RID: 2071
			internal RangerBug $self_$16810;
		}
	}

	// Token: 0x0200018E RID: 398
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_pink$16814 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060008F9 RID: 2297 RVA: 0x000EA0F8 File Offset: 0x000E82F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_pink$16814(Vector3 mPos, Vector3 tDir, int tID, RangerBug self_)
		{
			if (23960 - 549478 != -525518)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (72002 - 432984 != -360981)
				{
					base..ctor();
					if (277398 - 207574 == 69824)
					{
						this.$mPos$16821 = mPos;
						if (12777 - 195026 != -182248)
						{
							this.$tDir$16822 = tDir;
							if (24363 - 85031 == -60668)
							{
								this.$tID$16823 = tID;
								if (206731 - 579411 == -372680)
								{
									this.$self_$16824 = self_;
									if (281490 - 21564 == 259926)
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

		// Token: 0x060008FA RID: 2298 RVA: 0x000EA1F8 File Offset: 0x000E83F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerBug.$RPC_nAttack_pink$16814.$(this.$mPos$16821, this.$tDir$16822, this.$tID$16823, this.$self_$16824);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000EA218 File Offset: 0x000E8418
		internal static bool sxrGHiQI3apE6fRycBB()
		{
			return true;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000EA21C File Offset: 0x000E841C
		internal static bool BRtvIUQBXQx03wVqb8n()
		{
			return false;
		}

		// Token: 0x04000818 RID: 2072
		internal Vector3 $mPos$16821;

		// Token: 0x04000819 RID: 2073
		internal Vector3 $tDir$16822;

		// Token: 0x0400081A RID: 2074
		internal int $tID$16823;

		// Token: 0x0400081B RID: 2075
		internal RangerBug $self_$16824;

		// Token: 0x0200018F RID: 399
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060008FD RID: 2301 RVA: 0x000EA220 File Offset: 0x000E8420
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, RangerBug self_)
			{
				if (95069 - 110447 != -15378)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126067 - 139791 != -13723)
					{
						base..ctor();
						if (117021 - 355130 == -238109)
						{
							this.$mPos$16817 = mPos;
							if (57031 - 330284 == -273253)
							{
								this.$tDir$16818 = tDir;
								if (52992 - 168848 != -115855)
								{
									this.$tID$16819 = tID;
									if (24388 - 589135 == -564747)
									{
										this.$self_$16820 = self_;
										if (173881 - 596457 == -422576)
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

			// Token: 0x060008FE RID: 2302 RVA: 0x000EA320 File Offset: 0x000E8520
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (164636 - 314690 != -150054)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_82B;
					case 2:
						if (this.$self_$16820.rY4Qr3WmLm.actionState != "attack")
						{
							goto IL_6C8;
						}
						if (231417 - 370158 != -138741)
						{
							continue;
						}
						if (this.$self_$16820.rY4Qr3WmLm.myCommand != "nAttack_pink")
						{
							if (290981 - 571142 != -280160)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							if (this.$self_$16820.nAttack_pink_ring)
							{
								if (276507 - 292238 == -15730)
								{
									continue;
								}
								this.$self_$16820.rY4Qr3WmLm.createEffect(this.$self_$16820.nAttack_pink_ring, this.$self_$16820.transform.position, this.$self_$16820.transform.rotation);
								if (218616 - 562860 == -344243)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack_pink ring effect");
								if (34519 - 475336 == -440816)
								{
									continue;
								}
							}
							this.$tObject$16815 = null;
							if (195575 - 67504 == 128072)
							{
								continue;
							}
							this.$tChar$16816 = null;
							if (151720 - 14999 != 136721)
							{
								continue;
							}
							if (this.$tID$16819 != 0)
							{
								if (280341 - 491787 == -211445)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$16819];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$16815 = (GameObject)obj2;
								if (112099 - 290970 != -178871)
								{
									continue;
								}
							}
							if (this.$tObject$16815)
							{
								if (273869 - 573089 == -299219)
								{
									continue;
								}
								this.$tChar$16816 = (CharacterControl)this.$tObject$16815.GetComponent(typeof(CharacterControl));
								if (261548 - 399783 != -138235)
								{
									continue;
								}
							}
							if (!this.$tChar$16816)
							{
								goto IL_1A;
							}
							if (178500 - 466960 == -288459)
							{
								continue;
							}
							if (this.$self_$16820.nAttack_pink_hit)
							{
								if (5988 - 32171 != -26183)
								{
									continue;
								}
								this.$tChar$16816.createEffect(this.$self_$16820.nAttack_pink_hit, this.$tChar$16816.transform.position, Quaternion.identity);
								if (27512 - 564058 == -536545)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find heal_ring Effect");
								if (38680 - 538068 == -499387)
								{
									continue;
								}
							}
							if (!this.$self_$16820.rY4Qr3WmLm.isMine)
							{
								goto IL_1A;
							}
							if (47699 - 16892 == 30808)
							{
								continue;
							}
							this.$tChar$16816.RPC_AddHeal(1, this.$self_$16820.rY4Qr3WmLm.talAdjust(100), 0, 0, 0, 0, this.$self_$16820.rY4Qr3WmLm.ActorNr);
							if (189788 - 93808 == 95981)
							{
								continue;
							}
							this.$tChar$16816.RPC_AddStatus("cleanse", 4, 6, 0, this.$self_$16820.rY4Qr3WmLm.ActorNr);
							if (251834 - 546407 != -294573)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 3:
						if (this.$self_$16820.rY4Qr3WmLm.actionState == "attack")
						{
							if (13196 - 557795 != -544599)
							{
								continue;
							}
							if (this.$self_$16820.rY4Qr3WmLm.myCommand == "nAttack_pink")
							{
								if (44300 - 134816 == -90515)
								{
									continue;
								}
								this.$self_$16820.rY4Qr3WmLm.actionState = "standby";
								if (211613 - 594456 == -382842)
								{
									continue;
								}
								this.$self_$16820.rY4Qr3WmLm.actionTime = Time.time;
								if (107283 - 268719 != -161436)
								{
									continue;
								}
								this.$self_$16820.rY4Qr3WmLm.myCommand = "none";
								if (228454 - 589056 != -360602)
								{
									continue;
								}
								if (!this.$self_$16820.rY4Qr3WmLm.isMine)
								{
									if (255815 - 329874 != -74059)
									{
										continue;
									}
									this.$self_$16820.rY4Qr3WmLm.nPosition = this.$self_$16820.transform.position;
									if (299587 - 282529 != 17058)
									{
										continue;
									}
									this.$self_$16820.rY4Qr3WmLm.oPosition = this.$self_$16820.transform.position;
									if (261484 - 37382 == 224103)
									{
										continue;
									}
									this.$self_$16820.rY4Qr3WmLm.nDirection = this.$self_$16820.transform.forward;
									if (198151 - 240211 == -42059)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (150950 - 374862 != -223912)
						{
							continue;
						}
						goto IL_82B;
					default:
						if (206849 - 502826 == -295976)
						{
							continue;
						}
						break;
					}
					this.$self_$16820.rY4Qr3WmLm.actionState = "attack";
					if (229697 - 229907 != -209)
					{
						this.$self_$16820.rY4Qr3WmLm.actionTime = Time.time;
						if (221626 - 247824 == -26198)
						{
							this.$self_$16820.rY4Qr3WmLm.myCommand = "nAttack_pink";
							if (166290 - 470874 == -304584)
							{
								this.$self_$16820.rY4Qr3WmLm.addTimeOut("nAttack", (float)3);
								if (188724 - 57301 != 131424)
								{
									this.$self_$16820.transform.position = this.$mPos$16817;
									if (79154 - 447347 == -368193)
									{
										this.$self_$16820.transform.LookAt(this.$mPos$16817 + global::Math.vFlat(this.$tDir$16818));
										if (73722 - 76057 != -2334)
										{
											this.$self_$16820.animation.CrossFade("nAttack");
											if (6777 - 292274 != -285496)
											{
												this.$self_$16820.animation.wrapMode = WrapMode.Once;
												if (238686 - 326187 == -87501)
												{
													this.$self_$16820.rY4Qr3WmLm.vMovement = this.$self_$16820.transform.forward;
													if (176362 - 119337 != 57026)
													{
														this.$self_$16820.rY4Qr3WmLm.moveSpeed = (float)0;
														if (159641 - 542955 == -383314)
														{
															goto IL_42B;
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_42B:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_6C8:
				Block_51:
				IL_82B:
				return false;
			}

			// Token: 0x060008FF RID: 2303 RVA: 0x000EAB6C File Offset: 0x000E8D6C
			internal static bool pqAAL3QeAyecBPNQNi3()
			{
				return true;
			}

			// Token: 0x06000900 RID: 2304 RVA: 0x000EAB70 File Offset: 0x000E8D70
			internal static bool zGg3MoQrJC2QvglpWag()
			{
				return false;
			}

			// Token: 0x0400081C RID: 2076
			internal GameObject $tObject$16815;

			// Token: 0x0400081D RID: 2077
			internal CharacterControl $tChar$16816;

			// Token: 0x0400081E RID: 2078
			internal Vector3 $mPos$16817;

			// Token: 0x0400081F RID: 2079
			internal Vector3 $tDir$16818;

			// Token: 0x04000820 RID: 2080
			internal int $tID$16819;

			// Token: 0x04000821 RID: 2081
			internal RangerBug $self_$16820;
		}
	}

	// Token: 0x02000190 RID: 400
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_blue$16825 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000901 RID: 2305 RVA: 0x000EAB74 File Offset: 0x000E8D74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_blue$16825(Vector3 mPos, Vector3 tDir, RangerBug self_)
		{
			if (130840 - 86690 != 44151)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (284405 - 396257 == -111852)
				{
					base..ctor();
					if (81489 - 142036 != -60546)
					{
						this.$mPos$16836 = mPos;
						if (77724 - 173749 != -96024)
						{
							this.$tDir$16837 = tDir;
							if (201208 - 266765 == -65557)
							{
								this.$self_$16838 = self_;
								if (198528 - 356155 != -157626)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000EAC50 File Offset: 0x000E8E50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerBug.$RPC_nAttack_blue$16825.$(this.$mPos$16836, this.$tDir$16837, this.$self_$16838);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000EAC6C File Offset: 0x000E8E6C
		internal static bool XG2jEKQjgr9xrRXyeSs()
		{
			return true;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000EAC70 File Offset: 0x000E8E70
		internal static bool BBoF13QhQ7VXAZ0lp0f()
		{
			return false;
		}

		// Token: 0x04000822 RID: 2082
		internal Vector3 $mPos$16836;

		// Token: 0x04000823 RID: 2083
		internal Vector3 $tDir$16837;

		// Token: 0x04000824 RID: 2084
		internal RangerBug $self_$16838;

		// Token: 0x02000191 RID: 401
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000905 RID: 2309 RVA: 0x000EAC74 File Offset: 0x000E8E74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerBug self_)
			{
				if (202578 - 387639 != -185060)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (85930 - 27052 == 58878)
					{
						base..ctor();
						if (215586 - 228073 == -12487)
						{
							this.$mPos$16833 = mPos;
							if (38299 - 101183 != -62883)
							{
								this.$tDir$16834 = tDir;
								if (299625 - 403106 != -103480)
								{
									this.$self_$16835 = self_;
									if (45572 - 397850 == -352278)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000906 RID: 2310 RVA: 0x000EAD50 File Offset: 0x000E8F50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169237 - 436127 != -266889)
				{
				}
				for (;;)
				{
					IL_2F5:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9CE;
					case 2:
						if (this.$self_$16835.rY4Qr3WmLm.actionState != "attack")
						{
							goto IL_1CB;
						}
						if (172935 - 523678 == -350742)
						{
							continue;
						}
						if (this.$self_$16835.rY4Qr3WmLm.myCommand != "nAttack_blue")
						{
							if (280632 - 555624 != -274991)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							this.$self_$16835.rY4Qr3WmLm.moveSpeed = (float)-3;
							if (59722 - 47296 == 12427)
							{
								continue;
							}
							if (this.$self_$16835.nAttack_blue_ring)
							{
								if (52955 - 402101 == -349145)
								{
									continue;
								}
								this.$self_$16835.rY4Qr3WmLm.createEffect(this.$self_$16835.nAttack_blue_ring, this.$self_$16835.transform.position, this.$self_$16835.transform.rotation);
								if (133897 - 518404 != -384507)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack_blue ring effect");
								if (31692 - 289731 != -258039)
								{
									continue;
								}
							}
							if (this.$self_$16835.nAttack_blue_hit)
							{
								if (119548 - 92383 != 27165)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16835.nAttack_blue_hit, this.$mPos$16833 + this.$tDir$16834, Quaternion.identity);
								if (235244 - 414360 != -179116)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack_blue_hit effect ");
								if (166659 - 428824 != -262165)
								{
									continue;
								}
							}
							if (!this.$self_$16835.rY4Qr3WmLm.isMine)
							{
								goto IL_F3;
							}
							if (6133 - 115457 == -109323)
							{
								continue;
							}
							this.$hitPos$16826 = this.$mPos$16833 + this.$tDir$16834;
							if (166953 - 197052 == -30098)
							{
								continue;
							}
							this.$hitLayer$16827 = 130816 - (1 << this.$self_$16835.gameObject.layer);
							if (54657 - 67684 == -13026)
							{
								continue;
							}
							this.$hitList$16828 = Damage.FindAreaTarget(this.$hitPos$16826, (float)6, (float)3, this.$hitLayer$16827);
							if (180727 - 351397 != -170670)
							{
								continue;
							}
							this.$hitDmg$16829 = this.$self_$16835.rY4Qr3WmLm.talAdjust(150);
							if (146012 - 86775 != 59237)
							{
								continue;
							}
							this.$$iterator$9993$16832 = UnityRuntimeServices.GetEnumerator(this.$hitList$16828);
							if (167193 - 124289 != 42904)
							{
								continue;
							}
							while (this.$$iterator$9993$16832.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9993$16832.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16830 = (GameObject)obj2;
								if (143696 - 402080 == -258383)
								{
									goto IL_2F5;
								}
								this.$hitMagnitude$16831 = (float)1 - 0.5f * (global::Math.vFlat(this.$hitObject$16830.transform.position - this.$hitPos$16826).magnitude / (float)6);
								if (154222 - 36276 != 117946)
								{
									goto IL_2F5;
								}
								UnityRuntimeServices.Update(this.$$iterator$9993$16832, this.$hitObject$16830);
								if (198125 - 583020 != -384895)
								{
									goto IL_2F5;
								}
								this.$self_$16835.rY4Qr3WmLm.hit(4, this.$hitObject$16830, (int)(this.$hitMagnitude$16831 * (float)this.$hitDmg$16829), 10, 0, (float)2 * (this.$hitObject$16830.transform.position - this.$hitPos$16826).normalized);
								if (238356 - 550529 == -312172)
								{
									goto IL_2F5;
								}
								UnityRuntimeServices.Update(this.$$iterator$9993$16832, this.$hitObject$16830);
								if (5296 - 529212 == -523915)
								{
									goto IL_2F5;
								}
							}
							if (199775 - 315884 != -116108)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16835.rY4Qr3WmLm.actionState != "attack")
						{
							goto IL_4A2;
						}
						if (209807 - 500058 == -290250)
						{
							continue;
						}
						if (this.$self_$16835.rY4Qr3WmLm.myCommand != "nAttack_blue")
						{
							if (242706 - 125932 != 116775)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							this.$self_$16835.rY4Qr3WmLm.moveSpeed = (float)0;
							if (5696 - 47098 != -41401)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16835.rY4Qr3WmLm.actionState == "attack")
						{
							if (231669 - 81917 != 149752)
							{
								continue;
							}
							if (this.$self_$16835.rY4Qr3WmLm.myCommand == "nAttack_blue")
							{
								if (85238 - 26608 != 58630)
								{
									continue;
								}
								this.$self_$16835.rY4Qr3WmLm.actionState = "standby";
								if (13899 - 389661 != -375762)
								{
									continue;
								}
								this.$self_$16835.rY4Qr3WmLm.actionTime = Time.time;
								if (10308 - 527005 == -516696)
								{
									continue;
								}
								this.$self_$16835.rY4Qr3WmLm.myCommand = "none";
								if (219058 - 554911 == -335852)
								{
									continue;
								}
								if (!this.$self_$16835.rY4Qr3WmLm.isMine)
								{
									if (61582 - 596968 != -535386)
									{
										continue;
									}
									this.$self_$16835.rY4Qr3WmLm.nPosition = this.$self_$16835.transform.position;
									if (68865 - 244941 == -176075)
									{
										continue;
									}
									this.$self_$16835.rY4Qr3WmLm.oPosition = this.$self_$16835.transform.position;
									if (4827 - 78994 == -74166)
									{
										continue;
									}
									this.$self_$16835.rY4Qr3WmLm.nDirection = this.$self_$16835.transform.forward;
									if (105069 - 394639 == -289569)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (291856 - 542228 != -250371)
						{
							goto Block_36;
						}
						continue;
					default:
						if (196125 - 236314 != -40189)
						{
							continue;
						}
						break;
					}
					this.$self_$16835.rY4Qr3WmLm.actionState = "attack";
					if (226494 - 310722 != -84227)
					{
						this.$self_$16835.rY4Qr3WmLm.actionTime = Time.time;
						if (63286 - 462360 != -399073)
						{
							this.$self_$16835.rY4Qr3WmLm.myCommand = "nAttack_blue";
							if (53099 - 43426 == 9673)
							{
								this.$self_$16835.rY4Qr3WmLm.addTimeOut("nAttack", (float)9);
								if (213573 - 537400 == -323827)
								{
									this.$self_$16835.transform.position = this.$mPos$16833;
									if (147298 - 127115 == 20183)
									{
										this.$self_$16835.transform.LookAt(this.$mPos$16833 + global::Math.vFlat(this.$tDir$16834));
										if (120257 - 348606 == -228349)
										{
											this.$self_$16835.animation.CrossFade("nAttack");
											if (83744 - 498849 != -415104)
											{
												this.$self_$16835.animation.wrapMode = WrapMode.Once;
												if (296889 - 25945 == 270944)
												{
													this.$self_$16835.rY4Qr3WmLm.vMovement = this.$self_$16835.transform.forward;
													if (65740 - 16696 != 49045)
													{
														this.$self_$16835.rY4Qr3WmLm.moveSpeed = (float)0;
														if (55135 - 520657 == -465522)
														{
															goto IL_3EC;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_F3:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_1CB:
				goto IL_9CE;
				Block_24:
				goto IL_F3;
				IL_3EC:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_4A2:
				goto IL_9CE;
				Block_31:
				return this.Yield(4, new WaitForSeconds(0.6f));
				Block_36:
				Block_47:
				Block_57:
				IL_9CE:
				return false;
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x000EB740 File Offset: 0x000E9940
			internal static bool Lc5U4YQsyIvxKE8NoQu()
			{
				return true;
			}

			// Token: 0x06000908 RID: 2312 RVA: 0x000EB744 File Offset: 0x000E9944
			internal static bool uj7ZowQ9AqL1lKQcQSE()
			{
				return false;
			}

			// Token: 0x04000825 RID: 2085
			internal Vector3 $hitPos$16826;

			// Token: 0x04000826 RID: 2086
			internal int $hitLayer$16827;

			// Token: 0x04000827 RID: 2087
			internal UnityScript.Lang.Array $hitList$16828;

			// Token: 0x04000828 RID: 2088
			internal int $hitDmg$16829;

			// Token: 0x04000829 RID: 2089
			internal GameObject $hitObject$16830;

			// Token: 0x0400082A RID: 2090
			internal float $hitMagnitude$16831;

			// Token: 0x0400082B RID: 2091
			internal IEnumerator $$iterator$9993$16832;

			// Token: 0x0400082C RID: 2092
			internal Vector3 $mPos$16833;

			// Token: 0x0400082D RID: 2093
			internal Vector3 $tDir$16834;

			// Token: 0x0400082E RID: 2094
			internal RangerBug $self_$16835;
		}
	}

	// Token: 0x02000192 RID: 402
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_black$16839 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000909 RID: 2313 RVA: 0x000EB748 File Offset: 0x000E9948
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_black$16839(Vector3 mPos, Vector3 tDir, RangerBug self_)
		{
			if (80096 - 535315 != -455219)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292324 - 281004 == 11320)
				{
					base..ctor();
					if (128828 - 37150 == 91678)
					{
						this.$mPos$16847 = mPos;
						if (26103 - 30597 != -4493)
						{
							this.$tDir$16848 = tDir;
							if (45795 - 9040 == 36755)
							{
								this.$self_$16849 = self_;
								if (198646 - 110310 != 88337)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000EB824 File Offset: 0x000E9A24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerBug.$RPC_nAttack_black$16839.$(this.$mPos$16847, this.$tDir$16848, this.$self_$16849);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000EB840 File Offset: 0x000E9A40
		internal static bool Ye0sheQ12slbm19hD03()
		{
			return true;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x000EB844 File Offset: 0x000E9A44
		internal static bool l7BtC7Q4eonUOUoocT8()
		{
			return false;
		}

		// Token: 0x0400082F RID: 2095
		internal Vector3 $mPos$16847;

		// Token: 0x04000830 RID: 2096
		internal Vector3 $tDir$16848;

		// Token: 0x04000831 RID: 2097
		internal RangerBug $self_$16849;

		// Token: 0x02000193 RID: 403
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600090D RID: 2317 RVA: 0x000EB848 File Offset: 0x000E9A48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerBug self_)
			{
				if (139913 - 386927 != -247013)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246053 - 309813 != -63759)
					{
						base..ctor();
						if (274127 - 304545 == -30418)
						{
							this.$mPos$16844 = mPos;
							if (183378 - 48004 != 135375)
							{
								this.$tDir$16845 = tDir;
								if (157102 - 468288 != -311185)
								{
									this.$self_$16846 = self_;
									if (53001 - 503517 != -450515)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600090E RID: 2318 RVA: 0x000EB924 File Offset: 0x000E9B24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20275 - 180644 != -160369)
				{
				}
				for (;;)
				{
					IL_1A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_800;
					case 2:
						if (this.$self_$16846.rY4Qr3WmLm.actionState != "attack")
						{
							goto IL_125;
						}
						if (232529 - 399879 == -167349)
						{
							continue;
						}
						if (this.$self_$16846.rY4Qr3WmLm.myCommand != "nAttack_black")
						{
							if (151936 - 75646 != 76291)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							if (this.$self_$16846.rY4Qr3WmLm.isMine)
							{
								if (207449 - 16357 == 191093)
								{
									continue;
								}
								this.$hitLayer$16840 = 130816 - (1 << this.$self_$16846.gameObject.layer);
								if (252302 - 172218 == 80085)
								{
									continue;
								}
								this.$hitList$16841 = Damage.FindAreaTarget(this.$self_$16846.transform.position, (float)5, (float)2, this.$hitLayer$16840);
								if (249694 - 226577 != 23117)
								{
									continue;
								}
								this.$$iterator$9994$16843 = UnityRuntimeServices.GetEnumerator(this.$hitList$16841);
								if (41016 - 231340 != -190324)
								{
									continue;
								}
								while (this.$$iterator$9994$16843.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9994$16843.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16842 = (GameObject)obj2;
									if (73640 - 69816 == 3825)
									{
										goto IL_1A;
									}
									this.$self_$16846.rY4Qr3WmLm.hit(1, this.$hitObject$16842, 2 * this.$self_$16846.rY4Qr3WmLm.atk, 50, 0, 0.5f * this.$self_$16846.transform.forward);
									if (140725 - 598354 != -457629)
									{
										goto IL_1A;
									}
									UnityRuntimeServices.Update(this.$$iterator$9994$16843, this.$hitObject$16842);
									if (61317 - 592385 != -531068)
									{
										goto IL_1A;
									}
								}
								if (5173 - 393214 == -388040)
								{
									continue;
								}
							}
							Vector3 vector = Camera.main.transform.position - this.$self_$16846.transform.position;
							if (127280 - 135793 == -8512)
							{
								continue;
							}
							if (vector.sqrMagnitude >= (float)400)
							{
								goto IL_782;
							}
							if (219136 - 113654 != 105482)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", 0.5f);
							if (195550 - 537087 != -341537)
							{
								continue;
							}
							goto IL_782;
						}
						break;
					case 3:
						if (this.$self_$16846.rY4Qr3WmLm.actionState == "attack")
						{
							if (55851 - 294170 == -238318)
							{
								continue;
							}
							if (this.$self_$16846.rY4Qr3WmLm.myCommand == "nAttack_black")
							{
								if (217466 - 520973 != -303507)
								{
									continue;
								}
								this.$self_$16846.rY4Qr3WmLm.actionState = "standby";
								if (81620 - 256852 != -175232)
								{
									continue;
								}
								this.$self_$16846.rY4Qr3WmLm.actionTime = Time.time;
								if (231926 - 416347 != -184421)
								{
									continue;
								}
								this.$self_$16846.rY4Qr3WmLm.myCommand = "none";
								if (238439 - 164684 == 73756)
								{
									continue;
								}
								if (!this.$self_$16846.rY4Qr3WmLm.isMine)
								{
									if (85259 - 158535 != -73276)
									{
										continue;
									}
									this.$self_$16846.rY4Qr3WmLm.nPosition = this.$self_$16846.transform.position;
									if (22086 - 189317 == -167230)
									{
										continue;
									}
									this.$self_$16846.rY4Qr3WmLm.oPosition = this.$self_$16846.transform.position;
									if (100252 - 301985 == -201732)
									{
										continue;
									}
									this.$self_$16846.rY4Qr3WmLm.nDirection = this.$self_$16846.transform.forward;
									if (90384 - 287879 != -197495)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (218206 - 562656 != -344449)
						{
							goto Block_5;
						}
						continue;
					default:
						if (232631 - 441584 == -208952)
						{
							continue;
						}
						break;
					}
					this.$self_$16846.rY4Qr3WmLm.actionState = "attack";
					if (292931 - 92387 != 200545)
					{
						this.$self_$16846.rY4Qr3WmLm.actionTime = Time.time;
						if (161603 - 484779 == -323176)
						{
							this.$self_$16846.rY4Qr3WmLm.myCommand = "nAttack_black";
							if (117540 - 514394 == -396854)
							{
								this.$self_$16846.rY4Qr3WmLm.addTimeOut("nAttack", (float)3);
								if (125001 - 239637 == -114636)
								{
									this.$self_$16846.transform.position = this.$mPos$16844;
									if (169860 - 403884 != -234023)
									{
										this.$self_$16846.transform.LookAt(this.$mPos$16844 + global::Math.vFlat(this.$tDir$16845));
										if (190368 - 393308 != -202939)
										{
											this.$self_$16846.animation.CrossFade("nAttack");
											if (53155 - 62652 == -9497)
											{
												this.$self_$16846.animation.wrapMode = WrapMode.Once;
												if (141290 - 327005 == -185715)
												{
													this.$self_$16846.rY4Qr3WmLm.vMovement = this.$self_$16846.transform.forward;
													if (210489 - 150617 != 59873)
													{
														this.$self_$16846.rY4Qr3WmLm.moveSpeed = (float)0;
														if (43887 - 239207 == -195320)
														{
															if (this.$self_$16846.nAttack_black_ring)
															{
																if (155829 - 140183 != 15647)
																{
																	this.$self_$16846.rY4Qr3WmLm.createEffect(this.$self_$16846.nAttack_black_ring, this.$self_$16846.transform.position, this.$self_$16846.transform.rotation);
																	if (106876 - 45749 != 61128)
																	{
																		goto Block_36;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_black ring effect");
																if (195087 - 239347 != -44259)
																{
																	goto Block_42;
																}
															}
														}
													}
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
				IL_125:
				goto IL_800;
				IL_2CA:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_35:
				goto IL_125;
				Block_36:
				Block_42:
				goto IL_2CA;
				IL_782:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_800:
				return false;
			}

			// Token: 0x0600090F RID: 2319 RVA: 0x000EC144 File Offset: 0x000EA344
			internal static bool y80pB1QzO6VfEDlBRsd()
			{
				return true;
			}

			// Token: 0x06000910 RID: 2320 RVA: 0x000EC148 File Offset: 0x000EA348
			internal static bool F6pkG1kanRhtVLDlAmu()
			{
				return false;
			}

			// Token: 0x04000832 RID: 2098
			internal int $hitLayer$16840;

			// Token: 0x04000833 RID: 2099
			internal UnityScript.Lang.Array $hitList$16841;

			// Token: 0x04000834 RID: 2100
			internal GameObject $hitObject$16842;

			// Token: 0x04000835 RID: 2101
			internal IEnumerator $$iterator$9994$16843;

			// Token: 0x04000836 RID: 2102
			internal Vector3 $mPos$16844;

			// Token: 0x04000837 RID: 2103
			internal Vector3 $tDir$16845;

			// Token: 0x04000838 RID: 2104
			internal RangerBug $self_$16846;
		}
	}

	// Token: 0x02000194 RID: 404
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_summon$16850 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000911 RID: 2321 RVA: 0x000EC14C File Offset: 0x000EA34C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_summon$16850(Vector3 mPos, Vector3 tDir, RangerBug self_)
		{
			if (77611 - 165160 != -87548)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (248079 - 155038 == 93041)
				{
					base..ctor();
					if (11041 - 202668 == -191627)
					{
						this.$mPos$16854 = mPos;
						if (113683 - 19123 != 94561)
						{
							this.$tDir$16855 = tDir;
							if (246518 - 390952 == -144434)
							{
								this.$self_$16856 = self_;
								if (68232 - 34755 == 33477)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x000EC228 File Offset: 0x000EA428
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerBug.$RPC_summon$16850.$(this.$mPos$16854, this.$tDir$16855, this.$self_$16856);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000EC244 File Offset: 0x000EA444
		internal static bool jeqlpAk5OLDpfDymUKR()
		{
			return true;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000EC248 File Offset: 0x000EA448
		internal static bool vfu5Tjkp6jLKiL44wmG()
		{
			return false;
		}

		// Token: 0x04000839 RID: 2105
		internal Vector3 $mPos$16854;

		// Token: 0x0400083A RID: 2106
		internal Vector3 $tDir$16855;

		// Token: 0x0400083B RID: 2107
		internal RangerBug $self_$16856;

		// Token: 0x02000195 RID: 405
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000915 RID: 2325 RVA: 0x000EC24C File Offset: 0x000EA44C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerBug self_)
			{
				if (96404 - 45668 != 50737)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222521 - 565544 == -343023)
					{
						base..ctor();
						if (207182 - 60238 != 146945)
						{
							this.$mPos$16851 = mPos;
							if (142038 - 350839 == -208801)
							{
								this.$tDir$16852 = tDir;
								if (83544 - 361776 != -278231)
								{
									this.$self_$16853 = self_;
									if (173845 - 304516 == -130671)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000916 RID: 2326 RVA: 0x000EC328 File Offset: 0x000EA528
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (22411 - 89307 != -66895)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_50D;
					case 2:
						if (this.$self_$16853.rY4Qr3WmLm.actionState == "attack")
						{
							if (21605 - 410632 != -389027)
							{
								continue;
							}
							if (this.$self_$16853.rY4Qr3WmLm.myCommand == "summon")
							{
								if (210601 - 520683 == -310081)
								{
									continue;
								}
								this.$self_$16853.rY4Qr3WmLm.actionState = "standby";
								if (123398 - 259371 != -135973)
								{
									continue;
								}
								this.$self_$16853.rY4Qr3WmLm.actionTime = Time.time;
								if (101636 - 211166 != -109530)
								{
									continue;
								}
								this.$self_$16853.rY4Qr3WmLm.myCommand = "none";
								if (55722 - 408859 == -353136)
								{
									continue;
								}
								if (!this.$self_$16853.rY4Qr3WmLm.isMine)
								{
									if (161007 - 453830 == -292822)
									{
										continue;
									}
									this.$self_$16853.rY4Qr3WmLm.nPosition = this.$self_$16853.transform.position;
									if (111939 - 567669 != -455730)
									{
										continue;
									}
									this.$self_$16853.rY4Qr3WmLm.oPosition = this.$self_$16853.transform.position;
									if (85994 - 137858 == -51863)
									{
										continue;
									}
									this.$self_$16853.rY4Qr3WmLm.nDirection = this.$self_$16853.transform.forward;
									if (48146 - 260470 == -212323)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (37600 - 390821 != -353221)
						{
							continue;
						}
						goto IL_50D;
					default:
						if (288643 - 62929 != 225714)
						{
							continue;
						}
						break;
					}
					this.$self_$16853.rY4Qr3WmLm.actionState = "attack";
					if (173643 - 63477 == 110166)
					{
						this.$self_$16853.rY4Qr3WmLm.actionTime = Time.time;
						if (183449 - 229051 == -45602)
						{
							this.$self_$16853.rY4Qr3WmLm.myCommand = "summon";
							if (121063 - 383438 == -262375)
							{
								this.$self_$16853.rY4Qr3WmLm.addTimeOut("nAttack", (float)5);
								if (265342 - 563322 != -297979)
								{
									this.$self_$16853.transform.position = this.$mPos$16851;
									if (86633 - 479840 == -393207)
									{
										this.$self_$16853.transform.LookAt(this.$mPos$16851 + global::Math.vFlat(this.$tDir$16852));
										if (122623 - 177968 == -55345)
										{
											this.$self_$16853.animation.Play("summon");
											if (42782 - 190251 != -147468)
											{
												this.$self_$16853.animation.wrapMode = WrapMode.Once;
												if (148749 - 200036 != -51286)
												{
													if (this.$self_$16853.rY4Qr3WmLm)
													{
														if (287176 - 593232 == -306055)
														{
															continue;
														}
														this.$self_$16853.rY4Qr3WmLm.StartCoroutine_Auto(this.$self_$16853.rY4Qr3WmLm.addStatus("noDamage", 1, 3, 0, this.$self_$16853.rY4Qr3WmLm.ActorNr));
														if (132172 - 564775 == -432602)
														{
															continue;
														}
													}
													if (this.$self_$16853.summon_ring)
													{
														if (272615 - 492554 == -219939)
														{
															UnityEngine.Object.Instantiate(this.$self_$16853.summon_ring, this.$self_$16853.transform.position, this.$self_$16853.transform.rotation);
															if (168889 - 280197 == -111308)
															{
																break;
															}
														}
													}
													else
													{
														Debug.LogError("Missing summon_ring gameObject");
														if (174632 - 580437 == -405805)
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
				IL_36C:
				return this.Yield(2, new WaitForSeconds(3f));
				goto IL_36C;
				IL_50D:
				return false;
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x000EC854 File Offset: 0x000EAA54
			internal static bool MG9LDHkV2rEH5vj8mpy()
			{
				return true;
			}

			// Token: 0x06000918 RID: 2328 RVA: 0x000EC858 File Offset: 0x000EAA58
			internal static bool ug68QJktOv0WZb66Kf0()
			{
				return false;
			}

			// Token: 0x0400083C RID: 2108
			internal Vector3 $mPos$16851;

			// Token: 0x0400083D RID: 2109
			internal Vector3 $tDir$16852;

			// Token: 0x0400083E RID: 2110
			internal RangerBug $self_$16853;
		}
	}

	// Token: 0x02000196 RID: 406
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16857 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000919 RID: 2329 RVA: 0x000EC85C File Offset: 0x000EAA5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16857(UnityScript.Lang.Array nArray, RangerBug self_)
		{
			if (81887 - 85070 != -3183)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (297680 - 449473 == -151793)
				{
					base..ctor();
					if (216824 - 257235 == -40411)
					{
						this.$nArray$16862 = nArray;
						if (114755 - 578957 == -464202)
						{
							this.$self_$16863 = self_;
							if (237066 - 483281 == -246215)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000EC918 File Offset: 0x000EAB18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerBug.$RPC_ko$16857.$(this.$nArray$16862, this.$self_$16863);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000EC92C File Offset: 0x000EAB2C
		internal static bool gMdrnlkNfTAS6jhemXP()
		{
			return true;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000EC930 File Offset: 0x000EAB30
		internal static bool OrEg6PkY4g9P0RsXvpF()
		{
			return false;
		}

		// Token: 0x0400083F RID: 2111
		internal UnityScript.Lang.Array $nArray$16862;

		// Token: 0x04000840 RID: 2112
		internal RangerBug $self_$16863;

		// Token: 0x02000197 RID: 407
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600091D RID: 2333 RVA: 0x000EC934 File Offset: 0x000EAB34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RangerBug self_)
			{
				if (274356 - 8849 != 265508)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126951 - 278930 == -151979)
					{
						base..ctor();
						if (227064 - 23570 != 203495)
						{
							this.$nArray$16860 = nArray;
							if (51585 - 589280 != -537694)
							{
								this.$self_$16861 = self_;
								if (283546 - 586891 == -303345)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600091E RID: 2334 RVA: 0x000EC9F0 File Offset: 0x000EABF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (40110 - 543641 != -503530)
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
						if (this.$self_$16861.rY4Qr3WmLm.actionState != "ko")
						{
							if (235037 - 349956 != -114919)
							{
								continue;
							}
							goto IL_19C;
						}
						else
						{
							this.$self_$16861.animation.Play("getUp");
							if (270285 - 394001 == -123715)
							{
								continue;
							}
							this.$self_$16861.animation.wrapMode = WrapMode.Once;
							if (5958 - 461309 != -455351)
							{
								continue;
							}
							goto IL_350;
						}
						break;
					case 3:
						if (this.$self_$16861.rY4Qr3WmLm.actionState != "ko")
						{
							if (56405 - 357101 != -300696)
							{
								continue;
							}
							goto IL_139;
						}
						else
						{
							this.$self_$16861.rY4Qr3WmLm.actionState = "standby";
							if (245666 - 565394 != -319728)
							{
								continue;
							}
							this.$self_$16861.rY4Qr3WmLm.actionTime = Time.time;
							if (94939 - 350703 != -255764)
							{
								continue;
							}
							this.$self_$16861.rY4Qr3WmLm.myCommand = "none";
							if (77870 - 31643 != 46227)
							{
								continue;
							}
							this.$self_$16861.rY4Qr3WmLm.ko = this.$self_$16861.rY4Qr3WmLm.mko;
							if (195883 - 291431 != -95548)
							{
								continue;
							}
							this.YieldDefault(1);
							if (200199 - 126854 != 73346)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					default:
						if (268710 - 54136 == 214575)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16861.rY4Qr3WmLm.actionState == "ko")
					{
						break;
					}
					if (174264 - 48763 != 125502)
					{
						if (this.$self_$16861.rY4Qr3WmLm.actionState == "dead")
						{
							if (21191 - 83133 == -61942)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16858 = (Vector3)this.$nArray$16860[0];
							if (58059 - 321255 != -263195)
							{
								this.$mDir$16859 = (Vector3)this.$nArray$16860[1];
								if (142155 - 43872 != 98284)
								{
									this.$self_$16861.rY4Qr3WmLm.ko = 0;
									if (7379 - 30613 != -23233)
									{
										this.$self_$16861.rY4Qr3WmLm.actionState = "ko";
										if (253898 - 303212 == -49314)
										{
											this.$self_$16861.rY4Qr3WmLm.actionTime = Time.time;
											if (5272 - 347905 == -342633)
											{
												this.$self_$16861.rY4Qr3WmLm.myCommand = "none";
												if (238931 - 114910 == 124021)
												{
													this.$self_$16861.rY4Qr3WmLm.vMovement = Vector3.zero;
													if (225513 - 39487 != 186027)
													{
														this.$self_$16861.rY4Qr3WmLm.moveSpeed = (float)0;
														if (114378 - 77515 != 36864)
														{
															this.$self_$16861.animation.Play("ko");
															if (80692 - 579393 == -498701)
															{
																this.$self_$16861.animation.wrapMode = WrapMode.Once;
																if (52212 - 420256 != -368043)
																{
																	goto Block_23;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_139:
				IL_19C:
				Block_11:
				goto IL_48C;
				IL_350:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_23:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x0600091F RID: 2335 RVA: 0x000ECE9C File Offset: 0x000EB09C
			internal static bool C8GqMqkc9feql1tusXP()
			{
				return true;
			}

			// Token: 0x06000920 RID: 2336 RVA: 0x000ECEA0 File Offset: 0x000EB0A0
			internal static bool Xa5OfVkUnvaiJH8vqJA()
			{
				return false;
			}

			// Token: 0x04000841 RID: 2113
			internal Vector3 $mPos$16858;

			// Token: 0x04000842 RID: 2114
			internal Vector3 $mDir$16859;

			// Token: 0x04000843 RID: 2115
			internal UnityScript.Lang.Array $nArray$16860;

			// Token: 0x04000844 RID: 2116
			internal RangerBug $self_$16861;
		}
	}

	// Token: 0x02000198 RID: 408
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16864 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000921 RID: 2337 RVA: 0x000ECEA4 File Offset: 0x000EB0A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16864(UnityScript.Lang.Array nArray, RangerBug self_)
		{
			if (83571 - 64472 != 19100)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (269811 - 85847 == 183964)
				{
					base..ctor();
					if (2925 - 31303 != -28377)
					{
						this.$nArray$16869 = nArray;
						if (15988 - 581032 != -565043)
						{
							this.$self_$16870 = self_;
							if (177946 - 445012 != -267065)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x000ECF60 File Offset: 0x000EB160
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerBug.$RPC_dead$16864.$(this.$nArray$16869, this.$self_$16870);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000ECF74 File Offset: 0x000EB174
		internal static bool vvuOwwkTUDSIK2MysiP()
		{
			return true;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000ECF78 File Offset: 0x000EB178
		internal static bool iHoWafk3RQnYxyt2sC3()
		{
			return false;
		}

		// Token: 0x04000845 RID: 2117
		internal UnityScript.Lang.Array $nArray$16869;

		// Token: 0x04000846 RID: 2118
		internal RangerBug $self_$16870;

		// Token: 0x02000199 RID: 409
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000925 RID: 2341 RVA: 0x000ECF7C File Offset: 0x000EB17C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RangerBug self_)
			{
				if (223326 - 78894 != 144433)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17231 - 80806 != -63574)
					{
						base..ctor();
						if (247532 - 294252 != -46719)
						{
							this.$nArray$16867 = nArray;
							if (101739 - 204510 == -102771)
							{
								this.$self_$16868 = self_;
								if (151577 - 218741 != -67163)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000926 RID: 2342 RVA: 0x000ED038 File Offset: 0x000EB238
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (11893 - 463298 != -451404)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$16868.rY4Qr3WmLm.actionState != "dead")
						{
							if (200478 - 33506 != 166973)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							if (this.$self_$16868.deadEffect)
							{
								if (63374 - 13817 != 49557)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16868.deadEffect, this.$self_$16868.transform.position, this.$self_$16868.transform.rotation);
								if (111044 - 476328 == -365283)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing deadEffect effect");
								if (77887 - 42892 != 34995)
								{
									continue;
								}
							}
							if (!this.$self_$16868.rY4Qr3WmLm.isPlayer)
							{
								if (138867 - 304722 == -165854)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16868.gameObject);
								if (18170 - 282368 != -264198)
								{
									continue;
								}
							}
							else if (this.$self_$16868.rY4Qr3WmLm.isMine)
							{
								if (99146 - 187545 != -88399)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16868.gameObject);
								if (6562 - 314764 != -308202)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (13106 - 459058 != -445952)
							{
								continue;
							}
							goto IL_4D2;
						}
						break;
					default:
						if (214539 - 332202 != -117663)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16868.rY4Qr3WmLm.actionState == "dead")
					{
						if (297321 - 518244 != -220922)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$16865 = (Vector3)this.$nArray$16867[0];
						if (231681 - 337417 == -105736)
						{
							this.$myDirection$16866 = (Vector3)this.$nArray$16867[1];
							if (242148 - 352079 == -109931)
							{
								this.$self_$16868.transform.position = this.$myPosition$16865;
								if (242307 - 39225 == 203082)
								{
									this.$self_$16868.transform.LookAt(this.$myPosition$16865 + this.$myDirection$16866);
									if (198749 - 151255 != 47495)
									{
										this.$self_$16868.rY4Qr3WmLm.hp = 0;
										if (77566 - 75215 == 2351)
										{
											this.$self_$16868.rY4Qr3WmLm.actionState = "dead";
											if (253054 - 40659 != 212396)
											{
												this.$self_$16868.rY4Qr3WmLm.actionTime = Time.time;
												if (57697 - 231864 == -174167)
												{
													this.$self_$16868.rY4Qr3WmLm.myCommand = "none";
													if (299660 - 103471 == 196189)
													{
														this.$self_$16868.rY4Qr3WmLm.vMovement = Vector3.zero;
														if (169762 - 456514 != -286751)
														{
															this.$self_$16868.rY4Qr3WmLm.moveSpeed = (float)0;
															if (267060 - 362816 == -95756)
															{
																this.$self_$16868.animation.Rewind();
																if (162565 - 169636 != -7070)
																{
																	this.$self_$16868.animation.Play("ko");
																	if (77105 - 30118 == 46987)
																	{
																		this.$self_$16868.animation.wrapMode = WrapMode.Once;
																		if (169658 - 336433 != -166774)
																		{
																			goto Block_6;
																		}
																	}
																}
															}
														}
													}
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
				goto IL_4D2;
				Block_6:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4D2:
				return false;
			}

			// Token: 0x06000927 RID: 2343 RVA: 0x000ED52C File Offset: 0x000EB72C
			internal static bool GNNPQJkX3RJE4WP1stD()
			{
				return true;
			}

			// Token: 0x06000928 RID: 2344 RVA: 0x000ED530 File Offset: 0x000EB730
			internal static bool p95Cv6kQjLLNKPk5TR9()
			{
				return false;
			}

			// Token: 0x04000847 RID: 2119
			internal Vector3 $myPosition$16865;

			// Token: 0x04000848 RID: 2120
			internal Vector3 $myDirection$16866;

			// Token: 0x04000849 RID: 2121
			internal UnityScript.Lang.Array $nArray$16867;

			// Token: 0x0400084A RID: 2122
			internal RangerBug $self_$16868;
		}
	}
}
