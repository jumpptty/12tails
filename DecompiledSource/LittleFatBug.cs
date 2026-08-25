using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000D8 RID: 216
[Serializable]
public class LittleFatBug : MonoBehaviour
{
	// Token: 0x060004B5 RID: 1205 RVA: 0x0007ADCC File Offset: 0x00078FCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LittleFatBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x0007ADDC File Offset: 0x00078FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (272870 - 504564 != -231694)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (256060 - 582535 != -326474)
			{
				this.mChar.actionState = "standby";
				if (142857 - 398242 != -255384)
				{
					this.mChar.actionTime = Time.time;
					if (11813 - 186081 != -174267)
					{
						this.mChar.myCommand = "none";
						if (55195 - 307027 == -251832)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (17250 - 556572 == -539322)
							{
								this.mChar.isMine = true;
								if (169507 - 216099 == -46592)
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

	// Token: 0x060004B7 RID: 1207 RVA: 0x0007AF14 File Offset: 0x00079114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (174353 - 78967 != 95386)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (154294 - 205867 == -51572)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (210191 - 232365 != -22174)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2CD;
					}
					if (14178 - 204146 != -189968)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (12309 - 480034 == -467724)
				{
					continue;
				}
			}
			IL_2CD:
			if (this.mChar.hp <= 0)
			{
				if (69839 - 133572 == -63732)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (118362 - 363029 == -244666)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (159124 - 540115 == -380990)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (94011 - 370182 == -276170)
						{
							continue;
						}
						if (status != null)
						{
							if (251635 - 186852 != 64783)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (60179 - 114255 == -54075)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (206958 - 188471 != 18487)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (197828 - 480015 != -282187)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (145065 - 189808 != -44743)
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
							if (298670 - 477344 != -178674)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (28055 - 11244 == 16812)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (250740 - 166832 != 83908)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (173368 - 597426 != -424057)
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
			if (167302 - 364595 == -197293)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (200713 - 137616 != 63098)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (270149 - 284221 == -14072)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (218313 - 237012 == -18699)
						{
							if (this.mChar.isMine)
							{
								if (202599 - 182609 != 19991)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (177694 - 112099 != 65596)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (99124 - 493381 != -394256)
										{
											this.mChar.KoEvent();
											if (118203 - 371276 != -253072)
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
								if (64594 - 444789 != -380194)
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

	// Token: 0x060004B8 RID: 1208 RVA: 0x0007B414 File Offset: 0x00079614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (163557 - 141201 != 22356)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (91450 - 171963 == -80513)
			{
				float runSpeed = this.mChar.runSpeed;
				if (233448 - 460816 == -227368)
				{
					Vector3 a = default(Vector3);
					if (76392 - 100025 != -23632)
					{
						Vector3 vector = Vector3.zero;
						if (283309 - 117627 != 165683)
						{
							float num2 = (float)0;
							if (52723 - 493523 != -440799)
							{
								if (this.mChar.isMine)
								{
									if (89676 - 329918 == -240241)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (183637 - 529587 != -345950)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (104324 - 235716 == -131391)
										{
											continue;
										}
										a.y = (float)0;
										if (32444 - 253783 == -221338)
										{
											continue;
										}
										a = a.normalized;
										if (12424 - 253685 != -241261)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (252862 - 31370 == 221493)
										{
											continue;
										}
										vector = vector.normalized;
										if (58404 - 493368 != -434964)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (269080 - 227799 != 41281)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (143315 - 269786 != -126471)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (258193 - 584381 != -326188)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (7531 - 150173 == -142641)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (194073 - 476484 == -282410)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (233294 - 306849 == -73554)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (288939 - 410601 == -121661)
														{
															continue;
														}
														this.animation.Play("run");
														if (103786 - 493154 == -389367)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (144999 - 392463 != -247464)
														{
															continue;
														}
														goto IL_46C;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (30833 - 442189 == -411355)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (17078 - 244592 != -227514)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (45657 - 448359 != -402702)
											{
												continue;
											}
											num = (float)0;
											if (283383 - 282244 == 1140)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (169669 - 566393 != -396724)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (131643 - 389421 != -257778)
										{
											continue;
										}
									}
									IL_46C:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (254092 - 15747 == 238346)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (135812 - 114613 != 21199)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (191272 - 572588 != -381316)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (244336 - 418480 != -174144)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (242786 - 73945 == 168842)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (100399 - 563198 != -462799)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (214577 - 317054 != -102477)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (184521 - 569314 == -384792)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (102776 - 226993 == -124216)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (210814 - 290405 != -79591)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (94261 - 477758 != -383497)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (283729 - 520390 != -236661)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (113698 - 296241 != -182543)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (232971 - 320280 != -87309)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (219728 - 52218 != 167510)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (47476 - 337854 != -290378)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (153041 - 416037 != -262996)
												{
													continue;
												}
												num = (float)0;
												if (19398 - 189231 == -169832)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (123072 - 50952 != 72120)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (219119 - 599685 != -380566)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (244577 - 414843 == -170265)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (44269 - 192543 != -148274)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (211360 - 392699 == -181338)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (216054 - 559032 != -342978)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (54644 - 283045 == -228400)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (97064 - 280856 != -183792)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (107881 - 411079 == -303197)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (201688 - 318909 == -117220)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (179777 - 544918 == -365140)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (174461 - 175650 != -1189)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (277248 - 317066 == -39817)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (272849 - 399003 == -126153)
											{
												continue;
											}
											num = (float)0;
											if (248981 - 361959 == -112977)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (55314 - 179608 != -124294)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (164799 - 149192 != 15607)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (152033 - 27872 == 124162)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (102088 - 128079 == -25990)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (262529 - 218892 != 43638)
								{
									this.mChar.moveSpeed = num;
									if (80225 - 354162 != -273936)
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

	// Token: 0x060004B9 RID: 1209 RVA: 0x0007BF78 File Offset: 0x0007A178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (199928 - 501176 != -301247)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (147545 - 37331 != 110215)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (111210 - 67728 != 43483 && 136386 - 61732 != 74655)
				{
					if (ActionName == "RPC_shrubSpin")
					{
						if (239352 - 394481 == -155128)
						{
							continue;
						}
						v = 1;
						if (55340 - 58186 == -2845)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_shrubSpin_hit")
					{
						if (137442 - 342567 != -205125)
						{
							continue;
						}
						v = -1;
						if (112839 - 191429 == -78589)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (269877 - 503113 == -233236)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (283145 - 176939 == 106206)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (24918 - 48261 == -23343)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (180589 - 343408 == -162819)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (161326 - 454062 != -292735)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (290936 - 80910 != 210027)
										{
											Hashtable hashtable = new Hashtable();
											if (218032 - 216707 != 1326)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (215127 - 231389 != -16261)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (268462 - 472711 == -204249)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (97016 - 7829 != 89188)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (67157 - 93447 != -26289)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (75636 - 35075 == 40561)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (117577 - 294526 == -176949)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (114837 - 410546 == -295709)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (107927 - 469417 == -361490)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (15412 - 358601 != -343188)
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

	// Token: 0x060004BA RID: 1210 RVA: 0x0007C3CC File Offset: 0x0007A5CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (132545 - 163338 != -30792)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (181060 - 117836 == 63224)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (87581 - 512832 == -425251)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (39081 - 321959 == -282878)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (86017 - 379946 != -293928)
						{
							int num3 = num;
							if (112268 - 80804 == 31464)
							{
								if (num3 == 1)
								{
									if (18649 - 136560 != -117910)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (272437 - 393813 == -121376)
										{
											this.StartCoroutine_Auto(this.RPC_shrubSpin(vector, vector2, num2));
											if (239462 - 569191 == -329729)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (69023 - 180781 != -111757)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (215825 - 416966 != -201140)
										{
											this.RPC_shrubSpin_hit(vector, vector2, num2);
											if (263457 - 15913 == 247544)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (207083 - 510772 == -303689)
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

	// Token: 0x060004BB RID: 1211 RVA: 0x0007C660 File Offset: 0x0007A860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (117313 - 428693 != -311379)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (191015 - 61555 == 129460)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (225670 - 366327 == -140657)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (201159 - 584415 == -383256)
					{
						Vector3 normalized = vector.normalized;
						if (228771 - 203560 != 25212)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (228664 - 446310 != -217645 && 243484 - 33886 != 209599)
							{
								if (gameObject)
								{
									if (245111 - 116648 != 128463)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (231537 - 220878 != 10659)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (282242 - 348715 == -66472)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (120828 - 189523 == -68694)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (159305 - 139210 == 20095)
								{
									this.StartCoroutine_Auto(this.RPC_shrubSpin(this.transform.position, normalized, 0));
									if (191159 - 382668 == -191509)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (215506 - 547845 == -332339)
										{
											this.ActionEvent("RPC_shrubSpin", this.transform.position, normalized, 0);
											if (232605 - 154367 != 78239)
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

	// Token: 0x060004BC RID: 1212 RVA: 0x0007C91C File Offset: 0x0007AB1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x0007C920 File Offset: 0x0007AB20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x0007C924 File Offset: 0x0007AB24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_shrubSpin(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LittleFatBug.$RPC_shrubSpin$16047(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x0007C934 File Offset: 0x0007AB34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_shrubSpin_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.shrubSpin_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x0007C950 File Offset: 0x0007AB50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new LittleFatBug.$RPC_ko$16064(nArray, this).GetEnumerator();
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x0007C960 File Offset: 0x0007AB60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new LittleFatBug.$RPC_dead$16071(nArray, this).GetEnumerator();
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x0007C970 File Offset: 0x0007AB70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x0007C974 File Offset: 0x0007AB74
	internal static bool iHZxuSY1C4sUUfHCCPT()
	{
		return true;
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x0007C978 File Offset: 0x0007AB78
	internal static bool sHQf6VY4XiCX5gaytCF()
	{
		return false;
	}

	// Token: 0x04000472 RID: 1138
	public CharacterControl mChar;

	// Token: 0x04000473 RID: 1139
	public GameObject shrubSpin_trail;

	// Token: 0x04000474 RID: 1140
	public GameObject shrubSpin_hit;

	// Token: 0x020000D9 RID: 217
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_shrubSpin$16047 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060004C5 RID: 1221 RVA: 0x0007C97C File Offset: 0x0007AB7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_shrubSpin$16047(Vector3 mPos, Vector3 tDir, LittleFatBug self_)
		{
			if (184936 - 171727 != 13209)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199901 - 428755 != -228853)
				{
					base..ctor();
					if (233343 - 460007 == -226664)
					{
						this.$mPos$16061 = mPos;
						if (137919 - 165180 != -27260)
						{
							this.$tDir$16062 = tDir;
							if (253151 - 101633 == 151518)
							{
								this.$self_$16063 = self_;
								if (179557 - 262027 == -82470)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0007CA58 File Offset: 0x0007AC58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LittleFatBug.$RPC_shrubSpin$16047.$(this.$mPos$16061, this.$tDir$16062, this.$self_$16063);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0007CA74 File Offset: 0x0007AC74
		internal static bool nyjt9xYzEYcpw65QTi6()
		{
			return true;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0007CA78 File Offset: 0x0007AC78
		internal static bool yIhJWAcaskOK8FYuVuo()
		{
			return false;
		}

		// Token: 0x04000475 RID: 1141
		internal Vector3 $mPos$16061;

		// Token: 0x04000476 RID: 1142
		internal Vector3 $tDir$16062;

		// Token: 0x04000477 RID: 1143
		internal LittleFatBug $self_$16063;

		// Token: 0x020000DA RID: 218
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060004C9 RID: 1225 RVA: 0x0007CA7C File Offset: 0x0007AC7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LittleFatBug self_)
			{
				if (100293 - 188709 != -88415)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (252862 - 97215 == 155647)
					{
						base..ctor();
						if (292758 - 65002 != 227757)
						{
							this.$mPos$16058 = mPos;
							if (196424 - 487422 == -290998)
							{
								this.$tDir$16059 = tDir;
								if (159681 - 462647 != -302965)
								{
									this.$self_$16060 = self_;
									if (67727 - 390841 == -323114)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060004CA RID: 1226 RVA: 0x0007CB58 File Offset: 0x0007AD58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237047 - 329924 != -92876)
				{
				}
				for (;;)
				{
					IL_20C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_EB0;
					case 2:
						if (this.$self_$16060.mChar.actionState != "attack")
						{
							goto IL_27E;
						}
						if (223669 - 238233 == -14563)
						{
							continue;
						}
						if (this.$self_$16060.mChar.myCommand != "shrubSpin")
						{
							if (98872 - 695 != 98178)
							{
								goto Block_60;
							}
							continue;
						}
						else
						{
							this.$self_$16060.mChar.moveSpeed = (float)8;
							if (273308 - 175117 == 98192)
							{
								continue;
							}
							this.$mArmL$16048 = global::Math.findChildObject(this.$self_$16060.transform, "a_L");
							if (286983 - 497337 == -210353)
							{
								continue;
							}
							if (!this.$mArmL$16048)
							{
								goto IL_B79;
							}
							if (272229 - 132811 == 139419)
							{
								continue;
							}
							this.$mShrubSpin_trail$16049 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$16060.shrubSpin_trail, Vector3.zero, Quaternion.identity);
							if (17287 - 332470 == -315182)
							{
								continue;
							}
							this.$mShrubSpin_trail$16049.transform.parent = this.$mArmL$16048;
							if (270496 - 555028 != -284532)
							{
								continue;
							}
							this.$mShrubSpin_trail$16049.transform.localPosition = new Vector3(-0.5f, (float)0, (float)0);
							if (68035 - 175475 != -107440)
							{
								continue;
							}
							this.$mShrubSpin_trail$16049.transform.localRotation = Quaternion.identity;
							if (5422 - 175650 != -170228)
							{
								continue;
							}
							this.$mShrubSpin_trail_control$16050 = (EffectControl)this.$mShrubSpin_trail$16049.GetComponent(typeof(EffectControl));
							if (272336 - 548368 != -276032)
							{
								continue;
							}
							this.$mShrubSpin_trail_control$16050.InitEffectControl(this.$self_$16060.gameObject);
							if (218690 - 274108 != -55417)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16060.mChar.actionState != "attack")
						{
							goto IL_616;
						}
						if (228895 - 352974 == -124078)
						{
							continue;
						}
						if (this.$self_$16060.mChar.myCommand != "shrubSpin")
						{
							if (266929 - 427378 != -160448)
							{
								goto Block_79;
							}
							continue;
						}
						else
						{
							this.$self_$16060.mChar.moveSpeed = (float)7;
							if (84816 - 354825 != -270009)
							{
								continue;
							}
							this.$hitLayer$16051 = 130816 - (1 << this.$self_$16060.gameObject.layer);
							if (282923 - 437471 != -154548)
							{
								continue;
							}
							this.$hitList$16052 = null;
							if (106138 - 464071 == -357932)
							{
								continue;
							}
							this.$hitPos$16053 = default(Vector3);
							if (279428 - 89172 == 190257)
							{
								continue;
							}
							if (!this.$self_$16060.mChar.isMine)
							{
								goto IL_A31;
							}
							if (94747 - 107860 != -13113)
							{
								continue;
							}
							this.$hitList$16052 = Damage.FindAreaTarget(this.$self_$16060.transform.position, 2.5f * this.$self_$16060.mChar.rangeMod, (float)2 * this.$self_$16060.mChar.rangeMod, this.$hitLayer$16051);
							if (200012 - 100573 == 99440)
							{
								continue;
							}
							this.$$iterator$9937$16055 = UnityRuntimeServices.GetEnumerator(this.$hitList$16052);
							if (30443 - 510121 == -479677)
							{
								continue;
							}
							while (this.$$iterator$9937$16055.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9937$16055.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16054 = (GameObject)obj2;
								if (75245 - 324377 != -249132)
								{
									goto IL_20C;
								}
								if (this.$self_$16060.mChar.hit(1, this.$hitObject$16054, this.$self_$16060.mChar.atk, 1, 0, 0.5f * (this.$hitObject$16054.transform.position - this.$self_$16060.transform.position).normalized) != 0)
								{
									if (218341 - 202751 == 15591)
									{
										goto IL_20C;
									}
									this.$hitPos$16053 = this.$hitObject$16054.collider.ClosestPointOnBounds(this.$self_$16060.transform.position + Vector3.up);
									if (267573 - 492621 != -225048)
									{
										goto IL_20C;
									}
									UnityRuntimeServices.Update(this.$$iterator$9937$16055, this.$hitObject$16054);
									if (186216 - 511491 != -325275)
									{
										goto IL_20C;
									}
									this.$self_$16060.RPC_shrubSpin_hit(this.$hitPos$16053, this.$self_$16060.transform.forward, 0);
									if (116170 - 451166 == -334995)
									{
										goto IL_20C;
									}
									this.$self_$16060.ActionEvent("RPC_shrubSpin_hit", this.$hitPos$16053, this.$self_$16060.transform.forward, 0);
									if (153817 - 557888 != -404071)
									{
										goto IL_20C;
									}
								}
							}
							if (21113 - 370748 != -349635)
							{
								continue;
							}
							goto IL_A31;
						}
						break;
					case 4:
						if (this.$self_$16060.mChar.actionState != "attack")
						{
							goto IL_647;
						}
						if (72529 - 29018 == 43512)
						{
							continue;
						}
						if (this.$self_$16060.mChar.myCommand != "shrubSpin")
						{
							if (203396 - 417911 != -214515)
							{
								continue;
							}
							goto IL_647;
						}
						else
						{
							this.$self_$16060.mChar.moveSpeed = (float)5;
							if (165796 - 386875 != -221079)
							{
								continue;
							}
							if (!this.$self_$16060.mChar.isMine)
							{
								goto IL_C01;
							}
							if (207739 - 549196 == -341456)
							{
								continue;
							}
							this.$hitList$16052 = Damage.FindAreaTarget(this.$self_$16060.transform.position, 2.5f * this.$self_$16060.mChar.rangeMod, (float)2 * this.$self_$16060.mChar.rangeMod, this.$hitLayer$16051);
							if (156360 - 74264 != 82096)
							{
								continue;
							}
							this.$$iterator$9938$16057 = UnityRuntimeServices.GetEnumerator(this.$hitList$16052);
							if (71756 - 496601 == -424844)
							{
								continue;
							}
							while (this.$$iterator$9938$16057.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9938$16057.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$16056 = (GameObject)obj4;
								if (142117 - 373066 != -230949)
								{
									goto IL_20C;
								}
								if (this.$self_$16060.mChar.hit(99, this.$hitObject$16056, this.$self_$16060.mChar.atk, 1, 0, 0.5f * (this.$hitObject$16056.transform.position - this.$self_$16060.transform.position).normalized) != 0)
								{
									if (197192 - 528361 == -331168)
									{
										goto IL_20C;
									}
									this.$hitPos$16053 = this.$hitObject$16056.collider.ClosestPointOnBounds(this.$self_$16060.transform.position + Vector3.up);
									if (147121 - 598652 == -451530)
									{
										goto IL_20C;
									}
									UnityRuntimeServices.Update(this.$$iterator$9938$16057, this.$hitObject$16056);
									if (190339 - 316399 == -126059)
									{
										goto IL_20C;
									}
									this.$self_$16060.RPC_shrubSpin_hit(this.$hitPos$16053, this.$self_$16060.transform.forward, 0);
									if (81655 - 315772 == -234116)
									{
										goto IL_20C;
									}
									this.$self_$16060.ActionEvent("RPC_shrubSpin_hit", this.$hitPos$16053, this.$self_$16060.transform.forward, 0);
									if (259706 - 578404 != -318698)
									{
										goto IL_20C;
									}
								}
							}
							if (103519 - 248834 != -145315)
							{
								continue;
							}
							goto IL_C01;
						}
						break;
					case 5:
						if (this.$self_$16060.mChar.actionState != "attack")
						{
							goto IL_E21;
						}
						if (47933 - 451274 != -403341)
						{
							continue;
						}
						if (this.$self_$16060.mChar.myCommand != "shrubSpin")
						{
							if (233580 - 500696 != -267116)
							{
								continue;
							}
							goto IL_E21;
						}
						else
						{
							this.$self_$16060.mChar.moveSpeed = (float)0;
							if (143277 - 94512 != 48766)
							{
								goto Block_83;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$16060.mChar.actionState == "attack")
						{
							if (224718 - 520791 != -296073)
							{
								continue;
							}
							if (this.$self_$16060.mChar.myCommand == "shrubSpin")
							{
								if (64189 - 361272 == -297082)
								{
									continue;
								}
								this.$self_$16060.mChar.actionState = "standby";
								if (16694 - 26889 != -10195)
								{
									continue;
								}
								this.$self_$16060.mChar.actionTime = Time.time;
								if (205886 - 208557 != -2671)
								{
									continue;
								}
								this.$self_$16060.mChar.myCommand = "none";
								if (117357 - 182938 != -65581)
								{
									continue;
								}
								if (!this.$self_$16060.mChar.isMine)
								{
									if (294378 - 428344 != -133966)
									{
										continue;
									}
									this.$self_$16060.mChar.nPosition = this.$self_$16060.transform.position;
									if (122117 - 29176 != 92941)
									{
										continue;
									}
									this.$self_$16060.mChar.oPosition = this.$self_$16060.transform.position;
									if (236474 - 18557 != 217917)
									{
										continue;
									}
									this.$self_$16060.mChar.nDirection = this.$self_$16060.transform.forward;
									if (92258 - 493548 != -401290)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (184822 - 1727 != 183095)
						{
							continue;
						}
						goto IL_EB0;
					default:
						if (155559 - 262715 == -107155)
						{
							continue;
						}
						break;
					}
					this.$self_$16060.mChar.actionState = "attack";
					if (1134 - 280561 == -279427)
					{
						this.$self_$16060.mChar.actionTime = Time.time;
						if (149718 - 455763 == -306045)
						{
							this.$self_$16060.mChar.myCommand = "shrubSpin";
							if (107185 - 130262 != -23076)
							{
								this.$self_$16060.mChar.addTimeOut("nAttack", (float)3);
								if (126478 - 319486 != -193007)
								{
									this.$self_$16060.transform.position = this.$mPos$16058;
									if (291070 - 597870 != -306799)
									{
										this.$self_$16060.transform.LookAt(this.$mPos$16058 + global::Math.vFlat(this.$tDir$16059));
										if (117465 - 352315 == -234850)
										{
											this.$self_$16060.animation.CrossFade("shrubSpin");
											if (28298 - 359624 == -331326)
											{
												this.$self_$16060.animation.wrapMode = WrapMode.Once;
												if (185541 - 429719 == -244178)
												{
													this.$self_$16060.mChar.vMovement = this.$self_$16060.transform.forward;
													if (157838 - 432157 == -274319)
													{
														this.$self_$16060.mChar.moveSpeed = (float)0;
														if (177875 - 345105 == -167230)
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
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_27E:
				IL_616:
				IL_647:
				goto IL_EB0;
				Block_47:
				goto IL_B79;
				IL_A31:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_60:
				goto IL_27E;
				IL_B79:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_C01:
				return this.Yield(5, new WaitForSeconds(0.1f));
				Block_79:
				IL_E21:
				goto IL_EB0;
				Block_83:
				return this.Yield(6, new WaitForSeconds(0.3f));
				IL_EB0:
				return false;
			}

			// Token: 0x060004CB RID: 1227 RVA: 0x0007DA28 File Offset: 0x0007BC28
			internal static bool eZ4XMVc50nYwTEMnblU()
			{
				return true;
			}

			// Token: 0x060004CC RID: 1228 RVA: 0x0007DA2C File Offset: 0x0007BC2C
			internal static bool K57PcxcpKTi6EVwAkeA()
			{
				return false;
			}

			// Token: 0x04000478 RID: 1144
			internal Transform $mArmL$16048;

			// Token: 0x04000479 RID: 1145
			internal GameObject $mShrubSpin_trail$16049;

			// Token: 0x0400047A RID: 1146
			internal EffectControl $mShrubSpin_trail_control$16050;

			// Token: 0x0400047B RID: 1147
			internal int $hitLayer$16051;

			// Token: 0x0400047C RID: 1148
			internal UnityScript.Lang.Array $hitList$16052;

			// Token: 0x0400047D RID: 1149
			internal Vector3 $hitPos$16053;

			// Token: 0x0400047E RID: 1150
			internal GameObject $hitObject$16054;

			// Token: 0x0400047F RID: 1151
			internal IEnumerator $$iterator$9937$16055;

			// Token: 0x04000480 RID: 1152
			internal GameObject $hitObject$16056;

			// Token: 0x04000481 RID: 1153
			internal IEnumerator $$iterator$9938$16057;

			// Token: 0x04000482 RID: 1154
			internal Vector3 $mPos$16058;

			// Token: 0x04000483 RID: 1155
			internal Vector3 $tDir$16059;

			// Token: 0x04000484 RID: 1156
			internal LittleFatBug $self_$16060;
		}
	}

	// Token: 0x020000DB RID: 219
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16064 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x0007DA30 File Offset: 0x0007BC30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16064(UnityScript.Lang.Array nArray, LittleFatBug self_)
		{
			if (136712 - 58303 != 78409)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (259857 - 531446 != -271588)
				{
					base..ctor();
					if (131162 - 163422 == -32260)
					{
						this.$nArray$16069 = nArray;
						if (185053 - 350945 == -165892)
						{
							this.$self_$16070 = self_;
							if (291380 - 111081 != 180300)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0007DAEC File Offset: 0x0007BCEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LittleFatBug.$RPC_ko$16064.$(this.$nArray$16069, this.$self_$16070);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0007DB00 File Offset: 0x0007BD00
		internal static bool fSbnBPcVokbq6xMnKZ0()
		{
			return true;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0007DB04 File Offset: 0x0007BD04
		internal static bool Og0s2WctcF67gQ4MTxD()
		{
			return false;
		}

		// Token: 0x04000485 RID: 1157
		internal UnityScript.Lang.Array $nArray$16069;

		// Token: 0x04000486 RID: 1158
		internal LittleFatBug $self_$16070;

		// Token: 0x020000DC RID: 220
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060004D1 RID: 1233 RVA: 0x0007DB08 File Offset: 0x0007BD08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LittleFatBug self_)
			{
				if (263652 - 320884 != -57231)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (244712 - 562156 == -317444)
					{
						base..ctor();
						if (105095 - 59213 != 45883)
						{
							this.$nArray$16067 = nArray;
							if (145641 - 192046 != -46404)
							{
								this.$self_$16068 = self_;
								if (252923 - 348940 != -96016)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x0007DBC4 File Offset: 0x0007BDC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (203263 - 329477 != -126214)
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
						if (this.$self_$16068.mChar.actionState != "ko")
						{
							if (196954 - 13637 != 183317)
							{
								continue;
							}
							goto IL_1BC;
						}
						else
						{
							this.$self_$16068.animation.Play("getUp");
							if (60633 - 39400 == 21234)
							{
								continue;
							}
							this.$self_$16068.animation.wrapMode = WrapMode.Once;
							if (59777 - 557749 != -497972)
							{
								continue;
							}
							goto IL_2D8;
						}
						break;
					case 3:
						if (this.$self_$16068.mChar.actionState != "ko")
						{
							if (231971 - 531741 != -299770)
							{
								continue;
							}
							goto IL_458;
						}
						else
						{
							this.$self_$16068.mChar.actionState = "standby";
							if (179461 - 460765 != -281304)
							{
								continue;
							}
							this.$self_$16068.mChar.actionTime = Time.time;
							if (159570 - 33637 == 125934)
							{
								continue;
							}
							this.$self_$16068.mChar.myCommand = "none";
							if (298242 - 80640 == 217603)
							{
								continue;
							}
							this.$self_$16068.mChar.ko = this.$self_$16068.mChar.mko;
							if (291359 - 583852 != -292493)
							{
								continue;
							}
							this.YieldDefault(1);
							if (143638 - 318591 != -174953)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (80063 - 272189 != -192126)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16068.mChar.actionState == "ko")
					{
						break;
					}
					if (103060 - 307012 != -203951)
					{
						if (this.$self_$16068.mChar.actionState == "dead")
						{
							if (17647 - 505033 == -487386)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16065 = (Vector3)this.$nArray$16067[0];
							if (72568 - 172378 == -99810)
							{
								this.$mDir$16066 = (Vector3)this.$nArray$16067[1];
								if (181986 - 453793 != -271806)
								{
									this.$self_$16068.mChar.ko = 0;
									if (28555 - 521058 == -492503)
									{
										this.$self_$16068.mChar.actionState = "ko";
										if (161455 - 228100 == -66645)
										{
											this.$self_$16068.mChar.actionTime = Time.time;
											if (66245 - 306421 != -240175)
											{
												this.$self_$16068.mChar.myCommand = "none";
												if (30619 - 74289 != -43669)
												{
													this.$self_$16068.mChar.vMovement = Vector3.zero;
													if (251095 - 462234 != -211138)
													{
														this.$self_$16068.mChar.moveSpeed = (float)0;
														if (128125 - 372865 != -244739)
														{
															this.$self_$16068.animation.Play("ko");
															if (60972 - 570370 == -509398)
															{
																this.$self_$16068.animation.wrapMode = WrapMode.Once;
																if (242341 - 466947 == -224606)
																{
																	goto IL_374;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1BC:
				goto IL_48C;
				IL_2D8:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_374:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_458:
				IL_48C:
				return false;
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x0007E070 File Offset: 0x0007C270
			internal static bool lwZ1CtcNIPTSGkiMuvp()
			{
				return true;
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x0007E074 File Offset: 0x0007C274
			internal static bool GZQ1chcY0NLX279V01l()
			{
				return false;
			}

			// Token: 0x04000487 RID: 1159
			internal Vector3 $mPos$16065;

			// Token: 0x04000488 RID: 1160
			internal Vector3 $mDir$16066;

			// Token: 0x04000489 RID: 1161
			internal UnityScript.Lang.Array $nArray$16067;

			// Token: 0x0400048A RID: 1162
			internal LittleFatBug $self_$16068;
		}
	}

	// Token: 0x020000DD RID: 221
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16071 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x0007E078 File Offset: 0x0007C278
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16071(UnityScript.Lang.Array nArray, LittleFatBug self_)
		{
			if (96192 - 499852 != -403659)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (143351 - 311595 != -168243)
				{
					base..ctor();
					if (270277 - 2324 != 267954)
					{
						this.$nArray$16076 = nArray;
						if (30208 - 541636 != -511427)
						{
							this.$self_$16077 = self_;
							if (193856 - 312884 != -119027)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0007E134 File Offset: 0x0007C334
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LittleFatBug.$RPC_dead$16071.$(this.$nArray$16076, this.$self_$16077);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0007E148 File Offset: 0x0007C348
		internal static bool Wh5PCLccU6RxMa0lE7E()
		{
			return true;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0007E14C File Offset: 0x0007C34C
		internal static bool D6Du7OcUNQgmucX2nA2()
		{
			return false;
		}

		// Token: 0x0400048B RID: 1163
		internal UnityScript.Lang.Array $nArray$16076;

		// Token: 0x0400048C RID: 1164
		internal LittleFatBug $self_$16077;

		// Token: 0x020000DE RID: 222
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060004D9 RID: 1241 RVA: 0x0007E150 File Offset: 0x0007C350
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LittleFatBug self_)
			{
				if (195484 - 524468 != -328984)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (26206 - 116713 == -90507)
					{
						base..ctor();
						if (160406 - 283954 == -123548)
						{
							this.$nArray$16074 = nArray;
							if (242364 - 179346 != 63019)
							{
								this.$self_$16075 = self_;
								if (293784 - 448699 != -154914)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060004DA RID: 1242 RVA: 0x0007E20C File Offset: 0x0007C40C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83395 - 32128 != 51267)
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
						if (this.$self_$16075.mChar.actionState != "dead")
						{
							if (266249 - 20360 != 245889)
							{
								continue;
							}
							goto IL_2DA;
						}
						else
						{
							if (!this.$self_$16075.mChar.isPlayer)
							{
								if (41296 - 207823 == -166526)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16075.gameObject);
								if (91259 - 310016 == -218756)
								{
									continue;
								}
							}
							else if (this.$self_$16075.mChar.isMine)
							{
								if (214469 - 587358 != -372889)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16075.gameObject);
								if (220340 - 51725 == 168616)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (213911 - 138913 != 74999)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					default:
						if (227388 - 476612 == -249223)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16075.mChar.actionState == "dead")
					{
						if (200665 - 91897 != 108769)
						{
							goto Block_25;
						}
					}
					else
					{
						this.$myPosition$16072 = (Vector3)this.$nArray$16074[0];
						if (14603 - 165157 != -150553)
						{
							this.$myDirection$16073 = (Vector3)this.$nArray$16074[1];
							if (95372 - 562458 == -467086)
							{
								this.$self_$16075.transform.position = this.$myPosition$16072;
								if (108210 - 56744 != 51467)
								{
									this.$self_$16075.transform.LookAt(this.$myPosition$16072 + this.$myDirection$16073);
									if (148219 - 365333 != -217113)
									{
										this.$self_$16075.mChar.hp = 0;
										if (19493 - 429712 != -410218)
										{
											this.$self_$16075.mChar.actionState = "dead";
											if (142624 - 285979 != -143354)
											{
												this.$self_$16075.mChar.actionTime = Time.time;
												if (125998 - 423082 != -297083)
												{
													this.$self_$16075.mChar.myCommand = "none";
													if (168293 - 454386 == -286093)
													{
														this.$self_$16075.mChar.vMovement = Vector3.zero;
														if (184671 - 568529 != -383857)
														{
															this.$self_$16075.mChar.moveSpeed = (float)0;
															if (84978 - 239046 == -154068)
															{
																this.$self_$16075.animation.Rewind();
																if (202245 - 585038 != -382792)
																{
																	this.$self_$16075.animation.Play("ko");
																	if (272299 - 553613 != -281313)
																	{
																		this.$self_$16075.animation.wrapMode = WrapMode.Once;
																		if (186395 - 338644 == -152249)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_18:
				IL_2DA:
				Block_25:
				IL_42F:
				return false;
			}

			// Token: 0x060004DB RID: 1243 RVA: 0x0007E65C File Offset: 0x0007C85C
			internal static bool EqgpA3cTR7Rqisp1tLA()
			{
				return true;
			}

			// Token: 0x060004DC RID: 1244 RVA: 0x0007E660 File Offset: 0x0007C860
			internal static bool DhmdYnc3mHno7B3U767()
			{
				return false;
			}

			// Token: 0x0400048D RID: 1165
			internal Vector3 $myPosition$16072;

			// Token: 0x0400048E RID: 1166
			internal Vector3 $myDirection$16073;

			// Token: 0x0400048F RID: 1167
			internal UnityScript.Lang.Array $nArray$16074;

			// Token: 0x04000490 RID: 1168
			internal LittleFatBug $self_$16075;
		}
	}
}
