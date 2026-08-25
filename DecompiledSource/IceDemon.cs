using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020002F2 RID: 754
[Serializable]
public class IceDemon : MonoBehaviour
{
	// Token: 0x06001121 RID: 4385 RVA: 0x001B1DB0 File Offset: 0x001AFFB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IceDemon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x001B1DC0 File Offset: 0x001AFFC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (234663 - 531011 != -296348)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (121144 - 206804 != -85659)
			{
				this.mChar.actionState = "standby";
				if (240692 - 396052 != -155359)
				{
					this.mChar.actionTime = Time.time;
					if (103131 - 422345 != -319213)
					{
						this.mChar.myCommand = "none";
						if (278646 - 446128 == -167482)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
							{
								"ice",
								"frost",
								"snowMan",
								"snowBall"
							});
							if (92636 - 365130 == -272494)
							{
								this.mChar.hp = (this.mChar.mhp = 7000);
								if (261605 - 575635 == -314030)
								{
									this.mChar.ko = (this.mChar.mko = 70);
									if (42693 - 73818 != -31124)
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

	// Token: 0x06001123 RID: 4387 RVA: 0x001B1F68 File Offset: 0x001B0168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x001B1F84 File Offset: 0x001B0184
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (30417 - 213558 != -183140)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (119977 - 508649 != -388672)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (131708 - 65078 == 66631)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_4E;
					}
					if (64813 - 239065 != -174252)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (272243 - 399363 == -127119)
				{
					continue;
				}
			}
			IL_4E:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (254345 - 418132 == -163787)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (190308 - 111998 != 78311)
				{
					if (this.mChar.isMine)
					{
						if (130707 - 527499 == -396792)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (151203 - 379727 == -228524)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (8313 - 415949 == -407636)
								{
									this.mChar.DeadEvent();
									if (35777 - 507163 != -471385)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (251735 - 573137 == -321402)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x001B21C4 File Offset: 0x001B03C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (139309 - 430151 != -290841)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (169180 - 531088 != -361907)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (185521 - 595957 != -410435)
				{
					if (183841 - 292241 == -108400)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (67953 - 383572 != -315619)
							{
								continue;
							}
							v = 1;
							if (285927 - 108966 == 176962)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (241619 - 496371 != -254752)
							{
								continue;
							}
							v = -1;
							if (97580 - 546464 == -448883)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_manaBurn")
						{
							if (130041 - 58783 == 71259)
							{
								continue;
							}
							v = 11;
							if (81925 - 348156 != -266231)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_manaBurn_hit")
						{
							if (139828 - 272661 == -132832)
							{
								continue;
							}
							v = -11;
							if (45350 - 524750 != -479400)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_blink")
						{
							if (230000 - 273618 == -43617)
							{
								continue;
							}
							v = 21;
							if (47369 - 485385 != -438016)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_absoluteZero")
						{
							if (142109 - 114932 == 27178)
							{
								continue;
							}
							v = 31;
							if (293270 - 378930 == -85659)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_absoluteZero_hit")
						{
							if (13155 - 599668 != -586513)
							{
								continue;
							}
							v = -31;
							if (90893 - 322638 == -231744)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (78682 - 335321 != -256639)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (147995 - 74687 != 73309)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (281961 - 524225 != -242263)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (183833 - 427050 != -243216)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (126263 - 36009 != 90255)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (230731 - 211797 != 18935)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (180499 - 295972 == -115473)
											{
												Hashtable hashtable = new Hashtable();
												if (247822 - 297400 == -49578)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (193275 - 440215 != -246939)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (216879 - 263056 == -46177)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (133691 - 212265 != -78573)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (126260 - 418614 == -292354)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (245256 - 176639 != 68618)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (260639 - 165419 != 95221)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (86899 - 510061 == -423162)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (10610 - 298169 != -287558)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (93518 - 94643 == -1125)
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

	// Token: 0x06001126 RID: 4390 RVA: 0x001B27C0 File Offset: 0x001B09C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (250918 - 354568 != -103650)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (61159 - 43673 != 17487)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (141289 - 471920 == -330631)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (208810 - 154830 == 53980)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (268230 - 104114 != 164117)
						{
							int num3 = num;
							if (123246 - 345679 != -222432)
							{
								if (num3 == 1)
								{
									if (221078 - 318864 == -97786)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (63975 - 414801 == -350826)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (130387 - 538497 != -408109)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (211081 - 468414 == -257333)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (172367 - 513971 != -341603)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (85482 - 248890 == -163408)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (238902 - 46166 == 192736)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (280162 - 457039 == -176877)
										{
											this.StartCoroutine_Auto(this.RPC_manaBurn(vector, vector2, num2));
											if (24210 - 245606 != -221395)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (179889 - 476092 == -296203)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (160437 - 61042 == 99395)
										{
											this.StartCoroutine_Auto(this.RPC_manaBurn_hit(vector, vector2, num2));
											if (7019 - 481961 == -474942)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (60661 - 517732 == -457071)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (297733 - 494267 != -196533)
										{
											this.StartCoroutine_Auto(this.RPC_blink(vector, vector2, num2));
											if (41967 - 214574 != -172606)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (274006 - 424572 == -150566)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (286231 - 338251 == -52020)
										{
											this.StartCoroutine_Auto(this.RPC_absoluteZero(vector, vector2, num2));
											if (230155 - 120915 != 109241)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -31)
								{
									if (74575 - 478007 != -403431)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (145995 - 208097 != -62101)
										{
											this.StartCoroutine_Auto(this.RPC_absoluteZero_hit(vector, vector2, num2));
											if (290927 - 103505 != 187423)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (58674 - 512628 != -453953)
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

	// Token: 0x06001127 RID: 4391 RVA: 0x001B2CC0 File Offset: 0x001B0EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (266806 - 261429 != 5377)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (128291 - 552185 != -423893)
			{
				float runSpeed = this.mChar.runSpeed;
				if (257231 - 288431 == -31200)
				{
					Vector3 a = default(Vector3);
					if (131596 - 383756 != -252159)
					{
						Vector3 vector = Vector3.zero;
						if (170312 - 443444 != -273131)
						{
							float num2 = (float)0;
							if (269274 - 522105 == -252831)
							{
								if (this.mChar.isMine)
								{
									if (256934 - 1514 != 255420)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (220487 - 242820 != -22333)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (159777 - 13433 == 146345)
										{
											continue;
										}
										a.y = (float)0;
										if (279086 - 507956 != -228870)
										{
											continue;
										}
										a = a.normalized;
										if (134214 - 390828 == -256613)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (209024 - 593740 != -384716)
										{
											continue;
										}
										vector = vector.normalized;
										if (269632 - 384553 == -114920)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (178294 - 487205 != -308911)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (163272 - 137765 != 25507)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (168038 - 356484 == -188445)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (258913 - 277466 != -18553)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (276005 - 425381 == -149375)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (90476 - 347541 != -257065)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (66931 - 493063 != -426132)
														{
															continue;
														}
														this.animation.Play("run");
														if (81292 - 351865 == -270572)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (117380 - 499161 != -381781)
														{
															continue;
														}
														goto IL_A68;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (240568 - 581575 == -341006)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (259727 - 204027 != 55700)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (187239 - 189901 != -2662)
											{
												continue;
											}
											num = (float)0;
											if (196670 - 3824 == 192847)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (26459 - 102664 == -76204)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (282228 - 165353 == 116876)
										{
											continue;
										}
									}
									IL_A68:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (148221 - 82932 == 65290)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (244760 - 268595 == -23834)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (87585 - 294048 == -206462)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (115896 - 456250 != -340354)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (248038 - 371505 == -123466)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (57572 - 391312 == -333739)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (271856 - 488619 == -216762)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (30170 - 75958 != -45788)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (148927 - 342064 == -193136)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (283858 - 75394 != 208464)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (108397 - 227352 == -118954)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (70290 - 361778 == -291487)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (259378 - 146405 != 112973)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (114106 - 31430 == 82677)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (42959 - 443541 != -400582)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (4541 - 229806 != -225265)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (70240 - 131537 == -61296)
												{
													continue;
												}
												num = (float)0;
												if (154735 - 148952 == 5784)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (134866 - 386534 != -251668)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (147467 - 446289 != -298822)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (44341 - 558881 == -514539)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (284108 - 238638 == 45471)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (33437 - 254217 == -220779)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (118616 - 141905 != -23289)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (155235 - 77416 != 77819)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (46255 - 72264 == -26008)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (198556 - 177784 == 20773)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (195368 - 272780 != -77412)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (156170 - 347383 != -191213)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (217921 - 68899 != 149022)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (45176 - 121201 == -76024)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (98279 - 43128 == 55152)
											{
												continue;
											}
											num = (float)0;
											if (108632 - 533013 != -424381)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (40766 - 539828 != -499062)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (158750 - 548305 == -389554)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (111562 - 237211 != -125649)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (217187 - 298273 == -81085)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (206233 - 443397 == -237164)
								{
									this.mChar.moveSpeed = num;
									if (82880 - 24977 == 57903)
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

	// Token: 0x06001128 RID: 4392 RVA: 0x001B3824 File Offset: 0x001B1A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (264287 - 272036 != -7749)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (293400 - 109408 == 183992)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (227651 - 470726 == -243075)
				{
					Vector3 vector = a - this.transform.position;
					if (18901 - 473347 == -454446)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (186281 - 321563 == -135282)
						{
							CharacterControl characterControl = null;
							if (87391 - 287720 == -200329)
							{
								if (199184 - 272723 != -73538)
								{
									if (gameObject)
									{
										if (279557 - 313540 == -33982)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (44632 - 440422 == -395789)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (203584 - 139708 == 63877)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (79152 - 83101 != -3949)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (180540 - 301041 != -120501)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (200282 - 178517 == 21766)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (231382 - 107469 != 123914)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (116703 - 125129 != -8425)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (160821 - 212806 == -51985)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (131745 - 57664 != 74082)
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

	// Token: 0x06001129 RID: 4393 RVA: 0x001B3B1C File Offset: 0x001B1D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (24258 - 453302 != -429044)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (84456 - 461385 != -376928)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (204392 - 244173 != -39780)
				{
					Vector3 vector = a - this.transform.position;
					if (31823 - 536315 != -504491)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (106852 - 297181 == -190329)
						{
							CharacterControl characterControl = null;
							if (169080 - 432681 != -263600)
							{
								int tID = 0;
								if (174522 - 159574 == 14948)
								{
									if (gameObject)
									{
										if (127813 - 373967 == -246153)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (157052 - 232873 == -75820)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (259578 - 299802 != -40224)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (207618 - 230048 != -22430)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (37379 - 582844 == -545464)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (226484 - 569984 != -343500)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("blink") == (float)0)
									{
										if (156037 - 240375 != -84337)
										{
											this.StartCoroutine_Auto(this.RPC_blink(this.transform.position, vector, 0));
											if (78652 - 563343 != -484690)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (145664 - 491002 == -345338)
												{
													this.ActionEvent("RPC_blink", this.transform.position, vector, 0);
													if (104796 - 156468 == -51672)
													{
														break;
													}
												}
											}
										}
									}
									else if (this.mChar.isTimeOut("manaBurn") == (float)0)
									{
										if (25515 - 84670 != -59154)
										{
											this.StartCoroutine_Auto(this.RPC_manaBurn(this.transform.position, vector, tID));
											if (18994 - 100338 != -81343)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (21824 - 395653 != -373828)
												{
													this.ActionEvent("RPC_manaBurn", this.transform.position, vector, tID);
													if (191553 - 180233 == 11320)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										if (this.mChar.isTimeOut("absoluteZero") != (float)0)
										{
											break;
										}
										if (167215 - 317266 == -150051)
										{
											this.StartCoroutine_Auto(this.RPC_absoluteZero(this.transform.position, vector, tID));
											if (86004 - 154265 == -68261)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (128062 - 138668 != -10605)
												{
													this.ActionEvent("RPC_absoluteZero", this.transform.position, vector, tID);
													if (39186 - 263745 == -224559)
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

	// Token: 0x0600112A RID: 4394 RVA: 0x001B3F98 File Offset: 0x001B2198
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x001B3F9C File Offset: 0x001B219C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceDemon.$RPC_nAttack$18214(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x001B3FAC File Offset: 0x001B21AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x001B3FD8 File Offset: 0x001B21D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_manaBurn(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceDemon.$RPC_manaBurn$18227(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x001B3FE8 File Offset: 0x001B21E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_manaBurn_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new IceDemon.$RPC_manaBurn_hit$18238(hitPos, this).GetEnumerator();
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x001B3FF8 File Offset: 0x001B21F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_blink(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceDemon.$RPC_blink$18248(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x001B4008 File Offset: 0x001B2208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_absoluteZero(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceDemon.$RPC_absoluteZero$18262(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x001B4018 File Offset: 0x001B2218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_absoluteZero_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new IceDemon.$RPC_absoluteZero_hit$18273(hitPos, this).GetEnumerator();
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x001B4028 File Offset: 0x001B2228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new IceDemon.$RPC_dead$18282(nArray, this).GetEnumerator();
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x001B4038 File Offset: 0x001B2238
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x001B403C File Offset: 0x001B223C
	internal static bool mDeJE48yeJTtmNYJ2a4()
	{
		return true;
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x001B4040 File Offset: 0x001B2240
	internal static bool yd1Gfo8SHOuKJQuL9BB()
	{
		return false;
	}

	// Token: 0x04000EFE RID: 3838
	public CharacterControl mChar;

	// Token: 0x04000EFF RID: 3839
	public GameObject nAttack_ring;

	// Token: 0x04000F00 RID: 3840
	public GameObject nAttack_hit;

	// Token: 0x04000F01 RID: 3841
	public GameObject cast_ring;

	// Token: 0x04000F02 RID: 3842
	public GameObject manaBurn_hit;

	// Token: 0x04000F03 RID: 3843
	public GameObject blink;

	// Token: 0x04000F04 RID: 3844
	public GameObject absoluteZero_hit;

	// Token: 0x04000F05 RID: 3845
	public GameObject deadEffect;

	// Token: 0x020002F3 RID: 755
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$18214 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001136 RID: 4406 RVA: 0x001B4044 File Offset: 0x001B2244
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$18214(Vector3 mPos, Vector3 tDir, IceDemon self_)
		{
			if (18940 - 179548 != -160608)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (261583 - 305045 == -43462)
				{
					base..ctor();
					if (161387 - 548847 != -387459)
					{
						this.$mPos$18224 = mPos;
						if (58231 - 10050 != 48182)
						{
							this.$tDir$18225 = tDir;
							if (156872 - 119364 == 37508)
							{
								this.$self_$18226 = self_;
								if (61204 - 213594 != -152389)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x001B4120 File Offset: 0x001B2320
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceDemon.$RPC_nAttack$18214.$(this.$mPos$18224, this.$tDir$18225, this.$self_$18226);
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x001B413C File Offset: 0x001B233C
		internal static bool v5Pc738oiQNkr4fT7d2()
		{
			return true;
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x001B4140 File Offset: 0x001B2340
		internal static bool DeFyk68EQH9TaVa8C3R()
		{
			return false;
		}

		// Token: 0x04000F06 RID: 3846
		internal Vector3 $mPos$18224;

		// Token: 0x04000F07 RID: 3847
		internal Vector3 $tDir$18225;

		// Token: 0x04000F08 RID: 3848
		internal IceDemon $self_$18226;

		// Token: 0x020002F4 RID: 756
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600113A RID: 4410 RVA: 0x001B4144 File Offset: 0x001B2344
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IceDemon self_)
			{
				if (275720 - 8417 != 267303)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (29992 - 417523 != -387530)
					{
						base..ctor();
						if (200413 - 268208 != -67794)
						{
							this.$mPos$18221 = mPos;
							if (238530 - 171957 == 66573)
							{
								this.$tDir$18222 = tDir;
								if (225823 - 198676 != 27148)
								{
									this.$self_$18223 = self_;
									if (18383 - 191429 == -173046)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600113B RID: 4411 RVA: 0x001B4220 File Offset: 0x001B2420
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193023 - 272311 != -79287)
				{
				}
				for (;;)
				{
					IL_6AF:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_913;
					case 2:
						if (this.$self_$18223.mChar.actionState != "attack")
						{
							goto IL_53D;
						}
						if (224670 - 157942 == 66729)
						{
							continue;
						}
						if (this.$self_$18223.mChar.myCommand != "nAttack")
						{
							if (11931 - 275169 != -263237)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							if (this.$self_$18223.nAttack_ring)
							{
								if (206352 - 471866 == -265513)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$18223.nAttack_ring, this.$self_$18223.transform.position, this.$self_$18223.transform.rotation);
								if (33077 - 74960 != -41883)
								{
									continue;
								}
							}
							this.$i$18215 = 1;
							if (22886 - 454143 != -431256)
							{
								goto IL_4BC;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18223.mChar.actionState != "attack")
						{
							goto IL_37D;
						}
						if (2768 - 105569 == -102800)
						{
							continue;
						}
						if (this.$self_$18223.mChar.myCommand != "nAttack")
						{
							if (98603 - 417269 != -318666)
							{
								continue;
							}
							goto IL_37D;
						}
						else
						{
							if (this.$self_$18223.mChar.isMine)
							{
								if (109906 - 97082 != 12824)
								{
									continue;
								}
								this.$hitLayer$18216 = 130816 - (1 << this.$self_$18223.gameObject.layer);
								if (239678 - 516668 != -276990)
								{
									continue;
								}
								this.$hitList$18217 = Damage.FindAreaTarget(this.$self_$18223.transform.position, (float)(2 * this.$i$18215 + 2), (float)4, this.$hitLayer$18216);
								if (150579 - 284409 != -133830)
								{
									continue;
								}
								this.$$iterator$10456$18220 = UnityRuntimeServices.GetEnumerator(this.$hitList$18217);
								if (16816 - 288251 == -271434)
								{
									continue;
								}
								while (this.$$iterator$10456$18220.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10456$18220.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$18218 = (GameObject)obj2;
									if (78417 - 300656 != -222239)
									{
										goto IL_6AF;
									}
									if (this.$self_$18223.mChar.hit(1, this.$hitObject$18218, this.$self_$18223.mChar.atk, 5, 0, Vector3.zero) != 0)
									{
										if (29764 - 36926 == -7161)
										{
											goto IL_6AF;
										}
										this.$hitPos$18219 = this.$hitObject$18218.collider.ClosestPointOnBounds(this.$self_$18223.transform.position + Vector3.up);
										if (88896 - 233877 != -144981)
										{
											goto IL_6AF;
										}
										UnityRuntimeServices.Update(this.$$iterator$10456$18220, this.$hitObject$18218);
										if (187985 - 124962 == 63024)
										{
											goto IL_6AF;
										}
										this.$self_$18223.RPC_nAttack_hit(this.$hitPos$18219, this.$self_$18223.transform.forward, 0);
										if (245898 - 146999 == 98900)
										{
											goto IL_6AF;
										}
										if (PhotonClient.IsInitialized())
										{
											if (214702 - 482494 != -267792)
											{
												goto IL_6AF;
											}
											this.$self_$18223.ActionEvent("RPC_nAttack_hit", this.$hitPos$18219, this.$self_$18223.transform.forward, 0);
											if (194285 - 377997 == -183711)
											{
												goto IL_6AF;
											}
										}
									}
								}
								if (54292 - 510669 != -456377)
								{
									continue;
								}
							}
							this.$i$18215++;
							if (119231 - 544338 != -425106)
							{
								goto IL_4BC;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$18223.mChar.actionState == "attack")
						{
							if (49352 - 103750 == -54397)
							{
								continue;
							}
							if (this.$self_$18223.mChar.myCommand == "nAttack")
							{
								if (129763 - 405140 != -275377)
								{
									continue;
								}
								this.$self_$18223.mChar.actionState = "standby";
								if (204518 - 57404 != 147114)
								{
									continue;
								}
								this.$self_$18223.mChar.actionTime = Time.time;
								if (246554 - 192056 == 54499)
								{
									continue;
								}
								this.$self_$18223.mChar.myCommand = "none";
								if (217800 - 186426 != 31374)
								{
									continue;
								}
								if (!this.$self_$18223.mChar.isMine)
								{
									if (142893 - 65073 != 77820)
									{
										continue;
									}
									this.$self_$18223.mChar.nPosition = this.$self_$18223.transform.position;
									if (56369 - 117283 == -60913)
									{
										continue;
									}
									this.$self_$18223.mChar.oPosition = this.$self_$18223.transform.position;
									if (91743 - 410625 == -318881)
									{
										continue;
									}
									this.$self_$18223.mChar.nDirection = this.$self_$18223.transform.forward;
									if (277673 - 558818 != -281145)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (52477 - 202339 != -149862)
						{
							continue;
						}
						goto IL_913;
					default:
						if (86978 - 213824 != -126846)
						{
							continue;
						}
						break;
					}
					this.$self_$18223.mChar.actionState = "attack";
					if (244510 - 219316 == 25195)
					{
						continue;
					}
					this.$self_$18223.mChar.actionTime = Time.time;
					if (290245 - 52417 != 237828)
					{
						continue;
					}
					this.$self_$18223.mChar.myCommand = "nAttack";
					if (249852 - 176662 != 73190)
					{
						continue;
					}
					this.$self_$18223.mChar.addTimeOut("nAttack", (float)6);
					if (116333 - 72304 != 44029)
					{
						continue;
					}
					this.$self_$18223.transform.position = this.$mPos$18221;
					if (161905 - 459258 == -297352)
					{
						continue;
					}
					this.$self_$18223.transform.LookAt(this.$mPos$18221 + global::Math.vFlat(this.$tDir$18222));
					if (26198 - 509370 == -483171)
					{
						continue;
					}
					this.$self_$18223.animation.CrossFade("nAttack");
					if (37344 - 490367 != -453023)
					{
						continue;
					}
					this.$self_$18223.animation.wrapMode = WrapMode.Once;
					if (270538 - 21047 != 249491)
					{
						continue;
					}
					this.$self_$18223.mChar.vMovement = this.$self_$18223.transform.forward;
					if (82092 - 153176 == -71083)
					{
						continue;
					}
					this.$self_$18223.mChar.moveSpeed = (float)0;
					if (165444 - 378488 != -213044)
					{
						continue;
					}
					break;
					IL_4BC:
					if (this.$i$18215 <= 2)
					{
						goto IL_8C4;
					}
					if (145969 - 555266 != -409296)
					{
						goto Block_32;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_37D:
				goto IL_913;
				Block_32:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_53D:
				goto IL_913;
				Block_50:
				goto IL_53D;
				IL_8C4:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_913:
				return false;
			}

			// Token: 0x0600113C RID: 4412 RVA: 0x001B4B54 File Offset: 0x001B2D54
			internal static bool c10K3082mbmd69hMdTN()
			{
				return true;
			}

			// Token: 0x0600113D RID: 4413 RVA: 0x001B4B58 File Offset: 0x001B2D58
			internal static bool JhAGnt88hGGgLIqCR15()
			{
				return false;
			}

			// Token: 0x04000F09 RID: 3849
			internal int $i$18215;

			// Token: 0x04000F0A RID: 3850
			internal int $hitLayer$18216;

			// Token: 0x04000F0B RID: 3851
			internal UnityScript.Lang.Array $hitList$18217;

			// Token: 0x04000F0C RID: 3852
			internal GameObject $hitObject$18218;

			// Token: 0x04000F0D RID: 3853
			internal Vector3 $hitPos$18219;

			// Token: 0x04000F0E RID: 3854
			internal IEnumerator $$iterator$10456$18220;

			// Token: 0x04000F0F RID: 3855
			internal Vector3 $mPos$18221;

			// Token: 0x04000F10 RID: 3856
			internal Vector3 $tDir$18222;

			// Token: 0x04000F11 RID: 3857
			internal IceDemon $self_$18223;
		}
	}

	// Token: 0x020002F5 RID: 757
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_manaBurn$18227 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600113E RID: 4414 RVA: 0x001B4B5C File Offset: 0x001B2D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_manaBurn$18227(Vector3 mPos, Vector3 tDir, int tID, IceDemon self_)
		{
			if (97725 - 491420 != -393694)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (245294 - 389608 != -144313)
				{
					base..ctor();
					if (296686 - 393042 != -96355)
					{
						this.$mPos$18234 = mPos;
						if (34835 - 304852 == -270017)
						{
							this.$tDir$18235 = tDir;
							if (125804 - 392411 == -266607)
							{
								this.$tID$18236 = tID;
								if (108158 - 535196 == -427038)
								{
									this.$self_$18237 = self_;
									if (21685 - 43797 != -22111)
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

		// Token: 0x0600113F RID: 4415 RVA: 0x001B4C5C File Offset: 0x001B2E5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceDemon.$RPC_manaBurn$18227.$(this.$mPos$18234, this.$tDir$18235, this.$tID$18236, this.$self_$18237);
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x001B4C7C File Offset: 0x001B2E7C
		internal static bool iqnKWQ8ZifIVPv1XbdF()
		{
			return true;
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x001B4C80 File Offset: 0x001B2E80
		internal static bool gpDbxh8C8UEK1PWNT7a()
		{
			return false;
		}

		// Token: 0x04000F12 RID: 3858
		internal Vector3 $mPos$18234;

		// Token: 0x04000F13 RID: 3859
		internal Vector3 $tDir$18235;

		// Token: 0x04000F14 RID: 3860
		internal int $tID$18236;

		// Token: 0x04000F15 RID: 3861
		internal IceDemon $self_$18237;

		// Token: 0x020002F6 RID: 758
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001142 RID: 4418 RVA: 0x001B4C84 File Offset: 0x001B2E84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, IceDemon self_)
			{
				if (65773 - 131249 != -65475)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (226617 - 589465 == -362848)
					{
						base..ctor();
						if (120300 - 404281 != -283980)
						{
							this.$mPos$18230 = mPos;
							if (181337 - 443212 != -261874)
							{
								this.$tDir$18231 = tDir;
								if (17867 - 281540 == -263673)
								{
									this.$tID$18232 = tID;
									if (276165 - 66039 != 210127)
									{
										this.$self_$18233 = self_;
										if (79163 - 530865 == -451702)
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

			// Token: 0x06001143 RID: 4419 RVA: 0x001B4D84 File Offset: 0x001B2F84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280882 - 540769 != -259886)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8DA;
					case 2:
						if (this.$self_$18233.mChar.actionState != "attack")
						{
							goto IL_73C;
						}
						if (100095 - 306755 != -206660)
						{
							continue;
						}
						if (this.$self_$18233.mChar.myCommand != "manaBurn")
						{
							if (46920 - 106432 != -59511)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18233.cast_ring)
							{
								goto IL_90;
							}
							if (265824 - 311004 != -45180)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$18233.cast_ring, this.$self_$18233.transform.position, this.$self_$18233.transform.rotation);
							if (293688 - 394346 != -100658)
							{
								continue;
							}
							goto IL_90;
						}
						break;
					case 3:
						if (this.$self_$18233.mChar.actionState != "attack")
						{
							goto IL_4BF;
						}
						if (291312 - 545086 != -253774)
						{
							continue;
						}
						if (this.$self_$18233.mChar.myCommand != "manaBurn")
						{
							if (183779 - 501332 != -317552)
							{
								goto Block_53;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18233.mChar.isMine)
							{
								goto IL_7AF;
							}
							if (261083 - 512377 != -251294)
							{
								continue;
							}
							this.$firePos$18228 = this.$mPos$18230 + this.$tDir$18231;
							if (38225 - 401053 == -362827)
							{
								continue;
							}
							if (this.$tID$18232 == 0)
							{
								goto IL_224;
							}
							if (283256 - 81955 != 201301)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18232];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$18229 = (GameObject)obj2;
							if (56564 - 271423 == -214858)
							{
								continue;
							}
							if (!this.$tObject$18229)
							{
								goto IL_224;
							}
							if (268086 - 568969 != -300883)
							{
								continue;
							}
							this.$firePos$18228 = this.$tObject$18229.transform.position;
							if (203014 - 251907 != -48893)
							{
								continue;
							}
							goto IL_224;
						}
						break;
					case 4:
						if (this.$self_$18233.mChar.actionState != "attack")
						{
							goto IL_1B3;
						}
						if (181598 - 520710 != -339112)
						{
							continue;
						}
						if (this.$self_$18233.mChar.myCommand != "manaBurn")
						{
							if (156091 - 399028 != -242936)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$18233.StartCoroutine_Auto(this.$self_$18233.RPC_manaBurn_hit(this.$firePos$18228, Vector3.forward, 0));
							if (29886 - 22864 == 7023)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_7AA;
							}
							if (13397 - 48565 != -35168)
							{
								continue;
							}
							this.$self_$18233.ActionEvent("RPC_manaBurn_hit", this.$firePos$18228, Vector3.forward, 0);
							if (282451 - 331008 != -48556)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$18233.mChar.actionState != "attack")
						{
							goto IL_886;
						}
						if (141782 - 436711 == -294928)
						{
							continue;
						}
						if (!(this.$self_$18233.mChar.myCommand != "manaBurn"))
						{
							goto IL_88B;
						}
						if (122959 - 579409 != -456450)
						{
							continue;
						}
						goto IL_886;
					case 6:
						if (this.$self_$18233.mChar.actionState == "attack")
						{
							if (90104 - 159051 != -68947)
							{
								continue;
							}
							if (this.$self_$18233.mChar.myCommand == "manaBurn")
							{
								if (278972 - 445969 == -166996)
								{
									continue;
								}
								this.$self_$18233.mChar.actionState = "standby";
								if (141462 - 532574 == -391111)
								{
									continue;
								}
								this.$self_$18233.mChar.actionTime = Time.time;
								if (238385 - 26180 == 212206)
								{
									continue;
								}
								this.$self_$18233.mChar.myCommand = "none";
								if (165318 - 89456 == 75863)
								{
									continue;
								}
								if (!this.$self_$18233.mChar.isMine)
								{
									if (20900 - 36479 == -15578)
									{
										continue;
									}
									this.$self_$18233.mChar.nPosition = this.$self_$18233.transform.position;
									if (105092 - 537569 == -432476)
									{
										continue;
									}
									this.$self_$18233.mChar.oPosition = this.$self_$18233.transform.position;
									if (110802 - 246102 == -135299)
									{
										continue;
									}
									this.$self_$18233.mChar.nDirection = this.$self_$18233.transform.forward;
									if (264445 - 502465 == -238019)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (242289 - 242710 != -421)
						{
							continue;
						}
						goto IL_8DA;
					default:
						if (168394 - 71959 == 96436)
						{
							continue;
						}
						break;
					}
					this.$self_$18233.mChar.actionState = "attack";
					if (273453 - 573187 != -299733)
					{
						this.$self_$18233.mChar.actionTime = Time.time;
						if (12308 - 86695 != -74386)
						{
							this.$self_$18233.mChar.myCommand = "manaBurn";
							if (138527 - 289410 == -150883)
							{
								this.$self_$18233.mChar.addTimeOut("manaBurn", (float)6);
								if (211740 - 259353 == -47613)
								{
									this.$self_$18233.transform.position = this.$mPos$18230;
									if (254694 - 52105 == 202589)
									{
										this.$self_$18233.transform.LookAt(this.$mPos$18230 + global::Math.vFlat(this.$tDir$18231));
										if (41765 - 182634 != -140868)
										{
											this.$self_$18233.animation.CrossFade("cast");
											if (282669 - 480176 == -197507)
											{
												this.$self_$18233.animation.wrapMode = WrapMode.Once;
												if (50932 - 252410 == -201478)
												{
													this.$self_$18233.mChar.vMovement = this.$self_$18233.transform.forward;
													if (172099 - 24520 == 147579)
													{
														this.$self_$18233.mChar.moveSpeed = (float)0;
														if (19449 - 216711 == -197262)
														{
															goto IL_273;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_90:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_1B3:
				goto IL_8DA;
				IL_224:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_273:
				return this.Yield(2, new WaitForSeconds(0.7f));
				Block_21:
				goto IL_1B3;
				Block_27:
				goto IL_7AA;
				IL_4BF:
				Block_38:
				IL_73C:
				goto IL_8DA;
				IL_7AA:
				goto IL_88B;
				IL_7AF:
				return this.Yield(5, new WaitForSeconds(0.1f));
				Block_53:
				IL_886:
				goto IL_8DA;
				IL_88B:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_8DA:
				return false;
			}

			// Token: 0x06001144 RID: 4420 RVA: 0x001B5680 File Offset: 0x001B3880
			internal static bool R4yfdU8LRk76DBXSm4r()
			{
				return true;
			}

			// Token: 0x06001145 RID: 4421 RVA: 0x001B5684 File Offset: 0x001B3884
			internal static bool srJ60q8OIHjrZSfjtPN()
			{
				return false;
			}

			// Token: 0x04000F16 RID: 3862
			internal Vector3 $firePos$18228;

			// Token: 0x04000F17 RID: 3863
			internal GameObject $tObject$18229;

			// Token: 0x04000F18 RID: 3864
			internal Vector3 $mPos$18230;

			// Token: 0x04000F19 RID: 3865
			internal Vector3 $tDir$18231;

			// Token: 0x04000F1A RID: 3866
			internal int $tID$18232;

			// Token: 0x04000F1B RID: 3867
			internal IceDemon $self_$18233;
		}
	}

	// Token: 0x020002F7 RID: 759
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_manaBurn_hit$18238 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001146 RID: 4422 RVA: 0x001B5688 File Offset: 0x001B3888
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_manaBurn_hit$18238(Vector3 hitPos, IceDemon self_)
		{
			if (2706 - 97893 != -95186)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (256967 - 380025 == -123058)
				{
					base..ctor();
					if (205339 - 185686 == 19653)
					{
						this.$hitPos$18246 = hitPos;
						if (61766 - 195885 == -134119)
						{
							this.$self_$18247 = self_;
							if (144522 - 545052 == -400530)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x001B5744 File Offset: 0x001B3944
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceDemon.$RPC_manaBurn_hit$18238.$(this.$hitPos$18246, this.$self_$18247);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x001B5758 File Offset: 0x001B3958
		internal static bool rOHRGQ8m6q83b1lgKk0()
		{
			return true;
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x001B575C File Offset: 0x001B395C
		internal static bool a1l5d98F03Gn5SYpnQK()
		{
			return false;
		}

		// Token: 0x04000F1C RID: 3868
		internal Vector3 $hitPos$18246;

		// Token: 0x04000F1D RID: 3869
		internal IceDemon $self_$18247;

		// Token: 0x020002F8 RID: 760
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600114A RID: 4426 RVA: 0x001B5760 File Offset: 0x001B3960
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, IceDemon self_)
			{
				if (220980 - 292746 != -71765)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111194 - 253569 == -142375)
					{
						base..ctor();
						if (185697 - 505980 != -320282)
						{
							this.$hitPos$18244 = hitPos;
							if (215488 - 358227 != -142738)
							{
								this.$self_$18245 = self_;
								if (111886 - 582617 != -470730)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600114B RID: 4427 RVA: 0x001B581C File Offset: 0x001B3A1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286426 - 1842 != 284584)
				{
				}
				for (;;)
				{
					IL_D8:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2F5;
					case 2:
						if (this.$self_$18245.mChar.isMine)
						{
							if (98410 - 387413 != -289003)
							{
								continue;
							}
							this.$hitLayer$18239 = 130816 - (1 << this.$self_$18245.gameObject.layer);
							if (22666 - 338059 != -315393)
							{
								continue;
							}
							this.$hitList$18240 = Damage.FindAreaTarget(this.$hitPos$18244, (float)2, (float)3, this.$hitLayer$18239);
							if (167758 - 89554 == 78205)
							{
								continue;
							}
							this.$$iterator$10457$18243 = UnityRuntimeServices.GetEnumerator(this.$hitList$18240);
							if (198339 - 68503 == 129837)
							{
								continue;
							}
							while (this.$$iterator$10457$18243.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10457$18243.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18241 = (GameObject)obj2;
								if (5171 - 192440 != -187269)
								{
									goto IL_D8;
								}
								this.$tChar$18242 = (CharacterControl)this.$hitObject$18241.GetComponent(typeof(CharacterControl));
								if (21622 - 211054 != -189432)
								{
									goto IL_D8;
								}
								UnityRuntimeServices.Update(this.$$iterator$10457$18243, this.$hitObject$18241);
								if (30550 - 342646 != -312096)
								{
									goto IL_D8;
								}
								if (this.$tChar$18242)
								{
									if (214496 - 83901 != 130595)
									{
										goto IL_D8;
									}
									this.$tChar$18242.RPC_AddStatus("manaBurn", 3, 1, 30, this.$self_$18245.mChar.ActorNr);
									if (178964 - 232609 == -53644)
									{
										goto IL_D8;
									}
								}
							}
							if (115676 - 152325 == -36648)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (114101 - 406594 != -292493)
						{
							continue;
						}
						goto IL_2F5;
					default:
						if (212969 - 52740 == 160230)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$18245.manaBurn_hit)
					{
						break;
					}
					if (203234 - 467324 != -264089)
					{
						UnityEngine.Object.Instantiate(this.$self_$18245.manaBurn_hit, this.$hitPos$18244, Quaternion.identity);
						if (172762 - 204222 == -31460)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_2F5:
				return false;
			}

			// Token: 0x0600114C RID: 4428 RVA: 0x001B5B30 File Offset: 0x001B3D30
			internal static bool kHuwkV8MfNIrf36Q49b()
			{
				return true;
			}

			// Token: 0x0600114D RID: 4429 RVA: 0x001B5B34 File Offset: 0x001B3D34
			internal static bool vLgsMs8xEUQMArR2QTE()
			{
				return false;
			}

			// Token: 0x04000F1E RID: 3870
			internal int $hitLayer$18239;

			// Token: 0x04000F1F RID: 3871
			internal UnityScript.Lang.Array $hitList$18240;

			// Token: 0x04000F20 RID: 3872
			internal GameObject $hitObject$18241;

			// Token: 0x04000F21 RID: 3873
			internal CharacterControl $tChar$18242;

			// Token: 0x04000F22 RID: 3874
			internal IEnumerator $$iterator$10457$18243;

			// Token: 0x04000F23 RID: 3875
			internal Vector3 $hitPos$18244;

			// Token: 0x04000F24 RID: 3876
			internal IceDemon $self_$18245;
		}
	}

	// Token: 0x020002F9 RID: 761
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_blink$18248 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600114E RID: 4430 RVA: 0x001B5B38 File Offset: 0x001B3D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_blink$18248(Vector3 mPos, Vector3 tDir, IceDemon self_)
		{
			if (34959 - 233499 != -198540)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (49376 - 373296 != -323919)
				{
					base..ctor();
					if (251426 - 561041 == -309615)
					{
						this.$mPos$18259 = mPos;
						if (292777 - 171416 != 121362)
						{
							this.$tDir$18260 = tDir;
							if (106697 - 43734 == 62963)
							{
								this.$self_$18261 = self_;
								if (234175 - 583022 != -348846)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x001B5C14 File Offset: 0x001B3E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceDemon.$RPC_blink$18248.$(this.$mPos$18259, this.$tDir$18260, this.$self_$18261);
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x001B5C30 File Offset: 0x001B3E30
		internal static bool P3ryw38guUDxmtpiQTf()
		{
			return true;
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x001B5C34 File Offset: 0x001B3E34
		internal static bool WKNJHo8fOdmTWgSEAo4()
		{
			return false;
		}

		// Token: 0x04000F25 RID: 3877
		internal Vector3 $mPos$18259;

		// Token: 0x04000F26 RID: 3878
		internal Vector3 $tDir$18260;

		// Token: 0x04000F27 RID: 3879
		internal IceDemon $self_$18261;

		// Token: 0x020002FA RID: 762
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001152 RID: 4434 RVA: 0x001B5C38 File Offset: 0x001B3E38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IceDemon self_)
			{
				if (175985 - 488405 != -312419)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293326 - 20253 == 273073)
					{
						base..ctor();
						if (287250 - 297957 == -10707)
						{
							this.$mPos$18256 = mPos;
							if (94279 - 193902 != -99622)
							{
								this.$tDir$18257 = tDir;
								if (284967 - 146516 != 138452)
								{
									this.$self_$18258 = self_;
									if (149706 - 496427 == -346721)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001153 RID: 4435 RVA: 0x001B5D14 File Offset: 0x001B3F14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (80462 - 113460 != -32997)
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
						goto IL_9E7;
					case 2:
						if (this.$self_$18258.mChar.actionState != "attack")
						{
							goto IL_48E;
						}
						if (133815 - 17838 != 115977)
						{
							continue;
						}
						if (this.$self_$18258.mChar.myCommand != "blink")
						{
							if (288723 - 14758 != 273965)
							{
								continue;
							}
							goto IL_48E;
						}
						else
						{
							if (this.$self_$18258.blink)
							{
								if (298872 - 30631 != 268241)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$18258.blink, this.$self_$18258.transform.position, this.$self_$18258.transform.rotation);
								if (255675 - 247202 == 8474)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find blink effect");
								if (227968 - 266121 != -38153)
								{
									continue;
								}
							}
							this.$ignoreLayer$18249 = 130818;
							if (23918 - 344963 != -321045)
							{
								continue;
							}
							this.$ignoreList$18250 = Damage.FindRecTarget(this.$self_$18258.transform.position, this.$self_$18258.transform.forward, (float)1, (float)1, (float)6, (float)2, this.$ignoreLayer$18249);
							if (89252 - 40467 != 48785)
							{
								continue;
							}
							this.$$iterator$10458$18252 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$18250);
							if (258643 - 511875 != -253232)
							{
								continue;
							}
							while (this.$$iterator$10458$18252.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10458$18252.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$ignoreObject$18251 = (GameObject)obj2;
								if (3593 - 268832 != -265239)
								{
									goto IL_1A;
								}
								if (this.$ignoreObject$18251)
								{
									if (283209 - 273031 != 10178)
									{
										goto IL_1A;
									}
									if (this.$self_$18258.gameObject != this.$ignoreObject$18251)
									{
										if (246836 - 158589 != 88247)
										{
											goto IL_1A;
										}
										Physics.IgnoreCollision(this.$self_$18258.gameObject.collider, this.$ignoreObject$18251.collider, true);
										if (220990 - 298563 != -77573)
										{
											goto IL_1A;
										}
										UnityRuntimeServices.Update(this.$$iterator$10458$18252, this.$ignoreObject$18251);
										if (193269 - 432301 == -239031)
										{
											goto IL_1A;
										}
									}
								}
							}
							if (163121 - 181942 != -18821)
							{
								continue;
							}
							this.$mCharacterController$18253 = (CharacterController)this.$self_$18258.GetComponent(typeof(CharacterController));
							if (277466 - 574092 == -296625)
							{
								continue;
							}
							this.$mCharacterController$18253.Move((float)12 * this.$self_$18258.transform.forward);
							if (193039 - 236504 != -43465)
							{
								continue;
							}
							this.$$iterator$10459$18255 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$18250);
							if (148150 - 26119 == 122032)
							{
								continue;
							}
							while (this.$$iterator$10459$18255.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10459$18255.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$ignoreObject$18254 = (GameObject)obj4;
								if (3654 - 66578 == -62923)
								{
									goto IL_1A;
								}
								if (this.$ignoreObject$18254)
								{
									if (100268 - 386065 == -285796)
									{
										goto IL_1A;
									}
									if (this.$self_$18258.gameObject != this.$ignoreObject$18254)
									{
										if (36203 - 124240 != -88037)
										{
											goto IL_1A;
										}
										Physics.IgnoreCollision(this.$self_$18258.gameObject.collider, this.$ignoreObject$18254.collider, false);
										if (67550 - 3793 == 63758)
										{
											goto IL_1A;
										}
										UnityRuntimeServices.Update(this.$$iterator$10459$18255, this.$ignoreObject$18254);
										if (139588 - 251436 == -111847)
										{
											goto IL_1A;
										}
									}
								}
							}
							if (188065 - 139509 != 48556)
							{
								continue;
							}
							if (this.$self_$18258.blink)
							{
								if (294612 - 315108 == -20495)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$18258.blink, this.$self_$18258.transform.position, this.$self_$18258.transform.rotation);
								if (210605 - 265694 != -55089)
								{
									continue;
								}
								goto IL_7D7;
							}
							else
							{
								Debug.LogError("Cannot find blink effect");
								if (276594 - 531867 != -255272)
								{
									goto Block_52;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$18258.mChar.actionState == "attack")
						{
							if (289827 - 106623 == 183205)
							{
								continue;
							}
							if (this.$self_$18258.mChar.myCommand == "blink")
							{
								if (179227 - 532701 != -353474)
								{
									continue;
								}
								this.$self_$18258.mChar.actionState = "standby";
								if (55202 - 116197 == -60994)
								{
									continue;
								}
								this.$self_$18258.mChar.actionTime = Time.time;
								if (96592 - 387306 != -290714)
								{
									continue;
								}
								this.$self_$18258.mChar.myCommand = "none";
								if (221987 - 320615 == -98627)
								{
									continue;
								}
								if (!this.$self_$18258.mChar.isMine)
								{
									if (97875 - 303859 == -205983)
									{
										continue;
									}
									this.$self_$18258.mChar.nPosition = this.$self_$18258.transform.position;
									if (204835 - 500104 == -295268)
									{
										continue;
									}
									this.$self_$18258.mChar.oPosition = this.$self_$18258.transform.position;
									if (198063 - 191013 == 7051)
									{
										continue;
									}
									this.$self_$18258.mChar.nDirection = this.$self_$18258.transform.forward;
									if (279374 - 213274 != 66100)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (155661 - 209326 != -53665)
						{
							continue;
						}
						goto IL_9E7;
					default:
						if (161676 - 314251 == -152574)
						{
							continue;
						}
						break;
					}
					this.$self_$18258.mChar.actionState = "attack";
					if (136462 - 176038 == -39576)
					{
						this.$self_$18258.mChar.actionTime = Time.time;
						if (5042 - 543583 != -538540)
						{
							this.$self_$18258.mChar.myCommand = "blink";
							if (76371 - 94098 != -17726)
							{
								this.$self_$18258.mChar.addTimeOut("blink", (float)12);
								if (79129 - 224484 == -145355)
								{
									this.$self_$18258.transform.position = this.$mPos$18256;
									if (178463 - 549111 != -370647)
									{
										this.$self_$18258.transform.LookAt(this.$mPos$18256 + global::Math.vFlat(this.$tDir$18257));
										if (163992 - 219664 == -55672)
										{
											this.$self_$18258.animation.CrossFade("root");
											if (47471 - 89470 == -41999)
											{
												this.$self_$18258.animation.wrapMode = WrapMode.Loop;
												if (277803 - 502370 == -224567)
												{
													this.$self_$18258.mChar.vMovement = this.$self_$18258.transform.forward;
													if (161007 - 69292 == 91715)
													{
														this.$self_$18258.mChar.moveSpeed = (float)0;
														if (157022 - 96894 != 60129)
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
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_48E:
				goto IL_9E7;
				IL_788:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_7D7:
				Block_52:
				goto IL_788;
				IL_9E7:
				return false;
			}

			// Token: 0x06001154 RID: 4436 RVA: 0x001B671C File Offset: 0x001B491C
			internal static bool CHr4iL8nNR1r1rSIgB4()
			{
				return true;
			}

			// Token: 0x06001155 RID: 4437 RVA: 0x001B6720 File Offset: 0x001B4920
			internal static bool zSvoWn86m43xIVbcbJX()
			{
				return false;
			}

			// Token: 0x04000F28 RID: 3880
			internal int $ignoreLayer$18249;

			// Token: 0x04000F29 RID: 3881
			internal UnityScript.Lang.Array $ignoreList$18250;

			// Token: 0x04000F2A RID: 3882
			internal GameObject $ignoreObject$18251;

			// Token: 0x04000F2B RID: 3883
			internal IEnumerator $$iterator$10458$18252;

			// Token: 0x04000F2C RID: 3884
			internal CharacterController $mCharacterController$18253;

			// Token: 0x04000F2D RID: 3885
			internal GameObject $ignoreObject$18254;

			// Token: 0x04000F2E RID: 3886
			internal IEnumerator $$iterator$10459$18255;

			// Token: 0x04000F2F RID: 3887
			internal Vector3 $mPos$18256;

			// Token: 0x04000F30 RID: 3888
			internal Vector3 $tDir$18257;

			// Token: 0x04000F31 RID: 3889
			internal IceDemon $self_$18258;
		}
	}

	// Token: 0x020002FB RID: 763
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_absoluteZero$18262 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001156 RID: 4438 RVA: 0x001B6724 File Offset: 0x001B4924
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_absoluteZero$18262(Vector3 mPos, Vector3 tDir, int tID, IceDemon self_)
		{
			if (39000 - 221689 != -182688)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (262885 - 597905 != -335019)
				{
					base..ctor();
					if (30463 - 206594 != -176130)
					{
						this.$mPos$18269 = mPos;
						if (246248 - 143063 != 103186)
						{
							this.$tDir$18270 = tDir;
							if (56231 - 569901 != -513669)
							{
								this.$tID$18271 = tID;
								if (243843 - 73817 == 170026)
								{
									this.$self_$18272 = self_;
									if (14634 - 297477 == -282843)
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

		// Token: 0x06001157 RID: 4439 RVA: 0x001B6824 File Offset: 0x001B4A24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceDemon.$RPC_absoluteZero$18262.$(this.$mPos$18269, this.$tDir$18270, this.$tID$18271, this.$self_$18272);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x001B6844 File Offset: 0x001B4A44
		internal static bool Wt0QC78icQfeAjgccvW()
		{
			return true;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x001B6848 File Offset: 0x001B4A48
		internal static bool V8EvZU8KP0kZ7Uy17bA()
		{
			return false;
		}

		// Token: 0x04000F32 RID: 3890
		internal Vector3 $mPos$18269;

		// Token: 0x04000F33 RID: 3891
		internal Vector3 $tDir$18270;

		// Token: 0x04000F34 RID: 3892
		internal int $tID$18271;

		// Token: 0x04000F35 RID: 3893
		internal IceDemon $self_$18272;

		// Token: 0x020002FC RID: 764
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600115A RID: 4442 RVA: 0x001B684C File Offset: 0x001B4A4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, IceDemon self_)
			{
				if (94468 - 246066 != -151598)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (29641 - 376071 != -346429)
					{
						base..ctor();
						if (284040 - 420826 != -136785)
						{
							this.$mPos$18265 = mPos;
							if (85947 - 430798 == -344851)
							{
								this.$tDir$18266 = tDir;
								if (245746 - 83499 != 162248)
								{
									this.$tID$18267 = tID;
									if (255310 - 398137 == -142827)
									{
										this.$self_$18268 = self_;
										if (106818 - 243807 == -136989)
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

			// Token: 0x0600115B RID: 4443 RVA: 0x001B694C File Offset: 0x001B4B4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269769 - 132634 != 137136)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8DB;
					case 2:
						if (this.$self_$18268.mChar.actionState != "attack")
						{
							goto IL_41E;
						}
						if (235595 - 594806 == -359210)
						{
							continue;
						}
						if (this.$self_$18268.mChar.myCommand != "absoluteZero")
						{
							if (208408 - 103860 != 104549)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18268.cast_ring)
							{
								goto IL_6D0;
							}
							if (258529 - 488627 != -230098)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$18268.cast_ring, this.$self_$18268.transform.position, this.$self_$18268.transform.rotation);
							if (180176 - 378887 != -198710)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18268.mChar.actionState != "attack")
						{
							goto IL_7FE;
						}
						if (281091 - 279925 != 1166)
						{
							continue;
						}
						if (this.$self_$18268.mChar.myCommand != "absoluteZero")
						{
							if (28108 - 43997 != -15889)
							{
								continue;
							}
							goto IL_7FE;
						}
						else
						{
							if (!this.$self_$18268.mChar.isMine)
							{
								goto IL_1AA;
							}
							if (99312 - 376309 == -276996)
							{
								continue;
							}
							this.$firePos$18263 = this.$mPos$18265 + this.$tDir$18266;
							if (107926 - 569628 != -461702)
							{
								continue;
							}
							if (this.$tID$18267 == 0)
							{
								goto IL_2D8;
							}
							if (109668 - 471188 == -361519)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18267];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$18264 = (GameObject)obj2;
							if (299054 - 21788 == 277267)
							{
								continue;
							}
							if (!this.$tObject$18264)
							{
								goto IL_2D8;
							}
							if (276820 - 357836 != -81016)
							{
								continue;
							}
							this.$firePos$18263 = this.$tObject$18264.transform.position;
							if (289393 - 506390 != -216997)
							{
								continue;
							}
							goto IL_2D8;
						}
						break;
					case 4:
						if (this.$self_$18268.mChar.actionState != "attack")
						{
							goto IL_5C4;
						}
						if (251861 - 427388 == -175526)
						{
							continue;
						}
						if (this.$self_$18268.mChar.myCommand != "absoluteZero")
						{
							if (74092 - 321036 != -246943)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$18268.StartCoroutine_Auto(this.$self_$18268.RPC_absoluteZero_hit(this.$firePos$18263, Vector3.forward, 0));
							if (109957 - 409762 != -299805)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_1A5;
							}
							if (171947 - 252224 != -80277)
							{
								continue;
							}
							this.$self_$18268.ActionEvent("RPC_absoluteZero_hit", this.$firePos$18263, Vector3.forward, 0);
							if (46872 - 225919 != -179046)
							{
								goto Block_58;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$18268.mChar.actionState != "attack")
						{
							goto IL_F3;
						}
						if (236794 - 53999 != 182795)
						{
							continue;
						}
						if (!(this.$self_$18268.mChar.myCommand != "absoluteZero"))
						{
							goto IL_F8;
						}
						if (80016 - 28011 != 52006)
						{
							goto Block_26;
						}
						continue;
					case 6:
						if (this.$self_$18268.mChar.actionState == "attack")
						{
							if (237429 - 415323 == -177893)
							{
								continue;
							}
							if (this.$self_$18268.mChar.myCommand == "absoluteZero")
							{
								if (242014 - 516746 == -274731)
								{
									continue;
								}
								this.$self_$18268.mChar.actionState = "standby";
								if (48655 - 451533 != -402878)
								{
									continue;
								}
								this.$self_$18268.mChar.actionTime = Time.time;
								if (295748 - 591876 != -296128)
								{
									continue;
								}
								this.$self_$18268.mChar.myCommand = "none";
								if (207773 - 422432 == -214658)
								{
									continue;
								}
								if (!this.$self_$18268.mChar.isMine)
								{
									if (202427 - 285391 == -82963)
									{
										continue;
									}
									this.$self_$18268.mChar.nPosition = this.$self_$18268.transform.position;
									if (285576 - 430787 == -145210)
									{
										continue;
									}
									this.$self_$18268.mChar.oPosition = this.$self_$18268.transform.position;
									if (14793 - 276970 != -262177)
									{
										continue;
									}
									this.$self_$18268.mChar.nDirection = this.$self_$18268.transform.forward;
									if (263717 - 45459 != 218258)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (43374 - 326534 != -283159)
						{
							goto Block_47;
						}
						continue;
					default:
						if (174628 - 555069 != -380441)
						{
							continue;
						}
						break;
					}
					this.$self_$18268.mChar.actionState = "attack";
					if (256202 - 253256 != 2947)
					{
						this.$self_$18268.mChar.actionTime = Time.time;
						if (79085 - 357372 != -278286)
						{
							this.$self_$18268.mChar.myCommand = "absoluteZero";
							if (289158 - 205073 == 84085)
							{
								this.$self_$18268.mChar.addTimeOut("absoluteZero", (float)12);
								if (89203 - 165867 != -76663)
								{
									this.$self_$18268.transform.position = this.$mPos$18265;
									if (266072 - 210065 == 56007)
									{
										this.$self_$18268.transform.LookAt(this.$mPos$18265 + global::Math.vFlat(this.$tDir$18266));
										if (113976 - 525511 != -411534)
										{
											this.$self_$18268.animation.CrossFade("cast");
											if (235333 - 445202 == -209869)
											{
												this.$self_$18268.animation.wrapMode = WrapMode.Once;
												if (113447 - 83478 == 29969)
												{
													this.$self_$18268.mChar.vMovement = this.$self_$18268.transform.forward;
													if (68469 - 104264 != -35794)
													{
														this.$self_$18268.mChar.moveSpeed = (float)0;
														if (238768 - 362430 == -123662)
														{
															goto IL_289;
														}
													}
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
				goto IL_8DB;
				IL_F8:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_1A5:
				goto IL_F8;
				IL_1AA:
				return this.Yield(5, new WaitForSeconds(0.1f));
				Block_16:
				goto IL_5C4;
				IL_289:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_2D8:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_26:
				IL_41E:
				Block_35:
				IL_5C4:
				goto IL_8DB;
				Block_41:
				IL_6D0:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_47:
				IL_7FE:
				goto IL_8DB;
				Block_58:
				goto IL_1A5;
				IL_8DB:
				return false;
			}

			// Token: 0x0600115C RID: 4444 RVA: 0x001B7248 File Offset: 0x001B5448
			internal static bool rbKk6v8dd5VOIVwbqmS()
			{
				return true;
			}

			// Token: 0x0600115D RID: 4445 RVA: 0x001B724C File Offset: 0x001B544C
			internal static bool Q6ZbD58JyW3MiZH7upa()
			{
				return false;
			}

			// Token: 0x04000F36 RID: 3894
			internal Vector3 $firePos$18263;

			// Token: 0x04000F37 RID: 3895
			internal GameObject $tObject$18264;

			// Token: 0x04000F38 RID: 3896
			internal Vector3 $mPos$18265;

			// Token: 0x04000F39 RID: 3897
			internal Vector3 $tDir$18266;

			// Token: 0x04000F3A RID: 3898
			internal int $tID$18267;

			// Token: 0x04000F3B RID: 3899
			internal IceDemon $self_$18268;
		}
	}

	// Token: 0x020002FD RID: 765
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_absoluteZero_hit$18273 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600115E RID: 4446 RVA: 0x001B7250 File Offset: 0x001B5450
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_absoluteZero_hit$18273(Vector3 hitPos, IceDemon self_)
		{
			if (288923 - 106101 != 182823)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172230 - 16025 != 156206)
				{
					base..ctor();
					if (136374 - 85573 != 50802)
					{
						this.$hitPos$18280 = hitPos;
						if (2262 - 335683 == -333421)
						{
							this.$self_$18281 = self_;
							if (6891 - 276311 == -269420)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x001B730C File Offset: 0x001B550C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceDemon.$RPC_absoluteZero_hit$18273.$(this.$hitPos$18280, this.$self_$18281);
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x001B7320 File Offset: 0x001B5520
		internal static bool KmLQiJ8D5lLu4Bju5Ix()
		{
			return true;
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x001B7324 File Offset: 0x001B5524
		internal static bool vuW6Bg8vqlHdRl7CwTv()
		{
			return false;
		}

		// Token: 0x04000F3C RID: 3900
		internal Vector3 $hitPos$18280;

		// Token: 0x04000F3D RID: 3901
		internal IceDemon $self_$18281;

		// Token: 0x020002FE RID: 766
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001162 RID: 4450 RVA: 0x001B7328 File Offset: 0x001B5528
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, IceDemon self_)
			{
				if (36087 - 194344 != -158257)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (185931 - 514722 != -328790)
					{
						base..ctor();
						if (204137 - 289627 == -85490)
						{
							this.$hitPos$18278 = hitPos;
							if (74198 - 11730 != 62469)
							{
								this.$self_$18279 = self_;
								if (241317 - 274043 == -32726)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001163 RID: 4451 RVA: 0x001B73E4 File Offset: 0x001B55E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (123099 - 143592 != -20492)
				{
				}
				for (;;)
				{
					IL_9B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2B7;
					case 2:
						if (this.$self_$18279.mChar.isMine)
						{
							if (275068 - 559680 != -284612)
							{
								continue;
							}
							this.$hitLayer$18274 = 130816 - (1 << this.$self_$18279.gameObject.layer);
							if (92740 - 247937 != -155197)
							{
								continue;
							}
							this.$hitList$18275 = Damage.FindAreaTarget(this.$hitPos$18278, (float)1, (float)3, this.$hitLayer$18274);
							if (123137 - 141875 != -18738)
							{
								continue;
							}
							this.$$iterator$10460$18277 = UnityRuntimeServices.GetEnumerator(this.$hitList$18275);
							if (215446 - 154169 == 61278)
							{
								continue;
							}
							while (this.$$iterator$10460$18277.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10460$18277.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18276 = (GameObject)obj2;
								if (296082 - 329352 == -33269)
								{
									goto IL_9B;
								}
								if (this.$self_$18279.mChar.hit(1, this.$hitObject$18276, this.$self_$18279.mChar.talAdjust(135), 20, 0, Vector3.zero) != 0)
								{
									if (37514 - 370194 != -332680)
									{
										goto IL_9B;
									}
									this.$self_$18279.mChar.sp = this.$self_$18279.mChar.sp + 1;
									if (83690 - 291469 == -207778)
									{
										goto IL_9B;
									}
								}
							}
							if (144289 - 259416 == -115126)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (233819 - 433561 != -199742)
						{
							continue;
						}
						goto IL_2B7;
					default:
						if (219290 - 320151 != -100861)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$18279.absoluteZero_hit)
					{
						break;
					}
					if (279070 - 192617 == 86453)
					{
						UnityEngine.Object.Instantiate(this.$self_$18279.absoluteZero_hit, this.$hitPos$18278, Quaternion.identity);
						if (36930 - 562361 != -525430)
						{
							break;
						}
					}
				}
				IL_56:
				return this.Yield(2, new WaitForSeconds(0.1f));
				goto IL_56;
				IL_2B7:
				return false;
			}

			// Token: 0x06001164 RID: 4452 RVA: 0x001B76BC File Offset: 0x001B58BC
			internal static bool fxoGDQ8ReWMXVaiLulQ()
			{
				return true;
			}

			// Token: 0x06001165 RID: 4453 RVA: 0x001B76C0 File Offset: 0x001B58C0
			internal static bool MUBhao8weQZqJUsN4K0()
			{
				return false;
			}

			// Token: 0x04000F3E RID: 3902
			internal int $hitLayer$18274;

			// Token: 0x04000F3F RID: 3903
			internal UnityScript.Lang.Array $hitList$18275;

			// Token: 0x04000F40 RID: 3904
			internal GameObject $hitObject$18276;

			// Token: 0x04000F41 RID: 3905
			internal IEnumerator $$iterator$10460$18277;

			// Token: 0x04000F42 RID: 3906
			internal Vector3 $hitPos$18278;

			// Token: 0x04000F43 RID: 3907
			internal IceDemon $self_$18279;
		}
	}

	// Token: 0x020002FF RID: 767
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18282 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001166 RID: 4454 RVA: 0x001B76C4 File Offset: 0x001B58C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18282(UnityScript.Lang.Array nArray, IceDemon self_)
		{
			if (19767 - 575464 != -555696)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (268312 - 15873 == 252439)
				{
					base..ctor();
					if (169962 - 507515 == -337553)
					{
						this.$nArray$18287 = nArray;
						if (141416 - 411569 == -270153)
						{
							this.$self_$18288 = self_;
							if (206578 - 412463 != -205884)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x001B7780 File Offset: 0x001B5980
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceDemon.$RPC_dead$18282.$(this.$nArray$18287, this.$self_$18288);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x001B7794 File Offset: 0x001B5994
		internal static bool hSZysp8qUVOubneLBwo()
		{
			return true;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x001B7798 File Offset: 0x001B5998
		internal static bool ESu9vS879XcOjFruCjX()
		{
			return false;
		}

		// Token: 0x04000F44 RID: 3908
		internal UnityScript.Lang.Array $nArray$18287;

		// Token: 0x04000F45 RID: 3909
		internal IceDemon $self_$18288;

		// Token: 0x02000300 RID: 768
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600116A RID: 4458 RVA: 0x001B779C File Offset: 0x001B599C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, IceDemon self_)
			{
				if (48591 - 533496 != -484905)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (183235 - 4809 == 178426)
					{
						base..ctor();
						if (274588 - 346930 == -72342)
						{
							this.$nArray$18285 = nArray;
							if (123925 - 17004 == 106921)
							{
								this.$self_$18286 = self_;
								if (71030 - 399949 == -328919)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600116B RID: 4459 RVA: 0x001B7858 File Offset: 0x001B5A58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117931 - 355807 != -237876)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4C7;
					case 2:
						if (this.$self_$18286.mChar.actionState != "dead")
						{
							if (77182 - 255516 != -178334)
							{
								continue;
							}
							goto IL_359;
						}
						else
						{
							if (!this.$self_$18286.mChar.isPlayer)
							{
								if (223641 - 59966 == 163676)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18286.gameObject);
								if (51540 - 104659 == -53118)
								{
									continue;
								}
							}
							else if (this.$self_$18286.mChar.isMine)
							{
								if (247988 - 75645 != 172343)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18286.gameObject);
								if (181415 - 389174 == -207758)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (109623 - 412950 != -303327)
							{
								continue;
							}
							goto IL_4C7;
						}
						break;
					default:
						if (33349 - 257138 == -223788)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18286.mChar.actionState == "dead")
					{
						if (57711 - 317313 == -259602)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18283 = (Vector3)this.$nArray$18285[0];
						if (244428 - 65354 != 179075)
						{
							this.$myDirection$18284 = (Vector3)this.$nArray$18285[1];
							if (299005 - 329792 == -30787)
							{
								this.$self_$18286.transform.position = this.$myPosition$18283;
								if (64122 - 599542 == -535420)
								{
									this.$self_$18286.transform.LookAt(this.$myPosition$18283 + this.$myDirection$18284);
									if (272931 - 230210 == 42721)
									{
										this.$self_$18286.mChar.hp = 0;
										if (125523 - 424663 == -299140)
										{
											this.$self_$18286.mChar.actionState = "dead";
											if (58735 - 449708 != -390972)
											{
												this.$self_$18286.mChar.actionTime = Time.time;
												if (105726 - 341395 == -235669)
												{
													this.$self_$18286.mChar.myCommand = "none";
													if (157228 - 66274 != 90955)
													{
														this.$self_$18286.mChar.vMovement = Vector3.zero;
														if (82326 - 357983 == -275657)
														{
															this.$self_$18286.mChar.moveSpeed = (float)0;
															if (186152 - 512330 == -326178)
															{
																this.$self_$18286.animation.Rewind();
																if (24143 - 166809 == -142666)
																{
																	this.$self_$18286.animation.Play("ko");
																	if (252955 - 37520 != 215436)
																	{
																		this.$self_$18286.animation.wrapMode = WrapMode.Once;
																		if (3532 - 31180 != -27647)
																		{
																			if (this.$self_$18286.deadEffect)
																			{
																				if (142733 - 241485 != -98751)
																				{
																					UnityEngine.Object.Instantiate(this.$self_$18286.deadEffect, this.$self_$18286.transform.position, Quaternion.identity);
																					if (297704 - 533791 != -236086)
																					{
																						goto Block_29;
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Missing deadEffect");
																				if (208537 - 67174 == 141363)
																				{
																					goto IL_85;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4C7;
				IL_85:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_359:
				goto IL_4C7;
				Block_29:
				goto IL_85;
				IL_4C7:
				return false;
			}

			// Token: 0x0600116C RID: 4460 RVA: 0x001B7D40 File Offset: 0x001B5F40
			internal static bool F8vgEt8PW9kLPPg7cZZ()
			{
				return true;
			}

			// Token: 0x0600116D RID: 4461 RVA: 0x001B7D44 File Offset: 0x001B5F44
			internal static bool rocex080lVeYlPtPEB3()
			{
				return false;
			}

			// Token: 0x04000F46 RID: 3910
			internal Vector3 $myPosition$18283;

			// Token: 0x04000F47 RID: 3911
			internal Vector3 $myDirection$18284;

			// Token: 0x04000F48 RID: 3912
			internal UnityScript.Lang.Array $nArray$18285;

			// Token: 0x04000F49 RID: 3913
			internal IceDemon $self_$18286;
		}
	}
}
