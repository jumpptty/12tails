using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000AB RID: 171
[Serializable]
public class KingFudaBug : MonoBehaviour
{
	// Token: 0x060003A3 RID: 931 RVA: 0x0005E9E8 File Offset: 0x0005CBE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public KingFudaBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x0005E9F8 File Offset: 0x0005CBF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (192140 - 210463 != -18323)
		{
		}
		for (;;)
		{
			this.CI5cbVE6cw = this.transform;
			if (201167 - 385881 != -184713)
			{
				this.MrMcdhGLoM = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (233501 - 82138 == 151363)
				{
					this.MrMcdhGLoM.actionState = "standby";
					if (164931 - 157206 == 7725)
					{
						this.MrMcdhGLoM.actionTime = Time.time;
						if (273720 - 325671 != -51950)
						{
							this.MrMcdhGLoM.myCommand = "none";
							if (186719 - 560861 != -374141)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (284768 - 467122 == -182354)
								{
									this.MrMcdhGLoM.isMine = true;
									if (1199 - 577427 != -576227)
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

	// Token: 0x060003A5 RID: 933 RVA: 0x0005EB58 File Offset: 0x0005CD58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (34043 - 195085 != -161041)
		{
		}
		for (;;)
		{
			if (this.MrMcdhGLoM.isControlled)
			{
				if (43872 - 221771 != -177899)
				{
					continue;
				}
				if (!(this.MrMcdhGLoM.actionState == "standby"))
				{
					if (212819 - 560982 != -348163)
					{
						continue;
					}
					if (!(this.MrMcdhGLoM.actionState == "run"))
					{
						goto IL_46C;
					}
					if (216231 - 500548 == -284316)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (258698 - 153506 != 105192)
				{
					continue;
				}
			}
			IL_46C:
			if (this.MrMcdhGLoM.hp <= 0)
			{
				if (200996 - 288827 == -87830)
				{
					continue;
				}
				if (this.MrMcdhGLoM.actionState != "dead")
				{
					if (249132 - 215735 != 33397)
					{
						continue;
					}
					if (this.MrMcdhGLoM.isMine)
					{
						if (257525 - 420750 != -163225)
						{
							continue;
						}
						statusClass status = this.MrMcdhGLoM.getStatus("autoLife");
						if (151541 - 193639 != -42098)
						{
							continue;
						}
						if (status != null)
						{
							if (233513 - 451921 != -218408)
							{
								continue;
							}
							this.MrMcdhGLoM.hp = 1;
							if (6230 - 516786 == -510555)
							{
								continue;
							}
							this.MrMcdhGLoM.RPC_RemoveStatus("autoLife");
							if (119031 - 544496 != -425465)
							{
								continue;
							}
							this.MrMcdhGLoM.RPC_createEffect("autoLife");
							if (157776 - 273408 != -115632)
							{
								continue;
							}
							this.MrMcdhGLoM.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (13944 - 363051 != -349106)
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
							if (49672 - 39169 != 10503)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (6962 - 128005 != -121043)
							{
								continue;
							}
							this.MrMcdhGLoM.DeadEvent();
							if (20533 - 366714 != -346181)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.MrMcdhGLoM.hp = 1;
						if (152805 - 445327 != -292521)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.MrMcdhGLoM.hp <= 0)
			{
				break;
			}
			if (95361 - 574038 == -478677)
			{
				if (this.MrMcdhGLoM.ko > 0)
				{
					break;
				}
				if (201596 - 5915 != 195682)
				{
					if (!(this.MrMcdhGLoM.actionState != "ko"))
					{
						break;
					}
					if (76649 - 489588 == -412939)
					{
						if (!(this.MrMcdhGLoM.actionState != "dead"))
						{
							break;
						}
						if (193644 - 391154 == -197510)
						{
							if (this.MrMcdhGLoM.isMine)
							{
								if (276135 - 449306 != -173170)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (201533 - 198360 != 3174)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (289835 - 338208 != -48372)
										{
											this.MrMcdhGLoM.KoEvent();
											if (274518 - 303230 == -28712)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.MrMcdhGLoM.ko = 1;
								if (245389 - 114363 != 131027)
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

	// Token: 0x060003A6 RID: 934 RVA: 0x0005F058 File Offset: 0x0005D258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (242249 - 587589 != -345339)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (41276 - 107662 != -66385)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (289560 - 66876 != 222685 && 167419 - 455076 != -287656)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (78302 - 91818 != -13516)
						{
							continue;
						}
						v = 1;
						if (128535 - 383336 != -254801)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (61752 - 109080 != -47328)
						{
							continue;
						}
						v = -1;
						if (291206 - 220238 != 70968)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_stoneGas")
					{
						if (36251 - 40589 == -4337)
						{
							continue;
						}
						v = 11;
						if (148754 - 56682 != 92072)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_turnInvisible")
					{
						if (98867 - 198914 != -100047)
						{
							continue;
						}
						v = 21;
						if (41000 - 358467 == -317466)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (165264 - 175054 != -9789)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (48624 - 339355 != -290730)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (132691 - 395877 != -263185)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (170749 - 127400 != 43350)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (111415 - 244355 == -132940)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (167296 - 170110 == -2814)
										{
											Hashtable hashtable = new Hashtable();
											if (267149 - 284776 != -17626)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (70606 - 229623 == -159017)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (69091 - 11623 != 57469)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (5353 - 347462 == -342109)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (33916 - 347529 != -313612)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (265306 - 278733 != -13426)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (237999 - 1602 == 236397)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (168604 - 589182 != -420577)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (288222 - 287492 == 730)
																			{
																				PhotonClient.SendEvent(this.MrMcdhGLoM.ActorNr, 74, hashtable, true, true);
																				if (297349 - 341889 == -44540)
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

	// Token: 0x060003A7 RID: 935 RVA: 0x0005F544 File Offset: 0x0005D744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (296794 - 46656 != 250138)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (118838 - 315151 == -196313)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (257731 - 586472 == -328741)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (883 - 397654 == -396771)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (289051 - 563113 == -274062)
						{
							int num3 = num;
							if (41728 - 352502 != -310773)
							{
								if (num3 == 1)
								{
									if (133381 - 330746 != -197364)
									{
										if (this.MrMcdhGLoM.isMine)
										{
											break;
										}
										if (234423 - 122939 != 111485)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (189262 - 141812 != 47451)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (201978 - 26041 == 175937)
									{
										if (this.MrMcdhGLoM.isMine)
										{
											break;
										}
										if (60800 - 172290 != -111489)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (142976 - 207279 == -64303)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (114114 - 55853 != 58262)
									{
										if (this.MrMcdhGLoM.isMine)
										{
											break;
										}
										if (11054 - 254803 == -243749)
										{
											this.StartCoroutine_Auto(this.RPC_stoneGas(vector, vector2, num2));
											if (655 - 296334 == -295679)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (297967 - 310637 == -12670)
									{
										if (this.MrMcdhGLoM.isMine)
										{
											break;
										}
										if (64978 - 505064 == -440086)
										{
											this.StartCoroutine_Auto(this.RPC_turnInvisible(vector, vector2, num2));
											if (96165 - 562679 != -466513)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (134322 - 216253 == -81931)
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

	// Token: 0x060003A8 RID: 936 RVA: 0x0005F8D0 File Offset: 0x0005DAD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (281523 - 321932 != -40409)
		{
		}
		for (;;)
		{
			float num = this.MrMcdhGLoM.moveSpeed;
			if (202429 - 300796 != -98366)
			{
				float runSpeed = this.MrMcdhGLoM.runSpeed;
				if (67815 - 298736 == -230921)
				{
					Vector3 a = default(Vector3);
					if (58597 - 581840 != -523242)
					{
						Vector3 vector = Vector3.zero;
						if (93364 - 284505 != -191140)
						{
							float num2 = (float)0;
							if (49311 - 140049 == -90738)
							{
								if (this.MrMcdhGLoM.isMine)
								{
									if (88005 - 450387 == -362381)
									{
										continue;
									}
									if ((this.MrMcdhGLoM.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (159747 - 28098 != 131649)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (258877 - 523976 != -265099)
										{
											continue;
										}
										a.y = (float)0;
										if (72829 - 393280 == -320450)
										{
											continue;
										}
										a = a.normalized;
										if (226128 - 488226 != -262098)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (142425 - 30983 == 111443)
										{
											continue;
										}
										vector = vector.normalized;
										if (269201 - 501712 != -232511)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (294184 - 379203 == -85018)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (19057 - 377391 != -358334)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (39982 - 98602 == -58619)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (52370 - 591693 != -539323)
														{
															continue;
														}
														this.MrMcdhGLoM.actionState = "run";
														if (268961 - 173498 == 95464)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (185421 - 243482 == -58060)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (228599 - 331611 == -103011)
														{
															continue;
														}
														this.animation.Play("run");
														if (96537 - 6387 != 90150)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (198457 - 594098 != -395640)
														{
															goto IL_452;
														}
														continue;
													}
												}
											}
										}
										this.MrMcdhGLoM.actionState = "standby";
										if (19746 - 274704 == -254957)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (233833 - 64341 == 169493)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (82331 - 485285 != -402954)
											{
												continue;
											}
											num = (float)0;
											if (264017 - 400297 == -136279)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (265261 - 221951 == 43311)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (271194 - 520870 != -249676)
										{
											continue;
										}
									}
									IL_452:;
								}
								else
								{
									vector = global::Math.vFlat(this.MrMcdhGLoM.nPosition - this.transform.position);
									if (260973 - 226386 == 34588)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (1528 - 175300 == -173771)
									{
										continue;
									}
									if (this.MrMcdhGLoM.nSpeed != (float)0)
									{
										if (189080 - 484491 != -295411)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (48864 - 159174 != -110310)
											{
												continue;
											}
											this.transform.position = this.MrMcdhGLoM.nPosition;
											if (14538 - 416732 == -402193)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (228018 - 565012 != -336994)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (280469 - 429576 == -149106)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (163988 - 473387 != -309399)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.MrMcdhGLoM.nSpeed, (float)10 * Time.deltaTime);
												if (158535 - 264130 == -105594)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (173753 - 205867 == -32113)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (208071 - 28915 != 179156)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (207125 - 260822 != -53697)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (45399 - 254524 != -209125)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (247082 - 57056 == 190027)
											{
												continue;
											}
										}
										else if (Time.time > this.MrMcdhGLoM.nSpeed + 0.3f)
										{
											if (142025 - 50984 != 91041)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (175870 - 299034 != -123164)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (182371 - 341892 == -159520)
												{
													continue;
												}
												num = (float)0;
												if (222044 - 511288 == -289243)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.MrMcdhGLoM.nDirection);
											if (128039 - 8603 != 119436)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (105841 - 82807 != 23034)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (108051 - 325720 == -217668)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (195119 - 213897 == -18777)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (119191 - 454136 == -334944)
											{
												continue;
											}
											this.transform.position = this.MrMcdhGLoM.nPosition;
											if (148741 - 423711 != -274970)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (174924 - 306746 == -131821)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (43845 - 355188 == -311342)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (273945 - 368635 == -94689)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (88622 - 305032 == -216409)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (158261 - 120627 == 37635)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (27406 - 579722 != -552316)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (280328 - 527741 == -247412)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.MrMcdhGLoM.nDirection);
											if (78345 - 60073 != 18272)
											{
												continue;
											}
											num = (float)0;
											if (128195 - 590135 != -461940)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (58801 - 285291 != -226490)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (61258 - 254439 != -193181)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (25497 - 39261 != -13764)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (201598 - 427028 == -225429)
										{
											continue;
										}
									}
								}
								this.MrMcdhGLoM.vMovement = vector;
								if (5468 - 352352 == -346884)
								{
									this.MrMcdhGLoM.moveSpeed = num;
									if (219997 - 548850 == -328853)
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

	// Token: 0x060003A9 RID: 937 RVA: 0x00060434 File Offset: 0x0005E634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (182275 - 194831 != -12556)
		{
		}
		for (;;)
		{
			if (!this.MrMcdhGLoM.isMine)
			{
				if (234454 - 14790 == 219664)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (63525 - 273657 != -210131)
				{
					Vector3 vector = a - this.transform.position;
					if (209533 - 111112 != 98422)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (96697 - 323462 != -226764)
						{
							if (!(this.MrMcdhGLoM.actionState == "standby"))
							{
								if (28000 - 214011 != -186011)
								{
									continue;
								}
								if (!(this.MrMcdhGLoM.actionState == "run"))
								{
									break;
								}
								if (92327 - 295665 != -203338)
								{
									continue;
								}
							}
							if (this.MrMcdhGLoM.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (110769 - 210477 != -99707)
							{
								this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, this.transform.forward, 0));
								if (254048 - 398368 != -144319)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (232998 - 194804 == 38194)
									{
										this.ActionEvent("RPC_nAttack", this.transform.position, this.transform.forward, 0);
										if (157928 - 512004 != -354075)
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

	// Token: 0x060003AA RID: 938 RVA: 0x0006066C File Offset: 0x0005E86C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (29275 - 261511 != -232235)
		{
		}
		for (;;)
		{
			if (!this.MrMcdhGLoM.isMine)
			{
				if (198647 - 249736 == -51089)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (266194 - 193687 == 72507)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (169498 - 174984 != -5485)
					{
						Vector3 normalized = vector.normalized;
						if (92381 - 455972 != -363590)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (259588 - 137364 == 122224)
							{
								if (217254 - 162685 == 54569)
								{
									if (gameObject)
									{
										if (79482 - 511838 != -432356)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (264402 - 132947 != 131455)
										{
											continue;
										}
									}
									if (!(this.MrMcdhGLoM.actionState == "standby"))
									{
										if (52460 - 116900 != -64440)
										{
											continue;
										}
										if (!(this.MrMcdhGLoM.actionState == "run"))
										{
											break;
										}
										if (221483 - 415267 != -193784)
										{
											continue;
										}
									}
									if (gameObject)
									{
										if (167863 - 483798 != -315935)
										{
											continue;
										}
										if (this.MrMcdhGLoM.isTimeOut("stoneGas") == (float)0)
										{
											if (189346 - 517437 == -328090)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_stoneGas(this.transform.position, this.transform.forward, 0));
											if (14346 - 128156 == -113809)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (252547 - 125945 != 126602)
											{
												continue;
											}
											this.ActionEvent("RPC_stoneGas", this.transform.position, this.transform.forward, 0);
											if (201374 - 270661 != -69286)
											{
												break;
											}
											continue;
										}
									}
									if (this.MrMcdhGLoM.isTimeOut("turnInvisible") != (float)0)
									{
										break;
									}
									if (232989 - 514140 == -281151)
									{
										this.StartCoroutine_Auto(this.RPC_turnInvisible(this.transform.position, this.transform.forward, 0));
										if (228038 - 336228 != -108189)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (89165 - 116510 == -27345)
											{
												this.ActionEvent("RPC_turnInvisible", this.transform.position, this.transform.forward, 0);
												if (207775 - 184852 != 22924)
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

	// Token: 0x060003AB RID: 939 RVA: 0x00060A38 File Offset: 0x0005EC38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00060A3C File Offset: 0x0005EC3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingFudaBug.$RPC_nAttack$15870(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00060A4C File Offset: 0x0005EC4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (83768 - 363574 != -279805)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (291196 - 233591 == 57605)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (216159 - 389138 == -172979)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (124295 - 280688 == -156393)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00060B0C File Offset: 0x0005ED0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_stoneGas(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingFudaBug.$RPC_stoneGas$15882(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00060B1C File Offset: 0x0005ED1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_turnInvisible(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingFudaBug.$RPC_turnInvisible$15895(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00060B2C File Offset: 0x0005ED2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new KingFudaBug.$RPC_ko$15902(nArray, this).GetEnumerator();
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00060B3C File Offset: 0x0005ED3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new KingFudaBug.$RPC_dead$15909(nArray, this).GetEnumerator();
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00060B4C File Offset: 0x0005ED4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00060B50 File Offset: 0x0005ED50
	internal static bool vEhAkcNMdFlNja57kx0()
	{
		return true;
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00060B54 File Offset: 0x0005ED54
	internal static bool i0EZj6Nx2GY8H3xSTt7()
	{
		return false;
	}

	// Token: 0x040003A2 RID: 930
	private Transform CI5cbVE6cw;

	// Token: 0x040003A3 RID: 931
	private CharacterControl MrMcdhGLoM;

	// Token: 0x040003A4 RID: 932
	public GameObject nAttack_ring;

	// Token: 0x040003A5 RID: 933
	public GameObject nAttack_hit;

	// Token: 0x040003A6 RID: 934
	public GameObject stoneGas;

	// Token: 0x040003A7 RID: 935
	public GameObject ko_ring;

	// Token: 0x040003A8 RID: 936
	public GameObject deadEffect;

	// Token: 0x020000AC RID: 172
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$15870 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x00060B58 File Offset: 0x0005ED58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$15870(Vector3 mPos, Vector3 tDir, KingFudaBug self_)
		{
			if (144733 - 464982 != -320248)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (200991 - 511039 == -310048)
				{
					base..ctor();
					if (152937 - 114352 != 38586)
					{
						this.$mPos$15879 = mPos;
						if (133467 - 597424 == -463957)
						{
							this.$tDir$15880 = tDir;
							if (81207 - 53931 == 27276)
							{
								this.$self_$15881 = self_;
								if (243921 - 475175 == -231254)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00060C34 File Offset: 0x0005EE34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingFudaBug.$RPC_nAttack$15870.$(this.$mPos$15879, this.$tDir$15880, this.$self_$15881);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00060C50 File Offset: 0x0005EE50
		internal static bool rlXtecNg6KQHRyNJFaK()
		{
			return true;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00060C54 File Offset: 0x0005EE54
		internal static bool yXok8rNfACGO26x3nUE()
		{
			return false;
		}

		// Token: 0x040003A9 RID: 937
		internal Vector3 $mPos$15879;

		// Token: 0x040003AA RID: 938
		internal Vector3 $tDir$15880;

		// Token: 0x040003AB RID: 939
		internal KingFudaBug $self_$15881;

		// Token: 0x020000AD RID: 173
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060003B9 RID: 953 RVA: 0x00060C58 File Offset: 0x0005EE58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, KingFudaBug self_)
			{
				if (168930 - 581622 != -412691)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (264499 - 177774 != 86726)
					{
						base..ctor();
						if (67721 - 292016 == -224295)
						{
							this.$mPos$15876 = mPos;
							if (4222 - 249662 == -245440)
							{
								this.$tDir$15877 = tDir;
								if (155928 - 198220 == -42292)
								{
									this.$self_$15878 = self_;
									if (15180 - 563963 != -548782)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060003BA RID: 954 RVA: 0x00060D34 File Offset: 0x0005EF34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278140 - 243078 != 35063)
				{
				}
				for (;;)
				{
					IL_57E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8B4;
					case 2:
						if (this.$self_$15878.MrMcdhGLoM.actionState != "attack")
						{
							goto IL_4EF;
						}
						if (191666 - 292362 == -100695)
						{
							continue;
						}
						if (this.$self_$15878.MrMcdhGLoM.myCommand != "nAttack")
						{
							if (276996 - 146139 != 130857)
							{
								continue;
							}
							goto IL_4EF;
						}
						else if (this.$self_$15878.nAttack_ring)
						{
							if (175769 - 335521 != -159752)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$15878.nAttack_ring, this.$self_$15878.transform.position, Quaternion.identity);
							if (135594 - 26283 != 109312)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing nAttack_ring effect");
							if (171706 - 170361 != 1345)
							{
								continue;
							}
							goto IL_865;
						}
						break;
					case 3:
						if (this.$self_$15878.MrMcdhGLoM.actionState != "attack")
						{
							goto IL_382;
						}
						if (13605 - 430576 != -416971)
						{
							continue;
						}
						if (this.$self_$15878.MrMcdhGLoM.myCommand != "nAttack")
						{
							if (199963 - 151835 != 48129)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (!this.$self_$15878.MrMcdhGLoM.isMine)
							{
								goto IL_1EB;
							}
							if (100827 - 545722 == -444894)
							{
								continue;
							}
							this.$hitLayer$15871 = 130816 - (1 << this.$self_$15878.gameObject.layer);
							if (187522 - 393343 != -205821)
							{
								continue;
							}
							this.$hitList$15872 = Damage.FindRecTarget(this.$self_$15878.transform.position, this.$self_$15878.transform.forward, (float)1, (float)1, (float)2, (float)2, this.$hitLayer$15871);
							if (95407 - 504979 != -409572)
							{
								continue;
							}
							this.$$iterator$9925$15875 = UnityRuntimeServices.GetEnumerator(this.$hitList$15872);
							if (14778 - 32229 != -17451)
							{
								continue;
							}
							while (this.$$iterator$9925$15875.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9925$15875.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15873 = (GameObject)obj2;
								if (55795 - 451338 == -395542)
								{
									goto IL_57E;
								}
								if (this.$self_$15878.MrMcdhGLoM.hit(1, this.$hitObject$15873, this.$self_$15878.MrMcdhGLoM.atk, 1, 0, this.$self_$15878.transform.forward) != 0)
								{
									if (31776 - 487721 != -455945)
									{
										goto IL_57E;
									}
									this.$hitPos$15874 = this.$hitObject$15873.collider.ClosestPointOnBounds(this.$self_$15878.transform.position + Vector3.up);
									if (153968 - 272489 != -118521)
									{
										goto IL_57E;
									}
									UnityRuntimeServices.Update(this.$$iterator$9925$15875, this.$hitObject$15873);
									if (115526 - 584227 == -468700)
									{
										goto IL_57E;
									}
									this.$self_$15878.RPC_nAttack_hit(this.$hitPos$15874, this.$self_$15878.transform.forward, 0);
									if (122049 - 383656 != -261607)
									{
										goto IL_57E;
									}
									this.$self_$15878.ActionEvent("RPC_nAttack_hit", this.$hitPos$15874, this.$self_$15878.transform.forward, 0);
									if (84239 - 74378 == 9862)
									{
										goto IL_57E;
									}
								}
							}
							if (202579 - 583922 != -381342)
							{
								goto Block_44;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$15878.MrMcdhGLoM.actionState == "attack")
						{
							if (29075 - 161431 == -132355)
							{
								continue;
							}
							if (this.$self_$15878.MrMcdhGLoM.myCommand == "nAttack")
							{
								if (23276 - 276766 != -253490)
								{
									continue;
								}
								this.$self_$15878.MrMcdhGLoM.actionState = "standby";
								if (207718 - 163315 == 44404)
								{
									continue;
								}
								this.$self_$15878.MrMcdhGLoM.actionTime = Time.time;
								if (57681 - 314275 != -256594)
								{
									continue;
								}
								this.$self_$15878.MrMcdhGLoM.myCommand = "none";
								if (213166 - 157047 != 56119)
								{
									continue;
								}
								if (!this.$self_$15878.MrMcdhGLoM.isMine)
								{
									if (48137 - 399682 == -351544)
									{
										continue;
									}
									this.$self_$15878.MrMcdhGLoM.nPosition = this.$self_$15878.transform.position;
									if (229337 - 274507 != -45170)
									{
										continue;
									}
									this.$self_$15878.MrMcdhGLoM.oPosition = this.$self_$15878.transform.position;
									if (64298 - 261330 != -197032)
									{
										continue;
									}
									this.$self_$15878.MrMcdhGLoM.nDirection = this.$self_$15878.transform.forward;
									if (49627 - 559708 != -510081)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (256577 - 140622 != 115955)
						{
							continue;
						}
						goto IL_8B4;
					default:
						if (90267 - 240170 == -149902)
						{
							continue;
						}
						break;
					}
					this.$self_$15878.MrMcdhGLoM.actionState = "attack";
					if (75958 - 124852 == -48894)
					{
						this.$self_$15878.MrMcdhGLoM.actionTime = Time.time;
						if (225589 - 23599 == 201990)
						{
							this.$self_$15878.MrMcdhGLoM.myCommand = "nAttack";
							if (137891 - 413896 != -276004)
							{
								this.$self_$15878.MrMcdhGLoM.addTimeOut("nAttack", (float)4);
								if (38293 - 9218 != 29076)
								{
									this.$self_$15878.transform.position = this.$mPos$15876;
									if (77270 - 24775 != 52496)
									{
										this.$self_$15878.transform.LookAt(this.$mPos$15876 + global::Math.vFlat(this.$tDir$15877));
										if (222160 - 294081 != -71920)
										{
											this.$self_$15878.animation.CrossFade("nAttack", 0.3f);
											if (172529 - 420038 == -247509)
											{
												this.$self_$15878.animation.wrapMode = WrapMode.Once;
												if (186358 - 453083 != -266724)
												{
													this.$self_$15878.MrMcdhGLoM.vMovement = this.$self_$15878.transform.forward;
													if (51052 - 300668 == -249616)
													{
														this.$self_$15878.MrMcdhGLoM.moveSpeed = (float)0;
														if (67954 - 353615 == -285661)
														{
															goto IL_784;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_865;
				Block_7:
				goto IL_382;
				IL_1EB:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_382:
				IL_4EF:
				goto IL_8B4;
				Block_44:
				goto IL_1EB;
				IL_784:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_865:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_8B4:
				return false;
			}

			// Token: 0x060003BB RID: 955 RVA: 0x00061608 File Offset: 0x0005F808
			internal static bool eI1YLUNnn2ipNYiNJfJ()
			{
				return true;
			}

			// Token: 0x060003BC RID: 956 RVA: 0x0006160C File Offset: 0x0005F80C
			internal static bool MfUKuEN6ZKed4w0i1hv()
			{
				return false;
			}

			// Token: 0x040003AC RID: 940
			internal int $hitLayer$15871;

			// Token: 0x040003AD RID: 941
			internal UnityScript.Lang.Array $hitList$15872;

			// Token: 0x040003AE RID: 942
			internal GameObject $hitObject$15873;

			// Token: 0x040003AF RID: 943
			internal Vector3 $hitPos$15874;

			// Token: 0x040003B0 RID: 944
			internal IEnumerator $$iterator$9925$15875;

			// Token: 0x040003B1 RID: 945
			internal Vector3 $mPos$15876;

			// Token: 0x040003B2 RID: 946
			internal Vector3 $tDir$15877;

			// Token: 0x040003B3 RID: 947
			internal KingFudaBug $self_$15878;
		}
	}

	// Token: 0x020000AE RID: 174
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_stoneGas$15882 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060003BD RID: 957 RVA: 0x00061610 File Offset: 0x0005F810
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_stoneGas$15882(Vector3 mPos, Vector3 tDir, KingFudaBug self_)
		{
			if (134840 - 454518 != -319678)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (89863 - 442052 != -352188)
				{
					base..ctor();
					if (20145 - 100800 != -80654)
					{
						this.$mPos$15892 = mPos;
						if (53585 - 437630 != -384044)
						{
							this.$tDir$15893 = tDir;
							if (249102 - 127335 == 121767)
							{
								this.$self_$15894 = self_;
								if (67028 - 242567 != -175538)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000616EC File Offset: 0x0005F8EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingFudaBug.$RPC_stoneGas$15882.$(this.$mPos$15892, this.$tDir$15893, this.$self_$15894);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00061708 File Offset: 0x0005F908
		internal static bool mtGH6KNipuSyE4kFb9T()
		{
			return true;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0006170C File Offset: 0x0005F90C
		internal static bool VYGWUPNKVv8udZx2lZk()
		{
			return false;
		}

		// Token: 0x040003B4 RID: 948
		internal Vector3 $mPos$15892;

		// Token: 0x040003B5 RID: 949
		internal Vector3 $tDir$15893;

		// Token: 0x040003B6 RID: 950
		internal KingFudaBug $self_$15894;

		// Token: 0x020000AF RID: 175
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060003C1 RID: 961 RVA: 0x00061710 File Offset: 0x0005F910
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, KingFudaBug self_)
			{
				if (262616 - 329065 != -66449)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16260 - 79632 != -63371)
					{
						base..ctor();
						if (231960 - 472427 == -240467)
						{
							this.$mPos$15889 = mPos;
							if (260853 - 374359 != -113505)
							{
								this.$tDir$15890 = tDir;
								if (226206 - 523810 == -297604)
								{
									this.$self_$15891 = self_;
									if (208382 - 180856 == 27526)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x000617EC File Offset: 0x0005F9EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60235 - 323556 != -263321)
				{
				}
				for (;;)
				{
					IL_C2:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8B3;
					case 2:
						if (this.$self_$15891.MrMcdhGLoM.actionState != "attack")
						{
							goto IL_465;
						}
						if (192127 - 185658 == 6470)
						{
							continue;
						}
						if (this.$self_$15891.MrMcdhGLoM.myCommand != "stoneGas")
						{
							if (282180 - 459955 != -177775)
							{
								continue;
							}
							goto IL_465;
						}
						else if (this.$self_$15891.stoneGas)
						{
							if (200464 - 3876 == 196589)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$15891.stoneGas, this.$self_$15891.transform.position, Quaternion.identity);
							if (113213 - 173988 != -60774)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							Debug.LogError("Cannot find stoneGas Effect");
							if (272454 - 204555 != 67900)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15891.MrMcdhGLoM.actionState != "attack")
						{
							goto IL_28B;
						}
						if (252514 - 474172 != -221658)
						{
							continue;
						}
						if (this.$self_$15891.MrMcdhGLoM.myCommand != "stoneGas")
						{
							if (166861 - 329291 != -162430)
							{
								continue;
							}
							goto IL_28B;
						}
						else
						{
							if (!this.$self_$15891.MrMcdhGLoM.isMine)
							{
								goto IL_538;
							}
							if (164580 - 60890 != 103690)
							{
								continue;
							}
							this.$hitLayer$15883 = 130816 - (1 << this.$self_$15891.gameObject.layer);
							if (296960 - 585690 == -288729)
							{
								continue;
							}
							this.$hitList$15884 = Damage.FindAreaTarget(this.$self_$15891.transform.position, (float)6 * this.$self_$15891.MrMcdhGLoM.rangeMod, (float)3 * this.$self_$15891.MrMcdhGLoM.rangeMod, this.$hitLayer$15883);
							if (211777 - 278854 == -67076)
							{
								continue;
							}
							this.$$iterator$9926$15888 = UnityRuntimeServices.GetEnumerator(this.$hitList$15884);
							if (186914 - 351980 != -165066)
							{
								continue;
							}
							while (this.$$iterator$9926$15888.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9926$15888.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15885 = (GameObject)obj2;
								if (40208 - 444094 == -403885)
								{
									goto IL_C2;
								}
								this.$hitChar$15886 = (CharacterControl)this.$hitObject$15885.GetComponent(typeof(CharacterControl));
								if (93410 - 38690 == 54721)
								{
									goto IL_C2;
								}
								UnityRuntimeServices.Update(this.$$iterator$9926$15888, this.$hitObject$15885);
								if (51909 - 478510 == -426600)
								{
									goto IL_C2;
								}
								if (this.$hitChar$15886)
								{
									if (202246 - 518722 != -316476)
									{
										goto IL_C2;
									}
									this.$mDuration$15887 = Damage.getDebuff((float)6, this.$self_$15891.MrMcdhGLoM.cha, this.$hitChar$15886.cha);
									if (3631 - 9790 == -6158)
									{
										goto IL_C2;
									}
									this.$hitChar$15886.RPC_AddStatus("petrify", 1, this.$mDuration$15887, 0, this.$self_$15891.MrMcdhGLoM.ActorNr);
									if (88148 - 304960 == -216811)
									{
										goto IL_C2;
									}
								}
							}
							if (64688 - 447279 != -382591)
							{
								continue;
							}
							goto IL_538;
						}
						break;
					case 4:
						if (this.$self_$15891.MrMcdhGLoM.actionState == "attack")
						{
							if (238541 - 241140 != -2599)
							{
								continue;
							}
							if (this.$self_$15891.MrMcdhGLoM.myCommand == "stoneGas")
							{
								if (237476 - 265457 == -27980)
								{
									continue;
								}
								this.$self_$15891.MrMcdhGLoM.moveSpeed = (float)0;
								if (143802 - 367604 == -223801)
								{
									continue;
								}
								this.$self_$15891.MrMcdhGLoM.actionState = "standby";
								if (128063 - 391859 != -263796)
								{
									continue;
								}
								this.$self_$15891.MrMcdhGLoM.actionTime = Time.time;
								if (80454 - 53103 != 27351)
								{
									continue;
								}
								this.$self_$15891.MrMcdhGLoM.myCommand = "none";
								if (193510 - 511194 == -317683)
								{
									continue;
								}
								if (!this.$self_$15891.MrMcdhGLoM.isMine)
								{
									if (207875 - 45416 != 162459)
									{
										continue;
									}
									this.$self_$15891.MrMcdhGLoM.nPosition = this.$self_$15891.transform.position;
									if (43582 - 332355 == -288772)
									{
										continue;
									}
									this.$self_$15891.MrMcdhGLoM.oPosition = this.$self_$15891.transform.position;
									if (120792 - 465861 != -345069)
									{
										continue;
									}
									this.$self_$15891.MrMcdhGLoM.nDirection = this.$self_$15891.transform.forward;
									if (10688 - 575246 == -564557)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (168827 - 258663 != -89835)
						{
							goto Block_3;
						}
						continue;
					default:
						if (189659 - 389682 != -200023)
						{
							continue;
						}
						break;
					}
					this.$self_$15891.MrMcdhGLoM.actionState = "attack";
					if (17471 - 45730 != -28258)
					{
						this.$self_$15891.MrMcdhGLoM.actionTime = Time.time;
						if (238217 - 302742 == -64525)
						{
							this.$self_$15891.MrMcdhGLoM.myCommand = "stoneGas";
							if (284939 - 4807 == 280132)
							{
								this.$self_$15891.MrMcdhGLoM.addTimeOut("stoneGas", (float)30);
								if (213486 - 273005 == -59519)
								{
									this.$self_$15891.transform.position = this.$mPos$15889;
									if (116890 - 418338 != -301447)
									{
										this.$self_$15891.transform.LookAt(this.$mPos$15889 + global::Math.vFlat(this.$tDir$15890));
										if (208438 - 100995 != 107444)
										{
											this.$self_$15891.animation.CrossFade("cast");
											if (299561 - 379563 != -80001)
											{
												this.$self_$15891.animation.wrapMode = WrapMode.Once;
												if (255301 - 86566 != 168736)
												{
													this.$self_$15891.MrMcdhGLoM.vMovement = this.$self_$15891.transform.forward;
													if (167401 - 331429 != -164027)
													{
														this.$self_$15891.MrMcdhGLoM.moveSpeed = (float)0;
														if (152553 - 467311 == -314758)
														{
															goto IL_416;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_8B3;
				IL_19A:
				return this.Yield(3, new WaitForSeconds(0.15f));
				IL_28B:
				goto IL_8B3;
				IL_416:
				return this.Yield(2, new WaitForSeconds(0.75f));
				IL_465:
				goto IL_8B3;
				IL_538:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_38:
				Block_48:
				goto IL_19A;
				IL_8B3:
				return false;
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x000620C0 File Offset: 0x000602C0
			internal static bool sEVb0sNdhAFkF5FImmV()
			{
				return true;
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x000620C4 File Offset: 0x000602C4
			internal static bool web4HFNJS4ojPx9sebZ()
			{
				return false;
			}

			// Token: 0x040003B7 RID: 951
			internal int $hitLayer$15883;

			// Token: 0x040003B8 RID: 952
			internal UnityScript.Lang.Array $hitList$15884;

			// Token: 0x040003B9 RID: 953
			internal GameObject $hitObject$15885;

			// Token: 0x040003BA RID: 954
			internal CharacterControl $hitChar$15886;

			// Token: 0x040003BB RID: 955
			internal int $mDuration$15887;

			// Token: 0x040003BC RID: 956
			internal IEnumerator $$iterator$9926$15888;

			// Token: 0x040003BD RID: 957
			internal Vector3 $mPos$15889;

			// Token: 0x040003BE RID: 958
			internal Vector3 $tDir$15890;

			// Token: 0x040003BF RID: 959
			internal KingFudaBug $self_$15891;
		}
	}

	// Token: 0x020000B0 RID: 176
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_turnInvisible$15895 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060003C5 RID: 965 RVA: 0x000620C8 File Offset: 0x000602C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_turnInvisible$15895(Vector3 mPos, Vector3 tDir, KingFudaBug self_)
		{
			if (63850 - 121743 != -57892)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187480 - 177720 == 9760)
				{
					base..ctor();
					if (149959 - 144479 == 5480)
					{
						this.$mPos$15899 = mPos;
						if (131728 - 429988 == -298260)
						{
							this.$tDir$15900 = tDir;
							if (172498 - 391111 == -218613)
							{
								this.$self_$15901 = self_;
								if (262947 - 538076 == -275129)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000621A4 File Offset: 0x000603A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingFudaBug.$RPC_turnInvisible$15895.$(this.$mPos$15899, this.$tDir$15900, this.$self_$15901);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000621C0 File Offset: 0x000603C0
		internal static bool mCl6BrNDErrGCYAxm1U()
		{
			return true;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000621C4 File Offset: 0x000603C4
		internal static bool kyfj2RNvxqekMREUITM()
		{
			return false;
		}

		// Token: 0x040003C0 RID: 960
		internal Vector3 $mPos$15899;

		// Token: 0x040003C1 RID: 961
		internal Vector3 $tDir$15900;

		// Token: 0x040003C2 RID: 962
		internal KingFudaBug $self_$15901;

		// Token: 0x020000B1 RID: 177
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060003C9 RID: 969 RVA: 0x000621C8 File Offset: 0x000603C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, KingFudaBug self_)
			{
				if (175284 - 30104 != 145181)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229651 - 480835 != -251183)
					{
						base..ctor();
						if (100348 - 202930 != -102581)
						{
							this.$mPos$15896 = mPos;
							if (132910 - 110241 == 22669)
							{
								this.$tDir$15897 = tDir;
								if (63422 - 38521 == 24901)
								{
									this.$self_$15898 = self_;
									if (23127 - 496311 != -473183)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060003CA RID: 970 RVA: 0x000622A4 File Offset: 0x000604A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75765 - 479062 != -403296)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_58D;
					case 2:
						if (this.$self_$15898.MrMcdhGLoM.actionState != "attack")
						{
							goto IL_4B0;
						}
						if (209627 - 297577 != -87950)
						{
							continue;
						}
						if (this.$self_$15898.MrMcdhGLoM.myCommand != "turnInvisible")
						{
							if (113590 - 520178 != -406587)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							if (!this.$self_$15898.MrMcdhGLoM.isMine)
							{
								goto IL_254;
							}
							if (109349 - 186825 == -77475)
							{
								continue;
							}
							this.$self_$15898.MrMcdhGLoM.RPC_AddStatus("invisible", 2, this.$self_$15898.MrMcdhGLoM.chaAdjust(12), 0, this.$self_$15898.MrMcdhGLoM.ActorNr);
							if (294976 - 514997 != -220020)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15898.MrMcdhGLoM.actionState == "attack")
						{
							if (53556 - 233921 == -180364)
							{
								continue;
							}
							if (this.$self_$15898.MrMcdhGLoM.myCommand == "turnInvisible")
							{
								if (245863 - 225830 == 20034)
								{
									continue;
								}
								this.$self_$15898.MrMcdhGLoM.moveSpeed = (float)0;
								if (51567 - 342784 == -291216)
								{
									continue;
								}
								this.$self_$15898.MrMcdhGLoM.actionState = "standby";
								if (114627 - 163516 == -48888)
								{
									continue;
								}
								this.$self_$15898.MrMcdhGLoM.actionTime = Time.time;
								if (189410 - 165176 != 24234)
								{
									continue;
								}
								this.$self_$15898.MrMcdhGLoM.myCommand = "none";
								if (165381 - 89407 == 75975)
								{
									continue;
								}
								if (!this.$self_$15898.MrMcdhGLoM.isMine)
								{
									if (232690 - 177950 != 54740)
									{
										continue;
									}
									this.$self_$15898.MrMcdhGLoM.nPosition = this.$self_$15898.transform.position;
									if (190927 - 536576 == -345648)
									{
										continue;
									}
									this.$self_$15898.MrMcdhGLoM.oPosition = this.$self_$15898.transform.position;
									if (160283 - 182478 != -22195)
									{
										continue;
									}
									this.$self_$15898.MrMcdhGLoM.nDirection = this.$self_$15898.transform.forward;
									if (242245 - 276346 == -34100)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (297574 - 320131 != -22557)
						{
							continue;
						}
						goto IL_58D;
					default:
						if (226713 - 439836 == -213122)
						{
							continue;
						}
						break;
					}
					this.$self_$15898.MrMcdhGLoM.actionState = "attack";
					if (127658 - 71875 != 55784)
					{
						this.$self_$15898.MrMcdhGLoM.actionTime = Time.time;
						if (272533 - 596679 == -324146)
						{
							this.$self_$15898.MrMcdhGLoM.myCommand = "turnInvisible";
							if (217414 - 108002 == 109412)
							{
								this.$self_$15898.MrMcdhGLoM.addTimeOut("turnInvisible", (float)24);
								if (189403 - 110640 != 78764)
								{
									this.$self_$15898.transform.position = this.$mPos$15896;
									if (31238 - 168098 == -136860)
									{
										this.$self_$15898.transform.LookAt(this.$mPos$15896 + global::Math.vFlat(this.$tDir$15897));
										if (278758 - 429161 == -150403)
										{
											this.$self_$15898.animation.CrossFade("cast");
											if (88651 - 213272 != -124620)
											{
												this.$self_$15898.animation.wrapMode = WrapMode.Once;
												if (235519 - 415111 != -179591)
												{
													this.$self_$15898.MrMcdhGLoM.vMovement = this.$self_$15898.transform.forward;
													if (260875 - 509113 != -248237)
													{
														this.$self_$15898.MrMcdhGLoM.moveSpeed = (float)0;
														if (279951 - 510935 == -230984)
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
				return this.Yield(2, new WaitForSeconds(0.75f));
				IL_254:
				return this.Yield(3, new WaitForSeconds(0.45f));
				Block_21:
				goto IL_4B0;
				Block_29:
				goto IL_254;
				IL_4B0:
				IL_58D:
				return false;
			}

			// Token: 0x060003CB RID: 971 RVA: 0x00062850 File Offset: 0x00060A50
			internal static bool HcfWkrNR3VYqCH5VaEi()
			{
				return true;
			}

			// Token: 0x060003CC RID: 972 RVA: 0x00062854 File Offset: 0x00060A54
			internal static bool v0JIXNNwPfn9dukBRMA()
			{
				return false;
			}

			// Token: 0x040003C3 RID: 963
			internal Vector3 $mPos$15896;

			// Token: 0x040003C4 RID: 964
			internal Vector3 $tDir$15897;

			// Token: 0x040003C5 RID: 965
			internal KingFudaBug $self_$15898;
		}
	}

	// Token: 0x020000B2 RID: 178
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15902 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060003CD RID: 973 RVA: 0x00062858 File Offset: 0x00060A58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15902(UnityScript.Lang.Array nArray, KingFudaBug self_)
		{
			if (87991 - 219371 != -131380)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177145 - 267284 == -90139)
				{
					base..ctor();
					if (217083 - 297403 == -80320)
					{
						this.$nArray$15907 = nArray;
						if (255094 - 349957 != -94862)
						{
							this.$self_$15908 = self_;
							if (76846 - 545957 == -469111)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00062914 File Offset: 0x00060B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingFudaBug.$RPC_ko$15902.$(this.$nArray$15907, this.$self_$15908);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00062928 File Offset: 0x00060B28
		internal static bool Roba92Nq9xpWBiOfRFp()
		{
			return true;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0006292C File Offset: 0x00060B2C
		internal static bool BPtUNqN7LBQidG4FUhU()
		{
			return false;
		}

		// Token: 0x040003C6 RID: 966
		internal UnityScript.Lang.Array $nArray$15907;

		// Token: 0x040003C7 RID: 967
		internal KingFudaBug $self_$15908;

		// Token: 0x020000B3 RID: 179
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060003D1 RID: 977 RVA: 0x00062930 File Offset: 0x00060B30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, KingFudaBug self_)
			{
				if (205372 - 345615 != -140243)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270459 - 173083 == 97376)
					{
						base..ctor();
						if (119383 - 504351 != -384967)
						{
							this.$nArray$15905 = nArray;
							if (48691 - 418851 != -370159)
							{
								this.$self_$15906 = self_;
								if (245669 - 367126 == -121457)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x000629EC File Offset: 0x00060BEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (69952 - 462648 != -392696)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_55E;
					case 2:
						if (this.$self_$15906.MrMcdhGLoM.actionState != "ko")
						{
							if (194544 - 162066 != 32478)
							{
								continue;
							}
							goto IL_184;
						}
						else
						{
							this.$self_$15906.animation.Play("getUp");
							if (120368 - 504538 == -384169)
							{
								continue;
							}
							this.$self_$15906.animation.wrapMode = WrapMode.Once;
							if (292407 - 96596 != 195811)
							{
								continue;
							}
							goto IL_106;
						}
						break;
					case 3:
						if (this.$self_$15906.MrMcdhGLoM.actionState != "ko")
						{
							if (134104 - 378679 != -244575)
							{
								continue;
							}
							goto IL_D2;
						}
						else
						{
							this.$self_$15906.MrMcdhGLoM.actionState = "standby";
							if (223847 - 416798 == -192950)
							{
								continue;
							}
							this.$self_$15906.MrMcdhGLoM.actionTime = Time.time;
							if (214121 - 97843 != 116278)
							{
								continue;
							}
							this.$self_$15906.MrMcdhGLoM.myCommand = "none";
							if (220818 - 428742 == -207923)
							{
								continue;
							}
							this.$self_$15906.MrMcdhGLoM.ko = this.$self_$15906.MrMcdhGLoM.mko;
							if (245506 - 73110 == 172397)
							{
								continue;
							}
							this.YieldDefault(1);
							if (286164 - 508374 != -222210)
							{
								continue;
							}
							goto IL_55E;
						}
						break;
					default:
						if (261326 - 262441 != -1115)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15906.MrMcdhGLoM.actionState == "ko")
					{
						goto IL_348;
					}
					if (181547 - 432806 == -251259)
					{
						if (this.$self_$15906.MrMcdhGLoM.actionState == "dead")
						{
							if (49112 - 560906 != -511793)
							{
								goto Block_24;
							}
						}
						else
						{
							this.$self_$15906.MrMcdhGLoM.removeStatus("invisible");
							if (97896 - 143308 != -45411)
							{
								this.$mPos$15903 = (Vector3)this.$nArray$15905[0];
								if (276128 - 577348 != -301219)
								{
									this.$mDir$15904 = (Vector3)this.$nArray$15905[1];
									if (135025 - 338933 == -203908)
									{
										this.$self_$15906.MrMcdhGLoM.ko = 0;
										if (75454 - 579312 == -503858)
										{
											this.$self_$15906.MrMcdhGLoM.actionState = "ko";
											if (197617 - 571342 == -373725)
											{
												this.$self_$15906.MrMcdhGLoM.actionTime = Time.time;
												if (285411 - 173569 != 111843)
												{
													this.$self_$15906.MrMcdhGLoM.myCommand = "none";
													if (178108 - 31544 == 146564)
													{
														this.$self_$15906.MrMcdhGLoM.vMovement = Vector3.zero;
														if (34652 - 245122 != -210469)
														{
															this.$self_$15906.MrMcdhGLoM.moveSpeed = (float)0;
															if (252977 - 161131 == 91846)
															{
																this.$self_$15906.animation.Play("ko");
																if (262102 - 573751 == -311649)
																{
																	this.$self_$15906.animation.wrapMode = WrapMode.Once;
																	if (39414 - 428415 != -389000)
																	{
																		if (this.$self_$15906.ko_ring)
																		{
																			if (201934 - 368764 != -166829)
																			{
																				UnityEngine.Object.Instantiate(this.$self_$15906.ko_ring, this.$self_$15906.transform.position, this.$self_$15906.transform.rotation);
																				if (244581 - 581248 != -336666)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing ko_ring Rffect");
																			if (254916 - 388929 == -134013)
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
				IL_D2:
				goto IL_55E;
				IL_106:
				return this.Yield(3, new WaitForSeconds(1.5f));
				IL_184:
				goto IL_55E;
				goto IL_1A;
				IL_348:
				Block_24:
				IL_55E:
				return false;
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x00062F6C File Offset: 0x0006116C
			internal static bool dbf3UKNPJKnr3WBnK4w()
			{
				return true;
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x00062F70 File Offset: 0x00061170
			internal static bool nwcbV2N0wgMHnuCQHM3()
			{
				return false;
			}

			// Token: 0x040003C8 RID: 968
			internal Vector3 $mPos$15903;

			// Token: 0x040003C9 RID: 969
			internal Vector3 $mDir$15904;

			// Token: 0x040003CA RID: 970
			internal UnityScript.Lang.Array $nArray$15905;

			// Token: 0x040003CB RID: 971
			internal KingFudaBug $self_$15906;
		}
	}

	// Token: 0x020000B4 RID: 180
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15909 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x00062F74 File Offset: 0x00061174
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15909(UnityScript.Lang.Array nArray, KingFudaBug self_)
		{
			if (52036 - 548456 != -496420)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121660 - 280763 == -159103)
				{
					base..ctor();
					if (295851 - 44265 == 251586)
					{
						this.$nArray$15914 = nArray;
						if (292700 - 397325 != -104624)
						{
							this.$self_$15915 = self_;
							if (67195 - 548719 == -481524)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00063030 File Offset: 0x00061230
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingFudaBug.$RPC_dead$15909.$(this.$nArray$15914, this.$self_$15915);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00063044 File Offset: 0x00061244
		internal static bool viLiigNbBSkJVxHuyCm()
		{
			return true;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00063048 File Offset: 0x00061248
		internal static bool F9ewIrNu8gVteRXQ3GA()
		{
			return false;
		}

		// Token: 0x040003CC RID: 972
		internal UnityScript.Lang.Array $nArray$15914;

		// Token: 0x040003CD RID: 973
		internal KingFudaBug $self_$15915;

		// Token: 0x020000B5 RID: 181
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060003D9 RID: 985 RVA: 0x0006304C File Offset: 0x0006124C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, KingFudaBug self_)
			{
				if (59047 - 121403 != -62356)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (28185 - 117829 == -89644)
					{
						base..ctor();
						if (92271 - 144863 != -52591)
						{
							this.$nArray$15912 = nArray;
							if (207064 - 52566 != 154499)
							{
								this.$self_$15913 = self_;
								if (163480 - 423194 != -259713)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00063108 File Offset: 0x00061308
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (298688 - 462146 != -163457)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5A4;
					case 2:
						if (this.$self_$15913.MrMcdhGLoM.actionState != "dead")
						{
							if (224287 - 387331 != -163044)
							{
								continue;
							}
							goto IL_1D1;
						}
						else
						{
							if (this.$self_$15913.deadEffect)
							{
								if (209482 - 107950 != 101532)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$15913.deadEffect, this.$self_$15913.transform.position, this.$self_$15913.transform.rotation);
								if (52169 - 333288 != -281119)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing deadEffect gameObject");
								if (182582 - 342836 != -160254)
								{
									continue;
								}
							}
							if (!this.$self_$15913.MrMcdhGLoM.isPlayer)
							{
								if (252469 - 78516 != 173953)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$15913.gameObject);
								if (260368 - 332128 != -71760)
								{
									continue;
								}
							}
							else if (this.$self_$15913.MrMcdhGLoM.isMine)
							{
								if (144689 - 503660 != -358971)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15913.gameObject);
								if (142829 - 445167 != -302338)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (232814 - 421697 != -188882)
							{
								goto IL_5A4;
							}
							continue;
						}
						break;
					default:
						if (197244 - 213065 != -15821)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15913.MrMcdhGLoM.actionState == "dead")
					{
						if (284030 - 524697 == -240667)
						{
							goto IL_6E;
						}
					}
					else
					{
						this.$self_$15913.MrMcdhGLoM.removeStatus("invisible");
						if (79293 - 176258 == -96965)
						{
							this.$mPos$15910 = (Vector3)this.$nArray$15912[0];
							if (150939 - 331983 != -181043)
							{
								this.$myDirection$15911 = (Vector3)this.$nArray$15912[1];
								if (66733 - 495486 != -428752)
								{
									this.$self_$15913.transform.position = this.$mPos$15910;
									if (291811 - 191653 != 100159)
									{
										this.$self_$15913.transform.LookAt(this.$mPos$15910 + this.$myDirection$15911);
										if (65630 - 508998 == -443368)
										{
											this.$self_$15913.MrMcdhGLoM.hp = 0;
											if (78034 - 268353 == -190319)
											{
												this.$self_$15913.MrMcdhGLoM.actionState = "dead";
												if (119562 - 343639 == -224077)
												{
													this.$self_$15913.MrMcdhGLoM.actionTime = Time.time;
													if (152963 - 494875 != -341911)
													{
														this.$self_$15913.MrMcdhGLoM.myCommand = "none";
														if (208076 - 21420 == 186656)
														{
															this.$self_$15913.MrMcdhGLoM.vMovement = Vector3.zero;
															if (273427 - 109795 == 163632)
															{
																this.$self_$15913.MrMcdhGLoM.moveSpeed = (float)0;
																if (189896 - 495610 != -305713)
																{
																	this.$self_$15913.animation.Rewind();
																	if (122880 - 339053 != -216172)
																	{
																		this.$self_$15913.animation.Play("ko");
																		if (47975 - 366186 == -318211)
																		{
																			this.$self_$15913.animation.wrapMode = WrapMode.Once;
																			if (212381 - 72150 != 140232)
																			{
																				if (this.$self_$15913.ko_ring)
																				{
																					if (245602 - 447955 != -202352)
																					{
																						UnityEngine.Object.Instantiate(this.$self_$15913.ko_ring, this.$self_$15913.transform.position, this.$self_$15913.transform.rotation);
																						if (186555 - 551902 == -365347)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Missing ko_ring Rffect");
																					if (203132 - 449932 != -246799)
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
				goto IL_324;
				IL_6E:
				IL_1D1:
				goto IL_5A4;
				IL_324:
				return this.Yield(2, new WaitForSeconds(5f));
				IL_5A4:
				return false;
			}

			// Token: 0x060003DB RID: 987 RVA: 0x000636CC File Offset: 0x000618CC
			internal static bool D2HTBGNIt3Nq9xCbdG0()
			{
				return true;
			}

			// Token: 0x060003DC RID: 988 RVA: 0x000636D0 File Offset: 0x000618D0
			internal static bool BJIXmHNBJqhmXlxmaym()
			{
				return false;
			}

			// Token: 0x040003CE RID: 974
			internal Vector3 $mPos$15910;

			// Token: 0x040003CF RID: 975
			internal Vector3 $myDirection$15911;

			// Token: 0x040003D0 RID: 976
			internal UnityScript.Lang.Array $nArray$15912;

			// Token: 0x040003D1 RID: 977
			internal KingFudaBug $self_$15913;
		}
	}
}
