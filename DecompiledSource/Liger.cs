using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CD4 RID: 3284
[Serializable]
public class Liger : MonoBehaviour
{
	// Token: 0x060049BC RID: 18876 RVA: 0x00923858 File Offset: 0x00921A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Liger()
	{
		if (89409 - 239051 != -149641)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (20358 - 8689 != 11670)
			{
				base..ctor();
				if (179071 - 269575 == -90504)
				{
					this.U1Ac5I0ii30 = 10;
					if (32109 - 573783 == -541674)
					{
						this.Vaic56G6WEb = 100;
						if (128685 - 160212 == -31527)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060049BD RID: 18877 RVA: 0x00923914 File Offset: 0x00921B14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (159494 - 305806 != -146312)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (216826 - 529686 != -312859)
			{
				this.mChar.actionState = "standby";
				if (283174 - 289920 == -6746)
				{
					this.mChar.actionTime = Time.time;
					if (31892 - 473222 != -441329)
					{
						this.mChar.myCommand = "none";
						if (107368 - 578874 != -471505)
						{
							if (Game.mGameType == 99)
							{
								if (296038 - 191887 == 104152)
								{
									continue;
								}
								this.mChar.isMine = true;
								if (291427 - 563146 == -271718)
								{
									continue;
								}
							}
							this.mChar.addTimeOut("ligerSwing", (float)30);
							if (207409 - 118441 != 88969)
							{
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (290505 - 405140 == -114635)
								{
									if (!this.mChar.isSummon)
									{
										break;
									}
									if (227405 - 64966 == 162439)
									{
										if (this.awake_vc)
										{
											if (262755 - 171149 != 91607)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (129056 - 116850 == 12206)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (86658 - 78868 != 7791)
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

	// Token: 0x060049BE RID: 18878 RVA: 0x00923B4C File Offset: 0x00921D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (137204 - 268663 != -131459)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (85267 - 357648 != -272381)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (188340 - 562787 != -374447)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_33D;
					}
					if (139318 - 252702 != -113384)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (214218 - 496003 == -281784)
				{
					continue;
				}
			}
			IL_33D:
			if (this.mChar.hp <= 0)
			{
				if (112568 - 416879 == -304310)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (64381 - 77261 == -12879)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (179634 - 104945 == 74690)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (64079 - 529818 != -465739)
						{
							continue;
						}
						if (status != null)
						{
							if (15310 - 168899 != -153589)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (33869 - 349965 != -316096)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (262593 - 478122 == -215528)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (218762 - 582984 != -364222)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (183299 - 180512 != 2787)
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
							if (58212 - 597154 == -538941)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (71659 - 245539 != -173880)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (238336 - 461816 != -223480)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (38160 - 525514 != -487354)
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
			if (120861 - 461789 != -340927)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (189172 - 495562 == -306390)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (229112 - 19366 != 209747)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (86497 - 358638 != -272140)
						{
							if (this.mChar.isMine)
							{
								if (14360 - 132083 == -117723)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (165330 - 320221 == -154891)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (207928 - 363482 != -155553)
										{
											this.mChar.KoEvent();
											if (166730 - 173765 != -7034)
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
								if (112412 - 539103 != -426690)
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

	// Token: 0x060049BF RID: 18879 RVA: 0x0092404C File Offset: 0x0092224C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (146804 - 225037 != -78232)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (163377 - 465178 != -301800)
			{
				float runSpeed = this.mChar.runSpeed;
				if (230734 - 66623 == 164111)
				{
					Vector3 a = default(Vector3);
					if (104501 - 434940 != -330438)
					{
						Vector3 vector = Vector3.zero;
						if (243455 - 567019 == -323564)
						{
							float num2 = (float)0;
							if (30582 - 94009 == -63427)
							{
								if (this.mChar.isMine)
								{
									if (56196 - 567870 != -511674)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (155157 - 19078 == 136080)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (259129 - 255198 != 3931)
										{
											continue;
										}
										a.y = (float)0;
										if (18243 - 112429 == -94185)
										{
											continue;
										}
										a = a.normalized;
										if (124222 - 559643 == -435420)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (97631 - 148075 == -50443)
										{
											continue;
										}
										vector = vector.normalized;
										if (133408 - 219580 != -86172)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (29599 - 497813 == -468213)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (46435 - 109287 == -62851)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (65227 - 559411 != -494184)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (284644 - 335441 != -50797)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (298151 - 76570 == 221582)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (34381 - 307248 == -272866)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (149547 - 503192 != -353645)
														{
															continue;
														}
														this.animation.Play("run");
														if (298539 - 246169 != 52370)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (100342 - 381592 != -281249)
														{
															goto IL_2A9;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (235826 - 368245 != -132419)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (288171 - 498498 != -210327)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (270034 - 192712 != 77322)
											{
												continue;
											}
											num = (float)0;
											if (276644 - 239049 == 37596)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (226665 - 379880 != -153215)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (639 - 372810 == -372170)
										{
											continue;
										}
									}
									IL_2A9:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (201861 - 565616 != -363755)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (128943 - 472654 != -343711)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (279524 - 452027 != -172503)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (199592 - 269396 == -69803)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (236462 - 562118 == -325655)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (55815 - 391139 == -335323)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (177123 - 412625 != -235502)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (291285 - 166869 == 124417)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (217239 - 453091 != -235852)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (148773 - 458795 == -310021)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (283191 - 112362 != 170829)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (254307 - 248173 != 6134)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (291498 - 113814 != 177684)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (23044 - 70038 == -46993)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (56493 - 269974 == -213480)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (184894 - 13954 == 170941)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (254935 - 263027 != -8092)
												{
													continue;
												}
												num = (float)0;
												if (109637 - 510056 != -400419)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (228687 - 550950 == -322262)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (39937 - 480307 != -440370)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (152606 - 6845 != 145761)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (150349 - 470347 != -319998)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (102238 - 423274 != -321036)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (32529 - 447836 == -415306)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (255979 - 493463 != -237484)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (122681 - 485983 != -363302)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (223886 - 202939 == 20948)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (66941 - 525824 == -458882)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (166090 - 173268 == -7177)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (280920 - 436385 == -155464)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (297814 - 491187 != -193373)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (78907 - 395364 != -316457)
											{
												continue;
											}
											num = (float)0;
											if (234647 - 91378 != 143269)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (176928 - 311848 == -134919)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (98208 - 41366 == 56843)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (97070 - 264932 != -167862)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (111578 - 391762 == -280183)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (192095 - 173368 == 18727)
								{
									this.mChar.moveSpeed = num;
									if (268026 - 58874 == 209152)
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

	// Token: 0x060049C0 RID: 18880 RVA: 0x00924BB0 File Offset: 0x00922DB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tDir, int tID)
	{
		if (223270 - 193550 != 29720)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (37949 - 409030 != -371080)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (212876 - 312755 != -99878 && 124126 - 529177 != -405050)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (62660 - 7365 != 55295)
						{
							continue;
						}
						v = 1;
						if (253488 - 108395 != 145093)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (137597 - 506210 == -368612)
						{
							continue;
						}
						v = -1;
						if (19084 - 115849 == -96764)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_leapingLion")
					{
						if (238028 - 367715 == -129686)
						{
							continue;
						}
						v = 11;
						if (268920 - 520688 != -251768)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_ligerSwing")
					{
						if (164823 - 442643 == -277819)
						{
							continue;
						}
						v = 21;
						if (129001 - 496638 == -367636)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_crushingTiger")
					{
						if (179611 - 187874 != -8263)
						{
							continue;
						}
						v = 31;
						if (64293 - 327549 != -263256)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (27405 - 470932 == -443527)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (141168 - 284365 != -143196)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (38983 - 558989 == -520006)
							{
								int v5 = Mathf.RoundToInt((float)200 * tDir.x);
								if (161478 - 322191 != -160712)
								{
									int v6 = Mathf.RoundToInt((float)200 * tDir.y);
									if (187592 - 268268 != -80675)
									{
										int v7 = Mathf.RoundToInt((float)200 * tDir.z);
										if (81633 - 160523 != -78889)
										{
											Hashtable hashtable = new Hashtable();
											if (130994 - 231885 == -100891)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (289840 - 507489 == -217649)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (91274 - 72026 != 19249)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (107241 - 28641 == 78600)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (120404 - 88413 == 31991)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (66431 - 396620 == -330189)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (128117 - 499738 != -371620)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (225939 - 118151 == 107788)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (65246 - 373006 != -307759)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (64694 - 247101 == -182407)
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

	// Token: 0x060049C1 RID: 18881 RVA: 0x009250E8 File Offset: 0x009232E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (106900 - 47095 != 59805)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (60082 - 404782 == -344700)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (276400 - 564136 != -287735)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (103924 - 202260 == -98336)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (262690 - 484507 != -221816)
						{
							int num3 = num;
							if (104788 - 574862 == -470074)
							{
								if (num3 == 1)
								{
									if (248912 - 503630 == -254718)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (120198 - 329076 != -208877)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (172616 - 286590 != -113973)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (14551 - 589478 == -574927)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (177546 - 482672 == -305126)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (273407 - 267772 != 5636)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (247863 - 183252 != 64612)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (191544 - 237292 == -45748)
										{
											this.StartCoroutine_Auto(this.RPC_leapingLion(vector, vector2, num2));
											if (238659 - 567500 == -328841)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (210353 - 164380 != 45974)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (35643 - 408059 == -372416)
										{
											this.StartCoroutine_Auto(this.RPC_ligerSwing(vector, vector2, num2));
											if (215512 - 586106 == -370594)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (250340 - 210308 == 40032)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (78415 - 251327 != -172911)
										{
											this.StartCoroutine_Auto(this.RPC_crushingTiger(vector, vector2, num2));
											if (263355 - 571675 == -308320)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (86900 - 291023 != -204122)
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

	// Token: 0x060049C2 RID: 18882 RVA: 0x009254F0 File Offset: 0x009236F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (108309 - 330050 != -221740)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (49555 - 45146 != 4410)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (230692 - 383643 != -152950)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (246105 - 477066 == -230961)
					{
						Vector3 tDir = vector.normalized;
						if (271555 - 79395 == 192160)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (243761 - 541940 == -298179)
							{
								if (292820 - 142131 == 150689)
								{
									if (gameObject)
									{
										if (100360 - 189381 == -89020)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (122928 - 68612 == 54317)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (218514 - 530922 == -312407)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (182292 - 358932 != -176640)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (125942 - 308638 != -182695)
									{
										if (gameObject == this.gameObject)
										{
											if (229189 - 254141 == -24951)
											{
												continue;
											}
											tDir = this.transform.forward;
											if (279204 - 423279 != -144075)
											{
												continue;
											}
										}
										if (this.mLigerType == eLiger.normal)
										{
											if (226933 - 90187 != 136746)
											{
												continue;
											}
											if (UnityEngine.Random.Range(0, 100) < 35)
											{
												if (214457 - 159631 == 54827)
												{
													continue;
												}
												this.StartCoroutine_Auto(this.RPC_leapingLion(this.transform.position, tDir, 0));
												if (179708 - 97443 != 82265)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (162482 - 518071 != -355589)
												{
													continue;
												}
												this.ActionEvent("RPC_leapingLion", this.transform.position, tDir, 0);
												if (114729 - 519114 != -404384)
												{
													break;
												}
												continue;
											}
										}
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, tDir, 0));
										if (246840 - 325209 != -78368)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (221142 - 280629 == -59487)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, tDir, 0);
												if (48549 - 143855 == -95306)
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

	// Token: 0x060049C3 RID: 18883 RVA: 0x009258DC File Offset: 0x00923ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (241660 - 183015 != 58645)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (200235 - 521337 != -321101)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (280802 - 423607 != -142804)
				{
					Vector3 tDir = global::Math.vFlat(a - this.transform.position);
					if (150623 - 371869 != -221245)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (213853 - 277202 == -63349)
						{
							CharacterControl characterControl = null;
							if (130162 - 147198 == -17036)
							{
								if (gameObject)
								{
									if (93025 - 419037 == -326011)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (179835 - 508019 != -328184)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (41256 - 47657 == -6400)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (201348 - 107317 != 94031)
									{
										continue;
									}
								}
								if (this.mLigerType != eLiger.normal)
								{
									if (76217 - 230563 == -154346)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use charge attack");
										if (138743 - 242226 != -103482)
										{
											break;
										}
									}
								}
								else
								{
									if (characterControl)
									{
										if (295783 - 381873 != -86090)
										{
											continue;
										}
										if (this.mChar.sp < 30)
										{
											if (242211 - 12726 == 229486)
											{
												continue;
											}
										}
										else if (gameObject.layer == this.gameObject.layer)
										{
											if (237612 - 269175 != -31563)
											{
												continue;
											}
											Camera.main.SendMessage("newGameMessage", "Target Not Valid");
											if (72549 - 561853 != -489304)
											{
												continue;
											}
											break;
										}
										else if (this.mChar.isTimeOut("leapingLion") != (float)0)
										{
											if (292049 - 300777 == -8727)
											{
												continue;
											}
											Camera.main.SendMessage("newGameMessage", "Leaping Lion skill is not ready");
											if (163753 - 474428 != -310675)
											{
												continue;
											}
											break;
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_crushingTiger(this.transform.position, tDir, characterControl.ActorNr));
											if (274148 - 302019 != -27871)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (200371 - 466086 == -265714)
											{
												continue;
											}
											this.ActionEvent("RPC_crushingTiger", this.transform.position, tDir, characterControl.ActorNr);
											if (163386 - 596840 != -433454)
											{
												continue;
											}
											break;
										}
									}
									if (this.mChar.isTimeOut("ligerSwing") != (float)0)
									{
										if (91149 - 593238 != -502089)
										{
											continue;
										}
										Camera.main.SendMessage("newGameMessage", "Leaping Lion skill is not ready");
										if (99394 - 89250 != 10144)
										{
											continue;
										}
									}
									this.StartCoroutine_Auto(this.RPC_ligerSwing(this.transform.position, tDir, 0));
									if (17179 - 518159 != -500979)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (277267 - 385191 != -107923)
										{
											this.ActionEvent("RPC_ligerSwing", this.transform.position, tDir, 0);
											if (218556 - 314479 == -95923)
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

	// Token: 0x060049C4 RID: 18884 RVA: 0x00925DB0 File Offset: 0x00923FB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060049C5 RID: 18885 RVA: 0x00925DB4 File Offset: 0x00923FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Liger.$RPC_nAttack$32643(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060049C6 RID: 18886 RVA: 0x00925DC4 File Offset: 0x00923FC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (57463 - 416038 != -358574)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (141316 - 2155 == 139162)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (131238 - 408711 != -277473)
				{
					continue;
				}
			}
			if (this.uO0c5JUtlWB >= Time.time)
			{
				break;
			}
			if (112438 - 518539 == -406101)
			{
				this.uO0c5JUtlWB = Time.time + 0.2f;
				if (214619 - 287408 != -72788)
				{
					if (!this.nAttack_hitFx)
					{
						break;
					}
					if (142267 - 556799 != -414531)
					{
						this.audio.PlayOneShot(this.nAttack_hitFx);
						if (49993 - 240150 == -190157)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060049C7 RID: 18887 RVA: 0x00925F00 File Offset: 0x00924100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_leapingLion(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Liger.$RPC_leapingLion$32660(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060049C8 RID: 18888 RVA: 0x00925F10 File Offset: 0x00924110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ligerSwing(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Liger.$RPC_ligerSwing$32673(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060049C9 RID: 18889 RVA: 0x00925F20 File Offset: 0x00924120
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_crushingTiger(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Liger.$RPC_crushingTiger$32694(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060049CA RID: 18890 RVA: 0x00925F30 File Offset: 0x00924130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Liger.$RPC_ko$32707(nArray, this).GetEnumerator();
	}

	// Token: 0x060049CB RID: 18891 RVA: 0x00925F40 File Offset: 0x00924140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Liger.$RPC_dead$32715(nArray, this).GetEnumerator();
	}

	// Token: 0x060049CC RID: 18892 RVA: 0x00925F50 File Offset: 0x00924150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060049CD RID: 18893 RVA: 0x00925F54 File Offset: 0x00924154
	internal static bool OfbR5c5RsE6Hc3ftWmss()
	{
		return true;
	}

	// Token: 0x060049CE RID: 18894 RVA: 0x00925F58 File Offset: 0x00924158
	internal static bool UBc8em5R9m4C2fDWrpJy()
	{
		return false;
	}

	// Token: 0x04005474 RID: 21620
	public CharacterControl mChar;

	// Token: 0x04005475 RID: 21621
	public eLiger mLigerType;

	// Token: 0x04005476 RID: 21622
	public AudioClip awake_vc;

	// Token: 0x04005477 RID: 21623
	public GameObject nAttack_ring1;

	// Token: 0x04005478 RID: 21624
	public GameObject nAttack_ring2;

	// Token: 0x04005479 RID: 21625
	public GameObject nAttack_ring3;

	// Token: 0x0400547A RID: 21626
	private int U1Ac5I0ii30;

	// Token: 0x0400547B RID: 21627
	public AudioClip nAttack1_vc;

	// Token: 0x0400547C RID: 21628
	public AudioClip nAttack2_vc;

	// Token: 0x0400547D RID: 21629
	public AudioClip nAttack3_vc;

	// Token: 0x0400547E RID: 21630
	public GameObject nAttack_hit;

	// Token: 0x0400547F RID: 21631
	public AudioClip nAttack_hitFx;

	// Token: 0x04005480 RID: 21632
	private float uO0c5JUtlWB;

	// Token: 0x04005481 RID: 21633
	public GameObject leapingLion_ring;

	// Token: 0x04005482 RID: 21634
	public AudioClip leapingLion1_vc;

	// Token: 0x04005483 RID: 21635
	public AudioClip leapingLion2_vc;

	// Token: 0x04005484 RID: 21636
	public GameObject ligerSwing_ring;

	// Token: 0x04005485 RID: 21637
	public GameObject ligerSwing_spin;

	// Token: 0x04005486 RID: 21638
	public AudioClip ligerSwing_vc;

	// Token: 0x04005487 RID: 21639
	public GameObject crushingTiger_ring;

	// Token: 0x04005488 RID: 21640
	public GameObject crushingTiger_hit;

	// Token: 0x04005489 RID: 21641
	public AudioClip crushingTiger1_vc;

	// Token: 0x0400548A RID: 21642
	public AudioClip crushingTiger2_vc;

	// Token: 0x0400548B RID: 21643
	public AudioClip ko_vc;

	// Token: 0x0400548C RID: 21644
	private int Vaic56G6WEb;

	// Token: 0x0400548D RID: 21645
	public AudioClip dead_vc;

	// Token: 0x02000CD5 RID: 3285
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32643 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060049CF RID: 18895 RVA: 0x00925F5C File Offset: 0x0092415C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32643(Vector3 mPos, Vector3 tDir, Liger self_)
		{
			if (125211 - 64923 != 60288)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106126 - 580145 == -474019)
				{
					base..ctor();
					if (10219 - 108138 != -97918)
					{
						this.$mPos$32657 = mPos;
						if (257672 - 52847 == 204825)
						{
							this.$tDir$32658 = tDir;
							if (73010 - 559143 != -486132)
							{
								this.$self_$32659 = self_;
								if (125626 - 147445 == -21819)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x00926038 File Offset: 0x00924238
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Liger.$RPC_nAttack$32643.$(this.$mPos$32657, this.$tDir$32658, this.$self_$32659);
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x00926054 File Offset: 0x00924254
		internal static bool I94oeo5R1nLfxthBuH6j()
		{
			return true;
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x00926058 File Offset: 0x00924258
		internal static bool mQXTsd5R4g1sQTsKlhbA()
		{
			return false;
		}

		// Token: 0x0400548E RID: 21646
		internal Vector3 $mPos$32657;

		// Token: 0x0400548F RID: 21647
		internal Vector3 $tDir$32658;

		// Token: 0x04005490 RID: 21648
		internal Liger $self_$32659;

		// Token: 0x02000CD6 RID: 3286
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060049D3 RID: 18899 RVA: 0x0092605C File Offset: 0x0092425C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Liger self_)
			{
				if (257399 - 327098 != -69698)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (15440 - 584783 != -569342)
					{
						base..ctor();
						if (47399 - 179764 != -132364)
						{
							this.$mPos$32654 = mPos;
							if (157538 - 139355 == 18183)
							{
								this.$tDir$32655 = tDir;
								if (260802 - 111544 == 149258)
								{
									this.$self_$32656 = self_;
									if (130357 - 507424 == -377067)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060049D4 RID: 18900 RVA: 0x00926138 File Offset: 0x00924338
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (156611 - 287195 != -130583)
				{
				}
				for (;;)
				{
					IL_862:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_197B;
					case 2:
						if (this.$self_$32656.mChar.actionState != "attack")
						{
							goto IL_DF3;
						}
						if (277054 - 522248 != -245194)
						{
							continue;
						}
						if (this.$self_$32656.mChar.myCommand != "nAttack")
						{
							if (165434 - 144334 != 21101)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$self_$32656.mChar.moveSpeed = (float)14;
							if (14743 - 522827 == -508083)
							{
								continue;
							}
							if (this.$self_$32656.nAttack_ring2)
							{
								if (240038 - 242392 == -2353)
								{
									continue;
								}
								if (this.$self_$32656.mLigerType == eLiger.normal)
								{
									if (299441 - 357166 == -57724)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$32656.nAttack_ring2, this.$self_$32656.transform.position + this.$self_$32656.transform.TransformDirection((float)0, (float)0, (float)2), this.$self_$32656.transform.rotation);
									if (233526 - 19373 != 214153)
									{
										continue;
									}
								}
								else
								{
									UnityEngine.Object.Instantiate(this.$self_$32656.nAttack_ring2, this.$self_$32656.transform.position, this.$self_$32656.transform.rotation);
									if (121864 - 350766 != -228902)
									{
										continue;
									}
								}
							}
							else
							{
								Debug.LogError("Missing nAttack_ring2 effect");
								if (227989 - 172946 != 55043)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_11C;
							}
							if (70739 - 360075 != -289336)
							{
								continue;
							}
							if (this.$self_$32656.nAttack2_vc)
							{
								if (252743 - 3882 != 248861)
								{
									continue;
								}
								this.$self_$32656.audio.PlayOneShot(this.$self_$32656.nAttack2_vc);
								if (222867 - 33203 != 189664)
								{
									continue;
								}
								goto IL_D69;
							}
							else
							{
								Debug.LogError("Cannot find nAttack2 voice");
								if (123335 - 392484 != -269148)
								{
									goto Block_81;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$32656.mChar.actionState != "attack")
						{
							goto IL_D09;
						}
						if (37926 - 416949 != -379023)
						{
							continue;
						}
						if (this.$self_$32656.mChar.myCommand != "nAttack")
						{
							if (79928 - 329006 != -249078)
							{
								continue;
							}
							goto IL_D09;
						}
						else
						{
							this.$self_$32656.mChar.moveSpeed = (float)3;
							if (248957 - 126099 == 122859)
							{
								continue;
							}
							this.$hitLayer$32645 = 130816 - (1 << this.$self_$32656.gameObject.layer);
							if (207235 - 544716 != -337481)
							{
								continue;
							}
							this.$hitList$32646 = null;
							if (40189 - 101869 != -61680)
							{
								continue;
							}
							this.$hitPoint$32647 = default(Vector3);
							if (168912 - 561188 != -392276)
							{
								continue;
							}
							if (!this.$self_$32656.mChar.isMine)
							{
								goto IL_1A;
							}
							if (174710 - 71191 == 103520)
							{
								continue;
							}
							if (this.$self_$32656.mLigerType == eLiger.normal)
							{
								if (284352 - 504359 == -220006)
								{
									continue;
								}
								this.$hitList$32646 = Damage.FindRecTarget(this.$self_$32656.transform.position, this.$self_$32656.transform.forward, (float)2 * this.$self_$32656.mChar.rangeMod, (float)2 * this.$self_$32656.mChar.rangeMod, (float)5 * this.$self_$32656.mChar.rangeMod, (float)3 * this.$self_$32656.mChar.rangeMod, this.$hitLayer$32645);
								if (191650 - 290879 == -99228)
								{
									continue;
								}
							}
							else
							{
								this.$hitList$32646 = Damage.FindRecTarget(this.$self_$32656.transform.position, this.$self_$32656.transform.forward, (float)2 * this.$self_$32656.mChar.rangeMod, (float)2 * this.$self_$32656.mChar.rangeMod, (float)3 * this.$self_$32656.mChar.rangeMod, (float)3 * this.$self_$32656.mChar.rangeMod, this.$hitLayer$32645);
								if (142524 - 333719 == -191194)
								{
									continue;
								}
							}
							this.$$iterator$10773$32649 = UnityRuntimeServices.GetEnumerator(this.$hitList$32646);
							if (37259 - 341734 == -304474)
							{
								continue;
							}
							while (this.$$iterator$10773$32649.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10773$32649.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32648 = (GameObject)obj2;
								if (63035 - 263671 == -200635)
								{
									goto IL_862;
								}
								if (this.$self_$32656.mChar.hit(1, this.$hitObject$32648, this.$self_$32656.mChar.atk, 3, 0, (float)2 * this.$self_$32656.transform.forward) != 0)
								{
									if (261010 - 437706 != -176696)
									{
										goto IL_862;
									}
									this.$hitPoint$32647 = this.$hitObject$32648.collider.ClosestPointOnBounds(this.$self_$32656.transform.position + Vector3.up);
									if (101158 - 219441 == -118282)
									{
										goto IL_862;
									}
									UnityRuntimeServices.Update(this.$$iterator$10773$32649, this.$hitObject$32648);
									if (240352 - 23386 != 216966)
									{
										goto IL_862;
									}
									this.$self_$32656.RPC_nAttack_hit(this.$hitPoint$32647, this.$self_$32656.transform.forward, 0);
									if (152328 - 300479 == -148150)
									{
										goto IL_862;
									}
									this.$self_$32656.ActionEvent("RPC_nAttack_hit", this.$hitPoint$32647, this.$self_$32656.transform.forward, 0);
									if (111059 - 138019 == -26959)
									{
										goto IL_862;
									}
								}
							}
							if (108165 - 94978 != 13188)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$32656.mChar.actionState != "attack")
						{
							goto IL_62A;
						}
						if (233923 - 568846 == -334922)
						{
							continue;
						}
						if (this.$self_$32656.mChar.myCommand != "nAttack")
						{
							if (226125 - 555614 != -329489)
							{
								continue;
							}
							goto IL_62A;
						}
						else
						{
							this.$self_$32656.mChar.moveSpeed = (float)0;
							if (94568 - 146809 != -52241)
							{
								continue;
							}
							goto IL_37B;
						}
						break;
					case 5:
						if (this.$self_$32656.mChar.actionState != "attack")
						{
							goto IL_311;
						}
						if (198793 - 259410 != -60617)
						{
							continue;
						}
						if (this.$self_$32656.mChar.myCommand != "nAttack")
						{
							if (197509 - 56604 != 140906)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$self_$32656.mChar.moveSpeed = (float)6;
							if (265412 - 72170 == 193243)
							{
								continue;
							}
							if (this.$self_$32656.mChar.isMine)
							{
								if (7808 - 9378 == -1569)
								{
									continue;
								}
								if (this.$self_$32656.mLigerType == eLiger.normal)
								{
									if (166209 - 467812 == -301602)
									{
										continue;
									}
									this.$hitList$32646 = Damage.FindRecTarget(this.$self_$32656.transform.position, this.$self_$32656.transform.forward, (float)2 * this.$self_$32656.mChar.rangeMod, (float)2 * this.$self_$32656.mChar.rangeMod, (float)5 * this.$self_$32656.mChar.rangeMod, (float)3 * this.$self_$32656.mChar.rangeMod, this.$hitLayer$32645);
									if (174725 - 448946 != -274221)
									{
										continue;
									}
								}
								else
								{
									this.$hitList$32646 = Damage.FindRecTarget(this.$self_$32656.transform.position, this.$self_$32656.transform.forward, (float)2 * this.$self_$32656.mChar.rangeMod, (float)2 * this.$self_$32656.mChar.rangeMod, (float)3 * this.$self_$32656.mChar.rangeMod, (float)3 * this.$self_$32656.mChar.rangeMod, this.$hitLayer$32645);
									if (268884 - 438584 != -169700)
									{
										continue;
									}
								}
								this.$$iterator$10774$32651 = UnityRuntimeServices.GetEnumerator(this.$hitList$32646);
								if (282850 - 301017 == -18166)
								{
									continue;
								}
								while (this.$$iterator$10774$32651.MoveNext())
								{
									object obj4;
									object obj3 = obj4 = this.$$iterator$10774$32651.Current;
									if (!(obj3 is GameObject))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
									}
									this.$hitObject$32650 = (GameObject)obj4;
									if (114387 - 291242 == -176854)
									{
										goto IL_862;
									}
									if (this.$self_$32656.mChar.hit(1, this.$hitObject$32650, this.$self_$32656.mChar.atk, 2, 0, this.$self_$32656.transform.forward) != 0)
									{
										if (70835 - 448391 != -377556)
										{
											goto IL_862;
										}
										this.$hitPoint$32647 = this.$hitObject$32650.collider.ClosestPointOnBounds(this.$self_$32656.transform.position + Vector3.up);
										if (220347 - 43833 != 176514)
										{
											goto IL_862;
										}
										UnityRuntimeServices.Update(this.$$iterator$10774$32651, this.$hitObject$32650);
										if (299352 - 297226 == 2127)
										{
											goto IL_862;
										}
										this.$self_$32656.RPC_nAttack_hit(this.$hitPoint$32647, this.$self_$32656.transform.forward, 0);
										if (90207 - 90845 != -638)
										{
											goto IL_862;
										}
										this.$self_$32656.ActionEvent("RPC_nAttack_hit", this.$hitPoint$32647, this.$self_$32656.transform.forward, 0);
										if (77850 - 523195 != -445345)
										{
											goto IL_862;
										}
									}
								}
								if (117155 - 200501 != -83346)
								{
									continue;
								}
							}
							if (this.$self_$32656.nAttack_ring3)
							{
								if (273728 - 155029 == 118700)
								{
									continue;
								}
								this.$self_$32656.mChar.createEffect(this.$self_$32656.nAttack_ring3, this.$self_$32656.transform.position, this.$self_$32656.transform.rotation);
								if (33468 - 218743 == -185274)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack_ring3 effect");
								if (96384 - 123742 == -27357)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_2C2;
							}
							if (228460 - 250928 != -22468)
							{
								continue;
							}
							if (this.$self_$32656.nAttack3_vc)
							{
								if (48861 - 273995 == -225133)
								{
									continue;
								}
								this.$self_$32656.audio.PlayOneShot(this.$self_$32656.nAttack3_vc);
								if (57893 - 355545 != -297652)
								{
									continue;
								}
								goto IL_1524;
							}
							else
							{
								Debug.LogError("Cannot find nAttack3 voice");
								if (144173 - 268707 != -124534)
								{
									continue;
								}
								goto IL_2C2;
							}
						}
						break;
					case 6:
						if (this.$self_$32656.mChar.actionState != "attack")
						{
							goto IL_472;
						}
						if (1861 - 156591 == -154729)
						{
							continue;
						}
						if (this.$self_$32656.mChar.myCommand != "nAttack")
						{
							if (245452 - 237901 != 7552)
							{
								goto Block_117;
							}
							continue;
						}
						else
						{
							this.$self_$32656.mChar.moveSpeed = (float)0;
							if (127087 - 80566 == 46522)
							{
								continue;
							}
							if (!this.$self_$32656.mChar.isMine)
							{
								goto IL_18DB;
							}
							if (58150 - 470335 == -412184)
							{
								continue;
							}
							if (this.$self_$32656.mLigerType == eLiger.normal)
							{
								if (275881 - 83526 == 192356)
								{
									continue;
								}
								this.$hitList$32646 = Damage.FindAreaTarget(this.$self_$32656.transform.position, (float)5 * this.$self_$32656.mChar.rangeMod, (float)3 * this.$self_$32656.mChar.rangeMod, this.$hitLayer$32645);
								if (3919 - 412780 != -408861)
								{
									continue;
								}
							}
							else
							{
								this.$hitList$32646 = Damage.FindAreaTarget(this.$self_$32656.transform.position, (float)4 * this.$self_$32656.mChar.rangeMod, (float)3 * this.$self_$32656.mChar.rangeMod, this.$hitLayer$32645);
								if (64574 - 575540 != -510966)
								{
									continue;
								}
							}
							this.$$iterator$10775$32653 = UnityRuntimeServices.GetEnumerator(this.$hitList$32646);
							if (22598 - 567160 != -544562)
							{
								continue;
							}
							while (this.$$iterator$10775$32653.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$10775$32653.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$32652 = (GameObject)obj6;
								if (19570 - 166381 != -146811)
								{
									goto IL_862;
								}
								if (this.$self_$32656.mChar.hit(1, this.$hitObject$32652, this.$self_$32656.mChar.atk, 2, 0, this.$self_$32656.transform.forward) != 0)
								{
									if (142573 - 564796 == -422222)
									{
										goto IL_862;
									}
									this.$hitPoint$32647 = this.$hitObject$32652.collider.ClosestPointOnBounds(this.$self_$32656.transform.position + Vector3.up);
									if (17058 - 137310 == -120251)
									{
										goto IL_862;
									}
									UnityRuntimeServices.Update(this.$$iterator$10775$32653, this.$hitObject$32652);
									if (76169 - 143915 == -67745)
									{
										goto IL_862;
									}
									this.$self_$32656.RPC_nAttack_hit(this.$hitPoint$32647, this.$self_$32656.transform.forward, 0);
									if (296003 - 165862 != 130141)
									{
										goto IL_862;
									}
									this.$self_$32656.ActionEvent("RPC_nAttack_hit", this.$hitPoint$32647, this.$self_$32656.transform.forward, 0);
									if (139135 - 142670 == -3534)
									{
										goto IL_862;
									}
								}
							}
							if (194294 - 18598 != 175697)
							{
								goto Block_123;
							}
							continue;
						}
						break;
					case 7:
						if (this.$self_$32656.mChar.actionState == "attack")
						{
							if (202174 - 244360 != -42186)
							{
								continue;
							}
							if (this.$self_$32656.mChar.myCommand == "nAttack")
							{
								if (146045 - 591261 == -445215)
								{
									continue;
								}
								this.$self_$32656.mChar.actionState = "standby";
								if (265022 - 373262 != -108240)
								{
									continue;
								}
								this.$self_$32656.mChar.actionTime = Time.time;
								if (225107 - 65146 == 159962)
								{
									continue;
								}
								this.$self_$32656.mChar.myCommand = "none";
								if (136038 - 23271 != 112767)
								{
									continue;
								}
								if (!this.$self_$32656.mChar.isMine)
								{
									if (71206 - 585667 == -514460)
									{
										continue;
									}
									this.$self_$32656.mChar.nPosition = this.$self_$32656.transform.position;
									if (168829 - 428159 != -259330)
									{
										continue;
									}
									this.$self_$32656.mChar.oPosition = this.$self_$32656.transform.position;
									if (269004 - 598473 == -329468)
									{
										continue;
									}
									this.$self_$32656.mChar.nDirection = this.$self_$32656.transform.forward;
									if (165669 - 34521 == 131149)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (112229 - 100625 != 11605)
						{
							goto Block_104;
						}
						continue;
					default:
						if (66339 - 373419 == -307079)
						{
							continue;
						}
						break;
					}
					this.$self_$32656.mChar.actionState = "attack";
					if (222212 - 234889 == -12677)
					{
						this.$self_$32656.mChar.actionTime = Time.time;
						if (292564 - 440963 != -148398)
						{
							this.$self_$32656.mChar.myCommand = "nAttack";
							if (206482 - 275423 != -68940)
							{
								this.$self_$32656.mChar.addTimeOut("nAttack", (float)2);
								if (256258 - 590774 == -334516)
								{
									this.$self_$32656.transform.position = this.$mPos$32654;
									if (277874 - 194761 == 83113)
									{
										this.$self_$32656.transform.LookAt(this.$mPos$32654 + global::Math.vFlat(this.$tDir$32655));
										if (64074 - 108758 != -44683)
										{
											this.$self_$32656.animation.CrossFade("nAttack");
											if (159160 - 513197 == -354037)
											{
												this.$self_$32656.animation.wrapMode = WrapMode.Once;
												if (216348 - 430939 == -214591)
												{
													this.$self_$32656.mChar.vMovement = this.$self_$32656.transform.forward;
													if (188382 - 547732 == -359350)
													{
														this.$self_$32656.mChar.moveSpeed = (float)0;
														if (226835 - 243502 == -16667)
														{
															if (this.$self_$32656.nAttack_ring1)
															{
																if (52652 - 249420 == -196767)
																{
																	continue;
																}
																this.$self_$32656.mChar.createEffect(this.$self_$32656.nAttack_ring1, this.$self_$32656.transform.position, this.$self_$32656.transform.rotation);
																if (88698 - 55677 == 33022)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring1 effect");
																if (157838 - 186417 == -28578)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (200386 - 407944 == -207557)
																{
																	continue;
																}
																if (this.$self_$32656.nAttack1_vc)
																{
																	if (111763 - 30718 != 81045)
																	{
																		continue;
																	}
																	this.$self_$32656.audio.PlayOneShot(this.$self_$32656.nAttack1_vc);
																	if (17217 - 397722 != -380505)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find nAttack1 voice");
																	if (210197 - 124647 == 85551)
																	{
																		continue;
																	}
																}
															}
															this.$m$32644 = string.Empty;
															if (115609 - 81480 != 34130)
															{
																if (this.$self_$32656.mChar.isControlled)
																{
																	goto IL_1691;
																}
																if (264198 - 431357 != -167158)
																{
																	if (Game.mGameCode == 106)
																	{
																		if (65748 - 184157 != -118409)
																		{
																			continue;
																		}
																		if (this.$self_$32656.U1Ac5I0ii30 <= 35)
																		{
																			if (102586 - 430995 != -328409)
																			{
																				continue;
																			}
																			this.$self_$32656.U1Ac5I0ii30 = this.$self_$32656.U1Ac5I0ii30 + 1;
																			if (38740 - 86614 == -47873)
																			{
																				continue;
																			}
																			this.$m$32644 = Language.getMessage("M106_BoldasRecruitment", this.$self_$32656.U1Ac5I0ii30);
																			if (119035 - 120161 != -1126)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			this.$m$32644 = Language.getMessage("M106_BoldasRecruitment", UnityEngine.Random.Range(10, 35));
																			if (62350 - 482620 != -420270)
																			{
																				continue;
																			}
																		}
																	}
																	else if (Game.mGameCode == 802)
																	{
																		if (246313 - 158631 != 87682)
																		{
																			continue;
																		}
																		this.$m$32644 = Language.getMessage("M802_BoldasFinalTest", UnityEngine.Random.Range(201, 220));
																		if (94993 - 592610 != -497617)
																		{
																			continue;
																		}
																	}
																	if (!(this.$m$32644 != string.Empty))
																	{
																		goto IL_1691;
																	}
																	if (107053 - 279887 == -172834)
																	{
																		Chat.SubmitChat("Boldas", this.$m$32644, eChatType.enemy, eChatMode.system);
																		if (237381 - 152039 != 85343)
																		{
																			this.$self_$32656.mChar.doChatBubble(this.$m$32644);
																			if (108022 - 39181 != 68842)
																			{
																				goto Block_68;
																			}
																		}
																	}
																}
															}
														}
													}
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
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_11C:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_2C2:
				return this.Yield(6, new WaitForSeconds(0.2f));
				IL_311:
				goto IL_197B;
				Block_22:
				goto IL_311;
				IL_37B:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_472:
				Block_33:
				IL_62A:
				goto IL_197B;
				Block_40:
				goto IL_1A;
				Block_68:
				goto IL_1691;
				IL_D09:
				goto IL_197B;
				IL_D69:
				Block_81:
				goto IL_11C;
				IL_DF3:
				Block_104:
				Block_117:
				goto IL_472;
				Block_123:
				goto IL_18DB;
				IL_1524:
				goto IL_2C2;
				IL_1691:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_18DB:
				return this.Yield(7, new WaitForSeconds(0.3f));
				IL_197B:
				return false;
			}

			// Token: 0x060049D5 RID: 18901 RVA: 0x00927AD4 File Offset: 0x00925CD4
			internal static bool AiZmDg5RzI3FO82WV6sA()
			{
				return true;
			}

			// Token: 0x060049D6 RID: 18902 RVA: 0x00927AD8 File Offset: 0x00925CD8
			internal static bool hco6lm5wa9ImiusH8gXq()
			{
				return false;
			}

			// Token: 0x04005491 RID: 21649
			internal string $m$32644;

			// Token: 0x04005492 RID: 21650
			internal int $hitLayer$32645;

			// Token: 0x04005493 RID: 21651
			internal UnityScript.Lang.Array $hitList$32646;

			// Token: 0x04005494 RID: 21652
			internal Vector3 $hitPoint$32647;

			// Token: 0x04005495 RID: 21653
			internal GameObject $hitObject$32648;

			// Token: 0x04005496 RID: 21654
			internal IEnumerator $$iterator$10773$32649;

			// Token: 0x04005497 RID: 21655
			internal GameObject $hitObject$32650;

			// Token: 0x04005498 RID: 21656
			internal IEnumerator $$iterator$10774$32651;

			// Token: 0x04005499 RID: 21657
			internal GameObject $hitObject$32652;

			// Token: 0x0400549A RID: 21658
			internal IEnumerator $$iterator$10775$32653;

			// Token: 0x0400549B RID: 21659
			internal Vector3 $mPos$32654;

			// Token: 0x0400549C RID: 21660
			internal Vector3 $tDir$32655;

			// Token: 0x0400549D RID: 21661
			internal Liger $self_$32656;
		}
	}

	// Token: 0x02000CD7 RID: 3287
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_leapingLion$32660 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060049D7 RID: 18903 RVA: 0x00927ADC File Offset: 0x00925CDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_leapingLion$32660(Vector3 mPos, Vector3 tDir, Liger self_)
		{
			if (68139 - 598343 != -530204)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175519 - 313190 != -137670)
				{
					base..ctor();
					if (238261 - 244384 != -6122)
					{
						this.$mPos$32670 = mPos;
						if (272689 - 398708 == -126019)
						{
							this.$tDir$32671 = tDir;
							if (27286 - 266534 == -239248)
							{
								this.$self_$32672 = self_;
								if (257523 - 326047 != -68523)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x00927BB8 File Offset: 0x00925DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Liger.$RPC_leapingLion$32660.$(this.$mPos$32670, this.$tDir$32671, this.$self_$32672);
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x00927BD4 File Offset: 0x00925DD4
		internal static bool yq0RP15w5jfQtSrj43Sp()
		{
			return true;
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00927BD8 File Offset: 0x00925DD8
		internal static bool xjEcqD5wp6As4uaGB9BV()
		{
			return false;
		}

		// Token: 0x0400549E RID: 21662
		internal Vector3 $mPos$32670;

		// Token: 0x0400549F RID: 21663
		internal Vector3 $tDir$32671;

		// Token: 0x040054A0 RID: 21664
		internal Liger $self_$32672;

		// Token: 0x02000CD8 RID: 3288
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060049DB RID: 18907 RVA: 0x00927BDC File Offset: 0x00925DDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Liger self_)
			{
				if (116488 - 56370 != 60119)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (130271 - 127327 != 2945)
					{
						base..ctor();
						if (138460 - 171824 != -33363)
						{
							this.$mPos$32667 = mPos;
							if (197991 - 541479 == -343488)
							{
								this.$tDir$32668 = tDir;
								if (85265 - 299243 == -213978)
								{
									this.$self_$32669 = self_;
									if (272728 - 418964 == -146236)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060049DC RID: 18908 RVA: 0x00927CB8 File Offset: 0x00925EB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (146733 - 284722 != -137988)
				{
				}
				for (;;)
				{
					IL_4E9:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B37;
					case 2:
						if (this.$self_$32669.mChar.actionState != "attack")
						{
							goto IL_65A;
						}
						if (16391 - 175542 != -159151)
						{
							continue;
						}
						if (this.$self_$32669.mChar.myCommand != "leapingLion")
						{
							if (178949 - 263048 != -84098)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							this.$self_$32669.mChar.moveSpeed = (float)0;
							if (80468 - 293269 == -212800)
							{
								continue;
							}
							if (!this.$self_$32669.mChar.isMine)
							{
								goto IL_27A;
							}
							if (49338 - 140323 != -90985)
							{
								continue;
							}
							this.$hitLayer$32662 = 130816 - (1 << this.$self_$32669.gameObject.layer);
							if (287568 - 33166 == 254403)
							{
								continue;
							}
							this.$hitList$32663 = Damage.FindRecTarget(this.$self_$32669.transform.position - (float)2 * this.$self_$32669.transform.forward, this.$self_$32669.transform.forward, (float)2, (float)2, (float)5, (float)2, this.$hitLayer$32662);
							if (224862 - 251958 != -27096)
							{
								continue;
							}
							this.$$iterator$10776$32666 = UnityRuntimeServices.GetEnumerator(this.$hitList$32663);
							if (240582 - 290973 == -50390)
							{
								continue;
							}
							while (this.$$iterator$10776$32666.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10776$32666.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32664 = (GameObject)obj2;
								if (245728 - 293848 == -48119)
								{
									goto IL_4E9;
								}
								if (this.$self_$32669.mChar.hit(11, this.$hitObject$32664, this.$self_$32669.mChar.atk, 20, 0, (float)2 * this.$self_$32669.transform.forward) != 0)
								{
									if (209648 - 530361 == -320712)
									{
										goto IL_4E9;
									}
									this.$hitPos$32665 = this.$hitObject$32664.collider.ClosestPointOnBounds(this.$self_$32669.transform.position + Vector3.up);
									if (138823 - 577777 != -438954)
									{
										goto IL_4E9;
									}
									UnityRuntimeServices.Update(this.$$iterator$10776$32666, this.$hitObject$32664);
									if (15738 - 471559 == -455820)
									{
										goto IL_4E9;
									}
									this.$self_$32669.RPC_nAttack_hit(this.$hitPos$32665, this.$self_$32669.transform.forward, 0);
									if (251323 - 398713 == -147389)
									{
										goto IL_4E9;
									}
									this.$self_$32669.ActionEvent("RPC_nAttack_hit", this.$hitPos$32665, this.$self_$32669.transform.forward, 0);
									if (6785 - 227744 != -220959)
									{
										goto IL_4E9;
									}
								}
							}
							if (240531 - 361191 != -120659)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32669.mChar.actionState == "attack")
						{
							if (93401 - 313369 != -219968)
							{
								continue;
							}
							if (this.$self_$32669.mChar.myCommand == "leapingLion")
							{
								if (261898 - 36117 != 225781)
								{
									continue;
								}
								this.$self_$32669.mChar.actionState = "standby";
								if (152673 - 435019 == -282345)
								{
									continue;
								}
								this.$self_$32669.mChar.actionTime = Time.time;
								if (213421 - 276250 != -62829)
								{
									continue;
								}
								this.$self_$32669.mChar.myCommand = "none";
								if (210599 - 566330 == -355730)
								{
									continue;
								}
								if (!this.$self_$32669.mChar.isMine)
								{
									if (233703 - 460535 == -226831)
									{
										continue;
									}
									this.$self_$32669.mChar.nPosition = this.$self_$32669.transform.position;
									if (158206 - 100513 == 57694)
									{
										continue;
									}
									this.$self_$32669.mChar.oPosition = this.$self_$32669.transform.position;
									if (204636 - 111597 == 93040)
									{
										continue;
									}
									this.$self_$32669.mChar.nDirection = this.$self_$32669.transform.forward;
									if (5685 - 202466 == -196780)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (147413 - 430663 != -283250)
						{
							continue;
						}
						goto IL_B37;
					default:
						if (95767 - 374520 != -278753)
						{
							continue;
						}
						break;
					}
					this.$self_$32669.mChar.actionState = "attack";
					if (61800 - 381140 != -319339)
					{
						this.$self_$32669.mChar.actionTime = Time.time;
						if (236712 - 57996 != 178717)
						{
							this.$self_$32669.mChar.myCommand = "leapingLion";
							if (111681 - 231063 != -119381)
							{
								this.$self_$32669.mChar.addTimeOut("leapingLion", (float)9);
								if (212903 - 308985 == -96082)
								{
									this.$self_$32669.transform.position = this.$mPos$32667;
									if (59173 - 554006 != -494832)
									{
										this.$self_$32669.transform.LookAt(this.$mPos$32667 + global::Math.vFlat(this.$tDir$32668));
										if (229607 - 11160 == 218447)
										{
											this.$self_$32669.animation.CrossFade("leapingLion");
											if (150265 - 126770 == 23495)
											{
												this.$self_$32669.animation.wrapMode = WrapMode.Once;
												if (287711 - 439947 != -152235)
												{
													this.$self_$32669.mChar.vMovement = this.$self_$32669.transform.forward;
													if (163309 - 230788 != -67478)
													{
														this.$self_$32669.mChar.moveSpeed = (float)12;
														if (252293 - 315216 != -62922)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (42736 - 379153 == -336416)
																{
																	continue;
																}
																if (UnityEngine.Random.Range(0, 2) == 0)
																{
																	if (183659 - 17910 != 165749)
																	{
																		continue;
																	}
																	if (this.$self_$32669.leapingLion1_vc)
																	{
																		if (186662 - 475750 != -289088)
																		{
																			continue;
																		}
																		this.$self_$32669.audio.PlayOneShot(this.$self_$32669.leapingLion1_vc);
																		if (259409 - 26125 != 233284)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find leapingLion1 voice");
																		if (132287 - 177763 == -45475)
																		{
																			continue;
																		}
																	}
																}
																else if (this.$self_$32669.leapingLion2_vc)
																{
																	if (191971 - 466938 == -274966)
																	{
																		continue;
																	}
																	this.$self_$32669.audio.PlayOneShot(this.$self_$32669.leapingLion2_vc);
																	if (142848 - 222468 == -79619)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find leapingLion2 voice");
																	if (130707 - 139566 == -8858)
																	{
																		continue;
																	}
																}
															}
															if (this.$self_$32669.leapingLion_ring)
															{
																if (63090 - 39336 == 23755)
																{
																	continue;
																}
																this.$self_$32669.mChar.createEffect(this.$self_$32669.leapingLion_ring, this.$self_$32669.transform.position, this.$self_$32669.transform.rotation);
																if (299050 - 281427 == 17624)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing leapingLion_ring effect");
																if (181960 - 526886 == -344925)
																{
																	continue;
																}
															}
															this.$m$32661 = string.Empty;
															if (76015 - 573525 != -497509)
															{
																if (this.$self_$32669.mChar.isControlled)
																{
																	goto IL_432;
																}
																if (197829 - 15500 != 182330)
																{
																	if (Game.mGameCode != 802)
																	{
																		goto IL_432;
																	}
																	if (147814 - 197269 != -49454)
																	{
																		this.$m$32661 = Language.getMessage("M802_BoldasFinalTest", UnityEngine.Random.Range(201, 220));
																		if (141999 - 42500 == 99499)
																		{
																			if (!(this.$m$32661 != string.Empty))
																			{
																				goto IL_432;
																			}
																			if (264394 - 589493 != -325098)
																			{
																				Chat.SubmitChat("Boldas", this.$m$32661, eChatType.enemy, eChatMode.system);
																				if (61357 - 139142 == -77785)
																				{
																					this.$self_$32669.mChar.doChatBubble(this.$m$32661);
																					if (217528 - 192235 == 25293)
																					{
																						goto IL_432;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_27A:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_26:
				goto IL_27A;
				IL_432:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_65A:
				Block_57:
				IL_B37:
				return false;
			}

			// Token: 0x060049DD RID: 18909 RVA: 0x00928810 File Offset: 0x00926A10
			internal static bool x6mFJ15wVoypEHokWGb7()
			{
				return true;
			}

			// Token: 0x060049DE RID: 18910 RVA: 0x00928814 File Offset: 0x00926A14
			internal static bool YXrIVj5wtPsGZYa6hGyV()
			{
				return false;
			}

			// Token: 0x040054A1 RID: 21665
			internal string $m$32661;

			// Token: 0x040054A2 RID: 21666
			internal int $hitLayer$32662;

			// Token: 0x040054A3 RID: 21667
			internal UnityScript.Lang.Array $hitList$32663;

			// Token: 0x040054A4 RID: 21668
			internal GameObject $hitObject$32664;

			// Token: 0x040054A5 RID: 21669
			internal Vector3 $hitPos$32665;

			// Token: 0x040054A6 RID: 21670
			internal IEnumerator $$iterator$10776$32666;

			// Token: 0x040054A7 RID: 21671
			internal Vector3 $mPos$32667;

			// Token: 0x040054A8 RID: 21672
			internal Vector3 $tDir$32668;

			// Token: 0x040054A9 RID: 21673
			internal Liger $self_$32669;
		}
	}

	// Token: 0x02000CD9 RID: 3289
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ligerSwing$32673 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x060049DF RID: 18911 RVA: 0x00928818 File Offset: 0x00926A18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ligerSwing$32673(Vector3 mPos, Vector3 tDir, int tID, Liger self_)
		{
			if (78794 - 160857 != -82063)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15728 - 394035 == -378307)
				{
					base..ctor();
					if (5098 - 204653 == -199555)
					{
						this.$mPos$32690 = mPos;
						if (137725 - 442592 != -304866)
						{
							this.$tDir$32691 = tDir;
							if (28202 - 208584 != -180381)
							{
								this.$tID$32692 = tID;
								if (264026 - 299239 != -35212)
								{
									this.$self_$32693 = self_;
									if (8201 - 332626 == -324425)
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

		// Token: 0x060049E0 RID: 18912 RVA: 0x00928918 File Offset: 0x00926B18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new Liger.$RPC_ligerSwing$32673.$(this.$mPos$32690, this.$tDir$32691, this.$tID$32692, this.$self_$32693);
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x00928938 File Offset: 0x00926B38
		internal static bool udwOoS5wNvwSQFc2AYq3()
		{
			return true;
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x0092893C File Offset: 0x00926B3C
		internal static bool ld267g5wYHADOVFqadjb()
		{
			return false;
		}

		// Token: 0x040054AA RID: 21674
		internal Vector3 $mPos$32690;

		// Token: 0x040054AB RID: 21675
		internal Vector3 $tDir$32691;

		// Token: 0x040054AC RID: 21676
		internal int $tID$32692;

		// Token: 0x040054AD RID: 21677
		internal Liger $self_$32693;

		// Token: 0x02000CDA RID: 3290
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x060049E3 RID: 18915 RVA: 0x00928940 File Offset: 0x00926B40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Liger self_)
			{
				if (231474 - 184874 != 46601)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (138325 - 303940 != -165614)
					{
						base..ctor();
						if (584 - 139936 == -139352)
						{
							this.$mPos$32686 = mPos;
							if (217888 - 163122 == 54766)
							{
								this.$tDir$32687 = tDir;
								if (213390 - 294819 == -81429)
								{
									this.$tID$32688 = tID;
									if (200180 - 382421 == -182241)
									{
										this.$self_$32689 = self_;
										if (253954 - 533980 == -280026)
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

			// Token: 0x060049E4 RID: 18916 RVA: 0x00928A40 File Offset: 0x00926C40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117917 - 241160 != -123242)
				{
				}
				for (;;)
				{
					IL_D26:
					switch (this._state)
					{
					case 0:
						goto IL_7F3;
					case 1:
						goto IL_1396;
					case 2:
						if (this.$self_$32689.mChar.actionState != "attack")
						{
							goto IL_1346;
						}
						if (94295 - 549265 == -454969)
						{
							continue;
						}
						if (this.$self_$32689.mChar.myCommand != "ligerSwing")
						{
							if (11771 - 532172 != -520400)
							{
								goto Block_60;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (84329 - 40911 != 43418)
								{
									continue;
								}
								if (this.$self_$32689.nAttack3_vc)
								{
									if (115442 - 348409 != -232967)
									{
										continue;
									}
									this.$self_$32689.audio.PlayOneShot(this.$self_$32689.nAttack3_vc);
									if (230237 - 420142 == -189904)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find nAttack3 voice");
									if (283070 - 573314 == -290243)
									{
										continue;
									}
								}
							}
							this.$self_$32689.mChar.vMovement = this.$self_$32689.transform.forward;
							if (185473 - 6542 == 178932)
							{
								continue;
							}
							this.$self_$32689.mChar.moveSpeed = (float)6;
							if (228899 - 280276 == -51376)
							{
								continue;
							}
							this.$hitLayer$32675 = 130816 - (1 << this.$self_$32689.gameObject.layer);
							if (98302 - 35497 == 62806)
							{
								continue;
							}
							this.$hitList$32676 = null;
							if (282028 - 429150 != -147122)
							{
								continue;
							}
							this.$hitPoint$32677 = default(Vector3);
							if (139233 - 501718 != -362485)
							{
								continue;
							}
							this.$a$32678 = 0;
							if (23091 - 535733 != -512642)
							{
								continue;
							}
							goto IL_FC7;
						}
						break;
					case 3:
						if (this.$self_$32689.mChar.actionState != "attack")
						{
							goto IL_8BE;
						}
						if (280408 - 220702 != 59706)
						{
							continue;
						}
						if (this.$self_$32689.mChar.myCommand != "ligerSwing")
						{
							if (282031 - 224578 != 57454)
							{
								goto Block_119;
							}
							continue;
						}
						else
						{
							this.$hitList$32676 = Damage.FindAreaTarget(this.$self_$32689.transform.position, (float)3 * this.$self_$32689.mChar.rangeMod, (float)3 * this.$self_$32689.mChar.rangeMod, this.$hitLayer$32675);
							if (199988 - 33464 == 166525)
							{
								continue;
							}
							this.$$iterator$10777$32680 = UnityRuntimeServices.GetEnumerator(this.$hitList$32676);
							if (57309 - 512095 != -454786)
							{
								continue;
							}
							while (this.$$iterator$10777$32680.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10777$32680.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32679 = (GameObject)obj2;
								if (10705 - 7204 != 3501)
								{
									goto IL_D26;
								}
								if (this.$self_$32689.mChar.hit(1, this.$hitObject$32679, this.$self_$32689.mChar.atk, 2, 0, this.$self_$32689.transform.forward) != 0)
								{
									if (195933 - 440137 == -244203)
									{
										goto IL_D26;
									}
									this.$hitPoint$32677 = this.$hitObject$32679.collider.ClosestPointOnBounds(this.$self_$32689.transform.position + Vector3.up);
									if (16371 - 133598 == -117226)
									{
										goto IL_D26;
									}
									UnityRuntimeServices.Update(this.$$iterator$10777$32680, this.$hitObject$32679);
									if (175245 - 212794 != -37549)
									{
										goto IL_D26;
									}
									this.$self_$32689.RPC_nAttack_hit(this.$hitPoint$32677, this.$self_$32689.transform.forward, 0);
									if (54305 - 553836 == -499530)
									{
										goto IL_D26;
									}
									this.$self_$32689.ActionEvent("RPC_nAttack_hit", this.$hitPoint$32677, this.$self_$32689.transform.forward, 0);
									if (105176 - 487029 != -381853)
									{
										goto IL_D26;
									}
								}
							}
							if (178179 - 454105 == -275925)
							{
								continue;
							}
							this.$a$32678++;
							if (217138 - 296534 != -79395)
							{
								goto IL_FC7;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$32689.mChar.actionState != "attack")
						{
							goto IL_101D;
						}
						if (269373 - 513736 == -244362)
						{
							continue;
						}
						if (this.$self_$32689.mChar.myCommand != "ligerSwing")
						{
							if (80384 - 181721 != -101336)
							{
								goto Block_94;
							}
							continue;
						}
						else if (this.$self_$32689.mChar.isMine)
						{
							if (120860 - 531994 == -411133)
							{
								continue;
							}
							if (this.$tObject$32682)
							{
								if (243997 - 387126 != -143129)
								{
									continue;
								}
								this.$self_$32689.mChar.vMovement = global::Math.vFlat(this.$tObject$32682.transform.position - this.$self_$32689.transform.position).normalized;
								if (243834 - 411683 != -167849)
								{
									continue;
								}
							}
							if (this.$self_$32689.mChar.actionTime + (float)this.$mSpinCount$32681 * 0.3f + (float)2 < Time.time)
							{
								if (242468 - 332025 == -89556)
								{
									continue;
								}
								this.$mSpinCount$32681++;
								if (118511 - 551854 == -433342)
								{
									continue;
								}
								this.$hitList$32676 = Damage.FindAreaTarget(this.$self_$32689.transform.position, (float)4 * this.$self_$32689.mChar.rangeMod, (float)3 * this.$self_$32689.mChar.rangeMod, this.$hitLayer$32675);
								if (218648 - 500926 == -282277)
								{
									continue;
								}
								this.$$iterator$10778$32684 = UnityRuntimeServices.GetEnumerator(this.$hitList$32676);
								if (153023 - 363869 != -210846)
								{
									continue;
								}
								while (this.$$iterator$10778$32684.MoveNext())
								{
									object obj4;
									object obj3 = obj4 = this.$$iterator$10778$32684.Current;
									if (!(obj3 is GameObject))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
									}
									this.$hitObject$32683 = (GameObject)obj4;
									if (149930 - 209012 != -59082)
									{
										goto IL_D26;
									}
									if (this.$self_$32689.mChar.hit(1, this.$hitObject$32683, this.$self_$32689.mChar.atk, 2, 0, this.$self_$32689.transform.forward) != 0)
									{
										if (289472 - 36243 != 253229)
										{
											goto IL_D26;
										}
										this.$hitPoint$32677 = this.$hitObject$32683.collider.ClosestPointOnBounds(this.$self_$32689.transform.position + Vector3.up);
										if (223424 - 244499 == -21074)
										{
											goto IL_D26;
										}
										UnityRuntimeServices.Update(this.$$iterator$10778$32684, this.$hitObject$32683);
										if (52494 - 403844 != -351350)
										{
											goto IL_D26;
										}
										this.$self_$32689.RPC_nAttack_hit(this.$hitPoint$32677, this.$self_$32689.transform.forward, 0);
										if (285377 - 307545 == -22167)
										{
											goto IL_D26;
										}
										this.$self_$32689.ActionEvent("RPC_nAttack_hit", this.$hitPoint$32677, this.$self_$32689.transform.forward, 0);
										if (32751 - 462691 == -429939)
										{
											goto IL_D26;
										}
									}
								}
								if (194442 - 99301 != 95141)
								{
									continue;
								}
							}
						}
						else
						{
							this.$nTargetPosition$32685 = global::Math.vFlat(this.$self_$32689.mChar.nPosition - this.$self_$32689.transform.position);
							if (22489 - 493621 != -471132)
							{
								continue;
							}
							this.$self_$32689.mChar.vMovement = this.$nTargetPosition$32685.normalized;
							if (211496 - 78605 == 132892)
							{
								continue;
							}
							this.$self_$32689.mChar.moveSpeed = Mathf.Lerp(this.$self_$32689.mChar.moveSpeed, (float)3 * this.$nTargetPosition$32685.magnitude, (float)4 * Time.deltaTime);
							if (196067 - 459330 == -263262)
							{
								continue;
							}
						}
						break;
					default:
						if (76515 - 523164 != -446649)
						{
							continue;
						}
						goto IL_7F3;
					}
					IL_261:
					if (this.$self_$32689.mChar.actionTime + (float)6 > Time.time)
					{
						goto IL_112E;
					}
					if (154082 - 210774 != -56692)
					{
						continue;
					}
					if (this.$self_$32689.mChar.actionState == "attack")
					{
						if (196726 - 589072 == -392345)
						{
							continue;
						}
						if (this.$self_$32689.mChar.myCommand == "ligerSwing")
						{
							if (260903 - 308821 != -47918)
							{
								continue;
							}
							this.$self_$32689.mChar.actionState = "standby";
							if (25281 - 492562 != -467281)
							{
								continue;
							}
							this.$self_$32689.mChar.actionTime = Time.time;
							if (15497 - 336355 == -320857)
							{
								continue;
							}
							this.$self_$32689.mChar.myCommand = "none";
							if (231930 - 6850 == 225081)
							{
								continue;
							}
							if (!this.$self_$32689.mChar.isMine)
							{
								if (37968 - 403083 != -365115)
								{
									continue;
								}
								this.$self_$32689.mChar.nPosition = this.$self_$32689.transform.position;
								if (45439 - 123377 != -77938)
								{
									continue;
								}
								this.$self_$32689.mChar.oPosition = this.$self_$32689.transform.position;
								if (200371 - 431373 == -231001)
								{
									continue;
								}
								this.$self_$32689.mChar.nDirection = this.$self_$32689.transform.forward;
								if (19058 - 236041 != -216983)
								{
									continue;
								}
							}
						}
					}
					this.YieldDefault(1);
					if (105520 - 187904 != -82384)
					{
						continue;
					}
					goto IL_1396;
					IL_FC7:
					if (this.$a$32678 < 2)
					{
						break;
					}
					if (36181 - 571576 != -535395)
					{
						continue;
					}
					this.$self_$32689.animation.CrossFade("ligerSwing2");
					if (192725 - 162432 != 30293)
					{
						continue;
					}
					this.$self_$32689.animation.wrapMode = WrapMode.Loop;
					if (85625 - 150392 == -64766)
					{
						continue;
					}
					this.$self_$32689.mChar.vMovement = this.$self_$32689.transform.forward;
					if (35126 - 520009 == -484882)
					{
						continue;
					}
					this.$self_$32689.mChar.moveSpeed = (float)5;
					if (150020 - 191264 != -41244)
					{
						continue;
					}
					if (this.$self_$32689.ligerSwing_spin)
					{
						if (177372 - 124106 == 53267)
						{
							continue;
						}
						this.$self_$32689.mChar.createEffect(this.$self_$32689.ligerSwing_spin, this.$self_$32689.transform.position, this.$self_$32689.transform.rotation);
						if (296068 - 427060 != -130992)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing ligerSwing_spin effect");
						if (265863 - 130289 == 135575)
						{
							continue;
						}
					}
					this.$mSpinCount$32681 = 0;
					if (101490 - 154659 == -53168)
					{
						continue;
					}
					this.$tObject$32682 = null;
					if (227717 - 178809 != 48908)
					{
						continue;
					}
					if (this.$tID$32688 != 0)
					{
						if (193253 - 549388 != -356135)
						{
							continue;
						}
						object obj6;
						object obj5 = obj6 = PhotonClient.ActorNrList[this.$tID$32688];
						if (!(obj5 is GameObject))
						{
							obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
						}
						this.$tObject$32682 = (GameObject)obj6;
						if (9846 - 550013 != -540167)
						{
							continue;
						}
					}
					goto IL_261;
					IL_7F3:
					this.$self_$32689.mChar.actionState = "attack";
					if (67105 - 109718 == -42613)
					{
						this.$self_$32689.mChar.actionTime = Time.time;
						if (215140 - 347987 != -132846)
						{
							this.$self_$32689.mChar.myCommand = "ligerSwing";
							if (115988 - 237056 != -121067)
							{
								this.$self_$32689.mChar.addTimeOut("ligerSwing", (float)30);
								if (154214 - 116049 != 38166)
								{
									this.$self_$32689.transform.position = this.$mPos$32686;
									if (234212 - 302987 != -68774)
									{
										this.$self_$32689.transform.LookAt(this.$mPos$32686 + global::Math.vFlat(this.$tDir$32687));
										if (9735 - 106519 == -96784)
										{
											this.$self_$32689.animation.CrossFade("ligerSwing1");
											if (213387 - 478006 == -264619)
											{
												this.$self_$32689.animation.wrapMode = WrapMode.Once;
												if (253141 - 503919 != -250777)
												{
													this.$self_$32689.mChar.vMovement = this.$self_$32689.transform.forward;
													if (263661 - 84539 == 179122)
													{
														this.$self_$32689.mChar.moveSpeed = (float)0;
														if (229299 - 480594 == -251295)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (229036 - 211850 == 17187)
																{
																	continue;
																}
																if (this.$self_$32689.ligerSwing_vc)
																{
																	if (177996 - 514965 != -336969)
																	{
																		continue;
																	}
																	this.$self_$32689.audio.PlayOneShot(this.$self_$32689.ligerSwing_vc);
																	if (223124 - 21664 != 201460)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find ligerSwing voice");
																	if (282103 - 299631 == -17527)
																	{
																		continue;
																	}
																}
															}
															if (this.$self_$32689.ligerSwing_ring)
															{
																if (198965 - 323672 != -124707)
																{
																	continue;
																}
																this.$self_$32689.mChar.createEffect(this.$self_$32689.ligerSwing_ring, this.$self_$32689.transform.position, this.$self_$32689.transform.rotation);
																if (72079 - 493736 == -421656)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing ligerSwing_ring effect");
																if (261302 - 569938 != -308636)
																{
																	continue;
																}
															}
															this.$m$32674 = string.Empty;
															if (160331 - 310702 != -150370)
															{
																if (this.$self_$32689.mChar.isControlled)
																{
																	goto IL_F78;
																}
																if (284260 - 591905 != -307644)
																{
																	if (Game.mGameCode != 802)
																	{
																		goto IL_F78;
																	}
																	if (284349 - 332378 == -48029)
																	{
																		this.$m$32674 = Language.getMessage("M802_BoldasFinalTest", UnityEngine.Random.Range(201, 220));
																		if (187079 - 159469 != 27611)
																		{
																			if (!(this.$m$32674 != string.Empty))
																			{
																				goto IL_F78;
																			}
																			if (182305 - 84659 != 97647)
																			{
																				Chat.SubmitChat("Boldas", this.$m$32674, eChatType.enemy, eChatMode.system);
																				if (235269 - 515491 != -280221)
																				{
																					this.$self_$32689.mChar.doChatBubble(this.$m$32674);
																					if (289350 - 86348 != 203003)
																					{
																						goto Block_56;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_8BE:
				goto IL_1396;
				Block_56:
				goto IL_F78;
				Block_60:
				Block_94:
				goto IL_101D;
				IL_F78:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_101D:
				goto IL_1396;
				IL_112E:
				return this.Yield(4, new WaitForFixedUpdate());
				Block_119:
				IL_1346:
				IL_1396:
				return false;
			}

			// Token: 0x060049E5 RID: 18917 RVA: 0x00929DF8 File Offset: 0x00927FF8
			internal static bool Aiacye5wcxlKsoVQH24f()
			{
				return true;
			}

			// Token: 0x060049E6 RID: 18918 RVA: 0x00929DFC File Offset: 0x00927FFC
			internal static bool iRvoii5wUQ9pP6xVSOBp()
			{
				return false;
			}

			// Token: 0x040054AE RID: 21678
			internal string $m$32674;

			// Token: 0x040054AF RID: 21679
			internal int $hitLayer$32675;

			// Token: 0x040054B0 RID: 21680
			internal UnityScript.Lang.Array $hitList$32676;

			// Token: 0x040054B1 RID: 21681
			internal Vector3 $hitPoint$32677;

			// Token: 0x040054B2 RID: 21682
			internal int $a$32678;

			// Token: 0x040054B3 RID: 21683
			internal GameObject $hitObject$32679;

			// Token: 0x040054B4 RID: 21684
			internal IEnumerator $$iterator$10777$32680;

			// Token: 0x040054B5 RID: 21685
			internal int $mSpinCount$32681;

			// Token: 0x040054B6 RID: 21686
			internal GameObject $tObject$32682;

			// Token: 0x040054B7 RID: 21687
			internal GameObject $hitObject$32683;

			// Token: 0x040054B8 RID: 21688
			internal IEnumerator $$iterator$10778$32684;

			// Token: 0x040054B9 RID: 21689
			internal Vector3 $nTargetPosition$32685;

			// Token: 0x040054BA RID: 21690
			internal Vector3 $mPos$32686;

			// Token: 0x040054BB RID: 21691
			internal Vector3 $tDir$32687;

			// Token: 0x040054BC RID: 21692
			internal int $tID$32688;

			// Token: 0x040054BD RID: 21693
			internal Liger $self_$32689;
		}
	}

	// Token: 0x02000CDB RID: 3291
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_crushingTiger$32694 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060049E7 RID: 18919 RVA: 0x00929E00 File Offset: 0x00928000
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_crushingTiger$32694(Vector3 mPos, Vector3 tDir, Liger self_)
		{
			if (25107 - 215900 != -190793)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175000 - 541233 != -366232)
				{
					base..ctor();
					if (101711 - 247319 != -145607)
					{
						this.$mPos$32704 = mPos;
						if (246218 - 517761 == -271543)
						{
							this.$tDir$32705 = tDir;
							if (24738 - 71587 == -46849)
							{
								this.$self_$32706 = self_;
								if (86031 - 444636 == -358605)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x00929EDC File Offset: 0x009280DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Liger.$RPC_crushingTiger$32694.$(this.$mPos$32704, this.$tDir$32705, this.$self_$32706);
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x00929EF8 File Offset: 0x009280F8
		internal static bool H5x5uK5wTdw0e3AwEB8q()
		{
			return true;
		}

		// Token: 0x060049EA RID: 18922 RVA: 0x00929EFC File Offset: 0x009280FC
		internal static bool cfH6Uv5w3Oneo7CS7SRq()
		{
			return false;
		}

		// Token: 0x040054BE RID: 21694
		internal Vector3 $mPos$32704;

		// Token: 0x040054BF RID: 21695
		internal Vector3 $tDir$32705;

		// Token: 0x040054C0 RID: 21696
		internal Liger $self_$32706;

		// Token: 0x02000CDC RID: 3292
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060049EB RID: 18923 RVA: 0x00929F00 File Offset: 0x00928100
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Liger self_)
			{
				if (76029 - 442965 != -366935)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (92008 - 23422 != 68587)
					{
						base..ctor();
						if (245181 - 309008 != -63826)
						{
							this.$mPos$32701 = mPos;
							if (212258 - 379609 != -167350)
							{
								this.$tDir$32702 = tDir;
								if (173833 - 86552 == 87281)
								{
									this.$self_$32703 = self_;
									if (254875 - 582557 != -327681)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060049EC RID: 18924 RVA: 0x00929FDC File Offset: 0x009281DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (195348 - 527220 != -331871)
				{
				}
				for (;;)
				{
					IL_7AF:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D2B;
					case 2:
						if (this.$self_$32703.mChar.actionState != "attack")
						{
							goto IL_2E7;
						}
						if (68975 - 527507 == -458531)
						{
							continue;
						}
						if (this.$self_$32703.mChar.myCommand != "crushingTiger")
						{
							if (175337 - 184319 != -8982)
							{
								continue;
							}
							goto IL_2E7;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_A3B;
							}
							if (43508 - 171037 == -127528)
							{
								continue;
							}
							if (this.$self_$32703.crushingTiger2_vc)
							{
								if (53722 - 25876 == 27847)
								{
									continue;
								}
								this.$self_$32703.audio.PlayOneShot(this.$self_$32703.crushingTiger2_vc);
								if (96342 - 450489 != -354147)
								{
									continue;
								}
								goto IL_B78;
							}
							else
							{
								Debug.LogError("Cannot find crushingTiger2 voice");
								if (33944 - 593600 != -559656)
								{
									continue;
								}
								goto IL_A3B;
							}
						}
						break;
					case 3:
						if (this.$self_$32703.mChar.actionState != "attack")
						{
							goto IL_97B;
						}
						if (130374 - 470668 != -340294)
						{
							continue;
						}
						if (this.$self_$32703.mChar.myCommand != "crushingTiger")
						{
							if (221793 - 497359 != -275565)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							if (this.$self_$32703.crushingTiger_hit)
							{
								if (230943 - 231045 != -102)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$32703.crushingTiger_hit, this.$self_$32703.transform.position + this.$self_$32703.transform.TransformDirection((float)0, (float)0, 1.25f), this.$self_$32703.transform.rotation);
								if (253937 - 337408 == -83470)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing crushingTiger_hit Effect");
								if (122123 - 142297 == -20173)
								{
									continue;
								}
							}
							this.$i$32696 = 0;
							if (142002 - 383392 != -241389)
							{
								goto IL_490;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$32703.mChar.actionState != "attack")
						{
							goto IL_A07;
						}
						if (90967 - 192320 == -101352)
						{
							continue;
						}
						if (this.$self_$32703.mChar.myCommand != "crushingTiger")
						{
							if (273440 - 387619 != -114178)
							{
								goto Block_56;
							}
							continue;
						}
						else
						{
							if (this.$self_$32703.mChar.isMine)
							{
								if (58100 - 276946 != -218846)
								{
									continue;
								}
								this.$hitLayer$32697 = 130816 - (1 << this.$self_$32703.gameObject.layer);
								if (75822 - 491186 != -415364)
								{
									continue;
								}
								this.$hitList$32698 = Damage.FindAreaTarget(this.$self_$32703.transform.position, (float)16 * this.$self_$32703.mChar.rangeMod, (float)4 * this.$self_$32703.mChar.rangeMod, this.$hitLayer$32697);
								if (178959 - 162652 != 16307)
								{
									continue;
								}
								this.$$iterator$10779$32700 = UnityRuntimeServices.GetEnumerator(this.$hitList$32698);
								if (274599 - 453994 == -179394)
								{
									continue;
								}
								while (this.$$iterator$10779$32700.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10779$32700.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$32699 = (GameObject)obj2;
									if (186646 - 556956 != -370310)
									{
										goto IL_7AF;
									}
									this.$self_$32703.mChar.hit(1, this.$hitObject$32699, this.$self_$32703.mChar.atk + this.$self_$32703.mChar.talAdjust(45), 2, 0, global::Math.vFlat(this.$hitObject$32699.transform.position - this.$self_$32703.transform.position));
									if (276930 - 221853 != 55077)
									{
										goto IL_7AF;
									}
									UnityRuntimeServices.Update(this.$$iterator$10779$32700, this.$hitObject$32699);
									if (95985 - 148906 != -52921)
									{
										goto IL_7AF;
									}
								}
								if (159062 - 346936 == -187873)
								{
									continue;
								}
							}
							this.$i$32696++;
							if (20467 - 177566 != -157099)
							{
								continue;
							}
							goto IL_490;
						}
						break;
					case 5:
						if (this.$self_$32703.mChar.actionState == "attack")
						{
							if (121897 - 235402 != -113505)
							{
								continue;
							}
							if (this.$self_$32703.mChar.myCommand == "crushingTiger")
							{
								if (249496 - 365221 != -115725)
								{
									continue;
								}
								this.$self_$32703.mChar.moveSpeed = (float)0;
								if (276616 - 5029 == 271588)
								{
									continue;
								}
								this.$self_$32703.mChar.actionState = "standby";
								if (15092 - 446256 == -431163)
								{
									continue;
								}
								this.$self_$32703.mChar.actionTime = Time.time;
								if (175304 - 341405 != -166101)
								{
									continue;
								}
								this.$self_$32703.mChar.myCommand = "none";
								if (51520 - 432 == 51089)
								{
									continue;
								}
								if (!this.$self_$32703.mChar.isMine)
								{
									if (248939 - 170604 != 78335)
									{
										continue;
									}
									this.$self_$32703.mChar.nPosition = this.$self_$32703.transform.position;
									if (271653 - 223249 == 48405)
									{
										continue;
									}
									this.$self_$32703.mChar.oPosition = this.$self_$32703.transform.position;
									if (86095 - 496215 == -410119)
									{
										continue;
									}
									this.$self_$32703.mChar.nDirection = this.$self_$32703.transform.forward;
									if (268718 - 46021 != 222697)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (48022 - 449786 != -401763)
						{
							goto Block_5;
						}
						continue;
					default:
						if (250203 - 541499 != -291296)
						{
							continue;
						}
						break;
					}
					this.$self_$32703.mChar.actionState = "attack";
					if (29298 - 458161 != -428863)
					{
						continue;
					}
					this.$self_$32703.mChar.actionTime = Time.time;
					if (271639 - 592336 == -320696)
					{
						continue;
					}
					this.$self_$32703.mChar.myCommand = "crushingTiger";
					if (12021 - 319711 != -307690)
					{
						continue;
					}
					this.$self_$32703.mChar.addTimeOut("crushingTiger", (float)30);
					if (3129 - 56444 != -53315)
					{
						continue;
					}
					this.$self_$32703.transform.position = this.$mPos$32701;
					if (164647 - 493010 != -328363)
					{
						continue;
					}
					this.$self_$32703.transform.LookAt(this.$mPos$32701 + global::Math.vFlat(this.$tDir$32702));
					if (69528 - 177177 == -107648)
					{
						continue;
					}
					this.$self_$32703.animation.CrossFade("crushingTiger");
					if (119888 - 583146 == -463257)
					{
						continue;
					}
					this.$self_$32703.animation.wrapMode = WrapMode.Once;
					if (127996 - 289979 == -161982)
					{
						continue;
					}
					this.$self_$32703.mChar.vMovement = this.$self_$32703.transform.forward;
					if (216331 - 73568 != 142763)
					{
						continue;
					}
					this.$self_$32703.mChar.moveSpeed = (float)0;
					if (168570 - 537686 != -369116)
					{
						continue;
					}
					this.$self_$32703.mChar.StartCoroutine_Auto(this.$self_$32703.mChar.addStatus("noForce", 1, 2, 0, this.$self_$32703.mChar.ActorNr));
					if (51494 - 230999 != -179505)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) != 0)
					{
						if (59858 - 339240 != -279382)
						{
							continue;
						}
						if (this.$self_$32703.crushingTiger1_vc)
						{
							if (251886 - 161180 != 90706)
							{
								continue;
							}
							this.$self_$32703.audio.PlayOneShot(this.$self_$32703.crushingTiger1_vc);
							if (246236 - 333735 == -87498)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find crushingTiger1 voice");
							if (179385 - 413570 != -234185)
							{
								continue;
							}
						}
					}
					this.$m$32695 = string.Empty;
					if (224748 - 443840 == -219091)
					{
						continue;
					}
					if (!this.$self_$32703.mChar.isControlled)
					{
						if (148004 - 322050 != -174046)
						{
							continue;
						}
						if (Game.mGameCode == 802)
						{
							if (145 - 78813 != -78668)
							{
								continue;
							}
							this.$m$32695 = Language.getMessage("M802_BoldasFinalTest", UnityEngine.Random.Range(215, 220));
							if (216561 - 163192 != 53369)
							{
								continue;
							}
							if (this.$m$32695 != string.Empty)
							{
								if (69736 - 540683 == -470946)
								{
									continue;
								}
								Chat.SubmitChat("Boldas", this.$m$32695, eChatType.enemy, eChatMode.system);
								if (176335 - 441513 != -265178)
								{
									continue;
								}
								this.$self_$32703.mChar.doChatBubble(this.$m$32695);
								if (61868 - 252324 != -190456)
								{
									continue;
								}
							}
						}
					}
					if (this.$self_$32703.crushingTiger_ring)
					{
						if (18564 - 226526 != -207962)
						{
							continue;
						}
						this.$self_$32703.mChar.createEffect(this.$self_$32703.crushingTiger_ring, this.$self_$32703.transform.position, this.$self_$32703.transform.rotation);
						if (280599 - 214876 != 65724)
						{
							goto Block_57;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing crushingTiger_ring Effect");
						if (18866 - 266102 != -247235)
						{
							goto Block_53;
						}
						continue;
					}
					IL_490:
					if (this.$i$32696 < 2)
					{
						break;
					}
					if (36339 - 429520 == -393181)
					{
						goto IL_3AB;
					}
				}
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_5:
				goto IL_D2B;
				IL_215:
				return this.Yield(2, new WaitForSeconds(1.2f));
				IL_2E7:
				goto IL_D2B;
				IL_3AB:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_49:
				goto IL_97B;
				Block_53:
				goto IL_215;
				Block_56:
				goto IL_A07;
				Block_57:
				goto IL_215;
				IL_97B:
				IL_A07:
				goto IL_D2B;
				IL_A3B:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_B78:
				goto IL_A3B;
				IL_D2B:
				return false;
			}

			// Token: 0x060049ED RID: 18925 RVA: 0x0092AD28 File Offset: 0x00928F28
			internal static bool YgP4Ro5wXoFki3woEXcn()
			{
				return true;
			}

			// Token: 0x060049EE RID: 18926 RVA: 0x0092AD2C File Offset: 0x00928F2C
			internal static bool Gu4sJV5wQFfc5NTuengX()
			{
				return false;
			}

			// Token: 0x040054C1 RID: 21697
			internal string $m$32695;

			// Token: 0x040054C2 RID: 21698
			internal int $i$32696;

			// Token: 0x040054C3 RID: 21699
			internal int $hitLayer$32697;

			// Token: 0x040054C4 RID: 21700
			internal UnityScript.Lang.Array $hitList$32698;

			// Token: 0x040054C5 RID: 21701
			internal GameObject $hitObject$32699;

			// Token: 0x040054C6 RID: 21702
			internal IEnumerator $$iterator$10779$32700;

			// Token: 0x040054C7 RID: 21703
			internal Vector3 $mPos$32701;

			// Token: 0x040054C8 RID: 21704
			internal Vector3 $tDir$32702;

			// Token: 0x040054C9 RID: 21705
			internal Liger $self_$32703;
		}
	}

	// Token: 0x02000CDD RID: 3293
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32707 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060049EF RID: 18927 RVA: 0x0092AD30 File Offset: 0x00928F30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32707(UnityScript.Lang.Array nArray, Liger self_)
		{
			if (143983 - 127243 != 16741)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (238425 - 219501 == 18924)
				{
					base..ctor();
					if (22348 - 295867 != -273518)
					{
						this.$nArray$32713 = nArray;
						if (185746 - 69220 != 116527)
						{
							this.$self_$32714 = self_;
							if (116468 - 587282 == -470814)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x0092ADEC File Offset: 0x00928FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Liger.$RPC_ko$32707.$(this.$nArray$32713, this.$self_$32714);
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x0092AE00 File Offset: 0x00929000
		internal static bool hiB4Jd5wksnsHSAFxFmn()
		{
			return true;
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x0092AE04 File Offset: 0x00929004
		internal static bool msuL8m5wGXM6l7bgAtH0()
		{
			return false;
		}

		// Token: 0x040054CA RID: 21706
		internal UnityScript.Lang.Array $nArray$32713;

		// Token: 0x040054CB RID: 21707
		internal Liger $self_$32714;

		// Token: 0x02000CDE RID: 3294
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060049F3 RID: 18931 RVA: 0x0092AE08 File Offset: 0x00929008
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Liger self_)
			{
				if (2005 - 527095 != -525089)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (280644 - 224397 != 56248)
					{
						base..ctor();
						if (59206 - 6862 == 52344)
						{
							this.$nArray$32711 = nArray;
							if (175675 - 322592 == -146917)
							{
								this.$self_$32712 = self_;
								if (292869 - 86379 == 206490)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060049F4 RID: 18932 RVA: 0x0092AEC4 File Offset: 0x009290C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286752 - 141966 != 144786)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6AD;
					case 2:
						if (this.$self_$32712.mChar.actionState != "ko")
						{
							if (3791 - 535797 != -532006)
							{
								continue;
							}
							goto IL_52B;
						}
						else
						{
							this.$self_$32712.animation.Play("getUp");
							if (220144 - 211200 == 8945)
							{
								continue;
							}
							this.$self_$32712.animation.wrapMode = WrapMode.Once;
							if (282480 - 340388 != -57907)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32712.mChar.actionState != "ko")
						{
							if (156498 - 42653 != 113846)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							this.$self_$32712.mChar.actionState = "standby";
							if (129800 - 429616 == -299815)
							{
								continue;
							}
							this.$self_$32712.mChar.actionTime = Time.time;
							if (71714 - 172506 == -100791)
							{
								continue;
							}
							this.$self_$32712.mChar.myCommand = "none";
							if (68806 - 355024 != -286218)
							{
								continue;
							}
							this.$self_$32712.mChar.ko = this.$self_$32712.mChar.mko;
							if (137844 - 577241 == -439396)
							{
								continue;
							}
							this.YieldDefault(1);
							if (228068 - 423222 != -195154)
							{
								continue;
							}
							goto IL_6AD;
						}
						break;
					default:
						if (15633 - 248297 == -232663)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32712.mLigerType == eLiger.mallet)
					{
						if (171876 - 92955 != 78921)
						{
							continue;
						}
						this.$m$32708 = null;
						if (246183 - 55734 != 190449)
						{
							continue;
						}
						if (this.$self_$32712.Vaic56G6WEb <= 103)
						{
							if (46213 - 247817 == -201603)
							{
								continue;
							}
							this.$self_$32712.Vaic56G6WEb = this.$self_$32712.Vaic56G6WEb + 1;
							if (196216 - 591831 == -395614)
							{
								continue;
							}
							this.$m$32708 = Language.getMessage("M106_BoldasRecruitment", this.$self_$32712.Vaic56G6WEb);
							if (229092 - 538261 == -309168)
							{
								continue;
							}
						}
						if (this.$m$32708 != string.Empty)
						{
							if (209421 - 370410 == -160988)
							{
								continue;
							}
							Chat.SubmitChat("Boldas", this.$m$32708, eChatType.enemy, eChatMode.system);
							if (145870 - 248811 == -102940)
							{
								continue;
							}
							this.$self_$32712.mChar.doChatBubble(this.$m$32708);
							if (107317 - 547526 != -440209)
							{
								continue;
							}
						}
					}
					if (this.$self_$32712.mChar.actionState == "ko")
					{
						break;
					}
					if (282591 - 122292 == 160299)
					{
						if (this.$self_$32712.mChar.actionState == "dead")
						{
							if (290691 - 108130 != 182562)
							{
								break;
							}
						}
						else
						{
							this.$mPos$32709 = (Vector3)this.$nArray$32711[0];
							if (175026 - 56643 != 118384)
							{
								this.$mDir$32710 = (Vector3)this.$nArray$32711[1];
								if (6360 - 170639 != -164278)
								{
									this.$self_$32712.mChar.ko = 0;
									if (191202 - 481193 != -289990)
									{
										this.$self_$32712.mChar.actionState = "ko";
										if (146690 - 358520 == -211830)
										{
											this.$self_$32712.mChar.actionTime = Time.time;
											if (35927 - 27247 != 8681)
											{
												this.$self_$32712.mChar.myCommand = "none";
												if (273417 - 419459 != -146041)
												{
													this.$self_$32712.mChar.vMovement = Vector3.zero;
													if (75359 - 78212 == -2853)
													{
														this.$self_$32712.mChar.moveSpeed = (float)0;
														if (215740 - 330420 != -114679)
														{
															this.$self_$32712.animation.Play("ko");
															if (227619 - 413185 != -185565)
															{
																this.$self_$32712.animation.wrapMode = WrapMode.Once;
																if (202907 - 329662 == -126755)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		goto IL_65E;
																	}
																	if (271561 - 236020 != 35542)
																	{
																		if (this.$self_$32712.ko_vc)
																		{
																			if (239413 - 565522 == -326109)
																			{
																				this.$self_$32712.audio.PlayOneShot(this.$self_$32712.ko_vc);
																				if (190511 - 19790 != 170722)
																				{
																					goto Block_10;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (63255 - 58568 == 4687)
																			{
																				goto IL_65E;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4A5;
				Block_10:
				goto IL_65E;
				Block_30:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_4A5:
				IL_52B:
				Block_39:
				goto IL_6AD;
				IL_65E:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_6AD:
				return false;
			}

			// Token: 0x060049F5 RID: 18933 RVA: 0x0092B590 File Offset: 0x00929790
			internal static bool GwRHrR5wHKQtUbJddRFg()
			{
				return true;
			}

			// Token: 0x060049F6 RID: 18934 RVA: 0x0092B594 File Offset: 0x00929794
			internal static bool AaSIo65wWee6wrEhinfn()
			{
				return false;
			}

			// Token: 0x040054CC RID: 21708
			internal string $m$32708;

			// Token: 0x040054CD RID: 21709
			internal Vector3 $mPos$32709;

			// Token: 0x040054CE RID: 21710
			internal Vector3 $mDir$32710;

			// Token: 0x040054CF RID: 21711
			internal UnityScript.Lang.Array $nArray$32711;

			// Token: 0x040054D0 RID: 21712
			internal Liger $self_$32712;
		}
	}

	// Token: 0x02000CDF RID: 3295
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32715 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060049F7 RID: 18935 RVA: 0x0092B598 File Offset: 0x00929798
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32715(UnityScript.Lang.Array nArray, Liger self_)
		{
			if (299202 - 369327 != -70124)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (191628 - 495418 != -303789)
				{
					base..ctor();
					if (43402 - 395027 == -351625)
					{
						this.$nArray$32725 = nArray;
						if (142640 - 52453 != 90188)
						{
							this.$self_$32726 = self_;
							if (42224 - 372354 == -330130)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x0092B654 File Offset: 0x00929854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Liger.$RPC_dead$32715.$(this.$nArray$32725, this.$self_$32726);
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x0092B668 File Offset: 0x00929868
		internal static bool MwANnU5wAmcMwukKT07P()
		{
			return true;
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x0092B66C File Offset: 0x0092986C
		internal static bool RRMRXk5wlHKZ8YqiIX2B()
		{
			return false;
		}

		// Token: 0x040054D1 RID: 21713
		internal UnityScript.Lang.Array $nArray$32725;

		// Token: 0x040054D2 RID: 21714
		internal Liger $self_$32726;

		// Token: 0x02000CE0 RID: 3296
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060049FB RID: 18939 RVA: 0x0092B670 File Offset: 0x00929870
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Liger self_)
			{
				if (251616 - 183807 != 67809)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229607 - 390408 == -160801)
					{
						base..ctor();
						if (110686 - 561316 == -450630)
						{
							this.$nArray$32723 = nArray;
							if (208507 - 271252 == -62745)
							{
								this.$self_$32724 = self_;
								if (230618 - 66572 != 164047)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060049FC RID: 18940 RVA: 0x0092B72C File Offset: 0x0092992C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (105003 - 442868 != -337865)
				{
				}
				for (;;)
				{
					IL_61B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_64C;
					case 2:
						if (this.$self_$32724.mChar.actionState != "dead")
						{
							if (34827 - 251995 != -217168)
							{
								continue;
							}
							goto IL_155;
						}
						else
						{
							if (!this.$self_$32724.mChar.isPlayer)
							{
								if (139246 - 399446 == -260199)
								{
									continue;
								}
								this.$mGameObjectList$32718 = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy"));
								if (224148 - 224001 != 147)
								{
									continue;
								}
								this.$$11488$32720 = 0;
								if (118102 - 572110 != -454008)
								{
									continue;
								}
								this.$$11489$32721 = this.$mGameObjectList$32718;
								if (213234 - 562295 == -349060)
								{
									continue;
								}
								this.$$11490$32722 = this.$$11489$32721.Length;
								if (213613 - 407308 != -193695)
								{
									continue;
								}
								while (this.$$11488$32720 < this.$$11490$32722)
								{
									if (this.$$11489$32721[this.$$11488$32720] != this.$self_$32724.gameObject)
									{
										if (126504 - 356540 == -230035)
										{
											goto IL_61B;
										}
										Physics.IgnoreCollision(this.$$11489$32721[this.$$11488$32720].collider, this.$self_$32724.gameObject.collider, true);
										if (64818 - 466696 == -401877)
										{
											goto IL_61B;
										}
									}
									this.$$11488$32720++;
									if (213422 - 592466 != -379044)
									{
										goto IL_61B;
									}
								}
								if (238037 - 326088 != -88051)
								{
									continue;
								}
							}
							else if (this.$self_$32724.mChar.isMine)
							{
								if (1255 - 474184 == -472928)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32724.gameObject);
								if (26598 - 312539 == -285940)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (270757 - 233996 != 36761)
							{
								continue;
							}
							goto IL_64C;
						}
						break;
					default:
						if (146615 - 579842 != -433227)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32724.mChar.actionState == "dead")
					{
						if (166712 - 54750 == 111962)
						{
							goto IL_22C;
						}
					}
					else
					{
						this.$myPosition$32716 = (Vector3)this.$nArray$32723[0];
						if (275957 - 270129 == 5828)
						{
							this.$myDirection$32717 = (Vector3)this.$nArray$32723[1];
							if (226885 - 575188 == -348303)
							{
								this.$self_$32724.transform.position = this.$myPosition$32716;
								if (47985 - 129334 == -81349)
								{
									this.$self_$32724.transform.LookAt(this.$myPosition$32716 + this.$myDirection$32717);
									if (282825 - 179068 == 103757)
									{
										this.$self_$32724.mChar.hp = 0;
										if (207325 - 302343 != -95017)
										{
											this.$self_$32724.mChar.actionState = "dead";
											if (30369 - 598878 == -568509)
											{
												this.$self_$32724.mChar.actionTime = Time.time;
												if (272775 - 383276 != -110500)
												{
													this.$self_$32724.mChar.myCommand = "none";
													if (122459 - 387408 != -264948)
													{
														this.$self_$32724.mChar.vMovement = Vector3.zero;
														if (130607 - 588564 != -457956)
														{
															this.$self_$32724.mChar.moveSpeed = (float)0;
															if (129709 - 368467 != -238757)
															{
																this.$self_$32724.animation.Rewind();
																if (25750 - 15080 == 10670)
																{
																	this.$self_$32724.animation.Play("ko");
																	if (62169 - 553105 != -490935)
																	{
																		this.$self_$32724.animation.wrapMode = WrapMode.Once;
																		if (16431 - 194075 == -177644)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				break;
																			}
																			if (245174 - 569596 != -324421)
																			{
																				if (this.$self_$32724.dead_vc)
																				{
																					if (7103 - 257972 == -250869)
																					{
																						this.$self_$32724.audio.PlayOneShot(this.$self_$32724.dead_vc);
																						if (215822 - 455875 == -240053)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (244578 - 116657 != 127922)
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
				IL_4A:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_155:
				IL_22C:
				goto IL_64C;
				goto IL_4A;
				IL_64C:
				return false;
			}

			// Token: 0x060049FD RID: 18941 RVA: 0x0092BD98 File Offset: 0x00929F98
			internal static bool TXCILn5wywCI2NVvtK81()
			{
				return true;
			}

			// Token: 0x060049FE RID: 18942 RVA: 0x0092BD9C File Offset: 0x00929F9C
			internal static bool xBXtLs5wSwvJtoJWITuQ()
			{
				return false;
			}

			// Token: 0x040054D3 RID: 21715
			internal Vector3 $myPosition$32716;

			// Token: 0x040054D4 RID: 21716
			internal Vector3 $myDirection$32717;

			// Token: 0x040054D5 RID: 21717
			internal GameObject[] $mGameObjectList$32718;

			// Token: 0x040054D6 RID: 21718
			internal GameObject $mGameObject$32719;

			// Token: 0x040054D7 RID: 21719
			internal int $$11488$32720;

			// Token: 0x040054D8 RID: 21720
			internal GameObject[] $$11489$32721;

			// Token: 0x040054D9 RID: 21721
			internal int $$11490$32722;

			// Token: 0x040054DA RID: 21722
			internal UnityScript.Lang.Array $nArray$32723;

			// Token: 0x040054DB RID: 21723
			internal Liger $self_$32724;
		}
	}
}
