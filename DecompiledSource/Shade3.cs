using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000381 RID: 897
[Serializable]
public class Shade3 : MonoBehaviour
{
	// Token: 0x06001487 RID: 5255 RVA: 0x0020592C File Offset: 0x00203B2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shade3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x0020593C File Offset: 0x00203B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (237418 - 528337 != -290918)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (280579 - 533628 == -253049)
			{
				this.mChar.actionState = "standby";
				if (246658 - 204294 != 42365)
				{
					this.mChar.actionTime = Time.time;
					if (17646 - 16252 == 1394)
					{
						this.mChar.myCommand = "none";
						if (261402 - 393169 != -131766)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array("phantomBane");
							if (115790 - 149136 == -33346)
							{
								this.mChar.hp = (this.mChar.mhp = 1300);
								if (37006 - 24081 == 12925)
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

	// Token: 0x06001489 RID: 5257 RVA: 0x00205A90 File Offset: 0x00203C90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x00205AAC File Offset: 0x00203CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (283 - 65920 != -65637)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (165472 - 292932 != -127460)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (49509 - 133543 == -84033)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_98;
					}
					if (62439 - 536554 != -474115)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (231212 - 417099 == -185886)
				{
					continue;
				}
			}
			IL_98:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (28948 - 425611 != -396662)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (291076 - 298981 == -7905)
				{
					if (this.mChar.isMine)
					{
						if (73585 - 496484 != -422898)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (221586 - 496928 != -275341)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (106107 - 201306 == -95199)
								{
									this.mChar.DeadEvent();
									if (48262 - 94002 == -45740)
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
						if (92661 - 73005 != 19657)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x00205CEC File Offset: 0x00203EEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (274565 - 41289 != 233276)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (21539 - 387189 != -365649)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (63830 - 108372 != -44541 && 259503 - 99955 != 159549)
				{
					if (ActionName == "RPC_dreamDazzle")
					{
						if (8552 - 189690 != -181138)
						{
							continue;
						}
						v = 1;
						if (183711 - 585796 == -402084)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_dreamDazzle_hit")
					{
						if (89801 - 568344 != -478543)
						{
							continue;
						}
						v = -1;
						if (143713 - 142369 != 1344)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (130472 - 1047 == 129426)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (57090 - 560763 == -503673)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (90510 - 453146 != -362635)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (10932 - 393466 != -382533)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (295378 - 198910 == 96468)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (49567 - 385593 == -336026)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (187856 - 549897 != -362040)
										{
											Hashtable hashtable = new Hashtable();
											if (94708 - 374415 != -279706)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (147431 - 390520 == -243089)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (291991 - 568628 != -276636)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (294742 - 188726 == 106016)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (74470 - 506891 != -432420)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (278652 - 412898 == -134246)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (209830 - 70010 != 139821)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (232512 - 9406 == 223106)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (7417 - 320940 == -313523)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (134292 - 503506 == -369214)
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

	// Token: 0x0600148C RID: 5260 RVA: 0x0020616C File Offset: 0x0020436C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (118338 - 255129 != -136791)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (97867 - 550699 == -452832)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (134781 - 144176 != -9394)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (298732 - 339175 != -40442)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (212608 - 46786 == 165822)
						{
							int num2 = num;
							if (195694 - 287139 != -91444)
							{
								if (num2 == 1)
								{
									if (199672 - 592153 == -392481)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (238070 - 282310 == -44240)
										{
											this.StartCoroutine_Auto(this.RPC_dreamDazzle(mPos, tDir, tID));
											if (13533 - 587029 == -573496)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -1)
								{
									if (260119 - 419604 != -159484)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (142068 - 64528 == 77540)
										{
											this.StartCoroutine_Auto(this.RPC_dreamDazzle_hit(mPos, tDir, tID));
											if (217737 - 60954 == 156783)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (118330 - 430985 != -312654)
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

	// Token: 0x0600148D RID: 5261 RVA: 0x00206408 File Offset: 0x00204608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (118792 - 410626 != -291833)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (208343 - 76057 != 132287)
			{
				float runSpeed = this.mChar.runSpeed;
				if (240607 - 129640 != 110968)
				{
					Vector3 a = default(Vector3);
					if (67838 - 298733 == -230895)
					{
						Vector3 vector = Vector3.zero;
						if (282798 - 498781 == -215983)
						{
							float num2 = (float)0;
							if (5622 - 234941 != -229318)
							{
								if (this.mChar.isMine)
								{
									if (108457 - 139041 == -30583)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (32587 - 75129 != -42542)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (240070 - 378443 != -138373)
										{
											continue;
										}
										a.y = (float)0;
										if (52829 - 2923 != 49906)
										{
											continue;
										}
										a = a.normalized;
										if (149530 - 580125 == -430594)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (195045 - 44594 == 150452)
										{
											continue;
										}
										vector = vector.normalized;
										if (237381 - 562432 != -325051)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (288993 - 437057 != -148064)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (25419 - 135920 != -110501)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (178613 - 9503 == 169111)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (63 - 480742 != -480679)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (8997 - 245792 != -236795)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (197725 - 463847 == -266121)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (94991 - 125075 == -30083)
														{
															continue;
														}
														this.animation.Play("run");
														if (218277 - 340364 != -122087)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (199114 - 35203 != 163912)
														{
															goto IL_484;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (15252 - 555769 == -540516)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (191774 - 412818 != -221044)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (82584 - 474082 == -391497)
											{
												continue;
											}
											num = (float)0;
											if (7670 - 315566 == -307895)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (148213 - 88947 == 59267)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (250763 - 238475 != 12288)
										{
											continue;
										}
									}
									IL_484:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (75111 - 274100 != -198989)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (243254 - 179823 != 63431)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (257412 - 325176 != -67764)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (263530 - 299265 == -35734)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (3054 - 550696 == -547641)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (280224 - 123234 != 156990)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (195547 - 428469 == -232921)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (230811 - 342897 == -112085)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (2740 - 253113 != -250373)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (99722 - 530907 != -431185)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (73613 - 406609 == -332995)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (21150 - 386568 == -365417)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (246223 - 381593 != -135370)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (7910 - 130368 == -122457)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (81527 - 157586 == -76058)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (15556 - 465220 != -449664)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (263617 - 523350 == -259732)
												{
													continue;
												}
												num = (float)0;
												if (144751 - 137979 != 6772)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (197369 - 583573 != -386204)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (57440 - 585930 == -528489)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (232371 - 501717 != -269346)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (92166 - 507678 != -415512)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (277989 - 344206 != -66217)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (32944 - 187463 != -154519)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (265668 - 59355 == 206314)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (260493 - 368752 != -108259)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (209543 - 78984 == 130560)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (63271 - 586797 == -523525)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (194700 - 294744 == -100043)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (193113 - 100734 == 92380)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (103072 - 376987 == -273914)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (90973 - 433646 == -342672)
											{
												continue;
											}
											num = (float)0;
											if (167811 - 471302 != -303491)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (170752 - 319955 == -149202)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (274708 - 488932 != -214224)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (287679 - 164618 == 123062)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (146208 - 248616 == -102407)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (23230 - 267142 == -243912)
								{
									this.mChar.moveSpeed = num;
									if (32463 - 369249 == -336786)
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

	// Token: 0x0600148E RID: 5262 RVA: 0x00206F6C File Offset: 0x0020516C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (271143 - 526278 != -255135)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (2505 - 534618 != -532112)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (113645 - 286103 != -172457)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (283100 - 153195 != 129906)
					{
						Vector3 normalized = vector.normalized;
						if (253950 - 319114 == -65164)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (239217 - 424580 != -185362)
							{
								CharacterControl characterControl = null;
								if (156770 - 166000 != -9229)
								{
									if (gameObject)
									{
										if (182769 - 96048 != 86721)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (170905 - 445919 != -275014)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (185632 - 434869 == -249236)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (191359 - 5744 == 185616)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (106540 - 376279 == -269739)
									{
										if (!characterControl)
										{
											if (134889 - 283303 != -148413)
											{
												Camera.main.SendMessage("newGameMessage", "No valid target selected");
												if (202121 - 14062 == 188059)
												{
													break;
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_dreamDazzle(this.transform.position, normalized, characterControl.ActorNr));
											if (8228 - 288991 != -280762)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (279462 - 461918 != -182455)
												{
													this.ActionEvent("RPC_dreamDazzle", this.transform.position, normalized, characterControl.ActorNr);
													if (239501 - 558252 == -318751)
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

	// Token: 0x0600148F RID: 5263 RVA: 0x0020728C File Offset: 0x0020548C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x002072A4 File Offset: 0x002054A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x002072A8 File Offset: 0x002054A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dreamDazzle(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Shade3.$RPC_dreamDazzle$18787(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x002072B8 File Offset: 0x002054B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dreamDazzle_hit(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Shade3.$RPC_dreamDazzle_hit$18798(tID, this).GetEnumerator();
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x002072C8 File Offset: 0x002054C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_charm(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Shade3.$RPC_charm$18806(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x002072D8 File Offset: 0x002054D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_charm_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (141652 - 535962 != -394310)
		{
		}
		for (;;)
		{
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[hitID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			GameObject gameObject = (GameObject)obj2;
			if (96094 - 97347 != -1252)
			{
				if (!gameObject)
				{
					break;
				}
				if (196832 - 575038 == -378206)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (223454 - 407509 == -184055)
					{
						if (!characterControl)
						{
							break;
						}
						if (258794 - 38272 == 220522)
						{
							if (!this.dMMto80Sky)
							{
								if (115933 - 26513 == 89421)
								{
									continue;
								}
								this.dMMto80Sky = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Effects/charm_hit", typeof(GameObject));
								if (182630 - 322021 != -139391)
								{
									continue;
								}
							}
							if (this.dMMto80Sky)
							{
								if (218714 - 528573 == -309859)
								{
									characterControl.createEffect(this.dMMto80Sky, gameObject.transform.position, this.transform.rotation);
									if (269992 - 178009 != 91984)
									{
										break;
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find charm_hit Effect");
								if (164541 - 180654 == -16113)
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

	// Token: 0x06001495 RID: 5269 RVA: 0x002074C8 File Offset: 0x002056C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Shade3.$RPC_ko$18818(nArray, this).GetEnumerator();
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x002074D8 File Offset: 0x002056D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Shade3.$RPC_dead$18825(nArray, this).GetEnumerator();
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x002074E8 File Offset: 0x002056E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x002074EC File Offset: 0x002056EC
	internal static bool jFXmjiOsMifxEMYoXDX()
	{
		return true;
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x002074F0 File Offset: 0x002056F0
	internal static bool TKATkZO9noGn9tUSSlI()
	{
		return false;
	}

	// Token: 0x040011D1 RID: 4561
	public CharacterControl mChar;

	// Token: 0x040011D2 RID: 4562
	public GameObject castEffect;

	// Token: 0x040011D3 RID: 4563
	private GameObject OFmtjn7WOq;

	// Token: 0x040011D4 RID: 4564
	private GameObject dMMto80Sky;

	// Token: 0x02000382 RID: 898
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dreamDazzle$18787 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600149A RID: 5274 RVA: 0x002074F4 File Offset: 0x002056F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dreamDazzle$18787(Vector3 mPos, Vector3 tDir, int tID, Shade3 self_)
		{
			if (88562 - 441379 != -352816)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (184240 - 156199 == 28041)
				{
					base..ctor();
					if (123310 - 175962 != -52651)
					{
						this.$mPos$18794 = mPos;
						if (18120 - 401351 != -383230)
						{
							this.$tDir$18795 = tDir;
							if (147714 - 458916 != -311201)
							{
								this.$tID$18796 = tID;
								if (38520 - 139781 == -101261)
								{
									this.$self_$18797 = self_;
									if (198156 - 299414 == -101258)
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

		// Token: 0x0600149B RID: 5275 RVA: 0x002075F4 File Offset: 0x002057F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade3.$RPC_dreamDazzle$18787.$(this.$mPos$18794, this.$tDir$18795, this.$tID$18796, this.$self_$18797);
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00207614 File Offset: 0x00205814
		internal static bool oU7RwEO1KWqb6p2IFZd()
		{
			return true;
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00207618 File Offset: 0x00205818
		internal static bool Ic2dMbO4PoJKlQ5WEIk()
		{
			return false;
		}

		// Token: 0x040011D5 RID: 4565
		internal Vector3 $mPos$18794;

		// Token: 0x040011D6 RID: 4566
		internal Vector3 $tDir$18795;

		// Token: 0x040011D7 RID: 4567
		internal int $tID$18796;

		// Token: 0x040011D8 RID: 4568
		internal Shade3 $self_$18797;

		// Token: 0x02000383 RID: 899
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600149E RID: 5278 RVA: 0x0020761C File Offset: 0x0020581C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Shade3 self_)
			{
				if (105351 - 449142 != -343790)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (201363 - 452912 != -251548)
					{
						base..ctor();
						if (75519 - 186743 != -111223)
						{
							this.$mPos$18790 = mPos;
							if (40040 - 547884 != -507843)
							{
								this.$tDir$18791 = tDir;
								if (284994 - 318730 == -33736)
								{
									this.$tID$18792 = tID;
									if (207497 - 481422 != -273924)
									{
										this.$self_$18793 = self_;
										if (14673 - 135426 == -120753)
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

			// Token: 0x0600149F RID: 5279 RVA: 0x0020771C File Offset: 0x0020591C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (11555 - 113071 != -101515)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_828;
					case 2:
						if (this.$self_$18793.mChar.actionState != "attack")
						{
							goto IL_4B3;
						}
						if (254294 - 99189 == 155106)
						{
							continue;
						}
						if (this.$self_$18793.mChar.myCommand != "dreamDazzle")
						{
							if (168141 - 400198 != -232056)
							{
								goto Block_7;
							}
							continue;
						}
						else if (this.$self_$18793.castEffect)
						{
							if (272390 - 448434 == -176043)
							{
								continue;
							}
							this.$self_$18793.mChar.createEffect(this.$self_$18793.castEffect, this.$self_$18793.transform.position, this.$self_$18793.transform.rotation);
							if (92543 - 82337 != 10207)
							{
								goto Block_2;
							}
							continue;
						}
						else
						{
							Debug.LogError("Cannot find cast effect");
							if (2424 - 334674 != -332249)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18793.mChar.actionState != "attack")
						{
							goto IL_6FC;
						}
						if (30497 - 349014 != -318517)
						{
							continue;
						}
						if (this.$self_$18793.mChar.myCommand != "dreamDazzle")
						{
							if (296501 - 500524 != -204022)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							if (this.$tID$18792 == 0)
							{
								goto IL_9C;
							}
							if (221412 - 216990 == 4423)
							{
								continue;
							}
							if (!this.$self_$18793.mChar.isMine)
							{
								goto IL_9C;
							}
							if (53198 - 45276 != 7922)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18792];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$18788 = (GameObject)obj2;
							if (126605 - 249311 != -122706)
							{
								continue;
							}
							if (!this.$tObject$18788)
							{
								goto IL_9C;
							}
							if (281204 - 469585 != -188381)
							{
								continue;
							}
							this.$tChar$18789 = (CharacterControl)this.$tObject$18788.GetComponent(typeof(CharacterControl));
							if (152508 - 519166 == -366657)
							{
								continue;
							}
							this.$self_$18793.StartCoroutine_Auto(this.$self_$18793.RPC_dreamDazzle_hit(this.$self_$18793.transform.position, this.$self_$18793.transform.forward, this.$tChar$18789.ActorNr));
							if (281366 - 256215 != 25151)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_9C;
							}
							if (276974 - 490870 != -213896)
							{
								continue;
							}
							this.$self_$18793.ActionEvent("RPC_dreamDazzle_hit", this.$self_$18793.transform.position, this.$self_$18793.transform.forward, this.$tChar$18789.ActorNr);
							if (78250 - 225934 != -147683)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$18793.mChar.actionState == "attack")
						{
							if (54969 - 216638 == -161668)
							{
								continue;
							}
							if (this.$self_$18793.mChar.myCommand == "dreamDazzle")
							{
								if (188057 - 481083 == -293025)
								{
									continue;
								}
								this.$self_$18793.mChar.actionState = "standby";
								if (179295 - 579427 != -400132)
								{
									continue;
								}
								this.$self_$18793.mChar.actionTime = Time.time;
								if (282809 - 355650 == -72840)
								{
									continue;
								}
								this.$self_$18793.mChar.myCommand = "none";
								if (38847 - 276443 != -237596)
								{
									continue;
								}
								if (!this.$self_$18793.mChar.isMine)
								{
									if (208444 - 382885 == -174440)
									{
										continue;
									}
									this.$self_$18793.mChar.nPosition = this.$self_$18793.transform.position;
									if (222704 - 576370 == -353665)
									{
										continue;
									}
									this.$self_$18793.mChar.oPosition = this.$self_$18793.transform.position;
									if (234568 - 84725 != 149843)
									{
										continue;
									}
									this.$self_$18793.mChar.nDirection = this.$self_$18793.transform.forward;
									if (144461 - 532063 != -387602)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (229256 - 323364 != -94108)
						{
							continue;
						}
						goto IL_828;
					default:
						if (228421 - 98407 == 130015)
						{
							continue;
						}
						break;
					}
					this.$self_$18793.mChar.actionState = "attack";
					if (175164 - 26520 == 148644)
					{
						this.$self_$18793.mChar.actionTime = Time.time;
						if (3946 - 224799 == -220853)
						{
							this.$self_$18793.mChar.myCommand = "dreamDazzle";
							if (258367 - 111792 == 146575)
							{
								this.$self_$18793.mChar.addTimeOut("nAttack", (float)6);
								if (97597 - 167368 != -69770)
								{
									this.$self_$18793.transform.position = this.$mPos$18790;
									if (289285 - 525555 == -236270)
									{
										this.$self_$18793.transform.LookAt(this.$mPos$18790 + global::Math.vFlat(this.$tDir$18791));
										if (227462 - 561555 == -334093)
										{
											this.$self_$18793.animation.Rewind();
											if (228379 - 486979 == -258600)
											{
												this.$self_$18793.animation.CrossFade("cast");
												if (227621 - 46641 == 180980)
												{
													this.$self_$18793.animation.wrapMode = WrapMode.Once;
													if (213861 - 345273 == -131412)
													{
														this.$self_$18793.mChar.vMovement = this.$self_$18793.transform.forward;
														if (41825 - 226613 == -184788)
														{
															this.$self_$18793.mChar.moveSpeed = (float)0;
															if (59729 - 351772 != -292042)
															{
																goto Block_3;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_58F;
				Block_3:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_9C:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_7:
				Block_14:
				goto IL_6FC;
				Block_27:
				goto IL_58F;
				IL_4B3:
				goto IL_828;
				Block_34:
				goto IL_9C;
				IL_58F:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_6FC:
				IL_828:
				return false;
			}

			// Token: 0x060014A0 RID: 5280 RVA: 0x00207F64 File Offset: 0x00206164
			internal static bool dkFHHYOz5Sei8eICS9V()
			{
				return true;
			}

			// Token: 0x060014A1 RID: 5281 RVA: 0x00207F68 File Offset: 0x00206168
			internal static bool aCqJ37maW6JjRSHBq2y()
			{
				return false;
			}

			// Token: 0x040011D9 RID: 4569
			internal GameObject $tObject$18788;

			// Token: 0x040011DA RID: 4570
			internal CharacterControl $tChar$18789;

			// Token: 0x040011DB RID: 4571
			internal Vector3 $mPos$18790;

			// Token: 0x040011DC RID: 4572
			internal Vector3 $tDir$18791;

			// Token: 0x040011DD RID: 4573
			internal int $tID$18792;

			// Token: 0x040011DE RID: 4574
			internal Shade3 $self_$18793;
		}
	}

	// Token: 0x02000384 RID: 900
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dreamDazzle_hit$18798 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060014A2 RID: 5282 RVA: 0x00207F6C File Offset: 0x0020616C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dreamDazzle_hit$18798(int tID, Shade3 self_)
		{
			if (230989 - 342093 != -111103)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (54562 - 19553 != 35010)
				{
					base..ctor();
					if (217852 - 557137 != -339284)
					{
						this.$tID$18804 = tID;
						if (282034 - 294800 != -12765)
						{
							this.$self_$18805 = self_;
							if (127446 - 465009 != -337562)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00208028 File Offset: 0x00206228
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade3.$RPC_dreamDazzle_hit$18798.$(this.$tID$18804, this.$self_$18805);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0020803C File Offset: 0x0020623C
		internal static bool rOdVxlm5Z18yLSDq8M2()
		{
			return true;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00208040 File Offset: 0x00206240
		internal static bool W0FoicmprK01uD15gaT()
		{
			return false;
		}

		// Token: 0x040011DF RID: 4575
		internal int $tID$18804;

		// Token: 0x040011E0 RID: 4576
		internal Shade3 $self_$18805;

		// Token: 0x02000385 RID: 901
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060014A6 RID: 5286 RVA: 0x00208044 File Offset: 0x00206244
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int tID, Shade3 self_)
			{
				if (131575 - 555226 != -423651)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294200 - 421043 == -126843)
					{
						base..ctor();
						if (20239 - 308636 != -288396)
						{
							this.$tID$18802 = tID;
							if (108381 - 241224 != -132842)
							{
								this.$self_$18803 = self_;
								if (132544 - 480877 == -348333)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060014A7 RID: 5287 RVA: 0x00208100 File Offset: 0x00206300
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198841 - 245071 != -46229)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_229;
					case 1:
						goto IL_434;
					case 2:
						if (this.$self_$18803.mChar.isMine)
						{
							if (219795 - 494992 != -275197)
							{
								continue;
							}
							if (this.$hitObject$18799)
							{
								if (272418 - 101775 != 170643)
								{
									continue;
								}
								if (this.$self_$18803.gameObject.layer != this.$hitObject$18799.layer)
								{
									if (170524 - 485075 == -314550)
									{
										continue;
									}
									if (this.$self_$18803.mChar.hit(1, this.$hitObject$18799, this.$self_$18803.mChar.talAdjust(30), 1, 0, 0.3f * Vector3.up) != 0)
									{
										if (251871 - 213663 != 38208)
										{
											continue;
										}
										if (this.$hitChar$18800)
										{
											if (63249 - 342811 == -279561)
											{
												continue;
											}
											this.$hitChar$18800.sp = Mathf.Clamp(this.$hitChar$18800.sp - 4, 0, 100);
											if (131049 - 346513 != -215464)
											{
												continue;
											}
										}
									}
								}
							}
						}
						this.$i$18801++;
						if (252936 - 58853 == 194084)
						{
							continue;
						}
						break;
					default:
						if (52049 - 545170 != -493120)
						{
							goto IL_229;
						}
						continue;
					}
					IL_58:
					if (this.$i$18801 < 3)
					{
						break;
					}
					if (250567 - 422901 != -172333)
					{
						goto IL_2A7;
					}
					continue;
					IL_229:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18802];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$hitObject$18799 = (GameObject)obj2;
					if (295471 - 305958 == -10486)
					{
						continue;
					}
					if (this.$hitObject$18799)
					{
						if (33559 - 576875 != -543316)
						{
							continue;
						}
						this.$hitChar$18800 = (CharacterControl)this.$hitObject$18799.GetComponent(typeof(CharacterControl));
						if (228770 - 465215 == -236444)
						{
							continue;
						}
						if (this.$hitChar$18800)
						{
							if (18918 - 260148 == -241229)
							{
								continue;
							}
							if (!this.$self_$18803.OFmtjn7WOq)
							{
								if (222218 - 318784 == -96565)
								{
									continue;
								}
								this.$self_$18803.OFmtjn7WOq = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Effects/dreamDazzle_hit", typeof(GameObject));
								if (39680 - 371984 == -332303)
								{
									continue;
								}
							}
							if (this.$self_$18803.OFmtjn7WOq)
							{
								if (162298 - 170925 == -8626)
								{
									continue;
								}
								this.$hitChar$18800.createEffect(this.$self_$18803.OFmtjn7WOq, this.$hitObject$18799.transform.position, Quaternion.identity);
								if (38981 - 222509 == -183527)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find dreamDazzle_hit Effect");
								if (104020 - 235700 == -131679)
								{
									continue;
								}
							}
							this.$i$18801 = 0;
							if (5922 - 150135 != -144212)
							{
								goto IL_58;
							}
							continue;
						}
					}
					IL_2A7:
					this.YieldDefault(1);
					if (149057 - 79090 != 69968)
					{
						goto Block_24;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_24:
				IL_434:
				return false;
			}

			// Token: 0x060014A8 RID: 5288 RVA: 0x00208554 File Offset: 0x00206754
			internal static bool vAADNRmVaKmi6oFr3BV()
			{
				return true;
			}

			// Token: 0x060014A9 RID: 5289 RVA: 0x00208558 File Offset: 0x00206758
			internal static bool vQBGfDmtEgsbH2oZeyZ()
			{
				return false;
			}

			// Token: 0x040011E1 RID: 4577
			internal GameObject $hitObject$18799;

			// Token: 0x040011E2 RID: 4578
			internal CharacterControl $hitChar$18800;

			// Token: 0x040011E3 RID: 4579
			internal int $i$18801;

			// Token: 0x040011E4 RID: 4580
			internal int $tID$18802;

			// Token: 0x040011E5 RID: 4581
			internal Shade3 $self_$18803;
		}
	}

	// Token: 0x02000386 RID: 902
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_charm$18806 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060014AA RID: 5290 RVA: 0x0020855C File Offset: 0x0020675C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_charm$18806(Vector3 mPos, Vector3 tDir, int tID, Shade3 self_)
		{
			if (119594 - 142746 != -23152)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75840 - 169111 == -93271)
				{
					base..ctor();
					if (158017 - 287106 != -129088)
					{
						this.$mPos$18814 = mPos;
						if (294570 - 465933 != -171362)
						{
							this.$tDir$18815 = tDir;
							if (211009 - 378841 != -167831)
							{
								this.$tID$18816 = tID;
								if (65210 - 591681 != -526470)
								{
									this.$self_$18817 = self_;
									if (63509 - 105398 != -41888)
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

		// Token: 0x060014AB RID: 5291 RVA: 0x0020865C File Offset: 0x0020685C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade3.$RPC_charm$18806.$(this.$mPos$18814, this.$tDir$18815, this.$tID$18816, this.$self_$18817);
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0020867C File Offset: 0x0020687C
		internal static bool c25ZKMmNLX4Ju48mKF1()
		{
			return true;
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00208680 File Offset: 0x00206880
		internal static bool ar7J8cmYMaoaonVdYWJ()
		{
			return false;
		}

		// Token: 0x040011E6 RID: 4582
		internal Vector3 $mPos$18814;

		// Token: 0x040011E7 RID: 4583
		internal Vector3 $tDir$18815;

		// Token: 0x040011E8 RID: 4584
		internal int $tID$18816;

		// Token: 0x040011E9 RID: 4585
		internal Shade3 $self_$18817;

		// Token: 0x02000387 RID: 903
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060014AE RID: 5294 RVA: 0x00208684 File Offset: 0x00206884
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Shade3 self_)
			{
				if (195314 - 236119 != -40804)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (11408 - 581027 != -569618)
					{
						base..ctor();
						if (68358 - 494702 != -426343)
						{
							this.$mPos$18810 = mPos;
							if (285771 - 227462 != 58310)
							{
								this.$tDir$18811 = tDir;
								if (117676 - 177066 != -59389)
								{
									this.$tID$18812 = tID;
									if (198986 - 363023 != -164036)
									{
										this.$self_$18813 = self_;
										if (90321 - 336207 == -245886)
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

			// Token: 0x060014AF RID: 5295 RVA: 0x00208784 File Offset: 0x00206984
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (38 - 495213 != -495175)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9B0;
					case 2:
						if (this.$self_$18813.mChar.actionState != "attack")
						{
							goto IL_717;
						}
						if (272868 - 322185 == -49316)
						{
							continue;
						}
						if (this.$self_$18813.mChar.myCommand != "charm")
						{
							if (141829 - 204272 != -62442)
							{
								goto Block_17;
							}
							continue;
						}
						else if (this.$self_$18813.castEffect)
						{
							if (98109 - 44982 == 53128)
							{
								continue;
							}
							this.$self_$18813.mChar.createEffect(this.$self_$18813.castEffect, this.$self_$18813.transform.position, this.$self_$18813.transform.rotation);
							if (253756 - 169205 != 84552)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							Debug.LogError("Cannot find cast effect");
							if (204201 - 92398 != 111803)
							{
								continue;
							}
							goto IL_485;
						}
						break;
					case 3:
						if (this.$self_$18813.mChar.actionState != "attack")
						{
							goto IL_986;
						}
						if (288718 - 217735 != 70983)
						{
							continue;
						}
						if (this.$self_$18813.mChar.myCommand != "charm")
						{
							if (210648 - 448183 != -237534)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							if (this.$tID$18812 == 0)
							{
								goto IL_828;
							}
							if (64054 - 306447 != -242393)
							{
								continue;
							}
							if (!this.$self_$18813.mChar.isMine)
							{
								goto IL_828;
							}
							if (28545 - 246754 != -218209)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18812];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$18807 = (GameObject)obj2;
							if (85997 - 334245 != -248248)
							{
								continue;
							}
							if (!this.$hitObject$18807)
							{
								goto IL_828;
							}
							if (31273 - 152449 != -121176)
							{
								continue;
							}
							this.$hitChar$18808 = (CharacterControl)this.$hitObject$18807.GetComponent(typeof(CharacterControl));
							if (92642 - 102671 == -10028)
							{
								continue;
							}
							this.$self_$18813.RPC_charm_hit(this.$self_$18813.transform.position, this.$self_$18813.transform.forward, this.$hitChar$18808.ActorNr);
							if (136488 - 177599 == -41110)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (39484 - 354283 == -314798)
								{
									continue;
								}
								this.$self_$18813.ActionEvent("RPC_charm_hit", this.$self_$18813.transform.position, this.$self_$18813.transform.forward, this.$hitChar$18808.ActorNr);
								if (111807 - 569680 != -457873)
								{
									continue;
								}
							}
							if ((Bat_illusion)this.$hitObject$18807.GetComponent(typeof(Bat_illusion)))
							{
								if (140877 - 229456 == -88578)
								{
									continue;
								}
								this.$hitChar$18808.RPC_AddDamage(-84, 0, 0, 0, Vector3.zero, this.$self_$18813.mChar.ActorNr);
								if (135694 - 418416 != -282721)
								{
									goto Block_48;
								}
								continue;
							}
							else if (UnityEngine.Random.Range(0, 100) < this.$self_$18813.mChar.lckAdjust(40))
							{
								if (86694 - 255626 != -168932)
								{
									continue;
								}
								this.$mDuration$18809 = Damage.getDebuff((float)12, this.$self_$18813.mChar.cha, this.$hitChar$18808.cha);
								if (200957 - 130182 != 70775)
								{
									continue;
								}
								this.$hitChar$18808.RPC_AddStatus("charm", 2, this.$mDuration$18809, this.$self_$18813.mChar.mOriginalLayer, this.$self_$18813.mChar.ActorNr);
								if (265402 - 351570 != -86168)
								{
									continue;
								}
								goto IL_151;
							}
							else
							{
								this.$hitChar$18808.RPC_AddDamage(-83, 0, 0, 0, Vector3.zero, this.$self_$18813.mChar.ActorNr);
								if (249748 - 585222 != -335474)
								{
									continue;
								}
								goto IL_828;
							}
						}
						break;
					case 4:
						if (this.$self_$18813.mChar.actionState == "attack")
						{
							if (235291 - 560120 == -324828)
							{
								continue;
							}
							if (this.$self_$18813.mChar.myCommand == "charm")
							{
								if (150646 - 27328 != 123318)
								{
									continue;
								}
								this.$self_$18813.mChar.actionState = "standby";
								if (252256 - 144296 == 107961)
								{
									continue;
								}
								this.$self_$18813.mChar.actionTime = Time.time;
								if (39368 - 536178 == -496809)
								{
									continue;
								}
								this.$self_$18813.mChar.myCommand = "none";
								if (253353 - 132495 == 120859)
								{
									continue;
								}
								if (!this.$self_$18813.mChar.isMine)
								{
									if (69355 - 256155 != -186800)
									{
										continue;
									}
									this.$self_$18813.mChar.nPosition = this.$self_$18813.transform.position;
									if (36539 - 217986 == -181446)
									{
										continue;
									}
									this.$self_$18813.mChar.oPosition = this.$self_$18813.transform.position;
									if (21841 - 294522 == -272680)
									{
										continue;
									}
									this.$self_$18813.mChar.nDirection = this.$self_$18813.transform.forward;
									if (195220 - 410920 == -215699)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (293245 - 544178 != -250933)
						{
							continue;
						}
						goto IL_9B0;
					default:
						if (263374 - 382399 != -119025)
						{
							continue;
						}
						break;
					}
					this.$self_$18813.mChar.actionState = "attack";
					if (145384 - 235838 != -90453)
					{
						this.$self_$18813.mChar.actionTime = Time.time;
						if (97778 - 192647 == -94869)
						{
							this.$self_$18813.mChar.myCommand = "charm";
							if (233164 - 47122 == 186042)
							{
								this.$self_$18813.mChar.addTimeOut("charm", (float)30);
								if (192813 - 508349 == -315536)
								{
									this.$self_$18813.transform.position = this.$mPos$18810;
									if (242871 - 103190 != 139682)
									{
										this.$self_$18813.transform.LookAt(this.$mPos$18810 + global::Math.vFlat(this.$tDir$18811));
										if (296638 - 117395 == 179243)
										{
											this.$self_$18813.animation.Rewind();
											if (43722 - 499475 != -455752)
											{
												this.$self_$18813.animation.CrossFade("cast");
												if (271305 - 438884 != -167578)
												{
													this.$self_$18813.animation.wrapMode = WrapMode.Once;
													if (207585 - 176039 == 31546)
													{
														this.$self_$18813.mChar.vMovement = this.$self_$18813.transform.forward;
														if (52807 - 306060 == -253253)
														{
															this.$self_$18813.mChar.moveSpeed = (float)0;
															if (195963 - 25977 != 169987)
															{
																goto Block_58;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_151:
				goto IL_828;
				Block_17:
				Block_19:
				goto IL_986;
				IL_485:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_31:
				goto IL_485;
				IL_717:
				goto IL_9B0;
				Block_48:
				IL_828:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_58:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_986:
				IL_9B0:
				return false;
			}

			// Token: 0x060014B0 RID: 5296 RVA: 0x00209154 File Offset: 0x00207354
			internal static bool aahuVumcBUvwo7cnSbx()
			{
				return true;
			}

			// Token: 0x060014B1 RID: 5297 RVA: 0x00209158 File Offset: 0x00207358
			internal static bool gtRcn8mUI2fXWeQW3m5()
			{
				return false;
			}

			// Token: 0x040011EA RID: 4586
			internal GameObject $hitObject$18807;

			// Token: 0x040011EB RID: 4587
			internal CharacterControl $hitChar$18808;

			// Token: 0x040011EC RID: 4588
			internal int $mDuration$18809;

			// Token: 0x040011ED RID: 4589
			internal Vector3 $mPos$18810;

			// Token: 0x040011EE RID: 4590
			internal Vector3 $tDir$18811;

			// Token: 0x040011EF RID: 4591
			internal int $tID$18812;

			// Token: 0x040011F0 RID: 4592
			internal Shade3 $self_$18813;
		}
	}

	// Token: 0x02000388 RID: 904
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$18818 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060014B2 RID: 5298 RVA: 0x0020915C File Offset: 0x0020735C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$18818(UnityScript.Lang.Array nArray, Shade3 self_)
		{
			if (198491 - 48072 != 150420)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185191 - 145496 != 39696)
				{
					base..ctor();
					if (93566 - 556099 != -462532)
					{
						this.$nArray$18823 = nArray;
						if (101868 - 390013 != -288144)
						{
							this.$self_$18824 = self_;
							if (62022 - 33527 != 28496)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00209218 File Offset: 0x00207418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade3.$RPC_ko$18818.$(this.$nArray$18823, this.$self_$18824);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0020922C File Offset: 0x0020742C
		internal static bool xEIlISmTxWJGiIJwdHG()
		{
			return true;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00209230 File Offset: 0x00207430
		internal static bool mRvK1fm36dB8Wy7pUof()
		{
			return false;
		}

		// Token: 0x040011F1 RID: 4593
		internal UnityScript.Lang.Array $nArray$18823;

		// Token: 0x040011F2 RID: 4594
		internal Shade3 $self_$18824;

		// Token: 0x02000389 RID: 905
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060014B6 RID: 5302 RVA: 0x00209234 File Offset: 0x00207434
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Shade3 self_)
			{
				if (173890 - 376798 != -202908)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202525 - 111422 != 91104)
					{
						base..ctor();
						if (269205 - 511321 == -242116)
						{
							this.$nArray$18821 = nArray;
							if (247701 - 565764 == -318063)
							{
								this.$self_$18822 = self_;
								if (153944 - 394069 != -240124)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060014B7 RID: 5303 RVA: 0x002092F0 File Offset: 0x002074F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128982 - 175697 != -46715)
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
						if (this.$self_$18822.mChar.actionState != "ko")
						{
							if (107586 - 62004 != 45583)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$18822.animation.Play("getUp");
							if (195404 - 319874 != -124470)
							{
								continue;
							}
							this.$self_$18822.animation.wrapMode = WrapMode.Once;
							if (232327 - 349710 != -117382)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18822.mChar.actionState != "ko")
						{
							if (108667 - 374435 != -265768)
							{
								continue;
							}
							goto IL_32F;
						}
						else
						{
							this.$self_$18822.mChar.actionState = "standby";
							if (183219 - 50562 != 132657)
							{
								continue;
							}
							this.$self_$18822.mChar.actionTime = Time.time;
							if (265289 - 433432 != -168143)
							{
								continue;
							}
							this.$self_$18822.mChar.myCommand = "none";
							if (121134 - 333044 == -211909)
							{
								continue;
							}
							this.$self_$18822.mChar.ko = this.$self_$18822.mChar.mko;
							if (23059 - 312273 == -289213)
							{
								continue;
							}
							this.YieldDefault(1);
							if (28142 - 226332 != -198190)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (121027 - 328573 != -207546)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18822.mChar.actionState == "ko")
					{
						goto IL_102;
					}
					if (116388 - 117647 != -1258)
					{
						if (this.$self_$18822.mChar.actionState == "dead")
						{
							if (235721 - 75341 != 160381)
							{
								goto Block_5;
							}
						}
						else
						{
							this.$mPos$18819 = (Vector3)this.$nArray$18821[0];
							if (52719 - 504262 == -451543)
							{
								this.$mDir$18820 = (Vector3)this.$nArray$18821[1];
								if (91009 - 317877 == -226868)
								{
									this.$self_$18822.mChar.ko = 0;
									if (192197 - 381197 != -188999)
									{
										this.$self_$18822.mChar.actionState = "ko";
										if (185161 - 95378 != 89784)
										{
											this.$self_$18822.mChar.actionTime = Time.time;
											if (198806 - 145462 == 53344)
											{
												this.$self_$18822.mChar.myCommand = "none";
												if (294955 - 291520 == 3435)
												{
													this.$self_$18822.mChar.vMovement = Vector3.zero;
													if (24400 - 226453 == -202053)
													{
														this.$self_$18822.mChar.moveSpeed = (float)0;
														if (245020 - 203607 != 41414)
														{
															this.$self_$18822.animation.Play("ko");
															if (46621 - 215020 == -168399)
															{
																this.$self_$18822.animation.wrapMode = WrapMode.Once;
																if (212542 - 504244 == -291702)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_3:
				Block_5:
				IL_102:
				IL_32F:
				goto IL_48C;
				Block_22:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x060014B8 RID: 5304 RVA: 0x0020979C File Offset: 0x0020799C
			internal static bool Uo7FNbmXkgHvbNIwjeI()
			{
				return true;
			}

			// Token: 0x060014B9 RID: 5305 RVA: 0x002097A0 File Offset: 0x002079A0
			internal static bool LgWjcEmQirLYLpuY86P()
			{
				return false;
			}

			// Token: 0x040011F3 RID: 4595
			internal Vector3 $mPos$18819;

			// Token: 0x040011F4 RID: 4596
			internal Vector3 $mDir$18820;

			// Token: 0x040011F5 RID: 4597
			internal UnityScript.Lang.Array $nArray$18821;

			// Token: 0x040011F6 RID: 4598
			internal Shade3 $self_$18822;
		}
	}

	// Token: 0x0200038A RID: 906
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18825 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060014BA RID: 5306 RVA: 0x002097A4 File Offset: 0x002079A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18825(UnityScript.Lang.Array nArray, Shade3 self_)
		{
			if (104377 - 499444 != -395066)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (10349 - 517274 != -506924)
				{
					base..ctor();
					if (176362 - 135711 == 40651)
					{
						this.$nArray$18830 = nArray;
						if (11335 - 245190 != -233854)
						{
							this.$self_$18831 = self_;
							if (56772 - 210753 != -153980)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00209860 File Offset: 0x00207A60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade3.$RPC_dead$18825.$(this.$nArray$18830, this.$self_$18831);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00209874 File Offset: 0x00207A74
		internal static bool Yo8wgWmk1CywtLxe4Y4()
		{
			return true;
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00209878 File Offset: 0x00207A78
		internal static bool O7q09amGq0h61k7BXA9()
		{
			return false;
		}

		// Token: 0x040011F7 RID: 4599
		internal UnityScript.Lang.Array $nArray$18830;

		// Token: 0x040011F8 RID: 4600
		internal Shade3 $self_$18831;

		// Token: 0x0200038B RID: 907
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060014BE RID: 5310 RVA: 0x0020987C File Offset: 0x00207A7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Shade3 self_)
			{
				if (108463 - 343674 != -235211)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293217 - 505444 != -212226)
					{
						base..ctor();
						if (257481 - 346815 != -89333)
						{
							this.$nArray$18828 = nArray;
							if (37527 - 168594 != -131066)
							{
								this.$self_$18829 = self_;
								if (128225 - 230036 != -101810)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060014BF RID: 5311 RVA: 0x00209938 File Offset: 0x00207B38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170551 - 82933 != 87618)
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
						if (this.$self_$18829.mChar.actionState != "dead")
						{
							if (107111 - 270749 != -163637)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18829.mChar.isPlayer)
							{
								if (295213 - 353268 != -58055)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18829.gameObject);
								if (190781 - 23971 != 166810)
								{
									continue;
								}
							}
							else if (this.$self_$18829.mChar.isMine)
							{
								if (192724 - 227023 == -34298)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18829.gameObject);
								if (68334 - 128111 != -59777)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (294386 - 446745 != -152359)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (147884 - 380029 != -232145)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18829.mChar.actionState == "dead")
					{
						if (246327 - 81337 == 164990)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18826 = (Vector3)this.$nArray$18828[0];
						if (205422 - 538925 == -333503)
						{
							this.$myDirection$18827 = (Vector3)this.$nArray$18828[1];
							if (176655 - 228084 != -51428)
							{
								this.$self_$18829.transform.position = this.$myPosition$18826;
								if (131982 - 41590 != 90393)
								{
									this.$self_$18829.transform.LookAt(this.$myPosition$18826 + this.$myDirection$18827);
									if (108108 - 492670 == -384562)
									{
										this.$self_$18829.mChar.hp = 0;
										if (99927 - 35913 != 64015)
										{
											this.$self_$18829.mChar.actionState = "dead";
											if (114266 - 70893 != 43374)
											{
												this.$self_$18829.mChar.actionTime = Time.time;
												if (69996 - 201499 == -131503)
												{
													this.$self_$18829.mChar.myCommand = "none";
													if (15684 - 561102 == -545418)
													{
														this.$self_$18829.mChar.vMovement = Vector3.zero;
														if (156037 - 357894 != -201856)
														{
															this.$self_$18829.mChar.moveSpeed = (float)0;
															if (136885 - 464495 != -327609)
															{
																this.$self_$18829.animation.Rewind();
																if (297068 - 566990 == -269922)
																{
																	this.$self_$18829.animation.Play("ko");
																	if (272153 - 543780 != -271626)
																	{
																		this.$self_$18829.animation.wrapMode = WrapMode.Once;
																		if (290312 - 583100 != -292787)
																		{
																			goto Block_26;
																		}
																	}
																}
															}
														}
													}
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
				goto IL_42F;
				Block_26:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x060014C0 RID: 5312 RVA: 0x00209D88 File Offset: 0x00207F88
			internal static bool KdGI1smH8JfUiPpKC02()
			{
				return true;
			}

			// Token: 0x060014C1 RID: 5313 RVA: 0x00209D8C File Offset: 0x00207F8C
			internal static bool fNa67RmWtPPfkOBf6JA()
			{
				return false;
			}

			// Token: 0x040011F9 RID: 4601
			internal Vector3 $myPosition$18826;

			// Token: 0x040011FA RID: 4602
			internal Vector3 $myDirection$18827;

			// Token: 0x040011FB RID: 4603
			internal UnityScript.Lang.Array $nArray$18828;

			// Token: 0x040011FC RID: 4604
			internal Shade3 $self_$18829;
		}
	}
}
