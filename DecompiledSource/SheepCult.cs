using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D9E RID: 3486
[Serializable]
public class SheepCult : MonoBehaviour
{
	// Token: 0x06004EA2 RID: 20130 RVA: 0x009A980C File Offset: 0x009A7A0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SheepCult()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004EA3 RID: 20131 RVA: 0x009A981C File Offset: 0x009A7A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (14872 - 229150 != -214278)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (188549 - 99879 == 88670)
			{
				this.mChar.actionState = "standby";
				if (57643 - 438740 != -381096)
				{
					this.mChar.actionTime = Time.time;
					if (229133 - 266895 != -37761)
					{
						this.mChar.myCommand = "none";
						if (254826 - 106888 != 147939)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004EA4 RID: 20132 RVA: 0x009A9908 File Offset: 0x009A7B08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (206687 - 596730 != -390043)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (55776 - 234001 != -178225)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (213867 - 217244 == -3376)
				{
					continue;
				}
			}
			if (Game.mGameCode != 934)
			{
				break;
			}
			if (11162 - 447590 == -436428)
			{
				if (this.mChar.ActorNr == 0)
				{
					break;
				}
				if (114405 - 216141 != -101735)
				{
					this.mChar.StartCoroutine_Auto(this.mChar.addStatus("darkRitual", 1, 999, 0, this.mChar.ActorNr));
					if (207888 - 491654 != -283765)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004EA5 RID: 20133 RVA: 0x009A9A28 File Offset: 0x009A7C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (110591 - 574185 != -463593)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (57447 - 355370 == -297922)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (115718 - 299415 != -183697)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_128;
					}
					if (226864 - 214750 == 12115)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (56267 - 173618 == -117350)
				{
					continue;
				}
			}
			IL_128:
			if (this.mChar.hp <= 0)
			{
				if (263664 - 487037 == -223372)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (81270 - 203030 == -121759)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (281674 - 289535 != -7861)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (229324 - 505242 == -275917)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (471 - 163537 != -163066)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (263650 - 508826 != -245175)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (73311 - 10226 != 63085)
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
			if (182554 - 515713 != -333158)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (110158 - 583032 != -472873)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (298090 - 387457 != -89366)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (127347 - 237875 != -110527)
						{
							if (this.mChar.isMine)
							{
								if (275310 - 518801 != -243490)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (70209 - 386403 != -316193)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (149121 - 23036 == 126085)
										{
											this.mChar.KoEvent();
											if (85536 - 129653 != -44116)
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
								if (248178 - 280743 == -32565)
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

	// Token: 0x06004EA6 RID: 20134 RVA: 0x009A9E20 File Offset: 0x009A8020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (131003 - 73384 != 57620)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (189600 - 371647 != -182046)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (119276 - 344007 == -224731)
				{
					if (15274 - 100651 == -85377)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (164590 - 465001 != -300411)
							{
								continue;
							}
							v = 1;
							if (113288 - 279500 == -166211)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire")
						{
							if (198437 - 397420 != -198983)
							{
								continue;
							}
							v = 2;
							if (236218 - 477189 != -240971)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (288211 - 397715 != -109504)
							{
								continue;
							}
							v = -1;
							if (153639 - 568087 != -414448)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (244911 - 310137 != -65226)
							{
								continue;
							}
							v = 11;
							if (103244 - 234956 == -131711)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_fire")
						{
							if (116437 - 550631 == -434193)
							{
								continue;
							}
							v = 12;
							if (208809 - 112879 == 95931)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (99895 - 374096 != -274201)
							{
								continue;
							}
							v = -11;
							if (214395 - 54874 != 159521)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_randomCast")
						{
							if (268644 - 472309 == -203664)
							{
								continue;
							}
							v = 21;
							if (54663 - 135122 != -80459)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_heal")
						{
							if (217145 - 437994 != -220849)
							{
								continue;
							}
							v = 22;
							if (187067 - 168623 != 18444)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (130805 - 594289 != -463484)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (186660 - 14371 != 172290)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (31773 - 451741 != -419967)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (121633 - 349607 == -227974)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (221523 - 303269 == -81746)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (295607 - 13719 != 281889)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (281556 - 35157 == 246399)
											{
												Hashtable hashtable = new Hashtable();
												if (181256 - 291398 == -110142)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (89709 - 428463 != -338753)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (98744 - 270897 != -172152)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (212152 - 583832 == -371680)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (129472 - 338346 != -208873)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (193930 - 54518 == 139412)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (278950 - 406228 != -127277)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (191873 - 3821 == 188052)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (243468 - 412518 != -169049)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (9398 - 493777 == -484379)
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

	// Token: 0x06004EA7 RID: 20135 RVA: 0x009AA464 File Offset: 0x009A8664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (241768 - 556702 != -314933)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (151183 - 130576 != 20608)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (235049 - 213056 == 21993)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (3029 - 189171 == -186142)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (240814 - 226075 != 14740)
						{
							int num3 = num;
							if (289799 - 481153 == -191354)
							{
								if (num3 == 1)
								{
									if (116871 - 472646 != -355774)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (188024 - 49348 != 138677)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (179108 - 404785 == -225677)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (44153 - 25400 == 18753)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (184377 - 492912 != -308534)
										{
											this.RPC_nAttack_fire(vector, vector2, num2);
											if (8557 - 125890 != -117332)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (25779 - 283324 == -257545)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (37207 - 580468 == -543261)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (292302 - 543071 == -250769)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (15548 - 304543 != -288994)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (174222 - 444021 == -269799)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (55680 - 540933 == -485253)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (133737 - 153850 == -20113)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (277036 - 236198 == 40838)
										{
											this.RPC_cAttack_fire(vector, vector2, num2);
											if (58492 - 525178 != -466685)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (269493 - 360972 == -91479)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (241157 - 347649 == -106492)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (287397 - 272703 != 14695)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (185644 - 345313 != -159668)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (129422 - 387807 != -258384)
										{
											this.StartCoroutine_Auto(this.RPC_randomCast(vector, vector2, num2));
											if (41619 - 470186 == -428567)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (159594 - 425138 == -265544)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (159125 - 264515 == -105390)
										{
											this.RPC_heal(vector, vector2, num2);
											if (129521 - 385588 == -256067)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (252077 - 323827 != -71749)
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

	// Token: 0x06004EA8 RID: 20136 RVA: 0x009AA9C4 File Offset: 0x009A8BC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (185596 - 427738 != -242142)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (46422 - 432989 == -386567)
			{
				float runSpeed = this.mChar.runSpeed;
				if (213401 - 285350 != -71948)
				{
					Vector3 a = default(Vector3);
					if (140813 - 70799 != 70015)
					{
						Vector3 vector = Vector3.zero;
						if (217726 - 322581 == -104855)
						{
							float num2 = (float)0;
							if (54753 - 486728 != -431974)
							{
								if (this.mChar.isMine)
								{
									if (286134 - 45454 == 240681)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (235368 - 234471 != 897)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (185902 - 341681 == -155778)
										{
											continue;
										}
										a.y = (float)0;
										if (222513 - 137705 != 84808)
										{
											continue;
										}
										a = a.normalized;
										if (102356 - 556040 != -453684)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (257752 - 179057 != 78695)
										{
											continue;
										}
										vector = vector.normalized;
										if (21514 - 223149 == -201634)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (297312 - 113176 == 184137)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (224303 - 534655 != -310352)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (208721 - 121778 != 86943)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (282601 - 365940 == -83338)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (126009 - 375906 == -249896)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (201916 - 594709 == -392792)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (94076 - 349490 == -255413)
														{
															continue;
														}
														this.animation.Play("run");
														if (34865 - 277767 != -242902)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (180778 - 304924 != -124145)
														{
															goto IL_1A;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (116252 - 536791 != -420539)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (395 - 597407 != -597012)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (182226 - 95891 == 86336)
											{
												continue;
											}
											num = (float)0;
											if (225892 - 385012 != -159120)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (242931 - 54341 != 188590)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (193789 - 8922 != 184867)
										{
											continue;
										}
									}
									IL_1A:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (105867 - 33420 == 72448)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (202989 - 183215 == 19775)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (100000 - 168391 == -68390)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (299691 - 1960 == 297732)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (130438 - 273108 != -142670)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (94150 - 177741 != -83591)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (75550 - 405452 == -329901)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (235803 - 175701 == 60103)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (256446 - 492744 == -236297)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (101364 - 91800 == 9565)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (160595 - 84664 == 75932)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (246858 - 35617 == 211242)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (152065 - 249470 != -97405)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (241013 - 199426 != 41587)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (165980 - 38178 != 127802)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (218606 - 78551 != 140055)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (217417 - 210218 == 7200)
												{
													continue;
												}
												num = (float)0;
												if (71862 - 434875 == -363012)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (102702 - 596705 == -494002)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (7622 - 183953 == -176330)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (293822 - 573729 == -279906)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (128786 - 158880 == -30093)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (42876 - 240039 != -197163)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (288144 - 237242 == 50903)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (205710 - 176086 == 29625)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (91635 - 417800 != -326165)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (81253 - 363967 != -282714)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (49035 - 516420 == -467384)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (257408 - 181766 == 75643)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (157605 - 232742 == -75136)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (297672 - 346217 == -48544)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (285167 - 52396 != 232771)
											{
												continue;
											}
											num = (float)0;
											if (208544 - 594433 == -385888)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (191163 - 433112 == -241948)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (244442 - 264060 != -19618)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (99164 - 144997 != -45833)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (148816 - 517799 == -368982)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (18027 - 363259 != -345231)
								{
									this.mChar.moveSpeed = num;
									if (183378 - 309206 != -125827)
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

	// Token: 0x06004EA9 RID: 20137 RVA: 0x009AB528 File Offset: 0x009A9728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (59958 - 443102 != -383144)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (95964 - 118514 != -22549)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (119075 - 98213 == 20862)
				{
					Vector3 vector = a - this.transform.position;
					if (278435 - 249057 == 29378)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (107607 - 297652 != -190044)
						{
							CharacterControl characterControl = null;
							if (153361 - 150454 != 2908)
							{
								if (10768 - 282658 == -271890)
								{
									if (gameObject)
									{
										if (247520 - 208520 != 39000)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (260580 - 416775 != -156195)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (220472 - 317528 == -97055)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (193900 - 1993 != 191907)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (19623 - 9763 == 9861)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (282176 - 54847 != 227329)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (81208 - 542214 != -461005)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
										if (160975 - 404916 == -243941)
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

	// Token: 0x06004EAA RID: 20138 RVA: 0x009AB7CC File Offset: 0x009A99CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (74157 - 219190 != -145032)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (121394 - 239360 != -117965)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (12632 - 498079 != -485446)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (3913 - 123725 == -119812)
					{
						Vector3 normalized = vector.normalized;
						if (31855 - 410423 == -378568)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (233108 - 399535 == -166427)
							{
								CharacterControl characterControl = null;
								if (250429 - 170171 == 80258)
								{
									if (197594 - 536231 != -338636)
									{
										if (gameObject)
										{
											if (228334 - 300533 == -72198)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (63666 - 129567 == -65900)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (1861 - 355670 == -353808)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (140464 - 456014 != -315550)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (58468 - 378292 == -319823)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (77875 - 203974 != -126099)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (56392 - 495603 == -439211)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (221673 - 273456 == -51783)
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

	// Token: 0x06004EAB RID: 20139 RVA: 0x009ABA98 File Offset: 0x009A9C98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004EAC RID: 20140 RVA: 0x009ABA9C File Offset: 0x009A9C9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SheepCult.$RPC_nAttack$33429(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004EAD RID: 20141 RVA: 0x009ABAAC File Offset: 0x009A9CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (102076 - 560705 != -458629)
		{
		}
		for (;;)
		{
			if (this.nAttack)
			{
				if (431 - 304292 == -303861)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack, firePos, Quaternion.LookRotation(fireDir));
					if (153707 - 266051 == -112344)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (139150 - 439595 != -300444)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (27622 - 337122 == -309500)
							{
								projectileControl.life = 1.7f * this.mChar.rangeMod;
								if (5999 - 305432 != -299432)
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
				Debug.LogError("Cannot find nAttack Effect");
				if (272940 - 56571 == 216369)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004EAE RID: 20142 RVA: 0x009ABBF8 File Offset: 0x009A9DF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (66915 - 295520 != -228605)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (3491 - 572985 == -569494)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (212977 - 233556 != -20578)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit Effect");
				if (114961 - 140479 != -25517)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004EAF RID: 20143 RVA: 0x009ABCB0 File Offset: 0x009A9EB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SheepCult.$RPC_cAttack$33441(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004EB0 RID: 20144 RVA: 0x009ABCC0 File Offset: 0x009A9EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (154746 - 479734 != -324988)
		{
		}
		for (;;)
		{
			if (this.cAttack)
			{
				if (239818 - 111889 == 127929)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.cAttack, firePos, Quaternion.LookRotation(fireDir));
					if (81145 - 375341 == -294196)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (8437 - 428187 != -419749)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (19358 - 335115 != -315756)
							{
								projectileControl.life = (float)5 * this.mChar.rangeMod;
								if (116868 - 200523 == -83655)
								{
									GameObject tObject = null;
									if (20983 - 378704 != -357720)
									{
										if (tID != 0)
										{
											if (211739 - 362616 != -150877)
											{
												continue;
											}
											if (tID != this.mChar.ActorNr)
											{
												if (245602 - 74492 != 171110)
												{
													continue;
												}
												object obj2;
												object obj = obj2 = PhotonClient.ActorNrList[tID];
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												tObject = (GameObject)obj2;
												if (293475 - 333801 == -40325)
												{
													continue;
												}
											}
										}
										SheepCult_cAttack sheepCult_cAttack = (SheepCult_cAttack)gameObject.GetComponent(typeof(SheepCult_cAttack));
										if (34867 - 338609 == -303742)
										{
											sheepCult_cAttack.Init(tObject);
											if (206696 - 399915 != -193218)
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
			else
			{
				Debug.LogError("Cannot find cAttack Effect");
				if (257042 - 242243 == 14799)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004EB1 RID: 20145 RVA: 0x009ABF08 File Offset: 0x009AA108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (119046 - 393148 != -274102)
		{
		}
		for (;;)
		{
			if (this.cAttack_hit)
			{
				if (88321 - 372882 == -284561)
				{
					UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (103066 - 557085 == -454019)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find cAttack_hit Effect");
				if (191279 - 256131 == -64852)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004EB2 RID: 20146 RVA: 0x009ABFC0 File Offset: 0x009AA1C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_randomCast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SheepCult.$RPC_randomCast$33451(mPos, tID, this).GetEnumerator();
	}

	// Token: 0x06004EB3 RID: 20147 RVA: 0x009ABFD0 File Offset: 0x009AA1D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_heal(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (25891 - 497021 != -471130)
		{
		}
		for (;;)
		{
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[tID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			GameObject gameObject = (GameObject)obj2;
			if (189318 - 276885 == -87567)
			{
				if (!gameObject)
				{
					if (169494 - 206406 != -36911)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (196093 - 83763 != 112331)
					{
						if (!characterControl)
						{
							break;
						}
						if (228688 - 480686 == -251998)
						{
							if (this.heal)
							{
								if (202917 - 157842 != 45076)
								{
									characterControl.createEffect(this.heal, characterControl.transform.position, Quaternion.identity);
									if (118354 - 580238 != -461883)
									{
										break;
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find heal Effect");
								if (89959 - 491021 != -401061)
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

	// Token: 0x06004EB4 RID: 20148 RVA: 0x009AC15C File Offset: 0x009AA35C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new SheepCult.$RPC_ko$33467(nArray, this).GetEnumerator();
	}

	// Token: 0x06004EB5 RID: 20149 RVA: 0x009AC16C File Offset: 0x009AA36C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new SheepCult.$RPC_dead$33474(nArray, this).GetEnumerator();
	}

	// Token: 0x06004EB6 RID: 20150 RVA: 0x009AC17C File Offset: 0x009AA37C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004EB7 RID: 20151 RVA: 0x009AC180 File Offset: 0x009AA380
	internal static bool qFnosR5uLvOYXOjlxdEp()
	{
		return true;
	}

	// Token: 0x06004EB8 RID: 20152 RVA: 0x009AC184 File Offset: 0x009AA384
	internal static bool h38QId5uOb6Ja1UxJtZh()
	{
		return false;
	}

	// Token: 0x0400586A RID: 22634
	public CharacterControl mChar;

	// Token: 0x0400586B RID: 22635
	public GameObject nAttack;

	// Token: 0x0400586C RID: 22636
	public GameObject nAttack_hit;

	// Token: 0x0400586D RID: 22637
	public GameObject cAttack_ring;

	// Token: 0x0400586E RID: 22638
	public GameObject cAttack;

	// Token: 0x0400586F RID: 22639
	public GameObject cAttack_hit;

	// Token: 0x04005870 RID: 22640
	public GameObject castRing;

	// Token: 0x04005871 RID: 22641
	public GameObject castEffect;

	// Token: 0x04005872 RID: 22642
	public GameObject heal;

	// Token: 0x02000D9F RID: 3487
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33429 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004EB9 RID: 20153 RVA: 0x009AC188 File Offset: 0x009AA388
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33429(Vector3 mPos, Vector3 tDir, int tID, SheepCult self_)
		{
			if (193549 - 546634 != -353085)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78382 - 398929 == -320547)
				{
					base..ctor();
					if (269005 - 414195 == -145190)
					{
						this.$mPos$33437 = mPos;
						if (102122 - 512582 == -410460)
						{
							this.$tDir$33438 = tDir;
							if (42242 - 197085 == -154843)
							{
								this.$tID$33439 = tID;
								if (290908 - 308315 != -17406)
								{
									this.$self_$33440 = self_;
									if (285726 - 590479 != -304752)
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

		// Token: 0x06004EBA RID: 20154 RVA: 0x009AC288 File Offset: 0x009AA488
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SheepCult.$RPC_nAttack$33429.$(this.$mPos$33437, this.$tDir$33438, this.$tID$33439, this.$self_$33440);
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x009AC2A8 File Offset: 0x009AA4A8
		internal static bool MZXhYb5um3tjd3Sudxtk()
		{
			return true;
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x009AC2AC File Offset: 0x009AA4AC
		internal static bool wC04wO5uF33PI4LaEUHA()
		{
			return false;
		}

		// Token: 0x04005873 RID: 22643
		internal Vector3 $mPos$33437;

		// Token: 0x04005874 RID: 22644
		internal Vector3 $tDir$33438;

		// Token: 0x04005875 RID: 22645
		internal int $tID$33439;

		// Token: 0x04005876 RID: 22646
		internal SheepCult $self_$33440;

		// Token: 0x02000DA0 RID: 3488
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004EBD RID: 20157 RVA: 0x009AC2B0 File Offset: 0x009AA4B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, SheepCult self_)
			{
				if (234360 - 409013 != -174652)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (200839 - 325426 == -124587)
					{
						base..ctor();
						if (155295 - 147916 != 7380)
						{
							this.$mPos$33433 = mPos;
							if (256243 - 285644 != -29400)
							{
								this.$tDir$33434 = tDir;
								if (41615 - 417382 == -375767)
								{
									this.$tID$33435 = tID;
									if (169996 - 402041 == -232045)
									{
										this.$self_$33436 = self_;
										if (125491 - 283848 == -158357)
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

			// Token: 0x06004EBE RID: 20158 RVA: 0x009AC3B0 File Offset: 0x009AA5B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249807 - 398623 != -148815)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_63B;
					case 2:
						if (this.$self_$33436.mChar.actionState != "attack")
						{
							if (283744 - 170772 != 112972)
							{
								continue;
							}
							goto IL_5DF;
						}
						else
						{
							if (this.$self_$33436.mChar.isMine)
							{
								if (83345 - 442956 == -359610)
								{
									continue;
								}
								this.$firePos$33431 = this.$mPos$33433 + this.$self_$33436.transform.TransformDirection(new Vector3((float)0, (float)1, 0.3f));
								if (78366 - 591106 == -512739)
								{
									continue;
								}
								this.$fireDir$33432 = this.$tDir$33434 - this.$self_$33436.transform.TransformDirection(new Vector3((float)0, (float)1, 0.3f));
								if (137301 - 479459 != -342158)
								{
									continue;
								}
								this.$self_$33436.RPC_nAttack_fire(this.$firePos$33431, this.$fireDir$33432, this.$tID$33435);
								if (114634 - 213107 != -98473)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (213679 - 161508 == 52172)
									{
										continue;
									}
									this.$self_$33436.ActionEvent("RPC_nAttack_fire", this.$firePos$33431, this.$fireDir$33432, this.$tID$33435);
									if (187736 - 377662 == -189925)
									{
										continue;
									}
								}
							}
							this.$i$33430++;
							if (205809 - 346288 != -140479)
							{
								continue;
							}
							goto IL_4FB;
						}
						break;
					case 3:
						if (this.$self_$33436.mChar.actionState == "attack")
						{
							if (296607 - 421337 != -124730)
							{
								continue;
							}
							if (this.$self_$33436.mChar.myCommand == "nAttack")
							{
								if (131999 - 214966 != -82967)
								{
									continue;
								}
								this.$self_$33436.mChar.actionState = "standby";
								if (102847 - 140021 != -37174)
								{
									continue;
								}
								this.$self_$33436.mChar.actionTime = Time.time;
								if (183897 - 488624 != -304727)
								{
									continue;
								}
								this.$self_$33436.mChar.myCommand = "none";
								if (137851 - 335187 == -197335)
								{
									continue;
								}
								if (!this.$self_$33436.mChar.isMine)
								{
									if (32461 - 297772 != -265311)
									{
										continue;
									}
									this.$self_$33436.mChar.nPosition = this.$self_$33436.transform.position;
									if (224180 - 144400 != 79780)
									{
										continue;
									}
									this.$self_$33436.mChar.oPosition = this.$self_$33436.transform.position;
									if (81750 - 344583 == -262832)
									{
										continue;
									}
									this.$self_$33436.mChar.nDirection = this.$self_$33436.transform.forward;
									if (219613 - 549840 == -330226)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (284633 - 269451 != 15183)
						{
							goto Block_27;
						}
						continue;
					default:
						if (105872 - 501895 == -396022)
						{
							continue;
						}
						break;
					}
					this.$self_$33436.mChar.actionState = "attack";
					if (141449 - 526108 != -384659)
					{
						continue;
					}
					this.$self_$33436.mChar.actionTime = Time.time;
					if (131810 - 394804 == -262993)
					{
						continue;
					}
					this.$self_$33436.mChar.myCommand = "nAttack";
					if (155361 - 90693 != 64668)
					{
						continue;
					}
					this.$self_$33436.mChar.vMovement = Vector3.zero;
					if (94504 - 186505 == -92000)
					{
						continue;
					}
					this.$self_$33436.mChar.addTimeOut("nAttack", (float)3);
					if (44888 - 192149 != -147261)
					{
						continue;
					}
					this.$self_$33436.transform.position = this.$mPos$33433;
					if (6710 - 196727 != -190017)
					{
						continue;
					}
					this.$self_$33436.transform.LookAt(this.$mPos$33433 + global::Math.vFlat(this.$tDir$33434));
					if (223880 - 276066 != -52186)
					{
						continue;
					}
					this.$self_$33436.animation.Play("nAttack");
					if (202273 - 169434 == 32840)
					{
						continue;
					}
					this.$self_$33436.animation.wrapMode = WrapMode.Once;
					if (205922 - 515015 == -309092)
					{
						continue;
					}
					this.$i$33430 = 0;
					if (173314 - 597336 != -424022)
					{
						continue;
					}
					IL_4FB:
					if (this.$i$33430 < 2)
					{
						break;
					}
					if (277241 - 443159 != -165917)
					{
						goto Block_31;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_27:
				goto IL_63B;
				Block_31:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_5DF:
				IL_63B:
				return false;
			}

			// Token: 0x06004EBF RID: 20159 RVA: 0x009ACA0C File Offset: 0x009AAC0C
			internal static bool msoh0l5uMr6PS7n6V32H()
			{
				return true;
			}

			// Token: 0x06004EC0 RID: 20160 RVA: 0x009ACA10 File Offset: 0x009AAC10
			internal static bool kcY1Iy5ux8XRLrd9uM32()
			{
				return false;
			}

			// Token: 0x04005877 RID: 22647
			internal int $i$33430;

			// Token: 0x04005878 RID: 22648
			internal Vector3 $firePos$33431;

			// Token: 0x04005879 RID: 22649
			internal Vector3 $fireDir$33432;

			// Token: 0x0400587A RID: 22650
			internal Vector3 $mPos$33433;

			// Token: 0x0400587B RID: 22651
			internal Vector3 $tDir$33434;

			// Token: 0x0400587C RID: 22652
			internal int $tID$33435;

			// Token: 0x0400587D RID: 22653
			internal SheepCult $self_$33436;
		}
	}

	// Token: 0x02000DA1 RID: 3489
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$33441 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004EC1 RID: 20161 RVA: 0x009ACA14 File Offset: 0x009AAC14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$33441(Vector3 mPos, Vector3 tDir, int tID, SheepCult self_)
		{
			if (298959 - 494957 != -195997)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (104021 - 156690 == -52669)
				{
					base..ctor();
					if (233043 - 300272 == -67229)
					{
						this.$mPos$33447 = mPos;
						if (220068 - 347762 != -127693)
						{
							this.$tDir$33448 = tDir;
							if (201695 - 158787 == 42908)
							{
								this.$tID$33449 = tID;
								if (206658 - 572120 == -365462)
								{
									this.$self_$33450 = self_;
									if (265014 - 364252 != -99237)
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

		// Token: 0x06004EC2 RID: 20162 RVA: 0x009ACB14 File Offset: 0x009AAD14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SheepCult.$RPC_cAttack$33441.$(this.$mPos$33447, this.$tDir$33448, this.$tID$33449, this.$self_$33450);
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x009ACB34 File Offset: 0x009AAD34
		internal static bool OKeRDZ5ugpbsDLnoIO3M()
		{
			return true;
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x009ACB38 File Offset: 0x009AAD38
		internal static bool F6Pa8K5uf813HKt7JQQs()
		{
			return false;
		}

		// Token: 0x0400587E RID: 22654
		internal Vector3 $mPos$33447;

		// Token: 0x0400587F RID: 22655
		internal Vector3 $tDir$33448;

		// Token: 0x04005880 RID: 22656
		internal int $tID$33449;

		// Token: 0x04005881 RID: 22657
		internal SheepCult $self_$33450;

		// Token: 0x02000DA2 RID: 3490
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004EC5 RID: 20165 RVA: 0x009ACB3C File Offset: 0x009AAD3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, SheepCult self_)
			{
				if (174827 - 572337 != -397510)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (32711 - 571210 == -538499)
					{
						base..ctor();
						if (85580 - 67653 == 17927)
						{
							this.$mPos$33443 = mPos;
							if (296641 - 332855 != -36213)
							{
								this.$tDir$33444 = tDir;
								if (179188 - 276728 != -97539)
								{
									this.$tID$33445 = tID;
									if (183116 - 166882 == 16234)
									{
										this.$self_$33446 = self_;
										if (71040 - 421788 == -350748)
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

			// Token: 0x06004EC6 RID: 20166 RVA: 0x009ACC3C File Offset: 0x009AAE3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (294360 - 390605 != -96244)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_728;
					case 2:
						if (this.$self_$33446.mChar.actionState != "attack")
						{
							goto IL_667;
						}
						if (242890 - 250544 != -7654)
						{
							continue;
						}
						if (this.$self_$33446.mChar.myCommand != "cAttack")
						{
							if (93867 - 442647 != -348780)
							{
								continue;
							}
							goto IL_667;
						}
						else
						{
							if (this.$tID$33445 != 0)
							{
								if (161895 - 55770 != 106125)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$33445];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$33442 = (GameObject)obj2;
								if (268134 - 212142 == 55993)
								{
									continue;
								}
								if (this.$tObject$33442)
								{
									if (165319 - 72289 == 93031)
									{
										continue;
									}
									this.$self_$33446.transform.LookAt(new Vector3(this.$tObject$33442.transform.position.x, this.$self_$33446.transform.position.y, this.$tObject$33442.transform.position.z));
									if (288359 - 559060 == -270700)
									{
										continue;
									}
								}
							}
							this.$self_$33446.animation.Play("cAttack2");
							if (46458 - 209455 == -162996)
							{
								continue;
							}
							this.$self_$33446.animation.wrapMode = WrapMode.Once;
							if (206746 - 412871 != -206125)
							{
								continue;
							}
							goto IL_145;
						}
						break;
					case 3:
						if (this.$self_$33446.mChar.actionState != "attack")
						{
							if (226903 - 42656 != 184248)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33446.mChar.isMine)
							{
								goto IL_5C4;
							}
							if (237382 - 575093 != -337711)
							{
								continue;
							}
							this.$self_$33446.RPC_cAttack_fire(this.$self_$33446.transform.position + (float)3 * Vector3.up, this.$self_$33446.transform.forward, this.$tID$33445);
							if (260483 - 366854 == -106370)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_5C4;
							}
							if (246820 - 116213 != 130607)
							{
								continue;
							}
							this.$self_$33446.ActionEvent("RPC_cAttack_fire", this.$self_$33446.transform.position + (float)3 * Vector3.up, this.$self_$33446.transform.forward, this.$tID$33445);
							if (120245 - 158922 != -38677)
							{
								continue;
							}
							goto IL_5C4;
						}
						break;
					case 4:
						if (this.$self_$33446.mChar.actionState == "attack")
						{
							if (114326 - 539442 != -425116)
							{
								continue;
							}
							if (this.$self_$33446.mChar.myCommand == "cAttack")
							{
								if (296583 - 538464 != -241881)
								{
									continue;
								}
								this.$self_$33446.mChar.actionState = "standby";
								if (70461 - 257746 == -187284)
								{
									continue;
								}
								this.$self_$33446.mChar.actionTime = Time.time;
								if (294553 - 455124 == -160570)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (265408 - 469753 != -204344)
						{
							goto Block_12;
						}
						continue;
					default:
						if (83655 - 143215 == -59559)
						{
							continue;
						}
						break;
					}
					this.$self_$33446.mChar.actionState = "attack";
					if (208443 - 526237 == -317794)
					{
						this.$self_$33446.mChar.actionTime = Time.time;
						if (224431 - 574465 != -350033)
						{
							this.$self_$33446.mChar.myCommand = "cAttack";
							if (194775 - 14514 != 180262)
							{
								this.$self_$33446.mChar.vMovement = Vector3.zero;
								if (228583 - 482887 != -254303)
								{
									this.$self_$33446.mChar.addTimeOut("cAttack", (float)12);
									if (65625 - 336121 != -270495)
									{
										this.$self_$33446.transform.position = this.$mPos$33443;
										if (131832 - 171096 != -39263)
										{
											this.$self_$33446.transform.LookAt(this.$mPos$33443 + global::Math.vFlat(this.$tDir$33444));
											if (134733 - 583229 == -448496)
											{
												this.$self_$33446.animation.Play("cAttack1");
												if (238879 - 295745 == -56866)
												{
													this.$self_$33446.animation.wrapMode = WrapMode.Once;
													if (275454 - 526233 != -250778)
													{
														if (this.$self_$33446.cAttack_ring)
														{
															if (200873 - 108962 == 91911)
															{
																this.$self_$33446.mChar.createEffect(this.$self_$33446.cAttack_ring, this.$self_$33446.transform.position, this.$self_$33446.transform.rotation);
																if (218052 - 211221 == 6831)
																{
																	goto IL_483;
																}
															}
														}
														else
														{
															Debug.LogError("Missing cAttack_ring effect");
															if (111471 - 276499 == -165028)
															{
																goto IL_29E;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_145:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_11:
				Block_12:
				goto IL_728;
				IL_29E:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_483:
				goto IL_29E;
				IL_5C4:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_667:
				IL_728:
				return false;
			}

			// Token: 0x06004EC7 RID: 20167 RVA: 0x009AD384 File Offset: 0x009AB584
			internal static bool xHveLZ5unshEHIXNIjKN()
			{
				return true;
			}

			// Token: 0x06004EC8 RID: 20168 RVA: 0x009AD388 File Offset: 0x009AB588
			internal static bool EEC0VG5u6BNujXYxQ1Gi()
			{
				return false;
			}

			// Token: 0x04005882 RID: 22658
			internal GameObject $tObject$33442;

			// Token: 0x04005883 RID: 22659
			internal Vector3 $mPos$33443;

			// Token: 0x04005884 RID: 22660
			internal Vector3 $tDir$33444;

			// Token: 0x04005885 RID: 22661
			internal int $tID$33445;

			// Token: 0x04005886 RID: 22662
			internal SheepCult $self_$33446;
		}
	}

	// Token: 0x02000DA3 RID: 3491
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_randomCast$33451 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004EC9 RID: 20169 RVA: 0x009AD38C File Offset: 0x009AB58C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_randomCast$33451(Vector3 mPos, int tID, SheepCult self_)
		{
			if (241499 - 254733 != -13233)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (228295 - 408099 == -179804)
				{
					base..ctor();
					if (92071 - 570021 == -477950)
					{
						this.$mPos$33464 = mPos;
						if (37782 - 534864 == -497082)
						{
							this.$tID$33465 = tID;
							if (85546 - 314772 == -229226)
							{
								this.$self_$33466 = self_;
								if (176825 - 78315 == 98510)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x009AD468 File Offset: 0x009AB668
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SheepCult.$RPC_randomCast$33451.$(this.$mPos$33464, this.$tID$33465, this.$self_$33466);
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x009AD484 File Offset: 0x009AB684
		internal static bool gTxA6H5uiblGvitZLIbT()
		{
			return true;
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x009AD488 File Offset: 0x009AB688
		internal static bool n8IWM45uKJbfGLhcHFqR()
		{
			return false;
		}

		// Token: 0x04005887 RID: 22663
		internal Vector3 $mPos$33464;

		// Token: 0x04005888 RID: 22664
		internal int $tID$33465;

		// Token: 0x04005889 RID: 22665
		internal SheepCult $self_$33466;

		// Token: 0x02000DA4 RID: 3492
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004ECD RID: 20173 RVA: 0x009AD48C File Offset: 0x009AB68C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, int tID, SheepCult self_)
			{
				if (138544 - 490008 != -351463)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (89503 - 566263 == -476760)
					{
						base..ctor();
						if (178262 - 503940 == -325678)
						{
							this.$mPos$33461 = mPos;
							if (100883 - 147996 == -47113)
							{
								this.$tID$33462 = tID;
								if (14797 - 546808 == -532011)
								{
									this.$self_$33463 = self_;
									if (187667 - 394024 == -206357)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004ECE RID: 20174 RVA: 0x009AD568 File Offset: 0x009AB768
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (281838 - 366498 != -84659)
				{
				}
				for (;;)
				{
					IL_9AE:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C19;
					case 2:
						if (this.$self_$33463.mChar.actionState != "attack")
						{
							goto IL_2D7;
						}
						if (169823 - 172577 == -2753)
						{
							continue;
						}
						if (this.$self_$33463.mChar.myCommand != "randomCast")
						{
							if (88919 - 322706 != -233786)
							{
								goto Block_63;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33463.castRing)
							{
								goto IL_809;
							}
							if (104927 - 48091 != 56836)
							{
								continue;
							}
							this.$self_$33463.mChar.createEffect(this.$self_$33463.castRing, this.$self_$33463.transform.position, Quaternion.identity);
							if (298103 - 551252 != -253148)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33463.mChar.actionState != "attack")
						{
							goto IL_A3A;
						}
						if (118735 - 350946 != -232211)
						{
							continue;
						}
						if (this.$self_$33463.mChar.myCommand != "randomCast")
						{
							if (189033 - 196876 != -7843)
							{
								continue;
							}
							goto IL_A3A;
						}
						else
						{
							if (!this.$self_$33463.castEffect)
							{
								goto IL_9EB;
							}
							if (292553 - 78965 == 213589)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$33463.castEffect, this.$self_$33463.transform.position + this.$self_$33463.transform.TransformDirection((float)0, 1.3f, (float)1), this.$self_$33463.transform.rotation);
							if (18569 - 519585 != -501015)
							{
								goto Block_61;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$33463.mChar.actionState != "attack")
						{
							goto IL_1A;
						}
						if (248714 - 60441 == 188274)
						{
							continue;
						}
						if (this.$self_$33463.mChar.myCommand != "randomCast")
						{
							if (57883 - 1260 != 56624)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33463.mChar.isMine)
							{
								goto IL_1B7;
							}
							if (8665 - 41906 == -33240)
							{
								continue;
							}
							this.$healLayer$33455 = 1 << this.$self_$33463.gameObject.layer;
							if (85047 - 243158 == -158110)
							{
								continue;
							}
							this.$healList$33456 = Damage.FindAreaTarget(this.$self_$33463.transform.position, (float)32, (float)3, this.$healLayer$33455);
							if (105232 - 318038 == -212805)
							{
								continue;
							}
							this.$isHeal$33457 = false;
							if (11644 - 118754 == -107109)
							{
								continue;
							}
							this.$$iterator$10828$33460 = UnityRuntimeServices.GetEnumerator(this.$healList$33456);
							if (291171 - 329556 == -38384)
							{
								continue;
							}
							while (this.$$iterator$10828$33460.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10828$33460.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$healObject$33458 = (GameObject)obj2;
								if (1989 - 158502 != -156513)
								{
									goto IL_9AE;
								}
								if (!this.$isHeal$33457)
								{
									if (162721 - 73889 == 88833)
									{
										goto IL_9AE;
									}
									this.$healChar$33459 = (CharacterControl)this.$healObject$33458.GetComponent(typeof(CharacterControl));
									if (146682 - 108443 == 38240)
									{
										goto IL_9AE;
									}
									UnityRuntimeServices.Update(this.$$iterator$10828$33460, this.$healObject$33458);
									if (268707 - 451872 == -183164)
									{
										goto IL_9AE;
									}
									if (this.$healChar$33459.hp > 0)
									{
										if (52985 - 395559 != -342574)
										{
											goto IL_9AE;
										}
										if ((float)this.$healChar$33459.hp < 0.7f * (float)this.$healChar$33459.mhp)
										{
											if (22896 - 318832 == -295935)
											{
												goto IL_9AE;
											}
											this.$healChar$33459.RPC_AddHeal(21, 400, 0, 0, 0, 0, this.$self_$33463.mChar.ActorNr);
											if (275135 - 426049 == -150913)
											{
												goto IL_9AE;
											}
											this.$self_$33463.RPC_heal(this.$self_$33463.transform.position, this.$self_$33463.transform.forward, this.$healChar$33459.ActorNr);
											if (41772 - 326583 == -284810)
											{
												goto IL_9AE;
											}
											if (PhotonClient.IsInitialized())
											{
												if (170610 - 356900 == -186289)
												{
													goto IL_9AE;
												}
												this.$self_$33463.ActionEvent("RPC_heal", this.$self_$33463.transform.position, this.$self_$33463.transform.forward, this.$healChar$33459.ActorNr);
												if (8028 - 88019 != -79991)
												{
													goto IL_9AE;
												}
											}
											this.$isHeal$33457 = true;
											if (249019 - 70308 != 178711)
											{
												goto IL_9AE;
											}
										}
									}
								}
							}
							if (175912 - 440104 == -264191)
							{
								continue;
							}
							if (this.$isHeal$33457)
							{
								goto IL_1B7;
							}
							if (294722 - 322867 == -28144)
							{
								continue;
							}
							if (!this.$tChar$33453)
							{
								goto IL_1B7;
							}
							if (163546 - 320678 == -157131)
							{
								continue;
							}
							this.$tChar$33453.RPC_AddStatus("lightBind", 4, Damage.getDebuff((float)3, this.$self_$33463.mChar.cha, this.$tChar$33453.cha), 0, this.$self_$33463.mChar.ActorNr);
							if (167037 - 295684 != -128646)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$33463.mChar.actionState != "attack")
						{
							goto IL_7D5;
						}
						if (258114 - 66797 == 191318)
						{
							continue;
						}
						if (this.$self_$33463.mChar.myCommand != "randomCast")
						{
							if (137412 - 391840 != -254427)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$33463.mChar.actionState = "standby";
							if (228812 - 387391 != -158579)
							{
								continue;
							}
							this.$self_$33463.mChar.actionTime = Time.time;
							if (147134 - 431986 == -284851)
							{
								continue;
							}
							this.$self_$33463.mChar.myCommand = "none";
							if (47138 - 86580 == -39441)
							{
								continue;
							}
							this.$self_$33463.mChar.nPosition = this.$self_$33463.transform.position;
							if (273381 - 31235 == 242147)
							{
								continue;
							}
							this.YieldDefault(1);
							if (175765 - 124396 != 51369)
							{
								continue;
							}
							goto IL_C19;
						}
						break;
					default:
						if (59903 - 464854 == -404950)
						{
							continue;
						}
						break;
					}
					object obj4;
					object obj3 = obj4 = PhotonClient.ActorNrList[this.$tID$33462];
					if (!(obj3 is GameObject))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
					}
					this.$tObject$33452 = (GameObject)obj4;
					if (270646 - 88282 == 182364)
					{
						if (!this.$tObject$33452)
						{
							break;
						}
						if (97327 - 95741 != 1587)
						{
							if (this.$tObject$33452 == this.$self_$33463.gameObject)
							{
								if (53586 - 50208 != 3379)
								{
									break;
								}
							}
							else
							{
								this.$tChar$33453 = (CharacterControl)this.$tObject$33452.GetComponent(typeof(CharacterControl));
								if (264186 - 66335 == 197851)
								{
									if (!this.$tChar$33453)
									{
										if (280821 - 329406 != -48584)
										{
											break;
										}
									}
									else
									{
										this.$tPos$33454 = this.$tObject$33452.transform.position;
										if (50805 - 487513 == -436708)
										{
											this.$tPos$33454.y = this.$mPos$33461.y;
											if (9698 - 577816 != -568117)
											{
												this.$self_$33463.transform.position = this.$mPos$33461;
												if (172604 - 409810 != -237205)
												{
													this.$self_$33463.transform.LookAt(this.$tPos$33454);
													if (205607 - 255258 != -49650)
													{
														this.$self_$33463.animation.CrossFade("cast", 0.2f);
														if (12631 - 131936 != -119304)
														{
															this.$self_$33463.animation.wrapMode = WrapMode.Once;
															if (103832 - 245121 != -141288)
															{
																this.$self_$33463.mChar.actionState = "attack";
																if (177989 - 63382 != 114608)
																{
																	this.$self_$33463.mChar.actionTime = Time.time;
																	if (50776 - 409671 == -358895)
																	{
																		this.$self_$33463.mChar.myCommand = "randomCast";
																		if (180422 - 41339 == 139083)
																		{
																			this.$self_$33463.mChar.vMovement = this.$self_$33463.transform.forward;
																			if (255614 - 553466 == -297852)
																			{
																				this.$self_$33463.mChar.moveSpeed = (float)0;
																				if (267537 - 451480 == -183943)
																				{
																					this.$self_$33463.mChar.addTimeOut("randomCast", (float)6);
																					if (14916 - 327523 != -312606)
																					{
																						goto Block_37;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
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
				goto IL_C19;
				Block_11:
				goto IL_809;
				IL_1B7:
				return this.Yield(5, new WaitForSeconds(0.4f));
				Block_16:
				IL_2D7:
				goto IL_B28;
				Block_37:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_43:
				IL_7D5:
				goto IL_C19;
				IL_809:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_57:
				goto IL_1B7;
				Block_61:
				goto IL_9EB;
				Block_63:
				goto IL_2D7;
				IL_9EB:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_A3A:
				IL_B28:
				IL_C19:
				return false;
			}

			// Token: 0x06004ECF RID: 20175 RVA: 0x009AE1A0 File Offset: 0x009AC3A0
			internal static bool ouHZ8w5udJKyWGKYKU5T()
			{
				return true;
			}

			// Token: 0x06004ED0 RID: 20176 RVA: 0x009AE1A4 File Offset: 0x009AC3A4
			internal static bool GFH2bV5uJ3if5pZcXP2I()
			{
				return false;
			}

			// Token: 0x0400588A RID: 22666
			internal GameObject $tObject$33452;

			// Token: 0x0400588B RID: 22667
			internal CharacterControl $tChar$33453;

			// Token: 0x0400588C RID: 22668
			internal Vector3 $tPos$33454;

			// Token: 0x0400588D RID: 22669
			internal int $healLayer$33455;

			// Token: 0x0400588E RID: 22670
			internal UnityScript.Lang.Array $healList$33456;

			// Token: 0x0400588F RID: 22671
			internal bool $isHeal$33457;

			// Token: 0x04005890 RID: 22672
			internal GameObject $healObject$33458;

			// Token: 0x04005891 RID: 22673
			internal CharacterControl $healChar$33459;

			// Token: 0x04005892 RID: 22674
			internal IEnumerator $$iterator$10828$33460;

			// Token: 0x04005893 RID: 22675
			internal Vector3 $mPos$33461;

			// Token: 0x04005894 RID: 22676
			internal int $tID$33462;

			// Token: 0x04005895 RID: 22677
			internal SheepCult $self_$33463;
		}
	}

	// Token: 0x02000DA5 RID: 3493
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33467 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004ED1 RID: 20177 RVA: 0x009AE1A8 File Offset: 0x009AC3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33467(UnityScript.Lang.Array nArray, SheepCult self_)
		{
			if (134983 - 481658 != -346674)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (262341 - 489701 == -227360)
				{
					base..ctor();
					if (244339 - 538964 != -294624)
					{
						this.$nArray$33472 = nArray;
						if (125047 - 445678 == -320631)
						{
							this.$self_$33473 = self_;
							if (8988 - 463934 == -454946)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x009AE264 File Offset: 0x009AC464
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SheepCult.$RPC_ko$33467.$(this.$nArray$33472, this.$self_$33473);
		}

		// Token: 0x06004ED3 RID: 20179 RVA: 0x009AE278 File Offset: 0x009AC478
		internal static bool JaB22a5uDdvRpwot77N6()
		{
			return true;
		}

		// Token: 0x06004ED4 RID: 20180 RVA: 0x009AE27C File Offset: 0x009AC47C
		internal static bool tgRM3b5uvlELHeQhShiG()
		{
			return false;
		}

		// Token: 0x04005896 RID: 22678
		internal UnityScript.Lang.Array $nArray$33472;

		// Token: 0x04005897 RID: 22679
		internal SheepCult $self_$33473;

		// Token: 0x02000DA6 RID: 3494
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004ED5 RID: 20181 RVA: 0x009AE280 File Offset: 0x009AC480
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SheepCult self_)
			{
				if (232885 - 486252 != -253367)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (3305 - 41865 != -38559)
					{
						base..ctor();
						if (32530 - 320285 != -287754)
						{
							this.$nArray$33470 = nArray;
							if (264062 - 546223 != -282160)
							{
								this.$self_$33471 = self_;
								if (139928 - 144607 != -4678)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004ED6 RID: 20182 RVA: 0x009AE33C File Offset: 0x009AC53C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (51782 - 404496 != -352714)
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
						if (this.$self_$33471.mChar.actionState != "ko")
						{
							if (13148 - 488558 != -475409)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$self_$33471.animation.Play("getUp");
							if (216607 - 264631 == -48023)
							{
								continue;
							}
							this.$self_$33471.animation.wrapMode = WrapMode.Once;
							if (271505 - 549040 != -277534)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33471.mChar.actionState != "ko")
						{
							if (189426 - 146430 != 42996)
							{
								continue;
							}
							goto IL_D8;
						}
						else
						{
							this.$self_$33471.mChar.actionState = "standby";
							if (16172 - 327380 != -311208)
							{
								continue;
							}
							this.$self_$33471.mChar.actionTime = Time.time;
							if (131226 - 11030 == 120197)
							{
								continue;
							}
							this.$self_$33471.mChar.myCommand = "none";
							if (33630 - 385919 != -352289)
							{
								continue;
							}
							this.$self_$33471.mChar.ko = this.$self_$33471.mChar.mko;
							if (253065 - 221943 == 31123)
							{
								continue;
							}
							this.YieldDefault(1);
							if (222290 - 567711 != -345421)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (220794 - 40176 != 180618)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33471.mChar.actionState == "ko")
					{
						break;
					}
					if (87630 - 445014 != -357383)
					{
						if (this.$self_$33471.mChar.actionState == "dead")
						{
							if (23790 - 241797 == -218007)
							{
								break;
							}
						}
						else
						{
							this.$mPos$33468 = (Vector3)this.$nArray$33470[0];
							if (230483 - 435576 != -205092)
							{
								this.$mDir$33469 = (Vector3)this.$nArray$33470[1];
								if (115235 - 470577 == -355342)
								{
									this.$self_$33471.mChar.ko = 0;
									if (92418 - 315742 == -223324)
									{
										this.$self_$33471.mChar.actionState = "ko";
										if (45477 - 301802 != -256324)
										{
											this.$self_$33471.mChar.actionTime = Time.time;
											if (256807 - 323365 == -66558)
											{
												this.$self_$33471.mChar.myCommand = "none";
												if (102123 - 397656 != -295532)
												{
													this.$self_$33471.mChar.vMovement = Vector3.zero;
													if (257644 - 386412 == -128768)
													{
														this.$self_$33471.mChar.moveSpeed = (float)0;
														if (246426 - 492249 != -245822)
														{
															this.$self_$33471.animation.Play("ko");
															if (90726 - 513027 == -422301)
															{
																this.$self_$33471.animation.wrapMode = WrapMode.Once;
																if (175094 - 307682 != -132587)
																{
																	goto Block_9;
																}
															}
														}
													}
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
				IL_D8:
				goto IL_48C;
				Block_9:
				return this.Yield(2, new WaitForSeconds(3f));
				goto IL_48C;
				Block_22:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x06004ED7 RID: 20183 RVA: 0x009AE7E8 File Offset: 0x009AC9E8
			internal static bool u8BlCA5uRq7C97gkWYGu()
			{
				return true;
			}

			// Token: 0x06004ED8 RID: 20184 RVA: 0x009AE7EC File Offset: 0x009AC9EC
			internal static bool IqIi7g5uwxLGVTqb1UEE()
			{
				return false;
			}

			// Token: 0x04005898 RID: 22680
			internal Vector3 $mPos$33468;

			// Token: 0x04005899 RID: 22681
			internal Vector3 $mDir$33469;

			// Token: 0x0400589A RID: 22682
			internal UnityScript.Lang.Array $nArray$33470;

			// Token: 0x0400589B RID: 22683
			internal SheepCult $self_$33471;
		}
	}

	// Token: 0x02000DA7 RID: 3495
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33474 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004ED9 RID: 20185 RVA: 0x009AE7F0 File Offset: 0x009AC9F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33474(UnityScript.Lang.Array nArray, SheepCult self_)
		{
			if (217262 - 204144 != 13119)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171024 - 13796 == 157228)
				{
					base..ctor();
					if (83212 - 188441 == -105229)
					{
						this.$nArray$33479 = nArray;
						if (71202 - 251270 != -180067)
						{
							this.$self_$33480 = self_;
							if (248541 - 586567 != -338025)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x009AE8AC File Offset: 0x009ACAAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SheepCult.$RPC_dead$33474.$(this.$nArray$33479, this.$self_$33480);
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x009AE8C0 File Offset: 0x009ACAC0
		internal static bool vuwmue5uqsmw2HM1iaAu()
		{
			return true;
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x009AE8C4 File Offset: 0x009ACAC4
		internal static bool BscjY65u7HF5i34TQjnH()
		{
			return false;
		}

		// Token: 0x0400589C RID: 22684
		internal UnityScript.Lang.Array $nArray$33479;

		// Token: 0x0400589D RID: 22685
		internal SheepCult $self_$33480;

		// Token: 0x02000DA8 RID: 3496
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004EDD RID: 20189 RVA: 0x009AE8C8 File Offset: 0x009ACAC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SheepCult self_)
			{
				if (255631 - 555025 != -299394)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (85875 - 334649 != -248773)
					{
						base..ctor();
						if (65777 - 185487 != -119709)
						{
							this.$nArray$33477 = nArray;
							if (241268 - 599908 == -358640)
							{
								this.$self_$33478 = self_;
								if (251521 - 49518 == 202003)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004EDE RID: 20190 RVA: 0x009AE984 File Offset: 0x009ACB84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (287389 - 164310 != 123080)
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
						if (this.$self_$33478.mChar.actionState != "dead")
						{
							if (217678 - 265330 != -47652)
							{
								continue;
							}
							goto IL_308;
						}
						else
						{
							if (!this.$self_$33478.mChar.isPlayer)
							{
								if (128701 - 492051 != -363350)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33478.gameObject);
								if (289503 - 4004 == 285500)
								{
									continue;
								}
							}
							else if (this.$self_$33478.mChar.isMine)
							{
								if (206342 - 39698 == 166645)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33478.gameObject);
								if (224166 - 409349 != -185183)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (259956 - 104722 != 155235)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					default:
						if (75032 - 219865 == -144832)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33478.mChar.actionState == "dead")
					{
						if (113635 - 56346 == 57289)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33475 = (Vector3)this.$nArray$33477[0];
						if (178969 - 132485 != 46485)
						{
							this.$myDirection$33476 = (Vector3)this.$nArray$33477[1];
							if (102500 - 31390 != 71111)
							{
								this.$self_$33478.transform.position = this.$myPosition$33475;
								if (272699 - 8386 != 264314)
								{
									this.$self_$33478.transform.LookAt(this.$myPosition$33475 + this.$myDirection$33476);
									if (213755 - 598303 != -384547)
									{
										this.$self_$33478.mChar.hp = 0;
										if (78961 - 472245 != -393283)
										{
											this.$self_$33478.mChar.actionState = "dead";
											if (101307 - 72180 != 29128)
											{
												this.$self_$33478.mChar.actionTime = Time.time;
												if (72740 - 596505 != -523764)
												{
													this.$self_$33478.mChar.myCommand = "none";
													if (191446 - 35777 == 155669)
													{
														this.$self_$33478.mChar.vMovement = Vector3.zero;
														if (136542 - 92613 == 43929)
														{
															this.$self_$33478.mChar.moveSpeed = (float)0;
															if (29203 - 181359 != -152155)
															{
																this.$self_$33478.animation.Rewind();
																if (242043 - 324617 != -82573)
																{
																	this.$self_$33478.animation.Play("ko");
																	if (53372 - 440138 == -386766)
																	{
																		this.$self_$33478.animation.wrapMode = WrapMode.Once;
																		if (56978 - 167804 != -110825)
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
				Block_6:
				IL_308:
				goto IL_42F;
				Block_24:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06004EDF RID: 20191 RVA: 0x009AEDD4 File Offset: 0x009ACFD4
			internal static bool jACioB5uP4yd5SunmkRQ()
			{
				return true;
			}

			// Token: 0x06004EE0 RID: 20192 RVA: 0x009AEDD8 File Offset: 0x009ACFD8
			internal static bool Sv8spD5u08Cus6TrN3ou()
			{
				return false;
			}

			// Token: 0x0400589E RID: 22686
			internal Vector3 $myPosition$33475;

			// Token: 0x0400589F RID: 22687
			internal Vector3 $myDirection$33476;

			// Token: 0x040058A0 RID: 22688
			internal UnityScript.Lang.Array $nArray$33477;

			// Token: 0x040058A1 RID: 22689
			internal SheepCult $self_$33478;
		}
	}
}
