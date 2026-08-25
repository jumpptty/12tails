using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000302 RID: 770
[Serializable]
public class IceGuardian : MonoBehaviour
{
	// Token: 0x0600117B RID: 4475 RVA: 0x001BA4D0 File Offset: 0x001B86D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IceGuardian()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x001BA4E0 File Offset: 0x001B86E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (115927 - 583987 != -468059)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (67606 - 149933 != -82326)
			{
				this.mChar.actionState = "standby";
				if (153923 - 142945 == 10978)
				{
					this.mChar.actionTime = Time.time;
					if (197324 - 532083 == -334759)
					{
						this.mChar.myCommand = "none";
						if (87368 - 571278 != -483909)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
							{
								"ice",
								"frost",
								"snowMan",
								"snowBall"
							});
							if (12428 - 112098 != -99669)
							{
								this.mChar.hp = (this.mChar.mhp = 14500);
								if (73030 - 553996 != -480965)
								{
									this.mChar.ko = (this.mChar.mko = 10);
									if (292269 - 175414 != 116856)
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

	// Token: 0x0600117D RID: 4477 RVA: 0x001BA688 File Offset: 0x001B8888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x001BA6A4 File Offset: 0x001B88A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (129803 - 329359 != -199556)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (214531 - 585067 == -370535)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (127263 - 194622 == -67358)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_82;
					}
					if (134920 - 501872 != -366952)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (157181 - 584888 != -427707)
				{
					continue;
				}
			}
			IL_82:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (200060 - 102740 != 97321)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (189605 - 424746 == -235141)
				{
					if (this.mChar.isMine)
					{
						if (205145 - 188350 != 16796)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (70174 - 529554 != -459379)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (233023 - 570707 != -337683)
								{
									this.mChar.DeadEvent();
									if (76210 - 150803 == -74593)
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
						if (291480 - 586210 == -294730)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x001BA8E4 File Offset: 0x001B8AE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (139383 - 171380 != -31996)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (145021 - 327830 == -182809)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (134391 - 27716 != 106676 && 102386 - 202983 != -100596)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (277598 - 184815 != 92783)
						{
							continue;
						}
						v = 1;
						if (128137 - 339029 != -210892)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (41658 - 567101 == -525442)
						{
							continue;
						}
						v = -1;
						if (178705 - 506544 == -327838)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (180716 - 574660 != -393944)
						{
							continue;
						}
						v = 11;
						if (85806 - 232988 == -147181)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack_hit")
					{
						if (47419 - 388356 == -340936)
						{
							continue;
						}
						v = -11;
						if (272284 - 276630 != -4346)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_dispell")
					{
						if (23957 - 128556 == -104598)
						{
							continue;
						}
						v = 21;
						if (118403 - 594165 == -475761)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_iceStream")
					{
						if (221916 - 349160 == -127243)
						{
							continue;
						}
						v = 31;
						if (221012 - 571576 == -350563)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_blizzard")
					{
						if (150681 - 587930 != -437249)
						{
							continue;
						}
						v = 41;
						if (102668 - 264781 != -162113)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_blizzard_fire")
					{
						if (151294 - 125226 == 26069)
						{
							continue;
						}
						v = 42;
						if (39256 - 277973 != -238717)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (262642 - 144109 == 118534)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (233535 - 524597 == -291062)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (102895 - 499344 != -396448)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (69594 - 8857 == 60737)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (246361 - 564832 == -318471)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (826 - 2780 == -1954)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (160429 - 104969 != 55461)
										{
											Hashtable hashtable = new Hashtable();
											if (154701 - 145687 != 9015)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (153849 - 72520 != 81330)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (271571 - 81249 != 190323)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (125784 - 225362 == -99578)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (15009 - 503715 != -488705)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (124355 - 41830 == 82525)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (85894 - 481107 == -395213)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (81760 - 192938 != -111177)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (145861 - 73308 == 72553)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (152679 - 152770 == -91)
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

	// Token: 0x06001180 RID: 4480 RVA: 0x001BAF2C File Offset: 0x001B912C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (186194 - 216454 != -30259)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (77805 - 472823 == -395018)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (64867 - 195855 != -130987)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (106962 - 432234 != -325271)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (23366 - 284647 != -261280)
						{
							int num3 = num;
							if (73748 - 410869 == -337121)
							{
								if (num3 == 1)
								{
									if (198602 - 534022 != -335419)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (18194 - 257057 != -238862)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (252552 - 553688 != -301135)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (27491 - 506725 == -479234)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (3815 - 432152 == -428337)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (201233 - 388945 == -187712)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (211839 - 523231 != -311391)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (138995 - 548722 == -409727)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (165601 - 88120 == 77481)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (204505 - 377074 != -172568)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (128619 - 497889 != -369269)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (252181 - 414943 != -162761)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (94453 - 20135 != 74319)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (11536 - 347982 == -336446)
										{
											this.StartCoroutine_Auto(this.RPC_dispell(vector, vector2, num2));
											if (117524 - 407172 != -289647)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (10151 - 79076 == -68925)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (39307 - 238055 != -198747)
										{
											this.StartCoroutine_Auto(this.RPC_iceStream(vector, vector2, num2));
											if (109495 - 98545 == 10950)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (137768 - 198486 == -60718)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (227170 - 125634 != 101537)
										{
											this.StartCoroutine_Auto(this.RPC_blizzard(vector, vector2, num2));
											if (133471 - 228828 == -95357)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 52)
								{
									if (116611 - 132450 == -15839)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (1164 - 271842 != -270677)
										{
											this.StartCoroutine_Auto(this.RPC_blizzard_fire(vector, vector2, num2));
											if (3955 - 565429 != -561473)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (47811 - 100820 != -53008)
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

	// Token: 0x06001181 RID: 4481 RVA: 0x001BB4A0 File Offset: 0x001B96A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (73128 - 70259 != 2869)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (189836 - 392887 == -203051)
			{
				float runSpeed = this.mChar.runSpeed;
				if (34338 - 183644 != -149305)
				{
					Vector3 a = default(Vector3);
					if (25671 - 233061 == -207390)
					{
						Vector3 vector = Vector3.zero;
						if (181425 - 416552 == -235127)
						{
							float num2 = (float)0;
							if (20237 - 31507 != -11269)
							{
								if (this.mChar.isMine)
								{
									if (233835 - 596665 == -362829)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (80344 - 492252 == -411907)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (250475 - 554874 != -304399)
										{
											continue;
										}
										a.y = (float)0;
										if (172843 - 409928 == -237084)
										{
											continue;
										}
										a = a.normalized;
										if (198450 - 470063 != -271613)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (232261 - 410119 == -177857)
										{
											continue;
										}
										vector = vector.normalized;
										if (256518 - 334190 == -77671)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (193442 - 197390 != -3948)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (112820 - 200560 == -87739)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (60032 - 233420 != -173388)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (45482 - 461696 != -416214)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (154122 - 508006 == -353883)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (9966 - 411741 != -401775)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (9705 - 22465 != -12760)
														{
															continue;
														}
														this.animation.Play("run");
														if (292625 - 413650 != -121025)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (103023 - 19533 != 83491)
														{
															goto IL_AD;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (245266 - 473310 == -228043)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (253043 - 215838 == 37206)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (182424 - 143502 == 38923)
											{
												continue;
											}
											num = (float)0;
											if (15032 - 483502 != -468470)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (170308 - 6853 == 163456)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (2216 - 121032 != -118816)
										{
											continue;
										}
									}
									IL_AD:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (232333 - 539133 == -306799)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (47946 - 595640 != -547694)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (231479 - 442154 == -210674)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (45261 - 524734 == -479472)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (277719 - 115361 == 162359)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (57864 - 137531 != -79667)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (207726 - 311159 != -103433)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (261242 - 288138 != -26896)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (270743 - 189002 != 81741)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (167006 - 108952 != 58054)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (73347 - 394235 == -320887)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (207654 - 132337 == 75318)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (226704 - 543638 == -316933)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (274789 - 322143 == -47353)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (139552 - 285853 != -146301)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (4396 - 511570 == -507173)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (281441 - 564539 == -283097)
												{
													continue;
												}
												num = (float)0;
												if (216850 - 18413 == 198438)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (205025 - 169536 == 35490)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (132603 - 291853 != -159250)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (282975 - 442369 != -159394)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (202334 - 350982 != -148648)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (204006 - 165792 != 38214)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (177354 - 352372 != -175018)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (210764 - 357002 == -146237)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (56207 - 183461 != -127254)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (6538 - 373210 == -366671)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (173346 - 126282 != 47064)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (261255 - 107310 == 153946)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (49980 - 273816 == -223835)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (34483 - 11951 == 22533)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (176424 - 533161 != -356737)
											{
												continue;
											}
											num = (float)0;
											if (151241 - 272113 == -120871)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (158305 - 294924 == -136618)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (98005 - 242346 != -144341)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (231017 - 362493 != -131476)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (295447 - 103962 != 191485)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (137361 - 238123 == -100762)
								{
									this.mChar.moveSpeed = num;
									if (96919 - 373138 == -276219)
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

	// Token: 0x06001182 RID: 4482 RVA: 0x001BC004 File Offset: 0x001BA204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (76836 - 234782 != -157945)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (256286 - 44043 != 212244)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (116178 - 103557 != 12622)
				{
					Vector3 vector = a - this.transform.position;
					if (68632 - 161349 != -92716)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (37015 - 404603 != -367587)
						{
							CharacterControl characterControl = null;
							if (172825 - 143349 != 29477)
							{
								int tID = 0;
								if (143058 - 135206 == 7852)
								{
									if (gameObject)
									{
										if (246201 - 124261 == 121941)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (154786 - 549569 != -394783)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (133882 - 211627 != -77745)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (163642 - 37211 == 126432)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (233167 - 256054 == -22886)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (114190 - 239028 == -124837)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (150801 - 252123 == -101322)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (37340 - 541978 == -504638)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (126656 - 362729 != -236072)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
												if (10271 - 454174 == -443903)
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

	// Token: 0x06001183 RID: 4483 RVA: 0x001BC300 File Offset: 0x001BA500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (93009 - 382929 != -289920)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (100327 - 550928 == -450601)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (40893 - 338522 != -297628)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (76708 - 176494 == -99786)
					{
						Vector3 normalized = vector.normalized;
						if (200471 - 156001 == 44470)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (106941 - 294679 != -187737)
							{
								CharacterControl characterControl = null;
								if (87409 - 66833 != 20577)
								{
									if (20202 - 557164 == -536962)
									{
										if (gameObject)
										{
											if (143850 - 300780 != -156930)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (111146 - 79228 != 31918)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (232415 - 211394 == 21022)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (62732 - 254130 == -191397)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (22853 - 240575 != -217722)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (29673 - 22211 == 7463)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") == (float)0)
										{
											if (146362 - 577940 != -431577)
											{
												this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, this.transform.forward, 0));
												if (144563 - 107478 != 37086)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (278444 - 274866 != 3579)
													{
														this.ActionEvent("RPC_cAttack", this.transform.position, this.transform.forward, 0);
														if (154578 - 428250 == -273672)
														{
															break;
														}
													}
												}
											}
										}
										else if (this.mChar.isTimeOut("dispell") == (float)0)
										{
											if (273224 - 102526 == 170698)
											{
												this.StartCoroutine_Auto(this.RPC_dispell(this.transform.position, this.transform.forward, 0));
												if (137440 - 402253 != -264812)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (168299 - 435468 != -267168)
													{
														this.ActionEvent("RPC_dispell", this.transform.position, this.transform.forward, 0);
														if (221637 - 523889 != -302251)
														{
															break;
														}
													}
												}
											}
										}
										else if (this.mChar.isTimeOut("iceStream") == (float)0)
										{
											if (203247 - 69969 != 133279)
											{
												this.StartCoroutine_Auto(this.RPC_iceStream(this.transform.position, this.transform.forward, 0));
												if (29539 - 123203 == -93664)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (132826 - 485008 == -352182)
													{
														this.ActionEvent("RPC_iceStream", this.transform.position, this.transform.forward, 0);
														if (11491 - 435989 != -424497)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											if (this.mChar.isTimeOut("blizzard") != (float)0)
											{
												break;
											}
											if (170189 - 550631 != -380441)
											{
												this.StartCoroutine_Auto(this.RPC_blizzard(this.transform.position, this.transform.forward, 0));
												if (202409 - 560130 != -357720)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (226383 - 386072 != -159688)
													{
														this.ActionEvent("RPC_blizzard", this.transform.position, this.transform.forward, 0);
														if (80893 - 572844 == -491951)
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

	// Token: 0x06001184 RID: 4484 RVA: 0x001BC8B0 File Offset: 0x001BAAB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x001BC8B4 File Offset: 0x001BAAB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGuardian.$RPC_nAttack$18289(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x001BC8C4 File Offset: 0x001BAAC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x001BC8F0 File Offset: 0x001BAAF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGuardian.$RPC_cAttack$18301(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x001BC900 File Offset: 0x001BAB00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.cAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x001BC92C File Offset: 0x001BAB2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dispell(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGuardian.$RPC_dispell$18314(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x001BC93C File Offset: 0x001BAB3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_iceStream(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGuardian.$RPC_iceStream$18326(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x001BC94C File Offset: 0x001BAB4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_blizzard(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGuardian.$RPC_blizzard$18339(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x001BC95C File Offset: 0x001BAB5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_blizzard_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGuardian.$RPC_blizzard_fire$18348(this).GetEnumerator();
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x001BC96C File Offset: 0x001BAB6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new IceGuardian.$RPC_dead$18358(nArray, this).GetEnumerator();
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x001BC97C File Offset: 0x001BAB7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x001BC980 File Offset: 0x001BAB80
	internal static bool oNAKxA8IeA1AD91we1Y()
	{
		return true;
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x001BC984 File Offset: 0x001BAB84
	internal static bool zGNkq48BZSueR5GnVTv()
	{
		return false;
	}

	// Token: 0x04000F50 RID: 3920
	public CharacterControl mChar;

	// Token: 0x04000F51 RID: 3921
	public AudioClip iceGuadian_cryFx;

	// Token: 0x04000F52 RID: 3922
	public GameObject nAttack_hit;

	// Token: 0x04000F53 RID: 3923
	public GameObject cAttack_ring;

	// Token: 0x04000F54 RID: 3924
	public GameObject cAttack_hit;

	// Token: 0x04000F55 RID: 3925
	public GameObject dispell_ring;

	// Token: 0x04000F56 RID: 3926
	public GameObject castRing;

	// Token: 0x04000F57 RID: 3927
	public GameObject iceStream;

	// Token: 0x04000F58 RID: 3928
	public GameObject bigCastRing;

	// Token: 0x04000F59 RID: 3929
	public GameObject blizzard;

	// Token: 0x04000F5A RID: 3930
	public GameObject deadEffect;

	// Token: 0x02000303 RID: 771
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$18289 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001191 RID: 4497 RVA: 0x001BC988 File Offset: 0x001BAB88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$18289(Vector3 mPos, Vector3 tDir, IceGuardian self_)
		{
			if (143883 - 214297 != -70414)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276597 - 397993 != -121395)
				{
					base..ctor();
					if (242900 - 70813 == 172087)
					{
						this.$mPos$18298 = mPos;
						if (100689 - 396522 == -295833)
						{
							this.$tDir$18299 = tDir;
							if (159297 - 331980 != -172682)
							{
								this.$self_$18300 = self_;
								if (124780 - 349024 != -224243)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x001BCA64 File Offset: 0x001BAC64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGuardian.$RPC_nAttack$18289.$(this.$mPos$18298, this.$tDir$18299, this.$self_$18300);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x001BCA80 File Offset: 0x001BAC80
		internal static bool O0bOE58eZ8sZqbpiOXl()
		{
			return true;
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x001BCA84 File Offset: 0x001BAC84
		internal static bool cuB7qG8rfIp3Far20od()
		{
			return false;
		}

		// Token: 0x04000F5B RID: 3931
		internal Vector3 $mPos$18298;

		// Token: 0x04000F5C RID: 3932
		internal Vector3 $tDir$18299;

		// Token: 0x04000F5D RID: 3933
		internal IceGuardian $self_$18300;

		// Token: 0x02000304 RID: 772
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001195 RID: 4501 RVA: 0x001BCA88 File Offset: 0x001BAC88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IceGuardian self_)
			{
				if (134719 - 542883 != -408163)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (172411 - 184025 != -11613)
					{
						base..ctor();
						if (214704 - 515125 == -300421)
						{
							this.$mPos$18295 = mPos;
							if (21442 - 43036 == -21594)
							{
								this.$tDir$18296 = tDir;
								if (205568 - 520508 == -314940)
								{
									this.$self_$18297 = self_;
									if (193123 - 194690 != -1566)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001196 RID: 4502 RVA: 0x001BCB64 File Offset: 0x001BAD64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (264826 - 311977 != -47151)
				{
				}
				for (;;)
				{
					IL_2EC:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_805;
					case 2:
						if (this.$self_$18297.mChar.actionState != "attack")
						{
							goto IL_5D1;
						}
						if (113918 - 238621 != -124703)
						{
							continue;
						}
						if (this.$self_$18297.mChar.myCommand != "nAttack")
						{
							if (135561 - 443535 != -307973)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18297.mChar.isMine)
							{
								goto IL_6B2;
							}
							if (111353 - 158254 != -46901)
							{
								continue;
							}
							this.$hitLayer$18290 = 130816 - (1 << this.$self_$18297.gameObject.layer);
							if (50021 - 209832 == -159810)
							{
								continue;
							}
							this.$hitList$18291 = Damage.FindAreaTarget(this.$self_$18297.transform.position + this.$self_$18297.transform.forward, (float)2, (float)3, this.$hitLayer$18290);
							if (199686 - 588048 == -388361)
							{
								continue;
							}
							this.$$iterator$10462$18294 = UnityRuntimeServices.GetEnumerator(this.$hitList$18291);
							if (55959 - 422382 != -366423)
							{
								continue;
							}
							while (this.$$iterator$10462$18294.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10462$18294.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18292 = (GameObject)obj2;
								if (139822 - 211806 == -71983)
								{
									goto IL_2EC;
								}
								if (this.$self_$18297.mChar.hit(1, this.$hitObject$18292, this.$self_$18297.mChar.atk, 20, 0, Vector3.zero) != 0)
								{
									if (73227 - 484040 == -410812)
									{
										goto IL_2EC;
									}
									this.$hitPos$18293 = this.$hitObject$18292.collider.ClosestPointOnBounds(this.$self_$18297.transform.position + Vector3.up);
									if (48156 - 565823 == -517666)
									{
										goto IL_2EC;
									}
									UnityRuntimeServices.Update(this.$$iterator$10462$18294, this.$hitObject$18292);
									if (66297 - 407836 == -341538)
									{
										goto IL_2EC;
									}
									this.$self_$18297.RPC_nAttack_hit(this.$hitPos$18293, this.$self_$18297.transform.forward, 0);
									if (159992 - 89246 == 70747)
									{
										goto IL_2EC;
									}
									if (PhotonClient.IsInitialized())
									{
										if (154567 - 145031 != 9536)
										{
											goto IL_2EC;
										}
										this.$self_$18297.ActionEvent("RPC_nAttack_hit", this.$hitPos$18293, this.$self_$18297.transform.forward, 0);
										if (271371 - 175626 != 95745)
										{
											goto IL_2EC;
										}
									}
								}
							}
							if (286474 - 368312 != -81837)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18297.mChar.actionState == "attack")
						{
							if (182464 - 463244 != -280780)
							{
								continue;
							}
							if (this.$self_$18297.mChar.myCommand == "nAttack")
							{
								if (34301 - 58560 == -24258)
								{
									continue;
								}
								this.$self_$18297.mChar.actionState = "standby";
								if (51641 - 65566 != -13925)
								{
									continue;
								}
								this.$self_$18297.mChar.actionTime = Time.time;
								if (159726 - 106056 != 53670)
								{
									continue;
								}
								this.$self_$18297.mChar.myCommand = "none";
								if (227305 - 108784 != 118521)
								{
									continue;
								}
								if (!this.$self_$18297.mChar.isMine)
								{
									if (41044 - 223682 == -182637)
									{
										continue;
									}
									this.$self_$18297.mChar.nPosition = this.$self_$18297.transform.position;
									if (65031 - 92311 == -27279)
									{
										continue;
									}
									this.$self_$18297.mChar.oPosition = this.$self_$18297.transform.position;
									if (25987 - 494757 != -468770)
									{
										continue;
									}
									this.$self_$18297.mChar.nDirection = this.$self_$18297.transform.forward;
									if (5501 - 286907 != -281406)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (117592 - 558741 != -441148)
						{
							goto Block_12;
						}
						continue;
					default:
						if (77506 - 158718 != -81212)
						{
							continue;
						}
						break;
					}
					this.$self_$18297.mChar.actionState = "attack";
					if (203279 - 568868 != -365588)
					{
						this.$self_$18297.mChar.actionTime = Time.time;
						if (27908 - 5306 != 22603)
						{
							this.$self_$18297.mChar.myCommand = "nAttack";
							if (107257 - 475069 != -367811)
							{
								this.$self_$18297.mChar.addTimeOut("nAttack", (float)2);
								if (234922 - 386710 == -151788)
								{
									this.$self_$18297.transform.position = this.$mPos$18295;
									if (143613 - 33720 == 109893)
									{
										this.$self_$18297.transform.LookAt(this.$mPos$18295 + global::Math.vFlat(this.$tDir$18296));
										if (52365 - 115416 != -63050)
										{
											this.$self_$18297.animation.CrossFade("nAttack");
											if (31252 - 174226 != -142973)
											{
												this.$self_$18297.animation.wrapMode = WrapMode.Once;
												if (171374 - 487585 == -316211)
												{
													this.$self_$18297.mChar.vMovement = this.$self_$18297.transform.forward;
													if (259949 - 386494 != -126544)
													{
														this.$self_$18297.mChar.moveSpeed = (float)0;
														if (139157 - 140735 != -1577)
														{
															if (!this.$self_$18297.iceGuadian_cryFx)
															{
																goto IL_14B;
															}
															if (111275 - 494298 == -383023)
															{
																this.$self_$18297.audio.PlayOneShot(this.$self_$18297.iceGuadian_cryFx);
																if (239034 - 113775 == 125259)
																{
																	goto IL_14B;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_5D1;
				IL_14B:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_12:
				goto IL_805;
				Block_35:
				goto IL_6B2;
				IL_5D1:
				goto IL_805;
				IL_6B2:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_805:
				return false;
			}

			// Token: 0x06001197 RID: 4503 RVA: 0x001BD388 File Offset: 0x001BB588
			internal static bool C5XEBq8jTwP7MLlVvjU()
			{
				return true;
			}

			// Token: 0x06001198 RID: 4504 RVA: 0x001BD38C File Offset: 0x001BB58C
			internal static bool MuulJd8hxNB30QpACsK()
			{
				return false;
			}

			// Token: 0x04000F5E RID: 3934
			internal int $hitLayer$18290;

			// Token: 0x04000F5F RID: 3935
			internal UnityScript.Lang.Array $hitList$18291;

			// Token: 0x04000F60 RID: 3936
			internal GameObject $hitObject$18292;

			// Token: 0x04000F61 RID: 3937
			internal Vector3 $hitPos$18293;

			// Token: 0x04000F62 RID: 3938
			internal IEnumerator $$iterator$10462$18294;

			// Token: 0x04000F63 RID: 3939
			internal Vector3 $mPos$18295;

			// Token: 0x04000F64 RID: 3940
			internal Vector3 $tDir$18296;

			// Token: 0x04000F65 RID: 3941
			internal IceGuardian $self_$18297;
		}
	}

	// Token: 0x02000305 RID: 773
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$18301 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001199 RID: 4505 RVA: 0x001BD390 File Offset: 0x001BB590
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$18301(Vector3 mPos, Vector3 tDir, IceGuardian self_)
		{
			if (167375 - 559544 != -392169)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (46470 - 128758 != -82287)
				{
					base..ctor();
					if (240807 - 505508 != -264700)
					{
						this.$mPos$18311 = mPos;
						if (148948 - 213644 == -64696)
						{
							this.$tDir$18312 = tDir;
							if (74781 - 344650 == -269869)
							{
								this.$self_$18313 = self_;
								if (132445 - 487185 == -354740)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x001BD46C File Offset: 0x001BB66C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGuardian.$RPC_cAttack$18301.$(this.$mPos$18311, this.$tDir$18312, this.$self_$18313);
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x001BD488 File Offset: 0x001BB688
		internal static bool aA1pFy8s8q0sSC1iKar()
		{
			return true;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x001BD48C File Offset: 0x001BB68C
		internal static bool JNfTUI89YA6DJ9w9kCv()
		{
			return false;
		}

		// Token: 0x04000F66 RID: 3942
		internal Vector3 $mPos$18311;

		// Token: 0x04000F67 RID: 3943
		internal Vector3 $tDir$18312;

		// Token: 0x04000F68 RID: 3944
		internal IceGuardian $self_$18313;

		// Token: 0x02000306 RID: 774
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600119D RID: 4509 RVA: 0x001BD490 File Offset: 0x001BB690
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IceGuardian self_)
			{
				if (57462 - 385566 != -328104)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (187520 - 505923 == -318403)
					{
						base..ctor();
						if (260330 - 213803 != 46528)
						{
							this.$mPos$18308 = mPos;
							if (140335 - 356430 != -216094)
							{
								this.$tDir$18309 = tDir;
								if (223522 - 482461 != -258938)
								{
									this.$self_$18310 = self_;
									if (65484 - 225085 == -159601)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600119E RID: 4510 RVA: 0x001BD56C File Offset: 0x001BB76C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68522 - 197966 != -129443)
				{
				}
				for (;;)
				{
					IL_444:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B13;
					case 2:
						if (this.$self_$18310.mChar.actionState != "attack")
						{
							goto IL_833;
						}
						if (143340 - 231805 == -88464)
						{
							continue;
						}
						if (this.$self_$18310.mChar.myCommand != "cAttack")
						{
							if (236086 - 136057 != 100030)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$self_$18310.mChar.moveSpeed = (float)12;
							if (75022 - 90534 != -15511)
							{
								goto Block_52;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18310.mChar.actionState != "attack")
						{
							goto IL_485;
						}
						if (275064 - 328686 == -53621)
						{
							continue;
						}
						if (this.$self_$18310.mChar.myCommand != "cAttack")
						{
							if (261328 - 566602 != -305274)
							{
								continue;
							}
							goto IL_485;
						}
						else
						{
							if (this.$self_$18310.cAttack_ring)
							{
								if (198546 - 278677 != -80131)
								{
									continue;
								}
								this.$self_$18310.mChar.createEffect(this.$self_$18310.cAttack_ring, this.$self_$18310.transform.position, this.$self_$18310.transform.rotation);
								if (260870 - 72967 != 187903)
								{
									continue;
								}
							}
							this.$self_$18310.mChar.moveSpeed = (float)8;
							if (131916 - 183552 != -51635)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$18310.mChar.actionState != "attack")
						{
							goto IL_583;
						}
						if (61090 - 472239 == -411148)
						{
							continue;
						}
						if (this.$self_$18310.mChar.myCommand != "cAttack")
						{
							if (103806 - 242543 != -138736)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$i$18302 = 0;
							if (184157 - 232527 != -48369)
							{
								goto IL_727;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$18310.mChar.actionState != "attack")
						{
							goto IL_4B9;
						}
						if (146024 - 449130 == -303105)
						{
							continue;
						}
						if (this.$self_$18310.mChar.myCommand != "cAttack")
						{
							if (288790 - 203860 != 84931)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$i$18302++;
							if (193033 - 98174 != 94859)
							{
								continue;
							}
							goto IL_727;
						}
						break;
					case 6:
						if (this.$self_$18310.mChar.actionState == "attack")
						{
							if (279155 - 538008 != -258853)
							{
								continue;
							}
							if (this.$self_$18310.mChar.myCommand == "cAttack")
							{
								if (124372 - 113509 == 10864)
								{
									continue;
								}
								this.$self_$18310.mChar.actionState = "standby";
								if (198719 - 486113 != -287394)
								{
									continue;
								}
								this.$self_$18310.mChar.actionTime = Time.time;
								if (97616 - 257507 != -159891)
								{
									continue;
								}
								this.$self_$18310.mChar.myCommand = "none";
								if (175115 - 381566 != -206451)
								{
									continue;
								}
								if (!this.$self_$18310.mChar.isMine)
								{
									if (104396 - 435249 == -330852)
									{
										continue;
									}
									this.$self_$18310.mChar.nPosition = this.$self_$18310.transform.position;
									if (169980 - 235969 == -65988)
									{
										continue;
									}
									this.$self_$18310.mChar.oPosition = this.$self_$18310.transform.position;
									if (227361 - 123163 == 104199)
									{
										continue;
									}
									this.$self_$18310.mChar.nDirection = this.$self_$18310.transform.forward;
									if (248628 - 22067 == 226562)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (100030 - 480280 != -380249)
						{
							goto Block_35;
						}
						continue;
					default:
						if (223038 - 157184 == 65855)
						{
							continue;
						}
						break;
					}
					this.$self_$18310.mChar.actionState = "attack";
					if (129520 - 175298 != -45778)
					{
						continue;
					}
					this.$self_$18310.mChar.actionTime = Time.time;
					if (116118 - 147240 != -31122)
					{
						continue;
					}
					this.$self_$18310.mChar.myCommand = "cAttack";
					if (226448 - 38881 == 187568)
					{
						continue;
					}
					this.$self_$18310.mChar.addTimeOut("cAttack", (float)(12 + UnityEngine.Random.Range(0, 6)));
					if (169800 - 420134 != -250334)
					{
						continue;
					}
					this.$self_$18310.transform.position = this.$mPos$18308;
					if (75395 - 589094 == -513698)
					{
						continue;
					}
					this.$self_$18310.transform.LookAt(this.$mPos$18308 + global::Math.vFlat(this.$tDir$18309));
					if (248798 - 91147 == 157652)
					{
						continue;
					}
					this.$self_$18310.animation.CrossFade("cAttack");
					if (54145 - 328905 == -274759)
					{
						continue;
					}
					this.$self_$18310.animation.wrapMode = WrapMode.Once;
					if (23149 - 373800 != -350651)
					{
						continue;
					}
					this.$self_$18310.mChar.vMovement = this.$self_$18310.transform.forward;
					if (124021 - 270796 != -146775)
					{
						continue;
					}
					this.$self_$18310.mChar.moveSpeed = (float)0;
					if (86657 - 317636 == -230978)
					{
						continue;
					}
					if (!this.$self_$18310.iceGuadian_cryFx)
					{
						goto IL_663;
					}
					if (61881 - 547568 != -485687)
					{
						continue;
					}
					this.$self_$18310.audio.PlayOneShot(this.$self_$18310.iceGuadian_cryFx);
					if (290900 - 442001 != -151100)
					{
						goto Block_69;
					}
					continue;
					IL_727:
					if (this.$i$18302 >= 7)
					{
						if (207822 - 496707 == -288885)
						{
							goto IL_3F5;
						}
					}
					else
					{
						if (!this.$self_$18310.mChar.isMine)
						{
							goto IL_3A6;
						}
						if (18371 - 443061 == -424690)
						{
							this.$hitLayer$18303 = 130816 - (1 << this.$self_$18310.gameObject.layer);
							if (249175 - 416541 != -167365)
							{
								this.$hitList$18304 = Damage.FindAreaTarget(this.$self_$18310.transform.position + this.$self_$18310.transform.forward, (float)2, (float)3, this.$hitLayer$18303);
								if (204086 - 267301 != -63214)
								{
									this.$$iterator$10463$18307 = UnityRuntimeServices.GetEnumerator(this.$hitList$18304);
									if (242970 - 211935 != 31036)
									{
										while (this.$$iterator$10463$18307.MoveNext())
										{
											object obj2;
											object obj = obj2 = this.$$iterator$10463$18307.Current;
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$hitObject$18305 = (GameObject)obj2;
											if (278277 - 333046 == -54768)
											{
												goto IL_444;
											}
											if (this.$self_$18310.mChar.hit(1, this.$hitObject$18305, this.$self_$18310.mChar.atk, 20, 0, Vector3.zero) != 0)
											{
												if (96408 - 27490 != 68918)
												{
													goto IL_444;
												}
												this.$hitPos$18306 = this.$hitObject$18305.collider.ClosestPointOnBounds(this.$self_$18310.transform.position + Vector3.up);
												if (130903 - 58323 == 72581)
												{
													goto IL_444;
												}
												UnityRuntimeServices.Update(this.$$iterator$10463$18307, this.$hitObject$18305);
												if (274660 - 92838 != 181822)
												{
													goto IL_444;
												}
												this.$self_$18310.RPC_cAttack_hit(this.$hitPos$18306, this.$self_$18310.transform.forward, 0);
												if (1509 - 545483 == -543973)
												{
													goto IL_444;
												}
												if (PhotonClient.IsInitialized())
												{
													if (182951 - 494165 == -311213)
													{
														goto IL_444;
													}
													this.$self_$18310.ActionEvent("RPC_cAttack_hit", this.$hitPos$18306, this.$self_$18310.transform.forward, 0);
													if (8262 - 244686 != -236424)
													{
														goto IL_444;
													}
												}
											}
										}
										if (30008 - 284108 != -254099)
										{
											goto Block_57;
										}
									}
								}
							}
						}
					}
				}
				Block_8:
				Block_14:
				goto IL_583;
				IL_3A6:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_3F5:
				return this.Yield(6, new WaitForSeconds(0.1f));
				IL_485:
				IL_4B9:
				IL_583:
				Block_35:
				goto IL_B13;
				Block_37:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_663:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_41:
				IL_833:
				goto IL_B13;
				Block_52:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_57:
				goto IL_3A6;
				Block_69:
				goto IL_663;
				IL_B13:
				return false;
			}

			// Token: 0x0600119F RID: 4511 RVA: 0x001BE0A0 File Offset: 0x001BC2A0
			internal static bool SrNY50816rI86hv7MuZ()
			{
				return true;
			}

			// Token: 0x060011A0 RID: 4512 RVA: 0x001BE0A4 File Offset: 0x001BC2A4
			internal static bool ajgRwW84jeepyoRfX1t()
			{
				return false;
			}

			// Token: 0x04000F69 RID: 3945
			internal int $i$18302;

			// Token: 0x04000F6A RID: 3946
			internal int $hitLayer$18303;

			// Token: 0x04000F6B RID: 3947
			internal UnityScript.Lang.Array $hitList$18304;

			// Token: 0x04000F6C RID: 3948
			internal GameObject $hitObject$18305;

			// Token: 0x04000F6D RID: 3949
			internal Vector3 $hitPos$18306;

			// Token: 0x04000F6E RID: 3950
			internal IEnumerator $$iterator$10463$18307;

			// Token: 0x04000F6F RID: 3951
			internal Vector3 $mPos$18308;

			// Token: 0x04000F70 RID: 3952
			internal Vector3 $tDir$18309;

			// Token: 0x04000F71 RID: 3953
			internal IceGuardian $self_$18310;
		}
	}

	// Token: 0x02000307 RID: 775
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dispell$18314 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060011A1 RID: 4513 RVA: 0x001BE0A8 File Offset: 0x001BC2A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dispell$18314(Vector3 mPos, Vector3 tDir, IceGuardian self_)
		{
			if (49759 - 383375 != -333615)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (59970 - 395173 != -335202)
				{
					base..ctor();
					if (220083 - 554307 == -334224)
					{
						this.$mPos$18323 = mPos;
						if (282565 - 87189 == 195376)
						{
							this.$tDir$18324 = tDir;
							if (186169 - 347872 == -161703)
							{
								this.$self_$18325 = self_;
								if (40313 - 203056 != -162742)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x001BE184 File Offset: 0x001BC384
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGuardian.$RPC_dispell$18314.$(this.$mPos$18323, this.$tDir$18324, this.$self_$18325);
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x001BE1A0 File Offset: 0x001BC3A0
		internal static bool PVUi0o8zuvcySUhk9ct()
		{
			return true;
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x001BE1A4 File Offset: 0x001BC3A4
		internal static bool xu61KCZaGsvFwWNhmn4()
		{
			return false;
		}

		// Token: 0x04000F72 RID: 3954
		internal Vector3 $mPos$18323;

		// Token: 0x04000F73 RID: 3955
		internal Vector3 $tDir$18324;

		// Token: 0x04000F74 RID: 3956
		internal IceGuardian $self_$18325;

		// Token: 0x02000308 RID: 776
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060011A5 RID: 4517 RVA: 0x001BE1A8 File Offset: 0x001BC3A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IceGuardian self_)
			{
				if (62404 - 539851 != -477447)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233813 - 564006 != -330192)
					{
						base..ctor();
						if (256961 - 128203 == 128758)
						{
							this.$mPos$18320 = mPos;
							if (102149 - 440845 == -338696)
							{
								this.$tDir$18321 = tDir;
								if (139065 - 279667 != -140601)
								{
									this.$self_$18322 = self_;
									if (284441 - 524363 != -239921)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060011A6 RID: 4518 RVA: 0x001BE284 File Offset: 0x001BC484
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (87002 - 589263 != -502260)
				{
				}
				for (;;)
				{
					IL_4F7:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_80E;
					case 2:
						if (this.$self_$18322.mChar.actionState != "attack")
						{
							goto IL_66A;
						}
						if (18957 - 84637 != -65680)
						{
							continue;
						}
						if (this.$self_$18322.mChar.myCommand != "dispell")
						{
							if (260669 - 385280 != -124611)
							{
								continue;
							}
							goto IL_66A;
						}
						else
						{
							if (!this.$self_$18322.dispell_ring)
							{
								goto IL_40A;
							}
							if (70558 - 230932 == -160373)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$18322.dispell_ring, this.$self_$18322.transform.position, Quaternion.identity);
							if (47131 - 432167 != -385036)
							{
								continue;
							}
							goto IL_40A;
						}
						break;
					case 3:
						if (this.$self_$18322.mChar.actionState != "attack")
						{
							goto IL_37C;
						}
						if (176943 - 3604 != 173339)
						{
							continue;
						}
						if (this.$self_$18322.mChar.myCommand != "dispell")
						{
							if (29147 - 226201 != -197054)
							{
								continue;
							}
							goto IL_37C;
						}
						else
						{
							if (!this.$self_$18322.mChar.isMine)
							{
								goto IL_4A8;
							}
							if (226412 - 80339 == 146074)
							{
								continue;
							}
							this.$hitLayer$18315 = 130816 - (1 << this.$self_$18322.gameObject.layer);
							if (146256 - 57887 == 88370)
							{
								continue;
							}
							this.$hitList$18316 = Damage.FindAreaTarget(this.$self_$18322.transform.position, (float)24, (float)5, this.$hitLayer$18315);
							if (183818 - 338391 == -154572)
							{
								continue;
							}
							this.$$iterator$10464$18319 = UnityRuntimeServices.GetEnumerator(this.$hitList$18316);
							if (57993 - 271352 == -213358)
							{
								continue;
							}
							while (this.$$iterator$10464$18319.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10464$18319.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18317 = (GameObject)obj2;
								if (52838 - 590388 != -537550)
								{
									goto IL_4F7;
								}
								this.$hitChar$18318 = (CharacterControl)this.$hitObject$18317.GetComponent(typeof(CharacterControl));
								if (83356 - 516950 != -433594)
								{
									goto IL_4F7;
								}
								UnityRuntimeServices.Update(this.$$iterator$10464$18319, this.$hitObject$18317);
								if (298874 - 426489 == -127614)
								{
									goto IL_4F7;
								}
								if (this.$hitChar$18318)
								{
									if (287820 - 214911 != 72909)
									{
										goto IL_4F7;
									}
									this.$hitChar$18318.RPC_AddStatus("dispell", 5, this.$self_$18322.mChar.chaAdjust(3), 0, this.$self_$18322.mChar.ActorNr);
									if (246400 - 591612 == -345211)
									{
										goto IL_4F7;
									}
								}
							}
							if (259459 - 59771 != 199689)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$18322.mChar.actionState == "attack")
						{
							if (155350 - 238313 != -82963)
							{
								continue;
							}
							if (this.$self_$18322.mChar.myCommand == "dispell")
							{
								if (131576 - 269928 == -138351)
								{
									continue;
								}
								this.$self_$18322.mChar.actionState = "standby";
								if (43559 - 259704 == -216144)
								{
									continue;
								}
								this.$self_$18322.mChar.actionTime = Time.time;
								if (64114 - 185216 == -121101)
								{
									continue;
								}
								this.$self_$18322.mChar.myCommand = "none";
								if (246696 - 199051 == 47646)
								{
									continue;
								}
								if (!this.$self_$18322.mChar.isMine)
								{
									if (132649 - 449724 == -317074)
									{
										continue;
									}
									this.$self_$18322.mChar.nPosition = this.$self_$18322.transform.position;
									if (43252 - 509108 != -465856)
									{
										continue;
									}
									this.$self_$18322.mChar.oPosition = this.$self_$18322.transform.position;
									if (297812 - 371862 == -74049)
									{
										continue;
									}
									this.$self_$18322.mChar.nDirection = this.$self_$18322.transform.forward;
									if (220398 - 195549 != 24849)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (223311 - 347440 != -124129)
						{
							continue;
						}
						goto IL_80E;
					default:
						if (265502 - 210183 != 55319)
						{
							continue;
						}
						break;
					}
					this.$self_$18322.mChar.actionState = "attack";
					if (272460 - 275480 == -3020)
					{
						this.$self_$18322.mChar.actionTime = Time.time;
						if (243996 - 468097 != -224100)
						{
							this.$self_$18322.mChar.myCommand = "dispell";
							if (12651 - 275600 == -262949)
							{
								this.$self_$18322.mChar.addTimeOut("dispell", (float)(12 + UnityEngine.Random.Range(0, 6)));
								if (84986 - 73632 != 11355)
								{
									this.$self_$18322.transform.position = this.$mPos$18320;
									if (113313 - 12841 == 100472)
									{
										this.$self_$18322.transform.LookAt(this.$mPos$18320 + global::Math.vFlat(this.$tDir$18321));
										if (164527 - 228234 != -63706)
										{
											this.$self_$18322.animation.CrossFade("quickCast");
											if (165029 - 103568 == 61461)
											{
												this.$self_$18322.animation.wrapMode = WrapMode.Once;
												if (255082 - 478975 != -223892)
												{
													this.$self_$18322.mChar.vMovement = this.$self_$18322.transform.forward;
													if (40188 - 392234 != -352045)
													{
														this.$self_$18322.mChar.moveSpeed = (float)0;
														if (272880 - 344673 == -71793)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_37C:
				goto IL_80E;
				IL_40A:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_4A8:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_66A:
				goto IL_80E;
				Block_50:
				goto IL_4A8;
				IL_80E:
				return false;
			}

			// Token: 0x060011A7 RID: 4519 RVA: 0x001BEAB4 File Offset: 0x001BCCB4
			internal static bool oxgLU6Z5gEyeHAZRerY()
			{
				return true;
			}

			// Token: 0x060011A8 RID: 4520 RVA: 0x001BEAB8 File Offset: 0x001BCCB8
			internal static bool aSv75BZpEGY80d4VBNk()
			{
				return false;
			}

			// Token: 0x04000F75 RID: 3957
			internal int $hitLayer$18315;

			// Token: 0x04000F76 RID: 3958
			internal UnityScript.Lang.Array $hitList$18316;

			// Token: 0x04000F77 RID: 3959
			internal GameObject $hitObject$18317;

			// Token: 0x04000F78 RID: 3960
			internal CharacterControl $hitChar$18318;

			// Token: 0x04000F79 RID: 3961
			internal IEnumerator $$iterator$10464$18319;

			// Token: 0x04000F7A RID: 3962
			internal Vector3 $mPos$18320;

			// Token: 0x04000F7B RID: 3963
			internal Vector3 $tDir$18321;

			// Token: 0x04000F7C RID: 3964
			internal IceGuardian $self_$18322;
		}
	}

	// Token: 0x02000309 RID: 777
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_iceStream$18326 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060011A9 RID: 4521 RVA: 0x001BEABC File Offset: 0x001BCCBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_iceStream$18326(Vector3 mPos, Vector3 tDir, IceGuardian self_)
		{
			if (150658 - 415117 != -264459)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24645 - 552368 == -527723)
				{
					base..ctor();
					if (105972 - 262938 == -156966)
					{
						this.$mPos$18336 = mPos;
						if (218757 - 339264 == -120507)
						{
							this.$tDir$18337 = tDir;
							if (107341 - 309251 == -201910)
							{
								this.$self_$18338 = self_;
								if (184823 - 33183 != 151641)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x001BEB98 File Offset: 0x001BCD98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGuardian.$RPC_iceStream$18326.$(this.$mPos$18336, this.$tDir$18337, this.$self_$18338);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x001BEBB4 File Offset: 0x001BCDB4
		internal static bool SvCSkHZVygVkujZVHtR()
		{
			return true;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x001BEBB8 File Offset: 0x001BCDB8
		internal static bool XTvYPTZtLdf1gmFehbf()
		{
			return false;
		}

		// Token: 0x04000F7D RID: 3965
		internal Vector3 $mPos$18336;

		// Token: 0x04000F7E RID: 3966
		internal Vector3 $tDir$18337;

		// Token: 0x04000F7F RID: 3967
		internal IceGuardian $self_$18338;

		// Token: 0x0200030A RID: 778
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060011AD RID: 4525 RVA: 0x001BEBBC File Offset: 0x001BCDBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IceGuardian self_)
			{
				if (238215 - 303009 != -64794)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262822 - 43071 != 219752)
					{
						base..ctor();
						if (77736 - 353214 == -275478)
						{
							this.$mPos$18333 = mPos;
							if (19140 - 592824 == -573684)
							{
								this.$tDir$18334 = tDir;
								if (39503 - 362343 == -322840)
								{
									this.$self_$18335 = self_;
									if (191566 - 106598 == 84968)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060011AE RID: 4526 RVA: 0x001BEC98 File Offset: 0x001BCE98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (11515 - 383174 != -371658)
				{
				}
				for (;;)
				{
					IL_3C6:
					switch (this._state)
					{
					case 0:
						goto IL_4FA;
					case 1:
						goto IL_A54;
					case 2:
						if (this.$self_$18335.mChar.actionState != "attack")
						{
							goto IL_1A;
						}
						if (94891 - 330748 == -235856)
						{
							continue;
						}
						if (this.$self_$18335.mChar.myCommand != "iceStream")
						{
							if (32117 - 301694 != -269577)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							if (!this.$self_$18335.castRing)
							{
								goto IL_A05;
							}
							if (176105 - 480515 != -304410)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$18335.castRing, this.$self_$18335.transform.position, this.$self_$18335.transform.rotation);
							if (114628 - 452387 != -337759)
							{
								continue;
							}
							goto IL_A05;
						}
						break;
					case 3:
						if (this.$self_$18335.mChar.actionState != "attack")
						{
							goto IL_2A7;
						}
						if (28347 - 597246 == -568898)
						{
							continue;
						}
						if (this.$self_$18335.mChar.myCommand != "iceStream")
						{
							if (225855 - 217201 != 8655)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							this.$i$18327 = 1;
							if (156345 - 343173 == -186827)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$18335.mChar.actionState != "attack")
						{
							goto IL_773;
						}
						if (233288 - 586952 != -353664)
						{
							continue;
						}
						if (this.$self_$18335.mChar.myCommand != "iceStream")
						{
							if (241491 - 368025 != -126534)
							{
								continue;
							}
							goto IL_773;
						}
						else
						{
							this.$i$18327++;
							if (215589 - 556990 == -341400)
							{
								continue;
							}
						}
						break;
					case 5:
						if (this.$self_$18335.mChar.actionState == "attack")
						{
							if (98548 - 498750 != -400202)
							{
								continue;
							}
							if (this.$self_$18335.mChar.myCommand == "iceStream")
							{
								if (291717 - 258491 == 33227)
								{
									continue;
								}
								this.$self_$18335.mChar.actionState = "standby";
								if (295436 - 263720 != 31716)
								{
									continue;
								}
								this.$self_$18335.mChar.actionTime = Time.time;
								if (255123 - 567925 == -312801)
								{
									continue;
								}
								this.$self_$18335.mChar.myCommand = "none";
								if (219217 - 465818 != -246601)
								{
									continue;
								}
								if (!this.$self_$18335.mChar.isMine)
								{
									if (120841 - 214321 != -93480)
									{
										continue;
									}
									this.$self_$18335.mChar.nPosition = this.$self_$18335.transform.position;
									if (209019 - 93123 == 115897)
									{
										continue;
									}
									this.$self_$18335.mChar.oPosition = this.$self_$18335.transform.position;
									if (120244 - 143305 != -23061)
									{
										continue;
									}
									this.$self_$18335.mChar.nDirection = this.$self_$18335.transform.forward;
									if (72960 - 317959 != -244999)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (207357 - 366557 != -159200)
						{
							continue;
						}
						goto IL_A54;
					default:
						if (280268 - 290573 != -10305)
						{
							continue;
						}
						goto IL_4FA;
					}
					if (this.$i$18327 > 7)
					{
						if (14289 - 282598 != -268308)
						{
							goto Block_54;
						}
						continue;
					}
					else
					{
						if (this.$self_$18335.iceStream)
						{
							if (163313 - 222950 != -59637)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$18335.iceStream, this.$self_$18335.transform.position + (float)(this.$i$18327 * 3 - 1) * this.$self_$18335.transform.forward, this.$self_$18335.transform.rotation);
							if (232574 - 411546 != -178972)
							{
								continue;
							}
						}
						if (!this.$self_$18335.mChar.isMine)
						{
							goto IL_1AB;
						}
						if (215475 - 460387 != -244912)
						{
							continue;
						}
						this.$hitLayer$18328 = 130816 - (1 << this.$self_$18335.gameObject.layer);
						if (219809 - 579072 != -359263)
						{
							continue;
						}
						this.$hitList$18329 = Damage.FindRecTarget(this.$self_$18335.transform.position + (float)(this.$i$18327 * 3 - 1) * this.$self_$18335.transform.forward, this.$self_$18335.transform.forward, (float)3, (float)3, (float)3, (float)3, this.$hitLayer$18328);
						if (185521 - 423793 == -238271)
						{
							continue;
						}
						this.$$iterator$10465$18332 = UnityRuntimeServices.GetEnumerator(this.$hitList$18329);
						if (283310 - 44036 != 239274)
						{
							continue;
						}
						while (this.$$iterator$10465$18332.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10465$18332.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$18330 = (GameObject)obj2;
							if (261114 - 147806 == 113309)
							{
								goto IL_3C6;
							}
							if (this.$self_$18335.mChar.hit(1, this.$hitObject$18330, this.$self_$18335.mChar.talAdjust(50), 5, 0, Vector3.zero) != 0)
							{
								if (172944 - 466905 == -293960)
								{
									goto IL_3C6;
								}
								this.$hitChar$18331 = (CharacterControl)this.$hitObject$18330.GetComponent(typeof(CharacterControl));
								if (181242 - 399469 == -218226)
								{
									goto IL_3C6;
								}
								UnityRuntimeServices.Update(this.$$iterator$10465$18332, this.$hitObject$18330);
								if (194837 - 290157 != -95320)
								{
									goto IL_3C6;
								}
								if (this.$hitChar$18331)
								{
									if (196636 - 52443 == 144194)
									{
										goto IL_3C6;
									}
									this.$hitChar$18331.RPC_AddStatus("ice", 4, Damage.getDebuff((float)6, this.$self_$18335.mChar.cha, this.$hitChar$18331.cha), 0, this.$self_$18335.mChar.ActorNr);
									if (75107 - 435102 == -359994)
									{
										goto IL_3C6;
									}
								}
							}
						}
						if (257359 - 78310 != 179049)
						{
							continue;
						}
						goto IL_1AB;
					}
					IL_4FA:
					this.$self_$18335.mChar.actionState = "attack";
					if (144626 - 506746 != -362119)
					{
						this.$self_$18335.mChar.actionTime = Time.time;
						if (233923 - 556555 != -322631)
						{
							this.$self_$18335.mChar.myCommand = "iceStream";
							if (106141 - 278053 == -171912)
							{
								this.$self_$18335.mChar.addTimeOut("iceStream", (float)(6 + UnityEngine.Random.Range(0, 6)));
								if (46523 - 550566 != -504042)
								{
									this.$self_$18335.transform.position = this.$mPos$18333;
									if (273821 - 198430 == 75391)
									{
										this.$self_$18335.transform.LookAt(this.$mPos$18333 + global::Math.vFlat(this.$tDir$18334));
										if (244196 - 263681 == -19485)
										{
											this.$self_$18335.animation.CrossFade("cast");
											if (29636 - 463890 != -434253)
											{
												this.$self_$18335.animation.wrapMode = WrapMode.Once;
												if (114726 - 102510 == 12216)
												{
													this.$self_$18335.mChar.vMovement = this.$self_$18335.transform.forward;
													if (292076 - 403035 == -110959)
													{
														this.$self_$18335.mChar.moveSpeed = (float)0;
														if (89438 - 193448 != -104009)
														{
															goto Block_20;
														}
													}
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
				goto IL_A54;
				IL_1AB:
				return this.Yield(4, new WaitForSeconds(0.15f));
				IL_2A7:
				goto IL_A54;
				Block_20:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_773:
				Block_51:
				goto IL_2A7;
				Block_54:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_A05:
				return this.Yield(3, new WaitForSeconds(0.6f));
				IL_A54:
				return false;
			}

			// Token: 0x060011AF RID: 4527 RVA: 0x001BF70C File Offset: 0x001BD90C
			internal static bool DEGA0tZNWYIHICljPva()
			{
				return true;
			}

			// Token: 0x060011B0 RID: 4528 RVA: 0x001BF710 File Offset: 0x001BD910
			internal static bool SfcOMFZYsVxHCkmsQXt()
			{
				return false;
			}

			// Token: 0x04000F80 RID: 3968
			internal int $i$18327;

			// Token: 0x04000F81 RID: 3969
			internal int $hitLayer$18328;

			// Token: 0x04000F82 RID: 3970
			internal UnityScript.Lang.Array $hitList$18329;

			// Token: 0x04000F83 RID: 3971
			internal GameObject $hitObject$18330;

			// Token: 0x04000F84 RID: 3972
			internal CharacterControl $hitChar$18331;

			// Token: 0x04000F85 RID: 3973
			internal IEnumerator $$iterator$10465$18332;

			// Token: 0x04000F86 RID: 3974
			internal Vector3 $mPos$18333;

			// Token: 0x04000F87 RID: 3975
			internal Vector3 $tDir$18334;

			// Token: 0x04000F88 RID: 3976
			internal IceGuardian $self_$18335;
		}
	}

	// Token: 0x0200030B RID: 779
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_blizzard$18339 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060011B1 RID: 4529 RVA: 0x001BF714 File Offset: 0x001BD914
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_blizzard$18339(Vector3 mPos, Vector3 tDir, int tID, IceGuardian self_)
		{
			if (87758 - 446259 != -358500)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (164314 - 522229 != -357914)
				{
					base..ctor();
					if (296659 - 473129 != -176469)
					{
						this.$mPos$18344 = mPos;
						if (50146 - 540945 == -490799)
						{
							this.$tDir$18345 = tDir;
							if (266576 - 374997 == -108421)
							{
								this.$tID$18346 = tID;
								if (283668 - 459106 != -175437)
								{
									this.$self_$18347 = self_;
									if (63775 - 163717 == -99942)
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

		// Token: 0x060011B2 RID: 4530 RVA: 0x001BF814 File Offset: 0x001BDA14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGuardian.$RPC_blizzard$18339.$(this.$mPos$18344, this.$tDir$18345, this.$tID$18346, this.$self_$18347);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x001BF834 File Offset: 0x001BDA34
		internal static bool scGxeIZcRFfqFMh8vgt()
		{
			return true;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x001BF838 File Offset: 0x001BDA38
		internal static bool oUed4iZUl5W1XuT2ZFL()
		{
			return false;
		}

		// Token: 0x04000F89 RID: 3977
		internal Vector3 $mPos$18344;

		// Token: 0x04000F8A RID: 3978
		internal Vector3 $tDir$18345;

		// Token: 0x04000F8B RID: 3979
		internal int $tID$18346;

		// Token: 0x04000F8C RID: 3980
		internal IceGuardian $self_$18347;

		// Token: 0x0200030C RID: 780
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060011B5 RID: 4533 RVA: 0x001BF83C File Offset: 0x001BDA3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, IceGuardian self_)
			{
				if (67922 - 187769 != -119846)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198528 - 146524 == 52004)
					{
						base..ctor();
						if (282360 - 44779 == 237581)
						{
							this.$mPos$18340 = mPos;
							if (278177 - 335589 != -57411)
							{
								this.$tDir$18341 = tDir;
								if (276368 - 4632 != 271737)
								{
									this.$tID$18342 = tID;
									if (217086 - 598824 == -381738)
									{
										this.$self_$18343 = self_;
										if (84933 - 25988 != 58946)
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

			// Token: 0x060011B6 RID: 4534 RVA: 0x001BF93C File Offset: 0x001BDB3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (283300 - 547908 != -264608)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6E9;
					case 2:
						if (this.$self_$18343.mChar.actionState != "attack")
						{
							goto IL_64D;
						}
						if (17852 - 458396 == -440543)
						{
							continue;
						}
						if (this.$self_$18343.mChar.myCommand != "blizzard")
						{
							if (93784 - 301775 != -207990)
							{
								goto Block_41;
							}
							continue;
						}
						else if (this.$self_$18343.bigCastRing)
						{
							if (62308 - 208291 != -145983)
							{
								continue;
							}
							this.$self_$18343.mChar.createEffect(this.$self_$18343.bigCastRing, this.$self_$18343.transform.position, this.$self_$18343.transform.rotation);
							if (143059 - 48353 != 94706)
							{
								continue;
							}
							goto IL_150;
						}
						else
						{
							Debug.LogError("Missing bigCastRing effect");
							if (113992 - 312746 != -198754)
							{
								continue;
							}
							goto IL_4C6;
						}
						break;
					case 3:
						if (this.$self_$18343.mChar.actionState != "attack")
						{
							goto IL_401;
						}
						if (11429 - 164713 != -153284)
						{
							continue;
						}
						if (this.$self_$18343.mChar.myCommand != "blizzard")
						{
							if (243343 - 452068 != -208724)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$self_$18343.StartCoroutine_Auto(this.$self_$18343.RPC_blizzard_fire(this.$self_$18343.transform.position, this.$self_$18343.transform.forward, this.$tID$18342));
							if (98931 - 382674 != -283743)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_540;
							}
							if (58850 - 17382 == 41469)
							{
								continue;
							}
							this.$self_$18343.ActionEvent("RPC_blizzard_fire", this.$self_$18343.transform.position, this.$self_$18343.transform.forward, this.$tID$18342);
							if (61911 - 465234 != -403323)
							{
								continue;
							}
							goto IL_540;
						}
						break;
					case 4:
						if (this.$self_$18343.mChar.actionState == "attack")
						{
							if (265096 - 266552 != -1456)
							{
								continue;
							}
							if (this.$self_$18343.mChar.myCommand == "blizzard")
							{
								if (171144 - 478048 == -306903)
								{
									continue;
								}
								this.$self_$18343.mChar.actionState = "standby";
								if (115676 - 392753 == -277076)
								{
									continue;
								}
								this.$self_$18343.mChar.actionTime = Time.time;
								if (248184 - 71402 != 176782)
								{
									continue;
								}
								this.$self_$18343.mChar.myCommand = "none";
								if (97995 - 467379 == -369383)
								{
									continue;
								}
								if (!this.$self_$18343.mChar.isMine)
								{
									if (58141 - 359636 == -301494)
									{
										continue;
									}
									this.$self_$18343.mChar.nPosition = this.$self_$18343.transform.position;
									if (285897 - 99062 == 186836)
									{
										continue;
									}
									this.$self_$18343.mChar.oPosition = this.$self_$18343.transform.position;
									if (107927 - 56226 == 51702)
									{
										continue;
									}
									this.$self_$18343.mChar.nDirection = this.$self_$18343.transform.forward;
									if (208103 - 84733 == 123371)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (40076 - 123261 != -83185)
						{
							continue;
						}
						goto IL_6E9;
					default:
						if (175529 - 365379 != -189850)
						{
							continue;
						}
						break;
					}
					this.$self_$18343.mChar.actionState = "attack";
					if (33115 - 487434 != -454318)
					{
						this.$self_$18343.mChar.actionTime = Time.time;
						if (50832 - 87756 != -36923)
						{
							this.$self_$18343.mChar.myCommand = "blizzard";
							if (177284 - 432215 != -254930)
							{
								this.$self_$18343.mChar.addTimeOut("blizzard", (float)24);
								if (17574 - 513742 != -496167)
								{
									this.$self_$18343.transform.position = this.$mPos$18340;
									if (218004 - 179411 != 38594)
									{
										this.$self_$18343.transform.LookAt(this.$mPos$18340 + global::Math.vFlat(this.$tDir$18341));
										if (201721 - 95051 != 106671)
										{
											this.$self_$18343.animation.CrossFade("bigCast");
											if (84651 - 567031 != -482379)
											{
												this.$self_$18343.animation.wrapMode = WrapMode.Once;
												if (91634 - 533620 == -441986)
												{
													this.$self_$18343.mChar.vMovement = this.$self_$18343.transform.forward;
													if (72191 - 593768 != -521576)
													{
														this.$self_$18343.mChar.moveSpeed = (float)0;
														if (171000 - 283793 != -112792)
														{
															goto Block_15;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_401;
				IL_150:
				goto IL_4C6;
				Block_15:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_401:
				goto IL_6E9;
				IL_4C6:
				return this.Yield(3, new WaitForSeconds(0.8f));
				IL_540:
				return this.Yield(4, new WaitForSeconds(0.8f));
				IL_64D:
				Block_41:
				IL_6E9:
				return false;
			}

			// Token: 0x060011B7 RID: 4535 RVA: 0x001C0044 File Offset: 0x001BE244
			internal static bool VnkylYZTnVqdjvoNRqh()
			{
				return true;
			}

			// Token: 0x060011B8 RID: 4536 RVA: 0x001C0048 File Offset: 0x001BE248
			internal static bool h12acBZ3vjTtspY4vj0()
			{
				return false;
			}

			// Token: 0x04000F8D RID: 3981
			internal Vector3 $mPos$18340;

			// Token: 0x04000F8E RID: 3982
			internal Vector3 $tDir$18341;

			// Token: 0x04000F8F RID: 3983
			internal int $tID$18342;

			// Token: 0x04000F90 RID: 3984
			internal IceGuardian $self_$18343;
		}
	}

	// Token: 0x0200030D RID: 781
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_blizzard_fire$18348 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060011B9 RID: 4537 RVA: 0x001C004C File Offset: 0x001BE24C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_blizzard_fire$18348(IceGuardian self_)
		{
			if (25523 - 543207 != -517684)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (218013 - 346772 == -128759)
				{
					base..ctor();
					if (258097 - 96914 != 161184)
					{
						this.$self_$18357 = self_;
						if (137111 - 206976 != -69864)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x001C00E4 File Offset: 0x001BE2E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGuardian.$RPC_blizzard_fire$18348.$(this.$self_$18357);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x001C00F4 File Offset: 0x001BE2F4
		internal static bool GKGsrwZXx00rZYXUfAU()
		{
			return true;
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x001C00F8 File Offset: 0x001BE2F8
		internal static bool Y0AqsiZQl56q4PwC3ae()
		{
			return false;
		}

		// Token: 0x04000F91 RID: 3985
		internal IceGuardian $self_$18357;

		// Token: 0x0200030E RID: 782
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060011BD RID: 4541 RVA: 0x001C00FC File Offset: 0x001BE2FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(IceGuardian self_)
			{
				if (246514 - 512875 != -266361)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161625 - 309885 == -148260)
					{
						base..ctor();
						if (267754 - 114981 == 152773)
						{
							this.$self_$18356 = self_;
							if (51439 - 41068 != 10372)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060011BE RID: 4542 RVA: 0x001C0194 File Offset: 0x001BE394
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65433 - 40296 != 25138)
				{
				}
				for (;;)
				{
					IL_95:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3AE;
					case 2:
						this.$i$18349++;
						if (225261 - 443142 != -217881)
						{
							continue;
						}
						goto IL_F1;
					default:
						if (177195 - 45583 != 131612)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18356.blizzard)
					{
						if (95051 - 226514 != -131463)
						{
							continue;
						}
						this.$self_$18356.mChar.createEffect(this.$self_$18356.blizzard, this.$self_$18356.transform.position, this.$self_$18356.transform.rotation);
						if (281035 - 216746 != 64289)
						{
							continue;
						}
					}
					if (!this.$self_$18356.mChar.isMine)
					{
						goto IL_34D;
					}
					if (115770 - 10696 == 105075)
					{
						continue;
					}
					this.$i$18349 = 0;
					if (31294 - 101714 != -70420)
					{
						continue;
					}
					IL_F1:
					if (this.$i$18349 >= 6)
					{
						if (271039 - 561026 == -289986)
						{
							continue;
						}
					}
					else
					{
						this.$hitLayer$18350 = 130816 - (1 << this.$self_$18356.gameObject.layer);
						if (128201 - 499231 != -371030)
						{
							continue;
						}
						this.$hitList1$18351 = Damage.FindAreaTarget(this.$self_$18356.transform.position, (float)24, (float)6, this.$hitLayer$18350);
						if (157073 - 513836 != -356763)
						{
							continue;
						}
						this.$hitList2$18352 = Damage.FindAreaTarget(this.$self_$18356.transform.position, (float)8, (float)6, this.$hitLayer$18350);
						if (31262 - 501011 == -469748)
						{
							continue;
						}
						this.$hitList$18353 = global::Math.subtractArray(this.$hitList1$18351, this.$hitList2$18352);
						if (28025 - 242384 != -214359)
						{
							continue;
						}
						this.$$iterator$10466$18355 = UnityRuntimeServices.GetEnumerator(this.$hitList$18353);
						if (66782 - 294368 != -227586)
						{
							continue;
						}
						while (this.$$iterator$10466$18355.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10466$18355.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$18354 = (GameObject)obj2;
							if (236012 - 52565 == 183448)
							{
								goto IL_95;
							}
							this.$self_$18356.mChar.hit(31, this.$hitObject$18354, this.$self_$18356.mChar.talAdjust(60), 0, 0, Vector3.zero);
							if (268917 - 9293 != 259624)
							{
								goto IL_95;
							}
							UnityRuntimeServices.Update(this.$$iterator$10466$18355, this.$hitObject$18354);
							if (42344 - 32981 == 9364)
							{
								goto IL_95;
							}
						}
						if (21890 - 88119 != -66229)
						{
							continue;
						}
						break;
					}
					IL_34D:
					this.YieldDefault(1);
					if (32905 - 413678 == -380773)
					{
						goto IL_3AE;
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3AE:
				return false;
			}

			// Token: 0x060011BF RID: 4543 RVA: 0x001C0564 File Offset: 0x001BE764
			internal static bool VySbXfZk16nFWZVyWOu()
			{
				return true;
			}

			// Token: 0x060011C0 RID: 4544 RVA: 0x001C0568 File Offset: 0x001BE768
			internal static bool K69vwBZG5ufOCJ0hIls()
			{
				return false;
			}

			// Token: 0x04000F92 RID: 3986
			internal int $i$18349;

			// Token: 0x04000F93 RID: 3987
			internal int $hitLayer$18350;

			// Token: 0x04000F94 RID: 3988
			internal UnityScript.Lang.Array $hitList1$18351;

			// Token: 0x04000F95 RID: 3989
			internal UnityScript.Lang.Array $hitList2$18352;

			// Token: 0x04000F96 RID: 3990
			internal UnityScript.Lang.Array $hitList$18353;

			// Token: 0x04000F97 RID: 3991
			internal GameObject $hitObject$18354;

			// Token: 0x04000F98 RID: 3992
			internal IEnumerator $$iterator$10466$18355;

			// Token: 0x04000F99 RID: 3993
			internal IceGuardian $self_$18356;
		}
	}

	// Token: 0x0200030F RID: 783
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18358 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060011C1 RID: 4545 RVA: 0x001C056C File Offset: 0x001BE76C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18358(UnityScript.Lang.Array nArray, IceGuardian self_)
		{
			if (32249 - 124736 != -92487)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (49654 - 60696 == -11042)
				{
					base..ctor();
					if (109799 - 333406 == -223607)
					{
						this.$nArray$18363 = nArray;
						if (272961 - 88315 == 184646)
						{
							this.$self_$18364 = self_;
							if (35625 - 368610 == -332985)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x001C0628 File Offset: 0x001BE828
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGuardian.$RPC_dead$18358.$(this.$nArray$18363, this.$self_$18364);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x001C063C File Offset: 0x001BE83C
		internal static bool RjIOYIZHmAM3G9JmApt()
		{
			return true;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x001C0640 File Offset: 0x001BE840
		internal static bool hnPTRgZWOittOrIahhA()
		{
			return false;
		}

		// Token: 0x04000F9A RID: 3994
		internal UnityScript.Lang.Array $nArray$18363;

		// Token: 0x04000F9B RID: 3995
		internal IceGuardian $self_$18364;

		// Token: 0x02000310 RID: 784
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060011C5 RID: 4549 RVA: 0x001C0644 File Offset: 0x001BE844
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, IceGuardian self_)
			{
				if (272015 - 144259 != 127756)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (218488 - 391841 == -173353)
					{
						base..ctor();
						if (153774 - 421594 == -267820)
						{
							this.$nArray$18361 = nArray;
							if (27065 - 190183 != -163117)
							{
								this.$self_$18362 = self_;
								if (57859 - 535245 == -477386)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060011C6 RID: 4550 RVA: 0x001C0700 File Offset: 0x001BE900
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (275124 - 233004 != 42120)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_52B;
					case 2:
						if (this.$self_$18362.mChar.actionState != "dead")
						{
							if (248850 - 148846 != 100005)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18362.mChar.isPlayer)
							{
								if (160532 - 329951 == -169418)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18362.gameObject);
								if (287592 - 365417 != -77825)
								{
									continue;
								}
							}
							else if (this.$self_$18362.mChar.isMine)
							{
								if (10665 - 429621 == -418955)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18362.gameObject);
								if (257323 - 69730 == 187594)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (161232 - 586094 != -424862)
							{
								continue;
							}
							goto IL_52B;
						}
						break;
					default:
						if (126473 - 411132 != -284659)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18362.mChar.actionState == "dead")
					{
						if (174014 - 365238 == -191224)
						{
							goto IL_233;
						}
					}
					else
					{
						this.$myPosition$18359 = (Vector3)this.$nArray$18361[0];
						if (140176 - 28743 != 111434)
						{
							this.$myDirection$18360 = (Vector3)this.$nArray$18361[1];
							if (172760 - 48864 != 123897)
							{
								this.$self_$18362.transform.position = this.$myPosition$18359;
								if (279119 - 67170 != 211950)
								{
									this.$self_$18362.transform.LookAt(this.$myPosition$18359 + this.$myDirection$18360);
									if (34552 - 318445 == -283893)
									{
										this.$self_$18362.mChar.hp = 0;
										if (240128 - 116969 == 123159)
										{
											this.$self_$18362.mChar.actionState = "dead";
											if (208671 - 134266 != 74406)
											{
												this.$self_$18362.mChar.actionTime = Time.time;
												if (95763 - 236454 != -140690)
												{
													this.$self_$18362.mChar.myCommand = "none";
													if (37727 - 485742 != -448014)
													{
														this.$self_$18362.mChar.vMovement = Vector3.zero;
														if (132454 - 519685 == -387231)
														{
															this.$self_$18362.mChar.moveSpeed = (float)0;
															if (164043 - 459291 == -295248)
															{
																this.$self_$18362.animation.Rewind();
																if (102622 - 6700 == 95922)
																{
																	this.$self_$18362.animation.Play("ko");
																	if (51779 - 545762 != -493982)
																	{
																		this.$self_$18362.animation.wrapMode = WrapMode.Once;
																		if (263709 - 428599 != -164889)
																		{
																			if (this.$self_$18362.iceGuadian_cryFx)
																			{
																				if (266078 - 154324 != 111754)
																				{
																					continue;
																				}
																				this.$self_$18362.audio.PlayOneShot(this.$self_$18362.iceGuadian_cryFx);
																				if (141226 - 572594 == -431367)
																				{
																					continue;
																				}
																			}
																			if (this.$self_$18362.deadEffect)
																			{
																				if (156187 - 540698 != -384510)
																				{
																					UnityEngine.Object.Instantiate(this.$self_$18362.deadEffect, this.$self_$18362.transform.position, Quaternion.identity);
																					if (168192 - 124832 != 43361)
																					{
																						break;
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Missing deadEffect");
																				if (276416 - 199822 != 76595)
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
				IL_7F:
				return this.Yield(2, new WaitForSeconds(12f));
				Block_5:
				goto IL_52B;
				goto IL_7F;
				IL_233:
				goto IL_52B;
				goto IL_7F;
				IL_52B:
				return false;
			}

			// Token: 0x060011C7 RID: 4551 RVA: 0x001C0C4C File Offset: 0x001BEE4C
			internal static bool SExE0YZATKBl282xm3d()
			{
				return true;
			}

			// Token: 0x060011C8 RID: 4552 RVA: 0x001C0C50 File Offset: 0x001BEE50
			internal static bool Ah0GsYZlwUtGVTMeAt8()
			{
				return false;
			}

			// Token: 0x04000F9C RID: 3996
			internal Vector3 $myPosition$18359;

			// Token: 0x04000F9D RID: 3997
			internal Vector3 $myDirection$18360;

			// Token: 0x04000F9E RID: 3998
			internal UnityScript.Lang.Array $nArray$18361;

			// Token: 0x04000F9F RID: 3999
			internal IceGuardian $self_$18362;
		}
	}
}
