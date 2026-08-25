using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000E0 RID: 224
[Serializable]
public class MagmaBug : MonoBehaviour
{
	// Token: 0x060004EA RID: 1258 RVA: 0x00080B8C File Offset: 0x0007ED8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MagmaBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00080B9C File Offset: 0x0007ED9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (74068 - 188692 != -114624)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (203270 - 128522 == 74748)
			{
				this.mChar.actionState = "standby";
				if (167905 - 325954 != -158048)
				{
					this.mChar.actionTime = Time.time;
					if (194176 - 53151 != 141026)
					{
						this.mChar.myCommand = "none";
						if (59496 - 9857 != 49640)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (42569 - 146480 != -103910)
							{
								this.mChar.isMine = true;
								if (66805 - 314399 == -247594)
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

	// Token: 0x060004EC RID: 1260 RVA: 0x00080CD4 File Offset: 0x0007EED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (160791 - 592666 != -431875)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (129802 - 174710 != -44908)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (63893 - 163482 == -99588)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_19B;
					}
					if (42259 - 145807 == -103547)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (167494 - 503422 == -335927)
				{
					continue;
				}
			}
			IL_19B:
			if (this.mChar.hp <= 0)
			{
				if (62330 - 505309 == -442978)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (198116 - 74181 == 123936)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (154399 - 187541 == -33141)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (32729 - 339991 == -307261)
						{
							continue;
						}
						if (status != null)
						{
							if (171375 - 540909 != -369534)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (253094 - 397384 != -144290)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (23973 - 21479 == 2495)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (246159 - 262392 != -16233)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (162879 - 100051 != 62829)
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
							if (182467 - 593032 != -410565)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (146736 - 155224 == -8487)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (122110 - 407260 != -285150)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (242210 - 142412 != 99799)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (280004 - 218330 == 61674)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (68376 - 400989 != -332612)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (232313 - 123462 == 108851)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (287894 - 522170 != -234275)
						{
							if (this.mChar.isMine)
							{
								if (172275 - 136833 == 35442)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (83711 - 461487 == -377776)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (157453 - 432839 == -275386)
										{
											this.mChar.KoEvent();
											if (147817 - 60543 != 87275)
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
								if (227934 - 386323 == -158389)
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

	// Token: 0x060004ED RID: 1261 RVA: 0x000811D4 File Offset: 0x0007F3D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (246164 - 90435 != 155730)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (30212 - 429154 == -398942)
			{
				float runSpeed = this.mChar.runSpeed;
				if (103423 - 2728 != 100696)
				{
					Vector3 a = default(Vector3);
					if (108713 - 28366 != 80348)
					{
						Vector3 vector = Vector3.zero;
						if (15811 - 271962 != -256150)
						{
							float num2 = (float)0;
							if (12723 - 579970 == -567247)
							{
								if (this.mChar.isMine)
								{
									if (20376 - 454399 != -434023)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (158048 - 332025 != -173977)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (69384 - 178712 == -109327)
										{
											continue;
										}
										a.y = (float)0;
										if (49822 - 437404 != -387582)
										{
											continue;
										}
										a = a.normalized;
										if (68753 - 34070 != 34683)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (215147 - 503143 != -287996)
										{
											continue;
										}
										vector = vector.normalized;
										if (267017 - 544859 != -277842)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (218579 - 336170 == -117590)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (249842 - 161614 != 88228)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (65076 - 290090 != -225014)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (168314 - 585024 != -416710)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (272595 - 227354 != 45241)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (220919 - 446304 == -225384)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (280435 - 276612 != 3823)
														{
															continue;
														}
														this.animation.Play("run");
														if (25174 - 347521 != -322347)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (220574 - 275437 != -54863)
														{
															continue;
														}
														goto IL_AC3;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (264239 - 352695 != -88456)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (69444 - 13739 != 55705)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (67574 - 41054 == 26521)
											{
												continue;
											}
											num = (float)0;
											if (289050 - 300251 != -11201)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (197204 - 227196 != -29992)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (50878 - 455342 == -404463)
										{
											continue;
										}
									}
									IL_AC3:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (276417 - 349253 != -72836)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (227128 - 93858 == 133271)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (272557 - 377401 != -104844)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (25142 - 198708 != -173566)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (292801 - 187340 != 105461)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (160117 - 398712 == -238594)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (44766 - 449618 != -404852)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (296850 - 153518 != 143332)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (20565 - 343003 == -322437)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (243931 - 387779 != -143848)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (117757 - 319247 != -201490)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (22928 - 345808 != -322880)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (27157 - 309177 != -282020)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (104416 - 98679 == 5738)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (152254 - 20897 != 131357)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (212301 - 206017 != 6284)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (263952 - 61105 == 202848)
												{
													continue;
												}
												num = (float)0;
												if (227107 - 477369 == -250261)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (173188 - 115042 == 58147)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (86791 - 350054 != -263263)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (271582 - 495377 == -223794)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (151345 - 243068 != -91723)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (134583 - 519731 == -385147)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (77893 - 570443 == -492549)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (49011 - 400829 == -351817)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (287679 - 171940 == 115740)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (270577 - 578100 != -307523)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (127678 - 411984 == -284305)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (143226 - 327048 == -183821)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (36003 - 388017 == -352013)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (27906 - 452320 == -424413)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (205176 - 138656 == 66521)
											{
												continue;
											}
											num = (float)0;
											if (77623 - 151328 == -73704)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (7101 - 405011 == -397909)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (38394 - 219489 == -181094)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (237710 - 566079 != -328369)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (85484 - 167686 != -82202)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (187752 - 286411 == -98659)
								{
									this.mChar.moveSpeed = num;
									if (200116 - 421434 != -221317)
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

	// Token: 0x060004EE RID: 1262 RVA: 0x00081D38 File Offset: 0x0007FF38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (1362 - 273909 != -272547)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (215128 - 586451 == -371323)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (58006 - 64024 != -6017 && 101087 - 358039 != -256951)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (32497 - 212700 == -180202)
						{
							continue;
						}
						v = 1;
						if (30588 - 511821 != -481233)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (25660 - 520775 != -495115)
						{
							continue;
						}
						v = -1;
						if (247698 - 551165 == -303466)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_magmaLock")
					{
						if (271157 - 468354 != -197197)
						{
							continue;
						}
						v = 11;
						if (158032 - 288892 == -130859)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_magmaLock_hit")
					{
						if (225053 - 344907 == -119853)
						{
							continue;
						}
						v = -11;
						if (246156 - 183594 != 62562)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (76663 - 598696 == -522033)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (271043 - 592677 != -321633)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (132295 - 461751 == -329456)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (127222 - 146681 != -19458)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (140455 - 364240 == -223785)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (263224 - 152504 != 110721)
										{
											Hashtable hashtable = new Hashtable();
											if (169384 - 307792 == -138408)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (15311 - 471218 != -455906)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (107749 - 488218 == -380469)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (271900 - 84325 != 187576)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (122511 - 399721 == -277210)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (117771 - 214065 != -96293)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (234064 - 209821 == 24243)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (102577 - 265506 == -162929)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (269467 - 563973 != -294505)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (211055 - 451132 == -240077)
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

	// Token: 0x060004EF RID: 1263 RVA: 0x00082224 File Offset: 0x00080424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (297413 - 553103 != -255690)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (16984 - 401885 != -384900)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (237155 - 129263 == 107892)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (22583 - 82171 != -59587)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (235777 - 564554 != -328776)
						{
							int num3 = num;
							if (55796 - 276057 == -220261)
							{
								if (num3 == 1)
								{
									if (163461 - 156708 == 6753)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (18547 - 225389 != -206841)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (148510 - 558547 == -410037)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (41349 - 321251 == -279902)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (179051 - 571405 == -392354)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (118311 - 411874 == -293563)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 1)
								{
									if (194964 - 260967 != -66002)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (256097 - 320911 != -64813)
										{
											this.StartCoroutine_Auto(this.RPC_magmaLock(vector, vector2, num2));
											if (106264 - 471684 != -365419)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (269256 - 490944 != -221687)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (212223 - 185438 != 26786)
										{
											this.StartCoroutine_Auto(this.RPC_magmaLock_hit(vector, vector2, num2));
											if (25027 - 239390 != -214362)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (38155 - 557578 == -519423)
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

	// Token: 0x060004F0 RID: 1264 RVA: 0x000825B0 File Offset: 0x000807B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (203749 - 206642 != -2893)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (251722 - 350354 != -98631)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (224410 - 10154 == 214256)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (31198 - 223993 != -192794)
					{
						Vector3 normalized = vector.normalized;
						if (254610 - 133430 == 121180)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (156450 - 299453 == -143003)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (184072 - 41250 == 142823)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (20248 - 47877 == -27628)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (223055 - 347716 == -124661)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
									if (289702 - 563805 == -274103)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (297895 - 440872 == -142977)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
											if (144039 - 85036 != 59004)
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

	// Token: 0x060004F1 RID: 1265 RVA: 0x000827FC File Offset: 0x000809FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (211476 - 272773 != -61296)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (119955 - 293074 != -173118)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (97595 - 488392 != -390796)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (34967 - 263174 == -228207)
					{
						Vector3 normalized = vector.normalized;
						if (113198 - 474716 == -361518)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (133907 - 504652 == -370745)
							{
								CharacterControl characterControl = null;
								if (184258 - 475110 != -290851)
								{
									if (gameObject)
									{
										if (195489 - 536676 != -341187)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (265101 - 478645 != -213544)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (177610 - 430092 != -252482)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (215950 - 194892 != 21058)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (147066 - 570225 != -423159)
										{
											continue;
										}
										if (gameObject.layer == this.gameObject.layer)
										{
											if (60658 - 430302 != -369644)
											{
												continue;
											}
										}
										else if (this.mChar.isTimeOut("magmaLock") != (float)0)
										{
											if (85081 - 460073 == -374991)
											{
												continue;
											}
											Camera.main.SendMessage("newGameMessage", "magmaLock is not ready");
											if (100738 - 485499 != -384761)
											{
												continue;
											}
											break;
										}
										else
										{
											Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
											if (184398 - 292063 == -107664)
											{
												continue;
											}
											normalized = vector2.normalized;
											if (296086 - 423392 != -127306)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_magmaLock(this.transform.position, normalized, characterControl.ActorNr));
											if (165638 - 131500 == 34139)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (250914 - 357897 != -106983)
											{
												continue;
											}
											this.ActionEvent("RPC_magmaLock", this.transform.position, normalized, characterControl.ActorNr);
											if (140602 - 173038 != -32435)
											{
												break;
											}
											continue;
										}
									}
									Camera.main.SendMessage("newGameMessage", "Target is not valid");
									if (47116 - 5956 != 41161)
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

	// Token: 0x060004F2 RID: 1266 RVA: 0x00082BDC File Offset: 0x00080DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00082BE0 File Offset: 0x00080DE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MagmaBug.$RPC_nAttack$16078(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00082BF0 File Offset: 0x00080DF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (242832 - 424440 != -181608)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (106023 - 97086 == 8937)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (92174 - 516424 != -424249)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (20216 - 230640 == -210424)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x00082CB0 File Offset: 0x00080EB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_magmaLock(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MagmaBug.$RPC_magmaLock$16091(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00082CC0 File Offset: 0x00080EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_magmaLock_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new MagmaBug.$RPC_magmaLock_hit$16103(hitPos, this).GetEnumerator();
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x00082CD0 File Offset: 0x00080ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new MagmaBug.$RPC_ko$16112(nArray, this).GetEnumerator();
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00082CE0 File Offset: 0x00080EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new MagmaBug.$RPC_dead$16119(nArray, this).GetEnumerator();
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00082CF0 File Offset: 0x00080EF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x00082CF4 File Offset: 0x00080EF4
	internal static bool PBvM8lckr5Fd1T5E7iZ()
	{
		return true;
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00082CF8 File Offset: 0x00080EF8
	internal static bool s65fK4cG8Fexa4sLVSl()
	{
		return false;
	}

	// Token: 0x04000497 RID: 1175
	public CharacterControl mChar;

	// Token: 0x04000498 RID: 1176
	public GameObject nAttack_ring;

	// Token: 0x04000499 RID: 1177
	public GameObject nAttack_hit;

	// Token: 0x0400049A RID: 1178
	public GameObject magmaLock_hit;

	// Token: 0x020000E1 RID: 225
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$16078 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060004FC RID: 1276 RVA: 0x00082CFC File Offset: 0x00080EFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$16078(Vector3 mPos, Vector3 tDir, MagmaBug self_)
		{
			if (179025 - 272449 != -93423)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (163310 - 126672 != 36639)
				{
					base..ctor();
					if (282827 - 385331 == -102504)
					{
						this.$mPos$16088 = mPos;
						if (287636 - 452942 == -165306)
						{
							this.$tDir$16089 = tDir;
							if (23267 - 296261 != -272993)
							{
								this.$self_$16090 = self_;
								if (15590 - 468959 == -453369)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00082DD8 File Offset: 0x00080FD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MagmaBug.$RPC_nAttack$16078.$(this.$mPos$16088, this.$tDir$16089, this.$self_$16090);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00082DF4 File Offset: 0x00080FF4
		internal static bool IVivWbcHk5HA8MMMFIO()
		{
			return true;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00082DF8 File Offset: 0x00080FF8
		internal static bool p3Z4i8cWvVMBxfqLopD()
		{
			return false;
		}

		// Token: 0x0400049B RID: 1179
		internal Vector3 $mPos$16088;

		// Token: 0x0400049C RID: 1180
		internal Vector3 $tDir$16089;

		// Token: 0x0400049D RID: 1181
		internal MagmaBug $self_$16090;

		// Token: 0x020000E2 RID: 226
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000500 RID: 1280 RVA: 0x00082DFC File Offset: 0x00080FFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MagmaBug self_)
			{
				if (201239 - 48887 != 152352)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (107279 - 138062 == -30783)
					{
						base..ctor();
						if (117174 - 238980 == -121806)
						{
							this.$mPos$16085 = mPos;
							if (128624 - 543442 != -414817)
							{
								this.$tDir$16086 = tDir;
								if (256087 - 386803 != -130715)
								{
									this.$self_$16087 = self_;
									if (21630 - 565810 == -544180)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x00082ED8 File Offset: 0x000810D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (233438 - 77495 != 155943)
				{
				}
				for (;;)
				{
					IL_2C0:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B88;
					case 2:
						if (this.$self_$16087.mChar.actionState != "attack")
						{
							goto IL_528;
						}
						if (127193 - 37754 == 89440)
						{
							continue;
						}
						if (this.$self_$16087.mChar.myCommand != "nAttack")
						{
							if (188978 - 308787 != -119808)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							this.$self_$16087.mChar.moveSpeed = (float)5;
							if (270599 - 189825 != 80775)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16087.mChar.actionState != "attack")
						{
							goto IL_87D;
						}
						if (93842 - 593487 == -499644)
						{
							continue;
						}
						if (this.$self_$16087.mChar.myCommand != "nAttack")
						{
							if (246373 - 76276 != 170098)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$self_$16087.mChar.moveSpeed = (float)10;
							if (144084 - 152309 == -8224)
							{
								continue;
							}
							this.$hitLayer$16079 = 130816 - (1 << this.$self_$16087.gameObject.layer);
							if (120885 - 307331 == -186445)
							{
								continue;
							}
							this.$hitList$16080 = null;
							if (44194 - 293050 == -248855)
							{
								continue;
							}
							this.$hitPos$16081 = default(Vector3);
							if (24019 - 306384 != -282365)
							{
								continue;
							}
							this.$i$16082 = 0;
							if (122809 - 310801 != -187992)
							{
								continue;
							}
							goto IL_A71;
						}
						break;
					case 4:
						if (this.$self_$16087.mChar.actionState != "attack")
						{
							goto IL_5A0;
						}
						if (161321 - 56396 == 104926)
						{
							continue;
						}
						if (this.$self_$16087.mChar.myCommand != "nAttack")
						{
							if (245324 - 44751 != 200574)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$i$16082++;
							if (53688 - 158555 != -104866)
							{
								goto IL_A71;
							}
							continue;
						}
						break;
					default:
						if (58025 - 254757 != -196732)
						{
							continue;
						}
						break;
					}
					this.$self_$16087.mChar.actionState = "attack";
					if (97063 - 294945 != -197882)
					{
						continue;
					}
					this.$self_$16087.mChar.actionTime = Time.time;
					if (298261 - 121618 != 176643)
					{
						continue;
					}
					this.$self_$16087.mChar.myCommand = "nAttack";
					if (275231 - 124787 != 150444)
					{
						continue;
					}
					this.$self_$16087.mChar.addTimeOut("nAttack", (float)3);
					if (150359 - 307068 == -156708)
					{
						continue;
					}
					this.$self_$16087.transform.position = this.$mPos$16085;
					if (299646 - 24995 == 274652)
					{
						continue;
					}
					this.$self_$16087.transform.LookAt(this.$mPos$16085 + global::Math.vFlat(this.$tDir$16086));
					if (41855 - 177913 != -136058)
					{
						continue;
					}
					this.$self_$16087.animation.CrossFade("nAttack");
					if (31041 - 309479 == -278437)
					{
						continue;
					}
					this.$self_$16087.animation.wrapMode = WrapMode.Once;
					if (185994 - 256882 != -70888)
					{
						continue;
					}
					this.$self_$16087.mChar.vMovement = this.$self_$16087.transform.forward;
					if (36466 - 135793 != -99327)
					{
						continue;
					}
					this.$self_$16087.mChar.moveSpeed = (float)0;
					if (24527 - 589703 != -565176)
					{
						continue;
					}
					if (this.$self_$16087.nAttack_ring)
					{
						if (186073 - 587214 == -401140)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$16087.nAttack_ring, this.$self_$16087.transform.position, this.$self_$16087.transform.rotation);
						if (19182 - 482619 != -463437)
						{
							continue;
						}
						goto IL_403;
					}
					else
					{
						Debug.LogError("Missing nAttack_ring effect");
						if (6514 - 526107 != -519592)
						{
							goto Block_24;
						}
						continue;
					}
					IL_A71:
					if (this.$i$16082 >= 5)
					{
						if (42209 - 327266 == -285057)
						{
							if (this.$self_$16087.mChar.actionState != "attack")
							{
								break;
							}
							if (227811 - 450366 == -222555)
							{
								if (this.$self_$16087.mChar.myCommand != "nAttack")
								{
									if (247893 - 77071 != 170823)
									{
										break;
									}
								}
								else
								{
									this.$self_$16087.mChar.moveSpeed = (float)0;
									if (244127 - 175263 == 68864)
									{
										if (this.$self_$16087.mChar.actionState == "attack")
										{
											if (80564 - 544 == 80021)
											{
												continue;
											}
											if (this.$self_$16087.mChar.myCommand == "nAttack")
											{
												if (260188 - 242472 == 17717)
												{
													continue;
												}
												this.$self_$16087.mChar.actionState = "standby";
												if (58876 - 511649 != -452773)
												{
													continue;
												}
												this.$self_$16087.mChar.actionTime = Time.time;
												if (25545 - 473195 == -447649)
												{
													continue;
												}
												this.$self_$16087.mChar.myCommand = "none";
												if (206736 - 451894 == -245157)
												{
													continue;
												}
												if (!this.$self_$16087.mChar.isMine)
												{
													if (295205 - 64810 == 230396)
													{
														continue;
													}
													this.$self_$16087.mChar.nPosition = this.$self_$16087.transform.position;
													if (199415 - 48001 != 151414)
													{
														continue;
													}
													this.$self_$16087.mChar.oPosition = this.$self_$16087.transform.position;
													if (78037 - 412562 == -334524)
													{
														continue;
													}
													this.$self_$16087.mChar.nDirection = this.$self_$16087.transform.forward;
													if (289648 - 19090 == 270559)
													{
														continue;
													}
												}
											}
										}
										this.YieldDefault(1);
										if (273102 - 172944 == 100158)
										{
											break;
										}
									}
								}
							}
						}
					}
					else
					{
						if (this.$self_$16087.mChar.isMine)
						{
							if (277443 - 536467 != -259024)
							{
								continue;
							}
							this.$hitList$16080 = Damage.FindRecTarget(this.$self_$16087.transform.position, this.$self_$16087.transform.forward, (float)2 * this.$self_$16087.mChar.rangeMod, (float)2 * this.$self_$16087.mChar.rangeMod, (float)3 * this.$self_$16087.mChar.rangeMod, (float)2 * this.$self_$16087.mChar.rangeMod, this.$hitLayer$16079);
							if (257320 - 121289 != 136031)
							{
								continue;
							}
							this.$$iterator$9940$16084 = UnityRuntimeServices.GetEnumerator(this.$hitList$16080);
							if (174529 - 551274 != -376745)
							{
								continue;
							}
							while (this.$$iterator$9940$16084.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9940$16084.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16083 = (GameObject)obj2;
								if (155130 - 235100 != -79970)
								{
									goto IL_2C0;
								}
								if (this.$self_$16087.mChar.hit(1, this.$hitObject$16083, this.$self_$16087.mChar.atk, 4, 0, this.$self_$16087.transform.forward) != 0)
								{
									if (145276 - 585543 == -440266)
									{
										goto IL_2C0;
									}
									this.$hitPos$16081 = this.$hitObject$16083.collider.ClosestPointOnBounds(this.$self_$16087.transform.position + 1.5f * Vector3.up);
									if (42374 - 371087 != -328713)
									{
										goto IL_2C0;
									}
									UnityRuntimeServices.Update(this.$$iterator$9940$16084, this.$hitObject$16083);
									if (160035 - 552607 != -392572)
									{
										goto IL_2C0;
									}
									this.$self_$16087.RPC_nAttack_hit(this.$hitPos$16081, this.$self_$16087.transform.forward, 0);
									if (49770 - 82074 != -32304)
									{
										goto IL_2C0;
									}
									this.$self_$16087.ActionEvent("RPC_nAttack_hit", this.$hitPos$16081, this.$self_$16087.transform.forward, 0);
									if (298687 - 53679 != 245008)
									{
										goto IL_2C0;
									}
								}
							}
							if (273648 - 70533 == 203116)
							{
								continue;
							}
						}
						if (this.$i$16082 != 5)
						{
							goto IL_1C5;
						}
						if (193642 - 204641 != -10998)
						{
							this.$self_$16087.mChar.moveSpeed = (float)5;
							if (281029 - 385836 == -104807)
							{
								goto IL_1C5;
							}
						}
					}
				}
				goto IL_8AF;
				IL_1C5:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_13:
				Block_22:
				goto IL_5A0;
				IL_403:
				Block_24:
				goto IL_AD0;
				IL_528:
				goto IL_B88;
				Block_31:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_5A0:
				Block_43:
				IL_87D:
				IL_8AF:
				goto IL_B88;
				IL_AD0:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_B88:
				return false;
			}

			// Token: 0x06000502 RID: 1282 RVA: 0x00083A80 File Offset: 0x00081C80
			internal static bool PTgZ4qcAMcQR1rlfpOL()
			{
				return true;
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x00083A84 File Offset: 0x00081C84
			internal static bool aTGpr6cl3HFJuNA2IJ6()
			{
				return false;
			}

			// Token: 0x0400049E RID: 1182
			internal int $hitLayer$16079;

			// Token: 0x0400049F RID: 1183
			internal UnityScript.Lang.Array $hitList$16080;

			// Token: 0x040004A0 RID: 1184
			internal Vector3 $hitPos$16081;

			// Token: 0x040004A1 RID: 1185
			internal int $i$16082;

			// Token: 0x040004A2 RID: 1186
			internal GameObject $hitObject$16083;

			// Token: 0x040004A3 RID: 1187
			internal IEnumerator $$iterator$9940$16084;

			// Token: 0x040004A4 RID: 1188
			internal Vector3 $mPos$16085;

			// Token: 0x040004A5 RID: 1189
			internal Vector3 $tDir$16086;

			// Token: 0x040004A6 RID: 1190
			internal MagmaBug $self_$16087;
		}
	}

	// Token: 0x020000E3 RID: 227
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_magmaLock$16091 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000504 RID: 1284 RVA: 0x00083A88 File Offset: 0x00081C88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_magmaLock$16091(Vector3 mPos, Vector3 tDir, int tID, MagmaBug self_)
		{
			if (174544 - 471080 != -296536)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (251321 - 478850 != -227528)
				{
					base..ctor();
					if (70101 - 216210 == -146109)
					{
						this.$mPos$16099 = mPos;
						if (231951 - 265609 == -33658)
						{
							this.$tDir$16100 = tDir;
							if (9288 - 430098 == -420810)
							{
								this.$tID$16101 = tID;
								if (60752 - 216873 != -156120)
								{
									this.$self_$16102 = self_;
									if (37558 - 397734 == -360176)
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

		// Token: 0x06000505 RID: 1285 RVA: 0x00083B88 File Offset: 0x00081D88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MagmaBug.$RPC_magmaLock$16091.$(this.$mPos$16099, this.$tDir$16100, this.$tID$16101, this.$self_$16102);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00083BA8 File Offset: 0x00081DA8
		internal static bool t80SRKcym11FJ7UXr9b()
		{
			return true;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00083BAC File Offset: 0x00081DAC
		internal static bool nWWcn5cS4RVMkfH6fxD()
		{
			return false;
		}

		// Token: 0x040004A7 RID: 1191
		internal Vector3 $mPos$16099;

		// Token: 0x040004A8 RID: 1192
		internal Vector3 $tDir$16100;

		// Token: 0x040004A9 RID: 1193
		internal int $tID$16101;

		// Token: 0x040004AA RID: 1194
		internal MagmaBug $self_$16102;

		// Token: 0x020000E4 RID: 228
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000508 RID: 1288 RVA: 0x00083BB0 File Offset: 0x00081DB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, MagmaBug self_)
			{
				if (214651 - 98413 != 116238)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (192675 - 169198 != 23478)
					{
						base..ctor();
						if (53252 - 516949 == -463697)
						{
							this.$mPos$16095 = mPos;
							if (224697 - 62674 != 162024)
							{
								this.$tDir$16096 = tDir;
								if (241620 - 370903 != -129282)
								{
									this.$tID$16097 = tID;
									if (217397 - 9286 != 208112)
									{
										this.$self_$16098 = self_;
										if (245431 - 270468 == -25037)
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

			// Token: 0x06000509 RID: 1289 RVA: 0x00083CB0 File Offset: 0x00081EB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89262 - 72771 != 16491)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_87C;
					case 2:
						if (this.$self_$16098.mChar.actionState != "attack")
						{
							goto IL_331;
						}
						if (298985 - 120905 == 178081)
						{
							continue;
						}
						if (this.$self_$16098.mChar.myCommand != "magmaLock")
						{
							if (113383 - 329449 != -216066)
							{
								continue;
							}
							goto IL_331;
						}
						else
						{
							this.$tObject$16092 = null;
							if (291693 - 338219 == -46525)
							{
								continue;
							}
							if (this.$tID$16097 != 0)
							{
								if (155624 - 127314 != 28310)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$16097];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$16092 = (GameObject)obj2;
								if (74556 - 521195 != -446639)
								{
									continue;
								}
							}
							if (!this.$tObject$16092)
							{
								goto IL_94;
							}
							if (72914 - 583748 == -510833)
							{
								continue;
							}
							this.$tChar$16093 = (CharacterControl)this.$tObject$16092.GetComponent(typeof(CharacterControl));
							if (88663 - 428176 == -339512)
							{
								continue;
							}
							if (!this.$self_$16098.mChar.isMine)
							{
								goto IL_94;
							}
							if (214165 - 437187 != -223022)
							{
								continue;
							}
							this.$mDuration$16094 = Damage.getDebuff((float)3, this.$self_$16098.mChar.cha, this.$tChar$16093.cha);
							if (221271 - 7357 != 213914)
							{
								continue;
							}
							if (this.$self_$16098.mChar.isMine)
							{
								if (252024 - 526252 != -274228)
								{
									continue;
								}
								this.$tChar$16093.RPC_AddStatus("groundLock", 3, this.$mDuration$16094, 0, this.$self_$16098.mChar.ActorNr);
								if (41938 - 321781 != -279843)
								{
									continue;
								}
							}
							if (this.$self_$16098.mChar.hit(11, this.$tObject$16092, this.$self_$16098.mChar.talAdjust(30), 1, 0, 0.5f * Vector3.up) == 0)
							{
								goto IL_94;
							}
							if (169303 - 599524 == -430220)
							{
								continue;
							}
							this.$self_$16098.StartCoroutine_Auto(this.$self_$16098.RPC_magmaLock_hit(this.$tObject$16092.transform.position, this.$self_$16098.transform.forward, 0));
							if (174006 - 481232 == -307225)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_94;
							}
							if (94223 - 92217 == 2007)
							{
								continue;
							}
							this.$self_$16098.ActionEvent("RPC_magmaLock_hit", this.$tObject$16092.transform.position, this.$self_$16098.transform.forward, 0);
							if (215209 - 519207 != -303997)
							{
								goto IL_94;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16098.mChar.actionState != "attack")
						{
							goto IL_793;
						}
						if (14947 - 338974 == -324026)
						{
							continue;
						}
						if (this.$self_$16098.mChar.myCommand != "magmaLock")
						{
							if (178962 - 369528 != -190565)
							{
								goto Block_45;
							}
							continue;
						}
						else
						{
							this.$self_$16098.mChar.moveSpeed = (float)0;
							if (39283 - 33439 == 5845)
							{
								continue;
							}
							if (this.$self_$16098.mChar.actionState == "attack")
							{
								if (89355 - 150232 != -60877)
								{
									continue;
								}
								if (this.$self_$16098.mChar.myCommand == "magmaLock")
								{
									if (7944 - 424340 == -416395)
									{
										continue;
									}
									this.$self_$16098.mChar.actionState = "standby";
									if (269418 - 510174 == -240755)
									{
										continue;
									}
									this.$self_$16098.mChar.actionTime = Time.time;
									if (8601 - 510859 == -502257)
									{
										continue;
									}
									this.$self_$16098.mChar.myCommand = "none";
									if (79536 - 571825 == -492288)
									{
										continue;
									}
									if (!this.$self_$16098.mChar.isMine)
									{
										if (3387 - 430908 != -427521)
										{
											continue;
										}
										this.$self_$16098.mChar.nPosition = this.$self_$16098.transform.position;
										if (39192 - 5472 != 33720)
										{
											continue;
										}
										this.$self_$16098.mChar.oPosition = this.$self_$16098.transform.position;
										if (96263 - 599647 == -503383)
										{
											continue;
										}
										this.$self_$16098.mChar.nDirection = this.$self_$16098.transform.forward;
										if (134857 - 22193 == 112665)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (269742 - 125639 != 144104)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					default:
						if (278727 - 595000 == -316272)
						{
							continue;
						}
						break;
					}
					this.$self_$16098.mChar.actionState = "attack";
					if (239528 - 541836 == -302308)
					{
						this.$self_$16098.mChar.actionTime = Time.time;
						if (242003 - 104158 == 137845)
						{
							this.$self_$16098.mChar.myCommand = "magmaLock";
							if (29728 - 461631 == -431903)
							{
								this.$self_$16098.mChar.addTimeOut("magmaLock", (float)5);
								if (287168 - 74240 != 212929)
								{
									this.$self_$16098.transform.position = this.$mPos$16095;
									if (40725 - 416103 != -375377)
									{
										this.$self_$16098.transform.LookAt(this.$mPos$16095 + global::Math.vFlat(this.$tDir$16096));
										if (13299 - 105315 == -92016)
										{
											this.$self_$16098.animation.CrossFade("cast");
											if (172027 - 192769 == -20742)
											{
												this.$self_$16098.animation.wrapMode = WrapMode.Once;
												if (176906 - 236146 != -59239)
												{
													this.$self_$16098.mChar.vMovement = this.$self_$16098.transform.forward;
													if (110551 - 239827 == -129276)
													{
														this.$self_$16098.mChar.moveSpeed = (float)0;
														if (66790 - 498639 != -431848)
														{
															goto Block_34;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_94:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_331:
				goto IL_87C;
				Block_34:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_45:
				Block_47:
				IL_793:
				IL_87C:
				return false;
			}

			// Token: 0x0600050A RID: 1290 RVA: 0x0008454C File Offset: 0x0008274C
			internal static bool Ic9laQcoTsiV8puvOMR()
			{
				return true;
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x00084550 File Offset: 0x00082750
			internal static bool xNb5I1cEnKTAcXNYxgg()
			{
				return false;
			}

			// Token: 0x040004AB RID: 1195
			internal GameObject $tObject$16092;

			// Token: 0x040004AC RID: 1196
			internal CharacterControl $tChar$16093;

			// Token: 0x040004AD RID: 1197
			internal int $mDuration$16094;

			// Token: 0x040004AE RID: 1198
			internal Vector3 $mPos$16095;

			// Token: 0x040004AF RID: 1199
			internal Vector3 $tDir$16096;

			// Token: 0x040004B0 RID: 1200
			internal int $tID$16097;

			// Token: 0x040004B1 RID: 1201
			internal MagmaBug $self_$16098;
		}
	}

	// Token: 0x020000E5 RID: 229
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_magmaLock_hit$16103 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600050C RID: 1292 RVA: 0x00084554 File Offset: 0x00082754
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_magmaLock_hit$16103(Vector3 hitPos, MagmaBug self_)
		{
			if (299279 - 308134 != -8854)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (280276 - 13606 != 266671)
				{
					base..ctor();
					if (133112 - 468350 != -335237)
					{
						this.$hitPos$16110 = hitPos;
						if (203529 - 250564 == -47035)
						{
							this.$self_$16111 = self_;
							if (194252 - 236827 != -42574)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00084610 File Offset: 0x00082810
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MagmaBug.$RPC_magmaLock_hit$16103.$(this.$hitPos$16110, this.$self_$16111);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00084624 File Offset: 0x00082824
		internal static bool zG7Frnc2JEE6GteZG64()
		{
			return true;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00084628 File Offset: 0x00082828
		internal static bool OnsS34c8Z4fw5DeL7sd()
		{
			return false;
		}

		// Token: 0x040004B2 RID: 1202
		internal Vector3 $hitPos$16110;

		// Token: 0x040004B3 RID: 1203
		internal MagmaBug $self_$16111;

		// Token: 0x020000E6 RID: 230
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000510 RID: 1296 RVA: 0x0008462C File Offset: 0x0008282C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, MagmaBug self_)
			{
				if (257173 - 378344 != -121171)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (223515 - 451504 == -227989)
					{
						base..ctor();
						if (187900 - 451709 != -263808)
						{
							this.$hitPos$16108 = hitPos;
							if (244690 - 480435 != -235744)
							{
								this.$self_$16109 = self_;
								if (236757 - 277706 == -40949)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000511 RID: 1297 RVA: 0x000846E8 File Offset: 0x000828E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (36522 - 305852 != -269329)
				{
				}
				for (;;)
				{
					IL_CB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2D1;
					case 2:
						if (this.$self_$16109.mChar.isMine)
						{
							if (76003 - 151653 == -75649)
							{
								continue;
							}
							this.$hitLayer$16104 = 130816 - (1 << this.$self_$16109.gameObject.layer);
							if (219595 - 75104 != 144491)
							{
								continue;
							}
							this.$hitList$16105 = Damage.FindAreaTarget(this.$hitPos$16108, (float)2, (float)2, this.$hitLayer$16104);
							if (12636 - 402395 != -389759)
							{
								continue;
							}
							this.$$iterator$9941$16107 = UnityRuntimeServices.GetEnumerator(this.$hitList$16105);
							if (96113 - 63061 != 33052)
							{
								continue;
							}
							while (this.$$iterator$9941$16107.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9941$16107.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16106 = (GameObject)obj2;
								if (34646 - 258411 == -223764)
								{
									goto IL_CB;
								}
								this.$self_$16109.mChar.hit(12, this.$hitObject$16106, this.$self_$16109.mChar.talAdjust(60), 10, 0, Vector3.up);
								if (20086 - 323374 == -303287)
								{
									goto IL_CB;
								}
								UnityRuntimeServices.Update(this.$$iterator$9941$16107, this.$hitObject$16106);
								if (279092 - 529385 != -250293)
								{
									goto IL_CB;
								}
							}
							if (147361 - 505924 != -358563)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (135071 - 569259 != -434188)
						{
							continue;
						}
						goto IL_2D1;
					default:
						if (138259 - 132619 == 5641)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16109.magmaLock_hit)
					{
						if (45860 - 323222 != -277361)
						{
							UnityEngine.Object.Instantiate(this.$self_$16109.magmaLock_hit, this.$hitPos$16108, this.$self_$16109.transform.rotation);
							if (77275 - 274127 != -196851)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Missing magmaLock_hit effect");
						if (87640 - 308613 == -220973)
						{
							break;
						}
					}
				}
				IL_127:
				return this.Yield(2, new WaitForSeconds((float)2));
				goto IL_127;
				IL_2D1:
				return false;
			}

			// Token: 0x06000512 RID: 1298 RVA: 0x000849D8 File Offset: 0x00082BD8
			internal static bool vG7q94cZq9F96dnTBx2()
			{
				return true;
			}

			// Token: 0x06000513 RID: 1299 RVA: 0x000849DC File Offset: 0x00082BDC
			internal static bool jKIn42cCrk6WDwawCfS()
			{
				return false;
			}

			// Token: 0x040004B4 RID: 1204
			internal int $hitLayer$16104;

			// Token: 0x040004B5 RID: 1205
			internal UnityScript.Lang.Array $hitList$16105;

			// Token: 0x040004B6 RID: 1206
			internal GameObject $hitObject$16106;

			// Token: 0x040004B7 RID: 1207
			internal IEnumerator $$iterator$9941$16107;

			// Token: 0x040004B8 RID: 1208
			internal Vector3 $hitPos$16108;

			// Token: 0x040004B9 RID: 1209
			internal MagmaBug $self_$16109;
		}
	}

	// Token: 0x020000E7 RID: 231
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16112 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x000849E0 File Offset: 0x00082BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16112(UnityScript.Lang.Array nArray, MagmaBug self_)
		{
			if (163849 - 436419 != -272569)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (123167 - 244851 != -121683)
				{
					base..ctor();
					if (108798 - 542671 != -433872)
					{
						this.$nArray$16117 = nArray;
						if (95722 - 427286 != -331563)
						{
							this.$self_$16118 = self_;
							if (44549 - 3443 != 41107)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00084A9C File Offset: 0x00082C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MagmaBug.$RPC_ko$16112.$(this.$nArray$16117, this.$self_$16118);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00084AB0 File Offset: 0x00082CB0
		internal static bool lOJlyQcLfjT4jmGTiBZ()
		{
			return true;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00084AB4 File Offset: 0x00082CB4
		internal static bool X9dMEWcOSCQKms4Khvi()
		{
			return false;
		}

		// Token: 0x040004BA RID: 1210
		internal UnityScript.Lang.Array $nArray$16117;

		// Token: 0x040004BB RID: 1211
		internal MagmaBug $self_$16118;

		// Token: 0x020000E8 RID: 232
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000518 RID: 1304 RVA: 0x00084AB8 File Offset: 0x00082CB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MagmaBug self_)
			{
				if (267043 - 502679 != -235636)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (224412 - 210549 != 13864)
					{
						base..ctor();
						if (58988 - 265828 != -206839)
						{
							this.$nArray$16115 = nArray;
							if (226792 - 154777 == 72015)
							{
								this.$self_$16116 = self_;
								if (146506 - 300280 != -153773)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x00084B74 File Offset: 0x00082D74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (164473 - 330122 != -165649)
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
						if (this.$self_$16116.mChar.actionState != "ko")
						{
							if (35086 - 4502 != 30584)
							{
								continue;
							}
							goto IL_74;
						}
						else
						{
							this.$self_$16116.animation.Play("getUp");
							if (132049 - 547550 != -415501)
							{
								continue;
							}
							this.$self_$16116.animation.wrapMode = WrapMode.Once;
							if (283439 - 575371 != -291932)
							{
								continue;
							}
							goto IL_1CE;
						}
						break;
					case 3:
						if (this.$self_$16116.mChar.actionState != "ko")
						{
							if (288298 - 575746 != -287448)
							{
								continue;
							}
							goto IL_13D;
						}
						else
						{
							this.$self_$16116.mChar.actionState = "standby";
							if (258141 - 130894 != 127247)
							{
								continue;
							}
							this.$self_$16116.mChar.actionTime = Time.time;
							if (181676 - 283878 != -102202)
							{
								continue;
							}
							this.$self_$16116.mChar.myCommand = "none";
							if (263180 - 164050 != 99130)
							{
								continue;
							}
							this.$self_$16116.mChar.ko = this.$self_$16116.mChar.mko;
							if (112102 - 63480 != 48622)
							{
								continue;
							}
							this.YieldDefault(1);
							if (169697 - 316311 != -146614)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (37855 - 225549 != -187694)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16116.mChar.actionState == "ko")
					{
						break;
					}
					if (14917 - 150170 != -135252)
					{
						if (this.$self_$16116.mChar.actionState == "dead")
						{
							if (259884 - 17004 == 242880)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16113 = (Vector3)this.$nArray$16115[0];
							if (135664 - 327857 == -192193)
							{
								this.$mDir$16114 = (Vector3)this.$nArray$16115[1];
								if (87091 - 63065 == 24026)
								{
									this.$self_$16116.mChar.ko = 0;
									if (166179 - 179616 == -13437)
									{
										this.$self_$16116.mChar.actionState = "ko";
										if (170169 - 244659 != -74489)
										{
											this.$self_$16116.mChar.actionTime = Time.time;
											if (29934 - 92563 != -62628)
											{
												this.$self_$16116.mChar.myCommand = "none";
												if (80741 - 14532 != 66210)
												{
													this.$self_$16116.mChar.vMovement = Vector3.zero;
													if (75451 - 123193 == -47742)
													{
														this.$self_$16116.mChar.moveSpeed = (float)0;
														if (172652 - 468466 == -295814)
														{
															this.$self_$16116.animation.Play("ko");
															if (188688 - 355277 == -166589)
															{
																this.$self_$16116.animation.wrapMode = WrapMode.Once;
																if (40465 - 371546 != -331080)
																{
																	goto Block_27;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_74:
				IL_13D:
				goto IL_48C;
				IL_1CE:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_27:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x0600051A RID: 1306 RVA: 0x00085020 File Offset: 0x00083220
			internal static bool Fit5xucmrxKPxsYHycM()
			{
				return true;
			}

			// Token: 0x0600051B RID: 1307 RVA: 0x00085024 File Offset: 0x00083224
			internal static bool AT0GgDcF2XY53tRqbcU()
			{
				return false;
			}

			// Token: 0x040004BC RID: 1212
			internal Vector3 $mPos$16113;

			// Token: 0x040004BD RID: 1213
			internal Vector3 $mDir$16114;

			// Token: 0x040004BE RID: 1214
			internal UnityScript.Lang.Array $nArray$16115;

			// Token: 0x040004BF RID: 1215
			internal MagmaBug $self_$16116;
		}
	}

	// Token: 0x020000E9 RID: 233
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16119 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600051C RID: 1308 RVA: 0x00085028 File Offset: 0x00083228
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16119(UnityScript.Lang.Array nArray, MagmaBug self_)
		{
			if (245597 - 88838 != 156760)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106209 - 55324 == 50885)
				{
					base..ctor();
					if (261098 - 323654 != -62555)
					{
						this.$nArray$16124 = nArray;
						if (46489 - 356093 != -309603)
						{
							this.$self_$16125 = self_;
							if (179863 - 528399 == -348536)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000850E4 File Offset: 0x000832E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MagmaBug.$RPC_dead$16119.$(this.$nArray$16124, this.$self_$16125);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000850F8 File Offset: 0x000832F8
		internal static bool Ts0lyucMI4TwjFEjrnQ()
		{
			return true;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000850FC File Offset: 0x000832FC
		internal static bool JN8ckNcxMYfNTK5R1xH()
		{
			return false;
		}

		// Token: 0x040004C0 RID: 1216
		internal UnityScript.Lang.Array $nArray$16124;

		// Token: 0x040004C1 RID: 1217
		internal MagmaBug $self_$16125;

		// Token: 0x020000EA RID: 234
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000520 RID: 1312 RVA: 0x00085100 File Offset: 0x00083300
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MagmaBug self_)
			{
				if (193223 - 374967 != -181744)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7996 - 416659 == -408663)
					{
						base..ctor();
						if (64791 - 393435 == -328644)
						{
							this.$nArray$16122 = nArray;
							if (82551 - 147201 != -64649)
							{
								this.$self_$16123 = self_;
								if (187174 - 197028 != -9853)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x000851BC File Offset: 0x000833BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (181241 - 546244 != -365003)
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
						if (this.$self_$16123.mChar.actionState != "dead")
						{
							if (94059 - 589359 != -495300)
							{
								continue;
							}
							goto IL_2E4;
						}
						else
						{
							if (!this.$self_$16123.mChar.isPlayer)
							{
								if (224177 - 568334 == -344156)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16123.gameObject);
								if (180249 - 160522 != 19727)
								{
									continue;
								}
							}
							else if (this.$self_$16123.mChar.isMine)
							{
								if (240028 - 499478 == -259449)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16123.gameObject);
								if (104170 - 28339 == 75832)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (116354 - 60050 != 56305)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					default:
						if (242919 - 45476 != 197443)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16123.mChar.actionState == "dead")
					{
						if (207338 - 104914 != 102425)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$16120 = (Vector3)this.$nArray$16122[0];
						if (117289 - 435608 != -318318)
						{
							this.$myDirection$16121 = (Vector3)this.$nArray$16122[1];
							if (203625 - 287077 == -83452)
							{
								this.$self_$16123.transform.position = this.$myPosition$16120;
								if (280946 - 202393 != 78554)
								{
									this.$self_$16123.transform.LookAt(this.$myPosition$16120 + this.$myDirection$16121);
									if (293777 - 585797 == -292020)
									{
										this.$self_$16123.mChar.hp = 0;
										if (18956 - 258117 != -239160)
										{
											this.$self_$16123.mChar.actionState = "dead";
											if (247865 - 400673 != -152807)
											{
												this.$self_$16123.mChar.actionTime = Time.time;
												if (32280 - 488855 == -456575)
												{
													this.$self_$16123.mChar.myCommand = "none";
													if (186608 - 506676 == -320068)
													{
														this.$self_$16123.mChar.vMovement = Vector3.zero;
														if (183196 - 544627 == -361431)
														{
															this.$self_$16123.mChar.moveSpeed = (float)0;
															if (66899 - 138915 != -72015)
															{
																this.$self_$16123.animation.Rewind();
																if (235436 - 157649 != 77788)
																{
																	this.$self_$16123.animation.Play("ko");
																	if (182947 - 252893 != -69945)
																	{
																		this.$self_$16123.animation.wrapMode = WrapMode.Once;
																		if (258320 - 403549 != -145228)
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
				Block_7:
				IL_2E4:
				goto IL_42F;
				Block_24:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x0008560C File Offset: 0x0008380C
			internal static bool hZubYhcg1snBDjqarBt()
			{
				return true;
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x00085610 File Offset: 0x00083810
			internal static bool dNGDghcfMlrKBxDvCpu()
			{
				return false;
			}

			// Token: 0x040004C2 RID: 1218
			internal Vector3 $myPosition$16120;

			// Token: 0x040004C3 RID: 1219
			internal Vector3 $myDirection$16121;

			// Token: 0x040004C4 RID: 1220
			internal UnityScript.Lang.Array $nArray$16122;

			// Token: 0x040004C5 RID: 1221
			internal MagmaBug $self_$16123;
		}
	}
}
