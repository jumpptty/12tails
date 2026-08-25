using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200005C RID: 92
[Serializable]
public class FatBug : MonoBehaviour
{
	// Token: 0x060001D9 RID: 473 RVA: 0x0002F2A4 File Offset: 0x0002D4A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FatBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0002F2B4 File Offset: 0x0002D4B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (88535 - 21970 != 66566)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (146385 - 190273 == -43888)
			{
				this.mChar.actionState = "standby";
				if (39865 - 28254 == 11611)
				{
					this.mChar.actionTime = Time.time;
					if (67644 - 145532 != -77887)
					{
						this.mChar.myCommand = "none";
						if (210940 - 161542 != 49399)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (241075 - 292813 == -51738)
							{
								this.mChar.isMine = true;
								if (175426 - 538476 != -363049)
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

	// Token: 0x060001DB RID: 475 RVA: 0x0002F3EC File Offset: 0x0002D5EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (39405 - 259 != 39147)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (199542 - 320755 != -121213)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (199230 - 124588 == 74643)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_381;
					}
					if (259197 - 229876 == 29322)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (261317 - 277163 == -15845)
				{
					continue;
				}
			}
			IL_381:
			if (this.mChar.hp <= 0)
			{
				if (29536 - 100808 != -71272)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (96492 - 547973 == -451480)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (200373 - 154010 != 46363)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (3201 - 176723 != -173522)
						{
							continue;
						}
						if (status != null)
						{
							if (127081 - 425280 != -298199)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (268973 - 5883 != 263090)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (219977 - 258248 == -38270)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (200437 - 393585 == -193147)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (118591 - 367724 != -249133)
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
							if (104845 - 397008 == -292162)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (103907 - 449036 == -345128)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (183323 - 346050 != -162726)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (268702 - 12988 != 255714)
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
			if (259412 - 261869 == -2457)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (180442 - 396614 != -216171)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (173277 - 507347 != -334069)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (104088 - 80196 == 23892)
						{
							if (this.mChar.isMine)
							{
								if (75768 - 325452 != -249683)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (142658 - 17708 != 124951)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (168487 - 56050 != 112438)
										{
											this.mChar.KoEvent();
											if (182668 - 75939 != 106730)
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
								if (23204 - 324192 != -300987)
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

	// Token: 0x060001DC RID: 476 RVA: 0x0002F8EC File Offset: 0x0002DAEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (77715 - 188029 != -110313)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (28016 - 523719 != -495702)
			{
				float runSpeed = this.mChar.runSpeed;
				if (220403 - 551620 != -331216)
				{
					Vector3 a = default(Vector3);
					if (89422 - 257873 == -168451)
					{
						Vector3 vector = Vector3.zero;
						if (136417 - 182601 != -46183)
						{
							float num2 = (float)0;
							if (23331 - 78559 != -55227)
							{
								if (this.mChar.isMine)
								{
									if (35843 - 175863 == -140019)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (171167 - 143791 == 27377)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (161910 - 357221 == -195310)
										{
											continue;
										}
										a.y = (float)0;
										if (20189 - 497594 == -477404)
										{
											continue;
										}
										a = a.normalized;
										if (187575 - 232632 == -45056)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (5543 - 91756 != -86213)
										{
											continue;
										}
										vector = vector.normalized;
										if (278376 - 113656 == 164721)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (238395 - 162708 == 75688)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (163825 - 117585 != 46240)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (109013 - 429056 == -320042)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (133450 - 70786 != 62664)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (222513 - 472193 == -249679)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (100004 - 560922 == -460917)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (284953 - 49574 != 235379)
														{
															continue;
														}
														this.animation.Play("run");
														if (277733 - 208385 == 69349)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (102237 - 162872 != -60634)
														{
															goto IL_8B7;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (1891 - 390376 == -388484)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (212892 - 216093 == -3200)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (193081 - 170766 != 22315)
											{
												continue;
											}
											num = (float)0;
											if (83021 - 582714 != -499693)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (249944 - 194035 == 55910)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (156029 - 65384 == 90646)
										{
											continue;
										}
									}
									IL_8B7:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (165902 - 77328 == 88575)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (182534 - 314736 == -132201)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (127308 - 561276 == -433967)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (24113 - 262417 == -238303)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (82062 - 485247 == -403184)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (62045 - 167257 == -105211)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (172438 - 130694 != 41744)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (12934 - 426620 != -413686)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (89550 - 27818 != 61732)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (85845 - 187627 != -101782)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (126152 - 95572 != 30580)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (123882 - 115754 == 8129)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (90518 - 355884 == -265365)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (223452 - 7545 != 215907)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (86900 - 362342 == -275441)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (69696 - 183609 == -113912)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (66070 - 484837 == -418766)
												{
													continue;
												}
												num = (float)0;
												if (241108 - 598956 == -357847)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (21850 - 89728 != -67878)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (98226 - 252572 != -154346)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (123146 - 422883 == -299736)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (108758 - 357769 != -249011)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (168049 - 390198 == -222148)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (171845 - 86470 == 85376)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (54310 - 366200 == -311889)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (181430 - 280327 != -98897)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (29288 - 42980 == -13691)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (173178 - 287105 != -113927)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (204525 - 18403 != 186122)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (254660 - 179863 != 74797)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (19275 - 418327 != -399052)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (154532 - 13897 == 140636)
											{
												continue;
											}
											num = (float)0;
											if (67958 - 175775 == -107816)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (172900 - 163033 == 9868)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (36295 - 507050 != -470755)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (188008 - 281757 != -93749)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (206449 - 248060 == -41610)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (290479 - 67560 == 222919)
								{
									this.mChar.moveSpeed = num;
									if (184644 - 246071 == -61427)
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

	// Token: 0x060001DD RID: 477 RVA: 0x00030450 File Offset: 0x0002E650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (211665 - 212012 != -346)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (149103 - 117606 != 31498)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (34188 - 305214 == -271026)
				{
					if (216144 - 453849 == -237705)
					{
						if (ActionName == "RPC_weedSwipe")
						{
							if (50281 - 57041 != -6760)
							{
								continue;
							}
							v = 1;
							if (104725 - 117690 != -12965)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_weedSwipe_hit")
						{
							if (188792 - 47746 != 141046)
							{
								continue;
							}
							v = -1;
							if (257098 - 397545 != -140447)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bellyBump")
						{
							if (89730 - 321990 == -232259)
							{
								continue;
							}
							v = 2;
							if (36314 - 516202 != -479888)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bellyBump_hit")
						{
							if (269836 - 40467 == 229370)
							{
								continue;
							}
							v = -2;
							if (286888 - 14426 == 272463)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (188233 - 101213 != 87021)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (73748 - 370010 != -296261)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (198699 - 533944 == -335245)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (225520 - 69033 == 156487)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (262024 - 339724 != -77699)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (128764 - 268401 != -139636)
											{
												Hashtable hashtable = new Hashtable();
												if (181199 - 598592 != -417392)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (41449 - 159774 == -118325)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (195615 - 266714 == -71099)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (198055 - 243887 != -45831)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (108531 - 587460 != -478928)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (276676 - 210814 == 65862)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (228481 - 543898 == -315417)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (57023 - 117187 != -60163)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (38744 - 208166 != -169421)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (191753 - 593949 == -402196)
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

	// Token: 0x060001DE RID: 478 RVA: 0x0003093C File Offset: 0x0002EB3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (30452 - 145221 != -114769)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (229419 - 133560 != 95860)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (294524 - 43493 == 251031)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (154901 - 528206 == -373305)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (184488 - 257308 == -72820)
						{
							int num3 = num;
							if (132539 - 366729 != -234189)
							{
								if (num3 == 1)
								{
									if (15601 - 419406 == -403805)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (105989 - 498914 == -392925)
										{
											this.StartCoroutine_Auto(this.RPC_weedSwipe(vector, vector2, num2));
											if (3350 - 503578 == -500228)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (263641 - 8828 == 254813)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (224831 - 350123 != -125291)
										{
											this.RPC_weedSwipe_hit(vector, vector2, num2);
											if (271906 - 335715 == -63809)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (57276 - 558766 != -501489)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (55777 - 73773 == -17996)
										{
											this.StartCoroutine_Auto(this.RPC_bellyBump(vector, vector2, num2));
											if (58679 - 508467 == -449788)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (9928 - 410428 != -400499)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (117499 - 401228 == -283729)
										{
											this.StartCoroutine_Auto(this.RPC_bellyBump(vector, vector2, num2));
											if (29477 - 219823 == -190346)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (171575 - 429243 != -257667)
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

	// Token: 0x060001DF RID: 479 RVA: 0x00030CC8 File Offset: 0x0002EEC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (187080 - 200399 != -13318)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (210337 - 32943 != 177395)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (50524 - 262576 != -212051)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (49883 - 548183 != -498299)
					{
						Vector3 normalized = vector.normalized;
						if (297065 - 215746 == 81319)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (203280 - 389905 == -186625)
							{
								if (267940 - 569165 == -301225)
								{
									if (gameObject)
									{
										if (226470 - 15865 != 210605)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (209611 - 288066 == -78454)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (128502 - 104724 == 23779)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (78641 - 37726 == 40916)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (243350 - 191554 != 51797)
									{
										if (UnityEngine.Random.Range(0, 100) <= 65)
										{
											if (184934 - 52054 == 132880)
											{
												this.StartCoroutine_Auto(this.RPC_weedSwipe(this.transform.position, normalized, 0));
												if (201350 - 178126 == 23224)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (99127 - 265153 == -166026)
													{
														this.ActionEvent("RPC_weedSwipe", this.transform.position, normalized, 0);
														if (134788 - 338192 != -203403)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_bellyBump(this.transform.position, normalized, 0));
											if (233001 - 345401 == -112400)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (247937 - 325238 != -77300)
												{
													this.ActionEvent("RPC_bellyBump", this.transform.position, normalized, 0);
													if (189810 - 543582 == -353772)
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

	// Token: 0x060001E0 RID: 480 RVA: 0x0003103C File Offset: 0x0002F23C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00031040 File Offset: 0x0002F240
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00031044 File Offset: 0x0002F244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_weedSwipe(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FatBug.$RPC_weedSwipe$15547(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00031054 File Offset: 0x0002F254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_weedSwipe_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (32753 - 466134 != -433380)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Instantiate(this.weedSwipe_hit, hitPos, this.transform.rotation);
			if (22074 - 339337 == -317263)
			{
				if (Time.time <= this.RbMwQQLcj)
				{
					break;
				}
				if (251618 - 277162 != -25543)
				{
					this.RbMwQQLcj = Time.time + 0.1f;
					if (134844 - 45058 == 89786)
					{
						if (!this.weedSwipe_hitFX)
						{
							break;
						}
						if (180089 - 233884 != -53794)
						{
							this.audio.PlayOneShot(this.weedSwipe_hitFX);
							if (81807 - 424875 == -343068)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00031168 File Offset: 0x0002F368
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bellyBump(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FatBug.$RPC_bellyBump$15564(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x00031178 File Offset: 0x0002F378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bellyBump_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (54024 - 52692 != 1332)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Instantiate(this.bellyBump_hit, hitPos, this.transform.rotation);
			if (118380 - 312324 != -193943)
			{
				if (Time.time <= this.M0MUCX5q6)
				{
					break;
				}
				if (187382 - 523373 != -335990)
				{
					this.M0MUCX5q6 = Time.time + 0.1f;
					if (53166 - 300503 != -247336)
					{
						if (!this.bellyBump_hitFX)
						{
							break;
						}
						if (177598 - 171070 != 6529)
						{
							this.audio.PlayOneShot(this.bellyBump_hitFX);
							if (8041 - 578323 != -570281)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x0003128C File Offset: 0x0002F48C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new FatBug.$RPC_ko$15577(nArray, this).GetEnumerator();
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x0003129C File Offset: 0x0002F49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new FatBug.$RPC_dead$15584(nArray, this).GetEnumerator();
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x000312AC File Offset: 0x0002F4AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x000312B0 File Offset: 0x0002F4B0
	internal static bool xjKofHp1nRBxd0VHmT6()
	{
		return true;
	}

	// Token: 0x060001EA RID: 490 RVA: 0x000312B4 File Offset: 0x0002F4B4
	internal static bool iPSPBUp4pv1C4CMbGMJ()
	{
		return false;
	}

	// Token: 0x0400021A RID: 538
	public CharacterControl mChar;

	// Token: 0x0400021B RID: 539
	public AudioClip snarl;

	// Token: 0x0400021C RID: 540
	public GameObject weedSwipe_weed;

	// Token: 0x0400021D RID: 541
	public GameObject weedSwipe_hit;

	// Token: 0x0400021E RID: 542
	public AudioClip weedSwipe_hitFX;

	// Token: 0x0400021F RID: 543
	private float RbMwQQLcj;

	// Token: 0x04000220 RID: 544
	public GameObject bellyBump_hit;

	// Token: 0x04000221 RID: 545
	public AudioClip bellyBump_hitFX;

	// Token: 0x04000222 RID: 546
	private float M0MUCX5q6;

	// Token: 0x0200005D RID: 93
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_weedSwipe$15547 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060001EB RID: 491 RVA: 0x000312B8 File Offset: 0x0002F4B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_weedSwipe$15547(Vector3 mPos, Vector3 tDir, FatBug self_)
		{
			if (9411 - 429944 != -420533)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (151224 - 430221 == -278997)
				{
					base..ctor();
					if (153006 - 209399 == -56393)
					{
						this.$mPos$15561 = mPos;
						if (248959 - 495299 == -246340)
						{
							this.$tDir$15562 = tDir;
							if (154491 - 465419 != -310927)
							{
								this.$self_$15563 = self_;
								if (169140 - 432536 == -263396)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00031394 File Offset: 0x0002F594
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FatBug.$RPC_weedSwipe$15547.$(this.$mPos$15561, this.$tDir$15562, this.$self_$15563);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000313B0 File Offset: 0x0002F5B0
		internal static bool IU0NUPpzqjwHSx7J2HT()
		{
			return true;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000313B4 File Offset: 0x0002F5B4
		internal static bool h8jlJnVaNnXTY1sUwD1()
		{
			return false;
		}

		// Token: 0x04000223 RID: 547
		internal Vector3 $mPos$15561;

		// Token: 0x04000224 RID: 548
		internal Vector3 $tDir$15562;

		// Token: 0x04000225 RID: 549
		internal FatBug $self_$15563;

		// Token: 0x0200005E RID: 94
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060001EF RID: 495 RVA: 0x000313B8 File Offset: 0x0002F5B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FatBug self_)
			{
				if (144297 - 546912 != -402615)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (159704 - 526509 != -366804)
					{
						base..ctor();
						if (264278 - 203124 == 61154)
						{
							this.$mPos$15558 = mPos;
							if (86144 - 329224 == -243080)
							{
								this.$tDir$15559 = tDir;
								if (8471 - 213976 == -205505)
								{
									this.$self_$15560 = self_;
									if (107220 - 323434 != -216213)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x00031494 File Offset: 0x0002F694
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15308 - 413207 != -397898)
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
						goto IL_ECE;
					case 2:
						if (this.$self_$15560.mChar.actionState != "attack")
						{
							goto IL_3CB;
						}
						if (246181 - 371959 != -125778)
						{
							continue;
						}
						if (this.$self_$15560.mChar.myCommand != "weedSwipe")
						{
							if (44880 - 257494 != -212613)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$self_$15560.mChar.moveSpeed = (float)8;
							if (21099 - 199188 == -178088)
							{
								continue;
							}
							this.$mArmL$15548 = global::Math.findChildObject(this.$self_$15560.transform, "a_L");
							if (183600 - 316352 != -132752)
							{
								continue;
							}
							if (!this.$mArmL$15548)
							{
								goto IL_BB8;
							}
							if (283957 - 34575 == 249383)
							{
								continue;
							}
							this.$mWeedSwipe_weed$15549 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$15560.weedSwipe_weed, Vector3.zero, Quaternion.identity);
							if (21913 - 369017 == -347103)
							{
								continue;
							}
							this.$mWeedSwipe_weed$15549.transform.parent = this.$mArmL$15548;
							if (152009 - 12337 != 139672)
							{
								continue;
							}
							this.$mWeedSwipe_weed$15549.transform.localPosition = new Vector3(-1.35f, (float)0, (float)0);
							if (190778 - 347337 == -156558)
							{
								continue;
							}
							this.$mWeedSwipe_weed$15549.transform.localRotation = Quaternion.identity;
							if (76223 - 308506 != -232283)
							{
								continue;
							}
							this.$mWeedSwipe_control$15550 = (EffectControl)this.$mWeedSwipe_weed$15549.GetComponent(typeof(EffectControl));
							if (204184 - 430886 != -226702)
							{
								continue;
							}
							this.$mWeedSwipe_control$15550.InitEffectControl(this.$self_$15560.gameObject);
							if (299218 - 430396 != -131177)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15560.mChar.actionState != "attack")
						{
							goto IL_A09;
						}
						if (205529 - 587570 != -382041)
						{
							continue;
						}
						if (this.$self_$15560.mChar.myCommand != "weedSwipe")
						{
							if (41557 - 358316 != -316758)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$15560.mChar.moveSpeed = (float)7;
							if (162503 - 64651 != 97852)
							{
								continue;
							}
							this.$hitLayer$15551 = 130816 - (1 << this.$self_$15560.gameObject.layer);
							if (143493 - 400718 != -257225)
							{
								continue;
							}
							this.$hitList$15552 = null;
							if (75784 - 409066 == -333281)
							{
								continue;
							}
							this.$hitPos$15553 = default(Vector3);
							if (150001 - 361500 != -211499)
							{
								continue;
							}
							if (!this.$self_$15560.mChar.isMine)
							{
								goto IL_212;
							}
							if (66192 - 439299 == -373106)
							{
								continue;
							}
							this.$hitList$15552 = Damage.FindAreaTarget(this.$self_$15560.transform.position, (float)4 * this.$self_$15560.mChar.rangeMod, (float)3 * this.$self_$15560.mChar.rangeMod, this.$hitLayer$15551);
							if (256392 - 144579 != 111813)
							{
								continue;
							}
							this.$$iterator$9898$15555 = UnityRuntimeServices.GetEnumerator(this.$hitList$15552);
							if (146652 - 544643 != -397991)
							{
								continue;
							}
							while (this.$$iterator$9898$15555.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9898$15555.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15554 = (GameObject)obj2;
								if (143127 - 84015 != 59112)
								{
									goto IL_45C;
								}
								if (this.$self_$15560.mChar.hit(1, this.$hitObject$15554, (int)(1.2f * (float)this.$self_$15560.mChar.atk), 1, 0, 0.5f * (this.$hitObject$15554.transform.position - this.$self_$15560.transform.position).normalized) != 0)
								{
									if (188152 - 483927 != -295775)
									{
										goto IL_45C;
									}
									this.$hitPos$15553 = this.$hitObject$15554.collider.ClosestPointOnBounds(this.$self_$15560.transform.position + 1.5f * Vector3.up);
									if (54027 - 592652 == -538624)
									{
										goto IL_45C;
									}
									UnityRuntimeServices.Update(this.$$iterator$9898$15555, this.$hitObject$15554);
									if (143531 - 315898 != -172367)
									{
										goto IL_45C;
									}
									this.$self_$15560.RPC_weedSwipe_hit(this.$hitPos$15553, this.$self_$15560.transform.forward, 0);
									if (9141 - 398602 != -389461)
									{
										goto IL_45C;
									}
									this.$self_$15560.ActionEvent("RPC_weedSwipe_hit", this.$hitPos$15553, this.$self_$15560.transform.forward, 0);
									if (281203 - 334019 == -52815)
									{
										goto IL_45C;
									}
								}
							}
							if (278853 - 405322 != -126469)
							{
								continue;
							}
							goto IL_212;
						}
						break;
					case 4:
						if (this.$self_$15560.mChar.actionState != "attack")
						{
							goto IL_42B;
						}
						if (186620 - 506094 == -319473)
						{
							continue;
						}
						if (this.$self_$15560.mChar.myCommand != "weedSwipe")
						{
							if (143849 - 65453 != 78396)
							{
								continue;
							}
							goto IL_42B;
						}
						else
						{
							this.$self_$15560.mChar.moveSpeed = (float)5;
							if (50598 - 194022 != -143424)
							{
								continue;
							}
							if (!this.$self_$15560.mChar.isMine)
							{
								goto IL_712;
							}
							if (202430 - 556530 == -354099)
							{
								continue;
							}
							this.$hitList$15552 = Damage.FindAreaTarget(this.$self_$15560.transform.position, (float)4 * this.$self_$15560.mChar.rangeMod, (float)3 * this.$self_$15560.mChar.rangeMod, this.$hitLayer$15551);
							if (155121 - 459907 != -304786)
							{
								continue;
							}
							this.$$iterator$9899$15557 = UnityRuntimeServices.GetEnumerator(this.$hitList$15552);
							if (178789 - 546094 != -367305)
							{
								continue;
							}
							while (this.$$iterator$9899$15557.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9899$15557.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$15556 = (GameObject)obj4;
								if (184748 - 330356 != -145608)
								{
									goto IL_45C;
								}
								if (this.$self_$15560.mChar.hit(99, this.$hitObject$15556, (int)(1.2f * (float)this.$self_$15560.mChar.atk), 1, 0, 0.5f * (this.$hitObject$15556.transform.position - this.$self_$15560.transform.position).normalized) != 0)
								{
									if (179341 - 119086 == 60256)
									{
										goto IL_45C;
									}
									this.$hitPos$15553 = this.$hitObject$15556.collider.ClosestPointOnBounds(this.$self_$15560.transform.position + 1.5f * Vector3.up);
									if (72717 - 547590 == -474872)
									{
										goto IL_45C;
									}
									UnityRuntimeServices.Update(this.$$iterator$9899$15557, this.$hitObject$15556);
									if (288174 - 376846 != -88672)
									{
										goto IL_45C;
									}
									this.$self_$15560.RPC_weedSwipe_hit(this.$hitPos$15553, this.$self_$15560.transform.forward, 0);
									if (221667 - 29004 == 192664)
									{
										goto IL_45C;
									}
									this.$self_$15560.ActionEvent("RPC_weedSwipe_hit", this.$hitPos$15553, this.$self_$15560.transform.forward, 0);
									if (169263 - 46171 != 123092)
									{
										goto IL_45C;
									}
								}
							}
							if (108512 - 178529 != -70016)
							{
								goto Block_62;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$15560.mChar.actionState != "attack")
						{
							goto IL_A8F;
						}
						if (226461 - 212815 != 13646)
						{
							continue;
						}
						if (this.$self_$15560.mChar.myCommand != "weedSwipe")
						{
							if (107680 - 229237 != -121556)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$self_$15560.mChar.moveSpeed = (float)0;
							if (170905 - 496334 != -325428)
							{
								goto Block_60;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$15560.mChar.actionState == "attack")
						{
							if (179266 - 448113 != -268847)
							{
								continue;
							}
							if (this.$self_$15560.mChar.myCommand == "weedSwipe")
							{
								if (249119 - 314861 == -65741)
								{
									continue;
								}
								this.$self_$15560.mChar.actionState = "standby";
								if (62639 - 165926 != -103287)
								{
									continue;
								}
								this.$self_$15560.mChar.actionTime = Time.time;
								if (204464 - 11616 == 192849)
								{
									continue;
								}
								this.$self_$15560.mChar.myCommand = "none";
								if (148942 - 72408 == 76535)
								{
									continue;
								}
								if (!this.$self_$15560.mChar.isMine)
								{
									if (178710 - 79181 != 99529)
									{
										continue;
									}
									this.$self_$15560.mChar.nPosition = this.$self_$15560.transform.position;
									if (7843 - 225341 == -217497)
									{
										continue;
									}
									this.$self_$15560.mChar.oPosition = this.$self_$15560.transform.position;
									if (284967 - 283692 == 1276)
									{
										continue;
									}
									this.$self_$15560.mChar.nDirection = this.$self_$15560.transform.forward;
									if (211536 - 89499 == 122038)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (130259 - 481356 != -351096)
						{
							goto Block_39;
						}
						continue;
					default:
						if (293782 - 277001 == 16782)
						{
							continue;
						}
						break;
					}
					this.$self_$15560.mChar.actionState = "attack";
					if (36089 - 251924 == -215835)
					{
						this.$self_$15560.mChar.actionTime = Time.time;
						if (226856 - 301221 != -74364)
						{
							this.$self_$15560.mChar.myCommand = "weedSwipe";
							if (115489 - 36929 != 78561)
							{
								this.$self_$15560.mChar.addTimeOut("nAttack", (float)3);
								if (92364 - 163364 == -71000)
								{
									this.$self_$15560.transform.position = this.$mPos$15558;
									if (227227 - 13280 != 213948)
									{
										this.$self_$15560.transform.LookAt(this.$mPos$15558 + global::Math.vFlat(this.$tDir$15559));
										if (275084 - 72732 == 202352)
										{
											this.$self_$15560.animation.CrossFade("weedSwipe");
											if (50843 - 95455 != -44611)
											{
												this.$self_$15560.animation.wrapMode = WrapMode.Once;
												if (137699 - 171903 != -34203)
												{
													this.$self_$15560.mChar.vMovement = this.$self_$15560.transform.forward;
													if (198726 - 500273 == -301547)
													{
														this.$self_$15560.mChar.moveSpeed = (float)0;
														if (264649 - 557368 != -292718)
														{
															goto Block_43;
														}
													}
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
				goto IL_A8F;
				IL_212:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_3CB:
				goto IL_ECE;
				IL_42B:
				Block_26:
				Block_30:
				goto IL_3CB;
				Block_32:
				goto IL_BB8;
				Block_39:
				goto IL_ECE;
				IL_712:
				return this.Yield(5, new WaitForSeconds(0.1f));
				Block_43:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_A09:
				IL_A8F:
				goto IL_ECE;
				Block_60:
				return this.Yield(6, new WaitForSeconds(0.3f));
				Block_62:
				goto IL_712;
				IL_BB8:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_ECE:
				return false;
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x00032384 File Offset: 0x00030584
			internal static bool BP9VaIV52gHti8Fn69d()
			{
				return true;
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x00032388 File Offset: 0x00030588
			internal static bool DXtPQPVpjVaAHsWucOf()
			{
				return false;
			}

			// Token: 0x04000226 RID: 550
			internal Transform $mArmL$15548;

			// Token: 0x04000227 RID: 551
			internal GameObject $mWeedSwipe_weed$15549;

			// Token: 0x04000228 RID: 552
			internal EffectControl $mWeedSwipe_control$15550;

			// Token: 0x04000229 RID: 553
			internal int $hitLayer$15551;

			// Token: 0x0400022A RID: 554
			internal UnityScript.Lang.Array $hitList$15552;

			// Token: 0x0400022B RID: 555
			internal Vector3 $hitPos$15553;

			// Token: 0x0400022C RID: 556
			internal GameObject $hitObject$15554;

			// Token: 0x0400022D RID: 557
			internal IEnumerator $$iterator$9898$15555;

			// Token: 0x0400022E RID: 558
			internal GameObject $hitObject$15556;

			// Token: 0x0400022F RID: 559
			internal IEnumerator $$iterator$9899$15557;

			// Token: 0x04000230 RID: 560
			internal Vector3 $mPos$15558;

			// Token: 0x04000231 RID: 561
			internal Vector3 $tDir$15559;

			// Token: 0x04000232 RID: 562
			internal FatBug $self_$15560;
		}
	}

	// Token: 0x0200005F RID: 95
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bellyBump$15564 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x0003238C File Offset: 0x0003058C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bellyBump$15564(Vector3 mPos, Vector3 tDir, FatBug self_)
		{
			if (39933 - 232931 != -192997)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25030 - 401851 == -376821)
				{
					base..ctor();
					if (71208 - 471200 == -399992)
					{
						this.$mPos$15574 = mPos;
						if (202450 - 329167 == -126717)
						{
							this.$tDir$15575 = tDir;
							if (35889 - 444029 != -408139)
							{
								this.$self_$15576 = self_;
								if (280496 - 565644 == -285148)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00032468 File Offset: 0x00030668
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FatBug.$RPC_bellyBump$15564.$(this.$mPos$15574, this.$tDir$15575, this.$self_$15576);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00032484 File Offset: 0x00030684
		internal static bool jKclxdVVkCYsgZs3471()
		{
			return true;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00032488 File Offset: 0x00030688
		internal static bool rDLafXVtd3sMJRdMMkP()
		{
			return false;
		}

		// Token: 0x04000233 RID: 563
		internal Vector3 $mPos$15574;

		// Token: 0x04000234 RID: 564
		internal Vector3 $tDir$15575;

		// Token: 0x04000235 RID: 565
		internal FatBug $self_$15576;

		// Token: 0x02000060 RID: 96
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060001F7 RID: 503 RVA: 0x0003248C File Offset: 0x0003068C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FatBug self_)
			{
				if (167077 - 429015 != -261938)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (204976 - 425964 != -220987)
					{
						base..ctor();
						if (74054 - 522925 != -448870)
						{
							this.$mPos$15571 = mPos;
							if (216662 - 32735 == 183927)
							{
								this.$tDir$15572 = tDir;
								if (20008 - 441387 != -421378)
								{
									this.$self_$15573 = self_;
									if (192098 - 88117 != 103982)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x00032568 File Offset: 0x00030768
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (132917 - 117293 != 15625)
				{
				}
				for (;;)
				{
					IL_96E:
					switch (this._state)
					{
					case 0:
						goto IL_AF8;
					case 1:
						goto IL_B87;
					case 2:
						if (this.$self_$15573.mChar.actionState != "attack")
						{
							goto IL_1A;
						}
						if (260200 - 23952 == 236249)
						{
							continue;
						}
						if (this.$self_$15573.mChar.myCommand != "bellyBump")
						{
							if (288463 - 236913 != 51550)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$self_$15573.mChar.moveSpeed = (float)10;
							if (278332 - 87554 != 190778)
							{
								continue;
							}
							goto IL_F4;
						}
						break;
					case 3:
						if (this.$self_$15573.mChar.actionState != "attack")
						{
							goto IL_9EC;
						}
						if (268674 - 69308 != 199366)
						{
							continue;
						}
						if (this.$self_$15573.mChar.myCommand != "bellyBump")
						{
							if (85276 - 324487 != -239211)
							{
								continue;
							}
							goto IL_9EC;
						}
						else
						{
							this.$hitLayer$15565 = 130816 - (1 << this.$self_$15573.gameObject.layer);
							if (176722 - 579362 == -402639)
							{
								continue;
							}
							this.$hitList$15566 = null;
							if (281671 - 25870 != 255801)
							{
								continue;
							}
							this.$hitPos$15567 = default(Vector3);
							if (8729 - 54535 == -45805)
							{
								continue;
							}
							this.$i$15568 = 0;
							if (147297 - 532313 == -385015)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$15573.mChar.actionState != "attack")
						{
							goto IL_206;
						}
						if (163569 - 476025 == -312455)
						{
							continue;
						}
						if (!(this.$self_$15573.mChar.myCommand != "bellyBump"))
						{
							goto IL_20B;
						}
						if (156049 - 410622 != -254572)
						{
							goto Block_63;
						}
						continue;
					case 5:
						if (this.$self_$15573.mChar.actionState != "attack")
						{
							goto IL_60E;
						}
						if (217374 - 244608 != -27234)
						{
							continue;
						}
						if (this.$self_$15573.mChar.myCommand != "bellyBump")
						{
							if (254277 - 337958 != -83680)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$self_$15573.mChar.moveSpeed = (float)5;
							if (238661 - 481349 != -242687)
							{
								goto Block_38;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$15573.mChar.actionState != "attack")
						{
							goto IL_8D9;
						}
						if (223248 - 128555 != 94693)
						{
							continue;
						}
						if (this.$self_$15573.mChar.myCommand != "bellyBump")
						{
							if (45332 - 345291 != -299959)
							{
								continue;
							}
							goto IL_8D9;
						}
						else
						{
							this.$self_$15573.mChar.moveSpeed = (float)0;
							if (196163 - 585104 != -388940)
							{
								goto Block_56;
							}
							continue;
						}
						break;
					case 7:
						if (this.$self_$15573.mChar.actionState == "attack")
						{
							if (123293 - 553023 != -429730)
							{
								continue;
							}
							if (this.$self_$15573.mChar.myCommand == "bellyBump")
							{
								if (237913 - 30753 == 207161)
								{
									continue;
								}
								this.$self_$15573.mChar.actionState = "standby";
								if (66957 - 498513 == -431555)
								{
									continue;
								}
								this.$self_$15573.mChar.actionTime = Time.time;
								if (286141 - 497290 == -211148)
								{
									continue;
								}
								this.$self_$15573.mChar.myCommand = "none";
								if (188428 - 115805 != 72623)
								{
									continue;
								}
								if (!this.$self_$15573.mChar.isMine)
								{
									if (164548 - 286370 != -121822)
									{
										continue;
									}
									this.$self_$15573.mChar.nPosition = this.$self_$15573.transform.position;
									if (53635 - 562589 == -508953)
									{
										continue;
									}
									this.$self_$15573.mChar.oPosition = this.$self_$15573.transform.position;
									if (165610 - 316021 != -150411)
									{
										continue;
									}
									this.$self_$15573.mChar.nDirection = this.$self_$15573.transform.forward;
									if (136577 - 246186 == -109608)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (258329 - 575256 != -316926)
						{
							goto Block_13;
						}
						continue;
					default:
						if (72596 - 108080 != -35484)
						{
							continue;
						}
						goto IL_AF8;
					}
					IL_66E:
					if (this.$i$15568 >= 2)
					{
						if (175527 - 178517 != -2990)
						{
							continue;
						}
						goto IL_4C;
					}
					else
					{
						if (this.$self_$15573.mChar.isMine)
						{
							if (101613 - 389884 != -288271)
							{
								continue;
							}
							this.$hitList$15566 = Damage.FindRecTarget(this.$self_$15573.transform.position, this.$self_$15573.transform.forward, (float)1 * this.$self_$15573.mChar.rangeMod, (float)1 * this.$self_$15573.mChar.rangeMod, (float)3 * this.$self_$15573.mChar.rangeMod, (float)2 * this.$self_$15573.mChar.rangeMod, this.$hitLayer$15565);
							if (73777 - 462022 != -388245)
							{
								continue;
							}
							this.$$iterator$9900$15570 = UnityRuntimeServices.GetEnumerator(this.$hitList$15566);
							if (14888 - 347309 != -332421)
							{
								continue;
							}
							while (this.$$iterator$9900$15570.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9900$15570.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15569 = (GameObject)obj2;
								if (113602 - 482820 == -369217)
								{
									goto IL_96E;
								}
								if (this.$self_$15573.mChar.hit(99, this.$hitObject$15569, (int)(0.4f * (float)this.$self_$15573.mChar.atk), 10, 0, this.$self_$15573.transform.forward) != 0)
								{
									if (89454 - 399118 == -309663)
									{
										goto IL_96E;
									}
									this.$hitPos$15567 = this.$hitObject$15569.collider.ClosestPointOnBounds(this.$self_$15573.transform.position + 1.5f * Vector3.up);
									if (87699 - 401645 == -313945)
									{
										goto IL_96E;
									}
									UnityRuntimeServices.Update(this.$$iterator$9900$15570, this.$hitObject$15569);
									if (273276 - 38037 == 235240)
									{
										goto IL_96E;
									}
								}
								this.$self_$15573.RPC_bellyBump_hit(this.$hitPos$15567, this.$self_$15573.transform.forward, 0);
								if (299492 - 311329 == -11836)
								{
									goto IL_96E;
								}
								this.$self_$15573.ActionEvent("RPC_bellyBump_hit", this.$hitPos$15567, this.$self_$15573.transform.forward, 0);
								if (148082 - 19412 == 128671)
								{
									goto IL_96E;
								}
							}
							if (48457 - 448494 == -400036)
							{
								continue;
							}
						}
						if (this.$i$15568 == 0)
						{
							if (176344 - 268855 != -92511)
							{
								continue;
							}
							goto IL_6CD;
						}
					}
					IL_20B:
					this.$i$15568++;
					if (130475 - 392719 != -262244)
					{
						continue;
					}
					goto IL_66E;
					IL_AF8:
					this.$self_$15573.mChar.actionState = "attack";
					if (12120 - 376040 != -363919)
					{
						this.$self_$15573.mChar.actionTime = Time.time;
						if (75153 - 574084 != -498930)
						{
							this.$self_$15573.mChar.myCommand = "bellyBump";
							if (141120 - 122254 == 18866)
							{
								this.$self_$15573.mChar.addTimeOut("nAttack", (float)3);
								if (296806 - 542744 != -245937)
								{
									this.$self_$15573.transform.position = this.$mPos$15571;
									if (29472 - 503960 == -474488)
									{
										this.$self_$15573.transform.LookAt(this.$mPos$15571 + global::Math.vFlat(this.$tDir$15572));
										if (242807 - 537044 == -294237)
										{
											this.$self_$15573.animation.CrossFade("bellyBump");
											if (219518 - 538338 != -318819)
											{
												this.$self_$15573.animation.wrapMode = WrapMode.Once;
												if (187016 - 416397 != -229380)
												{
													this.$self_$15573.mChar.vMovement = this.$self_$15573.transform.forward;
													if (244495 - 595185 == -350690)
													{
														this.$self_$15573.mChar.moveSpeed = (float)0;
														if (227796 - 12269 != 215528)
														{
															goto Block_23;
														}
													}
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
				goto IL_B87;
				IL_4C:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_F4:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_13:
				IL_206:
				goto IL_B87;
				Block_23:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_32:
				IL_60E:
				goto IL_B87;
				Block_38:
				return this.Yield(6, new WaitForSeconds(0.3f));
				IL_6CD:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_8D9:
				goto IL_B87;
				Block_56:
				return this.Yield(7, new WaitForSeconds(0.4f));
				Block_63:
				IL_9EC:
				IL_B87:
				return false;
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x00033110 File Offset: 0x00031310
			internal static bool ADeEQVVNlJ2wsrXD7KE()
			{
				return true;
			}

			// Token: 0x060001FA RID: 506 RVA: 0x00033114 File Offset: 0x00031314
			internal static bool O5XWUdVYbvareSyyHsm()
			{
				return false;
			}

			// Token: 0x04000236 RID: 566
			internal int $hitLayer$15565;

			// Token: 0x04000237 RID: 567
			internal UnityScript.Lang.Array $hitList$15566;

			// Token: 0x04000238 RID: 568
			internal Vector3 $hitPos$15567;

			// Token: 0x04000239 RID: 569
			internal int $i$15568;

			// Token: 0x0400023A RID: 570
			internal GameObject $hitObject$15569;

			// Token: 0x0400023B RID: 571
			internal IEnumerator $$iterator$9900$15570;

			// Token: 0x0400023C RID: 572
			internal Vector3 $mPos$15571;

			// Token: 0x0400023D RID: 573
			internal Vector3 $tDir$15572;

			// Token: 0x0400023E RID: 574
			internal FatBug $self_$15573;
		}
	}

	// Token: 0x02000061 RID: 97
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15577 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00033118 File Offset: 0x00031318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15577(UnityScript.Lang.Array nArray, FatBug self_)
		{
			if (279872 - 530781 != -250908)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (122628 - 74458 != 48171)
				{
					base..ctor();
					if (95374 - 67142 != 28233)
					{
						this.$nArray$15582 = nArray;
						if (83800 - 3170 != 80631)
						{
							this.$self_$15583 = self_;
							if (106959 - 22988 != 83972)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000331D4 File Offset: 0x000313D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FatBug.$RPC_ko$15577.$(this.$nArray$15582, this.$self_$15583);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000331E8 File Offset: 0x000313E8
		internal static bool e5iQToVcNZlZweekwDP()
		{
			return true;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000331EC File Offset: 0x000313EC
		internal static bool DK8oShVUencPPDO1ntx()
		{
			return false;
		}

		// Token: 0x0400023F RID: 575
		internal UnityScript.Lang.Array $nArray$15582;

		// Token: 0x04000240 RID: 576
		internal FatBug $self_$15583;

		// Token: 0x02000062 RID: 98
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060001FF RID: 511 RVA: 0x000331F0 File Offset: 0x000313F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FatBug self_)
			{
				if (137880 - 447437 != -309556)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (268571 - 493141 == -224570)
					{
						base..ctor();
						if (138860 - 527489 != -388628)
						{
							this.$nArray$15580 = nArray;
							if (114574 - 536477 != -421902)
							{
								this.$self_$15581 = self_;
								if (12250 - 157960 != -145709)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000200 RID: 512 RVA: 0x000332AC File Offset: 0x000314AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (200877 - 154909 != 45969)
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
						if (this.$self_$15581.mChar.actionState != "ko")
						{
							if (228688 - 375135 != -146446)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$self_$15581.animation.Play("getUp");
							if (281517 - 65871 != 215646)
							{
								continue;
							}
							this.$self_$15581.animation.wrapMode = WrapMode.Once;
							if (42261 - 17113 != 25148)
							{
								continue;
							}
							if (!this.$self_$15581.snarl)
							{
								goto IL_472;
							}
							if (141133 - 515801 != -374668)
							{
								continue;
							}
							this.$self_$15581.audio.PlayOneShot(this.$self_$15581.snarl);
							if (41978 - 81578 != -39600)
							{
								continue;
							}
							goto IL_472;
						}
						break;
					case 3:
						if (this.$self_$15581.mChar.actionState != "ko")
						{
							if (162500 - 137183 != 25318)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$self_$15581.mChar.actionState = "standby";
							if (198687 - 276738 == -78050)
							{
								continue;
							}
							this.$self_$15581.mChar.actionTime = Time.time;
							if (34953 - 498125 == -463171)
							{
								continue;
							}
							this.$self_$15581.mChar.myCommand = "none";
							if (286702 - 280715 == 5988)
							{
								continue;
							}
							this.$self_$15581.mChar.ko = this.$self_$15581.mChar.mko;
							if (161098 - 160281 != 817)
							{
								continue;
							}
							this.YieldDefault(1);
							if (52870 - 242499 != -189628)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					default:
						if (60813 - 475819 != -415006)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15581.mChar.actionState == "ko")
					{
						break;
					}
					if (218047 - 377189 != -159141)
					{
						if (this.$self_$15581.mChar.actionState == "dead")
						{
							if (4249 - 116541 != -112291)
							{
								break;
							}
						}
						else
						{
							this.$mPos$15578 = (Vector3)this.$nArray$15580[0];
							if (204844 - 407938 == -203094)
							{
								this.$mDir$15579 = (Vector3)this.$nArray$15580[1];
								if (219859 - 267470 != -47610)
								{
									this.$self_$15581.mChar.ko = 0;
									if (258221 - 302543 == -44322)
									{
										this.$self_$15581.mChar.actionState = "ko";
										if (21631 - 10427 != 11205)
										{
											this.$self_$15581.mChar.actionTime = Time.time;
											if (7355 - 433448 != -426092)
											{
												this.$self_$15581.mChar.myCommand = "none";
												if (188203 - 342440 != -154236)
												{
													this.$self_$15581.mChar.vMovement = Vector3.zero;
													if (114031 - 34502 == 79529)
													{
														this.$self_$15581.mChar.moveSpeed = (float)0;
														if (61046 - 91282 != -30235)
														{
															this.$self_$15581.animation.Play("ko");
															if (7105 - 331374 == -324269)
															{
																this.$self_$15581.animation.wrapMode = WrapMode.Once;
																if (1374 - 317464 != -316089)
																{
																	goto Block_22;
																}
															}
														}
													}
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
				Block_11:
				IL_27E:
				goto IL_4F0;
				Block_22:
				return this.Yield(2, new WaitForSeconds(3f));
				goto IL_27E;
				IL_472:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_30:
				IL_4F0:
				return false;
			}

			// Token: 0x06000201 RID: 513 RVA: 0x000337BC File Offset: 0x000319BC
			internal static bool lrLYf5VTnF73rUYs8lR()
			{
				return true;
			}

			// Token: 0x06000202 RID: 514 RVA: 0x000337C0 File Offset: 0x000319C0
			internal static bool xj67yYV3vlr0KMqSfME()
			{
				return false;
			}

			// Token: 0x04000241 RID: 577
			internal Vector3 $mPos$15578;

			// Token: 0x04000242 RID: 578
			internal Vector3 $mDir$15579;

			// Token: 0x04000243 RID: 579
			internal UnityScript.Lang.Array $nArray$15580;

			// Token: 0x04000244 RID: 580
			internal FatBug $self_$15581;
		}
	}

	// Token: 0x02000063 RID: 99
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15584 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000203 RID: 515 RVA: 0x000337C4 File Offset: 0x000319C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15584(UnityScript.Lang.Array nArray, FatBug self_)
		{
			if (119618 - 485314 != -365695)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (16800 - 567061 != -550260)
				{
					base..ctor();
					if (164961 - 118569 == 46392)
					{
						this.$nArray$15589 = nArray;
						if (284012 - 220177 != 63836)
						{
							this.$self_$15590 = self_;
							if (169551 - 434060 == -264509)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00033880 File Offset: 0x00031A80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FatBug.$RPC_dead$15584.$(this.$nArray$15589, this.$self_$15590);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00033894 File Offset: 0x00031A94
		internal static bool DNXWXfVXrgDUxIKR8sk()
		{
			return true;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00033898 File Offset: 0x00031A98
		internal static bool YlGdjaVQWbQwu5csLRP()
		{
			return false;
		}

		// Token: 0x04000245 RID: 581
		internal UnityScript.Lang.Array $nArray$15589;

		// Token: 0x04000246 RID: 582
		internal FatBug $self_$15590;

		// Token: 0x02000064 RID: 100
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000207 RID: 519 RVA: 0x0003389C File Offset: 0x00031A9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FatBug self_)
			{
				if (130581 - 92563 != 38018)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (123448 - 244101 != -120652)
					{
						base..ctor();
						if (178992 - 183169 == -4177)
						{
							this.$nArray$15587 = nArray;
							if (160040 - 590444 != -430403)
							{
								this.$self_$15588 = self_;
								if (86567 - 174582 == -88015)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000208 RID: 520 RVA: 0x00033958 File Offset: 0x00031B58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208795 - 438731 != -229936)
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
						if (this.$self_$15588.mChar.actionState != "dead")
						{
							if (215417 - 295657 != -80240)
							{
								continue;
							}
							goto IL_97;
						}
						else
						{
							if (!this.$self_$15588.mChar.isPlayer)
							{
								if (202956 - 334662 != -131706)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$15588.gameObject);
								if (105877 - 267830 != -161953)
								{
									continue;
								}
							}
							else if (this.$self_$15588.mChar.isMine)
							{
								if (100145 - 462458 != -362313)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15588.gameObject);
								if (194080 - 210307 != -16227)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (46561 - 247613 != -201051)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					default:
						if (237965 - 59747 != 178218)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15588.mChar.actionState == "dead")
					{
						if (8467 - 183352 != -174884)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$15585 = (Vector3)this.$nArray$15587[0];
						if (72658 - 574953 == -502295)
						{
							this.$myDirection$15586 = (Vector3)this.$nArray$15587[1];
							if (169524 - 404719 != -235194)
							{
								this.$self_$15588.transform.position = this.$myPosition$15585;
								if (110944 - 315788 == -204844)
								{
									this.$self_$15588.transform.LookAt(this.$myPosition$15585 + this.$myDirection$15586);
									if (100160 - 245991 != -145830)
									{
										this.$self_$15588.mChar.hp = 0;
										if (283248 - 242739 != 40510)
										{
											this.$self_$15588.mChar.actionState = "dead";
											if (193284 - 562764 == -369480)
											{
												this.$self_$15588.mChar.actionTime = Time.time;
												if (282937 - 95672 != 187266)
												{
													this.$self_$15588.mChar.myCommand = "none";
													if (208467 - 462089 != -253621)
													{
														this.$self_$15588.mChar.vMovement = Vector3.zero;
														if (136695 - 542951 != -406255)
														{
															this.$self_$15588.mChar.moveSpeed = (float)0;
															if (232644 - 371184 != -138539)
															{
																this.$self_$15588.animation.Rewind();
																if (35866 - 578518 != -542651)
																{
																	this.$self_$15588.animation.Play("ko");
																	if (193858 - 230407 == -36549)
																	{
																		this.$self_$15588.animation.wrapMode = WrapMode.Once;
																		if (83531 - 310823 != -227291)
																		{
																			if (!this.$self_$15588.snarl)
																			{
																				goto IL_3AD;
																			}
																			if (132961 - 19259 == 113702)
																			{
																				this.$self_$15588.audio.PlayOneShot(this.$self_$15588.snarl);
																				if (255772 - 11580 != 244193)
																				{
																					goto Block_22;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
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
				IL_97:
				goto IL_493;
				Block_22:
				IL_3AD:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_493:
				return false;
			}

			// Token: 0x06000209 RID: 521 RVA: 0x00033E0C File Offset: 0x0003200C
			internal static bool TwFE7GVk5GmutTAaQJr()
			{
				return true;
			}

			// Token: 0x0600020A RID: 522 RVA: 0x00033E10 File Offset: 0x00032010
			internal static bool scuG6DVGbcersV2u7wB()
			{
				return false;
			}

			// Token: 0x04000247 RID: 583
			internal Vector3 $myPosition$15585;

			// Token: 0x04000248 RID: 584
			internal Vector3 $myDirection$15586;

			// Token: 0x04000249 RID: 585
			internal UnityScript.Lang.Array $nArray$15587;

			// Token: 0x0400024A RID: 586
			internal FatBug $self_$15588;
		}
	}
}
