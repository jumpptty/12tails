using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E21 RID: 3617
[Serializable]
public class Matti : MonoBehaviour
{
	// Token: 0x060051CF RID: 20943 RVA: 0x009FE4C8 File Offset: 0x009FC6C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Matti()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060051D0 RID: 20944 RVA: 0x009FE4D8 File Offset: 0x009FC6D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (13334 - 160133 != -146799)
		{
		}
		for (;;)
		{
			this.oDSce8Y2hn7 = this.transform;
			if (281117 - 557736 != -276618)
			{
				this.ipGceiZb2dc = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (146105 - 311896 != -165790)
				{
					this.ipGceiZb2dc.actionState = "standby";
					if (244012 - 463983 == -219971)
					{
						this.ipGceiZb2dc.actionTime = Time.time;
						if (255500 - 453799 == -198299)
						{
							this.ipGceiZb2dc.myCommand = "none";
							if (85808 - 387180 == -301372)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (164633 - 29116 == 135517)
								{
									this.ipGceiZb2dc.isMine = true;
									if (247393 - 439700 != -192306)
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

	// Token: 0x060051D1 RID: 20945 RVA: 0x009FE638 File Offset: 0x009FC838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (37456 - 334520 != -297064)
		{
		}
		for (;;)
		{
			if (this.ipGceiZb2dc.isControlled)
			{
				if (145043 - 488815 != -343772)
				{
					continue;
				}
				if (!(this.ipGceiZb2dc.actionState == "standby"))
				{
					if (20674 - 156701 != -136027)
					{
						continue;
					}
					if (!(this.ipGceiZb2dc.actionState == "run"))
					{
						goto IL_123;
					}
					if (146954 - 184961 != -38007)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (153292 - 473093 != -319801)
				{
					continue;
				}
			}
			IL_123:
			if (this.ipGceiZb2dc.hp <= 0)
			{
				if (18915 - 545318 != -526403)
				{
					continue;
				}
				if (this.ipGceiZb2dc.actionState != "dead")
				{
					if (72434 - 30307 != 42127)
					{
						continue;
					}
					if (this.ipGceiZb2dc.isMine)
					{
						if (184607 - 516390 != -331783)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (160423 - 200786 != -40363)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (146944 - 495939 == -348994)
						{
							continue;
						}
						this.ipGceiZb2dc.DeadEvent();
						if (27637 - 170583 != -142946)
						{
							continue;
						}
						break;
					}
					else
					{
						this.ipGceiZb2dc.hp = 1;
						if (154458 - 148265 != 6194)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.ipGceiZb2dc.hp <= 0)
			{
				break;
			}
			if (259565 - 112872 != 146694)
			{
				if (this.ipGceiZb2dc.ko > 0)
				{
					break;
				}
				if (99077 - 297734 != -198656)
				{
					if (!(this.ipGceiZb2dc.actionState != "ko"))
					{
						break;
					}
					if (100961 - 221119 != -120157)
					{
						if (!(this.ipGceiZb2dc.actionState != "dead"))
						{
							break;
						}
						if (179460 - 574725 != -395264)
						{
							if (this.ipGceiZb2dc.isMine)
							{
								if (158484 - 5412 != 153073)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (160650 - 538371 != -377720)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (247264 - 559694 == -312430)
										{
											this.ipGceiZb2dc.KoEvent();
											if (184247 - 413002 == -228755)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.ipGceiZb2dc.ko = 1;
								if (288135 - 383775 != -95639)
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

	// Token: 0x060051D2 RID: 20946 RVA: 0x009FEA30 File Offset: 0x009FCC30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (299665 - 187022 != 112644)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (124673 - 105081 != 19593)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (29843 - 246204 != -216360)
				{
					if (97740 - 564986 == -467246)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (212979 - 514116 != -301137)
							{
								continue;
							}
							v = 1;
							if (2815 - 164205 == -161389)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (146726 - 164382 == -17655)
							{
								continue;
							}
							v = -1;
							if (63521 - 554740 == -491218)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_noTrace")
						{
							if (230476 - 202929 != 27547)
							{
								continue;
							}
							v = 11;
							if (133389 - 504285 == -370895)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rollStrike")
						{
							if (214708 - 216092 == -1383)
							{
								continue;
							}
							v = 21;
							if (94438 - 209496 != -115058)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rollStrike_hit")
						{
							if (178073 - 275071 != -96998)
							{
								continue;
							}
							v = -21;
							if (165929 - 447096 == -281166)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_meatGrinder")
						{
							if (282670 - 458738 == -176067)
							{
								continue;
							}
							v = 31;
							if (41286 - 226730 == -185443)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_meatGrinder_hit")
						{
							if (287047 - 36127 == 250921)
							{
								continue;
							}
							v = -31;
							if (217033 - 523693 != -306660)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_muder")
						{
							if (239682 - 546340 != -306658)
							{
								continue;
							}
							v = 41;
							if (91782 - 433363 != -341581)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_muder_hit")
						{
							if (184382 - 157148 != 27234)
							{
								continue;
							}
							v = -41;
							if (4526 - 96182 != -91656)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (190268 - 167273 == 22996)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (105255 - 69162 != 36094)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (138205 - 389244 == -251039)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (87019 - 156771 == -69752)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (162533 - 482360 != -319826)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (83013 - 155685 == -72672)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (197096 - 214207 == -17111)
											{
												Hashtable hashtable = new Hashtable();
												if (188885 - 327779 != -138893)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (244632 - 10312 == 234320)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (157174 - 191828 != -34653)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (81198 - 139470 != -58271)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (250210 - 453045 == -202835)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (216880 - 276572 == -59692)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (4589 - 102043 == -97454)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (171234 - 463634 != -292399)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (157654 - 526183 == -368529)
																				{
																					PhotonClient.SendEvent(this.ipGceiZb2dc.ActorNr, 74, hashtable, true, true);
																					if (128202 - 399551 == -271349)
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

	// Token: 0x060051D3 RID: 20947 RVA: 0x009FF0C4 File Offset: 0x009FD2C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (192335 - 505160 != -312825)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (224788 - 59211 == 165577)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (297311 - 480943 == -183632)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (46449 - 299745 == -253296)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (139432 - 169728 != -30295)
						{
							int num3 = num;
							if (49471 - 302988 != -253516)
							{
								if (num3 == 1)
								{
									if (226881 - 188404 == 38477)
									{
										if (this.ipGceiZb2dc.isMine)
										{
											break;
										}
										if (226116 - 505859 == -279743)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (169138 - 486154 == -317016)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (20458 - 90551 == -70093)
									{
										if (this.ipGceiZb2dc.isMine)
										{
											break;
										}
										if (243555 - 272570 == -29015)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (204783 - 476695 != -271911)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (245703 - 307475 == -61772)
									{
										if (this.ipGceiZb2dc.isMine)
										{
											break;
										}
										if (108308 - 511459 != -403150)
										{
											this.StartCoroutine_Auto(this.RPC_noTrace(vector, vector2, num2));
											if (40383 - 68622 == -28239)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (56323 - 441622 != -385298)
									{
										if (this.ipGceiZb2dc.isMine)
										{
											break;
										}
										if (133770 - 456368 == -322598)
										{
											this.StartCoroutine_Auto(this.RPC_rollStrike(vector, vector2, num2));
											if (224978 - 583381 != -358402)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (284052 - 353720 == -69668)
									{
										if (this.ipGceiZb2dc.isMine)
										{
											break;
										}
										if (40834 - 563493 != -522658)
										{
											this.RPC_rollStrike_hit(vector, vector2, num2);
											if (126450 - 327163 != -200712)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (169149 - 453056 != -283906)
									{
										if (this.ipGceiZb2dc.isMine)
										{
											break;
										}
										if (73292 - 49135 == 24157)
										{
											this.StartCoroutine_Auto(this.RPC_meatGrinder(vector, vector2, num2));
											if (8481 - 225754 == -217273)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -31)
								{
									if (156971 - 237193 == -80222)
									{
										if (this.ipGceiZb2dc.isMine)
										{
											break;
										}
										if (113937 - 271421 == -157484)
										{
											this.RPC_meatGrinder_hit(vector, vector2, num2);
											if (123490 - 507810 == -384320)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (87553 - 87043 == 510)
									{
										if (this.ipGceiZb2dc.isMine)
										{
											break;
										}
										if (108060 - 388209 == -280149)
										{
											this.StartCoroutine_Auto(this.RPC_murder(vector, vector2, num2));
											if (81990 - 396617 == -314627)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -41)
								{
									if (248775 - 98003 != 150773)
									{
										if (this.ipGceiZb2dc.isMine)
										{
											break;
										}
										if (205374 - 126139 != 79236)
										{
											this.RPC_murder_hit(vector, vector2, num2);
											if (81767 - 555838 == -474071)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (237498 - 441421 != -203922)
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

	// Token: 0x060051D4 RID: 20948 RVA: 0x009FF6A8 File Offset: 0x009FD8A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (282271 - 13854 != 268418)
		{
		}
		for (;;)
		{
			float num = this.ipGceiZb2dc.moveSpeed;
			if (64014 - 147942 == -83928)
			{
				float runSpeed = this.ipGceiZb2dc.runSpeed;
				if (228159 - 577089 != -348929)
				{
					Vector3 a = default(Vector3);
					if (295974 - 406591 != -110616)
					{
						Vector3 vector = Vector3.zero;
						if (102213 - 109322 == -7109)
						{
							float num2 = (float)0;
							if (144585 - 551874 != -407288)
							{
								if (this.ipGceiZb2dc.isMine)
								{
									if (56173 - 217978 != -161805)
									{
										continue;
									}
									if ((this.ipGceiZb2dc.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (266051 - 427395 == -161343)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (204435 - 265500 != -61065)
										{
											continue;
										}
										a.y = (float)0;
										if (96532 - 228396 == -131863)
										{
											continue;
										}
										a = a.normalized;
										if (153129 - 108114 == 45016)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (285240 - 103349 != 181891)
										{
											continue;
										}
										vector = vector.normalized;
										if (81518 - 321418 == -239899)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (215482 - 332206 == -116723)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (47254 - 360039 == -312784)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (193534 - 64916 != 128618)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (99651 - 453053 == -353401)
														{
															continue;
														}
														this.ipGceiZb2dc.actionState = "run";
														if (7028 - 58817 == -51788)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (225081 - 149577 != 75504)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (18538 - 153121 != -134583)
														{
															continue;
														}
														this.animation.Play("run");
														if (162453 - 23459 != 138994)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (280782 - 239287 != 41495)
														{
															continue;
														}
														goto IL_ABA;
													}
												}
											}
										}
										this.ipGceiZb2dc.actionState = "standby";
										if (253651 - 581687 == -328035)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (142385 - 131159 == 11227)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (86724 - 128358 != -41634)
											{
												continue;
											}
											num = (float)0;
											if (103626 - 61835 != 41791)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (37604 - 46821 == -9216)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (80372 - 494033 == -413660)
										{
											continue;
										}
									}
									IL_ABA:;
								}
								else
								{
									vector = global::Math.vFlat(this.ipGceiZb2dc.nPosition - this.transform.position);
									if (195595 - 187403 == 8193)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (282769 - 48017 != 234752)
									{
										continue;
									}
									if (this.ipGceiZb2dc.nSpeed != (float)0)
									{
										if (90858 - 530013 != -439155)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (31509 - 49657 == -18147)
											{
												continue;
											}
											this.transform.position = this.ipGceiZb2dc.nPosition;
											if (15995 - 29050 != -13055)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (40010 - 65959 == -25948)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (86518 - 171306 == -84787)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (128631 - 310148 == -181516)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.ipGceiZb2dc.nSpeed, (float)10 * Time.deltaTime);
												if (76161 - 31503 == 44659)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (113557 - 480373 == -366815)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (96181 - 24257 == 71925)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (90595 - 315133 == -224537)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (57446 - 26736 == 30711)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (222691 - 388271 == -165579)
											{
												continue;
											}
										}
										else if (Time.time > this.ipGceiZb2dc.nSpeed + 0.3f)
										{
											if (272630 - 251750 != 20880)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (66685 - 576587 != -509902)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (80346 - 154421 != -74075)
												{
													continue;
												}
												num = (float)0;
												if (268200 - 523349 != -255149)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.ipGceiZb2dc.nDirection);
											if (141317 - 277436 != -136119)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (248803 - 54583 != 194220)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (125379 - 149407 != -24028)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (223947 - 131422 == 92526)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (230697 - 424910 != -194213)
											{
												continue;
											}
											this.transform.position = this.ipGceiZb2dc.nPosition;
											if (282416 - 490276 == -207859)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (133592 - 277486 == -143893)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (242803 - 155951 != 86852)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (41067 - 241152 == -200084)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (131588 - 20159 == 111430)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (274096 - 501978 == -227881)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (263551 - 78272 == 185280)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (36411 - 493015 != -456604)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.ipGceiZb2dc.nDirection);
											if (173111 - 70969 != 102142)
											{
												continue;
											}
											num = (float)0;
											if (125552 - 146738 == -21185)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (139826 - 15065 == 124762)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (218015 - 154147 != 63868)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (192615 - 183034 == 9582)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (281116 - 376433 == -95316)
										{
											continue;
										}
									}
								}
								this.ipGceiZb2dc.vMovement = vector;
								if (56662 - 470266 != -413603)
								{
									this.ipGceiZb2dc.moveSpeed = num;
									if (46729 - 465670 == -418941)
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

	// Token: 0x060051D5 RID: 20949 RVA: 0x00A0020C File Offset: 0x009FE40C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (185783 - 495538 != -309754)
		{
		}
		for (;;)
		{
			if (!this.ipGceiZb2dc.isMine)
			{
				if (25321 - 478534 != -453212)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (116089 - 405424 != -289334)
				{
					Vector3 tDir = a - this.transform.position;
					if (5599 - 540890 != -535290)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (201077 - 347326 == -146249)
						{
							CharacterControl characterControl = null;
							if (188684 - 436075 != -247390)
							{
								if (87318 - 591618 == -504300)
								{
									if (gameObject)
									{
										if (75669 - 46100 == 29570)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (259913 - 29777 != 230136)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (240278 - 169360 == 70919)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (134922 - 569918 != -434996)
										{
											continue;
										}
									}
									if (!(this.ipGceiZb2dc.actionState == "standby"))
									{
										if (26456 - 275164 != -248708)
										{
											continue;
										}
										if (!(this.ipGceiZb2dc.actionState == "run"))
										{
											break;
										}
										if (41298 - 408483 != -367185)
										{
											continue;
										}
									}
									if (this.ipGceiZb2dc.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (24163 - 510893 == -486730)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, tDir, 0));
										if (68368 - 515486 != -447117)
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

	// Token: 0x060051D6 RID: 20950 RVA: 0x00A004B4 File Offset: 0x009FE6B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (152985 - 146800 != 6185)
		{
		}
		for (;;)
		{
			if (!this.ipGceiZb2dc.isMine)
			{
				if (275797 - 26730 == 249067)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (178327 - 425579 != -247251)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (247747 - 101085 == 146662)
					{
						Vector3 normalized = vector.normalized;
						if (251668 - 186393 != 65276)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (144429 - 382943 != -238513)
							{
								CharacterControl characterControl = null;
								if (38213 - 381704 == -343491)
								{
									int tID = 0;
									if (208365 - 184931 != 23435)
									{
										if (gameObject)
										{
											if (138677 - 427629 == -288951)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (213136 - 263983 != -50847)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (295732 - 176796 == 118937)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (211495 - 350438 == -138942)
											{
												continue;
											}
										}
										if (!(this.ipGceiZb2dc.actionState == "standby"))
										{
											if (48543 - 196454 != -147911)
											{
												continue;
											}
											if (!(this.ipGceiZb2dc.actionState == "run"))
											{
												break;
											}
											if (163237 - 464575 != -301338)
											{
												continue;
											}
										}
										if (this.ipGceiZb2dc.isTimeOut("noTrace") == (float)0)
										{
											if (152385 - 203610 != -51224)
											{
												this.StartCoroutine_Auto(this.RPC_noTrace(this.transform.position, normalized, 0));
												if (146297 - 430530 != -284232)
												{
													break;
												}
											}
										}
										else
										{
											if (this.ipGceiZb2dc.isTimeOut("meatGrinder") != (float)0)
											{
												break;
											}
											if (145226 - 442472 != -297245)
											{
												this.StartCoroutine_Auto(this.RPC_meatGrinder(this.transform.position, normalized, tID));
												if (49770 - 132224 == -82454)
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

	// Token: 0x060051D7 RID: 20951 RVA: 0x00A007F0 File Offset: 0x009FE9F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060051D8 RID: 20952 RVA: 0x00A007F4 File Offset: 0x009FE9F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Matti.$RPC_nAttack$33912(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060051D9 RID: 20953 RVA: 0x00A00804 File Offset: 0x009FEA04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x060051DA RID: 20954 RVA: 0x00A00830 File Offset: 0x009FEA30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_noTrace(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Matti.$RPC_noTrace$33931(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060051DB RID: 20955 RVA: 0x00A00840 File Offset: 0x009FEA40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rollStrike(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Matti.$RPC_rollStrike$33938(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060051DC RID: 20956 RVA: 0x00A00850 File Offset: 0x009FEA50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_rollStrike_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.rollStrike_hit)
		{
			UnityEngine.Object.Instantiate(this.rollStrike_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x060051DD RID: 20957 RVA: 0x00A0087C File Offset: 0x009FEA7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_meatGrinder(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Matti.$RPC_meatGrinder$33952(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060051DE RID: 20958 RVA: 0x00A0088C File Offset: 0x009FEA8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_meatGrinder_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.meatGrinder_hit)
		{
			UnityEngine.Object.Instantiate(this.meatGrinder_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x060051DF RID: 20959 RVA: 0x00A008B8 File Offset: 0x009FEAB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_murder(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Matti.$RPC_murder$33969(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060051E0 RID: 20960 RVA: 0x00A008C8 File Offset: 0x009FEAC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_murder_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.murder_hit)
		{
			UnityEngine.Object.Instantiate(this.murder_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x060051E1 RID: 20961 RVA: 0x00A008F4 File Offset: 0x009FEAF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Matti.$RPC_ko$33982(nArray, this).GetEnumerator();
	}

	// Token: 0x060051E2 RID: 20962 RVA: 0x00A00904 File Offset: 0x009FEB04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Matti.$RPC_dead$33989(nArray, this).GetEnumerator();
	}

	// Token: 0x060051E3 RID: 20963 RVA: 0x00A00914 File Offset: 0x009FEB14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060051E4 RID: 20964 RVA: 0x00A00918 File Offset: 0x009FEB18
	internal static bool uTIbYB5rDBPiuFPumvYV()
	{
		return true;
	}

	// Token: 0x060051E5 RID: 20965 RVA: 0x00A0091C File Offset: 0x009FEB1C
	internal static bool tRfRHv5rv0eHqorc9kk4()
	{
		return false;
	}

	// Token: 0x04005B30 RID: 23344
	private Transform oDSce8Y2hn7;

	// Token: 0x04005B31 RID: 23345
	private CharacterControl ipGceiZb2dc;

	// Token: 0x04005B32 RID: 23346
	public GameObject nAttack_ring;

	// Token: 0x04005B33 RID: 23347
	public AudioClip nAttack_swing;

	// Token: 0x04005B34 RID: 23348
	public AudioClip nAttack_vc;

	// Token: 0x04005B35 RID: 23349
	public GameObject nAttack_hit;

	// Token: 0x04005B36 RID: 23350
	public AudioClip noTrace_vc;

	// Token: 0x04005B37 RID: 23351
	public GameObject noTrace_ring;

	// Token: 0x04005B38 RID: 23352
	public AudioClip rollStrike_vc;

	// Token: 0x04005B39 RID: 23353
	public GameObject rollStrike_ring;

	// Token: 0x04005B3A RID: 23354
	public GameObject rollStrike_hit;

	// Token: 0x04005B3B RID: 23355
	public AudioClip meatGrinder_vc;

	// Token: 0x04005B3C RID: 23356
	public GameObject meatGrinder_ring;

	// Token: 0x04005B3D RID: 23357
	public GameObject meatGrinder_hit;

	// Token: 0x04005B3E RID: 23358
	public AudioClip murder_vc;

	// Token: 0x04005B3F RID: 23359
	public GameObject murder_ring;

	// Token: 0x04005B40 RID: 23360
	public GameObject murder_hit;

	// Token: 0x04005B41 RID: 23361
	public AudioClip dead_vc;

	// Token: 0x02000E22 RID: 3618
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33912 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060051E6 RID: 20966 RVA: 0x00A00920 File Offset: 0x009FEB20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33912(Vector3 mPos, Vector3 tDir, Matti self_)
		{
			if (144758 - 466041 != -321282)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (158199 - 476580 == -318381)
				{
					base..ctor();
					if (238181 - 425497 == -187316)
					{
						this.$mPos$33928 = mPos;
						if (83390 - 262667 == -179277)
						{
							this.$tDir$33929 = tDir;
							if (175067 - 351005 == -175938)
							{
								this.$self_$33930 = self_;
								if (299990 - 173478 != 126513)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x00A009FC File Offset: 0x009FEBFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Matti.$RPC_nAttack$33912.$(this.$mPos$33928, this.$tDir$33929, this.$self_$33930);
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x00A00A18 File Offset: 0x009FEC18
		internal static bool ReGcyJ5rRPiH3ivG13b7()
		{
			return true;
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x00A00A1C File Offset: 0x009FEC1C
		internal static bool llMIAS5rwwqbDqBgPeAe()
		{
			return false;
		}

		// Token: 0x04005B42 RID: 23362
		internal Vector3 $mPos$33928;

		// Token: 0x04005B43 RID: 23363
		internal Vector3 $tDir$33929;

		// Token: 0x04005B44 RID: 23364
		internal Matti $self_$33930;

		// Token: 0x02000E23 RID: 3619
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060051EA RID: 20970 RVA: 0x00A00A20 File Offset: 0x009FEC20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Matti self_)
			{
				if (261212 - 107889 != 153324)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (212120 - 220696 != -8575)
					{
						base..ctor();
						if (284959 - 197535 != 87425)
						{
							this.$mPos$33925 = mPos;
							if (232571 - 240017 != -7445)
							{
								this.$tDir$33926 = tDir;
								if (13029 - 230774 != -217744)
								{
									this.$self_$33927 = self_;
									if (275915 - 46587 != 229329)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060051EB RID: 20971 RVA: 0x00A00AFC File Offset: 0x009FECFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (125722 - 198177 != -72454)
				{
				}
				for (;;)
				{
					IL_1162:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1A08;
					case 2:
						if (this.$self_$33927.ipGceiZb2dc.actionState != "attack")
						{
							goto IL_B18;
						}
						if (151011 - 441724 == -290712)
						{
							continue;
						}
						if (this.$self_$33927.ipGceiZb2dc.myCommand != "nAttack")
						{
							if (157959 - 526307 != -368348)
							{
								continue;
							}
							goto IL_B18;
						}
						else
						{
							this.$self_$33927.ipGceiZb2dc.moveSpeed = (float)6;
							if (130804 - 448957 != -318153)
							{
								continue;
							}
							if (!this.$self_$33927.nAttack_swing)
							{
								goto IL_1A;
							}
							if (81405 - 523127 == -441721)
							{
								continue;
							}
							this.$self_$33927.audio.PlayOneShot(this.$self_$33927.nAttack_swing);
							if (173078 - 257233 != -84154)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33927.ipGceiZb2dc.actionState != "attack")
						{
							goto IL_898;
						}
						if (182101 - 309987 == -127885)
						{
							continue;
						}
						if (this.$self_$33927.ipGceiZb2dc.myCommand != "nAttack")
						{
							if (39863 - 365969 != -326106)
							{
								continue;
							}
							goto IL_898;
						}
						else
						{
							this.$self_$33927.ipGceiZb2dc.moveSpeed = (float)0;
							if (2629 - 5693 == -3063)
							{
								continue;
							}
							this.$hitDamage$33913 = (int)(0.66f * (float)this.$self_$33927.ipGceiZb2dc.atk);
							if (12506 - 586199 != -573693)
							{
								continue;
							}
							this.$hitLayer$33914 = 130816 - (1 << this.$self_$33927.gameObject.layer);
							if (85182 - 80944 != 4238)
							{
								continue;
							}
							this.$hitList$33915 = null;
							if (192721 - 262279 == -69557)
							{
								continue;
							}
							this.$hitPos$33916 = default(Vector3);
							if (85694 - 171353 == -85658)
							{
								continue;
							}
							this.$nHiddenEdge$33917 = (float)1;
							if (3779 - 174784 == -171004)
							{
								continue;
							}
							this.$hitChar$33918 = null;
							if (164322 - 155864 != 8458)
							{
								continue;
							}
							if (!this.$self_$33927.ipGceiZb2dc.isMine)
							{
								goto IL_24A;
							}
							if (25241 - 222041 != -196800)
							{
								continue;
							}
							this.$hitList$33915 = Damage.FindRecTarget(this.$self_$33927.transform.position, this.$self_$33927.transform.forward, (float)2, (float)2, (float)4, (float)3, this.$hitLayer$33914);
							if (127668 - 96081 == 31588)
							{
								continue;
							}
							this.$$iterator$10866$33920 = UnityRuntimeServices.GetEnumerator(this.$hitList$33915);
							if (276072 - 25614 != 250458)
							{
								continue;
							}
							while (this.$$iterator$10866$33920.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10866$33920.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33919 = (GameObject)obj2;
								if (71774 - 297276 != -225502)
								{
									goto IL_1162;
								}
								if (Quaternion.Angle(this.$self_$33927.transform.rotation, this.$hitObject$33919.transform.rotation) < (float)60)
								{
									if (12068 - 479674 == -467605)
									{
										goto IL_1162;
									}
									this.$nHiddenEdge$33917 = (float)2;
									if (31657 - 268785 == -237127)
									{
										goto IL_1162;
									}
								}
								else
								{
									this.$nHiddenEdge$33917 = (float)1;
									if (56695 - 129547 != -72852)
									{
										goto IL_1162;
									}
								}
								if (this.$self_$33927.ipGceiZb2dc.hit(1, this.$hitObject$33919, (int)(this.$nHiddenEdge$33917 * (float)this.$hitDamage$33913), 2, 0, 0.3f * (this.$hitObject$33919.transform.position - this.$self_$33927.transform.position).normalized) != 0)
								{
									if (297840 - 463746 == -165905)
									{
										goto IL_1162;
									}
									this.$hitPos$33916 = global::Math.vFlat(this.$hitObject$33919.collider.bounds.center) + new Vector3((float)0, this.$self_$33927.transform.position.y + (float)1, (float)0);
									if (67898 - 313807 != -245909)
									{
										goto IL_1162;
									}
									UnityRuntimeServices.Update(this.$$iterator$10866$33920, this.$hitObject$33919);
									if (60761 - 335917 != -275156)
									{
										goto IL_1162;
									}
									this.$self_$33927.RPC_nAttack_hit(this.$hitPos$33916, this.$self_$33927.oDSce8Y2hn7.forward, 0);
									if (89380 - 417934 == -328553)
									{
										goto IL_1162;
									}
									if (PhotonClient.IsInitialized())
									{
										if (272539 - 335751 != -63212)
										{
											goto IL_1162;
										}
										this.$self_$33927.ActionEvent("RPC_nAttack_hit", this.$hitPos$33916, this.$self_$33927.oDSce8Y2hn7.forward, 0);
										if (43492 - 161894 != -118402)
										{
											goto IL_1162;
										}
									}
									this.$hitChar$33918 = (CharacterControl)this.$hitObject$33919.GetComponent(typeof(CharacterControl));
									if (193622 - 245961 != -52339)
									{
										goto IL_1162;
									}
									UnityRuntimeServices.Update(this.$$iterator$10866$33920, this.$hitObject$33919);
									if (101006 - 135895 != -34889)
									{
										goto IL_1162;
									}
									if (this.$hitChar$33918)
									{
										if (97725 - 334603 != -236878)
										{
											goto IL_1162;
										}
										this.$hitChar$33918.RPC_AddStatus("cut", 5, 1, 0, this.$self_$33927.ipGceiZb2dc.ActorNr);
										if (217588 - 471878 == -254289)
										{
											goto IL_1162;
										}
									}
								}
							}
							if (241656 - 38726 != 202931)
							{
								goto Block_148;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$33927.ipGceiZb2dc.actionState != "attack")
						{
							goto IL_199A;
						}
						if (78649 - 133399 == -54749)
						{
							continue;
						}
						if (this.$self_$33927.ipGceiZb2dc.myCommand != "nAttack")
						{
							if (6513 - 409897 != -403383)
							{
								goto Block_124;
							}
							continue;
						}
						else
						{
							this.$self_$33927.ipGceiZb2dc.moveSpeed = (float)9;
							if (191749 - 490601 != -298852)
							{
								continue;
							}
							this.$self_$33927.ipGceiZb2dc.removeLockStatus(5);
							if (257094 - 289938 == -32843)
							{
								continue;
							}
							if (this.$self_$33927.nAttack_vc)
							{
								if (42919 - 543376 == -500456)
								{
									continue;
								}
								this.$self_$33927.audio.PlayOneShot(this.$self_$33927.nAttack_vc);
								if (258723 - 16326 == 242398)
								{
									continue;
								}
							}
							if (!this.$self_$33927.nAttack_swing)
							{
								goto IL_1070;
							}
							if (24292 - 564226 == -539933)
							{
								continue;
							}
							this.$self_$33927.audio.PlayOneShot(this.$self_$33927.nAttack_swing);
							if (296029 - 149884 != 146146)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$33927.ipGceiZb2dc.actionState != "attack")
						{
							goto IL_57D;
						}
						if (107303 - 156426 == -49122)
						{
							continue;
						}
						if (this.$self_$33927.ipGceiZb2dc.myCommand != "nAttack")
						{
							if (153075 - 220968 != -67893)
							{
								continue;
							}
							goto IL_57D;
						}
						else
						{
							this.$self_$33927.ipGceiZb2dc.moveSpeed = (float)0;
							if (79468 - 146989 != -67521)
							{
								continue;
							}
							if (!this.$self_$33927.ipGceiZb2dc.isMine)
							{
								goto IL_D2F;
							}
							if (119823 - 385811 == -265987)
							{
								continue;
							}
							this.$hitList$33915 = Damage.FindRecTarget(this.$self_$33927.transform.position, this.$self_$33927.transform.forward, (float)3, (float)3, (float)4, (float)3, this.$hitLayer$33914);
							if (45114 - 449072 == -403957)
							{
								continue;
							}
							this.$$iterator$10867$33922 = UnityRuntimeServices.GetEnumerator(this.$hitList$33915);
							if (157258 - 211975 != -54717)
							{
								continue;
							}
							while (this.$$iterator$10867$33922.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10867$33922.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$33921 = (GameObject)obj4;
								if (22612 - 58087 == -35474)
								{
									goto IL_1162;
								}
								if (Quaternion.Angle(this.$self_$33927.transform.rotation, this.$hitObject$33921.transform.rotation) < (float)60)
								{
									if (265281 - 408109 != -142828)
									{
										goto IL_1162;
									}
									this.$nHiddenEdge$33917 = (float)2;
									if (238838 - 501253 != -262415)
									{
										goto IL_1162;
									}
								}
								else
								{
									this.$nHiddenEdge$33917 = (float)1;
									if (163859 - 135761 == 28099)
									{
										goto IL_1162;
									}
								}
								if (this.$self_$33927.ipGceiZb2dc.hit(1, this.$hitObject$33921, (int)(this.$nHiddenEdge$33917 * (float)this.$hitDamage$33913), 2, 0, 0.3f * (this.$hitObject$33921.transform.position - this.$self_$33927.transform.position).normalized) != 0)
								{
									if (28655 - 33898 == -5242)
									{
										goto IL_1162;
									}
									this.$hitPos$33916 = global::Math.vFlat(this.$hitObject$33921.collider.bounds.center) + new Vector3((float)0, this.$self_$33927.transform.position.y + (float)1, (float)0);
									if (213514 - 115118 == 98397)
									{
										goto IL_1162;
									}
									UnityRuntimeServices.Update(this.$$iterator$10867$33922, this.$hitObject$33921);
									if (150008 - 376365 != -226357)
									{
										goto IL_1162;
									}
									this.$self_$33927.RPC_nAttack_hit(this.$hitPos$33916, this.$self_$33927.oDSce8Y2hn7.forward, 0);
									if (270154 - 246150 == 24005)
									{
										goto IL_1162;
									}
									if (PhotonClient.IsInitialized())
									{
										if (237531 - 254640 == -17108)
										{
											goto IL_1162;
										}
										this.$self_$33927.ActionEvent("RPC_nAttack_hit", this.$hitPos$33916, this.$self_$33927.oDSce8Y2hn7.forward, 0);
										if (275486 - 405212 == -129725)
										{
											goto IL_1162;
										}
									}
									this.$hitChar$33918 = (CharacterControl)this.$hitObject$33921.GetComponent(typeof(CharacterControl));
									if (275737 - 390476 != -114739)
									{
										goto IL_1162;
									}
									UnityRuntimeServices.Update(this.$$iterator$10867$33922, this.$hitObject$33921);
									if (191204 - 47805 == 143400)
									{
										goto IL_1162;
									}
									if (this.$hitChar$33918)
									{
										if (33658 - 576418 == -542759)
										{
											goto IL_1162;
										}
										this.$hitChar$33918.RPC_AddStatus("cut", 5, 1, 0, this.$self_$33927.ipGceiZb2dc.ActorNr);
										if (67783 - 532738 != -464955)
										{
											goto IL_1162;
										}
									}
								}
							}
							if (121402 - 535433 != -414031)
							{
								continue;
							}
							goto IL_D2F;
						}
						break;
					case 6:
						if (this.$self_$33927.ipGceiZb2dc.actionState != "attack")
						{
							goto IL_B49;
						}
						if (162020 - 102400 == 59621)
						{
							continue;
						}
						if (this.$self_$33927.ipGceiZb2dc.myCommand != "nAttack")
						{
							if (127497 - 547387 != -419889)
							{
								goto Block_79;
							}
							continue;
						}
						else
						{
							this.$self_$33927.ipGceiZb2dc.moveSpeed = (float)9;
							if (13606 - 13443 == 164)
							{
								continue;
							}
							this.$self_$33927.ipGceiZb2dc.removeLockStatus(5);
							if (113744 - 321728 != -207984)
							{
								continue;
							}
							if (this.$self_$33927.nAttack_vc)
							{
								if (23803 - 25426 == -1622)
								{
									continue;
								}
								this.$self_$33927.audio.PlayOneShot(this.$self_$33927.nAttack_vc);
								if (14469 - 358089 != -343620)
								{
									continue;
								}
							}
							if (!this.$self_$33927.nAttack_swing)
							{
								goto IL_45B;
							}
							if (224557 - 273069 == -48511)
							{
								continue;
							}
							this.$self_$33927.audio.PlayOneShot(this.$self_$33927.nAttack_swing);
							if (6179 - 153344 != -147165)
							{
								continue;
							}
							goto IL_45B;
						}
						break;
					case 7:
						if (this.$self_$33927.ipGceiZb2dc.actionState != "attack")
						{
							goto IL_1419;
						}
						if (180090 - 404479 == -224388)
						{
							continue;
						}
						if (this.$self_$33927.ipGceiZb2dc.myCommand != "nAttack")
						{
							if (35074 - 561690 != -526616)
							{
								continue;
							}
							goto IL_1419;
						}
						else
						{
							this.$self_$33927.ipGceiZb2dc.moveSpeed = (float)0;
							if (208277 - 517334 != -309057)
							{
								continue;
							}
							if (!this.$self_$33927.ipGceiZb2dc.isMine)
							{
								goto IL_A9F;
							}
							if (20940 - 279395 == -258454)
							{
								continue;
							}
							this.$hitList$33915 = Damage.FindRecTarget(this.$self_$33927.transform.position, this.$self_$33927.transform.forward, (float)2, (float)2, (float)5, (float)3, this.$hitLayer$33914);
							if (154489 - 226279 == -71789)
							{
								continue;
							}
							this.$$iterator$10868$33924 = UnityRuntimeServices.GetEnumerator(this.$hitList$33915);
							if (178169 - 443671 != -265502)
							{
								continue;
							}
							while (this.$$iterator$10868$33924.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$10868$33924.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$33923 = (GameObject)obj6;
								if (123030 - 441079 != -318049)
								{
									goto IL_1162;
								}
								if (Quaternion.Angle(this.$self_$33927.transform.rotation, this.$hitObject$33923.transform.rotation) < (float)60)
								{
									if (263608 - 252081 == 11528)
									{
										goto IL_1162;
									}
									this.$nHiddenEdge$33917 = (float)2;
									if (277330 - 369540 == -92209)
									{
										goto IL_1162;
									}
								}
								else
								{
									this.$nHiddenEdge$33917 = (float)1;
									if (32784 - 471244 != -438460)
									{
										goto IL_1162;
									}
								}
								if (this.$self_$33927.ipGceiZb2dc.hit(1, this.$hitObject$33923, (int)(this.$nHiddenEdge$33917 * (float)this.$hitDamage$33913), 2, 0, 0.3f * (this.$hitObject$33923.transform.position - this.$self_$33927.transform.position).normalized) != 0)
								{
									if (221641 - 248101 == -26459)
									{
										goto IL_1162;
									}
									this.$hitPos$33916 = global::Math.vFlat(this.$hitObject$33923.collider.bounds.center) + new Vector3((float)0, this.$self_$33927.transform.position.y + (float)1, (float)0);
									if (81708 - 545591 == -463882)
									{
										goto IL_1162;
									}
									UnityRuntimeServices.Update(this.$$iterator$10868$33924, this.$hitObject$33923);
									if (15644 - 307249 == -291604)
									{
										goto IL_1162;
									}
									this.$self_$33927.RPC_nAttack_hit(this.$hitPos$33916, this.$self_$33927.oDSce8Y2hn7.forward, 0);
									if (185327 - 221903 == -36575)
									{
										goto IL_1162;
									}
									if (PhotonClient.IsInitialized())
									{
										if (150484 - 123044 == 27441)
										{
											goto IL_1162;
										}
										this.$self_$33927.ActionEvent("RPC_nAttack_hit", this.$hitPos$33916, this.$self_$33927.oDSce8Y2hn7.forward, 0);
										if (94153 - 365640 == -271486)
										{
											goto IL_1162;
										}
									}
									this.$hitChar$33918 = (CharacterControl)this.$hitObject$33923.GetComponent(typeof(CharacterControl));
									if (131975 - 526386 == -394410)
									{
										goto IL_1162;
									}
									UnityRuntimeServices.Update(this.$$iterator$10868$33924, this.$hitObject$33923);
									if (267448 - 239333 == 28116)
									{
										goto IL_1162;
									}
									if (this.$hitChar$33918)
									{
										if (20446 - 143175 == -122728)
										{
											goto IL_1162;
										}
										this.$hitChar$33918.RPC_AddStatus("cut", 5, 1, 0, this.$self_$33927.ipGceiZb2dc.ActorNr);
										if (120964 - 533254 != -412290)
										{
											goto IL_1162;
										}
									}
								}
							}
							if (132997 - 524593 != -391595)
							{
								goto Block_66;
							}
							continue;
						}
						break;
					case 8:
						if (this.$self_$33927.ipGceiZb2dc.actionState == "attack")
						{
							if (265339 - 295076 == -29736)
							{
								continue;
							}
							if (this.$self_$33927.ipGceiZb2dc.myCommand == "nAttack")
							{
								if (51891 - 410465 == -358573)
								{
									continue;
								}
								this.$self_$33927.ipGceiZb2dc.actionState = "standby";
								if (69256 - 94472 != -25216)
								{
									continue;
								}
								this.$self_$33927.ipGceiZb2dc.actionTime = Time.time;
								if (117742 - 347247 != -229505)
								{
									continue;
								}
								this.$self_$33927.ipGceiZb2dc.myCommand = "none";
								if (140226 - 511782 != -371556)
								{
									continue;
								}
								if (!this.$self_$33927.ipGceiZb2dc.isMine)
								{
									if (65003 - 18103 == 46901)
									{
										continue;
									}
									this.$self_$33927.ipGceiZb2dc.nPosition = this.$self_$33927.transform.position;
									if (290337 - 4507 == 285831)
									{
										continue;
									}
									this.$self_$33927.ipGceiZb2dc.oPosition = this.$self_$33927.transform.position;
									if (37460 - 529565 != -492105)
									{
										continue;
									}
									this.$self_$33927.ipGceiZb2dc.nDirection = this.$self_$33927.transform.forward;
									if (166612 - 98527 != 68085)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (204049 - 169207 != 34843)
						{
							goto Block_160;
						}
						continue;
					default:
						if (135571 - 219133 != -83562)
						{
							continue;
						}
						break;
					}
					this.$self_$33927.ipGceiZb2dc.actionState = "attack";
					if (44965 - 501308 != -456342)
					{
						this.$self_$33927.ipGceiZb2dc.actionTime = Time.time;
						if (260748 - 37434 != 223315)
						{
							this.$self_$33927.ipGceiZb2dc.myCommand = "nAttack";
							if (112447 - 326256 == -213809)
							{
								this.$self_$33927.ipGceiZb2dc.addTimeOut("nAttack", (float)3);
								if (258370 - 93041 != 165330)
								{
									this.$self_$33927.transform.position = this.$mPos$33925;
									if (287166 - 541890 != -254723)
									{
										this.$self_$33927.transform.LookAt(this.$mPos$33925 + global::Math.vFlat(this.$tDir$33926));
										if (99030 - 455974 != -356943)
										{
											this.$self_$33927.animation.CrossFade("nAttack");
											if (73602 - 239651 == -166049)
											{
												this.$self_$33927.animation.wrapMode = WrapMode.Once;
												if (277992 - 391976 == -113984)
												{
													this.$self_$33927.ipGceiZb2dc.vMovement = this.$self_$33927.transform.forward;
													if (19809 - 148770 == -128961)
													{
														this.$self_$33927.ipGceiZb2dc.moveSpeed = (float)0;
														if (204197 - 313885 != -109687)
														{
															this.$self_$33927.ipGceiZb2dc.removeLockStatus(5);
															if (280958 - 443870 != -162911)
															{
																this.$self_$33927.ipGceiZb2dc.removeStatus("blend");
																if (136032 - 358348 != -222315)
																{
																	if (this.$self_$33927.nAttack_ring)
																	{
																		if (245174 - 2733 == 242442)
																		{
																			continue;
																		}
																		this.$self_$33927.ipGceiZb2dc.createEffect(this.$self_$33927.nAttack_ring, this.$self_$33927.transform.position, this.$self_$33927.transform.rotation);
																		if (21848 - 285306 != -263458)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find nAttack ring Effect");
																		if (230023 - 563799 == -333775)
																		{
																			continue;
																		}
																	}
																	if (!this.$self_$33927.nAttack_vc)
																	{
																		goto IL_1865;
																	}
																	if (6403 - 323972 != -317568)
																	{
																		this.$self_$33927.audio.PlayOneShot(this.$self_$33927.nAttack_vc);
																		if (289423 - 162071 != 127353)
																		{
																			goto Block_107;
																		}
																	}
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_24A:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_22:
				goto IL_1070;
				IL_45B:
				return this.Yield(7, new WaitForSeconds(0.2f));
				Block_30:
				goto IL_1A;
				IL_57D:
				IL_898:
				goto IL_1A08;
				Block_66:
				IL_A9F:
				return this.Yield(8, new WaitForSeconds(0.2f));
				IL_B18:
				IL_B49:
				goto IL_1A08;
				Block_79:
				goto IL_B49;
				IL_D2F:
				return this.Yield(6, new WaitForSeconds(0.2f));
				IL_1070:
				return this.Yield(5, new WaitForSeconds(0.1f));
				Block_107:
				goto IL_1865;
				Block_124:
				IL_1419:
				goto IL_1A08;
				Block_148:
				goto IL_24A;
				IL_1865:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_160:
				IL_199A:
				IL_1A08:
				return false;
			}

			// Token: 0x060051EC RID: 20972 RVA: 0x00A02524 File Offset: 0x00A00724
			internal static bool HnoqLQ5rqfQe4FN4p7yf()
			{
				return true;
			}

			// Token: 0x060051ED RID: 20973 RVA: 0x00A02528 File Offset: 0x00A00728
			internal static bool df1sgg5r7s53VePKvl27()
			{
				return false;
			}

			// Token: 0x04005B45 RID: 23365
			internal int $hitDamage$33913;

			// Token: 0x04005B46 RID: 23366
			internal int $hitLayer$33914;

			// Token: 0x04005B47 RID: 23367
			internal UnityScript.Lang.Array $hitList$33915;

			// Token: 0x04005B48 RID: 23368
			internal Vector3 $hitPos$33916;

			// Token: 0x04005B49 RID: 23369
			internal float $nHiddenEdge$33917;

			// Token: 0x04005B4A RID: 23370
			internal CharacterControl $hitChar$33918;

			// Token: 0x04005B4B RID: 23371
			internal GameObject $hitObject$33919;

			// Token: 0x04005B4C RID: 23372
			internal IEnumerator $$iterator$10866$33920;

			// Token: 0x04005B4D RID: 23373
			internal GameObject $hitObject$33921;

			// Token: 0x04005B4E RID: 23374
			internal IEnumerator $$iterator$10867$33922;

			// Token: 0x04005B4F RID: 23375
			internal GameObject $hitObject$33923;

			// Token: 0x04005B50 RID: 23376
			internal IEnumerator $$iterator$10868$33924;

			// Token: 0x04005B51 RID: 23377
			internal Vector3 $mPos$33925;

			// Token: 0x04005B52 RID: 23378
			internal Vector3 $tDir$33926;

			// Token: 0x04005B53 RID: 23379
			internal Matti $self_$33927;
		}
	}

	// Token: 0x02000E24 RID: 3620
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_noTrace$33931 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060051EE RID: 20974 RVA: 0x00A0252C File Offset: 0x00A0072C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_noTrace$33931(Vector3 mPos, Vector3 tDir, Matti self_)
		{
			if (98592 - 383364 != -284772)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187733 - 589353 != -401619)
				{
					base..ctor();
					if (299737 - 467895 == -168158)
					{
						this.$mPos$33935 = mPos;
						if (158489 - 180411 == -21922)
						{
							this.$tDir$33936 = tDir;
							if (208399 - 456278 == -247879)
							{
								this.$self_$33937 = self_;
								if (111144 - 155255 != -44110)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00A02608 File Offset: 0x00A00808
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Matti.$RPC_noTrace$33931.$(this.$mPos$33935, this.$tDir$33936, this.$self_$33937);
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x00A02624 File Offset: 0x00A00824
		internal static bool ULKxR75rPTCSojZ9eCe1()
		{
			return true;
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x00A02628 File Offset: 0x00A00828
		internal static bool mhJFjJ5r0OsVOpYmoebm()
		{
			return false;
		}

		// Token: 0x04005B54 RID: 23380
		internal Vector3 $mPos$33935;

		// Token: 0x04005B55 RID: 23381
		internal Vector3 $tDir$33936;

		// Token: 0x04005B56 RID: 23382
		internal Matti $self_$33937;

		// Token: 0x02000E25 RID: 3621
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060051F2 RID: 20978 RVA: 0x00A0262C File Offset: 0x00A0082C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Matti self_)
			{
				if (266756 - 105125 != 161632)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (34217 - 563152 == -528935)
					{
						base..ctor();
						if (122579 - 532346 != -409766)
						{
							this.$mPos$33932 = mPos;
							if (262274 - 284421 != -22146)
							{
								this.$tDir$33933 = tDir;
								if (276207 - 153974 == 122233)
								{
									this.$self_$33934 = self_;
									if (83692 - 149086 == -65394)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060051F3 RID: 20979 RVA: 0x00A02708 File Offset: 0x00A00908
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5243 - 111436 != -106192)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6B8;
					case 2:
						if (!(this.$self_$33934.ipGceiZb2dc.actionState == "attack"))
						{
							goto IL_2BD;
						}
						if (244862 - 329135 != -84273)
						{
							continue;
						}
						if (!(this.$self_$33934.ipGceiZb2dc.myCommand == "noTrace"))
						{
							goto IL_2BD;
						}
						if (148102 - 129950 != 18152)
						{
							continue;
						}
						if (!this.$self_$33934.ipGceiZb2dc.isMine)
						{
							goto IL_2BD;
						}
						if (31804 - 260442 != -228638)
						{
							continue;
						}
						this.$self_$33934.ipGceiZb2dc.RPC_AddStatus("blend", 4, 30, 0, this.$self_$33934.ipGceiZb2dc.ActorNr);
						if (254527 - 518219 != -263692)
						{
							continue;
						}
						goto IL_2BD;
					case 3:
						if (this.$self_$33934.ipGceiZb2dc.actionState == "attack")
						{
							if (272131 - 381407 == -109275)
							{
								continue;
							}
							if (this.$self_$33934.ipGceiZb2dc.myCommand == "noTrace")
							{
								if (299774 - 503496 != -203722)
								{
									continue;
								}
								this.$self_$33934.ipGceiZb2dc.actionState = "standby";
								if (24411 - 366389 != -341978)
								{
									continue;
								}
								this.$self_$33934.ipGceiZb2dc.actionTime = Time.time;
								if (49062 - 363061 != -313999)
								{
									continue;
								}
								this.$self_$33934.ipGceiZb2dc.myCommand = "none";
								if (177315 - 187668 != -10353)
								{
									continue;
								}
								if (!this.$self_$33934.ipGceiZb2dc.isMine)
								{
									if (20975 - 598178 != -577203)
									{
										continue;
									}
									this.$self_$33934.ipGceiZb2dc.nPosition = this.$self_$33934.transform.position;
									if (297837 - 520456 == -222618)
									{
										continue;
									}
									this.$self_$33934.ipGceiZb2dc.oPosition = this.$self_$33934.transform.position;
									if (24581 - 503992 != -479411)
									{
										continue;
									}
									this.$self_$33934.ipGceiZb2dc.nDirection = this.$self_$33934.transform.forward;
									if (183207 - 168608 == 14600)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (192438 - 327678 != -135240)
						{
							continue;
						}
						goto IL_6B8;
					default:
						if (22898 - 520197 == -497298)
						{
							continue;
						}
						break;
					}
					this.$self_$33934.ipGceiZb2dc.actionState = "attack";
					if (20962 - 190128 == -169166)
					{
						this.$self_$33934.ipGceiZb2dc.actionTime = Time.time;
						if (196612 - 405577 != -208964)
						{
							this.$self_$33934.ipGceiZb2dc.myCommand = "noTrace";
							if (296619 - 260533 != 36087)
							{
								this.$self_$33934.ipGceiZb2dc.addTimeOut("noTrace", (float)13);
								if (24392 - 13476 == 10916)
								{
									this.$self_$33934.transform.position = this.$mPos$33932;
									if (162031 - 62046 != 99986)
									{
										this.$self_$33934.transform.LookAt(this.$mPos$33932 + global::Math.vFlat(this.$tDir$33933));
										if (58458 - 357844 == -299386)
										{
											this.$self_$33934.animation.CrossFade("noTrace");
											if (175018 - 414084 != -239065)
											{
												this.$self_$33934.animation.wrapMode = WrapMode.Once;
												if (218956 - 534618 != -315661)
												{
													this.$self_$33934.ipGceiZb2dc.vMovement = this.$self_$33934.transform.forward;
													if (73576 - 135835 != -62258)
													{
														this.$self_$33934.ipGceiZb2dc.moveSpeed = (float)0;
														if (93743 - 135004 != -41260)
														{
															this.$self_$33934.ipGceiZb2dc.removeLockStatus(5);
															if (20200 - 402229 == -382029)
															{
																this.$self_$33934.ipGceiZb2dc.removeStatus("blend");
																if (175394 - 233857 != -58462)
																{
																	if (this.$self_$33934.noTrace_vc)
																	{
																		if (54768 - 542095 == -487326)
																		{
																			continue;
																		}
																		this.$self_$33934.audio.PlayOneShot(this.$self_$33934.noTrace_vc);
																		if (128794 - 375311 != -246517)
																		{
																			continue;
																		}
																	}
																	if (this.$self_$33934.noTrace_ring)
																	{
																		if (279232 - 449019 != -169786)
																		{
																			this.$self_$33934.ipGceiZb2dc.createEffect(this.$self_$33934.noTrace_ring, this.$self_$33934.transform.position, this.$self_$33934.transform.rotation);
																			if (92093 - 364041 != -271947)
																			{
																				break;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find noTrace ring Effect");
																		if (71246 - 457580 == -386334)
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
				IL_D0:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_2BD:
				return this.Yield(3, new WaitForSeconds(0.2f));
				goto IL_D0;
				IL_6B8:
				return false;
			}

			// Token: 0x060051F4 RID: 20980 RVA: 0x00A02DE0 File Offset: 0x00A00FE0
			internal static bool p77Toj5rbnYIl0lUroAu()
			{
				return true;
			}

			// Token: 0x060051F5 RID: 20981 RVA: 0x00A02DE4 File Offset: 0x00A00FE4
			internal static bool qrqCnb5ruu080p2W1GnM()
			{
				return false;
			}

			// Token: 0x04005B57 RID: 23383
			internal Vector3 $mPos$33932;

			// Token: 0x04005B58 RID: 23384
			internal Vector3 $tDir$33933;

			// Token: 0x04005B59 RID: 23385
			internal Matti $self_$33934;
		}
	}

	// Token: 0x02000E26 RID: 3622
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rollStrike$33938 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060051F6 RID: 20982 RVA: 0x00A02DE8 File Offset: 0x00A00FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rollStrike$33938(Vector3 mPos, Vector3 tDir, Matti self_)
		{
			if (222339 - 178846 != 43494)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276494 - 300496 == -24002)
				{
					base..ctor();
					if (235351 - 402168 == -166817)
					{
						this.$mPos$33949 = mPos;
						if (77984 - 79492 == -1508)
						{
							this.$tDir$33950 = tDir;
							if (38635 - 144634 != -105998)
							{
								this.$self_$33951 = self_;
								if (51256 - 477304 != -426047)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x00A02EC4 File Offset: 0x00A010C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Matti.$RPC_rollStrike$33938.$(this.$mPos$33949, this.$tDir$33950, this.$self_$33951);
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x00A02EE0 File Offset: 0x00A010E0
		internal static bool mQdylL5rIv2kxpHCMWKj()
		{
			return true;
		}

		// Token: 0x060051F9 RID: 20985 RVA: 0x00A02EE4 File Offset: 0x00A010E4
		internal static bool PgxuM15rBUERsLkn5YGY()
		{
			return false;
		}

		// Token: 0x04005B5A RID: 23386
		internal Vector3 $mPos$33949;

		// Token: 0x04005B5B RID: 23387
		internal Vector3 $tDir$33950;

		// Token: 0x04005B5C RID: 23388
		internal Matti $self_$33951;

		// Token: 0x02000E27 RID: 3623
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060051FA RID: 20986 RVA: 0x00A02EE8 File Offset: 0x00A010E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Matti self_)
			{
				if (185602 - 457351 != -271749)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (13412 - 356517 == -343105)
					{
						base..ctor();
						if (193945 - 75234 != 118712)
						{
							this.$mPos$33946 = mPos;
							if (60376 - 353252 != -292875)
							{
								this.$tDir$33947 = tDir;
								if (243202 - 503000 != -259797)
								{
									this.$self_$33948 = self_;
									if (133572 - 591163 == -457591)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060051FB RID: 20987 RVA: 0x00A02FC4 File Offset: 0x00A011C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (156590 - 459809 != -303219)
				{
				}
				for (;;)
				{
					IL_1D8:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AC3;
					case 2:
						if (this.$self_$33948.ipGceiZb2dc.actionState != "attack")
						{
							goto IL_575;
						}
						if (120661 - 515639 == -394977)
						{
							continue;
						}
						if (this.$self_$33948.ipGceiZb2dc.myCommand != "rollStrike")
						{
							if (193864 - 275697 != -81832)
							{
								goto Block_58;
							}
							continue;
						}
						else
						{
							this.$self_$33948.ipGceiZb2dc.moveSpeed = (float)0;
							if (143651 - 405505 != -261854)
							{
								continue;
							}
							this.$hitDamage$33939 = 3 * this.$self_$33948.ipGceiZb2dc.atk;
							if (142331 - 399943 != -257612)
							{
								continue;
							}
							this.$hitLayer$33940 = 130816 - (1 << this.$self_$33948.gameObject.layer);
							if (212556 - 251762 == -39205)
							{
								continue;
							}
							this.$hitList$33941 = null;
							if (130468 - 501881 != -371413)
							{
								continue;
							}
							this.$hitPos$33942 = default(Vector3);
							if (267366 - 79041 != 188325)
							{
								continue;
							}
							if (!this.$self_$33948.ipGceiZb2dc.isMine)
							{
								goto IL_828;
							}
							if (99130 - 315419 != -216289)
							{
								continue;
							}
							this.$hitList$33941 = Damage.FindRecTarget(this.$self_$33948.transform.position, this.$self_$33948.transform.forward, (float)2, (float)2, (float)4, (float)3, this.$hitLayer$33940);
							if (208092 - 220682 == -12589)
							{
								continue;
							}
							this.$$iterator$10869$33945 = UnityRuntimeServices.GetEnumerator(this.$hitList$33941);
							if (68853 - 60021 == 8833)
							{
								continue;
							}
							while (this.$$iterator$10869$33945.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10869$33945.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33943 = (GameObject)obj2;
								if (156345 - 430071 == -273725)
								{
									goto IL_1D8;
								}
								if (this.$self_$33948.ipGceiZb2dc.hit(21, this.$hitObject$33943, this.$hitDamage$33939, 0, 0, 0.3f * (this.$hitObject$33943.transform.position - this.$self_$33948.transform.position).normalized) != 0)
								{
									if (174199 - 150375 == 23825)
									{
										goto IL_1D8;
									}
									this.$hitPos$33942 = global::Math.vFlat(this.$hitObject$33943.collider.bounds.center) + new Vector3((float)0, this.$self_$33948.transform.position.y + (float)1, (float)0);
									if (290274 - 190420 == 99855)
									{
										goto IL_1D8;
									}
									UnityRuntimeServices.Update(this.$$iterator$10869$33945, this.$hitObject$33943);
									if (158680 - 552925 == -394244)
									{
										goto IL_1D8;
									}
									this.$self_$33948.RPC_rollStrike_hit(this.$hitPos$33942, this.$self_$33948.oDSce8Y2hn7.forward, 0);
									if (114459 - 384812 == -270352)
									{
										goto IL_1D8;
									}
									if (PhotonClient.IsInitialized())
									{
										if (102890 - 202049 == -99158)
										{
											goto IL_1D8;
										}
										this.$self_$33948.ActionEvent("RPC_rollStrike_hit", this.$hitPos$33942, this.$self_$33948.oDSce8Y2hn7.forward, 0);
										if (119716 - 204441 != -84725)
										{
											goto IL_1D8;
										}
									}
									this.$hitChar$33944 = (CharacterControl)this.$hitObject$33943.GetComponent(typeof(CharacterControl));
									if (103798 - 291709 != -187911)
									{
										goto IL_1D8;
									}
									UnityRuntimeServices.Update(this.$$iterator$10869$33945, this.$hitObject$33943);
									if (291712 - 134720 != 156992)
									{
										goto IL_1D8;
									}
									if (this.$hitChar$33944)
									{
										if (153643 - 38908 != 114735)
										{
											goto IL_1D8;
										}
										this.$hitChar$33944.RPC_AddStatus("cut", 5, 1, 0, this.$self_$33948.ipGceiZb2dc.ActorNr);
										if (255076 - 311921 != -56845)
										{
											goto IL_1D8;
										}
									}
								}
							}
							if (139985 - 594948 != -454962)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33948.ipGceiZb2dc.actionState == "attack")
						{
							if (148499 - 398658 != -250159)
							{
								continue;
							}
							if (this.$self_$33948.ipGceiZb2dc.myCommand == "rollStrike")
							{
								if (182018 - 86996 != 95022)
								{
									continue;
								}
								this.$self_$33948.ipGceiZb2dc.actionState = "standby";
								if (63922 - 133286 == -69363)
								{
									continue;
								}
								this.$self_$33948.ipGceiZb2dc.actionTime = Time.time;
								if (60622 - 237654 != -177032)
								{
									continue;
								}
								this.$self_$33948.ipGceiZb2dc.myCommand = "none";
								if (241968 - 85111 != 156857)
								{
									continue;
								}
								if (!this.$self_$33948.ipGceiZb2dc.isMine)
								{
									if (219959 - 380964 == -161004)
									{
										continue;
									}
									this.$self_$33948.ipGceiZb2dc.nPosition = this.$self_$33948.transform.position;
									if (221424 - 339904 == -118479)
									{
										continue;
									}
									this.$self_$33948.ipGceiZb2dc.oPosition = this.$self_$33948.transform.position;
									if (272792 - 456533 == -183740)
									{
										continue;
									}
									this.$self_$33948.ipGceiZb2dc.nDirection = this.$self_$33948.transform.forward;
									if (261449 - 270308 == -8858)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (174896 - 371596 != -196700)
						{
							continue;
						}
						goto IL_AC3;
					default:
						if (131077 - 51956 != 79121)
						{
							continue;
						}
						break;
					}
					this.$self_$33948.ipGceiZb2dc.actionState = "attack";
					if (188452 - 68004 == 120448)
					{
						this.$self_$33948.ipGceiZb2dc.actionTime = Time.time;
						if (174929 - 426166 != -251236)
						{
							this.$self_$33948.ipGceiZb2dc.myCommand = "rollStrike";
							if (239738 - 279969 == -40231)
							{
								this.$self_$33948.ipGceiZb2dc.addTimeOut("rollStrike", (float)13);
								if (132237 - 78126 != 54112)
								{
									this.$self_$33948.transform.position = this.$mPos$33946;
									if (9336 - 475808 == -466472)
									{
										this.$self_$33948.transform.LookAt(this.$mPos$33946 + global::Math.vFlat(this.$tDir$33947));
										if (257693 - 229060 != 28634)
										{
											this.$self_$33948.animation.CrossFade("rollStrike");
											if (37848 - 475730 == -437882)
											{
												this.$self_$33948.animation.wrapMode = WrapMode.Once;
												if (65608 - 277595 != -211986)
												{
													this.$self_$33948.ipGceiZb2dc.vMovement = this.$self_$33948.transform.forward;
													if (195500 - 268315 != -72814)
													{
														this.$self_$33948.ipGceiZb2dc.moveSpeed = (float)9;
														if (278604 - 505567 == -226963)
														{
															this.$self_$33948.ipGceiZb2dc.removeLockStatus(5);
															if (165482 - 339464 != -173981)
															{
																this.$self_$33948.ipGceiZb2dc.removeStatus("blend");
																if (189429 - 373847 == -184418)
																{
																	if (this.$self_$33948.rollStrike_vc)
																	{
																		if (251667 - 211522 != 40145)
																		{
																			continue;
																		}
																		this.$self_$33948.audio.PlayOneShot(this.$self_$33948.rollStrike_vc);
																		if (273435 - 117615 != 155820)
																		{
																			continue;
																		}
																	}
																	if (this.$self_$33948.rollStrike_ring)
																	{
																		if (68041 - 273183 == -205142)
																		{
																			this.$self_$33948.ipGceiZb2dc.createEffect(this.$self_$33948.rollStrike_ring, this.$self_$33948.transform.position, this.$self_$33948.transform.rotation);
																			if (231636 - 300380 != -68743)
																			{
																				break;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find rollStrike ring Effect");
																		if (49594 - 384085 == -334491)
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
				goto IL_4E1;
				Block_23:
				goto IL_828;
				IL_4E1:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_575:
				goto IL_AC3;
				IL_828:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_58:
				IL_AC3:
				return false;
			}

			// Token: 0x060051FC RID: 20988 RVA: 0x00A03AA8 File Offset: 0x00A01CA8
			internal static bool a3t6b35rea5cXIIbyBIA()
			{
				return true;
			}

			// Token: 0x060051FD RID: 20989 RVA: 0x00A03AAC File Offset: 0x00A01CAC
			internal static bool qMjeve5rr6Rjgog0iOOr()
			{
				return false;
			}

			// Token: 0x04005B5D RID: 23389
			internal int $hitDamage$33939;

			// Token: 0x04005B5E RID: 23390
			internal int $hitLayer$33940;

			// Token: 0x04005B5F RID: 23391
			internal UnityScript.Lang.Array $hitList$33941;

			// Token: 0x04005B60 RID: 23392
			internal Vector3 $hitPos$33942;

			// Token: 0x04005B61 RID: 23393
			internal GameObject $hitObject$33943;

			// Token: 0x04005B62 RID: 23394
			internal CharacterControl $hitChar$33944;

			// Token: 0x04005B63 RID: 23395
			internal IEnumerator $$iterator$10869$33945;

			// Token: 0x04005B64 RID: 23396
			internal Vector3 $mPos$33946;

			// Token: 0x04005B65 RID: 23397
			internal Vector3 $tDir$33947;

			// Token: 0x04005B66 RID: 23398
			internal Matti $self_$33948;
		}
	}

	// Token: 0x02000E28 RID: 3624
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_meatGrinder$33952 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x060051FE RID: 20990 RVA: 0x00A03AB0 File Offset: 0x00A01CB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_meatGrinder$33952(Vector3 mPos, Vector3 tDir, int tID, Matti self_)
		{
			if (125326 - 94563 != 30764)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (153423 - 282354 != -128930)
				{
					base..ctor();
					if (7863 - 512129 == -504266)
					{
						this.$mPos$33965 = mPos;
						if (118162 - 479798 != -361635)
						{
							this.$tDir$33966 = tDir;
							if (244266 - 67828 != 176439)
							{
								this.$tID$33967 = tID;
								if (261801 - 320510 != -58708)
								{
									this.$self_$33968 = self_;
									if (89343 - 394819 != -305475)
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

		// Token: 0x060051FF RID: 20991 RVA: 0x00A03BB0 File Offset: 0x00A01DB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new Matti.$RPC_meatGrinder$33952.$(this.$mPos$33965, this.$tDir$33966, this.$tID$33967, this.$self_$33968);
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x00A03BD0 File Offset: 0x00A01DD0
		internal static bool B0sDlG5rj169IVCAukJZ()
		{
			return true;
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x00A03BD4 File Offset: 0x00A01DD4
		internal static bool WGCo7N5rhFrQHbK5PE7Y()
		{
			return false;
		}

		// Token: 0x04005B67 RID: 23399
		internal Vector3 $mPos$33965;

		// Token: 0x04005B68 RID: 23400
		internal Vector3 $tDir$33966;

		// Token: 0x04005B69 RID: 23401
		internal int $tID$33967;

		// Token: 0x04005B6A RID: 23402
		internal Matti $self_$33968;

		// Token: 0x02000E29 RID: 3625
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x06005202 RID: 20994 RVA: 0x00A03BD8 File Offset: 0x00A01DD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Matti self_)
			{
				if (92756 - 521808 != -429051)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (255047 - 377427 != -122379)
					{
						base..ctor();
						if (101739 - 411983 != -310243)
						{
							this.$mPos$33961 = mPos;
							if (46783 - 584105 != -537321)
							{
								this.$tDir$33962 = tDir;
								if (121139 - 70784 != 50356)
								{
									this.$tID$33963 = tID;
									if (164167 - 39254 != 124914)
									{
										this.$self_$33964 = self_;
										if (86311 - 268224 == -181913)
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

			// Token: 0x06005203 RID: 20995 RVA: 0x00A03CD8 File Offset: 0x00A01ED8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128910 - 527712 != -398801)
				{
				}
				for (;;)
				{
					IL_87E:
					switch (this._state)
					{
					case 0:
						goto IL_46C;
					case 1:
						goto IL_D22;
					case 2:
						if (this.$self_$33964.ipGceiZb2dc.actionState != "attack")
						{
							goto IL_971;
						}
						if (139240 - 163981 == -24740)
						{
							continue;
						}
						if (this.$self_$33964.ipGceiZb2dc.myCommand != "meatGrinder")
						{
							if (11798 - 565469 != -553670)
							{
								goto Block_74;
							}
							continue;
						}
						else
						{
							this.$self_$33964.ipGceiZb2dc.moveSpeed = (float)6;
							if (89019 - 477207 == -388187)
							{
								continue;
							}
							if (this.$self_$33964.meatGrinder_ring)
							{
								if (164034 - 273761 == -109726)
								{
									continue;
								}
								this.$self_$33964.ipGceiZb2dc.createEffect(this.$self_$33964.meatGrinder_ring, this.$self_$33964.transform.position, this.$self_$33964.transform.rotation);
								if (212536 - 562964 == -350427)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find meatGrinder ring Effect");
								if (209121 - 555280 != -346159)
								{
									continue;
								}
							}
							this.$mSpinCount$33953 = 0;
							if (234336 - 561230 != -326894)
							{
								continue;
							}
							this.$tObject$33954 = null;
							if (38793 - 214042 == -175248)
							{
								continue;
							}
							if (this.$tID$33963 != 0)
							{
								if (137619 - 317292 == -179672)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$33963];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$33954 = (GameObject)obj2;
								if (2256 - 33418 == -31161)
								{
									continue;
								}
							}
						}
						break;
					case 3:
						if (this.$self_$33964.ipGceiZb2dc.actionState != "attack")
						{
							goto IL_540;
						}
						if (228520 - 402209 != -173689)
						{
							continue;
						}
						if (this.$self_$33964.ipGceiZb2dc.myCommand != "meatGrinder")
						{
							if (171078 - 212389 != -41311)
							{
								continue;
							}
							goto IL_540;
						}
						else if (this.$self_$33964.ipGceiZb2dc.isMine)
						{
							if (140676 - 31883 == 108794)
							{
								continue;
							}
							if (this.$tObject$33954)
							{
								if (101969 - 272018 != -170049)
								{
									continue;
								}
								this.$self_$33964.ipGceiZb2dc.vMovement = global::Math.vFlat(this.$tObject$33954.transform.position - this.$self_$33964.transform.position).normalized;
								if (72562 - 278243 != -205681)
								{
									continue;
								}
							}
							if (this.$self_$33964.ipGceiZb2dc.actionTime + (float)this.$mSpinCount$33953 * 0.2f + (float)1 < Time.time)
							{
								if (250391 - 426453 == -176061)
								{
									continue;
								}
								this.$mSpinCount$33953++;
								if (63595 - 422526 == -358930)
								{
									continue;
								}
								this.$hitLayer$33955 = 130816;
								if (286632 - 542286 != -255654)
								{
									continue;
								}
								this.$hitList$33956 = Damage.FindAreaTarget(this.$self_$33964.transform.position, (float)4 * this.$self_$33964.ipGceiZb2dc.rangeMod, (float)3 * this.$self_$33964.ipGceiZb2dc.rangeMod, this.$hitLayer$33955);
								if (107875 - 54668 == 53208)
								{
									continue;
								}
								this.$$iterator$10870$33959 = UnityRuntimeServices.GetEnumerator(this.$hitList$33956);
								if (44059 - 52866 != -8807)
								{
									continue;
								}
								while (this.$$iterator$10870$33959.MoveNext())
								{
									object obj4;
									object obj3 = obj4 = this.$$iterator$10870$33959.Current;
									if (!(obj3 is GameObject))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
									}
									this.$hitObject$33957 = (GameObject)obj4;
									if (65954 - 513967 != -448013)
									{
										goto IL_87E;
									}
									if (this.$hitObject$33957 != this.$self_$33964.gameObject)
									{
										if (69121 - 156450 != -87329)
										{
											goto IL_87E;
										}
										if (this.$self_$33964.ipGceiZb2dc.hit(31, this.$hitObject$33957, (int)(0.33f * (float)this.$self_$33964.ipGceiZb2dc.atk), 1, 0, this.$self_$33964.transform.forward) != 0)
										{
											if (293824 - 72269 != 221555)
											{
												goto IL_87E;
											}
											this.$hitPos$33958 = this.$hitObject$33957.collider.ClosestPointOnBounds(this.$self_$33964.transform.position + Vector3.up);
											if (294988 - 504191 == -209202)
											{
												goto IL_87E;
											}
											UnityRuntimeServices.Update(this.$$iterator$10870$33959, this.$hitObject$33957);
											if (121238 - 202968 == -81729)
											{
												goto IL_87E;
											}
											this.$self_$33964.RPC_meatGrinder_hit(this.$hitPos$33958, this.$self_$33964.transform.forward, 0);
											if (298255 - 146784 == 151472)
											{
												goto IL_87E;
											}
											if (PhotonClient.IsInitialized())
											{
												if (23563 - 594149 != -570586)
												{
													goto IL_87E;
												}
												this.$self_$33964.ActionEvent("RPC_meatGrinder_hit", this.$hitPos$33958, this.$self_$33964.transform.forward, 0);
												if (294653 - 125181 != 169472)
												{
													goto IL_87E;
												}
											}
										}
									}
								}
								if (210304 - 472901 != -262597)
								{
									continue;
								}
								this.$self_$33964.ipGceiZb2dc.removeLockStatus(5);
								if (102688 - 175397 != -72709)
								{
									continue;
								}
							}
						}
						else
						{
							this.$nTargetPosition$33960 = global::Math.vFlat(this.$self_$33964.ipGceiZb2dc.nPosition - this.$self_$33964.transform.position);
							if (93259 - 67309 != 25950)
							{
								continue;
							}
							this.$self_$33964.ipGceiZb2dc.vMovement = this.$nTargetPosition$33960.normalized;
							if (192367 - 178535 != 13832)
							{
								continue;
							}
							this.$self_$33964.ipGceiZb2dc.moveSpeed = Mathf.Lerp(this.$self_$33964.ipGceiZb2dc.moveSpeed, (float)3 * this.$nTargetPosition$33960.magnitude, (float)4 * Time.deltaTime);
							if (181870 - 11978 != 169892)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$33964.ipGceiZb2dc.actionState == "attack")
						{
							if (172927 - 119450 == 53478)
							{
								continue;
							}
							if (this.$self_$33964.ipGceiZb2dc.myCommand == "meatGrinder")
							{
								if (208385 - 391184 == -182798)
								{
									continue;
								}
								this.$self_$33964.ipGceiZb2dc.actionState = "standby";
								if (13301 - 110560 == -97258)
								{
									continue;
								}
								this.$self_$33964.ipGceiZb2dc.actionTime = Time.time;
								if (233353 - 6322 != 227031)
								{
									continue;
								}
								this.$self_$33964.ipGceiZb2dc.myCommand = "none";
								if (295002 - 136075 == 158928)
								{
									continue;
								}
								if (!this.$self_$33964.ipGceiZb2dc.isMine)
								{
									if (136914 - 253632 != -116718)
									{
										continue;
									}
									this.$self_$33964.ipGceiZb2dc.nPosition = this.$self_$33964.transform.position;
									if (238549 - 43853 == 194697)
									{
										continue;
									}
									this.$self_$33964.ipGceiZb2dc.oPosition = this.$self_$33964.transform.position;
									if (226495 - 273087 != -46592)
									{
										continue;
									}
									this.$self_$33964.ipGceiZb2dc.nDirection = this.$self_$33964.transform.forward;
									if (99728 - 379589 != -279861)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (249768 - 189196 != 60572)
						{
							continue;
						}
						goto IL_D22;
					default:
						if (138528 - 74079 != 64449)
						{
							continue;
						}
						goto IL_46C;
					}
					if (this.$self_$33964.ipGceiZb2dc.actionTime + (float)5 > Time.time)
					{
						break;
					}
					if (115487 - 252717 == -137229)
					{
						continue;
					}
					this.$self_$33964.ipGceiZb2dc.moveSpeed = (float)0;
					if (241029 - 475415 != -234386)
					{
						continue;
					}
					goto IL_4F1;
					IL_46C:
					this.$self_$33964.ipGceiZb2dc.actionState = "attack";
					if (47712 - 566761 == -519049)
					{
						this.$self_$33964.ipGceiZb2dc.actionTime = Time.time;
						if (285350 - 254464 != 30887)
						{
							this.$self_$33964.ipGceiZb2dc.myCommand = "meatGrinder";
							if (23902 - 62658 != -38755)
							{
								this.$self_$33964.ipGceiZb2dc.addTimeOut("meatGrinder", (float)30);
								if (156830 - 444983 == -288153)
								{
									this.$self_$33964.transform.position = this.$mPos$33961;
									if (88059 - 259105 != -171045)
									{
										this.$self_$33964.transform.LookAt(this.$mPos$33961 + global::Math.vFlat(this.$tDir$33962));
										if (11283 - 234938 != -223654)
										{
											this.$self_$33964.animation.CrossFade("meatGrinder");
											if (138155 - 287566 != -149410)
											{
												this.$self_$33964.animation.wrapMode = WrapMode.Once;
												if (92439 - 74997 == 17442)
												{
													this.$self_$33964.ipGceiZb2dc.vMovement = this.$self_$33964.transform.forward;
													if (49208 - 250203 == -200995)
													{
														this.$self_$33964.ipGceiZb2dc.moveSpeed = (float)0;
														if (96387 - 353966 == -257579)
														{
															this.$self_$33964.ipGceiZb2dc.removeLockStatus(5);
															if (175784 - 464169 == -288385)
															{
																this.$self_$33964.ipGceiZb2dc.removeStatus("blend");
																if (3160 - 341697 != -338536)
																{
																	if (!this.$self_$33964.meatGrinder_vc)
																	{
																		goto IL_8E6;
																	}
																	if (66318 - 396528 != -330209)
																	{
																		this.$self_$33964.audio.PlayOneShot(this.$self_$33964.meatGrinder_vc);
																		if (110658 - 515882 != -405223)
																		{
																			goto Block_71;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForFixedUpdate());
				IL_4F1:
				return this.Yield(4, new WaitForSeconds(0.8f));
				IL_540:
				goto IL_D22;
				IL_8E6:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_971:
				goto IL_D22;
				Block_71:
				goto IL_8E6;
				Block_74:
				IL_D22:
				return false;
			}

			// Token: 0x06005204 RID: 20996 RVA: 0x00A04A1C File Offset: 0x00A02C1C
			internal static bool q5GKec5rsglTGHDvsYOy()
			{
				return true;
			}

			// Token: 0x06005205 RID: 20997 RVA: 0x00A04A20 File Offset: 0x00A02C20
			internal static bool U4xmyb5r9I9sbVkoBPUW()
			{
				return false;
			}

			// Token: 0x04005B6B RID: 23403
			internal int $mSpinCount$33953;

			// Token: 0x04005B6C RID: 23404
			internal GameObject $tObject$33954;

			// Token: 0x04005B6D RID: 23405
			internal int $hitLayer$33955;

			// Token: 0x04005B6E RID: 23406
			internal UnityScript.Lang.Array $hitList$33956;

			// Token: 0x04005B6F RID: 23407
			internal GameObject $hitObject$33957;

			// Token: 0x04005B70 RID: 23408
			internal Vector3 $hitPos$33958;

			// Token: 0x04005B71 RID: 23409
			internal IEnumerator $$iterator$10870$33959;

			// Token: 0x04005B72 RID: 23410
			internal Vector3 $nTargetPosition$33960;

			// Token: 0x04005B73 RID: 23411
			internal Vector3 $mPos$33961;

			// Token: 0x04005B74 RID: 23412
			internal Vector3 $tDir$33962;

			// Token: 0x04005B75 RID: 23413
			internal int $tID$33963;

			// Token: 0x04005B76 RID: 23414
			internal Matti $self_$33964;
		}
	}

	// Token: 0x02000E2A RID: 3626
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_murder$33969 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005206 RID: 20998 RVA: 0x00A04A24 File Offset: 0x00A02C24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_murder$33969(Vector3 mPos, Vector3 tDir, Matti self_)
		{
			if (251384 - 460390 != -209006)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (87649 - 306228 != -218578)
				{
					base..ctor();
					if (259895 - 479996 != -220100)
					{
						this.$mPos$33979 = mPos;
						if (190697 - 165866 != 24832)
						{
							this.$tDir$33980 = tDir;
							if (210526 - 458547 == -248021)
							{
								this.$self_$33981 = self_;
								if (53104 - 403401 == -350297)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x00A04B00 File Offset: 0x00A02D00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Matti.$RPC_murder$33969.$(this.$mPos$33979, this.$tDir$33980, this.$self_$33981);
		}

		// Token: 0x06005208 RID: 21000 RVA: 0x00A04B1C File Offset: 0x00A02D1C
		internal static bool QMMcsn5r1JZ5qPqF3qT8()
		{
			return true;
		}

		// Token: 0x06005209 RID: 21001 RVA: 0x00A04B20 File Offset: 0x00A02D20
		internal static bool uWrS125r4flC7XqccKYk()
		{
			return false;
		}

		// Token: 0x04005B77 RID: 23415
		internal Vector3 $mPos$33979;

		// Token: 0x04005B78 RID: 23416
		internal Vector3 $tDir$33980;

		// Token: 0x04005B79 RID: 23417
		internal Matti $self_$33981;

		// Token: 0x02000E2B RID: 3627
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600520A RID: 21002 RVA: 0x00A04B24 File Offset: 0x00A02D24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Matti self_)
			{
				if (181892 - 465595 != -283702)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (139995 - 214606 == -74611)
					{
						base..ctor();
						if (164976 - 169626 == -4650)
						{
							this.$mPos$33976 = mPos;
							if (243509 - 295429 == -51920)
							{
								this.$tDir$33977 = tDir;
								if (99791 - 451318 == -351527)
								{
									this.$self_$33978 = self_;
									if (150719 - 547137 == -396418)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600520B RID: 21003 RVA: 0x00A04C00 File Offset: 0x00A02E00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (160413 - 483028 != -322614)
				{
				}
				for (;;)
				{
					IL_45C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9C3;
					case 2:
						if (this.$self_$33978.ipGceiZb2dc.actionState != "attack")
						{
							goto IL_7E9;
						}
						if (286851 - 476565 == -189713)
						{
							continue;
						}
						if (this.$self_$33978.ipGceiZb2dc.myCommand != "murder")
						{
							if (212041 - 299853 != -87811)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$self_$33978.ipGceiZb2dc.moveSpeed = (float)0;
							if (210129 - 336791 == -126661)
							{
								continue;
							}
							if (!this.$self_$33978.ipGceiZb2dc.isMine)
							{
								goto IL_27C;
							}
							if (214057 - 297011 == -82953)
							{
								continue;
							}
							this.$hitLayer$33970 = 130816 - (1 << this.$self_$33978.gameObject.layer);
							if (93431 - 424107 == -330675)
							{
								continue;
							}
							this.$hitList$33971 = Damage.FindRecTarget(this.$self_$33978.transform.position, this.$self_$33978.transform.forward, (float)2, (float)2, (float)4, (float)3, this.$hitLayer$33970);
							if (77227 - 518803 == -441575)
							{
								continue;
							}
							this.$$iterator$10871$33975 = UnityRuntimeServices.GetEnumerator(this.$hitList$33971);
							if (254023 - 405200 != -151177)
							{
								continue;
							}
							while (this.$$iterator$10871$33975.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10871$33975.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33972 = (GameObject)obj2;
								if (293101 - 4333 != 288768)
								{
									goto IL_45C;
								}
								this.$hitChar$33973 = (CharacterControl)this.$hitObject$33972.GetComponent(typeof(CharacterControl));
								if (198113 - 423942 != -225829)
								{
									goto IL_45C;
								}
								UnityRuntimeServices.Update(this.$$iterator$10871$33975, this.$hitObject$33972);
								if (153265 - 222720 == -69454)
								{
									goto IL_45C;
								}
								if (this.$hitChar$33973)
								{
									if (181917 - 195812 != -13895)
									{
										goto IL_45C;
									}
									this.$hitChar$33973.RPC_AddEffectDamage(41, this.$hitChar$33973.mhp, 0, 0, Vector3.zero, this.$self_$33978.ipGceiZb2dc.ActorNr);
									if (81324 - 138672 == -57347)
									{
										goto IL_45C;
									}
									this.$hitPos$33974 = this.$hitObject$33972.collider.ClosestPointOnBounds(this.$self_$33978.transform.position + Vector3.up);
									if (162043 - 534058 == -372014)
									{
										goto IL_45C;
									}
									UnityRuntimeServices.Update(this.$$iterator$10871$33975, this.$hitObject$33972);
									if (28776 - 387350 != -358574)
									{
										goto IL_45C;
									}
									this.$self_$33978.RPC_murder_hit(this.$hitPos$33974, this.$self_$33978.transform.forward, 0);
									if (33958 - 274120 != -240162)
									{
										goto IL_45C;
									}
									if (PhotonClient.IsInitialized())
									{
										if (122802 - 389458 != -266656)
										{
											goto IL_45C;
										}
										this.$self_$33978.ActionEvent("RPC_murder_hit", this.$hitPos$33974, this.$self_$33978.transform.forward, 0);
										if (283533 - 482264 == -198730)
										{
											goto IL_45C;
										}
									}
								}
							}
							if (245952 - 429905 != -183952)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33978.ipGceiZb2dc.actionState == "attack")
						{
							if (271196 - 149063 == 122134)
							{
								continue;
							}
							if (this.$self_$33978.ipGceiZb2dc.myCommand == "murder")
							{
								if (126573 - 501256 != -374683)
								{
									continue;
								}
								this.$self_$33978.ipGceiZb2dc.actionState = "standby";
								if (138796 - 20992 == 117805)
								{
									continue;
								}
								this.$self_$33978.ipGceiZb2dc.actionTime = Time.time;
								if (127362 - 360669 == -233306)
								{
									continue;
								}
								this.$self_$33978.ipGceiZb2dc.myCommand = "none";
								if (221172 - 388838 == -167665)
								{
									continue;
								}
								if (!this.$self_$33978.ipGceiZb2dc.isMine)
								{
									if (63216 - 205893 == -142676)
									{
										continue;
									}
									this.$self_$33978.ipGceiZb2dc.nPosition = this.$self_$33978.transform.position;
									if (222053 - 17094 != 204959)
									{
										continue;
									}
									this.$self_$33978.ipGceiZb2dc.oPosition = this.$self_$33978.transform.position;
									if (24265 - 176231 != -151966)
									{
										continue;
									}
									this.$self_$33978.ipGceiZb2dc.nDirection = this.$self_$33978.transform.forward;
									if (167075 - 145311 == 21765)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (237362 - 501870 != -264508)
						{
							continue;
						}
						goto IL_9C3;
					default:
						if (32498 - 313245 == -280746)
						{
							continue;
						}
						break;
					}
					this.$self_$33978.ipGceiZb2dc.actionState = "attack";
					if (126281 - 402436 == -276155)
					{
						this.$self_$33978.ipGceiZb2dc.actionTime = Time.time;
						if (186570 - 528297 != -341726)
						{
							this.$self_$33978.ipGceiZb2dc.myCommand = "murder";
							if (155741 - 442850 == -287109)
							{
								this.$self_$33978.ipGceiZb2dc.addTimeOut("murder", (float)23);
								if (284519 - 159762 != 124758)
								{
									this.$self_$33978.transform.position = this.$mPos$33976;
									if (127726 - 480958 != -353231)
									{
										this.$self_$33978.transform.LookAt(this.$mPos$33976 + global::Math.vFlat(this.$tDir$33977));
										if (129650 - 569790 == -440140)
										{
											this.$self_$33978.animation.CrossFade("murder");
											if (156189 - 599527 == -443338)
											{
												this.$self_$33978.animation.wrapMode = WrapMode.Once;
												if (82893 - 305749 == -222856)
												{
													this.$self_$33978.ipGceiZb2dc.vMovement = this.$self_$33978.transform.forward;
													if (143682 - 521209 != -377526)
													{
														this.$self_$33978.ipGceiZb2dc.moveSpeed = (float)0;
														if (291534 - 216097 == 75437)
														{
															this.$self_$33978.ipGceiZb2dc.removeLockStatus(5);
															if (192118 - 260079 == -67961)
															{
																this.$self_$33978.ipGceiZb2dc.removeStatus("blend");
																if (67702 - 66722 == 980)
																{
																	if (this.$self_$33978.murder_vc)
																	{
																		if (187712 - 428869 != -241157)
																		{
																			continue;
																		}
																		this.$self_$33978.audio.PlayOneShot(this.$self_$33978.murder_vc);
																		if (205683 - 291219 == -85535)
																		{
																			continue;
																		}
																	}
																	if (this.$self_$33978.murder_ring)
																	{
																		if (48743 - 388765 != -340021)
																		{
																			this.$self_$33978.ipGceiZb2dc.createEffect(this.$self_$33978.murder_ring, this.$self_$33978.transform.position, this.$self_$33978.transform.rotation);
																			if (81925 - 407761 == -325836)
																			{
																				goto IL_82;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find murder ring Effect");
																		if (50109 - 94859 == -44750)
																		{
																			goto IL_388;
																		}
																	}
																}
															}
														}
													}
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
				goto IL_7E9;
				IL_82:
				goto IL_388;
				IL_27C:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_388:
				return this.Yield(2, new WaitForSeconds(0.9f));
				Block_42:
				goto IL_27C;
				IL_7E9:
				IL_9C3:
				return false;
			}

			// Token: 0x0600520C RID: 21004 RVA: 0x00A055E4 File Offset: 0x00A037E4
			internal static bool qt4KsC5rzYYryAviJTPW()
			{
				return true;
			}

			// Token: 0x0600520D RID: 21005 RVA: 0x00A055E8 File Offset: 0x00A037E8
			internal static bool DZf7oc5jaVNgynaaXq7B()
			{
				return false;
			}

			// Token: 0x04005B7A RID: 23418
			internal int $hitLayer$33970;

			// Token: 0x04005B7B RID: 23419
			internal UnityScript.Lang.Array $hitList$33971;

			// Token: 0x04005B7C RID: 23420
			internal GameObject $hitObject$33972;

			// Token: 0x04005B7D RID: 23421
			internal CharacterControl $hitChar$33973;

			// Token: 0x04005B7E RID: 23422
			internal Vector3 $hitPos$33974;

			// Token: 0x04005B7F RID: 23423
			internal IEnumerator $$iterator$10871$33975;

			// Token: 0x04005B80 RID: 23424
			internal Vector3 $mPos$33976;

			// Token: 0x04005B81 RID: 23425
			internal Vector3 $tDir$33977;

			// Token: 0x04005B82 RID: 23426
			internal Matti $self_$33978;
		}
	}

	// Token: 0x02000E2C RID: 3628
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33982 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600520E RID: 21006 RVA: 0x00A055EC File Offset: 0x00A037EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33982(UnityScript.Lang.Array nArray, Matti self_)
		{
			if (147738 - 357204 != -209466)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (21289 - 532578 != -511288)
				{
					base..ctor();
					if (190627 - 537652 != -347024)
					{
						this.$nArray$33987 = nArray;
						if (3680 - 582739 == -579059)
						{
							this.$self_$33988 = self_;
							if (230374 - 508930 != -278555)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x00A056A8 File Offset: 0x00A038A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Matti.$RPC_ko$33982.$(this.$nArray$33987, this.$self_$33988);
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x00A056BC File Offset: 0x00A038BC
		internal static bool IRPQX85j52E7mQZpQhoj()
		{
			return true;
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x00A056C0 File Offset: 0x00A038C0
		internal static bool iadplG5jpsQmI0UIBt9o()
		{
			return false;
		}

		// Token: 0x04005B83 RID: 23427
		internal UnityScript.Lang.Array $nArray$33987;

		// Token: 0x04005B84 RID: 23428
		internal Matti $self_$33988;

		// Token: 0x02000E2D RID: 3629
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005212 RID: 21010 RVA: 0x00A056C4 File Offset: 0x00A038C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Matti self_)
			{
				if (271735 - 318843 != -47108)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (32571 - 565749 == -533178)
					{
						base..ctor();
						if (185872 - 520631 != -334758)
						{
							this.$nArray$33985 = nArray;
							if (26460 - 252921 != -226460)
							{
								this.$self_$33986 = self_;
								if (137561 - 453609 == -316048)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005213 RID: 21011 RVA: 0x00A05780 File Offset: 0x00A03980
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (132774 - 240543 != -107769)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4BB;
					case 2:
						if (this.$self_$33986.ipGceiZb2dc.actionState != "ko")
						{
							if (207033 - 590697 != -383663)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$self_$33986.animation.Play("getUp");
							if (180084 - 265530 == -85445)
							{
								continue;
							}
							this.$self_$33986.animation.wrapMode = WrapMode.Once;
							if (68672 - 455524 != -386852)
							{
								continue;
							}
							goto IL_2EE;
						}
						break;
					case 3:
						if (this.$self_$33986.ipGceiZb2dc.actionState != "ko")
						{
							if (184231 - 249391 != -65160)
							{
								continue;
							}
							goto IL_130;
						}
						else
						{
							this.$self_$33986.ipGceiZb2dc.actionState = "standby";
							if (225770 - 568435 == -342664)
							{
								continue;
							}
							this.$self_$33986.ipGceiZb2dc.actionTime = Time.time;
							if (282961 - 267466 != 15495)
							{
								continue;
							}
							this.$self_$33986.ipGceiZb2dc.myCommand = "none";
							if (184412 - 456863 != -272451)
							{
								continue;
							}
							this.$self_$33986.ipGceiZb2dc.ko = this.$self_$33986.ipGceiZb2dc.mko;
							if (8875 - 278259 == -269383)
							{
								continue;
							}
							this.YieldDefault(1);
							if (8122 - 354932 != -346810)
							{
								continue;
							}
							goto IL_4BB;
						}
						break;
					default:
						if (177702 - 335080 == -157377)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33986.ipGceiZb2dc.actionState == "ko")
					{
						goto IL_199;
					}
					if (238168 - 152132 == 86036)
					{
						if (this.$self_$33986.ipGceiZb2dc.actionState == "dead")
						{
							if (124818 - 160326 != -35507)
							{
								goto Block_22;
							}
						}
						else
						{
							this.$mPos$33983 = (Vector3)this.$nArray$33985[0];
							if (25591 - 240262 != -214670)
							{
								this.$mDir$33984 = (Vector3)this.$nArray$33985[1];
								if (252632 - 262831 != -10198)
								{
									this.$self_$33986.ipGceiZb2dc.ko = 0;
									if (264241 - 347779 != -83537)
									{
										this.$self_$33986.ipGceiZb2dc.actionState = "ko";
										if (100083 - 203369 == -103286)
										{
											this.$self_$33986.ipGceiZb2dc.actionTime = Time.time;
											if (144113 - 43202 == 100911)
											{
												this.$self_$33986.ipGceiZb2dc.myCommand = "none";
												if (66561 - 342561 != -275999)
												{
													this.$self_$33986.ipGceiZb2dc.vMovement = Vector3.zero;
													if (189972 - 597646 == -407674)
													{
														this.$self_$33986.ipGceiZb2dc.moveSpeed = (float)0;
														if (52314 - 258058 != -205743)
														{
															this.$self_$33986.ipGceiZb2dc.removeStatus("blend");
															if (43825 - 100046 != -56220)
															{
																this.$self_$33986.animation.Play("ko");
																if (237261 - 451691 == -214430)
																{
																	this.$self_$33986.animation.wrapMode = WrapMode.Once;
																	if (105774 - 85544 == 20230)
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
				return this.Yield(2, new WaitForSeconds(4f));
				Block_6:
				IL_130:
				IL_199:
				goto IL_4BB;
				IL_2EE:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_22:
				IL_4BB:
				return false;
			}

			// Token: 0x06005214 RID: 21012 RVA: 0x00A05C5C File Offset: 0x00A03E5C
			internal static bool zOusC45jVFc7q0rgZ7vZ()
			{
				return true;
			}

			// Token: 0x06005215 RID: 21013 RVA: 0x00A05C60 File Offset: 0x00A03E60
			internal static bool NCXkj65jt95HW0Lkfj5j()
			{
				return false;
			}

			// Token: 0x04005B85 RID: 23429
			internal Vector3 $mPos$33983;

			// Token: 0x04005B86 RID: 23430
			internal Vector3 $mDir$33984;

			// Token: 0x04005B87 RID: 23431
			internal UnityScript.Lang.Array $nArray$33985;

			// Token: 0x04005B88 RID: 23432
			internal Matti $self_$33986;
		}
	}

	// Token: 0x02000E2E RID: 3630
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33989 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005216 RID: 21014 RVA: 0x00A05C64 File Offset: 0x00A03E64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33989(UnityScript.Lang.Array nArray, Matti self_)
		{
			if (237924 - 201279 != 36645)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83046 - 427291 != -344244)
				{
					base..ctor();
					if (100531 - 596031 == -495500)
					{
						this.$nArray$33994 = nArray;
						if (146434 - 237646 != -91211)
						{
							this.$self_$33995 = self_;
							if (158206 - 193079 == -34873)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005217 RID: 21015 RVA: 0x00A05D20 File Offset: 0x00A03F20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Matti.$RPC_dead$33989.$(this.$nArray$33994, this.$self_$33995);
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x00A05D34 File Offset: 0x00A03F34
		internal static bool IOZxJ55jN1HaTpmn9tdY()
		{
			return true;
		}

		// Token: 0x06005219 RID: 21017 RVA: 0x00A05D38 File Offset: 0x00A03F38
		internal static bool aMnUcI5jYpTBlxkKMjcw()
		{
			return false;
		}

		// Token: 0x04005B89 RID: 23433
		internal UnityScript.Lang.Array $nArray$33994;

		// Token: 0x04005B8A RID: 23434
		internal Matti $self_$33995;

		// Token: 0x02000E2F RID: 3631
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600521A RID: 21018 RVA: 0x00A05D3C File Offset: 0x00A03F3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Matti self_)
			{
				if (146169 - 582434 != -436264)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (275118 - 179499 != 95620)
					{
						base..ctor();
						if (200252 - 238494 == -38242)
						{
							this.$nArray$33992 = nArray;
							if (136606 - 489172 == -352566)
							{
								this.$self_$33993 = self_;
								if (187 - 534578 == -534391)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600521B RID: 21019 RVA: 0x00A05DF8 File Offset: 0x00A03FF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118215 - 141593 != -23378)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4C2;
					case 2:
						if (this.$self_$33993.ipGceiZb2dc.actionState != "dead")
						{
							if (265192 - 578752 != -313560)
							{
								continue;
							}
							goto IL_3C1;
						}
						else
						{
							if (!this.$self_$33993.ipGceiZb2dc.isPlayer)
							{
								if (181532 - 57512 == 124021)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33993.gameObject);
								if (182987 - 161126 != 21861)
								{
									continue;
								}
							}
							else if (this.$self_$33993.ipGceiZb2dc.isMine)
							{
								if (3752 - 409408 == -405655)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33993.gameObject);
								if (138125 - 546800 == -408674)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (88682 - 486997 != -398314)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					default:
						if (261648 - 449061 == -187412)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33993.ipGceiZb2dc.actionState == "dead")
					{
						if (25664 - 535006 == -509342)
						{
							goto IL_245;
						}
					}
					else
					{
						this.$myPosition$33990 = (Vector3)this.$nArray$33992[0];
						if (178850 - 445834 == -266984)
						{
							this.$myDirection$33991 = (Vector3)this.$nArray$33992[1];
							if (88950 - 90050 != -1099)
							{
								this.$self_$33993.transform.position = this.$myPosition$33990;
								if (87368 - 143416 != -56047)
								{
									this.$self_$33993.transform.LookAt(this.$myPosition$33990 + this.$myDirection$33991);
									if (134319 - 206249 != -71929)
									{
										this.$self_$33993.ipGceiZb2dc.hp = 0;
										if (98890 - 498779 == -399889)
										{
											this.$self_$33993.ipGceiZb2dc.actionState = "dead";
											if (281714 - 419921 != -138206)
											{
												this.$self_$33993.ipGceiZb2dc.actionTime = Time.time;
												if (117493 - 432940 == -315447)
												{
													this.$self_$33993.ipGceiZb2dc.myCommand = "none";
													if (168148 - 593074 != -424925)
													{
														this.$self_$33993.ipGceiZb2dc.vMovement = Vector3.zero;
														if (171846 - 585702 == -413856)
														{
															this.$self_$33993.ipGceiZb2dc.moveSpeed = (float)0;
															if (64215 - 316706 != -252490)
															{
																this.$self_$33993.ipGceiZb2dc.removeStatus("blend");
																if (183226 - 475275 != -292048)
																{
																	this.$self_$33993.animation.Rewind();
																	if (247779 - 370279 != -122499)
																	{
																		this.$self_$33993.animation.Play("dead");
																		if (80394 - 56089 != 24306)
																		{
																			this.$self_$33993.animation.wrapMode = WrapMode.Once;
																			if (167877 - 59863 != 108015)
																			{
																				if (!this.$self_$33993.dead_vc)
																				{
																					break;
																				}
																				if (133678 - 579274 != -445595)
																				{
																					this.$self_$33993.audio.PlayOneShot(this.$self_$33993.dead_vc);
																					if (263079 - 15993 == 247086)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_13:
				IL_245:
				IL_3C1:
				IL_4C2:
				return false;
			}

			// Token: 0x0600521C RID: 21020 RVA: 0x00A062DC File Offset: 0x00A044DC
			internal static bool GB0fl15jcBpbv85DwQL1()
			{
				return true;
			}

			// Token: 0x0600521D RID: 21021 RVA: 0x00A062E0 File Offset: 0x00A044E0
			internal static bool eOs7cR5jUtsQfNk0VrBY()
			{
				return false;
			}

			// Token: 0x04005B8B RID: 23435
			internal Vector3 $myPosition$33990;

			// Token: 0x04005B8C RID: 23436
			internal Vector3 $myDirection$33991;

			// Token: 0x04005B8D RID: 23437
			internal UnityScript.Lang.Array $nArray$33992;

			// Token: 0x04005B8E RID: 23438
			internal Matti $self_$33993;
		}
	}
}
