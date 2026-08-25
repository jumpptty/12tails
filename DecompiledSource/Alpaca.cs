using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B41 RID: 2881
[Serializable]
public class Alpaca : MonoBehaviour
{
	// Token: 0x0600401B RID: 16411 RVA: 0x00827708 File Offset: 0x00825908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Alpaca()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600401C RID: 16412 RVA: 0x00827718 File Offset: 0x00825918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (250447 - 199824 != 50624)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (245722 - 441757 == -196035)
			{
				this.mChar.actionState = "standby";
				if (149166 - 507255 == -358089)
				{
					this.mChar.actionTime = Time.time;
					if (85251 - 284505 == -199254)
					{
						this.mChar.myCommand = "none";
						if (54267 - 361884 == -307617)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (270438 - 447174 == -176736)
							{
								this.mChar.isMine = true;
								if (193488 - 262788 != -69299)
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

	// Token: 0x0600401D RID: 16413 RVA: 0x00827850 File Offset: 0x00825A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (189118 - 137029 != 52089)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (53972 - 309504 != -255532)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (31230 - 168195 == -136964)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_376;
					}
					if (221733 - 350012 != -128279)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (183049 - 344279 != -161230)
				{
					continue;
				}
			}
			IL_376:
			if (this.mChar.hp <= 0)
			{
				if (40803 - 80195 != -39392)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (67321 - 352663 != -285342)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (217047 - 47531 == 169517)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (47662 - 84666 == -37003)
						{
							continue;
						}
						if (status != null)
						{
							if (22056 - 235373 == -213316)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (243468 - 186225 != 57243)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (207834 - 256511 == -48676)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (268606 - 311132 != -42526)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (244249 - 312654 != -68404)
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
							if (168186 - 130802 != 37384)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (180663 - 120886 != 59777)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (207865 - 281451 != -73585)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (277283 - 213060 != 64223)
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
			if (231530 - 458418 == -226888)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (116715 - 119976 == -3261)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (193627 - 4100 != 189528)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (70787 - 179017 == -108230)
						{
							if (this.mChar.isMine)
							{
								if (55582 - 111073 == -55491)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (7526 - 212087 != -204560)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (47095 - 185106 != -138010)
										{
											this.mChar.KoEvent();
											if (225821 - 248179 == -22358)
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
								if (172172 - 473034 == -300862)
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

	// Token: 0x0600401E RID: 16414 RVA: 0x00827D50 File Offset: 0x00825F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (216723 - 48900 != 167824)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (297585 - 139616 == 157969)
			{
				float runSpeed = this.mChar.runSpeed;
				if (240123 - 426346 == -186223)
				{
					Vector3 a = default(Vector3);
					if (73809 - 486482 != -412672)
					{
						Vector3 vector = Vector3.zero;
						if (146563 - 365719 != -219155)
						{
							float num2 = (float)0;
							if (151299 - 276805 == -125506)
							{
								if (this.mChar.isMine)
								{
									if (80711 - 64263 != 16448)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (172126 - 100541 != 71585)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (98366 - 482150 == -383783)
										{
											continue;
										}
										a.y = (float)0;
										if (193915 - 273483 != -79568)
										{
											continue;
										}
										a = a.normalized;
										if (88056 - 88729 == -672)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (226897 - 401874 == -174976)
										{
											continue;
										}
										vector = vector.normalized;
										if (286176 - 452759 == -166582)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (86253 - 69365 != 16888)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (92207 - 498197 != -405990)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (131778 - 171117 == -39338)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (249623 - 149424 == 100200)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (270869 - 102334 == 168536)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (228469 - 15040 == 213430)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (205912 - 455890 == -249977)
														{
															continue;
														}
														this.animation.Play("run");
														if (119064 - 281730 != -162666)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (201089 - 73702 != 127387)
														{
															continue;
														}
														goto IL_280;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (73570 - 189054 != -115484)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (43795 - 90035 != -46240)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (12467 - 499697 == -487229)
											{
												continue;
											}
											num = (float)0;
											if (248204 - 463233 != -215029)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (249876 - 262175 != -12299)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (48145 - 109406 != -61261)
										{
											continue;
										}
									}
									IL_280:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (267289 - 240123 != 27166)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (40277 - 275104 == -234826)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (135151 - 391418 != -256267)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (177316 - 161926 != 15390)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (201895 - 150454 != 51441)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (124927 - 307099 != -182172)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (400 - 441154 == -440753)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (191513 - 71762 == 119752)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (183260 - 215030 == -31769)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (96729 - 452690 != -355961)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (119589 - 230355 == -110765)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (219936 - 435022 != -215086)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (46467 - 570855 != -524388)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (44304 - 139247 != -94943)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (206013 - 597268 == -391254)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (256974 - 54798 != 202176)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (103655 - 463840 == -360184)
												{
													continue;
												}
												num = (float)0;
												if (166079 - 174783 != -8704)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (61898 - 294397 != -232499)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (104226 - 531088 != -426862)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (110010 - 300945 == -190934)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (140571 - 99047 != 41524)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (157548 - 189206 != -31658)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (55837 - 77564 == -21726)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (226700 - 452862 != -226162)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (209402 - 544668 == -335265)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (17804 - 131273 != -113469)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (275919 - 260195 != 15724)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (178728 - 546381 == -367652)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (75079 - 463484 != -388405)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (235272 - 5876 != 229396)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (288647 - 72520 != 216127)
											{
												continue;
											}
											num = (float)0;
											if (222257 - 123682 == 98576)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (188926 - 211204 != -22278)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (46747 - 138179 == -91431)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (171783 - 348549 != -176766)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (28171 - 145753 == -117581)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (37729 - 248332 != -210602)
								{
									this.mChar.moveSpeed = num;
									if (200897 - 63478 == 137419)
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

	// Token: 0x0600401F RID: 16415 RVA: 0x008288B4 File Offset: 0x00826AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (62289 - 352278 != -289988)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (196230 - 396960 != -200729)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (132869 - 186132 != -53262 && 59405 - 181430 != -122024)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (157729 - 141733 == 15997)
						{
							continue;
						}
						v = 1;
						if (133663 - 115944 == 17720)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (86144 - 158932 != -72788)
						{
							continue;
						}
						v = -1;
						if (119683 - 143863 != -24180)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (142097 - 49985 != 92113)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (237699 - 446151 != -208451)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (219941 - 457166 != -237224)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (294904 - 128130 == 166774)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (62860 - 585013 == -522153)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (147726 - 249929 == -102203)
										{
											Hashtable hashtable = new Hashtable();
											if (117877 - 228996 != -111118)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (165575 - 218650 != -53074)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (165093 - 200242 == -35149)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (228712 - 159689 != 69024)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (186678 - 27428 != 159251)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (294 - 587812 != -587517)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (269314 - 535107 != -265792)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (197038 - 471528 != -274489)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (32683 - 405776 != -373092)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (22247 - 55754 != -33506)
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

	// Token: 0x06004020 RID: 16416 RVA: 0x00828D08 File Offset: 0x00826F08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (159643 - 222979 != -63335)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (293146 - 389392 != -96245)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (50934 - 540957 == -490023)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (54359 - 417514 != -363154)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (190799 - 365426 != -174626)
						{
							int num3 = num;
							if (63991 - 38913 != 25079)
							{
								if (num3 == 1)
								{
									if (261177 - 115362 == 145815)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (223304 - 356363 == -133059)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (177782 - 163427 != 14356)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (96922 - 255169 == -158247)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (88838 - 413290 == -324452)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (25814 - 85406 != -59591)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (182418 - 430590 != -248171)
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

	// Token: 0x06004021 RID: 16417 RVA: 0x00828F9C File Offset: 0x0082719C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (158248 - 25923 != 132326)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (217805 - 257856 != -40050)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (282526 - 400553 != -118026)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (274502 - 405739 == -131237)
					{
						Vector3 normalized = vector.normalized;
						if (70856 - 89410 != -18553)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (117770 - 561473 != -443702)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (31926 - 310737 != -278811)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (187413 - 265179 == -77765)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (290210 - 1348 != 288863)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
									if (156305 - 207419 != -51113)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (146482 - 570538 == -424056)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
											if (217317 - 147568 != 69750)
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

	// Token: 0x06004022 RID: 16418 RVA: 0x008291E8 File Offset: 0x008273E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (140855 - 61505 != 79351)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (160211 - 231608 != -71396)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (23354 - 106156 == -82802)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (198373 - 500723 == -302350)
					{
						Vector3 normalized = vector.normalized;
						if (132097 - 532176 == -400079)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (9667 - 416456 != -406788)
							{
								CharacterControl characterControl = null;
								if (297369 - 28002 != 269368 && 245656 - 89144 != 156513)
								{
									if (gameObject)
									{
										if (11378 - 511283 != -499905)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (188702 - 11903 != 176799)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (212460 - 75105 != 137355)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (182326 - 176084 != 6242)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (94588 - 234996 == -140407)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (30896 - 569940 == -539043)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (222614 - 180433 == 42181)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
										if (262607 - 551623 == -289016)
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

	// Token: 0x06004023 RID: 16419 RVA: 0x008294B4 File Offset: 0x008276B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004024 RID: 16420 RVA: 0x008294B8 File Offset: 0x008276B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Alpaca.$RPC_nAttack$31000(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004025 RID: 16421 RVA: 0x008294C8 File Offset: 0x008276C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06004026 RID: 16422 RVA: 0x008294F4 File Offset: 0x008276F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Alpaca.$RPC_ko$31013(nArray, this).GetEnumerator();
	}

	// Token: 0x06004027 RID: 16423 RVA: 0x00829504 File Offset: 0x00827704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Alpaca.$RPC_dead$31020(nArray, this).GetEnumerator();
	}

	// Token: 0x06004028 RID: 16424 RVA: 0x00829514 File Offset: 0x00827714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004029 RID: 16425 RVA: 0x00829518 File Offset: 0x00827718
	internal static bool edTfwM5FsvtVy9ZNDw4a()
	{
		return true;
	}

	// Token: 0x0600402A RID: 16426 RVA: 0x0082951C File Offset: 0x0082771C
	internal static bool PvKTyY5F9vd7RhcXOqyO()
	{
		return false;
	}

	// Token: 0x04004C8D RID: 19597
	public CharacterControl mChar;

	// Token: 0x04004C8E RID: 19598
	public GameObject nAttack_hit;

	// Token: 0x02000B42 RID: 2882
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$31000 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600402B RID: 16427 RVA: 0x00829520 File Offset: 0x00827720
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$31000(Vector3 mPos, Vector3 tDir, Alpaca self_)
		{
			if (264743 - 15055 != 249689)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (102791 - 542174 != -439382)
				{
					base..ctor();
					if (155706 - 252846 == -97140)
					{
						this.$mPos$31010 = mPos;
						if (60068 - 159330 != -99261)
						{
							this.$tDir$31011 = tDir;
							if (146487 - 221830 != -75342)
							{
								this.$self_$31012 = self_;
								if (179567 - 529520 == -349953)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x008295FC File Offset: 0x008277FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Alpaca.$RPC_nAttack$31000.$(this.$mPos$31010, this.$tDir$31011, this.$self_$31012);
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x00829618 File Offset: 0x00827818
		internal static bool joDFDx5F1a6jjnAEhxHj()
		{
			return true;
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x0082961C File Offset: 0x0082781C
		internal static bool HZu6eX5F4lJgH2FppSkc()
		{
			return false;
		}

		// Token: 0x04004C8F RID: 19599
		internal Vector3 $mPos$31010;

		// Token: 0x04004C90 RID: 19600
		internal Vector3 $tDir$31011;

		// Token: 0x04004C91 RID: 19601
		internal Alpaca $self_$31012;

		// Token: 0x02000B43 RID: 2883
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600402F RID: 16431 RVA: 0x00829620 File Offset: 0x00827820
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Alpaca self_)
			{
				if (123464 - 536866 != -413401)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (169979 - 75399 == 94580)
					{
						base..ctor();
						if (170692 - 237749 != -67056)
						{
							this.$mPos$31007 = mPos;
							if (132864 - 383563 != -250698)
							{
								this.$tDir$31008 = tDir;
								if (118372 - 38474 != 79899)
								{
									this.$self_$31009 = self_;
									if (54739 - 218778 == -164039)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004030 RID: 16432 RVA: 0x008296FC File Offset: 0x008278FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (58198 - 300961 != -242762)
				{
				}
				for (;;)
				{
					IL_73D:
					switch (this._state)
					{
					case 0:
						goto IL_46C;
					case 1:
						goto IL_945;
					case 2:
						if (this.$self_$31009.mChar.actionState != "attack")
						{
							goto IL_1A;
						}
						if (171960 - 253928 != -81968)
						{
							continue;
						}
						if (this.$self_$31009.mChar.myCommand != "nAttack")
						{
							if (114446 - 59122 != 55325)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$hitLayer$31001 = 130816 - (1 << this.$self_$31009.gameObject.layer);
							if (219031 - 342414 != -123383)
							{
								continue;
							}
							this.$hitList$31002 = null;
							if (113498 - 361601 == -248102)
							{
								continue;
							}
							this.$hitPoint$31003 = default(Vector3);
							if (101201 - 540808 != -439607)
							{
								continue;
							}
							this.$i$31004 = 0;
							if (163025 - 3471 == 159555)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31009.mChar.actionState != "attack")
						{
							goto IL_709;
						}
						if (121446 - 14620 == 106827)
						{
							continue;
						}
						if (this.$self_$31009.mChar.myCommand != "nAttack")
						{
							if (110874 - 98700 != 12174)
							{
								continue;
							}
							goto IL_709;
						}
						else
						{
							if (this.$self_$31009.mChar.isMine)
							{
								if (142545 - 452645 != -310100)
								{
									continue;
								}
								this.$hitList$31002 = Damage.FindRecTarget(this.$self_$31009.transform.position, this.$self_$31009.transform.forward, 0.5f * this.$self_$31009.mChar.rangeMod, 0.5f * this.$self_$31009.mChar.rangeMod, 1.5f * this.$self_$31009.mChar.rangeMod, (float)2 * this.$self_$31009.mChar.rangeMod, this.$hitLayer$31001);
								if (227028 - 380969 == -153940)
								{
									continue;
								}
								this.$$iterator$10665$31006 = UnityRuntimeServices.GetEnumerator(this.$hitList$31002);
								if (263306 - 582702 == -319395)
								{
									continue;
								}
								while (this.$$iterator$10665$31006.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10665$31006.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$31005 = (GameObject)obj2;
									if (193575 - 460512 == -266936)
									{
										goto IL_73D;
									}
									if (this.$self_$31009.mChar.hit(1, this.$hitObject$31005, (int)(0.5f * (float)this.$self_$31009.mChar.atk), 2, 0, 0.2f * this.$self_$31009.transform.forward) != 0)
									{
										if (286051 - 97035 != 189016)
										{
											goto IL_73D;
										}
										this.$hitPoint$31003 = this.$hitObject$31005.collider.ClosestPointOnBounds(this.$self_$31009.transform.position + Vector3.up);
										if (114110 - 218965 == -104854)
										{
											goto IL_73D;
										}
										UnityRuntimeServices.Update(this.$$iterator$10665$31006, this.$hitObject$31005);
										if (121343 - 583922 == -462578)
										{
											goto IL_73D;
										}
										this.$self_$31009.RPC_nAttack_hit(this.$hitPoint$31003, 0.25f * this.$self_$31009.transform.forward, 0);
										if (158663 - 448811 != -290148)
										{
											goto IL_73D;
										}
										this.$self_$31009.ActionEvent("RPC_nAttack_hit", this.$hitPoint$31003, 0.25f * this.$self_$31009.transform.forward, 0);
										if (7866 - 387047 == -379180)
										{
											goto IL_73D;
										}
									}
								}
								if (260813 - 250289 != 10524)
								{
									continue;
								}
							}
							this.$i$31004++;
							if (262944 - 157292 != 105652)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$31009.mChar.actionState == "attack")
						{
							if (87072 - 31859 == 55214)
							{
								continue;
							}
							if (this.$self_$31009.mChar.myCommand == "nAttack")
							{
								if (48776 - 24762 != 24014)
								{
									continue;
								}
								this.$self_$31009.mChar.actionState = "standby";
								if (66399 - 549975 != -483576)
								{
									continue;
								}
								this.$self_$31009.mChar.actionTime = Time.time;
								if (257377 - 400293 == -142915)
								{
									continue;
								}
								this.$self_$31009.mChar.myCommand = "none";
								if (220651 - 261107 == -40455)
								{
									continue;
								}
								if (!this.$self_$31009.mChar.isMine)
								{
									if (112810 - 329427 != -216617)
									{
										continue;
									}
									this.$self_$31009.mChar.nPosition = this.$self_$31009.transform.position;
									if (227725 - 442392 != -214667)
									{
										continue;
									}
									this.$self_$31009.mChar.oPosition = this.$self_$31009.transform.position;
									if (176565 - 484067 == -307501)
									{
										continue;
									}
									this.$self_$31009.mChar.nDirection = this.$self_$31009.transform.forward;
									if (296850 - 114699 == 182152)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (52573 - 411609 != -359036)
						{
							continue;
						}
						goto IL_945;
					default:
						if (165393 - 571675 != -406281)
						{
							goto IL_46C;
						}
						continue;
					}
					if (this.$i$31004 < 2)
					{
						goto IL_87D;
					}
					if (82617 - 408993 != -326375)
					{
						goto Block_20;
					}
					continue;
					IL_46C:
					this.$self_$31009.mChar.actionState = "attack";
					if (2595 - 364405 != -361809)
					{
						this.$self_$31009.mChar.actionTime = Time.time;
						if (229847 - 265917 != -36069)
						{
							this.$self_$31009.mChar.myCommand = "nAttack";
							if (138361 - 387318 != -248956)
							{
								this.$self_$31009.mChar.addTimeOut("nAttack", (float)2);
								if (113258 - 361624 != -248365)
								{
									this.$self_$31009.transform.position = this.$mPos$31007;
									if (43070 - 248775 != -205704)
									{
										this.$self_$31009.transform.LookAt(this.$mPos$31007 + global::Math.vFlat(this.$tDir$31008));
										if (297905 - 517234 == -219329)
										{
											this.$self_$31009.animation.CrossFade("nAttack");
											if (139590 - 138745 == 845)
											{
												this.$self_$31009.animation.wrapMode = WrapMode.Once;
												if (31797 - 367945 == -336148)
												{
													this.$self_$31009.mChar.vMovement = this.$self_$31009.transform.forward;
													if (6995 - 28733 != -21737)
													{
														this.$self_$31009.mChar.moveSpeed = (float)0;
														if (145 - 461642 != -461496)
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
				IL_1A:
				goto IL_945;
				Block_20:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_29:
				goto IL_1A;
				Block_37:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_709:
				goto IL_945;
				IL_87D:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_945:
				return false;
			}

			// Token: 0x06004031 RID: 16433 RVA: 0x0082A060 File Offset: 0x00828260
			internal static bool SEAW6h5Fz9YyqPUFEYTs()
			{
				return true;
			}

			// Token: 0x06004032 RID: 16434 RVA: 0x0082A064 File Offset: 0x00828264
			internal static bool mEIo4Z5MaU99KWBKH1KF()
			{
				return false;
			}

			// Token: 0x04004C92 RID: 19602
			internal int $hitLayer$31001;

			// Token: 0x04004C93 RID: 19603
			internal UnityScript.Lang.Array $hitList$31002;

			// Token: 0x04004C94 RID: 19604
			internal Vector3 $hitPoint$31003;

			// Token: 0x04004C95 RID: 19605
			internal int $i$31004;

			// Token: 0x04004C96 RID: 19606
			internal GameObject $hitObject$31005;

			// Token: 0x04004C97 RID: 19607
			internal IEnumerator $$iterator$10665$31006;

			// Token: 0x04004C98 RID: 19608
			internal Vector3 $mPos$31007;

			// Token: 0x04004C99 RID: 19609
			internal Vector3 $tDir$31008;

			// Token: 0x04004C9A RID: 19610
			internal Alpaca $self_$31009;
		}
	}

	// Token: 0x02000B44 RID: 2884
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31013 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004033 RID: 16435 RVA: 0x0082A068 File Offset: 0x00828268
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31013(UnityScript.Lang.Array nArray, Alpaca self_)
		{
			if (139340 - 407079 != -267739)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148826 - 117422 == 31404)
				{
					base..ctor();
					if (84142 - 459733 == -375591)
					{
						this.$nArray$31018 = nArray;
						if (267385 - 473577 != -206191)
						{
							this.$self_$31019 = self_;
							if (163644 - 123071 != 40574)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x0082A124 File Offset: 0x00828324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Alpaca.$RPC_ko$31013.$(this.$nArray$31018, this.$self_$31019);
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x0082A138 File Offset: 0x00828338
		internal static bool pSdGIT5M5c0imTIQWhwe()
		{
			return true;
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x0082A13C File Offset: 0x0082833C
		internal static bool LFMxcv5MpJn3v6tK4pDw()
		{
			return false;
		}

		// Token: 0x04004C9B RID: 19611
		internal UnityScript.Lang.Array $nArray$31018;

		// Token: 0x04004C9C RID: 19612
		internal Alpaca $self_$31019;

		// Token: 0x02000B45 RID: 2885
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004037 RID: 16439 RVA: 0x0082A140 File Offset: 0x00828340
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Alpaca self_)
			{
				if (228513 - 85205 != 143308)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221481 - 307312 != -85830)
					{
						base..ctor();
						if (17790 - 168775 != -150984)
						{
							this.$nArray$31016 = nArray;
							if (251769 - 402369 != -150599)
							{
								this.$self_$31017 = self_;
								if (30214 - 265074 == -234860)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004038 RID: 16440 RVA: 0x0082A1FC File Offset: 0x008283FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (167967 - 362253 != -194286)
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
						if (this.$self_$31017.mChar.actionState != "ko")
						{
							if (28672 - 324781 != -296109)
							{
								continue;
							}
							goto IL_3A4;
						}
						else
						{
							this.$self_$31017.animation.Play("getUp");
							if (115591 - 464585 == -348993)
							{
								continue;
							}
							this.$self_$31017.animation.wrapMode = WrapMode.Once;
							if (114954 - 64897 != 50057)
							{
								continue;
							}
							goto IL_43D;
						}
						break;
					case 3:
						if (this.$self_$31017.mChar.actionState != "ko")
						{
							if (292394 - 214814 != 77581)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$self_$31017.mChar.actionState = "standby";
							if (216193 - 199739 != 16454)
							{
								continue;
							}
							this.$self_$31017.mChar.actionTime = Time.time;
							if (172484 - 471210 == -298725)
							{
								continue;
							}
							this.$self_$31017.mChar.myCommand = "none";
							if (124774 - 312819 == -188044)
							{
								continue;
							}
							this.$self_$31017.mChar.ko = this.$self_$31017.mChar.mko;
							if (218073 - 61149 == 156925)
							{
								continue;
							}
							this.YieldDefault(1);
							if (110623 - 194503 != -83879)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					default:
						if (98165 - 272859 != -174694)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31017.mChar.actionState == "ko")
					{
						goto IL_253;
					}
					if (273637 - 373597 == -99960)
					{
						if (this.$self_$31017.mChar.actionState == "dead")
						{
							if (213447 - 204539 == 8908)
							{
								goto IL_253;
							}
						}
						else
						{
							this.$mPos$31014 = (Vector3)this.$nArray$31016[0];
							if (177479 - 8655 == 168824)
							{
								this.$mDir$31015 = (Vector3)this.$nArray$31016[1];
								if (114031 - 229146 != -115114)
								{
									this.$self_$31017.mChar.ko = 0;
									if (179824 - 329182 == -149358)
									{
										this.$self_$31017.mChar.actionState = "ko";
										if (247154 - 491637 == -244483)
										{
											this.$self_$31017.mChar.actionTime = Time.time;
											if (49493 - 462421 == -412928)
											{
												this.$self_$31017.mChar.myCommand = "none";
												if (9162 - 482234 != -473071)
												{
													this.$self_$31017.mChar.vMovement = Vector3.zero;
													if (91069 - 465391 != -374321)
													{
														this.$self_$31017.mChar.moveSpeed = (float)0;
														if (121967 - 353254 != -231286)
														{
															this.$self_$31017.animation.Play("ko");
															if (1055 - 468987 == -467932)
															{
																this.$self_$31017.animation.wrapMode = WrapMode.Once;
																if (194415 - 339903 == -145488)
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
				IL_253:
				Block_17:
				IL_3A4:
				goto IL_48C;
				IL_43D:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_28:
				IL_48C:
				return false;
			}

			// Token: 0x06004039 RID: 16441 RVA: 0x0082A6A8 File Offset: 0x008288A8
			internal static bool RJCF4e5MVFyy4HSCJIVH()
			{
				return true;
			}

			// Token: 0x0600403A RID: 16442 RVA: 0x0082A6AC File Offset: 0x008288AC
			internal static bool AwyOgu5Mt1yD7k64s0YN()
			{
				return false;
			}

			// Token: 0x04004C9D RID: 19613
			internal Vector3 $mPos$31014;

			// Token: 0x04004C9E RID: 19614
			internal Vector3 $mDir$31015;

			// Token: 0x04004C9F RID: 19615
			internal UnityScript.Lang.Array $nArray$31016;

			// Token: 0x04004CA0 RID: 19616
			internal Alpaca $self_$31017;
		}
	}

	// Token: 0x02000B46 RID: 2886
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31020 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600403B RID: 16443 RVA: 0x0082A6B0 File Offset: 0x008288B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31020(UnityScript.Lang.Array nArray, Alpaca self_)
		{
			if (192848 - 478097 != -285248)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (262598 - 465835 == -203237)
				{
					base..ctor();
					if (90017 - 16631 == 73386)
					{
						this.$nArray$31025 = nArray;
						if (177848 - 223661 == -45813)
						{
							this.$self_$31026 = self_;
							if (193312 - 111407 == 81905)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x0082A76C File Offset: 0x0082896C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Alpaca.$RPC_dead$31020.$(this.$nArray$31025, this.$self_$31026);
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x0082A780 File Offset: 0x00828980
		internal static bool BhFKqq5MNyYMj4ihTig0()
		{
			return true;
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x0082A784 File Offset: 0x00828984
		internal static bool XTdK1a5MYutMIyxN2VOo()
		{
			return false;
		}

		// Token: 0x04004CA1 RID: 19617
		internal UnityScript.Lang.Array $nArray$31025;

		// Token: 0x04004CA2 RID: 19618
		internal Alpaca $self_$31026;

		// Token: 0x02000B47 RID: 2887
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600403F RID: 16447 RVA: 0x0082A788 File Offset: 0x00828988
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Alpaca self_)
			{
				if (67593 - 15293 != 52300)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (56257 - 241510 == -185253)
					{
						base..ctor();
						if (257519 - 543624 != -286104)
						{
							this.$nArray$31023 = nArray;
							if (130354 - 175894 == -45540)
							{
								this.$self_$31024 = self_;
								if (114325 - 553485 != -439159)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004040 RID: 16448 RVA: 0x0082A844 File Offset: 0x00828A44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (11934 - 12550 != -615)
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
						if (this.$self_$31024.mChar.actionState != "dead")
						{
							if (222477 - 27216 != 195262)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							if (!this.$self_$31024.mChar.isPlayer)
							{
								if (267360 - 370784 == -103423)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31024.gameObject);
								if (33044 - 504513 == -471468)
								{
									continue;
								}
							}
							else if (this.$self_$31024.mChar.isMine)
							{
								if (72869 - 431234 != -358365)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31024.gameObject);
								if (86790 - 771 == 86020)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (42257 - 46077 != -3819)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (255450 - 400447 == -144996)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31024.mChar.actionState == "dead")
					{
						if (299111 - 464453 != -165341)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$31021 = (Vector3)this.$nArray$31023[0];
						if (293869 - 549709 == -255840)
						{
							this.$myDirection$31022 = (Vector3)this.$nArray$31023[1];
							if (1917 - 523049 != -521131)
							{
								this.$self_$31024.transform.position = this.$myPosition$31021;
								if (117128 - 273122 != -155993)
								{
									this.$self_$31024.transform.LookAt(this.$myPosition$31021 + this.$myDirection$31022);
									if (197105 - 194941 == 2164)
									{
										this.$self_$31024.mChar.hp = 0;
										if (285572 - 473309 != -187736)
										{
											this.$self_$31024.mChar.actionState = "dead";
											if (181781 - 546488 == -364707)
											{
												this.$self_$31024.mChar.actionTime = Time.time;
												if (270577 - 324675 == -54098)
												{
													this.$self_$31024.mChar.myCommand = "none";
													if (266415 - 93583 != 172833)
													{
														this.$self_$31024.mChar.vMovement = Vector3.zero;
														if (79404 - 62577 == 16827)
														{
															this.$self_$31024.mChar.moveSpeed = (float)0;
															if (219194 - 543938 != -324743)
															{
																this.$self_$31024.animation.Rewind();
																if (92203 - 398566 != -306362)
																{
																	this.$self_$31024.animation.Play("ko");
																	if (146237 - 157973 == -11736)
																	{
																		this.$self_$31024.animation.wrapMode = WrapMode.Once;
																		if (98129 - 297078 == -198949)
																		{
																			goto IL_2B7;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_42F;
				IL_2B7:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_18:
				IL_42F:
				return false;
			}

			// Token: 0x06004041 RID: 16449 RVA: 0x0082AC94 File Offset: 0x00828E94
			internal static bool hxiwNB5Mc3sgmJMGUCgS()
			{
				return true;
			}

			// Token: 0x06004042 RID: 16450 RVA: 0x0082AC98 File Offset: 0x00828E98
			internal static bool BWFpDy5MUCEd1x3iEgHX()
			{
				return false;
			}

			// Token: 0x04004CA3 RID: 19619
			internal Vector3 $myPosition$31021;

			// Token: 0x04004CA4 RID: 19620
			internal Vector3 $myDirection$31022;

			// Token: 0x04004CA5 RID: 19621
			internal UnityScript.Lang.Array $nArray$31023;

			// Token: 0x04004CA6 RID: 19622
			internal Alpaca $self_$31024;
		}
	}
}
