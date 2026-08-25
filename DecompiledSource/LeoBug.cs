using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000C4 RID: 196
[Serializable]
public class LeoBug : MonoBehaviour
{
	// Token: 0x06000439 RID: 1081 RVA: 0x0006D238 File Offset: 0x0006B438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeoBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x0006D248 File Offset: 0x0006B448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (108694 - 495097 != -386402)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (200972 - 568140 != -367167)
			{
				this.mChar.actionState = "standby";
				if (162373 - 507134 == -344761)
				{
					this.mChar.actionTime = Time.time;
					if (169639 - 253532 != -83892)
					{
						this.mChar.myCommand = "none";
						if (196318 - 87843 == 108475)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (236792 - 221139 != 15654)
							{
								this.mChar.isMine = true;
								if (15910 - 168350 == -152440)
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

	// Token: 0x0600043B RID: 1083 RVA: 0x0006D380 File Offset: 0x0006B580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (27996 - 155148 != -127152)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (242273 - 467107 != -224834)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (242931 - 551423 == -308491)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1A0;
					}
					if (198285 - 32745 == 165541)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (205958 - 391327 != -185369)
				{
					continue;
				}
			}
			IL_1A0:
			if (this.mChar.hp <= 0)
			{
				if (231349 - 250165 == -18815)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (123794 - 572888 == -449093)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (153660 - 565582 == -411921)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (203306 - 496606 == -293299)
						{
							continue;
						}
						if (status != null)
						{
							if (43896 - 259008 != -215112)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (50568 - 385445 != -334877)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (287451 - 544591 != -257140)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (115580 - 454281 != -338701)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (87113 - 110386 != -23273)
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
							if (21351 - 552233 == -530881)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (135989 - 386891 == -250901)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (115816 - 180877 != -65061)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (192693 - 238176 != -45482)
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
			if (230701 - 50057 != 180645)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (78299 - 252425 == -174126)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (10374 - 482427 == -472053)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (103314 - 307882 != -204567)
						{
							if (this.mChar.isMine)
							{
								if (266704 - 562603 == -295899)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (238253 - 366144 == -127891)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (191847 - 44914 != 146934)
										{
											this.mChar.KoEvent();
											if (297558 - 568423 != -270864)
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
								if (117045 - 477917 == -360872)
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

	// Token: 0x0600043C RID: 1084 RVA: 0x0006D880 File Offset: 0x0006BA80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (161748 - 28814 != 132935)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (201788 - 50965 == 150823)
			{
				float runSpeed = this.mChar.runSpeed;
				if (229576 - 538866 != -309289)
				{
					Vector3 a = default(Vector3);
					if (227375 - 141228 != 86148)
					{
						Vector3 vector = Vector3.zero;
						if (198649 - 219990 == -21341)
						{
							float num2 = (float)0;
							if (164073 - 132354 != 31720)
							{
								if (this.mChar.isMine)
								{
									if (135869 - 556042 != -420173)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (247274 - 97380 == 149895)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (279428 - 120738 == 158691)
										{
											continue;
										}
										a.y = (float)0;
										if (35541 - 296720 == -261178)
										{
											continue;
										}
										a = a.normalized;
										if (46640 - 357749 == -311108)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (193605 - 535179 == -341573)
										{
											continue;
										}
										vector = vector.normalized;
										if (57798 - 135160 == -77361)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (227763 - 228359 == -595)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (291027 - 543275 == -252247)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (64525 - 264012 != -199487)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (261442 - 354024 != -92582)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (213895 - 411668 != -197773)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (272287 - 260774 == 11514)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (97723 - 252129 != -154406)
														{
															continue;
														}
														this.animation.Play("run");
														if (94254 - 65869 == 28386)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (145519 - 223286 != -77767)
														{
															continue;
														}
														goto IL_990;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (144452 - 259348 != -114896)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (143175 - 75263 == 67913)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (82005 - 202421 == -120415)
											{
												continue;
											}
											num = (float)0;
											if (80707 - 493388 != -412681)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (87873 - 586592 == -498718)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (8826 - 411462 == -402635)
										{
											continue;
										}
									}
									IL_990:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (219911 - 591074 == -371162)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (272362 - 41252 == 231111)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (292659 - 163272 == 129388)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (166613 - 343765 != -177152)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (270149 - 5963 != 264186)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (210873 - 229969 != -19096)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (9598 - 100135 == -90536)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (131922 - 598752 != -466830)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (228984 - 88213 == 140772)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (248947 - 87137 == 161811)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (169821 - 146575 == 23247)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (32168 - 511572 == -479403)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (131335 - 563455 != -432120)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (64697 - 492877 == -428179)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (90791 - 488533 == -397741)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (292170 - 282661 == 9510)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (297968 - 324915 == -26946)
												{
													continue;
												}
												num = (float)0;
												if (39973 - 592014 == -552040)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (122210 - 397249 == -275038)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (125018 - 174099 != -49081)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (95954 - 186762 == -90807)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (218261 - 525064 == -306802)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (289777 - 182093 != 107684)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (44353 - 537316 != -492963)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (254054 - 125138 == 128917)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (20513 - 338909 != -318396)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (85583 - 196403 != -110820)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (178941 - 340333 == -161391)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (32814 - 52528 != -19714)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (195746 - 435916 == -240169)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (38725 - 482062 != -443337)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (249105 - 402675 != -153570)
											{
												continue;
											}
											num = (float)0;
											if (33815 - 167247 == -133431)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (100443 - 338430 != -237987)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (145945 - 361787 == -215841)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (11551 - 92476 == -80924)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (97119 - 317730 == -220610)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (26437 - 159773 != -133335)
								{
									this.mChar.moveSpeed = num;
									if (295719 - 341030 != -45310)
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

	// Token: 0x0600043D RID: 1085 RVA: 0x0006E3E4 File Offset: 0x0006C5E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (298937 - 159529 != 139409)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (90034 - 30236 == 59798)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (25013 - 587438 == -562425)
				{
					if (212871 - 233668 == -20797)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (88929 - 477738 != -388809)
							{
								continue;
							}
							v = 1;
							if (8492 - 212907 == -204414)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (152964 - 292377 == -139412)
							{
								continue;
							}
							v = -1;
							if (93887 - 561137 != -467250)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_primalRoar")
						{
							if (237157 - 252902 == -15744)
							{
								continue;
							}
							v = 10;
							if (21163 - 90318 != -69155)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leoBeam")
						{
							if (96370 - 131635 == -35264)
							{
								continue;
							}
							v = 20;
							if (216042 - 22962 == 193081)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (186936 - 598085 != -411148)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (30224 - 375705 == -345481)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (292629 - 422397 != -129767)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (94301 - 17089 != 77213)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (88413 - 520878 != -432464)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (176230 - 180955 == -4725)
											{
												Hashtable hashtable = new Hashtable();
												if (259800 - 211061 != 48740)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (146478 - 119174 == 27304)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (266700 - 250022 != 16679)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (95667 - 71659 == 24008)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (166935 - 471329 != -304393)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (227588 - 489662 != -262073)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (284219 - 365573 == -81354)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (285982 - 158402 != 127581)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (103076 - 556463 != -453386)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (67472 - 461585 != -394112)
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

	// Token: 0x0600043E RID: 1086 RVA: 0x0006E8D0 File Offset: 0x0006CAD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (263358 - 470695 != -207336)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (69191 - 17578 == 51613)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (12417 - 245280 != -232862)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (150671 - 183530 != -32858)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (258513 - 472628 != -214114)
						{
							int num3 = num;
							if (204227 - 439463 == -235236)
							{
								if (num3 == 1)
								{
									if (63196 - 396188 != -332991)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (106922 - 10760 != 96163)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (79875 - 570922 == -491047)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (254620 - 498520 != -243899)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (180620 - 276033 == -95413)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (244199 - 151969 != 92231)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (152077 - 151264 != 814)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (150815 - 111889 == 38926)
										{
											this.StartCoroutine_Auto(this.RPC_primalRoar(vector, vector2, num2));
											if (40307 - 121607 != -81299)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (46609 - 109528 == -62919)
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

	// Token: 0x0600043F RID: 1087 RVA: 0x0006EBE0 File Offset: 0x0006CDE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (210015 - 455140 != -245124)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (76890 - 150842 == -73952)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (48280 - 302344 != -254063)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (140308 - 466565 != -326256)
					{
						Vector3 vector2 = vector.normalized;
						if (134538 - 492340 != -357801)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (231287 - 463240 == -231953)
							{
								if (21139 - 144421 == -123282)
								{
									if (gameObject)
									{
										if (197975 - 552163 != -354188)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (182444 - 412736 == -230291)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (178309 - 296467 != -118158)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (9649 - 493611 == -483961)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (199240 - 293961 != -94720)
									{
										if (gameObject == this.gameObject)
										{
											if (275065 - 241502 == 33564)
											{
												continue;
											}
											vector2 = this.transform.forward;
											if (223372 - 343626 == -120253)
											{
												continue;
											}
										}
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector2, 0));
										if (136409 - 109415 == 26994)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (120329 - 102144 != 18186)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector2, 0);
												if (117763 - 265477 != -147713)
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

	// Token: 0x06000440 RID: 1088 RVA: 0x0006EEF0 File Offset: 0x0006D0F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (233675 - 457096 != -223420)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (92760 - 415448 != -322687)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (289405 - 316656 != -27250)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (39202 - 287347 != -248144)
					{
						Vector3 normalized = vector.normalized;
						if (17390 - 414752 != -397361)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (77332 - 583842 != -506509)
							{
								if (34450 - 412664 == -378214)
								{
									if (gameObject)
									{
										if (167700 - 441111 != -273411)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (229243 - 364534 != -135291)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (290803 - 478699 != -187896)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (221738 - 294424 == -72685)
										{
											continue;
										}
									}
									if (this.mChar.sp >= 40)
									{
										if (290847 - 596238 != -305390)
										{
											if (this.mChar.isTimeOut("leoBeam") != (float)0)
											{
												if (216696 - 463387 != -246690)
												{
													Camera.main.SendMessage("newGameMessage", "LeoBeam is not ready");
													if (41627 - 498024 != -456396)
													{
														break;
													}
												}
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_leoBeam(this.transform.position, this.transform.forward, 0));
												if (27409 - 57048 == -29639)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (265478 - 546155 != -280676)
													{
														this.ActionEvent("RPC_leoBeam", this.transform.position, this.transform.forward, 0);
														if (274386 - 216156 != 58231)
														{
															break;
														}
													}
												}
											}
										}
									}
									else if (this.mChar.isTimeOut("primalRoar") != (float)0)
									{
										if (156496 - 175111 == -18615)
										{
											Camera.main.SendMessage("newGameMessage", "PrimalRoar is not ready");
											if (155901 - 209987 == -54086)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_primalRoar(this.transform.position, this.transform.forward, 0));
										if (250852 - 63254 == 187598)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (172843 - 147772 == 25071)
											{
												this.ActionEvent("RPC_primalRoar", this.transform.position, this.transform.forward, 0);
												if (35535 - 297675 == -262140)
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

	// Token: 0x06000441 RID: 1089 RVA: 0x0006F328 File Offset: 0x0006D528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x0006F32C File Offset: 0x0006D52C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LeoBug.$RPC_nAttack$15960(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x0006F33C File Offset: 0x0006D53C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (66233 - 419245 != -353011)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (247814 - 478605 == -230791)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (295717 - 339581 != -43863)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Missing nAttack hit effect ");
				if (13372 - 120130 == -106758)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x0006F3FC File Offset: 0x0006D5FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_primalRoar(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LeoBug.$RPC_primalRoar$15974(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x0006F40C File Offset: 0x0006D60C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_leoBeam(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LeoBug.$RPC_leoBeam$15988(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x0006F41C File Offset: 0x0006D61C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new LeoBug.$RPC_ko$16005(nArray, this).GetEnumerator();
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x0006F42C File Offset: 0x0006D62C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new LeoBug.$RPC_dead$16012(nArray, this).GetEnumerator();
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x0006F43C File Offset: 0x0006D63C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x0006F440 File Offset: 0x0006D640
	internal static bool G3UCPjYyLVvGJM4qRb5()
	{
		return true;
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x0006F444 File Offset: 0x0006D644
	internal static bool eR2Ch3YSspvmMhMIHTH()
	{
		return false;
	}

	// Token: 0x0400040E RID: 1038
	public CharacterControl mChar;

	// Token: 0x0400040F RID: 1039
	public AudioClip leoBug_cry;

	// Token: 0x04000410 RID: 1040
	public GameObject nAttack_hit;

	// Token: 0x04000411 RID: 1041
	public GameObject primalRoar;

	// Token: 0x04000412 RID: 1042
	public GameObject leoBeam;

	// Token: 0x04000413 RID: 1043
	public AudioClip leoBeamFx;

	// Token: 0x020000C5 RID: 197
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$15960 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600044B RID: 1099 RVA: 0x0006F448 File Offset: 0x0006D648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$15960(Vector3 mPos, Vector3 tDir, LeoBug self_)
		{
			if (179938 - 594562 != -414623)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275178 - 42478 != 232701)
				{
					base..ctor();
					if (244573 - 427498 == -182925)
					{
						this.$mPos$15971 = mPos;
						if (106345 - 47628 != 58718)
						{
							this.$tDir$15972 = tDir;
							if (118503 - 458042 == -339539)
							{
								this.$self_$15973 = self_;
								if (228086 - 216160 != 11927)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0006F524 File Offset: 0x0006D724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LeoBug.$RPC_nAttack$15960.$(this.$mPos$15971, this.$tDir$15972, this.$self_$15973);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0006F540 File Offset: 0x0006D740
		internal static bool tMcqevYogrN66rsgRJo()
		{
			return true;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0006F544 File Offset: 0x0006D744
		internal static bool xGKR5jYEnL9XDCwl39H()
		{
			return false;
		}

		// Token: 0x04000414 RID: 1044
		internal Vector3 $mPos$15971;

		// Token: 0x04000415 RID: 1045
		internal Vector3 $tDir$15972;

		// Token: 0x04000416 RID: 1046
		internal LeoBug $self_$15973;

		// Token: 0x020000C6 RID: 198
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600044F RID: 1103 RVA: 0x0006F548 File Offset: 0x0006D748
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LeoBug self_)
			{
				if (299573 - 228825 != 70748)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141968 - 339880 != -197911)
					{
						base..ctor();
						if (59694 - 240797 == -181103)
						{
							this.$mPos$15968 = mPos;
							if (270665 - 202188 == 68477)
							{
								this.$tDir$15969 = tDir;
								if (54109 - 280173 == -226064)
								{
									this.$self_$15970 = self_;
									if (178750 - 499562 != -320811)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x0006F624 File Offset: 0x0006D824
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (136614 - 530225 != -393610)
				{
				}
				for (;;)
				{
					IL_BCD:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C97;
					case 2:
						if (this.$self_$15970.mChar.actionState != "attack")
						{
							goto IL_16E;
						}
						if (141625 - 12636 == 128990)
						{
							continue;
						}
						if (this.$self_$15970.mChar.myCommand != "nAttack")
						{
							if (22809 - 446281 != -423472)
							{
								continue;
							}
							goto IL_16E;
						}
						else
						{
							this.$hitLayer$15961 = 130816 - (1 << this.$self_$15970.gameObject.layer);
							if (276443 - 183526 != 92917)
							{
								continue;
							}
							this.$hitList$15962 = null;
							if (132061 - 402626 != -270565)
							{
								continue;
							}
							this.$hitPos$15963 = default(Vector3);
							if (115306 - 361565 != -246259)
							{
								continue;
							}
							if (!this.$self_$15970.mChar.isMine)
							{
								goto IL_2D9;
							}
							if (261530 - 347194 == -85663)
							{
								continue;
							}
							this.$hitList$15962 = Damage.FindRecTarget(this.$self_$15970.transform.position - this.$self_$15970.transform.forward, this.$self_$15970.transform.forward, (float)2 * this.$self_$15970.mChar.rangeMod, (float)2 * this.$self_$15970.mChar.rangeMod, (float)4 * this.$self_$15970.mChar.rangeMod, (float)3 * this.$self_$15970.mChar.rangeMod, this.$hitLayer$15961);
							if (44883 - 364065 == -319181)
							{
								continue;
							}
							this.$$iterator$9930$15965 = UnityRuntimeServices.GetEnumerator(this.$hitList$15962);
							if (216162 - 577218 == -361055)
							{
								continue;
							}
							while (this.$$iterator$9930$15965.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9930$15965.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15964 = (GameObject)obj2;
								if (221383 - 409477 != -188094)
								{
									goto IL_BCD;
								}
								if (this.$self_$15970.mChar.hit(1, this.$hitObject$15964, this.$self_$15970.mChar.atk, 1, 0, this.$self_$15970.transform.forward) != 0)
								{
									if (59939 - 452185 == -392245)
									{
										goto IL_BCD;
									}
									this.$hitPos$15963 = this.$hitObject$15964.collider.ClosestPointOnBounds(this.$self_$15970.transform.position + this.$self_$15970.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (254147 - 463346 != -209199)
									{
										goto IL_BCD;
									}
									UnityRuntimeServices.Update(this.$$iterator$9930$15965, this.$hitObject$15964);
									if (5007 - 92465 == -87457)
									{
										goto IL_BCD;
									}
									this.$self_$15970.RPC_nAttack_hit(this.$hitPos$15963, this.$self_$15970.transform.forward, 0);
									if (292310 - 496768 == -204457)
									{
										goto IL_BCD;
									}
									this.$self_$15970.ActionEvent("RPC_nAttack_hit", this.$hitPos$15963, this.$self_$15970.transform.forward, 0);
									if (245790 - 394727 == -148936)
									{
										goto IL_BCD;
									}
								}
							}
							if (51691 - 39064 != 12627)
							{
								continue;
							}
							goto IL_2D9;
						}
						break;
					case 3:
						if (this.$self_$15970.mChar.actionState != "attack")
						{
							goto IL_667;
						}
						if (172253 - 221991 != -49738)
						{
							continue;
						}
						if (this.$self_$15970.mChar.myCommand != "nAttack")
						{
							if (61214 - 182410 != -121195)
							{
								goto Block_63;
							}
							continue;
						}
						else
						{
							this.$self_$15970.mChar.moveSpeed = (float)8;
							if (295987 - 105058 != 190929)
							{
								continue;
							}
							if (!this.$self_$15970.mChar.isMine)
							{
								goto IL_25B;
							}
							if (178758 - 581422 != -402664)
							{
								continue;
							}
							this.$hitList$15962 = Damage.FindRecTarget(this.$self_$15970.transform.position - this.$self_$15970.transform.forward, this.$self_$15970.transform.forward, (float)2 * this.$self_$15970.mChar.rangeMod, (float)2 * this.$self_$15970.mChar.rangeMod, (float)4 * this.$self_$15970.mChar.rangeMod, (float)3 * this.$self_$15970.mChar.rangeMod, this.$hitLayer$15961);
							if (62725 - 599010 == -536284)
							{
								continue;
							}
							this.$$iterator$9931$15967 = UnityRuntimeServices.GetEnumerator(this.$hitList$15962);
							if (199909 - 402213 != -202304)
							{
								continue;
							}
							while (this.$$iterator$9931$15967.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9931$15967.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$15966 = (GameObject)obj4;
								if (8816 - 62003 != -53187)
								{
									goto IL_BCD;
								}
								if (this.$self_$15970.mChar.hit(2, this.$hitObject$15966, this.$self_$15970.mChar.atk, 1, 0, this.$self_$15970.transform.forward) != 0)
								{
									if (48379 - 71593 == -23213)
									{
										goto IL_BCD;
									}
									this.$hitPos$15963 = this.$hitObject$15966.collider.ClosestPointOnBounds(this.$self_$15970.transform.position + this.$self_$15970.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (274573 - 315849 != -41276)
									{
										goto IL_BCD;
									}
									UnityRuntimeServices.Update(this.$$iterator$9931$15967, this.$hitObject$15966);
									if (183838 - 69666 != 114172)
									{
										goto IL_BCD;
									}
									this.$self_$15970.RPC_nAttack_hit(this.$hitPos$15963, this.$self_$15970.transform.forward, 0);
									if (188939 - 141815 != 47124)
									{
										goto IL_BCD;
									}
									this.$self_$15970.ActionEvent("RPC_nAttack_hit", this.$hitPos$15963, this.$self_$15970.transform.forward, 0);
									if (11890 - 281639 != -269749)
									{
										goto IL_BCD;
									}
								}
							}
							if (177095 - 427281 != -250185)
							{
								goto Block_69;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$15970.mChar.actionState != "attack")
						{
							goto IL_916;
						}
						if (268145 - 323650 != -55505)
						{
							continue;
						}
						if (this.$self_$15970.mChar.myCommand != "nAttack")
						{
							if (69619 - 201658 != -132038)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$self_$15970.mChar.moveSpeed = (float)0;
							if (113541 - 70822 != 42720)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$15970.mChar.actionState == "attack")
						{
							if (3997 - 295937 == -291939)
							{
								continue;
							}
							if (this.$self_$15970.mChar.myCommand == "nAttack")
							{
								if (235545 - 302751 != -67206)
								{
									continue;
								}
								this.$self_$15970.mChar.actionState = "standby";
								if (274779 - 521321 != -246542)
								{
									continue;
								}
								this.$self_$15970.mChar.actionTime = Time.time;
								if (12065 - 119374 == -107308)
								{
									continue;
								}
								this.$self_$15970.mChar.myCommand = "none";
								if (31296 - 185738 != -154442)
								{
									continue;
								}
								if (!this.$self_$15970.mChar.isMine)
								{
									if (39378 - 367318 == -327939)
									{
										continue;
									}
									this.$self_$15970.mChar.nPosition = this.$self_$15970.transform.position;
									if (117456 - 352191 == -234734)
									{
										continue;
									}
									this.$self_$15970.mChar.oPosition = this.$self_$15970.transform.position;
									if (159359 - 129386 != 29973)
									{
										continue;
									}
									this.$self_$15970.mChar.nDirection = this.$self_$15970.transform.forward;
									if (24923 - 281076 != -256153)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (185760 - 411877 != -226117)
						{
							continue;
						}
						goto IL_C97;
					default:
						if (194039 - 186307 == 7733)
						{
							continue;
						}
						break;
					}
					this.$self_$15970.mChar.actionState = "attack";
					if (45149 - 92387 != -47237)
					{
						this.$self_$15970.mChar.actionTime = Time.time;
						if (252107 - 472351 == -220244)
						{
							this.$self_$15970.mChar.myCommand = "nAttack";
							if (132840 - 397506 == -264666)
							{
								this.$self_$15970.mChar.addTimeOut("nAttack", (float)3);
								if (132193 - 514721 != -382527)
								{
									this.$self_$15970.transform.position = this.$mPos$15968;
									if (60552 - 120069 == -59517)
									{
										this.$self_$15970.transform.LookAt(this.$mPos$15968 + global::Math.vFlat(this.$tDir$15969));
										if (25356 - 283885 != -258528)
										{
											this.$self_$15970.animation.CrossFade("nAttack");
											if (53006 - 77788 == -24782)
											{
												this.$self_$15970.animation.wrapMode = WrapMode.Once;
												if (266436 - 47203 == 219233)
												{
													this.$self_$15970.mChar.vMovement = this.$self_$15970.transform.forward;
													if (1973 - 141642 == -139669)
													{
														this.$self_$15970.mChar.moveSpeed = (float)0;
														if (39164 - 210034 != -170869)
														{
															goto Block_30;
														}
													}
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
				IL_16E:
				goto IL_C97;
				IL_25B:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_2D9:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_30:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_667:
				IL_916:
				goto IL_C97;
				Block_47:
				return this.Yield(5, new WaitForSeconds(0.3f));
				Block_63:
				goto IL_667;
				Block_69:
				goto IL_25B;
				IL_C97:
				return false;
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x000702DC File Offset: 0x0006E4DC
			internal static bool FFhDaDY2TWlWg2UdQlb()
			{
				return true;
			}

			// Token: 0x06000452 RID: 1106 RVA: 0x000702E0 File Offset: 0x0006E4E0
			internal static bool VhrmO8Y8tdL1MFsCKTm()
			{
				return false;
			}

			// Token: 0x04000417 RID: 1047
			internal int $hitLayer$15961;

			// Token: 0x04000418 RID: 1048
			internal UnityScript.Lang.Array $hitList$15962;

			// Token: 0x04000419 RID: 1049
			internal Vector3 $hitPos$15963;

			// Token: 0x0400041A RID: 1050
			internal GameObject $hitObject$15964;

			// Token: 0x0400041B RID: 1051
			internal IEnumerator $$iterator$9930$15965;

			// Token: 0x0400041C RID: 1052
			internal GameObject $hitObject$15966;

			// Token: 0x0400041D RID: 1053
			internal IEnumerator $$iterator$9931$15967;

			// Token: 0x0400041E RID: 1054
			internal Vector3 $mPos$15968;

			// Token: 0x0400041F RID: 1055
			internal Vector3 $tDir$15969;

			// Token: 0x04000420 RID: 1056
			internal LeoBug $self_$15970;
		}
	}

	// Token: 0x020000C7 RID: 199
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_primalRoar$15974 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x000702E4 File Offset: 0x0006E4E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_primalRoar$15974(Vector3 mPos, Vector3 tDir, LeoBug self_)
		{
			if (268195 - 110149 != 158046)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (269064 - 528207 == -259143)
				{
					base..ctor();
					if (115499 - 203234 != -87734)
					{
						this.$mPos$15985 = mPos;
						if (114333 - 283256 != -168922)
						{
							this.$tDir$15986 = tDir;
							if (36082 - 589516 == -553434)
							{
								this.$self_$15987 = self_;
								if (226592 - 332338 != -105745)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000703C0 File Offset: 0x0006E5C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LeoBug.$RPC_primalRoar$15974.$(this.$mPos$15985, this.$tDir$15986, this.$self_$15987);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000703DC File Offset: 0x0006E5DC
		internal static bool pJvkAOYZ8pyfnveeBMq()
		{
			return true;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000703E0 File Offset: 0x0006E5E0
		internal static bool jAboWoYCtLGlDQWpDPp()
		{
			return false;
		}

		// Token: 0x04000421 RID: 1057
		internal Vector3 $mPos$15985;

		// Token: 0x04000422 RID: 1058
		internal Vector3 $tDir$15986;

		// Token: 0x04000423 RID: 1059
		internal LeoBug $self_$15987;

		// Token: 0x020000C8 RID: 200
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000457 RID: 1111 RVA: 0x000703E4 File Offset: 0x0006E5E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LeoBug self_)
			{
				if (264769 - 283172 != -18403)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (118610 - 587148 == -468538)
					{
						base..ctor();
						if (121152 - 424784 != -303631)
						{
							this.$mPos$15982 = mPos;
							if (210736 - 462882 != -252145)
							{
								this.$tDir$15983 = tDir;
								if (131289 - 215802 == -84513)
								{
									this.$self_$15984 = self_;
									if (88709 - 299119 != -210409)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x000704C0 File Offset: 0x0006E6C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (95227 - 109961 != -14734)
				{
				}
				for (;;)
				{
					IL_4FB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A05;
					case 2:
						if (this.$self_$15984.mChar.actionState != "attack")
						{
							goto IL_133;
						}
						if (101270 - 558277 != -457007)
						{
							continue;
						}
						if (this.$self_$15984.mChar.myCommand != "primalRoar")
						{
							if (250326 - 497015 != -246689)
							{
								continue;
							}
							goto IL_133;
						}
						else
						{
							this.$self_$15984.mChar.moveSpeed = (float)0;
							if (18758 - 77028 != -58270)
							{
								continue;
							}
							if (this.$self_$15984.primalRoar)
							{
								if (169335 - 335680 != -166345)
								{
									continue;
								}
								this.$self_$15984.mChar.createEffect(this.$self_$15984.primalRoar, this.$self_$15984.transform.position, this.$self_$15984.transform.rotation);
								if (32084 - 276522 == -244437)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Missing primal roar effect ");
								if (181402 - 321619 == -140216)
								{
									continue;
								}
							}
							this.$i$15975 = 0;
							if (83044 - 443602 != -360557)
							{
								goto IL_649;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15984.mChar.actionState != "attack")
						{
							goto IL_248;
						}
						if (118934 - 471396 != -352462)
						{
							continue;
						}
						if (this.$self_$15984.mChar.myCommand != "primalRoar")
						{
							if (116822 - 550475 != -433652)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							this.$hitLayer$15976 = 130816 - (1 << this.$self_$15984.gameObject.layer);
							if (94882 - 421860 == -326977)
							{
								continue;
							}
							this.$hitList$15977 = null;
							if (211794 - 222607 != -10813)
							{
								continue;
							}
							this.$hitPos$15978 = default(Vector3);
							if (243054 - 379200 == -136145)
							{
								continue;
							}
							if (this.$self_$15984.mChar.isMine)
							{
								if (102437 - 509297 == -406859)
								{
									continue;
								}
								this.$hitList$15977 = Damage.FindAreaTarget(this.$self_$15984.transform.position, (float)24 * this.$self_$15984.mChar.rangeMod, (float)4 * this.$self_$15984.mChar.rangeMod, this.$hitLayer$15976);
								if (294481 - 532933 == -238451)
								{
									continue;
								}
								this.$$iterator$9932$15981 = UnityRuntimeServices.GetEnumerator(this.$hitList$15977);
								if (51318 - 308166 == -256847)
								{
									continue;
								}
								while (this.$$iterator$9932$15981.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9932$15981.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$15979 = (GameObject)obj2;
									if (117382 - 61119 == 56264)
									{
										goto IL_4FB;
									}
									if (this.$self_$15984.mChar.hit(10, this.$hitObject$15979, this.$self_$15984.mChar.talAdjust(15), 1, 0, 0.5f * global::Math.vFlat(this.$hitObject$15979.transform.position - this.$self_$15984.transform.position).normalized) != 0)
									{
										if (207763 - 302229 == -94465)
										{
											goto IL_4FB;
										}
										this.$tChar$15980 = (CharacterControl)this.$hitObject$15979.GetComponent(typeof(CharacterControl));
										if (30422 - 594010 == -563587)
										{
											goto IL_4FB;
										}
										UnityRuntimeServices.Update(this.$$iterator$9932$15981, this.$hitObject$15979);
										if (98171 - 537963 != -439792)
										{
											goto IL_4FB;
										}
										if (this.$tChar$15980)
										{
											if (46656 - 215457 != -168801)
											{
												goto IL_4FB;
											}
											if (!this.$tChar$15980.hasStatus("fear"))
											{
												if (296938 - 215001 != 81937)
												{
													goto IL_4FB;
												}
												this.$tChar$15980.RPC_AddStatus("fear", 4, this.$self_$15984.mChar.chaAdjust(15), 0, this.$self_$15984.mChar.ActorNr);
												if (280302 - 27399 == 252904)
												{
													goto IL_4FB;
												}
											}
										}
									}
								}
								if (207662 - 509926 != -302264)
								{
									continue;
								}
							}
							this.$i$15975++;
							if (190450 - 427842 != -237391)
							{
								goto IL_649;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$15984.mChar.actionState == "attack")
						{
							if (290628 - 535105 == -244476)
							{
								continue;
							}
							if (this.$self_$15984.mChar.myCommand == "primalRoar")
							{
								if (212564 - 171626 == 40939)
								{
									continue;
								}
								this.$self_$15984.mChar.actionState = "standby";
								if (146034 - 496840 != -350806)
								{
									continue;
								}
								this.$self_$15984.mChar.actionTime = Time.time;
								if (130287 - 591122 == -460834)
								{
									continue;
								}
								this.$self_$15984.mChar.myCommand = "none";
								if (194654 - 389864 != -195210)
								{
									continue;
								}
								if (!this.$self_$15984.mChar.isMine)
								{
									if (3832 - 268941 != -265109)
									{
										continue;
									}
									this.$self_$15984.mChar.nPosition = this.$self_$15984.transform.position;
									if (127575 - 159870 == -32294)
									{
										continue;
									}
									this.$self_$15984.mChar.oPosition = this.$self_$15984.transform.position;
									if (159706 - 33948 != 125758)
									{
										continue;
									}
									this.$self_$15984.mChar.nDirection = this.$self_$15984.transform.forward;
									if (149349 - 422333 != -272984)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (248650 - 84422 != 164229)
						{
							goto Block_31;
						}
						continue;
					default:
						if (76871 - 11725 == 65147)
						{
							continue;
						}
						break;
					}
					this.$self_$15984.mChar.actionState = "attack";
					if (164648 - 24824 == 139825)
					{
						continue;
					}
					this.$self_$15984.mChar.actionTime = Time.time;
					if (233355 - 176047 == 57309)
					{
						continue;
					}
					this.$self_$15984.mChar.myCommand = "primalRoar";
					if (256708 - 48165 != 208543)
					{
						continue;
					}
					this.$self_$15984.mChar.addTimeOut("primalRoar", (float)45);
					if (80153 - 544449 != -464296)
					{
						continue;
					}
					this.$self_$15984.transform.position = this.$mPos$15982;
					if (91229 - 89669 != 1560)
					{
						continue;
					}
					this.$self_$15984.transform.LookAt(this.$mPos$15982 + global::Math.vFlat(this.$tDir$15983));
					if (106338 - 517842 != -411504)
					{
						continue;
					}
					this.$self_$15984.animation.CrossFade("primalRoar");
					if (211876 - 1706 != 210170)
					{
						continue;
					}
					this.$self_$15984.animation.wrapMode = WrapMode.Once;
					if (223247 - 232114 == -8866)
					{
						continue;
					}
					this.$self_$15984.mChar.vMovement = this.$self_$15984.transform.forward;
					if (73917 - 322755 != -248838)
					{
						continue;
					}
					this.$self_$15984.mChar.moveSpeed = (float)0;
					if (51499 - 320419 != -268920)
					{
						continue;
					}
					goto IL_967;
					IL_649:
					if (this.$i$15975 < 3)
					{
						break;
					}
					if (115502 - 535689 == -420187)
					{
						goto IL_780;
					}
				}
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_133:
				IL_248:
				goto IL_A05;
				Block_31:
				Block_40:
				goto IL_248;
				IL_780:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_967:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_A05:
				return false;
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00070EE4 File Offset: 0x0006F0E4
			internal static bool xp4j6mYLn7Rc7rXDCVY()
			{
				return true;
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x00070EE8 File Offset: 0x0006F0E8
			internal static bool CwDgSFYOr8JHEaUf0TX()
			{
				return false;
			}

			// Token: 0x04000424 RID: 1060
			internal int $i$15975;

			// Token: 0x04000425 RID: 1061
			internal int $hitLayer$15976;

			// Token: 0x04000426 RID: 1062
			internal UnityScript.Lang.Array $hitList$15977;

			// Token: 0x04000427 RID: 1063
			internal Vector3 $hitPos$15978;

			// Token: 0x04000428 RID: 1064
			internal GameObject $hitObject$15979;

			// Token: 0x04000429 RID: 1065
			internal CharacterControl $tChar$15980;

			// Token: 0x0400042A RID: 1066
			internal IEnumerator $$iterator$9932$15981;

			// Token: 0x0400042B RID: 1067
			internal Vector3 $mPos$15982;

			// Token: 0x0400042C RID: 1068
			internal Vector3 $tDir$15983;

			// Token: 0x0400042D RID: 1069
			internal LeoBug $self_$15984;
		}
	}

	// Token: 0x020000C9 RID: 201
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_leoBeam$15988 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600045B RID: 1115 RVA: 0x00070EEC File Offset: 0x0006F0EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_leoBeam$15988(Vector3 mPos, Vector3 tDir, LeoBug self_)
		{
			if (80273 - 150403 != -70129)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (119589 - 84065 == 35524)
				{
					base..ctor();
					if (12065 - 20460 != -8394)
					{
						this.$mPos$16002 = mPos;
						if (233440 - 343845 == -110405)
						{
							this.$tDir$16003 = tDir;
							if (250142 - 330973 != -80830)
							{
								this.$self_$16004 = self_;
								if (270032 - 340615 == -70583)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00070FC8 File Offset: 0x0006F1C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LeoBug.$RPC_leoBeam$15988.$(this.$mPos$16002, this.$tDir$16003, this.$self_$16004);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00070FE4 File Offset: 0x0006F1E4
		internal static bool zZ9dlYYmr4ORu8XvePu()
		{
			return true;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00070FE8 File Offset: 0x0006F1E8
		internal static bool re17L3YFURM48gZpT6G()
		{
			return false;
		}

		// Token: 0x0400042E RID: 1070
		internal Vector3 $mPos$16002;

		// Token: 0x0400042F RID: 1071
		internal Vector3 $tDir$16003;

		// Token: 0x04000430 RID: 1072
		internal LeoBug $self_$16004;

		// Token: 0x020000CA RID: 202
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600045F RID: 1119 RVA: 0x00070FEC File Offset: 0x0006F1EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LeoBug self_)
			{
				if (219311 - 94066 != 125245)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (299840 - 260823 == 39017)
					{
						base..ctor();
						if (271634 - 565610 != -293975)
						{
							this.$mPos$15999 = mPos;
							if (28113 - 398534 == -370421)
							{
								this.$tDir$16000 = tDir;
								if (169856 - 255253 == -85397)
								{
									this.$self_$16001 = self_;
									if (233094 - 512585 == -279491)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x000710C8 File Offset: 0x0006F2C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (40368 - 137324 != -96956)
				{
				}
				for (;;)
				{
					IL_7D2:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AF3;
					case 2:
						if (this.$self_$16001.mChar.actionState != "attack")
						{
							goto IL_6E8;
						}
						if (117776 - 99558 != 18218)
						{
							continue;
						}
						if (this.$self_$16001.mChar.myCommand != "leoBeam")
						{
							if (4414 - 233774 != -229360)
							{
								continue;
							}
							goto IL_6E8;
						}
						else
						{
							this.$self_$16001.mChar.moveSpeed = (float)0;
							if (101202 - 278536 != -177334)
							{
								continue;
							}
							if (this.$self_$16001.leoBeam)
							{
								if (45119 - 412041 != -366922)
								{
									continue;
								}
								this.$mLeoBeam$15989 = this.$self_$16001.mChar.createEffect(this.$self_$16001.leoBeam, this.$self_$16001.transform.position, this.$self_$16001.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
								if (88496 - 245968 == -157471)
								{
									continue;
								}
								if (this.$self_$16001.mChar.Type == "LeoBug_g")
								{
									if (67211 - 192180 != -124969)
									{
										continue;
									}
									this.$mLeoBeam$15989.transform.localScale = 2.4f * Vector3.one;
									if (213720 - 214953 != -1233)
									{
										continue;
									}
									goto IL_8A;
								}
								else if (this.$self_$16001.mChar.Type == "LeoBug_p")
								{
									if (77072 - 23033 != 54039)
									{
										continue;
									}
									this.$mLeoBeam$15989.transform.localScale = (float)3 * Vector3.one;
									if (132620 - 50869 != 81751)
									{
										continue;
									}
									goto IL_67B;
								}
								else
								{
									this.$mLeoBeam$15989.transform.localScale = Vector3.one;
									if (43342 - 36469 != 6873)
									{
										continue;
									}
									goto IL_11D;
								}
							}
							else
							{
								Debug.Log("Cannot find leoBeam");
								if (243101 - 19019 != 224082)
								{
									continue;
								}
								goto IL_83A;
							}
						}
						break;
					case 3:
						if (this.$self_$16001.mChar.actionState != "attack")
						{
							goto IL_C8;
						}
						if (212227 - 544617 == -332389)
						{
							continue;
						}
						if (this.$self_$16001.mChar.myCommand != "leoBeam")
						{
							if (18141 - 278417 != -260275)
							{
								goto Block_52;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16001.mChar.isMine)
							{
								goto IL_237;
							}
							if (250355 - 30128 == 220228)
							{
								continue;
							}
							this.$hitLayer$15990 = ~((1 << this.$self_$16001.gameObject.layer) + 2 + 4);
							if (265441 - 78319 == 187123)
							{
								continue;
							}
							this.$hitList$15991 = Physics.SphereCastAll(this.$self_$16001.transform.position + Vector3.up, 1.5f, this.$self_$16001.transform.forward, (float)24, this.$hitLayer$15990);
							if (89925 - 438278 != -348353)
							{
								continue;
							}
							this.$$11020$15996 = 0;
							if (145139 - 496496 != -351357)
							{
								continue;
							}
							this.$$11021$15997 = this.$hitList$15991;
							if (73407 - 348370 != -274963)
							{
								continue;
							}
							this.$$11022$15998 = this.$$11021$15997.Length;
							if (120364 - 282529 != -162165)
							{
								continue;
							}
							while (this.$$11020$15996 < this.$$11022$15998)
							{
								this.$hitObject$15993 = this.$$11021$15997[this.$$11020$15996].collider.gameObject;
								if (57998 - 542542 != -484544)
								{
									goto IL_7D2;
								}
								if (this.$self_$16001.mChar.hit(20, this.$hitObject$15993, this.$self_$16001.mChar.talAdjust(50), 0, 0, global::Math.vFlat(this.$self_$16001.transform.forward)) != 0)
								{
									if (14475 - 479627 != -465152)
									{
										goto IL_7D2;
									}
									this.$tChar$15994 = (CharacterControl)this.$hitObject$15993.GetComponent(typeof(CharacterControl));
									if (42757 - 583137 != -540380)
									{
										goto IL_7D2;
									}
									this.$mDuration$15995 = Damage.getDebuff((float)9, this.$self_$16001.mChar.cha, this.$tChar$15994.cha);
									if (158555 - 166288 == -7732)
									{
										goto IL_7D2;
									}
									if (this.$tChar$15994)
									{
										if (268724 - 27406 != 241318)
										{
											goto IL_7D2;
										}
										this.$tChar$15994.RPC_AddStatus("petrify", 1, this.$mDuration$15995, 0, this.$self_$16001.mChar.ActorNr);
										if (259523 - 165632 != 93891)
										{
											goto IL_7D2;
										}
									}
								}
								this.$$11020$15996++;
								if (264461 - 338514 != -74053)
								{
									goto IL_7D2;
								}
							}
							if (122045 - 552192 != -430147)
							{
								continue;
							}
							goto IL_237;
						}
						break;
					case 4:
						if (this.$self_$16001.mChar.actionState == "attack")
						{
							if (191555 - 528613 == -337057)
							{
								continue;
							}
							if (this.$self_$16001.mChar.myCommand == "leoBeam")
							{
								if (145576 - 262970 != -117394)
								{
									continue;
								}
								this.$self_$16001.mChar.actionState = "standby";
								if (30604 - 399465 != -368861)
								{
									continue;
								}
								this.$self_$16001.mChar.actionTime = Time.time;
								if (255094 - 111179 == 143916)
								{
									continue;
								}
								this.$self_$16001.mChar.myCommand = "none";
								if (271439 - 179686 == 91754)
								{
									continue;
								}
								if (!this.$self_$16001.mChar.isMine)
								{
									if (7281 - 539398 == -532116)
									{
										continue;
									}
									this.$self_$16001.mChar.nPosition = this.$self_$16001.transform.position;
									if (10028 - 440357 != -430329)
									{
										continue;
									}
									this.$self_$16001.mChar.oPosition = this.$self_$16001.transform.position;
									if (186837 - 526747 == -339909)
									{
										continue;
									}
									this.$self_$16001.mChar.nDirection = this.$self_$16001.transform.forward;
									if (83462 - 380069 == -296606)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (161450 - 25566 != 135884)
						{
							continue;
						}
						goto IL_AF3;
					default:
						if (261670 - 247092 != 14578)
						{
							continue;
						}
						break;
					}
					this.$self_$16001.mChar.actionState = "attack";
					if (56561 - 432787 == -376226)
					{
						this.$self_$16001.mChar.actionTime = Time.time;
						if (296868 - 553906 == -257038)
						{
							this.$self_$16001.mChar.myCommand = "leoBeam";
							if (144794 - 59304 != 85491)
							{
								this.$self_$16001.mChar.addTimeOut("leoBeam", (float)45);
								if (38946 - 104436 != -65489)
								{
									this.$self_$16001.transform.position = this.$mPos$15999;
									if (207964 - 187034 != 20931)
									{
										this.$self_$16001.transform.LookAt(this.$mPos$15999 + global::Math.vFlat(this.$tDir$16000));
										if (147723 - 287361 != -139637)
										{
											this.$self_$16001.animation.CrossFade("leoBeam");
											if (192124 - 396722 != -204597)
											{
												this.$self_$16001.animation.wrapMode = WrapMode.Once;
												if (264574 - 489300 != -224725)
												{
													this.$self_$16001.mChar.vMovement = this.$self_$16001.transform.forward;
													if (265173 - 100072 != 165102)
													{
														this.$self_$16001.mChar.moveSpeed = (float)0;
														if (49513 - 578074 == -528561)
														{
															if (!this.$self_$16001.leoBeamFx)
															{
																goto IL_568;
															}
															if (138766 - 224805 != -86038)
															{
																this.$self_$16001.audio.PlayOneShot(this.$self_$16001.leoBeamFx);
																if (224259 - 356324 == -132065)
																{
																	goto IL_568;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_8A:
				goto IL_11D;
				IL_C8:
				goto IL_AF3;
				IL_11D:
				goto IL_83A;
				IL_237:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_568:
				return this.Yield(2, new WaitForSeconds(1.1f));
				IL_67B:
				goto IL_11D;
				IL_6E8:
				goto IL_AF3;
				IL_83A:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_52:
				IL_AF3:
				return false;
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00071BDC File Offset: 0x0006FDDC
			internal static bool qLkELRYM5rbebjfFrmQ()
			{
				return true;
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00071BE0 File Offset: 0x0006FDE0
			internal static bool WAACeNYxyMrVbNftNlZ()
			{
				return false;
			}

			// Token: 0x04000431 RID: 1073
			internal GameObject $mLeoBeam$15989;

			// Token: 0x04000432 RID: 1074
			internal int $hitLayer$15990;

			// Token: 0x04000433 RID: 1075
			internal RaycastHit[] $hitList$15991;

			// Token: 0x04000434 RID: 1076
			internal RaycastHit $hit$15992;

			// Token: 0x04000435 RID: 1077
			internal GameObject $hitObject$15993;

			// Token: 0x04000436 RID: 1078
			internal CharacterControl $tChar$15994;

			// Token: 0x04000437 RID: 1079
			internal int $mDuration$15995;

			// Token: 0x04000438 RID: 1080
			internal int $$11020$15996;

			// Token: 0x04000439 RID: 1081
			internal RaycastHit[] $$11021$15997;

			// Token: 0x0400043A RID: 1082
			internal int $$11022$15998;

			// Token: 0x0400043B RID: 1083
			internal Vector3 $mPos$15999;

			// Token: 0x0400043C RID: 1084
			internal Vector3 $tDir$16000;

			// Token: 0x0400043D RID: 1085
			internal LeoBug $self_$16001;
		}
	}

	// Token: 0x020000CB RID: 203
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16005 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000463 RID: 1123 RVA: 0x00071BE4 File Offset: 0x0006FDE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16005(UnityScript.Lang.Array nArray, LeoBug self_)
		{
			if (47770 - 305675 != -257905)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (33883 - 97451 == -63568)
				{
					base..ctor();
					if (149531 - 104840 == 44691)
					{
						this.$nArray$16010 = nArray;
						if (256156 - 247946 == 8210)
						{
							this.$self_$16011 = self_;
							if (34760 - 277515 == -242755)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00071CA0 File Offset: 0x0006FEA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LeoBug.$RPC_ko$16005.$(this.$nArray$16010, this.$self_$16011);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00071CB4 File Offset: 0x0006FEB4
		internal static bool DmosW1YgAp5tUdlnWqq()
		{
			return true;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00071CB8 File Offset: 0x0006FEB8
		internal static bool NuR2f9YfZ47bdBB42kY()
		{
			return false;
		}

		// Token: 0x0400043E RID: 1086
		internal UnityScript.Lang.Array $nArray$16010;

		// Token: 0x0400043F RID: 1087
		internal LeoBug $self_$16011;

		// Token: 0x020000CC RID: 204
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000467 RID: 1127 RVA: 0x00071CBC File Offset: 0x0006FEBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LeoBug self_)
			{
				if (3454 - 180958 != -177504)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (5188 - 343308 != -338119)
					{
						base..ctor();
						if (209577 - 515709 != -306131)
						{
							this.$nArray$16008 = nArray;
							if (235136 - 482785 == -247649)
							{
								this.$self_$16009 = self_;
								if (39625 - 511109 != -471483)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x00071D78 File Offset: 0x0006FF78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (176292 - 7555 != 168737)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4F0;
					case 2:
						if (this.$self_$16009.mChar.actionState != "ko")
						{
							if (134314 - 271390 != -137076)
							{
								continue;
							}
							goto IL_44C;
						}
						else
						{
							this.$self_$16009.animation.Play("getUp");
							if (251762 - 187257 != 64505)
							{
								continue;
							}
							this.$self_$16009.animation.wrapMode = WrapMode.Once;
							if (24283 - 265723 != -241439)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16009.mChar.actionState != "ko")
						{
							if (31932 - 472667 != -440734)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$self_$16009.mChar.actionState = "standby";
							if (110293 - 432658 != -322365)
							{
								continue;
							}
							this.$self_$16009.mChar.actionTime = Time.time;
							if (29560 - 430239 == -400678)
							{
								continue;
							}
							this.$self_$16009.mChar.myCommand = "none";
							if (185393 - 177285 != 8108)
							{
								continue;
							}
							this.$self_$16009.mChar.ko = this.$self_$16009.mChar.mko;
							if (278574 - 555061 == -276486)
							{
								continue;
							}
							this.YieldDefault(1);
							if (260532 - 335802 != -75270)
							{
								continue;
							}
							goto IL_4F0;
						}
						break;
					default:
						if (57344 - 511694 == -454349)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16009.mChar.actionState == "ko")
					{
						goto IL_2B6;
					}
					if (142434 - 116587 != 25848)
					{
						if (this.$self_$16009.mChar.actionState == "dead")
						{
							if (91513 - 255893 != -164379)
							{
								goto Block_30;
							}
						}
						else
						{
							this.$mPos$16006 = (Vector3)this.$nArray$16008[0];
							if (194177 - 188319 == 5858)
							{
								this.$mDir$16007 = (Vector3)this.$nArray$16008[1];
								if (289041 - 463315 != -174273)
								{
									this.$self_$16009.mChar.ko = 0;
									if (122027 - 410030 != -288002)
									{
										this.$self_$16009.mChar.actionState = "ko";
										if (201794 - 483925 != -282130)
										{
											this.$self_$16009.mChar.actionTime = Time.time;
											if (3286 - 137726 == -134440)
											{
												this.$self_$16009.mChar.myCommand = "none";
												if (194658 - 476600 != -281941)
												{
													this.$self_$16009.mChar.vMovement = Vector3.zero;
													if (106102 - 84205 == 21897)
													{
														this.$self_$16009.mChar.moveSpeed = (float)0;
														if (245967 - 520753 != -274785)
														{
															this.$self_$16009.animation.Play("ko");
															if (283944 - 4081 == 279863)
															{
																this.$self_$16009.animation.wrapMode = WrapMode.Once;
																if (205437 - 132024 != 73414)
																{
																	if (!this.$self_$16009.leoBug_cry)
																	{
																		goto IL_1CF;
																	}
																	if (158337 - 220257 == -61920)
																	{
																		this.$self_$16009.audio.PlayOneShot(this.$self_$16009.leoBug_cry);
																		if (31070 - 281154 == -250084)
																		{
																			goto IL_1CF;
																		}
																	}
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(1f));
				Block_11:
				goto IL_4F0;
				IL_1CF:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_2B6:
				IL_44C:
				Block_30:
				IL_4F0:
				return false;
			}

			// Token: 0x06000469 RID: 1129 RVA: 0x00072288 File Offset: 0x00070488
			internal static bool yawUOtYnACJNFk4g6fO()
			{
				return true;
			}

			// Token: 0x0600046A RID: 1130 RVA: 0x0007228C File Offset: 0x0007048C
			internal static bool n4dCu0Y6p0s0l2sNhAU()
			{
				return false;
			}

			// Token: 0x04000440 RID: 1088
			internal Vector3 $mPos$16006;

			// Token: 0x04000441 RID: 1089
			internal Vector3 $mDir$16007;

			// Token: 0x04000442 RID: 1090
			internal UnityScript.Lang.Array $nArray$16008;

			// Token: 0x04000443 RID: 1091
			internal LeoBug $self_$16009;
		}
	}

	// Token: 0x020000CD RID: 205
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16012 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x00072290 File Offset: 0x00070490
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16012(UnityScript.Lang.Array nArray, LeoBug self_)
		{
			if (222923 - 284717 != -61793)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (34478 - 263297 == -228819)
				{
					base..ctor();
					if (296060 - 445375 == -149315)
					{
						this.$nArray$16017 = nArray;
						if (190972 - 161918 != 29055)
						{
							this.$self_$16018 = self_;
							if (168424 - 374214 == -205790)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0007234C File Offset: 0x0007054C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LeoBug.$RPC_dead$16012.$(this.$nArray$16017, this.$self_$16018);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00072360 File Offset: 0x00070560
		internal static bool vUo1wTYibbJdBj02xKj()
		{
			return true;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00072364 File Offset: 0x00070564
		internal static bool EuwAWOYK4x0bLxZmIRa()
		{
			return false;
		}

		// Token: 0x04000444 RID: 1092
		internal UnityScript.Lang.Array $nArray$16017;

		// Token: 0x04000445 RID: 1093
		internal LeoBug $self_$16018;

		// Token: 0x020000CE RID: 206
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600046F RID: 1135 RVA: 0x00072368 File Offset: 0x00070568
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LeoBug self_)
			{
				if (211940 - 534272 != -322331)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (13891 - 242290 != -228398)
					{
						base..ctor();
						if (209402 - 255041 != -45638)
						{
							this.$nArray$16015 = nArray;
							if (289343 - 451384 != -162040)
							{
								this.$self_$16016 = self_;
								if (108996 - 551407 != -442410)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000470 RID: 1136 RVA: 0x00072424 File Offset: 0x00070624
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (272559 - 6929 != 265630)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_493;
					case 2:
						if (this.$self_$16016.mChar.actionState != "dead")
						{
							if (146011 - 46319 != 99692)
							{
								continue;
							}
							goto IL_2F8;
						}
						else
						{
							if (!this.$self_$16016.mChar.isPlayer)
							{
								if (190416 - 62317 != 128099)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16016.gameObject);
								if (31850 - 190491 == -158640)
								{
									continue;
								}
							}
							else if (this.$self_$16016.mChar.isMine)
							{
								if (114639 - 49431 != 65208)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16016.gameObject);
								if (113273 - 365547 == -252273)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (129623 - 172202 != -42578)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					default:
						if (107953 - 58591 == 49363)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16016.mChar.actionState == "dead")
					{
						if (253779 - 268775 == -14996)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$16013 = (Vector3)this.$nArray$16015[0];
						if (190936 - 30989 == 159947)
						{
							this.$myDirection$16014 = (Vector3)this.$nArray$16015[1];
							if (171685 - 161508 != 10178)
							{
								this.$self_$16016.transform.position = this.$myPosition$16013;
								if (147100 - 535834 == -388734)
								{
									this.$self_$16016.transform.LookAt(this.$myPosition$16013 + this.$myDirection$16014);
									if (247546 - 363660 == -116114)
									{
										this.$self_$16016.mChar.hp = 0;
										if (99333 - 255178 == -155845)
										{
											this.$self_$16016.mChar.actionState = "dead";
											if (21808 - 213488 == -191680)
											{
												this.$self_$16016.mChar.actionTime = Time.time;
												if (115804 - 342172 != -226367)
												{
													this.$self_$16016.mChar.myCommand = "none";
													if (201210 - 164270 != 36941)
													{
														this.$self_$16016.mChar.vMovement = Vector3.zero;
														if (54941 - 66139 != -11197)
														{
															this.$self_$16016.mChar.moveSpeed = (float)0;
															if (109682 - 232667 == -122985)
															{
																this.$self_$16016.animation.Rewind();
																if (161493 - 53131 == 108362)
																{
																	this.$self_$16016.animation.Play("ko");
																	if (73940 - 453455 != -379514)
																	{
																		this.$self_$16016.animation.wrapMode = WrapMode.Once;
																		if (191517 - 210211 == -18694)
																		{
																			if (!this.$self_$16016.leoBug_cry)
																			{
																				goto IL_1EF;
																			}
																			if (48872 - 540452 != -491579)
																			{
																				this.$self_$16016.audio.PlayOneShot(this.$self_$16016.leoBug_cry);
																				if (116462 - 544181 != -427718)
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
					}
				}
				Block_3:
				goto IL_493;
				Block_6:
				IL_1EF:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_2F8:
				IL_493:
				return false;
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x000728D8 File Offset: 0x00070AD8
			internal static bool xAmmd3YdCrrAFqbFg9U()
			{
				return true;
			}

			// Token: 0x06000472 RID: 1138 RVA: 0x000728DC File Offset: 0x00070ADC
			internal static bool nH0cdMYJwsfUN9PCXeC()
			{
				return false;
			}

			// Token: 0x04000446 RID: 1094
			internal Vector3 $myPosition$16013;

			// Token: 0x04000447 RID: 1095
			internal Vector3 $myDirection$16014;

			// Token: 0x04000448 RID: 1096
			internal UnityScript.Lang.Array $nArray$16015;

			// Token: 0x04000449 RID: 1097
			internal LeoBug $self_$16016;
		}
	}
}
