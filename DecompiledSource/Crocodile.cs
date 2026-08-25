using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BB7 RID: 2999
[Serializable]
public class Crocodile : MonoBehaviour
{
	// Token: 0x060042E1 RID: 17121 RVA: 0x0086EB20 File Offset: 0x0086CD20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Crocodile()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060042E2 RID: 17122 RVA: 0x0086EB30 File Offset: 0x0086CD30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (56295 - 222426 != -166130)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (202509 - 493416 != -290906)
			{
				this.mChar.actionState = "standby";
				if (145031 - 376006 == -230975)
				{
					this.mChar.actionTime = Time.time;
					if (237402 - 386919 != -149516)
					{
						this.mChar.myCommand = "none";
						if (259818 - 440741 != -180922)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060042E3 RID: 17123 RVA: 0x0086EC1C File Offset: 0x0086CE1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060042E4 RID: 17124 RVA: 0x0086EC38 File Offset: 0x0086CE38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (33934 - 414366 != -380432)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (94252 - 535127 != -440875)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (186790 - 384146 == -197355)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_35A;
					}
					if (292063 - 183800 != 108263)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (42999 - 37223 != 5776)
				{
					continue;
				}
			}
			IL_35A:
			if (this.mChar.hp <= 0)
			{
				if (267860 - 177368 == 90493)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (241128 - 446948 == -205819)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (114932 - 421939 != -307007)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (96763 - 402978 != -306215)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (28916 - 507655 == -478738)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (224608 - 453200 != -228592)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (51747 - 452929 != -401182)
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
			if (7331 - 248372 == -241041)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (167043 - 312163 != -145119)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (144222 - 406643 != -262420)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (93803 - 385637 == -291834)
						{
							if (this.mChar.isMine)
							{
								if (291912 - 576200 != -284287)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (33433 - 106492 != -73058)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (181356 - 437935 != -256578)
										{
											this.mChar.KoEvent();
											if (54036 - 437486 == -383450)
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
								if (46740 - 552606 == -505866)
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

	// Token: 0x060042E5 RID: 17125 RVA: 0x0086F030 File Offset: 0x0086D230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (41067 - 215565 != -174497)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (156687 - 594876 != -438188)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (41375 - 264 != 41112 && 85128 - 72408 != 12721)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (241184 - 377348 != -136164)
						{
							continue;
						}
						v = 1;
						if (128001 - 518329 != -390328)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (48820 - 351879 == -303058)
						{
							continue;
						}
						v = -1;
						if (295708 - 366921 == -71212)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (110813 - 52894 == 57920)
						{
							continue;
						}
						v = 11;
						if (31910 - 135478 != -103568)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack_hit")
					{
						if (289286 - 136618 != 152668)
						{
							continue;
						}
						v = -11;
						if (77391 - 245473 == -168081)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (263602 - 563116 == -299513)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (102735 - 114638 != -11902)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (18100 - 4597 == 13503)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (239497 - 192595 != 46903)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (211138 - 301634 == -90496)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (126707 - 314888 == -188181)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (58304 - 375478 == -317174)
										{
											Hashtable hashtable = new Hashtable();
											if (280247 - 513861 == -233614)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (284754 - 136933 == 147821)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (237390 - 496129 != -258738)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (7229 - 206510 == -199281)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (87602 - 52455 == 35147)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (282039 - 420577 == -138538)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (133165 - 538414 == -405249)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (59460 - 190488 == -131028)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (156850 - 215890 != -59039)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (118458 - 87641 != 30818)
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

	// Token: 0x060042E6 RID: 17126 RVA: 0x0086F548 File Offset: 0x0086D748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (131224 - 190597 != -59373)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (119935 - 515066 != -395130)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (289476 - 194135 != 95342)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (127508 - 418474 == -290966)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (37496 - 15474 != 22023)
						{
							int num3 = num;
							if (158613 - 227550 == -68937)
							{
								if (num3 == 1)
								{
									if (57611 - 288046 == -230435)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (78780 - 134965 == -56185)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (298638 - 270778 != 27861)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (286633 - 448938 == -162305)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (60136 - 18451 == 41685)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (247234 - 247745 == -511)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (82926 - 218605 == -135679)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (288383 - 401337 == -112954)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (223251 - 589729 == -366478)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (230239 - 273629 == -43390)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (70971 - 142162 != -71190)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (103262 - 537735 == -434473)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (197676 - 1031 == 196645)
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

	// Token: 0x060042E7 RID: 17127 RVA: 0x0086F8CC File Offset: 0x0086DACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (101814 - 334223 != -232408)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (114040 - 136090 == -22050)
			{
				float runSpeed = this.mChar.runSpeed;
				if (209959 - 192148 != 17812)
				{
					Vector3 a = default(Vector3);
					if (299019 - 74805 == 224214)
					{
						Vector3 vector = Vector3.zero;
						if (193170 - 55349 == 137821)
						{
							float num2 = (float)0;
							if (33420 - 36925 != -3504)
							{
								if (this.mChar.isMine)
								{
									if (222580 - 314317 != -91737)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (156282 - 159449 != -3167)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (43810 - 157265 == -113454)
										{
											continue;
										}
										a.y = (float)0;
										if (233795 - 581039 == -347243)
										{
											continue;
										}
										a = a.normalized;
										if (31107 - 505633 == -474525)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (111542 - 58016 == 53527)
										{
											continue;
										}
										vector = vector.normalized;
										if (46300 - 34639 == 11662)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (274747 - 522798 == -248050)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (188950 - 504236 != -315286)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (97468 - 48295 == 49174)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (42066 - 45823 != -3757)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (111329 - 189031 != -77702)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (106997 - 17757 == 89241)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (119063 - 190100 == -71036)
														{
															continue;
														}
														this.animation.Play("run");
														if (214993 - 67068 != 147925)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (18785 - 52441 != -33656)
														{
															continue;
														}
														goto IL_260;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (261695 - 569699 != -308004)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (119035 - 139138 == -20102)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (46581 - 520895 == -474313)
											{
												continue;
											}
											num = (float)0;
											if (108504 - 311271 == -202766)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (104223 - 445140 != -340917)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (196045 - 298792 == -102746)
										{
											continue;
										}
									}
									IL_260:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (33256 - 553643 != -520387)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (153585 - 357957 == -204371)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (93568 - 426608 != -333040)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (272326 - 235229 != 37097)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (58837 - 485892 != -427055)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (269826 - 298211 == -28384)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (139865 - 350199 == -210333)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (174190 - 121203 == 52988)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (162060 - 143389 != 18671)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (123167 - 426903 != -303736)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (180609 - 75358 != 105251)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (16034 - 231855 != -215821)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (244443 - 400459 == -156015)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (2143 - 255758 != -253615)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (116565 - 458964 == -342398)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (263702 - 155276 == 108427)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (21817 - 461768 == -439950)
												{
													continue;
												}
												num = (float)0;
												if (23732 - 580836 != -557104)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (27967 - 3127 == 24841)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (6233 - 596976 == -590742)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (36239 - 352951 == -316711)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (3907 - 281536 != -277629)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (289716 - 207491 == 82226)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (130330 - 197056 != -66726)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (187214 - 170537 == 16678)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (179577 - 23557 != 156020)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (201569 - 517048 == -315478)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (222476 - 68911 != 153565)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (166035 - 572484 == -406448)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (212680 - 153504 != 59176)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (275072 - 432794 != -157722)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (238093 - 568077 == -329983)
											{
												continue;
											}
											num = (float)0;
											if (140185 - 522490 == -382304)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (56098 - 393592 == -337493)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (25234 - 478273 == -453038)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (98248 - 8979 == 89270)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (212090 - 193341 == 18750)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (76201 - 101434 == -25233)
								{
									this.mChar.moveSpeed = num;
									if (46214 - 192866 == -146652)
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

	// Token: 0x060042E8 RID: 17128 RVA: 0x00870430 File Offset: 0x0086E630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (104843 - 110209 != -5366)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (214418 - 200950 == 13468)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (200886 - 523731 != -322844)
				{
					Vector3 vector = a - this.transform.position;
					if (92779 - 318100 != -225320)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (25473 - 12008 == 13465)
						{
							CharacterControl characterControl = null;
							if (50744 - 507823 != -457078 && 230784 - 313892 != -83107)
							{
								if (gameObject)
								{
									if (186815 - 93153 == 93663)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (234579 - 10510 != 224069)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (110485 - 571196 != -460711)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (68001 - 215471 == -147469)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (106947 - 208591 == -101643)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (151709 - 456719 == -305009)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (162764 - 390444 != -227679)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
									if (89780 - 536889 == -447109)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (210375 - 57549 == 152826)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (247808 - 176057 != 71752)
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

	// Token: 0x060042E9 RID: 17129 RVA: 0x00870728 File Offset: 0x0086E928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (124901 - 549668 != -424766)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (269195 - 89611 != 179585)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (56516 - 227931 == -171415)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (37719 - 459098 == -421379)
					{
						Vector3 normalized = vector.normalized;
						if (223190 - 527261 == -304071)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (231962 - 524838 != -292875)
							{
								CharacterControl characterControl = null;
								if (102540 - 47654 == 54886)
								{
									if (228243 - 353625 == -125382)
									{
										if (gameObject)
										{
											if (249552 - 119565 == 129988)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (73998 - 262856 != -188858)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (45214 - 113354 == -68139)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (7447 - 319165 == -311717)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (73275 - 561488 == -488212)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (116674 - 243733 == -127058)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (97449 - 415805 != -318355)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
											if (224415 - 405998 != -181582)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (6162 - 437698 != -431535)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
													if (141563 - 254197 == -112634)
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

	// Token: 0x060042EA RID: 17130 RVA: 0x00870A48 File Offset: 0x0086EC48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060042EB RID: 17131 RVA: 0x00870A4C File Offset: 0x0086EC4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Crocodile.$RPC_nAttack$31488(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060042EC RID: 17132 RVA: 0x00870A5C File Offset: 0x0086EC5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x060042ED RID: 17133 RVA: 0x00870A84 File Offset: 0x0086EC84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Crocodile.$RPC_cAttack$31503(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060042EE RID: 17134 RVA: 0x00870A94 File Offset: 0x0086EC94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.cAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x060042EF RID: 17135 RVA: 0x00870ABC File Offset: 0x0086ECBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Crocodile.$RPC_ko$31515(nArray, this).GetEnumerator();
	}

	// Token: 0x060042F0 RID: 17136 RVA: 0x00870ACC File Offset: 0x0086ECCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Crocodile.$RPC_dead$31522(nArray, this).GetEnumerator();
	}

	// Token: 0x060042F1 RID: 17137 RVA: 0x00870ADC File Offset: 0x0086ECDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060042F2 RID: 17138 RVA: 0x00870AE0 File Offset: 0x0086ECE0
	internal static bool y9Ahh75fqZo4osL38e6r()
	{
		return true;
	}

	// Token: 0x060042F3 RID: 17139 RVA: 0x00870AE4 File Offset: 0x0086ECE4
	internal static bool PQu9FI5f7MCPHpqJZwNI()
	{
		return false;
	}

	// Token: 0x04004EBC RID: 20156
	public CharacterControl mChar;

	// Token: 0x04004EBD RID: 20157
	public AudioClip nAttack_vc;

	// Token: 0x04004EBE RID: 20158
	public GameObject nAttack_hit;

	// Token: 0x04004EBF RID: 20159
	public GameObject cAttack_ring;

	// Token: 0x04004EC0 RID: 20160
	public AudioClip cAttack_vc;

	// Token: 0x04004EC1 RID: 20161
	public GameObject cAttack_hit;

	// Token: 0x04004EC2 RID: 20162
	public AudioClip ko_vc;

	// Token: 0x04004EC3 RID: 20163
	public AudioClip dead_vc;

	// Token: 0x02000BB8 RID: 3000
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$31488 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060042F4 RID: 17140 RVA: 0x00870AE8 File Offset: 0x0086ECE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$31488(Vector3 mPos, Vector3 tDir, Crocodile self_)
		{
			if (44383 - 313747 != -269364)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (143872 - 381949 != -238076)
				{
					base..ctor();
					if (118148 - 123347 == -5199)
					{
						this.$mPos$31500 = mPos;
						if (152448 - 279460 != -127011)
						{
							this.$tDir$31501 = tDir;
							if (271505 - 492974 != -221468)
							{
								this.$self_$31502 = self_;
								if (288368 - 251340 != 37029)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00870BC4 File Offset: 0x0086EDC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Crocodile.$RPC_nAttack$31488.$(this.$mPos$31500, this.$tDir$31501, this.$self_$31502);
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00870BE0 File Offset: 0x0086EDE0
		internal static bool Jm8Vkk5fPppspwNp104r()
		{
			return true;
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x00870BE4 File Offset: 0x0086EDE4
		internal static bool o7jW0d5f07dgddNSuj69()
		{
			return false;
		}

		// Token: 0x04004EC4 RID: 20164
		internal Vector3 $mPos$31500;

		// Token: 0x04004EC5 RID: 20165
		internal Vector3 $tDir$31501;

		// Token: 0x04004EC6 RID: 20166
		internal Crocodile $self_$31502;

		// Token: 0x02000BB9 RID: 3001
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060042F8 RID: 17144 RVA: 0x00870BE8 File Offset: 0x0086EDE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Crocodile self_)
			{
				if (110555 - 307611 != -197056)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (133933 - 346894 != -212960)
					{
						base..ctor();
						if (68517 - 57618 == 10899)
						{
							this.$mPos$31497 = mPos;
							if (223241 - 138297 == 84944)
							{
								this.$tDir$31498 = tDir;
								if (44756 - 242325 == -197569)
								{
									this.$self_$31499 = self_;
									if (101159 - 586611 != -485451)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060042F9 RID: 17145 RVA: 0x00870CC4 File Offset: 0x0086EEC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (71350 - 222240 != -150889)
				{
				}
				for (;;)
				{
					IL_4ED:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D75;
					case 2:
						if (this.$self_$31499.mChar.actionState != "attack")
						{
							goto IL_13F;
						}
						if (189980 - 427385 == -237404)
						{
							continue;
						}
						if (this.$self_$31499.mChar.myCommand != "nAttack")
						{
							if (138137 - 131809 != 6328)
							{
								continue;
							}
							goto IL_13F;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_5E8;
							}
							if (8162 - 280876 == -272713)
							{
								continue;
							}
							if (this.$self_$31499.nAttack_vc)
							{
								if (279481 - 188369 != 91112)
								{
									continue;
								}
								this.$self_$31499.audio.PlayOneShot(this.$self_$31499.nAttack_vc);
								if (268448 - 541042 != -272594)
								{
									continue;
								}
								goto IL_CFC;
							}
							else
							{
								Debug.LogError("Cannot find nAttack voice");
								if (111546 - 76808 != 34739)
								{
									goto Block_83;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31499.mChar.actionState != "attack")
						{
							goto IL_208;
						}
						if (215945 - 364479 == -148533)
						{
							continue;
						}
						if (this.$self_$31499.mChar.myCommand != "nAttack")
						{
							if (252942 - 153269 != 99673)
							{
								continue;
							}
							goto IL_208;
						}
						else
						{
							this.$hitLayer$31490 = 130816 - (1 << this.$self_$31499.gameObject.layer);
							if (218395 - 407531 != -189136)
							{
								continue;
							}
							this.$hitList$31491 = null;
							if (237059 - 357293 != -120234)
							{
								continue;
							}
							this.$hitPos$31492 = default(Vector3);
							if (78493 - 516768 == -438274)
							{
								continue;
							}
							if (!this.$self_$31499.mChar.isMine)
							{
								goto IL_3A6;
							}
							if (99311 - 485960 != -386649)
							{
								continue;
							}
							this.$hitList$31491 = Damage.FindAreaTarget(this.$self_$31499.transform.position + this.$self_$31499.transform.forward, (float)2, (float)3, this.$hitLayer$31490);
							if (163198 - 95893 != 67305)
							{
								continue;
							}
							this.$$iterator$10698$31494 = UnityRuntimeServices.GetEnumerator(this.$hitList$31491);
							if (169922 - 1887 == 168036)
							{
								continue;
							}
							while (this.$$iterator$10698$31494.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10698$31494.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31493 = (GameObject)obj2;
								if (183659 - 30401 == 153259)
								{
									goto IL_4ED;
								}
								if (this.$self_$31499.mChar.hit(1, this.$hitObject$31493, this.$self_$31499.mChar.atk, 3, 0, this.$self_$31499.transform.forward) != 0)
								{
									if (41984 - 278995 == -237010)
									{
										goto IL_4ED;
									}
									this.$hitPos$31492 = this.$hitObject$31493.collider.ClosestPointOnBounds(this.$self_$31499.transform.position + 1.5f * Vector3.up);
									if (234086 - 283335 != -49249)
									{
										goto IL_4ED;
									}
									UnityRuntimeServices.Update(this.$$iterator$10698$31494, this.$hitObject$31493);
									if (284971 - 141611 == 143361)
									{
										goto IL_4ED;
									}
									this.$self_$31499.RPC_nAttack_hit(this.$hitPos$31492, this.$self_$31499.transform.forward, 0);
									if (278704 - 282051 == -3346)
									{
										goto IL_4ED;
									}
									this.$self_$31499.ActionEvent("RPC_nAttack_hit", this.$hitPos$31492, this.$self_$31499.transform.forward, 0);
									if (50089 - 207541 == -157451)
									{
										goto IL_4ED;
									}
								}
							}
							if (122546 - 413924 != -291378)
							{
								continue;
							}
							goto IL_3A6;
						}
						break;
					case 4:
						if (this.$self_$31499.mChar.actionState != "attack")
						{
							goto IL_3F5;
						}
						if (262722 - 67643 != 195079)
						{
							continue;
						}
						if (this.$self_$31499.mChar.myCommand != "nAttack")
						{
							if (147540 - 59750 != 87791)
							{
								goto Block_70;
							}
							continue;
						}
						else
						{
							if (!this.$self_$31499.mChar.isMine)
							{
								goto IL_6E;
							}
							if (184665 - 499384 != -314719)
							{
								continue;
							}
							this.$hitList$31491 = Damage.FindAreaTarget(this.$self_$31499.transform.position + this.$self_$31499.transform.forward, (float)3, (float)3, this.$hitLayer$31490);
							if (71105 - 14957 == 56149)
							{
								continue;
							}
							this.$$iterator$10699$31496 = UnityRuntimeServices.GetEnumerator(this.$hitList$31491);
							if (158311 - 493989 == -335677)
							{
								continue;
							}
							while (this.$$iterator$10699$31496.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10699$31496.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$31495 = (GameObject)obj4;
								if (25764 - 111237 != -85473)
								{
									goto IL_4ED;
								}
								if (this.$self_$31499.mChar.hit(1, this.$hitObject$31495, this.$self_$31499.mChar.atk, 3, 0, this.$self_$31499.transform.forward) != 0)
								{
									if (4122 - 576107 != -571985)
									{
										goto IL_4ED;
									}
									this.$hitPos$31492 = this.$hitObject$31495.collider.ClosestPointOnBounds(this.$self_$31499.transform.position + 1.5f * Vector3.up);
									if (126598 - 174946 == -48347)
									{
										goto IL_4ED;
									}
									UnityRuntimeServices.Update(this.$$iterator$10699$31496, this.$hitObject$31495);
									if (146897 - 108718 != 38179)
									{
										goto IL_4ED;
									}
									this.$self_$31499.RPC_nAttack_hit(this.$hitPos$31492, this.$self_$31499.transform.forward, 0);
									if (271108 - 177174 == 93935)
									{
										goto IL_4ED;
									}
									this.$self_$31499.ActionEvent("RPC_nAttack_hit", this.$hitPos$31492, this.$self_$31499.transform.forward, 0);
									if (16954 - 106905 == -89950)
									{
										goto IL_4ED;
									}
								}
							}
							if (102527 - 534816 != -432289)
							{
								continue;
							}
							goto IL_6E;
						}
						break;
					case 5:
						if (this.$self_$31499.mChar.actionState == "attack")
						{
							if (233595 - 286366 == -52770)
							{
								continue;
							}
							if (this.$self_$31499.mChar.myCommand == "nAttack")
							{
								if (174029 - 599205 == -425175)
								{
									continue;
								}
								this.$self_$31499.mChar.actionState = "standby";
								if (221866 - 82599 != 139267)
								{
									continue;
								}
								this.$self_$31499.mChar.actionTime = Time.time;
								if (167621 - 395242 != -227621)
								{
									continue;
								}
								this.$self_$31499.mChar.myCommand = "none";
								if (274341 - 108591 == 165751)
								{
									continue;
								}
								if (!this.$self_$31499.mChar.isMine)
								{
									if (210782 - 336939 != -126157)
									{
										continue;
									}
									this.$self_$31499.mChar.nPosition = this.$self_$31499.transform.position;
									if (16161 - 186630 == -170468)
									{
										continue;
									}
									this.$self_$31499.mChar.oPosition = this.$self_$31499.transform.position;
									if (36035 - 167210 != -131175)
									{
										continue;
									}
									this.$self_$31499.mChar.nDirection = this.$self_$31499.transform.forward;
									if (158898 - 356334 == -197435)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (64246 - 35699 != 28548)
						{
							goto Block_55;
						}
						continue;
					default:
						if (200573 - 309073 == -108499)
						{
							continue;
						}
						break;
					}
					this.$self_$31499.mChar.actionState = "attack";
					if (105297 - 479835 != -374537)
					{
						this.$self_$31499.mChar.actionTime = Time.time;
						if (214110 - 139971 == 74139)
						{
							this.$self_$31499.mChar.myCommand = "nAttack";
							if (139976 - 246251 != -106274)
							{
								this.$self_$31499.mChar.addTimeOut("nAttack", (float)6);
								if (249917 - 115289 == 134628)
								{
									this.$self_$31499.transform.position = this.$mPos$31497;
									if (177063 - 210050 == -32987)
									{
										this.$self_$31499.transform.LookAt(this.$mPos$31497 + global::Math.vFlat(this.$tDir$31498));
										if (201152 - 590834 == -389682)
										{
											this.$self_$31499.animation.CrossFade("nAttack");
											if (51979 - 419878 != -367898)
											{
												this.$self_$31499.animation.wrapMode = WrapMode.Once;
												if (275753 - 37770 == 237983)
												{
													this.$self_$31499.mChar.vMovement = this.$self_$31499.transform.forward;
													if (234815 - 208255 == 26560)
													{
														this.$self_$31499.mChar.moveSpeed = (float)0;
														if (290678 - 119441 == 171237)
														{
															if (this.$self_$31499.mChar.isPlayer)
															{
																goto IL_2D7;
															}
															if (144541 - 521449 == -376908)
															{
																if (Game.mGameCode != 914)
																{
																	goto IL_2D7;
																}
																if (229206 - 13809 != 215398)
																{
																	if (UnityEngine.Random.Range(0, 100) >= 30)
																	{
																		goto IL_2D7;
																	}
																	if (173837 - 528357 != -354519)
																	{
																		this.$m$31489 = Language.getMessage("M914_GuildUnderAttack", UnityEngine.Random.Range(11, 20));
																		if (189764 - 335552 == -145788)
																		{
																			if (!(this.$m$31489 != string.Empty))
																			{
																				goto IL_2D7;
																			}
																			if (38187 - 573022 != -534834)
																			{
																				Chat.SubmitChat("Razan", "Razan: " + this.$m$31489, eChatType.npc, eChatMode.system);
																				if (5449 - 347417 != -341967)
																				{
																					this.$self_$31499.mChar.doChatBubble(this.$m$31489);
																					if (104048 - 259004 == -154956)
																					{
																						goto IL_2D7;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_6E:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_13F:
				IL_208:
				goto IL_D75;
				IL_2D7:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_3A6:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_3F5:
				goto IL_D75;
				IL_5E8:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_55:
				Block_70:
				goto IL_3F5;
				IL_CFC:
				Block_83:
				goto IL_5E8;
				IL_D75:
				return false;
			}

			// Token: 0x060042FA RID: 17146 RVA: 0x00871A58 File Offset: 0x0086FC58
			internal static bool qc0hGl5fbcZRPCjiLjaN()
			{
				return true;
			}

			// Token: 0x060042FB RID: 17147 RVA: 0x00871A5C File Offset: 0x0086FC5C
			internal static bool cJovOv5fuicBk6yI8j9O()
			{
				return false;
			}

			// Token: 0x04004EC7 RID: 20167
			internal string $m$31489;

			// Token: 0x04004EC8 RID: 20168
			internal int $hitLayer$31490;

			// Token: 0x04004EC9 RID: 20169
			internal UnityScript.Lang.Array $hitList$31491;

			// Token: 0x04004ECA RID: 20170
			internal Vector3 $hitPos$31492;

			// Token: 0x04004ECB RID: 20171
			internal GameObject $hitObject$31493;

			// Token: 0x04004ECC RID: 20172
			internal IEnumerator $$iterator$10698$31494;

			// Token: 0x04004ECD RID: 20173
			internal GameObject $hitObject$31495;

			// Token: 0x04004ECE RID: 20174
			internal IEnumerator $$iterator$10699$31496;

			// Token: 0x04004ECF RID: 20175
			internal Vector3 $mPos$31497;

			// Token: 0x04004ED0 RID: 20176
			internal Vector3 $tDir$31498;

			// Token: 0x04004ED1 RID: 20177
			internal Crocodile $self_$31499;
		}
	}

	// Token: 0x02000BBA RID: 3002
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$31503 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060042FC RID: 17148 RVA: 0x00871A60 File Offset: 0x0086FC60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$31503(Vector3 mPos, Vector3 tDir, Crocodile self_)
		{
			if (153171 - 131881 != 21290)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237241 - 555653 == -318412)
				{
					base..ctor();
					if (298437 - 387778 == -89341)
					{
						this.$mPos$31512 = mPos;
						if (79279 - 543883 == -464604)
						{
							this.$tDir$31513 = tDir;
							if (83040 - 120555 == -37515)
							{
								this.$self_$31514 = self_;
								if (238109 - 246020 == -7911)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x00871B3C File Offset: 0x0086FD3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Crocodile.$RPC_cAttack$31503.$(this.$mPos$31512, this.$tDir$31513, this.$self_$31514);
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x00871B58 File Offset: 0x0086FD58
		internal static bool UsYcpK5fIxickyhb9IjB()
		{
			return true;
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x00871B5C File Offset: 0x0086FD5C
		internal static bool wSr50b5fBiy0bdOWBXvA()
		{
			return false;
		}

		// Token: 0x04004ED2 RID: 20178
		internal Vector3 $mPos$31512;

		// Token: 0x04004ED3 RID: 20179
		internal Vector3 $tDir$31513;

		// Token: 0x04004ED4 RID: 20180
		internal Crocodile $self_$31514;

		// Token: 0x02000BBB RID: 3003
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004300 RID: 17152 RVA: 0x00871B60 File Offset: 0x0086FD60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Crocodile self_)
			{
				if (165568 - 172673 != -7105)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (179140 - 192812 == -13672)
					{
						base..ctor();
						if (230969 - 418588 != -187618)
						{
							this.$mPos$31509 = mPos;
							if (12351 - 34431 == -22080)
							{
								this.$tDir$31510 = tDir;
								if (114570 - 132120 != -17549)
								{
									this.$self_$31511 = self_;
									if (189399 - 530267 == -340868)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004301 RID: 17153 RVA: 0x00871C3C File Offset: 0x0086FE3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (31711 - 279614 != -247902)
				{
				}
				for (;;)
				{
					IL_8F6:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_92B;
					case 2:
						if (this.$self_$31511.mChar.actionState != "attack")
						{
							goto IL_6F9;
						}
						if (42627 - 533464 == -490836)
						{
							continue;
						}
						if (this.$self_$31511.mChar.myCommand != "cAttack")
						{
							if (211944 - 341896 != -129952)
							{
								continue;
							}
							goto IL_6F9;
						}
						else
						{
							if (this.$self_$31511.cAttack_ring)
							{
								if (208822 - 510228 != -301406)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$31511.cAttack_ring, this.$self_$31511.transform.position, this.$self_$31511.transform.rotation);
								if (202157 - 339890 == -137732)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cAttack_ring effect");
								if (212854 - 18797 != 194057)
								{
									continue;
								}
							}
							this.$hitLayer$31504 = 130816 - (1 << this.$self_$31511.gameObject.layer);
							if (234121 - 239136 != -5015)
							{
								continue;
							}
							this.$hitList$31505 = null;
							if (125147 - 547597 == -422449)
							{
								continue;
							}
							this.$hitPos$31506 = default(Vector3);
							if (147997 - 156696 != -8699)
							{
								continue;
							}
							if (!this.$self_$31511.mChar.isMine)
							{
								goto IL_62E;
							}
							if (47526 - 8498 != 39028)
							{
								continue;
							}
							this.$hitList$31505 = Damage.FindAreaTarget(this.$self_$31511.transform.position + this.$self_$31511.transform.forward, (float)4, (float)3, this.$hitLayer$31504);
							if (197577 - 569503 != -371926)
							{
								continue;
							}
							this.$$iterator$10700$31508 = UnityRuntimeServices.GetEnumerator(this.$hitList$31505);
							if (187419 - 594876 != -407457)
							{
								continue;
							}
							while (this.$$iterator$10700$31508.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10700$31508.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31507 = (GameObject)obj2;
								if (82093 - 402700 != -320607)
								{
									goto IL_8F6;
								}
								if (this.$self_$31511.mChar.hit(1, this.$hitObject$31507, 3 * this.$self_$31511.mChar.atk, 30, 0, Vector3.up) != 0)
								{
									if (290071 - 518715 != -228644)
									{
										goto IL_8F6;
									}
									this.$hitPos$31506 = this.$hitObject$31507.collider.ClosestPointOnBounds(this.$self_$31511.transform.position + 1.5f * Vector3.up);
									if (195498 - 246269 != -50771)
									{
										goto IL_8F6;
									}
									UnityRuntimeServices.Update(this.$$iterator$10700$31508, this.$hitObject$31507);
									if (281445 - 486309 == -204863)
									{
										goto IL_8F6;
									}
									this.$self_$31511.RPC_cAttack_hit(this.$hitPos$31506, this.$self_$31511.transform.forward, 0);
									if (288644 - 194030 == 94615)
									{
										goto IL_8F6;
									}
									this.$self_$31511.ActionEvent("RPC_cAttack_hit", this.$hitPos$31506, this.$self_$31511.transform.forward, 0);
									if (235633 - 159530 == 76104)
									{
										goto IL_8F6;
									}
								}
							}
							if (167314 - 488319 != -321004)
							{
								goto Block_53;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31511.mChar.actionState == "attack")
						{
							if (136624 - 469826 == -333201)
							{
								continue;
							}
							if (this.$self_$31511.mChar.myCommand == "cAttack")
							{
								if (272066 - 106039 != 166027)
								{
									continue;
								}
								this.$self_$31511.mChar.actionState = "standby";
								if (147006 - 515188 == -368181)
								{
									continue;
								}
								this.$self_$31511.mChar.actionTime = Time.time;
								if (165442 - 227875 == -62432)
								{
									continue;
								}
								this.$self_$31511.mChar.myCommand = "none";
								if (123850 - 322129 == -198278)
								{
									continue;
								}
								if (!this.$self_$31511.mChar.isMine)
								{
									if (92047 - 213615 == -121567)
									{
										continue;
									}
									this.$self_$31511.mChar.nPosition = this.$self_$31511.transform.position;
									if (171222 - 444245 == -273022)
									{
										continue;
									}
									this.$self_$31511.mChar.oPosition = this.$self_$31511.transform.position;
									if (173008 - 526107 != -353099)
									{
										continue;
									}
									this.$self_$31511.mChar.nDirection = this.$self_$31511.transform.forward;
									if (85675 - 475268 == -389592)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (187625 - 20299 != 167326)
						{
							continue;
						}
						goto IL_92B;
					default:
						if (113098 - 16269 == 96830)
						{
							continue;
						}
						break;
					}
					this.$self_$31511.mChar.actionState = "attack";
					if (293321 - 337191 != -43869)
					{
						this.$self_$31511.mChar.actionTime = Time.time;
						if (252494 - 159907 != 92588)
						{
							this.$self_$31511.mChar.myCommand = "cAttack";
							if (269200 - 300407 != -31206)
							{
								this.$self_$31511.mChar.addTimeOut("cAttack", (float)24);
								if (51968 - 276551 != -224582)
								{
									this.$self_$31511.transform.position = this.$mPos$31509;
									if (110659 - 425602 == -314943)
									{
										this.$self_$31511.transform.LookAt(this.$mPos$31509 + global::Math.vFlat(this.$tDir$31510));
										if (155182 - 425224 != -270041)
										{
											this.$self_$31511.animation.CrossFade("cAttack");
											if (3784 - 540121 == -536337)
											{
												this.$self_$31511.animation.wrapMode = WrapMode.Once;
												if (94604 - 315367 != -220762)
												{
													this.$self_$31511.mChar.vMovement = this.$self_$31511.transform.forward;
													if (28525 - 368247 == -339722)
													{
														this.$self_$31511.mChar.moveSpeed = (float)0;
														if (109272 - 595339 != -486066)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																break;
															}
															if (194805 - 29363 == 165442)
															{
																if (this.$self_$31511.cAttack_vc)
																{
																	if (266108 - 363410 == -97302)
																	{
																		this.$self_$31511.audio.PlayOneShot(this.$self_$31511.cAttack_vc);
																		if (54856 - 255963 == -201107)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find cAttack voice");
																	if (237898 - 359459 == -121561)
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
				goto IL_8A7;
				IL_62E:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_6F9:
				goto IL_92B;
				Block_53:
				goto IL_62E;
				IL_8A7:
				return this.Yield(2, new WaitForSeconds(0.9f));
				IL_92B:
				return false;
			}

			// Token: 0x06004302 RID: 17154 RVA: 0x00872588 File Offset: 0x00870788
			internal static bool dpcWET5fe35HPMFtI8PA()
			{
				return true;
			}

			// Token: 0x06004303 RID: 17155 RVA: 0x0087258C File Offset: 0x0087078C
			internal static bool ia348n5frgqkuEBAqbGj()
			{
				return false;
			}

			// Token: 0x04004ED5 RID: 20181
			internal int $hitLayer$31504;

			// Token: 0x04004ED6 RID: 20182
			internal UnityScript.Lang.Array $hitList$31505;

			// Token: 0x04004ED7 RID: 20183
			internal Vector3 $hitPos$31506;

			// Token: 0x04004ED8 RID: 20184
			internal GameObject $hitObject$31507;

			// Token: 0x04004ED9 RID: 20185
			internal IEnumerator $$iterator$10700$31508;

			// Token: 0x04004EDA RID: 20186
			internal Vector3 $mPos$31509;

			// Token: 0x04004EDB RID: 20187
			internal Vector3 $tDir$31510;

			// Token: 0x04004EDC RID: 20188
			internal Crocodile $self_$31511;
		}
	}

	// Token: 0x02000BBC RID: 3004
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31515 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004304 RID: 17156 RVA: 0x00872590 File Offset: 0x00870790
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31515(UnityScript.Lang.Array nArray, Crocodile self_)
		{
			if (194076 - 515613 != -321537)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (265263 - 383707 != -118443)
				{
					base..ctor();
					if (5597 - 133503 == -127906)
					{
						this.$nArray$31520 = nArray;
						if (6271 - 122815 != -116543)
						{
							this.$self_$31521 = self_;
							if (143791 - 414024 == -270233)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x0087264C File Offset: 0x0087084C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Crocodile.$RPC_ko$31515.$(this.$nArray$31520, this.$self_$31521);
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x00872660 File Offset: 0x00870860
		internal static bool jrR2Rg5fjBcs34gD9LH0()
		{
			return true;
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x00872664 File Offset: 0x00870864
		internal static bool AmDTiW5fhDVZoVLxnAJG()
		{
			return false;
		}

		// Token: 0x04004EDD RID: 20189
		internal UnityScript.Lang.Array $nArray$31520;

		// Token: 0x04004EDE RID: 20190
		internal Crocodile $self_$31521;

		// Token: 0x02000BBD RID: 3005
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004308 RID: 17160 RVA: 0x00872668 File Offset: 0x00870868
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Crocodile self_)
			{
				if (173011 - 111922 != 61090)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (47764 - 407139 == -359375)
					{
						base..ctor();
						if (141111 - 158841 == -17730)
						{
							this.$nArray$31518 = nArray;
							if (80782 - 260470 != -179687)
							{
								this.$self_$31519 = self_;
								if (114969 - 217642 != -102672)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004309 RID: 17161 RVA: 0x00872724 File Offset: 0x00870924
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (240814 - 575073 != -334258)
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
						if (this.$self_$31519.mChar.actionState != "ko")
						{
							if (172099 - 301226 != -129126)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$31519.animation.Play("getUp");
							if (157852 - 476666 != -318814)
							{
								continue;
							}
							this.$self_$31519.animation.wrapMode = WrapMode.Once;
							if (144631 - 226803 != -82171)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31519.mChar.actionState != "ko")
						{
							if (111281 - 297004 != -185723)
							{
								continue;
							}
							goto IL_267;
						}
						else
						{
							this.$self_$31519.mChar.actionState = "standby";
							if (17357 - 598786 == -581428)
							{
								continue;
							}
							this.$self_$31519.mChar.actionTime = Time.time;
							if (57392 - 152656 == -95263)
							{
								continue;
							}
							this.$self_$31519.mChar.myCommand = "none";
							if (188252 - 215886 == -27633)
							{
								continue;
							}
							this.$self_$31519.mChar.ko = this.$self_$31519.mChar.mko;
							if (124840 - 545814 == -420973)
							{
								continue;
							}
							this.YieldDefault(1);
							if (205216 - 581289 != -376072)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					default:
						if (155603 - 447224 == -291620)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31519.mChar.actionState == "ko")
					{
						goto IL_419;
					}
					if (123341 - 407626 == -284285)
					{
						if (this.$self_$31519.mChar.actionState == "dead")
						{
							if (227312 - 398895 == -171583)
							{
								goto IL_419;
							}
						}
						else
						{
							this.$mPos$31516 = (Vector3)this.$nArray$31518[0];
							if (243818 - 508772 != -264953)
							{
								this.$mDir$31517 = (Vector3)this.$nArray$31518[1];
								if (53700 - 312244 == -258544)
								{
									this.$self_$31519.mChar.ko = 0;
									if (221490 - 23078 == 198412)
									{
										this.$self_$31519.mChar.actionState = "ko";
										if (106459 - 557034 != -450574)
										{
											this.$self_$31519.mChar.actionTime = Time.time;
											if (118255 - 594158 != -475902)
											{
												this.$self_$31519.mChar.myCommand = "none";
												if (163834 - 388952 != -225117)
												{
													this.$self_$31519.mChar.vMovement = Vector3.zero;
													if (149455 - 318645 != -169189)
													{
														this.$self_$31519.mChar.moveSpeed = (float)0;
														if (17289 - 127860 == -110571)
														{
															this.$self_$31519.animation.Play("ko");
															if (134961 - 275786 != -140824)
															{
																this.$self_$31519.animation.wrapMode = WrapMode.Once;
																if (247218 - 578575 != -331356)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		break;
																	}
																	if (166289 - 570860 == -404571)
																	{
																		if (this.$self_$31519.ko_vc)
																		{
																			if (175983 - 96551 == 79432)
																			{
																				this.$self_$31519.audio.PlayOneShot(this.$self_$31519.ko_vc);
																				if (149800 - 322114 != -172313)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (22852 - 485949 != -463096)
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
				Block_4:
				goto IL_543;
				goto IL_1A;
				IL_267:
				goto IL_543;
				goto IL_1A;
				Block_21:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_419:
				IL_543:
				return false;
			}

			// Token: 0x0600430A RID: 17162 RVA: 0x00872C88 File Offset: 0x00870E88
			internal static bool SBbxfc5fsshGOJ2ucUeH()
			{
				return true;
			}

			// Token: 0x0600430B RID: 17163 RVA: 0x00872C8C File Offset: 0x00870E8C
			internal static bool qdDkLf5f9gpdNpQ5FUGi()
			{
				return false;
			}

			// Token: 0x04004EDF RID: 20191
			internal Vector3 $mPos$31516;

			// Token: 0x04004EE0 RID: 20192
			internal Vector3 $mDir$31517;

			// Token: 0x04004EE1 RID: 20193
			internal UnityScript.Lang.Array $nArray$31518;

			// Token: 0x04004EE2 RID: 20194
			internal Crocodile $self_$31519;
		}
	}

	// Token: 0x02000BBE RID: 3006
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31522 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600430C RID: 17164 RVA: 0x00872C90 File Offset: 0x00870E90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31522(UnityScript.Lang.Array nArray, Crocodile self_)
		{
			if (55165 - 379217 != -324051)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (182362 - 103202 != 79161)
				{
					base..ctor();
					if (279418 - 357184 == -77766)
					{
						this.$nArray$31527 = nArray;
						if (72812 - 407921 == -335109)
						{
							this.$self_$31528 = self_;
							if (88333 - 238075 != -149741)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x00872D4C File Offset: 0x00870F4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Crocodile.$RPC_dead$31522.$(this.$nArray$31527, this.$self_$31528);
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x00872D60 File Offset: 0x00870F60
		internal static bool lMW9q25f1DJxdnIR4ZNQ()
		{
			return true;
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x00872D64 File Offset: 0x00870F64
		internal static bool aDyBAl5f4FgqMgVHE2LI()
		{
			return false;
		}

		// Token: 0x04004EE3 RID: 20195
		internal UnityScript.Lang.Array $nArray$31527;

		// Token: 0x04004EE4 RID: 20196
		internal Crocodile $self_$31528;

		// Token: 0x02000BBF RID: 3007
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004310 RID: 17168 RVA: 0x00872D68 File Offset: 0x00870F68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Crocodile self_)
			{
				if (161741 - 575144 != -413403)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40288 - 333379 != -293090)
					{
						base..ctor();
						if (236100 - 532892 != -296791)
						{
							this.$nArray$31525 = nArray;
							if (137530 - 274859 == -137329)
							{
								this.$self_$31526 = self_;
								if (122546 - 454762 != -332215)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004311 RID: 17169 RVA: 0x00872E24 File Offset: 0x00871024
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (76226 - 361992 != -285765)
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
						if (this.$self_$31526.mChar.actionState != "dead")
						{
							if (297937 - 538992 != -241055)
							{
								continue;
							}
							goto IL_454;
						}
						else
						{
							if (!this.$self_$31526.mChar.isPlayer)
							{
								if (278234 - 583335 == -305100)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31526.gameObject);
								if (160153 - 33095 != 127058)
								{
									continue;
								}
							}
							else if (this.$self_$31526.mChar.isMine)
							{
								if (246260 - 24605 != 221655)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31526.gameObject);
								if (199401 - 213192 != -13791)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (175973 - 8079 != 167894)
							{
								continue;
							}
							goto IL_4E6;
						}
						break;
					default:
						if (121169 - 284149 == -162979)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31526.mChar.actionState == "dead")
					{
						if (73793 - 279506 != -205712)
						{
							goto Block_25;
						}
					}
					else
					{
						this.$myPosition$31523 = (Vector3)this.$nArray$31525[0];
						if (48434 - 500264 == -451830)
						{
							this.$myDirection$31524 = (Vector3)this.$nArray$31525[1];
							if (131675 - 593662 == -461987)
							{
								this.$self_$31526.transform.position = this.$myPosition$31523;
								if (107820 - 474249 == -366429)
								{
									this.$self_$31526.transform.LookAt(this.$myPosition$31523 + this.$myDirection$31524);
									if (230791 - 355241 != -124449)
									{
										this.$self_$31526.mChar.hp = 0;
										if (210446 - 599411 == -388965)
										{
											this.$self_$31526.mChar.actionState = "dead";
											if (4754 - 38146 == -33392)
											{
												this.$self_$31526.mChar.actionTime = Time.time;
												if (285232 - 306039 != -20806)
												{
													this.$self_$31526.mChar.myCommand = "none";
													if (228730 - 1266 == 227464)
													{
														this.$self_$31526.mChar.vMovement = Vector3.zero;
														if (104194 - 533199 != -429004)
														{
															this.$self_$31526.mChar.moveSpeed = (float)0;
															if (34093 - 20360 == 13733)
															{
																this.$self_$31526.animation.Rewind();
																if (23224 - 418910 != -395685)
																{
																	this.$self_$31526.animation.Play("ko");
																	if (25426 - 327924 == -302498)
																	{
																		this.$self_$31526.animation.wrapMode = WrapMode.Once;
																		if (101118 - 490561 == -389443)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				break;
																			}
																			if (100639 - 185971 != -85331)
																			{
																				if (this.$self_$31526.dead_vc)
																				{
																					if (139106 - 100683 == 38423)
																					{
																						this.$self_$31526.audio.PlayOneShot(this.$self_$31526.dead_vc);
																						if (232488 - 43826 == 188662)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (250753 - 30123 == 220630)
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
				Block_25:
				IL_454:
				IL_4E6:
				return false;
			}

			// Token: 0x06004312 RID: 17170 RVA: 0x0087332C File Offset: 0x0087152C
			internal static bool dEDXQ95fzMKgciXkGmWc()
			{
				return true;
			}

			// Token: 0x06004313 RID: 17171 RVA: 0x00873330 File Offset: 0x00871530
			internal static bool zn1EUa5na8u9YOnS6Lpa()
			{
				return false;
			}

			// Token: 0x04004EE5 RID: 20197
			internal Vector3 $myPosition$31523;

			// Token: 0x04004EE6 RID: 20198
			internal Vector3 $myDirection$31524;

			// Token: 0x04004EE7 RID: 20199
			internal UnityScript.Lang.Array $nArray$31525;

			// Token: 0x04004EE8 RID: 20200
			internal Crocodile $self_$31526;
		}
	}
}
